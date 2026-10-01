## C# — null and Debugging

**Goal:** you can explain what `null` is, find the reference that's `null` from
an error message, and pause your code with a breakpoint to look inside it.

### Idea — null: an arrow to nothing

A variable of a class type holds a **reference**: an arrow to an object
(Level 1). `null` means the arrow points at **nothing**.

| Can be `null` | Can't be `null` |
| --- | --- |
| class types: `GameObject`, components, `string`, `List<T>`, your own classes | `int`, `float`, `bool`, `Vector3` and other value types |

```csharp
string playerName = null;
GameObject target = null;
Debug.Log(playerName == null);
Debug.Log(target);
```

```
True
Null
```

Checking a `null` reference is fine. **Using** one is not:

```csharp
List<int> scores = null;       // forgot: = new List<int>();
scores.Add(10);                // NullReferenceException
```

`scores.Add` means "go to the list and add 10", but there's no list to go to. C#
stops the code with a **NullReferenceException**: the most common error in all of
Unity.

### Idea — reading the error

Double-click an error in the Console and your code editor opens the file at the
exact line. Click it once, and the bottom of the Console shows the whole
message:

```
NullReferenceException: Object reference not set to an instance of an object
Practice.AddBonus (System.Int32 amount) (at Assets/Scripts/Practice.cs:21)
Practice.Start () (at Assets/Scripts/Practice.cs:12)
```

| Part | Tells you |
| --- | --- |
| `NullReferenceException` | **what** went wrong |
| `Object reference not set…` | the explanation, in words |
| the lines below | the **stack trace**: **where** it happened |

Read the stack trace from the **top**. The error happened in `AddBonus`, at line
21 of `Practice.cs`. The line under it says who called `AddBonus`: `Start`, at
line 12. Each line is one step further back along the chain of calls.

### Idea — which one is null?

The error names the line, not the variable. On a line like this, three
references could be `null`:

```csharp
gameManager.player.health.TakeDamage(5);
```

To find out which, split the line, or print each part just before it:

```csharp
Debug.Log(gameManager == null);
Debug.Log(gameManager.player == null);
Debug.Log(gameManager.player.health == null);
```

The first `True` is the culprit. Or use a breakpoint (below) and **look**.

### Idea — Unity's own null errors

In the Editor, Unity replaces some `NullReferenceException`s with errors that
explain more. Learn to recognise them:

| Error | What happened | Fix |
| --- | --- | --- |
| **UnassignedReferenceException:** *The variable target of Practice has not been assigned.* | a `[SerializeField]` or `public` field was left empty in the Inspector | drag the object into the field |
| **MissingComponentException:** *There is no 'Rigidbody' attached to the "Cube" game object, but a script is trying to access it.* | `GetComponent` found nothing, and the code used the result | add the component, or check for `null` |
| **MissingReferenceException:** *The object of type 'GameObject' has been destroyed but you are still trying to access it.* | the code used an object after `Destroy` | stop using it: remove it from lists, check for `null` |
| **NullReferenceException** | a plain `null`: a variable that was never given an object | find the variable and give it one |

In a finished build, the first two become plain `NullReferenceException`s, with
no helpful message. Another reason to test in the Editor!

### Idea — checking for null

When something **might** be missing, check before you use it:

```csharp
if (target != null)
{
    target.SetActive(false);
}
```

Unity objects have a special rule: after you `Destroy` one, it **compares equal
to `null`**, even though your variable still holds the arrow. So
`if (enemy != null)` is exactly the right check for "does this enemy still
exist?".

> **Watch out:** you may meet `?.` and `??` in C# code online, like
> `target?.SetActive(false);`. Don't use them with Unity objects: they skip
> Unity's special check, and don't notice that an object was destroyed. Write
> `if (target != null)` instead.

### Idea — breakpoints: pause the game and look

A **breakpoint** pauses your code on a chosen line, while the game is running, so
you can look at every variable. In **Visual Studio Code**:

1. Click just left of a line number: a **red dot** appears. That's the
   breakpoint.
2. Open **Run and Debug** (**Ctrl + Shift + D**, **Cmd + Shift + D** on Mac),
   choose **Attach to Unity** at the top, and press the green ▶ (or **F5**).
3. The first time, Unity asks to switch to **Debug Mode**. Choose **Enable
   debugging for this session**.
4. Press **Play** in Unity. When the game reaches your line, it freezes, and VS
   Code highlights the line.
5. Hover over any variable to see its value, or read the **Variables** panel on
   the left. A `null` reference shows as `null`.
6. **F10** runs the next line (Step Over), **F11** goes into the method on this
   line (Step Into), **F5** continues until the next breakpoint, and
   **Shift + F5** stops debugging.

In **Visual Studio**, press **Attach to Unity** in the toolbar instead; the rest
is the same.

> **Tip:** the Console's **Error Pause** button pauses the game on the first
> error, so you can inspect the scene exactly as it was when things went wrong.

### Idea — Debug.Log is still your friend

| Code | Shows in the Console |
| --- | --- |
| `Debug.Log("Hit!")` | a normal message |
| `Debug.LogWarning("Low health")` | a yellow warning |
| `Debug.LogError("No spawn points!")` | a red error (the game keeps running) |
| `Debug.Log("Hit!", gameObject)` | a message that highlights `gameObject` in the Hierarchy when you click it |

### Do it

1. Add `[SerializeField] GameObject target;` to `Practice`, leave it empty, and
   call `target.SetActive(false);` in `Start()`. Read the error, double-click it,
   then fix it by dragging an object into the field.
2. Get a component that isn't there with `GetComponent`, and use it. Read the
   error.
3. `Destroy(target);` in `Start()`, and print `target.name` in `Update()`. Read
   the error, then add a `null` check so it stops.
4. Put a breakpoint inside `Update` on a line that uses a counter, attach the
   debugger, and watch the counter's value each time you press **F5**.

### Challenge

A friend's game shows this error in the Console. Answer the three questions
without looking at the code:

```
NullReferenceException: Object reference not set to an instance of an object
Shop.Buy (System.String item) (at Assets/Scripts/Shop.cs:34)
ShopButton.OnClick () (at Assets/Scripts/ShopButton.cs:15)
```

1. In which file and on which line did the error happen?
2. Which method called the method that failed?
3. On line 34, the code is `wallet.coins -= prices[item];`. Which two
   references could be `null`?
