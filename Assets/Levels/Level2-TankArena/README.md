# Level 2 — Tank Arena

One of the three games of Level 2 ("Builder") of the Unity Programmer Curriculum, in 2D, seen from above. The player's blue tank drives like a real tank (forwards, backwards, and turning on the spot) around a sandy arena with sandbag walls, trees and barrels, aims its barrel at the mouse, and fights four rounds of enemy tanks: red light tanks and black heavy tanks that drive around by themselves and fire when they can see the player, with no wall in the way. Ten hit points and a health bar, repair kits that destroyed enemies sometimes leave behind, a start screen and an end screen with the match's numbers, explosions, sound and camera shake, a camera that follows the tank, a settings panel that pauses the game, and a Web build that works with a keyboard, a mouse or a finger (tap to fire, press and hold to drive). Students join by passing the **Level 2 entry test**. The book stands alone and teaches every Level 2 topic, like the Mini Golf and Space Shooter books; the C# Concept chapters it uses live in `../Level2-Shared`.

## What's in this folder

| Path | What it is |
| --- | --- |
| `Docs/Level2-TankArena-Workbook.pdf` | **The student book.** 15 build chapters and the 15 shared C# Concept chapters, interleaved in teaching order, plus exam-style practice, the Level 2 cheat sheet and the Level 3 readiness checklist. |
| `Docs/TANKARENA_BUILD_SPEC.md` | The game spec: Level 2 code limits, scene values, acceptance checks. Hand it to Claude in VS Code for checks or changes. |
| `Scripts/` | The finished student code, 12 scripts: `PlayerTank`, `EnemyTank`, `Tracks`, `Turret`, `Health`, `Shell`, `RepairKit`, `CameraFollow`, `ArenaGame`, `SettingsMenu`, the static class `ArenaBounds`, and the plain C# class `MatchStats`. |
| `Editor/TankArenaSceneBuilder.cs` | **Instructor tool.** Menu **Tools → Tank Arena (Level 2) → Build Scene** sets up the sprites, makes the shell, enemy tank, repair kit, explosion and hit prefabs, and builds the arena, the player's tank, the camera and the whole UI exactly as the book describes, with every reference wired. |
| `Art/Sprites/` | 35 sprites from Kenney's Top-down Tanks pack: the tanks and barrels in five colours, the shells, the sand, sandbags, trees and barrels of the arena, the smoke puffs, and a few spares (`dirt`, `grass`, `oil`, `sandbagBeige`, `treeSmall`, `tracksSmall`…). |
| `Art/Kenney-License.txt` | Kenney's licence for the sprites (CC0). |
| `Audio/` | The six sounds students get from their trainer: `Shot`, `Hit`, `Repair`, `Explosion`, `Victory`, `Defeat`. |
| `Curriculum.Level2.TankArena.asmdef`, `Editor/Curriculum.Level2.TankArena.Editor.asmdef` | Keep Tank Arena's classes in their own assemblies (see below). |
| `Scenes/`, `Prefabs/`, `Generated/` | Created by the scene builder the first time you run it: `Scenes/TankArena.unity`, the seven prefabs, and the two smoke materials. |
| `Docs~/workbook/` | The book's source: `book.md` (edit this one), `workbook.md` (assembled from it: the file the PDF builder and the website read) and `cover.png`. The `~` makes Unity ignore the folder. |

The C# Concept chapters, the book assembler, the PDF builder, the helper kit the scene builders use and the Level 2 entry test are shared by the three games: see `../Level2-Shared/README.md`.

## First run

1. Open the project in Unity 6 and wait for scripts to compile (0 errors expected).
2. **Tools → Tank Arena (Level 2) → Build Scene**. If the project has no **TMP Essential
   Resources** yet, it asks you to import them: click **Import** in the Import Unity
   Package window, wait for the import, then run **Build Scene** again.
3. Press **Play**, then **Play** on the start panel. **W** and **S** drive, **A** and **D**
   turn, the barrel follows the mouse, and **Space** or a quick click fires. Press and hold
   the mouse button and the tank drives towards the pointer. **Settings** is at the
   bottom-right.

If the open scene has unsaved changes, the builder asks about them first. It also imports the sprites it uses at 100 Pixels Per Unit (the barrels with their pivot at the bottom, so they turn around the tank; `sand` and `sandbagBrown` with a Full Rect mesh, so they can tile), adds the `Walls` and `Player` layers, and puts the scene first in Build Settings, so a build starts with it. Running it again overwrites the scene and the prefabs, so anything changed in them by hand is lost.

## Why Tank Arena has its own assemblies

Every finished Level 2 game has a `SettingsMenu` class, and Mini Golf has a `CameraFollow` too, for example. Two classes with the same name in the same assembly don't compile; in different assemblies they're fine. So Tank Arena keeps its scripts in their own assembly definition (`Curriculum.Level2.TankArena`, not auto-referenced) and its scene builder in an Editor-only one (`Curriculum.Level2.TankArena.Editor`, which also uses the shared builder kit in `Curriculum.Level2.Shared.Editor`, and URP's 2D runtime for the Global Light 2D). Students never see this: in their own projects, scripts go in `Assets/Scripts` as the book says.

## Input

The project uses the **Input System** package only. The tank reads the keyboard with `Keyboard.current` (W A S D or the arrows, and Space), checking it isn't `null` first, because a phone may have no keyboard. It reads the mouse and the touchscreen with `Pointer.current`: the mouse on a computer, a finger on a phone, with the same code. A press shorter than a quarter of a second fires; a longer one drives the tank towards the pointer, with the same `Tracks.DriveTowards` the enemy tanks drive with. `EventSystem.current.IsPointerOverGameObject()` stops a press on a button from firing or driving, which is why every text and image that's only there to be read has **Raycast Target** off. It's checked on every frame of a press, not only the first: the UI only knows a finger is on a button a frame after it lands. The older `Input` class would throw errors here; the Mouse and Touch C# Concept shows its equivalents in a table, because exam questions still use it.

To test touch without a phone, open **Window → General → Device Simulator** (or switch the Game view to **Simulator**), pick a phone, turn it sideways with **Rotate**, and use the mouse as a finger (Chapter 9).

## One tank, many brains

Every tank is built from the same three components: `Tracks` (drives and turns, through its Rigidbody 2D), `Turret` (turns the barrel and fires shells) and `Health` (hit points). Only the brain differs: `PlayerTank` reads the controls, and `EnemyTank` picks random places to drive to and fires when a raycast shows it can see the player. The heavy tank is the light tank's prefab with different numbers, and no new code. Chapters 4 and 5 build this, and it's the idea to stress in class.

## Rebuilding the book and the PDF

Edit `Docs~/workbook/book.md` (or a shared concept chapter), never `workbook.md`. Then assemble the book and build the PDF, from `Level2-Shared`:

```bash
cd Assets/Levels/Level2-Shared/Docs~
node assemble.mjs            # book.md + the shared chapters → workbook.md (every Level 2 book)
cd pdf
npm install                  # first time only
node build.mjs ../../../Level2-TankArena/Docs~/workbook/workbook.md ../../../Level2-TankArena/Docs/Level2-TankArena-Workbook.pdf
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

`workbook.md` is also the source of the Tank Arena pages on the course site. The book is listed in `web/levels.config.mjs` with `published: false`. To publish it, add its password secret first, then set `published: true` (see `web/README.md`).
