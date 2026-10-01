# Knight Run — Level 3 Build Spec

Spec for **Knight Run**, the core game of Level 3 ("Junior-ready") of the Unity Programmer
Curriculum. Hand it to Claude in VS Code for checks or changes.

> **Status: built, waiting for Moayad's play-test.** Moayad approved design version 2 on
> 1 October 2026: the **Brackeys Platformer Bundle** for the art, stomp and roll for the
> knight (no sword), and every section of the level painted step by step. The scripts,
> the scene builder and the book (`Docs/Level3-KnightRun-Workbook.pdf`) are done, and
> the book is on the course site. This spec is the source of truth for the scripts,
> the scene builder and the book, as Level 2's specs are. The exact tile-by-tile map is
> `Editor/KnightRunLevel.txt`.

---

## 1. Context

- **Audience:** students who passed the Level 3 entry test, which tests Level 2. Everything
  in Levels 0–2 is theirs to use.
- **Level 3's purpose:** students build complete games on their own, with animated state
  machines and readable code. The level ends at the **Unity Certified User: Programmer**
  exam. Knight Run teaches every Level 3 topic through a 2D platformer: the Animation
  window, the Animator Controller, driving it from code, Animation Events, state machines
  in code and in the Animator, health bars and menus, naming conventions, reading code,
  finding errors, kinds of classes, and the exam itself.
- **Three books, one at a time:** Level 3 has three games, each with a book that stands
  alone: **Knight Run** (this one, the core game), **Crypt Keys** and **Gate Guard**. They
  are built one after another, and share the 12 C# Concept chapters and the closing Check
  Yourself part, which are written with this first book, in `Assets/Levels/Level3-Shared`.
  See `GAMES_PLAN.md`.
- **Engine:** Unity 6 (6000.6), URP 17 with its 2D Renderer, **Universal 2D** template,
  **Input System package only**. Enter Play Mode is set to Reload Scene only; Knight Run's
  only statics are `static readonly` Animator hashes, which never change.
- **Location:** `Assets/Levels/Level3-KnightRun/` in `~/apptrainers/unity-programmer-curriculum-levels`:

```
Assets/Levels/Level3-KnightRun/
├── README.md
├── Curriculum.Level3.KnightRun.asmdef      runtime assembly (not auto-referenced)
├── Scripts/            the 14 scripts in section 6
├── Editor/             KnightRunSceneBuilder.cs, KnightRunLevel.txt (the level's map),
│                       Curriculum.Level3.KnightRun.Editor.asmdef
├── Art/                Sprites/ and Fonts/ from the bundle, Brackeys-License.txt
├── Audio/              the bundle's 6 sounds and its music
├── Animation/          21 clips, 4 Animator Controllers, 1 Override Controller (created by the builder)
├── Tiles/              127 Tile assets and the Knight Run Palette (created by the builder)
├── Prefabs/            Slime, Purple Slime, Coin, Apple, Checkpoint, and the Meadow,
│                       Woods and Castle Platforms              (created by the builder)
├── Materials/          No Friction.physicsMaterial2D           (created by the builder)
├── Scenes/             KnightRun.unity                         (created by the builder)
├── Docs/               workbook PDF, this spec
└── Docs~/workbook/     book.md (source), workbook.md (assembled), cover.png

Assets/Levels/Level3-Shared/
├── README.md
├── Docs~/              concepts/ (12 C# Concept chapters), shared/check-yourself.md,
│                       assemble.mjs, check-code.mjs, pdf/ (the PDF builder);
│                       entry-test/ comes with the Level 3 entry test
└── Editor/             Level3BuilderKit.cs + Curriculum.Level3.Shared.Editor.asmdef
```

## 2. Hard rules (Level 3 limits)

The scripts may use **only** Level 0–3 topics. Don't "improve" them beyond these limits,
even where a more advanced approach is better practice.

**Allowed from Levels 0–2:** everything a Level 2 spec allows (for example
`Level2-SpaceShooter/Docs/SPACESHOOTER_BUILD_SPEC.md`, section 2): properties, plain C#
classes, `static`, `const`, `readonly`, `List<T>`, `Dictionary<K,V>`, overloads, `out`,
`Mathf`, vectors, the event functions, `GetComponent` and `TryGetComponent`, coroutines,
`Keyboard.current` and `Pointer.current`, raycasts with layer masks, UI events with
`AddListener`, Rigidbody 2D code, `Time.timeScale`, `AudioListener.volume`.

