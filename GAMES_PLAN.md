# Games Plan — Levels 3 to 6

_Proposed on 1 October 2026, from the topics in the Level Reference, and reviewed the same
day: Level 3's games are agreed with Moayad, and every level has a **core game**. Moayad can
still swap or drop any game before work on its level starts. The rule so far is to build
**every** game listed for a level, as for Level 2._

**For Claude in VS Code:** read `HANDOFF.md` first, for the conventions and working rules.
Then read the Level Reference (`Assets/Levels/Unity-Programmer-Curriculum-Levels.pdf`),
which lists each level's topics and exam objectives. Level 2 is the model for everything
here: copy its structure, its book format and its checks.

---

## At a glance

All game names are working titles.

| Level | Exam at the end | Games | Status |
| --- | --- | --- | --- |
| 0 Zero | — | Rocket Launch | Built |
| 1 Beginner | — | Catch the Falling Blocks | Built |
| 2 Builder | — | Mini Golf (3D), Space Shooter (2D), Tank Arena (2D, top-down) | Built |
| 3 Junior-ready | Unity Certified User: Programmer | **Knight Run** (2D platformer, core), **Crypt Keys** (2D dungeon crawler), **Gate Guard** (3D tower defence) | **In progress:** Knight Run, Crypt Keys and Gate Guard built; the entry test next |
| 4 Junior | Unity Certified Associate: Programmer | **Arcane Duel** (card battler, core), **Pocket Karts** (3D kart racer), **Juice Tycoon** (idle tycoon) | Planned |
| 5 Mid-level I | — | **Lost Ruins** (3D action adventure, core), **Box Pusher** (2D puzzle with undo), **Tiny Colony** (RTS-lite, optional) | Planned |
| 6 Mid-level II | — | **Card Table** (online card game for mobile, core), **Arena Online** (real-time multiplayer, optional) | Planned |

The **core game** is the best game for teaching all of its level, and the one to build
first. A course with time for only one game per level teaches the core game. Each level
lists its games in the order to build them.

By the end of Level 4, a student has shipped at least 5 different games, one per level,
which is what the Associate exam assumes.

---

## How to build a level (the Level 2 recipe)

1. **Folders.** Create `Assets/Levels/LevelN-Shared/` for the C# Concept chapters, the
   Check Yourself part, the assembler, the PDF builder, the builder kit and the entry test.
   Create one folder per game: `Assets/Levels/LevelN-<Game>/`. Each game has its own
   runtime and Editor assembly definitions.
2. **A build spec per game** (`Docs/<GAME>_BUILD_SPEC.md`), written first:
   - the level's code limits (what C# is allowed);
   - every script and what it does;
   - the scene, with exact values;
   - the Inspector wiring;
   - acceptance checks;
   - what's out of scope.
3. **The finished scripts**, commented for students. They must compile in Unity.
4. **The scene builder** (`Editor/`), using a copy of the Level 2 builder kit. It builds
   the scene, prefabs and UI exactly as the book describes, and puts its scene first in
   Build Settings.
5. **The book** (`Docs~/workbook/book.md`):
   - build chapters interleaved with the shared C# Concept chapters, which are included
     with `{{concept:id}}` and cross-referenced with `{{ref:id}}`;
   - every chapter has Goal, Idea, Do it, Test it and Challenge;
   - the earlier versions of each script are shown as the chapters build them up, and
     each one must compile at its step;
   - it ends with the Check Yourself part.
6. **Assemble, build and check:**
   - Assemble with a copy of Level 2's `assemble.mjs`.
   - Build the PDF with a copy of Level 2's builder. **Build every PDF on the Mac.**
   - Check the code cards against `Scripts/`.
   - Follow the book step by step, compiling at every step. Unity in batch mode can do
     the compiling.
   - Have a fresh agent review the book.
7. **The entry test**, which tests the previous level. It has a written paper (20
   questions, 40 minutes, pass with 14), a practical task (about 75 minutes, pass with 70
   out of 100), and an answer key with a rubric and a model solution. It's printed as two
   sets, like Level 2's.
8. **The website.** Add one entry per book in `web/levels.config.mjs`, with
   `published: false` until it's ready, `protected: true` and a new salt. Add its
   `COURSE_PW_*` secret and its line in `deploy.yml`.
