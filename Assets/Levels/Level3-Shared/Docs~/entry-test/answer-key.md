---
title: "Level 3 Entry Test: Answer Key"
subtitle: "Trainer only"
author: "Unity Programmer Curriculum  ·  Level 3 Entry Test  ·  Trainer Only"
coverEyebrow: "Trainer Only · Do Not Share With Students"
coverTop: "Answer Key"
coverRed: "Level 3 Entry Test"
coverSub: "Answers, marking guidance, the practical rubric and a model solution, plus what to do with each result."
coverPill: "Trainer Only"
coverCaption: "Keep this file away from students and out of shared folders"
coverArt: code
coverCode: level2
keepCode: true
footer: "Level 3 Entry Test  ·  Answer Key  ·  Trainer Only"
---

## Section 1 — Running the Test

**Goal:** run the test the same way for every student, so results are fair and
comparable.

### Before the test

- Print the student paper as two sets: **Sections 1–2**, the cover and pages 1–11
  (PDF pages 1–12), and **Section 3**, pages 12–14 (PDF pages 13–15). A print dialog
  counts the cover as page 1, so use the PDF page numbers there.
- Print the **Level 2 cheat sheet** too, from any Level 2 book (it's the same in all
  three): Mini Golf's pages 155–156 (PDF pages 156–157), Space Shooter's 170–171
  (PDF 171–172), or Tank Arena's 184–185 (PDF 185–186). One of each per student.
- Check each lab machine has **Unity 6** with the **Universal 2D** template, and a code
  editor connected to Unity. On each machine, create an empty project from the
  **Universal 2D** template, named after the student, so nobody spends the practical
  making one or opens an old project.
- Students work alone, with no internet, AI tools or earlier projects. Turn off AI
  code completion (GitHub Copilot, Rider AI, Unity AI) on every machine.

### On the day

| Part | Time | Notes |
| --- | --- | --- |
| Written paper | 40 minutes | Closed book: hand out Sections 1–2 only, with no cheat sheet on the desks. Collect them when time is up. |
| Break | 10 minutes | |
| Practical task | 90 minutes | Hand out Section 3 and the cheat sheet now. At the end, students leave Unity open with the scene saved. |

### Marking the practical

For each student, in this order:

1. Open their scene, check the Console for errors, and press **Play**. During wave 1,
   blast a few meteors with the mouse, keeping a tally of each size you blast, and
   let one land: the lives go down by one. Watch `Info Text` change.
