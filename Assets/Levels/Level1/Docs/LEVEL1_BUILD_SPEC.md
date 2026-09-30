# Catch the Falling Blocks — Level 1 Build Spec

Spec for the **Level 1** project of the Unity Programmer Curriculum. Hand it to Claude in VS Code for checks or changes. It describes the Level 1 code limits, the scene, and how to verify the result.

The student book (`Docs/Level1-CatchTheBlocks-Workbook.pdf`, source `Docs~/workbook/workbook.md`) is already written. **The project must match the book exactly**: same script names, same code, same object names, same numbers.

---

## 1. Context

- **Audience:** students who passed the Level 1 entry test (everything in Level 0).
- **Level 1 purpose:** the first real game. Keyboard control, Rigidbody 2D physics, triggers, prefabs, arrays and loops, enums and `switch`, a TextMeshPro UI with a button, sound, and a Web build.
- **Engine:** Unity 6 (6000.6), **Universal 2D** template (URP 2D Renderer), **Input System package only** (`activeInputHandler: 1`).
- **Location:** `Assets/Levels/Level1/` in `~/apptrainers/unity-programmer-curriculum-levels`:

```
Assets/Levels/Level1/
├── README.md
├── Curriculum.Level1.asmdef          runtime assembly (not auto-referenced)
├── Scripts/            PlayerController.cs, Spawner.cs, GameManager.cs, Floor.cs
├── Editor/             CatchSceneBuilder.cs + Curriculum.Level1.Editor.asmdef
├── Audio/              Catch.wav, Gold.wav, Miss.wav, GameOver.wav
├── Prefabs/            Block, GoldBlock, BadBlock          (created by the builder)
├── Scenes/             Catch.unity                        (created by the builder)
├── Sprites/            Square.png                         (created by the builder)
├── Docs/               workbook PDF, entry test PDFs, this spec
├── Docs~/workbook/     workbook.md + PDF builder          (ignored by Unity)
└── Docs~/entry-test/   test.md, answer-key.md, Elevator.cs (model solution)
```

## 2. Hard rules (Level 1 limits)

The four student scripts may use **only** Level 0 and Level 1 topics. Don't "improve" them beyond these limits, even where a more advanced approach is better practice.

