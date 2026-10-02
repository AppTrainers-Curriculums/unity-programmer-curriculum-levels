# Level 3 — Gate Guard

The third of the three games of Level 3 ("Junior-ready") of the Unity Programmer Curriculum: a **3D tower defence**. The dead are rising in the old ruins, and ten waves of skeletons march along a winding road to the castle gate, on a battlefield of hex tiles seen from a camera that never moves. The player builds towers on thirteen dirt plots beside the road: the **Arrow** tower (an archer), the **Catapult** (a wooden arm that throws a stone in an arc, hitting everything where it lands) and the **Frost** tower (a mage whose bolts slow a skeleton to half speed, legs and all). Each tower upgrades twice, growing a storey and then raising its flags, and sells for 60% of what it cost. Four kinds of skeleton (the Minion, the Rogue who runs, the Warrior with axe and shield, and the Bone Mage, the boss of wave 10) rise out of the ground, walk the road and chop at the gate; ten lives, gold and bounties, wave bonuses and a countdown, world-space health bars over every skeleton, a build menu that opens over the plot that was tapped, double speed, a start screen, a pause menu with a volume slider, win and lose screens (the gate's doors burst open, and the skeletons cheer), **Restart** without reloading the scene, sound and music, soft shadows, and a camera that shows the whole battlefield on any screen. It's played with a pointer, the mouse or a finger. The models and every clip come from **KayKit**, the GUI from **pzUH**, the icons from **game-icons.net**, the font is **Lilita One**, and the sound is **Ninja Adventure**: see `CREDITS.md`.

Like Knight Run and Crypt Keys, it teaches every Level 3 topic and ends at the **Unity Certified User: Programmer** exam, with the same C# Concept chapters from `../Level3-Shared`. It's the level's 3D game, and puts other things in the foreground: **Humanoid Avatars**, with clips from other files playing on any body; an imported clip's settings and **Animation Events added in the Import Settings**; a state's **Speed Multiplier** driven by a parameter, so frost slows the walk clip too; **one controller for four skeletons**, and **one for three tower crews**, an archer, a mage and a wooden catapult arm, through Override Controllers; a tower's looks switched by an **Int** and property clips with **Is Active** keys; a **hex Grid** painted with the **GameObject Brush**; a **World Space Canvas**; `Physics.OverlapSphere`, a ray from the camera, `Camera.WorldToScreenPoint`; and a **Physical Camera** with Gate Fit.

## What's in this folder

| Path | What it is |
| --- | --- |
| `Docs/Level3-GateGuard-Workbook.pdf` | **The student book.** 16 build chapters and the 12 shared C# Concept chapters, interleaved in teaching order, then the User exam, exam-style questions, a timed practice paper, the Level 3 cheat sheet and the Level 4 readiness list. |
| `Docs/GATEGUARD_BUILD_SPEC.md` | The game spec: Level 3 code limits, the battlefield, the numbers, the Animators, the UI, acceptance checks, and what changed while building. Hand it to Claude in VS Code for checks or changes. |
| `Scripts/` | The finished student code, 19 scripts: `GateGame`, `Bank`, `WaveSpawner`, `WaypointPath`, `Enemy`, `EnemyHealthBar`, `Tower`, `TowerCrew`, `Projectile`, `BuildPlot`, `Picker`, `BuildMenu`, `TowerMenu`, `RangeRing`, `Gate`, `PauseMenu`, and the plain C# classes `TowerLevel`, `Wave` and `SpawnGroup`. |
| `Editor/GateGuardSceneBuilder.cs` | **Instructor tool.** Menu **Tools → Gate Guard (Level 3) → Build Scene** sets up every model's import settings, the Humanoid Avatars and the clips with their events, makes the Animator Controllers, the Override Controllers and the property clips, the prefabs, the battlefield from the map, the castle, the 3D renderer, the light, the camera and the whole UI, exactly as the book describes, with every reference wired. |
| `Editor/GateGuardMap.txt` | The battlefield's map, one mark a hex: the builder lays the tiles, the road, the plots and the scenery from it (below). |
| `Art/` | `Models/` (the hex pack's tiles, buildings, nature and props, and `hexagons_medieval.png`, the one texture they share), `Characters/` (four skeletons, the Ranger and the Mage), `Weapons/`, `Animations/` (six clip files for KayKit's medium rig), `UI/`, `Icons/`, `Fonts/` (Lilita One, its licence, and the `LilitaOne-Regular SDF` font asset the builder makes) and `Licences/`. |
| `Audio/` | 13 sounds and two pieces of music (`Road`, `Tension`), and Ninja Adventure's licence. |
| `CREDITS.md` | Every pack, its creator, its link and its licence, and each icon's author. |
| `Animation/`, `Prefabs/`, `Settings/`, `Scenes/` | Made by the scene builder: 4 Animator Controllers (`Skeleton`, `Crew`, `Tower`, `Gate`), 5 Override Controllers (`Rogue Override`, `Warrior Override`, `Bone Mage Override`, `Mage Override`, `Catapult Override`), 9 property clips, and the particle and frost-bolt materials; 12 prefabs; `Settings/GateGuardRenderer.asset`, a Universal (3D) renderer; and `Scenes/GateGuard.unity`. |
| `Curriculum.Level3.GateGuard.asmdef`, `Editor/Curriculum.Level3.GateGuard.Editor.asmdef` | Keep Gate Guard's classes in their own assemblies (see below). |
| `Docs~/workbook/` | The book's source: `book.md` (edit this one), `workbook.md` (assembled from it: the file the PDF builder, the code checker and the website read) and `cover.png`. The `~` makes Unity ignore the folder. |

The C# Concept chapters, the book assembler, the code checker, the PDF builder and the helper kit the scene builder uses are shared by the Level 3 games: see `../Level3-Shared/README.md`.

## First run

1. Open the project in Unity 6 and wait for scripts to compile (0 errors expected). The
   first import also logs 56 red lines, `Assertion failed on expression:
   'IsFinite(curve.GetKey(0).value)'`, for `Art/Animations/Rig_Medium_General.fbx`: they
   are about two of its clips the game doesn't use (the spec's section 13 says why), so
   clear them.
