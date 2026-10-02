using System.Collections;
using UnityEngine;

// The Skeleton King, run as a state machine in two phases. In Phase 1 he
// walks at the hero and swings. At half health he summons two skeletons,
// and Phase 2 begins: he spins at the hero in a whirlwind that turns the
// sword aside, rests, open to the sword, and spins again. His Animator is a
// copy of Humanoid, with a Whirlwind state and a Summon state added.
[RequireComponent(typeof(Rigidbody2D))]
public class SkeletonKing : MonoBehaviour
{
    public enum State { Asleep, Walk, Swing, Summon, Whirlwind, Rest, Dead }

    static readonly int DirectionHash = Animator.StringToHash("Direction");
    static readonly int SpeedHash = Animator.StringToHash("Speed");
    static readonly int AttackHash = Animator.StringToHash("Attack");
    static readonly int DeadHash = Animator.StringToHash("Dead");
    static readonly int SummonHash = Animator.StringToHash("Summon");
    static readonly int WhirlwindHash = Animator.StringToHash("Whirlwind");

    [SerializeField] CryptGame game;
    [SerializeField] HeroHealth hero;
    [SerializeField] BossBar bossBar;
    [SerializeField] Skeleton skeletonTemplate;     // a skeleton in the scene, switched off: the summon copies it
    [SerializeField] Transform[] summonPoints;
    [SerializeField] Transform summonGroup;         // where the copies go, so Restart can clear them
    [SerializeField] AudioClip swingSound;
    [SerializeField] AudioClip hitSound;
    [SerializeField] AudioClip summonSound;
    [SerializeField] AudioClip whirlwindSound;
    [SerializeField] AudioClip deathSound;
    [SerializeField] int maxHealth = 20;
    [SerializeField] float walkSpeed = 1.5f;
    [SerializeField] float swingRange = 1.5f;
    [SerializeField] float swingSeconds = 1f;       // as long as his Attack clip
    [SerializeField] int swingDamage = 2;           // a whole heart
    [SerializeField] float summonSeconds = 1.2f;    // as long as his Summon clip
    [SerializeField] float whirlwindSpeed = 3f;     // the hero walks at 4: he can get away
    [SerializeField] float whirlwindSeconds = 2f;
    [SerializeField] int whirlwindDamage = 1;
    [SerializeField] float restSeconds = 1.5f;

