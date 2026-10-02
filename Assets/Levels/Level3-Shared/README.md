# Level 3 — Shared

What the Level 3 ("Junior-ready") games of the Unity Programmer Curriculum have in common. Level 3 has three games, each with a fully guided book: **Knight Run** (a 2D platformer, `../Level3-KnightRun`), **Crypt Keys** (a 2D top-down dungeon, `../Level3-CryptKeys`) and **Gate Guard** (a 3D tower defence, `../Level3-GateGuard`); see `GAMES_PLAN.md` at the top of the project. Each book stands alone and teaches every Level 3 topic, so a trainer can run one book, or give different groups different books. The teaching of those topics is the same in every book, so it lives here once: the 12 C# Concept chapters, the Check Yourself part that ends every book, the script that assembles each book from its own chapters and the shared ones, a checker that compiles every line of code in the books, the PDF builder, and the helpers the scene builders use. Fix a concept chapter here, and every book gets the fix.

Level 3 ends at the **Unity Certified User: Programmer** exam, so its concept chapters and its Check Yourself part are written around the exam's objectives.

## What's in this folder

| Path | What it is |
| --- | --- |
| `Docs~/concepts/*.md` | The 12 shared **C# Concept chapters** (table below). |
| `Docs~/shared/check-yourself.md` | The part every book ends with: 38 exam-style questions (two for each exam objective) and their answers, a timed 20-question practice paper with its answers, the Level 3 cheat sheet, and the "Before Level 4: can you…" readiness list. |
| `Docs~/assemble.mjs` | **The book assembler:** each game's `book.md` + the shared chapters → its `workbook.md`. |
| `Docs~/check-code.mjs` | **The code checker:** compiles the code in each assembled book with Unity's own compiler, step by step, and compares each code card with the game's `Scripts/`. |
| `Docs~/pdf/` | **The PDF builder:** `build.mjs`, `style.css`, `fonts.css` and `fonts/` (Inter, Poppins, JetBrains Mono), `package.json`. `build/` holds the HTML of its last run. |
| `Editor/Level3BuilderKit.cs`, `Editor/Curriculum.Level3.Shared.Editor.asmdef` | **Instructor tool.** Static helpers for the games' scene builders, in an Editor-only assembly (not auto-referenced). |
| `Docs/Level3-Entry-Test.pdf` | Student paper for the **Level 3 entry test**: a written paper and a practical task. |
| `Docs/Level3-Entry-Test-Answer-Key.pdf` | **Trainer only.** The entry test's answers, marking rubric and model solution. |
| `Docs/ENTRY_TEST_SPEC.md` | The entry test's spec: what it checks, the paper's blueprint, the practical, how it was checked. |
| `Docs~/entry-test/` | Source of the two test papers (`test.md`, `answer-key.md`), and the model solution's scripts (`Meteor.cs`, `MeteorGame.cs`). |

The `~` makes Unity ignore the `Docs~` folder. The Level 3 entry test lives here too, like Level 2's: see "The Level 3 entry test" below.

## The C# Concept chapters

Each chapter is written once, with an unnumbered heading (`## C# — Animation Events`), and gets its number from its place in each book. "Comes after" is the order `assemble.mjs` enforces: a chapter must come after the ones it builds on.

| Id | File | Chapter | Comes after | Knight Run | Crypt Keys | Gate Guard |
| --- | --- | --- | --- | --- | --- | --- |
| `naming` | `naming-conventions.md` | Naming Conventions | — | C# 1 | C# 1 | C# 1 |
| `animwindow` | `animation-window.md` | The Animation Window | — | C# 2 | C# 2 | C# 2 |
| `animator` | `animator-controller.md` | The Animator Controller | `animwindow` | C# 3 | C# 3 | C# 3 |
| `animcode` | `driving-the-animator.md` | Driving the Animator from Code | `animator` | C# 4 | C# 4 | C# 4 |
| `animevents` | `animation-events.md` | Animation Events | `animwindow` | C# 5 | C# 5 | C# 5 |
| `statemachines` | `state-machines.md` | State Machines with enum and switch | — | C# 6 | C# 6 | C# 6 |
| `enemies` | `enemies-as-state-machines.md` | Enemies as State Machines | `statemachines`, `animcode` | C# 7 | C# 7 | C# 7 |
| `gameui` | `game-ui.md` | Game UI: Health Bars, Menus and Pausing | — | C# 8 | C# 8 | C# 8 |
| `reading` | `reading-code.md` | Reading Code | `naming` | C# 9 | C# 9 | C# 9 |
| `errors` | `finding-errors.md` | Finding Errors | `animevents` | C# 10 | C# 10 | C# 10 |
| `classes` | `kinds-of-classes.md` | Kinds of Classes | — | C# 11 | C# 11 | C# 11 |
| `exam` | `the-user-exam.md` | The User Exam | `reading`, `errors`, `classes` | C# 12 | C# 12 | C# 12 |

