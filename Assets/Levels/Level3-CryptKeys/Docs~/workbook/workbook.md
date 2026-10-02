---
title: "Crypt Keys"
subtitle: "Level 3: Junior-ready"
author: "Unity Programmer Curriculum  ·  Level 3"
coverEyebrow: "Level 3 · Junior-ready · Learn to Code · Make Games"
coverTop: "Crypt"
coverRed: "Keys"
coverSub: "A top-down dungeon: a warrior who faces four ways, skeletons and archers that think in states, keys, doors and chests, a boss in two phases, and torchlight in the dark."
coverPill: "Level 3 Workbook · Crypt Keys"
coverCaption: "18 scripts · 92 animation clips · 1 Skeleton King"
coverArt: image
coverImage: cover.png
footer: "Crypt Keys  ·  Level 3 Workbook"
---

# Part 0 — Before You Start

## What you're going to build

A **top-down dungeon**. A warrior goes down into a crypt of six rooms, stacked one above
the other: each room's only way on is the door in the middle of its top wall. Keys open
the doors, chests hold the keys, and skeletons and skeleton archers guard the way to the
tomb of the Skeleton King.

| Room | Name | What's in it |
| --- | --- | --- |
| 1 | **The Crypt Gate** | torches and banners, a chest with the first key, gold |
| 2 | **The Hall of Bones** | two skeletons among stone statues, a chest, gold |
| 3 | **The Ossuary** | two skeletons, an archer, pillars to hide behind, a chest with a potion and a key |
| 4 | **The Archers' Gallery** | two archers behind shield statues, a skeleton, a chest, a potion |
| 5 | **The Chapel** | a red carpet up to the last door, a chest with the **boss key**, gold, a potion |
| 6 | **The King's Tomb** | the Skeleton King, two stone knights, torches |

**How to play:** walk with **W A S D** or the arrow keys, or hold the mouse button (or a
finger) down and the hero walks towards it. **Space** or **J**, or a quick tap, swings
the sword. **E** opens the chest in front of him, **Q** drinks a potion (or tap a potion
slot), and **Esc** or **P** pauses.

The hero has **3 hearts**, counted in half hearts. A skeleton's sword or an arrow costs
half a heart; a hit knocks him back and makes him blink, and while he blinks nothing can
hurt him. A skeleton takes three hits of the sword, an archer two. A potion gives back a
whole heart, and he can carry three. A locked door opens by itself when he walks into it
with a key, and the fifth door wants the boss key. The **Skeleton King** sleeps until the
hero comes into his tomb. He walks at the hero and swings; at half health he summons two
skeletons and starts to spin in a whirlwind that turns the sword aside, then stops to
rest, open to the sword. Beating him wins. A start screen waits for **Play**, the win
screen shows the gold and the time, and **Restart** puts the whole crypt back as it began.

## Level 3 has three books

Level 3 has three games, each with its own book: **Knight Run** (a 2D platformer),
**Crypt Keys** (this one, a 2D dungeon) and **Gate Guard** (a 3D tower defence). Every
book teaches **every** Level 3 topic, and they share the same C# Concept chapters, so
your trainer can run one book, or give different groups different books. If you've done
one book already, the C# Concept chapters in the next are a revision round.

The C# Concept chapters are written once for all three books, so some of their examples
come from Knight Run: a knight who runs and rolls, and slimes that hop. The ideas are
exactly the same in the crypt, and every build chapter of this book shows them on your
own hero, skeletons and king.

Level 3 ends at an exam: the **Unity Certified User: Programmer**. Parts 6 and 7 of this
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
> UI events, `GetComponent` and `TryGetComponent`, the Input System and the Rigidbody 2D.
> Keep the Level 2 cheat sheet next to you.

## The route through this book

| Step | Chapter | You learn | You build |
| --- | --- | --- | --- |
| 1 | C# 1 | Naming conventions | — |
| 2 | Chapter 1 | Pixel art at 32 pixels a unit, the Tile Palette, a Random Rule Tile, a Tilemap's colliders | The Crypt Gate |
| 3 | Chapter 2 | Top-down walking, the pointer, four ways to face, colliders at the feet, sorting by height, the Pixel Perfect Camera | The hero walks |
| 4 | C# 2 | Clips, keyframes, sprite frames | — |
| 5 | Chapter 3 | Twenty clips from twenty sheets | The hero's clips |
| 6 | C# 3, C# 4 | States, transitions, parameters, hashes | — |
| 7 | Chapter 4 | Sub-state machines, Exit and Entry, copying a machine | The Humanoid Animator |
| 8 | C# 5 | Animation Events | — |
| 9 | Chapter 5 | A hit frame, `OverlapCircleAll`, layer masks | The sword |
| 10 | C# 6, C# 7 | State machines in code and in the Animator | — |
| 11 | Chapter 6 | An enemy as a state machine, line of sight, an Override Controller | The skeleton, the Hall of Bones |
| 12 | Chapter 7 | Half hearts, knockback, blinking, falling | Hearts and hurt |
| 13 | Chapter 8 | Keeping a distance, a release frame, cover | The archer, the Ossuary |
| 14 | Chapter 9 | A Bool parameter, a property clip, a Sorting Group | Keys and doors, the Archers' Gallery |
| 15 | Chapter 10 | A loot frame, an inventory, a carpet of nine tiles | Chests and potions, the Chapel |
| 16 | C# 8 | Health bars, panels, pausing | — |
| 17 | Chapter 11 | Hearts with `/` and `%`, a font asset, 9-slicing, buttons | The screen |
| 18 | Chapter 12 | A room camera, the game as a state machine, Restart in code | Rooms, pause and restart |
| 19 | Chapter 13 | A copied, extended controller, a boss in two phases | The Skeleton King, his tomb |
| 20 | Chapter 14 | 2D lights, a flicker clip, sounds, music | Torchlight and sound |
| 21 | C# 9, C# 10, C# 11 | Reading code, finding errors, kinds of classes | — |
| 22 | Chapter 15 | The Animator's mistakes, and how to find them | Break it, then fix it |
| 23 | Chapter 16 | A Web build, and testing it | A game you can share |
| 24 | Part 6 | The exam, and how to take it | — |
| 25 | Part 7 | Exam-style practice | — |

## For trainers: running a session

Sessions follow the route above, with the same rhythm as Levels 0 to 2:

| Share | Activity | From |
| --- | --- | --- |
| About 20% | **Concept:** teach the idea. Students predict each example's Console output before you run it. | C# Concept chapters |
| About 60% | **Build:** students follow the chapter in Unity and press Play at every checkpoint. | Build chapters |
| About 20% | **Practice:** the **Do it** exercises, in class or as homework. | C# Concept chapters |

Students join Level 3 by passing the **Level 3 entry test** (the entry test papers in
the course project; the answer key is a separate trainer-only file). Chapters 4, 6 and
13 are the heart of this book: the hero's Animator with its four sub-state machines, the
enemies sharing it, and the boss's extended copy. Give them the most time. Each room is
painted in the chapter that first needs it (Chapters 1, 6, 8, 9, 10 and 13): slow mouse
users can finish painting at home, from the maps in the book. Chapter 12 changes nine
scripts at once to give every piece of the crypt a reset: let students type it over two
sessions if they need to.

Your trainer project has the finished game, and a menu item that builds its scene from
scratch (**Tools → Crypt Keys (Level 3) → Build Scene**): use it to show the goal on the
first day, or to rescue a scene that's beyond repair.

## The pieces we'll build

Eighteen scripts:

```
Facing ─────────── four ways to face (an enum), and two helpers (a static class)
Hero ───────────── walks with the keys or the pointer; tells the Animator his Direction and Speed
HeroCombat ─────── the sword: the attack, and the hit on the clip's hit frame
HeroHealth ─────── 3 hearts in half hearts, knockback, blinking, falling
Inventory ──────── keys, the boss key, potions and gold, and the screen's counts
Pickup ─────────── a key, the boss key, a potion or gold: one script, an enum and a switch
Chest ──────────── opens, and shows its loot on the lid's frame
Door ───────────── a lock, a key, and the door's leaves folding back
Skeleton ───────── an enemy as a state machine: idle, patrol, chase, attack, hurt, dead
Archer ─────────── keeps its distance, shoots, steps aside
Arrow ──────────── flies, hurts, breaks
SkeletonKing ───── the boss: two phases, a summon and a whirlwind
HeartsBar ──────── three hearts, full, half or empty
BossBar ────────── the king's bar, sliding down
RoomCamera ─────── shows one room at a time, and slides to the next
PauseMenu ──────── Resume, Restart and the volume
CryptGame ──────── the game's own state machine: start, playing, paused, won, lost

Room ───────────── one room's name, centre and boss flag (a plain C# class)
```

## New words for Level 3

| Word | What it means |
| --- | --- |
| **Sprite sheet** | one picture holding many frames or tiles, cut into separate sprites |
| **Pivot** | the point of a sprite that sits on its GameObject's position: for a character, the feet |
| **Tilemap** | a grid of tiles painted like a picture: the floor, the walls, the carpet |
| **Tile Palette** | the window you pick tiles from to paint them |
| **Rule Tile** | a tile that chooses its own sprite, by rules: here, at random |
| **Animation clip** | how some properties change over time: an `.anim` asset |
| **Keyframe** | a value set at one moment of a clip; Unity fills in the moments between |
| **Animator Controller** | the state machine that chooses which clip plays |
| **State, transition** | a box in the Animator, and an arrow from one box to another |
| **Sub-state machine** | a box in the Animator that holds a whole state machine of its own |
| **Parameter** | a value that code sets, and transitions read: Float, Int, Bool or Trigger |
| **Animation Event** | a marker on a clip that calls one of your methods |
| **State machine** | code, or an Animator, that's in one state at a time and follows rules to change |
| **Override Controller** | a copy of an Animator Controller's state machine with other clips |
| **Sorting Group** | makes several sprites sort as one picture |
| **Layer mask** | a set of layers, so a physics query only sees what it should |
| **Light 2D** | a light for 2D sprites: one that lights everything, or a circle of light |

## One-time project setup

- **Unity 6**, with a new project created from the **Universal 2D** template. It comes
  with the **Input System** and **2D Tilemap Extras** packages: nothing to install.
- **Art and sound:** your trainer shares two folders, `Art` and `Audio`, with every file
  this book uses, already renamed to one pattern (`HeroDownIdle.png`,
  `SkeletonLeftWalk.png`) and each pack's licence beside them. Every pack is free to use
  for anything (CC0); `CREDITS.md` names them all. They are, on itch.io:
  - **Lucifer** by Foozle: *Warrior*, *Skeleton Grunt*, *Skeleton Hunter*, *Skeleton
    King Boss*, *Dungeon Tileset*, *Pickups* and *RPG UI*;
  - **Legend – UI Icons** by Foozle (the keys);
  - **16x16 DungeonTileset II** by 0x72 (the chests, the hearts, the arrow);
  - **Ninja Adventure** by Pixel-Boy and AAA (every sound, and the music).
- `Art` holds `Characters/` (`Hero`, `Skeleton`, `Archer`, `King`: 20 sheets each, 22
  for the king), `Tiles/DungeonTileset.png`, `Props/` (the chest, keys, potion, gold,
  arrow), `UI/` (the panel, slot, buttons, hearts, boss bar), `Fonts/PixelRpgFont.ttf`
  and `Licences/`. `Audio` holds 16 sounds and two pieces of music.
- Copy both folders into `Assets`. Scripts live in `Assets/Scripts`, clips and
  controllers in `Assets/Animation`, tiles and the palette in `Assets/Tiles`, and prefabs
  in `Assets/Prefabs`.

# Part 1 — The Hero

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

## Chapter 1 — The Crypt Gate

**Goal:** a new project with the crypt's art imported as pixel art, a Tile Palette, a
stone floor that never repeats, and the first room, the Crypt Gate, painted on its
Tilemaps: the floor, the wall and the dark around it.

### Idea — pixel art, at 32 pixels a unit

The art is **pixel art**: small pictures meant to be shown big, every pixel a sharp
square. Unity's usual import settings are made for smooth art, so they blur pixel art and
change its colours. Four settings fix that:

| Setting | Value | Why |
| --- | --- | --- |
| **Pixels Per Unit** | `32` | the tiles are 32 pixels across, so one tile is one unit in the world |
| **Filter Mode** | **Point (no filter)** | the other modes blend each pixel with its neighbours: blur |
| **Compression** | **None** | compression changes colours a little, and in pixel art every colour shows |
| **Sprite Mode** | **Multiple** | a sheet holds many sprites, cut out with the Sprite Editor |

| Sheets | Pixels | Cut into |
| --- | --- | --- |
| `Tiles/DungeonTileset.png` | 672 × 256 | 32 × 32 tiles: floors, walls, the carpet, torches, banners, statues, doors |
| `Characters/Hero/…`, `Skeleton/…`, `Archer/…` | 48 tall | 48 × 48 frames: one sheet for each animation and direction |
| `Characters/King/…` | 48, 64 or 128 tall | 48 × 48 frames; 64 × 64 for his attack and summon; 128 × 128 for his whirlwind |
| `Props/…` | 16 tall | 16 × 16 frames: the chest, keys, potion and gold |

### Idea — a room of tiles

Unity's tools for a level made of tiles:

| Thing | What it is |
| --- | --- |
| **Grid** | a GameObject that lays out cells, 1 unit each, like squared paper |
| **Tilemap** | a child of the Grid that holds a tile in some of its cells, like one layer of paint |
| **Tile** | an asset that says which sprite a cell shows, and whether it's solid |
| **Tile Palette** | a window full of tiles, to pick from while you paint |

Every room of the crypt is the same size, 19 tiles across and 11 tall, and the camera
shows one room at a time:

```
   row 10   ▓ ▒▒▒▒▒▒▒▒ D ▒▒▒▒▒▒▒▒ ▓     the wall's face, two tiles tall, with the
   row  9   ▓ ▒▒▒▒▒▒▒▒ D ▒▒▒▒▒▒▒▒ ▓     doorway (D) in the middle column, x = 9
   row  8   ▓ · · · · · · · · · · ▓
     …      ▓        floor        ▓     the floor: 17 tiles by 8
   row  1   ▓ · · · · · · · · · · ▓
   row  0   ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓     the dark, round the edge
            x = 0       9        18
```

In a top-down crypt, a wall facing the camera shows its **face**: two rows of bricks along
the top of the room. The walls at the sides and the bottom face away from the camera, so
you see only the dark beyond them. The six rooms are **stacked**: the Crypt Gate fills rows
0 to 10, the next room rows 11 to 21, and so on up, so the door in the middle of each
room's top wall leads into the next room. Room 1's centre is (9.5, 5.5); room 2's is
(9.5, 16.5).

The room is painted on three Tilemaps, one for each job:

| Tilemap | Order in Layer | Holds | Collider |
| --- | --- | --- | --- |
| `Floor` | `-30` | the floor | none: you walk on it |
| `Decoration` | `-25` | the Chapel's carpet, in Chapter 10 | none |
| `Walls` | `-20` | the wall's face, and the dark | solid |

### Do it — the project and the art

1. In **Unity Hub**, create a new project from the **Universal 2D** template.
2. **File → Save As** `Assets/Scenes/CryptKeys.unity`.
3. In the **Project** window, create the folders `Scripts`, `Animation`, `Tiles` and
   `Prefabs` inside `Assets`.
4. Copy your trainer's `Art` and `Audio` folders into `Assets`.

### Do it — the tileset, as pixel art

1. Select `DungeonTileset` in `Assets/Art/Tiles`. In the Inspector, set:
   - **Texture Type** to **Sprite (2D and UI)**, and **Sprite Mode** to **Multiple**;
   - **Pixels Per Unit** to `32`;
   - **Filter Mode** to **Point (no filter)**;
   - **Compression** to **None**.

   Click **Apply**.
2. Click **Open Sprite Editor**. Open the **Slice** menu at its top-left, and set
   **Type** to **Grid By Cell Size**, **Pixel Size** to `32` × `32` and **Pivot** to
   **Center**. Click **Slice**, then **Apply** at the top-right, and close the window.
3. Open the arrow on `DungeonTileset` in the Project window: it holds 112 sprites now,
   `DungeonTileset_0` to `DungeonTileset_111`, numbered left to right, top row first.
   Unity left out the cells that are empty.

### Do it — the Tile Palette

1. **Window → 2D → Tile Palette**, and dock it beside the Inspector.
2. In its drop-down of palettes, choose **Create New Palette**. Name it `Crypt Palette`,
   leave **Grid** as **Rectangle** and **Cell Size** as **Automatic**, click **Create**,
   and choose the `Assets/Tiles` folder.
3. Drag `DungeonTileset` (the sheet itself, not one of its sprites) from the Project
   window into the palette. When Unity asks where to save the tiles, choose
   `Assets/Tiles` again. It makes 112 Tile assets, and lays them out in the palette just
   as they are in the sheet.

In this book, a tile is found by its **column** and **row** in the sheet, counted from 0
at the top-left, and by its name. These are the ones this chapter paints with:

| Tile | Column, row | Name |
| --- | --- | --- |
| the dark: plain black | 3, 0 | `DungeonTileset_0` |
| the wall's top row: left end, middle, right end | 4, 5 and 6, row 0 | `DungeonTileset_1`, `_2`, `_3` |
| the wall's bottom row: left end, middle, right end | 4, 5 and 6, row 1 | `DungeonTileset_14`, `_15`, `_16` |
| the floor: plain, a little cracked, cracked | 0, 1 and 2, row 5 | `DungeonTileset_71`, `_72`, `_73` |

The wall's top row has a dark edge along its top; its bottom row, the shadow where the
wall meets the floor. Each **end** tile has a dark edge down one side: a wall's end goes
next to the dark, or next to a doorway.

### Do it — which tiles are solid

A Tile asset's **Collider Type** says what shape its collider is, if it has one.

1. In `Assets/Tiles`, click the first tile, Shift-click the last, and in the Inspector
   set **Collider Type** to **None**.
2. Select the seven tiles the walls are painted with, `DungeonTileset_0`, `_1`, `_2`,
   `_3`, `_14`, `_15` and `_16` (Ctrl-click, or Cmd-click on a Mac, to pick several),
   and set their **Collider Type** to **Grid**: a whole square each.

### Idea — a floor that never repeats

Paint a floor with one tile and the eye sees the pattern at once: a grid of the same
stone. The tileset has three versions of the floor's square stones, plain, a little
cracked and cracked. Choosing among them by hand, cell after cell, would take an age. A
**Rule Tile** chooses for you.

A Rule Tile holds a list of **rules**. Each rule can look at the cell's eight neighbours
(is there a tile of this kind above? to the left?) and says which sprite to show when they
match. Ours has one rule, with no neighbours to check, so it matches every cell, and its
**Output** is **Random**: each cell shows one of a list of sprites, picked by **Perlin
noise** from the cell's position. Perlin noise is a smooth kind of randomness: the same
cell always gets the same pick, so the floor doesn't change each time you open the scene.

Perlin noise gathers round the middle of its range, so the sprites in the middle of the
list come up most, and those at its ends least. To make plain stones common and cracked
ones rare, the list goes cracked, a little cracked, plain, plain, a little cracked, cracked.

### Do it — the Floor Rule Tile

1. In `Assets/Tiles`, right-click → **Create → 2D → Tiles → Rule Tile**, and name it
   `Floor`.
2. In its Inspector, set **Default Sprite** to `DungeonTileset_71` and **Default
   Collider** to **None**.
3. Under **Tiling Rules**, click **+**. The new rule has a 3 × 3 grid of empty squares:
   the neighbours it checks. Leave them all empty. Set:
   - **Collider** to **None**;
   - **Output** to **Random**, **Noise** to `0.5`, and **Shuffle** to **Fixed**;
   - **Size** to `6`, and fill the six sprite slots, in this order: `DungeonTileset_73`,
     `_72`, `_71`, `_71`, `_72`, `_73`.
4. Drag `Floor` from the Project window into the Tile Palette, onto an empty cell below
   the sheet's tiles.

### Do it — the Grid and its three Tilemaps

1. In the Hierarchy, right-click → **2D Object → Tilemap → Rectangular**. Unity makes a
   `Grid` with a child, `Tilemap`. Rename the child `Floor`.
2. Right-click `Grid` → **2D Object → Tilemap → Rectangular** twice more, and name the
   new Tilemaps `Decoration` and `Walls`.
3. Each Tilemap has a **Tilemap Renderer**. Set its **Order in Layer**: `Floor` `-30`,
   `Decoration` `-25`, `Walls` `-20`. Everything you add later, the hero, the enemies,
   the chests, draws at `0`, in front of all three.

### Do it — the camera

Select **Main Camera**. Check that **Projection** is **Orthographic**, and set **Size**
to `5.5`: the camera sees 11 tiles from top to bottom, one room. Under **Environment**,
set **Background Type** to **Solid Color** and the colour to black, `#000000`. Set its
**Position** to `(9.5, 5.5, -10)`: room 1's centre.

### Idea — the Crypt Gate's map

This is the whole room, one character per cell. Each line is a row; the numbers on the
left are rows, and the ruler on top counts columns:

```
        0         10
        |         |
  10    #WWWWWWWWDWWWWWWWW#
   9    #WWtWWBWWDWWBWWtWW#
   8    #.................#
   7    #..T...........T..#
   6    #.................#
   5    #...k.............#
   4    #.............g...#
   3    #.................#
   2    #........H........#
   1    #.................#
   0    ###################
```

| Mark | Is | Painted or placed in |
| --- | --- | --- |
| `#` | the dark | this chapter |
| `W` | the wall's face | this chapter |
| `.` | floor | this chapter |
| `D` | the doorway: left empty | its door hangs there in Chapter 9 |
| `t` `B` | a torch, a banner, on the wall (wall tiles behind them) | Chapter 14; paint them as `W` now |
| `T` | a standing torch | Chapter 2 |
| `H` | where the hero starts | Chapter 2 |
| `k` `g` | a chest with a key, gold | Chapter 10 |

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
column and row) and **Size**. Drag again until Position says, for example, `X 9`, `Y 9`,
and you know where the doorway is. The grid lines in the Scene view mark every cell, so
from there you can count.

### Do it — the dark and the floor

At the top of the Tile Palette, the drop-down beside the tools names the Tilemap you're
painting on.

1. Set it to **Walls**, and pick the dark, `DungeonTileset_0`. With **Box Fill**, fill:
   - column 0, rows 0 to 10;
   - column 18, rows 0 to 10;
   - row 0, columns 1 to 17.
2. Set it to **Floor**, pick the `Floor` Rule Tile, and Box Fill columns 1 to 17, rows 1
   to 8. Each cell picks its own stone.

### Do it — the wall's face

Set the drop-down to **Walls** again. The two rows go the same way, with a gap in the
middle: the doorway, column 9, stays empty in both.

| Row | Column 1 | Columns 2 to 7 | Column 8 | Column 9 | Column 10 | Columns 11 to 16 | Column 17 |
| --- | --- | --- | --- | --- | --- | --- | --- |
| 10 | `_1` | `_2` | `_3` | empty | `_1` | `_2` | `_3` |
| 9 | `_14` | `_15` | `_16` | empty | `_14` | `_15` | `_16` |

Paint the middles with Box Fill, and the four ends of each row with Paint. The ends beside
the doorway are a left end and a right end too: the doorway is the dark between them.

### Do it — make the walls solid

1. Select `Walls`. At the top of the Inspector, open **Layer** → **Add Layer…**, and type
   `Walls`, `Hero` and `Enemy` into three empty **User Layers**: you'll need the other two
   soon. Select `Walls` again, and set its **Layer** to **Walls**.
2. **Add Component → Tilemap Collider 2D**, and set its **Composite Operation** to
   **Merge**.
3. **Add Component → Composite Collider 2D**. Unity adds a **Rigidbody 2D** with it: set
   its **Body Type** to **Static**, so the walls never move. On the **Composite Collider
   2D**, set **Geometry Type** to **Polygons**.

### Idea — why merge the colliders?

On its own, a Tilemap Collider 2D gives every tile its own square: dozens of them, side by
side. A body sliding along them can catch on the seams. The **Composite Collider 2D**
merges them into one shape for each piece of wall, with no seams. **Polygons** makes the
shape solid inside, not only its outline: an arrow that starts inside a wall still hits it.

### Test it

Select `Walls` and look at the Scene view: a green outline runs round the dark and along
the bottom of the wall's face, with a gap at column 9, the doorway. Select `Floor`: no
outline, it isn't solid. Press **Play**: nothing moves yet, but the Game view shows the
Crypt Gate, its stones all different.

### Challenge

Select the `Floor` Rule Tile and change its rule's **Noise**: `0.1` makes big patches of
one stone, `0.9` scatters them. Put it back to `0.5`. Then make a second Rule Tile,
`Brick Floor`, from the small bricks (columns 0 to 2, row 4), and paint a corner of the
room with it. Which floor reads better as a crypt? Paint the corner back with `Floor`.

## Chapter 2 — Four Ways to Walk

**Goal:** the hero walks round the Crypt Gate with the keyboard, or towards the pointer
while it's held down, facing one of four ways. The walls stop his feet, he walks behind
the standing torches and in front of them, and the Pixel Perfect Camera keeps every
pixel square.

### Idea — top-down, the feet are what matter

A top-down game looks down at the floor at a slant, so **lower on the screen is
nearer**. Three things follow, and every character and prop in the crypt is built
around them:

| Rule | Why |
| --- | --- |
| A sprite's **pivot** is at its **feet** | its position is where it stands |
| Its **collider** is at its feet too | the walls stop the feet; the head can pass in front of a wall's face |
| Lower on the screen **draws in front** | a hero standing below a torch is in front of it; above it, behind it |

The last rule is a setting of the **2D Renderer**: **Transparency Sort Mode**. Set to
**Custom Axis** with an axis of `(0, 1, 0)`, it draws sprites in order of their height
on the screen, the highest first, so lower ones cover them. Each Sprite Renderer's
**Sprite Sort Point** says which point is measured: the sprite's middle, or its
**Pivot**. At the feet, the pivot is the right one.

### Do it — the hero's first sheet

1. In `Assets/Art/Characters/Hero`, click the first sheet, Shift-click the last: all 20
   are selected. In the Inspector, set **Sprite Mode** to **Multiple**, **Pixels Per
   Unit** to `32`, **Filter Mode** to **Point (no filter)** and **Compression** to
   **None**, and click **Apply**: one change for all 20.
2. Select `HeroUpIdle` alone, and click **Open Sprite Editor**. In the **Slice** menu,
   set **Type** to **Grid By Cell Size**, **Pixel Size** to `48` × `48`, **Pivot** to
   **Custom**, **Pivot Unit Mode** to **Pixels**, and **Custom Pivot** to `X 24`, `Y 8`.
   Click **Slice**, then **Apply**.

Each frame is 48 pixels square, and the hero stands in its middle with his feet 8 pixels
above its bottom: (24, 8) is the point between his feet. The other 19 sheets get the same
slicing in Chapter 3.

### Do it — the hero

1. Drag `HeroUpIdle_0` from the Project window into the Hierarchy, and rename the new
   GameObject `Hero`. Set its **Position** to `(9.5, 2.15, 0)`, and its **Layer** to
   **Hero**.
2. On its **Sprite Renderer**, set **Sprite Sort Point** to **Pivot**.
3. **Add Component → Rigidbody 2D**: **Body Type** **Dynamic**, **Gravity Scale** `0`
   (nothing falls in a top-down game), **Constraints → Freeze Rotation Z** ticked, and
   **Interpolate** set to **Interpolate**.
4. **Add Component → Capsule Collider 2D**: **Direction** **Horizontal**, **Size**
   `(0.55, 0.3)`, **Offset** `(0, 0.15)`. A flat capsule round his feet, a little
   narrower than his shoulders.

### Idea — four ways to face

The hero walks in any direction, but he's drawn in only four: down, left, up and right.
An `enum` names them, and its numbers are the ones the Animator will use in Chapter 4:
`Down` is 0, `Left` 1, `Up` 2, `Right` 3.

Two helpers turn a direction into a facing and back. Every character in the crypt needs
them, so they're written once, as `static` methods of a `static class`, `Facings`: a class
that only holds helpers, and is never put on a GameObject. You call them through the
class's name: `Facings.FromVector(move, facing)`.

`FromVector` picks the way the movement points most: more across than up and down is left
or right, otherwise down or up. Exactly between two ways, up and to the right, say, it
keeps the facing the character already has if it's one of the two. Without that rule, a
hero walking diagonally would flick between two facings every frame.

### Do it — Facing

Create `Assets/Scripts/Facing.cs`:

```csharp:Facing.cs
using UnityEngine;

// The four ways a character can face. Their numbers are the Animator's
// Direction parameter: 0 down, 1 left, 2 up and 3 right.
public enum Facing { Down, Left, Up, Right }

// Turns a movement into a facing, and a facing into a direction. Every
// character needs them, so they're written once, as static methods.
public static class Facings
{
    // The facing nearest to a movement. A movement exactly between two
    // facings, such as up and to the right, keeps the facing the character
    // already has if it's one of the two, so walking diagonally doesn't flicker.
    public static Facing FromVector(Vector2 move, Facing current)
    {
        if (move.sqrMagnitude < 0.0001f)
        {
            return current;
        }

        float across = Mathf.Abs(move.x);
        float upDown = Mathf.Abs(move.y);
        Facing horizontal = move.x < 0f ? Facing.Left : Facing.Right;
        Facing vertical = move.y < 0f ? Facing.Down : Facing.Up;

        if (Mathf.Abs(across - upDown) < 0.01f && (current == horizontal || current == vertical))
        {
            return current;
        }
        return across > upDown ? horizontal : vertical;
    }

    public static Vector2 ToVector(Facing facing)
    {
        switch (facing)
        {
            case Facing.Left:
                return Vector2.left;
            case Facing.Up:
                return Vector2.up;
            case Facing.Right:
                return Vector2.right;
            default:
                return Vector2.down;
        }
    }
}
```

One file can hold more than one type. `Facing.cs` holds the `enum Facing` and the `static
class Facings`, and neither is a MonoBehaviour, so neither needs its file to have its name
to work. Naming the file after the main one keeps it easy to find.

### Do it — the Hero script

Create `Assets/Scripts/Hero.cs`, and add it to the `Hero` GameObject:

```csharp
using UnityEngine;
using UnityEngine.InputSystem;

// The hero: walks with the keyboard, or towards a pointer that's held down,
// and faces one of four ways.
[RequireComponent(typeof(Rigidbody2D))]
public class Hero : MonoBehaviour
{
    [SerializeField] float walkSpeed = 4f;
    [SerializeField] float holdSeconds = 0.25f;     // a press longer than this walks

    Rigidbody2D body;
    Camera mainCamera;
    Facing facing = Facing.Up;
    float pressStart = -1f;     // when the pointer went down, or -1 when it isn't down

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        mainCamera = Camera.main;
    }

    void Update()
    {
        Vector2 move = ReadKeyboard() + ReadPointer();

        if (move.sqrMagnitude > 0.01f)
        {
            facing = Facings.FromVector(move, facing);
        }

        // A velocity is safe to set in Update: the Rigidbody keeps it until
        // the next physics step uses it.
        body.linearVelocity = Vector2.ClampMagnitude(move, 1f) * walkSpeed;
    }

    // W A S D or the arrows walk.
    // A phone may have no keyboard, and then Keyboard.current is null.
    Vector2 ReadKeyboard()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard == null)
        {
            return Vector2.zero;
        }

        Vector2 move = Vector2.zero;
        if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed)
        {
            move.x -= 1f;
        }
        if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed)
        {
            move.x += 1f;
        }
        if (keyboard.sKey.isPressed || keyboard.downArrowKey.isPressed)
        {
            move.y -= 1f;
        }
        if (keyboard.wKey.isPressed || keyboard.upArrowKey.isPressed)
        {
            move.y += 1f;
        }
        return move.normalized;
    }

    // The mouse, or a finger: held down longer than holdSeconds, he walks
    // towards it.
    Vector2 ReadPointer()
    {
        Pointer pointer = Pointer.current;
        if (pointer == null)
        {
            return Vector2.zero;
        }

        if (pointer.press.wasPressedThisFrame)
        {
            pressStart = Time.time;
        }
        if (pressStart < 0f)
        {
            return Vector2.zero;
        }

        if (pointer.press.wasReleasedThisFrame || !pointer.press.isPressed)
        {
            pressStart = -1f;
            return Vector2.zero;
        }

        Vector2 target = mainCamera.ScreenToWorldPoint(pointer.position.ReadValue());
        Vector2 toTarget = target - body.position;
        if (Time.time - pressStart <= holdSeconds || toTarget.magnitude < 0.2f)
        {
            return Vector2.zero;
        }
        return toTarget.normalized;
    }
}
```

Read it before you move on:

- `ReadKeyboard` adds up the keys: right is `+1` across, left `-1`, both at once `0`.
  `move.normalized` makes the length 1, so a diagonal is as fast as a straight line: (1, 1)
  becomes about (0.71, 0.71).
- `Pointer.current` is the mouse on a computer and the finger on a phone. `pressStart`
  remembers when the press began; once it has lasted longer than `holdSeconds`, he walks
  towards the pointer. A shorter press is a **tap**: Chapter 5 makes it swing the sword.
- `ScreenToWorldPoint` turns the pointer's place on the screen, in pixels, into a place in
  the world, in units.
- `Vector2.ClampMagnitude(move, 1f)` is new. It keeps a vector's length at 1 or less,
  without changing its direction: the keyboard and the pointer together can't make him
  walk faster.

### Do it — sorting by height

1. Select `Assets/Settings/Renderer2D`, the project's 2D Renderer. In the Inspector, set
   **Transparency Sort Mode** to **Custom Axis**, and **Transparency Sort Axis** to
   `(0, 1, 0)`.
2. Now something to walk round. Select `DungeonTileset` and click **Open Sprite Editor**.
   Drag a small rectangle in an empty part of the sheet, such as its blank top-left
   corner: a new sprite. In the **Sprite** panel at the bottom-right, set:
   - **Name** to `Standing Torch`;
   - **Position** to `X 512`, `Y 192`, `W 32`, `H 48`;
   - **Pivot** to **Custom**, **Pivot Unit Mode** to **Pixels**, and **Custom Pivot** to
     `(16, 2)`: the torch's feet.

   Click **Apply**. The torch on its tripod was two tiles of the sheet; now it's also one
   sprite, with its pivot where it stands.
3. Drag `Standing Torch` (inside `DungeonTileset` in the Project window) into the
   Hierarchy. On its **Sprite Renderer**, set **Sprite Sort Point** to **Pivot**. Set its
   **Layer** to **Walls**, and **Add Component → Box Collider 2D**: **Size**
   `(0.5, 0.25)`, **Offset** `(0, 0.12)`, round its tripod's feet.
4. Drag it from the Hierarchy into `Assets/Prefabs`: a prefab. Make an empty GameObject,
   `Torches`, at `(0, 0, 0)`, and make the torch its child. Set its **Position** to
   `(3.5, 7.15, 0)`; drag a second `Standing Torch` prefab in, under `Torches`, at
   `(15.5, 7.15, 0)`.

The torch is on the **Walls** layer, so it's in the way like a wall: later, it will block
arrows and an enemy's sight too.

### Do it — the Pixel Perfect Camera

Pixel art looks right only when every art pixel is the same number of screen pixels: 2 by
2, or 3 by 3, never 2 by 3. The **Pixel Perfect Camera** makes sure of it.

1. Select **Main Camera**, and **Add Component → Pixel Perfect Camera**.
2. Set **Assets Pixels Per Unit** to `32`, and **Reference Resolution** to `640` × `352`.
3. Set **Crop Frame** to **Letterbox**, and **Grid Snapping** to **Upscale Render
   Texture**.
4. In the **Game** view, open the resolution drop-down at its top, click **+**, and add a
   **Fixed Resolution** of `1280` × `720`. Choose it.

| Setting | Why |
| --- | --- |
| **Reference Resolution** 640 × 352 | 20 tiles across and 11 down at 32 pixels a tile: one room, with half a tile of the dark at each side |
| **Crop Frame** **Letterbox** | on a screen taller than that, black bars, not a sliver of the next room |
| **Grid Snapping** **Upscale Render Texture** | draws the crypt at 640 × 352, then scales it up by a whole number: at 1280 × 720, exactly 2 |

### Test it

Press **Play**.

- **W A S D** or the arrows walk him round, at the same speed on a diagonal. The wall
  stops his feet, not his head: walk up to the wall's face, and his head passes in front
  of it. The dark stops him at the sides and the bottom.
- Hold the mouse button down: after a quarter of a second he walks towards the pointer. A
  quick click does nothing yet.
- Walk up behind a torch: it covers him. Walk down past it: he covers it. The torch's feet
  stop his.
- In the Inspector's **⋮** menu, choose **Debug**: the Inspector shows private fields too.
  Watch **Facing** change as he walks, and walk diagonally: it doesn't flicker. Choose
  **Normal** again when you're done.

He never turns round on the screen yet: his sprite is a single frame, facing up. Chapters
3 and 4 give him his animations.

### Challenge

Take `Vector2.ClampMagnitude` out of `Update`, hold **D** and hold the mouse to his right
at the same time, and watch his speed. Put it back. Then try **Grid Snapping** set to
**Pixel Snapping**, and walk slowly past a torch: what do you see? Which setting would you
ship?

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

## Chapter 3 — Twenty Clips

**Goal:** twenty animation clips for the hero: Idle, Walk, Attack, Hurt and Dead, each in
four directions, made in the Animation window from his twenty sprite sheets.

### Idea — five clips, four times

The warrior was drawn the way the Animator will think about him: every animation in all
four directions, one sheet each. Five animations, four directions, twenty clips:

| Clip | Sheet | Frames | Samples | Loop Time | Lasts |
| --- | --- | --- | --- | --- | --- |
| `Hero Down Idle` | `HeroDownIdle` | 5 | 8 | on | 0.63 s |
| `Hero Down Walk` | `HeroDownWalk` | 8 | 12 | on | 0.67 s |
| `Hero Down Attack` | `HeroDownAttack` | 6 | 12 | **off** | 0.5 s |
| `Hero Down Hurt` | `HeroDownHurt` | 4 | 10 | **off** | 0.4 s |
| `Hero Down Dead` | `HeroDownDeath` | 5, then a fade | 8 | **off** | 1.63 s |

