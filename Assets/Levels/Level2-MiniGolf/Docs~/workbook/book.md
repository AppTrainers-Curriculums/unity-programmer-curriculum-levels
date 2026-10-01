---
title: "Mini Golf"
subtitle: "Level 2: Builder"
author: "Unity Programmer Curriculum  ·  Level 2"
coverEyebrow: "Level 2 · Builder · Learn to Code · Make Games"
coverTop: "Mini"
coverRed: "Golf"
coverSub: "Your first 3D game: a ball you aim with a drag, a camera that follows it, three holes, a scorecard, settings, and controls that work on a phone."
coverPill: "Level 2 Workbook · Mini Golf"
coverCaption: "12 scripts · 3 holes · 1 game you can play with a finger"
coverArt: image
coverImage: cover.png
footer: "Mini Golf  ·  Level 2 Workbook"
---

# Part 0 — Before You Start

## What you're going to build

A **3D mini golf game**. Three holes built from tiles, a ball you aim by pulling
back and letting go, and a scorecard at the end:

| Hole | Name | Par | What makes it tricky |
| --- | --- | --- | --- |
| 1 | The Windmill | 2 | a spinning windmill, with a narrow tunnel through it |
| 2 | Around the Corner | 3 | a right-angle bend, and a pillar in the middle of the lane |
| 3 | Mind the Edge | 3 | a stretch with no walls, and a block sliding across it |

**How to play:** press anywhere on the screen, drag **back**, and let go. The
further you drag, the harder the putt. An aim line shows where the ball will go,
and a power meter shows how hard. It works with a mouse on a computer and with a
finger on a phone.

Each hole has a **par**: the number of strokes a good player needs. Beat it and
the game calls out a **Birdie!**; sink it in one and it's a **Hole in One!**,
with confetti either way. Roll off the edge of the course and it costs a stroke. After the
last hole, a scorecard adds everything up. There's also a settings panel for the
volume, the aim line, your name and the colour of your ball.

In Level 1 the game lived on a flat screen. This one is **3D**: the ball rolls on
real 3D physics, bounces off walls, and falls off edges.

## Level 2 has three books

Level 2 has three games, each with its own book: **Mini Golf** (this one, in 3D),
**Space Shooter** and **Tank Arena** (both in 2D). Every book teaches **every**
Level 2 topic, and they share the same C# Concept chapters, so your trainer can
run one book, or give different groups different books. If you've done one book
already, the C# Concept chapters in the next are a revision round.

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
| 1 | Chapter 1 | 3D scenes, models, Box Colliders, layers | Hole 1 |
| 2 | {{ref:methods}} | Return types, parameters, overloading, `out` | — |
| 3 | Chapter 2 | Rotating in 3D | The windmill |
| 4 | {{ref:events}}, {{ref:components}} | Event functions, `GetComponent` | — |
| 5 | Chapter 3 | Rigidbodies, Physics Materials, forces | The ball |
| 6 | {{ref:properties}} | Properties and constructors | — |
| 7 | Chapter 4 | `FixedUpdate`, speed | A ball that stops |
| 8 | {{ref:vectors}} | Vectors | — |
| 9 | Chapter 5 | `LateUpdate`, `Lerp` | The follow camera |
| 10 | {{ref:input}}, {{ref:raycasts}} | Mouse and touch, raycasts | — |
| 11 | Chapter 6 | The Pointer, Line Renderers | Aim and putt |
| 12 | {{ref:numbers}}, {{ref:docs}} | Conversions, rounding, the Unity docs | — |
| 13 | Chapter 7 | Triggers in 3D | The cup and the strokes |
| 14 | {{ref:modifiers}}, {{ref:lists}}, {{ref:dictionaries}} | `static`, `const`, lists, dictionaries | — |
| 15 | Chapter 8 | Plain C# classes | Scores and golf names |
| 16 | {{ref:coroutines}} | Coroutines and timers | — |
| 17 | Chapter 9 | Kinematic Rigidbodies | Holes 2 and 3 |
| 18 | Chapter 10 | — | A round of golf |
| 19 | Chapter 11 | Audio, particles, collisions | Sound and confetti |
| 20 | {{ref:uievents}} | UI events and `AddListener` | — |
| 21 | Chapter 12 | Sliders, toggles, input fields, dropdowns | Settings |
| 22 | Chapter 13 | — | The scorecard |
| 23 | {{ref:null}} | `null`, stack traces, breakpoints | — |
| 24 | Chapter 14 | Debugging | Break it, then fix it |
| 25 | Chapter 15 | Builds, testing touch | A game you can share |
| 26 | Part 7 | Exam-style practice | — |

## For trainers: running a session

Sessions follow the route above, with the same rhythm as Levels 0 and 1:

| Share | Activity | From |
| --- | --- | --- |
| About 20% | **Concept:** teach the idea. Students predict each example's Console output before you run it. | C# Concept chapters |
| About 60% | **Build:** students follow the chapter in Unity and press Play at every checkpoint. | Build chapters |
| About 20% | **Practice:** the **Do it** exercises, in class or as homework. | C# Concept chapters |

Students join Level 2 by passing the **Level 2 entry test** (the Level 2 entry
test papers in the course project; the answer key is a separate trainer-only
file). Chapters 6 and 10 are the heart of this book: the aiming, and the round of
golf that ties the holes together, so give them the most time. Part 7 rehearses
the question styles of the **Unity Certified User: Programmer** exam, which
students sit at the end of Level 3.

Your trainer project has a finished version of the game, and a menu item that
builds its scene from scratch (**Tools → Mini Golf (Level 2) → Build Scene**):
use it to show the goal on the first day, or to rescue a scene that's beyond
repair.

## The pieces we'll build

Twelve scripts, and three holes:

```
GolfBall ──── the ball: physics pushes it, the script notices when it stops
ShotAimer ─── reads the drag, draws the aim line, and putts
CameraFollow ─ follows the ball from above and behind
Spinner ───── turns the windmill's blades
MovingBlock ── slides a block across the lane on hole 3
Cup ───────── a trigger in each cup, at the height of the ball
Hole ──────── one per hole: its name, its par, where the ball starts
GolfGame ──── runs the round: strokes, holes, messages, sounds, the scorecard
BallSounds ── clicks when the ball hits a wall
SettingsMenu ─ the settings panel: volume, aim line, name, ball colour

HoleScore ─── one line of the scorecard (a plain C# class)
GolfTerms ─── golf's names for scores: Par, Birdie, Eagle… (a static class)
```

## New words for Level 2

| Word | What it means |
| --- | --- |
| **Model** | A 3D object made in a modelling program, saved as a file (`.fbx`). It holds meshes and materials. |
| **Mesh** | The shape of a 3D object: a skin of triangles. |
| **Box Collider** | An invisible box that physics can touch. The models are only pictures; colliders are what the ball bumps into. |
| **Rigidbody** | The 3D version of Level 1's Rigidbody 2D: hands an object to 3D physics. |
| **Physics Material** | Settings for how a surface slides and bounces: friction and bounciness. |
| **Kinematic** | A Rigidbody that physics doesn't move, but that you move from code, pushing others as it goes. |
| **Layer** | A group a GameObject belongs to, used to choose what physics and raycasts can touch. |
| **Coroutine** | A method that can pause and carry on later. |
| **Particle System** | A component that throws out lots of tiny images: confetti, sparks, smoke. |

## One-time project setup

- **Unity 6**, with a new project created from the **Universal 3D** template.
  (Not 2D this time!)
- **Input:** a new Unity 6 project reads the keyboard, the mouse and the
  touchscreen with the **Input System** package, and that's what this book uses.
  There's nothing to set up.
- **Art:** the tiles, flags and balls come from Kenney's **Minigolf Kit**, free
  to use for anything (www.kenney.nl). Your trainer shares the models: a folder of
  `.fbx` files, with a `Textures` folder inside. If you download the kit
  yourself, use the files in its `Models/FBX format` folder.
- **Sound:** your trainer shares five sounds: `Putt.wav`, `Wall.wav`, `Cup.wav`,
  `Fall.wav` and `Cheer.wav`. You'll need them in Chapter 11.
- Scripts live in `Assets/Scripts`, the Kenney models in `Assets/Models`, sounds
  in `Assets/Audio`, and materials in `Assets/Materials`.

# Part 1 — The Course

## Chapter 1 — A Course in 3D

**Goal:** the first hole of the course, built from Kenney's tiles in a 3D scene,
with invisible colliders for the ball to roll on, seen through the camera the
game will use.

### Idea — from 2D to 3D

In Levels 0 and 1, the camera looked straight at a flat world: `x` went across
and `y` went up. A 3D world adds a third direction, `z`: **depth**, going away
from you. In this game the ground is flat along `x` and `z`, and `y` is
**height**:

```
          y  (up)
          |
          |
          +------ x  (right)
         /
        /
       z  (forward, away from the camera)
```

One unit is one **metre**. Every Kenney tile is exactly 1 × 1 unit, the green
surface of a tile sits 0.063 units above the ground, and the ball is 0.07 units
across: 7 centimetres, like a real golf ball.

### Idea — moving around a 3D scene

In 2D you only ever panned and zoomed. In 3D you also need to **look around**.
With the mouse over the **Scene** view:

| To… | Do this |
| --- | --- |
| look around | hold the **right** mouse button and move the mouse |
| fly through the scene | hold the **right** mouse button and press **W A S D** (**Q** and **E** go down and up) |
| orbit around what's selected | hold **Alt** (**Option** on Mac) and drag with the **left** button |
| zoom | scroll the mouse wheel |
| frame the selected object | press **F** |

The **gizmo** in the top-right corner of the Scene view shows which way `x`, `y`
and `z` point. Click one of its arms to look straight along that axis, and click
the cube in its middle to switch between a perspective and a flat view.

### Idea — the pictures and the colliders

A **model** (an `.fbx` file) holds one or more **meshes** (the shape, made of
triangles) and **materials** (how it looks). Drag a model into the scene and
Unity makes a GameObject from it, like a prefab.

A model is only a **picture**, though: the ball would fall straight through it.
In 2D you gave sprites a **Collider 2D**; in 3D, objects need a **3D collider**:
a Box, Sphere or Capsule Collider, or a **Mesh Collider**, which copies the
mesh's exact shape.

Unity can give every tile a Mesh Collider automatically, but that's a trap. Each
tile would get its own collider, and where two tiles meet, the ball catches on
the joint and hops. So we do what real games do: the tiles stay pictures, and
each hole gets a few **invisible Box Colliders**:

- **one floor** for the whole hole: one flat box, so there are no joints to catch
  on
- **one box per wall**, running the whole length of the wall

Simple shapes for physics, detailed models for the eyes. It's also much less
work for the computer.

### Do it — the project and the scene

1. In **Unity Hub**, create a new project from the **Universal 3D** template.
2. **File → New Scene**, pick **Basic (URP)** (a camera and a light), then
   **File → Save As** `Assets/Scenes/MiniGolf.unity`.
3. In the **Project** window, create the folders `Models`, `Audio`, `Scripts` and
   `Materials` inside `Assets`.
4. Copy Kenney's model files (the `.fbx` files **and** their `Textures` folder)
   into `Assets/Models`, and the five sounds into `Assets/Audio`.

> **Watch out:** the `Textures` folder must sit **inside** `Models`, next to the
> `.fbx` files. That's where the models look for their colours. Without it,
> every tile is plain white.

### Do it — a layer for the course

A **layer** is a group for GameObjects, a little like a tag, except that physics
understands it. The aim line in Chapter 6 will stop at the walls of the course,
and it will know them by their layer.

1. Select any GameObject, open the **Layer** dropdown at the top-right of the
   Inspector, and choose **Add Layer…**.
2. Type `Course` in the first empty **User Layer**.

### Do it — the tiles of Hole 1

1. **GameObject → Create Empty**. Rename it `Hole 1`, and set its **Position** to
   `(0, 0, 0)`.
2. Drag each of these models from `Assets/Models` **onto** `Hole 1` in the
   Hierarchy, so it becomes a child of `Hole 1`, then type its **Position** and
   **Rotation** into the Inspector:

| Model | Position | Rotation |
| --- | --- | --- |
| `end` | (0, 0, 0) | (0, 180, 0) |
| `straight` | (0, 0, 1) | (0, 0, 0) |
| `windmill` | (0, 0, 2) | (0, 0, 0) |
| `straight` | (0, 0, 3) | (0, 0, 0) |
| `hole-square` | (0, 0, 4) | (0, 0, 0) |

