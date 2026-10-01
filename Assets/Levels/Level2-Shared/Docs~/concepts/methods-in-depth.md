## C# — Methods in Depth

**Goal:** you can read any method declaration, choose its return type and
parameters, give one name several versions (overloading), and hand back extra
values with `out`.

### Idea — the parts of a declaration

You've written methods since Level 0. Here's every part of a declaration, named:

```csharp
public int AddPoints(int points, bool doubled)
{
    // the body
}
```

| Part | Here | Meaning |
| --- | --- | --- |
| Access | `public` | who may call it; leave it out for `private` |
| Return type | `int` | the type of value it gives back, or `void` for nothing |
| Name | `AddPoints` | PascalCase, usually a verb |
| Parameters | `(int points, bool doubled)` | the values it needs, each with a type and a name |
| Body | `{ … }` | the code that runs when it's called |

The **name** plus the **parameter types** make the method's **signature**:
`AddPoints(int, bool)`. The return type isn't part of the signature, and that
matters for overloading below.

### Idea — return types

A method with a return type **must** return a value of that type, on **every**
path through it:

```csharp
string Grade(int score)
{
    if (score >= 90)
    {
        return "A";
    }
    else if (score >= 50)
    {
        return "Pass";
    }
    // no return for scores under 50: error CS0161
}
```

The error is *'Practice.Grade(int)': not all code paths return a value*
(CS0161). A score of 30 reaches the end of the method with nothing to give back.
Add `return "Fail";` as the last line and it's fixed.

A method can return any type: `bool`, `float`, `string`, `Vector3`, even a
`GameObject`. A method that answers a yes/no question usually returns `bool` and
starts with `Is`, `Has` or `Can`:

```csharp
bool IsEven(int number)
{
    return number % 2 == 0;
}
```

```csharp
Debug.Log(IsEven(10));
Debug.Log(IsEven(7));
Debug.Log(Grade(95) + " and " + Grade(60));
```

```
True
False
A and Pass
```

The value a method returns has a type, just like a variable.
`int result = Grade(95);` is an error, *Cannot implicitly convert type 'string'
to 'int'* (CS0029), because `Grade` returns a `string`.

### Idea — parameters

Parameters are the method's inputs, and **arguments** are the values you pass
when you call it. They're matched **by position**, so the call needs the right
number of arguments, of the right types, in the right order:

| Call | Result |
| --- | --- |
| `AddPoints(10, true)` | fine |
| `AddPoints(10)` | error CS7036: *There is no argument given that corresponds to the required parameter 'doubled' of 'Practice.AddPoints(int, bool)'* |
| `AddPoints("ten", true)` | error CS1503: *Argument 1: cannot convert from 'string' to 'int'* |

A parameter can have a **default value**. Then the argument is **optional**:

```csharp
void Heal(int amount = 10)
{
    Debug.Log("Healed " + amount);
}
```

```csharp
Heal(25);
Heal();
```

```
Healed 25
Healed 10
```

Unity's methods use default values a lot. In the Scripting API you'll see
declarations like `AddForce(Vector3 force, ForceMode mode = ForceMode.Force)`:
the second argument is optional.

### Idea — overloading: one name, several versions

Several methods can share a name, as long as their **parameter lists differ**
(a different number of parameters, or different types). C# picks the version
whose parameters match your arguments:

```csharp
void Greet()
{
    Debug.Log("Hello!");
}

void Greet(string name)
{
    Debug.Log("Hello, " + name + "!");
}

void Greet(string name, int times)
{
    for (int i = 0; i < times; i++)
    {
        Greet(name);
    }
}
```

```csharp
Greet();
Greet("Lina");
Greet("Omar", 2);
```

```
Hello!
Hello, Lina!
Hello, Omar!
Hello, Omar!
```

Notice that the third version calls the second one: overloads often share the
work this way. Overloads can also differ by **type**:

```csharp
int Half(int value)
{
    return value / 2;
}

float Half(float value)
{
    return value / 2;
}
```

```csharp
Debug.Log(Half(7));
Debug.Log(Half(7f));
```

```
3
3.5
```

`7` is an `int`, so C# runs the `int` version (and whole-number division drops
the .5). `7f` is a `float`, so it runs the `float` version.

You've been using overloads since Level 1. `Instantiate` has several versions:
`Instantiate(prefab)`, `Instantiate(prefab, parent)`,
`Instantiate(prefab, position, rotation)` and
`Instantiate(prefab, position, rotation, parent)`. And `Random.Range` has an
`int` version, which never returns the top number, and a `float` version, which
can.

> **Watch out:** the return type alone isn't enough to tell overloads apart.
> `int Speed()` and `float Speed()` in the same class give error CS0111: *Type
> 'Practice' already defines a member called 'Speed' with the same parameter
> types*. Parameter **names** don't count either: only their number and types.

### Idea — out: handing back more than one value

A method returns **one** value. When it needs to hand back more, it can use an
**`out` parameter**: the method fills in a variable that belongs to the caller.

```csharp
bool TryDivide(int a, int b, out int result)
{
    if (b == 0)
    {
        result = 0;
        return false;
    }
    result = a / b;
    return true;
}
```

```csharp
if (TryDivide(10, 2, out int answer))
{
    Debug.Log("10 / 2 = " + answer);
}

if (!TryDivide(5, 0, out int nothing))
{
    Debug.Log("You can't divide by zero");
}
```

```
10 / 2 = 5
You can't divide by zero
```

- `out int answer` creates a new variable, `answer`, right in the call. After the
  call, it holds whatever the method put in `result`.
- The method **must** give every `out` parameter a value before it returns, on
  every path (error CS0177 otherwise). That's why `result = 0;` is there even
  when dividing fails.
- The method returns `true` if it worked and `false` if it didn't. This is the
  **Try pattern**, and it's all over C# and Unity: `int.TryParse`,
  `TryGetComponent`, `TryGetValue`, and `Physics.Raycast(…, out RaycastHit hit)`
  all work like `TryDivide`.

### Do it

1. Write `int Biggest(int a, int b)` that returns the bigger number, and an
   overload `int Biggest(int a, int b, int c)` that uses the first one. Print
   `Biggest(4, 9)` and `Biggest(4, 9, 2)`.
2. Write `string Describe(int score)` that returns `"Great"` (100 or more),
   `"Good"` (50 or more) or `"Keep going"`. Remove the last `return` and read the
   error, then put it back.
3. Give `Describe` a second parameter `string player = "You"`, and make it
   return text like `"Sara: Great"`. Call it with and without a name.
4. Write `bool TryBuy(int price, int coins, out int change)`. When you have
   enough coins, print the change; when you don't, print `"Not enough coins"`.

### Challenge

Overload a method `Area`: `Area(float side)` for a square and
`Area(float width, float height)` for a rectangle, then print both. Now add
`int Area(float side)` and read the error. Which rule did it break?
