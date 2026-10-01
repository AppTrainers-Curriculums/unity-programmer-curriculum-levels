# Tank Arena — Level 2 Build Spec

Spec for the **Tank Arena** game of Level 2 ("Builder") of the Unity Programmer Curriculum. Hand it to Claude in VS Code for checks or changes. It describes the Level 2 code limits, the scene, and how to verify the result.

The student book (`Docs/Level2-TankArena-Workbook.pdf`, source `Docs~/workbook/book.md`, assembled into `Docs~/workbook/workbook.md`) is already written. **The project must match the book exactly**: same script names, same code, same object names, same numbers.

---

## 1. Context

- **Audience:** students who passed the Level 2 entry test (everything in Levels 0 and 1).
- **Level 2 purpose:** the topics of the 15 shared C# Concept chapters, which are methods in depth (overloads, `out`, optional parameters), event functions, components and `GetComponent`, properties and constructors, vectors, mouse and touch, raycasts, numbers and conversions, reading the Unity docs, `static` / `const` / `readonly`, lists, dictionaries, coroutines, UI events, `null` and debugging. Tank Arena teaches them through a top-down 2D game: Pixels Per Unit, tiled sprites and colliders, a tank driven through its Rigidbody 2D, a turret that turns around a sprite's pivot, one set of components (`Tracks`, `Turret`, `Health`) shared by every tank with a different brain for the player and the enemies, enemies that see the player with 2D raycasts and layers, rounds run by a coroutine, a filled health bar, taps and holds on a touchscreen, a follow camera, start and end screens with a plain C# class of statistics, particles, sound, a settings panel, and a Web build that works with touch.
- **Three books:** Level 2 has three games, each with a fully guided book that stands alone and teaches every Level 2 topic: Mini Golf (3D), Space Shooter (2D) and Tank Arena (this one, 2D). They share the C# Concept chapters and the closing Check Yourself part, in `Assets/Levels/Level2-Shared`.
- **Engine:** Unity 6 (6000.6), URP 17 with its 2D Renderer, **Universal 2D** template (the curriculum project's template too), **Input System package only** (`activeInputHandler: 1`).
- **Enter Play Mode** is set to Reload Scene only in the curriculum project, so static values survive from one Play to the next. Tank Arena's only static class, `ArenaBounds`, holds `const`s and a static method, and nothing static changes while the game runs.
- **Location:** `Assets/Levels/Level2-TankArena/` in `~/apptrainers/unity-programmer-curriculum-levels`:

```
Assets/Levels/Level2-TankArena/
├── README.md
├── Curriculum.Level2.TankArena.asmdef   runtime assembly (not auto-referenced)
├── Scripts/            PlayerTank, EnemyTank, Tracks, Turret, Health, Shell, RepairKit,
│                       CameraFollow, ArenaGame, SettingsMenu, ArenaBounds, MatchStats (.cs)
├── Editor/             TankArenaSceneBuilder.cs + Curriculum.Level2.TankArena.Editor.asmdef
├── Art/Sprites/        35 Kenney Top-down Tanks sprites (.png)
├── Art/Kenney-License.txt
├── Audio/              Shot, Hit, Repair, Explosion, Victory, Defeat (.wav)
├── Prefabs/            Player Shell, Enemy Shell, Light Tank, Heavy Tank, Repair Kit, Explosion,
│                       Hit Puff                                       (created by the builder)
├── Generated/          Explosion.mat, Hit Puff.mat                    (created by the builder)
├── Scenes/             TankArena.unity                                (created by the builder)
├── Docs/               workbook PDF, this spec
└── Docs~/workbook/     book.md (source), workbook.md (assembled), cover.png   (ignored by Unity)

Assets/Levels/Level2-Shared/
├── Docs~/              concepts/ (15 C# Concept chapters), shared/check-yourself.md,
│                       assemble.mjs, pdf/ (the PDF builder)
└── Editor/             Level2BuilderKit.cs + Curriculum.Level2.Shared.Editor.asmdef
```

## 2. Hard rules (Level 2 limits)

The twelve student scripts may use **only** Level 0, 1 and 2 topics. Don't "improve" them beyond these limits, even where a more advanced approach is better practice.

**Allowed from Levels 0 and 1:** variables, `if`, methods, `[SerializeField]` private fields, arrays, loops, `enum` and `switch`, the one-line if / else `condition ? a : b`, string interpolation and number formats (such as `{ShotsPerKill:F1}`), `Keyboard.current`, `Random.Range`, `Instantiate` / `Destroy`, trigger messages, `SetActive`, `TMP_Text.text`, `AudioSource.PlayOneShot`.

**Allowed (new in Level 2):** properties (auto, `private set`, computed); constructors and plain C# classes; `static` members and static classes; `const`; `readonly`; `List<T>`; `Dictionary<K,V>`; method overloads; optional and `out` parameters; casts and `Mathf` (`Clamp`, `Abs`, `Max`, `Min`, `MoveTowardsAngle`, `Lerp`…); `Vector2` / `Vector3` maths, including `Vector2.SignedAngle`, `Vector2.Angle` and `Vector3.Lerp`; the event functions `Awake`, `OnEnable`, `Start`, `Update`, `FixedUpdate`, `LateUpdate`, `OnDisable`; `GetComponent`, `TryGetComponent`, `[RequireComponent]`; `Camera.main`; coroutines (`IEnumerator`, `StartCoroutine`, `StopCoroutine`, `StopAllCoroutines`, `WaitForSeconds`, `yield return null`); the Input System's `Pointer`; `EventSystem.current.IsPointerOverGameObject()`; raycasts with layer masks (3D and 2D); UI events (`AddListener` / `RemoveListener`, `SetValueWithoutNotify` and the other `…WithoutNotify` methods); Rigidbody 2D code (`linearVelocity`, `angularVelocity`, `position`, `rotation`); `Image.fillAmount`; `Time.timeScale`; `AudioListener.volume`; `Debug.DrawRay`; `Random.value`.

The scripts also use a few things the book introduces where it needs them: `Quaternion.Euler`, `Destroy(gameObject, seconds)`, `Camera.ScreenToWorldPoint`, `Camera.orthographicSize` and `aspect`, `Transform.Rotate`, `KeyValuePair` (in a `foreach` over a dictionary), `foreach` over a Transform's children, and `GameObject.activeSelf` / `activeInHierarchy`.

**Not allowed (later levels):** inheritance beyond `MonoBehaviour`, interfaces, abstract classes; C# events, delegates, lambdas, `Action` (`AddListener` takes method names only); `var`; LINQ; your own generics; the Animator; ScriptableObjects; `SceneManager`; `PlayerPrefs`; `FindObjectOfType` / `FindAnyObjectByType` and similar; `async` / `await`; singletons; the older `Input` class; NavMesh or any pathfinding (the enemies drive straight at a random point, and push along walls).

**Style:** as Levels 0 and 1: 4-space indentation, Allman braces, braces on every `if` / `else`, private fields without the `private` keyword, and the comments as written.

## 3. The scripts (source of truth)

The twelve files in `Scripts/` are the source of truth. The book's `csharp:FileName.cs` code cards are byte-for-byte copies (checked in section 6). The book also shows earlier versions of `PlayerTank` (Chapters 2, 3, 4, 9 and 11, edited in Chapter 7), `Turret` (Chapters 3 and 4, edited in Chapter 7), `Shell` (Chapters 4 and 5), `Health` (Chapter 5, edited in Chapters 8 and 11), `EnemyTank` (Chapters 5, 6 and 7), `ArenaGame` (Chapters 6, 7, 8 and 11, edited in Chapter 10) and `CameraFollow` (Chapter 10): each must compile at its chapter, when a student follows the book. Chapter 6 (`ArenaGame` then `EnemyTank`) and Chapter 11 (`ArenaGame` then `PlayerTank`) each have one step where the Console shows errors until the next script is replaced, and the book warns about both.

| Script | On | Does |
| --- | --- | --- |
| `ArenaBounds` | — (static class) | `const HalfWidth = 12`, `HalfHeight = 8` (the ground's half-size); `RandomPoint()`: a random point at least `Margin` (2) inside the arena |
| `Tracks` | every tank | `[RequireComponent(typeof(Rigidbody2D))]`. `Drive(drive, turn)` stores both, clamped to −1…1; `DriveTowards(point)`: stops within 0.4 units, otherwise turns by `SignedAngle(transform.up, toPoint) / 30` and drives forwards only when less than 45° off; `Stop()`. `FixedUpdate`: `linearVelocity = transform.up * drive * moveSpeed`, `angularVelocity = turn * turnSpeed` |
| `Turret` | every tank | `AimAt(point)`: turns `barrel` towards the point with `Mathf.MoveTowardsAngle`, at most `turnSpeed` degrees a second. `IsAimedAt(point, degrees)`. `IsLoaded`. `Fire()`: if loaded, a shell at `muzzle` turned like the barrel, the shot sound, a new `reloadTime`; returns whether it fired |
| `Health` | every tank | `Current` (`private set`), `Max`, `IsDead`, `Fraction` (`(float)Current / maxHealth`). `TakeDamage(amount)` (never below 0, hurt sound if set), `Heal(amount = 1)` (never above the maximum, heal sound if set), `ResetHealth()` |
| `Shell` | `Player Shell`, `Enemy Shell` | `[RequireComponent(typeof(Rigidbody2D))]`. `Start`: `linearVelocity = transform.up * speed`, `Destroy(gameObject, lifetime)`. `OnTriggerEnter2D`: ignores triggers (other shells, repair kits); otherwise damages a `Health` if the collider has one, makes a hit puff, and destroys itself |
| `PlayerTank` | `Player Tank` | `[RequireComponent]` Tracks, Turret, Health; `Health` property. `Update`: stops the tracks; nothing else unless `game.IsPlaying` and the game isn't paused. Keyboard: W / ↑ and S / ↓ drive, A / ← and D / → turn, Space (`wasPressedThisFrame`) fires. Pointer: the barrel aims at it every frame; a press starts `pressing`, and any frame on which the pointer is over the UI ends it (a finger is only known to be on a button a frame after it lands); released within `tapTime` it fires, held longer it `DriveTowards` the pointer. `Fire()` reports each real shot with `game.ShotFired()`. `ResetTank()` |
| `EnemyTank` | `Light Tank`, `Heavy Tank` | `[RequireComponent]` Tracks, Turret, Health; `TankName`, `Health`. `SetGame()` (keeps the game, and the player's Transform as `target`). `Think` coroutine: a new `ArenaBounds.RandomPoint()` every `thinkTime` seconds. `Update`: dead → `game.EnemyDestroyed(this)` and `Destroy`; can see the target → stop, aim, fire when aimed within 5°; otherwise drive to the destination, barrel forwards. `CanSeeTarget(out Vector2)`: target active, within `sightRange`, and the first hit of a `Physics2D.Raycast` against `sightMask` is the target (`Debug.DrawRay` in yellow) |
| `RepairKit` | `Repair Kit` | Destroyed after `lifetime`; turns `spinSpeed` degrees a second; touched by a `PlayerTank`: `player.Health.Heal(repairAmount)`, then destroys itself |
| `CameraFollow` | `Main Camera` | `[RequireComponent(typeof(Camera))]`. `ShakeEnabled` (`true`). `Shake(seconds)` (with `defaultShake`) and `Shake(seconds, strength)` overloads. `LateUpdate`: clamps the target's position so the view stays inside `ArenaBounds` (using `orthographicSize` and `aspect`), `Lerp`s `followPosition` towards it at `smoothing * Time.deltaTime`, and, while a shake lasts and the game isn't paused, counts it down and adds a random jolt if `ShakeEnabled` (a shake that runs out while disabled is never seen) |
| `MatchStats` | — (plain C# class) | A `readonly Dictionary<string, int>` of kills, every name given to the constructor at 0. `RoundsCleared`, `ShotsFired` (`private set`); `TotalKills`, `ShotsPerKill` (computed; 0 before the first kill); `AddRound()`, `AddShot()`, `AddKill(name)`; `Summary()` |
| `ArenaGame` | `Arena Game` | `readonly List<EnemyTank>`; `IsPlaying`; `CommanderName` (`"Commander"`); `Player`. **Play** and **Play Again** call `StartGame()` (`AddListener` in `OnEnable`). `PlayRounds` coroutine: for each round, "Round N" 1.5 s, 3–2–1 (0.6 s each), "Go!" (0.8 s), `SpawnRound`, wait until no enemies are left, `AddRound`, "Round cleared!" 2 s; after the last, `EndGame(true)`. `Spawn` uses `spawnPoints[spawnIndex % spawnPoints.Length]` and `SetGame`. `EnemyDestroyed` (list, kill, `Explode`, a repair kit as a child with `repairKitChance`); `ShotFired`; `Explode` (smoke, sound, `Shake(0.3f)`); `EndGame(won)` (end panel text, victory or defeat sound, `Shake(0.6f, 0.4f)` on defeat); `ClearArena`; `ShowMessage` overloads; `UpdateScreen` (health bar, "Round N of 4", "Enemies: N") |
| `SettingsMenu` | `Settings Panel` | `OnEnable`: shows the current volume, shake setting and name without notifying, adds five listeners, sets `Time.timeScale` to 0. `OnDisable`: removes them, sets `Time.timeScale` to 1. Volume → `AudioListener.volume`; toggle → `cameraFollow.ShakeEnabled`; name (on end edit, trimmed, not blank) → `game.CommanderName`; dropdown → the player's body and barrel sprites; **Close** hides the panel |

Rules: the player's tank has 10 hit points, and every shell does 1 damage. A light tank has 2, a heavy tank 5. Enemy shells can hit other enemies too (they count as your kills). Each destroyed enemy leaves a repair kit 35% of the time; it heals 2 points (never above 10) and disappears after 12 seconds. A round ends when every enemy of it has been destroyed. Clearing round 4 wins.

The four rounds (`ArenaGame`'s arrays, which the Inspector can change):

| Round | Light tanks | Heavy tanks | Spawn points used |
| --- | --- | --- | --- |
| 1 | 2 | 0 | 1, 2 |
| 2 | 3 | 0 | 1, 2, 3 |
| 3 | 2 | 1 | 1, 2 (light), 3 (heavy) |
| 4 | 2 | 2 | 1, 2 (light), 3, 4 (heavy) |

## 4. The scene

`Assets/Levels/Level2-TankArena/Scenes/TankArena.unity`, created by **Tools → Tank Arena (Level 2) → Build Scene** (`Editor/TankArenaSceneBuilder.cs`, with the helpers in `Level2-Shared/Editor/Level2BuilderKit.cs`). Before it builds the scene, the builder:

- checks for the **TMP Essential Resources**; if they're missing, it opens the Import Unity Package window (click **Import**) and asks you to run it again;
- asks about unsaved changes in the open scene;
- adds the `Walls` and `Player` layers (in the first free User Layers) if they're missing;
- imports every sprite it uses as a single sprite, 100 Pixels Per Unit, no mipmaps, pivot centre, except the five barrels (`barrelBlue`, `barrelRed`, `barrelBlack`, `barrelGreen`, `barrelBeige`), whose pivot is **Bottom**, and `sand` and `sandbagBrown`, with Mesh Type **Full Rect** (tiling needs it);
- creates the seven prefabs below, overwriting them.

Then it builds the scene, saves it, puts it first in Build Settings and logs `Tank Arena scene built: Assets/Levels/Level2-TankArena/Scenes/TankArena.unity`.

### World objects

| Object | Position | Components | Notes |
| --- | --- | --- | --- |
| `Main Camera` | (0, 0, −10) | Camera: orthographic, Size 5, Solid Color `#3B3326`; Audio Listener; `CameraFollow` | tag `MainCamera` |
| `Global Light 2D` | (0, 0, 0) | Light 2D (Global) | |
| `Arena` | (0, 0, 0) | — | layer `Walls`, and so are all its children |
| ↳ `Ground` | (0, 0, 0) | Sprite Renderer `sand`, Draw Mode **Tiled**, Size 24 × 16, Order in Layer −10 | the arena: x −12 to 12, y −8 to 8 |
| ↳ `Wall Top`, `Wall Bottom` | (0, ±7.78, 0) | Sprite Renderer `sandbagBrown`, **Tiled**, Size 24 × 0.44, Order in Layer 0; Box Collider 2D, **Auto Tiling**, Size 24 × 0.44 | |
| ↳ `Wall Left`, `Wall Right` | (∓11.78, 0, 0), rotation Z 90 | the same, Size 16 × 0.44 | |
| ↳ `Wall North`, `Wall South` | (0, ±3.5, 0) | the same, Size 5 × 0.44 | |
| ↳ `Wall West`, `Wall East` | (∓6.5, 0, 0), rotation Z 90 | the same, Size 4 × 0.44 | |
| ↳ `Tree` ×4 | (−8, 4.5), (8, −4.5), (−3.5, −6), (3.5, 6) | Sprite Renderer `treeLarge`, Order in Layer 4; Circle Collider 2D, Radius 0.3 | the trunk only |
| ↳ `Oil Barrel` ×4 | `barrelRed_up` (−9.5, −1), (9.5, 1); `barrelGrey_up` (−2.5, 1), (2.5, −1) | Sprite Renderer, Order in Layer 1; Circle Collider 2D, Radius 0.22 | |
| `Spawn Points` | (0, 0, 0) | — | |
| ↳ `Spawn Point 1`–`4` | (−10, 6), (10, 6), (−10, −6), (10, −6) | — | rotation Z −121, 121, −59, 59: each faces the middle |
| `Player Tank` | (0, 0, 0) | Sprite Renderer `tankBlue`, Order in Layer 1; Rigidbody 2D: Dynamic, Gravity Scale 0, Interpolate; Circle Collider 2D, Radius 0.35; Audio Source (Play On Awake off); `Tracks`; `Turret`; `Health`; `PlayerTank` | layer `Player`, and so are its children |
| ↳ `Barrel` | (0, 0, 0) | Sprite Renderer `barrelBlue` (pivot Bottom), Order in Layer 2 | |
| ↳↳ `Muzzle` | (0, 0.55, 0) | — | child of `Barrel` |
| `Arena Game` | (0, 0, 0) | `ArenaGame`; Audio Source (Play On Awake off) | repair kits become its children |

### Prefabs (`Prefabs/`)

Shells: Sprite Renderer, Order in Layer 3; Rigidbody 2D Dynamic, Gravity Scale 0; Circle Collider 2D, Is Trigger, Radius 0.08; `Shell` (Lifetime 2, Damage 1, Hit Prefab `Hit Puff`).

| Prefab | Sprite | Speed |
| --- | --- | --- |
| `Player Shell` | `bulletBlue` | 9 |
| `Enemy Shell` | `bulletRed` | 7 |

Enemy tanks: Sprite Renderer, Order in Layer 1; Rigidbody 2D Dynamic, Gravity Scale 0, Interpolate; Circle Collider 2D, Radius 0.35; a child `Barrel` (pivot Bottom, Order in Layer 2) with its own child `Muzzle` at (0, 0.55, 0); Audio Source (Play On Awake off); `Tracks`; `Turret` (Barrel, Muzzle, Shell Prefab `Enemy Shell`, its Audio Source, Shot Sound `Shot`); `Health` (its Audio Source, Hurt Sound `Hit`, no Heal Sound); `EnemyTank` (Sight Mask **Walls** and **Player**, Think Time 3).

| Prefab | Body | Barrel | Tank Name | Max Health | Move Speed | Turn Speed | Turret Turn Speed | Reload Time | Sight Range |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| `Light Tank` | `tankRed` | `barrelRed` | Light Tank | 2 | 2 | 90 | 120 | 1.6 | 8 |
| `Heavy Tank` | `tankBlack` | `barrelBlack` | Heavy Tank | 5 | 1.3 | 60 | 90 | 2.4 | 9 |

`Repair Kit`: Sprite Renderer `barrelGreen_up`, Order in Layer 1; Rigidbody 2D Kinematic; Circle Collider 2D, Is Trigger, sized to the sprite; `RepairKit` (Repair Amount 2, Lifetime 12, Spin Speed 90).

Smoke: Particle Systems at (0, 0, 0), rotation (0, 0, 0). **Main**: Looping off, Play On Awake on (the default), Start Rotation 0–360, Gravity Modifier 0, Stop Action **Destroy**. **Emission**: Rate over Time 0, one burst at time 0. **Shape**: Circle. **Color over Lifetime**: alpha 255 → 0. **Renderer**: a material in `Generated/` (`Universal Render Pipeline/2D/Sprite-Unlit-Default`, texture as below), Order in Layer 5.

| Prefab | Texture | Duration | Start Lifetime | Start Speed | Start Size | Burst | Radius |
| --- | --- | --- | --- | --- | --- | --- | --- |
| `Explosion` | `smokeOrange0` | 0.6 | 0.4–0.8 | 0.5–2.5 | 0.5–1 | 12 | 0.3 |
| `Hit Puff` | `smokeGrey1` | 0.3 | 0.2–0.4 | 0.3–1.2 | 0.25–0.45 | 6 | 0.05 |

### UI

Canvas (Screen Space Overlay; Canvas Scaler: Scale With Screen Size, 1920 × 1080, Match 0.5) and an EventSystem with the **Input System UI Input Module**. Every Text - TextMeshPro below uses TextMeshPro's default font, white, with **Raycast Target** off. The Canvas's children, in this order:

| Object | Anchor | Pos | Size | Details |
| --- | --- | --- | --- | --- |
| `Health Bar` | top-left | (40, −30) | 400 × 36 | Image `#1E1E1E` at 70% alpha, Raycast Target off |
| ↳ `Health Fill` | stretched, 4 in from every edge | | | Image `UISprite`, **Filled**, Horizontal, origin Left, Fill Amount 1, `#61CB8B`, Raycast Target off |
| `Round Text` | top-center | (0, −25) | 600 × 70 | 44, centred, empty |
| `Enemies Text` | top-right | (−40, −25) | 500 × 70 | 44, right-aligned, empty |
| `Message Text` | middle-center | (0, 150) | 1600 × 200 | 96, bold, centred, empty |
| `Settings Button` | bottom-right | (−30, 30) | 220 × 70 | Image `#D98E04`, label "Settings", 35; **On Click ()** → `Settings Panel` **GameObject.SetActive** (ticked) |
| `Start Panel` | fills the screen | | | Image black at 55% alpha (it catches presses); starts active |
| `End Panel` | fills the screen | | | Image black at 55% alpha; starts inactive |
| `Settings Panel` | fills the screen | | | Image black at 55% alpha; `SettingsMenu`; starts inactive |

Each panel holds a `Window` (middle-center, colour `#2F3B28`) whose children are anchored middle-center; the controls keep their default heights. Buttons are `#D98E04`, with their label at half the button's height.

`Start Panel` → `Window` 600 × 320, **Scale** (2, 2, 1):

| Object | Made with | Pos | Size | Details |
| --- | --- | --- | --- | --- |
| `Title` | Text - TextMeshPro | (0, 105) | 560 × 70 | "Tank Arena", 48, centred |
| `How To Play` | Text - TextMeshPro | (0, 15) | 560 × 100 | "Keys: W and S drive, A and D turn, Space fires", "Mouse or finger: the barrel aims where you point" and "Tap to fire, or press and hold to drive there", on three lines, 17, centred |
| `Play Button` | Button - TextMeshPro | (0, −105) | 200 × 50 | "Play", 25 |

`End Panel` → `Window` 560 × 360, **Scale** (2, 2, 1):

| Object | Made with | Pos | Size | Details |
| --- | --- | --- | --- | --- |
| `End Text` | Text - TextMeshPro | (0, 30) | 520 × 270 | "Destroyed!", 20, top and centre |
| `Play Again Button` | Button - TextMeshPro | (0, −145) | 200 × 40 | "Play Again", 20 |

`Settings Panel` → `Window` 420 × 300, **Scale** (2.2, 2.2, 1):

| Object | Made with | Pos | Size | Details |
| --- | --- | --- | --- | --- |
| `Title` | Text - TextMeshPro | (0, 115) | 380 × 50 | "Settings", 30, centred |
| `Volume Label` | Text - TextMeshPro | (−110, 60) | 140 × 30 | "Volume", 18, left |
| `Volume Slider` | Slider | (60, 60) | width 200 | **Value** 1 |
| `Shake Toggle` | Toggle | (10, 18) | default | **Is On**; label "Screen shake", white |
| `Name Label` | Text - TextMeshPro | (−110, −28) | 140 × 30 | "Commander", 18, left |
| `Name Input` | Input Field - TextMeshPro | (60, −28) | width 200 | placeholder "Your name", **Character Limit** 12 |
| `Colour Label` | Text - TextMeshPro | (−110, −72) | 140 × 30 | "Tank", 18, left |
| `Colour Dropdown` | Dropdown - TextMeshPro | (60, −72) | width 200 | **Options** `Blue`, `Green`, `Beige` |
| `Close Button` | Button - TextMeshPro | (0, −120) | 160 × 36 | "Close", 18 |

### References

| Component | Fields |
| --- | --- |
| `Tracks` (`Player Tank`) | Move Speed 3, Turn Speed 120 |
| `Turret` (`Player Tank`) | Barrel, Muzzle; Shell Prefab `Player Shell`; Turn Speed 360; Reload Time 0.5; Audio Source: its own; Shot Sound `Shot` |
| `Health` (`Player Tank`) | Max Health 10; Audio Source: its own; Hurt Sound `Hit`; Heal Sound `Repair` |
| `PlayerTank` | Game `Arena Game`; Tap Time 0.25 |
| `CameraFollow` | Target `Player Tank`; Smoothing 5; Default Shake 0.15 |
| `ArenaGame` | Player `Player Tank`; Camera Follow `Main Camera`; Light Tank, Heavy Tank, Repair Kit and Explosion prefabs; Spawn Points 1–4 in order; Light Tanks Per Round 2, 3, 2, 2; Heavy Tanks Per Round 0, 0, 1, 2; Repair Kit Chance 0.35; Health Fill; Round Text, Enemies Text, Message Text; Start Panel, Play Button, End Panel, End Text, Play Again Button; Audio Source: its own; Explosion Sound `Explosion`, Victory Sound `Victory`, Defeat Sound `Defeat` |
| `SettingsMenu` | Volume Slider, Shake Toggle, Name Input, Colour Dropdown, Close Button; Game `Arena Game`; Camera Follow `Main Camera`; Body Renderer `Player Tank`; Barrel Renderer its `Barrel`; Body Sprites `tankBlue`, `tankGreen`, `tankBeige`; Barrel Sprites `barrelBlue`, `barrelGreen`, `barrelBeige` (the dropdown's order) |

## 5. Workbook and site

- `Docs~/workbook/book.md` is the book's source. `Level2-Shared/Docs~/assemble.mjs` expands its `{{concept:…}}` and `{{include:check-yourself}}` markers, numbers the C# chapters, fills in the `{{ref:…}}` references, and writes `Docs~/workbook/workbook.md`: the file the PDF builder and the course site read. Never edit `workbook.md`.
- `workbook.md` follows the site's heading conventions (`# Part N — …`, `## Chapter N — …`, `## C# N — …`). The site's importer splits it into 35 pages: Before You Start, 15 build chapters, 15 C# Concepts and the four Check Yourself pages (Exam-style questions, Answers, Level 2 cheat sheet, Before Level 3: can you…).
- The cover comes from the front matter (`coverArt: image`, `coverImage: cover.png`, in `Docs~/workbook/`): a moment of the finished game, drawn from the game's own sprites.
- The book is listed in `web/levels.config.mjs` with `published: false`. Publishing needs its password secret first (see `web/README.md`).

## 6. Acceptance checks

Do all of these and report the results.

1. **Compiles clean:** after import, the Console shows **0 errors and 0 warnings** from Tank Arena's files and `Level2-Shared`'s.
2. **Scene builds:** **Tools → Tank Arena (Level 2) → Build Scene** logs `Tank Arena scene built: …` with no errors or warnings (such as `Missing sprite`, `No field`, `Shader not found` or `Missing sound`). The Game view shows the start panel over the arena, with the blue tank in the middle and a full green health bar at the top-left.
3. **Book up to date, code cards match:** `node assemble.mjs --check` (from `Level2-Shared/Docs~`) prints `up to date` for Tank Arena, and the check in `README.md` prints `MATCH` for all 12 scripts.
4. **Play test:**
   - **Before a match:** the start panel waits, over "Round 1 of 4" and "Enemies: 0"; the tank doesn't move, turn its barrel or fire; no enemies come.
   - **Start:** **Play** hides the panel. "Round 1", then 3, 2, 1 and "Go!" in the middle; two light tanks appear at the top-left and top-right spawn points, facing the middle. "Round 1 of 4" at the top, "Enemies: 2" at the top-right.
   - **Your tank:** W / S (or ↑ / ↓) drive it forwards and backwards at 3 units a second, the way it faces; A / D (or ← / →) turn it on the spot at 120° a second; walls, trees and barrels stop it; enemy tanks can be pushed. The barrel follows the mouse at up to 360° a second, around its end. **Space** or a quick click (shorter than 0.25 s) fires a blue shell from the barrel's tip, at most twice a second, with the shot sound; holding **Space** fires once. Pressing and holding the mouse button (or a finger) outside the UI turns the tank towards the pointer and drives it there, and it stops within 0.4 units.
   - **Shells:** fly straight at 9 (yours) or 7 (enemies') units a second, pass through other shells and repair kits, burst in a grey puff on walls, trees, barrels and tanks, and disappear after 2 s if they hit nothing. A tank that's hit clanks.
   - **Enemies:** each drives to a new random place every 3 s (never within 2 units of the arena's edge), turning on the spot until it roughly faces it. Within sight range (light 8, heavy 9) and with no wall, tree or barrel between it and you, it stops, turns its barrel, and fires once its barrel points at you (within 5°), no faster than its reload time (light 1.6 s, heavy 2.4 s). In the Scene view, a yellow line shows its sight ray while you're in range. A light tank takes 2 hits, a heavy tank 5.
   - **Destroyed enemies:** orange smoke (the `Explosion(Clone)` removes itself), the explosion sound, a small camera jolt (0.3 s); "Enemies" goes down. About one in three leaves a green barrel, turning slowly, gone after 12 s. Driving over it plays the repair sound and heals 2 points, never above 10.
   - **Health bar:** full green at the start, a tenth shorter per hit, back up with repairs.
   - **Rounds:** 1: 2 light; 2: 3 light; 3: 2 light and 1 heavy; 4: 2 light and 2 heavy. When the last tank of a round goes, "Round cleared!" for 2 s, then the next round's countdown.
   - **Victory:** clearing round 4 plays the victory tune and shows the end panel: `Victory!`, `Commander`, then `Rounds cleared: 4`, `Light Tanks destroyed: …`, `Heavy Tanks destroyed: …`, `Shots fired: …`, `Shots per kill: …` (one decimal).
   - **Defeat:** at 0 health your tank explodes and disappears, the defeat tune plays, the camera shakes hard (0.6 s), the rounds stop, and the end panel shows `Destroyed!` with the same lines (rounds cleared so far).
   - **Play Again:** every enemy and repair kit vanishes, your tank is back in the middle, facing up, still, with full health, and round 1 starts again with new numbers.
   - **Camera:** follows your tank smoothly, and never shows the brown world outside the arena (at 16:9, its middle stays within x −3.1 to 3.1 and y −3 to 3), except for a flicker when it shakes right at an edge.
   - **Settings** (during a match): the panel opens and everything stops (`Time.timeScale` 0): tanks, shells, the rounds, a running shake, and your tank's controls, so typing a space in the name box doesn't fire. The slider sets the volume of every sound. Unticking **Screen shake** stops the shakes (the camera still follows). A commander name (up to 12 characters; blank is ignored) is taken on **Enter** or when you click away, and appears on the end panel. **Tank** `Green` (or `Beige`, `Blue`) recolours your tank's body and barrel. **Close** carries on where the game stopped.
   - **Touch:** in the Device Simulator (a phone, turned sideways), a tap fires and a press-and-hold drives, as with the mouse; tapping or holding **Settings** never fires a shell or drives the tank.
5. **Build:** **File → Build Profiles** → **Web** (**Switch Platform**). In the Scene List, tick `Scenes/TankArena` as the only scene (the builder adds it; other levels' scenes are listed too). In **Player Settings → Publishing Settings**, set **Compression Format** to **Disabled**. The build runs in a browser (itch.io viewport 960 × 600, the default Web canvas), with the keyboard, with the mouse, and with a finger on a phone.

## 7. Out of scope

- No Animator, state machines, ScriptableObjects, scene loading, saving (`PlayerPrefs`: only a Chapter 13 challenge mentions it), C# events or delegates, inheritance or interfaces, or pathfinding. Those arrive in later levels.
- Don't change the book text. If something in the project can't match it (a menu name differs in your Unity version, say), note it in your report instead.
- Mini Golf and Space Shooter have their own specs, in their own folders.
