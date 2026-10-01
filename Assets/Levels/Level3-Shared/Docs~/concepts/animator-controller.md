## C# — The Animator Controller

**Goal:** you can build a state machine in the Animator: states that play clips,
transitions between them, and the parameters and conditions that choose a transition.
Exam objectives U 4.3 and U 4.4 are about exactly this.

### Idea — three things with similar names

| Thing | What it is | Where |
| --- | --- | --- |
| **Animation clip** | how properties change over time (a `.anim` asset) | the Project window |
| **Animator Controller** | the state machine that chooses which clip plays (a `.controller` asset) | the Project window, opened in the **Animator** window |
| **Animator** component | plays a controller on one GameObject | the GameObject's Inspector |

Many GameObjects can share one controller: every slime in a level uses the same one,
and each slime's Animator keeps its own place in it.

### Idea — the Animator window

Open it with **Window → Animation → Animator**, and select a GameObject that has an
Animator. Each **state** is a box, and each state plays one clip (its **Motion**).

| Box | Means |
| --- | --- |
| an orange state | the **default state**: where the machine starts. Right-click another state → **Set as Layer Default State** to change it |
| a grey state | any other state |
| **Entry** (green) | where the machine comes in; its arrow points at the default state |
| **Any State** (blue) | stands for every state at once: a transition from it can fire from wherever the machine is |
| **Exit** (red) | leaves a sub-state machine; you won't need it in Level 3 |

Every clip you create in the Animation window gets its own state, named after the clip.
You can rename a state in its Inspector: the name is what code and the exam refer to.

While the game plays, select the object, and the Animator window shows the current
state with a moving blue bar: the best way to see why an animation isn't playing.

### Idea — parameters

**Parameters** are the controller's own variables, listed on the window's **Parameters**
tab. Click **+** to add one. Code sets them ({{ref:animcode}}), and transitions read them.

| Type | Holds | A condition can ask | Good for |
| --- | --- | --- | --- |
| **Float** | a number with a fraction | **Greater** or **Less** than a value | how fast he runs, how fast he falls |
| **Int** | a whole number | **Greater**, **Less**, **Equals** or **NotEqual** | which of several states the code is in |
| **Bool** | true or false, until it's changed | **true** or **false** | something that stays: grounded, open, lit |
| **Trigger** | a one-off signal | that it has been fired | something that happens once: jump, hurt, die |

A **Trigger** is like a Bool that switches itself off as soon as a transition uses it.
If no transition uses it, it waits, still set, until one can.

### Idea — transitions and conditions

A **transition** is an arrow from one state to another: right-click the first state →
**Make Transition**, then click the second. Select the arrow to see its settings in the
Inspector, and its **Conditions** list at the bottom.

- **Several conditions on one transition** must all be true: *AND*.
- **Several transitions out of one state** are checked in their order in the list, and
  the first that's ready wins: *OR*.
- **A transition with no conditions** is only allowed with Has Exit Time on (below):
  then it fires when the clip reaches its exit time.

| Transition | Conditions | Fires when… |
| --- | --- | --- |
| Idle → Run | `Speed` Greater `0.1` | the speed goes over 0.1 |
| Idle → Jump | `Grounded` false, **and** `VerticalSpeed` Greater `0.1` | he leaves the ground going up |
| Any State → Hurt | `Hurt` (a trigger) | code fires `Hurt`, whatever state he's in |

### Idea — the settings that change how a transition behaves

| Setting | Means | For sprite animation |
| --- | --- | --- |
| **Has Exit Time** | the transition waits until the clip has played to its **Exit Time** | **on** only after one-shot clips (an attack, a hurt), so they finish; **off** everywhere else, or every change waits for the clip to end |
| **Exit Time** | how far through the clip, where 1 is the end | `1` |
| **Fixed Duration** | the duration below is in seconds (on) or in parts of the clip (off) | on |
| **Transition Duration** | how long the two clips blend together | `0`: two drawings can't blend, so blending only delays the change |
| **Transition Offset** | where in the next clip to start | `0` |
| **Interruption Source** | whether another transition can cut this one short | `None` when the duration is 0 |
| **Can Transition To Self** (Any State only) | the transition may fire even when the machine is already in that state | **off**, or a held key or a parameter that stays true restarts the clip every frame |

> **Watch out:** **Has Exit Time** is on by default when you make a transition. Left on
> between Idle and Run, the knight keeps idling until the Idle clip ends, and running
> feels late. It's the most common Animator mistake, and exam questions about it are
> common too.

### Idea — the state's own settings

Select a state to see them:

| Setting | Means |
| --- | --- |
| **Motion** | the clip it plays |
| **Speed** | how fast it plays the clip: `2` is twice as fast. Two states can share one clip at different speeds |
| **Write Defaults** | properties this state's clip doesn't animate go back to the values they had at the start. Leave it on |

> **Note:** two more Animator tools, **layers** (two state machines at once, such as legs
> and arms) and **blend trees** (blending several clips by a parameter), belong to
> Level 5. For a 2D sprite character you need neither.

### Idea — reading a state machine

Exam questions give you a machine and ask what plays. Here's one for a door, with a
Bool parameter `IsOpen`:

```
                IsOpen = true                         (Has Exit Time)
   Entry → Closed ────────────────→ Opening ─────────────────────→ Open
             ↑                                                      │
             │       (Has Exit Time)              IsOpen = false    │
             └────────────────────── Closing ←──────────────────────┘
```

- The door starts in **Closed**: Entry points there.
- Code sets `IsOpen` to true: **Closed → Opening** fires at once (no exit time).
- **Opening → Open** has no condition: it fires when the Opening clip ends.
- `IsOpen` stays true, so the door stays **Open** until code sets it to false.

What if code sets `IsOpen` to false halfway through **Opening**? Nothing happens until
Opening ends and the machine reaches **Open**: then `IsOpen = false` sends it on to
**Closing** at once. A machine only follows the arrows out of the state it's in.

### Do it

1. Make a cube or sprite with three property clips: **Red**, **Yellow** and **Green**
   (each sets its colour). In its Animator, add a Trigger called `Next` and transitions
   Green → Yellow → Red → Green, each on `Next`, with Has Exit Time off and a duration
   of 0. Play, select the object, and click the trigger's circle on the Parameters tab
   to fire it by hand.
2. Build the door machine above, with clips of your own (the door's scale or rotation).
   Tick and untick `IsOpen` by hand while it plays. Try unticking it halfway through
   Opening.
3. Turn **Has Exit Time** on for Green → Yellow, and fire `Next` early in the Green
   clip. When does the light change now?

### Challenge

Give the traffic light a **Broken** state, with a clip that flashes yellow, reached from
**Any State** when a Bool `IsBroken` is true. Leave **Can Transition To Self** on, tick
`IsBroken`, and watch the flashing: it never gets past the first frame, because the
transition fires again every frame. Turn the setting off and try again. Then add a way
back from Broken to Red, for when `IsBroken` is false.