2. During the next wave (if wave 2 never starts, do this in wave 1), click
   **Settings**: everything stops, the meteors and the new arrivals too. Click a
   meteor (it's behind the panel): nothing is blasted. Move the slider to the far
   right (2), then click **Close**: the meteors fall twice as fast.
3. Let meteors land until the last life is lost: the sky clears, and `End Text`
   shows `The city has fallen`, the score and the counts. Check the counts against
   your tally. Wait 5 seconds: no new meteor appears, so the waves have stopped.
4. Stop. On `Game`, set the wave sizes to `2` and `3` in the Inspector. Switch the Game
   view to the **Simulator** (the **Game** dropdown at the top left of the Game view),
   pick any phone, click **Rotate** to turn it sideways, and press **Play**. Blast
   every meteor with a tap, a click inside the Simulator: after the second wave,
   `The city is safe!`.
5. Read both scripts, and the three prefabs' **Speed**, and mark them against the
   rubric in Section 3.

> **Note:** if a setup or Inspector mistake stops a working script (an empty field,
> **Meteor Mask** left at **Nothing**, a prefab missing from **Meteor Prefabs**), fix
> it, play again, and count one fault in the row it broke.

## Section 2 — Written Paper Answers

**Goal:** mark each question 1 or 0. Accept any answer that shows the same
understanding in different words.

| Q | Answer | Accept / notes | Level 2 chapter |
| --- | --- | --- | --- |
| 1 | Line 4: `Coins` has a `private set`, so only `Wallet`'s own code can change it | Line and reason both needed. Unity's error is CS0272: *the set accessor is inaccessible*. Lines 1 to 3 are fine: with no constructor of its own, `new Wallet()` works. | Properties and Constructors |
| 2 | `Soup x6, Rice x2`; and `public Order(string dish) { Dish = dish; Count = 1; }` | Both needed. The constructor has the class's name and no return type, and sets both properties. Accept it without `public`, with `this.Dish = dish;`, and with the braces on their own lines. Not `void Order(…)`: that's a method. | Properties and Constructors |
| 3 | 1 C, 2 B, 3 D, 4 A | All four needed. E is left over: with `public`, any script could change the jump height. | static, const and readonly |
| 4 | `C: 5 points`, `B: Hi 3`, `A: Hi` | All three. `Show(5)` matches only `Show(int, string)`, with the default `"points"`. | Methods in Depth |
| 5 | `Not a number: 7b`, then `22` | Both lines, in that order. `"-3"` is a number: 25 + (−3) = 22. | Methods in Depth, Numbers and Conversions |
| 6 | `4`, `4.5`, `-4`, `40` | All four. A cast to `int` cuts off towards zero, so −4.7 becomes −4, not −5; `(float)found` makes the division a decimal one. | Numbers and Conversions |
| 7 | `6`, `-3`, `3`, `0` | All four. 6.5 is exactly halfway, so `RoundToInt` goes to the even number, 6. `FloorToInt` always goes down: −3. | Numbers and Conversions |
| 8 | array; `List`; `Dictionary` | All three. | Lists, Dictionaries |
| 9 | `3 Eve -1` | {Ana, Ben, Cy, Dee}, then {Ana, Cy, Dee}, {Ana, Eve, Cy, Dee} and {Eve, Cy, Dee}. Ben isn't there any more, so `IndexOf` gives −1. | Lists |
| 10 | `7 2`, then `No plums`; a `KeyNotFoundException`: there's no key `"Plum"`, and the code stops | Both parts. Accept "an error, because the key isn't there". | Dictionaries |
| 11 | `Awake`, `OnEnable`, `Start`, `Update`, `OnDisable` | All five, in this order. The order the methods are written in doesn't matter. `enabled = false;` calls `OnDisable` at once, and `Update` stops. | Event Functions |
| 12 | Line C: `GetComponent` found no Rigidbody 2D in `Awake`, so `body` is `null`, and line C uses it | Line and reason. In the Editor the error is a `MissingComponentException`: *There is no 'Rigidbody2D' attached to the "Crate" game object*; accept `NullReferenceException`. Line A gives back `null` with no error; line B returns `false`. | Components and GetComponent, null and Debugging |
| 13 | `(6, 8, 0)`; `10`; `(0.6, 0.8, 0)` | All three. Accept Unity's `(6.00, 8.00, 0.00)`. 6, 8 and 10 are the 3, 4, 5 triangle twice over. | Vectors |
| 14 | `On`, `Started`, `Off`, `Stopped` | All four, in order, and no `On again`: at 1.5 seconds `StopCoroutine` stops the coroutine, half a second before it would print `On again`. `StartCoroutine` runs it up to its first `yield` straight away, so `On` comes before `Started`. | Coroutines and Timers |
| 15 | a) no; b) yes; c) no; d) yes | All four. At 0, game time stops: `WaitForSeconds` waits, and physics stops. `WaitForSecondsRealtime` counts real seconds, and the UI doesn't use game time, so it keeps working. | Coroutines and Timers, and each book's settings chapter |
| 16 | B; the Device Simulator | Both. Accept the Game view's **Simulator**, **Window → General → Device Simulator**, or the Input Debugger's **Simulate Touch Input From Mouse or Pen**. A is the mouse only; C and D are "held". | Mouse and Touch |
| 17 | `false`; `null` | Both. The box is on Default, not on the mask, and nothing on Ground is in reach. | Raycasts |
| 18 | `float`, `bool`, `string`, `int` | All four. | UI Events |
| 19 | a) `Fire`, called by `Update`; b) `ammoText`: hover over it at the breakpoint, or find it in the **Variables** panel, and it shows `null` | Both parts. `Fire` and `Update` are needed, not only the line numbers. An `int` can't be `null`, so it must be `ammoText`. | null and Debugging |
| 20 | `Collider2D nearby = Physics2D.OverlapCircle(transform.position, 2f, meteorMask);` | Accept `2` for `2f` (an `int` becomes a `float` by itself), and `meteorMask.value`. The arguments in this order, and on `Physics2D`, not `Physics`. | Reading the Unity Docs |

