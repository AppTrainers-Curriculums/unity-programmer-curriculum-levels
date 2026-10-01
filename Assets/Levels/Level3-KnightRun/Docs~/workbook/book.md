---
title: "Knight Run"
subtitle: "Level 3: Junior-ready"
author: "Unity Programmer Curriculum  ·  Level 3"
coverEyebrow: "Level 3 · Junior-ready · Learn to Code · Make Games"
coverTop: "Knight"
coverRed: "Run"
coverSub: "A 2D platformer with an animated knight, slimes that think in states, three seasons of tiles, checkpoints, a health bar, a pause menu, and buttons for a finger on a phone."
coverPill: "Level 3 Workbook · Knight Run"
coverCaption: "14 scripts · 21 animation clips · 1 knight"
coverArt: image
coverImage: cover.png
footer: "Knight Run  ·  Level 3 Workbook"
---

# Part 0 — Before You Start

## What you're going to build

A **2D platformer**. A small knight runs, jumps and rolls through one long level in
three sections, each in its own season:

| Section | Name | What's in it |
| --- | --- | --- |
| 1 | **The Meadow** | green grass, trees, two water pits, a floating platform, and 3 slimes |
| 2 | **The Autumn Woods** | gold grass and mushrooms, a long pit of purple goo crossed on floating platforms, and slimes that are harder to beat |
| 3 | **The Castle Walls** | snowy stone walls over a moat, a running jump, a last climb, and the castle door |

**How to play:** run with **A** and **D** or the arrow keys, jump with **Space**,
**W** or **↑**, and roll with **Shift** or **J**. On a phone, four buttons in the
bottom corners do the same, and work with two fingers at once. **Esc** or **P** pauses.

The knight has **5 health**. Landing on a slime **stomps** it; **rolling** into one
knocks it over, and nothing can hurt the knight while he rolls. Any other bump with a
slime costs 1 health, knocks him back, and makes him blink. Green slimes take one hit;
purple ones take two. Falling into water, goo or the moat costs 1 health and puts him
back at the last **checkpoint**: a signpost that lights up when he passes it. Apples
give health back. There are 30 coins to find, and the castle door at the far end wins
the game. A start screen waits for **Play**, the win screen shows the coins and the
time, and **Restart** puts the whole level back as it began.

## Level 3 has three books

Level 3 has three games, each with its own book: **Knight Run** (this one, a 2D
platformer), **Crypt Keys** (a 2D dungeon) and **Gate Guard** (a 3D tower defence).
Every book teaches **every** Level 3 topic, and they share the same C# Concept chapters,
so your trainer can run one book, or give different groups different books. If you've
done one book already, the C# Concept chapters in the next are a revision round.

Level 3 ends at an exam: the **Unity Certified User: Programmer**. Parts 5 and 6 of this
book get you ready for it.

## How this book works

It works like Levels 0 to 2: two kinds of chapters, read in the order they appear.

| Chapter | Colour | What it does |
| --- | --- | --- |
| **Chapter 1, 2, 3…** | Red | **Build** the game in Unity, step by step. |
| **C# Concept 1, 2, 3…** | Slate | **Learn** one coding or Unity idea, with examples to try. |

Each chapter follows the same beats: **Goal**, **Idea**, **Do it**, **Test it** and
an optional **Challenge**. Under many C# examples, a grey box shows what the Console
prints: **predict** it before you look.

You'll try the C# examples in a `Practice` script, as before: make an empty GameObject
called `Practice`, give it a script called `Practice`, put the example in, press
**Play**, and read the Console. When an example needs more than that, the chapter says.

> **Tip:** you passed the Level 3 entry test, so everything in Levels 0 to 2 is yours to
> use: properties, coroutines, lists and dictionaries, `static` and `const`, raycasts,
> UI events, `GetComponent`, the Input System and the Rigidbody 2D. Keep the Level 2
> cheat sheet next to you.

## The route through this book

| Step | Chapter | You learn | You build |
| --- | --- | --- | --- |
| 1 | {{ref:naming}} | Naming conventions | — |
| 2 | Chapter 1 | Pixel art, sprite sheets, the Tile Palette, Tilemaps | The Meadow |
| 3 | Chapter 2 | Two ground rays, one-way platforms, a camera that follows | Run and jump |
| 4 | {{ref:animwindow}} | Clips, keyframes, sprite frames | — |
| 5 | Chapter 3 | Seven clips from one sprite sheet | The knight's clips |
| 6 | {{ref:animator}}, {{ref:animcode}} | States, transitions, parameters, hashes | — |
| 7 | Chapter 4 | The Animator, driven from code | The knight's Animator |
| 8 | {{ref:animevents}} | Animation Events | — |
| 9 | Chapter 5 | Triggers, Any State, exit time, events | The roll |
| 10 | {{ref:statemachines}}, {{ref:enemies}} | State machines in code and in the Animator | — |
| 11 | Chapter 6 | An enemy as a state machine | The slime |
| 12 | Chapter 7 | Collisions, contact normals, knockback | Stomp, hurt and pits |
| 13 | Chapter 8 | Override Controllers, a second Tilemap section | The Autumn Woods |
| 14 | Chapter 9 | Property animation, pickups, respawning | Coins, apples and checkpoints |
| 15 | {{ref:gameui}} | Health bars, panels, pausing | — |
| 16 | Chapter 10 | `[System.Serializable]`, font assets | The HUD |
| 17 | Chapter 11 | The game as a state machine, Restart in code | Start, win and lose |
| 18 | Chapter 12 | Pausing, Event Triggers, the Device Simulator | Pause and touch |
| 19 | Chapter 13 | Sound on events, music | The Castle Walls |
| 20 | {{ref:reading}}, {{ref:errors}}, {{ref:classes}} | Reading code, finding errors, kinds of classes | — |
| 21 | Chapter 14 | The Animator's mistakes and how to find them | Break it, then fix it |
| 22 | Chapter 15 | A Web build, and testing it | A game you can share |
| 23 | Part 5 | The exam, and how to take it | — |
| 24 | Part 6 | Exam-style practice | — |

## For trainers: running a session

Sessions follow the route above, with the same rhythm as Levels 0 to 2:

| Share | Activity | From |
| --- | --- | --- |
| About 20% | **Concept:** teach the idea. Students predict each example's Console output before you run it. | C# Concept chapters |
| About 60% | **Build:** students follow the chapter in Unity and press Play at every checkpoint. | Build chapters |
| About 20% | **Practice:** the **Do it** exercises, in class or as homework. | C# Concept chapters |

Students join Level 3 by passing the **Level 3 entry test** (the entry test papers in
the course project; the answer key is a separate trainer-only file). Chapters 4, 6 and
11 are the heart of this book: the knight's Animator, the slime's state machine, and
the game's own state machine. Give them the most time. Chapters 1, 8 and 13, the
painting chapters, can run long for slow mouse users: let students finish painting at
home if they need to, from the maps in the book.

Your trainer project has the finished game, and a menu item that builds its scene from
scratch (**Tools → Knight Run (Level 3) → Build Scene**): use it to show the goal on the
first day, or to rescue a scene that's beyond repair.

## The pieces we'll build

Fourteen scripts:

```
KnightController ── runs, jumps and rolls; tells the Animator what he's doing
KnightHealth ────── 5 health, knockback, blinking, death
KnightCombat ────── decides each bump with a slime: a stomp, a roll, or a hurt knight
Slime ───────────── an enemy as a state machine: patrol, chase, wind up, leap, hurt, dead
Coin ────────────── counts, and hides
Apple ───────────── gives health back
Checkpoint ──────── a signpost that lights up, and becomes the respawn point
CastleDoor ──────── the finish
KillZone ────────── water, goo, the moat and the bottom of the level
CameraFollow ────── follows the knight, and stays inside the level
HealthBar ───────── a bar that slides, and fades from green to red
PauseMenu ───────── Resume, Restart and the volume
PlatformerGame ──── the game's own state machine: start, playing, paused, won, lost

Section ─────────── one section's name, start and sky (a plain C# class)
```

## New words for Level 3

| Word | What it means |
| --- | --- |
| **Sprite sheet** | one picture holding many frames or tiles, cut into separate sprites |
| **Tilemap** | a grid of tiles painted like a picture: the level's ground, water and decoration |
| **Tile Palette** | the window you pick tiles from to paint them |
| **Animation clip** | how some properties change over time: an `.anim` asset |
| **Keyframe** | a value set at one moment of a clip; Unity fills in the moments between |
| **Animator Controller** | the state machine that chooses which clip plays |
| **State, transition** | a box in the Animator, and an arrow from one box to another |
| **Parameter** | a value that code sets, and transitions read: Float, Int, Bool or Trigger |
| **Animation Event** | a marker on a clip that calls one of your methods |
| **State machine** | code, or an Animator, that's in one state at a time and follows rules to change |
| **Override Controller** | a copy of an Animator Controller's state machine with other clips |
| **One-way platform** | a platform you can jump up through and stand on |

## One-time project setup

- **Unity 6**, with a new project created from the **Universal 2D** template.
- **Input:** the **Input System** package, already in a new Unity 6 project. There's
  nothing to set up.
- **Art and sound:** everything comes from **Brackeys' Platformer Bundle**, free to use
  for anything (CC0). Your trainer shares its folder; to download it yourself, it's on
  itch.io as "Brackeys' Platformer Bundle". It holds:
  - `sprites/`: `knight.png`, `slime_green.png`, `slime_purple.png`, `coin.png`,
    `fruit.png`, `platforms.png` and `world_tileset.png`;
  - `sounds/`: six sounds; `music/`: `time_for_adventure.mp3`;
  - `fonts/`: `PixelOperator8.ttf` and its bold version.
- Scripts live in `Assets/Scripts`, sprites in `Assets/Art`, fonts in `Assets/Fonts`,
  sounds and music in `Assets/Audio`, clips and controllers in `Assets/Animation`, tiles
  and the palette in `Assets/Tiles`, prefabs in `Assets/Prefabs`, and the physics
  material in `Assets/Materials`.

# Part 1 — The Knight

{{concept:naming}}

## Chapter 1 — A World of Tiles

**Goal:** a new project with the bundle's art imported as pixel art, a Tile Palette, and
the Meadow, the first section of the level, painted on three Tilemaps: solid ground,
deadly water and decoration.

### Idea — pixel art needs its own import settings

The bundle's art is **pixel art**: tiny pictures meant to be blown up big, every pixel a
sharp square. Unity's usual import settings are made for smooth art, so they blur pixel
art and spoil its colours. Four settings fix that:

| Setting | Value | Why |
| --- | --- | --- |
| **Pixels Per Unit** | `16` | the tiles are 16 pixels across, so one tile is one unit in the world |
| **Filter Mode** | **Point (no filter)** | the other modes blend each pixel with its neighbours: blur |
| **Compression** | **None** | compression changes colours a little, and in pixel art every colour shows |
| **Sprite Mode** | **Multiple** | a sheet holds many sprites, cut out with the Sprite Editor |

| Sheet | Pixels | Cut into |
| --- | --- | --- |
| `world_tileset.png` | 256 × 256 | 16 × 16 tiles: ground for four seasons, trees, signs, sky colours, water, goo |
| `knight.png` | 256 × 256 | 32 × 32 frames of the knight |
| `slime_green.png`, `slime_purple.png` | 96 × 72 | 24 × 24 frames of a slime |
| `coin.png`, `fruit.png` | 192 × 16, 64 × 64 | 16 × 16 frames and fruits |
| `platforms.png` | 64 × 64 | floating platforms, 1 and 2 tiles wide |

### Idea — Tilemaps

A level made of tiles is painted, not built object by object. Unity's tools for it:

| Thing | What it is |
| --- | --- |
| **Grid** | a GameObject that lays out cells, 1 unit each, like squared paper |
| **Tilemap** | a child of the Grid that holds a tile in some of its cells, like one layer of paint |
| **Tile** | an asset that says which sprite a cell shows, and whether it's solid |
| **Tile Palette** | a window full of tiles, to pick from while you paint |

The level has three Tilemaps, one per job:

| Tilemap | Holds | Collider |
| --- | --- | --- |
| `Ground` | everything you stand on | solid |
| `Hazards` | water, goo and the moat | a trigger: Chapter 7 makes it deadly |
| `Decoration` | trees, bushes, mushrooms | none: the knight walks in front of them |

Every cell has a **column** (its x) and a **row** (its y). The ground's top row is row
`-1`, so its surface is at height 0: the knight will stand at `y = 0`.

### Do it — the project and the art

1. In **Unity Hub**, create a new project from the **Universal 2D** template.
2. **File → Save As** `Assets/Scenes/KnightRun.unity`.
3. In the **Project** window, create the folders `Art`, `Fonts`, `Audio`, `Scripts`,
   `Animation`, `Tiles`, `Prefabs` and `Materials` inside `Assets`.
4. Copy the bundle's seven sprites into `Assets/Art`, its two fonts into
   `Assets/Fonts`, and its six sounds and its music into `Assets/Audio`.

### Do it — the tileset, as pixel art

1. Select `world_tileset` in `Assets/Art`. In the Inspector, set:
   - **Texture Type** to **Sprite (2D and UI)**, and **Sprite Mode** to **Multiple**;
   - **Pixels Per Unit** to `16`;
   - **Filter Mode** to **Point (no filter)**;
   - **Compression** to **None**.

   Click **Apply**.
2. Click **Open Sprite Editor**. Open the **Slice** menu at its top-left, and set
   **Type** to **Grid By Cell Size**, **Pixel Size** to `16` × `16` and **Pivot** to
   **Center**. Click **Slice**, then **Apply** at the top-right, and close the window.
3. Open the arrow on `world_tileset` in the Project window: it holds 127 sprites now,
   `world_tileset_0` to `world_tileset_126`. Unity left out the cells that are empty.

### Do it — the Tile Palette

1. **Window → 2D → Tile Palette**, and dock it beside the Inspector.
2. In its drop-down of palettes, choose **Create New Palette**. Name it `Knight Run`,
   leave **Grid** as **Rectangle** and **Cell Size** as **Automatic**, click **Create**,
   and choose the `Assets/Tiles` folder.
3. Drag `world_tileset` (the sheet itself, not one of its sprites) from the Project
   window into the palette. When Unity asks where to save the tiles, choose
   `Assets/Tiles` again. It makes 127 Tile assets, and lays them out in the palette
   just as they are in the sheet.
4. Make every tile solid as a whole square: in `Assets/Tiles`, click the first tile,
   Shift-click the last, and in the Inspector set **Collider Type** to **Grid**.

The tileset's blocks have rounded corners. With the default **Collider Type**,
**Sprite**, each tile's collider follows its outline, and the corners leave little
notches between tiles, just right for a running knight to catch his feet on. **Grid**
makes every collider a full square.

In this book, a tile's place in the palette is its **column** and **row** in the sheet,
counted from 0 at the top-left. The palette's top-left tile, column 0, row 0, is grass;
the brown block under it, column 0, row 1, is dirt.

### Do it — the Grid and its three Tilemaps

1. In the Hierarchy, right-click → **2D Object → Tilemap → Rectangular**. Unity makes
   a `Grid` with a child, `Tilemap`. Rename the child `Ground`.
2. Right-click `Grid` → **2D Object → Tilemap → Rectangular** twice more, and name the
   new Tilemaps `Hazards` and `Decoration`.
3. Each Tilemap has a **Tilemap Renderer**. Set its **Order in Layer**: `Decoration`
   `-2`, `Ground` `0`, `Hazards` `1`. Decoration draws behind everything; the liquids
   draw in front of the pits' walls.

### Do it — the camera and the sky

Select **Main Camera**. Check that **Projection** is **Orthographic**, and set **Size**
to `5`: the camera sees 10 tiles from top to bottom. Under **Environment**, set
**Background Type** to **Solid Color** and the colour to a light sky blue, `#8ED0F2`.
Set its **Position** to `(9, 2, -10)` for now.

### Idea — the Meadow's map

This is the whole Meadow, one character per cell. Each line is a row; the numbers on the
left are rows, and the ruler on top counts columns:

```
       0         10        20        30        40        50        60
       |         |         |         |         |         |         |
   3   .............CC................................................
   2   ...........................C.C.C...............................
   1   ....C.C.C....==......####............................C.C..A....
   0   T.K...f...........b..####...s...........T..s..n..s..b....####fP
  -1   #############...##################...##########################
  -2   #############~~~##################~~~##########################
  -3   #############~~~##################~~~##########################
```

| Mark | Is | Painted or placed in |
| --- | --- | --- |
| `#` | ground | this chapter |
| `~` | water | this chapter |
| `T` `b` `f` `n` | a tree, a bush, flowers, a mushroom | this chapter |
| `K` | where the knight starts | Chapter 2 |
| `==` | a floating platform | Chapter 2 |
| `s` | a green slime | Chapter 6 |
| `C` `A` `P` | a coin, an apple, the checkpoint sign | Chapter 9 |

### Do it — find your way round the grid

The Tile Palette's tools, along the top of its window:

| Tool | Key | Does |
| --- | --- | --- |
| **Select** | **S** | selects cells, and shows where they are |
| **Paint** | **B** | paints the picked tile, one cell at a time, or as you drag |
| **Box Fill** | **U** | fills a rectangle: drag from one corner to the other |
| **Pick** | **I** | picks the tile already in a cell |
| **Erase** | **D** | removes tiles |

To find a cell, use the **Select** tool and drag over some cells in the Scene view. The
Inspector shows a **Grid Selection** with its **Position** (the bottom-left cell's
column and row) and **Size**. Drag again until Position says, for example, `X 16`,
`Y -3`, and you know where column 16, row −3 is. The grid lines in the Scene view mark
every cell, so from there you can count.

### Do it — paint the ground

At the top of the Tile Palette, the drop-down beside the tools names the Tilemap you're
painting on. Set it to **Ground**.

1. Pick the dirt tile (column 0, row 1). With **Box Fill**, fill three rectangles, each
   from row −3 up to row −1:
   - columns 0 to 12;
   - columns 16 to 33;
   - columns 37 to 62.
2. Two blocks stand on the ground. Fill them with dirt too:
   - columns 21 to 24, rows 0 and 1;
   - columns 57 to 60, row 0.
3. Pick the grass tile (column 0, row 0), and paint grass on the **top** cell of every
   column of ground, over the dirt:
   - row −1, columns 0 to 12, 16 to 20, 25 to 33, 37 to 56, and 61 and 62;
   - row 1, columns 21 to 24, the tall block's top;
   - row 0, columns 57 to 60, the low block's top.

Under each block the ground stays dirt: grass only grows where there's sky above it.
Compare your Scene view with the map, and fix any cell that's wrong with **Erase** or a
fresh tile.

### Do it — the water

Set the drop-down to **Hazards**.

1. Pick the water with waves on top (column 4, row 9), and paint row −2 of the two pits:
   columns 13 to 15, and 34 to 36.
2. Pick the plain water under it (column 4, row 10), and paint row −3 of the same
   columns.

The water sits a tile below the grass: the pits look like pits.

### Do it — decoration

Set the drop-down to **Decoration**, and paint, one tile at a time:

| Thing | Tiles in the palette | Paint it at |
| --- | --- | --- |
| a tall tree | column 0, rows 5 (trunk), 4 and 3 (top) | its trunk at (0, 0), then (0, 1) and (0, 2); again at column 40 |
| a bush | column 1, row 4 | (18, 0) and (52, 0) |
| flowers | column 1, row 6 | (6, 0) and (61, 0) |
| a small red mushroom | column 8, row 5 | (46, 0) |

A tree is three tiles, painted bottom to top: its trunk on row 0, then its leaves on
rows 1 and 2.

### Do it — make the ground solid

1. Select `Ground`. At the top of the Inspector, open **Layer** → **Add Layer…**, and
   type `Ground`, `Knight` and `Enemy` into three empty **User Layers**: you'll need the
   other two soon. Select `Ground` again, and set its **Layer** to **Ground**.
2. **Add Component → Tilemap Collider 2D**, and set its **Composite Operation** to
   **Merge**.
3. **Add Component → Composite Collider 2D**. Unity adds a **Rigidbody 2D** with it:
   set its **Body Type** to **Static**, so the ground never moves. On the **Composite
   Collider 2D**, set **Geometry Type** to **Polygons**.
4. Select `Hazards`, **Add Component → Tilemap Collider 2D**, and tick **Is Trigger**.

### Idea — why merge the colliders?

On its own, a Tilemap Collider 2D gives every tile its own square: hundreds of them, side
by side. A body sliding along them can catch on the seams between squares. The
**Composite Collider 2D** merges them all into one shape per piece of ground, with no
seams: the ground is one smooth floor. **Polygons** makes the shape solid inside, not
only its outline.

### Test it

Select `Ground` and look at the Scene view: a green outline runs round each of the three
pieces of ground and the two blocks, with no lines between the tiles. Select `Hazards`:
an outline round each pit's water. Press **Play**: nothing moves yet, but the Game view
shows the Meadow through the camera.

### Challenge

Paint clouds. The palette's bottom-left corner (columns 0 to 3, rows 9 to 15) holds four
skies: each column runs from a pale colour down to a dark one, with puffs where the
colours meet. Add a fourth Tilemap, `Sky`, with **Order in Layer** `-10`, and paint a
band of the blue column across the top of the Meadow, darkest at the top. The sheet has
them the other way up: flip the brush with **Shift + ]** before you paint.

## Chapter 2 — Run and Jump

**Goal:** the knight stands in the Meadow, runs with **A** and **D** or the arrows,
jumps with **Space**, lands on a floating platform he can jump up through, and the
camera follows him without ever showing anything outside the level.

### Idea — the knight's sprite sheet

`knight.png` holds 32 × 32-pixel frames, in rows, with the name of each row printed on
the sheet. Sliced into a grid, Unity numbers the frames from the top-left, and the
printed labels become sprites too, which you'll never use:

| Sprites | Are |
| --- | --- |
| `knight_0` to `knight_3` | **idle**: 4 frames |
| `knight_4` to `knight_7` | the labels IDLE and RUN |
| `knight_8` to `knight_23` | **run**: 16 frames, in two rows |
| `knight_24`, `knight_25` | the label ROLL |
| `knight_26` to `knight_33` | **roll**: 8 frames |
| `knight_34` to `knight_37` | **hit**: 4 frames, one of them flashing red |
| `knight_38`, `knight_39` | the label HIT |
| `knight_40` to `knight_43` | **death**: 4 frames |
| `knight_44` to `knight_46` | the label DEATH |

A sprite's **pivot** is the point that sits at the GameObject's position. In every frame,
the knight's feet are 4 pixels above the bottom of his 32-pixel frame, so a pivot of
`(0.5, 0.125)` (halfway across, and 4 / 32 of the way up) puts the knight's position
exactly at his feet. Then `y = 0` means standing on the ground.

### Idea — is he standing on something?

A jump is only allowed from the ground, so the script must know when the knight is
standing. It shoots two short rays down, one from each foot, against the **Ground**
layer only, with Level 2's `Physics2D.Raycast`:

```
        knight
        ▓▓▓▓▓
        ▓▓▓▓▓
     left   right     ← two empty children, at his feet
       │     │
       ↓     ↓        ← 0.15 units down: does either hit the Ground layer?
   ════════════════
```

Two rays, because one from his middle misses the ground when he stands on the very edge
of a block. And moving **up** never counts as standing, even if a ray still touches
the ground: that's a jump just beginning.

### Idea — moving by velocity

Each frame, the script sets the Rigidbody 2D's velocity: across, the run speed in the
direction of the keys; up and down, whatever gravity has made it, untouched. A jump sets
the upward speed once, and gravity brings him down. With **Gravity Scale** `3`, gravity
is three times Earth's, and jumps feel quick and snappy.

| Number | Value | Gives |
| --- | --- | --- |
| run speed | 6 units a second | across the screen in about 3 seconds |
| jump speed | 12 units a second up | about 2.4 units high: onto a block 2 tiles tall |
| Gravity Scale | 3 | up and down in under a second |

A velocity is safe to set in `Update`. The Rigidbody keeps it until the next physics
step uses it. (Forces are different: `AddForce` belongs in `FixedUpdate`.)

> **Note:** a Rigidbody pressed against a wall in mid-air grips the wall by friction,
> and the knight sticks there. A **Physics Material 2D** with a **Friction** of 0 lets
> him slide down it instead.

### Do it — the knight's sprites

1. Select `knight` in `Assets/Art`, and give it the same settings as the tileset:
   **Sprite (2D and UI)**, **Multiple**, **Pixels Per Unit** `16`, **Point (no filter)**,
   **Compression** **None**. Click **Apply**.
2. **Open Sprite Editor → Slice**: **Grid By Cell Size**, `32` × `32`. Set **Pivot** to
   **Custom**, and **Custom Pivot** to `X 0.5`, `Y 0.125`. Click **Slice**, then
   **Apply**.

### Do it — the knight

1. Drag `knight_0` from the Project window into the Hierarchy. Rename it `Knight`, set
   its **Position** to `(2.5, 0, 0)`, its Sprite Renderer's **Order in Layer** to `5`,
   and its **Layer** to **Knight**.
2. **Add Component → Rigidbody 2D**. Set **Gravity Scale** to `3`, **Collision
   Detection** to **Continuous**, **Interpolate** to **Interpolate**, and under
   **Constraints**, tick **Freeze Rotation Z**: a knight shouldn't tip over.
3. **Add Component → Capsule Collider 2D**. Set **Size** to `(0.7, 1.15)` and **Offset**
   to `(0, 0.575)`, so the capsule's bottom is at his feet.
4. In `Assets/Materials`, **right-click → Create → 2D → Physics Material 2D**. Name it
   `No Friction`, and set its **Friction** to `0`. Drag it into the knight's
   **Rigidbody 2D → Material**.
5. Right-click `Knight` → **Create Empty**, twice. Name the children `Left Foot` and
   `Right Foot`, at **Position** `(-0.25, 0.05, 0)` and `(0.25, 0.05, 0)`.

### Do it — the script

Create `KnightController` in `Assets/Scripts` and attach it to `Knight`:

```csharp
using UnityEngine;
using UnityEngine.InputSystem;

// The knight. For now, he runs and jumps with the keyboard.
[RequireComponent(typeof(Rigidbody2D))]
public class KnightController : MonoBehaviour
{
    [SerializeField] Transform leftFoot;
    [SerializeField] Transform rightFoot;
    [SerializeField] LayerMask groundMask;
    [SerializeField] float runSpeed = 6f;
    [SerializeField] float jumpSpeed = 12f;
    [SerializeField] float groundCheckDistance = 0.15f;

    Rigidbody2D body;
    SpriteRenderer spriteRenderer;

    float moveInput;            // -1 left, 0 still, 1 right
    bool isGrounded;
    bool isFacingLeft;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        isGrounded = CheckGround();
        bool isJumpPressed = false;

        moveInput = 0f;

        // The keyboard. A phone may have no keyboard, and then Keyboard.current is null.
        Keyboard keyboard = Keyboard.current;
        if (keyboard != null)
        {
            if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed)
            {
                moveInput -= 1f;
            }
            if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed)
            {
                moveInput += 1f;
            }
            if (keyboard.spaceKey.wasPressedThisFrame || keyboard.wKey.wasPressedThisFrame || keyboard.upArrowKey.wasPressedThisFrame)
            {
                isJumpPressed = true;
            }
        }

        if (moveInput != 0f)
        {
            isFacingLeft = moveInput < 0f;
            spriteRenderer.flipX = isFacingLeft;
        }
        if (isJumpPressed && isGrounded)
        {
            Jump();
        }

        // Run. A velocity is safe to set in Update: the Rigidbody keeps it
        // until the next physics step uses it.
        body.linearVelocity = new Vector2(moveInput * runSpeed, body.linearVelocity.y);
    }

    // Two short rays down from his feet, against the Ground layer only.
    // Moving up is never standing: that's a jump just starting.
    bool CheckGround()
    {
        if (body.linearVelocity.y > 0.01f)
        {
            return false;
        }
        RaycastHit2D left = Physics2D.Raycast(leftFoot.position, Vector2.down, groundCheckDistance, groundMask);
        RaycastHit2D right = Physics2D.Raycast(rightFoot.position, Vector2.down, groundCheckDistance, groundMask);
        return left.collider != null || right.collider != null;
    }

    void Jump()
    {
        body.linearVelocity = new Vector2(body.linearVelocity.x, jumpSpeed);
        isGrounded = false;
    }
}
```

In its Inspector, drag `Left Foot` and `Right Foot` into their fields, and set **Ground
Mask** to **Ground**.

Read it before you move on:

- `Awake` finds the knight's own **Rigidbody 2D** and **Sprite Renderer**:
  `RequireComponent` makes sure the first is there.
- `moveInput` starts at 0 every frame; **A** takes 1 away and **D** adds 1, so both
  together cancel out.
- `isPressed` is true for as long as a key is held: right for running.
  `wasPressedThisFrame` is true on one frame only: right for a jump, which happens
  once per press.
- `spriteRenderer.flipX` mirrors the picture, so he faces the way he runs. It changes
  only while he's moving: standing still, he keeps facing the way he last ran.
- `Jump` sets the upward speed, and keeps the speed across. `isGrounded = false` stops
  a second jump in the same frame.
- Every name reads as what it is ({{ref:naming}}): `isGrounded` and `isFacingLeft` are
  questions, `CheckGround` and `Jump` are verbs.

