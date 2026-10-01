# Level 2 — Mini Golf

One of the three games of Level 2 ("Builder") of the Unity Programmer Curriculum, and the only one in 3D. Three holes built from Kenney's Minigolf Kit tiles (The Windmill, par 2; Around the Corner, par 3; Mind the Edge, par 3), a ball you putt by pressing anywhere, dragging back and letting go, an aim line that stops at the first wall, a camera that follows the ball, golf's names for every score, sound and confetti, a settings panel that pauses the game, a scorecard, and a Web build that works with a mouse or a finger. Students join by passing the **Level 2 entry test**. The book stands alone and teaches every Level 2 topic, like the Space Shooter and Tank Arena books; the C# Concept chapters it uses live in `../Level2-Shared`.

## What's in this folder

| Path | What it is |
| --- | --- |
| `Docs/Level2-MiniGolf-Workbook.pdf` | **The student book.** 15 build chapters and the 15 shared C# Concept chapters, interleaved in teaching order, plus exam-style practice, the Level 2 cheat sheet and the Level 3 readiness checklist. |
| `Docs/MINIGOLF_BUILD_SPEC.md` | The game spec: Level 2 code limits, scene values, acceptance checks. Hand it to Claude in VS Code for checks or changes. |
| `Scripts/` | The finished student code, 12 scripts: `GolfBall`, `ShotAimer`, `CameraFollow`, `Spinner`, `MovingBlock`, `Cup`, `Hole`, `GolfGame`, `BallSounds`, `SettingsMenu`, and two plain C# classes, `HoleScore` and the static `GolfTerms`. |
| `Editor/MiniGolfSceneBuilder.cs` | **Instructor tool.** Menu **Tools → Mini Golf (Level 2) → Build Scene** builds the three holes and their colliders, the ball, the aim line, the camera, the confetti and the whole UI exactly as the book describes, with every reference wired. |
| `Art/Models/` | 36 Kenney Minigolf Kit models (`.fbx`) and their `Textures/colormap.png`: the tiles, flags and balls the course uses, and spares for Chapter 9's "Hole 4" challenge. |
| `Art/Kenney-License.txt` | Kenney's licence for the models (CC0). |
| `Audio/` | The five sounds students get from their trainer: `Putt`, `Wall`, `Cup`, `Fall`, `Cheer`. |
| `Curriculum.Level2.MiniGolf.asmdef`, `Editor/Curriculum.Level2.MiniGolf.Editor.asmdef` | Keep Mini Golf's classes in their own assemblies (see below). |
| `Scenes/`, `Generated/`, `Settings/` | Created by the scene builder the first time you run it: `Scenes/MiniGolf.unity`; the ball's Physics Material and the aim line, confetti and moving block materials; the 3D renderer (see below). |
| `Docs~/workbook/` | The book's source: `book.md` (edit this one), `workbook.md` (assembled from it: the file the PDF builder and the website read) and `cover.png`. The `~` makes Unity ignore the folder. |

The C# Concept chapters, the book assembler, the PDF builder, the helper kit the scene builders use and the Level 2 entry test are shared by the three games: see `../Level2-Shared/README.md`.

## First run

1. Open the project in Unity 6 and wait for scripts to compile (0 errors expected).
2. **Tools → Mini Golf (Level 2) → Build Scene**. The first time, it asks you to import
   **TMP Essential Resources**: click **Import** in the Import Unity Package window,
   wait for the import, then run **Build Scene** again.
3. Press **Play**. Press anywhere in the Game view, drag back and let go to putt: the
   further you drag, the harder the putt. **Settings** is at the top-right.

If the open scene has unsaved changes, the builder asks about them first. It also adds the `Course` layer, turns off **Generate Colliders** on the Kenney models, sets the Bounce Threshold and adds a 3D renderer (all below), and puts the scene first in Build Settings, so a build starts with it. Running it again overwrites the scene and the materials it makes, so anything changed in the scene by hand is lost.

## The 3D renderer

This curriculum project was created from the **Universal 2D** template, so its URP asset has only a 2D renderer. The builder adds a Universal (3D) renderer, `Settings/MiniGolfRenderer.asset`, to the project's URP asset (once), and gives the Mini Golf camera that renderer, with post-processing off. Every other scene keeps the 2D renderer. Students start Mini Golf from the **Universal 3D** template and never see this.

