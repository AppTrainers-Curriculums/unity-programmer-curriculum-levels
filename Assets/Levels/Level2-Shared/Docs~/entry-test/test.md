---
title: "Level 2 Entry Test"
subtitle: "C# and Unity: everything in Level 1"
author: "Unity Programmer Curriculum  ·  Level 2 Entry Test"
coverEyebrow: "Level 2 Entry Test · Unity Programmer Curriculum"
coverTop: "Level 2"
coverRed: "Entry Test"
coverSub: "A written paper and a practical task on everything in Level 1. Pass both to start Level 2."
coverPill: "Student Paper"
coverCaption: "Written paper: 40 minutes · Practical task: 75 minutes"
coverArt: code
coverCode: level1
footer: "Level 2 Entry Test  ·  Student Paper"
---

## Section 1 — Before You Begin

**Goal:** show that you can do everything in Level 1, so you're ready for Level 2.

### How the test works

| Part | Time | Marks | To pass |
| --- | --- | --- | --- |
| **Written paper:** 20 questions | 40 minutes | 20 | 14 or more |
| **Practical task:** build a small game from a description | 75 minutes | 100 | 70 or more |

You need to pass **both** parts. If you've come from Level 1, this is its final
check. If you already know some C# and Unity, passing lets you start straight at
Level 2.

### Rules

- **Written paper:** closed book. Write your answers in the spaces. Your trainer
  collects it before handing out the practical task.
- **Practical task:** you may use Unity, your code editor, and the printed **Level 1
  cheat sheet**. No other notes, websites, AI tools or code from earlier projects.
- Read each question to the end before answering. Several questions look like
  ones you've seen, with one detail changed.

Name: ______________________________ Date: ________________

## Section 2 — Written Paper

**Goal:** answer all 20 questions in 40 minutes. Each is worth 1 mark.

### Physics, prefabs and builds

**Q1.** A coin has a **Circle Collider 2D** with **Is Trigger** ticked, and a
**Rigidbody 2D** with a Gravity Scale of 1. It falls onto a player square that has
a **Box Collider 2D** and no Rigidbody 2D. What happens?

- A. `OnTriggerEnter2D` is called on both objects
- B. `OnTriggerEnter2D` is called on the coin only
- C. Nothing: the player has no Rigidbody 2D
- D. The coin lands on the player and stops

Answer: ________

**Q2.** In a 2D game, a ball should bounce off a wall. Should the wall's collider
be a trigger, and which message does a script on the wall receive when the ball
hits it?

Answer: ______________________________________________________________

**Q3.** Five coins in the scene were made from the `Coin` prefab, and none of them
has been changed. You open the prefab and change its colour to gold. What happens
to the five coins?

- A. Nothing: they were copied before the change
- B. They all turn gold
- C. Only coins made after the change are gold
- D. Unity asks you which coins to change

Answer: ________

**Q4.** You want anyone to play your game in a browser, from an itch.io link. In
**File → Build Profiles**, which platform do you build for? And which file must be
at the top of the zip you upload?

Platform: ______________________________ File: ______________________________

### Scope, access and classes

**Q5.** Which line causes an error, and why?

```csharp
using UnityEngine;

public class Car : MonoBehaviour
{
    float speed = 4f;

    void Start()
    {
        float boost = 2f;
        speed = speed + boost;
    }

    void Update()
    {
        Debug.Log(speed);
        Debug.Log(boost);
    }
}
```

Answer: ______________________________________________________________

**Q6.** A button's **On Click ()** list must be able to call `StartGame()`. A
designer must be able to change `startingLives` in the Inspector, but no other
script may change it. Write the first line of the method, and the field with a
starting value of 3.

Method: ______________________________________________________________

Field: ______________________________________________________________

**Q7.** What does this print?

```csharp
Lamp a = new Lamp();
a.brightness = 5;
Lamp b = a;
b.brightness = 9;
Lamp c = new Lamp();
c.brightness = 2;
Debug.Log(a.brightness + c.brightness);
```

