## C# — Enemies as State Machines

**Goal:** you can write an enemy as a state machine in code, and keep its Animator in
step with it, either through an Int that mirrors the code's `enum`, or through
parameters that describe what the enemy is doing.

### Idea — an enemy is a few states and their rules

Before any code, draw the enemy. Here's a guard:

```
                player within 4 units                  player within 1 unit
   Patrol ─────────────────────────→ Chase ─────────────────────────→ Attack
     ↑                                │ ↑                                │
     └── player more than 6 away ─────┘ └──── the attack has finished ───┘
```

Each arrow is a rule in code: a distance, a timer, a health check. Notice the two
distances: the guard notices the player at 4 units but only gives up at 6. With one
number for both, a player standing at the edge makes the guard flip between Patrol and
Chase every frame.

### Idea — the guard in code

```csharp
using UnityEngine;

public class Guard : MonoBehaviour
{
    public enum State { Patrol, Chase, Attack }

    [SerializeField] Transform player;
    [SerializeField] float patrolSpeed = 1.5f;
    [SerializeField] float chaseSpeed = 3f;
    [SerializeField] float noticeRange = 4f;
    [SerializeField] float giveUpRange = 6f;
    [SerializeField] float attackRange = 1f;
    [SerializeField] float attackSeconds = 0.8f;

    State state;
    float stateStartTime;
    float direction = 1f;

    void Start()
    {
        EnterState(State.Patrol);
    }

    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.position);
        switch (state)
        {
            case State.Patrol:
                transform.Translate(direction * patrolSpeed * Time.deltaTime, 0f, 0f);
                if (distance < noticeRange)
                {
                    EnterState(State.Chase);
                }
                break;
            case State.Chase:
                direction = player.position.x < transform.position.x ? -1f : 1f;
                transform.Translate(direction * chaseSpeed * Time.deltaTime, 0f, 0f);
                if (distance < attackRange)
                {
                    EnterState(State.Attack);
                }
                else if (distance > giveUpRange)
                {
                    EnterState(State.Patrol);
                }
                break;
            case State.Attack:
                if (Time.time - stateStartTime >= attackSeconds)
                {
                    EnterState(State.Chase);
                }
                break;
        }
    }

    void EnterState(State next)
    {
        state = next;
        stateStartTime = Time.time;
        Debug.Log("Guard: " + state);
    }
}
```

Put it on a sprite, drag something that moves (with the keyboard) into **Player**, and
walk towards the guard and away:

```
Guard: Patrol
Guard: Chase
Guard: Attack
Guard: Chase
Guard: Patrol
```

> **Note:** this guard moves with `transform.Translate`, so it walks through walls. A
> real enemy has a Rigidbody 2D and sets its velocity, and looks ahead with a short
> raycast before it walks: is there ground in front of it? Then it never chases the
> player off a ledge.

### Idea — two machines that must agree

The guard's code knows its state, and its Animator has states of its own. They must
agree, or the guard attacks while its Animator shows it walking. There are two good
ways to keep them together.

**1. The Animator follows the code.** Give the controller an **Int** parameter, `State`.
Give each Animator state an **Any State** transition with the condition `State`
**Equals** its number, with **Can Transition To Self** off. Then the enter step tells
the Animator, in one line:

```csharp
public class Guard : MonoBehaviour
{
    static readonly int StateHash = Animator.StringToHash("State");

    [SerializeField] Animator animator;
    // … the other fields and methods, as before …

    void EnterState(State next)
    {
        state = next;
        stateStartTime = Time.time;
        animator.SetInteger(StateHash, (int)state);
    }
}
```

`(int)state` turns the enum value into its number. An enum's values are numbered from
0, in the order they're written:

| `State` | `(int)` |
| --- | --- |
| `State.Patrol` | 0 |
| `State.Chase` | 1 |
| `State.Attack` | 2 |

So the code's machine decides, and the Animator plays whatever the code says. This
suits enemies, whose states are decisions.