9. **READMEs** for the shared folder and every game.

**Every book stands alone:** each game's book teaches **every** topic of its level, so a
trainer can teach any one game. The games differ; the topics don't. **Level 5 is the
exception:** only its core game, Lost Ruins, teaches all of it (see Level 5).

**Art and sound:** free CC0 packs, and no Kenney assets from Level 3 on. Moayad's sheet,
`Design_Resources_Levels_3-6.xlsx`, lists the packs for every game, with their licences;
each game's spec records what was picked after opening them. Knight Run uses the Brackeys
Platformer Bundle, Crypt Keys Foozle's Lucifer set, and Gate Guard KayKit's medieval
packs. **Ask Moayad before any download.** If a pack has no
animation frames, animate properties instead (position, rotation, scale, colour): that
teaches the Animation window just as well.

---

## Level 3 — Junior-ready

**Goal:** students build complete games on their own, with animated state machines and
readable code.
**Exam at the end:** Unity Certified User: Programmer. The Check Yourself part works
through every User objective, with exam-style questions and a practice paper.
**Games, in build order:** Knight Run (the core game), Crypt Keys and Gate Guard, agreed
with Moayad on 1 October 2026.

### Code limits

- **New at Level 3:**
  - state machines with `enum` + `switch`, with an enter step for each state;
  - the Animator API: `SetTrigger`, `SetBool`, `SetFloat`, `SetInteger` and
    `Animator.StringToHash`;
  - Animation Events;
  - `[System.Serializable]` plain classes in Inspector arrays;
  - naming conventions, applied everywhere.
- **Still allowed:** everything in Levels 0–2 (see a Level 2 build spec).
- **Not yet:**
  - from Level 4: inheritance (`virtual`, `override`, `abstract`), interfaces, C# events,
    `Action` and delegates, `Queue` and `Stack`, loading scenes, `PlayerPrefs` and JSON
    saves, making ScriptableObjects, object pooling, the Input Actions asset, and `try` /
    `catch`;
  - from Level 5: blend trees, Animator layers and avatar masks, Cinemachine, Timeline,
    LINQ, writing generics, and `async` / `await`.

  One consequence: enemy types are separate scripts, or one script with different values.
  There are no base classes yet.

### In every Level 3 book

- **All four Animator parameter types**, each set from code: a Float, a Bool, a Trigger
  and an Int. Exam objective U 2.3 asks which call triggers a state, so every book shows
  `SetFloat`, `SetBool`, `SetTrigger` and `SetInteger` at work.
- **Restart resets the level in code**, as Level 2's games do. Loading scenes waits for
  Level 4.

### Shared C# Concept chapters (`Level3-Shared`)

**C#**

