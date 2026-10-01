## C# — Game UI: Health Bars, Menus and Pausing

**Goal:** you can show health with a bar that slides and changes colour, show a panel
for each part of the game (start, pause, win, lose), and pause the game so that
everything stops except its menus.

### Idea — a health bar is a Filled image

A UI **Image** has an **Image Type**. Set it to **Filled**, and two more settings
appear:

| Setting | Set it to | Means |
| --- | --- | --- |
| **Fill Method** | **Horizontal** | the image fills from side to side |
| **Fill Origin** | **Left** | it fills from the left, and empties towards it |
| **Fill Amount** | a number from 0 to 1 | how much of it shows: 1 is full, 0.6 is three-fifths |

A **Filled** image needs a **Source Image**: any sprite works, such as Unity's own
**UISprite**. Put the bar in front of a darker image of the same size, its
background, and the empty part shows dark.

In code, the fill amount is the health as a share of the most it can be:

```csharp
int health = 3;
int maxHealth = 5;
Debug.Log(health / maxHealth);
Debug.Log((float)health / maxHealth);
```

```
0
0.6
```

> **Watch out:** `3 / 5` is **0** in C#: an `int` divided by an `int` gives an `int`,
> and the fraction is thrown away. Turn one of them into a `float` first, with
> `(float)`, and the result is 0.6. A bar that's always full or always empty is usually
> this bug.

### Idea — a bar that slides

A bar that jumps from 1 to 0.8 is hard to notice. A bar that slides there over a moment
catches the eye. Keep the value it should reach, and move the fill a little towards it
every frame:

```csharp
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] Image fill;
    [SerializeField] int maxHealth = 5;
    [SerializeField] float slideSpeed = 2f;     // how much of the bar it slides in a second

    int health;

    void Start()
    {
        health = maxHealth;
    }

    void Update()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard != null && keyboard.hKey.wasPressedThisFrame)
        {
            health = Mathf.Max(health - 1, 0);      // H hurts
        }
        if (keyboard != null && keyboard.gKey.wasPressedThisFrame)
        {
            health = Mathf.Min(health + 1, maxHealth);      // G heals
        }

        float target = (float)health / maxHealth;
        fill.fillAmount = Mathf.MoveTowards(fill.fillAmount, target, slideSpeed * Time.deltaTime);
        fill.color = Color.Lerp(Color.red, Color.green, fill.fillAmount);
    }
}
```

- `Mathf.MoveTowards(from, to, step)` moves `from` at most `step` closer to `to`, and
  never past it.
- `Color.Lerp(a, b, t)` mixes two colours: `t = 0` gives all `a`, `t = 1` all `b`,
  `t = 0.5` half of each. Here the bar turns from green to red as it empties.

> **Note:** a row of heart icons works too: an array of Images, with
> `hearts[i].enabled = i < health;` in a loop. Bars suit health that can be any amount;
> icons suit a few lives you can count.

### Idea — text on the screen

TextMeshPro texts (`TMP_Text`, from `using TMPro;`) show numbers with string
interpolation and the formats from Level 1:

| Code | Shows |
| --- | --- |
| `coinText.text = $"x {coins}";` | `x 12` |
| `scoreText.text = $"{score:D6}";` | `000420` |
| `timeText.text = $"{minutes}:{seconds:00}";` | `2:05` |

Time is easiest kept as seconds, and split only to show it: for 125 seconds,
`125 / 60` is 2 (whole minutes, `int` division doing what you want for once) and
`125 % 60` is 5.

### Idea — a panel for each part of the game

A game moves through parts: the start screen, playing, paused, won, lost. Give each its
own **panel**, a full-screen Image with the buttons and texts on it, and show exactly
one at a time with `SetActive`. A state machine ({{ref:statemachines}}) is the natural
place to do it, in its enter step:

```csharp
using UnityEngine;

public class Menus : MonoBehaviour
{
    public enum Page { Start, Playing, Paused, GameOver }

    [SerializeField] GameObject startPanel;
    [SerializeField] GameObject pausePanel;
    [SerializeField] GameObject gameOverPanel;

    Page page;

    public void Show(Page next)
    {
        page = next;
        startPanel.SetActive(page == Page.Start);
        pausePanel.SetActive(page == Page.Paused);
        gameOverPanel.SetActive(page == Page.GameOver);
    }
}
```

`page == Page.Start` is a `bool`, true for one page only, so each panel shows in its
own state and hides in every other. While a panel shows, its dark, see-through
background also catches clicks, so they can't reach the game behind it.

### Idea — pausing with Time.timeScale

`Time.timeScale` is how fast game time runs: 1 is normal speed, 0.5 is slow motion, and
**0** stops it.

| With `Time.timeScale = 0`… | Stops? |
| --- | --- |
| physics: Rigidbodies, collisions and triggers | **stops** |
| `Time.deltaTime` | **becomes 0**, so movement in `Update` stops too |
| coroutines waiting on `WaitForSeconds` | **wait** |
| Animators (on their usual Update Mode, Normal) | **stop** |
| `Update` itself | **keeps running**: so read the pause key there |
| UI buttons and sliders | **keep working** |
| `Time.unscaledDeltaTime` and `WaitForSecondsRealtime` | keep counting real time |
| sound | **keeps playing**, unless you also set `AudioListener.pause = true` |

```csharp
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseKey : MonoBehaviour
{
    [SerializeField] GameObject pausePanel;

    bool isPaused;

    void Update()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard != null && keyboard.escapeKey.wasPressedThisFrame)
        {
            isPaused = !isPaused;
            Time.timeScale = isPaused ? 0f : 1f;
            pausePanel.SetActive(isPaused);
        }
    }
}
```

> **Watch out:** `Time.timeScale` stays where you left it. A Restart button on the pause
> panel must set it back to 1, or the new game starts frozen. Stopping the game in the
> Editor does put it back to 1, so this bug only shows while you play: pause, Restart,
> and the game doesn't move.

### Idea — menu buttons and the volume

Connect a panel's buttons and sliders in code with `AddListener`, as in Level 2: in the
panel's `OnEnable`, and take them off again in `OnDisable`. `AudioListener.volume`, from
0 (silent) to 1 (full), sets the volume of every sound in the game at once, which is
exactly what a volume slider needs:

```csharp
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] Slider slider;

    void OnEnable()
    {
        slider.SetValueWithoutNotify(AudioListener.volume);
        slider.onValueChanged.AddListener(OnVolumeChanged);
    }

    void OnDisable()
    {
        slider.onValueChanged.RemoveListener(OnVolumeChanged);
    }

    void OnVolumeChanged(float value)
    {
        AudioListener.volume = value;
    }
}
```

### Do it

1. Make the health bar: a Canvas, a dark Image, and a **Filled** Image in front of it.
   Put `HealthDisplay` on any object, drag the filled Image into **Fill**, and press
   **H** and **G** while it plays.
2. Change `(float)health / maxHealth` to `health / maxHealth`. What does the bar do now,
   and why?
3. Add a pause panel with a **Resume** button, and the `PauseKey` script. Give a
   moving object a Rigidbody 2D, and check that it freezes while the panel shows.
4. Pause with something animating, then make one thing keep moving while paused:
   change its movement to use `Time.unscaledDeltaTime`.

### Challenge

Show a countdown text that counts down from 60 seconds and keeps the format `m:ss`.
When it reaches 0, show a "Time's up" panel and pause the game. Pause and unpause
during the countdown: does it stop counting while paused? Make sure it does.
