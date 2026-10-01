# Mini Golf — Level 2 Build Spec

Spec for the **Mini Golf** game of Level 2 ("Builder") of the Unity Programmer Curriculum. Hand it to Claude in VS Code for checks or changes. It describes the Level 2 code limits, the scene, and how to verify the result.

The student book (`Docs/Level2-MiniGolf-Workbook.pdf`, source `Docs~/workbook/book.md`, assembled into `Docs~/workbook/workbook.md`) is already written. **The project must match the book exactly**: same script names, same code, same object names, same numbers.

---

## 1. Context

- **Audience:** students who passed the Level 2 entry test (everything in Levels 0 and 1).
- **Level 2 purpose:** the topics of the 15 shared C# Concept chapters, which are methods in depth (overloads, `out`, optional parameters), event functions, components and `GetComponent`, properties and constructors, vectors, mouse and touch, raycasts, numbers and conversions, reading the Unity docs, `static` / `const` / `readonly`, lists, dictionaries, coroutines, UI events, `null` and debugging. Mini Golf teaches them through a 3D game: models, Box Colliders and layers, Rigidbodies, Physics Materials and forces, a follow camera, a Line Renderer, triggers in 3D, a kinematic Rigidbody, particles, a settings panel, and a Web build that works with touch.
- **Three books:** Level 2 has three games, each with a fully guided book that stands alone and teaches every Level 2 topic: Mini Golf (this one, 3D), Space Shooter (2D) and Tank Arena (2D). They share the C# Concept chapters and the closing Check Yourself part, in `Assets/Levels/Level2-Shared`.
- **Engine:** Unity 6 (6000.6), URP 17, **Input System package only** (`activeInputHandler: 1`). The curriculum project was created from the **Universal 2D** template; students start Mini Golf from **Universal 3D**, so the builder adds a 3D renderer to this project (section 4).
- **Enter Play Mode** is set to Reload Scene only in the curriculum project, so static values survive from one Play to the next. Mini Golf keeps no changing static state: `GolfTerms` holds only a `const` and a `static readonly` dictionary.
- **Location:** `Assets/Levels/Level2-MiniGolf/` in `~/apptrainers/unity-programmer-curriculum-levels`:

```
Assets/Levels/Level2-MiniGolf/
├── README.md
├── Curriculum.Level2.MiniGolf.asmdef   runtime assembly (not auto-referenced)
├── Scripts/            GolfBall, ShotAimer, CameraFollow, Spinner, MovingBlock, Cup, Hole,
│                       GolfGame, BallSounds, SettingsMenu, HoleScore, GolfTerms (.cs)
├── Editor/             MiniGolfSceneBuilder.cs + Curriculum.Level2.MiniGolf.Editor.asmdef
├── Art/Models/         36 Kenney Minigolf Kit .fbx models + Textures/colormap.png
├── Art/Kenney-License.txt
├── Audio/              Putt.wav, Wall.wav, Cup.wav, Fall.wav, Cheer.wav
├── Scenes/             MiniGolf.unity                                 (created by the builder)
├── Generated/          BallPhysics.asset, AimLine.mat, Confetti.mat,
│                       MovingBlock.mat                                (created by the builder)
├── Settings/           MiniGolfRenderer.asset                         (created by the builder)
├── Docs/               workbook PDF, this spec
└── Docs~/workbook/     book.md (source), workbook.md (assembled), cover.png   (ignored by Unity)

Assets/Levels/Level2-Shared/
├── Docs~/              concepts/ (15 C# Concept chapters), shared/check-yourself.md,
│                       assemble.mjs, pdf/ (the PDF builder)
└── Editor/             Level2BuilderKit.cs + Curriculum.Level2.Shared.Editor.asmdef
```

## 2. Hard rules (Level 2 limits)

The twelve student scripts may use **only** Level 0, 1 and 2 topics. Don't "improve" them beyond these limits, even where a more advanced approach is better practice.

