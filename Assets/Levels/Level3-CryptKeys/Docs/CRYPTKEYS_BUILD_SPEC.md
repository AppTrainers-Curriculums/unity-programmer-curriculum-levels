# Crypt Keys — Level 3 Build Spec

Spec for **Crypt Keys**, the second game of Level 3 ("Junior-ready") of the Unity
Programmer Curriculum. Hand it to Claude in VS Code for checks or changes.

> **Status: built, with its book (1 October 2026).** Moayad approved design version 1 on
> 1 October 2026, with every recommendation in section 15. The scripts, the scene builder
> and the book are done, and the game plays through in the lab's play tests (section 13).
> This spec is the source of truth for the scripts, the scene builder and the book, as
> Knight Run's is. The exact tile-by-tile map is `Editor/CryptKeysMap.txt`.

---

## 1. Context

- **Audience:** students who passed the Level 3 entry test, which tests Level 2. Everything
  in Levels 0–2 is theirs to use.
- **The book stands alone.** Like Knight Run, Crypt Keys teaches **every** Level 3 topic,
  with the same 12 shared C# Concept chapters and Check Yourself part from
  `Assets/Levels/Level3-Shared`, so a trainer can teach either game. The concepts are the
  same; the game puts different ones in the foreground:

| | Knight Run | Crypt Keys |
| --- | --- | --- |
| View | 2D side-on platformer | 2D top-down dungeon |
| The hero's Animator | one state machine, parameters through hashes | **four sub-state machines**, one per direction, chosen by `SetInteger("Direction")` |
| Enemies | the Animator follows the code through one Int, `State` | **one Animator Controller for four characters**, through Override Controllers; the code's state machine decides, the Animator shows the body |
| Bool parameter | `Grounded`, `Lit` | a door's `Open`, the boss's `Whirlwind` |
| Animation Events | footsteps, end of the roll, the slime's leap | the sword's **hit frame**, the arrow's **release frame**, the chest's **loot frame**, the door's **open frame**, the boss's **summon** |
| UI | a sliding health bar | a **row of hearts** with half hearts (`/` and `%`), keys, a potion inventory, a **boss bar** |

