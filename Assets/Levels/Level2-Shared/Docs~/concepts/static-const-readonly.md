## C# — static, const and readonly

**Goal:** you can decide whether a value belongs to each object or to the whole
class, and lock the values that must never change.

### Idea — one copy for everyone: static

Every object built from a class gets its **own copy** of each field: two ships,
two `fuel` values. A **static** member is different: it belongs to the **class
itself**, so there's exactly **one** copy, shared by every object.

```csharp
public class Coin
{
    public int Value { get; private set; }             // each coin has its own
    public static int CoinsMade { get; private set; }  // one number for ALL coins

    public Coin(int value)
    {
        Value = value;
        CoinsMade++;
    }
}
```

```csharp
Coin small = new Coin(1);
Coin big = new Coin(10);
Coin gold = new Coin(50);
Debug.Log(big.Value);
Debug.Log(Coin.CoinsMade);
```

```
10
3
```

Each coin remembers its own `Value`, but every constructor added 1 to the same
`CoinsMade`. You reach a static member through the **class name**:
`Coin.CoinsMade`. Writing `big.CoinsMade` is an error (CS0176), because the
number doesn't belong to `big`.

### Idea — you've used static members all along

Every time you wrote a class name, a dot and a member, you used a static member.
Nobody writes `new Time()`: there's one clock for the whole game, so its members
are static.

| You wrote | Class | Static member |
| --- | --- | --- |
| `Debug.Log("Hi")` | `Debug` | the method `Log` |
| `Random.Range(0, 3)` | `Random` | the method `Range` |
| `Time.deltaTime` | `Time` | the property `deltaTime` |
| `Keyboard.current` | `Keyboard` | the property `current` |
| `Quaternion.identity` | `Quaternion` | the property `identity` |

### Idea — static methods

A static method belongs to the class too, so you call it without making an
object. It's the right choice for a helper that only needs its parameters:

```csharp
public class Temperature
{
    public static float ToFahrenheit(float celsius)
    {
        return celsius * 9 / 5 + 32;
    }
}
```

```csharp
Debug.Log(Temperature.ToFahrenheit(100));
Debug.Log(Temperature.ToFahrenheit(-40));
```

```
212
-40
```

A static method has no object of its own, so it **can't use the object's
fields**. A normal (non-static) field inside a static method gives error CS0120:
*An object reference is required for the non-static field, method, or property*.

A class that only holds static members can be marked `static` itself:
`public static class Temperature`. Then nobody can build an object from it by
mistake.

> **Watch out:** a static value can survive from one **Play** to the next. A
> Unity 6 project can skip reloading your scripts when you press Play, so that
> Play starts faster: check **Edit → Project Settings → Editor → Enter Play Mode
> Settings**. If it says **Reload Scene only**, press Play twice with the coin
> example above and the second run says `6`, not `3`. Give every static value its
> starting value yourself when the game starts, in `Awake()` or `Start()`.

### Idea — const: fixed when you write the code

`const` makes a value that can **never** change. You must give it a value
straight away, and the value must be known when you write the code: a number, a
`bool` or a `string`.

```csharp
public class GameRules
{
    public const int MaxLives = 3;
    public const float Gravity = -9.81f;
    public const string PlayerTag = "Player";
}
```

```csharp
Debug.Log(GameRules.MaxLives);
Debug.Log(GameRules.PlayerTag);
```

```
3
Player
```

- A constant is automatically static: you read it through the class name,
  `GameRules.MaxLives`.
- Constants are named in **PascalCase**: `MaxLives`, not `maxLives`.
- `GameRules.MaxLives = 5;` is an error: *The left-hand side of an assignment
  must be a variable, property or indexer* (CS0131).

Constants replace **magic numbers**: numbers in the middle of the code that
nobody can explain a week later. `if (lives > 3)` hides what the 3 means;
`if (lives > MaxLives)` says it. Unity has constants of its own: `Mathf.PI` is
one.

### Idea — readonly: set once, when the object is made

A `readonly` field gets its value where it's declared **or in the constructor**,
and never again. Use it for values that are only known when the game runs, or
for types a `const` can't hold, like arrays:

```csharp
public class Race
{
    public readonly string trackName;
    public readonly int[] lapTimes = new int[3];

    public Race(string trackName)
    {
        this.trackName = trackName;   // allowed: we're in the constructor
    }

    public void Rename(string newName)
    {
        trackName = newName;          // error CS0191: trackName is readonly
    }
}
```

A readonly **array** can't be swapped for a different array, but its
**elements** can still change:

```csharp
Race race = new Race("Desert");
race.lapTimes[0] = 62;         // fine: changing an element
race.lapTimes = new int[5];    // error CS0191: can't replace a readonly array
```

The same goes for a readonly list: you can add to it and remove from it, but you
can't replace it with a new list.

### Idea — const or readonly?

| | `const` | `readonly` |
| --- | --- | --- |
| Value set | when you write the code | where it's declared, or in the constructor |
| Types | numbers, `bool`, `string` | any type |
| Belongs to | the class (always static) | each object, unless you add `static` |
| Example | `const int MaxLives = 3;` | `readonly int[] lapTimes = new int[3];` |

`static readonly` gives you one shared value that's set once and can be of any
type, like a colour: `static readonly Color Gold = new Color(1f, 0.82f, 0.4f);`.

### Idea — [SerializeField] or public: the whole picture

The certification exam likes this question: *who can see and change this
value?* Here are all the combinations you know now:

| You write | In the Inspector? | Other scripts can read it? | Other scripts can change it? |
| --- | --- | --- | --- |
| `float speed;` | No | No | No |
| `public float speed;` | Yes | Yes | Yes |
| `[SerializeField] float speed;` | Yes | No | No |
| `public float Speed { get; private set; }` | No | Yes | No |
| `public const float Speed = 5f;` | No | Yes | No: nobody can |
| `public static float speed;` | No | Yes | Yes |

> **Note:** Unity never shows `static` or `const` fields in the Inspector, and
> never saves them with the scene.

### Idea — the best of both

You'll see this pattern often: a private field you tune in the Inspector, plus a
property that lets other scripts **read** it without changing it.

```csharp
[SerializeField] int maxHealth = 100;   // tuned in the Inspector

public int MaxHealth
{
    get { return maxHealth; }            // other scripts can only read it
}
```

### Do it

1. Write a plain class `Enemy` with a static property `Count` (public get,
   private set) that the constructor increases. Make four enemies in `Start()`
   and print `Enemy.Count`.
2. Add `public const int MaxEnemies = 3;` to `Enemy`. In the constructor, print
   `"Too many enemies!"` when `Count` goes above `MaxEnemies`.
3. Add a static method `ResetCount()` that sets `Count` back to 0, and call
   `Enemy.ResetCount();` at the very start of `Start()`. Press Play twice: the
   count starts from 0 every time.
4. Try `Enemy.MaxEnemies = 10;`, read the error, then remove the line.

### Challenge

Write a class `Level` with a `readonly string levelName` set by the constructor,
a static property `LevelsCreated`, and a constant `MaxLevels = 10`. Make three
levels, print each name, then print how many levels were created and how many
more you're allowed to make.
