---
title: "Level 1 Entry Test: Answer Key"
subtitle: "Trainer only"
author: "Unity Programmer Curriculum  ·  Level 1 Entry Test  ·  Trainer Only"
coverEyebrow: "Trainer Only · Do Not Share With Students"
coverTop: "Answer Key"
coverRed: "Level 1 Entry Test"
coverSub: "Answers, marking guidance, the practical rubric and a model solution, plus what to do with each result."
coverPill: "Trainer Only"
coverCaption: "Keep this file away from students and out of shared folders"
coverArt: code
---

## Section 1 — Running the Test

**Goal:** run the test the same way for every student, so results are fair and
comparable.

### Before the test

- Print the student paper as two sets, **Sections 1–2** (the cover and pages 1–7)
  and **Section 3** (page 8 to the end), and the **Level 0 cheat sheet** (the last
  pages of the Level 0 book), one of each per student.
- Check each lab machine has **Unity 6** with the **Universal 2D** template, and a code
  editor connected to Unity.
- Students work alone, with no internet, AI tools or earlier projects.

### On the day

| Part | Time | Notes |
| --- | --- | --- |
| Written paper | 40 minutes | Closed book: hand out Sections 1–2 only, with no cheat sheet on the desks. Collect them when time is up. |
| Break | 10 minutes | |
| Practical task | 50 minutes | Hand out Section 3 and the cheat sheet now. At the end, students leave Unity open with the scene saved. |

### Marking the practical

For each student, in this order:

1. Open their scene, check the Console for errors, and press **Play**. Compare the
   output with the expected output.
2. Stop, change the target floor to `2` in their script, and press **Play** again.
   The elevator must stop at a height of 4 and print `Arrived at floor 2. Doors
   opening.`
3. Read the script and mark it against the rubric in Section 3.

## Section 2 — Written Paper Answers

**Goal:** mark each question 1 or 0. Accept any answer that shows the same
understanding in different words.

| Q | Answer | Accept / notes | Level 0 chapter |
| --- | --- | --- | --- |
| 1 | B | | Chapter 1 |
| 2 | C | | Chapter 1 |
| 3 | Unity refuses to attach it: the file name and the class name must match exactly, including capitals. | Needs both the result and the reason. | C# 2 |
| 4 | `Start()` once, `Update()` about 600 times | Accept 500–700 for `Update()`. | C# 1 |
| 5 | (a) `int` (b) `string` (c) `bool` (d) `float` | All four needed for the mark. | C# 4 |
| 6 | Line 2: `9.8` needs an `f` (`9.8f`) to be a `float` | Line number and reason both needed. | C# 4 |
| 7 | `3` then `2` | Integer division drops the remainder; `%` gives it. | C# 5 |
| 8 | `71` | 100 − 30 = 70, plus 1. | C# 5 |
| 9 | `Level 23` | Left to right: text + 2 is text, then + 3 joins "3". | C# 5 |
| 10 | `Total: 10` | Brackets add first. | C# 5 |
| 11 | `True` then `False` | Accept lower case. | C# 5 |
| 12 | `Good` | 45 isn't > 60; it is > 30, so that block runs and the rest is skipped. | C# 9 |
| 13 | `score >= 50` is checked first, and 95 matches it, so the `else if` never runs. Put the strictest condition (`>= 90`) first. | Needs the reason **and** the fix. | C# 9 |
| 14 | `13` | 9 + 4. | C# 10 |
| 15 | `A`, `Hi Lina`, `C` | Order matters. | C# 7, C# 8 |
| 16 | C | Error CS0161. | C# 10, C# 11 |
| 17 | `fuel >= 20 && weatherIsClear` | Accept `weatherIsClear && fuel >= 20` and `== true`. Not `> 20`. | C# 5, C# 10 |
| 18 | `Player.cs`, line 14, and also the line above it (13) | A missing `;` is often reported on the next line. | C# 11 |
| 19 | B | | C# 3 |
| 20 | `Debug.Log(shipName + " has " + fuel + " fuel and " + crew + " crew");` | The spaces inside the quotes must be right. Accept interpolation if used correctly. | C# 5 |

**Pass mark:** 14 out of 20.

> **Tip:** note which questions each student missed. The last column says which
> Level 0 chapter to send them back to.

## Section 3 — Practical Task Rubric

**Goal:** mark the elevator out of 100, giving partial credit where a requirement is
partly met.

