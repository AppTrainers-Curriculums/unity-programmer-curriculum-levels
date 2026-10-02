---
title: "Gate Guard"
subtitle: "Level 3: Junior-ready"
author: "Unity Programmer Curriculum  ·  Level 3"
coverEyebrow: "Level 3 · Junior-ready · Learn to Code · Make Games"
coverTop: "Gate"
coverRed: "Guard"
coverSub: "A 3D tower defence: skeletons that rise from the ruins and march on a hex battlefield, archers, catapults and frost mages on towers that grow, ten waves, and a castle gate to hold."
coverPill: "Level 3 Workbook · Gate Guard"
coverCaption: "19 scripts · 23 animation clips · 1 Bone Mage"
coverArt: image
coverImage: cover.png
footer: "Gate Guard  ·  Level 3 Workbook"
---

# Part 0 — Before You Start

## What you're going to build

A **3D tower defence**. The dead are rising in the old ruins: ten waves of skeletons
march along a winding road to the castle gate. You build towers on the dirt plots beside
the road, upgrade them, and hold the gate.

The battlefield is made of **hex tiles**, seen from above at an angle, and it never
moves: the whole road fits on the screen. The road starts at the ruins in the bottom-left
corner, runs east along the bottom, back west across the middle, east along the top, and
bends into the gate at the top-right. Thirteen dirt plots stand beside it, most of them
between two stretches of road.

| Skeleton | Looks | Health | Speed | Bounty | Lives it costs |
| --- | --- | --- | --- | --- | --- |
| **Minion** | a bare skull and a blade | 6 | 1.5 | 5 gold | 1 |
| **Rogue** | a red hood; it runs | 4 | 2.6 | 6 gold | 1 |
| **Warrior** | a horned helmet, an axe and a shield | 18 | 1 | 12 gold | 2 |
| **Bone Mage** | the boss of wave 10, half as big again, with a staff | 150 | 0.7 | 100 gold | 5 |

| Tower | Crew | Shoots |
| --- | --- | --- |
| **Arrow** (green) | an archer | one skeleton, quickly |
| **Catapult** (red) | a wooden arm | a stone that lands in an arc and hits everything round it |
| **Frost** (blue) | a mage | a frost bolt that slows a skeleton to half speed |

**How to play:** the game is played with a pointer: the mouse, or a finger on a phone.
Tap a dirt plot, and a menu opens over it with the three towers and their prices. Tap a
tower, and its menu shows **Upgrade** and **Sell**, and its range as a ring on the ground.
Tap anywhere else to close a menu. **Start Wave** sends the next wave (or **Space**), the
**x2** button plays at double speed (or **F**), and the pause button, **Esc** or **P**
pauses.

You start with **120 gold** and **10 lives**: the gate's strength. A tower costs gold,
and so does each upgrade, to **Level 2** and **Level 3**; at Level 2 a tower grows a
storey and reaches further, and at Level 3 it raises its flags. Selling gives back 60% of
everything a tower cost. A skeleton killed by a tower pays its bounty. A skeleton that
reaches the gate chops at it: the doors shudder, and the lives go. A cleared wave pays a
bonus, 20 gold plus 5 for each wave's number, and the next wave counts down from 15
seconds. Clear wave 10, Bone Mage and all, to win. If the lives run out, the gate's doors
burst open, and every skeleton on the road cheers. A start screen waits for **Play**, and
**Restart** puts the whole battlefield back as it began.

## Level 3 has three books

Level 3 has three games, each with its own book: **Knight Run** (a 2D platformer),
**Crypt Keys** (a 2D dungeon) and **Gate Guard** (this one, a 3D tower defence). Every
book teaches **every** Level 3 topic, and they share the same C# Concept chapters, so
your trainer can run one book, or give different groups different books. If you've done
one book already, the C# Concept chapters in the next are a revision round.

The C# Concept chapters are written once for all three books, so their examples come
from the 2D games: a knight who runs and rolls, and slimes that hop. The ideas are
exactly the same in 3D. Every build chapter of this book shows them on your own
skeletons, towers and gate, and where 3D does something differently, the chapter says.

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
> UI events, `GetComponent` and `TryGetComponent`, the Input System, and Level 2's 3D
> scenes. Keep the Level 2 cheat sheet next to you.

## The route through this book

| Step | Chapter | You learn | You build |
| --- | --- | --- | --- |
| 1 | C# 1 | Naming conventions | — |
| 2 | Chapter 1 | Model import settings, a hex Grid, the GameObject Brush, a camera that looks down | The bottom of the battlefield |
| 3 | Chapter 2 | Turning tiles to fit, waypoints, Gizmos | The road and the castle |
| 4 | C# 2 | Clips, keyframes, property clips | — |
| 5 | Chapter 3 | A Humanoid Avatar, a clip from another file, a weapon on a bone, following waypoints | A skeleton walks |
| 6 | C# 3, C# 4 | States, transitions, parameters, hashes | — |
| 7 | Chapter 4 | An imported clip's settings, a state's Speed Multiplier | The Skeleton controller |
| 8 | C# 5 | Animation Events | — |
| 9 | C# 6, C# 7 | State machines in code and in the Animator | — |
| 10 | Chapter 5 | Events in the Import Settings, an enemy as a state machine, a spawner, a property clip | The skeleton's life, the gate |
| 11 | Chapter 6 | Override Controllers, one script with other numbers | Four kinds of skeleton |
| 12 | C# 8 | Health bars, panels, pausing | — |
| 13 | Chapter 7 | A font asset, a ray from the camera, a menu over a 3D tile, a button's Disabled picture | Plots and gold |
| 14 | Chapter 8 | `Physics.OverlapSphere`, first in line, a release frame, a Trail Renderer | The Arrow tower |
| 15 | Chapter 9 | Property clips on a wooden arm, an arc, splash and slow, particles | The Catapult and the Frost tower |
| 16 | Chapter 10 | An array of plain classes, an Int that switches looks, Is Active keys, a circle in code | Three levels, upgrade and sell |
| 17 | Chapter 11 | Arrays inside arrays, the spawner as a state machine, a countdown | Ten waves |
| 18 | Chapter 12 | A World Space Canvas, double speed, panels | The screen |
| 19 | Chapter 13 | The game as a state machine, Restart in code, a Bool for the end | Hold the gate |
| 20 | Chapter 14 | Sounds and music, soft shadows, ambient light, a camera for every screen | Sound and light |
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
the course project; the answer key is a separate trainer-only file). Chapters 4, 8 and
10 are the heart of this book: one controller for four skeletons, one for three tower
crews, and a tower's looks switched by an Int. Give them the most time. Chapters 1 and 2
paint the battlefield, and can run long for slow mouse users: let students finish
painting at home if they need to, from the map in the book. Chapter 13 changes four
scripts at once to give every piece of the battlefield a reset: let students type it
over two sessions if they need to.

Your trainer project has the finished game, and a menu item that builds its scene from
scratch (**Tools → Gate Guard (Level 3) → Build Scene**): use it to show the goal on the
first day, or to rescue a scene that's beyond repair.

## The pieces we'll build

Nineteen scripts:

```
WaypointPath ───── the road: a point in the middle of every road tile, in order
Enemy ──────────── a skeleton as a state machine: rising, walking, slowed, dying, at the gate
EnemyHealthBar ─── a bar over a skeleton's head, turned to face the camera
WaveSpawner ────── the waves' own state machine: waiting, spawning, in progress, cleared
Gate ───────────── costs lives, shudders, and bursts open when the last one goes
Bank ───────────── the gold and the lives, and their numbers on the screen
BuildPlot ──────── a dirt plot beside the road, and the tower on it
Picker ─────────── a ray from the camera through the pointer: which plot was tapped?
BuildMenu ──────── three towers to build, over the plot that was tapped
TowerMenu ──────── upgrade or sell a tower, over the tower
RangeRing ──────── a circle on the ground: how far a tower reaches
Tower ──────────── a tower as a state machine: idle, aim, fire, reload; three levels
TowerCrew ──────── passes the crew's release frame on to its tower
Projectile ─────── an arrow, a stone or a frost bolt: one script, an enum and a switch
PauseMenu ──────── Resume, Restart and the volume
GateGame ───────── the game's own state machine: start, playing, paused, won, lost

TowerLevel ─────── what a tower can do at one level (a plain C# class)
Wave ───────────── one wave's name and its groups of skeletons (a plain C# class)
SpawnGroup ─────── which skeleton, how many, how far apart (a plain C# class)
```

## New words for Level 3

| Word | What it means |
| --- | --- |
| **Model** | a 3D file, here an `.fbx`: meshes, materials, and sometimes bones and clips |
| **Rig, bone** | the hidden skeleton inside a character model; moving a bone bends the mesh round it |
| **Humanoid Avatar** | Unity's map from a character's bones to a standard human body, so that any human clip plays on it |
| **Hex Grid** | a Grid whose cells are hexagons, every other row shifted half a cell |
| **GameObject Brush** | a Tile Palette brush that paints GameObjects, such as 3D tiles, instead of tiles |
| **Animation clip** | how some properties change over time: an `.anim` asset, or a clip inside a model |
| **Keyframe** | a value set at one moment of a clip; Unity fills in the moments between |
| **Animator Controller** | the state machine that chooses which clip plays |
| **State, transition** | a box in the Animator, and an arrow from one box to another |
| **Parameter** | a value that code sets, and transitions read: Float, Int, Bool or Trigger |
| **Animation Event** | a marker on a clip that calls one of your methods |
| **State machine** | code, or an Animator, that's in one state at a time and follows rules to change |
| **Override Controller** | a copy of an Animator Controller's state machine with other clips |
| **Layer mask** | a set of layers, so a physics query only sees what it should |
| **World Space Canvas** | a Canvas that stands in the world like a 3D object: a health bar over a head |
| **Trail Renderer** | draws a fading ribbon behind something that moves |

## One-time project setup

- **Unity 6**, with a new project created from the **Universal 3D** template, as for
  Level 2's 3D game. The **Input System** package comes with it.
- **One package to add:** **Window → Package Manager**, choose **Unity Registry** on the
  left, find **2D Tilemap Extras**, and click **Install**. It brings the Tile Palette, and
  the **GameObject Brush** this book paints the battlefield with.
- **Art and sound:** your trainer shares two folders, `Art` and `Audio`, holding every
  file this book uses, and each pack's licence beside them. `CREDITS.md` names them all.
  They are:
  - **KayKit** by Kay Lousberg, on itch.io: the **Medieval Hexagon Pack** (the
    battlefield, the castle and the towers), **Skeletons**, **Adventurers** (the archer
    and the mage) and **Character Animations** (every clip). All free to use for
    anything (CC0). Use the itch.io downloads: the Asset Store copies come under another
    licence.
  - **Free Fantasy Game GUI** by pzUH, on OpenGameArt (CC0): panels, buttons, bars.
  - Seven icons from **game-icons.net**, by Lorc, Delapouite, Skoll and sbed. They're
    free under **CC BY 3.0**, which asks for one thing: credit. The Start panel names
    the artists, and so does `CREDITS.md`.
  - **Lilita One**, a font by Juan Montoreano, under the SIL Open Font License.
  - **Ninja Adventure** by Pixel-Boy and AAA (CC0): every sound, and the music.
- `Art` holds `Models/` (the hex pack's tiles, buildings, nature and props, and the
  picture they're all painted from, `hexagons_medieval.png`), `Characters/` (four
  skeletons, the Ranger and the Mage), `Weapons/`, `Animations/` (six files of clips,
  `Rig_Medium_General.fbx` and the rest), `UI/`, `Icons/`, `Fonts/` and `Licences/`.
  `Audio` holds 13 sounds and two pieces of music.
- Copy both folders into `Assets`. Scripts live in `Assets/Scripts`, clips and
  controllers in `Assets/Animation`, prefabs in `Assets/Prefabs`, and materials in
  `Assets/Materials`.

# Part 1 — The Battlefield

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

## Chapter 1 — A Hex Battlefield

**Goal:** a new 3D project with the hex pack's models imported as plain models, a hex
Grid lying on the ground, and the bottom of the battlefield painted with the GameObject
Brush: grass, the first stretch of road out of the ruins, trees and hills. A camera looks
down on it from where it will stay for the whole game, and a sun lights it.

### Idea — what comes in with a model

An `.fbx` file can hold much more than a shape: meshes, materials, cameras, lights, a
skeleton of bones, and animation clips. The hex pack's tiles are only meshes and
materials, so we tell Unity to bring in only those. Each model's **Import Settings**, in
the Inspector when you select it, has four tabs:

| Tab | Setting | Value | Why |
| --- | --- | --- | --- |
| **Model** | **Import Cameras**, **Import Lights** | off | the files have none we want |
| **Rig** | **Animation Type** | **None** | a tile has no bones; with the usual **Generic**, every tile you paint would get an Animator, doing nothing |
| **Animation** | **Import Animation** | off | a tile has no clips |
| **Materials** | **Material Creation Mode**, **Location** | leave them: **Import via MaterialDescription**, **Use Embedded Materials** | the materials come from the file, and find `hexagons_medieval.png` beside them |

Every model in the pack is painted from that one picture, `hexagons_medieval.png`: a
**texture atlas**. A grass tile, a tree and a tower each take their colours from a
different part of it, so the whole battlefield shares one material.

### Idea — a battlefield of hexagons

The ground is made of **hex tiles**, and ours are **pointy-top**: a point at the top and
the bottom, flat sides left and right.

```
       / \ / \ / \ / \
      |   |   |   |   |      row 1: half a hex (1 unit) to the right
     / \ / \ / \ / \ /
    |   |   |   |   |        row 0
     \ / \ / \ / \ /

    every hex is 2 units across the flats, and 2.31 from point to point;
    the rows are 1.732 units apart, each fitted into the gaps of the next
```

Unity's **Grid** has a **Hexagon** layout that works out where every cell is, exactly as
the tiles need: you ask for column 3, row 2, and it knows the point. In Knight Run and
Crypt Keys the Grid stood upright, along x and y. A battlefield lies on the ground, along
x and z, and the Grid's **Cell Swizzle** says so:

| Grid setting | Value | Why |
| --- | --- | --- |
| **Cell Layout** | **Hexagon** | hexes, every other row shifted |
| **Cell Size** | `(2, 2.309, 1)` | 2 across the flats; 2.309 from point to point (`4 ÷ √3`) |
| **Cell Swizzle** | **XZY** | the grid's columns along x, its rows along z: flat on the ground |
| **Position** | `(-12, 0, -6.928)` | so the middle of the battlefield, column 6 of row 4, is at `(0, 0, 0)` |

The top of every tile is at `y = 0`, the ground the skeletons will walk on.

### Idea — painting 3D tiles

In 2D you painted tiles: pictures in the cells of a Tilemap. Here every hex is a 3D
model, a GameObject, and the Tile Palette has a brush for that too: the **GameObject
Brush**, from 2D Tilemap Extras. It paints copies of a model into the cells you click,
each one still linked to its file, as children of the **Active Target**.

| Brush setting | Set it to |
| --- | --- |
| **Anchor** | `(0, 0, 0)`: where in its cell a painted object stands. In a square grid, `(0.5, 0.5)` moves it from the cell's corner to its middle; a hex cell's position is already its middle |
| **Cells**, **Element 0**, **Game Object** | the model to paint: change it whenever you want to paint a different model |

Two things to know about the brush:

- It never paints a cell twice: a cell that already holds something under the Active
  Target is skipped. So paint the road first, then **Box Fill** the grass all round it,
  and the road stays.
- It paints every model the way it was made. A road tile that has to bend another way is
  turned afterwards, by hand, in the Inspector.

### Idea — the map

This is the whole battlefield, one mark per hex. Each line is a row, counted from `0` at
the bottom (the south, nearest the camera); the odd rows are drawn indented, because
that's where they sit. Columns count from `0` on the left:

```
              0         5        10
              |         |         |
   row 8      T T M M T T . T T . G C C
   row 7       T = = = = = = = = = . C C
   row 6      T = . b . . b . . b . . T
   row 5       T = . . b . . b . . . . T
   row 4      T . = = = = = = = = . . T
   row 3       T . . b . . b . . = b . T
   row 2      T . b . . b . . b . = . T
   row 1       X S = = = = = = = = . T T
   row 0      H h T . b . . b . . T T T
```

| Mark | Is | Painted in |
| --- | --- | --- |
| `.` | grass; a few get a rock or a lone tree | this chapter (rows 0 to 2), Chapter 2 (the rest) |
| `=` | road | this chapter (rows 1 and 2), Chapter 2 (the rest) |
| `S` | the start: the road's dead end, where the skeletons rise | this chapter |
| `G` | the gate's tile: road, with the gate on it | Chapter 2 |
| `b` | a build plot: grass for now | the plots go on in Chapter 7 |
| `T` | trees | this chapter, Chapter 2 |
| `M` `H` `h` | a mountain, hills, a small hill | this chapter, Chapter 2 |
| `X` | the ruins the skeletons come from | this chapter |
| `C` | the castle's ground: grass | Chapter 2 |

The road starts at `S`, runs east along row 1, climbs to row 4, runs back west, climbs to
row 7, runs east again, and enters the gate at `G`: 31 tiles, 61 units of road.

### Idea — three road pieces

The pack has a road piece for every way a road can go through a hex. We need three,
shown as they come, with north at the top:

| Piece | Model | Joins |
| --- | --- | --- |
| a dead end | `hex_road_M` | the east side only |
| a straight | `hex_road_A` | east and west |
| a gentle bend | `hex_road_B` | east and south-west |

A road that goes another way is one of these, turned about y. A hex has six sides, so
the turns are multiples of 60°. A positive **Rotation Y** turns a tile clockwise, seen
from above: the bend at column 9 of row 1 must join west and north-east, which is the
bend as it comes turned half round, **Rotation Y** `180`.

### Do it — the project and the art

1. In **Unity Hub**, create a new project from the **Universal 3D** template, and install
   **2D Tilemap Extras** (Part 0, *One-time project setup*).
2. **File → New Scene**, pick **Basic (URP)** (a camera and a light), and **File → Save
   As** `Assets/Scenes/GateGuard.unity`.
3. In the **Project** window, create the folders `Scripts`, `Animation`, `Prefabs` and
   `Materials` inside `Assets`.
4. Copy your trainer's `Art` and `Audio` folders into `Assets`.

### Do it — the models, as plain models

1. Open `Assets/Art/Models`. Click the first `.fbx`, Shift-click the last, and
   Ctrl-click (Cmd-click on a Mac) `hexagons_medieval.png` to leave it out: every model,
   and only models, is selected. In the Inspector:
   - on the **Animation** tab, untick **Import Animation**, and click **Apply**;
   - on the **Rig** tab, set **Animation Type** to **None**, and click **Apply**;
   - on the **Model** tab, untick **Import Cameras** and **Import Lights**, and click
     **Apply**.
2. Do the same for every `.fbx` in `Assets/Art/Weapons`: the skeletons' blades and the
   crews' bows, for Chapter 3 and Chapter 8.
3. Drag `hex_grass` into the Scene view and look at it: a hex of yellow-green grass, a
   unit thick. Its Inspector shows a **Transform**, a **Mesh Filter** and a **Mesh
   Renderer**, and no Animator. Delete it.

### Do it — the Grid and its two Tilemaps

1. **GameObject → 2D Object → Tilemap → Hexagonal Point Top**. Unity makes a `Grid` with
   a child, `Tilemap`.
2. Select `Grid`, and choose **GameObject → 2D Object → Tilemap → Hexagonal Point Top**
   again: a second child, `Tilemap (1)`.
3. Rename `Grid` to `Battlefield`, `Tilemap` to `Ground` and `Tilemap (1)` to `Decor`.
   The GameObject Brush paints the tiles under `Ground`, and the trees and rocks under
   `Decor`.
4. Select `Battlefield`, and set the **Grid** as the table in *A battlefield of
   hexagons* says: **Cell Size** `(2, 2.309, 1)`, **Cell Swizzle** **XZY**. Leave **Cell
   Layout** on **Hexagon**. Set the Transform's **Position** to `(-12, 0, -6.928)`.

> **Watch out:** make both Tilemaps **before** you change the Grid. Making a hexagonal
> Tilemap inside a Grid puts that Grid's Cell Size and Swizzle back to the 2D ones.

### Do it — the GameObject Brush

1. **Window → 2D → Tile Palette**, and dock it beside the Inspector. You won't need a
   palette of tiles: the brush holds the model it paints.
2. At the bottom of the Tile Palette, open the brush drop-down (it says **Default
   Brush**), and choose **GameObject Brush**. Its settings show under it.
3. Set **Anchor** to `(0, 0, 0)`. Open **Cells** and its **Element 0**, and drag
   `hex_road_A` from `Assets/Art/Models` into its **Game Object** field.
4. At the top of the Tile Palette, set the **Active Target** drop-down to **Ground**.

While the Tile Palette is open, the Scene view draws the hex cells on the ground. Move
the mouse over them: the cell under it lights up.

### Do it — find your way round the grid

The Tile Palette's tools, along the top of its window, work as they did in 2D:

| Tool | Key | Does |
| --- | --- | --- |
| **Select** | **S** | selects cells, and shows where they are |
| **Paint** | **B** | paints the brush's model into a cell, one at a time, or as you drag |
| **Box Fill** | **U** | fills every cell from one corner to the other |
| **Pick** | **I** | picks up the model in a cell, as the brush's model |
| **Erase** | **D** | removes the model in a cell |

To find a cell, use the **Select** tool and click one: the Inspector shows a **Grid
Selection** whose **Position** is the cell's column and row. Look at the Scene view from
above for painting: click the **y** arm of the gizmo in its top-right corner, and the
battlefield lies flat under you, with north at the top.

### Do it — the first road

With the **Paint** tool, and the **Active Target** on **Ground**:

1. With `hex_road_A` in the brush, paint row 1 from column 2 to column 8: seven
   straights.
2. Put `hex_road_M` in the brush, and paint column 1 of row 1: the dead end, `S`.
3. Put `hex_road_B` in the brush, and paint two bends: column 9 of row 1, and column 10
   of row 2.
4. Turn the bends. Select each in the Hierarchy (the newest children of `Ground` are at
   the bottom), or press **W** for the Move tool and click it in the Scene view, and set
   its **Rotation Y**:

| Tile | Column, row | Rotation Y | Joins |
| --- | --- | --- | --- |
| a bend | 9, 1 | `180` | west, and north-east |
| a bend | 10, 2 | `120` | south-west, and north-west |

The road now runs from the dead end, east along row 1, and turns north. Its north-west
end, at column 10 of row 2, waits for Chapter 2.

### Do it — grass all round

1. Put `hex_grass` in the brush, and choose **Box Fill**.
2. Drag from column 0 of row 0 to column 12 of row 2. Every empty cell of the three rows
   fills with grass; the ten road tiles stay as they are.

### Do it — trees, hills and the ruins

Set the **Active Target** to **Decor**, and paint these on top of the grass, changing
the brush's model as you go:

| Mark | Cells (column, row) | Models |
| --- | --- | --- |
| `X` | 0, 1 | `building_destroyed`, then **Rotation Y** `60` |
| `H` | 0, 0 | `hills_A_trees` |
| `h` | 1, 0 | `hill_single_A` |
| `T` | 2, 0; 10, 0; 11, 0; 12, 0; 11, 1; 12, 1; 0, 2; 12, 2 | `trees_A_large`, `trees_A_medium`, `trees_B_large`, `trees_B_medium`, `trees_A_small`: a mix |

The pack's guide asks for variety, and it's right: the same clump of trees eight times in
a row looks like wallpaper. Mix the five, and turn some of them by `60`, `120` or `180`.
Then give a few of the plain grass cells, about one in three, a rock (`rock_single_A`,
`_C` or `_E`) or a lone tree (`tree_single_A`, `_B`), and nudge each a little away from
the middle of its hex with the Move tool. Leave the `b` cells bare: they'll be dirt.

### Do it — the camera and the sun

1. Select **Main Camera**. Set its **Position** to `(0.2, 22.5, -17.6)` and its
   **Rotation** to `(50.9, 0, 0)`: high above the south edge, looking down at the middle
   of the battlefield. In the **Camera** component, set **Field of View** to `33`, and
   under **Environment**, **Background Type** to **Solid Color** and the colour to a dark
   slate, `#1D2128`.
2. Select **Directional Light**, and set its **Rotation** to `(55, 40, 0)`: the sun is
   behind the camera's left shoulder, and the shadows fall to the north-east, away from
   the camera.
3. At the top of the **Game** view, set its size to **Full HD (1920x1080)**: the game is
   made for a wide screen.

### Test it

Press **Play**. The Game view shows the bottom of the battlefield, nearest you: the ruins
and the dead end on the left, the road running east and turning north, trees along the
edges, and the dark beyond. Stop, and in the Scene view check the joins: every road tile
meets the next edge to edge, with no step and no gap. A tile that's out of line was
painted with the brush's **Anchor** still at `(0.5, 0.5, 0)`: erase it, and paint it
again.

### Challenge

Look at `hex_road_B`'s six neighbours and work out the **Rotation Y** for a bend that
joins north-west and east. Paint one in an empty corner of the Scene, turn it, and see.
Then erase it.

## Chapter 2 — The Road

**Goal:** the rest of the battlefield painted, the castle and its gate standing at the
end of the road, and the road written down as a list of points, from the ruins to the
gate, drawn in the Scene view as a red line: the path every skeleton will walk.

### Idea — the rest of the road

Rows 3 to 8 hold 21 more road tiles: the climb from row 2 to row 4, the long stretch west
along row 4, the climb up the west edge to row 7, the stretch east along row 7, and the
gate. Most are straights as they come. These seven are turned:

| Tile | Column, row | Piece | Rotation Y | Joins |
| --- | --- | --- | --- | --- |
| 10th | 9, 3 | `hex_road_A` | `60` | south-east, and north-west |
| 11th | 9, 4 | `hex_road_B` | `60` | south-east, and west |
| 18th | 2, 4 | `hex_road_B` | `-120` | east, and north-west |
| 19th | 1, 5 | `hex_road_A` | `60` | south-east, and north-west |
| 20th | 1, 6 | `hex_road_B` | `-60` | south-east, and north-east |
| 29th | 9, 7 | `hex_road_B` | `180` | west, and north-east |
| 30th | 10, 8 | `hex_road_A` | `-60` | south-west, and north-east: the gate's tile |

The bend at column 1 of row 7, which joins south-west and east, is a bend just as it
comes.

### Idea — a road, as a list of points

A skeleton can't see road tiles. What it needs is a **path**: a list of points to walk
to, one after another. Put a point in the middle of each road tile, in order from the
dead end to the gate, and a skeleton that walks to point 0, then point 1, then point 2,
follows the road exactly, bends and all.

`WaypointPath` holds those points as an array of **Transforms**: 31 empty GameObjects,
children of `Road`, one in the middle of each of the first 30 road tiles, and the last
just in front of the gate. Being Transforms, they can be moved in the Scene view, and
the path follows.

### Idea — Gizmos

A **Gizmo** is a drawing that shows only in the Scene view, never in the game: the
camera's outline, a collider's green lines, a light's rays. Your own scripts can draw
them too, in a method called **`OnDrawGizmos`**, which Unity calls whenever it redraws
the Scene view, even when the game isn't playing:

| Call | Draws |
| --- | --- |
| `Gizmos.color = Color.red;` | everything after it, in red |
| `Gizmos.DrawSphere(centre, radius)` | a ball |
| `Gizmos.DrawLine(from, to)` | a line |

So the road can draw itself: a ball at every point, and a line from each point to the
next. A point in the wrong place, or two points in the wrong order, shows at once as a
line that cuts across the grass.

### Do it — paint the rest of the road

With the GameObject Brush, the **Paint** tool and the **Active Target** on **Ground**:

1. With `hex_road_A`: row 3, column 9; row 4, columns 3 to 8; row 5, column 1; row 7,
   columns 2 to 8; row 8, column 10.
2. With `hex_road_B`: row 4, columns 2 and 9; row 6, column 1; row 7, columns 1 and 9.
3. Turn the seven tiles in the table.

### Do it — the rest of the grass, and the castle's ground

1. Put `hex_grass` in the brush. With **Box Fill**, drag from column 0 of row 3 to
   column 12 of row 8.
2. Behind the top edge is one more row, row 9, for the castle: paint grass on its
   columns 7 to 12.

### Do it — the trees and the mountain

With the **Active Target** on **Decor**, paint the rest of the `T`, `M` and `.` marks of
the map as in Chapter 1: tree clumps on every `T`; `mountain_A_grass_trees`,
`mountain_B_grass_trees` or `mountain_C_grass` on the two `M`s at columns 2 and 3 of row
8; a rock or a lone tree on about a third of the plain grass. Leave the `b` and `C` cells
bare.

### Do it — the castle and the gate

The castle stands behind the gate, at an angle, facing the road as it comes in from the
south-west. Its pieces aren't on the hex cells, so they're placed by hand. Make an empty
GameObject, `Castle`, at `(0, 0, 0)`, and drag these into it from `Assets/Art/Models`,
each with its **Position**, **Rotation** and **Scale**:

| Model | Position | Rotation | Scale |
| --- | --- | --- | --- |
| `building_castle_blue` | (9, 0, 8.66) | (0, -150, 0) | 1.1 |
| `building_tower_A_blue` | (5, 0, 8.66) | (0, -150, 0) | 1 |
| `building_tower_B_blue` | (12, 0, 6.928) | (0, -150, 0) | 1 |
| `flag_blue` | (11, 0, 5.196) | (0, -150, 0) | 3 |
| `wall_straight` | (6.268, 0, 7.928) | (0, -150, 0) | 1 |
| `wall_straight` | (9.732, 0, 5.928) | (0, -150, 0) | 1 |
| `trees_A_medium` | (3, 0, 8.66) | (0, 60, 0) | 1 |

Then drag `wall_straight_gate` into the scene on its own, not into `Castle`: it gets a
script of its own in Chapter 5. Rename it `Gate`, and set its **Position** to `(8, 0,
6.928)`, the middle of the gate's tile, and its **Rotation** to `(0, -150, 0)`, between
the two walls. Open its arrow: its two doors, `wall_straight_gate_door_left` and
`_right`, are separate parts, ready to move.

### Do it — WaypointPath

Create `Assets/Scripts/WaypointPath.cs`:

```csharp:WaypointPath.cs
using UnityEngine;

// The road, as the skeletons see it: a list of points, one at the middle of
// each road tile, from the ruins to the gate. A skeleton walks to the first
// point, then the next, and so on.
public class WaypointPath : MonoBehaviour
{
    [SerializeField] Transform[] waypoints;

    public int Count
    {
        get { return waypoints.Length; }
    }

    public Vector3 GetPoint(int index)
    {
        return waypoints[index].position;
    }

    // Gizmos draw only in the Scene view: the road as a red line, a ball at
    // every point. Handy for checking the points are in order.
    void OnDrawGizmos()
    {
        if (waypoints == null)
        {
            return;
        }
        Gizmos.color = Color.red;
        for (int i = 0; i < waypoints.Length; i++)
        {
            if (waypoints[i] == null)
            {
                continue;
            }
            Gizmos.DrawSphere(waypoints[i].position, 0.15f);
            if (i > 0 && waypoints[i - 1] != null)
            {
                Gizmos.DrawLine(waypoints[i - 1].position, waypoints[i].position);
            }
        }
    }
}
```

`Count` and `GetPoint` are all a skeleton will need: how many points there are, and
where point number `index` is. The array stays private: nothing else can change the
road.

### Do it — the road's 31 points

1. Make an empty GameObject, `Road`, at `(0, 0, 0)`, and add `WaypointPath` to it.
2. Make 31 empty children of `Road`, named `Waypoint 0` to `Waypoint 30`, at these
   positions. Each is the middle of a road tile, so the skeletons walk down the middle of
   the road; the last stops 0.8 units short of the gate's middle, in front of its doors.

| Waypoint | Position | | Waypoint | Position | | Waypoint | Position |
| --- | --- | --- | --- | --- | --- | --- | --- |
| 0 | (-9, 0, -5.196) | | 11 | (6, 0, 0) | | 22 | (-7, 0, 5.196) |
| 1 | (-7, 0, -5.196) | | 12 | (4, 0, 0) | | 23 | (-5, 0, 5.196) |
| 2 | (-5, 0, -5.196) | | 13 | (2, 0, 0) | | 24 | (-3, 0, 5.196) |
| 3 | (-3, 0, -5.196) | | 14 | (0, 0, 0) | | 25 | (-1, 0, 5.196) |
| 4 | (-1, 0, -5.196) | | 15 | (-2, 0, 0) | | 26 | (1, 0, 5.196) |
| 5 | (1, 0, -5.196) | | 16 | (-4, 0, 0) | | 27 | (3, 0, 5.196) |
| 6 | (3, 0, -5.196) | | 17 | (-6, 0, 0) | | 28 | (5, 0, 5.196) |
| 7 | (5, 0, -5.196) | | 18 | (-8, 0, 0) | | 29 | (7, 0, 5.196) |
| 8 | (7, 0, -5.196) | | 19 | (-9, 0, 1.732) | | 30 | (7.6, 0, 6.235) |
| 9 | (8, 0, -3.464) | | 20 | (-10, 0, 3.464) | | | |
| 10 | (7, 0, -1.732) | | 21 | (-9, 0, 5.196) | | | |

3. Select `Road`. Lock the Inspector (the padlock at its top-right), select all 31
   waypoints in the Hierarchy (click `Waypoint 0`, Shift-click `Waypoint 30`), and drag
   them onto the **Waypoints** field's name: Unity adds all 31. Unlock the Inspector, and
   check the order: **Element 0** must be `Waypoint 0`, and **Element 30** `Waypoint 30`.

> **Tip:** make `Waypoint 0`, then **Ctrl + D** (**Cmd + D** on a Mac) makes the next:
> Unity names the copy `Waypoint 1` by itself, and you only type its position.

### Test it

Look at the Scene view from above. A red line runs down the middle of the road, from the
dead end to the gate, through a red ball on every tile, and never leaves the road. If it
cuts a corner, a waypoint is in the wrong place, or the array is in the wrong order: click
the balls along the line to find which. Press **Play**: the Game view shows the whole
battlefield, the castle at the top-right, and no red line. Gizmos are only for you.

