---
title: "Level 3 Entry Test"
subtitle: "C# and Unity: everything in Level 2"
author: "Unity Programmer Curriculum  ·  Level 3 Entry Test"
coverEyebrow: "Level 3 Entry Test · Unity Programmer Curriculum"
coverTop: "Level 3"
coverRed: "Entry Test"
coverSub: "A written paper and a practical task on everything in Level 2. Pass both to start Level 3."
coverPill: "Student Paper"
coverCaption: "Written paper: 40 minutes · Practical task: 90 minutes"
coverArt: code
coverCode: level2
keepCode: true
footer: "Level 3 Entry Test  ·  Student Paper"
---

## Section 1 — Before You Begin

**Goal:** show that you can do everything in Level 2, so you're ready for Level 3.

### How the test works

| Part | Time | Marks | To pass |
| --- | --- | --- | --- |
| **Written paper:** 20 questions | 40 minutes | 20 | 14 or more |
| **Practical task:** build a small game from a description | 90 minutes | 100 | 70 or more |

You need to pass **both** parts. If you've come from Level 2, this is its final
check. If you already know C# and Unity well, passing lets you start straight at
Level 3.

### Rules

- **Written paper:** closed book. Write your answers in the spaces. Your trainer
  collects it before handing out the practical task.
- **Practical task:** you may use Unity, your code editor, and the printed **Level 2
  cheat sheet**. No other notes, websites, AI tools or code from earlier projects.
- Read each question to the end before answering. Several questions look like
  ones you've seen, with one detail changed.

Name: ______________________________ Date: ________________

## Section 2 — Written Paper

**Goal:** answer all 20 questions in 40 minutes. Each is worth 1 mark.

### Classes, properties and modifiers

**Q1.** Here is a class:

```csharp
public class Wallet
{
    public int Coins { get; private set; }

    public void Earn(int amount)
    {
        Coins += amount;
    }
}
```

Another script has these four lines:

```csharp
Wallet wallet = new Wallet();     // line 1
wallet.Earn(20);                  // line 2
Debug.Log(wallet.Coins);          // line 3
wallet.Coins = 50;                // line 4
```

One of the four lines doesn't compile. Which one, and why?

Answer: ______________________________________________________________

**Q2.** What does this print? Then write a second constructor for `Order`: one that
takes only the dish, and sets `Count` to 1.

```csharp
public class Order
{
    public string Dish { get; private set; }
    public int Count { get; private set; }

    public Order(string dish, int count)
    {
        Dish = dish;
        Count = count * 2;
    }
}
```

```csharp
Order first = new Order("Soup", 3);
Order second = new Order("Rice", 1);
Debug.Log(first.Dish + " x" + first.Count + ", " + second.Dish + " x" + second.Count);
```

Prints: ______________________________________________________________

The second constructor:

______________________________________________________________

______________________________________________________________

______________________________________________________________

______________________________________________________________

**Q3.** Match each value to the declaration that fits it best. Use four of the five
letters.

1. How many coins have been made: one number, shared by every `Coin` object.
2. The 3 lives every game starts with. It never changes, in any game.
3. A list of high scores, made when the object is created. Scores are added to it,
   but it's never replaced by another list.
4. A jump height a designer tunes in the Inspector. No other script may change it.

- A. `[SerializeField] float jumpHeight = 2f;`
- B. `public const int StartLives = 3;`
- C. `public static int CoinsMade;`
- D. `readonly List<int> highScores = new List<int>();`
- E. `public float jumpHeight = 2f;`

1: ________ 2: ________ 3: ________ 4: ________

### Methods and numbers

**Q4.** A script has these three methods:

```csharp
void Show(string text)
{
    Debug.Log("A: " + text);
}

void Show(string text, int times)
{
    Debug.Log("B: " + text + " " + times);
}

void Show(int number, string unit = "points")
{
    Debug.Log("C: " + number + " " + unit);
}
```

What does each call print?

`Show(5);` ______________________________

`Show("Hi", 3);` ______________________________

`Show("Hi");` ______________________________

**Q5.** What does the Console show? Write each line.

```csharp
string[] typed = { "25", "7b", "-3" };
int total = 0;
foreach (string text in typed)
{
    if (int.TryParse(text, out int number))
    {
        total += number;
    }
    else
    {
        Debug.Log("Not a number: " + text);
    }
}
Debug.Log(total);
```

Answer: ______________________________________________________________

**Q6.** What do the four `Debug.Log` lines print?

