using UnityEngine;

// One wave of enemies: its name, which kinds of enemy, how many, and how fast
// they arrive. A plain C# class: the spawner makes each wave with `new`.
public class Wave
{
    public string Name { get; private set; }
    public GameObject[] EnemyPrefabs { get; private set; }
    public int Count { get; private set; }
    public float Delay { get; private set; }

    public Wave(string name, GameObject[] enemyPrefabs, int count, float delay)
    {
        Name = name;
        EnemyPrefabs = enemyPrefabs;
        Count = count;
        Delay = delay;
    }

    public GameObject RandomEnemy()
    {
        return EnemyPrefabs[Random.Range(0, EnemyPrefabs.Length)];
    }
}
