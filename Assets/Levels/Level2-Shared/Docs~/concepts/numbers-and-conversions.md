## C# — Numbers and Conversions

**Goal:** you can predict what happens when whole and decimal numbers meet,
convert between types on purpose, and fix type-mismatch errors.

### Idea — the number types you use

| Type | Holds | Written like | Used for |
| --- | --- | --- | --- |
| `int` | whole numbers | `42`, `-7` | counts: score, lives, strokes, ammo |
| `float` | decimal numbers, about 7 digits | `3.5f` | Unity's everyday decimal: positions, speeds, time |
| `double` | decimal numbers, about 15 digits | `3.5` | C#'s default decimal; Unity rarely uses it |

A decimal written **without** `f` is a `double`, so `float speed = 3.5;` is an
error: *Literal of type double cannot be implicitly converted to type 'float';
use an 'F' suffix to create a literal of this type* (CS0664). Write `3.5f`.

### Idea — when int meets int

```csharp
Debug.Log(7 / 2);
Debug.Log(7 % 2);
Debug.Log(7 / 2f);
Debug.Log(7f / 2);
```

```
3
1
3.5
3.5
```

When **both** sides are `int`, the answer is an `int`: the decimal part is
**thrown away**, not rounded (`7 / 2` is 3, and `%` gives the remainder, 1). If
**either** side is a `float`, the answer is a `float`.

That rule hides a classic bug:

```csharp
int found = 3;
int total = 4;
float percent = found / total * 100;
Debug.Log(percent);
```

```
0
```

`3 / 4` is worked out first, with two `int`s: the answer is 0. Then `0 * 100` is
0, and only then does it go into the `float`. Too late! The fix is to make one
side a `float` **before** dividing, which is what the next ideas are about.

### Idea — implicit conversion: the safe direction

C# converts a value automatically when **nothing can be lost**:

```csharp
int coins = 5;
float price = coins;     // int to float: 5 becomes 5
double exact = price;    // float to double
Debug.Log(price);
```

```
5
```

Every whole number has a decimal version, so `int` → `float` → `double` is
always safe. This is an **implicit** conversion: you don't write anything.

### Idea — explicit conversion: the cast

The other direction can lose information, so C# refuses to do it silently:

```csharp
float height = 3.9f;
int floors = height;     // error CS0266
```

*Cannot implicitly convert type 'float' to 'int'. An explicit conversion exists
(are you missing a cast?)* (CS0266). A **cast** tells C#: "I know I may lose
something. Do it anyway." You write the type in brackets before the value:

```csharp
float height = 3.9f;
int floors = (int)height;
Debug.Log(floors);
Debug.Log((int)-3.9f);
```

```
3
-3
```

A cast to `int` **cuts off** the decimals, towards zero: 3.9 becomes 3, and
-3.9 becomes -3. Now the percentage bug has a fix:

```csharp
int found = 3;
int total = 4;
float percent = (float)found / total * 100;
Debug.Log(percent);
```

```
75
```

`(float)found` turns 3 into 3.0 **before** the division, so `3.0 / 4` is 0.75.

### Idea — rounding on purpose

When cutting off isn't what you want, `Mathf` has the right tool. Each one
returns an `int`:

| Code | 3.2 | 3.5 | 3.7 | -3.7 |
| --- | --- | --- | --- | --- |
| `(int)x` | 3 | 3 | 3 | -3 |
| `Mathf.FloorToInt(x)`: always down | 3 | 3 | 3 | -4 |
| `Mathf.CeilToInt(x)`: always up | 4 | 4 | 4 | -3 |
| `Mathf.RoundToInt(x)`: to the nearest | 3 | 4 | 4 | -4 |

> **Watch out:** `Mathf.RoundToInt(2.5f)` is **2**, not 3. When a number is
> exactly halfway, Unity rounds to the nearest **even** number: 2.5 goes to 2,
> 3.5 goes to 4.

`Mathf` has other helpers you'll use constantly:

| Code | Result | Does |
| --- | --- | --- |
| `Mathf.Abs(-4)` | `4` | removes the minus sign |
| `Mathf.Max(3, 8)` | `8` | the bigger of two |
| `Mathf.Min(3, 8)` | `3` | the smaller of two |
| `Mathf.Clamp(15, 0, 10)` | `10` | keeps a value between a minimum and a maximum |
| `Mathf.Clamp(0.5f, 0f, 1f)` | `0.5` | already inside the range: unchanged |

`Mathf.Clamp` does in one line what took two `if`s in Level 1:
`x = Mathf.Clamp(x, -edge, edge);`.

### Idea — numbers and text

A `string` that looks like a number is still text. `"10" + 5` is `"105"`! To
turn text into a number, use `int.Parse` or, better, `int.TryParse`:

```csharp
string typed = "12";
if (int.TryParse(typed, out int age))
{
    Debug.Log("Next year you'll be " + (age + 1));
}
else
{
    Debug.Log("That's not a number");
}
```

```
Next year you'll be 13
```

`int.Parse("twelve")` would stop your game with a **FormatException**.
`int.TryParse` is the Try pattern: it returns `false` instead, so it's the safe
choice for anything a player types. `float.TryParse` works the same way for
decimals.

To turn a number into text, use `ToString()` or string interpolation, with a
format if you like:

| Code | Result | Format means |
| --- | --- | --- |
| `42.ToString()` | `"42"` | as it is |
| `$"{3.14159f:F2}"` | `"3.14"` | two decimals |
| `$"{7:D3}"` | `"007"` | at least three digits, padded with zeros |
| `3.14159f.ToString("F1")` | `"3.1"` | one decimal |

### Idea — reading type-mismatch errors

Each of these lines has a type problem. Learn to recognise the error and the
fix: the certification exam shows lines like these and asks what's wrong.

| Line | Error | Fix |
| --- | --- | --- |
| `int lives = 2.5f;` | CS0266: cannot implicitly convert `float` to `int` | `(int)2.5f`, or make `lives` a `float` |
| `float speed = 2.5;` | CS0664: literal of type `double`… | `2.5f` |
| `int score = "10";` | CS0029: cannot implicitly convert `string` to `int` | `int.Parse("10")`, or no quotes |
| `string label = 10;` | CS0029: cannot implicitly convert `int` to `string` | `10.ToString()` |
| `bool ready = 1;` | CS0029: cannot implicitly convert `int` to `bool` | `bool ready = true;` |

### Do it

1. Predict, then print: `10 / 4`, `10 / 4f`, `10 % 4`, `(int)9.99f`,
   `Mathf.RoundToInt(9.5f)` and `Mathf.RoundToInt(8.5f)`.
2. A level has 8 stars and you found 3. Print the percentage you found: first
   get `0`, then fix it with a cast to get `37.5`.
3. Make `string typed = "abc";` and use `int.TryParse` to print either the
   number doubled or `"That's not a number"`. Then change it to `"25"`.
4. Print your score as `"Score: 007"` using the `D3` format.

### Challenge

Write `string FormatTime(float seconds)` that turns `125.7f` into `"2:05"`:
minutes, a colon, then the seconds with two digits. You'll need
`Mathf.FloorToInt`, `/`, `%` and the `D2` format.
