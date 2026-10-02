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
| 3 | Junior-ready | **Knight Run** (core), then Crypt Keys and Gate Guard | Done, with its entry test. Ends at **Unity Certified User: Programmer** |
| 4 | Junior | Planned: **Arcane Duel** (core), Pocket Karts, Juice Tycoon | Ends at **Unity Certified Associate: Programmer** |
| 5 | Mid-level I | Planned: **Lost Ruins** (core), Box Pusher, Tiny Colony (optional) | |
| 6 | Mid-level II | Planned: **Card Table** (core), Arena Online (optional) | |

The games for Levels 3–6 are in **`GAMES_PLAN.md`**, with a brief for each game and the
recipe for building a level. Each level's **core game** is the best one for teaching all of
the level, and the one to build first; a course with time for only one game per level
teaches it.

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
| `Assets/Levels/Level3-Shared/` | Shared by the Level 3 books: the 12 C# Concept chapters, the Check Yourself part, the book assembler, the **code checker** (`check-code.mjs`), the PDF builder and the scene builders' helper kit. The Level 3 entry test will go here |
| `Assets/Levels/Level3-KnightRun/` | **Knight Run**, a 2D platformer, with the Brackeys Platformer Bundle. 14 scripts, the builder and its level map, the book: 15 chapters and 12 C# Concept chapters, 228 pages |
| `Assets/Levels/Unity-Programmer-Curriculum-Levels.pdf` | The Level Reference. The website's home page links it |
| `web/` | The course website (Astro and Starlight), built from the books' `workbook.md` files. See `web/README.md` |
| `.github/workflows/deploy.yml` | Builds the site and deploys it to GitHub Pages |

Inside each level folder:

- `Scripts/`: the finished student code.
- `Editor/`: the scene builder.
- `Docs/`: the PDFs and the build spec.
- `Docs~/`: sources Unity ignores, such as `workbook/` and `entry-test/`.

Each Level 2 and Level 3 game keeps its scripts in its own assemblies, one for runtime
and one for the Editor, because the games share class names such as `SettingsMenu` and
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

### Level 3: Knight Run

A knight runs, jumps and rolls through one long level in three sections painted on
Tilemaps (the Meadow, the Autumn Woods, the Castle Walls). Green and purple slimes patrol,
chase and leap; he stomps them or rolls into them. 5 health and a health bar, knockback
and blinking, checkpoints, apples, 30 coins, a start screen, pause, win and lose screens,
Restart without reloading, sound and music, and touch buttons on a phone. The art, sound
and font are the **Brackeys Platformer Bundle** (CC0); Moayad chose it, and approved
design version 2 (stomp and roll, no sword, every section painted step by step in the
book).

- **C# and Unity:** naming conventions; the Animation window, sprite-frame and property
  clips; the Animator Controller, its parameters, and `SetFloat`, `SetInteger`, `SetBool`
  and `SetTrigger` through `Animator.StringToHash`; Animation Events; state machines with
  `enum`, `switch` and one `EnterState`; an enemy as a state machine; an Override
  Controller; Tilemaps; UI health bars, panels and `Time.timeScale`; Event Triggers for
  touch; `[System.Serializable]` plain classes; reading code, finding errors, kinds of
  classes, and the User exam.
- **The book** (228 pages) shows each script as it grows, 33 versions in all, and every
  one compiles at its step: `Level3-Shared/Docs~/check-code.mjs` checks that with
  Unity's own compiler, and that the 14 final cards match `Scripts/`.
- **Checked in a copy of the project:** the scene builds with no errors or warnings, 15
  play tests pass (running, jumping, rolling, stomping, hurting, pits, checkpoints,
  pickups, Restart, the panels), and the screens were looked at. The Unity messages the
  book quotes (Animator warnings, Animation Event errors, the null and missing-component
  exceptions, `Time.timeScale` after Play mode) were copied from Unity 6000.6's Console.
- **On the website**, locked with `COURSE_PW_LEVEL_3_KNIGHT_RUN`.
- **Not done yet:** Moayad's own play-test in Unity.

