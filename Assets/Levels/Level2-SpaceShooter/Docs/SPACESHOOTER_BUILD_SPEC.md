# Space Shooter — Level 2 Build Spec

Spec for the **Space Shooter** game of Level 2 ("Builder") of the Unity Programmer Curriculum. Hand it to Claude in VS Code for checks or changes. It describes the Level 2 code limits, the scene, and how to verify the result.

The student book (`Docs/Level2-SpaceShooter-Workbook.pdf`, source `Docs~/workbook/book.md`, assembled into `Docs~/workbook/workbook.md`) is already written. **The project must match the book exactly**: same script names, same code, same object names, same numbers.

---

## 1. Context

- **Audience:** students who passed the Level 2 entry test (everything in Levels 0 and 1).
- **Level 2 purpose:** the topics of the 15 shared C# Concept chapters, which are methods in depth (overloads, `out`, optional parameters), event functions, components and `GetComponent`, properties and constructors, vectors, mouse and touch, raycasts, numbers and conversions, reading the Unity docs, `static` / `const` / `readonly`, lists, dictionaries, coroutines, UI events, `null` and debugging. Space Shooter teaches them through a 2D game: Pixels Per Unit and tiled sprites, keyboard and touch controls, Rigidbody 2D body types and triggers, a spawner and waves (a plain C# class and a static counter), 2D raycasts and layers, start and end screens, particles, sound and camera shake, a settings panel, and a Web build that works with touch.
- **Three books:** Level 2 has three games, each with a fully guided book that stands alone and teaches every Level 2 topic: Mini Golf (3D), Space Shooter (this one, 2D) and Tank Arena (2D). They share the C# Concept chapters and the closing Check Yourself part, in `Assets/Levels/Level2-Shared`.
- **Engine:** Unity 6 (6000.6), URP 17 with its 2D Renderer, **Universal 2D** template (the curriculum project's template too), **Input System package only** (`activeInputHandler: 1`).
- **Enter Play Mode** is set to Reload Scene only in the curriculum project, so static values survive from one Play to the next. The one static value that changes, `Enemy.AliveCount`, is reset in `WaveSpawner.Awake`.
- **Location:** `Assets/Levels/Level2-SpaceShooter/` in `~/apptrainers/unity-programmer-curriculum-levels`:

```
Assets/Levels/Level2-SpaceShooter/
├── README.md
├── Curriculum.Level2.SpaceShooter.asmdef   runtime assembly (not auto-referenced)
├── Scripts/            PlayerShip, Laser, Enemy, EnemyGun, PowerUp, WaveSpawner, ShooterGame,
│                       ScrollingBackground, CameraShake, SettingsMenu, Wave (.cs)
├── Editor/             SpaceShooterSceneBuilder.cs + Curriculum.Level2.SpaceShooter.Editor.asmdef
├── Art/Sprites/        33 Kenney Space Shooter (Remastered) sprites (.png)
├── Art/Fonts/          kenvector_future.ttf, kenvector_future_thin.ttf,
│                       kenvector_future SDF.asset                     (created by the builder)
├── Art/Kenney-License.txt
├── Audio/              sfx_laser1, sfx_laser2, sfx_lose, sfx_shieldDown, sfx_shieldUp,
│                       sfx_twoTone, sfx_zap (.ogg)
├── Prefabs/            Player Laser, Enemy Laser, Scout, Meteor, Zigzag, Gunship, Shield Power-Up,
│                       Triple Shot Power-Up, Rapid Fire Power-Up, Explosion (created by the builder)
├── Generated/          Explosion.mat                                  (created by the builder)
├── Scenes/             SpaceShooter.unity                             (created by the builder)
├── Docs/               workbook PDF, this spec
└── Docs~/workbook/     book.md (source), workbook.md (assembled), cover.png   (ignored by Unity)

Assets/Levels/Level2-Shared/
├── Docs~/              concepts/ (15 C# Concept chapters), shared/check-yourself.md,
│                       assemble.mjs, pdf/ (the PDF builder)
└── Editor/             Level2BuilderKit.cs + Curriculum.Level2.Shared.Editor.asmdef
```

## 2. Hard rules (Level 2 limits)

The eleven student scripts may use **only** Level 0, 1 and 2 topics. Don't "improve" them beyond these limits, even where a more advanced approach is better practice.

**Allowed from Levels 0 and 1:** variables, `if`, methods, `[SerializeField]` private fields, arrays, loops, `enum` and `switch`, string interpolation and number formats (such as `{score:D6}`), `Keyboard.current`, `Random.Range`, `Instantiate` / `Destroy`, trigger messages, `SetActive`, `TMP_Text.text`, `AudioSource.PlayOneShot`.

**Allowed (new in Level 2):** properties (auto, `private set`, computed); constructors and plain C# classes; `static` members and static classes; `const`; `readonly`; `List<T>`; `Dictionary<K,V>`; method overloads; optional and `out` parameters; casts and `Mathf` (`Clamp`, `Clamp01`, `Repeat`, `Sin`, `RoundToInt`, `Lerp`, `MoveTowards`, `Max`…); `Vector2` / `Vector3` maths; the event functions `Awake`, `OnEnable`, `Start`, `Update`, `FixedUpdate`, `LateUpdate`, `OnDisable`, `OnDestroy`; `GetComponent`, `TryGetComponent`, `[RequireComponent]`; `Camera.main`; coroutines (`IEnumerator`, `StartCoroutine`, `StopCoroutine`, `StopAllCoroutines`, `WaitForSeconds`, `yield return null`); the Input System's `Pointer`; `EventSystem.current.IsPointerOverGameObject()`; raycasts with layer masks (3D and 2D); UI events (`AddListener` / `RemoveListener`, `SetValueWithoutNotify` and the other `…WithoutNotify` methods); Rigidbody and Rigidbody 2D code (`AddForce`, `linearVelocity`, `MovePosition`, `MoveRotation`); `ParticleSystem.Play`; `LineRenderer`; `Time.timeScale`; `AudioListener.volume`; `Debug.DrawRay`; `Random.value`.

The scripts also use a few Unity members the book introduces where it needs them: `Quaternion.Euler`, `Destroy(gameObject, seconds)`, `Camera.ScreenToWorldPoint`, `KeyValuePair` (in a `foreach` over a dictionary), a component's `enabled`, `GameObject.activeSelf`, and an `enum` declared inside a class (`PowerUp.Kind`).

**Not allowed (later levels):** inheritance beyond `MonoBehaviour`, interfaces, abstract classes; C# events, delegates, lambdas, `Action` (`AddListener` takes method names only); `var`; LINQ; your own generics; the Animator; ScriptableObjects; `SceneManager`; `PlayerPrefs`; `FindObjectOfType` / `FindAnyObjectByType` and similar; `async` / `await`; singletons; the older `Input` class.

**Style:** as Levels 0 and 1: 4-space indentation, Allman braces, braces on every `if` / `else`, private fields without the `private` keyword, and the comments as written.

## 3. The scripts (source of truth)

The eleven files in `Scripts/` are the source of truth. The book's `csharp:FileName.cs` code cards are byte-for-byte copies (checked in section 6). The book also shows earlier versions of `PlayerShip` (Chapters 2, 3, 4 and 7, edited in Chapters 8 to 11), `Laser` (Chapters 3 and 4), `Enemy` (Chapters 4 and 5, edited in Chapter 6), `WaveSpawner` (Chapters 5 and 6, edited in Chapter 8), `ShooterGame` (Chapters 5, 6, 8 and 9, edited in Chapter 10) and `EnemyGun` (Chapter 8): each must compile at its chapter, when a student follows the book.

| Script | On | Does |
| --- | --- | --- |
| `ScrollingBackground` | `Background` | Every frame, y = its start y − `Mathf.Repeat(Time.time * speed, tileHeight)`: slides down and jumps back one tile, unseen |
| `PlayerShip` | `Player Ship` | `[RequireComponent(typeof(Rigidbody2D))]`. `Update` does nothing unless `game.IsPlaying` and the game isn't paused. Arrows / W A S D give a normalized direction; Space held fires; a `Pointer.current` press that isn't over the UI makes the ship follow a point `fingerGap` above it, and fire. `FixedUpdate` moves the body with `MovePosition` (`Vector2.MoveTowards` the pointer target, or along the keys) at `speed`, clamped between `minPosition` and `maxPosition`. `Fire` shoots one laser, or three at −12°, 0° and 12° with triple shot; `shotsPerSecond`, doubled by rapid fire. `Collect(PowerUp.Kind)`; `TakeHit()` (ignored while blinking or when there's no game; the shield takes it first); crashing into an `Enemy` → `TakeDamage(100)` and `TakeHit()`; `Blink` coroutine; `ResetShip()`; its sounds |
| `Laser` | `Player Laser`, `Enemy Laser` | `[RequireComponent(typeof(Rigidbody2D))]`. `Start` sets `linearVelocity = transform.up * speed` and `Destroy(gameObject, lifetime)`. `OnTriggerEnter2D`: a player laser damages an `Enemy`, an enemy laser (`hitsPlayer`) calls `PlayerShip.TakeHit()`; then it destroys itself |
| `Enemy` | `Scout`, `Meteor`, `Zigzag`, `Gunship` | `[RequireComponent(typeof(Rigidbody2D))]`. `static AliveCount` (+1 in `OnEnable`, −1 in `OnDisable`; `ResetCount()`). `SetGame()`. `FixedUpdate`: `MovePosition` down at `fallSpeed`, swaying `Mathf.Sin(age * swaySpeed) * swayWidth` around its start x; `MoveRotation` by `spinSpeed`; destroys itself below y = −6.5. `TakeDamage()` (guarded). `Explode()`: `game.EnemyDestroyed(enemyName, points, position)`, a `Random.value < powerUpChance` roll for a random power-up (a child of the spawner), then `Destroy` |
| `EnemyGun` | `Gunship` | When its cooldown is over: `Debug.DrawRay`, and a `Physics2D.Raycast` straight down from `muzzle`, `range` long, against `playerMask`. On a hit: a laser turned 180°, `shootSound`, and a new cooldown |
| `PowerUp` | the three power-up prefabs | `public enum Kind { Shield, TripleShot, RapidFire }`. `Start`: `linearVelocity` down at `fallSpeed`, destroyed after 10 s. On touching the `PlayerShip`: `player.Collect(kind)`, then destroys itself |
| `Wave` | — (plain C# class) | `Name`, `EnemyPrefabs`, `Count`, `Delay` (`private set`, set by the constructor); `RandomEnemy()` |
| `WaveSpawner` | `Wave Spawner` | `Awake`: `Enemy.ResetCount()` and the five waves, in a `readonly List<Wave>`. `WaveCount`. `StartWaves()`; `StopWaves()` (stops the coroutine, destroys all its children). `RunWaves`: for each wave, `game.WaveStarted()`, 2 s, then `Count` enemies `Delay` apart at a random x within ±`spawnWidth`, y = `spawnHeight`, each handed the game with `SetGame`; then waits a frame at a time until `Enemy.AliveCount` is 0. After the last wave, `game.Win()` |
| `ShooterGame` | `Shooter Game` | `const int StartingLives = 3`; score, lives, and a `Dictionary<string, int>` of kills. `IsPlaying`, `PilotName` (`"Pilot"`). **Play** and **Play Again** call `StartGame()` (`AddListener` in `OnEnable`). `WaveStarted()`, `EnemyDestroyed()` (points, kill count, explosion, sound, `Shake(0.15f)`), `PlayerHit()` (`Shake(0.4f, 0.3f)`; at 0 lives: explosion, ship off, `EndGame("Game Over")`), `Win()`, `EndGame()`; `ShowMessage` overloads (stays / goes after N seconds); `UpdateScreen()` (`$"{score:D6}"`, the life icons) |
| `CameraShake` | `Main Camera` | `Shake(seconds)` (with `defaultStrength`) and `Shake(seconds, power)` overloads. `LateUpdate`: home + a random jolt × strength while time is left and the game isn't paused (`Time.timeScale > 0`), otherwise home. `OnDisable` puts the camera home |
| `SettingsMenu` | `Settings Panel` | `OnEnable`: shows the current volume, shake setting and name without notifying, adds five listeners, sets `Time.timeScale` to 0. `OnDisable`: removes them, sets `Time.timeScale` to 1. Volume → `AudioListener.volume`; toggle → `cameraShake.enabled`; name (on end edit, trimmed, not blank) → `game.PilotName`; dropdown → the ship's sprite and every life icon's sprite; **Close** hides the panel |

Rules: 3 lives. Points: Scout 100, Meteor 50, Zigzag 150, Gunship 250 (crashing into an enemy destroys it and scores it too). An enemy laser or a crash costs a life, unless the shield is up or the ship is blinking after a hit. Each destroyed enemy drops a power-up 12% of the time. Triple shot and rapid fire last 8 seconds; the shield lasts until it's hit. A new wave starts only when every enemy of the last one has gone. Clearing wave 5 wins.

The five waves (`WaveSpawner.Awake`):

| Wave | Name | Enemies | Count | Delay (s) |
| --- | --- | --- | --- | --- |
| 1 | Scouts | Scout | 8 | 0.7 |
| 2 | Meteor Shower | Meteor | 10 | 0.6 |
| 3 | Zigzag Squadron | Zigzag | 8 | 0.8 |
| 4 | Gunships | Gunship | 5 | 1.5 |
| 5 | Everything! | Scout, Meteor, Zigzag, Gunship (random) | 16 | 0.6 |

## 4. The scene

`Assets/Levels/Level2-SpaceShooter/Scenes/SpaceShooter.unity`, created by **Tools → Space Shooter (Level 2) → Build Scene** (`Editor/SpaceShooterSceneBuilder.cs`, with the helpers in `Level2-Shared/Editor/Level2BuilderKit.cs`). Before it builds the scene, the builder:

- checks for the **TMP Essential Resources**; if they're missing, it opens the Import Unity Package window (click **Import**) and asks you to run it again;
- asks about unsaved changes in the open scene;
- adds the `Player` layer (in the first free User Layer) if it's missing;
- makes `Art/Fonts/kenvector_future SDF.asset`, a TextMeshPro font asset from `kenvector_future.ttf` (only if it doesn't exist yet);
- imports every sprite it uses as a single sprite, 100 Pixels Per Unit, pivot centre, no mipmaps, and `darkPurple` with Mesh Type **Full Rect** (tiling needs it);
- creates the ten prefabs below, overwriting them.

Then it builds the scene, saves it, puts it first in Build Settings and logs `Space Shooter scene built: Assets/Levels/Level2-SpaceShooter/Scenes/SpaceShooter.unity`.

### World objects

| Object | Position | Components | Notes |
| --- | --- | --- | --- |
| `Main Camera` | (0, 0, −10) | Camera: orthographic, Size 5, Solid Color `#0B0B1A`; Audio Listener; `CameraShake` (Default Strength 0.1) | tag `MainCamera`; shows y −5 to 5 |
| `Global Light 2D` | (0, 0, 0) | Light 2D (Global) | |
| `Background` | (0, 0, 0) | Sprite Renderer: `darkPurple` (Mesh Type Full Rect), Draw Mode **Tiled**, Size 25.6 × 15.36, Order in Layer −10; `ScrollingBackground` (Speed 1, Tile Height 2.56) | 10 × 6 tiles of 2.56: wide enough for a phone on its side |
| `Player Ship` | (0, −3.5, 0) | Sprite Renderer `playerShip1_blue`, Order in Layer 1; Rigidbody 2D: Dynamic, Gravity Scale 0, Freeze Rotation Z, Interpolate; Circle Collider 2D: Is Trigger, Radius 0.35; Audio Source (Play On Awake off); `PlayerShip` | layer `Player` |
| ↳ `Muzzle` | (0, 0.5, 0) | — | child of `Player Ship` |
| ↳ `Shield` | (0, 0.1, 0) | Sprite Renderer `shield1`, Order in Layer 2 | child of `Player Ship`; starts inactive |
| `Wave Spawner` | (0, 0, 0) | `WaveSpawner` (Spawn Width 7.5, Spawn Height 6) | enemies and dropped power-ups become its children |
| `Shooter Game` | (0, 0, 0) | `ShooterGame`, Audio Source (Play On Awake off) | |

### Prefabs (`Prefabs/`)

Lasers: Sprite Renderer (Order in Layer 0); Rigidbody 2D Dynamic, Gravity Scale 0; Box Collider 2D, Is Trigger, sized to the sprite; `Laser` (Lifetime 1.5, Damage 1).

| Prefab | Sprite | Speed | Hits Player |
| --- | --- | --- | --- |
| `Player Laser` | `laserBlue01` | 12 | off |
| `Enemy Laser` | `laserRed01` | 8 | on |

Enemies: Sprite Renderer (Order in Layer 1); Rigidbody 2D Kinematic, Interpolate; Circle Collider 2D, Is Trigger, Radius 0.4; `Enemy` with Sway Speed 2, Power Up Chance 0.12 and **Power Up Prefabs** = the three power-ups.

| Prefab | Sprite | Enemy Name | Max Health | Points | Fall Speed | Sway Width | Spin Speed |
| --- | --- | --- | --- | --- | --- | --- | --- |
| `Scout` | `enemyBlack1` | Scout | 1 | 100 | 2.5 | 0 | 0 |
| `Meteor` | `meteorBrown_big1` | Meteor | 3 | 50 | 1.5 | 0 | 60 |
| `Zigzag` | `enemyBlue3` | Zigzag | 2 | 150 | 2 | 2 | 0 |
| `Gunship` | `enemyRed2` | Gunship | 3 | 250 | 1 | 0 | 0 |

`Gunship` also has a child `Muzzle` at (0, −0.55, 0), an Audio Source (Play On Awake off), and `EnemyGun`: Laser Prefab `Enemy Laser`, Muzzle, Player Mask `Player`, Range 12, Cooldown 1.2, its Audio Source, Shoot Sound `sfx_laser2`.

Power-ups: Sprite Renderer (Order in Layer 1); Rigidbody 2D Kinematic; Circle Collider 2D, Is Trigger, sized to the sprite; `PowerUp` (Fall Speed 1.5).

| Prefab | Sprite | Kind |
| --- | --- | --- |
| `Shield Power-Up` | `powerupBlue_shield` | Shield |
| `Triple Shot Power-Up` | `powerupRed_star` | Triple Shot |
| `Rapid Fire Power-Up` | `powerupYellow_bolt` | Rapid Fire |

`Explosion`: a Particle System at (0, 0, 0), rotation (0, 0, 0). **Main** Duration 0.5, Looping off, Play On Awake on (the default), Start Lifetime 0.4–0.8, Start Speed 1–4, Start Size 0.15–0.35, Start Color random between `#FFE066` and `#FF8A3D`, Gravity Modifier 0, Stop Action **Destroy**. **Emission** Rate over Time 0, one burst of 30 at time 0. **Shape** Circle, Radius 0.2. **Color over Lifetime** alpha 255 → 0. **Renderer** material `Generated/Explosion.mat` (`Universal Render Pipeline/2D/Sprite-Unlit-Default`, texture `star1`), Order in Layer 5.

### UI

Canvas (Screen Space Overlay; Canvas Scaler: Scale With Screen Size, 1920 × 1080, Match 0.5) and an EventSystem with the **Input System UI Input Module**. Every Text - TextMeshPro below is white, with **Raycast Target** off; "Kenney font" means `kenvector_future SDF`. The Canvas's children, in this order:

| Object | Anchor | Pos | Size | Details |
| --- | --- | --- | --- | --- |
| `Score Text` | top-right | (−40, −25) | 500 × 90 | Kenney font, 64, right-aligned, `000000` |
| `Wave Text` | top-center | (0, −30) | 700 × 70 | Kenney font, 40, centred, empty |
| `Message Text` | middle-center | (0, 150) | 1700 × 200 | Kenney font, 80, centred, empty |
| `Life Icon 1`–`3` | top-left | (40, −30), (125, −30), (210, −30) | 66 × 52 | Image `playerLife1_blue`, Preserve Aspect, Raycast Target off |
| `Settings Button` | bottom-right | (−30, 30) | 220 × 70 | Image `#3A8DDE`, label "Settings", 35; **On Click ()** → `Settings Panel` **GameObject.SetActive** (ticked) |
| `Start Panel` | fills the screen | | | Image black at 55% alpha (it catches presses); starts active |
| `End Panel` | fills the screen | | | Image black at 55% alpha; starts inactive |
| `Settings Panel` | fills the screen | | | Image black at 55% alpha; `SettingsMenu`; starts inactive |

Each panel holds a `Window` (middle-center, colour `#2A2340`) whose children are anchored middle-center; the controls keep their default heights.

`Start Panel` → `Window` 600 × 300, **Scale** (2, 2, 1):

| Object | Made with | Pos | Size | Details |
| --- | --- | --- | --- | --- |
| `Title` | Text - TextMeshPro | (0, 90) | 560 × 70 | "Space Shooter", Kenney font, 48, centred |
| `How To Play` | Text - TextMeshPro | (0, 10) | 560 × 80 | "Fly: arrow keys or W A S D, or drag with a finger" and "Fire: hold Space, or keep your finger down", on two lines, 18, centred |
| `Play Button` | Button - TextMeshPro | (0, −95) | 200 × 50 | `#3A8DDE`, "Play", 25 |

`End Panel` → `Window` 560 × 340, **Scale** (2, 2, 1):

| Object | Made with | Pos | Size | Details |
| --- | --- | --- | --- | --- |
| `End Text` | Text - TextMeshPro | (0, 30) | 520 × 250 | "Game Over", 22, top and centre |
| `Play Again Button` | Button - TextMeshPro | (0, −135) | 200 × 40 | `#3A8DDE`, "Play Again", 20 |

`Settings Panel` → `Window` 420 × 300, **Scale** (2.2, 2.2, 1):

| Object | Made with | Pos | Size | Details |
| --- | --- | --- | --- | --- |
| `Title` | Text - TextMeshPro | (0, 115) | 380 × 50 | "Settings", Kenney font, 30, centred |
| `Volume Label` | Text - TextMeshPro | (−110, 60) | 140 × 30 | "Volume", 18, left |
| `Volume Slider` | Slider | (60, 60) | width 200 | **Value** 1 |
| `Shake Toggle` | Toggle | (10, 18) | default | **Is On**; label "Screen shake", white |
| `Name Label` | Text - TextMeshPro | (−110, −28) | 140 × 30 | "Pilot", 18, left |
| `Name Input` | Input Field - TextMeshPro | (60, −28) | width 200 | placeholder "Your name", **Character Limit** 12 |
| `Ship Label` | Text - TextMeshPro | (−110, −72) | 140 × 30 | "Ship", 18, left |
| `Ship Dropdown` | Dropdown - TextMeshPro | (60, −72) | width 200 | **Options** `Blue`, `Green`, `Orange`, `Red` |
| `Close Button` | Button - TextMeshPro | (0, −120) | 160 × 36 | `#3A8DDE`, "Close", 18 |

### References

| Component | Fields |
| --- | --- |
| `PlayerShip` | Game `Shooter Game`; Laser Prefab `Player Laser`; Muzzle; Shield; Ship Renderer: its Sprite Renderer; Audio Source: its own; Laser Sound `sfx_laser1`, Power Up Sound `sfx_shieldUp`, Shield Down Sound `sfx_shieldDown`; defaults Speed 8, Shots Per Second 4, Power Up Seconds 8, Finger Gap 1, Min Position (−8.2, −4.4), Max Position (8.2, 1) |
| `WaveSpawner` | Game `Shooter Game`; Scout, Meteor, Zigzag and Gunship prefabs |
| `ShooterGame` | Player `Player Ship`; Spawner `Wave Spawner`; Camera Shake `Main Camera`; Explosion Prefab; Score Text, Wave Text, Message Text; Life Icons: `Life Icon 1`, `2`, `3` in order; Start Panel, Play Button, End Panel, End Text, Play Again Button; Audio Source: its own; Explosion Sound `sfx_zap`, Lose Life Sound `sfx_shieldDown`, Wave Sound `sfx_twoTone`, Game Over Sound `sfx_lose` |
| `SettingsMenu` | Volume Slider, Shake Toggle, Name Input, Ship Dropdown, Close Button; Game `Shooter Game`; Camera Shake `Main Camera`; Ship Renderer `Player Ship`; Ship Sprites `playerShip1_blue`, `_green`, `_orange`, `_red`; Life Icons: the three; Life Sprites `playerLife1_blue`, `_green`, `_orange`, `_red` (the dropdown's order) |

## 5. Workbook and site

- `Docs~/workbook/book.md` is the book's source. `Level2-Shared/Docs~/assemble.mjs` expands its `{{concept:…}}` and `{{include:check-yourself}}` markers, numbers the C# chapters, fills in the `{{ref:…}}` references, and writes `Docs~/workbook/workbook.md`: the file the PDF builder and the course site read. Never edit `workbook.md`.
- `workbook.md` follows the site's heading conventions (`# Part N — …`, `## Chapter N — …`, `## C# N — …`). The site's importer splits it into 34 pages: Before You Start, 14 build chapters, 15 C# Concepts and the four Check Yourself pages (Exam-style questions, Answers, Level 2 cheat sheet, Before Level 3: can you…).
- The cover comes from the front matter (`coverArt: image`, `coverImage: cover.png`, in `Docs~/workbook/`).
- The book is listed in `web/levels.config.mjs` with `published: false`. Publishing needs its password secret first (see `web/README.md`).

## 6. Acceptance checks

Do all of these and report the results.

1. **Compiles clean:** after import, the Console shows **0 errors and 0 warnings** from Space Shooter's files and `Level2-Shared`'s.
2. **Scene builds:** **Tools → Space Shooter (Level 2) → Build Scene** logs `Space Shooter scene built: …` with no errors or warnings (such as `Missing sprite`, `No field`, `Shader not found` or `Missing sound`). The Game view shows the start panel over the starfield, `000000` at the top-right, three blue life icons at the top-left, and the ship near the bottom.
3. **Book up to date, code cards match:** `node assemble.mjs --check` (from `Level2-Shared/Docs~`) prints `up to date` for Space Shooter, and the check in `README.md` prints `MATCH` for all 11 scripts.
4. **Play test:**
   - **Before a game:** the start panel waits; the starfield slides down, with no visible jump; the ship doesn't move or fire; no enemies come.
   - **Start:** **Play** hides the panel. `Wave 1 of 5` at the top, `Scouts` in the middle for 2 seconds, and the wave chime; 2 seconds later the scouts arrive, one every 0.7 s, from random places along the top (x between −7.5 and 7.5).
   - **Waves:** 1 Scouts ×8, 2 Meteor Shower ×10, 3 Zigzag Squadron ×8, 4 Gunships ×5, 5 Everything! ×16 (all four kinds, mixed). The next wave starts only when every enemy of the last one has been destroyed or has flown off the bottom (y below −6.5).
   - **Enemies:** a scout breaks with one laser, a zigzag with two, a meteor and a gunship with three. Scouts fall at 2.5 units a second, zigzags at 2, swaying 2 units each way; meteors fall at 1.5 and spin 60° a second; gunships fall at 1.
   - **Ship:** arrows or W A S D fly it at 8 units a second, as fast diagonally as straight, inside x −8.2 to 8.2 and y −4.4 to 1. Holding Space fires 4 blue lasers a second from the nose, each gone after 1.5 s, with the laser sound. Holding the mouse button (or a finger) outside the UI: the ship flies towards a point 1 unit above the pointer, at the same top speed, and fires.
   - **Hits:** a destroyed enemy bursts into yellow and orange stars (the `Explosion(Clone)` removes itself), the zap sound plays, the camera jolts (0.15 s), and the score adds its points: 100, 50, 150 or 250, shown with six digits (`000250`).
   - **Power-ups:** about one destroyed enemy in eight (12%) drops a random power-up, drifting down at 1.5 units a second and gone after 10 s if nobody collects it. Touching it plays the shield-up sound. Shield: a ring round the ship that takes the next hit instead of a life (shield-down sound). Triple shot: three lasers at a time, for 8 s. Rapid fire: 8 shots a second, for 8 s.
   - **Gunships:** when the ship is right below one, within 12 units, it fires a red laser straight down (at most every 1.2 s), with its own sound. In the Scene view, a red line shows its ray while its gun is ready.
   - **Lives:** a red laser, or crashing into an enemy (which destroys the enemy and scores it), costs a life: the rightmost life icon goes, the camera shakes harder (0.4 s), the shield-down sound plays, and the ship blinks for 1.5 seconds, during which nothing can hurt it.
   - **Game over:** at 0 lives the ship explodes and disappears, the lose sound plays, every enemy and dropped power-up vanishes, and the end panel shows `Game Over`, `Pilot: 001234 points` (the pilot name and the score), then one line per kind of enemy destroyed (`Scout: 8`).
   - **Win:** clearing wave 5 shows the same end panel with `You Win!`.
   - **Play Again:** score `000000`, three lives, the ship back at the start with no shield or power-ups, and wave 1 again.
   - **Settings** (during a game): the panel opens and everything stops (`Time.timeScale` 0): enemies, lasers, the starfield, and the ship's controls, so typing a space in the name box doesn't fire. The slider sets the volume of every sound. Unticking **Screen shake** switches `CameraShake` off. A pilot name (up to 12 characters; blank is ignored) is taken on **Enter** or when you click away, and appears on the end screen. **Ship** `Red` (or `Green`, `Orange`, `Blue`) recolours the ship and the three life icons. **Close** carries on where the game stopped.
   - **Play again:** stop and press Play again, twice in a row: wave 1 starts normally each time (`WaveSpawner.Awake` also resets the static `Enemy.AliveCount`).
5. **Build:** **File → Build Profiles** → **Web** (**Switch Platform**). In the Scene List, tick `Scenes/SpaceShooter` as the only scene (the builder adds it; other levels' scenes are listed too). In **Player Settings → Publishing Settings**, set **Compression Format** to **Disabled**. The build runs in a browser, with the keyboard, with the mouse, and with a finger on a phone.

## 7. Out of scope

- No Animator, state machines, ScriptableObjects, scene loading, saving (`PlayerPrefs`: only a Chapter 12 challenge mentions it), C# events or delegates, inheritance or interfaces. Those arrive in later levels.
- Don't change the book text. If something in the project can't match it (a menu name differs in your Unity version, say), note it in your report instead.
- Mini Golf and Tank Arena have their own specs, in their own folders.