    Rigidbody2D body;
    Animator animator;
    Collider2D bodyCollider;
    SpriteRenderer spriteRenderer;
    AudioSource audioSource;
    Vector2 home;
    State state;
    Facing facing = Facing.Down;
    int health;
    bool hasSummoned;
    float stateStartTime;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        bodyCollider = GetComponent<Collider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
        home = transform.position;
    }

    void Start()
    {
        ResetKing();
    }

    void Update()
    {
        if (!game.IsPlaying)
        {
            Stop();
            UpdateAnimator();
            return;
        }

        switch (state)
        {
            case State.Asleep:
                break;                  // waits for Wake, when the hero walks into the tomb
            case State.Walk:
                UpdateWalk();
                break;
            case State.Swing:
                UpdateSwing();
                break;
            case State.Summon:
                UpdateSummon();
                break;
            case State.Whirlwind:
                UpdateWhirlwind();
                break;
            case State.Rest:
                UpdateRest();
                break;
            case State.Dead:
                break;                  // waits for the OnDeathFinished Animation Event
        }
        UpdateAnimator();
    }

    void EnterState(State next)
    {
        state = next;
        stateStartTime = Time.time;

        switch (state)
        {
            case State.Asleep:
                Stop();
                break;
            case State.Walk:
                break;
            case State.Swing:
                Stop();
                FaceHero();
                animator.SetTrigger(AttackHash);
                audioSource.PlayOneShot(swingSound);
                break;
            case State.Summon:
                Stop();
                hasSummoned = true;
                animator.SetTrigger(SummonHash);
                break;
            case State.Whirlwind:
                animator.SetBool(WhirlwindHash, true);
                audioSource.PlayOneShot(whirlwindSound);
                break;
            case State.Rest:
                Stop();
                animator.SetBool(WhirlwindHash, false);
                break;
            case State.Dead:
                Stop();
                bodyCollider.enabled = false;
                body.simulated = false;
                animator.SetTrigger(DeadHash);
                audioSource.PlayOneShot(deathSound);
                break;
        }
    }

    // The hero walked into the tomb.
    public void Wake()
    {
        if (state == State.Asleep)
        {
            bossBar.Show(true);
            EnterState(State.Walk);
        }
    }

    void UpdateWalk()
    {
        if (hero.IsDead)
        {
            Stop();
            return;
        }
        Vector2 toHero = HeroPosition() - body.position;
        if (toHero.magnitude <= swingRange)
        {
            EnterState(State.Swing);
            return;
        }
        Move(toHero.normalized * walkSpeed);
    }

    void UpdateSwing()
    {
        if (Time.time - stateStartTime >= swingSeconds)
        {
            EnterState(State.Walk);
        }
    }

    void UpdateSummon()
    {
        if (Time.time - stateStartTime >= summonSeconds)
        {
            EnterState(State.Whirlwind);
        }
    }

    // He spins after the hero, and hurts him if he gets close.
    void UpdateWhirlwind()
    {
        Vector2 toHero = HeroPosition() - body.position;
        Move(toHero.normalized * whirlwindSpeed);
        if (toHero.magnitude < 1f)
        {
            hero.TakeDamage(whirlwindDamage, body.position);
        }
        if (Time.time - stateStartTime >= whirlwindSeconds)
        {
            EnterState(State.Rest);
        }
    }

    void UpdateRest()
    {
        if (Time.time - stateStartTime >= restSeconds)
        {
            EnterState(State.Whirlwind);
        }
    }

    // Animation Event: his sword's hit frame, on all four Attack clips.
    public void OnAttackHit()
    {
        if (state != State.Swing)
        {
            return;
        }
        Vector2 front = body.position + Facings.ToVector(facing) * 0.8f;
        if (Vector2.Distance(front, HeroPosition()) < 1.1f)
        {
            hero.TakeDamage(swingDamage, body.position);
        }
    }

    // Animation Event: the Summon clip's frame where the golden ring spreads.
    // Each copy of the template is a whole skeleton, already wired up.
    public void OnSummon()
    {
        foreach (Transform point in summonPoints)
        {
            Skeleton skeleton = Instantiate(skeletonTemplate, point.position, Quaternion.identity, summonGroup);
            skeleton.gameObject.SetActive(true);
        }
        audioSource.PlayOneShot(summonSound);
    }

    // The hero's sword hit him. Returns false when it can't hurt him: asleep,
    // summoning, spinning or dead, the sword just clangs.
    public bool TakeHit(int damage, Vector2 from)
    {
        if (state != State.Walk && state != State.Swing && state != State.Rest)
        {
            return false;
        }

        health = Mathf.Max(health - damage, 0);
        bossBar.SetHealth(health, maxHealth);
        audioSource.PlayOneShot(hitSound);
        StartCoroutine(Flicker());

        if (health == 0)
        {
            EnterState(State.Dead);
        }
        else if (!hasSummoned && health <= maxHealth / 2)
        {
            EnterState(State.Summon);
        }
        return true;
    }

    // He's too heavy to be knocked back: he flickers, so the hit shows.
    IEnumerator Flicker()
    {
        for (int i = 0; i < 3; i++)
        {
            spriteRenderer.enabled = false;
            yield return new WaitForSeconds(0.05f);
            spriteRenderer.enabled = true;
            yield return new WaitForSeconds(0.05f);
        }
    }

    // Animation Event: at the end of his Dead clips. The crypt is won.
    public void OnDeathFinished()
    {
        bossBar.Show(false);
        game.Win();
        gameObject.SetActive(false);
    }

    public void ResetKing()
    {
        StopAllCoroutines();
        foreach (Skeleton skeleton in summonGroup.GetComponentsInChildren<Skeleton>(true))
        {
            Destroy(skeleton.gameObject);
        }

        gameObject.SetActive(true);
        body.simulated = true;
        body.position = home;
        transform.position = home;
        body.linearVelocity = Vector2.zero;
        bodyCollider.enabled = true;
        spriteRenderer.enabled = true;
        spriteRenderer.color = Color.white;
        animator.Rebind();

        health = maxHealth;
        hasSummoned = false;
        facing = Facing.Down;
        bossBar.ResetBar();
        EnterState(State.Asleep);
    }

    Vector2 HeroPosition()
    {
        return hero.transform.position;
    }

    void Move(Vector2 velocity)
    {
        body.linearVelocity = velocity;
        facing = Facings.FromVector(velocity, facing);
    }

    void Stop()
    {
        body.linearVelocity = Vector2.zero;
    }

    void FaceHero()
    {
        facing = Facings.FromVector(HeroPosition() - body.position, facing);
    }

    void UpdateAnimator()
    {
        animator.SetInteger(DirectionHash, (int)facing);
        animator.SetFloat(SpeedHash, body.linearVelocity.magnitude);
    }
}
