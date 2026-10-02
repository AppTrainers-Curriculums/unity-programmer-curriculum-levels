using UnityEngine;

// A key, the boss key, a potion or a pile of gold: one script for all four.
// Its Kind says which, and a switch does the rest.
public class Pickup : MonoBehaviour
{
    public enum Kind { Key, BossKey, Potion, Gold }

    [SerializeField] Kind kind;
    [SerializeField] int gold = 25;             // for Gold only
    [SerializeField] bool startsHidden;         // loot waits, hidden, until its chest opens
    [SerializeField] AudioClip pickupSound;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.TryGetComponent(out Inventory inventory))
        {
            return;
        }

        switch (kind)
        {
            case Kind.Key:
                inventory.AddKey();
                break;
            case Kind.BossKey:
                inventory.AddBossKey();
                break;
            case Kind.Potion:
                if (!inventory.AddPotion())
                {
                    return;     // he carries three already: it waits for later
                }
                break;
            case Kind.Gold:
                inventory.AddGold(gold);
                break;
        }
        inventory.PlaySound(pickupSound);
        gameObject.SetActive(false);
    }

    public void ResetPickup()
    {
        gameObject.SetActive(!startsHidden);
    }
}
