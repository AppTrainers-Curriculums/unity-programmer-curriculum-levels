---
title: "Catch the Falling Blocks"
subtitle: "Level 1: Your First Real Game"
author: "Unity Programmer Curriculum  ·  Level 1"
coverEyebrow: "Level 1 · Learn to Code · Make Games"
coverTop: "Catch the"
coverRed: "Falling Blocks"
coverSub: "Your first real game: keyboard control, physics, prefabs, a score on screen, sound, and a build you can share."
coverPill: "Level 1 Workbook"
coverCaption: "Four scripts · three prefabs · one game you can publish"
coverArt: catch
---

# Part 0 — Before You Start

## What you're going to build

A **catch game**. A bar slides along the bottom of the screen, and you steer it
with the arrow keys. Blocks fall from the sky:

| Block | Colour | Catch it | Miss it |
| --- | --- | --- | --- |
| Normal | Red | **+1** point | You lose a life |
| Gold | Gold | **+5** points, but it falls fast | You lose a life |
| Bad | Purple | You lose a life | Nothing: dodging it is the right move |

You start with three lives. The blocks come faster and faster, and when your last
life goes, it's **game over**: the screen shows your score, your best score and
how long you lasted, and one click (or the Space key) starts a new game.

In Level 0 you were the programmer and the rocket flew itself. In Level 1 **the
player takes the controls**, and the game reacts to everything they do.

## How this book works

It works just like Level 0: two kinds of chapters, read in the order they appear.

| Chapter | Colour | What it does |
| --- | --- | --- |
| **Chapter 1, 2, 3…** | Red | **Build** the game in Unity, step by step. |
| **C# Concept 1, 2, 3…** | Slate | **Learn** one C# idea, with examples to try. |

Each chapter follows the same beats: **Goal**, **Idea**, **Do it**, **Test it**
and an optional **Challenge**. Under many C# examples, a grey box shows what the
Console prints: **predict** it before you look.

You'll try the C# examples in a `Practice` script, exactly as in Level 0: put the
example inside `Start()`, press **Play**, and read the Console.

> **Tip:** You passed the Level 1 entry test, so everything in Level 0 is yours to
> use: variables, operators, `if` / `else if` / `else`, methods, parameters,
> return values and reading errors. Keep the Level 0 cheat sheet next to you.

## The route through Level 1

| Step | Chapter | You learn | You build |
| --- | --- | --- | --- |
| 1 | Chapter 1 | Scenes, cameras, tags | The empty play area |
| 2 | C# Concept 1 | Scope, `public` and `private` | — |
| 3 | Chapter 2 | Keyboard input, `Time.deltaTime` | The player bar |
| 4 | Chapter 3 | Rigidbodies, gravity, colliders, triggers | One falling block |
| 5 | C# Concept 2 | Classes and objects | — |
| 6 | Chapter 4 | Prefabs | Three kinds of block |
| 7 | C# Concepts 3–4 | Arrays, loops | — |
| 8 | Chapter 5 | `Instantiate`, `Random.Range` | The spawner |
| 9 | C# Concepts 5–6 | Enums, `switch`, `?:`, text formatting | — |
| 10 | Chapter 6 | — | The game manager |
| 11 | Chapter 7 | Triggers in code, references | Catching and missing |
| 12 | Chapter 8 | Canvas, TextMeshPro, buttons | Score, lives and messages on screen |
| 13 | Chapter 9 | — | Game over and play again |
| 14 | Chapter 10 | Audio sources and clips | Sound |
| 15 | Chapter 11 | Builds | A game you can share |
| 16 | Part 5 | Exam-style practice | — |

## For trainers: running a session

Sessions follow the route above, with the same rhythm as Level 0:

| Share | Activity | From |
| --- | --- | --- |
| About 20% | **Concept:** teach the C# idea. Students predict each example's Console output before you run it. | C# Concept chapters |
| About 60% | **Build:** students follow the chapter in Unity and press Play at every checkpoint. | Build chapters |
| About 20% | **Practice:** the **Do it** exercises, in class or as homework. | C# Concept chapters |

Students join Level 1 by passing the **Level 1 entry test** (`Docs/Level1-Entry-Test.pdf`
in the course project; the answer key is a separate trainer-only file). Chapters
6 and 7 are the heart of the level: the game only comes alive once the scripts
talk to each other, so give them the most time. Part 5 rehearses the question
styles of the **Unity Certified User: Programmer** exam, which students sit at the
end of Level 3.

## The pieces we'll build

Four scripts and three prefabs:

```
PlayerController ── moves the bar with the keyboard, and reports blocks it touches
Spawner ─────────── drops random blocks from the sky, faster and faster
GameManager ─────── keeps the score, the lives and the game state, and runs the screen
Floor ───────────── an invisible floor under the screen: anything that lands was missed

Block, GoldBlock, BadBlock ── three prefabs: blueprints the Spawner copies
```

## From the browser page to Unity

You started Level 0 with **Catch the Falling Blocks** as a single HTML page. This
is that game, rebuilt properly in Unity, and bigger. Everything in the page has a
Unity version:

| In the browser page | In this Unity game |
| --- | --- |
| `TUNE` numbers at the top | `[SerializeField]` fields you tune in the **Inspector** |
| `loop()` and `requestAnimationFrame` | `Update()`, which Unity calls every frame |
| `dt` | `Time.deltaTime` |
| the `if`s that keep the player on screen | the same `if`s, in `PlayerController` |
| `overlaps()`: four comparisons | a **Collider 2D** and `OnTriggerEnter2D` |
| `blocks.push(…)` | `Instantiate`, copying a **prefab** |
| `blocks.splice(…)` | `Destroy` |
| `ctx.fillText("Score: " + score)` | a **TextMeshPro** text on a **Canvas** |
| `beep()` | an **Audio Source** playing a clip |

## New words for Level 1

| Word | What it means |
| --- | --- |
| **Prefab** | A saved GameObject you can copy as often as you like: a blueprint. |
| **Rigidbody 2D** | A component that hands an object to Unity's **physics**: gravity, speed, forces. |
| **Collider 2D** | A component that gives an object a shape that can **touch** other shapes. |
| **Trigger** | A collider that detects touches but lets things pass through. |
| **Tag** | A label on a GameObject, like `Block` or `GoldBlock`, that your code can read. |
| **Canvas** | The layer where the UI lives: text, buttons and icons drawn over the game. |

## One-time project setup

- **Unity 6**, with a new project created from the **Universal 2D** template, as
  in Level 0. Keep the scene's **Global Light 2D**.
- **Input:** a new Unity 6 project reads the keyboard with the **Input System**
  package, and that's what this book uses. There's nothing to set up.
- **Sound:** your trainer shares four sound files: `Catch.wav`, `Gold.wav`,
  `Miss.wav` and `GameOver.wav`. You'll need them in Chapter 10.
- Every script lives in `Assets/Scripts/`, and every prefab in `Assets/Prefabs/`.

# Part 1 — The Player

## Chapter 1 — Set Up the Scene

**Goal:** a dark, empty play area framed by the camera, saved as a scene, with the
tags the game will need.

### Idea

A 2D camera is **orthographic**: it shows a flat slice of the world, with no
perspective. Its **Size** is half the height it can see, in Unity units. With Size
`6`, the screen runs from `y = -6` at the bottom to `y = 6` at the top. Every
position in this book is chosen to fit that frame:

```
 y =  7    blocks appear here, just above the top edge
 y =  6    ───────── top of the screen ─────────
 y =  0    the middle
 y = -4.5  the player bar
 y = -6    ──────── bottom of the screen ───────
 y = -7.5  the invisible floor that catches missed blocks
```

A **tag** is a label you give a GameObject. We'll tag each kind of block, so the
code can ask "what did I just catch?" and get an answer like `"GoldBlock"`.

### Do it — the scene

1. Create a new scene: **File → New Scene**, pick **Lit 2D (URP)** (it comes with
   a camera and a Global Light 2D), then **File → Save As**
   `Assets/Scenes/Catch.unity`.
2. Select **Main Camera**: set **Position** to `(0, 0, -10)`, **Size** to `6`, and
   the **Background** colour (under **Environment**) to `#1E1A33`.
3. In the **Project** window, create the folders `Scripts`, `Prefabs` and `Audio`
   inside `Assets`.

### Do it — the tags

1. Select any GameObject, open the **Tag** dropdown at the top of the Inspector,
   and choose **Add Tag…**.
2. Click **+** three times and add the tags `Block`, `GoldBlock` and `BadBlock`,
   spelled exactly like that.

> **Watch out:** tags are **case-sensitive** strings. `Goldblock` is not
> `GoldBlock`, and the code in Chapter 6 will quietly ignore a block whose tag is
> spelled differently.

### Test it

Press **Play**. The Game view is an empty navy rectangle. That's right: the stage
is ready, and the actors arrive in the next chapters.

## C# 1 — Scope and Access

**Goal:** you can say where a variable can be used, and decide what other scripts
(and the Inspector) are allowed to see.

### Idea — scope: where a variable lives

A variable only exists inside the **block** where it was created: between its
`{` and `}`. That region is its **scope**.

```csharp
using UnityEngine;

public class Practice : MonoBehaviour
{
    int score = 10;                 // class level: every method can use it

    void Start()
    {
        int bonus = 5;              // local: only exists inside Start()
        score = score + bonus;
        Debug.Log(score);
    }

    void Update()
    {
        Debug.Log(bonus);           // error: bonus doesn't exist here
    }
}
```

The last line fails with *The name 'bonus' does not exist in the current
context* (CS0103), the same error as a typo from Level 0. `bonus` died at the end
of `Start()`.

| Declared… | Called | Lives | Use it for |
| --- | --- | --- | --- |
| inside the class, outside methods | a **field** | as long as the object exists | things to remember between frames: score, lives, timers |
| inside a method | a **local variable** | until the method's `}` | working values: a height you just read, a random number |

