---
title: "Tank Arena"
subtitle: "Level 2: Builder"
author: "Unity Programmer Curriculum  ·  Level 2"
coverEyebrow: "Level 2 · Builder · Learn to Code · Make Games"
coverTop: "Tank"
coverRed: "Arena"
coverSub: "A top-down 2D tank battle: four rounds of enemy tanks that fire the moment they see you, repair kits, explosions, a start screen, settings, and controls that work with a finger on a phone."
coverPill: "Level 2 Workbook · Tank Arena"
coverCaption: "12 scripts · 4 rounds · 1 game you can play with a finger"
coverArt: image
coverImage: cover.png
footer: "Tank Arena  ·  Level 2 Workbook"
---

# Part 0 — Before You Start

## What you're going to build

A **top-down 2D tank battle**. Your blue tank starts in the middle of a sandy
arena, with walls of sandbags, trees and barrels to hide behind. Enemy tanks drive
in from the corners, in four rounds:

| Round | What's coming |
| --- | --- |
| 1 | 2 red light tanks: quick, and two hits destroy one |
| 2 | 3 light tanks |
| 3 | 2 light tanks and a black heavy tank: slow, but it takes five hits |
| 4 | 2 light tanks and 2 heavy tanks |

The enemy tanks drive around by themselves. When one of them can see you, close
enough and with no wall in the way, it stops, turns its barrel towards you, and
fires.

**How to play:** drive like a real tank. **W** and **S** drive forwards and
backwards, **A** and **D** turn the tank on the spot, and **Space** fires. The
barrel follows the mouse, and a click fires too. On a phone, tap anywhere to fire
towards that spot, or press and hold, and the tank drives towards your finger.

Your tank can take ten hits. A health bar shows how many are left, and destroyed
enemies sometimes leave a green **repair kit** behind: drive over it to mend your
tank. A start screen waits for **Play**, and the end screen shows how the battle
went: the rounds you cleared, the tanks you destroyed, and how many shots you
needed. There's also a settings panel for the volume, the screen shake, your
commander's name and the colour of your tank.

## Level 2 has three books

Level 2 has three games, each with its own book: **Mini Golf** (in 3D),
**Space Shooter** (in 2D) and **Tank Arena** (this one, also in 2D). Every book
teaches **every** Level 2 topic, and they share the same C# Concept chapters, so
your trainer can run one book, or give different groups different books. If
you've done one book already, the C# Concept chapters in the next are a revision
round.

## How this book works

It works just like Levels 0 and 1: two kinds of chapters, read in the order they
appear.

| Chapter | Colour | What it does |
| --- | --- | --- |
| **Chapter 1, 2, 3…** | Red | **Build** the game in Unity, step by step. |
| **C# Concept 1, 2, 3…** | Slate | **Learn** one coding idea, C# or Unity scripting, with examples to try. |

Each chapter follows the same beats: **Goal**, **Idea**, **Do it**, **Test it**
and an optional **Challenge**. Under many C# examples, a grey box shows what the
Console prints: **predict** it before you look.

You'll try the C# examples in a `Practice` script, as before: make an empty
GameObject called `Practice`, give it a script called `Practice`, put the example
inside `Start()`, press **Play**, and read the Console. When an example needs
other things in the scene, the chapter says what to add.

> **Tip:** You passed the Level 2 entry test, so everything in Levels 0 and 1 is
> yours to use: variables, `if`, methods, `[SerializeField]`, arrays, loops,
> `enum`, `switch`, prefabs, triggers, `Instantiate`, TextMeshPro and sound. Keep
> the Level 1 cheat sheet next to you.

## The route through this book

| Step | Chapter | You learn | You build |
| --- | --- | --- | --- |
| 1 | Chapter 1 | Pixels Per Unit, tiled sprites, colliders | The arena |
| 2 | C# 1, C# 2 | Vectors, event functions | — |
| 3 | Chapter 2 | Rigidbodies, velocity, `FixedUpdate` | A tank that drives |
| 4 | C# 3, C# 4 | Return types, parameters, overloading, `out`; mouse and touch | — |
| 5 | Chapter 3 | Pivots, angles, `Quaternion.Euler` | The turret |
| 6 | C# 5, C# 6 | `GetComponent`, `[RequireComponent]`; properties and constructors | — |
| 7 | Chapter 4 | Components you can share, key presses | Tracks and shells |
| 8 | C# 7, C# 8 | `static`, `const`, `readonly`; coroutines and timers | — |
| 9 | Chapter 5 | Static classes, a tank that drives itself | Enemy tanks |
| 10 | C# 9, C# 10 | Lists; conversions | — |
| 11 | Chapter 6 | Spawn points, `%` | The game |
| 12 | C# 11 | Raycasts | — |
| 13 | Chapter 7 | 2D raycasts, layers, `out` | Enemies that fire back |
| 14 | C# 12 | The Unity docs | — |
| 15 | Chapter 8 | Rounds, filled images | Rounds and a health bar |
| 16 | Chapter 9 | Taps and holds, the Device Simulator | Touch controls |
| 17 | Chapter 10 | `LateUpdate`, `Lerp`, overloads | The follow camera |
| 18 | C# 13, C# 14 | Dictionaries, UI events | — |
| 19 | Chapter 11 | Plain C# classes, `AddListener`, game states | Start and end |
| 20 | Chapter 12 | Particles, audio, default values | Repair kits, explosions and sound |
| 21 | Chapter 13 | Sliders, toggles, input fields, dropdowns | Settings |
| 22 | C# 15 | `null`, stack traces, breakpoints | — |
| 23 | Chapter 14 | Debugging | Break it, then fix it |
| 24 | Chapter 15 | Builds, testing touch | A game you can share |
| 25 | Part 6 | Exam-style practice | — |

## For trainers: running a session

Sessions follow the route above, with the same rhythm as Levels 0 and 1:

| Share | Activity | From |
| --- | --- | --- |
| About 20% | **Concept:** teach the idea. Students predict each example's Console output before you run it. | C# Concept chapters |
| About 60% | **Build:** students follow the chapter in Unity and press Play at every checkpoint. | Build chapters |
| About 20% | **Practice:** the **Do it** exercises, in class or as homework. | C# Concept chapters |

Students join Level 2 by passing the **Level 2 entry test** (the Level 2 entry
test papers in the course project; the answer key is a separate trainer-only
file). Chapters 4 and 5 are the heart of this book: one tank made of small
components, then enemy tanks that reuse the same components with a brain of their
own. Chapter 11 ties the whole match together, from the start screen to the end
screen, so give these chapters the most time. Part 6 rehearses the question styles
of the **Unity Certified User: Programmer** exam, which students sit at the end
of Level 3.

Your trainer project has a finished version of the game, and a menu item that
builds its scene from scratch (**Tools → Tank Arena (Level 2) → Build Scene**):
use it to show the goal on the first day, or to rescue a scene that's beyond
repair.

## The pieces we'll build

Twelve scripts:

```
PlayerTank ──── your tank's brain: reads the keys, the mouse and a finger
EnemyTank ───── an enemy's brain: drives around, and fires when it can see you
Tracks ──────── drives a tank forwards and backwards, and turns it on the spot
Turret ──────── turns a tank's barrel towards a point, and fires shells
Health ──────── hit points, for every tank
Shell ───────── flies straight ahead, and hurts the first tank it hits
RepairKit ───── mends your tank when you drive over it
CameraFollow ── follows your tank, and shakes when something explodes
ArenaGame ───── runs the match: the rounds, the screen, the start and end panels
SettingsMenu ── the settings panel: volume, shake, name, tank colour

ArenaBounds ─── the size of the arena, for every script (a static class)
MatchStats ──── the numbers of one match (a plain C# class)
```

Every tank, yours and the enemies', is built from the same three components:
**Tracks**, **Turret** and **Health**. Only the brain is different.

## New words for Level 2

| Word | What it means |
| --- | --- |
| **Pixels Per Unit** | How many pixels of a sprite make one unit of the world. At 100, a 100-pixel sprite is 1 unit across. |
| **Pivot** | The point of a sprite that sits at its GameObject's position: the point it turns around. |
| **Body Type** | How physics treats a Rigidbody 2D: **Dynamic** (physics moves it), **Kinematic** (only your code moves it) or **Static** (it never moves). |
| **Layer** | A group a GameObject belongs to, used to choose what physics and raycasts can touch. |
| **Raycast** | An invisible line shot from a point in a direction, which reports the first collider it hits. |
| **Coroutine** | A method that can pause and carry on later. |
| **Particle System** | A component that throws out lots of tiny images: sparks, smoke, explosions. |

## One-time project setup

- **Unity 6**, with a new project created from the **Universal 2D** template.
- **Input:** a new Unity 6 project reads the keyboard, the mouse and the
  touchscreen with the **Input System** package, and that's what this book uses.
  There's nothing to set up.
- **Art:** the tanks, shells, sandbags, trees, barrels and smoke come from
  Kenney's **Top-down Tanks** pack, free to use for anything (www.kenney.nl). Your
  trainer shares a folder of the sprites this book uses. If you download the pack
  yourself, the sprites are in its `PNG` folder, sorted into `Tanks`, `Bullets`,
  `Environment`, `Obstacles` and `Smoke`.
- **Sound:** your trainer shares six sounds: `Shot.wav`, `Hit.wav`,
  `Repair.wav`, `Explosion.wav`, `Victory.wav` and `Defeat.wav`. You'll need them
  in Chapter 12.
- Scripts live in `Assets/Scripts`, sprites in `Assets/Sprites`, sounds in
  `Assets/Audio`, prefabs in `Assets/Prefabs`, and materials in
  `Assets/Materials`.

# Part 1 — Roll Out

## Chapter 1 — The Arena

**Goal:** a sandy arena seen from above, with walls of sandbags around it and
across it, trees and barrels to hide behind, and a collider on everything solid.

### Idea — how big is a sprite?

A sprite's size in the world comes from its **Pixels Per Unit**: how many of its
pixels make one unit. Kenney's sprites use the default, 100:

| Sprite | Pixels | Units in the world |
| --- | --- | --- |
| `tankBlue`, your tank | 75 × 70 | 0.75 × 0.7 |
| `barrelBlue`, its barrel | 16 × 50 | 0.16 × 0.5 |
| `sand`, the ground | 128 × 128 | 1.28 × 1.28 |
| `sandbagBrown`, one sandbag | 66 × 44 | 0.66 × 0.44 |
| `treeLarge`, a tree | 98 × 107 | 0.98 × 1.07 |

The arena is 24 units wide and 16 units tall: from `x = -12` to `x = 12`, and
from `y = -8` to `y = 8`. The camera's **Size** is half the height it sees, so
Size 8 would fit the arena exactly, and Size 8.5 leaves a little border around
it. For now you'll see the whole arena at once; in Chapter 10, the camera zooms
in and follows your tank.

### Idea — sprites that repeat

The ground is one small square of sand, 1.28 units across, repeated like floor
tiles. A **Sprite Renderer** can do the repeating for you: set its **Draw Mode**
to **Tiled** and give it a **Size**, and it fills that size with copies of the
sprite. A wall works the same way: one sandbag, repeated along the wall's length.

Tiling needs the sprite's whole rectangle. The default **Mesh Type**, **Tight**,
trims a sprite to the outline of its drawing, so the sprites you tile need
**Full Rect** instead.

### Idea — solid things

Walls, trees and barrels never move, so they need no Rigidbody 2D: just a
**collider**, the invisible shape that physics uses. Anything with a Rigidbody 2D,
like your tank in Chapter 2, bumps into those shapes and stops.

- A wall gets a **Box Collider 2D** with **Auto Tiling** ticked: the box follows
  the tiled size of its Sprite Renderer, however long you make the wall.
- A tree gets a small **Circle Collider 2D**: just its trunk. Tanks and shells
  can slip under the edge of its leaves, and the leaves are drawn on top.
- An oil barrel gets a Circle Collider 2D the size of the barrel.

### Idea — a tidy Hierarchy

The arena is made of 17 objects. They all go inside one empty GameObject called
`Arena`, as its **children**: the Hierarchy stays short, and in Chapter 7 you'll
change all of them in one go.

### Do it — the project and the scene

1. In **Unity Hub**, create a new project from the **Universal 2D** template.
2. The template opens a scene called `SampleScene`, with a **Main Camera** and a
   **Global Light 2D**, which lights the sprites. **File → Save As**
   `Assets/Scenes/TankArena.unity`.
3. In the **Project** window, create the folders `Sprites`, `Audio`, `Scripts`,
   `Prefabs` and `Materials` inside `Assets`.
4. Copy the sprites into `Assets/Sprites`, and the six sounds into `Assets/Audio`.

### Do it — the camera

Select **Main Camera**. In its **Camera** component, check that **Projection** is
**Orthographic**, and set **Size** to `8.5`. Under **Environment**, set
**Background Type** to **Solid Color** and the **Background** colour to a dark
brown, `#3B3326`: the world outside the arena.

### Do it — the ground

1. In `Assets/Sprites`, click `sand`, then hold **Ctrl** (**Cmd** on Mac) and
   click `sandbagBrown`, so both are selected. In the Inspector, set **Mesh Type**
   to **Full Rect**, and click **Apply**.
2. **GameObject → Create Empty**, named `Arena`, at **Position** `(0, 0, 0)`.
3. Drag `sand` from `Assets/Sprites` onto `Arena` in the Hierarchy: it becomes a
   child of `Arena`. Rename it `Ground`, and set its **Position** to `(0, 0, 0)`.
4. In its **Sprite Renderer**, set **Draw Mode** to **Tiled**, **Size** to
   `24 × 16`, and **Order in Layer** to `-10`, so everything else draws in front
   of it.

### Do it — the walls

1. Drag `sandbagBrown` onto `Arena`. Rename it `Wall Top`, and set its
   **Position** to `(0, 7.78, 0)`.
2. In its Sprite Renderer, set **Draw Mode** to **Tiled** and **Size** to
   `24 × 0.44`: a row of sandbags across the whole top of the arena.
3. **Add Component → Box Collider 2D**, and tick **Auto Tiling**. Its **Size**
   says `24 × 0.44`, like the sandbags; if it doesn't, type it in. In the Scene
   view, a thin green box hugs the row of sandbags.
4. Select `Wall Top` and press **Ctrl + D** (**Cmd + D**) seven times. Rename the
   copies and set them like this: the **Size** is the Sprite Renderer's, and the
   Box Collider follows it by itself. Then select each copy and check that its
   green box hugs its sandbags; if one doesn't, type the same Size into its Box
   Collider 2D.

| Name | Position | Rotation Z | Size |
| --- | --- | --- | --- |
| `Wall Top` | (0, 7.78, 0) | 0 | 24 × 0.44 |
| `Wall Bottom` | (0, −7.78, 0) | 0 | 24 × 0.44 |
| `Wall Left` | (−11.78, 0, 0) | 90 | 16 × 0.44 |
| `Wall Right` | (11.78, 0, 0) | 90 | 16 × 0.44 |
| `Wall North` | (0, 3.5, 0) | 0 | 5 × 0.44 |
| `Wall South` | (0, −3.5, 0) | 0 | 5 × 0.44 |
| `Wall West` | (−6.5, 0, 0) | 90 | 4 × 0.44 |
| `Wall East` | (6.5, 0, 0) | 90 | 4 × 0.44 |

Why 7.78? A wall is 0.44 thick, so its middle is 0.22 inside the edge of the
arena: 8 − 0.22 = 7.78. And the walls turned by 90 degrees run up and down the
screen instead of across it.

### Do it — trees and barrels

Drag each sprite onto `Arena`, rename it, and set its **Position** and **Order in
Layer**. Then **Add Component → Circle Collider 2D**, and set its **Radius**.

| Name | Sprite | Position | Order in Layer | Radius |
| --- | --- | --- | --- | --- |
| `Tree` | `treeLarge` | (−8, 4.5, 0) | 4 | 0.3 |
| `Tree` | `treeLarge` | (8, −4.5, 0) | 4 | 0.3 |
| `Tree` | `treeLarge` | (−3.5, −6, 0) | 4 | 0.3 |
| `Tree` | `treeLarge` | (3.5, 6, 0) | 4 | 0.3 |
| `Oil Barrel` | `barrelRed_up` | (−9.5, −1, 0) | 1 | 0.22 |
| `Oil Barrel` | `barrelRed_up` | (9.5, 1, 0) | 1 | 0.22 |
| `Oil Barrel` | `barrelGrey_up` | (−2.5, 1, 0) | 1 | 0.22 |
| `Oil Barrel` | `barrelGrey_up` | (2.5, −1, 0) | 1 | 0.22 |

> **Tip:** make the first tree completely, collider and all, then duplicate it
> and change only the position. The same goes for the oil barrels; for the grey
> ones, change the **Sprite** too.

The trees have the highest **Order in Layer** in the arena, 4, so their leaves
cover everything that drives underneath: tanks will be 1, the barrels of their
guns 2, and shells 3.

### Test it

Look at the arena in the **Game** view: sand, eight walls, four trees and four
barrels, with a brown border around it all. Now check the colliders with a quick
physics test:

1. Drag `barrelGreen_up` into the Hierarchy (not into `Arena`), and set its
   **Position** to `(0, 6, 0)`.
2. Add a **Rigidbody 2D** (leave it **Dynamic**, with **Gravity Scale** `1`) and a
   **Circle Collider 2D**.
3. Press **Play**: the barrel falls down the screen and lands on `Wall North`.

Stop, and delete the green barrel. In a game seen from above, nothing falls: your
tank will have a Gravity Scale of 0.

### Challenge

Add more cover: a `treeSmall` somewhere, or a short wall of `sandbagBeige` (set
its **Mesh Type** to **Full Rect** first, like `sandbagBrown`), each with its own
collider. Drag them onto `Arena` like the rest, so that in Chapter 7 they block
the enemies' view too. Keep the middle of the arena clear, where your tank will
start, and the four corners, where the enemy tanks will arrive.

## C# 1 — Vectors

**Goal:** you can use vectors for positions, movements and directions: add and
subtract them, measure them, and normalize them.

### Idea — a vector is an arrow

A `Vector3` holds three numbers, `x`, `y` and `z`; a `Vector2` holds two, `x`
and `y`. The same vector can mean two things:

| A vector as… | Example | Meaning |
| --- | --- | --- |
| a **position** | `transform.position` | a point: "where" |
| a **movement** or **direction** | `new Vector3(0, 5, 0)` | an arrow: "which way, and how far" |

Unity gives names to the arrows you need most:

| Name | Value | Name | Value |
| --- | --- | --- | --- |
| `Vector3.zero` | (0, 0, 0) | `Vector3.one` | (1, 1, 1) |
| `Vector3.up` | (0, 1, 0) | `Vector3.down` | (0, -1, 0) |
| `Vector3.right` | (1, 0, 0) | `Vector3.left` | (-1, 0, 0) |
| `Vector3.forward` | (0, 0, 1) | `Vector3.back` | (0, 0, -1) |

`Vector2` has the same names, without `forward` and `back`: `Vector2.up` is
(0, 1).

### Idea — vector maths

```csharp
Vector3 a = new Vector3(1, 2, 0);
Vector3 b = new Vector3(4, 6, 0);
Debug.Log(a + b);
Debug.Log(b - a);
Debug.Log(a * 3);
Debug.Log(b.x);
```

```
(5.00, 8.00, 0.00)
(3.00, 4.00, 0.00)
(3.00, 6.00, 0.00)
4
```

Unity prints vectors with two decimals. Each operation has a meaning:

- **`position + movement`** is a new position: where you end up after moving.
- **`b - a`** is the arrow **from `a` to `b`**. Remember it as
  **"target minus me"**.
- **`arrow * number`** makes the arrow longer (or shorter, with a number below 1).

### Idea — how long is an arrow?

An arrow's length is its **magnitude**. The distance between two points is the
length of the arrow between them, and `Vector3.Distance` works it out for you:

```csharp
Vector3 me = new Vector3(1, 2, 0);
Vector3 target = new Vector3(4, 6, 0);
Vector3 toTarget = target - me;
Debug.Log(toTarget.magnitude);
Debug.Log(Vector3.Distance(me, target));
```

```
5
5
```

Distance is how enemies decide the player is close enough to attack
(`if (Vector3.Distance(transform.position, player.position) < 3f)`), and how a
game decides a ball has stopped (`if (velocity.magnitude < 0.05f)`).

### Idea — a direction: normalize

A **direction** says "which way" and nothing else, so it should have a length of
exactly 1. `.normalized` gives you an arrow pointing the same way, with length
1:

```csharp
Vector3 toTarget = new Vector3(3, 4, 0);
Vector3 direction = toTarget.normalized;
Debug.Log(direction);
Debug.Log(direction.magnitude);
```

```
(0.60, 0.80, 0.00)
1
```

Why does it matter? To chase a target at a steady speed, you move along the
direction, times the speed:

```csharp
Vector3 direction = (target.position - transform.position).normalized;
transform.position += direction * speed * Time.deltaTime;
```

Without `.normalized`, the arrow is as long as the distance: the chaser would
rush when it's far away and crawl when it's close. With it, the speed is always
`speed`.

> **Tip:** `Vector3.MoveTowards(current, target, maxStep)` does the chasing for
> you: it moves `current` towards `target` by at most `maxStep`, and never
> overshoots.

### Idea — 2D and 3D together

A `Vector2` turns into a `Vector3` automatically (with `z = 0`), and a `Vector3`
turns into a `Vector2` by dropping `z`:

```csharp
Vector2 flat = new Vector2(3, 4);
Vector3 deep = flat;
Debug.Log(deep);
```

```
(3.00, 4.00, 0.00)
```

In a 3D game where things move on the ground, you often want a direction that
stays **flat**: set `y` to 0 before you normalize, so nothing aims into the floor
or up at the sky:

```csharp
Vector3 aim = target - transform.position;
aim.y = 0f;
aim = aim.normalized;
```

### Idea — the way an object faces

Every Transform knows its own arrows, and they turn when the object turns:

| Property | In 2D | In 3D |
| --- | --- | --- |
| `transform.up` | the way the sprite's top points | the object's up |
| `transform.right` | the way the sprite's right side points | the object's right |
| `transform.forward` | into the screen: not useful in 2D | the way the object faces |

They also work the other way: **set** one to turn the object.
`transform.up = direction;` turns a 2D sprite so its top points along
`direction`, and `transform.forward = direction;` turns a 3D object to face
`direction`.

### Do it

1. Make two points, `(2, 1, 0)` and `(5, 5, 0)`. Print the arrow from the first
   to the second, its length, and its direction.
2. Print `Vector3.Distance` between them. Does it match the length?
3. Print `Vector3.up * 3 + Vector3.right`. Draw the arrow on paper first.
4. Make an object chase another one in `Update` with a normalized direction and
   a `[SerializeField] float speed`. Then remove `.normalized` and watch the
   difference.

### Challenge

Make an object **patrol**: give it two points, A and B, and use
`Vector3.MoveTowards` in `Update` to move it to B, then back to A, forever. When
`Vector3.Distance` to the point it's heading for is less than 0.01, swap to the
other point. Then make it face the way it's moving (`transform.up` in 2D,
`transform.forward` in 3D).

## C# 2 — Event Functions: When Unity Calls Your Code

**Goal:** you know which event function Unity calls when, and you put each piece
of code in the right one.

### Idea — you don't call them: Unity does

You've never written `Start();` anywhere. Unity calls `Start()` and `Update()`
for you, at the right moments. They belong to a whole family of **event
functions** that Unity calls at fixed points in a script's life. You declare one
with the exact name, and Unity finds it and calls it.

> **Watch out:** the name must match **exactly**, capitals included. A method
> called `start()` or `Updat()` is just a normal method that nobody calls: no
> error, and it never runs.

### Idea — the life of a script

```
Awake()          once, when the object is created
OnEnable()       every time the script is switched on
Start()          once, just before its first Update
 ┌─ FixedUpdate()   on the physics clock: 50 times a second
 ├─ Update()        once every frame
 └─ LateUpdate()    once every frame, after every Update has run
OnDisable()      every time the script is switched off, and when it's destroyed
OnDestroy()      once, when the object is destroyed
```

| Function | When Unity calls it | Use it for |
| --- | --- | --- |
| `Awake` | once, first of all, even if the script is disabled | setting up **this** object: getting its own components |
| `OnEnable` | every time the script is enabled | starting to listen to events |
| `Start` | once, before the first frame, only if the script is enabled | setting up things that need **other** objects |
| `FixedUpdate` | on the physics clock, every 0.02 seconds | physics: forces and Rigidbody velocities |
| `Update` | every frame | input, timers, movement without physics |
| `LateUpdate` | every frame, after all the `Update`s | a camera that follows something |
| `OnDisable` | every time the script is disabled, and before it's destroyed | stopping listening to events |
| `OnDestroy` | once, when the object is destroyed | final clean-up |

### Idea — see the order for yourself

```csharp
using UnityEngine;

public class Practice : MonoBehaviour
{
    int frames = 0;

    void Awake()
    {
        Debug.Log("Awake");
    }

    void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    void Start()
    {
        Debug.Log("Start");
    }

    void Update()
    {
        if (frames < 2)
        {
            Debug.Log("Update " + frames);
        }
    }

    void LateUpdate()
    {
        if (frames < 2)
        {
            Debug.Log("LateUpdate " + frames);
        }
        frames++;
    }

    void OnDisable()
    {
        Debug.Log("OnDisable");
    }
}
```

Press Play, wait a moment, then stop. The Console shows:

```
Awake
OnEnable
Start
Update 0
LateUpdate 0
Update 1
LateUpdate 1
OnDisable
```

The `if`s keep the Console readable: after two frames, `Update` and `LateUpdate`
keep running every frame, but quietly. `OnDisable` arrives when you stop,
because stopping destroys every object in the scene.

`FixedUpdate` isn't in the example because it doesn't follow the frames: a fast
computer may draw several frames between two `FixedUpdate`s, and a slow one may
run `FixedUpdate` twice in one frame.

### Idea — Update or FixedUpdate?

Physics has its own clock. Unity moves every Rigidbody on that clock, so code
that pushes a Rigidbody belongs in `FixedUpdate`, where it runs in step with the
physics. Everything else goes in `Update`.

| Put it in `Update` | Put it in `FixedUpdate` |
| --- | --- |
| reading the keyboard, mouse and touch | `AddForce` on a Rigidbody |
| timers and cooldowns | setting a Rigidbody's velocity |
| moving objects with `transform` | moving a Rigidbody with `MovePosition` |

There's a catch: `wasPressedThisFrame` is `true` for **one frame** only, and
`FixedUpdate` might not run in that frame. So read input in `Update`, remember it
in a field, and use it in `FixedUpdate`:

```csharp
bool jumpPressed;

void Update()
{
    if (Keyboard.current.spaceKey.wasPressedThisFrame)
    {
        jumpPressed = true;          // remember it
    }
}

void FixedUpdate()
{
    if (jumpPressed)
    {
        Debug.Log("Jump!");          // the physics code goes here
        jumpPressed = false;         // used: forget it
    }
}
```

> **Note:** inside `FixedUpdate`, `Time.deltaTime` gives the physics step (0.02
> seconds), so frame-independent maths works the same in both.

### Idea — Awake or Start?

Unity calls every object's `Awake` before **any** object's `Start`. But it
doesn't promise which object's `Awake` comes first. That gives a simple rule:

- In **`Awake`**, set up **yourself**: your own fields and your own components.
- In **`Start`**, use **other** objects. By then, every object has run its
  `Awake`, so they're ready.

If script A reads a list in its `Awake` that script B fills in B's `Awake`, it
works on some days and fails on others. Move A's code to `Start` and it always
works.

### Idea — switching scripts on and off

| You do | Unity calls | And |
| --- | --- | --- |
| untick the script in the Inspector, or `enabled = false;` | `OnDisable` | `Update`, `FixedUpdate` and `LateUpdate` stop |
| tick it again, or `enabled = true;` | `OnEnable` | they start again |
| `gameObject.SetActive(false);` | `OnDisable` on every script of the object | the whole object disappears |
| `Destroy(gameObject);` | `OnDisable`, then `OnDestroy` | the object is gone |

> **Watch out:** a disabled script still receives collision and trigger messages
> (`OnTriggerEnter2D` and the others). Only deactivating the whole GameObject
> silences it completely.

### Do it

1. Put the example in your `Practice` script, press Play, stop, and match the
   Console to the diagram.
2. While the game is playing, untick the `Practice` component in the Inspector,
   then tick it again. Which messages appear?
3. Add `void OnDestroy()` with a `Debug.Log`, and stop the game. Does it come
   before or after `OnDisable`?
4. Rename `Start` to `start` and press Play: no error, and no `Start` message.
   Change it back.

### Challenge

Count how many times `Update` and `FixedUpdate` run. After two seconds of play
(check `Time.time` in `Update`), print both counts once. `FixedUpdate` gives
about 100, whatever your computer. What does `Update` give, and why is it
different on a friend's computer?

## Chapter 2 — The Tank

**Goal:** your blue tank drives around the arena like a real tank: **W** and
**S** drive forwards and backwards, **A** and **D** turn it on the spot, and it
can't drive through walls.

### Idea — tank controls

A real tank doesn't slide sideways: it drives forwards or backwards, in the
direction it's facing, and it turns on the spot. So the keys give two numbers:

| Number | 1 | 0 | −1 |
| --- | --- | --- | --- |
| `drive` | **W**: forwards | nothing, or both | **S**: backwards |
| `turn` | **A**: turn left | nothing, or both | **D**: turn right |

