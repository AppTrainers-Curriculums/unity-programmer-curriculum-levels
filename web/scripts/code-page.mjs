// Build the "All the Code" companion page for a level: every code block from
// its build chapters, in chapter order, stripped of the prose — so a student
// can copy each step without hunting through the text.
//
// A workbook block is one of two things, and the page has to say which:
//   * a complete file  — paste it over the whole file
//   * a snippet        — a method or field that goes inside a file you already
//                        have; the chapter page shows where
// We detect that structurally (a col-0 `using` or `class` means a whole file),
// never by guessing. A whole file the workbook leaves unnamed is named after
// its class: Unity requires the two to match. Snippets that carry no filename
// are left unlabelled on purpose: the nearest filename in the prose is reliably
// the WRONG one, and a wrong filename is worse than none.

const FENCE_OPEN = /^```([A-Za-z0-9]+)(?::(.+))?$/;
const IS_WHOLE_FILE = [
  /^using\s/m,
  // A file may open straight into a namespace, which indents its class.
  /^namespace\s/m,
  /^(?:public |internal |abstract |sealed |static |partial )*class\s/m,
];
const CLASS_NAME = /^\s*(?:public |internal |abstract |sealed |static |partial )*class\s+(\w+)/m;

// The instruction that introduces a block: the last sentence of the paragraph
// just above it ("Open `GameManager.cs` and add the two marked lines:"), with
// list markers stripped.
function captionFor(lines, fenceIndex) {
  let i = fenceIndex - 1;
  while (i >= 0 && !lines[i].trim()) i--;
  // Two fences back to back: there is no prose to quote, and walking further
  // would scrape the previous block's own source as if it were a sentence.
  if (i < 0 || lines[i].trim().startsWith('```')) return '';
  const para = [];
  while (i >= 0 && lines[i].trim()) {
    if (lines[i].trim().startsWith('```')) return '';
    para.unshift(lines[i].trim());
    i--;
  }
  if (!para.length) return '';
  const text = para.join(' ').replace(/\s+/g, ' ');
  const sentences = text.split(/(?<=[.!?])\s+(?=[A-Z0-9`*_])/);
  return sentences[sentences.length - 1]
    .replace(/^[-*]\s+/, '')
    .replace(/^\d+\.\s+/, '')
    .trim();
}

// Every fenced block with a language, in source order.
export function extractBlocks(lines) {
  const blocks = [];
  let open = null;
  lines.forEach((line, i) => {
    if (!open) {
      const m = line.match(FENCE_OPEN);
      if (m) open = { lang: m[1], file: (m[2] || '').trim(), caption: captionFor(lines, i), code: [] };
      return;
    }
    if (line.trim() === '```') {
      const code = open.code.join('\n').replace(/^\n+|\n+$/g, '');
      const whole = IS_WHOLE_FILE.some((re) => re.test(code));
      const file = open.file || (whole && code.match(CLASS_NAME) ? `${code.match(CLASS_NAME)[1]}.cs` : '');
      blocks.push({ ...open, file, code, whole });
      open = null;
      return;
    }
    open.code.push(line);
  });
  return blocks;
}

const INTRO = `Every piece of game code from the build chapters, chapter by chapter, with
the prose taken out — so you can copy a step straight into Unity. Hit the copy
button in the corner of a block. (The C# Concept examples aren't here: they're
for trying out, not part of the game.)

A block tabbed with just a filename is that **whole file**: paste it over
everything in the file. A block tabbed **· snippet** is a piece that goes
*inside* a file you already have, next to the code that's already there.`;

// Some chapters add no code: pure Editor work, or (Level 0's Chapter 10)
// breaking code you already have. Say so, rather than skipping the number and
// leaving the page looking like it starts at chapter 3.
const NO_CODE = '*No new code in this chapter.*';

export function buildCodePage(level, chapters) {
  const out = [];
  let whole = 0;
  let snippet = 0;

  for (const c of chapters) {
    const blocks = extractBlocks(c.lines).filter((b) => b.lang === 'csharp');
    out.push(`## ${c.num}. ${c.title}`, '');

    if (!blocks.length) {
      out.push(NO_CODE, '');
      continue;
    }

    for (const b of blocks) {
      b.whole ? whole++ : snippet++;
      const tab = b.file
        ? `${b.file}${b.whole ? '' : ' · snippet'}`
        : 'snippet';
      if (b.caption) out.push(b.caption, '');
      out.push(`\`\`\`csharp title="${tab.replace(/"/g, '')}"`, b.code, '```', '');
    }
  }

  // Unlisted, not secret: no sidebar entry and no link from the site, so the
  // page is reached by handing out its URL. Starlight still lists it in the
  // sitemap, so mark it noindex — otherwise "hidden" would only mean "hidden
  // from the nav" while search engines indexed it anyway.
  const title = `${level.shortName} — All the Code`;
  const frontMatter = [
    '---',
    `title: "${title}"`,
    `description: "Every code block from the ${level.shortName} build chapters, ready to copy."`,
    // splash = no sidebar at all. Without it Starlight renders the full level
    // navigation into this PUBLIC page and merely hides it with CSS, which put
    // every chapter URL of every level in the markup.
    'template: splash',
    'tableOfContents: true',
    'head:',
    '  - tag: meta',
    '    attrs:',
    '      name: robots',
    '      content: noindex, nofollow',
    '---',
  ].join('\n');
  const body = `${frontMatter}\n\n${INTRO}\n\n${out.join('\n')}`;
  return { body, whole, snippet };
}
