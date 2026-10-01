## C# — Animation Events

**Goal:** you can make a clip call one of your methods at an exact moment, and you can
spot the mistakes that stop it working. Exam objective U 3.3 includes these mistakes.

### Idea — a clip that calls your code

An **Animation Event** is a marker on a clip's timeline with a method's name on it. When
the clip plays past the marker, Unity calls that method on the scripts of the
GameObject that plays the clip.

They're for things that must happen **on a frame**, not after a time you'd have to keep
in step by hand:

| On this frame… | the event calls… |
| --- | --- |
| a sword reaches the enemy | `OnAttackHit()`: now look for what was hit |
| a foot touches the ground | `OnFootstep()`: play a step sound |
| a monster finishes winding up | `OnLeap()`: now jump |
| the last frame of a roll | `OnRollFinished()`: control comes back |
| the end of a death | `OnDeathFinished()`: show the Try Again panel |

Change the clip's speed, or redraw it with more frames, and the event moves with its
frame. A timer in code would be wrong as soon as the art changed.

### Idea — adding one

1. Open the Animation window and select the GameObject with the Animator.
2. Pick the clip, and move the playhead to the frame.
3. Click **Add Event** (the marker button beside **Add Keyframe**). A white marker
   appears above the timeline.
4. With the marker selected, the Inspector shows **Function**: a list of the methods
   on that GameObject's scripts. Pick one.

Drag a marker to move it, or select it and press **Delete** to remove it.

Here's a script with methods for events:

```csharp
using UnityEngine;

public class Practice : MonoBehaviour
{
    // Called by an Animation Event on the clip's last frame.
    public void OnSwingFinished()
    {
        Debug.Log("Swing finished at " + Time.time);
    }

    // An event can pass one value: here, which foot (set its Int in the Inspector).
    public void OnStep(int foot)
    {
        Debug.Log("Step with foot " + foot);
    }
}
```

### Idea — the rules for the method

| Rule | Why |
| --- | --- |
| It's in a script **on the same GameObject as the Animator** | Unity only looks there: not on the parent, not on a child |
| Its name matches the event's **exactly** | Unity finds it by name, as it finds `Update` |
| It returns `void` | an event throws away anything a method returns, so this course always writes `void` |
| It takes **no parameter**, or **one** of: `float`, `int`, `string`, an `enum`, an `Object`, or an `AnimationEvent` | the event's Inspector has one box of each kind to fill in |

Unity finds the method whether it's `public` or `private`. This course makes
event methods `public`, and starts their names with `On`, so you can tell them from
other methods at a glance ({{ref:naming}}).

### Idea — the errors

Each mistake shows up in the Console when the clip reaches the marker, not when you
compile. Learn to recognise them:

| The Console says… | Because |
| --- | --- |
| `'Knight' AnimationEvent 'OnFootStep' on animation 'Knight Run' has no receiver! Are you missing a component?` | no script on the GameObject `Knight` has a method of that name: a typo (`OnFootStep` for `OnFootstep`), or the script is on another object |
| `Failed to call AnimationEvent OnStep of class Practice. The function must have either 0 or 1 parameters and the parameter can only be: string, float, int, enum, Object, AnimationEvent or AnimationEventInfo.` | the method takes a parameter of a type an event can't send, such as a `Vector2` or a `bool`, or more than one |

The worst mistake gives no message at all: an event that **never fires**, because the
clip never reaches it.

- A transition with **Has Exit Time** off can leave a clip before its last frame, and an
  event on that frame never runs.
- Code can cut a clip short: `Rebind`, `Play`, or another state's trigger.
- An event near the very end of a clip that leaves it with a blending transition may be
  skipped.

So never let an important flag wait **only** for an event. If an event ends a roll by
setting `isRolling = false`, the code that resets the character after a fall must set
it too.

> **Watch out:** on a **looping** clip, an event fires on every loop: four footsteps a
> second if the run loops once a second with four markers. That's what you want for
> footsteps, and a bug for an event that should happen once.

### Idea — events and the exam

Questions show a clip with an event and a script, and ask why nothing happens. Check, in
order: is the script on the same GameObject as the Animator? Does the name match, case
included? Does the method take a parameter an event can send? Does the clip really
reach the marker?

### Do it

1. Put the Practice script on an animated object. On one of its clips, add an event on
   the last frame that calls `OnSwingFinished`. Play, and read the Console: one line
   per loop.
2. Add an event that calls `OnStep`, and set its **Int** to `1` in the Inspector. Add a
   second one, with `2`.
3. Rename the method to `OnSwingDone` in the script, without changing the event. Play,
   and read the error. Put it right.
4. Move the Practice script to a child of the animated object. Play, and read the
   error. Move it back.

### Challenge

Make an event that fires on a clip's last frame, and a transition out of that clip with
**Has Exit Time** off on a key press. Press the key halfway through the clip, again and
again. Does the event ever run? Write down when it does and when it doesn't.