### Level 3: Crypt Keys

A warrior explores a crypt of six rooms, stacked one above the other, each painted on
Tilemaps with a floor that never repeats (a Random Rule Tile). Keys from chests open the
doors in the rooms' top walls; skeletons patrol, chase and swing; skeleton archers keep
their distance and shoot from behind cover; the Skeleton King fights in two phases (a
double swing; then a summon of two skeletons and a whirlwind that turns the sword aside).
Three hearts in half hearts, potions, gold, a boss bar, a room camera, torchlight with 2D
lights, the pause menu, win and lose screens, Restart in code, sound and music, and
keyboard, mouse and touch control. The art is Foozle's **Lucifer** packs, Legend's keys
and 0x72's chests and hearts; the sound is **Ninja Adventure** (all CC0, `CREDITS.md`).
Moayad approved design version 1 with all six recommendations (*"i think all is good, go
a head"*).

- **C# and Unity, new in this book:** an Animator with four sub-state machines joined
  through Exit and Entry, built once and copied; one controller for four characters
  through Override Controllers, and a copied, extended one for the boss; pivots and
  colliders at the feet, Transparency Sort Axis sorting and a Sorting Group; the Pixel
  Perfect Camera; the Rule Tile; sprites cut by hand in the Sprite Editor; 2D lights and a
  flicker clip on a Light 2D; `Physics2D.OverlapCircleAll` and `Linecast` with layer
  masks; `Instantiate` of a scene object; hearts from `/` and `%`. The same 12 shared C#
  Concept chapters and Check Yourself as Knight Run.
- **The book** (286 pages) shows each script as it grows, 53 versions in all, every one
  compiling at its step (`check-code.mjs`), and its 18 final cards match `Scripts/`.
- **Checked in a copy of the project:** the scene builds with no errors or warnings, and
  14 play tests pass (walking through the sub-state machines, the sword's hit frame,
  skeletons, archers and arrows, keys, doors, chests, potions, the king's two phases and
  the win, the lose panel, Restart, pausing, and the whole crypt in order), with two more
  passes that take pictures. The lights, the rooms and the UI were looked at in Play-mode
  pictures. The Unity messages Chapter 15
  quotes were copied from Unity 6000.6's Console. Knight Run's builder still builds its
  scene with the extended builder kit, and its 15 play tests pass.
- **On the website:** entry `level-3-crypt-keys`, published, locked with
  `COURSE_PW_LEVEL_3_CRYPT_KEYS` (Moayad added the secret on 2 October).
- **Not done yet:** Moayad's own play-test in Unity. He ran **Build Scene** on 2 October.

### Level 3: Gate Guard

A 3D tower defence on a battlefield of KayKit hex tiles, seen from a camera that never
moves. Ten waves of skeletons (the Minion, the Rogue, the Warrior and, in wave 10, the
Bone Mage) rise out of the ruins and march along a winding road to the castle gate; the
player builds Arrow, Catapult and Frost towers on 13 dirt plots, upgrades them twice (a
second storey, then flags), and sells them for 60%. Ten lives, gold and bounties, wave
bonuses and a countdown, world-space health bars, a build menu that opens over the tapped
plot, double speed, the pause menu, win and lose screens (the gate's doors burst open and
the skeletons cheer), Restart in code, sound and music, soft shadows, and a camera that
shows the whole battlefield on any screen; played with a pointer. The models and clips
are **KayKit**'s (Medieval Hexagon, Skeletons, Adventurers, Character Animations), the
GUI **pzUH**'s, the icons **game-icons.net**'s (CC BY 3.0, credited on the Start panel),
the font **Lilita One**, the sound **Ninja Adventure** (`CREDITS.md`). Moayad approved
design version 1 with all six recommendations (*"All 6 approved"*).

- **C# and Unity, new in this book:** model import settings; **Humanoid Avatars** and
  clips from other files; a clip's Loop Time, root motion baked into the pose, and
  **Animation Events added in the Import Settings**; a state's **Speed Multiplier** from a
  parameter; one controller for four skeletons and one for three tower crews (an archer,
  a mage and a wooden catapult arm made of property clips), through Override Controllers;
  an **Int** that switches a tower's looks with **Is Active** keys; a **hex Grid** painted
  with the **GameObject Brush**; weapons on hand bones; `Physics.OverlapSphere`, a ray from
  the camera, `Camera.WorldToScreenPoint`; a **World Space Canvas**; a Trail Renderer, a
  Line Renderer and Particle Systems; a Physical Camera with Gate Fit. The same 12 shared
  C# Concept chapters and Check Yourself.
- **The book** (249 pages) shows each script as it grows, 44 versions in all, every one
  compiling at its step (`check-code.mjs`), and its 19 final cards match `Scripts/`.
- **Checked in a copy of the project (the lab):** the scene builds with no errors or
  warnings, and 11 play tests pass (building, upgrading and selling each tower; first in
  line, the release frame and the bounty; a stone's splash; frost's slow, in the code and
  in the walk clip; the gate's lives, its break, the cheer and the defeat; the waves,
  their bonus and the countdown; the boss and the win; pause and ×2; Restart), with two
  more passes that take pictures. Six design checks ran before building (section 13 of
  the spec). The panels, the HUD and the cover
  were looked at in Play-mode pictures, which found four layout faults, fixed; writing the
  book found the stone's landing sound almost silent (a 3D sound far from the listener),
  fixed.
- **Checked again on 2 October**, with all three Level 3 games in one project: the
  builder's scene matches the one built in Moayad's Editor, and the play tests pass.
  Chapter 15's breaks were made in the lab as the book has students make them: three
  messages were exactly as quoted, and the empty field's was wrong (it's a
  `NullReferenceException`), now corrected. The builder left the Start panel switched
  on, unlike Chapter 12: it switches it off now, so its scene matches the book's. And making `Rig_Medium_General` Humanoid logs 56 red
  `Assertion failed … IsFinite(curve.GetKey(0).value)` lines at every import, from two
  clips the game doesn't use: Chapter 3 now says so. The PDF was rebuilt (still 249
  pages).