1. State Machines with `enum` and `switch`
2. Naming Conventions (Unity and C#)
3. Reading Code: picking the comment that matches
4. Finding Errors: wrong types, `public` / `private` mix-ups, and "what does this print?"
5. Kinds of Classes: MonoBehaviour, ScriptableObject, plain C# and ECS (recognition only)

**Unity**

6. The Animation Window: clips, keyframes, sprite frames and properties
7. The Animator Controller: states, transitions, conditions and parameters
8. Driving the Animator from Code
9. Animation Events, and the errors they cause
10. Enemies as State Machines, in code and in the Animator
11. Game UI: health bars, menus and pausing
12. The User Exam: the objectives, and how to read the questions

### Knight Run — 2D platformer

**Pitch:** a small knight runs, jumps and rolls through one long level in three sections,
with a checkpoint sign between them. He stomps on slimes or rolls into them, collects
coins and apples, and walks into the castle door at the far end. The design was approved
on 1 October 2026; `Level3-KnightRun/Docs/KNIGHTRUN_BUILD_SPEC.md` has every detail.

- **Art:** the Brackeys Platformer Bundle (CC0), Moayad's choice: the knight, green and
  purple slimes, coins, fruit, platforms, a four-season tileset, 6 sounds, music and a
  pixel font.
- **Controls:**
  - keyboard: A / D or the arrows to run, Space to jump, Shift or J to roll;
  - touch: four on-screen buttons (left, right, jump, roll).
- **Player:**
  - a Rigidbody 2D and a Capsule Collider 2D;
  - a ground check with two raycasts;
  - 5 health; falling into water, goo or the moat costs 1 health and sends the knight
    back to the last checkpoint;
  - a stomp (landing on a slime hits it) and a roll (slimes can't hurt him, and any
    slime he rolls into is hit).
- **Animator (the knight):**
  - states: Idle, Run, Jump, Fall, Roll, Hurt and Dead;
  - parameters: `Speed` and `VerticalSpeed` (floats), `Grounded` (bool), and the `Roll`,
    `Hurt` and `Dead` triggers;
  - transition settings that matter: Has Exit Time on only out of Roll and Hurt, and a
    Transition Duration of 0. These are the "clips and property settings" the exam asks
    about.
- **Animation Events:**
  - the Roll clip's last frame calls `OnRollFinished()`;
  - the Run clip calls `OnFootstep()`;
  - the end of the Dead clip calls `OnDeathFinished()`;
  - the slime's WindUp clip calls `OnLeap()`.
- **Enemies as state machines:** one `Slime` script with `enum State` and a `switch`:
  Patrol → Chase → WindUp → Leap, plus Hurt and Dead. Its Animator follows the code
  through a `State` int: each state's enter step calls `SetInteger("State", (int)state)`.
  That ties the code's state machine to the Animator's, and gives the book its Int
  parameter. The purple slime is the same script with other numbers, and an Animator
  Override Controller for its clips.
- **Other objects:**
  - coins and apples;
  - checkpoint signposts with their own small Animator: Unlit → Lighting → Lit, on a `Lit`
    bool, with property clips only;
  - the castle door at the end, painted from tiles;
  - a camera-follow script.
- **Game states:** Start, Playing, Paused, Won and Lost. The UI shows a health bar, a coin
  count and the section's name, a pause menu (Resume, Restart, Volume), and start, win
  and lose panels.
- **Scripts:** `KnightController`, `KnightCombat`, `KnightHealth`, `Slime`, `Coin`,
  `Apple`, `Checkpoint`, `CastleDoor`, `KillZone`, `CameraFollow`, `Section`,
  `PlatformerGame`, `HealthBar` and `PauseMenu`.
- **Objectives covered:** U 2.3, U 3.3 (Animation Event errors), U 4.3 and U 4.4, plus
  every Level 3 C# topic.

### Crypt Keys — 2D top-down dungeon crawler

**Pitch:** a hero explores a crypt of six rooms. Keys open doors, chests give loot, and
skeletons and archers guard the way to the Skeleton King's tomb. The design was approved
on 1 October 2026 and the game is built; `Level3-CryptKeys/Docs/CRYPTKEYS_BUILD_SPEC.md`
has every detail.

- **Controls:**
  - keyboard: W A S D or the arrows to move, Space or J to attack, E to open the chest in
    front, Q to drink a potion;
  - mouse or touch: press and hold to walk towards the pointer (as in Tank Arena), and
    tap to attack, or to open the chest in front.
- **Animator (the hero):**
  - `Direction` (int, 0–3) through `SetInteger`, for down, left, up and right;
  - `Speed` (float), and the `Attack`, `Hurt` and `Dead` triggers;
  - one sub-state machine per direction: Down is built state by state, then copied three
    times. Blend trees wait until Level 5.
- **Animation Events:** the sword's hit frame and the bow's release frame; a chest's
  Opening clip, which spawns its loot at the right frame; a door's Opening clip, which
  turns off its collider; the king's summon; and the end of every Dead clip.
- **Enemies as state machines:**
  - **Skeleton:** Idle → Patrol → Chase → Attack, plus Hurt and Dead;
  - **Archer:** Idle → Keep Distance → Shoot → Reposition, plus Hurt and Dead;
  - **Skeleton King:** Asleep → Walk → Swing → Rest; below half health, Summon (two
    skeletons) and Whirlwind, which turns the sword aside; then Dead.
  - The skeleton and the archer use the hero's controller through Override Controllers;
    the king, a copy of it, extended with two states.
- **Rooms:** all in one scene, stacked one above the other, each painted on Tilemaps with
  a Random Rule Tile for the floor. The camera slides from room to room. Doors are
  Closed → Opening → Open, through an `Open` bool (`SetBool`), which gives the book its
  Bool parameter; keys are counted.
- **UI:**
  - hearts, in half hearts, and the key and gold counts;
  - a small inventory of potions;
  - the room name, which fades in;
  - a boss health bar;
  - a pause menu, and start, win and lose panels.
- **Art:** Foozle's **Lucifer** set (CC0): the Warrior hero, the Skeleton Grunt, the
  Skeleton Hunter (the archer) and the Skeleton King boss, every one in 4 directions with
  the same animations, so they share one Animator Controller; the Dungeon Tileset, the
  Pickups and the RPG UI. Chests, hearts and the arrow from 0x72's DungeonTileset II, keys
  from Foozle's Legend UI Icons, sounds and music from Ninja Adventure. Every pack is in
  `Level3-CryptKeys/CREDITS.md`.
- **Scripts:** `Hero`, `HeroCombat`, `HeroHealth`, `Inventory`, `Skeleton`, `Archer`,
  `Arrow`, `SkeletonKing`, `Door`, `Chest`, `Pickup`, `HeartsBar`, `BossBar`,
  `RoomCamera`, `CryptGame`, `PauseMenu`, `Facing` and `Room`.
- **Objectives covered:** the same as Knight Run, with `SetInteger` and sub-state machines
  in the foreground.

### Gate Guard — 3D tower defence

**Pitch:** skeletons rise from the ruins and march along a winding road to the castle
gate. The player builds towers on dirt plots beside the road and upgrades them, to hold
the gate for ten waves. The design was approved on 1 October 2026 and the game is built;
`Level3-GateGuard/Docs/GATEGUARD_BUILD_SPEC.md` has every detail, and its section 16 what
changed from this plan.

- **Controls:**
  - mouse or touch: tap a dirt plot to open the build menu over it, and tap a tower to
    upgrade or sell it, with its range shown as a ring;
  - buttons: Start Wave, ×2 speed (`Time.timeScale`) and Pause; Space, F, Esc and P on
    a keyboard.
- **Enemies:** four kinds of skeleton, one `Enemy` script with their own numbers in the
  Inspector: the Minion, the Rogue (fast), the Warrior (tough) and the Bone Mage (the boss
  of wave 10).
  - they follow waypoints (an array of Transforms);
  - their state machine is Rising → Walking ⇄ Slowed → At Gate or Dying;
  - their Animator, one `Skeleton` controller for all four through Override Controllers:
    a rise out of the ground, the walk (its Speed Multiplier is `WalkSpeed`, so frost
    visibly slows it), a chop at the gate, a fall and a cheer. Animation Events, added in
    the Import Settings: the rise's end starts the walk, the chop costs the gate its
    lives, the fall's end pays the bounty and removes the skeleton.
  - a hit is a red flash in code: one Animator layer at Level 3 can't play a flinch
    without stopping the walk.
- **Towers:**
  - their state machine is Idle → Aim → Fire → Reload;
  - one `Crew` controller drives all three crews (an archer, a mage and a wooden catapult
    arm made of property clips): it holds the aim while `Aiming` is on, and shoots on the
    `Fire` trigger; the shot leaves on the clip's release frame;
  - a second Animator on the tower: `SetInteger("Level")` switches its looks, a second
    storey and then flags, with Is Active keys;
  - the types are Arrow, **Catapult** (splash damage; the free packs have no cannon) and
    Frost (it slows skeletons). One `Tower` script; `Projectile` has the kind's `switch`.
- **Waves:**
  - an array of `[System.Serializable]` `Wave`s, each an array of groups (which skeleton,
    how many, the gap between them);
  - the spawner is a state machine: Waiting → Spawning → In Progress → Cleared, with a
    countdown and a bonus.
- **UI:**
  - gold, lives and "Wave N / 10";
  - build and tower menus placed over the tile tapped;
  - world-space health bars over the skeletons;
  - start, pause, victory and defeat panels.
- **Art:** KayKit's CC0 packs, in one style: Medieval Hexagon (the battlefield, the road,
  the plots, the castle, the gate and the towers), Skeletons, Adventurers (the Ranger and
  the Mage) and Character Animations (every clip). Not the Medieval Builder Pack: KayKit
  calls it legacy, and the Hexagon pack has everything it had. Tower upgrade looks built
  from KayKit parts. Menus from pzUH's Free Fantasy Game GUI; seven icons from
  game-icons.net, credited; the font Lilita One; sounds and music from Ninja Adventure.
  Every pack is in `Level3-GateGuard/CREDITS.md`.
