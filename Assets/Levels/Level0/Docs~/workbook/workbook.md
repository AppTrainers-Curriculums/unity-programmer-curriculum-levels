---
title: "Rocket Launch"
subtitle: "Your First Code: C# and Unity from Zero"
author: "Unity Programmer Curriculum  ·  Level 0"
coverEyebrow: "Level 0 · Learn to Code · Make Games"
coverTop: "Rocket"
coverRed: "Launch"
coverSub: "Your first C# code and your first Unity scene: a countdown, a liftoff and a flight to orbit."
coverPill: "Level 0 Workbook"
coverCaption: "Two small scripts · one scene · no coding experience needed"
coverArt: rocket
---

# Part 0 — Before You Start

## What you're going to build

A **rocket launch**. A rocket stands on a launch pad. When you press Play, mission
control prints a briefing, a countdown ticks down in the Console, the rocket lifts
off and climbs through the atmosphere, and the mission ends in **orbit**, or in
failure if the fuel runs out first.

There are **no controls**. You are not the pilot, you are the programmer. Every
decision the rocket makes, you wrote. Change a number in your code, press Play,
and a different mission happens.

This is **Level 0**. You need no coding experience and you've never opened Unity.
By the end you will have written every line of two real scripts, and you'll
understand all of them.

## How this book works

This book has **two kinds of chapters**, and you read them in the order they
appear:

| Chapter | Colour | What it does |
| --- | --- | --- |
| **Chapter 1, 2, 3…** | Red | **Build** the game in Unity, step by step. |
| **C# Concept 1, 2, 3…** | Slate | **Learn** one C# idea, with examples to try. |

Each C# Concept comes **just before** the build chapter that needs it. You learn
an idea, then use it straight away in the game.

Every chapter follows the same beats:

- **Goal** — what works, or what you can do, when you finish the chapter.
- **Idea** — the concept, in plain language.
- **Do it** — the exact steps and code to type.
- **Test it** — press Play and check the result.
- **Challenge** — an optional twist to try on your own.

Under many C# examples you'll see a grey box showing what appears in Unity's
**Console** when the code runs. Read the code, **predict** the output, then check.
Predicting before you look is the fastest way to learn.

> **Tip:** type the code yourself instead of copying it. Your fingers learn the
> syntax faster than your eyes, and the typos you make (and fix) are part of the
> lesson.

## The route through Level 0

| Step | Chapter | You learn | You build |
| --- | --- | --- | --- |
| 1 | Chapter 1 | The Unity editor | — |
| 2 | Chapter 2 | GameObjects, sprites, the Transform | The rocket and launch pad |
| 3 | C# Concepts 1–3 | Programs, scripts, comments | — |
| 4 | Chapter 3 | — | Your first script |
| 5 | C# Concepts 4–6 | Variables, operators, `if` / `else` | — |
| 6 | Chapter 4 | — | The mission briefing |
| 7 | Chapter 5 | The game loop | The countdown |
| 8 | C# Concept 7 | Methods | — |
| 9 | Chapter 6 | — | Liftoff |
| 10 | C# Concept 8 | Parameters | — |
| 11 | Chapter 7 | — | The flight |
| 12 | C# Concepts 9–10 | `else if`, return values | — |
| 13 | Chapters 8–9 | — | Stages, fuel and the mission result |
| 14 | C# Concept 11 | Reading errors | — |
| 15 | Chapter 10 | — | Break it on purpose |
| 16 | Part 5 | Exam-style practice | — |

Part 5 has exam-style questions. **Level 1 starts with a test** on exactly these
topics, so treat Part 5 as your practice run.

## For trainers: running a session

Each session follows the route above and splits roughly into three:

| Share | Activity | From |
| --- | --- | --- |
| About 20% | **Concept:** teach the C# idea. Students predict each example's Console output before you run it. | C# Concept chapters |
| About 60% | **Build:** students follow the chapter in Unity, and press Play at every checkpoint. | Build chapters |
| About 20% | **Practice:** the **Do it** exercises, in class or as homework. | C# Concept chapters |

Chapters 1 and 2 are pure Unity, with no code yet. From Chapter 3 onward, every
build chapter is preceded by the C# it needs. Part 5 is the rehearsal for the
**Level 1 entry test**; a student who can tick every line of the final checklist
is ready for it.

## The pieces we'll build

The whole game is **two scripts**, each with one job:

```
MissionBriefing ── prints the mission details once, when the game starts
Rocket ─────────── counts down, lifts off, climbs, and reports the result
```

## If you've played the browser version

Some of you started with **Catch the Falling Blocks** as a single HTML page, and
changed the numbers in its `TUNE` section. You've already met two ideas from this
book:

| In the browser page | In this book |
| --- | --- |
| `playerSpeed: 300` in `TUNE` | a **variable**: a named value you can change |
| `function update(dt)` running again and again | Unity's **`Update()`**, the game loop |
| `dt`, the seconds since the last frame | **`Time.deltaTime`** |

## The four words you need

| Word | What it means |
| --- | --- |
| **Scene** | The room. Everything that exists in your game right now. |
| **GameObject** | A thing in the room: the rocket, the launch pad, the camera. |
| **Component** | A part bolted onto a GameObject: its picture, its colour, your script. |
| **Inspector** | The panel that shows a GameObject's components and their values. |

## One-time project setup

- **Unity 6**, with a project created from the **2D (URP)** template. The scene
  it starts with already has a **Global Light 2D**: keep it, because without a
  light, sprites in a URP 2D scene render black.
- A code editor: **Visual Studio Code** (with the **Unity** extension) or
  **Visual Studio**. Chapter 1 connects it to Unity.
- Every script you write lives in `Assets/Scripts/`.

# Part 1 — The Editor and the Launch Pad

## Chapter 1 — Meet the Editor

**Goal:** you can name every main window in Unity, say what it's for, and open
your scripts in your own code editor.

### Idea

Unity's editor is a set of **windows**, each with one job. You'll use six of them
all the time:

| Window | What it's for |
| --- | --- |
| **Scene** | Where you build: move, rotate and resize things in your world. |
| **Game** | What the player sees, through the camera. This is where Play happens. |
| **Hierarchy** | A list of every GameObject in the scene. Children sit indented under their parent. |
| **Inspector** | The components and values of whatever you've selected. |
| **Project** | Every file in your project: scripts, sprites, scenes. |
| **Console** | Messages from your code, and errors when something is wrong. |

Above them sits the **toolbar** with the **Play**, **Pause** and **Step** buttons.

### Do it — find your windows

1. Open your project in Unity 6.
2. Click each of the six windows above, one at a time, and say out loud what it
   is for.
3. If the **Console** isn't visible, open it: **Window → General → Console**.
   Drag its tab next to the Project window so it's always in view.

### Do it — choose your code editor

Unity doesn't edit code itself. It hands your scripts to a **code editor**.

1. Open the settings: **Unity → Settings** on Mac, or **Edit → Preferences** on
   Windows.
2. Go to **External Tools**.
3. Set **External Script Editor** to **Visual Studio Code** (or Visual Studio).

> **Note:** if Visual Studio Code isn't in the list, choose **Browse…** and find
> it, and check that the **Visual Studio Editor** package is installed
> (**Window → Package Manager**).

### Test it

Name the window that answers each question, without looking back:

- Where do I see what the player sees? *(Game)*
- Where do I see my error messages? *(Console)*
- Where do I change an object's position? *(Inspector)*
- Where is every file in my project? *(Project)*

## Chapter 2 — Build the Rocket

**Goal:** a rocket standing on a launch pad against a dark sky, built from simple
shapes and seen through the camera.

### Idea

Every GameObject has a **Transform**, and you can't remove it. It holds three
values, each with an X, Y and Z:

