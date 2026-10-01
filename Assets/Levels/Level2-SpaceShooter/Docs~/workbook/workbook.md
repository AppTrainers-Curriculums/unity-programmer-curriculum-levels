---
title: "Space Shooter"
subtitle: "Level 2: Builder"
author: "Unity Programmer Curriculum  ·  Level 2"
coverEyebrow: "Level 2 · Builder · Learn to Code · Make Games"
coverTop: "Space"
coverRed: "Shooter"
coverSub: "A 2D shooter with five waves of enemies, power-ups, explosions, a start screen, settings, and controls that work with a finger on a phone."
coverPill: "Level 2 Workbook · Space Shooter"
coverCaption: "11 scripts · 5 waves · 1 game you can play with a finger"
coverArt: image
coverImage: cover.png
footer: "Space Shooter  ·  Level 2 Workbook"
---

# Part 0 — Before You Start

## What you're going to build

A **2D space shooter**. Your ship flies at the bottom of the screen, and the
enemies come down from the top in five waves:

| Wave | Name | What's coming |
| --- | --- | --- |
| 1 | Scouts | 8 fast little ships: one hit each |
| 2 | Meteor Shower | 10 spinning meteors: slow, but it takes three hits to break one |
| 3 | Zigzag Squadron | 8 ships that sway from side to side: two hits each |
| 4 | Gunships | 5 big ships that shoot back when you fly underneath them |
| 5 | Everything! | 16 of all four kinds, mixed up |

**How to play:** fly with the arrow keys or **W A S D**, and hold **Space** to
fire. On a phone, put your finger down and move it around: the ship follows it,
flying a little above your finger so you can still see it, and fires while your
finger is down. A mouse works the same way.

You have three lives. Anything that hits you costs one: an enemy's laser, or the
enemy itself. Some enemies drop a **power-up** when they explode: a **shield**
that takes a hit for you, **triple shot**, or **rapid fire**. A start screen
waits for **Play**, and the end screen shows your score and how many of each
enemy you destroyed. There's also a settings panel for the volume, the screen
shake, your pilot name and the colour of your ship.

## Level 2 has three books

Level 2 has three games, each with its own book: **Mini Golf** (in 3D),
**Space Shooter** (this one, in 2D) and **Tank Arena** (also in 2D). Every book
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
| 1 | Chapter 1 | Pixels Per Unit, tiled sprites, `Mathf.Repeat` | The starfield |
| 2 | C# 1 | Vectors | — |
| 3 | Chapter 2 | Keys to a direction, `Mathf.Clamp` | The ship |
| 4 | C# 2, C# 3 | Return types, parameters, overloading, `out`; conversions | — |
| 5 | Chapter 3 | Rotations, cooldowns | Lasers |
| 6 | C# 4, C# 5 | Event functions, `GetComponent` | — |
| 7 | Chapter 4 | Body types, triggers, `MovePosition` | Enemies |
| 8 | C# 6, C# 7 | The Unity docs, coroutines and timers | — |
| 9 | Chapter 5 | `Random.Range`, font assets | The spawner and the score |
| 10 | C# 8, C# 9, C# 10 | Properties, constructors, `static`, `const`, `readonly`, lists | — |
| 11 | Chapter 6 | Plain C# classes, static counters | Waves |
| 12 | C# 11 | Mouse and touch | — |
| 13 | Chapter 7 | The Pointer, the Device Simulator | Touch controls |
| 14 | C# 12 | Raycasts | — |
| 15 | Chapter 8 | 2D raycasts, layers | The gunship |
| 16 | C# 13, C# 14 | Dictionaries, UI events | — |
| 17 | Chapter 9 | `AddListener`, game states | Start and game over |
| 18 | Chapter 10 | Public enums (`PowerUp.Kind`), particles | Power-ups and explosions |
| 19 | Chapter 11 | Audio, overloads, `LateUpdate` | Sound and shake |
| 20 | Chapter 12 | Sliders, toggles, input fields, dropdowns | Settings |
| 21 | C# 15 | `null`, stack traces, breakpoints | — |
| 22 | Chapter 13 | Debugging | Break it, then fix it |
| 23 | Chapter 14 | Builds, testing touch | A game you can share |
| 24 | Part 6 | Exam-style practice | — |

## For trainers: running a session

Sessions follow the route above, with the same rhythm as Levels 0 and 1:

| Share | Activity | From |
| --- | --- | --- |
| About 20% | **Concept:** teach the idea. Students predict each example's Console output before you run it. | C# Concept chapters |
| About 60% | **Build:** students follow the chapter in Unity and press Play at every checkpoint. | Build chapters |
| About 20% | **Practice:** the **Do it** exercises, in class or as homework. | C# Concept chapters |

Students join Level 2 by passing the **Level 2 entry test** (the Level 2 entry
test papers in the course project; the answer key is a separate trainer-only
file). Chapters 6 and 9 are the heart of this book: the waves, and the game
that ties them together from the start screen to the end screen, so give them
the most time. Part 6 rehearses the question styles of the **Unity Certified
User: Programmer** exam, which students sit at the end of Level 3.

Your trainer project has a finished version of the game, and a menu item that
builds its scene from scratch (**Tools → Space Shooter (Level 2) → Build
Scene**): use it to show the goal on the first day, or to rescue a scene that's
beyond repair.

## The pieces we'll build

Eleven scripts:

```
ScrollingBackground ── slides the starry background down the screen, for ever
PlayerShip ─────────── flies, fires, collects power-ups, blinks when it's hit
Laser ──────────────── flies straight ahead, and hurts what it hits
Enemy ──────────────── falls, sways, spins, takes hits, explodes
EnemyGun ───────────── lets a gunship shoot when the player is right below it
PowerUp ────────────── a shield, triple shot or rapid fire, drifting down
WaveSpawner ────────── sends the waves of enemies, one after another
ShooterGame ────────── runs the game: score, lives, messages, start and end screens
CameraShake ────────── shakes the camera when something explodes
SettingsMenu ───────── the settings panel: volume, shake, name, ship colour

Wave ───────────────── one wave: its name, its enemies, how many (a plain C# class)
```

## New words for Level 2

| Word | What it means |
| --- | --- |
| **Pixels Per Unit** | How many pixels of a sprite make one unit of the world. At 100, a 100-pixel sprite is 1 unit across. |
| **Body Type** | How physics treats a Rigidbody 2D: **Dynamic** (physics moves it), **Kinematic** (only your code moves it) or **Static** (it never moves). |
| **Layer** | A group a GameObject belongs to, used to choose what physics and raycasts can touch. |
| **Raycast** | An invisible line shot from a point in a direction, which reports the first collider it hits. |
| **Coroutine** | A method that can pause and carry on later. |
| **Font Asset** | A font turned into something TextMeshPro can draw. |
| **Particle System** | A component that throws out lots of tiny images: sparks, smoke, explosions. |

## One-time project setup

- **Unity 6**, with a new project created from the **Universal 2D** template.
- **Input:** a new Unity 6 project reads the keyboard, the mouse and the
  touchscreen with the **Input System** package, and that's what this book uses.
  There's nothing to set up.
- **Art:** the ships, lasers, meteors and power-ups come from Kenney's **Space
  Shooter** pack (the Remastered edition), free to use for anything
  (www.kenney.nl). Your trainer shares a folder of the sprites this book uses, and
  Kenney's font, `kenvector_future.ttf`. If you download the pack yourself, the
  sprites are in its `PNG` folder (the background, `darkPurple`, is in
  `Backgrounds`), and the font is in `Bonus`.
- **Sound:** your trainer shares seven sounds from the same pack's `Bonus`
  folder, all starting with `sfx_`. You'll need them in Chapter 11.
- Scripts live in `Assets/Scripts`, sprites in `Assets/Sprites`, fonts in
  `Assets/Fonts`, sounds in `Assets/Audio`, prefabs in `Assets/Prefabs`, and
  materials in `Assets/Materials`.

# Part 1 — Take Off

## Chapter 1 — The Starfield

**Goal:** a 2D scene with Kenney's sprites, and a starry background that slides
down the screen for ever, as if your ship were flying up through space.

### Idea — how big is a sprite?

A sprite's size in the world comes from its **Pixels Per Unit**: how many of its
pixels make one unit. Kenney's sprites use the default, 100:

| Sprite | Pixels | Units in the world |
| --- | --- | --- |
| `playerShip1_blue`, your ship | 99 × 75 | 0.99 × 0.75 |
| `enemyBlack1`, a scout | 93 × 84 | 0.93 × 0.84 |
| `laserBlue01`, a laser | 9 × 54 | 0.09 × 0.54 |
| `darkPurple`, the background | 256 × 256 | 2.56 × 2.56 |

The camera's **Size** is half the height it sees. With Size 5, the screen shows
10 units from bottom to top, from `y = -5` to `y = 5`. A 16:9 screen is about
17.8 units wide, from `x = -8.9` to `x = 8.9`.

### Idea — a background that never ends

The background is one small square, 2.56 units across, repeated like floor
tiles. A **Sprite Renderer** can do the repeating for you: set its **Draw Mode**
to **Tiled** and give it a **Size**, and it fills that size with copies of the
sprite.

To make the ship seem to fly up, the background slides **down**. When it has
moved exactly one tile, it looks exactly as it did at the start, so it can jump
back up by one tile and nobody can tell. `Mathf.Repeat(t, length)` does the
counting: it counts up like `t`, but starts again from 0 every time it reaches
`length`:

| `t` | 0 | 1 | 2 | 2.56 | 3 | 5 | 5.12 | 6 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- |
| `Mathf.Repeat(t, 2.56f)` | 0 | 1 | 2 | 0 | 0.44 | 2.44 | 0 | 0.88 |

### Do it — the project and the scene

1. In **Unity Hub**, create a new project from the **Universal 2D** template.
2. The template opens a scene called `SampleScene`, with a **Main Camera** and a
   **Global Light 2D**, which lights the sprites. **File → Save As**
   `Assets/Scenes/SpaceShooter.unity`.
3. In the **Project** window, create the folders `Sprites`, `Fonts`, `Audio`,
   `Scripts`, `Prefabs` and `Materials` inside `Assets`.
4. Copy the sprites into `Assets/Sprites`, the font into `Assets/Fonts`, and the
   seven sounds into `Assets/Audio`.

### Do it — the camera

Select **Main Camera**. In its **Camera** component, check that **Projection** is
**Orthographic** and **Size** is `5`. Under **Environment**, set **Background
Type** to **Solid Color** and the **Background** colour to a very dark blue,
`#0B0B1A`.

### Do it — the background

1. Select `darkPurple` in `Assets/Sprites`. In the Inspector, set **Mesh Type**
   to **Full Rect**, and click **Apply**. Tiling needs the sprite's whole square;
   the default, **Tight**, trims a sprite to the outline of its drawing.
2. Drag `darkPurple` into the Hierarchy. Rename it `Background`, and set its
   **Position** to `(0, 0, 0)`.
3. In its **Sprite Renderer**, set **Draw Mode** to **Tiled**, **Size** to
   `25.6 × 15.36` (10 tiles across and 6 up), and **Order in Layer** to `-10`, so
   everything else draws in front of it.

Why so big? The screen is 10 units tall, and a phone on its side is up to about
22 units wide. The background must still cover all of that after sliding down a
whole tile. Its top edge starts at 7.68 (half of 15.36), and never gets lower
than 7.68 − 2.56 = 5.12: still above the top of the screen, at 5. And 25.6 units
across is wider than any screen.

### Do it — the script

Create `ScrollingBackground` in `Assets/Scripts` and attach it to `Background`:

```csharp:ScrollingBackground.cs
using UnityEngine;

// Slides the tiled space background down the screen, for ever, so the ship
// seems to fly forwards.
public class ScrollingBackground : MonoBehaviour
{
    [SerializeField] float speed = 1f;            // units per second
    [SerializeField] float tileHeight = 2.56f;    // the height of one tile of the background

    float startY;

    void Start()
    {
        startY = transform.position.y;
    }

    void Update()
    {
        // Mathf.Repeat counts up to tileHeight, then starts again from 0.
        // One tile lower looks exactly the same, so the jump back can't be seen.
        float offset = Mathf.Repeat(Time.time * speed, tileHeight);
        transform.position = new Vector3(transform.position.x, startY - offset, transform.position.z);
    }
}
```

Read it before you move on:

- `startY` remembers, in `Start`, the height the background started at.
- `Time.time` counts the seconds since you pressed Play. Times `speed`, it's how
  far the background has travelled in total. `Mathf.Repeat` turns that into how
  far it is into the current tile.
- Every frame, the background moves to `startY - offset`: a little lower each
  time, then one tile back up.
- `tileHeight` is 2.56, the height of one `darkPurple` tile. It must match
  exactly, or the jump shows.

### Test it

Press **Play**. The stars slide down, smoothly and for ever. Watch closely: can
you spot the moment the background jumps back up? You shouldn't be able to.

### Challenge

Set **Tile Height** to `2` and play again: now you can see the jump. Why? Set it
back to `2.56`. Then try a few values for **Speed**, and keep the one you like.

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

## Chapter 2 — The Ship

**Goal:** your ship flies around the lower part of the screen with the arrow keys
or **W A S D**, as fast diagonally as straight, and never off the screen.

### Idea — from keys to a direction

Each key held down adds to a `Vector2`: **left** takes 1 away from `x` and
**right** adds 1; **down** takes 1 away from `y` and **up** adds 1. Hold nothing
and the direction is `(0, 0)`; hold right and up and it's `(1, 1)`.

