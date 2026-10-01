# Level 2 — Shared

What the Level 2 ("Builder") games of the Unity Programmer Curriculum have in common. Level 2 has three games, each with a fully guided book: **Mini Golf** (3D, `../Level2-MiniGolf`), **Space Shooter** (2D, `../Level2-SpaceShooter`) and **Tank Arena** (2D, `../Level2-TankArena`). Each book stands alone and teaches every Level 2 topic, so a trainer can run one book, or give different groups different books. The teaching of those topics is the same in every book, so it lives here once: the 15 C# Concept chapters, the Check Yourself part that ends every book, the script that assembles each book from its own chapters and the shared ones, the PDF builder, the helpers the scene builders use, and the Level 2 entry test. Fix a concept chapter here, and every book gets the fix.

## What's in this folder

| Path | What it is |
| --- | --- |
| `Docs~/concepts/*.md` | The 15 shared **C# Concept chapters** (table below). |
| `Docs~/shared/check-yourself.md` | The part every book ends with: 20 exam-style questions, their answers, the Level 2 cheat sheet, and the "Before Level 3: can you…" readiness list. |
| `Docs~/assemble.mjs` | **The book assembler:** each game's `book.md` + the shared chapters → its `workbook.md`. |
| `Docs~/pdf/` | **The PDF builder:** `build.mjs`, `style.css`, `fonts.css` and `fonts/` (Inter, Poppins, JetBrains Mono), `package.json`. `build/` holds the HTML of its last run. |
| `Editor/Level2BuilderKit.cs`, `Editor/Curriculum.Level2.Shared.Editor.asmdef` | **Instructor tool.** Static helpers for the games' scene builders, in an Editor-only assembly (not auto-referenced). |
| `Docs/Level2-Entry-Test.pdf` | Student paper for the **Level 2 entry test**: a written paper and a practical task. |
| `Docs/Level2-Entry-Test-Answer-Key.pdf` | **Trainer only.** The entry test's answers, marking rubric and model solution. |
| `Docs~/entry-test/` | Source of the two test papers (`test.md`, `answer-key.md`), and the model solution's scripts (`Jar.cs`, `FireflyGame.cs`). |

The `~` makes Unity ignore the `Docs~` folder.

## The C# Concept chapters

Each chapter is written once, with an unnumbered heading (`## C# — Lists`), and gets its number from its place in each book. "Comes after" is the order `assemble.mjs` enforces: a chapter must come after the ones it builds on.

| Id | File | Chapter | Comes after | Mini Golf | Space Shooter | Tank Arena |
| --- | --- | --- | --- | --- | --- | --- |
| `properties` | `properties-and-constructors.md` | Properties and Constructors | — | C# 4 | C# 8 | C# 6 |
| `modifiers` | `static-const-readonly.md` | static, const and readonly | `properties` | C# 10 | C# 9 | C# 7 |
| `methods` | `methods-in-depth.md` | Methods in Depth | — | C# 1 | C# 2 | C# 3 |
| `numbers` | `numbers-and-conversions.md` | Numbers and Conversions | — | C# 8 | C# 3 | C# 10 |
| `lists` | `lists.md` | Lists | — | C# 11 | C# 10 | C# 9 |
| `dictionaries` | `dictionaries.md` | Dictionaries | `methods`, `lists` | C# 12 | C# 13 | C# 13 |
| `events` | `event-functions.md` | Event Functions: When Unity Calls Your Code | — | C# 2 | C# 4 | C# 2 |
| `components` | `components.md` | Components and GetComponent | `methods`, `events` | C# 3 | C# 5 | C# 5 |
| `vectors` | `vectors.md` | Vectors | — | C# 5 | C# 1 | C# 1 |
| `coroutines` | `coroutines.md` | Coroutines and Timers | — | C# 13 | C# 7 | C# 8 |
| `input` | `mouse-and-touch.md` | Mouse and Touch | `vectors` | C# 6 | C# 11 | C# 4 |
| `raycasts` | `raycasts.md` | Raycasts | `methods`, `vectors`, `input` | C# 7 | C# 12 | C# 11 |
| `uievents` | `ui-events.md` | UI Events: Listening for Changes | `methods`, `events` | C# 14 | C# 14 | C# 14 |
| `null` | `null-and-debugging.md` | null and Debugging | `components` | C# 15 | C# 15 | C# 15 |
| `docs` | `unity-docs.md` | Reading the Unity Docs | `methods` | C# 9 | C# 6 | C# 12 |

## How a book is put together

Each game's `Docs~/workbook/book.md` holds its front matter (cover, footer), Part 0 and its build chapters, and marks where the shared material goes:

| Marker | Where | Becomes |
| --- | --- | --- |
| `{{concept:lists}}` | on a line of its own | the whole concept chapter (`concepts/lists.md`), numbered |
| `{{include:check-yourself}}` | on a line of its own | `shared/check-yourself.md` (the last part of every book) |
| `{{ref:lists}}` | anywhere | that chapter's number in this book: `C# 11` in Mini Golf, `C# 10` in Space Shooter |
| `{{num:lists}}` | anywhere | just the number: `11` in Mini Golf |

