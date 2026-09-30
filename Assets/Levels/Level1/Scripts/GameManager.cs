using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

// The brain of the game: it keeps the score, the lives and the game state,
// and shows them on screen. Attach this to the GameManager object.
public class GameManager : MonoBehaviour
{
    // The three states the game can be in
    enum GameState
    {
        Ready,
        Playing,
        GameOver
    }

    // ---- Rules ----
    [SerializeField] int startingLives = 3;

    // ---- Other objects in the scene: drag them in, in the Inspector ----
    [SerializeField] Spawner spawner;
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text messageText;
    [SerializeField] GameObject playButton;
    [SerializeField] GameObject[] lifeIcons;

    // ---- Sound ----
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip catchSound;
    [SerializeField] AudioClip goldSound;
    [SerializeField] AudioClip missSound;
    [SerializeField] AudioClip gameOverSound;

    // ---- The game's state: these change while the game runs ----
    GameState state = GameState.Ready;
    int score = 0;
    int lives = 0;
    int bestScore = 0;
    float timeSurvived = 0f;
    string resultMessage = "";

    void Start()
    {
        lives = startingLives;
        UpdateScreen();
    }

    void Update()
    {
        if (state == GameState.Playing)
        {
            timeSurvived += Time.deltaTime;
        }
        else if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            // Space starts a game, just like clicking the Play button
            StartGame();
        }
    }

    // Called by the Play button, and by the Space key
    public void StartGame()
    {
        score = 0;
        lives = startingLives;
        timeSurvived = 0f;
        state = GameState.Playing;
        spawner.Restart();
        UpdateScreen();
    }

    // Answers the question "is a game running right now?"
    public bool IsPlaying()
    {
        return state == GameState.Playing;
    }

    // Called by the Player when it catches a block
    public void BlockCaught(string blockTag)
    {
        if (!IsPlaying())
        {
            return;
        }

        switch (blockTag)
        {
            case "Block":
                score += 1;
                audioSource.PlayOneShot(catchSound);
                break;
            case "GoldBlock":
                score += 5;
                audioSource.PlayOneShot(goldSound);
                break;
            case "BadBlock":
                LoseLife();
                break;
        }

        UpdateScreen();
    }

    // Called by the Floor when a block falls past the player
    public void BlockMissed(string blockTag)
    {
        // Letting a bad block fall is the right move, so it costs nothing
        if (IsPlaying() && blockTag != "BadBlock")
        {
            LoseLife();
            UpdateScreen();
        }
    }

    void LoseLife()
    {
        lives--;

        if (lives > 0)
        {
            audioSource.PlayOneShot(missSound);
        }
        else
        {
            EndGame();
        }
    }

    void EndGame()
    {
        state = GameState.GameOver;
        spawner.ClearBlocks();
        audioSource.PlayOneShot(gameOverSound);

        bool isNewBest = score > bestScore;
        if (isNewBest)
        {
            bestScore = score;
        }

        string scoreLine = isNewBest ? $"New best score: {score}!" : $"Score: {score}   Best: {bestScore}";
        resultMessage = $"{scoreLine}\nYou lasted {timeSurvived:F1} seconds";
    }

    // Shows the score, the lives and the right message for the current state
    void UpdateScreen()
    {
        scoreText.text = $"Score: {score}";

        // One icon for each life left: show the first few, hide the rest
        for (int i = 0; i < lifeIcons.Length; i++)
        {
            lifeIcons[i].SetActive(i < lives);
        }

        switch (state)
        {
            case GameState.Ready:
                messageText.text = "Catch the Falling Blocks\nPress Space or click Play";
                playButton.SetActive(true);
                break;
            case GameState.Playing:
                messageText.text = "";
                playButton.SetActive(false);
                break;
            case GameState.GameOver:
                messageText.text = $"Game Over\n{resultMessage}";
                playButton.SetActive(true);
                break;
        }
    }
}