Then the same five for `Left`, `Up` and `Right`: `Hero Left Idle` from `HeroLeftIdle`, and
so on. Every sheet's frames are numbered from 0, and a clip uses them all, in order:
`HeroDownIdle_0` to `HeroDownIdle_4`. One sheet is different: `HeroUpDeath` has 6 frames,
not 5.

The attack lasts exactly half a second. Chapter 5's code will count on that: while he
swings, he can't walk, for `0.5` seconds.

### Do it — slice the other nineteen sheets

You set the import settings of all twenty in Chapter 2, and sliced `HeroUpIdle`. Slice
the other nineteen the same way: select a sheet, **Open Sprite Editor**, **Slice** with
**Grid By Cell Size** `48` × `48`, **Custom** pivot, **Pixels**, `(24, 8)`, then **Slice**
and **Apply**. The Slice menu keeps its settings from one sheet to the next, so after the
first it's quick: open, **Slice**, **Slice**, **Apply**, close.

### Do it — the first clip

1. Open **Window → Animation → Animation**, and select `Hero` in the Hierarchy.
2. Click **Create**, and save the clip as `Assets/Animation/Hero Down Idle.anim`. Unity
   adds an **Animator** to the hero, and makes an Animator Controller for it,
   `Hero.controller`, beside the clip.
3. In the Animation window's **⋮** menu, tick **Show Sample Rate**, and set **Samples** to
   `8`.
4. In the Project window, open the arrow on `HeroDownIdle`, click `HeroDownIdle_0`,
   Shift-click `HeroDownIdle_4`, and drag the five sprites into the Animation window's
   timeline.
5. Press the Animation window's **Play** button: in the Scene view, the hero breathes,
   facing you. Press it again to stop.

### Do it — the other nineteen

For each clip in the table, and each direction: open the clip menu at the top-left of the
Animation window, choose **Create New Clip…**, save it in `Assets/Animation` with its
name, set **Samples**, and drag its frames in. Work one direction at a time: the five
`Down` clips, then the five `Left`, and so on.

Then select the twelve Attack, Hurt and Dead clips in `Assets/Animation` (Ctrl-click, or
Cmd-click on a Mac) and untick **Loop Time** in the Inspector, once for all twelve: a
swing, a hurt and a fall each happen once.

### Do it — the fade at the end of Dead

The death frames show the hero sinking to the floor. Then he should lie still for half a
second, and fade away over another half: a **property** curve on the Sprite Renderer's
colour, added to the sprite frames.

1. Pick `Hero Down Dead` in the clip menu. Click **Add Property**, open **Sprite
   Renderer**, and click the **+** beside **Color**. A Color curve appears, with keyframes
   at the start and the end of the frames.
2. The frames end at `0:5`: five frames at 8 samples. Move the playhead to `1:1`, half a
   second later (4 frames at 8 samples), and click **Add Keyframe**: its **A** (alpha, how
   solid it is) is `1`.
3. Move the playhead to `1:5`, another half a second. Turn on **Record**, and in the
   Sprite Renderer set the colour's **A** to `0`. A keyframe appears. Turn **Record** off.
4. Play the clip: five frames of falling, a moment still, then a fade to nothing.

Do the same for `Hero Left Dead` and `Hero Right Dead`, at the same times. `Hero Up Dead`
has six frames, so its frames end at `0:6`: put its keyframes at `1:2` and `1:6`.

### Idea — what Unity made for you

Select `Hero`: its **Animator** has **Controller** set to `Hero.controller`. Open
**Window → Animation → Animator**: the controller has a state for each of the twenty
clips, named after it, and `Hero Down Idle`, the first you made, is orange: the default
state, the one that plays when the game starts. There are no arrows between the states
yet, and twenty boxes in one window is already a crowd. Chapter 4 sorts them into four
groups, after the next two C# Concepts.

### Test it

Press **Play**. The hero breathes, facing down, whichever way he walks: the Animator plays
only its default state until transitions say otherwise, and nothing tells it his
direction yet. Stop, and preview a few clips in the Animation window: a walk, an attack,
a hurt, and a fall with its fade.

### Challenge

Play `Hero Down Walk` at 8 samples, then at 16, and watch his feet while he walks at 4
units a second. Which looks as if his feet grip the floor? Put it back to 12. Then preview
`Hero Down Attack` frame by frame (the **,** and **.** keys step backwards and forwards):
on which frame does the sword cut through the air? Remember it for Chapter 5.

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

## Chapter 4 — One Machine per Direction

**Goal:** one Animator Controller, `Humanoid`, that picks the hero's clip by itself: the
right animation, in the right direction, every frame. Twenty states, kept tidy in four
**sub-state machines**, one per direction. The script tells it two things: which way he
faces, and how fast he's moving.

### Idea — twenty states, four machines

Five parameters describe a character, any character in the crypt:

| Parameter | Type | Set by the script to |
| --- | --- | --- |
| `Direction` | Int | which way he faces: 0 down, 1 left, 2 up, 3 right, the `Facing` numbers |
| `Speed` | Float | how fast he's moving |
| `Attack` | Trigger | an attack starts (Chapter 5) |
| `Hurt` | Trigger | he's hit (Chapter 7) |
| `Dead` | Trigger | he falls (Chapter 7) |

Twenty states in one window, every one with arrows to the others, would be a tangle no
one could read. So the states are grouped: a **sub-state machine** is a box in the
Animator that holds a whole state machine of its own. There's one for each direction, and
each holds the same five states:

```
 Base Layer
 ┌─────────┐   ┌─────────┐   ┌─────────┐   ┌─────────┐
 │  Down   │◄─►│  Left   │◄─►│   Up    │◄─►│  Right  │   each machine joined to the
 └─────────┘   └─────────┘   └─────────┘   └─────────┘   other three, on Direction Equals n

 Inside Down:

   Entry ──► Idle (its default), or ──► Walk if Speed > 0.1
   Idle  ── Speed > 0.1 ──► Walk          Walk ── Speed < 0.1 ──► Idle
   Idle, Walk ── Attack ──► Attack        Attack ── at its end ──► Idle
   Idle, Walk ──► Exit   when Direction ≠ 0
   Any State ──► Hurt  on Hurt, if Direction = 0      Hurt ── at its end ──► Idle
   Any State ──► Dead  on Dead, if Direction = 0
```

### Idea — Exit, Entry and the arrows between machines

Three new nodes appear inside a sub-state machine:

| Node | What it does |
| --- | --- |
| **Exit** | an arrow to it means "this machine is done". Unity follows the Base Layer's arrows **out of** the machine's box, and takes the first whose conditions are true |
| **Entry** | where a machine starts when an arrow goes **into** its box: an arrow out of Entry whose conditions are true, or else the machine's default state |
| **Any State** | the same Any State as the Base Layer's: an arrow from it can start from any state, in any machine |

So when the hero turns from down to left, the Down machine's Idle sees `Direction ≠ 0`
and goes to Exit; the Base Layer's arrow from Down to Left, `Direction Equals 1`, takes
him into Left; and Left's Entry starts him in Walk if he's walking, or in Idle.

Only Idle and Walk lead to Exit, so **an attack or a hurt always finishes first**, in the
direction it started: the hero never turns round in the middle of a swing.

The Any State arrows carry a `Direction` condition too, so a hit sends him to the Hurt
state of the way he faces.

### Do it — one controller, Humanoid

1. In `Assets/Animation`, rename `Hero.controller` to `Humanoid`. The skeleton, the
   archer and the king will share it, so it's named for what they have in common. The
   hero's Animator still points to it: a rename doesn't break a reference.
2. Open **Window → Animation → Animator**, with `Hero` selected. On the **Parameters**
   tab, click **+** and add an **Int**, `Direction`; a **Float**, `Speed`; and three
   **Triggers**, `Attack`, `Hurt` and `Dead`.

### Do it — the Down machine

1. Right-click an empty spot in the Animator → **Create Sub-State Machine**. In the
   Inspector, name it `Down`.
2. Drag each of the five `Hero Down` states onto the `Down` box: each one disappears into
   it.
3. Select the other fifteen states (drag a box round them) and press **Delete**. Their
   clips stay in `Assets/Animation`: you'll use them in a minute.
4. Double-click `Down`. You're inside it: the bar at the top says **Base Layer › Down**.
   Inside are the five states, **Entry**, **Exit**, **Any State**, and **(Up) Base
   Layer**, the way back out.
5. Rename the states `Idle`, `Walk`, `Attack`, `Hurt` and `Dead`. `Idle` is orange: it's
   still the layer's default state. If the arrow from **Entry** doesn't go to `Idle`,
   right-click `Idle` → **Set StateMachine Default State**.

### Do it — the arrows inside Down

For each row below: right-click the first state → **Make Transition**, and click the
second (or the **Exit** node). Select the new arrow, and in the Inspector set **Has Exit
Time** as the table says, open **Settings** and set **Transition Duration** to `0`, and
under **Conditions** click **+** for each condition.

| From | To | Has Exit Time | Conditions |
| --- | --- | --- | --- |
| Idle | Walk | off | `Speed` Greater `0.1` |
| Walk | Idle | off | `Speed` Less `0.1` |
| Idle | Attack | off | `Attack` |
| Walk | Attack | off | `Attack` |
| Attack | Idle | **on**, **Exit Time** `1` | none |
| Hurt | Idle | **on**, **Exit Time** `1` | none |
| Idle | Exit | off | `Direction` NotEqual `0` |
| Walk | Exit | off | `Direction` NotEqual `0` |

Then one more: right-click **Entry** → **Make Transition**, click `Walk`, and give the
arrow the condition `Speed` Greater `0.1`. An arrow out of Entry has no settings, only
conditions: when he comes into this machine already walking, he starts in Walk, not in a
frame of Idle.

### Do it — Any State, for the whole layer

Any State belongs to the whole layer, not to one machine, so make its arrows from the Base
Layer: click **Base Layer** in the bar at the top.

1. Right-click **Any State** → **Make Transition**, and click the `Down` box. A menu opens
   with the states inside Down: choose `Hurt`.
2. On the new arrow: **Transition Duration** `0`, untick **Can Transition To Self** (in
   **Settings**), and two conditions: `Hurt`, and `Direction` Equals `0`.
3. The same again to Down's `Dead`: **Transition Duration** `0`, **Can Transition To
   Self** off, conditions `Dead`, and `Direction` Equals `0`.

**Can Transition To Self** off matters for Dead: without it, the Dead trigger could start
the fall again while he's already lying there.

### Do it — copy the machine three times

1. In the Base Layer, click the `Down` box, and press **Ctrl+C**, then **Ctrl+V** (**Cmd**
   on a Mac). A copy appears, `Down 0`, with all five states inside and every arrow among
   them, conditions and all. Rename it `Left`. Paste twice more, and rename the copies
   `Up` and `Right`. Arrange the four boxes in a row.
2. Go into `Left`. Select each state, and drag its clip from `Assets/Animation` into the
   **Motion** field: `Hero Left Idle` into Idle, `Hero Left Walk` into Walk, and so on.
   Select the two arrows to **Exit**, and change their condition to `Direction` NotEqual
   `1`.
3. The same for `Up` (its clips, and NotEqual `2`) and `Right` (NotEqual `3`).
4. The copies have no Any State arrows: those belong to the layer, and only Down's were
   made. From the Base Layer, make the six that are missing, as before: to `Left`'s Hurt
   and Dead with `Direction` Equals `1`, to `Up`'s with `2`, and to `Right`'s with `3`.

Building one machine with care, then copying it, is how a repeated structure is made: the
copies can't have a typo the first one didn't have.

### Do it — the arrows between machines

In the Base Layer, each machine needs an arrow to each of the other three: twelve.

1. Right-click the `Down` box → **Make Transition**, and click the `Left` box. In the menu
   that opens, choose the machine itself, at the top, not one of its states.
2. Select the arrow, and add the condition `Direction` Equals `1`.
3. Down to Up, `Direction` Equals `2`; Down to Right, Equals `3`.
4. Then from Left to Down (Equals `0`), Up (`2`) and Right (`3`); from Up to Down, Left
   and Right; and from Right to Down, Left and Up. The condition is always the number of
   the machine the arrow goes **to**.

An arrow out of a machine's box has no Has Exit Time and no duration: it's only followed
when that machine's Exit is reached, and then at once.

### Do it — the script

Replace `Hero` with this version:

```csharp
using UnityEngine;
using UnityEngine.InputSystem;

// The hero: walks with the keyboard, or towards a pointer that's held down,
// and faces one of four ways. Every frame he tells the Animator his Direction
// and his Speed.
[RequireComponent(typeof(Rigidbody2D))]
public class Hero : MonoBehaviour
{
    static readonly int DirectionHash = Animator.StringToHash("Direction");
    static readonly int SpeedHash = Animator.StringToHash("Speed");

    [SerializeField] float walkSpeed = 4f;
    [SerializeField] float holdSeconds = 0.25f;     // a press longer than this walks

    Rigidbody2D body;
    Animator animator;
    Camera mainCamera;
    Facing facing = Facing.Up;
    float pressStart = -1f;     // when the pointer went down, or -1 when it isn't down

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        mainCamera = Camera.main;
    }

    void Update()
    {
        Vector2 move = ReadKeyboard() + ReadPointer();

        if (move.sqrMagnitude > 0.01f)
        {
            facing = Facings.FromVector(move, facing);
        }

        // A velocity is safe to set in Update: the Rigidbody keeps it until
        // the next physics step uses it.
        body.linearVelocity = Vector2.ClampMagnitude(move, 1f) * walkSpeed;

        animator.SetInteger(DirectionHash, (int)facing);
        animator.SetFloat(SpeedHash, body.linearVelocity.magnitude);
    }

    // W A S D or the arrows walk.
    // A phone may have no keyboard, and then Keyboard.current is null.
    Vector2 ReadKeyboard()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard == null)
        {
            return Vector2.zero;
        }

        Vector2 move = Vector2.zero;
        if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed)
        {
            move.x -= 1f;
        }
        if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed)
        {
            move.x += 1f;
        }
        if (keyboard.sKey.isPressed || keyboard.downArrowKey.isPressed)
        {
            move.y -= 1f;
        }
        if (keyboard.wKey.isPressed || keyboard.upArrowKey.isPressed)
        {
            move.y += 1f;
        }
        return move.normalized;
    }

    // The mouse, or a finger: held down longer than holdSeconds, he walks
    // towards it.
    Vector2 ReadPointer()
    {
        Pointer pointer = Pointer.current;
        if (pointer == null)
        {
            return Vector2.zero;
        }

        if (pointer.press.wasPressedThisFrame)
        {
            pressStart = Time.time;
        }
        if (pressStart < 0f)
        {
            return Vector2.zero;
        }

        if (pointer.press.wasReleasedThisFrame || !pointer.press.isPressed)
        {
            pressStart = -1f;
            return Vector2.zero;
        }

        Vector2 target = mainCamera.ScreenToWorldPoint(pointer.position.ReadValue());
        Vector2 toTarget = target - body.position;
        if (Time.time - pressStart <= holdSeconds || toTarget.magnitude < 0.2f)
        {
            return Vector2.zero;
        }
        return toTarget.normalized;
    }
}
```

Read it before you move on:

