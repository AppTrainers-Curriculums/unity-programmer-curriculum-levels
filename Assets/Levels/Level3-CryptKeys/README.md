# Level 3 — Crypt Keys

The second of the three games of Level 3 ("Junior-ready") of the Unity Programmer Curriculum: a 2D top-down dungeon. A warrior goes down into a crypt of six rooms, stacked one above the other, each painted on Tilemaps with a stone floor that never repeats (a Random Rule Tile): the Crypt Gate, the Hall of Bones, the Ossuary, the Archers' Gallery, the Chapel and the King's Tomb. Keys open the doors in the rooms' top walls, chests give the keys (and potions), skeletons patrol, chase and swing, skeleton archers keep their distance and shoot, and the Skeleton King fights in two phases: a walk and a double swing, then at half health a summon of two skeletons and a whirlwind that turns the sword aside. Three hearts counted in half hearts, a potion inventory, keys, gold, a boss bar, a room camera that slides from room to room, torchlight in the dark (2D lights, with a flicker animated in the Animation window), a start screen, a pause menu with a volume slider, win and lose screens, **Restart** without reloading the scene, sound and music, and controls for the keyboard, the mouse or a finger. The art comes from Foozle's **Lucifer** packs, Legend's keys and 0x72's chests and hearts, the sound from **Ninja Adventure**: all CC0, see `CREDITS.md`.

Like Knight Run, it teaches every Level 3 topic and ends at the **Unity Certified User: Programmer** exam, with the same C# Concept chapters from `../Level3-Shared`. It puts other things in the foreground: an Animator with **four sub-state machines**, one per direction; **one controller for four characters** through Override Controllers, and a **copied, extended** controller for the boss; top-down sorting by height with pivots and colliders at the feet; the Pixel Perfect Camera; Animation Events that time the fighting (the sword's hit frame, the bow's release frame, the chest's loot frame, the door's open frame, the summon).

## What's in this folder

| Path | What it is |
| --- | --- |
| `Docs/Level3-CryptKeys-Workbook.pdf` | **The student book.** 16 build chapters and the 12 shared C# Concept chapters, interleaved in teaching order, then the User exam, exam-style questions, a timed practice paper, the Level 3 cheat sheet and the Level 4 readiness list. |
| `Docs/CRYPTKEYS_BUILD_SPEC.md` | The game spec: Level 3 code limits, the rooms, the numbers, the Animators, the UI, acceptance checks. Hand it to Claude in VS Code for checks or changes. |
| `Scripts/` | The finished student code, 18 scripts: `Hero`, `HeroCombat`, `HeroHealth`, `Inventory`, `Skeleton`, `Archer`, `Arrow`, `SkeletonKing`, `Door`, `Chest`, `Pickup`, `HeartsBar`, `BossBar`, `RoomCamera`, `CryptGame`, `PauseMenu`, `Facing` (an `enum` and a `static class`), and the plain C# class `Room`. |
| `Editor/CryptKeysSceneBuilder.cs` | **Instructor tool.** Menu **Tools → Crypt Keys (Level 3) → Build Scene** imports the art, cuts the sprites, makes the tiles, the two Rule Tiles, the clips with their events, the Animators and the prefabs, paints the six rooms, and builds the whole scene, lights and UI exactly as the book describes, with every reference wired. |
| `Editor/CryptKeysMap.txt` | The rooms' map, one character a cell: the builder paints and places everything from it (below). |
| `Art/` | `Characters/` (the hero, the skeleton, the archer and the king: 20 sheets each, 22 for the king), `Tiles/DungeonTileset.png`, `Props/` (the chest, keys, potion, gold, arrow, and the mimic and spikes for the Challenges), `UI/`, `Fonts/PixelRpgFont.ttf` and the `PixelRpgFont SDF` font asset the builder makes, and `Licences/`. |
| `Audio/` | 16 sounds and two pieces of music (`Crypt`, `Fight`), and Ninja Adventure's licence. |
| `CREDITS.md` | Every pack, its creator, its link and its licence. |
| `Animation/`, `Tiles/`, `Prefabs/`, `Scenes/` | Made by the scene builder: 92 clips, 8 Animator Controllers (`Humanoid`, `Skeleton King`, `Door`, `Chest`, `Torch`, `Key`, `Potion`, `Gold`) and 2 Override Controllers (`Skeleton Override`, `Archer Override`); the tileset's 112 tiles, the `Floor` and `Tomb Floor` Rule Tiles and the Crypt Palette; 16 prefabs; and `Scenes/CryptKeys.unity`. |
| `Curriculum.Level3.CryptKeys.asmdef`, `Editor/Curriculum.Level3.CryptKeys.Editor.asmdef` | Keep Crypt Keys' classes in their own assemblies (see below). |
| `Docs~/workbook/` | The book's source: `book.md` (edit this one), `workbook.md` (assembled from it: the file the PDF builder, the code checker and the website read) and `cover.png`. The `~` makes Unity ignore the folder. |

