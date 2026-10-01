// Check the code in the Level 3 books: compile what students type, chapter by
// chapter, with Unity's own compiler and references.
//
//   node check-code.mjs                 every Level3-*/Docs~/workbook/workbook.md
//   node check-code.mjs path/to/workbook.md
//
// It walks each assembled book from top to bottom:
//
// - In a build chapter (## Chapter N — …), a ```csharp block that holds a whole
//   script (a class or enum declared at the left margin) becomes that
//   script's current version, and the current version of every script shown
//   so far is compiled together: the student's project as it stands after that
//   step. A named card (```csharp:File.cs) must also match Scripts/ byte for
//   byte.
// - In a C# Concept chapter (## C# N — …), each example is compiled on its
//   own, with the chapter's earlier classes beside it. An example that is only
//   statements is wrapped in a Practice class's Start(); one that is only
//   fields and methods is wrapped in a class.
// - A block with "error CS" in it shows a mistake on purpose, and a block with
//   "…" in it leaves parts of a script out ("// … as before …"): both are skipped.
//
// It needs Unity 6000.6 (set UNITY_APP to use another install) and the
// project's Library folder: open the project in Unity once, so that Unity has
// compiled a Level 3 game and written its compiler arguments
// (Library/Bee/artifacts/*/Curriculum.Level3.*.rsp). Set UNITY_PROJECT to
// check against another copy of the project.
import fs from 'fs';
import os from 'os';
import path from 'path';
import { execFileSync } from 'child_process';
import { fileURLToPath } from 'url';

const HERE = path.dirname(fileURLToPath(import.meta.url));                 // Level3-Shared/Docs~
const LEVELS = path.join(HERE, '..', '..');                                 // Assets/Levels
const PROJECT = process.env.UNITY_PROJECT || path.join(LEVELS, '..', '..');
const UNITY = process.env.UNITY_APP || '/Applications/Unity/Hub/Editor/6000.6.3f1/Unity.app';
const DOTNET = path.join(UNITY, 'Contents/Resources/Scripting/DotNetSdk/dotnet');
const CSC = path.join(UNITY, 'Contents/Resources/Scripting/DotNetSdk/sdk/8.0.318/Roslyn/bincore/csc.dll');

const USINGS = [
  'using System;', 'using System.Collections;', 'using System.Collections.Generic;', 'using TMPro;',
  'using UnityEngine;', 'using UnityEngine.EventSystems;', 'using UnityEngine.InputSystem;', 'using UnityEngine.UI;',
].join('\n');

// Unity's compiler arguments for a Level 3 game's runtime assembly: its
// references, defines and warning settings, without its own files.
function unityArguments() {
  const artifacts = path.join(PROJECT, 'Library', 'Bee', 'artifacts');
  if (!fs.existsSync(artifacts)) throw new Error(`No ${artifacts}: open the project in Unity once first.`);
  for (const dag of fs.readdirSync(artifacts)) {
    const dir = path.join(artifacts, dag);
    if (!fs.statSync(dir).isDirectory()) continue;
    const rsp = fs.readdirSync(dir).find((f) => /^Curriculum\.Level3\.(?!Shared)[A-Za-z]+\.rsp$/.test(f));
    if (rsp) {
      return fs
        .readFileSync(path.join(dir, rsp), 'utf8')
        .split('\n')
        .filter((l) => /^(-r:|-define:|-langversion:|\/nowarn:|\/utf8output|\/nologo|\/RuntimeMetadataVersion)/.test(l));
    }
  }
  throw new Error('No Curriculum.Level3.*.rsp in Library/Bee/artifacts: let Unity compile the project first.');
}

let ARGUMENTS = null;
let runs = 0;

// Compiles files ({ name: code }) as one assembly. Returns the errors and
// warnings, each "File.cs(line,col): error CS0000: message".
function compile(files) {
  ARGUMENTS ??= unityArguments();
  runs += 1;
  const dir = fs.mkdtempSync(path.join(os.tmpdir(), 'check-code-'));
  const sources = [];
  for (const [name, code] of Object.entries(files)) {
    const file = path.join(dir, name);
    fs.writeFileSync(file, code);
    sources.push(`"${file}"`);
  }
  const rsp = path.join(dir, 'build.rsp');
  fs.writeFileSync(rsp, [...ARGUMENTS, '-target:library', `-out:"${path.join(dir, 'out.dll')}"`, ...sources].join('\n'));
  let output = '';
  try {
    output = execFileSync(DOTNET, [CSC, `@${rsp}`], { cwd: PROJECT, encoding: 'utf8', stdio: ['ignore', 'pipe', 'pipe'] });
  } catch (e) {
    output = (e.stdout || '') + (e.stderr || '');
  }
  fs.rmSync(dir, { recursive: true, force: true });
  return output
    .split('\n')
    .filter((l) => /(error|warning) CS\d+/.test(l))
    .map((l) => l.replace(dir + path.sep, '').replace(/\[[^\]]*\]$/, '').trim());
}

