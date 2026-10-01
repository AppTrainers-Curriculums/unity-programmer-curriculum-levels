## Exam-style questions

These questions are written the way the **Unity Certified User: Programmer** exam
writes its own: two for each of its 19 objectives, whose number is in brackets after
each question ({{ref:exam}} lists them all). Answer on paper first, then check the
answers. The practice paper after them is a timed rehearsal.

**Q1.** (1.1) A script has `int coins = 12;` and `int total = 30;`. The Console shows
`Coins: 12 of 30`. Which line printed it?

- A. `Debug.Log("Coins: coins of total");`
- B. `Debug.Log($"Coins: {coins} of {total}");`
- C. `Debug.Log("Coins: " + coins + "of" + total);`
- D. `Debug.Log($"Coins: {coins} of total");`

**Q2.** (1.1) What does this print?

```csharp
float seconds = 125.6f;
int whole = (int)seconds;
Debug.Log($"{whole / 60}:{whole % 60:00}");
```

**Q3.** (1.2) The Console shows this error. Line 13 of `Coin.cs` is
`game.AddCoin();`. Which object is `null`, and what's the most likely reason?

```
NullReferenceException: Object reference not set to an instance of an object
Coin.OnTriggerEnter2D (UnityEngine.Collider2D other) (at Assets/Scripts/Coin.cs:13)
```

**Q4.** (1.2) This line throws an exception when it runs. What's the most likely
reason?

```csharp
GetComponent<Animator>().SetTrigger("Jump");
```

- A. The Animator has no parameter called `Jump`.
- B. The GameObject has no Animator component.
- C. `SetTrigger` needs a hash, not a string.
- D. The Animator component is disabled.

**Q5.** (1.3) Which line makes the Rigidbody 2D `body` move right at 5 units a second,
and keeps its speed of falling?

- A. `body.linearVelocity = 5f;`
- B. `body.linearVelocity = new Vector2(5f, body.linearVelocity.y);`
- C. `body.AddForce(5f);`
- D. `transform.position.x += 5f;`

**Q6.** (1.3) Which line makes the Sprite Renderer `sprite` half see-through?

- A. `sprite.color.a = 0.5f;`
- B. `sprite.color = new Color(1f, 1f, 1f, 0.5f);`
- C. `sprite.alpha = 0.5f;`
- D. `sprite.SetColor(0.5f);`

**Q7.** (2.1) What does this print?

```csharp
List<string> items = new List<string> { "key", "apple" };
items.Add("coin");
items.Remove("key");
items.Insert(0, "map");
Debug.Log(items.Count + " " + items[1]);
```

**Q8.** (2.1) Which field shows in the Inspector, but can't be used by other scripts?

- A. `public int health;`
- B. `[SerializeField] int health;`
- C. `int health;`
- D. `static int health;`

**Q9.** (2.2) Which is a valid declaration of a method that takes an amount of damage
and says whether the target died?

- A. `bool TakeDamage(int amount)`
- B. `TakeDamage(int amount) : bool`
- C. `void bool TakeDamage(amount)`
- D. `int TakeDamage(bool amount)`

**Q10.** (2.2) An Animation Event should pass the method a whole number, set in the
event's Inspector. Which method can it call?

- A. `public void OnStep(int foot)`
- B. `public void OnStep(int foot, int side)`
- C. `public void OnStep(Vector2 where)`
- D. `public void OnStep(bool isLeft)`

**Q11.** (2.3) An Animator is in **Idle**. The transition Idle → Attack has one
condition: `Attack`, a Trigger. Which line makes it play Attack?

- A. `animator.SetBool("Attack", true);`
- B. `animator.SetTrigger("Attack");`
- C. `animator.Play("Idle");`
- D. `animator.SetFloat("Attack", 1f);`

**Q12.** (2.3) An enemy's Animator has an **Any State** transition into Hurt with the
condition `State` Equals `4`. Its script has
`enum State { Patrol, Chase, WindUp, Leap, Hurt, Dead }`. Which line makes it play Hurt?

