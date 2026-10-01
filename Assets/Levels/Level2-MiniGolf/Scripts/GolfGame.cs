using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Runs a round of golf: the holes in order, the strokes, the scorecard, and
// the messages and sounds that go with them.
public class GolfGame : MonoBehaviour
{
    [SerializeField] List<Hole> holes;
    [SerializeField] GolfBall ball;
    [SerializeField] ParticleSystem confetti;
    [SerializeField] TMP_Text holeText;
    [SerializeField] TMP_Text strokesText;
    [SerializeField] TMP_Text powerText;
    [SerializeField] TMP_Text messageText;
    [SerializeField] GameObject scorecardPanel;
    [SerializeField] TMP_Text scorecardText;
    [SerializeField] Button playAgainButton;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip puttSound;
    [SerializeField] AudioClip cupSound;
    [SerializeField] AudioClip fallSound;
    [SerializeField] AudioClip cheerSound;

    readonly List<HoleScore> scorecard = new List<HoleScore>();
    int holeIndex = 0;
    int strokes = 0;
    bool holeFinished = false;
    bool resetting = false;
    Coroutine hideMessage;

    public string PlayerName { get; set; } = "Player";

    public bool CanShoot
    {
        get { return !holeFinished && !resetting && !ball.IsMoving && Time.timeScale > 0f; }
    }

    Hole CurrentHole
    {
        get { return holes[holeIndex]; }
    }

    void OnEnable()
    {
        playAgainButton.onClick.AddListener(StartRound);
    }

    void OnDisable()
    {
        playAgainButton.onClick.RemoveListener(StartRound);
    }

    void Start()
    {
        StartRound();
    }

    void Update()
    {
        if (holeFinished || resetting)
        {
            return;
        }

        if (ball.IsOffCourse)
        {
            StartCoroutine(BallOffCourse());
        }
        else if (!ball.IsMoving && strokes >= GolfTerms.MaxStrokes)
        {
            FinishHole();    // too many strokes: pick the ball up and move on
        }
    }

    public void StartRound()
    {
        scorecard.Clear();
        scorecardPanel.SetActive(false);
        holeIndex = 0;
        StartHole();
    }

    void StartHole()
    {
        strokes = 0;
        holeFinished = false;
        ball.gameObject.SetActive(true);
        ball.PlaceAt(CurrentHole.TeePosition);
        UpdateScreen();
        ShowMessage("Hole " + (holeIndex + 1) + ": " + CurrentHole.HoleName, 2f);
    }

    public void StrokeTaken()
    {
        strokes++;
        audioSource.PlayOneShot(puttSound);
        UpdateScreen();
    }

    public void BallInCup()
    {
        if (holeFinished)
        {
            return;
        }
        audioSource.PlayOneShot(cupSound);
        confetti.transform.position = ball.transform.position;
        confetti.Play();
        FinishHole();
    }

    void FinishHole()
    {
        holeFinished = true;
        ball.Stop();
        ball.gameObject.SetActive(false);

        HoleScore score = new HoleScore(holeIndex + 1, CurrentHole.Par, strokes);
        scorecard.Add(score);
        ShowMessage(score.Name + "!");
        StartCoroutine(NextHole());
    }

    IEnumerator NextHole()
    {
        yield return new WaitForSeconds(2.5f);
        holeIndex++;
        if (holeIndex < holes.Count)
        {
            StartHole();
        }
        else
        {
            ShowScorecard();
        }
    }

    IEnumerator BallOffCourse()
    {
        resetting = true;
        audioSource.PlayOneShot(fallSound);
        ShowMessage("Off the course! +1 stroke", 1.5f);
        yield return new WaitForSeconds(1f);
        strokes++;
        ball.PlaceAt(ball.LastShotPosition);
        UpdateScreen();
        resetting = false;
    }

    void ShowScorecard()
    {
        int totalStrokes = 0;
        int totalPar = 0;
        string lines = "";
        foreach (HoleScore score in scorecard)
        {
            lines += $"Hole {score.HoleNumber}    Par {score.Par}    {score.Strokes} strokes    {score.Name}\n";
            totalStrokes += score.Strokes;
            totalPar += score.Par;
        }

        int difference = totalStrokes - totalPar;
        string result;
        if (difference < 0)
        {
            result = -difference + " under par!";
        }
        else if (difference > 0)
        {
            result = difference + " over par";
        }
        else
        {
            result = "level par";
        }

        scorecardText.text = $"Scorecard: {PlayerName}\n\n{lines}\nTotal: {totalStrokes} strokes, {result}";
        scorecardPanel.SetActive(true);
        messageText.text = "";
        audioSource.PlayOneShot(cheerSound);
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

    public void ShowPower(float power)
    {
        if (power > 0f)
        {
            powerText.text = "Power " + Mathf.RoundToInt(power * 100) + "%";
        }
        else
        {
            powerText.text = "";
        }
    }

    void UpdateScreen()
    {
        holeText.text = $"Hole {holeIndex + 1} of {holes.Count}    Par {CurrentHole.Par}";
        strokesText.text = "Strokes: " + strokes;
    }
}
