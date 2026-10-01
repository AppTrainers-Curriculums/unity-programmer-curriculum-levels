## C# — Properties and Constructors

**Goal:** you can write a class whose fields are protected by properties, and give
every new object its starting values through a constructor.

### Idea — a class you can trust

In Level 1 you wrote a small class with public fields:

```csharp
public class Spaceship
{
    public string shipName;
    public int fuel;
}
```

It works, but **any** script can do anything to it: `ship.fuel = -500;` compiles
without a murmur. A good class protects its data, so its objects can never get
into a state that makes no sense. C# gives you two tools for that:

| Tool | Answers the question |
| --- | --- |
| **Property** | "Who may read this value, and who may change it?" |
| **Constructor** | "What values must every new object start with?" |

### Idea — properties

A **property** looks like a field from the outside, but it controls access:

```csharp
public class Player
{
    public int Score { get; private set; }   // anyone can read it, only Player can change it

    public void AddPoints(int points)
    {
        Score += points;
    }
}
```

| Part | Meaning |
| --- | --- |
| `public int Score` | Other scripts can see `Score`. Properties use **PascalCase**, like methods. |
| `get;` | Reading is allowed (with the property's access: public here) |
| `private set;` | Changing it is only allowed **inside** this class |

```csharp
Player player = new Player();
player.AddPoints(10);
player.AddPoints(5);
Debug.Log(player.Score);
```

```
15
```

Outside the class, `player.Score = 999;` is now an error: *The property or indexer
'Player.Score' cannot be used in this context because the set accessor is
inaccessible* (CS0272). The only way to change the score is `AddPoints`, so the
class decides the rules.

### Idea — a property that works something out

A property can also **calculate** its value every time it's read. It has a `get`
with a body, and no `set`:

```csharp
public class Player
{
    public int Score { get; private set; }
    public int Lives { get; private set; } = 3;

    public bool IsAlive
    {
        get { return Lives > 0; }
    }

    public void LoseLife()
    {
        Lives--;
    }
}
```

```csharp
Player player = new Player();
Debug.Log(player.IsAlive);
player.LoseLife();
player.LoseLife();
player.LoseLife();
Debug.Log(player.IsAlive);
```

```
True
False
```

`IsAlive` is never stored: it's worked out from `Lives` when you ask. So it can
never be out of date. Note `= 3` after `Lives { get; private set; }`: a property
can have a starting value, like a field.

### Idea — constructors

A **constructor** is a special method that runs **once**, when an object is
built with `new`. It has the **same name as the class** and **no return type**.
Its parameters are the values every new object needs:

```csharp
public class Ticket
{
    public string Owner { get; private set; }
    public int Seat { get; private set; }

    // The constructor: runs once, when the ticket is created
    public Ticket(string owner, int seat)
    {
        Owner = owner;
        Seat = seat;
    }
}
```

```csharp
Ticket mine = new Ticket("Lina", 12);
Ticket yours = new Ticket("Omar", 14);
Debug.Log(mine.Owner + " sits in seat " + mine.Seat);
Debug.Log(yours.Owner + " sits in seat " + yours.Seat);
```

```
Lina sits in seat 12
Omar sits in seat 14
```

Now it's impossible to make a ticket without an owner and a seat:
`new Ticket()` is an error, because the only constructor needs two arguments.

### Idea — this

When a parameter has the same name as a field or property, `this.` means "the
one that belongs to this object":

```csharp
public class Ticket
{
    int seat;

    public Ticket(int seat)
    {
        this.seat = seat;   // this.seat is the field; seat is the parameter
    }
}
```

> **Watch out:** a constructor is only for **plain C# classes** like `Ticket` and
> `Player` here. A `MonoBehaviour` never has a constructor you call: Unity builds
> it when the component is added. Use `Awake()` or `Start()` for its setup
> instead.

### Idea — when to use what

| You want… | Use |
| --- | --- |
| a value other scripts can read but not change | `public int Score { get; private set; }` |
| a value worked out from other values | a property with only a `get` body |
| a value tuned in the Inspector | `[SerializeField] float speed = 5f;` (a field, not a property) |
| every new object to start with the right values | a constructor |

> **Note:** Unity shows **fields** in the Inspector, not properties. Keep
> `[SerializeField]` fields for tuning, and use properties for values other
> scripts read.

### Do it

1. Write a class `BankAccount` with a property `Balance` (public get, private set),
   a method `Deposit(int amount)`, and a method `Withdraw(int amount)` that only
   takes the money out if the balance is big enough. Test it in `Start()`.
2. Give `BankAccount` a constructor that takes the owner's name and a starting
   balance, and a computed property `IsEmpty`.
3. Try `account.Balance = 1000000;` from `Start()`, and read the error.

### Challenge

Write a class `Timer` with a constructor that takes a duration in seconds, a
method `Tick(float seconds)` that counts down, and two computed properties:
`TimeLeft` (never below 0) and `IsFinished`.
