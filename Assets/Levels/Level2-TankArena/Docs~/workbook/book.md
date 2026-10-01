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
| 2 | {{ref:vectors}}, {{ref:events}} | Vectors, event functions | — |
| 3 | Chapter 2 | Rigidbodies, velocity, `FixedUpdate` | A tank that drives |
| 4 | {{ref:methods}}, {{ref:input}} | Return types, parameters, overloading, `out`; mouse and touch | — |
| 5 | Chapter 3 | Pivots, angles, `Quaternion.Euler` | The turret |
| 6 | {{ref:components}}, {{ref:properties}} | `GetComponent`, `[RequireComponent]`; properties and constructors | — |
| 7 | Chapter 4 | Components you can share, key presses | Tracks and shells |
| 8 | {{ref:modifiers}}, {{ref:coroutines}} | `static`, `const`, `readonly`; coroutines and timers | — |
| 9 | Chapter 5 | Static classes, a tank that drives itself | Enemy tanks |
| 10 | {{ref:lists}}, {{ref:numbers}} | Lists; conversions | — |
| 11 | Chapter 6 | Spawn points, `%` | The game |
| 12 | {{ref:raycasts}} | Raycasts | — |
| 13 | Chapter 7 | 2D raycasts, layers, `out` | Enemies that fire back |
| 14 | {{ref:docs}} | The Unity docs | — |
| 15 | Chapter 8 | Rounds, filled images | Rounds and a health bar |
| 16 | Chapter 9 | Taps and holds, the Device Simulator | Touch controls |
| 17 | Chapter 10 | `LateUpdate`, `Lerp`, overloads | The follow camera |
| 18 | {{ref:dictionaries}}, {{ref:uievents}} | Dictionaries, UI events | — |
| 19 | Chapter 11 | Plain C# classes, `AddListener`, game states | Start and end |
| 20 | Chapter 12 | Particles, audio, default values | Repair kits, explosions and sound |
| 21 | Chapter 13 | Sliders, toggles, input fields, dropdowns | Settings |
| 22 | {{ref:null}} | `null`, stack traces, breakpoints | — |
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

{{concept:vectors}}

{{concept:events}}

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
({{ref:vectors}}). Turning left is anticlockwise, and anticlockwise angles are
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
({{ref:events}}).

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
  example. Using `null` is an error ({{ref:null}} tells the whole story), so the
  script checks first.
- `(Vector2)transform.up` keeps the `x` and `y` of the way the tank faces
  ({{ref:vectors}}). Times `drive * moveSpeed`, it's 3 units a second forwards,
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

{{concept:methods}}

{{concept:input}}

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
mouse ({{ref:vectors}}):

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

`Pointer.current` is the mouse, or a finger on a touchscreen ({{ref:input}}).
`pointer.position.ReadValue()` says where it is, in pixels on the screen, and
`cam.ScreenToWorldPoint` turns that into a point in the world: a `Vector3` whose
`z` is the camera's, −10. Stored in a `Vector2`, the `z` is simply dropped
({{ref:vectors}}). `cam` is found once, in `Awake`: `Camera.main` is the camera
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

{{concept:components}}

{{concept:properties}}

## Chapter 4 — Tracks and Shells

**Goal:** **Space** or a click fires a shell from the tip of the barrel, twice a
second at most. Shells fly straight, and burst on the first solid thing they
touch. And your tank is rebuilt from components that the enemy tanks can share.

### Idea — one tank, several components

Your tank's driving is in `PlayerTank`, and the enemy tanks will need exactly the
same driving. Instead of writing it twice, each job becomes a component of its
own ({{ref:components}}), and every tank gets the same set:

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
works out whether that time has come ({{ref:properties}}):

```csharp
public bool IsLoaded
{
    get { return Time.time >= nextShotTime; }
}
```

`Fire()` fires only if the turret is loaded, and returns a `bool`
({{ref:methods}}): `true` if it fired, `false` if it was still reloading. For
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
  ({{ref:components}}).
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

{{concept:modifiers}}

{{concept:coroutines}}

## Chapter 5 — Enemy Tanks

**Goal:** red enemy tanks drive around the arena by themselves, to a new place
every few seconds. Your shells hurt them: two hits, and one is gone.

### Idea — the size of the arena, in one place

Several scripts need to know how big the arena is: the enemies, to choose where
to go, and, in Chapter 10, the camera. The numbers go in one place:
`ArenaBounds`, a **static class** ({{ref:modifiers}}). Its sizes are `const`s, and
its method `RandomPoint()` is `static`, so any script can call
`ArenaBounds.RandomPoint()` without making an object first. There's only one
arena, so there's nothing to make.

### Idea — health you can trust

Every tank has hit points, so `Health` is a component too. Its `Current` value is
a property with a `private set` ({{ref:properties}}): every script can read it,
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
`other.TryGetComponent(out Health health)` ({{ref:components}}). A tank does, and
takes the shell's `damage`; a wall doesn't, and only stops the shell. The shell
doesn't need to know what a tank is.

### Idea — an enemy's brain

`EnemyTank` is the enemies' brain. Like `PlayerTank`, it uses the tank's `Tracks`
and `Turret`; it has no keys to read, so it decides by itself:

- A coroutine, `Think`, runs for as long as the tank is alive: it picks a random
  point in the arena, waits `thinkTime` seconds, and picks another, for ever
  ({{ref:coroutines}}).
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

{{concept:lists}}

{{concept:numbers}}

## Chapter 6 — The Game

**Goal:** when you press Play, four enemy tanks drive into the arena from its
corners. The top-right of the screen counts them, and "Arena clear!" appears when
you've destroyed them all.

### Idea — who's still out there?

