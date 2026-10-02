using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

// Model answer for the Level 3 entry test practical task.
// Sends waves of meteors at the city, blasts the one under the pointer, keeps
// the score and the lives, and shows how the game ended.
public class MeteorGame : MonoBehaviour
{
    const int StartLives = 3;

    // ---- Settings ----
    [SerializeField] GameObject[] meteorPrefabs;        // Small, Medium and Large Meteor
    [SerializeField] LayerMask meteorMask;              // only the Meteor layer
    [SerializeField] int[] waveSizes = { 6, 9, 12 };    // how many meteors in each wave
    [SerializeField] float spawnDelay = 0.7f;           // seconds between two meteors
    [SerializeField] float waveBreak = 2f;              // seconds between two waves
    [SerializeField] float edgeX = 8f;                  // meteors start and land between -8 and 8
    [SerializeField] float startY = 5.5f;               // just above the screen
    [SerializeField] float cityY = -4.2f;               // the top edge of the city

    // ---- The UI ----
    [SerializeField] TMP_Text infoText;
    [SerializeField] TMP_Text endText;
    [SerializeField] GameObject settingsPanel;
    [SerializeField] Button settingsButton;
    [SerializeField] Button closeButton;
    [SerializeField] Slider speedSlider;

    // The points for blasting each size, and how many of each were blasted
    readonly Dictionary<MeteorSize, int> points = new Dictionary<MeteorSize, int>
    {
        { MeteorSize.Small, 50 },
        { MeteorSize.Medium, 20 },
        { MeteorSize.Large, 10 },
    };
    readonly Dictionary<MeteorSize, int> blasted = new Dictionary<MeteorSize, int>
    {
        { MeteorSize.Small, 0 },
        { MeteorSize.Medium, 0 },
        { MeteorSize.Large, 0 },
    };

    // The meteors in the sky right now
    readonly List<Meteor> meteors = new List<Meteor>();

    Coroutine waves;
    int lives = StartLives;
    int wave = 0;
    bool isOver = false;

    // Every script can read these; only this one changes them
    public int Score { get; private set; }
    public float SpeedSetting { get; private set; } = 1f;

    void OnEnable()
    {
        settingsButton.onClick.AddListener(OpenSettings);
        closeButton.onClick.AddListener(CloseSettings);
        speedSlider.onValueChanged.AddListener(OnSpeedChanged);
    }

    void OnDisable()
    {
        settingsButton.onClick.RemoveListener(OpenSettings);
        closeButton.onClick.RemoveListener(CloseSettings);
        speedSlider.onValueChanged.RemoveListener(OnSpeedChanged);
    }

    void Start()
    {
        endText.text = "";
        waves = StartCoroutine(RunWaves());
    }

    void Update()
    {
        Pointer pointer = Pointer.current;
        if (pointer == null || !pointer.press.wasPressedThisFrame)
        {
            return;
        }

        // Nothing is blasted after the end, or while the game is paused
        if (isOver || Time.timeScale == 0f)
        {
            return;
        }

        Vector2 world = Camera.main.ScreenToWorldPoint(pointer.position.ReadValue());
        Collider2D found = Physics2D.OverlapPoint(world, meteorMask);
        if (found != null && found.TryGetComponent(out Meteor meteor))
        {
            Blast(meteor);
        }
    }

    // The waves, one after another
    IEnumerator RunWaves()
    {
        for (int i = 0; i < waveSizes.Length; i++)
        {
            wave = i + 1;
            UpdateText();

            for (int n = 0; n < waveSizes[i]; n++)
            {
                SpawnMeteor();
                yield return new WaitForSeconds(spawnDelay);
            }

            // The wave is over when the sky is empty
            while (meteors.Count > 0)
            {
                yield return null;
            }

            if (i < waveSizes.Length - 1)
            {
                yield return new WaitForSeconds(waveBreak);
            }
        }

        EndGame("The city is safe!");
    }

    // A random meteor, just above the screen, aimed at a random point on the city
    void SpawnMeteor()
    {
        GameObject prefab = meteorPrefabs[Random.Range(0, meteorPrefabs.Length)];
        Vector3 start = new Vector3(Random.Range(-edgeX, edgeX), startY, 0f);
        Vector3 landing = new Vector3(Random.Range(-edgeX, edgeX), cityY, 0f);

        GameObject copy = Instantiate(prefab, start, Quaternion.identity, transform);
        Meteor meteor = copy.GetComponent<Meteor>();
        meteor.Launch(this, landing);
        meteors.Add(meteor);
    }

    void Blast(Meteor meteor)
    {
        Score += points[meteor.Size];
        blasted[meteor.Size]++;
        RemoveMeteor(meteor);
        UpdateText();
    }

    // A meteor calls this when it reaches the city
    public void Landed(Meteor meteor)
    {
        if (isOver)
        {
            return;
        }

        RemoveMeteor(meteor);
        lives--;
        UpdateText();

        if (lives <= 0)
        {
            StopCoroutine(waves);
            EndGame("The city has fallen");
        }
    }

    void RemoveMeteor(Meteor meteor)
    {
        meteors.Remove(meteor);
        Destroy(meteor.gameObject);
    }

    // The end, either way: clear the sky and show the result
    void EndGame(string message)
    {
        isOver = true;

        foreach (Meteor meteor in meteors)
        {
            Destroy(meteor.gameObject);
        }
        meteors.Clear();

        endText.text = $"{message}\nScore: {Score}\n" +
            $"Small: {blasted[MeteorSize.Small]}   Medium: {blasted[MeteorSize.Medium]}   Large: {blasted[MeteorSize.Large]}";
    }

    // The settings panel pauses the game while it's open
    void OpenSettings()
    {
        settingsPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    void CloseSettings()
    {
        settingsPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    void OnSpeedChanged(float value)
    {
        SpeedSetting = value;
    }

    void UpdateText()
    {
        infoText.text = $"Wave {wave}   Score: {Score}   Lives: {lives}";
    }
}
