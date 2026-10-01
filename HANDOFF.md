# Unity Programmer Curriculum — Handoff

_Written on 1 October 2026, when the work moved from a Claude cloud session to VS Code._

This file is the map, the current status and the to-do list. The details live in each
level's `README.md` and build spec: when this file and a README disagree, trust the
README and fix this file.

**Claude in VS Code:** read this file first, then the README of the folder you're about
to work in. Section 9 lists the working rules.

---

## 1. The curriculum

The course runs from zero coding to mid-level Unity programmer in seven levels. Each level
has one or more games. Each game has a fully guided book (a PDF and website pages), the
finished code, an instructor scene builder and a build spec. From Level 1 on, every level
also has an entry test (a written paper and a practical task) with an answer key.
Level N's exit test is Level N+1's entry test.

| Level | Name | Games | Status |
| --- | --- | --- | --- |
| 0 | Zero | Rocket Launch | Done |
| 1 | Beginner | Catch the Falling Blocks | Done, with its entry test |
| 2 | Builder | Mini Golf (3D), Space Shooter (2D), Tank Arena (2D) | Done, with its entry test |
| 3 | Junior-ready | not chosen yet | **Next.** Ends at **Unity Certified User: Programmer** |
| 4 | Junior | not chosen yet | Ends at **Unity Certified Associate: Programmer** |
| 5 | Mid-level I | not chosen yet | |
| 6 | Mid-level II | not chosen yet | |

The topics of each level, with the exam objective each prepares for, are in the
**Level Reference**: `Assets/Levels/Unity-Programmer-Curriculum-Levels.pdf`. It's also
in the claude.ai project "AppTrainers", as `claude/unity-programmer-curriculum-levels.md`.
Levels 0–3 together should add up to about 150 hours of Unity use and training, which
Unity expects before the User exam.

Decisions so far:

- Students start with zero coding and zero Unity. Level 0 is open to anyone. Level 1 and
  above need the previous level's exam.
- Catch the Falling Blocks replaced Balloon Pop at Level 1.
- From Level 2 on, build **all** the candidate games for a level, each as a book that
  stands alone. A trainer then teaches one game or all of them, depending on the course
  length.
- The book format follows Moayad's Catch game workbook (`~/apptrainers/catch-game/Docs`):
  build chapters interleaved with C# Concept chapters, in one combined PDF per game.
- Each level gets a build spec (`Docs/*_BUILD_SPEC.md`) that can be handed to Claude in
  VS Code.

---

## 2. The project

`~/apptrainers/unity-programmer-curriculum-levels` is one Unity project for the whole curriculum.

- Unity **6000.6.3f1**, from the **Universal 2D** template: URP 17.6, Input System 1.20
  (the **only** input backend), and uGUI 2.6 with TextMeshPro.
- **Enter Play Mode Options** is set to **Reload Scene only**, so static values survive
  from one Play to the next.
- GitHub repo: `AppTrainers-Curriculums/unity-programmer-curriculum-levels`. The remote
  uses the SSH host alias `github-work`. Binary files (PDFs, images, audio, models) are in
  **Git LFS**.