The game keeps every living enemy in a `List<EnemyTank>` ({{ref:lists}}): `Add`
when one appears, `Remove` when one is destroyed. `enemies.Count` is always how
many are left. The field is `readonly` ({{ref:modifiers}}): it always holds the
same list, while the list itself grows and shrinks.

### Idea — spawn points

The enemies appear at four empty GameObjects, one near each corner, each turned
to face the middle of the arena. The game keeps them in an array,
`Transform[] spawnPoints`, and makes each tank at a point's position, turned like
the point: `Instantiate(prefab, point.position, point.rotation)`.

Which point does each tank use? `spawnIndex % spawnPoints.Length`, the remainder
({{ref:numbers}}), goes round and round the points, however many tanks there are:

| `spawnIndex` | 0 | 1 | 2 | 3 | 4 | 5 |
| --- | --- | --- | --- | --- | --- | --- |
| `spawnIndex % 4` | 0 | 1 | 2 | 3 | 0 | 1 |

### Idea — the enemies report back

When an enemy is destroyed, it must tell the game, so the game can take it off
the list. That needs a reference to the game, and a prefab can't keep a
reference to an object in a scene (the prefab exists before the scene does). So
the game hands it over: just after making a tank, it calls
`enemy.SetGame(this)`. `this` is the object whose code is running: the
`ArenaGame` itself ({{ref:properties}}). When the tank's health runs out, it
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
  you ({{ref:numbers}}).
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

{{concept:raycasts}}

## Chapter 7 — Enemies Fire Back

**Goal:** an enemy tank sees you when you're close enough and no wall is in the
way. Then it stops, turns its barrel towards you, and fires. Its shells hurt your
tank: ten hits, and it's destroyed.

### Idea — can it see you?

Every frame, each enemy casts a ray from its middle towards your tank
({{ref:raycasts}}). `direction` is the arrow from the enemy to your tank, made
1 long ({{ref:vectors}}):

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
({{ref:methods}}):

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

{{concept:docs}}

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

The whole battle is one coroutine, `PlayRounds` ({{ref:coroutines}}). For each
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

`ArenaGame` gets two versions of `ShowMessage`, as overloads ({{ref:methods}}):
`ShowMessage("Round 1")` shows a message that stays on the screen, and
`ShowMessage("Go!", 0.8f)` shows one for 0.8 seconds. The second starts a
coroutine that clears the text later. If another message arrives before then,
`StopCoroutine` cancels the old clearing, so the new message doesn't vanish too
early.

### Idea — a health bar

The bar is two UI images: a dark background, and a green **fill** in front of
it. The fill's **Image Type** is **Filled**: its **Fill Amount**, from 0 to 1,
says how much of the picture to show. Look up `Image.fillAmount` in the
Scripting API ({{ref:docs}}): it's a `float`, and `1` shows it all.

`Health` gets a property that gives exactly that, `Fraction`:

```csharp
get { return (float)Current / maxHealth; }
```

Without the `(float)`, `Current / maxHealth` would divide two `int`s, and the
answer would be 0 until your health was full again ({{ref:numbers}}).

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
({{ref:input}}):

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
({{ref:events}}), so the camera does its work there.

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

`CameraFollow` has two versions of `Shake`, as overloads ({{ref:methods}}):
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

{{concept:dictionaries}}

{{concept:uievents}}

## Chapter 11 — Start and End

**Goal:** the game waits on a start screen until you press **Play**. When your
tank is destroyed, or when you clear the last round, an end screen says
"Destroyed!" or "Victory!", with your name and the numbers of the match: the
rounds you cleared, the tanks you destroyed of each kind, your shots, and how
many shots each kill took. **Play Again** starts a new match.

### Idea — a game has states

A game isn't always being played: there's before the start, the match itself,
and after the end. `ArenaGame` keeps one property, `IsPlaying`
({{ref:properties}}), and everything that should only happen during a match
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
connects both buttons ({{ref:uievents}}): `AddListener` in `OnEnable`, and
`RemoveListener` in `OnDisable`. **Play** and **Play Again** both call
`StartGame`.

### Idea — the numbers of a match

The numbers go in a class of their own, `MatchStats`: a **plain C# class**,
which doesn't derive from `MonoBehaviour`, so it's never attached to a
GameObject ({{ref:properties}}). The game makes a new one with `new` at the
start of every match, so every match starts from zero:

```csharp
stats = new MatchStats(new string[] { "Light Tank", "Heavy Tank" });
```

The constructor gets the names of the kinds of tank, and starts each one at 0 in
a `Dictionary<string, int>` ({{ref:dictionaries}}): the key is the tank's name,
and the value is how many you've destroyed. That way the end screen lists every
kind of tank, even one you never destroyed.

| Member | Is |
| --- | --- |
| `RoundsCleared`, `ShotsFired` | counts, with a `private set` |
| `TotalKills` | a property that adds up every value in the dictionary |
| `ShotsPerKill` | a property: shots divided by kills, or 0 before the first kill |
| `AddRound()`, `AddShot()`, `AddKill(tankName)` | add one |
| `Summary()` | everything, one line each, for the end panel |

`{ShotsPerKill:F1}` shows the number with one decimal ({{ref:numbers}}): 8 shots
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

`Heal` has a parameter with a **default value** ({{ref:methods}}):
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
({{ref:uievents}}). Before connecting, `OnEnable` shows the current values with
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
`PlayerPrefs` in the Scripting API ({{ref:docs}}): `PlayerPrefs.SetFloat` and
`PlayerPrefs.GetFloat` are a good start.

# Part 5 — Finish

{{concept:null}}

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
   ({{ref:events}}).
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

{{include:check-yourself}}
