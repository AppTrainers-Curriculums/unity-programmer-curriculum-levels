# Unity Programmer Curriculum — web

The curriculum levels as a website, built with
[Astro](https://astro.build) + [Starlight](https://starlight.astro.build), the
same way as `materials-web`.

Live site: <https://apptrainers-curriculums.github.io/unity-programmer-curriculum-levels/>

## How it works

There is no copy of the book here. Each level's workbook stays in the Unity
project, at **`Assets/Levels/LevelN/Docs~/workbook/workbook.md`**: the same file
the PDF is built from, so the site and the PDF cannot drift apart. Edit the
workbook, and both follow.

`scripts/import.mjs` converts each workbook into Starlight doc pages, one page
per chapter, in the book's teaching order, and applies our conventions:

- `# Part N — Title` → a sidebar group (Part 0 is the **Before You Start** page)
- `## Chapter N — Title` → a build chapter page, numbered in the sidebar
- `## C# N — Title` → a C# Concept page, with a slate **C# N** badge
- any other `##` after Part 0 → its own page (Part 5's questions, answers,
  cheat sheet, checklist)
- ` ```csharp:File.cs ` fences → titled code blocks (filename tab + copy button)
- a plain fence straight under a C# example, or introduced by a paragraph that
  mentions the Console → a **Console** box (what the code prints)
- `### Idea / Do it / Test it / Challenge` → icon headings
- `**Goal:** …` → a highlighted "Goal" aside
- `> **Tip:**` / `> **Note:**` / `> **Watch out:**` → tip / note / caution asides

`scripts/workbook.mjs` does the splitting. The sidebar in `astro.config.mjs`
reads the same parse, so pages and navigation always agree.

Each level also gets a generated **"All the Code"** page
(`scripts/code-page.mjs`) at **`/code/<slug>/`**: every C# block from the
**build chapters**, in chapter order, with the prose stripped out, so a student
can copy a step straight into Unity. The C# Concept examples are left out: they
are for trying out, not part of the game. Blocks are tabbed with their filename
(a whole file the workbook leaves unnamed is named after its class), and marked
**· snippet** when the block is a piece that goes inside an existing file.

These pages are **unlisted**: no sidebar entry, no link anywhere on the site, and
`noindex, nofollow` so they stay out of search results. You hand out the URL —
`/code/<slug>/` — to whoever should have the code.

They live **outside** the level directories on purpose. `encrypt.mjs` locks
`dist/<slug>/`, so a code page inside a level would demand the level password;
at `/code/<slug>/` it stays readable. That means **the C# of a protected level
is public**: hand out the code without handing out the workbook.

**`levels.config.mjs`** is the single source of truth: it lists every level and
drives the generated pages, the sidebar, and the home-page cards.

The generated pages under `src/content/docs/` (everything except `index.mdx`)
are **git-ignored**: they are rebuilt from the workbooks on every dev / build.

## Downloads

The home page also links files the site serves as they are, listed in
`downloads` in `levels.config.mjs`. Today that's the curriculum overview,
`Assets/Levels/Unity-Programmer-Curriculum-Levels.pdf`. `scripts/import.mjs`
copies each one into `public/files/` (git-ignored) on every build, so the site
always serves the copy in the Unity project: replace the PDF there, push, and
the site follows. Downloads are **public**, never password-protected: don't list
a trainer-only file.

PDFs are in Git LFS: the deploy workflow pulls the curriculum PDF along with
`web/`'s own files. A new download needs adding to that `git lfs pull` line and
the workflow's `paths`, too.

## Develop

```bash
cd web
npm install
npm run dev        # import, then astro dev at :4321/unity-programmer-curriculum-levels/
npm run build      # import + astro build + encrypt -> dist/
npm run preview    # preview the built site
```

Requires **Node 20+**. After editing a workbook while `npm run dev` is running,
run `npm run import` (or restart dev) to pick up the change.

## Add a level

1. Write the level's workbook at `Assets/Levels/LevelN/Docs~/workbook/workbook.md`,
   with the same headings as Level 0 (`# Part N — …`, `## Chapter N — …`,
   `## C# N — …`).
2. Add an entry to the `levels` array in **`levels.config.mjs`** (slug, `src`
   path from the repo root, sidebar label, home-card text, `published`,
   `protected`, and a new `salt`: `openssl rand -hex 16`).
3. If it's protected, add its `COURSE_PW_<SLUG>` secret, and pass it in
   `.github/workflows/deploy.yml` next to `COURSE_PW_LEVEL_0`.

That one entry wires up the pages, the sidebar group, and the home card.

### Show / hide a level

Flip `published` in `levels.config.mjs`:

- `published: true` → built into the site.
- `published: false` → left out of the build entirely (not on the site).

Commit and push to apply.

## Password-protecting a level

Set `protected: true` on a level and its built pages are **AES-encrypted** with
[StatiCrypt](https://github.com/robinmoisson/staticrypt) at build time
(`scripts/encrypt.mjs`). Visitors get a branded password prompt and must enter
the level's password to read it. "Remember me" is ticked by default, so a
student enters the password once per level.

Passwords are **never** committed. Each protected level reads its password from
an environment variable **`COURSE_PW_<SLUG>`** (slug uppercased, `-` → `_`):

| Level                   | Env var / secret                  |
| ----------------------- | --------------------------------- |
| `level-0`               | `COURSE_PW_LEVEL_0`               |
| `level-1`               | `COURSE_PW_LEVEL_1`               |
| `level-2-mini-golf`     | `COURSE_PW_LEVEL_2_MINI_GOLF`     |
| `level-2-space-shooter` | `COURSE_PW_LEVEL_2_SPACE_SHOOTER` |
| `level-2-tank-arena`    | `COURSE_PW_LEVEL_2_TANK_ARENA`    |
| `level-3-knight-run`    | `COURSE_PW_LEVEL_3_KNIGHT_RUN`    |

Level 2 has three books, one per game (Mini Golf, Space Shooter, Tank Arena),
each its own entry in `levels.config.mjs` with its own secret. The three can
share a password: give each secret the same value. Their `workbook.md` files are
assembled from each game's `book.md` and the shared C# Concept chapters (see
`Assets/Levels/Level2-Shared/README.md`): re-assemble and commit them after
editing a shared chapter, or the site keeps the old text.

Level 3 works the same way, from `Assets/Levels/Level3-Shared`. Its first book,
Knight Run, is published, locked with `COURSE_PW_LEVEL_3_KNIGHT_RUN`. Add each
new Level 3 book's secret before setting its `published: true`.

- **In CI:** add each as a GitHub **repository secret**
  (Settings → Secrets and variables → Actions → New repository secret). The
  deploy workflow runs in **strict mode** (`STATICRYPT_STRICT=1`): if a
  protected level has no password, the build **fails**, so a locked level is
  never accidentally deployed unlocked.
- **Locally:** `COURSE_PW_LEVEL_0=… COURSE_PW_LEVEL_1=… npm run build`. A missing password locally
  just skips (leaves that level unencrypted) with a warning.

The `salt` per level is a fixed 32-hex string — **not secret**. It keeps builds
reproducible and lets "Remember me" work across a level's chapters.

> **Note:** site search (Pagefind) is disabled, because the search index is built
> from the *plaintext* pages and would leak protected content.

## Deploy

Pushing to `main` a change under `web/` or to a level's `workbook.md` triggers
`.github/workflows/deploy.yml` (at the repo root), which builds and publishes to
GitHub Pages. Unity-only commits don't trigger it; run it by hand from the
Actions tab if needed.

One-time setup on GitHub:

1. **Settings → Pages → Build and deployment → Source: GitHub Actions.**
2. Add the `COURSE_PW_*` secrets for the protected levels, or the strict build
   fails.

This is a project site (repo `unity-programmer-curriculum-levels`), so
`astro.config.mjs` sets `base: '/unity-programmer-curriculum-levels/'`. For a
custom domain, add a `public/CNAME` file and set `base` back to `'/'`.

The site's PNGs are in Git LFS like the rest of the project; the workflow pulls
only `web/`'s, not the whole Unity project's.