**Pass mark:** 14 out of 20.

> **Tip:** note which questions each student missed. The last column says which
> Level 2 chapter to send them back to: it has the same title in all three Level 2
> books.

## Section 3 — Practical Task Rubric

**Goal:** mark Meteor Defence out of 100, giving partial credit where a requirement is
partly met.

| Requirement | Full marks | Partial credit | Zero |
| --- | --- | --- | --- |
| **Scripts** (10) | `Meteor.cs` and `MeteorGame.cs` with matching classes, on the three prefabs and on `Game`, no compile errors | 5: compiles, but misnamed or attached elsewhere | Doesn't compile |
| **Falling** (15) | A direction made with `.normalized` (or `Vector3.MoveTowards`), moved by the speed × the speed setting × `Time.deltaTime`; the speed a `[SerializeField]` field set on each prefab (3, 2, 1.2); a random target with `x` from −8 to 8 at `y` −4.2; reaching it costs one life and removes the meteor | 8: meteors fall, but straight down, or not per second, or all at one speed, or landing doesn't cost a life or leaves the meteor there | Nothing falls |
| **Waves** (15) | One coroutine (`IEnumerator`, `StartCoroutine`) with `WaitForSeconds(0.7f)` between meteors and 2 seconds between waves; the wave sizes an Inspector array, used everywhere (`2` and `3` work); a `List` that meteors join when made and leave when blasted or landed; the next wave only when the list is empty | 8: waves come, but from a timer in `Update`, or the wave sizes are fixed in the code, or a wave doesn't wait for the sky to clear, or the list keeps destroyed meteors | No waves |
| **Blasting** (15) | `Pointer.current` checked for `null`, and `press.wasPressedThisFrame`; `ScreenToWorldPoint`; `Physics2D.OverlapPoint` (or `Physics2D.Raycast`) with the `LayerMask` field; `TryGetComponent` (or `GetComponent` and a `null` check); a tap in the Simulator works too | 8: blasting works, but with `Mouse.current` only (no taps), or without the layer mask, or without the `Pointer.current` null check | No blasting |
| **Score** (15) | A `Dictionary` with each size's points; `Score` a property with a public `get` and a `private set`; the starting 3 lives a `const`; `Wave 2   Score: 340   Lives: 2`, kept up to date | 8: one of these missing: points from `if`s or a `switch`, a public field instead of the property, a plain field instead of the `const`, or the text not updated | No score |
| **Settings** (10) | The buttons and the slider connected with `AddListener` (method names, no brackets); opening sets `Time.timeScale` to 0, closing back to 1; the slider changes every meteor's speed at once; nothing is blasted while paused | 5: works, but connected in the Inspector, or only new meteors get the new speed, or a press on the panel blasts a meteor | No settings |
| **The end** (10) | `StopCoroutine` with the `Coroutine` kept from `StartCoroutine` (or `StopAllCoroutines`); every meteor in the list destroyed, and the list emptied; both messages; the counts from a second `Dictionary` (a `foreach` over it is fine), on three lines | 5: the game ends, but the waves keep coming after a loss, or the sky isn't cleared, or the counts aren't from a dictionary | Never ends |
| **Readability** (10) | camelCase fields, PascalCase methods and properties, consistent indentation, at least three useful comments; Inspector fields are `[SerializeField]`, not `public`; each piece of code in the right event function (input read in `Update`; listeners added in `OnEnable` and removed in `OnDisable`) | 5: mostly readable, few or weak comments, `public` fields, or code in the wrong event function | Unreadable |

**A fault** is one Full-marks item missing or wrong, counted only in the row that lists
it. **Two or more faults in one row:** 4 in a 15-mark row, 2 in a 10-mark row.

**If the project doesn't compile**, don't fix it: give 0 for Scripts, and mark the
other rows from the code alone, with at most the partial mark in each.

**Pass mark:** 70 out of 100.

> **Note:** `Destroy` doesn't take a meteor out of the list (Level 2's Lists chapter).
> A student who forgets `Remove` gets a wave that never ends: that's the Waves row's
> partial credit, not a zero.