You met both in Level 0: `secondsLeft` in the rocket was a field, and
`float height = transform.position.y;` inside `Fly()` was a local variable.

> **Tip:** if a value must survive to the next frame, it has to be a field. A local
> variable in `Update()` starts fresh every single frame.

### Idea — access: who can see it

Every field and method has an **access modifier** that says who can use it:

| Modifier | Who can use it |
| --- | --- |
| `private` | only this script. This is the **default**: no word means private. |
| `public` | any script that has a reference to this object |

```csharp
public class Rocket : MonoBehaviour
{
    public int fuel = 100;          // any script can read AND change this
    int crew = 3;                   // private: only Rocket can touch it

    public void Launch()            // other scripts may call this
    {
    }

    void CheckEngines()             // private: an internal step
    {
    }
}
```

The rule that keeps projects healthy: **keep things private unless another script
genuinely needs them.** A public field can be changed by any script, from
anywhere, which makes bugs very hard to track down.

### Idea — the Inspector and [SerializeField]

Unity shows **public** fields in the Inspector, so you can tune them without
touching code. But public fields break the rule above. The answer is
**`[SerializeField]`**: it shows a **private** field in the Inspector, while
keeping it private to other scripts.

```csharp
[SerializeField] float moveSpeed = 10f;   // in the Inspector, private to code
```

| Field | In the Inspector? | Other scripts can change it? |
| --- | --- | --- |
| `float speed = 5f;` | No | No |
| `public float speed = 5f;` | Yes | **Yes** |
| `[SerializeField] float speed = 5f;` | Yes | No |

In this book, **every** tunable number is a `[SerializeField]` field, and methods
are `public` only when another script calls them.

> **Watch out:** once a field is in the Inspector, **the Inspector value wins**.
> The number in the code (`= 10f`) is only the starting value, used when the
> component is first added. If you change the code to `= 20f` later, the Inspector
> keeps `10`. Right-click the component → **Reset** to go back to the code values.

> **Note:** Inspector labels are generated from the field name: `moveSpeed`
> appears as **Move Speed**. Good camelCase names give you a readable Inspector
> for free.

### Do it

1. In your `Practice` script, add `[SerializeField] int lives = 3;` and
   `[SerializeField] string playerName = "Sam";` as fields, and print both in
   `Start()`. Select the `Practice` object: both appear in the Inspector.
2. Change the values **in the Inspector**, press Play, and check the Console.
3. Declare a local variable inside `Start()` and try to print it from `Update()`.
   Read the error, then remove the line.

## Chapter 2 — The Player Bar

**Goal:** a cyan bar that slides left and right with the arrow keys (or A and D),
at the same speed on every computer, and can't leave the screen.

### Idea — reading the keyboard

A new Unity 6 project reads input through the **Input System** package. For our
game we only need to ask the keyboard simple questions:

| Question | Code |
| --- | --- |
| Is the left arrow held down right now? | `Keyboard.current.leftArrowKey.isPressed` |
| Is the A key held down? | `Keyboard.current.aKey.isPressed` |
| Was Space pressed **this frame**? | `Keyboard.current.spaceKey.wasPressedThisFrame` |

`isPressed` is `true` on every frame the key is held: perfect for movement.
`wasPressedThisFrame` is `true` for **one frame only**, when the key goes down:
perfect for "press Space to start", where holding the key shouldn't start ten
games.

To use `Keyboard`, the script needs one extra line at the top:
`using UnityEngine.InputSystem;`.

> **Note:** older tutorials, and some exam questions, use Unity's older input
> class. You should recognise it:
>
> | Input System (this book) | Older Input Manager |
> | --- | --- |
> | `Keyboard.current.leftArrowKey.isPressed` | `Input.GetKey(KeyCode.LeftArrow)` |
> | `Keyboard.current.spaceKey.wasPressedThisFrame` | `Input.GetKeyDown(KeyCode.Space)` |
> | `Mouse.current.leftButton.wasPressedThisFrame` | `Input.GetMouseButtonDown(0)` |
>
> In a new Unity 6 project the older class is switched off, and calling it throws
> an error.

### Idea — Time.deltaTime, properly this time

In Level 0 you used `Time.deltaTime` as a ready-made tool. Here's why it matters.

`Update()` runs once per frame, but frames aren't evenly spaced: a fast computer
draws 120 frames a second, a slow one 40. If we moved the bar a fixed 0.1 units
every frame, it would fly on the fast computer and crawl on the slow one.

`Time.deltaTime` is **the number of seconds since the last frame**. Multiplying a
speed by it turns "units per second" into "units this frame":

```
fast computer: 10 units/sec × 0.008 sec = 0.08 units this frame   (120 frames a second)
slow computer: 10 units/sec × 0.025 sec = 0.25 units this frame   ( 40 frames a second)

after one second, both have moved: 0.08 × 120 = 0.25 × 40 = 10 units
```

Smaller frames take smaller steps, bigger frames take bigger steps, and every
computer ends up at the same place at the same time.

> **Tip:** the rule: anything that changes **over time** (movement, timers,
> fuel) is multiplied by `Time.deltaTime`. Anything that happens **once** (a
> jump, a score) is not.

### Idea — keeping the bar on screen

`transform.position` is where the object is. You can't change just its `x`, but
you can replace the whole position with a new one: `new Vector3(x, y, z)` packs
three numbers into a position. So "move it back to the edge, keeping its height"
is:

```csharp
transform.position = new Vector3(-edge, transform.position.y, 0f);
```

### Do it — build the bar

1. **GameObject → 2D Object → Sprites → Square**. Rename it `Player`.
2. Set its **Position** to `(0, -4.5, 0)` and **Scale** to `(2.4, 0.4, 1)`.
3. In the **Sprite Renderer**, set the **Color** to cyan, `#3DDCC8`.
4. **Add Component → Box Collider 2D**. A green outline appears around the bar.
   Blocks will bump into it in Chapter 7.

### Do it — the script

Create `PlayerController` in `Assets/Scripts`, attach it to `Player`, and make it
look like this:

```csharp
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;   // units per second
    [SerializeField] float edge = 8.3f;       // how far left and right the bar can go

    void Update()
    {
        float direction = 0f;

        if (Keyboard.current.leftArrowKey.isPressed || Keyboard.current.aKey.isPressed)
        {
            direction = -1f;
        }
        if (Keyboard.current.rightArrowKey.isPressed || Keyboard.current.dKey.isPressed)
        {
            direction = 1f;
        }

        transform.Translate(direction * moveSpeed * Time.deltaTime, 0f, 0f);

        // Keep the bar on screen
        if (transform.position.x < -edge)
        {
            transform.position = new Vector3(-edge, transform.position.y, 0f);
        }
        if (transform.position.x > edge)
        {
            transform.position = new Vector3(edge, transform.position.y, 0f);
        }
    }
}
```

Read it before you move on:

- `direction` starts at `0` **every frame**. It only becomes `-1` or `1` while a
  key is held, so the bar stops the moment you let go.
- `||` from Level 0: either the arrow **or** the letter key works.
- `direction * moveSpeed * Time.deltaTime` is `-1`, `0` or `1`, times 10 units per
  second, times this frame's seconds.

### Test it

Press **Play**, click the **Game** view so it has keyboard focus, and hold the
arrow keys. The bar slides, and stops at the edges instead of leaving the screen.

While it's running, select `Player` and change **Move Speed** in the Inspector to
`25`. The bar speeds up instantly. Stop the game: it goes back to `10`.

> **Watch out:** changes made **during Play** are thrown away when you stop. This
> catches everyone at least once. Stop the game first, then change values you
> want to keep.

### Challenge

Make the bar move **twice as fast** while the **Left Shift** key is held
(`Keyboard.current.leftShiftKey.isPressed`). You need one new `if` and one new
variable.

# Part 2 — Falling Blocks

## Chapter 3 — One Block that Falls

**Goal:** a red block that falls from the sky by itself, pulled by gravity, with
no code at all.

### Idea — physics does the work

In Level 0 you moved the rocket yourself with `Translate`. The blocks will be moved
by Unity's **physics engine** instead. You give an object a **Rigidbody 2D**, and
physics takes over its movement.

| Word | Meaning | In our game |
| --- | --- | --- |
| **Force** | A push or pull that changes speed over time | Gravity pulls every block down |
| **Velocity** | The current speed and direction | How fast a block is falling right now |
| **Gravity Scale** | How strongly gravity pulls this body (`1` = normal) | Gold blocks get more, bad blocks less |
| **Linear Damping** | Air resistance that slows the body down | Stops the blocks speeding up forever |

A **force** changes **velocity** gradually: gravity makes a block fall a little
faster every moment. **Damping** pushes back harder the faster it goes, so the two
balance out at a steady top speed. Setting the velocity directly in code is the
other option: the speed changes instantly, with no build-up. Level 2 does that.

### Idea — colliders, collisions and triggers

A **Collider 2D** gives an object a shape that can touch other shapes. When two
colliders meet, one of two things happens:

| | Collision | Trigger |
| --- | --- | --- |
| **What happens** | The objects **bump**: they can't pass through each other | They **pass through**, and Unity just reports the touch |
| **Set up by** | Leaving **Is Trigger** unticked | Ticking **Is Trigger** on one of the colliders |
| **Message to your code** | `OnCollisionEnter2D` | `OnTriggerEnter2D` |
| **Used for** | Floors, walls, things that push each other | Pickups, catch zones, finish lines |

Our blocks are **triggers**: the bar catches them without being knocked around.

> **Note:** for a touch to be reported, **at least one** of the two objects needs a
> **Rigidbody 2D**. Our blocks have one, so the bar doesn't need it.