## Colliders: the tiles are pictures only

If every tile had its own Mesh Collider, the ball would catch on the joints between tiles and hop. So the builder turns off **Generate Colliders** (and the import of animation, cameras and lights) on every model in `Art/Models`, and each hole has a child called `Colliders` holding invisible Box Colliders: **one floor for the whole hole**, with no seams, and one box per wall (plus the windmill's two feet on hole 1 and the pillar on hole 2). Chapter 1 teaches students to do exactly this.

The ball has a Sphere Collider (radius 0.035) with a Physics Material that has no friction and a bounciness of 0.6. Unity ignores bounces slower than the **Bounce Threshold** (2 m/s by default), so the builder sets it to `0.5` for the whole project (**Edit → Project Settings → Physics → Settings**, **GameObject** tab), as Chapter 3 does: gentle putts bounce off the walls, and a resting ball still rests.

## Why Mini Golf has its own assemblies

Both finished Level 2 games have a `SettingsMenu` class, for example. Two classes with the same name in the same assembly don't compile; in different assemblies they're fine. So Mini Golf keeps its scripts in their own assembly definition (`Curriculum.Level2.MiniGolf`, not auto-referenced) and its scene builder in an Editor-only one (`Curriculum.Level2.MiniGolf.Editor`, which also uses the shared builder kit in `Curriculum.Level2.Shared.Editor`). Students never see this: in their own projects, scripts go in `Assets/Scripts` as the book says.

## Input

The project uses the **Input System** package only, so the game reads the mouse and the touchscreen through `Pointer.current`: the mouse on a computer, a finger on a phone, with the same code. (The Space-bar test push of Chapters 3 to 5, removed in Chapter 6, reads `Keyboard.current`.) `EventSystem.current.IsPointerOverGameObject()` stops a press on a button from starting a putt, which is why every text and image that's only there to be read has **Raycast Target** off. The older `Input` class would throw errors here; the Mouse and Touch C# Concept shows its equivalents in a table, because exam questions still use it.

To test touch without a phone, open **Window → General → Device Simulator** (or switch the Game view to **Simulator**), pick a phone, and use the mouse as a finger.

## Rebuilding the book and the PDF

Edit `Docs~/workbook/book.md` (or a shared concept chapter), never `workbook.md`. Then assemble the book and build the PDF, from `Level2-Shared`:

```bash
cd Assets/Levels/Level2-Shared/Docs~
node assemble.mjs            # book.md + the shared chapters → workbook.md (every Level 2 book)
cd pdf
npm install                  # first time only
node build.mjs ../../../Level2-MiniGolf/Docs~/workbook/workbook.md ../../../Level2-MiniGolf/Docs/Level2-MiniGolf-Workbook.pdf
```

Requires Google Chrome (path in `build.mjs`, or set `CHROME_PATH`). `node assemble.mjs --check` says whether `workbook.md` is up to date without changing anything. More in `../Level2-Shared/README.md`.

## Keep the code cards honest

The book's `csharp:FileName.cs` code cards must match `Scripts/` byte for byte. After editing either side (the card in `book.md`, or the script), assemble the book, then run from `Docs~/workbook`:

```bash
python3 - <<'PY'
import re
md = open('workbook.md', 'rb').read()
for f, code in re.findall(rb'```csharp:([^\n]+)\n(.*?)```', md, re.S):
    name = f.strip().decode()
    real = open('../../Scripts/' + name, 'rb').read()
    print(('MATCH ' if code == real else 'DIFF  ') + name)
PY
```

It prints `MATCH` for all 12 scripts. The comparison is exact: one trailing space, or an extra blank line at the end of a file, shows as `DIFF`. The earlier versions of scripts that the book shows (code blocks without a file name) aren't checked.

## The website

`workbook.md` is also the source of the Mini Golf pages on the course site. They are published, and locked with the `COURSE_PW_LEVEL_2_MINI_GOLF` repository secret (see `web/README.md`): push a re-assembled `workbook.md` and the site follows.