**Allowed from Levels 0 and 1:** variables, `if`, methods, `[SerializeField]` private fields, arrays, loops, `enum` and `switch`, string interpolation and number formats, `Keyboard.current`, `Random.Range`, `Instantiate` / `Destroy`, trigger messages, `SetActive`, `TMP_Text.text`, `AudioSource.PlayOneShot`.

**Allowed (new in Level 2):** properties (auto, `private set`, computed); constructors and plain C# classes; `static` members and static classes; `const`; `readonly`; `List<T>`; `Dictionary<K,V>`; method overloads; optional and `out` parameters; casts and `Mathf` (`Clamp`, `Clamp01`, `Repeat`, `Sin`, `RoundToInt`, `Lerp`, `MoveTowards`, `Max`…); `Vector2` / `Vector3` maths; the event functions `Awake`, `OnEnable`, `Start`, `Update`, `FixedUpdate`, `LateUpdate`, `OnDisable`, `OnDestroy`; `GetComponent`, `TryGetComponent`, `[RequireComponent]`; `Camera.main`; coroutines (`IEnumerator`, `StartCoroutine`, `StopCoroutine`, `StopAllCoroutines`, `WaitForSeconds`, `yield return null`); the Input System's `Pointer`; `EventSystem.current.IsPointerOverGameObject()`; raycasts with layer masks (3D and 2D); UI events (`AddListener` / `RemoveListener`, `SetValueWithoutNotify` and the other `…WithoutNotify` methods); Rigidbody and Rigidbody 2D code (`AddForce`, `linearVelocity`, `MovePosition`, `MoveRotation`); `ParticleSystem.Play`; `LineRenderer`; `Time.timeScale`; `AudioListener.volume`; `Debug.DrawRay`; `Random.value`.

The scripts also use a few Unity members the book introduces where it needs them: `OnCollisionEnter` and `OnTriggerStay`, `transform.Rotate`, `Screen.height`, `ForceMode.Impulse`, `MeshFilter.sharedMesh`, `string.Trim()`.

**Not allowed (later levels):** inheritance beyond `MonoBehaviour`, interfaces, abstract classes; C# events, delegates, lambdas, `Action` (`AddListener` takes method names only); `var`; LINQ; your own generics; the Animator; ScriptableObjects; `SceneManager`; `PlayerPrefs`; `FindObjectOfType` / `FindAnyObjectByType` and similar; `async` / `await`; singletons; the older `Input` class.

**Style:** as Levels 0 and 1: 4-space indentation, Allman braces, braces on every `if` / `else`, private fields without the `private` keyword, and the comments as written.

## 3. The scripts (source of truth)

The twelve files in `Scripts/` are the source of truth. The book's `csharp:FileName.cs` code cards are byte-for-byte copies (checked in section 6). The book also shows earlier versions of `GolfBall` (Chapters 3 and 4, trimmed in Chapter 6), `ShotAimer` (Chapter 6, edited in Chapter 7) and `GolfGame` (Chapters 7 and 10, edited in Chapters 8, 11 and 12): each must compile at its chapter, when a student follows the book.

