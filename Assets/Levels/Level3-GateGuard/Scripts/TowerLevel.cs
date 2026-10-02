using UnityEngine;

// What a tower can do at one of its levels. Every tower keeps three of these,
// one per level, in an array: the numbers live in the Inspector, not in code.
[System.Serializable]
public class TowerLevel
{
    [SerializeField] int cost = 50;             // to build it, or to upgrade to this level
    [SerializeField] float range = 4f;
    [SerializeField] int damage = 1;
    [SerializeField] float reloadSeconds = 1f;  // from one shot to the next
    [SerializeField] float splashRadius;        // 0 hits only the target; more hits everything that close
    [SerializeField] float slowFactor = 1f;     // 1 doesn't slow; 0.5 is half speed
    [SerializeField] float slowSeconds;

    public int Cost
    {
        get { return cost; }
    }

    public float Range
    {
        get { return range; }
    }

    public int Damage
    {
        get { return damage; }
    }

    public float ReloadSeconds
    {
        get { return reloadSeconds; }
    }

    public float SplashRadius
    {
        get { return splashRadius; }
    }

    public float SlowFactor
    {
        get { return slowFactor; }
    }

    public float SlowSeconds
    {
        get { return slowSeconds; }
    }
}