The C# Concept chapters, the book assembler, the code checker, the PDF builder and the helper kit the scene builder uses are shared by the Level 3 games: see `../Level3-Shared/README.md`.

## First run

1. Open the project in Unity 6 and wait for scripts to compile (0 errors expected).
2. **Tools → Crypt Keys (Level 3) → Build Scene**. If the project has no **TMP Essential
   Resources** yet, it asks you to import them: click **Import** in the Import Unity
   Package window, wait for the import, then run **Build Scene** again.
3. Press **Play**, then **Play** on the start panel. **W A S D** or the arrows walk (or
   hold the mouse button down), **Space** or **J** (or a quick click) swings, **E** opens
   the chest in front, **Q** drinks a potion, and **Esc** or **P** pauses.

If the open scene has unsaved changes, the builder asks about them first. It also adds the `Walls`, `Hero` and `Enemy` layers (any that are missing), unticks **Enemy** against **Enemy** in the Physics 2D collision matrix (skeletons pass through each other, and arrows through skeletons), sets the 2D Renderer's **Transparency Sort Mode** to **Custom Axis (0, 1, 0)** (lower on the screen draws in front), imports the art as pixel art (32 Pixels Per Unit, Point filter, no compression, sliced and pivoted as the book does it), and puts the scene first in Build Settings, so a build starts with it. It logs `Crypt Keys scene built: …` when it's done. Running it again rebuilds the scene, the clips, the Animators and the prefabs in place (they keep their GUIDs), so anything changed in them by hand is lost; the font asset, the Rule Tiles and the Tile Palette are made once and kept.

## Why Crypt Keys has its own assemblies

The curriculum's games share class names: Knight Run has a `PauseMenu` too, for example. Two classes with the same name in the same assembly don't compile; in different assemblies they're fine. So Crypt Keys keeps its scripts in their own assembly definition (`Curriculum.Level3.CryptKeys`, not auto-referenced, using the Input System, TextMeshPro and UI) and its scene builder in an Editor-only one (`Curriculum.Level3.CryptKeys.Editor`, which also uses the shared builder kit in `Curriculum.Level3.Shared.Editor`, URP's 2D runtime and Tilemap Extras). Students never see this: in their own projects, scripts go in `Assets/Scripts` as the book says.

## Input

The project uses the **Input System** package only. The hero reads the keyboard with `Keyboard.current` and the mouse or a finger with `Pointer.current`, checking each isn't `null` first. A press held longer than 0.25 s walks him towards the pointer; a quicker one is a tap, which opens the chest in front of him or swings the sword the way of the tap. A press that lands on the UI (a potion slot, the pause button) belongs to the UI: `Hero` asks `EventSystem.current.IsPointerOverGameObject()` on every frame of the press. So there are no on-screen buttons to move with, and the same build plays on a computer and a phone. To test touch without a phone: **Window → General → Device Simulator** (Chapter 12).

## The state machines to stress