- **Unity skills a professional uses, new in this book** (engine features, so they fit
  Level 3's code limits):
  - Animator sub-state machines with Exit and Entry transitions, and copying and pasting a
    whole state machine;
  - one controller shared by four characters, and a copied, extended controller for the
    boss: when to override and when to copy;
  - top-down sorting by height (**Transparency Sort Axis**), with sprite pivots at the feet,
    and a **Sorting Group** for a picture made of several sprites;
  - colliders at the feet, the top-down way;
  - the **Pixel Perfect Camera**, for crisp pixel art at any screen size;
  - a **Random Rule Tile** for floors that don't repeat;
  - cutting extra sprites out of a sliced sheet in the Sprite Editor, with custom pivots;
  - **2D lights**: a dark crypt, torches with Point Lights, and their flicker animated in
    the Animation window, a property clip on a component that isn't a Transform;
  - melee hits with `Physics2D.OverlapCircleAll` and a layer mask; line of sight with
    `Physics2D.Linecast`;
  - a room-to-room camera.
- **Engine:** as Knight Run: Unity 6 (6000.6), URP 17 with its 2D Renderer, the Universal 2D
  template, the Input System package only, Tilemap Extras (for the Rule Tile).
- **Location:** `Assets/Levels/Level3-CryptKeys/` in `~/apptrainers/unity-programmer-curriculum-levels`:

```
Assets/Levels/Level3-CryptKeys/
├── README.md, CREDITS.md
├── Curriculum.Level3.CryptKeys.asmdef      runtime assembly (not auto-referenced)
├── Scripts/            the 18 scripts in section 6
├── Editor/             CryptKeysSceneBuilder.cs, CryptKeysMap.txt (the rooms' map),
│                       Curriculum.Level3.CryptKeys.Editor.asmdef
├── Art/                Characters/ (Hero, Skeleton, Archer, King), Tiles/, Props/, UI/,
│                       Fonts/, Licences/ (section 10)
├── Audio/              16 sounds, 2 pieces of music, the Ninja Adventure licence
├── Animation/          92 clips, 8 Animator Controllers, 2 Override Controllers (created by the builder)
├── Tiles/              the tileset's 112 Tile assets, the Floor and Tomb Floor Random Rule
│                       Tiles, and the Crypt Palette           (created by the builder)
├── Prefabs/            Skeleton, Archer, Skeleton King, Arrow, Chest, Door, Key, Boss Key,
│                       Potion, Gold, Wall Torch, Standing Torch, Banner, Statue, Shield
│                       Statue, Pillar                         (created by the builder)
├── Scenes/             CryptKeys.unity                        (created by the builder)
├── Docs/               workbook PDF, this spec
└── Docs~/workbook/     book.md (source), workbook.md (assembled), cover.png
```

## 2. Hard rules (Level 3 limits)

Exactly Knight Run's (`Level3-KnightRun/Docs/KNIGHTRUN_BUILD_SPEC.md`, section 2): Levels 0–2,
plus state machines with `enum` + `switch` and one `EnterState`, the Animator API through
`static readonly` hashes, Animation Events, `[System.Serializable]` plain classes and the
naming conventions. Not yet: inheritance, interfaces, C# events and delegates, `SceneManager`,
`PlayerPrefs`, making ScriptableObjects, prefab variants, pooling, Input Actions, `try` /
`catch` (Level 4); blend trees, Animator layers, Cinemachine, LINQ (Level 5). Never `var`,
`Find…` or the older `Input` class.

New Unity members the book introduces where it needs them: `Physics2D.OverlapCircleAll`,
`Physics2D.Linecast`, `Animator.Rebind`, `GetComponentsInChildren<T>(true)`,
`Object.Instantiate` of a scene object, sub-state machines with the Exit and Entry nodes,
Override Controllers, Light 2D, the Pixel Perfect Camera, the Sorting Group and the Rule Tile.
`Facing` is the book's one `static class` (`Facings`, two helper methods), as Level 2 taught.

Three consequences, said out loud in the book:

- **Three enemy scripts that repeat themselves.** `Skeleton`, `Archer` and `SkeletonKing`
  each have their own health, hurt and death code. A base class would share it: that's
  Level 4's inheritance, and the book says so.
- **One Animator for four characters.** The hero, the skeleton, the archer and the king
  have the same 20 animations, so they share one controller through Override Controllers.
  The king adds two attacks no one else has, so he gets a copy of the controller, extended.
- **Restart resets the crypt in code**: every enemy, door, chest and pickup has a reset
  method, as in Knight Run.

**Style:** as Knight Run, including the naming table (Animator parameters in PascalCase,
hashed once; Animation Event methods start with `On`).

## 3. The game

A warrior explores a crypt of **six rooms**, stacked one above the other: each room's only
way out is the door in the middle of its top wall, which leads up into the next room. Keys
open doors, chests give loot, and skeletons and skeleton archers guard the way to the tomb
of the Skeleton King.

```
  6  The King's Tomb          the Skeleton King
            ▲  door 5: the boss key
  5  The Chapel
            ▲  door 4
  4  The Archers' Gallery
            ▲  door 3
  3  The Ossuary
            ▲  door 2
  2  The Hall of Bones
            ▲  door 1
  1  The Crypt Gate           the hero starts here
```

| Door | From → to | Needs | Found in |
| --- | --- | --- | --- |
| 1 | The Crypt Gate → The Hall of Bones | a key | Room 1's chest |
| 2 | The Hall of Bones → The Ossuary | a key | Room 2's chest |
| 3 | The Ossuary → The Archers' Gallery | a key | Room 3's chest |
| 4 | The Archers' Gallery → The Chapel | a key | Room 4's chest |
| 5 | The Chapel → The King's Tomb | the boss key | Room 5's chest |

Each room has one chest, and the key in it opens that room's door, so the crypt goes in
order: 1 → 2 → 3 → 4 → 5 → 6.

| Room | Name | Teaches the player | In it |
| --- | --- | --- | --- |
| 1 | **The Crypt Gate** | walking, opening a chest and a door | 2 standing torches, 2 wall torches, 2 banners, a chest (a key), gold |
| 2 | **The Hall of Bones** | the sword, skeletons | 2 skeletons, 4 statues, 2 wall torches, a chest (a key), gold |
| 3 | **The Ossuary** | archers, cover | 2 skeletons, 1 archer, 4 pillars to hide behind, 2 wall torches, a chest (a potion and a key) |
| 4 | **The Archers' Gallery** | cover and timing | 2 archers behind shield statues, 1 skeleton, 2 more shield statues, a chest (a key), a potion |
| 5 | **The Chapel** | a breather before the boss | the red carpet, 2 standing torches, 2 wall torches, 2 banners, a chest (**the boss key**), gold, a potion |
| 6 | **The King's Tomb** | the boss in two phases | the Skeleton King, 2 stone knights, 4 standing torches, 2 wall torches, 2 banners, the two skeletons he summons |

**Controls**

| Action | Keyboard | Mouse and touch |
| --- | --- | --- |
| Walk | W A S D or the arrows | press and hold: the hero walks towards the pointer |
| Attack | Space or J | a quick tap or click (shorter than 0.25 s): he turns that way and swings |
| Open a chest | E, facing it | a quick tap, when a chest is in front of him |
| Drink a potion | Q | tap a potion slot |
| Pause | Esc or P | the pause button |

A locked door opens by itself when the hero walks into it carrying its key: no button.
Walking into it without one shows "Locked: find a key" (or "The boss key opens this door").

**Rules**

- The hero has **3 hearts**, counted in **half hearts**: 6 health. A skeleton's sword, an
  arrow or the king's whirlwind costs half a heart; each of the king's two slashes costs a
  whole one.
- Hurt: knocked back, no control for 0.2 s, blinking for 1 s, when nothing can hurt him.
- The sword hits whatever is in front of him, at the attack clip's hit frame.
- A skeleton takes 3 hits, an archer 2, the king 20.
- A potion gives back a whole heart. He carries up to 3; a potion he can't carry stays where
  it is. Q does nothing at full health.
- Keys are counted. A door uses one; the Chapel's door needs the boss key.
- A pile of gold is 25; there are 3. Gold only counts: the win panel shows the gold and the
  time.
- **The Skeleton King** sleeps until the hero walks into his tomb. Phase 1: he walks at the
  hero and swings. At half health he summons two skeletons (the sword clangs off him while
  he does), and Phase 2 begins: he spins after the hero in a whirlwind that turns the sword
  aside (clang), rests, open to the sword, and spins again. Beating him wins.
- At 0 health the hero falls, and **Try Again** shows. **Restart** puts the whole crypt back.

**Numbers**

| Thing | Value |
| --- | --- |
| Tile | 1 × 1 unit: 32 pixels, every Lucifer sprite at 32 Pixels Per Unit (0x72's chest at 16, so it's one tile) |
| Room | 19 × 11 tiles: the dark round the edge, a floor of 17 × 8, and the wall's face, 2 tiles tall, along the top; the door in the middle column (x = 9) |
| Stacking | room k fills rows 11k to 11k + 10, x 0 to 18; its centre is (9.5, 11k + 5.5) |
| Camera | Pixel Perfect Camera: Assets PPU 32, reference resolution 640 × 352 (20 × 11 tiles: one room), Crop Frame Letterbox, Grid Snapping Upscale Render Texture; it slides room to room at 30 units/s |
| Hero | walks at 4 units/s; 48-pixel frames, pivot 8 pixels up (his feet); a capsule 0.55 × 0.3 at his feet |
| Sword | a circle of radius 0.6, 0.7 units in front of his middle (0.4 above his feet); 1 damage |
| Chest | opened from a circle of radius 0.45, 0.6 in front of his feet |
| Skeleton | 3 health; patrols at 1.5 within 2 units of home; chases at 2.5 when the hero is within 5 units and in sight (gives up beyond 10); attacks from 1 unit; hits if the hero is within 0.8 of a point 0.6 in front |
| Archer | 2 health; moves at 2; sees 9 units; keeps 4 to 6 units away; shoots (1 s), then steps aside (0.8 s); arrows at 7 units/s, gone after 3 s |
| King | 20 health; walks at 1.5; swings from 1.5 units, two slashes a swing (1 s), each a whole heart if the hero is within 1.1 of a point 0.8 in front; summons at 10 health (1.2 s); whirlwind 3 units/s for 2 s, half a heart within 1 unit; rests 1.5 s |
| Knockback | hero 6 units/s; enemies 4 units/s, stopped after 0.15 s |

## 4. The crypt

All six rooms are in **one scene**, painted on **Tilemaps** under one `Grid`, at 32 pixels
a tile:

| Tilemap | Order in Layer | Holds | Collider |
| --- | --- | --- | --- |
| `Floor` | −30 | the floor: the **Floor** Random Rule Tile, or the **Tomb Floor** in room 6 | none |
| `Decoration` | −25 | the Chapel's red carpet: nine tiles, corners, edges and middle | none |
| `Walls` | −20 | the wall's face and the dark round each room | Tilemap Collider 2D, merged by a Composite Collider 2D (Polygons) on a Static Rigidbody 2D; layer `Walls` |

The builder paints the rooms from `Editor/CryptKeysMap.txt`; **each room is painted step by
step in the book**, in the chapter that first needs it (section 9). The map's letters:

| Mark | Is | | Mark | Is |
| --- | --- | --- | --- | --- |
| `#` | the dark (black tile, collider) | | `H` | the hero's start |
| `W` | the wall's face | | `s` `a` `K` | a skeleton, an archer, the king |
| `D` | the doorway: no tile, the door | | `x` | a summon point |
| `.` `,` | floor, tomb floor | | `k` `q` `b` | a chest with a key; a potion and a key; the boss key |
| `d` | a doorway's threshold (floor) | | `g` `p` | gold, a potion |
| `R` | the red carpet | | `S` `Z` `O` | a statue, a shield statue, a pillar |
| `t` `B` | a wall torch, a banner (on the wall) | | `T` | a standing torch |

- **Colliders:** only the seven tiles the walls are painted with have a Grid collider: the
  dark (`DungeonTileset_0`) and the wall's face (`_1` to `_3`, `_14` to `_16`). Every other
  Tile asset has none.
- **The wall's face** is two tiles tall: its top row has the dark edge along its top
  (tileset row 0), its bottom row the shadow where it meets the floor (row 1). A wall's end
  tiles (columns 4 and 6) have a dark edge on their side, beside the dark or the doorway;
  the middle is column 5.
- **The floor's Random Rule Tile** has one rule, no neighbours (it matches every cell), and
  Output Random among six sprites, Perlin Scale 0.5: cracked, slightly cracked, plain, plain,
  slightly cracked, cracked. Perlin noise gathers round the middle, so plain squares come up
  most. The **Tomb Floor**: dark cobbles, three dark squares, a dark slab.
- **Import:** every picture is pixel art: Filter Mode Point, Compression None, no mipmaps.
  Sheets are Sprite Mode Multiple, sliced as the book slices them; one-picture sprites
  (the keys, the arrow, the hearts, the panel, the slot and the three buttons, with their
  9-slice borders) are Single. Pixels Per Unit is 32 in the world (16 for 0x72's chest and
  spikes, so each is one tile) and 100 for sprites used only on the Canvas.
- **Sorting:** the 2D Renderer's **Transparency Sort Mode** is **Custom Axis (0, 1, 0)**, and
  every sprite's **Sprite Sort Point** is **Pivot**, at its foot: lower on the screen draws
  in front, so the hero walks behind a statue and in front of it. The door's three sprites
  sort as one through a **Sorting Group**.
- **Props** are prefabs cut from the tileset with their pivot at their foot. Those that
  stand on the floor (statues, shield statues, pillars, standing torches) have a Box
  Collider 2D at their foot on the `Walls` layer: they stop the hero, arrows and the
  enemies' sight, so they're cover.
- **Light:** a **Global Light 2D**, intensity 0.35, colour `#A7B0D8`, makes the crypt dark.
  Each torch has a **Point Light 2D** on its `Flame` child (`#FF9A40`, intensity 1.2,
  outer radius 4.5, inner 0.9) with a looping flicker clip; the hero carries a faint light
  of his own (`#FFE3B8`, 0.6, radius 3).
- **Rooms:** each room is a `[System.Serializable]` `Room` (its name, its centre and
  whether the king is there) in `CryptGame`'s array. The hero's room is
  `Mathf.FloorToInt(y / 11)`; when it changes, the camera slides there and the room's
  name fades in, as Knight Run's section names do.

## 5. The scene

| Object | Components | Notes |
| --- | --- | --- |
| `Main Camera` | Camera (orthographic, size 5.5, black), Audio Listener, Pixel Perfect Camera, `RoomCamera` | |
| `Global Light 2D` | Light 2D (Global) | |
| `Grid` → `Floor`, `Decoration`, `Walls` | section 4 | |
| `Hero` | Sprite Renderer, Rigidbody 2D (Dynamic, Gravity Scale 0, Freeze Rotation Z, Interpolate), Capsule Collider 2D (horizontal, at the feet), Animator (`Humanoid`), Audio Source, `Hero`, `HeroCombat`, `HeroHealth`, `Inventory`; child `Light` (Point Light 2D) | layer `Hero` |
| `Crypt Game` | `CryptGame`, two Audio Sources (sounds; music, looping, volume 0.5) | |
| `Enemies` | 5 skeletons, 3 archers, the Skeleton King | layer `Enemy`; each with its Animator: `Humanoid` through an Override Controller, or the king's own |
| `Chests`, `Doors`, `Pickups` | 5 chests, 5 doors (`Door 1`…), the loot (hidden), gold and potions | groups, so Restart finds them |
| `Torches`, `Statues and Banners` | the props | |
| `Arrows`, `Summoned`, `Summon Points` | where arrows and summoned skeletons go; the two points | |
| `Skeleton Template` | a skeleton, switched off, Sight Range 12 | the king's summon copies it |
| `Canvas`, `EventSystem` | the HUD, the boss bar, the four panels | Screen Space Overlay, 1920 × 1080, match 0.5; the Input System UI module |

## 6. The scripts

18 scripts, each with one job:

| Script | On | Does |
| --- | --- | --- |
| `Facing` | (an `enum` and a `static class`) | `Facing { Down, Left, Up, Right }`: the Animator's `Direction` numbers; `Facings.FromVector(move, current)` (keeps the current facing on an exact diagonal) and `Facings.ToVector(facing)` |
| `Hero` | `Hero` | Reads the keyboard and the pointer (hold to walk, tap to attack or open). Moves through the Rigidbody 2D. Works out the facing and sets `Direction` and `Speed` on the Animator. E opens the chest in front; Q drinks a potion. `ResetHero` |
| `HeroCombat` | `Hero` | `SetTrigger(Attack)`; `OnAttackHit()`, the Animation Event on each attack clip's hit frame, hits every enemy in a circle in front with `Physics2D.OverlapCircleAll` and a layer mask; a clang when the king turns it aside |
| `HeroHealth` | `Hero` | 6 health in half hearts; `TakeDamage(int amount, Vector2 from)`: knockback, stun, blinking, `Hurt` and `Dead` triggers; `Heal`; `OnDeathFinished()` tells the game |
| `Inventory` | `Hero` | Keys, the boss key, potions (up to 3) and gold; updates their UI; the potion slots' buttons; plays the pickups' sounds |
| `Skeleton` | each skeleton | A state machine: Idle, Patrol, Chase, Attack, Hurt, Dead. Sight through `Physics2D.Linecast`. Sets `Direction` and `Speed`; `OnAttackHit()` hurts the hero if he's in front; `ResetSkeleton()` |
| `Archer` | each archer | Idle, Keep Distance, Shoot, Reposition, Hurt, Dead. `OnAttackHit()`, on the bow's release frame, fires an `Arrow` at where the hero is |
| `Arrow` | the arrow prefab | Flies straight at feet height, its `Picture` child turned to the way it flies; hurts the hero, or breaks on anything solid |
| `SkeletonKing` | the king | Asleep, Walk, Swing, Summon, Whirlwind, Rest, Dead. `TakeHit` returns `false` when the sword can't hurt him. `OnSummon()` copies the template skeleton at each summon point; tells the boss bar his health |
| `Door` | each door | When the hero walks in with a key: `SetBool(Open, true)`. `OnDoorOpened()`, the Opening clip's last frame, turns its blocker off |
| `Chest` | each chest | `SetTrigger(Open)`; `OnLootReady()`, the Opening clip's lid-up frame, shows its loot |
| `Pickup` | keys, potions, gold | One script with `enum Kind { Key, BossKey, Potion, Gold }` and a `switch` |
| `HeartsBar` | the hearts | Three Images: full, half or empty, from `health / 2` and `health % 2` |
| `BossBar` | the boss bar | A Filled Image that slides; `Show`, `SetHealth`, `ResetBar` |
| `Room` | (plain class) | A room's name, centre and boss flag, `[System.Serializable]` |
| `RoomCamera` | `Main Camera` | Slides to the hero's room in `LateUpdate`; `SnapTo` on Restart |
| `CryptGame` | `Crypt Game` | The game's state machine: Start, Playing, Paused, Won, Lost; the rooms, the room names and messages, the music, the time; wakes the king; `Restart()` |
| `PauseMenu` | the pause panel | Resume, Restart and the volume, as in Knight Run |

## 7. Animation

### One controller for four characters

The hero, the skeleton, the archer and the king were drawn with the same animations in the
same four directions. So they share **one Animator Controller**, `Humanoid`, made for the
hero, and the skeleton and the archer get an **Animator Override Controller** each,
`Skeleton Override` and `Archer Override`, with their own clips:

| Parameter | Type | Set by |
| --- | --- | --- |
| `Direction` | Int | 0 down, 1 left, 2 up, 3 right |
| `Speed` | Float | how fast the character is moving |
| `Attack`, `Hurt`, `Dead` | Trigger | the scripts, when those happen |

```
 Base Layer
 ┌─────────┐   ┌─────────┐   ┌─────────┐   ┌─────────┐
 │  Down   │◄─►│  Left   │◄─►│   Up    │◄─►│  Right  │   four sub-state machines;
 └─────────┘   └─────────┘   └─────────┘   └─────────┘   each joined to the other three,
                                                         on Direction Equals n
 Inside each one, for example Down:

   Entry ──► Idle (default), or ──► Walk if Speed > 0.1
   Idle ◄── Speed < 0.1 / Speed > 0.1 ──► Walk
   Idle, Walk ── Attack (trigger) ──► Attack ── exit time ──► Idle
   Idle, Walk ──► Exit   when Direction ≠ 0
   Any State ──► Down/Hurt  on Hurt, if Direction = 0      Hurt ── exit time ──► Idle
   Any State ──► Down/Dead  on Dead, if Direction = 0
```

- The layer's default state is `Down/Idle`. Every transition has Transition Duration 0;
  only Attack → Idle and Hurt → Idle have Has Exit Time. Any State transitions have Can
  Transition To Self off.
- 20 clips: Idle, Walk, Attack, Hurt and Dead, in each direction. The book builds the Down
  machine state by state, then **copies and pastes it** three times and swaps the clips: the
  way a professional builds a repeated structure.
- Direction changes only from Idle and Walk: through the **Exit** node, out of one machine
  and into the one its `Direction` names. An attack or a hurt always finishes first.
- **Clips** (frames from the sheets, at these frame rates):

| Clip | Hero | Skeleton | Archer | King |
| --- | --- | --- | --- | --- |
| Idle (loop) | 5 frames, 8 fps | 6, 8 fps | 6, 8 fps | 6, 8 fps |
| Walk (loop) | 8, 12 fps | 6, 10 fps | 6, 10 fps | 10, 10 fps |
| Attack | 6, 12 fps; `OnAttackHit` at frame 2 | 8, 12 fps; frame 6 | 12, 12 fps; frame 8 (the release) | 10 at 64 px, 10 fps; frames 3 and 8 |
| Hurt | 4, 10 fps | 4, 10 fps | 4, 10 fps | 4, 10 fps |
| Dead | 5 (Up: 6), 8 fps | 8, 10 fps | 8, 10 fps | 13, 10 fps |

  Each Dead clip holds its last frame for 0.5 s, then fades the Sprite Renderer's colour to
  clear over 0.5 s, and calls `OnDeathFinished` at the end. Every key and event is on one of
  the clip's own frames, as the Animation window places them.
- **Pivots:** every 48-pixel frame's pivot is 8 pixels up, in the middle: the feet. The
  king's 64-pixel frames (Attack, Summon) have the same figure in their middle, so their
  pivot is (32, 16); his 128-pixel Whirlwind's is (64, 48).

### The king's own controller

The king has two attacks no one else has: a whirlwind spin (4 frames of 128 pixels, 12 fps,
looping) and a summoning strike with a golden ring (12 frames of 64 pixels, 10 fps,
`OnSummon` at frame 9). An Override Controller can only swap clips, not add states, so the
king gets a **copy** of `Humanoid` with his own clips, extended with two parameters and two
states at the Base Layer:

- `Whirlwind` (Bool): Any State → **Whirlwind** while it's on; Whirlwind → Exit when it's off.
- `Summon` (Trigger): Any State → **Summon**; Summon → Exit at the end of its clip.

The Base Layer's Exit starts the layer again from Entry: `Down/Idle`, then on into the
machine his `Direction` names. The book contrasts the two: override when only the pictures
change; copy when the states do.

### The others

| Animator | Parameters | States | Clips |
| --- | --- | --- | --- |
| Door | `Open` (Bool) | Closed → Opening → Open, and Open → Closed when `Open` is off | property clips on the `Left Leaf` and `Right Leaf` children's Scale X: 1, then to 0.15 over 0.5 s; `OnDoorOpened` at 0.5 s |
| Chest | `Open` (Trigger) | Closed → Opening → Open | 0x72's 3 frames, 8 fps; `OnLootReady` on the lid-up frame (0.25 s) |
| Torch | none | Flicker | a 1-second looping property clip, 30 samples, on the `Flame` child's Light 2D Intensity: 1.2, 1, 1.3, 1.1, 1.35, 1.05, 1.2 at frames 0, 6, 9, 15, 21, 24 and 30 |
| Potion, Gold | none | Idle | the sheets' own 10 and 8 frames, 10 fps |
| Key, Boss Key | none | Bob | a property clip on the `Sprite` child's Position Y: 0 to 0.1 and back, in 1 s |

## 8. The UI

```
┌───────────────────────────────────────────────────────────────────┐
│ ♥ ♥ ♡   🗝 x 2   ✦ (boss key)   ◉ 50                          [II] │
│                                                                   │
│                        The Ossuary                                │
│                                                                   │
│                     Locked: find a key                            │
│                        The Skeleton King                          │
│ [potion][potion][  ]   [██████████████░░░░░░░]                    │
└───────────────────────────────────────────────────────────────────┘
```

- **HUD** (on a 1920 × 1080 canvas; pixel art at whole multiples): three hearts at 4×
  (52 × 48), the key and its count (`x 2`), the boss key (shown only when carried), the
  gold and its count, the room name (fading in as each room starts, 64 pt), a message
  line (40 pt), the pause button, and the potion inventory: three slots (Lucifer's slot at
  2×, 96 × 96, each a Button), tapped or Q to drink. The boss bar (three strips of the
  RPG UI's bar at 6×, 456 × 36, with the king's name) shows only in the King's Tomb.
- **Panels:** Lucifer's stone panel, sliced (border 5, Pixels Per Unit Multiplier 0.5, in a
  window drawn at 2×), and its stone button, sliced (border 9, 8, 9, 8), with a **Sprite
  Swap** transition to its Highlighted and Pressed pictures; text in the RPG UI's pixel
  font, `PixelRpgFont SDF`, with a dark outline: Start ("Crypt Keys", how to play, **Play**),
  Pause (**Resume**, **Restart**, Volume), Win ("The Skeleton King has fallen!", gold, time,
  **Play Again**), Lose ("The hero has fallen", **Try Again**).