| Path | What it holds |
| --- | --- |
| `Assets/Levels/Level0/` | **Rocket Launch.** 2 scripts, the scene builder, `Scenes/Launch.unity`, the book: 10 chapters and 11 C# Concept chapters, 69 pages |
| `Assets/Levels/Level1/` | **Catch the Falling Blocks.** 4 scripts, 3 prefabs, sounds, the scene builder, `Scenes/Catch.unity`, the book: 11 chapters and 6 C# Concept chapters, 72 pages. Also the **Level 1 entry test** and its answer key; the practical task is "the Elevator" |
| `Assets/Levels/Level2-Shared/` | Shared by the three Level 2 books: the 15 C# Concept chapters, the Check Yourself part, the book assembler, the PDF builder, the scene builders' helper kit, and the **Level 2 entry test** with its answer key; the practical task is "Firefly Catcher" |
| `Assets/Levels/Level2-MiniGolf/` | **Mini Golf**, 3D, with Kenney's Minigolf Kit. 12 scripts, the builder, the book: 15 chapters, 158 pages |
| `Assets/Levels/Level2-SpaceShooter/` | **Space Shooter**, 2D, with Kenney's Space Shooter Remastered. 11 scripts, the builder, the book: 14 chapters, 173 pages |
| `Assets/Levels/Level2-TankArena/` | **Tank Arena**, 2D top-down, with Kenney's Top-down Tanks. 12 scripts, the builder, the book: 15 chapters, 187 pages |
| `Assets/Levels/Unity-Programmer-Curriculum-Levels.pdf` | The Level Reference. The website's home page links it |
| `web/` | The course website (Astro and Starlight), built from the books' `workbook.md` files. See `web/README.md` |
| `.github/workflows/deploy.yml` | Builds the site and deploys it to GitHub Pages |

Inside each level folder:

- `Scripts/`: the finished student code.
- `Editor/`: the scene builder.
- `Docs/`: the PDFs and the build spec.
- `Docs~/`: sources Unity ignores, such as `workbook/` and `entry-test/`.

Each Level 2 game keeps its scripts in its own assemblies, one for runtime and one for
the Editor, because the games share class names such as `SettingsMenu` and
`CameraFollow`. Students never see this: in their own projects, scripts go in
`Assets/Scripts`.

---

## 3. What's done

### Level 0: Rocket Launch

A rocket stands on a launch pad. The Console prints a mission briefing and a countdown,
then the rocket lifts off and climbs to orbit, burning fuel as it goes. There's no player
input. The book covers:

- program order, variables and types, operators, `if` / `else`, methods, parameters,
  return values and comments;
- the editor windows, the Transform, `Start` / `Update` and `Debug.Log`.

### Level 1: Catch the Falling Blocks

A bar steered with the keyboard catches falling blocks: a red block is worth 1 point and
a gold one 5. Catching a purple block, or missing a red or gold one, costs one of three
lives. The blocks fall faster and faster. The game has a start screen, Game Over, Play
Again, sounds and a Web build.

- **C#:** scope and access, classes and objects, arrays, loops, enums, `switch` and `?:`,
  string interpolation and formatting.
- **Unity:** the Input System keyboard, `Time.deltaTime`, Rigidbody 2D and triggers,
  prefabs, `Instantiate` / `Destroy`, tags, TextMeshPro UI and buttons, audio, and a Web
  build.
- **Level 1 entry test** (it tests Level 0): a written paper of 20 questions (40 minutes,
  pass with 14) and the Elevator practical (50 minutes, pass with 70 out of 100).

### Level 2: three games, three standalone books

- Every book teaches all of Level 2, so a trainer can run one book, or give different
  groups different games. The 15 C# Concept chapters are the same in each book; each
  book places them where its game first needs them. They are:
  - vectors, event functions, methods in depth, and mouse and touch;
  - components and `GetComponent`, properties and constructors, and `static`, `const`
    and `readonly`;
  - coroutines and timers, lists, numbers and conversions, and raycasts;
  - using the Unity docs, dictionaries, UI events, and `null` and debugging.
- Every book ends with **Check Yourself**: exam-style questions, a cheat sheet and the
  Level 3 readiness checklist.
- Every game plays on a computer and with a finger on a phone, and has a settings panel
  that pauses the game. It has a Web build for itch.io, with an itch.io viewport of
  960 × 600.
- Every code step was checked by following the book exactly, compiling the project after
  each step. The final code cards match `Scripts/` byte for byte.
- **Mini Golf fixes, from your testing:**
  - The Kenney tiles are pictures only: **Generate Colliders** is off.
  - Each hole has a `Colliders` child: **one floor box for the whole hole**, with no
    seams, plus one box per wall. That was your "one collider on the parent" idea.
  - A hole always ends: after 8 strokes it stops (`GolfTerms.MaxStrokes`), so you can
    always play on. **Still waiting for your retest in Unity.**