3. Drag `flag-red` onto `Hole 1` as well: **Position** `(0, 0.032, 4)`,
   **Rotation** `(0, -40, 0)`. Its pole stands in the hole.

The `end` tile is closed on one side. Turning it 180° puts the closed side at the
back, behind where the ball starts.

> **Tip:** because every tile is exactly 1 unit wide, whole-number positions put
> them edge to edge. Hold **Ctrl** (**Cmd** on Mac) while you drag an object with
> the Move tool and it jumps 0.25 units at a time, so it's easy to land exactly
> on a whole number.

### Do it — the colliders of Hole 1

1. Right-click `Hole 1` → **Create Empty**, and rename the new child `Colliders`.
2. For each row below: right-click `Colliders` → **Create Empty**, name it, type
   its **Position**, then **Add Component → Box Collider** and type the collider's
   **Size**:

| Name | Position | Box Collider Size |
| --- | --- | --- |
| `Floor` | (0, 0.0315, 2) | (1, 0.063, 5) |
| `Left Wall` | (-0.45, 0.0735, 2) | (0.1, 0.147, 5) |
| `Right Wall` | (0.45, 0.0735, 2) | (0.1, 0.147, 5) |
| `Back Wall` | (0, 0.0735, -0.45) | (1, 0.147, 0.1) |
| `End Wall` | (0, 0.0735, 4.45) | (1, 0.147, 0.1) |
| `Windmill Left` | (-0.3, 0.15, 2) | (0.2, 0.3, 0.8) |
| `Windmill Right` | (0.3, 0.15, 2) | (0.2, 0.3, 0.8) |

3. Select `Hole 1`, set its **Layer** to `Course`, and choose **Yes, change
   children** when Unity asks.

Where do the numbers come from? A box's **Position** is its **centre**. The
floor is 0.063 thick, so its centre is half of that, 0.0315, up; it's 5 tiles
long, so its centre is at `z = 2`, the middle tile. The walls are 0.147 tall and
0.1 thick, standing on the outer edges of the tiles, at `x = ±0.45`. The two
windmill boxes are the building's feet on either side of its tunnel.

> **Tip:** make `Left Wall`, then **Ctrl + D** (**Cmd + D**) to duplicate it,
> rename the copy `Right Wall` and change only the `x`. Duplicating saves a lot
> of typing.

### Do it — the camera

Select **Main Camera**:

1. Set its **Position** to `(0, 3, -2.5)` and its **Rotation** to `(50, 0, 0)`.
   The camera floats 3 metres up, behind the start, looking down at 50°.
2. In the **Camera** component, under **Environment**, set **Background Type** to
   **Solid Color** and the **Background** colour to a light sky blue, `#8ECAE6`.

### Test it

Select `Colliders` and look at the Scene view: thin green outlines show the
boxes, hugging the tiles' floor and walls. Colliders don't show in the Game view;
nobody ever sees them.

Press **Play**. The Game view shows Hole 1 from above and behind: the closed end
tile at the front, the windmill in the middle, and the red flag at the far end.
Nothing moves yet. That's Chapter 2's job.

### Challenge

Before you go on, explore. Fly around the hole in the Scene view with the right
mouse button and **W A S D**. Then add a **Sphere** (**GameObject → 3D Object →
Sphere**) with a **Rigidbody**, place it above the floor, and press Play: it
drops onto your invisible floor and stops, exactly on the green. Delete it
afterwards: the real ball comes in Chapter 3.

{{concept:methods}}

## Chapter 2 — The Windmill

**Goal:** the windmill's blades turn, forever, at a speed you can tune in the
Inspector.

### Idea — rotating in 3D

`transform.Rotate` turns an object by some angles, in degrees, around its **own**
three axes: the `x` angle tips it forward, the `y` angle spins it like a
turntable, and the `z` angle turns it like a clock face. As in Level 1, anything
that changes over time is multiplied by `Time.deltaTime`, so "degrees per second"
becomes "degrees this frame".

A `Vector3` field holds three numbers, so one field can hold a speed for each
axis. In the Inspector it shows three boxes: **X**, **Y** and **Z**.

### Idea — a child moves with its parent

Expand the `windmill` tile in the Hierarchy: it has a child called `blades`. A
child follows its parent wherever it goes, but it can also move on its own. Spin
the child, and only the blades turn; the building stays still.

### Do it — the script

Create a script called `Spinner` in `Assets/Scripts`:

```csharp:Spinner.cs
using UnityEngine;

// Spins an object around its own axes, for ever: the windmill's blades.
public class Spinner : MonoBehaviour
{
    [SerializeField] Vector3 degreesPerSecond = new Vector3(0f, 0f, 90f);

    void Update()
    {
        transform.Rotate(degreesPerSecond * Time.deltaTime);
    }
}
```

`degreesPerSecond * Time.deltaTime` multiplies all three numbers at once: a
vector times a number is another vector ({{ref:vectors}} has more on vectors).

### Do it — attach it

1. In the Hierarchy, expand `Hole 1` → `windmill` and select `blades`.
2. **Add Component → Spinner**, and set **Degrees Per Second** to `(0, 0, 60)`.

The blades have no collider, and don't need one: they turn far above the ball.

### Test it

Press **Play**: the blades turn slowly. While the game runs, change **Z** to
`-200`: they turn the other way, fast. Stop the game and the value goes back to
`60`.

### Challenge

Put a `Spinner` on `flag-red` with **Degrees Per Second** `(0, 30, 0)` and watch
the flag turn around its pole. Then try to make it swing back and forth instead
of round and round: you'll need a sine wave, which you'll meet with the moving
block in Chapter 9.

# Part 2 — The Ball

{{concept:events}}

{{concept:components}}

## Chapter 3 — The Ball

**Goal:** a golf ball that physics can push: it slides down the lane, through the
windmill's tunnel, and bounces off the walls.

### Idea — 3D physics

Everything you learned about 2D physics in Level 1 has a 3D twin. The names just
lose their "2D":

| 2D (Level 1) | 3D (this book) |
| --- | --- |
| Rigidbody 2D | **Rigidbody** |
| Box Collider 2D, Circle Collider 2D | **Box Collider**, **Sphere Collider**, Capsule Collider, Mesh Collider |
| Gravity Scale | **Use Gravity**: on or off. Gravity pulls at 9.81 m/s², like on Earth |
| Linear Damping | Linear Damping: the same air resistance |
| `OnTriggerEnter2D(Collider2D other)` | `OnTriggerEnter(Collider other)` |
| `OnCollisionEnter2D(Collision2D collision)` | `OnCollisionEnter(Collision collision)` |

> **Watch out:** 2D and 3D physics are two separate worlds. A Rigidbody 2D never
> touches a Box Collider, and `OnTriggerEnter2D` never fires for 3D colliders.
> In a 3D game, use the names without "2D".

### Idea — a Physics Material

How a surface slides and bounces is set by a **Physics Material**:

| Setting | Means |
| --- | --- |
| **Dynamic Friction** / **Static Friction** | how much it grips, while sliding and when still: 0 is ice |
| **Bounciness** | 0 doesn't bounce at all; 1 bounces back as fast as it came |
| **Friction Combine** / **Bounce Combine** | when two surfaces touch, how their values mix: Average, Minimum, Maximum or Multiply |

Our ball gets **no friction at all**. A 7 cm ball needs to spin very fast to roll
properly, faster than Unity lets things spin by default, so a gripping ball
scrubs to a halt. Instead, ours slides like a puck, and **Linear Damping** slows
it down gently. From above, a sliding ball and a rolling ball look the same.

Its **Bounciness** is 0.6, and **Bounce Combine: Maximum** means the ball's
bounciness wins over the walls' (which is 0): every wall bounces the ball back at
60% of its speed.

> **Watch out:** Unity ignores bounces slower than the **Bounce Threshold**,
> which is 2 metres per second by default. A putt rarely hits a wall that fast,
> so the ball would stick to walls instead of bouncing. We lower it to 0.5. Don't
> go much lower: then a ball resting on the floor starts to jiggle, bouncing on
> the spot a tiny bit on every physics step.

### Idea — pushing a Rigidbody

`AddForce` pushes a Rigidbody. Its second argument, a `ForceMode`, says how:

| ForceMode | Like | Use it |
| --- | --- | --- |
| `ForceMode.Force` (the default) | a steady push, a little on every physics step | every step, in `FixedUpdate`: an engine, the wind |
| `ForceMode.Impulse` | one kick, all at once | **once**: a putt, a jump, an explosion |

Both take the object's **mass** into account: twice as heavy moves half as fast.

An impulse is a single kick. Unity adds it at the next physics step, so it's
fine to call it from `Update`, the moment a key is pressed. The rule "physics in
`FixedUpdate`" ({{ref:events}}) is for forces that push **every** step.

### Do it — the ball

1. **GameObject → Create Empty**. Rename it `Ball` and set its **Position** to
   `(0, 0.1, 0)`: on the green (0.063) plus half the ball (0.035), plus a hair.
2. Drag the `ball-red` model onto `Ball`. Rename the child `Model`, and check its
   **Position** is `(0, 0, 0)`.
3. Select `Ball`: **Add Component → Sphere Collider**, and set its **Radius** to
   `0.035`.
4. **Add Component → Rigidbody**, and set:
   - **Linear Damping** `0.6`: the air resistance that slows the ball down
   - **Interpolate**: **Interpolate**. Physics moves the ball 50 times a second,
     but the screen may draw 60 or 120 frames: this smooths the movement in
     between.
   - **Collision Detection**: **Continuous Dynamic**. A small, fast ball could
     jump right through a thin wall between two physics steps; this checks the
     whole path.

### Do it — the Physics Material

1. In `Assets/Materials`: **Assets → Create → Physics Material**. Name it `Ball`.
2. Set **Dynamic Friction** `0`, **Static Friction** `0`, **Bounciness** `0.6`,
   **Friction Combine** **Minimum** and **Bounce Combine** **Maximum**.
3. Drag it into the **Material** slot of the Ball's **Sphere Collider**.
4. **Edit → Project Settings → Physics → Settings**. In the **GameObject** tab,
   set **Bounce Threshold** to `0.5`.

### Do it — the script

Create `GolfBall` in `Assets/Scripts` and attach it to `Ball`. For now, **Space**
gives the ball a test push:

```csharp
using UnityEngine;
using UnityEngine.InputSystem;

// The golf ball. For now, Space gives it a push, to test the physics.
[RequireComponent(typeof(Rigidbody))]
public class GolfBall : MonoBehaviour
{
    [SerializeField] float testForce = 2f;

    Rigidbody body;

    void Awake()
    {
        body = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            body.AddForce(Vector3.forward * testForce, ForceMode.Impulse);
        }
    }
}
```

Read it before you move on:

- `[RequireComponent(typeof(Rigidbody))]`: the ball can't work without a
  Rigidbody, so Unity won't let anyone remove it ({{ref:components}}).
- `GetComponent<Rigidbody>()` in `Awake`: find the Rigidbody **once**, and keep it
  in the field `body`.
- `Vector3.forward * testForce` is an arrow along `z`, down the lane, 2 long. As an
  impulse on a ball of mass 1, it starts the ball at 2 metres per second.

### Test it

Press **Play**, click the Game view, and press **Space**. The ball slides down the
lane, through the windmill's tunnel, and slows down. Set **Test Force** to `4`
and try again: it reaches the far wall and bounces back.

Notice two problems. The ball slows down but never quite **stops**: it crawls on
and on. And pressing **Space** while it's moving pushes it again. Chapter 4 fixes
both.

### Challenge

Make the **B** key push the ball **back**, towards the start
(`Keyboard.current.bKey`, `Vector3.back`). Then try a push that isn't straight:
`new Vector3(0.3f, 0f, 1f)`. What happens when it hits the windmill?

{{concept:properties}}

## Chapter 4 — A Ball that Stops

**Goal:** the ball knows whether it's moving, stops cleanly when it's slow, and
only accepts a new push when it has stopped.

### Idea — when is a ball stopped?

Linear Damping takes away a share of the ball's speed every moment: at 0.6, about
half of it every second. Half of a half of a half… gets smaller and smaller, but
never reaches zero. So **we** decide when the ball has stopped: when it's been
slower than **0.15 metres per second** for **0.2 seconds**. Then we stop it
ourselves, by setting its velocity to zero.

### Idea — reading the Rigidbody