- A. `animator.SetInteger("State", (int)State.Hurt);`
- B. `animator.SetTrigger("Hurt");`
- C. `animator.SetBool("State", true);`
- D. `animator.SetInteger("State", 5);`

**Q13.** (2.4) With the Input System, which is true on the one frame the player presses
Space down, and on no other?

- A. `Keyboard.current.spaceKey.isPressed`
- B. `Keyboard.current.spaceKey.wasPressedThisFrame`
- C. `Keyboard.current.spaceKey.wasReleasedThisFrame`
- D. `Keyboard.current.anyKey.isPressed`

**Q14.** (2.4) Why does this code check for `null`?

```csharp
Keyboard keyboard = Keyboard.current;
if (keyboard != null && keyboard.jKey.wasPressedThisFrame)
{
    Roll();
}
```

**Q15.** (2.5) What does this print?

```csharp
bool isGrounded = false;
bool isRolling = false;
bool isDead = true;
Debug.Log(isGrounded && !isRolling || isDead);
Debug.Log(isGrounded && (!isRolling || isDead));
```

**Q16.** (2.5) What does this print?

```csharp
int total = 0;
for (int i = 1; i <= 6; i++)
{
    if (i % 2 == 0)
    {
        continue;
    }
    if (i > 4)
    {
        break;
    }
    total += i;
}
Debug.Log(total);
```

**Q17.** (2.6) Which method can be passed to
`volumeSlider.onValueChanged.AddListener(…)`?

- A. `void OnVolumeChanged()`
- B. `void OnVolumeChanged(float value)`
- C. `float OnVolumeChanged(float value)`
- D. `void OnVolumeChanged(int value)`

**Q18.** (2.6) A pause panel connects its **Resume** button with `AddListener` when it
opens, in `OnEnable`. Where should it disconnect it?

- A. `Start`
- B. `OnDisable`
- C. `Update`
- D. `Awake`

**Q19.** (3.1) A GameObject, enabled, is in the scene when the scene loads. In what
order does Unity call these on its script: `Start`, `Update`, `Awake`, `OnEnable`?

**Q20.** (3.1) A camera follows a player who moves in `Update`. In which event function
should the camera move, so that it never shows the player a frame late?

- A. `Awake`
- B. `FixedUpdate`
- C. `LateUpdate`
- D. `OnEnable`

**Q21.** (3.2) Which line doesn't compile?

- A. `float speed = 6;`
- B. `int lives = 3.0f;`
- C. `double distance = 2.5f;`
- D. `string label = "5";`

**Q22.** (3.2) Why doesn't the last line compile, and what's one fix?

```csharp
int score = 10;
float bonus = 2.5f;
int total = score * bonus;
```

**Q23.** (3.3) Another script calls `door.Open();` on this door. What happens?

```csharp
public class Door : MonoBehaviour
{
    void Open()
    {
        Debug.Log("Open");
    }
}
```

- A. It compiles, and the door opens.
- B. A compile error: `Open` is inaccessible due to its protection level.
- C. A `NullReferenceException` when it runs.
- D. A warning, and nothing happens.

**Q24.** (3.3) A knight's **Attack** clip has an Animation Event that calls
`OnAttackHit`. The method is `public void OnAttackHit()`, in a script on the knight's
child object `Sword`. The Animator is on the knight. What happens when the clip reaches
the event, and how do you fix it?

**Q25.** (3.4) Which of these is a component in Unity's Entity Component System?

- A. `public class Speed : MonoBehaviour { public float value; }`
- B. `public struct Speed : IComponentData { public float Value; }`
- C. `public class Speed : ScriptableObject { public float value; }`
- D. `[System.Serializable] public class Speed { public float value; }`

**Q26.** (3.4) What kind of class is each one?

