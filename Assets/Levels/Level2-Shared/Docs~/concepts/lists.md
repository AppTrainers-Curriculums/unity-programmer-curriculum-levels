## C# — Lists

**Goal:** you can keep a collection that grows and shrinks in a `List<T>`: add,
remove, count, search and loop through it, and choose between a list and an
array.

### Idea — an array that can grow

An array's size is fixed when you make it. A **list** grows when you add to it
and shrinks when you remove from it. You write the type of its elements between
angle brackets: `List<int>`, `List<string>`, `List<GameObject>`.

Lists live in a part of C# you have to switch on with a `using` line at the top
of the script:

```csharp
using System.Collections.Generic;
using UnityEngine;

public class Practice : MonoBehaviour
{
    void Start()
    {
        List<string> crew = new List<string>();
        crew.Add("Sara");
        crew.Add("Omar");
        crew.Add("Lina");
        Debug.Log(crew.Count);
        Debug.Log(crew[0]);
    }
}
```

```
3
Sara
```

- `new List<string>()` makes an **empty** list. Then `Add` puts each name at the
  end.
- `crew.Count` is how many elements there are. Arrays say `Length`; lists say
  `Count`.
- `crew[0]` reads an element by index, exactly like an array, starting at 0.

> **Watch out:** without `using System.Collections.Generic;` the first line with
> `List` gives error CS0246: *The type or namespace name 'List<>' could not be
> found (are you missing a using directive or an assembly reference?)*.

### Idea — the list toolbox

| Code | Does |
| --- | --- |
| `list.Add(x)` | adds `x` at the end |
| `list.Insert(0, x)` | puts `x` at index 0 and moves everything else along |
| `list.Remove(x)` | removes the first `x` it finds |
| `list.RemoveAt(2)` | removes the element at index 2 |
| `list.Contains(x)` | `true` if `x` is in the list |
| `list.IndexOf(x)` | the index of `x`, or `-1` if it isn't there |
| `list.Count` | how many elements |
| `list.Clear()` | removes everything |
| `list[2]` | reads or changes the element at index 2 |

You can also fill a list as you create it, with the values between `{ }`:

```csharp
List<int> scores = new List<int> { 40, 75, 60 };
scores.Add(90);
scores.Remove(75);
scores.Insert(0, 10);
Debug.Log(scores.Count);
Debug.Log(scores[0] + " " + scores[1]);
Debug.Log(scores.Contains(75));
Debug.Log(scores.IndexOf(90));
```

```
4
10 40
False
3
```

Follow it step by step: `{40, 75, 60}`, then `Add(90)` gives
`{40, 75, 60, 90}`, `Remove(75)` gives `{40, 60, 90}`, and `Insert(0, 10)`
gives `{10, 40, 60, 90}`.

### Idea — printing a whole list

`Debug.Log(scores)` doesn't print the numbers. It prints the list's **type**:

```csharp
List<int> scores = new List<int> { 10, 40, 60, 90 };
Debug.Log(scores);
Debug.Log(string.Join(", ", scores));
```

```
System.Collections.Generic.List`1[System.Int32]
10, 40, 60, 90
```

`string.Join` glues every element into one string, with `", "` between them.

### Idea — looping through a list

`foreach` works on lists exactly as it does on arrays:

```csharp
List<string> inventory = new List<string> { "Key", "Map", "Torch" };
foreach (string item in inventory)
{
    Debug.Log("You carry: " + item);
}
```

```
You carry: Key
You carry: Map
You carry: Torch
```

A `for` loop works too; just use `Count` instead of `Length`:
`for (int i = 0; i < inventory.Count; i++)`.

### Idea — removing while looping

A `foreach` loop can't survive its list changing under it. Removing an element
inside `foreach` stops the game with an **InvalidOperationException**:
*Collection was modified; enumeration operation may not execute*.

To remove elements as you check them, use a `for` loop that runs **backwards**:

```csharp
List<int> health = new List<int> { 30, 0, 55, 0, 10 };
for (int i = health.Count - 1; i >= 0; i--)
{
    if (health[i] == 0)
    {
        health.RemoveAt(i);
    }
}
Debug.Log(string.Join(", ", health));
```

```
30, 55, 10
```

Why backwards? `RemoveAt` shifts every **later** element one place to the left.
Going backwards, the elements that shift are ones you've already checked, so
nothing gets skipped.

### Idea — lists of objects

A list can hold any type: numbers, strings, your own classes, and Unity objects.

```csharp
[SerializeField] List<Transform> waypoints;
List<GameObject> enemiesAlive = new List<GameObject>();
```

A `[SerializeField]` list shows in the Inspector exactly like an array: grow it
with **+** and fill it by dragging.

> **Watch out:** when you `Destroy` a GameObject, it isn't taken out of your
> lists. The list keeps an entry that now points at a destroyed object, so
> remove it yourself (`enemiesAlive.Remove(enemy);`) when you destroy it.

### Idea — array or list?

| Use an array when… | Use a List when… |
| --- | --- |
| the number of elements is fixed: 3 life icons, 4 spawn points | things come and go: enemies alive, items picked up |
| you fill it in the Inspector and never resize it | you `Add` and `Remove` while the game runs |
| you ask its size with `.Length` | you ask its size with `.Count` |

Both can be `[SerializeField]` fields, and both work with `for` and `foreach`.

### Do it

1. Make a `List<string>` shopping list with three items. Add one, remove one,
   then print the count and every item with `foreach`.
2. Make a `List<int>` of scores: 12, 45, 7, 45, 30. Use a loop to print how many
   times 45 appears, and the highest score (try `Mathf.Max`).
3. Remove every score below 20 with a backwards loop, then print the list with
   `string.Join`.
4. Try removing inside a `foreach` loop instead, and read the error.

### Challenge

Keep a "last three messages" list: write `AddMessage(string text)` that adds the
text at the end and removes the oldest message (index 0) whenever there are more
than three. Add five messages, then print the list.