`body.linearVelocity` is the ball's velocity: a `Vector3` arrow in metres per
second, pointing the way it's going. Its **length**, `.magnitude`, is the speed.

We only want the speed **across** the course, though. A ball that bobs up and
down on the spot hasn't gone anywhere, so we set the arrow's `y` to 0 before
measuring it:

```csharp
Vector3 velocity = body.linearVelocity;
velocity.y = 0f;
float speed = velocity.magnitude;
```

> **Note:** older Unity versions called it `velocity`, not `linearVelocity`.
> You'll still see the old name in tutorials and exam questions: they're the same
> thing.

### Idea — check it in FixedUpdate

Physics changes the ball's speed on the physics clock, so that's where we check
it: in `FixedUpdate` ({{ref:events}}). There, `Time.deltaTime` is the physics
step, 0.02 seconds, so adding it up measures how long the ball has been slow.

### Idea — properties for other scripts

Soon other scripts will ask the ball questions: "are you moving?", "how fast?".
The answers are **properties** ({{ref:properties}}):

- `IsMoving { get; private set; }`: everyone can read it, only the ball changes it.
- `Speed`: worked out fresh every time it's read, with a `get` body.

### Do it — the script

Update `GolfBall`:

```csharp
using UnityEngine;
using UnityEngine.InputSystem;

// The golf ball. Physics moves it; this script pushes it and notices when it
// has stopped. For now, Space still gives it a test push.
[RequireComponent(typeof(Rigidbody))]
public class GolfBall : MonoBehaviour
{
    [SerializeField] float testForce = 2f;
    [SerializeField] float stopSpeed = 0.15f;    // slower than this (metres per second)...
    [SerializeField] float stopDelay = 0.2f;     // ...for this long (seconds), and the ball stops

    Rigidbody body;
    float slowTime = 0f;

    public bool IsMoving { get; private set; }

    // How fast the ball rolls across the course. Up-and-down movement doesn't
    // count: a ball that's only bobbing on the spot has stopped.
    public float Speed
    {
        get
        {
            Vector3 velocity = body.linearVelocity;
            velocity.y = 0f;
            return velocity.magnitude;
        }
    }

    void Awake()
    {
        body = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && !IsMoving)
        {
            Shoot(Vector3.forward, testForce);
        }
    }

    void FixedUpdate()
    {
        if (!IsMoving)
        {
            return;
        }

        if (Speed < stopSpeed)
        {
            slowTime += Time.deltaTime;
            if (slowTime >= stopDelay)
            {
                Stop();
            }
        }
        else
        {
            slowTime = 0f;
        }
    }

    public void Shoot(Vector3 direction, float force)
    {
        body.AddForce(direction * force, ForceMode.Impulse);
        IsMoving = true;
        slowTime = 0f;
    }

    public void Stop()
    {
        body.linearVelocity = Vector3.zero;
        body.angularVelocity = Vector3.zero;
        IsMoving = false;
    }
}
```

Read it before you move on:

- `Shoot` and `Stop` are `public`: the aiming script and the game will call them.
  `Shoot` takes a direction and a force, so it can putt the ball any way.
- In `FixedUpdate`, `slowTime` adds up the time the ball has been slow, and goes
  back to 0 if it speeds up again, for example after bouncing off a wall.
- `Stop` sets both velocities to zero: `linearVelocity` (moving) and
  `angularVelocity` (spinning).
- `Update` only shoots when `!IsMoving`: no more pushes while the ball rolls.

### Test it

Press **Play** and **Space**. The ball slides, slows, and stops dead a few seconds
later. Press **Space** while it's moving: nothing. Once it stops, **Space** pushes
it again.

> **Tip:** properties don't show in the Inspector. To watch a script's private
> fields while the game runs, click the **⋮** menu at the top-right of the
> Inspector and choose **Debug**: you'll see `slowTime` count up as the ball slows
> down. Switch back to **Normal** afterwards.

### Challenge

Print how long each putt lasted: remember `Time.time` in `Shoot`, and in `Stop`
print `"Stopped after " + (Time.time - shotTime) + " seconds"`. Then try a
`stopSpeed` of `0.5`: what changes?

{{concept:vectors}}

## Chapter 5 — The Follow Camera

**Goal:** the camera follows the ball smoothly, from above and behind, wherever
it goes.

### Idea — LateUpdate

The camera must move **after** the ball has moved in this frame; otherwise it's
always one frame behind, and the picture judders. That's what `LateUpdate` is
for: Unity calls it every frame, once every `Update` has finished
({{ref:events}}).

### Idea — an offset

Right now the ball is at `(0, 0.1, 0)` and the camera at `(0, 3, -2.5)`. The
arrow from the ball to the camera is the camera's **offset**:
"3 metres up, 2.5 back". To follow the ball, keep that arrow the same:

```
camera position = ball position + offset
```

### Idea — Lerp: part of the way there

Jumping straight to the new position works, but feels stiff. `Vector3.Lerp(a, b,
t)` gives a point **part of the way** from `a` to `b`: `t = 0` is `a`, `t = 1` is
`b`, `t = 0.5` is halfway.

```csharp
transform.position = Vector3.Lerp(transform.position, wanted, smoothing * Time.deltaTime);
```

Every frame, the camera covers a share of the distance still left. When the ball
shoots off, the camera hurries after it; as it catches up, it slows down, and
glides to a stop. A bigger `smoothing` follows more tightly.

### Do it — the script

Create `CameraFollow` and attach it to **Main Camera**:

```csharp:CameraFollow.cs
using UnityEngine;

// Keeps the camera above and behind the ball. It runs in LateUpdate: after the
// ball has moved this frame, so the camera never lags a frame behind.
public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector3 offset = new Vector3(0f, 1.6f, -1.6f);
    [SerializeField] float smoothing = 4f;

    void LateUpdate()
    {
        Vector3 wanted = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, wanted, smoothing * Time.deltaTime);
    }
}
```

1. Drag `Ball` into the **Target** field. A `Transform` field accepts any
   GameObject: Unity fills it with that object's Transform.
2. Set **Offset** to `(0, 3, -2.5)`: exactly where the camera already is, compared
   with the ball.

### Test it

Press **Play** and **Space**: the camera glides after the ball, keeping it in the
middle of the screen, and settles when the ball stops. Try **Smoothing** `1`
(lazy) and `20` (tight) while the game runs.

The camera doesn't turn: it only slides, always looking down the course at the
same angle. That's what makes aiming easy in the next chapter.

### Challenge

Make the **Z** and **X** keys zoom: multiply the offset by a number that `Z` makes
smaller and `X` makes bigger (keep it between 0.5 and 2 with `Mathf.Clamp`).

# Part 3 — Putting

{{concept:input}}

{{concept:raycasts}}

## Chapter 6 — Aim and Putt

**Goal:** press anywhere, drag back and let go: the ball shoots the other way, as
hard as you dragged, and a line shows the aim, stopping at the first wall.

### Idea — pull back to shoot forward

The drag works like a slingshot. The player presses, pulls **back**, and lets go;
the ball flies the **opposite** way. So the shot is the drag turned around:

```
drag = where it started − where the pointer is now
```

The **longer** the drag, the harder the putt. We measure it against the height
of the screen, so the game feels the same on a phone and a big monitor: a drag
of 35% of the screen's height is full power.

```
power = drag length ÷ (screen height × 0.35), kept between 0 and 1
```

`Mathf.Clamp01` keeps a number between 0 and 1: a longer drag still gives
exactly full power.

### Idea — from the screen to the ground

The drag is in **pixels** on a flat screen: `x` across, `y` up. The ball moves on
the **ground**. We translate:

| On the screen | On the ground |
| --- | --- |
| drag **up** the screen (`drag.y`) | away from the camera: the camera's `forward` |
| drag **right** (`drag.x`) | the camera's `right` |

The camera looks **down** at 50°, so its `forward` arrow points into the ground.
We flatten it first (`y = 0`), then normalize it, so it's a flat direction of
length 1 ({{ref:vectors}}). Then:

```csharp
shotDirection = (forward.normalized * drag.y + right.normalized * drag.x).normalized;
```

### Idea — the aim line

A **Line Renderer** draws a line through points in the world. We give it two:
the ball, and the end of the aim. To keep the line honest, a **raycast**
({{ref:raycasts}}) goes from the ball along the shot direction, and if it hits a
wall on the `Course` layer first, the line stops there: you see exactly how far
the ball can go before bouncing.

### Do it — the aim line

1. **GameObject → Create Empty**, and rename it `Shot Aimer`.
2. **Add Component → Line Renderer**. Set the **Width** to `0.02`, and under
   **Lighting**, **Cast Shadows** to **Off**. Leave **Use World Space** ticked.
3. In `Assets/Materials`: **Assets → Create → Material**, named `AimLine`. Set its
   **Shader** to **Universal Render Pipeline → Unlit** and its **Base Map** colour
   to white.
4. Drag `AimLine` into the Line Renderer's **Materials** list, as **Element 0**.

### Do it — the script

Create `ShotAimer` and attach it to `Shot Aimer`:

```csharp
using UnityEngine;
using UnityEngine.InputSystem;

// Drag back from anywhere on the screen and let go to putt. It works the same
// with a mouse and with a finger, because it reads the Pointer.
public class ShotAimer : MonoBehaviour
{
    [SerializeField] GolfBall ball;
    [SerializeField] LineRenderer aimLine;
    [SerializeField] LayerMask wallsMask;
    [SerializeField] float maxForce = 4f;         // the push at full power
    [SerializeField] float fullDrag = 0.35f;      // a drag this big (a share of the screen's height) is full power
    [SerializeField] float lineLength = 1.2f;     // the aim line's length at full power, in metres

    Camera cam;
    bool aiming = false;
    Vector2 dragStart;
    Vector3 shotDirection;
    float shotPower;

    void Awake()
    {
        cam = Camera.main;
        aimLine.enabled = false;
    }

    void Update()
    {
        Pointer pointer = Pointer.current;
        if (pointer == null || ball.IsMoving)
        {
            return;
        }

        if (pointer.press.wasPressedThisFrame)
        {
            aiming = true;
            dragStart = pointer.position.ReadValue();
        }

        if (!aiming)
        {
            return;
        }

        Aim(pointer.position.ReadValue());

        if (pointer.press.wasReleasedThisFrame)
        {
            if (shotPower > 0.05f)
            {
                ball.Shoot(shotDirection, shotPower * maxForce);
            }
            CancelAim();
        }
    }

    void Aim(Vector2 pointerPosition)
    {
        // Pull back to shoot forward: the drag points the opposite way.
        Vector2 drag = dragStart - pointerPosition;
        shotPower = Mathf.Clamp01(drag.magnitude / (Screen.height * fullDrag));

        // Turn the drag on the screen into a direction on the ground, as the camera sees it.
        Vector3 forward = cam.transform.forward;
        forward.y = 0f;
        Vector3 right = cam.transform.right;
        right.y = 0f;
        shotDirection = (forward.normalized * drag.y + right.normalized * drag.x).normalized;

        // The aim line starts at the ball and stops at the first wall in the way.
        Vector3 start = ball.transform.position;
        float length = shotPower * lineLength;
        if (Physics.Raycast(start, shotDirection, out RaycastHit hit, length, wallsMask))
        {
            length = hit.distance;
        }
        aimLine.SetPosition(0, start);
        aimLine.SetPosition(1, start + shotDirection * length);
        aimLine.enabled = true;
    }

    public void CancelAim()
    {
        aiming = false;
        shotPower = 0f;
        aimLine.enabled = false;
    }
}
```

Read it before you move on:

- `Pointer.current` is the mouse on a computer and the finger on a phone
  ({{ref:input}}). If there's no pointer at all, or the ball is still moving,
  `return` leaves `Update` straight away: no aiming.
- `aiming` remembers that a drag has started. While it's `true`, `Aim` runs every
  frame, so the line follows the pointer.
- On release, a drag of less than 5% power doesn't count: a click without a drag
  shouldn't putt.
- `Camera.main` finds the camera tagged **MainCamera**. We keep it in `cam`, so
  we only search once.
- `Physics.Raycast(…, out RaycastHit hit, length, wallsMask)` returns `true` when a
  wall is closer than `length`; then `hit.distance` is how far away it is.

### Do it — connect it

1. Select `Shot Aimer`, and drag `Ball` into **Ball**, and `Shot Aimer` itself
   into **Aim Line** (Unity picks its Line Renderer).
2. Open the **Walls Mask** dropdown and tick only `Course`.

### Do it — no more test pushes

