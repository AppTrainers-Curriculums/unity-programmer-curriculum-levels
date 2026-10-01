## C# — Dictionaries

**Goal:** you can store values under keys in a `Dictionary<TKey, TValue>`, look
them up safely, and loop through them.

### Idea — look it up by name, not by position

Your phone's contacts work like this: you look up a **name** (the **key**) and
get a **number** (the **value**). Arrays and lists find things by position: 0,
1, 2… A **dictionary** finds things by key, and the key can be almost any type,
usually a `string` or an `int`.

```csharp
Dictionary<string, int> prices = new Dictionary<string, int>();
prices.Add("Sword", 150);
prices.Add("Shield", 90);
prices["Potion"] = 25;

Debug.Log(prices["Sword"]);
Debug.Log(prices.Count);
```

```
150
3
```

- `Dictionary<string, int>`: the keys are `string`s, the values are `int`s.
- `prices["Sword"]` reads the value stored under the key `"Sword"`.
- A dictionary needs the same `using System.Collections.Generic;` as a list.

### Idea — the dictionary toolbox

| Code | Does |
| --- | --- |
| `dict.Add(key, value)` | adds a new pair; an **error** if the key is already there |
| `dict[key] = value` | adds the pair, or **replaces** the value if the key is already there |
| `dict[key]` | reads a value; an **error** if the key isn't there |
| `dict.ContainsKey(key)` | `true` if the key is there |
| `dict.TryGetValue(key, out value)` | reads safely: `true` and the value, or `false` |
| `dict.Remove(key)` | removes the key and its value |
| `dict.Count` | how many pairs |
| `dict.Keys` / `dict.Values` | all the keys / all the values, to loop over |

**Keys are unique**: one key, one value. Values can repeat: a sword and an axe
can both cost 150.

```csharp
Dictionary<string, int> stock = new Dictionary<string, int>();
stock["Apple"] = 5;
stock["Apple"] = stock["Apple"] + 3;
Debug.Log(stock["Apple"]);
```

```
8
```

> **Watch out:** reading a key that isn't there, like `prices["Bow"]`, stops your
> code with a **KeyNotFoundException**. Calling `Add` with a key that's already
> there gives an **ArgumentException**. The next idea shows how to avoid both.

### Idea — reading safely

Ask first with `ContainsKey`, or ask and read in one go with `TryGetValue`, which
uses the Try pattern and an `out` parameter ({{ref:methods}}):

```csharp
if (prices.ContainsKey("Bow"))
{
    Debug.Log(prices["Bow"]);
}
else
{
    Debug.Log("We don't sell bows");
}

if (prices.TryGetValue("Shield", out int shieldPrice))
{
    Debug.Log("A shield costs " + shieldPrice);
}
```

```
We don't sell bows
A shield costs 90
```

### Idea — looping through a dictionary

`foreach` gives you one **pair** at a time: a `KeyValuePair<TKey, TValue>` with a
`.Key` and a `.Value`:

```csharp
foreach (KeyValuePair<string, int> pair in prices)
{
    Debug.Log(pair.Key + " costs " + pair.Value);
}
```

```
Sword costs 150
Shield costs 90
Potion costs 25
```

You can also loop over just the keys (`foreach (string item in prices.Keys)`) or
just the values.

> **Watch out:** a dictionary doesn't promise any order. Here the pairs come out
> in the order they were added, but once you start removing keys that can
> change. And, as with lists, don't `Add` or `Remove` while a `foreach` is
> running over the dictionary.

### Idea — fill it as you make it

Like a list, a dictionary can be filled as you create it. Each pair goes in its
own `{ }`:

```csharp
Dictionary<string, int> points = new Dictionary<string, int>
{
    { "Block", 1 },
    { "GoldBlock", 5 },
    { "BadBlock", -1 },
};
Debug.Log(points["GoldBlock"]);
```

```
5
```

Think back to Level 1: `GameManager` used a `switch` on the block's tag to decide
the points. With this dictionary, the whole `switch` becomes one line:
`score += points[blockTag];`. And adding a new kind of block means adding one
line to the dictionary, not a new `case`.

### Idea — array, list or dictionary?

| Collection | Finds an element by… | Example |
| --- | --- | --- |
| array | its position, and the size is fixed | the three life icons |
| `List` | its position, and it grows and shrinks | the enemies that are alive |
| `Dictionary` | its key | the points for each kind of enemy, or the name for each score |

### Do it

1. Make a `Dictionary<string, int>` of three friends' ages. Print one age,
   change it with `[ ]`, and print it again.
2. Loop through the dictionary and print `"Name is N years old"` for each pair.
3. Use `TryGetValue` to look up a name that isn't there and print
   `"Unknown friend"`.
4. Call `Add` with a name that's already there. Read the error in the Console,
   then remove the line.

### Challenge

Count words. Split a sentence into an array of words with
`string[] words = "the cat and the dog and the bird".Split(' ');`, then use a
`Dictionary<string, int>` to count how many times each word appears. Print every
word with its count.