### Challenge

Turn on **Gizmos** in the Game view (the button at the top of the Game view): now the
line shows there too, while you play. Turn it off again. Then make the line show only
while `Road` is selected: rename `OnDrawGizmos` to `OnDrawGizmosSelected`, and click
`Road` and away. Which is more use while you build? Put it back to `OnDrawGizmos`.

# Part 2 — The Skeletons

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

## Chapter 3 — Bones That Walk

**Goal:** the Minion, imported with a **Humanoid Avatar**, walks with a clip that comes
from another file, carries a blade in its bony hand, and follows the road from the ruins
to the gate.

### Idea — a rig, and a Humanoid Avatar

A character model holds a **rig**: a hidden skeleton of **bones** (hips, spine, arms,
legs, fingers), and a mesh that bends with them. Turn the upper arm bone, and the arm
turns. A clip moves bones.

KayKit's characters, the four skeletons, the Ranger and the Mage, all share one rig,
**Rig_Medium**, and their clips live in other files, made on that rig:
`Rig_Medium_General.fbx`, `Rig_Medium_Special.fbx` and so on. To let a clip from one file
play on a body from another, Unity needs to know that this bone is a hip and that one a
knee. That's an **Avatar**, and with the Rig tab's **Animation Type** set to
**Humanoid**, Unity makes one for each file by itself: it maps the file's bones onto a
standard human body.

| Animation Type | What a clip stores | A clip plays on |
| --- | --- | --- |
| **None** | (no rig) | nothing: the tiles |
| **Generic** | the movements of the file's own bones, by name | models with exactly those bones |
| **Humanoid** | the movements of the standard human body | **any** Humanoid model |

So the walk made for the pack's test dummy plays on the Minion, the Warrior and the
archer alike. KayKit's own guide gives that advice for Unity, and it's how studios share
one set of clips across many characters.

### Idea — the clips we'll use

The six clip files hold 97 clips. This book uses 14 of them:

| File | Clips | For |
| --- | --- | --- |
| `Rig_Medium_Special` | `Skeletons_Walking`, `Skeletons_Spawn_Ground`, `Skeletons_Death` | the skeletons walk, rise and fall (Chapters 3 to 5) |
| `Rig_Medium_CombatMelee` | `Melee_1H_Attack_Chop`, `Melee_2H_Attack_Chop` | chopping at the gate (Chapters 4 and 6) |
| `Rig_Medium_Simulation` | `Cheering` | when the gate falls (Chapter 4) |
| `Rig_Medium_MovementBasic` | `Running_A`, `Walking_A` | the Rogue runs, the Warrior marches (Chapter 6) |
| `Rig_Medium_CombatRanged` | `Ranged_Bow_Idle`, `Ranged_Bow_Aiming_Idle`, `Ranged_Bow_Release`, `Ranged_Magic_Spellcasting`, `Ranged_Magic_Shoot` | the archer and the mage (Chapters 8 and 9) |
| `Rig_Medium_General` | `Idle_A` | the mage, waiting (Chapter 9) |

### Idea — a clip's own settings, in the Import Settings

A clip inside a model is **read-only**: the Animation window shows it, but won't change
it. Its settings live in the model's Import Settings, on the **Animation** tab: pick the
clip in the **Clips** list, and its settings show below.

| Setting | Value | Why |
| --- | --- | --- |
| **Loop Time** | on for walking and other repeating clips; off for a rise, a chop, a fall | as for any clip |
| **Root Transform Rotation**: **Bake Into Pose** | on, **Based Upon** **Original** | the clip may not turn the character: the code decides which way it faces |
| **Root Transform Position (Y)**: **Bake Into Pose** | on, **Based Upon** **Original** | a rise out of the ground and a fall to it stay in the body; the GameObject stays on the road |
| **Root Transform Position (XZ)**: **Bake Into Pose** | on, **Based Upon** **Original** | the clip may not move the character along the ground: the code moves it, at its own speed |

The **root** is the whole character's place and facing. **Baking** a movement into the
pose keeps it inside the clip, as a movement of the body: the skeleton's bones rise out
of the ground, and its GameObject stays exactly where the code put it. **Original**
means *as the artist made it*. Leave **Loop Pose** off: KayKit's loops already end where
they start.

### Idea — a weapon on a bone

The skeleton's hands have two extra bones made for holding things: `handslot.r` and
`handslot.l`. A bone is a Transform, a child of the bone before it: `hips`, `spine`,
`chest`, `upperarm.r`, `lowerarm.r`, `wrist.r`, `hand.r`, `handslot.r`. Make a weapon
a child of `handslot.r`, and it goes wherever the hand goes, with no code at all.

### Idea — walking the road in code

The skeleton walks from waypoint to waypoint. Three Unity methods do the work, and all
three are about **not overshooting**:

| Call | Gives |
| --- | --- |
| `Vector3.MoveTowards(from, to, maxStep)` | a point up to `maxStep` from `from`, towards `to`, and never past it: at the end, exactly `to` |
| `Quaternion.LookRotation(direction)` | the rotation that faces along `direction`: KayKit's characters face their +z |
| `Quaternion.RotateTowards(from, to, maxDegrees)` | a rotation up to `maxDegrees` from `from`, towards `to` |

Each frame, the skeleton moves `speed × Time.deltaTime` along the road, and turns at
most `turnSpeed × Time.deltaTime` degrees towards where it's going: at 540° a second, a
bend of 120° takes it under a quarter of a second. When it lands exactly on its
waypoint, it heads for the next one.

### Do it — the characters, as Humanoids

1. Open `Assets/Art/Characters`, and select the six models: `Mage`, `Ranger`,
   `Skeleton_Mage`, `Skeleton_Minion`, `Skeleton_Rogue` and `Skeleton_Warrior` (not the
   pictures). In the Inspector:
   - on the **Rig** tab, set **Animation Type** to **Humanoid**, leave **Avatar
     Definition** on **Create From This Model**, and click **Apply**;
   - on the **Animation** tab, untick **Import Animation**, and click **Apply**;
   - on the **Model** tab, untick **Import Cameras** and **Import Lights**, and click
     **Apply**.
2. Open `Skeleton_Minion`'s arrow in the Project window: beside its meshes is a new
   asset, `Skeleton_MinionAvatar`. Select `Skeleton_Minion`, and on the **Rig** tab click
   **Configure…**: a scene opens with the Minion and a body diagram, every circle green,
   every bone mapped. Click **Done**.
3. Open `Assets/Art/Animations`, select the six `Rig_Medium_…` files, and on the **Rig**
   tab set **Animation Type** to **Humanoid**, with **Create From This Model**. **Apply**.
   The Console fills with red: 56 lines, all the same.

   ```
   Assertion failed on expression: 'IsFinite(curve.GetKey(0).value)'
   ```

   They come from two clips in `Rig_Medium_General` that this book doesn't use,
   `Spawn_Air` and `Spawn_Ground`. On their first frame every bone is shrunk to nothing,
   and Unity can't work out a human body's movements from a body of size zero, so it
   leaves out those two clips' arms and legs. Everything else imports as it should.
   Click **Clear** in the Console. The lines come back whenever that file is imported
   again, after an **Apply** on it in Chapter 9, for example: clear them again.

### Do it — the walk

1. Select `Rig_Medium_Special`, and open the **Animation** tab. The **Clips** list shows
   its 15 clips. Click `Skeletons_Walking`.
2. Tick **Loop Time**. Under **Root Transform Rotation**, **Root Transform Position (Y)**
   and **Root Transform Position (XZ)**, tick **Bake Into Pose** and set **Based Upon**
   to **Original**: three times. Click **Apply**.
3. At the bottom of the Inspector is the clip's preview, with a test dummy in it. Drag
   `Skeleton_Minion` from the Project window onto the preview, and press its ▶: the
   Minion walks on the spot, its arms swinging, in a clip that was made for another
   model.

### Do it — the Minion

1. Drag `Skeleton_Minion` into the Hierarchy. Set its **Position** to `(0, 0, 0)` and its
   **Scale** to `(0.42, 0.42, 0.42)`: about one unit tall, half a hex.
2. It came with an **Animator**, with its **Avatar** already set to
   `Skeleton_MinionAvatar`. Untick **Apply Root Motion**: our code moves it.
3. Type `handslot` into the Hierarchy's search box: two bones show, `handslot.l` and
   `handslot.r`. Drag `Skeleton_Blade` from `Assets/Art/Weapons` onto `handslot.r`.
   Clear the search. Check the blade's **Position** and **Rotation** are `(0, 0, 0)`:
   the pack made it to sit in the hand just so.

### Do it — a controller to test with

An Animator plays clips through an **Animator Controller**. The next C# chapter is all
about controllers; for now, one that plays a single clip is enough.

1. In `Assets/Animation`, right-click → **Create → Animation → Animator Controller**, and
   name it `Walk Test`.
2. Double-click it: the **Animator** window opens. Open `Rig_Medium_Special`'s arrow in
   the Project window, and drag `Skeletons_Walking` from inside it into the window's grid:
   an orange box appears, the state that plays first.
3. Select `Skeleton_Minion`, and drag `Walk Test` into its Animator's **Controller**.

### Do it — Enemy

Create `Assets/Scripts/Enemy.cs`, add it to `Skeleton_Minion`, and drag `Road` into its
**Path**:

```csharp
using UnityEngine;

// A skeleton on the road. For now it only walks: from the first point of the
// road to the last, turning to face the way it goes.
public class Enemy : MonoBehaviour
{
    [SerializeField] WaypointPath path;
    [SerializeField] float speed = 1.5f;            // units a second, on the road
    [SerializeField] float turnSpeed = 540f;        // degrees a second

    int nextPoint;

    void Start()
    {
        nextPoint = 1;
        transform.position = path.GetPoint(0);
        transform.rotation = Quaternion.LookRotation(path.GetPoint(1) - path.GetPoint(0));
    }

    void Update()
    {
        if (nextPoint < path.Count)
        {
            Walk();
        }
    }

    // Walks towards the next point on the road, turning to face it.
    void Walk()
    {
        Vector3 target = path.GetPoint(nextPoint);
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        Vector3 toTarget = target - transform.position;
        if (toTarget.sqrMagnitude > 0.0001f)
        {
            Quaternion facing = Quaternion.LookRotation(toTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, facing, turnSpeed * Time.deltaTime);
        }

        if (transform.position == target)
        {
            nextPoint++;
            if (nextPoint >= path.Count)
            {
                Debug.Log("A skeleton reached the gate");
            }
        }
    }
}
```

Read it before you move on:

- `Start` puts the skeleton on the first waypoint, facing the second.
- `nextPoint` is the waypoint it's heading for. Each frame, `Walk` moves it there and
  turns it to face it; when it arrives, `nextPoint` goes up by one.
- `toTarget.sqrMagnitude > 0.0001f` asks *is there anywhere left to look?* Standing
  exactly on its waypoint, `toTarget` is `(0, 0, 0)`, and a rotation that faces
  *nowhere* means nothing. The square of the length is quicker to work out than the
  length, and just as good for asking *is it almost zero?*
- After the last waypoint, `Update` stops calling `Walk`: the skeleton stands at the gate.

### Test it

Press **Play**. The Minion jumps to the dead end in the ruins, faces east, and walks:
along the bottom, round the bends, back west across the middle, up the west edge, east
along the top, and up to the gate, where it stops, and the Console says:

```
A skeleton reached the gate
```

Watch a bend closely: the body turns smoothly, and the feet keep walking. While it
walks, select it and open the **Animation** window (**Ctrl + 6** / **Cmd + 6**): the
clip, `Skeletons_Walking`, is there, but greyed out and marked read-only. It belongs to
its file.

### Challenge

Set **Speed** to `4`, then `0.5`. At 4, it slides, its feet too slow for the road; at
0.5, it walks on the spot. Find the speed where the feet look planted on the road, and
write it down: Chapter 6 needs the idea. Put it back to `1.5`.

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

## Chapter 4 — Rise, Walk, Fall

**Goal:** the skeletons' own Animator Controller, `Skeleton`. A skeleton rises out of the
ground, walks the road at a speed the code sets, and chops at the gate; it can fall, or
cheer, from whatever it's doing. The code drives it with a Float and a Trigger, through
hashes.

### Idea — the Skeleton controller

| State | Clip (from) | Settings |
| --- | --- | --- |
| **Rise** (the default) | `Skeletons_Spawn_Ground` (Special): 3.6 s | **Speed** `2`: 1.8 s |
| **Walk** | `Skeletons_Walking` (Special): 1.6 s, looping | **Speed** × **WalkSpeed** |
| **Attack** | `Melee_1H_Attack_Chop` (CombatMelee): 1.1 s | |
| **Die** | `Skeletons_Death` (Special): 2 s | |
| **Cheer** | `Cheering` (Simulation): 1.7 s, looping | |

```
   Rise ── when the clip ends ──► Walk ── Attack ──► Attack
   Any State ── Die ──► Die
   Any State ── Cheer ──► Cheer
```

| Parameter | Type | Set by the code when… |
| --- | --- | --- |
| `WalkSpeed` | Float, default `1` | it walks at full speed (1), or slowed (0.5, in Chapter 9) |
| `Attack` | Trigger | it reaches the gate |
| `Die` | Trigger | it has no health left, or has hit the gate (Chapter 5) |
| `Cheer` | Trigger | the gate falls (Chapter 13) |

Two of the arrows come from **Any State**, because a skeleton can be cut down while it
rises, walks or chops. Attack has no way out: a skeleton at the gate chops once, and
falls (Chapter 5). Die has no way out either: its last frame, a heap of bones, stays.

### Idea — 3D bodies blend

In 2D, a transition jumps from one drawing to the next: halfway between two drawings is
nothing at all. A 3D body can be halfway between two poses, so a **Transition Duration**
of `0.1` seconds lets the walk melt into the chop, instead of snapping.

### Idea — a state's Speed Multiplier

Every state has a **Speed**: `1` plays its clip as it was made, `2` twice as fast. Below
it, **Multiplier** can take a Float parameter, and then the clip plays at **Speed ×
that parameter**. With `WalkSpeed` as the Walk state's multiplier, the code does two
things for a slowed skeleton: it moves it at half speed along the road, and sets
`WalkSpeed` to `0.5`, so its legs move at half speed too. Without the second, a frozen
skeleton would trot on the spot as it crawled along.

### Do it — the clips' settings

Set these clips up as you set up `Skeletons_Walking`: on each, **Bake Into Pose** and
**Based Upon** **Original** for all three Root Transform rows, and **Loop Time** as the
table says. **Apply** each file before you leave it.

| File | Clip | Loop Time |
| --- | --- | --- |
| `Rig_Medium_Special` | `Skeletons_Spawn_Ground` | off |
| `Rig_Medium_Special` | `Skeletons_Death` | off |
| `Rig_Medium_CombatMelee` | `Melee_1H_Attack_Chop` | off |
| `Rig_Medium_Simulation` | `Cheering` | on |

### Do it — the Skeleton controller

1. In `Assets/Animation`, make an Animator Controller called `Skeleton`, and open it.
2. On the Animator window's **Parameters** tab, add a **Float** `WalkSpeed`, and set its
   default to `1`; then three **Triggers**: `Die`, `Attack` and `Cheer`.
3. Drag the five clips in, from inside their files: `Skeletons_Spawn_Ground`,
   `Skeletons_Walking`, `Melee_1H_Attack_Chop`, `Skeletons_Death` and `Cheering`. Rename
   the states `Rise`, `Walk`, `Attack`, `Die` and `Cheer`.
4. Right-click `Rise` → **Set as Layer Default State**: it turns orange.
5. Select `Rise`, and set its **Speed** to `2`. Select `Walk`; beside **Multiplier**,
   tick **Parameter**, and choose `WalkSpeed`.
6. Make the transitions (right-click a state → **Make Transition**, then click the
   other). For each, open **Settings**, and set **Transition Duration** to `0.1`:

| From | To | Has Exit Time | Conditions |
| --- | --- | --- | --- |
| Rise | Walk | on, **Exit Time** `1` | none |
| Walk | Attack | off | `Attack` |
| Any State | Die | off | `Die` |
| Any State | Cheer | off | `Cheer` |

7. On the two **Any State** transitions, untick **Can Transition To Self**: a second
   `Die` mustn't start the fall again.
8. Select `Skeleton_Minion`, drag `Skeleton` into its Animator's **Controller**, and
   delete `Walk Test`.

### Do it — Enemy drives the Animator

Replace `Enemy` with this version:

```csharp
using UnityEngine;

// A skeleton on the road, with its Animator: it rises out of the ground,
// walks the road, and chops at the gate when it gets there. The code moves
// it; the Animator only shows the body doing it.
[RequireComponent(typeof(Animator))]
public class Enemy : MonoBehaviour
{
    static readonly int WalkSpeedHash = Animator.StringToHash("WalkSpeed");
    static readonly int AttackHash = Animator.StringToHash("Attack");

    [SerializeField] WaypointPath path;
    [SerializeField] float speed = 1.5f;            // units a second, on the road
    [SerializeField] float turnSpeed = 540f;        // degrees a second
    [SerializeField] float riseSeconds = 1.8f;      // as long as the Rise state
    [SerializeField] float walkFactor = 1f;         // 1 is full speed: try 0.5 while it plays

    Animator animator;
    int nextPoint;
    float startTime;
    bool atGate;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Start()
    {
        nextPoint = 1;
        startTime = Time.time;
        transform.position = path.GetPoint(0);
        transform.rotation = Quaternion.LookRotation(path.GetPoint(1) - path.GetPoint(0));
    }

    void Update()
    {
        // WalkSpeed is the Walk state's Speed Multiplier: at 0.5, its clip
        // plays at half speed, as the skeleton walks at half speed.
        animator.SetFloat(WalkSpeedHash, walkFactor);

        if (Time.time - startTime < riseSeconds || atGate)
        {
            return;                     // still rising, or at the gate already
        }
        Walk(walkFactor);
    }

    // Walks towards the next point on the road, turning to face it. factor is
    // 1 at full speed, 0.5 at half.
    void Walk(float factor)
    {
        Vector3 target = path.GetPoint(nextPoint);
        transform.position = Vector3.MoveTowards(transform.position, target, speed * factor * Time.deltaTime);

        Vector3 toTarget = target - transform.position;
        if (toTarget.sqrMagnitude > 0.0001f)
        {
            Quaternion facing = Quaternion.LookRotation(toTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, facing, turnSpeed * Time.deltaTime);
        }

        if (transform.position == target)
        {
            nextPoint++;
            if (nextPoint >= path.Count)
            {
                atGate = true;
                animator.SetTrigger(AttackHash);
            }
        }
    }
}
```

Read it before you move on:

- The two hashes are made once, for the whole class: `static readonly`, as in
  C# 4.
- `riseSeconds` is how long the Rise state lasts: its 3.6-second clip at Speed 2. For
  now, the skeleton waits that long before it walks. In Chapter 5, the clip itself will
  say when it's up.
- `walkFactor` is a test: a number in the Inspector that you can change while the game
  plays. The skeleton walks at `speed × walkFactor`, and `WalkSpeed` gets the same
  number, so the legs keep up with the road.
- `atGate` makes sure the `Attack` trigger is set once, not every frame.

### Test it

Press **Play**, and select `Skeleton_Minion` with the **Animator** window open.

- In the ruins, the skeleton claws its way out of the ground, then walks. In the
  Animator window, a blue bar fills `Rise`, then `Walk`.
- While it walks, set **Walk Factor** to `0.5`: it walks at half speed, and its legs
  move in slow motion. Try `0.2`. Put it back to `1`.
- At the gate, it chops once, and stands.
- Play again. While it walks, click the circle beside `Die` in the **Parameters** list:
  it falls into a heap of bones, and the heap **slides on along the road**. The Animator
  only shows the body. The code doesn't know the skeleton is dead, so it walks it on.
  Chapter 5 gives the code a mind of its own, with states, to stop exactly that.
- Click `Cheer`: it cheers, sliding along. Stop the game.

### Challenge

Set the Rise state's **Speed** back to `1`: the rise takes 3.6 seconds, and the skeleton
starts walking while still half in the ground, because the code waits only
`riseSeconds`. Two numbers that must agree, in two places: that's the problem Chapter
5's Animation Events solve. Put the Speed back to `2`.

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

## Chapter 5 — The Enemy's State Machine

**Goal:** the skeleton gets a mind: a state machine in code, kept in step with its body
by three Animation Events, added to the imported clips in their Import Settings. It rises,
walks, chops at the gate (whose doors shudder) and falls, and while you test, a key hits
every skeleton on the road: each flashes red, and the third hit fells it. A spawner sends
a new skeleton every three seconds, made from a prefab, the Minion.

### Idea — the skeleton, as a state machine

| State | What it does | The Animator | Leaves for |
| --- | --- | --- | --- |
| **Rising** | waits; it can't be hit yet | Rise (the default state) | Walking, on the `OnRisen` event |
| **Walking** | walks the road | Walk | At Gate, at the last waypoint; Dying, with no health left |
| **At Gate** | waits for its blade to land | the `Attack` trigger | Dying, on the `OnGateHit` event, which costs the gate its lives |
| **Dying** | waits for the fall to end; then it's removed | the `Die` trigger | nothing: `OnDeathFinished` destroys it |

```
            OnRisen              last waypoint             OnGateHit
   Rising ──────────► Walking ─────────────────► AtGate ────────────► Dying
                        │                                               ▲
                        └──────────────── no health left ───────────────┘
                               OnDeathFinished: gone (a bounty if a tower killed it)
```

The code decides **what** the skeleton does; the Animator shows the body doing it, as in
C# 7. They meet in three places, each an Animation Event on a clip:

| Event | On the clip | At | The code… |
| --- | --- | --- | --- |
| `OnRisen` | `Skeletons_Spawn_Ground` | 98% | starts walking: the skeleton is up |
| `OnGateHit` | `Melee_1H_Attack_Chop` | 55% | costs the gate its lives, as the blade lands |
| `OnDeathFinished` | `Skeletons_Death` | 98% | pays the bounty, if a tower killed it, and destroys the skeleton |

Chapter 4's `riseSeconds` is gone: the clip itself says when the skeleton is up. Change
the Rise state's Speed, and the event moves with it.

### Idea — events on an imported clip

An imported clip is read-only in the Animation window, so its events go where its other
settings are: the model's **Import Settings**, **Animation** tab, under the clip, in
**Events**. An event's place is shown as a share of the clip, from 0% at its start to 100%
at its end: Unity calls it **normalised time**. That's also how a studio's animators
hand their clips over: the events travel inside the model's import settings.

