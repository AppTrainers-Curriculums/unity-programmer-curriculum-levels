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
| 2 | C# 1 | Return types, parameters, overloading, `out` | — |
| 3 | Chapter 2 | Rotating in 3D | The windmill |
| 4 | C# 2, C# 3 | Event functions, `GetComponent` | — |
| 5 | Chapter 3 | Rigidbodies, Physics Materials, forces | The ball |
| 6 | C# 4 | Properties and constructors | — |
| 7 | Chapter 4 | `FixedUpdate`, speed | A ball that stops |
| 8 | C# 5 | Vectors | — |
| 9 | Chapter 5 | `LateUpdate`, `Lerp` | The follow camera |
| 10 | C# 6, C# 7 | Mouse and touch, raycasts | — |
| 11 | Chapter 6 | The Pointer, Line Renderers | Aim and putt |
| 12 | C# 8, C# 9 | Conversions, rounding, the Unity docs | — |
| 13 | Chapter 7 | Triggers in 3D | The cup and the strokes |
| 14 | C# 10, C# 11, C# 12 | `static`, `const`, lists, dictionaries | — |
| 15 | Chapter 8 | Plain C# classes | Scores and golf names |
| 16 | C# 13 | Coroutines and timers | — |
| 17 | Chapter 9 | Kinematic Rigidbodies | Holes 2 and 3 |
| 18 | Chapter 10 | — | A round of golf |
| 19 | Chapter 11 | Audio, particles, collisions | Sound and confetti |
| 20 | C# 14 | UI events and `AddListener` | — |
| 21 | Chapter 12 | Sliders, toggles, input fields, dropdowns | Settings |
| 22 | Chapter 13 | — | The scorecard |
| 23 | C# 15 | `null`, stack traces, breakpoints | — |
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

## C# 1 — Methods in Depth

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
vector times a number is another vector (C# 5 has more on vectors).

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

## C# 3 — Components and GetComponent

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
parameter (C# 1):

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
`FixedUpdate`" (C# 2) is for forces that push **every** step.

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
  Rigidbody, so Unity won't let anyone remove it (C# 3).
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

## C# 4 — Properties and Constructors

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
it: in `FixedUpdate` (C# 2). There, `Time.deltaTime` is the physics
step, 0.02 seconds, so adding it up measures how long the ball has been slow.

### Idea — properties for other scripts

Soon other scripts will ask the ball questions: "are you moving?", "how fast?".
The answers are **properties** (C# 4):

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

## C# 5 — Vectors

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

## Chapter 5 — The Follow Camera

**Goal:** the camera follows the ball smoothly, from above and behind, wherever
it goes.

### Idea — LateUpdate

The camera must move **after** the ball has moved in this frame; otherwise it's
always one frame behind, and the picture judders. That's what `LateUpdate` is
for: Unity calls it every frame, once every `Update` has finished
(C# 2).

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

## C# 6 — Mouse and Touch

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
| 3D | `Camera.main.ScreenPointToRay(screenPosition)` | a **ray** from the camera through the pointer (use it with a raycast: C# 7) |

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

## C# 7 — Raycasts

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

`Physics.Raycast` uses the Try pattern (C# 1). It returns `true` if the
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

In **3D**, the camera makes a ray through the pointer (C# 6), and a
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
length 1 (C# 5). Then:

```csharp
shotDirection = (forward.normalized * drag.y + right.normalized * drag.x).normalized;
```

### Idea — the aim line

A **Line Renderer** draws a line through points in the world. We give it two:
the ball, and the end of the aim. To keep the line honest, a **raycast**
(C# 7) goes from the ball along the shot direction, and if it hits a
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
  (C# 6). If there's no pointer at all, or the ball is still moving,
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

## C# 8 — Numbers and Conversions

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

## C# 9 — Reading the Unity Docs

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

Read it like any method you write (C# 1):

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
  whole number `73`, for a tidy `"Power 73%"` (C# 8).
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

`TryGetComponent(out GolfBall ball)` (C# 3) asks whatever is inside
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

## C# 10 — static, const and readonly

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

## C# 11 — Lists

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

## C# 12 — Dictionaries

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
uses the Try pattern and an `out` parameter (C# 1):

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

That table is a perfect **dictionary** (C# 12): the key is the
difference, an `int`, and the value is the name, a `string`.

### Idea — a static class for golf's rules

Golf's names are the same for every hole and every player. There's no reason to
make an object to hold them, so they go in a **static class**
(C# 10): `GolfTerms.NameFor(3, 2)` works straight from the class
name, like `Mathf.RoundToInt`. The dictionary is `static readonly`: one
dictionary for the whole game, made once, never replaced.

The class also holds a **constant** you'll use in Chapter 10: `MaxStrokes`, the
most strokes allowed on a hole before the ball is picked up.

### Idea — a plain class for one line of the scorecard

Each finished hole gives one line: the hole's number, its par and the strokes.
That's a job for a small **plain C# class** with a **constructor**
(C# 4): not a component, never on a GameObject, just made with
`new` when a hole is finished. A `List<HoleScore>` (C# 11) then holds one
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

## C# 13 — Coroutines and Timers

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

## Chapter 9 — Holes 2 and 3

**Goal:** two more holes, one around a corner and one with no walls on part of
it, a block that slides across the lane, and a `Hole` script that knows each
hole's name, par and starting point.

### Idea — a script for each hole

Each hole has its own name, par and **tee** (where the ball starts). A small
`Hole` script keeps them, as `[SerializeField]` fields you set in the Inspector,
and lets other scripts **read** them through properties: the pattern from
C# 10. `TeePosition` reads the position of an empty GameObject called
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

The game gets a `List<Hole>` (C# 11) and a number, `holeIndex`, for the
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

Three things in this chapter have to **wait** (C# 13):

| Coroutine | Waits | Then |
| --- | --- | --- |
| `NextHole` | 2.5 seconds after the ball drops | moves the ball to the next tee, or ends the round |
| `BallOffCourse` | 1 second after the ball falls | puts the ball back where it was hit from, and adds a stroke |
| `HideMessageAfter` | a few seconds | clears the message |

### Idea — two ways to show a message

Some messages should stay ("Birdie!" stays until the next hole). Others should
go away ("Hole 2: Around the Corner" disappears after two seconds). So
`ShowMessage` gets two versions, **overloads** (C# 1):

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
Clips** with `PlayOneShot`. `PlayOneShot` has an **overload** (C# 1)
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

## Chapter 12 — Settings

**Goal:** a **Settings** button opens a panel that pauses the game, with a volume
slider, an aim-line switch, a name box and a choice of ball colour.

### Idea — pausing with Time.timeScale

`Time.timeScale` is how fast game time runs: 1 is normal, 0 is **stopped**. At 0,
physics stops, `Time.time` stops, and every `WaitForSeconds` waits
(C# 13). The UI keeps working, because it doesn't use game time.
So the settings panel sets it to 0 when it opens, and back to 1 when it closes.

### Idea — a panel that only listens while it's open

The `SettingsMenu` script sits **on the panel itself**. When the panel is shown,
Unity calls its `OnEnable`, which connects the controls with `AddListener`; when
it's hidden, `OnDisable` disconnects them (C# 14). The panel doesn't
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
- `AudioListener.volume` is a **static** property (C# 10): the volume
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
`scorecard` list (C# 11). Each line is a `$"…"` string ending in `\n`, a
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
  `AddListener`, the same pattern as the settings panel (C# 14).
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
   event functions whose names match **exactly** (C# 2).
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
