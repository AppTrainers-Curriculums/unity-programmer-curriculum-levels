## C# — Mouse and Touch

**Goal:** you can read the mouse and the touchscreen with the Input System, turn
a screen position into a world position, and test touch without a phone.

### Idea — the same pattern as the keyboard

In Level 1 you read keys like this: `Keyboard.current.spaceKey.wasPressedThisFrame`.
A device, then a control on it, then a question. The mouse and the touchscreen
work the same way:

| You want to know… | Mouse | Touchscreen |
| --- | --- | --- |
| is it held down? | `Mouse.current.leftButton.isPressed` | `Touchscreen.current.primaryTouch.press.isPressed` |
| was it pressed this frame? | `Mouse.current.leftButton.wasPressedThisFrame` | `Touchscreen.current.primaryTouch.press.wasPressedThisFrame` |
| was it released this frame? | `Mouse.current.leftButton.wasReleasedThisFrame` | `Touchscreen.current.primaryTouch.press.wasReleasedThisFrame` |
| where is it? | `Mouse.current.position.ReadValue()` | `Touchscreen.current.primaryTouch.position.ReadValue()` |

`primaryTouch` is the first finger on the screen. `ReadValue()` gives the
position as a `Vector2` in **pixels**, where (0, 0) is the **bottom-left**
corner of the Game view.

```csharp
void Update()
{
    if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
    {
        Vector2 where = Mouse.current.position.ReadValue();
        Debug.Log("Click at " + where);
    }
}
```

```
Click at (412.00, 230.00)
```

(Your numbers depend on where you click.)

> **Watch out:** a computer without a touchscreen has no `Touchscreen.current`:
> it's `null`. A phone may have no `Mouse.current`. Check for `null` before you
> use a device, as the example does.

### Idea — Pointer: the mouse or a finger

Most games don't care whether the player clicks or taps. **`Pointer.current`**
is whichever pointing device was used last: the mouse on a computer, the finger
on a phone. It has a `press` and a `position`, so one piece of code handles
both:

```csharp
void Update()
{
    Pointer pointer = Pointer.current;
    if (pointer != null && pointer.press.wasPressedThisFrame)
    {
        Debug.Log("Pressed at " + pointer.position.ReadValue());
    }
}
```

On a computer, `press` is the left mouse button; on a phone, it's the first
finger. The games in this book use `Pointer`, so they work with a mouse and with
a touchscreen without any changes.

### Idea — from the screen to the world

Pixels aren't world units: pixel (400, 300) might be the point (1.5, -2) in your
scene. The **camera** converts between them:

| Game | Code | Gives |
| --- | --- | --- |
| 2D | `Camera.main.ScreenToWorldPoint(screenPosition)` | the world point under the pointer |
| 3D | `Camera.main.ScreenPointToRay(screenPosition)` | a **ray** from the camera through the pointer (use it with a raycast: {{ref:raycasts}}) |

In 2D, this moves an object to wherever you click or tap:

```csharp
Pointer pointer = Pointer.current;
if (pointer != null && pointer.press.wasPressedThisFrame)
{
    Vector3 world = Camera.main.ScreenToWorldPoint(pointer.position.ReadValue());
    world.z = 0f;
    transform.position = world;
}
```

`ScreenToWorldPoint` returns a point at the camera's depth (`z = -10`), so set
`z` back to 0 before you use it.

### Idea — a drag: press, hold, release

A drag has three moments. Remember where it **started**, follow it while it's
**held**, and use it when it's **released**:

```csharp
Vector2 dragStart;

void Update()
{
    Pointer pointer = Pointer.current;
    if (pointer == null)
    {
        return;
    }

    if (pointer.press.wasPressedThisFrame)
    {
        dragStart = pointer.position.ReadValue();
    }

    if (pointer.press.wasReleasedThisFrame)
    {
        Vector2 drag = pointer.position.ReadValue() - dragStart;
        Debug.Log("You dragged " + drag.magnitude + " pixels");
    }
}
```

`return;` on its own leaves a `void` method straight away. Here it means "no
pointer at all: nothing to do this frame".

### Idea — testing touch without a phone

You don't need a phone to test touch. Unity has two ways to turn your mouse into
a finger:

1. **The Device Simulator.** In the Game view's toolbar, open the **Game**
   dropdown on the left and choose **Simulator** (or use **Window → General →
   Device Simulator**). Pick a phone at the top: the Game view takes its shape,
   and your clicks inside it become touches.
2. **The Input Debugger.** Open **Window → Analysis → Input Debugger**, then
   **Options → Simulate Touch Input From Mouse or Pen**. Your mouse now also
   acts as a finger in the normal Game view.

### Idea — the older Input class

Unity 6 projects read input with the **Input System** package, as this book
does. Older projects, and many exam questions, use the older `Input` class.
Learn to read both:

| Input System (this book) | Older `Input` class |
| --- | --- |
| `Mouse.current.leftButton.wasPressedThisFrame` | `Input.GetMouseButtonDown(0)` |
| `Mouse.current.leftButton.isPressed` | `Input.GetMouseButton(0)` |
| `Mouse.current.leftButton.wasReleasedThisFrame` | `Input.GetMouseButtonUp(0)` |
| `Mouse.current.position.ReadValue()` | `Input.mousePosition` |
| `Touchscreen.current.primaryTouch.press.isPressed` | `Input.touchCount > 0` |
| `Touchscreen.current.primaryTouch.position.ReadValue()` | `Input.GetTouch(0).position` |
| `…primaryTouch.press.wasPressedThisFrame` | `Input.GetTouch(0).phase == TouchPhase.Began` |
| `…primaryTouch.press.wasReleasedThisFrame` | `Input.GetTouch(0).phase == TouchPhase.Ended` |

> **Watch out:** in a project that uses the Input System only, the older `Input`
> class throws an **InvalidOperationException** as soon as it runs: *You are
> trying to read Input using the UnityEngine.Input class, but you have switched
> active Input handling to Input System package in Player Settings.*

### Do it

1. Print the mouse position every time you click in the Game view. Click the
   bottom-left corner, then the top-right. What are the numbers?
2. Use `Pointer` to print `"Down"` when it's pressed, then `"Up"` and how long
   the press lasted when it's released (use `Time.time`).
3. Make an object jump to wherever you click (2D: `ScreenToWorldPoint`).
4. Switch the Game view to the Simulator, choose a phone, and test step 2 with
   "touches".

### Challenge

A swipe detector: when the pointer is released, if the drag is longer than 100
pixels, print `"Swipe left"`, `"Swipe right"`, `"Swipe up"` or `"Swipe down"`.
Compare `Mathf.Abs(drag.x)` with `Mathf.Abs(drag.y)` to decide whether the swipe
was mostly sideways or mostly up and down.
