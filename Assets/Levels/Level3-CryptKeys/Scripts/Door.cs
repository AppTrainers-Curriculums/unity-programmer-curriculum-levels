using UnityEngine;

// A locked door. Walk into it carrying a key, and it opens: the Open Bool
// starts its Opening clip, whose last frame calls OnDoorOpened, and only
// then does the doorway stop blocking the way.
public class Door : MonoBehaviour
{
    static readonly int OpenHash = Animator.StringToHash("Open");

    [SerializeField] CryptGame game;
    [SerializeField] bool needsBossKey;
    [SerializeField] Collider2D blocker;
    [SerializeField] AudioClip openSound;

    Animator animator;
    AudioSource audioSource;
    bool isOpen;

    void Awake()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (isOpen || !collision.gameObject.TryGetComponent(out Inventory inventory))
        {
            return;
        }

        bool hasKey = needsBossKey ? inventory.UseBossKey() : inventory.UseKey();
        if (!hasKey)
        {
            game.ShowMessage(needsBossKey ? "The boss key opens this door" : "Locked: find a key");
            return;
        }

        isOpen = true;
        animator.SetBool(OpenHash, true);
        audioSource.PlayOneShot(openSound);
    }

    // Animation Event: the Opening clip's last frame, once the door is open.
    public void OnDoorOpened()
    {
        blocker.enabled = false;
    }

    public void ResetDoor()
    {
        isOpen = false;
        blocker.enabled = true;
        animator.SetBool(OpenHash, false);
        animator.Rebind();
    }
}
