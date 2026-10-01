# Level 0 book — source

`workbook.md` → `../../Docs/Level0-RocketLaunch-Workbook.pdf` (marked + highlight.js → HTML → Chrome print → cover merged with pdf-lib).

- `## C# N — Title` → a slate **C# Concept** chapter header (build chapters stay `## Chapter N — Title`, in red)
- `coverArt: rocket` / `coverArt: code` in the front matter → CSS cover art (default: the Catch game)

`build.mjs` is the same file in Levels 0, 1 and 2 (Level 2's is in `../../../Level2-Shared/Docs~/pdf`), and so is `style.css`, except that Level 2 sets code a little smaller: fix one, then copy it to the others. `../../../Level2-Shared/README.md` describes what the builder does: fonts, page breaks, and chapters set a little tighter so none ends on a nearly empty page.

```bash
npm install          # first time only
node build.mjs workbook.md ../../Docs/Level0-RocketLaunch-Workbook.pdf
```

Needs Google Chrome (path in `build.mjs`), or set `CHROME_PATH`.
