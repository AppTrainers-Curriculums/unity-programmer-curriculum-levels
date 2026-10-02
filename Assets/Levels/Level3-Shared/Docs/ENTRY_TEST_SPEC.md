# Level 3 Entry Test — Spec

Spec for the **Level 3 entry test** of the Unity Programmer Curriculum. Hand it to Claude
in VS Code for checks or changes.

> **Status: written and checked, 2 October 2026.** Moayad approved design version 1 on
> 2 October 2026, all six decisions in section 8 as recommended (*"all approved"*). The
> paper, the answer key, the model solution and both PDFs are done. Every code answer was
> run in Unity 6000.6, the model solution was play-tested in a scene built from the
> paper's own setup steps, and two independent reviews' fixes are in (section 6).
> Section 9 lists what changed from the design while writing. This spec is the source of
> truth now.

---

## 1. What it is for

- **It tests Level 2.** Level N's exit test is Level N+1's entry test, so this is Level
  2's final check and the door to Level 3. A student who already knows C# and Unity can
  take it to start straight at Level 3.
- **It checks every line of Level 2's "Before Level 3: can you…" list**, the last page of
  every Level 2 book, which tells students: *"Level 3's entry test checks every line."*
  It also follows the Level 2 box of the curriculum overview
  (`Assets/Levels/Unity-Programmer-Curriculum-Levels.pdf`).
- **It uses only what all three Level 2 books teach.** The 15 shared C# Concept chapters,
  the cheat sheet, and what every book's own chapters teach, such as the settings panel
  that pauses with `Time.timeScale`. Nothing from Level 3: no Animator, no Animation
  Events, no `enum` + `switch` state machines as Level 3 teaches them.

## 2. The format: the same as Levels 1 and 2

| Part | Time | Marks | To pass |
| --- | --- | --- | --- |
| **Written paper:** 20 questions | 40 minutes | 20 | 14 or more |
| **Practical task:** Meteor Defence, from a description | 90 minutes | 100 | 70 or more |

- **Both parts must pass.** The paper is closed book. The practical allows Unity, a code
  editor and the printed **Level 2 cheat sheet** (two pages near the end of any Level 2
  book): no internet, AI tools or earlier projects.
- **Printed as two sets**, as Level 2's: Sections 1–2 (the cover and pages 1–11), then
  Section 3 (pages 12–14), handed out only after the paper is collected. The key gives
  the PDF page numbers too, because a print dialog counts the cover as page 1.
