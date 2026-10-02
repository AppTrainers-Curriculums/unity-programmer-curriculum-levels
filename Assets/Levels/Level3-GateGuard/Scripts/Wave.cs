using UnityEngine;

// One wave: its name, and its groups of skeletons, which come one group after
// another. WaveSpawner keeps an array of these, and each one holds an array
// of SpawnGroups: arrays inside an array, all filled in in the Inspector.
[System.Serializable]
public class Wave
{
    [SerializeField] string title;
    [SerializeField] SpawnGroup[] groups;

    public string Title
    {
        get { return title; }
    }

    public SpawnGroup[] Groups
    {
        get { return groups; }
    }
}
