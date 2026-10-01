# Level 2 — Space Shooter

One of the three games of Level 2 ("Builder") of the Unity Programmer Curriculum, in 2D. The player's ship flies at the bottom of the screen with the keyboard, or follows a finger, and shoots down five waves of enemies: scouts, spinning meteors, swaying zigzag ships, gunships that shoot back, then all four mixed. Some enemies drop a shield, triple shot or rapid fire. Three lives, a six-digit score, a start screen and an end screen that counts each kind of enemy destroyed, explosions, sound and camera shake, a settings panel that pauses the game, and a Web build that works with a keyboard, a mouse or a finger. Students join by passing the **Level 2 entry test**. The book stands alone and teaches every Level 2 topic, like the Mini Golf and Tank Arena books; the C# Concept chapters it uses live in `../Level2-Shared`.

## What's in this folder

| Path | What it is |
| --- | --- |
| `Docs/Level2-SpaceShooter-Workbook.pdf` | **The student book.** 14 build chapters and the 15 shared C# Concept chapters, interleaved in teaching order, plus exam-style practice, the Level 2 cheat sheet and the Level 3 readiness checklist. |
| `Docs/SPACESHOOTER_BUILD_SPEC.md` | The game spec: Level 2 code limits, scene values, acceptance checks. Hand it to Claude in VS Code for checks or changes. |
| `Scripts/` | The finished student code, 11 scripts: `PlayerShip`, `Laser`, `Enemy`, `EnemyGun`, `PowerUp`, `WaveSpawner`, `ShooterGame`, `ScrollingBackground`, `CameraShake`, `SettingsMenu`, and the plain C# class `Wave`. |
| `Editor/SpaceShooterSceneBuilder.cs` | **Instructor tool.** Menu **Tools → Space Shooter (Level 2) → Build Scene** sets up the sprites and the font, makes the laser, enemy, power-up and explosion prefabs, and builds the ship, the spawner, the camera and the whole UI exactly as the book describes, with every reference wired. |
| `Art/Sprites/` | 33 sprites from Kenney's Space Shooter pack (Remastered): the ships, lasers, enemies, meteors, power-ups, shield, life icons, the `darkPurple` background and the `star1` spark the game uses, and a few spares. |
| `Art/Fonts/` | Kenney's two fonts, `kenvector_future.ttf` (the one the game uses) and `kenvector_future_thin.ttf`. |
| `Art/Kenney-License.txt` | Kenney's licence for the sprites, fonts and sounds (CC0). |
| `Audio/` | The seven sounds students get from their trainer, from the same pack: `sfx_laser1`, `sfx_laser2`, `sfx_lose`, `sfx_shieldDown`, `sfx_shieldUp`, `sfx_twoTone`, `sfx_zap`. |
| `Curriculum.Level2.SpaceShooter.asmdef`, `Editor/Curriculum.Level2.SpaceShooter.Editor.asmdef` | Keep Space Shooter's classes in their own assemblies (see below). |
| `Scenes/`, `Prefabs/`, `Generated/`, `Art/Fonts/kenvector_future SDF.asset` | Created by the scene builder the first time you run it: `Scenes/SpaceShooter.unity`, the ten prefabs, the explosion's material, and the TextMeshPro font asset. |
| `Docs~/workbook/` | The book's source: `book.md` (edit this one), `workbook.md` (assembled from it: the file the PDF builder and the website read) and `cover.png`. The `~` makes Unity ignore the folder. |

The C# Concept chapters, the book assembler, the PDF builder, the helper kit the scene builders use and the Level 2 entry test are shared by the three games: see `../Level2-Shared/README.md`.

## First run

1. Open the project in Unity 6 and wait for scripts to compile (0 errors expected).
2. **Tools → Space Shooter (Level 2) → Build Scene**. The first time, it asks you to
   import **TMP Essential Resources**: click **Import** in the Import Unity Package
   window, wait for the import, then run **Build Scene** again.
3. Press **Play**, then **Play** on the start panel. Arrow keys or W A S D fly the ship
   and holding **Space** fires; or hold the mouse button down: the ship follows the
   pointer, a little above it, and fires. **Settings** is at the bottom-right.

If the open scene has unsaved changes, the builder asks about them first. It also imports the sprites it uses at 100 Pixels Per Unit, centred (`darkPurple` with a Full Rect mesh, so it can tile), makes the font asset `kenvector_future SDF` from Kenney's font, adds the `Player` layer, and puts the scene first in Build Settings, so a build starts with it. Running it again overwrites the scene and the prefabs, so anything changed in them by hand is lost; the font asset is made once and kept.

## Why Space Shooter has its own assemblies

Both finished Level 2 games have a `SettingsMenu` class, for example. Two classes with the same name in the same assembly don't compile; in different assemblies they're fine. So Space Shooter keeps its scripts in their own assembly definition (`Curriculum.Level2.SpaceShooter`, not auto-referenced) and its scene builder in an Editor-only one (`Curriculum.Level2.SpaceShooter.Editor`, which also uses the shared builder kit in `Curriculum.Level2.Shared.Editor`, and URP's 2D runtime for the Global Light 2D). Students never see this: in their own projects, scripts go in `Assets/Scripts` as the book says.

## Input

The project uses the **Input System** package only. The ship reads the keyboard with `Keyboard.current` (arrows or W A S D, and Space), checking it isn't `null` first, because a phone may have no keyboard. It reads the mouse and the touchscreen with `Pointer.current`: the mouse on a computer, a finger on a phone, with the same code. `EventSystem.current.IsPointerOverGameObject()` stops a press on a button from steering the ship or firing, which is why every text and image that's only there to be read has **Raycast Target** off. The older `Input` class would throw errors here; the Mouse and Touch C# Concept shows its equivalents in a table, because exam questions still use it.

To test touch without a phone, open **Window → General → Device Simulator** (or switch the Game view to **Simulator**), pick a phone, turn it sideways with **Rotate**, and use the mouse as a finger (Chapter 7).

## A static count

In the curriculum project, **Enter Play Mode** is set to Reload Scene only (**Edit → Project Settings → Editor**), so static values survive from one Play to the next. Every enemy counts itself in the static `Enemy.AliveCount`, so `WaveSpawner.Awake` puts it back to 0 with `Enemy.ResetCount()`, as Chapter 6 teaches.

## Rebuilding the book and the PDF

Edit `Docs~/workbook/book.md` (or a shared concept chapter), never `workbook.md`. Then assemble the book and build the PDF, from `Level2-Shared`:

```bash
cd Assets/Levels/Level2-Shared/Docs~
node assemble.mjs            # book.md + the shared chapters → workbook.md (every Level 2 book)
cd pdf
npm install                  # first time only
node build.mjs ../../../Level2-SpaceShooter/Docs~/workbook/workbook.md ../../../Level2-SpaceShooter/Docs/Level2-SpaceShooter-Workbook.pdf
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

It prints `MATCH` for all 11 scripts. The comparison is exact: one trailing space, or an extra blank line at the end of a file, shows as `DIFF`. The earlier versions of scripts that the book shows (code blocks without a file name) aren't checked.

## The website

`workbook.md` is also the source of the Space Shooter pages on the course site. They are published, and locked with the `COURSE_PW_LEVEL_2_SPACE_SHOOTER` repository secret (see `web/README.md`): push a re-assembled `workbook.md` and the site follows.