`Lamp` is a class with one field: `public int brightness;`.

Answer: ______________________________

### Arrays and loops

**Q8.** What does this print?

```csharp
string[] days = { "Mon", "Tue", "Wed", "Thu" };
Debug.Log(days[days.Length - 1] + days[0]);
```

Answer: ______________________________

**Q9.** What does this print?

```csharp
int[] points = new int[4];
points[1] = 7;
points[3] = points[1] * 2;
Debug.Log(points[0] + points[3]);
```

Answer: ______________________________

**Q10.** What does this print?

```csharp
int total = 0;
for (int i = 1; i <= 4; i++)
{
    total += i;
}
Debug.Log(total);
```

Answer: ______________________________

**Q11.** What does this print?

```csharp
int[] ages = { 12, 17, 9, 15, 20 };
int counted = 0;
foreach (int age in ages)
{
    if (age < 10)
    {
        continue;
    }
    if (age >= 20)
    {
        break;
    }
    counted++;
}
Debug.Log(counted);
```

Answer: ______________________________

**Q12.** What does this print?

```csharp
int fuel = 10;
int laps = 0;
while (fuel >= 3)
{
    fuel -= 3;
    laps++;
}
Debug.Log(laps + " laps, " + fuel + " left");
```

Answer: ______________________________

### Enums, choices and text

**Q13.** What does this print?

```csharp
Weather today = Weather.Snowy;

switch (today)
{
    case Weather.Sunny:
        Debug.Log("Sunglasses");
        break;
    case Weather.Rainy:
        Debug.Log("Umbrella");
        break;
    default:
        Debug.Log("Coat");
        break;
}
```

`Weather` is `enum Weather { Sunny, Rainy, Snowy }`.

Answer: ______________________________

**Q14.** Write **one** line, using `?:`, that makes a `string` called `medal`:
`"Gold"` when the `float time` is less than 30, and `"Silver"` otherwise.

Answer: ______________________________________________________________

**Q15.** What does this print? Write each line of the Console message.

```csharp
string player = "Rana";
float time = 12.349f;
int stars = 3;
Debug.Log($"{player}: {stars} stars\nTime {time:F2}");
```

Line 1: ______________________________________________________________

Line 2: ______________________________________________________________

### Input, time, spawning, UI and sound

**Q16.** Which of these is `true` **only** in the frame when the player presses
Space?

- A. `Keyboard.current.spaceKey.isPressed`
- B. `Keyboard.current.spaceKey.wasPressedThisFrame`
- C. `Keyboard.current.spaceKey.wasReleasedThisFrame`
- D. `Input.GetKey(KeyCode.Space)`

Answer: ________

**Q17.** A bar's `Update()` contains `transform.Translate(5f, 0f, 0f);`. How far
does the bar move in one second at 60 frames per second? What do you change so
that it moves 5 units per second on every computer?

Answer: ______________________________________________________________

**Q18.** An array `prefabs` holds 3 prefabs. Which values can each of these
return?

`Random.Range(0, prefabs.Length)`: ______________________________

`Random.Range(-2f, 2f)`: ______________________________

**Q19.** Complete the line that makes a copy of `coinPrefab` at `position`, with no
rotation, as a child of the object this script is on.

Answer: `Instantiate(` ____________________________________________________ `);`

**Q20.** A script has three references, all set in the Inspector: `playButton` (a
GameObject), `audioSource` (an AudioSource) and `coinSound` (an AudioClip). Write
the two lines that hide the play button and play the coin sound once.

Line 1: ______________________________________________________________

Line 2: ______________________________________________________________

## Section 3 — Practical Task: Firefly Catcher

**Goal:** in 75 minutes, build a small game from this description, with no
tutorial.

### The task

It's night. Fireflies and moths appear in the sky, one after another. You fly a
jar around with the keyboard and catch them: each firefly is worth a point, and
each moth costs two. After 30 seconds the game ends, the sky clears, and you get a
rank.

