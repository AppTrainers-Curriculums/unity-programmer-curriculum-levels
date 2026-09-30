# Level 0 book — source

`workbook.md` → `../../Docs/Level0-RocketLaunch-Workbook.pdf` (marked + highlight.js → HTML → Chrome print → cover merged with pdf-lib).

Same conventions as the catch-game workbook, plus:

- `## C# N — Title` → a slate **C# Concept** chapter header (build chapters stay `## Chapter N — Title`, in red)
- `coverArt: rocket` / `coverArt: code` in the front matter → CSS cover art (default: the Catch game)

```bash
npm install          # first time only
node build.mjs workbook.md ../../Docs/Level0-RocketLaunch-Workbook.pdf
```

Needs Google Chrome (path in `build.mjs`), or set `CHROME_PATH`.
