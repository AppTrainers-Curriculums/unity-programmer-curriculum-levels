using UnityEngine;

// A signpost. The first time the knight passes it, it lights up, and it
// becomes the place he comes back to after a fall.
public class Checkpoint : MonoBehaviour
{
    static readonly int LitHash = Animator.StringToHash("Lit");

    [SerializeField] PlatformerGame game;

    Animator animator;
    bool isLit;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!isLit && other.TryGetComponent(out KnightController knight))
        {
            isLit = true;
            animator.SetBool(LitHash, true);
            game.SetRespawnPoint(transform.position);
        }
    }

    public void ResetCheckpoint()
    {
        isLit = false;
        animator.SetBool(LitHash, false);
    }
}
