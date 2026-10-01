## C# — UI Events: Listening for Changes

**Goal:** you can run a method of your own when a button is clicked, or when a
slider, toggle, input field or dropdown changes, and connect it from code with
`AddListener`.

### Idea — the UI tells you when something changes

In Level 1 you connected the Play button in the Inspector, in its **On Click ()**
list. Every UI control has an **event** like that: a list of methods it calls
when something happens. Each control's event hands your method the new value:

| Control | Event | Your method looks like |
| --- | --- | --- |
| Button | `onClick` | `void OnPlayClicked()`: no value |
| Slider | `onValueChanged` | `void OnVolumeChanged(float value)` |
| Toggle | `onValueChanged` | `void OnMusicToggled(bool isOn)` |
| Input Field (TextMeshPro) | `onValueChanged` (every letter), `onEndEdit` (typing finished) | `void OnNameEntered(string text)` |
| Dropdown (TextMeshPro) | `onValueChanged` | `void OnColourChosen(int index)` |

### Idea — AddListener

Instead of filling the list in the Inspector, you can add your method to it from
code:

```csharp
using UnityEngine;
using UnityEngine.UI;

public class Practice : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;

    void OnEnable()
    {
        volumeSlider.onValueChanged.AddListener(OnVolumeChanged);
    }

    void OnDisable()
    {
        volumeSlider.onValueChanged.RemoveListener(OnVolumeChanged);
    }

    void OnVolumeChanged(float value)
    {
        Debug.Log("Volume: " + value);
    }
}
```

Move the slider while the game runs, and the Console shows every change:

```
Volume: 0.3721154
Volume: 0.5
```

(Your numbers depend on where you drag the handle.)

- `using UnityEngine.UI;` gives you `Slider`, `Toggle` and `Button`.
- `AddListener(OnVolumeChanged)` has **no brackets** after the method's name.
  You're not calling the method: you're **handing it over**, so the slider can
  call it later, every time its value changes.
- The method's parameter must match the event: a slider sends a `float`. A
  method with the wrong parameter gives error CS1503: *Argument 1: cannot
  convert from 'method group' to 'UnityEngine.Events.UnityAction<float>'*.
- Add the listener in `OnEnable` and remove it in `OnDisable`
  ({{ref:events}}). Then a hidden settings panel doesn't react, and the pairs
  always match up.

### Idea — each control

```csharp
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Practice : MonoBehaviour
{
    [SerializeField] Toggle musicToggle;
    [SerializeField] TMP_InputField nameInput;
    [SerializeField] TMP_Dropdown colourDropdown;

    void OnEnable()
    {
        musicToggle.onValueChanged.AddListener(OnMusicToggled);
        nameInput.onEndEdit.AddListener(OnNameEntered);
        colourDropdown.onValueChanged.AddListener(OnColourChosen);
    }

    void OnDisable()
    {
        musicToggle.onValueChanged.RemoveListener(OnMusicToggled);
        nameInput.onEndEdit.RemoveListener(OnNameEntered);
        colourDropdown.onValueChanged.RemoveListener(OnColourChosen);
    }

    void OnMusicToggled(bool isOn)
    {
        Debug.Log("Music on: " + isOn);
    }

    void OnNameEntered(string text)
    {
        Debug.Log("Hello, " + text);
    }

    void OnColourChosen(int index)
    {
        Debug.Log("You chose " + colourDropdown.options[index].text);
    }
}
```

Untick the toggle, type `Lina` and press **Enter**, then choose the third option
of a dropdown whose options are Red, Green and Blue. The Console shows:

```
Music on: False
Hello, Lina
You chose Blue
```

| Control | Read its value any time | Remember |
| --- | --- | --- |
| Slider | `slider.value` | set **Min Value**, **Max Value** and **Whole Numbers** in the Inspector |
| Toggle | `toggle.isOn` | |
| Input Field | `inputField.text` | `onEndEdit` fires once, when typing is finished |
| Dropdown | `dropdown.value` | an **index**: the first option is 0; the option's text is `dropdown.options[index].text` |

`TMP_InputField` and `TMP_Dropdown` live in `using TMPro;`, like `TMP_Text`.

### Idea — changing a value without the event

When **your code** sets a control, its event fires too: `slider.value = 0.5f;`
calls every listener, just as if the player had moved it. When you only want to
show a value, for example when the settings panel opens, set it **quietly**:

| Control | Set quietly |
| --- | --- |
| Slider | `slider.SetValueWithoutNotify(0.5f);` |
| Toggle | `toggle.SetIsOnWithoutNotify(true);` |
| Input Field | `inputField.SetTextWithoutNotify("Player");` |
| Dropdown | `dropdown.SetValueWithoutNotify(2);` |

### Idea — Inspector or code?

Both work, and the exam shows both:

| In the Inspector's event list | In code, with AddListener |
| --- | --- |
| no code, quick to set up | everything is visible in the script |
| your method must be `public`; choose it under **Dynamic float** (or bool, string, int) to receive the value | the method can stay private |
| the connection lives in the scene | works for UI you create while the game runs |

### Do it

1. Create a Canvas with a Slider, a Toggle, an Input Field and a Dropdown:
   **GameObject → UI (Canvas) → Slider**, **Toggle**, **Input Field -
   TextMeshPro** and **Dropdown - TextMeshPro**. Spread them out on the screen.
2. In the Dropdown's Inspector, change its **Options** to `Red`, `Green` and
   `Blue`.
3. Put both examples in your `Practice` script (one class, all four fields), drag
   the controls into the fields, press Play and use every control.
4. Give `OnVolumeChanged` a `string` parameter instead of `float`, and read the
   error.
5. Open the Toggle's **On Value Changed (Boolean)** list in the Inspector and
   connect it to a `public` method, the Level 1 way. Use the toggle: now two
   methods react.

### Challenge

Make a "dimmer": a Slider from 0 to 1 that changes the alpha (transparency) of an
Image's colour as you drag it. When the game starts, set the slider to 1 without
calling the listener.
