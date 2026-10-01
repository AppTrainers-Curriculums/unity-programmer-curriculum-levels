using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Runs the match: the rounds of enemy tanks, the screen, the start and end
// panels, the explosions and the sounds.
public class ArenaGame : MonoBehaviour
{
    [SerializeField] PlayerTank player;
    [SerializeField] CameraFollow cameraFollow;
    [SerializeField] GameObject lightTankPrefab;
    [SerializeField] GameObject heavyTankPrefab;
    [SerializeField] GameObject repairKitPrefab;
    [SerializeField] GameObject explosionPrefab;
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] int[] lightTanksPerRound = { 2, 3, 2, 2 };
    [SerializeField] int[] heavyTanksPerRound = { 0, 0, 1, 2 };
    [SerializeField] float repairKitChance = 0.35f;
    [SerializeField] Image healthFill;
    [SerializeField] TMP_Text roundText;
    [SerializeField] TMP_Text enemiesText;
    [SerializeField] TMP_Text messageText;
    [SerializeField] GameObject startPanel;
    [SerializeField] Button playButton;
    [SerializeField] GameObject endPanel;
    [SerializeField] TMP_Text endText;
    [SerializeField] Button playAgainButton;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip explosionSound;
    [SerializeField] AudioClip victorySound;
    [SerializeField] AudioClip defeatSound;

    readonly List<EnemyTank> enemies = new List<EnemyTank>();
    MatchStats stats;
    int round = 1;                                // the round being played, counting from 1
    Coroutine hideMessage;

    public bool IsPlaying { get; private set; }
    public string CommanderName { get; set; } = "Commander";

    public PlayerTank Player
    {
        get { return player; }
    }

    int RoundCount
    {
        get { return lightTanksPerRound.Length; }
    }

    void Awake()
    {
        IsPlaying = false;
        startPanel.SetActive(true);
        endPanel.SetActive(false);
        messageText.text = "";
    }

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

    void Update()
    {
        if (IsPlaying && player.Health.IsDead)
        {
            Explode(player.transform.position);
            player.gameObject.SetActive(false);
            EndGame(false);
        }
        UpdateScreen();
    }

    public void StartGame()
    {
        StopAllCoroutines();
        ClearArena();
        stats = new MatchStats(new string[] { "Light Tank", "Heavy Tank" });
        startPanel.SetActive(false);
        endPanel.SetActive(false);
        player.gameObject.SetActive(true);
        player.ResetTank();
        IsPlaying = true;
        StartCoroutine(PlayRounds());
    }

    // The whole match: each round counts down, sends its tanks, and waits
    // until every one of them has been destroyed.
    IEnumerator PlayRounds()
    {
        for (int number = 1; number <= RoundCount; number++)
        {
            round = number;
            ShowMessage("Round " + round);
            yield return new WaitForSeconds(1.5f);
            for (int count = 3; count > 0; count--)
            {
                ShowMessage(count.ToString());
                yield return new WaitForSeconds(0.6f);
            }
            ShowMessage("Go!", 0.8f);
            SpawnRound(round);

            while (enemies.Count > 0)
            {
                yield return null;
            }
            stats.AddRound();

            if (round < RoundCount)
            {
                ShowMessage("Round cleared!");
                yield return new WaitForSeconds(2f);
            }
        }
        EndGame(true);
    }

    void SpawnRound(int roundNumber)
    {
        int spawnIndex = 0;
        for (int i = 0; i < lightTanksPerRound[roundNumber - 1]; i++)
        {
            Spawn(lightTankPrefab, spawnIndex);
            spawnIndex++;
        }
        for (int i = 0; i < heavyTanksPerRound[roundNumber - 1]; i++)
        {
            Spawn(heavyTankPrefab, spawnIndex);
            spawnIndex++;
        }
    }

    void Spawn(GameObject prefab, int spawnIndex)
    {
        // % goes round the spawn points: with 4 points, tank 5 uses point 0 again.
        Transform point = spawnPoints[spawnIndex % spawnPoints.Length];
        GameObject tank = Instantiate(prefab, point.position, point.rotation);
        EnemyTank enemy = tank.GetComponent<EnemyTank>();
        enemy.SetGame(this);
        enemies.Add(enemy);
    }

    public void EnemyDestroyed(EnemyTank enemy)
    {
        enemies.Remove(enemy);
        stats.AddKill(enemy.TankName);
        Explode(enemy.transform.position);
        if (Random.value < repairKitChance)
        {
            // A child of the game, so ClearArena can find it.
            Instantiate(repairKitPrefab, enemy.transform.position, Quaternion.identity, transform);
        }
    }

    public void ShotFired()
    {
        stats.AddShot();
    }

    void Explode(Vector3 position)
    {
        Instantiate(explosionPrefab, position, Quaternion.identity);
        audioSource.PlayOneShot(explosionSound);
        cameraFollow.Shake(0.3f);
    }

    void EndGame(bool won)
    {
        IsPlaying = false;
        StopAllCoroutines();
        messageText.text = "";

        string title = won ? "Victory!" : "Destroyed!";
        endText.text = $"{title}\n\n{CommanderName}\n{stats.Summary()}";
        endPanel.SetActive(true);
        if (won)
        {
            audioSource.PlayOneShot(victorySound);
        }
        else
        {
            audioSource.PlayOneShot(defeatSound);
            cameraFollow.Shake(0.6f, 0.4f);
        }
    }

    // Removes every enemy and every repair kit, for a new match.
    void ClearArena()
    {
        foreach (EnemyTank enemy in enemies)
        {
            Destroy(enemy.gameObject);
        }
        enemies.Clear();
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
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
        healthFill.fillAmount = player.Health.Fraction;
        roundText.text = $"Round {round} of {RoundCount}";
        enemiesText.text = "Enemies: " + enemies.Count;
    }
}