```csharp
int found = 2;
int total = 5;
Debug.Log(9 / 2);
Debug.Log(9 / 2f);
Debug.Log((int)-4.7f);
Debug.Log((float)found / total * 100);
```

1: ________ 2: ________ 3: ________ 4: ________

**Q7.** Each of these gives an `int`. Write its value.

`Mathf.RoundToInt(6.5f)`: ________ `Mathf.FloorToInt(-2.3f)`: ________

`Mathf.CeilToInt(2.1f)`: ________ `Mathf.Clamp(-5, 0, 10)`: ________

### Collections

**Q8.** Which fits each one best: an array, a `List` or a `Dictionary`?

1. The four spawn points of a level, dragged in once in the Inspector. ________________
2. The enemies alive right now: added when they spawn, removed when they die. ________________
3. The price of each item in a shop, looked up by the item's name. ________________

**Q9.** What does this print?

```csharp
List<string> players = new List<string> { "Ana", "Ben", "Cy" };
players.Add("Dee");
players.Remove("Ben");
players.Insert(1, "Eve");
players.RemoveAt(0);
Debug.Log(players.Count + " " + players[0] + " " + players.IndexOf("Ben"));
```

Answer: ______________________________

**Q10.** What does the Console show? And what would one more line,
`Debug.Log(stock["Plum"]);`, do?

```csharp
Dictionary<string, int> stock = new Dictionary<string, int>();
stock["Apple"] = 4;
stock["Pear"] = 2;
stock["Apple"] = stock["Apple"] + 3;
Debug.Log(stock["Apple"] + " " + stock.Count);

if (stock.TryGetValue("Plum", out int plums))
{
    Debug.Log("Plums: " + plums);
}
else
{
    Debug.Log("No plums");
}
```

Shows: ______________________________________________________________

The extra line: ______________________________________________________________

### Event functions and components

**Q11.** `Lamp` is on an object in the scene, and ticked. You press **Play** and
wait a few seconds. Write the Console's messages, in order.

```csharp
public class Lamp : MonoBehaviour
{
    void Update()
    {
        Debug.Log("Update");
        enabled = false;
    }

    void Start()
    {
        Debug.Log("Start");
    }

    void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    void Awake()
    {
        Debug.Log("Awake");
    }

    void OnEnable()
    {
        Debug.Log("OnEnable");
    }
}
```

Answer: ______________________________________________________________

**Q12.** The crate has a **Box Collider 2D** with **Is Trigger** ticked, and **no**
Rigidbody 2D. A ball with a Rigidbody 2D, but no `Health` script, rolls into the
crate's trigger. Which line, if any, gives an error, and why? (`Health` is one of
your scripts.)

```csharp
public class Crate : MonoBehaviour
{
    Rigidbody2D body;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();             // line A
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out Health health))   // line B
        {
            health.TakeDamage(5);
        }
        body.linearVelocity = Vector2.up * 3f;          // line C
    }
}
```

Answer: ______________________________________________________________

### Vectors, time and coroutines

**Q13.** A drone is at `(2, 1, 0)`, and its target is at `(8, 9, 0)`. Write:

The arrow from the drone to the target: ______________________________

Its length: ______________________________

The normalized direction: ______________________________

**Q14.** What does the Console show in the first three seconds, in order?

```csharp
Coroutine blink;

void Start()
{
    blink = StartCoroutine(Blink());
    Debug.Log("Started");
}

IEnumerator Blink()
{
    Debug.Log("On");
    yield return new WaitForSeconds(1f);
    Debug.Log("Off");
    yield return new WaitForSeconds(1f);
    Debug.Log("On again");
}

void Update()
{
    if (Time.time > 1.5f && blink != null)
    {
        StopCoroutine(blink);
        blink = null;
        Debug.Log("Stopped");
    }
}
```

Answer: ______________________________________________________________

**Q15.** A settings panel sets `Time.timeScale = 0f;` while it's open. While it's
open, is each of these true? Write yes or no.

a) A coroutine waiting at `yield return new WaitForSeconds(2f);` carries on after
2 seconds. ________

b) A coroutine waiting at `yield return new WaitForSecondsRealtime(2f);` carries on
after 2 seconds. ________

c) A ball with a Rigidbody 2D, which was falling when the panel opened, keeps
falling. ________

d) The panel's slider and buttons still work. ________

### Input, rays, UI and debugging

**Q16.** Which of these is `true` only in the frame when the mouse button, or a
finger, first goes down, and works with both?

- A. `Mouse.current.leftButton.wasPressedThisFrame`
- B. `Pointer.current.press.wasPressedThisFrame`
- C. `Pointer.current.press.isPressed`
- D. `Touchscreen.current.primaryTouch.press.isPressed`

