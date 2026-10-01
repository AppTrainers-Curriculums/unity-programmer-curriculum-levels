using UnityEngine;

// Hit points, for anything that can be shot: the player's tank and the enemy
// tanks. Other scripts read it through its properties, but only its own methods
// can change it.
public class Health : MonoBehaviour
{
    [SerializeField] int maxHealth = 3;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip hurtSound;         // optional: leave it empty for no sound
    [SerializeField] AudioClip healSound;         // optional too

    public int Current { get; private set; }

    public int Max
    {
        get { return maxHealth; }
    }

    public bool IsDead
    {
        get { return Current <= 0; }
    }

    // How full the health is, from 0 (dead) to 1 (as good as new).
    public float Fraction
    {
        get { return (float)Current / maxHealth; }
    }

    void Awake()
    {
        Current = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        Current = Mathf.Max(Current - amount, 0);
        if (hurtSound != null)
        {
            audioSource.PlayOneShot(hurtSound);
        }
    }

    // Mends 1 point, or as many as you ask for, but never above the maximum.
    public void Heal(int amount = 1)
    {
        Current = Mathf.Min(Current + amount, maxHealth);
        if (healSound != null)
        {
            audioSource.PlayOneShot(healSound);
        }
    }

    public void ResetHealth()
    {
        Current = maxHealth;
    }
}
