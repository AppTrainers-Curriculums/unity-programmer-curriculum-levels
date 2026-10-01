// Assemble the Level 2 books.
//
// The three Level 2 games (Mini Golf, Space Shooter, Tank Arena) each have a
// fully guided book, and all three teach the same C# Concept chapters. Those
// chapters live once, here in Level2-Shared/Docs~/concepts/, and each game's
// book source, Docs~/workbook/book.md, pulls them in where that game needs
// them:
//
//   {{concept:lists}}     on a line of its own: the whole Lists chapter
//   {{include:name}}      on a line of its own: shared/name.md, e.g. the
//                         exam-style questions and cheat sheet every book ends with
//   {{ref:lists}}         anywhere: "C# 5", the number the chapter got in this book
//   {{num:lists}}         anywhere: just the number, "5"
//
// The shared chapters are written with unnumbered headings ("## C# — Lists").
// This script numbers every C# chapter in book order, fills in the references,
// checks that each book includes every concept once and after the concepts it
// builds on, and writes Docs~/workbook/workbook.md: the file the PDF builder
// and the course website read.
//
//   node assemble.mjs            assemble every Level2-*/Docs~/workbook/book.md
//   node assemble.mjs --check    fail if any workbook.md is out of date
//
// Edit book.md or a concept file, never workbook.md: it's rebuilt from them.
import fs from 'fs';
import path from 'path';
import { fileURLToPath } from 'url';

const HERE = path.dirname(fileURLToPath(import.meta.url));       // Level2-Shared/Docs~
const LEVELS = path.join(HERE, '..', '..');                       // Assets/Levels
const CONCEPTS = path.join(HERE, 'concepts');
const SHARED = path.join(HERE, 'shared');

// Every Level 2 C# Concept, with the concepts it builds on (which must come
// earlier in the book).
export const CONCEPT_LIST = {
  properties:   { file: 'properties-and-constructors.md', needs: [] },
  modifiers:    { file: 'static-const-readonly.md',       needs: ['properties'] },
  methods:      { file: 'methods-in-depth.md',            needs: [] },
  numbers:      { file: 'numbers-and-conversions.md',     needs: [] },
  lists:        { file: 'lists.md',                       needs: [] },
  dictionaries: { file: 'dictionaries.md',                needs: ['methods', 'lists'] },
  events:       { file: 'event-functions.md',             needs: [] },
  components:   { file: 'components.md',                  needs: ['methods', 'events'] },
  vectors:      { file: 'vectors.md',                     needs: [] },
  coroutines:   { file: 'coroutines.md',                  needs: [] },
  input:        { file: 'mouse-and-touch.md',             needs: ['vectors'] },
  raycasts:     { file: 'raycasts.md',                    needs: ['methods', 'vectors', 'input'] },
  uievents:     { file: 'ui-events.md',                   needs: ['methods', 'events'] },
  null:         { file: 'null-and-debugging.md',          needs: ['components'] },
  docs:         { file: 'unity-docs.md',                  needs: ['methods'] },
};

const INCLUDE = /^\{\{concept:([a-z]+)\}\}\s*$/;
const SHARED_INCLUDE = /^\{\{include:([a-z0-9-]+)\}\}\s*$/;
const UNNUMBERED = /^## C# — (.+)$/;