// The name of each class, struct or enum declared at the left margin.
function topLevelTypes(code) {
  const names = [];
  for (const m of code.matchAll(/^(?:\[[^\]]*\]\s*)*(?:public |internal )?(?:static |abstract |sealed )*(?:class|struct|enum) (\w+)/gm)) {
    names.push(m[1]);
  }
  return names;
}

function checkBook(book) {
  const where = path.relative(LEVELS, book);
  const scripts = path.join(path.dirname(book), '..', '..', 'Scripts');
  const lines = fs.readFileSync(book, 'utf8').split('\n');
  const problems = [];
  const current = {};          // the student's scripts: name → code
  let chapter = null;          // { title, kind: 'build' | 'concept', classes: {} }
  let practice = 0;
  let cards = 0;
  let versions = 0;
  let examples = 0;

  for (let i = 0; i < lines.length; i++) {
    const line = lines[i];
    const heading = line.match(/^## (Chapter \d+|C# \d+|Section \d+) — (.+)$/) || (line.match(/^#{1,2} /) ? [line, line, ''] : null);
    if (heading && !line.startsWith('###')) {
      const kind = heading[1].startsWith('Chapter') ? 'build' : heading[1].startsWith('C#') ? 'concept' : 'other';
      chapter = { title: line.replace(/^#+ /, ''), kind, classes: {} };
      continue;
    }
    const fence = line.match(/^```csharp(?::(\S+))?\s*$/);
    if (!fence) continue;
    const start = i + 1;
    while (i + 1 < lines.length && !lines[i + 1].startsWith('```')) i++;
    const code = lines.slice(start, i + 1).join('\n') + '\n';
    i++;                                                   // the closing fence
    if (!chapter || /error CS\d+/.test(code) || code.includes('…')) continue;

    if (fence[1]) {
      cards++;
      const real = path.join(scripts, fence[1]);
      if (!fs.existsSync(real)) problems.push(`${chapter.title}: card ${fence[1]} has no file in Scripts/`);
      else if (fs.readFileSync(real, 'utf8') !== code) problems.push(`${chapter.title}: card ${fence[1]} differs from Scripts/${fence[1]}`);
    }

    const types = topLevelTypes(code);
    if (chapter.kind === 'build') {
      if (types.length) {
        // Unity compiles as soon as a script is saved, so every step must leave
        // a project that compiles.
        const name = fence[1] ? fence[1].replace(/\.cs$/, '') : types[0];
        current[name] = code;
        versions++;
        const files = {};
        for (const [script, text] of Object.entries(current)) files[script + '.cs'] = text;
        for (const message of compile(files)) problems.push(`${chapter.title}, after ${name} (line ${start}): ${message}`);
      }
      continue;
    }
    if (chapter.kind !== 'concept') continue;

    // A C# Concept example, with the chapter's earlier classes beside it.
    examples++;
    const files = {};
    for (const [name, other] of Object.entries(chapter.classes)) {
      if (!types.includes(name)) files[name + '.cs'] = other;
    }
    let messages;
    if (types.length) {
      files[types[0] + '.cs'] = /^using /m.test(code) ? code : `${USINGS}\n${code}`;
      for (const name of types) chapter.classes[name] = files[types[0] + '.cs'];
      messages = compile(files);
    } else {
      // Statements, or fields and methods? Try it as statements in Start()
      // first, then as the members of a class.
      practice++;
      const wrap = (body) => `${USINGS}\npublic class Example${practice} : MonoBehaviour\n{\n${body}\n}\n`;
      files[`Example${practice}.cs`] = wrap(`    void Start()\n    {\n${code}\n    }`);
      messages = compile(files);
      if (messages.some((m) => / error /.test(m))) {
        files[`Example${practice}.cs`] = wrap(code);
        const asMembers = compile(files);
        if (!asMembers.some((m) => / error /.test(m))) messages = asMembers;
      }
    }
    for (const message of messages) {
      problems.push(`${chapter.title}, the example at line ${start}: ${message}`);
    }
  }
  return { where, problems, cards, versions, examples };
}

function main() {
  const args = process.argv.slice(2);
  const books = args.length
    ? args.map((a) => path.resolve(a))
    : fs
        .readdirSync(LEVELS)
        .filter((d) => /^Level3-/.test(d))
        .map((d) => path.join(LEVELS, d, 'Docs~', 'workbook', 'workbook.md'))
        .filter((p) => fs.existsSync(p));
  if (!books.length) throw new Error('No Level3-*/Docs~/workbook/workbook.md found: run node assemble.mjs first.');
  let failed = 0;
  for (const book of books) {
    const { where, problems, cards, versions, examples } = checkBook(book);
    console.log(`${problems.length ? 'PROBLEMS' : 'ok      '}  ${where}  (${versions} script versions, ${cards} cards, ${examples} C# examples)`);
    for (const p of problems) console.log(`  - ${p}`);
    failed += problems.length;
  }
  console.log(`${runs} compiles`);
  if (failed) process.exit(1);
}

try {
  main();
} catch (e) {
  console.error(e.message);
  process.exit(1);
}
