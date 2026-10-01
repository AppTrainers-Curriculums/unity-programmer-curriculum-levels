## C# — The Animation Window

**Goal:** you can make animation clips in Unity's Animation window: clips that swap a
sprite's frames, and clips that change properties such as position, scale and colour
over time.

### Idea — what a clip is

An **animation clip** is an asset (a `.anim` file) that says how some properties of a
GameObject change over time. Each property gets a **curve**: its value at every moment
of the clip. The moments you set by hand are **keyframes**, and Unity works out every
moment in between.

| A clip can change… | For example |
| --- | --- |
| a Sprite Renderer's **Sprite** | a run made of 16 pictures, one after another |
| a Transform's **Position**, **Rotation** or **Scale** | a coin bobbing up and down, a door swinging |
| a Sprite Renderer's **Color** | a flash of red, a fade to nothing |
| almost any number, colour or tick box of a component | a light's brightness, a collider's size |

There are two kinds of animation in a 2D game, and one clip can mix them:

- **Sprite-frame animation:** a series of drawings shown one after another, like a
  flip-book. A curve of the Sprite property, with one keyframe per drawing.
- **Property animation:** one drawing, moved, turned, scaled or tinted. Curves of
  numbers.

> **Note:** a clip changes values, nothing more. It can't run your code, except
> through Animation Events ({{ref:animevents}}).

### Idea — the window

Open it with **Window → Animation → Animation** (or **Ctrl + 6**, **Cmd + 6** on a
Mac), and dock it beside the Console. It always shows the clips of the GameObject
selected in the Hierarchy.

| Part | What it does |
| --- | --- |
| **Clip menu** (top-left) | the selected object's clips; **Create New Clip…** adds another |
| **Record** (the red dot) | while it's on, every change you make in the Inspector becomes a keyframe |
| **Add Property** | adds a curve for one property, without recording |
| **Timeline** | time runs left to right; the white line is the **playhead** |
| **Add Keyframe** and **Add Event** | add a keyframe, or an Animation Event, at the playhead |
| **Dopesheet** / **Curves** (bottom) | keyframes as diamonds, or the curves themselves |

To make the first clip of an object, select it and click **Create** in the Animation
window, then save the clip, for example as `Assets/Animation/Door Open.anim`. If the
object has no **Animator** yet, Unity adds one, and makes an **Animator Controller** for
it, named after the object. The next chapter is about that controller.

### Idea — frames per second

A clip has a **sample rate**: how many frames it shows in a second. Pixel-art
animations are drawn for 8 to 16 frames a second, not the 60 the window starts with.
In the Animation window's **⋮** menu, tick **Show Sample Rate**, and a **Samples**
field appears. Set it **before** you add sprite frames: dragged frames land one sample
apart.

| Samples | One frame lasts | 8 frames take |
| --- | --- | --- |
| 8 | 0.125 s | 1 s |
| 12 | 0.083 s | 0.67 s |
| 16 | 0.0625 s | 0.5 s |

### Idea — a sprite-frame clip

1. Slice the sprite sheet first (Sprite Mode **Multiple**, then the **Sprite Editor**),
   so that each frame is its own sprite.
2. Select the GameObject, and create a clip.
3. Set **Samples**.
4. In the Project window, open the sheet's arrow, click its first frame, Shift-click
   its last, and drag them all into the timeline.

Unity puts one keyframe on each sample, and the clip lasts as long as its frames: 16
frames at 16 samples make a one-second clip. Press the window's **Play** button to
watch it in the Scene view.

### Idea — a property clip

1. Select the GameObject, create a clip, and turn on **Record**.
2. Move the playhead to `0:00` and set a property in the Inspector, for example
   **Position Y** to `0`. A keyframe appears, and the property turns red in the
   Inspector: it's animated now.
3. Move the playhead to `0:30` (half a second, at 60 samples) and set **Position Y** to
   `0.5`. Another keyframe.
4. Move to `1:00` and set it back to `0`. Turn **Record** off, and play: the object bobs.

The numbers in the timeline are **seconds:frames**: `1:30` is one second and 30
frames.

**Add Property** does the same without recording: pick the component and the property,
and Unity adds a curve with two keyframes you can then move and change.

> **Watch out:** forgetting to turn **Record** off is the classic mistake. Every change
> you make to the object afterwards, even moving it in the scene, turns into another
> keyframe. If a value keeps snapping back while you edit, look for the red dot.

### Idea — curves and tangents

In **Curves** view you see how a value moves between its keyframes. A keyframe's
**tangents** set the shape of the curve: right-click a keyframe to choose.

| Tangent | The value… | Good for |
| --- | --- | --- |
| **Auto** / **Clamped Auto** (the default) | eases in and out smoothly | bobbing, swinging |
| **Linear** | changes at a steady rate | fades, steady turns |
| **Constant** | jumps at the keyframe and holds | blinking, on/off |

A Sprite curve always jumps: a picture can't be halfway between two pictures.

### Idea — the clip's own settings

Select the clip asset in the Project window to see its Inspector:

| Setting | Means |
| --- | --- |
| **Loop Time** | when the clip ends, it starts again: on for idle and run, **off** for things that happen once, such as an attack or a death |
| **Loop Pose** | for 3D characters' bodies; leave it off in 2D |

### Idea — animating a child

A clip belongs to the GameObject with the **Animator**, but it can change that object's
children too. **Add Property** lists them: a curve on a child called `Sign` shows as
**Sign : Sprite Renderer.Color**. The child's name is part of the curve's **path**, so
renaming the child breaks the curve: it turns yellow and says **(Missing!)**. Rename it
back, or move the curve to the new name.

### Do it

1. Make a coin bob: a sprite with a property clip that moves its **Position Y** from 0
   to 0.3 and back over one second, with **Loop Time** on.
2. Make a warning light blink: a property clip on a sprite's **Color**, white at
   `0:00`, red at `0:15`, white at `0:30`. Then change the keyframes' tangents to
   **Constant** and compare.
3. Slice any sheet of frames into sprites, and make a sprite-frame clip from four of
   them at 8 samples. Play it at 4 samples, then at 16.
4. Leave **Record** on by mistake, move the object, and watch a keyframe appear. Undo
   it, and turn **Record** off.

### Challenge

Make a door that opens: an empty GameObject `Door` with a child sprite called `Panel`,
and a clip on `Door` that turns `Panel` (its **Rotation Z** from 0 to 90 over half a
second), with **Loop Time** off. Then rename the child and watch the curve break; rename
it back.
