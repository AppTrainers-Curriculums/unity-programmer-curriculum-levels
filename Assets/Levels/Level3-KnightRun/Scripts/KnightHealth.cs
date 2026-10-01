using System.Collections;
using UnityEngine;

// The knight's health: 5 to start with. A slime knocks him back and makes him
// blink, and nothing can hurt him while he blinks. At 0 he falls, and when his
// Dead clip ends, the game is lost.
public class KnightHealth : MonoBehaviour
{
    public const int MaxHealth = 5;

    static readonly int HurtHash = Animator.StringToHash("Hurt");
    static readonly int DeadHash = Animator.StringToHash("Dead");

    [SerializeField] PlatformerGame game;
    [SerializeField] HealthBar healthBar;
    [SerializeField] AudioClip hurtSound;
    [SerializeField] AudioClip healSound;
    [SerializeField] Vector2 knockback = new Vector2(5f, 6f);
    [SerializeField] float stunSeconds = 0.25f;     // no control, while the knockback carries him
    [SerializeField] float blinkSeconds = 1f;

    Rigidbody2D body;
    Animator animator;
    SpriteRenderer spriteRenderer;
    AudioSource audioSource;
    KnightController controller;
    bool isBlinking;
    float stunnedUntil;

    public int Health { get; private set; } = MaxHealth;
    public bool IsDead { get; private set; }

    public bool IsStunned
    {
        get { return Time.time < stunnedUntil; }
    }

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
        controller = GetComponent<KnightController>();
    }

    void Start()
    {
        healthBar.SetHealth(Health, MaxHealth);
    }

    // A slime hurt him. fromX is where the slime is, so he flies away from it.
    public void TakeDamage(int amount, float fromX)
    {
        // Nothing hurts him while he blinks or rolls, and a fallen knight
        // can't fall again.
        if (IsDead || isBlinking || controller.IsRolling)
        {
            return;
        }

        LoseHealth(amount);
        if (IsDead)
        {
            return;
        }

        float direction = transform.position.x < fromX ? -1f : 1f;
        body.linearVelocity = new Vector2(knockback.x * direction, knockback.y);
        stunnedUntil = Time.time + stunSeconds;
        animator.SetTrigger(HurtHash);
    }

    // He fell into water, goo or the moat. The game has already put him back
    // at the last checkpoint.
    public void FellInPit()
    {
        if (!IsDead)
        {
            LoseHealth(1);
        }
    }

    void LoseHealth(int amount)
    {
        Health = Mathf.Max(Health - amount, 0);
        healthBar.SetHealth(Health, MaxHealth);
        audioSource.PlayOneShot(hurtSound);

        if (Health == 0)
        {
            IsDead = true;
            body.linearVelocity = new Vector2(0f, body.linearVelocity.y);
            animator.SetTrigger(DeadHash);
        }
        else
        {
            StartCoroutine(Blink());
        }
    }

    IEnumerator Blink()
    {
        isBlinking = true;
        float endTime = Time.time + blinkSeconds;
        while (Time.time < endTime)
        {
            spriteRenderer.enabled = !spriteRenderer.enabled;
            yield return new WaitForSeconds(0.1f);
        }
        spriteRenderer.enabled = true;
        isBlinking = false;
    }

    public void Heal(int amount)
    {
        Health = Mathf.Min(Health + amount, MaxHealth);
        healthBar.SetHealth(Health, MaxHealth);
        audioSource.PlayOneShot(healSound);
    }

    // Animation Event: at the end of the Dead clip, once he has faded out.
    public void OnDeathFinished()
    {
        game.Lose();
    }

    public void ResetHealth()
    {
        StopAllCoroutines();
        Health = MaxHealth;
        IsDead = false;
        isBlinking = false;
        stunnedUntil = 0f;
        spriteRenderer.enabled = true;
        healthBar.SetHealth(Health, MaxHealth);
    }
}
