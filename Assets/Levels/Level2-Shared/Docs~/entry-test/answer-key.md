---
title: "Level 2 Entry Test: Answer Key"
subtitle: "Trainer only"
author: "Unity Programmer Curriculum  ·  Level 2 Entry Test  ·  Trainer Only"
coverEyebrow: "Trainer Only · Do Not Share With Students"
coverTop: "Answer Key"
coverRed: "Level 2 Entry Test"
coverSub: "Answers, marking guidance, the practical rubric and a model solution, plus what to do with each result."
coverPill: "Trainer Only"
coverCaption: "Keep this file away from students and out of shared folders"
coverArt: code
coverCode: level1
footer: "Level 2 Entry Test  ·  Answer Key  ·  Trainer Only"
---

## Section 1 — Running the Test

**Goal:** run the test the same way for every student, so results are fair and
comparable.

### Before the test

- Print the student paper as two sets, **Sections 1–2** (the cover and pages 1–7)
  and **Section 3** (page 8 to the end), and the **Level 1 cheat sheet** (the last
  pages of the Level 1 book), one of each per student.
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
| Practical task | 75 minutes | Hand out Section 3 and the cheat sheet now. At the end, students leave Unity open with the scene saved. |

### Marking the practical

For each student, in this order:

1. Open their scene, check the Console for errors, and press **Play**. Play for the
   whole 30 seconds: move in all four directions with the arrow keys, then with
   W A S D, catch fireflies and a moth or two, and watch the text. Catch a moth while the score is 0 or 1: it must stay
   at 0.
2. Stop, set the game's length to `10` in the Inspector, and press **Play** again.
   The game must end after 10 seconds, clear the sky, and show a rank.
3. Read both scripts and mark them against the rubric in Section 3.

> **Note:** if insects can only be caught in their first half-second, the prefabs'
> **Sleeping Mode** isn't **Never Sleep** (setup step 4). Set it on both prefabs,
> play again, and mark Catching on what you see then.

## Section 2 — Written Paper Answers

**Goal:** mark each question 1 or 0. Accept any answer that shows the same
understanding in different words.

| Q | Answer | Accept / notes | Level 1 chapter |
| --- | --- | --- | --- |
| 1 | A | The coin's Rigidbody 2D is enough: at least one of the two needs one, and the trigger reports the touch to both. Not B: Unity calls it on the scripts of both objects. Not D: a trigger stops nothing, so the coin falls on through the player. | Chapters 3, 7 |
| 2 | No trigger; `OnCollisionEnter2D` | Both parts needed. A trigger would let the ball pass through. Not `OnCollisionEnter`: that's the 3D message. | Chapter 3 |
| 3 | B | Every instance follows its prefab. | Chapter 4 |
| 4 | Web; `index.html` | Both needed. Accept `WebGL`. The zip holds the folder's contents, not the folder, so `index.html` is at the top. | Chapter 11 |
| 5 | `Debug.Log(boost);` in `Update()`: `boost` is a local variable of `Start()`, so it doesn't exist in `Update()` (CS0103) | Line and reason both needed. | C# 1 |
| 6 | `public void StartGame()` and `[SerializeField] int startingLives = 3;` | Both needed. Accept `[SerializeField] private int startingLives = 3;`. Not `public int startingLives`: other scripts could change it. | C# 1, Chapter 8 |
| 7 | `11` | `a` and `b` are two arrows to the same lamp (9); `c` is another lamp (2). | C# 2 |
| 8 | `ThuMon` | The last index is `Length - 1`, 3. No space: the strings are joined. | C# 3 |
| 9 | `14` | `points[0]` is still 0, the default. | C# 3 |
| 10 | `10` | 1 + 2 + 3 + 4. | C# 4 |
| 11 | `3` | 12 and 17 count, 9 is skipped by `continue`, 15 counts, then `break` at 20. | C# 4 |
| 12 | `3 laps, 1 left` | 10 → 7 → 4 → 1, and 1 fails `fuel >= 3`. | C# 4 |
| 13 | `Coat` | No case matches `Snowy`, so `default` runs. | C# 5 |
| 14 | `string medal = time < 30f ? "Gold" : "Silver";` | Accept `30` for `30f`, `time >= 30 ? "Silver" : "Gold"`, and the line without `string` (the question tests `?:`). Not `<=`. | C# 5 |
| 15 | `Rana: 3 stars`, then `Time 12.35` on a second line | Both lines needed. `\n` starts a new line; `F2` rounds, so not `12.34`. | C# 6 |
| 16 | B | A is true while Space is held; C when it's let go; D is the older Input Manager's "held". | Chapter 2 |
| 17 | 300 units; multiply the movement by `Time.deltaTime` | Both needed. Accept `5f * Time.deltaTime`. | Chapter 2 |
| 18 | `0`, `1` or `2`; any number from −2 to 2 | Both parts needed. The second must include 2: not "up to 1.99", not whole numbers only. Whole numbers leave out the maximum; decimals include it. | C# 3, Chapter 5 |
| 19 | `coinPrefab, position, Quaternion.identity, transform` | The order matters. | Chapter 5 |
| 20 | `playButton.SetActive(false);` and `audioSource.PlayOneShot(coinSound);` | Both needed. Accept `audioSource.clip = coinSound; audioSource.Play();`. | Chapters 8, 10 |

