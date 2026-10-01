## C# — Coroutines and Timers

**Goal:** you can make something happen after a delay, or step by step over
time, with a timer or a coroutine.

### Idea — you can't wait inside Update

`Update` must finish quickly: Unity can't draw the next frame until it does. So
you can't write "wait two seconds" in the middle of it. Games wait in one of two
ways:

| Tool | How it waits |
| --- | --- |
| a **timer** | a number that counts time, checked every frame in `Update` |
| a **coroutine** | a special method that can pause itself, and carry on later |

### Idea — timers

You met the first kind of timer in Level 1's Spawner: add `Time.deltaTime` every
frame, and act when it's big enough.

```csharp
float timer = 0f;

void Update()
{
    timer += Time.deltaTime;
    if (timer >= 2f)
    {
        Debug.Log("Two seconds passed");
        timer = 0f;
    }
}
```

The second kind uses `Time.time`, the number of seconds since the game started.
Remember **when** something is next allowed, and compare. It's perfect for a
**cooldown**, like a weapon that can't fire more than twice a second:

```csharp
[SerializeField] float cooldown = 0.5f;
float nextShotTime = 0f;

void Update()
{
    if (Keyboard.current.spaceKey.wasPressedThisFrame && Time.time >= nextShotTime)
    {
        Debug.Log("Fire!");
        nextShotTime = Time.time + cooldown;
    }
}
```

### Idea — a coroutine: a method that can wait

```csharp
using System.Collections;
using UnityEngine;

public class Practice : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Countdown());
        Debug.Log("Start is finished");
    }

    IEnumerator Countdown()
    {
        Debug.Log("3");
        yield return new WaitForSeconds(1f);
        Debug.Log("2");
        yield return new WaitForSeconds(1f);
        Debug.Log("1");
        yield return new WaitForSeconds(1f);
        Debug.Log("Go!");
    }
}
```

```
3
Start is finished
2
1
Go!
```

Look at the order. `StartCoroutine` runs `Countdown` straight away, **up to its
first `yield`**: that prints `3`. There the coroutine pauses, and `Start` carries
on and prints its message. One second later, Unity wakes the coroutine up, it
prints `2`, and pauses again, and so on.

| Part | Meaning |
| --- | --- |
| `IEnumerator Countdown()` | a coroutine's return type is always `IEnumerator` (it needs `using System.Collections;`) |
| `StartCoroutine(Countdown());` | how you start one |
| `yield return new WaitForSeconds(1f);` | pause here for one second |
| `yield return null;` | pause here until the next frame |

> **Watch out:** calling `Countdown();` without `StartCoroutine` does
> **nothing**: no error and no countdown. It's one of the most common coroutine
> bugs.

### Idea — loops that wait

A coroutine can wait inside a loop, which makes sequences easy to write. This one
spawns a wave of enemies, one every 0.8 seconds:

```csharp
IEnumerator SpawnWave(int count)
{
    for (int i = 1; i <= count; i++)
    {
        Debug.Log("Enemy " + i);
        yield return new WaitForSeconds(0.8f);
    }
    Debug.Log("Wave complete");
}
```

```csharp
StartCoroutine(SpawnWave(3));
```

```
Enemy 1
Enemy 2
Enemy 3
Wave complete
```

A coroutine can take parameters like any method. It can even loop forever with
`while (true)`, as long as the loop has a `yield` inside, so it pauses every time
round. A `while (true)` loop **without** a `yield` freezes Unity.

### Idea — stopping a coroutine

| Code | Stops |
| --- | --- |
| `Coroutine blink = StartCoroutine(Blink());` then `StopCoroutine(blink);` | that one coroutine |
| `StopAllCoroutines();` | every coroutine this script started |
| `yield break;` inside the coroutine | the coroutine itself, from the inside |

Coroutines also stop when their GameObject is deactivated or destroyed. They do
**not** stop when you only disable the script.

### Idea — timer or coroutine?

| A timer in Update fits… | A coroutine fits… |
| --- | --- |
| something that repeats forever with a changing delay | a sequence: do, wait, do, wait |
| cooldowns: "am I allowed to fire yet?" | "in two seconds, move to the next level" |
| values you want to see and change every frame | a story you want to read from top to bottom |

> **Note:** `WaitForSeconds` counts game time. If the game is paused with
> `Time.timeScale = 0;`, coroutines waiting with `WaitForSeconds` pause too.
> `WaitForSecondsRealtime` keeps counting real seconds.

> **Note:** Unity also has `Invoke("Explode", 2f)`, which calls a method **by
> its name** after a delay. You'll see it in older code and exam questions. A
> typo in the name is only noticed when the game runs, so this book uses
> coroutines.

### Do it

1. Write a coroutine `Countdown(int from)` that prints the numbers from `from`
   down to 1, one per second, then prints `"Liftoff!"`. Start it from `Start()`
   with 5.
2. Add a `Debug.Log` right after the `StartCoroutine` line. Predict where it
   appears in the Console, then run it.
3. Replace `StartCoroutine(Countdown(5));` with `Countdown(5);`. What happens?
4. Add the cooldown example, and tap **Space** as fast as you can: you never get
   more than two `"Fire!"` messages a second.

### Challenge

Write a traffic light coroutine that loops forever with `while (true)`: green
for 3 seconds, yellow for 1, red for 3, and round again. Keep the running
coroutine in a field, and stop it when the **S** key is pressed.