2. **Tools → Gate Guard (Level 3) → Build Scene**. If the project has no **TMP Essential
   Resources** yet, it asks you to import them: click **Import** in the Import Unity
   Package window, wait for the import, then run **Build Scene** again.
3. Press **Play**, then **Play** on the start panel. Click a dirt plot to build, click a
   tower to upgrade or sell it, **Start Wave** (or **Space**) sends a wave, **x2** (or
   **F**) plays at double speed, and **Esc** or **P** pauses.

If the open scene has unsaved changes, the builder asks about them first. It also adds the `Enemy` and `Plot` layers (any that are missing); imports the models as the book does (no rig, cameras, lights or clips for the tiles, buildings and weapons; a **Humanoid** Avatar for the six characters and the six clip files); sets up every clip the game plays (**Loop Time**, the root's rotation and position **baked into the pose**, and the Animation Events); imports the GUI pictures as smooth sprites (Bilinear, no mipmaps); adds a Universal (3D) renderer, `Settings/GateGuardRenderer.asset`, to the project's URP asset, whose renderer list starts with the 2D renderer the other Level 3 games use, and makes the camera use it, as Mini Golf's builder does; and puts the scene in Build Settings, so a build starts with it. It logs `Gate Guard scene built: …` when it's done. Running it again rebuilds the scene, the clips, the controllers and the prefabs in place (they keep their GUIDs), so anything changed in them by hand is lost; the font asset is made once and kept.

## Why Gate Guard has its own assemblies

The curriculum's games share class names: Knight Run and Crypt Keys have a `PauseMenu` too, for example. Two classes with the same name in the same assembly don't compile; in different assemblies they're fine. So Gate Guard keeps its scripts in their own assembly definition (`Curriculum.Level3.GateGuard`, not auto-referenced, using the Input System, TextMeshPro and UI) and its scene builder in an Editor-only one (`Curriculum.Level3.GateGuard.Editor`, which also uses the shared builder kit in `Curriculum.Level3.Shared.Editor` and URP's runtime). Students never see this: in their own projects, scripts go in `Assets/Scripts` as the book says.

## Input

The project uses the **Input System** package only. The game is played with `Pointer.current`, the mouse or a finger: `Picker` casts a ray from the camera through the pointer against the `Plot` layer, and a press that lands on the UI belongs to the UI (`EventSystem.current.IsPointerOverGameObject()`). The keyboard (`Keyboard.current`, checked for `null`) only adds shortcuts: **Space** for the next wave, **F** for double speed, **Esc** to close a menu or pause, and **P** to pause. So the same Web build plays on a computer and a phone, and the Physical Camera's **Gate Fit: Overscan** shows the whole battlefield on a screen of any shape.

## The state machines to stress

The ideas to stress in class, in Chapters 4, 5, 8, 10 and 13:

