## Exam-style questions

These questions use the styles of the Unity certification exams, and the
**Level 3 entry test** uses them too. Answer on paper first, then check the
answers.

**Q1.** What does this print?

```csharp
public class Counter
{
    public int Count { get; private set; }

    public void Add(int amount)
    {
        Count += amount;
    }
}
```

```csharp
Counter counter = new Counter();
counter.Add(4);
counter.Add(6);
Debug.Log(counter.Count);
```

**Q2.** Using the `Counter` class from Q1, which line doesn't compile?

- A. `Debug.Log(counter.Count);`
- B. `counter.Count = 0;`
- C. `counter.Add(-2);`
- D. `int total = counter.Count + 1;`

**Q3.** What does this print?

```csharp
public class Robot
{
    public static int Built { get; private set; }
    public string Name { get; private set; }

    public Robot(string name)
    {
        Name = name;
        Built++;
    }
}
```

```csharp
Robot a = new Robot("Ax");
Robot b = new Robot("Bo");
Debug.Log(b.Name + " " + Robot.Built);
```

**Q4.** What does this print?

```csharp
int coins = 7;
int players = 2;
Debug.Log(coins / players);
Debug.Log((float)coins / players);
Debug.Log(coins % players);
```

**Q5.** What does this print?

```csharp
Debug.Log((int)4.9f);
Debug.Log(Mathf.RoundToInt(4.5f));
Debug.Log(Mathf.RoundToInt(5.5f));
```

**Q6.** What does this print?

```csharp
List<string> queue = new List<string> { "Ali", "Maya", "Jo" };
queue.Add("Sami");
queue.RemoveAt(0);
queue.Insert(1, "Rana");
Debug.Log(queue.Count + " " + queue[1] + " " + queue.IndexOf("Jo"));
```

**Q7.** What does this print?

```csharp
Dictionary<string, int> ammo = new Dictionary<string, int>();
ammo["Laser"] = 20;
ammo["Rocket"] = 2;
ammo["Laser"] = ammo["Laser"] - 5;
if (ammo.TryGetValue("Mine", out int mines))
{
    Debug.Log("Mines: " + mines);
}
else
{
    Debug.Log("Laser: " + ammo["Laser"]);
}
```

**Q8.** A class already has `void Play(string clip)`. Which of these can be added
as an overload? (Choose all that apply.)

- A. `void Play(string sound)`
- B. `void Play(string clip, float volume)`
- C. `bool Play(string clip)`
- D. `void Play(int trackNumber)`

**Q9.** Match each job with the best event function: `Awake`, `OnEnable`,
`FixedUpdate`, `LateUpdate`.

1. Pushing a Rigidbody with `AddForce(…, ForceMode.Force)` every step
2. Getting this object's own Rigidbody with `GetComponent`
3. Moving a camera that follows the player
4. Calling `AddListener` on a button

**Q10.** In what order does Unity call these, for a script that's enabled when
the scene starts? `Start`, `Awake`, `Update`, `OnEnable`.

**Q11.** What does this print?

```csharp
void Start()
{
    Debug.Log("A");
    StartCoroutine(Wait());
    Debug.Log("B");
}

IEnumerator Wait()
{
    Debug.Log("C");
    yield return new WaitForSeconds(1f);
    Debug.Log("D");
}
```

**Q12.** A student writes `Wait();` instead of `StartCoroutine(Wait());`. What
happens?

- A. A compile error
- B. The coroutine runs normally
- C. Nothing: the coroutine never runs, and there's no error
- D. The game freezes for one second

**Q13.** An enemy is at `(1, 2, 0)` and the player at `(4, 6, 0)`. What are the
distance between them, and the normalized direction from the enemy to the player?

**Q14.** Which line finds the first collider on the layers in `wallsMask`, up to
10 units straight ahead of this object, in 3D?

- A. `Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, 10f, wallsMask)`
- B. `Physics.Raycast(transform.forward, transform.position, out RaycastHit hit, 10f, wallsMask)`
- C. `Physics2D.Raycast(transform.position, transform.forward, 10f, wallsMask)`
- D. `Physics.Raycast(transform.position, transform.forward, 10f, out RaycastHit hit, wallsMask)`

