## C# — State Machines with enum and switch

**Goal:** you can write a state machine in C#: an `enum` of states, a field that holds
the current one, a `switch` that does each state's work, and an enter step that runs
once as each state begins.

### Idea — one state at a time

Lots of things in a game are always in exactly one of a few **states**:

| Thing | Its states |
| --- | --- |
| a traffic light | Green, Yellow, Red |
| a door | Closed, Opening, Open, Closing |
| an enemy | Patrol, Chase, Attack, Hurt, Dead |
| the game itself | Start, Playing, Paused, Won, Lost |

A **state machine** is code built round that idea: it knows its current state, does
that state's work, and follows rules to move from one state to another. You can draw
one before you write it:

```
           3 seconds             1 second
   Green ───────────→ Yellow ───────────→ Red
     ↑                                      │
     └──────────────────────────────────────┘
                     3 seconds
```

The Animator is a state machine too ({{ref:animator}}). Writing one in code lets your
scripts make the same kind of decisions.

### Idea — the three parts

```csharp
using UnityEngine;

public class TrafficLight : MonoBehaviour
{
    // 1. The states: an enum, as in Level 1.
    enum State { Green, Yellow, Red }

    // 2. The current state, and when it began.
    State state;
    float stateStartTime;

    void Start()
    {
        EnterState(State.Green);
    }

    // 3. Every frame, the current state does its work, and may move on.
    void Update()
    {
        float timeInState = Time.time - stateStartTime;
        switch (state)
        {
            case State.Green:
                if (timeInState >= 3f)
                {
                    EnterState(State.Yellow);
                }
                break;
            case State.Yellow:
                if (timeInState >= 1f)
                {
                    EnterState(State.Red);
                }
                break;
            case State.Red:
                if (timeInState >= 3f)
                {
                    EnterState(State.Green);
                }
                break;
        }
    }

    // The one place the state changes. Its enter step runs once, on arrival.
    void EnterState(State next)
    {
        state = next;
        stateStartTime = Time.time;
        Debug.Log("Now " + state);
    }
}
```

```
Now Green
Now Yellow
Now Red
Now Green
```

The lines appear 3 seconds, 1 second and 3 seconds apart.

| Part | Job |
| --- | --- |
| the `enum` | names every state, so a typo is a compile error, not a bug |
| the `state` field | holds the one current state |
| the `switch` in `Update` | runs every frame: the current state's work, and its checks for moving on |
| `EnterState` | runs once per change: remember when the state began, play a sound, tell the Animator… |

### Idea — why an enter step

Some things must happen once, when a state begins, not on every frame of it: a sound, a
timer starting, an Animator parameter, switching a collider off. Put them in
`EnterState`, and they happen once, however long the state lasts.

The other rule matters as much: **only `EnterState` changes `state`.** A line like
`state = State.Red;` somewhere else compiles, but it skips the enter step: no timer
starts, no sound plays, and the state's timer is left over from the state before. When
every change goes through one method, there's one place to look when a change goes
wrong, and one line to add when every change should log, or set the Animator.

The `switch` can call a method per state when a state's work grows:

```csharp
using UnityEngine;

public class Lamp : MonoBehaviour
{
    enum State { Off, On, Flickering }

    State state;

    void Start()
    {
        EnterState(State.On);
    }

    void Update()
    {
        switch (state)
        {
            case State.Off:
                break;                  // nothing to do: it waits
            case State.On:
                UpdateOn();
                break;
            case State.Flickering:
                UpdateFlickering();
                break;
        }
    }

    void UpdateOn()
    {
        if (Random.value < 0.001f)
        {
            EnterState(State.Flickering);
        }
    }

    void UpdateFlickering()
    {
        GetComponent<SpriteRenderer>().enabled = Random.value > 0.5f;
    }

    void EnterState(State next)
    {
        state = next;
        Debug.Log("The lamp is " + state);
    }
}
```

A state with nothing to do still gets its own `case` with a comment: then you can see
that it was thought of, not forgotten.

### Idea — the mistakes

| Mistake | What happens |
| --- | --- |
| a `case` without `break` | a compile error: C# won't let one case fall into the next |
| `state = …` outside `EnterState` | the enter step never runs: no sound, a stale timer |
| calling `EnterState` every frame | the enter step runs every frame: the timer never gets past 0 |
| a long `if` / `else if` chain instead of a `switch` | works, but it's easy to test the same state twice, or none |
| a new state added to the `enum` but not to the `switch` | it does nothing, silently. A `default:` case that logs a warning catches it |

### Idea — states and the exam

Exam questions give a state machine, in code or as a drawing, and ask what happens: what
the state is after some events, which line moves it on, or why a state never changes.
Trace it like a table: the state, the time, what each frame checks.

| Time | State | Green's check: `timeInState >= 3f`? |
| --- | --- | --- |
| 0.0 | Green | no |
| 2.9 | Green | no |
| 3.0 | Green → **Yellow** | yes: `EnterState(State.Yellow)` |

### Do it

1. Make the traffic light work: put it on a sprite, and also set the sprite's colour in
   `EnterState` with a `switch` of its own.
2. Add a fourth state, **Off**, entered when you press **O** in any state, and left when
   you press **O** again, back to Green.
3. Break it on purpose: replace one `EnterState(State.Red);` with `state = State.Red;`.
   What goes wrong with the timer, and why?
4. Add `default: Debug.LogWarning("No case for " + state); break;` to the `switch`, add
   a state to the `enum` without a case, and enter it.

### Challenge

Write a door as a state machine: Closed, Opening, Open and Closing. **Space** starts it
opening (only from Closed) and closing (only from Open); Opening and Closing each take a
second, scaling the door's height from 1 to 0 or back. Draw the machine before you
write a line.