`assemble.mjs` expands the markers, numbers every C# chapter in book order (`## C# 1 — …`, `## C# 2 — …`), fills in the references, and writes `workbook.md` next to `book.md`. It stops with a message naming the book if a concept is missing (every book teaches every concept), included twice, placed before a chapter it builds on, or unknown; if a shared file is missing; if a concept file doesn't start with `## C# — Title`; if a heading was numbered by hand; or if a marker is left unresolved.

```
Level2-MiniGolf/Docs~/workbook/book.md ─┐
Level2-Shared/Docs~/concepts/*.md ──────┼─ node assemble.mjs ─→ Level2-MiniGolf/Docs~/workbook/workbook.md ─→ PDF, website
Level2-Shared/Docs~/shared/*.md ────────┘
```

`workbook.md` is the file the PDF builder and the course website read. Edit `book.md` or a shared file, never `workbook.md`: the next run overwrites it.

```bash
cd Assets/Levels/Level2-Shared/Docs~
node assemble.mjs            # assemble every Level2-*/Docs~/workbook/book.md
node assemble.mjs --check    # change nothing; exit 1 if any workbook.md is out of date
```

The first command prints, for each book, `wrote` (or `unchanged`), the file, and its counts, such as `(15 chapters, 15 C# Concepts)`. The `--check` mode prints `up to date` or `OUT OF DATE` for each book, and exits with 1 if any `workbook.md` needs assembling: run it before committing, or in CI. The assembler finds every `Level2-*` folder that has a `Docs~/workbook/book.md`, so a new game's book joins in as soon as it exists.

## Changing or adding a concept chapter

**To change one:**

1. Edit its file in `Docs~/concepts/`, once. The same text goes into every book, so keep it about C# and Unity, not about one game.
2. Keep the first line `## C# — Title`, and point to other concepts with `{{ref:id}}`, never with a number: the numbers differ from book to book.
3. Run `node assemble.mjs`, then `node assemble.mjs --check`.
4. Rebuild **each** book's PDF (next section), and commit the re-assembled `workbook.md` files too: the website reads them.

**To add one:** write the file (starting with `## C# — Title`), add it to `CONCEPT_LIST` in `assemble.mjs` with the ids it builds on (`needs`), put `{{concept:id}}` in **every** `book.md`, after the chapters it needs and before the build chapter that uses it, then assemble and rebuild every PDF. The assembler refuses a book that leaves it out.

The same goes for `shared/check-yourself.md`: edit it once, assemble, rebuild every PDF.

## Building the PDFs

```bash
cd Assets/Levels/Level2-Shared/Docs~/pdf
npm install                  # first time only
node build.mjs ../../../Level2-MiniGolf/Docs~/workbook/workbook.md ../../../Level2-MiniGolf/Docs/Level2-MiniGolf-Workbook.pdf
node build.mjs ../../../Level2-SpaceShooter/Docs~/workbook/workbook.md ../../../Level2-SpaceShooter/Docs/Level2-SpaceShooter-Workbook.pdf
node build.mjs ../../../Level2-TankArena/Docs~/workbook/workbook.md ../../../Level2-TankArena/Docs/Level2-TankArena-Workbook.pdf
```

Assemble first: the builder reads `workbook.md`, not `book.md`. It needs Google Chrome: `build.mjs` looks for it at the macOS path (`/Applications/Google Chrome.app/…`); anywhere else, set `CHROME_PATH`. `CHROME_ARGS` (a JSON array) adds Chrome launch flags if you need them.

The builder makes an A4 PDF: the cover from the book's front matter (Level 2 books use `coverArt: image`, with `coverImage: cover.png` from the book's `Docs~/workbook/` folder), then the content, with the book's `footer` and page numbers. `## Chapter N — …` headings get the red build-chapter header, `## C# N — …` the slate C# Concept header, and `## Section N — …` a Section header, for test papers. A numbered list keeps its numbers when a code block interrupts it: a step written `3.` after a code block is drawn as step 3. Code cards taller than half a page, and tables taller than a third of one, continue on the next page rather than leave a gap; shorter ones, and bullet lists of up to four items, move to the next page whole. Every chapter starts on a new page, so the builder also looks for chapters whose last page would hold only a few lines: it sets those chapters a little tighter (less space between lines and blocks) until the lines fit on the page before, and says which ones. It writes `build/cover.html` and `build/content.html` and prints Chrome's PDF from those files, so the fonts in `fonts/` (Inter, Poppins, JetBrains Mono) load; if one doesn't, the build stops and names it. It ends by printing `wrote <file> (N pages)`.

The Level 0 and Level 1 books use the same builder: `../Level0/Docs~/workbook` and `../Level1/Docs~/workbook` hold copies of `build.mjs` and `style.css` (their `style.css` sets code at 8.5 pt, for their shorter lines, instead of 7.8 pt). After changing either file here, copy it there too, keeping that one line.