- The two `static readonly int` fields turn each parameter's name into a number once
  (C# 4). The names must match the Animator's exactly: `Direction`, not
  `direction`.
- `(int)facing` turns the `Facing` into its number: `Facing.Left` is `1`. That's why the
  enum lists the four ways in the Animator's order.
- The last two lines of `Update` tell the Animator what the hero is doing, every frame.
  The script never picks a clip; the transitions do.

### Test it

Press **Play** with the Animator window open and `Hero` selected in the Hierarchy. In the
Base Layer, the box of the machine he's in is highlighted; double-click it to watch the
blue bar under its current state.

- He starts facing up: Down's Idle leaves through Exit at once, and the arrow to Up takes
  him into Up's Idle.
- Walk right: into Right, straight into Walk. Stop: Right's Idle.
- Walk down, left, up: every turn goes Exit → the Base Layer → Entry, in one frame.
- Watch the **Parameters** tab: `Direction` jumps between 0 and 3, and `Speed` is `4`
  while he walks.

If he gets stuck in a machine, look at its Exit arrows' conditions: each machine's own
number. If he goes into the wrong machine, look at the Base Layer arrow's number. If a
state plays the wrong clip, look at its **Motion**.

### Idea — why four machines, and not one big one?

Four machines of five states are easy to read, easy to check (they're copies), and easy to
extend: Chapter 13 adds two states to the king's copy of this controller without touching
the four machines. In Level 5 you'll meet the **blend tree**, which can pick among the
four directions from the Direction itself, in one state; it's the tool for walking in
eight directions, or sixteen. For four, sub-state machines are just right.

### Challenge

Delete Right's arrow from **Entry** to `Walk`, then walk in a square, and watch the first
frame after each turn into Right in the Animator: a frame of Idle. Undo the delete. Then
think it through: if `Hurt` fires while `Direction` is 3 and he's in the Down machine,
which state does he go to? Why does the script set `Direction` every frame, before
anything can set a trigger?

# Part 2 — Sword and Bones

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

## Chapter 5 — The Sword

**Goal:** **Space**, **J** or a quick tap swings the hero's sword the way he faces. The
swing hurts nothing when the key goes down: it hits on the **hit frame**, the moment the
blade cuts through the air, through an Animation Event. A circle in front of him finds
what's there.

### Idea — the hit frame

The attack clip is six frames at 12 samples, half a second. Step through `Hero Down
Attack` in the Animation window: the blade sweeps past on **frame 2**, `0:2`, a sixth of a
second in. That's when the sword should hit: not when the key is pressed (too soon, before
the arm has moved), and not at the end of the clip (too late, the blade is back by his
side). An **Animation Event** on frame 2 calls a method, `OnAttackHit`, on the hero's
scripts, at exactly that moment, in all four directions.

### Idea — a circle in front of him

`Physics2D.OverlapCircleAll(point, radius, layerMask)` is new. It returns every collider
that overlaps a circle, as an array. The **layer mask** says which layers to look on: only
**Enemy**, so the sword never hits a wall, a torch or the hero himself.

```
                ·   ·            the circle: radius 0.6, its centre 0.7 in front
             ·         ·         of his middle, the way he swings
            ·     ✕     ·
             ·    │    ·
                ·   ·
                  │ 0.7
               ( hero )   ← his middle, 0.4 above his feet
                 feet
```

The circle is measured from his **middle**, 0.4 above his feet, because that's where the
sword swings. At a radius of 0.6, it still reaches the floor in front of him, where an
enemy's feet, and its collider, are.

A `LayerMask` field shows in the Inspector as a drop-down of layers, with a tick for each.

### Do it — HeroCombat

Create `Assets/Scripts/HeroCombat.cs`:

```csharp
using UnityEngine;

// The hero's sword. An attack starts the Attack clip, and the clip's hit
// frame calls OnAttackHit: only then does the sword hurt what's in front.
public class HeroCombat : MonoBehaviour
{
    static readonly int AttackHash = Animator.StringToHash("Attack");

    [SerializeField] LayerMask enemyMask;
    [SerializeField] float attackSeconds = 0.5f;    // as long as the Attack clip
    [SerializeField] float hitDistance = 0.7f;      // how far in front of his middle the sword's circle is
    [SerializeField] float hitRadius = 0.6f;

    // His body's middle, above his feet: the sword's circle is measured from here.
    readonly Vector2 middle = new Vector2(0f, 0.4f);

    Animator animator;
    Vector2 attackDirection;
    float attackEndTime;

    public bool IsAttacking
    {
        get { return Time.time < attackEndTime; }
    }

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // An attack the way he faces: direction is Facings.ToVector of his facing.
    public void Attack(Vector2 direction)
    {
        if (IsAttacking)
        {
            return;
        }
        attackDirection = direction;
        attackEndTime = Time.time + attackSeconds;
        animator.SetTrigger(AttackHash);
    }

    // Animation Event: the sword's hit frame, on all four Attack clips.
    // Everything on the Enemy layer inside the circle is hit.
    public void OnAttackHit()
    {
        Vector2 front = (Vector2)transform.position + middle + attackDirection * hitDistance;
        Collider2D[] hits = Physics2D.OverlapCircleAll(front, hitRadius, enemyMask);
        foreach (Collider2D hit in hits)
        {
            Debug.Log("The sword hits " + hit.name);
        }
    }
}
```

Read it before you move on:

- `IsAttacking` is true for `attackSeconds` after an attack starts: as long as the clip.
  `Attack` does nothing while it's true, so a second press in the middle of a swing
  doesn't start another.
- `Attack` takes the direction to swing in, and keeps it in `attackDirection` until the
  hit frame. HeroCombat doesn't ask which way the hero faces: `Hero` knows, and tells it.
- `OnAttackHit` is `public`: Animation Events call public methods. For now, the Console
  names what the sword hits; the skeletons in Chapter 6 will take the hit.
- `(Vector2)transform.position` turns the position, a `Vector3`, into a `Vector2`, so it
  can be added to the other `Vector2`s.

### Idea — why Hero tells HeroCombat the direction

Hero calls `combat.Attack(…)`, so Hero needs HeroCombat. If HeroCombat also asked Hero
which way he faces, each would need the other, and neither could be written first: Unity
compiles each time you save, and the first of the two to be saved wouldn't compile.
Passing the direction in keeps the need going one way only, and makes HeroCombat simpler
to read: everything it uses arrives through its own fields and parameters.

### Do it — the Hero, with a sword

Replace `Hero` with this version, then add `HeroCombat` to the `Hero` GameObject and set
its **Enemy Mask** to **Enemy**:

```csharp
using UnityEngine;
using UnityEngine.InputSystem;

// The hero: walks with the keyboard, or towards a pointer that's held down,
// and faces one of four ways. Every frame he tells the Animator his Direction
// and his Speed. A quick tap swings the sword.
[RequireComponent(typeof(Rigidbody2D))]
public class Hero : MonoBehaviour
{
    static readonly int DirectionHash = Animator.StringToHash("Direction");
    static readonly int SpeedHash = Animator.StringToHash("Speed");

    [SerializeField] float walkSpeed = 4f;
    [SerializeField] float holdSeconds = 0.25f;     // a press longer than this walks; a shorter one is a tap

    Rigidbody2D body;
    Animator animator;
    HeroCombat combat;
    Camera mainCamera;
    Facing facing = Facing.Up;
    float pressStart = -1f;     // when the pointer went down, or -1 when it isn't down

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        combat = GetComponent<HeroCombat>();
        mainCamera = Camera.main;
    }

    void Update()
    {
        // While he swings, he stands still.
        Vector2 move = Vector2.zero;
        if (!combat.IsAttacking)
        {
            move = ReadKeyboard() + ReadPointer();
        }

        if (move.sqrMagnitude > 0.01f)
        {
            facing = Facings.FromVector(move, facing);
        }

        // A velocity is safe to set in Update: the Rigidbody keeps it until
        // the next physics step uses it.
        body.linearVelocity = Vector2.ClampMagnitude(move, 1f) * walkSpeed;

        animator.SetInteger(DirectionHash, (int)facing);
        animator.SetFloat(SpeedHash, body.linearVelocity.magnitude);
    }

    // W A S D or the arrows walk; Space or J attacks.
    // A phone may have no keyboard, and then Keyboard.current is null.
    Vector2 ReadKeyboard()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard == null)
        {
            return Vector2.zero;
        }

        Vector2 move = Vector2.zero;
        if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed)
        {
            move.x -= 1f;
        }
        if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed)
        {
            move.x += 1f;
        }
        if (keyboard.sKey.isPressed || keyboard.downArrowKey.isPressed)
        {
            move.y -= 1f;
        }
        if (keyboard.wKey.isPressed || keyboard.upArrowKey.isPressed)
        {
            move.y += 1f;
        }

        if (keyboard.spaceKey.wasPressedThisFrame || keyboard.jKey.wasPressedThisFrame)
        {
            combat.Attack(Facings.ToVector(facing));
        }
        return move.normalized;
    }

    // The mouse, or a finger: held down longer than holdSeconds, he walks
    // towards it; a quicker tap is handled by Tap.
    Vector2 ReadPointer()
    {
        Pointer pointer = Pointer.current;
        if (pointer == null)
        {
            return Vector2.zero;
        }

        if (pointer.press.wasPressedThisFrame)
        {
            pressStart = Time.time;
        }
        if (pressStart < 0f)
        {
            return Vector2.zero;
        }

        Vector2 target = mainCamera.ScreenToWorldPoint(pointer.position.ReadValue());
        if (pointer.press.wasReleasedThisFrame || !pointer.press.isPressed)
        {
            if (Time.time - pressStart <= holdSeconds)
            {
                Tap(target);
            }
            pressStart = -1f;
            return Vector2.zero;
        }

        Vector2 toTarget = target - body.position;
        if (Time.time - pressStart <= holdSeconds || toTarget.magnitude < 0.2f)
        {
            return Vector2.zero;
        }
        return toTarget.normalized;
    }

    // A tap swings the sword the way of the tap.
    void Tap(Vector2 target)
    {
        facing = Facings.FromVector(target - body.position, facing);
        animator.SetInteger(DirectionHash, (int)facing);
        combat.Attack(Facings.ToVector(facing));
    }
}
```

What's new:

- **Space** or **J** calls `combat.Attack` with `Facings.ToVector(facing)`: the way he
  faces, as a direction.
- A press shorter than `holdSeconds` is a **tap**: `Tap` turns him to face the tap, tells
  the Animator his new Direction at once, and swings.
- `Update` reads no input while he's attacking, so he stands still while he swings.

### Do it — the hit frame, on four clips

1. Open the Animation window with `Hero` selected, and pick `Hero Down Attack` in the
   clip menu.
2. Move the playhead to `0:2`. Click **Add Event** (the button with a small marker, under
   the playhead's time): a marker appears on the timeline, above frame 2.
3. Select the marker. In the Inspector, set **Function** to `OnAttackHit`: the drop-down
   lists the public methods of the scripts on `Hero`.
4. Do the same for `Hero Left Attack`, `Hero Up Attack` and `Hero Right Attack`, each at
   `0:2`.

### Do it — something to hit

There are no enemies yet. To see the sword work, make a test target: create an empty
GameObject, `Test Target`, at `(9.5, 4, 0)`, just above the hero, set its **Layer** to
**Enemy**, and **Add Component → Box Collider 2D**.

### Test it

Press **Play**, and walk the hero up to the test target: its collider stops him, facing
it.

- Press **Space**: he swings, and stands still while he does. The Console says `The sword
  hits Test Target` just after the blade sweeps, not when you press.
- Turn away and swing: nothing is hit. Swing again in the middle of a swing: nothing
  happens until the first is over.
- Tap the screen to his right with the mouse: he turns to the right and swings. Hold the
  mouse down instead: he walks, and no swing.
- Swing, then hold **D** at once: the swing finishes, facing up, before he turns. In the
  Animator, Up's Attack goes to Idle, then Exit, then Right.

Delete `Test Target` when you're done.

### Challenge

Move the event on `Hero Down Attack` to frame 0, then to frame 5, and swing at the test
target: how does each feel? Put it back on frame 2. Then let the Scene view show you the
circle: add this method to `HeroCombat`, select `Hero` while you play, and swing.

```csharp
    void OnDrawGizmosSelected()
    {
        Vector2 front = (Vector2)transform.position + middle + attackDirection * hitDistance;
        Gizmos.DrawWireSphere(front, hitRadius);
    }
```

Unity calls `OnDrawGizmosSelected` itself, in the Editor only, while the GameObject is
selected: a **gizmo** is a drawing for you, never seen in the game.

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

## Chapter 6 — The Skeleton

**Goal:** the Hall of Bones, the second room, painted, with stone statues and two
skeletons. A skeleton patrols near where it stands, notices the hero when it can see him,
chases him and swings its sword on its own hit frame. The hero's sword knocks it back, and
three hits fell it. It uses the hero's own Animator, through an **Override Controller**.

### Idea — a skeleton, as a state machine

The skeleton's mind is code: an `enum State` and one `EnterState`, as in C# 7.

| State | What it does | Leaves for |
| --- | --- | --- |
| **Idle** | stands still | Chase, if it sees the hero; Patrol, after 1.5 s |
| **Patrol** | walks at 1.5 to a random point within 2 units of home | Chase, if it sees the hero; Idle, at the point or after 3 s |
| **Chase** | walks at 2.5 towards the hero | Attack, within 1 unit; Idle, beyond 10 |
| **Attack** | stops, faces him, swings: the `Attack` trigger | Chase, after 0.7 s, as long as the clip |
| **Hurt** | is knocked back; the `Hurt` trigger | Chase, or Dead if its health is gone, after 0.4 s |
| **Dead** | stops, and switches off its collider; the `Dead` trigger | nothing: its Dead clip's last frame hides it |

```
            sees him                  within 1
   Idle ─────────────► Chase ─────────────────► Attack
    ▲  ╲  1.5 s           ▲   ◄─── after 0.7 s ───┘
    │   ▼                 │ beyond 10 ──► Idle
   Patrol ── sees him ────┘
   (any state, when the sword hits) ──► Hurt ── 0.4 s ──► Chase, or Dead
```

Chase starts within 5 units but only gives up beyond 10. With one distance for both, a
hero standing right at the edge would make the skeleton flip between Idle and Chase every
frame.

### Idea — the code decides, the Animator shows the body

The skeleton's Animator is the hero's: Direction, Speed and the three triggers. Its code
has six states, the Animator twenty, and they don't need to match. The code decides **what
to do**; the Animator only shows **the body doing it**: which way it faces, whether its
feet move, and a swing, a hurt or a fall when one happens. Patrol and Chase are both just
Walk to the Animator, at different Speeds.

### Idea — line of sight

`Physics2D.Linecast(from, to, layerMask)` is new. It looks along the straight line between
two points, and returns the first collider it meets on the mask's layers, or nothing. With
the mask set to **Walls**, `!Physics2D.Linecast(skeleton, hero, wallMask)` means *no wall
is in the way*: the skeleton can see him. Statues and torches are on the Walls layer too,
so they hide him.

A skeleton only **notices** the hero when it can see him. Once it's chasing, it follows
him round a statue: it knows where he went.

`Random.insideUnitCircle` is new too: a random point inside a circle of radius 1. Times
`patrolDistance`, round the skeleton's home, it's somewhere to wander to.

### Do it — the skeleton's twenty clips

1. Select all 20 sheets in `Assets/Art/Characters/Skeleton`, and set them as the hero's
   were: **Multiple**, `32` Pixels Per Unit, **Point (no filter)**, Compression **None**.
   **Apply**.
2. Slice each one as the hero's: **Grid By Cell Size** `48` × `48`, a **Custom** pivot
   in **Pixels** at `(24, 8)`.
3. Drag `SkeletonDownIdle_0` into the Hierarchy, and rename it `Skeleton`. Select it, and
   in the Animation window click **Create**: save `Assets/Animation/Skeleton Down
   Idle.anim`. Unity makes `Skeleton.controller` too; it only holds the clips while you
   make them.
4. Make the skeleton's twenty clips as you made the hero's, named `Skeleton Down Idle`,
   `Skeleton Down Walk` and so on, from its sheets:

| Animation | Frames | Samples | Loop Time |
| --- | --- | --- | --- |
| Idle | 6 | 8 | on |
| Walk | 6 | 10 | on |
| Attack | 8 | 12 | off |
| Hurt | 4 | 10 | off |
| Dead (from the `Death` sheets) | 8, then a fade | 10 | off |

5. Give each Dead clip the hero's fade: its frames end at `0:8`, so keyframes on Color
   at `1:3` (A `1`) and `1:8` (A `0`).
6. Add the events. On each **Attack** clip, at `0:6`, the frame the skeleton's blade cuts:
   `OnAttackHit`. On each **Dead** clip, at its very end, `1:8`: `OnDeathFinished`.

### Do it — one controller for two

The skeleton's animations are the hero's, the same five in the same four directions. So it
can use the same state machine, `Humanoid`, with its own clips: an **Animator Override
Controller**.

1. In `Assets/Animation`, right-click → **Create → Animation → Animator Override
   Controller**, and name it `Skeleton Override`.
2. In its Inspector, set **Controller** to `Humanoid`. A list appears: every clip
   `Humanoid` uses, on the left, `Hero Down Idle` to `Hero Right Dead`, each with an empty
   **Override** slot on the right.
3. Drag each skeleton clip into its slot: `Skeleton Down Idle` beside `Hero Down Idle`,
   and so on, all twenty.
4. Select `Skeleton`, and set its **Animator**'s **Controller** to `Skeleton Override`.
   Then delete `Skeleton.controller`: the clips stay.

An Override Controller swaps **clips**, nothing else. Every state, arrow and condition
stays `Humanoid`'s, so a change to `Humanoid` changes the skeleton too.

### Do it — the skeleton

1. Select `Skeleton`. Set its **Layer** to **Enemy**, and its Sprite Renderer's **Sprite
   Sort Point** to **Pivot**.
2. Give it a **Rigidbody 2D** and a **Capsule Collider 2D**, set as the hero's: Dynamic,
   Gravity Scale `0`, Freeze Rotation Z, Interpolate; Horizontal, Size `(0.55, 0.3)`,
   Offset `(0, 0.15)`.

Create `Assets/Scripts/Skeleton.cs`, add it to `Skeleton`, and set its **Wall Mask** to
**Walls**:

```csharp
using UnityEngine;

// A skeleton with a sword, run as a state machine. The code decides what it
// does; its Animator, the hero's Humanoid controller with the skeleton's own
// clips, only shows the body: which way it faces, how fast it walks, and an
// attack, a hurt or a fall when one happens.
[RequireComponent(typeof(Rigidbody2D))]
public class Skeleton : MonoBehaviour
{
    public enum State { Idle, Patrol, Chase, Attack, Hurt, Dead }

    static readonly int DirectionHash = Animator.StringToHash("Direction");
    static readonly int SpeedHash = Animator.StringToHash("Speed");
    static readonly int AttackHash = Animator.StringToHash("Attack");
    static readonly int HurtHash = Animator.StringToHash("Hurt");
    static readonly int DeadHash = Animator.StringToHash("Dead");

    [SerializeField] Transform hero;
    [SerializeField] LayerMask wallMask;
    [SerializeField] int maxHealth = 3;
    [SerializeField] float patrolSpeed = 1.5f;
    [SerializeField] float patrolDistance = 2f;     // how far it wanders from where it started
    [SerializeField] float chaseSpeed = 2.5f;
    [SerializeField] float sightRange = 5f;
    [SerializeField] float attackRange = 1f;
    [SerializeField] float attackSeconds = 0.7f;    // as long as the Attack clip
    [SerializeField] float hurtSeconds = 0.4f;
    [SerializeField] float knockbackSpeed = 4f;

    Rigidbody2D body;
    Animator animator;
    Collider2D bodyCollider;
    SpriteRenderer spriteRenderer;
    Vector2 home;
    Vector2 patrolTarget;
    State state;
    Facing facing = Facing.Down;
    int health;
    float stateStartTime;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        bodyCollider = GetComponent<Collider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        home = transform.position;
    }

    void Start()
    {
        health = maxHealth;
        EnterState(State.Idle);
    }

    void Update()
    {
        switch (state)
        {
            case State.Idle:
                UpdateIdle();
                break;
            case State.Patrol:
                UpdatePatrol();
                break;
            case State.Chase:
                UpdateChase();
                break;
            case State.Attack:
                UpdateAttack();
                break;
            case State.Hurt:
                UpdateHurt();
                break;
            case State.Dead:
                break;                  // waits for the OnDeathFinished Animation Event
        }
        UpdateAnimator();
    }

    // The one place the state changes. The enter step runs once, as the
    // skeleton arrives in its new state.
    void EnterState(State next)
    {
        state = next;
        stateStartTime = Time.time;

        switch (state)
        {
            case State.Idle:
                Stop();
                break;
            case State.Patrol:
                patrolTarget = home + Random.insideUnitCircle * patrolDistance;
                break;
            case State.Chase:
                break;
            case State.Attack:
                Stop();
                FaceHero();
                animator.SetTrigger(AttackHash);
                break;
            case State.Hurt:
                animator.SetTrigger(HurtHash);
                break;
            case State.Dead:
                Stop();
                bodyCollider.enabled = false;
                body.simulated = false;
                animator.SetTrigger(DeadHash);
                break;
        }
    }

    void UpdateIdle()
    {
        if (CanSeeHero())
        {
            EnterState(State.Chase);
        }
        else if (Time.time - stateStartTime > 1.5f)
        {
            EnterState(State.Patrol);
        }
    }

    void UpdatePatrol()
    {
        if (CanSeeHero())
        {
            EnterState(State.Chase);
            return;
        }

        Vector2 toTarget = patrolTarget - body.position;
        if (toTarget.magnitude < 0.1f || Time.time - stateStartTime > 3f)
        {
            EnterState(State.Idle);
            return;
        }
        Move(toTarget.normalized * patrolSpeed);
    }

    // Chase starts within sightRange, but only gives up beyond twice that:
    // with one number for both, a hero standing right at the edge would make
    // the skeleton flip between the two states every frame.
    void UpdateChase()
    {
        Vector2 toHero = HeroPosition() - body.position;
        if (toHero.magnitude > sightRange * 2f)
        {
            EnterState(State.Idle);
            return;
        }
        if (toHero.magnitude <= attackRange)
        {
            EnterState(State.Attack);
            return;
        }
        Move(toHero.normalized * chaseSpeed);
    }

    void UpdateAttack()
    {
        if (Time.time - stateStartTime >= attackSeconds)
        {
            EnterState(State.Chase);
        }
    }

    // The knockback carries it for a moment; then it decides between Chase
    // and Dead.
    void UpdateHurt()
    {
        if (Time.time - stateStartTime > 0.15f)
        {
            Stop();
        }
        if (Time.time - stateStartTime >= hurtSeconds)
        {
            EnterState(health > 0 ? State.Chase : State.Dead);
        }
    }

    // Animation Event: the sword's hit frame. The hero is only hurt if he's
    // still in front of the skeleton, so stepping back at the right moment works.
    public void OnAttackHit()
    {
        if (state != State.Attack)
        {
            return;
        }
        Vector2 front = body.position + Facings.ToVector(facing) * 0.6f;
        if (Vector2.Distance(front, HeroPosition()) < 0.8f)
        {
            Debug.Log("The skeleton's sword hits the hero");
        }
    }

    // The hero's sword hit it.
    public void TakeHit(int damage, Vector2 from)
    {
        if (state == State.Hurt || state == State.Dead)
        {
            return;
        }
        health -= damage;
        body.linearVelocity = (body.position - from).normalized * knockbackSpeed;
        EnterState(State.Hurt);
    }

    // Animation Event: at the end of the Dead clips, once it has faded.
    public void OnDeathFinished()
    {
        gameObject.SetActive(false);
    }

    bool CanSeeHero()
    {
        Vector2 heroPosition = HeroPosition();
        if (Vector2.Distance(body.position, heroPosition) > sightRange)
        {
            return false;
        }
        // A wall between them blocks the view.
        return !Physics2D.Linecast(body.position, heroPosition, wallMask);
    }

    Vector2 HeroPosition()
    {
        return hero.position;
    }

    void Move(Vector2 velocity)
    {
        body.linearVelocity = velocity;
        facing = Facings.FromVector(velocity, facing);
    }

    void Stop()
    {
        body.linearVelocity = Vector2.zero;
    }

    void FaceHero()
    {
        facing = Facings.FromVector(HeroPosition() - body.position, facing);
    }

    void UpdateAnimator()
    {
        animator.SetInteger(DirectionHash, (int)facing);
        animator.SetFloat(SpeedHash, body.linearVelocity.magnitude);
    }
}
```

Read it before you move on:

- `Update` runs the current state's own method; `EnterState` is the one place the state
  changes, and its `switch` does each state's start: a new patrol point, a trigger, the
  collider switched off.
- `UpdateHurt` stops the knockback after 0.15 s; at 0.4 s it chooses Chase or Dead.
- `OnAttackHit` checks the hero is still in front, 0.6 units ahead, when the blade comes
  down: a hero who steps back in time isn't hit. For now, the Console says so; Chapter 7
  gives the hero hearts to lose.
- `TakeHit` ignores a hit while it's hurt or dead, so one swing can't hit it twice.
- `UpdateAnimator` runs every frame, whatever the state: Direction and Speed.

Drag `Skeleton` into `Assets/Prefabs`, and delete it from the scene: the room's skeletons
will be copies of the prefab.

### Do it — real hits

Replace `HeroCombat` with this version:

```csharp
using UnityEngine;

// The hero's sword. An attack starts the Attack clip, and the clip's hit
// frame calls OnAttackHit: only then does the sword hurt what's in front.
public class HeroCombat : MonoBehaviour
{
    static readonly int AttackHash = Animator.StringToHash("Attack");

    [SerializeField] LayerMask enemyMask;
    [SerializeField] int damage = 1;
    [SerializeField] float attackSeconds = 0.5f;    // as long as the Attack clip
    [SerializeField] float hitDistance = 0.7f;      // how far in front of his middle the sword's circle is
    [SerializeField] float hitRadius = 0.6f;

    // His body's middle, above his feet: the sword's circle is measured from here.
    readonly Vector2 middle = new Vector2(0f, 0.4f);

    Animator animator;
    Vector2 attackDirection;
    float attackEndTime;

    public bool IsAttacking
    {
        get { return Time.time < attackEndTime; }
    }

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // An attack the way he faces: direction is Facings.ToVector of his facing.
    public void Attack(Vector2 direction)
    {
        if (IsAttacking)
        {
            return;
        }
        attackDirection = direction;
        attackEndTime = Time.time + attackSeconds;
        animator.SetTrigger(AttackHash);
    }

    // Animation Event: the sword's hit frame, on all four Attack clips.
    // Everything on the Enemy layer inside the circle is hit.
    public void OnAttackHit()
    {
        Vector2 front = (Vector2)transform.position + middle + attackDirection * hitDistance;
        Collider2D[] hits = Physics2D.OverlapCircleAll(front, hitRadius, enemyMask);
        foreach (Collider2D hit in hits)
        {
            if (hit.TryGetComponent(out Skeleton skeleton))
            {
                skeleton.TakeHit(damage, transform.position);
            }
        }
    }
}
```

`TryGetComponent` asks the collider's GameObject for a `Skeleton`: if it has one, the sword
hits it, `damage` times, from where the hero stands, so the knockback pushes it away from
him.

### Do it — skeletons pass through each other

Open **Edit → Project Settings → Physics 2D**, and in the **Layer Collision Matrix** untick
the box where **Enemy** meets **Enemy**. Two skeletons chasing the hero side by side would
otherwise shove each other about. Chapter 8's arrows will be on the Enemy layer too, and
fly through skeletons.

### Idea — the Hall of Bones's map

Room 2 fills rows 11 to 21, right above the Crypt Gate. Its bottom row has a gap, the
**threshold**, under room 1's doorway: the way in.

```
        0         10
        |         |
  21    #WWWWWWWWDWWWWWWWW#
  20    #WWWtWWWWDWWWWtWWW#
  19    #.................#
  18    #...S.........S...#
  17    #......s..........#
  16    #............s....#
  15    #...S.........S...#
  14    #...............k.#
  13    #..g..............#
  12    #.................#
  11    #########d#########
```

| Mark | Is | Placed in |
| --- | --- | --- |
| `d` | the threshold: floor | this chapter |
| `S` | a statue | this chapter |
| `s` | a skeleton | this chapter |
| `t` | a wall torch | Chapter 14 |
| `k` `g` | a chest with a key, gold | Chapter 10 |

### Do it — paint the Hall of Bones

Paint it as you painted the Crypt Gate, 11 rows higher:

1. **Walls:** the dark (`DungeonTileset_0`) down columns 0 and 18 from row 11 to row 21,
   and along row 11, columns 1 to 17, **except column 9**.
2. **Floor:** the `Floor` Rule Tile, columns 1 to 17, rows 12 to 19; and the threshold,
   column 9, row 11.
3. **Walls:** the wall's face on rows 21 (top: `_1`, `_2`, `_3`) and 20 (bottom: `_14`,
   `_15`, `_16`), with the doorway at column 9 empty, exactly as in Chapter 1.

### Do it — the statues

1. Open `DungeonTileset` in the Sprite Editor again, make two more sprites, as you made
   the standing torch, and click **Apply**. The second is for Chapter 9.

| Name | Position (X, Y, W, H) | Custom Pivot (pixels) |
| --- | --- | --- |
| `Statue` | 416, 96, 32, 32 | (16, 0) |
| `Shield Statue` | 448, 96, 32, 32 | (16, 0) |

2. Drag `Statue` into the Hierarchy. **Sprite Sort Point**: **Pivot**. **Layer**:
   **Walls**. **Add Component → Box Collider 2D**: Size `(0.7, 0.35)`, Offset
   `(0, 0.175)`. Drag it into `Assets/Prefabs`.
3. Make an empty GameObject, `Statues and Banners`, at `(0, 0, 0)`, and four statues
   under it, at `(4.5, 18.15)`, `(14.5, 18.15)`, `(4.5, 15.15)` and `(14.5, 15.15)`.

### Do it — the skeletons

Make an empty GameObject, `Enemies`, at `(0, 0, 0)`. Drag two `Skeleton` prefabs in under
it, at `(7.5, 17.15)` and `(13.5, 16.15)`. Select both, and drag `Hero` from the Hierarchy
into **Hero**: one drag sets both. (A prefab can't point to something in a scene, so each
skeleton in the scene gets its own reference.)

### Test it

The camera doesn't follow the hero from room to room yet: that's Chapter 12. To test the
Hall of Bones, move the hero and the camera there for now: `Hero` to `(9.5, 12.15, 0)`,
and **Main Camera** to `(9.5, 16.5, -10)`. Press **Play**.

- The skeletons stand, then wander round their homes.
- Walk into the middle of the room: the nearer one sees you, and comes at you, faster.
  Stand still: it swings, and the Console says the skeleton's sword hits the hero, on its
  hit frame.
- Hide behind a statue before one sees you: it doesn't notice you, even close by.
- Hit one: it's knocked back, flashes its Hurt clip, and comes again. On the third hit it
  falls, lies still, fades, and is gone.
- Run to the far end of the room: beyond 10 units, it gives up.

Put the hero back at `(9.5, 2.15, 0)` and the camera at `(9.5, 5.5, -10)` when you're done:
the game starts in the Crypt Gate.

### Challenge

Select a skeleton while it chases, and in the **Debug** Inspector watch its **State**
change. Then set one skeleton's **Sight Range** to `2`: an easy skeleton. Prefab
**Overrides** in the Inspector show the field you changed in bold: the prefab is
unchanged, only this copy differs. Set it back with right-click → **Revert**.

## Chapter 7 — Hearts and Hurt

**Goal:** the hero has three hearts, counted in **half hearts**. A skeleton's blade knocks
him back, takes his control away for a moment, and makes him blink; while he blinks,
nothing can hurt him. At 0 he falls, and his Dead clip plays to its end.

### Idea — health in half hearts

A heart that can be half full is easy to draw (Chapter 11), and easy to count, if health
counts the **halves**: 6 health is three whole hearts, and a skeleton's sword, half a
heart, takes 1. Health stays a whole number, so it never ends up at 0.4999 by mistake.

`HeroHealth.MaxHealth` is a `const`, 6: the same for every hero, and known before the game
runs. Other scripts can read it as `HeroHealth.MaxHealth`.

### Idea — what a hit does

| Part | How long | What it does |
| --- | --- | --- |
| **Knockback** | at once | sets his velocity to 6 units a second, away from what hit him |
| **Stun** | 0.2 s | no control: `Hero` doesn't set his velocity, so the knockback carries him |
| **Blinking** | 1 s | his sprite flicks off and on every 0.1 s; nothing can hurt him |
| **Hurt clip** | 0.4 s | the `Hurt` trigger, in the way he faces |

The blinking is a **coroutine**, as in Level 2: a method that runs a little each frame,
waiting with `yield return`. Without the second of blinking, two skeletons together could
take all his hearts in a moment.

### Do it — HeroHealth

Create `Assets/Scripts/HeroHealth.cs`, and add it to `Hero`:

```csharp
using System.Collections;
using UnityEngine;

// The hero's health, counted in half hearts: 6 is three whole hearts. A hit
// knocks him back and makes him blink, and nothing can hurt him while he
// blinks. At 0 he falls.
public class HeroHealth : MonoBehaviour
{
    public const int MaxHealth = 6;

    static readonly int HurtHash = Animator.StringToHash("Hurt");
    static readonly int DeadHash = Animator.StringToHash("Dead");

    [SerializeField] float knockbackSpeed = 6f;
    [SerializeField] float stunSeconds = 0.2f;      // no control, while the knockback carries him
    [SerializeField] float blinkSeconds = 1f;

    Rigidbody2D body;
    Animator animator;
    SpriteRenderer spriteRenderer;
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
    }

    // Something hurt him. from is where it was, so he's knocked away from it.
    public void TakeDamage(int amount, Vector2 from)
    {
        // Nothing hurts him while he blinks, or once he has fallen.
        if (IsDead || isBlinking)
        {
            return;
        }

        Health = Mathf.Max(Health - amount, 0);
        Debug.Log($"Health: {Health}");

        if (Health == 0)
        {
            IsDead = true;
            body.linearVelocity = Vector2.zero;
            animator.SetTrigger(DeadHash);
            return;
        }

        Vector2 away = (body.position - from).normalized;
        body.linearVelocity = away * knockbackSpeed;
        stunnedUntil = Time.time + stunSeconds;
        animator.SetTrigger(HurtHash);
        StartCoroutine(Blink());
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

    // Animation Event: at the end of the Dead clips.
    public void OnDeathFinished()
    {
        Debug.Log("The hero has fallen");
    }
}
```

Read it before you move on:

- `public int Health { get; private set; } = MaxHealth;` is a property any script can read
  and only this one can change, starting at 6.
- `TakeDamage` takes where the hit came **from**, so the knockback pushes him away from
  it: `(body.position - from).normalized` points from the hit to him.
- `Mathf.Max(Health - amount, 0)` keeps health from going below 0.
- At 0, there's no knockback: he falls where he stands, through the `Dead` trigger. The
  Dead clip's last frame will call `OnDeathFinished`; for now, it tells the Console.
- `IsStunned` compares the time with `stunnedUntil`: no timer to count down.

### Do it — the skeleton's sword

Replace `Skeleton` with this version. Its `hero` field is a `HeroHealth` now, so set it
again: select both skeletons in the Hierarchy and drag `Hero` into **Hero**.

```csharp
using UnityEngine;

// A skeleton with a sword, run as a state machine. The code decides what it
// does; its Animator, the hero's Humanoid controller with the skeleton's own
// clips, only shows the body: which way it faces, how fast it walks, and an
// attack, a hurt or a fall when one happens.
[RequireComponent(typeof(Rigidbody2D))]
public class Skeleton : MonoBehaviour
{
    public enum State { Idle, Patrol, Chase, Attack, Hurt, Dead }

    static readonly int DirectionHash = Animator.StringToHash("Direction");
    static readonly int SpeedHash = Animator.StringToHash("Speed");
    static readonly int AttackHash = Animator.StringToHash("Attack");
    static readonly int HurtHash = Animator.StringToHash("Hurt");
    static readonly int DeadHash = Animator.StringToHash("Dead");

    [SerializeField] HeroHealth hero;
    [SerializeField] LayerMask wallMask;
    [SerializeField] int maxHealth = 3;
    [SerializeField] float patrolSpeed = 1.5f;
    [SerializeField] float patrolDistance = 2f;     // how far it wanders from where it started
    [SerializeField] float chaseSpeed = 2.5f;
    [SerializeField] float sightRange = 5f;
    [SerializeField] float attackRange = 1f;
    [SerializeField] float attackSeconds = 0.7f;    // as long as the Attack clip
    [SerializeField] float hurtSeconds = 0.4f;
    [SerializeField] float knockbackSpeed = 4f;

    Rigidbody2D body;
    Animator animator;
    Collider2D bodyCollider;
    SpriteRenderer spriteRenderer;
    Vector2 home;
    Vector2 patrolTarget;
    State state;
    Facing facing = Facing.Down;
    int health;
    float stateStartTime;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        bodyCollider = GetComponent<Collider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        home = transform.position;
    }

    void Start()
    {
        health = maxHealth;
        EnterState(State.Idle);
    }

    void Update()
    {
        switch (state)
        {
            case State.Idle:
                UpdateIdle();
                break;
            case State.Patrol:
                UpdatePatrol();
                break;
            case State.Chase:
                UpdateChase();
                break;
            case State.Attack:
                UpdateAttack();
                break;
            case State.Hurt:
                UpdateHurt();
                break;
            case State.Dead:
                break;                  // waits for the OnDeathFinished Animation Event
        }
        UpdateAnimator();
    }

    // The one place the state changes. The enter step runs once, as the
    // skeleton arrives in its new state.
    void EnterState(State next)
    {
        state = next;
        stateStartTime = Time.time;

        switch (state)
        {
            case State.Idle:
                Stop();
                break;
            case State.Patrol:
                patrolTarget = home + Random.insideUnitCircle * patrolDistance;
                break;
            case State.Chase:
                break;
            case State.Attack:
                Stop();
                FaceHero();
                animator.SetTrigger(AttackHash);
                break;
            case State.Hurt:
                animator.SetTrigger(HurtHash);
                break;
            case State.Dead:
                Stop();
                bodyCollider.enabled = false;
                body.simulated = false;
                animator.SetTrigger(DeadHash);
                break;
        }
    }

    void UpdateIdle()
    {
        if (CanSeeHero())
        {
            EnterState(State.Chase);
        }
        else if (Time.time - stateStartTime > 1.5f)
        {
            EnterState(State.Patrol);
        }
    }

    void UpdatePatrol()
    {
        if (CanSeeHero())
        {
            EnterState(State.Chase);
            return;
        }

        Vector2 toTarget = patrolTarget - body.position;
        if (toTarget.magnitude < 0.1f || Time.time - stateStartTime > 3f)
        {
            EnterState(State.Idle);
            return;
        }
        Move(toTarget.normalized * patrolSpeed);
    }

    // Chase starts within sightRange, but only gives up beyond twice that:
    // with one number for both, a hero standing right at the edge would make
    // the skeleton flip between the two states every frame.
    void UpdateChase()
    {
        Vector2 toHero = HeroPosition() - body.position;
        if (hero.IsDead || toHero.magnitude > sightRange * 2f)
        {
            EnterState(State.Idle);
            return;
        }
        if (toHero.magnitude <= attackRange)
        {
            EnterState(State.Attack);
            return;
        }
        Move(toHero.normalized * chaseSpeed);
    }

    void UpdateAttack()
    {
        if (Time.time - stateStartTime >= attackSeconds)
        {
            EnterState(State.Chase);
        }
    }

    // The knockback carries it for a moment; then it decides between Chase
    // and Dead.
    void UpdateHurt()
    {
        if (Time.time - stateStartTime > 0.15f)
        {
            Stop();
        }
        if (Time.time - stateStartTime >= hurtSeconds)
        {
            EnterState(health > 0 ? State.Chase : State.Dead);
        }
    }

    // Animation Event: the sword's hit frame. The hero is only hurt if he's
    // still in front of the skeleton, so stepping back at the right moment works.
    public void OnAttackHit()
    {
        if (state != State.Attack)
        {
            return;
        }
        Vector2 front = body.position + Facings.ToVector(facing) * 0.6f;
        if (Vector2.Distance(front, HeroPosition()) < 0.8f)
        {
            hero.TakeDamage(1, body.position);
        }
    }

    // The hero's sword hit it.
    public void TakeHit(int damage, Vector2 from)
    {
        if (state == State.Hurt || state == State.Dead)
        {
            return;
        }
        health -= damage;
        body.linearVelocity = (body.position - from).normalized * knockbackSpeed;
        EnterState(State.Hurt);
    }

    // Animation Event: at the end of the Dead clips, once it has faded.
    public void OnDeathFinished()
    {
        gameObject.SetActive(false);
    }

    bool CanSeeHero()
    {
        Vector2 heroPosition = HeroPosition();
        if (hero.IsDead || Vector2.Distance(body.position, heroPosition) > sightRange)
        {
            return false;
        }
        // A wall between them blocks the view.
        return !Physics2D.Linecast(body.position, heroPosition, wallMask);
    }

    Vector2 HeroPosition()
    {
        return hero.transform.position;
    }

    void Move(Vector2 velocity)
    {
        body.linearVelocity = velocity;
        facing = Facings.FromVector(velocity, facing);
    }

    void Stop()
    {
        body.linearVelocity = Vector2.zero;
    }

    void FaceHero()
    {
        facing = Facings.FromVector(HeroPosition() - body.position, facing);
    }

    void UpdateAnimator()
    {
        animator.SetInteger(DirectionHash, (int)facing);
        animator.SetFloat(SpeedHash, body.linearVelocity.magnitude);
    }
}
```

`OnAttackHit` hurts the hero now, by 1, from where the skeleton stands. A skeleton also
stops seeing a hero who has fallen: `hero.IsDead` ends a chase.

### Do it — the hero loses control

Replace `Hero` with this version:

```csharp
using UnityEngine;
using UnityEngine.InputSystem;

// The hero: walks with the keyboard, or towards a pointer that's held down,
// and faces one of four ways. Every frame he tells the Animator his Direction
// and his Speed. A quick tap swings the sword.
[RequireComponent(typeof(Rigidbody2D))]
public class Hero : MonoBehaviour
{
    static readonly int DirectionHash = Animator.StringToHash("Direction");
    static readonly int SpeedHash = Animator.StringToHash("Speed");

    [SerializeField] float walkSpeed = 4f;
    [SerializeField] float holdSeconds = 0.25f;     // a press longer than this walks; a shorter one is a tap

    Rigidbody2D body;
    Animator animator;
    HeroCombat combat;
    HeroHealth health;
    Camera mainCamera;
    Facing facing = Facing.Up;
    float pressStart = -1f;     // when the pointer went down, or -1 when it isn't down

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        combat = GetComponent<HeroCombat>();
        health = GetComponent<HeroHealth>();
        mainCamera = Camera.main;
    }

    void Update()
    {
        Vector2 move = Vector2.zero;
        if (HasControl() && !combat.IsAttacking)
        {
            move = ReadKeyboard() + ReadPointer();
        }
        else if (!HasControl())
        {
            pressStart = -1f;
        }

        if (move.sqrMagnitude > 0.01f)
        {
            facing = Facings.FromVector(move, facing);
        }

        // While he's stunned, the knockback carries him instead. A velocity
        // is safe to set in Update: the Rigidbody keeps it until the next
        // physics step uses it.
        if (!health.IsStunned)
        {
            body.linearVelocity = Vector2.ClampMagnitude(move, 1f) * walkSpeed;
        }

        animator.SetInteger(DirectionHash, (int)facing);
        animator.SetFloat(SpeedHash, body.linearVelocity.magnitude);
    }

    bool HasControl()
    {
        return !health.IsDead && !health.IsStunned;
    }

    // W A S D or the arrows walk; Space or J attacks.
    // A phone may have no keyboard, and then Keyboard.current is null.
    Vector2 ReadKeyboard()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard == null)
        {
            return Vector2.zero;
        }

        Vector2 move = Vector2.zero;
        if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed)
        {
            move.x -= 1f;
        }
        if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed)
        {
            move.x += 1f;
        }
        if (keyboard.sKey.isPressed || keyboard.downArrowKey.isPressed)
        {
            move.y -= 1f;
        }
        if (keyboard.wKey.isPressed || keyboard.upArrowKey.isPressed)
        {
            move.y += 1f;
        }

        if (keyboard.spaceKey.wasPressedThisFrame || keyboard.jKey.wasPressedThisFrame)
        {
            combat.Attack(Facings.ToVector(facing));
        }
        return move.normalized;
    }

    // The mouse, or a finger: held down longer than holdSeconds, he walks
    // towards it; a quicker tap is handled by Tap.
    Vector2 ReadPointer()
    {
        Pointer pointer = Pointer.current;
        if (pointer == null)
        {
            return Vector2.zero;
        }

        if (pointer.press.wasPressedThisFrame)
        {
            pressStart = Time.time;
        }
        if (pressStart < 0f)
        {
            return Vector2.zero;
        }

        Vector2 target = mainCamera.ScreenToWorldPoint(pointer.position.ReadValue());
        if (pointer.press.wasReleasedThisFrame || !pointer.press.isPressed)
        {
            if (Time.time - pressStart <= holdSeconds)
            {
                Tap(target);
            }
            pressStart = -1f;
            return Vector2.zero;
        }

        Vector2 toTarget = target - body.position;
        if (Time.time - pressStart <= holdSeconds || toTarget.magnitude < 0.2f)
        {
            return Vector2.zero;
        }
        return toTarget.normalized;
    }

    // A tap swings the sword the way of the tap.
    void Tap(Vector2 target)
    {
        facing = Facings.FromVector(target - body.position, facing);
        animator.SetInteger(DirectionHash, (int)facing);
        combat.Attack(Facings.ToVector(facing));
    }
}
```

`HasControl` is false while he's stunned or fallen: no input is read, and a press that
started before is forgotten. While he's stunned, `Update` leaves his velocity alone, so the
knockback carries him.

### Do it — the hero's last frame

In the Animation window, give each of the hero's four Dead clips an Animation Event at its
very end, calling `OnDeathFinished`: at `1:5` on Down, Left and Right, and at `1:6` on Up.

### Test it

Move the hero and the camera to the Hall of Bones again, as in Chapter 6, and press
**Play**.

- Let a skeleton swing at you: you're knocked back, you blink, and the Console says
  `Health: 5`. While you blink, a second swing does nothing.
- During the knockback, your keys do nothing for a moment.
- Let the skeletons win: at `Health: 0` the hero falls in the way he faces, lies still,
  fades away, and the Console says `The hero has fallen`. The skeletons stop chasing.

Put the hero and the camera back in the Crypt Gate when you're done.

### Challenge

Set **Blink Seconds** to `0`, and let two skeletons catch you at once: count how quickly
the hearts go. Put it back to `1`. Then set **Knockback Speed** to `12`: is the game
better, or just harder? Where does a knockback that's too strong send you?

Then build a **spike trap**: a tile of floor whose spikes go up and down by themselves,
and hurt only while they're up. `Assets/Art/Props/Spikes` has four 16-pixel frames, down
to up: import it at `16` Pixels Per Unit, so it's one tile, and slice it with its pivot at
the middle of its bottom edge, `(8, 0)`. Give a `Spikes` GameObject
a Box Collider 2D with **Is Trigger** ticked, and a looping clip: the spikes down for a
second, rising over three frames, up for a second, and back down. Put an Animation Event
on the frame they're fully up, `OnSpikesUp`, and one where they start down,
`OnSpikesDown`. In a script of your own, `Spikes`, those two methods switch the collider
on and off (`spikeCollider.enabled = true;`), and `OnTriggerStay2D` hurts a hero who stands
there: `TryGetComponent(out HeroHealth hero)`, then `hero.TakeDamage(1,
transform.position)`. No timer anywhere in the code: the clip is the clock.

## Chapter 8 — The Archer

**Goal:** the Ossuary, the third room, painted, with pillars to hide behind, two skeletons
and a skeleton archer. The archer keeps its distance, shoots on the **release frame** of
its bow, and steps aside. Its arrows fly straight, cost half a heart, and break on walls
and pillars.

### Idea — the archer's states

| State | What it does | Leaves for |
| --- | --- | --- |
| **Idle** | stands still | Keep Distance, when it sees the hero (9 units) |
| **Keep Distance** | backs away if he's nearer than 4, still facing him; comes closer if he's further than 6 | Shoot, between 4 and 6; Idle, if it can't see him |
| **Shoot** | stops, faces him, draws: the `Attack` trigger | Reposition, after 1 s, as long as the clip |
| **Reposition** | steps sideways, across the line to the hero, for 0.8 s | Keep Distance |
| **Hurt**, **Dead** | as the skeleton's | |

```
            sees him              between 4 and 6
   Idle ──────────► Keep Distance ───────────────► Shoot
                     ▲   (backs away, or closes in)   │ 1 s
                     └──────── Reposition ◄───────────┘
                                 0.8 s sideways
```

After each shot it steps left or right at random: a target that moves is harder to hit
back, and the hero has to think about where to stand.

### Idea — the release frame

The archer's attack clip is twelve frames at 12 samples, one second: it draws, holds, and
looses. The arrow leaves the bow on **frame 8**, `0:8`. An Animation Event there calls
`OnAttackHit`, and the code makes an arrow at that moment, aimed at where the hero is
**then**. A hero who keeps moving is missed.

### Idea — an arrow at the height of the feet

Every collider in the crypt is at the feet: the hero's, the walls' bottom edge, the
pillars'. So the arrow's collider flies at the height of the feet too, from the archer's
feet to where the hero's feet were. Its picture is a child, `Picture`, drawn 0.4 higher,
at the height of a bow, and turned to point the way it flies: `picture.up = direction`.

The arrow is on the **Enemy** layer: Enemy against Enemy is unticked in the collision
matrix, so it flies through skeletons and archers. Its collider is a **trigger**, so it
pushes nothing; `OnTriggerEnter2D` decides what happens. It ignores other triggers, hurts
the hero, and breaks on anything solid. `Destroy(gameObject, 3f)` removes it after 3
seconds anyway, if it hits nothing.

### Do it — the archer's clips and its Override Controller

1. Import and slice the 20 sheets in `Assets/Art/Characters/Archer` exactly as the
   skeleton's.
2. Make the archer's twenty clips, `Archer Down Idle` and so on, as you made the
   skeleton's: on a temporary `Archer` GameObject (drag `ArcherDownIdle_0` into the
   Hierarchy), whose `Archer.controller` you delete afterwards.

| Animation | Frames | Samples | Loop Time | Events |
| --- | --- | --- | --- | --- |
| Idle | 6 | 8 | on | |
| Walk | 6 | 10 | on | |
| Attack | 12 | 12 | off | `OnAttackHit` at `0:8`, the release |
| Hurt | 4 | 10 | off | |
| Dead | 8, then the fade (keys at `1:3` and `1:8`) | 10 | off | `OnDeathFinished` at `1:8` |

3. Create an **Animator Override Controller**, `Archer Override`, for `Humanoid`, and drag
   the twenty archer clips into its slots.
4. Set the `Archer` GameObject's Animator to `Archer Override`, delete `Archer.controller`,
   and set the archer up as the skeleton was: Layer **Enemy**, Sprite Sort Point
   **Pivot**, the same Rigidbody 2D and Capsule Collider 2D.

### Do it — the arrow

1. Select `Assets/Art/Props/Arrow`. Set **Sprite Mode** to **Single**, **Pixels Per Unit**
   to `32`, **Filter Mode** to **Point (no filter)** and **Compression** to **None**, and
   click **Apply**. A single sprite's pivot is its middle.
2. Create an empty GameObject, `Arrow`, with its **Layer** set to **Enemy**. Give it a
   **Rigidbody 2D** (Dynamic, Gravity Scale `0`, Freeze Rotation Z, Interpolate) and a
   **Circle Collider 2D** with **Is Trigger** ticked and **Radius** `0.15`.
3. Drag the `Arrow` sprite onto the `Arrow` GameObject in the Hierarchy: it becomes a child
   with a Sprite Renderer. Rename the child `Picture`, set its **Position** to
   `(0, 0.4, 0)`, its **Layer** to **Enemy**, and its **Sprite Sort Point** to **Pivot**.

Create `Assets/Scripts/Arrow.cs`, add it to `Arrow`, and drag `Picture` into its
**Picture** field:

```csharp:Arrow.cs
using UnityEngine;

// An archer's arrow. It flies straight, hurts the hero, and breaks on
// anything solid. Like every collider in the crypt, its collider is at the
// height of the feet; its picture is a child, drawn higher, at the height of
// a bow. It's on the Enemy layer, so it flies through skeletons.
[RequireComponent(typeof(Rigidbody2D))]
public class Arrow : MonoBehaviour
{
    [SerializeField] Transform picture;
    [SerializeField] float speed = 7f;
    [SerializeField] int damage = 1;
    [SerializeField] float lifeSeconds = 3f;

    public void Launch(Vector2 direction)
    {
        // The picture points up: turn its up to the way the arrow flies.
        picture.up = direction.normalized;
        GetComponent<Rigidbody2D>().linearVelocity = direction.normalized * speed;
        Destroy(gameObject, lifeSeconds);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Other triggers, such as pickups, aren't in the way.
        if (other.isTrigger)
        {
            return;
        }
        if (other.TryGetComponent(out HeroHealth hero))
        {
            hero.TakeDamage(damage, transform.position);
        }
        Destroy(gameObject);
    }
}
```

Drag `Arrow` into `Assets/Prefabs`, and delete it from the scene.

### Do it — the Archer script

Create `Assets/Scripts/Archer.cs`, and add it to `Archer`:

```csharp
using UnityEngine;

// A skeleton archer, run as a state machine. It keeps its distance, shoots
// when it can see the hero, then steps aside before shooting again. Its
// Animator is the Humanoid controller, with the archer's own clips.
[RequireComponent(typeof(Rigidbody2D))]
public class Archer : MonoBehaviour
{
    public enum State { Idle, KeepDistance, Shoot, Reposition, Hurt, Dead }

    static readonly int DirectionHash = Animator.StringToHash("Direction");
    static readonly int SpeedHash = Animator.StringToHash("Speed");
    static readonly int AttackHash = Animator.StringToHash("Attack");
    static readonly int HurtHash = Animator.StringToHash("Hurt");
    static readonly int DeadHash = Animator.StringToHash("Dead");

    [SerializeField] HeroHealth hero;
    [SerializeField] Arrow arrowPrefab;
    [SerializeField] Transform arrowGroup;          // where its arrows go, so Restart can clear them
    [SerializeField] LayerMask wallMask;
    [SerializeField] int maxHealth = 2;
    [SerializeField] float moveSpeed = 2f;
    [SerializeField] float sightRange = 9f;
    [SerializeField] float tooClose = 4f;           // closer than this, it backs away
    [SerializeField] float tooFar = 6f;             // further than this, it comes closer
    [SerializeField] float shootSeconds = 1f;       // as long as the Attack clip
    [SerializeField] float repositionSeconds = 0.8f;
    [SerializeField] float hurtSeconds = 0.4f;
    [SerializeField] float knockbackSpeed = 4f;

    Rigidbody2D body;
    Animator animator;
    Collider2D bodyCollider;
    SpriteRenderer spriteRenderer;
    Vector2 home;
    Vector2 sideStep;
    State state;
    Facing facing = Facing.Down;
    int health;
    float stateStartTime;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        bodyCollider = GetComponent<Collider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        home = transform.position;
    }

    void Start()
    {
        health = maxHealth;
        EnterState(State.Idle);
    }

    void Update()
    {
        switch (state)
        {
            case State.Idle:
                UpdateIdle();
                break;
            case State.KeepDistance:
                UpdateKeepDistance();
                break;
            case State.Shoot:
                UpdateShoot();
                break;
            case State.Reposition:
                UpdateReposition();
                break;
            case State.Hurt:
                UpdateHurt();
                break;
            case State.Dead:
                break;                  // waits for the OnDeathFinished Animation Event
        }
        UpdateAnimator();
    }

    void EnterState(State next)
    {
        state = next;
        stateStartTime = Time.time;

        switch (state)
        {
            case State.Idle:
                Stop();
                break;
            case State.KeepDistance:
                break;
            case State.Shoot:
                Stop();
                FaceHero();
                animator.SetTrigger(AttackHash);
                break;
            case State.Reposition:
                // A step to one side or the other, across the line to the hero.
                Vector2 toHero = (HeroPosition() - body.position).normalized;
                Vector2 across = new Vector2(-toHero.y, toHero.x);
                sideStep = (Random.value < 0.5f ? across : -across) * moveSpeed;
                break;
            case State.Hurt:
                animator.SetTrigger(HurtHash);
                break;
            case State.Dead:
                Stop();
                bodyCollider.enabled = false;
                body.simulated = false;
                animator.SetTrigger(DeadHash);
                break;
        }
    }

    void UpdateIdle()
    {
        if (CanSeeHero())
        {
            EnterState(State.KeepDistance);
        }
    }

    void UpdateKeepDistance()
    {
        if (!CanSeeHero())
        {
            EnterState(State.Idle);
            return;
        }

        Vector2 toHero = HeroPosition() - body.position;
        if (toHero.magnitude < tooClose)
        {
            Move(-toHero.normalized * moveSpeed);
            facing = Facings.FromVector(toHero, facing);     // backs away, still facing the hero
        }
        else if (toHero.magnitude > tooFar)
        {
            Move(toHero.normalized * moveSpeed);
        }
        else
        {
            EnterState(State.Shoot);
        }
    }

    void UpdateShoot()
    {
        if (Time.time - stateStartTime >= shootSeconds)
        {
            EnterState(State.Reposition);
        }
    }

    void UpdateReposition()
    {
        Move(sideStep);
        if (Time.time - stateStartTime >= repositionSeconds)
        {
            EnterState(State.KeepDistance);
        }
    }

    void UpdateHurt()
    {
        if (Time.time - stateStartTime > 0.15f)
        {
            Stop();
        }
        if (Time.time - stateStartTime >= hurtSeconds)
        {
            EnterState(health > 0 ? State.KeepDistance : State.Dead);
        }
    }

    // Animation Event: the release frame, as the bowstring snaps forward.
    // The arrow flies from the archer's feet at where the hero's feet are now.
    public void OnAttackHit()
    {
        if (state != State.Shoot)
        {
            return;
        }
        Vector2 from = body.position + Facings.ToVector(facing) * 0.4f;
        Arrow arrow = Instantiate(arrowPrefab, from, Quaternion.identity, arrowGroup);
        arrow.Launch(HeroPosition() - from);
    }

    public void TakeHit(int damage, Vector2 from)
    {
        if (state == State.Hurt || state == State.Dead)
        {
            return;
        }
        health -= damage;
        body.linearVelocity = (body.position - from).normalized * knockbackSpeed;
        EnterState(State.Hurt);
    }

    // Animation Event: at the end of the Dead clips, once it has faded.
    public void OnDeathFinished()
    {
        gameObject.SetActive(false);
    }

    // It sees the hero if he's within range and no wall is in the way. A
    // statue isn't a wall, but its collider is on the Walls layer too: cover.
    bool CanSeeHero()
    {
        Vector2 heroPosition = HeroPosition();
        if (hero.IsDead || Vector2.Distance(body.position, heroPosition) > sightRange)
        {
            return false;
        }
        return !Physics2D.Linecast(body.position, heroPosition, wallMask);
    }

    Vector2 HeroPosition()
    {
        return hero.transform.position;
    }

    void Move(Vector2 velocity)
    {
        body.linearVelocity = velocity;
        facing = Facings.FromVector(velocity, facing);
    }

    void Stop()
    {
        body.linearVelocity = Vector2.zero;
    }

    void FaceHero()
    {
        facing = Facings.FromVector(HeroPosition() - body.position, facing);
    }

    void UpdateAnimator()
    {
        animator.SetInteger(DirectionHash, (int)facing);
        animator.SetFloat(SpeedHash, body.linearVelocity.magnitude);
    }
}
```

Read it before you move on:

- `UpdateKeepDistance` walks away from the hero, then turns him round to face the hero
  again: `Move` sets the facing from the velocity, and the line after it sets it back.
  The archer backs away looking at him.
- In `EnterState(State.Reposition)`, `new Vector2(-toHero.y, toHero.x)` is the direction
  to the hero turned a quarter round: across the line between them. `Random.value < 0.5f`
  picks left or right, half the time each.
- `OnAttackHit` makes the arrow with `Instantiate(arrowPrefab, from, Quaternion.identity,
  arrowGroup)`: the prefab, where, which way round, and the parent it goes under. Its
  type is `Arrow`, so `Instantiate` hands back the new arrow's script, ready for `Launch`.
- An archer's code repeats the skeleton's hurt, death and helpers, nearly line for line.
  Level 4 shares them through **inheritance**: one `Enemy` class that both build on. For
  now, two scripts it is.

Set the archer's **Arrow Prefab** to the `Arrow` prefab, its **Wall Mask** to **Walls**,
and drag `Archer` into `Assets/Prefabs`. Delete it from the scene.

### Do it — the sword hits archers too

Replace `HeroCombat` with this version:

```csharp
using UnityEngine;

// The hero's sword. An attack starts the Attack clip, and the clip's hit
// frame calls OnAttackHit: only then does the sword hurt what's in front.
public class HeroCombat : MonoBehaviour
{
    static readonly int AttackHash = Animator.StringToHash("Attack");

    [SerializeField] LayerMask enemyMask;
    [SerializeField] int damage = 1;
    [SerializeField] float attackSeconds = 0.5f;    // as long as the Attack clip
    [SerializeField] float hitDistance = 0.7f;      // how far in front of his middle the sword's circle is
    [SerializeField] float hitRadius = 0.6f;

    // His body's middle, above his feet: the sword's circle is measured from here.
    readonly Vector2 middle = new Vector2(0f, 0.4f);

    Animator animator;
    Vector2 attackDirection;
    float attackEndTime;

    public bool IsAttacking
    {
        get { return Time.time < attackEndTime; }
    }

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // An attack the way he faces: direction is Facings.ToVector of his facing.
    public void Attack(Vector2 direction)
    {
        if (IsAttacking)
        {
            return;
        }
        attackDirection = direction;
        attackEndTime = Time.time + attackSeconds;
        animator.SetTrigger(AttackHash);
    }

    // Animation Event: the sword's hit frame, on all four Attack clips.
    // Everything on the Enemy layer inside the circle is hit.
    public void OnAttackHit()
    {
        Vector2 front = (Vector2)transform.position + middle + attackDirection * hitDistance;
        Collider2D[] hits = Physics2D.OverlapCircleAll(front, hitRadius, enemyMask);
        foreach (Collider2D hit in hits)
        {
            if (hit.TryGetComponent(out Skeleton skeleton))
            {
                skeleton.TakeHit(damage, transform.position);
            }
            else if (hit.TryGetComponent(out Archer archer))
            {
                archer.TakeHit(damage, transform.position);
            }
        }
    }
}
```

### Idea — the Ossuary's map

Room 3 fills rows 22 to 32.

```
        0         10
        |         |
  32    #WWWWWWWWDWWWWWWWW#
  31    #WWWtWWWWDWWWWtWWW#
  30    #.........a.......#
  29    #...O.........O...#
  28    #.................#
  27    #..s.........s....#
  26    #...O.........O...#
  25    #.q...............#
  24    #.................#
  23    #.................#
  22    #########d#########
```

| Mark | Is | Placed in |
| --- | --- | --- |
| `O` | a pillar: a block of wall standing on the floor | this chapter |
| `s` `a` | a skeleton, the archer | this chapter |
| `q` | a chest with a potion and a key | Chapter 10 |

### Do it — paint the Ossuary

1. Paint the dark, the floor and the threshold (column 9, row 22), and the wall's face on
   rows 32 and 31 with the doorway at column 9, as you painted the Hall of Bones.
2. Cut one more sprite out of `DungeonTileset`: `Pillar`, **Position** `X 160`, `Y 32`,
   `W 32`, `H 72`, pivot `(16, 0)`. It's the block of wall at column 5, rows 4 to 6 of the
   sheet, with its dark top.
3. Make a `Pillar` prefab as you made the statue's: Sort Point **Pivot**, Layer **Walls**,
   a **Box Collider 2D** with **Size** `(1, 0.6)` and **Offset** `(0, 0.3)`. Put four
   under `Statues and Banners`, at `(4.5, 29)`, `(14.5, 29)`, `(4.5, 26)` and
   `(14.5, 26)`.
4. Make an empty GameObject, `Arrows`, at `(0, 0, 0)`: the archers' arrows go under it.
5. Under `Enemies`: two skeletons at `(3.5, 27.15)` and `(13.5, 27.15)`, and an archer at
   `(10.5, 30.15)`. Set the three's **Hero** to `Hero`, and the archer's **Arrow Group** to
   `Arrows`.

### Test it

Move the hero to `(9.5, 23.15, 0)` and the camera to `(9.5, 27.5, -10)`, and press
**Play**.

- The archer sees you, comes to between 4 and 6 units away, draws, and looses on frame
  8. The arrow flies at where you stood: step aside as it draws, and it misses.
- An arrow that hits costs half a heart and knocks you back from where it hit.
- Walk towards the archer: it backs away, facing you. Hide behind a pillar: it can't see
  you, and arrows break on the pillar.
- An arrow flies through the skeletons, and breaks on the wall.
- Two sword hits fell the archer.

Put the hero and the camera back in the Crypt Gate when you're done.

### Challenge

Give the archer's prefab **Too Close** `3` and **Too Far** `8`, and watch where it stands
now. Then set **Shoot Seconds** to `0.6`, and play: the archer draws, again and again, and
never shoots. Why? (When is the release frame, and what does `OnAttackHit` check first?)
Put it back to `1`. Last, give a pillar a thin collider, **Size** `(1, 0.2)`: what happens
to its cover, and why?

# Part 3 — Keys, Doors and Chests

## Chapter 9 — Keys and Doors

**Goal:** a door in the top wall of every room but the last, all five locked. A key on
the floor goes into the hero's pocket. Walking into a door with a key opens it: an `Open`
**Bool** starts its Opening clip, its two leaves fold back to their hinges, and the clip's
last frame clears the way. The Archers' Gallery, the fourth room, painted.

### Idea — what the hero carries

An **Inventory** on the hero counts what he carries: keys, and the boss key, which opens
only the last door. A key is a **pickup**: a trigger he walks into. Every kind of pickup
in the crypt (a key, the boss key, and in Chapter 10 a potion and gold) does the same
thing, *tell the inventory, then vanish*, so they share one script, `Pickup`, with an
`enum Kind` and a `switch` that does each kind's part.

### Idea — a door in three pictures

The arched door is drawn closed. To open it, it's cut into three sprites, one on top of
another at the same place:

| Sprite | Is | Draws |
| --- | --- | --- |
| `Doorway` | the whole door, coloured black | the dark opening behind the door |
| `Left Leaf` | the door's left half | in front of the doorway |
| `Right Leaf` | the door's right half | in front of the doorway |

Each leaf's **pivot** is its **hinge**, at the door's outer edge. A clip that scales a leaf's
**Scale X** from 1 down to 0.15 folds it back towards its hinge, as a door seen from the
front swings open, leaving the dark doorway between them.

The door's Animator has three states and a **Bool**, `Open`:

```
   Closed ── Open is true ──► Opening ── at its end ──► Open
     ▲                                                    │
     └─────────────────── Open is false ──────────────────┘
```

A **Bool**, not a trigger: a trigger is a moment, but an open door is a state it stays in.
Chapter 12's Restart sets it back to false, and the door closes.

**Opening**'s last frame has an Animation Event, `OnDoorOpened`. Only then does the door
switch off its **blocker**, the Box Collider 2D that fills the doorway: the hero can't
squeeze through a door that's still opening.

### Idea — a Sorting Group

Three sprites at one place would each be sorted on their own against the hero, and could
come out in the wrong order. A **Sorting Group** on their parent makes them sort as one
picture, at the parent's position, the door's foot. Inside the group, their own **Order in
Layer** puts them in order: the doorway `0`, the leaves `1`.

### Do it — Inventory and Pickup

Create `Assets/Scripts/Inventory.cs`, and add it to `Hero`:

```csharp
using UnityEngine;

// What the hero carries: keys and the boss key.
// For now, the Console shows what he carries.
public class Inventory : MonoBehaviour
{
    int keys;
    bool hasBossKey;

    public void AddKey()
    {
        keys++;
        UpdateScreen();
    }

    public void AddBossKey()
    {
        hasBossKey = true;
        UpdateScreen();
    }

    // A door asks for a key: true if there was one to use.
    public bool UseKey()
    {
        if (keys == 0)
        {
            return false;
        }
        keys--;
        UpdateScreen();
        return true;
    }

    public bool UseBossKey()
    {
        if (!hasBossKey)
        {
            return false;
        }
        hasBossKey = false;
        UpdateScreen();
        return true;
    }

    void UpdateScreen()
    {
        Debug.Log($"Keys: {keys}, boss key: {hasBossKey}");
    }
}
```

`UseKey` returns `true` and uses a key if there is one, and returns `false` if not: the
door asks, and the answer tells it whether to open. For now, `UpdateScreen` shows the
inventory in the Console; Chapter 11 puts it on the screen.

Create `Assets/Scripts/Pickup.cs`:

```csharp
using UnityEngine;

// A key or the boss key: one script for both. Its Kind says which, and a
// switch does the rest.
public class Pickup : MonoBehaviour
{
    public enum Kind { Key, BossKey }

    [SerializeField] Kind kind;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.TryGetComponent(out Inventory inventory))
        {
            return;
        }

        switch (kind)
        {
            case Kind.Key:
                inventory.AddKey();
                break;
            case Kind.BossKey:
                inventory.AddBossKey();
                break;
        }
        gameObject.SetActive(false);
    }
}
```

`OnTriggerEnter2D` gives up straight away unless the collider that came in belongs to
something with an `Inventory`: only the hero picks things up.

### Do it — the keys

1. Select `Key` and `BossKey` in `Assets/Art/Props`, and set them as you set the arrow:
   **Single**, `32` Pixels Per Unit, **Point (no filter)**, Compression **None**.
2. Make an empty GameObject, `Key`. **Add Component → Circle Collider 2D**: **Is Trigger**
   ticked, **Radius** `0.3`. Add `Pickup`, with **Kind** **Key**.
3. Drag the `Key` sprite onto it in the Hierarchy: a child. Rename it `Sprite`, and set
   its **Sprite Sort Point** to **Pivot**.
4. With `Key` selected, **Create** a clip in the Animation window, `Assets/Animation/Key
   Bob.anim`, at 30 samples. **Add Property → Sprite → Transform → Position**, and make
   **Position.y** `0` at `0:00`, `0.1` at `0:15` and `0` at `1:00`. Unity names its new
   controller `Key`. The key bobs, while the key itself, and its collider, stay where
   they were put.
5. Drag `Key` into `Assets/Prefabs`. In the Project window, select the prefab, press
   **Ctrl+D** (**Cmd+D**) to duplicate it, and rename the copy `Boss Key`. Open it, and
   set its `Sprite` child's sprite to `BossKey` and its **Kind** to **Boss Key**.
6. For now, put a `Key` prefab on the floor of the Crypt Gate, at `(4.5, 4.6, 0)`, under a
   new empty GameObject, `Pickups`. Chapter 10 puts it in a chest.

### Do it — the door's three sprites

Cut three more sprites out of `DungeonTileset`, as before:

| Name | Position (X, Y, W, H) | Custom Pivot (pixels) |
| --- | --- | --- |
| `Door` | 608, 190, 32, 64 | (16, 0) |
| `Door Left` | 608, 190, 16, 64 | (3, 0) |
| `Door Right` | 624, 190, 16, 64 | (13, 0) |

The arched door is 26 pixels wide, in the middle of its 32: its left edge is 3 pixels in
from the left, and its right edge 3 in from the right, which is 13 pixels into `Door
Right`. Those are the hinges. The door's foot is 2 pixels below the bottom of the wall's
face: it stands on the floor.

### Do it — the door

1. Make an empty GameObject, `Door`, at `(9.5, 8.9375, 0)`: the middle of the doorway,
   2 pixels (`2 / 32 = 0.0625`) below the bottom of the wall's face. **Add Component →
   Sorting Group**, **Add Component → Box Collider 2D** with **Size** `(1, 2)` and
   **Offset** `(0, 1.0625)`, so it fills the doorway's two cells, and **Add Component →
   Animator**.
2. Drag the `Door` sprite onto it in the Hierarchy, and rename the child `Doorway`. Set
   its Sprite Renderer's **Color** to a near-black, `#0B0A0D`, and its **Order in Layer**
   to `0`.
3. Drag `Door Left` onto it: rename it `Left Leaf`, **Position** `(-0.40625, 0, 0)`,
   **Order in Layer** `1`. Then `Door Right`: `Right Leaf`, **Position**
   `(0.40625, 0, 0)`, **Order in Layer** `1`. Each hinge is 13 pixels from the middle:
   `13 / 32 = 0.40625`.

### Do it — the door's three clips

Select `Door`. Each clip animates the two leaves' **Scale X**, so each starts the same way:
**Add Property → Left Leaf → Transform → Scale**, and again for **Right Leaf**. Set every
clip to 30 samples.

| Clip | Loop Time | Scale.x of both leaves | Event |
| --- | --- | --- | --- |
| `Door Closed` | on | `1` at `0:00` and `1:00` | |
| `Door Opening` | **off** | `1` at `0:00`, `0.15` at `0:15` | `OnDoorOpened` at `0:15` |
| `Door Open` | on | `0.15` at `0:00` and `1:00` | |

`Door Closed`, the first, is made with **Create**; Unity names the new controller `Door`.
These are clips with no sprites in them at all: **property clips**, as in
C# 2.

### Do it — the door's Animator

Open `Door` in the Animator. Rename the states `Closed`, `Opening` and `Open`. Add a
**Bool** parameter, `Open`, and the three arrows, each with **Transition Duration** `0`:

| From | To | Has Exit Time | Conditions |
| --- | --- | --- | --- |
| Closed | Opening | off | `Open` true |
| Opening | Open | **on**, Exit Time `1` | none |
| Open | Closed | off | `Open` false |

### Do it — the Door script

Create `Assets/Scripts/Door.cs`, add it to `Door`, and drag the door's own Box Collider 2D
into its **Blocker** field:

```csharp
using UnityEngine;

// A locked door. Walk into it carrying a key, and it opens: the Open Bool
// starts its Opening clip, whose last frame calls OnDoorOpened, and only
// then does the doorway stop blocking the way.
public class Door : MonoBehaviour
{
    static readonly int OpenHash = Animator.StringToHash("Open");

    [SerializeField] bool needsBossKey;
    [SerializeField] Collider2D blocker;

    Animator animator;
    bool isOpen;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (isOpen || !collision.gameObject.TryGetComponent(out Inventory inventory))
        {
            return;
        }

        bool hasKey = needsBossKey ? inventory.UseBossKey() : inventory.UseKey();
        if (!hasKey)
        {
            Debug.Log(needsBossKey ? "The boss key opens this door" : "Locked: find a key");
            return;
        }

        isOpen = true;
        animator.SetBool(OpenHash, true);
    }

    // Animation Event: the Opening clip's last frame, once the door is open.
    public void OnDoorOpened()
    {
        blocker.enabled = false;
    }
}
```

`OnCollisionEnter2D` runs when something with a Rigidbody 2D bumps into the blocker. A
door that's already open, or a bump from something without an inventory, is ignored. The
`? :` picks which key to ask for, and which message to give.

### Do it — five doors

1. Drag `Door` into `Assets/Prefabs`, and rename it in the scene `Door 1`. Make an empty
   GameObject, `Doors`, and put `Door 1` under it.
2. Put four more `Door` prefabs under `Doors`, in the doorways of rooms 2 to 5, each 11
   units higher than the one before: `Door 2` at `(9.5, 19.9375)`, `Door 3` at
   `(9.5, 30.9375)`, `Door 4` at `(9.5, 41.9375)` and `Door 5` at `(9.5, 52.9375)`.
   The prefab's **Blocker** points to its own Box Collider 2D, so each copy's points to
   its own: a reference inside a prefab stays inside each copy.
3. Tick **Needs Boss Key** on `Door 5`: the Chapel's door. (Room 5's walls come in Chapter
   10; the door can wait in its doorway.)

### Idea — the Archers' Gallery's map

Room 4 fills rows 33 to 43. Two archers wait at the top corners behind shield statues;
two more statues give cover in the middle.

```
        0         10
        |         |
  43    #WWWWWWWWDWWWWWWWW#
  42    #WWtWWBWWDWWBWWtWW#
  41    #..a...........a..#
  40    #.................#
  39    #..Z...........Z..#
  38    #........s........#
  37    #.....Z.....Z.....#
  36    #.................#
  35    #.p............k..#
  34    #.................#
  33    #########d#########
```

| Mark | Is | Placed in |
| --- | --- | --- |
| `Z` | a shield statue | this chapter |
| `a` `s` | an archer, a skeleton | this chapter |
| `t` `B` | a wall torch, a banner | Chapter 14 |
| `p` `k` | a potion, a chest with a key | Chapter 10 |

### Do it — paint the Archers' Gallery

1. Paint it as the rooms before: the dark, the floor and the threshold (column 9, row 33),
   the wall's face on rows 43 and 42 with the doorway.
2. Make a `Shield Statue` prefab from the sprite you cut in Chapter 6, set up as the
   `Statue` prefab is. Put four under `Statues and Banners`, at `(3.5, 39.15)`,
   `(15.5, 39.15)`, `(6.5, 37.15)` and `(12.5, 37.15)`.
3. Under `Enemies`: archers at `(3.5, 41.15)` and `(15.5, 41.15)`, and a skeleton at
   `(9.5, 38.15)`. Set their **Hero**, and the archers' **Arrow Group**.

### Test it

Press **Play** in the Crypt Gate.

- Walk into the door: it doesn't open, and the Console says `Locked: find a key`.
- Walk over the key: it's gone, and the Console says `Keys: 1, boss key: False`.
- Walk into the door again: the leaves fold back to their hinges over half a second, the
  Console says `Keys: 0, boss key: False`, and once they're back, walk up through the
  doorway, into the dark of the threshold. (The camera stays in room 1 until Chapter 12:
  watch the Scene view.)
- Select `Door 1` while it opens, with the Animator window open: Closed, Opening, Open.

### Challenge

Set `Door Opening`'s last **Scale.x** to `0` and open the door: the leaves vanish
completely. A door seen from the front is never thinner than its edge: put it back to
`0.15`. Then move `OnDoorOpened` to `0:00`: what can the hero do now that he couldn't?

## Chapter 10 — Chests and Potions

**Goal:** a chest in every room but the last. **E**, or a tap, opens the one in front of
the hero; on the frame its lid comes up, its loot appears in front of it: a key, and in
the Chapel the boss key. Potions, up to three, and **Q** drinks one, for a whole heart
back. Gold. The Chapel, the fifth room, painted, with its red carpet.

### Idea — the loot frame

A chest's Animator is the door's, nearly: Closed, Opening, Open. But a chest opens once
and only once, so its parameter is a **Trigger**, `Open`, not a Bool.

| Clip | Frames | Event |
| --- | --- | --- |
| `Chest Closed` | `Chest_0` | |
| `Chest Opening` | `Chest_0`, `Chest_1`, `Chest_2`, at 8 samples | `OnLootReady` at `0:2`, as the lid comes up |
| `Chest Open` | `Chest_2` | |

The loot is ordinary pickups, put in front of the chest and switched off. `OnLootReady`
switches them on: a key appears just as the lid lifts, at the hero's feet, and he picks it
up.

### Idea — opening what's in front of his feet

`TryOpenChest` looks for a chest in a circle 0.6 units in front of the hero's **feet**,
not his middle: a chest's collider is at its foot, as his is. A tap opens a chest too, if
there's one in front of him; otherwise it swings the sword, as before.

### Idea — potions and gold

`Pickup` gets two more kinds. Gold just counts. A potion goes into the inventory, if there
are fewer than three there: `AddPotion` returns `false` when his three slots are full, and
the pickup `return`s before it vanishes, so the potion waits on the floor for later. **Q**
drinks one, but only if he has a heart to lose: drinking at full health would waste it.

### Do it — HeroHealth heals

Replace `HeroHealth` with this version:

```csharp
using System.Collections;
using UnityEngine;

// The hero's health, counted in half hearts: 6 is three whole hearts. A hit
// knocks him back and makes him blink, and nothing can hurt him while he
// blinks. At 0 he falls.
public class HeroHealth : MonoBehaviour
{
    public const int MaxHealth = 6;

    static readonly int HurtHash = Animator.StringToHash("Hurt");
    static readonly int DeadHash = Animator.StringToHash("Dead");

    [SerializeField] float knockbackSpeed = 6f;
    [SerializeField] float stunSeconds = 0.2f;      // no control, while the knockback carries him
    [SerializeField] float blinkSeconds = 1f;

    Rigidbody2D body;
    Animator animator;
    SpriteRenderer spriteRenderer;
    bool isBlinking;
    float stunnedUntil;

    public int Health { get; private set; } = MaxHealth;
    public bool IsDead { get; private set; }

    public bool IsStunned
    {
        get { return Time.time < stunnedUntil; }
    }

    public bool IsFull
    {
        get { return Health == MaxHealth; }
    }

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Something hurt him. from is where it was, so he's knocked away from it.
    public void TakeDamage(int amount, Vector2 from)
    {
        // Nothing hurts him while he blinks, or once he has fallen.
        if (IsDead || isBlinking)
        {
            return;
        }

        Health = Mathf.Max(Health - amount, 0);
        Debug.Log($"Health: {Health}");

        if (Health == 0)
        {
            IsDead = true;
            body.linearVelocity = Vector2.zero;
            animator.SetTrigger(DeadHash);
            return;
        }

        Vector2 away = (body.position - from).normalized;
        body.linearVelocity = away * knockbackSpeed;
        stunnedUntil = Time.time + stunSeconds;
        animator.SetTrigger(HurtHash);
        StartCoroutine(Blink());
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

    // Animation Event: at the end of the Dead clips.
    public void OnDeathFinished()
    {
        Debug.Log("The hero has fallen");
    }
}
```

`Mathf.Min(Health + amount, MaxHealth)` heals, but never past 6. `IsFull` lets the
inventory ask before it pours a potion away.

### Do it — Inventory: potions and gold

Replace `Inventory` with this version, and drag `Hero` into its **Health** field:

```csharp
using UnityEngine;

// What the hero carries: keys, the boss key, up to three potions, and gold.
// For now, the Console shows what he carries.
public class Inventory : MonoBehaviour
{
    public const int MaxPotions = 3;

    [SerializeField] HeroHealth health;
    [SerializeField] int potionHealing = 2;     // a whole heart

    int keys;
    bool hasBossKey;
    int potions;

    public int Gold { get; private set; }

    public void AddKey()
    {
        keys++;
        UpdateScreen();
    }

    public void AddBossKey()
    {
        hasBossKey = true;
        UpdateScreen();
    }

    // False when he already carries three: the potion stays where it is.
    public bool AddPotion()
    {
        if (potions >= MaxPotions)
        {
            return false;
        }
        potions++;
        UpdateScreen();
        return true;
    }

    public void AddGold(int amount)
    {
        Gold += amount;
        UpdateScreen();
    }

    // A door asks for a key: true if there was one to use.
    public bool UseKey()
    {
        if (keys == 0)
        {
            return false;
        }
        keys--;
        UpdateScreen();
        return true;
    }

    public bool UseBossKey()
    {
        if (!hasBossKey)
        {
            return false;
        }
        hasBossKey = false;
        UpdateScreen();
        return true;
    }

    // Q. A whole heart back, if there's a potion and he has a heart to lose.
    public void DrinkPotion()
    {
        if (potions == 0 || health.IsDead || health.IsFull)
        {
            return;
        }
        potions--;
        health.Heal(potionHealing);
        UpdateScreen();
    }

    void UpdateScreen()
    {
        Debug.Log($"Keys: {keys}, boss key: {hasBossKey}, potions: {potions}, gold: {Gold}");
    }
}
```

`Gold` is a property with a `private set`, like `Health`: other scripts can read it, and
Chapter 12's win screen will.

### Do it — Pickup: four kinds

Replace `Pickup` with this version:

```csharp
using UnityEngine;

// A key, the boss key, a potion or a pile of gold: one script for all four.
// Its Kind says which, and a switch does the rest.
public class Pickup : MonoBehaviour
{
    public enum Kind { Key, BossKey, Potion, Gold }

    [SerializeField] Kind kind;
    [SerializeField] int gold = 25;             // for Gold only

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.TryGetComponent(out Inventory inventory))
        {
            return;
        }

        switch (kind)
        {
            case Kind.Key:
                inventory.AddKey();
                break;
            case Kind.BossKey:
                inventory.AddBossKey();
                break;
            case Kind.Potion:
                if (!inventory.AddPotion())
                {
                    return;     // he carries three already: it waits for later
                }
                break;
            case Kind.Gold:
                inventory.AddGold(gold);
                break;
        }
        gameObject.SetActive(false);
    }
}
```

A new value at the end of an `enum` is safe: the keys you made are still `Key` and
`BossKey`, which are still 0 and 1.

### Do it — potions and gold

1. Set `Potion` and `Gold` in `Assets/Art/Props` as **Multiple**, `32` Pixels Per Unit,
   **Point (no filter)**, Compression **None**, and slice each **Grid By Cell Size**
   `16` × `16`, **Pivot** **Center**: ten frames of bubbling potion, eight of glinting gold.
2. Drag `Potion_0` into the Hierarchy and rename it `Potion`: **Sprite Sort Point**
   **Pivot**, a **Circle Collider 2D** with **Is Trigger** and **Radius** `0.3`, and a
   `Pickup` with **Kind** **Potion**. **Create** its clip, `Potion Idle`: all ten frames,
   10 samples, looping. Drag it into `Assets/Prefabs`.
3. The same for `Gold`: its clip `Gold Idle` has its eight frames at 10 samples, and its
   `Pickup` has **Kind** **Gold** and **Gold** `25`.

### Do it — the chest

1. Set `Chest` in `Assets/Art/Props` as **Multiple**, **Pixels Per Unit** `16`, **Point
   (no filter)**, Compression **None**, and slice it **Grid By Cell Size** `16` × `16`,
   with a **Custom** pivot in **Pixels** at `(8, 0)`: its foot. At 16 pixels a unit, the
   chest is one tile wide.
2. Drag `Chest_0` into the Hierarchy and rename it `Chest`: **Sprite Sort Point**
   **Pivot**, and a **Box Collider 2D** with **Size** `(0.85, 0.45)` and **Offset**
   `(0, 0.225)`.
3. **Create** its three clips at 8 samples, as in the table above, with **Loop Time** off
   for `Chest Opening`, and the event on it. In the `Chest` controller Unity makes, rename
   the states `Closed`, `Opening` and `Open`, add a **Trigger**, `Open`, and two arrows,
   each with **Transition Duration** `0`: Closed → Opening on `Open`, with no exit time,
   and Opening → Open, with **Has Exit Time** on, Exit Time `1`.

Create `Assets/Scripts/Chest.cs`, and add it to `Chest`:

```csharp
using UnityEngine;

// A chest. Open sets the Open trigger; the Opening clip's lid-up frame calls
// OnLootReady, and the loot waiting in front of the chest appears just then.
public class Chest : MonoBehaviour
{
    static readonly int OpenHash = Animator.StringToHash("Open");

    [SerializeField] GameObject[] loot;     // hidden pickups, placed in front of the chest

    Animator animator;

    public bool IsOpen { get; private set; }

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void Open()
    {
        if (IsOpen)
        {
            return;
        }
        IsOpen = true;
        animator.SetTrigger(OpenHash);
    }

    // Animation Event: the Opening clip's last frame, as the lid comes up.
    public void OnLootReady()
    {
        foreach (GameObject item in loot)
        {
            item.SetActive(true);
        }
    }
}
```

Drag `Chest` into `Assets/Prefabs`, and delete it from the scene.

### Do it — the hero opens chests and drinks

Replace `Hero` with this version:

```csharp
using UnityEngine;
using UnityEngine.InputSystem;

// The hero: walks with the keyboard, or towards a pointer that's held down,
// and faces one of four ways. Every frame he tells the Animator his Direction
// and his Speed. A quick tap swings the sword, or opens the chest in front.
[RequireComponent(typeof(Rigidbody2D))]
public class Hero : MonoBehaviour
{
    static readonly int DirectionHash = Animator.StringToHash("Direction");
    static readonly int SpeedHash = Animator.StringToHash("Speed");

    [SerializeField] float walkSpeed = 4f;
    [SerializeField] float holdSeconds = 0.25f;     // a press longer than this walks; a shorter one is a tap
    [SerializeField] float reach = 0.6f;            // how far in front of his feet a chest can be opened

    Rigidbody2D body;
    Animator animator;
    HeroCombat combat;
    HeroHealth health;
    Inventory inventory;
    Camera mainCamera;
    Facing facing = Facing.Up;
    float pressStart = -1f;     // when the pointer went down, or -1 when it isn't down

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        combat = GetComponent<HeroCombat>();
        health = GetComponent<HeroHealth>();
        inventory = GetComponent<Inventory>();
        mainCamera = Camera.main;
    }

    void Update()
    {
        Vector2 move = Vector2.zero;
        if (HasControl() && !combat.IsAttacking)
        {
            move = ReadKeyboard() + ReadPointer();
        }
        else if (!HasControl())
        {
            pressStart = -1f;
        }

        if (move.sqrMagnitude > 0.01f)
        {
            facing = Facings.FromVector(move, facing);
        }

        // While he's stunned, the knockback carries him instead. A velocity
        // is safe to set in Update: the Rigidbody keeps it until the next
        // physics step uses it.
        if (!health.IsStunned)
        {
            body.linearVelocity = Vector2.ClampMagnitude(move, 1f) * walkSpeed;
        }

        animator.SetInteger(DirectionHash, (int)facing);
        animator.SetFloat(SpeedHash, body.linearVelocity.magnitude);
    }

    bool HasControl()
    {
        return !health.IsDead && !health.IsStunned;
    }

    // W A S D or the arrows walk; Space or J attacks; E opens; Q drinks.
    // A phone may have no keyboard, and then Keyboard.current is null.
    Vector2 ReadKeyboard()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard == null)
        {
            return Vector2.zero;
        }

        Vector2 move = Vector2.zero;
        if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed)
        {
            move.x -= 1f;
        }
        if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed)
        {
            move.x += 1f;
        }
        if (keyboard.sKey.isPressed || keyboard.downArrowKey.isPressed)
        {
            move.y -= 1f;
        }
        if (keyboard.wKey.isPressed || keyboard.upArrowKey.isPressed)
        {
            move.y += 1f;
        }

        if (keyboard.spaceKey.wasPressedThisFrame || keyboard.jKey.wasPressedThisFrame)
        {
            combat.Attack(Facings.ToVector(facing));
        }
        if (keyboard.eKey.wasPressedThisFrame)
        {
            TryOpenChest();
        }
        if (keyboard.qKey.wasPressedThisFrame)
        {
            inventory.DrinkPotion();
        }
        return move.normalized;
    }

    // The mouse, or a finger: held down longer than holdSeconds, he walks
    // towards it; a quicker tap is handled by Tap.
    Vector2 ReadPointer()
    {
        Pointer pointer = Pointer.current;
        if (pointer == null)
        {
            return Vector2.zero;
        }

        if (pointer.press.wasPressedThisFrame)
        {
            pressStart = Time.time;
        }
        if (pressStart < 0f)
        {
            return Vector2.zero;
        }

        Vector2 target = mainCamera.ScreenToWorldPoint(pointer.position.ReadValue());
        if (pointer.press.wasReleasedThisFrame || !pointer.press.isPressed)
        {
            if (Time.time - pressStart <= holdSeconds)
            {
                Tap(target);
            }
            pressStart = -1f;
            return Vector2.zero;
        }

        Vector2 toTarget = target - body.position;
        if (Time.time - pressStart <= holdSeconds || toTarget.magnitude < 0.2f)
        {
            return Vector2.zero;
        }
        return toTarget.normalized;
    }

    // A tap opens the chest in front of him, or swings the sword the way of the tap.
    void Tap(Vector2 target)
    {
        if (TryOpenChest())
        {
            return;
        }
        facing = Facings.FromVector(target - body.position, facing);
        animator.SetInteger(DirectionHash, (int)facing);
        combat.Attack(Facings.ToVector(facing));
    }

    // A chest's collider is at its foot, as his is, so this circle is
    // measured from his feet.
    bool TryOpenChest()
    {
        Vector2 front = body.position + Facings.ToVector(facing) * reach;
        Collider2D[] hits = Physics2D.OverlapCircleAll(front, 0.45f);
        foreach (Collider2D hit in hits)
        {
            if (hit.TryGetComponent(out Chest chest) && !chest.IsOpen)
            {
                chest.Open();
                return true;
            }
        }
        return false;
    }
}
```

**E** calls `TryOpenChest`; **Q** calls `inventory.DrinkPotion()`. `TryOpenChest` returns
`true` if it opened one, so `Tap` knows not to swing as well.

### Do it — five chests and their loot

Make an empty GameObject, `Chests`, and put five `Chest` prefabs under it. Each one's loot
is pickups under `Pickups`, in front of it, **switched off**: untick the box at the top of
each one's Inspector. Then drag them into its chest's **Loot** list.

| Chest | At | Its loot, switched off |
| --- | --- | --- |
| `Chest 1` | `(4.5, 5.15)` | the key from Chapter 9, at `(4.5, 4.6)` |
| `Chest 2` | `(16.5, 14.15)` | a key at `(16.5, 13.6)` |
| `Chest 3` | `(2.5, 25.15)` | a potion at `(2.15, 24.6)` and a key at `(2.85, 24.6)` |
| `Chest 4` | `(15.5, 35.15)` | a key at `(15.5, 34.6)` |
| `Chest 5` | `(13.5, 51.15)` | the boss key at `(13.5, 50.6)` |

Name each piece of loot after its chest, such as `Key (Room 1 Chest)`, so the Hierarchy
says where it belongs. Then put the loose pickups under `Pickups`, switched on: gold at
`(14.5, 4.5)`, `(3.5, 13.5)` and `(3.5, 49.5)`, and potions at `(2.5, 35.5)` and
`(15.5, 49.5)`.

### Idea — the Chapel's map

Room 5 fills rows 44 to 54. A red carpet, three tiles wide, runs from the threshold to the
door of the King's Tomb.

```
        0         10
        |         |
  54    #WWWWWWWWDWWWWWWWW#
  53    #WWBWWtWWDWWtWWBWW#
  52    #.......RRR.......#
  51    #..T....RRR..b.T..#
  50    #.......RRR.......#
  49    #..g....RRR....p..#
  48    #.......RRR.......#
  47    #.......RRR.......#
  46    #.......RRR.......#
  45    #.......RRR.......#
  44    #########d#########
```

### Idea — a carpet in nine tiles

The carpet is drawn as nine tiles in the sheet, a 3 × 3 block at columns 7 to 9, rows 5
to 7: four corners, four edges and a middle. A carpet of any size uses the corners at its
corners, the edges along its sides, and the middle everywhere else. Ours is three wide,
so its middle column is the top, middle and bottom of the block's middle column:

| Carpet row | Column 8 | Column 9 | Column 10 |
| --- | --- | --- | --- |
| 52, the top | `_78` | `_79` | `_80` |
| 46 to 51 | `_94` | `_95` | `_96` |
| 45, the bottom | `_103` | `_104` | `_105` |

### Do it — paint the Chapel

1. Paint the dark, the floor (all of it, under the carpet too), the threshold (column 9,
   row 44) and the wall's face on rows 54 and 53, with the doorway.
2. Set the Tile Palette to **Decoration**, and paint the carpet from the table.
3. Two standing torches under `Torches`, at `(3.5, 51.15)` and `(15.5, 51.15)`.

### Test it

Press **Play** in the Crypt Gate.

- Walk up to the chest and press **E**, facing it: the lid lifts, the key appears at your
  feet, and you've picked it up: the Console says `Keys: 1`. Try it from the side, and
  from above: E opens it from any side you face it from.
- A chest opens once: **E** again does nothing.
- Walk over the gold: `gold: 25`.
- Move the hero and camera to the Archers' Gallery, let an arrow hit you, and press **Q**:
  nothing, you have no potion. Walk over the potion, press **Q**: a heart back, and
  `Health` goes up by 2. At full health, **Q** keeps the potion.

### Challenge

Make a **mimic**: a chest that bites. Slice `Assets/Art/Props/Mimic` exactly as the chest,
and make an **Animator Override Controller** for `Chest`, `Mimic Override`, with clips made
from the mimic's three frames. Duplicate the `Chest` prefab as `Mimic`, give it `Mimic
Override`, leave its **Loot** empty, and add a script of your own, `Mimic`, with a
`[SerializeField] HeroHealth hero;` and a method `public void OnLootReady()` that calls
`hero.TakeDamage(2, transform.position)` if the hero is within 1.5 units. Both scripts on
the mimic have an `OnLootReady`: the Animation Event calls them both. Put one in the
Chapel, beside the real chest. Which one do you open first?

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

## Chapter 11 — The Screen

**Goal:** the hero's three hearts on the screen, whole, half or empty; the keys he carries,
the boss key once he has it, and his gold, counted; and three potion slots at the bottom,
each a button: a tap on one drinks a potion. In the RPG UI's pixel font, with a dark
outline, so it reads in the dark of the crypt.

### Idea — what goes where

```
 ┌──────────────────────────────────────────────────────────────────────┐
 │ ♥ ♥ ♡   (key) x 2   (boss key)   (gold) 50                      [II] │
 │                                                                      │
 │                                                                      │
 │                                                                      │
 │ [potion][potion][  ]                                                 │
 └──────────────────────────────────────────────────────────────────────┘
```

| Thing | Shows | Chapter |
| --- | --- | --- |
| hearts | three hearts: full, half or empty | this one |
| keys, boss key, gold | the key and `x 2`; the boss key, only once he has it; a pile of gold and `50` | this one |
| potion slots | three slots, a potion in each one he carries; tap to drink | this one |
| room name, message, pause button | | Chapter 12 |
| the boss bar | | Chapter 13 |

Pixel art on a canvas looks right at a whole number of screen pixels for each art pixel.
The canvas is 1920 × 1080, so the icons are four times their size: a 16-pixel key is 64
across, a 13 × 12 heart 52 × 48. The slots are 48 pixels, at twice their size, 96.

### Idea — a heart, from / and %

Health counts half hearts, so with 6 health in three hearts:

| Health | `health / 2` (whole hearts) | `health % 2` (a half after them?) | Hearts |
| --- | --- | --- | --- |
| 6 | 3 | 0 | ♥ ♥ ♥ |
| 5 | 2 | 1 | ♥ ♥ ½ |
| 4 | 2 | 0 | ♥ ♥ ♡ |
| 1 | 0 | 1 | ½ ♡ ♡ |

`/` on two `int`s divides and drops the fraction: `5 / 2` is `2`. `%` gives what's left
over: `5 % 2` is `1`. So heart number `i` (counting from 0) is full if `i < health / 2`;
half if it's the next one, `i == health / 2`, and `health % 2 == 1`; and empty otherwise.

### Do it — the pictures, and the font

1. Select `HeartFull`, `HeartHalf`, `HeartEmpty` and `Slot` in `Assets/Art/UI`, and set them
   as **Single**, **Pixels Per Unit** `100` (the Canvas's own), **Point (no filter)**,
   Compression **None**. **Apply**.
2. Open `Slot` in the Sprite Editor, and set its **Border** to `7` on all four sides
   (**L**, **T**, **R**, **B**): its corners, for Chapter 12. **Apply**.
3. Select `PixelRpgFont` in `Assets/Art/Fonts`, then **Assets → Create → TextMeshPro →
   Font Asset → SDF**. Unity asks to import **TMP Essentials** the first time: click
   **Import TMP Essentials**, close the window, and do this step again. Open the new
   `PixelRpgFont SDF`'s arrow, select `PixelRpgFont Atlas Material`, and under
   **Outline** set **Color** to `#120E12` and **Thickness** to `0.2`.