The ideas to stress in class, in Chapters 4, 6 and 13:

- **The hero's Animator** (Chapter 4): one controller, `Humanoid`, with four sub-state machines (Down, Left, Up, Right) of five states each, joined through their **Exit** nodes and the Base Layer's arrows on `Direction`. The code only sets parameters (`Direction`, `Speed`, and the `Attack`, `Hurt` and `Dead` triggers) through `static readonly` hashes. The Down machine is built state by state, then copied and pasted three times.
- **The enemies** (Chapter 6): the states live in code, an `enum State` with one `EnterState`; the Animator is the hero's own, through an Override Controller, and only shows the body. One controller for four characters.
- **The king** (Chapter 13): a **copy** of `Humanoid`, extended with a `Whirlwind` Bool, a `Summon` trigger and two states in the Base Layer, because an Override Controller can swap clips but not add states. When to override, and when to copy.

And the game itself is a state machine too (Chapter 12): `CryptGame`'s `GameState` (Start, Playing, Paused, Won, Lost) shows one panel per state and sets `Time.timeScale` in its enter steps. `Restart` puts every skeleton, archer, door, chest and pickup back with their own reset methods, and the king destroys the skeletons he summoned; scene loading waits for Level 4.

## The rooms' map

`Editor/CryptKeysMap.txt` holds the six rooms, bottom to top, each a heading (`# The Crypt Gate`…) and 11 rows of 19 cells, top row first; room k fills rows 11k to 11k + 10. `#` is the dark, `W` the wall's face (its top row and its bottom row tiles are chosen by position, and its end tiles beside the dark and the doorway), `D` the doorway (its door hangs there), `.` and `,` floor and tomb floor, `d` a doorway's threshold, `R` the Chapel's carpet, `H` the hero's start, `s` `a` `K` a skeleton, an archer and the king, `x` a summon point, `k` `q` `b` a chest holding a key, a potion and a key, or the boss key, `g` and `p` gold and a potion, `S` `Z` `O` a statue, a shield statue and a pillar, `T` a standing torch, and `t` and `B` a wall torch and a banner on the wall's face. The book prints each room's map, and every position, in the chapter that paints it (Chapters 1, 6, 8, 9, 10 and 13): after changing the map, run **Build Scene**, and change the book to match.

## Rebuilding the book and the PDF

Edit `Docs~/workbook/book.md` (or a shared concept chapter), never `workbook.md`. Then assemble the book, check its code and build the PDF, from `Level3-Shared`:

```bash
cd Assets/Levels/Level3-Shared/Docs~
node assemble.mjs            # book.md + the shared chapters → workbook.md (every Level 3 book)
node check-code.mjs          # compile every script version in the book; compare the cards with Scripts/
cd pdf
npm install                  # first time only
node build.mjs ../../../Level3-CryptKeys/Docs~/workbook/workbook.md ../../../Level3-CryptKeys/Docs/Level3-CryptKeys-Workbook.pdf
```

Requires Google Chrome (path in `build.mjs`, or set `CHROME_PATH`). `node assemble.mjs --check` says whether `workbook.md` is up to date without changing anything. More in `../Level3-Shared/README.md`.

## Keep the code honest

The book shows each script many times, as it grows from chapter to chapter, and its final version as a code card (` ```csharp:Skeleton.cs `) that must match `Scripts/` byte for byte. `check-code.mjs` checks both: every version must compile, at the step where the book shows it, together with the other scripts as they stand then, and every card must equal its script. After editing either side, assemble the book and run it: it prints `ok` with `(53 script versions, 18 cards, 21 C# examples)`. One trailing space, or an extra blank line at the end of a file, shows as a card that differs.

## The website

`workbook.md` is also the source of the Crypt Keys pages on the course site, entry `level-3-crypt-keys` in `web/levels.config.mjs`. They are published, and locked with the `COURSE_PW_LEVEL_3_CRYPT_KEYS` repository secret (see `web/README.md`): push a re-assembled `workbook.md` and the site follows.
