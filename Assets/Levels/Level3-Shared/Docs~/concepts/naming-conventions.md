## C# — Naming Conventions

**Goal:** you can name classes, methods, fields and the rest the way C# and Unity
programmers do, and you can spot a name that breaks the rules. Exam objective U 3.5
asks about exactly this.

### Idea — why names follow rules

Code is read far more often than it's written: by you next week, by your team, and by
the exam. When everyone writes names the same way, a name tells you what kind of thing
it is before you've read anything else. `TakeDamage` is a method, `maxHealth` is a
field, `IsDead` is a property and `State.Chase` is a value of an enum, and you know that
from the letters alone.

C# uses two ways of joining words into one name:

| Style | How | Example |
| --- | --- | --- |
| **PascalCase** | every word starts with a capital, the first one too | `KnightController`, `TakeDamage`, `MaxHealth` |
| **camelCase** | like PascalCase, but the first word is all small letters | `moveSpeed`, `isGrounded`, `coinCount` |

Other languages use other styles, such as `move_speed` (snake case) or `MOVE_SPEED`.
You'll meet them in other places, but normal C# names don't use underscores or capitals
all the way through.

### Idea — which style goes where

| What | Style | Examples |
| --- | --- | --- |
| Classes, structs and enums | PascalCase | `Slime`, `HealthBar`, `GameState` |
| Enum values | PascalCase | `State.Patrol`, `GameState.Playing` |
| Methods | PascalCase, usually a verb | `Jump()`, `TakeDamage()`, `ResetLevel()` |
| Properties | PascalCase | `Health`, `IsDead`, `IsPlaying` |
| Fields, private or `[SerializeField]` | camelCase | `jumpSpeed`, `groundMask`, `health` |
| Local variables and parameters | camelCase | `toPlayer`, `amount`, `fromX` |
| `const` and `static readonly` fields | PascalCase | `MaxHealth`, `SpeedHash` |
| Interfaces (Level 4) | PascalCase, starting with `I` | `IDamageable` |

The rule underneath: anything other scripts can use from outside (a class, a method, a
property, a constant) gets a capital. The things that live inside a class, or inside
one method, start small.

> **Note:** you'll see other styles for private fields in other people's code:
> `_health`, or `m_Health` (Unity's own engine code uses `m_`, which is why the
> Animation window lists properties such as `m_Sprite` and `m_Color`). They're
> conventions too, of other teams. This course uses plain camelCase, and so does
> the exam.

### Idea — meaningful names

A name should say what the thing is for, so that nobody needs a comment to explain it.

| Weak | Better | Why |
| --- | --- | --- |
| `spd` | `runSpeed` | whole words, and which speed |
| `t` | `stateStartTime` | what the time is of |
| `flag` | `isGrounded` | a bool reads as a yes/no question |
| `DoStuff()` | `ResetLevel()` | a method says what it does, with a verb |
| `slime2` | `purpleSlime` | what makes it different, not its number |
| `delay` | `delaySeconds` | the unit, when it isn't obvious |

- **Booleans** read as a question with a yes/no answer: `isGrounded`, `hasKey`,
  `canJump`, `IsDead`.
- **Methods** start with a verb: `Jump`, `OpenDoor`, `AddCoin`, `TakeDamage`.
- **Counts** say what they count: `coinCount`, `livesLeft`.
- **Single letters** are fine for a loop counter (`i`) and for short maths (`x`, `y`),
  and nowhere else.

### Idea — where Unity cares about exact names

C# itself doesn't care which style you use: `void jump()` compiles. Unity does, in
four places, because it finds things **by name**:

| Where | The name must be | What happens if it's wrong |
| --- | --- | --- |
| Event functions | exactly `Start`, `Update`, `OnTriggerEnter2D`… | a method called `update` compiles, and Unity never calls it |
| A MonoBehaviour's file | the same as its class: `Slime.cs` holds `class Slime` | Unity can't add the script to a GameObject |
| Animator parameters | exactly as typed in the Animator: `"Speed"` | the Console warns that the parameter doesn't exist, and nothing animates |
| Animation Events | exactly the method's name | the Console says the event has no receiver |

> **Watch out:** a wrong-case event function is one of the hardest bugs to see,
> because there's no error at all. If `Update` seems never to run, check its spelling
> first.

### Idea — the same class, named badly and well

Both of these compile and do the same thing. Only one is easy to read:

```csharp
using UnityEngine;

public class door_script : MonoBehaviour
{
    [SerializeField] float S = 2f;
    bool o;
    float T;

    public void open()
    {
        o = true;
        T = 0f;
    }

    void Update()
    {
        if (o && T < 1f)
        {
            T += Time.deltaTime * S;
            transform.localScale = new Vector3(1f, 1f - T, 1f);
        }
    }
}
```

```csharp
using UnityEngine;

public class SlidingDoor : MonoBehaviour
{
    [SerializeField] float openSpeed = 2f;
    bool isOpening;
    float openAmount;

    public void Open()
    {
        isOpening = true;
        openAmount = 0f;
    }

    void Update()
    {
        if (isOpening && openAmount < 1f)
        {
            openAmount += Time.deltaTime * openSpeed;
            transform.localScale = new Vector3(1f, 1f - openAmount, 1f);
        }
    }
}
```

Read them side by side. The first class name uses snake case; `S`, `o` and `T` say
nothing; `open()` is a public method with a small letter. In the second, every name
tells you its job, and the code almost reads as a sentence: *if it's opening and the
open amount is under 1…*

### Idea — how the exam asks

Exam questions about naming give you a few lines and ask which one follows Unity's
conventions, or which name is wrong. For example: *which declaration follows the
conventions for a private field set in the Inspector?*

- A. `[SerializeField] float JumpHeight;`
- B. `[SerializeField] float jump_height;`
- C. `[SerializeField] float jumpHeight;`
- D. `[SerializeField] float JUMPHEIGHT;`

The answer is C: a field is camelCase. A looks like a property, B uses snake case, and
D looks like a constant from another language.

### Do it

1. Rename each of these to follow the conventions: a class `player_health`; a method
   `getScore()`; a private field `MaxSpeed`; a bool `dead`; a constant
   `const int max_lives = 3;`; an enum `enum colour { red, green }`.
2. In a `Practice` script, write `void update()` with a `Debug.Log` inside, and press
   **Play**. Nothing appears. Fix the name, and it does.
3. Open one of your own scripts from Level 2 and find three names you'd now write
   differently. Rename them (right-click a name in VS Code → **Rename Symbol** changes
   every use at once).

### Challenge

Write a small class `TreasureChest` with: a `[SerializeField]` number of coins inside, a
bool that says whether it's been opened, a property that other scripts can read but not
change saying the same thing, a constant for the most coins a chest can hold, and a
method that opens it and returns the coins. Name every part by the rules in this
chapter, then ask a partner to guess what each part does from its name alone.