- **On the website:** entry `level-3-gate-guard`, published, locked with
  `COURSE_PW_LEVEL_3_GATE_GUARD` (Moayad added the secret on 2 October).
- **Not done yet:** Moayad's own play-test in Unity (he ran **Build Scene** on 2 October),
  and a Web build on a phone with a late wave.

### Level 3 entry test

It tests Level 2, and checks every line of the "Before Level 3: can you…" list at the end
of every Level 2 book. Moayad approved design version 1 with *"all approved"* (the spec
is `Level3-Shared/Docs/ENTRY_TEST_SPEC.md`).

- **The written paper:** 20 questions in 40 minutes, pass with 14. It covers properties and
  constructors (one to write), `static`, `const` and `readonly`, overloads and `out`,
  numbers and casts, lists and dictionaries, event functions, `GetComponent`, vectors,
  coroutines and `Time.timeScale`, the pointer and the Simulator, rays with masks, UI
  events, a `NullReferenceException` and the debugger, and a Scripting API entry.
- **The practical, Meteor Defence:** 90 minutes, pass with 70 out of 100.
  - Meteors fall at a city, and the student blasts them with a click or a tap.
  - Waves come from a coroutine, with a `List` of the meteors in the sky.
  - Points and counts per size live in dictionaries, and the score has a `private set`.
  - A settings panel pauses the game, with a Slider connected through `AddListener`.
  - `StopCoroutine` runs when the city falls.
- **Checked:**
  - Every code answer and retake answer was run in Unity 6000.6, and the compile
    questions went through Unity's compiler.
  - The model solution passes 10 play tests, in a scene built by following the setup
    steps through Unity's own menus.
  - Two independent reviews were done, and their fixes are in: one against the Level 2
    chapters, one as a student and then a trainer.
- **The time:** the student reviewer put the practical at 85 to 95 minutes for a good
  student. It stays at the approved 90, and Moayad may want 105.