**New at Level 3:**

- state machines with `enum` + `switch`, with an enter step for each state
  (`EnterState(State next)`);
- the Animator API: `SetFloat`, `SetBool`, `SetTrigger`, `SetInteger`, and
  `Animator.StringToHash` in `static readonly int` fields;
- Animation Events;
- `[System.Serializable]` plain classes in Inspector arrays;
- naming conventions, applied everywhere.

The scripts and the scene also use a few Unity members the book introduces where it needs
them: `Collision2D.GetContact` (for the stomp), `Animator.Rebind` (Restart puts each
Animator back to its first state), `GetComponentsInChildren<T>(true)`, an `Image` of type
**Filled** (`fillAmount`), the **Event Trigger** component, wired in the Inspector, the
**Platform Effector 2D** (one-way platforms, no code) and the **Animator Override
Controller** (the purple slime's clips, no code).

**Not allowed yet:**

- from Level 4: inheritance (`virtual`, `override`, `abstract`), interfaces, C# events,
  `Action`, delegates and lambdas, `Queue` and `Stack`, loading scenes (`SceneManager`),
  `PlayerPrefs` and JSON saves, making ScriptableObjects, prefab variants, object pooling,
  the Input Actions asset, `try` / `catch`;
- from Level 5: blend trees, Animator layers and avatar masks, Cinemachine, Timeline, LINQ,
  writing generics, `async` / `await`, singletons;
- never in game code: `var`, `FindObjectOfType` / `FindAnyObjectByType` and similar, and
  the older `Input` class.

Two consequences, both said out loud in the book:

- **One enemy script, two kinds.** The purple slime is the `Slime` script with other
  numbers in the Inspector, on a copy of the Slime prefab, with an Animator Override
  Controller for its clips. Prefab variants wait for Level 4, and so do base classes and
  interfaces for enemies that really differ: a deliberate "this gets better later".
- **Restart resets the level in code**: every slime, coin, apple and checkpoint has a
  reset method. Loading the scene again waits for Level 4.

**Style:** as Levels 0–2 (4-space indentation, Allman braces, braces on every `if` /
`else`, private fields without the `private` keyword), plus Level 3's naming conventions:

| What | Convention | Example |
| --- | --- | --- |
| Classes, methods, properties, enum types and values | PascalCase | `KnightHealth`, `TakeDamage`, `IsRolling`, `State.Chase` |
| Fields, local variables, parameters | camelCase | `moveSpeed`, `hitCount` |
| Booleans | read as a yes/no question | `isGrounded`, `isRolling`, `isLit` |
| `const` and `static readonly` | PascalCase | `MaxHealth`, `SpeedHash` |
| Animator parameters | PascalCase strings, hashed once | `static readonly int SpeedHash = Animator.StringToHash("Speed");` |
| Methods called by Animation Events | start with `On` | `OnRollFinished`, `OnFootstep` |

## 3. The game

A small knight runs, jumps and rolls through **one long level in three sections**, with a
checkpoint sign between them. He stomps on slimes or rolls into them, collects coins and
apples, and walks into the castle door at the far end.

| Section | Name | What it teaches the player | In it |
| --- | --- | --- | --- |
| 1 | **The Meadow** | running, jumping, stomping | green grass, trees and a blue sky; two water pits, a floating platform, 3 green slimes, 10 coins, an apple |
| 2 | **The Autumn Woods** | the roll, and purple slimes | gold grass, orange trees and mushrooms under a sunset; one-way platforms over a long pit of purple goo, 2 green and 2 purple slimes, 10 coins, an apple on a high ledge |
| 3 | **The Castle Walls** | everything together | snowy stone walls under a dusk sky; steps, gaps over the moat that need a running jump, 2 green and 3 purple slimes, 10 coins, an apple before the last climb, the castle door |

**Controls**

| Action | Keyboard | Touch (shown only on a touchscreen) |
| --- | --- | --- |
| Run | A / D or ← / → | ◀ and ▶ buttons, bottom-left |
| Jump | Space, W or ↑ | Jump button, bottom-right |
| Roll | Shift or J | Roll button, bottom-right |
| Pause | Esc or P, or the pause button | the pause button, top-right |

The touch buttons work with two fingers at once (run and jump together): each one is an
**Event Trigger** with Pointer Down, Pointer Up and Pointer Exit, wired in the Inspector.

**Rules**

- The knight has **5 health**. Touching a slime costs 1 health, knocks him back, and makes
  him blink for 1 second, when nothing can hurt him.
- **Stomp:** landing on a slime from above hits it, and he bounces up.
- **Roll:** on the ground, a quick roll forwards. While he rolls, slimes can't hurt him,
  and any slime he rolls into is hit.
- A green slime takes 1 hit. A purple slime takes 2, and flashes red after the first.
- Falling into water, goo or the moat costs 1 health and puts him back at the last
  checkpoint (the start, at first).
- At 0 health he falls, and the **Try Again** panel shows.
- An apple gives back 1 health, up to 5. A full-health knight leaves apples where they are.
- Coins only count: the win panel shows how many of the 30 he found, and the time.
- Walking into the castle door wins.
- **Restart** (pause menu, win panel, lose panel) puts everything back as it started: the
  knight, his health, every slime, coin, apple and checkpoint, the coin count and the time.

**Numbers** (tuned while building; the book and spec then agree on the final ones)

| Thing | Value |
| --- | --- |
| Tile | 1 × 1 unit: 16 pixels, and every sprite is imported at 16 Pixels Per Unit |
| Level | about 190 units long, three sections of about 63 |
| Camera | orthographic, size 5 (10 tiles tall), follows the knight, kept inside the level |
| Knight | run 6 units/s, jump speed 12, Gravity Scale 3 (about 2.4 units high, 4.5 across at a run) |
| Roll | 9 units/s while the Roll clip plays (8 frames, about 0.55 s, so about 5 units); then 0.4 s before the next; on the ground only |
| Stomp | bounce speed 9 |
| Hurt | knockback (5, 6) away from the slime; no control for 0.25 s; blinking for 1 s |
| Green slime | 1 health; patrols at 1.5 units/s; chases at 2.5 when the knight is within 4 units and about level with it; leaps at him from 1.2 units away |
| Purple slime | 2 health; patrols at 2; chases at 3.5 within 5 units; leaps from 2 units away |
| Pickups | 30 coins (10 per section), 3 apples, 2 checkpoints and the castle door |

## 4. The level

The level is painted on **Tilemaps** with the Tile Palette, all under one `Grid`. Every
tile uses **Collider Type: Grid**: the tileset's blocks have rounded corners, and their
outlines would leave notches between tiles for the knight's feet to catch on.

- `Ground`: a Tilemap Collider 2D (Composite Operation: Merge) merged by a Composite
  Collider 2D (Geometry Type: Polygons) with a Static Rigidbody 2D, on the `Ground` layer.
  The builder calls `ProcessTilemapChanges` and `GenerateGeometry` before saving: the
  Editor makes the shapes a moment after painting, and a composite saved without them
  stays empty in Play mode;
- `Hazards`: the water, goo and moat tiles, with a Tilemap Collider 2D set to **Is
  Trigger** and the `KillZone` script, so every liquid tile students paint is deadly;
- `Decoration`: trees, bushes, mushrooms, fences, the castle's wall and its dark doorway;
  no collider.

**The sky** is the camera's background colour, a different one per section, eased from
one to the next in code (each `Section` holds its colour): `#8ED0F2` for the Meadow,
`#FAD3B3` for the Autumn Woods, `#6F2C77` for the Castle Walls. A Challenge paints clouds
from the tileset's sky tiles.

**Floating platforms** are the bundle's platform sprites, each with a Box Collider 2D
(Used By Effector) and a **Platform Effector 2D** (Use One Way): the knight jumps up
through them and lands on top. No code. The Meadow has one and the woods four; the
Castle Walls have none, so the Castle Platform prefab is spare, for students' own
sections.

The scene builder paints the level from `Editor/KnightRunLevel.txt`: three sections of
63 columns, rows from y = 10 down to y = −3, where `#` is ground, `~` liquid, `==` a
platform, `w` and `o` the keep's wall and doorway, `D` the door, and `K C A s p P` the
knight, coins, apples, green and purple slimes and checkpoint signs. Ground's top tile is
the one with nothing above it; decorations are `T` (a tree, 3 tiles tall), `b`, `f`, `m`,
`n` and `k`. The book prints the same map, one section at a time, in Chapters 1, 8 and 13. The
Meadow's, from Chapter 1 (its rows 4 to 10 are empty):

```
       0         10        20        30        40        50        60
       |         |         |         |         |         |         |
   3   .............CC................................................
   2   ...........................C.C.C...............................
   1   ....C.C.C....==......####............................C.C..A....
   0   T.K...f...........b..####...s...........T..s..n..s..b....####fP
  -1   #############...##################...##########################
  -2   #############~~~##################~~~##########################
  -3   #############~~~##################~~~##########################
```

`T` is a tree, `b` a bush, `f` flowers and `n` a small mushroom; the woods add `m`, a big
mushroom, and `k`, a pumpkin. A change to `KnightRunLevel.txt` needs the same change in
the book's maps and in its lists of positions.

- **Students paint every section step by step:** Section 1 in Chapter 1, where they learn
  the Tile Palette; Section 2 in Chapter 8, with the purple slime; Section 3 in Chapter
  13, at the end. Each comes with its map and every step to paint it. A Challenge invites
  them to design a section of their own.
- A long, invisible **Kill Zone** (a trigger, with the same `KillZone` script) lies under
  the whole level as a safety net.
- Three empty GameObjects hold the level's things, so scripts can find them all with
  `GetComponentsInChildren<T>(true)`: `Enemies`, `Pickups` and `Checkpoints`.

## 5. The scene

`Assets/Levels/Level3-KnightRun/Scenes/KnightRun.unity`, created by
**Tools → Knight Run (Level 3) → Build Scene** (`Editor/KnightRunSceneBuilder.cs`, with the
helpers in `Level3-Shared/Editor/Level3BuilderKit.cs`). Before building, it adds the
`Ground`, `Knight` and `Enemy` layers if they're missing, imports the sprites, creates the
tiles and palette, the animation clips, the Animator Controllers and the Override
Controller, and the prefabs. It saves the scene, puts it first in Build Settings and logs
`Knight Run scene built: …`.

| Object | Components | Notes |
| --- | --- | --- |
| `Main Camera` | Camera (orthographic, size 5), Audio Listener, `CameraFollow` | its background colour is the sky |
| `Global Light 2D` | Light 2D (Global) | |
| `Grid` → `Ground`, `Hazards`, `Decoration` | Tilemap, Tilemap Renderer; `Ground` also Tilemap Collider 2D, Composite Collider 2D, Rigidbody 2D (Static); `Hazards` also Tilemap Collider 2D (Is Trigger) and `KillZone` | `Ground` on layer `Ground` |
| `Knight` | Sprite Renderer (Order 5), Rigidbody 2D (Dynamic, Gravity Scale 3, Freeze Rotation, Interpolate, Continuous, the No Friction material), Capsule Collider 2D (0.7 × 1.15, offset 0.575), **Animator**, Audio Source, `KnightController`, `KnightCombat`, `KnightHealth` | layer `Knight`; the sprite and the Animator on the same object, so a clip's sprite curve has no path, and the Animation Event receivers are beside the Animator |
| ↳ `Left Foot`, `Right Foot` | — | at (∓0.25, 0.05): where the two ground rays start |
| `Platforms` | — | the floating platforms: Sprite Renderer, Box Collider 2D (Used By Effector), Platform Effector 2D |
| `Enemies` | — | 7 `Slime` and 5 `Purple Slime` prefab instances |
| `Pickups` | — | 30 `Coin` and 3 `Apple` instances |
| `Checkpoints` | — | 2 `Checkpoint` instances: a root with the trigger, the Animator and the script, and a `Sign` child with the picture, half a tile up, so the clips bounce and sway the post from its foot |
| `Castle Door` | Box Collider 2D (trigger), `CastleDoor` | in the doorway painted on `Decoration` |
| `Kill Zone` | Box Collider 2D (trigger), `KillZone` | under the whole level |
| `Platformer Game` | `PlatformerGame`, two Audio Sources (sounds, and the looping music) | |
| `Canvas`, `EventSystem` | as Level 2 (Scale With Screen Size 1920 × 1080, Input System UI Input Module) | the HUD, the touch controls and the panels: section 8 |

Physics: the knight and the slimes are Dynamic and bump into each other; `KnightCombat`
decides what each bump means. Slimes pass through each other (the `Enemy` layer doesn't
collide with itself).

## 6. The scripts

Fourteen scripts. Each is commented for students, in the books' plain voice.

| Script | On | Does |
| --- | --- | --- |
| `KnightController` | `Knight` | Reads the keyboard and the touch buttons (`SetLeftHeld(bool)`, `SetRightHeld(bool)`, `PressJump()`, `PressRoll()`). Runs, jumps, faces the way it runs (the Sprite Renderer's Flip X). Two ground rays from the feet, against `Ground`. Rolls: `SetTrigger(Roll)`, then 9 units/s the way he faces until `OnRollFinished()` (Animation Event, the Roll clip's last frame); `IsRolling`. Sets the Animator's `Speed`, `VerticalSpeed` and `Grounded` every frame, through hashes. `OnFootstep()` (Animation Event) plays a step. `Bounce()` for stomps. `ResetKnight(Vector2)`; stops when the game isn't playing or the knight is hurt or dead |
| `KnightCombat` | `Knight` | Decides every bump with a slime, in `OnCollisionEnter2D`. If the slime pushed him upwards (`GetContact(0).normal.y > 0.5f`), he landed on it: the slime takes a hit and he bounces. If not, and he's rolling, the slime takes a hit. Otherwise he takes 1 damage |
| `KnightHealth` | `Knight` | `MaxHealth` 5; `Health` and `IsDead` properties. `TakeDamage(int, float fromX)`: ignored while blinking or rolling; knockback, `Hurt` trigger, blink coroutine. At 0: `Dead` trigger. `OnDeathFinished()` (Animation Event, end of the Dead clip) tells the game. `Heal(int)`, `FellInPit()`, `ResetHealth()` |
| `Slime` | `Slime` and `Purple Slime` prefabs | `enum State { Patrol, Chase, WindUp, Leap, Hurt, Dead }` with `EnterState` and a `switch` in `Update`. Each enter step calls `SetInteger(State, (int)state)`: **the Animator follows the code's state machine**. `OnLeap()` (Animation Event, end of the wind-up) launches the leap. `TakeHit(float fromX)`; `OnDeathFinished()` hides it; `ResetSlime()`. Its health, speeds and ranges are Inspector fields, so the purple slime is the same script with other numbers |
| `Coin` | `Coin` prefab | On the knight: `game.AddCoin()`, then hides itself. Its spin is a looping clip: **no code at all** |
| `Apple` | `Apple` prefab | On the knight, if he isn't at full health: `Heal(1)`, then hides itself |
| `Checkpoint` | `Checkpoint` prefab (a signpost) | On the knight, the first time: `SetBool(Lit, true)`, a sound, and `game.SetRespawnPoint(...)`. `ResetCheckpoint()` puts its light out |
| `CastleDoor` | `Castle Door` | On the knight: `game.Win()` |
| `KillZone` | `Hazards`, `Kill Zone` | On the knight: `FellInPit()` and back to the last checkpoint |
| `CameraFollow` | `Main Camera` | `LateUpdate`: eases towards the knight, kept inside the level's edges. `SnapToTarget()` for restarts |
| `Section` | — (a `[System.Serializable]` plain class) | One section of the level: its `Title`, the `StartX` where it begins, and its `SkyColour` |
| `PlatformerGame` | `Platformer Game` | `enum GameState { Start, Playing, Paused, Won, Lost }`, `EnterState` and a `switch`. Coins, time, respawn point, music. A `Section[]` array in the Inspector: as the knight reaches each section, its name shows and the sky eases to its colour. `Win()`, `Lose()`, `Pause()`, `Resume()`, `Restart()` (resets everything found with `GetComponentsInChildren<T>(true)`). Shows the touch buttons only when `Touchscreen.current` isn't `null` |
| `HealthBar` | `Health Bar` (UI) | `SetHealth(int current, int max)`: a Filled Image that slides to the new value and fades from green to red |
| `PauseMenu` | `Pause Panel` (UI) | Resume, Restart, and a Volume slider (`AudioListener.volume`); listeners added in `OnEnable`, removed in `OnDisable` |

## 7. Animation

Every clip is made in the Animation window from the bundle's **sprite frames**, plus
**properties** (scale, rotation and colour) where the art has no frames. All four Animator
parameter types appear, each set from code.

### The knight's Animator

**Parameters:** `Speed` (float), `VerticalSpeed` (float), `Grounded` (bool), and `Roll`,
`Hurt` and `Dead` (triggers).

```
                    Speed > 0.1
           ┌────────────────────────────┐
  Entry → Idle                         Run
           └────────────────────────────┘
                    Speed < 0.1
   Idle / Run ── not Grounded, VerticalSpeed > 0.1 ──→ Jump ── VerticalSpeed < 0.1 ──→ Fall
   Idle / Run ── not Grounded, VerticalSpeed < −0.1 ─→ Fall ── Grounded ──→ Idle

   Any State ── Roll ──→ Roll ──── (exit time) ──→ Idle
   Any State ── Hurt ──→ Hurt ──── (exit time) ──→ Idle
   Any State ── Dead ──→ Dead      (no way out)
```

| Clip | Frames from `knight.png` | Animation Events |
| --- | --- | --- |
| `Knight Idle` | the 4 idle frames | — |
| `Knight Run` | the 16 run frames | `OnFootstep` as each foot lands |
| `Knight Jump`, `Knight Fall` | one frame each: `knight_28` (tucked, from the roll) and `knight_8` (legs apart, from the run) | — |
| `Knight Roll` | the 8 roll frames, `knight_26` to `knight_33`, at 14 a second | `OnRollFinished` on the last frame (0.5 s) |
| `Knight Hurt` | the 4 hit frames, `knight_34` to `knight_37`, at 10 a second, with the sheet's own red flash | — |
| `Knight Dead` | the 4 death frames, `knight_40` to `knight_43`, at 8 a second, then fading out over 0.5 s (a colour curve) | `OnDeathFinished` at the end (1 s) |

`Knight Idle` is `knight_0` to `knight_3` at 8 frames a second, and `Knight Run` is
`knight_8` to `knight_23` at 16, with `OnFootstep` on frames 2, 6, 10 and 14: where the
feet come together. The labels printed on the sheet slice to `knight_4` to `knight_7`,
`knight_24`, `knight_25` and `knight_38` to `knight_46`, and stay unused.

**Why `< 0.1`, not `< 0`, out of Jump:** landing on a ledge at the very top of a jump
stops him with a vertical speed of exactly 0, and `< 0` would leave him in Jump, standing.
`Grounded` starts ticked, so the knight is in Idle, not Fall, on the first frame.

**The transition settings the exam asks about:** Has Exit Time is **on** only for the
transitions out of the two one-shot clips, Roll and Hurt, and **off** everywhere else,
with a Transition Duration of 0 (sprite frames don't blend). The Any State transitions have
**Can Transition To Self** off, so holding the roll key can't restart a roll every frame.

**Why the roll ends on an event:** if a pit or Restart interrupts the Roll clip, its last
frame never plays and `OnRollFinished` never fires. `ResetKnight` clears `isRolling`
itself. The book makes that bug on purpose, then fixes it: it's exactly the kind of
Animation Event error exam objective U 3.3 asks about.

### The others

| Animator | Parameters | States | Clips |
| --- | --- | --- | --- |
| Slime | `State` (int) | Patrol, Chase, WindUp, Leap, Hurt, Dead: one Any State transition each, `State == n` | Move (4 frames; Chase plays it faster, with the state's Speed), WindUp (3 frames, squashing down, then `OnLeap`), Leap (1 stretched frame), Hurt (4 frames with the red flash), Dead (4 frames melting flat, then a fade, then `OnDeathFinished`). Shows an **Int** that mirrors the code's `enum`, and an event (`OnLeap`) that times gameplay |
| Purple Slime | the Slime's controller | the same | an **Animator Override Controller** swaps in the purple clips: the same state machine, other pictures |
| Checkpoint | `Lit` (bool) | Unlit, Lighting, Lit | property clips only: Unlit is greyed out; Lighting is a quick bounce (scale) into full colour; Lit is a gentle sway (rotation). Shows a **Bool** for something that stays true |
| Coin | none | Spin | 12 frames: a controller with one looping state, and no code |

## 8. The UI

```
┌──────────────────────────────────────────────────────────────────┐
│ [knight ████████░░]                                         [II] │
│ ◎ × 12                                                           │
│                              The Autumn Woods                    │
│                                                                  │
│                                                                  │
│ [ ◀ ] [ ▶ ]                                    [ Roll ] [ ⤒ ]    │
└──────────────────────────────────────────────────────────────────┘
```

- **HUD:** the health bar, with the knight's face beside it (top-left), the coin count
  under it, the section's name (centred, just below the HUD's top row, so the longest name
  clears the health bar; it fades out after each section starts), the pause button
  (top-right). All the text is in the bundle's pixel font (Pixel Operator 8),
  made into a TextMeshPro font asset (**Create → TextMeshPro → Font Asset → SDF**), with a
  dark outline (`#1C1F2B`, thickness 0.2) on its material.
- **Touch controls** (bottom corners), only on a touchscreen.
- **Panels**, each a dimmed screen with a window, as in Level 2:
  - **Start:** "Knight Run", how to play, **Play**;
  - **Pause:** **Resume**, **Restart**, Volume;
  - **Win:** "You made it!", coins `23 / 30`, time `2:41`, **Play Again**;
  - **Lose:** "The knight has fallen", **Try Again**.

### The game's own state machine

```
 Start ── Play ──→ Playing ── Esc / pause button ──→ Paused ── Resume ──→ Playing
                      │                                  └──── Restart ──→ Playing
                      ├── walks into the castle door ──→ Won  ── Play Again ──→ Playing
                      └── health 0 ─────────────────→ Lost ── Try Again ───→ Playing
```

## 9. The book

`Docs~/workbook/book.md`, assembled with `Level3-Shared/Docs~/assemble.mjs` into
`workbook.md`, like Level 2. About 15 build chapters and the 12 shared C# Concept chapters,
each placed just before the chapter that first needs it:

| Part | Chapters (C# Concepts in _italics_) |
| --- | --- |
| 0 Before You Start | what you're going to build, how the book works, the route, for trainers, setup |
| 1 The Knight | _Naming Conventions_ · 1 A World of Tiles · 2 Run and Jump · _The Animation Window_ · 3 Clips for the Knight · _The Animator Controller_ · _Driving the Animator from Code_ · 4 The Knight's Animator |
| 2 Roll and Slimes | _Animation Events_ · 5 The Roll · _State Machines with enum and switch_ · _Enemies as State Machines_ · 6 The Slime · 7 Stomp, Hurt and Pits · 8 The Autumn Woods and the Purple Slime |
| 3 A Real Level | 9 Coins, Apples and Checkpoints · _Game UI_ · 10 The HUD · 11 The Game's State Machine · 12 Pause and Touch · 13 The Castle Walls, and Sound |
| 4 Read, Fix and Ship | _Reading Code_ · _Finding Errors_ · _Kinds of Classes_ · 14 Break It, Then Fix It · 15 Ship It |
| 5 The User Exam | _The User Exam_ · Check Yourself: exam-style questions for every User objective, answers, a practice paper, the Level 3 cheat sheet, "Before Level 4: can you…" |

Every chapter has Goal, Idea, Do it, Test it and Challenge. Every earlier version of a
script compiles at its chapter.

**Exam objectives covered:** U 2.3 (which call triggers a state), U 3.2 (wrong types),
U 3.3 (`public` / `private` mix-ups, and Animation Event errors), U 3.4 (kinds of classes),
U 3.5 (naming conventions), U 3.6 (the comment that matches), U 4.3 (a state machine from
given clips and property settings) and U 4.4 (programming a state machine in the Animator
Controller), plus a review of every User objective.

## 10. Art and sound: the Brackeys Platformer Bundle

**Brackeys' Platformer Bundle**, version 1 (1 MB, CC0), from
<https://brackeysgames.itch.io/brackeys-platformer-bundle>. Moayad chose it on 1 October
2026. It was downloaded then to check its frames, and goes into the project once this
design is approved. Everything in the game comes from it: **nothing else to download.**

| File | What it is | Used for |
| --- | --- | --- |
| `sprites/knight.png` | 256 × 256, 32-pixel frames: Idle 4, Run 16, Roll 8, Hit 4, Death 4. The sheet has its labels (IDLE, RUN…) printed on it: Unity slices them too, and they stay unused | the knight |
| `sprites/slime_green.png`, `slime_purple.png` | 96 × 72, 24-pixel frames, 12 each: rising (4), moving (4), hit (4, with a red flash) | the two slimes |
| `sprites/coin.png` | 12 frames, 16 pixels | the coin's spin |
| `sprites/fruit.png` | 12 fruits, 16 pixels | the red apple |
| `sprites/platforms.png` | platforms in 4 colours, 1 and 2 tiles wide | floating platforms |
| `sprites/world_tileset.png` | 16-pixel tiles: ground for four seasons (grass, sand, autumn, snow and stone), blocks, bridges, trees, bushes, mushrooms, signs, fences, crates, bottles, sky colours, and water, goo and lava | the level, the signposts, the castle |
| `sounds/` | `coin`, `explosion`, `hurt`, `jump`, `power_up`, `tap` | see below |
| `music/time_for_adventure.mp3` | 40 seconds, loops | the music |
| `fonts/` | Pixel Operator 8, and its bold | the HUD and panels |

**Import settings:** Pixels Per Unit 16, Filter Mode Point (no filter), Compression None,
Sprite Mode Multiple, sliced with Grid By Cell Size. The knight's pivot is at his feet,
4 pixels above the bottom of each frame; the slimes', signs' and fruit's at the bottom.

| Sound | Plays when |
| --- | --- |
| `jump` | the knight jumps |
| `coin` | he takes a coin |
| `power_up` | he eats an apple, lights a checkpoint, or reaches the castle door |
| `hurt` | he's hurt, or falls in |
| `explosion` | a slime is knocked out |
| `tap` | footsteps (quiet, at a slightly random pitch), the roll, and the UI buttons |
| `time_for_adventure` | the music, looping while playing |

**Not in the bundle, and what the design does instead:** no attack frames (the knight
stomps and rolls), no flying enemy (the purple slime), no hearts (apples), no flags
(signposts, and the castle door), no background pictures (the sky is the camera's colour).

**Credits**, kept in `Art/Brackeys-License.txt` as the pack gives them: sprites by
analogStudios_ (knight, slime, platforms and coin) and RottingPixels (world tileset and
fruit), repackaged and modified by Brackeys; sounds by Brackeys (Asbjørn Thirslund); music
by Brackeys and Sofia Thirslund; fonts by Jayvee Enaguas (HarvettFox96). As in Level 2,
trainers share the art folder with students.

## 11. Built with Knight Run, shared by all of Level 3 (`Level3-Shared`)

- The **12 C# Concept chapters** (`GAMES_PLAN.md`, Level 3) and the **Check Yourself**
  part, with the User exam practice paper.
- `assemble.mjs`, copied from Level 2's and set to Level 3's folders and concepts.
- The **PDF builder**, copied from Level 2's. Every PDF is built on the Mac.
- `Level3BuilderKit.cs`: Level 2's builder kit, plus helpers for importing pixel art,
  tiles, animation clips (sprite frames, property curves, Animation Events), Animator
  Controllers and Override Controllers.
- The **Level 3 entry test** (it tests Level 2) comes after this book: a written paper and
  the "Meteor Defence" practical, with an answer key.

## 12. The website

One entry in `web/levels.config.mjs`: slug `level-3-knight-run`, `published: false` until
the book is ready, `protected: true`, a new salt, and the secret
`COURSE_PW_LEVEL_3_KNIGHT_RUN` with its line in `deploy.yml`.

## 13. Acceptance checks (when built)

1. **Compiles clean:** 0 errors and 0 warnings from Knight Run's and `Level3-Shared`'s
   files, checked with Unity in batch mode.
2. **Scene builds:** the Tools menu item logs `Knight Run scene built: …` with no errors
   or warnings.
3. **Book:** `node assemble.mjs --check` says `up to date`; every `csharp:File.cs` card
   matches `Scripts/`; every earlier version of a script compiles at its chapter, followed
   step by step.
4. **Play test:** every rule in section 3 and every transition in section 7, with the
   keyboard and the Device Simulator: running, jumping, rolling, stomping, both slimes'
   state machines, hurt and blinking, pits and checkpoints, coins and apples, the HUD,
   pause, win, lose, and Restart putting everything back.
5. **Web build** works in a browser with the keyboard, and on a phone with the touch
   buttons.

## 14. Out of scope

- A sword: the bundle's knight has no attack frames, so he stomps and rolls (agreed on
  1 October 2026).
- Enemies that shoot (Crypt Keys has archers), moving platforms, a boss.
- Saving a best time: there's no `PlayerPrefs` before Level 4, so the win panel shows this
  run's time only.
- The Pixel Perfect Camera, parallax backgrounds, 2D lights beyond the global one, and
  particles.
- Crypt Keys and Gate Guard: their own specs, after this book is done.

## 15. Decisions (answered on 1 October 2026)

1. **The art:** the Brackeys Platformer Bundle. The bundle has a real knight, so the
   question of the hero is gone.
2. **This design (version 2):** approved.
3. **The sword:** none. The knight stomps and rolls, with the bundle only.
4. **Painting the level:** every section step by step.