| Value | Meaning in a 2D game |
| --- | --- |
| **Position** | Where it is. X is left–right, Y is up–down. Z stays `0`. |
| **Rotation** | How far it's turned. In 2D, only **Z** is used, in degrees. |
| **Scale** | How big it is. `1` is normal size, `2` is double. |

We'll build the rocket from Unity's ready-made **sprites** (flat 2D shapes): white
squares and circles, tinted and stretched. Then we'll make them **children** of
one empty GameObject called `Rocket`. When the parent moves, every child moves
with it. That's what lets one script fly the whole rocket.

When sprites overlap, **Order in Layer** decides which one is drawn on top:
higher numbers are drawn in front.

### Do it — save the scene

**File → Save As**, and save the scene as `Assets/Scenes/Launch.unity`. It
already contains a **Main Camera** and a **Global Light 2D**.

### Do it — the rocket

1. **GameObject → Create Empty**. Rename it `Rocket` (slow double-click its name
   in the Hierarchy). Set its **Position** to `(0, 0, 0)`.
2. Create each part with **GameObject → 2D Object → Sprites → Square** (or
   **Circle**), rename it, and set its values in the **Inspector**. The colour and
   **Order in Layer** are in the **Sprite Renderer** component.

| Name | Sprite | Position | Rotation | Scale | Color | Order in Layer |
| --- | --- | --- | --- | --- | --- | --- |
| `Body` | Square | `(0, 1.5, 0)` | `(0, 0, 0)` | `(1, 3, 1)` | `#F5F3FF` | `1` |
| `Nose` | Circle | `(0, 3, 0)` | `(0, 0, 0)` | `(1, 1, 1)` | `#EF4050` | `0` |
| `Window` | Circle | `(0, 2.2, 0)` | `(0, 0, 0)` | `(0.45, 0.45, 1)` | `#3DDCC8` | `2` |
| `Fin Left` | Square | `(-0.6, 0.5, 0)` | `(0, 0, -20)` | `(0.4, 1, 1)` | `#EF4050` | `0` |
| `Fin Right` | Square | `(0.6, 0.5, 0)` | `(0, 0, 20)` | `(0.4, 1, 1)` | `#EF4050` | `0` |

3. In the Hierarchy, drag `Body`, `Nose`, `Window`, `Fin Left` and `Fin Right`
   **onto** `Rocket`. They become indented under it: they're now its children.

> **Tip:** the `Nose` is a full circle, but the `Body` has a higher Order in Layer,
> so it covers the bottom half. Only the dome on top shows. Layering shapes like
> this is how you make new shapes without drawing anything.

> **Watch out:** after parenting, a child's Position is measured from the
> **parent**, not from the centre of the world. Because `Rocket` sits at
> `(0, 0, 0)`, the numbers stay the same this time.

### Do it — the pad, the ground and the sky

1. Two more squares, **not** children of `Rocket`:

| Name | Position | Scale | Color | Order in Layer |
| --- | --- | --- | --- | --- |
| `Launch Pad` | `(0, -0.15, 0)` | `(4, 0.3, 1)` | `#6B6F7B` | `-1` |
| `Ground` | `(0, -2.3, 0)` | `(40, 4, 1)` | `#2E2A45` | `-2` |

2. Select **Main Camera**: set **Position** to `(0, 7, -10)`, **Size** to `9`,
   and the **Background** colour (under **Environment**) to a dark navy,
   `#1E1A33`.
3. **GameObject → Create Empty**, named `MissionControl`. It stays invisible:
   it's just a place to put the briefing script in Chapter 4.
4. Save the scene (**Ctrl/Cmd + S**).

> **Note:** a camera's **Size** is half of the height it can see, in Unity units.
> Size `9` at a height of `7` shows everything from `y = -2` up to `y = 16`: room
> for the whole flight.

### Test it

Press **Play**. The **Game** window shows the rocket standing on its pad against
the dark sky. Nothing moves yet, because nothing has told it to. Press **Play**
again to stop.

> **Tip:** select `Rocket` in the Hierarchy and drag the green (Y) arrow in the
> Scene window. The whole rocket moves together: that's parenting. Press
> **Ctrl/Cmd + Z** to put it back at `(0, 0, 0)`.

### Challenge

Add a flame under the rocket: an orange circle, squashed with its Scale, with an
Order in Layer that puts it behind the body. Keep it a child of `Rocket`.

# Part 2 — Your First Code

## C# 1 — What a Program Is

**Goal:** you can explain what a program is, and predict the order in which lines
of code run.

### Idea — instructions in order

A program is a list of **instructions** that the computer follows **in order**,
from top to bottom, one line at a time. The computer never guesses what you
meant. It does exactly what you wrote, nothing more and nothing less.

Every program, from a calculator to a game, has the same shape:

| Input | Process | Output |
| --- | --- | --- |
| Information comes in | The program works on it | A result comes out |
| The player presses a key | Move the player left | The player appears further left |
| The countdown is at 3 | Subtract 1 | Show `2` |
| Two prices | Add them together | Show the total |

### Idea — seeing the order

`Debug.Log("...")` prints a message in the **Console**. Because lines run in
order, messages appear in the order you wrote them:

```csharp
Debug.Log("1. Mission control is online");
Debug.Log("2. Checking the rocket");
Debug.Log("3. Ready for countdown");
```

```
1. Mission control is online
2. Checking the rocket
3. Ready for countdown
```

Swap the first and last lines, and the output order changes too:

```csharp
Debug.Log("3. Ready for countdown");
Debug.Log("2. Checking the rocket");
Debug.Log("1. Mission control is online");
```

```
3. Ready for countdown
2. Checking the rocket
1. Mission control is online
```

### Idea — programs in Unity

In Unity, your code runs inside **methods** that Unity calls for you:

| Method | When Unity runs it | Good for |
| --- | --- | --- |
| `Start()` | **Once**, when the game starts | Setting things up, printing a briefing |
| `Update()` | **Every frame**, dozens of times a second | Anything that changes over time: movement, timers |

That repeating `Update()` is the **game loop**: every frame, your code changes
something a little, and Unity draws the new picture.

```csharp
void Start()
{
    Debug.Log("This prints once");
}

void Update()
{
    Debug.Log("This prints every frame");
}
```

```
This prints once
This prints every frame
This prints every frame
This prints every frame
... (forever, until you stop the game)
```

> **Tip:** in the Console, the **Collapse** button groups identical messages into
> one line with a counter. Turn it on when `Update()` floods the Console.

### Do it — your practice script

You'll try the C# examples in a **practice script**, separate from the game.
Create the folder `Assets/Scripts`, right-click it → **Create → MonoBehaviour
Script**, and name it `Practice`. Create an empty GameObject called `Practice`,
and drag the script onto it. Make the script look like this:

```csharp
using UnityEngine;

public class Practice : MonoBehaviour
{
    void Start()
    {
        // Put the example you are trying here
    }
}
```

Put any example from a C# Concept inside `Start()`, press **Play**, and read the
Console. Replace what's inside `Start()` each time.

1. Print your name, then your city, then your favourite game, each on its own
   line.
2. Predict the output before pressing Play. Then reorder the lines and predict
   again.

## C# 2 — Anatomy of a Script

**Goal:** you can name every part of a new Unity script and say what it does.

### Idea

When you create a script in Unity (**Create → MonoBehaviour Script**), you get a
file like this:

```csharp
using UnityEngine;

public class Rocket : MonoBehaviour
{
    // Start is called once before the first Update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
```

You don't need to understand every word yet. Here's what matters:

| Part | What it means |
| --- | --- |
| `using UnityEngine;` | Lets your script use Unity's tools, such as `Debug.Log`. |
| `public class Rocket` | The script's name. It **must match the file name**: `Rocket.cs`. |
| `: MonoBehaviour` | Makes it a Unity script you can attach to a GameObject. |
| `void Start()` / `void Update()` | Two methods Unity calls for you (C# 1). |
| `{ }` | Curly braces mark where a block of code starts and ends. |
| `;` | Ends an instruction, like a full stop ends a sentence. |
| `// ...` | A comment: a note for humans (C# 3). |

### Idea — braces and blocks

Every `{` needs a matching `}`. What sits between them is a **block**, and blocks
can sit inside other blocks. Indenting each block (moving it right) shows you
where it belongs:

```
public class Rocket : MonoBehaviour     ← the class
{                                        ← class block starts
    void Start()                         ← a method inside the class
    {                                    ← method block starts
        Debug.Log("Hello");              ← an instruction inside the method
    }                                    ← method block ends
}                                        ← class block ends
```

> **Watch out:** if the file name and class name differ (`rocket.cs` and
> `class Rocket`, say), Unity can't attach the script. Keep them identical,
> including capital letters. This is the most common first error there is.

> **Watch out:** C# is **case-sensitive**. `Debug.Log` works. `debug.log`,
> `Debug.log` and `DEBUG.LOG` don't exist.

### Do it

Create a new script called `Spaceship`. Before opening it, write down on paper
what its first lines will look like. Then open it and compare. (You can delete it
afterwards.)

## C# 3 — Comments

**Goal:** you can write comments, and tell a useful comment from a useless one.

### Idea

A **comment** is a note for humans. The computer skips it completely.

```csharp
// A single-line comment: everything after // is ignored

/* A multi-line comment.
   Everything between the two markers is ignored. */

int fuel = 100; // A comment can also sit at the end of a line
```

Good comments explain **what** code does or **why** it's there. They don't just
repeat the code in words:

| Code | Weak comment | Good comment |
| --- | --- | --- |
| `fuel = fuel - 1;` | `// fuel equals fuel minus 1` | `// Burn one unit of fuel each frame` |
| `if (height >= 12)` | `// if height is 12 or more` | `// Did the rocket reach orbit?` |
| `lives = 3;` | `// lives is 3` | `// Every new game starts with 3 lives` |

### Idea — commenting out

Putting `//` in front of a line switches it off without deleting it. This is
called **commenting out**:

```csharp
Debug.Log("Engine check");
// Debug.Log("Fuel check");
Debug.Log("Ready");
```

```
Engine check
Ready
```

> **Tip:** in VS Code, select lines and press **Ctrl + /** (**Cmd + /** on Mac)
> to comment them out, or back in, all at once.

### Do it

Take any three lines of code from these chapters and write a **good** comment for
each: one that explains the purpose, not the syntax.

## Chapter 3 — Hello, Mission Control

**Goal:** your first game script prints a message in the Console when the game
starts.

### Idea

You've met the pieces in C# 1–3: a script is a class, `Start()` runs once, and
`Debug.Log` prints to the Console. Now you'll write the first script of the actual
game and attach it to the `MissionControl` object.

### Do it — create the script

In `Assets/Scripts`, right-click → **Create → MonoBehaviour Script**, and name it
`MissionBriefing`. Double-click it to open it in your code editor.

Unity gives you a starting file. Delete the `Update()` part (we don't need it
here) and make it look like this:

```csharp
using UnityEngine;

public class MissionBriefing : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Mission control is online");
    }
}
```

Save the file, go back to Unity, and drag `MissionBriefing` from the Project
window onto `MissionControl` in the Hierarchy.

> **Tip:** you can switch the practice script off while you work on the game:
> select the `Practice` GameObject and untick the checkbox next to its name at the
> top of the Inspector.

### Test it

Press **Play**. The Console shows `Mission control is online`.

Now add two more lines under the first one, and press Play again:

```csharp
Debug.Log("Checking the rocket");
Debug.Log("Ready for countdown");
```

Three messages, always in the order you wrote them. Swap two lines and press Play:
the order changes, because the order of the instructions changed.

### Challenge

Add a comment above each `Debug.Log` line that explains **why** mission control
would print it. Then comment out the middle line and check the Console.

## C# 4 — Variables and Types

**Goal:** you can create variables of the four basic types, change them, and name
them well.

### Idea — a named box

A **variable** is a named box that holds a value. You can look inside the box,
and you can replace what's in it.

```csharp
int countdown = 5;
```

This one line does three things:

| Part | Meaning |
| --- | --- |
| `int` | The **type**: what kind of value fits in the box. |
| `countdown` | The **name** of the box. |
| `= 5` | Puts `5` into the box. This is called **assignment**. |

### Idea — the four basic types

| Type | Holds | Examples |
| --- | --- | --- |
| `int` | Whole numbers (no decimal point) | `5`, `0`, `-12`, `1000` |
| `float` | Numbers with a decimal point | `3.5f`, `0.25f`, `-9.8f` |
| `bool` | Only `true` or `false` | `true`, `false` |
| `string` | Text, always in double quotes | `"Falcon"`, `"Player 1"`, `""` |

```csharp
int crewSize = 3;
float speed = 2.5f;
bool isLaunched = false;
string rocketName = "Falcon";

Debug.Log(crewSize);
Debug.Log(speed);
Debug.Log(isLaunched);
Debug.Log(rocketName);
```

```
3
2.5
False
Falcon
```

> **Note:** Unity prints `bool` values with a capital letter: `True` and `False`.

**Which type should I use?** Ask what the value *is*:

| Value | Type | Why |
| --- | --- | --- |
| Number of lives | `int` | You can't have half a life |
| Player speed | `float` | Speed can be 2.5 |
| Is the game paused? | `bool` | It's a yes/no question |
| Player's name | `string` | It's text |
| Score | `int` | Points are whole numbers |
| Health from 0 to 100, going down smoothly | `float` | It changes by fractions |

### Idea — changing a variable

Once a variable exists, you change it **without** writing the type again:

```csharp
int countdown = 5;         // create it: type, name, value
Debug.Log(countdown);

countdown = 4;             // replace the value
Debug.Log(countdown);

countdown = countdown - 1; // read the current value, subtract 1, store it back
Debug.Log(countdown);
```

```
5
4
3
```

`countdown = countdown - 1` looks strange at first. Read it right to left: *take
countdown, subtract 1, and put the answer back in countdown.*

> **Watch out:** writing the type again creates a **second** variable with the
> same name, which is an error: `int countdown = 4;` after `int countdown = 5;`
> doesn't compile.

### Idea — naming variables

- Start with a **lowercase** letter and capitalise each new word: `rocketSpeed`,
  `secondsLeft`, `isGameOver`. This style is called **camelCase**.
- Say what the value **means**: `fuel` beats `f`, and `targetHeight` beats
  `number2`.
- A `bool` reads best as a yes/no question: `isLaunched`, `hasKey`, `canJump`.
- No spaces, no symbols (except `_`), and don't start with a digit.

| Name | OK? | Why |
| --- | --- | --- |
| `playerScore` | Yes | camelCase, clear meaning |
| `PlayerScore` | Works, but not the style | Capital first letter is for classes and methods |
| `player score` | No | Spaces aren't allowed |
| `2ndPlayer` | No | Can't start with a digit |
| `x` | Works, but unclear | What does `x` mean? |

> **Watch out:** a `float` value needs an `f` on the end: `2.5f`. Without it,
> `float speed = 2.5;` gives an error, because C# treats `2.5` as a different
> number type (`double`).

> **Watch out:** `"5"` in quotes is **text**. `5` without quotes is a **number**.
> `int lives = "5";` is an error: you can't put text in a number box.

### Do it

1. Create one variable of each type to describe **yourself**: your age, your
   height in metres, whether you like coffee, and your name. Print all four.
2. Change your age to next year's, using the variable itself
   (`age = age + 1;`), and print it again.

### Challenge

Describe a game character with at least six variables, choosing the right type for
each. Swap with a classmate and check each other's choices.

## C# 5 — Operators

**Goal:** you can do maths, join text, compare values and combine true/false
answers.

### Idea — arithmetic

| Operator | Meaning | Example | Result |
| --- | --- | --- | --- |
| `+` | Add | `7 + 2` | `9` |
| `-` | Subtract | `7 - 2` | `5` |
| `*` | Multiply | `7 * 2` | `14` |
| `/` | Divide | `7 / 2` | `3` (see below) |
| `%` | Remainder after dividing | `7 % 2` | `1` |

```csharp
int crew = 3;
int suppliesPerPerson = 2;
int totalSupplies = crew * suppliesPerPerson;
Debug.Log(totalSupplies);

float fuel = 100f;
float burnPerSecond = 12.5f;
Debug.Log(fuel / burnPerSecond);
```

```
6
8
```

**Order of operations** is the same as in maths: `*` and `/` before `+` and `-`.
Use brackets to change it:

```csharp
Debug.Log(2 + 3 * 4);     // 3 * 4 first
Debug.Log((2 + 3) * 4);   // brackets first
```

```
14
20
```

> **Watch out:** dividing one `int` by another throws away the decimal part:
> `7 / 2` is `3`, not `3.5`. If you need the decimal, make one of them a float:
> `7f / 2` is `3.5`.

**`%` (remainder)** answers "what's left over?". It's great for "every Nth time"
and for even/odd checks:

```csharp
Debug.Log(10 % 3);   // 10 = 3 + 3 + 3, remainder 1
Debug.Log(8 % 2);    // 8 is even, remainder 0
Debug.Log(9 % 2);    // 9 is odd, remainder 1
```

```
1
0
1
```

### Idea — shortcuts

Changing a variable using its own value is so common that C# has shortcuts:

| Long way | Shortcut | Meaning |
| --- | --- | --- |
| `score = score + 5;` | `score += 5;` | Add 5 |
| `fuel = fuel - 10;` | `fuel -= 10;` | Subtract 10 |
| `speed = speed * 2;` | `speed *= 2;` | Double it |
| `lives = lives + 1;` | `lives++;` | Add 1 |
| `countdown = countdown - 1;` | `countdown--;` | Subtract 1 |

### Idea — joining text

The `+` operator also **joins text** (strings) together. Numbers joined to text
become text:

```csharp
string rocketName = "Falcon";
int countdown = 3;
Debug.Log("Rocket " + rocketName + " launches in " + countdown + " seconds");
```

```
Rocket Falcon launches in 3 seconds
```

Watch the spaces: they must be **inside** the quotes, or the words run together.

```csharp
Debug.Log("Rocket" + rocketName);    // no space inside the quotes
```

```
RocketFalcon
```

> **Watch out:** C# works left to right. `"Total: " + 5 + 5` prints `Total: 55`,
> because the text joins with 5, and then with 5 again. To add first, use
> brackets: `"Total: " + (5 + 5)` prints `Total: 10`.

### Idea — comparison

A comparison asks a question, and the answer is always a `bool`: `true` or
`false`.

| Operator | Question | Example | Result |
| --- | --- | --- | --- |
| `==` | Equal? | `3 == 3` | `true` |
| `!=` | Not equal? | `3 != 3` | `false` |
| `>` | Greater than? | `5 > 2` | `true` |
| `<` | Less than? | `5 < 2` | `false` |
| `>=` | Greater than or equal? | `5 >= 5` | `true` |
| `<=` | Less than or equal? | `4 <= 5` | `true` |

```csharp
int fuel = 30;
Debug.Log(fuel > 50);
Debug.Log(fuel <= 30);
Debug.Log(fuel != 0);
```

```
False
True
True
```

Strings can be compared with `==` and `!=` too: `"Space" == "Space"` is `true`,
and `"space" == "Space"` is `false` (capital letters matter).

> **Watch out:** one `=` **stores** a value. Two `==` **compare** values.
> `countdown = 0` sets countdown to zero; `countdown == 0` asks "is countdown
> zero?". Mixing them up is one of the most common beginner mistakes.

### Idea — logic: and, or, not

Logic operators combine `bool` values:

| Operator | Name | `true` when… | Example |
| --- | --- | --- | --- |
| `&&` | AND | **both** sides are true | `hasFuel && isReady` |
| `\|\|` | OR | **at least one** side is true | `outOfFuel \|\| engineBroken` |
| `!` | NOT | flips `true` ↔ `false` | `!isLaunched` |

All four combinations, side by side:

| `a` | `b` | `a && b` | `a \|\| b` | `!a` |
| --- | --- | --- | --- | --- |
| true | true | true | true | false |
| true | false | false | true | false |
| false | true | false | true | true |
| false | false | false | false | true |

```csharp
bool hasFuel = true;
bool weatherIsClear = false;

Debug.Log(hasFuel && weatherIsClear);   // both needed
Debug.Log(hasFuel || weatherIsClear);   // one is enough
Debug.Log(!weatherIsClear);             // the opposite
```

```
False
True
True
```

You can combine comparisons with logic, too:

```csharp
int fuel = 80;
int crew = 3;
Debug.Log(fuel >= 50 && crew > 0);
```

```
True
```

### Do it

1. A shop sells 3 potions at 12 coins each. Calculate the total with variables and
   print `Total: 36 coins`.
2. Predict, then check: `17 / 5`, `17 % 5`, `17f / 5`.
3. With `int age = 20;` and `bool hasTicket = false;`, print whether the person
   can enter: they need to be 18 or older **and** have a ticket.

### Challenge

Use `%` to print whether a number stored in a variable is even: `True` if it is,
`False` if it isn't. (Hint: compare the remainder with `0`.)

## C# 6 — Decisions: if and else

**Goal:** you can make your code choose between paths with `if` and `else`.

### Idea — if

An `if` runs its block **only when** its condition is `true`:

```csharp
int fuel = 0;

if (fuel <= 0)
{
    Debug.Log("Out of fuel!");
}

Debug.Log("Check complete");
```

```
Out of fuel!
Check complete
```

With `fuel = 50`, the condition is `false`, the block is skipped, and only
`Check complete` prints.

### Idea — if / else

`else` gives you a second path, for when the condition is `false`. Exactly one of
the two blocks runs, never both, never neither:

```csharp
int countdown = 0;

if (countdown == 0)
{
    Debug.Log("Liftoff!");
}
else
{
    Debug.Log("T-minus " + countdown);
}
```

```
Liftoff!
```

### Idea — conditions with logic

Any expression that gives a `bool` can be a condition, including `&&`, `||` and
`!`:

```csharp
bool weatherIsClear = true;
float fuelTons = 12.5f;

if (weatherIsClear && fuelTons >= 10)
{
    Debug.Log("GO for launch");
}
else
{
    Debug.Log("NO GO");
}
```

```
GO for launch
```

A `bool` variable is already true or false, so you can use it directly:
`if (isLaunched)` means "if it's launched", and `if (!isLaunched)` means "if it's
**not** launched yet".

### Idea — an if inside an if

Blocks can hold other blocks, so an `if` can sit inside another `if`:

```csharp
bool isLaunched = false;
int secondsLeft = 0;

if (!isLaunched)
{
    if (secondsLeft > 0)
    {
        Debug.Log("Counting down");
    }
    else
    {
        Debug.Log("Launch now!");
    }
}
```

```
Launch now!
```

> **Watch out:** never put a semicolon straight after the condition.
> `if (fuel <= 0);` ends the `if` right there, and the block below it then runs
> **every** time. Unity only shows a yellow warning, so this bug is easy to miss.

### Do it

1. With `int fuel`, print `Ready` if fuel is 20 or more, otherwise `Refuel`. Test
   it with 50, 20 and 5.
2. With `bool hasKey` and `bool doorIsOpen`, print `Walk in` if the door is open,
   otherwise `Use the key` if the player has one, otherwise `Locked out`. (You'll
   need an `if` inside an `else`.)

## Chapter 4 — The Mission Briefing

**Goal:** the briefing prints the rocket's name, crew, fuel and supplies, and
decides on its own whether the launch is GO.

### Idea

This chapter puts C# 4–6 to work: four variables (one of each type), a
calculation, text joined with numbers, and an `if` / `else` that decides whether
the launch can go ahead. The condition uses `&&`: the weather must be clear
**and** there must be enough fuel.

### Do it

Replace everything in `MissionBriefing.cs` with the finished script:

```csharp:MissionBriefing.cs
using UnityEngine;

// Prints the mission briefing in the Console when the game starts.
// Attach this to the MissionControl object.
public class MissionBriefing : MonoBehaviour
{
    // Start runs once, when the game starts
    void Start()
    {
        // The mission details: one variable of each basic type
        string rocketName = "Falcon";
        int crewSize = 3;
        float fuelTons = 12.5f;
        bool weatherIsClear = true;

        Debug.Log("=== MISSION BRIEFING ===");
        Debug.Log("Rocket: " + rocketName);
        Debug.Log("Crew: " + crewSize + " astronauts");
        Debug.Log("Fuel: " + fuelTons + " tons");

        // Each astronaut needs 2 tons of supplies
        int suppliesTons = crewSize * 2;
        Debug.Log("Supplies: " + suppliesTons + " tons");

        // The launch can only go ahead in clear weather with enough fuel
        if (weatherIsClear && fuelTons >= 10)
        {
            Debug.Log("Status: GO for launch");
        }
        else
        {
            Debug.Log("Status: NO GO, launch delayed");
        }
    }
}
```

### Test it

Press **Play**. The Console shows the full briefing, ending in
`Status: GO for launch`.

Now change `weatherIsClear` to `false` and press Play again: **NO GO**. Put it
back to `true`, and change `fuelTons` to `8.5f`: **NO GO** again, because `&&`
needs both conditions. You just changed the program's decision without touching
the `if`.

### Challenge

Add a `string launchSite = "Wadi Rum";` and print it. Then change the `&&` to
`||` and predict, before pressing Play, which combinations of weather and fuel now
give GO.

# Part 3 — Countdown and Liftoff

## Chapter 5 — The Countdown

**Goal:** after pressing Play, the Console counts down one second at a time.

### Idea — the game loop

`Start()` runs once. **`Update()`** runs **every frame**, again and again, for as
long as the game runs (C# 1). Each run is a tiny step: change something a little,
then Unity draws the new picture.

Frames aren't evenly spaced: a fast computer might draw 120 frames a second, a
slow one 40. So to count **seconds**, we use `Time.deltaTime`: the number of
seconds since the last frame. Adding it up every frame gives us a stopwatch:

```
frame 1   timer = 0.016
frame 2   timer = 0.033
  ...
frame 60  timer = 1.001   → one second has passed: reset timer, count down
```

We'll use `Time.deltaTime` as a ready-made tool for now. Level 1 explains it in
full.

### Do it

Create a new script, `Rocket`, in `Assets/Scripts`, and drag it onto the
**`Rocket`** parent object (not onto `Body`). Make it look like this:

```csharp
using UnityEngine;

public class Rocket : MonoBehaviour
{
    int countdownSeconds = 5;
    int secondsLeft;
    float timer = 0f;

    void Start()
    {
        secondsLeft = countdownSeconds;
        Debug.Log("Countdown started: T-minus " + secondsLeft);
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 1f)
        {
            timer = 0f;
            secondsLeft--;
            Debug.Log("T-minus " + secondsLeft);
        }
    }
}
```

Read it before you move on:

- The variables at the top belong to the **whole script**, so both `Start()` and
  `Update()` can use them. `secondsLeft` has no value yet; `Start()` gives it one.
- `timer += Time.deltaTime;` and `secondsLeft--;` are the shortcuts from C# 5.

### Test it

Press **Play** and watch the Console: `T-minus 5`, `T-minus 4` … one per second.
Keep watching: after `T-minus 0` it keeps going: `-1`, `-2`, `-3`. The computer
did **exactly** what you wrote, and you never told it to stop. Chapter 6 fixes
that.

### Challenge

Change `countdownSeconds` to `10`. Then make the countdown twice as fast by
changing a single number in `Update()`.

## C# 7 — Methods

**Goal:** you can write your own methods and call them.

### Idea — a named job

A **method** is a named block of code that does one job. You write it once and
**call** it by name whenever you need that job done:

```csharp
void Start()
{
    Launch();    // call the method: its code runs now
    Debug.Log("After launch");
}

void Launch()
{
    Debug.Log("Engines on");
    Debug.Log("LIFTOFF!");
}
```

```
Engines on
LIFTOFF!
After launch
```

When C# reaches `Launch();`, it jumps into `Launch`, runs all of it, then comes
back and carries on from the next line.

| Part | Meaning |
| --- | --- |
| `void` | The method does its job and gives nothing back. |
| `Launch` | The name. Method names start with a **capital** letter (**PascalCase**). |
| `()` | Brackets for parameters. This one has none (C# 8). |
| `{ }` | The method's body: the code that runs when it's called. |

Methods go **inside the class** but **outside other methods**, next to `Start()`.
`Start()` and `Update()` are methods too. The only difference is that Unity calls
them for you.

### Idea — why methods?

- **Names explain code.** `Launch();` tells you what happens without reading how.
- **Write once, use many times.** Call it from three places, fix it in one.
- **Small pieces are easier to test and fix.**

### Idea — leaving a method early

`return;` ends a `void` method straight away. Nothing after it in that method
runs:

```csharp
void CheckEngine()
{
    Debug.Log("Checking engine");
    return;
    Debug.Log("This line never runs");
}
```

It's useful at the top of a method, inside an `if`: "if there's nothing to do,
stop here".

### Do it

1. Write a method `void PrintLine()` that prints `----------`. Call it three
   times from `Start()`, with a `Debug.Log` of your name between the calls.
2. Write `void Countdown()` that prints `3`, `2`, `1`, `Go!`, and call it from
   `Start()`.

## Chapter 6 — Liftoff

**Goal:** the countdown stops at zero and the rocket launches.

### Idea

We'll move the countdown into its own method, `RunCountdown()`, and add a
`Launch()` method (C# 7). A `bool` called `isLaunched` remembers whether we've
launched, and `Update()` only runs the countdown while `!isLaunched`: "not
launched yet" (C# 5 and 6).

### Do it

Update `Rocket.cs`:

```csharp
using UnityEngine;

public class Rocket : MonoBehaviour
{
    int countdownSeconds = 5;
    int secondsLeft;
    float timer = 0f;
    bool isLaunched = false;

    void Start()
    {
        secondsLeft = countdownSeconds;
        Debug.Log("Countdown started: T-minus " + secondsLeft);
    }

    void Update()
    {
        if (!isLaunched)
        {
            RunCountdown();
        }
    }

    // Counts down one second at a time, then launches
    void RunCountdown()
    {
        timer += Time.deltaTime;

        if (timer >= 1f)
        {
            timer = 0f;
            secondsLeft--;

            if (secondsLeft > 0)
            {
                Debug.Log("T-minus " + secondsLeft);
            }
            else
            {
                Launch();
            }
        }
    }

    void Launch()
    {
        isLaunched = true;
        Debug.Log("LIFTOFF!");
    }
}
```

### Test it

Press **Play**: `T-minus 5` … `T-minus 1`, then `LIFTOFF!`, and nothing after it.
Once `isLaunched` is `true`, `!isLaunched` is `false`, so `Update()` stops calling
`RunCountdown()`.

> **You just used a `bool` as memory.** The rocket "remembers" it has launched by
> keeping `true` in a variable. Games are full of these: `isAlive`, `isPaused`,
> `hasKey`.

## C# 8 — Parameters

**Goal:** you can pass information into a method.

### Idea

Some methods need information to do their job. A **parameter** is a variable in
the method's brackets that gets its value from the call:

```csharp
void BurnFuel(int amount)
{
    Debug.Log("Burning " + amount + " fuel");
}

void Start()
{
    BurnFuel(10);
    BurnFuel(25);
}
```

```
Burning 10 fuel
Burning 25 fuel
```

The first call sets `amount` to `10`; the second sets it to `25`. The value you
pass in the call is called an **argument**.

Several parameters are separated by commas, and the call gives them **in the same
order**:

```csharp
void Report(string rocketName, int crew)
{
    Debug.Log(rocketName + " is carrying " + crew + " astronauts");
}

Report("Falcon", 3);
```

```
Falcon is carrying 3 astronauts
```

### Idea — you've been using them already

`Debug.Log("Hello")` is a method call with one argument: the text to print. Unity
has thousands of ready-made methods, and many take arguments. In the next chapter
you'll use `transform.Translate(x, y, z)`, which takes three.

> **Watch out:** the arguments must match the parameters in **number**, **order**
> and **type**. `Report(3, "Falcon")` is an error: the text and the number are
> the wrong way round.

### Do it

1. Write `void Greet(string name)` that prints `Hello, <name>!`. Call it three
   times with different names.
2. Write `void ShowScore(string player, int score)` and call it for two players.

## Chapter 7 — Flight

**Goal:** after liftoff the rocket climbs steadily, and stops when it reaches
orbit.

### Idea

`transform.Translate(x, y, z)` moves this GameObject by the three amounts you pass
it (C# 8):

```csharp
transform.Translate(0f, climbSpeed * Time.deltaTime, 0f);
```

X = `0` (no sideways move), Y = up by `climbSpeed × deltaTime`, Z = `0`. Because
we multiply by `Time.deltaTime`, `climbSpeed = 2` means **2 units every second**
on any computer.

`transform` is this GameObject's Transform: the same Position you set in the
Inspector. `transform.position.y` reads its current height.

### Do it

1. Add three variables under `bool isLaunched = false;`:

```csharp
float climbSpeed = 2f;
float orbitHeight = 12f;
bool missionOver = false;
```

2. Replace `Update()` with this version:

```csharp
void Update()
{
    if (missionOver)
    {
        return;
    }

    if (!isLaunched)
    {
        RunCountdown();
    }
    else
    {
        Fly();
    }
}
```

3. Add a new method under `Launch()`:

```csharp
void Fly()
{
    transform.Translate(0f, climbSpeed * Time.deltaTime, 0f);

    if (transform.position.y >= orbitHeight)
    {
        missionOver = true;
        Debug.Log("ORBIT REACHED!");
    }
}
```

`return;` (C# 7) ends `Update()` straight away. Once `missionOver` is `true`,
`Update()` stops at its first line and does nothing, every frame, forever.

### Test it

Press **Play**. After `LIFTOFF!` the rocket rises from the pad and stops at a
height of 12 with `ORBIT REACHED!`. While it flies, select `Rocket` and watch its
**Position Y** climb in the Inspector: that's the number your code is changing.

> **Tip:** if the rocket leaves the top of the Game view, raise the camera's
> **Size** a little, or lower `orbitHeight`.

### Challenge

Make the rocket **drift** slightly sideways as it climbs, by changing just one of
the three numbers in `Translate`.

# Part 4 — The Mission

## C# 9 — More Paths: else if

**Goal:** you can choose between many paths, and put the conditions in the right
order.

### Idea

Use `else if` to check several conditions **in order**:

```csharp
float height = 7f;

if (height >= 10f)
{
    Debug.Log("Space");
}
else if (height >= 6f)
{
    Debug.Log("Upper atmosphere");
}
else if (height >= 2f)
{
    Debug.Log("Lower atmosphere");
}
else
{
    Debug.Log("Launch pad");
}
```

```
Upper atmosphere
```

C# checks each condition from the top and runs **only the first one that is
true**. At height 7, `height >= 10f` is false, `height >= 6f` is true, so it
prints "Upper atmosphere" and skips everything below, even though `7 >= 2` is
also true.

The final `else` (with no condition) catches everything that didn't match. It's
optional.

> **Watch out:** order matters. Put the **strictest** condition first. If
> `height >= 2f` came first, a rocket at height 11 would print "Lower
> atmosphere", because 11 is also more than 2 and C# stops at the first match.

### Do it

1. With an `int score` variable, print a grade: `A` for 90 or more, `B` for 80 or
   more, `C` for 70 or more, otherwise `Try again`. Test it with 95, 85, 72 and
   40.
2. Swap the order of your conditions so the `>= 70` check comes first. Predict
   what goes wrong, then test it.

### Challenge

A door opens if the player **has the key**, **or** if they have **at least 3
coins and** the guard is asleep. Write the variables and the `if` for it, and
test all the combinations you can think of.

## C# 10 — Return Values

**Goal:** you can write a method that calculates an answer and gives it back.

### Idea

A method can work something out and **return** the answer. Instead of `void`,
write the **type** of the answer before the name:

```csharp
int Add(int a, int b)
{
    return a + b;
}

void Start()
{
    int total = Add(3, 4);
    Debug.Log(total);
    Debug.Log(Add(10, 20));
}
```

```
7
30
```

`Add(3, 4)` is replaced by its answer, `7`, which is then stored in `total`. You
can use a method call anywhere you could use a value.

A method can return any type, and can make decisions before returning:

```csharp
string GetStage(float height)
{
    if (height >= 10f)
    {
        return "Space";
    }
    return "Atmosphere";
}

bool CanLaunch(float fuel, bool weatherIsClear)
{
    return fuel >= 10 && weatherIsClear;
}
```

`return` sends the answer back and **ends the method immediately**. Nothing after
it in that method runs.

> **Watch out:** a method with a return type must return a value on **every**
> path. If one path of an `if` has no `return`, you get the error *not all code
> paths return a value*.

### Idea — void or a return type?

| Question | Use |
| --- | --- |
| Does the method **do** something (print, move, change a variable)? | `void` |
| Does it **answer a question** or **calculate** something? | A return type: `int`, `float`, `bool`, `string` |

### Do it

1. Write `float Double(float value)` that returns the value times 2. Print
   `Double(3.5f)`.
2. Write `bool IsEven(int number)` that returns `true` for even numbers (C# 5
   challenge). Test it with 4 and 7.

### Challenge

Turn your grade code from C# 9 into `string GetGrade(int score)`, which returns
`A`, `B`, `C` or `Try again`, and call it for four different scores in `Start()`.

## Chapter 8 — Stages of Flight

**Goal:** the Console announces each stage of the flight (lower atmosphere, upper
atmosphere, space) exactly once.

### Idea

`GetStageName` uses an `else if` chain (C# 9) inside a method that returns a
`string` (C# 10):

```csharp
string GetStageName(float height)
{
    if (height >= 10f)
    {
        return "Space";
    }
    else if (height >= 6f)
    {
        return "Upper atmosphere";
    }
    else if (height >= 2f)
    {
        return "Lower atmosphere";
    }
    return "Launch pad";
}
```

To announce each stage **once**, we remember the current stage in a `string` and
only print when the new one is different: `!=` means **not equal**.

### Do it

1. Add a variable with the others: `string currentStage = "Launch pad";`
2. Add `GetStageName` (above) and this method to the script:

```csharp
// Prints a message only when the rocket enters a new stage
void CheckStage(float height)
{
    string stage = GetStageName(height);

    if (stage != currentStage)
    {
        currentStage = stage;
        Debug.Log("Now entering: " + stage);
    }
}
```

3. Update `Fly()` so it checks the stage every frame:

```csharp
void Fly()
{
    transform.Translate(0f, climbSpeed * Time.deltaTime, 0f);

    float height = transform.position.y;
    CheckStage(height);

    if (height >= orbitHeight)
    {
        missionOver = true;
        Debug.Log("ORBIT REACHED!");
    }
}
```

### Test it

Press **Play**. During the climb, three messages appear, each exactly once:
`Now entering: Lower atmosphere`, `Upper atmosphere`, `Space`.

Now comment out the line `currentStage = stage;` and press Play. The Console floods
with the same message every frame. Put the line back: that one line is the
"remember" part.

## Chapter 9 — Fuel and Mission Result

**Goal:** the rocket burns fuel as it climbs, and the mission ends in success
(orbit) or failure (out of fuel).

### Idea

Fuel goes down every frame while the rocket climbs: `fuel -= burnRate *
Time.deltaTime;`, the same per-second trick as the movement. Each frame we then
check two ways the mission can end, **in order**:

1. Reached orbit? → success.
2. Otherwise, out of fuel? → failure.

One method, `EndMission(bool success)`, handles both endings. The `bool`
parameter tells it which one happened.

### Do it

This is the finished `Rocket.cs`. Compare it with yours: the new parts are the
two fuel variables, the fuel line in `Fly()`, the `else if` in `Fly()` and
`EndMission()`. The tuning numbers are grouped at the top.

```csharp:Rocket.cs
using UnityEngine;

// Counts down, launches the rocket and flies it to orbit.
// Attach this to the Rocket object.
public class Rocket : MonoBehaviour
{
    // ---- Tune these numbers, then press Play ----
    int countdownSeconds = 5;   // seconds before liftoff
    float climbSpeed = 2f;      // how fast the rocket climbs (units per second)
    float orbitHeight = 12f;    // the height where the mission is complete
    float fuel = 100f;          // fuel in the tank at liftoff
    float burnRate = 10f;       // fuel burned every second while climbing

    // ---- The rocket's state: these change while the game runs ----
    int secondsLeft;
    float timer = 0f;
    bool isLaunched = false;
    bool missionOver = false;
    string currentStage = "Launch pad";

    // Start runs once, when the game starts
    void Start()
    {
        secondsLeft = countdownSeconds;
        Debug.Log("Countdown started: T-minus " + secondsLeft);
    }

    // Update runs every frame
    void Update()
    {
        // Once the mission is over, there is nothing left to do
        if (missionOver)
        {
            return;
        }

        if (!isLaunched)
        {
            RunCountdown();
        }
        else
        {
            Fly();
        }
    }

    // Counts down one second at a time, then launches
    void RunCountdown()
    {
        timer += Time.deltaTime;

        if (timer >= 1f)
        {
            timer = 0f;
            secondsLeft--;

            if (secondsLeft > 0)
            {
                Debug.Log("T-minus " + secondsLeft);
            }
            else
            {
                Launch();
            }
        }
    }

    void Launch()
    {
        isLaunched = true;
        Debug.Log("LIFTOFF!");
    }

    // Moves the rocket up, burns fuel and checks how the mission is going
    void Fly()
    {
        transform.Translate(0f, climbSpeed * Time.deltaTime, 0f);
        fuel -= burnRate * Time.deltaTime;

        float height = transform.position.y;
        CheckStage(height);

        if (height >= orbitHeight)
        {
            EndMission(true);
        }
        else if (fuel <= 0f)
        {
            EndMission(false);
        }
    }

    // Prints a message only when the rocket enters a new stage
    void CheckStage(float height)
    {
        string stage = GetStageName(height);

        if (stage != currentStage)
        {
            currentStage = stage;
            Debug.Log("Now entering: " + stage);
        }
    }

    // Returns the name of the stage for a given height
    string GetStageName(float height)
    {
        if (height >= 10f)
        {
            return "Space";
        }
        else if (height >= 6f)
        {
            return "Upper atmosphere";
        }
        else if (height >= 2f)
        {
            return "Lower atmosphere";
        }
        return "Launch pad";
    }

    // Ends the mission and reports how it went
    void EndMission(bool success)
    {
        missionOver = true;

        if (success)
        {
            Debug.Log("ORBIT REACHED! Mission success. Fuel left: " + fuel);
        }
        else
        {
            Debug.Log("OUT OF FUEL at height " + transform.position.y + ". Mission failed.");
        }
    }
}
```

### Test it

Press **Play**. The rocket reaches orbit with about `40` fuel left: 6 seconds of
climbing at 10 fuel per second is 60 fuel burned.

Now plan a **failed** mission on paper first, then test it: set `burnRate` to
`20f`. How many seconds until the tank is empty? How high is the rocket by then?
Press Play and check your answer against the Console.

> **Note:** you'll see numbers like `40.00001` instead of `40`. Computers store
> decimals with tiny rounding errors, so `float` values are almost never perfectly
> round. Level 1 shows you how to print them neatly.

> **You just built a complete program:** it takes starting values, runs a loop,
> makes decisions every frame, remembers what happened, and reports a result.
> Every game you'll write has that same shape, with more of each.

### Challenge

When the mission **fails**, make the rocket fall back down instead of freezing in
the air. You'll need a new `bool`, a new branch in `Update()`, and a `Translate`
with a negative number.

## C# 11 — Reading Errors

**Goal:** you can read a Console error, find the line it points to, and fix the
five most common beginner errors.

### Idea — errors are normal

Every developer sees errors every day. The skill isn't avoiding them; it's
**reading** them. When your code has a mistake, Unity shows a **red** message in
the Console and won't let you press Play until it's fixed:

```
Assets/Scripts/Rocket.cs(71,26): error CS1002: ; expected
```

| Part | Meaning |
| --- | --- |
| `Assets/Scripts/Rocket.cs` | The file with the problem |
| `(71,26)` | Line 71, character 26 |
| `CS1002` | The error code: you can search for it online |
| `; expected` | What C# expected to find there |

> **Tip:** double-click the error in the Console, and your code editor opens on
> the exact line.

### Idea — the five errors you'll see most

**1. `; expected` (CS1002)** — a missing semicolon.

```csharp
int fuel = 100
Debug.Log(fuel);
```

Fix: `int fuel = 100;`

**2. `The name '…' does not exist in the current context` (CS0103)** — a typo in
a name, or a variable that was never created.

```csharp
int fuel = 100;
Debug.Log(fule);
```

Fix: spell it exactly as it was created: `fuel`.

**3. `Cannot implicitly convert type 'string' to 'int'` (CS0029)** — the value's
type doesn't match the variable's type.

```csharp
int fuel = "100";
```

Fix: remove the quotes, `int fuel = 100;`, or change the type if it really is
text.

**4. `Literal of type double cannot be implicitly converted to type 'float'`
(CS0664)** — a float value without its `f`.

```csharp
float speed = 2.5;
```

Fix: `float speed = 2.5f;`

**5. `not all code paths return a value` (CS0161)** — a method with a return
type misses a `return` on some path.

```csharp
string GetStatus(int fuel)
{
    if (fuel > 0)
    {
        return "Ready";
    }
}
```

Fix: add a return for the other path, such as `return "Empty";` before the
last `}`.

### Idea — how to fix errors like a professional

1. Fix the **first** error in the list first. One mistake can cause several
   errors, and fixing the first often clears the rest.
2. Look at the line it points to, **and the line above**. A missing semicolon is
   often reported on the **next** line.
3. Read the message word by word. It usually says exactly what's wrong.
4. Change one thing, save, and check the Console again.

> **Note:** **red** messages are errors: the code won't run. **Yellow** messages
> are warnings: the code runs, but something looks suspicious. Read warnings too.

## Chapter 10 — Break It on Purpose

**Goal:** you can recognise each common error on sight, in your own game code.

### Idea

In C# 11 you met the five most common errors. Now you'll cause each one yourself,
in `Rocket.cs`, and read what Unity tells you. Recognising an error on sight is
worth more than memorising syntax.

### Do it

Make each mistake below, **one at a time**. Save, read the error in the Console,
then undo it before trying the next.

| Break it like this | The error you'll see | Why |
| --- | --- | --- |
| Delete the `;` after `isLaunched = true` | `; expected` (CS1002) | Every instruction needs its semicolon |
| In `Fly()`, write `fule` instead of `fuel` | `The name 'fule' does not exist in the current context` (CS0103) | A typo is a different name to C# |
| Change `2f` to `2.5` in `float climbSpeed = 2f;` | `Literal of type double cannot be implicitly converted to type 'float'` (CS0664) | A float value needs its `f` |
| Change `int countdownSeconds = 5;` to `= "5";` | `Cannot implicitly convert type 'string' to 'int'` (CS0029) | Text can't go in a number box |
| Delete `return "Launch pad";` in `GetStageName` | `not all code paths return a value` (CS0161) | A `string` method must always return a string |

### Test it

One last break, and the sneakiest. In `Update()`, add a semicolon right after the
condition: `if (missionOver);`. There's no red error, only a **yellow warning**.
Press Play and see what happens to the rocket. Can you explain why? *(Answer in
Part 5, question 8.)*

# Part 5 — Check Yourself

## Exam-style questions

These questions use the same styles as the Unity certification exams, and the
**Level 1 entry test**. Answer on paper first, then check the answers.

**Q1.** What does this print?

```csharp
int a = 10;
int b = 4;
Debug.Log(a / b);
```

**Q2.** What does this print?

```csharp
Debug.Log("Stage " + 1 + 2);
```

**Q3.** What does this print?

```csharp
bool hasFuel = true;
bool engineOn = false;
Debug.Log(hasFuel && !engineOn);
```

**Q4.** What does this print?

```csharp
int height = 60;
if (height >= 10)
{
    Debug.Log("Low");
}
else if (height >= 50)
{
    Debug.Log("High");
}
```

**Q5.** What does this print?

```csharp
int Triple(int x)
{
    return x * 3;
}

void Start()
{
    int result = Triple(4) + 1;
    Debug.Log(result);
}
```

**Q6.** What does this print?

```csharp
int lives = 3;
lives--;
lives += 5;
Debug.Log("Lives: " + lives);
```

**Q7.** Which line causes an error, and why?

```csharp
int fuel = 100;
float speed = 3.5;
string rocketName = "Falcon";
```

**Q8.** In Chapter 10 you wrote `if (missionOver);` in `Update()`. There's only a
yellow warning, but the rocket never lifts off. Why?

**Q9.** Which error does this method cause?

```csharp
string GetStatus(int fuel)
{
    if (fuel > 0)
    {
        return "Ready";
    }
}
```

**Q10.** Which comment best describes `secondsLeft--;`?

- A. `// secondsLeft minus minus`
- B. `// One more second has passed, so one less before liftoff`
- C. `// Launch the rocket`

**Q11.** The variables `string rocketName = "Falcon";` and `int crewSize = 3;`
exist. Write the one line of code that printed exactly:

```
Falcon is carrying 3 astronauts
```

**Q12.** Which type fits each value best: (a) the number of coins, (b) whether
the door is locked, (c) the player's walking speed, (d) the level's name?

**Q13.** Which window would you use to (a) see your error messages, (b) change an
object's Scale, (c) find a script file?

**Q14.** A rocket should print "Launch" when `fuel` is more than 50 **and**
`weatherIsClear` is true. Fill in the condition: `if ( ______ )`

## Answers

| Q | Answer | Why |
| --- | --- | --- |
| 1 | `2` | Both are `int`, so the `.5` of 2.5 is thrown away. |
| 2 | `Stage 12` | Left to right: `"Stage " + 1` is text, then `+ 2` joins `"2"`. |
| 3 | `True` | `hasFuel` is true and `!engineOn` is true; `&&` needs both. |
| 4 | `Low` | 60 is `>= 10`, so the first block runs and the rest is skipped. |
| 5 | `13` | `Triple(4)` returns 12, plus 1. |
| 6 | `Lives: 7` | 3, minus 1 is 2, plus 5 is 7. |
| 7 | Line 2 | `3.5` needs an `f`: `3.5f` (error CS0664). |
| 8 | The `;` ends the `if` | `if (missionOver);` does nothing, so `return;` below it runs **every** frame and `Update()` always stops there. |
| 9 | *not all code paths return a value* (CS0161) | When `fuel` is 0 or less, nothing is returned. |
| 10 | B | It explains the purpose. A repeats the code; C is wrong. |
| 11 | `Debug.Log(rocketName + " is carrying " + crewSize + " astronauts");` | Mind the spaces inside the quotes. |
| 12 | (a) `int` (b) `bool` (c) `float` (d) `string` | Whole number, yes/no, decimal, text. |
| 13 | (a) Console, (b) Inspector, (c) Project | See Chapter 1. |
| 14 | `fuel > 50 && weatherIsClear` | `&&` means both must be true. |

## Level 0 cheat sheet

| Topic | Syntax |
| --- | --- |
| Print to the Console | `Debug.Log("text");` |
| Comments | `// note` and `/* note */` |
| Create variables | `int lives = 3;` `float speed = 2.5f;` `bool isAlive = true;` `string name = "Sam";` |
| Change a variable | `lives = 2;` `lives -= 1;` `lives--;` `timer += Time.deltaTime;` |
| Arithmetic | `+` `-` `*` `/` `%` |
| Join text | `"Score: " + score` |
| Comparison | `==` `!=` `>` `<` `>=` `<=` |
| Logic | `&&` (and) `\|\|` (or) `!` (not) |
| Decisions | `if (…) { } else if (…) { } else { }` |
| Method, no answer | `void Launch() { … }` and call it with `Launch();` |
| Method with a parameter | `void CheckStage(float height) { … }` then `CheckStage(5f);` |
| Method with an answer | `string GetStageName(float h) { return "Space"; }` |
| Leave a method early | `return;` |
| Runs once | `void Start() { }` |
| Runs every frame | `void Update() { }` |
| Move this object | `transform.Translate(x, y, z);` |
| Read its height | `transform.position.y` |

## Before Level 1: can you…

Tick each one honestly. Level 1's entry test checks every line.

- Name the six main editor windows and say what each is for?
- Set your external script editor?
- Create a script, fix its name, and attach it to a GameObject?
- Explain the difference between `Start()` and `Update()`?
- Create an `int`, a `float`, a `bool` and a `string`, and change them?
- Predict what a `Debug.Log` line prints, including text joined with numbers?
- Write an `if` / `else if` / `else`, and explain why their order matters?
- Write a method with a parameter, and one that returns a value?
- Read a Console error and find the line it points to?

*End of Level 0 — next up, Level 1: Catch the Falling Blocks, where the player takes the controls.*