- `Level3-Shared/Docs/Level3-Entry-Test.pdf` (a cover and 14 pages) and the trainer-only
  `Level3-Entry-Test-Answer-Key.pdf` (a cover and 16 pages). Not on the website.

### Entry tests (Levels 1 to 3)

- Print each paper as **two sets**: Sections 1–2 and Section 3. That's the cover and pages
  1–7, then page 8 to the end, for Levels 1 and 2; and the cover and pages 1–11, then
  pages 12–14, for Level 3. A print dialog counts the cover as page 1: Level 3's key gives
  the PDF page numbers.
- Students get the practical task and the cheat sheet only **after** the trainer collects
  the written paper.
- The answer keys are trainer-only. They are in the repo (`Level1/Docs`,
  `Level2-Shared/Docs`, `Level3-Shared/Docs`) but not on the website. **If the GitHub repo
  is public, so are the keys.**

### PDFs: one builder for every level

- `Level2-Shared/Docs~/pdf/build.mjs` and `style.css` build every PDF. There are copies in
  `Level0/Docs~/workbook/`, `Level1/Docs~/workbook/` and `Level3-Shared/Docs~/pdf/`. The
  only difference is that Levels 0 and 1 set code at 8.5 pt, and Levels 2 and 3 at 7.8 pt.
- Fixed during the Level 2 work:
  - pages printed shrunk (at about 78% for Level 2 and 87% for Level 0);
  - the bundled fonts never loaded;
  - numbered steps restarted at 1 after a code block.
- The builder now:
  - keeps headings, lead-ins and short lists with what follows them;
  - lets long code cards and tables continue on the next page;
  - sets a chapter a little tighter when its last page would hold only a line or two.
- **All ten PDFs were last built on this Mac** (1 October), so they match: Apple emoji,
  and Inter and JetBrains Mono at their real weights. Chrome on Linux sets the same book
  with Noto emoji, regular weights only and other line breaks, so build them all here.
  Built here, the Level 2 entry test is a cover and 10 pages; Section 3 still starts on
  page 8.

### Website

- Live at <https://apptrainers-curriculums.github.io/unity-programmer-curriculum-levels/>.
- Levels 0 and 1, all three Level 2 books and all three Level 3 books are **published
  and password-protected**. Each has its own secret: `COURSE_PW_LEVEL_0`,
  `COURSE_PW_LEVEL_1`, `COURSE_PW_LEVEL_2_MINI_GOLF`, `COURSE_PW_LEVEL_2_SPACE_SHOOTER`,
  `COURSE_PW_LEVEL_2_TANK_ARENA`, `COURSE_PW_LEVEL_3_KNIGHT_RUN`,
  `COURSE_PW_LEVEL_3_CRYPT_KEYS` and `COURSE_PW_LEVEL_3_GATE_GUARD`. Crypt Keys and Gate
  Guard went live on 2 October.
- Each level also has an unlisted "All the Code" page at `/code/<slug>/`.

### Project clean-up

- **SampleScene is deleted**, along with its `.meta` and the empty `Assets/Scenes`
  folder, and it's gone from Build Settings.
- Every scene builder now puts its own scene **first** in Build Settings, so a Web build
  opens the game you built last. Each builder also drops any scene whose file has been
  deleted.

---

## 4. The state right now (2 October 2026)

- **Committed and pushed** (2 October): five commits add Crypt Keys and Gate Guard, each
  with its book, put both books on the website, and fix Gate Guard's Start panel in the
  builder and the scene. The website is deployed, with all three Level 3 books.
