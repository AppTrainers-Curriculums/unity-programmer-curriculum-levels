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
| 2 | {{ref:vectors}} | Vectors | — |
| 3 | Chapter 2 | Keys to a direction, `Mathf.Clamp` | The ship |
| 4 | {{ref:methods}}, {{ref:numbers}} | Return types, parameters, overloading, `out`; conversions | — |
| 5 | Chapter 3 | Rotations, cooldowns | Lasers |
| 6 | {{ref:events}}, {{ref:components}} | Event functions, `GetComponent` | — |
| 7 | Chapter 4 | Body types, triggers, `MovePosition` | Enemies |
| 8 | {{ref:docs}}, {{ref:coroutines}} | The Unity docs, coroutines and timers | — |
| 9 | Chapter 5 | `Random.Range`, font assets | The spawner and the score |
| 10 | {{ref:properties}}, {{ref:modifiers}}, {{ref:lists}} | Properties, constructors, `static`, `const`, `readonly`, lists | — |
| 11 | Chapter 6 | Plain C# classes, static counters | Waves |
| 12 | {{ref:input}} | Mouse and touch | — |
| 13 | Chapter 7 | The Pointer, the Device Simulator | Touch controls |
| 14 | {{ref:raycasts}} | Raycasts | — |
| 15 | Chapter 8 | 2D raycasts, layers | The gunship |
| 16 | {{ref:dictionaries}}, {{ref:uievents}} | Dictionaries, UI events | — |
| 17 | Chapter 9 | `AddListener`, game states | Start and game over |
| 18 | Chapter 10 | Public enums (`PowerUp.Kind`), particles | Power-ups and explosions |
| 19 | Chapter 11 | Audio, overloads, `LateUpdate` | Sound and shake |
| 20 | Chapter 12 | Sliders, toggles, input fields, dropdowns | Settings |
| 21 | {{ref:null}} | `null`, stack traces, breakpoints | — |
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

{{concept:vectors}}

## Chapter 2 — The Ship

**Goal:** your ship flies around the lower part of the screen with the arrow keys
or **W A S D**, as fast diagonally as straight, and never off the screen.

### Idea — from keys to a direction

Each key held down adds to a `Vector2`: **left** takes 1 away from `x` and
**right** adds 1; **down** takes 1 away from `y` and **up** adds 1. Hold nothing
and the direction is `(0, 0)`; hold right and up and it's `(1, 1)`.