**Pass mark:** 14 out of 20.

> **Tip:** note which questions each student missed. The last column says which
> Level 1 chapter to send them back to.

## Section 3 — Practical Task Rubric

**Goal:** mark Firefly Catcher out of 100, giving partial credit where a requirement
is partly met.

| Requirement | Full marks | Partial credit | Zero |
| --- | --- | --- | --- |
| **Scripts and setup** (10) | `Jar.cs` and `FireflyGame.cs` with matching classes, attached to `Jar` and `Game`, no compile errors | 5: compiles, but misnamed or attached elsewhere | Doesn't compile |
| **The jar** (15) | Four directions, with the arrow keys and with W A S D; `speed` a `[SerializeField]` (or `public`) field; multiplied by `Time.deltaTime`; kept inside x ±8 and y ±4.5 | 8: moves, but only two directions, or only one set of keys, or not per second, or can leave the screen, or the speed isn't an Inspector field | No movement |
| **Insects appear** (15) | A `[SerializeField]` (or `public`) `GameObject[]` array, holding `Firefly` three times and `Moth` once; a timer with `Time.deltaTime`; a random element with `Random.Range(0, array.Length)`; random x and y in the ranges | 8: insects appear, but from separate fields instead of an array, or not three fireflies to each moth, or every frame, or always in the same place | None appear |
| **Catching** (15) | `OnTriggerEnter2D` destroys the insect and tells the game (a `[SerializeField]` (or `public`) reference and a public method); a `switch` on the tag: +1 firefly, −2 moth, never below 0 | 8: catching works, but no `switch`, or the score can go below 0, or the points are wrong | No catching |
| **Screen** (10) | `Score: 7   Time: 12.4` (any spacing between the two parts), the time with `F1` or another way to one decimal place, updated as the game runs | 5: shows the score and time, but no decimal format, or only updated sometimes | No text |
| **States and end** (15) | An `enum` with two values, and the state checked (a `switch` or `if`); at 0 seconds no more insects, catching adds nothing, the sky clears (`foreach` over the children, or another correct way); the length is an Inspector field used everywhere, so with `10` it all happens at 10 seconds | 8: the game ends, but one of the three is missing, or it still ends at 30 with `10` set, or a `bool` instead of an enum | Never ends |
| **Rank** (10) | Two arrays and a loop that finds the best rank reached; the three-line message | 5: correct rank from `if`/`else if` without arrays, or arrays without a loop, or `>` instead of `>=` (exactly 10, 20 or 30 gets the rank below), or the message isn't on three lines | No rank |
| **Readability** (10) | camelCase fields, PascalCase methods, consistent indentation, at least three useful comments; Inspector fields are `[SerializeField]`, not `public` | 5: mostly readable, few or weak comments, or `public` fields | Unreadable |

**Two or more faults in one row:** 4 in a 15-mark row, 2 in a 10-mark row.

**Pass mark:** 70 out of 100.

