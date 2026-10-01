## C# — Driving the Animator from Code

**Goal:** you can set an Animator's parameters from a script, and you can say which call
makes a given state play. Exam objective U 2.3 asks exactly that.

### Idea — code sets parameters, the Animator chooses states

Your script doesn't usually tell the Animator *which state to play*. It tells it what's
true right now, through the parameters ({{ref:animator}}), and the transitions you drew
choose the state. That keeps the decisions in one place: change a transition in the
Animator window, and no code changes.

| Parameter type | The call | Example |
| --- | --- | --- |
| Float | `SetFloat(name, value)` | `animator.SetFloat("Speed", 4.5f);` |
| Int | `SetInteger(name, value)` | `animator.SetInteger("State", 2);` |
| Bool | `SetBool(name, value)` | `animator.SetBool("IsOpen", true);` |
| Trigger | `SetTrigger(name)` | `animator.SetTrigger("Jump");` |
| Trigger | `ResetTrigger(name)` | `animator.ResetTrigger("Jump");` clears it, unused |

Each has a matching getter, such as `GetFloat("Speed")` and `GetBool("IsOpen")`, to
read a value back.

### Idea — a first script

Add an Animator and a controller with a Bool `IsOpen` and a Trigger `Next` to an
object, then give it this:

```csharp
using UnityEngine;
using UnityEngine.InputSystem;

public class Practice : MonoBehaviour
{
    [SerializeField] Animator animator;

    void Update()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard == null)
        {
            return;
        }

        // A Bool can follow something every frame: open while O is held.
        animator.SetBool("IsOpen", keyboard.oKey.isPressed);

        // A Trigger is fired once, when something happens.
        if (keyboard.nKey.wasPressedThisFrame)
        {
            animator.SetTrigger("Next");
            Debug.Log("Next!");
        }
    }
}
```

Drag the object's Animator into the **Animator** field. While it plays, watch the
**Parameters** tab: `IsOpen` ticks and unticks as you hold **O**, and `Next` lights up
for a moment each time you press **N**.

### Idea — which call makes a state play?

To answer, follow the arrow **into** the state and read its condition:

| The transition into the state has… | The call that makes it fire |
| --- | --- |
| `Speed` Greater `0.1` | `SetFloat("Speed", 3f)`: any number over 0.1 |
| `State` Equals `2` | `SetInteger("State", 2)` |
| `IsOpen` true | `SetBool("IsOpen", true)` |
| `Jump` (a Trigger) | `SetTrigger("Jump")` |
| no condition, Has Exit Time on | no call: it fires when the previous clip ends |

And the machine must already be in the state the arrow starts from. If the only arrow
into **Jump** starts at **Idle**, then `SetTrigger("Jump")` while running does nothing,
until the machine is back in Idle: then the trigger, still set, fires the jump.

> **Watch out:** a trigger that nobody uses stays set. Press jump in the air, and the
> knight may jump the moment he lands, long after you pressed. When a trigger shouldn't
> wait, fire it only when it can be used, or clear it with `ResetTrigger`.

### Idea — names are exact

Parameter names are **strings**, matched letter for letter, capitals included. A
mistake isn't a compile error. It's a warning in the Console when that line runs:

```
Parameter 'speed' does not exist.
```

And nothing animates. The same goes for the wrong call: `SetBool` on a Float parameter
changes nothing either, and the warning says so:

```
Parameter type 'Speed' does not match.
```

### Idea — hashes: names turned into numbers

Looking up a string every frame is slow, and a typo can hide in any of the places you
typed it. `Animator.StringToHash` turns a name into an `int` once, and every `Set` and
`Get` call also accepts that number:

```csharp
using UnityEngine;

public class RunAnimation : MonoBehaviour
{
    static readonly int SpeedHash = Animator.StringToHash("Speed");
    static readonly int GroundedHash = Animator.StringToHash("Grounded");

    [SerializeField] Animator animator;
    [SerializeField] Rigidbody2D body;

    void Update()
    {
        animator.SetFloat(SpeedHash, Mathf.Abs(body.linearVelocity.x));
        animator.SetBool(GroundedHash, Mathf.Abs(body.linearVelocity.y) < 0.01f);
    }
}
```

- `static`: one number for the whole class, worked out once, however many objects use
  the script.
- `readonly`: it can't be changed by mistake later.
- PascalCase names ending in `Hash`, as for every `static readonly` value
  ({{ref:naming}}).

The name is still a string, so a typo in `"Speed"` still breaks it, but now the string
is written once, at the top of the script, where it's easy to check against the
Animator window.

A hash has one catch. Unity only receives the number, so its warning can't tell you the
name:

```
Parameter 'Hash 254213878' does not exist.
```

Click the warning: the stack trace under it names your script and the line that called
`SetFloat`. That line's hash comes from one of the `StringToHash` lines at the top:
check their spelling against the Animator window.

### Idea — asking the Animator where it is

Usually you don't need to know: your own code knows what it told the Animator. When you
do (in a test, or to wait for an animation), ask for the current state of layer 0:

```csharp
using UnityEngine;

public class StateReport : MonoBehaviour
{
    [SerializeField] Animator animator;

    void Update()
    {
        AnimatorStateInfo info = animator.GetCurrentAnimatorStateInfo(0);
        if (info.IsName("Run"))
        {
            // normalizedTime counts the clip's plays: 0.5 is halfway, 2.25 is a quarter into the third.
            Debug.Log($"Running, {info.normalizedTime:0.00} plays in");
        }
    }
}
```

### Idea — jumping straight to a state, and starting again

Two calls skip the transitions altogether. Use them for resets, not for normal play:

| Call | Does |
| --- | --- |
| `animator.Play("Idle")` | jumps straight into the state called `Idle`; the parameters keep their values |
| `animator.Rebind()` | puts the whole Animator back as it was at the start: the default state, every parameter at its default |

A state with no way out, such as **Dead**, needs one of these when the game restarts.

> **Watch out:** `Rebind` also remembers the values that animated properties have
> *right now*, as the ones to go back to. If a death clip has faded the sprite to
> nothing, set its colour back first, then call `Rebind`. In the other order, the
> character comes back invisible.

### Do it

1. Make the Practice script above work, with the door or traffic-light controller from
   {{ref:animator}}.
2. Misspell `"IsOpen"` as `"isOpen"`, play, and read the warning. Put it right.
3. Change the script to use hashes for both parameters.
4. Give the traffic light an Int parameter `Colour` (0 green, 1 yellow, 2 red), with an
   Any State transition into each colour on `Colour` Equals its number. Set it from the
   keys **1**, **2** and **3** with `SetInteger`.

### Challenge

Press **N** three times quickly while the light is changing. How many changes do you
get? Then fire `Next` only when the current state's clip has finished
(`normalizedTime >= 1`), and try again.
