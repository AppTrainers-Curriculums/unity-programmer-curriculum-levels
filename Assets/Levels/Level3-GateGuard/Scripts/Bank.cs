using TMPro;
using UnityEngine;

// The player's gold, and the gate's lives. Both are properties with a
// private set: any script can read them, but only Bank changes them, through
// its methods, so the numbers on the screen always match.
public class Bank : MonoBehaviour
{
    [SerializeField] int startGold = 120;
    [SerializeField] int startLives = 10;
    [SerializeField] TMP_Text goldText;
    [SerializeField] TMP_Text livesText;

    public int Gold { get; private set; }
    public int Lives { get; private set; }

    public bool CanAfford(int cost)
    {
        return Gold >= cost;
    }

    // Takes the gold and answers true, or answers false if there isn't enough.
    public bool Spend(int cost)
    {
        if (!CanAfford(cost))
        {
            return false;
        }
        Gold -= cost;
        UpdateText();
        return true;
    }

    public void Earn(int amount)
    {
        Gold += amount;
        UpdateText();
    }

    public void LoseLives(int amount)
    {
        Lives = Mathf.Max(0, Lives - amount);
        UpdateText();
    }

    public void ResetBank()
    {
        Gold = startGold;
        Lives = startLives;
        UpdateText();
    }

    void UpdateText()
    {
        goldText.text = Gold.ToString();
        livesText.text = Lives.ToString();
    }
}
