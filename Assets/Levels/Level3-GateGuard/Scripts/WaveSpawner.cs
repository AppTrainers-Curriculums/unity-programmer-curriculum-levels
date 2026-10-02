using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

// Sends the waves, run as a state machine: Waiting for the next wave,
// Spawning its skeletons, In Progress while they're on the road, and Cleared
// when none are left. Each wave is a Wave in the array, filled in in the
// Inspector.
public class WaveSpawner : MonoBehaviour
{
    public enum State { Waiting, Spawning, InProgress, Cleared }

    [SerializeField] GateGame game;
    [SerializeField] Bank bank;
    [SerializeField] WaypointPath path;
    [SerializeField] Transform skeletonGroup;     // every skeleton goes here, so Restart finds them
    [SerializeField] Wave[] waves;
    [SerializeField] float countdownSeconds = 15f;
    [SerializeField] int bonusBase = 20;          // a cleared wave pays bonusBase + bonusPerWave × its number
    [SerializeField] int bonusPerWave = 5;
    [SerializeField] Button startWaveButton;
    [SerializeField] TMP_Text countdownText;
    [SerializeField] TMP_Text waveText;
    [SerializeField] AudioClip waveSound;

    State state;
    int waveIndex;              // the next wave to send: 0 is wave 1
    float countdown;

    void OnEnable()
    {
        startWaveButton.onClick.AddListener(StartNextWave);
    }

    void OnDisable()
    {
        startWaveButton.onClick.RemoveListener(StartNextWave);
    }

    void Update()
    {
        if (!game.IsPlaying)
        {
            return;
        }

        switch (state)
        {
            case State.Waiting:
                UpdateWaiting();
                break;
            case State.Spawning:
                break;                  // the SpawnWave coroutine is at work
            case State.InProgress:
                if (skeletonGroup.childCount == 0)
                {
                    EnterState(State.Cleared);
                }
                break;
            case State.Cleared:
                break;
        }
    }

    void EnterState(State next)
    {
        state = next;
        startWaveButton.gameObject.SetActive(state == State.Waiting);

        switch (state)
        {
            case State.Waiting:
                countdown = countdownSeconds;
                countdownText.text = waveIndex == 0 ? "Build your towers, then start the first wave" : "";
                break;
            case State.Spawning:
                countdownText.text = "";
                waveText.text = $"Wave {waveIndex + 1} / {waves.Length}";
                game.ShowMessage(waves[waveIndex].Title);
                game.WaveStarted(waveIndex + 1);
                game.PlaySound(waveSound);
                StartCoroutine(SpawnWave(waves[waveIndex]));
                break;
            case State.InProgress:
                break;
            case State.Cleared:
                int bonus = bonusBase + bonusPerWave * (waveIndex + 1);
                bank.Earn(bonus);
                waveIndex++;
                if (waveIndex >= waves.Length)
                {
                    game.Win();
                }
                else
                {
                    game.ShowMessage($"Wave {waveIndex} cleared! +{bonus} gold");
                    EnterState(State.Waiting);
                }
                break;
        }
    }

    // Wave 1 waits for the button; after that, the countdown starts the next
    // wave by itself, unless the player is quicker.
    void UpdateWaiting()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard != null && keyboard.spaceKey.wasPressedThisFrame)
        {
            StartNextWave();
            return;
        }
        if (waveIndex == 0)
        {
            return;
        }
        countdown -= Time.deltaTime;
        countdownText.text = $"Next wave in {Mathf.CeilToInt(countdown)}";
        if (countdown <= 0f)
        {
            StartNextWave();
        }
    }

    public void StartNextWave()
    {
        if (state == State.Waiting && game.IsPlaying)
        {
            EnterState(State.Spawning);
        }
    }

    // A coroutine: one skeleton, a wait, the next, group after group.
    IEnumerator SpawnWave(Wave wave)
    {
        foreach (SpawnGroup group in wave.Groups)
        {
            for (int i = 0; i < group.Count; i++)
            {
                Enemy enemy = Instantiate(group.EnemyPrefab, path.GetPoint(0), Quaternion.identity, skeletonGroup);
                enemy.Begin(game, path);
                yield return new WaitForSeconds(group.Gap);
            }
        }
        EnterState(State.InProgress);
    }

    // The gate fell: no more skeletons.
    public void StopWaves()
    {
        StopAllCoroutines();
    }

    // Back to before wave 1: on Restart.
    public void ResetSpawner()
    {
        StopAllCoroutines();
        foreach (Enemy enemy in skeletonGroup.GetComponentsInChildren<Enemy>())
        {
            Destroy(enemy.gameObject);
        }
        waveIndex = 0;
        waveText.text = $"Wave 0 / {waves.Length}";
        EnterState(State.Waiting);
    }
}
