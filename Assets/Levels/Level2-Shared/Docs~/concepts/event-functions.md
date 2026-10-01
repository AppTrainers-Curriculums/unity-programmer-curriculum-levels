## C# — Event Functions: When Unity Calls Your Code

**Goal:** you know which event function Unity calls when, and you put each piece
of code in the right one.

### Idea — you don't call them: Unity does

You've never written `Start();` anywhere. Unity calls `Start()` and `Update()`
for you, at the right moments. They belong to a whole family of **event
functions** that Unity calls at fixed points in a script's life. You declare one
with the exact name, and Unity finds it and calls it.

> **Watch out:** the name must match **exactly**, capitals included. A method
> called `start()` or `Updat()` is just a normal method that nobody calls: no
> error, and it never runs.

### Idea — the life of a script

```
Awake()          once, when the object is created
OnEnable()       every time the script is switched on
Start()          once, just before its first Update
 ┌─ FixedUpdate()   on the physics clock: 50 times a second
 ├─ Update()        once every frame
 └─ LateUpdate()    once every frame, after every Update has run
OnDisable()      every time the script is switched off, and when it's destroyed
OnDestroy()      once, when the object is destroyed
```

| Function | When Unity calls it | Use it for |
| --- | --- | --- |
| `Awake` | once, first of all, even if the script is disabled | setting up **this** object: getting its own components |
| `OnEnable` | every time the script is enabled | starting to listen to events |
| `Start` | once, before the first frame, only if the script is enabled | setting up things that need **other** objects |
| `FixedUpdate` | on the physics clock, every 0.02 seconds | physics: forces and Rigidbody velocities |
| `Update` | every frame | input, timers, movement without physics |
| `LateUpdate` | every frame, after all the `Update`s | a camera that follows something |
| `OnDisable` | every time the script is disabled, and before it's destroyed | stopping listening to events |
| `OnDestroy` | once, when the object is destroyed | final clean-up |

### Idea — see the order for yourself

```csharp
using UnityEngine;

public class Practice : MonoBehaviour
{
    int frames = 0;

    void Awake()
    {
        Debug.Log("Awake");
    }

    void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    void Start()
    {
        Debug.Log("Start");
    }

    void Update()
    {
        if (frames < 2)
        {
            Debug.Log("Update " + frames);
        }
    }

    void LateUpdate()
    {
        if (frames < 2)
        {
            Debug.Log("LateUpdate " + frames);
        }
        frames++;
    }

    void OnDisable()
    {
        Debug.Log("OnDisable");
    }
}
```

Press Play, wait a moment, then stop. The Console shows:

```
Awake
OnEnable
Start
Update 0
LateUpdate 0
Update 1
LateUpdate 1
OnDisable
```

The `if`s keep the Console readable: after two frames, `Update` and `LateUpdate`
keep running every frame, but quietly. `OnDisable` arrives when you stop,
because stopping destroys every object in the scene.

`FixedUpdate` isn't in the example because it doesn't follow the frames: a fast
computer may draw several frames between two `FixedUpdate`s, and a slow one may
run `FixedUpdate` twice in one frame.

### Idea — Update or FixedUpdate?

Physics has its own clock. Unity moves every Rigidbody on that clock, so code
that pushes a Rigidbody belongs in `FixedUpdate`, where it runs in step with the
physics. Everything else goes in `Update`.

| Put it in `Update` | Put it in `FixedUpdate` |
| --- | --- |
| reading the keyboard, mouse and touch | `AddForce` on a Rigidbody |
| timers and cooldowns | setting a Rigidbody's velocity |
| moving objects with `transform` | moving a Rigidbody with `MovePosition` |

There's a catch: `wasPressedThisFrame` is `true` for **one frame** only, and
`FixedUpdate` might not run in that frame. So read input in `Update`, remember it
in a field, and use it in `FixedUpdate`:

```csharp
bool jumpPressed;

void Update()
{
    if (Keyboard.current.spaceKey.wasPressedThisFrame)
    {
        jumpPressed = true;          // remember it
    }
}

void FixedUpdate()
{
    if (jumpPressed)
    {
        Debug.Log("Jump!");          // the physics code goes here
        jumpPressed = false;         // used: forget it
    }
}
```

> **Note:** inside `FixedUpdate`, `Time.deltaTime` gives the physics step (0.02
> seconds), so frame-independent maths works the same in both.

### Idea — Awake or Start?

Unity calls every object's `Awake` before **any** object's `Start`. But it
doesn't promise which object's `Awake` comes first. That gives a simple rule:

- In **`Awake`**, set up **yourself**: your own fields and your own components.
- In **`Start`**, use **other** objects. By then, every object has run its
  `Awake`, so they're ready.

If script A reads a list in its `Awake` that script B fills in B's `Awake`, it
works on some days and fails on others. Move A's code to `Start` and it always
works.

### Idea — switching scripts on and off

| You do | Unity calls | And |
| --- | --- | --- |
| untick the script in the Inspector, or `enabled = false;` | `OnDisable` | `Update`, `FixedUpdate` and `LateUpdate` stop |
| tick it again, or `enabled = true;` | `OnEnable` | they start again |
| `gameObject.SetActive(false);` | `OnDisable` on every script of the object | the whole object disappears |
| `Destroy(gameObject);` | `OnDisable`, then `OnDestroy` | the object is gone |

> **Watch out:** a disabled script still receives collision and trigger messages
> (`OnTriggerEnter2D` and the others). Only deactivating the whole GameObject
> silences it completely.

### Do it

1. Put the example in your `Practice` script, press Play, stop, and match the
   Console to the diagram.
2. While the game is playing, untick the `Practice` component in the Inspector,
   then tick it again. Which messages appear?
3. Add `void OnDestroy()` with a `Debug.Log`, and stop the game. Does it come
   before or after `OnDisable`?
4. Rename `Start` to `start` and press Play: no error, and no `Start` message.
   Change it back.

### Challenge

Count how many times `Update` and `FixedUpdate` run. After two seconds of play
(check `Time.time` in `Update`), print both counts once. `FixedUpdate` gives
about 100, whatever your computer. What does `Update` give, and why is it
different on a friend's computer?
