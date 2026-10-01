## C# — Reading Code

**Goal:** you can read a script you didn't write, say what it does, trace what it prints,
and pick the comment that describes it accurately. Exam objective U 3.6 asks for that
last one, and many other questions need the rest.

### Idea — read in this order

A script is easier to read in the order Unity uses it than from top to bottom:

1. **The class's name and its comment:** what is this for?
2. **The fields:** what does it remember, and what does it get from the Inspector?
   `[SerializeField]` fields are settings and references; the others are its state.
3. **`Awake` and `Start`:** what does it set up?
4. **`Update`**, and the other event functions: what does it do every frame, or when
   something touches it?
5. **The methods they call**, one at a time, as you meet them.

At each method, ask three questions: *what goes in* (its parameters and the fields it
reads), *what changes* (the fields it sets), and *what comes out* (what it returns, or
calls on other objects).

### Idea — trace it on paper

To be sure what code does, run it by hand with a table: one column per variable, one row
per step.

```csharp
int coins = 0;
int[] chests = { 3, 0, 5, 2 };
for (int i = 0; i < chests.Length; i++)
{
    if (chests[i] == 0)
    {
        continue;
    }
    coins += chests[i];
    if (coins > 6)
    {
        break;
    }
}
Debug.Log(coins);
```

| `i` | `chests[i]` | what happens | `coins` |
| --- | --- | --- | --- |
| 0 | 3 | add | 3 |
| 1 | 0 | `continue`: skip the rest of this turn | 3 |
| 2 | 5 | add, and 8 > 6: `break` out of the loop | 8 |

```
8
```

The last chest is never opened: `break` left the loop first. Tracing finds that kind of
thing; reading quickly doesn't.

### Idea — what makes a comment accurate

A comment is accurate when it says what the code **does**: not what it was meant to do,
not what it did last week, not more and not less.

```csharp
using UnityEngine;

public class Healer : MonoBehaviour
{
    [SerializeField] int maxHealth = 5;
    int health = 2;

    // ???
    public void Heal(int amount)
    {
        health = Mathf.Min(health + amount, maxHealth);
    }
}
```

Which comment belongs above `Heal`?

- A. `// Adds amount to health, but never above maxHealth.`
- B. `// Sets health to the smaller of amount and maxHealth.`
- C. `// Adds amount to health, and raises maxHealth if needed.`
- D. `// Heals the player to full health.`

**A.** B misses the `health +`: it describes `Mathf.Min(amount, maxHealth)`. C describes
`Mathf.Max`, and the code never changes `maxHealth`. D is only true when `amount` is big
enough. Each wrong answer is close to right: that's how exam distractors are made. Read
every word of each option against the code.

| A comment is wrong when it… | For example |
| --- | --- |
| gets a comparison the wrong way round | says "at least" for `<` |
| swaps who does what | says the enemy hurts the player, when the player hurts the enemy |
| gets the timing wrong | says "every frame" for code in `Start`, or "once" for code in `Update` |
| promises more than the code does | says "and plays a sound", with no sound in the code |
| describes code that was there before | the classic, after a change that wasn't followed by the comment |

### Idea — another one

```csharp
using UnityEngine;

public class Patroller : MonoBehaviour
{
    [SerializeField] float patrolDistance = 2f;
    Vector2 startPosition;
    float direction = 1f;

    void Awake()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // ???
        if (Mathf.Abs(transform.position.x - startPosition.x) > patrolDistance)
        {
            direction = -direction;
        }
        transform.Translate(direction * 2f * Time.deltaTime, 0f, 0f);
    }
}
```

- A. `// Turns round every patrolDistance seconds.`
- B. `// Turns round when it's further than patrolDistance from where it started, on either side.`
- C. `// Turns round when it reaches the start position.`
- D. `// Stops when it's further than patrolDistance from the start.`

**B.** `Mathf.Abs` makes the distance positive on both sides. A confuses distance with
time; C would test the distance against 0; D: nothing stops, `direction` flips.

> **Watch out:** this patroller has a bug that the comment won't show. If it overshoots
> by a little, it can still be over the distance on the next frame, flip again, and
> shake on the spot. Reading the code, not only the comment, is how you find that. The
> fix: turn round only if it's heading away (`direction` and the offset have the same
> sign).

### Idea — the three kinds of comment

| Kind | Looks like | Use |
| --- | --- | --- |
| line comment | `// up to the end of the line` | almost every comment |
| block comment | `/* across several lines */` | rarely: to switch off code for a moment |
| documentation comment | `/// <summary>Heals the player.</summary>` | in libraries; your IDE shows it when you hover over the method |

Good comments say **why**: `// Moving up is never standing: that's a jump just starting`
tells you something the code alone can't. A comment that repeats the code
(`health = 0; // set health to 0`) only adds something to keep up to date.

### Do it

1. Trace the coin loop with `{ 0, 4, 0, 4 }` and with `{ 7, 1 }`. Write the tables, then
   run them in a Practice script.
2. Write a wrong comment of each kind in the table above for the `Heal` method.
3. Fix the patroller's shake: turn round only when it's past the distance **and**
   heading away from the start.
4. Open a finished script from your current game, cover its comments with a piece of
   paper, and write your own for each method. Compare.

### Challenge

Swap a script with a partner, without its comments. Each of you writes a comment above
every method of the other's script. Then compare yours with the real ones: where you
differ, who's right? Run the code to settle it.
