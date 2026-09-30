import fs from 'fs';
import path from 'path';
import { fileURLToPath } from 'url';
import { marked } from 'marked';
import hljs from 'highlight.js';
import puppeteer from 'puppeteer-core';
import { PDFDocument } from 'pdf-lib';

const __dirname = path.dirname(fileURLToPath(import.meta.url));
const CHROME = process.env.CHROME_PATH || '/Applications/Google Chrome.app/Contents/MacOS/Google Chrome';

// No logo in this workbook: the running header is left empty and the cover
// leads with the title block.

const SRC = process.argv[2] || path.join(__dirname, 'workbook.md');
const OUT = process.argv[3] || path.join(__dirname, 'out.pdf');

// ---------- helpers ----------
const esc = (s) => s.replace(/&/g, '&amp;').replace(/</g, '&lt;').replace(/>/g, '&gt;');
const inline = (s) => marked.parseInline(s);

const BEATS = {
  'idea':      { cls: 'idea',      ico: '💡', label: 'Idea' },
  'do it':     { cls: 'doit',      ico: '⌨️', label: 'Do it' },
  'test it':   { cls: 'testit',    ico: '▶️', label: 'Test it' },
  'challenge': { cls: 'challenge', ico: '🧠', label: 'Challenge' },
};
// beats whose heading text may carry extra words, e.g. "Do it — the script"
function matchBeat(text) {
  const t = text.trim().toLowerCase();
  for (const key of Object.keys(BEATS)) {
    if (t === key || t.startsWith(key + ' ') || t.startsWith(key + '(') || t.startsWith(key + ' (')) {
      return { ...BEATS[key], extra: text.trim().slice(key.length).trim() };
    }
  }
  return null;
}

