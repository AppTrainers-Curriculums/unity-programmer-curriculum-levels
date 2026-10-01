---
title: "Level 1 Entry Test"
subtitle: "C# and Unity: everything in Level 0"
author: "Unity Programmer Curriculum  ·  Level 1 Entry Test"
coverEyebrow: "Level 1 Entry Test · Unity Programmer Curriculum"
coverTop: "Level 1"
coverRed: "Entry Test"
coverSub: "A written paper and a practical task on everything in Level 0. Pass both to start Level 1."
coverPill: "Student Paper"
coverCaption: "Written paper: 40 minutes · Practical task: 50 minutes"
coverArt: code
---

## Section 1 — Before You Begin

**Goal:** show that you can do everything in Level 0, so you're ready for Level 1.

### How the test works

| Part | Time | Marks | To pass |
| --- | --- | --- | --- |
| **Written paper:** 20 questions | 40 minutes | 20 | 14 or more |
| **Practical task:** build a script from a description | 50 minutes | 100 | 70 or more |

You need to pass **both** parts. If you've come from Level 0, this is its final
check. If you already know some C# and Unity, passing lets you start straight at
Level 1.

### Rules

- **Written paper:** closed book. Write your answers in the spaces. Your trainer
  collects it before handing out the practical task.
- **Practical task:** you may use Unity, your code editor, and the printed **Level 0
  cheat sheet**. No other notes, websites, AI tools or code from earlier projects.
- Read each question to the end before answering. Several questions look like
  ones you've seen, with one detail changed.

Name: ______________________________ Date: ________________

## Section 2 — Written Paper

**Goal:** answer all 20 questions in 40 minutes. Each is worth 1 mark.

### The Unity editor

**Q1.** Which window lists every GameObject in the open scene?

- A. Project
- B. Hierarchy
- C. Inspector
- D. Console

Answer: ________

**Q2.** Where do you choose the code editor that Unity opens your scripts in?

- A. File → Build Profiles
- B. Project Settings → Player
- C. Settings (or Preferences) → External Tools
- D. Window → Package Manager

Answer: ________

**Q3.** A file called `enemy.cs` contains `public class Enemy : MonoBehaviour`.
What happens when you try to attach it to a GameObject, and why?

Answer: ______________________________________________________________

**Q4.** A game runs for 10 seconds at 60 frames per second. About how many times
does Unity run `Start()`, and about how many times `Update()`?

`Start()`: ________ `Update()`: ________

### Variables and types

**Q5.** Choose the best type for each value: `int`, `float`, `bool` or `string`.

| Value | Type |
| --- | --- |
| (a) the number of arrows in a quiver | |
| (b) the player's name | |
| (c) whether the door is open | |
| (d) a jump height of 1.5 | |

**Q6.** Which line causes an error?

```csharp
int coins = 10;
float gravity = 9.8;
bool isReady = false;
string title = "Level 1";
```

Answer: line ________ because ______________________________________

**Q7.** What does this print?

```csharp
int a = 17;
int b = 5;
Debug.Log(a / b);
Debug.Log(a % b);
```

Answer: ______________________________

**Q8.** What does this print?

```csharp
int health = 100;
health -= 30;
health++;
Debug.Log(health);
```

Answer: ______________________________

### Operators and decisions

**Q9.** What does this print?

```csharp
Debug.Log("Level " + 2 + 3);
```

Answer: ______________________________

**Q10.** What does this print?

```csharp
Debug.Log("Total: " + (4 + 6));
```

Answer: ______________________________

**Q11.** What does this print?

```csharp
bool hasKey = false;
bool doorOpen = true;
Debug.Log(hasKey || doorOpen);
Debug.Log(!doorOpen);
```

Answer: ______________________________

**Q12.** What does this print?

```csharp
int speed = 45;

if (speed > 60)
{
    Debug.Log("Too fast");
}
else if (speed > 30)
{
    Debug.Log("Good");
}
else if (speed > 10)
{
    Debug.Log("Slow");
}
else
{
    Debug.Log("Stopped");
}
```

Answer: ______________________________

**Q13.** This code should print `Gold` for a score of 95, but it prints `Bronze`.
Explain why, and how to fix it.

```csharp
int score = 95;

if (score >= 50)
{
    Debug.Log("Bronze");
}
else if (score >= 90)
{
    Debug.Log("Gold");
}
```

Answer: ______________________________________________________________

### Methods

**Q14.** What does this print?

```csharp
int Square(int n)
{
    return n * n;
}

void Start()
{
    Debug.Log(Square(3) + Square(2));
}
```