`(1, 1)` is 1.41 units long, though ({{ref:vectors}}), so flying diagonally would
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
`Keyboard.current` is `null`: nothing. Using nothing is an error ({{ref:null}}
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
  ({{ref:vectors}}).
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

{{concept:methods}}

{{concept:numbers}}

## Chapter 3 — Lasers

**Goal:** hold **Space**, and your ship fires blue lasers from its nose, four
every second.

### Idea — a laser that flies itself

A laser is a prefab with its own small script. It flies along `transform.up`, the
way its sprite points ({{ref:vectors}}), and it deletes itself after a while, so
the lasers that miss don't fly on for ever. `Destroy` has an **overload** with a
second parameter ({{ref:methods}}): `Destroy(gameObject, 1.5f)` destroys the
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
`float`; if both were `int`s, `1 / 4` would be `0` ({{ref:numbers}}).

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

{{concept:events}}

{{concept:components}}

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
in `FixedUpdate` ({{ref:events}}). Moving the Transform directly would fight the
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
script?" ({{ref:components}}). If it does, `enemy` is that script: the laser
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
({{ref:components}}); `keyboardDirection` is now a field, set in `Update`; and
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

{{concept:docs}}

{{concept:coroutines}}

## Chapter 5 — The Spawner and the Score

**Goal:** a new enemy arrives every second from a random place along the top of
the screen, and every enemy you destroy adds its points to the score in the
top-right corner.

### Idea — a coroutine that never ends

A coroutine can run a loop that never ends, `while (true)`, as long as the loop
waits every time round ({{ref:coroutines}}):

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

`Random.Range` has two overloads ({{ref:methods}}), and their `max` works
differently. Look them up in the Scripting API ({{ref:docs}}):

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
score with zeros to six digits ({{ref:numbers}}): `0` shows as `000000`, and
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
`Start` ({{ref:events}}): in Chapter 6, that matters. Select `Shooter Game`, and
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

{{concept:properties}}

{{concept:modifiers}}

{{concept:lists}}

## Chapter 6 — Waves

**Goal:** the enemies come in waves: four of them for now, and five when the
gunships arrive in Chapter 8. Each wave's name flashes up, and the next wave
waits until every enemy of the last one has gone.

### Idea — a wave is a plain C# class

A wave isn't something in the scene: it's a few facts. Its name, which kinds of
enemy it sends, how many, and how quickly. `Wave` is a **plain C# class**: it
doesn't derive from `MonoBehaviour`, so it's never attached to a GameObject. You
make a wave with `new` and its constructor ({{ref:properties}}):

```csharp
new Wave("Scouts", new GameObject[] { scoutPrefab }, 8, 0.7f)
```

Its properties have a `private set`: once a wave is made, nothing outside can
change it.

### Idea — a list of waves

The spawner keeps its waves in a `List<Wave>` ({{ref:lists}}), filled in `Awake`.
The field is `readonly` ({{ref:modifiers}}): it always holds the same list, while
the list itself can still grow with `Add`. A property, `WaveCount`, lets the game
ask how many waves there are, to show "Wave 2 of 4".

### Idea — when is a wave over?

When every one of its enemies has been destroyed or has flown off the screen.
Instead of keeping track of them all, every enemy **counts itself**: a `static`
property, `Enemy.AliveCount`, shared by all the enemies ({{ref:modifiers}}). An
enemy's `OnEnable` adds 1 and its `OnDisable` takes 1 away. Destroying an object
disables it first ({{ref:events}}), so an enemy that explodes, or flies off the
bottom, is always taken off the count.

The spawner waits, one frame at a time, until the count is 0:

```csharp
while (Enemy.AliveCount > 0)
{
    yield return null;    // wait one frame, then check again
}
```

### Idea — a message that disappears by itself

`ShooterGame` gets two versions of `ShowMessage`, as overloads ({{ref:methods}}):
`ShowMessage("Game Over")` shows a message that stays on the screen, and
`ShowMessage("Scouts", 2f)` shows one for two seconds. The second starts a
coroutine that clears the text later ({{ref:coroutines}}). If another message
arrives before then, `StopCoroutine` cancels the old clearing, so the new message
doesn't vanish too early.

### Idea — Awake before Start

The spawner starts its waves in `Start`, and the very first thing it does is show
"Wave 1 of 4" and "Scouts". `ShooterGame` empties those same texts when the game
begins. If it did that in its `Start`, it might run just **after** the spawner's
`Start`, and wipe the first wave's name: Unity doesn't promise which object's
`Start` comes first. But it does promise that every `Awake` in the scene runs
before any `Start` ({{ref:events}}). That's why `ShooterGame` prepares its screen
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
  Play to the next ({{ref:modifiers}}). Then it fills the list with the waves,
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

{{concept:input}}

## Chapter 7 — Touch Controls

**Goal:** on a phone, the ship follows your finger and fires while your finger
is down, and a mouse does the same. You test it without a phone, in the Device
Simulator.

### Idea — the Pointer

`Pointer.current` is whichever pointer the player is using: the mouse, or a
finger on a touchscreen ({{ref:input}}). Two things tell the ship all it needs:

| Code | Gives |
| --- | --- |
| `pointer.press.isPressed` | `true` while the mouse button or the finger is down |
| `pointer.position.ReadValue()` | where it is, in pixels on the screen |

`Pointer.current` can be `null` too, on a device with neither a mouse nor a
touchscreen, so the script checks it like the keyboard.

### Idea — from the screen to the world

Pixels aren't units. `cam.ScreenToWorldPoint(pixels)` turns a point on the
screen into a point in the world ({{ref:input}}). `cam` is found once, in
`Awake`: `Camera.main` is the camera tagged **MainCamera**.

### Idea — following, not jumping

The ship doesn't jump to your finger. In `FixedUpdate`,
`Vector2.MoveTowards(from, to, maxStep)` moves it towards the finger by at most
`speed * Time.deltaTime` each step: the same top speed as with the keys
({{ref:vectors}}). And it aims for a point `fingerGap`, 1 unit, **above** the
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

{{concept:raycasts}}


## Chapter 8 — The Gunship

**Goal:** a fourth wave, of big red gunships that shoot back when you fly right
underneath them. Their lasers cost you one of your three lives, and so does
crashing into any enemy.

### Idea — seeing the player with a raycast

Every frame, the gunship's gun casts a ray straight down from its muzzle
({{ref:raycasts}}):

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
({{ref:modifiers}}): `const int StartingLives = 3;`. The life icons are an array
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

{{concept:dictionaries}}

{{concept:uievents}}

## Chapter 9 — Start and Game Over

**Goal:** the game waits on a start screen until you press **Play**. When you
lose your last life, or clear every wave, an end screen shows your score and how
many of each enemy you destroyed, and **Play Again** starts over. After a hit,
your ship blinks for a moment, and nothing can hurt it while it blinks.

### Idea — a game has states

A game isn't always being played: there's before the start, the game itself, and
after the end. `ShooterGame` keeps one property, `IsPlaying`
({{ref:properties}}), and everything that should only happen during a game
checks it first: the ship ignores the controls, and hits don't count.

| Method | Does |
| --- | --- |
| `Awake` | not playing yet: shows the start panel |
| `StartGame` | resets the score, the lives and the kills; hides the panels; resets the ship; starts the waves |
| `EndGame(title)` | stops playing, stops the waves, and shows the end panel |
| `Win` | `EndGame("You Win!")`: the spawner calls it after the last wave |

### Idea — buttons in code

In Level 1, the Play button was connected in the Inspector. This time the code
connects both buttons ({{ref:uievents}}): `AddListener` in `OnEnable`, and
`RemoveListener` in `OnDisable`. **Play** and **Play Again** both call
`StartGame`.

### Idea — counting what you destroyed

The end screen lists each kind of enemy and how many you destroyed. That's a
`Dictionary<string, int>` ({{ref:dictionaries}}): the key is the enemy's name,
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
({{ref:coroutines}}) turns its Sprite Renderer off and on ten times, 0.15 seconds
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
it's still on ({{ref:properties}}):

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

`CameraShake` has two versions of `Shake`, as overloads ({{ref:methods}}):
`Shake(0.15f)` shakes gently, with the default strength, and
`Shake(0.4f, 0.3f)` shakes for longer and harder, for when you lose a life. The
short version only calls the long one, with `defaultStrength`: the shaking itself
is written once.

The shake happens in `LateUpdate` ({{ref:events}}): after everything else has
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
({{ref:uievents}}). Before connecting, `OnEnable` shows the current values with
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
`PlayerPrefs` in the Scripting API ({{ref:docs}}): `PlayerPrefs.SetFloat` and
`PlayerPrefs.GetFloat` are a good start.

# Part 5 — Finish

{{concept:null}}

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
   and it only calls event functions whose names match exactly ({{ref:events}}).
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

{{include:check-yourself}}
