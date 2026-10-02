using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

// Runs the game as a state machine: Start, Playing, Paused, Won and Lost. It
// keeps the game's speed (normal or double), shows messages, plays the music,
// and puts the whole battlefield back on Restart.
public class GateGame : MonoBehaviour
{
    public enum GameState { Start, Playing, Paused, Won, Lost }

    [SerializeField] Bank bank;
    [SerializeField] Gate gate;
    [SerializeField] WaveSpawner spawner;
    [SerializeField] Picker picker;
    [SerializeField] Transform plots;
    [SerializeField] Transform skeletons;
    [SerializeField] Transform shots;
    [SerializeField] TMP_Text messageText;
    [SerializeField] GameObject startPanel;
    [SerializeField] Button playButton;
    [SerializeField] Button pauseButton;
    [SerializeField] Button speedButton;
    [SerializeField] TMP_Text speedText;
    [SerializeField] GameObject pausePanel;
    [SerializeField] GameObject winPanel;
    [SerializeField] TMP_Text winText;
    [SerializeField] Button playAgainButton;
    [SerializeField] GameObject losePanel;
    [SerializeField] Button tryAgainButton;
    [SerializeField] AudioSource soundSource;
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioClip buildMusic;
    [SerializeField] AudioClip battleMusic;
    [SerializeField] int battleMusicFromWave = 8;
    [SerializeField] AudioClip winSound;
    [SerializeField] AudioClip loseSound;

    GameState state;
    float speed = 1f;
    Coroutine messageFade;

    public bool IsPlaying
    {
        get { return state == GameState.Playing; }
    }

    public Bank Bank
    {
        get { return bank; }
    }

    public Gate Gate
    {
        get { return gate; }
    }

    void OnEnable()
    {
        playButton.onClick.AddListener(Restart);
        pauseButton.onClick.AddListener(Pause);
        speedButton.onClick.AddListener(ToggleSpeed);
        playAgainButton.onClick.AddListener(Restart);
        tryAgainButton.onClick.AddListener(Restart);
    }

    void OnDisable()
    {
        playButton.onClick.RemoveListener(Restart);
        pauseButton.onClick.RemoveListener(Pause);
        speedButton.onClick.RemoveListener(ToggleSpeed);
        playAgainButton.onClick.RemoveListener(Restart);
        tryAgainButton.onClick.RemoveListener(Restart);
    }

    void Awake()
    {
        messageText.text = "";
        bank.ResetBank();
        EnterState(GameState.Start);
    }

    void Update()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard == null)
        {
            return;
        }

        switch (state)
        {
            case GameState.Start:
                break;
            case GameState.Playing:
                // Esc closes a menu if one is open; otherwise it pauses, as P does.
                if (keyboard.escapeKey.wasPressedThisFrame && picker.HasMenuOpen)
                {
                    picker.CloseMenus();
                }
                else if (keyboard.escapeKey.wasPressedThisFrame || keyboard.pKey.wasPressedThisFrame)
                {
                    Pause();
                }
                else if (keyboard.fKey.wasPressedThisFrame)
                {
                    ToggleSpeed();
                }
                break;
            case GameState.Paused:
                if (keyboard.escapeKey.wasPressedThisFrame || keyboard.pKey.wasPressedThisFrame)
                {
                    Resume();
                }
                break;
            case GameState.Won:
                break;
            case GameState.Lost:
                break;
        }
    }

    // The one place the game's state changes. Every state shows its own panel,
    // and hides the others; then the enter step does what that state needs.
    void EnterState(GameState next)
    {
        state = next;
        startPanel.SetActive(state == GameState.Start);
        pausePanel.SetActive(state == GameState.Paused);
        winPanel.SetActive(state == GameState.Won);
        losePanel.SetActive(state == GameState.Lost);
        pauseButton.gameObject.SetActive(state == GameState.Playing);
        speedButton.gameObject.SetActive(state == GameState.Playing);

        switch (state)
        {
            case GameState.Start:
                Time.timeScale = 1f;
                break;
            case GameState.Playing:
                Time.timeScale = speed;         // 1, or 2 after the ×2 button
                break;
            case GameState.Paused:
                Time.timeScale = 0f;            // Animators, coroutines and timers all stop
                picker.CloseMenus();
                break;
            case GameState.Won:
                Time.timeScale = 1f;
                winText.text = $"The gate held!\n\nLives left: {bank.Lives}";
                picker.CloseMenus();
                musicSource.Stop();
                soundSource.PlayOneShot(winSound);
                break;
            case GameState.Lost:
                Time.timeScale = 1f;
                picker.CloseMenus();
                spawner.StopWaves();
                foreach (Enemy enemy in skeletons.GetComponentsInChildren<Enemy>())
                {
                    enemy.Cheer();
                }
                musicSource.Stop();
                soundSource.PlayOneShot(loseSound);
                break;
        }
    }

    // Puts the whole battlefield back as it was at the start, then plays.
    public void Restart()
    {
        picker.CloseMenus();
        spawner.ResetSpawner();
        foreach (Projectile shot in shots.GetComponentsInChildren<Projectile>())
        {
            Destroy(shot.gameObject);
        }
        foreach (BuildPlot plot in plots.GetComponentsInChildren<BuildPlot>())
        {
            plot.Clear();
        }
        bank.ResetBank();
        gate.ResetGate();
        speed = 1f;
        speedText.text = "x2";
        messageText.text = "";
        PlayMusic(buildMusic);
        EnterState(GameState.Playing);
    }

    public void Pause()
    {
        if (state == GameState.Playing)
        {
            EnterState(GameState.Paused);
        }
    }

    public void Resume()
    {
        if (state == GameState.Paused)
        {
            EnterState(GameState.Playing);
        }
    }

    public void Win()
    {
        if (state == GameState.Playing)
        {
            EnterState(GameState.Won);
        }
    }

    public void Lose()
    {
        if (state == GameState.Playing)
        {
            EnterState(GameState.Lost);
        }
    }

    // Normal speed or double: the button shows what pressing it will do.
    public void ToggleSpeed()
    {
        speed = speed > 1f ? 1f : 2f;
        speedText.text = speed > 1f ? "x1" : "x2";
        if (state == GameState.Playing)
        {
            Time.timeScale = speed;
        }
    }

    // The spawner tells the game when a wave starts: the late waves get the
    // battle music.
    public void WaveStarted(int waveNumber)
    {
        if (waveNumber >= battleMusicFromWave)
        {
            PlayMusic(battleMusic);
        }
    }

    public void PlaySound(AudioClip clip)
    {
        soundSource.PlayOneShot(clip);
    }

    // A line in the middle of the screen, such as "Wave 3 cleared! +35 gold".
    public void ShowMessage(string message)
    {
        if (messageFade != null)
        {
            StopCoroutine(messageFade);
        }
        messageFade = StartCoroutine(FadeText(message));
    }

    // Shows the text for two seconds, then fades it out over one.
    IEnumerator FadeText(string text)
    {
        messageText.text = text;
        messageText.alpha = 1f;
        yield return new WaitForSeconds(2f);
        for (float t = 0f; t < 1f; t += Time.deltaTime)
        {
            messageText.alpha = 1f - t;
            yield return null;
        }
        messageText.text = "";
    }

    void PlayMusic(AudioClip clip)
    {
        if (musicSource.clip == clip && musicSource.isPlaying)
        {
            return;
        }
        musicSource.clip = clip;
        musicSource.Play();
    }
}