- **The answer key is trainer only:** how to run and mark the test; each question's
  answer, what else to accept, and the Level 2 chapter it tests, by **title** (the three
  Level 2 books number their C# Concept chapters differently); the practical's rubric
  with partial credit, what counts as a fault, and what to do with a project that
  doesn't compile; a model solution; results and next steps; and changed numbers for a
  retake of every code question and of the practical.

## 3. The written paper: 20 questions

One question or two for each line of the readiness list, so every line is checked. The
questions are of Level 2's kinds: *what does this print?*, *which line is the error, and
why?*, one choice from several, *write the line*, and one *write the constructor*.

| Q | Group | What it checks | Level 2 chapter |
| --- | --- | --- | --- |
| 1 | Classes and modifiers | Which of four lines doesn't compile: setting a `private set` property from another class (CS0272) | Properties and Constructors |
| 2 | Classes and modifiers | What a constructor with parameters leaves in two objects; then write a second constructor | Properties and Constructors |
| 3 | Classes and modifiers | Match four described values to `static`, `const`, `readonly` and `[SerializeField]`, with a `public` field left over | static, const and readonly |
| 4 | Methods and numbers | Which of three overloads each call runs, with an optional parameter's default | Methods in Depth |
| 5 | Methods and numbers | `int.TryParse` with its `out` variable, over good and bad text | Methods in Depth, Numbers and Conversions |
| 6 | Methods and numbers | `9 / 2`, `9 / 2f`, `(int)-4.7f`, `(float)found / total * 100` | Numbers and Conversions |
| 7 | Methods and numbers | `RoundToInt(6.5f)` (to the even number), `FloorToInt`, `CeilToInt`, `Clamp` | Numbers and Conversions |
| 8 | Collections | Array, `List` or `Dictionary` for three described needs | Lists, Dictionaries |
| 9 | Collections | A `List` after `Add`, `Remove`, `Insert` and `RemoveAt`: `Count`, an index and `IndexOf` | Lists |
| 10 | Collections | A `Dictionary`: a key set twice, `TryGetValue` on a missing key, and what `d["missing"]` does | Dictionaries |
| 11 | Event functions and components | The Console's order from `Awake`, `OnEnable`, `Start`, `Update` and `OnDisable`, written out of order, with `enabled = false;` | Event Functions |
| 12 | Event functions and components | `GetComponent` cached in `Awake` and `TryGetComponent` in a trigger: which line, if any, throws when the Rigidbody 2D is missing | Components and GetComponent, null and Debugging |
| 13 | Vectors, time and coroutines | From (2, 1, 0) to (8, 9, 0): the arrow, its length and its normalized direction | Vectors |
| 14 | Vectors, time and coroutines | The order of messages around `StartCoroutine` and `yield return`, and `StopCoroutine` with the handle | Coroutines and Timers |
| 15 | Vectors, time and coroutines | With `Time.timeScale = 0`: `WaitForSeconds`, `WaitForSecondsRealtime`, a falling Rigidbody 2D, and the panel's UI | Coroutines and Timers, each book's settings chapter |
| 16 | Input, rays, UI and debugging | `Pointer.current.press.wasPressedThisFrame` among four, and testing a tap in the Device Simulator | Mouse and Touch |
| 17 | Input, rays, UI and debugging | A 3D and a 2D ray with a layer mask, when only an object off the mask is in reach | Raycasts |
| 18 | Input, rays, UI and debugging | The parameter type of a Slider's, a Toggle's, an Input Field's (`onEndEdit`) and a Dropdown's listener | UI Events |
| 19 | Input, rays, UI and debugging | A `NullReferenceException`'s stack trace: which method, called by which; which reference is `null`, and how a breakpoint shows it | null and Debugging |
| 20 | Input, rays, UI and debugging | A printed Scripting API entry for `Physics2D.OverlapCircle`: write the call it describes | Reading the Unity Docs |

## 4. The practical task: Meteor Defence

GAMES_PLAN's suggestion, made concrete. A 2D game built from an empty **Universal 2D**
project, from a description, with no tutorial, in the way of Level 2's Firefly Catcher.

### The game

Meteors fall on a small city. The player clicks or taps them to blast them before they
land. There are three waves, each bigger than the last. Small meteors are the fastest and
worth the most. Each meteor that lands costs one of the city's 3 lives. A settings panel
pauses the game and sets how fast meteors fall. The game ends with the city safe or
fallen, and how many meteors of each size were blasted.

### Set up the scene (about 15 minutes, every value given)

- A **Lit 2D (URP)** scene, `Assets/Scenes/Meteors.unity`; the camera's **Size** `5`, the
  Game view **16:9**, a dark **Background**.
- A layer, `Meteor`.
- `City`: a **Square** sprite at `(0, -4.6, 0)`, **Scale** `(18, 0.8, 1)`: only a picture.
- Three prefabs, `Small Meteor`, `Medium Meteor` and `Large Meteor`: **Circle** sprites,
  **Scale** `0.4`, `0.7` and `1.1`, on the `Meteor` layer, each with a **Circle Collider
  2D** and no Rigidbody 2D (they move in code; the pointer finds their colliders).
- The UI: `Info Text` (TextMeshPro, top-left); `End Text` (TextMeshPro, in the middle,
  empty); `Settings Button`, over the city at the bottom-right, where no meteor ever
  flies; `Settings Panel`, switched off, with a `Speed Slider` (**Min** `0.5`, **Max**
  `2`, **Value** `1`) and a `Close Button`.
- `Game`: an empty GameObject at `(0, 0, 0)`.

### What the scripts must do

Two scripts: `Meteor`, on the three prefabs, and `MeteorGame`, on `Game`.

1. **Meteors fall towards the city.** Each picks a random point on the city's top edge
   (`x` from −8 to 8, `y` = −4.2) and flies straight at it, along a **normalized**
   direction (or with `Vector3.MoveTowards`), at its own speed set on its prefab in the
   Inspector (Small 3, Medium 2, Large 1.2 units a second), times the game's speed
   setting, the same on any computer. When it reaches the city it leaves the list,
   disappears and costs a life. The paper says to give each meteor a reference to the
   game when it's made, so it can tell the game.
2. **Waves come from a coroutine.** One coroutine runs three waves of 6, 9 and 12
   meteors: a random prefab from an array, at a random `x` from −8 to 8 at `y` = 5.5, one
   every 0.7 seconds. The game keeps a **`List`** of the meteors in the sky; a wave is
   over when the list is empty, and the next starts 2 seconds later. The wave sizes are
   an Inspector array; the trainer also tries two waves, of 2 and 3.
3. **Blasting.** When the mouse button or a finger is pressed (`Pointer.current`, checked
   for `null`), the meteor under the pointer (`Physics2D.OverlapPoint`, named in the
   paper because the cheat sheet doesn't have it), on the `Meteor` layer only (a
   `LayerMask` field), is blasted: out of the list, destroyed, and its points added from
   a **`Dictionary`**: Small 50, Medium 20, Large 10.
4. **The score** is a property every script can read and only `MeteorGame` can change
   (`private set`). The 3 lives the city starts with are a `const`.
5. **The screen:** `Info Text` reads `Wave 2   Score: 340   Lives: 2` as the game runs.
6. **Settings.** The settings button opens the panel and pauses the game with
   `Time.timeScale` (the coroutine's waits pause with it); **Close** carries on. Both
   buttons and the slider are connected in code with `AddListener`. The Speed slider
   changes every meteor's speed at once. While the panel is open, a click blasts nothing.
7. **The end.** The last wave cleared: `The city is safe!`. The last life lost: the wave
   coroutine is stopped (`StopCoroutine`), every meteor still in the sky disappears, and
   `The city has fallen`. Either way, `End Text` shows the message, the score, and how
   many of each size were blasted, counted in a second `Dictionary`: `Small: 4   Medium:
   5   Large: 4` for 340 points.

### How it's marked (100)

| Requirement | Marks |
| --- | --- |
| Scripts named correctly, attached, compile with no errors | 10 |
| Meteors fall towards the city at the right speed, and landing costs a life | 15 |
| Waves: one coroutine, and a `List` of the meteors in the sky | 15 |
| Blasting with the mouse and with a finger, on the `Meteor` layer only | 15 |
| Points from a `Dictionary`, the score property, the starting lives `const`, the screen | 15 |
| Settings: the pause, the slider and buttons connected in code, no blasting while paused | 10 |
| The end: the waves stopped, the sky cleared, the counts from a `Dictionary` | 10 |
| Readable code: names, indentation, comments, `[SerializeField]`, each piece of code in the right event function | 10 |
| **Total** | **100** |

The key's rubric gives each row's full marks, partial credit and zero, defines a fault
(one full-marks item missing or wrong, counted only in the row that lists it), and says:
a project that doesn't compile isn't fixed; it gets 0 for Scripts, and at most each
row's partial mark from reading the code.

### Marking it

The trainer:
1. plays it with the mouse, keeping a tally of each size blasted, and lets one meteor land;
2. opens the settings during a wave, clicks a meteor behind the panel, and moves the slider to 2;
3. loses on purpose, checks the counts, and waits 5 seconds to see the waves have stopped;
4. sets the waves to 2 and 3 and plays to the win with taps in the **Device Simulator**, the phone turned sideways (**Rotate**: an upright phone at camera Size 5 shows only x ±2.3);
5. reads both scripts and the prefabs' speeds against the rubric.

## 5. The files, and how they're built

| Path | What it is |
| --- | --- |
| `Level3-Shared/Docs~/entry-test/test.md` | The student paper's source |
| `Level3-Shared/Docs~/entry-test/answer-key.md` | The answer key's source |
| `Level3-Shared/Docs~/entry-test/Meteor.cs`, `MeteorGame.cs` | The model solution's scripts; the key's two code cards are copies of them, byte for byte |
| `Level3-Shared/Docs/Level3-Entry-Test.pdf` | The student paper: a cover and 14 pages |
| `Level3-Shared/Docs/Level3-Entry-Test-Answer-Key.pdf` | **Trainer only:** a cover and 16 pages |

- Built with Level 3's PDF builder, **on this Mac**. The cover is the code cover with
  `coverCode: level2`, new for this test: a few lines of Level 2 code, a `List` and a
  `foreach`, which give away no answer.
- Both papers set **`keepCode: true`**, also new: every code card that fits on a page
  moves to the next page whole instead of splitting, so no question's code is split.
  The other books don't set it, so their PDFs don't change.
- The two builder changes are in `Level3-Shared/Docs~/pdf/build.mjs`, copied to Level 0,
  Level 1 and Level 2's builders, as the rule says; the four copies are identical.
- **Not on the website**, like Levels 1 and 2's tests. The key is in the repo, so if the
  repo is ever public, so is the key.

## 6. How it was checked (2 October 2026)

- **Every code answer was run in Unity 6000.6**, in a copy of the project (the lab), with
  each retake version. Unity's own compiler checked the compile questions:
  - CS0272 for Q1's line 4 (and the retake's line 2);
  - the second constructor of Q2 and its retake;
  - the four listener types of Q18, and CS1503 for a wrong one;
  - Q20's answer with `2f`, `2` and `meteorMask.value`.
  - Unity's own messages were captured: Q10's `KeyNotFoundException`, Q12's
    `MissingComponentException` (*There is no 'Rigidbody2D' attached to the "Crate" game
    object, but a script is trying to access it.*) and Q19's stack trace format.
  - Q15's four facts were measured. At `timeScale` 0, `WaitForSeconds(2)` was still
    waiting after 2.5 real seconds, `WaitForSecondsRealtime(2)` had finished, a falling
    Rigidbody 2D didn't move, and a click on **Close** through the EventSystem worked.
- **The model solution was play-tested in a scene built by following the setup steps**
  through Unity's own menu items: every menu path in the paper exists in Unity 6000.6. Ten
  play tests pass, with simulated mouse clicks and finger taps:
  - meteors fly straight at their targets at their own speed (1.500 units in 0.500 s at 3), and a landing costs a life;
  - waves of 6, 9 and 12, 0.7 s apart, the next 2.0 s after the sky clears;
  - a click blasts only on the `Meteor` layer, with the dictionary's points, and a tap blasts too;
  - the settings freeze the meteors and the coroutine, and blast nothing, and the slider at 2 doubles a meteor's speed;
  - the UI works while paused;
  - a loss stops the waves, clears the sky and counts each size;
  - two short waves cleared win.
- **Two independent reviews** (2 October):
  - one checked every question and the practical against the Level 2 chapters;
  - one took the paper as a Level 2 student, then marked it as a trainer.
  - Every answer the student reviewer gave matched the key. Their fixes are in (section 9).
- **The size:** the model solution has 135 lines of code (without blank lines, comments
  and lines holding only a brace), against Firefly Catcher's 100. That's a third more,
  for a fifth more time.
  - The student reviewer estimated 85 to 95 minutes: realistic for a strong student, tight for a typical good one.
  - They suggested 105 minutes, or handing out the scene with its UI already made.
  - The test keeps the approved 90 minutes. Three of the fixes take work off students: no UI check, a hint for linking each meteor to the game, and `OverlapPoint` named.
- Both PDFs were looked at page by page.

## 7. Out of scope

Level 3 topics (the Animator, Animation Events, `enum` + `switch` state machines as Level
3 teaches them), saving, scenes, object pooling, particles (decision 3), and UI that
blocks presses on the world: `EventSystem.current.IsPointerOverGameObject()` is Level 2
(the three books' own games use it), but nothing in this game would show it working.

## 8. Decisions (design version 1): all approved, 2 October 2026

1. **The practical is Meteor Defence**, in 2D, as GAMES_PLAN suggests. *Approved.*
2. **90 minutes for the practical**, not 75. *Approved.* (See section 6 on the time.)
3. **No particles.** *Approved.*
4. **The paper's blueprint**: 20 questions, every readiness line checked. *Approved.*
5. **Retakes** with changed numbers for every code question and the practical. *Approved.*
6. **Where it lives:** `Level3-Shared`, not on the website. *Approved.*

## 9. What changed while writing

- **Q2** has students write a constructor, not just read one: the readiness list says
  "write a class with … a constructor".
- **Q3** has a fifth option, a `public` field, left over, so the last match isn't given
  away, and `public` against `[SerializeField]` is checked.
- **Q12** asks "which line, if any", so its retake (line C inside a `null` check) can
  have no error.
- **Q15** changed. The design's version asked whether `Update` still runs and `FixedUpdate`
  doesn't at `timeScale` 0. Space Shooter and Tank Arena teach that, but Mini Golf
  doesn't. It now asks about `WaitForSeconds`, `WaitForSecondsRealtime`, physics and the
  UI, which every book teaches.
- **The practical**:
  - It no longer asks that "a press on the UI blasts nothing" (`IsPointerOverGameObject`): no meteor flies under the button, and the panel pauses the game, so a trainer could never see it.
  - The setup's Raycast Target step went with it.
  - Requirement 1 says a landed meteor leaves the list, and hints at linking each meteor to the game.
  - Requirement 3 names `Physics2D.OverlapPoint`.
  - The starting lives are the `const`, not the lives, so nobody writes `const int lives`.
  - The trainer's two-wave check is spelt out.
  - The info text is in a code block, so it can't wrap.
  - Readability marks each piece of code in the right event function.
- **The model solution** uses `GameObject` prefabs and `GetComponent`, as Level 2's own
  scripts do, rather than `Meteor` prefabs.
- **The key**:
  - The Simulator is turned sideways.
  - The marking steps keep a tally and wait 5 seconds after a loss.
  - The note covers any setup mistake.
  - The rubric defines a fault and handles a project that doesn't compile.
  - Q19 needs both method names.
  - Every chapter title matches the books.
  - There are retakes for Q17, Q19 and Q20, and the practical's retake example adds up (325).
- **The builder** gained `keepCode` and `coverCode: level2` (section 5).
