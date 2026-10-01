# Level 3 — Knight Run

The first of the three games of Level 3 ("Junior-ready") of the Unity Programmer Curriculum: a 2D platformer. A small knight runs, jumps and rolls through one long level in three sections, each in its own season: the Meadow, the Autumn Woods and the Castle Walls, painted on Tilemaps. Green and purple slimes patrol, chase and leap at him; he stomps them, or rolls into them. He has 5 health, a health bar beside his face, knockback and blinking when he's hurt, checkpoints that light up as he passes them, apples that heal, 30 coins to find, and the castle door at the end. A start screen, a pause menu with a volume slider, a win screen with the coins and the time, a lose screen, **Restart** without reloading the scene, sound and music, and touch buttons that show on a phone. All the art, sound and the font come from the **Brackeys Platformer Bundle** (CC0).

Level 3 is about animation and state machines: the knight's Animator, driven from code through parameters and hashes; Animation Events that time the game; the slime as an `enum` and `switch` state machine whose Animator follows it; and the game itself as a state machine. It ends at the **Unity Certified User: Programmer** exam. The book stands alone and teaches every Level 3 topic; the C# Concept chapters it uses live in `../Level3-Shared`.

## What's in this folder

| Path | What it is |
| --- | --- |
| `Docs/Level3-KnightRun-Workbook.pdf` | **The student book.** 15 build chapters and the 12 shared C# Concept chapters, interleaved in teaching order, then the User exam, exam-style questions, a timed practice paper, the Level 3 cheat sheet and the Level 4 readiness list. |
| `Docs/KNIGHTRUN_BUILD_SPEC.md` | The game spec: Level 3 code limits, scene values, the Animators, acceptance checks. Hand it to Claude in VS Code for checks or changes. |
| `Scripts/` | The finished student code, 14 scripts: `KnightController`, `KnightHealth`, `KnightCombat`, `Slime`, `Coin`, `Apple`, `Checkpoint`, `CastleDoor`, `KillZone`, `CameraFollow`, `HealthBar`, `PauseMenu`, `PlatformerGame`, and the plain C# class `Section`. |
| `Editor/KnightRunSceneBuilder.cs` | **Instructor tool.** Menu **Tools → Knight Run (Level 3) → Build Scene** imports the art, makes the tiles, clips, Animators and prefabs, paints the level, and builds the whole scene and UI exactly as the book describes, with every reference wired. |
| `Editor/KnightRunLevel.txt` | The level's map, one character a cell: the builder paints and places everything from it (below). |
| `Art/Sprites/` | The bundle's seven sheets: `knight`, `slime_green`, `slime_purple`, `coin`, `fruit`, `platforms` and `world_tileset`. |
| `Art/Fonts/` | `PixelOperator8` and its bold version, and the `PixelOperator8 SDF` font asset the builder makes, with a dark outline. |
| `Art/Brackeys-License.txt` | The bundle's licence (CC0). |
| `Audio/` | The bundle's six sounds (`jump`, `tap`, `hurt`, `power_up`, `coin`, `explosion`) and its music, `time_for_adventure`. |
| `Animation/`, `Tiles/`, `Prefabs/`, `Materials/`, `Scenes/` | Made by the scene builder: 21 clips, 4 Animator Controllers and the purple slime's Override Controller; 127 tiles and the Knight Run Palette; 8 prefabs (the two slimes, coin, apple, checkpoint and three platforms); the No Friction physics material; and `Scenes/KnightRun.unity`. |
| `Curriculum.Level3.KnightRun.asmdef`, `Editor/Curriculum.Level3.KnightRun.Editor.asmdef` | Keep Knight Run's classes in their own assemblies (see below). |
| `Docs~/workbook/` | The book's source: `book.md` (edit this one), `workbook.md` (assembled from it: the file the PDF builder, the code checker and the website read) and `cover.png`. The `~` makes Unity ignore the folder. |

The C# Concept chapters, the book assembler, the code checker, the PDF builder and the helper kit the scene builder uses are shared by the Level 3 games: see `../Level3-Shared/README.md`.

## First run

1. Open the project in Unity 6 and wait for scripts to compile (0 errors expected).
2. **Tools → Knight Run (Level 3) → Build Scene**. If the project has no **TMP Essential
   Resources** yet, it asks you to import them: click **Import** in the Import Unity
   Package window, wait for the import, then run **Build Scene** again.
3. Press **Play**, then **Play** on the start panel. **A** and **D** or the arrows run,
   **Space**, **W** or **↑** jumps, **Shift** or **J** rolls, and **Esc** or **P** pauses.

If the open scene has unsaved changes, the builder asks about them first. It also adds the `Ground`, `Knight` and `Enemy` layers, unticks **Enemy** against **Enemy** in the Physics 2D collision matrix (slimes pass through each other), imports the sheets as pixel art (16 Pixels Per Unit, Point filter, no compression, sliced as the book slices them), and puts the scene first in Build Settings, so a build starts with it. It logs `Knight Run scene built: …` when it's done. Running it again rebuilds the scene, the clips, the Animators and the prefabs in place (they keep their GUIDs), so anything changed in them by hand is lost.