The chapters' examples are written once, for every book, so some come from Knight Run (a
knight, slimes). Each book's Part 0 says so; its own build chapters show the same ideas on
its own game, Gate Guard's in 3D.

The Unity messages the chapters quote (Animator warnings, Animation Event errors, null and missing-component exceptions) were copied from Unity 6000.6's Console, not written from memory. If a later Unity changes one, change the chapter.

## How a book is put together

Each game's `Docs~/workbook/book.md` holds its front matter (cover, footer), Part 0 and its build chapters, and marks where the shared material goes:

| Marker | Where | Becomes |
| --- | --- | --- |
| `{{concept:animevents}}` | on a line of its own | the whole concept chapter (`concepts/animation-events.md`), numbered |
| `{{include:check-yourself}}` | on a line of its own | `shared/check-yourself.md` (the last part of every book) |
| `{{ref:animevents}}` | anywhere | that chapter's number in this book: `C# 5` in Knight Run |
| `{{num:animevents}}` | anywhere | just the number: `5` |

`assemble.mjs` expands the markers, numbers every C# chapter in book order (`## C# 1 — …`, `## C# 2 — …`), fills in the references, and writes `workbook.md` next to `book.md`. It stops with a message naming the book if a concept is missing (every book teaches every concept), included twice, placed before a chapter it builds on, or unknown; if a shared file is missing; if a concept file doesn't start with `## C# — Title`; if a heading was numbered by hand; or if a marker is left unresolved.

```
Level3-KnightRun/Docs~/workbook/book.md ─┐
Level3-Shared/Docs~/concepts/*.md ───────┼─ node assemble.mjs ─→ Level3-KnightRun/Docs~/workbook/workbook.md ─→ PDF, website
Level3-Shared/Docs~/shared/*.md ─────────┘
```

`workbook.md` is the file the PDF builder, the code checker and the course website read. Edit `book.md` or a shared file, never `workbook.md`: the next run overwrites it.

```bash
cd Assets/Levels/Level3-Shared/Docs~
node assemble.mjs            # assemble every Level3-*/Docs~/workbook/book.md
node assemble.mjs --check    # change nothing; exit 1 if any workbook.md is out of date
```

The first command prints, for each book, `wrote` (or `unchanged`), the file, and its counts, such as `(15 chapters, 12 C# Concepts)`. The `--check` mode prints `up to date` or `OUT OF DATE` for each book, and exits with 1 if any `workbook.md` needs assembling. The assembler finds every `Level3-*` folder that has a `Docs~/workbook/book.md`, so a new game's book joins in as soon as it exists.

## Checking the code in the books

Level 3 books show each script many times as it grows, chapter by chapter. `check-code.mjs` makes sure every one of those versions compiles, in the order a student types them:

```bash
cd Assets/Levels/Level3-Shared/Docs~
node check-code.mjs          # every Level3-*/Docs~/workbook/workbook.md
```

It walks each assembled book from top to bottom, and compiles with Unity's own C# compiler, references and defines, so what passes here compiles in Unity:

- **In a build chapter**, a `csharp` block that holds a whole script becomes that script's current version, and every script shown so far is compiled together: the student's project after that step. Unity compiles as soon as a script is saved, so every step must leave a project that compiles. A named card (` ```csharp:Coin.cs `) must also match the game's `Scripts/Coin.cs` byte for byte.
- **In a C# Concept chapter**, each example is compiled on its own, beside the chapter's earlier classes. An example that is only statements is wrapped in a `Practice` class's `Start()`; one that is only fields and methods is wrapped in a class.
- A block containing `error CS` shows a mistake on purpose, and a block containing `…` leaves parts of a script out: both are skipped. So are one-line snippets in build chapters (no class in them).

It prints `ok` and the counts for each book, such as `(33 script versions, 14 cards, 21 C# examples)`, or `PROBLEMS` and each compiler message, with the chapter and the line of `workbook.md`. It needs Unity 6000.6 at the Hub's usual path (or `UNITY_APP`) and the project's `Library` folder: open the project in Unity once, so that Unity has compiled a Level 3 game and written its compiler arguments (`Library/Bee/artifacts/*/Curriculum.Level3.*.rsp`). Set `UNITY_PROJECT` to check against another copy of the project.

Run it, with `node assemble.mjs --check`, before committing a change to a book or to a game's scripts.

## Changing or adding a concept chapter

**To change one:**

1. Edit its file in `Docs~/concepts/`, once. The same text goes into every book, so keep it about C# and Unity, not about one game.
2. Keep the first line `## C# — Title`, and point to other concepts with `{{ref:id}}`, never with a number: the numbers differ from book to book.
3. Run `node assemble.mjs`, `node assemble.mjs --check` and `node check-code.mjs`.
4. Rebuild **each** Level 3 book's PDF (next section), and commit the re-assembled `workbook.md` files too: the website reads them.

**To add one:** write the file (starting with `## C# — Title`), add it to `CONCEPT_LIST` in `assemble.mjs` with the ids it builds on (`needs`), put `{{concept:id}}` in **every** `book.md`, after the chapters it needs and before the build chapter that uses it, then assemble, check and rebuild every PDF. The assembler refuses a book that leaves it out.

The same goes for `shared/check-yourself.md`: edit it once, assemble, rebuild every PDF. Its "What does this print?" answers were checked by running the code; check a changed one the same way.

## Building the PDFs

```bash
cd Assets/Levels/Level3-Shared/Docs~/pdf
npm install                  # first time only
node build.mjs ../../../Level3-KnightRun/Docs~/workbook/workbook.md ../../../Level3-KnightRun/Docs/Level3-KnightRun-Workbook.pdf
node build.mjs ../../../Level3-CryptKeys/Docs~/workbook/workbook.md ../../../Level3-CryptKeys/Docs/Level3-CryptKeys-Workbook.pdf
node build.mjs ../../../Level3-GateGuard/Docs~/workbook/workbook.md ../../../Level3-GateGuard/Docs/Level3-GateGuard-Workbook.pdf
node build.mjs ../entry-test/test.md ../../Docs/Level3-Entry-Test.pdf
node build.mjs ../entry-test/answer-key.md ../../Docs/Level3-Entry-Test-Answer-Key.pdf
```

Assemble first: the builder reads `workbook.md`, not `book.md`. It needs Google Chrome: `build.mjs` looks for it at the macOS path (`/Applications/Google Chrome.app/…`); anywhere else, set `CHROME_PATH`. It ends by printing `wrote <file> (N pages)`.

`build.mjs` and `style.css` here are copies of Level 2's (`../Level2-Shared/Docs~/pdf`), which describes in full what the builder does: Level 3 books use the same cover (`coverArt: image`, with `coverImage: cover.png` from the book's `Docs~/workbook/` folder), the same headers, and code at 7.8 pt. After changing either file in one place, copy it to the other, and to Levels 0 and 1 (keeping their 8.5 pt code). Two things to know when writing a book:

- A numbered list step can hold a code block, but not a table: write the table after the step, unindented, and the next step (`2.`) keeps its number.
- A test paper sets `keepCode: true` in its front matter, so every code card that fits on a page moves to the next page whole and no question's code is split; books leave it out. The entry test's cover is `coverArt: code` with `coverCode: level2`, a code editor showing Level 2 C#.
- Each book's `cover.png` is a screenshot of its game, 1280 × 768: for Knight Run and Crypt Keys at a whole number of screen pixels for each art pixel, so pixel art stays sharp; for Gate Guard, a Play-mode shot of wave 10 with the HUD in it.

## The Level 3 entry test

Students join Level 3 by passing the **Level 3 entry test**, which tests Level 2 and checks every line of the "Before Level 3: can you…" list at the end of every Level 2 book. It lives here, shared by the three Level 3 games. `Docs/ENTRY_TEST_SPEC.md` describes it in full.

| Part | Time | Marks | To pass |
| --- | --- | --- | --- |
| **Written paper:** 20 questions on Level 2 (properties and constructors, `static`, `const` and `readonly`, overloads and `out`, numbers and casts, arrays, lists and dictionaries, event functions, `GetComponent`, vectors, coroutines and `Time.timeScale`, the pointer, rays with masks, UI events, `null` and the debugger, the Scripting API) | 40 minutes | 20 | 14 |
| **Practical task:** Meteor Defence, a small 2D game built from a description: meteors fall at a city, blasted with a click or a tap (`Pointer.current` and a masked `OverlapPoint`), waves from a coroutine and a `List`, points and counts in dictionaries, a `private set` score, a settings panel that pauses, with a Slider through `AddListener`, and `StopCoroutine` when the city falls | 90 minutes | 100 | 70 |

- `Docs/Level3-Entry-Test.pdf`: the student paper, a cover and 14 pages. Sections 1–2 (the rules and the written paper) are pages 1–11, and Section 3 (the practical task) is pages 12–14, so trainers can print the written paper and the task as two sets, and hand out the task (with the Level 2 cheat sheet) only after collecting the written paper. Check this still holds after editing `test.md`: the answer key's "Before the test" list quotes those pages, and their PDF page numbers.
- `Docs/Level3-Entry-Test-Answer-Key.pdf`: **trainer only**: how to run and mark the test, every answer with the Level 2 chapter to review, the practical's rubric, a model solution, what to do with each result, and changed numbers for retakes.
- `Docs~/entry-test/`: their sources, and the model solution's two scripts. The key's code cards are copies of them, byte for byte; the scripts use only Level 2 C#, within Level 2's code rules.

Every code answer in the key, and every retake answer, was run in Unity 6000.6, and the model solution was play-tested in a scene built from the paper's setup steps (the spec's section 6). After changing a question or the model solution, check it the same way, then rebuild both papers (the commands in "Building the PDFs" above). The entry test isn't part of the course site.