`(1, 1)` is 1.41 units long, though (C# 1), so flying diagonally would
be 41% faster than flying straight. `.normalized` keeps the direction and makes
it exactly 1 long. Normalizing `(0, 0)` gives `(0, 0)`, so standing still still
works.

### Idea — keeping the ship on the screen

`Mathf.Clamp(value, min, max)` gives back `value`, pushed into the range: below
`min` it gives `min`, and above `max` it gives `max`.

| Code | Result |
| --- | --- |
| `Mathf.Clamp(3f, -8.2f, 8.2f)` | `3` |
| `Mathf.Clamp(9.5f, -8.2f, 8.2f)` | `8.2` |
| `Mathf.Clamp(-6f, -4.4f, 1f)` | `-4.4` |

Clamp `x` and `y` separately, and the ship stays inside a box. Ours goes from
`(-8.2, -4.4)` to `(8.2, 1)`: the whole width of the screen, but only its lower
part. The top of the screen belongs to the enemies.

### Idea — no keyboard?

`Keyboard.current` is the keyboard. A phone may have no keyboard at all, and then
`Keyboard.current` is `null`: nothing. Using nothing is an error (C# 15
tells the whole story), so the script checks first: `if (keyboard != null)`.

### Do it

1. Drag `playerShip1_blue` into the Hierarchy. Rename it `Player Ship`, set its
   **Position** to `(0, -3.5, 0)`, and its **Order in Layer** to `1`.
2. Create `PlayerShip` and attach it to `Player Ship`:

```csharp
using UnityEngine;
using UnityEngine.InputSystem;

// The player's ship. For now, it flies with the arrow keys or W A S D.
public class PlayerShip : MonoBehaviour
{
    [SerializeField] float speed = 8f;
    [SerializeField] Vector2 minPosition = new Vector2(-8.2f, -4.4f);
    [SerializeField] Vector2 maxPosition = new Vector2(8.2f, 1f);

    void Update()
    {
        // The keyboard: arrows or W A S D. A phone may have no keyboard at all,
        // and then Keyboard.current is null.
        Vector2 direction = Vector2.zero;
        Keyboard keyboard = Keyboard.current;
        if (keyboard != null)
        {
            if (keyboard.leftArrowKey.isPressed || keyboard.aKey.isPressed)
            {
                direction.x -= 1f;
            }
            if (keyboard.rightArrowKey.isPressed || keyboard.dKey.isPressed)
            {
                direction.x += 1f;
            }
            if (keyboard.downArrowKey.isPressed || keyboard.sKey.isPressed)
            {
                direction.y -= 1f;
            }
            if (keyboard.upArrowKey.isPressed || keyboard.wKey.isPressed)
            {
                direction.y += 1f;
            }
            direction = direction.normalized;
        }

        // Move, but never off the screen.
        Vector2 next = (Vector2)transform.position + direction * speed * Time.deltaTime;
        next.x = Mathf.Clamp(next.x, minPosition.x, maxPosition.x);
        next.y = Mathf.Clamp(next.y, minPosition.y, maxPosition.y);
        transform.position = next;
    }
}
```

Read it before you move on:

- `direction` starts at `(0, 0)` every frame, and each key held down adds to it.
- `(Vector2)transform.position`: the position is a `Vector3`, and the cast keeps
  its `x` and `y`. Going the other way, when you give a `Vector2` to
  `transform.position`, Unity turns it into a `Vector3` with `z = 0` for you
  (C# 1).
- `direction * speed * Time.deltaTime` is this frame's step: 8 units every
  second, whatever the frame rate.

### Test it

Press **Play**, click the Game view, and fly. Fly diagonally, then straight: the
same speed. Try to leave the screen at the sides and at the bottom. Then fly up:
the ship stops at `y = 1`, a little above the middle.

### Challenge

A **boost**: while **Left Shift** is held (`keyboard.leftShiftKey.isPressed`),
the ship flies twice as fast. Hint: work out this frame's speed in a local
variable before the move, and remember that `keyboard` can be `null`.

## C# 2 — Methods in Depth

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

## C# 3 — Numbers and Conversions

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

## Chapter 3 — Lasers

**Goal:** hold **Space**, and your ship fires blue lasers from its nose, four
every second.

### Idea — a laser that flies itself

A laser is a prefab with its own small script. It flies along `transform.up`, the
way its sprite points (C# 1), and it deletes itself after a while, so
the lasers that miss don't fly on for ever. `Destroy` has an **overload** with a
second parameter (C# 2): `Destroy(gameObject, 1.5f)` destroys the
object 1.5 seconds from now.

### Idea — turning a laser

`Instantiate(prefab, position, rotation)` takes a rotation, as a `Quaternion`.
Unity keeps rotations as quaternions; you don't need their maths, just one line:
`Quaternion.Euler(0f, 0f, angle)` is the rotation you'd type into the Inspector
as `(0, 0, angle)`. In 2D, turning around `z` is the only turn there is. Positive
angles turn anticlockwise, to the left; negative angles turn clockwise.

So `FireLaser(0f)` fires straight up, and `FireLaser(12f)` fires a little to the
left. One method with a parameter can fire in any direction.

### Idea — a cooldown

Holding **Space** for one second lasts about 60 frames: firing on every frame
would be 60 lasers a second! Instead, the ship remembers **when** it may fire
next:

```csharp
if (spaceHeld && Time.time >= nextShotTime)
{
    Fire();    // Fire sets nextShotTime = Time.time + 1f / shotsPerSecond
}
```

With `shotsPerSecond` at 4, `1f / shotsPerSecond` is 0.25: a quarter of a second
between two shots. It's a `float` division because `shotsPerSecond` is a
`float`; if both were `int`s, `1 / 4` would be `0` (C# 3).

### Do it — the laser prefab

1. Drag `laserBlue01` into the Hierarchy, and rename it `Player Laser`.
2. Create `Laser` and attach it to `Player Laser`:

```csharp
using UnityEngine;

// A laser bolt. It flies straight ahead at a fixed speed, then disappears.
public class Laser : MonoBehaviour
{
    [SerializeField] float speed = 12f;
    [SerializeField] float lifetime = 1.5f;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    void Update()
    {
        // transform.up is the way the laser's sprite points
        transform.position += transform.up * speed * Time.deltaTime;
    }
}
```

3. Drag `Player Laser` from the Hierarchy into `Assets/Prefabs`, then delete it
   from the Hierarchy.

### Do it — the muzzle

The lasers should come out of the ship's nose, not its middle. Right-click
`Player Ship` → **Create Empty**, rename it `Muzzle`, and set its **Position** to
`(0, 0.5, 0)`. As a child of the ship, it goes wherever the ship goes.

### Do it — firing

Replace `PlayerShip` with this version:

```csharp
using UnityEngine;
using UnityEngine.InputSystem;

// The player's ship. It flies with the arrow keys or W A S D, and fires lasers
// while Space is held.
public class PlayerShip : MonoBehaviour
{
    [SerializeField] GameObject laserPrefab;
    [SerializeField] Transform muzzle;
    [SerializeField] float speed = 8f;
    [SerializeField] float shotsPerSecond = 4f;
    [SerializeField] Vector2 minPosition = new Vector2(-8.2f, -4.4f);
    [SerializeField] Vector2 maxPosition = new Vector2(8.2f, 1f);

    float nextShotTime = 0f;

    void Update()
    {
        // The keyboard: arrows or W A S D, and Space to fire. A phone may have
        // no keyboard at all, and then Keyboard.current is null.
        Vector2 direction = Vector2.zero;
        bool spaceHeld = false;
        Keyboard keyboard = Keyboard.current;
        if (keyboard != null)
        {
            if (keyboard.leftArrowKey.isPressed || keyboard.aKey.isPressed)
            {
                direction.x -= 1f;
            }
            if (keyboard.rightArrowKey.isPressed || keyboard.dKey.isPressed)
            {
                direction.x += 1f;
            }
            if (keyboard.downArrowKey.isPressed || keyboard.sKey.isPressed)
            {
                direction.y -= 1f;
            }
            if (keyboard.upArrowKey.isPressed || keyboard.wKey.isPressed)
            {
                direction.y += 1f;
            }
            direction = direction.normalized;
            spaceHeld = keyboard.spaceKey.isPressed;
        }

        // Move, but never off the screen.
        Vector2 next = (Vector2)transform.position + direction * speed * Time.deltaTime;
        next.x = Mathf.Clamp(next.x, minPosition.x, maxPosition.x);
        next.y = Mathf.Clamp(next.y, minPosition.y, maxPosition.y);
        transform.position = next;

        // Fire while Space is held, but no faster than shotsPerSecond.
        if (spaceHeld && Time.time >= nextShotTime)
        {
            Fire();
        }
    }

    void Fire()
    {
        FireLaser(0f);
        nextShotTime = Time.time + 1f / shotsPerSecond;
    }

    // One laser from the muzzle, turned by angle degrees: 0 flies straight up.
    void FireLaser(float angle)
    {
        Instantiate(laserPrefab, muzzle.position, Quaternion.Euler(0f, 0f, angle));
    }
}
```

What's new:

- `spaceHeld` remembers whether Space is down, to use after the keyboard's `if`.
- `Fire` fires one laser and starts the cooldown. `FireLaser(float angle)` makes
  one laser at the muzzle, turned by `angle` degrees.

Select `Player Ship`. Drag the `Player Laser` prefab into **Laser Prefab**, and
`Muzzle` into **Muzzle**.

### Test it

Press **Play** and hold **Space**: four lasers a second stream up from the nose,
and each one disappears after 1.5 seconds. Watch the Hierarchy while you fire:
the `Player Laser(Clone)` objects come and go.

### Challenge

Make `Fire` fire **three** lasers at once, at `-12`, `0` and `12` degrees.
Chapter 10 turns that into a power-up, so put `Fire` back to one laser when
you've seen it work.

# Part 2 — Enemies

## C# 4 — Event Functions: When Unity Calls Your Code

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
parameter (C# 2):

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

## Chapter 4 — Enemies

**Goal:** enemy ships and meteors fly down the screen. One laser breaks a scout,
two break a zigzag ship, and a meteor takes three.

### Idea — which objects notice each other?

In Level 1 you learned that two colliders only report a touch when at least one
of them has a **Rigidbody 2D**. The whole rule depends on the Rigidbody's **Body
Type**:

| Body Type | What moves it | In this game |
| --- | --- | --- |
| **Dynamic** | physics: gravity, forces, velocity | the ship and the lasers |
| **Kinematic** | only your code | the enemies (and, later, the power-ups) |
| **Static** | nothing: it never moves | nothing |

A Kinematic body doesn't notice other Kinematic or Static bodies: every pair that
should notice each other needs a **Dynamic** body on at least one side. So lasers
(Dynamic) hit enemies (Kinematic), the ship (Dynamic) can crash into enemies, and
enemies flying through each other (Kinematic and Kinematic) don't notice at all.
That's exactly what we want.

All the colliders in this game are **triggers**: nothing bounces off anything.
They only report the touch, and the scripts decide what happens.

### Idea — moving with physics

Once physics owns an object, move it through its Rigidbody, on the physics clock,
in `FixedUpdate` (C# 4). Moving the Transform directly would fight the
physics.

| Rigidbody 2D | Does |
| --- | --- |
| `body.MovePosition(position)` | moves the body to `position` at the next physics step, noticing what it touches on the way |
| `body.MoveRotation(angle)` | turns it to `angle` degrees |
| `body.linearVelocity = velocity;` | sets its speed and direction; a Dynamic body then keeps going by itself |

The ship now reads the keys in `Update`, so that no key press is ever missed, and
moves in `FixedUpdate`. The direction lives in a field, `keyboardDirection`, so
both methods can use it. The lasers set their `linearVelocity` once, in `Start`,
and physics carries them from there.

### Idea — swaying and spinning

The zigzag ship sways from side to side. `Mathf.Sin` of a number that keeps
growing goes smoothly up to 1, down to −1, and back, for ever:

| `age` (seconds) | 0 | 0.79 | 1.57 | 2.36 | 3.14 |
| --- | --- | --- | --- | --- | --- |
| `Mathf.Sin(age * 2f)` | 0 | 1 | 0 | −1 | 0 |

Times `swayWidth`, 2, the ship's `x` swings from 2 units left of where it
appeared to 2 units right of it, and back, every 3.14 seconds. Meteors don't
sway; they **spin**: every physics step, `MoveRotation` turns them a little
further, 60 degrees a second.

### Idea — who did the laser hit?

When a laser's trigger touches something, Unity calls its
`OnTriggerEnter2D(Collider2D other)` with the other collider.
`other.TryGetComponent(out Enemy enemy)` asks it: "do you have an `Enemy`
script?" (C# 5). If it does, `enemy` is that script: the laser
calls `enemy.TakeDamage(damage)` and destroys itself. A laser that touches
anything else, like another laser, flies on.

### Do it — physics for the ship

1. Select `Player Ship`. **Add Component → Rigidbody 2D**, and set:
   - **Body Type** **Dynamic**, and **Gravity Scale** `0`: nothing falls in space
   - **Interpolate** **Interpolate**. Physics moves the ship 50 times a second,
     but the screen may draw 60 or 120 frames: this smooths the movement in
     between.
   - under **Constraints**, tick **Freeze Rotation Z**, so nothing can spin the
     ship
2. **Add Component → Circle Collider 2D**: tick **Is Trigger**, and set the
   **Radius** to `0.35`.
3. Replace `PlayerShip` with this version:

```csharp
using UnityEngine;
using UnityEngine.InputSystem;

// The player's ship. It flies with the arrow keys or W A S D, and fires lasers
// while Space is held. Physics moves it, so it can touch the enemies.
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerShip : MonoBehaviour
{
    [SerializeField] GameObject laserPrefab;
    [SerializeField] Transform muzzle;
    [SerializeField] float speed = 8f;
    [SerializeField] float shotsPerSecond = 4f;
    [SerializeField] Vector2 minPosition = new Vector2(-8.2f, -4.4f);
    [SerializeField] Vector2 maxPosition = new Vector2(8.2f, 1f);

    Rigidbody2D body;
    Vector2 keyboardDirection;
    float nextShotTime = 0f;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Start every frame standing still: only keys held down right now can
        // move the ship.
        keyboardDirection = Vector2.zero;

        // The keyboard: arrows or W A S D, and Space to fire. A phone may have
        // no keyboard at all, and then Keyboard.current is null.
        Keyboard keyboard = Keyboard.current;
        bool spaceHeld = false;
        if (keyboard != null)
        {
            if (keyboard.leftArrowKey.isPressed || keyboard.aKey.isPressed)
            {
                keyboardDirection.x -= 1f;
            }
            if (keyboard.rightArrowKey.isPressed || keyboard.dKey.isPressed)
            {
                keyboardDirection.x += 1f;
            }
            if (keyboard.downArrowKey.isPressed || keyboard.sKey.isPressed)
            {
                keyboardDirection.y -= 1f;
            }
            if (keyboard.upArrowKey.isPressed || keyboard.wKey.isPressed)
            {
                keyboardDirection.y += 1f;
            }
            keyboardDirection = keyboardDirection.normalized;
            spaceHeld = keyboard.spaceKey.isPressed;
        }

        // Fire while Space is held, but no faster than shotsPerSecond.
        if (spaceHeld && Time.time >= nextShotTime)
        {
            Fire();
        }
    }

    // Physics moves the ship, on the physics clock.
    void FixedUpdate()
    {
        Vector2 next = body.position + keyboardDirection * speed * Time.deltaTime;
        next.x = Mathf.Clamp(next.x, minPosition.x, maxPosition.x);
        next.y = Mathf.Clamp(next.y, minPosition.y, maxPosition.y);
        body.MovePosition(next);
    }

    void Fire()
    {
        FireLaser(0f);
        nextShotTime = Time.time + 1f / shotsPerSecond;
    }

    // One laser from the muzzle, turned by angle degrees: 0 flies straight up.
    void FireLaser(float angle)
    {
        Instantiate(laserPrefab, muzzle.position, Quaternion.Euler(0f, 0f, angle));
    }
}
```

What's new: `[RequireComponent]` and the `Rigidbody2D` found in `Awake`
(C# 5); `keyboardDirection` is now a field, set in `Update`; and
the move happens in `FixedUpdate`, through `body.position` and
`body.MovePosition`.

### Do it — the Enemy script

Create the `Enemy` script now: the lasers need it in a moment. You'll attach it
to the enemies after that.

```csharp
using UnityEngine;

// Anything the player can shoot: enemy ships and meteors. It flies down the
// screen (swaying and spinning, if you like), takes hits, and explodes.
[RequireComponent(typeof(Rigidbody2D))]
public class Enemy : MonoBehaviour
{
    [SerializeField] int maxHealth = 1;
    [SerializeField] float fallSpeed = 2.5f;
    [SerializeField] float swayWidth = 0f;        // 0 flies straight down
    [SerializeField] float swaySpeed = 2f;
    [SerializeField] float spinSpeed = 0f;        // degrees per second: meteors spin

    Rigidbody2D body;
    int health;
    float startX;
    float age = 0f;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        health = maxHealth;
        startX = transform.position.x;
    }

    void FixedUpdate()
    {
        age += Time.deltaTime;
        float x = startX + Mathf.Sin(age * swaySpeed) * swayWidth;
        float y = body.position.y - fallSpeed * Time.deltaTime;
        body.MovePosition(new Vector2(x, y));
        body.MoveRotation(body.rotation + spinSpeed * Time.deltaTime);

        if (y < -6.5f)
        {
            Destroy(gameObject);    // it flew off the bottom of the screen
        }
    }

    public void TakeDamage(int damage)
    {
        if (health <= 0)
        {
            return;    // already exploding
        }

        health -= damage;
        if (health <= 0)
        {
            Explode();
        }
    }

    void Explode()
    {
        Destroy(gameObject);
    }
}
```

Read it before you move on:

- `Awake` sets `health` to `maxHealth`, so every enemy starts unhurt, and
  remembers `startX`, where it appeared, for the sway.
- In `FixedUpdate`, `age` grows by one physics step each time. `x` sways around
  `startX`, `y` falls, and `MovePosition` goes there; `MoveRotation` spins. An
  enemy that gets below `y = -6.5`, off the bottom of the screen, destroys itself.
- `TakeDamage` starts with a guard. Two lasers can hit in the same physics step,
  and `Destroy` only happens at the end of the frame: without the guard, the
  second laser would make the enemy explode twice.
- `Explode` only destroys the enemy, for now. Chapter 5 adds points, and
  Chapter 10 an explosion.

### Do it — physics for the lasers

1. Double-click the `Player Laser` prefab to open it. **Add Component →
   Rigidbody 2D**: **Body Type** **Dynamic**, **Gravity Scale** `0`. Then **Add
   Component → Box Collider 2D**, and tick **Is Trigger**: the box sizes itself
   to the sprite.
2. Replace `Laser` with this version:

```csharp
using UnityEngine;

// A laser bolt. It flies straight ahead at a fixed speed, hurts the first enemy
// it hits, and disappears.
[RequireComponent(typeof(Rigidbody2D))]
public class Laser : MonoBehaviour
{
    [SerializeField] float speed = 12f;
    [SerializeField] float lifetime = 1.5f;
    [SerializeField] int damage = 1;

    void Start()
    {
        // transform.up is the way the laser's sprite points
        GetComponent<Rigidbody2D>().linearVelocity = transform.up * speed;
        Destroy(gameObject, lifetime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out Enemy enemy))
        {
            enemy.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
```

3. Go back to the scene with the arrow at the top-left of the Hierarchy.

### Do it — the enemies

1. Drag `enemyBlack1` into the Hierarchy and rename it `Scout`. Set its **Order in
   Layer** to `1`, then add:
   - **Rigidbody 2D**: **Body Type** **Kinematic**, **Interpolate**
     **Interpolate**
   - **Circle Collider 2D**: tick **Is Trigger**, **Radius** `0.4`
   - **Enemy**
2. Select `Scout` and press **Ctrl + D** (**Cmd + D**) twice. Change the two
   copies, and set all three like this. To change a copy's picture, drag the
   sprite into its Sprite Renderer's **Sprite** slot.

| Name | Sprite | Max Health | Fall Speed | Sway Width | Spin Speed |
| --- | --- | --- | --- | --- | --- |
| `Scout` | `enemyBlack1` | 1 | 2.5 | 0 | 0 |
| `Meteor` | `meteorBrown_big1` | 3 | 1.5 | 0 | 60 |
| `Zigzag` | `enemyBlue3` | 2 | 2 | 2 | 0 |

3. Drag all three into `Assets/Prefabs`, then delete them from the Hierarchy.

### Test it

Drag a `Scout`, a `Meteor` and a `Zigzag` from `Assets/Prefabs` into the scene,
above the top of the screen: anywhere with `y` between 6 and 10. Press **Play**.
They fly down; the meteor spins and the zigzag sways. Shoot them: the scout
breaks with one laser, the zigzag with two, the meteor with three. Let one get
past you: it disappears below the screen. When you've seen it all, delete the
test enemies from the Hierarchy: from Chapter 5, they arrive by themselves.

### Challenge

Make a fourth enemy prefab from `enemyGreen4`: slow, five hits to break, and
swaying wide and lazily (**Sway Width** `4`, **Sway Speed** `1`). What happens if
you give it a negative **Spin Speed**?

## C# 6 — Reading the Unity Docs

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

Read it like any method you write (C# 2):

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

## C# 7 — Coroutines and Timers

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

## Chapter 5 — The Spawner and the Score

**Goal:** a new enemy arrives every second from a random place along the top of
the screen, and every enemy you destroy adds its points to the score in the
top-right corner.

### Idea — a coroutine that never ends

A coroutine can run a loop that never ends, `while (true)`, as long as the loop
waits every time round (C# 7):

```csharp
IEnumerator SpawnForever()
{
    while (true)
    {
        // make one enemy
        yield return new WaitForSeconds(delay);
    }
}
```

Every lap it waits, and hands control back to Unity while it waits. Without the
`yield`, the loop would never let Unity draw another frame: the Editor would
freeze.

### Idea — Random.Range, twice

`Random.Range` has two overloads (C# 2), and their `max` works
differently. Look them up in the Scripting API (C# 6):

| Call | Gives | `max` included? |
| --- | --- | --- |
| `Random.Range(0, 3)` | an `int`: 0, 1 or 2 | no |
| `Random.Range(-7.5f, 7.5f)` | a `float`: anything from −7.5 to 7.5 | yes |

The `int` version leaves out `max` on purpose, so that
`Random.Range(0, enemyPrefabs.Length)` is always a valid index into the array.

### Idea — telling the game

Every enemy you destroy adds to the score. The score lives in one place, a new
script called `ShooterGame`, and each enemy needs a reference to it. A prefab
can't keep a reference to an object in a scene (the prefab exists before the
scene does), so the spawner hands it over: just after `Instantiate`, it calls
`enemy.GetComponent<Enemy>().SetGame(game)`.

When an enemy explodes, it calls `game.EnemyDestroyed(enemyName, points,
transform.position)`. The game only needs the points for now. Chapter 9 counts
how many of each enemy you destroyed, by name, and Chapter 10 puts an explosion
at the position.

### Idea — a score with six digits

Arcade scores always show the same number of digits. `$"{score:D6}"` pads the
score with zeros to six digits (C# 3): `0` shows as `000000`, and
`1250` as `001250`.

### Do it — the score on the screen

1. **GameObject → UI (Canvas) → Text - TextMeshPro**. The first time, Unity asks
   to import **TMP Essentials**: click **Import TMP Essentials**, then close the
   window. Unity also creates a **Canvas** and an **EventSystem**. Rename the text
   `Score Text`.
2. Select **Canvas**. In its **Canvas Scaler**, set **UI Scale Mode** to **Scale
   With Screen Size**, **Reference Resolution** to `1920 × 1080`, and **Match** to
   `0.5`.
3. Select `Score Text`. Anchor it **top-right**, holding **Shift + Alt** (**Shift
   + Option** on Mac) as in Level 1. Set **Pos** to `(-40, -25)`, **Width** `500`
   and **Height** `90`.
4. In its **TextMeshPro - Text (UI)** component, set the text to `000000`, the
   **Font Size** to `64`, and the alignment to **right** and **middle**. Open
   **Extra Settings** at the bottom and untick **Raycast Target**: this text is
   only there to be read (Chapter 7 shows why that matters).

### Do it — the font

Kenney's pack comes with a space-age font. TextMeshPro can't draw a `.ttf` file
directly: it needs a **Font Asset** made from it. (**SDF**, in its name, is the
clever way TextMeshPro stores the letters, so they stay sharp at any size.)

1. Select `kenvector_future` in `Assets/Fonts`, then **Assets → Create →
   TextMeshPro → Font Asset → SDF**. A new asset appears next to it:
   `kenvector_future SDF`.
2. Select `Score Text`, and set its **Font Asset** to `kenvector_future SDF`.

### Do it — the game

Create `ShooterGame`, and attach it to a new empty GameObject called `Shooter
Game`:

```csharp
using TMPro;
using UnityEngine;

// Runs the game. For now, it keeps the score.
public class ShooterGame : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;

    int score = 0;

    // Awake, not Start: Unity calls every Awake before any Start, so the screen
    // is ready before another script's Start can show anything on it.
    void Awake()
    {
        UpdateScreen();
    }

    public void EnemyDestroyed(string enemyName, int points, Vector3 position)
    {
        score += points;
        UpdateScreen();
    }

    void UpdateScreen()
    {
        scoreText.text = $"{score:D6}";
    }
}
```

`ShooterGame` sets up the screen in `Awake`, which Unity calls before any
`Start` (C# 4): in Chapter 6, that matters. Select `Shooter Game`, and
drag `Score Text` into **Score Text**.

### Do it — points for the enemies

Replace `Enemy` with this version:

```csharp
using UnityEngine;

// Anything the player can shoot: enemy ships and meteors. It flies down the
// screen (swaying and spinning, if you like), takes hits, and explodes.
[RequireComponent(typeof(Rigidbody2D))]
public class Enemy : MonoBehaviour
{
    [SerializeField] string enemyName = "Scout";
    [SerializeField] int maxHealth = 1;
    [SerializeField] int points = 100;
    [SerializeField] float fallSpeed = 2.5f;
    [SerializeField] float swayWidth = 0f;        // 0 flies straight down
    [SerializeField] float swaySpeed = 2f;
    [SerializeField] float spinSpeed = 0f;        // degrees per second: meteors spin

    Rigidbody2D body;
    ShooterGame game;
    int health;
    float startX;
    float age = 0f;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        health = maxHealth;
        startX = transform.position.x;
    }

    public void SetGame(ShooterGame shooterGame)
    {
        game = shooterGame;
    }

    void FixedUpdate()
    {
        age += Time.deltaTime;
        float x = startX + Mathf.Sin(age * swaySpeed) * swayWidth;
        float y = body.position.y - fallSpeed * Time.deltaTime;
        body.MovePosition(new Vector2(x, y));
        body.MoveRotation(body.rotation + spinSpeed * Time.deltaTime);

        if (y < -6.5f)
        {
            Destroy(gameObject);    // it flew off the bottom of the screen
        }
    }

    public void TakeDamage(int damage)
    {
        if (health <= 0)
        {
            return;    // already exploding
        }

        health -= damage;
        if (health <= 0)
        {
            Explode();
        }
    }

    void Explode()
    {
        game.EnemyDestroyed(enemyName, points, transform.position);
        Destroy(gameObject);
    }
}
```

What's new: two fields, `enemyName` and `points`; a reference to the game, with
`SetGame` to fill it in; and `Explode` tells the game before the enemy goes.
Open each enemy prefab and set its new fields:

| Prefab | Enemy Name | Points |
| --- | --- | --- |
| `Scout` | `Scout` | 100 |
| `Meteor` | `Meteor` | 50 |
| `Zigzag` | `Zigzag` | 150 |

### Do it — the spawner

1. Create `WaveSpawner`. It's called that because, in Chapter 6, it will send the
   enemies in waves.

```csharp
using System.Collections;
using UnityEngine;

// Sends enemies down the screen, one after another, for ever: a random kind of
// enemy, from a random place along the top.
public class WaveSpawner : MonoBehaviour
{
    [SerializeField] ShooterGame game;
    [SerializeField] GameObject[] enemyPrefabs;
    [SerializeField] float delay = 1f;            // seconds between two enemies
    [SerializeField] float spawnWidth = 7.5f;     // enemies appear between -7.5 and 7.5...
    [SerializeField] float spawnHeight = 6f;      // ...just above the top of the screen

    void Start()
    {
        StartCoroutine(SpawnForever());
    }

    IEnumerator SpawnForever()
    {
        while (true)
        {
            Spawn(enemyPrefabs[Random.Range(0, enemyPrefabs.Length)]);
            yield return new WaitForSeconds(delay);
        }
    }

    void Spawn(GameObject prefab)
    {
        Vector3 position = new Vector3(Random.Range(-spawnWidth, spawnWidth), spawnHeight, 0f);
        GameObject enemy = Instantiate(prefab, position, Quaternion.identity, transform);
        enemy.GetComponent<Enemy>().SetGame(game);
    }
}
```

2. **GameObject → Create Empty**, named `Wave Spawner`, at **Position**
   `(0, 0, 0)`. Attach `WaveSpawner` to it.
3. In the Inspector, give **Enemy Prefabs** three elements: `Scout`, `Meteor` and
   `Zigzag`, from `Assets/Prefabs`. Then drag `Shooter Game` into **Game**.

The last argument of `Instantiate`, `transform`, makes every new enemy a child of
`Wave Spawner`: the Hierarchy stays tidy, and in Chapter 9 the spawner clears
the screen by destroying all its children.

### Test it

Press **Play**. Every second, an enemy appears at a random place along the top.
Shoot them, and watch the score: 100 for a scout, 50 for a meteor, 150 for a
zigzag. In the Hierarchy, `Wave Spawner` fills up with enemies, and empties again
as they're destroyed or fly away.

### Challenge

Make the game speed up as it goes: every time an enemy appears, make `delay` 2%
smaller (`delay *= 0.98f;`), but never less than 0.3 seconds. Look up
`Mathf.Max` in the Scripting API.

## C# 8 — Properties and Constructors

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

## C# 9 — static, const and readonly

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

## C# 10 — Lists

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

## Chapter 6 — Waves

**Goal:** the enemies come in waves: four of them for now, and five when the
gunships arrive in Chapter 8. Each wave's name flashes up, and the next wave
waits until every enemy of the last one has gone.

### Idea — a wave is a plain C# class

A wave isn't something in the scene: it's a few facts. Its name, which kinds of
enemy it sends, how many, and how quickly. `Wave` is a **plain C# class**: it
doesn't derive from `MonoBehaviour`, so it's never attached to a GameObject. You
make a wave with `new` and its constructor (C# 8):

```csharp
new Wave("Scouts", new GameObject[] { scoutPrefab }, 8, 0.7f)
```

Its properties have a `private set`: once a wave is made, nothing outside can
change it.

### Idea — a list of waves

The spawner keeps its waves in a `List<Wave>` (C# 10), filled in `Awake`.
The field is `readonly` (C# 9): it always holds the same list, while
the list itself can still grow with `Add`. A property, `WaveCount`, lets the game
ask how many waves there are, to show "Wave 2 of 4".

### Idea — when is a wave over?

When every one of its enemies has been destroyed or has flown off the screen.
Instead of keeping track of them all, every enemy **counts itself**: a `static`
property, `Enemy.AliveCount`, shared by all the enemies (C# 9). An
enemy's `OnEnable` adds 1 and its `OnDisable` takes 1 away. Destroying an object
disables it first (C# 4), so an enemy that explodes, or flies off the
bottom, is always taken off the count.

The spawner waits, one frame at a time, until the count is 0:

```csharp
while (Enemy.AliveCount > 0)
{
    yield return null;    // wait one frame, then check again
}
```

### Idea — a message that disappears by itself

`ShooterGame` gets two versions of `ShowMessage`, as overloads (C# 2):
`ShowMessage("Game Over")` shows a message that stays on the screen, and
`ShowMessage("Scouts", 2f)` shows one for two seconds. The second starts a
coroutine that clears the text later (C# 7). If another message
arrives before then, `StopCoroutine` cancels the old clearing, so the new message
doesn't vanish too early.

### Idea — Awake before Start

The spawner starts its waves in `Start`, and the very first thing it does is show
"Wave 1 of 4" and "Scouts". `ShooterGame` empties those same texts when the game
begins. If it did that in its `Start`, it might run just **after** the spawner's
`Start`, and wipe the first wave's name: Unity doesn't promise which object's
`Start` comes first. But it does promise that every `Awake` in the scene runs
before any `Start` (C# 4). That's why `ShooterGame` prepares its screen
in `Awake`.

### Do it — the Wave class

Create a script called `Wave`, and replace everything in it with this:

```csharp:Wave.cs
using UnityEngine;

// One wave of enemies: its name, which kinds of enemy, how many, and how fast
// they arrive. A plain C# class: the spawner makes each wave with `new`.
public class Wave
{
    public string Name { get; private set; }
    public GameObject[] EnemyPrefabs { get; private set; }
    public int Count { get; private set; }
    public float Delay { get; private set; }

    public Wave(string name, GameObject[] enemyPrefabs, int count, float delay)
    {
        Name = name;
        EnemyPrefabs = enemyPrefabs;
        Count = count;
        Delay = delay;
    }

    public GameObject RandomEnemy()
    {
        return EnemyPrefabs[Random.Range(0, EnemyPrefabs.Length)];
    }
}
```

You can't attach `Wave` to anything, and you don't need to: the spawner makes
its waves in code.

### Do it — every enemy counts itself

In `Enemy`:

1. Make the comment at the top end with "Every enemy counts itself while it's
   alive."
2. Add the count under the `[SerializeField]` fields, just above
   `Rigidbody2D body;`:

```csharp
    public static int AliveCount { get; private set; }
```

3. Add these three methods after `Awake`:

```csharp
    void OnEnable()
    {
        AliveCount++;
    }

    void OnDisable()
    {
        AliveCount--;
    }

    public static void ResetCount()
    {
        AliveCount = 0;
    }
```

### Do it — the texts

Make two more texts on the Canvas, like `Score Text`: anchored with Shift + Alt,
with the `kenvector_future SDF` font, white, and **Raycast Target** unticked.
Delete the "New Text" they start with, so they start empty.

| Object | Anchor | Pos | Size | Font Size | Alignment |
| --- | --- | --- | --- | --- | --- |
| `Wave Text` | top-center | (0, −30) | 700 × 70 | 40 | centre, middle |
| `Message Text` | middle-center | (0, 150) | 1700 × 200 | 80 | centre, middle |

### Do it — the waves and the messages

The new spawner and the new game use each other: the spawner tells the game when
a wave starts, and the game asks the spawner how many waves there are. So replace
both scripts, one straight after the other.

> **Note:** after the first one, the Console shows errors: each script uses
> something that's only in the new version of the other. They go away when both
> are replaced.

1. Replace `WaveSpawner` with this version:

```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Sends the waves of enemies, one after another. A new wave only starts when
// every enemy of the last one has been shot down or has flown off the screen.
public class WaveSpawner : MonoBehaviour
{
    [SerializeField] ShooterGame game;
    [SerializeField] GameObject scoutPrefab;
    [SerializeField] GameObject meteorPrefab;
    [SerializeField] GameObject zigzagPrefab;
    [SerializeField] float spawnWidth = 7.5f;     // enemies appear between -7.5 and 7.5...
    [SerializeField] float spawnHeight = 6f;      // ...just above the top of the screen

    readonly List<Wave> waves = new List<Wave>();

    public int WaveCount
    {
        get { return waves.Count; }
    }

    void Awake()
    {
        Enemy.ResetCount();    // a static count can survive from the last Play

        waves.Add(new Wave("Scouts", new GameObject[] { scoutPrefab }, 8, 0.7f));
        waves.Add(new Wave("Meteor Shower", new GameObject[] { meteorPrefab }, 10, 0.6f));
        waves.Add(new Wave("Zigzag Squadron", new GameObject[] { zigzagPrefab }, 8, 0.8f));
        waves.Add(new Wave("Everything!", new GameObject[] { scoutPrefab, meteorPrefab, zigzagPrefab }, 16, 0.6f));
    }

    void Start()
    {
        StartCoroutine(RunWaves());
    }

    IEnumerator RunWaves()
    {
        for (int i = 0; i < waves.Count; i++)
        {
            Wave wave = waves[i];
            game.WaveStarted(i + 1, wave.Name);
            yield return new WaitForSeconds(2f);

            for (int n = 0; n < wave.Count; n++)
            {
                Spawn(wave.RandomEnemy());
                yield return new WaitForSeconds(wave.Delay);
            }

            // Wait for the last enemies of this wave to go, one frame at a time.
            while (Enemy.AliveCount > 0)
            {
                yield return null;
            }
        }
        game.ShowMessage("All waves cleared!");
    }

    void Spawn(GameObject prefab)
    {
        Vector3 position = new Vector3(Random.Range(-spawnWidth, spawnWidth), spawnHeight, 0f);
        GameObject enemy = Instantiate(prefab, position, Quaternion.identity, transform);
        enemy.GetComponent<Enemy>().SetGame(game);
    }
}
```

2. Replace `ShooterGame` with this version:

```csharp
using System.Collections;
using TMPro;
using UnityEngine;

// Runs the game: the score, the waves and the messages.
public class ShooterGame : MonoBehaviour
{
    [SerializeField] WaveSpawner spawner;
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text waveText;
    [SerializeField] TMP_Text messageText;

    int score = 0;
    Coroutine hideMessage;

    // Awake, not Start: Unity calls every Awake before any Start, so the screen
    // is ready before another script's Start can show anything on it.
    void Awake()
    {
        messageText.text = "";
        waveText.text = "";
        UpdateScreen();
    }

    public void WaveStarted(int number, string waveName)
    {
        waveText.text = $"Wave {number} of {spawner.WaveCount}";
        ShowMessage(waveName, 2f);
    }

    public void EnemyDestroyed(string enemyName, int points, Vector3 position)
    {
        score += points;
        UpdateScreen();
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
        scoreText.text = $"{score:D6}";
    }
}
```

3. Select `Wave Spawner`. The **Enemy Prefabs** array has gone, and three fields
   have taken its place: drag in the `Scout`, `Meteor` and `Zigzag` prefabs.
4. Select `Shooter Game`, and drag `Wave Spawner` into **Spawner**, `Wave Text`
   into **Wave Text**, and `Message Text` into **Message Text**.

Read `WaveSpawner` before you move on:

- `Awake` first puts the count back to 0: a static value can survive from one
  Play to the next (C# 9). Then it fills the list with the waves,
  written as data: a name, the prefabs, how many enemies, and the delay between
  them.
- `RunWaves` goes through the list. For each wave, it tells the game, waits two
  seconds so you can read the wave's name, sends `Count` enemies, `Delay` seconds
  apart, then waits for the last one to go. After the last wave, it tells the
  game you've cleared them all.
- `i + 1`: lists count from 0, but people count from 1.

### Test it

Press **Play**. "Scouts" appears in the middle, and "Wave 1 of 4" at the top.
Two seconds later, the scouts arrive. When the last scout is gone, shot down or
flown past, the second wave, "Meteor Shower", begins. After "Everything!", the
message "All waves cleared!" stays on the screen.

> **Tip:** testing all four waves takes a while. While you test, make the waves
> smaller in `Awake`, for example 2 enemies each, and put the real numbers back
> afterwards.

### Challenge

Design a wave of your own and add it between two others: its name, its enemies,
how many and how fast. The game shows "Wave 1 of 5" all by itself. Why?

# Part 3 — Fight Back

## C# 11 — Mouse and Touch

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
| 3D | `Camera.main.ScreenPointToRay(screenPosition)` | a **ray** from the camera through the pointer (use it with a raycast: C# 12) |

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

## Chapter 7 — Touch Controls

**Goal:** on a phone, the ship follows your finger and fires while your finger
is down, and a mouse does the same. You test it without a phone, in the Device
Simulator.

### Idea — the Pointer

`Pointer.current` is whichever pointer the player is using: the mouse, or a
finger on a touchscreen (C# 11). Two things tell the ship all it needs:

| Code | Gives |
| --- | --- |
| `pointer.press.isPressed` | `true` while the mouse button or the finger is down |
| `pointer.position.ReadValue()` | where it is, in pixels on the screen |

`Pointer.current` can be `null` too, on a device with neither a mouse nor a
touchscreen, so the script checks it like the keyboard.

### Idea — from the screen to the world

Pixels aren't units. `cam.ScreenToWorldPoint(pixels)` turns a point on the
screen into a point in the world (C# 11). `cam` is found once, in
`Awake`: `Camera.main` is the camera tagged **MainCamera**.

### Idea — following, not jumping

The ship doesn't jump to your finger. In `FixedUpdate`,
`Vector2.MoveTowards(from, to, maxStep)` moves it towards the finger by at most
`speed * Time.deltaTime` each step: the same top speed as with the keys
(C# 1). And it aims for a point `fingerGap`, 1 unit, **above** the
finger: otherwise your finger would hide the ship.

### Idea — a press on the UI isn't for the ship

`EventSystem.current.IsPointerOverGameObject()` is `true` when the pointer is
over a UI element: any button, text or image with **Raycast Target** ticked. The
ship ignores those presses, so that pressing a button during a game, like the
**Settings** button in Chapter 12, doesn't also drag the ship over and fire.

That's why you unticked **Raycast Target** on the texts. `Message Text` fills a
wide strip across the middle of the screen, even when it's empty: with Raycast
Target ticked, a finger on that strip couldn't steer the ship.

### Do it

Replace `PlayerShip` with this version:

```csharp
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

// The player's ship. It flies with the keyboard or follows a finger, and fires
// lasers.
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerShip : MonoBehaviour
{
    [SerializeField] GameObject laserPrefab;
    [SerializeField] Transform muzzle;
    [SerializeField] float speed = 8f;
    [SerializeField] float shotsPerSecond = 4f;
    [SerializeField] float fingerGap = 1f;        // the ship flies this far above a finger, so you can see it
    [SerializeField] Vector2 minPosition = new Vector2(-8.2f, -4.4f);
    [SerializeField] Vector2 maxPosition = new Vector2(8.2f, 1f);

    Rigidbody2D body;
    Camera cam;
    Vector2 keyboardDirection;
    Vector2 pointerTarget;
    bool followPointer = false;
    float nextShotTime = 0f;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        cam = Camera.main;
    }

    void Update()
    {
        // Start every frame standing still: only keys and fingers held down
        // right now can move the ship.
        keyboardDirection = Vector2.zero;
        followPointer = false;

        // The keyboard: arrows or W A S D, and Space to fire. A phone may have
        // no keyboard at all, and then Keyboard.current is null.
        Keyboard keyboard = Keyboard.current;
        bool spaceHeld = false;
        if (keyboard != null)
        {
            if (keyboard.leftArrowKey.isPressed || keyboard.aKey.isPressed)
            {
                keyboardDirection.x -= 1f;
            }
            if (keyboard.rightArrowKey.isPressed || keyboard.dKey.isPressed)
            {
                keyboardDirection.x += 1f;
            }
            if (keyboard.downArrowKey.isPressed || keyboard.sKey.isPressed)
            {
                keyboardDirection.y -= 1f;
            }
            if (keyboard.upArrowKey.isPressed || keyboard.wKey.isPressed)
            {
                keyboardDirection.y += 1f;
            }
            keyboardDirection = keyboardDirection.normalized;
            spaceHeld = keyboard.spaceKey.isPressed;
        }

        // A finger or the mouse: while it's held down, the ship follows it.
        Pointer pointer = Pointer.current;
        followPointer = pointer != null && pointer.press.isPressed && !EventSystem.current.IsPointerOverGameObject();
        if (followPointer)
        {
            Vector2 world = cam.ScreenToWorldPoint(pointer.position.ReadValue());
            pointerTarget = world + new Vector2(0f, fingerGap);
        }

        // Fire while Space is held, or while the ship is following the pointer.
        if ((spaceHeld || followPointer) && Time.time >= nextShotTime)
        {
            Fire();
        }
    }

    // Physics moves the ship, on the physics clock.
    void FixedUpdate()
    {
        Vector2 next;
        if (followPointer)
        {
            next = Vector2.MoveTowards(body.position, pointerTarget, speed * Time.deltaTime);
        }
        else
        {
            next = body.position + keyboardDirection * speed * Time.deltaTime;
        }

        next.x = Mathf.Clamp(next.x, minPosition.x, maxPosition.x);
        next.y = Mathf.Clamp(next.y, minPosition.y, maxPosition.y);
        body.MovePosition(next);
    }

    void Fire()
    {
        FireLaser(0f);
        nextShotTime = Time.time + 1f / shotsPerSecond;
    }

    // One laser from the muzzle, turned by angle degrees: 0 flies straight up.
    void FireLaser(float angle)
    {
        Instantiate(laserPrefab, muzzle.position, Quaternion.Euler(0f, 0f, angle));
    }
}
```

What's new:

- `using UnityEngine.EventSystems;` for the EventSystem, `fingerGap`, and three
  fields: `cam`, `pointerTarget` and `followPointer`.
- `Update` first sets `followPointer` to `false`. Then, if a pointer is held down
  and isn't over the UI, the ship follows it, and works out `pointerTarget`.
- The ship fires while Space is held, **or** while it's following the pointer.
- `FixedUpdate` chooses: towards the pointer, or along the keys.

### Test it — with the mouse

Press **Play**, hold the left mouse button in the Game view, and move the mouse:
the ship follows, a little above the cursor, and fires. Let go: it stops
following and stops firing. The keys still work as before.

### Test it — with a finger, in the Simulator

1. **Window → General → Device Simulator**. The Simulator opens next to the Game
   view.
2. At the top, pick a phone, and click **Rotate** to turn it sideways.
3. Press **Play**, and drag on the phone's screen: in the Simulator, the mouse
   acts as a finger. The ship follows, and fires while you drag.
4. Switch back to the **Game** tab when you're done.

### Challenge

Set **Finger Gap** to `0`, and play in the Simulator: why is `1` better? Then give
the ship a separate, faster `followSpeed` for when it follows the pointer, so it
keeps up with a quick finger.

## C# 12 — Raycasts

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

`Physics.Raycast` uses the Try pattern (C# 2). It returns `true` if the
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

In **3D**, the camera makes a ray through the pointer (C# 11), and a
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

## Chapter 8 — The Gunship

**Goal:** a fourth wave, of big red gunships that shoot back when you fly right
underneath them. Their lasers cost you one of your three lives, and so does
crashing into any enemy.

### Idea — seeing the player with a raycast

Every frame, the gunship's gun casts a ray straight down from its muzzle
(C# 12):

```csharp
RaycastHit2D hit = Physics2D.Raycast(muzzle.position, Vector2.down, range, playerMask);
```

If the ray hits something on the **Player** layer, `hit.collider` isn't `null`,
and the gun fires. `playerMask` is why the gun only ever sees the player: without
it, the ray would stop at whatever collider is first below the gun, often another
enemy or one of your lasers. `Debug.DrawRay` draws the ray in the Scene view, so
you can see what the gun sees.

After a shot, the gun waits for its cooldown before it looks again, like the
ship's cooldown in Chapter 3.

### Idea — lasers that hit the player

The enemy's laser is the same `Laser` script with one more setting, `hitsPlayer`.
A player's laser looks for an `Enemy` and damages it; an enemy's laser looks for
the `PlayerShip` and calls its `TakeHit`. The gun turns its laser 180°, so the
laser's `transform.up` points down the screen, and it flies down.

### Idea — lives

`ShooterGame` counts the lives. The starting number is a `const`
(C# 9): `const int StartingLives = 3;`. The life icons are an array
of `Image`s, and a loop decides which ones to show, as in Level 1:
`lifeIcons[i].enabled = i < lives;`. Turning off an `Image` component hides just
the picture.

When the last life goes, the ship disappears (`SetActive(false)`) and "Game Over"
appears. The waves carry on for now, and the next wave's name even replaces the
message: Chapter 9 gives the game a real ending.

### Do it — the Player layer

1. Select `Player Ship`. Open the **Layer** dropdown at the top-right of the
   Inspector and choose **Add Layer…**. Type `Player` in the first empty **User
   Layer**.
2. Select `Player Ship` again, and set its **Layer** to `Player`. If Unity asks
   about the children, choose **Yes, change children**.

### Do it — lives

1. Replace `ShooterGame` with this version:

```csharp
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Runs the game: the score, the lives, the waves and the messages.
public class ShooterGame : MonoBehaviour
{
    const int StartingLives = 3;

    [SerializeField] PlayerShip player;
    [SerializeField] WaveSpawner spawner;
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text waveText;
    [SerializeField] TMP_Text messageText;
    [SerializeField] Image[] lifeIcons;

    int score = 0;
    int lives = StartingLives;
    Coroutine hideMessage;

    // Awake, not Start: Unity calls every Awake before any Start, so the screen
    // is ready before another script's Start can show anything on it.
    void Awake()
    {
        messageText.text = "";
        waveText.text = "";
        UpdateScreen();
    }

    public void WaveStarted(int number, string waveName)
    {
        waveText.text = $"Wave {number} of {spawner.WaveCount}";
        ShowMessage(waveName, 2f);
    }

    public void EnemyDestroyed(string enemyName, int points, Vector3 position)
    {
        score += points;
        UpdateScreen();
    }

    public void PlayerHit()
    {
        lives--;
        UpdateScreen();

        if (lives <= 0)
        {
            player.gameObject.SetActive(false);
            ShowMessage("Game Over");
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
        scoreText.text = $"{score:D6}";
        for (int i = 0; i < lifeIcons.Length; i++)
        {
            lifeIcons[i].enabled = i < lives;
        }
    }
}
```

What's new: `using UnityEngine.UI;` for `Image`; the lives, with their `const`
and their icons; a reference to the player; and `PlayerHit`.

2. In `PlayerShip`, make the comment at the top end with "fires lasers, and loses
   a life when it's hit.". Add a reference to the game as the first field:

```csharp
    [SerializeField] ShooterGame game;
```

   and add these two methods at the end of the class:

```csharp
    public void TakeHit()
    {
        game.PlayerHit();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Crashing into an enemy destroys it, and costs the ship a life.
        if (other.TryGetComponent(out Enemy enemy))
        {
            enemy.TakeDamage(100);
            TakeHit();
        }
    }
```

### Do it — the life icons

1. **GameObject → UI (Canvas) → Image**, named `Life Icon 1`. Anchor it
   **top-left** (with Shift + Alt), **Pos** `(40, -30)`, **Width** `66`,
   **Height** `52`. Set its **Source Image** to `playerLife1_blue`, tick
   **Preserve Aspect**, and untick **Raycast Target**.
2. Duplicate it twice: `Life Icon 2` at **Pos** `(125, -30)` and `Life Icon 3`
   at `(210, -30)`.
3. Select `Shooter Game`. Drag `Player Ship` into **Player**, and give **Life
   Icons** three elements: `Life Icon 1`, `Life Icon 2` and `Life Icon 3`, in that
   order.
4. Select `Player Ship`, and drag `Shooter Game` into **Game**.

### Do it — the enemy laser

1. Replace `Laser` with its final version:

```csharp:Laser.cs
using UnityEngine;

// A laser bolt. It flies straight ahead at a fixed speed, hurts the first thing
// it hits on the other side, and disappears.
[RequireComponent(typeof(Rigidbody2D))]
public class Laser : MonoBehaviour
{
    [SerializeField] float speed = 12f;
    [SerializeField] float lifetime = 1.5f;
    [SerializeField] int damage = 1;
    [SerializeField] bool hitsPlayer = false;    // player lasers hit enemies; enemy lasers hit the player

    void Start()
    {
        // transform.up is the way the laser's sprite points
        GetComponent<Rigidbody2D>().linearVelocity = transform.up * speed;
        Destroy(gameObject, lifetime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (hitsPlayer)
        {
            if (other.TryGetComponent(out PlayerShip player))
            {
                player.TakeHit();
                Destroy(gameObject);
            }
        }
        else if (other.TryGetComponent(out Enemy enemy))
        {
            enemy.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
```

2. Drag `laserRed01` into the Hierarchy and rename it `Enemy Laser`. Add a
   **Rigidbody 2D** (**Dynamic**, **Gravity Scale** `0`), a **Box Collider 2D**
   (**Is Trigger** ticked), and the **Laser** script: **Speed** `8`, and tick
   **Hits Player**.
3. Drag `Enemy Laser` into `Assets/Prefabs`, then delete it from the Hierarchy.

### Do it — the gunship

1. Create `EnemyGun`:

```csharp
using UnityEngine;

// Lets an enemy ship shoot, but only when it can see the player: a raycast
// looks straight down from the gun for anything on the Player layer.
public class EnemyGun : MonoBehaviour
{
    [SerializeField] GameObject laserPrefab;
    [SerializeField] Transform muzzle;
    [SerializeField] LayerMask playerMask;
    [SerializeField] float range = 12f;
    [SerializeField] float cooldown = 1.2f;

    float nextShotTime = 0f;

    void Update()
    {
        if (Time.time < nextShotTime)
        {
            return;
        }

        Debug.DrawRay(muzzle.position, Vector2.down * range, Color.red);
        RaycastHit2D hit = Physics2D.Raycast(muzzle.position, Vector2.down, range, playerMask);
        if (hit.collider != null)
        {
            // Turned 180°, the laser's "up" points down the screen.
            Instantiate(laserPrefab, muzzle.position, Quaternion.Euler(0f, 0f, 180f));
            nextShotTime = Time.time + cooldown;
        }
    }
}
```

2. Drag `enemyRed2` into the Hierarchy and rename it `Gunship`. Set it up like the
   other enemies: **Order in Layer** `1`; a **Rigidbody 2D** (**Kinematic**,
   **Interpolate**); a **Circle Collider 2D** (**Is Trigger**, **Radius** `0.4`);
   and **Enemy**, with **Enemy Name** `Gunship`, **Max Health** `3`, **Points**
   `250` and **Fall Speed** `1`.
3. Right-click `Gunship` → **Create Empty**, rename it `Muzzle`, and set its
   **Position** to `(0, -0.55, 0)`: just below its nose, which points down.
4. Add **EnemyGun** to `Gunship`. Drag the `Enemy Laser` prefab into **Laser
   Prefab** and the gunship's `Muzzle` into **Muzzle**. Open **Player Mask** and
   tick only **Player**.
5. Drag `Gunship` into `Assets/Prefabs`, then delete it from the Hierarchy.

### Do it — a wave of gunships

In `WaveSpawner`:

1. Add a field under `zigzagPrefab`:

```csharp
    [SerializeField] GameObject gunshipPrefab;
```

2. In `Awake`, replace the `Everything!` line with these two, so that the
   gunships get a wave of their own and join the last one:

```csharp
        waves.Add(new Wave("Gunships", new GameObject[] { gunshipPrefab }, 5, 1.5f));
        waves.Add(new Wave("Everything!", new GameObject[] { scoutPrefab, meteorPrefab, zigzagPrefab, gunshipPrefab }, 16, 0.6f));
```

3. Select `Wave Spawner`, and drag the `Gunship` prefab into **Gunship Prefab**.

### Test it

Press **Play**. Crash into an enemy: it breaks, and a life icon goes. In wave 4,
fly under a gunship: it fires red lasers straight down at you. Keep the Scene
view open next to the Game view while you play: a red line shows each gunship's
ray, whenever its gun is ready. Lose all three lives, and the ship vanishes with
"Game Over".

> **Tip:** to reach wave 4 quickly, make the first three waves small while you
> test, as in Chapter 6.

### Challenge

Try a gunship with a **Range** of `3`: now it only shoots when you're close.
Which do you prefer? Then give the gunship a **Sway Width** of `1`: does its gun
still look straight down while it sways?

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
uses the Try pattern and an `out` parameter (C# 2):

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
  convert from 'method group' to 'UnityEngine.Events.UnityAction\<float>'*.
- Add the listener in `OnEnable` and remove it in `OnDisable`
  (C# 4). Then a hidden settings panel doesn't react, and the pairs
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

## Chapter 9 — Start and Game Over

**Goal:** the game waits on a start screen until you press **Play**. When you
lose your last life, or clear every wave, an end screen shows your score and how
many of each enemy you destroyed, and **Play Again** starts over. After a hit,
your ship blinks for a moment, and nothing can hurt it while it blinks.

### Idea — a game has states

A game isn't always being played: there's before the start, the game itself, and
after the end. `ShooterGame` keeps one property, `IsPlaying`
(C# 8), and everything that should only happen during a game
checks it first: the ship ignores the controls, and hits don't count.

| Method | Does |
| --- | --- |
| `Awake` | not playing yet: shows the start panel |
| `StartGame` | resets the score, the lives and the kills; hides the panels; resets the ship; starts the waves |
| `EndGame(title)` | stops playing, stops the waves, and shows the end panel |
| `Win` | `EndGame("You Win!")`: the spawner calls it after the last wave |

### Idea — buttons in code

In Level 1, the Play button was connected in the Inspector. This time the code
connects both buttons (C# 14): `AddListener` in `OnEnable`, and
`RemoveListener` in `OnDisable`. **Play** and **Play Again** both call
`StartGame`.

### Idea — counting what you destroyed

The end screen lists each kind of enemy and how many you destroyed. That's a
`Dictionary<string, int>` (C# 13): the key is the enemy's name,
and the value is how many. `EnemyDestroyed` adds one to the right key, at last
using the `enemyName` every enemy has been sending since Chapter 5. The end
screen loops through the pairs, one line each:

```
Scout: 8
Meteor: 10
Zigzag: 7
```

### Idea — blinking

After a hit, the ship blinks for 1.5 seconds and can't be hurt again. A coroutine
(C# 7) turns its Sprite Renderer off and on ten times, 0.15 seconds
apart, and a `bool`, `invulnerable`, makes `TakeHit` ignore any hit meanwhile.
`ResetShip`, which `StartGame` calls, puts everything back: the ship's position,
its controls, and the blinking.

### Do it — the start panel

> **Watch out:** the **GameObject** menu always puts new UI straight onto the
> Canvas, whatever you've selected. To put a new UI element **inside** another
> one, right-click the parent in the Hierarchy and choose **UI (Canvas) → …**
> there.

1. **GameObject → UI (Canvas) → Panel**, named `Start Panel`. It covers the whole
   screen: set its **Color** to black, with **Alpha** around 140, to dim the game
   behind it.
2. Right-click `Start Panel` → **UI (Canvas) → Image**, and name it `Window`:
   anchor middle-center, **Width** `600`, **Height** `300`, colour `#2A2340`, and
   **Scale** `(2, 2, 1)`. The standard buttons are small; scaling the window
   makes everything in it bigger at once.
3. Make these inside `Window`, right-clicking `Window` each time:

| Object | Type | Pos | Size | Settings |
| --- | --- | --- | --- | --- |
| `Title` | Text - TextMeshPro | (0, 90) | 560 × 70 | "Space Shooter", `kenvector_future SDF`, size 48, centre, middle |
| `How To Play` | Text - TextMeshPro | (0, 10) | 560 × 80 | two lines, below; size 18, centre, middle |
| `Play Button` | Button - TextMeshPro | (0, −95) | 200 × 50 | colour `#3A8DDE`, text "Play", size 25 |

The two lines of `How To Play` (press **Enter** between them):

```
Fly: arrow keys or W A S D, or drag with a finger
Fire: hold Space, or keep your finger down
```

### Do it — the end panel

1. Another **Panel**, named `End Panel`, black with **Alpha** around 140, and
   inside it a `Window` like the first one, but **Width** `560` and **Height**
   `340`.
2. Inside this `Window`:

| Object | Type | Pos | Size | Settings |
| --- | --- | --- | --- | --- |
| `End Text` | Text - TextMeshPro | (0, 30) | 520 × 250 | "Game Over", size 22, centre, top |
| `Play Again Button` | Button - TextMeshPro | (0, −135) | 200 × 40 | colour `#3A8DDE`, text "Play Again", size 20 |

3. Hide `End Panel`: untick the checkbox next to its name in the Inspector.

### Do it — the code

Three scripts change, and they use each other: the game starts the spawner's
waves and resets the ship; the spawner tells the game you've won; the ship asks
the game whether it's playing. Change all three, one after the other.

> **Note:** the Console shows errors until you've changed all three. That's
> expected: each one uses something that's only in the new version of another.

1. Replace `ShooterGame` with this version:

```csharp
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Runs the game: the score, the lives, the waves, the messages, and the start
// and end screens.
public class ShooterGame : MonoBehaviour
{
    const int StartingLives = 3;

    [SerializeField] PlayerShip player;
    [SerializeField] WaveSpawner spawner;
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text waveText;
    [SerializeField] TMP_Text messageText;
    [SerializeField] Image[] lifeIcons;
    [SerializeField] GameObject startPanel;
    [SerializeField] Button playButton;
    [SerializeField] GameObject endPanel;
    [SerializeField] TMP_Text endText;
    [SerializeField] Button playAgainButton;

    readonly Dictionary<string, int> kills = new Dictionary<string, int>();
    int score = 0;
    int lives = StartingLives;
    Coroutine hideMessage;

    public bool IsPlaying { get; private set; }
    public string PilotName { get; set; } = "Pilot";

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

    // Awake, not Start: Unity calls every Awake before any Start, so the screen
    // is ready before another script's Start can show anything on it.
    void Awake()
    {
        IsPlaying = false;
        startPanel.SetActive(true);
        endPanel.SetActive(false);
        messageText.text = "";
        waveText.text = "";
        UpdateScreen();
    }

    public void StartGame()
    {
        score = 0;
        lives = StartingLives;
        kills.Clear();
        startPanel.SetActive(false);
        endPanel.SetActive(false);

        player.gameObject.SetActive(true);
        player.ResetShip();
        IsPlaying = true;
        spawner.StartWaves();
        UpdateScreen();
    }

    public void WaveStarted(int number, string waveName)
    {
        waveText.text = $"Wave {number} of {spawner.WaveCount}";
        ShowMessage(waveName, 2f);
    }

    public void EnemyDestroyed(string enemyName, int points, Vector3 position)
    {
        score += points;
        if (kills.ContainsKey(enemyName))
        {
            kills[enemyName]++;
        }
        else
        {
            kills[enemyName] = 1;
        }

        UpdateScreen();
    }

    public void PlayerHit()
    {
        lives--;
        UpdateScreen();

        if (lives <= 0)
        {
            player.gameObject.SetActive(false);
            EndGame("Game Over");
        }
    }

    public void Win()
    {
        EndGame("You Win!");
    }

    void EndGame(string title)
    {
        IsPlaying = false;
        spawner.StopWaves();

        string lines = "";
        foreach (KeyValuePair<string, int> pair in kills)
        {
            lines += $"{pair.Key}: {pair.Value}\n";
        }
        endText.text = $"{title}\n\n{PilotName}: {score:D6} points\n\n{lines}";
        endPanel.SetActive(true);
        messageText.text = "";
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
        scoreText.text = $"{score:D6}";
        for (int i = 0; i < lifeIcons.Length; i++)
        {
            lifeIcons[i].enabled = i < lives;
        }
    }
}
```

2. Replace `WaveSpawner` with its final version:

```csharp:WaveSpawner.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Sends the waves of enemies, one after another. A new wave only starts when
// every enemy of the last one has been shot down or has flown off the screen.
public class WaveSpawner : MonoBehaviour
{
    [SerializeField] ShooterGame game;
    [SerializeField] GameObject scoutPrefab;
    [SerializeField] GameObject meteorPrefab;
    [SerializeField] GameObject zigzagPrefab;
    [SerializeField] GameObject gunshipPrefab;
    [SerializeField] float spawnWidth = 7.5f;     // enemies appear between -7.5 and 7.5...
    [SerializeField] float spawnHeight = 6f;      // ...just above the top of the screen

    readonly List<Wave> waves = new List<Wave>();

    public int WaveCount
    {
        get { return waves.Count; }
    }

    void Awake()
    {
        Enemy.ResetCount();    // a static count can survive from the last Play

        waves.Add(new Wave("Scouts", new GameObject[] { scoutPrefab }, 8, 0.7f));
        waves.Add(new Wave("Meteor Shower", new GameObject[] { meteorPrefab }, 10, 0.6f));
        waves.Add(new Wave("Zigzag Squadron", new GameObject[] { zigzagPrefab }, 8, 0.8f));
        waves.Add(new Wave("Gunships", new GameObject[] { gunshipPrefab }, 5, 1.5f));
        waves.Add(new Wave("Everything!", new GameObject[] { scoutPrefab, meteorPrefab, zigzagPrefab, gunshipPrefab }, 16, 0.6f));
    }

    public void StartWaves()
    {
        StopWaves();
        StartCoroutine(RunWaves());
    }

    public void StopWaves()
    {
        StopAllCoroutines();
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }

    IEnumerator RunWaves()
    {
        for (int i = 0; i < waves.Count; i++)
        {
            Wave wave = waves[i];
            game.WaveStarted(i + 1, wave.Name);
            yield return new WaitForSeconds(2f);

            for (int n = 0; n < wave.Count; n++)
            {
                Spawn(wave.RandomEnemy());
                yield return new WaitForSeconds(wave.Delay);
            }

            // Wait for the last enemies of this wave to go, one frame at a time.
            while (Enemy.AliveCount > 0)
            {
                yield return null;
            }
        }
        game.Win();
    }

    void Spawn(GameObject prefab)
    {
        Vector3 position = new Vector3(Random.Range(-spawnWidth, spawnWidth), spawnHeight, 0f);
        GameObject enemy = Instantiate(prefab, position, Quaternion.identity, transform);
        enemy.GetComponent<Enemy>().SetGame(game);
    }
}
```

3. In `PlayerShip`:
   - Add `using System.Collections;` at the very top, for the coroutine, and make
     the comment above the class end with "fires lasers, and blinks for a moment
     after it's hit.".
   - Add a field under `muzzle`:

```csharp
    [SerializeField] SpriteRenderer shipRenderer;
```

   - Add `Vector2 startPosition;` under `Camera cam;`, and
     `bool invulnerable = false;` under `float nextShotTime = 0f;`.
   - At the end of `Awake`, remember where the ship starts:

```csharp
        startPosition = transform.position;
```

   - In `Update`, just after `followPointer = false;`, stop when there's no game.
     The two lines above it still run, so the ship stands still between games:

```csharp
        if (!game.IsPlaying)
        {
            return;
        }
```

   - Replace `TakeHit`. After the last life, the ship is switched off, and a
     switched-off object can't start a coroutine: hence the second check.

```csharp
    public void TakeHit()
    {
        if (invulnerable || !game.IsPlaying)
        {
            return;
        }

        game.PlayerHit();
        if (game.IsPlaying)
        {
            StartCoroutine(Blink());
        }
    }
```

   - Add these two methods at the end of the class:

```csharp
    IEnumerator Blink()
    {
        invulnerable = true;
        for (int i = 0; i < 10; i++)
        {
            shipRenderer.enabled = !shipRenderer.enabled;
            yield return new WaitForSeconds(0.15f);
        }
        shipRenderer.enabled = true;
        invulnerable = false;
    }

    public void ResetShip()
    {
        StopAllCoroutines();
        body.position = startPosition;
        transform.position = startPosition;
        keyboardDirection = Vector2.zero;
        followPointer = false;
        invulnerable = false;
        shipRenderer.enabled = true;
    }
```

Read the new `ShooterGame` and `WaveSpawner` before you move on:

- `PilotName` is a property with a starting value, `"Pilot"`. The end screen uses
  it; in Chapter 12, the player can type their own.
- `OnEnable` and `OnDisable` connect and disconnect the two buttons.
- `EnemyDestroyed` counts the kill: `ContainsKey` checks whether this kind of
  enemy is already in the dictionary. If it is, add one; if not, start at 1.
- `EndGame` builds the kills list line by line, then puts everything in
  `endText`. `\n` starts a new line.
- The spawner's `Start` has gone: the waves wait until the game calls
  `StartWaves`. `StopWaves` stops the coroutine, and destroys every child of the
  spawner: all the enemies, wherever they are. After the last wave, the spawner
  calls `game.Win()`.

### Do it — connect it all

1. Select `Shooter Game`, and drag in the five new references: `Start Panel`,
   `Play Button`, `End Panel`, `End Text` and `Play Again Button`.
2. Select `Player Ship`, and drag `Player Ship` itself into **Ship Renderer**:
   Unity picks its Sprite Renderer.

### Test it

Press **Play**: the start panel waits. Press **Play** on it, and the first wave
begins. Get hit: the ship blinks, and a second hit during the blink costs
nothing. Lose all your lives: the end panel shows "Game Over", your score, and
your kills. Press **Play Again**: the score is back to `000000`, you have three
lives, and wave 1 starts again. Then play to the end of wave 5, for "You Win!".

### Challenge

Show the best score of the session on the end screen, under the score: "Best:
004200". Keep it in a field, and update it in `EndGame`.

# Part 4 — Polish

## Chapter 10 — Power-Ups and Explosions

**Goal:** destroyed enemies burst into sparks, and about one in eight drops a
power-up: a **shield** that takes a hit for you, **triple shot**, or **rapid
fire**.

### Idea — a public enum

There are three kinds of power-up, and an `enum` lists them, inside the
`PowerUp` class, as in Level 1:

```csharp
public class PowerUp : MonoBehaviour
{
    public enum Kind { Shield, TripleShot, RapidFire }
```

What's new is `public`: other scripts can use it too, by its full name. Inside
`PowerUp`, it's just `Kind`; everywhere else, it's `PowerUp.Kind`, as in
`PowerUp.Kind.Shield`. When the ship touches a power-up, the power-up calls
`player.Collect(kind)`, and the ship's `switch` decides what to do.

### Idea — power-ups that run out

Triple shot and rapid fire last 8 seconds. The ship doesn't count the seconds
down; it remembers **when** each one ends:
`tripleShotUntil = Time.time + powerUpSeconds;`. A property works out whether
it's still on (C# 8):

```csharp
bool HasTripleShot
{
    get { return Time.time < tripleShotUntil; }
}
```

`Fire` asks `HasTripleShot` and `HasRapidFire` every time it fires. Rapid fire
doubles the rate: `1f / 8` is 0.125 seconds between shots.

The shield doesn't run out: it's a picture of a force field, a child of the ship,
switched on when you collect it. The next hit switches it off instead of costing
a life.

### Idea — a lucky drop

`Random.value` is a random `float` from 0 to 1. `Random.value < 0.12f` is `true`
12% of the time: about one enemy in eight drops a power-up.

### Idea — an explosion that cleans up after itself

A **Particle System** throws out lots of small images, each living for a moment.
Its settings are grouped into **modules**:

| Module | Controls |
| --- | --- |
| **Main** (the top section) | how long the effect lasts, whether it loops, and each particle's lifetime, speed, size and colour |
| **Emission** | how many particles, and when: a steady stream, or a **Burst** all at once |
| **Shape** | where they come from, and which way they fly |
| **Color over Lifetime** | how their colour changes as they age: here, they fade away |
| **Renderer** | what each particle looks like: its material, and its sorting order |

The explosion is a prefab that plays once, by itself, as soon as it appears. Its
**Stop Action** is **Destroy**: when the last spark has faded, the explosion
deletes itself. `ShooterGame` only has to make one where the enemy was: the
`position` it's been receiving since Chapter 5.

### Do it — the explosion's material

1. In `Assets/Materials`: **Assets → Create → Material**, named `Explosion`.
2. Set its **Shader** to **Universal Render Pipeline → 2D →
   Sprite-Unlit-Default**, and drag `star1` into its **Sprite Texture** slot.
   Each spark will be a little star, unlit: it shines by itself.

### Do it — the explosion

1. **GameObject → Effects → Particle System**, named `Explosion`. Set its
   **Position** to `(0, 0, 0)` and its **Rotation** to `(0, 0, 0)`: the particle
   system arrives tipped over, for 3D, and in 2D it must face the camera.
2. In the **Main** module (to pick "Random Between Two Constants" or "Random
   Between Two Colors", click the small arrow at the right of a value):
   - **Duration** `0.5`, and untick **Looping**
   - **Start Lifetime**: random between `0.4` and `0.8`
   - **Start Speed**: random between `1` and `4`
   - **Start Size**: random between `0.15` and `0.35`
   - **Start Color**: random between two colours, yellow `#FFE066` and orange
     `#FF8A3D`
   - **Stop Action** **Destroy**
3. **Emission**: **Rate over Time** `0`. Under **Bursts**, click **+**: one burst
   at **Time** `0` with **Count** `30`.
4. **Shape**: **Shape** **Circle**, **Radius** `0.2`.
5. Tick **Color over Lifetime**, click its colour bar, and make the **Alpha** go
   from 255 at the start to 0 at the end: the sparks fade out.
6. **Renderer**: set **Material** to `Explosion` and **Order in Layer** to `5`,
   in front of everything.
7. Drag `Explosion` into `Assets/Prefabs`, then delete it from the Hierarchy.

### Do it — the power-up code

`PowerUp` calls the ship's `Collect`, and `Collect` takes a `PowerUp.Kind`: the
two scripts use each other, so write both, one after the other.

> **Note:** after the first one, the Console shows an error until the ship has
> its `Collect` method.

1. Create `PowerUp`:

```csharp:PowerUp.cs
using UnityEngine;

// A power-up drifting down the screen. The ship collects it by touching it.
[RequireComponent(typeof(Rigidbody2D))]
public class PowerUp : MonoBehaviour
{
    public enum Kind { Shield, TripleShot, RapidFire }

    [SerializeField] Kind kind = Kind.Shield;
    [SerializeField] float fallSpeed = 1.5f;

    void Start()
    {
        GetComponent<Rigidbody2D>().linearVelocity = Vector2.down * fallSpeed;
        Destroy(gameObject, 10f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out PlayerShip player))
        {
            player.Collect(kind);
            Destroy(gameObject);
        }
    }
}
```

2. In `PlayerShip`, make the comment at the top say the ship "fires lasers,
   collects power-ups, and blinks for a moment after it's hit.". Then add a field
   under `muzzle`, and another under `shotsPerSecond`:

```csharp
    [SerializeField] GameObject shield;
```

```csharp
    [SerializeField] float powerUpSeconds = 8f;
```

3. Under `float nextShotTime = 0f;`, add the two end times:

```csharp
    float tripleShotUntil = 0f;
    float rapidFireUntil = 0f;
```

4. Add the two properties just before `Awake`:

```csharp
    bool HasTripleShot
    {
        get { return Time.time < tripleShotUntil; }
    }

    bool HasRapidFire
    {
        get { return Time.time < rapidFireUntil; }
    }
```

5. Replace `Fire`:

```csharp
    void Fire()
    {
        if (HasTripleShot)
        {
            FireLaser(-12f);
            FireLaser(0f);
            FireLaser(12f);
        }
        else
        {
            FireLaser(0f);
        }

        float rate = shotsPerSecond;
        if (HasRapidFire)
        {
            rate = shotsPerSecond * 2f;
        }
        nextShotTime = Time.time + 1f / rate;
    }
```

6. After `FireLaser`, add `Collect`:

```csharp
    public void Collect(PowerUp.Kind kind)
    {
        switch (kind)
        {
            case PowerUp.Kind.Shield:
                shield.SetActive(true);
                break;
            case PowerUp.Kind.TripleShot:
                tripleShotUntil = Time.time + powerUpSeconds;
                break;
            case PowerUp.Kind.RapidFire:
                rapidFireUntil = Time.time + powerUpSeconds;
                break;
        }
    }
```

7. In `TakeHit`, just after the first `if`, let the shield take the hit:

```csharp
        if (shield.activeSelf)
        {
            shield.SetActive(false);    // the shield takes the hit instead
            return;
        }
```

8. At the end of `ResetShip`, switch the power-ups and the shield off:

```csharp
        tripleShotUntil = 0f;
        rapidFireUntil = 0f;
        shield.SetActive(false);
```

### Do it — the shield

1. Right-click `Player Ship` → **Create Empty**, named `Shield`, at **Position**
   `(0, 0.1, 0)`. **Add Component → Sprite Renderer**: **Sprite** `shield1`,
   **Order in Layer** `2`.
2. Select `Player Ship`, and drag its `Shield` child into **Shield**.
3. Select `Shield` and untick it in the Inspector: it starts switched off.

### Do it — the power-ups

1. Make three prefabs, like the enemies: drag the sprite into the Hierarchy, set
   **Order in Layer** `1`, and add a **Rigidbody 2D** (**Kinematic**), a **Circle
   Collider 2D** (**Is Trigger**; it sizes itself), and **PowerUp** with its
   **Kind**:

| Name | Sprite | Kind |
| --- | --- | --- |
| `Shield Power-Up` | `powerupBlue_shield` | Shield |
| `Triple Shot Power-Up` | `powerupRed_star` | Triple Shot |
| `Rapid Fire Power-Up` | `powerupYellow_bolt` | Rapid Fire |

2. Drag all three into `Assets/Prefabs`, then delete them from the Hierarchy.

A Kinematic body moves by its velocity too: nothing pushes it, and nothing stops
it. `Start` sets it drifting down, and it deletes itself after 10 seconds, if
nobody collects it.

### Do it — enemies drop power-ups

1. Replace `Enemy` with its final version:

```csharp:Enemy.cs
using UnityEngine;

// Anything the player can shoot: enemy ships and meteors. It flies down the
// screen (swaying and spinning, if you like), takes hits, and explodes. Every
// enemy counts itself while it's alive.
[RequireComponent(typeof(Rigidbody2D))]
public class Enemy : MonoBehaviour
{
    [SerializeField] string enemyName = "Scout";
    [SerializeField] int maxHealth = 1;
    [SerializeField] int points = 100;
    [SerializeField] float fallSpeed = 2.5f;
    [SerializeField] float swayWidth = 0f;        // 0 flies straight down
    [SerializeField] float swaySpeed = 2f;
    [SerializeField] float spinSpeed = 0f;        // degrees per second: meteors spin
    [SerializeField] GameObject[] powerUpPrefabs;
    [SerializeField] float powerUpChance = 0.12f;

    public static int AliveCount { get; private set; }

    Rigidbody2D body;
    ShooterGame game;
    int health;
    float startX;
    float age = 0f;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        health = maxHealth;
        startX = transform.position.x;
    }

    void OnEnable()
    {
        AliveCount++;
    }

    void OnDisable()
    {
        AliveCount--;
    }

    public static void ResetCount()
    {
        AliveCount = 0;
    }

    public void SetGame(ShooterGame shooterGame)
    {
        game = shooterGame;
    }

    void FixedUpdate()
    {
        age += Time.deltaTime;
        float x = startX + Mathf.Sin(age * swaySpeed) * swayWidth;
        float y = body.position.y - fallSpeed * Time.deltaTime;
        body.MovePosition(new Vector2(x, y));
        body.MoveRotation(body.rotation + spinSpeed * Time.deltaTime);

        if (y < -6.5f)
        {
            Destroy(gameObject);    // it flew off the bottom of the screen
        }
    }

    public void TakeDamage(int damage)
    {
        if (health <= 0)
        {
            return;    // already exploding
        }

        health -= damage;
        if (health <= 0)
        {
            Explode();
        }
    }

    void Explode()
    {
        game.EnemyDestroyed(enemyName, points, transform.position);

        if (powerUpPrefabs.Length > 0 && Random.value < powerUpChance)
        {
            GameObject prefab = powerUpPrefabs[Random.Range(0, powerUpPrefabs.Length)];
            Instantiate(prefab, transform.position, Quaternion.identity, transform.parent);
        }
        Destroy(gameObject);
    }
}
```

2. Select all four enemy prefabs in `Assets/Prefabs` at once (hold **Ctrl** /
   **Cmd** and click each one). In the Inspector, give **Power Up Prefabs** three
   elements: the three power-up prefabs. Changing them all together saves time.

The power-up becomes a child of the enemy's parent, `Wave Spawner`, so
`StopWaves` clears power-ups away too.

### Do it — explosions

In `ShooterGame`:

1. Make the comment at the top list "the explosions," too. Add a field under
   `spawner`:

```csharp
    [SerializeField] GameObject explosionPrefab;
```

2. In `EnemyDestroyed`, just before `UpdateScreen();`, make an explosion where
   the enemy was:

```csharp
        Instantiate(explosionPrefab, position, Quaternion.identity);
```

3. In `PlayerHit`, when the last life goes, the ship explodes too. Add this line
   just before `player.gameObject.SetActive(false);`:

```csharp
            Instantiate(explosionPrefab, player.transform.position, Quaternion.identity);
```

4. Select `Shooter Game`, and drag the `Explosion` prefab into **Explosion
   Prefab**.

### Test it

Press **Play**. Every enemy you destroy bursts into yellow and orange stars,
and the `Explosion(Clone)` objects clean themselves out of the Hierarchy. Keep
shooting, and power-ups drift down: fly into them. The blue shield puts a ring
around your ship, and the next hit only takes the ring. The red star fires three
lasers at once, and the yellow bolt fires twice as fast, both for 8 seconds.

### Challenge

Add a fourth kind, `ExtraLife`: one more life, but never more than
`StartingLives`. You'll need a new sprite (try `playerLife1_blue`), a new case in
`Collect`, and a public method in `ShooterGame` for the ship to call.

## Chapter 11 — Sound and Shake

**Goal:** the game sounds like an arcade: lasers zap, enemies explode, waves
start with a chime, and big moments shake the camera.

### Idea — sounds, the Level 1 way

Sounds work exactly as in Level 1: an **Audio Source** component plays **Audio
Clips** with `PlayOneShot`. Three objects get an Audio Source of their own:

| Sound | When | Played by |
| --- | --- | --- |
| `sfx_laser1` | the ship fires | `PlayerShip` |
| `sfx_shieldUp` | the ship collects a power-up | `PlayerShip` |
| `sfx_shieldDown` | the shield takes a hit, or you lose a life | `PlayerShip`, `ShooterGame` |
| `sfx_laser2` | a gunship fires | `EnemyGun` |
| `sfx_zap` | an enemy explodes | `ShooterGame` |
| `sfx_twoTone` | a wave starts | `ShooterGame` |
| `sfx_lose` | the game is over | `ShooterGame` |

### Idea — a shake, in two sizes

`CameraShake` has two versions of `Shake`, as overloads (C# 2):
`Shake(0.15f)` shakes gently, with the default strength, and
`Shake(0.4f, 0.3f)` shakes for longer and harder, for when you lose a life. The
short version only calls the long one, with `defaultStrength`: the shaking itself
is written once.

The shake happens in `LateUpdate` (C# 4): after everything else has
moved this frame, the camera jumps to its home position plus a small random
offset. When time runs out, it goes back home. If the script is switched off in
the middle of a shake, `OnDisable` puts the camera back: Chapter 12's settings
switch it off exactly like that. And while the game is paused, a shake waits:
more about pausing in Chapter 12.

### Do it — the shake

Create `CameraShake`, and attach it to **Main Camera**:

```csharp:CameraShake.cs
using UnityEngine;

// Shakes the camera for a moment when something explodes. The shake happens in
// LateUpdate, after everything else has moved this frame.
public class CameraShake : MonoBehaviour
{
    [SerializeField] float defaultStrength = 0.1f;

    Vector3 home;
    float timeLeft = 0f;
    float strength;

    void Awake()
    {
        home = transform.position;
    }

    // Two versions (overloads): a normal shake, or one as strong as you ask.
    public void Shake(float seconds)
    {
        Shake(seconds, defaultStrength);
    }

    public void Shake(float seconds, float power)
    {
        timeLeft = seconds;
        strength = power;
    }

    void LateUpdate()
    {
        // While the game is paused (Time.timeScale is 0), time doesn't pass, so
        // the shake would never end: stay still until the game carries on.
        if (timeLeft > 0f && Time.timeScale > 0f)
        {
            timeLeft -= Time.deltaTime;
            Vector3 jolt = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f);
            transform.position = home + jolt * strength;
        }
        else
        {
            transform.position = home;
        }
    }

    void OnDisable()
    {
        transform.position = home;    // switched off in the settings: stop mid-shake
    }
}
```

### Do it — the sounds

1. Add an **Audio Source** to `Player Ship`, to `Shooter Game`, and to the
   `Gunship` prefab. Untick **Play On Awake** on all three.
2. In `PlayerShip`, add four fields under `shipRenderer`:

```csharp
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip laserSound;
    [SerializeField] AudioClip powerUpSound;
    [SerializeField] AudioClip shieldDownSound;
```

   Then add one line to each of three methods:
   - in `Fire`, just after the `if`/`else` that fires the lasers:
     `audioSource.PlayOneShot(laserSound);`
   - in `Collect`, as its first line: `audioSource.PlayOneShot(powerUpSound);`
   - in `TakeHit`, inside the shield's `if`, just after
     `shield.SetActive(false);`: `audioSource.PlayOneShot(shieldDownSound);`

3. Replace `EnemyGun` with its final version:

```csharp:EnemyGun.cs
using UnityEngine;

// Lets an enemy ship shoot, but only when it can see the player: a raycast
// looks straight down from the gun for anything on the Player layer.
public class EnemyGun : MonoBehaviour
{
    [SerializeField] GameObject laserPrefab;
    [SerializeField] Transform muzzle;
    [SerializeField] LayerMask playerMask;
    [SerializeField] float range = 12f;
    [SerializeField] float cooldown = 1.2f;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip shootSound;

    float nextShotTime = 0f;

    void Update()
    {
        if (Time.time < nextShotTime)
        {
            return;
        }

        Debug.DrawRay(muzzle.position, Vector2.down * range, Color.red);
        RaycastHit2D hit = Physics2D.Raycast(muzzle.position, Vector2.down, range, playerMask);
        if (hit.collider != null)
        {
            // Turned 180°, the laser's "up" points down the screen.
            Instantiate(laserPrefab, muzzle.position, Quaternion.Euler(0f, 0f, 180f));
            audioSource.PlayOneShot(shootSound);
            nextShotTime = Time.time + cooldown;
        }
    }
}
```

4. Replace `ShooterGame` with its final version:

```csharp:ShooterGame.cs
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Runs the game: the score, the lives, the waves, the messages, the explosions,
// and the start and end screens.
public class ShooterGame : MonoBehaviour
{
    const int StartingLives = 3;

    [SerializeField] PlayerShip player;
    [SerializeField] WaveSpawner spawner;
    [SerializeField] CameraShake cameraShake;
    [SerializeField] GameObject explosionPrefab;
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text waveText;
    [SerializeField] TMP_Text messageText;
    [SerializeField] Image[] lifeIcons;
    [SerializeField] GameObject startPanel;
    [SerializeField] Button playButton;
    [SerializeField] GameObject endPanel;
    [SerializeField] TMP_Text endText;
    [SerializeField] Button playAgainButton;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip explosionSound;
    [SerializeField] AudioClip loseLifeSound;
    [SerializeField] AudioClip waveSound;
    [SerializeField] AudioClip gameOverSound;

    readonly Dictionary<string, int> kills = new Dictionary<string, int>();
    int score = 0;
    int lives = StartingLives;
    Coroutine hideMessage;

    public bool IsPlaying { get; private set; }
    public string PilotName { get; set; } = "Pilot";

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

    // Awake, not Start: Unity calls every Awake before any Start, so the screen
    // is ready before another script's Start can show anything on it.
    void Awake()
    {
        IsPlaying = false;
        startPanel.SetActive(true);
        endPanel.SetActive(false);
        messageText.text = "";
        waveText.text = "";
        UpdateScreen();
    }

    public void StartGame()
    {
        score = 0;
        lives = StartingLives;
        kills.Clear();
        startPanel.SetActive(false);
        endPanel.SetActive(false);

        player.gameObject.SetActive(true);
        player.ResetShip();
        IsPlaying = true;
        spawner.StartWaves();
        UpdateScreen();
    }

    public void WaveStarted(int number, string waveName)
    {
        waveText.text = $"Wave {number} of {spawner.WaveCount}";
        ShowMessage(waveName, 2f);
        audioSource.PlayOneShot(waveSound);
    }

    public void EnemyDestroyed(string enemyName, int points, Vector3 position)
    {
        score += points;
        if (kills.ContainsKey(enemyName))
        {
            kills[enemyName]++;
        }
        else
        {
            kills[enemyName] = 1;
        }

        Instantiate(explosionPrefab, position, Quaternion.identity);
        audioSource.PlayOneShot(explosionSound);
        cameraShake.Shake(0.15f);
        UpdateScreen();
    }

    public void PlayerHit()
    {
        lives--;
        cameraShake.Shake(0.4f, 0.3f);
        UpdateScreen();

        if (lives <= 0)
        {
            Instantiate(explosionPrefab, player.transform.position, Quaternion.identity);
            player.gameObject.SetActive(false);
            audioSource.PlayOneShot(gameOverSound);
            EndGame("Game Over");
        }
        else
        {
            audioSource.PlayOneShot(loseLifeSound);
        }
    }

    public void Win()
    {
        EndGame("You Win!");
    }

    void EndGame(string title)
    {
        IsPlaying = false;
        spawner.StopWaves();

        string lines = "";
        foreach (KeyValuePair<string, int> pair in kills)
        {
            lines += $"{pair.Key}: {pair.Value}\n";
        }
        endText.text = $"{title}\n\n{PilotName}: {score:D6} points\n\n{lines}";
        endPanel.SetActive(true);
        messageText.text = "";
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
        scoreText.text = $"{score:D6}";
        for (int i = 0; i < lifeIcons.Length; i++)
        {
            lifeIcons[i].enabled = i < lives;
        }
    }
}
```

What's new in `ShooterGame`: the camera shake and five sound fields. A wave
start plays its chime; an explosion plays a zap and a gentle shake; losing a life
shakes hard and plays a sound, or, for the last life, the game-over sound.

### Do it — connect the sounds

| Select | And set |
| --- | --- |
| `Player Ship` | **Audio Source**: its own; **Laser Sound** `sfx_laser1`; **Power Up Sound** `sfx_shieldUp`; **Shield Down Sound** `sfx_shieldDown` |
| the `Gunship` prefab | **Audio Source**: its own; **Shoot Sound** `sfx_laser2` |
| `Shooter Game` | **Camera Shake**: **Main Camera**; **Audio Source**: its own; **Explosion Sound** `sfx_zap`; **Lose Life Sound** `sfx_shieldDown`; **Wave Sound** `sfx_twoTone`; **Game Over Sound** `sfx_lose` |

### Test it

Press **Play**, with the sound on. Every shot has its laser sound; every
explosion zaps and gives the screen a little jolt. Lose a life: a harder, longer
shake. Fly under a gunship: its laser has a sound of its own. And listen for the
chime as each wave begins.

### Challenge

Make the lasers less repetitive: before each laser sound, set
`audioSource.pitch` to a random value between `0.9` and `1.1`. Does it change
the other sounds of the ship too? Why?

## Chapter 12 — Settings

**Goal:** a **Settings** button opens a panel that pauses the game. In it: the
volume, the screen shake on or off, the pilot's name for the end screen, and the
colour of the ship.

### Idea — pausing

`Time.timeScale` is how fast game time runs. At `0`, time stops: `Time.deltaTime`
is 0, `FixedUpdate` isn't called, physics freezes, and `WaitForSeconds` waits.
At `1`, everything carries on.

`Update` and `LateUpdate` are still called while the game is paused, though. The
ship reads the keyboard in `Update`: without a check, typing a space in the name
box would fire a laser. So the ship ignores the controls while the game is
paused: `if (!game.IsPlaying || Time.timeScale == 0f)`. `CameraShake` checks
`Time.timeScale` in `LateUpdate` for the same reason: a shake that was running
when you paused waits for the game to carry on.

### Idea — the panel connects its own controls

The `SettingsMenu` script sits **on the panel itself**. When the panel is shown,
Unity calls its `OnEnable`, which connects the controls with `AddListener` and
pauses the game; when it's hidden, `OnDisable` disconnects them and unpauses
(C# 14). Before connecting, `OnEnable` shows the current values with
`SetValueWithoutNotify`, which changes a control without calling its listener.

The **Settings** button, which isn't on the panel, opens it the Level 1 way: in
its **On Click ()** list in the Inspector. Both ways of connecting UI, side by
side.

| Control | Sends | Does |
| --- | --- | --- |
| Volume slider | a `float`, 0 to 1 | `AudioListener.volume`, the volume of every sound in the game |
| Shake toggle | a `bool` | switches `CameraShake` on or off: `cameraShake.enabled` |
| Name input field | a `string`, when you finish typing | `game.PilotName`, for the end screen |
| Ship dropdown | an `int`: which option | swaps the ship's sprite and the life icons' sprites |

The dropdown's options and the sprite arrays are in the same order, so the option
number is also the index into both arrays.

### Do it — the panel

1. **GameObject → UI (Canvas) → Panel**, named `Settings Panel`: black, with
   **Alpha** around 140.
2. Right-click `Settings Panel` → **UI (Canvas) → Image**, named `Window`: anchor
   middle-center, **Width** `420`, **Height** `300`, colour `#2A2340`, and
   **Scale** `(2.2, 2.2, 1)`.
3. Make these inside `Window`, right-clicking `Window` each time, and place them
   (sizes are **Width**; heights stay as they come, except where the table says):

| Object | Type | Pos | Width | Settings |
| --- | --- | --- | --- | --- |
| `Title` | Text - TextMeshPro | (0, 115) | 380 | "Settings", `kenvector_future SDF`, size 30, centre, middle |
| `Volume Label` | Text - TextMeshPro | (−110, 60) | 140 | "Volume", size 18, height 30, left, middle |
| `Volume Slider` | Slider | (60, 60) | 200 | **Value** `1` |
| `Shake Toggle` | Toggle | (10, 18) | — | **Is On** ticked; its label says "Screen shake", in white |
| `Name Label` | Text - TextMeshPro | (−110, −28) | 140 | "Pilot", size 18, height 30, left, middle |
| `Name Input` | Input Field - TextMeshPro | (60, −28) | 200 | placeholder "Your name", **Character Limit** 12 |
| `Ship Label` | Text - TextMeshPro | (−110, −72) | 140 | "Ship", size 18, height 30, left, middle |
| `Ship Dropdown` | Dropdown - TextMeshPro | (60, −72) | 200 | **Options**: `Blue`, `Green`, `Orange`, `Red` |
| `Close Button` | Button - TextMeshPro | (0, −120) | 160 | height 36, colour `#3A8DDE`, text "Close", size 18 |

> **Tip:** the Toggle's label is an older **Text** component, not TextMeshPro.
> Select the Toggle's **Label** child to change its words and colour.

4. On the Canvas itself (not in the panel), a **Button - TextMeshPro** named
   `Settings Button`: anchor **bottom-right** (with Shift + Alt), **Pos**
   `(-30, 30)`, size `220 × 70`, colour `#3A8DDE`, text "Settings", size 35.
5. UI lower down in the Hierarchy draws on top. In the Hierarchy, drag `Settings
   Button` up to just below `Life Icon 3`, above `Start Panel`: then the panels
   cover it when they're open, and nobody can press it through them.

### Do it — the script

Create `SettingsMenu`, and attach it to `Settings Panel`:

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
    [SerializeField] TMP_Dropdown shipDropdown;
    [SerializeField] Button closeButton;
    [SerializeField] ShooterGame game;
    [SerializeField] CameraShake cameraShake;
    [SerializeField] SpriteRenderer shipRenderer;
    [SerializeField] Sprite[] shipSprites;      // in the same order as the dropdown's options
    [SerializeField] Image[] lifeIcons;
    [SerializeField] Sprite[] lifeSprites;      // the same colours, in the same order

    void OnEnable()
    {
        // Show the current values, without calling the listeners.
        volumeSlider.SetValueWithoutNotify(AudioListener.volume);
        shakeToggle.SetIsOnWithoutNotify(cameraShake.enabled);
        nameInput.SetTextWithoutNotify(game.PilotName);

        volumeSlider.onValueChanged.AddListener(OnVolumeChanged);
        shakeToggle.onValueChanged.AddListener(OnShakeToggled);
        nameInput.onEndEdit.AddListener(OnNameEntered);
        shipDropdown.onValueChanged.AddListener(OnShipChosen);
        closeButton.onClick.AddListener(Close);

        Time.timeScale = 0f;
    }

    void OnDisable()
    {
        volumeSlider.onValueChanged.RemoveListener(OnVolumeChanged);
        shakeToggle.onValueChanged.RemoveListener(OnShakeToggled);
        nameInput.onEndEdit.RemoveListener(OnNameEntered);
        shipDropdown.onValueChanged.RemoveListener(OnShipChosen);
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
        cameraShake.enabled = isOn;
    }

    void OnNameEntered(string text)
    {
        if (text.Trim() != "")
        {
            game.PilotName = text.Trim();
        }
    }

    void OnShipChosen(int index)
    {
        shipRenderer.sprite = shipSprites[index];
        foreach (Image icon in lifeIcons)
        {
            icon.sprite = lifeSprites[index];
        }
    }
}
```

`text.Trim()` is the text without the spaces at its ends, so a name made only of
spaces counts as blank, and the old name stays.

1. Select `Settings Panel`, and fill in its fields: the five controls; `Shooter
   Game` into **Game**; **Main Camera** into **Camera Shake**; `Player Ship` into
   **Ship Renderer**.
2. Give **Ship Sprites** four elements, in the dropdown's order:
   `playerShip1_blue`, `playerShip1_green`, `playerShip1_orange` and
   `playerShip1_red`. Give **Life Icons** the three life icons, and **Life
   Sprites** four elements: `playerLife1_blue`, `playerLife1_green`,
   `playerLife1_orange` and `playerLife1_red`.
3. Hide `Settings Panel`: untick it.
4. Select `Settings Button`. In its **On Click ()** list, click **+**, drag
   `Settings Panel` into the object slot, choose **GameObject → SetActive
   (bool)**, and tick the box.

### Do it — no controls while paused

Replace `PlayerShip` with its final version. The only change is in `Update`: the
pause check.

```csharp:PlayerShip.cs
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

// The player's ship. It flies with the keyboard or follows a finger, fires
// lasers, collects power-ups, and blinks for a moment after it's hit.
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerShip : MonoBehaviour
{
    [SerializeField] ShooterGame game;
    [SerializeField] GameObject laserPrefab;
    [SerializeField] Transform muzzle;
    [SerializeField] GameObject shield;
    [SerializeField] SpriteRenderer shipRenderer;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip laserSound;
    [SerializeField] AudioClip powerUpSound;
    [SerializeField] AudioClip shieldDownSound;
    [SerializeField] float speed = 8f;
    [SerializeField] float shotsPerSecond = 4f;
    [SerializeField] float powerUpSeconds = 8f;
    [SerializeField] float fingerGap = 1f;        // the ship flies this far above a finger, so you can see it
    [SerializeField] Vector2 minPosition = new Vector2(-8.2f, -4.4f);
    [SerializeField] Vector2 maxPosition = new Vector2(8.2f, 1f);

    Rigidbody2D body;
    Camera cam;
    Vector2 startPosition;
    Vector2 keyboardDirection;
    Vector2 pointerTarget;
    bool followPointer = false;
    float nextShotTime = 0f;
    float tripleShotUntil = 0f;
    float rapidFireUntil = 0f;
    bool invulnerable = false;

    bool HasTripleShot
    {
        get { return Time.time < tripleShotUntil; }
    }

    bool HasRapidFire
    {
        get { return Time.time < rapidFireUntil; }
    }

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        cam = Camera.main;
        startPosition = transform.position;
    }

    void Update()
    {
        // Start every frame standing still: only keys and fingers held down
        // right now can move the ship.
        keyboardDirection = Vector2.zero;
        followPointer = false;
        if (!game.IsPlaying || Time.timeScale == 0f)
        {
            return;
        }

        // The keyboard: arrows or W A S D, and Space to fire. A phone may have
        // no keyboard at all, and then Keyboard.current is null.
        Keyboard keyboard = Keyboard.current;
        bool spaceHeld = false;
        if (keyboard != null)
        {
            if (keyboard.leftArrowKey.isPressed || keyboard.aKey.isPressed)
            {
                keyboardDirection.x -= 1f;
            }
            if (keyboard.rightArrowKey.isPressed || keyboard.dKey.isPressed)
            {
                keyboardDirection.x += 1f;
            }
            if (keyboard.downArrowKey.isPressed || keyboard.sKey.isPressed)
            {
                keyboardDirection.y -= 1f;
            }
            if (keyboard.upArrowKey.isPressed || keyboard.wKey.isPressed)
            {
                keyboardDirection.y += 1f;
            }
            keyboardDirection = keyboardDirection.normalized;
            spaceHeld = keyboard.spaceKey.isPressed;
        }

        // A finger or the mouse: while it's held down, the ship follows it.
        Pointer pointer = Pointer.current;
        followPointer = pointer != null && pointer.press.isPressed && !EventSystem.current.IsPointerOverGameObject();
        if (followPointer)
        {
            Vector2 world = cam.ScreenToWorldPoint(pointer.position.ReadValue());
            pointerTarget = world + new Vector2(0f, fingerGap);
        }

        // Fire while Space is held, or while the ship is following the pointer.
        if ((spaceHeld || followPointer) && Time.time >= nextShotTime)
        {
            Fire();
        }
    }

    // Physics moves the ship, on the physics clock.
    void FixedUpdate()
    {
        Vector2 next;
        if (followPointer)
        {
            next = Vector2.MoveTowards(body.position, pointerTarget, speed * Time.deltaTime);
        }
        else
        {
            next = body.position + keyboardDirection * speed * Time.deltaTime;
        }

        next.x = Mathf.Clamp(next.x, minPosition.x, maxPosition.x);
        next.y = Mathf.Clamp(next.y, minPosition.y, maxPosition.y);
        body.MovePosition(next);
    }

    void Fire()
    {
        if (HasTripleShot)
        {
            FireLaser(-12f);
            FireLaser(0f);
            FireLaser(12f);
        }
        else
        {
            FireLaser(0f);
        }
        audioSource.PlayOneShot(laserSound);

        float rate = shotsPerSecond;
        if (HasRapidFire)
        {
            rate = shotsPerSecond * 2f;
        }
        nextShotTime = Time.time + 1f / rate;
    }

    // One laser from the muzzle, turned by angle degrees: 0 flies straight up.
    void FireLaser(float angle)
    {
        Instantiate(laserPrefab, muzzle.position, Quaternion.Euler(0f, 0f, angle));
    }

    public void Collect(PowerUp.Kind kind)
    {
        audioSource.PlayOneShot(powerUpSound);
        switch (kind)
        {
            case PowerUp.Kind.Shield:
                shield.SetActive(true);
                break;
            case PowerUp.Kind.TripleShot:
                tripleShotUntil = Time.time + powerUpSeconds;
                break;
            case PowerUp.Kind.RapidFire:
                rapidFireUntil = Time.time + powerUpSeconds;
                break;
        }
    }

    public void TakeHit()
    {
        if (invulnerable || !game.IsPlaying)
        {
            return;
        }

        if (shield.activeSelf)
        {
            shield.SetActive(false);    // the shield takes the hit instead
            audioSource.PlayOneShot(shieldDownSound);
            return;
        }

        game.PlayerHit();
        if (game.IsPlaying)
        {
            StartCoroutine(Blink());
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Crashing into an enemy destroys it, and costs the ship a life.
        if (other.TryGetComponent(out Enemy enemy))
        {
            enemy.TakeDamage(100);
            TakeHit();
        }
    }

    IEnumerator Blink()
    {
        invulnerable = true;
        for (int i = 0; i < 10; i++)
        {
            shipRenderer.enabled = !shipRenderer.enabled;
            yield return new WaitForSeconds(0.15f);
        }
        shipRenderer.enabled = true;
        invulnerable = false;
    }

    public void ResetShip()
    {
        StopAllCoroutines();
        body.position = startPosition;
        transform.position = startPosition;
        keyboardDirection = Vector2.zero;
        followPointer = false;
        invulnerable = false;
        shipRenderer.enabled = true;
        tripleShotUntil = 0f;
        rapidFireUntil = 0f;
        shield.SetActive(false);
    }
}
```

### Test it

Press **Play**, start a game, and click **Settings**: everything freezes. Drag
the volume down, untick the shake, type your name (press **Enter** or click
elsewhere to finish), and pick a red ship. **Close**: the game carries on, with a
red ship and red life icons, no shake, and quieter sounds. Lose your lives: the
end screen names you.

### Challenge

Save the settings, so they're still there the next time the game starts. Look up
`PlayerPrefs` in the Scripting API (C# 6): `PlayerPrefs.SetFloat` and
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

## Chapter 13 — Break It, Then Fix It

**Goal:** you can recognise the errors a broken Unity project throws, go straight
to their cause, and use a breakpoint to watch an enemy take damage.

### Idea

Every programmer breaks things, every day. The difference between a beginner and
a professional is how fast they find the cause. In this chapter you break the
finished game **on purpose**, one thing at a time, read what Unity tells you, and
fix it. Do each step, then undo it before the next one.

> **Watch out:** save your scene first (**Ctrl + S** / **Cmd + S**). If anything
> goes wrong, you can always go back to the saved version.

### Do it — an empty field

1. Select `Player Ship`. Click its **Muzzle** field and press **Delete** or
   **Backspace**: it now says **None (Transform)**.
2. Press **Play**, start a game, and hold **Space**. The Console fills with:

```
UnassignedReferenceException: The variable muzzle of PlayerShip has not been assigned.
You probably need to assign the muzzle variable of the PlayerShip script in the inspector.
```

3. Click the error. Below the message comes the stack trace. Its first line or
   two are Unity's own code: start at the first line that names your script,
   `PlayerShip.FireLaser`, with its line number. Under it are the methods that
   called it: `PlayerShip.Fire`, then `PlayerShip.Update`. Double-click the
   error: your editor opens `PlayerShip.cs` at the line that uses `muzzle`.
4. Stop, and drag `Muzzle` back into the field.

### Do it — a real null

1. In `PlayerShip`, turn the second line of `Awake` into a comment:
   `// cam = Camera.main;`. Now `cam` is never given the camera.
2. Play, start a game, and hold the mouse button down in the Game view. This time
   it's the plain C# error:

```
NullReferenceException: Object reference not set to an instance of an object
PlayerShip.Update () (at Assets/Scripts/PlayerShip.cs:97)
```

3. Line 97 is `Vector2 world = cam.ScreenToWorldPoint(pointer.position.ReadValue());`.
   Which reference on that line could be `null`? `pointer` was checked just
   before, so it's `cam`. `cam` is private and not a `[SerializeField]`, so no
   Inspector field can help: it's `null` because no code gave it a value.
4. Remove the `//`.

### Do it — a destroyed object

1. Press **Play** and start a game. Then, in the Hierarchy, open `Player Ship`,
   select its child `Muzzle`, and delete it (**Delete**, or **Cmd + Backspace** on
   Mac).
2. Click the **Game** tab, so the game has the keyboard again, and hold
   **Space**. A new kind of error:
   **MissingReferenceException**: *The object of type 'Transform' has been
   destroyed but you are still trying to access it*. The field still points at
   the muzzle, but the muzzle is gone.
3. Stop the game: the muzzle comes back. Deleting it in Play mode was only
   temporary.

### Do it — a component that can't go

Select `Player Ship` and try to remove its **Rigidbody 2D** (right-click its
title → **Remove Component**). Unity refuses: `PlayerShip` needs it, because of
its `[RequireComponent(typeof(Rigidbody2D))]`. That one line prevents a whole
family of errors.

### Do it — a bug with no error at all

1. In `Laser`, rename `OnTriggerEnter2D` to `OnTriggerEnter`, and change its
   parameter to `(Collider other)`. Save, and play.
2. No error, no warning, and your lasers fly straight through the enemies.
   `OnTriggerEnter` is the **3D** version: Unity only calls it for 3D colliders,
   and it only calls event functions whose names match exactly (C# 4).
3. Put back `OnTriggerEnter2D(Collider2D other)`.

### Do it — watch a hit with a breakpoint

1. Open `Enemy` in VS Code, and click left of the line number of
   `health -= damage;` in `TakeDamage`: a red dot.
2. **Run and Debug** (**Ctrl + Shift + D** / **Cmd + Shift + D**), choose
   **Attach to Unity**, and press ▶. If Unity asks, choose **Enable debugging
   for this session**.
3. Play, start a game, and shoot the first scout. The game freezes, and VS Code
   highlights the line.
4. Hover over `health`: 1, for a scout. Hover over `damage`: 1. Press **F10**
   once, and hover over `health` again: 0. Press **F10** again: the `if` sends
   the scout to `Explode`.
5. Press **F5** to carry on: the next hit stops the game again. In wave 2, try a
   meteor: each time the game stops, its `health` is 3, then 2, then 1, before
   the laser's damage is taken away. Click the red dot to remove it, press
   **F5**, and stop debugging with **Shift + F5**.

### Test it

After undoing every break, the game works exactly as before: play a whole game
to be sure, and check that the Console has no errors.

### Challenge

Break the game in a way this chapter didn't, and swap with a classmate: each of
you must find and fix the other's bug using only the Console and a breakpoint.

## Chapter 14 — Ship It

**Goal:** a Web build of your game, published on itch.io, that works with the
keyboard or a mouse on a computer, and with a finger on a phone.

### Idea

The game is finished; now players need it. As in Level 1, a **Web** build runs
in any browser, and itch.io hosts it for free. And this time there's a bonus: the
game already understands touch, so the same link works on a phone.

### Do it — the build

1. **File → Build Profiles**. Select **Web** and click **Switch Platform**.
2. In **Scene List**, click **Add Open Scenes** if `Scenes/SpaceShooter` is
   missing, and untick `Scenes/SampleScene`: a build starts with the first ticked
   scene, and that must be `Scenes/SpaceShooter`.
3. Open **Player Settings**: set the **Product Name** to `Space Shooter`. Under
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

Play the game in the browser with the keyboard, then with the mouse. Then open
the same page on a phone, turn it sideways, and fly with your finger. If
something is too small to read or to press on the phone, that's a job for the
challenge.

### Challenge

Watch a friend play without explaining anything. Where do they get stuck? Fix
the biggest problem: a clearer message, a bigger button, a gentler first wave.
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