- **Unity:** **Build Scene** has been run on this Mac for all three games (Knight Run on
  1 October, Crypt Keys and Gate Guard on 2 October, Gate Guard again after the Start
  panel fix), and its scenes are committed. So the project has the `Ground`,
  `Knight`, `Enemy`, `Hero` and `Plot` layers and the Enemy–Enemy collision setting; the
  2D Renderer's Transparency Sort Mode is Custom Axis (Knight Run looks the same: each
  kind of sprite in it has its own Order in Layer, which Unity compares before the sort
  axis); and Gate Guard's Universal renderer is in the URP asset's renderer list. Build
  Settings lists Gate Guard's scene first. **Still to do:** Moayad's play-tests of the
  three games (keyboard, mouse and the Device Simulator), and a Web build of Gate Guard
  on a phone with a late wave on the road.
- **A fresh import of the project logs 56 red lines** for
  `Assets/Levels/Level3-GateGuard/Art/Animations/Rig_Medium_General.fbx`,
  `Assertion failed on expression: 'IsFinite(curve.GetKey(0).value)'`, and so does every
  reimport of that file: KayKit's two `Spawn` clips in it start with every bone at scale
  0, which a Humanoid can't take. The game doesn't use them; clear the lines. Gate
  Guard's spec (section 13) has the details.
- **The design pages** show each game's design version 1: Crypt Keys
  https://claude.ai/artifact/3nJ1vA36MxgW94FHq5kRJt, Gate Guard
  https://claude.ai/artifact/VTypoXoXvcjMypwJ2BgsfC. Each game's spec is the source of
  truth now. Gate Guard was made in a Remote Control session, from Moayad's phone: its
  packs were downloaded to that session's scratch folder, and only the files the game
  uses were copied in.