Why 98%, and not 100%? An event on a clip's very last frame can be missed when the clip
is left through a blending transition (C# 5). The last frame but one or
two is just as good, and always reached.

### Idea — a red flash, not a clip

When an arrow hits, the skeleton should show it. In Crypt Keys, a Hurt clip did that.
Here, a Hurt state would stop the walk while it played: an Animator at Level 3 has **one
layer**, and plays one state at a time. So the hit shows in code: every part of the body
turns red for 0.08 seconds, in a coroutine.

`GetComponentsInChildren<SkinnedMeshRenderer>()` finds the body's parts: a **Skinned
Mesh Renderer** draws a mesh that bends with bones. `part.material.color = Color.red`
tints one part. `material`, not `sharedMaterial`: the first time it's used, Unity gives
that renderer its own copy of the material, so one skeleton can flash red without every
skeleton in the game flashing with it.

> **Note:** Level 5's **Animator layers** play two states at once: a walk on the legs,
> and a flinch on top. Then a hit can be a clip again.

### Idea — a spawner, and Begin

From now on there's no skeleton in the scene. The **Minion** is a prefab, and a spawner
makes a copy every three seconds: `Instantiate(prefab, position, rotation, parent)`,
from Level 2, with the new skeleton put under `Skeletons`, to keep the Hierarchy tidy.

A prefab can't point at anything in a scene: its fields can't hold the `Road` or the
`Gate`. So the spawner hands each new skeleton what it needs, through a method, `Begin`,
called the moment it's made. The skeleton needs the road, and to tell the gate it hit
it. One object, `Gate Game`, will hold everything the battlefield shares: the gate now,
and the gold in Chapter 7. So the spawner hands each skeleton two things: the game, and
the road.

### Idea — the gate's first property clip

The gate's two doors are separate parts of its model, and each turns about its hinge:
the pack's artist put each door's pivot at its hinge, at the outer edge. A clip that
turns the doors a few degrees about **y**, one way and back, makes the gate shudder under
a blow.

| Parameter | Type | Set by |
| --- | --- | --- |
| `Hit` | Trigger | `Gate`, when a skeleton's blade lands |

```
   Shut ── Hit ──► Shudder ── when the clip ends ──► Shut
```

### Do it — the three events

Do this for each row of the table below:

1. Select the clip file in `Assets/Art/Animations`, open the **Animation** tab, and click
   the clip in the **Clips** list.
2. At the bottom of the Inspector, in the preview, drag the time bar until the readout
   under it says the percentage in the table.
3. Scroll up to **Events**, and open it. Click **Add Event**, the button at the left of
   its strip: a marker appears at the preview's time. With the marker selected, type the
   method's name in **Function**.
4. Click **Apply**.

| File | Clip | At | Function |
| --- | --- | --- | --- |
| `Rig_Medium_Special` | `Skeletons_Spawn_Ground` | 98% | `OnRisen` |
| `Rig_Medium_CombatMelee` | `Melee_1H_Attack_Chop` | 55% | `OnGateHit` |
| `Rig_Medium_Special` | `Skeletons_Death` | 98% | `OnDeathFinished` |

The chop's 55% is the frame its blade meets the gate. Scrub the preview through the chop
with the Minion in it, and you'll see it.

### Do it — the gate's clips

1. Select `Gate`. In the Animation window, click **Create**, and save
   `Assets/Animation/Gate Shut.anim`. Unity adds an Animator to `Gate`, and makes a
   controller named `Gate`.
2. Set **Samples** to `30`. Add the doors' turns: **Add Property →
   wall_straight_gate_door_left → Transform → Rotation**, and again for
   `wall_straight_gate_door_right`.
3. Make the clips, from the window's clip menu, **Create New Clip…** for the second:

| Clip | Loop Time | Left door's Rotation.y | Right door's Rotation.y |
| --- | --- | --- | --- |
| `Gate Shut` | on | `0` at `0:00` and `1:00` | `0` at `0:00` and `1:00` |
| `Gate Shudder` | **off** | `0` at `0:00`, `4` at `0:02`, `-4` at `0:05`, `3` at `0:07`, `0` at `0:09` | the same numbers, each the other way: `0`, `-4`, `4`, `-3`, `0` |

To set a key, move the playhead to its time and type the value into the curve's box in
the window's list, on the left: a key appears at the playhead. In `Gate Shudder`, drag
the `1:00` keys back to `0:09`, or delete them: the clip ends at its last key.

### Do it — the gate's Animator

Open the `Gate` controller. Rename the states `Shut` and `Shudder`; `Shut` is the
default. Add a **Trigger**, `Hit`, and two arrows, each with **Transition Duration** `0`:

| From | To | Has Exit Time | Conditions |
| --- | --- | --- | --- |
| Shut | Shudder | off | `Hit` |
| Shudder | Shut | on, **Exit Time** `1` | none |

### Do it — Gate

Create `Assets/Scripts/Gate.cs`, and add it to `Gate`:

```csharp
using UnityEngine;

// The castle gate. Every skeleton that reaches it hits it, and the doors
// shudder: the Hit trigger. For now the Console counts the lives it costs;
// Chapter 7 takes them from the bank.
public class Gate : MonoBehaviour
{
    static readonly int HitHash = Animator.StringToHash("Hit");

    Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void TakeHit(int lives)
    {
        animator.SetTrigger(HitHash);
        Debug.Log($"The gate is hit: {lives} lives lost");
    }
}
```

### Do it — Gate Game

Make an empty GameObject, `Gate Game`, at `(0, 0, 0)`. Create
`Assets/Scripts/GateGame.cs`, and add it to `Gate Game`:

```csharp
using UnityEngine;

// The game itself: the one object every piece of the battlefield can ask for
// what it needs. For now it knows the gate. It grows a little in most
// chapters, and in Chapter 13 it runs the whole game as a state machine.
public class GateGame : MonoBehaviour
{
    [SerializeField] Gate gate;

    // Chapter 13 gives the game its states: start, playing, paused, won and
    // lost. Until then, it's always being played.
    public bool IsPlaying
    {
        get { return true; }
    }

    public Gate Gate
    {
        get { return gate; }
    }
}
```

`IsPlaying` is a **stand-in**: a property every piece of the game can ask, *is the game
being played?*, that always answers yes for now. Chapter 13 gives the game a start
screen, a pause and an end, and makes the answer real, with no change to anything that
asks.

### Do it — Enemy, as a state machine

Replace `Enemy` with this version:

```csharp
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

// A skeleton on the road, run as a state machine. The code decides what it
// does; its Animator, the Skeleton controller, only shows the body: rising
// from the ground, walking, chopping at the gate, falling.
[RequireComponent(typeof(Animator))]
public class Enemy : MonoBehaviour
{
    public enum State { Rising, Walking, Dying, AtGate }

    static readonly int WalkSpeedHash = Animator.StringToHash("WalkSpeed");
    static readonly int DieHash = Animator.StringToHash("Die");
    static readonly int AttackHash = Animator.StringToHash("Attack");

    [SerializeField] int maxHealth = 6;
    [SerializeField] float speed = 1.5f;            // units a second, on the road
    [SerializeField] int bounty = 5;                // gold, for the tower that finishes it
    [SerializeField] int livesCost = 1;             // what it costs the gate
    [SerializeField] float turnSpeed = 540f;        // degrees a second

    GateGame game;
    WaypointPath path;
    Animator animator;
    Renderer[] bodyRenderers;
    State state;
    int health;
    int nextPoint;
    bool killedByTower;
    Coroutine flash;

    // Only a skeleton that's up and walking can be hit.
    public bool IsTargetable
    {
        get { return state == State.Walking; }
    }

    void Awake()
    {
        animator = GetComponent<Animator>();
        bodyRenderers = GetComponentsInChildren<SkinnedMeshRenderer>();
    }

    // The spawner calls this as soon as it makes the skeleton: a prefab can't
    // point at things in the scene, so it's handed them here.
    public void Begin(GateGame owner, WaypointPath road)
    {
        game = owner;
        path = road;
        health = maxHealth;
        nextPoint = 1;
        transform.position = path.GetPoint(0);
        transform.rotation = Quaternion.LookRotation(path.GetPoint(1) - path.GetPoint(0));
        EnterState(State.Rising);
    }

    void Update()
    {
        // Before Begin, and while the game isn't being played, it waits.
        if (game == null || !game.IsPlaying)
        {
            return;
        }

        // A test, until the towers shoot in Chapter 8: H hits every skeleton.
        Keyboard keyboard = Keyboard.current;
        if (keyboard != null && keyboard.hKey.wasPressedThisFrame)
        {
            TakeDamage(2);
        }

        switch (state)
        {
            case State.Rising:
                break;                  // waits for the OnRisen Animation Event
            case State.Walking:
                Walk(1f);
                break;
            case State.Dying:
                break;                  // waits for OnDeathFinished
            case State.AtGate:
                break;                  // waits for OnGateHit
        }
    }

    // The one place the state changes. The enter step runs once, as the
    // skeleton arrives in its new state.
    void EnterState(State next)
    {
        state = next;

        switch (state)
        {
            case State.Rising:
                break;
            case State.Walking:
                animator.SetFloat(WalkSpeedHash, 1f);
                break;
            case State.Dying:
                animator.SetTrigger(DieHash);
                break;
            case State.AtGate:
                animator.SetTrigger(AttackHash);
                break;
        }
    }

    // Walks towards the next point on the road, turning to face it. factor is
    // 1 at full speed, 0.5 at half.
    void Walk(float factor)
    {
        Vector3 target = path.GetPoint(nextPoint);
        transform.position = Vector3.MoveTowards(transform.position, target, speed * factor * Time.deltaTime);

        Vector3 toTarget = target - transform.position;
        if (toTarget.sqrMagnitude > 0.0001f)
        {
            Quaternion facing = Quaternion.LookRotation(toTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, facing, turnSpeed * Time.deltaTime);
        }

        if (transform.position == target)
        {
            nextPoint++;
            if (nextPoint >= path.Count)
            {
                EnterState(State.AtGate);
            }
        }
    }

    // Something hit it.
    public void TakeDamage(int damage)
    {
        if (!IsTargetable)
        {
            return;
        }
        health -= damage;
        if (flash != null)
        {
            StopCoroutine(flash);
        }
        flash = StartCoroutine(FlashRed());
        if (health <= 0)
        {
            killedByTower = true;
            EnterState(State.Dying);
        }
    }

    // Animation Event: the end of the Rise clip, once it's out of the ground.
    public void OnRisen()
    {
        if (state == State.Rising)
        {
            EnterState(State.Walking);
        }
    }

    // Animation Event: the chop's frame, as the blade hits the gate.
    public void OnGateHit()
    {
        if (state != State.AtGate)
        {
            return;
        }
        game.Gate.TakeHit(livesCost);
        killedByTower = false;          // no bounty for this one
        EnterState(State.Dying);
    }

    // Animation Event: the end of the Die clip.
    public void OnDeathFinished()
    {
        if (killedByTower)
        {
            Debug.Log($"+{bounty} gold");       // Chapter 7 puts it in the bank
        }
        Destroy(gameObject);
    }

    // An Animator has one layer at Level 3, so a hit can't play a clip without
    // stopping the walk. The hit shows as a red flash instead, for a moment.
    IEnumerator FlashRed()
    {
        SetColour(Color.red);
        yield return new WaitForSeconds(0.08f);
        SetColour(Color.white);
        flash = null;
    }

    void SetColour(Color colour)
    {
        foreach (Renderer part in bodyRenderers)
        {
            part.material.color = colour;
        }
    }
}
```

Read it before you move on:

- `Update` runs the current state's own work, and `EnterState` is the one place the
  state changes, as in C# 6. Rising, Dying and At Gate do nothing each
  frame: they're waiting for an event.
- `Begin` replaces `Start`. Everything a fresh skeleton needs is set there, ending with
  `EnterState(State.Rising)`.
- `IsTargetable` answers *can it be hit?* Only while it walks: not while it's still in
  the ground, at the gate, or already falling. `TakeDamage` asks it first, so a skeleton
  can't be killed twice.
- Each event method checks the state before it acts, as in C# 7: an
  `OnGateHit` from a chop that a hit already interrupted mustn't cost the gate a life.
- `killedByTower` remembers *why* it's dying: hit to death, or crumbling after its chop at
  the gate. Only the first pays a bounty. For now, the bounty goes to the Console;
  Chapter 7 puts it in the bank.
- H is a test, until the towers shoot in Chapter 8. Every skeleton reads the key itself,
  so one press hits them all.

### Do it — the Minion prefab

1. Select `Skeleton_Minion`, and rename it `Minion`. Its **Path** field is gone: it gets
   the road from `Begin` now.
2. Drag it from the Hierarchy into `Assets/Prefabs`. Unity asks what kind of prefab to
   make: choose **Original Prefab**. (A **Prefab Variant** is a prefab that inherits from
   another: Level 4.)
3. Delete `Minion` from the scene.

### Do it — the spawner

1. Make an empty GameObject, `Skeletons`, at `(0, 0, 0)`: every skeleton goes in here.
2. Create `Assets/Scripts/WaveSpawner.cs`, and add it to `Gate Game`:

```csharp
using System.Collections;
using UnityEngine;

// Sends skeletons up the road from the ruins. For now it sends one every few
// seconds, for ever, taking the kinds in turn. Chapter 11 turns it into ten
// waves.
public class WaveSpawner : MonoBehaviour
{
    [SerializeField] GateGame game;
    [SerializeField] WaypointPath path;
    [SerializeField] Transform skeletonGroup;     // every skeleton goes here
    [SerializeField] Enemy[] kinds;               // sent in turn
    [SerializeField] float gap = 3f;              // seconds between one skeleton and the next

    void Start()
    {
        StartCoroutine(SendSkeletons());
    }

    // A coroutine: a skeleton, a wait, the next, for ever.
    IEnumerator SendSkeletons()
    {
        int next = 0;
        while (true)
        {
            Enemy enemy = Instantiate(kinds[next], path.GetPoint(0), Quaternion.identity, skeletonGroup);
            enemy.Begin(game, path);
            next = (next + 1) % kinds.Length;
            yield return new WaitForSeconds(gap);
        }
    }
}
```

3. Select `Gate Game`, and fill in the fields: `Gate` into **Gate**; on the spawner,
   `Gate Game` itself into **Game**, `Road` into **Path**, `Skeletons` into **Skeleton
   Group**, and the `Minion` prefab into **Kinds**, as **Element 0**.

`next = (next + 1) % kinds.Length` counts 0, 1, 2… and back to 0 at the end of the
array: with one kind, it's always 0; in Chapter 6, with four, it goes round all four.

### Test it

Press **Play**.

- Every three seconds a Minion claws its way out of the ground in the ruins, and sets off
  along the road: a line of them, three seconds apart.
- Press **H**: every walking skeleton flashes red. Those still rising don't: they can't be
  hit yet. Press it twice more: they fall into heaps of bones, and a moment later each
  heap is gone, and the Console says `+5 gold` for each.
- Let one reach the gate: it chops, the gate's doors shudder on the blow, the Console
  says `The gate is hit: 1 lives lost`, and the skeleton crumbles where it stands. No
  gold for that one.
- Watch the Hierarchy: skeletons appear under `Skeletons`, and disappear as they're
  destroyed.

### Challenge

Select a skeleton while it walks, and switch the Inspector to **Debug** (the **⋮** menu
at its top-right): the private fields show, **State** among them. Watch it change as you
press H. Then move the `OnGateHit` marker to 20%: the gate shudders before the blade gets
there. Put it back to 55%.

## Chapter 6 — Four Kinds of Skeleton

**Goal:** three more skeletons, the Rogue, the Warrior and the Bone Mage. Each is the
same `Enemy` script with its own numbers, and the same `Skeleton` controller with some
of its own clips, through **Override Controllers**. The spawner sends the four kinds in
turn.

### Idea — one script, other numbers

| Kind | Model | Scale | Max Health | Speed | Bounty | Lives Cost | Weapons |
| --- | --- | --- | --- | --- | --- | --- | --- |
| **Minion** | `Skeleton_Minion` | 0.42 | 6 | 1.5 | 5 | 1 | `Skeleton_Blade` on `handslot.r` |
| **Rogue** | `Skeleton_Rogue` | 0.42 | 4 | 2.6 | 6 | 1 | none: it runs |
| **Warrior** | `Skeleton_Warrior` | 0.42 | 18 | 1 | 12 | 2 | `Skeleton_Axe` on `handslot.r`, `Skeleton_Shield_Large_A` on `handslot.l` |
| **Bone Mage** | `Skeleton_Mage` | 0.62 | 150 | 0.7 | 100 | 5 | `Skeleton_Staff` on `handslot.r` |

The rule from C# 7: the same behaviour with other numbers is **one script**
and another prefab. The four kinds walk the same road, rise, chop and fall the same way;
only their numbers differ, and their numbers are in the Inspector.

### Idea — other clips, the same machine

The Rogue runs, and the Warrior marches; the Bone Mage chops with its staff in both
hands. Everything else, every state and every arrow, is the `Skeleton` controller's. An
**Animator Override Controller** borrows a controller's whole state machine and swaps
some of its clips:

| Override Controller | Clip in `Skeleton` | Played instead |
| --- | --- | --- |
| `Rogue Override` | `Skeletons_Walking` | `Running_A` (MovementBasic) |
| `Warrior Override` | `Skeletons_Walking` | `Walking_A` (MovementBasic) |
| `Bone Mage Override` | `Melee_1H_Attack_Chop` | `Melee_2H_Attack_Chop` (CombatMelee) |

An empty slot plays the original clip, so each override fills in only what differs.

The Bone Mage's chop is a different clip, so it needs its own `OnGateHit`. The other
events stay where they are: an event belongs to its clip, and the Rogue rises and dies
with the Minion's clips.

### Do it — the clips' settings

As before: **Bake Into Pose** and **Based Upon** **Original** on all three Root Transform
rows, **Loop Time** as the table says, the event as in Chapter 5, and **Apply**.

| File | Clip | Loop Time | Event |
| --- | --- | --- | --- |
| `Rig_Medium_MovementBasic` | `Running_A` | on | |
| `Rig_Medium_MovementBasic` | `Walking_A` | on | |
| `Rig_Medium_CombatMelee` | `Melee_2H_Attack_Chop` | off | `OnGateHit` at 55% |

### Do it — the three Override Controllers

1. In `Assets/Animation`, right-click → **Create → Animation → Animator Override
   Controller**, and name it `Rogue Override`.
2. Set its **Controller** to `Skeleton`. The list shows the five clips `Skeleton` plays,
   each with an empty **Override** slot. Drag `Running_A` into the slot beside
   `Skeletons_Walking`.
3. Make `Warrior Override` and `Bone Mage Override` the same way, from the table.

### Do it — the three skeletons

For each of the Rogue, the Warrior and the Bone Mage:

1. Drag its model into the Hierarchy, rename it (`Rogue`, `Warrior` or `Bone Mage`), and
   set its **Position** to `(0, 0, 0)` and its **Scale** from the table.
2. On its Animator, untick **Apply Root Motion**, and drag its Override Controller into
   **Controller**.
3. Put its weapons on their bones, as you did the Minion's blade.
4. Add `Enemy`, and type its four numbers in from the table.
5. Drag it into `Assets/Prefabs` as an **Original Prefab**, and delete it from the scene.

### Do it — four kinds in turn

Select `Gate Game`. On the spawner, set **Kinds** to 4 elements: `Minion`, `Rogue`,
`Warrior` and `Bone Mage`.

### Test it

Press **Play**.

- The four rise in turn: a Minion; a Rogue, who runs, and soon overtakes; a Warrior,
  slow behind its shield; and the Bone Mage, half as big again as the others, slowest
  of all.
- Press **H** while they walk: the Rogue falls after two presses, the Minion after
  three. The Warrior takes nine. The Bone Mage takes 75: it's a boss.
- At the gate: a Warrior costs `2 lives`, and the Bone Mage chops with both hands, for
  `5 lives`.
- Watch the Rogue's legs, then the Minion's: one controller, two different walks.

From now on the road is never empty, which is just what Chapters 7 to 10 need while you
build towers. If the Bone Mage gets in your way while you test, take it out of **Kinds**
for a while (set it to 3 elements), and put it back by Chapter 11.

### Challenge

Make a fifth kind, the **Captain**: the Warrior's model, its own override that also swaps
`Melee_1H_Attack_Chop` for `Melee_2H_Attack_Chop` (with its event, already there), more
health, and a bigger bounty. No new code. Add it to **Kinds**, and watch it march. Then
take it out again: the game's waves, in Chapter 11, use the four kinds.

# Part 3 — The Towers

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

## Chapter 7 — Plots and Gold

**Goal:** the gold and the lives on the screen, in a chunky font on pzUH's bars. Thirteen
dirt plots beside the road. Tap or click an empty plot, and a menu opens over it with the
Arrow tower and its price; build it, and the gold goes down. The gate's hits cost lives
now, and when the last one goes, the game is lost.

### Idea — the screen

```
 ┌──────────────────────────────────────────────────────────────────────┐
 │ (◉) 120   (♥) 10   (☠) Wave 3 / 10                       [x2] [II]   │
 │                                                                      │
 │                   ┌──────────────┐                                   │
 │                   │    Build     │  ← the build menu, over the plot  │
 │                   │ [↟] [⚙] [❄]  │                                   │
 │                   │  50  80  60  │                                   │
 │                   └──────────────┘                                   │
 │                      Wave 3 cleared! +35 gold                        │
 │                   [ Start Wave ]   Next wave in 12                   │
 └──────────────────────────────────────────────────────────────────────┘
```

| Thing | Shows | Chapter |
| --- | --- | --- |
| gold, lives | a coin and a number; a heart and a number, on a bar each | this one |
| the build menu | over the plot that was tapped: a button for each tower, its price under it | this one (the Arrow tower), Chapter 9 (all three) |
| the tower menu | over a tower: its name and level, Upgrade, Sell | Chapter 10 |
| the wave, the message, Start Wave | | Chapter 11 |
| x2, pause | | Chapter 12 |

### Idea — pictures that aren't pixel art

pzUH's GUI is painted smooth, not in pixels, so its pictures want the opposite of Knight
Run's and Crypt Keys' settings: **Bilinear** filtering, which blends neighbouring pixels
as a picture is scaled. They're shown on a Canvas, never in the world, so they need no
**mipmaps**: the smaller copies of a texture that a 3D camera uses for things far away.

| Setting | Value |
| --- | --- |
| **Texture Type** | **Sprite (2D and UI)** |
| **Sprite Mode** | **Single** |
| **Generate Mipmaps** (under **Advanced**) | off |
| **Filter Mode** | **Bilinear** |

### Idea — the bank

`Bank` keeps the gold and the lives, as two properties with a **private set**:

```csharp
public int Gold { get; private set; }
```

Any script can read `Gold`; only `Bank` can change it, through its own methods, and each
of them puts the new numbers on the screen. So the screen can never show a number that
isn't in the bank. `Spend` answers a question as it works: `true` if there was enough
gold and it's spent, `false` if there wasn't and nothing changed.

### Idea — which plot was tapped?

The pointer is a point on the screen; the plots are in the world. A **ray from the
camera** joins them: `cam.ScreenPointToRay(screenPoint)` gives the line that starts at
the camera and goes out through that point on the screen, into the scene. Level 2's
`Physics.Raycast` follows it to the first collider it meets:

```csharp
Ray ray = cam.ScreenPointToRay(pointer.position.ReadValue());
if (Physics.Raycast(ray, out RaycastHit hit, 200f, plotMask))
```

`plotMask` is a **layer mask** holding just the **Plot** layer: the ray goes straight
through skeletons, towers and trees, and stops only at a plot's collider.

`Pointer.current` is the Input System's mouse or touchscreen, whichever is used: a
click and a tap are the same press. And a press on a button belongs to the button:
`EventSystem.current.IsPointerOverGameObject()` is `true` while the pointer is over the
UI, and then the `Picker` leaves the press alone.

### Idea — a menu over a 3D tile

The build menu belongs to the Canvas, but it must open over the plot, wherever the plot
is on the screen. `cam.WorldToScreenPoint(point)` is the ray's opposite: it gives the
place on the screen, in pixels, where a point in the world is drawn. Put the menu's
**pivot**, the middle of its bottom edge, at the point 1.5 units above the plot, and the
menu stands on the plot. Then `Mathf.Clamp` keeps it inside the screen: a plot at the top
edge can't push its menu off.

### Idea — a button you can't press

A **Button** has an **interactable** tick box. Untick it, from the Inspector or from
code, and the button stops taking presses and shows its **Disabled** look. With the
**Sprite Swap** transition, each look is its own picture, and pzUH drew four for every
button:

| Button state | pzUH picture | When |
| --- | --- | --- |
| **Normal** | `SquareNormal` | waiting |
| **Highlighted** | `SquareHover` | the mouse is over it |
| **Pressed** | `SquareClick` | it's being pressed |
| **Disabled** | `SquareLocked` | `interactable` is off: here, you can't afford the tower |

The build menu checks the gold every frame it's open, so a skeleton's bounty can light up
a button while you look at it.

### Do it — the pictures, and the font

1. Select every picture in `Assets/Art/UI` and `Assets/Art/Icons`, and set them as the
   table in *Pictures that aren't pixel art* says. **Apply**.
2. Select `LilitaOne-Regular` in `Assets/Art/Fonts`, then **Assets → Create →
   TextMeshPro → Font Asset → SDF**. Unity asks to import **TMP Essentials** the first
   time: click **Import TMP Essentials**, close the window, and do this step again.
3. Open the new `LilitaOne-Regular SDF`'s arrow, select `LilitaOne-Regular Atlas
   Material`, and under **Outline** set **Color** to a dark brown, `#2B1B10`, and
   **Thickness** to `0.18`: every letter gets a dark edge, so it reads on any colour.
4. **Edit → Project Settings → TextMesh Pro → Settings**, and drag `LilitaOne-Regular
   SDF` into **Default Font Asset**: every new text starts in Lilita One.

### Do it — the Canvas

1. **GameObject → UI (Canvas) → Canvas**. Unity makes a **Canvas** and an
   **EventSystem**.
2. In the Canvas's **Canvas Scaler**, set **UI Scale Mode** to **Scale With Screen
   Size**, **Reference Resolution** to `1920 × 1080`, and **Match** to `0.5`.

> **Watch out:** the **GameObject** menu always puts new UI straight onto the Canvas.
> To put a UI element **inside** another, right-click the parent in the Hierarchy and
> choose **UI (Canvas) → …** there.

### Do it — the gold and the lives

Make these, each from the menu its **Parent** says. Anchor each with **Shift + Alt**
(**Shift + Option** on a Mac), so its pivot moves to the same place, and untick **Raycast
Target** on every one: they're only there to be seen.

| Object | Type | Parent | Anchor | Pos | Size |
| --- | --- | --- | --- | --- | --- |
| `Gold Bar` | Image | Canvas | top-left | (30, −30) | 264 × 95 |
| `Icon` | Image | Gold Bar | middle-left | (14, 0) | 66 × 66 |
| `Gold Text` | Text - TextMeshPro | Gold Bar | middle-left | (100, 2) | 160 × 80 |
| `Lives Bar` | Image | Canvas | top-left | (320, −30) | 264 × 95 |
| `Icon` | Image | Lives Bar | middle-left | (14, 0) | 66 × 66 |
| `Lives Text` | Text - TextMeshPro | Lives Bar | middle-left | (100, 2) | 160 × 80 |

The bars show `Bar`; the icons `Coin` and `Hearts`, with **Preserve Aspect** ticked. The
texts say `120` and `10`, **Font Size** `44`, colour a warm white, `#FFF7E6`, aligned
**left** and **middle**.

### Do it — Bank

Create `Assets/Scripts/Bank.cs`, add it to `Gate Game`, and drag `Gold Text` and `Lives
Text` into its two text fields:

```csharp:Bank.cs
using TMPro;
using UnityEngine;

// The player's gold, and the gate's lives. Both are properties with a
// private set: any script can read them, but only Bank changes them, through
// its methods, so the numbers on the screen always match.
public class Bank : MonoBehaviour
{
    [SerializeField] int startGold = 120;
    [SerializeField] int startLives = 10;
    [SerializeField] TMP_Text goldText;
    [SerializeField] TMP_Text livesText;

    public int Gold { get; private set; }
    public int Lives { get; private set; }

    public bool CanAfford(int cost)
    {
        return Gold >= cost;
    }

    // Takes the gold and answers true, or answers false if there isn't enough.
    public bool Spend(int cost)
    {
        if (!CanAfford(cost))
        {
            return false;
        }
        Gold -= cost;
        UpdateText();
        return true;
    }

    public void Earn(int amount)
    {
        Gold += amount;
        UpdateText();
    }

    public void LoseLives(int amount)
    {
        Lives = Mathf.Max(0, Lives - amount);
        UpdateText();
    }

    public void ResetBank()
    {
        Gold = startGold;
        Lives = startLives;
        UpdateText();
    }

    void UpdateText()
    {
        goldText.text = Gold.ToString();
        livesText.text = Lives.ToString();
    }
}
```

`Mathf.Max(0, Lives - amount)` stops the lives at 0: a Bone Mage at the gate with 3 lives
left takes the gate to 0, not to −2.

### Do it — the game fills the bank

Replace `GateGame` with this version, and drag `Gate Game` itself into its new **Bank**
field (Unity picks its `Bank`):

```csharp
using UnityEngine;

// The game itself: the one object every piece of the battlefield can ask for
// what it needs. Now it knows the bank as well as the gate, and it fills the
// bank as the game starts.
public class GateGame : MonoBehaviour
{
    [SerializeField] Bank bank;
    [SerializeField] Gate gate;

    // Chapter 13 gives the game its states: start, playing, paused, won and
    // lost. Until then, it's always being played.
    public bool IsPlaying
    {
        get { return true; }
    }

    public Bank Bank
    {
        get { return bank; }
    }

    public Gate Gate
    {
        get { return gate; }
    }

    void Awake()
    {
        bank.ResetBank();
    }

    // The gate calls this when its last life goes. Chapter 13 makes it the
    // Lost state, with its own panel.
    public void Lose()
    {
        Debug.Log("The gate has fallen");
    }
}
```

`Lose` is another stand-in: the gate calls it when its last life goes, and for now the
Console says so.

### Do it — the gate costs lives

Replace `Gate` with this version, and drag `Gate Game` into both its **Game** and its
**Bank** fields:

```csharp
using UnityEngine;

// The castle gate. Every skeleton that reaches it costs lives, and the doors
// shudder (the Hit trigger). When the last life goes, the game is lost.
public class Gate : MonoBehaviour
{
    static readonly int HitHash = Animator.StringToHash("Hit");

    [SerializeField] GateGame game;
    [SerializeField] Bank bank;

    Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void TakeHit(int lives)
    {
        if (bank.Lives <= 0)
        {
            return;
        }
        bank.LoseLives(lives);
        if (bank.Lives > 0)
        {
            animator.SetTrigger(HitHash);
        }
        else
        {
            game.Lose();
        }
    }
}
```

`if (bank.Lives <= 0) return;` at the top: once the gate has fallen, more blows change
nothing.

### Idea — a build plot

A plot is a dirt hex with a **Box Collider** for the ray to hit, on the **Plot** layer,
and a script, `BuildPlot`, that remembers the tower built on it. It's a prefab, and the
GameObject Brush can paint prefabs as well as models: the 13 plots go where the map has
a `b`.

When a tower is built, the plot makes it from its prefab, and hands it what a prefab
can't point at: the game, and `Shots`, where its arrows will go. It's `Begin` again,
called `Build` here.

### Do it — Tower

Create `Assets/Scripts/Tower.cs`. It goes on the towers you'll make later in this
chapter; for now, it only has to exist, because the plot needs it:

```csharp
using UnityEngine;

// A tower on a plot. For now it only stands there, and says so: Chapter 8
// teaches it to shoot.
public class Tower : MonoBehaviour
{
    [SerializeField] string title = "Arrow Tower";
    [SerializeField] int cost = 50;

    public int BuildCost
    {
        get { return cost; }
    }

    // The plot calls this as soon as it makes the tower. The tower doesn't
    // need the game or the shots yet; it will in Chapter 8.
    public void Build(GateGame owner, Transform shots)
    {
        Debug.Log($"{title} built");
    }
}
```

The game and the shots are handed to `Build`, and it doesn't keep them yet: a tower that
can't shoot doesn't need them. Chapter 8's will.

### Do it — the Build Plot prefab

1. Add a layer: select any GameObject, open **Layer → Add Layer…**, and type `Plot` into
   an empty **User Layer**.
2. Make an empty GameObject, `Build Plot`, at `(0, 0, 0)`, and set its **Layer** to
   **Plot**. Drag `building_dirt` from `Assets/Art/Models` onto it: its dirt sits on the
   grass, at `(0, 0, 0)`.
3. **Add Component → Box Collider** on `Build Plot`: **Center** `(0, 0.1, 0)`, **Size**
   `(1.8, 0.2, 2)`. A flat box over the hex: easy to hit.

Create `Assets/Scripts/BuildPlot.cs`, and add it to `Build Plot`:

```csharp:BuildPlot.cs
using UnityEngine;

// A dirt plot beside the road, where a tower can stand. Its Box Collider, on
// the Plot layer, is what the Picker's ray hits.
public class BuildPlot : MonoBehaviour
{
    [SerializeField] GateGame game;
    [SerializeField] Transform towerGroup;      // every tower goes here
    [SerializeField] Transform shotGroup;       // and every tower's shots here

    Tower tower;

    public Tower Tower
    {
        get { return tower; }
    }

    public bool IsEmpty
    {
        get { return tower == null; }
    }

    public void Build(Tower towerPrefab)
    {
        tower = Instantiate(towerPrefab, transform.position, Quaternion.identity, towerGroup);
        tower.Build(game, shotGroup);
    }

    // Sold, or on Restart: the plot is empty again.
    public void Clear()
    {
        if (tower != null)
        {
            Destroy(tower.gameObject);
        }
        tower = null;
    }
}
```

Drag `Build Plot` into `Assets/Prefabs` as an **Original Prefab**, and delete it from
the scene.

### Do it — paint the plots

1. Right-click `Battlefield` → **Create Empty**, name the child `Build Plots`, and **Add
   Component → Tilemap**: the GameObject Brush paints only onto objects of the Grid.
2. Make two empty GameObjects at `(0, 0, 0)`: `Towers` and `Shots`. Every tower built
   goes into the first, and every arrow into the second.
3. In the Tile Palette, set the **Active Target** to **Build Plots**, put the `Build
   Plot` **prefab** into the brush's **Game Object**, and **Paint** the 13 `b` cells of
   the map:

| Row | Columns |
| --- | --- |
| 6 | 3, 6, 9 |
| 5 | 4, 7 |
| 3 | 3, 6, 10 |
| 2 | 2, 5, 8 |
| 0 | 4, 7 |

4. Select all 13 `Build Plot`s under `Build Plots`, and drag `Gate Game` into **Game**,
   `Towers` into **Tower Group** and `Shots` into **Shot Group**: one drag sets all 13.

### Do it — the Arrow tower's body

1. Make an empty GameObject, `Arrow Tower`, at `(0, 0, 0)`. Drag `building_tower_base_green`
   onto it, and rename the child `Base`: a stone tower, 1.5 units tall.
2. Right-click `Arrow Tower` → **Create Empty**: name it `Top`, at `(0, 1.38, 0)`, the
   floor of the tower's top. The crew stands on it.
3. Drag `Ranger` from `Assets/Art/Characters` onto `Top`: **Position** `(0, 0, 0)`,
   **Scale** `(0.36, 0.36, 0.36)`. On its Animator, untick **Apply Root Motion**. Put
   `bow_withString` from `Assets/Art/Weapons` on its `handslot.l`: archers hold the bow
   in the left hand.
4. Set up `Ranged_Bow_Idle` in `Rig_Medium_CombatRanged` as you set up the walk: **Loop
   Time** on, **Bake Into Pose** and **Original** on all three Root Transform rows.
   **Apply**.
5. Make an Animator Controller, `Crew`, in `Assets/Animation`, and drag
   `Ranged_Bow_Idle` into it: its default state. Rename the state `Idle`. Drag `Crew`
   into the Ranger's Animator's **Controller**. Chapter 8 gives `Crew` its other states.
6. Add `Tower` to `Arrow Tower`. Its **Title** is `Arrow Tower`, its **Cost** `50`.
7. Drag `Arrow Tower` into `Assets/Prefabs` as an **Original Prefab**, and delete it from
   the scene.

### Do it — the build menu

Make these, as before. The menu has room for three towers; for now, it has one.

| Object | Type | Parent | Anchor | Pos | Size |
| --- | --- | --- | --- | --- | --- |
| `Build Menu` | Image | Canvas | bottom-left | (0, 0) | 450 × 343 |
| `Title` | Text - TextMeshPro | Build Menu | middle-center | (0, 136) | 300 × 60 |
| `Bow Button` | Button - TextMeshPro | Build Menu | middle-center | (−130, 20) | 112 × 112 |
| `Icon` | Image | Bow Button | middle-center | (0, 4) | 65 × 65 |
| `Bow Coin` | Image | Build Menu | middle-center | (−160, −70) | 36 × 38 |
| `Bow Price` | Text - TextMeshPro | Build Menu | middle-center | (−112, −70) | 80 × 50 |

1. `Build Menu` shows `PanelRibbon`. Set its **Pivot** to `(0.5, 0)`, the middle of its
   bottom edge, and keep its **Raycast Target** ticked: a press on the menu, between the
   buttons, belongs to the menu, not to the battlefield behind it.
2. `Title` says `Build`, **Font Size** `40`, centred, in a dark brown, `#4A3420`, the ink
   of the parchment.
3. `Bow Button`: delete its `Text (TMP)` child. Its **Image** shows `SquareNormal`. On
   its **Button**, set **Transition** to **Sprite Swap**: **Highlighted Sprite**
   `SquareHover`, **Pressed Sprite** `SquareClick`, **Selected Sprite** `SquareNormal`,
   **Disabled Sprite** `SquareLocked`.
4. Its `Icon` shows `Bow`, with **Preserve Aspect** ticked and **Raycast Target**
   unticked: a press on the icon is a press on the button.
5. `Bow Coin` shows `Coin`. `Bow Price` says `50`, **Font Size** `36`, centred, `#4A3420`.
   Untick **Raycast Target** on all three.
6. Switch `Build Menu` off: the box beside its name, at the top of the Inspector.

### Do it — BuildMenu

Create `Assets/Scripts/BuildMenu.cs`, and add it to `Build Menu`:

```csharp
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The build menu, over the plot that was tapped. Camera.WorldToScreenPoint
// turns the plot's place in the world into a place on the screen. A tower
// the player can't afford has its button's interactable switched off, so it
// shows its Disabled picture. For now it builds one tower, the Arrow tower:
// Chapter 9 adds the Catapult and the Frost tower.
public class BuildMenu : MonoBehaviour
{
    [SerializeField] Bank bank;
    [SerializeField] Tower[] towerPrefabs;      // Arrow, Catapult, Frost
    [SerializeField] Button[] buttons;          // in the same order
    [SerializeField] TMP_Text[] priceTexts;
    [SerializeField] float heightAbovePlot = 1.5f;

    BuildPlot plot;
    Camera cam;

    public bool IsOpen
    {
        get { return gameObject.activeSelf; }
    }

    void Awake()
    {
        cam = Camera.main;
    }

    // Each button needs its own method to call: buttons[0] builds an Arrow
    // tower.
    void OnEnable()
    {
        buttons[0].onClick.AddListener(BuildArrow);
    }

    void OnDisable()
    {
        buttons[0].onClick.RemoveListener(BuildArrow);
    }

    // While it's open, it stays over its plot, and the buttons keep up with
    // the gold: a bounty can make a tower affordable.
    void Update()
    {
        if (plot == null)
        {
            return;
        }
        PlaceOver(plot.transform.position);
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = bank.CanAfford(towerPrefabs[i].BuildCost);
        }
    }

    public void Open(BuildPlot target)
    {
        plot = target;
        gameObject.SetActive(true);
        for (int i = 0; i < priceTexts.Length; i++)
        {
            priceTexts[i].text = towerPrefabs[i].BuildCost.ToString();
        }
        Update();
    }

    public void Close()
    {
        plot = null;
        gameObject.SetActive(false);
    }

    void BuildArrow()
    {
        Build(0);
    }

    void Build(int index)
    {
        if (plot != null && bank.Spend(towerPrefabs[index].BuildCost))
        {
            plot.Build(towerPrefabs[index]);
        }
        Close();
    }

    // The menu's pivot is the middle of its bottom edge: that point goes over
    // the plot, then the menu is kept inside the screen.
    void PlaceOver(Vector3 worldPoint)
    {
        Vector3 screenPoint = cam.WorldToScreenPoint(worldPoint + Vector3.up * heightAbovePlot);
        RectTransform rect = (RectTransform)transform;
        Vector2 size = rect.rect.size * rect.lossyScale;
        screenPoint.x = Mathf.Clamp(screenPoint.x, size.x / 2f, Screen.width - size.x / 2f);
        screenPoint.y = Mathf.Clamp(screenPoint.y, 0f, Screen.height - size.y);
        rect.position = screenPoint;
    }
}
```

Select `Build Menu`, and fill in its fields: `Gate Game` into **Bank**; set **Tower
Prefabs**, **Buttons** and **Price Texts** to one element each, and drag in the `Arrow
Tower` prefab, `Bow Button` and `Bow Price`.

Read it before you move on:

- `Open` remembers the plot, shows the menu, writes the prices, and calls `Update` at
  once, so the menu is over its plot from its very first frame, not one frame late.
- `Build` asks the bank first: `bank.Spend` takes the gold **and** says whether it could.
  Only then does the plot build.
- A button's `onClick` wants a method with no parameters, but `Build` needs to know which
  tower. So each button gets a little method of its own, `BuildArrow`, that calls
  `Build(0)`. They're connected in `OnEnable`, and disconnected in `OnDisable`, as Level
  2 did.
- `(RectTransform)transform` is a **cast**: on a Canvas, every Transform is a
  RectTransform, and the cast lets us use its size.

### Do it — Picker

Create `Assets/Scripts/Picker.cs`, and add it to `Gate Game`:

```csharp
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

// Works out what the player tapped or clicked. A press that isn't on the UI
// casts a ray from the camera through the pointer: if it hits an empty plot,
// the build menu opens over it. Anywhere else closes it.
public class Picker : MonoBehaviour
{
    [SerializeField] GateGame game;
    [SerializeField] LayerMask plotMask;
    [SerializeField] BuildMenu buildMenu;

    Camera cam;

    void Awake()
    {
        cam = Camera.main;
    }

    void Update()
    {
        Pointer pointer = Pointer.current;
        if (!game.IsPlaying || pointer == null || !pointer.press.wasPressedThisFrame)
        {
            return;
        }
        // A press on a button belongs to the button.
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        Ray ray = cam.ScreenPointToRay(pointer.position.ReadValue());
        if (Physics.Raycast(ray, out RaycastHit hit, 200f, plotMask) && hit.collider.TryGetComponent(out BuildPlot plot) && plot.IsEmpty)
        {
            buildMenu.Open(plot);
        }
        else
        {
            buildMenu.Close();
        }
    }
}
```

Fill in its fields: `Gate Game` into **Game**, **Plot Mask** to **Plot**, and `Build
Menu` into **Build Menu**.

### Test it

Press **Play**. While you test, set the bank's **Start Lives** to `100` if the gate falls
too soon, and put it back to `10` at the end.

- The gold says `120` and the lives `10`.
- Click a plot: the menu opens over it, the Arrow tower at `50`. Click the bow: the menu
  closes, the gold says `70`, a stone tower stands on the plot with an archer on top, and
  the Console says `Arrow Tower built`.
- Build a second: `20`. Click a third plot: the button is grey and locked, and clicking
  it does nothing. Click the grass: the menu closes.
- Click a plot that has a tower: nothing opens. Chapter 10 gives towers their own menu.
- Press H until skeletons fall: the Console still says `+5 gold`, and the bank doesn't
  change. The towers will earn the bounties, in Chapter 8.
- Let skeletons reach the gate: the lives count down, by 2 for a Warrior and 5 for the
  Bone Mage. At 0, the Console says `The gate has fallen`, and the gate stops counting.

### Challenge

Make building take a moment, as on a real building site. When a tower is bought, show
`building_scaffolding` (it's in `Assets/Art/Models`) on the plot for one second, then
remove it and build the tower. Which script changes? A coroutine from Level 2 does the
waiting. And what should happen if the player taps the plot during that second?

## Chapter 8 — The Arrow Tower

**Goal:** the Arrow tower comes alive. Its archer turns to face the skeleton nearest the
gate, draws, and looses an arrow on the very frame the bowstring lets go. The arrow flies
with a white trail, follows its target, and hits. Skeletons killed by a tower pay their
bounty into the bank, and the test key is gone: the towers do the job now.

### Idea — the tower, as a state machine

| State | What it does | The crew's Animator | Leaves for |
| --- | --- | --- | --- |
| **Idle** | looks for a target in range | `Aiming` false | Aim, when it finds one |
| **Aim** | turns to face its target | `Aiming` true | Fire, once it faces it; Idle, if no target is left in range |
| **Fire** | waits for the release frame | the `Fire` trigger | Reload, on the `OnRelease` event |
| **Reload** | waits | | Aim, after **Reload Seconds** |

```
             a target in range            facing it
   Idle ─────────────────────► Aim ─────────────────► Fire
    ▲      none left in range ◄─┘ ▲                     │ OnRelease: the arrow leaves
    └───────────────────────────  └──── Reload ◄────────┘
                                   after Reload Seconds
```

### Idea — first in line

`Physics.OverlapSphere(centre, radius, layerMask)` returns every collider inside a ball,
on the mask's layers: every skeleton within range. Which one to shoot? Not the nearest:
the most dangerous is the one **closest to the gate**, and that's the one that has walked
the furthest. So every skeleton adds up how far it has walked, `DistanceTravelled`, and
the tower keeps the biggest:

```csharp
if (found.TryGetComponent(out Enemy enemy) && enemy.IsTargetable &&
    (best == null || enemy.DistanceTravelled > best.DistanceTravelled))
{
    best = enemy;
}
```

The skeletons need **colliders** on an **Enemy** layer for that, and a collider that
moves every frame should have a **Rigidbody**. It's **kinematic**: moved by our code,
not pushed by physics. The collider is a **trigger**: things pass through it, and
queries still find it.

### Idea — the crew's controller

The archer stands idle, aims while there's a target, and shoots when told:

| State | Clip (CombatRanged) | Settings |
| --- | --- | --- |
| **Idle** (the default) | `Ranged_Bow_Idle`, looping | |
| **Aim** | `Ranged_Bow_Aiming_Idle`: holding the bow drawn, looping | |
| **Shoot** | `Ranged_Bow_Release`: the string lets go, and the arm comes back | **Speed** `2` |

```
   Idle ◄─── Aiming false ─── Aim ─── Fire ───► Shoot
     └────── Aiming true ───►  ▲                  │
                               └─ Exit Time 0.9 ──┘
```

| Parameter | Type | Set by `Tower` |
| --- | --- | --- |
| `Aiming` | Bool | true while it has a target |
| `Fire` | Trigger | when it faces its target, loaded |

A **Bool** for aiming, because aiming is a state the archer stays in; a **Trigger** for
the shot, because a shot is a moment. Shoot plays at double speed: the archer keeps up
with a tower that reloads in under a second.

### Idea — the release frame, and TowerCrew

The arrow must leave the bow on the frame the string lets go: 15% of the way into
`Ranged_Bow_Release`. That's an Animation Event, `OnRelease`, added in the Import
Settings as in Chapter 5. But an event only reaches scripts **on the Animator's own
GameObject** (C# 5): the `Ranger`, not `Arrow Tower`, where `Tower` is.

So a small script sits beside the archer's Animator, and passes the event on:

```
   Ranged_Bow_Release, at 15% ──► TowerCrew.OnRelease() ──► Tower.Release() ──► an arrow
       (on the Ranger)               (on the Ranger)          (on Arrow Tower)
```

### Idea — a tower's numbers, in a plain class

A tower has four numbers: what it costs, how far it reaches, how hard it hits, and how
long it reloads. Chapter 10 will give every tower three sets of them, one per level. So
they go together in a **plain C# class**, `TowerLevel`, not a component: no
`MonoBehaviour` after its name, and it's never added to a GameObject. Marked
`[System.Serializable]`, it shows in the Inspector of a script that keeps one, as a
foldout with its four fields (C# 11 has more).

### Idea — a trail

A **Trail Renderer** draws a ribbon behind a moving object, along the path it took,
fading out after its **Time**: an arrow too quick to see leaves a white streak you can.
The trail's **Width** is a curve along its length, wide at the arrow, nothing at the
tail.

### Do it — skeletons the towers can find

1. Add a layer, `Enemy`, as you added `Plot`.
2. Open each skeleton prefab in turn (double-click it in `Assets/Prefabs`): `Minion`,
   `Rogue`, `Warrior` and `Bone Mage`. On its root:
   - set **Layer** to **Enemy** (and choose **No, this object only** when Unity asks);
   - **Add Component → Capsule Collider**: tick **Is Trigger**, **Center** `(0, 1.1,
     0)`, **Radius** `0.5`, **Height** `2.2`, round the body;
   - **Add Component → Rigidbody**: tick **Is Kinematic**, untick **Use Gravity**.

> **Tip:** set up the Minion, then right-click its **Capsule Collider**'s title →
> **Copy Component**. In the next prefab, right-click any component's title → **Paste
> Component As New**. Same for the Rigidbody.

### Do it — Enemy, for the towers

Replace `Enemy` with this version:

```csharp
using System.Collections;
using UnityEngine;

// A skeleton on the road, run as a state machine. The code decides what it
// does; its Animator, the Skeleton controller, only shows the body: rising
// from the ground, walking, chopping at the gate, falling. Every kind of
// skeleton is this one script, with its own numbers in the Inspector.
[RequireComponent(typeof(Animator))]
public class Enemy : MonoBehaviour
{
    public enum State { Rising, Walking, Dying, AtGate }

    static readonly int WalkSpeedHash = Animator.StringToHash("WalkSpeed");
    static readonly int DieHash = Animator.StringToHash("Die");
    static readonly int AttackHash = Animator.StringToHash("Attack");

    [SerializeField] int maxHealth = 6;
    [SerializeField] float speed = 1.5f;            // units a second, on the road
    [SerializeField] int bounty = 5;                // gold, for the tower that finishes it
    [SerializeField] int livesCost = 1;             // what it costs the gate
    [SerializeField] float turnSpeed = 540f;        // degrees a second

    GateGame game;
    WaypointPath path;
    Animator animator;
    Collider bodyCollider;
    Renderer[] bodyRenderers;
    State state;
    int health;
    int nextPoint;
    float distanceTravelled;
    bool killedByTower;
    Coroutine flash;

    // How far along the road it has walked: the towers aim at the biggest.
    public float DistanceTravelled
    {
        get { return distanceTravelled; }
    }

    // Towers only shoot at a skeleton that's up and walking.
    public bool IsTargetable
    {
        get { return state == State.Walking; }
    }

    void Awake()
    {
        animator = GetComponent<Animator>();
        bodyCollider = GetComponent<Collider>();
        bodyRenderers = GetComponentsInChildren<SkinnedMeshRenderer>();
    }

    // The spawner calls this as soon as it makes the skeleton: a prefab can't
    // point at things in the scene, so it's handed them here.
    public void Begin(GateGame owner, WaypointPath road)
    {
        game = owner;
        path = road;
        health = maxHealth;
        nextPoint = 1;
        distanceTravelled = 0f;
        transform.position = path.GetPoint(0);
        transform.rotation = Quaternion.LookRotation(path.GetPoint(1) - path.GetPoint(0));
        EnterState(State.Rising);
    }

    void Update()
    {
        // Before Begin, and while the game isn't being played, it waits.
        if (game == null || !game.IsPlaying)
        {
            return;
        }

        switch (state)
        {
            case State.Rising:
                break;                  // waits for the OnRisen Animation Event
            case State.Walking:
                Walk(1f);
                break;
            case State.Dying:
                break;                  // waits for OnDeathFinished
            case State.AtGate:
                break;                  // waits for OnGateHit
        }
    }

    // The one place the state changes. The enter step runs once, as the
    // skeleton arrives in its new state.
    void EnterState(State next)
    {
        state = next;

        switch (state)
        {
            case State.Rising:
                bodyCollider.enabled = false;           // the towers can't see it yet
                break;
            case State.Walking:
                bodyCollider.enabled = true;
                animator.SetFloat(WalkSpeedHash, 1f);
                break;
            case State.Dying:
                bodyCollider.enabled = false;
                animator.SetTrigger(DieHash);
                break;
            case State.AtGate:
                bodyCollider.enabled = false;
                animator.SetTrigger(AttackHash);
                break;
        }
    }

    // Walks towards the next point on the road, turning to face it. factor is
    // 1 at full speed, 0.5 at half.
    void Walk(float factor)
    {
        Vector3 target = path.GetPoint(nextPoint);
        Vector3 before = transform.position;
        transform.position = Vector3.MoveTowards(before, target, speed * factor * Time.deltaTime);
        distanceTravelled += Vector3.Distance(before, transform.position);

        Vector3 toTarget = target - transform.position;
        if (toTarget.sqrMagnitude > 0.0001f)
        {
            Quaternion facing = Quaternion.LookRotation(toTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, facing, turnSpeed * Time.deltaTime);
        }

        if (transform.position == target)
        {
            nextPoint++;
            if (nextPoint >= path.Count)
            {
                EnterState(State.AtGate);
            }
        }
    }

    // A tower's shot hit it.
    public void TakeDamage(int damage)
    {
        if (!IsTargetable)
        {
            return;
        }
        health -= damage;
        if (flash != null)
        {
            StopCoroutine(flash);
        }
        flash = StartCoroutine(FlashRed());
        if (health <= 0)
        {
            killedByTower = true;
            EnterState(State.Dying);
        }
    }

    // Animation Event: the end of the Rise clip, once it's out of the ground.
    public void OnRisen()
    {
        if (state == State.Rising)
        {
            EnterState(State.Walking);
        }
    }

    // Animation Event: the chop's frame, as the blade hits the gate.
    public void OnGateHit()
    {
        if (state != State.AtGate)
        {
            return;
        }
        game.Gate.TakeHit(livesCost);
        killedByTower = false;          // no bounty for this one
        EnterState(State.Dying);
    }

    // Animation Event: the end of the Die clip.
    public void OnDeathFinished()
    {
        if (killedByTower)
        {
            game.Bank.Earn(bounty);
        }
        Destroy(gameObject);
    }

    // An Animator has one layer at Level 3, so a hit can't play a clip without
    // stopping the walk. The hit shows as a red flash instead, for a moment.
    IEnumerator FlashRed()
    {
        SetColour(Color.red);
        yield return new WaitForSeconds(0.08f);
        SetColour(Color.white);
        flash = null;
    }

    void SetColour(Color colour)
    {
        foreach (Renderer part in bodyRenderers)
        {
            part.material.color = colour;
        }
    }
}
```

What's new:

- `bodyCollider` is switched on only while the skeleton walks. A rising skeleton, one at
  the gate and one already falling can't be found by a tower at all.
- `Walk` adds up `distanceTravelled`, and `DistanceTravelled` lets the towers read it.
- `OnDeathFinished` pays the bounty into the bank: `game.Bank.Earn(bounty)`. The game
  holds the bank, as it holds the gate.
- The H test is gone.

### Do it — the bow's clips

Set these up, with **Bake Into Pose** and **Original** on all three Root Transform rows:

| File | Clip | Loop Time | Event |
| --- | --- | --- | --- |
| `Rig_Medium_CombatRanged` | `Ranged_Bow_Aiming_Idle` | on | |
| `Rig_Medium_CombatRanged` | `Ranged_Bow_Release` | off | `OnRelease` at 15% |

### Do it — the Crew controller

1. Open `Crew`. Add a **Bool**, `Aiming`, and a **Trigger**, `Fire`.
2. Drag in `Ranged_Bow_Aiming_Idle` and `Ranged_Bow_Release`, and rename the states
   `Aim` and `Shoot`. Set `Shoot`'s **Speed** to `2`.
3. Make the arrows, each with **Transition Duration** `0.1`:

| From | To | Has Exit Time | Conditions |
| --- | --- | --- | --- |
| Idle | Aim | off | `Aiming` true |
| Aim | Idle | off | `Aiming` false |
| Aim | Shoot | off | `Fire` |
| Shoot | Aim | on, **Exit Time** `0.9` | none |

### Do it — the arrow

1. Make an empty GameObject, `Arrow`. Drag `arrow_bow` from `Assets/Art/Weapons` onto
   it, and rename the child `Model`: **Rotation** `(90, 0, 0)`, **Scale** `(0.9, 0.9,
   0.9)`. The model lies along y; turned 90°, its point faces the arrow's +z, the way it
   will fly.
2. Make a material for trails and sparks: in `Assets/Materials`, **Create → Material**,
   name it `Particle`, and set its **Shader** to **Universal Render Pipeline →
   Particles → Unlit**, **Surface Type** to **Transparent**, and **Base Map** to
   `Default-Particle`, Unity's own soft round dot (click the circle beside **Base Map**,
   and search for it).
3. **Add Component → Trail Renderer** on `Arrow`. Set **Time** to `0.2`, the **Width**
   to `0.05`, and drag the right-hand end of the width curve down to `0`. Set its
   **Color** to white, fading to clear: in the gradient, the left alpha key about 60%,
   the right one 0.
   Drag `Particle` into its **Materials**, and set **Cast Shadows** to **Off**.

### Do it — TowerLevel, Projectile, Tower and TowerCrew

Create `Assets/Scripts/TowerLevel.cs`. It isn't a component: don't attach it to anything.

```csharp
using UnityEngine;

// What a tower can do: what it costs, how far it reaches, how hard it hits,
// and how long it takes to reload. A plain C# class, not a component:
// [System.Serializable] shows its numbers in the Inspector of the script
// that keeps one.
[System.Serializable]
public class TowerLevel
{
    [SerializeField] int cost = 50;             // to build it, or to upgrade to this level
    [SerializeField] float range = 4f;
    [SerializeField] int damage = 1;
    [SerializeField] float reloadSeconds = 1f;  // from one shot to the next

    public int Cost
    {
        get { return cost; }
    }

    public float Range
    {
        get { return range; }
    }

    public int Damage
    {
        get { return damage; }
    }

    public float ReloadSeconds
    {
        get { return reloadSeconds; }
    }
}
```

Create `Assets/Scripts/Projectile.cs`, add it to `Arrow`, and set its **Speed** to `14`.
Then drag `Arrow` into `Assets/Prefabs`, and delete it from the scene.

```csharp
using UnityEngine;

// A tower's shot: for now, an arrow. It flies straight at its target, and
// follows it while it walks.
public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 12f;             // units a second
    [SerializeField] float aimHeight = 0.45f;       // a skeleton's chest, above its feet

    Enemy target;
    TowerLevel stats;
    Vector3 end;

    // mask is the Enemy layer, for Chapter 9's stones, which hit everything
    // where they land. An arrow only hits its target.
    public void Launch(Enemy aim, TowerLevel level, LayerMask mask)
    {
        target = aim;
        stats = level;
        end = AimPoint();
    }

    void Update()
    {
        // Follow the target while it's still walking; otherwise fly on to the
        // last place it was.
        if (target != null && target.IsTargetable)
        {
            end = AimPoint();
        }
        Vector3 before = transform.position;
        transform.position = Vector3.MoveTowards(before, end, speed * Time.deltaTime);
        if (transform.position != before)
        {
            transform.rotation = Quaternion.LookRotation(transform.position - before);
        }
        if (transform.position == end)
        {
            Arrive();
        }
    }

    void Arrive()
    {
        if (target != null)
        {
            target.TakeDamage(stats.Damage);
        }
        Destroy(gameObject);
    }

    Vector3 AimPoint()
    {
        return target.transform.position + Vector3.up * aimHeight;
    }
}
```

`Launch` takes the Enemy layer's mask and doesn't use it yet: Chapter 9's stones hit
everything where they land, and need it. Giving the method that parameter now means
`Tower` won't have to change when they come.

Replace `Tower` with this version:

```csharp
using UnityEngine;

// A tower on a plot, run as a state machine: Idle with nothing in range, Aim
// at the skeleton furthest along the road, Fire, then Reload. Its crew's
// Animator (the archer) is driven with Aiming and Fire, and the shot leaves
// on the crew's own release frame.
public class Tower : MonoBehaviour
{
    public enum State { Idle, Aim, Fire, Reload }

    static readonly int AimingHash = Animator.StringToHash("Aiming");
    static readonly int FireHash = Animator.StringToHash("Fire");

    [SerializeField] string title = "Arrow Tower";
    [SerializeField] TowerLevel stats;
    [SerializeField] Animator crew;
    [SerializeField] Transform turret;          // what turns to face the target
    [SerializeField] Transform muzzle;          // where its shots start
    [SerializeField] Projectile shotPrefab;
    [SerializeField] LayerMask enemyMask;
    [SerializeField] float turnSpeed = 360f;    // degrees a second

    GateGame game;
    Transform shotGroup;
    State state;
    Enemy target;
    float stateStartTime;

    public int BuildCost
    {
        get { return stats.Cost; }
    }

    // The plot calls this as soon as it makes the tower.
    public void Build(GateGame owner, Transform shots)
    {
        game = owner;
        shotGroup = shots;
        Debug.Log($"{title} built");
        EnterState(State.Idle);
    }

    void Update()
    {
        if (game == null || !game.IsPlaying)
        {
            return;
        }

        switch (state)
        {
            case State.Idle:
                target = FindTarget();
                if (target != null)
                {
                    EnterState(State.Aim);
                }
                break;
            case State.Aim:
                if (!InRange(target))
                {
                    target = FindTarget();
                }
                if (target == null)
                {
                    EnterState(State.Idle);
                }
                else if (TurnTowards(target))
                {
                    EnterState(State.Fire);
                }
                break;
            case State.Fire:
                if (InRange(target))
                {
                    TurnTowards(target);
                }
                // The shot leaves on the crew's OnRelease event. If it never
                // comes (the crew was interrupted), aim again.
                if (Time.time - stateStartTime > 2f)
                {
                    EnterState(State.Aim);
                }
                break;
            case State.Reload:
                if (Time.time - stateStartTime >= stats.ReloadSeconds)
                {
                    EnterState(State.Aim);
                }
                break;
        }
    }

    void EnterState(State next)
    {
        state = next;
        stateStartTime = Time.time;

        switch (state)
        {
            case State.Idle:
                target = null;
                crew.SetBool(AimingHash, false);
                break;
            case State.Aim:
                crew.SetBool(AimingHash, true);
                break;
            case State.Fire:
                crew.SetTrigger(FireHash);
                break;
            case State.Reload:
                break;
        }
    }

    // TowerCrew calls this on the crew's OnRelease Animation Event: the
    // frame the arrow leaves the bow.
    public void Release()
    {
        if (state != State.Fire)
        {
            return;
        }
        if (InRange(target))
        {
            Projectile shot = Instantiate(shotPrefab, muzzle.position, Quaternion.identity, shotGroup);
            shot.Launch(target, stats, enemyMask);
        }
        EnterState(State.Reload);
    }

    // The skeleton furthest along the road, within range: the one closest to
    // the gate. Physics.OverlapSphere finds every collider on the Enemy layer
    // inside the circle; the loop keeps the best.
    Enemy FindTarget()
    {
        Enemy best = null;
        foreach (Collider found in Physics.OverlapSphere(transform.position, stats.Range, enemyMask))
        {
            if (found.TryGetComponent(out Enemy enemy) && enemy.IsTargetable &&
                (best == null || enemy.DistanceTravelled > best.DistanceTravelled))
            {
                best = enemy;
            }
        }
        return best;
    }

    bool InRange(Enemy enemy)
    {
        if (enemy == null || !enemy.IsTargetable)
        {
            return false;
        }
        Vector3 offset = enemy.transform.position - transform.position;
        offset.y = 0f;
        return offset.magnitude <= stats.Range;
    }

    // Turns the turret a little towards the enemy, on the ground only, and
    // answers true once it's facing it.
    bool TurnTowards(Enemy enemy)
    {
        Vector3 toEnemy = enemy.transform.position - turret.position;
        toEnemy.y = 0f;
        Quaternion facing = Quaternion.LookRotation(toEnemy);
        turret.rotation = Quaternion.RotateTowards(turret.rotation, facing, turnSpeed * Time.deltaTime);
        return Quaternion.Angle(turret.rotation, facing) < 5f;
    }
}
```

Read it before you move on:

- `Update` runs the four states, as in the skeleton. `EnterState` is where the crew's
  Animator hears about it: `Aiming` on and off, and the `Fire` trigger.
- In **Fire**, the tower waits for the event. If it never comes, because the shot was cut
  short, two seconds later it aims again: never wait **only** for an event
  (C# 5).
- `InRange` measures along the ground only: `offset.y = 0f`. The archer stands 1.4 units
  up, and a skeleton right under the tower shouldn't be out of range.
- `TurnTowards` turns the **turret** only about y, at `turnSpeed` degrees a second, and
  answers `true` once it's within 5° of facing the skeleton. The archer is the tower's
  turret: the whole archer turns on the spot.
- `Release` checks the target is still worth shooting, makes the arrow at the `muzzle`,
  in `Shots`, and launches it with the tower's numbers.

Create `Assets/Scripts/TowerCrew.cs`:

```csharp:TowerCrew.cs
using UnityEngine;

// Sits beside a tower crew's Animator: on the archer, the mage, or the
// catapult. An Animation Event only reaches scripts on the Animator's own
// GameObject, and the Tower script is on the tower, so this passes the event
// on. Without it, the Console says OnRelease has no receiver.
public class TowerCrew : MonoBehaviour
{
    [SerializeField] Tower tower;

    // Animation Event: the frame the shot leaves.
    public void OnRelease()
    {
        tower.Release();
    }
}
```

### Do it — the Arrow tower, armed

Double-click the `Arrow Tower` prefab to open it:

1. Right-click `Top` → **Create Empty**: `Muzzle`, at `(0, 0.45, 0)`, where the arrow
   leaves: the archer's hands.
2. Add `TowerCrew` to `Ranger`, and drag `Arrow Tower` into its **Tower**.
3. On `Arrow Tower`'s `Tower`, open **Stats**, and set **Cost** `50`, **Range** `4`,
   **Damage** `1`, **Reload Seconds** `1`. Drag the `Ranger` into **Crew** (Unity picks
   its Animator) and into **Turret**, `Muzzle` into **Muzzle**, the `Arrow` prefab into
   **Shot Prefab**, and set **Enemy Mask** to **Enemy**.

### Test it

Press **Play**, and build an Arrow tower beside the first stretch of road.

- The archer stands idle. A skeleton walks into range: the archer turns to face it,
  raises the bow and aims, looses, and the arrow streaks across with a white trail, and hits. The
  skeleton flashes red. Again, a second later.
- Six arrows fell a Minion. It crumbles, and as the heap disappears, the gold goes up by
  5.
- With two skeletons in range, the archer shoots the one further along the road, even
  when the other is nearer to the tower.
- Watch an arrow chase a Rogue round a bend: it follows its target. If the target dies
  first, the arrow flies on to where it was, and vanishes.
- Watch the Hierarchy: arrows appear under `Shots`, and are destroyed as they arrive.

### Challenge

Make a tower that shoots the skeleton **nearest the tower** instead: change the test in
`FindTarget` to compare each skeleton's `Vector3.Distance` to the tower. Build one of
each beside a bend, and watch which shoots more often, and which kills more skeletons
before they pass. Put `FindTarget` back.

## Chapter 9 — Catapult and Frost

**Goal:** two more towers, run by the archer's own controller. The **Catapult**'s wooden
arm, animated by property clips, throws a stone in an arc that hits every skeleton where
it lands, in a puff of dust. The **Frost** tower's mage throws a frost bolt that slows a
skeleton to half speed, legs and all, while frost sparkles round it. The build menu
offers all three towers.

### Idea — one controller, three crews

The `Crew` controller has three states, Idle, Aim and Shoot, and two parameters, and
`Tower` drives them the same way whatever the crew is. So the mage and the catapult use
it too, each through an Override Controller with its own three clips:

| Crew | Idle | Aim | Shoot (`OnRelease` on the release frame) |
| --- | --- | --- | --- |
| the archer: `Crew` itself | `Ranged_Bow_Idle` | `Ranged_Bow_Aiming_Idle` | `Ranged_Bow_Release`, at 15% |
| the mage: `Mage Override` | `Idle_A` | `Ranged_Magic_Spellcasting` | `Ranged_Magic_Shoot`, at 40%: the staff points |
| the catapult: `Catapult Override` | `Arm Rest` | `Arm Wound` | `Arm Throw`, at `0:04`: the spoon passes the top |

The archer's and the mage's clips move bones. The catapult's move one part of a wooden
model, its arm, and you make them yourself in the Animation window. The Animator doesn't
mind what its clips move: a state is a state, and a Humanoid body and a wooden arm run
through the same machine.

### Idea — a catapult in three clips

`building_tower_catapult_red` has a turret, `catapult_turret_red`, that can turn about y,
and on it an arm, `catapult_arm_red`, that swings about its own x. Three property clips,
at 30 samples, turn the arm:

| Clip | Loop Time | `catapult_arm_red`'s Rotation.x | Event |
| --- | --- | --- | --- |
| `Arm Rest` | on | `0` at `0:00` and `1:00` | |
| `Arm Wound` | on | `-40` at `0:00` and `1:00`: pulled back | |
| `Arm Throw` | **off** | `-40` at `0:00`, `95` at `0:06`, `95` at `0:18`, `-40` at `1:00` | `OnRelease` at `0:04` |

The throw whips the arm over in six frames, holds it up, and lowers it back. The
stone leaves at `0:04`, as the spoon passes the top. Shoot's Speed `2` plays it all twice
as fast, as it plays the archer's.

### Idea — one script, three shots

An arrow and a frost bolt fly straight at their target, following it. A stone flies in an
**arc** to where its target was when it was thrown, and hits everything where it lands.
They're one script, `Projectile`, with an `enum ProjectileKind { Arrow, Stone, Frost }`
and a `switch` where they differ: Crypt Keys' `Pickup` did the same for its four kinds.

> **Note:** at Level 4, **inheritance** gives each kind its own class: an `Arrow`, a
> `Stone` and a `FrostBolt`, each built on `Projectile`, each with its own `Arrive`. The
> `switch` is exactly where they'd split.

The stone's arc needs no physics. `t` runs from 0 at the throw to 1 at the landing.
Along the ground, the stone moves in a straight line, `Vector3.Lerp(start, end, t)`; up
and down, it rises by `arcHeight × 4t(1 − t)`:

| `t` | 0 | 0.25 | 0.5 | 0.75 | 1 |
| --- | --- | --- | --- | --- | --- |
| `4t(1 − t)` | 0 | 0.75 | 1 | 0.75 | 0 |

0 at both ends, 1 halfway: a curve that rises and falls, the shape of a throw.

### Idea — splash, and slow

`TowerLevel` gains three numbers: **Splash Radius**, **Slow Factor** and **Slow
Seconds**. A stone hits every skeleton within its splash radius of where it lands, with
`Physics.OverlapSphere` again. A frost bolt hits its target, and slows it: **Slow
Factor** `0.5` is half speed, for **Slow Seconds**.

Slowed is a new state for the skeleton, between Walking and Dying. It walks at
`slowFactor`, and sets `WalkSpeed` to the same, so its legs move at half speed too: the
Speed Multiplier from Chapter 4. Frost sparkles round it, and it turns icy blue. When the
time is up, it goes back to Walking, which puts all three back. A second bolt while it's
slowed keeps the slower of the two factors, and the later end.

Slowed goes **in the middle** of the `enum`. With an Int that mirrors the enum, that would
break the Animator's numbering (C# 7). Here the Animator reads `WalkSpeed` and
three triggers, never the state's number, so the order is free.

### Idea — particles

A **Particle System** throws out lots of small pictures, each living for a moment:
smoke, sparks, snow. The dust where a stone lands, and the frost of a bolt, are
**bursts**: they throw out a handful of particles at once, once, and the GameObject
removes itself when they've faded (**Stop Action**: **Destroy**). The frost round a
slowed skeleton is a **loop**: it sparkles for as long as its GameObject is switched on.

### Do it — TowerLevel, Enemy and Projectile

Replace `TowerLevel` with its last version:

```csharp:TowerLevel.cs
using UnityEngine;

// What a tower can do at one of its levels. Every tower keeps three of these,
// one per level, in an array: the numbers live in the Inspector, not in code.
[System.Serializable]
public class TowerLevel
{
    [SerializeField] int cost = 50;             // to build it, or to upgrade to this level
    [SerializeField] float range = 4f;
    [SerializeField] int damage = 1;
    [SerializeField] float reloadSeconds = 1f;  // from one shot to the next
    [SerializeField] float splashRadius;        // 0 hits only the target; more hits everything that close
    [SerializeField] float slowFactor = 1f;     // 1 doesn't slow; 0.5 is half speed
    [SerializeField] float slowSeconds;

    public int Cost
    {
        get { return cost; }
    }

    public float Range
    {
        get { return range; }
    }

    public int Damage
    {
        get { return damage; }
    }

    public float ReloadSeconds
    {
        get { return reloadSeconds; }
    }

    public float SplashRadius
    {
        get { return splashRadius; }
    }

    public float SlowFactor
    {
        get { return slowFactor; }
    }

    public float SlowSeconds
    {
        get { return slowSeconds; }
    }
}
```

Replace `Enemy` with this version:

```csharp
using System.Collections;
using UnityEngine;

// A skeleton on the road, run as a state machine. The code decides what it
// does; its Animator, the Skeleton controller, only shows the body: rising
// from the ground, walking, chopping at the gate, falling. Every kind of
// skeleton is this one script, with its own numbers in the Inspector.
[RequireComponent(typeof(Animator))]
public class Enemy : MonoBehaviour
{
    public enum State { Rising, Walking, Slowed, Dying, AtGate }

    static readonly int WalkSpeedHash = Animator.StringToHash("WalkSpeed");
    static readonly int DieHash = Animator.StringToHash("Die");
    static readonly int AttackHash = Animator.StringToHash("Attack");

    [SerializeField] int maxHealth = 6;
    [SerializeField] float speed = 1.5f;            // units a second, on the road
    [SerializeField] int bounty = 5;                // gold, for the tower that finishes it
    [SerializeField] int livesCost = 1;             // what it costs the gate
    [SerializeField] float turnSpeed = 540f;        // degrees a second
    [SerializeField] GameObject frost;              // the frost that shows while it's slowed
    [SerializeField] Color frostTint = new Color(0.62f, 0.85f, 1f);

    GateGame game;
    WaypointPath path;
    Animator animator;
    Collider bodyCollider;
    Renderer[] bodyRenderers;
    State state;
    int health;
    int nextPoint;
    float distanceTravelled;
    float slowFactor = 1f;
    float slowUntil;
    bool killedByTower;
    Color tint = Color.white;
    Coroutine flash;

    // How far along the road it has walked: the towers aim at the biggest.
    public float DistanceTravelled
    {
        get { return distanceTravelled; }
    }

    // Towers only shoot at a skeleton that's up and walking.
    public bool IsTargetable
    {
        get { return state == State.Walking || state == State.Slowed; }
    }

    void Awake()
    {
        animator = GetComponent<Animator>();
        bodyCollider = GetComponent<Collider>();
        bodyRenderers = GetComponentsInChildren<SkinnedMeshRenderer>();
    }

    // The spawner calls this as soon as it makes the skeleton: a prefab can't
    // point at things in the scene, so it's handed them here.
    public void Begin(GateGame owner, WaypointPath road)
    {
        game = owner;
        path = road;
        health = maxHealth;
        nextPoint = 1;
        distanceTravelled = 0f;
        transform.position = path.GetPoint(0);
        transform.rotation = Quaternion.LookRotation(path.GetPoint(1) - path.GetPoint(0));
        EnterState(State.Rising);
    }

    void Update()
    {
        // Before Begin, and while the game isn't being played, it waits.
        if (game == null || !game.IsPlaying)
        {
            return;
        }

        switch (state)
        {
            case State.Rising:
                break;                  // waits for the OnRisen Animation Event
            case State.Walking:
                Walk(1f);
                break;
            case State.Slowed:
                Walk(slowFactor);
                if (Time.time >= slowUntil)
                {
                    EnterState(State.Walking);
                }
                break;
            case State.Dying:
                break;                  // waits for OnDeathFinished
            case State.AtGate:
                break;                  // waits for OnGateHit
        }
    }

    // The one place the state changes. The enter step runs once, as the
    // skeleton arrives in its new state.
    void EnterState(State next)
    {
        state = next;

        switch (state)
        {
            case State.Rising:
                bodyCollider.enabled = false;           // the towers can't see it yet
                break;
            case State.Walking:
                bodyCollider.enabled = true;
                slowFactor = 1f;
                animator.SetFloat(WalkSpeedHash, 1f);
                frost.SetActive(false);
                SetTint(Color.white);
                break;
            case State.Slowed:
                animator.SetFloat(WalkSpeedHash, slowFactor);   // the Walk clip plays slower too
                frost.SetActive(true);
                SetTint(frostTint);
                break;
            case State.Dying:
                bodyCollider.enabled = false;
                frost.SetActive(false);
                animator.SetTrigger(DieHash);
                break;
            case State.AtGate:
                bodyCollider.enabled = false;
                animator.SetTrigger(AttackHash);
                break;
        }
    }

    // Walks towards the next point on the road, turning to face it. factor is
    // 1 at full speed, 0.5 when slowed.
    void Walk(float factor)
    {
        Vector3 target = path.GetPoint(nextPoint);
        Vector3 before = transform.position;
        transform.position = Vector3.MoveTowards(before, target, speed * factor * Time.deltaTime);
        distanceTravelled += Vector3.Distance(before, transform.position);

        Vector3 toTarget = target - transform.position;
        if (toTarget.sqrMagnitude > 0.0001f)
        {
            Quaternion facing = Quaternion.LookRotation(toTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, facing, turnSpeed * Time.deltaTime);
        }

        if (transform.position == target)
        {
            nextPoint++;
            if (nextPoint >= path.Count)
            {
                EnterState(State.AtGate);
            }
        }
    }

    // A tower's shot hit it.
    public void TakeDamage(int damage)
    {
        if (!IsTargetable)
        {
            return;
        }
        health -= damage;
        if (flash != null)
        {
            StopCoroutine(flash);
        }
        flash = StartCoroutine(FlashRed());
        if (health <= 0)
        {
            killedByTower = true;
            EnterState(State.Dying);
        }
    }

    // A frost bolt hit it: slower for a while. Two bolts keep the slower
    // speed and the later end.
    public void Slow(float factor, float seconds)
    {
        if (!IsTargetable)
        {
            return;
        }
        slowFactor = state == State.Slowed ? Mathf.Min(slowFactor, factor) : factor;
        slowUntil = Mathf.Max(slowUntil, Time.time + seconds);
        EnterState(State.Slowed);
    }

    // Animation Event: the end of the Rise clip, once it's out of the ground.
    public void OnRisen()
    {
        if (state == State.Rising)
        {
            EnterState(State.Walking);
        }
    }

    // Animation Event: the chop's frame, as the blade hits the gate.
    public void OnGateHit()
    {
        if (state != State.AtGate)
        {
            return;
        }
        game.Gate.TakeHit(livesCost);
        killedByTower = false;          // no bounty for this one
        EnterState(State.Dying);
    }

    // Animation Event: the end of the Die clip.
    public void OnDeathFinished()
    {
        if (killedByTower)
        {
            game.Bank.Earn(bounty);
        }
        Destroy(gameObject);
    }

    // An Animator has one layer at Level 3, so a hit can't play a clip without
    // stopping the walk. The hit shows as a red flash instead, for a moment.
    IEnumerator FlashRed()
    {
        SetColour(Color.red);
        yield return new WaitForSeconds(0.08f);
        SetColour(tint);
        flash = null;
    }

    void SetTint(Color colour)
    {
        tint = colour;
        SetColour(colour);
    }

    void SetColour(Color colour)
    {
        foreach (Renderer part in bodyRenderers)
        {
            part.material.color = colour;
        }
    }
}
```

Replace `Projectile` with its last version:

```csharp:Projectile.cs
using UnityEngine;

// A tower's shot. Arrows and frost bolts fly straight at their target and
// follow it; a catapult's stone flies in an arc to where the target was when
// it was thrown, and hits everything where it lands. One script, a switch on
// its kind.
public class Projectile : MonoBehaviour
{
    public enum ProjectileKind { Arrow, Stone, Frost }

    [SerializeField] ProjectileKind kind;
    [SerializeField] float speed = 12f;             // arrows and frost bolts, units a second
    [SerializeField] float flightSeconds = 0.9f;    // a stone's time in the air
    [SerializeField] float arcHeight = 3f;          // how high a stone rises, halfway
    [SerializeField] float aimHeight = 0.45f;       // a skeleton's chest, above its feet
    [SerializeField] GameObject burstPrefab;        // dust or frost, where it lands
    [SerializeField] AudioClip landSound;

    Enemy target;
    TowerLevel stats;
    LayerMask enemyMask;
    Vector3 start;
    Vector3 end;
    float launchTime;

    public void Launch(Enemy aim, TowerLevel level, LayerMask mask)
    {
        target = aim;
        stats = level;
        enemyMask = mask;
        start = transform.position;
        end = kind == ProjectileKind.Stone ? target.transform.position : AimPoint();
        launchTime = Time.time;
    }

    void Update()
    {
        switch (kind)
        {
            case ProjectileKind.Arrow:
            case ProjectileKind.Frost:
                // Follow the target while it's still walking; otherwise fly
                // on to the last place it was.
                if (target != null && target.IsTargetable)
                {
                    end = AimPoint();
                }
                Vector3 before = transform.position;
                transform.position = Vector3.MoveTowards(before, end, speed * Time.deltaTime);
                if (transform.position != before)
                {
                    transform.rotation = Quaternion.LookRotation(transform.position - before);
                }
                if (transform.position == end)
                {
                    Arrive();
                }
                break;
            case ProjectileKind.Stone:
                // t runs from 0 to 1 over the flight. Along the ground it moves
                // in a straight line; up and down it follows 4t(1 − t): 0 at
                // both ends, 1 halfway.
                float t = (Time.time - launchTime) / flightSeconds;
                Vector3 ground = Vector3.Lerp(start, end, t);
                transform.position = ground + Vector3.up * arcHeight * 4f * t * (1f - t);
                if (t >= 1f)
                {
                    Arrive();
                }
                break;
        }
    }

    void Arrive()
    {
        switch (kind)
        {
            case ProjectileKind.Arrow:
                if (target != null)
                {
                    target.TakeDamage(stats.Damage);
                }
                break;
            case ProjectileKind.Stone:
                HitAround(transform.position, stats.SplashRadius, false);
                break;
            case ProjectileKind.Frost:
                if (stats.SplashRadius > 0f)
                {
                    HitAround(transform.position, stats.SplashRadius, true);
                }
                else if (target != null)
                {
                    target.TakeDamage(stats.Damage);
                    target.Slow(stats.SlowFactor, stats.SlowSeconds);
                }
                break;
        }

        if (burstPrefab != null)
        {
            Instantiate(burstPrefab, transform.position, Quaternion.identity);
        }
        if (landSound != null)
        {
            // A sound played at a point is a 3D sound: the further it is from
            // the Audio Listener, on the camera, the quieter. Played at the
            // camera, it's heard at full volume.
            AudioSource.PlayClipAtPoint(landSound, Camera.main.transform.position);
        }
        Destroy(gameObject);
    }

    // Everything on the Enemy layer within radius of the centre is hit.
    void HitAround(Vector3 centre, float radius, bool slows)
    {
        foreach (Collider found in Physics.OverlapSphere(centre, radius, enemyMask))
        {
            if (found.TryGetComponent(out Enemy enemy))
            {
                enemy.TakeDamage(stats.Damage);
                if (slows)
                {
                    enemy.Slow(stats.SlowFactor, stats.SlowSeconds);
                }
            }
        }
    }

    Vector3 AimPoint()
    {
        return target.transform.position + Vector3.up * aimHeight;
    }
}
```

Read it before you move on:

- `Launch` works out `end`: for a stone, where the target stands now; for the others, its
  chest. A stone doesn't follow.
- `case ProjectileKind.Arrow:` and `case ProjectileKind.Frost:` share their code: two
  `case` lines over one block.
- `Arrive` does each kind's hit. A frost bolt with a splash radius hits and slows
  everything round it; Chapter 10's Level 3 Frost tower has one.
- `burstPrefab` and `landSound` may be empty: an arrow has neither, so the code checks.
  The stone's sound comes in Chapter 14.

### Do it — the particles

Make three Particle Systems, each on a new empty GameObject, **Add Component → Effects →
Particle System**, with these settings. Leave everything else as it is. Each **Renderer**
module's **Material** is `Particle`, and each **Color over Lifetime** is ticked, with its
gradient's alpha full at the start, still full at 60%, and clear at the end: the
particles fade out.

| Setting | `Dust` | `Frost Burst` | `Frost` |
| --- | --- | --- | --- |
| **Duration**, **Looping** | 0.5, off | 0.5, off | 5, on |
| **Start Lifetime** | 0.4 to 0.8 | 0.4 to 0.8 | 0.8 |
| **Start Speed** | 0.7 to 1.4 | 0.8 to 1.6 | 0.4 |
| **Start Size** | 0.12 to 0.28 | 0.12 to 0.28 | 0.08 to 0.16 |
| **Start Color** | between `#B99A74` and `#8C7A66` | between `#DFF3FF` and `#7CC8FF` | between `#DFF3FF` and `#7CC8FF` |
| **Gravity Modifier** | 0.5 | 0 | 0 |
| **Simulation Space** | Local | Local | **World** |
| **Scaling Mode** | Local | Local | **Shape** |
| **Stop Action** | **Destroy** | **Destroy** | None |
| **Emission** | **Rate over Time** 0; **Bursts** + : **Time** 0, **Count** 24 | **Rate over Time** 0; a burst of 18 | **Rate over Time** 18 |
| **Shape** | **Hemisphere**, **Radius** 0.3, **Rotation** (−90, 0, 0) | the same | **Sphere**, **Radius** 0.9 |

A range such as *0.4 to 0.8* is **Random Between Two Constants**: the small arrow at the
right of the field chooses it. The hemisphere is a dome, turned to face up: the dust
flies up and out, and falls back.

1. Make `Dust` and `Frost Burst`, and drag each into `Assets/Prefabs`. Delete them from
   the scene.
2. Make `Frost` as a child of each skeleton prefab, at `(0, 1.1, 0)`, round its chest,
   and switch it off. Drag it into the skeleton's `Enemy`'s **Frost** field. (Make it in
   the Minion, then copy it: select it, **Ctrl + C**, open the next prefab, select its
   root, **Ctrl + V**.)

### Do it — the stone and the frost bolt

1. **The stone:** an empty GameObject, `Stone`, with `projectile_catapult` as its child
   `Model`, at **Scale** `1.3`. A **Trail Renderer** as the arrow's, but **Width** `0.12`
   and a dusty grey, `#8C8073`, fading out. Add `Projectile`: **Kind** **Stone**, **Burst
   Prefab** `Dust`.
2. **The frost bolt:** an empty GameObject, `Frost Bolt`. Right-click it → **3D Object →
   Sphere**, name it `Model`, **Scale** `0.22`, and remove its **Sphere Collider**: a bolt
   is only a picture. Make a material, `Frost Bolt`, with the shader **Universal Render
   Pipeline → Unlit** and **Base Color** `#BFE6FF`, and drag it onto the sphere. A **Trail
   Renderer** with **Width** `0.12`, a pale blue, `#9ED9FF`, fading out. Add
   `Projectile`: **Kind** **Frost**, **Speed** `9`, **Burst Prefab** `Frost Burst`.
3. Drag both into `Assets/Prefabs`, and delete them from the scene. The `Arrow` prefab's
   **Kind** is already **Arrow**: the first in the enum, and the default.

### Do it — the Frost tower

1. Set up the mage's clips, with **Bake Into Pose** and **Original** on all three Root
   Transform rows:

| File | Clip | Loop Time | Event |
| --- | --- | --- | --- |
| `Rig_Medium_General` | `Idle_A` | on | |
| `Rig_Medium_CombatRanged` | `Ranged_Magic_Spellcasting` | on | |
| `Rig_Medium_CombatRanged` | `Ranged_Magic_Shoot` | off | `OnRelease` at 40% |

2. Make an Override Controller, `Mage Override`, on `Crew`: `Idle_A` in place of
   `Ranged_Bow_Idle`, `Ranged_Magic_Spellcasting` for `Ranged_Bow_Aiming_Idle`, and
   `Ranged_Magic_Shoot` for `Ranged_Bow_Release`.
3. Build the tower as you built the Arrow tower: an empty `Frost Tower`; `Base`, from
   `building_tower_base_blue`; `Top` at `(0, 1.38, 0)`; on it the `Mage`, **Scale**
   `0.36`, **Apply Root Motion** off, `Mage Override` as its **Controller**, `staff` on
   its `handslot.r`, and `TowerCrew`; and `Muzzle` at `(0, 0.45, 0)`.
4. Add `Tower`: **Title** `Frost Tower`; **Stats**: **Cost** `60`, **Range** `3.5`,
   **Damage** `1`, **Reload Seconds** `1.2`, **Splash Radius** `0`, **Slow Factor**
   `0.5`, **Slow Seconds** `2`. **Crew** and **Turret** the `Mage`; **Shot Prefab** `Frost
   Bolt`; **Enemy Mask** **Enemy**. Drag `Frost Tower` into **Tower** on the mage's
   `TowerCrew`.
5. Drag `Frost Tower` into `Assets/Prefabs`, and delete it from the scene.

### Do it — the Catapult tower

1. Make an empty GameObject, `Catapult Tower`, at `(0, 0, 0)`, and a child `Top` at `(0,
   1.38, 0)`. Drag `building_tower_catapult_red` onto `Top`, rename it `Catapult`, and set
   its **Position** to `(0, -1.38, 0)`: the model is a whole tower, base and all, so it
   stands on the ground, and its turret is at the same height as the archer.
2. Add `TowerCrew` to `Catapult`, and drag `Catapult Tower` into its **Tower**.
3. Select `Catapult`. In the Animation window, click **Create**, and save
   `Assets/Animation/Arm Rest.anim`; Unity makes a controller, `Catapult`. Set
   **Samples** to `30`, and make the three clips in the table in *A catapult in three
   clips*: **Add Property → catapult_turret_red → catapult_arm_red → Transform →
   Rotation**, and set the keys on **Rotation.x**. For `Arm Throw`, move the playhead to
   `0:04`, click **Add Event**, and choose `OnRelease` in the event's **Function**.
4. Make `Catapult Override` on `Crew`: `Arm Rest`, `Arm Wound` and `Arm Throw` in place
   of the bow's three clips. Drag it into `Catapult`'s Animator's **Controller**, and
   delete the `Catapult` controller Unity made.
5. Right-click `Top` → **Create Empty**: `Muzzle`, at `(0, 0.5, 0)`, by the spoon.
6. Add `Tower` to `Catapult Tower`: **Title** `Catapult Tower`; **Stats**: **Cost**
   `80`, **Range** `5`, **Damage** `4`, **Reload Seconds** `2.6`, **Splash Radius**
   `1.2`, **Slow Factor** `1`, **Slow Seconds** `0`. **Crew**: `Catapult`. **Turret**:
   `catapult_turret_red`, under `Catapult`: only the turret turns, with the arm on it.
   **Shot Prefab** `Stone`; **Enemy Mask** **Enemy**.
7. Drag `Catapult Tower` into `Assets/Prefabs`, and delete it from the scene.

### Do it — three towers to build

1. Open the build menu: select `Build Menu`, and switch it on for now.
2. Select `Bow Button`, `Bow Coin` and `Bow Price`, and duplicate them twice (**Ctrl + D**).
   Rename the copies `Catapult Button`, `Catapult Coin`, `Catapult Price`, and `Frost
   Button`, `Frost Coin`, `Frost Price`, and move each set along: the Catapult's `x` is
   130 more than the Bow's, and the Frost tower's 260 more (the button at `0` and `130`,
   the coin at `-30` and `100`, the price at `18` and `148`).
3. The `Icon` in `Catapult Button` shows `Catapult`; the one in `Frost Button` shows
   `Frost`.
4. Switch `Build Menu` off again, and replace `BuildMenu` with its last version:

```csharp:BuildMenu.cs
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The build menu: three buttons, one per tower, over the plot that was
// tapped. Camera.WorldToScreenPoint turns the plot's place in the world into
// a place on the screen. A tower the player can't afford has its button's
// interactable switched off, so it shows its Disabled picture.
public class BuildMenu : MonoBehaviour
{
    [SerializeField] Bank bank;
    [SerializeField] Tower[] towerPrefabs;      // Arrow, Catapult, Frost
    [SerializeField] Button[] buttons;          // in the same order
    [SerializeField] TMP_Text[] priceTexts;
    [SerializeField] float heightAbovePlot = 1.5f;

    BuildPlot plot;
    Camera cam;

    public bool IsOpen
    {
        get { return gameObject.activeSelf; }
    }

    void Awake()
    {
        cam = Camera.main;
    }

    // Each button needs its own method to call: buttons[0] builds an Arrow
    // tower, buttons[1] a Catapult, buttons[2] a Frost tower.
    void OnEnable()
    {
        buttons[0].onClick.AddListener(BuildArrow);
        buttons[1].onClick.AddListener(BuildCatapult);
        buttons[2].onClick.AddListener(BuildFrost);
    }

    void OnDisable()
    {
        buttons[0].onClick.RemoveListener(BuildArrow);
        buttons[1].onClick.RemoveListener(BuildCatapult);
        buttons[2].onClick.RemoveListener(BuildFrost);
    }

    // While it's open, it stays over its plot, and the buttons keep up with
    // the gold: a bounty can make a tower affordable.
    void Update()
    {
        if (plot == null)
        {
            return;
        }
        PlaceOver(plot.transform.position);
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = bank.CanAfford(towerPrefabs[i].BuildCost);
        }
    }

    public void Open(BuildPlot target)
    {
        plot = target;
        gameObject.SetActive(true);
        for (int i = 0; i < priceTexts.Length; i++)
        {
            priceTexts[i].text = towerPrefabs[i].BuildCost.ToString();
        }
        Update();
    }

    public void Close()
    {
        plot = null;
        gameObject.SetActive(false);
    }

    void BuildArrow()
    {
        Build(0);
    }

    void BuildCatapult()
    {
        Build(1);
    }

    void BuildFrost()
    {
        Build(2);
    }

    void Build(int index)
    {
        if (plot != null && bank.Spend(towerPrefabs[index].BuildCost))
        {
            plot.Build(towerPrefabs[index]);
        }
        Close();
    }

    // The menu's pivot is the middle of its bottom edge: that point goes over
    // the plot, then the menu is kept inside the screen.
    void PlaceOver(Vector3 worldPoint)
    {
        Vector3 screenPoint = cam.WorldToScreenPoint(worldPoint + Vector3.up * heightAbovePlot);
        RectTransform rect = (RectTransform)transform;
        Vector2 size = rect.rect.size * rect.lossyScale;
        screenPoint.x = Mathf.Clamp(screenPoint.x, size.x / 2f, Screen.width - size.x / 2f);
        screenPoint.y = Mathf.Clamp(screenPoint.y, 0f, Screen.height - size.y);
        rect.position = screenPoint;
    }
}
```

5. Set its three arrays to three elements each, in the same order: **Tower Prefabs**
   `Arrow Tower`, `Catapult Tower`, `Frost Tower`; **Buttons** `Bow Button`, `Catapult
   Button`, `Frost Button`; **Price Texts** `Bow Price`, `Catapult Price`, `Frost Price`.

The three arrays line up: element 1 of each is the Catapult. That's the only link
between a button and its tower, so the order matters.

### Test it

Press **Play**. Set the bank's **Start Gold** to `1000` while you test, and put it back
to `120` at the end.

- The build menu offers three towers: `50`, `80`, `60`.
- Build a Catapult beside a stretch of road where skeletons bunch up. Its turret turns
  to face the road, its arm winds back, and whips over: a stone flies in a high arc
  with a grey trail, and lands in a puff of dust. Every skeleton near where it lands
  flashes red.
- Build a Frost tower. The mage raises the staff, and throws a pale blue bolt. The
  skeleton it hits turns icy blue, frost sparkles round it, and it walks at half speed,
  its legs in slow motion. Two seconds later it warms up, and hurries on.
- A Rogue that's slowed is still a fast skeleton; a Warrior that's slowed is very slow
  indeed. Which tower helps the other most?

### Challenge

Give the Frost tower a splash: **Splash Radius** `1`. Now one bolt slows a whole crowd.
Is that too strong for 60 gold? Chapter 10 makes it the Frost tower's Level 3, for 190
gold in all. Put it back to `0`.

## Chapter 10 — Three Levels

**Goal:** every tower can be upgraded twice. Tap a tower, and its menu shows its name,
its level as stars, **Upgrade** with the price (or *Max*), and **Sell** with what you'd
get back; its range shows as a ring on the ground. An upgraded tower pops, grows a
storey, lifts its crew, and at Level 3 raises two flags: a second Animator on the tower,
driven by an Int.

### Idea — three levels, in an array

Each tower keeps three `TowerLevel`s in an array, one per level, and `Current` is the
one it's at: `levels[level - 1]`, because arrays count from 0 and levels from 1. A
level's **Cost** is what it costs to reach it: to build, for Level 1.

| Tower | Level 1 | Level 2 | Level 3 |
| --- | --- | --- | --- |
| **Arrow** | 50 · range 4 · 1 damage · every 1 s | +40 · 4.5 · 2 · 0.85 s | +70 · 5 · 3 · 0.7 s |
| **Catapult** | 80 · range 5 · 4 damage, splash 1.2 · every 2.6 s | +60 · 5.5 · 6, splash 1.4 · 2.4 s | +100 · 6 · 9, splash 1.6 · 2.2 s |
| **Frost** | 60 · range 3.5 · 1 damage, half speed for 2 s · every 1.2 s | +50 · 4 · 1, 2.5 s | +80 · 4.5 · 2, 3 s, splash 1 |

Selling gives back 60% of everything spent on the tower: an Arrow tower at Level 3 cost
`50 + 40 + 70 = 160`, and sells for `96`. `Mathf.RoundToInt(spent * 0.6f)` makes a
whole number of gold.

### Idea — a tower's looks, switched by an Int

The tower gets an Animator of its own, on its root, beside the crew's, with one
controller for all three kinds, `Tower`:

| Parameter | Type | Set by `Tower` |
| --- | --- | --- |
| `Level` | Int, default `1` | when it's built, and each time it's upgraded |

```
   Any State ── Level Equals 1 ──► Level 1   (the default)
   Any State ── Level Equals 2 ──► Level 2
   Any State ── Level Equals 3 ──► Level 3        Can Transition To Self: off
```

An **Int** fits: a level is one of a few numbered states, and the code says which. With
**Can Transition To Self** on, `Level Equals 2` would be true again every frame, and the
Level 2 clip would restart every frame, frozen on its first.

Every tower has the same three children, so the same three clips work on all of them:

| Child | Level 1 | Level 2 | Level 3 |
| --- | --- | --- | --- |
| `Upper`: a second storey, 1.2 tall | off | **on** | on |
| `Top`: the crew, the muzzle and the flags | **Position Y** `1.38` | `2.58`: up a storey | `2.58` |
| `Top/Flags`: two flags | off | off | **on** |

And each clip starts with a **pop**: the whole tower's **Scale** goes `0.9` → `1.1` → `1`
in a quarter of a second. Then it holds its last frame.

### Idea — Is Active keys

The Animation window can switch a child on and off: **Add Property → Upper → Is Active**
adds a curve that's either on (1) or off (0). It's a property clip like any other, and
it's how a level's clip shows a storey or the flags. In the Inspector, the child's box
beside its name ticks and unticks as the clip plays.

### Idea — a circle in code

`RangeRing` draws a tower's range on the ground with a **Line Renderer**, through 64
points round a circle. Point `i` is at the angle `i × 2π ÷ 64`, and a point at angle `a`
on a circle of radius `r` is at:

```
   x = cos(a) × r        z = sin(a) × r
```

`Mathf.Cos` and `Mathf.Sin` work in **radians**: a whole turn is `2 × Mathf.PI`, not
360. The line's **loop** joins the last point back to the first.

### Do it — every tower gets a second storey and flags

Open each tower prefab, and add:

1. **`Upper`**: drag the tower's base model onto the root again
   (`building_tower_base_green` for the Arrow tower, `_red` for the Catapult, `_blue` for
   the Frost tower), and rename it `Upper`: **Position** `(0, 1.2, 0)`, **Scale** `(1,
   0.8, 1)`, switched off. The Catapult tower's goes **under** the catapult instead, at
   `(0, 0, 0)`: when `Top` rises, the whole catapult stands on it.
2. **`Flags`**: an empty child of `Top`, at `(0, 0, 0)`, switched off, holding two flags
   in the tower's colour (`flag_green`, `flag_red` or `flag_blue`):

| Flag | Position | Rotation | Scale |
| --- | --- | --- | --- |
| `Flag Left` | (−0.38, −0.05, 0.1) | (0, 90, 0) | 2.6 |
| `Flag Right` | (0.38, −0.05, 0.1) | (0, 90, 0) | 2.6 |

On the Catapult tower, both flags' **Position Y** is `0.12`.

### Do it — the Tower controller

1. Drag the `Arrow Tower` prefab into the scene, to make the clips on. Select its root,
   and in the Animation window click **Create**: save `Assets/Animation/Tower Level
   1.anim`. Unity makes a controller named `Arrow Tower`: rename it `Tower`.
2. Set **Samples** to `30`. Make the three clips, `Tower Level 1`, `Tower Level 2` and
   `Tower Level 3`, with **Loop Time** off, and these curves (**Add Property** for each):

| Property | Keys, in every clip | Level 1 | Level 2 | Level 3 |
| --- | --- | --- | --- | --- |
| `Arrow Tower`: **Scale** (x, y and z) | `0.9` at `0:00`, `1.1` at `0:04`, `1` at `0:08` | ✓ | ✓ | ✓ |
| `Upper`: **Is Active** | at `0:00` and `0:08` | off | on | on |
| `Top`: **Position.y** | at `0:00` and `0:08` | `1.38` | `2.58` | `2.58` |
| `Top/Flags`: **Is Active** | at `0:00` and `0:08` | off | off | on |

3. Open `Tower` in the Animator. Rename the states `Level 1`, `Level 2` and `Level 3`;
   `Level 1` is the default. Add an **Int**, `Level`, with default `1`. Make an **Any
   State** transition to each, with **Transition Duration** `0`, **Can Transition To
   Self** off, and the condition `Level` **Equals** its number.
4. Click **Overrides → Apply All** at the top of the Inspector, to save the new Animator
   into the `Arrow Tower` prefab, and delete the copy from the scene.
5. Open `Catapult Tower` and `Frost Tower`, and give each root an **Animator** with the
   `Tower` controller.

### Do it — Tower, with levels

Replace `Tower` with this version:

```csharp
using UnityEngine;

// A tower on a plot, run as a state machine: Idle with nothing in range, Aim
// at the skeleton furthest along the road, Fire, then Reload. It has two
// Animators: its crew's (the archer, the mage or the catapult), driven with
// Aiming and Fire, and its own, whose Level switches the tower's looks. One
// script serves all three kinds: what differs is in the Inspector, and in
// the shot each one fires.
public class Tower : MonoBehaviour
{
    public enum State { Idle, Aim, Fire, Reload }

    static readonly int AimingHash = Animator.StringToHash("Aiming");
    static readonly int FireHash = Animator.StringToHash("Fire");
    static readonly int LevelHash = Animator.StringToHash("Level");

    [SerializeField] string title = "Arrow Tower";
    [SerializeField] TowerLevel[] levels;       // Levels 1, 2 and 3
    [SerializeField] Animator crew;
    [SerializeField] Transform turret;          // what turns to face the target
    [SerializeField] Transform muzzle;          // where its shots start
    [SerializeField] Projectile shotPrefab;
    [SerializeField] LayerMask enemyMask;
    [SerializeField] float turnSpeed = 360f;    // degrees a second

    GateGame game;
    Transform shotGroup;
    Animator body;
    State state;
    int level;
    int spent;
    Enemy target;
    float stateStartTime;

    public string Title
    {
        get { return title; }
    }

    public int Level
    {
        get { return level; }
    }

    public TowerLevel Current
    {
        get { return levels[level - 1]; }
    }

    public int BuildCost
    {
        get { return levels[0].Cost; }
    }

    public bool CanUpgrade
    {
        get { return level < levels.Length; }
    }

    public int UpgradeCost
    {
        get { return CanUpgrade ? levels[level].Cost : 0; }
    }

    // Selling gives back 60% of everything spent on the tower.
    public int SellValue
    {
        get { return Mathf.RoundToInt(spent * 0.6f); }
    }

    void Awake()
    {
        body = GetComponent<Animator>();
    }

    // The plot calls this as soon as it makes the tower.
    public void Build(GateGame owner, Transform shots)
    {
        game = owner;
        shotGroup = shots;
        level = 1;
        spent = levels[0].Cost;
        body.SetInteger(LevelHash, level);
        EnterState(State.Idle);
    }

    public void Upgrade()
    {
        if (!CanUpgrade)
        {
            return;
        }
        level++;
        spent += levels[level - 1].Cost;
        body.SetInteger(LevelHash, level);      // the Level clip adds a storey, or the flags
    }

    void Update()
    {
        if (game == null || !game.IsPlaying)
        {
            return;
        }

        switch (state)
        {
            case State.Idle:
                target = FindTarget();
                if (target != null)
                {
                    EnterState(State.Aim);
                }
                break;
            case State.Aim:
                if (!InRange(target))
                {
                    target = FindTarget();
                }
                if (target == null)
                {
                    EnterState(State.Idle);
                }
                else if (TurnTowards(target))
                {
                    EnterState(State.Fire);
                }
                break;
            case State.Fire:
                if (InRange(target))
                {
                    TurnTowards(target);
                }
                // The shot leaves on the crew's OnRelease event. If it never
                // comes (the crew was interrupted), aim again.
                if (Time.time - stateStartTime > 2f)
                {
                    EnterState(State.Aim);
                }
                break;
            case State.Reload:
                if (Time.time - stateStartTime >= Current.ReloadSeconds)
                {
                    EnterState(State.Aim);
                }
                break;
        }
    }

    void EnterState(State next)
    {
        state = next;
        stateStartTime = Time.time;

        switch (state)
        {
            case State.Idle:
                target = null;
                crew.SetBool(AimingHash, false);
                break;
            case State.Aim:
                crew.SetBool(AimingHash, true);
                break;
            case State.Fire:
                crew.SetTrigger(FireHash);
                break;
            case State.Reload:
                break;
        }
    }

    // TowerCrew calls this on the crew's OnRelease Animation Event: the
    // frame the arrow leaves the bow, the bolt the staff, the stone the arm.
    public void Release()
    {
        if (state != State.Fire)
        {
            return;
        }
        if (InRange(target))
        {
            Projectile shot = Instantiate(shotPrefab, muzzle.position, Quaternion.identity, shotGroup);
            shot.Launch(target, Current, enemyMask);
        }
        EnterState(State.Reload);
    }

    // The skeleton furthest along the road, within range: the one closest to
    // the gate. Physics.OverlapSphere finds every collider on the Enemy layer
    // inside the circle; the loop keeps the best.
    Enemy FindTarget()
    {
        Enemy best = null;
        foreach (Collider found in Physics.OverlapSphere(transform.position, Current.Range, enemyMask))
        {
            if (found.TryGetComponent(out Enemy enemy) && enemy.IsTargetable &&
                (best == null || enemy.DistanceTravelled > best.DistanceTravelled))
            {
                best = enemy;
            }
        }
        return best;
    }

    bool InRange(Enemy enemy)
    {
        if (enemy == null || !enemy.IsTargetable)
        {
            return false;
        }
        Vector3 offset = enemy.transform.position - transform.position;
        offset.y = 0f;
        return offset.magnitude <= Current.Range;
    }

    // Turns the turret a little towards the enemy, on the ground only, and
    // answers true once it's facing it.
    bool TurnTowards(Enemy enemy)
    {
        Vector3 toEnemy = enemy.transform.position - turret.position;
        toEnemy.y = 0f;
        Quaternion facing = Quaternion.LookRotation(toEnemy);
        turret.rotation = Quaternion.RotateTowards(turret.rotation, facing, turnSpeed * Time.deltaTime);
        return Quaternion.Angle(turret.rotation, facing) < 5f;
    }
}
```

Then open each tower prefab, and fill in its `Tower`'s **Levels** with three elements,
from the table in *Three levels, in an array*. The Splash Radius, Slow Factor and Slow
Seconds of each level are as in Chapter 9: `0`, `1` and `0` for the Arrow tower; the
splash, `1` and `0` for the Catapult; and for the Frost tower `0`, `0.5` and the
seconds, but **Splash Radius** `1` at Level 3.

What's new:

- `level` is the tower's level, 1 to 3, and `spent` everything paid for it, so far.
- `Build` and `Upgrade` tell the tower's own Animator: `body.SetInteger(LevelHash,
  level)`. The `Level` clips do the rest.
- `CanUpgrade` asks *is there a next level?* `UpgradeCost` is its cost, and `levels[level]`
  is the next one, because the current one is `levels[level - 1]`.
- The tower menu will read `Title`, `Level`, `Current`, `CanUpgrade`, `UpgradeCost` and
  `SellValue`. All six are read-only properties: only the tower changes its own numbers.

### Do it — the range ring

1. Make an empty GameObject, `Range Ring`, at `(0, 0, 0)`. **Add Component → Line
   Renderer**: tick **Use World Space**, set the **Width** to `0.08`, drag `Particle` into
   its **Materials**, set **Color** to white at 85% alpha, and **Cast Shadows** to **Off**.
2. Create `Assets/Scripts/RangeRing.cs`, and add it to `Range Ring`:

```csharp:RangeRing.cs
using UnityEngine;

// Draws a circle on the ground with a Line Renderer: a tower's range, while
// its menu is open. The points go round the circle with Cos and Sin.
[RequireComponent(typeof(LineRenderer))]
public class RangeRing : MonoBehaviour
{
    [SerializeField] int points = 64;
    [SerializeField] float height = 0.05f;      // just above the ground, so it isn't hidden in it

    LineRenderer line;

    void Awake()
    {
        line = GetComponent<LineRenderer>();
        line.loop = true;
        line.positionCount = points;
        Hide();
    }

    public void Show(Vector3 centre, float radius)
    {
        for (int i = 0; i < points; i++)
        {
            float angle = i * 2f * Mathf.PI / points;
            Vector3 offset = new Vector3(Mathf.Cos(angle) * radius, height, Mathf.Sin(angle) * radius);
            line.SetPosition(i, centre + offset);
        }
        line.enabled = true;
    }

    public void Hide()
    {
        line.enabled = false;
    }
}
```

### Do it — the tower menu

| Object | Type | Parent | Anchor | Pos | Size |
| --- | --- | --- | --- | --- | --- |
| `Tower Menu` | Image | Canvas | bottom-left | (0, 0) | 470 × 322 |
| `Title` | Text - TextMeshPro | Tower Menu | middle-center | (0, 100) | 400 × 56 |
| `Star 1`, `Star 2`, `Star 3` | Image | Tower Menu | middle-center | (−52, 52), (0, 52), (52, 52) | 44 × 41 |
| `Upgrade Button` | Button - TextMeshPro | Tower Menu | middle-center | (−90, −30) | 104 × 104 |
| `Upgrade Price` | Text - TextMeshPro | Tower Menu | middle-center | (−90, −112) | 150 × 50 |
| `Sell Button` | Button - TextMeshPro | Tower Menu | middle-center | (90, −30) | 104 × 104 |
| `Icon` | Image | Sell Button | middle-center | (0, 4) | 60 × 60 |
| `Sell Value` | Text - TextMeshPro | Tower Menu | middle-center | (90, −112) | 170 × 50 |

1. `Tower Menu` shows `PanelPlain`, with its **Pivot** at `(0.5, 0)` and **Raycast
   Target** ticked, as the build menu.
2. `Title` says `Arrow Tower`, **Font Size** `40`; `Upgrade Price` says `40` and `Sell
   Value` `Sell 30`, **Font Size** `34`; all three centred, `#4A3420`. The stars show
   `Star`. Untick **Raycast Target** on everything but the menu and the two buttons.
3. Delete both buttons' `Text (TMP)` children. `Upgrade Button` shows `UpgradeButton`,
   with **Transition** **Sprite Swap** and only a **Disabled Sprite**, `UpgradeButtonLocked`.
   `Sell Button` is a square button like the build menu's, with the `Sell` icon.
4. Switch `Tower Menu` off.

Create `Assets/Scripts/TowerMenu.cs`, and add it to `Tower Menu`. Fill in its fields:
`Gate Game` into **Bank**, `Range Ring`, `Title`, the three stars, the two buttons and
their two texts.

```csharp
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The tower menu, over a tower that was tapped: its name, its level as
// stars, Upgrade and Sell. While it's open, the tower's range shows as a
// ring on the ground.
public class TowerMenu : MonoBehaviour
{
    [SerializeField] Bank bank;
    [SerializeField] RangeRing rangeRing;
    [SerializeField] TMP_Text titleText;
    [SerializeField] Image[] stars;             // three, one per level
    [SerializeField] Button upgradeButton;
    [SerializeField] TMP_Text upgradeText;
    [SerializeField] Button sellButton;
    [SerializeField] TMP_Text sellText;
    [SerializeField] float heightAbovePlot = 3.2f;

    BuildPlot plot;
    Camera cam;

    public bool IsOpen
    {
        get { return gameObject.activeSelf; }
    }

    void Awake()
    {
        cam = Camera.main;
    }

    void OnEnable()
    {
        upgradeButton.onClick.AddListener(Upgrade);
        sellButton.onClick.AddListener(Sell);
    }

    void OnDisable()
    {
        upgradeButton.onClick.RemoveListener(Upgrade);
        sellButton.onClick.RemoveListener(Sell);
    }

    void Update()
    {
        if (plot == null)
        {
            return;
        }
        PlaceOver(plot.transform.position);
        Tower tower = plot.Tower;
        upgradeButton.interactable = tower.CanUpgrade && bank.CanAfford(tower.UpgradeCost);
    }

    public void Open(BuildPlot target)
    {
        plot = target;
        gameObject.SetActive(true);
        Refresh();
        Update();
    }

    public void Close()
    {
        plot = null;
        rangeRing.Hide();
        gameObject.SetActive(false);
    }

    void Refresh()
    {
        Tower tower = plot.Tower;
        titleText.text = tower.Title;
        for (int i = 0; i < stars.Length; i++)
        {
            stars[i].enabled = i < tower.Level;
        }
        upgradeText.text = tower.CanUpgrade ? tower.UpgradeCost.ToString() : "Max";
        sellText.text = $"Sell {tower.SellValue}";
        rangeRing.Show(tower.transform.position, tower.Current.Range);
    }

    void Upgrade()
    {
        Tower tower = plot.Tower;
        if (tower.CanUpgrade && bank.Spend(tower.UpgradeCost))
        {
            tower.Upgrade();
            Refresh();
        }
    }

    void Sell()
    {
        bank.Earn(plot.Tower.SellValue);
        plot.Clear();
        Close();
    }

    void PlaceOver(Vector3 worldPoint)
    {
        Vector3 screenPoint = cam.WorldToScreenPoint(worldPoint + Vector3.up * heightAbovePlot);
        RectTransform rect = (RectTransform)transform;
        Vector2 size = rect.rect.size * rect.lossyScale;
        screenPoint.x = Mathf.Clamp(screenPoint.x, size.x / 2f, Screen.width - size.x / 2f);
        screenPoint.y = Mathf.Clamp(screenPoint.y, 0f, Screen.height - size.y);
        rect.position = screenPoint;
    }
}
```

`stars[i].enabled = i < tower.Level` switches each star's Image on or off: at Level 2,
stars 0 and 1 are on. `Refresh` runs when the menu opens and after an upgrade; `Update`
runs every frame, because the gold can change while you look.

### Do it — Picker, with the tower menu

Replace `Picker` with its last version, and drag `Tower Menu` into its new **Tower Menu**
field:

```csharp:Picker.cs
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

// Works out what the player tapped or clicked. A press that isn't on the UI
// casts a ray from the camera through the pointer: if it hits a plot, the
// build menu opens over an empty one, and the tower menu over a tower.
// Anywhere else closes them.
public class Picker : MonoBehaviour
{
    [SerializeField] GateGame game;
    [SerializeField] LayerMask plotMask;
    [SerializeField] BuildMenu buildMenu;
    [SerializeField] TowerMenu towerMenu;

    Camera cam;

    public bool HasMenuOpen
    {
        get { return buildMenu.IsOpen || towerMenu.IsOpen; }
    }

    void Awake()
    {
        cam = Camera.main;
    }

    void Update()
    {
        Pointer pointer = Pointer.current;
        if (!game.IsPlaying || pointer == null || !pointer.press.wasPressedThisFrame)
        {
            return;
        }
        // A press on a button belongs to the button.
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        Ray ray = cam.ScreenPointToRay(pointer.position.ReadValue());
        if (Physics.Raycast(ray, out RaycastHit hit, 200f, plotMask) && hit.collider.TryGetComponent(out BuildPlot plot))
        {
            if (plot.IsEmpty)
            {
                towerMenu.Close();
                buildMenu.Open(plot);
            }
            else
            {
                buildMenu.Close();
                towerMenu.Open(plot);
            }
        }
        else
        {
            CloseMenus();
        }
    }

    public void CloseMenus()
    {
        buildMenu.Close();
        towerMenu.Close();
    }
}
```

`HasMenuOpen` and `CloseMenus` are for Chapter 13: **Esc** will close a menu before it
pauses the game.

### Test it

Press **Play** (with **Start Gold** `1000` while you test).

- Build an Arrow tower: it pops as it appears. Tap it: the tower menu opens over it,
  `Arrow Tower`, one star, Upgrade `40`, `Sell 30`, and a white ring on the ground
  shows its range.
- **Upgrade**: the tower pops, a second storey appears under the archer, and the archer
  rises with it. Two stars; the ring is wider, 4.5; Upgrade `70`; `Sell 54`.
- **Upgrade** again: two green flags. Three stars, Upgrade says `Max`, and its button is
  locked. `Sell 96`.
- **Sell**: the gold goes up by 96, the tower is gone, and the plot is empty again. Tap
  it: the build menu.
- Do the same with the Catapult tower, and watch the whole catapult rise onto its new
  storey. Then with the Frost tower: at Level 3, a bolt slows a whole crowd.
- Set **Start Gold** back to `120`, and try to afford an upgrade: its button stays locked
  until a bounty or two come in, and lights up by itself when they do.

### Challenge

Give the towers a fourth level: a fourth element in an Arrow tower's **Levels**, and a
`Level 4` state and clip with the tower even taller. What else has to change? Look at
`Tower.CanUpgrade`, at the tower menu's stars, and at the Animator. Then take it out
again.

# Part 4 — Waves

## Chapter 11 — Ten Waves

**Goal:** the endless stream of skeletons becomes ten waves, each a name and a list of
groups, all filled in in the Inspector. **Start Wave** sends the first; a cleared wave
pays its bonus, and the next one counts down from 15. Each wave's name shows in the
middle of the screen, and the HUD says which wave it is.

### Idea — waves are data

| Wave | Name | Groups: which skeleton, how many, seconds apart |
| --- | --- | --- |
| 1 | The First Rising | 6 Minions, 1.6 |
| 2 | More Bones | 10 Minions, 1.2 |
| 3 | Hooded Runners | 6 Minions, 1.2; then 4 Rogues, 0.9 |
| 4 | The Quick Ones | 10 Rogues, 0.7 |
| 5 | Shields | 2 Warriors, 2.5; then 8 Minions, 1 |
| 6 | The Wall of Shields | 6 Warriors, 2 |
| 7 | Run and Hide | 10 Rogues, 0.6; then 4 Warriors, 2 |
| 8 | The Long March | 14 Minions, 0.8; 6 Rogues, 0.7; 3 Warriors, 2 |
| 9 | Iron and Bone | 8 Warriors, 1.6; then 8 Rogues, 0.6 |
| 10 | The Bone Mage | 10 Minions, 0.9; 6 Warriors, 1.8; the Bone Mage |

None of that belongs in code. Two plain classes hold it, both `[System.Serializable]`
like `TowerLevel`:

```
   WaveSpawner
     └── Wave[] waves               ten of them
           ├── string title         "Hooded Runners"
           └── SpawnGroup[] groups  two, in wave 3
                 ├── Enemy enemyPrefab    Minion
                 ├── int count            6
                 └── float gap            1.2
```

Arrays inside an array: the Inspector shows **Waves**, each element opens into its
**Title** and its **Groups**, and each group into its three fields. A designer can
rebalance the whole game without opening a script.

### Idea — the spawner, as a state machine

| State | What it does | Leaves for |
| --- | --- | --- |
| **Waiting** | shows Start Wave; counts down, from wave 2 on | Spawning, on Start Wave, Space, or the end of the countdown |
| **Spawning** | a coroutine makes the wave's skeletons, one group after another | In Progress, when the last skeleton is made |
| **In Progress** | waits for the road to be empty | Cleared, when `Skeletons` has no children left |
| **Cleared** | pays the bonus | Waiting; or, after wave 10, the game is won |

```
              Start Wave            the last one is made         none left
   Waiting ─────────────► Spawning ─────────────────► InProgress ─────────► Cleared
      ▲                                                                       │
      └────────────── a bonus, and the next wave counts down ─────────────────┘
```

**In Progress** doesn't count skeletons: it asks `skeletonGroup.childCount == 0`. Every
skeleton is made under `Skeletons`, and destroys itself when it falls or crumbles at the
gate, so an empty group means the wave is over, however each of them went.

**Cleared**'s enter step can call `EnterState(State.Waiting)` itself: one state's enter
step moving straight on to the next.

### Idea — a message that fades

`GateGame.ShowMessage` shows a line in the middle of the screen for two seconds, then
fades it out over one, in a coroutine. A new message while the old one is still showing
stops the old coroutine first, with `StopCoroutine`, so the two don't fight over the
text.

### Do it — SpawnGroup and Wave

Create `Assets/Scripts/SpawnGroup.cs` and `Assets/Scripts/Wave.cs`. Neither is a
component: don't attach them to anything.

```csharp:SpawnGroup.cs
using UnityEngine;

// One group of skeletons in a wave: which kind, how many, and how long to wait
// between them. [System.Serializable] lets a plain C# class show in the
// Inspector, so a Wave can keep an array of them.
[System.Serializable]
public class SpawnGroup
{
    [SerializeField] Enemy enemyPrefab;
    [SerializeField] int count = 6;
    [SerializeField] float gap = 1.5f;      // seconds between one skeleton and the next

    public Enemy EnemyPrefab
    {
        get { return enemyPrefab; }
    }

    public int Count
    {
        get { return count; }
    }

    public float Gap
    {
        get { return gap; }
    }
}
```

```csharp:Wave.cs
using UnityEngine;

// One wave: its name, and its groups of skeletons, which come one group after
// another. WaveSpawner keeps an array of these, and each one holds an array
// of SpawnGroups: arrays inside an array, all filled in in the Inspector.
[System.Serializable]
public class Wave
{
    [SerializeField] string title;
    [SerializeField] SpawnGroup[] groups;

    public string Title
    {
        get { return title; }
    }

    public SpawnGroup[] Groups
    {
        get { return groups; }
    }
}
```

`title`, not `name`: every Unity object already has a `name`, and a field with that name
would be confusing.

### Do it — the game shows messages

Replace `GateGame` with this version:

```csharp
using System.Collections;
using TMPro;
using UnityEngine;

// The game itself: the one object every piece of the battlefield can ask for
// what it needs. It knows the bank and the gate, fills the bank as the game
// starts, and shows messages in the middle of the screen.
public class GateGame : MonoBehaviour
{
    [SerializeField] Bank bank;
    [SerializeField] Gate gate;
    [SerializeField] TMP_Text messageText;

    Coroutine messageFade;

    // Chapter 13 gives the game its states: start, playing, paused, won and
    // lost. Until then, it's always being played.
    public bool IsPlaying
    {
        get { return true; }
    }

    public Bank Bank
    {
        get { return bank; }
    }

    public Gate Gate
    {
        get { return gate; }
    }

    void Awake()
    {
        messageText.text = "";
        bank.ResetBank();
    }

    // The spawner calls this when the last wave is cleared, and the gate
    // when its last life goes. Chapter 13 makes them the Won and Lost
    // states, each with its own panel.
    public void Win()
    {
        ShowMessage("The gate held!");
    }

    public void Lose()
    {
        ShowMessage("The gate has fallen");
    }

    // A line in the middle of the screen, such as "Wave 3 cleared! +35 gold".
    public void ShowMessage(string message)
    {
        if (messageFade != null)
        {
            StopCoroutine(messageFade);
        }
        messageFade = StartCoroutine(FadeText(message));
    }

    // Shows the text for two seconds, then fades it out over one.
    IEnumerator FadeText(string text)
    {
        messageText.text = text;
        messageText.alpha = 1f;
        yield return new WaitForSeconds(2f);
        for (float t = 0f; t < 1f; t += Time.deltaTime)
        {
            messageText.alpha = 1f - t;
            yield return null;
        }
        messageText.text = "";
    }
}
```

`Win` and `Lose` show a message now. Chapter 13 makes them real.

### Do it — the wave on the screen

| Object | Type | Parent | Anchor | Pos | Size |
| --- | --- | --- | --- | --- | --- |
| `Wave Bar` | Image | Canvas | top-left | (610, −30) | 340 × 95 |
| `Icon` | Image | Wave Bar | middle-left | (14, 0) | 66 × 66 |
| `Wave Text` | Text - TextMeshPro | Wave Bar | middle-left | (100, 2) | 230 × 80 |
| `Message Text` | Text - TextMeshPro | Canvas | middle-center | (0, 300) | 1400 × 100 |
| `Countdown Text` | Text - TextMeshPro | Canvas | middle-center | (0, −330) | 1400 × 70 |
| `Start Wave Button` | Button - TextMeshPro | Canvas | middle-center | (0, −430) | 360 × 140 |
| `Icon` | Image | Start Wave Button | middle-left | (34, 4) | 64 × 64 |

1. `Wave Bar` and its icon as the gold's, `Bar` and `Skull`, but longer: `Wave 10 / 10`
   needs the room. `Wave Text` says `Wave 0 / 10`, **Font Size** `34`, left, `#FFF7E6`.
2. `Message Text`: empty, **Font Size** `64`, centred, `#FFF7E6`. `Countdown Text`:
   empty, **Font Size** `40`, centred, `#FFF7E6`. Untick **Raycast Target** on both, and
   on the bar and its parts.
3. `Start Wave Button` shows `ButtonNormal`, with **Sprite Swap**: `ButtonHover`,
   `ButtonClick`, `ButtonNormal` and `ButtonLocked`. Its `Text (TMP)` child: rename it
   `Label`, **Position** `(30, 4)`, `Start Wave`, **Font Size** `50`, `#FFF7E6`. Its
   `Icon` shows `CrossedSwords`, **Raycast Target** unticked. Switch the button off: the
   spawner shows it whenever it's waiting for a wave.

### Do it — WaveSpawner, with waves

Replace `WaveSpawner` with this version:

```csharp
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

// Sends the waves, run as a state machine: Waiting for the next wave,
// Spawning its skeletons, In Progress while they're on the road, and Cleared
// when none are left. Each wave is a Wave in the array, filled in in the
// Inspector.
public class WaveSpawner : MonoBehaviour
{
    public enum State { Waiting, Spawning, InProgress, Cleared }

    [SerializeField] GateGame game;
    [SerializeField] Bank bank;
    [SerializeField] WaypointPath path;
    [SerializeField] Transform skeletonGroup;     // every skeleton goes here, so the spawner can count them
    [SerializeField] Wave[] waves;
    [SerializeField] float countdownSeconds = 15f;
    [SerializeField] int bonusBase = 20;          // a cleared wave pays bonusBase + bonusPerWave × its number
    [SerializeField] int bonusPerWave = 5;
    [SerializeField] Button startWaveButton;
    [SerializeField] TMP_Text countdownText;
    [SerializeField] TMP_Text waveText;

    State state;
    int waveIndex;              // the next wave to send: 0 is wave 1
    float countdown;

    void OnEnable()
    {
        startWaveButton.onClick.AddListener(StartNextWave);
    }

    void OnDisable()
    {
        startWaveButton.onClick.RemoveListener(StartNextWave);
    }

    // Before wave 1, waiting for the player.
    void Start()
    {
        waveText.text = $"Wave 0 / {waves.Length}";
        EnterState(State.Waiting);
    }

    void Update()
    {
        if (!game.IsPlaying)
        {
            return;
        }

        switch (state)
        {
            case State.Waiting:
                UpdateWaiting();
                break;
            case State.Spawning:
                break;                  // the SpawnWave coroutine is at work
            case State.InProgress:
                if (skeletonGroup.childCount == 0)
                {
                    EnterState(State.Cleared);
                }
                break;
            case State.Cleared:
                break;
        }
    }

    void EnterState(State next)
    {
        state = next;
        startWaveButton.gameObject.SetActive(state == State.Waiting);

        switch (state)
        {
            case State.Waiting:
                countdown = countdownSeconds;
                countdownText.text = waveIndex == 0 ? "Build your towers, then start the first wave" : "";
                break;
            case State.Spawning:
                countdownText.text = "";
                waveText.text = $"Wave {waveIndex + 1} / {waves.Length}";
                game.ShowMessage(waves[waveIndex].Title);
                StartCoroutine(SpawnWave(waves[waveIndex]));
                break;
            case State.InProgress:
                break;
            case State.Cleared:
                int bonus = bonusBase + bonusPerWave * (waveIndex + 1);
                bank.Earn(bonus);
                waveIndex++;
                if (waveIndex >= waves.Length)
                {
                    game.Win();
                }
                else
                {
                    game.ShowMessage($"Wave {waveIndex} cleared! +{bonus} gold");
                    EnterState(State.Waiting);
                }
                break;
        }
    }

    // Wave 1 waits for the button; after that, the countdown starts the next
    // wave by itself, unless the player is quicker.
    void UpdateWaiting()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard != null && keyboard.spaceKey.wasPressedThisFrame)
        {
            StartNextWave();
            return;
        }
        if (waveIndex == 0)
        {
            return;
        }
        countdown -= Time.deltaTime;
        countdownText.text = $"Next wave in {Mathf.CeilToInt(countdown)}";
        if (countdown <= 0f)
        {
            StartNextWave();
        }
    }

    public void StartNextWave()
    {
        if (state == State.Waiting && game.IsPlaying)
        {
            EnterState(State.Spawning);
        }
    }

    // A coroutine: one skeleton, a wait, the next, group after group.
    IEnumerator SpawnWave(Wave wave)
    {
        foreach (SpawnGroup group in wave.Groups)
        {
            for (int i = 0; i < group.Count; i++)
            {
                Enemy enemy = Instantiate(group.EnemyPrefab, path.GetPoint(0), Quaternion.identity, skeletonGroup);
                enemy.Begin(game, path);
                yield return new WaitForSeconds(group.Gap);
            }
        }
        EnterState(State.InProgress);
    }
}
```

Select `Gate Game`, and fill in the spawner's new fields: `Gate Game` into **Bank**;
`Start Wave Button`, `Countdown Text` and `Wave Text`. **Countdown Seconds** `15`,
**Bonus Base** `20` and **Bonus Per Wave** `5` are already set. Then the waves: set
**Waves** to `10`, and fill in each from the table in *Waves are data*. Wave 3, for
example, is **Title** `Hooded Runners`, and **Groups** of two: `Minion`, **Count** `6`,
**Gap** `1.2`; then `Rogue`, `4`, `0.9`. The Bone Mage's group in wave 10 is **Count**
`1`, **Gap** `1`.

Read it before you move on:

- `SpawnWave` is a coroutine with a loop inside a loop: for each group, for each
  skeleton, make one and wait the group's gap. Only when both loops end does it move to
  In Progress.
- `$"Wave {waveIndex + 1} / {waves.Length}"`: `waveIndex` counts from 0, as arrays do,
  but players count waves from 1.
- `EnterState` shows the Start Wave button in Waiting, and hides it in every other
  state, in one line.
- Wave 1 waits for the player: `if (waveIndex == 0) return;` skips the countdown. Wave 2
  onwards counts down, and `Mathf.CeilToInt` shows `15`, `14`… down to `1`, not
  `14.97`.
- The spawner starts in **Waiting**, from its own `Start`. Chapter 13 hands that job to
  the game's Restart.

### Test it

Press **Play**.

- The HUD says `Wave 0 / 10`. Near the bottom of the screen, over the **Start Wave**
  button, it says *Build your towers, then start the first wave*. No skeletons come.
- Build two Arrow towers, and press **Start Wave**. The button goes; *The First Rising*
  shows in the middle of the screen and fades; the HUD says `Wave 1 / 10`; six Minions
  rise, 1.6 seconds apart.
- When the last of them is gone, killed or crumbled at the gate: *Wave 1 cleared! +25
  gold*, the gold goes up by 25, and the button is back, with *Next wave in 15*, 14,
  13… At 0, wave 2 starts by itself. Press **Space** during a countdown to start early.
- Play on. Wave 3 ends with Rogues; wave 5 opens with two Warriors. If you hold out to
  the end of wave 10, the middle of the screen says *The gate held!*

### Challenge

Pay a bonus for starting early: when the player starts a wave while the countdown is
running, give them the seconds left as gold. Which method gets the new line, and what
must it check first, so that wave 1, which has no countdown, pays nothing?

## Chapter 12 — The Screen

**Goal:** a health bar floats over every skeleton once it's been hit, on a **World Space
Canvas** that turns to face the camera wherever the skeleton walks. The **x2** button
plays the game at double speed, and the pause button waits beside it. The game's four
panels, Start, Pause, Victory and Defeat, are built, and put away until Chapter 13.

### Idea — a canvas in the world

Every Canvas so far has been **Screen Space - Overlay**: drawn flat on the screen, on
top of everything. A **World Space** Canvas is a thing in the scene: it has a place and
a size in the world, it's drawn by the camera like a model, things can stand in front of
it, and it moves with its parent. Make one the child of a skeleton, a little above its
head, and it walks the road with it.

It's sized like any other Canvas, in its own units, and then scaled down: a bar 100 ×
14 at a scale of `0.019`, on a skeleton scaled `0.42`, is 0.8 units wide in the world.

A world-space canvas turns with its parent, so when the skeleton turns a corner, its bar
would turn edge-on to the camera and vanish. `EnemyHealthBar` turns it back in
**`LateUpdate`**, which Unity calls after every `Update` of the frame: the skeleton has
already moved and turned, and then the bar copies the camera's rotation, so its face is
always flat to the screen.

The bar itself is a **Filled** Image, as in C# 8: `fillAmount` is the share of
health left, from 1 down to 0. It's hidden at first, and shows from the first hit.

### Idea — double speed

`Time.timeScale` is how fast the game's clock runs: 1 is normal, 0 stops it, and 2 runs
it twice as fast. Everything that runs on `Time.deltaTime` and `WaitForSeconds` speeds
up with it: the skeletons' walking, the towers' reloading, the waves' gaps and the
countdown. The Animators speed up too: they run on the same clock. So one line doubles
the whole battle.

The button shows what pressing it will do: `x2` at normal speed, `x1` at double.

### Idea — four panels

| Panel | Shows | Buttons |
| --- | --- | --- |
| **Start Panel** | "Gate Guard", how to play, the icons' credits | **Play** |
| **Pause Panel** | "Paused", the volume | **Resume**, **Restart** |
| **Win Panel** | "Victory!", a crown, "The gate held!" and the lives left | **Play Again** |
| **Lose Panel** | "Defeat", "The gate has fallen" | **Try Again** |

Each is the same three layers: a black sheet over the whole screen, at 55% alpha, which
dims the battlefield and catches presses; a pzUH **window** in the middle; and a
**ribbon** across the window's top, with the title on it.

### Do it — EnemyHealthBar

Create `Assets/Scripts/EnemyHealthBar.cs`:

```csharp:EnemyHealthBar.cs
using UnityEngine;
using UnityEngine.UI;

// A health bar that floats over a skeleton, on a World Space Canvas. A canvas
// in the world turns with whatever holds it, so every frame, after the
// skeleton has moved and turned, the bar turns back to face the camera.
public class EnemyHealthBar : MonoBehaviour
{
    [SerializeField] Image fill;

    Transform cameraTransform;

    void Awake()
    {
        cameraTransform = Camera.main.transform;
    }

    void LateUpdate()
    {
        transform.rotation = cameraTransform.rotation;
    }

    // fraction is 1 at full health, 0.5 at half.
    public void Show(float fraction)
    {
        gameObject.SetActive(true);
        fill.fillAmount = fraction;
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
```

### Do it — a health bar over the Minion

Double-click the `Minion` prefab to open it.

1. Right-click `Minion` → **Create Empty**, name it `Health Bar`, and **Add Component →
   Canvas**. Set **Render Mode** to **World Space**. Its Transform is a Rect Transform
   now: **Pos** `(0, 2.75, 0)`, **Width** `100`, **Height** `14`, **Scale** `(0.019,
   0.019, 0.019)`.
2. Right-click `Health Bar` → **UI (Canvas) → Image**: `Back`, **Width** `100`, **Height**
   `14`, colour black at 60% alpha. Again: `Fill`, **Width** `96`, **Height** `10`,
   showing `HealthFill`, with **Image Type** **Filled**, **Fill Method** **Horizontal**,
   **Fill Origin** **Left**. Untick **Raycast Target** on both.
3. Add `EnemyHealthBar` to `Health Bar`, and drag `Fill` into its **Fill**.
4. Drag `Health Bar` into the Minion's `Enemy`'s **Health Bar** field once you've
   replaced `Enemy`, below.
5. Copy `Health Bar` into the other three skeletons (**Ctrl + C** here, **Ctrl + V** on
   each prefab's root), and drag each into its own `Enemy`'s **Health Bar**. Its numbers
   stay the same: inside the Bone Mage, scaled `0.62`, the same bar comes out bigger, as a
   boss's should.

### Do it — Enemy shows its health

Replace `Enemy` with this version:

```csharp
using System.Collections;
using UnityEngine;

// A skeleton on the road, run as a state machine. The code decides what it
// does; its Animator, the Skeleton controller, only shows the body: rising
// from the ground, walking, chopping at the gate, falling. Every kind of
// skeleton is this one script, with its own numbers in the Inspector.
[RequireComponent(typeof(Animator))]
public class Enemy : MonoBehaviour
{
    public enum State { Rising, Walking, Slowed, Dying, AtGate }

    static readonly int WalkSpeedHash = Animator.StringToHash("WalkSpeed");
    static readonly int DieHash = Animator.StringToHash("Die");
    static readonly int AttackHash = Animator.StringToHash("Attack");
    static readonly int CheerHash = Animator.StringToHash("Cheer");

    [SerializeField] int maxHealth = 6;
    [SerializeField] float speed = 1.5f;            // units a second, on the road
    [SerializeField] int bounty = 5;                // gold, for the tower that finishes it
    [SerializeField] int livesCost = 1;             // what it costs the gate
    [SerializeField] float turnSpeed = 540f;        // degrees a second
    [SerializeField] EnemyHealthBar healthBar;
    [SerializeField] GameObject frost;              // the frost that shows while it's slowed
    [SerializeField] Color frostTint = new Color(0.62f, 0.85f, 1f);

    GateGame game;
    WaypointPath path;
    Animator animator;
    Collider bodyCollider;
    Renderer[] bodyRenderers;
    State state;
    int health;
    int nextPoint;
    float distanceTravelled;
    float slowFactor = 1f;
    float slowUntil;
    bool killedByTower;
    Color tint = Color.white;
    Coroutine flash;

    // How far along the road it has walked: the towers aim at the biggest.
    public float DistanceTravelled
    {
        get { return distanceTravelled; }
    }

    // Towers only shoot at a skeleton that's up and walking.
    public bool IsTargetable
    {
        get { return state == State.Walking || state == State.Slowed; }
    }

    void Awake()
    {
        animator = GetComponent<Animator>();
        bodyCollider = GetComponent<Collider>();
        bodyRenderers = GetComponentsInChildren<SkinnedMeshRenderer>();
    }

    // The spawner calls this as soon as it makes the skeleton: a prefab can't
    // point at things in the scene, so it's handed them here.
    public void Begin(GateGame owner, WaypointPath road)
    {
        game = owner;
        path = road;
        health = maxHealth;
        nextPoint = 1;
        distanceTravelled = 0f;
        transform.position = path.GetPoint(0);
        transform.rotation = Quaternion.LookRotation(path.GetPoint(1) - path.GetPoint(0));
        EnterState(State.Rising);
    }

    void Update()
    {
        // Before Begin, while paused (the clock stops), and after the end, it waits.
        if (game == null || !game.IsPlaying)
        {
            return;
        }

        switch (state)
        {
            case State.Rising:
                break;                  // waits for the OnRisen Animation Event
            case State.Walking:
                Walk(1f);
                break;
            case State.Slowed:
                Walk(slowFactor);
                if (Time.time >= slowUntil)
                {
                    EnterState(State.Walking);
                }
                break;
            case State.Dying:
                break;                  // waits for OnDeathFinished
            case State.AtGate:
                break;                  // waits for OnGateHit
        }
    }

    // The one place the state changes. The enter step runs once, as the
    // skeleton arrives in its new state.
    void EnterState(State next)
    {
        state = next;

        switch (state)
        {
            case State.Rising:
                bodyCollider.enabled = false;           // the towers can't see it yet
                healthBar.Hide();
                break;
            case State.Walking:
                bodyCollider.enabled = true;
                slowFactor = 1f;
                animator.SetFloat(WalkSpeedHash, 1f);
                frost.SetActive(false);
                SetTint(Color.white);
                break;
            case State.Slowed:
                animator.SetFloat(WalkSpeedHash, slowFactor);   // the Walk clip plays slower too
                frost.SetActive(true);
                SetTint(frostTint);
                break;
            case State.Dying:
                bodyCollider.enabled = false;
                healthBar.Hide();
                frost.SetActive(false);
                animator.SetTrigger(DieHash);
                break;
            case State.AtGate:
                bodyCollider.enabled = false;
                animator.SetTrigger(AttackHash);
                break;
        }
    }

    // Walks towards the next point on the road, turning to face it. factor is
    // 1 at full speed, 0.5 when slowed.
    void Walk(float factor)
    {
        Vector3 target = path.GetPoint(nextPoint);
        Vector3 before = transform.position;
        transform.position = Vector3.MoveTowards(before, target, speed * factor * Time.deltaTime);
        distanceTravelled += Vector3.Distance(before, transform.position);

        Vector3 toTarget = target - transform.position;
        if (toTarget.sqrMagnitude > 0.0001f)
        {
            Quaternion facing = Quaternion.LookRotation(toTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, facing, turnSpeed * Time.deltaTime);
        }

        if (transform.position == target)
        {
            nextPoint++;
            if (nextPoint >= path.Count)
            {
                EnterState(State.AtGate);
            }
        }
    }

    // A tower's shot hit it.
    public void TakeDamage(int damage)
    {
        if (!IsTargetable)
        {
            return;
        }
        health -= damage;
        healthBar.Show((float)health / maxHealth);
        if (flash != null)
        {
            StopCoroutine(flash);
        }
        flash = StartCoroutine(FlashRed());
        if (health <= 0)
        {
            killedByTower = true;
            EnterState(State.Dying);
        }
    }

    // A frost bolt hit it: slower for a while. Two bolts keep the slower
    // speed and the later end.
    public void Slow(float factor, float seconds)
    {
        if (!IsTargetable)
        {
            return;
        }
        slowFactor = state == State.Slowed ? Mathf.Min(slowFactor, factor) : factor;
        slowUntil = Mathf.Max(slowUntil, Time.time + seconds);
        EnterState(State.Slowed);
    }

    // The gate has fallen: whoever is still standing celebrates.
    public void Cheer()
    {
        if (state != State.Dying)
        {
            animator.SetTrigger(CheerHash);
        }
    }

    // Animation Event: the end of the Rise clip, once it's out of the ground.
    public void OnRisen()
    {
        if (state == State.Rising)
        {
            EnterState(State.Walking);
        }
    }

    // Animation Event: the chop's frame, as the blade hits the gate.
    public void OnGateHit()
    {
        if (state != State.AtGate)
        {
            return;
        }
        game.Gate.TakeHit(livesCost);
        killedByTower = false;          // no bounty for this one
        EnterState(State.Dying);
    }

    // Animation Event: the end of the Die clip.
    public void OnDeathFinished()
    {
        if (killedByTower)
        {
            game.Bank.Earn(bounty);
        }
        Destroy(gameObject);
    }

    // An Animator has one layer at Level 3, so a hit can't play a clip without
    // stopping the walk. The hit shows as a red flash instead, for a moment.
    IEnumerator FlashRed()
    {
        SetColour(Color.red);
        yield return new WaitForSeconds(0.08f);
        SetColour(tint);
        flash = null;
    }

    void SetTint(Color colour)
    {
        tint = colour;
        SetColour(colour);
    }

    void SetColour(Color colour)
    {
        foreach (Renderer part in bodyRenderers)
        {
            part.material.color = colour;
        }
    }
}
```

What's new:

- `healthBar.Hide()` as it rises and as it falls; `healthBar.Show((float)health /
  maxHealth)` at every hit. `(float)` matters: `health / maxHealth` with two `int`s is
  `0` until the very end, because `int` division drops the fraction.
- `Cheer` is for Chapter 13: when the gate falls, the game calls it on every skeleton
  still standing. A skeleton that's already falling doesn't cheer.

### Do it — x2 and pause

| Object | Type | Parent | Anchor | Pos | Size |
| --- | --- | --- | --- | --- | --- |
| `Speed Button` | Button - TextMeshPro | Canvas | top-right | (−170, −30) | 120 × 120 |
| `Pause Button` | Button - TextMeshPro | Canvas | top-right | (−30, −30) | 120 × 120 |

1. `Speed Button` is a square button like the build menu's, with **Sprite Swap**. Keep
   its text child: rename it `Label`, `x2`, **Font Size** `52`, `#FFF7E6`.
2. `Pause Button` shows `PauseButton`, and keeps the usual **Color Tint** transition.
   Delete its text child. It works from Chapter 13.

Replace `GateGame` with this version, and drag `Speed Button` and its `Label` into the
new **Speed Button** and **Speed Text** fields:

```csharp
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

// The game itself: the one object every piece of the battlefield can ask for
// what it needs. It knows the bank and the gate, fills the bank as the game
// starts, keeps the game's speed (normal or double), and shows messages.
public class GateGame : MonoBehaviour
{
    [SerializeField] Bank bank;
    [SerializeField] Gate gate;
    [SerializeField] TMP_Text messageText;
    [SerializeField] Button speedButton;
    [SerializeField] TMP_Text speedText;

    float speed = 1f;
    Coroutine messageFade;

    // Chapter 13 gives the game its states: start, playing, paused, won and
    // lost. Until then, it's always being played.
    public bool IsPlaying
    {
        get { return true; }
    }

    public Bank Bank
    {
        get { return bank; }
    }

    public Gate Gate
    {
        get { return gate; }
    }

    void OnEnable()
    {
        speedButton.onClick.AddListener(ToggleSpeed);
    }

    void OnDisable()
    {
        speedButton.onClick.RemoveListener(ToggleSpeed);
    }

    void Awake()
    {
        messageText.text = "";
        bank.ResetBank();
    }

    void Update()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard != null && keyboard.fKey.wasPressedThisFrame)
        {
            ToggleSpeed();
        }
    }

    // The spawner calls this when the last wave is cleared, and the gate
    // when its last life goes. Chapter 13 makes them the Won and Lost
    // states, each with its own panel.
    public void Win()
    {
        ShowMessage("The gate held!");
    }

    public void Lose()
    {
        ShowMessage("The gate has fallen");
    }

    // Normal speed or double: the button shows what pressing it will do.
    public void ToggleSpeed()
    {
        speed = speed > 1f ? 1f : 2f;
        speedText.text = speed > 1f ? "x1" : "x2";
        Time.timeScale = speed;
    }

    // A line in the middle of the screen, such as "Wave 3 cleared! +35 gold".
    public void ShowMessage(string message)
    {
        if (messageFade != null)
        {
            StopCoroutine(messageFade);
        }
        messageFade = StartCoroutine(FadeText(message));
    }

    // Shows the text for two seconds, then fades it out over one.
    IEnumerator FadeText(string text)
    {
        messageText.text = text;
        messageText.alpha = 1f;
        yield return new WaitForSeconds(2f);
        for (float t = 0f; t < 1f; t += Time.deltaTime)
        {
            messageText.alpha = 1f - t;
            yield return null;
        }
        messageText.text = "";
    }
}
```

### Do it — the four panels

Build the Start panel first; then duplicate it (**Ctrl + D**) for the others, and change
what differs.

| Object | Type | Parent | Anchor | Pos | Size |
| --- | --- | --- | --- | --- | --- |
| `Start Panel` | Image | Canvas | stretch, both ways | — | the whole screen |
| `Window` | Image | Start Panel | middle-center | (0, 0) | 760 × 806 |
| `Ribbon` | Image | Window | top-center | (0, 46) | 560 × 113 |
| `Title` | Text - TextMeshPro | Ribbon | middle-center | (0, 6) | 300 × 70 |
| `How To Play` | Text - TextMeshPro | Window | middle-center | (0, 40) | 620 × 470 |
| `Play Button` | Button - TextMeshPro | Window | middle-center | (0, −245) | 300 × 118 |
| `Credits` | Text - TextMeshPro | Window | middle-center | (0, −332) | 640 × 50 |

1. `Start Panel`: **Anchor** **stretch** both ways, with **Shift + Alt**, so it fills
   the screen; colour black, alpha 55%; **Raycast Target** ticked.
2. `Window` shows `PanelSquare`, and `Ribbon` shows `Ribbon`.
3. The texts are `#4A3420`, centred: `Title` says `Gate Guard`, size `44`. `How To Play`,
   size `30`, says:

   ```
   Skeletons are marching on the castle gate.

   Tap a dirt plot to build a tower.
   Tap a tower to upgrade it, or sell it.

   Arrows hit one skeleton, stones hit a crowd,
   and frost slows them down.

   Hold the gate for ten waves!
   ```

   `Credits`, size `18`, on two lines: *Icons by Lorc, Delapouite, Skoll and sbed:* and
   *game-icons.net, CC BY 3.0*. That's the credit the icons' licence asks for.
4. `Play Button` is a wide button like Start Wave, with the same four pictures, its
   label `Play`, size `42`, `#FFF7E6`.

Then the other three, each with its own **Window** size and title:

| Panel | Window | Title | Its own parts (in the Window) |
| --- | --- | --- | --- |
| `Pause Panel` | `PanelTall`, 520 × 700 | `Paused` | `Resume Button` (0, 120) and `Restart Button` (0, −20), 300 × 118; `Volume Label`, a text `Volume`, size 32, at (0, −130), 300 × 50; `Volume Slider`, **UI (Canvas) → Slider**, at (0, −190), width 300, **Scale** (1.4, 1.4, 1), **Value** 1 |
| `Win Panel` | `PanelSquare`, 700 × 742 | `Victory!` | `Crown`, an image of `Crown`, anchored top-center at (0, −70), under the ribbon, 240 × 164; `Win Text`, `The gate held!`, size 40, at (0, 30), 600 × 300; `Play Again Button` (0, −230), 330 × 124 |
| `Lose Panel` | `PanelSquare`, 700 × 742 | `Defeat` | `Lose Text`, `The gate has fallen`, size 44, at (0, 40), 600 × 200; `Try Again Button` (0, −230), 330 × 124 |

The wide buttons' labels are `Resume`, `Restart`, `Play Again` and `Try Again`, size
`42` on the 118-tall buttons and `45` on the 124-tall ones. Delete the copies of `How To
Play`, `Credits` and `Play Button` that the duplicates brought along.

Last, switch **all four** panels off. Chapter 13's game decides which one shows.

### Test it

Press **Play**, and start a wave.

- The skeletons walk with no bars. The first arrow that hits one shows its bar over its
  head, five sixths full on a Minion; each hit shortens it. Watch a bar round a bend: it stays
  flat to you.
- A Warrior's bar shrinks slowly; the Bone Mage's is bigger, and shrinks very slowly.
- Click **x2**: everything moves twice as fast, skeletons, arrows, reloads, the
  countdown, and the button says `x1`. Click it again, or press **F**. The pause button
  does nothing yet.
- Stop the game. Switch each panel on in the Hierarchy, look at it in the Game view, and
  switch it off again.

### Challenge

Make the health bar change colour as it empties, as Knight Run's did: green above half,
yellow above a quarter, red below. `fill.color` is the Image's colour. Which method
changes, and where does the fraction come from?

## Chapter 13 — Hold the Gate

**Goal:** the game becomes a state machine. A start screen waits for **Play**; **Esc**,
**P** or the pause button pause it, with Resume, Restart and the volume; clearing wave 10
wins, and the gate's last life loses: its doors burst open (a **Bool**, `Broken`) and
every skeleton still on the road cheers. Every button that starts again calls the same
`Restart`, which puts the whole battlefield back, in code.

### Idea — the game's own state machine

| State | Enter step | Leaves for |
| --- | --- | --- |
| **Start** | the Start panel; the clock at normal speed | Playing, on **Play** |
| **Playing** | no panel; the clock at the chosen speed, 1 or 2 | Paused, on Esc, P or the pause button; Won; Lost |
| **Paused** | the Pause panel; the clock stopped; the menus closed | Playing, on Resume, Esc or P; or Restart |
| **Won** | the Win panel, with the lives left | Playing, through Restart, on **Play Again** |
| **Lost** | the Lose panel; no more skeletons; every skeleton cheers | Playing, through Restart, on **Try Again** |

`IsPlaying` stops being a stand-in: it's `state == GameState.Playing`. Every script that
has asked it since Chapter 5 now waits on the start screen, in the pause and after the
end, with no change to any of them. That's why the stand-in was there.

**Esc** does two jobs: with a build or tower menu open, it closes the menu; otherwise it
pauses. `picker.HasMenuOpen` tells them apart.

### Idea — Restart, piece by piece

Restart doesn't load the scene again: loading scenes is Level 4. It puts every piece
back, each with a method of its own:

| Piece | On Restart |
| --- | --- |
| `WaveSpawner.ResetSpawner` | stops its coroutine, destroys every skeleton, back to wave 0 and Waiting |
| the shots | every arrow, stone and bolt still flying is destroyed |
| `BuildPlot.Clear`, on every plot | destroys its tower |
| `Bank.ResetBank` | 120 gold, 10 lives |
| `Gate.ResetGate` | the doors shut |
| `GateGame` | normal speed, no message, the build music (Chapter 14), and Playing |

`GetComponentsInChildren<BuildPlot>()` on `Build Plots` finds all 13 plots at once, and
`GetComponentsInChildren<Enemy>()` on `Skeletons` every skeleton.

### Idea — a Bool for the end

The gate's **Hit** is a trigger: a shudder is a moment. **Broken** is a **Bool**: a gate
stays broken. `Any State → Broken` when `Broken` is true, and Broken's clip throws the
doors open, 100° each, and holds them there.

To mend it on Restart, `Broken` goes back to false; but no arrow leads out of Broken, so
the Animator would stay there. `animator.Rebind()` starts the Animator again from
scratch: its default state, Shut, and every animated part back where it began.

### Do it — the gate can break

1. Select `Gate`, and in the Animation window make a third clip, `Gate Broken`, at 30
   samples, with **Loop Time** off: the left door's **Rotation.y** `0` at `0:00` and
   `100` at `0:18`; the right door's `0` and `-100`.
2. In the `Gate` controller, add a **Bool**, `Broken`, and an arrow from **Any State**
   to the new `Broken` state: **Transition Duration** `0`, **Can Transition To Self**
   off, the condition `Broken` **true**.

### Do it — the pieces can be put back

Replace `WaveSpawner` with this version. `Start` is gone: the game's Restart starts it.

```csharp
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

// Sends the waves, run as a state machine: Waiting for the next wave,
// Spawning its skeletons, In Progress while they're on the road, and Cleared
// when none are left. Each wave is a Wave in the array, filled in in the
// Inspector.
public class WaveSpawner : MonoBehaviour
{
    public enum State { Waiting, Spawning, InProgress, Cleared }

    [SerializeField] GateGame game;
    [SerializeField] Bank bank;
    [SerializeField] WaypointPath path;
    [SerializeField] Transform skeletonGroup;     // every skeleton goes here, so Restart finds them
    [SerializeField] Wave[] waves;
    [SerializeField] float countdownSeconds = 15f;
    [SerializeField] int bonusBase = 20;          // a cleared wave pays bonusBase + bonusPerWave × its number
    [SerializeField] int bonusPerWave = 5;
    [SerializeField] Button startWaveButton;
    [SerializeField] TMP_Text countdownText;
    [SerializeField] TMP_Text waveText;

    State state;
    int waveIndex;              // the next wave to send: 0 is wave 1
    float countdown;

    void OnEnable()
    {
        startWaveButton.onClick.AddListener(StartNextWave);
    }

    void OnDisable()
    {
        startWaveButton.onClick.RemoveListener(StartNextWave);
    }

    void Update()
    {
        if (!game.IsPlaying)
        {
            return;
        }

        switch (state)
        {
            case State.Waiting:
                UpdateWaiting();
                break;
            case State.Spawning:
                break;                  // the SpawnWave coroutine is at work
            case State.InProgress:
                if (skeletonGroup.childCount == 0)
                {
                    EnterState(State.Cleared);
                }
                break;
            case State.Cleared:
                break;
        }
    }

    void EnterState(State next)
    {
        state = next;
        startWaveButton.gameObject.SetActive(state == State.Waiting);

        switch (state)
        {
            case State.Waiting:
                countdown = countdownSeconds;
                countdownText.text = waveIndex == 0 ? "Build your towers, then start the first wave" : "";
                break;
            case State.Spawning:
                countdownText.text = "";
                waveText.text = $"Wave {waveIndex + 1} / {waves.Length}";
                game.ShowMessage(waves[waveIndex].Title);
                StartCoroutine(SpawnWave(waves[waveIndex]));
                break;
            case State.InProgress:
                break;
            case State.Cleared:
                int bonus = bonusBase + bonusPerWave * (waveIndex + 1);
                bank.Earn(bonus);
                waveIndex++;
                if (waveIndex >= waves.Length)
                {
                    game.Win();
                }
                else
                {
                    game.ShowMessage($"Wave {waveIndex} cleared! +{bonus} gold");
                    EnterState(State.Waiting);
                }
                break;
        }
    }

    // Wave 1 waits for the button; after that, the countdown starts the next
    // wave by itself, unless the player is quicker.
    void UpdateWaiting()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard != null && keyboard.spaceKey.wasPressedThisFrame)
        {
            StartNextWave();
            return;
        }
        if (waveIndex == 0)
        {
            return;
        }
        countdown -= Time.deltaTime;
        countdownText.text = $"Next wave in {Mathf.CeilToInt(countdown)}";
        if (countdown <= 0f)
        {
            StartNextWave();
        }
    }

    public void StartNextWave()
    {
        if (state == State.Waiting && game.IsPlaying)
        {
            EnterState(State.Spawning);
        }
    }

    // A coroutine: one skeleton, a wait, the next, group after group.
    IEnumerator SpawnWave(Wave wave)
    {
        foreach (SpawnGroup group in wave.Groups)
        {
            for (int i = 0; i < group.Count; i++)
            {
                Enemy enemy = Instantiate(group.EnemyPrefab, path.GetPoint(0), Quaternion.identity, skeletonGroup);
                enemy.Begin(game, path);
                yield return new WaitForSeconds(group.Gap);
            }
        }
        EnterState(State.InProgress);
    }

    // The gate fell: no more skeletons.
    public void StopWaves()
    {
        StopAllCoroutines();
    }

    // Back to before wave 1: on Restart.
    public void ResetSpawner()
    {
        StopAllCoroutines();
        foreach (Enemy enemy in skeletonGroup.GetComponentsInChildren<Enemy>())
        {
            Destroy(enemy.gameObject);
        }
        waveIndex = 0;
        waveText.text = $"Wave 0 / {waves.Length}";
        EnterState(State.Waiting);
    }
}
```

Replace `Gate` with this version:

```csharp
using UnityEngine;

// The castle gate. Every skeleton that reaches it costs lives: the doors
// shudder (the Hit trigger), and when the last life goes they burst open
// (the Broken Bool) and the game is lost.
public class Gate : MonoBehaviour
{
    static readonly int HitHash = Animator.StringToHash("Hit");
    static readonly int BrokenHash = Animator.StringToHash("Broken");

    [SerializeField] GateGame game;
    [SerializeField] Bank bank;

    Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void TakeHit(int lives)
    {
        if (bank.Lives <= 0)
        {
            return;
        }
        bank.LoseLives(lives);
        if (bank.Lives > 0)
        {
            animator.SetTrigger(HitHash);
        }
        else
        {
            animator.SetBool(BrokenHash, true);
            game.Lose();
        }
    }

    // Doors shut again: on Restart.
    public void ResetGate()
    {
        animator.SetBool(BrokenHash, false);
        animator.Rebind();
    }
}
```

### Do it — GateGame, as a state machine

Replace `GateGame` with this version:

```csharp
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

// Runs the game as a state machine: Start, Playing, Paused, Won and Lost. It
// keeps the game's speed (normal or double), shows messages, and puts the
// whole battlefield back on Restart.
public class GateGame : MonoBehaviour
{
    public enum GameState { Start, Playing, Paused, Won, Lost }

    [SerializeField] Bank bank;
    [SerializeField] Gate gate;
    [SerializeField] WaveSpawner spawner;
    [SerializeField] Picker picker;
    [SerializeField] Transform plots;
    [SerializeField] Transform skeletons;
    [SerializeField] Transform shots;
    [SerializeField] TMP_Text messageText;
    [SerializeField] GameObject startPanel;
    [SerializeField] Button playButton;
    [SerializeField] Button pauseButton;
    [SerializeField] Button speedButton;
    [SerializeField] TMP_Text speedText;
    [SerializeField] GameObject pausePanel;
    [SerializeField] GameObject winPanel;
    [SerializeField] TMP_Text winText;
    [SerializeField] Button playAgainButton;
    [SerializeField] GameObject losePanel;
    [SerializeField] Button tryAgainButton;

    GameState state;
    float speed = 1f;
    Coroutine messageFade;

    public bool IsPlaying
    {
        get { return state == GameState.Playing; }
    }

    public Bank Bank
    {
        get { return bank; }
    }

    public Gate Gate
    {
        get { return gate; }
    }

    void OnEnable()
    {
        playButton.onClick.AddListener(Restart);
        pauseButton.onClick.AddListener(Pause);
        speedButton.onClick.AddListener(ToggleSpeed);
        playAgainButton.onClick.AddListener(Restart);
        tryAgainButton.onClick.AddListener(Restart);
    }

    void OnDisable()
    {
        playButton.onClick.RemoveListener(Restart);
        pauseButton.onClick.RemoveListener(Pause);
        speedButton.onClick.RemoveListener(ToggleSpeed);
        playAgainButton.onClick.RemoveListener(Restart);
        tryAgainButton.onClick.RemoveListener(Restart);
    }

    void Awake()
    {
        messageText.text = "";
        bank.ResetBank();
        EnterState(GameState.Start);
    }

    void Update()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard == null)
        {
            return;
        }

        switch (state)
        {
            case GameState.Start:
                break;
            case GameState.Playing:
                // Esc closes a menu if one is open; otherwise it pauses, as P does.
                if (keyboard.escapeKey.wasPressedThisFrame && picker.HasMenuOpen)
                {
                    picker.CloseMenus();
                }
                else if (keyboard.escapeKey.wasPressedThisFrame || keyboard.pKey.wasPressedThisFrame)
                {
                    Pause();
                }
                else if (keyboard.fKey.wasPressedThisFrame)
                {
                    ToggleSpeed();
                }
                break;
            case GameState.Paused:
                if (keyboard.escapeKey.wasPressedThisFrame || keyboard.pKey.wasPressedThisFrame)
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
        speedButton.gameObject.SetActive(state == GameState.Playing);

        switch (state)
        {
            case GameState.Start:
                Time.timeScale = 1f;
                break;
            case GameState.Playing:
                Time.timeScale = speed;         // 1, or 2 after the ×2 button
                break;
            case GameState.Paused:
                Time.timeScale = 0f;            // Animators, coroutines and timers all stop
                picker.CloseMenus();
                break;
            case GameState.Won:
                Time.timeScale = 1f;
                winText.text = $"The gate held!\n\nLives left: {bank.Lives}";
                picker.CloseMenus();
                break;
            case GameState.Lost:
                Time.timeScale = 1f;
                picker.CloseMenus();
                spawner.StopWaves();
                foreach (Enemy enemy in skeletons.GetComponentsInChildren<Enemy>())
                {
                    enemy.Cheer();
                }
                break;
        }
    }

    // Puts the whole battlefield back as it was at the start, then plays.
    public void Restart()
    {
        picker.CloseMenus();
        spawner.ResetSpawner();
        foreach (Projectile shot in shots.GetComponentsInChildren<Projectile>())
        {
            Destroy(shot.gameObject);
        }
        foreach (BuildPlot plot in plots.GetComponentsInChildren<BuildPlot>())
        {
            plot.Clear();
        }
        bank.ResetBank();
        gate.ResetGate();
        speed = 1f;
        speedText.text = "x2";
        messageText.text = "";
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

    // Normal speed or double: the button shows what pressing it will do.
    public void ToggleSpeed()
    {
        speed = speed > 1f ? 1f : 2f;
        speedText.text = speed > 1f ? "x1" : "x2";
        if (state == GameState.Playing)
        {
            Time.timeScale = speed;
        }
    }

    // A line in the middle of the screen, such as "Wave 3 cleared! +35 gold".
    public void ShowMessage(string message)
    {
        if (messageFade != null)
        {
            StopCoroutine(messageFade);
        }
        messageFade = StartCoroutine(FadeText(message));
    }

    // Shows the text for two seconds, then fades it out over one.
    IEnumerator FadeText(string text)
    {
        messageText.text = text;
        messageText.alpha = 1f;
        yield return new WaitForSeconds(2f);
        for (float t = 0f; t < 1f; t += Time.deltaTime)
        {
            messageText.alpha = 1f - t;
            yield return null;
        }
        messageText.text = "";
    }
}
```

Select `Gate Game`, and fill in its fields:

| Field | Drag in |
| --- | --- |
| **Bank**, **Spawner**, **Picker** | `Gate Game` itself |
| **Gate** | `Gate` |
| **Plots**, **Skeletons**, **Shots** | `Build Plots`, `Skeletons`, `Shots` |
| **Message Text** | `Message Text` |
| **Start Panel**, **Play Button** | `Start Panel`, and its `Play Button` |
| **Pause Button**, **Speed Button**, **Speed Text** | `Pause Button`, `Speed Button`, and its `Label` |
| **Pause Panel** | `Pause Panel` |
| **Win Panel**, **Win Text**, **Play Again Button** | `Win Panel`, its `Win Text`, its `Play Again Button` |
| **Lose Panel**, **Try Again Button** | `Lose Panel`, and its `Try Again Button` |

Read it before you move on:

- `Awake` starts the game in **Start**: the Start panel shows, and nothing moves, because
  nothing is being played.
- `EnterState` shows the state's panel and hides the other three in four lines, then does
  the state's own work. The x2 and pause buttons only show while playing.
- **Play**, **Play Again** and **Try Again** all call `Restart`. On the first press,
  there's nothing to put back, and Restart does it anyway: one method, every time.
- In **Lost**, `spawner.StopWaves()` stops the coroutine, so no new skeleton rises, and
  every skeleton left gets `Cheer()`.
- `ToggleSpeed` remembers the speed even while paused, and only changes the clock while
  playing.

### Do it — the pause menu

Create `Assets/Scripts/PauseMenu.cs`, add it to `Pause Panel`, and fill in **Game**, the
two buttons and the slider:

```csharp:PauseMenu.cs
using UnityEngine;
using UnityEngine.UI;

// The pause panel: Resume, Restart and the volume. Its buttons are connected
// when the panel opens (OnEnable), and disconnected when it closes (OnDisable).
public class PauseMenu : MonoBehaviour
{
    [SerializeField] GateGame game;
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

As in Knight Run, the panel's buttons are connected when the panel opens, and
disconnected when it closes.

### Test it

Press **Play**. While you test, set the bank's **Start Lives** to `2` to lose quickly,
and to `10` again at the end.

- The Start panel shows over a battlefield where nothing moves. Click **Play**.
- Build a tower and open its menu, then press **Esc**: the menu closes. Press **Esc**
  again: the Pause panel, and everything stops, arrows in mid-air. **Resume**. Press
  **P**: paused again. Drag the volume.
- **Restart** from the pause: the gold is back to 120, the towers and skeletons are
  gone, the wave is 0, and the Start Wave button waits.
- Let two skeletons reach the gate. On the second blow the gate's doors burst open, every
  skeleton on the road stops and cheers, and the Defeat panel shows. **Try Again**: the
  doors are shut, and the battlefield is new.
- To see Victory without playing ten waves: press **Play**, and before you click the
  start panel's **Play**, set the spawner's **Waves** to `1` in the Inspector. Clear the
  one wave, and read the lives left on the Victory panel. A change made while the game
  runs is undone when you stop it, so the other nine waves come back.

### Challenge

Add a **Give Up** button to the Pause panel that loses the game at once, gate and all.
Which method does it call, and what does it need first? (`Lose` only works while the
game is **Playing**.)

## Chapter 14 — Sound and Light

**Goal:** every bow, throw, stone, bolt, blow and fall gets its sound, and so do the
towers going up and coming down, the waves and the gate. Music plays: `Road` while you
build, `Tension` from wave 8. The sun casts soft shadows, the sky and the ground light
what the sun can't reach, and the camera shows the whole battlefield on any screen, a
wide phone's or a square-ish tablet's.

### Idea — sounds on the events

Each sound plays from an **Audio Source** on the object it belongs to, with
`audioSource.PlayOneShot(clip)`: one source can play many sounds at once. They hang on
moments the scripts already have:

| Sound | Plays in | When |
| --- | --- | --- |
| `Bones` | `Enemy.TakeDamage` | a hit |
| `Crumble` | `Enemy`, entering Dying | a fall |
| `Bow`, `Launch`, `Frost` | `Tower.Release`: each tower's **Shoot Sound** | a shot leaves |
| `StoneHit` | `Projectile.Arrive`: the stone's **Land Sound** | a stone lands |
| `Build` | `Tower.Build` and `Tower.Upgrade` | a tower goes up, or grows |
| `Sell` | `TowerMenu.Sell` | a tower comes down |
| `GateHit`, `GateBreak` | `Gate.TakeHit` | a blow; the last one |
| `WaveStart` | `WaveSpawner`, entering Spawning, through `GateGame.PlaySound` | a wave starts |
| `Win`, `Lose` | `GateGame` | the end |

A stone can't play its own sound from an Audio Source: it destroys itself the moment it
lands, and a destroyed object makes no sound. `AudioSource.PlayClipAtPoint(clip, point)`
makes a short-lived Audio Source of its own, which removes itself when the clip ends.
Chapter 9's `Projectile` already does that.

> **Note:** a sound played at a point is a **3D sound**: it gets quieter the further it
> is from the **Audio Listener**, which is on the camera, nearly 30 units from the
> battlefield. Played where the stone lands, it would be a whisper. That's why
> `Projectile` plays it at the camera's own position. Every Audio Source you add
> yourself starts as a **2D** sound (**Spatial Blend** `0`): the same volume wherever it
> is.

The music starts on **Play**, not as the scene loads: a web browser lets a page make
sound only after the player has clicked something.

### Idea — light from the sky

The sun, a **Directional Light**, lights everything from one direction, and casts
shadows: the towers' and the trees' shadows lie on the grass, to the north-east. Where
the sun doesn't reach, the sides of things facing away from it, the scene would be dark.
**Ambient light** fills them in, and a **Gradient** of three colours does it the way the
outdoors does: a pale blue from the sky above, a grey-blue from the horizon, and a
green-brown bounced up from the ground below.

| Light | Setting | Value |
| --- | --- | --- |
| **Directional Light** | **Color**, **Intensity** | `#FFF4E0`, a warm white; `1.3` |
| | **Shadow Type** | **Soft Shadows** |
| **Environment Lighting** (the Lighting window) | **Source** | **Gradient** |
| | **Sky Color**, **Equator Color**, **Ground Color** | `#C9E4F5`, `#A8B9C4`, `#5E6B5A` |

### Idea — a camera for every screen

The camera's **Field of View** is the angle it sees from top to bottom. On a screen of
another shape, the same angle shows more or less from side to side: a 20:9 phone sees
more of the sides, and a 4:3 tablet less, and the battlefield's edges, with plots and
road on them, fall off the screen.

A **Physical Camera** works like a real one, with a **sensor** and a lens's **focal
length**. Its **Gate Fit** says what to do when the screen isn't the sensor's shape:
**Overscan** shows the whole sensor's picture, and a little more above and below, or at
the sides. Give it a 16:9 sensor, the shape the battlefield was framed for, and every
screen sees the whole battlefield:

| Setting | Value | Why |
| --- | --- | --- |
| **Physical Camera** | on | |
| **Sensor Type**, **Sensor Size** | **Custom**, `36 × 20.25` | a 16:9 sensor |
| **Focal Length** | `34.2` | the same view as Chapter 1's Field of View `33`, on a 16:9 screen |
| **Gate Fit** | **Overscan** | the whole frame, on any screen |

### Do it — the Audio Sources

Add an **Audio Source**, with **Play On Awake** unticked, to the four skeleton prefabs,
the three tower prefabs (on their roots) and `Gate`. Give `Gate Game` two: the first for
sounds, and the second for music, with **Loop** ticked and **Volume** `0.5`.

> **Tip:** to put one particular Audio Source in a field, drag it by its title in the
> Inspector onto the field. Dragging the GameObject picks its first Audio Source.

### Do it — the scripts, with sound

These are the last versions of six scripts. Replace each one, and fill in its new fields
from `Assets/Audio`: the prefabs' fields in the prefabs, so every copy gets them.

`Enemy`: **Hit Sound** `Bones`, **Death Sound** `Crumble`.

```csharp:Enemy.cs
using System.Collections;
using UnityEngine;

// A skeleton on the road, run as a state machine. The code decides what it
// does; its Animator, the Skeleton controller, only shows the body: rising
// from the ground, walking, chopping at the gate, falling. Every kind of
// skeleton is this one script, with its own numbers in the Inspector.
[RequireComponent(typeof(Animator))]
public class Enemy : MonoBehaviour
{
    public enum State { Rising, Walking, Slowed, Dying, AtGate }

    static readonly int WalkSpeedHash = Animator.StringToHash("WalkSpeed");
    static readonly int DieHash = Animator.StringToHash("Die");
    static readonly int AttackHash = Animator.StringToHash("Attack");
    static readonly int CheerHash = Animator.StringToHash("Cheer");

    [SerializeField] int maxHealth = 6;
    [SerializeField] float speed = 1.5f;            // units a second, on the road
    [SerializeField] int bounty = 5;                // gold, for the tower that finishes it
    [SerializeField] int livesCost = 1;             // what it costs the gate
    [SerializeField] float turnSpeed = 540f;        // degrees a second
    [SerializeField] EnemyHealthBar healthBar;
    [SerializeField] GameObject frost;              // the frost that shows while it's slowed
    [SerializeField] Color frostTint = new Color(0.62f, 0.85f, 1f);
    [SerializeField] AudioClip hitSound;
    [SerializeField] AudioClip deathSound;

    GateGame game;
    WaypointPath path;
    Animator animator;
    Collider bodyCollider;
    AudioSource audioSource;
    Renderer[] bodyRenderers;
    State state;
    int health;
    int nextPoint;
    float distanceTravelled;
    float slowFactor = 1f;
    float slowUntil;
    bool killedByTower;
    Color tint = Color.white;
    Coroutine flash;

    // How far along the road it has walked: the towers aim at the biggest.
    public float DistanceTravelled
    {
        get { return distanceTravelled; }
    }

    // Towers only shoot at a skeleton that's up and walking.
    public bool IsTargetable
    {
        get { return state == State.Walking || state == State.Slowed; }
    }

    void Awake()
    {
        animator = GetComponent<Animator>();
        bodyCollider = GetComponent<Collider>();
        audioSource = GetComponent<AudioSource>();
        bodyRenderers = GetComponentsInChildren<SkinnedMeshRenderer>();
    }

    // The spawner calls this as soon as it makes the skeleton: a prefab can't
    // point at things in the scene, so it's handed them here.
    public void Begin(GateGame owner, WaypointPath road)
    {
        game = owner;
        path = road;
        health = maxHealth;
        nextPoint = 1;
        distanceTravelled = 0f;
        transform.position = path.GetPoint(0);
        transform.rotation = Quaternion.LookRotation(path.GetPoint(1) - path.GetPoint(0));
        EnterState(State.Rising);
    }

    void Update()
    {
        // Before Begin, while paused (the clock stops), and after the end, it waits.
        if (game == null || !game.IsPlaying)
        {
            return;
        }

        switch (state)
        {
            case State.Rising:
                break;                  // waits for the OnRisen Animation Event
            case State.Walking:
                Walk(1f);
                break;
            case State.Slowed:
                Walk(slowFactor);
                if (Time.time >= slowUntil)
                {
                    EnterState(State.Walking);
                }
                break;
            case State.Dying:
                break;                  // waits for OnDeathFinished
            case State.AtGate:
                break;                  // waits for OnGateHit
        }
    }

    // The one place the state changes. The enter step runs once, as the
    // skeleton arrives in its new state.
    void EnterState(State next)
    {
        state = next;

        switch (state)
        {
            case State.Rising:
                bodyCollider.enabled = false;           // the towers can't see it yet
                healthBar.Hide();
                break;
            case State.Walking:
                bodyCollider.enabled = true;
                slowFactor = 1f;
                animator.SetFloat(WalkSpeedHash, 1f);
                frost.SetActive(false);
                SetTint(Color.white);
                break;
            case State.Slowed:
                animator.SetFloat(WalkSpeedHash, slowFactor);   // the Walk clip plays slower too
                frost.SetActive(true);
                SetTint(frostTint);
                break;
            case State.Dying:
                bodyCollider.enabled = false;
                healthBar.Hide();
                frost.SetActive(false);
                animator.SetTrigger(DieHash);
                audioSource.PlayOneShot(deathSound);
                break;
            case State.AtGate:
                bodyCollider.enabled = false;
                animator.SetTrigger(AttackHash);
                break;
        }
    }

    // Walks towards the next point on the road, turning to face it. factor is
    // 1 at full speed, 0.5 when slowed.
    void Walk(float factor)
    {
        Vector3 target = path.GetPoint(nextPoint);
        Vector3 before = transform.position;
        transform.position = Vector3.MoveTowards(before, target, speed * factor * Time.deltaTime);
        distanceTravelled += Vector3.Distance(before, transform.position);

        Vector3 toTarget = target - transform.position;
        if (toTarget.sqrMagnitude > 0.0001f)
        {
            Quaternion facing = Quaternion.LookRotation(toTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, facing, turnSpeed * Time.deltaTime);
        }

        if (transform.position == target)
        {
            nextPoint++;
            if (nextPoint >= path.Count)
            {
                EnterState(State.AtGate);
            }
        }
    }

    // A tower's shot hit it.
    public void TakeDamage(int damage)
    {
        if (!IsTargetable)
        {
            return;
        }
        health -= damage;
        healthBar.Show((float)health / maxHealth);
        audioSource.PlayOneShot(hitSound);
        if (flash != null)
        {
            StopCoroutine(flash);
        }
        flash = StartCoroutine(FlashRed());
        if (health <= 0)
        {
            killedByTower = true;
            EnterState(State.Dying);
        }
    }

    // A frost bolt hit it: slower for a while. Two bolts keep the slower
    // speed and the later end.
    public void Slow(float factor, float seconds)
    {
        if (!IsTargetable)
        {
            return;
        }
        slowFactor = state == State.Slowed ? Mathf.Min(slowFactor, factor) : factor;
        slowUntil = Mathf.Max(slowUntil, Time.time + seconds);
        EnterState(State.Slowed);
    }

    // The gate has fallen: whoever is still standing celebrates.
    public void Cheer()
    {
        if (state != State.Dying)
        {
            animator.SetTrigger(CheerHash);
        }
    }

    // Animation Event: the end of the Rise clip, once it's out of the ground.
    public void OnRisen()
    {
        if (state == State.Rising)
        {
            EnterState(State.Walking);
        }
    }

    // Animation Event: the chop's frame, as the blade hits the gate.
    public void OnGateHit()
    {
        if (state != State.AtGate)
        {
            return;
        }
        game.Gate.TakeHit(livesCost);
        killedByTower = false;          // no bounty for this one
        EnterState(State.Dying);
    }

    // Animation Event: the end of the Die clip.
    public void OnDeathFinished()
    {
        if (killedByTower)
        {
            game.Bank.Earn(bounty);
        }
        Destroy(gameObject);
    }

    // An Animator has one layer at Level 3, so a hit can't play a clip without
    // stopping the walk. The hit shows as a red flash instead, for a moment.
    IEnumerator FlashRed()
    {
        SetColour(Color.red);
        yield return new WaitForSeconds(0.08f);
        SetColour(tint);
        flash = null;
    }

    void SetTint(Color colour)
    {
        tint = colour;
        SetColour(colour);
    }

    void SetColour(Color colour)
    {
        foreach (Renderer part in bodyRenderers)
        {
            part.material.color = colour;
        }
    }
}
```

`Tower`: **Shoot Sound** `Bow` on the Arrow tower, `Launch` on the Catapult tower and
`Frost` on the Frost tower; **Build Sound** `Build` on all three.

```csharp:Tower.cs
using UnityEngine;

// A tower on a plot, run as a state machine: Idle with nothing in range, Aim
// at the skeleton furthest along the road, Fire, then Reload. It has two
// Animators: its crew's (the archer, the mage or the catapult), driven with
// Aiming and Fire, and its own, whose Level switches the tower's looks. One
// script serves all three kinds: what differs is in the Inspector, and in
// the shot each one fires.
public class Tower : MonoBehaviour
{
    public enum State { Idle, Aim, Fire, Reload }

    static readonly int AimingHash = Animator.StringToHash("Aiming");
    static readonly int FireHash = Animator.StringToHash("Fire");
    static readonly int LevelHash = Animator.StringToHash("Level");

    [SerializeField] string title = "Arrow Tower";
    [SerializeField] TowerLevel[] levels;       // Levels 1, 2 and 3
    [SerializeField] Animator crew;
    [SerializeField] Transform turret;          // what turns to face the target
    [SerializeField] Transform muzzle;          // where its shots start
    [SerializeField] Projectile shotPrefab;
    [SerializeField] LayerMask enemyMask;
    [SerializeField] float turnSpeed = 360f;    // degrees a second
    [SerializeField] AudioClip shootSound;
    [SerializeField] AudioClip buildSound;

    GateGame game;
    Transform shotGroup;
    Animator body;
    AudioSource audioSource;
    State state;
    int level;
    int spent;
    Enemy target;
    float stateStartTime;

    public string Title
    {
        get { return title; }
    }

    public int Level
    {
        get { return level; }
    }

    public TowerLevel Current
    {
        get { return levels[level - 1]; }
    }

    public int BuildCost
    {
        get { return levels[0].Cost; }
    }

    public bool CanUpgrade
    {
        get { return level < levels.Length; }
    }

    public int UpgradeCost
    {
        get { return CanUpgrade ? levels[level].Cost : 0; }
    }

    // Selling gives back 60% of everything spent on the tower.
    public int SellValue
    {
        get { return Mathf.RoundToInt(spent * 0.6f); }
    }

    void Awake()
    {
        body = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // The plot calls this as soon as it makes the tower.
    public void Build(GateGame owner, Transform shots)
    {
        game = owner;
        shotGroup = shots;
        level = 1;
        spent = levels[0].Cost;
        body.SetInteger(LevelHash, level);
        audioSource.PlayOneShot(buildSound);
        EnterState(State.Idle);
    }

    public void Upgrade()
    {
        if (!CanUpgrade)
        {
            return;
        }
        level++;
        spent += levels[level - 1].Cost;
        body.SetInteger(LevelHash, level);      // the Level clip adds a storey, or the flags
        audioSource.PlayOneShot(buildSound);
    }

    void Update()
    {
        if (game == null || !game.IsPlaying)
        {
            return;
        }

        switch (state)
        {
            case State.Idle:
                target = FindTarget();
                if (target != null)
                {
                    EnterState(State.Aim);
                }
                break;
            case State.Aim:
                if (!InRange(target))
                {
                    target = FindTarget();
                }
                if (target == null)
                {
                    EnterState(State.Idle);
                }
                else if (TurnTowards(target))
                {
                    EnterState(State.Fire);
                }
                break;
            case State.Fire:
                if (InRange(target))
                {
                    TurnTowards(target);
                }
                // The shot leaves on the crew's OnRelease event. If it never
                // comes (the crew was interrupted), aim again.
                if (Time.time - stateStartTime > 2f)
                {
                    EnterState(State.Aim);
                }
                break;
            case State.Reload:
                if (Time.time - stateStartTime >= Current.ReloadSeconds)
                {
                    EnterState(State.Aim);
                }
                break;
        }
    }

    void EnterState(State next)
    {
        state = next;
        stateStartTime = Time.time;

        switch (state)
        {
            case State.Idle:
                target = null;
                crew.SetBool(AimingHash, false);
                break;
            case State.Aim:
                crew.SetBool(AimingHash, true);
                break;
            case State.Fire:
                crew.SetTrigger(FireHash);
                break;
            case State.Reload:
                break;
        }
    }

    // TowerCrew calls this on the crew's OnRelease Animation Event: the
    // frame the arrow leaves the bow, the bolt the staff, the stone the arm.
    public void Release()
    {
        if (state != State.Fire)
        {
            return;
        }
        if (InRange(target))
        {
            Projectile shot = Instantiate(shotPrefab, muzzle.position, Quaternion.identity, shotGroup);
            shot.Launch(target, Current, enemyMask);
            audioSource.PlayOneShot(shootSound);
        }
        EnterState(State.Reload);
    }

    // The skeleton furthest along the road, within range: the one closest to
    // the gate. Physics.OverlapSphere finds every collider on the Enemy layer
    // inside the circle; the loop keeps the best.
    Enemy FindTarget()
    {
        Enemy best = null;
        foreach (Collider found in Physics.OverlapSphere(transform.position, Current.Range, enemyMask))
        {
            if (found.TryGetComponent(out Enemy enemy) && enemy.IsTargetable &&
                (best == null || enemy.DistanceTravelled > best.DistanceTravelled))
            {
                best = enemy;
            }
        }
        return best;
    }

    bool InRange(Enemy enemy)
    {
        if (enemy == null || !enemy.IsTargetable)
        {
            return false;
        }
        Vector3 offset = enemy.transform.position - transform.position;
        offset.y = 0f;
        return offset.magnitude <= Current.Range;
    }

    // Turns the turret a little towards the enemy, on the ground only, and
    // answers true once it's facing it.
    bool TurnTowards(Enemy enemy)
    {
        Vector3 toEnemy = enemy.transform.position - turret.position;
        toEnemy.y = 0f;
        Quaternion facing = Quaternion.LookRotation(toEnemy);
        turret.rotation = Quaternion.RotateTowards(turret.rotation, facing, turnSpeed * Time.deltaTime);
        return Quaternion.Angle(turret.rotation, facing) < 5f;
    }
}
```

`Gate`: **Hit Sound** `GateHit`, **Break Sound** `GateBreak`.

```csharp:Gate.cs
using UnityEngine;

// The castle gate. Every skeleton that reaches it costs lives: the doors
// shudder (the Hit trigger), and when the last life goes they burst open
// (the Broken Bool) and the game is lost.
public class Gate : MonoBehaviour
{
    static readonly int HitHash = Animator.StringToHash("Hit");
    static readonly int BrokenHash = Animator.StringToHash("Broken");

    [SerializeField] GateGame game;
    [SerializeField] Bank bank;
    [SerializeField] AudioClip hitSound;
    [SerializeField] AudioClip breakSound;

    Animator animator;
    AudioSource audioSource;

    void Awake()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    public void TakeHit(int lives)
    {
        if (bank.Lives <= 0)
        {
            return;
        }
        bank.LoseLives(lives);
        if (bank.Lives > 0)
        {
            animator.SetTrigger(HitHash);
            audioSource.PlayOneShot(hitSound);
        }
        else
        {
            animator.SetBool(BrokenHash, true);
            audioSource.PlayOneShot(breakSound);
            game.Lose();
        }
    }

    // Doors shut again: on Restart.
    public void ResetGate()
    {
        animator.SetBool(BrokenHash, false);
        animator.Rebind();
    }
}
```

`TowerMenu`: **Audio Source** `Gate Game`'s first Audio Source, **Sell Sound** `Sell`.

```csharp:TowerMenu.cs
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The tower menu, over a tower that was tapped: its name, its level as
// stars, Upgrade and Sell. While it's open, the tower's range shows as a
// ring on the ground.
public class TowerMenu : MonoBehaviour
{
    [SerializeField] Bank bank;
    [SerializeField] RangeRing rangeRing;
    [SerializeField] TMP_Text titleText;
    [SerializeField] Image[] stars;             // three, one per level
    [SerializeField] Button upgradeButton;
    [SerializeField] TMP_Text upgradeText;
    [SerializeField] Button sellButton;
    [SerializeField] TMP_Text sellText;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip sellSound;
    [SerializeField] float heightAbovePlot = 3.2f;

    BuildPlot plot;
    Camera cam;

    public bool IsOpen
    {
        get { return gameObject.activeSelf; }
    }

    void Awake()
    {
        cam = Camera.main;
    }

    void OnEnable()
    {
        upgradeButton.onClick.AddListener(Upgrade);
        sellButton.onClick.AddListener(Sell);
    }

    void OnDisable()
    {
        upgradeButton.onClick.RemoveListener(Upgrade);
        sellButton.onClick.RemoveListener(Sell);
    }

    void Update()
    {
        if (plot == null)
        {
            return;
        }
        PlaceOver(plot.transform.position);
        Tower tower = plot.Tower;
        upgradeButton.interactable = tower.CanUpgrade && bank.CanAfford(tower.UpgradeCost);
    }

    public void Open(BuildPlot target)
    {
        plot = target;
        gameObject.SetActive(true);
        Refresh();
        Update();
    }

    public void Close()
    {
        plot = null;
        rangeRing.Hide();
        gameObject.SetActive(false);
    }

    void Refresh()
    {
        Tower tower = plot.Tower;
        titleText.text = tower.Title;
        for (int i = 0; i < stars.Length; i++)
        {
            stars[i].enabled = i < tower.Level;
        }
        upgradeText.text = tower.CanUpgrade ? tower.UpgradeCost.ToString() : "Max";
        sellText.text = $"Sell {tower.SellValue}";
        rangeRing.Show(tower.transform.position, tower.Current.Range);
    }

    void Upgrade()
    {
        Tower tower = plot.Tower;
        if (tower.CanUpgrade && bank.Spend(tower.UpgradeCost))
        {
            tower.Upgrade();
            Refresh();
        }
    }

    void Sell()
    {
        bank.Earn(plot.Tower.SellValue);
        audioSource.PlayOneShot(sellSound);
        plot.Clear();
        Close();
    }

    void PlaceOver(Vector3 worldPoint)
    {
        Vector3 screenPoint = cam.WorldToScreenPoint(worldPoint + Vector3.up * heightAbovePlot);
        RectTransform rect = (RectTransform)transform;
        Vector2 size = rect.rect.size * rect.lossyScale;
        screenPoint.x = Mathf.Clamp(screenPoint.x, size.x / 2f, Screen.width - size.x / 2f);
        screenPoint.y = Mathf.Clamp(screenPoint.y, 0f, Screen.height - size.y);
        rect.position = screenPoint;
    }
}
```

`GateGame`: **Sound Source** and **Music Source** (the first and second Audio Sources),
**Build Music** `Road`, **Battle Music** `Tension`, **Battle Music From Wave** `8`, **Win
Sound** `Win`, **Lose Sound** `Lose`.

```csharp:GateGame.cs
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

// Runs the game as a state machine: Start, Playing, Paused, Won and Lost. It
// keeps the game's speed (normal or double), shows messages, plays the music,
// and puts the whole battlefield back on Restart.
public class GateGame : MonoBehaviour
{
    public enum GameState { Start, Playing, Paused, Won, Lost }

    [SerializeField] Bank bank;
    [SerializeField] Gate gate;
    [SerializeField] WaveSpawner spawner;
    [SerializeField] Picker picker;
    [SerializeField] Transform plots;
    [SerializeField] Transform skeletons;
    [SerializeField] Transform shots;
    [SerializeField] TMP_Text messageText;
    [SerializeField] GameObject startPanel;
    [SerializeField] Button playButton;
    [SerializeField] Button pauseButton;
    [SerializeField] Button speedButton;
    [SerializeField] TMP_Text speedText;
    [SerializeField] GameObject pausePanel;
    [SerializeField] GameObject winPanel;
    [SerializeField] TMP_Text winText;
    [SerializeField] Button playAgainButton;
    [SerializeField] GameObject losePanel;
    [SerializeField] Button tryAgainButton;
    [SerializeField] AudioSource soundSource;
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioClip buildMusic;
    [SerializeField] AudioClip battleMusic;
    [SerializeField] int battleMusicFromWave = 8;
    [SerializeField] AudioClip winSound;
    [SerializeField] AudioClip loseSound;

    GameState state;
    float speed = 1f;
    Coroutine messageFade;

    public bool IsPlaying
    {
        get { return state == GameState.Playing; }
    }

    public Bank Bank
    {
        get { return bank; }
    }

    public Gate Gate
    {
        get { return gate; }
    }

    void OnEnable()
    {
        playButton.onClick.AddListener(Restart);
        pauseButton.onClick.AddListener(Pause);
        speedButton.onClick.AddListener(ToggleSpeed);
        playAgainButton.onClick.AddListener(Restart);
        tryAgainButton.onClick.AddListener(Restart);
    }

    void OnDisable()
    {
        playButton.onClick.RemoveListener(Restart);
        pauseButton.onClick.RemoveListener(Pause);
        speedButton.onClick.RemoveListener(ToggleSpeed);
        playAgainButton.onClick.RemoveListener(Restart);
        tryAgainButton.onClick.RemoveListener(Restart);
    }

    void Awake()
    {
        messageText.text = "";
        bank.ResetBank();
        EnterState(GameState.Start);
    }

    void Update()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard == null)
        {
            return;
        }

        switch (state)
        {
            case GameState.Start:
                break;
            case GameState.Playing:
                // Esc closes a menu if one is open; otherwise it pauses, as P does.
                if (keyboard.escapeKey.wasPressedThisFrame && picker.HasMenuOpen)
                {
                    picker.CloseMenus();
                }
                else if (keyboard.escapeKey.wasPressedThisFrame || keyboard.pKey.wasPressedThisFrame)
                {
                    Pause();
                }
                else if (keyboard.fKey.wasPressedThisFrame)
                {
                    ToggleSpeed();
                }
                break;
            case GameState.Paused:
                if (keyboard.escapeKey.wasPressedThisFrame || keyboard.pKey.wasPressedThisFrame)
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
        speedButton.gameObject.SetActive(state == GameState.Playing);

        switch (state)
        {
            case GameState.Start:
                Time.timeScale = 1f;
                break;
            case GameState.Playing:
                Time.timeScale = speed;         // 1, or 2 after the ×2 button
                break;
            case GameState.Paused:
                Time.timeScale = 0f;            // Animators, coroutines and timers all stop
                picker.CloseMenus();
                break;
            case GameState.Won:
                Time.timeScale = 1f;
                winText.text = $"The gate held!\n\nLives left: {bank.Lives}";
                picker.CloseMenus();
                musicSource.Stop();
                soundSource.PlayOneShot(winSound);
                break;
            case GameState.Lost:
                Time.timeScale = 1f;
                picker.CloseMenus();
                spawner.StopWaves();
                foreach (Enemy enemy in skeletons.GetComponentsInChildren<Enemy>())
                {
                    enemy.Cheer();
                }
                musicSource.Stop();
                soundSource.PlayOneShot(loseSound);
                break;
        }
    }

    // Puts the whole battlefield back as it was at the start, then plays.
    public void Restart()
    {
        picker.CloseMenus();
        spawner.ResetSpawner();
        foreach (Projectile shot in shots.GetComponentsInChildren<Projectile>())
        {
            Destroy(shot.gameObject);
        }
        foreach (BuildPlot plot in plots.GetComponentsInChildren<BuildPlot>())
        {
            plot.Clear();
        }
        bank.ResetBank();
        gate.ResetGate();
        speed = 1f;
        speedText.text = "x2";
        messageText.text = "";
        PlayMusic(buildMusic);
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

    // Normal speed or double: the button shows what pressing it will do.
    public void ToggleSpeed()
    {
        speed = speed > 1f ? 1f : 2f;
        speedText.text = speed > 1f ? "x1" : "x2";
        if (state == GameState.Playing)
        {
            Time.timeScale = speed;
        }
    }

    // The spawner tells the game when a wave starts: the late waves get the
    // battle music.
    public void WaveStarted(int waveNumber)
    {
        if (waveNumber >= battleMusicFromWave)
        {
            PlayMusic(battleMusic);
        }
    }

    public void PlaySound(AudioClip clip)
    {
        soundSource.PlayOneShot(clip);
    }

    // A line in the middle of the screen, such as "Wave 3 cleared! +35 gold".
    public void ShowMessage(string message)
    {
        if (messageFade != null)
        {
            StopCoroutine(messageFade);
        }
        messageFade = StartCoroutine(FadeText(message));
    }

    // Shows the text for two seconds, then fades it out over one.
    IEnumerator FadeText(string text)
    {
        messageText.text = text;
        messageText.alpha = 1f;
        yield return new WaitForSeconds(2f);
        for (float t = 0f; t < 1f; t += Time.deltaTime)
        {
            messageText.alpha = 1f - t;
            yield return null;
        }
        messageText.text = "";
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
}
```

`PlayMusic` does nothing if that music is already playing: Restart, from the pause or
after a defeat, doesn't start the road's music over if it's already on.

`WaveSpawner`: **Wave Sound** `WaveStart`.

```csharp:WaveSpawner.cs
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

// Sends the waves, run as a state machine: Waiting for the next wave,
// Spawning its skeletons, In Progress while they're on the road, and Cleared
// when none are left. Each wave is a Wave in the array, filled in in the
// Inspector.
public class WaveSpawner : MonoBehaviour
{
    public enum State { Waiting, Spawning, InProgress, Cleared }

    [SerializeField] GateGame game;
    [SerializeField] Bank bank;
    [SerializeField] WaypointPath path;
    [SerializeField] Transform skeletonGroup;     // every skeleton goes here, so Restart finds them
    [SerializeField] Wave[] waves;
    [SerializeField] float countdownSeconds = 15f;
    [SerializeField] int bonusBase = 20;          // a cleared wave pays bonusBase + bonusPerWave × its number
    [SerializeField] int bonusPerWave = 5;
    [SerializeField] Button startWaveButton;
    [SerializeField] TMP_Text countdownText;
    [SerializeField] TMP_Text waveText;
    [SerializeField] AudioClip waveSound;

    State state;
    int waveIndex;              // the next wave to send: 0 is wave 1
    float countdown;

    void OnEnable()
    {
        startWaveButton.onClick.AddListener(StartNextWave);
    }

    void OnDisable()
    {
        startWaveButton.onClick.RemoveListener(StartNextWave);
    }

    void Update()
    {
        if (!game.IsPlaying)
        {
            return;
        }

        switch (state)
        {
            case State.Waiting:
                UpdateWaiting();
                break;
            case State.Spawning:
                break;                  // the SpawnWave coroutine is at work
            case State.InProgress:
                if (skeletonGroup.childCount == 0)
                {
                    EnterState(State.Cleared);
                }
                break;
            case State.Cleared:
                break;
        }
    }

    void EnterState(State next)
    {
        state = next;
        startWaveButton.gameObject.SetActive(state == State.Waiting);

        switch (state)
        {
            case State.Waiting:
                countdown = countdownSeconds;
                countdownText.text = waveIndex == 0 ? "Build your towers, then start the first wave" : "";
                break;
            case State.Spawning:
                countdownText.text = "";
                waveText.text = $"Wave {waveIndex + 1} / {waves.Length}";
                game.ShowMessage(waves[waveIndex].Title);
                game.WaveStarted(waveIndex + 1);
                game.PlaySound(waveSound);
                StartCoroutine(SpawnWave(waves[waveIndex]));
                break;
            case State.InProgress:
                break;
            case State.Cleared:
                int bonus = bonusBase + bonusPerWave * (waveIndex + 1);
                bank.Earn(bonus);
                waveIndex++;
                if (waveIndex >= waves.Length)
                {
                    game.Win();
                }
                else
                {
                    game.ShowMessage($"Wave {waveIndex} cleared! +{bonus} gold");
                    EnterState(State.Waiting);
                }
                break;
        }
    }

    // Wave 1 waits for the button; after that, the countdown starts the next
    // wave by itself, unless the player is quicker.
    void UpdateWaiting()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard != null && keyboard.spaceKey.wasPressedThisFrame)
        {
            StartNextWave();
            return;
        }
        if (waveIndex == 0)
        {
            return;
        }
        countdown -= Time.deltaTime;
        countdownText.text = $"Next wave in {Mathf.CeilToInt(countdown)}";
        if (countdown <= 0f)
        {
            StartNextWave();
        }
    }

    public void StartNextWave()
    {
        if (state == State.Waiting && game.IsPlaying)
        {
            EnterState(State.Spawning);
        }
    }

    // A coroutine: one skeleton, a wait, the next, group after group.
    IEnumerator SpawnWave(Wave wave)
    {
        foreach (SpawnGroup group in wave.Groups)
        {
            for (int i = 0; i < group.Count; i++)
            {
                Enemy enemy = Instantiate(group.EnemyPrefab, path.GetPoint(0), Quaternion.identity, skeletonGroup);
                enemy.Begin(game, path);
                yield return new WaitForSeconds(group.Gap);
            }
        }
        EnterState(State.InProgress);
    }

    // The gate fell: no more skeletons.
    public void StopWaves()
    {
        StopAllCoroutines();
    }

    // Back to before wave 1: on Restart.
    public void ResetSpawner()
    {
        StopAllCoroutines();
        foreach (Enemy enemy in skeletonGroup.GetComponentsInChildren<Enemy>())
        {
            Destroy(enemy.gameObject);
        }
        waveIndex = 0;
        waveText.text = $"Wave 0 / {waves.Length}";
        EnterState(State.Waiting);
    }
}
```

Last, open the `Stone` prefab, and set its **Land Sound** to `StoneHit`.

### Do it — the light

1. Select **Directional Light**. Set its **Color** to `#FFF4E0`, its **Intensity** to
   `1.3`, and under **Shadows**, **Shadow Type** to **Soft Shadows**.
2. **Window → Rendering → Lighting**, and open its **Environment** tab. Under
   **Environment Lighting**, set **Source** to **Gradient**, and the three colours from
   the table in *Light from the sky*.

### Do it — the camera

Select **Main Camera**. In the **Camera**'s **Projection**, tick **Physical Camera**, and
set the four settings in the table in *A camera for every screen*. The view in the Game
view at **Full HD** doesn't change.

### Test it

1. Press **Play**, and click **Play**: the road's music starts. Build towers, and play a
   few waves: every shot, hit, fall, blow and wave has its sound, and wave 8 brings in
   `Tension`. Lose on purpose: the music stops, the gate breaks with a crash, and the lose
   sound plays.
2. Look at the battlefield in the light: the towers and trees cast soft shadows towards
   the north-east, and the shady sides of the castle are blue-grey, not black.
3. In the Game view's size menu, choose **4:3**, then add a phone's shape with **+**:
   **Aspect Ratio**, `20 : 9`. On each, the whole battlefield shows, from the ruins to
   the gate, with a little more dark around it where the screen is a different shape.
   Turn **Physical Camera** off for a moment, and look at 4:3 again: the edges are cut
   off. Turn it back on.

### Challenge

Give every skeleton's footsteps a sound, with an Animation Event `OnFootstep` on the walk
clips, and a method in `Enemy` that plays one, quietly. Try it with a wave of ten Rogues:
how loud is a whole wave of footsteps? A game designer would keep only the boss's.

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
an Override Controller, a layer mask or a reference is wrong, go straight to the cause, and
use a breakpoint to watch a tower make up its mind.

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

1. In `Tower`, change the first hash's name to `"aiming"`, with a small `a`:

   ```csharp
   static readonly int AimingHash = Animator.StringToHash("aiming");
   ```

2. Play, click **Play**, and build an Arrow tower. At once, a yellow warning:

   ```
   Parameter 'Hash 1084884419' does not exist.
   ```

3. Click it, and read the stack trace under it from the top: first Unity's own
   `UnityEngine.Animator:SetBool (int,bool)`, then your code: `Tower:EnterState
   (Tower/State)`, line 164, called by `Tower:Build`, line 89, called by
   `BuildPlot:Build`, called by `BuildMenu:Build`, called by `BuildMenu:BuildArrow`:
   the button you clicked. A hash is only a number, so Unity can't say which name is
   wrong (C# 4); line 164 sets `AimingHash`, and `AimingHash` comes from the
   line you changed.
4. Start a wave and watch the tower: the archer turns to face each skeleton, and never
   shoots. With no `Aiming`, the crew's Animator never leaves Idle, and there's no arrow
   from Idle to Shoot, so the release frame never comes. Put the capital `A` back.

### Do it — the wrong call

1. In `Tower.Upgrade`, change `body.SetInteger(LevelHash, level);` to:

   ```csharp
   body.SetFloat(LevelHash, level);
   ```

2. Play, build a tower, and upgrade it: another warning,

   ```
   Parameter type 'Hash 1529602839' does not match.
   ```

3. `Level` is an **Int** in the `Tower` controller, so `SetFloat` can't change it. The
   tower menu shows two stars and the wider ring: the code's numbers changed. The tower
   doesn't grow: the Animator's didn't. Put `SetInteger` back.

### Do it — an event with no receiver

1. In `TowerCrew`, rename `OnRelease` to `OnLoose`.
2. Play, build an Arrow tower, and start a wave. A red error, once a shot:

   ```
   'Ranger' AnimationEvent 'OnRelease' on animation 'Ranged_Bow_Release' has no receiver! Are you missing a component?
   ```

3. Read it from the start: the GameObject, `Ranger`; the event, `OnRelease`; the clip,
   `Ranged_Bow_Release`. The clip still calls `OnRelease`, and no script on `Ranger` has a
   method by that name any more (C# 5). The archer draws and lets go, and
   no arrow leaves. Rename the method back.
4. Now break it the other way: open the `Arrow Tower` prefab, remove `TowerCrew` from
   `Ranger`, and add it to `Arrow Tower` instead, with its **Tower** filled in. The same
   error: the method exists, on the tower, but an event only looks on the Animator's own
   GameObject. That's the reason `TowerCrew` exists. Put it back on `Ranger`.

### Do it — an empty slot in an Override Controller

1. Select `Rogue Override`, and clear the **Override** slot beside `Skeletons_Walking`.
2. Play, and send wave 3: the Rogues walk with the Minion's walk, at a Rogue's speed,
   their feet sliding along the road.
3. An empty slot plays the base controller's own clip. No message at all: the Animator
   did exactly what it was told. Put `Running_A` back in the slot.

### Do it — a mask with nothing in it

1. Open the `Arrow Tower` prefab, and set its `Tower`'s **Enemy Mask** to **Nothing**.
2. Play, build one, and start a wave: the archer stands idle, and the skeletons walk past.
3. `Physics.OverlapSphere` looks only on the mask's layers, and the mask has none, so it
   never finds a skeleton. No message. Set it back to **Enemy**.

### Do it — an empty field

1. Select `Gate Game`, and empty the bank's **Gold Text**: click it, and press **Delete**
   or **Backspace**. It says **None (TMP_Text)**.
2. Play. No Start panel, no **Play** button: the battlefield sits there, and nothing
   happens. A red error, once:

   ```
   NullReferenceException: Object reference not set to an instance of an object
   Bank.UpdateText () (at Assets/Scripts/Bank.cs:55)
   Bank.ResetBank () (at Assets/Scripts/Bank.cs:50)
   GateGame.Awake () (at Assets/Scripts/GateGame.cs:81)
   ```

   A plain `NullReferenceException`, not the friendlier message an empty `Transform`
   gets: `TMP_Text` is a script's type, not one of Unity's own (C# 10).
3. Read the stack trace from the bottom up: `GateGame.Awake` called `Bank.ResetBank`,
   which called `Bank.UpdateText`, where line 55 is `goldText.text = Gold.ToString();`.
   `goldText` is the only thing before a `.` that could be missing. The error stopped
   `Awake` before its last line, `EnterState(GameState.Start)`, so the Start panel never
   opened. And look at `Gate Game` in the Inspector: its `GateGame` has lost its tick.
   When `Awake` throws, Unity switches the script off, so its `OnEnable`, which connects
   the buttons, never runs, and nor does its `Update`. One empty field, and nobody can
   play. Drag `Gold Text` back.

### Do it — a state change that skips its enter step

1. In `Enemy.Walk`, line 167, change `EnterState(State.AtGate);` to `state =
   State.AtGate;`.
2. Play, and let a skeleton reach the gate. It stops in front of the doors, and walks on
   the spot for ever. It never chops; the gate never loses a life.
3. Only `EnterState` sets the `Attack` trigger and switches off the collider. Without the
   trigger, the Attack clip never plays, so its blade never lands, and nothing calls
   `OnGateHit` (C# 7). And because the skeleton never leaves, `Skeletons` is
   never empty, and the wave never ends: the Start Wave button never comes back. Put
   `EnterState(State.AtGate);` back.

### Do it — watch a tower decide, with a breakpoint

1. Open `Tower` in VS Code, and click left of line 157, `state = next;`, the first line
   of `EnterState`: a red dot.
2. **Run and Debug** (**Ctrl + Shift + D** / **Cmd + Shift + D**), choose **Attach to
   Unity**, and press ▶. If Unity asks, choose **Enable debugging for this session**.
3. Play, click **Play**, and build an Arrow tower. The game freezes: hover over `next`,
   **Idle**, and look at the **Call Stack**: `EnterState`, called by `Build`, called by
   `BuildPlot.Build`, called by `BuildMenu.Build` and `BuildArrow`, and under them
   Unity's own code for a button press. Press **F5** to carry on.
4. Start a wave. When a skeleton comes into range, it stops: **Aim**, called by `Update`.
   **F5**: **Fire**, called by `Update`, once the archer faces it.
5. **F5** again: **Reload**, called by `Release`, called by `TowerCrew.OnRelease`. Under
   that, no `Update` at all: none of your code called `OnRelease`. The Animator did, from
   the release frame of the bow's clip.
6. Click the red dot to remove it, press **F5**, and stop debugging with **Shift + F5**.

### Test it

After undoing every break, the game works exactly as before: play a few waves to be sure,
and check that the Console has no errors and no warnings.

### Challenge

Break the game in a way this chapter didn't, and swap with a classmate: each of you must
find and fix the other's bug using only the Console, the Animator window and a breakpoint.
The hardest ones to find give no message at all, like the empty Override slot. (Ideas:
an event moved to 0%, a Bake Into Pose left off, a transition with **Can Transition To
Self** on.)

## Chapter 16 — Ship It

**Goal:** a Web build of Gate Guard, published on itch.io, that plays with the mouse on a
computer, and with a finger on a phone or a tablet.

### Idea

The game is finished; now players need it. As in Levels 1 and 2, a **Web** build runs in
any browser, and itch.io hosts it for free. Every control is a press of the pointer, or a
key that has a button too, so the same link works everywhere: on a phone, a tap is a
click. And since Chapter 14, the camera shows the whole battlefield on a screen of any
shape.

### Do it — the build

1. **File → Build Profiles**. Select **Web** and click **Switch Platform**.
2. In **Scene List**, click **Add Open Scenes** if `Scenes/GateGuard` is missing, and
   untick `Scenes/SampleScene`: a build starts with the first ticked scene, and that must
   be `Scenes/GateGuard`.
3. Open **Player Settings**: set the **Product Name** to `Gate Guard`. Under **Resolution
   and Presentation**, set **Default Canvas Width** to `1280` and **Default Canvas
   Height** to `720`. Under **Publishing Settings**, set **Compression Format** to
   **Disabled**.
4. Click **Build**, create a folder called `Builds/Web`, and wait.

### Do it — publish on itch.io

1. Zip the **contents** of `Builds/Web`, so `index.html` is at the top of the zip.
2. On itch.io, **Upload new project**, **Kind of project: HTML**, upload the zip, and tick
   **This file will be played in the browser**.
3. Set the **Viewport dimensions** to `1280 × 720`, and tick **Mobile friendly**; if
   itch.io asks for an orientation, choose **Landscape**. Save, and open the page.

### Test it

1. On a computer: play with the mouse only. Build, upgrade and sell, start waves with the
   button, play at x2, pause with the button, change the volume, and hold the gate.
2. On a phone: open the same page, turn the phone sideways, and press **Play**. Tap a plot
   to build, tap a tower to upgrade it, tap the grass to close a menu. Is everything big
   enough to tap? Are the build menu's buttons too close together?
3. Play a late wave on the phone, with every plot built: thirty skeletons on the road,
   each with an Animator, and a dozen towers shooting. Does it stay smooth? If it doesn't,
   that's what Level 4's **object pooling** is for: reusing arrows and skeletons instead
   of making and destroying them.

### Challenge

Watch a friend play without explaining anything. Where do they build first? Do they find
the upgrade? Which wave beats them? Fix the biggest problem: a cheaper tower, a longer
countdown, a gentler wave 4. That's what game designers call **playtesting**, and a tower
defence lives or dies by it.

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
