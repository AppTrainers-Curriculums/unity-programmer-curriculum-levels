using System.Collections;
using UnityEngine;

// The hero's health, counted in half hearts: 6 is three whole hearts. A hit
// knocks him back and makes him blink, and nothing can hurt him while he
// blinks. At 0 he falls, and when his Dead clip ends, the game is lost.
public class HeroHealth : MonoBehaviour
{
    public const int MaxHealth = 6;

    static readonly int HurtHash = Animator.StringToHash("Hurt");
    static readonly int DeadHash = Animator.StringToHash("Dead");

    [SerializeField] CryptGame game;
    [SerializeField] HeartsBar hearts;
    [SerializeField] AudioClip hurtSound;
    [SerializeField] AudioClip healSound;
    [SerializeField] float knockbackSpeed = 6f;
    [SerializeField] float stunSeconds = 0.2f;      // no control, while the knockback carries him
    [SerializeField] float blinkSeconds = 1f;

    Rigidbody2D body;
    Animator animator;
    SpriteRenderer spriteRenderer;
    AudioSource audioSource;
    bool isBlinking;
    float stunnedUntil;

    public int Health { get; private set; } = MaxHealth;
    public bool IsDead { get; private set; }

    public bool IsStunned
    {
        get { return Time.time < stunnedUntil; }
    }

    public bool IsFull
    {
        get { return Health == MaxHealth; }
    }

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
    }

    void Start()
    {
        hearts.SetHealth(Health);
    }

    // Something hurt him. from is where it was, so he's knocked away from it.
    public void TakeDamage(int amount, Vector2 from)
    {
        // Nothing hurts him while he blinks, or once he has fallen, or when
        // the game isn't being played.
        if (IsDead || isBlinking || !game.IsPlaying)
        {
            return;
        }

        Health = Mathf.Max(Health - amount, 0);
        hearts.SetHealth(Health);
        audioSource.PlayOneShot(hurtSound);

        if (Health == 0)
        {
            IsDead = true;
            body.linearVelocity = Vector2.zero;
            animator.SetTrigger(DeadHash);
            return;
        }

        Vector2 away = (body.position - from).normalized;
        body.linearVelocity = away * knockbackSpeed;
        stunnedUntil = Time.time + stunSeconds;
        animator.SetTrigger(HurtHash);
        StartCoroutine(Blink());
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
        hearts.SetHealth(Health);
        audioSource.PlayOneShot(healSound);
    }

    // Animation Event: at the end of the Dead clips.
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
        hearts.SetHealth(Health);
    }
}