- **Level 2 entry test** (it tests Level 1): a written paper of 20 questions (40 minutes,
  pass with 14) and the Firefly Catcher practical (75 minutes, pass with 70 out of 100).
  Two independent reviews checked it, and their fixes are in.

### Entry tests (Levels 1 and 2)

- Print each paper as **two sets**: Sections 1–2 (the cover and pages 1–7) and Section 3
  (page 8 to the end).
- Students get the practical task and the cheat sheet only **after** the trainer collects
  the written paper.
- The answer keys are trainer-only. They are in the repo (`Level1/Docs`,
  `Level2-Shared/Docs`) but not on the website. **If the GitHub repo is public, so are the
  keys.**

### PDFs: one builder for every level

- `Level2-Shared/Docs~/pdf/build.mjs` and `style.css` build every PDF. There are copies in
  `Level0/Docs~/workbook/` and `Level1/Docs~/workbook/`. The only difference is that
  Levels 0 and 1 set code at 8.5 pt, and Level 2 at 7.8 pt.
- Fixed during the Level 2 work:
  - pages printed shrunk (at about 78% for Level 2 and 87% for Level 0);
  - the bundled fonts never loaded;
  - numbered steps restarted at 1 after a code block.
- The builder now:
  - keeps headings, lead-ins and short lists with what follows them;
  - lets long code cards and tables continue on the next page;
  - sets a chapter a little tighter when its last page would hold only a line or two.
- **All nine PDFs were last built on this Mac** (1 October), so they match: Apple emoji,
  and Inter and JetBrains Mono at their real weights. Chrome on Linux sets the same book
  with Noto emoji, regular weights only and other line breaks, so build them all here.
  Built here, the Level 2 entry test is a cover and 10 pages; Section 3 still starts on
  page 8.

### Website

- Live at <https://apptrainers-curriculums.github.io/unity-programmer-curriculum-levels/>.
- Levels 0 and 1 and all three Level 2 books are **published and password-protected**.
  Each has its own secret: `COURSE_PW_LEVEL_0`, `COURSE_PW_LEVEL_1`,
  `COURSE_PW_LEVEL_2_MINI_GOLF`, `COURSE_PW_LEVEL_2_SPACE_SHOOTER` and
  `COURSE_PW_LEVEL_2_TANK_ARENA`.
- Each level also has an unlisted "All the Code" page at `/code/<slug>/`.

### Project clean-up

- **SampleScene is deleted**, along with its `.meta` and the empty `Assets/Scenes`
  folder, and it's gone from Build Settings.
- Every scene builder now puts its own scene **first** in Build Settings, so a Web build
  opens the game you built last. Each builder also drops any scene whose file has been
  deleted.

---

## 4. The state right now (1 October 2026)

- **Everything is committed and pushed**, and the website is deployed. The latest
  commits:
  - `50ecd27`: `UnityAction\<float>` is escaped in the shared `ui-events.md`, so the
    PDFs and the website no longer drop `<float>`. The three Level 2 books are
    re-assembled, every PDF is rebuilt on this Mac (see "PDFs" in section 3), the PDF
    builder's folder ignores `node_modules/` and `build/`, and the READMEs are up to date.
  - `1cfdfa4`: the website's importer keeps a `\<` that a book already escaped.
  - Then this file, and `Assets/Welcome/2d-template.png` moved into Git LFS. It was the
    one PNG committed before the LFS rule, so git always listed it as modified.
- The three Kenney zips are deleted from the project root: everything in them was
  already unpacked into the games.
- **Unity:**
  - The editor was open when SampleScene was deleted. **Restart it**, so Build Settings
    stop listing SampleScene.
  - Build Settings list Launch, Catch, MiniGolf and SpaceShooter. **Tank Arena's scene
    hasn't been built on this Mac yet:** run **Tools → Tank Arena (Level 2) → Build Scene**.

