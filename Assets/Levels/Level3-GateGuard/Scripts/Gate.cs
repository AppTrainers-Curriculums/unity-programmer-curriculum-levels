using UnityEngine;

// The castle gate. Every skeleton that reaches it costs lives: the doors
// shudder (the Hit trigger), and when the last life goes they burst open
// (the Broken Bool) and the game is lost.
public class Gate : MonoBehaviour
{
    static readonly int HitHash = Animator.StringToHash("Hit");
    static readonly int BrokenHash = Animator.StringToHash("Broken");

    [SerializeField] GateGame game;
    [SerializeField] Bank bank;
    [SerializeField] AudioClip hitSound;
    [SerializeField] AudioClip breakSound;

    Animator animator;
    AudioSource audioSource;

    void Awake()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    public void TakeHit(int lives)
    {
        if (bank.Lives <= 0)
        {
            return;
        }
        bank.LoseLives(lives);
        if (bank.Lives > 0)
        {
            animator.SetTrigger(HitHash);
            audioSource.PlayOneShot(hitSound);
        }
        else
        {
            animator.SetBool(BrokenHash, true);
            audioSource.PlayOneShot(breakSound);
            game.Lose();
        }
    }

    // Doors shut again: on Restart.
    public void ResetGate()
    {
        animator.SetBool(BrokenHash, false);
        animator.Rebind();
    }
}
