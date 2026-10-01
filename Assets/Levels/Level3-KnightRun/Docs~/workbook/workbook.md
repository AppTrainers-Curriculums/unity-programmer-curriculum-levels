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
| 1 | C# 1 | Naming conventions | — |
| 2 | Chapter 1 | Pixel art, sprite sheets, the Tile Palette, Tilemaps | The Meadow |
| 3 | Chapter 2 | Two ground rays, one-way platforms, a camera that follows | Run and jump |
| 4 | C# 2 | Clips, keyframes, sprite frames | — |
| 5 | Chapter 3 | Seven clips from one sprite sheet | The knight's clips |
| 6 | C# 3, C# 4 | States, transitions, parameters, hashes | — |
| 7 | Chapter 4 | The Animator, driven from code | The knight's Animator |
| 8 | C# 5 | Animation Events | — |
| 9 | Chapter 5 | Triggers, Any State, exit time, events | The roll |
| 10 | C# 6, C# 7 | State machines in code and in the Animator | — |
| 11 | Chapter 6 | An enemy as a state machine | The slime |
| 12 | Chapter 7 | Collisions, contact normals, knockback | Stomp, hurt and pits |
| 13 | Chapter 8 | Override Controllers, a second Tilemap section | The Autumn Woods |
| 14 | Chapter 9 | Property animation, pickups, respawning | Coins, apples and checkpoints |
| 15 | C# 8 | Health bars, panels, pausing | — |
| 16 | Chapter 10 | `[System.Serializable]`, font assets | The HUD |
| 17 | Chapter 11 | The game as a state machine, Restart in code | Start, win and lose |
| 18 | Chapter 12 | Pausing, Event Triggers, the Device Simulator | Pause and touch |
| 19 | Chapter 13 | Sound on events, music | The Castle Walls |
| 20 | C# 9, C# 10, C# 11 | Reading code, finding errors, kinds of classes | — |
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

## C# 1 — Naming Conventions

**Goal:** you can name classes, methods, fields and the rest the way C# and Unity
programmers do, and you can spot a name that breaks the rules. Exam objective U 3.5
asks about exactly this.

### Idea — why names follow rules

Code is read far more often than it's written: by you next week, by your team, and by
the exam. When everyone writes names the same way, a name tells you what kind of thing
it is before you've read anything else. `TakeDamage` is a method, `maxHealth` is a
field, `IsDead` is a property and `State.Chase` is a value of an enum, and you know that
from the letters alone.

C# uses two ways of joining words into one name:

| Style | How | Example |
| --- | --- | --- |
| **PascalCase** | every word starts with a capital, the first one too | `KnightController`, `TakeDamage`, `MaxHealth` |
| **camelCase** | like PascalCase, but the first word is all small letters | `moveSpeed`, `isGrounded`, `coinCount` |

Other languages use other styles, such as `move_speed` (snake case) or `MOVE_SPEED`.
You'll meet them in other places, but normal C# names don't use underscores or capitals
all the way through.

### Idea — which style goes where

| What | Style | Examples |
| --- | --- | --- |
| Classes, structs and enums | PascalCase | `Slime`, `HealthBar`, `GameState` |
| Enum values | PascalCase | `State.Patrol`, `GameState.Playing` |
| Methods | PascalCase, usually a verb | `Jump()`, `TakeDamage()`, `ResetLevel()` |
| Properties | PascalCase | `Health`, `IsDead`, `IsPlaying` |
| Fields, private or `[SerializeField]` | camelCase | `jumpSpeed`, `groundMask`, `health` |
| Local variables and parameters | camelCase | `toPlayer`, `amount`, `fromX` |
| `const` and `static readonly` fields | PascalCase | `MaxHealth`, `SpeedHash` |
| Interfaces (Level 4) | PascalCase, starting with `I` | `IDamageable` |

The rule underneath: anything other scripts can use from outside (a class, a method, a
property, a constant) gets a capital. The things that live inside a class, or inside
one method, start small.

> **Note:** you'll see other styles for private fields in other people's code:
> `_health`, or `m_Health` (Unity's own engine code uses `m_`, which is why the
> Animation window lists properties such as `m_Sprite` and `m_Color`). They're
> conventions too, of other teams. This course uses plain camelCase, and so does
> the exam.

### Idea — meaningful names

A name should say what the thing is for, so that nobody needs a comment to explain it.

| Weak | Better | Why |
| --- | --- | --- |
| `spd` | `runSpeed` | whole words, and which speed |
| `t` | `stateStartTime` | what the time is of |
| `flag` | `isGrounded` | a bool reads as a yes/no question |
| `DoStuff()` | `ResetLevel()` | a method says what it does, with a verb |
| `slime2` | `purpleSlime` | what makes it different, not its number |
| `delay` | `delaySeconds` | the unit, when it isn't obvious |

- **Booleans** read as a question with a yes/no answer: `isGrounded`, `hasKey`,
  `canJump`, `IsDead`.
- **Methods** start with a verb: `Jump`, `OpenDoor`, `AddCoin`, `TakeDamage`.
- **Counts** say what they count: `coinCount`, `livesLeft`.
- **Single letters** are fine for a loop counter (`i`) and for short maths (`x`, `y`),
  and nowhere else.

### Idea — where Unity cares about exact names

C# itself doesn't care which style you use: `void jump()` compiles. Unity does, in
four places, because it finds things **by name**:

| Where | The name must be | What happens if it's wrong |
| --- | --- | --- |
| Event functions | exactly `Start`, `Update`, `OnTriggerEnter2D`… | a method called `update` compiles, and Unity never calls it |
| A MonoBehaviour's file | the same as its class: `Slime.cs` holds `class Slime` | Unity can't add the script to a GameObject |
| Animator parameters | exactly as typed in the Animator: `"Speed"` | the Console warns that the parameter doesn't exist, and nothing animates |
| Animation Events | exactly the method's name | the Console says the event has no receiver |

> **Watch out:** a wrong-case event function is one of the hardest bugs to see,
> because there's no error at all. If `Update` seems never to run, check its spelling
> first.

### Idea — the same class, named badly and well

Both of these compile and do the same thing. Only one is easy to read:

```csharp
using UnityEngine;

public class door_script : MonoBehaviour
{
    [SerializeField] float S = 2f;
    bool o;
    float T;

    public void open()
    {
        o = true;
        T = 0f;
    }

    void Update()
    {
        if (o && T < 1f)
        {
            T += Time.deltaTime * S;
            transform.localScale = new Vector3(1f, 1f - T, 1f);
        }
    }
}
```

```csharp
using UnityEngine;

public class SlidingDoor : MonoBehaviour
{
    [SerializeField] float openSpeed = 2f;
    bool isOpening;
    float openAmount;

    public void Open()
    {
        isOpening = true;
        openAmount = 0f;
    }

    void Update()
    {
        if (isOpening && openAmount < 1f)
        {
            openAmount += Time.deltaTime * openSpeed;
            transform.localScale = new Vector3(1f, 1f - openAmount, 1f);
        }
    }
}
```

Read them side by side. The first class name uses snake case; `S`, `o` and `T` say
nothing; `open()` is a public method with a small letter. In the second, every name
tells you its job, and the code almost reads as a sentence: *if it's opening and the
open amount is under 1…*

### Idea — how the exam asks

Exam questions about naming give you a few lines and ask which one follows Unity's
conventions, or which name is wrong. For example: *which declaration follows the
conventions for a private field set in the Inspector?*

- A. `[SerializeField] float JumpHeight;`
- B. `[SerializeField] float jump_height;`
- C. `[SerializeField] float jumpHeight;`
- D. `[SerializeField] float JUMPHEIGHT;`

The answer is C: a field is camelCase. A looks like a property, B uses snake case, and
D looks like a constant from another language.

### Do it

1. Rename each of these to follow the conventions: a class `player_health`; a method
   `getScore()`; a private field `MaxSpeed`; a bool `dead`; a constant
   `const int max_lives = 3;`; an enum `enum colour { red, green }`.
2. In a `Practice` script, write `void update()` with a `Debug.Log` inside, and press
   **Play**. Nothing appears. Fix the name, and it does.
3. Open one of your own scripts from Level 2 and find three names you'd now write
   differently. Rename them (right-click a name in VS Code → **Rename Symbol** changes
   every use at once).

### Challenge