> **Note:** moving diagonally is faster than moving straight when two keys are
> held (the direction isn't normalized). That's expected at this level: Level 2
> teaches the fix. Don't take marks off for it.

### What a working game looks like

- The jar flies in all four directions and stops at the edges of the screen.
- About one insect appears each 0.8 seconds, roughly three fireflies to each moth,
  and they stay where they appear until caught.
- The text counts down: `Score: 0   Time: 30.0`, `Score: 1   Time: 27.3`…
- At 0: the insects vanish, the jar can still move but catches nothing, and the text
  reads `Time's up!`, `Score: …` and `Rank: …` on three lines. With 12 points,
  the rank is `Catcher`; with exactly 20, `Expert`.

## Section 4 — Model Solution

**Goal:** a reference answer written only with Level 1 C#. Students' solutions can
look different and still earn full marks.

In the Inspector: `Jar`'s **Game** is `Game`; `Game`'s **Insect Prefabs** has four
elements (`Firefly` three times, then `Moth`), and **Info Text** is `Info Text`.
Both prefabs' Rigidbody 2D has **Sleeping Mode** set to **Never Sleep**.

```csharp:Jar.cs
using UnityEngine;
using UnityEngine.InputSystem;

// Model answer for the Level 2 entry test practical task.
// Moves the jar with the keyboard, and catches whatever it touches.
public class Jar : MonoBehaviour
{
    [SerializeField] FireflyGame game;
    [SerializeField] float speed = 8f;      // units per second
    [SerializeField] float maxX = 8f;       // how far left and right the jar can go
    [SerializeField] float maxY = 4.5f;     // how far up and down

    void Update()
    {
        float x = 0f;
        float y = 0f;

        if (Keyboard.current.leftArrowKey.isPressed || Keyboard.current.aKey.isPressed)
        {
            x = -1f;
        }
        if (Keyboard.current.rightArrowKey.isPressed || Keyboard.current.dKey.isPressed)
        {
            x = 1f;
        }
        if (Keyboard.current.downArrowKey.isPressed || Keyboard.current.sKey.isPressed)
        {
            y = -1f;
        }
        if (Keyboard.current.upArrowKey.isPressed || Keyboard.current.wKey.isPressed)
        {
            y = 1f;
        }

        transform.Translate(x * speed * Time.deltaTime, y * speed * Time.deltaTime, 0f);

        // Keep the jar on screen
        if (transform.position.x < -maxX)
        {
            transform.position = new Vector3(-maxX, transform.position.y, 0f);
        }
        if (transform.position.x > maxX)
        {
            transform.position = new Vector3(maxX, transform.position.y, 0f);
        }
        if (transform.position.y < -maxY)
        {
            transform.position = new Vector3(transform.position.x, -maxY, 0f);
        }
        if (transform.position.y > maxY)
        {
            transform.position = new Vector3(transform.position.x, maxY, 0f);
        }
    }

    // Runs when an insect's trigger collider touches the jar
    void OnTriggerEnter2D(Collider2D other)
    {
        game.Caught(other.tag);
        Destroy(other.gameObject);
    }
}
```

```csharp:FireflyGame.cs
using UnityEngine;
using TMPro;

// Model answer for the Level 2 entry test practical task.
// Sends fireflies and moths for a set time, keeps the score, and gives a rank.
public class FireflyGame : MonoBehaviour
{
    // The two states the game can be in
    enum GameState
    {
        Playing,
        Finished
    }

    // ---- Settings ----
    [SerializeField] GameObject[] insectPrefabs;    // put Firefly in three times, Moth once
    [SerializeField] TMP_Text infoText;
    [SerializeField] float spawnDelay = 0.8f;       // seconds between two new insects
    [SerializeField] float gameLength = 30f;        // seconds

    // Where insects appear: x from -spawnWidth to spawnWidth, y from lowestY to highestY
    [SerializeField] float spawnWidth = 7.5f;
    [SerializeField] float lowestY = -2f;
    [SerializeField] float highestY = 4f;

    // ---- Ranks: the score each one needs, and its name ----
    int[] rankScores = { 0, 10, 20, 30 };
    string[] rankNames = { "Beginner", "Catcher", "Expert", "Firefly Master" };

    // ---- State: these change while the game runs ----
    GameState state = GameState.Playing;
    int score = 0;
    float timeLeft = 0f;
    float spawnTimer = 0f;

    void Start()
    {
        timeLeft = gameLength;
        UpdateText();
    }

    void Update()
    {
        switch (state)
        {
            case GameState.Playing:
                Play();
                break;
            case GameState.Finished:
                // Nothing appears and nothing counts any more
                break;
        }
    }

    // One frame of the game: the clock, and a new insect now and then
    void Play()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0f)
        {
            Finish();
            return;
        }

        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnDelay)
        {
            spawnTimer = 0f;
            SpawnInsect();
        }

        UpdateText();
    }

    // A random insect at a random place in the night sky
    void SpawnInsect()
    {
        int index = Random.Range(0, insectPrefabs.Length);
        float x = Random.Range(-spawnWidth, spawnWidth);
        float y = Random.Range(lowestY, highestY);

        // The last argument makes the insect a child of this object
        Instantiate(insectPrefabs[index], new Vector3(x, y, 0f), Quaternion.identity, transform);
    }

    // Called by the Jar when it catches an insect
    public void Caught(string insectTag)
    {
        if (state != GameState.Playing)
        {
            return;
        }

        switch (insectTag)
        {
            case "Firefly":
                score += 1;
                break;
            case "Moth":
                score -= 2;
                if (score < 0)
                {
                    score = 0;
                }
                break;
        }

        UpdateText();
    }

    // Time's up: stop, clear the sky, and show the result
    void Finish()
    {
        state = GameState.Finished;

        // Every insect still flying is a child of this object
        foreach (Transform insect in transform)
        {
            Destroy(insect.gameObject);
        }

        infoText.text = $"Time's up!\nScore: {score}\nRank: {GetRank()}";
    }

    // The best rank whose score has been reached
    string GetRank()
    {
        string rank = rankNames[0];
        for (int i = 0; i < rankScores.Length; i++)
        {
            if (score >= rankScores[i])
            {
                rank = rankNames[i];
            }
        }
        return rank;
    }

    void UpdateText()
    {
        infoText.text = $"Score: {score}   Time: {timeLeft:F1}";
    }
}
```

## Section 5 — Results and Next Steps

**Goal:** turn each result into a clear next step for the student.

| Result | Written | Practical | Next step |
| --- | --- | --- | --- |
| **Pass** | 14 or more | 70 or more | Start **Level 2**. |
| **Nearly there** | 11–13 | 70 or more | Review the chapters listed for the missed questions, then retake the **written paper** only. |
| **Nearly there** | 14 or more | 50–69 | Rebuild the Level 1 game's spawner and game manager from memory, then retake the **practical** only. |
| **Not yet** | anything else | | Repeat **Level 1**, focusing on the chapters from the written paper. |

A student who takes the test **without** doing Level 1 (to skip it) and doesn't
pass starts at **Level 1**, beginning at the first chapter linked to a missed
question.

### Retakes

Allow at least a few days between attempts, so students review rather than
memorise. For a retake, change the numbers so the answers change:

| Question | Change | New answer |
| --- | --- | --- |
| Q1, Q3, Q16 | reorder the options | the same answer, under its new letter |
| Q7 | `a.brightness = 4`, `b.brightness = 6`, `c.brightness = 3` | `9` |
| Q8 | `Debug.Log(days[days.Length - 2] + days[1]);` | `WedTue` |
| Q9 | `points[2] = points[1] + 3;` and `Debug.Log(points[0] + points[2]);` | `10` |
| Q10 | `int i = 2; i <= 5` | `14` |
| Q11 | `int[] ages = { 12, 8, 17, 20, 15 };` | `2` |
| Q12 | `fuel = 14`, `fuel >= 4`, `fuel -= 4` | `3 laps, 2 left` |
| Q13 | `default` prints `"Boots"` | `Boots` |
| Q15 | `float time = 8.456f;` | `Rana: 3 stars`, then `Time 8.46` |
| Practical | a 20-second game, a spawn every 0.6 seconds, a moth costs 3, and the ranks at 0, 8, 16 and 24; change every number in Section 3 to match, and in marking step 1 catch a moth at a score of 2 or less | the rank for 16 points is `Expert` |