### What a working game looks like

- Meteors appear just above the screen, one every 0.7 seconds, and fall in straight
  lines to the city: the small ones fast, the large ones slowly.
- `Wave 1   Score: 0   Lives: 3` at the start. A small meteor blasted adds 50; a
  landing takes away a life.
- After 6 meteors, and a 2-second break once the sky is clear, wave 2 brings 9, and
  wave 3 brings 12.
- With the settings open, nothing moves or appears, and clicks blast nothing.
- At the end, the sky clears, and `End Text` reads, for example, `The city has
  fallen`, `Score: 340` and `Small: 4   Medium: 5   Large: 4`.

## Section 4 — Model Solution

**Goal:** a reference answer written only with Level 2 C#. Students' solutions can
look different and still earn full marks.

In the Inspector:

- each prefab's `Meteor` has its **Size** and **Speed**: `Small` and 3, `Medium` and
  2, `Large` and 1.2;
- on `Game`, **Meteor Prefabs** holds the three prefabs, **Meteor Mask** is `Meteor`
  only, and **Info Text**, **End Text**, **Settings Panel**, **Settings Button**,
  **Close Button** and **Speed Slider** are the UI's parts.

The prefabs are `GameObject`s, and `GetComponent` finds each new meteor's script, as in
the Level 2 books.

```csharp:Meteor.cs
using UnityEngine;

// The three sizes of meteor. Each one has its own prefab.
public enum MeteorSize
{
    Small,
    Medium,
    Large
}

// Model answer for the Level 3 entry test practical task.
// One meteor: it flies in a straight line at a point on the city, and tells
// the game when it lands.
public class Meteor : MonoBehaviour
{
    [SerializeField] MeteorSize size = MeteorSize.Small;
    [SerializeField] float speed = 3f;      // units per second, at speed setting 1

    MeteorGame game;
    Vector3 target;
    Vector3 direction;

    // Other scripts can read the size, but not change it
    public MeteorSize Size
    {
        get { return size; }
    }

    // The game calls this as soon as it makes the meteor
    public void Launch(MeteorGame owner, Vector3 landingPoint)
    {
        game = owner;
        target = landingPoint;
        direction = (target - transform.position).normalized;
    }

    void Update()
    {
        transform.position += direction * speed * game.SpeedSetting * Time.deltaTime;

        // It has reached the top edge of the city
        if (transform.position.y <= target.y)
        {
            game.Landed(this);
        }
    }
}
```

