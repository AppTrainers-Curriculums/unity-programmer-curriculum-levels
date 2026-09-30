# Level 0 — Rocket Launch

The first level of the Unity Programmer Curriculum: first C# code and first Unity scene, for students with no coding experience. A rocket counts down, launches, climbs through stages and ends in orbit or out of fuel. There are no player controls.

## What's in this folder

| Path | What it is |
| --- | --- |
| `Docs/Level0-RocketLaunch-Workbook.pdf` | **The student book.** Build chapters and C# Concept chapters, interleaved in teaching order, plus exam-style practice and the Level 1 readiness checklist. |
| `Docs/LEVEL0_BUILD_SPEC.md` | The game spec: Level 0 code limits, scene values, acceptance checks. Hand it to Claude in VS Code for checks or changes. |
| `Scripts/MissionBriefing.cs` | Prints the mission briefing (variables, operators, `if`/`else`). |
| `Scripts/Rocket.cs` | Countdown, liftoff, flight, stages, fuel and result (methods, parameters, return values). |
| `Editor/RocketSceneBuilder.cs` | **Instructor tool.** Menu **Tools → Rocket Launch (Level 0) → Build Scene** creates `Scenes/Launch.unity` exactly as Chapter 2 describes it. |
| `Scenes/`, `Sprites/` | Created by the scene builder the first time you run it. |
| `Docs~/workbook/` | Source of the PDF (Markdown + builder). The `~` makes Unity ignore the folder. |

## First run

1. Open the project in Unity 6 and wait for scripts to compile (0 errors expected).
2. **Tools → Rocket Launch (Level 0) → Build Scene**.
3. Press **Play** and watch the Console: briefing, countdown, `LIFTOFF!`, three stages, `ORBIT REACHED!`.

## Teaching order

The book's Part 0 has the full route and the session rhythm for trainers (about 20% concept, 60% build, 20% practice). Chapters 1–2 are pure Unity; from Chapter 3 on, each build chapter is preceded by the C# Concept chapters it needs.

## Rebuilding the PDF

```bash
cd Assets/Levels/Level0/Docs~/workbook
npm install            # first time only
node build.mjs workbook.md ../../Docs/Level0-RocketLaunch-Workbook.pdf
```

Requires Google Chrome (path in `build.mjs`, or set `CHROME_PATH`).

## Keep the code cards honest

The `csharp:FileName.cs` code cards in `workbook.md` must match `Scripts/` byte for byte. After editing either side, run from `Docs~/workbook`:

```bash
python3 - <<'PY'
import re
md = open('workbook.md').read()
for f, code in re.findall(r'```csharp:([^\n]+)\n(.*?)```', md, re.S):
    real = open('../../Scripts/' + f.strip()).read()
    print(('MATCH ' if code.rstrip() == real.rstrip() else 'DIFF  ') + f.strip())
PY
```