The direction the tank faces is `transform.up`, the way its sprite points
(C# 1). Turning left is anticlockwise, and anticlockwise angles are
positive, so **A** gives `+1`.

### Idea — physics drives the tank

The tank must stop at walls, so physics moves it: it gets a **Rigidbody 2D**. What
kind of body depends on who moves it:

| Body Type | What moves it | In this game |
| --- | --- | --- |
| **Dynamic** | physics: forces, velocity, collisions | the tanks and the shells |
| **Kinematic** | only your code | the repair kits (Chapter 12) |
| **Static** | nothing: it never moves | nothing; the walls, trees and barrels have no Rigidbody 2D at all, which works the same way |

A Dynamic body in a game seen from above needs a **Gravity Scale** of 0, or it
would fall down the screen like the green barrel in Chapter 1.

Instead of moving the Transform, the script sets how fast the body goes, and
physics does the moving, stopping it at every wall:

| Rigidbody 2D | Is | For the tank |
| --- | --- | --- |
| `body.linearVelocity` | a `Vector2`: its speed and direction, in units per second | `transform.up` times the speed |
| `body.angularVelocity` | a `float`: how fast it turns, in degrees per second | `turn` times the turning speed |

Physics works on its own clock, 50 steps a second, so the script sets the body's
velocities in `FixedUpdate`, which Unity calls before every physics step
(C# 2).

### Do it

1. Drag `tankBlue` into the Hierarchy (not into `Arena`). Rename it
   `Player Tank`, set its **Position** to `(0, 0, 0)`, and its **Order in Layer**
   to `1`.
2. **Add Component → Rigidbody 2D**, and set:
   - **Body Type** **Dynamic**, and **Gravity Scale** `0`
   - **Interpolate** **Interpolate**. Physics moves the tank 50 times a second,
     but the screen may draw 60 or 120 frames: this smooths the movement in
     between.
3. **Add Component → Circle Collider 2D**, with **Radius** `0.35`.
4. Create `PlayerTank` in `Assets/Scripts`, and attach it to `Player Tank`:

```csharp
using UnityEngine;
using UnityEngine.InputSystem;

// The player's tank, driven like a real tank: W and S drive forwards and
// backwards along the way it faces, and A and D turn it on the spot.
public class PlayerTank : MonoBehaviour
{
    [SerializeField] Rigidbody2D body;
    [SerializeField] float moveSpeed = 3f;        // units per second
    [SerializeField] float turnSpeed = 120f;      // degrees per second

    void FixedUpdate()
    {
        // Tank controls. A phone may have no keyboard at all, so check for null first.
        float drive = 0f;
        float turn = 0f;
        Keyboard keyboard = Keyboard.current;
        if (keyboard != null)
        {
            if (keyboard.wKey.isPressed || keyboard.upArrowKey.isPressed)
            {
                drive += 1f;
            }
            if (keyboard.sKey.isPressed || keyboard.downArrowKey.isPressed)
            {
                drive -= 1f;
            }
            if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed)
            {
                turn += 1f;
            }
            if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed)
            {
                turn -= 1f;
            }
        }

        // Physics moves the tank: set how fast it goes, and how fast it turns.
        body.linearVelocity = (Vector2)transform.up * (drive * moveSpeed);
        body.angularVelocity = turn * turnSpeed;
    }
}
```

5. Drag `Player Tank` itself into the **Body** field: Unity picks its
   Rigidbody 2D.

Read it before you move on:

- `drive` and `turn` start at 0 at every physics step, and each key held down
  adds 1 or takes 1 away. Hold **W** and **S** together, and they cancel out.
- `Keyboard.current` is `null` when there's no keyboard, on a phone, for
  example. Using `null` is an error (C# 15 tells the whole story), so the
  script checks first.
- `(Vector2)transform.up` keeps the `x` and `y` of the way the tank faces
  (C# 1). Times `drive * moveSpeed`, it's 3 units a second forwards,
  3 backwards, or nothing.
- The last two lines only say how fast to go and turn. Physics does the rest: it
  moves the tank, and stops it when it touches a collider.

### Test it

Press **Play**, and click the Game view. **W**: the tank drives up the screen, the
way it faces. **A** and **D**: it turns on the spot. **W** and **A** together: it
drives round in a circle. Drive into a wall, a tree trunk or a barrel: the tank
stops. In the Scene view, the tank's collider is a thin green circle.

### Challenge

Real tanks reverse slowly. Make driving backwards half as fast as driving
forwards: after reading the keys, halve `drive` when it's less than 0. Then think:
what does holding **S** and **A** together do now, and is that what a real tank
would do?

## C# 3 — Methods in Depth

**Goal:** you can read any method declaration, choose its return type and
parameters, give one name several versions (overloading), and hand back extra
values with `out`.

### Idea — the parts of a declaration

You've written methods since Level 0. Here's every part of a declaration, named:

```csharp
public int AddPoints(int points, bool doubled)
{
    // the body
}
```

| Part | Here | Meaning |
| --- | --- | --- |
| Access | `public` | who may call it; leave it out for `private` |
| Return type | `int` | the type of value it gives back, or `void` for nothing |
| Name | `AddPoints` | PascalCase, usually a verb |
| Parameters | `(int points, bool doubled)` | the values it needs, each with a type and a name |
| Body | `{ … }` | the code that runs when it's called |

The **name** plus the **parameter types** make the method's **signature**:
`AddPoints(int, bool)`. The return type isn't part of the signature, and that
matters for overloading below.

### Idea — return types

A method with a return type **must** return a value of that type, on **every**
path through it:

```csharp
string Grade(int score)
{
    if (score >= 90)
    {
        return "A";
    }
    else if (score >= 50)
    {
        return "Pass";
    }
    // no return for scores under 50: error CS0161
}
```

The error is *'Practice.Grade(int)': not all code paths return a value*
(CS0161). A score of 30 reaches the end of the method with nothing to give back.
Add `return "Fail";` as the last line and it's fixed.

A method can return any type: `bool`, `float`, `string`, `Vector3`, even a
`GameObject`. A method that answers a yes/no question usually returns `bool` and
starts with `Is`, `Has` or `Can`:

```csharp
bool IsEven(int number)
{
    return number % 2 == 0;
}
```

```csharp
Debug.Log(IsEven(10));
Debug.Log(IsEven(7));
Debug.Log(Grade(95) + " and " + Grade(60));
```

```
True
False
A and Pass
```

The value a method returns has a type, just like a variable.
`int result = Grade(95);` is an error, *Cannot implicitly convert type 'string'
to 'int'* (CS0029), because `Grade` returns a `string`.

### Idea — parameters

Parameters are the method's inputs, and **arguments** are the values you pass
when you call it. They're matched **by position**, so the call needs the right
number of arguments, of the right types, in the right order:

| Call | Result |
| --- | --- |
| `AddPoints(10, true)` | fine |
| `AddPoints(10)` | error CS7036: *There is no argument given that corresponds to the required parameter 'doubled' of 'Practice.AddPoints(int, bool)'* |
| `AddPoints("ten", true)` | error CS1503: *Argument 1: cannot convert from 'string' to 'int'* |

A parameter can have a **default value**. Then the argument is **optional**:

```csharp
void Heal(int amount = 10)
{
    Debug.Log("Healed " + amount);
}
```

```csharp
Heal(25);
Heal();
```

```
Healed 25
Healed 10
```

Unity's methods use default values a lot. In the Scripting API you'll see
declarations like `AddForce(Vector3 force, ForceMode mode = ForceMode.Force)`:
the second argument is optional.

### Idea — overloading: one name, several versions

Several methods can share a name, as long as their **parameter lists differ**
(a different number of parameters, or different types). C# picks the version
whose parameters match your arguments:

```csharp
void Greet()
{
    Debug.Log("Hello!");
}

void Greet(string name)
{
    Debug.Log("Hello, " + name + "!");
}

void Greet(string name, int times)
{
    for (int i = 0; i < times; i++)
    {
        Greet(name);
    }
}
```

```csharp
Greet();
Greet("Lina");
Greet("Omar", 2);
```

```
Hello!
Hello, Lina!
Hello, Omar!
Hello, Omar!
```

Notice that the third version calls the second one: overloads often share the
work this way. Overloads can also differ by **type**:

```csharp
int Half(int value)
{
    return value / 2;
}

float Half(float value)
{
    return value / 2;
}
```

```csharp
Debug.Log(Half(7));
Debug.Log(Half(7f));
```

```
3
3.5
```

`7` is an `int`, so C# runs the `int` version (and whole-number division drops
the .5). `7f` is a `float`, so it runs the `float` version.

You've been using overloads since Level 1. `Instantiate` has several versions:
`Instantiate(prefab)`, `Instantiate(prefab, parent)`,
`Instantiate(prefab, position, rotation)` and
`Instantiate(prefab, position, rotation, parent)`. And `Random.Range` has an
`int` version, which never returns the top number, and a `float` version, which
can.

> **Watch out:** the return type alone isn't enough to tell overloads apart.
> `int Speed()` and `float Speed()` in the same class give error CS0111: *Type
> 'Practice' already defines a member called 'Speed' with the same parameter
> types*. Parameter **names** don't count either: only their number and types.

### Idea — out: handing back more than one value

A method returns **one** value. When it needs to hand back more, it can use an
**`out` parameter**: the method fills in a variable that belongs to the caller.

```csharp
bool TryDivide(int a, int b, out int result)
{
    if (b == 0)
    {
        result = 0;
        return false;
    }
    result = a / b;
    return true;
}
```

```csharp
if (TryDivide(10, 2, out int answer))
{
    Debug.Log("10 / 2 = " + answer);
}

if (!TryDivide(5, 0, out int nothing))
{
    Debug.Log("You can't divide by zero");
}
```

```
10 / 2 = 5
You can't divide by zero
```

- `out int answer` creates a new variable, `answer`, right in the call. After the
  call, it holds whatever the method put in `result`.
- The method **must** give every `out` parameter a value before it returns, on
  every path (error CS0177 otherwise). That's why `result = 0;` is there even
  when dividing fails.
- The method returns `true` if it worked and `false` if it didn't. This is the
  **Try pattern**, and it's all over C# and Unity: `int.TryParse`,
  `TryGetComponent`, `TryGetValue`, and `Physics.Raycast(…, out RaycastHit hit)`
  all work like `TryDivide`.

### Do it

1. Write `int Biggest(int a, int b)` that returns the bigger number, and an
   overload `int Biggest(int a, int b, int c)` that uses the first one. Print
   `Biggest(4, 9)` and `Biggest(4, 9, 2)`.
2. Write `string Describe(int score)` that returns `"Great"` (100 or more),
   `"Good"` (50 or more) or `"Keep going"`. Remove the last `return` and read the
   error, then put it back.
3. Give `Describe` a second parameter `string player = "You"`, and make it
   return text like `"Sara: Great"`. Call it with and without a name.
4. Write `bool TryBuy(int price, int coins, out int change)`. When you have
   enough coins, print the change; when you don't, print `"Not enough coins"`.

### Challenge

Overload a method `Area`: `Area(float side)` for a square and
`Area(float width, float height)` for a rectangle, then print both. Now add
`int Area(float side)` and read the error. Which rule did it break?

## C# 4 — Mouse and Touch

**Goal:** you can read the mouse and the touchscreen with the Input System, turn
a screen position into a world position, and test touch without a phone.

### Idea — the same pattern as the keyboard

In Level 1 you read keys like this: `Keyboard.current.spaceKey.wasPressedThisFrame`.
A device, then a control on it, then a question. The mouse and the touchscreen
work the same way:

| You want to know… | Mouse | Touchscreen |
| --- | --- | --- |
| is it held down? | `Mouse.current.leftButton.isPressed` | `Touchscreen.current.primaryTouch.press.isPressed` |
| was it pressed this frame? | `Mouse.current.leftButton.wasPressedThisFrame` | `Touchscreen.current.primaryTouch.press.wasPressedThisFrame` |
| was it released this frame? | `Mouse.current.leftButton.wasReleasedThisFrame` | `Touchscreen.current.primaryTouch.press.wasReleasedThisFrame` |
| where is it? | `Mouse.current.position.ReadValue()` | `Touchscreen.current.primaryTouch.position.ReadValue()` |

`primaryTouch` is the first finger on the screen. `ReadValue()` gives the
position as a `Vector2` in **pixels**, where (0, 0) is the **bottom-left**
corner of the Game view.

```csharp
void Update()
{
    if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
    {
        Vector2 where = Mouse.current.position.ReadValue();
        Debug.Log("Click at " + where);
    }
}
```

```
Click at (412.00, 230.00)
```

(Your numbers depend on where you click.)

> **Watch out:** a computer without a touchscreen has no `Touchscreen.current`:
> it's `null`. A phone may have no `Mouse.current`. Check for `null` before you
> use a device, as the example does.

### Idea — Pointer: the mouse or a finger

Most games don't care whether the player clicks or taps. **`Pointer.current`**
is whichever pointing device was used last: the mouse on a computer, the finger
on a phone. It has a `press` and a `position`, so one piece of code handles
both:

```csharp
void Update()
{
    Pointer pointer = Pointer.current;
    if (pointer != null && pointer.press.wasPressedThisFrame)
    {
        Debug.Log("Pressed at " + pointer.position.ReadValue());
    }
}
```

On a computer, `press` is the left mouse button; on a phone, it's the first
finger. The games in this book use `Pointer`, so they work with a mouse and with
a touchscreen without any changes.

### Idea — from the screen to the world

Pixels aren't world units: pixel (400, 300) might be the point (1.5, -2) in your
scene. The **camera** converts between them:

| Game | Code | Gives |
| --- | --- | --- |
| 2D | `Camera.main.ScreenToWorldPoint(screenPosition)` | the world point under the pointer |
| 3D | `Camera.main.ScreenPointToRay(screenPosition)` | a **ray** from the camera through the pointer (use it with a raycast: C# 11) |

In 2D, this moves an object to wherever you click or tap:

```csharp
Pointer pointer = Pointer.current;
if (pointer != null && pointer.press.wasPressedThisFrame)
{
    Vector3 world = Camera.main.ScreenToWorldPoint(pointer.position.ReadValue());
    world.z = 0f;
    transform.position = world;
}
```

`ScreenToWorldPoint` returns a point at the camera's depth (`z = -10`), so set
`z` back to 0 before you use it.

### Idea — a drag: press, hold, release

A drag has three moments. Remember where it **started**, follow it while it's
**held**, and use it when it's **released**:

```csharp
Vector2 dragStart;

void Update()
{
    Pointer pointer = Pointer.current;
    if (pointer == null)
    {
        return;
    }

    if (pointer.press.wasPressedThisFrame)
    {
        dragStart = pointer.position.ReadValue();
    }

    if (pointer.press.wasReleasedThisFrame)
    {
        Vector2 drag = pointer.position.ReadValue() - dragStart;
        Debug.Log("You dragged " + drag.magnitude + " pixels");
    }
}
```

`return;` on its own leaves a `void` method straight away. Here it means "no
pointer at all: nothing to do this frame".

### Idea — testing touch without a phone

You don't need a phone to test touch. Unity has two ways to turn your mouse into
a finger:

1. **The Device Simulator.** In the Game view's toolbar, open the **Game**
   dropdown on the left and choose **Simulator** (or use **Window → General →
   Device Simulator**). Pick a phone at the top: the Game view takes its shape,
   and your clicks inside it become touches.
2. **The Input Debugger.** Open **Window → Analysis → Input Debugger**, then
   **Options → Simulate Touch Input From Mouse or Pen**. Your mouse now also
   acts as a finger in the normal Game view.

### Idea — the older Input class

Unity 6 projects read input with the **Input System** package, as this book
does. Older projects, and many exam questions, use the older `Input` class.
Learn to read both:

| Input System (this book) | Older `Input` class |
| --- | --- |
| `Mouse.current.leftButton.wasPressedThisFrame` | `Input.GetMouseButtonDown(0)` |
| `Mouse.current.leftButton.isPressed` | `Input.GetMouseButton(0)` |
| `Mouse.current.leftButton.wasReleasedThisFrame` | `Input.GetMouseButtonUp(0)` |
| `Mouse.current.position.ReadValue()` | `Input.mousePosition` |
| `Touchscreen.current.primaryTouch.press.isPressed` | `Input.touchCount > 0` |
| `Touchscreen.current.primaryTouch.position.ReadValue()` | `Input.GetTouch(0).position` |
| `…primaryTouch.press.wasPressedThisFrame` | `Input.GetTouch(0).phase == TouchPhase.Began` |
| `…primaryTouch.press.wasReleasedThisFrame` | `Input.GetTouch(0).phase == TouchPhase.Ended` |

> **Watch out:** in a project that uses the Input System only, the older `Input`
> class throws an **InvalidOperationException** as soon as it runs: *You are
> trying to read Input using the UnityEngine.Input class, but you have switched
> active Input handling to Input System package in Player Settings.*

### Do it

1. Print the mouse position every time you click in the Game view. Click the
   bottom-left corner, then the top-right. What are the numbers?
2. Use `Pointer` to print `"Down"` when it's pressed, then `"Up"` and how long
   the press lasted when it's released (use `Time.time`).
3. Make an object jump to wherever you click (2D: `ScreenToWorldPoint`).
4. Switch the Game view to the Simulator, choose a phone, and test step 2 with
   "touches".

### Challenge

A swipe detector: when the pointer is released, if the drag is longer than 100
pixels, print `"Swipe left"`, `"Swipe right"`, `"Swipe up"` or `"Swipe down"`.
Compare `Mathf.Abs(drag.x)` with `Mathf.Abs(drag.y)` to decide whether the swipe
was mostly sideways or mostly up and down.

## Chapter 3 — The Turret

**Goal:** your tank's barrel turns towards the mouse pointer, a little every
frame, while the tank drives wherever it likes.

### Idea — a barrel that turns around its end

The barrel is a sprite of its own, a child of the tank, so it goes wherever the
tank goes. It must turn around the end that's fixed to the tank.

A sprite's **pivot** is the point that sits exactly at its GameObject's position,
and the point it turns around. By default it's the middle of the sprite: a barrel
turning around its middle would swing round like a propeller. Set the pivot to
**Bottom**, in the sprite's import settings, and the barrel turns around its
bottom end. With the barrel at `(0, 0, 0)`, that end sits in the middle of the
tank, and the barrel sticks out 0.5 units.

### Idea — the angle to a point

The barrel should point at the mouse. First, the arrow from the barrel to the
mouse (C# 1):

```csharp
Vector2 direction = point - (Vector2)barrel.position;
```

`Vector2.SignedAngle(from, to)` gives the angle between two arrows, in degrees,
from −180 to 180: positive when `to` is anticlockwise from `from`. Measured from
`Vector2.up`, it's exactly the **Z** rotation that turns an up-pointing sprite
towards the point:

| `direction` | `Vector2.SignedAngle(Vector2.up, direction)` |
| --- | --- |
| `(0, 1)`, up | 0 |
| `(-1, 0)`, left | 90 |
| `(1, 0)`, right | −90 |
| `(0, -1)`, down | 180 |
| `(1, 1)`, up and to the right | −45 |

### Idea — turning a little at a time

A real turret takes time to turn. `Mathf.MoveTowardsAngle(current, target,
maxStep)` moves an angle towards another, but by `maxStep` degrees at most:

| Call | Result |
| --- | --- |
| `Mathf.MoveTowardsAngle(0f, 90f, 6f)` | 6 |
| `Mathf.MoveTowardsAngle(84f, 90f, 6f)` | 90 |
| `Mathf.MoveTowardsAngle(350f, 10f, 6f)` | 356 |

The last line shows why it's `MoveTowardsAngle` and not `MoveTowards`: it knows
that 350° and 10° are only 20° apart, and goes the short way round. With
`turnSpeed * Time.deltaTime` as the step, the barrel turns at `turnSpeed` degrees
a second, whatever the frame rate.

The result goes into the barrel's rotation. Unity keeps rotations as
`Quaternion`s; you don't need their maths, just one line:
`Quaternion.Euler(0f, 0f, angle)` is the rotation you'd type into the Inspector
as `(0, 0, angle)`. In 2D, turning around `z` is the only turn there is.

### Idea — where's the mouse?

`Pointer.current` is the mouse, or a finger on a touchscreen (C# 4).
`pointer.position.ReadValue()` says where it is, in pixels on the screen, and
`cam.ScreenToWorldPoint` turns that into a point in the world: a `Vector3` whose
`z` is the camera's, −10. Stored in a `Vector2`, the `z` is simply dropped
(C# 1). `cam` is found once, in `Awake`: `Camera.main` is the camera
tagged **MainCamera**.

### Idea — a Turret component

The turning goes into a script of its own, `Turret`, with a public method:
`AimAt(Vector2 point)`. `PlayerTank` decides **where** to aim, and `Turret` knows
**how**. In Chapter 5, the enemy tanks use the same `Turret`, with a brain of
their own deciding where to aim.

The barrel isn't moved by physics, so it turns in `Update`, every frame. The
tracks stay in `FixedUpdate`.

### Do it — the barrel's pivot

1. In `Assets/Sprites`, select the five barrel sprites together: click
   `barrelBeige`, then hold **Ctrl** (**Cmd**) and click `barrelBlack`,
   `barrelBlue`, `barrelGreen` and `barrelRed`. Leave out the three ending in
   `_up`: those are oil barrels.
2. In the Inspector, set **Pivot** to **Bottom**, and click **Apply**. The other
   colours are for later: red and black for the enemy tanks, green and beige for
   the settings.

### Do it — the barrel

Drag `barrelBlue` from `Assets/Sprites` onto `Player Tank` in the Hierarchy: it
becomes a child of the tank. Rename it `Barrel`, set its **Position** to
`(0, 0, 0)`, and its **Order in Layer** to `2`, in front of the tank.

### Do it — the scripts

1. Create `Turret`, and attach it to `Player Tank`:

```csharp
using UnityEngine;

// A tank's turret. The barrel turns towards a point, a little at a time.
public class Turret : MonoBehaviour
{
    [SerializeField] Transform barrel;
    [SerializeField] float turnSpeed = 180f;      // degrees per second

    // Turns the barrel a step towards the point. Call it every frame.
    public void AimAt(Vector2 point)
    {
        Vector2 direction = point - (Vector2)barrel.position;
        float wanted = Vector2.SignedAngle(Vector2.up, direction);
        float step = turnSpeed * Time.deltaTime;
        float angle = Mathf.MoveTowardsAngle(barrel.eulerAngles.z, wanted, step);
        barrel.rotation = Quaternion.Euler(0f, 0f, angle);
    }
}
```

2. Select `Player Tank`. Drag its child `Barrel` into the Turret's **Barrel**
   field, and set **Turn Speed** to `360`: a quick turret, for the player. The
   enemies' turrets will be slower.
3. Replace `PlayerTank` with this version:

```csharp
using UnityEngine;
using UnityEngine.InputSystem;

// The player's tank, driven like a real tank: W and S drive forwards and
// backwards along the way it faces, and A and D turn it on the spot. Its barrel
// follows the mouse.
public class PlayerTank : MonoBehaviour
{
    [SerializeField] Rigidbody2D body;
    [SerializeField] Turret turret;
    [SerializeField] float moveSpeed = 3f;        // units per second
    [SerializeField] float turnSpeed = 120f;      // degrees per second

    Camera cam;

    void Awake()
    {
        cam = Camera.main;
    }

    // Every frame: the barrel turns towards the mouse.
    void Update()
    {
        Pointer pointer = Pointer.current;
        if (pointer != null)
        {
            Vector2 world = cam.ScreenToWorldPoint(pointer.position.ReadValue());
            turret.AimAt(world);
        }
    }

    // Every physics step: the tracks.
    void FixedUpdate()
    {
        // Tank controls. A phone may have no keyboard at all, so check for null first.
        float drive = 0f;
        float turn = 0f;
        Keyboard keyboard = Keyboard.current;
        if (keyboard != null)
        {
            if (keyboard.wKey.isPressed || keyboard.upArrowKey.isPressed)
            {
                drive += 1f;
            }
            if (keyboard.sKey.isPressed || keyboard.downArrowKey.isPressed)
            {
                drive -= 1f;
            }
            if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed)
            {
                turn += 1f;
            }
            if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed)
            {
                turn -= 1f;
            }
        }

        // Physics moves the tank: set how fast it goes, and how fast it turns.
        body.linearVelocity = (Vector2)transform.up * (drive * moveSpeed);
        body.angularVelocity = turn * turnSpeed;
    }
}
```

4. Drag `Player Tank` itself into the new **Turret** field: Unity picks its
   Turret component.

What's new in `PlayerTank`: a reference to the turret, `cam`, found in `Awake`,
and `Update`, which aims the turret at the pointer every frame.

### Test it

Press **Play** and move the mouse around the tank: the barrel follows it. Move the
mouse quickly in a circle: the barrel lags a little behind, turning at 360
degrees a second. Now drive and turn with the keys: the barrel keeps pointing at
the mouse, wherever the tank goes.

### Challenge

1. Set the turret's **Turn Speed** to `60`: how does a slow, heavy turret feel?
   Put it back to `360`.
2. Select `barrelBlue` in `Assets/Sprites`, set its **Pivot** back to **Center**,
   and play again. What goes wrong, and why? Put it back to **Bottom**.

# Part 2 — Fire!

## C# 5 — Components and GetComponent

**Goal:** you can get any component of a GameObject from code, reach the
components of other objects, and choose between an Inspector reference and
`GetComponent`.

### Idea — a GameObject is a box of components

Everything you see in the Inspector under a GameObject's name is a
**component**: the Transform, a Sprite Renderer, a Rigidbody, a Collider, and
your own scripts. Your script is one component among the others, and to use
another component it needs a **reference** to it. There are two ways to get one:

| Way | How | Use it when the component is… |
| --- | --- | --- |
| An Inspector reference | a `[SerializeField]` field you fill by dragging | on another object you know in advance: the camera, the game manager |
| `GetComponent<T>()` | code that finds a component of type `T` | on the **same** object, or on an object you just hit, touched or created |

### Idea — GetComponent

`GetComponent<T>()` looks through the GameObject's components and returns the
first one of type `T`. The type goes between angle brackets, as in `List<int>`.
If there's no component of that type, it returns `null`.

To try it, add an **Audio Source** component to your `Practice` object (**Add
Component → Audio → Audio Source**):

```csharp
void Start()
{
    AudioSource source = GetComponent<AudioSource>();
    Debug.Log(source);
    Debug.Log(source.volume);

    Rigidbody2D body = GetComponent<Rigidbody2D>();
    Debug.Log(body == null);
}
```

```
Practice (UnityEngine.AudioSource)
1
True
```

- Unity prints a component as its **GameObject's name** followed by its type.
- `source.volume` reads a property of the component, as if you'd looked in the
  Inspector.
- The object has no Rigidbody 2D, so `GetComponent<Rigidbody2D>()` returned
  `null`.

### Idea — get it once, in Awake

`GetComponent` searches the object every time you call it. That's fine once, but
wasteful 60 times a second in `Update`. Get it **once**, in `Awake`, and keep it
in a field:

```csharp
AudioSource source;

void Awake()
{
    source = GetComponent<AudioSource>();
}

void Update()
{
    if (Keyboard.current.mKey.wasPressedThisFrame)
    {
        source.mute = !source.mute;
    }
}
```

This is called **caching** the reference, and it's why `Awake` is the place for
"get my own components".

### Idea — making sure it's there: RequireComponent

If your script can't work without a component, say so above the class:

```csharp
[RequireComponent(typeof(AudioSource))]
public class Practice : MonoBehaviour
{
```

Now, when you add `Practice` to an object, Unity adds an Audio Source too, and
won't let anyone remove it while `Practice` is there. Your `GetComponent` can't
come back empty. (`typeof(AudioSource)` means "the type AudioSource itself".)

### Idea — components of other objects

Any GameObject or component can call `GetComponent`, so you can reach into
another object:

| You have | Its component |
| --- | --- |
| `GameObject enemy` | `enemy.GetComponent<Rigidbody2D>()` |
| `Collider2D other` in `OnTriggerEnter2D` | `other.GetComponent<Health>()` |
| `GameObject copy = Instantiate(prefab)` | `copy.GetComponent<AudioSource>()` |

When the other object **might not** have the component, check before you use
it:

```csharp
void OnTriggerEnter2D(Collider2D other)
{
    Health health = other.GetComponent<Health>();
    if (health != null)
    {
        health.TakeDamage(10);
    }
}
```

`TryGetComponent` does the same in one step, with the Try pattern and an `out`
parameter (C# 3):

```csharp
void OnTriggerEnter2D(Collider2D other)
{
    if (other.TryGetComponent(out Health health))
    {
        health.TakeDamage(10);
    }
}
```

Here `Health` stands for one of your own scripts. Your scripts are components
like any other, so `GetComponent` finds them too.

### Idea — the shortcuts you already use

Every component comes with two ready-made references:

| Shortcut | Means |
| --- | --- |
| `transform` | this object's Transform. Every GameObject has one, so Unity keeps it ready for you. |
| `gameObject` | the GameObject this component is on |

So `other.gameObject` (Level 1) is the GameObject of the collider you touched,
and `other.transform.position` is where it is.

GetComponent has relatives, for when the component is somewhere else in the
family:

| Method | Looks in |
| --- | --- |
| `GetComponent<T>()` | this GameObject |
| `GetComponentInChildren<T>()` | this GameObject, then its children |
| `GetComponentInParent<T>()` | this GameObject, then its parent, and its parent… |
| `GetComponents<T>()` | this GameObject, and returns **all** of them in an array |

> **Note:** Unity can also search the **whole scene**, with
> `GameObject.Find("Player")` or `FindAnyObjectByType<GameManager>()`. They're
> slow, and `Find` breaks as soon as someone renames the object. Prefer
> Inspector references, and never search the scene in `Update`.

### Do it

1. Add an Audio Source to your `Practice` object. In `Start()`, get it and print
   its `volume` and `loop`. Change them in the Inspector and run again.
2. Print `GetComponent<Transform>() == transform`. What does it tell you?
3. Get a `Rigidbody2D` (or a `Rigidbody`) that isn't there, then use it anyway:
   print `body.mass`. Read the error: C# 15 explains it.
4. Cache the Audio Source in `Awake`, and make the **M** key mute and unmute it
   in `Update`.

### Challenge

Make a second GameObject called `Speaker` with an Audio Source. Give `Practice` a
field `[SerializeField] GameObject speaker;` and drag `Speaker` into it. In
`Start()`, get the speaker's Audio Source with `GetComponent` and set its volume
to `0.25f`. Press Play and check the speaker's Inspector.

## C# 6 — Properties and Constructors

**Goal:** you can write a class whose fields are protected by properties, and give
every new object its starting values through a constructor.

### Idea — a class you can trust

In Level 1 you wrote a small class with public fields:

```csharp
public class Spaceship
{
    public string shipName;
    public int fuel;
}
```

It works, but **any** script can do anything to it: `ship.fuel = -500;` compiles
without a murmur. A good class protects its data, so its objects can never get
into a state that makes no sense. C# gives you two tools for that:

| Tool | Answers the question |
| --- | --- |
| **Property** | "Who may read this value, and who may change it?" |
| **Constructor** | "What values must every new object start with?" |

### Idea — properties

A **property** looks like a field from the outside, but it controls access:

```csharp
public class Player
{
    public int Score { get; private set; }   // anyone can read it, only Player can change it

    public void AddPoints(int points)
    {
        Score += points;
    }
}
```

| Part | Meaning |
| --- | --- |
| `public int Score` | Other scripts can see `Score`. Properties use **PascalCase**, like methods. |
| `get;` | Reading is allowed (with the property's access: public here) |
| `private set;` | Changing it is only allowed **inside** this class |

```csharp
Player player = new Player();
player.AddPoints(10);
player.AddPoints(5);
Debug.Log(player.Score);
```

```
15
```

Outside the class, `player.Score = 999;` is now an error: *The property or indexer
'Player.Score' cannot be used in this context because the set accessor is
inaccessible* (CS0272). The only way to change the score is `AddPoints`, so the
class decides the rules.

### Idea — a property that works something out

A property can also **calculate** its value every time it's read. It has a `get`
with a body, and no `set`:

```csharp
public class Player
{
    public int Score { get; private set; }
    public int Lives { get; private set; } = 3;

    public bool IsAlive
    {
        get { return Lives > 0; }
    }

    public void LoseLife()
    {
        Lives--;
    }
}
```

```csharp
Player player = new Player();
Debug.Log(player.IsAlive);
player.LoseLife();
player.LoseLife();
player.LoseLife();
Debug.Log(player.IsAlive);
```

```
True
False
```

`IsAlive` is never stored: it's worked out from `Lives` when you ask. So it can
never be out of date. Note `= 3` after `Lives { get; private set; }`: a property
can have a starting value, like a field.

### Idea — constructors

A **constructor** is a special method that runs **once**, when an object is
built with `new`. It has the **same name as the class** and **no return type**.
Its parameters are the values every new object needs:

```csharp
public class Ticket
{
    public string Owner { get; private set; }
    public int Seat { get; private set; }

    // The constructor: runs once, when the ticket is created
    public Ticket(string owner, int seat)
    {
        Owner = owner;
        Seat = seat;
    }
}
```

```csharp
Ticket mine = new Ticket("Lina", 12);
Ticket yours = new Ticket("Omar", 14);
Debug.Log(mine.Owner + " sits in seat " + mine.Seat);
Debug.Log(yours.Owner + " sits in seat " + yours.Seat);
```

```
Lina sits in seat 12
Omar sits in seat 14
```

Now it's impossible to make a ticket without an owner and a seat:
`new Ticket()` is an error, because the only constructor needs two arguments.

### Idea — this

When a parameter has the same name as a field or property, `this.` means "the
one that belongs to this object":

```csharp
public class Ticket
{
    int seat;

    public Ticket(int seat)
    {
        this.seat = seat;   // this.seat is the field; seat is the parameter
    }
}
```

> **Watch out:** a constructor is only for **plain C# classes** like `Ticket` and
> `Player` here. A `MonoBehaviour` never has a constructor you call: Unity builds
> it when the component is added. Use `Awake()` or `Start()` for its setup
> instead.

### Idea — when to use what

| You want… | Use |
| --- | --- |
| a value other scripts can read but not change | `public int Score { get; private set; }` |
| a value worked out from other values | a property with only a `get` body |
| a value tuned in the Inspector | `[SerializeField] float speed = 5f;` (a field, not a property) |
| every new object to start with the right values | a constructor |

> **Note:** Unity shows **fields** in the Inspector, not properties. Keep
> `[SerializeField]` fields for tuning, and use properties for values other
> scripts read.

### Do it

1. Write a class `BankAccount` with a property `Balance` (public get, private set),
   a method `Deposit(int amount)`, and a method `Withdraw(int amount)` that only
   takes the money out if the balance is big enough. Test it in `Start()`.
2. Give `BankAccount` a constructor that takes the owner's name and a starting
   balance, and a computed property `IsEmpty`.
3. Try `account.Balance = 1000000;` from `Start()`, and read the error.

### Challenge

Write a class `Timer` with a constructor that takes a duration in seconds, a
method `Tick(float seconds)` that counts down, and two computed properties:
`TimeLeft` (never below 0) and `IsFinished`.

## Chapter 4 — Tracks and Shells

**Goal:** **Space** or a click fires a shell from the tip of the barrel, twice a
second at most. Shells fly straight, and burst on the first solid thing they
touch. And your tank is rebuilt from components that the enemy tanks can share.

### Idea — one tank, several components

Your tank's driving is in `PlayerTank`, and the enemy tanks will need exactly the
same driving. Instead of writing it twice, each job becomes a component of its
own (C# 5), and every tank gets the same set:

| Component | Its job | Player's tank | Enemy tanks |
| --- | --- | --- | --- |
| `Tracks` | drives and turns the tank | yes | yes |
| `Turret` | turns the barrel, and fires | yes | yes |
| `Health` | hit points (Chapter 5) | yes | yes |
| `PlayerTank` | the brain: reads your keys and the mouse | yes | — |
| `EnemyTank` | the brain: decides by itself (Chapter 5) | — | yes |

`PlayerTank` finds its tank's `Tracks` and `Turret` in `Awake`, with
`GetComponent`, and `[RequireComponent]` makes sure they're there.

### Idea — the tracks

`Tracks` has one method you already know how to use: `Drive(driveAmount,
turnAmount)`, with the numbers from Chapter 2. It doesn't move anything; it
remembers what to do, and `FixedUpdate` does it on the physics clock. `Stop()` is
`Drive(0f, 0f)`.

The brain calls `tracks.Stop()` at the start of every frame, then `Drive` with
the keys held down: no key, no movement.

### Idea — a press is a moment

Firing needs a key **press**, not a key held down:

| Code | Is `true` |
| --- | --- |
| `keyboard.spaceKey.isPressed` | in every frame while Space is held down |
| `keyboard.spaceKey.wasPressedThisFrame` | only in the frame when Space goes down |
| `pointer.press.wasPressedThisFrame` | only in the frame when the mouse button or a finger goes down |

A moment can fall between two physics steps, and `FixedUpdate` would miss it. So
presses are read in `Update`, which runs every frame. That's why `PlayerTank` now
reads the keyboard in `Update`, and leaves `FixedUpdate` to `Tracks`.

### Idea — reloading

The turret remembers **when** it may fire next, `nextShotTime`, and a property
works out whether that time has come (C# 6):

```csharp
public bool IsLoaded
{
    get { return Time.time >= nextShotTime; }
}
```

`Fire()` fires only if the turret is loaded, and returns a `bool`
(C# 3): `true` if it fired, `false` if it was still reloading. For
now, nothing uses the answer. In Chapter 11, your tank counts its shots with it.

### Idea — a shell

A shell is a prefab with a **Dynamic** Rigidbody 2D and a small **trigger**
collider. `Instantiate(shellPrefab, muzzle.position, barrel.rotation)` makes it
at the tip of the barrel, turned like the barrel, so its `transform.up` points
where the barrel points. In `Start`, the shell sets its `linearVelocity` once,
and physics carries it from there, in a straight line.

A trigger doesn't bounce off anything, but it tells its script what it touches:
Unity calls `OnTriggerEnter2D`. The shell flies on through other triggers, like
other shells, and bursts on anything solid: a wall, a tree, a barrel or a tank.

### Do it — the tracks

1. Create `Tracks`:

```csharp:Tracks.cs
using UnityEngine;

// A tank's tracks: they drive it along the way it faces, and turn it on the
// spot. The player's tank and the enemy tanks all use them; their own scripts
// decide where to go.
[RequireComponent(typeof(Rigidbody2D))]
public class Tracks : MonoBehaviour
{
    [SerializeField] float moveSpeed = 3f;        // units per second
    [SerializeField] float turnSpeed = 120f;      // degrees per second

    Rigidbody2D body;
    float drive = 0f;
    float turn = 0f;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // drive: 1 forwards, -1 backwards, 0 stop. turn: 1 left, -1 right, 0 straight on.
    public void Drive(float driveAmount, float turnAmount)
    {
        drive = Mathf.Clamp(driveAmount, -1f, 1f);
        turn = Mathf.Clamp(turnAmount, -1f, 1f);
    }

    // Turns towards a point, and drives forwards once it's facing roughly that way.
    public void DriveTowards(Vector2 point)
    {
        Vector2 toPoint = point - body.position;
        if (toPoint.magnitude < 0.4f)
        {
            Stop();    // close enough: it has arrived
            return;
        }

        // The angle is more than 0 when the point is to the left. The tank turns
        // fully while it's 30° or more off, and drives only once it's within 45°.
        float angle = Vector2.SignedAngle(transform.up, toPoint);
        float turnAmount = angle / 30f;
        float driveAmount = Mathf.Abs(angle) < 45f ? 1f : 0f;
        Drive(driveAmount, turnAmount);
    }

    public void Stop()
    {
        Drive(0f, 0f);
    }

    // Physics moves the tank, on the physics clock.
    void FixedUpdate()
    {
        body.linearVelocity = (Vector2)transform.up * (drive * moveSpeed);
        body.angularVelocity = turn * turnSpeed;
    }
}
```

2. Select `Player Tank`, and **Add Component → Tracks**. Leave **Move Speed** at
   `3` and **Turn Speed** at `120`.

Read it before you move on:

- `[RequireComponent(typeof(Rigidbody2D))]`, and the body found in `Awake`
  (C# 5).
- `Drive` keeps both numbers between −1 and 1 with `Mathf.Clamp`, so no brain can
  make a tank faster than its `moveSpeed`.
- `DriveTowards(point)` is for later: the enemy tanks use it in Chapter 5, and
  your finger in Chapter 9. It turns the tank towards the point, and only drives
  forwards once the tank is facing roughly that way.
- `Mathf.Abs(angle) < 45f ? 1f : 0f` is Level 1's one-line if / else, `?:`:
  `condition ? a : b` is `a` when the condition is `true`, and `b` when it's
  `false`.

### Do it — the shell

1. Drag `bulletBlue` into the Hierarchy, rename it `Player Shell`, and set its
   **Order in Layer** to `3`.
2. **Add Component → Rigidbody 2D**: **Body Type** **Dynamic**, **Gravity Scale**
   `0`.
3. **Add Component → Circle Collider 2D**: tick **Is Trigger**, and set the
   **Radius** to `0.08`.
4. Create `Shell`, and attach it to `Player Shell`:

```csharp
using UnityEngine;

// A tank shell. It flies straight ahead, and bursts on the first solid thing it
// touches.
[RequireComponent(typeof(Rigidbody2D))]
public class Shell : MonoBehaviour
{
    [SerializeField] float speed = 9f;
    [SerializeField] float lifetime = 2f;

    void Start()
    {
        // transform.up is the way the shell's sprite points
        GetComponent<Rigidbody2D>().linearVelocity = transform.up * speed;
        Destroy(gameObject, lifetime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.isTrigger)
        {
            return;    // other shells don't stop a shell
        }

        Destroy(gameObject);
    }
}
```

5. Drag `Player Shell` into `Assets/Prefabs`, then delete it from the Hierarchy.

### Do it — the muzzle

The shells should come out of the tip of the barrel, not the middle of the tank.
Right-click `Barrel` (the child of `Player Tank`) → **Create Empty**, rename it
`Muzzle`, and set its **Position** to `(0, 0.55, 0)`: just beyond the tip of the
barrel, which is 0.5 units long. As a child of the barrel, it turns with it.

### Do it — the turret fires

Replace `Turret` with this version:

```csharp
using UnityEngine;

// A tank's turret. The barrel turns towards a point, a little at a time, and
// fires shells from its tip, no faster than it can reload. The player's tank
// and the enemy tanks all use it.
public class Turret : MonoBehaviour
{
    [SerializeField] Transform barrel;
    [SerializeField] Transform muzzle;
    [SerializeField] GameObject shellPrefab;
    [SerializeField] float turnSpeed = 180f;      // degrees per second
    [SerializeField] float reloadTime = 0.5f;     // seconds between two shots

    float nextShotTime = 0f;

    public bool IsLoaded
    {
        get { return Time.time >= nextShotTime; }
    }

    // Turns the barrel a step towards the point. Call it every frame.
    public void AimAt(Vector2 point)
    {
        Vector2 direction = point - (Vector2)barrel.position;
        float wanted = Vector2.SignedAngle(Vector2.up, direction);
        float step = turnSpeed * Time.deltaTime;
        float angle = Mathf.MoveTowardsAngle(barrel.eulerAngles.z, wanted, step);
        barrel.rotation = Quaternion.Euler(0f, 0f, angle);
    }

    // Fires a shell, if the turret has reloaded. Returns whether it fired.
    public bool Fire()
    {
        if (!IsLoaded)
        {
            return false;
        }

        Instantiate(shellPrefab, muzzle.position, barrel.rotation);
        nextShotTime = Time.time + reloadTime;
        return true;
    }
}
```

What's new: the muzzle, the shell prefab, the reload time, `nextShotTime`, the
`IsLoaded` property, and `Fire`.

Select `Player Tank`. In its **Turret**, drag `Muzzle` into **Muzzle** and the
`Player Shell` prefab into **Shell Prefab**. Leave **Reload Time** at `0.5`.

### Do it — the new brain

Replace `PlayerTank` with this version:

```csharp
using UnityEngine;
using UnityEngine.InputSystem;

// The player's tank. W and S drive, A and D turn, the barrel follows the mouse,
// and Space or a click fires.
[RequireComponent(typeof(Tracks))]
[RequireComponent(typeof(Turret))]
public class PlayerTank : MonoBehaviour
{
    Tracks tracks;
    Turret turret;
    Camera cam;

    void Awake()
    {
        tracks = GetComponent<Tracks>();
        turret = GetComponent<Turret>();
        cam = Camera.main;
    }

    void Update()
    {
        tracks.Stop();
        ReadKeyboard();
        ReadPointer();
    }

    // Tank controls: forwards and backwards along the way it faces, and turning
    // on the spot. A phone may have no keyboard at all, so check for null first.
    void ReadKeyboard()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard == null)
        {
            return;
        }

        float drive = 0f;
        float turn = 0f;
        if (keyboard.wKey.isPressed || keyboard.upArrowKey.isPressed)
        {
            drive += 1f;
        }
        if (keyboard.sKey.isPressed || keyboard.downArrowKey.isPressed)
        {
            drive -= 1f;
        }
        if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed)
        {
            turn += 1f;
        }
        if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed)
        {
            turn -= 1f;
        }
        tracks.Drive(drive, turn);

        if (keyboard.spaceKey.wasPressedThisFrame)
        {
            Fire();
        }
    }

    // The mouse: the barrel aims at it, and a click fires.
    void ReadPointer()
    {
        Pointer pointer = Pointer.current;
        if (pointer == null)
        {
            return;
        }

        Vector2 world = cam.ScreenToWorldPoint(pointer.position.ReadValue());
        turret.AimAt(world);

        if (pointer.press.wasPressedThisFrame)
        {
            Fire();
        }
    }

    void Fire()
    {
        turret.Fire();
    }
}
```

Its old fields, **Body**, **Turret**, **Move Speed** and **Turn Speed**, disappear
from the Inspector: the brain finds the tank's components by itself now, and the
speeds belong to `Tracks`.

Read it before you move on:

- The two `[RequireComponent]` lines, and `Awake`, which finds the tracks and the
  turret with `GetComponent`.
- `Update` starts every frame by stopping the tracks. Then `ReadKeyboard` and
  `ReadPointer`, two methods of its own, read the keys and the mouse.
- `ReadKeyboard` uses `return` to stop early when there's no keyboard: the rest
  of the method only runs when there is one.
- **Space** and a click both call the tank's own `Fire`, which asks the turret to
  fire.

### Test it

Press **Play**. Drive, aim with the mouse, and fire with **Space** or a click:
the shells fly from the tip of the barrel, wherever it points, and burst on the
walls, the trees and the barrels. Hold **Space** down: one shell, not a stream.
Press it as fast as you can: never more than two shells a second. A shell that
hits nothing disappears after 2 seconds; watch the `Player Shell(Clone)` objects
come and go in the Hierarchy.

### Challenge

Make a machine gun: set the turret's **Reload Time** to `0.1`. Hold **Space**
down: why doesn't it keep firing? Change one word in `ReadKeyboard` so that it
does. Then put both back.

## C# 7 — static, const and readonly

**Goal:** you can decide whether a value belongs to each object or to the whole
class, and lock the values that must never change.

### Idea — one copy for everyone: static

Every object built from a class gets its **own copy** of each field: two ships,
two `fuel` values. A **static** member is different: it belongs to the **class
itself**, so there's exactly **one** copy, shared by every object.

```csharp
public class Coin
{
    public int Value { get; private set; }             // each coin has its own
    public static int CoinsMade { get; private set; }  // one number for ALL coins

    public Coin(int value)
    {
        Value = value;
        CoinsMade++;
    }
}
```

```csharp
Coin small = new Coin(1);
Coin big = new Coin(10);
Coin gold = new Coin(50);
Debug.Log(big.Value);
Debug.Log(Coin.CoinsMade);
```

```
10
3
```

Each coin remembers its own `Value`, but every constructor added 1 to the same
`CoinsMade`. You reach a static member through the **class name**:
`Coin.CoinsMade`. Writing `big.CoinsMade` is an error (CS0176), because the
number doesn't belong to `big`.

### Idea — you've used static members all along

Every time you wrote a class name, a dot and a member, you used a static member.
Nobody writes `new Time()`: there's one clock for the whole game, so its members
are static.

| You wrote | Class | Static member |
| --- | --- | --- |
| `Debug.Log("Hi")` | `Debug` | the method `Log` |
| `Random.Range(0, 3)` | `Random` | the method `Range` |
| `Time.deltaTime` | `Time` | the property `deltaTime` |
| `Keyboard.current` | `Keyboard` | the property `current` |
| `Quaternion.identity` | `Quaternion` | the property `identity` |

### Idea — static methods

A static method belongs to the class too, so you call it without making an
object. It's the right choice for a helper that only needs its parameters:

```csharp
public class Temperature
{
    public static float ToFahrenheit(float celsius)
    {
        return celsius * 9 / 5 + 32;
    }
}
```

```csharp
Debug.Log(Temperature.ToFahrenheit(100));
Debug.Log(Temperature.ToFahrenheit(-40));
```

```
212
-40
```

A static method has no object of its own, so it **can't use the object's
fields**. A normal (non-static) field inside a static method gives error CS0120:
*An object reference is required for the non-static field, method, or property*.

A class that only holds static members can be marked `static` itself:
`public static class Temperature`. Then nobody can build an object from it by
mistake.

> **Watch out:** a static value can survive from one **Play** to the next. A
> Unity 6 project can skip reloading your scripts when you press Play, so that
> Play starts faster: check **Edit → Project Settings → Editor → Enter Play Mode
> Settings**. If it says **Reload Scene only**, press Play twice with the coin
> example above and the second run says `6`, not `3`. Give every static value its
> starting value yourself when the game starts, in `Awake()` or `Start()`.

### Idea — const: fixed when you write the code

`const` makes a value that can **never** change. You must give it a value
straight away, and the value must be known when you write the code: a number, a
`bool` or a `string`.

```csharp
public class GameRules
{
    public const int MaxLives = 3;
    public const float Gravity = -9.81f;
    public const string PlayerTag = "Player";
}
```

```csharp
Debug.Log(GameRules.MaxLives);
Debug.Log(GameRules.PlayerTag);
```

```
3
Player
```

- A constant is automatically static: you read it through the class name,
  `GameRules.MaxLives`.
- Constants are named in **PascalCase**: `MaxLives`, not `maxLives`.
- `GameRules.MaxLives = 5;` is an error: *The left-hand side of an assignment
  must be a variable, property or indexer* (CS0131).

Constants replace **magic numbers**: numbers in the middle of the code that
nobody can explain a week later. `if (lives > 3)` hides what the 3 means;
`if (lives > MaxLives)` says it. Unity has constants of its own: `Mathf.PI` is
one.

### Idea — readonly: set once, when the object is made

A `readonly` field gets its value where it's declared **or in the constructor**,
and never again. Use it for values that are only known when the game runs, or
for types a `const` can't hold, like arrays:

```csharp
public class Race
{
    public readonly string trackName;
    public readonly int[] lapTimes = new int[3];

    public Race(string trackName)
    {
        this.trackName = trackName;   // allowed: we're in the constructor
    }

    public void Rename(string newName)
    {
        trackName = newName;          // error CS0191: trackName is readonly
    }
}
```

A readonly **array** can't be swapped for a different array, but its
**elements** can still change:

```csharp
Race race = new Race("Desert");
race.lapTimes[0] = 62;         // fine: changing an element
race.lapTimes = new int[5];    // error CS0191: can't replace a readonly array
```

The same goes for a readonly list: you can add to it and remove from it, but you
can't replace it with a new list.

### Idea — const or readonly?

| | `const` | `readonly` |
| --- | --- | --- |
| Value set | when you write the code | where it's declared, or in the constructor |
| Types | numbers, `bool`, `string` | any type |
| Belongs to | the class (always static) | each object, unless you add `static` |
| Example | `const int MaxLives = 3;` | `readonly int[] lapTimes = new int[3];` |

`static readonly` gives you one shared value that's set once and can be of any
type, like a colour: `static readonly Color Gold = new Color(1f, 0.82f, 0.4f);`.

### Idea — [SerializeField] or public: the whole picture

The certification exam likes this question: *who can see and change this
value?* Here are all the combinations you know now:

| You write | In the Inspector? | Other scripts can read it? | Other scripts can change it? |
| --- | --- | --- | --- |
| `float speed;` | No | No | No |
| `public float speed;` | Yes | Yes | Yes |
| `[SerializeField] float speed;` | Yes | No | No |
| `public float Speed { get; private set; }` | No | Yes | No |
| `public const float Speed = 5f;` | No | Yes | No: nobody can |
| `public static float speed;` | No | Yes | Yes |

> **Note:** Unity never shows `static` or `const` fields in the Inspector, and
> never saves them with the scene.

### Idea — the best of both

You'll see this pattern often: a private field you tune in the Inspector, plus a
property that lets other scripts **read** it without changing it.

```csharp
[SerializeField] int maxHealth = 100;   // tuned in the Inspector

public int MaxHealth
{
    get { return maxHealth; }            // other scripts can only read it
}
```

### Do it

1. Write a plain class `Enemy` with a static property `Count` (public get,
   private set) that the constructor increases. Make four enemies in `Start()`
   and print `Enemy.Count`.
2. Add `public const int MaxEnemies = 3;` to `Enemy`. In the constructor, print
   `"Too many enemies!"` when `Count` goes above `MaxEnemies`.
3. Add a static method `ResetCount()` that sets `Count` back to 0, and call
   `Enemy.ResetCount();` at the very start of `Start()`. Press Play twice: the
   count starts from 0 every time.
4. Try `Enemy.MaxEnemies = 10;`, read the error, then remove the line.

### Challenge

Write a class `Level` with a `readonly string levelName` set by the constructor,
a static property `LevelsCreated`, and a constant `MaxLevels = 10`. Make three
levels, print each name, then print how many levels were created and how many
more you're allowed to make.

## C# 8 — Coroutines and Timers

**Goal:** you can make something happen after a delay, or step by step over
time, with a timer or a coroutine.

### Idea — you can't wait inside Update

`Update` must finish quickly: Unity can't draw the next frame until it does. So
you can't write "wait two seconds" in the middle of it. Games wait in one of two
ways:

| Tool | How it waits |
| --- | --- |
| a **timer** | a number that counts time, checked every frame in `Update` |
| a **coroutine** | a special method that can pause itself, and carry on later |

### Idea — timers

You met the first kind of timer in Level 1's Spawner: add `Time.deltaTime` every
frame, and act when it's big enough.

```csharp
float timer = 0f;

void Update()
{
    timer += Time.deltaTime;
    if (timer >= 2f)
    {
        Debug.Log("Two seconds passed");
        timer = 0f;
    }
}
```

The second kind uses `Time.time`, the number of seconds since the game started.
Remember **when** something is next allowed, and compare. It's perfect for a
**cooldown**, like a weapon that can't fire more than twice a second:

```csharp
[SerializeField] float cooldown = 0.5f;
float nextShotTime = 0f;

void Update()
{
    if (Keyboard.current.spaceKey.wasPressedThisFrame && Time.time >= nextShotTime)
    {
        Debug.Log("Fire!");
        nextShotTime = Time.time + cooldown;
    }
}
```

### Idea — a coroutine: a method that can wait

```csharp
using System.Collections;
using UnityEngine;

public class Practice : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Countdown());
        Debug.Log("Start is finished");
    }

    IEnumerator Countdown()
    {
        Debug.Log("3");
        yield return new WaitForSeconds(1f);
        Debug.Log("2");
        yield return new WaitForSeconds(1f);
        Debug.Log("1");
        yield return new WaitForSeconds(1f);
        Debug.Log("Go!");
    }
}
```

```
3
Start is finished
2
1
Go!
```

Look at the order. `StartCoroutine` runs `Countdown` straight away, **up to its
first `yield`**: that prints `3`. There the coroutine pauses, and `Start` carries
on and prints its message. One second later, Unity wakes the coroutine up, it
prints `2`, and pauses again, and so on.

| Part | Meaning |
| --- | --- |
| `IEnumerator Countdown()` | a coroutine's return type is always `IEnumerator` (it needs `using System.Collections;`) |
| `StartCoroutine(Countdown());` | how you start one |
| `yield return new WaitForSeconds(1f);` | pause here for one second |
| `yield return null;` | pause here until the next frame |

> **Watch out:** calling `Countdown();` without `StartCoroutine` does
> **nothing**: no error and no countdown. It's one of the most common coroutine
> bugs.

### Idea — loops that wait

A coroutine can wait inside a loop, which makes sequences easy to write. This one
spawns a wave of enemies, one every 0.8 seconds:

```csharp
IEnumerator SpawnWave(int count)
{
    for (int i = 1; i <= count; i++)
    {
        Debug.Log("Enemy " + i);
        yield return new WaitForSeconds(0.8f);
    }
    Debug.Log("Wave complete");
}
```

```csharp
StartCoroutine(SpawnWave(3));
```

```
Enemy 1
Enemy 2
Enemy 3
Wave complete
```

A coroutine can take parameters like any method. It can even loop forever with
`while (true)`, as long as the loop has a `yield` inside, so it pauses every time
round. A `while (true)` loop **without** a `yield` freezes Unity.

### Idea — stopping a coroutine

| Code | Stops |
| --- | --- |
| `Coroutine blink = StartCoroutine(Blink());` then `StopCoroutine(blink);` | that one coroutine |
| `StopAllCoroutines();` | every coroutine this script started |
| `yield break;` inside the coroutine | the coroutine itself, from the inside |

Coroutines also stop when their GameObject is deactivated or destroyed. They do
**not** stop when you only disable the script.

### Idea — timer or coroutine?

| A timer in Update fits… | A coroutine fits… |
| --- | --- |
| something that repeats forever with a changing delay | a sequence: do, wait, do, wait |
| cooldowns: "am I allowed to fire yet?" | "in two seconds, move to the next level" |
| values you want to see and change every frame | a story you want to read from top to bottom |

> **Note:** `WaitForSeconds` counts game time. If the game is paused with
> `Time.timeScale = 0;`, coroutines waiting with `WaitForSeconds` pause too.
> `WaitForSecondsRealtime` keeps counting real seconds.

> **Note:** Unity also has `Invoke("Explode", 2f)`, which calls a method **by
> its name** after a delay. You'll see it in older code and exam questions. A
> typo in the name is only noticed when the game runs, so this book uses
> coroutines.

### Do it

1. Write a coroutine `Countdown(int from)` that prints the numbers from `from`
   down to 1, one per second, then prints `"Liftoff!"`. Start it from `Start()`
   with 5.
2. Add a `Debug.Log` right after the `StartCoroutine` line. Predict where it
   appears in the Console, then run it.
3. Replace `StartCoroutine(Countdown(5));` with `Countdown(5);`. What happens?
4. Add the cooldown example, and tap **Space** as fast as you can: you never get
   more than two `"Fire!"` messages a second.

### Challenge

Write a traffic light coroutine that loops forever with `while (true)`: green
for 3 seconds, yellow for 1, red for 3, and round again. Keep the running
coroutine in a field, and stop it when the **S** key is pressed.

## Chapter 5 — Enemy Tanks

**Goal:** red enemy tanks drive around the arena by themselves, to a new place
every few seconds. Your shells hurt them: two hits, and one is gone.

### Idea — the size of the arena, in one place

Several scripts need to know how big the arena is: the enemies, to choose where
to go, and, in Chapter 10, the camera. The numbers go in one place:
`ArenaBounds`, a **static class** (C# 7). Its sizes are `const`s, and
its method `RandomPoint()` is `static`, so any script can call
`ArenaBounds.RandomPoint()` without making an object first. There's only one
arena, so there's nothing to make.

### Idea — health you can trust

Every tank has hit points, so `Health` is a component too. Its `Current` value is
a property with a `private set` (C# 6): every script can read it,
but only `Health` itself can change it, through its own methods. Nobody can set a
tank's health to 1000 by mistake.

| Member | Is |
| --- | --- |
| `Current` | the hit points left: anyone can read it, only `Health` can set it |
| `Max` | the starting hit points, `maxHealth` |
| `IsDead` | `true` when `Current` has reached 0 |
| `TakeDamage(amount)` | takes `amount` away, but never goes below 0 |

### Idea — hurting what you hit

The shell asks whatever it hit: "do you have a `Health`?"
`other.TryGetComponent(out Health health)` (C# 5). A tank does, and
takes the shell's `damage`; a wall doesn't, and only stops the shell. The shell
doesn't need to know what a tank is.

### Idea — an enemy's brain

`EnemyTank` is the enemies' brain. Like `PlayerTank`, it uses the tank's `Tracks`
and `Turret`; it has no keys to read, so it decides by itself:

- A coroutine, `Think`, runs for as long as the tank is alive: it picks a random
  point in the arena, waits `thinkTime` seconds, and picks another, for ever
  (C# 8).
- Every frame, `Update` drives towards the latest point with
  `tracks.DriveTowards`, and keeps the barrel pointing straight ahead.
- When its `Health` says it's dead, the tank destroys itself.

### Idea — driving towards a point

`DriveTowards`, in `Tracks`, works like a driver who can only turn and go:

```csharp
float angle = Vector2.SignedAngle(transform.up, toPoint);
```

`angle` is how far the point is from straight ahead: positive to the left,
negative to the right, like the barrel in Chapter 3. `angle / 30f` turns hard
while the point is more than 30 degrees off (`Drive` cuts anything bigger down
to 1), and more gently as the tank lines up. The tank only drives forwards once
it's less than 45 degrees off, and stops when it's within 0.4 units of the point.

The enemies aren't clever: they drive straight at their point, and if a wall is
in the way, they push against it until they choose another. That's good enough
for a tank, and you'll give them eyes in Chapter 7.

### Do it — the scripts

1. Create `ArenaBounds`, and replace everything in it with this:

```csharp:ArenaBounds.cs
using UnityEngine;

// The size of the arena, for every script that needs it. A static class: there's
// only one arena, so nobody needs to make an object to ask about it.
public static class ArenaBounds
{
    public const float HalfWidth = 12f;     // the ground goes from x = -12 to 12...
    public const float HalfHeight = 8f;     // ...and from y = -8 to 8
    const float Margin = 2f;                // keeps random points away from the walls

    // A random point inside the arena, not too close to its edge.
    public static Vector2 RandomPoint()
    {
        float x = Random.Range(-HalfWidth + Margin, HalfWidth - Margin);
        float y = Random.Range(-HalfHeight + Margin, HalfHeight - Margin);
        return new Vector2(x, y);
    }
}
```

   You can't attach `ArenaBounds` to anything, and you don't need to: other
   scripts use it by its name.

2. Create `Health`:

```csharp
using UnityEngine;

// Hit points, for anything that can be shot: the player's tank and the enemy
// tanks. Other scripts read it through its properties, but only its own methods
// can change it.
public class Health : MonoBehaviour
{
    [SerializeField] int maxHealth = 3;

    public int Current { get; private set; }

    public int Max
    {
        get { return maxHealth; }
    }

    public bool IsDead
    {
        get { return Current <= 0; }
    }

    void Awake()
    {
        Current = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        Current = Mathf.Max(Current - amount, 0);
    }
}
```

3. Replace `Shell` with this version:

```csharp
using UnityEngine;

// A tank shell. It flies straight ahead and bursts on the first solid thing it
// touches: a wall only stops it, a tank loses health.
[RequireComponent(typeof(Rigidbody2D))]
public class Shell : MonoBehaviour
{
    [SerializeField] float speed = 9f;
    [SerializeField] float lifetime = 2f;
    [SerializeField] int damage = 1;

    void Start()
    {
        // transform.up is the way the shell's sprite points
        GetComponent<Rigidbody2D>().linearVelocity = transform.up * speed;
        Destroy(gameObject, lifetime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.isTrigger)
        {
            return;    // other shells don't stop a shell
        }

        if (other.TryGetComponent(out Health health))
        {
            health.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
```

   What's new: a comment that says what happens now, the `damage` field, and the
   `if` that hurts anything with a `Health`.

4. Create `EnemyTank`:

```csharp
using System.Collections;
using UnityEngine;

// An enemy tank. For now, it drives around the arena to random places.
[RequireComponent(typeof(Tracks))]
[RequireComponent(typeof(Turret))]
[RequireComponent(typeof(Health))]
public class EnemyTank : MonoBehaviour
{
    [SerializeField] float thinkTime = 3f;        // seconds between two new places to go

    Tracks tracks;
    Turret turret;
    Vector2 destination;

    public Health Health { get; private set; }

    void Awake()
    {
        tracks = GetComponent<Tracks>();
        turret = GetComponent<Turret>();
        Health = GetComponent<Health>();
        destination = transform.position;
    }

    void Start()
    {
        StartCoroutine(Think());
    }

    // Every few seconds, choose somewhere new to go.
    IEnumerator Think()
    {
        while (true)
        {
            destination = ArenaBounds.RandomPoint();
            yield return new WaitForSeconds(thinkTime);
        }
    }

    void Update()
    {
        if (Health.IsDead)
        {
            Destroy(gameObject);
            return;
        }

        // Drive on, with the barrel pointing straight ahead.
        tracks.DriveTowards(destination);
        turret.AimAt((Vector2)transform.position + (Vector2)transform.up);
    }
}
```

Read `EnemyTank` before you move on:

- Three `[RequireComponent]` lines: adding `EnemyTank` to an object adds
  `Tracks`, `Turret` and `Health` too, if they're missing.
- `Health` is a property the other scripts can read, but only the tank can set.
- `Start` starts the coroutine. `Think` loops `while (true)`, but every lap
  waits, so it never freezes the game.
- In `Update`, `return` ends the frame's work early for a tank that's being
  destroyed. `(Vector2)transform.position + (Vector2)transform.up` is a point
  just in front of the tank: aiming there points the barrel straight ahead.

### Do it — the light tank

1. Drag `tankRed` (Kenney's red is nearly orange) into the Hierarchy (not into
   `Arena`). Rename it `Light Tank`, set its **Position** to `(-9, 3, 0)`, and its
   **Order in Layer** to `1`.
2. Give it a **Rigidbody 2D** and a **Circle Collider 2D**, set exactly like the
   player's: **Dynamic**, **Gravity Scale** `0`, **Interpolate** **Interpolate**,
   and **Radius** `0.35`.
3. Drag `barrelRed` onto `Light Tank`. Rename it `Barrel`, with **Position**
   `(0, 0, 0)` and **Order in Layer** `2`. Right-click it → **Create Empty**,
   named `Muzzle`, at `(0, 0.55, 0)`.
4. Select `Light Tank`, and **Add Component → EnemyTank**. Unity adds **Tracks**,
   **Turret** and **Health** as well. Set them:

| Component | Settings |
| --- | --- |
| **Tracks** | **Move Speed** `2`, **Turn Speed** `90` |
| **Turret** | **Barrel**: its `Barrel`; **Muzzle**: its `Muzzle`; **Turn Speed** `120`; **Reload Time** `1.6`. Leave **Shell Prefab** empty until Chapter 7. |
| **Health** | **Max Health** `2` |
| **EnemyTank** | **Think Time** `3` |

5. Drag `Light Tank` into `Assets/Prefabs`. Leave it in the scene, and drag a
   second `Light Tank` from `Assets/Prefabs` into the scene, at `(9, -3, 0)`.

### Test it

Press **Play**. The two red tanks set off, each to a random place, and choose a
new one every 3 seconds. Watch one turn on the spot until it faces its new
destination, then drive. Chase one and fire: the first hit does nothing you can
see, and the second destroys it. Drive into one: tanks push each other around,
because both are Dynamic bodies.

When you've seen it all, delete both light tanks from the Hierarchy (the prefab
stays in `Assets/Prefabs`): from Chapter 6, they arrive by themselves.

### Challenge

1. Where is each tank going? At the end of `EnemyTank.Update`, draw a line from
   the tank to its destination: `Debug.DrawLine(transform.position, destination,
   Color.cyan);`. Play with the Scene view open next to the Game view.
2. Give `ArenaBounds` a second static method, `IsInside(Vector2 point)`, that
   returns whether a point is inside the arena. Test it from a `Practice` script:
   `ArenaBounds.IsInside(new Vector2(20f, 0f))` should be `false`.

## C# 9 — Lists

**Goal:** you can keep a collection that grows and shrinks in a `List<T>`: add,
remove, count, search and loop through it, and choose between a list and an
array.

### Idea — an array that can grow

An array's size is fixed when you make it. A **list** grows when you add to it
and shrinks when you remove from it. You write the type of its elements between
angle brackets: `List<int>`, `List<string>`, `List<GameObject>`.

Lists live in a part of C# you have to switch on with a `using` line at the top
of the script:

```csharp
using System.Collections.Generic;
using UnityEngine;

public class Practice : MonoBehaviour
{
    void Start()
    {
        List<string> crew = new List<string>();
        crew.Add("Sara");
        crew.Add("Omar");
        crew.Add("Lina");
        Debug.Log(crew.Count);
        Debug.Log(crew[0]);
    }
}
```

```
3
Sara
```

- `new List<string>()` makes an **empty** list. Then `Add` puts each name at the
  end.
- `crew.Count` is how many elements there are. Arrays say `Length`; lists say
  `Count`.
- `crew[0]` reads an element by index, exactly like an array, starting at 0.

> **Watch out:** without `using System.Collections.Generic;` the first line with
> `List` gives error CS0246: *The type or namespace name 'List<>' could not be
> found (are you missing a using directive or an assembly reference?)*.

### Idea — the list toolbox

| Code | Does |
| --- | --- |
| `list.Add(x)` | adds `x` at the end |
| `list.Insert(0, x)` | puts `x` at index 0 and moves everything else along |
| `list.Remove(x)` | removes the first `x` it finds |
| `list.RemoveAt(2)` | removes the element at index 2 |
| `list.Contains(x)` | `true` if `x` is in the list |
| `list.IndexOf(x)` | the index of `x`, or `-1` if it isn't there |
| `list.Count` | how many elements |
| `list.Clear()` | removes everything |
| `list[2]` | reads or changes the element at index 2 |

You can also fill a list as you create it, with the values between `{ }`:

```csharp
List<int> scores = new List<int> { 40, 75, 60 };
scores.Add(90);
scores.Remove(75);
scores.Insert(0, 10);
Debug.Log(scores.Count);
Debug.Log(scores[0] + " " + scores[1]);
Debug.Log(scores.Contains(75));
Debug.Log(scores.IndexOf(90));
```

```
4
10 40
False
3
```

Follow it step by step: `{40, 75, 60}`, then `Add(90)` gives
`{40, 75, 60, 90}`, `Remove(75)` gives `{40, 60, 90}`, and `Insert(0, 10)`
gives `{10, 40, 60, 90}`.

### Idea — printing a whole list

`Debug.Log(scores)` doesn't print the numbers. It prints the list's **type**:

```csharp
List<int> scores = new List<int> { 10, 40, 60, 90 };
Debug.Log(scores);
Debug.Log(string.Join(", ", scores));
```

```
System.Collections.Generic.List`1[System.Int32]
10, 40, 60, 90
```

`string.Join` glues every element into one string, with `", "` between them.

### Idea — looping through a list

`foreach` works on lists exactly as it does on arrays:

```csharp
List<string> inventory = new List<string> { "Key", "Map", "Torch" };
foreach (string item in inventory)
{
    Debug.Log("You carry: " + item);
}
```

```
You carry: Key
You carry: Map
You carry: Torch
```

A `for` loop works too; just use `Count` instead of `Length`:
`for (int i = 0; i < inventory.Count; i++)`.

### Idea — removing while looping

A `foreach` loop can't survive its list changing under it. Removing an element
inside `foreach` stops the game with an **InvalidOperationException**:
*Collection was modified; enumeration operation may not execute*.

To remove elements as you check them, use a `for` loop that runs **backwards**:

```csharp
List<int> health = new List<int> { 30, 0, 55, 0, 10 };
for (int i = health.Count - 1; i >= 0; i--)
{
    if (health[i] == 0)
    {
        health.RemoveAt(i);
    }
}
Debug.Log(string.Join(", ", health));
```

```
30, 55, 10
```

Why backwards? `RemoveAt` shifts every **later** element one place to the left.
Going backwards, the elements that shift are ones you've already checked, so
nothing gets skipped.

### Idea — lists of objects

A list can hold any type: numbers, strings, your own classes, and Unity objects.

```csharp
[SerializeField] List<Transform> waypoints;
List<GameObject> enemiesAlive = new List<GameObject>();
```

A `[SerializeField]` list shows in the Inspector exactly like an array: grow it
with **+** and fill it by dragging.

> **Watch out:** when you `Destroy` a GameObject, it isn't taken out of your
> lists. The list keeps an entry that now points at a destroyed object, so
> remove it yourself (`enemiesAlive.Remove(enemy);`) when you destroy it.

### Idea — array or list?

| Use an array when… | Use a List when… |
| --- | --- |
| the number of elements is fixed: 3 life icons, 4 spawn points | things come and go: enemies alive, items picked up |
| you fill it in the Inspector and never resize it | you `Add` and `Remove` while the game runs |
| you ask its size with `.Length` | you ask its size with `.Count` |

Both can be `[SerializeField]` fields, and both work with `for` and `foreach`.

### Do it

1. Make a `List<string>` shopping list with three items. Add one, remove one,
   then print the count and every item with `foreach`.
2. Make a `List<int>` of scores: 12, 45, 7, 45, 30. Use a loop to print how many
   times 45 appears, and the highest score (try `Mathf.Max`).
3. Remove every score below 20 with a backwards loop, then print the list with
   `string.Join`.
4. Try removing inside a `foreach` loop instead, and read the error.

### Challenge

Keep a "last three messages" list: write `AddMessage(string text)` that adds the
text at the end and removes the oldest message (index 0) whenever there are more
than three. Add five messages, then print the list.

## C# 10 — Numbers and Conversions

**Goal:** you can predict what happens when whole and decimal numbers meet,
convert between types on purpose, and fix type-mismatch errors.

### Idea — the number types you use

| Type | Holds | Written like | Used for |
| --- | --- | --- | --- |
| `int` | whole numbers | `42`, `-7` | counts: score, lives, strokes, ammo |
| `float` | decimal numbers, about 7 digits | `3.5f` | Unity's everyday decimal: positions, speeds, time |
| `double` | decimal numbers, about 15 digits | `3.5` | C#'s default decimal; Unity rarely uses it |

A decimal written **without** `f` is a `double`, so `float speed = 3.5;` is an
error: *Literal of type double cannot be implicitly converted to type 'float';
use an 'F' suffix to create a literal of this type* (CS0664). Write `3.5f`.

### Idea — when int meets int

```csharp
Debug.Log(7 / 2);
Debug.Log(7 % 2);
Debug.Log(7 / 2f);
Debug.Log(7f / 2);
```

```
3
1
3.5
3.5
```

When **both** sides are `int`, the answer is an `int`: the decimal part is
**thrown away**, not rounded (`7 / 2` is 3, and `%` gives the remainder, 1). If
**either** side is a `float`, the answer is a `float`.

That rule hides a classic bug:

```csharp
int found = 3;
int total = 4;
float percent = found / total * 100;
Debug.Log(percent);
```

```
0
```

`3 / 4` is worked out first, with two `int`s: the answer is 0. Then `0 * 100` is
0, and only then does it go into the `float`. Too late! The fix is to make one
side a `float` **before** dividing, which is what the next ideas are about.

### Idea — implicit conversion: the safe direction

C# converts a value automatically when **nothing can be lost**:

```csharp
int coins = 5;
float price = coins;     // int to float: 5 becomes 5
double exact = price;    // float to double
Debug.Log(price);
```

```
5
```

Every whole number has a decimal version, so `int` → `float` → `double` is
always safe. This is an **implicit** conversion: you don't write anything.

### Idea — explicit conversion: the cast

The other direction can lose information, so C# refuses to do it silently:

```csharp
float height = 3.9f;
int floors = height;     // error CS0266
```

*Cannot implicitly convert type 'float' to 'int'. An explicit conversion exists
(are you missing a cast?)* (CS0266). A **cast** tells C#: "I know I may lose
something. Do it anyway." You write the type in brackets before the value:

```csharp
float height = 3.9f;
int floors = (int)height;
Debug.Log(floors);
Debug.Log((int)-3.9f);
```

```
3
-3
```

A cast to `int` **cuts off** the decimals, towards zero: 3.9 becomes 3, and
-3.9 becomes -3. Now the percentage bug has a fix:

```csharp
int found = 3;
int total = 4;
float percent = (float)found / total * 100;
Debug.Log(percent);
```

```
75
```

`(float)found` turns 3 into 3.0 **before** the division, so `3.0 / 4` is 0.75.

### Idea — rounding on purpose

When cutting off isn't what you want, `Mathf` has the right tool. Each one
returns an `int`:

| Code | 3.2 | 3.5 | 3.7 | -3.7 |
| --- | --- | --- | --- | --- |
| `(int)x` | 3 | 3 | 3 | -3 |
| `Mathf.FloorToInt(x)`: always down | 3 | 3 | 3 | -4 |
| `Mathf.CeilToInt(x)`: always up | 4 | 4 | 4 | -3 |
| `Mathf.RoundToInt(x)`: to the nearest | 3 | 4 | 4 | -4 |

> **Watch out:** `Mathf.RoundToInt(2.5f)` is **2**, not 3. When a number is
> exactly halfway, Unity rounds to the nearest **even** number: 2.5 goes to 2,
> 3.5 goes to 4.

`Mathf` has other helpers you'll use constantly:

| Code | Result | Does |
| --- | --- | --- |
| `Mathf.Abs(-4)` | `4` | removes the minus sign |
| `Mathf.Max(3, 8)` | `8` | the bigger of two |
| `Mathf.Min(3, 8)` | `3` | the smaller of two |
| `Mathf.Clamp(15, 0, 10)` | `10` | keeps a value between a minimum and a maximum |
| `Mathf.Clamp(0.5f, 0f, 1f)` | `0.5` | already inside the range: unchanged |

`Mathf.Clamp` does in one line what took two `if`s in Level 1:
`x = Mathf.Clamp(x, -edge, edge);`.

### Idea — numbers and text

A `string` that looks like a number is still text. `"10" + 5` is `"105"`! To
turn text into a number, use `int.Parse` or, better, `int.TryParse`:

```csharp
string typed = "12";
if (int.TryParse(typed, out int age))
{
    Debug.Log("Next year you'll be " + (age + 1));
}
else
{
    Debug.Log("That's not a number");
}
```

```
Next year you'll be 13
```

`int.Parse("twelve")` would stop your game with a **FormatException**.
`int.TryParse` is the Try pattern: it returns `false` instead, so it's the safe
choice for anything a player types. `float.TryParse` works the same way for
decimals.

To turn a number into text, use `ToString()` or string interpolation, with a
format if you like:

| Code | Result | Format means |
| --- | --- | --- |
| `42.ToString()` | `"42"` | as it is |
| `$"{3.14159f:F2}"` | `"3.14"` | two decimals |
| `$"{7:D3}"` | `"007"` | at least three digits, padded with zeros |
| `3.14159f.ToString("F1")` | `"3.1"` | one decimal |

### Idea — reading type-mismatch errors

Each of these lines has a type problem. Learn to recognise the error and the
fix: the certification exam shows lines like these and asks what's wrong.

| Line | Error | Fix |
| --- | --- | --- |
| `int lives = 2.5f;` | CS0266: cannot implicitly convert `float` to `int` | `(int)2.5f`, or make `lives` a `float` |
| `float speed = 2.5;` | CS0664: literal of type `double`… | `2.5f` |
| `int score = "10";` | CS0029: cannot implicitly convert `string` to `int` | `int.Parse("10")`, or no quotes |
| `string label = 10;` | CS0029: cannot implicitly convert `int` to `string` | `10.ToString()` |
| `bool ready = 1;` | CS0029: cannot implicitly convert `int` to `bool` | `bool ready = true;` |

### Do it

1. Predict, then print: `10 / 4`, `10 / 4f`, `10 % 4`, `(int)9.99f`,
   `Mathf.RoundToInt(9.5f)` and `Mathf.RoundToInt(8.5f)`.
2. A level has 8 stars and you found 3. Print the percentage you found: first
   get `0`, then fix it with a cast to get `37.5`.
3. Make `string typed = "abc";` and use `int.TryParse` to print either the
   number doubled or `"That's not a number"`. Then change it to `"25"`.
4. Print your score as `"Score: 007"` using the `D3` format.

### Challenge

Write `string FormatTime(float seconds)` that turns `125.7f` into `"2:05"`:
minutes, a colon, then the seconds with two digits. You'll need
`Mathf.FloorToInt`, `/`, `%` and the `D2` format.

## Chapter 6 — The Game

**Goal:** when you press Play, four enemy tanks drive into the arena from its
corners. The top-right of the screen counts them, and "Arena clear!" appears when
you've destroyed them all.

### Idea — who's still out there?

The game keeps every living enemy in a `List<EnemyTank>` (C# 9): `Add`
when one appears, `Remove` when one is destroyed. `enemies.Count` is always how
many are left. The field is `readonly` (C# 7): it always holds the
same list, while the list itself grows and shrinks.

### Idea — spawn points

The enemies appear at four empty GameObjects, one near each corner, each turned
to face the middle of the arena. The game keeps them in an array,
`Transform[] spawnPoints`, and makes each tank at a point's position, turned like
the point: `Instantiate(prefab, point.position, point.rotation)`.

Which point does each tank use? `spawnIndex % spawnPoints.Length`, the remainder
(C# 10), goes round and round the points, however many tanks there are:

| `spawnIndex` | 0 | 1 | 2 | 3 | 4 | 5 |
| --- | --- | --- | --- | --- | --- | --- |
| `spawnIndex % 4` | 0 | 1 | 2 | 3 | 0 | 1 |

### Idea — the enemies report back

When an enemy is destroyed, it must tell the game, so the game can take it off
the list. That needs a reference to the game, and a prefab can't keep a
reference to an object in a scene (the prefab exists before the scene does). So
the game hands it over: just after making a tank, it calls
`enemy.SetGame(this)`. `this` is the object whose code is running: the
`ArenaGame` itself (C# 6). When the tank's health runs out, it
calls `game.EnemyDestroyed(this)` just before it destroys itself.

### Do it — the spawn points

1. **GameObject → Create Empty**, named `Spawn Points`, at `(0, 0, 0)`.
2. Right-click `Spawn Points` → **Create Empty**, four times, and set them:

| Name | Position | Rotation Z |
| --- | --- | --- |
| `Spawn Point 1` | (−10, 6, 0) | −121 |
| `Spawn Point 2` | (10, 6, 0) | 121 |
| `Spawn Point 3` | (−10, −6, 0) | −59 |
| `Spawn Point 4` | (10, −6, 0) | 59 |

Where do those angles come from? From `Spawn Point 1`, the middle of the arena is
the arrow `(10, -6)`, and `Vector2.SignedAngle(Vector2.up, new Vector2(10f,
-6f))` is −121: the rotation that turns "up" towards the middle, as in
Chapter 3.

> **Tip:** to see which way a point faces, select it with the **Move** tool, and
> switch the Scene view's toolbar from **Global** to **Local**: the green arrow is
> the point's "up".

### Do it — the screen

1. **GameObject → UI (Canvas) → Text - TextMeshPro**. The first time, Unity asks
   to import **TMP Essentials**: click **Import TMP Essentials**, then close the
   window. Unity also creates a **Canvas** and an **EventSystem**. Rename the text
   `Enemies Text`.
2. Select **Canvas**. In its **Canvas Scaler**, set **UI Scale Mode** to **Scale
   With Screen Size**, **Reference Resolution** to `1920 × 1080`, and **Match** to
   `0.5`.
3. Select `Enemies Text`. Anchor it **top-right**, holding **Shift + Alt**
   (**Shift + Option** on Mac) as in Level 1. Set **Pos** to `(-40, -25)`,
   **Width** `500` and **Height** `70`.
4. In its **TextMeshPro - Text (UI)** component, delete the "New Text" it starts
   with, and set the **Font Size** to `44`, and the alignment to **right** and
   **middle**. Open **Extra Settings** at the bottom and untick **Raycast
   Target**: this text is only there to be read (Chapter 9 shows why that
   matters).
5. Make a second text the same way, named `Message Text`: anchored
   **middle-center**, **Pos** `(0, 150)`, **Width** `1600`, **Height** `200`,
   empty, **Font Size** `96`, **Font Style** **B** (bold), alignment **centre** and
   **middle**, and **Raycast Target** unticked.

### Do it — the game

The game calls the enemy's `SetGame`, and the enemy calls the game's
`EnemyDestroyed`: the two scripts use each other, so write both, one straight
after the other.

> **Note:** after the first one, the Console shows an error: `EnemyTank` has no
> `SetGame` yet. It goes away when you've replaced `EnemyTank` too. While there's
> an error, Unity can't attach a new script to anything, so attach `ArenaGame`
> after both.

1. Create `ArenaGame`:

```csharp
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// Runs the battle. For now, it sends a few enemy tanks into the arena, counts
// them, and says when they've all been destroyed.
public class ArenaGame : MonoBehaviour
{
    [SerializeField] GameObject lightTankPrefab;
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] int enemyCount = 4;
    [SerializeField] TMP_Text enemiesText;
    [SerializeField] TMP_Text messageText;

    readonly List<EnemyTank> enemies = new List<EnemyTank>();

    void Start()
    {
        messageText.text = "";
        for (int i = 0; i < enemyCount; i++)
        {
            Spawn(lightTankPrefab, i);
        }
    }

    void Update()
    {
        enemiesText.text = "Enemies: " + enemies.Count;
    }

    void Spawn(GameObject prefab, int spawnIndex)
    {
        // % goes round the spawn points: with 4 points, tank 5 uses point 0 again.
        Transform point = spawnPoints[spawnIndex % spawnPoints.Length];
        GameObject tank = Instantiate(prefab, point.position, point.rotation);
        EnemyTank enemy = tank.GetComponent<EnemyTank>();
        enemy.SetGame(this);
        enemies.Add(enemy);
    }

    public void EnemyDestroyed(EnemyTank enemy)
    {
        enemies.Remove(enemy);
        if (enemies.Count == 0)
        {
            messageText.text = "Arena clear!";
        }
    }
}
```

2. Replace `EnemyTank` with this version:

```csharp
using System.Collections;
using UnityEngine;

// An enemy tank. It drives around the arena to random places, and tells the game
// when it's destroyed.
[RequireComponent(typeof(Tracks))]
[RequireComponent(typeof(Turret))]
[RequireComponent(typeof(Health))]
public class EnemyTank : MonoBehaviour
{
    [SerializeField] float thinkTime = 3f;        // seconds between two new places to go

    Tracks tracks;
    Turret turret;
    ArenaGame game;
    Vector2 destination;

    public Health Health { get; private set; }

    void Awake()
    {
        tracks = GetComponent<Tracks>();
        turret = GetComponent<Turret>();
        Health = GetComponent<Health>();
        destination = transform.position;
    }

    void Start()
    {
        StartCoroutine(Think());
    }

    // The game hands every new enemy a reference to itself.
    public void SetGame(ArenaGame arenaGame)
    {
        game = arenaGame;
    }

    // Every few seconds, choose somewhere new to go.
    IEnumerator Think()
    {
        while (true)
        {
            destination = ArenaBounds.RandomPoint();
            yield return new WaitForSeconds(thinkTime);
        }
    }

    void Update()
    {
        if (Health.IsDead)
        {
            game.EnemyDestroyed(this);
            Destroy(gameObject);
            return;
        }

        // Drive on, with the barrel pointing straight ahead.
        tracks.DriveTowards(destination);
        turret.AimAt((Vector2)transform.position + (Vector2)transform.up);
    }
}
```

   What's new: the comment, the `game` field, `SetGame`, and, in `Update`,
   `game.EnemyDestroyed(this);` just before `Destroy`. The `game` field isn't a
   `[SerializeField]`: nobody fills it in the Inspector, because the game fills
   it in from code.

3. When the Console has no errors, **GameObject → Create Empty**, named
   `Arena Game`, at `(0, 0, 0)`, and attach `ArenaGame` to it.
4. Drag the `Light Tank` prefab into **Light Tank Prefab**. Give **Spawn Points**
   four elements, and drag in `Spawn Point 1` to `Spawn Point 4`, in order. Drag
   `Enemies Text` into **Enemies Text**, and `Message Text` into **Message Text**.

Read `ArenaGame` before you move on:

- `Start` empties the message, then makes `enemyCount` tanks, one at each spawn
  point.
- `Spawn` makes the tank, gets its `EnemyTank` with `GetComponent`, hands it the
  game, and adds it to the list.
- `Update` puts the count on the screen, every frame. `"Enemies: " +
  enemies.Count` joins a `string` and an `int`: C# turns the `int` into text for
  you (C# 10).
- `EnemyDestroyed` takes the enemy off the list, and when none are left, says so.

### Test it

Press **Play**. Four light tanks appear near the corners, each facing the middle,
and drive off. The top-right corner says "Enemies: 4". Destroy them one by one,
and watch the count go down. When the last one goes, "Arena clear!" appears in
the middle of the screen. In the Hierarchy, the `Light Tank(Clone)` objects come
and go.

### Challenge

Set **Enemy Count** to `6`. Which spawn points do tanks 5 and 6 use? What
happens when two tanks appear in the same place at the same moment? Put it back
to `4`.

# Part 3 — Battle

## C# 11 — Raycasts

**Goal:** you can shoot an invisible ray to find what's in a direction or under
the pointer, in 2D and in 3D, and choose what the ray is allowed to hit.

### Idea — a laser pointer made of maths

A **raycast** shoots an invisible line from a **start point**, in a
**direction**, up to a **maximum distance**, and tells you about the **first
collider** it hits. It's how games answer questions like these:

| Question | Ray |
| --- | --- |
| Can the enemy see the player, or is a wall in the way? | from the enemy towards the player |
| What did the player click or tap? | from the camera, through the pointer |
| Is there ground under my feet? | from the feet, straight down, a short distance |

Only objects with a **collider** can be hit: a ray passes straight through
anything without one.

### Idea — raycasts in 3D

```csharp
void Update()
{
    if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, 10f))
    {
        Debug.Log("I see " + hit.collider.name + ", " + hit.distance + " away");
    }
}
```

`Physics.Raycast` uses the Try pattern (C# 3). It returns `true` if the
ray hit something, and fills in `hit` through the `out` parameter:

| Argument | Here |
| --- | --- |
| start point | `transform.position` |
| direction | `transform.forward`: the way this object faces |
| the result | `out RaycastHit hit` |
| maximum distance | `10f`: leave it out and the ray goes on forever |

| `hit.` | Gives |
| --- | --- |
| `collider` | the collider that was hit (and `hit.collider.gameObject`, its GameObject) |
| `point` | the exact world point where the ray hit it |
| `distance` | how far that point is from the start |
| `normal` | the direction the hit surface faces |

### Idea — raycasts in 2D

2D physics has its own raycast. It takes the same kind of arguments, but instead
of an `out` parameter, it **returns** the result:

```csharp
void Update()
{
    RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, 10f);
    if (hit.collider != null)
    {
        Debug.Log("I see " + hit.collider.name);
    }
}
```

If the ray hits nothing, `hit.collider` is `null`.

> **Watch out:** a 2D ray that starts **inside** a collider hits that collider
> first. If the object casting the ray has a collider of its own, the ray hits
> the object itself, every time! Start the ray just outside your own collider,
> or use a layer mask (below) that leaves out your own layer. 3D rays don't
> have this problem: they ignore a collider they start inside.

### Idea — seeing the ray

Rays are invisible, which makes them hard to get right. `Debug.DrawRay` draws a
line in the **Scene view** for one frame, so call it in `Update` next to your
raycast:

```csharp
Debug.DrawRay(transform.position, transform.forward * 10f, Color.red);
```

The second argument is the whole arrow: the direction **times** the length. To
see the line in the Game view too, turn on the **Gizmos** button in its toolbar.

### Idea — choosing what the ray can hit: layers

Every GameObject is on one **layer**, chosen in the **Layer** dropdown at the top
right of the Inspector. Layers are like tags, but physics understands them. Add
your own with **Layer → Add Layer…**, such as `Ground`, `Walls` or `Player`.

A **layer mask** is a list of layers a ray is allowed to hit. Make one a
`[SerializeField]` field, and the Inspector gives you a dropdown to tick
layers:

```csharp
[SerializeField] LayerMask wallsMask;

void Update()
{
    if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, 10f, wallsMask))
    {
        Debug.Log("A wall is in the way");
    }
}
```

The mask always goes **last**. In 2D:
`Physics2D.Raycast(transform.position, Vector2.right, 10f, wallsMask)`. You can
also build a mask in code: `LayerMask.GetMask("Walls", "Ground")`.

> **Tip:** the built-in **Ignore Raycast** layer does what it says: normal
> raycasts pass straight through anything on it.

### Idea — what's under the pointer?

In **3D**, the camera makes a ray through the pointer (C# 4), and a
normal raycast follows it into the scene:

```csharp
Ray ray = Camera.main.ScreenPointToRay(Pointer.current.position.ReadValue());
if (Physics.Raycast(ray, out RaycastHit hit, 100f))
{
    Debug.Log("Pointing at " + hit.collider.name + " at " + hit.point);
}
```

`Physics.Raycast` has an overload that takes a `Ray` (a start point and a
direction packed together) instead of the two separately.

In **2D**, the camera looks straight at the scene, so you don't need a ray: turn
the pointer into a world point, then ask which collider is **at** that point:

```csharp
Vector2 world = Camera.main.ScreenToWorldPoint(Pointer.current.position.ReadValue());
Collider2D found = Physics2D.OverlapPoint(world);
if (found != null)
{
    Debug.Log("Pointing at " + found.name);
}
```

### Do it

In a 3D scene (a 2D version follows):

1. Put your `Practice` object at (0, 0.5, 0) and a Cube at (0, 0.5, 5). Raycast
   forward from `Practice` and print what it hits and how far away.
2. Draw the ray with `Debug.DrawRay` and look at it in the Scene view while the
   game runs. Move the cube aside: the messages stop.
3. Add a second cube at (0, 0.5, 3). Put the far cube on a new layer, `Target`,
   and add a `LayerMask` field with only `Target` ticked: now the ray skips the
   near cube.
4. Print the name of whatever you click.

In a 2D scene: use two sprites with **Box Collider 2D**s and `Physics2D.Raycast`
along `Vector2.right`, and `Physics2D.OverlapPoint` for step 4.

### Challenge

Make a "security camera": an object that turns slowly (rotate it in `Update`) and
raycasts forward every frame. When the ray hits an object tagged `Player`, print
`"Spotted!"`, but only once each time the player comes into view.

## Chapter 7 — Enemies Fire Back

**Goal:** an enemy tank sees you when you're close enough and no wall is in the
way. Then it stops, turns its barrel towards you, and fires. Its shells hurt your
tank: ten hits, and it's destroyed.

### Idea — can it see you?

Every frame, each enemy casts a ray from its middle towards your tank
(C# 11). `direction` is the arrow from the enemy to your tank, made
1 long (C# 1):

```csharp
RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, sightRange, sightMask);
```

The ray reports the **first** collider it hits. If that's your tank, nothing is
in the way: the enemy can see you. If it's a wall, a tree or a barrel, it can't.
And if you're further away than `sightRange`, the ray doesn't even reach you.

### Idea — what the ray can hit: layers

`sightMask` chooses which **layers** the ray can hit. Two new layers sort the
colliders out:

| Layer | Objects | Ticked in `sightMask`? |
| --- | --- | --- |
| **Walls** | everything in `Arena`: the walls, the trees, the barrels | yes: they block the view |
| **Player** | your tank | yes: that's what the enemy looks for |
| **Default** | the enemy tanks, and the shells | no: the ray goes straight through them |

Without the mask, the ray would stop at the first collider of any kind: often the
enemy's own collider, which the ray starts inside, or a shell flying past.

### Idea — a method that answers twice

`CanSeeTarget` has two answers: **whether** the enemy can see you, as its
`bool` return value, and **where** you are, through an `out` parameter
(C# 3):

```csharp
if (CanSeeTarget(out Vector2 targetPosition))
{
    // it can see you, and targetPosition says where you are
}
```

`Debug.DrawRay` draws the ray in the Scene view, in yellow, so you can see where
each enemy is looking.

### Idea — aim first, then fire

An enemy that sees you stops, and turns its barrel towards you. It only fires
when the barrel points at you, within 5 degrees. `Turret` gets a new method for
that, `IsAimedAt`, with `Vector2.Angle`: the angle between two arrows, from 0 to
180, whichever side. The slow turn gives you a moment to see a shot coming, and
to get out of the way.

### Idea — your tank can be hurt

Your tank gets a `Health` component, like the enemies, with 10 hit points. Two
scripts need to reach it:

- `PlayerTank` gets a `Health` property, like `EnemyTank`'s: `public Health
  Health { get; private set; }`. The first `Health` is the type, and the second
  the property's name; C# can tell them apart.
- `ArenaGame` checks, every frame, whether your health has run out. It also
  gets a `Player` property, so each enemy can ask the game which tank to hunt.

### Do it — the layers

1. Select `Player Tank`. Open the **Layer** dropdown at the top-right of the
   Inspector and choose **Add Layer…**. Type `Walls` in the first empty **User
   Layer**, and `Player` in the next one.
2. Select `Arena`, and set its **Layer** to `Walls`. Unity asks about its
   children: choose **Yes, change children**.
3. Select `Player Tank`, and set its **Layer** to `Player`, with **Yes, change
   children**.

### Do it — your tank can be hurt

1. Select `Player Tank`, **Add Component → Health**, and set **Max Health** to
   `10`.
2. In `PlayerTank`:
   - Under the two `[RequireComponent]` lines, add a third:

```csharp
[RequireComponent(typeof(Health))]
```

   - Just above `void Awake()`, add the property, with an empty line after it:

```csharp
    public Health Health { get; private set; }
```

   - In `Awake`, just after `turret = GetComponent<Turret>();`, add:

```csharp
        Health = GetComponent<Health>();
```

3. Replace `ArenaGame` with this version:

```csharp
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// Runs the battle. For now, it sends a few enemy tanks into the arena, counts
// them, and says when they've all been destroyed, or when your tank has been.
public class ArenaGame : MonoBehaviour
{
    [SerializeField] PlayerTank player;
    [SerializeField] GameObject lightTankPrefab;
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] int enemyCount = 4;
    [SerializeField] TMP_Text enemiesText;
    [SerializeField] TMP_Text messageText;

    readonly List<EnemyTank> enemies = new List<EnemyTank>();

    public PlayerTank Player
    {
        get { return player; }
    }

    void Start()
    {
        messageText.text = "";
        for (int i = 0; i < enemyCount; i++)
        {
            Spawn(lightTankPrefab, i);
        }
    }

    void Update()
    {
        if (player.gameObject.activeSelf && player.Health.IsDead)
        {
            player.gameObject.SetActive(false);
            messageText.text = "Destroyed!";
        }
        enemiesText.text = "Enemies: " + enemies.Count;
    }

    void Spawn(GameObject prefab, int spawnIndex)
    {
        // % goes round the spawn points: with 4 points, tank 5 uses point 0 again.
        Transform point = spawnPoints[spawnIndex % spawnPoints.Length];
        GameObject tank = Instantiate(prefab, point.position, point.rotation);
        EnemyTank enemy = tank.GetComponent<EnemyTank>();
        enemy.SetGame(this);
        enemies.Add(enemy);
    }

    public void EnemyDestroyed(EnemyTank enemy)
    {
        enemies.Remove(enemy);
        if (enemies.Count == 0)
        {
            messageText.text = "Arena clear!";
        }
    }
}
```

   What's new: the comment, the `player` field, the `Player` property, and the
   `if` in `Update`. `player.gameObject.activeSelf` is `false` once your tank has
   been switched off, so the `if` only happens once.

4. Select `Arena Game`, and drag `Player Tank` into **Player**.

### Do it — enemy shells

1. In `Assets/Prefabs`, select `Player Shell` and press **Ctrl + D**
   (**Cmd + D**). Rename the copy `Enemy Shell`.
2. Double-click `Enemy Shell` to open it. Set its **Sprite** to `bulletRed`, and
   its **Shell**'s **Speed** to `7`: a little slower than yours, so you can dodge.
   Go back to the scene with the arrow at the top-left of the Hierarchy.

### Do it — enemies that see

1. In `Turret`, add this method after `AimAt`:

```csharp
    // Is the barrel pointing at the point, give or take a few degrees?
    public bool IsAimedAt(Vector2 point, float degrees)
    {
        Vector2 direction = point - (Vector2)barrel.position;
        return Vector2.Angle(barrel.up, direction) <= degrees;
    }
```

2. Replace `EnemyTank` with this version:

```csharp
using System.Collections;
using UnityEngine;

// An enemy tank. It drives around the arena to random places; whenever it can
// see the player, with no wall in the way, it stops, turns its barrel and fires.
[RequireComponent(typeof(Tracks))]
[RequireComponent(typeof(Turret))]
[RequireComponent(typeof(Health))]
public class EnemyTank : MonoBehaviour
{
    [SerializeField] float sightRange = 8f;
    [SerializeField] LayerMask sightMask;         // what its eyes stop at: the walls and the player
    [SerializeField] float thinkTime = 3f;        // seconds between two new places to go

    Tracks tracks;
    Turret turret;
    ArenaGame game;
    Transform target;
    Vector2 destination;

    public Health Health { get; private set; }

    void Awake()
    {
        tracks = GetComponent<Tracks>();
        turret = GetComponent<Turret>();
        Health = GetComponent<Health>();
        destination = transform.position;
    }

    void Start()
    {
        StartCoroutine(Think());
    }

    // The game hands every new enemy the game itself, and the tank to hunt.
    public void SetGame(ArenaGame arenaGame)
    {
        game = arenaGame;
        target = game.Player.transform;
    }

    // Every few seconds, choose somewhere new to go.
    IEnumerator Think()
    {
        while (true)
        {
            destination = ArenaBounds.RandomPoint();
            yield return new WaitForSeconds(thinkTime);
        }
    }

    void Update()
    {
        if (Health.IsDead)
        {
            game.EnemyDestroyed(this);
            Destroy(gameObject);
            return;
        }

        if (CanSeeTarget(out Vector2 targetPosition))
        {
            tracks.Stop();
            turret.AimAt(targetPosition);
            if (turret.IsAimedAt(targetPosition, 5f))
            {
                turret.Fire();
            }
        }
        else
        {
            // Drive on, with the barrel pointing straight ahead again.
            tracks.DriveTowards(destination);
            turret.AimAt((Vector2)transform.position + (Vector2)transform.up);
        }
    }

    // Can it see the player: close enough, with nothing in the way? If so,
    // targetPosition says where the player is.
    bool CanSeeTarget(out Vector2 targetPosition)
    {
        targetPosition = Vector2.zero;
        if (target == null || !target.gameObject.activeInHierarchy)
        {
            return false;
        }

        targetPosition = target.position;
        Vector2 toTarget = targetPosition - (Vector2)transform.position;
        if (toTarget.magnitude > sightRange)
        {
            return false;
        }

        Vector2 direction = toTarget.normalized;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, sightRange, sightMask);
        Debug.DrawRay(transform.position, direction * sightRange, Color.yellow);
        return hit.collider != null && hit.transform == target;
    }
}
```

3. Open the `Light Tank` prefab. In its **Turret**, drag the `Enemy Shell` prefab
   into **Shell Prefab**. In its **EnemyTank**, set **Sight Range** to `8`, open
   **Sight Mask**, and tick **Walls** and **Player**.

Read `EnemyTank` before you move on:

- `SetGame` now also asks the game for the player's tank, and keeps its
  Transform in `target`.
- `Update` has two ways to go. If the enemy can see you, it stops, aims, and
  fires once its barrel points at you. If not, it drives to its destination, as
  before.
- `CanSeeTarget` starts with checks that end it early: no target, a target that's
  been switched off, or a target too far away. `activeInHierarchy` is `false`
  when an object is switched off, or when its parent is; your tank has no parent,
  so here it says the same as the `activeSelf` in `ArenaGame`. `out` parameters
  must always be given a value before the method returns, so `targetPosition` gets
  one at the very start.
- `hit.transform == target`: the first thing the ray hit is your tank itself, and
  not a wall in front of it.

### Test it

Press **Play**, with the Scene view open next to the Game view. The enemies drive
around, and when one gets within 8 units of you, a yellow line points from it to
your tank. With nothing in the way, it stops, turns its barrel, and fires red
shells. Hide behind a wall: the line still points at you, but the ray hits the
wall first, so the enemy drives on. You can't see your health yet (Chapter 8
adds a health bar), so count: the tenth hit destroys your tank, and "Destroyed!"
appears.

### Challenge

Make the enemies hunt you. In `EnemyTank.Update`, when an enemy can see you, also
set `destination = targetPosition;`. Now, when you hide, the enemy drives to the
last place it saw you. Does that make the game better, or only harder?

## C# 12 — Reading the Unity Docs

**Goal:** you can find a class in Unity's Scripting API, read its page, and pick
the right property or method, with the right arguments.

### Idea — two manuals

Nobody remembers all of Unity. Professionals look things up many times a day, in
two official manuals at **docs.unity3d.com**:

| Manual | Answers | Example |
| --- | --- | --- |
| **Unity Manual** | "How does this part of the Editor work?" | how the Animator window works |
| **Scripting API** (Scripting Reference) | "What can my code do with this class?" | every property and method of `Rigidbody` |

Check the **version** at the top of the page: pick the version of Unity you're
using (6000.x). The **?** icon at the top of every component in the Inspector
opens that component's page too.

### Idea — a class page

Search the Scripting API for `Rigidbody` and open the class page. Every class
page has the same parts:

| Part | Tells you |
| --- | --- |
| **class in UnityEngine** | the namespace: the `using` line you need |
| **Inherits from** | its parent class: `Rigidbody` is a `Component`, so it has everything a component has |
| **Description** | what it's for, often with an example script |
| **Properties** | the values you can read or set: `mass`, `linearVelocity`, `useGravity`… |
| **Public Methods** | what you can ask it to do: `AddForce`, `MovePosition`… |
| **Static Methods** | members of the class itself, called on the class name |
| **Messages** | event functions Unity calls on your scripts, like `OnCollisionEnter` |
| **Inherited Members** | everything that comes from the parent classes |

### Idea — a method page

Click `AddForce`. The **Declaration** is the most important line on the page:

```csharp
public void AddForce(Vector3 force, ForceMode mode = ForceMode.Force);
```

Read it like any method you write (C# 3):

- `void`: it returns nothing.
- `Vector3 force`: the first argument is the push, as a vector.
- `ForceMode mode = ForceMode.Force`: the second argument is **optional**. Leave
  it out and you get `ForceMode.Force`.

Under it, the **Parameters** table explains each argument, and the
**Description** says what the method does and when to use it. When a method has
**several declarations**, those are its overloads: pick the one whose parameters
match what you have.

### Idea — searching well

- Search for the **thing**, then read its page: to move a physics object, start
  at `Rigidbody`; for distances, start at `Vector3`.
- Scan the **Properties** and **Public Methods** lists: the one-line summaries
  are written to be skimmed.
- Read the **Declaration**, not only the example. The example shows one way to
  call a method; the declaration shows every way.
- Check the version. Unity 6 renamed some members (`velocity` became
  `linearVelocity`), and old answers on the internet use the old names.

> **Tip:** in VS Code, hover over any Unity class or method to see its summary,
> and its declaration, without leaving your code.

### Do it: a scavenger hunt

Use the Scripting API to answer each question. The answers are below.

1. Which property of `Rigidbody2D` sets how strongly gravity pulls it?
2. What does `Vector3.Distance` return, and what are its parameters?
3. `Mathf.Clamp` has more than one declaration. Which types can it work with?
4. Which class does `Transform` inherit from?
5. What's the default `ForceMode` of `Rigidbody.AddForce`, and what does
   `ForceMode.Impulse` do?
6. Which message does Unity send when two 2D colliders (not triggers) start
   touching?
7. What does `GameObject.CompareTag` return?

### Challenge

Find a method you've never used that would be useful in your game, read its whole
page, and use it. Explain to a classmate what its declaration says.

### Answers

1. `gravityScale`.
2. It returns a `float`: the distance between its two parameters, `Vector3 a`
   and `Vector3 b`.
3. `float` and `int`: `Clamp(float value, float min, float max)` and
   `Clamp(int value, int min, int max)`.
4. `Component`.
5. `ForceMode.Force`. `ForceMode.Impulse` applies the whole push at once, like a
   kick, and takes the mass into account.
6. `OnCollisionEnter2D`.
7. A `bool`: `true` if the GameObject has that tag.

## Chapter 8 — Rounds and a Health Bar

**Goal:** the battle comes in four rounds, each announced by a countdown: 3, 2,
1, Go! Round 3 brings a black heavy tank. A health bar at the top-left shows how
much your tank can take, and the top of the screen says which round it is.

### Idea — the rounds are data

Each round is how many light tanks and how many heavy tanks it sends. Two arrays
hold them, one number per round:

| Round | `lightTanksPerRound` | `heavyTanksPerRound` |
| --- | --- | --- |
| 1 | 2 | 0 |
| 2 | 3 | 0 |
| 3 | 2 | 1 |
| 4 | 2 | 2 |

Arrays count from 0 and rounds from 1, so round `n` is at index `n - 1`. A
property, `RoundCount`, is the length of the array: add a number to both arrays
in the Inspector, and the game has a fifth round.

### Idea — a coroutine runs the battle

The whole battle is one coroutine, `PlayRounds` (C# 8). For each
round it shows "Round 1", counts down 3, 2, 1, shows "Go!", sends the round's
tanks, then waits, one frame at a time, until none are left:

```csharp
while (enemies.Count > 0)
{
    yield return null;    // wait one frame, then check again
}
```

Then "Round cleared!", a short break, and the next round. After the last one:
"Victory!". If your tank is destroyed, `StopAllCoroutines()` stops the battle.

### Idea — messages that disappear by themselves

`ArenaGame` gets two versions of `ShowMessage`, as overloads (C# 3):
`ShowMessage("Round 1")` shows a message that stays on the screen, and
`ShowMessage("Go!", 0.8f)` shows one for 0.8 seconds. The second starts a
coroutine that clears the text later. If another message arrives before then,
`StopCoroutine` cancels the old clearing, so the new message doesn't vanish too
early.

### Idea — a health bar

The bar is two UI images: a dark background, and a green **fill** in front of
it. The fill's **Image Type** is **Filled**: its **Fill Amount**, from 0 to 1,
says how much of the picture to show. Look up `Image.fillAmount` in the
Scripting API (C# 12): it's a `float`, and `1` shows it all.

`Health` gets a property that gives exactly that, `Fraction`:

```csharp
get { return (float)Current / maxHealth; }
```

Without the `(float)`, `Current / maxHealth` would divide two `int`s, and the
answer would be 0 until your health was full again (C# 10).

### Idea — the heavy tank

A heavy tank is built exactly like a light tank, from the same components, with
different numbers: no new code at all.

| Component | Setting | Light Tank | Heavy Tank |
| --- | --- | --- | --- |
| **Health** | **Max Health** | 2 | 5 |
| **Tracks** | **Move Speed**, **Turn Speed** | 2, 90 | 1.3, 60 |
| **Turret** | **Turn Speed**, **Reload Time** | 120, 1.6 | 90, 2.4 |
| **EnemyTank** | **Sight Range** | 8 | 9 |

### Do it — the heavy tank

1. In `Assets/Prefabs`, select `Light Tank` and press **Ctrl + D**
   (**Cmd + D**). Rename the copy `Heavy Tank`.
2. Double-click `Heavy Tank` to open it. Set its **Sprite** to `tankBlack`, and
   its `Barrel`'s **Sprite** to `barrelBlack`. Then change its settings to the
   Heavy Tank column of the table above.

### Do it — the health bar

1. **GameObject → UI (Canvas) → Image**, named `Health Bar`. Anchor it
   **top-left** (with Shift + Alt), **Pos** `(40, -30)`, **Width** `400`,
   **Height** `36`. Set its **Color** to `#1E1E1E`, with **Alpha** around 180,
   and untick **Raycast Target**.
2. Right-click `Health Bar` → **UI (Canvas) → Image**, named `Health Fill`. In
   the anchor presets, hold **Shift + Alt** and click the bottom-right one,
   **stretch** in both directions: the fill covers the whole bar. Then set
   **Left**, **Top**, **Right** and **Bottom** to `4`, for a thin dark border.
3. Still on `Health Fill`: click the small circle next to **Source Image** and
   pick `UISprite`. New settings appear: set **Image Type** to **Filled**, **Fill
   Method** to **Horizontal** and **Fill Origin** to **Left**. Set its **Color**
   to green, `#61CB8B`, and untick **Raycast Target**.
4. One more text, like `Enemies Text`, named `Round Text`: anchored
   **top-center**, **Pos** `(0, -25)`, **Width** `600`, **Height** `70`, empty,
   **Font Size** `44`, alignment **centre** and **middle**, and **Raycast Target**
   unticked.

### Do it — the code

1. In `Health`, add this property after `IsDead`:

```csharp
    // How full the health is, from 0 (dead) to 1 (as good as new).
    public float Fraction
    {
        get { return (float)Current / maxHealth; }
    }
```

2. Replace `ArenaGame` with this version:

```csharp
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Runs the battle: the rounds of enemy tanks, one after another, and the
// screen.
public class ArenaGame : MonoBehaviour
{
    [SerializeField] PlayerTank player;
    [SerializeField] GameObject lightTankPrefab;
    [SerializeField] GameObject heavyTankPrefab;
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] int[] lightTanksPerRound = { 2, 3, 2, 2 };
    [SerializeField] int[] heavyTanksPerRound = { 0, 0, 1, 2 };
    [SerializeField] Image healthFill;
    [SerializeField] TMP_Text roundText;
    [SerializeField] TMP_Text enemiesText;
    [SerializeField] TMP_Text messageText;

    readonly List<EnemyTank> enemies = new List<EnemyTank>();
    int round = 1;                                // the round being played, counting from 1
    Coroutine hideMessage;

    public PlayerTank Player
    {
        get { return player; }
    }

    int RoundCount
    {
        get { return lightTanksPerRound.Length; }
    }

    void Awake()
    {
        messageText.text = "";
    }

    void Start()
    {
        StartCoroutine(PlayRounds());
    }

    void Update()
    {
        if (player.gameObject.activeSelf && player.Health.IsDead)
        {
            player.gameObject.SetActive(false);
            StopAllCoroutines();
            ShowMessage("Destroyed!");
        }
        UpdateScreen();
    }

    // The whole battle: each round counts down, sends its tanks, and waits
    // until every one of them has been destroyed.
    IEnumerator PlayRounds()
    {
        for (int number = 1; number <= RoundCount; number++)
        {
            round = number;
            ShowMessage("Round " + round);
            yield return new WaitForSeconds(1.5f);
            for (int count = 3; count > 0; count--)
            {
                ShowMessage(count.ToString());
                yield return new WaitForSeconds(0.6f);
            }
            ShowMessage("Go!", 0.8f);
            SpawnRound(round);

            while (enemies.Count > 0)
            {
                yield return null;
            }

            if (round < RoundCount)
            {
                ShowMessage("Round cleared!");
                yield return new WaitForSeconds(2f);
            }
        }
        ShowMessage("Victory!");
    }

    void SpawnRound(int roundNumber)
    {
        int spawnIndex = 0;
        for (int i = 0; i < lightTanksPerRound[roundNumber - 1]; i++)
        {
            Spawn(lightTankPrefab, spawnIndex);
            spawnIndex++;
        }
        for (int i = 0; i < heavyTanksPerRound[roundNumber - 1]; i++)
        {
            Spawn(heavyTankPrefab, spawnIndex);
            spawnIndex++;
        }
    }

    void Spawn(GameObject prefab, int spawnIndex)
    {
        // % goes round the spawn points: with 4 points, tank 5 uses point 0 again.
        Transform point = spawnPoints[spawnIndex % spawnPoints.Length];
        GameObject tank = Instantiate(prefab, point.position, point.rotation);
        EnemyTank enemy = tank.GetComponent<EnemyTank>();
        enemy.SetGame(this);
        enemies.Add(enemy);
    }

    public void EnemyDestroyed(EnemyTank enemy)
    {
        enemies.Remove(enemy);
    }

    // Two versions of ShowMessage (overloads): one message stays on screen,
    // the other disappears after a few seconds.
    public void ShowMessage(string text)
    {
        if (hideMessage != null)
        {
            StopCoroutine(hideMessage);
        }
        messageText.text = text;
    }

    public void ShowMessage(string text, float seconds)
    {
        ShowMessage(text);
        hideMessage = StartCoroutine(HideMessageAfter(seconds));
    }

    IEnumerator HideMessageAfter(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        messageText.text = "";
    }

    void UpdateScreen()
    {
        healthFill.fillAmount = player.Health.Fraction;
        roundText.text = $"Round {round} of {RoundCount}";
        enemiesText.text = "Enemies: " + enemies.Count;
    }
}
```

3. Select `Arena Game`. **Enemy Count** has gone, and there are new fields: drag
   in the `Heavy Tank` prefab, `Health Fill` and `Round Text`. The two arrays
   already hold the rounds, from the script.

Read it before you move on:

- `using UnityEngine.UI;` for `Image`.
- `round` starts at 1, and `PlayRounds` sets it at the start of each round.
  `RoundCount` is a property with only a `get`, and it's private: nothing outside
  the game needs it.
- `Awake` empties the message; `Start` starts the battle.
- `SpawnRound` makes the round's light tanks, then its heavy tanks, each at the
  next spawn point.
- `EnemyDestroyed` only takes the enemy off the list now: the coroutine notices
  when the list is empty.
- `UpdateScreen`, every frame: the health bar, the round, and the enemies left.

### Test it

Press **Play**. "Round 1" appears, then 3, 2, 1 and "Go!", and two light tanks
arrive. Get hit: the green bar shrinks by a tenth. Destroy both tanks: "Round
cleared!", and round 2 begins. Round 3 brings the heavy tank: slow, but it takes
five hits. Clear round 4 for "Victory!". Or let the enemies win: the rounds
stop, and "Destroyed!" stays on the screen.

> **Tip:** four rounds take a while. While you test, select `Arena Game` and make
> the arrays smaller in the Inspector, for example 1 light tank per round, and put
> the real numbers back afterwards.

### Challenge

1. Add a fifth round of 3 light tanks and 2 heavy tanks. The screen says "Round 1
   of 5" all by itself: why? And which spawn point does the fifth tank use?
2. Make the health bar turn red, `#E86A6A`, when less than a third of your health
   is left: `healthFill.color` is the fill's colour.

## Chapter 9 — Touch Controls

**Goal:** on a phone, a quick tap fires towards that spot, and pressing and
holding drives your tank towards your finger. A mouse does the same. You test it without
a phone, in the Device Simulator.

### Idea — a tap or a hold?

A finger can't hover: it's down, or it isn't. So one finger does two jobs, and
the tank tells them apart by **how long** the finger stays down
(C# 4):

| The finger | Is | The tank |
| --- | --- | --- |
| goes down and comes up again within `tapTime`, 0.25 seconds | a **tap** | fires |
| stays down longer than `tapTime` | a **hold** | drives towards the finger, for as long as it's down |

When the press begins, the tank remembers the time, `pressStartTime`.
`Time.time - pressStartTime` is how long the finger has been down. And the
barrel always aims at the pointer: at the mouse on a computer, at the finger on a
phone.

Driving towards the finger uses `tracks.DriveTowards`: the same method the enemy
tanks drive with. One method, three drivers.

### Idea — a press on the UI isn't for the tank

`EventSystem.current.IsPointerOverGameObject()` is `true` when the pointer is
over a UI element: any button, text or image with **Raycast Target** ticked. The
tank ignores those presses, so that pressing a button during a game, like the
**Settings** button in Chapter 13, doesn't also fire a shell.

That's why you unticked **Raycast Target** on the texts and the health bar.
`Message Text` covers a wide strip across the middle of the screen, even when
it's empty: with Raycast Target ticked, a finger on that strip would do nothing.

A `bool`, `pressing`, remembers that a press is going on over the arena. The UI
always knows what the mouse is over, but a finger is different: the UI only
notices it a frame after it lands. So the tank checks on **every** frame of a
press, not just the first, and the moment the pointer is over the UI, the press
is forgotten: no shell, no driving.

### Do it

Replace `PlayerTank` with this version:

```csharp
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

// The player's tank. With a keyboard: W and S drive, A and D turn, the barrel
// follows the mouse, and Space or a click fires. With a finger: a quick tap
// fires towards that spot, and a press that's held drives the tank there.
[RequireComponent(typeof(Tracks))]
[RequireComponent(typeof(Turret))]
[RequireComponent(typeof(Health))]
public class PlayerTank : MonoBehaviour
{
    [SerializeField] float tapTime = 0.25f;       // a press shorter than this is a tap: it fires

    Tracks tracks;
    Turret turret;
    Camera cam;
    bool pressing = false;
    float pressStartTime = 0f;

    public Health Health { get; private set; }

    void Awake()
    {
        tracks = GetComponent<Tracks>();
        turret = GetComponent<Turret>();
        Health = GetComponent<Health>();
        cam = Camera.main;
    }

    void Update()
    {
        tracks.Stop();
        ReadKeyboard();
        ReadPointer();
    }

    // Tank controls: forwards and backwards along the way it faces, and turning
    // on the spot. A phone may have no keyboard at all, so check for null first.
    void ReadKeyboard()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard == null)
        {
            return;
        }

        float drive = 0f;
        float turn = 0f;
        if (keyboard.wKey.isPressed || keyboard.upArrowKey.isPressed)
        {
            drive += 1f;
        }
        if (keyboard.sKey.isPressed || keyboard.downArrowKey.isPressed)
        {
            drive -= 1f;
        }
        if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed)
        {
            turn += 1f;
        }
        if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed)
        {
            turn -= 1f;
        }
        tracks.Drive(drive, turn);

        if (keyboard.spaceKey.wasPressedThisFrame)
        {
            Fire();
        }
    }

    // The mouse or a finger. The barrel always aims at it. A tap fires; holding
    // it down drives the tank towards it.
    void ReadPointer()
    {
        Pointer pointer = Pointer.current;
        if (pointer == null)
        {
            return;
        }

        Vector2 world = cam.ScreenToWorldPoint(pointer.position.ReadValue());
        turret.AimAt(world);

        if (pointer.press.wasPressedThisFrame)
        {
            pressing = true;
            pressStartTime = Time.time;
        }
        // A press on a button isn't for the tank. The UI only knows a finger is
        // on a button a frame after it lands, so check on every frame.
        if (EventSystem.current.IsPointerOverGameObject())
        {
            pressing = false;
        }
        if (!pressing)
        {
            return;
        }

        float heldFor = Time.time - pressStartTime;
        if (pointer.press.wasReleasedThisFrame)
        {
            pressing = false;
            if (heldFor < tapTime)
            {
                Fire();    // a quick tap
            }
        }
        else if (heldFor >= tapTime)
        {
            tracks.DriveTowards(world);    // a press that's held
        }
    }

    void Fire()
    {
        turret.Fire();
    }
}
```

What's new:

- `using UnityEngine.EventSystems;`, the new comments, `tapTime`, and two fields:
  `pressing` and `pressStartTime`.
- `ReadPointer` still aims the barrel at the pointer every frame. A new press
  starts `pressing`, and the UI check stops it. While it lasts, `heldFor` is how
  long it's been down: released quickly, it fires; held on, it drives.

### Test it — with the mouse

Press **Play**. A quick click fires, as before. Now press and hold the mouse
button: after a quarter of a second, the tank turns towards the pointer and
drives there, and follows it as you move the mouse. Let go: it stops. The keys
still work as before.

### Test it — with a finger, in the Simulator

1. **Window → General → Device Simulator**. The Simulator opens next to the Game
   view.
2. At the top, pick a phone, and click **Rotate** to turn it sideways.
3. Press **Play**. In the Simulator, the mouse acts as a finger. Tap an enemy:
   the barrel swings towards your finger and fires. If it had far to turn, the
   first shell misses (Challenge 1 fixes that); tap again, and it hits. Press and
   hold to drive.
4. Switch back to the **Game** tab when you're done.

### Challenge

1. Tap far behind your tank: the shell flies off the wrong way, because the tap
   was over before the barrel could turn round. Make a tap wait for the barrel:
   keep the tap's point in a field, and fire from `Update` only once
   `turret.IsAimedAt(point, 5f)` says the barrel points there.
2. Try a **Tap Time** of `0.1` and of `0.5`, in the Simulator. Which feels best?

## Chapter 10 — The Follow Camera

**Goal:** the camera zooms in on your tank and follows it smoothly, without ever
showing anything outside the arena. And it shakes when a tank explodes.

### Idea — after everyone else has moved

The camera must move **after** your tank has moved this frame, or it would always
be a frame behind. `LateUpdate` is called after every `Update` of the frame
(C# 2), so the camera does its work there.

### Idea — following smoothly

`Vector3.Lerp(from, to, t)` gives a point part of the way from `from` to `to`:
with `t` at 0.1, a tenth of the way. Every frame, the camera moves from where it
is towards where it wants to be, with `t = smoothing * Time.deltaTime`. With
`smoothing` at 5 and 60 frames a second, that's about 8% of the distance left:
quick when the tank is far away, gentle as the camera catches up.

### Idea — never outside the arena

A camera with **Size** 5 shows 5 units above and below its middle, and, on a
16:9 screen, 8.9 units to each side: `cam.orthographicSize` times `cam.aspect`,
the screen's width divided by its height. So the camera's middle must stay 8.9
units inside the left and right edges of the arena, and 5 inside the top and
bottom:

| | Arena | Camera's middle may go |
| --- | --- | --- |
| **x** | −12 to 12 | −3.1 to 3.1 |
| **y** | −8 to 8 | −3 to 3 |

`Mathf.Clamp` does it, with the arena's size from `ArenaBounds`: the static class
from Chapter 5 pays off.

### Idea — a shake, in two sizes

`CameraFollow` has two versions of `Shake`, as overloads (C# 3):
`Shake(0.3f)` shakes for 0.3 seconds with the default strength, and
`Shake(0.6f, 0.4f)` shakes longer and harder, for when your tank is destroyed.
The short version only calls the long one, with `defaultShake`: the shaking
itself is written once.

The camera keeps where it's following to, `followPosition`, apart from the
shake's jolt, which is added on top at the very end. That way, the shaking never
pushes the following off course.

### Do it

1. Select **Main Camera**, and set its **Size** to `5`.
2. Create `CameraFollow`, attach it to **Main Camera**, and drag `Player Tank`
   into its **Target**:

```csharp
using UnityEngine;

// Follows the player's tank, smoothly, without ever showing anything outside
// the arena. It can shake too, when something explodes.
[RequireComponent(typeof(Camera))]
public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float smoothing = 5f;        // bigger catches up faster
    [SerializeField] float defaultShake = 0.15f;

    Camera cam;
    Vector3 followPosition;
    float shakeTimeLeft = 0f;
    float shakeStrength = 0f;

    void Awake()
    {
        cam = GetComponent<Camera>();
        followPosition = transform.position;
    }

    // Two versions (overloads): a normal shake, or one as strong as you ask.
    public void Shake(float seconds)
    {
        Shake(seconds, defaultShake);
    }

    public void Shake(float seconds, float strength)
    {
        shakeTimeLeft = seconds;
        shakeStrength = strength;
    }

    // LateUpdate: after the tank has moved this frame.
    void LateUpdate()
    {
        // Where the camera wants to be: over the tank, but no nearer the edge of
        // the arena than half of what it shows.
        float halfHeight = cam.orthographicSize;
        float halfWidth = halfHeight * cam.aspect;
        float maxX = ArenaBounds.HalfWidth - halfWidth;
        float maxY = ArenaBounds.HalfHeight - halfHeight;
        Vector3 wanted = target.position;
        wanted.x = Mathf.Clamp(wanted.x, -maxX, maxX);
        wanted.y = Mathf.Clamp(wanted.y, -maxY, maxY);
        wanted.z = transform.position.z;

        followPosition = Vector3.Lerp(followPosition, wanted, smoothing * Time.deltaTime);

        Vector3 jolt = Vector3.zero;
        if (shakeTimeLeft > 0f)
        {
            shakeTimeLeft -= Time.deltaTime;
            jolt = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f) * shakeStrength;
        }
        transform.position = followPosition + jolt;
    }
}
```

3. In `ArenaGame`:
   - Add a field under `player`:

```csharp
    [SerializeField] CameraFollow cameraFollow;
```

   - In `Update`, just after `ShowMessage("Destroyed!");`, a big shake:

```csharp
            cameraFollow.Shake(0.6f, 0.4f);
```

   - In `EnemyDestroyed`, after `enemies.Remove(enemy);`, a small one:

```csharp
        cameraFollow.Shake(0.3f);
```

4. Select `Arena Game`, and drag **Main Camera** into **Camera Follow**.

Read `CameraFollow` before you move on:

- `[RequireComponent(typeof(Camera))]`, and the camera found in `Awake`.
- `wanted` starts at the tank's position, and is clamped so that the camera's
  edges stay inside the arena. `wanted.z` keeps the camera's own `z`, −10: a
  camera at `z = 0` would be level with the sprites, and see nothing.
- `followPosition` moves a little towards `wanted` every frame, with `Lerp`.
- While a shake lasts, `jolt` is a small random offset; otherwise it's
  `Vector3.zero`, and the camera sits exactly on `followPosition`.

### Test it

Press **Play**, and drive around. The camera follows your tank, a little behind
it, and stops at the edges of the arena: the brown border never shows, except for
a flicker when the camera shakes right at an edge. Destroy an enemy: a small
jolt. Let your tank be destroyed: a bigger, longer shake.

### Challenge

1. Try a **Smoothing** of `1`, then `20`. Which do you prefer, and why?
2. Change the camera's **Size** to `6` while the game is running. Does the camera
   still stay inside the arena? Which line makes that work?

# Part 4 — Polish

## C# 13 — Dictionaries

**Goal:** you can store values under keys in a `Dictionary<TKey, TValue>`, look
them up safely, and loop through them.

### Idea — look it up by name, not by position

Your phone's contacts work like this: you look up a **name** (the **key**) and
get a **number** (the **value**). Arrays and lists find things by position: 0,
1, 2… A **dictionary** finds things by key, and the key can be almost any type,
usually a `string` or an `int`.

```csharp
Dictionary<string, int> prices = new Dictionary<string, int>();
prices.Add("Sword", 150);
prices.Add("Shield", 90);
prices["Potion"] = 25;

Debug.Log(prices["Sword"]);
Debug.Log(prices.Count);
```

```
150
3
```

- `Dictionary<string, int>`: the keys are `string`s, the values are `int`s.
- `prices["Sword"]` reads the value stored under the key `"Sword"`.
- A dictionary needs the same `using System.Collections.Generic;` as a list.

### Idea — the dictionary toolbox

| Code | Does |
| --- | --- |
| `dict.Add(key, value)` | adds a new pair; an **error** if the key is already there |
| `dict[key] = value` | adds the pair, or **replaces** the value if the key is already there |
| `dict[key]` | reads a value; an **error** if the key isn't there |
| `dict.ContainsKey(key)` | `true` if the key is there |
| `dict.TryGetValue(key, out value)` | reads safely: `true` and the value, or `false` |
| `dict.Remove(key)` | removes the key and its value |
| `dict.Count` | how many pairs |
| `dict.Keys` / `dict.Values` | all the keys / all the values, to loop over |

**Keys are unique**: one key, one value. Values can repeat: a sword and an axe
can both cost 150.

```csharp
Dictionary<string, int> stock = new Dictionary<string, int>();
stock["Apple"] = 5;
stock["Apple"] = stock["Apple"] + 3;
Debug.Log(stock["Apple"]);
```

```
8
```

> **Watch out:** reading a key that isn't there, like `prices["Bow"]`, stops your
> code with a **KeyNotFoundException**. Calling `Add` with a key that's already
> there gives an **ArgumentException**. The next idea shows how to avoid both.

### Idea — reading safely

Ask first with `ContainsKey`, or ask and read in one go with `TryGetValue`, which
uses the Try pattern and an `out` parameter (C# 3):

```csharp
if (prices.ContainsKey("Bow"))
{
    Debug.Log(prices["Bow"]);
}
else
{
    Debug.Log("We don't sell bows");
}

if (prices.TryGetValue("Shield", out int shieldPrice))
{
    Debug.Log("A shield costs " + shieldPrice);
}
```

```
We don't sell bows
A shield costs 90
```

### Idea — looping through a dictionary

`foreach` gives you one **pair** at a time: a `KeyValuePair<TKey, TValue>` with a
`.Key` and a `.Value`:

```csharp
foreach (KeyValuePair<string, int> pair in prices)
{
    Debug.Log(pair.Key + " costs " + pair.Value);
}
```

```
Sword costs 150
Shield costs 90
Potion costs 25
```

You can also loop over just the keys (`foreach (string item in prices.Keys)`) or
just the values.

> **Watch out:** a dictionary doesn't promise any order. Here the pairs come out
> in the order they were added, but once you start removing keys that can
> change. And, as with lists, don't `Add` or `Remove` while a `foreach` is
> running over the dictionary.

### Idea — fill it as you make it

Like a list, a dictionary can be filled as you create it. Each pair goes in its
own `{ }`:

```csharp
Dictionary<string, int> points = new Dictionary<string, int>
{
    { "Block", 1 },
    { "GoldBlock", 5 },
    { "BadBlock", -1 },
};
Debug.Log(points["GoldBlock"]);
```

```
5
```

Think back to Level 1: `GameManager` used a `switch` on the block's tag to decide
the points. With this dictionary, the whole `switch` becomes one line:
`score += points[blockTag];`. And adding a new kind of block means adding one
line to the dictionary, not a new `case`.

### Idea — array, list or dictionary?

| Collection | Finds an element by… | Example |
| --- | --- | --- |
| array | its position, and the size is fixed | the three life icons |
| `List` | its position, and it grows and shrinks | the enemies that are alive |
| `Dictionary` | its key | the points for each kind of enemy, or the name for each score |

### Do it

1. Make a `Dictionary<string, int>` of three friends' ages. Print one age,
   change it with `[ ]`, and print it again.
2. Loop through the dictionary and print `"Name is N years old"` for each pair.
3. Use `TryGetValue` to look up a name that isn't there and print
   `"Unknown friend"`.
4. Call `Add` with a name that's already there. Read the error in the Console,
   then remove the line.

### Challenge

Count words. Split a sentence into an array of words with
`string[] words = "the cat and the dog and the bird".Split(' ');`, then use a
`Dictionary<string, int>` to count how many times each word appears. Print every
word with its count.

## C# 14 — UI Events: Listening for Changes

**Goal:** you can run a method of your own when a button is clicked, or when a
slider, toggle, input field or dropdown changes, and connect it from code with
`AddListener`.

### Idea — the UI tells you when something changes

In Level 1 you connected the Play button in the Inspector, in its **On Click ()**
list. Every UI control has an **event** like that: a list of methods it calls
when something happens. Each control's event hands your method the new value:

| Control | Event | Your method looks like |
| --- | --- | --- |
| Button | `onClick` | `void OnPlayClicked()`: no value |
| Slider | `onValueChanged` | `void OnVolumeChanged(float value)` |
| Toggle | `onValueChanged` | `void OnMusicToggled(bool isOn)` |
| Input Field (TextMeshPro) | `onValueChanged` (every letter), `onEndEdit` (typing finished) | `void OnNameEntered(string text)` |
| Dropdown (TextMeshPro) | `onValueChanged` | `void OnColourChosen(int index)` |

### Idea — AddListener

Instead of filling the list in the Inspector, you can add your method to it from
code:

```csharp
using UnityEngine;
using UnityEngine.UI;

public class Practice : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;

    void OnEnable()
    {
        volumeSlider.onValueChanged.AddListener(OnVolumeChanged);
    }

    void OnDisable()
    {
        volumeSlider.onValueChanged.RemoveListener(OnVolumeChanged);
    }

    void OnVolumeChanged(float value)
    {
        Debug.Log("Volume: " + value);
    }
}
```

Move the slider while the game runs, and the Console shows every change:

```
Volume: 0.3721154
Volume: 0.5
```

(Your numbers depend on where you drag the handle.)

- `using UnityEngine.UI;` gives you `Slider`, `Toggle` and `Button`.
- `AddListener(OnVolumeChanged)` has **no brackets** after the method's name.
  You're not calling the method: you're **handing it over**, so the slider can
  call it later, every time its value changes.
- The method's parameter must match the event: a slider sends a `float`. A
  method with the wrong parameter gives error CS1503: *Argument 1: cannot
  convert from 'method group' to 'UnityEngine.Events.UnityAction<float>'*.
- Add the listener in `OnEnable` and remove it in `OnDisable`
  (C# 2). Then a hidden settings panel doesn't react, and the pairs
  always match up.

### Idea — each control

```csharp
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Practice : MonoBehaviour
{
    [SerializeField] Toggle musicToggle;
    [SerializeField] TMP_InputField nameInput;
    [SerializeField] TMP_Dropdown colourDropdown;

    void OnEnable()
    {
        musicToggle.onValueChanged.AddListener(OnMusicToggled);
        nameInput.onEndEdit.AddListener(OnNameEntered);
        colourDropdown.onValueChanged.AddListener(OnColourChosen);
    }

    void OnDisable()
    {
        musicToggle.onValueChanged.RemoveListener(OnMusicToggled);
        nameInput.onEndEdit.RemoveListener(OnNameEntered);
        colourDropdown.onValueChanged.RemoveListener(OnColourChosen);
    }

    void OnMusicToggled(bool isOn)
    {
        Debug.Log("Music on: " + isOn);
    }

    void OnNameEntered(string text)
    {
        Debug.Log("Hello, " + text);
    }

    void OnColourChosen(int index)
    {
        Debug.Log("You chose " + colourDropdown.options[index].text);
    }
}
```

Untick the toggle, type `Lina` and press **Enter**, then choose the third option
of a dropdown whose options are Red, Green and Blue. The Console shows:

```
Music on: False
Hello, Lina
You chose Blue
```

| Control | Read its value any time | Remember |
| --- | --- | --- |
| Slider | `slider.value` | set **Min Value**, **Max Value** and **Whole Numbers** in the Inspector |
| Toggle | `toggle.isOn` | |
| Input Field | `inputField.text` | `onEndEdit` fires once, when typing is finished |
| Dropdown | `dropdown.value` | an **index**: the first option is 0; the option's text is `dropdown.options[index].text` |

`TMP_InputField` and `TMP_Dropdown` live in `using TMPro;`, like `TMP_Text`.

### Idea — changing a value without the event

When **your code** sets a control, its event fires too: `slider.value = 0.5f;`
calls every listener, just as if the player had moved it. When you only want to
show a value, for example when the settings panel opens, set it **quietly**:

| Control | Set quietly |
| --- | --- |
| Slider | `slider.SetValueWithoutNotify(0.5f);` |
| Toggle | `toggle.SetIsOnWithoutNotify(true);` |
| Input Field | `inputField.SetTextWithoutNotify("Player");` |
| Dropdown | `dropdown.SetValueWithoutNotify(2);` |

### Idea — Inspector or code?

Both work, and the exam shows both:

| In the Inspector's event list | In code, with AddListener |
| --- | --- |
| no code, quick to set up | everything is visible in the script |
| your method must be `public`; choose it under **Dynamic float** (or bool, string, int) to receive the value | the method can stay private |
| the connection lives in the scene | works for UI you create while the game runs |

### Do it

1. Create a Canvas with a Slider, a Toggle, an Input Field and a Dropdown:
   **GameObject → UI (Canvas) → Slider**, **Toggle**, **Input Field -
   TextMeshPro** and **Dropdown - TextMeshPro**. Spread them out on the screen.
2. In the Dropdown's Inspector, change its **Options** to `Red`, `Green` and
   `Blue`.
3. Put both examples in your `Practice` script (one class, all four fields), drag
   the controls into the fields, press Play and use every control.
4. Give `OnVolumeChanged` a `string` parameter instead of `float`, and read the
   error.
5. Open the Toggle's **On Value Changed (Boolean)** list in the Inspector and
   connect it to a `public` method, the Level 1 way. Use the toggle: now two
   methods react.

### Challenge

Make a "dimmer": a Slider from 0 to 1 that changes the alpha (transparency) of an
Image's colour as you drag it. When the game starts, set the slider to 1 without
calling the listener.

## Chapter 11 — Start and End

**Goal:** the game waits on a start screen until you press **Play**. When your
tank is destroyed, or when you clear the last round, an end screen says
"Destroyed!" or "Victory!", with your name and the numbers of the match: the
rounds you cleared, the tanks you destroyed of each kind, your shots, and how
many shots each kill took. **Play Again** starts a new match.

### Idea — a game has states

A game isn't always being played: there's before the start, the match itself,
and after the end. `ArenaGame` keeps one property, `IsPlaying`
(C# 6), and everything that should only happen during a match
checks it first: your tank ignores the controls, and your health only counts
while you play.

| Method | Does |
| --- | --- |
| `Awake` | not playing yet: shows the start panel |
| `StartGame` | clears the arena, starts new numbers, hides the panels, resets your tank, starts the rounds |
| `EndGame(won)` | stops playing, stops the rounds, and shows the end panel |

`Start` has gone: the rounds wait until you press **Play**.

### Idea — buttons in code

In Level 1, the Play button was connected in the Inspector. This time, the code
connects both buttons (C# 14): `AddListener` in `OnEnable`, and
`RemoveListener` in `OnDisable`. **Play** and **Play Again** both call
`StartGame`.

### Idea — the numbers of a match

The numbers go in a class of their own, `MatchStats`: a **plain C# class**,
which doesn't derive from `MonoBehaviour`, so it's never attached to a
GameObject (C# 6). The game makes a new one with `new` at the
start of every match, so every match starts from zero:

```csharp
stats = new MatchStats(new string[] { "Light Tank", "Heavy Tank" });
```

The constructor gets the names of the kinds of tank, and starts each one at 0 in
a `Dictionary<string, int>` (C# 13): the key is the tank's name,
and the value is how many you've destroyed. That way the end screen lists every
kind of tank, even one you never destroyed.

| Member | Is |
| --- | --- |
| `RoundsCleared`, `ShotsFired` | counts, with a `private set` |
| `TotalKills` | a property that adds up every value in the dictionary |
| `ShotsPerKill` | a property: shots divided by kills, or 0 before the first kill |
| `AddRound()`, `AddShot()`, `AddKill(tankName)` | add one |
| `Summary()` | everything, one line each, for the end panel |

`{ShotsPerKill:F1}` shows the number with one decimal (C# 10): 8 shots
for 3 kills is 2.666…, and shows as `2.7`.

### Idea — every enemy has a name

`EnemyTank` gets a `tankName` field and a `TankName` property, so the game knows
what kind of tank it destroyed: the `Light Tank` prefab says "Light Tank", and
the `Heavy Tank` prefab says "Heavy Tank". They're the dictionary's keys, so they
must match the names the game gives `MatchStats`, letter for letter.

### Idea — counting your shots

Since Chapter 4, `turret.Fire()` has said whether it fired. Your tank finally
uses the answer: only a shell that really left the barrel counts.

```csharp
if (turret.Fire())
{
    game.ShotFired();
}
```

### Idea — a fresh start

**Play Again** must put everything back:

- `ClearArena` destroys every enemy still in the arena, and empties the list.
- `ResetTank` puts your tank back in the middle, facing up, standing still, and
  calls `Health.ResetHealth()`, a new method that fills its health again.
- `StartGame` calls `StopAllCoroutines()` first, in case a match was still
  running.

`EndGame` chooses its title with `?:`, the one-line if / else you met again in
`Tracks`: `won ? "Victory!" : "Destroyed!"`.

### Do it — the start panel

> **Watch out:** the **GameObject** menu always puts new UI straight onto the
> Canvas, whatever you've selected. To put a new UI element **inside** another
> one, right-click the parent in the Hierarchy and choose **UI (Canvas) → …**
> there.

1. **GameObject → UI (Canvas) → Panel**, named `Start Panel`. It covers the whole
   screen: set its **Color** to black, with **Alpha** around 140, to dim the game
   behind it.
2. Right-click `Start Panel` → **UI (Canvas) → Image**, and name it `Window`:
   anchor middle-center, **Width** `600`, **Height** `320`, colour `#2F3B28`, and
   **Scale** `(2, 2, 1)`. The standard buttons are small; scaling the window
   makes everything in it bigger at once.
3. Make these inside `Window`, right-clicking `Window` each time:

| Object | Type | Pos | Size | Settings |
| --- | --- | --- | --- | --- |
| `Title` | Text - TextMeshPro | (0, 105) | 560 × 70 | "Tank Arena", size 48, centre, middle |
| `How To Play` | Text - TextMeshPro | (0, 15) | 560 × 100 | three lines, below; size 17, centre, middle |
| `Play Button` | Button - TextMeshPro | (0, −105) | 200 × 50 | colour `#D98E04`, text "Play", size 25 |

The three lines of `How To Play` (press **Enter** between them):

```
Keys: W and S drive, A and D turn, Space fires
Mouse or finger: the barrel aims where you point
Tap to fire, or press and hold to drive there
```

### Do it — the end panel

1. Another **Panel**, named `End Panel`, black with **Alpha** around 140, and
   inside it a `Window` like the first one, but **Width** `560` and **Height**
   `360`.
2. Inside this `Window`:

| Object | Type | Pos | Size | Settings |
| --- | --- | --- | --- | --- |
| `End Text` | Text - TextMeshPro | (0, 30) | 520 × 270 | "Destroyed!", size 20, centre, top |
| `Play Again Button` | Button - TextMeshPro | (0, −145) | 200 × 40 | colour `#D98E04`, text "Play Again", size 20 |

3. Hide `End Panel`: untick the checkbox next to its name in the Inspector.

### Do it — the code

Five scripts change. `ArenaGame` and `PlayerTank` use each other: the game
resets your tank, and your tank asks the game whether it's playing and reports
its shots. Do the steps in order.

> **Note:** after step 4, the Console shows errors until you've done step 5.
> That's expected: each of the two scripts uses something that's only in the new
> version of the other.

1. Create `MatchStats`, and replace everything in it with this:

```csharp:MatchStats.cs
using System.Collections.Generic;

// The numbers of one match: rounds cleared, shots fired, and how many tanks of
// each kind were destroyed. A plain C# class: the game makes a new one, with
// new, at the start of every match.
public class MatchStats
{
    readonly Dictionary<string, int> kills = new Dictionary<string, int>();

    public int RoundsCleared { get; private set; }
    public int ShotsFired { get; private set; }

    public MatchStats(string[] tankNames)
    {
        // Every kind of tank starts at 0, so the summary lists them all.
        foreach (string tankName in tankNames)
        {
            kills[tankName] = 0;
        }
    }

    public int TotalKills
    {
        get
        {
            int total = 0;
            foreach (KeyValuePair<string, int> pair in kills)
            {
                total += pair.Value;
            }
            return total;
        }
    }

    // How many shots each kill took, on average: 0 until there's a kill.
    public float ShotsPerKill
    {
        get
        {
            if (TotalKills == 0)
            {
                return 0f;
            }
            return (float)ShotsFired / TotalKills;
        }
    }

    public void AddRound()
    {
        RoundsCleared++;
    }

    public void AddShot()
    {
        ShotsFired++;
    }

    public void AddKill(string tankName)
    {
        if (kills.ContainsKey(tankName))
        {
            kills[tankName]++;
        }
        else
        {
            kills[tankName] = 1;
        }
    }

    // Everything, one line each, for the end panel.
    public string Summary()
    {
        string lines = $"Rounds cleared: {RoundsCleared}\n";
        foreach (KeyValuePair<string, int> pair in kills)
        {
            lines += $"{pair.Key}s destroyed: {pair.Value}\n";
        }
        lines += $"Shots fired: {ShotsFired}\n";
        lines += $"Shots per kill: {ShotsPerKill:F1}";
        return lines;
    }
}
```

2. Replace `EnemyTank` with its final version:

```csharp:EnemyTank.cs
using System.Collections;
using UnityEngine;

// An enemy tank. It drives around the arena to random places; whenever it can
// see the player, with no wall in the way, it stops, turns its barrel and fires.
[RequireComponent(typeof(Tracks))]
[RequireComponent(typeof(Turret))]
[RequireComponent(typeof(Health))]
public class EnemyTank : MonoBehaviour
{
    [SerializeField] string tankName = "Light Tank";
    [SerializeField] float sightRange = 8f;
    [SerializeField] LayerMask sightMask;         // what its eyes stop at: the walls and the player
    [SerializeField] float thinkTime = 3f;        // seconds between two new places to go

    Tracks tracks;
    Turret turret;
    ArenaGame game;
    Transform target;
    Vector2 destination;

    public string TankName
    {
        get { return tankName; }
    }

    public Health Health { get; private set; }

    void Awake()
    {
        tracks = GetComponent<Tracks>();
        turret = GetComponent<Turret>();
        Health = GetComponent<Health>();
        destination = transform.position;
    }

    void Start()
    {
        StartCoroutine(Think());
    }

    // The game hands every new enemy the game itself, and the tank to hunt.
    public void SetGame(ArenaGame arenaGame)
    {
        game = arenaGame;
        target = game.Player.transform;
    }

    // Every few seconds, choose somewhere new to go.
    IEnumerator Think()
    {
        while (true)
        {
            destination = ArenaBounds.RandomPoint();
            yield return new WaitForSeconds(thinkTime);
        }
    }

    void Update()
    {
        if (Health.IsDead)
        {
            game.EnemyDestroyed(this);
            Destroy(gameObject);
            return;
        }

        if (CanSeeTarget(out Vector2 targetPosition))
        {
            tracks.Stop();
            turret.AimAt(targetPosition);
            if (turret.IsAimedAt(targetPosition, 5f))
            {
                turret.Fire();
            }
        }
        else
        {
            // Drive on, with the barrel pointing straight ahead again.
            tracks.DriveTowards(destination);
            turret.AimAt((Vector2)transform.position + (Vector2)transform.up);
        }
    }

    // Can it see the player: close enough, with nothing in the way? If so,
    // targetPosition says where the player is.
    bool CanSeeTarget(out Vector2 targetPosition)
    {
        targetPosition = Vector2.zero;
        if (target == null || !target.gameObject.activeInHierarchy)
        {
            return false;
        }

        targetPosition = target.position;
        Vector2 toTarget = targetPosition - (Vector2)transform.position;
        if (toTarget.magnitude > sightRange)
        {
            return false;
        }

        Vector2 direction = toTarget.normalized;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, sightRange, sightMask);
        Debug.DrawRay(transform.position, direction * sightRange, Color.yellow);
        return hit.collider != null && hit.transform == target;
    }
}
```

   The only changes: the `tankName` field and the `TankName` property. Open the
   `Heavy Tank` prefab, and set its **Tank Name** to `Heavy Tank`. The
   `Light Tank` prefab already says `Light Tank`: it's the field's starting value.

3. In `Health`, add this method at the end of the class:

```csharp
    public void ResetHealth()
    {
        Current = maxHealth;
    }
```

4. Replace `ArenaGame` with this version:

```csharp
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Runs the match: the rounds of enemy tanks, the screen, and the start and
// end panels.
public class ArenaGame : MonoBehaviour
{
    [SerializeField] PlayerTank player;
    [SerializeField] CameraFollow cameraFollow;
    [SerializeField] GameObject lightTankPrefab;
    [SerializeField] GameObject heavyTankPrefab;
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] int[] lightTanksPerRound = { 2, 3, 2, 2 };
    [SerializeField] int[] heavyTanksPerRound = { 0, 0, 1, 2 };
    [SerializeField] Image healthFill;
    [SerializeField] TMP_Text roundText;
    [SerializeField] TMP_Text enemiesText;
    [SerializeField] TMP_Text messageText;
    [SerializeField] GameObject startPanel;
    [SerializeField] Button playButton;
    [SerializeField] GameObject endPanel;
    [SerializeField] TMP_Text endText;
    [SerializeField] Button playAgainButton;

    readonly List<EnemyTank> enemies = new List<EnemyTank>();
    MatchStats stats;
    int round = 1;                                // the round being played, counting from 1
    Coroutine hideMessage;

    public bool IsPlaying { get; private set; }
    public string CommanderName { get; set; } = "Commander";

    public PlayerTank Player
    {
        get { return player; }
    }

    int RoundCount
    {
        get { return lightTanksPerRound.Length; }
    }

    void Awake()
    {
        IsPlaying = false;
        startPanel.SetActive(true);
        endPanel.SetActive(false);
        messageText.text = "";
    }

    void OnEnable()
    {
        playButton.onClick.AddListener(StartGame);
        playAgainButton.onClick.AddListener(StartGame);
    }

    void OnDisable()
    {
        playButton.onClick.RemoveListener(StartGame);
        playAgainButton.onClick.RemoveListener(StartGame);
    }

    void Update()
    {
        if (IsPlaying && player.Health.IsDead)
        {
            player.gameObject.SetActive(false);
            EndGame(false);
        }
        UpdateScreen();
    }

    public void StartGame()
    {
        StopAllCoroutines();
        ClearArena();
        stats = new MatchStats(new string[] { "Light Tank", "Heavy Tank" });
        startPanel.SetActive(false);
        endPanel.SetActive(false);
        player.gameObject.SetActive(true);
        player.ResetTank();
        IsPlaying = true;
        StartCoroutine(PlayRounds());
    }

    // The whole match: each round counts down, sends its tanks, and waits
    // until every one of them has been destroyed.
    IEnumerator PlayRounds()
    {
        for (int number = 1; number <= RoundCount; number++)
        {
            round = number;
            ShowMessage("Round " + round);
            yield return new WaitForSeconds(1.5f);
            for (int count = 3; count > 0; count--)
            {
                ShowMessage(count.ToString());
                yield return new WaitForSeconds(0.6f);
            }
            ShowMessage("Go!", 0.8f);
            SpawnRound(round);

            while (enemies.Count > 0)
            {
                yield return null;
            }
            stats.AddRound();

            if (round < RoundCount)
            {
                ShowMessage("Round cleared!");
                yield return new WaitForSeconds(2f);
            }
        }
        EndGame(true);
    }

    void SpawnRound(int roundNumber)
    {
        int spawnIndex = 0;
        for (int i = 0; i < lightTanksPerRound[roundNumber - 1]; i++)
        {
            Spawn(lightTankPrefab, spawnIndex);
            spawnIndex++;
        }
        for (int i = 0; i < heavyTanksPerRound[roundNumber - 1]; i++)
        {
            Spawn(heavyTankPrefab, spawnIndex);
            spawnIndex++;
        }
    }

    void Spawn(GameObject prefab, int spawnIndex)
    {
        // % goes round the spawn points: with 4 points, tank 5 uses point 0 again.
        Transform point = spawnPoints[spawnIndex % spawnPoints.Length];
        GameObject tank = Instantiate(prefab, point.position, point.rotation);
        EnemyTank enemy = tank.GetComponent<EnemyTank>();
        enemy.SetGame(this);
        enemies.Add(enemy);
    }

    public void EnemyDestroyed(EnemyTank enemy)
    {
        enemies.Remove(enemy);
        stats.AddKill(enemy.TankName);
        cameraFollow.Shake(0.3f);
    }

    public void ShotFired()
    {
        stats.AddShot();
    }

    void EndGame(bool won)
    {
        IsPlaying = false;
        StopAllCoroutines();
        messageText.text = "";

        string title = won ? "Victory!" : "Destroyed!";
        endText.text = $"{title}\n\n{CommanderName}\n{stats.Summary()}";
        endPanel.SetActive(true);
        if (!won)
        {
            cameraFollow.Shake(0.6f, 0.4f);
        }
    }

    // Removes every enemy, for a new match.
    void ClearArena()
    {
        foreach (EnemyTank enemy in enemies)
        {
            Destroy(enemy.gameObject);
        }
        enemies.Clear();
    }

    // Two versions of ShowMessage (overloads): one message stays on screen,
    // the other disappears after a few seconds.
    public void ShowMessage(string text)
    {
        if (hideMessage != null)
        {
            StopCoroutine(hideMessage);
        }
        messageText.text = text;
    }

    public void ShowMessage(string text, float seconds)
    {
        ShowMessage(text);
        hideMessage = StartCoroutine(HideMessageAfter(seconds));
    }

    IEnumerator HideMessageAfter(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        messageText.text = "";
    }

    void UpdateScreen()
    {
        healthFill.fillAmount = player.Health.Fraction;
        roundText.text = $"Round {round} of {RoundCount}";
        enemiesText.text = "Enemies: " + enemies.Count;
    }
}
```

5. Replace `PlayerTank` with this version:

```csharp
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

// The player's tank. With a keyboard: W and S drive, A and D turn, the barrel
// follows the mouse, and Space or a click fires. With a finger: a quick tap
// fires towards that spot, and a press that's held drives the tank there.
[RequireComponent(typeof(Tracks))]
[RequireComponent(typeof(Turret))]
[RequireComponent(typeof(Health))]
public class PlayerTank : MonoBehaviour
{
    [SerializeField] ArenaGame game;
    [SerializeField] float tapTime = 0.25f;       // a press shorter than this is a tap: it fires

    Tracks tracks;
    Turret turret;
    Rigidbody2D body;
    Camera cam;
    Vector2 startPosition;
    bool pressing = false;
    float pressStartTime = 0f;

    public Health Health { get; private set; }

    void Awake()
    {
        tracks = GetComponent<Tracks>();
        turret = GetComponent<Turret>();
        body = GetComponent<Rigidbody2D>();
        Health = GetComponent<Health>();
        cam = Camera.main;
        startPosition = transform.position;
    }

    void Update()
    {
        tracks.Stop();
        if (!game.IsPlaying)
        {
            pressing = false;
            return;
        }

        ReadKeyboard();
        ReadPointer();
    }

    // Tank controls: forwards and backwards along the way it faces, and turning
    // on the spot. A phone may have no keyboard at all, so check for null first.
    void ReadKeyboard()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard == null)
        {
            return;
        }

        float drive = 0f;
        float turn = 0f;
        if (keyboard.wKey.isPressed || keyboard.upArrowKey.isPressed)
        {
            drive += 1f;
        }
        if (keyboard.sKey.isPressed || keyboard.downArrowKey.isPressed)
        {
            drive -= 1f;
        }
        if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed)
        {
            turn += 1f;
        }
        if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed)
        {
            turn -= 1f;
        }
        tracks.Drive(drive, turn);

        if (keyboard.spaceKey.wasPressedThisFrame)
        {
            Fire();
        }
    }

    // The mouse or a finger. The barrel always aims at it. A tap fires; holding
    // it down drives the tank towards it.
    void ReadPointer()
    {
        Pointer pointer = Pointer.current;
        if (pointer == null)
        {
            return;
        }

        Vector2 world = cam.ScreenToWorldPoint(pointer.position.ReadValue());
        turret.AimAt(world);

        if (pointer.press.wasPressedThisFrame)
        {
            pressing = true;
            pressStartTime = Time.time;
        }
        // A press on a button isn't for the tank. The UI only knows a finger is
        // on a button a frame after it lands, so check on every frame.
        if (EventSystem.current.IsPointerOverGameObject())
        {
            pressing = false;
        }
        if (!pressing)
        {
            return;
        }

        float heldFor = Time.time - pressStartTime;
        if (pointer.press.wasReleasedThisFrame)
        {
            pressing = false;
            if (heldFor < tapTime)
            {
                Fire();    // a quick tap
            }
        }
        else if (heldFor >= tapTime)
        {
            tracks.DriveTowards(world);    // a press that's held
        }
    }

    void Fire()
    {
        if (turret.Fire())
        {
            game.ShotFired();
        }
    }

    // Back to the start, facing up, with full health, for a new match.
    public void ResetTank()
    {
        tracks.Stop();
        body.position = startPosition;
        body.rotation = 0f;
        transform.position = startPosition;
        transform.rotation = Quaternion.identity;
        body.linearVelocity = Vector2.zero;
        body.angularVelocity = 0f;
        Health.ResetHealth();
        pressing = false;
    }
}
```

Read the new `ArenaGame` before you move on:

- `CommanderName` is a property with a starting value, `"Commander"`. The end
  panel uses it; in Chapter 13, the player can type their own.
- `Awake` shows the start panel; `OnEnable` and `OnDisable` connect and
  disconnect the two buttons.
- `Update` only checks your health while `IsPlaying`.
- `PlayRounds` counts each cleared round with `stats.AddRound()`, and ends with
  `EndGame(true)` instead of a message.
- `EnemyDestroyed` counts the kill by the tank's name.
- `EndGame` builds the end panel's text: the title, your name, and the summary.
  `\n` starts a new line. Losing shakes the camera; winning doesn't need to.

And `PlayerTank`:

- A reference to the game, and `body` and `startPosition` for `ResetTank`.
- `Update` stops the tank and does nothing else while there's no match. Setting
  `pressing` to `false` there means a press that was going on when the match
  ended is forgotten.
- `Fire` tells the game about every shell that really fired.
- `ResetTank` puts the body and the Transform back where they started. It also
  stops the body moving and turning: a tank destroyed at full speed mustn't
  start the next match still sliding.

### Do it — connect it all

1. Select `Arena Game`, and drag in the five new references: `Start Panel`,
   `Play Button`, `End Panel`, `End Text` and `Play Again Button`.
2. Select `Player Tank`, and drag `Arena Game` into **Game**.

### Test it

Press **Play**: the start panel waits, and your tank doesn't move. Press **Play**
on it, and round 1 begins. Fire a few shots, destroy a tank or two, then let the
enemies win: the end panel shows "Destroyed!", "Commander", and the numbers. Check
them: the rounds, the light and heavy tanks, the shots, and the shots per kill.
Press **Play Again**: the arena empties, your tank is back in the middle with full
health, and round 1 starts again. Then play to the end for "Victory!".

### Challenge

Show how long the match took, on a line of its own under the title: "Time: 95
seconds". Remember `Time.time` in `StartGame`, and work out the difference in
`EndGame`. Use `:F0` to show it with no decimals.

## Chapter 12 — Repair Kits, Explosions and Sound

**Goal:** destroyed tanks burst into orange smoke, and shells burst in a grey
puff. Sometimes a destroyed enemy leaves a green repair kit behind: drive over it
to mend your tank. And every shot, hit, repair, explosion and ending has a sound.

### Idea — particles

A **Particle System** throws out lots of small images, each living for a moment.
Its settings are grouped into **modules**:

| Module | Controls |
| --- | --- |
| **Main** (the top section) | how long the effect lasts, whether it loops, and each particle's lifetime, speed, size and rotation |
| **Emission** | how many particles, and when: a steady stream, or a **Burst** all at once |
| **Shape** | where they come from, and which way they fly |
| **Color over Lifetime** | how their colour changes as they age: here, they fade away |
| **Renderer** | what each particle looks like: its material, and its sorting order |

Both effects are prefabs that play once, by themselves, as soon as they appear.
Their **Stop Action** is **Destroy**: when the last puff has faded, the effect
deletes itself. Each needs a **material** that shows a sprite: Kenney's smoke
puffs.

### Idea — a repair kit

A repair kit is a green barrel on the ground, turning slowly to catch the eye.
It has a **Kinematic** Rigidbody 2D and a trigger: nothing pushes it, and it
notices your tank, a Dynamic body, driving over it (the body types in Chapter
2). Then it calls `player.Health.Heal(repairAmount)`, and disappears. If nobody
takes it, it disappears after 12 seconds anyway.

`Heal` has a parameter with a **default value** (C# 3):
`Heal(int amount = 1)`. `Heal()` mends 1 point, and `Heal(2)` mends 2. Either
way, `Mathf.Min` stops it at the maximum.

### Idea — a lucky drop

`Random.value` is a random `float` from 0 to 1, so `Random.value < 0.35f` is
`true` about 35% of the time: roughly one destroyed enemy in three leaves a
repair kit. The game makes each kit a **child** of `Arena Game`, with
`Instantiate`'s last argument, so that `ClearArena` can find the leftover kits
and remove them: `foreach (Transform child in transform)` goes through every
child.

### Idea — sounds, the Level 1 way

Sounds work exactly as in Level 1: an **Audio Source** component plays **Audio
Clips** with `PlayOneShot`. Every tank gets an Audio Source of its own, which its
`Turret` and its `Health` share, and so does `Arena Game`:

| Sound | When | Played by |
| --- | --- | --- |
| `Shot` | a turret fires | `Turret` |
| `Hit` | a shell hits a tank | `Health` |
| `Repair` | your tank picks up a repair kit | `Health` |
| `Explosion` | a tank is destroyed | `ArenaGame` |
| `Victory` | you win | `ArenaGame` |
| `Defeat` | you lose | `ArenaGame` |

The enemies' `Health` has no repair sound: they never heal. So `Health` checks
each sound before playing it, `if (healSound != null)`, and a `Health` with an
empty sound slot just stays quiet.

### Idea — one method for every explosion

An explosion is three things: the smoke, the sound and a shake. `ArenaGame` gets
one method that does all three, `Explode(position)`, and calls it for enemies and
for your tank. The small shake in `EnemyDestroyed` moves into it; the big one,
for losing, stays in `EndGame`.

### Do it — the materials

1. In `Assets/Materials`: **Assets → Create → Material**, named `Explosion`. Set
   its **Shader** to **Universal Render Pipeline → 2D → Sprite-Unlit-Default**,
   and drag `smokeOrange0` into its **Sprite Texture** slot. Unlit, it shines by
   itself.
2. A second material, `Hit Puff`, the same way, with `smokeGrey1`.

### Do it — the explosion

1. **GameObject → Effects → Particle System**, named `Explosion`. Set its
   **Position** to `(0, 0, 0)` and its **Rotation** to `(0, 0, 0)`: the particle
   system arrives tipped over, for 3D, and in 2D it must face the camera.
2. In the **Main** module (to pick "Random Between Two Constants", click the
   small arrow at the right of a value):
   - **Duration** `0.6`, and untick **Looping**
   - **Start Lifetime**: random between `0.4` and `0.8`
   - **Start Speed**: random between `0.5` and `2.5`
   - **Start Size**: random between `0.5` and `1`
   - **Start Rotation**: random between `0` and `360`
   - **Stop Action** **Destroy**
3. **Emission**: **Rate over Time** `0`. Under **Bursts**, click **+**: one burst
   at **Time** `0` with **Count** `12`.
4. **Shape**: **Shape** **Circle**, **Radius** `0.3`.
5. Tick **Color over Lifetime**, click its colour bar, and make the **Alpha** go
   from 255 at the start to 0 at the end: the smoke fades out.
6. **Renderer**: set **Material** to `Explosion` and **Order in Layer** to `5`,
   in front of everything.
7. Drag `Explosion` into `Assets/Prefabs`, then delete it from the Hierarchy.

### Do it — the hit puff

1. In `Assets/Prefabs`, select `Explosion`, press **Ctrl + D** (**Cmd + D**), and
   rename the copy `Hit Puff`.
2. Open it, and make it smaller and quicker:
   - **Main**: **Duration** `0.3`; **Start Lifetime** `0.2` to `0.4`; **Start
     Speed** `0.3` to `1.2`; **Start Size** `0.25` to `0.45`
   - **Emission**: the burst's **Count** `6`
   - **Shape**: **Radius** `0.05`
   - **Renderer**: **Material** `Hit Puff`

### Do it — sounds and shells

1. Add an **Audio Source** to `Player Tank`, to the `Light Tank` and
   `Heavy Tank` prefabs, and to `Arena Game`. Untick **Play On Awake** on all
   four.
2. Replace `Health` with its final version:

```csharp:Health.cs
using UnityEngine;

// Hit points, for anything that can be shot: the player's tank and the enemy
// tanks. Other scripts read it through its properties, but only its own methods
// can change it.
public class Health : MonoBehaviour
{
    [SerializeField] int maxHealth = 3;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip hurtSound;         // optional: leave it empty for no sound
    [SerializeField] AudioClip healSound;         // optional too

    public int Current { get; private set; }

    public int Max
    {
        get { return maxHealth; }
    }

    public bool IsDead
    {
        get { return Current <= 0; }
    }

    // How full the health is, from 0 (dead) to 1 (as good as new).
    public float Fraction
    {
        get { return (float)Current / maxHealth; }
    }

    void Awake()
    {
        Current = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        Current = Mathf.Max(Current - amount, 0);
        if (hurtSound != null)
        {
            audioSource.PlayOneShot(hurtSound);
        }
    }

    // Mends 1 point, or as many as you ask for, but never above the maximum.
    public void Heal(int amount = 1)
    {
        Current = Mathf.Min(Current + amount, maxHealth);
        if (healSound != null)
        {
            audioSource.PlayOneShot(healSound);
        }
    }

    public void ResetHealth()
    {
        Current = maxHealth;
    }
}
```

3. Replace `Turret` with its final version:

```csharp:Turret.cs
using UnityEngine;

// A tank's turret. The barrel turns towards a point, a little at a time, and
// fires shells from its tip, no faster than it can reload. The player's tank
// and the enemy tanks all use it.
public class Turret : MonoBehaviour
{
    [SerializeField] Transform barrel;
    [SerializeField] Transform muzzle;
    [SerializeField] GameObject shellPrefab;
    [SerializeField] float turnSpeed = 180f;      // degrees per second
    [SerializeField] float reloadTime = 0.5f;     // seconds between two shots
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip shotSound;

    float nextShotTime = 0f;

    public bool IsLoaded
    {
        get { return Time.time >= nextShotTime; }
    }

    // Turns the barrel a step towards the point. Call it every frame.
    public void AimAt(Vector2 point)
    {
        Vector2 direction = point - (Vector2)barrel.position;
        float wanted = Vector2.SignedAngle(Vector2.up, direction);
        float step = turnSpeed * Time.deltaTime;
        float angle = Mathf.MoveTowardsAngle(barrel.eulerAngles.z, wanted, step);
        barrel.rotation = Quaternion.Euler(0f, 0f, angle);
    }

    // Is the barrel pointing at the point, give or take a few degrees?
    public bool IsAimedAt(Vector2 point, float degrees)
    {
        Vector2 direction = point - (Vector2)barrel.position;
        return Vector2.Angle(barrel.up, direction) <= degrees;
    }

    // Fires a shell, if the turret has reloaded. Returns whether it fired.
    public bool Fire()
    {
        if (!IsLoaded)
        {
            return false;
        }

        Instantiate(shellPrefab, muzzle.position, barrel.rotation);
        audioSource.PlayOneShot(shotSound);
        nextShotTime = Time.time + reloadTime;
        return true;
    }
}
```

4. Replace `Shell` with its final version:

```csharp:Shell.cs
using UnityEngine;

// A tank shell. It flies straight ahead and bursts on the first solid thing it
// touches: a wall only stops it, a tank loses health.
[RequireComponent(typeof(Rigidbody2D))]
public class Shell : MonoBehaviour
{
    [SerializeField] float speed = 9f;
    [SerializeField] float lifetime = 2f;
    [SerializeField] int damage = 1;
    [SerializeField] GameObject hitPrefab;        // the puff of smoke where it bursts

    void Start()
    {
        // transform.up is the way the shell's sprite points
        GetComponent<Rigidbody2D>().linearVelocity = transform.up * speed;
        Destroy(gameObject, lifetime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.isTrigger)
        {
            return;    // other shells and repair kits don't stop a shell
        }

        if (other.TryGetComponent(out Health health))
        {
            health.TakeDamage(damage);
        }
        Instantiate(hitPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
```

   What's new: `hitPrefab`, and the puff where the shell bursts. Open both shell
   prefabs, `Player Shell` and `Enemy Shell`, and drag `Hit Puff` into their
   **Hit Prefab**.

5. Set the tanks' sounds. Each tank's **Audio Source** field takes its own Audio
   Source: drag in the tank itself.

| Select | And set |
| --- | --- |
| `Player Tank` | **Turret**: **Audio Source**, **Shot Sound** `Shot`. **Health**: **Audio Source**, **Hurt Sound** `Hit`, **Heal Sound** `Repair` |
| the `Light Tank` and `Heavy Tank` prefabs | **Turret**: **Audio Source**, **Shot Sound** `Shot`. **Health**: **Audio Source**, **Hurt Sound** `Hit`; leave **Heal Sound** empty |

### Do it — repair kits

1. Create `RepairKit`:

```csharp:RepairKit.cs
using UnityEngine;

// A repair kit, sometimes left behind by a destroyed enemy. Drive over it to
// mend your tank. It turns slowly, to catch the eye, and doesn't wait for ever.
public class RepairKit : MonoBehaviour
{
    [SerializeField] int repairAmount = 2;
    [SerializeField] float lifetime = 12f;
    [SerializeField] float spinSpeed = 90f;       // degrees per second

    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    void Update()
    {
        transform.Rotate(0f, 0f, spinSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out PlayerTank player))
        {
            player.Health.Heal(repairAmount);
            Destroy(gameObject);
        }
    }
}
```

2. Drag `barrelGreen_up` into the Hierarchy, rename it `Repair Kit`, and set its
   **Order in Layer** to `1`. Add a **Rigidbody 2D** with **Body Type**
   **Kinematic**, a **Circle Collider 2D** with **Is Trigger** ticked (it sizes
   itself), and the **RepairKit** script.
3. Drag `Repair Kit` into `Assets/Prefabs`, then delete it from the Hierarchy.

### Do it — explosions and endings

1. Replace `ArenaGame` with its final version:

```csharp:ArenaGame.cs
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Runs the match: the rounds of enemy tanks, the screen, the start and end
// panels, the explosions and the sounds.
public class ArenaGame : MonoBehaviour
{
    [SerializeField] PlayerTank player;
    [SerializeField] CameraFollow cameraFollow;
    [SerializeField] GameObject lightTankPrefab;
    [SerializeField] GameObject heavyTankPrefab;
    [SerializeField] GameObject repairKitPrefab;
    [SerializeField] GameObject explosionPrefab;
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] int[] lightTanksPerRound = { 2, 3, 2, 2 };
    [SerializeField] int[] heavyTanksPerRound = { 0, 0, 1, 2 };
    [SerializeField] float repairKitChance = 0.35f;
    [SerializeField] Image healthFill;
    [SerializeField] TMP_Text roundText;
    [SerializeField] TMP_Text enemiesText;
    [SerializeField] TMP_Text messageText;
    [SerializeField] GameObject startPanel;
    [SerializeField] Button playButton;
    [SerializeField] GameObject endPanel;
    [SerializeField] TMP_Text endText;
    [SerializeField] Button playAgainButton;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip explosionSound;
    [SerializeField] AudioClip victorySound;
    [SerializeField] AudioClip defeatSound;

    readonly List<EnemyTank> enemies = new List<EnemyTank>();
    MatchStats stats;
    int round = 1;                                // the round being played, counting from 1
    Coroutine hideMessage;

    public bool IsPlaying { get; private set; }
    public string CommanderName { get; set; } = "Commander";

    public PlayerTank Player
    {
        get { return player; }
    }

    int RoundCount
    {
        get { return lightTanksPerRound.Length; }
    }

    void Awake()
    {
        IsPlaying = false;
        startPanel.SetActive(true);
        endPanel.SetActive(false);
        messageText.text = "";
    }

    void OnEnable()
    {
        playButton.onClick.AddListener(StartGame);
        playAgainButton.onClick.AddListener(StartGame);
    }

    void OnDisable()
    {
        playButton.onClick.RemoveListener(StartGame);
        playAgainButton.onClick.RemoveListener(StartGame);
    }

    void Update()
    {
        if (IsPlaying && player.Health.IsDead)
        {
            Explode(player.transform.position);
            player.gameObject.SetActive(false);
            EndGame(false);
        }
        UpdateScreen();
    }

    public void StartGame()
    {
        StopAllCoroutines();
        ClearArena();
        stats = new MatchStats(new string[] { "Light Tank", "Heavy Tank" });
        startPanel.SetActive(false);
        endPanel.SetActive(false);
        player.gameObject.SetActive(true);
        player.ResetTank();
        IsPlaying = true;
        StartCoroutine(PlayRounds());
    }

    // The whole match: each round counts down, sends its tanks, and waits
    // until every one of them has been destroyed.
    IEnumerator PlayRounds()
    {
        for (int number = 1; number <= RoundCount; number++)
        {
            round = number;
            ShowMessage("Round " + round);
            yield return new WaitForSeconds(1.5f);
            for (int count = 3; count > 0; count--)
            {
                ShowMessage(count.ToString());
                yield return new WaitForSeconds(0.6f);
            }
            ShowMessage("Go!", 0.8f);
            SpawnRound(round);

            while (enemies.Count > 0)
            {
                yield return null;
            }
            stats.AddRound();

            if (round < RoundCount)
            {
                ShowMessage("Round cleared!");
                yield return new WaitForSeconds(2f);
            }
        }
        EndGame(true);
    }

    void SpawnRound(int roundNumber)
    {
        int spawnIndex = 0;
        for (int i = 0; i < lightTanksPerRound[roundNumber - 1]; i++)
        {
            Spawn(lightTankPrefab, spawnIndex);
            spawnIndex++;
        }
        for (int i = 0; i < heavyTanksPerRound[roundNumber - 1]; i++)
        {
            Spawn(heavyTankPrefab, spawnIndex);
            spawnIndex++;
        }
    }

    void Spawn(GameObject prefab, int spawnIndex)
    {
        // % goes round the spawn points: with 4 points, tank 5 uses point 0 again.
        Transform point = spawnPoints[spawnIndex % spawnPoints.Length];
        GameObject tank = Instantiate(prefab, point.position, point.rotation);
        EnemyTank enemy = tank.GetComponent<EnemyTank>();
        enemy.SetGame(this);
        enemies.Add(enemy);
    }

    public void EnemyDestroyed(EnemyTank enemy)
    {
        enemies.Remove(enemy);
        stats.AddKill(enemy.TankName);
        Explode(enemy.transform.position);
        if (Random.value < repairKitChance)
        {
            // A child of the game, so ClearArena can find it.
            Instantiate(repairKitPrefab, enemy.transform.position, Quaternion.identity, transform);
        }
    }

    public void ShotFired()
    {
        stats.AddShot();
    }

    void Explode(Vector3 position)
    {
        Instantiate(explosionPrefab, position, Quaternion.identity);
        audioSource.PlayOneShot(explosionSound);
        cameraFollow.Shake(0.3f);
    }

    void EndGame(bool won)
    {
        IsPlaying = false;
        StopAllCoroutines();
        messageText.text = "";

        string title = won ? "Victory!" : "Destroyed!";
        endText.text = $"{title}\n\n{CommanderName}\n{stats.Summary()}";
        endPanel.SetActive(true);
        if (won)
        {
            audioSource.PlayOneShot(victorySound);
        }
        else
        {
            audioSource.PlayOneShot(defeatSound);
            cameraFollow.Shake(0.6f, 0.4f);
        }
    }

    // Removes every enemy and every repair kit, for a new match.
    void ClearArena()
    {
        foreach (EnemyTank enemy in enemies)
        {
            Destroy(enemy.gameObject);
        }
        enemies.Clear();
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }

    // Two versions of ShowMessage (overloads): one message stays on screen,
    // the other disappears after a few seconds.
    public void ShowMessage(string text)
    {
        if (hideMessage != null)
        {
            StopCoroutine(hideMessage);
        }
        messageText.text = text;
    }

    public void ShowMessage(string text, float seconds)
    {
        ShowMessage(text);
        hideMessage = StartCoroutine(HideMessageAfter(seconds));
    }

    IEnumerator HideMessageAfter(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        messageText.text = "";
    }

    void UpdateScreen()
    {
        healthFill.fillAmount = player.Health.Fraction;
        roundText.text = $"Round {round} of {RoundCount}";
        enemiesText.text = "Enemies: " + enemies.Count;
    }
}
```

2. Select `Arena Game`, and fill in the new fields: the `Repair Kit` and
   `Explosion` prefabs; its own **Audio Source**; and the sounds `Explosion`,
   `Victory` and `Defeat`.

What's new in `ArenaGame`: the comment, seven fields, and `Explode`, which
`Update` now calls for your tank and `EnemyDestroyed` for each enemy (the small
shake has moved into it); the repair kits in `EnemyDestroyed`, the sounds in
`EndGame`, and `ClearArena` removing the leftover kits too.

### Test it

Press **Play**, with the sound on, and start a match. Every shot booms. A shell
bursts in a grey puff wherever it lands, and a tank it hits clanks. Destroy an
enemy: orange smoke, an explosion and a jolt, and now and then a green barrel,
turning slowly. Take a few hits, then drive over the barrel: a repair sound, and
your health bar grows by two tenths. Win, and a fanfare plays; lose, and your
tank explodes too, with a sadder tune. Press **Play Again**: any repair kits left
lying around disappear.

### Challenge

Make a repair kit blink during its last 3 seconds, so players know it's about to
go. A coroutine can wait `lifetime - 3f` seconds, then switch the Sprite
Renderer's `enabled` on and off, as the lives blinked in Level 1.

## Chapter 13 — Settings

**Goal:** a **Settings** button opens a panel that pauses the game. In it: the
volume, the screen shake on or off, the commander's name for the end screen, and
the colour of your tank.

### Idea — pausing

`Time.timeScale` is how fast game time runs. At `0`, time stops:
`Time.deltaTime` is 0, `FixedUpdate` isn't called, physics freezes, and
`WaitForSeconds` waits. At `1`, everything carries on.

`Update` and `LateUpdate` are still called while the game is paused, though.
Your tank reads the keyboard in `Update`: without a check, typing a space in the
name box would fire a shell. So the tank ignores the controls while the game is
paused: `if (!game.IsPlaying || Time.timeScale == 0f)`. And `CameraFollow` checks
`Time.timeScale` too, so that a shake that was running when you paused waits for
the game to carry on.

### Idea — a switch for the shake

The toggle switches the screen shake on and off. The same script, `CameraFollow`,
also follows your tank, so switching the whole script off would stop the
following too. Instead, it gets a property, `ShakeEnabled`, which the toggle sets
and the shake checks. While it's off, a shake still counts down its time, unseen,
so switching it back on never brings back an old shake.

### Idea — the panel connects its own controls

The `SettingsMenu` script sits **on the panel itself**. When the panel is shown,
Unity calls its `OnEnable`, which connects the controls with `AddListener` and
pauses the game; when it's hidden, `OnDisable` disconnects them and unpauses
(C# 14). Before connecting, `OnEnable` shows the current values with
`SetValueWithoutNotify` and its cousins, which change a control without calling
its listener.

The **Settings** button, which isn't on the panel, opens it the Level 1 way: in
its **On Click ()** list in the Inspector. Both ways of connecting UI, side by
side.

| Control | Sends | Does |
| --- | --- | --- |
| Volume slider | a `float`, 0 to 1 | `AudioListener.volume`, the volume of every sound in the game |
| Shake toggle | a `bool` | `cameraFollow.ShakeEnabled` |
| Name input field | a `string`, when you finish typing | `game.CommanderName`, for the end screen |
| Colour dropdown | an `int`: which option | swaps the sprites of your tank and its barrel |

The dropdown's options and the two sprite arrays are in the same order, so the
option number is also the index into both arrays.

### Do it — the panel

1. **GameObject → UI (Canvas) → Panel**, named `Settings Panel`: black, with
   **Alpha** around 140.
2. Right-click `Settings Panel` → **UI (Canvas) → Image**, named `Window`: anchor
   middle-center, **Width** `420`, **Height** `300`, colour `#2F3B28`, and
   **Scale** `(2.2, 2.2, 1)`.
3. Make these inside `Window`, right-clicking `Window` each time, and place them
   (sizes are **Width**; heights stay as they come, except where the table says):

| Object | Type | Pos | Width | Settings |
| --- | --- | --- | --- | --- |
| `Title` | Text - TextMeshPro | (0, 115) | 380 | "Settings", size 30, centre, middle |
| `Volume Label` | Text - TextMeshPro | (−110, 60) | 140 | "Volume", size 18, height 30, left, middle |
| `Volume Slider` | Slider | (60, 60) | 200 | **Value** `1` |
| `Shake Toggle` | Toggle | (10, 18) | — | **Is On** ticked; its label says "Screen shake", in white |
| `Name Label` | Text - TextMeshPro | (−110, −28) | 140 | "Commander", size 18, height 30, left, middle |
| `Name Input` | Input Field - TextMeshPro | (60, −28) | 200 | placeholder "Your name", **Character Limit** 12 |
| `Colour Label` | Text - TextMeshPro | (−110, −72) | 140 | "Tank", size 18, height 30, left, middle |
| `Colour Dropdown` | Dropdown - TextMeshPro | (60, −72) | 200 | **Options**: `Blue`, `Green`, `Beige` |
| `Close Button` | Button - TextMeshPro | (0, −120) | 160 | height 36, colour `#D98E04`, text "Close", size 18 |

> **Tip:** the Toggle's label is an older **Text** component, not TextMeshPro.
> Select the Toggle's **Label** child to change its words and colour.

4. On the Canvas itself (not in the panel), a **Button - TextMeshPro** named
   `Settings Button`: anchor **bottom-right** (with Shift + Alt), **Pos**
   `(-30, 30)`, size `220 × 70`, colour `#D98E04`, text "Settings", size 35.
5. UI lower down in the Hierarchy draws on top. In the Hierarchy, drag
   `Settings Button` up to just below `Round Text`, above `Start Panel`: then the
   panels cover it when they're open, and nobody can press it through them.

### Do it — the scripts

1. Replace `CameraFollow` with its final version:

```csharp:CameraFollow.cs
using UnityEngine;

// Follows the player's tank, smoothly, without ever showing anything outside
// the arena. It can shake too, when something explodes.
[RequireComponent(typeof(Camera))]
public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float smoothing = 5f;        // bigger catches up faster
    [SerializeField] float defaultShake = 0.15f;

    Camera cam;
    Vector3 followPosition;
    float shakeTimeLeft = 0f;
    float shakeStrength = 0f;

    public bool ShakeEnabled { get; set; } = true;

    void Awake()
    {
        cam = GetComponent<Camera>();
        followPosition = transform.position;
    }

    // Two versions (overloads): a normal shake, or one as strong as you ask.
    public void Shake(float seconds)
    {
        Shake(seconds, defaultShake);
    }

    public void Shake(float seconds, float strength)
    {
        shakeTimeLeft = seconds;
        shakeStrength = strength;
    }

    // LateUpdate: after the tank has moved this frame.
    void LateUpdate()
    {
        // Where the camera wants to be: over the tank, but no nearer the edge of
        // the arena than half of what it shows.
        float halfHeight = cam.orthographicSize;
        float halfWidth = halfHeight * cam.aspect;
        float maxX = ArenaBounds.HalfWidth - halfWidth;
        float maxY = ArenaBounds.HalfHeight - halfHeight;
        Vector3 wanted = target.position;
        wanted.x = Mathf.Clamp(wanted.x, -maxX, maxX);
        wanted.y = Mathf.Clamp(wanted.y, -maxY, maxY);
        wanted.z = transform.position.z;

        followPosition = Vector3.Lerp(followPosition, wanted, smoothing * Time.deltaTime);

        // While the game is paused, time doesn't pass, and the shake waits.
        Vector3 jolt = Vector3.zero;
        if (shakeTimeLeft > 0f && Time.timeScale > 0f)
        {
            shakeTimeLeft -= Time.deltaTime;
            if (ShakeEnabled)
            {
                jolt = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f) * shakeStrength;
            }
        }
        transform.position = followPosition + jolt;
    }
}
```

   What's new: the `ShakeEnabled` property, and two more checks. The shake only
   counts down while the game isn't paused, and it only moves the camera while
   `ShakeEnabled` is `true`.

2. Replace `PlayerTank` with its final version. The only change is in `Update`:
   the pause check.

```csharp:PlayerTank.cs
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

// The player's tank. With a keyboard: W and S drive, A and D turn, the barrel
// follows the mouse, and Space or a click fires. With a finger: a quick tap
// fires towards that spot, and a press that's held drives the tank there.
[RequireComponent(typeof(Tracks))]
[RequireComponent(typeof(Turret))]
[RequireComponent(typeof(Health))]
public class PlayerTank : MonoBehaviour
{
    [SerializeField] ArenaGame game;
    [SerializeField] float tapTime = 0.25f;       // a press shorter than this is a tap: it fires

    Tracks tracks;
    Turret turret;
    Rigidbody2D body;
    Camera cam;
    Vector2 startPosition;
    bool pressing = false;
    float pressStartTime = 0f;

    public Health Health { get; private set; }

    void Awake()
    {
        tracks = GetComponent<Tracks>();
        turret = GetComponent<Turret>();
        body = GetComponent<Rigidbody2D>();
        Health = GetComponent<Health>();
        cam = Camera.main;
        startPosition = transform.position;
    }

    void Update()
    {
        tracks.Stop();
        if (!game.IsPlaying || Time.timeScale == 0f)
        {
            pressing = false;
            return;
        }

        ReadKeyboard();
        ReadPointer();
    }

    // Tank controls: forwards and backwards along the way it faces, and turning
    // on the spot. A phone may have no keyboard at all, so check for null first.
    void ReadKeyboard()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard == null)
        {
            return;
        }

        float drive = 0f;
        float turn = 0f;
        if (keyboard.wKey.isPressed || keyboard.upArrowKey.isPressed)
        {
            drive += 1f;
        }
        if (keyboard.sKey.isPressed || keyboard.downArrowKey.isPressed)
        {
            drive -= 1f;
        }
        if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed)
        {
            turn += 1f;
        }
        if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed)
        {
            turn -= 1f;
        }
        tracks.Drive(drive, turn);

        if (keyboard.spaceKey.wasPressedThisFrame)
        {
            Fire();
        }
    }

    // The mouse or a finger. The barrel always aims at it. A tap fires; holding
    // it down drives the tank towards it.
    void ReadPointer()
    {
        Pointer pointer = Pointer.current;
        if (pointer == null)
        {
            return;
        }

        Vector2 world = cam.ScreenToWorldPoint(pointer.position.ReadValue());
        turret.AimAt(world);

        if (pointer.press.wasPressedThisFrame)
        {
            pressing = true;
            pressStartTime = Time.time;
        }
        // A press on a button isn't for the tank. The UI only knows a finger is
        // on a button a frame after it lands, so check on every frame.
        if (EventSystem.current.IsPointerOverGameObject())
        {
            pressing = false;
        }
        if (!pressing)
        {
            return;
        }

        float heldFor = Time.time - pressStartTime;
        if (pointer.press.wasReleasedThisFrame)
        {
            pressing = false;
            if (heldFor < tapTime)
            {
                Fire();    // a quick tap
            }
        }
        else if (heldFor >= tapTime)
        {
            tracks.DriveTowards(world);    // a press that's held
        }
    }

    void Fire()
    {
        if (turret.Fire())
        {
            game.ShotFired();
        }
    }

    // Back to the start, facing up, with full health, for a new match.
    public void ResetTank()
    {
        tracks.Stop();
        body.position = startPosition;
        body.rotation = 0f;
        transform.position = startPosition;
        transform.rotation = Quaternion.identity;
        body.linearVelocity = Vector2.zero;
        body.angularVelocity = 0f;
        Health.ResetHealth();
        pressing = false;
    }
}
```

3. Create `SettingsMenu`, and attach it to `Settings Panel`:

```csharp:SettingsMenu.cs
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The settings panel. Its controls are connected with AddListener when the
// panel opens (OnEnable), and disconnected when it closes (OnDisable). The
// game is paused while it's open.
public class SettingsMenu : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] Toggle shakeToggle;
    [SerializeField] TMP_InputField nameInput;
    [SerializeField] TMP_Dropdown colourDropdown;
    [SerializeField] Button closeButton;
    [SerializeField] ArenaGame game;
    [SerializeField] CameraFollow cameraFollow;
    [SerializeField] SpriteRenderer bodyRenderer;
    [SerializeField] SpriteRenderer barrelRenderer;
    [SerializeField] Sprite[] bodySprites;        // in the same order as the dropdown's options
    [SerializeField] Sprite[] barrelSprites;      // the same colours, in the same order

    void OnEnable()
    {
        // Show the current values, without calling the listeners.
        volumeSlider.SetValueWithoutNotify(AudioListener.volume);
        shakeToggle.SetIsOnWithoutNotify(cameraFollow.ShakeEnabled);
        nameInput.SetTextWithoutNotify(game.CommanderName);

        volumeSlider.onValueChanged.AddListener(OnVolumeChanged);
        shakeToggle.onValueChanged.AddListener(OnShakeToggled);
        nameInput.onEndEdit.AddListener(OnNameEntered);
        colourDropdown.onValueChanged.AddListener(OnColourChosen);
        closeButton.onClick.AddListener(Close);

        Time.timeScale = 0f;
    }

    void OnDisable()
    {
        volumeSlider.onValueChanged.RemoveListener(OnVolumeChanged);
        shakeToggle.onValueChanged.RemoveListener(OnShakeToggled);
        nameInput.onEndEdit.RemoveListener(OnNameEntered);
        colourDropdown.onValueChanged.RemoveListener(OnColourChosen);
        closeButton.onClick.RemoveListener(Close);

        Time.timeScale = 1f;
    }

    void Close()
    {
        gameObject.SetActive(false);
    }

    void OnVolumeChanged(float value)
    {
        AudioListener.volume = value;
    }

    void OnShakeToggled(bool isOn)
    {
        cameraFollow.ShakeEnabled = isOn;
    }

    void OnNameEntered(string text)
    {
        if (text.Trim() != "")
        {
            game.CommanderName = text.Trim();
        }
    }

    void OnColourChosen(int index)
    {
        bodyRenderer.sprite = bodySprites[index];
        barrelRenderer.sprite = barrelSprites[index];
    }
}
```

Read `SettingsMenu` before you move on:

- `OnEnable` and `OnDisable` connect and disconnect the five listeners, and pause
  and unpause the game.
- Each listener's parameter is what its control sends: a `float` for the slider,
  a `bool` for the toggle, a `string` for the input field and an `int` for the
  dropdown.
- `text.Trim()` is the text without the spaces at its ends, so a name made only
  of spaces counts as blank, and the old name stays.

### Do it — connect it all

1. Select `Settings Panel`, and fill in its fields: the five controls;
   `Arena Game` into **Game**; **Main Camera** into **Camera Follow**;
   `Player Tank` into **Body Renderer**; its child `Barrel` into **Barrel
   Renderer**.
2. Give **Body Sprites** three elements, in the dropdown's order: `tankBlue`,
   `tankGreen` and `tankBeige`. Give **Barrel Sprites** three elements:
   `barrelBlue`, `barrelGreen` and `barrelBeige`.
3. Hide `Settings Panel`: untick it.
4. Select `Settings Button`. In its **On Click ()** list, click **+**, drag
   `Settings Panel` into the object slot, choose **GameObject → SetActive
   (bool)**, and tick the box.

### Test it

Press **Play**, start a match, and click **Settings**: everything freezes. Drag
the volume down, untick the shake, type your name (press **Enter** or click
elsewhere to finish), and pick a green tank. **Close**: the match carries on,
with a green tank, no shake, and quieter sounds. Let the enemies win: the end
screen names you.

### Challenge

Save the settings, so they're still there the next time the game starts. Look up
`PlayerPrefs` in the Scripting API (C# 12): `PlayerPrefs.SetFloat` and
`PlayerPrefs.GetFloat` are a good start.

# Part 5 — Finish

## C# 15 — null and Debugging

**Goal:** you can explain what `null` is, find the reference that's `null` from
an error message, and pause your code with a breakpoint to look inside it.

### Idea — null: an arrow to nothing

A variable of a class type holds a **reference**: an arrow to an object
(Level 1). `null` means the arrow points at **nothing**.

| Can be `null` | Can't be `null` |
| --- | --- |
| class types: `GameObject`, components, `string`, `List<T>`, your own classes | `int`, `float`, `bool`, `Vector3` and other value types |

```csharp
string playerName = null;
GameObject target = null;
Debug.Log(playerName == null);
Debug.Log(target);
```

```
True
Null
```

Checking a `null` reference is fine. **Using** one is not:

```csharp
List<int> scores = null;       // forgot: = new List<int>();
scores.Add(10);                // NullReferenceException
```

`scores.Add` means "go to the list and add 10", but there's no list to go to. C#
stops the code with a **NullReferenceException**: the most common error in all of
Unity.

### Idea — reading the error

Double-click an error in the Console and your code editor opens the file at the
exact line. Click it once, and the bottom of the Console shows the whole
message:

```
NullReferenceException: Object reference not set to an instance of an object
Practice.AddBonus (System.Int32 amount) (at Assets/Scripts/Practice.cs:21)
Practice.Start () (at Assets/Scripts/Practice.cs:12)
```

| Part | Tells you |
| --- | --- |
| `NullReferenceException` | **what** went wrong |
| `Object reference not set…` | the explanation, in words |
| the lines below | the **stack trace**: **where** it happened |

Read the stack trace from the **top**. The error happened in `AddBonus`, at line
21 of `Practice.cs`. The line under it says who called `AddBonus`: `Start`, at
line 12. Each line is one step further back along the chain of calls.

### Idea — which one is null?

The error names the line, not the variable. On a line like this, three
references could be `null`:

```csharp
gameManager.player.health.TakeDamage(5);
```

To find out which, split the line, or print each part just before it:

```csharp
Debug.Log(gameManager == null);
Debug.Log(gameManager.player == null);
Debug.Log(gameManager.player.health == null);
```

The first `True` is the culprit. Or use a breakpoint (below) and **look**.

### Idea — Unity's own null errors

In the Editor, Unity replaces some `NullReferenceException`s with errors that
explain more. Learn to recognise them:

| Error | What happened | Fix |
| --- | --- | --- |
| **UnassignedReferenceException:** *The variable target of Practice has not been assigned.* | a `[SerializeField]` or `public` field was left empty in the Inspector | drag the object into the field |
| **MissingComponentException:** *There is no 'Rigidbody' attached to the "Cube" game object, but a script is trying to access it.* | `GetComponent` found nothing, and the code used the result | add the component, or check for `null` |
| **MissingReferenceException:** *The object of type 'GameObject' has been destroyed but you are still trying to access it.* | the code used an object after `Destroy` | stop using it: remove it from lists, check for `null` |
| **NullReferenceException** | a plain `null`: a variable that was never given an object | find the variable and give it one |

In a finished build, the first two become plain `NullReferenceException`s, with
no helpful message. Another reason to test in the Editor!

### Idea — checking for null

When something **might** be missing, check before you use it:

```csharp
if (target != null)
{
    target.SetActive(false);
}
```

Unity objects have a special rule: after you `Destroy` one, it **compares equal
to `null`**, even though your variable still holds the arrow. So
`if (enemy != null)` is exactly the right check for "does this enemy still
exist?".

> **Watch out:** you may meet `?.` and `??` in C# code online, like
> `target?.SetActive(false);`. Don't use them with Unity objects: they skip
> Unity's special check, and don't notice that an object was destroyed. Write
> `if (target != null)` instead.

### Idea — breakpoints: pause the game and look

A **breakpoint** pauses your code on a chosen line, while the game is running, so
you can look at every variable. In **Visual Studio Code**:

1. Click just left of a line number: a **red dot** appears. That's the
   breakpoint.
2. Open **Run and Debug** (**Ctrl + Shift + D**, **Cmd + Shift + D** on Mac),
   choose **Attach to Unity** at the top, and press the green ▶ (or **F5**).
3. The first time, Unity asks to switch to **Debug Mode**. Choose **Enable
   debugging for this session**.
4. Press **Play** in Unity. When the game reaches your line, it freezes, and VS
   Code highlights the line.
5. Hover over any variable to see its value, or read the **Variables** panel on
   the left. A `null` reference shows as `null`.
6. **F10** runs the next line (Step Over), **F11** goes into the method on this
   line (Step Into), **F5** continues until the next breakpoint, and
   **Shift + F5** stops debugging.

In **Visual Studio**, press **Attach to Unity** in the toolbar instead; the rest
is the same.

> **Tip:** the Console's **Error Pause** button pauses the game on the first
> error, so you can inspect the scene exactly as it was when things went wrong.

### Idea — Debug.Log is still your friend

| Code | Shows in the Console |
| --- | --- |
| `Debug.Log("Hit!")` | a normal message |
| `Debug.LogWarning("Low health")` | a yellow warning |
| `Debug.LogError("No spawn points!")` | a red error (the game keeps running) |
| `Debug.Log("Hit!", gameObject)` | a message that highlights `gameObject` in the Hierarchy when you click it |

### Do it

1. Add `[SerializeField] GameObject target;` to `Practice`, leave it empty, and
   call `target.SetActive(false);` in `Start()`. Read the error, double-click it,
   then fix it by dragging an object into the field.
2. Get a component that isn't there with `GetComponent`, and use it. Read the
   error.
3. `Destroy(target);` in `Start()`, and print `target.name` in `Update()`. Read
   the error, then add a `null` check so it stops.
4. Put a breakpoint inside `Update` on a line that uses a counter, attach the
   debugger, and watch the counter's value each time you press **F5**.

### Challenge

A friend's game shows this error in the Console. Answer the three questions
without looking at the code:

```
NullReferenceException: Object reference not set to an instance of an object
Shop.Buy (System.String item) (at Assets/Scripts/Shop.cs:34)
ShopButton.OnClick () (at Assets/Scripts/ShopButton.cs:15)
```

1. In which file and on which line did the error happen?
2. Which method called the method that failed?
3. On line 34, the code is `wallet.coins -= prices[item];`. Which two
   references could be `null`?

## Chapter 14 — Break It, Then Fix It

**Goal:** you can recognise the errors a broken Unity project throws, go straight
to their cause, and use a breakpoint to watch a tank take damage.

### Idea

Every programmer breaks things, every day. The difference between a beginner and
a professional is how fast they find the cause. In this chapter you break the
finished game **on purpose**, one thing at a time, read what Unity tells you, and
fix it. Do each step, then undo it before the next one.

> **Watch out:** save your scene first (**Ctrl + S** / **Cmd + S**). If anything
> goes wrong, you can always go back to the saved version.

### Do it — an empty field

1. Select `Player Tank`. In its **Turret**, click the **Muzzle** field and press
   **Delete** or **Backspace**: it now says **None (Transform)**.
2. Press **Play**, start a match, and press **Space**. The Console shows:

```
UnassignedReferenceException: The variable muzzle of Turret has not been assigned.
You probably need to assign the muzzle variable of the Turret script in the inspector.
```

3. Click the error. Below the message comes the stack trace. Its first line or
   two are Unity's own code: start at the first line that names your script,
   `Turret.Fire`, with its line number. Under it are the methods that called it,
   one after another: `PlayerTank.Fire`, `PlayerTank.ReadKeyboard`, then
   `PlayerTank.Update`. Double-click the error: your editor opens `Turret.cs` at
   the line that uses `muzzle`.
4. Stop, and drag `Muzzle` back into the field.

The enemy tanks' turrets still work, even while yours is broken: every tank has a
`Turret` of its own, with its own fields.

### Do it — a real null

1. In `PlayerTank`, turn the last line but one of `Awake` into a comment:
   `// cam = Camera.main;`. Now `cam` is never given the camera.
2. Before you even press Play, the Console has a clue: a yellow **warning**.

```
Assets/Scripts/PlayerTank.cs(19,12): warning CS0649: Field 'PlayerTank.cam' is never assigned to, and will always have its default value null
```

   A warning doesn't stop the game, so it's easy to miss. This one tells the whole
   story: nothing ever gives `cam` a value.
3. Play, and start a match. Now it's the plain C# error, again and again:

```
NullReferenceException: Object reference not set to an instance of an object
PlayerTank.ReadPointer () (at Assets/Scripts/PlayerTank.cs:95)
```

4. Line 95 is `Vector2 world = cam.ScreenToWorldPoint(pointer.position.ReadValue());`.
   Which reference on that line could be `null`? `pointer` was checked just
   before, so it's `cam`. `cam` is private and not a `[SerializeField]`, so no
   Inspector field can help: it's `null` because no code gave it a value, just as
   the warning said.
5. Remove the `//`.

### Do it — a destroyed object

1. Press **Play** and start a match. Then, in the Hierarchy, open `Player Tank`,
   select its child `Barrel`, and delete it (**Delete**, or **Cmd + Backspace** on
   Mac).
2. A new kind of error fills the Console: **MissingReferenceException**: *The
   object of type 'Transform' has been destroyed but you are still trying to
   access it*. The turret's `barrel` field still points at the barrel, but the
   barrel is gone. The stack trace starts at `Turret.AimAt`.
3. Stop the game: the barrel comes back. Deleting it in Play mode was only
   temporary.

### Do it — a component that can't go

Select `Player Tank` and try to remove its **Tracks** (right-click the
component's title → **Remove Component**). Unity refuses: `PlayerTank` needs it,
because of its `[RequireComponent(typeof(Tracks))]`. That one line prevents a
whole family of errors.

### Do it — a bug with no error at all

1. In `Shell`, rename `OnTriggerEnter2D` to `OnTriggerEnter`, and change its
   parameter to `(Collider other)`. Save, and play.
2. No error, no warning, and your shells fly straight through walls, trees and
   tanks. `OnTriggerEnter` is the **3D** version: Unity only calls it for 3D
   colliders, and it only calls event functions whose names match exactly
   (C# 2).
3. Put back `OnTriggerEnter2D(Collider2D other)`.

### Do it — watch a hit with a breakpoint

1. Open `Health` in VS Code, and click left of the line number of
   `Current = Mathf.Max(Current - amount, 0);` in `TakeDamage`: a red dot.
2. **Run and Debug** (**Ctrl + Shift + D** / **Cmd + Shift + D**), choose
   **Attach to Unity**, and press ▶. If Unity asks, choose **Enable debugging
   for this session**.
3. Play, start a match, and shoot a light tank. The game freezes, and VS Code
   highlights the line.
4. Hover over `Current`: 2, for a light tank. Hover over `amount`: 1. Press
   **F10** once, and hover over `Current` again: 1.
5. Press **F5** to carry on. Soon the game stops again: maybe your second shell,
   maybe an enemy's shell hitting **your** tank. Hover over `maxHealth` to tell
   which: 2 is a light tank, 5 a heavy one, and 10 is yours. One script, many
   objects, each with its own values. Click the red dot to remove it, press
   **F5**, and stop debugging with **Shift + F5**.

### Test it

After undoing every break, the game works exactly as before: play a whole match
to be sure, and check that the Console has no errors.

### Challenge

Break the game in a way this chapter didn't, and swap with a classmate: each of
you must find and fix the other's bug using only the Console and a breakpoint.

## Chapter 15 — Ship It

**Goal:** a Web build of your game, published on itch.io, that works with the
keyboard or a mouse on a computer, and with a finger on a phone.

### Idea

The game is finished; now players need it. As in Level 1, a **Web** build runs
in any browser, and itch.io hosts it for free. And this time there's a bonus: the
game already understands touch, so the same link works on a phone.

### Do it — the build

1. **File → Build Profiles**. Select **Web** and click **Switch Platform**.
2. In **Scene List**, click **Add Open Scenes** if `Scenes/TankArena` is
   missing, and untick `Scenes/SampleScene`: a build starts with the first ticked
   scene, and that must be `Scenes/TankArena`.
3. Open **Player Settings**: set the **Product Name** to `Tank Arena`. Under
   **Publishing Settings**, set **Compression Format** to **Disabled**.
4. Click **Build**, create a folder called `Builds/Web`, and wait.

### Do it — publish on itch.io

1. Zip the **contents** of `Builds/Web`, so `index.html` is at the top of the
   zip.
2. On itch.io, **Upload new project**, **Kind of project: HTML**, upload the zip,
   and tick **This file will be played in the browser**.
3. Set the **Viewport dimensions** to `960 × 600`, the size of the game in a Web
   build, and tick **Mobile friendly**; if itch.io asks for an orientation, choose
   **Landscape**. Save, and open the page.

### Test it

Play the game in the browser with the keyboard and the mouse. Then open the same
page on a phone, turn it sideways, and play with your finger: tap to fire, press
and hold to drive. If something is too small to read or to press on the phone,
that's a job for the challenge.

### Challenge

Watch a friend play without explaining anything. Where do they get stuck? Fix
the biggest problem: a clearer message, a bigger button, a gentler first round.
That's what game designers call **playtesting**.

# Part 6 — Check Yourself

## Exam-style questions

These questions use the styles of the Unity certification exams, and the
**Level 3 entry test** uses them too. Answer on paper first, then check the
answers.

**Q1.** What does this print?

```csharp
public class Counter
{
    public int Count { get; private set; }

    public void Add(int amount)
    {
        Count += amount;
    }
}
```

```csharp
Counter counter = new Counter();
counter.Add(4);
counter.Add(6);
Debug.Log(counter.Count);
```

**Q2.** Using the `Counter` class from Q1, which line doesn't compile?

- A. `Debug.Log(counter.Count);`
- B. `counter.Count = 0;`
- C. `counter.Add(-2);`
- D. `int total = counter.Count + 1;`

**Q3.** What does this print?

```csharp
public class Robot
{
    public static int Built { get; private set; }
    public string Name { get; private set; }

    public Robot(string name)
    {
        Name = name;
        Built++;
    }
}
```

```csharp
Robot a = new Robot("Ax");
Robot b = new Robot("Bo");
Debug.Log(b.Name + " " + Robot.Built);
```

**Q4.** What does this print?

```csharp
int coins = 7;
int players = 2;
Debug.Log(coins / players);
Debug.Log((float)coins / players);
Debug.Log(coins % players);
```

**Q5.** What does this print?

```csharp
Debug.Log((int)4.9f);
Debug.Log(Mathf.RoundToInt(4.5f));
Debug.Log(Mathf.RoundToInt(5.5f));
```

**Q6.** What does this print?

```csharp
List<string> queue = new List<string> { "Ali", "Maya", "Jo" };
queue.Add("Sami");
queue.RemoveAt(0);
queue.Insert(1, "Rana");
Debug.Log(queue.Count + " " + queue[1] + " " + queue.IndexOf("Jo"));
```

**Q7.** What does this print?

```csharp
Dictionary<string, int> ammo = new Dictionary<string, int>();
ammo["Laser"] = 20;
ammo["Rocket"] = 2;
ammo["Laser"] = ammo["Laser"] - 5;
if (ammo.TryGetValue("Mine", out int mines))
{
    Debug.Log("Mines: " + mines);
}
else
{
    Debug.Log("Laser: " + ammo["Laser"]);
}
```

**Q8.** A class already has `void Play(string clip)`. Which of these can be added
as an overload? (Choose all that apply.)

- A. `void Play(string sound)`
- B. `void Play(string clip, float volume)`
- C. `bool Play(string clip)`
- D. `void Play(int trackNumber)`

**Q9.** Match each job with the best event function: `Awake`, `OnEnable`,
`FixedUpdate`, `LateUpdate`.

1. Pushing a Rigidbody with `AddForce(…, ForceMode.Force)` every step
2. Getting this object's own Rigidbody with `GetComponent`
3. Moving a camera that follows the player
4. Calling `AddListener` on a button

**Q10.** In what order does Unity call these, for a script that's enabled when
the scene starts? `Start`, `Awake`, `Update`, `OnEnable`.

**Q11.** What does this print?

```csharp
void Start()
{
    Debug.Log("A");
    StartCoroutine(Wait());
    Debug.Log("B");
}

IEnumerator Wait()
{
    Debug.Log("C");
    yield return new WaitForSeconds(1f);
    Debug.Log("D");
}
```

**Q12.** A student writes `Wait();` instead of `StartCoroutine(Wait());`. What
happens?

- A. A compile error
- B. The coroutine runs normally
- C. Nothing: the coroutine never runs, and there's no error
- D. The game freezes for one second

**Q13.** An enemy is at `(1, 2, 0)` and the player at `(4, 6, 0)`. What are the
distance between them, and the normalized direction from the enemy to the player?

**Q14.** Which line finds the first collider on the layers in `wallsMask`, up to
10 units straight ahead of this object, in 3D?

- A. `Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, 10f, wallsMask)`
- B. `Physics.Raycast(transform.forward, transform.position, out RaycastHit hit, 10f, wallsMask)`
- C. `Physics2D.Raycast(transform.position, transform.forward, 10f, wallsMask)`
- D. `Physics.Raycast(transform.position, transform.forward, 10f, out RaycastHit hit, wallsMask)`

**Q15.** Which older `Input` code matches
`Touchscreen.current.primaryTouch.press.wasPressedThisFrame`?

- A. `Input.touchCount > 0`
- B. `Input.GetTouch(0).phase == TouchPhase.Began`
- C. `Input.GetTouch(0).phase == TouchPhase.Moved`
- D. `Input.GetMouseButton(0)`

**Q16.** Which method can be passed to `slider.onValueChanged.AddListener(…)`?

- A. `void OnVolume()`
- B. `void OnVolume(int value)`
- C. `void OnVolume(float value)`
- D. `float OnVolume(float value)`

**Q17.** A script has `[SerializeField] AudioSource source;`, left empty in the
Inspector. In the Editor, what does `source.Play();` throw?

**Q18.** The Console shows this error. In which method, file and line did it
happen, and which method called that one?

```
NullReferenceException: Object reference not set to an instance of an object
Inventory.AddItem (System.String item) (at Assets/Scripts/Inventory.cs:18)
Pickup.OnTriggerEnter2D (UnityEngine.Collider2D other) (at Assets/Scripts/Pickup.cs:11)
```

**Q19.** What does `GetComponent<Rigidbody>()` return when the GameObject has no
Rigidbody?

**Q20.** Which of these lines don't compile? (Choose all that apply.)

- A. `int lives = 3.0f;`
- B. `float speed = 3;`
- C. `string label = 3;`
- D. `double exact = 3f;`

## Answers

| Q | Answer | Why |
| --- | --- | --- |
| 1 | `10` | `Add` changes `Count` from inside the class: 4 + 6. |
| 2 | B | `Count` has a `private set`: only `Counter` can change it (CS0272). |
| 3 | `Bo 2` | Each robot has its own `Name`; `Built` is static, shared by both. |
| 4 | `3`, `3.5`, `1` | `int / int` drops the decimals; the cast makes it a `float` division; `%` is the remainder. |
| 5 | `4`, `4`, `6` | A cast cuts off the decimals. Halfway values round to the nearest **even** number. |
| 6 | `4 Rana 2` | After the changes: `Maya, Rana, Jo, Sami`. |
| 7 | `Laser: 15` | "Mine" isn't a key, so `TryGetValue` returns `false`. |
| 8 | B, D | Overloads need different parameter **types or numbers**. Names (A) and return types (C) don't count. |
| 9 | 1 `FixedUpdate`, 2 `Awake`, 3 `LateUpdate`, 4 `OnEnable` | Physics on the physics clock; your own set-up first; cameras after everything moved; listen while enabled. |
| 10 | `Awake`, `OnEnable`, `Start`, `Update` | `Start` waits until just before the first `Update`. |
| 11 | `A`, `C`, `B`, then `D` a second later | The coroutine runs until its first `yield` straight away. |
| 12 | C | Only `StartCoroutine` runs it. Calling it alone does nothing. |
| 13 | `5`, and `(0.60, 0.80, 0.00)` | The arrow is `(3, 4, 0)`: its length is 5, and divided by 5 it's `(0.6, 0.8, 0)`. |
| 14 | A | Start, direction, `out` result, distance, then the mask. C is 2D and has no `out`. |
| 15 | B | `Began` is the frame the finger touches down. |
| 16 | C | A slider sends a `float`, and a listener returns nothing (`void`). |
| 17 | `UnassignedReferenceException` | In the Editor, an empty Inspector field gets this more helpful error. In a build it's a `NullReferenceException`. |
| 18 | `Inventory.AddItem`, `Inventory.cs` line 18, called by `Pickup.OnTriggerEnter2D` | Read a stack trace from the top. |
| 19 | `null` | Use it without checking and you get an error. `TryGetComponent` checks for you. |
| 20 | A, C | `float` → `int` needs a cast; a number is not a `string`. B and D are safe, implicit conversions. |

## Level 2 cheat sheet

| Topic | Syntax |
| --- | --- |
| Read-only property | `public int Score { get; private set; }` |
| Worked-out property | `public bool IsAlive { get { return lives > 0; } }` |
| Constructor | `public Ticket(string owner) { Owner = owner; }` then `new Ticket("Lina")` |
| Static member | `public static int Count { get; private set; }` then `Enemy.Count` |
| Constant | `public const int MaxLives = 3;` |
| Set once | `readonly List<int> scores = new List<int>();` |
| Overloads | `void Show(string text)` and `void Show(string text, float seconds)` |
| Optional parameter | `void Heal(int amount = 10)` |
| `out` and the Try pattern | `if (int.TryParse(text, out int number)) { … }` |
| Cast | `(int)3.9f` is 3; `(float)found / total` |
| Rounding | `Mathf.RoundToInt(x)`, `Mathf.FloorToInt(x)`, `Mathf.CeilToInt(x)` |
| Keep in range | `Mathf.Clamp(x, min, max)`, `Mathf.Clamp01(x)` |
| List | `List<int> list = new List<int>();` `Add` `Remove` `RemoveAt` `Contains` `Count` |
| Dictionary | `Dictionary<string, int> d = new Dictionary<string, int>();` `d["a"] = 1;` `d.TryGetValue("a", out int v)` |
| Event functions | `Awake` → `OnEnable` → `Start` → `FixedUpdate` / `Update` → `LateUpdate` → `OnDisable` → `OnDestroy` |
| Own component | `body = GetComponent<Rigidbody>();` in `Awake` |
| Other object's component | `if (other.TryGetComponent(out Health health)) { … }` |
| Must have | `[RequireComponent(typeof(Rigidbody))]` above the class |
| Vectors | `target - me` (the arrow), `.magnitude`, `.normalized`, `Vector3.Distance(a, b)` |
| Part of the way | `Vector3.Lerp(a, b, t)`, `Vector3.MoveTowards(a, b, maxStep)` |
| Coroutine | `IEnumerator Wait() { yield return new WaitForSeconds(1f); }` and `StartCoroutine(Wait());` |
| Cooldown | `if (Time.time >= nextTime) { nextTime = Time.time + cooldown; }` |
| Mouse or finger | `Pointer.current.press.wasPressedThisFrame`, `Pointer.current.position.ReadValue()` |
| Screen to world | 2D: `Camera.main.ScreenToWorldPoint(p)`; 3D: `Camera.main.ScreenPointToRay(p)` |
| 3D raycast | `Physics.Raycast(start, direction, out RaycastHit hit, distance, mask)` |
| 2D raycast | `RaycastHit2D hit = Physics2D.Raycast(start, direction, distance, mask);` then `hit.collider != null` |
| UI events | `slider.onValueChanged.AddListener(OnVolume);` and `RemoveListener` |
| Change a UI value quietly | `slider.SetValueWithoutNotify(0.5f);` |
| Null check | `if (target != null) { … }` |
| Pause the game | `Time.timeScale = 0f;` (and `1f` to carry on) |
| Particles | `particles.Play();` |

## Before Level 3: can you…

Tick each one honestly. Level 3's entry test checks every line.

- Write a class with properties and a constructor, and explain `private set`?
- Choose between `static`, `const` and `readonly`, and between `public`,
  `[SerializeField]` and a property, for a value?
- Read a method declaration, overload a method, and use an `out` parameter?
- Predict `int` and `float` arithmetic, cast between them, and round on purpose?
- Choose between an array, a `List` and a `Dictionary`, and use each one?
- Say when each event function runs, and put code in the right one?
- Get components with `GetComponent` and `TryGetComponent`, and cache them in
  `Awake`?
- Use vectors for directions and distances, and normalize a direction?
- Wait with a timer or a coroutine, and stop a coroutine?
- Read the mouse and the touchscreen, and test touch in the Simulator?
- Cast a ray in 2D and in 3D, with a layer mask?
- Connect a Slider, Toggle, Input Field and Dropdown with `AddListener`?
- Explain a `NullReferenceException`, read a stack trace, and use a breakpoint?
- Find a class, a method and its arguments in the Unity Scripting API?

*End of Level 2 — next up, Level 3, where characters come alive with the
Animator, enemies think with state machines, and you get ready for your first
Unity certificate.*
