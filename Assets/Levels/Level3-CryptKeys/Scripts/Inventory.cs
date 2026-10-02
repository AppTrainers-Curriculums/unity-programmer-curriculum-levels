using TMPro;
using UnityEngine;
using UnityEngine.UI;

// What the hero carries: keys, the boss key, up to three potions, and gold.
// It keeps the screen's key count, potion slots and gold up to date.
public class Inventory : MonoBehaviour
{
    public const int MaxPotions = 3;

    [SerializeField] HeroHealth health;
    [SerializeField] TMP_Text keyText;
    [SerializeField] Image bossKeyIcon;
    [SerializeField] TMP_Text goldText;
    [SerializeField] Image[] potionIcons;       // the three slots' potions
    [SerializeField] Button[] potionButtons;    // tap a slot to drink
    [SerializeField] int potionHealing = 2;     // a whole heart

    AudioSource audioSource;
    int keys;
    bool hasBossKey;
    int potions;

    public int Gold { get; private set; }

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnEnable()
    {
        foreach (Button button in potionButtons)
        {
            button.onClick.AddListener(DrinkPotion);
        }
    }

    void OnDisable()
    {
        foreach (Button button in potionButtons)
        {
            button.onClick.RemoveListener(DrinkPotion);
        }
    }

    void Start()
    {
        UpdateScreen();
    }

    public void AddKey()
    {
        keys++;
        UpdateScreen();
    }

    public void AddBossKey()
    {
        hasBossKey = true;
        UpdateScreen();
    }

    // False when he already carries three: the potion stays where it is.
    public bool AddPotion()
    {
        if (potions >= MaxPotions)
        {
            return false;
        }
        potions++;
        UpdateScreen();
        return true;
    }

    public void AddGold(int amount)
    {
        Gold += amount;
        UpdateScreen();
    }

    // A door asks for a key: true if there was one to use.
    public bool UseKey()
    {
        if (keys == 0)
        {
            return false;
        }
        keys--;
        UpdateScreen();
        return true;
    }

    public bool UseBossKey()
    {
        if (!hasBossKey)
        {
            return false;
        }
        hasBossKey = false;
        UpdateScreen();
        return true;
    }

    // Q, or a tap on a potion slot. A whole heart back, if there's a potion
    // and he has a heart to lose.
    public void DrinkPotion()
    {
        if (potions == 0 || health.IsDead || health.IsFull)
        {
            return;
        }
        potions--;
        health.Heal(potionHealing);
        UpdateScreen();
    }

    // Pickups play their sound here: a picked-up pickup is hidden at once,
    // and a hidden object can't play anything.
    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }

    void UpdateScreen()
    {
        keyText.text = $"x {keys}";
        bossKeyIcon.enabled = hasBossKey;
        goldText.text = Gold.ToString();
        for (int i = 0; i < potionIcons.Length; i++)
        {
            potionIcons[i].enabled = i < potions;
        }
    }

    public void ResetInventory()
    {
        keys = 0;
        hasBossKey = false;
        potions = 0;
        Gold = 0;
        UpdateScreen();
    }
}