### Do it — a camera that follows

Create `CameraFollow`, and attach it to **Main Camera**:

```csharp:CameraFollow.cs
using UnityEngine;

// Follows the knight smoothly, and never shows anything outside the level.
[RequireComponent(typeof(Camera))]
public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector2 offset = new Vector2(0f, 2f);         // look a little above the knight
    [SerializeField] float followSpeed = 5f;
    [SerializeField] Vector2 levelMin = new Vector2(0f, -3f);       // the level's bottom-left corner
    [SerializeField] Vector2 levelMax = new Vector2(189f, 12f);     // and its top-right corner

    Camera cam;

    void Awake()
    {
        cam = GetComponent<Camera>();
    }

    // LateUpdate runs after every Update, so the knight has already moved.
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, Goal(), followSpeed * Time.deltaTime);
    }

    // Straight to the knight, with no easing: after a fall, and on Restart.
    public void SnapToTarget()
    {
        transform.position = Goal();
    }

    Vector3 Goal()
    {
        // The camera sees Size units above and below its centre, and
        // Size × aspect units to each side.
        float halfHeight = cam.orthographicSize;
        float halfWidth = halfHeight * cam.aspect;
        float x = Mathf.Clamp(target.position.x + offset.x, levelMin.x + halfWidth, levelMax.x - halfWidth);
        float y = Mathf.Clamp(target.position.y + offset.y, levelMin.y + halfHeight, levelMax.y - halfHeight);
        return new Vector3(x, y, transform.position.z);
    }
}
```

Drag `Knight` into **Target**. **Level Min** `(0, -3)` and **Level Max** `(189, 12)` are
the corners of the whole level, all three sections: the camera never shows past them.

Read it before you move on:

- `LateUpdate` runs after every `Update`: the knight has already moved this frame when
  the camera follows.
- `Vector3.Lerp(from, to, t)` moves part of the way: with `t` at 5 × `Time.deltaTime`,
  the camera eases after the knight instead of jerking.
- `Goal` keeps the camera's centre half a screen inside the level's edges. Half its
  width depends on the screen's shape (`cam.aspect`), so it works on a phone too.
- `SnapToTarget` jumps straight there. Chapter 7 uses it, when the knight comes back
  from a fall.

### Do it — a floating platform

1. Give `platforms` the same pixel-art settings, and **Apply**. In the **Sprite
   Editor**, **Slice** with **Type** set to **Automatic** and **Pivot** to **Top**:
   Unity finds the eight platforms by their outlines.
2. Drag the green platform two tiles wide into the Hierarchy. Rename it
   `Meadow Platform`, set its **Position** to `(14, 2, 0)`, over the first pit, and its
   **Layer** to **Ground**.
3. **Add Component → Box Collider 2D**: **Size** `(2, 0.5)`, **Offset** `(0, -0.25)`,
   and tick **Used By Effector**.
4. **Add Component → Platform Effector 2D**. Check that **Use One Way** is ticked.
5. Drag `Meadow Platform` from the Hierarchy into `Assets/Prefabs`: it's a prefab now.

The **Platform Effector 2D** makes the collider **one-way**: solid from above, empty from
below. The knight jumps up through it, and lands on top. His ground check works on it
too: it's on the Ground layer.

### Test it

Press **Play**. Run both ways: the knight turns to face the way he runs. Jump onto the
tall block, then jump up through the platform from below and stand on it. Run along to
the end of the Meadow: the camera follows, and stops where the level ends. Now walk
into a pit: the knight falls forever, and the camera stops at the bottom of the level.
Chapter 7 fixes the pits. Stop, and play again.

### Challenge

A jump you can control: if the jump key comes up while the knight is still rising,
halve his upward speed, so a tap makes a little jump and a long press a big one. Hint:
`keyboard.spaceKey.wasReleasedThisFrame`, and only while `body.linearVelocity.y > 0`.

{{concept:animwindow}}

## Chapter 3 — Clips for the Knight

**Goal:** seven animation clips for the knight, made in the Animation window from his
sprite sheet: idle, run, jump, fall, roll, hurt and dead.

### Idea — seven clips from one sheet

| Clip | Frames | Samples | Loop Time | Lasts |
| --- | --- | --- | --- | --- |
| `Knight Idle` | `knight_0` to `knight_3` | 8 | on | 0.5 s |
| `Knight Run` | `knight_8` to `knight_23` | 16 | on | 1 s |
| `Knight Jump` | `knight_28`: tucked up, from the roll | 8 | on | one frame |
| `Knight Fall` | `knight_8`: legs apart, from the run | 8 | on | one frame |
| `Knight Roll` | `knight_26` to `knight_33` | 14 | **off** | 0.57 s |
| `Knight Hurt` | `knight_34` to `knight_37` | 10 | **off** | 0.4 s |
| `Knight Dead` | `knight_40` to `knight_43`, then a fade | 8 | **off** | 1 s |

The sheet has no frames drawn for jumping or falling, so those two clips borrow a frame
each: tucked for going up, legs apart for coming down. A clip of one frame is a pose: the
Animator plays clips, so even a pose is one.

Loop Time is off for the last three: a roll, a hurt and a death each happen once.

### Do it — the first clip

1. Open **Window → Animation → Animation**, and select `Knight` in the Hierarchy.
2. Click **Create**, and save the clip as `Assets/Animation/Knight Idle.anim`. Unity adds
   an **Animator** to the knight, and makes an Animator Controller for it,
   `Knight.controller`, beside the clip.
3. In the Animation window's **⋮** menu, tick **Show Sample Rate**, and set **Samples**
   to `8`.
4. In the Project window, open the arrow on `knight`, click `knight_0`, Shift-click
   `knight_3`, and drag the four sprites into the Animation window's timeline.
5. Press the Animation window's **Play** button: in the Scene view, the knight breathes.
   Press it again to stop.

### Do it — the other six

For each clip in the table: open the clip menu at the top-left of the Animation window,
choose **Create New Clip…**, save it in `Assets/Animation` with its name from the table,
set **Samples**, and drag its frames in.

- For `Knight Run`, the frames are in two rows of the sheet, but in one run of names:
  click `knight_8`, Shift-click `knight_23`, and drag all sixteen.
- `Knight Jump` and `Knight Fall` get one sprite each.

Then select `Knight Roll`, `Knight Hurt` and `Knight Dead` in the Project window, one
at a time, and untick **Loop Time** in the Inspector.

### Do it — the fade at the end of Dead

The death frames show the knight falling over. Then he should fade away, over half a
second: a **property** curve on the Sprite Renderer's colour, added to the sprite frames.

1. Pick `Knight Dead` in the clip menu. Click **Add Property**, open **Sprite Renderer**,
   and click the **+** beside **Color**. A Color curve appears, with keyframes at the
   start and the end of the clip.
2. Move the playhead to `0:4` (the clip's end: four frames at 8 samples is half a
   second). If there's no keyframe there for Color, click **Add Keyframe**. Its **A**
   (alpha, how solid it is) should be `1`.
3. Move the playhead to `1:0`, one second. Turn on **Record**, and in the Sprite
   Renderer set the colour's **A** to `0`. A keyframe appears. Turn **Record** off.
4. Play the clip: four frames of falling, then a fade to nothing. The clip now lasts one
   second.

### Idea — what Unity made for you

Select `Knight`: its **Animator** has **Controller** set to `Knight.controller`. Open
**Window → Animation → Animator**: the controller has a state for each of the seven
clips, named after it, and `Knight Idle`, the first you made, is orange: the default
state, the one that plays when the game starts. There are no arrows between the states
yet. Chapter 4 adds them, after the next two C# Concepts.

### Test it

Press **Play**. The knight breathes as he stands. Run: he slides along, still breathing.
The Animator plays only its default state until transitions say otherwise. Stop, and
preview each clip in the Animation window: run, the two poses, roll, hurt, and dead with
its fade.

### Challenge

Try the run at 12 samples and at 20, and watch his feet against the ground while he
runs at 6 units a second. Which looks right? Then choose other frames for the two poses,
such as `knight_26` for the jump. Which reads best as *going up*?

{{concept:animator}}

{{concept:animcode}}

## Chapter 4 — The Knight's Animator

**Goal:** the knight's Animator chooses his clip by itself: idle when he stands, run when
he runs, jump on the way up and fall on the way down. The script tells it, every frame,
what he's doing.

### Idea — the knight's state machine

Three parameters describe the knight, and eight transitions use them:

| Parameter | Type | The script sets it to |
| --- | --- | --- |
| `Speed` | Float | how fast he moves across, always positive |
| `VerticalSpeed` | Float | how fast he moves up (positive) or down (negative) |
| `Grounded` | Bool | whether his feet are on the ground |

```
                    Speed > 0.1
           ┌────────────────────────────┐
  Entry → Idle                         Run
           └────────────────────────────┘
                    Speed < 0.1

   Idle / Run ── not Grounded, VerticalSpeed > 0.1 ──→ Jump ── VerticalSpeed < 0.1 ──→ Fall
   Idle / Run ── not Grounded, VerticalSpeed < −0.1 ─→ Fall ── Grounded ──→ Idle
```

- Every transition has **Has Exit Time** off, and a **Transition Duration** of 0: the
  clip changes the moment the knight does, and sprite frames don't blend.
- Speeds use `0.1`, not `0`: a body resting on the ground can still move a tiny amount,
  and `Speed > 0` would flicker between Idle and Run.
- Out of Jump, `VerticalSpeed < 0.1`, not `< 0`. If he lands on a ledge at the very top
  of a jump, his speed stops at exactly 0. With `< 0` he'd stay in Jump, standing on
  the ledge with his knees tucked.
- Fall goes back to **Idle**, never straight to Run. If he lands running, Idle sends
  him on to Run in the same moment.

### Do it — tidy the states

Open **Window → Animation → Animator** with the knight selected.

1. Rename each state in its Inspector, dropping the word `Knight`: `Idle`, `Run`,
   `Jump`, `Fall`, `Roll`, `Hurt` and `Dead`.
2. Drag them into place: Idle and Run on top, Jump and Fall below them, and Roll, Hurt
   and Dead in a row at the bottom, for Chapters 5 and 7.

### Do it — the parameters

On the **Parameters** tab, click **+** and add:

- a **Float**, `Speed`;
- a **Float**, `VerticalSpeed`;
- a **Bool**, `Grounded`, and tick its box: he starts on the ground.

### Do it — the transitions

For each row below: right-click the first state → **Make Transition**, and click the
second. Select the new arrow, and in the Inspector:

- untick **Has Exit Time**;
- open **Settings**, and set **Transition Duration** to `0`;
- under **Conditions**, click **+** for each condition.

| From | To | Conditions |
| --- | --- | --- |
| Idle | Run | `Speed` Greater `0.1` |
| Run | Idle | `Speed` Less `0.1` |
| Idle | Jump | `Grounded` false, `VerticalSpeed` Greater `0.1` |
| Run | Jump | `Grounded` false, `VerticalSpeed` Greater `0.1` |
| Idle | Fall | `Grounded` false, `VerticalSpeed` Less `-0.1` |
| Run | Fall | `Grounded` false, `VerticalSpeed` Less `-0.1` |
| Jump | Fall | `VerticalSpeed` Less `0.1` |
| Fall | Idle | `Grounded` true |

### Do it — the script

Replace `KnightController` with this version:

```csharp
using UnityEngine;
using UnityEngine.InputSystem;

// The knight: he runs and jumps with the keyboard, and tells his Animator
// what he's doing every frame.
[RequireComponent(typeof(Rigidbody2D))]
public class KnightController : MonoBehaviour
{
    // The Animator's parameters, turned into numbers once. Strings are slow to
    // look up, and a typo in a hash's name is easy to spot: it's written once.
    static readonly int SpeedHash = Animator.StringToHash("Speed");
    static readonly int VerticalSpeedHash = Animator.StringToHash("VerticalSpeed");
    static readonly int GroundedHash = Animator.StringToHash("Grounded");

    [SerializeField] Transform leftFoot;
    [SerializeField] Transform rightFoot;
    [SerializeField] LayerMask groundMask;
    [SerializeField] float runSpeed = 6f;
    [SerializeField] float jumpSpeed = 12f;
    [SerializeField] float groundCheckDistance = 0.15f;

    Rigidbody2D body;
    Animator animator;
    SpriteRenderer spriteRenderer;

    float moveInput;            // -1 left, 0 still, 1 right
    bool isGrounded;
    bool isFacingLeft;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        isGrounded = CheckGround();
        bool isJumpPressed = false;

        moveInput = 0f;

        // The keyboard. A phone may have no keyboard, and then Keyboard.current is null.
        Keyboard keyboard = Keyboard.current;
        if (keyboard != null)
        {
            if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed)
            {
                moveInput -= 1f;
            }
            if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed)
            {
                moveInput += 1f;
            }
            if (keyboard.spaceKey.wasPressedThisFrame || keyboard.wKey.wasPressedThisFrame || keyboard.upArrowKey.wasPressedThisFrame)
            {
                isJumpPressed = true;
            }
        }

        if (moveInput != 0f)
        {
            isFacingLeft = moveInput < 0f;
            spriteRenderer.flipX = isFacingLeft;
        }
        if (isJumpPressed && isGrounded)
        {
            Jump();
        }

        // Run. A velocity is safe to set in Update: the Rigidbody keeps it
        // until the next physics step uses it.
        body.linearVelocity = new Vector2(moveInput * runSpeed, body.linearVelocity.y);

        animator.SetFloat(SpeedHash, Mathf.Abs(body.linearVelocity.x));
        animator.SetFloat(VerticalSpeedHash, body.linearVelocity.y);
        animator.SetBool(GroundedHash, isGrounded);
    }

    // Two short rays down from his feet, against the Ground layer only.
    // Moving up is never standing: that's a jump just starting.
    bool CheckGround()
    {
        if (body.linearVelocity.y > 0.01f)
        {
            return false;
        }
        RaycastHit2D left = Physics2D.Raycast(leftFoot.position, Vector2.down, groundCheckDistance, groundMask);
        RaycastHit2D right = Physics2D.Raycast(rightFoot.position, Vector2.down, groundCheckDistance, groundMask);
        return left.collider != null || right.collider != null;
    }

    void Jump()
    {
        body.linearVelocity = new Vector2(body.linearVelocity.x, jumpSpeed);
        isGrounded = false;
    }
}
```

Read it before you move on:

- The three `static readonly int` fields turn each parameter's name into a number once
  ({{ref:animcode}}). The names must match the Animator's exactly: `Speed`, not `speed`.
- The last three lines of `Update` tell the Animator what the knight is doing, every
  frame. The script never chooses a clip; the transitions do.
- `Mathf.Abs` makes the speed positive both ways: running left is a negative velocity,
  and `Speed > 0.1` must be true for it too.
- The Animator is on the same GameObject, so `GetComponent` finds it in `Awake`.

### Test it

Press **Play** with the Animator window open and `Knight` selected in the Hierarchy. The
blue bar under a state shows where the machine is.

- Run: Idle → Run. Let go: Run → Idle, at once.
- Jump: Jump on the way up, Fall on the way down, then Idle.
- Walk off the tall block: straight into Fall.
- Watch the **Parameters** tab: `Speed` and `VerticalSpeed` change all the time, and
  `Grounded` ticks and unticks.

If a change comes late, look for a transition with **Has Exit Time** still on. If one
never comes, compare the parameter names in the script with the Parameters tab, and read
the Console.

### Challenge

Turn **Has Exit Time** on for Run → Idle, play, and stop running in the middle of the
run clip: feel how late the knight stops. Turn it off again. Then untick `Grounded`'s
default box and play: what does the knight do on the very first frame, and why?

# Part 2 — Roll and Slimes

{{concept:animevents}}

## Chapter 5 — The Roll

**Goal:** **Shift** or **J** rolls the knight forwards, faster than he runs. A trigger
starts the roll from wherever he is, the clip plays once and goes back to Idle by itself,
and an Animation Event on its last frame hands control back to the player. A second
event, on the run, marks every footstep.

### Idea — a roll is a trigger

A roll happens once per press, so it's a **Trigger**. The knight can start one while
idling or while running, so the transition comes from **Any State**. The Roll clip must
finish before he gets up, so the way out has **Has Exit Time** on:

```
   Any State ── Roll (Trigger) ──→ Roll ── (Has Exit Time: the clip's end) ──→ Idle
```

| Transition | Has Exit Time | Conditions | Also |
| --- | --- | --- | --- |
| Any State → Roll | off | `Roll` | **Can Transition To Self** off |
| Roll → Idle | **on**, Exit Time `1` | none | |

**Can Transition To Self** must be off: with it on, a second press during a roll would
start the clip again from its first frame, over and over.

### Idea — who knows when the roll ends?

While he rolls, the script moves the knight at 9 units a second, and ignores the keys.
So the script must know when the roll is over. The clip knows best: its last frame *is*
the end. An Animation Event there calls `OnRollFinished`, which gives control back and
starts a short wait, 0.4 seconds, before the next roll.

That keeps the code and the art together. Speed the clip up, and the roll in code gets
shorter by itself. With a timer in code, you'd have to change two numbers, and remember
to.

### Idea — footsteps

The run has four footsteps in its 16 frames: frames 2, 6, 10 and 14, where his feet come
together on the ground. An event on each calls `OnFootstep`. For now it prints `Step` in
the Console; Chapter 13 makes it a sound.

### Do it — the trigger and the transitions

With the knight selected, in the Animator window:

1. On the **Parameters** tab, add a **Trigger**, `Roll`.
2. Right-click **Any State** → **Make Transition**, and click **Roll**. Untick **Has
   Exit Time**; in **Settings**, set **Transition Duration** to `0` and untick **Can
   Transition To Self**; add the condition `Roll`.
3. Make a transition from **Roll** to **Idle**. Leave **Has Exit Time** on, with **Exit
   Time** `1`; set **Transition Duration** to `0`; add no conditions.

### Do it — the script

Replace `KnightController` with this version:

```csharp
using UnityEngine;
using UnityEngine.InputSystem;

// The knight: he runs, jumps and rolls with the keyboard, and tells his
// Animator what he's doing every frame.
[RequireComponent(typeof(Rigidbody2D))]
public class KnightController : MonoBehaviour
{
    // The Animator's parameters, turned into numbers once. Strings are slow to
    // look up, and a typo in a hash's name is easy to spot: it's written once.
    static readonly int SpeedHash = Animator.StringToHash("Speed");
    static readonly int VerticalSpeedHash = Animator.StringToHash("VerticalSpeed");
    static readonly int GroundedHash = Animator.StringToHash("Grounded");
    static readonly int RollHash = Animator.StringToHash("Roll");

    [SerializeField] Transform leftFoot;
    [SerializeField] Transform rightFoot;
    [SerializeField] LayerMask groundMask;
    [SerializeField] float runSpeed = 6f;
    [SerializeField] float jumpSpeed = 12f;
    [SerializeField] float rollSpeed = 9f;
    [SerializeField] float rollCooldown = 0.4f;     // seconds from the end of one roll to the next
    [SerializeField] float groundCheckDistance = 0.15f;

    Rigidbody2D body;
    Animator animator;
    SpriteRenderer spriteRenderer;

    float moveInput;            // -1 left, 0 still, 1 right
    bool isGrounded;
    bool isFacingLeft;
    bool isRolling;
    float rollDirection;
    float nextRollTime;

    public bool IsRolling
    {
        get { return isRolling; }
    }

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        isGrounded = CheckGround();
        bool isJumpPressed = false;
        bool isRollPressed = false;

        moveInput = 0f;

        // The keyboard. A phone may have no keyboard, and then Keyboard.current is null.
        Keyboard keyboard = Keyboard.current;
        if (keyboard != null)
        {
            if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed)
            {
                moveInput -= 1f;
            }
            if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed)
            {
                moveInput += 1f;
            }
            if (keyboard.spaceKey.wasPressedThisFrame || keyboard.wKey.wasPressedThisFrame || keyboard.upArrowKey.wasPressedThisFrame)
            {
                isJumpPressed = true;
            }
            if (keyboard.leftShiftKey.wasPressedThisFrame || keyboard.rightShiftKey.wasPressedThisFrame || keyboard.jKey.wasPressedThisFrame)
            {
                isRollPressed = true;
            }
        }

        if (moveInput != 0f && !isRolling)
        {
            isFacingLeft = moveInput < 0f;
            spriteRenderer.flipX = isFacingLeft;
        }
        if (isJumpPressed && isGrounded && !isRolling)
        {
            Jump();
        }
        if (isRollPressed && isGrounded && !isRolling && Time.time >= nextRollTime)
        {
            StartRoll();
        }

        // Run, or roll. A velocity is safe to set in Update: the Rigidbody
        // keeps it until the next physics step uses it.
        float speedX = moveInput * runSpeed;
        if (isRolling)
        {
            speedX = rollDirection * rollSpeed;
        }
        body.linearVelocity = new Vector2(speedX, body.linearVelocity.y);

        animator.SetFloat(SpeedHash, Mathf.Abs(body.linearVelocity.x));
        animator.SetFloat(VerticalSpeedHash, body.linearVelocity.y);
        animator.SetBool(GroundedHash, isGrounded);
    }

    // Two short rays down from his feet, against the Ground layer only.
    // Moving up is never standing: that's a jump just starting.
    bool CheckGround()
    {
        if (body.linearVelocity.y > 0.01f)
        {
            return false;
        }
        RaycastHit2D left = Physics2D.Raycast(leftFoot.position, Vector2.down, groundCheckDistance, groundMask);
        RaycastHit2D right = Physics2D.Raycast(rightFoot.position, Vector2.down, groundCheckDistance, groundMask);
        return left.collider != null || right.collider != null;
    }

    void Jump()
    {
        body.linearVelocity = new Vector2(body.linearVelocity.x, jumpSpeed);
        isGrounded = false;
    }

    void StartRoll()
    {
        isRolling = true;
        rollDirection = isFacingLeft ? -1f : 1f;
        animator.SetTrigger(RollHash);
    }

    // Animation Event: on each frame of the Run clip where a foot lands.
    public void OnFootstep()
    {
        Debug.Log("Step");
    }

    // Animation Event: on the last frame of the Roll clip.
    public void OnRollFinished()
    {
        isRolling = false;
        nextRollTime = Time.time + rollCooldown;
    }
}
```

Read it before you move on:

- **Shift** (either one) or **J** sets `isRollPressed`, on one frame per press.
- A roll can only start on the ground, when he isn't rolling already, and when
  `Time.time` has reached `nextRollTime`.
- `StartRoll` remembers the direction he faces, and fires the trigger. The Animator does
  the rest: Any State → Roll.
- While `isRolling` is true, he doesn't turn or jump, and his speed across is the roll's.
- `OnFootstep` and `OnRollFinished` are `public`, and their names start with `On`: they
  are called by Animation Events ({{ref:naming}}). Nothing in the script calls them.
- `IsRolling` lets other scripts ask whether he's rolling, without being able to change
  it. Chapter 7 needs that.

### Do it — the two events

1. In the Animation window, with the knight selected, pick **Knight Roll**. Move the
   playhead to its last frame, `0:7`. Click **Add Event**. In the Inspector, set
   **Function** to **OnRollFinished**.
2. Pick **Knight Run**. Add an event at `0:2`, `0:6`, `0:10` and `0:14`, and set each
   one's **Function** to **OnFootstep**.

The Function list shows the methods of the knight's scripts. If `OnRollFinished` isn't
there, save the script and let Unity compile it first.

### Test it

1. Press **Play**, run, and press **Shift**: the knight rolls about five units forwards,
   then stands up. Roll from standing still: he rolls the way he faces.
2. Hold **Shift**: one roll, a short pause, then no more until you press again.
3. Try to jump or turn in mid-roll: you can't.
4. Watch the Console while he runs: `Step`, four times a second.
5. Now break it on purpose. Rename `OnRollFinished` to `OnRollEnded` in the script,
   save, play and roll. The Console shows:

   ```
   'Knight' AnimationEvent 'OnRollFinished' on animation 'Knight Roll' has no receiver! Are you missing a component?
   ```

   And the knight rolls on, for ever: `isRolling` never becomes false. An event's
   method name is part of your code, even though it's typed in the Animation window.
   Put the name back.

### Challenge

Select the **Roll** state in the Animator window, and set its **Speed** to `1.5`: the
clip plays half as fast again, so the roll is quicker and shorter. Does
`KnightController` need any change? Why not? Then set it back to `1`.

{{concept:statemachines}}

{{concept:enemies}}

## Chapter 6 — The Slime

**Goal:** a slime that patrols its patch of ground, chases the knight when he comes near,
squashes down, and leaps at him. Its states are an `enum` in its script, and its
Animator follows the script through an Int.

### Idea — the slime's states

```
                knight near                   in range, on the ground
   Patrol ──────────────────→ Chase ──────────────────────────────→ WindUp
     ↑                          │ ↑                                    │
     └────── knight gone ───────┘ └── lands ── Leap ←── OnLeap ────────┘
                                                      (Animation Event)
```

| State | Does | Leaves when… |
| --- | --- | --- |
| **Patrol** | moves back and forth, up to 2 units from where it started; turns at either end, and at an edge | the knight is within 4 units across and 1.5 up or down: **Chase** |
| **Chase** | moves towards the knight, faster, but never off an edge | he's within 1.2 units, and the slime is on the ground with ground ahead: **WindUp**. He's more than 6 away: **Patrol** |
| **WindUp** | stops, and squashes down | its clip's last frame calls `OnLeap`: **Leap** |
| **Leap** | flies at the knight | it lands again: **Chase** |
| **Hurt**, **Dead** | Chapter 7 | |

Chase starts at 4 units and gives up at 6: with one number for both, a knight standing
right at the edge would make the slime flip between the two states every frame.

### Idea — the Animator follows the code

The slime's states are decisions, so the script decides, and the Animator plays whatever
the script says ({{ref:enemies}}). The controller has one **Int** parameter, `State`, and
each state has an **Any State** transition on `State` Equals its number:

| `State` | Patrol | Chase | WindUp | Leap | Hurt | Dead |
| --- | --- | --- | --- | --- | --- | --- |
| `(int)` | 0 | 1 | 2 | 3 | 4 | 5 |

Patrol and Chase play the same clip, **Slime Move**: the Chase state plays it at
**Speed** `1.6`, so a chasing slime wobbles faster.

### Idea — the slime's sprites

`slime_green.png` holds twelve frames, 24 pixels square: frames 0 to 3 rise from a puddle
into a slime, 4 to 7 wobble along, and 8 to 11 are a hit, with a red flash. Played
backwards, the rising frames squash the slime down: that's its wind-up, and in Chapter 7
its death.

### Do it — the sprites

Give `slime_green` and `slime_purple` the pixel-art settings, and **Apply**. Slice each
with **Grid By Cell Size**, `24` × `24`, **Pivot** **Bottom**. The slimes stand on
their pivot, at the bottom of the frame.

### Do it — the slime

1. Drag `slime_green_4` into the Hierarchy. Rename it `Slime`, set its **Position** to
   `(28.5, 0, 0)`, its **Order in Layer** to `2`, and its **Layer** to **Enemy**.
2. **Add Component → Rigidbody 2D**: **Gravity Scale** `3`, **Interpolate**
   **Interpolate**, and tick **Freeze Rotation Z**.
3. **Add Component → Box Collider 2D**: **Size** `(0.8, 0.65)`, **Offset**
   `(0, 0.325)`.
4. **Edit → Project Settings → Physics 2D**, open **Layer Collision Matrix**, and untick
   the box where **Enemy** meets **Enemy**: slimes pass through each other.

### Do it — the clips

Select `Slime`, and in the Animation window click **Create**: save
`Assets/Animation/Slime Move.anim`. Unity adds an Animator and makes `Slime.controller`.

| Clip | Frames | Samples | Loop Time |
| --- | --- | --- | --- |
| `Slime Move` | `slime_green_4` to `slime_green_7` | 8 | on |
| `Slime WindUp` | `slime_green_3`, `slime_green_2`, `slime_green_1`, in that order | 8 | **off** |
| `Slime Leap` | `slime_green_6`, stretched tall | 8 | on |

Dragging several sprites at once puts them in name order. For **Slime WindUp**, which
runs backwards, drag the three sprites one at a time: `slime_green_3` to `0:0`,
`slime_green_2` to `0:1`, `slime_green_1` to `0:2`.

### Do it — the Animator

In the Animator window, with `Slime` selected:

1. Rename the states: **Slime Move** to `Patrol`, **Slime WindUp** to `WindUp`, **Slime
   Leap** to `Leap`.
2. Right-click the empty grid → **Create State → Empty**. Name it `Chase`, set its
   **Motion** to **Slime Move**, and its **Speed** to `1.6`.
3. Check that **Patrol** is orange, the default. If not, right-click it → **Set as Layer
   Default State**.
4. On the **Parameters** tab, add an **Int**, `State`.
5. For each of the four states, make a transition from **Any State**: **Has Exit Time**
   off, **Transition Duration** `0`, **Can Transition To Self** off, and the condition
   `State` **Equals** its number: Patrol `0`, Chase `1`, WindUp `2`, Leap `3`.

### Do it — the script

Create `Slime` and attach it to the slime:

```csharp
using UnityEngine;

// A slime, run as a state machine. Each state's enter step tells the Animator
// which state it's in, through the State parameter, so the Animator follows
// the code. For now it patrols, chases and leaps: Chapter 7 adds Hurt and Dead.
[RequireComponent(typeof(Rigidbody2D))]
public class Slime : MonoBehaviour
{
    public enum State { Patrol, Chase, WindUp, Leap, Hurt, Dead }

    static readonly int StateHash = Animator.StringToHash("State");

    [SerializeField] Transform knight;
    [SerializeField] LayerMask groundMask;
    [SerializeField] float patrolSpeed = 1.5f;
    [SerializeField] float patrolDistance = 2f;     // how far it wanders from where it started, each way
    [SerializeField] float chaseSpeed = 2.5f;
    [SerializeField] float sightRange = 4f;
    [SerializeField] float leapRange = 1.2f;
    [SerializeField] Vector2 leapVelocity = new Vector2(4f, 6f);

    Rigidbody2D body;
    Animator animator;
    SpriteRenderer spriteRenderer;
    Vector2 startPosition;
    State state;
    float direction = -1f;      // -1 left, 1 right
    float stateStartTime;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        startPosition = transform.position;
    }

    void Start()
    {
        EnterState(State.Patrol);
    }

    void Update()
    {
        switch (state)
        {
            case State.Patrol:
                UpdatePatrol();
                break;
            case State.Chase:
                UpdateChase();
                break;
            case State.WindUp:
                break;                  // waits for the OnLeap Animation Event
            case State.Leap:
                UpdateLeap();
                break;
            case State.Hurt:
                break;                  // Chapter 7
            case State.Dead:
                break;                  // Chapter 7
        }

        // The slime's picture looks left, so it flips to look right.
        spriteRenderer.flipX = direction > 0f;
    }

    // The one place the state changes. The enter step runs once, as the
    // slime arrives in its new state.
    void EnterState(State next)
    {
        state = next;
        stateStartTime = Time.time;
        animator.SetInteger(StateHash, (int)state);

        switch (state)
        {
            case State.Patrol:
                break;
            case State.Chase:
                break;
            case State.WindUp:
                Stop();
                break;
            case State.Leap:
                body.linearVelocity = new Vector2(direction * leapVelocity.x, leapVelocity.y);
                break;
            case State.Hurt:
                break;
            case State.Dead:
                break;
        }
    }

    void UpdatePatrol()
    {
        if (CanSeeKnight(sightRange))
        {
            EnterState(State.Chase);
            return;
        }

        // Turn round at either end of its patch of ground, or at an edge.
        bool isPastRight = direction > 0f && transform.position.x > startPosition.x + patrolDistance;
        bool isPastLeft = direction < 0f && transform.position.x < startPosition.x - patrolDistance;
        if (isPastRight || isPastLeft || !HasGroundAhead())
        {
            direction = -direction;
        }
        Move(patrolSpeed);
    }

    void UpdateChase()
    {
        // It gives up once the knight is well away.
        if (!CanSeeKnight(sightRange * 1.5f))
        {
            EnterState(State.Patrol);
            return;
        }

        float toKnight = knight.position.x - transform.position.x;
        direction = toKnight < 0f ? -1f : 1f;

        if (Mathf.Abs(toKnight) <= leapRange && IsGrounded() && HasGroundAhead())
        {
            EnterState(State.WindUp);
        }
        else if (HasGroundAhead())
        {
            Move(chaseSpeed);
        }
        else
        {
            Stop();     // it never chases him off a ledge
        }
    }

    void UpdateLeap()
    {
        // Landed: a moment after take-off, it's standing on the ground again.
        if (Time.time > stateStartTime + 0.2f && IsGrounded())
        {
            EnterState(State.Chase);
        }
    }

    // Animation Event: on the last frame of the WindUp clip.
    public void OnLeap()
    {
        // A stomp during the wind-up changes the state first: then there's no leap.
        if (state == State.WindUp)
        {
            EnterState(State.Leap);
        }
    }

    bool CanSeeKnight(float range)
    {
        Vector2 toKnight = knight.position - transform.position;
        return Mathf.Abs(toKnight.x) < range && Mathf.Abs(toKnight.y) < 1.5f;
    }

    bool IsGrounded()
    {
        Vector2 start = (Vector2)transform.position + new Vector2(0f, 0.1f);
        return Physics2D.Raycast(start, Vector2.down, 0.2f, groundMask).collider != null;
    }

    // Is there ground half a tile ahead, in the direction it's going?
    bool HasGroundAhead()
    {
        Vector2 start = (Vector2)transform.position + new Vector2(direction * 0.5f, 0.1f);
        return Physics2D.Raycast(start, Vector2.down, 0.6f, groundMask).collider != null;
    }

    void Move(float speed)
    {
        body.linearVelocity = new Vector2(direction * speed, body.linearVelocity.y);
    }

    void Stop()
    {
        body.linearVelocity = new Vector2(0f, body.linearVelocity.y);
    }
}
```

In its Inspector, drag `Knight` into **Knight**, and set **Ground Mask** to **Ground**.

Read it before you move on:

- `enum State` lists all six states, even the two that do nothing until Chapter 7: their
  numbers must match the Animator's from the start ({{ref:enemies}}).
- `EnterState` is the only place `state` changes. Its first lines run for every state:
  remember the time, and tell the Animator with `SetInteger`. Then a `switch` does each
  state's own enter step: WindUp stops the slime; Leap throws it.
- The `switch` in `Update` runs the current state's work, every frame. WindUp's case is
  empty: it waits for the Animation Event.
- `OnLeap` checks that the slime is still winding up. Chapter 7 gives a reason why it
  might not be.
- `HasGroundAhead` shoots a ray down from half a tile in front of the slime. No ground
  there means an edge: turn round on patrol, stop in a chase.
- The picture faces left, so `flipX` turns it to face right when `direction` is
  positive.

### Do it — the leap's event

In the Animation window, with `Slime` selected, pick **Slime WindUp**, move the playhead
to its last frame, `0:2`, and **Add Event** with the **Function** **OnLeap**.

### Do it — three slimes

1. Drag `Slime` from the Hierarchy into `Assets/Prefabs`.
2. Place two more: drag the prefab into the scene twice, at `(43.5, 0, 0)` and
   `(49.5, 0, 0)`: the `s` marks on the Meadow's map.
3. A prefab can't remember a GameObject in the scene, so the new slimes' **Knight**
   field is empty. Select all three slimes in the Hierarchy (click the first,
   Ctrl-click the others, Cmd-click on a Mac) and drag `Knight` into **Knight** once:
   it fills the field on all three.

### Test it

1. Press **Play**. The slimes wobble back and forth along their patches.
2. Walk towards one: it turns to you and wobbles faster. Stand still near it: it
   squashes down, and leaps at you. It bumps into you, and nothing else happens yet.
3. Run away: it gives up and patrols again.
4. Select a slime while it plays, and watch its Animator: `State` changes, and the blue
   bar jumps to the matching state each time.

### Challenge

Add a `Debug.Log` to `EnterState` that prints the slime's name and its new state, then
walk past all three slimes. Read the Console like a story: can you tell which slime saw
you first?

## Chapter 7 — Stomp, Hurt and Pits

**Goal:** the knight has 5 health. A slime that bumps into him knocks him back and makes
him blink, and nothing can hurt him while he blinks. Landing on a slime stomps it, and
rolling into one knocks it over: a green slime takes one hit, melts and fades away.
Falling into water costs 1 health and sends him back to the start, and at 0 health he
falls over and fades.

### Idea — one place decides what a bump means

When the knight and a slime touch, three things can happen, and one script, on the
knight, decides which:

| If… | then… |
| --- | --- |
| he came down **on top** of the slime | a **stomp**: the slime is hit, and he bounces up |
| he's **rolling** | the slime is hit, and he rolls on |
| neither | **he** is hurt |

How does a script know he came down on top? Every collision has **contact points**, and
each has a **normal**: an arrow pointing out of the other collider, towards this one.
Seen from the knight, a slime under his feet pushes him **up**: the normal's `y` is
close to 1. A slime beside him pushes him sideways: its `y` is close to 0.

```
        knight                         knight → ← slime
          ↑  normal (0, 1): a stomp            normal (-1, 0): a bump
        slime
```

`OnCollisionEnter2D` runs on the first moment two colliders touch;
`OnCollisionStay2D` runs on every physics step while they keep touching. The script
uses both, so that a slime still touching the knight when his blinking ends hurts him
again.

### Idea — hurt, blink, and back on your feet

| When hurt, the knight… | For |
| --- | --- |
| loses 1 health | |
| is knocked back, up and away from the slime: a velocity of (5, 6) | |
| can't be steered (he's **stunned**) | 0.25 s |
| plays the **Hurt** clip, through a `Hurt` trigger | 0.4 s |
| blinks, and can't be hurt again | 1 s |

At 0 health he plays **Dead**, through a `Dead` trigger, and the Dead clip's last moment
calls `OnDeathFinished`. For now that prints `The knight has fallen`; Chapter 11 shows
the Try Again panel there.

### Idea — the slime's Hurt and Dead

`TakeHit` takes a health point from the slime and sends it to **Hurt**: its red flash,
and a little knockback. After 0.4 seconds it goes back to **Chase**, or, with no health
left, to **Dead**. A dead slime switches its collider and its physics off, melts into a
puddle (the rising frames, backwards), fades, and its clip's end calls
`OnDeathFinished`, which hides it. A hurt or dead slime is **harmless**: it can't hurt
the knight, and can't be hit again.

Now that slimes need to know whether the knight is dead (no chasing a fallen knight),
the slime's `knight` field changes type: from `Transform` to `KnightHealth`.

### Idea — falling in

A `KillZone` script on the **Hazards** Tilemap (and on a long strip under the whole
level, to catch anything that falls past) sends the knight back to a start point, and
takes 1 health.

Sending him back is `ResetKnight`'s job, and it has two traps in it, both explained in
its comments:

- If he falls in mid-roll, the Roll clip is cut short, and `OnRollFinished` never comes.
  So `ResetKnight` sets `isRolling` to false itself.
- `animator.Rebind()` puts the Animator back in Idle. But the Dead clip fades the sprite
  out, and `Rebind` remembers the colour the sprite has *now* as the one to go back to.
  So the colour is set back to white first ({{ref:animcode}}).

### Do it — the knight's Hurt and Dead

In the Animator window, with the knight selected:

1. Add two **Triggers**, `Hurt` and `Dead`.
2. From **Any State**, make a transition to **Hurt** and one to **Dead**, each with **Has
   Exit Time** off, **Transition Duration** `0`, **Can Transition To Self** off, and the
   trigger of the same name as its condition.
3. Make a transition from **Hurt** to **Idle**, with **Has Exit Time** on, **Exit
   Time** `1` and **Transition Duration** `0`.

**Dead** gets no way out: a fallen knight stays down. Chapter 11's Restart brings him
back, with `Rebind`.

### Do it — the knight's health

Create `KnightHealth`, and attach it to `Knight`:

```csharp
using System.Collections;
using UnityEngine;

// The knight's health: 5 to start with. A slime knocks him back and makes him
// blink, and nothing can hurt him while he blinks. At 0 he falls, and when his
// Dead clip ends, the game is lost.
public class KnightHealth : MonoBehaviour
{
    public const int MaxHealth = 5;

    static readonly int HurtHash = Animator.StringToHash("Hurt");
    static readonly int DeadHash = Animator.StringToHash("Dead");

    [SerializeField] Vector2 knockback = new Vector2(5f, 6f);
    [SerializeField] float stunSeconds = 0.25f;     // no control, while the knockback carries him
    [SerializeField] float blinkSeconds = 1f;

    Rigidbody2D body;
    Animator animator;
    SpriteRenderer spriteRenderer;
    KnightController controller;
    bool isBlinking;
    float stunnedUntil;

    public int Health { get; private set; } = MaxHealth;
    public bool IsDead { get; private set; }

    public bool IsStunned
    {
        get { return Time.time < stunnedUntil; }
    }

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        controller = GetComponent<KnightController>();
    }

    // A slime hurt him. fromX is where the slime is, so he flies away from it.
    public void TakeDamage(int amount, float fromX)
    {
        // Nothing hurts him while he blinks or rolls, and a fallen knight
        // can't fall again.
        if (IsDead || isBlinking || controller.IsRolling)
        {
            return;
        }

        LoseHealth(amount);
        if (IsDead)
        {
            return;
        }

        float direction = transform.position.x < fromX ? -1f : 1f;
        body.linearVelocity = new Vector2(knockback.x * direction, knockback.y);
        stunnedUntil = Time.time + stunSeconds;
        animator.SetTrigger(HurtHash);
    }

    // He fell into water, goo or the moat. The game has already put him back
    // at the last checkpoint.
    public void FellInPit()
    {
        if (!IsDead)
        {
            LoseHealth(1);
        }
    }

    void LoseHealth(int amount)
    {
        Health = Mathf.Max(Health - amount, 0);
        Debug.Log($"Health: {Health}");

        if (Health == 0)
        {
            IsDead = true;
            body.linearVelocity = new Vector2(0f, body.linearVelocity.y);
            animator.SetTrigger(DeadHash);
        }
        else
        {
            StartCoroutine(Blink());
        }
    }

    IEnumerator Blink()
    {
        isBlinking = true;
        float endTime = Time.time + blinkSeconds;
        while (Time.time < endTime)
        {
            spriteRenderer.enabled = !spriteRenderer.enabled;
            yield return new WaitForSeconds(0.1f);
        }
        spriteRenderer.enabled = true;
        isBlinking = false;
    }

    // Animation Event: at the end of the Dead clip, once he has faded out.
    public void OnDeathFinished()
    {
        Debug.Log("The knight has fallen");
    }
}
```

Read it before you move on:

- `MaxHealth` is a `public const`: other scripts will read it as
  `KnightHealth.MaxHealth`.
- `Health` and `IsDead` are properties with a `private set`: any script can read them,
  only this one can change them.
- `IsStunned` works its answer out each time: is it still before `stunnedUntil`?
- `TakeDamage` does nothing while he blinks or rolls, or once he's dead. The knockback
  goes away from `fromX`, where the slime is.
- `LoseHealth` is shared by slimes and pits. At 0 he dies; otherwise he blinks.
- `Blink` is a coroutine: it switches the sprite off and on every 0.1 seconds for a
  second.

### Do it — the knight's controller

Replace `KnightController` with this version:

```csharp
using UnityEngine;
using UnityEngine.InputSystem;

// The knight: he runs, jumps and rolls with the keyboard, and tells his
// Animator what he's doing every frame.
[RequireComponent(typeof(Rigidbody2D))]
public class KnightController : MonoBehaviour
{
    // The Animator's parameters, turned into numbers once. Strings are slow to
    // look up, and a typo in a hash's name is easy to spot: it's written once.
    static readonly int SpeedHash = Animator.StringToHash("Speed");
    static readonly int VerticalSpeedHash = Animator.StringToHash("VerticalSpeed");
    static readonly int GroundedHash = Animator.StringToHash("Grounded");
    static readonly int RollHash = Animator.StringToHash("Roll");

    [SerializeField] Transform leftFoot;
    [SerializeField] Transform rightFoot;
    [SerializeField] LayerMask groundMask;
    [SerializeField] float runSpeed = 6f;
    [SerializeField] float jumpSpeed = 12f;
    [SerializeField] float rollSpeed = 9f;
    [SerializeField] float rollCooldown = 0.4f;     // seconds from the end of one roll to the next
    [SerializeField] float bounceSpeed = 9f;        // how high a stomp throws him
    [SerializeField] float groundCheckDistance = 0.15f;

    Rigidbody2D body;
    Animator animator;
    SpriteRenderer spriteRenderer;
    KnightHealth health;

    float moveInput;            // -1 left, 0 still, 1 right
    bool isGrounded;
    bool isFacingLeft;
    bool isRolling;
    float rollDirection;
    float nextRollTime;

    public bool IsRolling
    {
        get { return isRolling; }
    }

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        health = GetComponent<KnightHealth>();
    }

    void Update()
    {
        isGrounded = CheckGround();
        bool isJumpPressed = false;
        bool isRollPressed = false;

        moveInput = 0f;

        // The keyboard. A phone may have no keyboard, and then Keyboard.current is null.
        Keyboard keyboard = Keyboard.current;
        if (keyboard != null)
        {
            if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed)
            {
                moveInput -= 1f;
            }
            if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed)
            {
                moveInput += 1f;
            }
            if (keyboard.spaceKey.wasPressedThisFrame || keyboard.wKey.wasPressedThisFrame || keyboard.upArrowKey.wasPressedThisFrame)
            {
                isJumpPressed = true;
            }
            if (keyboard.leftShiftKey.wasPressedThisFrame || keyboard.rightShiftKey.wasPressedThisFrame || keyboard.jKey.wasPressedThisFrame)
            {
                isRollPressed = true;
            }
        }

        if (HasControl())
        {
            if (moveInput != 0f && !isRolling)
            {
                isFacingLeft = moveInput < 0f;
                spriteRenderer.flipX = isFacingLeft;
            }
            if (isJumpPressed && isGrounded && !isRolling)
            {
                Jump();
            }
            if (isRollPressed && isGrounded && !isRolling && Time.time >= nextRollTime)
            {
                StartRoll();
            }
        }
        else
        {
            moveInput = 0f;
        }

        // Run, or roll. While he's stunned, the knockback carries him instead.
        // A velocity is safe to set in Update: the Rigidbody keeps it until the
        // next physics step uses it.
        if (!health.IsStunned)
        {
            float speedX = moveInput * runSpeed;
            if (isRolling)
            {
                speedX = rollDirection * rollSpeed;
            }
            body.linearVelocity = new Vector2(speedX, body.linearVelocity.y);
        }

        animator.SetFloat(SpeedHash, Mathf.Abs(body.linearVelocity.x));
        animator.SetFloat(VerticalSpeedHash, body.linearVelocity.y);
        animator.SetBool(GroundedHash, isGrounded);
    }

    bool HasControl()
    {
        return !health.IsDead && !health.IsStunned;
    }

    // Two short rays down from his feet, against the Ground layer only.
    // Moving up is never standing: that's a jump just starting.
    bool CheckGround()
    {
        if (body.linearVelocity.y > 0.01f)
        {
            return false;
        }
        RaycastHit2D left = Physics2D.Raycast(leftFoot.position, Vector2.down, groundCheckDistance, groundMask);
        RaycastHit2D right = Physics2D.Raycast(rightFoot.position, Vector2.down, groundCheckDistance, groundMask);
        return left.collider != null || right.collider != null;
    }

    void Jump()
    {
        body.linearVelocity = new Vector2(body.linearVelocity.x, jumpSpeed);
        isGrounded = false;
    }

    void StartRoll()
    {
        isRolling = true;
        rollDirection = isFacingLeft ? -1f : 1f;
        animator.SetTrigger(RollHash);
    }

    // A stomp throws him back up off the slime.
    public void Bounce()
    {
        body.linearVelocity = new Vector2(body.linearVelocity.x, bounceSpeed);
    }

    // Animation Event: on each frame of the Run clip where a foot lands.
    public void OnFootstep()
    {
        Debug.Log("Step");
    }

    // Animation Event: on the last frame of the Roll clip.
    public void OnRollFinished()
    {
        isRolling = false;
        nextRollTime = Time.time + rollCooldown;
    }

    // Back to a starting point, standing still and facing right: after a fall,
    // and on Restart.
    public void ResetKnight(Vector2 position)
    {
        body.position = position;
        transform.position = position;
        body.linearVelocity = Vector2.zero;

        // A fall can cut the Roll clip short, and then OnRollFinished never
        // comes. So the reset ends the roll itself.
        isRolling = false;
        nextRollTime = 0f;
        isFacingLeft = false;
        spriteRenderer.flipX = false;

        // The Dead clip fades him out. Put his colour back first: Rebind
        // remembers the colour he has now as the one to go back to.
        spriteRenderer.color = Color.white;
        animator.Rebind();
    }
}
```

Read it before you move on:

- `HasControl` is false while he's dead or stunned: then the keys are ignored.
- While he's stunned, the script doesn't set his velocity at all: the knockback carries
  him.
- `Bounce` throws him up after a stomp.
- `ResetKnight` puts him at a position, still and facing right, ends any roll, and
  rebinds the Animator.

### Do it — the slime's Hurt and Dead

1. Select `Slime` in the Hierarchy, and make two more clips:

| Clip | Frames | Samples | Loop Time |
| --- | --- | --- | --- |
| `Slime Hurt` | `slime_green_8` to `slime_green_11` | 10 | off |
| `Slime Dead` | `slime_green_3`, `2`, `1` and `0`, one at a time | 8 | off |

2. Give **Slime Dead** a fade, as you did for the knight: a **Color** curve, with **A**
   `1` at `0:4` and **A** `0` at `1:0`.
3. In the slime's Animator, rename the new states `Hurt` and `Dead`, and make **Any
   State** transitions to them with the same settings as the others, on `State`
   **Equals** `4` and `5`.
4. Replace `Slime` with this version:

```csharp
using UnityEngine;

// A slime, run as a state machine. Each state's enter step tells the Animator
// which state it's in, through the State parameter, so the Animator follows
// the code. The purple slime is this same script, with other numbers.
[RequireComponent(typeof(Rigidbody2D))]
public class Slime : MonoBehaviour
{
    public enum State { Patrol, Chase, WindUp, Leap, Hurt, Dead }

    static readonly int StateHash = Animator.StringToHash("State");

    [SerializeField] KnightHealth knight;
    [SerializeField] LayerMask groundMask;
    [SerializeField] int maxHealth = 1;
    [SerializeField] float patrolSpeed = 1.5f;
    [SerializeField] float patrolDistance = 2f;     // how far it wanders from where it started, each way
    [SerializeField] float chaseSpeed = 2.5f;
    [SerializeField] float sightRange = 4f;
    [SerializeField] float leapRange = 1.2f;
    [SerializeField] Vector2 leapVelocity = new Vector2(4f, 6f);
    [SerializeField] Vector2 knockback = new Vector2(3f, 3f);
    [SerializeField] float hurtSeconds = 0.4f;

    Rigidbody2D body;
    Animator animator;
    SpriteRenderer spriteRenderer;
    Collider2D slimeCollider;
    Vector2 startPosition;
    State state;
    int health;
    float direction = -1f;      // -1 left, 1 right
    float stateStartTime;

    // A hurt or dead slime can't hurt the knight, and can't be hit again.
    public bool IsHarmless
    {
        get { return state == State.Hurt || state == State.Dead; }
    }

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        slimeCollider = GetComponent<Collider2D>();
        startPosition = transform.position;
    }

    void Start()
    {
        health = maxHealth;
        EnterState(State.Patrol);
    }

    void Update()
    {
        switch (state)
        {
            case State.Patrol:
                UpdatePatrol();
                break;
            case State.Chase:
                UpdateChase();
                break;
            case State.WindUp:
                break;                  // waits for the OnLeap Animation Event
            case State.Leap:
                UpdateLeap();
                break;
            case State.Hurt:
                UpdateHurt();
                break;
            case State.Dead:
                break;                  // waits for the OnDeathFinished Animation Event
        }

        // The slime's picture looks left, so it flips to look right.
        spriteRenderer.flipX = direction > 0f;
    }

    // The one place the state changes. The enter step runs once, as the
    // slime arrives in its new state.
    void EnterState(State next)
    {
        state = next;
        stateStartTime = Time.time;
        animator.SetInteger(StateHash, (int)state);

        switch (state)
        {
            case State.Patrol:
                break;
            case State.Chase:
                break;
            case State.WindUp:
                Stop();
                break;
            case State.Leap:
                body.linearVelocity = new Vector2(direction * leapVelocity.x, leapVelocity.y);
                break;
            case State.Hurt:
                break;
            case State.Dead:
                Stop();
                slimeCollider.enabled = false;
                body.simulated = false;
                break;
        }
    }

    void UpdatePatrol()
    {
        if (CanSeeKnight(sightRange))
        {
            EnterState(State.Chase);
            return;
        }

        // Turn round at either end of its patch of ground, or at an edge.
        bool isPastRight = direction > 0f && transform.position.x > startPosition.x + patrolDistance;
        bool isPastLeft = direction < 0f && transform.position.x < startPosition.x - patrolDistance;
        if (isPastRight || isPastLeft || !HasGroundAhead())
        {
            direction = -direction;
        }
        Move(patrolSpeed);
    }

    void UpdateChase()
    {
        // It gives up once the knight is well away.
        if (!CanSeeKnight(sightRange * 1.5f))
        {
            EnterState(State.Patrol);
            return;
        }

        float toKnight = knight.transform.position.x - transform.position.x;
        direction = toKnight < 0f ? -1f : 1f;

        if (Mathf.Abs(toKnight) <= leapRange && IsGrounded() && HasGroundAhead())
        {
            EnterState(State.WindUp);
        }
        else if (HasGroundAhead())
        {
            Move(chaseSpeed);
        }
        else
        {
            Stop();     // it never chases him off a ledge
        }
    }

    void UpdateLeap()
    {
        // Landed: a moment after take-off, it's standing on the ground again.
        if (Time.time > stateStartTime + 0.2f && IsGrounded())
        {
            EnterState(State.Chase);
        }
    }

    void UpdateHurt()
    {
        if (Time.time < stateStartTime + hurtSeconds)
        {
            return;
        }
        if (health > 0)
        {
            EnterState(State.Chase);
        }
        else
        {
            EnterState(State.Dead);
        }
    }

    // Stomped or rolled into. fromX is where the knight is, so it flies away from him.
    public void TakeHit(float fromX)
    {
        if (IsHarmless)
        {
            return;
        }
        health--;
        float away = transform.position.x < fromX ? -1f : 1f;
        body.linearVelocity = new Vector2(knockback.x * away, knockback.y);
        EnterState(State.Hurt);
    }

    // Animation Event: on the last frame of the WindUp clip.
    public void OnLeap()
    {
        // A stomp during the wind-up changes the state first: then there's no leap.
        if (state == State.WindUp)
        {
            EnterState(State.Leap);
        }
    }

    // Animation Event: at the end of the Dead clip, once it has melted and faded.
    public void OnDeathFinished()
    {
        gameObject.SetActive(false);
    }

    bool CanSeeKnight(float range)
    {
        if (knight.IsDead)
        {
            return false;
        }
        Vector2 toKnight = knight.transform.position - transform.position;
        return Mathf.Abs(toKnight.x) < range && Mathf.Abs(toKnight.y) < 1.5f;
    }

    bool IsGrounded()
    {
        Vector2 start = (Vector2)transform.position + new Vector2(0f, 0.1f);
        return Physics2D.Raycast(start, Vector2.down, 0.2f, groundMask).collider != null;
    }

    // Is there ground half a tile ahead, in the direction it's going?
    bool HasGroundAhead()
    {
        Vector2 start = (Vector2)transform.position + new Vector2(direction * 0.5f, 0.1f);
        return Physics2D.Raycast(start, Vector2.down, 0.6f, groundMask).collider != null;
    }

    void Move(float speed)
    {
        body.linearVelocity = new Vector2(direction * speed, body.linearVelocity.y);
    }

    void Stop()
    {
        body.linearVelocity = new Vector2(0f, body.linearVelocity.y);
    }
}
```

5. The **Knight** field is a `KnightHealth` now, and Unity can't keep the old
   reference: it shows **None**. Select all three slimes and drag `Knight` into it
   again.

Read it before you move on:

- `IsHarmless` is true in Hurt and Dead: the knight can't be hurt by a slime in those
  states, and can't hit one again.
- `TakeHit` knocks the slime away from the knight, and always enters **Hurt** first:
  the flash plays even on the last hit. `UpdateHurt` decides, 0.4 seconds later,
  between Chase and Dead.
- Dead's enter step switches the collider and the physics off, so nothing bumps into a
  melting slime.
- `OnLeap` checks the state for a reason now: a stomp during the wind-up sends the slime
  to Hurt, and the cut-short wind-up must not leap.

### Do it — the combat

Create `KnightCombat`, and attach it to `Knight`:

```csharp:KnightCombat.cs
using UnityEngine;

// What a bump with a slime means. Landing on top of it is a stomp, and rolling
// into it knocks it over. Any other bump hurts the knight.
public class KnightCombat : MonoBehaviour
{
    KnightController controller;
    KnightHealth health;

    void Awake()
    {
        controller = GetComponent<KnightController>();
        health = GetComponent<KnightHealth>();
    }

    // Enter: the first moment they touch. Stay: every physics step after that,
    // so a slime still touching him when the blinking ends hurts him again.
    void OnCollisionEnter2D(Collision2D collision)
    {
        HandleBump(collision);
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        HandleBump(collision);
    }

    void HandleBump(Collision2D collision)
    {
        if (collision.contactCount == 0 || health.IsDead)
        {
            return;
        }
        if (!collision.gameObject.TryGetComponent(out Slime slime) || slime.IsHarmless)
        {
            return;
        }

        // The contact's normal points from the slime towards the knight.
        // Pointing up means he came down on top of it.
        if (collision.GetContact(0).normal.y > 0.5f)
        {
            slime.TakeHit(transform.position.x);
            controller.Bounce();
        }
        else if (controller.IsRolling)
        {
            slime.TakeHit(transform.position.x);
        }
        else
        {
            health.TakeDamage(1, slime.transform.position.x);
        }
    }
}
```

Read it before you move on:

- `TryGetComponent(out Slime slime)` both asks *is it a slime?* and gets the slime, as
  in Level 2.
- `collision.GetContact(0).normal.y > 0.5f`: the first contact point's normal points
  up, so he landed on top.
- `contactCount == 0` guards a rare case: a collision with no contact points left.

### Do it — the pits

1. Create `KillZone`:

```csharp
using UnityEngine;

// Water, goo, the moat, and the bottom of the level. For now, the knight
// loses 1 health and goes back to the start point.
public class KillZone : MonoBehaviour
{
    [SerializeField] Transform startPoint;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out KnightController knight))
        {
            knight.ResetKnight(startPoint.position);
            knight.GetComponent<KnightHealth>().FellInPit();
        }
    }
}
```

2. Create an empty GameObject, `Start Point`, at `(2.5, 0, 0)`, where the knight starts.
3. Select `Hazards` and **Add Component → Kill Zone**, with `Start Point` in its **Start
   Point** field.
4. Create an empty GameObject, `Kill Zone`, at `(94.5, -7, 0)`. Give it a **Box
   Collider 2D** with **Is Trigger** ticked and a **Size** of `(209, 2)`, and a **Kill
   Zone** with the same **Start Point**.

### Do it — the events

1. In the Animation window, with the knight selected, pick **Knight Dead**, move to
   `1:0`, its last moment, and **Add Event**: **OnDeathFinished**.
2. With a slime selected, pick **Slime Dead**, and do the same: **OnDeathFinished**, the
   slime's this time.

### Test it

1. Walk into a slime: the knight flashes red, flies back, blinks, and the Console says
   `Health: 4`. While he blinks, walk into it again: nothing.
2. Jump onto a slime: it flashes, melts and fades, and the knight bounces up.
3. Roll into a slime: it's knocked over, and the knight isn't hurt.
4. Jump into a pit: he's back at the start, one health down.
5. Lose all five: he falls over and fades, and the Console says
   `The knight has fallen`. Stop and play again to start over: Restart comes in
   Chapter 11.
6. Make the roll bug on purpose: in `ResetKnight`, put `//` in front of
   `isRolling = false;`, play, and roll into the water. He comes back still rolling, and
   rolls on, for ever. Take the `//` away.

### Challenge

Make stomping skilful: if the jump key is held as he lands on a slime, bounce higher
(14 instead of 9). Hint: `Bounce` can read the keyboard too, and remember that
`Keyboard.current` can be `null`.

## Chapter 8 — The Autumn Woods and the Purple Slime

**Goal:** the second section, painted step by step: gold grass on red earth, a long pit
of purple goo crossed on floating platforms, and mushrooms. And a second kind of slime,
purple and tougher, made from the same script and the same state machine, with no new
code at all.

### Idea — the woods' map

```
                70        80        90        100       110       120
                |         |         |         |         |         |
   4   ...............C......................A........................
   3   ...........C.......C.................==........................
   2   ..............==..............C.C...................C..........
   1   ..........==......==.....C.C.......##.........C...........C....
   0   .T..m..................n..s.b..p...##........m..s..T...p....k.P
  -1   ########..............###################...###################
  -2   ########~~~~~~~~~~~~~~###################~~~###################
  -3   ########~~~~~~~~~~~~~~###################~~~###################
```

The woods start at column 63, where the Meadow ends. `~` is goo here, `p` a purple slime,
`m` a big mushroom and `k` a pumpkin. The woods use other tiles from the same palette:

| Thing | Tiles in the palette |
| --- | --- |
| autumn grass, gold on top | column 4, row 0 |
| red earth | column 4, row 1 |
| goo, with its surface | column 4, row 11 |
| goo | column 4, row 12 |
| an orange tree | column 5, rows 5 (trunk), 4 and 3 |
| an orange bush | column 5, row 7 |
| a big red mushroom | column 7, row 5 |
| a small orange mushroom | column 8, row 6 |
| a pumpkin | column 4, row 8 |

### Do it — paint the ground

On the **Ground** Tilemap:

1. With the red earth, **Box Fill** rows −3 to −1 over columns 63 to 70, 85 to 103, and
   107 to 125. Then the block under the high ledge: columns 98 and 99, rows 0 and 1.
2. With the autumn grass, paint the top of every column: row −1 over columns 63 to 70,
   85 to 97, 100 to 103 and 107 to 125, and row 1 over columns 98 and 99.

### Do it — the goo

On the **Hazards** Tilemap: the goo with its surface on row −2, and plain goo on row −3,
over columns 71 to 84 (the long pit) and 104 to 106. The goo is a hazard because the
Tilemap is: the `KillZone` on `Hazards` makes every liquid tile on it deadly, whatever it
looks like.

### Do it — decoration

On the **Decoration** Tilemap: orange trees with their trunks at (64, 0) and (114, 0),
big red mushrooms at (67, 0) and (108, 0), a small orange mushroom at (86, 0), an orange
bush at (91, 0), and a pumpkin at (123, 0).

### Do it — gold platforms

1. Select the `Meadow Platform` prefab in `Assets/Prefabs` and press **Ctrl + D**
   (**Cmd + D**) to copy it. Rename the copy `Woods Platform`, open it, and give its
   Sprite Renderer the gold platform two tiles wide.
2. Place four, at `(74, 2, 0)`, `(78, 3, 0)` and `(82, 2, 0)` over the long pit, and
   `(101, 4, 0)`: the high ledge, above the block.

Each step between platforms is two tiles across and one up or down, and the knight jumps
about four across and two up: one jump each.

### Idea — the purple slime: one script, other numbers, other clips

The purple slime does everything the green one does, only more. It's the same `Slime`
script, with other values in the Inspector:

| | Green | Purple |
| --- | --- | --- |
| Max Health | 1 | 2 |
| Patrol Speed | 1.5 | 2 |
| Chase Speed | 2.5 | 3.5 |
| Sight Range | 4 | 5 |
| Leap Range | 1.2 | 2 |
| Leap Velocity | (4, 6) | (5, 7) |

It needs purple clips, though, and its Animator must play them in the same state
machine: Patrol, Chase, WindUp, Leap, Hurt and Dead, on the same `State` Int. An
**Animator Override Controller** does exactly that ({{ref:enemies}}): it borrows the
Slime controller's states and transitions, and swaps each clip for another. Change a
transition in `Slime.controller` later, and both slimes get it.

> **Note:** Unity has **prefab variants** too, prefabs that inherit from another, which
> would be another good fit. They come in Level 4: for now, the purple slime is a copy.

### Do it — the purple clips

The Animation window makes clips for the GameObject you select, so the purple clips
need a purple slime to make them on: a stand-in, deleted afterwards.

1. Drag the `Slime` prefab into the scene. Right-click it → **Prefab → Unpack
   Completely**, rename it `Purple Stand-in`, set its **Animator**'s **Controller** to
   **None**, and its sprite to `slime_purple_4`.
2. With the stand-in selected, click **Create** in the Animation window and save
   `Assets/Animation/Purple Slime Move.anim`. Unity makes a controller for the stand-in;
   you'll delete it.
3. Make the five purple clips, just like the green ones, with frames from
   `slime_purple`: **Purple Slime Move**, **Purple Slime WindUp** (with an `OnLeap`
   event on its last frame), **Purple Slime Leap**, **Purple Slime Hurt** and **Purple
   Slime Dead** (with its colour fade, and an `OnDeathFinished` event at `1:0`). The
   stand-in has the `Slime` script, so both methods are in the Function list.
4. Delete the stand-in from the Hierarchy, and the controller Unity made for it from
   `Assets/Animation`, `Purple Stand-in.controller`.

### Do it — the Override Controller

1. In `Assets/Animation`, **right-click → Create → Animation → Animator Override
   Controller**, and name it `Purple Slime`.
2. In its Inspector, set **Controller** to `Slime`. A list of the Slime controller's
   clips appears, each with an empty **Override** box.
3. Drag each purple clip into the box beside its green one: **Purple Slime Move** beside
   **Slime Move**, and so on for all five.

### Do it — the purple slime prefab

1. Select the `Slime` prefab in `Assets/Prefabs`, press **Ctrl + D** (**Cmd + D**), and
   rename the copy `Purple Slime`.
2. Open it. Give its Sprite Renderer `slime_purple_4`, its Animator's **Controller** the
   `Purple Slime` Override Controller, and its **Slime** the purple numbers from the
   table.

### Do it — the woods' slimes

Place two green slimes, at `(89.5, 0, 0)` and `(111.5, 0, 0)`, and two purple ones, at
`(94.5, 0, 0)` and `(118.5, 0, 0)`. Select all four and drag `Knight` into **Knight**.

### Test it

1. Play, and run on into the woods: the ground changes to gold, and the sky is still the
   Meadow's for now (Chapter 10).
2. Cross the goo on the platforms. Fall in on purpose: back to the start. Checkpoints
   come in Chapter 9.
3. Meet a purple slime: it sees you from further away, chases faster, and leaps further.
   Stomp it once: it flashes red and comes back for more. Twice: it melts away.
4. Select a purple slime while it plays, and look at its Animator window: the same
   states as the green slime's, playing purple clips.

### Challenge

Make a third kind of slime with no new clips at all: a little one. Copy the green prefab,
set its **Scale** to `(0.6, 0.6, 1)`, and make it quicker. Does its collider shrink with
it? Does its leap still reach you?

# Part 3 — A Real Level

## Chapter 9 — Coins, Apples and Checkpoints

**Goal:** coins to collect, spinning on a clip with no code at all; apples that give
health back; and two checkpoint signs that light up as the knight passes them, and
become the place he comes back to after a fall. A first `PlatformerGame` counts the
coins and remembers the last checkpoint.

### Idea — a clip with no code

A coin spins all the time, whatever happens: twelve frames in a looping clip. Its
Animator has that one state, no parameters and no transitions, and the coin's spin needs
no script at all. Not every Animator needs code: this one is just a looping picture.

### Idea — three pickups, three ways to talk

| Pickup | When the knight touches it | Talks to |
| --- | --- | --- |
| coin | counts, and hides | the game: `game.AddCoin()`, through a **Game** field |
| apple | gives 1 health back, unless he has all 5, and hides | the knight it touched: `TryGetComponent(out KnightHealth health)` |
| checkpoint | lights up, the first time, and becomes the respawn point | the game: `game.SetRespawnPoint(…)` |

A coin hides with `SetActive(false)` instead of being destroyed: Chapter 11's Restart
shows it again with `ResetCoin`.

### Idea — a sign that lights up, with property clips only

The checkpoint is a signpost from the tileset. It has no frames to animate, so its three
clips animate **properties**: the post's scale and rotation, and the sign's colour.

| Clip | Loops | Does |
| --- | --- | --- |
| `Checkpoint Unlit` | yes | greyed out, standing still |
| `Checkpoint Lighting` | no | a quick bounce (its scale to 1.3 and back) while its colour goes from grey to full |
| `Checkpoint Lit` | yes | full colour, swaying gently from side to side |

```
          Lit = true                  (Has Exit Time)
   Unlit ────────────→ Lighting ──────────────────────→ Lit
     ↑                                                   │
     └────────────────── Lit = false ────────────────────┘
```

Each clip sets all three properties, scale, rotation and colour, so whichever state
plays, the sign looks right.

The sign must bounce and sway from its foot, not its middle. So the checkpoint is two
GameObjects: the root, at ground level, which the clips scale and turn, and a child,
`Sign`, holding the picture half a tile up. A clip on the root can animate its child: the
colour curves have the path `Sign` ({{ref:animwindow}}).

### Idea — the game remembers the checkpoint

`PlatformerGame` starts small: it counts the coins in the Console, and remembers a
**respawn point**, the start at first, then each checkpoint the knight passes. A fall
now goes through the game: `KillZone` calls `game.KnightFell()`, which puts the knight at
the respawn point, snaps the camera to him, and takes 1 health.

### Do it — the coin

1. Give `coin` the pixel-art settings, and **Slice** it with **Grid By Cell Size**,
   `16` × `16`, **Pivot** **Center**.
2. Drag `coin_0` into the Hierarchy and rename it `Coin`. Set its **Order in Layer** to
   `3`.
3. **Add Component → Circle Collider 2D**, tick **Is Trigger**, and set **Radius** to
   `0.3`.
4. With `Coin` selected, click **Create** in the Animation window: save `Coin Spin.anim`
   in `Assets/Animation`, set **Samples** to `12`, and drag `coin_0` to `coin_11` in.
   Unity makes `Coin.controller`, with the one state. Press **Play** in the Animation
   window: it spins.

### Do it — the game, first version

1. Create an empty GameObject, `Platformer Game`, at `(0, 0, 0)`.
2. Create `PlatformerGame` and attach it:

```csharp
using UnityEngine;

// Runs the game. For now, it counts the coins, remembers the last checkpoint,
// and sends the knight back to it after a fall.
public class PlatformerGame : MonoBehaviour
{
    [SerializeField] KnightController knight;
    [SerializeField] KnightHealth knightHealth;
    [SerializeField] CameraFollow cameraFollow;

    int coins;
    Vector2 startPoint;
    Vector2 respawnPoint;

    void Awake()
    {
        startPoint = knight.transform.position;
        respawnPoint = startPoint;
    }

    public void AddCoin()
    {
        coins++;
        Debug.Log($"Coins: {coins}");
    }

    public void SetRespawnPoint(Vector2 point)
    {
        respawnPoint = point;
    }

    // The knight fell in: back to the last checkpoint, and 1 health less.
    public void KnightFell()
    {
        knight.ResetKnight(respawnPoint);
        cameraFollow.SnapToTarget();
        knightHealth.FellInPit();
    }
}
```

3. Drag `Knight` into **Knight** and into **Knight Health**, and **Main Camera** into
   **Camera Follow**.

Read it before you move on:

- The knight's start is wherever he stands when the game begins: `Awake` remembers it.
- `SetRespawnPoint` takes a `Vector2`; a checkpoint passes its own position.
- `KnightFell` uses `ResetKnight` and `FellInPit` from Chapter 7, and the camera's
  `SnapToTarget` from Chapter 2, so the view doesn't drift back across the level.

### Do it — the kill zone, final version

Replace `KillZone` with its final version:

```csharp:KillZone.cs
using UnityEngine;

// Water, goo, the moat, and the bottom of the level. The knight loses 1
// health and goes back to the last checkpoint. A slime that falls in is gone
// until Restart.
public class KillZone : MonoBehaviour
{
    [SerializeField] PlatformerGame game;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out KnightController knight))
        {
            game.KnightFell();
        }
        else if (other.TryGetComponent(out Slime slime))
        {
            slime.gameObject.SetActive(false);
        }
    }
}
```

Select `Hazards` and `Kill Zone`, and drag `Platformer Game` into their **Game** field.
Delete the `Start Point` object: the game remembers the start now.

The `else if` takes care of slimes: one knocked into the water by a roll falls in, and
is gone until Restart.

### Do it — the coin's script

1. Create `Coin`, attach it to the coin, and drag `Platformer Game` into its **Game**
   field:

```csharp:Coin.cs
using UnityEngine;

// A coin. Its spin is a looping clip in its Animator, with no code at all.
// When the knight touches it, it counts, and hides until Restart.
public class Coin : MonoBehaviour
{
    [SerializeField] PlatformerGame game;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out KnightController knight))
        {
            game.AddCoin();
            gameObject.SetActive(false);
        }
    }

    public void ResetCoin()
    {
        gameObject.SetActive(true);
    }
}
```

2. Drag `Coin` into `Assets/Prefabs`. Then place the Meadow's and the woods' coins, the
   `C` marks on their maps, each half a tile into its cell. A quick way: select a
   placed coin, press **Ctrl + D** (**Cmd + D**) to copy it, and type the new position.

| Section | Coins at |
| --- | --- |
| Meadow | (4.5, 1.5), (6.5, 1.5), (8.5, 1.5), (13.5, 3.5), (14.5, 3.5), (27.5, 2.5), (29.5, 2.5), (31.5, 2.5), (53.5, 1.5), (55.5, 1.5) |
| Woods | (74.5, 3.5), (78.5, 4.5), (82.5, 3.5), (88.5, 1.5), (90.5, 1.5), (93.5, 2.5), (95.5, 2.5), (109.5, 1.5), (115.5, 2.5), (121.5, 1.5) |

3. Select all twenty coins in the Hierarchy and drag `Platformer Game` into **Game**
   once: a prefab can't remember a GameObject in the scene.

### Do it — health back

Replace `KnightHealth` with this version:

```csharp
using System.Collections;
using UnityEngine;

// The knight's health: 5 to start with. A slime knocks him back and makes him
// blink, and nothing can hurt him while he blinks. At 0 he falls, and when his
// Dead clip ends, the game is lost.
public class KnightHealth : MonoBehaviour
{
    public const int MaxHealth = 5;

    static readonly int HurtHash = Animator.StringToHash("Hurt");
    static readonly int DeadHash = Animator.StringToHash("Dead");

    [SerializeField] Vector2 knockback = new Vector2(5f, 6f);
    [SerializeField] float stunSeconds = 0.25f;     // no control, while the knockback carries him
    [SerializeField] float blinkSeconds = 1f;

    Rigidbody2D body;
    Animator animator;
    SpriteRenderer spriteRenderer;
    KnightController controller;
    bool isBlinking;
    float stunnedUntil;

    public int Health { get; private set; } = MaxHealth;
    public bool IsDead { get; private set; }

    public bool IsStunned
    {
        get { return Time.time < stunnedUntil; }
    }

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        controller = GetComponent<KnightController>();
    }

    // A slime hurt him. fromX is where the slime is, so he flies away from it.
    public void TakeDamage(int amount, float fromX)
    {
        // Nothing hurts him while he blinks or rolls, and a fallen knight
        // can't fall again.
        if (IsDead || isBlinking || controller.IsRolling)
        {
            return;
        }

        LoseHealth(amount);
        if (IsDead)
        {
            return;
        }

        float direction = transform.position.x < fromX ? -1f : 1f;
        body.linearVelocity = new Vector2(knockback.x * direction, knockback.y);
        stunnedUntil = Time.time + stunSeconds;
        animator.SetTrigger(HurtHash);
    }

    // He fell into water, goo or the moat. The game has already put him back
    // at the last checkpoint.
    public void FellInPit()
    {
        if (!IsDead)
        {
            LoseHealth(1);
        }
    }

    void LoseHealth(int amount)
    {
        Health = Mathf.Max(Health - amount, 0);
        Debug.Log($"Health: {Health}");

        if (Health == 0)
        {
            IsDead = true;
            body.linearVelocity = new Vector2(0f, body.linearVelocity.y);
            animator.SetTrigger(DeadHash);
        }
        else
        {
            StartCoroutine(Blink());
        }
    }

    IEnumerator Blink()
    {
        isBlinking = true;
        float endTime = Time.time + blinkSeconds;
        while (Time.time < endTime)
        {
            spriteRenderer.enabled = !spriteRenderer.enabled;
            yield return new WaitForSeconds(0.1f);
        }
        spriteRenderer.enabled = true;
        isBlinking = false;
    }

    public void Heal(int amount)
    {
        Health = Mathf.Min(Health + amount, MaxHealth);
        Debug.Log($"Health: {Health}");
    }

    // Animation Event: at the end of the Dead clip, once he has faded out.
    public void OnDeathFinished()
    {
        Debug.Log("The knight has fallen");
    }

    public void ResetHealth()
    {
        StopAllCoroutines();
        Health = MaxHealth;
        IsDead = false;
        isBlinking = false;
        stunnedUntil = 0f;
        spriteRenderer.enabled = true;
    }
}
```

Read it before you move on:

- `Heal` adds health, never above `MaxHealth`: `Mathf.Min` picks the smaller.
- `ResetHealth` puts everything back as it was at the start. Nothing calls it yet:
  Chapter 11's Restart will.

### Do it — the apple

1. Give `fruit` the pixel-art settings, and slice it `16` × `16`, **Pivot** **Center**.
   The red apple is `fruit_9`, the first fruit of the bottom row.
2. Drag `fruit_9` into the Hierarchy, rename it `Apple`, set its **Order in Layer** to
   `3`, and give it a **Circle Collider 2D** with **Is Trigger** ticked and a **Radius**
   of `0.35`.
3. Create `Apple`, and attach it:

```csharp:Apple.cs
using UnityEngine;

// An apple. It gives the knight back 1 health, unless he already has all 5:
// then it stays where it is, for later.
public class Apple : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out KnightHealth health) && !health.IsDead && health.Health < KnightHealth.MaxHealth)
        {
            health.Heal(1);
            gameObject.SetActive(false);
        }
    }

    public void ResetApple()
    {
        gameObject.SetActive(true);
    }
}
```

4. Make it a prefab, and place two apples: `(58.5, 1.5, 0)` on the Meadow's low block,
   and `(101.5, 4.5, 0)` on the woods' high ledge.

### Do it — the checkpoint

1. Create an empty GameObject, `Checkpoint`, at `(62.5, 0, 0)`: the `P` at the end of
   the Meadow. Give it a **Box Collider 2D** with **Is Trigger** ticked, a **Size** of
   `(1, 2)` and an **Offset** of `(0, 1)`.
2. Right-click it → **Create Empty**, name the child `Sign`, set its **Position** to
   `(0, 0.5, 0)`, and give it a **Sprite Renderer** with the signpost:
   `world_tileset_42`, from column 8, row 3 of the palette. Set its **Order in Layer**
   to `1`.
3. Select `Checkpoint` (the root). In the Animation window, click **Create** and save
   `Assets/Animation/Checkpoint Unlit.anim`. Leave **Samples** at `60`, a new clip's
   default: `0:30` is then half a second, and `0:09` is 9 frames, 0.15 seconds.
4. Click **Add Property**, and click the **+** beside **Transform → Scale** and
   **Transform → Rotation**. Click **Add Property** again, open **Sign → Sprite
   Renderer**, and click the **+** beside **Color**. Unity gives each property two
   keyframes, at `0:00` and `1:00`, holding its value now.
5. Grey the sign: turn on **Record**, select `Sign` in the Hierarchy, and with the
   playhead at `0:00`, set its colour to the hex value `8C8C99`. Move the playhead to
   `1:00` and set it again. Turn **Record** off. That's **Unlit**: grey, and still.
6. Select `Checkpoint` again. In the clip menu, **Create New Clip…**, save
   `Checkpoint Lighting.anim`, and add the same three properties. Then:
   - in the Dopesheet's top row, drag the diamond at `1:00` to `0:24`: every
     property's last keyframe moves with it, and the clip lasts 0.4 seconds;
   - turn on **Record**. At `0:00`, set `Sign`'s colour to `8C8C99`. At `0:09`, set
     `Checkpoint`'s **Scale** to `(1.3, 1.3, 1)`. Turn **Record** off.

   The sign swells to 1.3 and settles back by `0:24`, while its colour comes up from
   grey to white. In the Project window, untick this clip's **Loop Time**.
7. **Create New Clip…** again: `Checkpoint Lit.anim`, with the same three properties.
   Turn on **Record**, and set `Checkpoint`'s **Rotation Z** to `4` at `0:30`, and to
   `-4` at `1:30`. The keys at `0:00` and `1:00` already hold `0`. Move the playhead to
   `2:00` and click **Add Keyframe**, so the clip ends there, back at `0`. Turn
   **Record** off. The sign leans one way, then the other, every two seconds, in full
   colour.
8. Open the Animator window. The three states are named after their clips: rename them
   `Unlit`, `Lighting` and `Lit`. **Unlit**, the first clip you made, is orange, the
   default. Add a **Bool**, `Lit`, and three transitions, each with **Transition
   Duration** `0`:
   - Unlit → Lighting: **Has Exit Time** off, `Lit` true;
   - Lighting → Lit: **Has Exit Time** on, **Exit Time** `1`, no condition;
   - Lit → Unlit: **Has Exit Time** off, `Lit` false.
9. Create `Checkpoint`, attach it to the root, and drag `Platformer Game` into **Game**:

```csharp:Checkpoint.cs
using UnityEngine;

// A signpost. The first time the knight passes it, it lights up, and it
// becomes the place he comes back to after a fall.
public class Checkpoint : MonoBehaviour
{
    static readonly int LitHash = Animator.StringToHash("Lit");

    [SerializeField] PlatformerGame game;

    Animator animator;
    bool isLit;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!isLit && other.TryGetComponent(out KnightController knight))
        {
            isLit = true;
            animator.SetBool(LitHash, true);
            game.SetRespawnPoint(transform.position);
        }
    }

    public void ResetCheckpoint()
    {
        isLit = false;
        animator.SetBool(LitHash, false);
    }
}
```

10. Make it a prefab, and place a second one at `(125.5, 0, 0)`, the end of the woods.
    Set its **Game** too.

### Do it — the slimes' reset

Replace `Slime` with this version, which adds `ResetSlime` for Chapter 11's Restart:

```csharp
using UnityEngine;

// A slime, run as a state machine. Each state's enter step tells the Animator
// which state it's in, through the State parameter, so the Animator follows
// the code. The purple slime is this same script, with other numbers.
[RequireComponent(typeof(Rigidbody2D))]
public class Slime : MonoBehaviour
{
    public enum State { Patrol, Chase, WindUp, Leap, Hurt, Dead }

    static readonly int StateHash = Animator.StringToHash("State");

    [SerializeField] KnightHealth knight;
    [SerializeField] LayerMask groundMask;
    [SerializeField] int maxHealth = 1;
    [SerializeField] float patrolSpeed = 1.5f;
    [SerializeField] float patrolDistance = 2f;     // how far it wanders from where it started, each way
    [SerializeField] float chaseSpeed = 2.5f;
    [SerializeField] float sightRange = 4f;
    [SerializeField] float leapRange = 1.2f;
    [SerializeField] Vector2 leapVelocity = new Vector2(4f, 6f);
    [SerializeField] Vector2 knockback = new Vector2(3f, 3f);
    [SerializeField] float hurtSeconds = 0.4f;

    Rigidbody2D body;
    Animator animator;
    SpriteRenderer spriteRenderer;
    Collider2D slimeCollider;
    Vector2 startPosition;
    State state;
    int health;
    float direction = -1f;      // -1 left, 1 right
    float stateStartTime;

    // A hurt or dead slime can't hurt the knight, and can't be hit again.
    public bool IsHarmless
    {
        get { return state == State.Hurt || state == State.Dead; }
    }

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        slimeCollider = GetComponent<Collider2D>();
        startPosition = transform.position;
    }

    void Start()
    {
        ResetSlime();
    }

    void Update()
    {
        switch (state)
        {
            case State.Patrol:
                UpdatePatrol();
                break;
            case State.Chase:
                UpdateChase();
                break;
            case State.WindUp:
                break;                  // waits for the OnLeap Animation Event
            case State.Leap:
                UpdateLeap();
                break;
            case State.Hurt:
                UpdateHurt();
                break;
            case State.Dead:
                break;                  // waits for the OnDeathFinished Animation Event
        }

        // The slime's picture looks left, so it flips to look right.
        spriteRenderer.flipX = direction > 0f;
    }

    // The one place the state changes. The enter step runs once, as the
    // slime arrives in its new state.
    void EnterState(State next)
    {
        state = next;
        stateStartTime = Time.time;
        animator.SetInteger(StateHash, (int)state);

        switch (state)
        {
            case State.Patrol:
                break;
            case State.Chase:
                break;
            case State.WindUp:
                Stop();
                break;
            case State.Leap:
                body.linearVelocity = new Vector2(direction * leapVelocity.x, leapVelocity.y);
                break;
            case State.Hurt:
                break;
            case State.Dead:
                Stop();
                slimeCollider.enabled = false;
                body.simulated = false;
                break;
        }
    }

    void UpdatePatrol()
    {
        if (CanSeeKnight(sightRange))
        {
            EnterState(State.Chase);
            return;
        }

        // Turn round at either end of its patch of ground, or at an edge.
        bool isPastRight = direction > 0f && transform.position.x > startPosition.x + patrolDistance;
        bool isPastLeft = direction < 0f && transform.position.x < startPosition.x - patrolDistance;
        if (isPastRight || isPastLeft || !HasGroundAhead())
        {
            direction = -direction;
        }
        Move(patrolSpeed);
    }

    void UpdateChase()
    {
        // It gives up once the knight is well away.
        if (!CanSeeKnight(sightRange * 1.5f))
        {
            EnterState(State.Patrol);
            return;
        }

        float toKnight = knight.transform.position.x - transform.position.x;
        direction = toKnight < 0f ? -1f : 1f;

        if (Mathf.Abs(toKnight) <= leapRange && IsGrounded() && HasGroundAhead())
        {
            EnterState(State.WindUp);
        }
        else if (HasGroundAhead())
        {
            Move(chaseSpeed);
        }
        else
        {
            Stop();     // it never chases him off a ledge
        }
    }

    void UpdateLeap()
    {
        // Landed: a moment after take-off, it's standing on the ground again.
        if (Time.time > stateStartTime + 0.2f && IsGrounded())
        {
            EnterState(State.Chase);
        }
    }

    void UpdateHurt()
    {
        if (Time.time < stateStartTime + hurtSeconds)
        {
            return;
        }
        if (health > 0)
        {
            EnterState(State.Chase);
        }
        else
        {
            EnterState(State.Dead);
        }
    }

    // Stomped or rolled into. fromX is where the knight is, so it flies away from him.
    public void TakeHit(float fromX)
    {
        if (IsHarmless)
        {
            return;
        }
        health--;
        float away = transform.position.x < fromX ? -1f : 1f;
        body.linearVelocity = new Vector2(knockback.x * away, knockback.y);
        EnterState(State.Hurt);
    }

    // Animation Event: on the last frame of the WindUp clip.
    public void OnLeap()
    {
        // A stomp during the wind-up changes the state first: then there's no leap.
        if (state == State.WindUp)
        {
            EnterState(State.Leap);
        }
    }

    // Animation Event: at the end of the Dead clip, once it has melted and faded.
    public void OnDeathFinished()
    {
        gameObject.SetActive(false);
    }

    bool CanSeeKnight(float range)
    {
        if (knight.IsDead)
        {
            return false;
        }
        Vector2 toKnight = knight.transform.position - transform.position;
        return Mathf.Abs(toKnight.x) < range && Mathf.Abs(toKnight.y) < 1.5f;
    }

    bool IsGrounded()
    {
        Vector2 start = (Vector2)transform.position + new Vector2(0f, 0.1f);
        return Physics2D.Raycast(start, Vector2.down, 0.2f, groundMask).collider != null;
    }

    // Is there ground half a tile ahead, in the direction it's going?
    bool HasGroundAhead()
    {
        Vector2 start = (Vector2)transform.position + new Vector2(direction * 0.5f, 0.1f);
        return Physics2D.Raycast(start, Vector2.down, 0.6f, groundMask).collider != null;
    }

    void Move(float speed)
    {
        body.linearVelocity = new Vector2(direction * speed, body.linearVelocity.y);
    }

    void Stop()
    {
        body.linearVelocity = new Vector2(0f, body.linearVelocity.y);
    }

    // Back where it started, alive and patrolling: on Restart.
    public void ResetSlime()
    {
        gameObject.SetActive(true);
        body.simulated = true;
        body.position = startPosition;
        transform.position = startPosition;
        body.linearVelocity = Vector2.zero;
        slimeCollider.enabled = true;

        // The Dead clip fades it out. Put its colour back before Rebind
        // remembers it.
        spriteRenderer.color = Color.white;
        animator.Rebind();

        health = maxHealth;
        direction = -1f;
        EnterState(State.Patrol);
    }
}
```