## Why Knight Run has its own assemblies

The curriculum's games share class names: Level 2's Mini Golf and Tank Arena have a `CameraFollow` too, for example. Two classes with the same name in the same assembly don't compile; in different assemblies they're fine. So Knight Run keeps its scripts in their own assembly definition (`Curriculum.Level3.KnightRun`, not auto-referenced, using the Input System, TextMeshPro and UI) and its scene builder in an Editor-only one (`Curriculum.Level3.KnightRun.Editor`, which also uses the shared builder kit in `Curriculum.Level3.Shared.Editor`, and URP's 2D runtime). Students never see this: in their own projects, scripts go in `Assets/Scripts` as the book says.

## Input

The project uses the **Input System** package only. The knight reads the keyboard with `Keyboard.current`, checking it isn't `null` first, because a phone may have no keyboard. On a touchscreen, four round buttons show in the bottom corners (`Touchscreen.current != null`): left and right are held, roll and jump are tapped. They're UI Images with **Event Trigger** components (PointerDown, PointerUp, PointerExit) that call `SetLeftHeld(bool)`, `SetRightHeld(bool)`, `PressRoll()` and `PressJump()` on the knight, so two thumbs work at once. To test them without a phone, switch the Game view to **Simulator**, pick a phone, turn it sideways with **Rotate**, and use the mouse as a finger (Chapter 12).

## Three state machines

The idea to stress in class, in Chapters 4, 6 and 11:

- **The knight's Animator** (Chapter 4): the states live in the Animator Controller, and code only sets parameters (`Speed`, `VerticalSpeed`, `Grounded`, and the `Roll`, `Hurt` and `Dead` triggers) through `static readonly` hashes.
- **The slime** (Chapter 6): the states live in code, an `enum State` with one `EnterState` that every change goes through, and the Animator follows the code through one Int parameter. The purple slime is the same script with other numbers, and an Override Controller for its clips.
- **The game** (Chapter 11): `PlatformerGame`'s `GameState` (Start, Playing, Paused, Won, Lost) shows one panel per state and sets `Time.timeScale` in its enter steps. `Restart` puts every slime, coin, apple and checkpoint back with their own reset methods; scene loading waits for Level 4.

Animation Events tie the two kinds together: the run clip's footsteps, the end of the roll (`OnRollFinished`), the slime's leap (`OnLeap`) and the end of each Dead clip.

## The level's map

`Editor/KnightRunLevel.txt` holds the whole level: three sections of 63 columns, each a heading (`# The Meadow`, `# The Autumn Woods`, `# The Castle Walls`) and 14 rows, from y = 10 down to y = −3. `#` is ground (its top tile is the one with nothing above it), `~` water, goo or the moat, `==` a two-tile platform, `w` and `o` the keep's wall and doorway, `D` the castle door, `K` the knight, `C` a coin, `A` an apple, `s` and `p` green and purple slimes, `P` a checkpoint sign, and `T`, `b`, `f`, `m`, `n` and `k` decorations. The book prints each section's map, and every position, in Chapters 1, 8 and 13: after changing the map, run **Build Scene**, and change the book to match.

## Rebuilding the book and the PDF

Edit `Docs~/workbook/book.md` (or a shared concept chapter), never `workbook.md`. Then assemble the book, check its code and build the PDF, from `Level3-Shared`:

```bash
cd Assets/Levels/Level3-Shared/Docs~
node assemble.mjs            # book.md + the shared chapters → workbook.md (every Level 3 book)
node check-code.mjs          # compile every script version in the book; compare the cards with Scripts/
cd pdf
npm install                  # first time only
node build.mjs ../../../Level3-KnightRun/Docs~/workbook/workbook.md ../../../Level3-KnightRun/Docs/Level3-KnightRun-Workbook.pdf
```

Requires Google Chrome (path in `build.mjs`, or set `CHROME_PATH`). `node assemble.mjs --check` says whether `workbook.md` is up to date without changing anything. More in `../Level3-Shared/README.md`.

## Keep the code honest

The book shows each script many times, as it grows from chapter to chapter, and its final version as a code card (` ```csharp:Slime.cs `) that must match `Scripts/` byte for byte. `check-code.mjs` checks both: every version must compile, at the step where the book shows it, together with the other scripts as they stand then, and every card must equal its script. After editing either side, assemble the book and run it: it prints `ok` with `(33 script versions, 14 cards, 21 C# examples)`. One trailing space, or an extra blank line at the end of a file, shows as a card that differs.

## The website

`workbook.md` is also the source of the Knight Run pages on the course site. They are published, and locked with the `COURSE_PW_LEVEL_3_KNIGHT_RUN` repository secret (see `web/README.md`): push a re-assembled `workbook.md` and the site follows.