### The game's own state machine

Start → Playing ⇄ Paused; Playing → Won (the king falls) or Lost (the hero falls). As in
Knight Run, each state's enter step shows its panel and sets `Time.timeScale`, and every
button calls the same `Restart`. The music starts on **Play** (a browser plays sound only
after a click): `Crypt` in the rooms, `Fight` from the King's Tomb.

## 9. The book

Every chapter has the curriculum's beats (Goal, Idea, Do it, Test it, Challenge). The 12
shared C# Concepts are placed where the game first needs them:

| Part | Chapters and C# Concepts |
| --- | --- |
| 0 Before You Start | the game, the route, setup |
| 1 The Hero | _Naming Conventions_ · 1 The Crypt Gate (pixel art at 32 PPU, the palette, the Random Rule Tile, walls, Room 1 painted) · 2 Four Ways to Walk (top-down movement, the pointer, the facing, colliders at the feet, sorting by height, the Pixel Perfect Camera) · _The Animation Window_ · 3 Twenty Clips · _The Animator Controller_ · _Driving the Animator from Code_ · 4 One Machine per Direction (sub-state machines, Exit and Entry, copy and paste) |
| 2 Sword and Bones | _Animation Events_ · 5 The Sword (the hit frame, `OverlapCircleAll`) · _State Machines with enum and switch_ · _Enemies as State Machines_ · 6 The Skeleton (one controller for two, line of sight, Room 2 painted) · 7 Hearts and Hurt (half hearts, knockback, death) · 8 The Archer (keep distance, the release frame, cover, Room 3 painted) |
| 3 Keys, Doors and Chests | 9 Keys and Doors (the `Open` Bool, a property clip, the open frame, a Sorting Group, Room 4 painted) · 10 Chests and Potions (the loot frame, the inventory, Room 5 painted) · _Game UI_ · 11 The Screen (hearts, keys, gold, potion slots) · 12 Rooms, Pause and Restart (the room camera, the game's states, resets) |
| 4 The Skeleton King | 13 The Skeleton King (his own controller, two phases, the boss bar, Room 6 painted) · 14 Torchlight and Sound (2D lights, the flicker clip, sounds, music) |
| 5 Finish | _Reading Code_ · _Finding Errors_ · _Kinds of Classes_ · 15 Break It, Then Fix It · 16 Ship It |
| 6–7 The Exam, Check Yourself | _The User Exam_ · exam-style questions, a practice paper, the cheat sheet |

Chapters 4, 6 and 13 are the heart of the book: the hero's Animator, the enemies sharing
it, and the boss's extended copy. The shared chapters, their checker and the PDF builder
are Knight Run's (`Level3-Shared`); only `book.md` and its chapters are new.

## 10. Art and sound

Every pack is **CC0** and free (name your price). Only the files the game uses are in
`Art/` and `Audio/`, each pack's licence beside them, and `CREDITS.md` names every pack.

| What | Pack | Creator | Link |
| --- | --- | --- | --- |
| The hero: 4 directions, 48-pixel frames | Lucifer – Warrior | Foozle | foozlecc.itch.io/lucifer-warrior |
| Skeleton | Lucifer – Skeleton Grunt | Foozle | foozlecc.itch.io/lucifer-skeleton-grunt-enemy |
| Archer | Lucifer – Skeleton Hunter | Foozle | foozlecc.itch.io/lucifer-skeleton-hunter-enemy |
| Boss, with the whirlwind and the summoning strike | Lucifer – Skeleton King Boss | Foozle | foozlecc.itch.io/lucifer-skeleton-king-boss |
| Walls, floors, the arched door, torches, banners, statues, pillars, the carpet; 32-pixel tiles | Lucifer – Dungeon Tileset | Foozle | foozlecc.itch.io/lucifer-dungeon-tileset |
| Potions and gold, animated | Lucifer – Pickups | Foozle | foozlecc.itch.io/lucifer-pickups |
| Panels, buttons, the boss bar, the slot, the pixel font | Lucifer – RPG UI | Foozle | foozlecc.itch.io/lucifer-rpg-ui |
| Keys | Legend – UI Icons | Foozle | foozlecc.itch.io/legend-ui-icons |
| Chests (3-frame opening), the mimic and the floor spikes (Challenges), hearts (full, half, empty), the arrow | 16x16 DungeonTileset II | 0x72 | 0x72.itch.io/dungeontileset-ii |
| Sounds and music (`Crypt`, `Fight`) | Ninja Adventure | Pixel-Boy & AAA | pixel-boy.itch.io/ninja-adventure-asset-pack |

The packs' sheets were renamed on the way in, `<Character><Direction><Animation>.png`: the
packs' own names have typos (`SkeletonWithBowLefttIdle`) and call the skeletons' side walks
`Run`. The book uses the new names.

## 11. Shared with Knight Run (`Level3-Shared`)

The 12 C# Concept chapters, Check Yourself, `assemble.mjs`, `check-code.mjs`, the PDF builder
and `Level3BuilderKit.cs`. Crypt Keys added to the kit: `GridCells`, `SpriteCut` and
`ImportSpriteCuts` (a sheet cut into named sprites, each with its own pivot and 9-slice
border), `MakeRandomRuleTile`, `AddState` for a sub-state machine, `AddExitTransition`, and
`MakeController` now also empties sub-state machines and Entry transitions. Knight Run's
builder builds the same scene after, and its play tests pass.

## 12. The website

The second Level 3 entry in `web/levels.config.mjs`, `level-3-crypt-keys`, locked with
its own `COURSE_PW_LEVEL_3_CRYPT_KEYS` secret.

## 13. Acceptance checks

- The scene builds with no errors or warnings.
- The lab's play tests (`CryptKeysPlayTests`: 14 checks, and two passes that take pictures, of the rooms and of the cover) pass: walking through the
  sub-state machines; an attack finishing before a turn; the sword's hit frame; a
  skeleton's sword (half a heart, the hearts' sprites); a skeleton's third hit and its
  `OnDeathFinished`; an archer's arrow on its release frame; a locked door's message; a
  chest's key opening a door, and the camera sliding to the next room; a potion picked up
  and drunk; the king in both phases (`OnSummon`, the clang, the whirlwind's Exit) and the
  win; the hero's fall and the lose panel; Restart putting back every enemy, door, chest,
  pickup, the inventory, the hearts, the king and his summoned skeletons; pausing; and the
  whole crypt in order, each chest's key opening its room's door.
- `node check-code.mjs`: every script version in the book compiles at its step; every
  card matches `Scripts/`.
- The PDF is built on this Mac and looked at page by page; the website builds with the
  book published.
- Checked again on 2 October 2026, with Knight Run and Gate Guard in the same project:
  the builder's scene matches the one built in Moayad's Editor (Unity's internal ids
  aside), and the 14 checks pass.

## 14. Out of scope

Blend trees (Level 5 replaces the four sub-state machines with one 2D blend tree, which the
book mentions), inheritance for the enemies (Level 4), saving (Level 4), and procedural
rooms.

## 15. Decisions (answered on 1 October 2026)

Moayad: *"i think all is good, go a head"*, so every recommendation stands:

1. **The art and sound** in section 10.
2. **The boss's Phase 2** with his own, extended controller: the whirlwind and the summon.
3. **Every room painted step by step**, each in the chapter that first needs it.
4. **The Pixel Perfect Camera**, and a 1280 × 720 itch.io viewport.
5. **Torchlight** with 2D lights.
6. **The mimic and the spike traps** as Challenges.

Made while building, within those answers: the rooms are stacked (the arched door only
faces the camera, so every door is in a top wall); a room is 19 tiles wide, so the door is
in its middle column; the king's whirlwind moves at 3, a little slower than the hero, so he
can get away.