**Q15.** Which older `Input` code matches
`Touchscreen.current.primaryTouch.press.wasPressedThisFrame`?

- A. `Input.touchCount > 0`
- B. `Input.GetTouch(0).phase == TouchPhase.Began`
- C. `Input.GetTouch(0).phase == TouchPhase.Moved`
- D. `Input.GetMouseButton(0)`

**Q16.** Which method can be passed to `slider.onValueChanged.AddListener(…)`?

- A. `void OnVolume()`
- B. `void OnVolume(int value)`
- C. `void OnVolume(float value)`
- D. `float OnVolume(float value)`

**Q17.** A script has `[SerializeField] AudioSource source;`, left empty in the
Inspector. In the Editor, what does `source.Play();` throw?

**Q18.** The Console shows this error. In which method, file and line did it
happen, and which method called that one?

```
NullReferenceException: Object reference not set to an instance of an object
Inventory.AddItem (System.String item) (at Assets/Scripts/Inventory.cs:18)
Pickup.OnTriggerEnter2D (UnityEngine.Collider2D other) (at Assets/Scripts/Pickup.cs:11)
```

**Q19.** What does `GetComponent<Rigidbody>()` return when the GameObject has no
Rigidbody?

**Q20.** Which of these lines don't compile? (Choose all that apply.)

- A. `int lives = 3.0f;`
- B. `float speed = 3;`
- C. `string label = 3;`
- D. `double exact = 3f;`

## Answers

| Q | Answer | Why |
| --- | --- | --- |
| 1 | `10` | `Add` changes `Count` from inside the class: 4 + 6. |
| 2 | B | `Count` has a `private set`: only `Counter` can change it (CS0272). |
| 3 | `Bo 2` | Each robot has its own `Name`; `Built` is static, shared by both. |
| 4 | `3`, `3.5`, `1` | `int / int` drops the decimals; the cast makes it a `float` division; `%` is the remainder. |
| 5 | `4`, `4`, `6` | A cast cuts off the decimals. Halfway values round to the nearest **even** number. |
| 6 | `4 Rana 2` | After the changes: `Maya, Rana, Jo, Sami`. |
| 7 | `Laser: 15` | "Mine" isn't a key, so `TryGetValue` returns `false`. |
| 8 | B, D | Overloads need different parameter **types or numbers**. Names (A) and return types (C) don't count. |
| 9 | 1 `FixedUpdate`, 2 `Awake`, 3 `LateUpdate`, 4 `OnEnable` | Physics on the physics clock; your own set-up first; cameras after everything moved; listen while enabled. |
| 10 | `Awake`, `OnEnable`, `Start`, `Update` | `Start` waits until just before the first `Update`. |
| 11 | `A`, `C`, `B`, then `D` a second later | The coroutine runs until its first `yield` straight away. |
| 12 | C | Only `StartCoroutine` runs it. Calling it alone does nothing. |
| 13 | `5`, and `(0.60, 0.80, 0.00)` | The arrow is `(3, 4, 0)`: its length is 5, and divided by 5 it's `(0.6, 0.8, 0)`. |
| 14 | A | Start, direction, `out` result, distance, then the mask. C is 2D and has no `out`. |
| 15 | B | `Began` is the frame the finger touches down. |
| 16 | C | A slider sends a `float`, and a listener returns nothing (`void`). |
| 17 | `UnassignedReferenceException` | In the Editor, an empty Inspector field gets this more helpful error. In a build it's a `NullReferenceException`. |
| 18 | `Inventory.AddItem`, `Inventory.cs` line 18, called by `Pickup.OnTriggerEnter2D` | Read a stack trace from the top. |
| 19 | `null` | Use it without checking and you get an error. `TryGetComponent` checks for you. |
| 20 | A, C | `float` → `int` needs a cast; a number is not a `string`. B and D are safe, implicit conversions. |

## Level 2 cheat sheet

