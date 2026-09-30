// Read a level's workbook.md and split it into the site's pages, in reading
// order. Shared by scripts/import.mjs (writes the pages) and astro.config.mjs
// (builds the sidebar), so the two always agree.
//
//   # Part 0 — …           the intro: everything up to Part 1 is one page,
//                          and its own ## headings stay sections on that page
//   # Part N — Title       a sidebar group for the pages that follow
//   ## Chapter N — Title   a build chapter page
//   ## C# N — Title        a C# Concept page
//   ## Anything else       its own page too, once past the intro (Part 5's
//                          questions, answers, cheat sheet …)
//
// Pages keep the book's order, which is the teaching order: the C# Concepts sit
// just before the build chapter that needs them.
import fs from 'fs';
import path from 'path';
import { fileURLToPath } from 'url';
import { slugify, stripMd } from '../levels.config.mjs';

const REPO = path.join(path.dirname(fileURLToPath(import.meta.url)), '..', '..');

const PART = /^#\s+Part\s+(\d+)\s*[—-]\s*(.+)$/i;
const CHAPTER = /^##\s+Chapter\s+(\d+)\s*[—-]\s*(.+)$/i;
const CONCEPT = /^##\s+C#\s+(\d+)\s*[—-]\s*(.+)$/i;
const SECTION = /^##\s+(.+)$/;

// The heading that starts a new page, or null. Inside the intro only chapters
// do: a plain ## there is a section of the intro page.
function pageStart(line, inIntro) {
  let m;
  if ((m = line.match(CHAPTER))) return { kind: 'chapter', num: Number(m[1]), title: stripMd(m[2]) };
  if ((m = line.match(CONCEPT))) return { kind: 'concept', num: Number(m[1]), title: stripMd(m[2]) };
  if (!inIntro && (m = line.match(SECTION))) return { kind: 'section', num: null, title: stripMd(m[1]) };
  return null;
}

export function readWorkbook(level) {
  const md = fs
    .readFileSync(path.join(REPO, level.src), 'utf8')
    .replace(/^---\n[\s\S]*?\n---\n?/, '');

  const intro = { kind: 'intro', num: null, title: level.introTitle, part: null, lines: [] };
  const pages = [intro];
  let cur = intro;
  let part = null;
  let inFence = false;

  for (const line of md.split('\n')) {
    if (line.startsWith('```')) inFence = !inFence;
    if (!inFence) {
      const p = line.match(PART);
      if (p && Number(p[1]) > 0) {
        part = { num: Number(p[1]), title: stripMd(p[2]) };
        continue;
      }
      if (/^#\s/.test(line)) continue; // Part 0 and any other divider: dropped

      const start = pageStart(line, cur === intro && !part);
      if (start) {
        cur = { ...start, part, lines: [] };
        pages.push(cur);
        continue; // the heading becomes the page title
      }
    }
    cur.lines.push(line);
  }

  const seen = new Map();
  for (const p of pages) {
    p.slug = slugify(p.title);
    if (seen.has(p.slug)) {
      throw new Error(
        `${level.src}: "${seen.get(p.slug)}" and "${p.title}" would both be /${level.slug}/${p.slug}/ — rename one.`
      );
    }
    seen.set(p.slug, p.title);
  }
  return pages;
}

// The page's <h1> and browser-tab title.
export function pageTitle(p) {
  if (p.kind === 'chapter') return `Chapter ${p.num} — ${p.title}`;
  if (p.kind === 'concept') return `C# Concept ${p.num} — ${p.title}`;
  return p.title;
}

// The page's sidebar entry. C# Concepts carry a slate "C# N" badge, the PDF's
// colour for them, so they stand apart from the numbered build chapters.
export function sidebarMeta(p) {
  if (p.kind === 'chapter') return { label: `${p.num}. ${p.title}` };
  if (p.kind === 'concept') return { label: p.title, badge: { text: `C# ${p.num}`, class: 'badge-csharp' } };
  return { label: p.title };
}

// The level's sidebar items: pages before Part 1 at the top, then one group per
// Part. Labels and badges come from each page's front matter (sidebarMeta).
export function sidebarFor(level) {
  const items = [];
  let group = null;
  for (const p of readWorkbook(level)) {
    const link = { slug: `${level.slug}/${p.slug}` };
    if (!p.part) {
      items.push(link);
      continue;
    }
    if (group?.part !== p.part) {
      group = { part: p.part, label: `Part ${p.part.num} · ${p.part.title}`, items: [] };
      items.push(group);
    }
    group.items.push(link);
  }
  return items.map(({ part, ...item }) => item);
}