Answer: ________

How can you test a finger's tap in the Editor, without a phone?

Answer: ______________________________________________________________

**Q17.** `groundMask` is a `[SerializeField] LayerMask` with only the `Ground`
layer ticked. Half a unit below the player is a box on the `Default` layer. There's
nothing on the `Ground` layer within 1.5 units.

In 3D, what does this line put in `found`?

```csharp
bool found = Physics.Raycast(transform.position, Vector3.down, out RaycastHit hit, 1.5f, groundMask);
```

Answer: ______________________________

In 2D, after this line, what is `hit2D.collider`?

```csharp
RaycastHit2D hit2D = Physics2D.Raycast(transform.position, Vector2.down, 1.5f, groundMask);
```

Answer: ______________________________

**Q18.** Write the parameter type each listener method needs, so it can be added
with `AddListener`.

A Slider's `onValueChanged`: `void OnSpeedChanged(` ________ `value)`

A Toggle's `onValueChanged`: `void OnMusicToggled(` ________ `isOn)`

An Input Field's `onEndEdit`: `void OnNameEntered(` ________ `text)`

A Dropdown's `onValueChanged`: `void OnLevelChosen(` ________ `index)`

**Q19.** The Console shows:

```
NullReferenceException: Object reference not set to an instance of an object
Cannon.Fire (System.Single power) (at Assets/Scripts/Cannon.cs:27)
Cannon.Update () (at Assets/Scripts/Cannon.cs:14)
```

Line 27 of `Cannon.cs` is `ammoText.text = "Ammo: " + ammo;`. `ammo` is an `int`.

a) Which method was running when the error happened, and which method called it?

Answer: ______________________________________________________________

b) Which reference is `null`? You stop the game on line 27 with a breakpoint: how
do you see that it's `null`?

Answer: ______________________________________________________________

**Q20.** Here is part of a Scripting API page (shortened), for the class
`Physics2D`:

```
public static Collider2D OverlapCircle(Vector2 point, float radius, int layerMask);
```

| Parameter | Description |
| --- | --- |
| `point` | The centre of the circle. |
| `radius` | The radius of the circle. |
| `layerMask` | Only colliders on these layers are found. |

**Returns:** `Collider2D`, the collider overlapping the circle, or `null` if there
isn't one. **Description:** checks if a collider falls within a circular area.

Write one line that stores, in a `Collider2D` called `nearby`, a collider on the
layers of `meteorMask` that's within 2 units of this object's position.

Answer: ______________________________________________________________

## Section 3 — Practical Task: Meteor Defence

**Goal:** in 90 minutes, build a small game from this description, with no
tutorial.

### The task

Meteors are falling on a small city. You click or tap them to blast them before
they land. They come in three waves, each bigger than the last. Small meteors are
the fastest and worth the most points. Every meteor that lands costs the city one
of its 3 lives. A settings panel pauses the game and sets how fast the meteors
fall.

> **Tip:** build it in small steps, pressing Play after each one: falling, then the
> waves, blasting, the score, the screen, the settings, and the end. A game that
> does five steps correctly scores far more than one that tries all seven and
> doesn't compile.

### Set up the scene (about 15 minutes)

1. In the **Universal 2D** project your trainer made, **File → New Scene** →
   **Lit 2D (URP)**, and save it as `Assets/Scenes/Meteors.unity`. Keep the
   **Main Camera**'s **Size** at `5`, and set the Game view to **16:9** (the aspect
   menu at the top of the Game view). Any dark **Background** colour makes a good
   night sky.
2. Add a layer called `Meteor`: **Layer → Add Layer…** at the top of the
   Inspector.
3. **The city:** **GameObject → 2D Object → Sprites → Square**, named `City`, at
   **Position** `(0, -4.6, 0)`, **Scale** `(18, 0.8, 1)`, in any colour. It's only a
   picture: no collider.
4. **The meteors:** **GameObject → 2D Object → Sprites → Circle**, named `Small
   Meteor`, **Scale** `(0.4, 0.4, 1)`, on the `Meteor` layer, in a bright colour.
   Add a **Circle Collider 2D**. Make it a prefab, and delete it from the scene.
   Make two more the same way, each in its own colour: `Medium Meteor`, **Scale**
   `(0.7, 0.7, 1)`, and `Large Meteor`, **Scale** `(1.1, 1.1, 1)`. They need no
   Rigidbody 2D: your script moves them.