- **Scripts:** `GateGame`, `Bank`, `WaveSpawner`, `Wave`, `SpawnGroup`, `WaypointPath`,
  `Enemy`, `EnemyHealthBar`, `Tower`, `TowerLevel`, `TowerCrew`, `Projectile`,
  `BuildPlot`, `Picker`, `BuildMenu`, `TowerMenu`, `RangeRing`, `Gate` and `PauseMenu`.
  (`SpeedControls` wasn't needed: `GateGame` keeps the speed.)
- **Objectives covered:** the same as Knight Run, with Humanoid Avatars, events in the
  Import Settings, towers, waves and world-space UI in the foreground. It is 3D, as Mini
  Golf was at Level 2.

### Level 3 entry test (it tests Level 2)

- **Written paper:** 20 questions across the 15 Level 2 concept chapters.
- **Practical: "Meteor Defence"**, suggested:
  - meteors fall, and the player clicks or taps them to blast them, with a raycast at
    the pointer;
  - the game keeps a `List` of active meteors and spawns waves in a coroutine;
  - a `Dictionary` holds the points for each size;
  - the score is a property with a `private set`;
  - a settings Slider (`onValueChanged`) sets the speed;
  - the end screen shows how many meteors of each size were blasted.

---

## Level 4 — Junior

**Goal:** structured, multi-scene games with clean code, saving and version control.
**Exam at the end:** Unity Certified Associate: Programmer. The Check Yourself part works
through every Associate domain, with exam-style questions and a practice paper.
**Games, in build order:** Arcane Duel (the core game: it carries the most Associate
objectives naturally), Pocket Karts and Juice Tycoon.

- **New at Level 4:**
  - inheritance (`virtual`, `override`, `abstract`), interfaces, and when to use which;
  - `Dictionary` in depth, `Queue` and `Stack`;
  - C# events, `Action` and delegates (intro), and the risks of `static` members;
  - coding standards and refactoring; `Debug.LogWarning` and `LogError`; `try` / `catch`;
  - loading scenes and passing data between them;
  - `PlayerPrefs` and JSON saves;
  - UI in depth: Canvas scaling, anchors, pivots and layout groups;
  - ScriptableObjects; nested prefabs, variants and overrides;
  - the Package Manager and the Asset Store; object pooling; the profiling tools;
  - the Input Actions asset, action maps and rebinding;
  - working inside an existing codebase: reading, evaluating and integrating code someone
    else wrote, as the exam's "evaluate code for integration" asks. Every book hands
    students a ready-made module to read and plug in: Arcane Duel's computer opponent,
    Pocket Karts' kart handling, Juice Tycoon's achievements;
  - builds for WebGL and PC;
  - **Git with Unity, used from the first chapter.**
- **The entry test** (it tests Level 3): the practical could be a guard whose Animator is
  built from given clips and driven by a code state machine, with an Animation Event.

| Game | What it is | What it carries |
| --- | --- | --- |
| **Arcane Duel** _(core)_ | 2D card battler against the computer, mostly UI | Cards through inheritance (an abstract `Card`, then attack, heal and shield cards) and interfaces (`IDamageable`). ScriptableObject card data. The draw pile as a `Queue` and the discard pile as a `Stack`. C# events for turns. A hand laid out with layout groups. Menu, deck builder, battle and results scenes. Decks saved as JSON, settings in `PlayerPrefs` |
| **Pocket Karts** | 3D kart racer | Menu, track select, race and results scenes, with data passed between them. An Input Actions asset for keyboard, gamepad and touch, with rebinding saved in `PlayerPrefs`. Kart prefab variants (fast, heavy, balanced). AI karts on waypoints, through inheritance and an `IRacer` interface. Lap times and best laps saved as JSON. A Profiler and Frame Debugger session, and importing a package and fixing a conflict. Art: from the design resources sheet |
| **Juice Tycoon** | 2D idle tycoon, mobile style | ScriptableObject generators and upgrades. Earnings while the player is away (a saved timestamp and JSON). Number formatting (1.2K, 3.4M). Scrolling lists with anchors and layout groups. Prefab variants for the generator rows. Pooled "+$" pop-ups. Finding garbage-collection spikes with the Profiler |

---

## Level 5 — Mid-level I

**Goal:** architecture and performance: systems that stay clean and fast as the game grows.
**Games, in build order:** Lost Ruins (the core game), Box Pusher and Tiny Colony
(optional).

**Only Lost Ruins stands alone.** A 2D puzzle and a top-down RTS have no humanoid
character for avatar masks and no use for a third-person camera, so Box Pusher
(architecture and testable code) and Tiny Colony (performance) go deeper into parts of
Level 5 instead. Every class does Lost Ruins.

- **New at Level 5:**
  - your own generics; LINQ, and when not to use it in games;
  - delegates and events in depth (the observer pattern); `async` / `await`, with Tasks
    and UniTask;
  - memory: value and reference types, structs, boxing and garbage collection;
  - SOLID; the Singleton, Observer, Command, State, Factory, Object Pool and Service
    Locator patterns; dependency injection;
  - game logic separate from MonoBehaviours; script execution order;
  - Addressables;
  - the Profiler and Frame Debugger in depth;
  - blend trees, Animator layers and avatar masks;
  - Cinemachine and Timeline.

| Game | What it is | What it carries |
| --- | --- | --- |
| **Lost Ruins** _(core)_ | 3D third-person action adventure | A locomotion blend tree, an upper-body attack layer with an avatar mask, a Cinemachine third-person camera and a Timeline intro cutscene. Enemies through the State pattern, with state classes. Player actions through the Command pattern. An event bus. Areas loaded with Addressables, asynchronously. Services found through a Service Locator. Also the topics it would otherwise leave to the other two: a generic object pool (`Pool<T>`), LINQ and when not to use it, structs and garbage collection, a Factory for enemies, the Singleton and its problems (replaced by the Service Locator), dependency injection, and script execution order |
| **Box Pusher** | 2D puzzle with undo, in the style of Sokoban | The whole game in plain C#, outside MonoBehaviours, with views that only listen. Command-pattern undo and redo. A generic `Grid<T>`. Data-driven levels, loaded with Addressables. Refactoring to SOLID. Code written so Level 6 can unit-test it |
| **Tiny Colony** _(optional)_ | 3D top-down RTS-lite | Hundreds of units: pooling, no garbage per frame, and structs where they help. Selection and unit orders through the Command pattern. A Factory for units and buildings. LINQ against loops, measured in the Profiler |

---

## Level 6 — Mid-level II

**Goal:** production: testing, tools, online features, mobile and working as a team.
**Games, in build order:** Card Table (the core game), and Arena Online (optional).

- **New at Level 6:**
  - unit tests and testable code: the Unity Test Framework, in Edit Mode and Play Mode;
  - web requests and JSON, with error handling, cancellation and timeouts;
  - editor scripting: custom Inspectors and tools for designers;
  - Android (and iOS) builds;
  - online services, taught one SDK at a time (PlayFab, then Firebase);
  - Netcode for GameObjects (intro);
  - Git branching, code reviews and build pipelines;
  - store builds, versioning and crash reporting.

| Game | What it is | What it carries |
| --- | --- | --- |
| **Card Table** _(core)_ | An online card or board game for mobile | A rules engine in plain C#, with Edit Mode tests, and Play Mode tests for the UI flow. **PlayFab** module: anonymous login, cloud save and leaderboards. **Firebase** module: Analytics, Crashlytics and push notifications. **Netcode for GameObjects** module: a two-player online match, with the turns as RPCs and the table's state in `NetworkVariable`s, so the book covers all of Level 6. A web request with a timeout and cancellation. An editor window for designing decks and rules. An Android store build, with versioning and crash reports. Work on Git branches, with code reviews |
| **Arena Online** _(optional)_ | A 2–4 player top-down arena, for going further with real-time multiplayer | Netcode for GameObjects, with deliberately simple gameplay: host and clients, spawned network objects, `NetworkVariable` health and score, and an RPC for shooting. Tested on one machine with Multiplayer Play Mode |

---

## Open decisions for Moayad

- **Level 3 is settled:** Knight Run, Crypt Keys and Gate Guard, in that order (1 October
  2026).
- Levels 4–6: keep, swap or drop any game before work on its level starts.
- Level 5's Tiny Colony and Level 6's Arena Online are optional: build them only if
  there's time.
- Art packs: approve each download before it happens.