```csharp:MeteorGame.cs
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

// Model answer for the Level 3 entry test practical task.
// Sends waves of meteors at the city, blasts the one under the pointer, keeps
// the score and the lives, and shows how the game ended.
public class MeteorGame : MonoBehaviour
{
    const int StartLives = 3;

    // ---- Settings ----
    [SerializeField] GameObject[] meteorPrefabs;        // Small, Medium and Large Meteor
    [SerializeField] LayerMask meteorMask;              // only the Meteor layer
    [SerializeField] int[] waveSizes = { 6, 9, 12 };    // how many meteors in each wave
    [SerializeField] float spawnDelay = 0.7f;           // seconds between two meteors
    [SerializeField] float waveBreak = 2f;              // seconds between two waves
    [SerializeField] float edgeX = 8f;                  // meteors start and land between -8 and 8
    [SerializeField] float startY = 5.5f;               // just above the screen
    [SerializeField] float cityY = -4.2f;               // the top edge of the city

    // ---- The UI ----
    [SerializeField] TMP_Text infoText;
    [SerializeField] TMP_Text endText;
    [SerializeField] GameObject settingsPanel;
    [SerializeField] Button settingsButton;
    [SerializeField] Button closeButton;
    [SerializeField] Slider speedSlider;

    // The points for blasting each size, and how many of each were blasted
    readonly Dictionary<MeteorSize, int> points = new Dictionary<MeteorSize, int>
    {
        { MeteorSize.Small, 50 },
        { MeteorSize.Medium, 20 },
        { MeteorSize.Large, 10 },
    };
    readonly Dictionary<MeteorSize, int> blasted = new Dictionary<MeteorSize, int>
    {
        { MeteorSize.Small, 0 },
        { MeteorSize.Medium, 0 },
        { MeteorSize.Large, 0 },
    };

    // The meteors in the sky right now
    readonly List<Meteor> meteors = new List<Meteor>();

    Coroutine waves;
    int lives = StartLives;
    int wave = 0;
    bool isOver = false;

    // Every script can read these; only this one changes them
    public int Score { get; private set; }
    public float SpeedSetting { get; private set; } = 1f;

    void OnEnable()
    {
        settingsButton.onClick.AddListener(OpenSettings);
        closeButton.onClick.AddListener(CloseSettings);
        speedSlider.onValueChanged.AddListener(OnSpeedChanged);
    }

    void OnDisable()
    {
        settingsButton.onClick.RemoveListener(OpenSettings);
        closeButton.onClick.RemoveListener(CloseSettings);
        speedSlider.onValueChanged.RemoveListener(OnSpeedChanged);
    }

    void Start()
    {
        endText.text = "";
        waves = StartCoroutine(RunWaves());
    }

    void Update()
    {
        Pointer pointer = Pointer.current;
        if (pointer == null || !pointer.press.wasPressedThisFrame)
        {
            return;
        }

        // Nothing is blasted after the end, or while the game is paused
        if (isOver || Time.timeScale == 0f)
        {
            return;
        }

        Vector2 world = Camera.main.ScreenToWorldPoint(pointer.position.ReadValue());
        Collider2D found = Physics2D.OverlapPoint(world, meteorMask);
        if (found != null && found.TryGetComponent(out Meteor meteor))
        {
            Blast(meteor);
        }
    }

    // The waves, one after another
    IEnumerator RunWaves()
    {
        for (int i = 0; i < waveSizes.Length; i++)
        {
            wave = i + 1;
            UpdateText();

            for (int n = 0; n < waveSizes[i]; n++)
            {
                SpawnMeteor();
                yield return new WaitForSeconds(spawnDelay);
            }

            // The wave is over when the sky is empty
            while (meteors.Count > 0)
            {
                yield return null;
            }

            if (i < waveSizes.Length - 1)
            {
                yield return new WaitForSeconds(waveBreak);
            }
        }

        EndGame("The city is safe!");
    }

    // A random meteor, just above the screen, aimed at a random point on the city
    void SpawnMeteor()
    {
        GameObject prefab = meteorPrefabs[Random.Range(0, meteorPrefabs.Length)];
        Vector3 start = new Vector3(Random.Range(-edgeX, edgeX), startY, 0f);
        Vector3 landing = new Vector3(Random.Range(-edgeX, edgeX), cityY, 0f);

        GameObject copy = Instantiate(prefab, start, Quaternion.identity, transform);
        Meteor meteor = copy.GetComponent<Meteor>();
        meteor.Launch(this, landing);
        meteors.Add(meteor);
    }

    void Blast(Meteor meteor)
    {
        Score += points[meteor.Size];
        blasted[meteor.Size]++;
        RemoveMeteor(meteor);
        UpdateText();
    }

    // A meteor calls this when it reaches the city
    public void Landed(Meteor meteor)
    {
        if (isOver)
        {
            return;
        }

        RemoveMeteor(meteor);
        lives--;
        UpdateText();

        if (lives <= 0)
        {
            StopCoroutine(waves);
            EndGame("The city has fallen");
        }
    }

    void RemoveMeteor(Meteor meteor)
    {
        meteors.Remove(meteor);
        Destroy(meteor.gameObject);
    }

    // The end, either way: clear the sky and show the result
    void EndGame(string message)
    {
        isOver = true;

        foreach (Meteor meteor in meteors)
        {
            Destroy(meteor.gameObject);
        }
        meteors.Clear();

        endText.text = $"{message}\nScore: {Score}\n" +
            $"Small: {blasted[MeteorSize.Small]}   Medium: {blasted[MeteorSize.Medium]}   Large: {blasted[MeteorSize.Large]}";
    }

    // The settings panel pauses the game while it's open
    void OpenSettings()
    {
        settingsPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    void CloseSettings()
    {
        settingsPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    void OnSpeedChanged(float value)
    {
        SpeedSetting = value;
    }

    void UpdateText()
    {
        infoText.text = $"Wave {wave}   Score: {Score}   Lives: {lives}";
    }
}
```