| Topic | Syntax |
| --- | --- |
| Read-only property | `public int Score { get; private set; }` |
| Worked-out property | `public bool IsAlive { get { return lives > 0; } }` |
| Constructor | `public Ticket(string owner) { Owner = owner; }` then `new Ticket("Lina")` |
| Static member | `public static int Count { get; private set; }` then `Enemy.Count` |
| Constant | `public const int MaxLives = 3;` |
| Set once | `readonly List<int> scores = new List<int>();` |
| Overloads | `void Show(string text)` and `void Show(string text, float seconds)` |
| Optional parameter | `void Heal(int amount = 10)` |
| `out` and the Try pattern | `if (int.TryParse(text, out int number)) { … }` |
| Cast | `(int)3.9f` is 3; `(float)found / total` |
| Rounding | `Mathf.RoundToInt(x)`, `Mathf.FloorToInt(x)`, `Mathf.CeilToInt(x)` |
| Keep in range | `Mathf.Clamp(x, min, max)`, `Mathf.Clamp01(x)` |
| List | `List<int> list = new List<int>();` `Add` `Remove` `RemoveAt` `Contains` `Count` |
| Dictionary | `Dictionary<string, int> d = new Dictionary<string, int>();` `d["a"] = 1;` `d.TryGetValue("a", out int v)` |
| Event functions | `Awake` → `OnEnable` → `Start` → `FixedUpdate` / `Update` → `LateUpdate` → `OnDisable` → `OnDestroy` |
| Own component | `body = GetComponent<Rigidbody>();` in `Awake` |
| Other object's component | `if (other.TryGetComponent(out Health health)) { … }` |
| Must have | `[RequireComponent(typeof(Rigidbody))]` above the class |
| Vectors | `target - me` (the arrow), `.magnitude`, `.normalized`, `Vector3.Distance(a, b)` |
| Part of the way | `Vector3.Lerp(a, b, t)`, `Vector3.MoveTowards(a, b, maxStep)` |
| Coroutine | `IEnumerator Wait() { yield return new WaitForSeconds(1f); }` and `StartCoroutine(Wait());` |
| Cooldown | `if (Time.time >= nextTime) { nextTime = Time.time + cooldown; }` |
| Mouse or finger | `Pointer.current.press.wasPressedThisFrame`, `Pointer.current.position.ReadValue()` |
| Screen to world | 2D: `Camera.main.ScreenToWorldPoint(p)`; 3D: `Camera.main.ScreenPointToRay(p)` |
| 3D raycast | `Physics.Raycast(start, direction, out RaycastHit hit, distance, mask)` |
| 2D raycast | `RaycastHit2D hit = Physics2D.Raycast(start, direction, distance, mask);` then `hit.collider != null` |
| UI events | `slider.onValueChanged.AddListener(OnVolume);` and `RemoveListener` |
| Change a UI value quietly | `slider.SetValueWithoutNotify(0.5f);` |
| Null check | `if (target != null) { … }` |
| Pause the game | `Time.timeScale = 0f;` (and `1f` to carry on) |
| Particles | `particles.Play();` |

## Before Level 3: can you…

Tick each one honestly. Level 3's entry test checks every line.

- Write a class with properties and a constructor, and explain `private set`?
- Choose between `static`, `const` and `readonly`, and between `public`,
  `[SerializeField]` and a property, for a value?
- Read a method declaration, overload a method, and use an `out` parameter?
- Predict `int` and `float` arithmetic, cast between them, and round on purpose?
- Choose between an array, a `List` and a `Dictionary`, and use each one?
- Say when each event function runs, and put code in the right one?
- Get components with `GetComponent` and `TryGetComponent`, and cache them in
  `Awake`?
- Use vectors for directions and distances, and normalize a direction?
- Wait with a timer or a coroutine, and stop a coroutine?
- Read the mouse and the touchscreen, and test touch in the Simulator?
- Cast a ray in 2D and in 3D, with a layer mask?
- Connect a Slider, Toggle, Input Field and Dropdown with `AddListener`?
- Explain a `NullReferenceException`, read a stack trace, and use a breakpoint?
- Find a class, a method and its arguments in the Unity Scripting API?

*End of Level 2 — next up, Level 3, where characters come alive with the
Animator, enemies think with state machines, and you get ready for your first
Unity certificate.*