### Do it — the Canvas

1. **GameObject → UI (Canvas) → Canvas**. Unity makes a **Canvas** and an
   **EventSystem**.
2. In the Canvas's **Canvas Scaler**, set **UI Scale Mode** to **Scale With Screen Size**,
   **Reference Resolution** to `1920 × 1080`, and **Match** to `0.5`.

> **Watch out:** the **GameObject** menu always puts new UI straight onto the Canvas.
> To put a UI element **inside** another, right-click the parent in the Hierarchy and
> choose **UI (Canvas) → …** there.

### Do it — the hearts, the keys and the gold

Make these, each from the menu its **Parent** says. Anchor each with **Shift + Alt**
(**Shift + Option** on a Mac), so its pivot moves to the same place, and untick **Raycast
Target** on every one: they're only there to be seen, so a press on them goes through to
the game.

| Object | Type | Parent | Anchor | Pos | Size |
| --- | --- | --- | --- | --- | --- |
| `Hearts` | Create Empty | Canvas | top-left | (40, −40) | 180 × 48 |
| `Heart 1` | Image | Hearts | middle-left | (0, 0) | 52 × 48 |
| `Heart 2` | Image | Hearts | middle-left | (62, 0) | 52 × 48 |
| `Heart 3` | Image | Hearts | middle-left | (124, 0) | 52 × 48 |
| `Key Icon` | Image | Canvas | top-left | (250, −32) | 64 × 64 |
| `Key Text` | Text - TextMeshPro | Canvas | top-left | (320, −40) | 110 × 56 |
| `Boss Key Icon` | Image | Canvas | top-left | (440, −32) | 64 × 64 |
| `Gold Icon` | Image | Canvas | top-left | (540, −32) | 64 × 64 |
| `Gold Text` | Text - TextMeshPro | Canvas | top-left | (610, −40) | 160 × 56 |

The three hearts show `HeartFull`; the icons `Key`, `BossKey` and `Gold_0`. Untick the
`Boss Key Icon`'s **Image** component (the box beside its name, not the GameObject's):
it shows only once he has the boss key. The two texts say `x 0` and `0`, in `PixelRpgFont
SDF`, **Font Size** `44`, colour `#F2E8D5` (old parchment), aligned **left** and
**middle**.

### Do it — the potion slots

| Object | Type | Parent | Anchor | Pos | Size |
| --- | --- | --- | --- | --- | --- |
| `Potion Slot 1` | Image | Canvas | bottom-left | (30, 30) | 96 × 96 |
| `Potion Slot 2` | Image | Canvas | bottom-left | (140, 30) | 96 × 96 |
| `Potion Slot 3` | Image | Canvas | bottom-left | (250, 30) | 96 × 96 |
| `Potion` | Image, in each slot | its slot | middle-center | (0, 0) | 64 × 64 |

Each slot shows `Slot`, and keeps **Raycast Target** ticked: a slot takes presses. **Add
Component → Button** to each, and drag the slot itself into its **Target Graphic**. Each
`Potion` shows `Potion_0`, with **Raycast Target** unticked, and its **Image** component
unticked: a slot is empty until he carries a potion.

### Do it — the code

Create `Assets/Scripts/HeartsBar.cs`, and add it to `Hearts`. Drag the three hearts into
its **Hearts** list, and the three heart sprites into **Full Heart**, **Half Heart** and
**Empty Heart**:

```csharp:HeartsBar.cs
using UnityEngine;
using UnityEngine.UI;

// The hero's three hearts. His health is counted in half hearts, so
// health / 2 is how many hearts are full, and health % 2, what's left over,
// is 1 when a half heart comes after them.
public class HeartsBar : MonoBehaviour
{
    [SerializeField] Image[] hearts;
    [SerializeField] Sprite fullHeart;
    [SerializeField] Sprite halfHeart;
    [SerializeField] Sprite emptyHeart;

    public void SetHealth(int health)
    {
        int full = health / 2;
        bool hasHalf = health % 2 == 1;
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < full)
            {
                hearts[i].sprite = fullHeart;
            }
            else if (i == full && hasHalf)
            {
                hearts[i].sprite = halfHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
        }
    }
}
```

Replace `HeroHealth`, and drag `Hearts` into its new **Hearts** field:

```csharp
using System.Collections;
using UnityEngine;

// The hero's health, counted in half hearts: 6 is three whole hearts. A hit
// knocks him back and makes him blink, and nothing can hurt him while he
// blinks. At 0 he falls.
public class HeroHealth : MonoBehaviour
{
    public const int MaxHealth = 6;

    static readonly int HurtHash = Animator.StringToHash("Hurt");
    static readonly int DeadHash = Animator.StringToHash("Dead");

    [SerializeField] HeartsBar hearts;
    [SerializeField] float knockbackSpeed = 6f;
    [SerializeField] float stunSeconds = 0.2f;      // no control, while the knockback carries him
    [SerializeField] float blinkSeconds = 1f;

    Rigidbody2D body;
    Animator animator;
    SpriteRenderer spriteRenderer;
    bool isBlinking;
    float stunnedUntil;

    public int Health { get; private set; } = MaxHealth;
    public bool IsDead { get; private set; }

    public bool IsStunned
    {
        get { return Time.time < stunnedUntil; }
    }

    public bool IsFull
    {
        get { return Health == MaxHealth; }
    }

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        hearts.SetHealth(Health);
    }

    // Something hurt him. from is where it was, so he's knocked away from it.
    public void TakeDamage(int amount, Vector2 from)
    {
        // Nothing hurts him while he blinks, or once he has fallen.
        if (IsDead || isBlinking)
        {
            return;
        }

        Health = Mathf.Max(Health - amount, 0);
        hearts.SetHealth(Health);

        if (Health == 0)
        {
            IsDead = true;
            body.linearVelocity = Vector2.zero;
            animator.SetTrigger(DeadHash);
            return;
        }

        Vector2 away = (body.position - from).normalized;
        body.linearVelocity = away * knockbackSpeed;
        stunnedUntil = Time.time + stunSeconds;
        animator.SetTrigger(HurtHash);
        StartCoroutine(Blink());
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
        hearts.SetHealth(Health);
    }

    // Animation Event: at the end of the Dead clips.
    public void OnDeathFinished()
    {
        Debug.Log("The hero has fallen");
    }
}
```

Every change to `Health` now tells the hearts, and `Start` shows them the first time.

Replace `Inventory`, and fill its new fields: **Key Text**, **Boss Key Icon**, **Gold Text**,
the three `Potion` images into **Potion Icons**, and the three slots into **Potion
Buttons**:

```csharp
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// What the hero carries: keys, the boss key, up to three potions, and gold.
// It keeps the screen's key count, potion slots and gold up to date.
public class Inventory : MonoBehaviour
{
    public const int MaxPotions = 3;

    [SerializeField] HeroHealth health;
    [SerializeField] TMP_Text keyText;
    [SerializeField] Image bossKeyIcon;
    [SerializeField] TMP_Text goldText;
    [SerializeField] Image[] potionIcons;       // the three slots' potions
    [SerializeField] Button[] potionButtons;    // tap a slot to drink
    [SerializeField] int potionHealing = 2;     // a whole heart

    int keys;
    bool hasBossKey;
    int potions;

    public int Gold { get; private set; }

    void OnEnable()
    {
        foreach (Button button in potionButtons)
        {
            button.onClick.AddListener(DrinkPotion);
        }
    }

    void OnDisable()
    {
        foreach (Button button in potionButtons)
        {
            button.onClick.RemoveListener(DrinkPotion);
        }
    }

    void Start()
    {
        UpdateScreen();
    }

    public void AddKey()
    {
        keys++;
        UpdateScreen();
    }

    public void AddBossKey()
    {
        hasBossKey = true;
        UpdateScreen();
    }

    // False when he already carries three: the potion stays where it is.
    public bool AddPotion()
    {
        if (potions >= MaxPotions)
        {
            return false;
        }
        potions++;
        UpdateScreen();
        return true;
    }

    public void AddGold(int amount)
    {
        Gold += amount;
        UpdateScreen();
    }

    // A door asks for a key: true if there was one to use.
    public bool UseKey()
    {
        if (keys == 0)
        {
            return false;
        }
        keys--;
        UpdateScreen();
        return true;
    }

    public bool UseBossKey()
    {
        if (!hasBossKey)
        {
            return false;
        }
        hasBossKey = false;
        UpdateScreen();
        return true;
    }

    // Q, or a tap on a potion slot. A whole heart back, if there's a potion
    // and he has a heart to lose.
    public void DrinkPotion()
    {
        if (potions == 0 || health.IsDead || health.IsFull)
        {
            return;
        }
        potions--;
        health.Heal(potionHealing);
        UpdateScreen();
    }

    void UpdateScreen()
    {
        keyText.text = $"x {keys}";
        bossKeyIcon.enabled = hasBossKey;
        goldText.text = Gold.ToString();
        for (int i = 0; i < potionIcons.Length; i++)
        {
            potionIcons[i].enabled = i < potions;
        }
    }
}
```

Read it before you move on:

- `OnEnable` connects each slot's button to `DrinkPotion`, and `OnDisable` disconnects it,
  as in C# 8.
- `UpdateScreen` sets everything at once: the key count, the boss key, the gold, and each
  slot's potion, shown if `i < potions`.

Replace `Hero`:

```csharp
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

// The hero: walks with the keyboard, or towards a pointer that's held down,
// and faces one of four ways. Every frame he tells the Animator his Direction
// and his Speed. A quick tap swings the sword, or opens the chest in front.
[RequireComponent(typeof(Rigidbody2D))]
public class Hero : MonoBehaviour
{
    static readonly int DirectionHash = Animator.StringToHash("Direction");
    static readonly int SpeedHash = Animator.StringToHash("Speed");

    [SerializeField] float walkSpeed = 4f;
    [SerializeField] float holdSeconds = 0.25f;     // a press longer than this walks; a shorter one is a tap
    [SerializeField] float reach = 0.6f;            // how far in front of his feet a chest can be opened

    Rigidbody2D body;
    Animator animator;
    HeroCombat combat;
    HeroHealth health;
    Inventory inventory;
    Camera mainCamera;
    Facing facing = Facing.Up;
    float pressStart = -1f;     // when the pointer went down, or -1 when it isn't down
    bool isPressOnUi;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        combat = GetComponent<HeroCombat>();
        health = GetComponent<HeroHealth>();
        inventory = GetComponent<Inventory>();
        mainCamera = Camera.main;
    }

    void Update()
    {
        Vector2 move = Vector2.zero;
        if (HasControl() && !combat.IsAttacking)
        {
            move = ReadKeyboard() + ReadPointer();
        }
        else if (!HasControl())
        {
            pressStart = -1f;
        }

        if (move.sqrMagnitude > 0.01f)
        {
            facing = Facings.FromVector(move, facing);
        }

        // While he's stunned, the knockback carries him instead. A velocity
        // is safe to set in Update: the Rigidbody keeps it until the next
        // physics step uses it.
        if (!health.IsStunned)
        {
            body.linearVelocity = Vector2.ClampMagnitude(move, 1f) * walkSpeed;
        }

        animator.SetInteger(DirectionHash, (int)facing);
        animator.SetFloat(SpeedHash, body.linearVelocity.magnitude);
    }

    bool HasControl()
    {
        return !health.IsDead && !health.IsStunned;
    }

    // W A S D or the arrows walk; Space or J attacks; E opens; Q drinks.
    // A phone may have no keyboard, and then Keyboard.current is null.
    Vector2 ReadKeyboard()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard == null)
        {
            return Vector2.zero;
        }

        Vector2 move = Vector2.zero;
        if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed)
        {
            move.x -= 1f;
        }
        if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed)
        {
            move.x += 1f;
        }
        if (keyboard.sKey.isPressed || keyboard.downArrowKey.isPressed)
        {
            move.y -= 1f;
        }
        if (keyboard.wKey.isPressed || keyboard.upArrowKey.isPressed)
        {
            move.y += 1f;
        }

        if (keyboard.spaceKey.wasPressedThisFrame || keyboard.jKey.wasPressedThisFrame)
        {
            combat.Attack(Facings.ToVector(facing));
        }
        if (keyboard.eKey.wasPressedThisFrame)
        {
            TryOpenChest();
        }
        if (keyboard.qKey.wasPressedThisFrame)
        {
            inventory.DrinkPotion();
        }
        return move.normalized;
    }

    // The mouse, or a finger: held down longer than holdSeconds, he walks
    // towards it; a quicker tap is handled by Tap. A press that lands on the
    // UI, such as a potion slot, belongs to the UI.
    Vector2 ReadPointer()
    {
        Pointer pointer = Pointer.current;
        if (pointer == null)
        {
            return Vector2.zero;
        }

        if (pointer.press.wasPressedThisFrame)
        {
            pressStart = Time.time;
            isPressOnUi = false;
        }
        if (pressStart < 0f)
        {
            return Vector2.zero;
        }

        // The UI only knows a finger is on a button a frame after it lands,
        // so ask on every frame of the press.
        if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
        {
            isPressOnUi = true;
        }

        Vector2 target = mainCamera.ScreenToWorldPoint(pointer.position.ReadValue());
        if (pointer.press.wasReleasedThisFrame || !pointer.press.isPressed)
        {
            if (!isPressOnUi && Time.time - pressStart <= holdSeconds)
            {
                Tap(target);
            }
            pressStart = -1f;
            return Vector2.zero;
        }

        Vector2 toTarget = target - body.position;
        if (isPressOnUi || Time.time - pressStart <= holdSeconds || toTarget.magnitude < 0.2f)
        {
            return Vector2.zero;
        }
        return toTarget.normalized;
    }

    // A tap opens the chest in front of him, or swings the sword the way of the tap.
    void Tap(Vector2 target)
    {
        if (TryOpenChest())
        {
            return;
        }
        facing = Facings.FromVector(target - body.position, facing);
        animator.SetInteger(DirectionHash, (int)facing);
        combat.Attack(Facings.ToVector(facing));
    }

    // A chest's collider is at its foot, as his is, so this circle is
    // measured from his feet.
    bool TryOpenChest()
    {
        Vector2 front = body.position + Facings.ToVector(facing) * reach;
        Collider2D[] hits = Physics2D.OverlapCircleAll(front, 0.45f);
        foreach (Collider2D hit in hits)
        {
            if (hit.TryGetComponent(out Chest chest) && !chest.IsOpen)
            {
                chest.Open();
                return true;
            }
        }
        return false;
    }
}
```

A tap on a potion slot must drink, not swing the sword as well. `EventSystem.current.
IsPointerOverGameObject()` says whether the pointer is over the UI: over something with
**Raycast Target** ticked. A finger landing on a button is only seen by the UI a frame
later, so `ReadPointer` asks on every frame of the press, and remembers in `isPressOnUi`.

### Test it

Press **Play** in the Crypt Gate.

- Three full hearts, `x 0`, `0`, and three empty slots.
- Open the chest: `x 1`. Take the gold: `25`. Open the door: `x 0`.
- In the Ossuary (move the hero and the camera there), let a skeleton hit you: the third
  heart goes half. Again: empty. Open the chest: a potion appears in the first slot. Tap
  it: the slot empties, a heart comes back, and he doesn't swing.
- The hearts and icons don't block presses: tap just on a heart, and he swings.

### Challenge

Make the hearts **blink** when he's hurt: in `HeroHealth`'s `Blink`, the hearts could flash
too. Or show the potion count as a number in the first slot, and hide the other two: which
is easier to read in a fight?

## Chapter 12 — Rooms, Pause and Restart

**Goal:** the camera shows one room at a time, and slides up to the next as the hero goes
through a door, while the room's name fades in. The game gets its own state machine: a
Start panel with **Play**, a pause menu, a lose panel with **Try Again**, and a win panel
for Chapter 13. And **Restart** puts the whole crypt back as it was: every enemy, door,
chest and pickup, and the hero, from code.

### Idea — which room is he in?

The rooms are stacked 11 rows apart, room 1 at the bottom. So the hero's room is his
height divided by 11, rounded down: at `y = 16.3`, `16.3 / 11` is `1.48`, so he's in room
index `1`, the Hall of Bones. `Mathf.FloorToInt` rounds down; `Mathf.Clamp` keeps the
answer between the first room and the last.

Each room has three things to remember: its name, where the camera looks, and whether
the king is there. They go in a small `[System.Serializable]` class, `Room`, and the game
keeps an array of them, as in C# 11.

| Room | Title | Centre | Has Boss |
| --- | --- | --- | --- |
| 0 | The Crypt Gate | (9.5, 5.5) | |
| 1 | The Hall of Bones | (9.5, 16.5) | |
| 2 | The Ossuary | (9.5, 27.5) | |
| 3 | The Archers' Gallery | (9.5, 38.5) | |
| 4 | The Chapel | (9.5, 49.5) | |
| 5 | The King's Tomb | (9.5, 60.5) | ✓ |

When the room changes, `RoomCamera` slides to its centre at 30 units a second: one room in
about a third of a second. It moves in `LateUpdate`, after every `Update`, so it always
works with where the hero is this frame.

### Idea — the game's own state machine

`CryptGame` runs the game as Knight Run's game does, as a state machine with one
`EnterState`:

| State | Its panel | Its enter step |
| --- | --- | --- |
| **Start** | Start: "Crypt Keys", how to play, **Play** | time runs, so the torches flicker behind the panel |
| **Playing** | none, and the pause button | time runs |
| **Paused** | Pause: **Resume**, **Restart**, Volume | `Time.timeScale = 0`: physics, Animators and timers stop |
| **Won** | Win: the gold, the time, **Play Again** | the win text |
| **Lost** | Lose: **Try Again** | |

**Play**, **Restart**, **Play Again** and **Try Again** all call the same method, `Restart`.

### Idea — Restart, piece by piece

Loading the scene again would put everything back too; that waits for Level 4. Here each
piece of the crypt knows how to put **itself** back, and `Restart` asks them all:

| Piece | Its reset puts back |
| --- | --- |
| `Skeleton`, `Archer` | home, whole, switched on, its Animator from the start |
| `Chest` | shut, its loot hidden |
| `Door` | locked, `Open` false |
| `Pickup` | there again, or hidden, if it's loot (**Starts Hidden**) |
| `Inventory` | nothing carried |
| `HeroHealth`, `HeroCombat`, `Hero` | full health; not swinging; at the start, facing up |
| arrows in flight | destroyed |

`enemies.GetComponentsInChildren<Skeleton>(true)` finds every skeleton under `Enemies`. The
`true` matters: it includes those that are switched off, the fallen ones.

`animator.Rebind()` puts an Animator back as it was when the game started: its default
state, its parameters at their defaults. A Dead clip faded the sprite out, though, and
Rebind remembers the colour it finds as the one to go back to: so each reset puts the
colour back to white **first**.

One more thing changes in every enemy: before **Play**, on the pause menu, and once the
game is won or lost, they wait. `if (!game.IsPlaying)` at the top of `Update` stands them
still.

### Do it — Room and RoomCamera

Create `Assets/Scripts/Room.cs`. It isn't a component: don't attach it to anything.

```csharp:Room.cs
using UnityEngine;

// One room of the crypt: its name, the point the camera looks at, and
// whether the king waits there. [System.Serializable] lets a plain C# class
// show in the Inspector, so CryptGame can keep an array of them.
[System.Serializable]
public class Room
{
    [SerializeField] string title;
    [SerializeField] Vector2 centre;
    [SerializeField] bool hasBoss;

    public string Title
    {
        get { return title; }
    }

    public Vector2 Centre
    {
        get { return centre; }
    }

    public bool HasBoss
    {
        get { return hasBoss; }
    }
}
```

Create `Assets/Scripts/RoomCamera.cs`, and add it to **Main Camera**:

```csharp:RoomCamera.cs
using UnityEngine;

// Shows one room at a time. When the hero walks into the next room, the
// camera slides there, at a steady speed.
public class RoomCamera : MonoBehaviour
{
    [SerializeField] float slideSpeed = 30f;    // units a second: one room in about a third of a second

    Vector3 goal;

    void Awake()
    {
        goal = transform.position;
    }

    public void MoveTo(Vector2 centre)
    {
        goal = new Vector3(centre.x, centre.y, transform.position.z);
    }

    // Straight there, with no slide: on Restart.
    public void SnapTo(Vector2 centre)
    {
        MoveTo(centre);
        transform.position = goal;
    }

    // LateUpdate runs after every Update, so the hero has already moved.
    void LateUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, goal, slideSpeed * Time.deltaTime);
    }
}
```

### Do it — the room's name and messages

On the Canvas, two more texts, both in `PixelRpgFont SDF`, colour `#F2E8D5`, centred, with
**Raycast Target** unticked and no text in them:

| Object | Anchor | Pos | Size | Font Size |
| --- | --- | --- | --- | --- |
| `Room Text` | top-center | (0, −185) | 1200 × 100 | 64 |
| `Message Text` | bottom-center | (0, 210) | 1200 × 70 | 40 |

### Do it — the panels' pictures