1. `public class Wave`, made with `new Wave(…)`
2. `public class EnemyStats : ScriptableObject`
3. `public partial struct MoveSystem : ISystem`
4. `public class Slime : MonoBehaviour`

**Q27.** (3.5) Which declaration follows the naming conventions for a private field
that's set in the Inspector?

- A. `[SerializeField] float JumpHeight;`
- B. `[SerializeField] float jump_height;`
- C. `[SerializeField] float jumpHeight;`
- D. `[SerializeField] float JUMPHEIGHT;`

**Q28.** (3.5) Which method will Unity call every frame?

- A. `void update()`
- B. `void Update()`
- C. `void OnUpdate()`
- D. `void UPDATE()`

**Q29.** (3.6) Which comment describes this code accurately?

```csharp
// ???
if (health <= 0)
{
    EnterState(State.Dead);
}
```

- A. `// Dies when health goes below zero.`
- B. `// Dies when no health is left.`
- C. `// Loses one health, and dies at zero.`
- D. `// Dies every frame.`

**Q30.** (3.6) Which comment describes the last line inside the `if`?

```csharp
if (isRollPressed && Time.time >= nextRollTime)
{
    StartRoll();
    nextRollTime = Time.time + 0.4f;
}
```

- A. `// Rolls every 0.4 seconds.`
- B. `// The next roll can start 0.4 seconds from now, at the earliest.`
- C. `// The roll lasts 0.4 seconds.`
- D. `// Waits 0.4 seconds, then rolls.`

**Q31.** (4.1) In which window do you add keyframes and Animation Events to the selected
GameObject's clips?

- A. Animator
- B. Animation
- C. Inspector
- D. Timeline

**Q32.** (4.1) Which window lists every GameObject in the open scene, and shows which
ones are children of which?

**Q33.** (4.2) Double-clicking a script opens it in the wrong code editor. Where do you
change that?

**Q34.** (4.2) After you choose a new code editor there, it doesn't understand your
project: no colours, no suggestions. Which button on the same page helps?

**Q35.** (4.3) An **Attack** clip, with Loop Time off, should play once, then go back
to **Idle** by itself. Which settings does the transition Attack → Idle need?

- A. Has Exit Time on, Exit Time 1, no conditions, Transition Duration 0.
- B. Has Exit Time off, no conditions.
- C. Has Exit Time off, and a Trigger condition `Idle`.
- D. Has Exit Time on, Exit Time 0.

**Q36.** (4.3) Run → Idle has the condition `Speed` Less `0.1`, with Has Exit Time on
and an Exit Time of 1. The Run clip lasts one second, and loops. What does the player
see when they let go of the run key, and what's the fix?

**Q37.** (4.4) Which parameter type fits each one best?

1. the character is standing on the ground (true for a while)
2. the character has just been hurt (happens once)
3. how fast the character is running
4. which of six states an enemy's code is in

**Q38.** (4.4) An Any State → Hurt transition has **Can Transition To Self** on. While
the player touches an enemy, code calls `animator.SetTrigger("Hurt")` every frame. What
does the player see, and which setting fixes it?

## Answers