---

## 5. How to build and check

**A Level 2 book.** Edit the game's `Docs~/workbook/book.md` or a shared chapter. Never
edit `workbook.md`, which is generated.

```bash
cd Assets/Levels/Level2-Shared/Docs~
node assemble.mjs           # book.md + shared chapters → every game's workbook.md
node assemble.mjs --check   # says whether every workbook.md is up to date
```

**A PDF.** You need Node and Google Chrome. Run `npm install` once in each builder folder.

```bash
# Level 2: the books and the entry test
cd Assets/Levels/Level2-Shared/Docs~/pdf
npm install
node build.mjs ../../../Level2-MiniGolf/Docs~/workbook/workbook.md ../../../Level2-MiniGolf/Docs/Level2-MiniGolf-Workbook.pdf
node build.mjs ../../../Level2-SpaceShooter/Docs~/workbook/workbook.md ../../../Level2-SpaceShooter/Docs/Level2-SpaceShooter-Workbook.pdf
node build.mjs ../../../Level2-TankArena/Docs~/workbook/workbook.md ../../../Level2-TankArena/Docs/Level2-TankArena-Workbook.pdf
node build.mjs ../entry-test/test.md ../../Docs/Level2-Entry-Test.pdf
node build.mjs ../entry-test/answer-key.md ../../Docs/Level2-Entry-Test-Answer-Key.pdf

# Level 1: the book and the entry test
cd Assets/Levels/Level1/Docs~/workbook
npm install
node build.mjs workbook.md ../../Docs/Level1-CatchTheBlocks-Workbook.pdf
node build.mjs ../entry-test/test.md ../../Docs/Level1-Entry-Test.pdf
node build.mjs ../entry-test/answer-key.md ../../Docs/Level1-Entry-Test-Answer-Key.pdf

# Level 0: the book
cd Assets/Levels/Level0/Docs~/workbook
npm install
node build.mjs workbook.md ../../Docs/Level0-RocketLaunch-Workbook.pdf
```

What the builder prints:

- the chapters it set tighter;
- a `note:` if a chapter still ends on a nearly empty page;
- an error naming any font that didn't load.

**The website**

```bash
cd web
npm install
npm run dev    # http://localhost:4321/unity-programmer-curriculum-levels/
```

Pushing to `main` a change under `web/`, or to a book's `workbook.md`, deploys the site.
The deploy fails if a protected level has no password secret. See `web/README.md`.

**Code cards.** Every game's README (Levels 0–2) has a short Python snippet, under "Keep
the code cards honest", that compares every ` ```csharp:File.cs ` card with `Scripts/`. Run
it after changing a script or a card.

**Scene builders.** These are instructor tools, run from Unity's **Tools** menu:

- **Tools → Rocket Launch (Level 0) → Build Scene**
- **Tools → Catch the Falling Blocks (Level 1) → Build Scene**
- **Tools → Mini Golf (Level 2) → Build Scene**, and the same for Space Shooter and Tank
  Arena

Running a builder again overwrites its scene and prefabs. With the editor **closed**, you
can also run a builder from the terminal. This hasn't been tried yet:

```bash
"/Applications/Unity/Hub/Editor/6000.6.3f1/Unity.app/Contents/MacOS/Unity" \
  -batchmode -nographics -projectPath . \
  -executeMethod TankArenaSceneBuilder.Build -quit -logFile -
```

The other classes are `RocketSceneBuilder`, `CatchSceneBuilder`, `MiniGolfSceneBuilder`
and `SpaceShooterSceneBuilder`. Each has a `Build()` method. A batch-mode run also
compiles every script, so it doubles as a compile check that VS Code can run.

**Not in the repo.** The cloud session had some helper scripts that were never moved here:

- the Tank Arena and Space Shooter book drafts;
- the stage-by-stage script versions;
- the script that followed each book step by step and compiled every step;
- the PDF layout checks.

