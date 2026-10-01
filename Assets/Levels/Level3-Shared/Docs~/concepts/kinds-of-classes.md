## C# — Kinds of Classes

**Goal:** you can tell a MonoBehaviour, a plain C# class, a ScriptableObject and an ECS
class apart from their code, and say what each is for. Exam objective U 3.4 asks you to
tell an ECS class from the others.

### Idea — four kinds, at a glance

| Kind | Its first line looks like | Lives | You make one with |
| --- | --- | --- | --- |
| **MonoBehaviour** | `public class Coin : MonoBehaviour` | on a GameObject, as a component | **Add Component**, or `AddComponent<Coin>()` |
| **plain C# class** | `public class Wave` | inside other objects, in memory | `new Wave(…)` |
| **ScriptableObject** | `public class EnemyStats : ScriptableObject` | in the Project, as an asset | **Assets → Create → …**, from `[CreateAssetMenu]` |
| **ECS** (Entities) | `public struct Speed : IComponentData` | in Unity's Entities system, with no GameObject | the Entities package's own tools |

The part after the colon is the giveaway: it says what the class is built on.

### Idea — MonoBehaviour: a component

Every script you've attached to a GameObject is a MonoBehaviour. It gets the event
functions (`Awake`, `Start`, `Update`, `OnTriggerEnter2D`…), a `transform`, a
`gameObject`, and `[SerializeField]` fields in the Inspector.

- Its **file name must match its class name**: `Coin.cs` for `class Coin`.
- You can't make one with `new`. Unity has to make it, on a GameObject:
  `gameObject.AddComponent<Coin>()`.
- It only exists while its GameObject does.

### Idea — plain C# classes: data and logic

A class that isn't built on anything is a plain C# class, like Level 2's `Wave`. You
make as many as you like with `new`, and they're perfect for data and the logic that
goes with it.

Mark one `[System.Serializable]`, and Unity can show it **inside** a MonoBehaviour's
Inspector, and save it in the scene with it. An array of them becomes a list you can
fill in, item by item:

```csharp
using UnityEngine;

[System.Serializable]
public class Level
{
    [SerializeField] string title;
    [SerializeField] int coinsToWin = 10;

    public string Title
    {
        get { return title; }
    }

    public int CoinsToWin
    {
        get { return coinsToWin; }
    }
}
```

```csharp
using UnityEngine;

public class LevelList : MonoBehaviour
{
    [SerializeField] Level[] levels;

    void Start()
    {
        foreach (Level level in levels)
        {
            Debug.Log($"{level.Title}: {level.CoinsToWin} coins");
        }
    }
}
```

In the Inspector, **Levels** shows a size, and each element opens into its own **Title**
and **Coins To Win**. Without `[System.Serializable]`, the field doesn't show at all.

### Idea — ScriptableObject: data as an asset

A ScriptableObject is a class whose objects are **assets**, saved in the Project like a
material or a clip. Many objects can point to the same one: give fifty enemies one
`EnemyStats` asset, change its health once, and all fifty change.

```csharp
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Enemy Stats")]
public class EnemyStats : ScriptableObject
{
    [SerializeField] int maxHealth = 3;
    [SerializeField] float speed = 2f;

    public int MaxHealth
    {
        get { return maxHealth; }
    }

    public float Speed
    {
        get { return speed; }
    }
}
```

`[CreateAssetMenu]` adds **Assets → Create → Game → Enemy Stats** to the menus. A
ScriptableObject has no `transform` and no `Update`: it's data, not a thing in the
scene.

> **Note:** in Level 3 you only need to recognise one. Level 4 is where you make your
> own, and use them to share settings between scenes.

### Idea — ECS: entities, components and systems

Unity also has a second, very different way to build games: **ECS**, the Entity
Component System, from the Entities package (part of DOTS). It's made for huge numbers
of things, such as a hundred thousand fish, and it splits everything that a
MonoBehaviour holds together:

| ECS part | Is | Looks like |
| --- | --- | --- |
| **entity** | an ID, with no code and no GameObject | (you don't write a class for it) |
| **component** | a `struct` of data only, no methods | `public struct Speed : IComponentData` |
| **system** | the code that runs over every entity with certain components | `public partial struct MoveSystem : ISystem` |

```csharp
// … needs the Entities package, which this project doesn't have: for reading only.
using Unity.Entities;

public struct Speed : IComponentData
{
    public float Value;
}

public partial struct MoveSystem : ISystem
{
    public void OnUpdate(ref SystemState state)
    {
        // … moves every entity that has a Speed component …
    }
}
```

What gives ECS code away: `struct` instead of `class`, `IComponentData`, `ISystem` or
`SystemBase`, `partial`, `using Unity.Entities;`, and no `MonoBehaviour` anywhere.

> **Note:** this course doesn't use ECS; recognising it is all the exam asks.

### Idea — two more you already use

| Kind | Example | Means |
| --- | --- | --- |
| **struct** | `Vector2`, `Color`, `RaycastHit2D` | like a class, but copied whenever you pass it or assign it: change the copy, and the original stays the same |
| **static class** | `Mathf`, `Debug`, `Physics2D` | no objects at all: you call its methods through its name, as in `Mathf.Clamp(…)` |

### Idea — how the exam asks

*Which of these is a component in Unity's Entity Component System?*

- A. `public class Health : MonoBehaviour { public int value; }`
- B. `public struct Health : IComponentData { public int Value; }`
- C. `public class Health : ScriptableObject { public int value; }`
- D. `[System.Serializable] public class Health { public int value; }`

**B**: a `struct` built on `IComponentData`. A is a MonoBehaviour component, which is a
different thing with the same word in its name; C is an asset; D is a plain class.

### Do it

1. Make the `Level` and `LevelList` scripts. Fill in three levels in the Inspector and
   play. Then remove `[System.Serializable]`, and watch the list disappear from the
   Inspector.
2. Make the `EnemyStats` ScriptableObject, create two assets from the menu, and give a
   test script a `[SerializeField] EnemyStats stats;` field that logs `stats.MaxHealth`.
3. For each script in your current game, say which kind of class it is.
4. Try `new` on a MonoBehaviour (`Coin coin = new Coin();`) in a Practice script. It
   compiles, and Unity warns while playing. Read what it says.

### Challenge

Explain to a partner, in two sentences each: when would you use a plain C# class instead
of a MonoBehaviour? When a ScriptableObject instead of a plain class? Then find one place
in your game where you'd make the change.