> **Note:** 3D games have the same pieces without the "2D": **Rigidbody**, **Box
> Collider**, `OnTriggerEnter`. 2D and 3D physics never touch each other: a Box
> Collider 2D can't hit a Box Collider.

### Do it

1. **GameObject → 2D Object → Sprites → Square**. Rename it `Block`.
2. **Position** `(0, 7, 0)`, **Scale** `(0.6, 0.6, 1)`, **Color** `#FF4D6D`, and
   in the Sprite Renderer set **Order in Layer** to `1` so blocks are drawn over
   the bar.
3. **Add Component → Box Collider 2D**, and tick **Is Trigger**.
4. **Add Component → Rigidbody 2D**. Set **Gravity Scale** to `0.5` and **Linear
   Damping** to `1`.
5. Set the **Tag** at the top of the Inspector to `Block`.

### Test it

Press **Play**. The block drops in from above the screen, speeds up, settles into a
steady fall, passes **straight through** the bar and keeps going forever. Select it
while it falls and watch its **Position Y** drop in the Inspector.

Now stop, untick **Is Trigger** on the block, and press Play again. This time the
block **lands on the bar** and stays there: that's a collision. Tick **Is
Trigger** again before you move on.

> **Tip:** try a **Gravity Scale** of `3`, then `0`, and a **Linear Damping** of
> `0` and `5`. Every number here changes how the game feels. This is what game
> designers call tuning.

## C# 2 — Classes and Objects

**Goal:** you can explain the difference between a class and an object, and create
objects of your own.

### Idea — a blueprint and the things built from it

A **class** is a blueprint. An **object** is one thing built from that blueprint.
One blueprint can build as many objects as you like, and each object has **its
own copy** of every field.

| Blueprint (class) | Things built from it (objects) |
| --- | --- |
| The plan for a car | Your car, my car, the car outside |
| `Rocket` | Every rocket in the scene |
| The **Block** prefab | Every block the Spawner drops |

You've been writing classes since Level 0: `public class Rocket : MonoBehaviour`
is a blueprint. When you attach the script to a GameObject, Unity builds an
object from it.

### Idea — your own class

A class doesn't have to be a Unity script. This one is plain C#, written **below**
the `Practice` class, in the same file:

```csharp
using UnityEngine;

public class Practice : MonoBehaviour
{
    void Start()
    {
        Spaceship first = new Spaceship();
        first.shipName = "Falcon";
        first.fuel = 80;

        Spaceship second = new Spaceship();
        second.shipName = "Hawk";
        second.fuel = 30;

        first.Report();
        second.Report();
    }
}

// A blueprint for spaceships
public class Spaceship
{
    public string shipName;
    public int fuel;

    public void Report()
    {
        Debug.Log(shipName + " has " + fuel + " fuel");
    }
}
```

```
Falcon has 80 fuel
Hawk has 30 fuel
```

- `new Spaceship()` builds a new object from the blueprint.
- The **dot** reaches inside an object: `first.fuel` is *first's* fuel,
  `first.Report()` runs *first's* `Report`.
