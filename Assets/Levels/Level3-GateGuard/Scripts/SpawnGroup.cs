using UnityEngine;

// One group of skeletons in a wave: which kind, how many, and how long to wait
// between them. [System.Serializable] lets a plain C# class show in the
// Inspector, so a Wave can keep an array of them.
[System.Serializable]
public class SpawnGroup
{
    [SerializeField] Enemy enemyPrefab;
    [SerializeField] int count = 6;
    [SerializeField] float gap = 1.5f;      // seconds between one skeleton and the next

    public Enemy EnemyPrefab
    {
        get { return enemyPrefab; }
    }

    public int Count
    {
        get { return count; }
    }

    public float Gap
    {
        get { return gap; }
    }
}
