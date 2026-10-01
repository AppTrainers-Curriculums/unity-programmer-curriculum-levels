## C# — Raycasts

**Goal:** you can shoot an invisible ray to find what's in a direction or under
the pointer, in 2D and in 3D, and choose what the ray is allowed to hit.

### Idea — a laser pointer made of maths

A **raycast** shoots an invisible line from a **start point**, in a
**direction**, up to a **maximum distance**, and tells you about the **first
collider** it hits. It's how games answer questions like these:

| Question | Ray |
| --- | --- |
| Can the enemy see the player, or is a wall in the way? | from the enemy towards the player |
| What did the player click or tap? | from the camera, through the pointer |
| Is there ground under my feet? | from the feet, straight down, a short distance |

Only objects with a **collider** can be hit: a ray passes straight through
anything without one.

### Idea — raycasts in 3D

```csharp
void Update()
{
    if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, 10f))
    {
        Debug.Log("I see " + hit.collider.name + ", " + hit.distance + " away");
    }
}
```

`Physics.Raycast` uses the Try pattern ({{ref:methods}}). It returns `true` if the
ray hit something, and fills in `hit` through the `out` parameter:

| Argument | Here |
| --- | --- |
| start point | `transform.position` |
| direction | `transform.forward`: the way this object faces |
| the result | `out RaycastHit hit` |
| maximum distance | `10f`: leave it out and the ray goes on forever |

| `hit.` | Gives |
| --- | --- |
| `collider` | the collider that was hit (and `hit.collider.gameObject`, its GameObject) |
| `point` | the exact world point where the ray hit it |
| `distance` | how far that point is from the start |
| `normal` | the direction the hit surface faces |

### Idea — raycasts in 2D

2D physics has its own raycast. It takes the same kind of arguments, but instead
of an `out` parameter, it **returns** the result:

```csharp
void Update()
{
    RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, 10f);
    if (hit.collider != null)
    {
        Debug.Log("I see " + hit.collider.name);
    }
}
```

If the ray hits nothing, `hit.collider` is `null`.

> **Watch out:** a 2D ray that starts **inside** a collider hits that collider
> first. If the object casting the ray has a collider of its own, the ray hits
> the object itself, every time! Start the ray just outside your own collider,
> or use a layer mask (below) that leaves out your own layer. 3D rays don't
> have this problem: they ignore a collider they start inside.

### Idea — seeing the ray

Rays are invisible, which makes them hard to get right. `Debug.DrawRay` draws a
line in the **Scene view** for one frame, so call it in `Update` next to your
raycast:

```csharp
Debug.DrawRay(transform.position, transform.forward * 10f, Color.red);
```

The second argument is the whole arrow: the direction **times** the length. To
see the line in the Game view too, turn on the **Gizmos** button in its toolbar.

### Idea — choosing what the ray can hit: layers

Every GameObject is on one **layer**, chosen in the **Layer** dropdown at the top
right of the Inspector. Layers are like tags, but physics understands them. Add
your own with **Layer → Add Layer…**, such as `Ground`, `Walls` or `Player`.

A **layer mask** is a list of layers a ray is allowed to hit. Make one a
`[SerializeField]` field, and the Inspector gives you a dropdown to tick
layers:

```csharp
[SerializeField] LayerMask wallsMask;

void Update()
{
    if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, 10f, wallsMask))
    {
        Debug.Log("A wall is in the way");
    }
}
```

The mask always goes **last**. In 2D:
`Physics2D.Raycast(transform.position, Vector2.right, 10f, wallsMask)`. You can
also build a mask in code: `LayerMask.GetMask("Walls", "Ground")`.

> **Tip:** the built-in **Ignore Raycast** layer does what it says: normal
> raycasts pass straight through anything on it.

### Idea — what's under the pointer?

In **3D**, the camera makes a ray through the pointer ({{ref:input}}), and a
normal raycast follows it into the scene:

```csharp
Ray ray = Camera.main.ScreenPointToRay(Pointer.current.position.ReadValue());
if (Physics.Raycast(ray, out RaycastHit hit, 100f))
{
    Debug.Log("Pointing at " + hit.collider.name + " at " + hit.point);
}
```

`Physics.Raycast` has an overload that takes a `Ray` (a start point and a
direction packed together) instead of the two separately.

In **2D**, the camera looks straight at the scene, so you don't need a ray: turn
the pointer into a world point, then ask which collider is **at** that point:

```csharp
Vector2 world = Camera.main.ScreenToWorldPoint(Pointer.current.position.ReadValue());
Collider2D found = Physics2D.OverlapPoint(world);
if (found != null)
{
    Debug.Log("Pointing at " + found.name);
}
```

### Do it

In a 3D scene (a 2D version follows):

1. Put your `Practice` object at (0, 0.5, 0) and a Cube at (0, 0.5, 5). Raycast
   forward from `Practice` and print what it hits and how far away.
2. Draw the ray with `Debug.DrawRay` and look at it in the Scene view while the
   game runs. Move the cube aside: the messages stop.
3. Add a second cube at (0, 0.5, 3). Put the far cube on a new layer, `Target`,
   and add a `LayerMask` field with only `Target` ticked: now the ray skips the
   near cube.
4. Print the name of whatever you click.

In a 2D scene: use two sprites with **Box Collider 2D**s and `Physics2D.Raycast`
along `Vector2.right`, and `Physics2D.OverlapPoint` for step 4.

### Challenge

Make a "security camera": an object that turns slowly (rotate it in `Update`) and
raycasts forward every frame. When the ray hits an object tagged `Player`, print
`"Spotted!"`, but only once each time the player comes into view.
