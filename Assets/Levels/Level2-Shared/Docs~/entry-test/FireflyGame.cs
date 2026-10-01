using UnityEngine;
using TMPro;

// Model answer for the Level 2 entry test practical task.
// Sends fireflies and moths for a set time, keeps the score, and gives a rank.
public class FireflyGame : MonoBehaviour
{
    // The two states the game can be in
    enum GameState
    {
        Playing,
        Finished
    }

    // ---- Settings ----
    [SerializeField] GameObject[] insectPrefabs;    // put Firefly in three times, Moth once
    [SerializeField] TMP_Text infoText;
    [SerializeField] float spawnDelay = 0.8f;       // seconds between two new insects
    [SerializeField] float gameLength = 30f;        // seconds

    // Where insects appear: x from -spawnWidth to spawnWidth, y from lowestY to highestY
    [SerializeField] float spawnWidth = 7.5f;
    [SerializeField] float lowestY = -2f;
    [SerializeField] float highestY = 4f;

    // ---- Ranks: the score each one needs, and its name ----
    int[] rankScores = { 0, 10, 20, 30 };
    string[] rankNames = { "Beginner", "Catcher", "Expert", "Firefly Master" };

    // ---- State: these change while the game runs ----
    GameState state = GameState.Playing;
    int score = 0;
    float timeLeft = 0f;
    float spawnTimer = 0f;

    void Start()
    {
        timeLeft = gameLength;
        UpdateText();
    }

    void Update()
    {
        switch (state)
        {
            case GameState.Playing:
                Play();
                break;
            case GameState.Finished:
                // Nothing appears and nothing counts any more
                break;
        }
    }

    // One frame of the game: the clock, and a new insect now and then
    void Play()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0f)
        {
            Finish();
            return;
        }

        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnDelay)
        {
            spawnTimer = 0f;
            SpawnInsect();
        }

        UpdateText();
    }

    // A random insect at a random place in the night sky
    void SpawnInsect()
    {
        int index = Random.Range(0, insectPrefabs.Length);
        float x = Random.Range(-spawnWidth, spawnWidth);
        float y = Random.Range(lowestY, highestY);

        // The last argument makes the insect a child of this object
        Instantiate(insectPrefabs[index], new Vector3(x, y, 0f), Quaternion.identity, transform);
    }

    // Called by the Jar when it catches an insect
    public void Caught(string insectTag)
    {
        if (state != GameState.Playing)
        {
            return;
        }

        switch (insectTag)
        {
            case "Firefly":
                score += 1;
                break;
            case "Moth":
                score -= 2;
                if (score < 0)
                {
                    score = 0;
                }
                break;
        }

        UpdateText();
    }

    // Time's up: stop, clear the sky, and show the result
    void Finish()
    {
        state = GameState.Finished;

        // Every insect still flying is a child of this object
        foreach (Transform insect in transform)
        {
            Destroy(insect.gameObject);
        }

        infoText.text = $"Time's up!\nScore: {score}\nRank: {GetRank()}";
    }

    // The best rank whose score has been reached
    string GetRank()
    {
        string rank = rankNames[0];
        for (int i = 0; i < rankScores.Length; i++)
        {
            if (score >= rankScores[i])
            {
                rank = rankNames[i];
            }
        }
        return rank;
    }

    void UpdateText()
    {
        infoText.text = $"Score: {score}   Time: {timeLeft:F1}";
    }
}
