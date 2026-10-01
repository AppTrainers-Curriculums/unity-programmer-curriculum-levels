## C# — Vectors

**Goal:** you can use vectors for positions, movements and directions: add and
subtract them, measure them, and normalize them.

### Idea — a vector is an arrow

A `Vector3` holds three numbers, `x`, `y` and `z`; a `Vector2` holds two, `x`
and `y`. The same vector can mean two things:

| A vector as… | Example | Meaning |
| --- | --- | --- |
| a **position** | `transform.position` | a point: "where" |
| a **movement** or **direction** | `new Vector3(0, 5, 0)` | an arrow: "which way, and how far" |

Unity gives names to the arrows you need most:

| Name | Value | Name | Value |
| --- | --- | --- | --- |
| `Vector3.zero` | (0, 0, 0) | `Vector3.one` | (1, 1, 1) |
| `Vector3.up` | (0, 1, 0) | `Vector3.down` | (0, -1, 0) |
| `Vector3.right` | (1, 0, 0) | `Vector3.left` | (-1, 0, 0) |
| `Vector3.forward` | (0, 0, 1) | `Vector3.back` | (0, 0, -1) |

`Vector2` has the same names, without `forward` and `back`: `Vector2.up` is
(0, 1).

### Idea — vector maths

```csharp
Vector3 a = new Vector3(1, 2, 0);
Vector3 b = new Vector3(4, 6, 0);
Debug.Log(a + b);
Debug.Log(b - a);
Debug.Log(a * 3);
Debug.Log(b.x);
```

```
(5.00, 8.00, 0.00)
(3.00, 4.00, 0.00)
(3.00, 6.00, 0.00)
4
```

Unity prints vectors with two decimals. Each operation has a meaning:

- **`position + movement`** is a new position: where you end up after moving.
- **`b - a`** is the arrow **from `a` to `b`**. Remember it as
  **"target minus me"**.
- **`arrow * number`** makes the arrow longer (or shorter, with a number below 1).

### Idea — how long is an arrow?

An arrow's length is its **magnitude**. The distance between two points is the
length of the arrow between them, and `Vector3.Distance` works it out for you:

```csharp
Vector3 me = new Vector3(1, 2, 0);
Vector3 target = new Vector3(4, 6, 0);
Vector3 toTarget = target - me;
Debug.Log(toTarget.magnitude);
Debug.Log(Vector3.Distance(me, target));
```

```
5
5
```

Distance is how enemies decide the player is close enough to attack
(`if (Vector3.Distance(transform.position, player.position) < 3f)`), and how a
game decides a ball has stopped (`if (velocity.magnitude < 0.05f)`).

### Idea — a direction: normalize

A **direction** says "which way" and nothing else, so it should have a length of
exactly 1. `.normalized` gives you an arrow pointing the same way, with length
1:

```csharp
Vector3 toTarget = new Vector3(3, 4, 0);
Vector3 direction = toTarget.normalized;
Debug.Log(direction);
Debug.Log(direction.magnitude);
```

```
(0.60, 0.80, 0.00)
1
```

Why does it matter? To chase a target at a steady speed, you move along the
direction, times the speed:

```csharp
Vector3 direction = (target.position - transform.position).normalized;
transform.position += direction * speed * Time.deltaTime;
```

Without `.normalized`, the arrow is as long as the distance: the chaser would
rush when it's far away and crawl when it's close. With it, the speed is always
`speed`.

> **Tip:** `Vector3.MoveTowards(current, target, maxStep)` does the chasing for
> you: it moves `current` towards `target` by at most `maxStep`, and never
> overshoots.

### Idea — 2D and 3D together

A `Vector2` turns into a `Vector3` automatically (with `z = 0`), and a `Vector3`
turns into a `Vector2` by dropping `z`:

```csharp
Vector2 flat = new Vector2(3, 4);
Vector3 deep = flat;
Debug.Log(deep);
```

```
(3.00, 4.00, 0.00)
```

In a 3D game where things move on the ground, you often want a direction that
stays **flat**: set `y` to 0 before you normalize, so nothing aims into the floor
or up at the sky:

```csharp
Vector3 aim = target - transform.position;
aim.y = 0f;
aim = aim.normalized;
```

### Idea — the way an object faces

Every Transform knows its own arrows, and they turn when the object turns:

| Property | In 2D | In 3D |
| --- | --- | --- |
| `transform.up` | the way the sprite's top points | the object's up |
| `transform.right` | the way the sprite's right side points | the object's right |
| `transform.forward` | into the screen: not useful in 2D | the way the object faces |

They also work the other way: **set** one to turn the object.
`transform.up = direction;` turns a 2D sprite so its top points along
`direction`, and `transform.forward = direction;` turns a 3D object to face
`direction`.

### Do it

1. Make two points, `(2, 1, 0)` and `(5, 5, 0)`. Print the arrow from the first
   to the second, its length, and its direction.
2. Print `Vector3.Distance` between them. Does it match the length?
3. Print `Vector3.up * 3 + Vector3.right`. Draw the arrow on paper first.
4. Make an object chase another one in `Update` with a normalized direction and
   a `[SerializeField] float speed`. Then remove `.normalized` and watch the
   difference.

### Challenge

Make an object **patrol**: give it two points, A and B, and use
`Vector3.MoveTowards` in `Update` to move it to B, then back to A, forever. When
`Vector3.Distance` to the point it's heading for is less than 0.01, swap to the
other point. Then make it face the way it's moving (`transform.up` in 2D,
`transform.forward` in 3D).