Write a small class `TreasureChest` with: a `[SerializeField]` number of coins inside, a
bool that says whether it's been opened, a property that other scripts can read but not
change saying the same thing, a constant for the most coins a chest can hold, and a
method that opens it and returns the coins. Name every part by the rules in this
chapter, then ask a partner to guess what each part does from its name alone.

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
- Every name reads as what it is (C# 1): `isGrounded` and `isFacingLeft` are
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

## C# 2 — The Animation Window

**Goal:** you can make animation clips in Unity's Animation window: clips that swap a
sprite's frames, and clips that change properties such as position, scale and colour
over time.

### Idea — what a clip is

An **animation clip** is an asset (a `.anim` file) that says how some properties of a
GameObject change over time. Each property gets a **curve**: its value at every moment
of the clip. The moments you set by hand are **keyframes**, and Unity works out every
moment in between.

| A clip can change… | For example |
| --- | --- |
| a Sprite Renderer's **Sprite** | a run made of 16 pictures, one after another |
| a Transform's **Position**, **Rotation** or **Scale** | a coin bobbing up and down, a door swinging |
| a Sprite Renderer's **Color** | a flash of red, a fade to nothing |
| almost any number, colour or tick box of a component | a light's brightness, a collider's size |

There are two kinds of animation in a 2D game, and one clip can mix them:

- **Sprite-frame animation:** a series of drawings shown one after another, like a
  flip-book. A curve of the Sprite property, with one keyframe per drawing.
- **Property animation:** one drawing, moved, turned, scaled or tinted. Curves of
  numbers.

> **Note:** a clip changes values, nothing more. It can't run your code, except
> through Animation Events (C# 5).

### Idea — the window

Open it with **Window → Animation → Animation** (or **Ctrl + 6**, **Cmd + 6** on a
Mac), and dock it beside the Console. It always shows the clips of the GameObject
selected in the Hierarchy.

| Part | What it does |
| --- | --- |
| **Clip menu** (top-left) | the selected object's clips; **Create New Clip…** adds another |
| **Record** (the red dot) | while it's on, every change you make in the Inspector becomes a keyframe |
| **Add Property** | adds a curve for one property, without recording |
| **Timeline** | time runs left to right; the white line is the **playhead** |
| **Add Keyframe** and **Add Event** | add a keyframe, or an Animation Event, at the playhead |
| **Dopesheet** / **Curves** (bottom) | keyframes as diamonds, or the curves themselves |

To make the first clip of an object, select it and click **Create** in the Animation
window, then save the clip, for example as `Assets/Animation/Door Open.anim`. If the
object has no **Animator** yet, Unity adds one, and makes an **Animator Controller** for
it, named after the object. The next chapter is about that controller.

### Idea — frames per second

A clip has a **sample rate**: how many frames it shows in a second. Pixel-art
animations are drawn for 8 to 16 frames a second, not the 60 the window starts with.
In the Animation window's **⋮** menu, tick **Show Sample Rate**, and a **Samples**
field appears. Set it **before** you add sprite frames: dragged frames land one sample
apart.

| Samples | One frame lasts | 8 frames take |
| --- | --- | --- |
| 8 | 0.125 s | 1 s |
| 12 | 0.083 s | 0.67 s |
| 16 | 0.0625 s | 0.5 s |

### Idea — a sprite-frame clip

1. Slice the sprite sheet first (Sprite Mode **Multiple**, then the **Sprite Editor**),
   so that each frame is its own sprite.
2. Select the GameObject, and create a clip.
3. Set **Samples**.
4. In the Project window, open the sheet's arrow, click its first frame, Shift-click
   its last, and drag them all into the timeline.

Unity puts one keyframe on each sample, and the clip lasts as long as its frames: 16
frames at 16 samples make a one-second clip. Press the window's **Play** button to
watch it in the Scene view.

### Idea — a property clip

1. Select the GameObject, create a clip, and turn on **Record**.
2. Move the playhead to `0:00` and set a property in the Inspector, for example
   **Position Y** to `0`. A keyframe appears, and the property turns red in the
   Inspector: it's animated now.
3. Move the playhead to `0:30` (half a second, at 60 samples) and set **Position Y** to
   `0.5`. Another keyframe.
4. Move to `1:00` and set it back to `0`. Turn **Record** off, and play: the object bobs.

The numbers in the timeline are **seconds:frames**: `1:30` is one second and 30
frames.

**Add Property** does the same without recording: pick the component and the property,
and Unity adds a curve with two keyframes you can then move and change.

> **Watch out:** forgetting to turn **Record** off is the classic mistake. Every change
> you make to the object afterwards, even moving it in the scene, turns into another
> keyframe. If a value keeps snapping back while you edit, look for the red dot.

### Idea — curves and tangents

In **Curves** view you see how a value moves between its keyframes. A keyframe's
**tangents** set the shape of the curve: right-click a keyframe to choose.

| Tangent | The value… | Good for |
| --- | --- | --- |
| **Auto** / **Clamped Auto** (the default) | eases in and out smoothly | bobbing, swinging |
| **Linear** | changes at a steady rate | fades, steady turns |
| **Constant** | jumps at the keyframe and holds | blinking, on/off |

A Sprite curve always jumps: a picture can't be halfway between two pictures.

### Idea — the clip's own settings

Select the clip asset in the Project window to see its Inspector:

| Setting | Means |
| --- | --- |
| **Loop Time** | when the clip ends, it starts again: on for idle and run, **off** for things that happen once, such as an attack or a death |
| **Loop Pose** | for 3D characters' bodies; leave it off in 2D |

### Idea — animating a child

A clip belongs to the GameObject with the **Animator**, but it can change that object's
children too. **Add Property** lists them: a curve on a child called `Sign` shows as
**Sign : Sprite Renderer.Color**. The child's name is part of the curve's **path**, so
renaming the child breaks the curve: it turns yellow and says **(Missing!)**. Rename it
back, or move the curve to the new name.

### Do it

1. Make a coin bob: a sprite with a property clip that moves its **Position Y** from 0
   to 0.3 and back over one second, with **Loop Time** on.
2. Make a warning light blink: a property clip on a sprite's **Color**, white at
   `0:00`, red at `0:15`, white at `0:30`. Then change the keyframes' tangents to
   **Constant** and compare.
3. Slice any sheet of frames into sprites, and make a sprite-frame clip from four of
   them at 8 samples. Play it at 4 samples, then at 16.
4. Leave **Record** on by mistake, move the object, and watch a keyframe appear. Undo
   it, and turn **Record** off.

### Challenge

Make a door that opens: an empty GameObject `Door` with a child sprite called `Panel`,
and a clip on `Door` that turns `Panel` (its **Rotation Z** from 0 to 90 over half a
second), with **Loop Time** off. Then rename the child and watch the curve break; rename
it back.

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

## C# 3 — The Animator Controller

**Goal:** you can build a state machine in the Animator: states that play clips,
transitions between them, and the parameters and conditions that choose a transition.
Exam objectives U 4.3 and U 4.4 are about exactly this.

### Idea — three things with similar names

| Thing | What it is | Where |
| --- | --- | --- |
| **Animation clip** | how properties change over time (a `.anim` asset) | the Project window |
| **Animator Controller** | the state machine that chooses which clip plays (a `.controller` asset) | the Project window, opened in the **Animator** window |
| **Animator** component | plays a controller on one GameObject | the GameObject's Inspector |

Many GameObjects can share one controller: every slime in a level uses the same one,
and each slime's Animator keeps its own place in it.

### Idea — the Animator window

Open it with **Window → Animation → Animator**, and select a GameObject that has an
Animator. Each **state** is a box, and each state plays one clip (its **Motion**).

| Box | Means |
| --- | --- |
| an orange state | the **default state**: where the machine starts. Right-click another state → **Set as Layer Default State** to change it |
| a grey state | any other state |
| **Entry** (green) | where the machine comes in; its arrow points at the default state |
| **Any State** (blue) | stands for every state at once: a transition from it can fire from wherever the machine is |
| **Exit** (red) | leaves a sub-state machine; you won't need it in Level 3 |

Every clip you create in the Animation window gets its own state, named after the clip.
You can rename a state in its Inspector: the name is what code and the exam refer to.

While the game plays, select the object, and the Animator window shows the current
state with a moving blue bar: the best way to see why an animation isn't playing.

### Idea — parameters

**Parameters** are the controller's own variables, listed on the window's **Parameters**
tab. Click **+** to add one. Code sets them (C# 4), and transitions read them.

| Type | Holds | A condition can ask | Good for |
| --- | --- | --- | --- |
| **Float** | a number with a fraction | **Greater** or **Less** than a value | how fast he runs, how fast he falls |
| **Int** | a whole number | **Greater**, **Less**, **Equals** or **NotEqual** | which of several states the code is in |
| **Bool** | true or false, until it's changed | **true** or **false** | something that stays: grounded, open, lit |
| **Trigger** | a one-off signal | that it has been fired | something that happens once: jump, hurt, die |

A **Trigger** is like a Bool that switches itself off as soon as a transition uses it.
If no transition uses it, it waits, still set, until one can.

### Idea — transitions and conditions

A **transition** is an arrow from one state to another: right-click the first state →
**Make Transition**, then click the second. Select the arrow to see its settings in the
Inspector, and its **Conditions** list at the bottom.

- **Several conditions on one transition** must all be true: *AND*.
- **Several transitions out of one state** are checked in their order in the list, and
  the first that's ready wins: *OR*.
- **A transition with no conditions** is only allowed with Has Exit Time on (below):
  then it fires when the clip reaches its exit time.

| Transition | Conditions | Fires when… |
| --- | --- | --- |
| Idle → Run | `Speed` Greater `0.1` | the speed goes over 0.1 |
| Idle → Jump | `Grounded` false, **and** `VerticalSpeed` Greater `0.1` | he leaves the ground going up |
| Any State → Hurt | `Hurt` (a trigger) | code fires `Hurt`, whatever state he's in |

### Idea — the settings that change how a transition behaves

| Setting | Means | For sprite animation |
| --- | --- | --- |
| **Has Exit Time** | the transition waits until the clip has played to its **Exit Time** | **on** only after one-shot clips (an attack, a hurt), so they finish; **off** everywhere else, or every change waits for the clip to end |
| **Exit Time** | how far through the clip, where 1 is the end | `1` |
| **Fixed Duration** | the duration below is in seconds (on) or in parts of the clip (off) | on |
| **Transition Duration** | how long the two clips blend together | `0`: two drawings can't blend, so blending only delays the change |
| **Transition Offset** | where in the next clip to start | `0` |
| **Interruption Source** | whether another transition can cut this one short | `None` when the duration is 0 |
| **Can Transition To Self** (Any State only) | the transition may fire even when the machine is already in that state | **off**, or a held key or a parameter that stays true restarts the clip every frame |

> **Watch out:** **Has Exit Time** is on by default when you make a transition. Left on
> between Idle and Run, the knight keeps idling until the Idle clip ends, and running
> feels late. It's the most common Animator mistake, and exam questions about it are
> common too.

### Idea — the state's own settings

Select a state to see them:

| Setting | Means |
| --- | --- |
| **Motion** | the clip it plays |
| **Speed** | how fast it plays the clip: `2` is twice as fast. Two states can share one clip at different speeds |
| **Write Defaults** | properties this state's clip doesn't animate go back to the values they had at the start. Leave it on |

> **Note:** two more Animator tools, **layers** (two state machines at once, such as legs
> and arms) and **blend trees** (blending several clips by a parameter), belong to
> Level 5. For a 2D sprite character you need neither.

### Idea — reading a state machine

Exam questions give you a machine and ask what plays. Here's one for a door, with a
Bool parameter `IsOpen`:

```
                IsOpen = true                         (Has Exit Time)
   Entry → Closed ────────────────→ Opening ─────────────────────→ Open
             ↑                                                      │
             │       (Has Exit Time)              IsOpen = false    │
             └────────────────────── Closing ←──────────────────────┘
```

- The door starts in **Closed**: Entry points there.
- Code sets `IsOpen` to true: **Closed → Opening** fires at once (no exit time).
- **Opening → Open** has no condition: it fires when the Opening clip ends.
- `IsOpen` stays true, so the door stays **Open** until code sets it to false.

What if code sets `IsOpen` to false halfway through **Opening**? Nothing happens until
Opening ends and the machine reaches **Open**: then `IsOpen = false` sends it on to
**Closing** at once. A machine only follows the arrows out of the state it's in.

### Do it

1. Make a cube or sprite with three property clips: **Red**, **Yellow** and **Green**
   (each sets its colour). In its Animator, add a Trigger called `Next` and transitions
   Green → Yellow → Red → Green, each on `Next`, with Has Exit Time off and a duration
   of 0. Play, select the object, and click the trigger's circle on the Parameters tab
   to fire it by hand.
2. Build the door machine above, with clips of your own (the door's scale or rotation).
   Tick and untick `IsOpen` by hand while it plays. Try unticking it halfway through
   Opening.
3. Turn **Has Exit Time** on for Green → Yellow, and fire `Next` early in the Green
   clip. When does the light change now?

### Challenge

Give the traffic light a **Broken** state, with a clip that flashes yellow, reached from
**Any State** when a Bool `IsBroken` is true. Leave **Can Transition To Self** on, tick
`IsBroken`, and watch the flashing: it never gets past the first frame, because the
transition fires again every frame. Turn the setting off and try again. Then add a way
back from Broken to Red, for when `IsBroken` is false.

## C# 4 — Driving the Animator from Code

**Goal:** you can set an Animator's parameters from a script, and you can say which call
makes a given state play. Exam objective U 2.3 asks exactly that.

### Idea — code sets parameters, the Animator chooses states

Your script doesn't usually tell the Animator *which state to play*. It tells it what's
true right now, through the parameters (C# 3), and the transitions you drew
choose the state. That keeps the decisions in one place: change a transition in the
Animator window, and no code changes.

| Parameter type | The call | Example |
| --- | --- | --- |
| Float | `SetFloat(name, value)` | `animator.SetFloat("Speed", 4.5f);` |
| Int | `SetInteger(name, value)` | `animator.SetInteger("State", 2);` |
| Bool | `SetBool(name, value)` | `animator.SetBool("IsOpen", true);` |
| Trigger | `SetTrigger(name)` | `animator.SetTrigger("Jump");` |
| Trigger | `ResetTrigger(name)` | `animator.ResetTrigger("Jump");` clears it, unused |

Each has a matching getter, such as `GetFloat("Speed")` and `GetBool("IsOpen")`, to
read a value back.

### Idea — a first script

Add an Animator and a controller with a Bool `IsOpen` and a Trigger `Next` to an
object, then give it this:

```csharp
using UnityEngine;
using UnityEngine.InputSystem;

public class Practice : MonoBehaviour
{
    [SerializeField] Animator animator;

    void Update()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard == null)
        {
            return;
        }

        // A Bool can follow something every frame: open while O is held.
        animator.SetBool("IsOpen", keyboard.oKey.isPressed);

        // A Trigger is fired once, when something happens.
        if (keyboard.nKey.wasPressedThisFrame)
        {
            animator.SetTrigger("Next");
            Debug.Log("Next!");
        }
    }
}
```

Drag the object's Animator into the **Animator** field. While it plays, watch the
**Parameters** tab: `IsOpen` ticks and unticks as you hold **O**, and `Next` lights up
for a moment each time you press **N**.

### Idea — which call makes a state play?

To answer, follow the arrow **into** the state and read its condition:

| The transition into the state has… | The call that makes it fire |
| --- | --- |
| `Speed` Greater `0.1` | `SetFloat("Speed", 3f)`: any number over 0.1 |
| `State` Equals `2` | `SetInteger("State", 2)` |
| `IsOpen` true | `SetBool("IsOpen", true)` |
| `Jump` (a Trigger) | `SetTrigger("Jump")` |
| no condition, Has Exit Time on | no call: it fires when the previous clip ends |

And the machine must already be in the state the arrow starts from. If the only arrow
into **Jump** starts at **Idle**, then `SetTrigger("Jump")` while running does nothing,
until the machine is back in Idle: then the trigger, still set, fires the jump.

> **Watch out:** a trigger that nobody uses stays set. Press jump in the air, and the
> knight may jump the moment he lands, long after you pressed. When a trigger shouldn't
> wait, fire it only when it can be used, or clear it with `ResetTrigger`.

### Idea — names are exact

Parameter names are **strings**, matched letter for letter, capitals included. A
mistake isn't a compile error. It's a warning in the Console when that line runs:

```
Parameter 'speed' does not exist.
```

And nothing animates. The same goes for the wrong call: `SetBool` on a Float parameter
changes nothing either, and the warning says so:

```
Parameter type 'Speed' does not match.
```

### Idea — hashes: names turned into numbers

Looking up a string every frame is slow, and a typo can hide in any of the places you
typed it. `Animator.StringToHash` turns a name into an `int` once, and every `Set` and
`Get` call also accepts that number:

```csharp
using UnityEngine;

public class RunAnimation : MonoBehaviour
{
    static readonly int SpeedHash = Animator.StringToHash("Speed");
    static readonly int GroundedHash = Animator.StringToHash("Grounded");

    [SerializeField] Animator animator;
    [SerializeField] Rigidbody2D body;

    void Update()
    {
        animator.SetFloat(SpeedHash, Mathf.Abs(body.linearVelocity.x));
        animator.SetBool(GroundedHash, Mathf.Abs(body.linearVelocity.y) < 0.01f);
    }
}
```

- `static`: one number for the whole class, worked out once, however many objects use
  the script.
- `readonly`: it can't be changed by mistake later.
- PascalCase names ending in `Hash`, as for every `static readonly` value
  (C# 1).

The name is still a string, so a typo in `"Speed"` still breaks it, but now the string
is written once, at the top of the script, where it's easy to check against the
Animator window.

A hash has one catch. Unity only receives the number, so its warning can't tell you the
name:

```
Parameter 'Hash 254213878' does not exist.
```

Click the warning: the stack trace under it names your script and the line that called
`SetFloat`. That line's hash comes from one of the `StringToHash` lines at the top:
check their spelling against the Animator window.

### Idea — asking the Animator where it is

Usually you don't need to know: your own code knows what it told the Animator. When you
do (in a test, or to wait for an animation), ask for the current state of layer 0:

```csharp
using UnityEngine;

public class StateReport : MonoBehaviour
{
    [SerializeField] Animator animator;

    void Update()
    {
        AnimatorStateInfo info = animator.GetCurrentAnimatorStateInfo(0);
        if (info.IsName("Run"))
        {
            // normalizedTime counts the clip's plays: 0.5 is halfway, 2.25 is a quarter into the third.
            Debug.Log($"Running, {info.normalizedTime:0.00} plays in");
        }
    }
}
```

### Idea — jumping straight to a state, and starting again

Two calls skip the transitions altogether. Use them for resets, not for normal play:

| Call | Does |
| --- | --- |
| `animator.Play("Idle")` | jumps straight into the state called `Idle`; the parameters keep their values |
| `animator.Rebind()` | puts the whole Animator back as it was at the start: the default state, every parameter at its default |

A state with no way out, such as **Dead**, needs one of these when the game restarts.

> **Watch out:** `Rebind` also remembers the values that animated properties have
> *right now*, as the ones to go back to. If a death clip has faded the sprite to
> nothing, set its colour back first, then call `Rebind`. In the other order, the
> character comes back invisible.

### Do it

1. Make the Practice script above work, with the door or traffic-light controller from
   C# 3.
2. Misspell `"IsOpen"` as `"isOpen"`, play, and read the warning. Put it right.
3. Change the script to use hashes for both parameters.
4. Give the traffic light an Int parameter `Colour` (0 green, 1 yellow, 2 red), with an
   Any State transition into each colour on `Colour` Equals its number. Set it from the
   keys **1**, **2** and **3** with `SetInteger`.

### Challenge

Press **N** three times quickly while the light is changing. How many changes do you
get? Then fire `Next` only when the current state's clip has finished
(`normalizedTime >= 1`), and try again.

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
  (C# 4). The names must match the Animator's exactly: `Speed`, not `speed`.
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

## C# 5 — Animation Events

**Goal:** you can make a clip call one of your methods at an exact moment, and you can
spot the mistakes that stop it working. Exam objective U 3.3 includes these mistakes.

### Idea — a clip that calls your code

An **Animation Event** is a marker on a clip's timeline with a method's name on it. When
the clip plays past the marker, Unity calls that method on the scripts of the
GameObject that plays the clip.

They're for things that must happen **on a frame**, not after a time you'd have to keep
in step by hand:

| On this frame… | the event calls… |
| --- | --- |
| a sword reaches the enemy | `OnAttackHit()`: now look for what was hit |
| a foot touches the ground | `OnFootstep()`: play a step sound |
| a monster finishes winding up | `OnLeap()`: now jump |
| the last frame of a roll | `OnRollFinished()`: control comes back |
| the end of a death | `OnDeathFinished()`: show the Try Again panel |

Change the clip's speed, or redraw it with more frames, and the event moves with its
frame. A timer in code would be wrong as soon as the art changed.

### Idea — adding one

1. Open the Animation window and select the GameObject with the Animator.
2. Pick the clip, and move the playhead to the frame.
3. Click **Add Event** (the marker button beside **Add Keyframe**). A white marker
   appears above the timeline.
4. With the marker selected, the Inspector shows **Function**: a list of the methods
   on that GameObject's scripts. Pick one.

Drag a marker to move it, or select it and press **Delete** to remove it.

Here's a script with methods for events:

```csharp
using UnityEngine;

public class Practice : MonoBehaviour
{
    // Called by an Animation Event on the clip's last frame.
    public void OnSwingFinished()
    {
        Debug.Log("Swing finished at " + Time.time);
    }

    // An event can pass one value: here, which foot (set its Int in the Inspector).
    public void OnStep(int foot)
    {
        Debug.Log("Step with foot " + foot);
    }
}
```

### Idea — the rules for the method

| Rule | Why |
| --- | --- |
| It's in a script **on the same GameObject as the Animator** | Unity only looks there: not on the parent, not on a child |
| Its name matches the event's **exactly** | Unity finds it by name, as it finds `Update` |
| It returns `void` | an event throws away anything a method returns, so this course always writes `void` |
| It takes **no parameter**, or **one** of: `float`, `int`, `string`, an `enum`, an `Object`, or an `AnimationEvent` | the event's Inspector has one box of each kind to fill in |

Unity finds the method whether it's `public` or `private`. This course makes
event methods `public`, and starts their names with `On`, so you can tell them from
other methods at a glance (C# 1).

### Idea — the errors

Each mistake shows up in the Console when the clip reaches the marker, not when you
compile. Learn to recognise them:

| The Console says… | Because |
| --- | --- |
| `'Knight' AnimationEvent 'OnFootStep' on animation 'Knight Run' has no receiver! Are you missing a component?` | no script on the GameObject `Knight` has a method of that name: a typo (`OnFootStep` for `OnFootstep`), or the script is on another object |
| `Failed to call AnimationEvent OnStep of class Practice. The function must have either 0 or 1 parameters and the parameter can only be: string, float, int, enum, Object, AnimationEvent or AnimationEventInfo.` | the method takes a parameter of a type an event can't send, such as a `Vector2` or a `bool`, or more than one |

The worst mistake gives no message at all: an event that **never fires**, because the
clip never reaches it.

- A transition with **Has Exit Time** off can leave a clip before its last frame, and an
  event on that frame never runs.
- Code can cut a clip short: `Rebind`, `Play`, or another state's trigger.
- An event near the very end of a clip that leaves it with a blending transition may be
  skipped.

So never let an important flag wait **only** for an event. If an event ends a roll by
setting `isRolling = false`, the code that resets the character after a fall must set
it too.

> **Watch out:** on a **looping** clip, an event fires on every loop: four footsteps a
> second if the run loops once a second with four markers. That's what you want for
> footsteps, and a bug for an event that should happen once.

### Idea — events and the exam

Questions show a clip with an event and a script, and ask why nothing happens. Check, in
order: is the script on the same GameObject as the Animator? Does the name match, case
included? Does the method take a parameter an event can send? Does the clip really
reach the marker?

### Do it

1. Put the Practice script on an animated object. On one of its clips, add an event on
   the last frame that calls `OnSwingFinished`. Play, and read the Console: one line
   per loop.
2. Add an event that calls `OnStep`, and set its **Int** to `1` in the Inspector. Add a
   second one, with `2`.
3. Rename the method to `OnSwingDone` in the script, without changing the event. Play,
   and read the error. Put it right.
4. Move the Practice script to a child of the animated object. Play, and read the
   error. Move it back.

### Challenge

Make an event that fires on a clip's last frame, and a transition out of that clip with
**Has Exit Time** off on a key press. Press the key halfway through the clip, again and
again. Does the event ever run? Write down when it does and when it doesn't.

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
  are called by Animation Events (C# 1). Nothing in the script calls them.
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

## C# 6 — State Machines with enum and switch

**Goal:** you can write a state machine in C#: an `enum` of states, a field that holds
the current one, a `switch` that does each state's work, and an enter step that runs
once as each state begins.

### Idea — one state at a time

Lots of things in a game are always in exactly one of a few **states**:

| Thing | Its states |
| --- | --- |
| a traffic light | Green, Yellow, Red |
| a door | Closed, Opening, Open, Closing |
| an enemy | Patrol, Chase, Attack, Hurt, Dead |
| the game itself | Start, Playing, Paused, Won, Lost |

A **state machine** is code built round that idea: it knows its current state, does
that state's work, and follows rules to move from one state to another. You can draw
one before you write it:

```
           3 seconds             1 second
   Green ───────────→ Yellow ───────────→ Red
     ↑                                      │
     └──────────────────────────────────────┘
                     3 seconds
```

The Animator is a state machine too (C# 3). Writing one in code lets your
scripts make the same kind of decisions.

### Idea — the three parts

```csharp
using UnityEngine;

public class TrafficLight : MonoBehaviour
{
    // 1. The states: an enum, as in Level 1.
    enum State { Green, Yellow, Red }

    // 2. The current state, and when it began.
    State state;
    float stateStartTime;

    void Start()
    {
        EnterState(State.Green);
    }

    // 3. Every frame, the current state does its work, and may move on.
    void Update()
    {
        float timeInState = Time.time - stateStartTime;
        switch (state)
        {
            case State.Green:
                if (timeInState >= 3f)
                {
                    EnterState(State.Yellow);
                }
                break;
            case State.Yellow:
                if (timeInState >= 1f)
                {
                    EnterState(State.Red);
                }
                break;
            case State.Red:
                if (timeInState >= 3f)
                {
                    EnterState(State.Green);
                }
                break;
        }
    }

    // The one place the state changes. Its enter step runs once, on arrival.
    void EnterState(State next)
    {
        state = next;
        stateStartTime = Time.time;
        Debug.Log("Now " + state);
    }
}
```

```
Now Green
Now Yellow
Now Red
Now Green
```

The lines appear 3 seconds, 1 second and 3 seconds apart.

| Part | Job |
| --- | --- |
| the `enum` | names every state, so a typo is a compile error, not a bug |
| the `state` field | holds the one current state |
| the `switch` in `Update` | runs every frame: the current state's work, and its checks for moving on |
| `EnterState` | runs once per change: remember when the state began, play a sound, tell the Animator… |

### Idea — why an enter step

Some things must happen once, when a state begins, not on every frame of it: a sound, a
timer starting, an Animator parameter, switching a collider off. Put them in
`EnterState`, and they happen once, however long the state lasts.

The other rule matters as much: **only `EnterState` changes `state`.** A line like
`state = State.Red;` somewhere else compiles, but it skips the enter step: no timer
starts, no sound plays, and the state's timer is left over from the state before. When
every change goes through one method, there's one place to look when a change goes
wrong, and one line to add when every change should log, or set the Animator.

The `switch` can call a method per state when a state's work grows:

```csharp
using UnityEngine;

public class Lamp : MonoBehaviour
{
    enum State { Off, On, Flickering }

    State state;

    void Start()
    {
        EnterState(State.On);
    }

    void Update()
    {
        switch (state)
        {
            case State.Off:
                break;                  // nothing to do: it waits
            case State.On:
                UpdateOn();
                break;
            case State.Flickering:
                UpdateFlickering();
                break;
        }
    }

    void UpdateOn()
    {
        if (Random.value < 0.001f)
        {
            EnterState(State.Flickering);
        }
    }

    void UpdateFlickering()
    {
        GetComponent<SpriteRenderer>().enabled = Random.value > 0.5f;
    }

    void EnterState(State next)
    {
        state = next;
        Debug.Log("The lamp is " + state);
    }
}
```

A state with nothing to do still gets its own `case` with a comment: then you can see
that it was thought of, not forgotten.

### Idea — the mistakes

| Mistake | What happens |
| --- | --- |
| a `case` without `break` | a compile error: C# won't let one case fall into the next |
| `state = …` outside `EnterState` | the enter step never runs: no sound, a stale timer |
| calling `EnterState` every frame | the enter step runs every frame: the timer never gets past 0 |
| a long `if` / `else if` chain instead of a `switch` | works, but it's easy to test the same state twice, or none |
| a new state added to the `enum` but not to the `switch` | it does nothing, silently. A `default:` case that logs a warning catches it |

### Idea — states and the exam

Exam questions give a state machine, in code or as a drawing, and ask what happens: what
the state is after some events, which line moves it on, or why a state never changes.
Trace it like a table: the state, the time, what each frame checks.

| Time | State | Green's check: `timeInState >= 3f`? |
| --- | --- | --- |
| 0.0 | Green | no |
| 2.9 | Green | no |
| 3.0 | Green → **Yellow** | yes: `EnterState(State.Yellow)` |

### Do it

1. Make the traffic light work: put it on a sprite, and also set the sprite's colour in
   `EnterState` with a `switch` of its own.
2. Add a fourth state, **Off**, entered when you press **O** in any state, and left when
   you press **O** again, back to Green.
3. Break it on purpose: replace one `EnterState(State.Red);` with `state = State.Red;`.
   What goes wrong with the timer, and why?
4. Add `default: Debug.LogWarning("No case for " + state); break;` to the `switch`, add
   a state to the `enum` without a case, and enter it.

### Challenge

Write a door as a state machine: Closed, Opening, Open and Closing. **Space** starts it
opening (only from Closed) and closing (only from Open); Opening and Closing each take a
second, scaling the door's height from 1 to 0 or back. Draw the machine before you
write a line.

## C# 7 — Enemies as State Machines

**Goal:** you can write an enemy as a state machine in code, and keep its Animator in
step with it, either through an Int that mirrors the code's `enum`, or through
parameters that describe what the enemy is doing.

### Idea — an enemy is a few states and their rules

Before any code, draw the enemy. Here's a guard:

```
                player within 4 units                  player within 1 unit
   Patrol ─────────────────────────→ Chase ─────────────────────────→ Attack
     ↑                                │ ↑                                │
     └── player more than 6 away ─────┘ └──── the attack has finished ───┘
```

Each arrow is a rule in code: a distance, a timer, a health check. Notice the two
distances: the guard notices the player at 4 units but only gives up at 6. With one
number for both, a player standing at the edge makes the guard flip between Patrol and
Chase every frame.

### Idea — the guard in code

```csharp
using UnityEngine;

public class Guard : MonoBehaviour
{
    public enum State { Patrol, Chase, Attack }

    [SerializeField] Transform player;
    [SerializeField] float patrolSpeed = 1.5f;
    [SerializeField] float chaseSpeed = 3f;
    [SerializeField] float noticeRange = 4f;
    [SerializeField] float giveUpRange = 6f;
    [SerializeField] float attackRange = 1f;
    [SerializeField] float attackSeconds = 0.8f;

    State state;
    float stateStartTime;
    float direction = 1f;

    void Start()
    {
        EnterState(State.Patrol);
    }

    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.position);
        switch (state)
        {
            case State.Patrol:
                transform.Translate(direction * patrolSpeed * Time.deltaTime, 0f, 0f);
                if (distance < noticeRange)
                {
                    EnterState(State.Chase);
                }
                break;
            case State.Chase:
                direction = player.position.x < transform.position.x ? -1f : 1f;
                transform.Translate(direction * chaseSpeed * Time.deltaTime, 0f, 0f);
                if (distance < attackRange)
                {
                    EnterState(State.Attack);
                }
                else if (distance > giveUpRange)
                {
                    EnterState(State.Patrol);
                }
                break;
            case State.Attack:
                if (Time.time - stateStartTime >= attackSeconds)
                {
                    EnterState(State.Chase);
                }
                break;
        }
    }

    void EnterState(State next)
    {
        state = next;
        stateStartTime = Time.time;
        Debug.Log("Guard: " + state);
    }
}
```

Put it on a sprite, drag something that moves (with the keyboard) into **Player**, and
walk towards the guard and away:

```
Guard: Patrol
Guard: Chase
Guard: Attack
Guard: Chase
Guard: Patrol
```

> **Note:** this guard moves with `transform.Translate`, so it walks through walls. A
> real enemy has a Rigidbody 2D and sets its velocity, and looks ahead with a short
> raycast before it walks: is there ground in front of it? Then it never chases the
> player off a ledge.

### Idea — two machines that must agree

The guard's code knows its state, and its Animator has states of its own. They must
agree, or the guard attacks while its Animator shows it walking. There are two good
ways to keep them together.

**1. The Animator follows the code.** Give the controller an **Int** parameter, `State`.
Give each Animator state an **Any State** transition with the condition `State`
**Equals** its number, with **Can Transition To Self** off. Then the enter step tells
the Animator, in one line:

```csharp
public class Guard : MonoBehaviour
{
    static readonly int StateHash = Animator.StringToHash("State");

    [SerializeField] Animator animator;
    // … the other fields and methods, as before …

    void EnterState(State next)
    {
        state = next;
        stateStartTime = Time.time;
        animator.SetInteger(StateHash, (int)state);
    }
}
```

`(int)state` turns the enum value into its number. An enum's values are numbered from
0, in the order they're written:

| `State` | `(int)` |
| --- | --- |
| `State.Patrol` | 0 |
| `State.Chase` | 1 |
| `State.Attack` | 2 |

So the code's machine decides, and the Animator plays whatever the code says. This
suits enemies, whose states are decisions.

**2. The Animator decides, from what the code reports.** Give the controller
parameters that describe the enemy, such as a Float `Speed`, a Bool `IsAlert` and a
Trigger `Attack`, and draw normal transitions between its states. The code sets the
parameters every frame or when something happens, and the Animator's own transitions
choose the clip. This suits a player character, whose animation follows its movement:
run when moving, fall when falling.

| | The Animator follows the code (Int) | The Animator decides (parameters) |
| --- | --- | --- |
| Who chooses the state | the code's `switch` | the Animator's transitions |
| Parameters | one Int, `State` | Floats, Bools and Triggers |
| Transitions | one from Any State per state | drawn between the states |
| Best for | enemies and other things that make decisions | characters whose animation follows physics |

> **Watch out:** with the Int, the order of the `enum` *is* the Animator's numbering.
> Put a new state in the middle (`Patrol, Alert, Chase, Attack`) and Chase becomes 2:
> the Animator plays the Attack clip for it. Add new states at the end, or change every
> condition to match.

### Idea — timing with Animation Events

Some changes should wait for the animation itself: an enemy winds up, and only leaps
when its wind-up clip reaches its last frame. An Animation Event (C# 5) on
that frame calls the code, and the code changes state:

```csharp
// … in an enemy with WindUp and Leap states …

// Animation Event: the last frame of the WindUp clip.
public void OnWindUpFinished()
{
    // Something else may have changed the state first, such as a hit.
    if (state == State.WindUp)
    {
        EnterState(State.Leap);
    }
}
```

The `if` matters: if a hit has already sent the enemy to Hurt, the wind-up clip was cut
short, and a late event mustn't jump it back to Leap.

### Idea — many kinds of enemy

| Need | Use |
| --- | --- |
| the same behaviour, other numbers (a tougher, faster version) | **one script**, and a second prefab with other values in the Inspector |
| the same state machine, other pictures | an **Animator Override Controller** (below) |
| different behaviour | a separate script, with its own state machine |

An **Animator Override Controller** is an asset that borrows another controller's whole
state machine, its states, parameters and transitions, and swaps its clips:

1. **Assets → Create → Animation → Animator Override Controller**, and name it.
2. Set its **Controller** to the original Animator Controller. Its Inspector lists every
   clip the original uses.
3. Drag a replacement clip next to each one.
4. Put the Override Controller in the second enemy's **Animator**, where the controller
   goes.

Change a transition in the original, and both enemies get the change.

> **Note:** Level 4 adds two more tools: prefab variants, a prefab that inherits from
> another, and interfaces, so that one script can hit any kind of enemy. Until then, a
> copy of the prefab and an `if` for each kind of script are the honest way.

### Idea — how the exam asks

*An enemy's Animator has an Any State transition into Chase with the condition `State`
Equals `1`. Which line makes it play Chase?*

- A. `animator.SetTrigger("Chase");`
- B. `animator.SetInteger("State", 1);`
- C. `animator.SetFloat("State", 1f);`
- D. `animator.Play("State");`

B: the condition reads an Int, so the call is `SetInteger`, with the number the
condition checks. A fires a trigger that doesn't exist; C uses the wrong type; D jumps
to a state called "State", which isn't there.

### Do it

1. Make the guard work, with a player you move with the arrow keys.
2. Give the guard an Animator with three clips (a colour each is enough: Patrol white,
   Chase yellow, Attack red) and the `State` Int, with an Any State transition into each
   state. Add the `SetInteger` line to `EnterState`.
3. Put `Alert` between `Patrol` and `Chase` in the enum, without changing the Animator.
   What colour does the guard turn when it chases? Put the enum back.
4. Make a second guard prefab that's faster and notices the player from further away,
   with no new code.

### Challenge

Add a **Stunned** state: when the player presses **S** within 2 units, the guard stops
for 1.5 seconds, whatever it was doing, then goes back to Patrol. Draw the new arrows
first. Which states can it be entered from?

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
the script says (C# 7). The controller has one **Int** parameter, `State`, and
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
  numbers must match the Animator's from the start (C# 7).
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
  So the colour is set back to white first (C# 4).

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
**Animator Override Controller** does exactly that (C# 7): it borrows the
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
colour curves have the path `Sign` (C# 2).

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

## C# 8 — Game UI: Health Bars, Menus and Pausing

**Goal:** you can show health with a bar that slides and changes colour, show a panel
for each part of the game (start, pause, win, lose), and pause the game so that
everything stops except its menus.

### Idea — a health bar is a Filled image

A UI **Image** has an **Image Type**. Set it to **Filled**, and two more settings
appear:

| Setting | Set it to | Means |
| --- | --- | --- |
| **Fill Method** | **Horizontal** | the image fills from side to side |
| **Fill Origin** | **Left** | it fills from the left, and empties towards it |
| **Fill Amount** | a number from 0 to 1 | how much of it shows: 1 is full, 0.6 is three-fifths |

A **Filled** image needs a **Source Image**: any sprite works, such as Unity's own
**UISprite**. Put the bar in front of a darker image of the same size, its
background, and the empty part shows dark.

In code, the fill amount is the health as a share of the most it can be:

```csharp
int health = 3;
int maxHealth = 5;
Debug.Log(health / maxHealth);
Debug.Log((float)health / maxHealth);
```

```
0
0.6
```

> **Watch out:** `3 / 5` is **0** in C#: an `int` divided by an `int` gives an `int`,
> and the fraction is thrown away. Turn one of them into a `float` first, with
> `(float)`, and the result is 0.6. A bar that's always full or always empty is usually
> this bug.

### Idea — a bar that slides

A bar that jumps from 1 to 0.8 is hard to notice. A bar that slides there over a moment
catches the eye. Keep the value it should reach, and move the fill a little towards it
every frame:

```csharp
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] Image fill;
    [SerializeField] int maxHealth = 5;
    [SerializeField] float slideSpeed = 2f;     // how much of the bar it slides in a second

    int health;

    void Start()
    {
        health = maxHealth;
    }

    void Update()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard != null && keyboard.hKey.wasPressedThisFrame)
        {
            health = Mathf.Max(health - 1, 0);      // H hurts
        }
        if (keyboard != null && keyboard.gKey.wasPressedThisFrame)
        {
            health = Mathf.Min(health + 1, maxHealth);      // G heals
        }

        float target = (float)health / maxHealth;
        fill.fillAmount = Mathf.MoveTowards(fill.fillAmount, target, slideSpeed * Time.deltaTime);
        fill.color = Color.Lerp(Color.red, Color.green, fill.fillAmount);
    }
}
```

- `Mathf.MoveTowards(from, to, step)` moves `from` at most `step` closer to `to`, and
  never past it.
- `Color.Lerp(a, b, t)` mixes two colours: `t = 0` gives all `a`, `t = 1` all `b`,
  `t = 0.5` half of each. Here the bar turns from green to red as it empties.

> **Note:** a row of heart icons works too: an array of Images, with
> `hearts[i].enabled = i < health;` in a loop. Bars suit health that can be any amount;
> icons suit a few lives you can count.

### Idea — text on the screen

TextMeshPro texts (`TMP_Text`, from `using TMPro;`) show numbers with string
interpolation and the formats from Level 1:

| Code | Shows |
| --- | --- |
| `coinText.text = $"x {coins}";` | `x 12` |
| `scoreText.text = $"{score:D6}";` | `000420` |
| `timeText.text = $"{minutes}:{seconds:00}";` | `2:05` |

Time is easiest kept as seconds, and split only to show it: for 125 seconds,
`125 / 60` is 2 (whole minutes, `int` division doing what you want for once) and
`125 % 60` is 5.

### Idea — a panel for each part of the game

A game moves through parts: the start screen, playing, paused, won, lost. Give each its
own **panel**, a full-screen Image with the buttons and texts on it, and show exactly
one at a time with `SetActive`. A state machine (C# 6) is the natural
place to do it, in its enter step:

```csharp
using UnityEngine;

public class Menus : MonoBehaviour
{
    public enum Page { Start, Playing, Paused, GameOver }

    [SerializeField] GameObject startPanel;
    [SerializeField] GameObject pausePanel;
    [SerializeField] GameObject gameOverPanel;

    Page page;

    public void Show(Page next)
    {
        page = next;
        startPanel.SetActive(page == Page.Start);
        pausePanel.SetActive(page == Page.Paused);
        gameOverPanel.SetActive(page == Page.GameOver);
    }
}
```

`page == Page.Start` is a `bool`, true for one page only, so each panel shows in its
own state and hides in every other. While a panel shows, its dark, see-through
background also catches clicks, so they can't reach the game behind it.

### Idea — pausing with Time.timeScale

`Time.timeScale` is how fast game time runs: 1 is normal speed, 0.5 is slow motion, and
**0** stops it.

| With `Time.timeScale = 0`… | Stops? |
| --- | --- |
| physics: Rigidbodies, collisions and triggers | **stops** |
| `Time.deltaTime` | **becomes 0**, so movement in `Update` stops too |
| coroutines waiting on `WaitForSeconds` | **wait** |
| Animators (on their usual Update Mode, Normal) | **stop** |
| `Update` itself | **keeps running**: so read the pause key there |
| UI buttons and sliders | **keep working** |
| `Time.unscaledDeltaTime` and `WaitForSecondsRealtime` | keep counting real time |
| sound | **keeps playing**, unless you also set `AudioListener.pause = true` |

```csharp
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseKey : MonoBehaviour
{
    [SerializeField] GameObject pausePanel;

    bool isPaused;

    void Update()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard != null && keyboard.escapeKey.wasPressedThisFrame)
        {
            isPaused = !isPaused;
            Time.timeScale = isPaused ? 0f : 1f;
            pausePanel.SetActive(isPaused);
        }
    }
}
```

> **Watch out:** `Time.timeScale` stays where you left it. A Restart button on the pause
> panel must set it back to 1, or the new game starts frozen. Stopping the game in the
> Editor does put it back to 1, so this bug only shows while you play: pause, Restart,
> and the game doesn't move.

### Idea — menu buttons and the volume

Connect a panel's buttons and sliders in code with `AddListener`, as in Level 2: in the
panel's `OnEnable`, and take them off again in `OnDisable`. `AudioListener.volume`, from
0 (silent) to 1 (full), sets the volume of every sound in the game at once, which is
exactly what a volume slider needs:

```csharp
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] Slider slider;

    void OnEnable()
    {
        slider.SetValueWithoutNotify(AudioListener.volume);
        slider.onValueChanged.AddListener(OnVolumeChanged);
    }

    void OnDisable()
    {
        slider.onValueChanged.RemoveListener(OnVolumeChanged);
    }

    void OnVolumeChanged(float value)
    {
        AudioListener.volume = value;
    }
}
```

### Do it

1. Make the health bar: a Canvas, a dark Image, and a **Filled** Image in front of it.
   Put `HealthDisplay` on any object, drag the filled Image into **Fill**, and press
   **H** and **G** while it plays.
2. Change `(float)health / maxHealth` to `health / maxHealth`. What does the bar do now,
   and why?
3. Add a pause panel with a **Resume** button, and the `PauseKey` script. Give a
   moving object a Rigidbody 2D, and check that it freezes while the panel shows.
4. Pause with something animating, then make one thing keep moving while paused:
   change its movement to use `Time.unscaledDeltaTime`.

### Challenge

Show a countdown text that counts down from 60 seconds and keeps the format `m:ss`.
When it reaches 0, show a "Time's up" panel and pause the game. Pause and unpause
during the countdown: does it stop counting while paused? Make sure it does.

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
`PlatformerGame`'s Inspector, as a list to fill in (C# 11 has more on kinds of
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
  would be empty at 3 health (C# 8).
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
a hash (C# 4). How does `PlatformerGame` get hold of the icon's Animator?

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

It's the slime's pattern again (C# 6): an `enum`, a `state` field, and
one `EnterState` that every change goes through. Its enter step shows the state's panel
and hides the others (C# 8). Chapter 12 adds a fifth state, **Paused**.

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
back to 1 (C# 8). Since every change goes through `EnterState`, no button can
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
  them in `OnDisable`, when it hides (C# 8). `SetValueWithoutNotify` moves
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

## C# 9 — Reading Code

**Goal:** you can read a script you didn't write, say what it does, trace what it prints,
and pick the comment that describes it accurately. Exam objective U 3.6 asks for that
last one, and many other questions need the rest.

### Idea — read in this order

A script is easier to read in the order Unity uses it than from top to bottom:

1. **The class's name and its comment:** what is this for?
2. **The fields:** what does it remember, and what does it get from the Inspector?
   `[SerializeField]` fields are settings and references; the others are its state.
3. **`Awake` and `Start`:** what does it set up?
4. **`Update`**, and the other event functions: what does it do every frame, or when
   something touches it?
5. **The methods they call**, one at a time, as you meet them.

At each method, ask three questions: *what goes in* (its parameters and the fields it
reads), *what changes* (the fields it sets), and *what comes out* (what it returns, or
calls on other objects).

### Idea — trace it on paper

To be sure what code does, run it by hand with a table: one column per variable, one row
per step.

```csharp
int coins = 0;
int[] chests = { 3, 0, 5, 2 };
for (int i = 0; i < chests.Length; i++)
{
    if (chests[i] == 0)
    {
        continue;
    }
    coins += chests[i];
    if (coins > 6)
    {
        break;
    }
}
Debug.Log(coins);
```

| `i` | `chests[i]` | what happens | `coins` |
| --- | --- | --- | --- |
| 0 | 3 | add | 3 |
| 1 | 0 | `continue`: skip the rest of this turn | 3 |
| 2 | 5 | add, and 8 > 6: `break` out of the loop | 8 |

```
8
```

The last chest is never opened: `break` left the loop first. Tracing finds that kind of
thing; reading quickly doesn't.

### Idea — what makes a comment accurate

A comment is accurate when it says what the code **does**: not what it was meant to do,
not what it did last week, not more and not less.

```csharp
using UnityEngine;

public class Healer : MonoBehaviour
{
    [SerializeField] int maxHealth = 5;
    int health = 2;

    // ???
    public void Heal(int amount)
    {
        health = Mathf.Min(health + amount, maxHealth);
    }
}
```

Which comment belongs above `Heal`?

- A. `// Adds amount to health, but never above maxHealth.`
- B. `// Sets health to the smaller of amount and maxHealth.`
- C. `// Adds amount to health, and raises maxHealth if needed.`
- D. `// Heals the player to full health.`

**A.** B misses the `health +`: it describes `Mathf.Min(amount, maxHealth)`. C describes
`Mathf.Max`, and the code never changes `maxHealth`. D is only true when `amount` is big
enough. Each wrong answer is close to right: that's how exam distractors are made. Read
every word of each option against the code.

| A comment is wrong when it… | For example |
| --- | --- |
| gets a comparison the wrong way round | says "at least" for `<` |
| swaps who does what | says the enemy hurts the player, when the player hurts the enemy |
| gets the timing wrong | says "every frame" for code in `Start`, or "once" for code in `Update` |
| promises more than the code does | says "and plays a sound", with no sound in the code |
| describes code that was there before | the classic, after a change that wasn't followed by the comment |

### Idea — another one

```csharp
using UnityEngine;

public class Patroller : MonoBehaviour
{
    [SerializeField] float patrolDistance = 2f;
    Vector2 startPosition;
    float direction = 1f;

    void Awake()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // ???
        if (Mathf.Abs(transform.position.x - startPosition.x) > patrolDistance)
        {
            direction = -direction;
        }
        transform.Translate(direction * 2f * Time.deltaTime, 0f, 0f);
    }
}
```

- A. `// Turns round every patrolDistance seconds.`
- B. `// Turns round when it's further than patrolDistance from where it started, on either side.`
- C. `// Turns round when it reaches the start position.`
- D. `// Stops when it's further than patrolDistance from the start.`

**B.** `Mathf.Abs` makes the distance positive on both sides. A confuses distance with
time; C would test the distance against 0; D: nothing stops, `direction` flips.

> **Watch out:** this patroller has a bug that the comment won't show. If it overshoots
> by a little, it can still be over the distance on the next frame, flip again, and
> shake on the spot. Reading the code, not only the comment, is how you find that. The
> fix: turn round only if it's heading away (`direction` and the offset have the same
> sign).

### Idea — the three kinds of comment

| Kind | Looks like | Use |
| --- | --- | --- |
| line comment | `// up to the end of the line` | almost every comment |
| block comment | `/* across several lines */` | rarely: to switch off code for a moment |
| documentation comment | `/// <summary>Heals the player.</summary>` | in libraries; your IDE shows it when you hover over the method |

Good comments say **why**: `// Moving up is never standing: that's a jump just starting`
tells you something the code alone can't. A comment that repeats the code
(`health = 0; // set health to 0`) only adds something to keep up to date.

### Do it

1. Trace the coin loop with `{ 0, 4, 0, 4 }` and with `{ 7, 1 }`. Write the tables, then
   run them in a Practice script.
2. Write a wrong comment of each kind in the table above for the `Heal` method.
3. Fix the patroller's shake: turn round only when it's past the distance **and**
   heading away from the start.
4. Open a finished script from your current game, cover its comments with a piece of
   paper, and write your own for each method. Compare.

### Challenge

Swap a script with a partner, without its comments. Each of you writes a comment above
every method of the other's script. Then compare yours with the real ones: where you
differ, who's right? Run the code to settle it.

## C# 10 — Finding Errors

**Goal:** you can look at code and say why it won't compile or won't work: a wrong data
type, a `public` or `private` mix-up, an Animator or Animation Event mistake, or a
`null`. Exam objectives U 3.2 and U 3.3 are about these, and U 1.2 about the last.

### Idea — three kinds of mistake

| Kind | When you find out | How |
| --- | --- | --- |
| **Compile error** | as soon as you save | red in the Console, and Play won't start until it's fixed |
| **Runtime error** | when that line runs | red in the Console while playing, often `NullReferenceException`; that frame's `Update` stops at the line |
| **Logic bug** | when you notice the game is wrong | no message at all |

Double-click a compile error in the Console and your IDE opens at the line. The message
gives the file, the line and the column, then a code: `Door.cs(12,9): error CS0122`.
The code (`CS0122`) is worth reading: the same codes come back again and again.

### Idea — wrong data types (U 3.2)

C# checks that every value fits the type of the place it goes. These all fail to
compile:

```csharp
int lives = 2.5f;           // error CS0266: a float doesn't fit in an int
float speed = 5.0;          // error CS0664: 5.0 is a double; write 5.0f
string playerName = 10;     // error CS0029: a number isn't text
bool isAlive = 1;           // error CS0029: C# has no 1 for true
int coins = "5";            // error CS0029: text isn't a number
Vector2 position = 3f;      // error CS0029: one number isn't two
```

The same check applies to what a method returns, and to what you pass it:

```csharp
// error CS0266: the method says it returns an int, and 2.5f isn't one
int GetScore()
{
    return 2.5f;
}
```

```csharp
using UnityEngine;

public class StateSetter : MonoBehaviour
{
    [SerializeField] Animator animator;

    void Start()
    {
        animator.SetInteger("State", 1.5f);     // error CS1503: SetInteger wants an int
    }
}
```

The fixes are the right type (`int lives = 2;`), the right literal (`5.0f`), or an
explicit conversion when you mean it: `(int)2.5f` is 2, and `Mathf.RoundToInt(2.5f)`
rounds instead.

> **Watch out:** some type mistakes compile, and only show while playing.
> `GetComponent<Rigidbody>()` on an object that only has a **Rigidbody 2D** compiles
> fine, and returns `null`: 3D and 2D components are different types. And `3 / 5` is
> 0, because both are `int`s (C# 8).

### Idea — public and private (U 3.3)

`private` (or no modifier at all) means *only this class can use it*. `public` means any
script can. Getting it wrong gives these:

```csharp
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool IsLocked { get; private set; }

    void Open()             // no modifier: private
    {
        Debug.Log("The door opens");
    }
}
```

```csharp
using UnityEngine;

public class DoorKey : MonoBehaviour
{
    [SerializeField] Door door;

    void Start()
    {
        door.Open();            // error CS0122: 'Door.Open()' is inaccessible due to its protection level
        door.IsLocked = false;  // error CS0272: the set accessor is inaccessible
    }
}
```

| The code | The problem | The fix |
| --- | --- | --- |
| another script calls `door.Open()` | `Open` is private | make it `public void Open()` |
| another script sets `door.IsLocked` | its `set` is private | give `Door` a public method that unlocks it, or make the setter public if any script should change it |
| `float speed = 5f;` doesn't show in the Inspector | it's private, with no `[SerializeField]` | add `[SerializeField]` |
| you changed `public float speed = 5f;` to `8f` in code, and nothing changed | the Inspector's saved value wins over the code's starting value | change it in the Inspector, or **Reset** the component |

`Update`, `Start` and the other event functions are private by habit. Unity calls them
anyway, by name: making them `public` changes nothing for Unity.

### Idea — Animation Event and Animator mistakes (U 3.3)

An Animation Event calls a method **by name**, on the scripts of the GameObject that has
the Animator (C# 5). So:

| Mistake | What you see |
| --- | --- |
| the event says `OnFootStep`, the method is `OnFootstep` | `'Knight' AnimationEvent 'OnFootStep' on animation 'Knight Run' has no receiver!` |
| the method is on a script on a **child** or a **parent** | the same "no receiver" message |
| the method takes a parameter an event can't pass (a `Vector2`, a `bool`, or two values) | `Failed to call AnimationEvent …`, an error, and the method isn't called |
| the method is `private` | nothing: Unity calls private methods too. Other **scripts** can't, though |

And the Animator's parameters are matched by name too (C# 4):

| Mistake | What you see |
| --- | --- |
| `SetFloat("speed", …)` for a parameter called `Speed` | `Parameter 'speed' does not exist.`, and nothing animates |
| `SetBool` on a Float parameter called `Speed` | `Parameter type 'Speed' does not match.`; the value doesn't change |
| a transition with **Has Exit Time** on, where it should be off | no message: the animation changes late |

### Idea — null (U 1.2, from Level 2)

```
NullReferenceException: Object reference not set to an instance of an object
Coin.OnTriggerEnter2D (UnityEngine.Collider2D other) (at Assets/Scripts/Coin.cs:13)
```

Line 13 of `Coin.cs` used something that was `null`. On that line, look at what comes
before each `.`: one of those objects is missing. In Unity it's usually a
`[SerializeField]` field left empty in the Inspector, or a `GetComponent` that found
nothing. Select the object and look for a field that says **None**.

When the missing object is one of Unity's own types, such as a `Transform` or an
`Animator`, the Editor names the problem for you instead. An empty field:

```
UnassignedReferenceException: The variable target of CameraFollow has not been assigned.
You probably need to assign the target variable of the CameraFollow script in the inspector.
```

A `GetComponent` that found nothing:

```
MissingComponentException: There is no 'Animator' attached to the "Knight" game object, but a script is trying to access it.
You probably need to add a Animator to the game object "Knight". Or your script needs to check if the component is attached before using it.
```

A built game, outside the Editor, shows a plain `NullReferenceException` for both.

### Idea — how the exam asks

*Which line causes a compile error?*

```csharp
int score = 10;
float bonus = score * 1.5f;
int total = score + bonus;      // error CS0266: int + float is a float
Debug.Log(total);
```

The third: `score + bonus` is a `float` (an `int` plus a `float` gives a `float`), and
it can't go into an `int` without a conversion. The second line is fine: a `float` can
always hold an `int`'s value.

### Do it

1. Type each of the six wrong declarations into a Practice script, one at a time, and
   read the Console. Then fix each one.
2. Make the `Door` and `DoorKey` scripts, read both errors, and fix them the way the
   table says.
3. On an animated object, give an event the name of a method with a typo in it. Play,
   and read the message. Then move the right method to a child, and read it again.
4. Leave a `[SerializeField]` reference empty, use it, and read the
   `NullReferenceException`. Find the line, and the `None` in the Inspector.

### Challenge

Write a short script with five mistakes in it: two type errors, a `public`/`private`
mix-up, an Animator parameter typo and an empty reference. Swap with a partner. Who
finds all five first, and can say which ones the compiler will find, and which only show
when you press Play?

## C# 11 — Kinds of Classes

**Goal:** you can tell a MonoBehaviour, a plain C# class, a ScriptableObject and an ECS
class apart from their code, and say what each is for. Exam objective U 3.4 asks you to
tell an ECS class from the others.

### Idea — four kinds, at a glance

| Kind | Its first line looks like | Lives | You make one with |
| --- | --- | --- | --- |
| **MonoBehaviour** | `public class Coin : MonoBehaviour` | on a GameObject, as a component | **Add Component**, or `AddComponent<Coin>()` |
| **plain C# class** | `public class Wave` | inside other objects, in memory | `new Wave(…)` |
| **ScriptableObject** | `public class EnemyStats : ScriptableObject` | in the Project, as an asset | **Assets → Create → …**, from `[CreateAssetMenu]` |
| **ECS** (Entities) | `public struct Speed : IComponentData` | in Unity's Entities system, with no GameObject | the Entities package's own tools |

The part after the colon is the giveaway: it says what the class is built on.

### Idea — MonoBehaviour: a component

Every script you've attached to a GameObject is a MonoBehaviour. It gets the event
functions (`Awake`, `Start`, `Update`, `OnTriggerEnter2D`…), a `transform`, a
`gameObject`, and `[SerializeField]` fields in the Inspector.

- Its **file name must match its class name**: `Coin.cs` for `class Coin`.
- You can't make one with `new`. Unity has to make it, on a GameObject:
  `gameObject.AddComponent<Coin>()`.
- It only exists while its GameObject does.

### Idea — plain C# classes: data and logic

A class that isn't built on anything is a plain C# class, like Level 2's `Wave`. You
make as many as you like with `new`, and they're perfect for data and the logic that
goes with it.

Mark one `[System.Serializable]`, and Unity can show it **inside** a MonoBehaviour's
Inspector, and save it in the scene with it. An array of them becomes a list you can
fill in, item by item:

```csharp
using UnityEngine;

[System.Serializable]
public class Level
{
    [SerializeField] string title;
    [SerializeField] int coinsToWin = 10;

    public string Title
    {
        get { return title; }
    }

    public int CoinsToWin
    {
        get { return coinsToWin; }
    }
}
```

```csharp
using UnityEngine;

public class LevelList : MonoBehaviour
{
    [SerializeField] Level[] levels;

    void Start()
    {
        foreach (Level level in levels)
        {
            Debug.Log($"{level.Title}: {level.CoinsToWin} coins");
        }
    }
}
```

In the Inspector, **Levels** shows a size, and each element opens into its own **Title**
and **Coins To Win**. Without `[System.Serializable]`, the field doesn't show at all.

### Idea — ScriptableObject: data as an asset

A ScriptableObject is a class whose objects are **assets**, saved in the Project like a
material or a clip. Many objects can point to the same one: give fifty enemies one
`EnemyStats` asset, change its health once, and all fifty change.

```csharp
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Enemy Stats")]
public class EnemyStats : ScriptableObject
{
    [SerializeField] int maxHealth = 3;
    [SerializeField] float speed = 2f;

    public int MaxHealth
    {
        get { return maxHealth; }
    }

    public float Speed
    {
        get { return speed; }
    }
}
```

`[CreateAssetMenu]` adds **Assets → Create → Game → Enemy Stats** to the menus. A
ScriptableObject has no `transform` and no `Update`: it's data, not a thing in the
scene.

> **Note:** in Level 3 you only need to recognise one. Level 4 is where you make your
> own, and use them to share settings between scenes.

### Idea — ECS: entities, components and systems

Unity also has a second, very different way to build games: **ECS**, the Entity
Component System, from the Entities package (part of DOTS). It's made for huge numbers
of things, such as a hundred thousand fish, and it splits everything that a
MonoBehaviour holds together:

| ECS part | Is | Looks like |
| --- | --- | --- |
| **entity** | an ID, with no code and no GameObject | (you don't write a class for it) |
| **component** | a `struct` of data only, no methods | `public struct Speed : IComponentData` |
| **system** | the code that runs over every entity with certain components | `public partial struct MoveSystem : ISystem` |

```csharp
// … needs the Entities package, which this project doesn't have: for reading only.
using Unity.Entities;

public struct Speed : IComponentData
{
    public float Value;
}

public partial struct MoveSystem : ISystem
{
    public void OnUpdate(ref SystemState state)
    {
        // … moves every entity that has a Speed component …
    }
}
```

What gives ECS code away: `struct` instead of `class`, `IComponentData`, `ISystem` or
`SystemBase`, `partial`, `using Unity.Entities;`, and no `MonoBehaviour` anywhere.

> **Note:** this course doesn't use ECS; recognising it is all the exam asks.

### Idea — two more you already use

| Kind | Example | Means |
| --- | --- | --- |
| **struct** | `Vector2`, `Color`, `RaycastHit2D` | like a class, but copied whenever you pass it or assign it: change the copy, and the original stays the same |
| **static class** | `Mathf`, `Debug`, `Physics2D` | no objects at all: you call its methods through its name, as in `Mathf.Clamp(…)` |

### Idea — how the exam asks

*Which of these is a component in Unity's Entity Component System?*

- A. `public class Health : MonoBehaviour { public int value; }`
- B. `public struct Health : IComponentData { public int Value; }`
- C. `public class Health : ScriptableObject { public int value; }`
- D. `[System.Serializable] public class Health { public int value; }`

**B**: a `struct` built on `IComponentData`. A is a MonoBehaviour component, which is a
different thing with the same word in its name; C is an asset; D is a plain class.

### Do it

1. Make the `Level` and `LevelList` scripts. Fill in three levels in the Inspector and
   play. Then remove `[System.Serializable]`, and watch the list disappear from the
   Inspector.
2. Make the `EnemyStats` ScriptableObject, create two assets from the menu, and give a
   test script a `[SerializeField] EnemyStats stats;` field that logs `stats.MaxHealth`.
3. For each script in your current game, say which kind of class it is.
4. Try `new` on a MonoBehaviour (`Coin coin = new Coin();`) in a Practice script. It
   compiles, and Unity warns while playing. Read what it says.

### Challenge

Explain to a partner, in two sentences each: when would you use a plain C# class instead
of a MonoBehaviour? When a ScriptableObject instead of a plain class? Then find one place
in your game where you'd make the change.

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
instead of an error (C# 10).

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

3. A hash is only a number, so Unity can't say which name is wrong (C# 4).
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
   method by that name any more (C# 5). Rename the method back.

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
   (C# 7). Put `EnterState(State.Chase);` back.

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

## C# 12 — The User Exam

**Goal:** you know what the **Unity Certified User: Programmer** exam covers, where in
this course you learned each part, how its questions are written, and how to work
through them without falling into their traps.

### Idea — the exam

The **Unity Certified User: Programmer** exam is Unity's first certificate for
programmers. You take it on a computer, at a test centre or online, in a set time.
Most questions give you some code, a Unity window or a description, and four answers
to choose from; some ask you to choose more than one, or to put things in order.

Unity's certification pages list the current number of questions, the time and the
pass mark, and they change from time to time: check them with your trainer before you
book. Unity also publishes an official practice test, to take before the real one.

### Idea — what it covers, and where you learned it

The exam's objectives come in four groups. Every one has a place in this course:

| | Objective | Where you learned it |
| --- | --- | --- |
| **1.1** | given a Console message, write the code that printed it | Levels 0 and 1: `Debug.Log`, string interpolation |
| **1.2** | given code and its error, find which object is `null` | Level 2: null and debugging |
| **1.3** | choose the right class member and syntax for a task | Level 2: the Unity docs, `GetComponent` |
| **2.1** | variables, modifiers, arrays, lists and dictionaries | Levels 1 and 2 |
| **2.2** | write a valid method declaration | Level 2: methods in depth |
| **2.3** | choose the call that makes a state play, Animator included | Level 3: C# 4 |
| **2.4** | read the keyboard and touch | Levels 1 and 2: the Input System |
| **2.5** | logic and flow: `if`, `switch`, loops, `&&`, `\|\|`, `!` | Level 1 |
| **2.6** | respond when a UI element reports a change | Level 2: UI events |
| **3.1** | event functions, and when Unity calls each | Level 2: event functions |
| **3.2** | spot a wrongly declared data type | Level 3: C# 10 |
| **3.3** | spot `public`/`private` misuse, Animation Events included | Level 3: C# 10, C# 5 |
| **3.4** | tell an ECS class from the other kinds | Level 3: C# 11 |
| **3.5** | recognise Unity's naming conventions | Level 3: C# 1 |
| **3.6** | choose the comment that describes code accurately | Levels 0 and 3: C# 9 |
| **4.1** | the editor windows: what each is for | Level 0 |
| **4.2** | change the code editor Unity opens scripts in | Level 0 |
| **4.3** | build a state machine from clips and property settings | Level 3: C# 2, C# 3 |
| **4.4** | program a state machine in the Animator Controller | Level 3: C# 3 |

The **Check Yourself** part at the end of this book has exam-style questions on every
one of them, a practice paper, and a cheat sheet.

### Idea — how the questions are written

| Question says… | It wants… |
| --- | --- |
| "What does this code print?" | trace it, on paper, line by line (C# 9) |
| "Which line causes an error?" | the line that doesn't compile, not the one that would be bad style |
| "Which comment best describes…" | the option true word for word; the others are each slightly wrong |
| "Which code should replace `// TODO`…" | the option that compiles **and** does the task: two often compile |
| "Which call makes the X state play?" | follow the arrow into X, read its condition, match the parameter's type |
| "Which name follows the conventions?" | PascalCase or camelCase, by the table in C# 1 |
| a picture of the Animator or the Inspector | read every setting it shows: one of them is usually the point |

Watch for **NOT**, **BEST**, **FIRST** and **MOST** in the question: they turn it round.
"Which is NOT a valid declaration" wants the broken one.

### Idea — the traps, collected

| Trap | Remember |
| --- | --- |
| `3 / 5` | 0: `int` divided by `int` is an `int` |
| `update()`, `start()` | compile, and Unity never calls them |
| `"speed"` for a parameter called `Speed` | names are exact: a warning while playing, and nothing animates |
| **Has Exit Time** on | the transition waits for the clip to finish |
| a trigger set when no transition can use it | it stays set, and fires later |
| `if (x = 5)` | assignment, not comparison: a compile error in C# |
| `Awake` and `Start` | every `Awake` runs before any `Start` |
| `GetComponent<Rigidbody>()` on a 2D object | `null`: the 2D component is `Rigidbody2D` |
| `private` methods called from another script | `CS0122`: inaccessible |
| an Animation Event on a child's script | no receiver: the method must be beside the Animator |
| `float f = 1.5;` | `1.5` is a `double`: write `1.5f` |

### Idea — on the day

- **Read the code before the question's answers.** Work out what it does; then look
  for that answer.
- **Rule out.** Two answers are usually clearly wrong. Of the last two, find the word
  that makes one of them false.
- **Trace when it matters.** A small table on scrap paper beats a guess.
- **Don't get stuck.** Mark a hard question, answer the easy ones, and come back. An
  unanswered question can't score.
- **Check the units.** Seconds or frames? 0 to 1, or 0 to 100?

### Do it

1. For each objective in the table, write one line of code, or one sentence, that
   shows it. Where you can't, go back to the chapter it names.
2. Work through the Check Yourself questions at the end of this book, on paper, before
   reading the answers.
3. Take the practice paper with a timer, as if it were the real exam.

### Challenge

Write an exam question of your own for any objective: a stem, four answers and one
right one, with three wrong answers that are each *nearly* right. Swap with a partner,
answer each other's, and explain why each wrong answer is wrong.

# Part 6 — Check Yourself

## Exam-style questions

These questions are written the way the **Unity Certified User: Programmer** exam
writes its own: two for each of its 19 objectives, whose number is in brackets after
each question (C# 12 lists them all). Answer on paper first, then check the
answers. The practice paper after them is a timed rehearsal.

**Q1.** (1.1) A script has `int coins = 12;` and `int total = 30;`. The Console shows
`Coins: 12 of 30`. Which line printed it?

- A. `Debug.Log("Coins: coins of total");`
- B. `Debug.Log($"Coins: {coins} of {total}");`
- C. `Debug.Log("Coins: " + coins + "of" + total);`
- D. `Debug.Log($"Coins: {coins} of total");`

**Q2.** (1.1) What does this print?

```csharp
float seconds = 125.6f;
int whole = (int)seconds;
Debug.Log($"{whole / 60}:{whole % 60:00}");
```

**Q3.** (1.2) The Console shows this error. Line 13 of `Coin.cs` is
`game.AddCoin();`. Which object is `null`, and what's the most likely reason?

```
NullReferenceException: Object reference not set to an instance of an object
Coin.OnTriggerEnter2D (UnityEngine.Collider2D other) (at Assets/Scripts/Coin.cs:13)
```

**Q4.** (1.2) This line throws an exception when it runs. What's the most likely
reason?

```csharp
GetComponent<Animator>().SetTrigger("Jump");
```

- A. The Animator has no parameter called `Jump`.
- B. The GameObject has no Animator component.
- C. `SetTrigger` needs a hash, not a string.
- D. The Animator component is disabled.

**Q5.** (1.3) Which line makes the Rigidbody 2D `body` move right at 5 units a second,
and keeps its speed of falling?

- A. `body.linearVelocity = 5f;`
- B. `body.linearVelocity = new Vector2(5f, body.linearVelocity.y);`
- C. `body.AddForce(5f);`
- D. `transform.position.x += 5f;`

**Q6.** (1.3) Which line makes the Sprite Renderer `sprite` half see-through?

- A. `sprite.color.a = 0.5f;`
- B. `sprite.color = new Color(1f, 1f, 1f, 0.5f);`
- C. `sprite.alpha = 0.5f;`
- D. `sprite.SetColor(0.5f);`

**Q7.** (2.1) What does this print?

```csharp
List<string> items = new List<string> { "key", "apple" };
items.Add("coin");
items.Remove("key");
items.Insert(0, "map");
Debug.Log(items.Count + " " + items[1]);
```

**Q8.** (2.1) Which field shows in the Inspector, but can't be used by other scripts?

- A. `public int health;`
- B. `[SerializeField] int health;`
- C. `int health;`
- D. `static int health;`

**Q9.** (2.2) Which is a valid declaration of a method that takes an amount of damage
and says whether the target died?

- A. `bool TakeDamage(int amount)`
- B. `TakeDamage(int amount) : bool`
- C. `void bool TakeDamage(amount)`
- D. `int TakeDamage(bool amount)`

**Q10.** (2.2) An Animation Event should pass the method a whole number, set in the
event's Inspector. Which method can it call?

- A. `public void OnStep(int foot)`
- B. `public void OnStep(int foot, int side)`
- C. `public void OnStep(Vector2 where)`
- D. `public void OnStep(bool isLeft)`

**Q11.** (2.3) An Animator is in **Idle**. The transition Idle → Attack has one
condition: `Attack`, a Trigger. Which line makes it play Attack?

- A. `animator.SetBool("Attack", true);`
- B. `animator.SetTrigger("Attack");`
- C. `animator.Play("Idle");`
- D. `animator.SetFloat("Attack", 1f);`

**Q12.** (2.3) An enemy's Animator has an **Any State** transition into Hurt with the
condition `State` Equals `4`. Its script has
`enum State { Patrol, Chase, WindUp, Leap, Hurt, Dead }`. Which line makes it play Hurt?

- A. `animator.SetInteger("State", (int)State.Hurt);`
- B. `animator.SetTrigger("Hurt");`
- C. `animator.SetBool("State", true);`
- D. `animator.SetInteger("State", 5);`

**Q13.** (2.4) With the Input System, which is true on the one frame the player presses
Space down, and on no other?

- A. `Keyboard.current.spaceKey.isPressed`
- B. `Keyboard.current.spaceKey.wasPressedThisFrame`
- C. `Keyboard.current.spaceKey.wasReleasedThisFrame`
- D. `Keyboard.current.anyKey.isPressed`

**Q14.** (2.4) Why does this code check for `null`?

```csharp
Keyboard keyboard = Keyboard.current;
if (keyboard != null && keyboard.jKey.wasPressedThisFrame)
{
    Roll();
}
```

**Q15.** (2.5) What does this print?

```csharp
bool isGrounded = false;
bool isRolling = false;
bool isDead = true;
Debug.Log(isGrounded && !isRolling || isDead);
Debug.Log(isGrounded && (!isRolling || isDead));
```

**Q16.** (2.5) What does this print?

```csharp
int total = 0;
for (int i = 1; i <= 6; i++)
{
    if (i % 2 == 0)
    {
        continue;
    }
    if (i > 4)
    {
        break;
    }
    total += i;
}
Debug.Log(total);
```

**Q17.** (2.6) Which method can be passed to
`volumeSlider.onValueChanged.AddListener(…)`?

- A. `void OnVolumeChanged()`
- B. `void OnVolumeChanged(float value)`
- C. `float OnVolumeChanged(float value)`
- D. `void OnVolumeChanged(int value)`

**Q18.** (2.6) A pause panel connects its **Resume** button with `AddListener` when it
opens, in `OnEnable`. Where should it disconnect it?

- A. `Start`
- B. `OnDisable`
- C. `Update`
- D. `Awake`

**Q19.** (3.1) A GameObject, enabled, is in the scene when the scene loads. In what
order does Unity call these on its script: `Start`, `Update`, `Awake`, `OnEnable`?

**Q20.** (3.1) A camera follows a player who moves in `Update`. In which event function
should the camera move, so that it never shows the player a frame late?

- A. `Awake`
- B. `FixedUpdate`
- C. `LateUpdate`
- D. `OnEnable`

**Q21.** (3.2) Which line doesn't compile?

- A. `float speed = 6;`
- B. `int lives = 3.0f;`
- C. `double distance = 2.5f;`
- D. `string label = "5";`

**Q22.** (3.2) Why doesn't the last line compile, and what's one fix?

```csharp
int score = 10;
float bonus = 2.5f;
int total = score * bonus;
```

**Q23.** (3.3) Another script calls `door.Open();` on this door. What happens?

```csharp
public class Door : MonoBehaviour
{
    void Open()
    {
        Debug.Log("Open");
    }
}
```

- A. It compiles, and the door opens.
- B. A compile error: `Open` is inaccessible due to its protection level.
- C. A `NullReferenceException` when it runs.
- D. A warning, and nothing happens.

**Q24.** (3.3) A knight's **Attack** clip has an Animation Event that calls
`OnAttackHit`. The method is `public void OnAttackHit()`, in a script on the knight's
child object `Sword`. The Animator is on the knight. What happens when the clip reaches
the event, and how do you fix it?

**Q25.** (3.4) Which of these is a component in Unity's Entity Component System?

- A. `public class Speed : MonoBehaviour { public float value; }`
- B. `public struct Speed : IComponentData { public float Value; }`
- C. `public class Speed : ScriptableObject { public float value; }`
- D. `[System.Serializable] public class Speed { public float value; }`

**Q26.** (3.4) What kind of class is each one?

1. `public class Wave`, made with `new Wave(…)`
2. `public class EnemyStats : ScriptableObject`
3. `public partial struct MoveSystem : ISystem`
4. `public class Slime : MonoBehaviour`

**Q27.** (3.5) Which declaration follows the naming conventions for a private field
that's set in the Inspector?

- A. `[SerializeField] float JumpHeight;`
- B. `[SerializeField] float jump_height;`
- C. `[SerializeField] float jumpHeight;`
- D. `[SerializeField] float JUMPHEIGHT;`

**Q28.** (3.5) Which method will Unity call every frame?

- A. `void update()`
- B. `void Update()`
- C. `void OnUpdate()`
- D. `void UPDATE()`

**Q29.** (3.6) Which comment describes this code accurately?

```csharp
// ???
if (health <= 0)
{
    EnterState(State.Dead);
}
```

- A. `// Dies when health goes below zero.`
- B. `// Dies when no health is left.`
- C. `// Loses one health, and dies at zero.`
- D. `// Dies every frame.`

**Q30.** (3.6) Which comment describes the last line inside the `if`?

```csharp
if (isRollPressed && Time.time >= nextRollTime)
{
    StartRoll();
    nextRollTime = Time.time + 0.4f;
}
```

- A. `// Rolls every 0.4 seconds.`
- B. `// The next roll can start 0.4 seconds from now, at the earliest.`
- C. `// The roll lasts 0.4 seconds.`
- D. `// Waits 0.4 seconds, then rolls.`

**Q31.** (4.1) In which window do you add keyframes and Animation Events to the selected
GameObject's clips?

- A. Animator
- B. Animation
- C. Inspector
- D. Timeline

**Q32.** (4.1) Which window lists every GameObject in the open scene, and shows which
ones are children of which?

**Q33.** (4.2) Double-clicking a script opens it in the wrong code editor. Where do you
change that?

**Q34.** (4.2) After you choose a new code editor there, it doesn't understand your
project: no colours, no suggestions. Which button on the same page helps?

**Q35.** (4.3) An **Attack** clip, with Loop Time off, should play once, then go back
to **Idle** by itself. Which settings does the transition Attack → Idle need?

- A. Has Exit Time on, Exit Time 1, no conditions, Transition Duration 0.
- B. Has Exit Time off, no conditions.
- C. Has Exit Time off, and a Trigger condition `Idle`.
- D. Has Exit Time on, Exit Time 0.

**Q36.** (4.3) Run → Idle has the condition `Speed` Less `0.1`, with Has Exit Time on
and an Exit Time of 1. The Run clip lasts one second, and loops. What does the player
see when they let go of the run key, and what's the fix?

**Q37.** (4.4) Which parameter type fits each one best?

1. the character is standing on the ground (true for a while)
2. the character has just been hurt (happens once)
3. how fast the character is running
4. which of six states an enemy's code is in

**Q38.** (4.4) An Any State → Hurt transition has **Can Transition To Self** on. While
the player touches an enemy, code calls `animator.SetTrigger("Hurt")` every frame. What
does the player see, and which setting fixes it?

## Answers

| Q | Answer | Why | Review |
| --- | --- | --- | --- |
| 1 | B | A prints the words; C has no spaces: `Coins: 12of30`; D prints `of total` as text. | Level 1: strings |
| 2 | `2:05` | 125 seconds is 2 whole minutes and 5 seconds; `:00` pads the seconds to two digits. | C# 8 |
| 3 | `game` | The coin's **Game** field was left empty (**None**) in the Inspector. | C# 10 |
| 4 | B | `GetComponent` found nothing, so it returned `null`. In the Editor the exception is a `MissingComponentException` that names the Animator; in a built game, a `NullReferenceException`. A gives a warning, not an exception; both strings and hashes work; a disabled component is still there. | C# 10 |
| 5 | B | A float isn't a `Vector2` (A); `AddForce` wants a `Vector2` (C); D doesn't compile: one part of `transform.position` can't be set alone. | Level 2: Rigidbody 2D |
| 6 | B | A doesn't compile, for the same reason as Q5's D; C and D don't exist. | C# 2 |
| 7 | `3 apple` | `key apple` → `key apple coin` → `apple coin` → `map apple coin`. | Level 2: lists |
| 8 | B | `[SerializeField]` shows a private field. A is public; C doesn't show; `static` fields don't show. | C# 1 |
| 9 | A | The return type comes first, then the name, then each parameter's type and name. | Level 2: methods |
| 10 | A | An event passes at most one value: a float, int, string, enum, Object or AnimationEvent. Not two, not a `Vector2`, not a `bool`. | C# 5 |
| 11 | B | The condition is a Trigger, and the machine is in Idle, where the arrow starts. | C# 4 |
| 12 | A | `(int)State.Hurt` is 4. D is Dead's number; the other calls don't match an Int. | C# 7 |
| 13 | B | `isPressed` is true on every frame it's held; `wasReleasedThisFrame` is the frame it comes up. | Level 2: input |
| 14 | — | On a phone, or anything with no keyboard, `Keyboard.current` is `null`, and using it would throw a `NullReferenceException`. | Level 2: input |
| 15 | `True`, then `False` | `&&` is worked out before `\|\|`: `(false && true) \|\| true` is true. The brackets change it: `false && …` is false. | Level 1: logic |
| 16 | `4` | 1 is added; 2 is skipped; 3 is added; 4 is skipped; at 5, `break`. | C# 9 |
| 17 | B | A slider sends a `float`, and a listener returns nothing. | Level 2: UI events |
| 18 | B | Disconnect in `OnDisable`, the pair of `OnEnable`. | C# 8 |
| 19 | `Awake`, `OnEnable`, `Start`, `Update` | `Start` waits until just before the first `Update`. | Level 2: event functions |
| 20 | C | `LateUpdate` runs after every `Update`, so the player has already moved. | Level 2: event functions |
| 21 | B | A `float` doesn't fit in an `int` without a cast (CS0266). A `float` fits in a `double` (C), and an `int` in a `float` (A). | C# 10 |
| 22 | — | `score * bonus` is a `float`, which doesn't fit in an `int`. Make `total` a `float`, or round it: `Mathf.RoundToInt(score * bonus)`. | C# 10 |
| 23 | B | No modifier means `private`: only `Door` can call `Open` (CS0122). Make it `public void Open()`. | C# 10 |
| 24 | — | The Console says the event has no receiver, and nothing is called. An event only calls scripts on the GameObject with the Animator: move the method there. | C# 5 |
| 25 | B | A `struct` built on `IComponentData`. | C# 11 |
| 26 | — | 1 a plain C# class; 2 a ScriptableObject, an asset; 3 an ECS system; 4 a MonoBehaviour, a component. | C# 11 |
| 27 | C | Fields are camelCase. A looks like a property; B uses snake case; D looks like a constant from another language. | C# 1 |
| 28 | B | Event functions are called by their exact name. The others compile, and are never called. | C# 1 |
| 29 | B | `<= 0` includes 0, which A leaves out; nothing is subtracted (C); and it's only when health is 0 or less (D). | C# 9 |
| 30 | B | It's a cooldown: the earliest time the next roll may start. | C# 9 |
| 31 | B | The Animation window edits clips; the Animator window edits the state machine. | C# 2 |
| 32 | the Hierarchy | | Level 0 |
| 33 | **Edit → Preferences** (on a Mac, **Unity → Settings**) → **External Tools** → **External Script Editor** | | Level 0 |
| 34 | **Regenerate project files** | It rewrites the files the code editor reads to understand the project. | Level 0 |
| 35 | A | B is ignored by Unity: a transition needs a condition or an exit time. C needs code to fire `Idle`. D leaves the moment Attack starts. | C# 3 |
| 36 | — | He keeps running until the Run clip's loop ends, up to a second, then idles. Turn Has Exit Time **off**. | C# 3 |
| 37 | — | 1 Bool; 2 Trigger; 3 Float; 4 Int. | C# 3 |
| 38 | — | Hurt restarts every frame, so it never gets past its first frame. Turn **Can Transition To Self** off (and fire the trigger only when the hurt starts). | C# 3 |

## Practice paper

Twenty questions, in the exam's styles and from all four of its groups. Give yourself
**30 minutes**, with no book and no Unity, then mark it with the answers that follow.
14 or more right is a good sign you're ready; under 14, go back to the chapters the
answers name, and try again a few days later.

**P1.** `int health = 4;` and `const int MaxHealth = 5;`. Which line prints
`Health: 4/5`?

- A. `Debug.Log($"Health: {health}/{MaxHealth}");`
- B. `Debug.Log("Health: " + health / MaxHealth);`
- C. `Debug.Log($"Health: {health / MaxHealth}");`
- D. `Debug.Log("Health: {health}/{MaxHealth}");`

**P2.** What does this print?

```csharp
Dictionary<string, int> keys = new Dictionary<string, int>();
keys["gold"] = 1;
keys["silver"] = 2;
keys["gold"] += 2;
Debug.Log(keys["gold"] + keys.Count);
```

**P3.** A door's Animator has Closed → Opening, with the condition `IsOpen` true. Which
line opens the door?

- A. `animator.SetTrigger("IsOpen");`
- B. `animator.SetBool("IsOpen", true);`
- C. `animator.SetInteger("IsOpen", 1);`
- D. `animator.Play("IsOpen");`

**P4.** Which line doesn't compile?

- A. `Vector2 jump = new Vector2(0f, 12f);`
- B. `bool isLit = "true";`
- C. `float half = 1 / 2f;`
- D. `int count = (int)4.8f;`

**P5.** A class `Wallet` has `public int Coins { get; private set; }`. Another script
writes `wallet.Coins = 10;`. What happens?

- A. `Coins` becomes 10.
- B. A compile error: the set accessor is inaccessible.
- C. A `NullReferenceException`.
- D. Nothing: the line is skipped.

**P6.** Which is the conventional name for a `static readonly` hash of the Animator
parameter `Grounded`?

- A. `groundedHash`
- B. `GroundedHash`
- C. `GROUNDED_HASH`
- D. `_groundedHash`

**P7.** Which comment describes this line accurately?

```csharp
spriteRenderer.flipX = moveInput < 0f;
```

- A. `// Flips the picture every frame.`
- B. `// Faces left while moving left, and right otherwise.`
- C. `// Faces left while moving right.`
- D. `// Turns the character round when it stops.`

**P8.** A door has three clips: **Closed** (one frame), **Opening** (Loop Time off) and
**Open** (one frame). Which transition should have Has Exit Time on?

- A. Closed → Opening
- B. Opening → Open
- C. Open → Closed
- D. All three

**P9.** Which is true of a **Trigger** parameter?

- A. It holds a number between 0 and 1.
- B. It stays true until code sets it to false.
- C. It switches itself off as soon as a transition uses it.
- D. It can only be used by Any State transitions.

**P10.** What does this print?

```csharp
int lives = 2;
switch (lives)
{
    case 0:
        Debug.Log("Game over");
        break;
    case 1:
        Debug.Log("Last life");
        break;
    default:
        Debug.Log("Lives: " + lives);
        break;
}
```

**P11.** `KnightHealth.Start` throws a `NullReferenceException` on the line
`healthBar.SetHealth(Health, MaxHealth);`. What's `null`?

- A. `Health`
- B. `MaxHealth`
- C. `healthBar`
- D. `SetHealth`

**P12.** Two colliders bump into each other. Neither has **Is Trigger** ticked, and one
has a Rigidbody 2D. Which event function runs?

- A. `OnTriggerEnter2D(Collider2D other)`
- B. `OnCollisionEnter2D(Collision2D collision)`
- C. `OnCollisionEnter(Collision collision)`
- D. `OnBump2D()`

**P13.** With the Input System, which reads where the mouse or a finger is, in screen
pixels?

- A. `Pointer.current.position.ReadValue()`
- B. `Mouse.position`
- C. `Touchscreen.current.press.isPressed`
- D. `Pointer.current.press.wasPressedThisFrame`

**P14.** Which method can listen to a Toggle's `onValueChanged`?

- A. `void OnToggled(float value)`
- B. `void OnToggled(bool isOn)`
- C. `bool OnToggled()`
- D. `void OnToggled(string text)`

**P15.** Which line plays a sound once, without stopping a sound that's already playing
on the same Audio Source?

- A. `audioSource.Play();`
- B. `audioSource.PlayOneShot(clip);`
- C. `audioSource.clip = clip;`
- D. `audioSource.Stop();`

**P16.** Which of these can't be added to a GameObject with **Add Component**?

- A. Rigidbody 2D
- B. a MonoBehaviour script
- C. a ScriptableObject
- D. Animator

**P17.** Which pair of methods can both be in one class?

- A. `void Heal()` and `int Heal()`
- B. `void Heal(int amount)` and `void Heal(int points)`
- C. `void Heal()` and `void Heal(int amount)`
- D. `void Heal(int amount)` and `int Heal(int amount)`

**P18.** While the game plays, where can you watch which state an Animator is in?

- A. the Animator window, with the GameObject selected
- B. the Console
- C. the Project window
- D. the Animation window's Curves view

**P19.** Code calls `animator.SetFloat("Speed", 5f)` every frame, but the knight never
runs. The controller's parameter is called `speed`. What does the Console show?

**P20.** A slime's **Dead** clip has an Animation Event that calls `OnDeathFinished`.
Its script declares `public void OnDeathFinished(Vector2 where)`. What happens, and
what's the fix?

## Practice paper answers

| P | Answer | Why | Objective |
| --- | --- | --- | --- |
| 1 | A | B and C divide two `int`s first: `4 / 5` is 0. D has no `$`, so it prints the braces. | 1.1 |
| 2 | `5` | `keys["gold"]` is 3, and there are 2 keys: 3 + 2 is 5, a number, not text. | 2.1 |
| 3 | B | The condition reads a Bool. | 2.3 |
| 4 | B | Text isn't a `bool`. C is 0.5, a `float` division; D is 4. | 3.2 |
| 5 | B | Only `Wallet` can set `Coins` (CS0272). | 3.3 |
| 6 | B | `static readonly` values are PascalCase. | 3.5 |
| 7 | B | `moveInput < 0f` is true while moving left. | 3.6 |
| 8 | B | Opening must finish first; the others wait for a parameter. | 4.3 |
| 9 | C | A is a Float; B is a Bool; any transition can use a trigger. | 4.4 |
| 10 | `Lives: 2` | No case is 2, so `default` runs. | 2.5 |
| 11 | C | Only an object can be `null`. The **Health Bar** field is empty. | 1.2 |
| 12 | B | A collision, not a trigger, and the 2D version. | 3.1 |
| 13 | A | The pointer is the mouse or a finger, whichever is in use. | 2.4 |
| 14 | B | A toggle sends a `bool`. | 2.6 |
| 15 | B | `PlayOneShot` mixes a sound over whatever is playing. | 1.3 |
| 16 | C | A ScriptableObject is an asset, not a component. | 3.4 |
| 17 | C | An overload needs different parameter types or numbers: not other names (B), not another return type (A, D). | 2.2 |
| 18 | A | The current state has a moving blue bar. | 4.1 |
| 19 | `Parameter 'Speed' does not exist.` | Parameter names are exact, capitals included. | 2.3 |
| 20 | — | An event can't pass a `Vector2`: the Console shows `Failed to call AnimationEvent OnDeathFinished…`, and the method isn't called. Give it no parameter. | 3.3 |

## Level 3 cheat sheet

**A state machine in code**

```csharp
enum State { Idle, Walk, Hurt }        // the states

State state;                           // the current one
float stateStartTime;

void Update()
{
    switch (state)                     // each state's work, every frame
    {
        case State.Idle:
            break;
        case State.Walk:
            break;
        case State.Hurt:
            break;
    }
}

void EnterState(State next)            // the only place the state changes
{
    state = next;
    stateStartTime = Time.time;
    animator.SetInteger(StateHash, (int)state);
}
```

**Animator parameters**

| Type | Code | A condition asks | For |
| --- | --- | --- | --- |
| Float | `SetFloat(SpeedHash, 4f)` | Greater, Less | speeds |
| Int | `SetInteger(StateHash, 2)` | Greater, Less, Equals, NotEqual | the code's state |
| Bool | `SetBool(GroundedHash, true)` | true, false | things that stay true |
| Trigger | `SetTrigger(HurtHash)` | fired | things that happen once |

`static readonly int SpeedHash = Animator.StringToHash("Speed");` Names are exact.

**Transitions for sprite animation**

| Setting | Value |
| --- | --- |
| Has Exit Time | off, except out of one-shot clips (attack, hurt, roll) |
| Transition Duration | 0 |
| Can Transition To Self (Any State) | off |

**Animation Events:** a method on a script **on the same GameObject as the Animator**,
the exact name, `void`, with no parameter or one `float`, `int`, `string`, `enum` or
`Object`.
An event on a clip that's cut short never fires.

**Naming**

| PascalCase | camelCase |
| --- | --- |
| classes, methods, properties, enums and their values, `const`, `static readonly` | fields, local variables, parameters |

Booleans read as questions: `isGrounded`, `hasKey`, `IsDead`.

**Kinds of classes**

| `: MonoBehaviour` | `[System.Serializable]` class | `: ScriptableObject` | `struct … : IComponentData` |
| --- | --- | --- | --- |
| a component | data inside a component | an asset | ECS |

**UI and pausing:** a health bar is a **Filled** Image, `fillAmount = (float)health / max`.
`Time.timeScale = 0` stops physics, Animators and `WaitForSeconds`; `Update` and the UI
keep running. Set it back to 1 on Restart.

## Before Level 4: can you…

- Write a state machine with an `enum`, a `switch` and an enter step, without looking?
- Make sprite-frame clips and property clips in the Animation window, at the right
  sample rate?
- Build an Animator Controller from a set of clips: a default state, transitions with
  conditions, and the right **Has Exit Time** on each?
- Set Float, Int, Bool and Trigger parameters from code, with hashes, and say which
  call makes a given state play?
- Add Animation Events, and fix one that has no receiver?
- Make an enemy whose Animator follows its code through an Int, and give a second
  enemy the same machine with other clips through an Override Controller?
- Make a health bar that slides, a panel for each part of the game, and a pause that
  stops everything but the menu?
- Name everything by the conventions, pick the comment that matches the code, and spot
  a wrong type or a private member used from outside?
- Tell an ECS class from a MonoBehaviour, a plain class and a ScriptableObject?
- Score 14 or more on the practice paper in 30 minutes?

If yes, you're ready for the **Unity Certified User: Programmer** exam, and for
Level 4, where your games grow up: several scenes, saved progress, interfaces,
ScriptableObjects of your own, the Input Actions asset, and code you didn't write.
