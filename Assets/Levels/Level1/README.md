# Level 1 — Catch the Falling Blocks

The second level of the Unity Programmer Curriculum: the student's first real game. A bar steered with the keyboard catches falling red and gold blocks and dodges purple ones, with three lives, a score and messages on screen, sound, faster and faster blocks, and a Web build to publish. Students join by passing the **Level 1 entry test**.

## What's in this folder

| Path | What it is |
| --- | --- |
| `Docs/Level1-CatchTheBlocks-Workbook.pdf` | **The student book.** 11 build chapters and 6 C# Concept chapters, interleaved in teaching order, plus exam-style practice and the Level 2 readiness checklist. |
| `Docs/Level1-Entry-Test.pdf` | **Student paper** for the entry test: a 20-question written paper and a practical task (the Elevator). |
| `Docs/Level1-Entry-Test-Answer-Key.pdf` | **Trainer only.** Answers, the practical rubric, a model solution, and what to do with each result. |
| `Docs/LEVEL1_BUILD_SPEC.md` | The game spec: Level 1 code limits, scene values, acceptance checks. Hand it to Claude in VS Code for checks or changes. |
| `Scripts/` | `PlayerController.cs`, `Spawner.cs`, `GameManager.cs`, `Floor.cs`: the finished student code. |
| `Editor/CatchSceneBuilder.cs` | **Instructor tool.** Menu **Tools → Catch the Falling Blocks (Level 1) → Build Scene** creates the tags, sprite, prefabs, scene and UI exactly as the book describes, with every reference wired. |
| `Audio/` | The four sounds students get from their trainer: `Catch`, `Gold`, `Miss`, `GameOver`. |
| `Curriculum.Level1.asmdef`, `Editor/Curriculum.Level1.Editor.asmdef` | Keep Level 1's classes in their own assemblies (see below). |
| `Prefabs/`, `Scenes/`, `Sprites/` | Created by the scene builder the first time you run it. |
| `Docs~/workbook/` | Source of the book (`workbook.md`, the same file the website reads) and the PDF builder. |
| `Docs~/entry-test/` | Source of the two test papers, and `Elevator.cs`, the model solution. |

## First run

1. Open the project in Unity 6 and wait for scripts to compile (0 errors expected).
2. **Tools → Catch the Falling Blocks (Level 1) → Build Scene**. The first time, it
   asks you to import **TMP Essential Resources**: click **Import** in the Import
   Unity Package window, wait for the import, then run **Build Scene** again.
3. Press **Play**, click the Game view, and press **Space** (or click **Play**).
   Arrow keys or A / D move the bar.

## Why Level 1 has its own assemblies

Later levels will have their own `GameManager`, `PlayerController` and so on. Two classes with the same name in the same assembly don't compile, so each level from Level 1 on keeps its code in its own assembly definition (`Curriculum.Level1`, not auto-referenced). Level 0's class names are unique, so it doesn't need one. Students never see this: in their own projects, scripts go in `Assets/Scripts` as the book says.

## Input

The project uses the **Input System** package only (Unity 6's default for new projects), so the scripts read the keyboard with `Keyboard.current…`. The older `Input.GetKey` would throw errors here. The book shows the older equivalents in a table, because certification questions still use them.

## Rebuilding the PDFs

```bash
cd Assets/Levels/Level1/Docs~/workbook
npm install            # first time only
node build.mjs workbook.md ../../Docs/Level1-CatchTheBlocks-Workbook.pdf
node build.mjs ../entry-test/test.md ../../Docs/Level1-Entry-Test.pdf
node build.mjs ../entry-test/answer-key.md ../../Docs/Level1-Entry-Test-Answer-Key.pdf
```

Requires Google Chrome (path in `build.mjs`, or set `CHROME_PATH`). `build.mjs` is the same file in Levels 0, 1 and 2 (Level 2's is in `../Level2-Shared/Docs~/pdf`), and so is `style.css`, except that Level 2 sets code a little smaller: fix one, then copy it to the others. `../Level2-Shared/README.md` describes what the builder does: the covers (`coverArt: catch` for this book), `## Section N — Title` headers for the test papers, page breaks, and chapters set a little tighter so none ends on a nearly empty page.

## Keep the code cards honest

The `csharp:FileName.cs` code cards must match the files byte for byte. After editing either side, run from `Docs~/workbook`:

```bash
python3 - <<'PY'
import re
for md, folder in [('workbook.md', '../../Scripts/'), ('../entry-test/answer-key.md', '../entry-test/')]:
    text = open(md).read()
    for f, code in re.findall(r'```csharp:([^\n]+)\n(.*?)```', text, re.S):
        real = open(folder + f.strip()).read()
        print(('MATCH ' if code.rstrip() == real.rstrip() else 'DIFF  ') + f.strip())
PY
```

## The website

`workbook.md` is also the source of the Level 1 pages on the course site. Level 1 is listed in `web/levels.config.mjs` with `published: false`. To publish it, add the `COURSE_PW_LEVEL_1` repository secret, then set `published: true` (see `web/README.md`). The entry-test papers are not part of the site.