| Q | Answer | Why | Review |
| --- | --- | --- | --- |
| 1 | B | A prints the words; C has no spaces: `Coins: 12of30`; D prints `of total` as text. | Level 1: strings |
| 2 | `2:05` | 125 seconds is 2 whole minutes and 5 seconds; `:00` pads the seconds to two digits. | {{ref:gameui}} |
| 3 | `game` | The coin's **Game** field was left empty (**None**) in the Inspector. | {{ref:errors}} |
| 4 | B | `GetComponent` found nothing, so it returned `null`. In the Editor the exception is a `MissingComponentException` that names the Animator; in a built game, a `NullReferenceException`. A gives a warning, not an exception; both strings and hashes work; a disabled component is still there. | {{ref:errors}} |
| 5 | B | A float isn't a `Vector2` (A); `AddForce` wants a `Vector2` (C); D doesn't compile: one part of `transform.position` can't be set alone. | Level 2: Rigidbody 2D |
| 6 | B | A doesn't compile, for the same reason as Q5's D; C and D don't exist. | {{ref:animwindow}} |
| 7 | `3 apple` | `key apple` → `key apple coin` → `apple coin` → `map apple coin`. | Level 2: lists |
| 8 | B | `[SerializeField]` shows a private field. A is public; C doesn't show; `static` fields don't show. | {{ref:naming}} |
| 9 | A | The return type comes first, then the name, then each parameter's type and name. | Level 2: methods |
| 10 | A | An event passes at most one value: a float, int, string, enum, Object or AnimationEvent. Not two, not a `Vector2`, not a `bool`. | {{ref:animevents}} |
| 11 | B | The condition is a Trigger, and the machine is in Idle, where the arrow starts. | {{ref:animcode}} |
| 12 | A | `(int)State.Hurt` is 4. D is Dead's number; the other calls don't match an Int. | {{ref:enemies}} |
| 13 | B | `isPressed` is true on every frame it's held; `wasReleasedThisFrame` is the frame it comes up. | Level 2: input |
| 14 | — | On a phone, or anything with no keyboard, `Keyboard.current` is `null`, and using it would throw a `NullReferenceException`. | Level 2: input |
| 15 | `True`, then `False` | `&&` is worked out before `\|\|`: `(false && true) \|\| true` is true. The brackets change it: `false && …` is false. | Level 1: logic |
| 16 | `4` | 1 is added; 2 is skipped; 3 is added; 4 is skipped; at 5, `break`. | {{ref:reading}} |
| 17 | B | A slider sends a `float`, and a listener returns nothing. | Level 2: UI events |
| 18 | B | Disconnect in `OnDisable`, the pair of `OnEnable`. | {{ref:gameui}} |
| 19 | `Awake`, `OnEnable`, `Start`, `Update` | `Start` waits until just before the first `Update`. | Level 2: event functions |
| 20 | C | `LateUpdate` runs after every `Update`, so the player has already moved. | Level 2: event functions |
| 21 | B | A `float` doesn't fit in an `int` without a cast (CS0266). A `float` fits in a `double` (C), and an `int` in a `float` (A). | {{ref:errors}} |
| 22 | — | `score * bonus` is a `float`, which doesn't fit in an `int`. Make `total` a `float`, or round it: `Mathf.RoundToInt(score * bonus)`. | {{ref:errors}} |
| 23 | B | No modifier means `private`: only `Door` can call `Open` (CS0122). Make it `public void Open()`. | {{ref:errors}} |
| 24 | — | The Console says the event has no receiver, and nothing is called. An event only calls scripts on the GameObject with the Animator: move the method there. | {{ref:animevents}} |
| 25 | B | A `struct` built on `IComponentData`. | {{ref:classes}} |
| 26 | — | 1 a plain C# class; 2 a ScriptableObject, an asset; 3 an ECS system; 4 a MonoBehaviour, a component. | {{ref:classes}} |
| 27 | C | Fields are camelCase. A looks like a property; B uses snake case; D looks like a constant from another language. | {{ref:naming}} |
| 28 | B | Event functions are called by their exact name. The others compile, and are never called. | {{ref:naming}} |
| 29 | B | `<= 0` includes 0, which A leaves out; nothing is subtracted (C); and it's only when health is 0 or less (D). | {{ref:reading}} |
| 30 | B | It's a cooldown: the earliest time the next roll may start. | {{ref:reading}} |
| 31 | B | The Animation window edits clips; the Animator window edits the state machine. | {{ref:animwindow}} |
| 32 | the Hierarchy | | Level 0 |
| 33 | **Edit → Preferences** (on a Mac, **Unity → Settings**) → **External Tools** → **External Script Editor** | | Level 0 |
| 34 | **Regenerate project files** | It rewrites the files the code editor reads to understand the project. | Level 0 |
| 35 | A | B is ignored by Unity: a transition needs a condition or an exit time. C needs code to fire `Idle`. D leaves the moment Attack starts. | {{ref:animator}} |
| 36 | — | He keeps running until the Run clip's loop ends, up to a second, then idles. Turn Has Exit Time **off**. | {{ref:animator}} |
| 37 | — | 1 Bool; 2 Trigger; 3 Float; 4 Int. | {{ref:animator}} |
| 38 | — | Hurt restarts every frame, so it never gets past its first frame. Turn **Can Transition To Self** off (and fire the trigger only when the hurt starts). | {{ref:animator}} |