Now `book.md`, `Scripts/` and the specs are the source of truth. When a script changes,
update by hand the earlier versions of it that the book shows, then check by following
the book.

---

## 6. Conventions

**Books**

- **Structure:**
  - `# Part N — Title` for parts;
  - `## Chapter N — Title` for a build chapter, with a red header;
  - `## C# N — Title` for a C# Concept chapter, with a slate header;
  - `## Section N — Title` for the sections of a test paper.
- **Inside a chapter:**
  - every chapter opens with `**Goal:** …`;
  - beats are `### Idea`, `### Do it`, `### Test it` and `### Challenge`, optionally
    `### Do it — the script`;
  - callouts are `> **Tip:**`, `> **Note:**` and `> **Watch out:**`.
- **Code:**
  - a whole final script is a card, ` ```csharp:File.cs `, and must equal `Scripts/`
    byte for byte;
  - an earlier version of a script is an unnamed ` ```csharp ` block;
  - Console output is a plain fence right after the code.
- **Steps:** a numbered step that continues after a code block keeps its number: write
  `3.`, and it's drawn as step 3.
- **Level 2 only:**
  - shared chapters live in `Level2-Shared/Docs~/concepts/` and are included with
    `{{concept:id}}`;
  - cross-references are `{{ref:id}}`;
  - the ids are listed in `Level2-Shared/README.md`.
- **Writing:** plain English, short sentences, second person, British spelling (`colour`).
  Explain the why, not only the what.
- **Level limits:** each build spec lists the C# allowed at its level. Never use a topic
  before the level that teaches it. Every code step must compile at its chapter. When a
  step deliberately leaves an error in the Console until the next step, the book says so.

**Code**

- **Input:** the Input System only. Use `Keyboard.current` and `Pointer.current`, and
  check them for `null`, because a phone has no keyboard. Never use the old `Input` class
  in game code: it throws errors in this project. The books show the old equivalents in
  a table, because the exams still use them.
- **Fields:** `[SerializeField]` private fields for anything set in the Inspector.
  Students learn properties at Level 2.
- **Comments:** the finished scripts are commented for students, in the same plain voice
  as the books.

**Assets**

- The art is from Kenney's packs, which are CC0. Each `Art/` folder holds Kenney's
  licence.
- Space Shooter uses Kenney's sounds. The other games' sounds were made for the course.
- **Downloading any asset needs Moayad's permission first.**

---

## 7. What's next

1. **Unity checks:**
   - Restart Unity.
   - Build the Tank Arena scene, then play-test all three Level 2 games with the
     keyboard, the mouse and the Device Simulator (for touch).
   - **Retest the Mini Golf fixes:** the ball shouldn't catch on tile edges, and a hole
     should end after 8 strokes.
2. **Level Reference:** fill in Level 2's row in "Next step: games per level" with Mini
   Golf, Space Shooter and Tank Arena and their topics. Do it in both the PDF and the
   claude.ai project doc.