5. **The UI** (in some Unity 6 versions the menu is just **UI**):
   - `Info Text`: **GameObject → UI (Canvas) → Text - TextMeshPro**, anchored at the
     top-left, wide enough for one line of about 35 letters.
   - `End Text`: another **Text - TextMeshPro**, in the middle of the screen, big
     enough for three lines, with its text empty.
   - `Settings Button`: **GameObject → UI (Canvas) → Button - TextMeshPro**, its
     label `Settings`, anchored at the bottom-right, over the city, where no meteor
     ever flies.
   - `Settings Panel`: **GameObject → UI (Canvas) → Panel**. Inside it, a `Speed
     Slider` (**UI (Canvas) → Slider**, with **Min Value** `0.5`, **Max Value** `2`
     and **Value** `1`) and a `Close Button` (**Button - TextMeshPro**, its label
     `Close`). Then switch the panel off: the box beside its name, at the top of the
     Inspector.
6. **The game:** an empty GameObject named `Game`, at `(0, 0, 0)`.

### What your scripts must do

Write two scripts: `Meteor`, on the three meteor prefabs, and `MeteorGame`, on
`Game`. When you press Play:

1. **Meteors fall towards the city.** Each meteor picks a random point on the
   city's top edge, with `x` between −8 and 8 and `y` = −4.2, and flies straight at
   it, along a **normalized** direction (or with `Vector3.MoveTowards`), the same on
   any computer. Its speed is set on its prefab in the Inspector, Small 3, Medium 2
   and Large 1.2 units per second, times the game's speed setting (point 6). When it
   reaches the city, it leaves the list (point 2), disappears, and the city loses a
   life. Give each meteor a reference to the game when you make it, so it can tell
   the game.
2. **Waves come from a coroutine.** One coroutine runs the waves. A wave makes its
   meteors one every 0.7 seconds: a random prefab from an **array**, at a random `x`
   between −8 and 8, with `y` = 5.5, just above the screen. The game keeps a
   **`List`** of the meteors in the sky. A wave is over when the list is empty, and
   the next wave starts 2 seconds later. The number of meteors in each wave is an
   array set in the Inspector, `6`, `9` and `12`: your trainer will also try just
   two waves, of `2` and `3` meteors, so take the number of waves from the array
   too.
3. **Blasting.** When the mouse button or a finger is pressed (`Pointer.current`,
   checked for `null`), the meteor under the pointer (find it with
   `Physics2D.OverlapPoint`) is blasted: it leaves the list and disappears, and its
   points go on the score. Only the `Meteor` layer counts:
   use a `LayerMask` field. The points come from a **`Dictionary`**: Small 50,
   Medium 20, Large 10.
4. **The score and the lives.** The score is a property that every script can read
   and only `MeteorGame` can change. The 3 lives the city starts with are a `const`.
5. **The screen.** While the game runs, `Info Text` shows the wave, the score and
   the lives, on one line:

   ```
   Wave 2   Score: 340   Lives: 2
   ```

6. **Settings.** The `Settings Button` opens the panel and pauses the game with
   `Time.timeScale`; the `Close Button` hides it and carries on. Connect both
   buttons and the slider in code, with `AddListener`. The `Speed Slider` sets the
   speed setting of point 1, for every meteor, at once. While the panel is open,
   nothing is blasted.
7. **The end.** When the last wave is cleared, the game ends with `The city is
   safe!`. When the last life is lost, the wave coroutine is stopped
   (`StopCoroutine`), every meteor still in the sky disappears, and the game ends
   with `The city has fallen`. Either way, `End Text` shows three lines: the
   message, the score, and how many meteors of each size were blasted, counted in a
   second **`Dictionary`**:

   ```
   The city has fallen
   Score: 340
   Small: 4   Medium: 5   Large: 4
   ```

### How it's marked

| Requirement | Marks |
| --- | --- |
| Scripts named correctly, attached, compile with no errors | 10 |
| Meteors fall towards the city at the right speed, and landing costs a life | 15 |
| Waves come from one coroutine, and a `List` keeps the meteors in the sky | 15 |
| Blasting with the mouse and with a finger, on the `Meteor` layer only | 15 |
| Points from a `Dictionary`, the score property and the starting lives `const`, the screen | 15 |
| Settings: the pause, the slider and buttons connected in code, no blasting while paused | 10 |
| The end: the waves stopped, the sky cleared, the counts from a `Dictionary` | 10 |
| Readable code: names, indentation, useful comments, `[SerializeField]` rather than `public`, each piece of code in the right event function | 10 |
| **Total** | **100** |