## Practice paper

Twenty questions, in the exam's styles and from all four of its groups. Give yourself
**30 minutes**, with no book and no Unity, then mark it with the answers that follow.
14 or more right is a good sign you're ready; under 14, go back to the chapters the
answers name, and try again a few days later.

**P1.** `int health = 4;` and `const int MaxHealth = 5;`. Which line prints
`Health: 4/5`?

- A. `Debug.Log($"Health: {health}/{MaxHealth}");`
- B. `Debug.Log("Health: " + health / MaxHealth);`
- C. `Debug.Log($"Health: {health / MaxHealth}");`
- D. `Debug.Log("Health: {health}/{MaxHealth}");`

**P2.** What does this print?

```csharp
Dictionary<string, int> keys = new Dictionary<string, int>();
keys["gold"] = 1;
keys["silver"] = 2;
keys["gold"] += 2;
Debug.Log(keys["gold"] + keys.Count);
```

**P3.** A door's Animator has Closed → Opening, with the condition `IsOpen` true. Which
line opens the door?

- A. `animator.SetTrigger("IsOpen");`
- B. `animator.SetBool("IsOpen", true);`
- C. `animator.SetInteger("IsOpen", 1);`
- D. `animator.Play("IsOpen");`

**P4.** Which line doesn't compile?

- A. `Vector2 jump = new Vector2(0f, 12f);`
- B. `bool isLit = "true";`
- C. `float half = 1 / 2f;`
- D. `int count = (int)4.8f;`

**P5.** A class `Wallet` has `public int Coins { get; private set; }`. Another script
writes `wallet.Coins = 10;`. What happens?

- A. `Coins` becomes 10.
- B. A compile error: the set accessor is inaccessible.
- C. A `NullReferenceException`.
- D. Nothing: the line is skipped.

**P6.** Which is the conventional name for a `static readonly` hash of the Animator
parameter `Grounded`?

- A. `groundedHash`
- B. `GroundedHash`
- C. `GROUNDED_HASH`
- D. `_groundedHash`

**P7.** Which comment describes this line accurately?

```csharp
spriteRenderer.flipX = moveInput < 0f;
```

- A. `// Flips the picture every frame.`
- B. `// Faces left while moving left, and right otherwise.`
- C. `// Faces left while moving right.`
- D. `// Turns the character round when it stops.`

**P8.** A door has three clips: **Closed** (one frame), **Opening** (Loop Time off) and
**Open** (one frame). Which transition should have Has Exit Time on?

- A. Closed → Opening
- B. Opening → Open
- C. Open → Closed
- D. All three

**P9.** Which is true of a **Trigger** parameter?

- A. It holds a number between 0 and 1.
- B. It stays true until code sets it to false.
- C. It switches itself off as soon as a transition uses it.
- D. It can only be used by Any State transitions.

**P10.** What does this print?

```csharp
int lives = 2;
switch (lives)
{
    case 0:
        Debug.Log("Game over");
        break;
    case 1:
        Debug.Log("Last life");
        break;
    default:
        Debug.Log("Lives: " + lives);
        break;
}
```

**P11.** `KnightHealth.Start` throws a `NullReferenceException` on the line
`healthBar.SetHealth(Health, MaxHealth);`. What's `null`?

