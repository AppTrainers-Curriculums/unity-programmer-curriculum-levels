using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

// Runs the game as a state machine: Start, Playing, Paused, Won and Lost. It
// knows which room the hero is in, wakes the king in his tomb, counts the
// time, and puts the whole crypt back on Restart.
public class CryptGame : MonoBehaviour
{
    public enum GameState { Start, Playing, Paused, Won, Lost }

    [SerializeField] Hero hero;
    [SerializeField] HeroHealth heroHealth;
    [SerializeField] HeroCombat heroCombat;
    [SerializeField] Inventory inventory;
    [SerializeField] RoomCamera roomCamera;
    [SerializeField] Room[] rooms;
    [SerializeField] float roomHeight = 11f;    // the rooms are stacked, the first at the bottom
    [SerializeField] SkeletonKing king;
    [SerializeField] Transform enemies;
    [SerializeField] Transform chests;
    [SerializeField] Transform doors;
    [SerializeField] Transform pickups;
    [SerializeField] Transform arrows;
    [SerializeField] TMP_Text roomText;
    [SerializeField] TMP_Text messageText;
    [SerializeField] GameObject startPanel;
    [SerializeField] Button playButton;
    [SerializeField] Button pauseButton;
    [SerializeField] GameObject pausePanel;
    [SerializeField] GameObject winPanel;
    [SerializeField] TMP_Text winText;
    [SerializeField] Button playAgainButton;
    [SerializeField] GameObject losePanel;
    [SerializeField] Button tryAgainButton;
    [SerializeField] AudioSource soundSource;
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioClip cryptMusic;
    [SerializeField] AudioClip fightMusic;
    [SerializeField] AudioClip winSound;
    [SerializeField] AudioClip loseSound;

    GameState state;
    float playTime;
    Vector2 startPoint;
    int roomIndex = -1;
    Coroutine roomFade;
    Coroutine messageFade;

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
        startPoint = hero.transform.position;
        roomText.text = "";
        messageText.text = "";
        roomCamera.SnapTo(rooms[0].Centre);
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
                UpdateRoom();
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
                winText.text = $"The Skeleton King has fallen!\n\nGold: {inventory.Gold}\nTime: {FormatTime(playTime)}";
                musicSource.Stop();
                soundSource.PlayOneShot(winSound);
                break;
            case GameState.Lost:
                musicSource.Stop();
                soundSource.PlayOneShot(loseSound);
                break;
        }
    }

    // Puts the whole crypt back as it was at the start, then plays.
    public void Restart()
    {
        playTime = 0f;
        roomIndex = -1;

        foreach (Skeleton skeleton in enemies.GetComponentsInChildren<Skeleton>(true))
        {
            skeleton.ResetSkeleton();
        }
        foreach (Archer archer in enemies.GetComponentsInChildren<Archer>(true))
        {
            archer.ResetArcher();
        }
        king.ResetKing();
        foreach (Arrow arrow in arrows.GetComponentsInChildren<Arrow>())
        {
            Destroy(arrow.gameObject);
        }
        foreach (Chest chest in chests.GetComponentsInChildren<Chest>(true))
        {
            chest.ResetChest();
        }
        foreach (Door door in doors.GetComponentsInChildren<Door>(true))
        {
            door.ResetDoor();
        }
        foreach (Pickup pickup in pickups.GetComponentsInChildren<Pickup>(true))
        {
            pickup.ResetPickup();
        }

        hero.ResetHero(startPoint);
        heroHealth.ResetHealth();
        heroCombat.ResetCombat();
        inventory.ResetInventory();
        roomCamera.SnapTo(rooms[0].Centre);
        PlayMusic(cryptMusic);
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

    // The rooms are stacked roomHeight units apart, so the height of the
    // hero's feet says which room he's in: 0 for the first, 1 for the next.
    void UpdateRoom()
    {
        int index = Mathf.FloorToInt(hero.transform.position.y / roomHeight);
        index = Mathf.Clamp(index, 0, rooms.Length - 1);
        if (index == roomIndex)
        {
            return;
        }

        roomIndex = index;
        roomCamera.MoveTo(rooms[index].Centre);
        if (roomFade != null)
        {
            StopCoroutine(roomFade);
        }
        roomFade = StartCoroutine(FadeText(roomText, rooms[index].Title));

        if (rooms[index].HasBoss)
        {
            king.Wake();
            PlayMusic(fightMusic);
        }
    }

    // A line at the bottom of the screen, such as "Locked: find a key".
    public void ShowMessage(string message)
    {
        if (messageFade != null)
        {
            StopCoroutine(messageFade);
        }
        messageFade = StartCoroutine(FadeText(messageText, message));
    }

    // Shows the text for two seconds, then fades it out over one.
    IEnumerator FadeText(TMP_Text label, string text)
    {
        label.text = text;
        label.alpha = 1f;
        yield return new WaitForSeconds(2f);
        for (float t = 0f; t < 1f; t += Time.deltaTime)
        {
            label.alpha = 1f - t;
            yield return null;
        }
        label.text = "";
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

    bool WasPausePressed()
    {
        Keyboard keyboard = Keyboard.current;
        return keyboard != null && (keyboard.escapeKey.wasPressedThisFrame || keyboard.pKey.wasPressedThisFrame);
    }

    // 161.4 seconds becomes "2:41".
    static string FormatTime(float seconds)
    {
        int whole = Mathf.FloorToInt(seconds);
        return $"{whole / 60}:{whole % 60:00}";
    }
}