| Requirement | Full marks | Partial credit | Zero |
| --- | --- | --- | --- |
| **Script and setup** (10) | `Elevator.cs` with a matching class, attached to `Elevator`, no compile errors | 5: compiles, but misnamed or attached elsewhere | Doesn't compile |
| **Variables** (10) | Name `string`, target floor `int`, heights and speed `float`, all as fields | 5: one wrong type, or values written directly into the logic | No variables |
| **Welcome message** (10) | Exact text, built from the name and floor variables | 5: exact text, but typed out in full | Missing |
| **Wait, then doors** (15) | A timer using `Time.deltaTime` in `Update()`; `Doors closing` printed once, after about 2 seconds | 8: waits, but `Doors closing` repeats or the timing is frame-based | No wait |
| **Movement** (15) | `Translate` (or position) with `speed * Time.deltaTime`, only after the wait | 8: moves, but not multiplied by `Time.deltaTime`, or moves during the wait | No movement |
| **Floors** (20) | A method with a `float` parameter that **returns** the floor name, with correct `else if` order; each floor announced exactly once | 10: floors announced, but repeated every frame, or no return-value method | Missing |
| **Stop and arrive** (10) | Stops at `targetFloor * floorHeight` (works for floor 2 too); arrival printed once | 5: stops, but only for floor 3, or the arrival repeats | Never stops |
| **Readability** (10) | camelCase fields, PascalCase methods, consistent indentation, at least three useful comments | 5: mostly readable, few or weak comments | Unreadable |

**Pass mark:** 70 out of 100.

### Expected Console output

For the target floor `3`:

```
Welcome to AppTrainers Tower. Going to floor 3
Doors closing
Now passing: Floor 1
Now passing: Floor 2
Now passing: Floor 3
Arrived at floor 3. Doors opening.
```

For the target floor `2`, it announces floors 1 and 2, then prints
`Arrived at floor 2. Doors opening.` and stops at a height of 4.

> **Note:** `Now passing: Floor 3` and the arrival appear on the same frame, since
> the elevator reaches floor 3 as it arrives. That's correct.

## Section 4 — Model Solution

**Goal:** a reference answer written only with Level 0 C#. Students' solutions can
look different and still earn full marks.

```csharp:Elevator.cs
using UnityEngine;

// Model answer for the Level 1 entry test practical task.
// Waits, closes the doors, rides up to the target floor and announces each floor.
public class Elevator : MonoBehaviour
{
    // ---- Settings ----
    string buildingName = "AppTrainers Tower";
    int targetFloor = 3;
    float floorHeight = 2f;     // the height of one floor, in units
    float speed = 1.5f;         // units per second
    float waitTime = 2f;        // seconds before the doors close

    // ---- State: these change while the game runs ----
    float timer = 0f;
    bool isMoving = false;
    bool hasArrived = false;
    string currentFloor = "Ground floor";

    void Start()
    {
        Debug.Log("Welcome to " + buildingName + ". Going to floor " + targetFloor);
    }

    void Update()
    {
        // Nothing left to do once we've arrived
        if (hasArrived)
        {
            return;
        }

        if (!isMoving)
        {
            WaitForDoors();
        }
        else
        {
            Ride();
        }
    }

    // Waits a few seconds, then starts moving
    void WaitForDoors()
    {
        timer += Time.deltaTime;

        if (timer >= waitTime)
        {
            isMoving = true;
            Debug.Log("Doors closing");
        }
    }

    // Moves up, announces each new floor, and stops at the target floor
    void Ride()
    {
        transform.Translate(0f, speed * Time.deltaTime, 0f);

        float height = transform.position.y;
        string floor = GetFloorName(height);

        if (floor != currentFloor)
        {
            currentFloor = floor;
            Debug.Log("Now passing: " + floor);
        }

        if (height >= targetFloor * floorHeight)
        {
            hasArrived = true;
            Debug.Log("Arrived at floor " + targetFloor + ". Doors opening.");
        }
    }

    // Returns the name of the floor at a given height
    string GetFloorName(float height)
    {
        if (height >= 6f)
        {
            return "Floor 3";
        }
        else if (height >= 4f)
        {
            return "Floor 2";
        }
        else if (height >= 2f)
        {
            return "Floor 1";
        }
        return "Ground floor";
    }
}
```

## Section 5 — Results and Next Steps

**Goal:** turn each result into a clear next step for the student.

| Result | Written | Practical | Next step |
| --- | --- | --- | --- |
| **Pass** | 14 or more | 70 or more | Start **Level 1**. |
| **Nearly there** | 11–13 | 70 or more | Review the chapters listed for the missed questions, then retake the **written paper** only. |
| **Nearly there** | 14 or more | 50–69 | Rebuild the Level 0 rocket from memory, then retake the **practical** only. |
| **Not yet** | anything else | | Repeat **Level 0**, focusing on the chapters from the written paper. |

A student who takes the test **without** doing Level 0 (to skip it) and doesn't
pass starts at **Level 0**, beginning at the first chapter linked to a missed
question.

### Retakes

Allow at least a few days between attempts, so students review rather than
memorise. For a retake, change the numbers so the answers change:

| Question | Change | New answer |
| --- | --- | --- |
| Q7 | `a = 23`, `b = 4` | `5` then `3` |
| Q8 | `health = 80`, `health -= 25` | `56` |
| Q9 | `"Stage " + 4 + 1` | `Stage 41` |
| Q12 | `speed = 12` | `Slow` |
| Q14 | `Square(4) + Square(1)` | `17` |
| Q20 | `"Kite"`, `fuel = 60`, `crew = 5` | `Kite has 60 fuel and 5 crew` |
| Practical | building `Harbour Tower`, target floor `2`, floor height `3`, floor names at 3, 6 and 9 | stops at a height of 6 |