**2. The Animator decides, from what the code reports.** Give the controller
parameters that describe the enemy, such as a Float `Speed`, a Bool `IsAlert` and a
Trigger `Attack`, and draw normal transitions between its states. The code sets the
parameters every frame or when something happens, and the Animator's own transitions
choose the clip. This suits a player character, whose animation follows its movement:
run when moving, fall when falling.

| | The Animator follows the code (Int) | The Animator decides (parameters) |
| --- | --- | --- |
| Who chooses the state | the code's `switch` | the Animator's transitions |
| Parameters | one Int, `State` | Floats, Bools and Triggers |
| Transitions | one from Any State per state | drawn between the states |
| Best for | enemies and other things that make decisions | characters whose animation follows physics |

> **Watch out:** with the Int, the order of the `enum` *is* the Animator's numbering.
> Put a new state in the middle (`Patrol, Alert, Chase, Attack`) and Chase becomes 2:
> the Animator plays the Attack clip for it. Add new states at the end, or change every
> condition to match.

### Idea — timing with Animation Events

Some changes should wait for the animation itself: an enemy winds up, and only leaps
when its wind-up clip reaches its last frame. An Animation Event ({{ref:animevents}}) on
that frame calls the code, and the code changes state:

```csharp
// … in an enemy with WindUp and Leap states …

// Animation Event: the last frame of the WindUp clip.
public void OnWindUpFinished()
{
    // Something else may have changed the state first, such as a hit.
    if (state == State.WindUp)
    {
        EnterState(State.Leap);
    }
}
```

The `if` matters: if a hit has already sent the enemy to Hurt, the wind-up clip was cut
short, and a late event mustn't jump it back to Leap.

### Idea — many kinds of enemy

| Need | Use |
| --- | --- |
| the same behaviour, other numbers (a tougher, faster version) | **one script**, and a second prefab with other values in the Inspector |
| the same state machine, other pictures | an **Animator Override Controller** (below) |
| different behaviour | a separate script, with its own state machine |

An **Animator Override Controller** is an asset that borrows another controller's whole
state machine, its states, parameters and transitions, and swaps its clips:

1. **Assets → Create → Animation → Animator Override Controller**, and name it.
2. Set its **Controller** to the original Animator Controller. Its Inspector lists every
   clip the original uses.
3. Drag a replacement clip next to each one.
4. Put the Override Controller in the second enemy's **Animator**, where the controller
   goes.

Change a transition in the original, and both enemies get the change.

> **Note:** Level 4 adds two more tools: prefab variants, a prefab that inherits from
> another, and interfaces, so that one script can hit any kind of enemy. Until then, a
> copy of the prefab and an `if` for each kind of script are the honest way.

### Idea — how the exam asks

*An enemy's Animator has an Any State transition into Chase with the condition `State`
Equals `1`. Which line makes it play Chase?*

- A. `animator.SetTrigger("Chase");`
- B. `animator.SetInteger("State", 1);`
- C. `animator.SetFloat("State", 1f);`
- D. `animator.Play("State");`

B: the condition reads an Int, so the call is `SetInteger`, with the number the
condition checks. A fires a trigger that doesn't exist; C uses the wrong type; D jumps
to a state called "State", which isn't there.

### Do it

1. Make the guard work, with a player you move with the arrow keys.
2. Give the guard an Animator with three clips (a colour each is enough: Patrol white,
   Chase yellow, Attack red) and the `State` Int, with an Any State transition into each
   state. Add the `SetInteger` line to `EnterState`.
3. Put `Alert` between `Patrol` and `Chase` in the enum, without changing the Animator.
   What colour does the guard turn when it chases? Put the enum back.
4. Make a second guard prefab that's faster and notices the player from further away,
   with no new code.

### Challenge

Add a **Stunned** state: when the player presses **S** within 2 units, the guard stops
for 1.5 seconds, whatever it was doing, then goes back to Patrol. Draw the new arrows
first. Which states can it be entered from?
