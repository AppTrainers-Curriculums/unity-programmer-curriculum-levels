// Convert each level's workbook markdown (Assets/Levels/LevelN/Docs~/workbook/)
// into Starlight doc pages under src/content/docs/<slug>/, one page per chapter
// plus an intro page, and an "All the Code" page under src/content/docs/code/.
import fs from 'fs';
import path from 'path';
import { fileURLToPath } from 'url';
import { levels, downloads, downloadPath } from '../levels.config.mjs';
import { readWorkbook, pageTitle, sidebarMeta } from './workbook.mjs';
import { buildCodePage } from './code-page.mjs';

const __dirname = path.dirname(fileURLToPath(import.meta.url));
const ROOT = path.join(__dirname, '..');
const OUT = path.join(ROOT, 'src', 'content', 'docs');
const CODE_OUT = path.join(OUT, 'code');
const REPO = path.join(ROOT, '..');
const PUBLIC = path.join(ROOT, 'public');

// Split markdown into prose and fenced-code chunks, so the prose rewrites below
// never touch code.
function chunks(text) {
  const out = [];
  let prose = [];
  let fence = null;
  for (const line of text.split('\n')) {
    if (!fence && line.startsWith('```')) {
      out.push({ prose: prose.join('\n') });
      prose = [];
      fence = { lang: line.slice(3).trim(), lines: [] };
    } else if (fence && line.trim() === '```') {
      out.push(fence);
      fence = null;
    } else {
      (fence ? fence.lines : prose).push(line);
    }
  }
  if (fence) throw new Error(`Unclosed code fence: \`\`\`${fence.lang}`);
  out.push({ prose: prose.join('\n') });
  return out;
}

// > **Tip:** / **Note:** / **Watch out:** quotes → Starlight asides. Any other
// quote ("> **You just built a complete program:** …") becomes a note with its
// lead-in kept.
const CALLOUTS = { Tip: ':::tip', Note: ':::note', 'Watch out': ':::caution[Watch out]' };
const capitalise = (s) => s.replace(/^[a-z]/, (c) => c.toUpperCase());

function callout(quote) {
  const body = quote.split('\n').map((l) => l.replace(/^>\s?/, '')).join('\n');
  const m = body.match(/^\*\*(Tip|Note|Watch out):\*\*\s*/);
  if (!m) return `:::note\n${body}\n:::`;
  return `${CALLOUTS[m[1]]}\n${capitalise(body.slice(m[0].length))}\n:::`;
}

// The books never use raw HTML, but a type name in running text, such as
// UnityAction<float> in an error message, would be read as an HTML tag and
// vanish. Escape every tag-like `<` outside code spans (which show it as-is),
// except one the book already escaped as `\<`: turning that into `\&lt;` would
// print a literal "&lt;".
const CODE_SPAN = /(`+)[\s\S]*?\1/g;
const escapeTags = (s) => s.replace(/(?<!\\)((?:\\\\)*)<(?=[A-Za-z/!])/g, '$1&lt;');

function escapeTagsOutsideCode(text) {
  let out = '';
  let last = 0;
  for (const m of text.matchAll(CODE_SPAN)) {
    out += escapeTags(text.slice(last, m.index)) + m[0];
    last = m.index + m[0].length;
  }
  return out + escapeTags(text.slice(last));
}

function transformProse(text) {
  text = escapeTagsOutsideCode(text);
  text = text.replace(/^\\newpage.*$/gm, '');

  // Beat headings get an icon.
  text = text.replace(/^###\s+Idea\b/gm, '### 💡 Idea');
  text = text.replace(/^###\s+Do it/gm, '### ⌨️ Do it');
  text = text.replace(/^###\s+Test it/gm, '### ▶️ Test it');
  text = text.replace(/^###\s+Challenge\b/gm, '### 🧠 Challenge');

  // **Goal:** <paragraph>  ->  :::tip[Goal] aside
  // (?![\s\S]) is the end of the text; `$` would stop at the first line end.
  text = text.replace(/^\*\*Goal:\*\*\s*([\s\S]*?)(?=\n\n|\n*(?![\s\S]))/gm,
    (_, body) => `:::tip[Goal]\n${capitalise(body.trim())}\n:::`);

  return text.replace(/^>.*(?:\n>.*)*/gm, callout);
}

// Turn our custom markdown flavour into Starlight-friendly markdown.
function transform(text) {
  const parts = chunks(text);
  return parts
    .map((c, i) => {
      if ('prose' in c) return transformProse(c.prose);

      let open = '```' + c.lang;
      // ```csharp:File.cs  ->  ```csharp title="File.cs"  (filename tab + copy button)
      const file = c.lang.match(/^([A-Za-z0-9]+):(.+)$/);
      if (file) open = `\`\`\`${file[1]} title="${file[2].trim()}"`;

      // A plain block is what the Console prints (the PDF's grey box) when it
      // sits straight under a C# example, or when the paragraph introducing it
      // says so ("The Console shows this message."). Anything else plain is a
      // diagram, or text on the game screen.
      const prose = parts[i - 1].prose;
      const underCsharp = !prose.trim() && parts[i - 2]?.lang?.startsWith('csharp');
      const saysConsole = /\bConsole\b/.test(prose.trim().split(/\n\s*\n/).pop());
      if (!c.lang && (underCsharp || saysConsole)) {
        open = '```text title="Console" frame="terminal"';
      }
      return [open, ...c.lines, '```'].join('\n');
    })
    .join('\n')
    .replace(/\n{3,}/g, '\n\n')
    .trim() + '\n';
}

