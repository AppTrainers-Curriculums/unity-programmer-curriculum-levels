## C# — Reading the Unity Docs

**Goal:** you can find a class in Unity's Scripting API, read its page, and pick
the right property or method, with the right arguments.

### Idea — two manuals

Nobody remembers all of Unity. Professionals look things up many times a day, in
two official manuals at **docs.unity3d.com**:

| Manual | Answers | Example |
| --- | --- | --- |
| **Unity Manual** | "How does this part of the Editor work?" | how the Animator window works |
| **Scripting API** (Scripting Reference) | "What can my code do with this class?" | every property and method of `Rigidbody` |

Check the **version** at the top of the page: pick the version of Unity you're
using (6000.x). The **?** icon at the top of every component in the Inspector
opens that component's page too.

### Idea — a class page

Search the Scripting API for `Rigidbody` and open the class page. Every class
page has the same parts:

| Part | Tells you |
| --- | --- |
| **class in UnityEngine** | the namespace: the `using` line you need |
| **Inherits from** | its parent class: `Rigidbody` is a `Component`, so it has everything a component has |
| **Description** | what it's for, often with an example script |
| **Properties** | the values you can read or set: `mass`, `linearVelocity`, `useGravity`… |
| **Public Methods** | what you can ask it to do: `AddForce`, `MovePosition`… |
| **Static Methods** | members of the class itself, called on the class name |
| **Messages** | event functions Unity calls on your scripts, like `OnCollisionEnter` |
| **Inherited Members** | everything that comes from the parent classes |

### Idea — a method page

Click `AddForce`. The **Declaration** is the most important line on the page:

```csharp
public void AddForce(Vector3 force, ForceMode mode = ForceMode.Force);
```

Read it like any method you write ({{ref:methods}}):

- `void`: it returns nothing.
- `Vector3 force`: the first argument is the push, as a vector.
- `ForceMode mode = ForceMode.Force`: the second argument is **optional**. Leave
  it out and you get `ForceMode.Force`.

Under it, the **Parameters** table explains each argument, and the
**Description** says what the method does and when to use it. When a method has
**several declarations**, those are its overloads: pick the one whose parameters
match what you have.

### Idea — searching well

- Search for the **thing**, then read its page: to move a physics object, start
  at `Rigidbody`; for distances, start at `Vector3`.
- Scan the **Properties** and **Public Methods** lists: the one-line summaries
  are written to be skimmed.
- Read the **Declaration**, not only the example. The example shows one way to
  call a method; the declaration shows every way.
- Check the version. Unity 6 renamed some members (`velocity` became
  `linearVelocity`), and old answers on the internet use the old names.

> **Tip:** in VS Code, hover over any Unity class or method to see its summary,
> and its declaration, without leaving your code.

### Do it: a scavenger hunt

Use the Scripting API to answer each question. The answers are below.

1. Which property of `Rigidbody2D` sets how strongly gravity pulls it?
2. What does `Vector3.Distance` return, and what are its parameters?
3. `Mathf.Clamp` has more than one declaration. Which types can it work with?
4. Which class does `Transform` inherit from?
5. What's the default `ForceMode` of `Rigidbody.AddForce`, and what does
   `ForceMode.Impulse` do?
6. Which message does Unity send when two 2D colliders (not triggers) start
   touching?
7. What does `GameObject.CompareTag` return?

### Challenge

Find a method you've never used that would be useful in your game, read its whole
page, and use it. Explain to a classmate what its declaration says.

### Answers

1. `gravityScale`.
2. It returns a `float`: the distance between its two parameters, `Vector3 a`
   and `Vector3 b`.
3. `float` and `int`: `Clamp(float value, float min, float max)` and
   `Clamp(int value, int min, int max)`.
4. `Component`.
5. `ForceMode.Force`. `ForceMode.Impulse` applies the whole push at once, like a
   kick, and takes the mass into account.
6. `OnCollisionEnter2D`.
7. A `bool`: `true` if the GameObject has that tag.