The ball has a real controller now. In `GolfBall`, delete the `testForce` field,
the whole `Update` method, and the `using UnityEngine.InputSystem;` line, and
change the comment at the top to:

```csharp
// The golf ball. Physics moves it; this script pushes it and notices when it
// has stopped.
```

### Test it

Press **Play**. Press in the Game view and drag **down**, towards you: an aim line
grows from the ball, pointing up the lane. Move the pointer left and right and the
line swings. Aim straight at the windmill's tunnel, and let go: putt! Point the
line at a wall: it stops at the wall.

While the ball rolls, pressing does nothing. A click without a drag does nothing
either.

**Touch:** switch the Game view to **Simulator**, choose a phone, and play with
the mouse as a finger. It works without a single change to the code.

### Challenge

Make the aim line go from white to red as the power grows. The line's colour
comes from its material, so in `Aim` set `aimLine.material.color` to
`Color.Lerp(Color.white, Color.red, shotPower)`.

{{concept:numbers}}

{{concept:docs}}

## Chapter 7 — The Cup and the Strokes

**Goal:** the game counts the strokes, shows them on screen with the power of the
putt, and notices when the ball drops into the cup.

### Idea — a trigger in the cup

The floor under the hole is a solid box, so the ball can't really fall in. It
doesn't need to. In the middle of the cup, a small invisible **trigger** sphere
sits at the height of the ball. When the ball is inside it **and** slow enough,
the ball has dropped into the cup, and the game makes it disappear.

A fast ball can cross the cup and carry on, just like a real putt that's too
hard. To check the speed while the ball is inside, we use `OnTriggerStay`, the
3D twin of Level 1's trigger messages: Unity calls it on every physics step while
something stays inside the trigger.

| Message | When |
| --- | --- |
| `OnTriggerEnter(Collider other)` | once, when something enters the trigger |
| `OnTriggerStay(Collider other)` | on every physics step while it's inside |
| `OnTriggerExit(Collider other)` | once, when it leaves |

### Idea — a game manager

As in Level 1, one script runs the game: `GolfGame`. It counts the strokes, shows
the text on screen, and decides whether the player may putt. The aimer asks it
with a property, `CanShoot`, and tells it about every stroke with `StrokeTaken()`.

### Do it — the screen

1. **GameObject → UI (Canvas) → Text - TextMeshPro**. This creates a **Canvas**
   and an **EventSystem** too. Rename the text `Hole Text`.
2. Select **Canvas**: in its **Canvas Scaler**, set **UI Scale Mode** to **Scale
   With Screen Size**, **Reference Resolution** to `1920 × 1080`, and **Match** to
   `0.5`.
3. Make three more texts on the Canvas, and set all four like this (white text).
   As in Level 1, hold **Shift + Alt** (**Shift + Option** on Mac) when you click
   an anchor preset, so the pivot and the position move to that corner too:

| Object | Anchor | Pos | Size | Font Size | Alignment |
| --- | --- | --- | --- | --- | --- |
| `Hole Text` | top-left | (40, −20) | 900 × 70 | 48 | left, middle |
| `Strokes Text` | top-center | (0, −20) | 500 × 70 | 48 | centre, middle |
| `Power Text` | bottom-center | (0, 50) | 700 × 90 | 64 | centre, middle |
| `Message Text` | middle-center | (0, 180) | 1700 × 200 | 96, **Bold** | centre, middle |

4. On each of the four texts, open **Extra Settings** at the bottom of the
   **TextMeshPro - Text (UI)** component and untick **Raycast Target**. A UI
   element with Raycast Target ticked catches presses, like a button does, even
   when it's an empty text: Chapter 12 shows why that matters. These texts are
   only there to be read.
5. Delete the "New Text" in `Power Text` and `Message Text`, so they start empty.

> **Tip:** white text is hard to read on the bright course. Add an **Image**
> (**GameObject → UI (Canvas) → Image**) called `Top Bar`: anchor it to stretch
> across the top (hold **Alt** / **Option** in the anchor presets), set its
> **Height** to 110 and its colour to a dark grey, `#38383D`, with some
> transparency, and untick its **Raycast Target**. Move it to the top of the
> Canvas's children, so the texts draw on top of it.

### Do it — the game manager

Create `GolfGame` and attach it to a new empty GameObject called `Golf Game`:

```csharp
using TMPro;
using UnityEngine;

// Runs the game: the strokes, the words on screen, and what happens when the
// ball drops into the cup.
public class GolfGame : MonoBehaviour
{
    [SerializeField] GolfBall ball;
    [SerializeField] int par = 2;
    [SerializeField] TMP_Text holeText;
    [SerializeField] TMP_Text strokesText;
    [SerializeField] TMP_Text powerText;
    [SerializeField] TMP_Text messageText;

    int strokes = 0;
    bool holeFinished = false;

    public bool CanShoot
    {
        get { return !holeFinished && !ball.IsMoving; }
    }

    void Start()
    {
        messageText.text = "";
        powerText.text = "";
        UpdateScreen();
    }

    public void StrokeTaken()
    {
        strokes++;
        UpdateScreen();
    }

    public void BallInCup()
    {
        if (holeFinished)
        {
            return;
        }
        holeFinished = true;
        ball.Stop();
        ball.gameObject.SetActive(false);
        messageText.text = "In the hole in " + strokes + "!";
    }

    public void ShowPower(float power)
    {
        if (power > 0f)
        {
            powerText.text = "Power " + Mathf.RoundToInt(power * 100) + "%";
        }
        else
        {
            powerText.text = "";
        }
    }

    void UpdateScreen()
    {
        holeText.text = "Hole 1    Par " + par;
        strokesText.text = "Strokes: " + strokes;
    }
}
```

Read it before you move on:

- `CanShoot` is a property with only a `get`: "the hole isn't finished, and the
  ball isn't moving". The aimer asks it before every drag.
- `BallInCup` starts with a **guard**: `OnTriggerStay` fires on every physics step,
  so without `if (holeFinished) return;` the hole would finish fifty times a
  second.
- `power * 100` is a `float` like `73.4`. `Mathf.RoundToInt` turns it into the
  whole number `73`, for a tidy `"Power 73%"` ({{ref:numbers}}).
- `ball.gameObject.SetActive(false)` hides the ball: it's in the cup.

Drag `Ball` and the four texts into the fields.

### Do it — the cup

1. Right-click `Hole 1` → **Create Empty**, name it `Cup`, and set its **Position**
   to `(0, 0.098, 4)`: the middle of the hole, at the height of the ball's centre.
2. A new child takes its parent's layer, so the cup is on the `Course` layer. Set
   its **Layer** back to **Default**: the aim line stops at anything on the
   `Course` layer, and a cup isn't a wall.
3. **Add Component → Sphere Collider**: tick **Is Trigger**, **Radius** `0.03`.
4. Create the `Cup` script and attach it. Then drag `Golf Game` into its **Game**
   field:

```csharp:Cup.cs
using UnityEngine;

// A trigger in the cup. A ball that's slow enough while it's inside has
// dropped in; a fast one rolls over the hole and carries on.
public class Cup : MonoBehaviour
{
    [SerializeField] GolfGame game;
    [SerializeField] float sinkSpeed = 1f;

    void OnTriggerStay(Collider other)
    {
        if (other.TryGetComponent(out GolfBall ball) && ball.Speed < sinkSpeed)
        {
            game.BallInCup();
        }
    }
}
```

`TryGetComponent(out GolfBall ball)` ({{ref:components}}) asks whatever is inside
the trigger: "do you have a `GolfBall`?". If yes, `ball` is its `GolfBall`, and
`&&` goes on to check its speed.

### Do it — the aimer asks the game

`ShotAimer` must now ask the game before aiming, and report each stroke and the
power. In `ShotAimer`:

1. Add a field under `ball`: `[SerializeField] GolfGame game;`, and drag
   `Golf Game` into it.
2. In `Update`, change `ball.IsMoving` to `!game.CanShoot`:

```csharp
        if (pointer == null || !game.CanShoot)
        {
            return;
        }
```

3. Tell the game about the stroke, right after the putt:

```csharp
            if (shotPower > 0.05f)
            {
                ball.Shoot(shotDirection, shotPower * maxForce);
                game.StrokeTaken();
            }
```

4. Show the power: at the end of `Aim`, after `aimLine.enabled = true;`, add
   `game.ShowPower(shotPower);`. And at the end of `CancelAim`, add
   `game.ShowPower(0f);`.

### Test it

Press **Play**. The top of the screen says `Hole 1    Par 2` and `Strokes: 0`.
Drag, and `Power 45%` follows your pointer; let go and the strokes go up. Sink
the ball: it vanishes, and the message says `In the hole in 2!`. Now try a hard,
straight putt over the cup: it rolls on, just like a real one.

### Challenge

When the ball goes in with the very first stroke, show `Hole in one!` instead.
You need one `if` and one `else` in `BallInCup`.

# Part 4 — A Round of Golf

{{concept:modifiers}}

{{concept:lists}}

{{concept:dictionaries}}

## Chapter 8 — Scores and Names

**Goal:** when the ball drops, the game names the score the way golfers do (Par,
Birdie, Bogey…), and writes it on a scorecard that will hold every hole.

### Idea — golf's names for scores

Golfers compare the strokes with the hole's **par**, and every difference has a
name:

| Strokes compared with par | Name |
| --- | --- |
| 3 under (−3) | Albatross |
| 2 under (−2) | Eagle |
| 1 under (−1) | Birdie |
| the same (0) | Par |
| 1 over (+1) | Bogey |
| 2 over (+2) | Double Bogey |
| 3 over (+3) | Triple Bogey |

And sinking the ball with a single stroke, on any hole, is a **Hole in One**.

That table is a perfect **dictionary** ({{ref:dictionaries}}): the key is the
difference, an `int`, and the value is the name, a `string`.

### Idea — a static class for golf's rules

Golf's names are the same for every hole and every player. There's no reason to
make an object to hold them, so they go in a **static class**
({{ref:modifiers}}): `GolfTerms.NameFor(3, 2)` works straight from the class
name, like `Mathf.RoundToInt`. The dictionary is `static readonly`: one
dictionary for the whole game, made once, never replaced.

The class also holds a **constant** you'll use in Chapter 10: `MaxStrokes`, the
most strokes allowed on a hole before the ball is picked up.

### Idea — a plain class for one line of the scorecard

Each finished hole gives one line: the hole's number, its par and the strokes.
That's a job for a small **plain C# class** with a **constructor**
({{ref:properties}}): not a component, never on a GameObject, just made with
`new` when a hole is finished. A `List<HoleScore>` ({{ref:lists}}) then holds one
line per hole.

### Do it — the two classes