- Each ship has its own `fuel`. Changing `second.fuel` never touches `first`.
- The fields are `public` so `Practice` can reach them (C# 1).

### Idea — objects in Unity

In Unity you rarely write `new` for game objects. Unity has its own ways to build
objects from blueprints:

| Plain C# | Unity |
| --- | --- |
| `new Spaceship()` | **Adding a script** to a GameObject builds one object of that class |
| — | **`Instantiate(prefab)`** copies a whole GameObject from a prefab (Chapter 5) |

> **Watch out:** never write `new` for a `MonoBehaviour` class
> (`new PlayerController()`). Unity refuses: scripts only live on GameObjects.

### Idea — references: a variable that points at an object

A variable of a class type doesn't hold a copy of an object. It holds a
**reference**: an arrow pointing at the object.

```csharp
Spaceship first = new Spaceship();
first.fuel = 80;

Spaceship sameShip = first;    // a second arrow to the SAME ship
sameShip.fuel = 10;

Debug.Log(first.fuel);
```

```
10
```

There's only one ship: `first` and `sameShip` both point at it. You'll use this in
Chapter 7, where the player needs a reference to the game manager: a field like
`GameManager gameManager;` that points at the one game manager in the scene.

A reference that points at nothing is `null`. Using it gives the famous
**NullReferenceException**, which Level 2 covers in depth.

### Do it

1. Add a field `public int crew;` to `Spaceship`, and include it in `Report()`.
2. Build three ships with different names and fuel, and report all three.
3. Add a method `public void Refuel(int amount)` to `Spaceship` that adds
   `amount` to `fuel`. Refuel one ship and report them all again: only that ship
   changes.

## Chapter 4 — Prefabs

**Goal:** three block prefabs (red, gold and bad) saved in `Assets/Prefabs`,
ready for the Spawner to copy.

### Idea

A **prefab** is a GameObject saved as a file: a blueprint (C# 2) for GameObjects.
Drag a GameObject from the **Hierarchy** into the **Project** window and it
becomes a prefab: its components, their values, its tag, everything.

After that, every copy you place or create in code is an **instance** of the
prefab. Change the prefab, and every instance changes with it.

| In the Hierarchy | Meaning |
| --- | --- |
| Blue cube icon, blue name | An instance of a prefab |
| Grey icon, white name | An ordinary GameObject |

### Do it — the red block

1. Drag `Block` from the Hierarchy into `Assets/Prefabs`. Its name turns blue.
2. Delete `Block` from the **Hierarchy**. The prefab file stays safe in the
   Project window.

### Do it — gold and bad blocks

1. In `Assets/Prefabs`, select `Block` and press **Ctrl/Cmd + D** twice to
   duplicate it. Rename the copies `GoldBlock` and `BadBlock`.
2. Double-click `GoldBlock` to open it in **prefab mode**, and change:
   - **Color** to gold, `#FFD166`
   - **Gravity Scale** to `0.9`: it falls fast, which is why it's worth 5 points
   - **Tag** to `GoldBlock`
3. Click the **<** arrow at the top of the Hierarchy to leave prefab mode. Then
   open `BadBlock` the same way and change:
   - **Color** to purple, `#9B5DE5`
   - **Gravity Scale** to `0.35`: it drifts down slowly
   - **Tag** to `BadBlock`

> **Watch out:** check each prefab's **tag** twice. A gold block still tagged
> `Block` looks gold but scores like a red one, and nothing tells you why.

### Test it

Drag all three prefabs from the Project window into the scene, side by side near
the top, and press **Play**. They fall at three different speeds. Stop, then
delete the three instances from the Hierarchy: from now on, only the Spawner makes
blocks.

## C# 3 — Arrays

**Goal:** you can store a list of values in an array, read and change them by
index, and pick a random element.

### Idea — many values under one name

An **array** holds several values of the same type, in order, under one name:

```csharp
string[] crew = { "Sara", "Omar", "Lina" };
int[] scores = { 12, 7, 30, 18 };
```

The `[]` after the type means "an array of". Each value sits at a numbered
position, its **index**, and **counting starts at 0**:

```
crew:     "Sara"   "Omar"   "Lina"
index:      0        1        2
```

```csharp
string[] crew = { "Sara", "Omar", "Lina" };

Debug.Log(crew[0]);
Debug.Log(crew[2]);
Debug.Log(crew.Length);

crew[1] = "Yusuf";     // replace one element
Debug.Log(crew[1]);
```

```
Sara
Lina
3
Yusuf
```

`crew.Length` is how many elements there are. The **last** index is always
`Length - 1`.

### Idea — making an empty array

You can also make an array of a set size, and fill it later. Each element starts
at its type's default: `0` for numbers, `false` for `bool`, and `null` for
strings and objects.

```csharp
int[] laps = new int[3];
laps[0] = 42;
Debug.Log(laps[0]);
Debug.Log(laps[1]);
```

```
42
0
```

> **Watch out:** an array's size is fixed once it's made. Reading or writing an
> index that doesn't exist, such as `crew[3]` in a 3-element array, stops your code
> with an **IndexOutOfRangeException**. The valid indexes are `0` to `Length - 1`.

### Idea — arrays in the Inspector

A `[SerializeField]` array appears in the Inspector as a list you can grow with
**+** and fill by dragging, which is exactly how the Spawner will get its prefabs:

```csharp
[SerializeField] GameObject[] blockPrefabs;
```

### Idea — a random element

`Random.Range(0, crew.Length)` gives a random **index**. With whole numbers, the
second number is **excluded**, so `Random.Range(0, 3)` gives `0`, `1` or `2`:
always a valid index.

```csharp
string[] crew = { "Sara", "Omar", "Lina" };
int index = Random.Range(0, crew.Length);
Debug.Log(crew[index] + " is flying today");
```

```
Omar is flying today      (or Sara, or Lina)
```

> **Note:** with decimal numbers, `Random.Range(-8.5f, 8.5f)` can return any value
> between the two, **including** both ends. Whole numbers exclude the top; floats
> don't.

### Do it

1. Make an array of five of your favourite games, and print the first, the last
   (using `Length - 1`) and the number of games.
2. Print a random game from the array each time you press Play.
3. Try to print `games[5]`, read the error, then remove the line.

## C# 4 — Loops

**Goal:** you can repeat code with `for`, `foreach` and `while`, and control a loop
with `break` and `continue`.

### Idea — for: repeat a set number of times

```csharp
for (int i = 0; i < 3; i++)
{
    Debug.Log("Lap " + i);
}
```

```
Lap 0
Lap 1
Lap 2
```

A `for` loop has three parts, separated by semicolons:

| Part | Here | Meaning |
| --- | --- | --- |
| Start | `int i = 0` | Runs once, before the loop begins |
| Condition | `i < 3` | Checked before **each** lap. When it's false, the loop ends |
| Step | `i++` | Runs after each lap |

Counting down works too:

```csharp
for (int i = 3; i > 0; i--)
{
    Debug.Log(i);
}
Debug.Log("Liftoff!");
```

```
3
2
1
Liftoff!
```

### Idea — for with an array

A `for` loop from `0` to `Length` visits every index of an array. It's the
loop you'll use in Chapter 8 to show one life icon per life:

```csharp
int[] scores = { 12, 7, 30 };
int total = 0;

for (int i = 0; i < scores.Length; i++)
{
    total += scores[i];
}

Debug.Log("Total: " + total);
```

```
Total: 49
```

> **Watch out:** the condition is `i < scores.Length`, not `<=`. With `<=`, the
> last lap asks for `scores[3]`, which doesn't exist: IndexOutOfRangeException.

### Idea — foreach: visit every element

When you don't need the index, `foreach` is simpler: it hands you each element in
turn.

```csharp
string[] crew = { "Sara", "Omar", "Lina" };

foreach (string name in crew)
{
    Debug.Log("Welcome aboard, " + name);
}
```

```
Welcome aboard, Sara
Welcome aboard, Omar
Welcome aboard, Lina
```

Read it as "for each `name` in `crew`". In Chapter 9, a `foreach` removes every
block still on screen when the game ends.

### Idea — while: repeat until something changes

A `while` loop repeats as long as its condition is true. Use it when you don't know
in advance how many laps it takes:

```csharp
int fuel = 100;
int seconds = 0;

while (fuel > 0)
{
    fuel -= 30;
    seconds++;
}

Debug.Log("Empty after " + seconds + " seconds");
```

```
Empty after 4 seconds
```

> **Watch out:** if the condition never becomes false, the loop never ends, and
> **Unity freezes** (you have to force-quit it). Always make sure something inside
> the loop moves it towards the end. And never use a `while` loop to wait for time
> to pass: nothing else runs until the loop finishes. That's what timers in
> `Update()` are for.

### Idea — break and continue

- `break` leaves the loop immediately.
- `continue` skips the rest of **this** lap and moves on to the next.

```csharp
int[] scores = { 12, 0, 30, 99, 18 };

foreach (int score in scores)
{
    if (score == 0)
    {
        continue;           // skip zeros
    }
    if (score == 99)
    {
        break;              // 99 means "stop reading"
    }
    Debug.Log(score);
}
```

```
12
30
```

### Do it

1. Print the numbers 1 to 10 with a `for` loop, then only the even ones (hint:
   `%` from Level 0).
2. With `int[] temperatures = { 21, 25, 19, 30, 27 };`, find and print the highest
   temperature with a loop.
3. Use a `foreach` to print only the names in an array that are longer than 4
   letters (`name.Length > 4`).

### Challenge

A `while` loop starts with `int balance = 1000;`. Each year, the balance grows by
10% (`balance += balance / 10;`). How many years until it reaches 2000? Print the
answer.

## Chapter 5 — The Spawner

**Goal:** random blocks rain down from the sky, one every 1.2 seconds, at random
positions.

### Idea

The **Spawner** is an empty GameObject with a script. It uses the Level 0 timer
pattern, and every time the timer fills, it drops a block:

1. Pick a random prefab from its array (C# 3).
2. Pick a random `x` between `-spawnWidth` and `spawnWidth`.
3. **Instantiate** a copy of that prefab at that position.

`Instantiate(prefab, position, rotation, parent)` is Unity's `new` for
GameObjects (C# 2):

| Argument | Here | Meaning |
| --- | --- | --- |
| `prefab` | `blockPrefabs[index]` | The blueprint to copy |
| `position` | `new Vector3(x, spawnHeight, 0f)` | Where the copy appears |
| `rotation` | `Quaternion.identity` | "Not rotated at all" |
| `parent` | `transform` | Put the copy **under the Spawner** in the Hierarchy |

Making every block a child of the Spawner keeps the Hierarchy tidy, and in
Chapter 9 it lets the Spawner find all its blocks in one loop.

**Weighting with an array:** the array can hold the same prefab more than once. An
array of 4 red, 1 gold and 2 bad blocks makes red the most common, because 4 of
the 7 slots are red.

### Do it

1. **GameObject → Create Empty**, named `Spawner`, at `(0, 0, 0)`.
2. Create the `Spawner` script, attach it, and make it look like this:

```csharp
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // The blocks it can drop. Put a prefab in twice to drop it twice as often.
    [SerializeField] GameObject[] blockPrefabs;

    [SerializeField] float delay = 1.2f;         // seconds between blocks
    [SerializeField] float spawnWidth = 8.5f;    // blocks appear between -spawnWidth and +spawnWidth
    [SerializeField] float spawnHeight = 7f;     // just above the top of the screen

    float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= delay)
        {
            timer = 0f;
            DropBlock();
        }
    }

    // Drops one random block at a random x position
    void DropBlock()
    {
        int index = Random.Range(0, blockPrefabs.Length);
        float x = Random.Range(-spawnWidth, spawnWidth);
        Vector3 position = new Vector3(x, spawnHeight, 0f);

        // The last argument makes the new block a child of this Spawner
        Instantiate(blockPrefabs[index], position, Quaternion.identity, transform);
    }
}
```

3. Select `Spawner`. In the Inspector, set **Block Prefabs** to size `7`, and drag
   in the prefabs from `Assets/Prefabs`: `Block` into elements 0–3, `GoldBlock`
   into 4, and `BadBlock` into 5 and 6.

> **Tip:** lock the Inspector (the padlock icon in its top-right corner) while you
> drag several prefabs, so clicking them in the Project window doesn't change what
> the Inspector shows.

### Test it

Press **Play**. A new block appears every 1.2 seconds, at a random spot, and you
can slide the bar under them. Expand `Spawner` in the Hierarchy: every block is
listed under it as `Block(Clone)`, `GoldBlock(Clone)` or `BadBlock(Clone)`.

Nothing is counted yet, and the blocks fall forever. The next two chapters give
the game its rules.

> **Watch out:** if the Console shows *UnassignedReferenceException* or
> *IndexOutOfRangeException* in `DropBlock`, an element of **Block Prefabs** is
> empty, or the array has size 0. Every slot needs a prefab.

### Challenge

Change the weighting so gold blocks are **rare**: about one in ten. What size must
the array be?

# Part 3 — Catching and Missing

## C# 5 — Enums, switch and ?:

**Goal:** you can give a variable a fixed set of named values, and choose between
many paths with `switch` and between two values with `?:`.

### Idea — enum: a type with named values

Our game is always in one of three states: waiting to start, playing, or over. You
could store that in a `string`, but a typo like `"Playng"` would compile and
silently break the game. An **enum** creates a new type whose only possible values
are the names you list:

```csharp
enum GameState
{
    Ready,
    Playing,
    GameOver
}
```

Now `GameState` is a type, like `int` or `bool`, and a `GameState` variable can
only ever be one of those three:

```csharp
GameState state = GameState.Ready;
Debug.Log(state);

state = GameState.Playing;

if (state == GameState.Playing)
{
    Debug.Log("The game is running");
}
```

```
Ready
The game is running
```

A typo like `GameState.Playng` is a compile error, caught before the game runs.
The enum goes **inside the class**, next to the fields, and its values are written
`EnumName.Value`.

### Idea — switch: one path per value

When one variable decides between many paths, a `switch` is easier to read than a
long `if` / `else if` chain:

```csharp
GameState state = GameState.GameOver;

switch (state)
{
    case GameState.Ready:
        Debug.Log("Press Space to start");
        break;
    case GameState.Playing:
        Debug.Log("Go!");
        break;
    case GameState.GameOver:
        Debug.Log("Game over");
        break;
}
```

```
Game over
```

`switch` works on enums, whole numbers and **strings**, so it can check a block's
tag:

```csharp
string blockTag = "GoldBlock";
int points = 0;

switch (blockTag)
{
    case "Block":
        points = 1;
        break;
    case "GoldBlock":
        points = 5;
        break;
    default:
        points = 0;
        break;
}

Debug.Log("Points: " + points);
```

```
Points: 5
```

- Each `case` ends with `break`, which jumps out of the `switch`.
- `default` runs when no `case` matches. It's optional.

> **Watch out:** forgetting a `break` is an error in C#: *Control cannot fall
> through from one case label to another* (CS0163). Every case must end with
> `break` (or `return`).

### Idea — ?: the one-line if / else

The **ternary operator** `?:` picks one of two **values**:

```
condition ? valueIfTrue : valueIfFalse
```

```csharp
int lives = 1;
string label = lives == 1 ? "life" : "lives";
Debug.Log(lives + " " + label + " left");
```

```
1 life left
```

It's the same as an `if` / `else` that stores a value, in one line. Use it for
short choices between two values. For anything longer, a normal `if` reads better.

### Do it

1. Make an enum `Weather` with `Sunny`, `Rainy` and `Stormy`. Store one in a
   variable, and use a `switch` to print advice for each ("Sunglasses!",
   "Umbrella!", "Stay inside!").
2. Use `?:` to print `"Pass"` or `"Fail"` for an `int mark`, with 50 as the pass
   mark.
3. Remove a `break` from your `switch` and read the error.

## C# 6 — Text: Interpolation and Formatting

**Goal:** you can build text from values with `$"…"`, and print numbers neatly.

### Idea — string interpolation

Joining text with `+` gets messy fast. **String interpolation** writes the text as
one piece, with values dropped into `{ }` holes. Put a `$` before the opening
quote:

```csharp
string rocketName = "Falcon";
int crew = 3;

Debug.Log("Rocket " + rocketName + " has " + crew + " crew");   // the Level 0 way
Debug.Log($"Rocket {rocketName} has {crew} crew");               // interpolation
```

```
Rocket Falcon has 3 crew
Rocket Falcon has 3 crew
```

Anything that gives a value can go inside the braces, including maths and method
calls:

```csharp
int score = 7;
Debug.Log($"Score: {score}, doubled: {score * 2}");
```

```
Score: 7, doubled: 14
```

> **Watch out:** without the `$`, the braces are just characters:
> `"Score: {score}"` prints exactly that, braces and all.

### Idea — special characters

Some characters need a backslash inside a string:

| Write | You get |
| --- | --- |
| `\n` | a new line |
| `\"` | a double quote |
| `\\` | a backslash |

```csharp
Debug.Log("Game Over\nScore: 12");
```

```
Game Over
Score: 12
```

### Idea — formatting numbers

In Level 0, the rocket reported `Fuel left: 40.00001`. A **format** after a colon
inside the braces controls how a number is shown:

| Format | Means | `{3.14159:…}` gives |
| --- | --- | --- |
| `F0` | no decimal places | `3` |
| `F1` | one decimal place | `3.1` |
| `F2` | two decimal places | `3.14` |

```csharp
float fuel = 40.00001f;
float time = 12.3456f;

Debug.Log($"Fuel left: {fuel:F0}");
Debug.Log($"You lasted {time:F1} seconds");
```

```
Fuel left: 40
You lasted 12.3 seconds
```

The number is **rounded** for display. The variable itself doesn't change.

### Idea — from message back to code

A certification question type you'll meet: the Console shows a message, and you
choose (or write) the line that printed it. Work backwards: find the fixed text,
then find where each value goes.

```
Level 3: 2 lives, 45.5 seconds
```

With `int level`, `int lives` and `float time`, that's:

```csharp
Debug.Log($"Level {level}: {lives} lives, {time:F1} seconds");
```

### Do it

1. Rewrite three `Debug.Log` lines from the Level 0 rocket with interpolation.
2. With `float price = 4.5f;` and `int count = 3;`, print
   `3 items: 13.50 coins` (hint: `F2`).
3. Print a two-line message using `\n`: your name on the first line, your city on
   the second.

## Chapter 6 — The Game Manager

**Goal:** a game manager that keeps the score, the lives and the game state, and
only lets blocks fall once you press Space.

### Idea

Every game needs a script that knows **the rules**: what a block is worth, how
many lives you have, and whether a game is running. That's the **GameManager**.
The other scripts report events to it ("I caught a gold block!", "a block hit the
floor!") and it decides what they mean.

It uses everything from C# 5 and 6:

- An **enum** for the three states: `Ready`, `Playing`, `GameOver`.
- A **switch** on the block's tag to decide what a catch is worth.
- **Interpolated** text for its messages, printed to the Console for now. Chapter 8
  moves them onto the screen.

Its **public** methods (C# 1) are the only doors the other scripts may use:

| Public method | Called by | Does |
| --- | --- | --- |
| `StartGame()` | the Space key (and the Play button, Chapter 8) | resets score and lives, starts playing |
| `IsPlaying()` | the Spawner | answers "is a game running?" with a `bool` |
| `BlockCaught(string blockTag)` | the Player (Chapter 7) | scores the block, or loses a life for a bad one |
| `BlockMissed(string blockTag)` | the Floor (Chapter 7) | loses a life, unless the block was bad |

### Do it — the game manager

1. **GameObject → Create Empty**, named `GameManager`.
2. Create the `GameManager` script, attach it, and make it look like this:

```csharp
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    // The three states the game can be in
    enum GameState
    {
        Ready,
        Playing,
        GameOver
    }

    [SerializeField] int startingLives = 3;

    GameState state = GameState.Ready;
    int score = 0;
    int lives = 0;

    void Start()
    {
        lives = startingLives;
        Debug.Log("Press Space to start");
    }

    void Update()
    {
        // Space starts a game, unless one is already running
        if (state != GameState.Playing && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            StartGame();
        }
    }

    public void StartGame()
    {
        score = 0;
        lives = startingLives;
        state = GameState.Playing;
        Debug.Log($"Game started! Lives: {lives}");
    }

    // Answers the question "is a game running right now?"
    public bool IsPlaying()
    {
        return state == GameState.Playing;
    }

    // Called by the Player when it catches a block
    public void BlockCaught(string blockTag)
    {
        if (!IsPlaying())
        {
            return;
        }

        switch (blockTag)
        {
            case "Block":
                score += 1;
                break;
            case "GoldBlock":
                score += 5;
                break;
            case "BadBlock":
                LoseLife();
                break;
        }

        Debug.Log($"Caught a {blockTag}. Score: {score}, lives: {lives}");
    }

    // Called by the Floor when a block falls past the player
    public void BlockMissed(string blockTag)
    {
        // Letting a bad block fall is the right move, so it costs nothing
        if (IsPlaying() && blockTag != "BadBlock")
        {
            LoseLife();
            Debug.Log($"Missed a {blockTag}. Lives: {lives}");
        }
    }

    void LoseLife()
    {
        lives--;

        if (lives <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        state = GameState.GameOver;
        Debug.Log($"GAME OVER! Final score: {score}. Press Space to play again");
    }
}
```

Read it before you move on:

- `BlockCaught` and `BlockMissed` start with a guard: if no game is running, they
  do nothing. Blocks still falling after game over can't cost lives.
- `LoseLife` and `EndGame` are **private**: no other script should be able to end
  the game directly.
- The `switch` has no `default`: any other tag is simply ignored.

### Do it — the spawner waits for the game

The Spawner should only drop blocks while a game is running. It needs a
**reference** to the game manager (C# 2) and one question:

1. In `Spawner.cs`, add this field above `blockPrefabs`:

```csharp
[SerializeField] GameManager gameManager;
```

2. Add this at the very top of the Spawner's `Update()`, before the timer line:

```csharp
if (!gameManager.IsPlaying())
{
    return;
}
```

3. Select `Spawner`. A new **Game Manager** slot has appeared in the Inspector.
   Drag the `GameManager` object from the Hierarchy into it.

> **Note:** dragging an object into a slot **is** setting the reference. The field
> now points at the game manager in this scene, just like
> `Spaceship sameShip = first;` in C# 2.

### Test it

Press **Play**. The Console says `Press Space to start`, and no blocks fall. Click
the Game view and press **Space**: `Game started! Lives: 3`, and the blocks
begin. Nothing is scored yet: the player and the floor don't report anything.
That's the next chapter.

> **Watch out:** if the Console shows *UnassignedReferenceException: The variable
> gameManager of Spawner has not been assigned*, the slot from step 3 is empty.
> This is the most common error in Unity: a reference nobody dragged in.

## Chapter 7 — Catching and Missing

**Goal:** catching a block scores it, a block that hits the floor costs a life,
and three lost lives end the game.

### Idea — Unity calls you when things touch

When a trigger collider touches another collider, Unity calls a method named
**`OnTriggerEnter2D`** on the scripts of both objects, if they have one. You don't
call it yourself: like `Start()` and `Update()`, Unity calls it for you.

```csharp
void OnTriggerEnter2D(Collider2D other)
{
    // "other" is the collider that touched this object
}
```

The parameter `other` is the thing you touched. From it you can read:

| Code | Gives you |
| --- | --- |
| `other.tag` | its tag: `"Block"`, `"GoldBlock"` or `"BadBlock"` |
| `other.gameObject` | the whole GameObject, for example to `Destroy` it |

> **Watch out:** the name and parameter must be exactly
> `OnTriggerEnter2D(Collider2D other)`. `OnTriggerEnter2d`, or the 3D
> `OnTriggerEnter(Collider other)`, compiles without errors and is **never
> called**.

### Idea — who reports what

| When a block touches… | That object's script | Calls | Then |
| --- | --- | --- | --- |
| the **Player** | `PlayerController` | `gameManager.BlockCaught(other.tag)` | destroys the block |
| the **Floor** | `Floor` | `gameManager.BlockMissed(other.tag)` | destroys the block |

Both scripts need a reference to the game manager, set by dragging, exactly like
the Spawner.

### Do it — catching

This is the finished `PlayerController.cs`. The new parts are the `gameManager`
field and `OnTriggerEnter2D` at the bottom:

```csharp:PlayerController.cs
using UnityEngine;
using UnityEngine.InputSystem;

// Slides the player bar left and right, and reports every block it touches.
// Attach this to the Player object.
public class PlayerController : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] float moveSpeed = 10f;   // units per second
    [SerializeField] float edge = 8.3f;       // how far left and right the bar can go

    void Update()
    {
        float direction = 0f;

        if (Keyboard.current.leftArrowKey.isPressed || Keyboard.current.aKey.isPressed)
        {
            direction = -1f;
        }
        if (Keyboard.current.rightArrowKey.isPressed || Keyboard.current.dKey.isPressed)
        {
            direction = 1f;
        }

        transform.Translate(direction * moveSpeed * Time.deltaTime, 0f, 0f);

        // Keep the bar on screen
        if (transform.position.x < -edge)
        {
            transform.position = new Vector3(-edge, transform.position.y, 0f);
        }
        if (transform.position.x > edge)
        {
            transform.position = new Vector3(edge, transform.position.y, 0f);
        }
    }

    // Runs when a block's trigger collider touches the bar
    void OnTriggerEnter2D(Collider2D other)
    {
        gameManager.BlockCaught(other.tag);
        Destroy(other.gameObject);
    }
}
```

Select `Player` and drag `GameManager` into its new **Game Manager** slot.

### Do it — missing

1. **GameObject → Create Empty**, named `Floor`, at **Position** `(0, -7.5, 0)`
   with **Scale** `(30, 1, 1)`: a wide strip below the bottom of the screen.
2. **Add Component → Box Collider 2D**. Leave **Is Trigger unticked**: the
   blocks are triggers already, so they still pass in and get reported.
3. Create the `Floor` script, attach it, and drag `GameManager` into its slot:

```csharp:Floor.cs
using UnityEngine;

// An invisible floor below the screen: every block that reaches it was missed.
// Attach this to the Floor object.
public class Floor : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

    // Runs when a block's trigger collider touches the floor
    void OnTriggerEnter2D(Collider2D other)
    {
        gameManager.BlockMissed(other.tag);
        Destroy(other.gameObject);
    }
}
```

The floor has no Sprite Renderer, so it's invisible in the game. Select it to see
its green collider outline in the Scene view.

### Test it

Press **Play**, then **Space**, and play:

```
Game started! Lives: 3
Caught a Block. Score: 1, lives: 3
Caught a GoldBlock. Score: 6, lives: 3
Missed a Block. Lives: 2
Caught a BadBlock. Score: 6, lives: 1
GAME OVER! Final score: 6. Press Space to play again
Missed a Block. Lives: 0
```

Your numbers will differ, but every catch and miss is reported. (The last miss is
printed just **after** `GAME OVER`: `LoseLife()` ends the game before
`BlockMissed` gets to its `Debug.Log`. Code runs in order.) After game over,
the blocks stop, and **Space** starts a new game.

> **You just built a game loop with rules:** input moves the player, a spawner
> creates things, physics reports touches, and a manager applies the rules. Almost
> every game has that same shape.

### If nothing happens when you catch a block

Work through this list in order:

1. Is there any Console output at all after pressing Space? If not, the problem is
   the `GameManager`, not catching.
2. Open the **Block** prefab: is **Is Trigger** ticked? Is there a **Rigidbody 2D**?
3. Does `Player` have a **Box Collider 2D**?
4. Is the method spelled `OnTriggerEnter2D(Collider2D other)` exactly?
5. Does the block's **tag** match the `case` text exactly, including capitals?

Notice that only one of those five checks is about code. In Unity, most "my code
doesn't work" problems are really setup problems.

### Challenge

Make **gold blocks worth 10** and **bad blocks cost 2 lives**. Which script and
which lines do you change? (Only one script needs to change.)

# Part 4 — Screen and Sound

## Chapter 8 — The Score on Screen

**Goal:** the score, the lives and the game's messages appear on screen, and a
**Play** button starts the game with a mouse click.

### Idea — the Canvas and the UI

Game objects live in the **world**; the score and buttons live on the **Canvas**,
a layer drawn over the camera's picture. Anything you create from **GameObject →
UI (Canvas)** goes on the Canvas.

| UI element | Component | Used for |
| --- | --- | --- |
| Text | **TextMeshPro - Text (UI)** (`TMP_Text` in code) | The score and the messages |
| Image | **Image** | The life icons |
| Button | **Button**, with a text child | The Play button |

The script reaches UI elements through references, just like the game manager:
`[SerializeField] TMP_Text scoreText;`, then `scoreText.text = "…";` changes what
it shows.

**Anchors** decide which corner of the screen an element sticks to. Anchor the
score to the top-left, and it stays in the top-left corner on any screen size.

**Showing the lives** uses an array and a loop (C# 3 and 4). Three icons sit in
the top-right corner. After every change, a `for` loop visits each icon and asks:
is this icon's index smaller than the number of lives?

```
lives = 2       icon 0: 0 < 2 → show     icon 1: 1 < 2 → show     icon 2: 2 < 2 → hide
```

`SetActive(true)` shows a GameObject, and `SetActive(false)` hides it.

**Buttons** call a public method when they're clicked. You connect the method in
the button's **On Click ()** list, with no code: that's the Play button calling
`StartGame()`.

### Do it — the texts

> **Note:** in some earlier Unity 6 versions, the **UI (Canvas)** menu is called
> just **UI**. The items inside it are the same.

1. **GameObject → UI (Canvas) → Text - TextMeshPro**. The first time, Unity asks to import
   **TMP Essentials**: click **Import TMP Essentials**, then close the window.
   Unity also creates a **Canvas** and an **EventSystem** for you.
2. Select **Canvas**. In **Canvas Scaler**, set **UI Scale Mode** to **Scale With
   Screen Size**, **Reference Resolution** to `1920 × 1080` and **Match** to
   `0.5`. The UI now grows and shrinks with the screen.
3. Rename the text `ScoreText`. In its **Rect Transform**, click the anchor square,
   hold **Shift + Alt** (**Shift + Option** on Mac), and click the **top-left**
   preset. Set **Pos X** `40`, **Pos Y** `-30`, **Width** `600`, **Height** `100`.
   Set the text to `Score: 0` and the **Font Size** to `56`.
4. Create a second text, `MessageText`: anchor **middle-center**, **Pos**
   `(0, 140)`, **Width** `1600`, **Height** `360`, **Font Size** `64`, and both
   **Alignment** buttons set to **center**.

### Do it — the button and the life icons

1. **GameObject → UI (Canvas) → Button - TextMeshPro**, renamed `PlayButton`: **Pos**
   `(0, -140)`, **Width** `320`, **Height** `110`. Set its **Image** colour to
   cyan (`#3DDCC8`). Expand it, select its **Text (TMP)** child, and set the text
   to `Play`, **Font Size** `56`, and the colour to navy (`#1E1A33`).
2. **GameObject → UI (Canvas) → Image**, renamed `LifeIcon1`: anchor **top-right** (with
   Shift + Alt), **Width** and **Height** `50`, colour `#FF4D6D`. Set **Pos** to
   `(-180, -40)`.
3. Duplicate it twice: `LifeIcon2` at `(-110, -40)` and `LifeIcon3` at
   `(-40, -40)`.

### Do it — the script

Replace `GameManager.cs` with this version. It adds `using TMPro;`, four UI
fields, and a new `UpdateScreen()` method, which every other method calls instead
of `Debug.Log`:

```csharp
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class GameManager : MonoBehaviour
{
    // The three states the game can be in
    enum GameState
    {
        Ready,
        Playing,
        GameOver
    }

    [SerializeField] int startingLives = 3;

    // Other objects in the scene: drag them in, in the Inspector
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text messageText;
    [SerializeField] GameObject playButton;
    [SerializeField] GameObject[] lifeIcons;

    GameState state = GameState.Ready;
    int score = 0;
    int lives = 0;

    void Start()
    {
        lives = startingLives;
        UpdateScreen();
    }

    void Update()
    {
        // Space starts a game, unless one is already running
        if (state != GameState.Playing && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            StartGame();
        }
    }

    // Called by the Play button, and by the Space key
    public void StartGame()
    {
        score = 0;
        lives = startingLives;
        state = GameState.Playing;
        UpdateScreen();
    }

    // Answers the question "is a game running right now?"
    public bool IsPlaying()
    {
        return state == GameState.Playing;
    }

    // Called by the Player when it catches a block
    public void BlockCaught(string blockTag)
    {
        if (!IsPlaying())
        {
            return;
        }

        switch (blockTag)
        {
            case "Block":
                score += 1;
                break;
            case "GoldBlock":
                score += 5;
                break;
            case "BadBlock":
                LoseLife();
                break;
        }

        UpdateScreen();
    }

    // Called by the Floor when a block falls past the player
    public void BlockMissed(string blockTag)
    {
        // Letting a bad block fall is the right move, so it costs nothing
        if (IsPlaying() && blockTag != "BadBlock")
        {
            LoseLife();
            UpdateScreen();
        }
    }

    void LoseLife()
    {
        lives--;

        if (lives <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        state = GameState.GameOver;
    }

    // Shows the score, the lives and the right message for the current state
    void UpdateScreen()
    {
        scoreText.text = $"Score: {score}";

        // One icon for each life left: show the first few, hide the rest
        for (int i = 0; i < lifeIcons.Length; i++)
        {
            lifeIcons[i].SetActive(i < lives);
        }

        switch (state)
        {
            case GameState.Ready:
                messageText.text = "Catch the Falling Blocks\nPress Space or click Play";
                playButton.SetActive(true);
                break;
            case GameState.Playing:
                messageText.text = "";
                playButton.SetActive(false);
                break;
            case GameState.GameOver:
                messageText.text = $"Game Over\nScore: {score}";
                playButton.SetActive(true);
                break;
        }
    }
}
```

### Do it — connect everything

1. Select `GameManager`, and drag into its slots: `ScoreText`, `MessageText`,
   `PlayButton`, and the three `LifeIcon`s into **Life Icons** (size `3`,
   `LifeIcon1` first).
2. Select `PlayButton`. At the bottom of its **Button** component, in **On Click
   ()**, click **+**, drag `GameManager` into the empty object slot, then choose
   **GameManager → StartGame ()** from the function dropdown.

> **Note:** only **public** methods appear in that dropdown. That's C# 1 at work:
> `StartGame` is public because the button calls it; `EndGame` is private, so it
> can't be picked.

### Test it

Press **Play**. The screen says *Catch the Falling Blocks*, with three red life
icons and a **Play** button. **Click Play**: the message and button disappear, and
the blocks start. Each catch updates the score; each miss removes an icon, from
the right. At zero, *Game Over* appears with your score, and the button comes
back. Space works too.

> **Watch out:** a *NullReferenceException* in `UpdateScreen` means one of the
> slots from "connect everything" is empty. Double-click the error: the line it
> opens tells you which reference is missing.

## Chapter 9 — Game Over and Play Again

**Goal:** game over clears the screen, the game remembers your best score and how
long you lasted, and the blocks get faster the longer you survive.

### Idea

Three problems remain:

1. After game over, the old blocks keep falling, and a new game starts with them
   still on screen.
2. The game doesn't remember your best score, or tell you how you did.
3. The blocks never get faster, so there's no challenge.

The fixes use `foreach` (C# 4), `?:` (C# 5) and number formatting (C# 6):

- **Clearing blocks:** every block is a child of the Spawner (Chapter 5). A
  `foreach` over the Spawner's `transform` visits each child, and destroys it.
- **Best score:** `isNewBest ? "New best…" : "Score… Best…"` picks the message.
- **Speeding up:** after each block, the delay shrinks a little, but never below
  a shortest delay.

### Do it — the finished spawner

This is the finished `Spawner.cs`. The new parts: `delay` is now worked out in
code from `startDelay`, each block makes the next one come sooner, and two public
methods, `Restart()` and `ClearBlocks()`, prepare for a new game and empty the
screen.

```csharp:Spawner.cs
using UnityEngine;

// Drops a random block from above the screen, a little faster each time.
// Attach this to the Spawner object.
public class Spawner : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

    // The blocks it can drop. Put a prefab in twice to drop it twice as often.
    [SerializeField] GameObject[] blockPrefabs;

    [SerializeField] float startDelay = 1.2f;      // seconds between blocks when a game starts
    [SerializeField] float shortestDelay = 0.45f;  // the fastest it will ever get
    [SerializeField] float speedUp = 0.02f;        // seconds cut from the delay after each block
    [SerializeField] float spawnWidth = 8.5f;      // blocks appear between -spawnWidth and +spawnWidth
    [SerializeField] float spawnHeight = 7f;       // just above the top of the screen

    float delay;
    float timer = 0f;

    void Update()
    {
        if (!gameManager.IsPlaying())
        {
            return;
        }

        timer += Time.deltaTime;

        if (timer >= delay)
        {
            timer = 0f;
            DropBlock();

            // Speed up a little, but never past the shortest delay
            if (delay > shortestDelay)
            {
                delay -= speedUp;
            }
        }
    }

    // Drops one random block at a random x position
    void DropBlock()
    {
        int index = Random.Range(0, blockPrefabs.Length);
        float x = Random.Range(-spawnWidth, spawnWidth);
        Vector3 position = new Vector3(x, spawnHeight, 0f);

        // The last argument makes the new block a child of this Spawner
        Instantiate(blockPrefabs[index], position, Quaternion.identity, transform);
    }

    // Gets ready for a new game: no blocks, and back to the starting speed
    public void Restart()
    {
        ClearBlocks();
        delay = startDelay;
        timer = 0f;
    }

    // Removes every block still falling (they are all children of this Spawner)
    public void ClearBlocks()
    {
        foreach (Transform block in transform)
        {
            Destroy(block.gameObject);
        }
    }
}
```

> **Note:** `foreach (Transform block in transform)` reads "for each child
> `block` of this object". A `Transform` can be looped over like an array: it
> hands you its children, one by one.

### Do it — the game manager

In `GameManager.cs`, make these changes:

1. Add a reference to the spawner with the other scene references:

```csharp
[SerializeField] Spawner spawner;
```

2. Add three fields under `int lives = 0;`:

```csharp
int bestScore = 0;
float timeSurvived = 0f;
string resultMessage = "";
```

3. Replace `Update()` so it also counts the seconds survived:

```csharp
void Update()
{
    if (state == GameState.Playing)
    {
        timeSurvived += Time.deltaTime;
    }
    else if (Keyboard.current.spaceKey.wasPressedThisFrame)
    {
        // Space starts a game, just like clicking the Play button
        StartGame();
    }
}
```

4. In `StartGame()`, add `timeSurvived = 0f;` under `lives = startingLives;`,
   and `spawner.Restart();` just before `UpdateScreen();`.

5. Replace `EndGame()`:

```csharp
void EndGame()
{
    state = GameState.GameOver;
    spawner.ClearBlocks();

    bool isNewBest = score > bestScore;
    if (isNewBest)
    {
        bestScore = score;
    }

    string scoreLine = isNewBest ? $"New best score: {score}!" : $"Score: {score}   Best: {bestScore}";
    resultMessage = $"{scoreLine}\nYou lasted {timeSurvived:F1} seconds";
}
```

6. In `UpdateScreen()`, change the `GameOver` case's message line to:

```csharp
messageText.text = $"Game Over\n{resultMessage}";
```

7. Select `GameManager` and drag `Spawner` into its new **Spawner** slot.

### Test it

Play a game until it ends. The screen clears at once, and shows your result:

```
Game Over
New best score: 14!
You lasted 38.4 seconds
```

Play again and score less: the message shows your score **and** your best. Notice
the blocks arrive faster the longer you survive.

> **Note:** the best score lives in a variable, so it resets when you stop the
> game. Saving it permanently (`PlayerPrefs`) is a Level 4 topic.

### Challenge

Show the seconds survived **during** the game, in the score text:
`Score: 12   Time: 23.5`. You only need to change one line, and call
`UpdateScreen()` somewhere it runs every frame while playing.

## Chapter 10 — Sound

**Goal:** catches, gold blocks, misses and game over each play their own sound.

### Idea

Sound in Unity takes two pieces:

| Piece | What it is | Like |
| --- | --- | --- |
| **Audio Clip** | a sound file in your project (`.wav`, `.mp3`, `.ogg`) | a song file |
| **Audio Source** | a component that plays clips | a speaker |

One Audio Source can play many clips. `audioSource.PlayOneShot(clip)` plays a clip
once, and doesn't cut off a sound that's already playing: exactly what you want
when two blocks are caught close together.

### Do it

1. Drag the four sound files (`Catch.wav`, `Gold.wav`, `Miss.wav` and
   `GameOver.wav`) into `Assets/Audio`.
2. Select `GameManager` → **Add Component → Audio Source**, and **untick Play On
   Awake**.
3. Replace `GameManager.cs` with the finished version below. The new parts are
   the five sound fields, and the `PlayOneShot` lines in `BlockCaught`,
   `LoseLife` and `EndGame`. `LoseLife` now picks a sound: the miss sound, unless
   that was the last life.

```csharp:GameManager.cs
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

// The brain of the game: it keeps the score, the lives and the game state,
// and shows them on screen. Attach this to the GameManager object.
public class GameManager : MonoBehaviour
{
    // The three states the game can be in
    enum GameState
    {
        Ready,
        Playing,
        GameOver
    }

    // ---- Rules ----
    [SerializeField] int startingLives = 3;

    // ---- Other objects in the scene: drag them in, in the Inspector ----
    [SerializeField] Spawner spawner;
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text messageText;
    [SerializeField] GameObject playButton;
    [SerializeField] GameObject[] lifeIcons;

    // ---- Sound ----
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip catchSound;
    [SerializeField] AudioClip goldSound;
    [SerializeField] AudioClip missSound;
    [SerializeField] AudioClip gameOverSound;

    // ---- The game's state: these change while the game runs ----
    GameState state = GameState.Ready;
    int score = 0;
    int lives = 0;
    int bestScore = 0;
    float timeSurvived = 0f;
    string resultMessage = "";

    void Start()
    {
        lives = startingLives;
        UpdateScreen();
    }

    void Update()
    {
        if (state == GameState.Playing)
        {
            timeSurvived += Time.deltaTime;
        }
        else if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            // Space starts a game, just like clicking the Play button
            StartGame();
        }
    }

    // Called by the Play button, and by the Space key
    public void StartGame()
    {
        score = 0;
        lives = startingLives;
        timeSurvived = 0f;
        state = GameState.Playing;
        spawner.Restart();
        UpdateScreen();
    }

    // Answers the question "is a game running right now?"
    public bool IsPlaying()
    {
        return state == GameState.Playing;
    }

    // Called by the Player when it catches a block
    public void BlockCaught(string blockTag)
    {
        if (!IsPlaying())
        {
            return;
        }

        switch (blockTag)
        {
            case "Block":
                score += 1;
                audioSource.PlayOneShot(catchSound);
                break;
            case "GoldBlock":
                score += 5;
                audioSource.PlayOneShot(goldSound);
                break;
            case "BadBlock":
                LoseLife();
                break;
        }

        UpdateScreen();
    }

    // Called by the Floor when a block falls past the player
    public void BlockMissed(string blockTag)
    {
        // Letting a bad block fall is the right move, so it costs nothing
        if (IsPlaying() && blockTag != "BadBlock")
        {
            LoseLife();
            UpdateScreen();
        }
    }

    void LoseLife()
    {
        lives--;

        if (lives > 0)
        {
            audioSource.PlayOneShot(missSound);
        }
        else
        {
            EndGame();
        }
    }

    void EndGame()
    {
        state = GameState.GameOver;
        spawner.ClearBlocks();
        audioSource.PlayOneShot(gameOverSound);

        bool isNewBest = score > bestScore;
        if (isNewBest)
        {
            bestScore = score;
        }

        string scoreLine = isNewBest ? $"New best score: {score}!" : $"Score: {score}   Best: {bestScore}";
        resultMessage = $"{scoreLine}\nYou lasted {timeSurvived:F1} seconds";
    }

    // Shows the score, the lives and the right message for the current state
    void UpdateScreen()
    {
        scoreText.text = $"Score: {score}";

        // One icon for each life left: show the first few, hide the rest
        for (int i = 0; i < lifeIcons.Length; i++)
        {
            lifeIcons[i].SetActive(i < lives);
        }

        switch (state)
        {
            case GameState.Ready:
                messageText.text = "Catch the Falling Blocks\nPress Space or click Play";
                playButton.SetActive(true);
                break;
            case GameState.Playing:
                messageText.text = "";
                playButton.SetActive(false);
                break;
            case GameState.GameOver:
                messageText.text = $"Game Over\n{resultMessage}";
                playButton.SetActive(true);
                break;
        }
    }
}
```

4. Select `GameManager` and fill the new slots: drag its own **Audio Source**
   component into **Audio Source** (or drag the `GameManager` object itself: Unity
   finds the component), and the four clips into their slots.

### Test it

Press **Play** and play a game with the sound on. Each event has its own sound: a
short blip for a catch, a bright three-note chime for gold, a low buzz for a miss,
and a falling tune at game over.

> **Tip:** sound is the cheapest polish there is. Two lines of code and four small
> files make the game feel twice as responsive.

### Challenge

Make each catch sound slightly different by changing the Audio Source's pitch
just before playing: `audioSource.pitch = Random.Range(0.9f, 1.1f);`. Where does
the line go?

## Chapter 11 — Ship It

**Goal:** a build of your game that runs outside Unity, published on itch.io
where anyone can play it in a browser.

### Idea

Until now, the game has only run inside the Unity editor. A **build** turns the
project into a stand-alone game:

| Platform | You get | Players need |
| --- | --- | --- |
| **Web** (WebGL) | a folder of web files | only a browser |
| **Windows / Mac** | an app | to download it |

A Web build uploaded to **itch.io** is the easiest way to share a game: send a
link, and anyone can play instantly. Your published games are your **portfolio**:
employers look at what you've shipped, far more than at certificates.

### Do it — the build

1. **File → Build Profiles**. Select **Web**. If Unity says the module isn't
   installed, click **Install with Unity Hub**, wait, and come back.
2. Click **Switch Platform** and wait for it to finish.
3. In **Scene List**, make sure `Scenes/Catch` is included and ticked (click
   **Add Open Scenes** if it's missing).
4. Open **Player Settings**: set the **Product Name** to `Catch the Falling
   Blocks`. Under **Publishing Settings**, set **Compression Format** to
   **Disabled**. It makes the upload a little bigger, but it works on itch.io
   without any server setup.
5. Click **Build**, create a new folder called `Builds/Web`, and wait.

### Do it — publish on itch.io

1. Zip the **contents** of `Builds/Web` (select the files inside the folder, not
   the folder itself), so `index.html` is at the top of the zip.
2. On itch.io, go to **Upload new project**, choose **Kind of project: HTML**,
   upload the zip, and tick **This file will be played in the browser**.
3. Set the **Viewport dimensions** to `960 × 600`, save, and open the page.

### Test it

Play your game in the browser, then send the link to someone else and watch them
play. Note everything they struggle with: that's your list for the challenge.

> **Note:** keyboard input goes to the game only after the player clicks it once.
> Your **Play** button makes that click happen naturally.

### Challenge

Build a **Windows** or **Mac** version too (switch the platform in Build Profiles),
and add it to your itch.io page as a download.

# Part 5 — Check Yourself

## Exam-style questions

These questions use the styles of the Unity certification exams. The **Level 2
entry test** uses them too. Answer on paper first, then check the answers.

**Q1.** What does this print?

```csharp
int[] laps = { 40, 38, 45 };
Debug.Log(laps[1] + laps.Length);
```

**Q2.** What does this print?

```csharp
for (int i = 0; i < 6; i += 2)
{
    Debug.Log(i);
}
```

**Q3.** What does this print?

```csharp
string[] names = { "Ali", "Maya", "Jo", "Sami" };
foreach (string n in names)
{
    if (n.Length < 3)
    {
        break;
    }
    Debug.Log(n);
}
```

**Q4.** What does this print?

```csharp
int lives = 0;
string text = lives > 0 ? "Keep going" : "Game over";
Debug.Log(text);
```

**Q5.** What does this print?

```csharp
float time = 7.86f;
int score = 12;
Debug.Log($"{score} points in {time:F1}s");
```

**Q6.** Which line causes an error, and what happens when it runs?

```csharp
int[] scores = new int[3];
scores[0] = 10;
scores[3] = 20;
```

**Q7.** This doesn't compile. What's missing?

```csharp
switch (state)
{
    case GameState.Ready:
        Debug.Log("Ready");
    case GameState.Playing:
        Debug.Log("Playing");
        break;
}
```

**Q8.** Which of these shows `speed` in the Inspector, but stops other scripts
from changing it?

- A. `float speed = 5f;`
- B. `public float speed = 5f;`
- C. `[SerializeField] float speed = 5f;`
- D. `[SerializeField] public float speed = 5f;`

**Q9.** A block has a Box Collider 2D with **Is Trigger** ticked, but no Rigidbody
2D. The player has a Box Collider 2D and no Rigidbody 2D. The block is moved onto
the player. What happens?

- A. `OnTriggerEnter2D` is called on both
- B. `OnCollisionEnter2D` is called on both
- C. Nothing: neither object has a Rigidbody 2D
- D. The block bounces off the player

**Q10.** Which values can `Random.Range(1, 4)` return?

**Q11.** Why is movement in `Update()` multiplied by `Time.deltaTime`?

**Q12.** The Console shows this message. `string blockTag`, `int score` and
`float time` exist. Write the line that printed it, using interpolation.

```
GoldBlock caught at 12.5s. Score: 30
```

**Q13.** Your script has `[SerializeField] float moveSpeed = 10f;`. You change the
code to `= 20f` and save, but the bar still moves at 10. Why, and how do you fix
it?

**Q14.** Which line reads "was the Space key pressed this frame?" in the older
Input Manager, as seen in many exam questions?

- A. `Input.GetKey(KeyCode.Space)`
- B. `Input.GetKeyDown(KeyCode.Space)`
- C. `Input.GetButton("Space")`
- D. `Keyboard.current.spaceKey.isPressed`

**Q15.** Which of these names follow the C# and Unity conventions? (Choose all
that apply.)

- A. a method `startGame()`
- B. a field `moveSpeed`
- C. a class `Spawner`
- D. a field `Best_Score`

## Answers

| Q | Answer | Why |
| --- | --- | --- |
| 1 | `41` | `laps[1]` is 38 (index 1 is the **second** element), plus `Length` 3. |
| 2 | `0`, `2`, `4` | `i += 2` steps by two; 6 fails `i < 6`. |
| 3 | `Ali`, `Maya` | "Jo" has 2 letters, so `break` ends the loop before Sami. |
| 4 | `Game over` | `lives > 0` is false, so `?:` picks the second value. |
| 5 | `12 points in 7.9s` | `F1` rounds 7.86 to one decimal place. |
| 6 | Line 3 | Valid indexes are 0–2. It compiles, but at runtime throws **IndexOutOfRangeException**. |
| 7 | A `break` | The first case falls through to the next: error CS0163. |
| 8 | C | Private (the default) plus `[SerializeField]`. B and D are public. |
| 9 | C | A touch is only reported when at least one object has a Rigidbody 2D. |
| 10 | `1`, `2` or `3` | With whole numbers, the maximum is excluded. |
| 11 | So speed is per **second**, not per frame | Every computer moves the same distance per second, whatever its frame rate. |
| 12 | `Debug.Log($"{blockTag} caught at {time:F1}s. Score: {score}");` | Fixed text first, then the holes. |
| 13 | The Inspector value wins | The code value is only a starting value. Change it in the Inspector, or right-click the component → Reset. |
| 14 | B | `GetKeyDown` is true only on the frame the key goes down; `GetKey` is true while held. |
| 15 | B, C | Methods and classes use PascalCase (`StartGame`); fields use camelCase with no underscores. |

## Level 1 cheat sheet

| Topic | Syntax |
| --- | --- |
| Show a private field in the Inspector | `[SerializeField] float speed = 5f;` |
| A method other scripts can call | `public void StartGame() { … }` |
| A reference to another script | `[SerializeField] GameManager gameManager;` then `gameManager.StartGame();` |
| Make an object from a class | `Spaceship ship = new Spaceship();` |
| Array | `int[] scores = { 3, 7 };` `scores[0]` `scores.Length` `new int[5]` |
| for loop | `for (int i = 0; i < scores.Length; i++) { … }` |
| foreach loop | `foreach (string name in names) { … }` |
| while loop | `while (fuel > 0) { … }` |
| Leave or skip | `break;` `continue;` |
| Enum | `enum GameState { Ready, Playing }` then `GameState.Ready` |
| switch | `switch (x) { case 1: … break; default: … break; }` |
| One-line choice | `string s = lives == 1 ? "life" : "lives";` |
| Interpolation | `$"Score: {score}"` |
| Number format | `$"{time:F1}"` (one decimal place) |
| New line in text | `"Line one\nLine two"` |
| Key held | `Keyboard.current.leftArrowKey.isPressed` |
| Key pressed this frame | `Keyboard.current.spaceKey.wasPressedThisFrame` |
| Per-second movement | `transform.Translate(speed * Time.deltaTime, 0f, 0f);` |
| New position | `transform.position = new Vector3(x, y, 0f);` |
| Random whole number | `Random.Range(0, 3)` (0, 1 or 2) |
| Random decimal | `Random.Range(-8.5f, 8.5f)` |
| Copy a prefab | `Instantiate(prefab, position, Quaternion.identity, transform);` |
| Remove an object | `Destroy(other.gameObject);` |
| Touch report | `void OnTriggerEnter2D(Collider2D other) { … other.tag … }` |
| Show / hide | `icon.SetActive(false);` |
| Change UI text | `scoreText.text = $"Score: {score}";` |
| Play a sound | `audioSource.PlayOneShot(clip);` |

## Before Level 2: can you…

Tick each one honestly. Level 2's entry test checks every line.

- Explain the difference between a field and a local variable, and say where each
  can be used?
- Choose between `private`, `public` and `[SerializeField]` for a field, and
  explain why?
- Explain what a class and an object are, and build an object with `new`?
- Create an array, read and change elements by index, and avoid an
  IndexOutOfRangeException?
- Write `for`, `foreach` and `while` loops, and use `break` and `continue`?
- Create an enum and use it in a `switch`?
- Build text with interpolation, `\n` and a number format like `F1`?
- Read the keyboard, and move an object at the same speed on any computer?
- Set up a Rigidbody 2D and colliders, and explain triggers versus collisions?
- Create a prefab, and `Instantiate` and `Destroy` objects in code?
- Connect scripts with Inspector references, and a button with **On Click ()**?
- Build your game for the Web and publish it?

*End of Level 1 — next up, Level 2, where your scripts learn to find each other, wait, animate and react to the mouse and touch.*