- **The Level 3 entry test is written, checked, committed and pushed** (section 3):
  - `Level3-Shared/Docs~/entry-test/` (the paper, the key and the model solution);
  - the two PDFs and the spec in `Level3-Shared/Docs/`;
  - the shared README, and Level 2's README for the builder's two new options;
  - the builder itself, in all four copies;
  - this file and `GAMES_PLAN.md`.

  The review page (https://claude.ai/artifact/CfHy5WP6FKQBPYe5CFAeTq) shows design version
  1; the spec is the source of truth now, and its section 9 lists what changed.
- `Assets/Levels/Level3-KnightRun/Art/Fonts/PixelOperator8 SDF.asset` shows as changed,
  and isn't committed: it's a dynamic font atlas, which grows whenever the Editor draws a
  letter it hasn't drawn before.
- From earlier, still open: restart Unity after the SampleScene deletion, build the Tank
  Arena scene on this Mac, and retest the Mini Golf fixes (section 7).

---

## 5. How to build and check

**A Level 2 or Level 3 book.** Edit the game's `Docs~/workbook/book.md` or a shared
chapter. Never edit `workbook.md`, which is generated.

```bash
cd Assets/Levels/Level2-Shared/Docs~      # or Level3-Shared/Docs~
node assemble.mjs           # book.md + shared chapters → every game's workbook.md
node assemble.mjs --check   # says whether every workbook.md is up to date
node check-code.mjs         # Level 3 only: compiles every script version in the books
```

`check-code.mjs` needs the project's `Library` (open the project in Unity once); with
the editor open on this project, point it at a copy with `UNITY_PROJECT=…`.

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

# Level 3: the books
cd Assets/Levels/Level3-Shared/Docs~/pdf
npm install
node build.mjs ../../../Level3-KnightRun/Docs~/workbook/workbook.md ../../../Level3-KnightRun/Docs/Level3-KnightRun-Workbook.pdf
node build.mjs ../../../Level3-CryptKeys/Docs~/workbook/workbook.md ../../../Level3-CryptKeys/Docs/Level3-CryptKeys-Workbook.pdf
node build.mjs ../../../Level3-GateGuard/Docs~/workbook/workbook.md ../../../Level3-GateGuard/Docs/Level3-GateGuard-Workbook.pdf
node build.mjs ../entry-test/test.md ../../Docs/Level3-Entry-Test.pdf
node build.mjs ../entry-test/answer-key.md ../../Docs/Level3-Entry-Test-Answer-Key.pdf
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
it after changing a script or a card. Level 3's `check-code.mjs` does that and more: it
also compiles every earlier version the book shows, at its step.

**Scene builders.** These are instructor tools, run from Unity's **Tools** menu:

- **Tools → Rocket Launch (Level 0) → Build Scene**
- **Tools → Catch the Falling Blocks (Level 1) → Build Scene**
- **Tools → Mini Golf (Level 2) → Build Scene**, and the same for Space Shooter and Tank
  Arena
- **Tools → Knight Run (Level 3) → Build Scene**

Running a builder again overwrites its scene and prefabs. With the editor **closed**, you
can also run a builder from the terminal. With it **open**, the project is locked: clone it
first (`cp -cR Assets Packages ProjectSettings Library <copy>`, which is instant on APFS)
and run the builder, or PlayMode tests (`-runTests -testPlatform PlayMode`), in the copy.
That's how Knight Run was built and tested:

```bash
"/Applications/Unity/Hub/Editor/6000.6.3f1/Unity.app/Contents/MacOS/Unity" \
  -batchmode -nographics -projectPath . \
  -executeMethod TankArenaSceneBuilder.Build -quit -logFile -
```

The other classes are `RocketSceneBuilder`, `CatchSceneBuilder`, `MiniGolfSceneBuilder`,
`SpaceShooterSceneBuilder` and `KnightRunSceneBuilder`. Each has a `Build()` method. A batch-mode run also
compiles every script, so it doubles as a compile check that VS Code can run.

**Not in the repo.** The cloud session had some helper scripts that were never moved here:

- the Tank Arena and Space Shooter book drafts;
- the stage-by-stage script versions;
- the script that followed each book step by step and compiled every step;
- the PDF layout checks.

Now `book.md`, `Scripts/` and the specs are the source of truth. When a script changes,
update by hand the earlier versions of it that the book shows, then check by following
the book (for Level 3, run `check-code.mjs`). Knight Run's chapter drafts were also put
together outside the repo, into `book.md`: edit `book.md` from now on.

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
  `3.`, and it's drawn as step 3. A step can hold a code block, but not a table: put the
  table after the step, unindented.
- **Levels 2 and 3:**
  - shared chapters live in `Level2-Shared/Docs~/concepts/` or
    `Level3-Shared/Docs~/concepts/` and are included with `{{concept:id}}`;
  - cross-references are `{{ref:id}}`;
  - the ids are listed in each shared folder's `README.md`.
- **Quoted Unity messages** are copied from Unity's Console, never written from memory:
  test them in a copy of the project first.
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

- The art is from Kenney's packs, which are CC0, and, for Knight Run, the Brackeys
  Platformer Bundle, also CC0. Each `Art/` folder holds its licence.
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
3. **Level 3, Junior-ready.** It ends at the Certified User: Programmer exam. **Knight
   Run, Crypt Keys and Gate Guard are built, committed, and their books published**
   (section 3; all three are on the website), and **the Level 3 entry test is written**
   (section 3). Next: Moayad's play-tests of the three games, and his look at the entry
   test (and its practical's time). Then Level 4 (`GAMES_PLAN.md`), one game at a time,
   each design shown first.
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
     1. The games are agreed (`GAMES_PLAN.md`): Knight Run (the core game), Crypt Keys
        and Gate Guard. Build all three, in that order, as for Level 2. Every book uses
        all four Animator parameter types, and Restart resets the level in code.
     2. Done: the **Level 3 entry test**, which tests Level 2: a written paper and a
        practical task, with an answer key, as in `Level2-Shared/Docs~/entry-test/`.
     3. `Level3-Shared` exists, with the concept chapters, the assembler, the code
        checker, the PDF builder and the builder kit; the entry test goes there too. Add
        each new book to `web/levels.config.mjs`, with its password secret and its line
        in `deploy.yml`.
4. **Optional:**
   - Move the answer keys out of the repo if it's public.
   - Add a book checker like Level 3's `check-code.mjs` for Levels 0–2.

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

- **Level 3, in VS Code (1 October):** you asked *"Let's start building Level 3, but i
  want build game by game for level 3 and let me see the design before you start"*, chose
  the art (*"for art we can use this one"*: the Brackeys Platformer Bundle), then
  answered the design's questions: *"1 Approve"*, stomp and roll with this bundle only,
  and *"3 step by step"* (paint every section in the book). Knight Run was built: the
  game, the scene builder, the 12 C# Concept chapters, Check Yourself, the book and its
  PDF, the code checker and the READMEs.
- **Crypt Keys (1 October):** you shared the design resources sheet, asked for the next
  two games' designs (*"do the best to make this curriculum good for teatching and make
  studtent very pro with unity"*), and approved Crypt Keys' design with *"i think all is
  good, go a head"*. Crypt Keys was built: the game and its 18 scripts, the scene builder
  and map, the builder kit's additions, the book (16 chapters, using the shared concepts),
  its PDF and cover, the spec, the READMEs and the website entry. Gate Guard's design
  comes next.
- **Gate Guard (1 to 2 October, from your phone through Remote Control):** you asked
  to *"start from here the next game as he did"*. Its design version 1 was made the
  Crypt Keys way: the sheet's packs downloaded and opened, the spec, the lab checks, and
  the review page. You said *"Keep going here"*, then *"All 6 approved"*. Gate Guard was
  built: the game and its 19 scripts, the scene builder and map, the book (16 chapters,
  using the shared concepts), its PDF and cover, the spec, the READMEs, the credits and
  the website entry. Nothing committed: you were asked whether to commit Crypt Keys first,
  and haven't answered yet.
- **Checking everything (2 October):** you answered *"Well, yes"*, said another session
  had made the third game, asked to *"check everything"*, and added the
  `COURSE_PW_LEVEL_3_CRYPT_KEYS` and `COURSE_PW_LEVEL_3_GATE_GUARD` secrets. With all
  three games in one copy of the project: each builder's scene matches the one your
  Editor built, and 43 play tests pass; every script version in the three books
  compiles; the site builds with both new books published and encrypted. Found and fixed
  in Gate Guard's book: Chapter 3 warns about the 56 import lines from
  `Rig_Medium_General`, and Chapter 15's empty field has Unity's real message and
  behaviour. Committed as three commits, not pushed. Then the other session spotted that
  the new Chapter 15 step described the builder's scene, where the Start panel was on,
  not a student's, where Chapter 12 switches it off: the builder now switches it off too,
  and the chapter describes the student's scene (a fourth commit). You ran Gate Guard's
  **Build Scene** again, and its scene was committed (a fifth). You said *"push"*, and
  the site went live with both books.
- **The Level 3 entry test (2 October):** you said *"do it"*.
  - Its design version 1 (the spec and a review page) was made from Level 2's own test
    and the 15 Level 2 chapters, and you answered *"all approved"*.
  - It was written, every answer was run in Unity, and the model solution was
    play-tested. Two independent reviews followed, and their fixes are in.
  - You said *"yes push it"*: committed and pushed.

---

## 9. Working rules (for Claude)

- **Commit only when Moayad asks.** The author is `Moayad <moayad.rahhal@hotmail.com>`.
  Git LFS must be installed (`git lfs install`), because the PDFs, images, audio and
  models are LFS files.
- **Ask before any download**, and before adding a package or an asset.
- **Delete only what Moayad asked for.** A deleted file in this project can't be undone
  outside Git.
- After editing a shared C# Concept chapter, **re-assemble that level's books and rebuild
  their PDFs** (Level 3: run `check-code.mjs` too). The website reads `workbook.md`, so
  commit the assembled files too.
- **Show Moayad each game's design before building it**, one game at a time.
- After changing `build.mjs` or `style.css`, copy the change to the other levels' builder
  folders, but keep Levels 0–1 at 8.5 pt code. Rebuild the PDFs it affects, and look at
  the pages.
- **Build every PDF on this Mac.** Chrome on another system picks other fallback fonts
  and emoji, and breaks pages differently, so the books stop matching.
- Keep each game's README and build spec true to its code. They are what the next person,
  or the next Claude, reads first.