Create `GolfTerms` (you can delete the `using` lines and the `MonoBehaviour`
that Unity writes: this class isn't a component):

```csharp:GolfTerms.cs
using System.Collections.Generic;

// Golf's rules and its names for scores. A static class: there's one set of
// golf rules for the whole game, so nobody needs to make an object of it.
public static class GolfTerms
{
    public const int MaxStrokes = 8;

    static readonly Dictionary<int, string> names = new Dictionary<int, string>
    {
        { -3, "Albatross" },
        { -2, "Eagle" },
        { -1, "Birdie" },
        { 0, "Par" },
        { 1, "Bogey" },
        { 2, "Double Bogey" },
        { 3, "Triple Bogey" },
    };

    public static string NameFor(int strokes, int par)
    {
        if (strokes == 1)
        {
            return "Hole in One";
        }
        if (names.TryGetValue(strokes - par, out string name))
        {
            return name;
        }
        return "+" + (strokes - par);
    }
}
```

Then create `HoleScore`, also a plain class:

```csharp:HoleScore.cs
// One line of the scorecard. A plain C# class: not a component, never on a
// GameObject. The game makes one with `new` each time a hole is finished.
public class HoleScore
{
    public int HoleNumber { get; private set; }
    public int Par { get; private set; }
    public int Strokes { get; private set; }

    public HoleScore(int holeNumber, int par, int strokes)
    {
        HoleNumber = holeNumber;
        Par = par;
        Strokes = strokes;
    }

    // Strokes compared with par: -1 is one under par, 2 is two over.
    public int Difference
    {
        get { return Strokes - Par; }
    }

    public string Name
    {
        get { return GolfTerms.NameFor(Strokes, Par); }
    }
}
```

Read them before you move on:

- `NameFor` checks the hole in one **first**: a hole in one on a par 2 is also a
  Birdie, but "Hole in One" is the name everyone wants to hear.
- `TryGetValue` looks the difference up without any risk. Nine strokes on a par
  2 is `+7`: not in the dictionary, so the method returns `"+7"` instead of
  crashing.
- `HoleScore`'s properties have a `private set`: once a line is on the
  scorecard, nobody can change it. `Difference` and `Name` are worked out from
  the other properties whenever they're read.

### Do it — the game uses them

In `GolfGame`:

1. Add `using System.Collections.Generic;` at the top.
2. Add the scorecard, above `int strokes = 0;`:

```csharp
    readonly List<HoleScore> scorecard = new List<HoleScore>();
```

3. In `BallInCup`, replace the line that sets `messageText.text` with:

```csharp
        HoleScore score = new HoleScore(1, par, strokes);
        scorecard.Add(score);
        messageText.text = score.Name + "!";
```

The list is `readonly`: the game always keeps the same list, and adds lines to
it. We'll show the whole scorecard in Chapter 13.

### Test it

Sink the ball in two strokes: `Par!`. In three: `Bogey!`. Put it in with a
single putt (aim carefully through the windmill!) and you get `Hole in One!`.

### Challenge

Add `-4` to the dictionary: golfers call it a **Condor**. Can it ever happen on
our par-2 hole? (Think about which check in `NameFor` comes first.)

{{concept:coroutines}}

## Chapter 9 — Holes 2 and 3

**Goal:** two more holes, one around a corner and one with no walls on part of
it, a block that slides across the lane, and a `Hole` script that knows each
hole's name, par and starting point.

### Idea — a script for each hole

Each hole has its own name, par and **tee** (where the ball starts). A small
`Hole` script keeps them, as `[SerializeField]` fields you set in the Inspector,
and lets other scripts **read** them through properties: the pattern from
{{ref:modifiers}}. `TeePosition` reads the position of an empty GameObject called
`Tee`, so you can move the start in the Scene view.

### Idea — a kinematic Rigidbody

The block on hole 3 must slide back and forth, and push the ball when it's in the
way. A normal Rigidbody would fall, and fly off when the ball hit it. A
**kinematic** Rigidbody (**Is Kinematic** ticked) is different:

| | Dynamic (the ball) | Kinematic (the block) |
| --- | --- | --- |
| Moved by | physics: gravity, collisions, forces | **your code** |
| Pushed by other objects? | yes | no |
| Pushes other objects? | yes | **yes** |

A kinematic Rigidbody is moved with `MovePosition`, in `FixedUpdate`: then it
moves **during** the physics step, and pushes the ball properly on the way.

### Idea — a sine wave

`Mathf.Sin` turns a number that keeps growing into a smooth wave between −1 and
1. Feed it the time, and it swings back and forth forever:

| `Time.time × speed` | 0 | 1.57 | 3.14 | 4.71 | 6.28 |
| --- | --- | --- | --- | --- | --- |
| `Mathf.Sin(…)` | 0 | 1 | 0 | −1 | 0 |

Multiply the wave by how far the block travels, add it to the middle position,
and the block glides from one side to the other, slowing down at each end like a
pendulum.

### Do it — the Hole script

Create `Hole`:

```csharp:Hole.cs
using UnityEngine;

// One hole of the course. It lives on the hole's parent object, and knows the
// hole's name, its par, and where the ball starts.
public class Hole : MonoBehaviour
{
    [SerializeField] string holeName = "New Hole";
    [SerializeField] int par = 2;
    [SerializeField] Transform tee;

    public string HoleName
    {
        get { return holeName; }
    }

    public int Par
    {
        get { return par; }
    }

    public Vector3 TeePosition
    {
        get { return tee.position; }
    }
}
```

1. Right-click `Hole 1` → **Create Empty**, name it `Tee`, **Position**
   `(0, 0.1, 0)`: where the ball starts.
2. Add the `Hole` script to `Hole 1`: **Hole Name** `The Windmill`, **Par** `2`,
   and drag `Tee` into **Tee**.

### Do it — Hole 2: Around the Corner

1. Create an empty `Hole 2` at **Position** `(3, 0, 0)`, with these tiles as
   children:

| Model | Position | Rotation |
| --- | --- | --- |
| `end` | (0, 0, 0) | (0, 180, 0) |
| `straight` | (0, 0, 1) | (0, 0, 0) |
| `corner` | (0, 0, 2) | (0, 0, 0) |
| `straight` | (1, 0, 2) | (0, 90, 0) |
| `obstacle-block` | (2, 0, 2) | (0, 90, 0) |
| `hole-square` | (3, 0, 2) | (0, 90, 0) |
| `flag-blue` | (3, 0.032, 2) | (0, -40, 0) |

2. Its colliders, under a child called `Colliders`:

| Name | Position | Box Collider Size |
| --- | --- | --- |
| `Floor` | (1.5, 0.0315, 1) | (4, 0.063, 3) |
| `Left Wall` | (-0.45, 0.0735, 1) | (0.1, 0.147, 3) |
| `Top Wall` | (1.5, 0.0735, 2.45) | (4, 0.147, 0.1) |
| `Inner Wall A` | (0.45, 0.0735, 0.5) | (0.1, 0.147, 2) |
| `Inner Wall B` | (2, 0.0735, 1.55) | (3, 0.147, 0.1) |
| `Back Wall` | (0, 0.0735, -0.45) | (1, 0.147, 0.1) |
| `End Wall` | (3.45, 0.0735, 2) | (0.1, 0.147, 1) |
| `Pillar` | (2, 0.0735, 2) | (0.63, 0.147, 0.16) |

3. Set `Hole 2`'s **Layer** to `Course`, children included.
4. The cup: select the `Cup` in Hole 1, **Ctrl + D** (**Cmd + D**) to copy it, drag
   the copy onto `Hole 2`, and set its **Position** to `(3, 0.098, 2)`. The copy
   keeps its **Game** reference, and its **Default** layer.
5. A `Tee` at `(0, 0.1, 0)`, and the `Hole` script: `Around the Corner`, par `3`.

The floor is one big box under the whole L shape, even the empty corner the lane
goes round. The walls fence the ball in, so it can never reach the parts nobody
can see.

### Do it — Hole 3: Mind the Edge

1. Create an empty `Hole 3` at **Position** `(8, 0, 0)`, with these tiles:

| Model | Position | Rotation |
| --- | --- | --- |
| `end` | (0, 0, 0) | (0, 180, 0) |
| `straight` | (0, 0, 1) | (0, 0, 0) |
| `open` | (0, 0, 2) | (0, 0, 0) |
| `open` | (0, 0, 3) | (0, 0, 0) |
| `straight` | (0, 0, 4) | (0, 0, 0) |
| `hole-square` | (0, 0, 5) | (0, 0, 0) |
| `flag-green` | (0, 0.032, 5) | (0, -40, 0) |

2. Its colliders. There are no walls beside the two `open` tiles: roll too far to
   the side there, and the ball falls off the edge.

| Name | Position | Box Collider Size |
| --- | --- | --- |
| `Floor` | (0, 0.0315, 2.5) | (1, 0.063, 6) |
| `Left Wall 1` | (-0.45, 0.0735, 0.5) | (0.1, 0.147, 2) |
| `Right Wall 1` | (0.45, 0.0735, 0.5) | (0.1, 0.147, 2) |
| `Left Wall 2` | (-0.45, 0.0735, 4.5) | (0.1, 0.147, 2) |
| `Right Wall 2` | (0.45, 0.0735, 4.5) | (0.1, 0.147, 2) |
| `Back Wall` | (0, 0.0735, -0.45) | (1, 0.147, 0.1) |
| `End Wall` | (0, 0.0735, 5.45) | (1, 0.147, 0.1) |

3. Set `Hole 3`'s **Layer** to `Course`, children included. Then add a copy of the
   `Cup` at `(0, 0.098, 5)`, a `Tee` at `(0, 0.1, 0)`, and the `Hole` script:
   `Mind the Edge`, par `3`.

### Do it — the moving block

1. Right-click `Hole 3` → **3D Object → Cube**, named `Moving Block`:
   **Position** `(0, 0.103, 2.5)`, **Scale** `(0.2, 0.08, 0.1)`. The cube comes
   with its own Box Collider, and, as a child of `Hole 3`, it's on the `Course`
   layer: the aim line stops at it.
2. In `Assets/Materials`, make a material `MovingBlock` (the normal **Lit**
   shader), with the **Base Map** colour orange, `#FF7E44`, and drag it onto the
   cube.
3. **Add Component → Rigidbody**: tick **Is Kinematic**, and set **Interpolate**
   to **Interpolate**.
4. Create the `MovingBlock` script and attach it, with **Travel** `(0.3, 0, 0)`:

```csharp:MovingBlock.cs
using UnityEngine;

// A block that slides from side to side across the lane. It's a kinematic
// Rigidbody, moved by code in FixedUpdate, so the ball bounces off it properly.
[RequireComponent(typeof(Rigidbody))]
public class MovingBlock : MonoBehaviour
{
    [SerializeField] Vector3 travel = new Vector3(0.25f, 0f, 0f);   // how far it slides each way
    [SerializeField] float speed = 1.5f;                              // how fast it swings

    Rigidbody body;
    Vector3 middle;

    void Awake()
    {
        body = GetComponent<Rigidbody>();
        middle = transform.position;
    }

    void FixedUpdate()
    {
        float swing = Mathf.Sin(Time.time * speed);    // goes smoothly from -1 to 1 and back
        body.MovePosition(middle + travel * swing);
    }
}
```

`middle` is remembered once, in `Awake`, and the block swings around it:
`travel * swing` goes from `(-0.3, 0, 0)` to `(0.3, 0, 0)` and back.

### Test it

The round doesn't move from hole to hole yet: that's the next chapter. To try a
new hole now, move `Ball` to that hole's tee before you press **Play**: for hole
2, **Position** `(3, 0.1, 0)`. Play it; then try hole 3 at `(8, 0.1, 0)`, and
watch the block. Knock the ball off the open stretch: it falls, and falls, and
falls. Chapter 10 catches it.

Put `Ball` back at `(0, 0.1, 0)` when you've finished.

### Challenge

Design a **Hole 4** of your own. Look through `Assets/Models` for tiles you
haven't used (`bump`, `split`, `obstacle-triangle`, `narrow-block`…), sketch the
hole on squared paper first, then build its tiles and its colliders.

## Chapter 10 — A Round of Golf

**Goal:** the three holes played in order: the ball moves to the next tee by
itself, messages come and go, falling off the course costs a stroke, and a hole
that goes on too long is picked up.

### Idea — a list of holes

The game gets a `List<Hole>` ({{ref:lists}}) and a number, `holeIndex`, for the
hole being played. A small private property gives the current hole a name:

```csharp
Hole CurrentHole
{
    get { return holes[holeIndex]; }
}
```

Now `CurrentHole.Par` and `CurrentHole.TeePosition` always mean "this hole's". To
move on, add 1 to `holeIndex`; when it reaches `holes.Count`, the round is over.

### Idea — waiting, with coroutines

Three things in this chapter have to **wait** ({{ref:coroutines}}):

| Coroutine | Waits | Then |
| --- | --- | --- |
| `NextHole` | 2.5 seconds after the ball drops | moves the ball to the next tee, or ends the round |
| `BallOffCourse` | 1 second after the ball falls | puts the ball back where it was hit from, and adds a stroke |
| `HideMessageAfter` | a few seconds | clears the message |

### Idea — two ways to show a message

Some messages should stay ("Birdie!" stays until the next hole). Others should
go away ("Hole 2: Around the Corner" disappears after two seconds). So
`ShowMessage` gets two versions, **overloads** ({{ref:methods}}):

```csharp
ShowMessage("Birdie!");                              // stays
ShowMessage("Hole 2: Around the Corner", 2f);        // goes away after 2 seconds
```

The second one calls the first, then starts a coroutine to clear the text later.
If a new message arrives before the old one's time is up, the old coroutine must
not wipe out the new message, so `ShowMessage` stops it first with
`StopCoroutine`.

### Idea — putting the ball back

To move a Rigidbody **instantly**, set its position and stop it:

```csharp
Stop();
body.position = position;
transform.position = position;
```

`body.position` tells physics; `transform.position` moves it on screen straight
away. The ball also remembers where each putt was hit from, in
`LastShotPosition`, so the game can put it back there after a fall. And
`IsOffCourse` says whether it has fallen below the course.

### Do it — the ball

Update `GolfBall` to its final version:

```csharp:GolfBall.cs
using UnityEngine;

// The golf ball. Physics moves it; this script pushes it, notices when it has
// stopped, and puts it back on the course.
[RequireComponent(typeof(Rigidbody))]
public class GolfBall : MonoBehaviour
{
    [SerializeField] float stopSpeed = 0.15f;    // slower than this (metres per second)...
    [SerializeField] float stopDelay = 0.2f;     // ...for this long (seconds), and the ball stops
    [SerializeField] float fallLimit = -1f;      // below this height, the ball has left the course

    Rigidbody body;
    float slowTime = 0f;

    public bool IsMoving { get; private set; }
    public Vector3 LastShotPosition { get; private set; }

    // How fast the ball rolls across the course. Up-and-down movement doesn't
    // count: a ball that's only bobbing on the spot has stopped.
    public float Speed
    {
        get
        {
            Vector3 velocity = body.linearVelocity;
            velocity.y = 0f;
            return velocity.magnitude;
        }
    }

    public bool IsOffCourse
    {
        get { return transform.position.y < fallLimit; }
    }

    void Awake()
    {
        body = GetComponent<Rigidbody>();
        LastShotPosition = transform.position;
    }

    void FixedUpdate()
    {
        if (!IsMoving)
        {
            return;
        }

        if (Speed < stopSpeed)
        {
            slowTime += Time.deltaTime;
            if (slowTime >= stopDelay)
            {
                Stop();
            }
        }
        else
        {
            slowTime = 0f;
        }
    }

    public void Shoot(Vector3 direction, float force)
    {
        LastShotPosition = transform.position;
        body.AddForce(direction * force, ForceMode.Impulse);
        IsMoving = true;
        slowTime = 0f;
    }

    public void Stop()
    {
        body.linearVelocity = Vector3.zero;
        body.angularVelocity = Vector3.zero;
        IsMoving = false;
    }

    public void PlaceAt(Vector3 position)
    {
        Stop();
        body.position = position;
        transform.position = position;
    }
}
```

### Do it — the round

Replace `GolfGame` with this version. It's bigger, but every method is one of
the ideas above:

```csharp
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// Runs a round of golf: the holes in order, the strokes, the scorecard, and
// the messages that go with them.
public class GolfGame : MonoBehaviour
{
    [SerializeField] List<Hole> holes;
    [SerializeField] GolfBall ball;
    [SerializeField] TMP_Text holeText;
    [SerializeField] TMP_Text strokesText;
    [SerializeField] TMP_Text powerText;
    [SerializeField] TMP_Text messageText;

    readonly List<HoleScore> scorecard = new List<HoleScore>();
    int holeIndex = 0;
    int strokes = 0;
    bool holeFinished = false;
    bool resetting = false;
    Coroutine hideMessage;

    public bool CanShoot
    {
        get { return !holeFinished && !resetting && !ball.IsMoving; }
    }

    Hole CurrentHole
    {
        get { return holes[holeIndex]; }
    }

    void Start()
    {
        StartRound();
    }

    void Update()
    {
        if (holeFinished || resetting)
        {
            return;
        }

        if (ball.IsOffCourse)
        {
            StartCoroutine(BallOffCourse());
        }
        else if (!ball.IsMoving && strokes >= GolfTerms.MaxStrokes)
        {
            FinishHole();    // too many strokes: pick the ball up and move on
        }
    }

    public void StartRound()
    {
        scorecard.Clear();
        holeIndex = 0;
        StartHole();
    }

    void StartHole()
    {
        strokes = 0;
        holeFinished = false;
        ball.gameObject.SetActive(true);
        ball.PlaceAt(CurrentHole.TeePosition);
        UpdateScreen();
        ShowMessage("Hole " + (holeIndex + 1) + ": " + CurrentHole.HoleName, 2f);
    }

    public void StrokeTaken()
    {
        strokes++;
        UpdateScreen();
    }

    public void BallInCup()
    {
        if (holeFinished)
        {
            return;
        }
        FinishHole();
    }

    void FinishHole()
    {
        holeFinished = true;
        ball.Stop();
        ball.gameObject.SetActive(false);

        HoleScore score = new HoleScore(holeIndex + 1, CurrentHole.Par, strokes);
        scorecard.Add(score);
        ShowMessage(score.Name + "!");
        StartCoroutine(NextHole());
    }

    IEnumerator NextHole()
    {
        yield return new WaitForSeconds(2.5f);
        holeIndex++;
        if (holeIndex < holes.Count)
        {
            StartHole();
        }
        else
        {
            ShowMessage("Round complete!");
        }
    }

    IEnumerator BallOffCourse()
    {
        resetting = true;
        ShowMessage("Off the course! +1 stroke", 1.5f);
        yield return new WaitForSeconds(1f);
        strokes++;
        ball.PlaceAt(ball.LastShotPosition);
        UpdateScreen();
        resetting = false;
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

    public void ShowPower(float power)
    {
        if (power > 0f)
        {
            powerText.text = "Power " + Mathf.RoundToInt(power * 100) + "%";
        }
        else
        {
            powerText.text = "";
        }
    }

    void UpdateScreen()
    {
        holeText.text = $"Hole {holeIndex + 1} of {holes.Count}    Par {CurrentHole.Par}";
        strokesText.text = "Strokes: " + strokes;
    }
}
```

Read it before you move on:

- `Start` starts the round, and `StartHole` puts the ball on the current hole's
  tee: the `par` field is gone, because each `Hole` knows its own par now.
- `Update` watches for two problems while a hole is being played: a ball that has
  fallen off the course, and a ball that has stopped after `GolfTerms.MaxStrokes`
  strokes.
- `FinishHole` does what `BallInCup` used to do, so the "too many strokes" case
  can use it too.
- `resetting` stops `Update` from starting `BallOffCourse` again on the next
  frame, while the first one is still waiting.
- `$"Hole {holeIndex + 1} of {holes.Count}    Par {CurrentHole.Par}"`:
  `holeIndex` counts from 0, like every list, but people count holes from 1.

### Do it — connect it

Select `Golf Game`: set the **Holes** list to 3, and drag in `Hole 1`,
`Hole 2` and `Hole 3`, in that order.

### Test it

Play a whole round. Each hole starts with its name on screen for two seconds.
Sink the ball: its score appears, and 2.5 seconds later the ball is on the next
tee. On hole 3, roll off the open stretch: `Off the course! +1 stroke`, and the
ball comes back to where you hit it from. After hole 3: `Round complete!`.

Then test the limit: on any hole, putt eight times without sinking the ball. When
the eighth putt stops, the hole ends.

### Challenge

Add a fourth hole to the list: your Hole 4 from Chapter 9's challenge, or a copy
of Hole 1 moved somewhere else. Nothing in `GolfGame` needs to change. Why not?

# Part 5 — Polish

## Chapter 11 — Sound and Confetti

**Goal:** the game sounds like golf (a putt, a click off the walls, a rattle in
the cup), and confetti bursts out of the cup when the ball drops.

### Idea — sounds, the Level 1 way

Sounds work exactly as in Level 1: an **Audio Source** component plays **Audio
Clips** with `PlayOneShot`. `PlayOneShot` has an **overload** ({{ref:methods}})
with a second argument, the volume from 0 to 1:

```csharp
audioSource.PlayOneShot(wallSound);          // full volume
audioSource.PlayOneShot(wallSound, 0.3f);    // 30% volume
```

### Idea — how hard did it hit?

`OnCollisionEnter(Collision collision)` is called when the ball starts touching
something solid. The `Collision` it receives describes the crash:

| `collision.` | Gives |
| --- | --- |
| `relativeVelocity.magnitude` | how fast the two things came together: the harder the hit, the bigger |
| `GetContact(0).normal` | the direction the surface faces, where they touched |
| `gameObject` | what was hit |

The ball touches the **floor** too, every time it lands on it. The contact's
**normal** tells them apart: a floor faces up, so its normal's `y` is near 1; a
wall faces sideways, so its `y` is near 0.

### Idea — a Particle System

A **Particle System** throws out lots of small images (**particles**), each
living for a moment. Its settings are grouped into **modules**:

| Module | Controls |
| --- | --- |
| **Main** (the top section) | how long the effect lasts, whether it loops, and each particle's lifetime, speed, size, colour and gravity |
| **Emission** | how many particles, and when: a steady stream, or a **Burst** all at once |
| **Shape** | where they come from and which way they fly: a cone, a sphere, a box… |
| **Renderer** | what each particle looks like: its material |

Code only needs one line to set it off: `confetti.Play();`.

### Do it — the game's sounds

In `GolfGame`:

1. Add the fields, under `messageText`, and change the comment at the top to end
   with "the messages and sounds that go with them":

```csharp
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip puttSound;
    [SerializeField] AudioClip cupSound;
    [SerializeField] AudioClip fallSound;
    [SerializeField] AudioClip cheerSound;
```

2. Play them:
   - in `StrokeTaken`, before `UpdateScreen();`: `audioSource.PlayOneShot(puttSound);`
   - in `BallInCup`, before `FinishHole();`: `audioSource.PlayOneShot(cupSound);`
   - in `BallOffCourse`, after `resetting = true;`:
     `audioSource.PlayOneShot(fallSound);`
   - in `NextHole`, after `ShowMessage("Round complete!");`:
     `audioSource.PlayOneShot(cheerSound);`
3. Add an **Audio Source** to `Golf Game`, untick **Play On Awake**, and drag it
   and the four clips (`Putt`, `Cup`, `Fall` and `Cheer` from `Assets/Audio`) into
   the fields.

### Do it — clicks off the walls

Give `Ball` its own **Audio Source** (**Play On Awake** off), and a new script:

```csharp:BallSounds.cs
using UnityEngine;

// Plays a click when the ball hits a wall: the harder the hit, the louder.
public class BallSounds : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip wallSound;

    void OnCollisionEnter(Collision collision)
    {
        // A floor faces up (its normal's y is near 1); a wall faces sideways (near 0).
        bool hitWall = Mathf.Abs(collision.GetContact(0).normal.y) < 0.5f;
        float impact = collision.relativeVelocity.magnitude;
        if (hitWall && impact > 0.2f)
        {
            audioSource.PlayOneShot(wallSound, Mathf.Clamp01(impact / 2f));
        }
    }
}
```

Drag the Ball's Audio Source into **Audio Source**, and `Wall` into **Wall
Sound**. `Mathf.Clamp01(impact / 2f)` turns the speed of the hit into a volume: a
hit at 2 metres per second or more is full volume, a hit at 1 is half volume.

### Do it — the confetti

1. **GameObject → Effects → Particle System**, named `Confetti`. Set its
   **Rotation** to `(-90, 0, 0)`: the cone of particles points up.
2. In the **Main** section, set:
   - **Duration** `1`, and untick **Looping** and **Play On Awake**
   - **Start Lifetime**, **Start Speed** and **Start Size**: click the small arrow
     at the right of each, choose **Random Between Two Constants**, and enter
     `1.2`–`1.8`, `1.5`–`3` and `0.03`–`0.06`
   - **Start Rotation**: **Random Between Two Constants**, `0`–`360`, so the
     pieces land at every angle
   - **Start Color**: arrow → **Random Color**, then click the gradient and make it
     rainbow-bright (yellow, orange, pink, blue, green)
   - **Gravity Modifier** `0.6`, and **Simulation Space** **World**
3. **Emission**: **Rate over Time** `0`, then click **+** under **Bursts**: a
   burst at time `0` with **Count** `80`.
4. **Shape**: **Cone**, **Angle** `30`, **Radius** `0.05`.
5. **Renderer**: make a material `Confetti` in `Assets/Materials` with the shader
   **Universal Render Pipeline → Particles → Unlit**, and drag it into
   **Material**.

Then, in `GolfGame`, add a field under `ball`:
`[SerializeField] ParticleSystem confetti;`, drag `Confetti` into it, and in
`BallInCup`, after the cup sound, move the confetti to the ball and play it:

```csharp
        confetti.transform.position = ball.transform.position;
        confetti.Play();
```

### Test it

Putt: a tock. Hit a wall hard: a loud click; brush it gently: a soft one. Roll
along the floor: silence. Sink the ball: a rattle, and a fountain of confetti
from the cup. Fall off hole 3: a sad slide whistle. Finish the round: a fanfare.

### Challenge

Make a small puff of particles at the ball every time it's putted: a second
Particle System with a burst of 10 grey particles, moved to the ball in
`StrokeTaken`.

{{concept:uievents}}

## Chapter 12 — Settings

**Goal:** a **Settings** button opens a panel that pauses the game, with a volume
slider, an aim-line switch, a name box and a choice of ball colour.

### Idea — pausing with Time.timeScale

`Time.timeScale` is how fast game time runs: 1 is normal, 0 is **stopped**. At 0,
physics stops, `Time.time` stops, and every `WaitForSeconds` waits
({{ref:coroutines}}). The UI keeps working, because it doesn't use game time.
So the settings panel sets it to 0 when it opens, and back to 1 when it closes.

### Idea — a panel that only listens while it's open

The `SettingsMenu` script sits **on the panel itself**. When the panel is shown,
Unity calls its `OnEnable`, which connects the controls with `AddListener`; when
it's hidden, `OnDisable` disconnects them ({{ref:uievents}}). The panel doesn't
react to anything while it's closed, and pausing and unpausing happen in exactly
the right places.

The **Settings** button, which isn't on the panel, opens it the Level 1 way: in
its **On Click ()** list in the Inspector. Both ways of connecting UI, side by
side.

### Idea — a click on a button isn't a putt

Pressing the **Settings** button also presses the pointer, and `ShotAimer` would
start aiming! `EventSystem.current.IsPointerOverGameObject()` answers "is the
pointer over a UI element?", so the aimer can ignore presses that land on
buttons.

It counts every UI element with **Raycast Target** ticked, and that's the
default for texts and images too, empty or not. That's why you unticked it on
the texts in Chapter 7: otherwise a press on the invisible rectangle of the
`Power Text`, right below the ball, would never start a putt.

### Do it — the panel

1. **GameObject → UI (Canvas) → Panel**, named `Settings Panel`. It covers the
   whole screen; set its **Color** to black, with **Alpha** around 140, to dim the
   game behind it.
2. Right-click `Settings Panel` → **UI (Canvas) → Image**, named `Window`: anchor
   middle-center, **Width** `420`, **Height** `300`, colour `#38383D`, and
   **Scale** `(2.2, 2.2, 1)`. The standard controls are small; scaling the window
   makes all of them bigger at once.
3. Make these inside `Window`, right-clicking `Window` each time (the
   **GameObject** menu would put them straight onto the Canvas), and place them
   (anchors middle-center):

| Object | Made with | Pos | Width | Details |
| --- | --- | --- | --- | --- |
| `Title` | Text - TextMeshPro | (0, 115) | 380 | "Settings", size 30, centred |
| `Volume Label` | Text - TextMeshPro | (−110, 60) | 140 | "Volume", size 18 |
| `Volume Slider` | Slider | (60, 60) | 200 | **Value** 1 |
| `Aim Line Toggle` | Toggle | (10, 18) | 160 | its **Label**'s text: "Show the aim line", in white |
| `Name Label` | Text - TextMeshPro | (−110, −28) | 140 | "Name", size 18 |
| `Name Input` | Input Field - TextMeshPro | (60, −28) | 200 | placeholder "Your name", **Character Limit** 12 |
| `Ball Label` | Text - TextMeshPro | (−110, −72) | 140 | "Ball", size 18 |
| `Ball Dropdown` | Dropdown - TextMeshPro | (60, −72) | 200 | **Options**: `Red`, `Blue`, `Green` |
| `Close Button` | Button - TextMeshPro | (0, −120) | 160 | height 36, colour `#FF7E44`, text "Close" |

4. On the Canvas itself (not in the panel), a **Button - TextMeshPro** named
   `Settings Button`: anchor **top-right** (with Shift + Alt), **Pos** `(-30, -15)`, size
   `260 × 80`, colour `#FF7E44`, text "Settings", size 40.
5. UI lower down in the Hierarchy draws on top. Drag `Settings Button` up in the
   Hierarchy, above `Settings Panel`: then the open panel covers it.

### Do it — the aimer and the game

The settings panel needs two new things from the aimer and the game, so add them
first. Update `ShotAimer` to its final version. It gets a `ShowAimLine` property
for the toggle, and ignores presses on the UI:

```csharp:ShotAimer.cs
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

// Drag back from anywhere on the screen and let go to putt. It works the same
// with a mouse and with a finger, because it reads the Pointer.
public class ShotAimer : MonoBehaviour
{
    [SerializeField] GolfBall ball;
    [SerializeField] GolfGame game;
    [SerializeField] LineRenderer aimLine;
    [SerializeField] LayerMask wallsMask;
    [SerializeField] float maxForce = 4f;         // the push at full power
    [SerializeField] float fullDrag = 0.35f;      // a drag this big (a share of the screen's height) is full power
    [SerializeField] float lineLength = 1.2f;     // the aim line's length at full power, in metres

    Camera cam;
    bool aiming = false;
    Vector2 dragStart;
    Vector3 shotDirection;
    float shotPower;

    public bool ShowAimLine { get; set; } = true;

    void Awake()
    {
        cam = Camera.main;
        aimLine.enabled = false;
    }

    void Update()
    {
        Pointer pointer = Pointer.current;
        if (pointer == null || !game.CanShoot)
        {
            return;
        }

        if (pointer.press.wasPressedThisFrame && !EventSystem.current.IsPointerOverGameObject())
        {
            aiming = true;
            dragStart = pointer.position.ReadValue();
        }

        if (!aiming)
        {
            return;
        }

        Aim(pointer.position.ReadValue());

        if (pointer.press.wasReleasedThisFrame)
        {
            if (shotPower > 0.05f)
            {
                ball.Shoot(shotDirection, shotPower * maxForce);
                game.StrokeTaken();
            }
            CancelAim();
        }
    }

    void Aim(Vector2 pointerPosition)
    {
        // Pull back to shoot forward: the drag points the opposite way.
        Vector2 drag = dragStart - pointerPosition;
        shotPower = Mathf.Clamp01(drag.magnitude / (Screen.height * fullDrag));

        // Turn the drag on the screen into a direction on the ground, as the camera sees it.
        Vector3 forward = cam.transform.forward;
        forward.y = 0f;
        Vector3 right = cam.transform.right;
        right.y = 0f;
        shotDirection = (forward.normalized * drag.y + right.normalized * drag.x).normalized;

        // The aim line starts at the ball and stops at the first wall in the way.
        Vector3 start = ball.transform.position;
        float length = shotPower * lineLength;
        if (Physics.Raycast(start, shotDirection, out RaycastHit hit, length, wallsMask))
        {
            length = hit.distance;
        }
        aimLine.SetPosition(0, start);
        aimLine.SetPosition(1, start + shotDirection * length);
        aimLine.enabled = ShowAimLine;

        game.ShowPower(shotPower);
    }

    public void CancelAim()
    {
        aiming = false;
        shotPower = 0f;
        aimLine.enabled = false;
        game.ShowPower(0f);
    }
}
```

And in `GolfGame`:

1. Under `Coroutine hideMessage;`, add the player's name:

```csharp
    public string PlayerName { get; set; } = "Player";
```

2. In `CanShoot`, add one more condition, so nobody can putt while the game is
   paused:

```csharp
        get { return !holeFinished && !resetting && !ball.IsMoving && Time.timeScale > 0f; }
```

### Do it — the script

Create `SettingsMenu` and attach it to `Settings Panel`:

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
    [SerializeField] Toggle aimLineToggle;
    [SerializeField] TMP_InputField nameInput;
    [SerializeField] TMP_Dropdown ballDropdown;
    [SerializeField] Button closeButton;
    [SerializeField] ShotAimer aimer;
    [SerializeField] GolfGame game;
    [SerializeField] MeshFilter ballModel;
    [SerializeField] Mesh[] ballMeshes;     // in the same order as the dropdown's options

    void OnEnable()
    {
        // Show the current values, without calling the listeners.
        volumeSlider.SetValueWithoutNotify(AudioListener.volume);
        aimLineToggle.SetIsOnWithoutNotify(aimer.ShowAimLine);
        nameInput.SetTextWithoutNotify(game.PlayerName);

        volumeSlider.onValueChanged.AddListener(OnVolumeChanged);
        aimLineToggle.onValueChanged.AddListener(OnAimLineToggled);
        nameInput.onEndEdit.AddListener(OnNameEntered);
        ballDropdown.onValueChanged.AddListener(OnBallChosen);
        closeButton.onClick.AddListener(Close);

        aimer.CancelAim();
        Time.timeScale = 0f;
    }

    void OnDisable()
    {
        volumeSlider.onValueChanged.RemoveListener(OnVolumeChanged);
        aimLineToggle.onValueChanged.RemoveListener(OnAimLineToggled);
        nameInput.onEndEdit.RemoveListener(OnNameEntered);
        ballDropdown.onValueChanged.RemoveListener(OnBallChosen);
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

    void OnAimLineToggled(bool isOn)
    {
        aimer.ShowAimLine = isOn;
    }

    void OnNameEntered(string text)
    {
        if (text.Trim() != "")
        {
            game.PlayerName = text.Trim();
        }
    }

    void OnBallChosen(int index)
    {
        ballModel.sharedMesh = ballMeshes[index];
    }
}
```

Read it before you move on:

- `OnEnable` first shows the current values **quietly**, with the
  `…WithoutNotify` methods, so opening the panel doesn't call the listeners.
- Each listener's parameter matches its control: `float` for the slider, `bool`
  for the toggle, `string` for the input field, `int` for the dropdown.
- `AudioListener.volume` is a **static** property ({{ref:modifiers}}): the volume
  of the whole game, 0 to 1.
- `text.Trim()` removes spaces at both ends, so a name of only spaces is ignored.
- The dropdown gives the **index** of the chosen option; `ballMeshes[index]` is
  the mesh with the same index, so the order of the options and of the meshes
  must match.

### Do it — connect it

1. Drag the controls, `Shot Aimer` and `Golf Game` into the matching fields.
2. **Ball Model**: drag `Ball` → `Model` in (Unity picks its **Mesh Filter**).
3. **Ball Meshes**: set the size to 3. In the Project window, click the arrow on
   `ball-red` to open it, and drag the **mesh** inside it (the grey grid icon)
   into Element 0. Do the same with `ball-blue` (Element 1) and `ball-green`
   (Element 2).
4. Select `Settings Button`. In its **On Click ()** list, click **+**, drag
   `Settings Panel` into the slot, choose **GameObject → SetActive (bool)**, and
   tick the box.
5. Select `Settings Panel` and untick the checkbox beside its name, at the top of
   the Inspector: the game starts with the panel closed.

### Test it

Press **Play** and click **Settings**: the panel opens and everything stops: the
windmill, the moving block, a rolling ball. Drag the volume down and putt after
closing: quieter. Untick **Show the aim line**: you now putt blind, with only the
power meter to help. Type a name, press **Enter**. Choose **Blue**: the ball turns
blue. Close the panel: the game carries on exactly where it stopped.

### Challenge

Add a **Toggle** called "Fast camera" that switches the camera's smoothing
between 4 and 12. You'll need a public method on `CameraFollow`, because
`smoothing` is private.

## Chapter 13 — The Scorecard

**Goal:** after the last hole, a scorecard shows every hole and the total against
par, with the player's name, and **Play Again** starts a new round.

### Idea — building the scorecard's text

The scorecard is one long string, built line by line in a `foreach` loop over the
`scorecard` list ({{ref:lists}}). Each line is a `$"…"` string ending in `\n`, a
new line, and the loop adds up the strokes and the pars as it goes:

```
Scorecard: Lina

Hole 1    Par 2    2 strokes    Par
Hole 2    Par 3    2 strokes    Birdie
Hole 3    Par 3    4 strokes    Bogey

Total: 8 strokes, level par
```

### Do it — the panel

1. A second **Panel**, `Scorecard Panel`, dimmed like the first, with a `Window`
   inside it (right-click the panel → **UI (Canvas) → Image**; **Width** `560`,
   **Height** `330`, **Scale** `(2, 2, 1)`, colour `#38383D`).
2. Inside the window, right-clicking `Window`: a **Text - TextMeshPro** named `Scorecard Text` (**Pos**
   `(0, 25)`, **Width** `520`, **Height** `250`, size 20, aligned top-left), and a
   **Button - TextMeshPro** named `Play Again Button` (**Pos** `(0, -130)`, size
   `200 × 40`, colour `#61CB8B`, text "Play Again").
3. Untick `Scorecard Panel`, so it starts hidden.

### Do it — the script

`GolfGame` gets its last changes:

1. `using UnityEngine.UI;` at the top, for `Button`.
2. Three fields, under `messageText`:

```csharp
    [SerializeField] GameObject scorecardPanel;
    [SerializeField] TMP_Text scorecardText;
    [SerializeField] Button playAgainButton;
```

3. The **Play Again** button calls `StartRound`, connected in code, and
   `StartRound` hides the scorecard.
4. `NextHole` shows the scorecard at the end of the round, instead of "Round
   complete!", and a new method, `ShowScorecard`, builds it.

Here's the finished script:

```csharp:GolfGame.cs
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Runs a round of golf: the holes in order, the strokes, the scorecard, and
// the messages and sounds that go with them.
public class GolfGame : MonoBehaviour
{
    [SerializeField] List<Hole> holes;
    [SerializeField] GolfBall ball;
    [SerializeField] ParticleSystem confetti;
    [SerializeField] TMP_Text holeText;
    [SerializeField] TMP_Text strokesText;
    [SerializeField] TMP_Text powerText;
    [SerializeField] TMP_Text messageText;
    [SerializeField] GameObject scorecardPanel;
    [SerializeField] TMP_Text scorecardText;
    [SerializeField] Button playAgainButton;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip puttSound;
    [SerializeField] AudioClip cupSound;
    [SerializeField] AudioClip fallSound;
    [SerializeField] AudioClip cheerSound;

    readonly List<HoleScore> scorecard = new List<HoleScore>();
    int holeIndex = 0;
    int strokes = 0;
    bool holeFinished = false;
    bool resetting = false;
    Coroutine hideMessage;

    public string PlayerName { get; set; } = "Player";

    public bool CanShoot
    {
        get { return !holeFinished && !resetting && !ball.IsMoving && Time.timeScale > 0f; }
    }

    Hole CurrentHole
    {
        get { return holes[holeIndex]; }
    }

    void OnEnable()
    {
        playAgainButton.onClick.AddListener(StartRound);
    }

    void OnDisable()
    {
        playAgainButton.onClick.RemoveListener(StartRound);
    }

    void Start()
    {
        StartRound();
    }

    void Update()
    {
        if (holeFinished || resetting)
        {
            return;
        }

        if (ball.IsOffCourse)
        {
            StartCoroutine(BallOffCourse());
        }
        else if (!ball.IsMoving && strokes >= GolfTerms.MaxStrokes)
        {
            FinishHole();    // too many strokes: pick the ball up and move on
        }
    }

    public void StartRound()
    {
        scorecard.Clear();
        scorecardPanel.SetActive(false);
        holeIndex = 0;
        StartHole();
    }

    void StartHole()
    {
        strokes = 0;
        holeFinished = false;
        ball.gameObject.SetActive(true);
        ball.PlaceAt(CurrentHole.TeePosition);
        UpdateScreen();
        ShowMessage("Hole " + (holeIndex + 1) + ": " + CurrentHole.HoleName, 2f);
    }

    public void StrokeTaken()
    {
        strokes++;
        audioSource.PlayOneShot(puttSound);
        UpdateScreen();
    }

    public void BallInCup()
    {
        if (holeFinished)
        {
            return;
        }
        audioSource.PlayOneShot(cupSound);
        confetti.transform.position = ball.transform.position;
        confetti.Play();
        FinishHole();
    }

    void FinishHole()
    {
        holeFinished = true;
        ball.Stop();
        ball.gameObject.SetActive(false);

        HoleScore score = new HoleScore(holeIndex + 1, CurrentHole.Par, strokes);
        scorecard.Add(score);
        ShowMessage(score.Name + "!");
        StartCoroutine(NextHole());
    }

    IEnumerator NextHole()
    {
        yield return new WaitForSeconds(2.5f);
        holeIndex++;
        if (holeIndex < holes.Count)
        {
            StartHole();
        }
        else
        {
            ShowScorecard();
        }
    }

    IEnumerator BallOffCourse()
    {
        resetting = true;
        audioSource.PlayOneShot(fallSound);
        ShowMessage("Off the course! +1 stroke", 1.5f);
        yield return new WaitForSeconds(1f);
        strokes++;
        ball.PlaceAt(ball.LastShotPosition);
        UpdateScreen();
        resetting = false;
    }

    void ShowScorecard()
    {
        int totalStrokes = 0;
        int totalPar = 0;
        string lines = "";
        foreach (HoleScore score in scorecard)
        {
            lines += $"Hole {score.HoleNumber}    Par {score.Par}    {score.Strokes} strokes    {score.Name}\n";
            totalStrokes += score.Strokes;
            totalPar += score.Par;
        }

        int difference = totalStrokes - totalPar;
        string result;
        if (difference < 0)
        {
            result = -difference + " under par!";
        }
        else if (difference > 0)
        {
            result = difference + " over par";
        }
        else
        {
            result = "level par";
        }

        scorecardText.text = $"Scorecard: {PlayerName}\n\n{lines}\nTotal: {totalStrokes} strokes, {result}";
        scorecardPanel.SetActive(true);
        messageText.text = "";
        audioSource.PlayOneShot(cheerSound);
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

    public void ShowPower(float power)
    {
        if (power > 0f)
        {
            powerText.text = "Power " + Mathf.RoundToInt(power * 100) + "%";
        }
        else
        {
            powerText.text = "";
        }
    }

    void UpdateScreen()
    {
        holeText.text = $"Hole {holeIndex + 1} of {holes.Count}    Par {CurrentHole.Par}";
        strokesText.text = "Strokes: " + strokes;
    }
}
```

Read it before you move on:

- `OnEnable` and `OnDisable` connect the button to `StartRound` with
  `AddListener`, the same pattern as the settings panel ({{ref:uievents}}).
- `lines +=` adds to the end of a string: after the loop, `lines` holds one line
  per hole.
- `-difference + " under par!"`: when the total is under par, `difference` is
  negative, so `-difference` turns `-2` into `2`.
- `ShowScorecard` plays the cheer now, so `NextHole` doesn't.

Drag `Scorecard Panel`, `Scorecard Text` and `Play Again Button` into the new
fields.

### Test it

Play a full round with your name set in the settings. After hole 3, the
scorecard lists all three holes with their names, and the total. Click
**Play Again**: the scorecard disappears and the ball is back on the first tee,
at 0 strokes.

### Challenge

Keep the **best** total of the session: add a field `bestTotal` (starting at 0,
meaning "none yet"), update it in `ShowScorecard` when the new total is lower,
and add a line `Best today: N strokes` to the scorecard.

# Part 6 — Finish

{{concept:null}}

## Chapter 14 — Break It, Then Fix It

**Goal:** you can recognise the errors a broken Unity project throws, go straight
to their cause, and use a breakpoint to watch the aiming code think.

### Idea

Every programmer breaks things, every day. The difference between a beginner and
a professional is how fast they find the cause. In this chapter you break the
finished game **on purpose**, one thing at a time, read what Unity tells you,
and fix it. Do each step, then undo it before the next one.

> **Watch out:** save your scene first (**Ctrl + S** / **Cmd + S**). If anything
> goes wrong, you can always go back to the saved version.

### Do it — an empty field

1. Select `Shot Aimer`. Click its **Ball** field and press **Delete** or
   **Backspace**: it now says **None (Golf Ball)**.
2. Press **Play** and try to putt. The Console fills with:

```
UnassignedReferenceException: The variable ball of ShotAimer has not been assigned.
You probably need to assign the ball variable of the ShotAimer script in the inspector.
```

3. Click the error. Below the message, the stack trace names `ShotAimer.Aim` and
   the line, and under it `ShotAimer.Update`, the method that called `Aim`.
   Double-click the error: your editor opens `ShotAimer.cs` at the line that
   uses `ball`.
4. Stop, and drag `Ball` back into the field.

### Do it — a real null

1. In `ShotAimer`, turn the first line of `Awake` into a comment:
   `// cam = Camera.main;`. Now `cam` is never given the camera.
2. Play and drag. This time it's the plain C# error:

```
NullReferenceException: Object reference not set to an instance of an object
ShotAimer.Aim (UnityEngine.Vector2 pointerPosition) (at Assets/Scripts/ShotAimer.cs:70)
ShotAimer.Update () (at Assets/Scripts/ShotAimer.cs:50)
```

3. Line 70 is `Vector3 forward = cam.transform.forward;`. Which reference on that
   line could be `null`? Only `cam`: `transform` belongs to a camera that isn't
   there. `cam` is private and not a `[SerializeField]`, so no Inspector helps:
   it's `null` because no code gave it a value.
4. Remove the `//`.

### Do it — a destroyed object

1. Press **Play**, then select `Ball` in the Hierarchy and delete it (**Delete**,
   or **Cmd + Backspace** on Mac).
2. Errors pour in, every frame. Click **Collapse** in the Console's toolbar: each
   different error shows once, with a count. You get two:
   **MissingReferenceException**: *The object of type 'GolfBall' has been
   destroyed but you are still trying to access it*, from `GolfGame.Update`, and a
   second one about a `Transform`, from `CameraFollow.LateUpdate`.
3. Both scripts still hold a reference to the ball, which no longer exists.
   Stopping the game brings the ball back: deleting it in Play mode was only
   temporary.

### Do it — a component that can't go

Select `Ball` and try to remove its **Rigidbody** (right-click its title →
**Remove Component**). Unity refuses: the Rigidbody is needed because of
`GolfBall`'s `[RequireComponent(typeof(Rigidbody))]`. That one line prevents a
whole family of `MissingComponentException`s.

### Do it — a bug with no error at all

1. In `CameraFollow`, rename `LateUpdate` to `Lateupdate`, save, and play.
2. No error, no warning, and the camera doesn't follow the ball. Unity only calls
   event functions whose names match **exactly** ({{ref:events}}).
3. Put the capital `U` back.

### Do it — watch the aim with a breakpoint

1. Open `ShotAimer` in VS Code and click left of the line number of
   `shotPower = Mathf.Clamp01(…)` in `Aim`: a red dot.
2. **Run and Debug** (**Ctrl + Shift + D** / **Cmd + Shift + D**), choose
   **Attach to Unity**, and press ▶. If Unity asks, choose **Enable debugging
   for this session**.
3. Play, and drag in the Game view. The game freezes, and VS Code highlights the
   line.
4. Hover over `drag`: you see its `x` and `y` in pixels. Press **F10** once, then
   hover over `shotPower`: the power, between 0 and 1.
5. Press **F5** to carry on: it stops again on the next frame, because `Aim` runs
   every frame while you drag. Click the red dot to remove it, press **F5**, and
   stop debugging with **Shift + F5**.

### Test it

After undoing every break, the game works exactly as before: play a whole round
to be sure, and check that the Console has no errors.

### Challenge

Break the game in a way this chapter didn't, and swap with a classmate: each of
you must find and fix the other's bug using only the Console and a breakpoint.

## Chapter 15 — Ship It

**Goal:** a Web build of your game, published on itch.io, that works with a mouse
on a computer and with a finger on a phone.

### Idea

The game is finished; now players need it. As in Level 1, a **Web** build runs
in any browser, and itch.io hosts it for free. This time there's a bonus: the
game already understands touch, so the same link works on a phone.

### Do it — the build

1. **File → Build Profiles**. Select **Web** and click **Switch Platform**.
2. In **Scene List**, click **Add Open Scenes** if `Scenes/MiniGolf` is missing,
   and untick `Scenes/SampleScene`: a build starts with the first ticked scene, and
   that must be `Scenes/MiniGolf`.
3. Open **Player Settings**: set the **Product Name** to `Mini Golf`. Under
   **Publishing Settings**, set **Compression Format** to **Disabled**.
4. Click **Build**, create a folder called `Builds/Web`, and wait.

### Do it — publish on itch.io

1. Zip the **contents** of `Builds/Web`, so `index.html` is at the top of the
   zip.
2. On itch.io, **Upload new project**, **Kind of project: HTML**, upload the zip,
   and tick **This file will be played in the browser**.
3. Set the **Viewport dimensions** to `960 × 600`, the size of the game in a Web
   build, and tick **Mobile friendly**. Save, and open the page.

### Test it

Play the game in the browser with the mouse. Then open the same page on a phone,
turn it sideways, and putt with your finger. If something is too small to read
on the phone, that's a job for the challenge.

### Challenge

Watch a friend play without explaining anything. Where do they get stuck? Fix
the biggest problem: a message, a bigger button, an easier first hole. That's
what game designers call **playtesting**.

# Part 7 — Check Yourself

{{include:check-yourself}}