## The builder kit

`Editor/Level2BuilderKit.cs` is a static class of helpers for the Level 2 scene builders (**Tools → Mini Golf (Level 2) → Build Scene**, **Tools → Space Shooter (Level 2) → Build Scene** and **Tools → Tank Arena (Level 2) → Build Scene**). The builders use it with `using static Level2BuilderKit;`, and each game's Editor assembly references `Curriculum.Level2.Shared.Editor`. It isn't part of any book, and never goes into a build.

| Helpers | Do |
| --- | --- |
| `TextMeshProIsReady` | Checks for the TMP Essential Resources. If they're missing, opens the Import Unity Package window and a dialog: click **Import**, wait, then run **Build Scene** again. |
| `AddTag`, `AddLayer`, `SetLayerRecursively`, `AddToBuildSettings`, `EnsureFolder` | Project setup. `AddLayer` uses the first free User Layer and returns the layer's number. |
| `Set`, `SetArray`, `SetFloat`, `SetInt`, `SetBool`, `SetString`, `SetVector3`, `SetLayerMask` | Fill a script's `[SerializeField]` fields, exactly as dragging into the Inspector would. A wrong field name logs `No field '…' on …`. |
| `LoadClip`, `ImportSprite`, `MakeMaterial`, `Hex` | Assets: a sound; a PNG as a single sprite with the given Pixels Per Unit and pivot, no mipmaps (reimported only when a setting differs); a material created or updated with a shader and a colour; a colour from `#RRGGBB`. |
| `MakeCanvas`, `MakeRect`, `MakeStretch`, `MakeText`, `MakeImage` | A Screen Space Overlay canvas (Scale With Screen Size, 1920 × 1080, Match 0.5) and an EventSystem with the Input System UI Input Module; rectangles; TextMeshPro texts and images with Raycast Target off. |
| `MakeButton`, `MakeSlider`, `MakeToggle`, `MakeInputField`, `MakeDropdown`, `MakeWindow` | The controls **GameObject → UI (Canvas)** makes. A button gets the size you give it and a label half its height; a slider, input field or dropdown gets a width and keeps its default height; a toggle's label is white; an input field takes up to 12 characters. `MakeWindow` makes a dimmed full-screen panel (black at 55% alpha) holding a scaled window, so the default-sized controls read well on a 1920 × 1080 canvas. |
| `SaveScene` | Saves the scene and puts it first in Build Settings, ticked, so a build starts with it; drops any scene in the list whose file has been deleted. |

All the builders share it: after changing it, run each game's **Build Scene** again and check its scene.

## The Level 2 entry test

Students join Level 2 by passing the **Level 2 entry test**, which tests Level 1 (Catch the Falling Blocks). The books send trainers to it ("the Level 2 entry test papers in the course project; the answer key is a separate trainer-only file"), so it lives here, shared by all three:

| Part | Time | Marks | To pass |
| --- | --- | --- | --- |
| **Written paper:** 20 questions on Level 1 (physics and prefabs, Web builds, scope and access, classes, arrays, loops, enums, `switch` and `?:`, text formatting, input, spawning, UI and sound) | 40 minutes | 20 | 14 |
| **Practical task:** Firefly Catcher, a small game built from a description: a jar moved with the keyboard, insects spawned from an array, catching with triggers and a `switch`, a timer, an `enum` for the game's state, and a rank from two arrays and a loop | 75 minutes | 100 | 70 |

- `Docs/Level2-Entry-Test.pdf`: the student paper (a cover and 10 pages). Sections 1–2 (the rules and the written paper) are pages 1–7, and Section 3 (the practical task) starts on page 8, so trainers can print the written paper and the task as two sets, and hand out the task (with the Level 1 cheat sheet) only after collecting the written paper. Check this still holds after editing `test.md`: the answer key's "Before the test" list quotes those pages.
- `Docs/Level2-Entry-Test-Answer-Key.pdf`: **trainer only**: how to run the test, every answer with the Level 1 chapter to review, the practical's rubric, a model solution, what to do with each result, and changed numbers for retakes.
- `Docs~/entry-test/`: their sources, and the model solution's two scripts. The key's code cards are copies of them, byte for byte; the scripts use only Level 1 C#.

To rebuild the papers after an edit:

```bash
cd Assets/Levels/Level2-Shared/Docs~/pdf
node build.mjs ../entry-test/test.md ../../Docs/Level2-Entry-Test.pdf
node build.mjs ../entry-test/answer-key.md ../../Docs/Level2-Entry-Test-Answer-Key.pdf
```

Their covers use `coverArt: code` with `coverCode: level1`: a code editor showing Level 1 C#. The entry test isn't part of the course site.

> **Watch out:** the answer key is in the project like everything else. If the repository is ever made public, the key is public too: keep a trainer-only copy elsewhere, or leave the key out of the repository.