Answer: ______________________________

**Q15.** What does this print, in order?

```csharp
void Start()
{
    Debug.Log("A");
    Greet("Lina");
    Debug.Log("C");
}

void Greet(string name)
{
    Debug.Log("Hi " + name);
}
```

Answer: ______________________________

**Q16.** Which error does this method cause?

```csharp
bool IsAlive(int health)
{
    if (health > 0)
    {
        return true;
    }
}
```

- A. `; expected`
- B. `The name 'health' does not exist in the current context`
- C. `not all code paths return a value`
- D. `Cannot implicitly convert type 'string' to 'int'`

Answer: ________

**Q17.** Complete the method so it returns `true` only when there are at least 20
units of fuel **and** the weather is clear.

```csharp
bool CanLaunch(float fuel, bool weatherIsClear)
{
    return ______________________________;
}
```

### Errors and comments

**Q18.** The Console shows this error. Which file and which line do you look at
first, and which line do you also check?

```
Assets/Scripts/Player.cs(14,21): error CS1002: ; expected
```

Answer: ______________________________________________________________

**Q19.** Which comment best describes `lives = lives - 1;`?

- A. `// lives equals lives minus one`
- B. `// The player was hit, so take away one life`
- C. `// Restart the level`

Answer: ________

**Q20.** The variables `string shipName = "Hawk";`, `int fuel = 45;` and
`int crew = 2;` exist. Write the one line of code that printed exactly:

```
Hawk has 45 fuel and 2 crew
```

Answer: ______________________________________________________________

## Section 3 — Practical Task: The Elevator

**Goal:** in 50 minutes, build a script from this description, with no tutorial.

### The task

An elevator in the **AppTrainers Tower** waits with its doors open, closes them,
rides up to floor 3, announces every floor it passes, and opens its doors when it
arrives.

### Set up the scene

1. In a Unity 6 **Universal 2D** project, create a new scene.
2. Create a **Square** sprite named `Elevator` at **Position** `(0, 0, 0)`.
3. Set the **Main Camera** to **Position** `(0, 4, -10)` and **Size** `5`.

### What your script must do

Write a script called `Elevator` and attach it to the `Elevator` object. When you
press Play, it must:

1. **Store its settings in variables:** the building name (`AppTrainers Tower`),
   the target floor (`3`), the height of one floor (`2` units) and the speed
   (`1.5` units per second). Choose a sensible type for each.
2. **When the game starts,** print:
   `Welcome to AppTrainers Tower. Going to floor 3`
   The name and the floor number must come from your variables.
3. **Wait 2 seconds,** then print `Doors closing` and start moving.
4. **Move straight up** at the speed you stored, the same on any computer.
5. **Announce each floor once,** as the elevator reaches it:
   `Now passing: Floor 1`, then `Floor 2`, then `Floor 3`. Use a method that
   takes a height and **returns** the name of the floor:

| Height | Floor name |
| --- | --- |
| below 2 | `Ground floor` |
| 2 up to (but not including) 4 | `Floor 1` |
| 4 up to (but not including) 6 | `Floor 2` |
| 6 or more | `Floor 3` |

6. **Stop** when its height reaches the target floor × the floor height, and print
   `Arrived at floor 3. Doors opening.` exactly once. After that, nothing moves and
   nothing more is printed.

### Expected Console output

```
Welcome to AppTrainers Tower. Going to floor 3
Doors closing
Now passing: Floor 1
Now passing: Floor 2
Now passing: Floor 3
Arrived at floor 3. Doors opening.
```

### How it's marked

| Requirement | Marks |
| --- | --- |
| Script named correctly, attached, compiles with no errors | 10 |
| Settings stored in well-chosen variables | 10 |
| Welcome message built from the variables | 10 |
| 2-second wait, then `Doors closing` | 15 |
| Moves up at the right speed on any computer | 15 |
| A floor-name method that returns a value; each floor announced once | 20 |
| Stops at the target floor; arrival printed once | 10 |
| Readable code: names, indentation, useful comments | 10 |
| **Total** | **100** |

> **Tip:** your trainer will also change the target floor to `2` and press Play.
> The elevator must then stop at a height of 4 and say `Arrived at floor 2`. Use
> your variables everywhere, and it will.

> **Tip:** get it working in small steps, pressing Play after each one: the
> welcome message, then the wait, then the movement, then the floors, then the
> stop. A script that does four steps correctly scores far more than one that
> tries all six and doesn't compile.
