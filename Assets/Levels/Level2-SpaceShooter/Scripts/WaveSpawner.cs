using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Sends the waves of enemies, one after another. A new wave only starts when
// every enemy of the last one has been shot down or has flown off the screen.
public class WaveSpawner : MonoBehaviour
{
    [SerializeField] ShooterGame game;
    [SerializeField] GameObject scoutPrefab;
    [SerializeField] GameObject meteorPrefab;
    [SerializeField] GameObject zigzagPrefab;
    [SerializeField] GameObject gunshipPrefab;
    [SerializeField] float spawnWidth = 7.5f;     // enemies appear between -7.5 and 7.5...
    [SerializeField] float spawnHeight = 6f;      // ...just above the top of the screen

    readonly List<Wave> waves = new List<Wave>();

    public int WaveCount
    {
        get { return waves.Count; }
    }

    void Awake()
    {
        Enemy.ResetCount();    // a static count can survive from the last Play

        waves.Add(new Wave("Scouts", new GameObject[] { scoutPrefab }, 8, 0.7f));
        waves.Add(new Wave("Meteor Shower", new GameObject[] { meteorPrefab }, 10, 0.6f));
        waves.Add(new Wave("Zigzag Squadron", new GameObject[] { zigzagPrefab }, 8, 0.8f));
        waves.Add(new Wave("Gunships", new GameObject[] { gunshipPrefab }, 5, 1.5f));
        waves.Add(new Wave("Everything!", new GameObject[] { scoutPrefab, meteorPrefab, zigzagPrefab, gunshipPrefab }, 16, 0.6f));
    }

    public void StartWaves()
    {
        StopWaves();
        StartCoroutine(RunWaves());
    }

    public void StopWaves()
    {
        StopAllCoroutines();
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }

    IEnumerator RunWaves()
    {
        for (int i = 0; i < waves.Count; i++)
        {
            Wave wave = waves[i];
            game.WaveStarted(i + 1, wave.Name);
            yield return new WaitForSeconds(2f);

            for (int n = 0; n < wave.Count; n++)
            {
                Spawn(wave.RandomEnemy());
                yield return new WaitForSeconds(wave.Delay);
            }

            // Wait for the last enemies of this wave to go, one frame at a time.
            while (Enemy.AliveCount > 0)
            {
                yield return null;
            }
        }
        game.Win();
    }

    void Spawn(GameObject prefab)
    {
        Vector3 position = new Vector3(Random.Range(-spawnWidth, spawnWidth), spawnHeight, 0f);
        GameObject enemy = Instantiate(prefab, position, Quaternion.identity, transform);
        enemy.GetComponent<Enemy>().SetGame(game);
    }
}