**Allowed (new in Level 1):** `[SerializeField]` private fields; `public` methods; references to other scripts set in the Inspector; arrays (`T[]`, `.Length`, indexing); `for`, `foreach` (including over a `Transform`'s children), `while`, `break`, `continue`; a nested `enum` and `switch` (on the enum and on strings); the ternary `?:`; string interpolation `$"…"`, `\n`, and number formats such as `{x:F1}`; `Keyboard.current.<key>.isPressed` / `.wasPressedThisFrame`; `new Vector3(x, y, z)`; `Random.Range`; `Instantiate(prefab, position, Quaternion.identity, parent)`; `Destroy`; `OnTriggerEnter2D(Collider2D other)`, `other.tag`, `other.gameObject`; `GameObject.SetActive`; `TMP_Text.text`; `AudioSource.PlayOneShot`.

**Not allowed:** `GetComponent` / `FindObjectOfType` and similar; `static` members; `List<T>` / `Dictionary`; coroutines; properties; events, delegates or lambdas; `var`; inheritance beyond `MonoBehaviour`, and interfaces; `Mathf`; `Vector2` / vector maths; the older `Input` class; `PlayerPrefs`; `SceneManager`; physics code that sets velocity or adds forces (physics is configured in the Inspector).

**Style:** as Level 0: 4-space indentation, Allman braces, braces on every `if` / `else`, private fields without the `private` keyword, and the comments as written.

## 3. The scripts (source of truth)

`Scripts/PlayerController.cs`, `Scripts/Spawner.cs`, `Scripts/GameManager.cs` and `Scripts/Floor.cs` are the source of truth. The book's `csharp:FileName.cs` code cards are byte-for-byte copies (checked in section 6). The book also shows earlier versions of `PlayerController`, `Spawner` and `GameManager` in Chapters 2, 5, 6 and 8: each must compile at its chapter, when a student follows the book.

| Script | On | Does |
| --- | --- | --- |
| `PlayerController` | `Player` | Arrow keys / A-D movement at `moveSpeed`, clamped to ±`edge`; `OnTriggerEnter2D` → `gameManager.BlockCaught(other.tag)`, destroys the block |
| `Floor` | `Floor` | `OnTriggerEnter2D` → `gameManager.BlockMissed(other.tag)`, destroys the block |
| `Spawner` | `Spawner` | While playing: drops a random prefab from `blockPrefabs` at a random x, as a child; delay shrinks by `speedUp` down to `shortestDelay`. `Restart()`, `ClearBlocks()` |
| `GameManager` | `GameManager` | `enum GameState { Ready, Playing, GameOver }`; score, lives, best score, time survived; `StartGame()` (button and Space), `IsPlaying()`, `BlockCaught()`, `BlockMissed()`; `UpdateScreen()`; sounds |

Rules: red block +1, gold +5, bad block caught −1 life; missing red or gold −1 life, missing bad costs nothing. 3 lives.

## 4. The scene

`Assets/Levels/Level1/Scenes/Catch.unity`, created by **Tools → Catch the Falling Blocks (Level 1) → Build Scene** (`Editor/CatchSceneBuilder.cs`). The builder also adds the tags `Block`, `GoldBlock`, `BadBlock`, generates `Sprites/Square.png` (white, 1 unit), creates the three prefabs, and adds the scene to Build Settings. It needs the **TMP Essential Resources**; if they're missing, it opens the Import Unity Package window (click **Import**) and asks you to run it again.

### World objects

| Object | Position | Scale | Components | Notes |
| --- | --- | --- | --- | --- |
| `Main Camera` | (0, 0, -10) | 1 | Camera: orthographic, Size `6`, Solid Color `#1E1A33` | shows y −6 to 6 |
| `Global Light 2D` | (0, 0, 0) | 1 | Light 2D (Global) | |
| `Player` | (0, -4.5, 0) | (2.4, 0.4, 1) | Sprite `#3DDCC8`, Box Collider 2D (solid), `PlayerController` | tag `Player` |
| `Floor` | (0, -7.5, 0) | (30, 1, 1) | Box Collider 2D (solid), `Floor` | invisible |
| `Spawner` | (0, 0, 0) | 1 | `Spawner` | blocks spawn as its children at y = 7 |
| `GameManager` | (0, 0, 0) | 1 | `GameManager`, Audio Source (Play On Awake off) | |

### Prefabs (`Prefabs/`)

| Prefab | Tag | Colour | Scale | Order in Layer | Box Collider 2D | Rigidbody 2D |
| --- | --- | --- | --- | --- | --- | --- |
| `Block` | `Block` | `#FF4D6D` | (0.6, 0.6, 1) | 1 | Is Trigger | Gravity Scale `0.5`, Linear Damping `1` |
| `GoldBlock` | `GoldBlock` | `#FFD166` | (0.6, 0.6, 1) | 1 | Is Trigger | Gravity Scale `0.9`, Linear Damping `1` |
| `BadBlock` | `BadBlock` | `#9B5DE5` | (0.6, 0.6, 1) | 1 | Is Trigger | Gravity Scale `0.35`, Linear Damping `1` |

`Spawner.blockPrefabs` = `Block` ×4, `GoldBlock`, `BadBlock` ×2 (7 elements).

### UI

Canvas (Screen Space Overlay; Canvas Scaler: Scale With Screen Size, 1920 × 1080, Match 0.5) and an EventSystem with **Input System UI Input Module**.

| Object | Anchor | Pos | Size | Details |
| --- | --- | --- | --- | --- |
| `ScoreText` | top-left | (40, −30) | 600 × 100 | TMP, 56, top-left aligned, `#F5F3FF` |
| `MessageText` | middle-center | (0, 140) | 1600 × 360 | TMP, 64, centred, `#F5F3FF` |
| `PlayButton` | middle-center | (0, −140) | 320 × 110 | Image `#3DDCC8`; child TMP "Play", 56, `#1E1A33`; On Click → `GameManager.StartGame` |
| `LifeIcon1`–`3` | top-right | (−180, −40), (−110, −40), (−40, −40) | 50 × 50 | Image `#FF4D6D` |

`GameManager` references: `spawner`, `scoreText`, `messageText`, `playButton`, `lifeIcons` (LifeIcon1, 2, 3 in order), `audioSource`, and the four clips from `Audio/`.

## 5. Workbook and site

- `Docs~/workbook/workbook.md` is the book source, and also the source of the Level 1 pages on the course site (`web/`). It follows the site's heading conventions (`# Part N — …`, `## Chapter N — …`, `## C# N — …`); the site's `npm run import` produces 22 pages for it.
- Level 1 is in `web/levels.config.mjs` with `published: false`. Publishing needs the `COURSE_PW_LEVEL_1` secret first (it's already passed in `.github/workflows/deploy.yml`).

## 6. Acceptance checks

Do all of these and report the results.

1. **Compiles clean:** after import, the Console shows **0 errors and 0 warnings** from Level 1 files.
2. **Scene builds:** **Tools → Catch the Falling Blocks (Level 1) → Build Scene** creates the scene, prefabs and tags; the Game view shows the title message, the Play button and three red life icons over the navy background.
3. **Code cards match:** the check in `README.md` prints `MATCH` for `PlayerController.cs`, `Floor.cs`, `Spawner.cs`, `GameManager.cs` and `Elevator.cs`.
4. **Play test:**
   - Before starting: no blocks fall. Space **or** clicking Play starts the game; the message and button disappear.
   - Arrow keys and A / D move the bar; it stops at x = ±8.3.
   - Catching red: +1 and the catch sound. Gold: +5 and the gold sound. Bad: one life icon disappears (from the right) and the miss sound.
   - Missing red or gold: one life lost. Missing bad: nothing.
   - Blocks arrive faster over time.
   - At 0 lives: every block disappears, the game-over sound plays, and the screen shows `Game Over`, then `New best score: N!` (or `Score: N   Best: M`) and `You lasted X.X seconds`. The Play button returns, and a new game starts from 0 points and 3 lives.
5. **Build:** a Web build (Compression Format: Disabled) runs in a browser.

## 7. Out of scope

- No `GetComponent`, coroutines, animation, touch, scene loading or saving. Those arrive in Levels 2–4.
- Don't change the book text. If something in the project can't match it (a menu name differs in your Unity version, say), note it in your report instead.