Select `Panel`, `Button`, `ButtonHighlighted` and `ButtonPressed` in `Assets/Art/UI`, and set
them as **Single**, **Pixels Per Unit** `100`, **Point (no filter)**, Compression **None**.
Then give each a **Border** in the Sprite Editor, so it can stretch without stretching its
edges (C# 8):

| Sprite | Border (L, T, R, B) |
| --- | --- |
| `Panel` | 5, 5, 5, 5 |
| `Button`, `ButtonHighlighted`, `ButtonPressed` | 9, 8, 9, 8 |

The button's pointed ends are 9 pixels; its top and bottom borders add up to its whole
height, 16, so it stretches only across, never up and down.

### Do it — four panels

Each panel is a dark sheet over the whole screen, holding a stone window:

1. On the Canvas, make an **Image**, `Start Panel`. Stretch it over the whole screen
   (anchor **stretch-stretch** with **Shift + Alt**), colour black with **A** `140`. Keep
   its **Raycast Target**: it stops presses reaching the game.
2. Inside it, an **Image**, `Window`, anchored middle-center: **Source Image** `Panel`,
   **Image Type** **Sliced**, **Pixels Per Unit Multiplier** `0.5`, **Width** and
   **Height** from the table, and **Scale** `(2, 2, 1)`. The window is drawn at twice its
   size, and its border at twice that again, so each pixel of the stone is 4 × 4 on the
   screen.
3. In the window, its texts and buttons. A button is **UI (Canvas) → Button -
   TextMeshPro**, 220 × 32: **Source Image** `Button`, **Image Type** **Sliced**, **Pixels
   Per Unit Multiplier** `0.5`, colour white; **Transition** **Sprite Swap**, with
   **Highlighted Sprite** `ButtonHighlighted` and **Pressed Sprite** `ButtonPressed`. Its
   label: `PixelRpgFont SDF`, **Font Size** `18`, colour `#F2E8D5`.

| Panel | Window | Inside it (Pos in the window) |
| --- | --- | --- |
| `Start Panel` | 640 × 360 | `Title` "Crypt Keys", 44 pt, at (0, 125), 600 × 60 · `How To Play`, 15 pt, at (0, 20), 600 × 150 · `Play Button` "Play" at (0, −125) |
| `Pause Panel` | 460 × 330 | `Title` "Paused", 36 pt, at (0, 115) · `Resume Button` at (0, 45) · `Restart Button` at (0, −10) · `Volume Label` "Volume", 16 pt, at (−120, −90) · `Volume Slider` (**UI → Slider**), at (60, −90), 220 wide, **Value** `1` |
| `Win Panel` | 560 × 330 | `Win Text`, 22 pt, at (0, 40), 520 × 220 · `Play Again Button` at (0, −115) |
| `Lose Panel` | 560 × 260 | `Title` "The hero has fallen", 28 pt, at (0, 45) · `Try Again Button` at (0, −70) |

The how-to-play text, in five lines:

```
Walk: W A S D, or hold the mouse or a finger down
Attack: Space, or a quick tap    Open a chest: E
Drink a potion: Q, or tap it

Find the keys, open the doors,
and defeat the Skeleton King!
```

Last, the pause button: a **Button - TextMeshPro** on the Canvas, `Pause Button`, anchored
top-right at (−30, −30), 96 × 96, **Source Image** `Slot`, **Image Type** **Simple**, its
label `II` at **Font Size** `44`. Switch off `Pause Panel`, `Win Panel` and `Lose Panel` in
the Hierarchy; `Start Panel` stays on.

### Do it — CryptGame: the game's states

Make an empty GameObject, `Crypt Game`. Create `Assets/Scripts/CryptGame.cs`, and add it:

```csharp
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

// Runs the game as a state machine: Start, Playing, Paused, Won and Lost. It
// knows which room the hero is in, and counts the time.
public class CryptGame : MonoBehaviour
{
    public enum GameState { Start, Playing, Paused, Won, Lost }

    [SerializeField] Hero hero;
    [SerializeField] Inventory inventory;
    [SerializeField] RoomCamera roomCamera;
    [SerializeField] Room[] rooms;
    [SerializeField] float roomHeight = 11f;    // the rooms are stacked, the first at the bottom
    [SerializeField] TMP_Text roomText;
    [SerializeField] TMP_Text messageText;
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
    float playTime;
    Vector2 startPoint;
    int roomIndex = -1;
    Coroutine roomFade;
    Coroutine messageFade;

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
        startPoint = hero.transform.position;
        roomText.text = "";
        messageText.text = "";
        roomCamera.SnapTo(rooms[0].Centre);
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
                UpdateRoom();
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
                winText.text = $"The Skeleton King has fallen!\n\nGold: {inventory.Gold}\nTime: {FormatTime(playTime)}";
                break;
            case GameState.Lost:
                break;
        }
    }

    // Plays. Putting the crypt back as it was comes next.
    public void Restart()
    {
        playTime = 0f;
        roomIndex = -1;
        roomCamera.SnapTo(rooms[0].Centre);
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

    // The rooms are stacked roomHeight units apart, so the height of the
    // hero's feet says which room he's in: 0 for the first, 1 for the next.
    void UpdateRoom()
    {
        int index = Mathf.FloorToInt(hero.transform.position.y / roomHeight);
        index = Mathf.Clamp(index, 0, rooms.Length - 1);
        if (index == roomIndex)
        {
            return;
        }

        roomIndex = index;
        roomCamera.MoveTo(rooms[index].Centre);
        if (roomFade != null)
        {
            StopCoroutine(roomFade);
        }
        roomFade = StartCoroutine(FadeText(roomText, rooms[index].Title));
    }

    // A line at the bottom of the screen, such as "Locked: find a key".
    public void ShowMessage(string message)
    {
        if (messageFade != null)
        {
            StopCoroutine(messageFade);
        }
        messageFade = StartCoroutine(FadeText(messageText, message));
    }

    // Shows the text for two seconds, then fades it out over one.
    IEnumerator FadeText(TMP_Text label, string text)
    {
        label.text = text;
        label.alpha = 1f;
        yield return new WaitForSeconds(2f);
        for (float t = 0f; t < 1f; t += Time.deltaTime)
        {
            label.alpha = 1f - t;
            yield return null;
        }
        label.text = "";
    }

    bool WasPausePressed()
    {
        Keyboard keyboard = Keyboard.current;
        return keyboard != null && (keyboard.escapeKey.wasPressedThisFrame || keyboard.pKey.wasPressedThisFrame);
    }

    // 161.4 seconds becomes "2:41".
    static string FormatTime(float seconds)
    {
        int whole = Mathf.FloorToInt(seconds);
        return $"{whole / 60}:{whole % 60:00}";
    }
}
```

Read it before you move on:

- `EnterState` shows the state's panel and hides the others, in five lines: each panel is
  active when `state` is its state.
- `UpdateRoom` works out the room, and when it's a new one, moves the camera and starts
  `FadeText`: a coroutine that shows the room's name for two seconds, then fades it over
  one, through the text's `alpha`.
- `ShowMessage` uses the same coroutine for a line at the bottom: a door will say it's
  locked there.
- `Restart` only plays, for now: the pieces can't put themselves back yet.

Fill in its fields: `Hero` into **Hero** and **Inventory**; **Main Camera** into **Room
Camera**; the texts, panels and buttons. Open **Rooms**, set its size to `6`, and fill in
each from the table: **Title**, **Centre**, and **Has Boss** on the last. Check that `Hero`
is back at `(9.5, 2.15, 0)`.

### Do it — every piece can put itself back

Now each script gets its reset, and those that act on their own get `game`, to wait when
the game isn't being played. Replace them one by one.

`Skeleton`: it waits when the game isn't playing, and `ResetSkeleton` puts it back. `Start`
calls it too: one place that sets a skeleton up.

```csharp
using UnityEngine;

// A skeleton with a sword, run as a state machine. The code decides what it
// does; its Animator, the hero's Humanoid controller with the skeleton's own
// clips, only shows the body: which way it faces, how fast it walks, and an
// attack, a hurt or a fall when one happens.
[RequireComponent(typeof(Rigidbody2D))]
public class Skeleton : MonoBehaviour
{
    public enum State { Idle, Patrol, Chase, Attack, Hurt, Dead }

    static readonly int DirectionHash = Animator.StringToHash("Direction");
    static readonly int SpeedHash = Animator.StringToHash("Speed");
    static readonly int AttackHash = Animator.StringToHash("Attack");
    static readonly int HurtHash = Animator.StringToHash("Hurt");
    static readonly int DeadHash = Animator.StringToHash("Dead");

    [SerializeField] CryptGame game;
    [SerializeField] HeroHealth hero;
    [SerializeField] LayerMask wallMask;
    [SerializeField] int maxHealth = 3;
    [SerializeField] float patrolSpeed = 1.5f;
    [SerializeField] float patrolDistance = 2f;     // how far it wanders from where it started
    [SerializeField] float chaseSpeed = 2.5f;
    [SerializeField] float sightRange = 5f;
    [SerializeField] float attackRange = 1f;
    [SerializeField] float attackSeconds = 0.7f;    // as long as the Attack clip
    [SerializeField] float hurtSeconds = 0.4f;
    [SerializeField] float knockbackSpeed = 4f;

    Rigidbody2D body;
    Animator animator;
    Collider2D bodyCollider;
    SpriteRenderer spriteRenderer;
    Vector2 home;
    Vector2 patrolTarget;
    State state;
    Facing facing = Facing.Down;
    int health;
    float stateStartTime;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        bodyCollider = GetComponent<Collider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        home = transform.position;
    }

    void Start()
    {
        ResetSkeleton();
    }

    void Update()
    {
        // Before Play, after the end and in the pause menu, skeletons wait.
        if (!game.IsPlaying)
        {
            Stop();
            UpdateAnimator();
            return;
        }

        switch (state)
        {
            case State.Idle:
                UpdateIdle();
                break;
            case State.Patrol:
                UpdatePatrol();
                break;
            case State.Chase:
                UpdateChase();
                break;
            case State.Attack:
                UpdateAttack();
                break;
            case State.Hurt:
                UpdateHurt();
                break;
            case State.Dead:
                break;                  // waits for the OnDeathFinished Animation Event
        }
        UpdateAnimator();
    }

    // The one place the state changes. The enter step runs once, as the
    // skeleton arrives in its new state.
    void EnterState(State next)
    {
        state = next;
        stateStartTime = Time.time;

        switch (state)
        {
            case State.Idle:
                Stop();
                break;
            case State.Patrol:
                patrolTarget = home + Random.insideUnitCircle * patrolDistance;
                break;
            case State.Chase:
                break;
            case State.Attack:
                Stop();
                FaceHero();
                animator.SetTrigger(AttackHash);
                break;
            case State.Hurt:
                animator.SetTrigger(HurtHash);
                break;
            case State.Dead:
                Stop();
                bodyCollider.enabled = false;
                body.simulated = false;
                animator.SetTrigger(DeadHash);
                break;
        }
    }

    void UpdateIdle()
    {
        if (CanSeeHero())
        {
            EnterState(State.Chase);
        }
        else if (Time.time - stateStartTime > 1.5f)
        {
            EnterState(State.Patrol);
        }
    }

    void UpdatePatrol()
    {
        if (CanSeeHero())
        {
            EnterState(State.Chase);
            return;
        }

        Vector2 toTarget = patrolTarget - body.position;
        if (toTarget.magnitude < 0.1f || Time.time - stateStartTime > 3f)
        {
            EnterState(State.Idle);
            return;
        }
        Move(toTarget.normalized * patrolSpeed);
    }

    // Chase starts within sightRange, but only gives up beyond twice that:
    // with one number for both, a hero standing right at the edge would make
    // the skeleton flip between the two states every frame.
    void UpdateChase()
    {
        Vector2 toHero = HeroPosition() - body.position;
        if (hero.IsDead || toHero.magnitude > sightRange * 2f)
        {
            EnterState(State.Idle);
            return;
        }
        if (toHero.magnitude <= attackRange)
        {
            EnterState(State.Attack);
            return;
        }
        Move(toHero.normalized * chaseSpeed);
    }

    void UpdateAttack()
    {
        if (Time.time - stateStartTime >= attackSeconds)
        {
            EnterState(State.Chase);
        }
    }

    // The knockback carries it for a moment; then it decides between Chase
    // and Dead.
    void UpdateHurt()
    {
        if (Time.time - stateStartTime > 0.15f)
        {
            Stop();
        }
        if (Time.time - stateStartTime >= hurtSeconds)
        {
            EnterState(health > 0 ? State.Chase : State.Dead);
        }
    }

    // Animation Event: the sword's hit frame. The hero is only hurt if he's
    // still in front of the skeleton, so stepping back at the right moment works.
    public void OnAttackHit()
    {
        if (state != State.Attack)
        {
            return;
        }
        Vector2 front = body.position + Facings.ToVector(facing) * 0.6f;
        if (Vector2.Distance(front, HeroPosition()) < 0.8f)
        {
            hero.TakeDamage(1, body.position);
        }
    }

    // The hero's sword hit it.
    public void TakeHit(int damage, Vector2 from)
    {
        if (state == State.Hurt || state == State.Dead)
        {
            return;
        }
        health -= damage;
        body.linearVelocity = (body.position - from).normalized * knockbackSpeed;
        EnterState(State.Hurt);
    }

    // Animation Event: at the end of the Dead clips, once it has faded.
    public void OnDeathFinished()
    {
        gameObject.SetActive(false);
    }

    // Back where it started, whole again: on Restart.
    public void ResetSkeleton()
    {
        gameObject.SetActive(true);
        body.simulated = true;
        body.position = home;
        transform.position = home;
        body.linearVelocity = Vector2.zero;
        bodyCollider.enabled = true;

        // The Dead clip fades it out. Put its colour back before Rebind
        // remembers it.
        spriteRenderer.color = Color.white;
        animator.Rebind();

        health = maxHealth;
        facing = Facing.Down;
        EnterState(State.Idle);
    }

    bool CanSeeHero()
    {
        Vector2 heroPosition = HeroPosition();
        if (hero.IsDead || Vector2.Distance(body.position, heroPosition) > sightRange)
        {
            return false;
        }
        // A wall between them blocks the view.
        return !Physics2D.Linecast(body.position, heroPosition, wallMask);
    }

    Vector2 HeroPosition()
    {
        return hero.transform.position;
    }

    void Move(Vector2 velocity)
    {
        body.linearVelocity = velocity;
        facing = Facings.FromVector(velocity, facing);
    }

    void Stop()
    {
        body.linearVelocity = Vector2.zero;
    }

    void FaceHero()
    {
        facing = Facings.FromVector(HeroPosition() - body.position, facing);
    }

    void UpdateAnimator()
    {
        animator.SetInteger(DirectionHash, (int)facing);
        animator.SetFloat(SpeedHash, body.linearVelocity.magnitude);
    }
}
```

`Archer`: the same.

```csharp
using UnityEngine;

// A skeleton archer, run as a state machine. It keeps its distance, shoots
// when it can see the hero, then steps aside before shooting again. Its
// Animator is the Humanoid controller, with the archer's own clips.
[RequireComponent(typeof(Rigidbody2D))]
public class Archer : MonoBehaviour
{
    public enum State { Idle, KeepDistance, Shoot, Reposition, Hurt, Dead }

    static readonly int DirectionHash = Animator.StringToHash("Direction");
    static readonly int SpeedHash = Animator.StringToHash("Speed");
    static readonly int AttackHash = Animator.StringToHash("Attack");
    static readonly int HurtHash = Animator.StringToHash("Hurt");
    static readonly int DeadHash = Animator.StringToHash("Dead");

    [SerializeField] CryptGame game;
    [SerializeField] HeroHealth hero;
    [SerializeField] Arrow arrowPrefab;
    [SerializeField] Transform arrowGroup;          // where its arrows go, so Restart can clear them
    [SerializeField] LayerMask wallMask;
    [SerializeField] int maxHealth = 2;
    [SerializeField] float moveSpeed = 2f;
    [SerializeField] float sightRange = 9f;
    [SerializeField] float tooClose = 4f;           // closer than this, it backs away
    [SerializeField] float tooFar = 6f;             // further than this, it comes closer
    [SerializeField] float shootSeconds = 1f;       // as long as the Attack clip
    [SerializeField] float repositionSeconds = 0.8f;
    [SerializeField] float hurtSeconds = 0.4f;
    [SerializeField] float knockbackSpeed = 4f;

    Rigidbody2D body;
    Animator animator;
    Collider2D bodyCollider;
    SpriteRenderer spriteRenderer;
    Vector2 home;
    Vector2 sideStep;
    State state;
    Facing facing = Facing.Down;
    int health;
    float stateStartTime;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        bodyCollider = GetComponent<Collider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        home = transform.position;
    }

    void Start()
    {
        ResetArcher();
    }

    void Update()
    {
        if (!game.IsPlaying)
        {
            Stop();
            UpdateAnimator();
            return;
        }

        switch (state)
        {
            case State.Idle:
                UpdateIdle();
                break;
            case State.KeepDistance:
                UpdateKeepDistance();
                break;
            case State.Shoot:
                UpdateShoot();
                break;
            case State.Reposition:
                UpdateReposition();
                break;
            case State.Hurt:
                UpdateHurt();
                break;
            case State.Dead:
                break;                  // waits for the OnDeathFinished Animation Event
        }
        UpdateAnimator();
    }

    void EnterState(State next)
    {
        state = next;
        stateStartTime = Time.time;

        switch (state)
        {
            case State.Idle:
                Stop();
                break;
            case State.KeepDistance:
                break;
            case State.Shoot:
                Stop();
                FaceHero();
                animator.SetTrigger(AttackHash);
                break;
            case State.Reposition:
                // A step to one side or the other, across the line to the hero.
                Vector2 toHero = (HeroPosition() - body.position).normalized;
                Vector2 across = new Vector2(-toHero.y, toHero.x);
                sideStep = (Random.value < 0.5f ? across : -across) * moveSpeed;
                break;
            case State.Hurt:
                animator.SetTrigger(HurtHash);
                break;
            case State.Dead:
                Stop();
                bodyCollider.enabled = false;
                body.simulated = false;
                animator.SetTrigger(DeadHash);
                break;
        }
    }

    void UpdateIdle()
    {
        if (CanSeeHero())
        {
            EnterState(State.KeepDistance);
        }
    }

    void UpdateKeepDistance()
    {
        if (!CanSeeHero())
        {
            EnterState(State.Idle);
            return;
        }

        Vector2 toHero = HeroPosition() - body.position;
        if (toHero.magnitude < tooClose)
        {
            Move(-toHero.normalized * moveSpeed);
            facing = Facings.FromVector(toHero, facing);     // backs away, still facing the hero
        }
        else if (toHero.magnitude > tooFar)
        {
            Move(toHero.normalized * moveSpeed);
        }
        else
        {
            EnterState(State.Shoot);
        }
    }

    void UpdateShoot()
    {
        if (Time.time - stateStartTime >= shootSeconds)
        {
            EnterState(State.Reposition);
        }
    }

    void UpdateReposition()
    {
        Move(sideStep);
        if (Time.time - stateStartTime >= repositionSeconds)
        {
            EnterState(State.KeepDistance);
        }
    }

    void UpdateHurt()
    {
        if (Time.time - stateStartTime > 0.15f)
        {
            Stop();
        }
        if (Time.time - stateStartTime >= hurtSeconds)
        {
            EnterState(health > 0 ? State.KeepDistance : State.Dead);
        }
    }

    // Animation Event: the release frame, as the bowstring snaps forward.
    // The arrow flies from the archer's feet at where the hero's feet are now.
    public void OnAttackHit()
    {
        if (state != State.Shoot)
        {
            return;
        }
        Vector2 from = body.position + Facings.ToVector(facing) * 0.4f;
        Arrow arrow = Instantiate(arrowPrefab, from, Quaternion.identity, arrowGroup);
        arrow.Launch(HeroPosition() - from);
    }

    public void TakeHit(int damage, Vector2 from)
    {
        if (state == State.Hurt || state == State.Dead)
        {
            return;
        }
        health -= damage;
        body.linearVelocity = (body.position - from).normalized * knockbackSpeed;
        EnterState(State.Hurt);
    }

    // Animation Event: at the end of the Dead clips, once it has faded.
    public void OnDeathFinished()
    {
        gameObject.SetActive(false);
    }

    public void ResetArcher()
    {
        gameObject.SetActive(true);
        body.simulated = true;
        body.position = home;
        transform.position = home;
        body.linearVelocity = Vector2.zero;
        bodyCollider.enabled = true;
        spriteRenderer.color = Color.white;
        animator.Rebind();

        health = maxHealth;
        facing = Facing.Down;
        EnterState(State.Idle);
    }

    // It sees the hero if he's within range and no wall is in the way. A
    // statue isn't a wall, but its collider is on the Walls layer too: cover.
    bool CanSeeHero()
    {
        Vector2 heroPosition = HeroPosition();
        if (hero.IsDead || Vector2.Distance(body.position, heroPosition) > sightRange)
        {
            return false;
        }
        return !Physics2D.Linecast(body.position, heroPosition, wallMask);
    }

    Vector2 HeroPosition()
    {
        return hero.transform.position;
    }

    void Move(Vector2 velocity)
    {
        body.linearVelocity = velocity;
        facing = Facings.FromVector(velocity, facing);
    }

    void Stop()
    {
        body.linearVelocity = Vector2.zero;
    }

    void FaceHero()
    {
        facing = Facings.FromVector(HeroPosition() - body.position, facing);
    }

    void UpdateAnimator()
    {
        animator.SetInteger(DirectionHash, (int)facing);
        animator.SetFloat(SpeedHash, body.linearVelocity.magnitude);
    }
}
```

`Chest`: shut, and its loot hidden again.

```csharp
using UnityEngine;

// A chest. Open sets the Open trigger; the Opening clip's lid-up frame calls
// OnLootReady, and the loot waiting in front of the chest appears just then.
public class Chest : MonoBehaviour
{
    static readonly int OpenHash = Animator.StringToHash("Open");

    [SerializeField] GameObject[] loot;     // hidden pickups, placed in front of the chest

    Animator animator;

    public bool IsOpen { get; private set; }

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void Open()
    {
        if (IsOpen)
        {
            return;
        }
        IsOpen = true;
        animator.SetTrigger(OpenHash);
    }

    // Animation Event: the Opening clip's last frame, as the lid comes up.
    public void OnLootReady()
    {
        foreach (GameObject item in loot)
        {
            item.SetActive(true);
        }
    }

    public void ResetChest()
    {
        IsOpen = false;
        foreach (GameObject item in loot)
        {
            item.SetActive(false);
        }
        animator.Rebind();
    }
}
```

`Door`: locked again, its leaves back. A locked door now says so on the screen.

```csharp
using UnityEngine;

// A locked door. Walk into it carrying a key, and it opens: the Open Bool
// starts its Opening clip, whose last frame calls OnDoorOpened, and only
// then does the doorway stop blocking the way.
public class Door : MonoBehaviour
{
    static readonly int OpenHash = Animator.StringToHash("Open");

    [SerializeField] CryptGame game;
    [SerializeField] bool needsBossKey;
    [SerializeField] Collider2D blocker;

    Animator animator;
    bool isOpen;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (isOpen || !collision.gameObject.TryGetComponent(out Inventory inventory))
        {
            return;
        }

        bool hasKey = needsBossKey ? inventory.UseBossKey() : inventory.UseKey();
        if (!hasKey)
        {
            game.ShowMessage(needsBossKey ? "The boss key opens this door" : "Locked: find a key");
            return;
        }

        isOpen = true;
        animator.SetBool(OpenHash, true);
    }

    // Animation Event: the Opening clip's last frame, once the door is open.
    public void OnDoorOpened()
    {
        blocker.enabled = false;
    }

    public void ResetDoor()
    {
        isOpen = false;
        blocker.enabled = true;
        animator.SetBool(OpenHash, false);
        animator.Rebind();
    }
}
```

`Pickup`: **Starts Hidden** is for loot. Tick it on the six pieces of loot in front of the
chests (they're switched off: select them in the Hierarchy all the same).

```csharp
using UnityEngine;

// A key, the boss key, a potion or a pile of gold: one script for all four.
// Its Kind says which, and a switch does the rest.
public class Pickup : MonoBehaviour
{
    public enum Kind { Key, BossKey, Potion, Gold }

    [SerializeField] Kind kind;
    [SerializeField] int gold = 25;             // for Gold only
    [SerializeField] bool startsHidden;         // loot waits, hidden, until its chest opens

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.TryGetComponent(out Inventory inventory))
        {
            return;
        }

        switch (kind)
        {
            case Kind.Key:
                inventory.AddKey();
                break;
            case Kind.BossKey:
                inventory.AddBossKey();
                break;
            case Kind.Potion:
                if (!inventory.AddPotion())
                {
                    return;     // he carries three already: it waits for later
                }
                break;
            case Kind.Gold:
                inventory.AddGold(gold);
                break;
        }
        gameObject.SetActive(false);
    }

    public void ResetPickup()
    {
        gameObject.SetActive(!startsHidden);
    }
}
```

`Inventory`: empty pockets.

```csharp
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// What the hero carries: keys, the boss key, up to three potions, and gold.
// It keeps the screen's key count, potion slots and gold up to date.
public class Inventory : MonoBehaviour
{
    public const int MaxPotions = 3;

    [SerializeField] HeroHealth health;
    [SerializeField] TMP_Text keyText;
    [SerializeField] Image bossKeyIcon;
    [SerializeField] TMP_Text goldText;
    [SerializeField] Image[] potionIcons;       // the three slots' potions
    [SerializeField] Button[] potionButtons;    // tap a slot to drink
    [SerializeField] int potionHealing = 2;     // a whole heart

    int keys;
    bool hasBossKey;
    int potions;

    public int Gold { get; private set; }

    void OnEnable()
    {
        foreach (Button button in potionButtons)
        {
            button.onClick.AddListener(DrinkPotion);
        }
    }

    void OnDisable()
    {
        foreach (Button button in potionButtons)
        {
            button.onClick.RemoveListener(DrinkPotion);
        }
    }

    void Start()
    {
        UpdateScreen();
    }

    public void AddKey()
    {
        keys++;
        UpdateScreen();
    }

    public void AddBossKey()
    {
        hasBossKey = true;
        UpdateScreen();
    }

    // False when he already carries three: the potion stays where it is.
    public bool AddPotion()
    {
        if (potions >= MaxPotions)
        {
            return false;
        }
        potions++;
        UpdateScreen();
        return true;
    }

    public void AddGold(int amount)
    {
        Gold += amount;
        UpdateScreen();
    }

    // A door asks for a key: true if there was one to use.
    public bool UseKey()
    {
        if (keys == 0)
        {
            return false;
        }
        keys--;
        UpdateScreen();
        return true;
    }

    public bool UseBossKey()
    {
        if (!hasBossKey)
        {
            return false;
        }
        hasBossKey = false;
        UpdateScreen();
        return true;
    }

    // Q, or a tap on a potion slot. A whole heart back, if there's a potion
    // and he has a heart to lose.
    public void DrinkPotion()
    {
        if (potions == 0 || health.IsDead || health.IsFull)
        {
            return;
        }
        potions--;
        health.Heal(potionHealing);
        UpdateScreen();
    }

    void UpdateScreen()
    {
        keyText.text = $"x {keys}";
        bossKeyIcon.enabled = hasBossKey;
        goldText.text = Gold.ToString();
        for (int i = 0; i < potionIcons.Length; i++)
        {
            potionIcons[i].enabled = i < potions;
        }
    }

    public void ResetInventory()
    {
        keys = 0;
        hasBossKey = false;
        potions = 0;
        Gold = 0;
        UpdateScreen();
    }
}
```

`HeroHealth`: full health, and at 0, the game is lost. Nothing hurts him unless the game
is being played.

```csharp
using System.Collections;
using UnityEngine;

// The hero's health, counted in half hearts: 6 is three whole hearts. A hit
// knocks him back and makes him blink, and nothing can hurt him while he
// blinks. At 0 he falls, and when his Dead clip ends, the game is lost.
public class HeroHealth : MonoBehaviour
{
    public const int MaxHealth = 6;

    static readonly int HurtHash = Animator.StringToHash("Hurt");
    static readonly int DeadHash = Animator.StringToHash("Dead");

    [SerializeField] CryptGame game;
    [SerializeField] HeartsBar hearts;
    [SerializeField] float knockbackSpeed = 6f;
    [SerializeField] float stunSeconds = 0.2f;      // no control, while the knockback carries him
    [SerializeField] float blinkSeconds = 1f;

    Rigidbody2D body;
    Animator animator;
    SpriteRenderer spriteRenderer;
    bool isBlinking;
    float stunnedUntil;

    public int Health { get; private set; } = MaxHealth;
    public bool IsDead { get; private set; }

    public bool IsStunned
    {
        get { return Time.time < stunnedUntil; }
    }

    public bool IsFull
    {
        get { return Health == MaxHealth; }
    }

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        hearts.SetHealth(Health);
    }

    // Something hurt him. from is where it was, so he's knocked away from it.
    public void TakeDamage(int amount, Vector2 from)
    {
        // Nothing hurts him while he blinks, or once he has fallen, or when
        // the game isn't being played.
        if (IsDead || isBlinking || !game.IsPlaying)
        {
            return;
        }

        Health = Mathf.Max(Health - amount, 0);
        hearts.SetHealth(Health);

        if (Health == 0)
        {
            IsDead = true;
            body.linearVelocity = Vector2.zero;
            animator.SetTrigger(DeadHash);
            return;
        }

        Vector2 away = (body.position - from).normalized;
        body.linearVelocity = away * knockbackSpeed;
        stunnedUntil = Time.time + stunSeconds;
        animator.SetTrigger(HurtHash);
        StartCoroutine(Blink());
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
        hearts.SetHealth(Health);
    }

    // Animation Event: at the end of the Dead clips.
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
        hearts.SetHealth(Health);
    }
}
```

`HeroCombat`: not swinging.

```csharp
using UnityEngine;

// The hero's sword. An attack starts the Attack clip, and the clip's hit
// frame calls OnAttackHit: only then does the sword hurt what's in front.
public class HeroCombat : MonoBehaviour
{
    static readonly int AttackHash = Animator.StringToHash("Attack");

    [SerializeField] LayerMask enemyMask;
    [SerializeField] int damage = 1;
    [SerializeField] float attackSeconds = 0.5f;    // as long as the Attack clip
    [SerializeField] float hitDistance = 0.7f;      // how far in front of his middle the sword's circle is
    [SerializeField] float hitRadius = 0.6f;

    // His body's middle, above his feet: the sword's circle is measured from here.
    readonly Vector2 middle = new Vector2(0f, 0.4f);

    Animator animator;
    Vector2 attackDirection;
    float attackEndTime;

    public bool IsAttacking
    {
        get { return Time.time < attackEndTime; }
    }

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // An attack the way he faces: direction is Facings.ToVector of his facing.
    public void Attack(Vector2 direction)
    {
        if (IsAttacking)
        {
            return;
        }
        attackDirection = direction;
        attackEndTime = Time.time + attackSeconds;
        animator.SetTrigger(AttackHash);
    }

    // Animation Event: the sword's hit frame, on all four Attack clips.
    // Everything on the Enemy layer inside the circle is hit.
    public void OnAttackHit()
    {
        Vector2 front = (Vector2)transform.position + middle + attackDirection * hitDistance;
        Collider2D[] hits = Physics2D.OverlapCircleAll(front, hitRadius, enemyMask);
        foreach (Collider2D hit in hits)
        {
            if (hit.TryGetComponent(out Skeleton skeleton))
            {
                skeleton.TakeHit(damage, transform.position);
            }
            else if (hit.TryGetComponent(out Archer archer))
            {
                archer.TakeHit(damage, transform.position);
            }
        }
    }

    public void ResetCombat()
    {
        attackEndTime = 0f;
    }
}
```

`Hero`: no control unless the game is being played; `ResetHero` puts him at the start,
facing up, his colour back, and his Animator from the start. This is `Hero`'s last
version:

```csharp:Hero.cs
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

// The hero: walks with the keyboard, or towards a pointer that's held down,
// and faces one of four ways. Every frame he tells the Animator his Direction
// and his Speed. A quick tap swings the sword, or opens the chest in front.
[RequireComponent(typeof(Rigidbody2D))]
public class Hero : MonoBehaviour
{
    static readonly int DirectionHash = Animator.StringToHash("Direction");
    static readonly int SpeedHash = Animator.StringToHash("Speed");

    [SerializeField] CryptGame game;
    [SerializeField] float walkSpeed = 4f;
    [SerializeField] float holdSeconds = 0.25f;     // a press longer than this walks; a shorter one is a tap
    [SerializeField] float reach = 0.6f;            // how far in front of his feet a chest can be opened

    Rigidbody2D body;
    Animator animator;
    SpriteRenderer spriteRenderer;
    HeroCombat combat;
    HeroHealth health;
    Inventory inventory;
    Camera mainCamera;
    Facing facing = Facing.Up;
    float pressStart = -1f;     // when the pointer went down, or -1 when it isn't down
    bool isPressOnUi;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        combat = GetComponent<HeroCombat>();
        health = GetComponent<HeroHealth>();
        inventory = GetComponent<Inventory>();
        mainCamera = Camera.main;
    }

    void Update()
    {
        Vector2 move = Vector2.zero;
        if (HasControl() && !combat.IsAttacking)
        {
            move = ReadKeyboard() + ReadPointer();
        }
        else if (!HasControl())
        {
            pressStart = -1f;
        }

        if (move.sqrMagnitude > 0.01f)
        {
            facing = Facings.FromVector(move, facing);
        }

        // While he's stunned, the knockback carries him instead. A velocity
        // is safe to set in Update: the Rigidbody keeps it until the next
        // physics step uses it.
        if (!health.IsStunned)
        {
            body.linearVelocity = Vector2.ClampMagnitude(move, 1f) * walkSpeed;
        }

        animator.SetInteger(DirectionHash, (int)facing);
        animator.SetFloat(SpeedHash, body.linearVelocity.magnitude);
    }

    bool HasControl()
    {
        return game.IsPlaying && !health.IsDead && !health.IsStunned;
    }

    // W A S D or the arrows walk; Space or J attacks; E opens; Q drinks.
    // A phone may have no keyboard, and then Keyboard.current is null.
    Vector2 ReadKeyboard()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard == null)
        {
            return Vector2.zero;
        }

        Vector2 move = Vector2.zero;
        if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed)
        {
            move.x -= 1f;
        }
        if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed)
        {
            move.x += 1f;
        }
        if (keyboard.sKey.isPressed || keyboard.downArrowKey.isPressed)
        {
            move.y -= 1f;
        }
        if (keyboard.wKey.isPressed || keyboard.upArrowKey.isPressed)
        {
            move.y += 1f;
        }

        if (keyboard.spaceKey.wasPressedThisFrame || keyboard.jKey.wasPressedThisFrame)
        {
            combat.Attack(Facings.ToVector(facing));
        }
        if (keyboard.eKey.wasPressedThisFrame)
        {
            TryOpenChest();
        }
        if (keyboard.qKey.wasPressedThisFrame)
        {
            inventory.DrinkPotion();
        }
        return move.normalized;
    }

    // The mouse, or a finger: held down longer than holdSeconds, he walks
    // towards it; a quicker tap is handled by Tap. A press that lands on the
    // UI, such as a potion slot, belongs to the UI.
    Vector2 ReadPointer()
    {
        Pointer pointer = Pointer.current;
        if (pointer == null)
        {
            return Vector2.zero;
        }

        if (pointer.press.wasPressedThisFrame)
        {
            pressStart = Time.time;
            isPressOnUi = false;
        }
        if (pressStart < 0f)
        {
            return Vector2.zero;
        }

        // The UI only knows a finger is on a button a frame after it lands,
        // so ask on every frame of the press.
        if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
        {
            isPressOnUi = true;
        }

        Vector2 target = mainCamera.ScreenToWorldPoint(pointer.position.ReadValue());
        if (pointer.press.wasReleasedThisFrame || !pointer.press.isPressed)
        {
            if (!isPressOnUi && Time.time - pressStart <= holdSeconds)
            {
                Tap(target);
            }
            pressStart = -1f;
            return Vector2.zero;
        }

        Vector2 toTarget = target - body.position;
        if (isPressOnUi || Time.time - pressStart <= holdSeconds || toTarget.magnitude < 0.2f)
        {
            return Vector2.zero;
        }
        return toTarget.normalized;
    }

    // A tap opens the chest in front of him, or swings the sword the way of the tap.
    void Tap(Vector2 target)
    {
        if (TryOpenChest())
        {
            return;
        }
        facing = Facings.FromVector(target - body.position, facing);
        animator.SetInteger(DirectionHash, (int)facing);
        combat.Attack(Facings.ToVector(facing));
    }

    // A chest's collider is at its foot, as his is, so this circle is
    // measured from his feet.
    bool TryOpenChest()
    {
        Vector2 front = body.position + Facings.ToVector(facing) * reach;
        Collider2D[] hits = Physics2D.OverlapCircleAll(front, 0.45f);
        foreach (Collider2D hit in hits)
        {
            if (hit.TryGetComponent(out Chest chest) && !chest.IsOpen)
            {
                chest.Open();
                return true;
            }
        }
        return false;
    }

    // Back at the start, facing into the crypt: on Restart.
    public void ResetHero(Vector2 position)
    {
        body.position = position;
        transform.position = position;
        body.linearVelocity = Vector2.zero;
        facing = Facing.Up;
        pressStart = -1f;

        // The Dead clip fades him out. Put his colour back first: Rebind
        // remembers the colour he has now as the one to go back to.
        spriteRenderer.color = Color.white;
        animator.Rebind();
        animator.SetInteger(DirectionHash, (int)facing);
    }
}
```

Then fill the new **Game** fields: select all the skeletons under `Enemies` and drag `Crypt
Game` into **Game** (one drag for all), then the archers, then the five doors, then `Hero`
(two of its scripts have one).

### Do it — CryptGame: Restart for real

Make an empty GameObject `Arrows` if you haven't, and replace `CryptGame`:

```csharp
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

// Runs the game as a state machine: Start, Playing, Paused, Won and Lost. It
// knows which room the hero is in, counts the time, and puts the whole crypt
// back on Restart.
public class CryptGame : MonoBehaviour
{
    public enum GameState { Start, Playing, Paused, Won, Lost }

    [SerializeField] Hero hero;
    [SerializeField] HeroHealth heroHealth;
    [SerializeField] HeroCombat heroCombat;
    [SerializeField] Inventory inventory;
    [SerializeField] RoomCamera roomCamera;
    [SerializeField] Room[] rooms;
    [SerializeField] float roomHeight = 11f;    // the rooms are stacked, the first at the bottom
    [SerializeField] Transform enemies;
    [SerializeField] Transform chests;
    [SerializeField] Transform doors;
    [SerializeField] Transform pickups;
    [SerializeField] Transform arrows;
    [SerializeField] TMP_Text roomText;
    [SerializeField] TMP_Text messageText;
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
    float playTime;
    Vector2 startPoint;
    int roomIndex = -1;
    Coroutine roomFade;
    Coroutine messageFade;

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
        startPoint = hero.transform.position;
        roomText.text = "";
        messageText.text = "";
        roomCamera.SnapTo(rooms[0].Centre);
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
                UpdateRoom();
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
                winText.text = $"The Skeleton King has fallen!\n\nGold: {inventory.Gold}\nTime: {FormatTime(playTime)}";
                break;
            case GameState.Lost:
                break;
        }
    }

    // Puts the whole crypt back as it was at the start, then plays.
    public void Restart()
    {
        playTime = 0f;
        roomIndex = -1;

        foreach (Skeleton skeleton in enemies.GetComponentsInChildren<Skeleton>(true))
        {
            skeleton.ResetSkeleton();
        }
        foreach (Archer archer in enemies.GetComponentsInChildren<Archer>(true))
        {
            archer.ResetArcher();
        }
        foreach (Arrow arrow in arrows.GetComponentsInChildren<Arrow>())
        {
            Destroy(arrow.gameObject);
        }
        foreach (Chest chest in chests.GetComponentsInChildren<Chest>(true))
        {
            chest.ResetChest();
        }
        foreach (Door door in doors.GetComponentsInChildren<Door>(true))
        {
            door.ResetDoor();
        }
        foreach (Pickup pickup in pickups.GetComponentsInChildren<Pickup>(true))
        {
            pickup.ResetPickup();
        }

        hero.ResetHero(startPoint);
        heroHealth.ResetHealth();
        heroCombat.ResetCombat();
        inventory.ResetInventory();
        roomCamera.SnapTo(rooms[0].Centre);
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

    // The rooms are stacked roomHeight units apart, so the height of the
    // hero's feet says which room he's in: 0 for the first, 1 for the next.
    void UpdateRoom()
    {
        int index = Mathf.FloorToInt(hero.transform.position.y / roomHeight);
        index = Mathf.Clamp(index, 0, rooms.Length - 1);
        if (index == roomIndex)
        {
            return;
        }

        roomIndex = index;
        roomCamera.MoveTo(rooms[index].Centre);
        if (roomFade != null)
        {
            StopCoroutine(roomFade);
        }
        roomFade = StartCoroutine(FadeText(roomText, rooms[index].Title));
    }

    // A line at the bottom of the screen, such as "Locked: find a key".
    public void ShowMessage(string message)
    {
        if (messageFade != null)
        {
            StopCoroutine(messageFade);
        }
        messageFade = StartCoroutine(FadeText(messageText, message));
    }

    // Shows the text for two seconds, then fades it out over one.
    IEnumerator FadeText(TMP_Text label, string text)
    {
        label.text = text;
        label.alpha = 1f;
        yield return new WaitForSeconds(2f);
        for (float t = 0f; t < 1f; t += Time.deltaTime)
        {
            label.alpha = 1f - t;
            yield return null;
        }
        label.text = "";
    }

    bool WasPausePressed()
    {
        Keyboard keyboard = Keyboard.current;
        return keyboard != null && (keyboard.escapeKey.wasPressedThisFrame || keyboard.pKey.wasPressedThisFrame);
    }

    // 161.4 seconds becomes "2:41".
    static string FormatTime(float seconds)
    {
        int whole = Mathf.FloorToInt(seconds);
        return $"{whole / 60}:{whole % 60:00}";
    }
}
```

Fill in its new fields: `Hero` into **Hero Health** and **Hero Combat**, and the groups
`Enemies`, `Chests`, `Doors`, `Pickups` and `Arrows`.

### Do it — the pause menu

Create `Assets/Scripts/PauseMenu.cs`, add it to `Pause Panel`, and fill in **Game**,
**Resume Button**, **Restart Button** and **Volume Slider**:

```csharp:PauseMenu.cs
using UnityEngine;
using UnityEngine.UI;

// The pause panel: Resume, Restart and the volume. Its buttons are connected
// when the panel opens (OnEnable), and disconnected when it closes (OnDisable).
public class PauseMenu : MonoBehaviour
{
    [SerializeField] CryptGame game;
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

### Test it

Press **Play**.

- The Start panel. The skeletons don't move behind it. Press **Play**.
- Open the chest and the door, and walk through: the camera slides up into the Hall of
  Bones, and `The Hall of Bones` fades in. Walk back down: back to the Crypt Gate.
- Walk into a locked door: `Locked: find a key` at the bottom of the screen.
- **Esc**: the pause panel, and everything stops, the torches too. Drag the volume.
  **Resume**.
- Let the skeletons win: the hero falls, fades, and **Try Again** shows. Press it: the
  hero is at the start with three hearts, the chests are shut, the doors locked, the
  skeletons home, the key and the gold back.
- Fell a skeleton, pick up the gold, pause and **Restart**: all back.

To try it on a phone: **Window → General → Device Simulator**, pick a phone, and use the
mouse as a finger. A hold walks, a tap swings or opens, a tap on a potion slot drinks.

### Challenge

Slow the camera's slide to `5` units a second, and walk through a door: what does the
player see in the middle of the slide, and why is a quick slide kinder? Put it back to
`30`. Then find the one place in `CryptGame` where you'd show the room's **number** too
(`2 / 6`), and add it to the room text.

# Part 4 — The Skeleton King

## Chapter 13 — The Skeleton King

**Goal:** the King's Tomb painted, and its king. He sleeps until the hero walks in; then
his bar shows, and he fights in two phases. In the first he walks at the hero and swings,
two slashes a swing. At half health he strikes the floor, a golden ring spreads, and two
skeletons rise. In the second he spins after the hero in a whirlwind that turns the sword
aside, then stops to rest, open to the sword. When he falls, the crypt is won. He uses his
own Animator Controller: a **copy** of Humanoid, with two states more.

### Idea — override, or copy?

The king was drawn with the same twenty animations as the hero, and two more: a whirlwind
(4 frames of 128 pixels, looping) and a summoning strike (12 frames of 64 pixels, the ring
spreading on frame 9). An Override Controller can swap clips, but it can't add a state or
a parameter: its state machine is always its base's. So the king gets a **copy** of
`Humanoid`, with his own clips in it, and two parameters and two states added.

| When | Use | Because |
| --- | --- | --- |
| only the pictures change | an **Override Controller** | one state machine to fix and improve: every override gets the change |
| the states change | a **copy** of the controller | it can grow its own states, but a fix to the original doesn't reach it |

The two new states sit in the Base Layer, beside the four machines:

| Parameter | Type | State | Arrows |
| --- | --- | --- | --- |
| `Whirlwind` | Bool | **Whirlwind**: spins, looping, as long as the Bool is on | Any State → Whirlwind while `Whirlwind` is true; Whirlwind → Exit when it's false |
| `Summon` | Trigger | **Summon**: the strike and the ring, once | Any State → Summon on `Summon`; Summon → Exit at the end of its clip |

An arrow to the Base Layer's **Exit** starts the whole layer again from its Entry: the
default state, Down's Idle, which leaves at once for the machine his `Direction` names.

### Idea — the king's states, in two phases

| State | What he does | Leaves for |
| --- | --- | --- |
| **Asleep** | stands on his tomb | Walk, when the hero comes into the tomb (`Wake`) |
| **Walk** | walks at 1.5 towards the hero | Swing, within 1.5 units |
| **Swing** | stops, faces him, swings: two slashes, on frames 3 and 8; each costs a whole heart if the hero's in front | Walk, after 1 s |
| **Summon** | at half health, once: strikes the floor; `OnSummon` on frame 9 raises two skeletons | Whirlwind, after 1.2 s |
| **Whirlwind** | spins after the hero at 3, half a heart if he's within 1 unit | Rest, after 2 s |
| **Rest** | stands still, dizzy | Whirlwind, after 1.5 s |
| **Dead** | falls | `OnDeathFinished`: the game is won |

```
   Phase 1:   Asleep ──► Walk ◄──► Swing
                           │ at half health
   Phase 2:              Summon ──► Whirlwind ◄──► Rest ──► Dead
```

The hero walks at 4 and the whirlwind at 3: he can get away, if he's quick. The second
slash of a swing catches a hero who stepped back from the first, but blinking protects him
from being hit by both.

`TakeHit` returns a `bool` now: `false` when the sword can't hurt him, asleep, summoning,
spinning or fallen. `HeroCombat` hears the `false`, and the Console says *clang* (Chapter
14 makes it a sound).

He's too heavy to be knocked back, so a hit makes him **flicker** instead. Why not flash
him red? The Dead clips animate the Sprite Renderer's **Color**, and an Animator that
animates a property in one state sets it in every state, every frame: a colour set from
code would be put back at once. The renderer's **enabled** isn't animated, so switching it
off and on works.

### Idea — a summon: copying a scene object

`Instantiate` copies a prefab, and it can copy an object in the scene too. The king copies
a **template skeleton**: a whole skeleton in the scene, switched off, with every field
filled in, its **Game**, its **Hero** and its **Wall Mask**. A prefab couldn't point to the
scene's hero; a scene object can, and so can its copies. Each copy is switched off, like its
template, so `OnSummon` switches it on. The copies go under a group of their own,
`Summoned`, and `ResetKing` destroys them all. The template sits outside `Enemies`, so
Restart never wakes it.

### Do it — the king's clips

1. Import the 22 sheets in `Assets/Art/Characters/King` as the others: **Multiple**, `32`,
   **Point**, **None**.
2. Slice each **Grid By Cell Size** with a **Custom** pivot in **Pixels**. The same figure
   stands in the middle of every frame, so the bigger frames' pivots are further in:

| Sheets | Cell Size | Custom Pivot |
| --- | --- | --- |
| all `…Idle`, `…Walk`, `…Hurt` and `…Death` | 48 × 48 | (24, 8) |
| all four `…Attack`, and `KingSummon` | 64 × 64 | (32, 16) |
| `KingWhirlwind` | 128 × 128 | (64, 48) |

3. On a temporary GameObject, `King` (drag `KingDownIdle_0` into the Hierarchy), make his
   twenty-two clips, named `King Down Idle` and so on, and `King Whirlwind` and `King
   Summon`:

| Clip | Frames | Samples | Loop Time | Events |
| --- | --- | --- | --- | --- |
| Idle | 6 | 8 | on | |
| Walk | 10 | 10 | on | |
| Attack | 10 | 10 | off | `OnAttackHit` at `0:3` and at `0:8`: two slashes |
| Hurt | 4 | 10 | off | |
| Dead | 13, then the fade (keys at `1:8` and `2:3`) | 10 | off | `OnDeathFinished` at `2:3` |
| `King Whirlwind` | 4 | 12 | on | |
| `King Summon` | 12 | 10 | off | `OnSummon` at `0:9`, the ring |

Then delete the temporary `King.controller` Unity made.

### Do it — the king's own controller

1. Select `Humanoid` in `Assets/Animation`, press **Ctrl+D** (**Cmd+D**), and rename the
   copy `Skeleton King`.
2. Open it in the Animator. In each of its four machines, swap the five states' **Motion**
   for the king's clips: `King Down Idle` into Down's Idle, and so on.
3. On the **Parameters** tab, add a **Bool**, `Whirlwind`, and a **Trigger**, `Summon`.
4. In the Base Layer, right-click → **Create State → Empty**, twice: `Whirlwind`, with
   **Motion** `King Whirlwind`, and `Summon`, with **Motion** `King Summon`.
5. The four arrows, each with **Transition Duration** `0`:

| From | To | Settings | Conditions |
| --- | --- | --- | --- |
| Any State | Whirlwind | Can Transition To Self **off** | `Whirlwind` true |
| Whirlwind | Exit | Has Exit Time off | `Whirlwind` false |
| Any State | Summon | Can Transition To Self **off** | `Summon` |
| Summon | Exit | Has Exit Time **on**, Exit Time `1` | none |

Without **Can Transition To Self** off, Any State → Whirlwind would start the spin again
on every frame the Bool is on, and he'd never get past its first frame.

### Do it — the boss bar

1. Set `BossBar` in `Assets/Art/UI` as **Multiple**, `100`, **Point**, **None**. The sheet
   holds three strips, each 76 × 6: the frame, the dark bar behind, and the red bar. In
   the Sprite Editor, drag out three rectangles by hand, each with **Pivot** **Center**:

| Name | Position (X, Y, W, H) |
| --- | --- |
| `Boss Bar Frame` | 0, 11, 76, 6 |
| `Boss Bar Back` | 0, 5, 76, 6 |
| `Boss Bar Fill` | 0, 0, 76, 6 |

2. On the Canvas, a **Create Empty**, `Boss Bar`, anchored bottom-center at (0, 50), 456 ×
   96. Inside it, anchored as listed, all with **Raycast Target** unticked:

| Object | Type | Anchor | Pos | Size | Shows |
| --- | --- | --- | --- | --- | --- |
| `Name` | Text - TextMeshPro | top-center | (0, 0) | 456 × 50 | `The Skeleton King`, 36 pt, centred |
| `Back` | Image | bottom-center | (0, 0) | 456 × 36 | `Boss Bar Back` |
| `Fill` | Image | bottom-center | (0, 0) | 456 × 36 | `Boss Bar Fill`, **Filled**, **Horizontal**, **Left** |
| `Frame` | Image | bottom-center | (0, 0) | 456 × 36 | `Boss Bar Frame` |

The strips are drawn at six times their size, one on top of another: the back, the red
that empties, and the frame over both.

Create `Assets/Scripts/BossBar.cs`, add it to `Boss Bar`, drag `Fill` into **Fill**, and
switch `Boss Bar` off: the king shows it.

```csharp:BossBar.cs
using UnityEngine;
using UnityEngine.UI;

// The king's health bar, shown only in his tomb: a Filled image that slides
// down to his health.
public class BossBar : MonoBehaviour
{
    [SerializeField] Image fill;
    [SerializeField] float slideSpeed = 1f;     // how much of the bar it slides in a second

    float target = 1f;

    public void Show(bool isShown)
    {
        gameObject.SetActive(isShown);
    }

    public void SetHealth(int current, int max)
    {
        target = (float)current / max;
    }

    void Update()
    {
        fill.fillAmount = Mathf.MoveTowards(fill.fillAmount, target, slideSpeed * Time.deltaTime);
    }

    public void ResetBar()
    {
        target = 1f;
        fill.fillAmount = 1f;
        Show(false);
    }
}
```

### Idea — the King's Tomb's map

Room 6 fills rows 55 to 65. It's the last room: its wall has no doorway. Its floor is the
tomb's own, dark stone.

```
        0         10
        |         |
  65    #WWWWWWWWWWWWWWWWW#
  64    #WWtWWWBWWWBWWWtWW#
  63    #,,,,,,S,,,S,,,,,,#
  62    #,,T,,,,,K,,,,,T,,#
  61    #,,,,,x,,,,,x,,,,,#
  60    #,,,,,,,,,,,,,,,,,#
  59    #,,,,,,,,,,,,,,,,,#
  58    #,,T,,,,,,,,,,,T,,#
  57    #,,,,,,,,,,,,,,,,,#
  56    #,,,,,,,,,,,,,,,,,#
  55    #########d#########
```

| Mark | Is |
| --- | --- |
| `,` | the tomb's floor |
| `K` | the Skeleton King |
| `x` | where a summoned skeleton rises |
| `S` `T` | two stone knights, four standing torches |

### Do it — paint the King's Tomb

1. A second Random Rule Tile, `Tomb Floor`, made as `Floor` was: **Default Sprite**
   `DungeonTileset_109`, one rule, **Output** **Random**, **Noise** `0.5`, and five sprites:
   `_110` (dark cobbles), `_109`, `_109`, `_109` (dark squares) and `_111` (a dark slab).
   Drag it into the palette.
2. Paint the dark, the threshold (column 9, row 55), and the tomb floor, columns 1 to 17,
   rows 56 to 63. The wall's face on rows 65 and 64, with **no** doorway: middles from
   column 2 to 16, ends at 1 and 17.
3. Two statues under `Statues and Banners`, at `(7.5, 63.15)` and `(11.5, 63.15)`, and four
   standing torches under `Torches`, at `(3.5, 62.15)`, `(15.5, 62.15)`, `(3.5, 58.15)` and
   `(15.5, 58.15)`.

### Do it — the king and his summons

1. Rename the temporary `King` GameObject `Skeleton King`, and set it up as an enemy:
   Layer **Enemy**, Sprite Sort Point **Pivot**, **Rigidbody 2D** (Dynamic, Gravity Scale
   `0`, **Mass** `5`, Freeze Rotation Z, Interpolate), and a **Capsule Collider 2D**,
   Horizontal, **Size** `(0.7, 0.3)`, **Offset** `(0, 0.15)`. Set its Animator's
   **Controller** to `Skeleton King`. Put it under `Enemies`, at `(9.5, 62.15)`.
2. Make an empty `Summon Points` with two children, `Summon Point 1` at `(6.5, 61.15)` and
   `Summon Point 2` at `(12.5, 61.15)`, and an empty `Summoned`.
3. Drag a `Skeleton` prefab into the Hierarchy at the top level (not under `Enemies`), at
   `(9.5, 60.5)`. Name it `Skeleton Template`, set its **Game** and **Hero**, its **Sight
   Range** to `12`, so it sees the hero across the whole tomb, and switch it off.

Create `Assets/Scripts/SkeletonKing.cs`, add it to `Skeleton King`, and fill in **Game**,
**Hero**, **Boss Bar**, **Skeleton Template**, the two **Summon Points** and **Summon
Group** (`Summoned`):

```csharp
using System.Collections;
using UnityEngine;

// The Skeleton King, run as a state machine in two phases. In Phase 1 he
// walks at the hero and swings. At half health he summons two skeletons,
// and Phase 2 begins: he spins at the hero in a whirlwind that turns the
// sword aside, rests, open to the sword, and spins again. His Animator is a
// copy of Humanoid, with a Whirlwind state and a Summon state added.
[RequireComponent(typeof(Rigidbody2D))]
public class SkeletonKing : MonoBehaviour
{
    public enum State { Asleep, Walk, Swing, Summon, Whirlwind, Rest, Dead }

    static readonly int DirectionHash = Animator.StringToHash("Direction");
    static readonly int SpeedHash = Animator.StringToHash("Speed");
    static readonly int AttackHash = Animator.StringToHash("Attack");
    static readonly int DeadHash = Animator.StringToHash("Dead");
    static readonly int SummonHash = Animator.StringToHash("Summon");
    static readonly int WhirlwindHash = Animator.StringToHash("Whirlwind");

    [SerializeField] CryptGame game;
    [SerializeField] HeroHealth hero;
    [SerializeField] BossBar bossBar;
    [SerializeField] Skeleton skeletonTemplate;     // a skeleton in the scene, switched off: the summon copies it
    [SerializeField] Transform[] summonPoints;
    [SerializeField] Transform summonGroup;         // where the copies go, so Restart can clear them
    [SerializeField] int maxHealth = 20;
    [SerializeField] float walkSpeed = 1.5f;
    [SerializeField] float swingRange = 1.5f;
    [SerializeField] float swingSeconds = 1f;       // as long as his Attack clip
    [SerializeField] int swingDamage = 2;           // a whole heart
    [SerializeField] float summonSeconds = 1.2f;    // as long as his Summon clip
    [SerializeField] float whirlwindSpeed = 3f;     // the hero walks at 4: he can get away
    [SerializeField] float whirlwindSeconds = 2f;
    [SerializeField] int whirlwindDamage = 1;
    [SerializeField] float restSeconds = 1.5f;

    Rigidbody2D body;
    Animator animator;
    Collider2D bodyCollider;
    SpriteRenderer spriteRenderer;
    Vector2 home;
    State state;
    Facing facing = Facing.Down;
    int health;
    bool hasSummoned;
    float stateStartTime;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        bodyCollider = GetComponent<Collider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        home = transform.position;
    }

    void Start()
    {
        ResetKing();
    }

    void Update()
    {
        if (!game.IsPlaying)
        {
            Stop();
            UpdateAnimator();
            return;
        }

        switch (state)
        {
            case State.Asleep:
                break;                  // waits for Wake, when the hero walks into the tomb
            case State.Walk:
                UpdateWalk();
                break;
            case State.Swing:
                UpdateSwing();
                break;
            case State.Summon:
                UpdateSummon();
                break;
            case State.Whirlwind:
                UpdateWhirlwind();
                break;
            case State.Rest:
                UpdateRest();
                break;
            case State.Dead:
                break;                  // waits for the OnDeathFinished Animation Event
        }
        UpdateAnimator();
    }

    void EnterState(State next)
    {
        state = next;
        stateStartTime = Time.time;

        switch (state)
        {
            case State.Asleep:
                Stop();
                break;
            case State.Walk:
                break;
            case State.Swing:
                Stop();
                FaceHero();
                animator.SetTrigger(AttackHash);
                break;
            case State.Summon:
                Stop();
                hasSummoned = true;
                animator.SetTrigger(SummonHash);
                break;
            case State.Whirlwind:
                animator.SetBool(WhirlwindHash, true);
                break;
            case State.Rest:
                Stop();
                animator.SetBool(WhirlwindHash, false);
                break;
            case State.Dead:
                Stop();
                bodyCollider.enabled = false;
                body.simulated = false;
                animator.SetTrigger(DeadHash);
                break;
        }
    }

    // The hero walked into the tomb.
    public void Wake()
    {
        if (state == State.Asleep)
        {
            bossBar.Show(true);
            EnterState(State.Walk);
        }
    }

    void UpdateWalk()
    {
        if (hero.IsDead)
        {
            Stop();
            return;
        }
        Vector2 toHero = HeroPosition() - body.position;
        if (toHero.magnitude <= swingRange)
        {
            EnterState(State.Swing);
            return;
        }
        Move(toHero.normalized * walkSpeed);
    }

    void UpdateSwing()
    {
        if (Time.time - stateStartTime >= swingSeconds)
        {
            EnterState(State.Walk);
        }
    }

    void UpdateSummon()
    {
        if (Time.time - stateStartTime >= summonSeconds)
        {
            EnterState(State.Whirlwind);
        }
    }

    // He spins after the hero, and hurts him if he gets close.
    void UpdateWhirlwind()
    {
        Vector2 toHero = HeroPosition() - body.position;
        Move(toHero.normalized * whirlwindSpeed);
        if (toHero.magnitude < 1f)
        {
            hero.TakeDamage(whirlwindDamage, body.position);
        }
        if (Time.time - stateStartTime >= whirlwindSeconds)
        {
            EnterState(State.Rest);
        }
    }

    void UpdateRest()
    {
        if (Time.time - stateStartTime >= restSeconds)
        {
            EnterState(State.Whirlwind);
        }
    }

    // Animation Event: his sword's hit frame, on all four Attack clips.
    public void OnAttackHit()
    {
        if (state != State.Swing)
        {
            return;
        }
        Vector2 front = body.position + Facings.ToVector(facing) * 0.8f;
        if (Vector2.Distance(front, HeroPosition()) < 1.1f)
        {
            hero.TakeDamage(swingDamage, body.position);
        }
    }

    // Animation Event: the Summon clip's frame where the golden ring spreads.
    // Each copy of the template is a whole skeleton, already wired up.
    public void OnSummon()
    {
        foreach (Transform point in summonPoints)
        {
            Skeleton skeleton = Instantiate(skeletonTemplate, point.position, Quaternion.identity, summonGroup);
            skeleton.gameObject.SetActive(true);
        }
    }

    // The hero's sword hit him. Returns false when it can't hurt him: asleep,
    // summoning, spinning or dead, the sword just clangs.
    public bool TakeHit(int damage, Vector2 from)
    {
        if (state != State.Walk && state != State.Swing && state != State.Rest)
        {
            return false;
        }

        health = Mathf.Max(health - damage, 0);
        bossBar.SetHealth(health, maxHealth);
        StartCoroutine(Flicker());

        if (health == 0)
        {
            EnterState(State.Dead);
        }
        else if (!hasSummoned && health <= maxHealth / 2)
        {
            EnterState(State.Summon);
        }
        return true;
    }

    // He's too heavy to be knocked back: he flickers, so the hit shows.
    IEnumerator Flicker()
    {
        for (int i = 0; i < 3; i++)
        {
            spriteRenderer.enabled = false;
            yield return new WaitForSeconds(0.05f);
            spriteRenderer.enabled = true;
            yield return new WaitForSeconds(0.05f);
        }
    }

    // Animation Event: at the end of his Dead clips. The crypt is won.
    public void OnDeathFinished()
    {
        bossBar.Show(false);
        game.Win();
        gameObject.SetActive(false);
    }

    public void ResetKing()
    {
        StopAllCoroutines();
        foreach (Skeleton skeleton in summonGroup.GetComponentsInChildren<Skeleton>(true))
        {
            Destroy(skeleton.gameObject);
        }

        gameObject.SetActive(true);
        body.simulated = true;
        body.position = home;
        transform.position = home;
        body.linearVelocity = Vector2.zero;
        bodyCollider.enabled = true;
        spriteRenderer.enabled = true;
        spriteRenderer.color = Color.white;
        animator.Rebind();

        health = maxHealth;
        hasSummoned = false;
        facing = Facing.Down;
        bossBar.ResetBar();
        EnterState(State.Asleep);
    }

    Vector2 HeroPosition()
    {
        return hero.transform.position;
    }

    void Move(Vector2 velocity)
    {
        body.linearVelocity = velocity;
        facing = Facings.FromVector(velocity, facing);
    }

    void Stop()
    {
        body.linearVelocity = Vector2.zero;
    }

    void FaceHero()
    {
        facing = Facings.FromVector(HeroPosition() - body.position, facing);
    }

    void UpdateAnimator()
    {
        animator.SetInteger(DirectionHash, (int)facing);
        animator.SetFloat(SpeedHash, body.linearVelocity.magnitude);
    }
}
```

Read it before you move on:

- `Asleep` does nothing at all in `Update`: `Wake` is called from outside, by the game.
- `UpdateWhirlwind` moves him, and hurts the hero if he's within 1 unit: `TakeDamage`
  itself ignores a hero who's blinking, so the spin costs half a heart at a time.
- In `TakeHit`, the first `if` is the king's armour: only Walk, Swing and Rest can be hurt.
  `hasSummoned` makes the summon happen once.
- `OnSummon` copies the template once for each summon point, and switches each copy on.
- `ResetKing` destroys the summoned skeletons first, then puts him back asleep, and his bar
  away.

Drag `Skeleton King` into `Assets/Prefabs`.

### Do it — the clang, and the game wakes him

Replace `HeroCombat`:

```csharp
using UnityEngine;

// The hero's sword. An attack starts the Attack clip, and the clip's hit
// frame calls OnAttackHit: only then does the sword hurt what's in front.
public class HeroCombat : MonoBehaviour
{
    static readonly int AttackHash = Animator.StringToHash("Attack");

    [SerializeField] LayerMask enemyMask;
    [SerializeField] int damage = 1;
    [SerializeField] float attackSeconds = 0.5f;    // as long as the Attack clip
    [SerializeField] float hitDistance = 0.7f;      // how far in front of his middle the sword's circle is
    [SerializeField] float hitRadius = 0.6f;

    // His body's middle, above his feet: the sword's circle is measured from here.
    readonly Vector2 middle = new Vector2(0f, 0.4f);

    Animator animator;
    Vector2 attackDirection;
    float attackEndTime;

    public bool IsAttacking
    {
        get { return Time.time < attackEndTime; }
    }

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // An attack the way he faces: direction is Facings.ToVector of his facing.
    public void Attack(Vector2 direction)
    {
        if (IsAttacking)
        {
            return;
        }
        attackDirection = direction;
        attackEndTime = Time.time + attackSeconds;
        animator.SetTrigger(AttackHash);
    }

    // Animation Event: the sword's hit frame, on all four Attack clips.
    // Everything on the Enemy layer inside the circle is hit.
    public void OnAttackHit()
    {
        Vector2 front = (Vector2)transform.position + middle + attackDirection * hitDistance;
        Collider2D[] hits = Physics2D.OverlapCircleAll(front, hitRadius, enemyMask);
        foreach (Collider2D hit in hits)
        {
            if (hit.TryGetComponent(out Skeleton skeleton))
            {
                skeleton.TakeHit(damage, transform.position);
            }
            else if (hit.TryGetComponent(out Archer archer))
            {
                archer.TakeHit(damage, transform.position);
            }
            else if (hit.TryGetComponent(out SkeletonKing king) && !king.TakeHit(damage, transform.position))
            {
                Debug.Log("Clang: the sword can't hurt the king now");
            }
        }
    }

    public void ResetCombat()
    {
        attackEndTime = 0f;
    }
}
```

Replace `CryptGame`, and drag `Skeleton King` into its new **King** field:

```csharp
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

// Runs the game as a state machine: Start, Playing, Paused, Won and Lost. It
// knows which room the hero is in, wakes the king in his tomb, counts the
// time, and puts the whole crypt back on Restart.
public class CryptGame : MonoBehaviour
{
    public enum GameState { Start, Playing, Paused, Won, Lost }

    [SerializeField] Hero hero;
    [SerializeField] HeroHealth heroHealth;
    [SerializeField] HeroCombat heroCombat;
    [SerializeField] Inventory inventory;
    [SerializeField] RoomCamera roomCamera;
    [SerializeField] Room[] rooms;
    [SerializeField] float roomHeight = 11f;    // the rooms are stacked, the first at the bottom
    [SerializeField] SkeletonKing king;
    [SerializeField] Transform enemies;
    [SerializeField] Transform chests;
    [SerializeField] Transform doors;
    [SerializeField] Transform pickups;
    [SerializeField] Transform arrows;
    [SerializeField] TMP_Text roomText;
    [SerializeField] TMP_Text messageText;
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
    float playTime;
    Vector2 startPoint;
    int roomIndex = -1;
    Coroutine roomFade;
    Coroutine messageFade;

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
        startPoint = hero.transform.position;
        roomText.text = "";
        messageText.text = "";
        roomCamera.SnapTo(rooms[0].Centre);
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
                UpdateRoom();
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
                winText.text = $"The Skeleton King has fallen!\n\nGold: {inventory.Gold}\nTime: {FormatTime(playTime)}";
                break;
            case GameState.Lost:
                break;
        }
    }

    // Puts the whole crypt back as it was at the start, then plays.
    public void Restart()
    {
        playTime = 0f;
        roomIndex = -1;

        foreach (Skeleton skeleton in enemies.GetComponentsInChildren<Skeleton>(true))
        {
            skeleton.ResetSkeleton();
        }
        foreach (Archer archer in enemies.GetComponentsInChildren<Archer>(true))
        {
            archer.ResetArcher();
        }
        king.ResetKing();
        foreach (Arrow arrow in arrows.GetComponentsInChildren<Arrow>())
        {
            Destroy(arrow.gameObject);
        }
        foreach (Chest chest in chests.GetComponentsInChildren<Chest>(true))
        {
            chest.ResetChest();
        }
        foreach (Door door in doors.GetComponentsInChildren<Door>(true))
        {
            door.ResetDoor();
        }
        foreach (Pickup pickup in pickups.GetComponentsInChildren<Pickup>(true))
        {
            pickup.ResetPickup();
        }

        hero.ResetHero(startPoint);
        heroHealth.ResetHealth();
        heroCombat.ResetCombat();
        inventory.ResetInventory();
        roomCamera.SnapTo(rooms[0].Centre);
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

    // The rooms are stacked roomHeight units apart, so the height of the
    // hero's feet says which room he's in: 0 for the first, 1 for the next.
    void UpdateRoom()
    {
        int index = Mathf.FloorToInt(hero.transform.position.y / roomHeight);
        index = Mathf.Clamp(index, 0, rooms.Length - 1);
        if (index == roomIndex)
        {
            return;
        }

        roomIndex = index;
        roomCamera.MoveTo(rooms[index].Centre);
        if (roomFade != null)
        {
            StopCoroutine(roomFade);
        }
        roomFade = StartCoroutine(FadeText(roomText, rooms[index].Title));

        if (rooms[index].HasBoss)
        {
            king.Wake();
        }
    }

    // A line at the bottom of the screen, such as "Locked: find a key".
    public void ShowMessage(string message)
    {
        if (messageFade != null)
        {
            StopCoroutine(messageFade);
        }
        messageFade = StartCoroutine(FadeText(messageText, message));
    }

    // Shows the text for two seconds, then fades it out over one.
    IEnumerator FadeText(TMP_Text label, string text)
    {
        label.text = text;
        label.alpha = 1f;
        yield return new WaitForSeconds(2f);
        for (float t = 0f; t < 1f; t += Time.deltaTime)
        {
            label.alpha = 1f - t;
            yield return null;
        }
        label.text = "";
    }

    bool WasPausePressed()
    {
        Keyboard keyboard = Keyboard.current;
        return keyboard != null && (keyboard.escapeKey.wasPressedThisFrame || keyboard.pKey.wasPressedThisFrame);
    }

    // 161.4 seconds becomes "2:41".
    static string FormatTime(float seconds)
    {
        int whole = Mathf.FloorToInt(seconds);
        return $"{whole / 60}:{whole % 60:00}";
    }
}
```

When the hero's room is the one with **Has Boss** ticked, `UpdateRoom` wakes the king; and
`Restart` puts him back.

### Test it

Play through the crypt to the tomb. (To test quickly, start the hero at `(9.5, 56.5, 0)`,
in the tomb, and put him back at `(9.5, 2.15, 0)` when you're done.)

- He wakes as you come in, and his bar shows. He walks at you and swings: two slashes,
  each a whole heart. Step back after the first, and the second still catches you.
- Hit him: he flickers, and the bar slides down.
- At half the bar, he strikes the floor, the ring spreads, and two skeletons rise from the
  summon points and come at you. Hit him while he summons: *Clang* in the Console.
- Then he spins after you. Hit him while he spins: *Clang*. Run: you're faster. When he
  stops, dizzy, hit him: the bar goes down again.
- When the bar is empty, he falls, fades, and the win panel shows: the gold you found and
  your time. **Play Again** puts it all back, him asleep on his tomb.

### Challenge

Add a third phase: below a quarter of his health, his whirlwind speeds up to `4`, as fast
as the hero, and his rest shrinks to `1` second. You need only one new `bool`, and two
lines in `TakeHit` and `EnterState`. Is he still fair? What would make a third phase feel
different, not only harder?

## Chapter 14 — Torchlight and Sound

**Goal:** the crypt goes dark. Torches on the walls and on their tripods light it in warm
circles, flickering, and the hero carries a faint light of his own. Every swing, hit,
bone, key, door and chest gets its sound, and music plays: `Crypt` in the rooms, `Fight`
in the King's Tomb.

### Idea — 2D lights

URP's 2D Renderer lights sprites with **Light 2D** components. Every sprite with the
template's material, **Sprite-Lit-Default**, is lit by them; the UI isn't.

| Light 2D | Lights | Here |
| --- | --- | --- |
| **Global** | everything, evenly | the dark: Intensity `0.35`, a cold grey-blue, `#A7B0D8` |
| **Spot Light** | a circle: full inside its **Inner** radius, fading to nothing at its **Outer** | a torch: `#FF9A40`, Intensity `1.2`, radius 0.9 to 4.5 |