| Script | On | Does |
| --- | --- | --- |
| `Spinner` | `blades`, the child of Hole 1's `windmill` tile | `transform.Rotate(degreesPerSecond * Time.deltaTime)` every frame |
| `GolfBall` | `Ball` | `[RequireComponent(typeof(Rigidbody))]`. Properties `IsMoving`, `LastShotPosition` (`private set`), `Speed` (the velocity with `y` set to 0), `IsOffCourse` (y below `fallLimit`). `FixedUpdate` stops the ball once it has been slower than `stopSpeed` for `stopDelay`. `Shoot(direction, force)` (an impulse; remembers where it was hit from), `Stop()`, `PlaceAt(position)` |
| `CameraFollow` | `Main Camera` | In `LateUpdate`, `Vector3.Lerp` from its position towards `target.position + offset`, by `smoothing * Time.deltaTime` |
| `ShotAimer` | `Shot Aimer` | Reads `Pointer.current` while `game.CanShoot`. A press that isn't over the UI starts a drag; power = drag length ÷ (`Screen.height` × `fullDrag`), clamped 0–1; the direction is the drag turned around, on the ground as the camera sees it. The Line Renderer runs from the ball, `lineLength` × power long, cut short by a raycast against `wallsMask`; shown only if `ShowAimLine`. On release above 5% power: `ball.Shoot(direction, power × maxForce)` and `game.StrokeTaken()`. `game.ShowPower()` while aiming. `CancelAim()` |
| `Cup` | `Cup` in each hole | `OnTriggerStay`: a `GolfBall` inside that's slower than `sinkSpeed` → `game.BallInCup()` |
| `Hole` | `Hole 1`, `Hole 2`, `Hole 3` | `holeName`, `par` and `tee`, read through `HoleName`, `Par` and `TeePosition` |
| `MovingBlock` | `Moving Block` (Hole 3) | `[RequireComponent(typeof(Rigidbody))]`. In `FixedUpdate`, `body.MovePosition(middle + travel * Mathf.Sin(Time.time * speed))` around its start position |
| `GolfTerms` | — (static class) | `const int MaxStrokes = 8`; `NameFor(strokes, par)`: `Hole in One` for one stroke, else the dictionary's name for strokes − par (−3 `Albatross` … +3 `Triple Bogey`), else `+N` |
| `HoleScore` | — (plain C# class) | One scorecard line: `HoleNumber`, `Par`, `Strokes` (`private set`, set by the constructor); `Difference` and `Name` worked out when read |
| `GolfGame` | `Golf Game` | The round: `List<Hole>`, the current hole and its strokes, a `List<HoleScore>` scorecard. `CanShoot`, `PlayerName` (`"Player"`). `StartRound()` (also Play Again, via `AddListener` in `OnEnable`), `StartHole`, `StrokeTaken()`, `BallInCup()`, `FinishHole`; coroutines `NextHole`, `BallOffCourse`, `HideMessageAfter`; `ShowMessage` overloads (stays / goes after N seconds); `ShowPower()`; `ShowScorecard`; the sounds and the confetti |
| `BallSounds` | `Ball` | `OnCollisionEnter`: a contact facing sideways (`Mathf.Abs(normal.y) < 0.5f`) at more than 0.2 m/s plays `wallSound` at volume `Mathf.Clamp01(impact / 2f)` |
| `SettingsMenu` | `Settings Panel` | `OnEnable`: shows the current volume, aim-line setting and name without notifying, adds five listeners, cancels any aim, sets `Time.timeScale` to 0. `OnDisable`: removes them, sets `Time.timeScale` to 1. Volume → `AudioListener.volume`; toggle → `aimer.ShowAimLine`; name (on end edit, trimmed, not blank) → `game.PlayerName`; dropdown → `ballModel.sharedMesh = ballMeshes[index]`; **Close** hides the panel |

Rules: pars 2, 3 and 3 (total 8). Every putt is a stroke, and leaving the course (below y = −1) costs one more. The ball drops when it's in the cup's trigger and slower than 1 m/s. A hole also ends when the ball stops after `GolfTerms.MaxStrokes` (8) strokes. Scores are named by `GolfTerms.NameFor`.

## 4. The scene

`Assets/Levels/Level2-MiniGolf/Scenes/MiniGolf.unity`, created by **Tools → Mini Golf (Level 2) → Build Scene** (`Editor/MiniGolfSceneBuilder.cs`, with the helpers in `Level2-Shared/Editor/Level2BuilderKit.cs`). Before it builds the scene, the builder:

- checks for the **TMP Essential Resources**; if they're missing, it opens the Import Unity Package window (click **Import**) and asks you to run it again;
- asks about unsaved changes in the open scene;
- adds the `Course` layer (in the first free User Layer) if it's missing;
- turns off **Generate Colliders**, **Import Animation**, **Import Cameras** and **Import Lights** on every model in `Art/Models`, reimporting only the models that need it;
- sets the project's Physics **Bounce Threshold** to `0.5`.

Then it builds everything below, saves the scene, puts it first in Build Settings and logs `Mini Golf scene built: Assets/Levels/Level2-MiniGolf/Scenes/MiniGolf.unity`. Running it again overwrites the scene and the assets in `Generated/`.

### Renderer, lighting and generated assets

- `Settings/MiniGolfRenderer.asset`: a Universal Renderer Data (with URP's default Post Process Data), added once to the active URP asset's renderer list. The camera uses it, with post-processing off. If no URP asset is active, the builder logs a warning and the camera keeps its default renderer.
- Ambient light: **Trilight**, sky `#C9E4F5`, equator `#A8B9C4`, ground `#5E6B5A`.

| Asset | Settings |
| --- | --- |
| `Generated/BallPhysics.asset` | Physics Material (the book's `Ball`): Dynamic and Static Friction 0, Friction Combine Minimum, Bounciness 0.6, Bounce Combine Maximum |
| `Generated/AimLine.mat` | `Universal Render Pipeline/Unlit`, white |
| `Generated/Confetti.mat` | `Universal Render Pipeline/Particles/Unlit`, white |
| `Generated/MovingBlock.mat` | `Universal Render Pipeline/Lit`, `#FF7E44` |

### World objects

| Object | Position | Rotation | Components | Notes |
| --- | --- | --- | --- | --- |
| `Directional Light` | (0, 0, 0) | (50, −30, 0) | Light: Directional, Intensity 1.2, colour `#FFF4E0`, Soft Shadows | |
| `Main Camera` | (0, 3, −2.5) | (50, 0, 0) | Camera: perspective, Field of View 60, Near 0.05, Solid Color `#8ECAE6`; Audio Listener; `CameraFollow` | tag `MainCamera`; renderer `MiniGolfRenderer` |
| `Course` | (0, 0, 0) | | — | parent of the three holes |
| `Ball` | (0, 0.1, 0) | | Rigidbody: Mass 1, Linear Damping 0.6, Angular Damping 0.05, Interpolate, Collision Detection Continuous Dynamic; Sphere Collider: Radius 0.035, material `Generated/BallPhysics`; `GolfBall`; Audio Source (Play On Awake off); `BallSounds` | child `Model`: the `ball-red` model at (0, 0, 0). y = 0.063 (the green) + 0.035 (half the ball) + 0.002 |
| `Shot Aimer` | (0, 0, 0) | | Line Renderer: 2 positions, Use World Space, width 0.02, Cast Shadows off, material `AimLine`; `ShotAimer` | |
| `Confetti` | (0, 0, 0) | (−90, 0, 0) | Particle System (below) | the cone points up |
| `Golf Game` | (0, 0, 0) | | `GolfGame`, Audio Source (Play On Awake off) | |

`Confetti`: **Main** Duration 1, Looping off, Play On Awake off, Start Lifetime 1.2–1.8, Start Speed 1.5–3, Start Size 0.03–0.06, Start Rotation 0–360°, Gravity Modifier 0.6, Simulation Space World, Start Color **Random Color** from a gradient of `#FFC044`, `#FF7E44`, `#F378F0`, `#6794D9`, `#61CB8B`. **Emission** Rate over Time 0, one burst of 80 at time 0. **Shape** Cone, Angle 30, Radius 0.05. **Renderer** material `Confetti`.

### The holes

Each hole is an empty GameObject under `Course`, on the `Course` layer, with a `Hole` script and these children: `Colliders`, `Tee` (at (0, 0.1, 0)), the tiles, the `Cup` and a flag. The tiles, `Colliders` and its boxes, `Tee` and the flag are on `Course` too; the `Cup` is on Default, so the aim line's raycast (which also hits triggers) doesn't stop at it. Positions below are local to the hole. Every tile is 1 × 1 unit, and a tile's green is 0.063 up.

| Object | Position | Hole Name | Par |
| --- | --- | --- | --- |
| `Hole 1` | (0, 0, 0) | The Windmill | 2 |
| `Hole 2` | (3, 0, 0) | Around the Corner | 3 |
| `Hole 3` | (8, 0, 0) | Mind the Edge | 3 |

Tiles, flag and cup (Y rotation after the position; no angle means 0°):

| | Hole 1 | Hole 2 | Hole 3 |
| --- | --- | --- | --- |
| 1 | `end` (0, 0, 0), 180° | `end` (0, 0, 0), 180° | `end` (0, 0, 0), 180° |
| 2 | `straight` (0, 0, 1) | `straight` (0, 0, 1) | `straight` (0, 0, 1) |
| 3 | `windmill` (0, 0, 2) | `corner` (0, 0, 2) | `open` (0, 0, 2) |
| 4 | `straight` (0, 0, 3) | `straight` (1, 0, 2), 90° | `open` (0, 0, 3) |
| 5 | `hole-square` (0, 0, 4) | `obstacle-block` (2, 0, 2), 90° | `straight` (0, 0, 4) |
| 6 | | `hole-square` (3, 0, 2), 90° | `hole-square` (0, 0, 5) |
| Flag | `flag-red` (0, 0.032, 4), −40° | `flag-blue` (3, 0.032, 2), −40° | `flag-green` (0, 0.032, 5), −40° |
| `Cup` | (0, 0.098, 4) | (3, 0.098, 2) | (0, 0.098, 5) |

Each `Cup` is a Sphere Collider (Is Trigger, Radius 0.03) with the `Cup` script, at the height of the ball's centre (0.063 + 0.035). On Hole 1, the `windmill` tile's child `blades` has a `Spinner`.

**Colliders.** Each box is an empty GameObject under the hole's `Colliders`, at **Position** (its centre), with a Box Collider of **Size**:

| Hole | Name | Position | Size |
| --- | --- | --- | --- |
| 1 | `Floor` | (0, 0.0315, 2) | (1, 0.063, 5) |
| 1 | `Left Wall` | (−0.45, 0.0735, 2) | (0.1, 0.147, 5) |
| 1 | `Right Wall` | (0.45, 0.0735, 2) | (0.1, 0.147, 5) |
| 1 | `Back Wall` | (0, 0.0735, −0.45) | (1, 0.147, 0.1) |
| 1 | `End Wall` | (0, 0.0735, 4.45) | (1, 0.147, 0.1) |
| 1 | `Windmill Left` | (−0.3, 0.15, 2) | (0.2, 0.3, 0.8) |
| 1 | `Windmill Right` | (0.3, 0.15, 2) | (0.2, 0.3, 0.8) |
| 2 | `Floor` | (1.5, 0.0315, 1) | (4, 0.063, 3) |
| 2 | `Left Wall` | (−0.45, 0.0735, 1) | (0.1, 0.147, 3) |
| 2 | `Top Wall` | (1.5, 0.0735, 2.45) | (4, 0.147, 0.1) |
| 2 | `Inner Wall A` | (0.45, 0.0735, 0.5) | (0.1, 0.147, 2) |
| 2 | `Inner Wall B` | (2, 0.0735, 1.55) | (3, 0.147, 0.1) |
| 2 | `Back Wall` | (0, 0.0735, −0.45) | (1, 0.147, 0.1) |
| 2 | `End Wall` | (3.45, 0.0735, 2) | (0.1, 0.147, 1) |
| 2 | `Pillar` | (2, 0.0735, 2) | (0.63, 0.147, 0.16) |
| 3 | `Floor` | (0, 0.0315, 2.5) | (1, 0.063, 6) |
| 3 | `Left Wall 1` | (−0.45, 0.0735, 0.5) | (0.1, 0.147, 2) |
| 3 | `Right Wall 1` | (0.45, 0.0735, 0.5) | (0.1, 0.147, 2) |
| 3 | `Left Wall 2` | (−0.45, 0.0735, 4.5) | (0.1, 0.147, 2) |
| 3 | `Right Wall 2` | (0.45, 0.0735, 4.5) | (0.1, 0.147, 2) |
| 3 | `Back Wall` | (0, 0.0735, −0.45) | (1, 0.147, 0.1) |
| 3 | `End Wall` | (0, 0.0735, 5.45) | (1, 0.147, 0.1) |

Hole 3 has no walls beside its two `open` tiles (z 1.5 to 3.5): a ball that rolls off the side there falls.

**Moving Block** (child of `Hole 3`, layer `Course`): a Cube with its Box Collider, **Position** (0, 0.103, 2.5), **Scale** (0.2, 0.08, 0.1), material `MovingBlock`; Rigidbody with **Is Kinematic** and **Interpolate**; `MovingBlock`.

### UI

Canvas (Screen Space Overlay; Canvas Scaler: Scale With Screen Size, 1920 × 1080, Match 0.5) and an EventSystem with the **Input System UI Input Module**. Every Text - TextMeshPro below is white, with **Raycast Target** off. The Canvas's children, in this order:

| Object | Anchor | Pos | Size | Details |
| --- | --- | --- | --- | --- |
| `Top Bar` | stretched across the top | (0, 0) | height 110 | Image `#38383D` at 70% alpha, Raycast Target off |
| `Hole Text` | top-left | (40, −20) | 900 × 70 | 48, left; starts as `Hole 1 of 3    Par 2` |
| `Strokes Text` | top-center | (0, −20) | 500 × 70 | 48, centred; `Strokes: 0` |
| `Power Text` | bottom-center | (0, 50) | 700 × 90 | 64, centred; empty |
| `Message Text` | middle-center | (0, 180) | 1700 × 200 | 96, **Bold**, centred; empty |
| `Settings Button` | top-right | (−30, −15) | 260 × 80 | Image `#FF7E44`, label "Settings", 40; **On Click ()** → `Settings Panel` **GameObject.SetActive** (ticked) |
| `Settings Panel` | fills the screen | | | Image black at 55% alpha (it catches presses); `SettingsMenu`; starts inactive |
| `Scorecard Panel` | fills the screen | | | Image black at 55% alpha; starts inactive |

`Settings Panel` → `Window`: middle-center, 420 × 300, `#38383D`, **Scale** (2.2, 2.2, 1). Its children (anchors middle-center; the controls keep their default heights):

| Object | Made with | Pos | Size | Details |
| --- | --- | --- | --- | --- |
| `Title` | Text - TextMeshPro | (0, 115) | 380 × 50 | "Settings", 30, centred |
| `Volume Label` | Text - TextMeshPro | (−110, 60) | 140 × 30 | "Volume", 18, left |
| `Volume Slider` | Slider | (60, 60) | width 200 | **Value** 1 |
| `Aim Line Toggle` | Toggle | (10, 18) | default | **Is On**; label "Show the aim line", white |
| `Name Label` | Text - TextMeshPro | (−110, −28) | 140 × 30 | "Name", 18, left |
| `Name Input` | Input Field - TextMeshPro | (60, −28) | width 200 | placeholder "Your name", **Character Limit** 12 |
| `Ball Label` | Text - TextMeshPro | (−110, −72) | 140 × 30 | "Ball", 18, left |
| `Ball Dropdown` | Dropdown - TextMeshPro | (60, −72) | width 200 | **Options** `Red`, `Blue`, `Green` |
| `Close Button` | Button - TextMeshPro | (0, −120) | 160 × 36 | `#FF7E44`, "Close", 18 |

`Scorecard Panel` → `Window`: middle-center, 560 × 330, `#38383D`, **Scale** (2, 2, 1):

| Object | Made with | Pos | Size | Details |
| --- | --- | --- | --- | --- |
| `Scorecard Text` | Text - TextMeshPro | (0, 25) | 520 × 250 | 20, top-left |
| `Play Again Button` | Button - TextMeshPro | (0, −130) | 200 × 40 | `#61CB8B`, "Play Again", 20 |

### References

| Component | Fields |
| --- | --- |
| `CameraFollow` | Target `Ball`; **Offset** (0, 3, −2.5) (script default (0, 1.6, −1.6)); Smoothing 4 |
| `GolfBall` | defaults: Stop Speed 0.15, Stop Delay 0.2, Fall Limit −1 |
| `BallSounds` | Audio Source: the Ball's; Wall Sound `Audio/Wall.wav` |
| `ShotAimer` | Ball; Game `Golf Game`; Aim Line: its Line Renderer; Walls Mask `Course`; defaults Max Force 4, Full Drag 0.35, Line Length 1.2 |
| `Cup` (×3) | Game `Golf Game`; default Sink Speed 1 |
| `Hole` (×3) | Hole Name, Par (table above); Tee: the hole's `Tee` |
| `Spinner` | **Degrees Per Second** (0, 0, 60) (script default (0, 0, 90)) |
| `MovingBlock` | **Travel** (0.3, 0, 0) (script default (0.25, 0, 0)); Speed 1.5 |
| `GolfGame` | Holes: `Hole 1`, `Hole 2`, `Hole 3` in order; Ball; Confetti; Hole Text, Strokes Text, Power Text, Message Text; Scorecard Panel, Scorecard Text, Play Again Button; Audio Source: its own; Putt, Cup, Fall and Cheer sounds from `Audio/` |
| `SettingsMenu` | Volume Slider, Aim Line Toggle, Name Input, Ball Dropdown, Close Button; Aimer `Shot Aimer`; Game `Golf Game`; Ball Model: `Ball/Model`'s Mesh Filter; Ball Meshes: the meshes of `ball-red`, `ball-blue`, `ball-green`, in the dropdown's order |

## 5. Workbook and site

- `Docs~/workbook/book.md` is the book's source. `Level2-Shared/Docs~/assemble.mjs` expands its `{{concept:…}}` and `{{include:check-yourself}}` markers, numbers the C# chapters, fills in the `{{ref:…}}` references, and writes `Docs~/workbook/workbook.md`: the file the PDF builder and the course site read. Never edit `workbook.md`.
- `workbook.md` follows the site's heading conventions (`# Part N — …`, `## Chapter N — …`, `## C# N — …`). The site's importer splits it into 35 pages: Before You Start, 15 build chapters, 15 C# Concepts and the four Check Yourself pages (Exam-style questions, Answers, Level 2 cheat sheet, Before Level 3: can you…).
- The cover comes from the front matter (`coverArt: image`, `coverImage: cover.png`, in `Docs~/workbook/`).
- The book is listed in `web/levels.config.mjs` with `published: false`. Publishing needs its password secret first (see `web/README.md`).

## 6. Acceptance checks

Do all of these and report the results.

1. **Compiles clean:** after import, the Console shows **0 errors and 0 warnings** from Mini Golf's files and `Level2-Shared`'s.
2. **Scene builds:** **Tools → Mini Golf (Level 2) → Build Scene** logs `Mini Golf scene built: …` with no errors or warnings (such as `Missing model`, `No mesh in`, `No field` or `Missing sound`). The Game view shows Hole 1 from above and behind, under the grey top bar.
3. **Book up to date, code cards match:** `node assemble.mjs --check` (from `Level2-Shared/Docs~`) prints `up to date` for Mini Golf, and the check in `README.md` prints `MATCH` for all 12 scripts.
4. **Play test:**
   - **Start:** Hole 1 from above and behind, the windmill's blades turning slowly; `Hole 1 of 3    Par 2` and `Strokes: 0` on the top bar; `Hole 1: The Windmill` for 2 seconds.
   - **Aim:** press anywhere except on **Settings** and drag back: a white aim line grows from the ball, pointing away from the drag, up to 1.2 m long at full power, and stops at the first `Course` collider in its way. `Power N%` shows at the bottom; a drag of 35% of the screen's height is 100%. Letting go at 5% or less does nothing. Otherwise: a putt, the putt sound, `Strokes: 1`.
   - **Roll:** pressing does nothing while the ball moves. The camera glides after the ball without turning. The ball bounces off walls and clicks, louder the harder it hits (full volume from 2 m/s, silent below 0.2 m/s); rolling on the floor is silent. It stops dead once it has been slower than 0.15 m/s for 0.2 seconds.
   - **Cup:** a ball crossing the cup faster than 1 m/s rolls on. Slower, it drops: the cup sound, a burst of confetti, the ball vanishes, and the score's name stays on screen: `Hole in One!` for one stroke; otherwise strokes − par gives `Albatross!` (−3), `Eagle!` (−2), `Birdie!` (−1), `Par!` (0), `Bogey!` (+1), `Double Bogey!` (+2), `Triple Bogey!` (+3), or `+N!`. 2.5 seconds later the ball is on the next tee, with `Hole 2 of 3    Par 3`, `Strokes: 0` and `Hole 2: Around the Corner`.
   - **Hole 3:** the block slides 0.3 m each way across the open stretch, and the ball bounces off it. Rolling off the side: once the ball is below y = −1, the fall sound and `Off the course! +1 stroke` (1.5 seconds); 1 second later the ball is back where it was hit from, and the strokes are one higher.
   - **Stroke limit:** when the ball stops with 8 strokes or more (`GolfTerms.MaxStrokes`; a penalty stroke counts), the hole ends without the cup sound or confetti: with 8 strokes, `+6!` on hole 1 and `+5!` on holes 2 and 3.
   - **Scorecard:** 2.5 seconds after hole 3 ends, the scorecard panel: `Scorecard: Player` (or the name from Settings), one line per hole such as `Hole 1    Par 2    2 strokes    Par`, and `Total: N strokes, ` followed by `M under par!`, `M over par` or `level par` (the total par is 8); the cheer sound; the message is cleared. **Play Again** hides the scorecard and starts again on hole 1 at `Strokes: 0`.
   - **Settings:** the panel opens and the game pauses: the blades, the block and a rolling ball stop, an aim in progress is cancelled, and no putt can start. The slider sets the volume of every sound. Unticking **Show the aim line** hides the line; putting still works, with the power text. A name (up to 12 characters; blank is ignored) is taken on **Enter** or when you click away, and appears on the scorecard. **Blue** or **Green** changes the ball's colour. **Close** carries on exactly where the game stopped. Pressing **Settings** never starts a putt.
   - **Play again:** stop and press Play again: a clean start. (Stopping with the panel open runs `SettingsMenu.OnDisable`, which sets `Time.timeScale` back to 1.)
5. **Build:** **File → Build Profiles** → **Web** (**Switch Platform**). In the Scene List, tick `Scenes/MiniGolf` as the only scene (the builder adds it; other levels' scenes are listed too). In **Player Settings → Publishing Settings**, set **Compression Format** to **Disabled**. The build runs in a browser, with the mouse, and with a finger on a phone.

## 7. Out of scope

- No Animator, state machines, ScriptableObjects, scene loading, saving (`PlayerPrefs`), C# events or delegates, inheritance or interfaces. Those arrive in later levels.
- Don't change the book text. If something in the project can't match it (a menu name differs in your Unity version, say), note it in your report instead.
- Space Shooter and Tank Arena have their own specs, in their own folders.
