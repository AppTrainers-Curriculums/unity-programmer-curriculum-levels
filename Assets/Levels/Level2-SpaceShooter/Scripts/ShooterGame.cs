using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Runs the game: the score, the lives, the waves, the messages, the explosions,
// and the start and end screens.
public class ShooterGame : MonoBehaviour
{
    const int StartingLives = 3;

    [SerializeField] PlayerShip player;
    [SerializeField] WaveSpawner spawner;
    [SerializeField] CameraShake cameraShake;
    [SerializeField] GameObject explosionPrefab;
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text waveText;
    [SerializeField] TMP_Text messageText;
    [SerializeField] Image[] lifeIcons;
    [SerializeField] GameObject startPanel;
    [SerializeField] Button playButton;
    [SerializeField] GameObject endPanel;
    [SerializeField] TMP_Text endText;
    [SerializeField] Button playAgainButton;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip explosionSound;
    [SerializeField] AudioClip loseLifeSound;
    [SerializeField] AudioClip waveSound;
    [SerializeField] AudioClip gameOverSound;

    readonly Dictionary<string, int> kills = new Dictionary<string, int>();
    int score = 0;
    int lives = StartingLives;
    Coroutine hideMessage;

    public bool IsPlaying { get; private set; }
    public string PilotName { get; set; } = "Pilot";

    void OnEnable()
    {
        playButton.onClick.AddListener(StartGame);
        playAgainButton.onClick.AddListener(StartGame);
    }

    void OnDisable()
    {
        playButton.onClick.RemoveListener(StartGame);
        playAgainButton.onClick.RemoveListener(StartGame);
    }

    // Awake, not Start: Unity calls every Awake before any Start, so the screen
    // is ready before another script's Start can show anything on it.
    void Awake()
    {
        IsPlaying = false;
        startPanel.SetActive(true);
        endPanel.SetActive(false);
        messageText.text = "";
        waveText.text = "";
        UpdateScreen();
    }

    public void StartGame()
    {
        score = 0;
        lives = StartingLives;
        kills.Clear();
        startPanel.SetActive(false);
        endPanel.SetActive(false);

        player.gameObject.SetActive(true);
        player.ResetShip();
        IsPlaying = true;
        spawner.StartWaves();
        UpdateScreen();
    }

    public void WaveStarted(int number, string waveName)
    {
        waveText.text = $"Wave {number} of {spawner.WaveCount}";
        ShowMessage(waveName, 2f);
        audioSource.PlayOneShot(waveSound);
    }

    public void EnemyDestroyed(string enemyName, int points, Vector3 position)
    {
        score += points;
        if (kills.ContainsKey(enemyName))
        {
            kills[enemyName]++;
        }
        else
        {
            kills[enemyName] = 1;
        }

        Instantiate(explosionPrefab, position, Quaternion.identity);
        audioSource.PlayOneShot(explosionSound);
        cameraShake.Shake(0.15f);
        UpdateScreen();
    }

    public void PlayerHit()
    {
        lives--;
        cameraShake.Shake(0.4f, 0.3f);
        UpdateScreen();

        if (lives <= 0)
        {
            Instantiate(explosionPrefab, player.transform.position, Quaternion.identity);
            player.gameObject.SetActive(false);
            audioSource.PlayOneShot(gameOverSound);
            EndGame("Game Over");
        }
        else
        {
            audioSource.PlayOneShot(loseLifeSound);
        }
    }

    public void Win()
    {
        EndGame("You Win!");
    }

    void EndGame(string title)
    {
        IsPlaying = false;
        spawner.StopWaves();

        string lines = "";
        foreach (KeyValuePair<string, int> pair in kills)
        {
            lines += $"{pair.Key}: {pair.Value}\n";
        }
        endText.text = $"{title}\n\n{PilotName}: {score:D6} points\n\n{lines}";
        endPanel.SetActive(true);
        messageText.text = "";
    }

    // Two versions of ShowMessage (overloads): one message stays on screen,
    // the other disappears after a few seconds.
    public void ShowMessage(string text)
    {
        if (hideMessage != null)
        {
            StopCoroutine(hideMessage);
        }
        messageText.text = text;
    }

    public void ShowMessage(string text, float seconds)
    {
        ShowMessage(text);
        hideMessage = StartCoroutine(HideMessageAfter(seconds));
    }

    IEnumerator HideMessageAfter(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        messageText.text = "";
    }

    void UpdateScreen()
    {
        scoreText.text = $"{score:D6}";
        for (int i = 0; i < lifeIcons.Length; i++)
        {
            lifeIcons[i].enabled = i < lives;
        }
    }
}
