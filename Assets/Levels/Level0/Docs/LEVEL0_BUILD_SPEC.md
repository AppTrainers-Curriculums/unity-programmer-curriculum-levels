# Rocket Launch — Level 0 Build Spec

Spec for the **Level 0** project of the Unity Programmer Curriculum. Hand it to Claude in VS Code for checks or changes. It describes the Level 0 code limits, the exact scripts, the scene, and how to verify the result.

The student book (`Docs/Level0-RocketLaunch-Workbook.pdf`) is already written. **The project must match the book exactly**: same script names, same code, same object names, same numbers.

---

## 1. Context

- **Audience:** complete beginners (never coded, never opened Unity), 18+.
- **Level 0 purpose:** first C# code and first Unity scene. A rocket counts down, launches, climbs through stages and ends in orbit or out of fuel. There are **no player controls**; the student is the programmer, not the pilot.
- **Engine:** Unity 6, **2D (URP)** project (2D Renderer). The scene is 2D: coloured sprites, an orthographic camera and a Global Light 2D.
- **Repository:** `~/apptrainers/unity-programmer-curriculum-levels`, one Unity project holding every level. Level 0 lives in `Assets/Levels/Level0/`:

```
Assets/Levels/Level0/
├── README.md
├── Scripts/            MissionBriefing.cs, Rocket.cs      (student code)
├── Editor/             RocketSceneBuilder.cs              (instructor tool)
├── Scenes/             Launch.unity                       (created by the builder)
├── Sprites/            Square.png, Circle.png             (created by the builder)
├── Docs/               Level0-RocketLaunch-Workbook.pdf, LEVEL0_BUILD_SPEC.md
└── Docs~/workbook/     workbook.md + PDF builder          (ignored by Unity)
```

Students build the same game in **their own** 2D (URP) project, with scripts in `Assets/Scripts/` and the scene at `Assets/Scenes/Launch.unity`, as the book says. This repository is the instructor reference.

## 2. Hard rules (Level 0 limits)

The code may use **only** Level 0 topics. Do not "improve" the scripts beyond these limits, even where a more advanced approach is better practice.

**Allowed:** `int`, `float`, `bool`, `string`; arithmetic, comparison and logic operators (including `+=`, `-=`, `++`, `--`, `!`); `if` / `else if` / `else`; methods with parameters and return values; `return;` to exit a `void` method; comments; `Start()`, `Update()`; `Debug.Log`; `transform.Translate(x, y, z)`; `transform.position.y`; `Time.deltaTime` (used as a given; explained in Level 1).

**Not allowed in the student scripts:** `public` fields, `[SerializeField]`, `[Header]`, input of any kind, `GetComponent`, prefabs, `Instantiate` / `Destroy`, loops, arrays or lists, coroutines, physics / Rigidbody, UI, string interpolation (`$"..."`) or number formatting, `Vector3`, `Mathf`, enums, `switch`, access modifiers on methods, properties, events, static members.

**Style:** 4-space indentation; Allman braces (opening brace on its own line), braces on every `if` / `else` even for one line; one blank line between methods; the comments exactly as given below.

## 3. The scripts (source of truth)

These two files live in `Assets/Levels/Level0/Scripts/` and must stay **byte for byte** as below, including comments and blank lines. The workbook's code cards are copies of them, and a check in section 6 compares them.

### `Assets/Levels/Level0/Scripts/MissionBriefing.cs`

```csharp
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

### `Assets/Levels/Level0/Scripts/Rocket.cs`

```csharp
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

## 4. The scene

`Assets/Levels/Level0/Scenes/Launch.unity`, created by **Tools → Rocket Launch (Level 0) → Build Scene** (`Editor/RocketSceneBuilder.cs`). The builder generates white 1-unit `Square` and `Circle` sprites in `Sprites/`, standing in for the ones students create via **GameObject → 2D Object → Sprites**, and adds the scene to Build Settings.