`Start` now calls `ResetSlime`, so a slime starts the game exactly as Restart will
start it again.

### Test it

1. Play. The coins spin. Collect a few: the Console counts them.
2. Get hurt by a slime, then touch an apple: `Health` goes back up, and the apple
   disappears. At full health, an apple stays where it is.
3. Run past the first checkpoint: it bounces into colour, and sways. Run back past it:
   it doesn't light again.
4. Fall into the goo: you're back at the checkpoint, not at the start.

### Challenge

Make the apples bob gently up and down. Careful: a clip that animates the apple's own
**Position** moves every apple in the level to the same place, the position in the clip.
Animate a child holding the picture instead, as the checkpoint does.

{{concept:gameui}}

## Chapter 10 — The Screen

**Goal:** the knight's health as a bar beside his face, sliding and changing colour; the
coins counted on the screen; and each section's name shown as the knight reaches it,
while the sky changes colour to match. All in the bundle's pixel font, with a dark
outline so it reads on every sky.

### Idea — what goes where

```
 ┌───────────────────────────────────────────────────────────────────────┐
 │ ┌─────────────────────────┐                                     ┌──┐  │
 │ │ (face) ██████████░░░░░  │                                     │II│  │
 │ └─────────────────────────┘                                     └──┘  │
 │ ┌───────────┐                                                         │
 │ │ (coin) x 7│               The Autumn Woods                          │
 │ └───────────┘                                                         │
 │                                                                       │
 └───────────────────────────────────────────────────────────────────────┘
```

| Thing | Shows | Chapter |
| --- | --- | --- |
| health panel | the knight's face, and a bar from green (5) to red (1) | this one |
| coin panel | a coin, and `x 7` | this one |
| section name | `The Meadow`, `The Autumn Woods`, `The Castle Walls`, for two seconds, then fading; under the top row, so the longest name clears the health panel | this one |
| pause button | `II` | Chapter 12 |

### Idea — a section is a plain class

Each section has three things to remember: its name, where it starts, and its sky. They
belong together, so they go in one small class, `Section`, and `PlatformerGame` keeps an
array of them. `Section` isn't a component, and nothing attaches it to a GameObject: it
only holds data. `[System.Serializable]` above it lets Unity show it inside
`PlatformerGame`'s Inspector, as a list to fill in ({{ref:classes}} has more on kinds of
class).

| Title | Start X | Sky |
| --- | --- | --- |
| The Meadow | 0 | `#8ED0F2`, blue |
| The Autumn Woods | 63 | `#FAD3B3`, peach |
| The Castle Walls | 126 | `#6F2C77`, dusk purple |

The game finds the knight's section with a loop: the last section whose `StartX` he has
passed. When that changes, it shows the new name.

### Idea — two ways to move a value

The health bar and the sky both move towards a target, but differently:

| | Code | Moves |
| --- | --- | --- |
| bar | `Mathf.MoveTowards(fill, target, 2 * Time.deltaTime)` | at a steady speed, and stops exactly on the target |
| sky | `Color.Lerp(sky, target, 2 * Time.deltaTime)` | a part of the way that's left, every frame: quickly at first, then slower and slower |

The steady slide suits a bar you read; the easing suits a sky that should change
without anyone noticing when.

### Do it — the Canvas

1. **GameObject → UI (Canvas) → Text - TextMeshPro**. The first time, Unity asks to
   import **TMP Essentials**: click **Import TMP Essentials**, then close the window.
   Unity also creates a **Canvas** and an **EventSystem**. Rename the text
   `Section Text`.
2. Select **Canvas**. In its **Canvas Scaler**, set **UI Scale Mode** to **Scale With
   Screen Size**, **Reference Resolution** to `1920 × 1080`, and **Match** to `0.5`.
3. Select `Section Text`. Anchor it **top-center**, holding **Shift + Alt** (**Shift +
   Option** on a Mac), and set **Pos** to `(0, -170)`, **Width** `1200` and **Height**
   `100`. Delete its "New Text", set **Font Size** to `64` and the alignment to
   **centre** and **middle**, and untick **Raycast Target** under **Extra Settings**.

### Do it — the pixel font, with an outline

TextMeshPro draws a font from a **Font Asset** made from it.

1. Select `PixelOperator8` in `Assets/Fonts`, then **Assets → Create → TextMeshPro →
   Font Asset → SDF**. A new asset appears beside it: `PixelOperator8 SDF`.
2. Open its arrow in the Project window: inside are the letters' texture,
   `PixelOperator8 Atlas`, and their material, `PixelOperator8 Atlas Material`. Select
   the material. In the Inspector, under **Outline**, set **Color** to `#1C1F2B`, a
   deep navy, and **Thickness** to `0.2`.
3. Select `Section Text`, and set its **Font Asset** to `PixelOperator8 SDF`. Type
   `The Meadow` into it to see the letters, then delete them again.

Every text that uses this font asset gets its material, and so its outline: white
letters with a dark edge, readable on the blue sky, the peach one, and the purple one.

### Do it — the health panel

> **Watch out:** the **GameObject** menu always puts new UI straight onto the Canvas.
> To put a UI element **inside** another, right-click the parent in the Hierarchy and
> choose **UI (Canvas) → …** there.

Make these, in this order, each from the menu its **Parent** says. Anchor each with
**Shift + Alt**, so its pivot moves to the same place, and untick **Raycast Target** on
every one: they're only there to be seen.

| Object | Type | Parent | Anchor | Pos | Size |
| --- | --- | --- | --- | --- | --- |
| `Health Panel` | Image | Canvas | top-left | (30, −30) | 560 × 100 |
| `Knight Face` | Image | Health Panel | middle-left | (0, −4) | 128 × 128 |
| `Health Bar` | Create Empty | Health Panel | middle-left | (120, 0) | 410 × 40 |
| `Background` | Image | Health Bar | middle-center | (0, 0) | 410 × 40 |
| `Fill` | Image | Health Bar | middle-center | (0, 0) | 410 × 40 |

Then their pictures:

| Object | Source Image | Image Type | Color |
| --- | --- | --- | --- |
| `Health Panel` | `UISprite` | **Sliced** | `#1C1F2B`, **A** `191` |
| `Knight Face` | `knight_0`, with **Preserve Aspect** ticked | **Simple** | white |
| `Background` | `UISprite` | **Sliced** | black, **A** `115` |
| `Fill` | `UISprite` | **Filled**: **Horizontal**, **Left** | `#5CD140` |

To find `UISprite`, click the small circle beside **Source Image**: it's one of Unity's
own sprites. `Background` comes before `Fill` in the Hierarchy, so it's drawn first,
behind it: as the fill shrinks, the dark background shows.

### Do it — the coin panel

| Object | Type | Parent | Anchor | Pos | Size |
| --- | --- | --- | --- | --- | --- |
| `Coin Panel` | Image | Canvas | top-left | (30, −145) | 230 × 80 |
| `Coin Icon` | Image | Coin Panel | middle-left | (10, 0) | 64 × 64 |
| `Coin Text` | Text - TextMeshPro | Coin Panel | middle-left | (84, 0) | 140 × 70 |

`Coin Panel` looks like `Health Panel`: `UISprite`, **Sliced**, `#1C1F2B` with **A**
`191`. `Coin Icon` shows `coin_0`. `Coin Text` says `x 0`, in `PixelOperator8 SDF`,
**Font Size** `44`, aligned **left** and **middle**. Untick **Raycast Target** on all
three.

### Do it — the code

Four scripts, in this order: each uses the one before.

1. Create `Section`. It isn't a component, so don't attach it to anything:

```csharp:Section.cs
using UnityEngine;

// One section of the level: its name, where it starts, and the colour of its
// sky. [System.Serializable] lets a plain C# class show in the Inspector, so
// PlatformerGame can keep an array of them there.
[System.Serializable]
public class Section
{
    [SerializeField] string title;
    [SerializeField] float startX;
    [SerializeField] Color skyColour = Color.cyan;

    public string Title
    {
        get { return title; }
    }

    public float StartX
    {
        get { return startX; }
    }

    public Color SkyColour
    {
        get { return skyColour; }
    }
}
```

2. Create `HealthBar`, attach it to the `Health Bar` object, and drag `Fill` into its
   **Fill** field:

```csharp:HealthBar.cs
using UnityEngine;
using UnityEngine.UI;

// The health bar: a Filled image that slides to the knight's health, and
// fades from green to red as it empties.
public class HealthBar : MonoBehaviour
{
    [SerializeField] Image fill;
    [SerializeField] Color fullColour = new Color(0.36f, 0.82f, 0.25f);
    [SerializeField] Color emptyColour = new Color(0.9f, 0.2f, 0.2f);
    [SerializeField] float slideSpeed = 2f;     // how much of the bar it slides in a second

    float target = 1f;

    public void SetHealth(int current, int max)
    {
        target = (float)current / max;
    }

    void Update()
    {
        fill.fillAmount = Mathf.MoveTowards(fill.fillAmount, target, slideSpeed * Time.deltaTime);
        fill.color = Color.Lerp(emptyColour, fullColour, fill.fillAmount);
    }
}
```

3. Replace `KnightHealth`, and drag `Health Bar` into the knight's new **Health Bar**
   field:

```csharp
using System.Collections;
using UnityEngine;

// The knight's health: 5 to start with. A slime knocks him back and makes him
// blink, and nothing can hurt him while he blinks. At 0 he falls, and when his
// Dead clip ends, the game is lost.
public class KnightHealth : MonoBehaviour
{
    public const int MaxHealth = 5;

    static readonly int HurtHash = Animator.StringToHash("Hurt");
    static readonly int DeadHash = Animator.StringToHash("Dead");

    [SerializeField] HealthBar healthBar;
    [SerializeField] Vector2 knockback = new Vector2(5f, 6f);
    [SerializeField] float stunSeconds = 0.25f;     // no control, while the knockback carries him
    [SerializeField] float blinkSeconds = 1f;

    Rigidbody2D body;
    Animator animator;
    SpriteRenderer spriteRenderer;
    KnightController controller;
    bool isBlinking;
    float stunnedUntil;

    public int Health { get; private set; } = MaxHealth;
    public bool IsDead { get; private set; }

    public bool IsStunned
    {
        get { return Time.time < stunnedUntil; }
    }

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        controller = GetComponent<KnightController>();
    }

    void Start()
    {
        healthBar.SetHealth(Health, MaxHealth);
    }

    // A slime hurt him. fromX is where the slime is, so he flies away from it.
    public void TakeDamage(int amount, float fromX)
    {
        // Nothing hurts him while he blinks or rolls, and a fallen knight
        // can't fall again.
        if (IsDead || isBlinking || controller.IsRolling)
        {
            return;
        }

        LoseHealth(amount);
        if (IsDead)
        {
            return;
        }

        float direction = transform.position.x < fromX ? -1f : 1f;
        body.linearVelocity = new Vector2(knockback.x * direction, knockback.y);
        stunnedUntil = Time.time + stunSeconds;
        animator.SetTrigger(HurtHash);
    }

    // He fell into water, goo or the moat. The game has already put him back
    // at the last checkpoint.
    public void FellInPit()
    {
        if (!IsDead)
        {
            LoseHealth(1);
        }
    }

    void LoseHealth(int amount)
    {
        Health = Mathf.Max(Health - amount, 0);
        healthBar.SetHealth(Health, MaxHealth);

        if (Health == 0)
        {
            IsDead = true;
            body.linearVelocity = new Vector2(0f, body.linearVelocity.y);
            animator.SetTrigger(DeadHash);
        }
        else
        {
            StartCoroutine(Blink());
        }
    }

    IEnumerator Blink()
    {
        isBlinking = true;
        float endTime = Time.time + blinkSeconds;
        while (Time.time < endTime)
        {
            spriteRenderer.enabled = !spriteRenderer.enabled;
            yield return new WaitForSeconds(0.1f);
        }
        spriteRenderer.enabled = true;
        isBlinking = false;
    }

    public void Heal(int amount)
    {
        Health = Mathf.Min(Health + amount, MaxHealth);
        healthBar.SetHealth(Health, MaxHealth);
    }

    // Animation Event: at the end of the Dead clip, once he has faded out.
    public void OnDeathFinished()
    {
        Debug.Log("The knight has fallen");
    }

    public void ResetHealth()
    {
        StopAllCoroutines();
        Health = MaxHealth;
        IsDead = false;
        isBlinking = false;
        stunnedUntil = 0f;
        spriteRenderer.enabled = true;
        healthBar.SetHealth(Health, MaxHealth);
    }
}
```

4. Replace `PlatformerGame`:

```csharp
using System.Collections;
using TMPro;
using UnityEngine;

// Runs the game: it counts the coins, remembers the last checkpoint, and
// shows each section's name and sky as the knight reaches it.
public class PlatformerGame : MonoBehaviour
{
    [SerializeField] KnightController knight;
    [SerializeField] KnightHealth knightHealth;
    [SerializeField] CameraFollow cameraFollow;
    [SerializeField] Camera mainCamera;
    [SerializeField] Section[] sections;
    [SerializeField] float skyChangeSpeed = 2f;
    [SerializeField] TMP_Text coinText;
    [SerializeField] TMP_Text sectionText;

    int coins;
    Vector2 startPoint;
    Vector2 respawnPoint;
    int sectionIndex = -1;
    Coroutine sectionFade;

    void Awake()
    {
        startPoint = knight.transform.position;
        respawnPoint = startPoint;
        sectionText.text = "";
        mainCamera.backgroundColor = sections[0].SkyColour;
        UpdateCoinText();
    }

    void Update()
    {
        UpdateSection();

        // The sky eases towards the colour of the section the knight is in.
        if (sectionIndex >= 0)
        {
            Color sky = sections[sectionIndex].SkyColour;
            mainCamera.backgroundColor = Color.Lerp(mainCamera.backgroundColor, sky, skyChangeSpeed * Time.deltaTime);
        }
    }

    public void AddCoin()
    {
        coins++;
        UpdateCoinText();
    }

    public void SetRespawnPoint(Vector2 point)
    {
        respawnPoint = point;
    }

    // The knight fell in: back to the last checkpoint, and 1 health less.
    public void KnightFell()
    {
        knight.ResetKnight(respawnPoint);
        cameraFollow.SnapToTarget();
        knightHealth.FellInPit();
    }

    // Shows a section's name as the knight reaches it.
    void UpdateSection()
    {
        float x = knight.transform.position.x;
        int index = 0;
        for (int i = 0; i < sections.Length; i++)
        {
            if (x >= sections[i].StartX)
            {
                index = i;
            }
        }

        if (index != sectionIndex)
        {
            sectionIndex = index;
            if (sectionFade != null)
            {
                StopCoroutine(sectionFade);
            }
            sectionFade = StartCoroutine(ShowSectionName(sections[index].Title));
        }
    }

    IEnumerator ShowSectionName(string title)
    {
        sectionText.text = title;
        sectionText.alpha = 1f;
        yield return new WaitForSeconds(2f);
        for (float t = 0f; t < 1f; t += Time.deltaTime)
        {
            sectionText.alpha = 1f - t;
            yield return null;
        }
        sectionText.text = "";
    }

    void UpdateCoinText()
    {
        coinText.text = $"x {coins}";
    }
}
```

Read it before you move on:

- `HealthBar` doesn't know about the knight: it takes two numbers, and slides to them.
  `KnightHealth` tells it whenever the health changes, instead of a `Debug.Log`.
- `(float)current / max`: without the `(float)`, `3 / 5` would be `0`, and the bar
  would be empty at 3 health ({{ref:gameui}}).
- `UpdateSection` loops over every section, and keeps the last one the knight has
  passed. Only when that changes does it start `ShowSectionName`.
- `ShowSectionName` is a coroutine: the name, two seconds, then a one-second fade with
  `alpha`. If the knight reaches the next section while a name is still showing,
  `StopCoroutine` ends the old one first, so two can't fight over the text.
- `Awake` puts the first sky straight on, with no easing, so the game doesn't start
  with a fade.

### Do it — the sections

Select `Platformer Game`. Drag **Main Camera** into **Main Camera**, `Coin Text` into
**Coin Text** and `Section Text` into **Section Text**. Then open **Sections**, click
**+** three times, and fill in each element from the table: **Title**, **Start X**, and
**Sky Colour** from its hex value. Check that each colour's **A** (alpha) is `255`.

### Test it

1. Play. *The Meadow* appears at the top, and fades after two seconds. The bar is full
   and green; the coin count says `x 0`.
2. Collect coins: `x 1`, `x 2`…
3. Walk into a slime: the bar slides down a fifth. Each time it's hurt, the bar slides
   down again, and its colour moves from green through olive and orange to red. Eat
   an apple: it slides back up.
4. Run on into the woods: *The Autumn Woods* appears, and the sky warms from blue to
   peach over a second or two.
5. Run back into the Meadow: its name shows again, and the sky turns blue.

### Challenge

Make the coin icon bounce each time a coin is collected. Give `Coin Icon` an Animator
with two clips: **Idle**, scale 1, and **Bounce**, 0.2 seconds, scale 1 to 1.4 and back.
Add a `Bounce` Trigger and two transitions, and call `SetTrigger` from `AddCoin`, with
a hash ({{ref:animcode}}). How does `PlatformerGame` get hold of the icon's Animator?

## Chapter 11 — Start, Win and Try Again

**Goal:** the game itself becomes a state machine: a start panel with **Play**; a win
panel at the castle door, with the coins and the time; a lose panel with **Try Again**.
Every button starts the level again from the beginning, without loading anything: each
thing that can change puts itself back.

### Idea — the game's states

```
             Play                        the castle door
   Start ───────────→ Playing ───────────────────────────→ Won
                       ↑   │                                │
                       │   │  the knight's Dead clip ends   │
                       │   ↓                                │
                       │  Lost                              │
                       │   │                                │
                       └───┴──── Try Again, Play Again ─────┘
```

| State | Shows | Leaves when… |
| --- | --- | --- |
| **Start** | the start panel: the title, how to play, **Play** | **Play** is clicked: **Playing** |
| **Playing** | no panel: the game | the knight reaches the castle door: **Won**. His Dead clip ends: **Lost** |
| **Won** | the win panel: *You made it!*, the coins, the time, **Play Again** | **Play Again**: **Playing** |
| **Lost** | the lose panel: *The knight has fallen*, **Try Again** | **Try Again**: **Playing** |

It's the slime's pattern again ({{ref:statemachines}}): an `enum`, a `state` field, and
one `EnterState` that every change goes through. Its enter step shows the state's panel
and hides the others ({{ref:gameui}}). Chapter 12 adds a fifth state, **Paused**.

### Idea — one Restart for every button

**Play**, **Play Again** and **Try Again** all call the same method, `Restart`: put
everything back as it was, then enter **Playing**. On the first Play nothing has changed
yet, so putting it back does nothing, and one method serves all three buttons.

Loading the scene again would also start over, but scene loading is Level 4. Here, each
thing that can change has a method that puts it back:

| Thing | Changes during a run | Put back by |
| --- | --- | --- |
| knight | his place, his roll, his Animator | `ResetKnight` (Chapter 7) |
| his health | health, blinking, dead | `ResetHealth` (Chapter 9) |
| slimes | their place and state; hidden when squashed | `ResetSlime` (Chapter 9) |
| coins, apples | hidden when collected | `ResetCoin`, `ResetApple` (Chapter 9) |
| checkpoints | lit | `ResetCheckpoint` (Chapter 9) |
| the game | coins, time, respawn point, sky | `Restart` itself |

The game finds the slimes, pickups and checkpoints through three **group** objects,
`Enemies`, `Pickups` and `Checkpoints`, with `GetComponentsInChildren<Slime>(true)`. The
`true` means *hidden ones too*: a squashed slime or a collected coin is inactive, and
those are exactly the ones that need putting back.

### Idea — everyone asks the game

Before **Play**, and after a win or a loss, nothing should move. A property on the game,
`IsPlaying`, answers *are we in the Playing state?*, and three scripts ask it:

- the knight's `HasControl`: no running before **Play**, or after the end;
- the slime's `Update`: it stands still, wobbling, until the game is playing;
- the game's own `KnightFell`, `Win` and `Lose`: a slime landing on the knight just after
  he reaches the door can't turn a win into a loss.

### Do it — the groups

1. Create three empty GameObjects, `Enemies`, `Pickups` and `Checkpoints`, each at
   `(0, 0, 0)`.
2. In the Hierarchy, select every slime (click the first, Shift-click the last) and drag
   them onto `Enemies`. Drag every coin and apple onto `Pickups`, and both checkpoints
   onto `Checkpoints`.

A child keeps its place in the world when you drag it onto a parent at `(0, 0, 0)`:
nothing moves.

### Do it — the start panel

> **Watch out:** the **GameObject** menu always puts new UI straight onto the Canvas.
> To put a UI element **inside** another, right-click the parent in the Hierarchy and
> choose **UI (Canvas) → …** there.

1. **GameObject → UI (Canvas) → Panel**, named `Start Panel`. It covers the whole
   screen: set its **Color** to black, with **A** `140`, to dim the game behind it.
2. Right-click `Start Panel` → **UI (Canvas) → Image**, named `Window`: anchor
   middle-center, **Width** `640`, **Height** `340`, **Source Image** `UISprite`,
   **Image Type** **Sliced**, colour `#2B2440`, and **Scale** `(2, 2, 1)`. The standard
   buttons are small; scaling the window makes everything in it bigger at once.
3. Make these inside `Window`, right-clicking `Window` each time. Every text uses
   `PixelOperator8 SDF`, aligned **centre** and **middle**:

| Object | Type | Pos | Size | Settings |
| --- | --- | --- | --- | --- |
| `Title` | Text - TextMeshPro | (0, 105) | 600 × 70 | "Knight Run", size 48 |
| `How To Play` | Text - TextMeshPro | (0, 10) | 600 × 120 | four lines, below; size 17 |
| `Play Button` | Button - TextMeshPro | (0, −115) | 220 × 46 | colour `#E2A23B`; its text "Play", size 22, white |

The four lines of `How To Play` (press **Enter** between them):

```
Run: A and D, or the arrows
Jump: Space    Roll: Shift
Stomp on slimes, or roll into them.
Reach the castle door!
```

### Do it — the win and lose panels

1. Another **Panel**, named `Win Panel`, black with **A** `140`, and inside it a
   `Window` like the first one, but **Width** `560` and **Height** `330`. Inside this
   `Window`:

| Object | Type | Pos | Size | Settings |
| --- | --- | --- | --- | --- |
| `Win Text` | Text - TextMeshPro | (0, 40) | 520 × 220 | "You made it!", size 26 |
| `Play Again Button` | Button - TextMeshPro | (0, −115) | 220 × 46 | like Play; its text "Play Again" |

2. One more, `Lose Panel`, with a `Window` of **Width** `560` and **Height** `260`:

| Object | Type | Pos | Size | Settings |
| --- | --- | --- | --- | --- |
| `Title` | Text - TextMeshPro | (0, 45) | 520 × 100 | "The knight has fallen", size 30 |
| `Try Again Button` | Button - TextMeshPro | (0, −70) | 220 × 46 | like Play; its text "Try Again" |

The game shows and hides all three panels itself, as soon as it starts, so it doesn't
matter which you leave showing. Hide the win and lose panels anyway, by unticking the
box beside each name in the Inspector, so you can see the start panel while you work.

### Do it — a castle door, for now

The castle comes in Chapter 13. Until then, the door is at the end of the woods: an
invisible trigger to run into.

Create an empty GameObject, `Castle Door`, at `(124, 1.3, 0)`, just past the pumpkin.
Give it a **Box Collider 2D** with **Is Trigger** ticked and a **Size** of `(1.4, 2.6)`.

### Do it — the code

Five scripts, in this order.

1. Replace `PlatformerGame`:

```csharp
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Runs the game as a state machine: Start, Playing, Won and Lost. It
// counts the coins and the time, remembers the last checkpoint, shows each
// section's name and sky, and puts the whole level back on Restart.
public class PlatformerGame : MonoBehaviour
{
    public enum GameState { Start, Playing, Won, Lost }

    [SerializeField] KnightController knight;
    [SerializeField] KnightHealth knightHealth;
    [SerializeField] CameraFollow cameraFollow;
    [SerializeField] Camera mainCamera;
    [SerializeField] Transform enemies;
    [SerializeField] Transform pickups;
    [SerializeField] Transform checkpoints;
    [SerializeField] Section[] sections;
    [SerializeField] float skyChangeSpeed = 2f;
    [SerializeField] TMP_Text coinText;
    [SerializeField] TMP_Text sectionText;
    [SerializeField] GameObject startPanel;
    [SerializeField] Button playButton;
    [SerializeField] GameObject winPanel;
    [SerializeField] TMP_Text winText;
    [SerializeField] Button playAgainButton;
    [SerializeField] GameObject losePanel;
    [SerializeField] Button tryAgainButton;

    GameState state;
    int coins;
    int totalCoins;
    float playTime;
    Vector2 startPoint;
    Vector2 respawnPoint;
    int sectionIndex = -1;
    Coroutine sectionFade;

    public bool IsPlaying
    {
        get { return state == GameState.Playing; }
    }

    void OnEnable()
    {
        playButton.onClick.AddListener(Restart);
        playAgainButton.onClick.AddListener(Restart);
        tryAgainButton.onClick.AddListener(Restart);
    }

    void OnDisable()
    {
        playButton.onClick.RemoveListener(Restart);
        playAgainButton.onClick.RemoveListener(Restart);
        tryAgainButton.onClick.RemoveListener(Restart);
    }

    void Awake()
    {
        startPoint = knight.transform.position;
        respawnPoint = startPoint;
        totalCoins = pickups.GetComponentsInChildren<Coin>(true).Length;

        sectionText.text = "";
        mainCamera.backgroundColor = sections[0].SkyColour;
        UpdateCoinText();
        EnterState(GameState.Start);
    }

    void Update()
    {
        switch (state)
        {
            case GameState.Start:
                break;
            case GameState.Playing:
                playTime += Time.deltaTime;
                UpdateSection();
                break;
            case GameState.Won:
                break;
            case GameState.Lost:
                break;
        }

        // The sky eases towards the colour of the section the knight is in.
        if (sectionIndex >= 0)
        {
            Color sky = sections[sectionIndex].SkyColour;
            mainCamera.backgroundColor = Color.Lerp(mainCamera.backgroundColor, sky, skyChangeSpeed * Time.deltaTime);
        }
    }

    // The one place the game's state changes. Every state shows its own panel,
    // and hides the others; then the enter step does what that state needs.
    void EnterState(GameState next)
    {
        state = next;
        startPanel.SetActive(state == GameState.Start);
        winPanel.SetActive(state == GameState.Won);
        losePanel.SetActive(state == GameState.Lost);

        switch (state)
        {
            case GameState.Start:
                break;
            case GameState.Playing:
                break;
            case GameState.Won:
                winText.text = $"You made it!\n\nCoins: {coins} / {totalCoins}\nTime: {FormatTime(playTime)}";
                break;
            case GameState.Lost:
                break;
        }
    }

    // Puts everything back as it was at the start, then plays. Loading the
    // scene again would do the same: that waits for Level 4.
    public void Restart()
    {
        coins = 0;
        playTime = 0f;
        respawnPoint = startPoint;
        sectionIndex = -1;

        foreach (Slime slime in enemies.GetComponentsInChildren<Slime>(true))
        {
            slime.ResetSlime();
        }
        foreach (Coin coin in pickups.GetComponentsInChildren<Coin>(true))
        {
            coin.ResetCoin();
        }
        foreach (Apple apple in pickups.GetComponentsInChildren<Apple>(true))
        {
            apple.ResetApple();
        }
        foreach (Checkpoint checkpoint in checkpoints.GetComponentsInChildren<Checkpoint>(true))
        {
            checkpoint.ResetCheckpoint();
        }

        knight.ResetKnight(startPoint);
        knightHealth.ResetHealth();
        cameraFollow.SnapToTarget();
        mainCamera.backgroundColor = sections[0].SkyColour;
        UpdateCoinText();
        EnterState(GameState.Playing);
    }

    public void Win()
    {
        if (state == GameState.Playing)
        {
            EnterState(GameState.Won);
        }
    }

    public void Lose()
    {
        if (state == GameState.Playing)
        {
            EnterState(GameState.Lost);
        }
    }

    public void AddCoin()
    {
        coins++;
        UpdateCoinText();
    }

    public void SetRespawnPoint(Vector2 point)
    {
        respawnPoint = point;
    }

    // The knight fell in: back to the last checkpoint, and 1 health less.
    public void KnightFell()
    {
        if (state != GameState.Playing)
        {
            return;
        }
        knight.ResetKnight(respawnPoint);
        cameraFollow.SnapToTarget();
        knightHealth.FellInPit();
    }

    // Shows a section's name as the knight reaches it.
    void UpdateSection()
    {
        float x = knight.transform.position.x;
        int index = 0;
        for (int i = 0; i < sections.Length; i++)
        {
            if (x >= sections[i].StartX)
            {
                index = i;
            }
        }

        if (index != sectionIndex)
        {
            sectionIndex = index;
            if (sectionFade != null)
            {
                StopCoroutine(sectionFade);
            }
            sectionFade = StartCoroutine(ShowSectionName(sections[index].Title));
        }
    }

    IEnumerator ShowSectionName(string title)
    {
        sectionText.text = title;
        sectionText.alpha = 1f;
        yield return new WaitForSeconds(2f);
        for (float t = 0f; t < 1f; t += Time.deltaTime)
        {
            sectionText.alpha = 1f - t;
            yield return null;
        }
        sectionText.text = "";
    }

    void UpdateCoinText()
    {
        coinText.text = $"x {coins}";
    }

    // 161.4 seconds becomes "2:41".
    static string FormatTime(float seconds)
    {
        int whole = Mathf.FloorToInt(seconds);
        return $"{whole / 60}:{whole % 60:00}";
    }
}
```