export function assemble(bookPath) {
  const errors = [];
  const where = path.relative(LEVELS, bookPath);
  const included = [];

  // 1. Expand the includes.
  const lines = [];
  let inFence = false;
  for (const line of fs.readFileSync(bookPath, 'utf8').split('\n')) {
    if (line.startsWith('```')) inFence = !inFence;
    const shared = !inFence && line.match(SHARED_INCLUDE);
    if (shared) {
      const file = path.join(SHARED, shared[1] + '.md');
      if (!fs.existsSync(file)) {
        errors.push(`no shared file ${shared[1]}.md`);
        continue;
      }
      lines.push(...fs.readFileSync(file, 'utf8').trim().split('\n'));
      continue;
    }
    const m = !inFence && line.match(INCLUDE);
    if (!m) {
      lines.push(line);
      continue;
    }
    const id = m[1];
    const concept = CONCEPT_LIST[id];
    if (!concept) {
      errors.push(`unknown concept "${id}"`);
      continue;
    }
    if (included.includes(id)) errors.push(`concept "${id}" is included twice`);
    for (const need of concept.needs) {
      if (!included.includes(need)) errors.push(`concept "${id}" must come after "${need}"`);
    }
    included.push(id);
    const body = fs.readFileSync(path.join(CONCEPTS, concept.file), 'utf8').trim();
    if (!UNNUMBERED.test(body.split('\n')[0])) errors.push(`${concept.file} must start with "## C# — Title"`);
    lines.push(`{{start:${id}}}`, ...body.split('\n'));
  }
  for (const id of Object.keys(CONCEPT_LIST)) {
    if (!included.includes(id)) errors.push(`concept "${id}" is missing: every book teaches every Level 2 concept`);
  }

  // 2. Number every C# chapter in book order, and remember each concept's number.
  const numbers = {};
  let n = 0;
  let pending = null;
  const out = [];
  inFence = false;
  for (const line of lines) {
    if (line.startsWith('```')) inFence = !inFence;
    const start = !inFence && line.match(/^\{\{start:([a-z]+)\}\}$/);
    if (start) {
      pending = start[1];
      continue;
    }
    const h = !inFence && (line.match(UNNUMBERED) || line.match(/^## C# (\d+) — (.+)$/));
    if (h) {
      if (h.length === 3) errors.push(`number C# chapters with "## C# — Title", not "## C# ${h[1]}": "${line}"`);
      n += 1;
      if (pending) {
        numbers[pending] = n;
        pending = null;
      }
      out.push(`## C# ${n} — ${h[h.length - 1]}`);
      continue;
    }
    out.push(line);
  }

  // 3. Fill in the references.
  let text = out.join('\n').replace(/\{\{(ref|num):([a-z]+)\}\}/g, (all, kind, id) => {
    if (!(id in numbers)) {
      errors.push(`${all} points to a concept this book doesn't include`);
      return all;
    }
    return kind === 'ref' ? `C# ${numbers[id]}` : String(numbers[id]);
  });
  const left = text.match(/\{\{[^}]*\}\}/g);
  if (left) errors.push(`unresolved markers: ${[...new Set(left)].join(', ')}`);

  text = text.replace(/\n{3,}/g, '\n\n').trimEnd() + '\n';
  if (errors.length) throw new Error(`${where}:\n  - ${errors.join('\n  - ')}`);
  return { text, concepts: n, chapters: (text.match(/^## Chapter \d+ — /gm) || []).length };
}

function main() {
  const check = process.argv.includes('--check');
  const books = fs
    .readdirSync(LEVELS)
    .filter((d) => /^Level2-/.test(d))
    .map((d) => path.join(LEVELS, d, 'Docs~', 'workbook', 'book.md'))
    .filter((p) => fs.existsSync(p));
  if (!books.length) throw new Error('No Level2-*/Docs~/workbook/book.md found.');

  let stale = 0;
  for (const book of books) {
    const { text, concepts, chapters } = assemble(book);
    const target = path.join(path.dirname(book), 'workbook.md');
    const name = path.relative(LEVELS, target);
    const current = fs.existsSync(target) ? fs.readFileSync(target, 'utf8') : null;
    if (check) {
      if (current !== text) {
        stale += 1;
        console.log(`OUT OF DATE  ${name}`);
      } else {
        console.log(`up to date   ${name}`);
      }
      continue;
    }
    if (current !== text) fs.writeFileSync(target, text);
    console.log(`${current === text ? 'unchanged' : 'wrote    '}  ${name}  (${chapters} chapters, ${concepts} C# Concepts)`);
  }
  if (stale) {
    console.log(`\n${stale} workbook(s) out of date: run  node assemble.mjs`);
    process.exit(1);
  }
}

if (process.argv[1] && path.resolve(process.argv[1]) === fileURLToPath(import.meta.url)) {
  try {
    main();
  } catch (e) {
    console.error(e.message);
    process.exit(1);
  }
}