3. **Level 3, Junior-ready.** It ends at the Certified User: Programmer exam.
   - **Topics, from the Level Reference:**
     - state machines with `enum` + `switch`;
     - the Animator Controller: states, transitions, parameters, and `SetTrigger`,
       `SetBool`, `SetFloat` and `SetInteger` from code;
     - Animation Events;
     - enemy behaviour as a state machine;
     - UI: health bars and menus;
     - naming conventions, reading code and picking the right comment, and recognising
       class types (MonoBehaviour, ScriptableObject, plain C#, ECS);
     - exam readiness.
   - **Steps:**
     1. Propose the candidate games, and agree them with Moayad. Then build all of them,
        as for Level 2.
     2. Write the **Level 3 entry test**, which tests Level 2: a written paper and a
        practical task, with an answer key, as in `Level2-Shared/Docs~/entry-test/`.
     3. For several games, copy Level 2's structure: a `Level3-Shared` folder for the
        concept chapters, the assembler, the PDF builder (copy Level 2's) and the entry
        test, plus one folder per game. Add each book to `web/levels.config.mjs`, and
        add its password secret and its line in `deploy.yml`.
4. **Optional:**
   - Move the answer keys out of the repo if it's public.
   - Add a small book checker to the repo, one that compiles each chapter's code.

---

## 8. This conversation, in short

- **Level 1.** Built Catch the Falling Blocks: scripts and sounds, the scene builder, the
  book, the entry test (the Elevator) with its answer key, and the website entry. It's
  installed in the project.
- **Level 2.** Your brief: *"three fully guided books, so we can teach one of them or 3
  at the course, it will depends on the time of the course"*, *"3D with Kenney's minigolf
  kit"* and *"Allow for permission"*; then *"let's all of them"*. You put the three Kenney
  zips beside `Assets`. I unpacked them into the three games, and built the 15 shared
  C# Concept chapters, the assembler and the three games with their books.
- **Mini Golf bugs you reported:**
  - *"each model has its own mesh collider and this is heavy, and the ball collision with
    edge of the model while moving"*;
  - *"when the ball not reach the hole, i can not play again"*;
  - and later *"we should add one collider on all models on the parent"*.

  The tile colliders are off, each hole has one floor box plus a box per wall, and there's
  an 8-stroke limit. Waiting for your retest.
- **The Unity command-line package.** You suggested *"install the pipeline package of
  CLI"*. The cloud session couldn't start the Unity editor, so it checked code by
  compiling against Unity's libraries. In VS Code, Claude can run Unity in batch mode
  (section 5).
- **Tank Arena.** Finished, checked by following the book step by step, and reviewed
  independently.
- **Level 2 entry test.** Firefly Catcher, reviewed twice. The fixes:
  - insects use Sleeping Mode **Never Sleep**, so a still insect can still be caught;
  - the practical is 75 minutes;
  - the paper is printed as two sets;
  - Question 4 tests a Web build;
  - and more.
- **PDFs.** Fixed the shrunk pages, the fonts that never loaded and the numbered steps
  that restarted after code, for Levels 0, 1 and 2, and rebuilt all nine PDFs. Level 1's
  entry test got the same two-set handout as Level 2's.
- **Today:** *"yes fix it"* (the Level 0 and 1 PDFs) and *"remove the SampleScene from
  the project"*: done, as in section 3. Then *"give me an md file … i want to move the
  work in VSCode"*: this file.
- **Then, in VS Code (1 October):** the three Level 2 books and the Level Reference PDF
  went on the website. `UnityAction<float>` was fixed in the shared UI Events chapter:
  every Level 2 PDF had printed it as `UnityAction`. All nine PDFs were rebuilt on the
  Mac, so they match. The Kenney zips were deleted, and `Assets/Welcome/2d-template.png`
  moved into Git LFS.

---

## 9. Working rules (for Claude)

- **Commit only when Moayad asks.** The author is `Moayad <moayad.rahhal@hotmail.com>`.
  Git LFS must be installed (`git lfs install`), because the PDFs, images, audio and
  models are LFS files.
- **Ask before any download**, and before adding a package or an asset.
- **Delete only what Moayad asked for.** A deleted file in this project can't be undone
  outside Git.
- After editing a shared C# Concept chapter, **re-assemble the Level 2 books and rebuild
  their PDFs**. The website reads `workbook.md`, so commit the assembled files too.
- After changing `build.mjs` or `style.css`, copy the change to the other levels' builder
  folders, but keep Levels 0–1 at 8.5 pt code. Rebuild the PDFs it affects, and look at
  the pages.
- **Build every PDF on this Mac.** Chrome on another system picks other fallback fonts
  and emoji, and breaks pages differently, so the books stop matching.
- Keep each game's README and build spec true to its code. They are what the next person,
  or the next Claude, reads first.