2. Create `CastleDoor`, and attach it to `Castle Door`:

```csharp:CastleDoor.cs
using UnityEngine;

// The castle door at the end of the level. Walking into it wins.
public class CastleDoor : MonoBehaviour
{
    [SerializeField] PlatformerGame game;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out KnightController knight))
        {
            game.Win();
        }
    }
}
```

3. Replace `KnightHealth`: its `OnDeathFinished` tells the game now.

```csharp
using System.Collections;
using UnityEngine;

// The knight's health: 5 to start with. A slime knocks him back and makes him
// blink, and nothing can hurt him while he blinks. At 0 he falls, and when his
// Dead clip ends, the game is lost.
public class KnightHealth : MonoBehaviour
{
    public const int MaxHealth = 5;

    static readonly int HurtHash = Animator.StringToHash("Hurt");
    static readonly int DeadHash = Animator.StringToHash("Dead");

    [SerializeField] PlatformerGame game;
    [SerializeField] HealthBar healthBar;
    [SerializeField] Vector2 knockback = new Vector2(5f, 6f);
    [SerializeField] float stunSeconds = 0.25f;     // no control, while the knockback carries him
    [SerializeField] float blinkSeconds = 1f;

    Rigidbody2D body;
    Animator animator;
    SpriteRenderer spriteRenderer;
    KnightController controller;
    bool isBlinking;
    float stunnedUntil;

    public int Health { get; private set; } = MaxHealth;
    public bool IsDead { get; private set; }

    public bool IsStunned
    {
        get { return Time.time < stunnedUntil; }
    }

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        controller = GetComponent<KnightController>();
    }

    void Start()
    {
        healthBar.SetHealth(Health, MaxHealth);
    }

    // A slime hurt him. fromX is where the slime is, so he flies away from it.
    public void TakeDamage(int amount, float fromX)
    {
        // Nothing hurts him while he blinks or rolls, and a fallen knight
        // can't fall again.
        if (IsDead || isBlinking || controller.IsRolling)
        {
            return;
        }

        LoseHealth(amount);
        if (IsDead)
        {
            return;
        }

        float direction = transform.position.x < fromX ? -1f : 1f;
        body.linearVelocity = new Vector2(knockback.x * direction, knockback.y);
        stunnedUntil = Time.time + stunSeconds;
        animator.SetTrigger(HurtHash);
    }

    // He fell into water, goo or the moat. The game has already put him back
    // at the last checkpoint.
    public void FellInPit()
    {
        if (!IsDead)
        {
            LoseHealth(1);
        }
    }

    void LoseHealth(int amount)
    {
        Health = Mathf.Max(Health - amount, 0);
        healthBar.SetHealth(Health, MaxHealth);

        if (Health == 0)
        {
            IsDead = true;
            body.linearVelocity = new Vector2(0f, body.linearVelocity.y);
            animator.SetTrigger(DeadHash);
        }
        else
        {
            StartCoroutine(Blink());
        }
    }

    IEnumerator Blink()
    {
        isBlinking = true;
        float endTime = Time.time + blinkSeconds;
        while (Time.time < endTime)
        {
            spriteRenderer.enabled = !spriteRenderer.enabled;
            yield return new WaitForSeconds(0.1f);
        }
        spriteRenderer.enabled = true;
        isBlinking = false;
    }

    public void Heal(int amount)
    {
        Health = Mathf.Min(Health + amount, MaxHealth);
        healthBar.SetHealth(Health, MaxHealth);
    }

    // Animation Event: at the end of the Dead clip, once he has faded out.
    public void OnDeathFinished()
    {
        game.Lose();
    }

    public void ResetHealth()
    {
        StopAllCoroutines();
        Health = MaxHealth;
        IsDead = false;
        isBlinking = false;
        stunnedUntil = 0f;
        spriteRenderer.enabled = true;
        healthBar.SetHealth(Health, MaxHealth);
    }
}
```

4. Replace `Slime`: it waits unless the game is playing.

```csharp
using UnityEngine;

// A slime, run as a state machine. Each state's enter step tells the Animator
// which state it's in, through the State parameter, so the Animator follows
// the code. The purple slime is this same script, with other numbers.
[RequireComponent(typeof(Rigidbody2D))]
public class Slime : MonoBehaviour
{
    public enum State { Patrol, Chase, WindUp, Leap, Hurt, Dead }

    static readonly int StateHash = Animator.StringToHash("State");

    [SerializeField] PlatformerGame game;
    [SerializeField] KnightHealth knight;
    [SerializeField] LayerMask groundMask;
    [SerializeField] int maxHealth = 1;
    [SerializeField] float patrolSpeed = 1.5f;
    [SerializeField] float patrolDistance = 2f;     // how far it wanders from where it started, each way
    [SerializeField] float chaseSpeed = 2.5f;
    [SerializeField] float sightRange = 4f;
    [SerializeField] float leapRange = 1.2f;
    [SerializeField] Vector2 leapVelocity = new Vector2(4f, 6f);
    [SerializeField] Vector2 knockback = new Vector2(3f, 3f);
    [SerializeField] float hurtSeconds = 0.4f;

    Rigidbody2D body;
    Animator animator;
    SpriteRenderer spriteRenderer;
    Collider2D slimeCollider;
    Vector2 startPosition;
    State state;
    int health;
    float direction = -1f;      // -1 left, 1 right
    float stateStartTime;

    // A hurt or dead slime can't hurt the knight, and can't be hit again.
    public bool IsHarmless
    {
        get { return state == State.Hurt || state == State.Dead; }
    }

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        slimeCollider = GetComponent<Collider2D>();
        startPosition = transform.position;
    }

    void Start()
    {
        ResetSlime();
    }

    void Update()
    {
        // Before Play, after the end and in the pause menu, slimes wait.
        if (!game.IsPlaying)
        {
            Stop();
            return;
        }

        switch (state)
        {
            case State.Patrol:
                UpdatePatrol();
                break;
            case State.Chase:
                UpdateChase();
                break;
            case State.WindUp:
                break;                  // waits for the OnLeap Animation Event
            case State.Leap:
                UpdateLeap();
                break;
            case State.Hurt:
                UpdateHurt();
                break;
            case State.Dead:
                break;                  // waits for the OnDeathFinished Animation Event
        }

        // The slime's picture looks left, so it flips to look right.
        spriteRenderer.flipX = direction > 0f;
    }

    // The one place the state changes. The enter step runs once, as the
    // slime arrives in its new state.
    void EnterState(State next)
    {
        state = next;
        stateStartTime = Time.time;
        animator.SetInteger(StateHash, (int)state);

        switch (state)
        {
            case State.Patrol:
                break;
            case State.Chase:
                break;
            case State.WindUp:
                Stop();
                break;
            case State.Leap:
                body.linearVelocity = new Vector2(direction * leapVelocity.x, leapVelocity.y);
                break;
            case State.Hurt:
                break;
            case State.Dead:
                Stop();
                slimeCollider.enabled = false;
                body.simulated = false;
                break;
        }
    }

    void UpdatePatrol()
    {
        if (CanSeeKnight(sightRange))
        {
            EnterState(State.Chase);
            return;
        }

        // Turn round at either end of its patch of ground, or at an edge.
        bool isPastRight = direction > 0f && transform.position.x > startPosition.x + patrolDistance;
        bool isPastLeft = direction < 0f && transform.position.x < startPosition.x - patrolDistance;
        if (isPastRight || isPastLeft || !HasGroundAhead())
        {
            direction = -direction;
        }
        Move(patrolSpeed);
    }

    void UpdateChase()
    {
        // It gives up once the knight is well away.
        if (!CanSeeKnight(sightRange * 1.5f))
        {
            EnterState(State.Patrol);
            return;
        }

        float toKnight = knight.transform.position.x - transform.position.x;
        direction = toKnight < 0f ? -1f : 1f;

        if (Mathf.Abs(toKnight) <= leapRange && IsGrounded() && HasGroundAhead())
        {
            EnterState(State.WindUp);
        }
        else if (HasGroundAhead())
        {
            Move(chaseSpeed);
        }
        else
        {
            Stop();     // it never chases him off a ledge
        }
    }

    void UpdateLeap()
    {
        // Landed: a moment after take-off, it's standing on the ground again.
        if (Time.time > stateStartTime + 0.2f && IsGrounded())
        {
            EnterState(State.Chase);
        }
    }

    void UpdateHurt()
    {
        if (Time.time < stateStartTime + hurtSeconds)
        {
            return;
        }
        if (health > 0)
        {
            EnterState(State.Chase);
        }
        else
        {
            EnterState(State.Dead);
        }
    }

    // Stomped or rolled into. fromX is where the knight is, so it flies away from him.
    public void TakeHit(float fromX)
    {
        if (IsHarmless)
        {
            return;
        }
        health--;
        float away = transform.position.x < fromX ? -1f : 1f;
        body.linearVelocity = new Vector2(knockback.x * away, knockback.y);
        EnterState(State.Hurt);
    }

    // Animation Event: on the last frame of the WindUp clip.
    public void OnLeap()
    {
        // A stomp during the wind-up changes the state first: then there's no leap.
        if (state == State.WindUp)
        {
            EnterState(State.Leap);
        }
    }

    // Animation Event: at the end of the Dead clip, once it has melted and faded.
    public void OnDeathFinished()
    {
        gameObject.SetActive(false);
    }

    bool CanSeeKnight(float range)
    {
        if (knight.IsDead)
        {
            return false;
        }
        Vector2 toKnight = knight.transform.position - transform.position;
        return Mathf.Abs(toKnight.x) < range && Mathf.Abs(toKnight.y) < 1.5f;
    }

    bool IsGrounded()
    {
        Vector2 start = (Vector2)transform.position + new Vector2(0f, 0.1f);
        return Physics2D.Raycast(start, Vector2.down, 0.2f, groundMask).collider != null;
    }

    // Is there ground half a tile ahead, in the direction it's going?
    bool HasGroundAhead()
    {
        Vector2 start = (Vector2)transform.position + new Vector2(direction * 0.5f, 0.1f);
        return Physics2D.Raycast(start, Vector2.down, 0.6f, groundMask).collider != null;
    }

    void Move(float speed)
    {
        body.linearVelocity = new Vector2(direction * speed, body.linearVelocity.y);
    }

    void Stop()
    {
        body.linearVelocity = new Vector2(0f, body.linearVelocity.y);
    }

    // Back where it started, alive and patrolling: on Restart.
    public void ResetSlime()
    {
        gameObject.SetActive(true);
        body.simulated = true;
        body.position = startPosition;
        transform.position = startPosition;
        body.linearVelocity = Vector2.zero;
        slimeCollider.enabled = true;

        // The Dead clip fades it out. Put its colour back before Rebind
        // remembers it.
        spriteRenderer.color = Color.white;
        animator.Rebind();

        health = maxHealth;
        direction = -1f;
        EnterState(State.Patrol);
    }
}
```

5. Replace `KnightController`: `HasControl` asks the game too.

```csharp
using UnityEngine;
using UnityEngine.InputSystem;

// The knight: he runs, jumps and rolls with the keyboard, and tells his
// Animator what he's doing every frame.
[RequireComponent(typeof(Rigidbody2D))]
public class KnightController : MonoBehaviour
{
    // The Animator's parameters, turned into numbers once. Strings are slow to
    // look up, and a typo in a hash's name is easy to spot: it's written once.
    static readonly int SpeedHash = Animator.StringToHash("Speed");
    static readonly int VerticalSpeedHash = Animator.StringToHash("VerticalSpeed");
    static readonly int GroundedHash = Animator.StringToHash("Grounded");
    static readonly int RollHash = Animator.StringToHash("Roll");

    [SerializeField] PlatformerGame game;
    [SerializeField] Transform leftFoot;
    [SerializeField] Transform rightFoot;
    [SerializeField] LayerMask groundMask;
    [SerializeField] float runSpeed = 6f;
    [SerializeField] float jumpSpeed = 12f;
    [SerializeField] float rollSpeed = 9f;
    [SerializeField] float rollCooldown = 0.4f;     // seconds from the end of one roll to the next
    [SerializeField] float bounceSpeed = 9f;        // how high a stomp throws him
    [SerializeField] float groundCheckDistance = 0.15f;

    Rigidbody2D body;
    Animator animator;
    SpriteRenderer spriteRenderer;
    KnightHealth health;

    float moveInput;            // -1 left, 0 still, 1 right
    bool isGrounded;
    bool isFacingLeft;
    bool isRolling;
    float rollDirection;
    float nextRollTime;

    public bool IsRolling
    {
        get { return isRolling; }
    }

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        health = GetComponent<KnightHealth>();
    }

    void Update()
    {
        isGrounded = CheckGround();
        bool isJumpPressed = false;
        bool isRollPressed = false;

        moveInput = 0f;

        // The keyboard. A phone may have no keyboard, and then Keyboard.current is null.
        Keyboard keyboard = Keyboard.current;
        if (keyboard != null)
        {
            if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed)
            {
                moveInput -= 1f;
            }
            if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed)
            {
                moveInput += 1f;
            }
            if (keyboard.spaceKey.wasPressedThisFrame || keyboard.wKey.wasPressedThisFrame || keyboard.upArrowKey.wasPressedThisFrame)
            {
                isJumpPressed = true;
            }
            if (keyboard.leftShiftKey.wasPressedThisFrame || keyboard.rightShiftKey.wasPressedThisFrame || keyboard.jKey.wasPressedThisFrame)
            {
                isRollPressed = true;
            }
        }

        if (HasControl())
        {
            if (moveInput != 0f && !isRolling)
            {
                isFacingLeft = moveInput < 0f;
                spriteRenderer.flipX = isFacingLeft;
            }
            if (isJumpPressed && isGrounded && !isRolling)
            {
                Jump();
            }
            if (isRollPressed && isGrounded && !isRolling && Time.time >= nextRollTime)
            {
                StartRoll();
            }
        }
        else
        {
            moveInput = 0f;
        }

        // Run, or roll. While he's stunned, the knockback carries him instead.
        // A velocity is safe to set in Update: the Rigidbody keeps it until the
        // next physics step uses it.
        if (!health.IsStunned)
        {
            float speedX = moveInput * runSpeed;
            if (isRolling)
            {
                speedX = rollDirection * rollSpeed;
            }
            body.linearVelocity = new Vector2(speedX, body.linearVelocity.y);
        }

        animator.SetFloat(SpeedHash, Mathf.Abs(body.linearVelocity.x));
        animator.SetFloat(VerticalSpeedHash, body.linearVelocity.y);
        animator.SetBool(GroundedHash, isGrounded);
    }

    bool HasControl()
    {
        return game.IsPlaying && !health.IsDead && !health.IsStunned;
    }

    // Two short rays down from his feet, against the Ground layer only.
    // Moving up is never standing: that's a jump just starting.
    bool CheckGround()
    {
        if (body.linearVelocity.y > 0.01f)
        {
            return false;
        }
        RaycastHit2D left = Physics2D.Raycast(leftFoot.position, Vector2.down, groundCheckDistance, groundMask);
        RaycastHit2D right = Physics2D.Raycast(rightFoot.position, Vector2.down, groundCheckDistance, groundMask);
        return left.collider != null || right.collider != null;
    }

    void Jump()
    {
        body.linearVelocity = new Vector2(body.linearVelocity.x, jumpSpeed);
        isGrounded = false;
    }

    void StartRoll()
    {
        isRolling = true;
        rollDirection = isFacingLeft ? -1f : 1f;
        animator.SetTrigger(RollHash);
    }

    // A stomp throws him back up off the slime.
    public void Bounce()
    {
        body.linearVelocity = new Vector2(body.linearVelocity.x, bounceSpeed);
    }

    // Animation Event: on each frame of the Run clip where a foot lands.
    public void OnFootstep()
    {
        Debug.Log("Step");
    }

    // Animation Event: on the last frame of the Roll clip.
    public void OnRollFinished()
    {
        isRolling = false;
        nextRollTime = Time.time + rollCooldown;
    }

    // Back to a starting point, standing still and facing right: after a fall,
    // and on Restart.
    public void ResetKnight(Vector2 position)
    {
        body.position = position;
        transform.position = position;
        body.linearVelocity = Vector2.zero;

        // A fall can cut the Roll clip short, and then OnRollFinished never
        // comes. So the reset ends the roll itself.
        isRolling = false;
        nextRollTime = 0f;
        isFacingLeft = false;
        spriteRenderer.flipX = false;

        // The Dead clip fades him out. Put his colour back first: Rebind
        // remembers the colour he has now as the one to go back to.
        spriteRenderer.color = Color.white;
        animator.Rebind();
    }
}
```

Read `PlatformerGame` before you move on:

- `EnterState` shows a panel only in its own state: `state == GameState.Won` is true in
  **Won**, and false in every other.
- In `Update`, only **Playing** has work to do: count the time, and watch for a new
  section. The other states wait for a button.
- `Awake` counts the coins once, hidden ones too, for the win panel's `Coins: 17 / 20`.
- `Restart` puts back every slime, coin, apple and checkpoint, then the knight, his
  health, the camera and the sky, and enters **Playing**. `sectionIndex = -1` makes the
  first section's name show again.
- `FormatTime` turns seconds into minutes and seconds: `whole / 60` is the whole
  minutes, `whole % 60` the seconds left over, and `:00` writes them with two digits.

### Do it — wire it up

1. Select `Platformer Game`, and drag each object into the field of the same name:
   `Enemies`, `Pickups`, `Checkpoints`, `Start Panel`, `Play Button`, `Win Panel`,
   `Win Text`, `Play Again Button`, `Lose Panel` and `Try Again Button`.
2. Select `Castle Door`, and drag `Platformer Game` into its **Game**.
3. Select `Knight`, and drag `Platformer Game` into **Game** on both **Knight Health**
   and **Knight Controller**.
4. Open `Enemies`, select every slime, and drag `Platformer Game` into **Game**.

### Test it

1. Play. The start panel shows, and behind it nothing moves but the slimes' wobble.
   Press the arrow keys: the knight stays put. Click **Play**.
2. *The Meadow* shows. Collect some coins, light the first checkpoint, and squash a
   slime.
3. Fall in the water five times. The knight falls over and fades, and the lose panel
   shows. Click **Try Again**: the coins are back, the squashed slime too, the checkpoint
   is grey again, the count says `x 0`, and the knight is at the start.
4. Play through to the end of the woods, past the pumpkin: *You made it!*, with your
   coins out of 20, and your time.
5. Click **Play Again**, and win again, faster.

### Challenge

Add a best time to the win panel: `Best: 1:52`. Keep the fastest win in a field, and
change it only when a new win is faster. What should it start as, so that the first win
always counts as the best? (Keeping it after the game closes needs `PlayerPrefs`, in
Level 4. For now, it lasts until you stop playing.)

## Chapter 12 — Pause, and Play on a Phone

**Goal:** **Esc**, **P** or a pause button stops the whole game, in mid-air if need be,
and shows a pause panel with **Resume**, **Restart** and a volume slider. And on a
touchscreen, four round buttons: left and right to hold, roll and jump to tap, with
two fingers at once.

### Idea — a fifth state

```
              Esc, P, or the II button
   Playing ───────────────────────────→ Paused
      ↑                                   │
      └──── Esc, P, or Resume ────────────┘
             (Restart, too: from the start)
```

**Paused**'s enter step sets `Time.timeScale` to 0; **Playing**'s and **Start**'s set it
back to 1 ({{ref:gameui}}). Since every change goes through `EnterState`, no button can
forget: **Restart** on the pause panel enters **Playing**, and so starts time again.

The pause button shows in **Playing** only: on a panel, there's nothing to pause.

### Idea — what stops in this game

| While paused… | |
| --- | --- |
| the knight and the slimes, their Rigidbodies | stop where they are, even in mid-air |
| every Animator: knight, slimes, coins, signs | freezes on its frame |
| the section name's two seconds, and the knight's blinking | wait |
| the time on the win panel | stops: `playTime` adds `Time.deltaTime`, which is 0 |
| `Update` | keeps running, so `PlatformerGame` can read **Esc** and **P** |
| the pause panel's buttons and slider | work |

### Idea — touch buttons that you hold

A UI **Button** clicks when the finger comes **off** it. That's right for **Play**, but
running needs to know when a finger goes down and when it comes off again. An **Event
Trigger** component does that: it has a list of events, such as **PointerDown** and
**PointerUp**, and each event calls the methods you choose in the Inspector, as a
Button's **On Click** does.

| Button | Event | Calls |
| --- | --- | --- |
| `<` | **PointerDown** | `SetLeftHeld`, with the box ticked: `true` |
| | **PointerUp** | `SetLeftHeld`, unticked: `false` |
| | **PointerExit**: the finger slides off | `SetLeftHeld`, unticked: `false` |
| `>` | the same three | `SetRightHeld` |
| **ROLL** | **PointerDown** | `PressRoll` |
| **JUMP** | **PointerDown** | `PressJump` |

Each touch button follows its own finger, so the left thumb can hold `>` while the right
one taps **JUMP**.

`PressJump` doesn't jump. It sets `isJumpQueued`, and the next `Update` uses it, and
clears it, along with the keys. A tap gives one jump, exactly as `wasPressedThisFrame`
does, and the jump is still only allowed on the ground.

The buttons only show on a device with a touchscreen: `Touchscreen.current` is `null`
on a computer with none.

### Do it — the pause button

**GameObject → UI (Canvas) → Button - TextMeshPro**, named `Pause Button`. Anchor it
**top-right** (with Shift + Alt), **Pos** `(-30, -30)`, **Width** `110`, **Height**
`110`, colour `#1C1F2B` with **A** `191`. Its text: `II`, in `PixelOperator8 SDF`, size
`55`, white.

### Do it — the pause panel

1. A **Panel**, named `Pause Panel`, black with **A** `140`, and inside it a `Window`
   like the others: **Width** `460`, **Height** `330`, `UISprite` **Sliced**,
   `#2B2440`, **Scale** `(2, 2, 1)`.
2. Inside the `Window`:

| Object | Type | Pos | Size | Settings |
| --- | --- | --- | --- | --- |
| `Title` | Text - TextMeshPro | (0, 115) | 420 × 60 | "Paused", size 40 |
| `Resume Button` | Button - TextMeshPro | (0, 45) | 220 × 46 | like Play; its text "Resume" |
| `Restart Button` | Button - TextMeshPro | (0, −15) | 220 × 46 | like Play; its text "Restart" |
| `Volume Label` | Text - TextMeshPro | (−120, −90) | 140 × 30 | "Volume", size 18 |
| `Volume Slider` | Slider | (60, −90) | 220 × 20 | **Value** `1` |

3. Hide `Pause Panel`.

### Do it — the touch buttons

1. Right-click **Canvas** → **Create Empty**, named `Touch Controls`. In the anchor
   presets, hold **Shift + Alt** and click the bottom-right one, **stretch** in both
   directions, and set **Left**, **Top**, **Right** and **Bottom** to `0`: it covers
   the screen, and holds the four buttons.
2. Right-click `Touch Controls` → **UI (Canvas) → Image**, four times:

| Object | Anchor | Pos | Label | Label size |
| --- | --- | --- | --- | --- |
| `Left Button` | bottom-left | (60, 60) | `<` | 110 |
| `Right Button` | bottom-left | (290, 60) | `>` | 110 |
| `Roll Button` | bottom-right | (−290, 60) | `ROLL` | 44 |
| `Jump Button` | bottom-right | (−60, 60) | `JUMP` | 44 |

3. Give each **Width** and **Height** `200`, **Source Image** `Knob` (another of Unity's
   own sprites: a circle), and the colour white with **A** `77`, see-through. Leave
   **Raycast Target** ticked on these four: they take presses.
4. Inside each, right-click → **UI (Canvas) → Text - TextMeshPro**, named `Label`:
   **Pos** `(0, 0)`, 200 × 200, its label from the table in `PixelOperator8 SDF`, white,
   centre and middle, and **Raycast Target** unticked, so the presses go through it to
   the button.

### Do it — the code

1. Replace `PlatformerGame`:

```csharp
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

// Runs the game as a state machine: Start, Playing, Paused, Won and Lost. It
// counts the coins and the time, remembers the last checkpoint, shows each
// section's name and sky, and puts the whole level back on Restart.
public class PlatformerGame : MonoBehaviour
{
    public enum GameState { Start, Playing, Paused, Won, Lost }

    [SerializeField] KnightController knight;
    [SerializeField] KnightHealth knightHealth;
    [SerializeField] CameraFollow cameraFollow;
    [SerializeField] Camera mainCamera;
    [SerializeField] Transform enemies;
    [SerializeField] Transform pickups;
    [SerializeField] Transform checkpoints;
    [SerializeField] Section[] sections;
    [SerializeField] float skyChangeSpeed = 2f;
    [SerializeField] TMP_Text coinText;
    [SerializeField] TMP_Text sectionText;
    [SerializeField] GameObject touchControls;
    [SerializeField] GameObject startPanel;
    [SerializeField] Button playButton;
    [SerializeField] Button pauseButton;
    [SerializeField] GameObject pausePanel;
    [SerializeField] GameObject winPanel;
    [SerializeField] TMP_Text winText;
    [SerializeField] Button playAgainButton;
    [SerializeField] GameObject losePanel;
    [SerializeField] Button tryAgainButton;

    GameState state;
    int coins;
    int totalCoins;
    float playTime;
    Vector2 startPoint;
    Vector2 respawnPoint;
    int sectionIndex = -1;
    Coroutine sectionFade;

    public bool IsPlaying
    {
        get { return state == GameState.Playing; }
    }

    void OnEnable()
    {
        playButton.onClick.AddListener(Restart);
        pauseButton.onClick.AddListener(Pause);
        playAgainButton.onClick.AddListener(Restart);
        tryAgainButton.onClick.AddListener(Restart);
    }

    void OnDisable()
    {
        playButton.onClick.RemoveListener(Restart);
        pauseButton.onClick.RemoveListener(Pause);
        playAgainButton.onClick.RemoveListener(Restart);
        tryAgainButton.onClick.RemoveListener(Restart);
    }

    void Awake()
    {
        startPoint = knight.transform.position;
        respawnPoint = startPoint;
        totalCoins = pickups.GetComponentsInChildren<Coin>(true).Length;

        // The touch buttons only show on a touchscreen.
        touchControls.SetActive(Touchscreen.current != null);
        sectionText.text = "";
        mainCamera.backgroundColor = sections[0].SkyColour;
        UpdateCoinText();
        EnterState(GameState.Start);
    }

    void Update()
    {
        switch (state)
        {
            case GameState.Start:
                break;
            case GameState.Playing:
                playTime += Time.deltaTime;
                UpdateSection();
                if (WasPausePressed())
                {
                    Pause();
                }
                break;
            case GameState.Paused:
                if (WasPausePressed())
                {
                    Resume();
                }
                break;
            case GameState.Won:
                break;
            case GameState.Lost:
                break;
        }

        // The sky eases towards the colour of the section the knight is in.
        if (sectionIndex >= 0)
        {
            Color sky = sections[sectionIndex].SkyColour;
            mainCamera.backgroundColor = Color.Lerp(mainCamera.backgroundColor, sky, skyChangeSpeed * Time.deltaTime);
        }
    }

    // The one place the game's state changes. Every state shows its own panel,
    // and hides the others; then the enter step does what that state needs.
    void EnterState(GameState next)
    {
        state = next;
        startPanel.SetActive(state == GameState.Start);
        pausePanel.SetActive(state == GameState.Paused);
        winPanel.SetActive(state == GameState.Won);
        losePanel.SetActive(state == GameState.Lost);
        pauseButton.gameObject.SetActive(state == GameState.Playing);

        switch (state)
        {
            case GameState.Start:
                Time.timeScale = 1f;
                break;
            case GameState.Playing:
                Time.timeScale = 1f;
                break;
            case GameState.Paused:
                Time.timeScale = 0f;    // physics, Animators and timers all stop
                break;
            case GameState.Won:
                winText.text = $"You made it!\n\nCoins: {coins} / {totalCoins}\nTime: {FormatTime(playTime)}";
                break;
            case GameState.Lost:
                break;
        }
    }

    // Puts everything back as it was at the start, then plays. Loading the
    // scene again would do the same: that waits for Level 4.
    public void Restart()
    {
        coins = 0;
        playTime = 0f;
        respawnPoint = startPoint;
        sectionIndex = -1;

        foreach (Slime slime in enemies.GetComponentsInChildren<Slime>(true))
        {
            slime.ResetSlime();
        }
        foreach (Coin coin in pickups.GetComponentsInChildren<Coin>(true))
        {
            coin.ResetCoin();
        }
        foreach (Apple apple in pickups.GetComponentsInChildren<Apple>(true))
        {
            apple.ResetApple();
        }
        foreach (Checkpoint checkpoint in checkpoints.GetComponentsInChildren<Checkpoint>(true))
        {
            checkpoint.ResetCheckpoint();
        }

        knight.ResetKnight(startPoint);
        knightHealth.ResetHealth();
        cameraFollow.SnapToTarget();
        mainCamera.backgroundColor = sections[0].SkyColour;
        UpdateCoinText();
        EnterState(GameState.Playing);
    }

    public void Pause()
    {
        if (state == GameState.Playing)
        {
            EnterState(GameState.Paused);
        }
    }

    public void Resume()
    {
        if (state == GameState.Paused)
        {
            EnterState(GameState.Playing);
        }
    }

    public void Win()
    {
        if (state == GameState.Playing)
        {
            EnterState(GameState.Won);
        }
    }

    public void Lose()
    {
        if (state == GameState.Playing)
        {
            EnterState(GameState.Lost);
        }
    }

    public void AddCoin()
    {
        coins++;
        UpdateCoinText();
    }

    public void SetRespawnPoint(Vector2 point)
    {
        respawnPoint = point;
    }

    // The knight fell in: back to the last checkpoint, and 1 health less.
    public void KnightFell()
    {
        if (state != GameState.Playing)
        {
            return;
        }
        knight.ResetKnight(respawnPoint);
        cameraFollow.SnapToTarget();
        knightHealth.FellInPit();
    }

    // Shows a section's name as the knight reaches it.
    void UpdateSection()
    {
        float x = knight.transform.position.x;
        int index = 0;
        for (int i = 0; i < sections.Length; i++)
        {
            if (x >= sections[i].StartX)
            {
                index = i;
            }
        }

        if (index != sectionIndex)
        {
            sectionIndex = index;
            if (sectionFade != null)
            {
                StopCoroutine(sectionFade);
            }
            sectionFade = StartCoroutine(ShowSectionName(sections[index].Title));
        }
    }

    IEnumerator ShowSectionName(string title)
    {
        sectionText.text = title;
        sectionText.alpha = 1f;
        yield return new WaitForSeconds(2f);
        for (float t = 0f; t < 1f; t += Time.deltaTime)
        {
            sectionText.alpha = 1f - t;
            yield return null;
        }
        sectionText.text = "";
    }

    bool WasPausePressed()
    {
        Keyboard keyboard = Keyboard.current;
        return keyboard != null && (keyboard.escapeKey.wasPressedThisFrame || keyboard.pKey.wasPressedThisFrame);
    }

    void UpdateCoinText()
    {
        coinText.text = $"x {coins}";
    }

    // 161.4 seconds becomes "2:41".
    static string FormatTime(float seconds)
    {
        int whole = Mathf.FloorToInt(seconds);
        return $"{whole / 60}:{whole % 60:00}";
    }
}
```

2. Create `PauseMenu`, and attach it to `Pause Panel`:

```csharp:PauseMenu.cs
using UnityEngine;
using UnityEngine.UI;

// The pause panel: Resume, Restart and the volume. Its buttons are connected
// when the panel opens (OnEnable), and disconnected when it closes (OnDisable).
public class PauseMenu : MonoBehaviour
{
    [SerializeField] PlatformerGame game;
    [SerializeField] Button resumeButton;
    [SerializeField] Button restartButton;
    [SerializeField] Slider volumeSlider;

    void OnEnable()
    {
        volumeSlider.SetValueWithoutNotify(AudioListener.volume);
        resumeButton.onClick.AddListener(game.Resume);
        restartButton.onClick.AddListener(game.Restart);
        volumeSlider.onValueChanged.AddListener(OnVolumeChanged);
    }

    void OnDisable()
    {
        resumeButton.onClick.RemoveListener(game.Resume);
        restartButton.onClick.RemoveListener(game.Restart);
        volumeSlider.onValueChanged.RemoveListener(OnVolumeChanged);
    }

    void OnVolumeChanged(float value)
    {
        AudioListener.volume = value;
    }
}
```

3. Replace `KnightController`:

```csharp
using UnityEngine;
using UnityEngine.InputSystem;

// The knight: he runs, jumps and rolls, with the keyboard or the touch
// buttons, and tells his Animator what he's doing every frame.
[RequireComponent(typeof(Rigidbody2D))]
public class KnightController : MonoBehaviour
{
    // The Animator's parameters, turned into numbers once. Strings are slow to
    // look up, and a typo in a hash's name is easy to spot: it's written once.
    static readonly int SpeedHash = Animator.StringToHash("Speed");
    static readonly int VerticalSpeedHash = Animator.StringToHash("VerticalSpeed");
    static readonly int GroundedHash = Animator.StringToHash("Grounded");
    static readonly int RollHash = Animator.StringToHash("Roll");

    [SerializeField] PlatformerGame game;
    [SerializeField] Transform leftFoot;
    [SerializeField] Transform rightFoot;
    [SerializeField] LayerMask groundMask;
    [SerializeField] float runSpeed = 6f;
    [SerializeField] float jumpSpeed = 12f;
    [SerializeField] float rollSpeed = 9f;
    [SerializeField] float rollCooldown = 0.4f;     // seconds from the end of one roll to the next
    [SerializeField] float bounceSpeed = 9f;        // how high a stomp throws him
    [SerializeField] float groundCheckDistance = 0.15f;

    Rigidbody2D body;
    Animator animator;
    SpriteRenderer spriteRenderer;
    KnightHealth health;

    float moveInput;            // -1 left, 0 still, 1 right
    bool isGrounded;
    bool isFacingLeft;
    bool isRolling;
    float rollDirection;
    float nextRollTime;
    bool isLeftHeld;            // the touch buttons
    bool isRightHeld;
    bool isJumpQueued;
    bool isRollQueued;

    public bool IsRolling
    {
        get { return isRolling; }
    }

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        health = GetComponent<KnightHealth>();
    }

    void Update()
    {
        isGrounded = CheckGround();

        // The touch buttons only queue a jump or a roll. Use them up now.
        bool isJumpPressed = isJumpQueued;
        bool isRollPressed = isRollQueued;
        isJumpQueued = false;
        isRollQueued = false;

        moveInput = 0f;
        if (isLeftHeld)
        {
            moveInput -= 1f;
        }
        if (isRightHeld)
        {
            moveInput += 1f;
        }

        // The keyboard. A phone may have no keyboard, and then Keyboard.current is null.
        Keyboard keyboard = Keyboard.current;
        if (keyboard != null)
        {
            if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed)
            {
                moveInput -= 1f;
            }
            if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed)
            {
                moveInput += 1f;
            }
            if (keyboard.spaceKey.wasPressedThisFrame || keyboard.wKey.wasPressedThisFrame || keyboard.upArrowKey.wasPressedThisFrame)
            {
                isJumpPressed = true;
            }
            if (keyboard.leftShiftKey.wasPressedThisFrame || keyboard.rightShiftKey.wasPressedThisFrame || keyboard.jKey.wasPressedThisFrame)
            {
                isRollPressed = true;
            }
        }
        moveInput = Mathf.Clamp(moveInput, -1f, 1f);

        if (HasControl())
        {
            if (moveInput != 0f && !isRolling)
            {
                isFacingLeft = moveInput < 0f;
                spriteRenderer.flipX = isFacingLeft;
            }
            if (isJumpPressed && isGrounded && !isRolling)
            {
                Jump();
            }
            if (isRollPressed && isGrounded && !isRolling && Time.time >= nextRollTime)
            {
                StartRoll();
            }
        }
        else
        {
            moveInput = 0f;
        }

        // Run, or roll. While he's stunned, the knockback carries him instead.
        // A velocity is safe to set in Update: the Rigidbody keeps it until the
        // next physics step uses it.
        if (!health.IsStunned)
        {
            float speedX = moveInput * runSpeed;
            if (isRolling)
            {
                speedX = rollDirection * rollSpeed;
            }
            body.linearVelocity = new Vector2(speedX, body.linearVelocity.y);
        }

        animator.SetFloat(SpeedHash, Mathf.Abs(body.linearVelocity.x));
        animator.SetFloat(VerticalSpeedHash, body.linearVelocity.y);
        animator.SetBool(GroundedHash, isGrounded);
    }

    bool HasControl()
    {
        return game.IsPlaying && !health.IsDead && !health.IsStunned;
    }

    // Two short rays down from his feet, against the Ground layer only.
    // Moving up is never standing: that's a jump just starting.
    bool CheckGround()
    {
        if (body.linearVelocity.y > 0.01f)
        {
            return false;
        }
        RaycastHit2D left = Physics2D.Raycast(leftFoot.position, Vector2.down, groundCheckDistance, groundMask);
        RaycastHit2D right = Physics2D.Raycast(rightFoot.position, Vector2.down, groundCheckDistance, groundMask);
        return left.collider != null || right.collider != null;
    }

    void Jump()
    {
        body.linearVelocity = new Vector2(body.linearVelocity.x, jumpSpeed);
        isGrounded = false;
    }

    void StartRoll()
    {
        isRolling = true;
        rollDirection = isFacingLeft ? -1f : 1f;
        animator.SetTrigger(RollHash);
    }

    // A stomp throws him back up off the slime.
    public void Bounce()
    {
        body.linearVelocity = new Vector2(body.linearVelocity.x, bounceSpeed);
    }

    // Animation Event: on each frame of the Run clip where a foot lands.
    public void OnFootstep()
    {
        Debug.Log("Step");
    }

    // Animation Event: on the last frame of the Roll clip.
    public void OnRollFinished()
    {
        isRolling = false;
        nextRollTime = Time.time + rollCooldown;
    }

    // The touch buttons call these, through their Event Triggers.
    public void SetLeftHeld(bool isHeld)
    {
        isLeftHeld = isHeld;
    }

    public void SetRightHeld(bool isHeld)
    {
        isRightHeld = isHeld;
    }

    public void PressJump()
    {
        isJumpQueued = true;
    }

    public void PressRoll()
    {
        isRollQueued = true;
    }

    // Back to a starting point, standing still and facing right: after a fall,
    // and on Restart.
    public void ResetKnight(Vector2 position)
    {
        body.position = position;
        transform.position = position;
        body.linearVelocity = Vector2.zero;

        // A fall can cut the Roll clip short, and then OnRollFinished never
        // comes. So the reset ends the roll itself.
        isRolling = false;
        nextRollTime = 0f;
        isFacingLeft = false;
        spriteRenderer.flipX = false;

        // The Dead clip fades him out. Put his colour back first: Rebind
        // remembers the colour he has now as the one to go back to.
        spriteRenderer.color = Color.white;
        animator.Rebind();
    }
}
```

Read it before you move on:

- `WasPausePressed` reads two keys. **Playing** pauses on them; **Paused** resumes on
  them. Both happen in `Update`, which still runs at a time scale of 0.
- `Pause` works only from **Playing**, and `Resume` only from **Paused**, like `Win` and
  `Lose`.
- `PauseMenu` connects its buttons in `OnEnable`, when the panel shows, and disconnects
  them in `OnDisable`, when it hides ({{ref:gameui}}). `SetValueWithoutNotify` moves
  the slider to the current volume without calling `OnVolumeChanged`.
- In the knight's `Update`, the held touch buttons add to `moveInput` like the keys, and
  `Mathf.Clamp` keeps it between −1 and 1, even with a key and a button held at once.

### Do it — wire it up

1. Select `Platformer Game`, and drag `Touch Controls`, `Pause Button` and
   `Pause Panel` into their fields.
2. Select `Pause Panel`. Drag `Platformer Game`, `Resume Button`, `Restart Button` and
   `Volume Slider` into the **Pause Menu**'s fields.
3. Select `Left Button`, and **Add Component → Event Trigger**. Click **Add New Event
   Type → PointerDown**. Under it, click **+**, drag `Knight` into the object box, and
   pick **KnightController → SetLeftHeld (bool)** from the function list. Tick the box
   that appears: `true`.
4. Add **PointerUp** and **PointerExit** the same way, each calling **SetLeftHeld**
   with the box unticked.
5. Do the same for `Right Button`, with **SetRightHeld**.
6. `Roll Button`: an Event Trigger with **PointerDown** only, calling **PressRoll**.
   `Jump Button`: **PointerDown**, calling **PressJump**.

### Test it

1. Play, and click **Play**. Press **Esc**: the pause panel. The slimes freeze in
   mid-wobble, and the coins stop spinning. Press **Esc** again: the game carries on.
2. Jump, and press **P** at the top of the jump: the knight hangs in the air. Click
   **Resume**: he comes down.
3. Pause, and click **Restart**: the level starts again, and moves. The pause button
   hides while a panel shows.
4. The volume slider has nothing to turn down yet: the sounds come in Chapter 13.
5. Without a touchscreen, the touch buttons don't show. To see them, switch the Game
   view's drop-down at its top-left from **Game** to **Simulator**, pick a phone, and
   rotate it sideways with the **Rotate** button. Press Play: the four buttons show,
   and the mouse is a finger now. Hold `>` to run, and tap **JUMP**. A mouse is only
   one finger: two at once must wait for a real phone, in Chapter 15.

### Challenge

On a phone, a call or a message can take the player out of the game. Unity calls
`OnApplicationFocus(bool hasFocus)` on every MonoBehaviour when the game loses the
focus, and again when it gets it back. Pause the game when it loses the focus, but
don't resume it by itself when the focus comes back. Why not? Test it by clicking
another program's window while the game plays.

## Chapter 13 — The Castle Walls, and Sound

**Goal:** the third section, painted step by step: grey stone with snow on top, a moat
in three places, a staircase, and the keep with its dark doorway, where the castle door
moves to. Ten more coins, five more slimes and one more apple. Then sound: steps, jumps,
rolls, hurts, coins, checkpoints, squashes, the win, and music.

### Idea — the castle's map

The castle starts at column 126, where the woods end. `~` is the moat, `w` the keep's
wall, `o` its doorway, and `D` where the castle door goes. The ground climbs: three
blocks over the moat, then a staircase up to the keep.

```
           130       140       150       160       170       180
           |         |         |         |         |         |
  10   .........................................................w.w.w.
   9   .........................................................wwwwww
   8   .........................................................wwwwww
   7   .........................................................wwooww
   6   .........................................................wwooww
   5   ...........................C...........CC............C..pwwDoww
   4   ...............C.................C................C....########
   3   ...................C...C.......b..p.................###########
   2   ..........b..........p.......#########.....b.s.A.##############
   1   ....C.########...#########...#########....#####################
   0   .T.s..########...#########...#########....#####################
  -1   ##############...#########...#########....#####################
  -2   ##############~~~#########~~~#########~~~~#####################
  -3   ##############~~~#########~~~#########~~~~#####################
```

| Thing | Tiles in the palette |
| --- | --- |
| stone | column 6, row 1 |
| stone with snow on top | column 7, row 1 |
| stone bricks | column 8, row 1 |
| the moat, with its surface | column 6, row 9 |
| the moat | column 6, row 10 |
| a teal tree | column 6, rows 5 (trunk), 4 and 3 |
| a teal bush | column 6, row 7 |
| the doorway's dark | column 0, row 15 |

### Do it — paint the ground

On the **Ground** Tilemap:

1. With the stone, **Box Fill** each piece of ground, from row −3 up to its top row:

| Columns | Up to row |
| --- | --- |
| 126 to 131 | −1 |
| 132 to 139 | 1 |
| 143 to 151 | 1 |
| 155 to 163 | 2 |
| 168 to 174 | 1 |
| 175 to 177 | 2 |
| 178 to 180 | 3 |
| 181 to 188 | 4 |

2. With the snowy stone, paint over the top row of each: row −1 over columns 126 to
   131; row 1 over 132 to 139, 143 to 151 and 168 to 174; row 2 over 155 to 163 and 175
   to 177; row 3 over 178 to 180; and row 4 over 181 to 188.

### Do it — the moat

On the **Hazards** Tilemap: the moat with its surface on row −2, and the plain moat on
row −3, over columns 140 to 142, 152 to 154, and 164 to 167. The `KillZone` on
`Hazards` makes it deadly, like the water and the goo.

### Do it — decoration

On the **Decoration** Tilemap: a teal tree with its trunk at (127, 0), and teal bushes at
(136, 2), (157, 3) and (169, 2).

### Do it — the keep

The keep goes on **Decoration** too, like a tree: it has no collider, and the knight
walks in front of it, on the top step.

1. With the stone bricks, **Box Fill** columns 183 to 188, rows 5 to 8.
2. Paint the top of the wall, row 9: stone bricks at columns 183, 185 and 187, and snowy
   stone at 184, 186 and 188.
3. Paint the battlements, row 10: snowy stone at columns 183, 185 and 187.
4. With the doorway's dark, **Box Fill** columns 185 and 186, rows 5 to 7, over the
   bricks.

### Do it — the castle's things

Drag each prefab onto its group in the Hierarchy, so it lands inside it, and type its
position.

1. Ten coins, in `Pickups`: (130.5, 1.5), (141.5, 4.5), (145.5, 3.5), (149.5, 3.5),
   (153.5, 5.5), (159.5, 4.5), (165.5, 5.5), (166.5, 5.5), (176.5, 4.5) and
   (179.5, 5.5). The ones over the moat are for brave jumpers.
2. An apple, in `Pickups`: (173.5, 2.5).
3. Five slimes, in `Enemies`: green ones at (129.5, 0) and (171.5, 2), and purple ones
   at (147.5, 2), (160.5, 3) and (182.5, 5), guarding the door.
4. Select the ten new coins and drag `Platformer Game` into **Game**. Select the five new
   slimes and drag `Platformer Game` into **Game** and `Knight` into **Knight**.
5. Select `Castle Door`, and move it to `(186, 6.3, 0)`: in front of the doorway, at
   the top of the stairs.

### Idea — every sound is a one-shot

An **Audio Source** plays sounds; an **Audio Clip** is a sound. `PlayOneShot(clip)`
plays a clip once on a source, without cutting off a sound that's already playing on
it: grab three coins in quick succession, and you hear all three.

| Sound | File | Played by | When |
| --- | --- | --- | --- |
| jump | `jump` | `KnightController` | in `Jump` |
| step | `tap`, at 0.4 | `KnightController` | in `OnFootstep`, the Run clip's event, if he's on the ground |
| roll | `tap` | `KnightController` | in `StartRoll` |
| hurt | `hurt` | `KnightHealth` | in `LoseHealth`: slimes and pits |
| heal | `power_up` | `KnightHealth` | in `Heal` |
| squash | `explosion` | `Slime` | in Dead's enter step |
| coin | `coin` | `PlatformerGame` | in `AddCoin` |
| checkpoint | `power_up` | `PlatformerGame` | in `SetRespawnPoint` |
| win | `power_up` | `PlatformerGame` | in Won's enter step |
| music | `time_for_adventure` | a second Audio Source on `Platformer Game` | from the start, round and round |

The music needs no code at all: an Audio Source with **Play On Awake** and **Loop**
ticked plays from the start, for ever.

### Do it — the Audio Sources

1. Select `Knight`, **Add Component → Audio Source**, and untick **Play On Awake**.
2. Double-click the `Slime` prefab in `Assets/Prefabs` to open it, add an **Audio
   Source** with **Play On Awake** unticked, and go back to the scene. Do the same for
   `Purple Slime`. Every slime in the level gets one.
3. Select `Platformer Game`, and add **two** Audio Sources. Untick **Play On Awake** on
   the first: it plays the game's sounds. On the second, the music: set **Audio
   Generator** (in earlier versions of Unity 6, **Audio Resource**), the sound it plays,
   to `time_for_adventure`. Leave **Play On Awake** ticked, tick **Loop**, and set
   **Volume** to `0.5`.

### Do it — the final scripts

Replace the four scripts that make sounds. These are their final versions.

1. `KnightController`:

```csharp:KnightController.cs
using UnityEngine;
using UnityEngine.InputSystem;

// The knight: he runs, jumps and rolls, with the keyboard or the touch
// buttons, and tells his Animator what he's doing every frame.
[RequireComponent(typeof(Rigidbody2D))]
public class KnightController : MonoBehaviour
{
    // The Animator's parameters, turned into numbers once. Strings are slow to
    // look up, and a typo in a hash's name is easy to spot: it's written once.
    static readonly int SpeedHash = Animator.StringToHash("Speed");
    static readonly int VerticalSpeedHash = Animator.StringToHash("VerticalSpeed");
    static readonly int GroundedHash = Animator.StringToHash("Grounded");
    static readonly int RollHash = Animator.StringToHash("Roll");

    [SerializeField] PlatformerGame game;
    [SerializeField] Transform leftFoot;
    [SerializeField] Transform rightFoot;
    [SerializeField] LayerMask groundMask;
    [SerializeField] AudioClip jumpSound;
    [SerializeField] AudioClip stepSound;
    [SerializeField] AudioClip rollSound;
    [SerializeField] float runSpeed = 6f;
    [SerializeField] float jumpSpeed = 12f;
    [SerializeField] float rollSpeed = 9f;
    [SerializeField] float rollCooldown = 0.4f;     // seconds from the end of one roll to the next
    [SerializeField] float bounceSpeed = 9f;        // how high a stomp throws him
    [SerializeField] float groundCheckDistance = 0.15f;

    Rigidbody2D body;
    Animator animator;
    SpriteRenderer spriteRenderer;
    AudioSource audioSource;
    KnightHealth health;

    float moveInput;            // -1 left, 0 still, 1 right
    bool isGrounded;
    bool isFacingLeft;
    bool isRolling;
    float rollDirection;
    float nextRollTime;
    bool isLeftHeld;            // the touch buttons
    bool isRightHeld;
    bool isJumpQueued;
    bool isRollQueued;

    public bool IsRolling
    {
        get { return isRolling; }
    }

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
        health = GetComponent<KnightHealth>();
    }

    void Update()
    {
        isGrounded = CheckGround();

        // The touch buttons only queue a jump or a roll. Use them up now.
        bool isJumpPressed = isJumpQueued;
        bool isRollPressed = isRollQueued;
        isJumpQueued = false;
        isRollQueued = false;

        moveInput = 0f;
        if (isLeftHeld)
        {
            moveInput -= 1f;
        }
        if (isRightHeld)
        {
            moveInput += 1f;
        }

        // The keyboard. A phone may have no keyboard, and then Keyboard.current is null.
        Keyboard keyboard = Keyboard.current;
        if (keyboard != null)
        {
            if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed)
            {
                moveInput -= 1f;
            }
            if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed)
            {
                moveInput += 1f;
            }
            if (keyboard.spaceKey.wasPressedThisFrame || keyboard.wKey.wasPressedThisFrame || keyboard.upArrowKey.wasPressedThisFrame)
            {
                isJumpPressed = true;
            }
            if (keyboard.leftShiftKey.wasPressedThisFrame || keyboard.rightShiftKey.wasPressedThisFrame || keyboard.jKey.wasPressedThisFrame)
            {
                isRollPressed = true;
            }
        }
        moveInput = Mathf.Clamp(moveInput, -1f, 1f);

        if (HasControl())
        {
            if (moveInput != 0f && !isRolling)
            {
                isFacingLeft = moveInput < 0f;
                spriteRenderer.flipX = isFacingLeft;
            }
            if (isJumpPressed && isGrounded && !isRolling)
            {
                Jump();
            }
            if (isRollPressed && isGrounded && !isRolling && Time.time >= nextRollTime)
            {
                StartRoll();
            }
        }
        else
        {
            moveInput = 0f;
        }

        // Run, or roll. While he's stunned, the knockback carries him instead.
        // A velocity is safe to set in Update: the Rigidbody keeps it until the
        // next physics step uses it.
        if (!health.IsStunned)
        {
            float speedX = moveInput * runSpeed;
            if (isRolling)
            {
                speedX = rollDirection * rollSpeed;
            }
            body.linearVelocity = new Vector2(speedX, body.linearVelocity.y);
        }

        animator.SetFloat(SpeedHash, Mathf.Abs(body.linearVelocity.x));
        animator.SetFloat(VerticalSpeedHash, body.linearVelocity.y);
        animator.SetBool(GroundedHash, isGrounded);
    }

    bool HasControl()
    {
        return game.IsPlaying && !health.IsDead && !health.IsStunned;
    }

    // Two short rays down from his feet, against the Ground layer only.
    // Moving up is never standing: that's a jump just starting.
    bool CheckGround()
    {
        if (body.linearVelocity.y > 0.01f)
        {
            return false;
        }
        RaycastHit2D left = Physics2D.Raycast(leftFoot.position, Vector2.down, groundCheckDistance, groundMask);
        RaycastHit2D right = Physics2D.Raycast(rightFoot.position, Vector2.down, groundCheckDistance, groundMask);
        return left.collider != null || right.collider != null;
    }

    void Jump()
    {
        body.linearVelocity = new Vector2(body.linearVelocity.x, jumpSpeed);
        isGrounded = false;
        audioSource.PlayOneShot(jumpSound);
    }

    void StartRoll()
    {
        isRolling = true;
        rollDirection = isFacingLeft ? -1f : 1f;
        animator.SetTrigger(RollHash);
        audioSource.PlayOneShot(rollSound);
    }

    // A stomp throws him back up off the slime.
    public void Bounce()
    {
        body.linearVelocity = new Vector2(body.linearVelocity.x, bounceSpeed);
    }

    // Animation Event: on each frame of the Run clip where a foot lands.
    public void OnFootstep()
    {
        if (isGrounded)
        {
            audioSource.PlayOneShot(stepSound, 0.4f);
        }
    }

    // Animation Event: on the last frame of the Roll clip.
    public void OnRollFinished()
    {
        isRolling = false;
        nextRollTime = Time.time + rollCooldown;
    }

    // The touch buttons call these, through their Event Triggers.
    public void SetLeftHeld(bool isHeld)
    {
        isLeftHeld = isHeld;
    }

    public void SetRightHeld(bool isHeld)
    {
        isRightHeld = isHeld;
    }

    public void PressJump()
    {
        isJumpQueued = true;
    }

    public void PressRoll()
    {
        isRollQueued = true;
    }

    // Back to a starting point, standing still and facing right: after a fall,
    // and on Restart.
    public void ResetKnight(Vector2 position)
    {
        body.position = position;
        transform.position = position;
        body.linearVelocity = Vector2.zero;

        // A fall can cut the Roll clip short, and then OnRollFinished never
        // comes. So the reset ends the roll itself.
        isRolling = false;
        nextRollTime = 0f;
        isFacingLeft = false;
        spriteRenderer.flipX = false;

        // The Dead clip fades him out. Put his colour back first: Rebind
        // remembers the colour he has now as the one to go back to.
        spriteRenderer.color = Color.white;
        animator.Rebind();
    }
}
```

2. `KnightHealth`:

```csharp:KnightHealth.cs
using System.Collections;
using UnityEngine;

// The knight's health: 5 to start with. A slime knocks him back and makes him
// blink, and nothing can hurt him while he blinks. At 0 he falls, and when his
// Dead clip ends, the game is lost.
public class KnightHealth : MonoBehaviour
{
    public const int MaxHealth = 5;

    static readonly int HurtHash = Animator.StringToHash("Hurt");
    static readonly int DeadHash = Animator.StringToHash("Dead");

    [SerializeField] PlatformerGame game;
    [SerializeField] HealthBar healthBar;
    [SerializeField] AudioClip hurtSound;
    [SerializeField] AudioClip healSound;
    [SerializeField] Vector2 knockback = new Vector2(5f, 6f);
    [SerializeField] float stunSeconds = 0.25f;     // no control, while the knockback carries him
    [SerializeField] float blinkSeconds = 1f;

    Rigidbody2D body;
    Animator animator;
    SpriteRenderer spriteRenderer;
    AudioSource audioSource;
    KnightController controller;
    bool isBlinking;
    float stunnedUntil;

    public int Health { get; private set; } = MaxHealth;
    public bool IsDead { get; private set; }

    public bool IsStunned
    {
        get { return Time.time < stunnedUntil; }
    }

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
        controller = GetComponent<KnightController>();
    }

    void Start()
    {
        healthBar.SetHealth(Health, MaxHealth);
    }

    // A slime hurt him. fromX is where the slime is, so he flies away from it.
    public void TakeDamage(int amount, float fromX)
    {
        // Nothing hurts him while he blinks or rolls, and a fallen knight
        // can't fall again.
        if (IsDead || isBlinking || controller.IsRolling)
        {
            return;
        }

        LoseHealth(amount);
        if (IsDead)
        {
            return;
        }

        float direction = transform.position.x < fromX ? -1f : 1f;
        body.linearVelocity = new Vector2(knockback.x * direction, knockback.y);
        stunnedUntil = Time.time + stunSeconds;
        animator.SetTrigger(HurtHash);
    }

    // He fell into water, goo or the moat. The game has already put him back
    // at the last checkpoint.
    public void FellInPit()
    {
        if (!IsDead)
        {
            LoseHealth(1);
        }
    }

    void LoseHealth(int amount)
    {
        Health = Mathf.Max(Health - amount, 0);
        healthBar.SetHealth(Health, MaxHealth);
        audioSource.PlayOneShot(hurtSound);

        if (Health == 0)
        {
            IsDead = true;
            body.linearVelocity = new Vector2(0f, body.linearVelocity.y);
            animator.SetTrigger(DeadHash);
        }
        else
        {
            StartCoroutine(Blink());
        }
    }

    IEnumerator Blink()
    {
        isBlinking = true;
        float endTime = Time.time + blinkSeconds;
        while (Time.time < endTime)
        {
            spriteRenderer.enabled = !spriteRenderer.enabled;
            yield return new WaitForSeconds(0.1f);
        }
        spriteRenderer.enabled = true;
        isBlinking = false;
    }

    public void Heal(int amount)
    {
        Health = Mathf.Min(Health + amount, MaxHealth);
        healthBar.SetHealth(Health, MaxHealth);
        audioSource.PlayOneShot(healSound);
    }

    // Animation Event: at the end of the Dead clip, once he has faded out.
    public void OnDeathFinished()
    {
        game.Lose();
    }

    public void ResetHealth()
    {
        StopAllCoroutines();
        Health = MaxHealth;
        IsDead = false;
        isBlinking = false;
        stunnedUntil = 0f;
        spriteRenderer.enabled = true;
        healthBar.SetHealth(Health, MaxHealth);
    }
}
```

3. `Slime`:

```csharp:Slime.cs
using UnityEngine;

// A slime, run as a state machine. Each state's enter step tells the Animator
// which state it's in, through the State parameter, so the Animator follows
// the code. The purple slime is this same script, with other numbers.
[RequireComponent(typeof(Rigidbody2D))]
public class Slime : MonoBehaviour
{
    public enum State { Patrol, Chase, WindUp, Leap, Hurt, Dead }

    static readonly int StateHash = Animator.StringToHash("State");

    [SerializeField] PlatformerGame game;
    [SerializeField] KnightHealth knight;
    [SerializeField] LayerMask groundMask;
    [SerializeField] AudioClip squashSound;
    [SerializeField] int maxHealth = 1;
    [SerializeField] float patrolSpeed = 1.5f;
    [SerializeField] float patrolDistance = 2f;     // how far it wanders from where it started, each way
    [SerializeField] float chaseSpeed = 2.5f;
    [SerializeField] float sightRange = 4f;
    [SerializeField] float leapRange = 1.2f;
    [SerializeField] Vector2 leapVelocity = new Vector2(4f, 6f);
    [SerializeField] Vector2 knockback = new Vector2(3f, 3f);
    [SerializeField] float hurtSeconds = 0.4f;

    Rigidbody2D body;
    Animator animator;
    SpriteRenderer spriteRenderer;
    Collider2D slimeCollider;
    AudioSource audioSource;
    Vector2 startPosition;
    State state;
    int health;
    float direction = -1f;      // -1 left, 1 right
    float stateStartTime;

    // A hurt or dead slime can't hurt the knight, and can't be hit again.
    public bool IsHarmless
    {
        get { return state == State.Hurt || state == State.Dead; }
    }

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        slimeCollider = GetComponent<Collider2D>();
        audioSource = GetComponent<AudioSource>();
        startPosition = transform.position;
    }

    void Start()
    {
        ResetSlime();
    }

    void Update()
    {
        // Before Play, after the end and in the pause menu, slimes wait.
        if (!game.IsPlaying)
        {
            Stop();
            return;
        }

        switch (state)
        {
            case State.Patrol:
                UpdatePatrol();
                break;
            case State.Chase:
                UpdateChase();
                break;
            case State.WindUp:
                break;                  // waits for the OnLeap Animation Event
            case State.Leap:
                UpdateLeap();
                break;
            case State.Hurt:
                UpdateHurt();
                break;
            case State.Dead:
                break;                  // waits for the OnDeathFinished Animation Event
        }

        // The slime's picture looks left, so it flips to look right.
        spriteRenderer.flipX = direction > 0f;
    }

    // The one place the state changes. The enter step runs once, as the
    // slime arrives in its new state.
    void EnterState(State next)
    {
        state = next;
        stateStartTime = Time.time;
        animator.SetInteger(StateHash, (int)state);

        switch (state)
        {
            case State.Patrol:
                break;
            case State.Chase:
                break;
            case State.WindUp:
                Stop();
                break;
            case State.Leap:
                body.linearVelocity = new Vector2(direction * leapVelocity.x, leapVelocity.y);
                break;
            case State.Hurt:
                break;
            case State.Dead:
                Stop();
                slimeCollider.enabled = false;
                body.simulated = false;
                audioSource.PlayOneShot(squashSound);
                break;
        }
    }

    void UpdatePatrol()
    {
        if (CanSeeKnight(sightRange))
        {
            EnterState(State.Chase);
            return;
        }

        // Turn round at either end of its patch of ground, or at an edge.
        bool isPastRight = direction > 0f && transform.position.x > startPosition.x + patrolDistance;
        bool isPastLeft = direction < 0f && transform.position.x < startPosition.x - patrolDistance;
        if (isPastRight || isPastLeft || !HasGroundAhead())
        {
            direction = -direction;
        }
        Move(patrolSpeed);
    }

    void UpdateChase()
    {
        // It gives up once the knight is well away.
        if (!CanSeeKnight(sightRange * 1.5f))
        {
            EnterState(State.Patrol);
            return;
        }

        float toKnight = knight.transform.position.x - transform.position.x;
        direction = toKnight < 0f ? -1f : 1f;

        if (Mathf.Abs(toKnight) <= leapRange && IsGrounded() && HasGroundAhead())
        {
            EnterState(State.WindUp);
        }
        else if (HasGroundAhead())
        {
            Move(chaseSpeed);
        }
        else
        {
            Stop();     // it never chases him off a ledge
        }
    }

    void UpdateLeap()
    {
        // Landed: a moment after take-off, it's standing on the ground again.
        if (Time.time > stateStartTime + 0.2f && IsGrounded())
        {
            EnterState(State.Chase);
        }
    }

    void UpdateHurt()
    {
        if (Time.time < stateStartTime + hurtSeconds)
        {
            return;
        }
        if (health > 0)
        {
            EnterState(State.Chase);
        }
        else
        {
            EnterState(State.Dead);
        }
    }

    // Stomped or rolled into. fromX is where the knight is, so it flies away from him.
    public void TakeHit(float fromX)
    {
        if (IsHarmless)
        {
            return;
        }
        health--;
        float away = transform.position.x < fromX ? -1f : 1f;
        body.linearVelocity = new Vector2(knockback.x * away, knockback.y);
        EnterState(State.Hurt);
    }

    // Animation Event: on the last frame of the WindUp clip.
    public void OnLeap()
    {
        // A stomp during the wind-up changes the state first: then there's no leap.
        if (state == State.WindUp)
        {
            EnterState(State.Leap);
        }
    }

    // Animation Event: at the end of the Dead clip, once it has melted and faded.
    public void OnDeathFinished()
    {
        gameObject.SetActive(false);
    }

    bool CanSeeKnight(float range)
    {
        if (knight.IsDead)
        {
            return false;
        }
        Vector2 toKnight = knight.transform.position - transform.position;
        return Mathf.Abs(toKnight.x) < range && Mathf.Abs(toKnight.y) < 1.5f;
    }

    bool IsGrounded()
    {
        Vector2 start = (Vector2)transform.position + new Vector2(0f, 0.1f);
        return Physics2D.Raycast(start, Vector2.down, 0.2f, groundMask).collider != null;
    }

    // Is there ground half a tile ahead, in the direction it's going?
    bool HasGroundAhead()
    {
        Vector2 start = (Vector2)transform.position + new Vector2(direction * 0.5f, 0.1f);
        return Physics2D.Raycast(start, Vector2.down, 0.6f, groundMask).collider != null;
    }

    void Move(float speed)
    {
        body.linearVelocity = new Vector2(direction * speed, body.linearVelocity.y);
    }

    void Stop()
    {
        body.linearVelocity = new Vector2(0f, body.linearVelocity.y);
    }

    // Back where it started, alive and patrolling: on Restart.
    public void ResetSlime()
    {
        gameObject.SetActive(true);
        body.simulated = true;
        body.position = startPosition;
        transform.position = startPosition;
        body.linearVelocity = Vector2.zero;
        slimeCollider.enabled = true;

        // The Dead clip fades it out. Put its colour back before Rebind
        // remembers it.
        spriteRenderer.color = Color.white;
        animator.Rebind();

        health = maxHealth;
        direction = -1f;
        EnterState(State.Patrol);
    }
}
```

4. `PlatformerGame`:

```csharp:PlatformerGame.cs
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

// Runs the game as a state machine: Start, Playing, Paused, Won and Lost. It
// counts the coins and the time, remembers the last checkpoint, shows each
// section's name and sky, and puts the whole level back on Restart.
public class PlatformerGame : MonoBehaviour
{
    public enum GameState { Start, Playing, Paused, Won, Lost }

    [SerializeField] KnightController knight;
    [SerializeField] KnightHealth knightHealth;
    [SerializeField] CameraFollow cameraFollow;
    [SerializeField] Camera mainCamera;
    [SerializeField] Transform enemies;
    [SerializeField] Transform pickups;
    [SerializeField] Transform checkpoints;
    [SerializeField] Section[] sections;
    [SerializeField] float skyChangeSpeed = 2f;
    [SerializeField] TMP_Text coinText;
    [SerializeField] TMP_Text sectionText;
    [SerializeField] GameObject touchControls;
    [SerializeField] GameObject startPanel;
    [SerializeField] Button playButton;
    [SerializeField] Button pauseButton;
    [SerializeField] GameObject pausePanel;
    [SerializeField] GameObject winPanel;
    [SerializeField] TMP_Text winText;
    [SerializeField] Button playAgainButton;
    [SerializeField] GameObject losePanel;
    [SerializeField] Button tryAgainButton;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip coinSound;
    [SerializeField] AudioClip checkpointSound;
    [SerializeField] AudioClip winSound;

    GameState state;
    int coins;
    int totalCoins;
    float playTime;
    Vector2 startPoint;
    Vector2 respawnPoint;
    int sectionIndex = -1;
    Coroutine sectionFade;

    public bool IsPlaying
    {
        get { return state == GameState.Playing; }
    }

    void OnEnable()
    {
        playButton.onClick.AddListener(Restart);
        pauseButton.onClick.AddListener(Pause);
        playAgainButton.onClick.AddListener(Restart);
        tryAgainButton.onClick.AddListener(Restart);
    }

    void OnDisable()
    {
        playButton.onClick.RemoveListener(Restart);
        pauseButton.onClick.RemoveListener(Pause);
        playAgainButton.onClick.RemoveListener(Restart);
        tryAgainButton.onClick.RemoveListener(Restart);
    }

    void Awake()
    {
        startPoint = knight.transform.position;
        respawnPoint = startPoint;
        totalCoins = pickups.GetComponentsInChildren<Coin>(true).Length;

        // The touch buttons only show on a touchscreen.
        touchControls.SetActive(Touchscreen.current != null);
        sectionText.text = "";
        mainCamera.backgroundColor = sections[0].SkyColour;
        UpdateCoinText();
        EnterState(GameState.Start);
    }

    void Update()
    {
        switch (state)
        {
            case GameState.Start:
                break;
            case GameState.Playing:
                playTime += Time.deltaTime;
                UpdateSection();
                if (WasPausePressed())
                {
                    Pause();
                }
                break;
            case GameState.Paused:
                if (WasPausePressed())
                {
                    Resume();
                }
                break;
            case GameState.Won:
                break;
            case GameState.Lost:
                break;
        }

        // The sky eases towards the colour of the section the knight is in.
        if (sectionIndex >= 0)
        {
            Color sky = sections[sectionIndex].SkyColour;
            mainCamera.backgroundColor = Color.Lerp(mainCamera.backgroundColor, sky, skyChangeSpeed * Time.deltaTime);
        }
    }

    // The one place the game's state changes. Every state shows its own panel,
    // and hides the others; then the enter step does what that state needs.
    void EnterState(GameState next)
    {
        state = next;
        startPanel.SetActive(state == GameState.Start);
        pausePanel.SetActive(state == GameState.Paused);
        winPanel.SetActive(state == GameState.Won);
        losePanel.SetActive(state == GameState.Lost);
        pauseButton.gameObject.SetActive(state == GameState.Playing);

        switch (state)
        {
            case GameState.Start:
                Time.timeScale = 1f;
                break;
            case GameState.Playing:
                Time.timeScale = 1f;
                break;
            case GameState.Paused:
                Time.timeScale = 0f;    // physics, Animators and timers all stop
                break;
            case GameState.Won:
                winText.text = $"You made it!\n\nCoins: {coins} / {totalCoins}\nTime: {FormatTime(playTime)}";
                audioSource.PlayOneShot(winSound);
                break;
            case GameState.Lost:
                break;
        }
    }

    // Puts everything back as it was at the start, then plays. Loading the
    // scene again would do the same: that waits for Level 4.
    public void Restart()
    {
        coins = 0;
        playTime = 0f;
        respawnPoint = startPoint;
        sectionIndex = -1;

        foreach (Slime slime in enemies.GetComponentsInChildren<Slime>(true))
        {
            slime.ResetSlime();
        }
        foreach (Coin coin in pickups.GetComponentsInChildren<Coin>(true))
        {
            coin.ResetCoin();
        }
        foreach (Apple apple in pickups.GetComponentsInChildren<Apple>(true))
        {
            apple.ResetApple();
        }
        foreach (Checkpoint checkpoint in checkpoints.GetComponentsInChildren<Checkpoint>(true))
        {
            checkpoint.ResetCheckpoint();
        }

        knight.ResetKnight(startPoint);
        knightHealth.ResetHealth();
        cameraFollow.SnapToTarget();
        mainCamera.backgroundColor = sections[0].SkyColour;
        UpdateCoinText();
        EnterState(GameState.Playing);
    }

    public void Pause()
    {
        if (state == GameState.Playing)
        {
            EnterState(GameState.Paused);
        }
    }

    public void Resume()
    {
        if (state == GameState.Paused)
        {
            EnterState(GameState.Playing);
        }
    }

    public void Win()
    {
        if (state == GameState.Playing)
        {
            EnterState(GameState.Won);
        }
    }

    public void Lose()
    {
        if (state == GameState.Playing)
        {
            EnterState(GameState.Lost);
        }
    }

    public void AddCoin()
    {
        coins++;
        UpdateCoinText();
        audioSource.PlayOneShot(coinSound);
    }

    public void SetRespawnPoint(Vector2 point)
    {
        respawnPoint = point;
        audioSource.PlayOneShot(checkpointSound);
    }

    // The knight fell in: back to the last checkpoint, and 1 health less.
    public void KnightFell()
    {
        if (state != GameState.Playing)
        {
            return;
        }
        knight.ResetKnight(respawnPoint);
        cameraFollow.SnapToTarget();
        knightHealth.FellInPit();
    }

    // Shows a section's name as the knight reaches it.
    void UpdateSection()
    {
        float x = knight.transform.position.x;
        int index = 0;
        for (int i = 0; i < sections.Length; i++)
        {
            if (x >= sections[i].StartX)
            {
                index = i;
            }
        }

        if (index != sectionIndex)
        {
            sectionIndex = index;
            if (sectionFade != null)
            {
                StopCoroutine(sectionFade);
            }
            sectionFade = StartCoroutine(ShowSectionName(sections[index].Title));
        }
    }

    IEnumerator ShowSectionName(string title)
    {
        sectionText.text = title;
        sectionText.alpha = 1f;
        yield return new WaitForSeconds(2f);
        for (float t = 0f; t < 1f; t += Time.deltaTime)
        {
            sectionText.alpha = 1f - t;
            yield return null;
        }
        sectionText.text = "";
    }

    bool WasPausePressed()
    {
        Keyboard keyboard = Keyboard.current;
        return keyboard != null && (keyboard.escapeKey.wasPressedThisFrame || keyboard.pKey.wasPressedThisFrame);
    }

    void UpdateCoinText()
    {
        coinText.text = $"x {coins}";
    }

    // 161.4 seconds becomes "2:41".
    static string FormatTime(float seconds)
    {
        int whole = Mathf.FloorToInt(seconds);
        return $"{whole / 60}:{whole % 60:00}";
    }
}
```

Read them before you move on:

- `PlayOneShot(stepSound, 0.4f)`: the second number is the volume, from 0 to 1, so the
  steps are quiet.
- `OnFootstep` checks `isGrounded`: running off an edge, the Run clip can still be
  playing for a moment, and a step in mid-air would sound wrong.
- The squash plays in Dead's enter step, so every slime squashes exactly once, whether it
  was stomped, rolled into, or worn down.
- The knight and the slimes find their Audio Source with `GetComponent`. The game takes
  its own through a field instead: `Platformer Game` has two, and `GetComponent` would
  give whichever comes first.

### Do it — the sounds

Drag each sound from `Assets/Audio` into its field:

| Select | In | Field | Sound |
| --- | --- | --- | --- |
| `Knight` | Knight Controller | **Jump Sound** | `jump` |
| | | **Step Sound**, **Roll Sound** | `tap` |
| | Knight Health | **Hurt Sound** | `hurt` |
| | | **Heal Sound** | `power_up` |
| the `Slime` and `Purple Slime` prefabs | Slime | **Squash Sound** | `explosion` |
| `Platformer Game` | Platformer Game | **Coin Sound** | `coin` |
| | | **Checkpoint Sound**, **Win Sound** | `power_up` |

Last, drag the first **Audio Source** on `Platformer Game`, by its title in the
Inspector, onto the game's **Audio Source** field.

### Test it

1. Play. The music starts with the start panel. Run: quiet steps, in time with his feet.
   Jump, roll, collect a coin, and eat an apple: each has its sound.
2. Squash a slime, and get hurt by one. Fall in, and hear the hurt.
3. Run on past the woods' checkpoint: *The Castle Walls*, and the sky turns from peach
   to dusk purple.
4. Cross the moat, climb the stairs past the purple slime, and walk into the doorway:
   *You made it!*, with your coins out of 30 now.
5. Pause, and move the volume slider: every sound turns down, the music too.

### Challenge

Make the music stop while the game is paused: `AudioListener.pause = true` stops every
Audio Source in the game until it's `false` again. Which two states' enter steps need
it, and what about **Restart** from the pause panel? Then make a `Castle Platform`
prefab, like the woods' one, with the icy blue platform from the `platforms` sheet,
and build a secret high route over the second moat, with a coin on it.

# Part 4 — Finish

{{concept:reading}}

{{concept:errors}}

{{concept:classes}}

## Chapter 14 — Break It, Then Fix It

**Goal:** you can recognise what Unity says when an Animator parameter, an Animation
Event or a reference is wrong, go straight to the cause, and use a breakpoint to watch a
slime make up its mind.

### Idea

Every programmer breaks things, every day. The difference between a beginner and a
professional is how fast they find the cause. In this chapter you break the finished
game **on purpose**, one thing at a time, read what Unity tells you, and fix it. Do each
step, then undo it before the next one.

Level 3's mistakes are sneakier than Level 2's: an Animator or an Animation Event
finds its parameters and methods **by name**, while the game runs. So the compiler
can't catch a wrong name, and some of these mistakes give a warning, or nothing at all,
instead of an error ({{ref:errors}}).

> **Watch out:** save your scene first (**Ctrl + S** / **Cmd + S**). If anything goes
> wrong, you can always go back to the saved version.

### Do it — a typo in a hash

1. In `KnightController`, change the first hash's name to `"speed"`, with a small `s`:

   ```csharp
   static readonly int SpeedHash = Animator.StringToHash("speed");
   ```

2. Play, click **Play**, and run. The knight slides along in his Idle pose, and the
   Console fills with a yellow warning:

   ```
   Parameter 'Hash 254213878' does not exist.
   ```

3. A hash is only a number, so Unity can't say which name is wrong ({{ref:animcode}}).
   Click the warning. Under it, the stack trace: first Unity's own
   `UnityEngine.Animator:SetFloat (int,single)`, then your code,
   `KnightController:Update () (at Assets/Scripts/KnightController.cs:138)`. Line 138
   sets `SpeedHash`, and `SpeedHash` comes from the line you changed. Put the capital
   `S` back.

### Do it — the wrong call

1. In `KnightController.Update`, change `animator.SetBool(GroundedHash, isGrounded);`
   to:

   ```csharp
   animator.SetInteger(GroundedHash, isGrounded ? 1 : 0);
   ```

2. Play, and jump. The knight jumps and lands in his standing pose: the Jump and Fall
   poses never show. The warning:

   ```
   Parameter type 'Hash 862969536' does not match.
   ```

3. `Grounded` is a **Bool** in the Animator, so `SetInteger` can't change it. It stays
   at its default, true, and the transitions to Jump and Fall need it to be false. Put
   `SetBool` back.

### Do it — an event with no receiver

1. In `KnightController`, rename `OnFootstep` to `OnFootStep`, with a capital `S`.
2. Play, and run. Red errors, four a second, one for each footstep event:

   ```
   'Knight' AnimationEvent 'OnFootstep' on animation 'Knight Run' has no receiver! Are you missing a component?
   ```

3. Read it from the start: the GameObject, `Knight`; the event, `OnFootstep`; the clip,
   `Knight Run`. The clip still calls `OnFootstep`, and no script on `Knight` has a
   method by that name any more ({{ref:animevents}}). Rename the method back.

### Do it — an event that can't be called

1. Give `OnRollFinished` a parameter: `public void OnRollFinished(bool isDone)`.
2. Play, and roll. When the roll clip ends:

   ```
   Failed to call AnimationEvent OnRollFinished of class KnightController.
   The function must have either 0 or 1 parameters and the parameter can only be: string, float, int, enum, Object, AnimationEvent or AnimationEventInfo.
   ```

3. A `bool` isn't on the list, so the method is never called, and `isRolling` never
   goes back to false. Watch the knight: the Animator moves on to Idle and Run, but the
   code still thinks he's rolling, so he speeds on at rolling speed, can't jump, and
   can't be hurt. Two state machines that no longer agree. Take the parameter out.

### Do it — an empty field

1. Open `Pickups`, select the first coin, and empty its **Game** field: click it, and
   press **Delete** or **Backspace**. It says **None (Platformer Game)**.
2. Play, and collect that coin. The error:

   ```
   NullReferenceException: Object reference not set to an instance of an object
   Coin.OnTriggerEnter2D (UnityEngine.Collider2D other) (at Assets/Scripts/Coin.cs:13)
   ```

3. Line 13 is `game.AddCoin();`, and `game` is the only thing before a `.` on it. The
   coin doesn't disappear, and the count doesn't change: the error stopped the method
   before `SetActive(false)`. This is the mistake Chapter 13 warned about: a new coin
   whose **Game** was never set. Drag `Platformer Game` back into the field.
4. Now select **Main Camera**, and empty its **Target**. Play: a different exception,
   every frame, and a friendlier one, because a `Transform` is one of Unity's own types:

   ```
   UnassignedReferenceException: The variable target of CameraFollow has not been assigned.
   You probably need to assign the target variable of the CameraFollow script in the inspector.
   ```

5. Click it. The stack trace's first three lines are Unity's own code. Start at the
   first that names your script: `CameraFollow.Goal ()`, line 38, called by
   `CameraFollow.LateUpdate ()`, line 23. Drag `Knight` back into **Target**.

### Do it — a transition that waits

1. Open the knight's Animator, select the **Idle → Run** transition, and tick **Has
   Exit Time**.
2. Play, and start running. The knight slides for a moment in his Idle pose before his
   legs start: the transition now waits for the Idle clip to reach its exit time.
3. No message at all: only your eyes catch this one. Untick **Has Exit Time**.

### Do it — a state change that skips its enter step

1. In `Slime.UpdatePatrol`, change `EnterState(State.Chase);` to `state = State.Chase;`.
2. Play, select the first slime, and open the Animator window. Walk up to the slime:
   it chases you, but the Animator still shows **Patrol**, and `State` still says `0`.
   The slime wobbles at its slow patrol speed instead of the fast chase.
3. Only `EnterState` tells the Animator. Skip it, and the two machines no longer agree
   ({{ref:enemies}}). Put `EnterState(State.Chase);` back.

### Do it — watch a slime decide, with a breakpoint

1. Open `Slime` in VS Code, and click left of the line number of `state = next;`, the
   first line of `EnterState`: a red dot.
2. **Run and Debug** (**Ctrl + Shift + D** / **Cmd + Shift + D**), choose **Attach to
   Unity**, and press ▶. If Unity asks, choose **Enable debugging for this session**.
3. Play, click **Play**, and walk towards the first slime. The game freezes, and VS Code
   highlights the line. Hover over `next`: **Chase**. Look at the **Call Stack**:
   `EnterState`, called by `UpdatePatrol`, called by `Update`.
4. Press **F5** to carry on, and stand still near the slime. It stops again: **WindUp**,
   called by `UpdateChase`. **F5** again: **Leap**, called by `OnLeap`. Under `OnLeap`,
   there's no `Update`: none of your code called it. The Animator did, from the WindUp
   clip's event.
5. Click the red dot to remove it, press **F5**, and stop debugging with **Shift + F5**.

### Test it

After undoing every break, the game works exactly as before: play the whole level to
be sure, and check that the Console has no errors and no warnings.

### Challenge

Break the game in a way this chapter didn't, and swap with a classmate: each of you
must find and fix the other's bug using only the Console, the Animator window and a
breakpoint. The hardest ones to find give no message at all.

## Chapter 15 — Ship It

**Goal:** a Web build of Knight Run, published on itch.io, that plays with the keyboard
on a computer, and with two thumbs on a phone.

### Idea

The game is finished; now players need it. As in Levels 1 and 2, a **Web** build runs
in any browser, and itch.io hosts it for free. The touch buttons from Chapter 12 show
by themselves on a phone, because it has a touchscreen: the same link works everywhere.

### Do it — the build

1. **File → Build Profiles**. Select **Web** and click **Switch Platform**.
2. In **Scene List**, click **Add Open Scenes** if `Scenes/KnightRun` is missing, and
   untick `Scenes/SampleScene`: a build starts with the first ticked scene, and that
   must be `Scenes/KnightRun`.
3. Open **Player Settings**: set the **Product Name** to `Knight Run`. Under
   **Publishing Settings**, set **Compression Format** to **Disabled**.
4. Click **Build**, create a folder called `Builds/Web`, and wait.

### Do it — publish on itch.io

1. Zip the **contents** of `Builds/Web`, so `index.html` is at the top of the zip.
2. On itch.io, **Upload new project**, **Kind of project: HTML**, upload the zip, and
   tick **This file will be played in the browser**.
3. Set the **Viewport dimensions** to `960 × 600`, the size of the game in a Web build,
   and tick **Mobile friendly**; if itch.io asks for an orientation, choose
   **Landscape**. Save, and open the page.

### Test it

1. On a computer: play the whole level with the keyboard. Pause with **Esc**, change the
   volume, and win. The touch buttons don't show, unless the computer has a touchscreen.
2. On a phone: open the same page, turn the phone sideways, and press **Play**. The four
   round buttons show. Hold `>` with your left thumb, and tap **JUMP** with your right:
   two fingers at once. Pause with the `II` button.
3. If something is too small to read or to press on the phone, or a jump is too hard
   with thumbs, that's a job for the challenge.

### Challenge

Watch a friend play without explaining anything. Where do they get stuck? Where do
they fall in? Fix the biggest problem: a clearer sign, a bigger button, a wider
platform, a gentler slime. That's what game designers call **playtesting**.

# Part 5 — The Exam

{{concept:exam}}

# Part 6 — Check Yourself

{{include:check-yourself}}
