## C# — Components and GetComponent

**Goal:** you can get any component of a GameObject from code, reach the
components of other objects, and choose between an Inspector reference and
`GetComponent`.

### Idea — a GameObject is a box of components

Everything you see in the Inspector under a GameObject's name is a
**component**: the Transform, a Sprite Renderer, a Rigidbody, a Collider, and
your own scripts. Your script is one component among the others, and to use
another component it needs a **reference** to it. There are two ways to get one:

| Way | How | Use it when the component is… |
| --- | --- | --- |
| An Inspector reference | a `[SerializeField]` field you fill by dragging | on another object you know in advance: the camera, the game manager |
| `GetComponent<T>()` | code that finds a component of type `T` | on the **same** object, or on an object you just hit, touched or created |

### Idea — GetComponent

`GetComponent<T>()` looks through the GameObject's components and returns the
first one of type `T`. The type goes between angle brackets, as in `List<int>`.
If there's no component of that type, it returns `null`.

To try it, add an **Audio Source** component to your `Practice` object (**Add
Component → Audio → Audio Source**):

```csharp
void Start()
{
    AudioSource source = GetComponent<AudioSource>();
    Debug.Log(source);
    Debug.Log(source.volume);

    Rigidbody2D body = GetComponent<Rigidbody2D>();
    Debug.Log(body == null);
}
```

```
Practice (UnityEngine.AudioSource)
1
True
```

- Unity prints a component as its **GameObject's name** followed by its type.
- `source.volume` reads a property of the component, as if you'd looked in the
  Inspector.
- The object has no Rigidbody 2D, so `GetComponent<Rigidbody2D>()` returned
  `null`.

### Idea — get it once, in Awake

`GetComponent` searches the object every time you call it. That's fine once, but
wasteful 60 times a second in `Update`. Get it **once**, in `Awake`, and keep it
in a field:

```csharp
AudioSource source;

void Awake()
{
    source = GetComponent<AudioSource>();
}

void Update()
{
    if (Keyboard.current.mKey.wasPressedThisFrame)
    {
        source.mute = !source.mute;
    }
}
```

This is called **caching** the reference, and it's why `Awake` is the place for
"get my own components".

### Idea — making sure it's there: RequireComponent

If your script can't work without a component, say so above the class:

```csharp
[RequireComponent(typeof(AudioSource))]
public class Practice : MonoBehaviour
{
```

Now, when you add `Practice` to an object, Unity adds an Audio Source too, and
won't let anyone remove it while `Practice` is there. Your `GetComponent` can't
come back empty. (`typeof(AudioSource)` means "the type AudioSource itself".)

### Idea — components of other objects

Any GameObject or component can call `GetComponent`, so you can reach into
another object:

| You have | Its component |
| --- | --- |
| `GameObject enemy` | `enemy.GetComponent<Rigidbody2D>()` |
| `Collider2D other` in `OnTriggerEnter2D` | `other.GetComponent<Health>()` |
| `GameObject copy = Instantiate(prefab)` | `copy.GetComponent<AudioSource>()` |

When the other object **might not** have the component, check before you use
it:

```csharp
void OnTriggerEnter2D(Collider2D other)
{
    Health health = other.GetComponent<Health>();
    if (health != null)
    {
        health.TakeDamage(10);
    }
}
```

`TryGetComponent` does the same in one step, with the Try pattern and an `out`
parameter ({{ref:methods}}):

```csharp
void OnTriggerEnter2D(Collider2D other)
{
    if (other.TryGetComponent(out Health health))
    {
        health.TakeDamage(10);
    }
}
```

Here `Health` stands for one of your own scripts. Your scripts are components
like any other, so `GetComponent` finds them too.

### Idea — the shortcuts you already use

Every component comes with two ready-made references:

| Shortcut | Means |
| --- | --- |
| `transform` | this object's Transform. Every GameObject has one, so Unity keeps it ready for you. |
| `gameObject` | the GameObject this component is on |

So `other.gameObject` (Level 1) is the GameObject of the collider you touched,
and `other.transform.position` is where it is.

GetComponent has relatives, for when the component is somewhere else in the
family:

| Method | Looks in |
| --- | --- |
| `GetComponent<T>()` | this GameObject |
| `GetComponentInChildren<T>()` | this GameObject, then its children |
| `GetComponentInParent<T>()` | this GameObject, then its parent, and its parent… |
| `GetComponents<T>()` | this GameObject, and returns **all** of them in an array |

> **Note:** Unity can also search the **whole scene**, with
> `GameObject.Find("Player")` or `FindAnyObjectByType<GameManager>()`. They're
> slow, and `Find` breaks as soon as someone renames the object. Prefer
> Inspector references, and never search the scene in `Update`.

### Do it

1. Add an Audio Source to your `Practice` object. In `Start()`, get it and print
   its `volume` and `loop`. Change them in the Inspector and run again.
2. Print `GetComponent<Transform>() == transform`. What does it tell you?
3. Get a `Rigidbody2D` (or a `Rigidbody`) that isn't there, then use it anyway:
   print `body.mass`. Read the error: {{ref:null}} explains it.
4. Cache the Audio Source in `Awake`, and make the **M** key mute and unmute it
   in `Update`.

### Challenge

Make a second GameObject called `Speaker` with an Audio Source. Give `Practice` a
field `[SerializeField] GameObject speaker;` and drag `Speaker` into it. In
`Start()`, get the speaker's Audio Source with `GetComponent` and set its volume
to `0.25f`. Press Play and check the speaker's Inspector.
