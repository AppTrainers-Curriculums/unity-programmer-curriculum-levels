using UnityEngine;

// A chest. Open sets the Open trigger; the Opening clip's lid-up frame calls
// OnLootReady, and the loot waiting in front of the chest appears just then.
public class Chest : MonoBehaviour
{
    static readonly int OpenHash = Animator.StringToHash("Open");

    [SerializeField] GameObject[] loot;     // hidden pickups, placed in front of the chest
    [SerializeField] AudioClip openSound;

    Animator animator;
    AudioSource audioSource;

    public bool IsOpen { get; private set; }

    void Awake()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    public void Open()
    {
        if (IsOpen)
        {
            return;
        }
        IsOpen = true;
        animator.SetTrigger(OpenHash);
        audioSource.PlayOneShot(openSound);
    }

    // Animation Event: the Opening clip's last frame, as the lid comes up.
    public void OnLootReady()
    {
        foreach (GameObject item in loot)
        {
            item.SetActive(true);
        }
    }

    public void ResetChest()
    {
        IsOpen = false;
        foreach (GameObject item in loot)
        {
            item.SetActive(false);
        }
        animator.Rebind();
    }
}