- A. `Health`
- B. `MaxHealth`
- C. `healthBar`
- D. `SetHealth`

**P12.** Two colliders bump into each other. Neither has **Is Trigger** ticked, and one
has a Rigidbody 2D. Which event function runs?

- A. `OnTriggerEnter2D(Collider2D other)`
- B. `OnCollisionEnter2D(Collision2D collision)`
- C. `OnCollisionEnter(Collision collision)`
- D. `OnBump2D()`

**P13.** With the Input System, which reads where the mouse or a finger is, in screen
pixels?

- A. `Pointer.current.position.ReadValue()`
- B. `Mouse.position`
- C. `Touchscreen.current.press.isPressed`
- D. `Pointer.current.press.wasPressedThisFrame`

**P14.** Which method can listen to a Toggle's `onValueChanged`?

- A. `void OnToggled(float value)`
- B. `void OnToggled(bool isOn)`
- C. `bool OnToggled()`
- D. `void OnToggled(string text)`

**P15.** Which line plays a sound once, without stopping a sound that's already playing
on the same Audio Source?

- A. `audioSource.Play();`
- B. `audioSource.PlayOneShot(clip);`
- C. `audioSource.clip = clip;`
- D. `audioSource.Stop();`

**P16.** Which of these can't be added to a GameObject with **Add Component**?

- A. Rigidbody 2D
- B. a MonoBehaviour script
- C. a ScriptableObject
- D. Animator

**P17.** Which pair of methods can both be in one class?

- A. `void Heal()` and `int Heal()`
- B. `void Heal(int amount)` and `void Heal(int points)`
- C. `void Heal()` and `void Heal(int amount)`
- D. `void Heal(int amount)` and `int Heal(int amount)`

**P18.** While the game plays, where can you watch which state an Animator is in?

- A. the Animator window, with the GameObject selected
- B. the Console
- C. the Project window
- D. the Animation window's Curves view

**P19.** Code calls `animator.SetFloat("Speed", 5f)` every frame, but the knight never
runs. The controller's parameter is called `speed`. What does the Console show?

**P20.** A slime's **Dead** clip has an Animation Event that calls `OnDeathFinished`.
Its script declares `public void OnDeathFinished(Vector2 where)`. What happens, and
what's the fix?

## Practice paper answers

| P | Answer | Why | Objective |
| --- | --- | --- | --- |
| 1 | A | B and C divide two `int`s first: `4 / 5` is 0. D has no `$`, so it prints the braces. | 1.1 |
| 2 | `5` | `keys["gold"]` is 3, and there are 2 keys: 3 + 2 is 5, a number, not text. | 2.1 |
| 3 | B | The condition reads a Bool. | 2.3 |
| 4 | B | Text isn't a `bool`. C is 0.5, a `float` division; D is 4. | 3.2 |
| 5 | B | Only `Wallet` can set `Coins` (CS0272). | 3.3 |
| 6 | B | `static readonly` values are PascalCase. | 3.5 |
| 7 | B | `moveInput < 0f` is true while moving left. | 3.6 |
| 8 | B | Opening must finish first; the others wait for a parameter. | 4.3 |
| 9 | C | A is a Float; B is a Bool; any transition can use a trigger. | 4.4 |
| 10 | `Lives: 2` | No case is 2, so `default` runs. | 2.5 |
| 11 | C | Only an object can be `null`. The **Health Bar** field is empty. | 1.2 |
| 12 | B | A collision, not a trigger, and the 2D version. | 3.1 |
| 13 | A | The pointer is the mouse or a finger, whichever is in use. | 2.4 |
| 14 | B | A toggle sends a `bool`. | 2.6 |
| 15 | B | `PlayOneShot` mixes a sound over whatever is playing. | 1.3 |
| 16 | C | A ScriptableObject is an asset, not a component. | 3.4 |
| 17 | C | An overload needs different parameter types or numbers: not other names (B), not another return type (A, D). | 2.2 |
| 18 | A | The current state has a moving blue bar. | 4.1 |
| 19 | `Parameter 'Speed' does not exist.` | Parameter names are exact, capitals included. | 2.3 |
| 20 | — | An event can't pass a `Vector2`: the Console shows `Failed to call AnimationEvent OnDeathFinished…`, and the method isn't called. Give it no parameter. | 3.3 |