Lights add up: in the dark, a torch's circle is warm and bright, and the floor between two
torches is lit by both.

### Idea — a flicker, with no code

A torch flickers because its light's **Intensity** goes up and down a little, never twice
the same in a second. That's a property clip, as the door's leaves were, on the light
instead of a Transform: in the Animation window, any property of any component can be
animated.

| Time (30 samples) | `0:00` | `0:06` | `0:09` | `0:15` | `0:21` | `0:24` | `1:00` |
| --- | --- | --- | --- | --- | --- | --- | --- |
| Intensity | 1.2 | 1 | 1.3 | 1.1 | 1.35 | 1.05 | 1.2 |

The clip loops, and its last key equals its first, so the loop has no jump.

### Do it — the dark

Select **Global Light 2D**, which the Universal 2D template put in the scene. Set its
**Intensity** to `0.35` and its **Color** to `#A7B0D8`. Press **Play** for a moment: the
crypt is dark, and hard to see in. Time for the torches.

### Do it — a standing torch that burns

1. Double-click the `Standing Torch` prefab to open it. Right-click its root → **Light →
   Spot Light 2D**: a child light. Rename it `Flame`, and set its **Position** to
   `(0, 1.15, 0)`, on the brazier. Set **Color** `#FF9A40`, **Intensity** `1.2`, and
   **Radius** **Inner** `0.9`, **Outer** `4.5`.
2. Select the prefab's root, and in the Animation window click **Create**: save `Torch
   Flicker`, at 30 samples, looping. **Add Property → Flame → Light 2D → Intensity**, and
   make the keys in the table. Unity makes a controller named after the prefab: rename it
   `Torch`.
3. Close the prefab: every standing torch in the crypt burns now.

### Do it — wall torches and banners

1. Cut two more sprites out of `DungeonTileset`:

| Name | Position (X, Y, W, H) | Custom Pivot (pixels) |
| --- | --- | --- |
| `Wall Torch` | 488, 208, 16, 32 | (8, 0) |
| `Banner` | 480, 128, 32, 64 | (16, 0) |

2. Make a `Wall Torch` prefab like the standing torch, but with no collider (it's on the
   wall), and its `Flame` at `(0, 0.7, 0)`, with the same light. Give it an Animator with
   the `Torch` controller.
3. Make a `Banner` prefab: just its sprite, **Sprite Sort Point** **Pivot**.
4. Put them on the walls: wall torches under `Torches`, banners under `Statues and
   Banners`. The wall's bottom row is 9 rows up each room, so a wall torch stands at that
   row plus `0.4`, and a banner at that row plus `0.1`:

| Room | Wall torches | Banners |
| --- | --- | --- |
| 1 | (3.5, 9.4), (15.5, 9.4) | (6.5, 9.1), (12.5, 9.1) |
| 2 | (4.5, 20.4), (14.5, 20.4) | |
| 3 | (4.5, 31.4), (14.5, 31.4) | |
| 4 | (3.5, 42.4), (15.5, 42.4) | (6.5, 42.1), (12.5, 42.1) |
| 5 | (6.5, 53.4), (12.5, 53.4) | (3.5, 53.1), (15.5, 53.1) |
| 6 | (3.5, 64.4), (15.5, 64.4) | (7.5, 64.1), (11.5, 64.1) |

### Do it — the hero's own light

Right-click `Hero` → **Light → Spot Light 2D**, rename it `Light`, at `(0, 0.5, 0)`:
**Color** `#FFE3B8`, **Intensity** `0.6`, **Radius** **Inner** `0.6`, **Outer** `3`. A
hero who walks away from the torches still sees the floor at his feet.

### Idea — sounds on the events

Each sound plays from an **Audio Source** on the object it belongs to, with
`audioSource.PlayOneShot(clip)`: one source can play many sounds at once. Most of them hang
on moments the scripts already have:

| Sound | Plays in | When |
| --- | --- | --- |
| `Swing` | `HeroCombat.Attack`, `SkeletonKing`'s Swing | a swing starts |
| `Clang` | `HeroCombat.OnAttackHit` | the king turns the sword aside |
| `Hurt`, `Heal` | `HeroHealth` | a hit; a potion |
| `Hit`, `Bones` | `Skeleton`, `Archer`, `SkeletonKing` | the sword hits; a fall |
| `Shoot` | `Archer.OnAttackHit` | the release frame |
| `Door`, `Chest` | `Door`, `Chest` | they open |
| `Key`, `Potion`, `Gold` | `Pickup`, through `Inventory.PlaySound` | picked up |
| `Summon`, `Whirl` | `SkeletonKing` | the summon; a spin starts |
| `Win`, `Lose` | `CryptGame` | the end |

A pickup can't play its own sound: it switches itself off the moment it's picked up, and a
switched-off object makes no sound. So it asks the hero's `Inventory` to play it.

The music starts on **Play**, not as the scene loads: a web browser lets a page make sound
only after the player has clicked something.

### Do it — the Audio Sources

Add an **Audio Source**, with **Play On Awake** unticked, to `Hero`, and to the `Skeleton`,
`Archer`, `Skeleton King`, `Door` and `Chest` prefabs. Give `Crypt Game` two: the first for
sounds, the second for music, with **Loop** ticked and **Volume** `0.5`.

### Do it — the scripts, with sound