> **Watch out:** the answer key is in the project like everything else. If the repository is ever made public, the key is public too: keep a trainer-only copy elsewhere, or leave the key out of the repository.

## The builder kit

`Editor/Level3BuilderKit.cs` is a static class of helpers for the Level 3 scene builders (**Tools → Knight Run (Level 3) → Build Scene**, **Tools → Crypt Keys (Level 3) → Build Scene** and **Tools → Gate Guard (Level 3) → Build Scene**). The builders use it with `using static Level3BuilderKit;`, and each game's Editor assembly references `Curriculum.Level3.Shared.Editor`. It isn't part of any book, and never goes into a build. It starts from Level 2's kit, so Level 2's helpers are all here (see `../Level2-Shared/README.md`): project setup, filling `[SerializeField]` fields, sounds, sprites and materials, and the UI controls. Level 3 adds:

| Helpers | Do |
| --- | --- |
| `SaveOver<T>`, `MakePhysicsMaterial` | Save an asset over the one already at its path, so it keeps its GUID and everything that points to it still does; a Physics Material 2D with a friction and a bounciness. |
| `IgnoreCollisions` | Unticks a box in **Project Settings → Physics 2D → Layer Collision Matrix**. |
| `MakeFontAsset` | A TextMeshPro font asset made as **Assets → Create → TextMeshPro → Font Asset → SDF** makes it: a dynamic SDF atlas, its texture and material named after the font, and the full Distance Field shader, so the material's Outline panel matches the book. |
| `ImportSpriteSheet`, `ImportSpriteRects`, `GridCells` | Import a sheet as pixel art (Sprite Mode Multiple, Point filter, no compression) and slice it: into a grid, keeping only the cells with something in them and naming them as the Sprite Editor does (`knight_0`, `knight_1`…, top row first), or into given rectangles. `GridCells` lists a grid's non-empty cells, in that order. |
| `SpriteCut`, `ImportSpriteCuts` | Cut a sheet into named sprites, each with its own rectangle, pivot and 9-slice border: a tileset's 32 × 32 cells and, on the same sheet, its tall props with their pivots at their feet (Crypt Keys). |
| `ImportSprite` | A one-picture sprite (Sprite Mode Single) as pixel art: Pixels Per Unit, pivot, Point filter, no compression, and a 9-slice border if it has one. |
| `MakeRandomRuleTile` | A Rule Tile with one rule and no neighbours, Output Random, among a list of sprites: a floor that never repeats (Crypt Keys). |
| `MakeTile`, `MakeTilePalette` | A Tile asset for a sprite, with a Grid collider, and a Tile Palette with the tiles laid out as in their sheet. |
| `MakeSpriteClip`, `MakePropertyClip`, `SetCurve`, `SetColourCurve`, `SetEvents` | Animation clips: sprite frames at a frame rate, as dragging frames into the Animation window does; property curves on the clip's GameObject or a child, named as the Animation window names them; and Animation Events. |
| `MakeController`, `AddState`, `AddTransition`, `AddExitTransition`, `AddAnyStateTransition`, `MakeOverrideController` | Animator Controllers: emptied and refilled in place, so they keep their GUIDs (states, sub-state machines, Entry and Any State transitions and parameters all go); states, in the Base Layer or in a sub-state machine; transitions with Transition Duration 0 and Has Exit Time only when asked for, to a state or to a machine's Exit; Any State transitions with Can Transition To Self off, made on the Base Layer, the only place Unity runs them from; Override Controllers. |

All the builders share it: after changing it, run each game's **Build Scene** again and check its scene. Crypt Keys' additions were checked that way: Knight Run's builder builds the same scene with them, and its play tests pass. Gate Guard added nothing to it: its 3D helpers (models' and clips' import settings, Humanoid Avatars, the hex battlefield, the 3D renderer, the particles) are in its own builder, since no other Level 3 game needs them, and it uses the kit's Animator, clip, UI and font helpers as they are.