| Object | Parent | Sprite | Position | Rotation Z | Scale | Color | Order in Layer | Script |
|---|---|---|---|---|---|---|---|---|
| `Main Camera` | — | — | (0, 7, -10) | 0 | (1, 1, 1) | bg `#1E1A33` | — | — |
| `Global Light 2D` | — | — | (0, 0, 0) | 0 | (1, 1, 1) | — | — | — |
| `MissionControl` | — | — | (0, 0, 0) | 0 | (1, 1, 1) | — | — | `MissionBriefing` |
| `Rocket` | — | — | (0, 0, 0) | 0 | (1, 1, 1) | — | — | `Rocket` |
| `Body` | `Rocket` | Square | (0, 1.5, 0) | 0 | (1, 3, 1) | `#F5F3FF` | 1 | — |
| `Nose` | `Rocket` | Circle | (0, 3, 0) | 0 | (1, 1, 1) | `#EF4050` | 0 | — |
| `Window` | `Rocket` | Circle | (0, 2.2, 0) | 0 | (0.45, 0.45, 1) | `#3DDCC8` | 2 | — |
| `Fin Left` | `Rocket` | Square | (-0.6, 0.5, 0) | -20 | (0.4, 1, 1) | `#EF4050` | 0 | — |
| `Fin Right` | `Rocket` | Square | (0.6, 0.5, 0) | 20 | (0.4, 1, 1) | `#EF4050` | 0 | — |
| `Launch Pad` | — | Square | (0, -0.15, 0) | 0 | (4, 0.3, 1) | `#6B6F7B` | -1 | — |
| `Ground` | — | Square | (0, -2.3, 0) | 0 | (40, 4, 1) | `#2E2A45` | -2 | — |

- **Camera:** orthographic, Size `9`, Solid Color background. It shows `y = -2` to `y = 16`, enough for the whole flight (the rocket's top reaches about 15.5).
- The `Rocket` script goes on the **parent** `Rocket` object, not on `Body`.
- The builder is an editor tool and may use any Unity API; the Level 0 limits apply only to the two student scripts.

## 5. Workbook source

`Docs~/workbook/` holds `workbook.md`, `build.mjs`, `style.css`, `fonts.css`, `fonts/` and `package.json`. It's the catch-game pipeline with three additions: a CSS rocket cover (`coverArt: rocket`), a code-editor cover (`coverArt: code`), and `## C# N — Title` headers for the slate **C# Concept** chapters. Build:

```bash
cd Assets/Levels/Level0/Docs~/workbook
npm install
node build.mjs workbook.md ../../Docs/Level0-RocketLaunch-Workbook.pdf
```

## 6. Acceptance checks

Do all of these and report the results.

1. **Compiles clean:** after import, the Console shows **0 errors and 0 warnings** from Level 0 files.
2. **Scene builds:** **Tools → Rocket Launch (Level 0) → Build Scene** creates `Scenes/Launch.unity`; the Game view shows the white rocket with a red nose, cyan window and red fins on a grey pad, over dark ground and a navy sky.
3. **Code cards match:** from `Docs~/workbook`, this prints `MATCH` for both files:

```bash
python3 - <<'PY'
import re
md = open('workbook.md').read()
for f, code in re.findall(r'```csharp:([^\n]+)\n(.*?)```', md, re.S):
    real = open('../../Scripts/' + f.strip()).read()
    print(('MATCH ' if code.rstrip() == real.rstrip() else 'DIFF  ') + f.strip())
PY
```

4. **Play test (default numbers):** the Console shows, in this order (the briefing and `Countdown started` both come from `Start()` and may swap):

```
=== MISSION BRIEFING ===
Rocket: Falcon
Crew: 3 astronauts
Fuel: 12.5 tons
Supplies: 6 tons
Status: GO for launch
Countdown started: T-minus 5
T-minus 4
T-minus 3
T-minus 2
T-minus 1
LIFTOFF!
Now entering: Lower atmosphere
Now entering: Upper atmosphere
Now entering: Space
ORBIT REACHED! Mission success. Fuel left: 40.xxx   (about 40; not exactly round)
```

   The rocket rises about 5 seconds after Play, climbs for about 6 seconds, stops at a height of 12 and stays in view.
5. **Failure test:** temporarily set `burnRate = 20f`. The mission ends with `OUT OF FUEL at height 10.xxx. Mission failed.` Restore `10f` afterwards.

## 7. Out of scope

- No player input, UI, sound, particles, prefabs or extra scripts. Those arrive in Level 1 (Catch the Falling Blocks).
- Don't change the book text. If something in the project can't match it (a menu name differs in your Unity version, say), note it in your report instead.