These are the last versions of ten scripts. Replace each one, and fill in its new fields
from `Assets/Audio` (the prefabs' fields in the prefabs, so every copy gets them).

`Inventory` plays the pickups' sounds:

```csharp:Inventory.cs
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// What the hero carries: keys, the boss key, up to three potions, and gold.
// It keeps the screen's key count, potion slots and gold up to date.
public class Inventory : MonoBehaviour
{
    public const int MaxPotions = 3;

    [SerializeField] HeroHealth health;
    [SerializeField] TMP_Text keyText;
    [SerializeField] Image bossKeyIcon;
    [SerializeField] TMP_Text goldText;
    [SerializeField] Image[] potionIcons;       // the three slots' potions
    [SerializeField] Button[] potionButtons;    // tap a slot to drink
    [SerializeField] int potionHealing = 2;     // a whole heart

    AudioSource audioSource;
    int keys;
    bool hasBossKey;
    int potions;

    public int Gold { get; private set; }

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnEnable()
    {
        foreach (Button button in potionButtons)
        {
            button.onClick.AddListener(DrinkPotion);
        }
    }

    void OnDisable()
    {
        foreach (Button button in potionButtons)
        {
            button.onClick.RemoveListener(DrinkPotion);
        }
    }

    void Start()
    {
        UpdateScreen();
    }

    public void AddKey()
    {
        keys++;
        UpdateScreen();
    }

    public void AddBossKey()
    {
        hasBossKey = true;
        UpdateScreen();
    }

    // False when he already carries three: the potion stays where it is.
    public bool AddPotion()
    {
        if (potions >= MaxPotions)
        {
            return false;
        }
        potions++;
        UpdateScreen();
        return true;
    }

    public void AddGold(int amount)
    {
        Gold += amount;
        UpdateScreen();
    }

    // A door asks for a key: true if there was one to use.
    public bool UseKey()
    {
        if (keys == 0)
        {
            return false;
        }
        keys--;
        UpdateScreen();
        return true;
    }

    public bool UseBossKey()
    {
        if (!hasBossKey)
        {
            return false;
        }
        hasBossKey = false;
        UpdateScreen();
        return true;
    }

    // Q, or a tap on a potion slot. A whole heart back, if there's a potion
    // and he has a heart to lose.
    public void DrinkPotion()
    {
        if (potions == 0 || health.IsDead || health.IsFull)
        {
            return;
        }
        potions--;
        health.Heal(potionHealing);
        UpdateScreen();
    }

    // Pickups play their sound here: a picked-up pickup is hidden at once,
    // and a hidden object can't play anything.
    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }

    void UpdateScreen()
    {
        keyText.text = $"x {keys}";
        bossKeyIcon.enabled = hasBossKey;
        goldText.text = Gold.ToString();
        for (int i = 0; i < potionIcons.Length; i++)
        {
            potionIcons[i].enabled = i < potions;
        }
    }

    public void ResetInventory()
    {
        keys = 0;
        hasBossKey = false;
        potions = 0;
        Gold = 0;
        UpdateScreen();
    }
}
```

`Pickup`: give the `Key` and `Boss Key` prefabs `Key`, the `Potion` prefab `Potion`, and the
`Gold` prefab `Gold`.

```csharp:Pickup.cs
using UnityEngine;

// A key, the boss key, a potion or a pile of gold: one script for all four.
// Its Kind says which, and a switch does the rest.
public class Pickup : MonoBehaviour
{
    public enum Kind { Key, BossKey, Potion, Gold }

    [SerializeField] Kind kind;
    [SerializeField] int gold = 25;             // for Gold only
    [SerializeField] bool startsHidden;         // loot waits, hidden, until its chest opens
    [SerializeField] AudioClip pickupSound;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.TryGetComponent(out Inventory inventory))
        {
            return;
        }

        switch (kind)
        {
            case Kind.Key:
                inventory.AddKey();
                break;
            case Kind.BossKey:
                inventory.AddBossKey();
                break;
            case Kind.Potion:
                if (!inventory.AddPotion())
                {
                    return;     // he carries three already: it waits for later
                }
                break;
            case Kind.Gold:
                inventory.AddGold(gold);
                break;
        }
        inventory.PlaySound(pickupSound);
        gameObject.SetActive(false);
    }

    public void ResetPickup()
    {
        gameObject.SetActive(!startsHidden);
    }
}
```

`HeroCombat`: **Swing Sound** `Swing`, **Clang Sound** `Clang`.

```csharp:HeroCombat.cs
using UnityEngine;

// The hero's sword. An attack starts the Attack clip, and the clip's hit
// frame calls OnAttackHit: only then does the sword hurt what's in front.
public class HeroCombat : MonoBehaviour
{
    static readonly int AttackHash = Animator.StringToHash("Attack");

    [SerializeField] LayerMask enemyMask;
    [SerializeField] AudioClip swingSound;
    [SerializeField] AudioClip clangSound;          // the king's whirlwind turns the sword aside
    [SerializeField] int damage = 1;
    [SerializeField] float attackSeconds = 0.5f;    // as long as the Attack clip
    [SerializeField] float hitDistance = 0.7f;      // how far in front of his middle the sword's circle is
    [SerializeField] float hitRadius = 0.6f;

    // His body's middle, above his feet: the sword's circle is measured from here.
    readonly Vector2 middle = new Vector2(0f, 0.4f);

    Animator animator;
    AudioSource audioSource;
    Vector2 attackDirection;
    float attackEndTime;

    public bool IsAttacking
    {
        get { return Time.time < attackEndTime; }
    }

    void Awake()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // An attack the way he faces: direction is Facings.ToVector of his facing.
    public void Attack(Vector2 direction)
    {
        if (IsAttacking)
        {
            return;
        }
        attackDirection = direction;
        attackEndTime = Time.time + attackSeconds;
        animator.SetTrigger(AttackHash);
        audioSource.PlayOneShot(swingSound);
    }

    // Animation Event: the sword's hit frame, on all four Attack clips.
    // Everything on the Enemy layer inside the circle is hit.
    public void OnAttackHit()
    {
        Vector2 front = (Vector2)transform.position + middle + attackDirection * hitDistance;
        Collider2D[] hits = Physics2D.OverlapCircleAll(front, hitRadius, enemyMask);
        foreach (Collider2D hit in hits)
        {
            if (hit.TryGetComponent(out Skeleton skeleton))
            {
                skeleton.TakeHit(damage, transform.position);
            }
            else if (hit.TryGetComponent(out Archer archer))
            {
                archer.TakeHit(damage, transform.position);
            }
            else if (hit.TryGetComponent(out SkeletonKing king) && !king.TakeHit(damage, transform.position))
            {
                audioSource.PlayOneShot(clangSound);
            }
        }
    }

    public void ResetCombat()
    {
        attackEndTime = 0f;
    }
}
```

`HeroHealth`: **Hurt Sound** `Hurt`, **Heal Sound** `Heal`.

```csharp:HeroHealth.cs
using System.Collections;
using UnityEngine;

// The hero's health, counted in half hearts: 6 is three whole hearts. A hit
// knocks him back and makes him blink, and nothing can hurt him while he
// blinks. At 0 he falls, and when his Dead clip ends, the game is lost.
public class HeroHealth : MonoBehaviour
{
    public const int MaxHealth = 6;

    static readonly int HurtHash = Animator.StringToHash("Hurt");
    static readonly int DeadHash = Animator.StringToHash("Dead");

    [SerializeField] CryptGame game;
    [SerializeField] HeartsBar hearts;
    [SerializeField] AudioClip hurtSound;
    [SerializeField] AudioClip healSound;
    [SerializeField] float knockbackSpeed = 6f;
    [SerializeField] float stunSeconds = 0.2f;      // no control, while the knockback carries him
    [SerializeField] float blinkSeconds = 1f;

    Rigidbody2D body;
    Animator animator;
    SpriteRenderer spriteRenderer;
    AudioSource audioSource;
    bool isBlinking;
    float stunnedUntil;

    public int Health { get; private set; } = MaxHealth;
    public bool IsDead { get; private set; }

    public bool IsStunned
    {
        get { return Time.time < stunnedUntil; }
    }

    public bool IsFull
    {
        get { return Health == MaxHealth; }
    }

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
    }

    void Start()
    {
        hearts.SetHealth(Health);
    }

    // Something hurt him. from is where it was, so he's knocked away from it.
    public void TakeDamage(int amount, Vector2 from)
    {
        // Nothing hurts him while he blinks, or once he has fallen, or when
        // the game isn't being played.
        if (IsDead || isBlinking || !game.IsPlaying)
        {
            return;
        }

        Health = Mathf.Max(Health - amount, 0);
        hearts.SetHealth(Health);
        audioSource.PlayOneShot(hurtSound);

        if (Health == 0)
        {
            IsDead = true;
            body.linearVelocity = Vector2.zero;
            animator.SetTrigger(DeadHash);
            return;
        }

        Vector2 away = (body.position - from).normalized;
        body.linearVelocity = away * knockbackSpeed;
        stunnedUntil = Time.time + stunSeconds;
        animator.SetTrigger(HurtHash);
        StartCoroutine(Blink());
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
        hearts.SetHealth(Health);
        audioSource.PlayOneShot(healSound);
    }

    // Animation Event: at the end of the Dead clips.
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
        hearts.SetHealth(Health);
    }
}
```

`Chest`: **Open Sound** `Chest`.

```csharp:Chest.cs
using UnityEngine;

// A chest. Open sets the Open trigger; the Opening clip's lid-up frame calls
// OnLootReady, and the loot waiting in front of the chest appears just then.
public class Chest : MonoBehaviour
{
    static readonly int OpenHash = Animator.StringToHash("Open");

    [SerializeField] GameObject[] loot;     // hidden pickups, placed in front of the chest
    [SerializeField] AudioClip openSound;

    Animator animator;
    AudioSource audioSource;

    public bool IsOpen { get; private set; }

    void Awake()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    public void Open()
    {
        if (IsOpen)
        {
            return;
        }
        IsOpen = true;
        animator.SetTrigger(OpenHash);
        audioSource.PlayOneShot(openSound);
    }

    // Animation Event: the Opening clip's last frame, as the lid comes up.
    public void OnLootReady()
    {
        foreach (GameObject item in loot)
        {
            item.SetActive(true);
        }
    }

    public void ResetChest()
    {
        IsOpen = false;
        foreach (GameObject item in loot)
        {
            item.SetActive(false);
        }
        animator.Rebind();
    }
}
```

`Door`: **Open Sound** `Door`.

```csharp:Door.cs
using UnityEngine;

// A locked door. Walk into it carrying a key, and it opens: the Open Bool
// starts its Opening clip, whose last frame calls OnDoorOpened, and only
// then does the doorway stop blocking the way.
public class Door : MonoBehaviour
{
    static readonly int OpenHash = Animator.StringToHash("Open");

    [SerializeField] CryptGame game;
    [SerializeField] bool needsBossKey;
    [SerializeField] Collider2D blocker;
    [SerializeField] AudioClip openSound;

    Animator animator;
    AudioSource audioSource;
    bool isOpen;

    void Awake()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (isOpen || !collision.gameObject.TryGetComponent(out Inventory inventory))
        {
            return;
        }

        bool hasKey = needsBossKey ? inventory.UseBossKey() : inventory.UseKey();
        if (!hasKey)
        {
            game.ShowMessage(needsBossKey ? "The boss key opens this door" : "Locked: find a key");
            return;
        }

        isOpen = true;
        animator.SetBool(OpenHash, true);
        audioSource.PlayOneShot(openSound);
    }

    // Animation Event: the Opening clip's last frame, once the door is open.
    public void OnDoorOpened()
    {
        blocker.enabled = false;
    }

    public void ResetDoor()
    {
        isOpen = false;
        blocker.enabled = true;
        animator.SetBool(OpenHash, false);
        animator.Rebind();
    }
}
```

`Skeleton`: **Hit Sound** `Hit`, **Death Sound** `Bones`. The template skeleton is a copy
of the prefab, so it gets them too.

```csharp:Skeleton.cs
using UnityEngine;

// A skeleton with a sword, run as a state machine. The code decides what it
// does; its Animator, the hero's Humanoid controller with the skeleton's own
// clips, only shows the body: which way it faces, how fast it walks, and an
// attack, a hurt or a fall when one happens.
[RequireComponent(typeof(Rigidbody2D))]
public class Skeleton : MonoBehaviour
{
    public enum State { Idle, Patrol, Chase, Attack, Hurt, Dead }

    static readonly int DirectionHash = Animator.StringToHash("Direction");
    static readonly int SpeedHash = Animator.StringToHash("Speed");
    static readonly int AttackHash = Animator.StringToHash("Attack");
    static readonly int HurtHash = Animator.StringToHash("Hurt");
    static readonly int DeadHash = Animator.StringToHash("Dead");

    [SerializeField] CryptGame game;
    [SerializeField] HeroHealth hero;
    [SerializeField] LayerMask wallMask;
    [SerializeField] AudioClip hitSound;
    [SerializeField] AudioClip deathSound;
    [SerializeField] int maxHealth = 3;
    [SerializeField] float patrolSpeed = 1.5f;
    [SerializeField] float patrolDistance = 2f;     // how far it wanders from where it started
    [SerializeField] float chaseSpeed = 2.5f;
    [SerializeField] float sightRange = 5f;
    [SerializeField] float attackRange = 1f;
    [SerializeField] float attackSeconds = 0.7f;    // as long as the Attack clip
    [SerializeField] float hurtSeconds = 0.4f;
    [SerializeField] float knockbackSpeed = 4f;

    Rigidbody2D body;
    Animator animator;
    Collider2D bodyCollider;
    SpriteRenderer spriteRenderer;
    AudioSource audioSource;
    Vector2 home;
    Vector2 patrolTarget;
    State state;
    Facing facing = Facing.Down;
    int health;
    float stateStartTime;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        bodyCollider = GetComponent<Collider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
        home = transform.position;
    }

    void Start()
    {
        ResetSkeleton();
    }

    void Update()
    {
        // Before Play, after the end and in the pause menu, skeletons wait.
        if (!game.IsPlaying)
        {
            Stop();
            UpdateAnimator();
            return;
        }

        switch (state)
        {
            case State.Idle:
                UpdateIdle();
                break;
            case State.Patrol:
                UpdatePatrol();
                break;
            case State.Chase:
                UpdateChase();
                break;
            case State.Attack:
                UpdateAttack();
                break;
            case State.Hurt:
                UpdateHurt();
                break;
            case State.Dead:
                break;                  // waits for the OnDeathFinished Animation Event
        }
        UpdateAnimator();
    }

    // The one place the state changes. The enter step runs once, as the
    // skeleton arrives in its new state.
    void EnterState(State next)
    {
        state = next;
        stateStartTime = Time.time;

        switch (state)
        {
            case State.Idle:
                Stop();
                break;
            case State.Patrol:
                patrolTarget = home + Random.insideUnitCircle * patrolDistance;
                break;
            case State.Chase:
                break;
            case State.Attack:
                Stop();
                FaceHero();
                animator.SetTrigger(AttackHash);
                break;
            case State.Hurt:
                animator.SetTrigger(HurtHash);
                break;
            case State.Dead:
                Stop();
                bodyCollider.enabled = false;
                body.simulated = false;
                animator.SetTrigger(DeadHash);
                audioSource.PlayOneShot(deathSound);
                break;
        }
    }

    void UpdateIdle()
    {
        if (CanSeeHero())
        {
            EnterState(State.Chase);
        }
        else if (Time.time - stateStartTime > 1.5f)
        {
            EnterState(State.Patrol);
        }
    }

    void UpdatePatrol()
    {
        if (CanSeeHero())
        {
            EnterState(State.Chase);
            return;
        }

        Vector2 toTarget = patrolTarget - body.position;
        if (toTarget.magnitude < 0.1f || Time.time - stateStartTime > 3f)
        {
            EnterState(State.Idle);
            return;
        }
        Move(toTarget.normalized * patrolSpeed);
    }

    // Chase starts within sightRange, but only gives up beyond twice that:
    // with one number for both, a hero standing right at the edge would make
    // the skeleton flip between the two states every frame.
    void UpdateChase()
    {
        Vector2 toHero = HeroPosition() - body.position;
        if (hero.IsDead || toHero.magnitude > sightRange * 2f)
        {
            EnterState(State.Idle);
            return;
        }
        if (toHero.magnitude <= attackRange)
        {
            EnterState(State.Attack);
            return;
        }
        Move(toHero.normalized * chaseSpeed);
    }

    void UpdateAttack()
    {
        if (Time.time - stateStartTime >= attackSeconds)
        {
            EnterState(State.Chase);
        }
    }

    // The knockback carries it for a moment; then it decides between Chase
    // and Dead.
    void UpdateHurt()
    {
        if (Time.time - stateStartTime > 0.15f)
        {
            Stop();
        }
        if (Time.time - stateStartTime >= hurtSeconds)
        {
            EnterState(health > 0 ? State.Chase : State.Dead);
        }
    }

    // Animation Event: the sword's hit frame. The hero is only hurt if he's
    // still in front of the skeleton, so stepping back at the right moment works.
    public void OnAttackHit()
    {
        if (state != State.Attack)
        {
            return;
        }
        Vector2 front = body.position + Facings.ToVector(facing) * 0.6f;
        if (Vector2.Distance(front, HeroPosition()) < 0.8f)
        {
            hero.TakeDamage(1, body.position);
        }
    }

    // The hero's sword hit it.
    public void TakeHit(int damage, Vector2 from)
    {
        if (state == State.Hurt || state == State.Dead)
        {
            return;
        }
        health -= damage;
        audioSource.PlayOneShot(hitSound);
        body.linearVelocity = (body.position - from).normalized * knockbackSpeed;
        EnterState(State.Hurt);
    }

    // Animation Event: at the end of the Dead clips, once it has faded.
    public void OnDeathFinished()
    {
        gameObject.SetActive(false);
    }

    // Back where it started, whole again: on Restart.
    public void ResetSkeleton()
    {
        gameObject.SetActive(true);
        body.simulated = true;
        body.position = home;
        transform.position = home;
        body.linearVelocity = Vector2.zero;
        bodyCollider.enabled = true;

        // The Dead clip fades it out. Put its colour back before Rebind
        // remembers it.
        spriteRenderer.color = Color.white;
        animator.Rebind();

        health = maxHealth;
        facing = Facing.Down;
        EnterState(State.Idle);
    }

    bool CanSeeHero()
    {
        Vector2 heroPosition = HeroPosition();
        if (hero.IsDead || Vector2.Distance(body.position, heroPosition) > sightRange)
        {
            return false;
        }
        // A wall between them blocks the view.
        return !Physics2D.Linecast(body.position, heroPosition, wallMask);
    }

    Vector2 HeroPosition()
    {
        return hero.transform.position;
    }

    void Move(Vector2 velocity)
    {
        body.linearVelocity = velocity;
        facing = Facings.FromVector(velocity, facing);
    }

    void Stop()
    {
        body.linearVelocity = Vector2.zero;
    }

    void FaceHero()
    {
        facing = Facings.FromVector(HeroPosition() - body.position, facing);
    }

    void UpdateAnimator()
    {
        animator.SetInteger(DirectionHash, (int)facing);
        animator.SetFloat(SpeedHash, body.linearVelocity.magnitude);
    }
}
```

`Archer`: **Shoot Sound** `Shoot`, **Hit Sound** `Hit`, **Death Sound** `Bones`.

```csharp:Archer.cs
using UnityEngine;

// A skeleton archer, run as a state machine. It keeps its distance, shoots
// when it can see the hero, then steps aside before shooting again. Its
// Animator is the Humanoid controller, with the archer's own clips.
[RequireComponent(typeof(Rigidbody2D))]
public class Archer : MonoBehaviour
{
    public enum State { Idle, KeepDistance, Shoot, Reposition, Hurt, Dead }

    static readonly int DirectionHash = Animator.StringToHash("Direction");
    static readonly int SpeedHash = Animator.StringToHash("Speed");
    static readonly int AttackHash = Animator.StringToHash("Attack");
    static readonly int HurtHash = Animator.StringToHash("Hurt");
    static readonly int DeadHash = Animator.StringToHash("Dead");

    [SerializeField] CryptGame game;
    [SerializeField] HeroHealth hero;
    [SerializeField] Arrow arrowPrefab;
    [SerializeField] Transform arrowGroup;          // where its arrows go, so Restart can clear them
    [SerializeField] LayerMask wallMask;
    [SerializeField] AudioClip shootSound;
    [SerializeField] AudioClip hitSound;
    [SerializeField] AudioClip deathSound;
    [SerializeField] int maxHealth = 2;
    [SerializeField] float moveSpeed = 2f;
    [SerializeField] float sightRange = 9f;
    [SerializeField] float tooClose = 4f;           // closer than this, it backs away
    [SerializeField] float tooFar = 6f;             // further than this, it comes closer
    [SerializeField] float shootSeconds = 1f;       // as long as the Attack clip
    [SerializeField] float repositionSeconds = 0.8f;
    [SerializeField] float hurtSeconds = 0.4f;
    [SerializeField] float knockbackSpeed = 4f;

    Rigidbody2D body;
    Animator animator;
    Collider2D bodyCollider;
    SpriteRenderer spriteRenderer;
    AudioSource audioSource;
    Vector2 home;
    Vector2 sideStep;
    State state;
    Facing facing = Facing.Down;
    int health;
    float stateStartTime;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        bodyCollider = GetComponent<Collider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
        home = transform.position;
    }

    void Start()
    {
        ResetArcher();
    }

    void Update()
    {
        if (!game.IsPlaying)
        {
            Stop();
            UpdateAnimator();
            return;
        }

        switch (state)
        {
            case State.Idle:
                UpdateIdle();
                break;
            case State.KeepDistance:
                UpdateKeepDistance();
                break;
            case State.Shoot:
                UpdateShoot();
                break;
            case State.Reposition:
                UpdateReposition();
                break;
            case State.Hurt:
                UpdateHurt();
                break;
            case State.Dead:
                break;                  // waits for the OnDeathFinished Animation Event
        }
        UpdateAnimator();
    }

    void EnterState(State next)
    {
        state = next;
        stateStartTime = Time.time;

        switch (state)
        {
            case State.Idle:
                Stop();
                break;
            case State.KeepDistance:
                break;
            case State.Shoot:
                Stop();
                FaceHero();
                animator.SetTrigger(AttackHash);
                break;
            case State.Reposition:
                // A step to one side or the other, across the line to the hero.
                Vector2 toHero = (HeroPosition() - body.position).normalized;
                Vector2 across = new Vector2(-toHero.y, toHero.x);
                sideStep = (Random.value < 0.5f ? across : -across) * moveSpeed;
                break;
            case State.Hurt:
                animator.SetTrigger(HurtHash);
                break;
            case State.Dead:
                Stop();
                bodyCollider.enabled = false;
                body.simulated = false;
                animator.SetTrigger(DeadHash);
                audioSource.PlayOneShot(deathSound);
                break;
        }
    }

    void UpdateIdle()
    {
        if (CanSeeHero())
        {
            EnterState(State.KeepDistance);
        }
    }

    void UpdateKeepDistance()
    {
        if (!CanSeeHero())
        {
            EnterState(State.Idle);
            return;
        }

        Vector2 toHero = HeroPosition() - body.position;
        if (toHero.magnitude < tooClose)
        {
            Move(-toHero.normalized * moveSpeed);
            facing = Facings.FromVector(toHero, facing);     // backs away, still facing the hero
        }
        else if (toHero.magnitude > tooFar)
        {
            Move(toHero.normalized * moveSpeed);
        }
        else
        {
            EnterState(State.Shoot);
        }
    }

    void UpdateShoot()
    {
        if (Time.time - stateStartTime >= shootSeconds)
        {
            EnterState(State.Reposition);
        }
    }

    void UpdateReposition()
    {
        Move(sideStep);
        if (Time.time - stateStartTime >= repositionSeconds)
        {
            EnterState(State.KeepDistance);
        }
    }

    void UpdateHurt()
    {
        if (Time.time - stateStartTime > 0.15f)
        {
            Stop();
        }
        if (Time.time - stateStartTime >= hurtSeconds)
        {
            EnterState(health > 0 ? State.KeepDistance : State.Dead);
        }
    }

    // Animation Event: the release frame, as the bowstring snaps forward.
    // The arrow flies from the archer's feet at where the hero's feet are now.
    public void OnAttackHit()
    {
        if (state != State.Shoot)
        {
            return;
        }
        Vector2 from = body.position + Facings.ToVector(facing) * 0.4f;
        Arrow arrow = Instantiate(arrowPrefab, from, Quaternion.identity, arrowGroup);
        arrow.Launch(HeroPosition() - from);
        audioSource.PlayOneShot(shootSound);
    }

    public void TakeHit(int damage, Vector2 from)
    {
        if (state == State.Hurt || state == State.Dead)
        {
            return;
        }
        health -= damage;
        audioSource.PlayOneShot(hitSound);
        body.linearVelocity = (body.position - from).normalized * knockbackSpeed;
        EnterState(State.Hurt);
    }

    // Animation Event: at the end of the Dead clips, once it has faded.
    public void OnDeathFinished()
    {
        gameObject.SetActive(false);
    }

    public void ResetArcher()
    {
        gameObject.SetActive(true);
        body.simulated = true;
        body.position = home;
        transform.position = home;
        body.linearVelocity = Vector2.zero;
        bodyCollider.enabled = true;
        spriteRenderer.color = Color.white;
        animator.Rebind();

        health = maxHealth;
        facing = Facing.Down;
        EnterState(State.Idle);
    }

    // It sees the hero if he's within range and no wall is in the way. A
    // statue isn't a wall, but its collider is on the Walls layer too: cover.
    bool CanSeeHero()
    {
        Vector2 heroPosition = HeroPosition();
        if (hero.IsDead || Vector2.Distance(body.position, heroPosition) > sightRange)
        {
            return false;
        }
        return !Physics2D.Linecast(body.position, heroPosition, wallMask);
    }

    Vector2 HeroPosition()
    {
        return hero.transform.position;
    }

    void Move(Vector2 velocity)
    {
        body.linearVelocity = velocity;
        facing = Facings.FromVector(velocity, facing);
    }

    void Stop()
    {
        body.linearVelocity = Vector2.zero;
    }

    void FaceHero()
    {
        facing = Facings.FromVector(HeroPosition() - body.position, facing);
    }

    void UpdateAnimator()
    {
        animator.SetInteger(DirectionHash, (int)facing);
        animator.SetFloat(SpeedHash, body.linearVelocity.magnitude);
    }
}
```

`SkeletonKing`: **Swing Sound** `Swing`, **Hit Sound** `Hit`, **Summon Sound** `Summon`,
**Whirlwind Sound** `Whirl`, **Death Sound** `Bones`.

```csharp:SkeletonKing.cs
using System.Collections;
using UnityEngine;

// The Skeleton King, run as a state machine in two phases. In Phase 1 he
// walks at the hero and swings. At half health he summons two skeletons,
// and Phase 2 begins: he spins at the hero in a whirlwind that turns the
// sword aside, rests, open to the sword, and spins again. His Animator is a
// copy of Humanoid, with a Whirlwind state and a Summon state added.
[RequireComponent(typeof(Rigidbody2D))]
public class SkeletonKing : MonoBehaviour
{
    public enum State { Asleep, Walk, Swing, Summon, Whirlwind, Rest, Dead }

    static readonly int DirectionHash = Animator.StringToHash("Direction");
    static readonly int SpeedHash = Animator.StringToHash("Speed");
    static readonly int AttackHash = Animator.StringToHash("Attack");
    static readonly int DeadHash = Animator.StringToHash("Dead");
    static readonly int SummonHash = Animator.StringToHash("Summon");
    static readonly int WhirlwindHash = Animator.StringToHash("Whirlwind");

    [SerializeField] CryptGame game;
    [SerializeField] HeroHealth hero;
    [SerializeField] BossBar bossBar;
    [SerializeField] Skeleton skeletonTemplate;     // a skeleton in the scene, switched off: the summon copies it
    [SerializeField] Transform[] summonPoints;
    [SerializeField] Transform summonGroup;         // where the copies go, so Restart can clear them
    [SerializeField] AudioClip swingSound;
    [SerializeField] AudioClip hitSound;
    [SerializeField] AudioClip summonSound;
    [SerializeField] AudioClip whirlwindSound;
    [SerializeField] AudioClip deathSound;
    [SerializeField] int maxHealth = 20;
    [SerializeField] float walkSpeed = 1.5f;
    [SerializeField] float swingRange = 1.5f;
    [SerializeField] float swingSeconds = 1f;       // as long as his Attack clip
    [SerializeField] int swingDamage = 2;           // a whole heart
    [SerializeField] float summonSeconds = 1.2f;    // as long as his Summon clip
    [SerializeField] float whirlwindSpeed = 3f;     // the hero walks at 4: he can get away
    [SerializeField] float whirlwindSeconds = 2f;
    [SerializeField] int whirlwindDamage = 1;
    [SerializeField] float restSeconds = 1.5f;

    Rigidbody2D body;
    Animator animator;
    Collider2D bodyCollider;
    SpriteRenderer spriteRenderer;
    AudioSource audioSource;
    Vector2 home;
    State state;
    Facing facing = Facing.Down;
    int health;
    bool hasSummoned;
    float stateStartTime;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        bodyCollider = GetComponent<Collider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
        home = transform.position;
    }

    void Start()
    {
        ResetKing();
    }

    void Update()
    {
        if (!game.IsPlaying)
        {
            Stop();
            UpdateAnimator();
            return;
        }

        switch (state)
        {
            case State.Asleep:
                break;                  // waits for Wake, when the hero walks into the tomb
            case State.Walk:
                UpdateWalk();
                break;
            case State.Swing:
                UpdateSwing();
                break;
            case State.Summon:
                UpdateSummon();
                break;
            case State.Whirlwind:
                UpdateWhirlwind();
                break;
            case State.Rest:
                UpdateRest();
                break;
            case State.Dead:
                break;                  // waits for the OnDeathFinished Animation Event
        }
        UpdateAnimator();
    }

    void EnterState(State next)
    {
        state = next;
        stateStartTime = Time.time;

        switch (state)
        {
            case State.Asleep:
                Stop();
                break;
            case State.Walk:
                break;
            case State.Swing:
                Stop();
                FaceHero();
                animator.SetTrigger(AttackHash);
                audioSource.PlayOneShot(swingSound);
                break;
            case State.Summon:
                Stop();
                hasSummoned = true;
                animator.SetTrigger(SummonHash);
                break;
            case State.Whirlwind:
                animator.SetBool(WhirlwindHash, true);
                audioSource.PlayOneShot(whirlwindSound);
                break;
            case State.Rest:
                Stop();
                animator.SetBool(WhirlwindHash, false);
                break;
            case State.Dead:
                Stop();
                bodyCollider.enabled = false;
                body.simulated = false;
                animator.SetTrigger(DeadHash);
                audioSource.PlayOneShot(deathSound);
                break;
        }
    }

    // The hero walked into the tomb.
    public void Wake()
    {
        if (state == State.Asleep)
        {
            bossBar.Show(true);
            EnterState(State.Walk);
        }
    }

    void UpdateWalk()
    {
        if (hero.IsDead)
        {
            Stop();
            return;
        }
        Vector2 toHero = HeroPosition() - body.position;
        if (toHero.magnitude <= swingRange)
        {
            EnterState(State.Swing);
            return;
        }
        Move(toHero.normalized * walkSpeed);
    }

    void UpdateSwing()
    {
        if (Time.time - stateStartTime >= swingSeconds)
        {
            EnterState(State.Walk);
        }
    }

    void UpdateSummon()
    {
        if (Time.time - stateStartTime >= summonSeconds)
        {
            EnterState(State.Whirlwind);
        }
    }

    // He spins after the hero, and hurts him if he gets close.
    void UpdateWhirlwind()
    {
        Vector2 toHero = HeroPosition() - body.position;
        Move(toHero.normalized * whirlwindSpeed);
        if (toHero.magnitude < 1f)
        {
            hero.TakeDamage(whirlwindDamage, body.position);
        }
        if (Time.time - stateStartTime >= whirlwindSeconds)
        {
            EnterState(State.Rest);
        }
    }

    void UpdateRest()
    {
        if (Time.time - stateStartTime >= restSeconds)
        {
            EnterState(State.Whirlwind);
        }
    }

    // Animation Event: his sword's hit frame, on all four Attack clips.
    public void OnAttackHit()
    {
        if (state != State.Swing)
        {
            return;
        }
        Vector2 front = body.position + Facings.ToVector(facing) * 0.8f;
        if (Vector2.Distance(front, HeroPosition()) < 1.1f)
        {
            hero.TakeDamage(swingDamage, body.position);
        }
    }

    // Animation Event: the Summon clip's frame where the golden ring spreads.
    // Each copy of the template is a whole skeleton, already wired up.
    public void OnSummon()
    {
        foreach (Transform point in summonPoints)
        {
            Skeleton skeleton = Instantiate(skeletonTemplate, point.position, Quaternion.identity, summonGroup);
            skeleton.gameObject.SetActive(true);
        }
        audioSource.PlayOneShot(summonSound);
    }

    // The hero's sword hit him. Returns false when it can't hurt him: asleep,
    // summoning, spinning or dead, the sword just clangs.
    public bool TakeHit(int damage, Vector2 from)
    {
        if (state != State.Walk && state != State.Swing && state != State.Rest)
        {
            return false;
        }

        health = Mathf.Max(health - damage, 0);
        bossBar.SetHealth(health, maxHealth);
        audioSource.PlayOneShot(hitSound);
        StartCoroutine(Flicker());

        if (health == 0)
        {
            EnterState(State.Dead);
        }
        else if (!hasSummoned && health <= maxHealth / 2)
        {
            EnterState(State.Summon);
        }
        return true;
    }

    // He's too heavy to be knocked back: he flickers, so the hit shows.
    IEnumerator Flicker()
    {
        for (int i = 0; i < 3; i++)
        {
            spriteRenderer.enabled = false;
            yield return new WaitForSeconds(0.05f);
            spriteRenderer.enabled = true;
            yield return new WaitForSeconds(0.05f);
        }
    }

    // Animation Event: at the end of his Dead clips. The crypt is won.
    public void OnDeathFinished()
    {
        bossBar.Show(false);
        game.Win();
        gameObject.SetActive(false);
    }

    public void ResetKing()
    {
        StopAllCoroutines();
        foreach (Skeleton skeleton in summonGroup.GetComponentsInChildren<Skeleton>(true))
        {
            Destroy(skeleton.gameObject);
        }

        gameObject.SetActive(true);
        body.simulated = true;
        body.position = home;
        transform.position = home;
        body.linearVelocity = Vector2.zero;
        bodyCollider.enabled = true;
        spriteRenderer.enabled = true;
        spriteRenderer.color = Color.white;
        animator.Rebind();

        health = maxHealth;
        hasSummoned = false;
        facing = Facing.Down;
        bossBar.ResetBar();
        EnterState(State.Asleep);
    }

    Vector2 HeroPosition()
    {
        return hero.transform.position;
    }

    void Move(Vector2 velocity)
    {
        body.linearVelocity = velocity;
        facing = Facings.FromVector(velocity, facing);
    }

    void Stop()
    {
        body.linearVelocity = Vector2.zero;
    }

    void FaceHero()
    {
        facing = Facings.FromVector(HeroPosition() - body.position, facing);
    }

    void UpdateAnimator()
    {
        animator.SetInteger(DirectionHash, (int)facing);
        animator.SetFloat(SpeedHash, body.linearVelocity.magnitude);
    }
}
```

`CryptGame`: **Sound Source** and **Music Source** (the first and second Audio Sources),
**Crypt Music** `Crypt`, **Fight Music** `Fight`, **Win Sound** `Win`, **Lose Sound** `Lose`.

```csharp:CryptGame.cs
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

// Runs the game as a state machine: Start, Playing, Paused, Won and Lost. It
// knows which room the hero is in, wakes the king in his tomb, counts the
// time, and puts the whole crypt back on Restart.
public class CryptGame : MonoBehaviour
{
    public enum GameState { Start, Playing, Paused, Won, Lost }

    [SerializeField] Hero hero;
    [SerializeField] HeroHealth heroHealth;
    [SerializeField] HeroCombat heroCombat;
    [SerializeField] Inventory inventory;
    [SerializeField] RoomCamera roomCamera;
    [SerializeField] Room[] rooms;
    [SerializeField] float roomHeight = 11f;    // the rooms are stacked, the first at the bottom
    [SerializeField] SkeletonKing king;
    [SerializeField] Transform enemies;
    [SerializeField] Transform chests;
    [SerializeField] Transform doors;
    [SerializeField] Transform pickups;
    [SerializeField] Transform arrows;
    [SerializeField] TMP_Text roomText;
    [SerializeField] TMP_Text messageText;
    [SerializeField] GameObject startPanel;
    [SerializeField] Button playButton;
    [SerializeField] Button pauseButton;
    [SerializeField] GameObject pausePanel;
    [SerializeField] GameObject winPanel;
    [SerializeField] TMP_Text winText;
    [SerializeField] Button playAgainButton;
    [SerializeField] GameObject losePanel;
    [SerializeField] Button tryAgainButton;
    [SerializeField] AudioSource soundSource;
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioClip cryptMusic;
    [SerializeField] AudioClip fightMusic;
    [SerializeField] AudioClip winSound;
    [SerializeField] AudioClip loseSound;

    GameState state;
    float playTime;
    Vector2 startPoint;
    int roomIndex = -1;
    Coroutine roomFade;
    Coroutine messageFade;

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
        startPoint = hero.transform.position;
        roomText.text = "";
        messageText.text = "";
        roomCamera.SnapTo(rooms[0].Centre);
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
                UpdateRoom();
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
                winText.text = $"The Skeleton King has fallen!\n\nGold: {inventory.Gold}\nTime: {FormatTime(playTime)}";
                musicSource.Stop();
                soundSource.PlayOneShot(winSound);
                break;
            case GameState.Lost:
                musicSource.Stop();
                soundSource.PlayOneShot(loseSound);
                break;
        }
    }

    // Puts the whole crypt back as it was at the start, then plays.
    public void Restart()
    {
        playTime = 0f;
        roomIndex = -1;

        foreach (Skeleton skeleton in enemies.GetComponentsInChildren<Skeleton>(true))
        {
            skeleton.ResetSkeleton();
        }
        foreach (Archer archer in enemies.GetComponentsInChildren<Archer>(true))
        {
            archer.ResetArcher();
        }
        king.ResetKing();
        foreach (Arrow arrow in arrows.GetComponentsInChildren<Arrow>())
        {
            Destroy(arrow.gameObject);
        }
        foreach (Chest chest in chests.GetComponentsInChildren<Chest>(true))
        {
            chest.ResetChest();
        }
        foreach (Door door in doors.GetComponentsInChildren<Door>(true))
        {
            door.ResetDoor();
        }
        foreach (Pickup pickup in pickups.GetComponentsInChildren<Pickup>(true))
        {
            pickup.ResetPickup();
        }

        hero.ResetHero(startPoint);
        heroHealth.ResetHealth();
        heroCombat.ResetCombat();
        inventory.ResetInventory();
        roomCamera.SnapTo(rooms[0].Centre);
        PlayMusic(cryptMusic);
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

    // The rooms are stacked roomHeight units apart, so the height of the
    // hero's feet says which room he's in: 0 for the first, 1 for the next.
    void UpdateRoom()
    {
        int index = Mathf.FloorToInt(hero.transform.position.y / roomHeight);
        index = Mathf.Clamp(index, 0, rooms.Length - 1);
        if (index == roomIndex)
        {
            return;
        }

        roomIndex = index;
        roomCamera.MoveTo(rooms[index].Centre);
        if (roomFade != null)
        {
            StopCoroutine(roomFade);
        }
        roomFade = StartCoroutine(FadeText(roomText, rooms[index].Title));

        if (rooms[index].HasBoss)
        {
            king.Wake();
            PlayMusic(fightMusic);
        }
    }

    // A line at the bottom of the screen, such as "Locked: find a key".
    public void ShowMessage(string message)
    {
        if (messageFade != null)
        {
            StopCoroutine(messageFade);
        }
        messageFade = StartCoroutine(FadeText(messageText, message));
    }

    // Shows the text for two seconds, then fades it out over one.
    IEnumerator FadeText(TMP_Text label, string text)
    {
        label.text = text;
        label.alpha = 1f;
        yield return new WaitForSeconds(2f);
        for (float t = 0f; t < 1f; t += Time.deltaTime)
        {
            label.alpha = 1f - t;
            yield return null;
        }
        label.text = "";
    }

    void PlayMusic(AudioClip clip)
    {
        if (musicSource.clip == clip && musicSource.isPlaying)
        {
            return;
        }
        musicSource.clip = clip;
        musicSource.Play();
    }

    bool WasPausePressed()
    {
        Keyboard keyboard = Keyboard.current;
        return keyboard != null && (keyboard.escapeKey.wasPressedThisFrame || keyboard.pKey.wasPressedThisFrame);
    }

    // 161.4 seconds becomes "2:41".
    static string FormatTime(float seconds)
    {
        int whole = Mathf.FloorToInt(seconds);
        return $"{whole / 60}:{whole % 60:00}";
    }
}
```

`PlayMusic` does nothing if that music is already playing, so walking back and forth
between two rooms doesn't start the music over.

### Test it

Press **Play**, and play the whole crypt through.

- The rooms are dark, warm round the torches, and the torches flicker. Walk away from
  them: your own light shows your feet.
- The music starts with **Play**. Every swing, hit, fall, key, potion, chest and door
  sounds. Into the King's Tomb: the music changes to `Fight`. The clang of the
  whirlwind, the summon's boom, the bones of the king, and the win.
- Lose on purpose: the music stops, and the lose sound plays.

### Challenge

Make the pillars throw shadows: add a **Shadow Caster 2D** to the `Pillar` prefab, and on
the torches' `Flame` lights tick **Shadows** and set its **Strength** to `0.8`. Walk round a
pillar near a torch. Then try `Fight` in every room: what does music do to how the crypt
feels?

# Part 5 — Finish

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

## Chapter 15 — Break It, Then Fix It

**Goal:** you can recognise what Unity says when an Animator parameter, an Animation Event,
an Override Controller or a reference is wrong, go straight to the cause, and use a
breakpoint to watch the Skeleton King make up his mind.

### Idea

Every programmer breaks things, every day. The difference between a beginner and a
professional is how fast they find the cause. In this chapter you break the finished game
**on purpose**, one thing at a time, read what Unity tells you, and fix it. Do each step,
then undo it before the next one.

Level 3's mistakes are sneakier than Level 2's: an Animator or an Animation Event finds its
parameters and methods **by name**, while the game runs, so the compiler can't catch a
wrong name. Some of these mistakes give a warning, and some give nothing at all
(C# 10).

> **Watch out:** save your scene first (**Ctrl + S** / **Cmd + S**). If anything goes
> wrong, you can always go back to the saved version.

### Do it — a typo in a hash

1. In `Hero`, change the first hash's name to `"direction"`, with a small `d`:

   ```csharp
   static readonly int DirectionHash = Animator.StringToHash("direction");
   ```

2. Play, click **Play**, and walk round. He walks every way facing you, in the Down
   machine's clips, and the Console fills with a yellow warning, every frame:

   ```
   Parameter 'Hash 1045090739' does not exist.
   ```

3. A hash is only a number, so Unity can't say which name is wrong (C# 4).
   Click the warning. Under it, the stack trace: first Unity's own
   `UnityEngine.Animator:SetInteger (int,int)`, then your code, `Hero:Update () (at
   Assets/Scripts/Hero.cs:66)`. Line 66 sets `DirectionHash`, and `DirectionHash` comes
   from the line you changed. `Direction` stays at its default, 0, so the Base Layer never
   takes him out of Down. Put the capital `D` back.

### Do it — the wrong call

1. In `Hero.Update`, change `animator.SetInteger(DirectionHash, (int)facing);` to:

   ```csharp
   animator.SetFloat(DirectionHash, (int)facing);
   ```

2. Play: the same hero who only faces you, and another warning:

   ```
   Parameter type 'Hash -1128574192' does not match.
   ```

3. `Direction` is an **Int** in the Animator, so `SetFloat` can't change it. (A hash can be
   negative: it's any `int` at all.) Put `SetInteger` back.

### Do it — an event with no receiver

1. In `HeroCombat`, rename `OnAttackHit` to `OnSwordHit`.
2. Play, and swing, facing up. A red error, once a swing:

   ```
   'Hero' AnimationEvent 'OnAttackHit' on animation 'Hero Up Attack' has no receiver! Are you missing a component?
   ```

3. Read it from the start: the GameObject, `Hero`; the event, `OnAttackHit`; the clip,
   `Hero Up Attack`. The clip still calls `OnAttackHit`, and no script on `Hero` has a
   method by that name any more (C# 5). The swing plays, but the sword
   hurts nothing. Rename the method back.

### Do it — a copy you forgot to finish

1. Open `Humanoid`, go into the `Up` machine, and set `Walk`'s **Motion** back to `Hero
   Down Walk`, as it was when you pasted the copy.
2. Play, and walk up: he walks up the screen with his face towards you, walking down.
3. No message: the Animator did exactly what it was told. A copy is only right once every
   one of its states has been changed. Set the **Motion** back to `Hero Up Walk`.

### Do it — an empty slot in an Override Controller

1. Select `Skeleton Override`, and clear the **Override** slot beside `Hero Down Walk`.
2. Play, and watch a skeleton walk towards you: for as long as it walks down, it's the
   hero.
3. An empty slot plays the base controller's own clip. No message again. Put `Skeleton
   Down Walk` back in the slot.

### Do it — an empty field

1. Under `Enemies`, select the skeleton at `(7.5, 17.15)` in the Hall of Bones, and empty
   its **Hero** field: click it, and press **Delete** or **Backspace**. It says **None (Hero Health)**.
2. Play, and click **Play**. A red error, every frame:

   ```
   NullReferenceException: Object reference not set to an instance of an object
   Skeleton.HeroPosition () (at Assets/Scripts/Skeleton.cs:265)
   Skeleton.CanSeeHero () (at Assets/Scripts/Skeleton.cs:254)
   Skeleton.UpdateIdle () (at Assets/Scripts/Skeleton.cs:130)
   Skeleton.Update () (at Assets/Scripts/Skeleton.cs:73)
   ```

3. Read the stack trace from the bottom up: `Update` called `UpdateIdle`, which called
   `CanSeeHero`, which called `HeroPosition`, where line 265 is `return
   hero.transform.position;`. `hero` is the only thing before a `.` that could be
   missing. That skeleton never moves: the error stops its `Update` every frame, before it
   does anything. Drag `Hero` back into the field.
4. Now select `Skeleton King`, and empty its **Summon Group**. Play: one error at once,
   before you even click **Play**, and a friendlier one, because a `Transform` is one of
   Unity's own types:

   ```
   UnassignedReferenceException: The variable summonGroup of SkeletonKing has not been assigned.
   You probably need to assign the summonGroup variable of the SkeletonKing script in the inspector.
   ```

5. Click it. The first lines of the stack trace are Unity's own. Start at the first that
   names your script: `SkeletonKing.ResetKing ()`, line 284, called by `SkeletonKing.Start
   ()`, line 67. Now click **Play**: nothing happens, and the same error comes again.
   `Restart` resets the king too, the error stops it, and it never reaches the line that
   starts the game. One empty field, and the whole game won't start. Drag `Summoned` back
   into **Summon Group**.

### Do it — a wall you can see through

1. Select the `Skeleton` prefab, and set its **Wall Mask** to **Nothing**.
2. Play, go into the Hall of Bones, and stand behind a statue, still. The skeletons see
   you, and come.
3. `Physics2D.Linecast` looks only on the mask's layers, and the mask has none, so nothing
   is ever in the way. Set it back to **Walls**.

### Do it — a state change that skips its enter step

1. In `Skeleton.UpdateChase`, line 170, change `EnterState(State.Attack);` to `state =
   State.Attack;`.
2. Play, and let a skeleton reach you. It walks into you, pushes, and never swings.
3. Only `EnterState` stops it, turns it to face you and sets the `Attack` trigger. Without
   the trigger, the Attack clip never plays, so its hit frame never comes, and nothing
   calls `OnAttackHit` (C# 7). Put `EnterState(State.Attack);` back.

### Do it — sorting by the wrong point

1. Select the `Statue` prefab, and set its **Sprite Sort Point** to **Center**.
2. Play, and walk up behind a statue, slowly. For a few steps, while his feet are above
   the statue's feet but below its middle, he's drawn **in front** of it.
3. The statue now sorts by its middle, half a tile above where it stands. Set it back to
   **Pivot**.

### Do it — watch the king decide, with a breakpoint

1. Open `SkeletonKing` in VS Code, and click left of line 106, `state = next;`, the first
   line of `EnterState`: a red dot.
2. **Run and Debug** (**Ctrl + Shift + D** / **Cmd + Shift + D**), choose **Attach to
   Unity**, and press ▶. If Unity asks, choose **Enable debugging for this session**.
3. Play. The game freezes before it has even drawn: hover over `next`, **Asleep**, and look
   at the **Call Stack**: `EnterState`, called by `ResetKing`, called by `Start`. Press
   **F5** to carry on. Click **Play**: it stops again, **Asleep**, from `ResetKing`, this
   time called by `CryptGame.Restart`. **F5**.
4. Walk into the King's Tomb (start the hero there, as in Chapter 13, to be quick). It stops
   as you come in: **Walk**, called by `Wake`, called by `CryptGame.UpdateRoom`, called by
   `CryptGame.Update`. The game woke him.
5. **F5**, and let him reach you: **Swing**, called by `UpdateWalk`. He changes state
   often now, and every change stops the game: press **F5** each time.
6. Hit him until his bar is at half. It stops: **Summon**, called by `TakeHit`, called by
   `HeroCombat.OnAttackHit`. Under that, no `Update` at all: none of your code called
   `OnAttackHit`. The Animator did, from the hit frame of the hero's Attack clip.
7. Click the red dot to remove it, press **F5**, and stop debugging with **Shift + F5**.

### Test it

After undoing every break, the game works exactly as before: play the whole crypt to be
sure, and check that the Console has no errors and no warnings.

### Challenge

Break the game in a way this chapter didn't, and swap with a classmate: each of you must
find and fix the other's bug using only the Console, the Animator window and a breakpoint.
The hardest ones to find give no message at all, like the copy you forgot to finish.

## Chapter 16 — Ship It

**Goal:** a Web build of Crypt Keys, published on itch.io, that plays with the keyboard and
the mouse on a computer, and with a finger on a phone.

### Idea

The game is finished; now players need it. As in Levels 1 and 2, a **Web** build runs in
any browser, and itch.io hosts it for free. The pointer controls from Chapter 2 work with
a finger as well as a mouse, so the same link works everywhere.

The Pixel Perfect Camera draws the crypt at 640 × 352 and scales it up by a whole number.
A Web page of **1280 × 720** scales it by exactly 2, with a thin black bar above and
below: the size to build for.

### Do it — the build

1. **File → Build Profiles**. Select **Web** and click **Switch Platform**.
2. In **Scene List**, click **Add Open Scenes** if `Scenes/CryptKeys` is missing, and untick
   `Scenes/SampleScene`: a build starts with the first ticked scene, and that must be
   `Scenes/CryptKeys`.
3. Open **Player Settings**: set the **Product Name** to `Crypt Keys`. Under **Resolution
   and Presentation**, set **Default Canvas Width** to `1280` and **Default Canvas Height**
   to `720`. Under **Publishing Settings**, set **Compression Format** to **Disabled**.
4. Click **Build**, create a folder called `Builds/Web`, and wait.

### Do it — publish on itch.io

1. Zip the **contents** of `Builds/Web`, so `index.html` is at the top of the zip.
2. On itch.io, **Upload new project**, **Kind of project: HTML**, upload the zip, and tick
   **This file will be played in the browser**.
3. Set the **Viewport dimensions** to `1280 × 720`, and tick **Mobile friendly**; if
   itch.io asks for an orientation, choose **Landscape**. Save, and open the page.

### Test it

1. On a computer: play the whole crypt with the keyboard, then again with the mouse only:
   hold to walk, click to swing and open, click the potion slots. Pause with **Esc**,
   change the volume, and beat the king.
2. Look closely at the pixels: every one is square, and the same size, in the hero and the
   walls alike. If some look stretched, the page isn't 1280 × 720: check the viewport.
3. On a phone: open the same page, turn the phone sideways, and press **Play**. Hold a
   finger down to walk towards it, tap to swing, tap a chest to open it, tap a slot to
   drink. Pause with the `II` button.
4. If something is too small to read or to press on the phone, that's a job for the
   challenge.

### Challenge

Watch a friend play without explaining anything. Where do they get lost? Which room do
they die in? Do they find the potions? Fix the biggest problem: a slower archer, a potion
in an easier place, a torch where it's too dark. That's what game designers call
**playtesting**.

# Part 6 — The Exam

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

# Part 7 — Check Yourself

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