## Level 3 cheat sheet

**A state machine in code**

```csharp
enum State { Idle, Walk, Hurt }        // the states

State state;                           // the current one
float stateStartTime;

void Update()
{
    switch (state)                     // each state's work, every frame
    {
        case State.Idle:
            break;
        case State.Walk:
            break;
        case State.Hurt:
            break;
    }
}

void EnterState(State next)            // the only place the state changes
{
    state = next;
    stateStartTime = Time.time;
    animator.SetInteger(StateHash, (int)state);
}
```

**Animator parameters**

| Type | Code | A condition asks | For |
| --- | --- | --- | --- |
| Float | `SetFloat(SpeedHash, 4f)` | Greater, Less | speeds |
| Int | `SetInteger(StateHash, 2)` | Greater, Less, Equals, NotEqual | the code's state |
| Bool | `SetBool(GroundedHash, true)` | true, false | things that stay true |
| Trigger | `SetTrigger(HurtHash)` | fired | things that happen once |

`static readonly int SpeedHash = Animator.StringToHash("Speed");` Names are exact.

**Transitions for sprite animation**

| Setting | Value |
| --- | --- |
| Has Exit Time | off, except out of one-shot clips (attack, hurt, roll) |
| Transition Duration | 0 |
| Can Transition To Self (Any State) | off |

**Animation Events:** a method on a script **on the same GameObject as the Animator**,
the exact name, `void`, with no parameter or one `float`, `int`, `string`, `enum` or
`Object`.
An event on a clip that's cut short never fires.

**Naming**

| PascalCase | camelCase |
| --- | --- |
| classes, methods, properties, enums and their values, `const`, `static readonly` | fields, local variables, parameters |

Booleans read as questions: `isGrounded`, `hasKey`, `IsDead`.

**Kinds of classes**

| `: MonoBehaviour` | `[System.Serializable]` class | `: ScriptableObject` | `struct … : IComponentData` |
| --- | --- | --- | --- |
| a component | data inside a component | an asset | ECS |

**UI and pausing:** a health bar is a **Filled** Image, `fillAmount = (float)health / max`.
`Time.timeScale = 0` stops physics, Animators and `WaitForSeconds`; `Update` and the UI
keep running. Set it back to 1 on Restart.

## Before Level 4: can you…

- Write a state machine with an `enum`, a `switch` and an enter step, without looking?
- Make sprite-frame clips and property clips in the Animation window, at the right
  sample rate?
- Build an Animator Controller from a set of clips: a default state, transitions with
  conditions, and the right **Has Exit Time** on each?
- Set Float, Int, Bool and Trigger parameters from code, with hashes, and say which
  call makes a given state play?
- Add Animation Events, and fix one that has no receiver?
- Make an enemy whose Animator follows its code through an Int, and give a second
  enemy the same machine with other clips through an Override Controller?
- Make a health bar that slides, a panel for each part of the game, and a pause that
  stops everything but the menu?
- Name everything by the conventions, pick the comment that matches the code, and spot
  a wrong type or a private member used from outside?
- Tell an ECS class from a MonoBehaviour, a plain class and a ScriptableObject?
- Score 14 or more on the practice paper in 30 minutes?

If yes, you're ready for the **Unity Certified User: Programmer** exam, and for
Level 4, where your games grow up: several scenes, saved progress, interfaces,
ScriptableObjects of your own, the Input Actions asset, and code you didn't write.