// ---------- front matter ----------
function parseFrontMatter(md) {
  const m = md.match(/^---\n([\s\S]*?)\n---\n?/);
  const meta = {};
  let body = md;
  if (m) {
    body = md.slice(m[0].length);
    for (const line of m[1].split('\n')) {
      const mm = line.match(/^(\w[\w-]*):\s*(.*)$/);
      if (mm) meta[mm[1]] = mm[2].replace(/^["']|["']$/g, '');
    }
  }
  return { meta, body };
}

// ---------- code card ----------
function codeCard(code, file) {
  // No line numbers: one <pre> block so students can select and copy the code
  // straight out of the PDF. Long lines wrap (pre-wrap) instead of clipping.
  const highlighted = hljs.highlight(code, { language: 'csharp' }).value.replace(/\n$/, '');
  const fileTab = file
    ? `<span class="file">${esc(file)}<span class="lang">C#</span></span>`
    : `<span class="file"><span class="lang">C#</span></span>`;
  return `<div class="code-card"><div class="bar"><span class="dot r"></span><span class="dot y"></span><span class="dot g"></span>${fileTab}</div>` +
    `<pre class="code"><code class="hljs">${highlighted}</code></pre></div>`;
}

function diagram(text) {
  return `<div class="diagram"><pre>${esc(text.replace(/\n$/, ''))}</pre></div>`;
}

// ---------- callout ----------
function callout(innerHtml) {
  let ico = '💬';
  const low = innerHtml.toLowerCase();
  if (low.includes('tip')) ico = '💡';
  else if (low.includes('note')) ico = '📌';
  else if (low.includes('you just')) ico = '✅';
  else if (low.includes('watch out') || low.includes('careful')) ico = '⚠️';
  return `<div class="callout"><span class="ico">${ico}</span><div class="body">${innerHtml}</div></div>`;
}

// ---------- render top-level tokens ----------
function renderTokens(tokens) {
  let html = '';
  let partSeen = false;

  for (const tok of tokens) {
    switch (tok.type) {
      case 'heading': {
        if (tok.depth === 1) {
          const first = !partSeen; partSeen = true;
          const raw = tok.text.replace(/\\newpage/g, '').trim();
          const [kick, ...rest] = raw.split('—');
          const title = rest.join('—').trim() || raw;
          html += `<section class="part${first ? ' first' : ''}">` +
            `<div class="kicker">${esc(kick.trim())}</div>` +
            `<h1>${esc(title)}</h1><div class="rule"></div></section>`;
        } else if (tok.depth === 2) {
          const t = tok.text.trim();
          const cm = t.match(/^Chapter\s+(\d+)\s*[—-]\s*(.+)$/i);
          const csm = t.match(/^C#\s+(\d+)\s*[—-]\s*(.+)$/i);
          const sm = t.match(/^Section\s+(\w+)\s*[—-]\s*(.+)$/i);
          if (sm) {
            // Test papers: "## Section 1 — Title", same header as a chapter, "Section" eyebrow
            html += `<header class="chapter"><div class="num">${esc(sm[1])}</div>` +
              `<div class="titles"><div class="eyebrow">Section</div>` +
              `<h2>${inline(sm[2])}</h2></div></header>`;
          } else if (csm) {
            // C# concept chapter: same header, slate number box, "C# Concept" eyebrow
            const num = csm[1].padStart(2, '0');
            html += `<header class="chapter cs"><div class="num">${num}</div>` +
              `<div class="titles"><div class="eyebrow">C# Concept</div>` +
              `<h2>${inline(csm[2])}</h2></div></header>`;
          } else if (cm) {
            const num = cm[1].padStart(2, '0');
            html += `<header class="chapter"><div class="num">${num}</div>` +
              `<div class="titles"><div class="eyebrow">Chapter</div>` +
              `<h2>${inline(cm[2])}</h2></div></header>`;
          } else {
            html += `<h2 class="section">${inline(t)}</h2>`;
          }
        } else if (tok.depth === 3) {
          const beat = matchBeat(tok.text);
          if (beat) {
            const extra = beat.extra ? ` <span class="beat-extra">${esc(beat.extra)}</span>` : '';
            html += `<div class="beat ${beat.cls}"><span class="chip">${beat.ico}</span>${beat.label}${extra}</div>`;
          } else {
            html += `<h3 class="plain">${inline(tok.text)}</h3>`;
          }
        } else {
          html += `<h4 class="plain">${inline(tok.text)}</h4>`;
        }
        break;
      }
      case 'paragraph': {
        const raw = tok.text.trim();
        if (/^\\newpage/.test(raw)) break;
        if (/^\*\*Goal:\*\*/.test(raw)) {
          const rest = raw.replace(/^\*\*Goal:\*\*\s*/, '');
          html += `<div class="goal"><span class="ico">🎯</span><div class="txt"><b>Goal.</b> ${inline(rest)}</div></div>`;
        } else if (/^\*End of/.test(raw)) {
          html += `<div class="endnote">${inline(raw.replace(/^\*|\*$/g, ''))}</div>`;
        } else {
          html += `<p>${inline(raw)}</p>`;
        }
        break;
      }
      case 'code': {
        const lang = (tok.lang || '').trim();
        if (lang.startsWith('csharp')) {
          const file = lang.includes(':') ? lang.split(':')[1].trim() : '';
          html += codeCard(tok.text, file);
        } else {
          html += diagram(tok.text);
        }
        break;
      }
      case 'blockquote': {
        html += callout(renderTokens(tok.tokens));
        break;
      }
      case 'list': {
        const tag = tok.ordered ? 'ol' : 'ul';
        let items = '';
        for (const it of tok.items) items += `<li>${renderListItem(it)}</li>`;
        html += `<${tag}>${items}</${tag}>`;
        break;
      }
      case 'table': {
        const head = tok.header.map((c) => `<th>${inline(c.text)}</th>`).join('');
        const rows = tok.rows.map(
          (r) => `<tr>${r.map((c) => `<td>${inline(c.text)}</td>`).join('')}</tr>`
        ).join('');
        html += `<table class="tbl"><thead><tr>${head}</tr></thead><tbody>${rows}</tbody></table>`;
        break;
      }
      case 'hr': html += '<hr>'; break;
      case 'space': break;
      default:
        if (tok.raw && tok.raw.trim()) html += `<p>${inline(tok.raw.trim())}</p>`;
    }
  }
  return html;
}

function renderListItem(item) {
  let out = '';
  for (const t of item.tokens) {
    if (t.type === 'text') out += inline(t.text);
    else if (t.type === 'list') {
      const tag = t.ordered ? 'ol' : 'ul';
      let sub = '';
      for (const it of t.items) sub += `<li>${renderListItem(it)}</li>`;
      out += `<${tag}>${sub}</${tag}>`;
    } else if (t.type === 'code') {
      out += t.lang && t.lang.startsWith('csharp') ? codeCard(t.text, '') : diagram(t.text);
    } else if (t.type === 'paragraph') {
      out += `<p>${inline(t.text)}</p>`;
    } else if (t.raw) out += inline(t.raw);
  }
  return out;
}

// ---------- cover ----------
// The hero is the game itself, drawn in CSS rather than pasted in as a bitmap:
// the exact colours the project ships with, so it stays sharp at any zoom.
const GAME = {
  screen: '#1E1A33',   // canvas / camera background
  player: '#3DDCC8',   // the cyan bar
  block:  '#FF4D6D',   // the falling blocks
  text:   '#F5F3FF',
};
function gameArtHtml(meta = {}) {
  // Level 1 cover (`coverArt: catch`): red, gold and bad blocks, and three life icons.
  if (meta.coverArt === 'catch') {
    const colours = { r: '#FF4D6D', g: '#FFD166', b: '#9B5DE5' };
    const blocks = [
      { x: 12, y: 18, c: 'r' }, { x: 30, y: 44, c: 'g' }, { x: 55, y: 10, c: 'r' },
      { x: 70, y: 56, c: 'b' }, { x: 86, y: 28, c: 'r' }, { x: 44, y: 70, c: 'r' },
    ].map((b) => `<i style="left:${b.x}%;top:${b.y}%;width:5.4%;padding-bottom:5.4%;background:${colours[b.c]}"></i>`).join('');
    const lives = [0, 1, 2].map((n) => `<u style="right:${4 + (2 - n) * 5}%"></u>`).join('');
    return `<div class="shot">
    <div class="screen">
      <span class="score">Score: 12</span>
      ${lives}
      ${blocks}
      <b class="bar"></b>
    </div>
  </div>`;
  }
  // x / y / size are percentages of the screen box.
  const blocks = [
    { x: 12, y: 16, s: 5.4 }, { x: 34, y: 46, s: 5.4 }, { x: 58, y: 8, s: 5.4 },
    { x: 72, y: 62, s: 5.4 }, { x: 86, y: 30, s: 5.4 }, { x: 46, y: 74, s: 5.4 },
  ].map((b) => `<i style="left:${b.x}%;top:${b.y}%;width:${b.s}%;padding-bottom:${b.s}%"></i>`).join('');
  return `<div class="shot">
    <div class="screen">
      <span class="score">Score: 7</span>
      ${blocks}
      <b class="bar"></b>
    </div>
  </div>`;
}


// Level 0 cover art: the Rocket Launch scene, also drawn in CSS.
// Select it with `coverArt: rocket` in the workbook front matter.
function rocketArtHtml() {
  const stars = [[8,12],[18,30],[27,8],[40,22],[52,6],[63,30],[70,12],[82,24],[91,8],[12,48],[34,40],[88,44],[58,46],[5,70],[95,66]]
    .map(([x,y]) => `<s style="left:${x}%;top:${y}%"></s>`).join('');
  return `<div class="shot">
    <div class="screen rocketscene">
      ${stars}
      <div class="rocket"><span class="nose"></span><span class="body"><em></em></span>
        <span class="fin l"></span><span class="fin r"></span><span class="flame"></span></div>
      <div class="pad"></div><div class="ground"></div>
      <div class="console"><div class="ch">Console</div>
        <p>T-minus 3</p><p>T-minus 2</p><p>T-minus 1</p><p class="hot">LIFTOFF!</p><p>Now entering: Lower atmosphere</p></div>
    </div>
  </div>`;
}
const ROCKET_CSS = `
  .rocketscene{background:linear-gradient(180deg,#141127 0%,#1E1A33 70%,#2A2448 100%);}
  .rocketscene s{position:absolute;width:3px;height:3px;border-radius:50%;background:#F5F3FF;opacity:.75;}
  .rocketscene .ground{position:absolute;left:0;right:0;bottom:0;height:9%;background:#2E2A45;}
  .rocketscene .pad{position:absolute;left:23%;bottom:9%;width:18%;height:2.4%;background:#6B6F7B;border-radius:1mm 1mm 0 0;}
  .rocket{position:absolute;left:32%;bottom:24%;width:9%;height:48%;transform:translateX(-50%);}
  .rocket .body{position:absolute;left:18%;right:18%;top:18%;bottom:10%;background:#F5F3FF;border-radius:2mm 2mm 1mm 1mm;}
  .rocket .body em{position:absolute;left:28%;right:28%;top:18%;padding-bottom:44%;border-radius:50%;background:#3DDCC8;border:2px solid #232733;}
  .rocket .nose{position:absolute;left:18%;right:18%;top:0;height:22%;background:#EF4050;border-radius:50% 50% 0 0 / 100% 100% 0 0;}
  .rocket .fin{position:absolute;bottom:8%;width:26%;height:24%;background:#EF4050;}
  .rocket .fin.l{left:-4%;border-radius:3mm 0 0 1mm;transform:skewY(30deg);}
  .rocket .fin.r{right:-4%;border-radius:0 3mm 1mm 0;transform:skewY(-30deg);}
  .rocket .flame{position:absolute;left:30%;right:30%;bottom:-16%;height:18%;background:linear-gradient(180deg,#FFD166,#FF7A3D 60%,rgba(255,77,109,0));border-radius:0 0 50% 50%;}
  .rocketscene .console{position:absolute;right:5%;top:12%;width:40%;background:rgba(245,243,255,.08);border:1px solid rgba(245,243,255,.18);
     border-radius:2.5mm;padding:3mm 4mm;font-family:'JetBrains Mono',monospace;font-size:10.5pt;color:#C9C6DE;line-height:1.55;}
  .rocketscene .console .ch{font-family:'Inter',sans-serif;font-weight:600;font-size:8.5pt;letter-spacing:.14em;text-transform:uppercase;color:#8F8AAE;margin-bottom:1.5mm;}
  .rocketscene .console p{margin:0;}
  .rocketscene .console .hot{color:#FF4D6D;font-weight:700;}
`;

// C# guide cover art: a code editor with its Console output, drawn in CSS.
// Select it with `coverArt: code` in the front matter.
function codeArtHtml() {
  const k = (t) => `<b class="k">${t}</b>`, st = (t) => `<b class="s">${t}</b>`,
        n = (t) => `<b class="n">${t}</b>`, c = (t) => `<b class="c">${t}</b>`, ty = (t) => `<b class="t">${t}</b>`;
  const lines = [
    `${c('// Mission check')}`,
    `${k('string')} rocketName = ${st('"Falcon"')};`,
    `${k('int')} crew = ${n('3')};`,
    `${k('float')} fuel = ${n('12.5f')};`,
    `${k('bool')} isClear = ${k('true')};`,
    ``,
    `${k('if')} (isClear &amp;&amp; fuel &gt;= ${n('10')})`,
    `{`,
    `&nbsp;&nbsp;&nbsp;&nbsp;${ty('Debug')}.Log(rocketName + ${st('" is GO"')});`,
    `}`,
  ].map((l, i) => `<div><span class="ln">${i + 1}</span>${l || '&nbsp;'}</div>`).join('');
  return `<div class="shot">
    <div class="screen codescene">
      <div class="ed"><div class="tabs"><span class="d r"></span><span class="d y"></span><span class="d g"></span><span class="fn">Practice.cs</span></div>
        <div class="src">${lines}</div></div>
      <div class="con"><div class="ch">Console</div><p>Falcon is GO</p></div>
    </div>
  </div>`;
}
const CODE_CSS = `
  .codescene{background:#1E1A33;}
  .codescene .ed{position:absolute;left:5%;top:8%;width:62%;bottom:8%;background:#2A2F3A;border-radius:2.5mm;overflow:hidden;}
  .codescene .tabs{height:9mm;background:#20242E;display:flex;align-items:center;gap:2mm;padding:0 4mm;}
  .codescene .d{width:3mm;height:3mm;border-radius:50%;display:inline-block;}
  .codescene .d.r{background:#FF5F57}.codescene .d.y{background:#FEBC2E}.codescene .d.g{background:#28C840}
  .codescene .fn{margin-left:3mm;font-family:'Inter',sans-serif;font-size:9pt;color:#AEB4C2;}
  .codescene .src{padding:3mm 4mm;font-family:'JetBrains Mono',monospace;font-size:11pt;line-height:1.6;color:#E6E9F0;white-space:nowrap;}
  .codescene .src .ln{display:inline-block;width:8mm;color:#626B7C;}
  .codescene .src b{font-weight:500;}
  .codescene .k{color:#FF7A8A}.codescene .s{color:#9BE39B}.codescene .n{color:#C7A6FF}.codescene .c{color:#7D8698;font-style:italic}.codescene .t{color:#6FC3FF}
  .codescene .con{position:absolute;right:5%;bottom:14%;width:25%;background:rgba(245,243,255,.08);border:1px solid rgba(245,243,255,.18);
     border-radius:2.5mm;padding:3mm 4mm;font-family:'JetBrains Mono',monospace;font-size:10.5pt;color:#3DDCC8;}
  .codescene .con .ch{font-family:'Inter',sans-serif;font-weight:600;font-size:8.5pt;letter-spacing:.14em;text-transform:uppercase;color:#8F8AAE;margin-bottom:1.5mm;}
  .codescene .con p{margin:0;}
`;

function coverHtml(meta, cssLinks) {
  const rocketArt = meta.coverArt === 'rocket';
  const codeArt = meta.coverArt === 'code';
  return `<!doctype html><html><head><meta charset="utf-8">${cssLinks}
  <style>
  html,body{margin:0;padding:0;width:210mm;height:297mm;overflow:hidden;}
  .cover{position:relative;width:210mm;height:297mm;background:#FFFFFF;overflow:hidden;
     font-family:'Poppins',sans-serif;-webkit-print-color-adjust:exact;print-color-adjust:exact;}
  .cover::before{content:'';position:absolute;top:-70mm;right:-70mm;width:210mm;height:210mm;border-radius:50%;
     background:radial-gradient(circle,#FCEBEE 0%,rgba(252,235,238,0) 70%);}
  .titleblock{position:absolute;left:16mm;top:44mm;right:16mm;z-index:6;}
  .eyebrow{font-weight:700;font-size:11pt;letter-spacing:.3em;color:#EC4A5A;text-transform:uppercase;margin-bottom:6mm;}
  .title{font-weight:800;font-size:52pt;line-height:.98;letter-spacing:-1.5px;color:#3E4655;margin:0;}
  .title .red{color:#EC4A5A;}
  .subtitle{font-family:'Inter',sans-serif;font-weight:500;font-size:13.5pt;color:#6B7280;margin-top:6mm;max-width:150mm;}
  .pill{display:inline-block;margin-top:8mm;background:#3E4655;color:#fff;font-weight:700;
     font-size:10pt;letter-spacing:.22em;text-transform:uppercase;padding:3.2mm 8mm;border-radius:40px;}

  /* the game screen, tilted slightly, with a soft shadow */
  .shot{position:absolute;left:50%;bottom:24mm;width:190mm;transform:translateX(-50%) rotate(-2.5deg);
     z-index:4;border-radius:4mm;box-shadow:0 12mm 20mm rgba(37,42,55,.22);overflow:hidden;}
  .screen{position:relative;width:100%;padding-bottom:62.5%;background:${GAME.screen};}
  .screen .score{position:absolute;left:5%;top:5%;font-family:'Inter',sans-serif;font-weight:600;
     font-size:15pt;color:${GAME.text};letter-spacing:.02em;}
  .screen i{position:absolute;height:0;background:${GAME.block};border-radius:1.2mm;display:block;}
  .screen u{position:absolute;top:5.5%;width:3.2%;padding-bottom:3.2%;height:0;background:#FF4D6D;border-radius:1mm;display:block;}
  .screen .bar{position:absolute;left:38%;bottom:9%;width:24%;padding-bottom:3.4%;
     background:${GAME.player};border-radius:1.4mm;display:block;}
  .caption{position:absolute;left:0;right:0;bottom:14mm;text-align:center;z-index:6;
     font-family:'Inter',sans-serif;font-size:9pt;color:#9AA3B0;}
  ${rocketArt ? ROCKET_CSS : ''}${codeArt ? CODE_CSS : ''}
  </style></head><body>
  <div class="cover">
    <div class="titleblock">
      <div class="eyebrow">${esc(meta.coverEyebrow || 'Learn to Code · Make Games')}</div>
      <h1 class="title">${esc(meta.coverTop || 'Catch the')}<br><span class="red">${esc(meta.coverRed || 'Falling Blocks')}</span></h1>
      <div class="subtitle">${esc(meta.coverSub || '')}</div>
      <div class="pill">${esc(meta.coverPill || 'Student Workbook')}</div>
    </div>
    ${rocketArt ? rocketArtHtml() : codeArt ? codeArtHtml() : gameArtHtml(meta)}
    <div class="caption">${esc(meta.coverCaption || '')}</div>
  </div></body></html>`;
}

// ---------- main ----------
const md = fs.readFileSync(SRC, 'utf8');
const { meta, body } = parseFrontMatter(md);
const tokens = marked.lexer(body);
const bodyHtml = renderTokens(tokens);

const fontsCss = fs.readFileSync(path.join(__dirname, 'fonts.css'), 'utf8');
const styleCss = fs.readFileSync(path.join(__dirname, 'style.css'), 'utf8');

const contentHtml = `<!doctype html><html><head><meta charset="utf-8">
<base href="file://${__dirname}/">
<style>${fontsCss}\n${styleCss}</style></head>
<body><div class="content">${bodyHtml}</div></body></html>`;

const coverPage = coverHtml(meta, `<base href="file://${__dirname}/"><style>${fontsCss}</style>`);

fs.mkdirSync(path.join(__dirname, 'build'), { recursive: true });
fs.writeFileSync(path.join(__dirname, 'build', 'content.html'), contentHtml);
fs.writeFileSync(path.join(__dirname, 'build', 'cover.html'), coverPage);

const browser = await puppeteer.launch({ executablePath: CHROME, headless: 'new', args: ['--no-sandbox', ...(process.env.CHROME_ARGS ? JSON.parse(process.env.CHROME_ARGS) : [])] });

async function renderPdf(html, opts) {
  const page = await browser.newPage();
  await page.setContent(html, { waitUntil: 'networkidle0' });
  await page.evaluateHandle('document.fonts.ready');
  const buf = await page.pdf(opts);
  await page.close();
  return buf;
}

// No running header (no logo in this workbook) — just a thin page footer.
const header = '<div></div>';
const footerLeft = esc(`${meta.title || 'Catch the Falling Blocks'}  ·  ${meta.coverPill || 'Student Workbook'}`);
const footer = `<div style="width:100%;font-family:Helvetica,Arial,sans-serif;font-size:7.5pt;color:#A9B0BC;padding:0 15mm 4mm;display:flex;justify-content:space-between;align-items:center;">
  <span>${footerLeft}</span>
  <span style="color:#EC4A5A;font-weight:600;">Page <span class="pageNumber"></span></span></div>`;

const contentPdf = await renderPdf(contentHtml, {
  format: 'A4', printBackground: true,
  displayHeaderFooter: true,
  headerTemplate: header,
  footerTemplate: footer,
  margin: { top: '18mm', bottom: '16mm', left: '15mm', right: '15mm' },
});

const coverPdf = await renderPdf(coverPage, {
  width: '210mm', height: '297mm', printBackground: true,
  margin: { top: 0, bottom: 0, left: 0, right: 0 },
});

const merged = await PDFDocument.create();
for (const src of [coverPdf, contentPdf]) {
  const doc = await PDFDocument.load(src);
  const pages = await merged.copyPages(doc, doc.getPageIndices());
  pages.forEach((p) => merged.addPage(p));
}
const outPdf = await merged.save();

await browser.close();

fs.writeFileSync(OUT, outPdf);
console.log('wrote', OUT, '(' + (await PDFDocument.load(fs.readFileSync(OUT))).getPageCount() + ' pages)');