- **The skeletons** (Chapters 4 to 6): one controller, `Skeleton`, for four bodies. The code sets `WalkSpeed` (a Float, the Walk state's Speed Multiplier) and the `Attack`, `Die` and `Cheer` triggers through `static readonly` hashes; the Rogue, the Warrior and the Bone Mage swap clips through Override Controllers. The mind is code: `Enemy`'s `enum State` (Rising, Walking, Slowed, Dying, AtGate) with one `EnterState`, kept in step with the body by three events added in the Import Settings, `OnRisen`, `OnGateHit` and `OnDeathFinished`.
- **The towers** (Chapter 8): `Tower`'s state machine (Idle, Aim, Fire, Reload) drives the crew's Animator with `Aiming` (a Bool) and `Fire` (a Trigger), and the shot leaves on the crew's release frame. The event reaches only scripts on the Animator's own GameObject, so `TowerCrew` passes it on. One controller, `Crew`, drives an archer, a mage and a wooden arm (Chapter 9): an Animator doesn't care what its clips move.
- **A tower's looks** (Chapter 10): a second Animator on the tower, `Tower`, with an Int, `Level`, and an Any State transition per level; the clips switch the second storey and the flags with **Is Active** keys, lift the crew, and pop the tower.

And the game itself is a state machine (Chapter 13): `GateGame`'s `GameState` (Start, Playing, Paused, Won, Lost) shows one panel per state and sets `Time.timeScale` in its enter steps, at the chosen speed, 1 or 2. Its `IsPlaying` is a stand-in that answers `true` from Chapter 5 to 12, so every script that asks it is ready for the real states. `Restart` puts the spawner, the shots, every plot, the bank and the gate back with their own reset methods; scene loading waits for Level 4. So does object pooling: every arrow, stone and skeleton is made with `Instantiate` and removed with `Destroy`.

## The battlefield's map

`Editor/GateGuardMap.txt` holds the battlefield, 13 hexes across and 9 rows, the first line the far (north) edge; the odd rows are drawn indented, as they sit, half a hex to the right. `S` is the start (the road's dead end, where skeletons rise), `=` road, `G` the gate's tile, `b` a build plot, `.` grass (the builder puts a rock or a lone tree on about a third of them, from a fixed random seed, so every build is the same), `T` trees, `M` a mountain, `H` hills, `h` a small hill, `X` the ruins and `C` the castle's ground. The builder walks the road from `S` to `G`, tile by tile, and works out each tile's piece and turn: 23 straights (`hex_road_A`), 7 bends (`hex_road_B`) and the dead end (`hex_road_M`), 9 of them turned. It puts a waypoint in the middle of each road tile but the last, and one 0.8 units in front of the gate. The castle, its walls and the gate are placed in code, on a row behind the map. The book prints the map, every road tile's turn, every plot and every waypoint, in Chapters 1, 2 and 7: after changing the map, run **Build Scene**, and change the book to match.

## Rebuilding the book and the PDF

Edit `Docs~/workbook/book.md` (or a shared concept chapter), never `workbook.md`. Then assemble the book, check its code and build the PDF, from `Level3-Shared`:

```bash
cd Assets/Levels/Level3-Shared/Docs~
node assemble.mjs            # book.md + the shared chapters → workbook.md (every Level 3 book)
node check-code.mjs          # compile every script version in the book; compare the cards with Scripts/
cd pdf
npm install                  # first time only
node build.mjs ../../../Level3-GateGuard/Docs~/workbook/workbook.md ../../../Level3-GateGuard/Docs/Level3-GateGuard-Workbook.pdf
```

Requires Google Chrome (path in `build.mjs`, or set `CHROME_PATH`). `node assemble.mjs --check` says whether `workbook.md` is up to date without changing anything. More in `../Level3-Shared/README.md`.

## Keep the code honest

The book shows each script many times, as it grows from chapter to chapter (`Enemy` seven times, `GateGame` six), and its final version as a code card (` ```csharp:Enemy.cs `) that must match `Scripts/` byte for byte. Most scripts reach their final version in the chapter that needs them; Chapter 14 gives the last versions of the six that gain sounds. `check-code.mjs` checks both: every version must compile, at the step where the book shows it, together with the other scripts as they stand then, and every card must equal its script. After editing either side, assemble the book and run it: it prints `ok` with `(44 script versions, 19 cards, 21 C# examples)`. One trailing space, or an extra blank line at the end of a file, shows as a card that differs.

## The website

`workbook.md` is also the source of the Gate Guard pages on the course site, entry `level-3-gate-guard` in `web/levels.config.mjs`. They are published, and locked with the `COURSE_PW_LEVEL_3_GATE_GUARD` repository secret (see `web/README.md`): push a re-assembled `workbook.md` and the site follows.
