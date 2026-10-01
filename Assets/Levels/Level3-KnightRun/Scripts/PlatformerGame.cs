using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

// Runs the game as a state machine: Start, Playing, Paused, Won and Lost. It
// counts the coins and the time, remembers the last checkpoint, shows each
// section's name and sky, and puts the whole level back on Restart.
public class PlatformerGame : MonoBehaviour
{
    public enum GameState { Start, Playing, Paused, Won, Lost }

    [SerializeField] KnightController knight;
    [SerializeField] KnightHealth knightHealth;
    [SerializeField] CameraFollow cameraFollow;
    [SerializeField] Camera mainCamera;
    [SerializeField] Transform enemies;
    [SerializeField] Transform pickups;
    [SerializeField] Transform checkpoints;
    [SerializeField] Section[] sections;
    [SerializeField] float skyChangeSpeed = 2f;
    [SerializeField] TMP_Text coinText;
    [SerializeField] TMP_Text sectionText;
    [SerializeField] GameObject touchControls;
    [SerializeField] GameObject startPanel;
    [SerializeField] Button playButton;
    [SerializeField] Button pauseButton;
    [SerializeField] GameObject pausePanel;
    [SerializeField] GameObject winPanel;
    [SerializeField] TMP_Text winText;
    [SerializeField] Button playAgainButton;
    [SerializeField] GameObject losePanel;
    [SerializeField] Button tryAgainButton;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip coinSound;
    [SerializeField] AudioClip checkpointSound;
    [SerializeField] AudioClip winSound;

    GameState state;
    int coins;
    int totalCoins;
    float playTime;
    Vector2 startPoint;
    Vector2 respawnPoint;
    int sectionIndex = -1;
    Coroutine sectionFade;

    public bool IsPlaying
    {
        get { return state == GameState.Playing; }
    }

    void OnEnable()
    {
        playButton.onClick.AddListener(Restart);
        pauseButton.onClick.AddListener(Pause);
        playAgainButton.onClick.AddListener(Restart);
        tryAgainButton.onClick.AddListener(Restart);
    }

    void OnDisable()
    {
        playButton.onClick.RemoveListener(Restart);
        pauseButton.onClick.RemoveListener(Pause);
        playAgainButton.onClick.RemoveListener(Restart);
        tryAgainButton.onClick.RemoveListener(Restart);
    }

    void Awake()
    {
        startPoint = knight.transform.position;
        respawnPoint = startPoint;
        totalCoins = pickups.GetComponentsInChildren<Coin>(true).Length;

        // The touch buttons only show on a touchscreen.
        touchControls.SetActive(Touchscreen.current != null);
        sectionText.text = "";
        mainCamera.backgroundColor = sections[0].SkyColour;
        UpdateCoinText();
        EnterState(GameState.Start);
    }

    void Update()
    {
        switch (state)
        {
            case GameState.Start:
                break;
            case GameState.Playing:
                playTime += Time.deltaTime;
                UpdateSection();
                if (WasPausePressed())
                {
                    Pause();
                }
                break;
            case GameState.Paused:
                if (WasPausePressed())
                {
                    Resume();
                }
                break;
            case GameState.Won:
                break;
            case GameState.Lost:
                break;
        }

        // The sky eases towards the colour of the section the knight is in.
        if (sectionIndex >= 0)
        {
            Color sky = sections[sectionIndex].SkyColour;
            mainCamera.backgroundColor = Color.Lerp(mainCamera.backgroundColor, sky, skyChangeSpeed * Time.deltaTime);
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

        switch (state)
        {
            case GameState.Start:
                Time.timeScale = 1f;
                break;
            case GameState.Playing:
                Time.timeScale = 1f;
                break;
            case GameState.Paused:
                Time.timeScale = 0f;    // physics, Animators and timers all stop
                break;
            case GameState.Won:
                winText.text = $"You made it!\n\nCoins: {coins} / {totalCoins}\nTime: {FormatTime(playTime)}";
                audioSource.PlayOneShot(winSound);
                break;
            case GameState.Lost:
                break;
        }
    }

    // Puts everything back as it was at the start, then plays. Loading the
    // scene again would do the same: that waits for Level 4.
    public void Restart()
    {
        coins = 0;
        playTime = 0f;
        respawnPoint = startPoint;
        sectionIndex = -1;

        foreach (Slime slime in enemies.GetComponentsInChildren<Slime>(true))
        {
            slime.ResetSlime();
        }
        foreach (Coin coin in pickups.GetComponentsInChildren<Coin>(true))
        {
            coin.ResetCoin();
        }
        foreach (Apple apple in pickups.GetComponentsInChildren<Apple>(true))
        {
            apple.ResetApple();
        }
        foreach (Checkpoint checkpoint in checkpoints.GetComponentsInChildren<Checkpoint>(true))
        {
            checkpoint.ResetCheckpoint();
        }

        knight.ResetKnight(startPoint);
        knightHealth.ResetHealth();
        cameraFollow.SnapToTarget();
        mainCamera.backgroundColor = sections[0].SkyColour;
        UpdateCoinText();
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

    public void AddCoin()
    {
        coins++;
        UpdateCoinText();
        audioSource.PlayOneShot(coinSound);
    }

    public void SetRespawnPoint(Vector2 point)
    {
        respawnPoint = point;
        audioSource.PlayOneShot(checkpointSound);
    }

    // The knight fell in: back to the last checkpoint, and 1 health less.
    public void KnightFell()
    {
        if (state != GameState.Playing)
        {
            return;
        }
        knight.ResetKnight(respawnPoint);
        cameraFollow.SnapToTarget();
        knightHealth.FellInPit();
    }

    // Shows a section's name as the knight reaches it.
    void UpdateSection()
    {
        float x = knight.transform.position.x;
        int index = 0;
        for (int i = 0; i < sections.Length; i++)
        {
            if (x >= sections[i].StartX)
            {
                index = i;
            }
        }

        if (index != sectionIndex)
        {
            sectionIndex = index;
            if (sectionFade != null)
            {
                StopCoroutine(sectionFade);
            }
            sectionFade = StartCoroutine(ShowSectionName(sections[index].Title));
        }
    }

    IEnumerator ShowSectionName(string title)
    {
        sectionText.text = title;
        sectionText.alpha = 1f;
        yield return new WaitForSeconds(2f);
        for (float t = 0f; t < 1f; t += Time.deltaTime)
        {
            sectionText.alpha = 1f - t;
            yield return null;
        }
        sectionText.text = "";
    }

    bool WasPausePressed()
    {
        Keyboard keyboard = Keyboard.current;
        return keyboard != null && (keyboard.escapeKey.wasPressedThisFrame || keyboard.pKey.wasPressedThisFrame);
    }

    void UpdateCoinText()
    {
        coinText.text = $"x {coins}";
    }

    // 161.4 seconds becomes "2:41".
    static string FormatTime(float seconds)
    {
        int whole = Mathf.FloorToInt(seconds);
        return $"{whole / 60}:{whole % 60:00}";
    }
}