> **Tip:** build it in small steps, pressing Play after each one: the jar, then the
> insects, catching, the text, the end, and the rank. A game that does four steps
> correctly scores far more than one that tries all six and doesn't compile.

### Set up the scene (about 10 minutes)

1. In a Unity 6 **Universal 2D** project, **File → New Scene** → **Lit 2D (URP)**,
   and save it as `Assets/Scenes/Firefly.unity`. Keep the **Main Camera**'s
   **Size** at `5`, and set the Game view to **16:9** (the aspect menu at the top
   of the Game view). Any dark **Background**
   colour makes a good night sky.
2. Add two tags: `Firefly` and `Moth`.
3. **The jar:** **GameObject → 2D Object → Sprites → Square**, named `Jar`, at
   **Position** `(0, -3.5, 0)`, in any colour you like. Add a **Box Collider 2D**.
4. **The firefly:** **GameObject → 2D Object → Sprites → Circle**, named
   `Firefly`, **Scale** `(0.4, 0.4, 1)`, yellow, tag `Firefly`. Add a **Rigidbody
   2D** with **Gravity Scale** `0` and **Sleeping Mode** **Never Sleep** (so it
   still notices the jar after sitting still for a while), and a **Circle Collider
   2D** with **Is Trigger** ticked. Make it a prefab, and delete it from the scene.
5. **The moth:** a second prefab made the same way, named `Moth`, grey, tag
   `Moth`.
6. **The text:** **GameObject → UI (Canvas) → Text - TextMeshPro** (in some Unity
   6 versions the menu is just **UI**), named `Info Text`, anchored at the
   top-left, big enough for three lines.
7. **The game:** an empty GameObject named `Game`, at `(0, 0, 0)`.

### What your scripts must do

Write two scripts: `Jar`, attached to `Jar`, and `FireflyGame`, attached to
`Game`. When you press Play:

1. **The jar moves** with the arrow keys, and with W A S D, in all four
   directions, at a speed you can set in the Inspector (8 units per second), the
   same on any computer. It never leaves the screen: `x` stays between −8 and 8, and `y`
   between −4.5 and 4.5.
2. **Insects appear:** every 0.8 seconds, the game makes a random insect from an
   **array** of prefabs, at a random position with `x` between −7.5 and 7.5 and
   `y` between −2 and 4. Put `Firefly` in the array three times and `Moth` once,
   so fireflies come three times as often.
3. **The jar catches:** when an insect touches the jar, it disappears, and the jar
   tells the game what it caught. A firefly adds 1 point; a moth takes 2 away, but
   the score never goes below 0. Use a `switch`.
4. **The screen:** while the game runs, `Info Text` shows the score and the time
   left, with one decimal place: `Score: 7   Time: 12.4`.
5. **The game has states:** use an `enum` with a value for playing and one for
   finished. When the time runs out, the game is finished: no more insects
   appear, catching adds nothing, and every insect still in the sky disappears.
   The game's length, 30 seconds, is set in the Inspector: your trainer will also
   try `10`, so use your variables everywhere.
6. **The rank:** when the game is finished, `Info Text` shows three lines:

```
Time's up!
Score: 12
Rank: Catcher
```

   The rank comes from two **arrays**, the scores needed and the names, and a
   **loop** that finds the best rank reached:

| Score needed | 0 | 10 | 20 | 30 |
| --- | --- | --- | --- | --- |
| Rank | Beginner | Catcher | Expert | Firefly Master |

### How it's marked

| Requirement | Marks |
| --- | --- |
| Scripts named correctly, attached, compile with no errors | 10 |
| The jar moves in four directions at the right speed, and stays on screen | 15 |
| Insects appear from an array, at random positions, at the right rate | 15 |
| Catching: the insect disappears, and the score changes the right way | 15 |
| The screen shows the score and the time, with one decimal place | 10 |
| An enum for the game's state; the end stops everything and clears the sky | 15 |
| The rank, from two arrays and a loop | 10 |
| Readable code: names, indentation, useful comments, `[SerializeField]` rather than `public` | 10 |
| **Total** | **100** |
