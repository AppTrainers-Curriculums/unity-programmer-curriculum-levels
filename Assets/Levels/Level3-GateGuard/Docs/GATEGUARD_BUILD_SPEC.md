# Gate Guard — Level 3 Build Spec

Spec for **Gate Guard**, the third game of Level 3 ("Junior-ready") of the Unity
Programmer Curriculum. Hand it to Claude in VS Code for checks or changes.

> **Status: built, 1 to 2 October 2026.** Design version 1 was approved by Moayad on
> 1 October 2026, all six decisions in section 15 as recommended. The game, its scene
> builder and its book (assembled, code-checked, PDF built) are in place, and Moayad ran
> **Build Scene** in the project on 2 October. Section 16 lists what changed from the
> design while building. Left: Moayad's own play, and a Web build on a phone. Numbers once
> marked *(lab)* are the ones the lab's play tests settled on.

---

## 1. Context

- **Audience:** students who passed the Level 3 entry test, which tests Level 2. Everything
  in Levels 0–2 is theirs to use.
- **The book stands alone.** Like Knight Run and Crypt Keys, Gate Guard teaches **every**
  Level 3 topic, with the same 12 shared C# Concept chapters and Check Yourself part from
  `Assets/Levels/Level3-Shared`, so a trainer can teach any of the three games. It is the
  level's 3D game, as Mini Golf was Level 2's. The concepts are the same; the game puts
  different ones in the foreground:

| | Knight Run | Crypt Keys | Gate Guard |
| --- | --- | --- | --- |
| View | 2D side-on platformer | 2D top-down dungeon | **3D**: a fixed camera over a hex battlefield |
| Characters | sprite frames | sprite frames, 4 directions | **rigged 3D models with real clips**: a Humanoid Avatar, one clip on many bodies |
| Float | `Speed`, `VerticalSpeed` | `Speed` | `WalkSpeed`, a state's **Speed Multiplier**: frost visibly slows the walk |
| Bool | `Grounded`, `Lit` | `Open`, `Whirlwind` | `Aiming` (every tower's crew), `Broken` (the gate) |
| Trigger | `Roll`, `Hurt`, `Dead` | `Attack`, `Hurt`, `Dead` | `Fire`, `Die`, `Attack`, `Cheer`, `Hit` |
| Int | `State` | `Direction` | `Level`: a tower's **upgrade look**, switched by property clips |
| Animation Events | footsteps, the roll's end, the slime's leap | hit, release, loot, open, summon | the bow's **release frame**, the catapult's **throw frame**, the mage's **cast frame**, the rise's end, the gate **hit**, the death's end (the bounty) |
| Sharing | an Override Controller for the purple slime | one controller for four characters | one controller for **four skeletons**, and one for **three tower crews**: an archer, a mage and a wooden catapult arm |
| UI | a sliding health bar | hearts, keys, a boss bar | **world-space health bars** over every skeleton, a **build menu placed over the tile you tap**, gold, lives, waves, ×2 speed |

- **Unity skills a professional uses, new in this book** (engine features, so they fit
  Level 3's code limits):
  - importing 3D models from a pack: FBX import settings (scale, materials, the Rig tab);
  - a **Humanoid Avatar**, and clips from another file playing on any Humanoid body
    (KayKit's own advice for these characters);
  - imported clips: Loop Time, and **Animation Events added in the Import Settings**,
    because an imported clip is read-only in the Animation window;
  - a state's Speed Multiplier driven by a parameter;
  - one Animator Controller shared by bodies as different as a person and a wooden arm,
    through Override Controllers;
  - property clips that switch GameObjects on and off (**Is Active** keys) and move them;
  - a **hex Grid** and the Tile Palette's **GameObject Brush**, painting 3D tiles as the
    students painted 2D ones in Knight Run and Crypt Keys *(lab: see section 13)*;
  - a weapon parented to a bone (`handslot.r`), so it follows the hand;
  - `Physics.OverlapSphere` with a layer mask (towers find targets); a raycast from the
    camera through the pointer (tapping a tile);
  - a **World Space Canvas** that faces the camera; `Camera.WorldToScreenPoint` for a menu
    over a 3D tile;
  - a **Trail Renderer** behind each shot, Particle Systems for dust and frost, a Line
    Renderer drawing a tower's range;
  - 3D light: a Directional Light with soft shadows, ambient light from a gradient, and a
    **Physical Camera** with **Gate Fit: Overscan**, so a phone and a tablet both see the
    whole road.
- **Engine:** Unity 6 (6000.6), URP 17, the Input System package only, Tilemap Extras (for
  the GameObject Brush). Students start Gate Guard from the **Universal 3D** template, as
  for Mini Golf; in the curriculum project the builder adds a 3D renderer for this game's
  camera, as Mini Golf's builder does (section 5).
- **Location:** `Assets/Levels/Level3-GateGuard/` in `~/apptrainers/unity-programmer-curriculum-levels`:

```
Assets/Levels/Level3-GateGuard/
├── README.md, CREDITS.md
├── Curriculum.Level3.GateGuard.asmdef      runtime assembly (not auto-referenced)
├── Scripts/            the 19 scripts in section 6
├── Editor/             GateGuardSceneBuilder.cs, GateGuardMap.txt (the battlefield's map),
│                       Curriculum.Level3.GateGuard.Editor.asmdef
├── Art/                Models/ (tiles, buildings, nature, props), Characters/ (4 skeletons,
│                       the Ranger, the Mage, weapons), Animations/ (6 clip files), UI/,
│                       Icons/, Fonts/, Licences/ (section 10)
├── Audio/              sounds and 2 pieces of music, from Ninja Adventure
├── Animation/          property clips and Animator Controllers   (created by the builder)
├── Prefabs/            skeletons, towers, shots, effects, tiles  (created by the builder)
├── Settings/           GateGuardRenderer.asset                    (created by the builder)
├── Scenes/             GateGuard.unity                            (created by the builder)
├── Docs/               workbook PDF, this spec
└── Docs~/workbook/     book.md (source), workbook.md (assembled), cover.png
```

## 2. Hard rules (Level 3 limits)

Exactly Knight Run's (`Level3-KnightRun/Docs/KNIGHTRUN_BUILD_SPEC.md`, section 2): Levels 0–2,
plus state machines with `enum` + `switch` and one `EnterState`, the Animator API through
`static readonly` hashes, Animation Events, `[System.Serializable]` plain classes and the
naming conventions. Not yet: inheritance, interfaces, C# events and delegates, `SceneManager`,
`PlayerPrefs`, making ScriptableObjects, prefab variants, pooling, Input Actions, `try` /
`catch` (Level 4); blend trees, Animator layers, Cinemachine, NavMesh, LINQ (Level 5). Never
`var`, `Find…` or the older `Input` class.

New Unity members the book introduces where it needs them: `Physics.OverlapSphere`,
`Camera.ScreenPointToRay` (Level 2's raycasts, now from the camera), `Camera.WorldToScreenPoint`,
`Quaternion.LookRotation` and `Quaternion.RotateTowards`, `Transform.LookAt`,
`Animator.Rebind`, `GetComponentsInChildren<T>(true)`, `Renderer.material`, the World Space
Canvas, the Trail Renderer, the Grid's Hexagon layout and the GameObject Brush.

Four consequences, said out loud in the book:

- **One script for three towers, one for three shots.** `Tower` is the same for all three:
  what differs is in the Inspector (its levels, its crew, its turret) and in the shot it
  fires. `Projectile` has `enum ProjectileKind { Arrow, Stone, Frost }` and a `switch`
  where they differ, as Crypt Keys' `Pickup` has one for its four kinds. At Level 4,
  inheritance gives each kind its own class: the book says that's where the `switch`
  would split.
- **One enemy script, four kinds.** `Enemy` with different numbers in the Inspector, and an
  Override Controller where the clips differ. The rule from Knight Run.
- **Shots are made and destroyed.** Every arrow, stone and frost bolt is `Instantiate`d and
  `Destroy`ed. Object pooling, which reuses them, is a Level 4 topic: the book says so.
- **A hit can't play a clip without stopping the walk.** An Animator has one layer at
  Level 3, so a hit flashes the skeleton red in code (a coroutine, from Level 2) instead.
  Level 5's Animator layers play both at once: the book says so.

**Style:** as Knight Run, including the naming table (Animator parameters in PascalCase,
hashed once; Animation Event methods start with `On`).

## 3. The game

**The dead are rising in the old ruins.** Ten waves of skeletons march along a winding road
to the castle gate. The player builds towers on dirt plots beside the road, upgrades them,
and holds the gate.

**Controls.** The game is played with a pointer: the mouse, or a finger on a phone.

| Action | Mouse and touch | Keyboard |
| --- | --- | --- |
| Build | tap an empty dirt plot: the **build menu** opens over it (Arrow, Catapult, Frost, with their prices) | |
| Upgrade or sell | tap a tower: the **tower menu** opens over it (Upgrade, Sell) and its range shows on the ground | |
| Close a menu | tap anywhere else | Esc |
| Start the next wave | the **Start Wave** button, or wait for the countdown | Space |
| Speed | the **×2** button: normal or double speed | F |
| Pause | the pause button | Esc or P |

**Rules**

- The player starts with **120 gold** and **10 lives**: the gate's strength.
- A tower costs gold, and so does each upgrade, to **Level 2** and **Level 3**. Selling gives
  back **60%** of what the tower cost, upgrades included.
- A skeleton killed by a tower pays its bounty.
- A skeleton that reaches the gate swings at it. The gate shudders and loses lives: 1 for
  most skeletons, 2 for a Warrior, 5 for the boss. Then the skeleton crumbles, with no
  bounty.
- **Wave 1** starts when the player presses Start Wave. After each wave the next one counts
  down from 15 seconds; Start Wave skips the wait. A cleared wave pays a bonus:
  20 + 5 × the wave's number.
- **Won:** wave 10 is cleared, boss included. **Lost:** the lives reach 0, the gate's doors
  burst open, and the skeletons on the road cheer.
- **Restart** puts everything back in code: gold, lives, the waves, the gate, and every plot
  empty.

**The skeletons** (KayKit Skeletons; section 7 has their clips)

| Kind | Look | Health | Speed (units/s) | Bounty | Lives it costs | Road time at ×1 |
| --- | --- | --- | --- | --- | --- | --- |
| **Minion** | bare skull, a blade | 6 | 1.5 | 5 | 1 | 41 s |
| **Rogue** | red hood, runs | 4 | 2.6 | 6 | 1 | 23 s |
| **Warrior** | horned helmet, axe and shield | 18 | 1.0 | 12 | 2 | 61 s |
| **Bone Mage** (the boss, wave 10) | the Skeleton Mage, 1.5 × the size, a staff | 150 | 0.7 | 100 | 5 | 87 s |

**The towers** (the design's numbers held up in the lab's play tests)

| | Level 1 | Level 2 | Level 3 |
| --- | --- | --- | --- |
| **Arrow** (the Ranger) | 50 gold · range 4 · 1 damage every 1 s | +40 · range 4.5 · 2 every 0.85 s | +70 · range 5 · 3 every 0.7 s |
| **Catapult** | 80 gold · range 5 · 4 damage to everything within 1.2 of where the stone lands, every 2.6 s | +60 · range 5.5 · 6 within 1.4, every 2.4 s | +100 · range 6 · 9 within 1.6, every 2.2 s |
| **Frost** (the Mage) | 60 gold · range 3.5 · 1 damage, and half speed for 2 s, every 1.2 s | +50 · range 4 · 1, half speed for 2.5 s | +80 · range 4.5 · 2, and everything within 1 of the target slowed for 3 s |

A tower shoots the skeleton **furthest along the road** within its range: the one closest
to the gate. Arrows and frost bolts follow their target; a stone flies in an arc to where
the target was, and hits everything where it lands.

**The waves**: an array of `[System.Serializable]` `Wave`s, each a list of groups
(which skeleton, how many, the gap between them), spawned one group after another.

| Wave | Name | Groups |
| --- | --- | --- |
| 1 | The First Rising | 6 Minions, 1.6 s apart |
| 2 | More Bones | 10 Minions, 1.2 s |
| 3 | Hooded Runners | 6 Minions, 1.2 s; then 4 Rogues, 0.9 s |
| 4 | The Quick Ones | 10 Rogues, 0.7 s |
| 5 | Shields | 2 Warriors, 2.5 s; then 8 Minions, 1 s |
| 6 | The Wall of Shields | 6 Warriors, 2 s |
| 7 | Run and Hide | 10 Rogues, 0.6 s; then 4 Warriors, 2 s |
| 8 | The Long March | 14 Minions, 0.8 s; 6 Rogues, 0.7 s; 3 Warriors, 2 s |
| 9 | Iron and Bone | 8 Warriors, 1.6 s; 8 Rogues, 0.6 s |
| 10 | The Bone Mage | 10 Minions, 0.9 s; 6 Warriors, 1.8 s; the Bone Mage |

## 4. The battlefield

One scene. The ground is **hex tiles** from the KayKit Medieval Hexagon Pack: pointy-top
hexes, **2 units across the flats** and 2.31 from point to point, so rows are 1.732 units
apart and every other row sits half a hex to the right. The map is 13 hexes wide and 9 tall,
plus a row behind the top edge for the castle. `Editor/GateGuardMap.txt` holds it; odd rows
are drawn indented, as they sit:

```
 T T M M T T . T T . G C C
  T = = = = = = = = = . C C
 T = . b . . b . . b . . T
  T = . . b . . b . . . . T
 T . = = = = = = = = . . T
  T . . b . . b . . = b . T
 T . b . . b . . b . = . T
  X S = = = = = = = = . T T
 H h T . b . . b . . T T T
```

| Mark | Is | | Mark | Is |
| --- | --- | --- | --- | --- |
| `S` | the start: the road's dead end, where skeletons rise | | `b` | a build plot (13) |
| `=` | road | | `.` | grass, sometimes a rock or a lone tree |
| `G` | the gate's tile: the road runs through the gate | | `T` `M` `H` `h` | trees, a mountain, hills, a small hill |
| `C` | the castle's ground | | `X` | the ruins the skeletons come from |

- **The road** is 31 tiles and 61 units long, from the ruins at the bottom left to the gate
  at the top right: east along the bottom, up and back west across the middle, up and east
  along the top, then a bend north-east into the gate. Every road tile is one of KayKit's
  pieces turned to fit: 23 straights (`hex_road_A`), 7 gentle bends (`hex_road_B`) and the
  dead end (`hex_road_M`). The builder works out each piece and its turn by walking the road
  from `S` to `G`; the book has students paint them.
- **The build plots** are dirt hexes (`building_dirt`) beside the road. Most touch two
  stretches of road, so where to build is a real choice.
- **The castle** stands behind the gate: `wall_straight_gate`, a wall on each side, the
  castle (`building_castle_blue`) and two of its towers. The gate's two doors are separate
  parts of the model, so its Animator can shake them and throw them open (section 7).
- **Waypoints:** `WaypointPath` holds an array of 31 Transforms: one at the centre of each
  road tile in order but the gate's, and the 31st 0.8 units in front of the gate. Gizmos draw
  the path in the Scene view.
- **Look:** the guide that comes with the pack asks for variety: different tree models and
  rotations, rocks on some grass tiles, a hill or two. The builder does that with a fixed
  random seed, so every build is the same.
- **Light:** a Directional Light (rotation (55, 40, 0), colour `#FFF4E0`, intensity 1.3, soft
  shadows), ambient **Gradient** (Trilight: sky `#C9E4F5`, equator `#A8B9C4`, ground
  `#5E6B5A`), and a dark slate behind the map, `#1D2128`. The grass is lemon-green: that's
  the pack's own colour (the hex tops take the light end of the atlas's yellow-olive strip),
  the same in the design's renders.
- **Camera:** at (0.2, 22.5, −17.6), looking at (0.2, 0, 0.7): down at 50.9°. A **Physical
  Camera**, sensor 36 × 20.25 (16:9), focal length 34.2, **Gate Fit: Overscan**: the whole
  16:9 frame shows on any screen. (Chapter 1 starts with Field of View 33, the same view on a
  16:9 screen; Chapter 14 makes it physical. Field of View Axis **Horizontal** turned out to
  be only how the Inspector shows the angle, so it couldn't do this.) It doesn't move.

## 5. The scene

| Object | Components | Notes |
| --- | --- | --- |
| `Main Camera` | Camera (Physical Camera, Gate Fit Overscan), Audio Listener | renderer `GateGuardRenderer` |
| `Directional Light` | Light (Directional, soft shadows) | |
| `Battlefield` → `Ground`, `Decor`, `Castle` | Grid (Hexagon, Cell Swizzle XZY, Cell Size (2, 2.309, 1)); the tiles, painted with the GameObject Brush | |
| `Road` | `WaypointPath`; children `Waypoint 0` … `Waypoint 30` | |
| `Build Plots` | 13 `Build Plot n`: `BuildPlot`, a Box Collider (1.8 × 0.2 × 2) over the hex, the dirt model | layer `Plot`; in the book, a prefab painted with the GameObject Brush onto a `Build Plots` Tilemap |
| `Towers`, `Skeletons`, `Shots` | where built towers, skeletons and shots go | so Restart finds them |
| `Gate` | `Gate`, Animator (`Gate`), the gate model with `Door Left` and `Door Right` | |
| `Gate Game` | `GateGame`, `Bank`, `WaveSpawner`, `Picker`, two Audio Sources (sounds; music, looping, volume 0.5) | |
| `Range Ring` | Line Renderer (64 points, loop), `RangeRing` | hidden until a tower is tapped |
| `Canvas`, `EventSystem` | the HUD, the build menu, the tower menu, the four panels | Screen Space Overlay, 1920 × 1080, match 0.5; the Input System UI module |

**Prefabs:** `Minion`, `Rogue`, `Warrior`, `Bone Mage` (each: the model with its Humanoid
Avatar, Animator, Capsule Collider, kinematic Rigidbody, `Enemy`, a weapon on `handslot.r`,
a `Health Bar` child on a World Space Canvas, a `Frost` particle child); `Arrow Tower`,
`Catapult Tower`, `Frost Tower` (section 7); `Arrow`, `Stone`, `Frost Bolt` (each: the model
or a glowing sphere, a Trail Renderer, `Projectile`); `Dust`, `Frost Burst` (particles).
Layers: `Enemy`, `Plot`.

## 6. The scripts

19 scripts, each with one job:

| Script | On | Does |
| --- | --- | --- |
| `GateGame` | `Gate Game` | The game's state machine: Start, Playing, Paused, Won, Lost. The speed (1 or 2) and `Time.timeScale`; messages; the music; `Restart()` |
| `Bank` | `Gate Game` | `Gold` and `Lives`, properties with a `private set`; `CanAfford`, `Spend`, `Earn`, `LoseLives`; updates their UI |
| `WaveSpawner` | `Gate Game` | The waves' state machine: Waiting, Spawning, In Progress, Cleared. The `Wave[]` array, the countdown, the Start Wave button; spawns each group in a coroutine; pays the wave bonus |
| `Wave` | (plain class) | A wave's name and its `SpawnGroup[]`, `[System.Serializable]` |
| `SpawnGroup` | (plain class) | Which skeleton, how many, the gap, `[System.Serializable]` |
| `WaypointPath` | `Road` | The waypoints in order; `Count`, `GetPoint(i)`; draws the path with Gizmos |
| `Enemy` | each skeleton | A state machine: Rising, Walking, Slowed, Dying, At Gate. Follows the waypoints and faces the way it walks; `DistanceTravelled`; `TakeDamage` (and the red flash); `Slow(factor, seconds)`; sets `WalkSpeed`; the Animation Event methods `OnRisen`, `OnGateHit`, `OnDeathFinished` |
| `EnemyHealthBar` | the bar's canvas | Faces the camera in `LateUpdate`; a Filled Image; hidden until the first hit |
| `Tower` | each tower | Its `TowerLevel[]` and its level. A state machine: Idle, Aim, Fire, Reload. Finds the target with `Physics.OverlapSphere`, turns the crew or the catapult towards it, sets `Aiming` and `Fire` on the crew's Animator and `Level` on its own; `Release()` launches the shot; `Upgrade`, `SellValue` |
| `TowerLevel` | (plain class) | One level's numbers: cost, range, damage, the time between shots, splash, slow, `[System.Serializable]` |
| `TowerCrew` | the archer, the mage, the catapult's turret | Receives the clip's `OnRelease` Animation Event and passes it to its `Tower`: an event only reaches scripts on the Animator's own GameObject |
| `Projectile` | each shot | `enum ProjectileKind { Arrow, Stone, Frost }` and a `switch`: arrows and frost bolts follow their target, a stone flies in an arc; on arrival, damage, splash or slow |
| `BuildPlot` | each plot | Holds its tower; `Build(towerPrefab)`, `Clear()` |
| `Picker` | `Gate Game` | On a press that isn't over the UI, casts a ray from the camera through the pointer against the `Plot` layer: opens the build menu or the tower menu, or closes them |
| `BuildMenu` | the build menu | Opens over its plot (`Camera.WorldToScreenPoint`); one button per tower with its price; a button the player can't afford isn't interactable |
| `TowerMenu` | the tower menu | The tower's name and level; Upgrade (its price, or "Max") and Sell (the refund); shows the range ring |
| `RangeRing` | `Range Ring` | Draws a circle of a given radius on the ground with the Line Renderer: 64 points, from `Mathf.Cos` and `Mathf.Sin` |
| `Gate` | `Gate` | `TakeHit(lives)`: the `Hit` trigger and a thud; at 0 lives, `Broken` and the game is lost |
| `PauseMenu` | the pause panel | Resume, Restart and the volume, as in Knight Run |

Every button is wired in code, in `OnEnable` and `OnDisable` (`AddListener`,
`RemoveListener`), as Level 2 and Knight Run's pause menu do: the ×2 and Start Wave buttons
too. The plan's `SpeedControls` script isn't needed.

## 7. Animation

### The skeletons: one controller, four bodies

The four skeletons share KayKit's medium rig, and so do the Ranger and the Mage. Their
models are imported with **Animation Type: Humanoid**, each with its own Avatar, and the
clips come from the Character Animations pack's `Rig_Medium` files, imported as Humanoid
too. So any clip plays on any of them. One controller, `Skeleton`, made for the Minion:

| Parameter | Type | Set by |
| --- | --- | --- |
| `WalkSpeed` | Float, default 1 | `Enemy`: 1 when walking, the slow factor (0.5) when slowed. The **Walk state's Speed Multiplier**, so a frozen skeleton visibly walks in slow motion |
| `Die` | Trigger | `Enemy`, at 0 health, or after hitting the gate |
| `Attack` | Trigger | `Enemy`, at the gate |
| `Cheer` | Trigger | `GateGame`, on every skeleton still on the road, when the gate falls |

```
 Rise (default) ── exit time ──► Walk (loops; Speed × WalkSpeed)
 Walk ── Attack ──► Attack ── exit time ──► (stays; Enemy sends Die)
 Any State ── Die ──► Die (holds the last frame)
 Any State ── Cheer ──► Cheer (loops)
```

| State | Minion's clip (from) | Event |
| --- | --- | --- |
| Rise | `Skeletons_Spawn_Ground` (Special), state speed 2: 1.8 s | `OnRisen` at 98%: the skeleton can be hit, and starts walking |
| Walk | `Skeletons_Walking` (Special), looped | |
| Attack | `Melee_1H_Attack_Chop` (CombatMelee) | `OnGateHit` at 55%, the chop's frame |
| Die | `Skeletons_Death` (Special), 2 s | `OnDeathFinished` at 98%: pays the bounty if a tower killed it, then removes it |
| Cheer | `Cheering` (Simulation), looped | |

- **Override Controllers:** `Rogue Override` (Walk → `Running_A`), `Warrior Override`
  (Walk → `Walking_A`), `Bone Mage Override` (Attack → `Melee_2H_Attack_Chop`, with its own
  `OnGateHit` at 55%). The rule from Crypt Keys: override when only the clips change. The
  design's `Ranged_Magic_Shoot` for the boss was dropped: the mage crew's `OnRelease` is on
  that clip, and an event belongs to its clip.
- **Events on imported clips** are added in the model's **Import Settings → Animation →
  Events**, because the clip inside an FBX is read-only in the Animation window. A professional
  habit, and the place students will find them in any studio project.
- Every transition has Transition Duration 0.1 (3D bodies blend; sprites didn't), and only
  Rise → Walk has Has Exit Time (Exit Time 1). Attack has no way out: the skeleton falls on
  `Die`. Any State transitions have Can Transition To Self off.
- Every clip the game plays is set up in the Import Settings: **Loop Time** where it
  repeats, and the root's rotation, height and ground position **Baked Into Pose**, based
  upon **Original**, so the rise and the fall stay in the body and the code alone moves and
  turns the character.
- **Weapons** are children of the `handslot.r` bone (and the Warrior's shield of
  `handslot.l`), so they follow the hand.

### The tower crews: one controller, three bodies

| Parameter | Type | Set by |
| --- | --- | --- |
| `Aiming` | Bool | `Tower`, while it has a target |
| `Fire` | Trigger | `Tower`, when it's facing the target and loaded |

```
 Idle ◄── Aiming false / Aiming true ──► Aim (loops)
 Aim ── Fire ──► Shoot ── exit time ──► Aim
```

| Crew | Idle | Aim | Shoot (`OnRelease` on the frame the shot leaves) |
| --- | --- | --- | --- |
| **The Ranger** (Arrow), the `Crew` controller itself | `Ranged_Bow_Idle` | `Ranged_Bow_Aiming_Idle` | `Ranged_Bow_Release`: `OnRelease` at 15%, the string's release frame |
| **The Mage** (Frost), `Mage Override` | `Idle_A` | `Ranged_Magic_Spellcasting` | `Ranged_Magic_Shoot`: `OnRelease` at 40%, the frame the staff points |
| **The catapult**, `Catapult Override` | `Arm Rest`: the arm at 0° | `Arm Wound`: the arm pulled back to −40° | `Arm Throw`, at 30 samples: −40° at `0:00`, 95° at `0:06`, held to `0:18`, back to −40° at `1:00`; `OnRelease` at `0:04`, as the spoon passes the top |

The catapult's clips are **property clips** on its `catapult_arm` part, made in the
Animation window; the archer's and the mage's are imported body clips. The same controller
drives all three: the book's point that an Animator doesn't care what its clips move. The
catapult's turret turns towards the target in code (`Quaternion.RotateTowards`, about Y only);
the archer and the mage turn the same way. `Shoot` plays at Speed 2, and goes back to Aim at
Exit Time 0.9; Idle ⇄ Aim and Aim → Shoot have no exit time; every crew transition blends for
0.1 s.

### The tower's body: `SetInteger("Level")`

Each tower has a second Animator, on its root, with one controller, `Tower`, for all three
kinds:

| Parameter | Type | Set by |
| --- | --- | --- |
| `Level` | Int (1–3) | `Tower`, when it's built and upgraded |

```
 Any State ── Level = 1 ──► Level 1      Any State ── Level = 2 ──► Level 2
 Any State ── Level = 3 ──► Level 3      (Can Transition To Self off)
```

Every tower has the same children, so the same property clips work on all three:

| Child | Level 1 | Level 2 | Level 3 |
| --- | --- | --- | --- |
| `Upper` (a second storey, `building_tower_base`, 0.8 tall) | off | on | on |
| `Top` (the crew's platform, or the catapult) | at 1.38 | at 2.58 | at 2.58 |
| `Flags` (two flags, `flag_<colour>`, 2.6 × size) | off | off | on |

- Each level's clip starts with a pop, at 30 samples: the root's scale 0.9 at `0:00`, 1.1 at
  `0:04`, 1 at `0:08`. Then it holds.
  The keys on `Upper` and `Flags` are **Is Active** keys, the Animation window's way of
  switching a GameObject on and off.
- The colours tell the kinds apart at a glance: **green** for Arrow, **red** for Catapult,
  **blue** for Frost (the pack has every building in four colours).
- A tower grows a storey at Level 2, so it looks taller and shoots further, and raises its
  flags at Level 3.

### The gate

| Parameter | Type | States and clips |
| --- | --- | --- |
| `Hit` | Trigger | Shut → **Shudder** (at 30 samples: the doors, `wall_straight_gate_door_left` and `_right`, turn 0, 4, −4, 3, 0 degrees about Y, the right one the other way, at `0:00`, `0:02`, `0:05`, `0:07`, `0:09`) → Shut |
| `Broken` | Bool | Any State → **Broken**: the doors swing open 100° in 0.6 s (`0:18`) and stay open; `Gate.ResetGate` sets it false and calls `Animator.Rebind()` |

### Effects without the Animator

- **The red flash:** `Enemy` sets each renderer's `material.color` to red for 0.08 s, in a
  coroutine (section 2 says why it isn't a clip).
- **Slowed:** the skeleton's `Frost` particles play, its colour is tinted `#9FD8FF`, and
  `WalkSpeed` is the slow factor.
- **Shots:** a Trail Renderer behind each; the stone lands in a `Dust` burst; a frost bolt
  in a `Frost Burst`.

## 8. The UI

```
┌──────────────────────────────────────────────────────────────────────┐
│ (◉) 120   (♥) 10   (☠) Wave 3 / 10                       [×2] [II]   │
│                                                                      │
│                   ┌──────────────┐                                   │
│                   │ Arrow    50  │  ← the build menu, over the plot  │
│                   │ Catapult 80  │                                   │
│                   │ Frost    60  │                                   │
│                   └──────────────┘                                   │
│                      Wave 3 cleared! +35 gold                        │
│                   [ Start Wave ]   Next wave in 12                   │
└──────────────────────────────────────────────────────────────────────┘
```

- **HUD** (1920 × 1080 canvas, match 0.5): gold, lives and the wave, each a pzUH bar with
  an icon (the wave's bar longer, 340 wide, so `Wave 10 / 10` fits on one line); the ×2 and
  pause buttons (pzUH's square buttons); the message line; Start Wave with the countdown.
  Start Wave is switched off in the scene: the spawner shows it while it waits for a wave.
- **The build menu** is a small pzUH panel placed over the plot that was tapped
  (`Camera.WorldToScreenPoint`, kept inside the screen). Three buttons, each with the tower's
  icon and price. A button whose tower the player can't afford isn't interactable, and its
  **Sprite Swap** shows the pack's grey **Locked** picture: the Disabled state.
- **The tower menu**: the tower's name and its level as stars, **Upgrade** with its price
  (or "Max"), **Sell** with the refund. The range ring shows round the tower while it's open.
- **Health bars** float over each skeleton on a **World Space Canvas** that turns to face
  the camera every `LateUpdate`. They appear at the first hit. The Bone Mage's is bigger.
- **Buttons** use pzUH's four pictures, Normal, Hover (Highlighted), Click (Pressed) and
  Locked (Disabled), through a Sprite Swap transition.
- **Panels**, on pzUH's parchment panel with its ribbon title: Start ("Gate Guard", how to
  play, **Play**, and the icons' credits on two lines), Pause (**Resume**, **Restart**,
  Volume), Won (a crown under the ribbon, "The gate held!", lives left, **Play Again**),
  Lost ("The gate has fallen", **Try Again**). Each is a dimming sheet over the screen (black,
  55%), a window and a ribbon.
- **Text**: TextMeshPro with Lilita One, a chunky cartoon font that suits the art
  (decision 4), with a dark outline.

### The game's own state machine

Start → Playing ⇄ Paused; Playing → Won (wave 10 cleared) or Lost (no lives left). As in
Knight Run, each state's enter step shows its panel and sets `Time.timeScale`: Playing uses
the chosen speed, 1 or 2. Every button calls the same `Restart`. The music starts on
**Play**: `Road` while building, `Tension` from wave 8.

## 9. The book

Every chapter has the curriculum's beats (Goal, Idea, Do it, Test it, Challenge). The 12
shared C# Concepts are placed where the game first needs them, in an order `assemble.mjs`
accepts. As written (`Docs~/workbook/book.md`; the PDF has 249 pages):

| Part | Chapters and C# Concepts |
| --- | --- |
| 0 Before You Start | the game, the route, setup: a new project from **Universal 3D**, **2D Tilemap Extras** from the Package Manager, the packs |
| 1 The Battlefield | _Naming Conventions_ · 1 A Hex Battlefield (model import settings, the hex Grid with Swizzle XZY, the GameObject Brush with Anchor (0, 0, 0), the three road pieces and their turns, rows 0 to 2 painted, the camera and the sun) · 2 The Road (rows 3 to 8 and the castle row, the seven other turned tiles, the castle and the gate placed by hand, `WaypointPath`, 31 waypoints and Gizmos) |
| 2 The Skeletons | _The Animation Window_ · 3 Bones That Walk (Humanoid Avatars, a clip's import settings, a clip from another file in the preview, a blade on `handslot.r`, a one-state test controller, `Enemy` walking the waypoints) · _The Animator Controller_ · _Driving the Animator from Code_ · 4 Rise, Walk, Fall (the `Skeleton` controller, `WalkSpeed` as the Walk state's Speed Multiplier, hashes, Die and Cheer tested from the Parameters list) · _Animation Events_ · _State Machines with enum and switch_ · _Enemies as State Machines_ · 5 The Enemy's State Machine (three events in the Import Settings, the state machine, health and the red flash with a test key, the gate's Shut and Shudder property clips and `Gate`, `GateGame` with the `IsPlaying` stand-in, the Minion prefab, `Begin`, and a spawner that sends a skeleton every three seconds) · 6 Four Kinds of Skeleton (three Override Controllers, three more prefabs, one script with other numbers) |
| 3 The Towers | _Game UI_ · 7 Plots and Gold (UI sprites, the Lilita One font asset, the Canvas, the gold and lives bars, `Bank`, the gate costs lives, `Tower` as a stand, the Build Plot prefab painted onto a `Build Plots` Tilemap, the Arrow tower's body with a one-state `Crew`, the build menu with one tower, `Picker`'s ray from the camera) · 8 The Arrow Tower (colliders on an Enemy layer, `DistanceTravelled`, the bounty, the `Crew` controller, the release frame and `TowerCrew`, `TowerLevel`, the arrow with a Trail Renderer, `Tower`'s state machine, `OverlapSphere` and first in line) · 9 Catapult and Frost (one controller for three crews, the catapult's three property clips, `ProjectileKind` and the stone's arc, splash and slow, the Slowed state, three Particle Systems, the build menu with all three towers) · 10 Three Levels (`TowerLevel[]`, the `Tower` controller with an Int and Is Active keys, a second storey and flags, Upgrade and Sell, the range ring from Cos and Sin, the tower menu) |
| 4 Waves | 11 Ten Waves (`Wave[]` and `SpawnGroup[]`, the spawner's state machine, the countdown, the bonus, messages that fade, the wave's HUD) · 12 The Screen (world-space health bars, `Cheer`, ×2 speed, the pause button, the four panels built) · 13 Hold the Gate (the gate's `Broken` Bool, the game's states, Restart piece by piece, the pause menu) · 14 Sound and Light (Audio Sources and the last versions of six scripts, music, the sun's colour and soft shadows, gradient ambient light, the Physical Camera) |
| 5 Finish | _Reading Code_ · _Finding Errors_ · _Kinds of Classes_ · 15 Break It, Then Fix It (a hash typo, `SetFloat` on an Int, an event with no receiver and on the wrong object, an empty Override slot, an empty mask, an empty field, a state change that skips its enter step, a breakpoint in `Tower.EnterState`) · 16 Ship It (a Web build that plays with a finger) |
| 6–7 The Exam, Check Yourself | _The User Exam_ · exam-style questions, a practice paper, the cheat sheet |

Chapters 4, 8 and 10 are the heart of the book: one controller for four skeletons, one for
three crews, and a tower's looks switched by an Int. The shared chapters' examples come from
the 2D games; Part 0 says so, and the build chapters show the same ideas in 3D.

**How the scripts grow.** Every version compiles at its step (`check-code.mjs`: 44 script
versions, 19 cards). `Enemy` appears seven times (Chapters 3, 4, 5, 8, 9, 12, 14) and
`GateGame` six (5, 7, 11, 12, 13, 14). `GateGame` arrives in Chapter 5 as the object the
battlefield shares, with an `IsPlaying` that always answers `true` until Chapter 13, so no
script needs changing when the game gets its states. `Projectile.Launch` takes the Enemy
mask from Chapter 8, though arrows don't need it, so `Tower` doesn't change in Chapter 9.
Most scripts reach their last version in the chapter that needs them; Chapter 14 gives the
last versions of the six that gain sounds, as Crypt Keys' Chapter 14 does.

**Challenges:** 1 a bend's turn worked out from its neighbours; 2 `OnDrawGizmosSelected`;
3 the walk speed that matches the feet; 4 the Rise state's speed against the code's timer;
5 the Debug Inspector, and an event moved too early; 6 a fifth kind, the Captain, with no
new code; 7 scaffolding for a second while a tower builds (`building_scaffolding`, in the
pack); 8 nearest-first targeting against first-in-line; 9 a Frost tower with splash at
Level 1; 10 a fourth level; 11 gold for starting a wave early; 12 a health bar that changes
colour; 13 a Give Up button; 14 footsteps on an event; 15 break it for a classmate; 16
playtesting.

## 10. Art and sound

Every pack is **CC0** and free, except the icons (CC BY 3.0, credited). Only the files the game
uses go into `Art/` and `Audio/`, each pack's licence beside them, and `CREDITS.md` names every
pack and every icon's author. All were opened and checked in a scratch folder:

| What | Pack | Creator | Link |
| --- | --- | --- | --- |
| The battlefield: hex tiles, the road pieces, trees, rocks, hills, the ruins, the dirt plots; the castle, walls and gate (doors as separate parts); the towers in four colours, the catapult tower (turret and arm as separate parts) and its stone; flags | KayKit Medieval Hexagon Pack 1.0, free | Kay Lousberg | kaylousberg.itch.io/kaykit-medieval-hexagon |
| The skeletons: Minion, Rogue, Warrior, Mage; blade, axe, staff, shields | KayKit Skeletons 1.1, free | Kay Lousberg | kaylousberg.itch.io/kaykit-skeletons |
| The crews: the Ranger and the Mage; bow, arrow, staff | KayKit Adventurers 2.0, free | Kay Lousberg | kaylousberg.itch.io/kaykit-adventurers |
| Every clip: walk, run, rise, attack, death, cheer, bow, magic, idle (161 for the medium rig; 6 files used) | KayKit Character Animations 1.1 | Kay Lousberg | kaylousberg.itch.io/kaykit-character-animations |
| Panels, ribbons, buttons in four states, bars, coin, heart | Free Fantasy Game GUI | pzUH | opengameart.org/content/free-fantasy-game-gui |
| Seven icons: the three towers' (bow, trebuchet, snowflake), hearts, skull, crossed swords, sell | game-icons.net (CC BY 3.0) | Lorc, Delapouite, Skoll and sbed | game-icons.net |
| The font (decision 4) | Lilita One (SIL OFL 1.1, its licence file beside it) | Juan Montoreano | fonts.google.com/specimen/Lilita+One |
| Sounds and music (`Road`, `Tension`) | Ninja Adventure, already in Crypt Keys | Pixel-Boy & AAA | pixel-boy.itch.io/ninja-adventure-asset-pack |

- **Use the itch.io and OpenGameArt copies.** KayKit's Unity Asset Store editions are under
  the Asset Store's licence, not CC0.
- **Not used:** the Medieval Builder Pack (KayKit's page calls it legacy and points to the
  Hexagon pack, which has everything it had) and Quaternius's Ultimate Fantasy RTS (another
  style; the towers' upgrade looks come from KayKit's parts instead). Neither was downloaded.
- **No cannon:** KayKit's cannons are in the paid Extra tier, so the Cannon tower of the plan
  is a **Catapult** (decision 2).
- **Sounds** from Ninja Adventure, renamed by what they're for (`CREDITS.md` maps each to
  its file in the pack): `Bow` (Whoosh), `Launch`, `StoneHit` (Explosion2), `Frost`
  (Magic2), `Bones` (Hit1), `Crumble` (Hit5), `GateHit` (Impact4), `GateBreak` (Explosion4),
  `Build` (Accept2), `Sell` (Coin2), `WaveStart` (Alert2), `Win` (Success3), `Lose`
  (GameOver), and the music `Road` and `Tension`. No sound for the bounty: a coin sound
  every time a skeleton falls was too much.
- **game-icons.net credits:** "Icons made by {author}. Available on https://game-icons.net",
  for each icon, in `CREDITS.md` and on the Start panel's Credits line.

## 11. Shared with Knight Run and Crypt Keys (`Level3-Shared`)

The 12 C# Concept chapters, Check Yourself, `assemble.mjs`, `check-code.mjs`, the PDF builder
and `Level3BuilderKit.cs`. Gate Guard added nothing to the kit: its 3D helpers (models' and
clips' import settings, Humanoid Avatars, the hex battlefield from the map, the 3D renderer,
the particles) live in `GateGuardSceneBuilder.cs`, since no other Level 3 game needs them,
and it uses the kit's Animator, clip, UI and font helpers as they are. So Knight Run's and
Crypt Keys' builders are untouched.

## 12. The website

The third Level 3 entry in `web/levels.config.mjs`, `level-3-gate-guard`, locked with its
own `COURSE_PW_LEVEL_3_GATE_GUARD` secret.

## 13. Acceptance checks, and what the lab checks first

**Before building**, in a copy of the project (the lab), check what this design relies on.
Checked on 1 October 2026, with 6 play tests, all passing:

1. **Passed.** The Minion, the Ranger and the Mage import as valid Humanoid Avatars (17
   bones mapped), and all 97 clips in the six clip files import as Humanoid. A clip from
   another file moves the Minion's feet, and `WalkSpeed` 0.5 halves the walk's progress
   (0.625 → 0.313 cycles a second).
2. **Partly.** Unity's Hexagon layout with Cell Swizzle XZY matches the tiles exactly
   (2 units across, rows 1.73 apart, odd rows shifted right), and the GameObject Brush
   paints them once its **Anchor** is (0, 0, 0). But the brush's rotate turns a tile 90°
   about the wrong axis, so the book paints each bend and then sets its **Y Rotation** in
   the Inspector: 9 of the 31 road tiles. The builder places every tile from the map.
3. **Passed.** One controller: the archer, the mage (`Mage Override`) and the catapult's
   arm (`Catapult Override`, property clips on `catapult_turret_red/catapult_arm_red`) all
   go Idle → Aim → Shoot, each firing `OnRelease` once.
4. **Passed.** Events added in the Import Settings (`OnRisen`, `OnGateHit`,
   `OnDeathFinished`, `OnRelease`) reach a script on the Animator's GameObject.
5. **Passed.** The catapult's arm and the gate's doors are separate parts in Unity; the
   arm swings from −40° to +44°, and the doors' pivots are at their hinges (x = ±0.45).
6. **To do while building:** a Web build with 30 skeletons on the road, on a phone.

Also found: an imported model's Animator defaults to **Cull Update Transforms**, so its
bones only move while a camera sees it. The game's camera sees the whole battlefield; the
play tests, which render nothing, set **Always Animate**.

**When built** (1 to 2 October 2026, in the lab, a copy of the project):

- **Passed.** The scene builds with no errors or warnings.
- **Passed.** 11 play tests of the built game (and two passes that take pictures, of the
  panels and of the cover): each tower built, upgraded to Level 3 and sold (60% back), with its Level looks; the
  build buttons following the gold; the first skeleton in line targeted, the arrow leaving
  on the release frame, the bounty paid on `OnDeathFinished`; a stone hitting three
  skeletons; frost halving a skeleton's speed and its `WalkSpeed`; a skeleton at the gate
  costing lives on `OnGateHit`, with no bounty; the last life breaking the gate (`Broken`),
  the others cheering, and the game Lost; wave 1, its bonus and the countdown; wave 10 with
  the boss, and Won; pause and ×2; Restart putting back gold, lives, the waves, the gate
  and every plot.
- **Passed.** `node check-code.mjs`: `ok (44 script versions, 19 cards, 21 C# examples)`.
- **Passed.** The PDF built on this Mac (249 pages), and every page looked at.
- **Passed.** The website builds with the book published (35 pages).
- **To do:** lab check 6, a Web build with thirty skeletons on the road, on a phone; and
  Moayad's own play in the project.

**Checked again** on 2 October 2026, with Knight Run and Crypt Keys in the same project:

- **Passed.** The builder's scene matches the one built in Moayad's Editor (Unity's
  internal ids aside), and the 11 play tests pass.
- **Found, and the book changed:** making `Rig_Medium_General` Humanoid logs 56 red lines,
  `Assertion failed on expression: 'IsFinite(curve.GetKey(0).value)'`, at every import.
  They come from its `Spawn_Air` and `Spawn_Ground` clips, which the game doesn't use:
  their first frame scales every bone to 0, so Unity drops those two clips' arm and leg
  curves (87 of 130 kept). No import setting stops it (compression, resampling and the
  clips' first frame were tried); as Generic, the file imports cleanly. Chapter 3 now says
  to expect the lines and clear them.
- **Found, and the book changed:** Chapter 15's breaks, made in the lab the way the book
  has students make them. The hash typo, the wrong call and the event with no receiver
  give exactly the messages and line numbers the book quotes. The empty **Gold Text**
  didn't: a `TMP_Text` field is a script's type, so it gives a `NullReferenceException`,
  not an `UnassignedReferenceException`. When `Awake` throws, Unity switches `GateGame`
  off, so `OnEnable` never connects the buttons; and since all four panels start switched
  off (Chapter 12), no panel shows at all. Chapter 15 now says so.
- **Found, and the builder changed:** the builder left the Start panel switched on,
  unlike Chapter 12, which switches all four panels off. It switches the Start panel off
  now; `Awake` shows it, so the game plays the same, and the play tests pass.

## 14. Out of scope

More maps or levels (loading scenes is Level 4), saving (Level 4), object pooling (Level 4),
NavMesh (the skeletons follow waypoints), a camera that pans or zooms, Cinemachine and
Animator layers (Level 5), flying enemies, and tower abilities beyond the three kinds.

## 15. Decisions for Moayad (design version 1): all six approved, 1 October 2026

1. **The art and sound in section 10.** KayKit's Hexagon, Skeletons, Adventurers and
   Character Animations packs, pzUH's GUI, game-icons.net icons (credited), and Ninja
   Adventure's sounds, already in the project. *Recommended.*
2. **A Catapult instead of a Cannon.** The free packs have no cannon. The catapult tower
   has a turret that turns and an arm that throws, and does the cannon's job: splash damage.
   *Recommended.*
3. **Paint the battlefield step by step** with the GameObject Brush, as Knight Run's and
   Crypt Keys' maps were painted: the bottom road in Chapter 1, the rest in Chapter 2. The
   brush paints the tiles; each of the 9 tiles that must turn (6 bends, 3 diagonal straights) is then turned in the Inspector (lab check 2).
   The other way is a ready-made battlefield the students open, with that time spent on
   code. *Recommended: step by step.*
4. **The font: Lilita One** (Google Fonts, OFL). It needs your OK to download. The other
   way is TextMeshPro's built-in font. *Recommended: Lilita One.*
5. **The Bone Mage in wave 10:** a boss, 1.5 × the size of a skeleton, who costs 5 lives if
   he reaches the gate. *Recommended.*
6. **The skeletons' hit is a red flash in code**, not an Animator clip, so their walk never
   stops; Level 5's layers show the other way. *Recommended.*

## 16. What changed while building

- **No `TowerKind`.** The towers differ only in the Inspector and in their shots, so the
  kind's `switch` is `Projectile`'s (section 2).
- **The Bone Mage chops** with `Melee_2H_Attack_Chop`, not `Ranged_Magic_Shoot`, whose
  `OnRelease` belongs to the mage crew (section 7). **The skeletons fall** with
  `Skeletons_Death`, made for them, not `Death_A`.
- **Event times**, set by scrubbing each clip: `OnRisen` and `OnDeathFinished` at 98% (an
  event on the very last frame can be skipped by a blending transition), `OnGateHit` at
  55%, the bow's `OnRelease` at 15% and the magic's at 40%. Every property clip's keys and
  events are on whole frames at 30 samples, as the book has students make them.
- **The camera** is a Physical Camera with Gate Fit Overscan; the Field of View Axis can't
  keep the frame (section 4).
- **Buttons are wired in code**, ×2 and Start Wave included (section 6).
- **The waypoints** are 31: the gate's tile has none, and the last is 0.8 in front of the
  gate (section 4).
- **The book's order** (section 9): _Game UI_ comes before Chapter 7, the first chapter
  with UI. The gate's property clip, `GateGame` and a first spawner come in Chapter 5, so
  skeletons are prefabs, and the road is never empty while Chapters 7 to 10 build towers.
  The build menu has one tower in Chapter 7 and three in Chapter 9; the particles come in
  Chapter 9, where frost needs them; the four panels are built in Chapter 12 and wired in
  Chapter 13.
- **Found while writing the book, and fixed in the game:** the stone's landing sound was
  played at the stone, a 3D sound nearly 30 units from the listener, so almost silent: it
  plays at the camera now. The lab's screenshots showed `Wave 10 / 10` wrapping onto two
  lines, the Victory crown off the top of the screen, the volume slider wider than its
  window and the credits on the window's border: all four fixed. Start Wave no longer shows
  through the start screen.
- **Not used, so not in the game:** the ×2 icon (the button says `x2` or `x1`), pzUH's
  health-bar frame, and a coin sound for the bounty.
- **The kit is unchanged** (section 11).
- **Checked again on 2 October** (section 13): Chapter 3 warns about the 56 import lines,
  Chapter 15's empty field has Unity's real message and behaviour, and the builder
  switches the Start panel off, as Chapter 12 does.
- **The lab's tests and screenshots** are in a copy of the project, not here, as Knight
  Run's and Crypt Keys' are.