## Section 5 — Results and Next Steps

**Goal:** turn each result into a clear next step for the student.

| Result | Written | Practical | Next step |
| --- | --- | --- | --- |
| **Pass** | 14 or more | 70 or more | Start **Level 3**. |
| **Nearly there** | 11–13 | 70 or more | Review the chapters listed for the missed questions, then retake the **written paper** only. |
| **Nearly there** | 14 or more | 50–69 | Rebuild a Level 2 game's spawner and settings panel from memory, then retake the **practical** only. |
| **Not yet** | anything else | | Repeat **Level 2** with one of its books, focusing on the chapters from the written paper. |

A student who takes the test **without** doing Level 2 (to skip it) and doesn't pass
starts at **Level 2**, with any of its three books, beginning at the first chapter
linked to a missed question.

### Retakes

Allow at least a few days between attempts, so students review rather than
memorise. For a retake, change the numbers so the answers change:

| Question | Change | New answer |
| --- | --- | --- |
| Q1 | line 2 becomes `wallet.Coins += 5;`, line 3 `wallet.Earn(20);`, line 4 `Debug.Log(wallet.Coins);` | Line 2 |
| Q2 | `Count = count + 1;`; the second constructor takes only the count, with the dish `"Water"` | `Soup x4, Rice x2`; `public Order(int count) { Dish = "Water"; Count = count; }` |
| Q3, Q16 | reorder the options | the same answers, under their new letters |
| Q8, Q15, Q18 | reorder the items | the same answers, in the new order |
| Q4 | the calls `Show(8, "stars");`, `Show("Go");` and `Show("Go", 2);` | `C: 8 stars`, `A: Go`, `B: Go 2` |
| Q5 | `{ "40", "x9", "15" }` | `Not a number: x9`, then `55` |
| Q6 | `11 / 4`, `11 / 4f`, `(int)-2.9f`, and `found = 3`, `total = 4` | `2`, `2.75`, `-2`, `75` |
| Q7 | `RoundToInt(4.5f)`, `FloorToInt(-1.5f)`, `CeilToInt(7.01f)`, `Clamp(15, 0, 10)` | `4`, `-2`, `8`, `10` |
| Q9 | `Remove("Cy")`, `Insert(0, "Eve")`, `RemoveAt(1)`, and `IndexOf("Dee")` | `3 Eve 2` |
| Q10 | `stock["Apple"] = 5;`, `stock["Plum"] = 2;`, `stock["Plum"] = stock["Plum"] * 3;`; the first `Debug.Log` shows `stock["Plum"]`; the extra line reads `stock["Pear"]` | `6 2`, then `Plums: 6`; a `KeyNotFoundException` |
| Q11 | the `Lamp` component starts unticked | `Awake` only |
| Q12 | line C goes inside `if (body != null) { … }` | none: line A gives back `null`, line B returns `false`, and line C checks for `null` first |
| Q13 | the drone at `(1, 4, 0)`, the target at `(4, 0, 0)` | `(3, -4, 0)`, `5`, `(0.6, -0.8, 0)` |
| Q14 | `Time.time > 2.5f` | `On`, `Started`, `Off`, `On again`, `Stopped` |
| Q17 | the box is on the `Ground` layer | `true`; the box's collider |
| Q19 | the trace's lines are `Basket.Catch (System.Int32 points) (at Assets/Scripts/Basket.cs:31)` and `Basket.OnTriggerEnter2D (UnityEngine.Collider2D other) (at Assets/Scripts/Basket.cs:18)`; line 31 is `scoreText.text = "Score: " + score;`, and `score` is an `int` | `Catch`, called by `OnTriggerEnter2D`; `scoreText` |
| Q20 | within 3 units, on `wallMask`, stored in `wall` | `Collider2D wall = Physics2D.OverlapCircle(transform.position, 3f, wallMask);` |
| Practical | three waves of 5, 8 and 10, a meteor every 0.6 seconds, a 3-second break, points of 40, 25 and 10, and 4 lives; change every number in the paper's Section 3, and in this key's Sections 1 and 3, to match | the end example becomes `Score: 325`; the same rubric |
