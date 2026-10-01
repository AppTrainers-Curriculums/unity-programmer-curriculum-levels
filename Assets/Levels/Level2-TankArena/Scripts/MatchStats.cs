using System.Collections.Generic;

// The numbers of one match: rounds cleared, shots fired, and how many tanks of
// each kind were destroyed. A plain C# class: the game makes a new one, with
// new, at the start of every match.
public class MatchStats
{
    readonly Dictionary<string, int> kills = new Dictionary<string, int>();

    public int RoundsCleared { get; private set; }
    public int ShotsFired { get; private set; }

    public MatchStats(string[] tankNames)
    {
        // Every kind of tank starts at 0, so the summary lists them all.
        foreach (string tankName in tankNames)
        {
            kills[tankName] = 0;
        }
    }

    public int TotalKills
    {
        get
        {
            int total = 0;
            foreach (KeyValuePair<string, int> pair in kills)
            {
                total += pair.Value;
            }
            return total;
        }
    }

    // How many shots each kill took, on average: 0 until there's a kill.
    public float ShotsPerKill
    {
        get
        {
            if (TotalKills == 0)
            {
                return 0f;
            }
            return (float)ShotsFired / TotalKills;
        }
    }

    public void AddRound()
    {
        RoundsCleared++;
    }

    public void AddShot()
    {
        ShotsFired++;
    }

    public void AddKill(string tankName)
    {
        if (kills.ContainsKey(tankName))
        {
            kills[tankName]++;
        }
        else
        {
            kills[tankName] = 1;
        }
    }

    // Everything, one line each, for the end panel.
    public string Summary()
    {
        string lines = $"Rounds cleared: {RoundsCleared}\n";
        foreach (KeyValuePair<string, int> pair in kills)
        {
            lines += $"{pair.Key}s destroyed: {pair.Value}\n";
        }
        lines += $"Shots fired: {ShotsFired}\n";
        lines += $"Shots per kill: {ShotsPerKill:F1}";
        return lines;
    }
}
