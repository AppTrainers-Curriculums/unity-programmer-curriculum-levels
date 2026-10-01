## C# — Finding Errors

**Goal:** you can look at code and say why it won't compile or won't work: a wrong data
type, a `public` or `private` mix-up, an Animator or Animation Event mistake, or a
`null`. Exam objectives U 3.2 and U 3.3 are about these, and U 1.2 about the last.

### Idea — three kinds of mistake

| Kind | When you find out | How |
| --- | --- | --- |
| **Compile error** | as soon as you save | red in the Console, and Play won't start until it's fixed |
| **Runtime error** | when that line runs | red in the Console while playing, often `NullReferenceException`; that frame's `Update` stops at the line |
| **Logic bug** | when you notice the game is wrong | no message at all |

Double-click a compile error in the Console and your IDE opens at the line. The message
gives the file, the line and the column, then a code: `Door.cs(12,9): error CS0122`.
The code (`CS0122`) is worth reading: the same codes come back again and again.

### Idea — wrong data types (U 3.2)

C# checks that every value fits the type of the place it goes. These all fail to
compile:

```csharp
int lives = 2.5f;           // error CS0266: a float doesn't fit in an int
float speed = 5.0;          // error CS0664: 5.0 is a double; write 5.0f
string playerName = 10;     // error CS0029: a number isn't text
bool isAlive = 1;           // error CS0029: C# has no 1 for true
int coins = "5";            // error CS0029: text isn't a number
Vector2 position = 3f;      // error CS0029: one number isn't two
```

The same check applies to what a method returns, and to what you pass it:

```csharp
// error CS0266: the method says it returns an int, and 2.5f isn't one
int GetScore()
{
    return 2.5f;
}
```

```csharp
using UnityEngine;

public class StateSetter : MonoBehaviour
{
    [SerializeField] Animator animator;

    void Start()
    {
        animator.SetInteger("State", 1.5f);     // error CS1503: SetInteger wants an int
    }
}
```

The fixes are the right type (`int lives = 2;`), the right literal (`5.0f`), or an
explicit conversion when you mean it: `(int)2.5f` is 2, and `Mathf.RoundToInt(2.5f)`
rounds instead.

> **Watch out:** some type mistakes compile, and only show while playing.
> `GetComponent<Rigidbody>()` on an object that only has a **Rigidbody 2D** compiles
> fine, and returns `null`: 3D and 2D components are different types. And `3 / 5` is
> 0, because both are `int`s ({{ref:gameui}}).

### Idea — public and private (U 3.3)

`private` (or no modifier at all) means *only this class can use it*. `public` means any
script can. Getting it wrong gives these:

```csharp
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool IsLocked { get; private set; }

    void Open()             // no modifier: private
    {
        Debug.Log("The door opens");
    }
}
```

```csharp
using UnityEngine;

public class DoorKey : MonoBehaviour
{
    [SerializeField] Door door;

    void Start()
    {
        door.Open();            // error CS0122: 'Door.Open()' is inaccessible due to its protection level
        door.IsLocked = false;  // error CS0272: the set accessor is inaccessible
    }
}
```

| The code | The problem | The fix |
| --- | --- | --- |
| another script calls `door.Open()` | `Open` is private | make it `public void Open()` |
| another script sets `door.IsLocked` | its `set` is private | give `Door` a public method that unlocks it, or make the setter public if any script should change it |
| `float speed = 5f;` doesn't show in the Inspector | it's private, with no `[SerializeField]` | add `[SerializeField]` |
| you changed `public float speed = 5f;` to `8f` in code, and nothing changed | the Inspector's saved value wins over the code's starting value | change it in the Inspector, or **Reset** the component |

`Update`, `Start` and the other event functions are private by habit. Unity calls them
anyway, by name: making them `public` changes nothing for Unity.

### Idea — Animation Event and Animator mistakes (U 3.3)

An Animation Event calls a method **by name**, on the scripts of the GameObject that has
the Animator ({{ref:animevents}}). So:

| Mistake | What you see |
| --- | --- |
| the event says `OnFootStep`, the method is `OnFootstep` | `'Knight' AnimationEvent 'OnFootStep' on animation 'Knight Run' has no receiver!` |
| the method is on a script on a **child** or a **parent** | the same "no receiver" message |
| the method takes a parameter an event can't pass (a `Vector2`, a `bool`, or two values) | `Failed to call AnimationEvent …`, an error, and the method isn't called |
| the method is `private` | nothing: Unity calls private methods too. Other **scripts** can't, though |

And the Animator's parameters are matched by name too ({{ref:animcode}}):

| Mistake | What you see |
| --- | --- |
| `SetFloat("speed", …)` for a parameter called `Speed` | `Parameter 'speed' does not exist.`, and nothing animates |
| `SetBool` on a Float parameter called `Speed` | `Parameter type 'Speed' does not match.`; the value doesn't change |
| a transition with **Has Exit Time** on, where it should be off | no message: the animation changes late |

### Idea — null (U 1.2, from Level 2)

```
NullReferenceException: Object reference not set to an instance of an object
Coin.OnTriggerEnter2D (UnityEngine.Collider2D other) (at Assets/Scripts/Coin.cs:13)
```

Line 13 of `Coin.cs` used something that was `null`. On that line, look at what comes
before each `.`: one of those objects is missing. In Unity it's usually a
`[SerializeField]` field left empty in the Inspector, or a `GetComponent` that found
nothing. Select the object and look for a field that says **None**.

When the missing object is one of Unity's own types, such as a `Transform` or an
`Animator`, the Editor names the problem for you instead. An empty field:

```
UnassignedReferenceException: The variable target of CameraFollow has not been assigned.
You probably need to assign the target variable of the CameraFollow script in the inspector.
```

A `GetComponent` that found nothing:

```
MissingComponentException: There is no 'Animator' attached to the "Knight" game object, but a script is trying to access it.
You probably need to add a Animator to the game object "Knight". Or your script needs to check if the component is attached before using it.
```

A built game, outside the Editor, shows a plain `NullReferenceException` for both.

### Idea — how the exam asks

*Which line causes a compile error?*

```csharp
int score = 10;
float bonus = score * 1.5f;
int total = score + bonus;      // error CS0266: int + float is a float
Debug.Log(total);
```

The third: `score + bonus` is a `float` (an `int` plus a `float` gives a `float`), and
it can't go into an `int` without a conversion. The second line is fine: a `float` can
always hold an `int`'s value.

### Do it

1. Type each of the six wrong declarations into a Practice script, one at a time, and
   read the Console. Then fix each one.
2. Make the `Door` and `DoorKey` scripts, read both errors, and fix them the way the
   table says.
3. On an animated object, give an event the name of a method with a typo in it. Play,
   and read the message. Then move the right method to a child, and read it again.
4. Leave a `[SerializeField]` reference empty, use it, and read the
   `NullReferenceException`. Find the line, and the `None` in the Inspector.

### Challenge

Write a short script with five mistakes in it: two type errors, a `public`/`private`
mix-up, an Animator parameter typo and an empty reference. Swap with a partner. Who
finds all five first, and can say which ones the compiler will find, and which only show
when you press Play?