function frontMatter(p) {
  const { label, badge } = sidebarMeta(p);
  const q = JSON.stringify; // a JSON string is a valid YAML double-quoted scalar
  const fm = ['---', `title: ${q(pageTitle(p))}`, 'sidebar:', `  label: ${q(label)}`];
  if (badge) fm.push('  badge:', `    text: ${q(badge.text)}`, `    class: ${q(badge.class)}`);
  fm.push('---');
  return fm.join('\n');
}

function build(level) {
  const pages = readWorkbook(level);
  const outDir = path.join(OUT, level.slug);
  fs.rmSync(outDir, { recursive: true, force: true });
  fs.mkdirSync(outDir, { recursive: true });

  for (const p of pages) {
    fs.writeFileSync(
      path.join(outDir, `${p.slug}.md`),
      `${frontMatter(p)}\n\n${transform(p.lines.join('\n'))}`
    );
  }

  // Code-only companion. It lives OUTSIDE the level directory, under code/,
  // on purpose: encrypt.mjs locks dist/<slug>/, so a page in there would demand
  // the level password. Students who only need the code can read this one.
  // Written directly (not through transform()) — it is generated markdown, not
  // workbook prose. Build chapters only: the C# Concept examples are for trying
  // out, not part of the game.
  const chapters = pages.filter((p) => p.kind === 'chapter');
  const code = buildCodePage(level, chapters);
  fs.mkdirSync(CODE_OUT, { recursive: true });
  fs.writeFileSync(path.join(CODE_OUT, `${level.slug}.md`), code.body);

  const concepts = pages.filter((p) => p.kind === 'concept').length;
  console.log(
    `${level.slug}: ${pages.length} pages (${chapters.length} chapters, ${concepts} C# Concepts)` +
      ` + code page (${code.whole} complete files, ${code.snippet} snippets)`
  );
}

fs.mkdirSync(OUT, { recursive: true });
// Remove any stale pages for levels that are now unpublished.
levels
  .filter((l) => !l.published)
  .forEach((l) => {
    fs.rmSync(path.join(OUT, l.slug), { recursive: true, force: true });
    fs.rmSync(path.join(CODE_OUT, `${l.slug}.md`), { force: true });
  });
levels.filter((l) => l.published).forEach(build);

// The home page's downloads, copied from the Unity project. PDFs are in Git LFS:
// without `git lfs pull`, the file on disk is a small text pointer, and copying
// that would publish a broken PDF.
fs.rmSync(path.join(PUBLIC, 'files'), { recursive: true, force: true });
for (const d of downloads) {
  const from = path.join(REPO, d.src);
  const head = fs.readFileSync(from).subarray(0, 64).toString('latin1');
  if (head.startsWith('version https://git-lfs')) {
    throw new Error(`${d.src} is a Git LFS pointer, not the file: run  git lfs pull`);
  }
  const to = path.join(PUBLIC, downloadPath(d));
  fs.mkdirSync(path.dirname(to), { recursive: true });
  fs.copyFileSync(from, to);
  console.log(`download: ${d.src} -> public/${downloadPath(d)}`);
}
console.log('import done ->', path.relative(ROOT, OUT));
