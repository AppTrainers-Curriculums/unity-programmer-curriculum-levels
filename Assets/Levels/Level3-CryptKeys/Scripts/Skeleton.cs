using UnityEngine;

// A skeleton with a sword, run as a state machine. The code decides what it
// does; its Animator, the hero's Humanoid controller with the skeleton's own
// clips, only shows the body: which way it faces, how fast it walks, and an
// attack, a hurt or a fall when one happens.
[RequireComponent(typeof(Rigidbody2D))]
public class Skeleton : MonoBehaviour
{
    public enum State { Idle, Patrol, Chase, Attack, Hurt, Dead }

    static readonly int DirectionHash = Animator.StringToHash("Direction");
    static readonly int SpeedHash = Animator.StringToHash("Speed");
    static readonly int AttackHash = Animator.StringToHash("Attack");
    static readonly int HurtHash = Animator.StringToHash("Hurt");
    static readonly int DeadHash = Animator.StringToHash("Dead");

    [SerializeField] CryptGame game;
    [SerializeField] HeroHealth hero;
    [SerializeField] LayerMask wallMask;
    [SerializeField] AudioClip hitSound;
    [SerializeField] AudioClip deathSound;
    [SerializeField] int maxHealth = 3;
    [SerializeField] float patrolSpeed = 1.5f;
    [SerializeField] float patrolDistance = 2f;     // how far it wanders from where it started
    [SerializeField] float chaseSpeed = 2.5f;
    [SerializeField] float sightRange = 5f;
    [SerializeField] float attackRange = 1f;
    [SerializeField] float attackSeconds = 0.7f;    // as long as the Attack clip
    [SerializeField] float hurtSeconds = 0.4f;
    [SerializeField] float knockbackSpeed = 4f;

    Rigidbody2D body;
    Animator animator;
    Collider2D bodyCollider;
    SpriteRenderer spriteRenderer;
    AudioSource audioSource;
    Vector2 home;
    Vector2 patrolTarget;
    State state;
    Facing facing = Facing.Down;
    int health;
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
        ResetSkeleton();
    }

    void Update()
    {
        // Before Play, after the end and in the pause menu, skeletons wait.
        if (!game.IsPlaying)
        {
            Stop();
            UpdateAnimator();
            return;
        }

        switch (state)
        {
            case State.Idle:
                UpdateIdle();
                break;
            case State.Patrol:
                UpdatePatrol();
                break;
            case State.Chase:
                UpdateChase();
                break;
            case State.Attack:
                UpdateAttack();
                break;
            case State.Hurt:
                UpdateHurt();
                break;
            case State.Dead:
                break;                  // waits for the OnDeathFinished Animation Event
        }
        UpdateAnimator();
    }

    // The one place the state changes. The enter step runs once, as the
    // skeleton arrives in its new state.
    void EnterState(State next)
    {
        state = next;
        stateStartTime = Time.time;

        switch (state)
        {
            case State.Idle:
                Stop();
                break;
            case State.Patrol:
                patrolTarget = home + Random.insideUnitCircle * patrolDistance;
                break;
            case State.Chase:
                break;
            case State.Attack:
                Stop();
                FaceHero();
                animator.SetTrigger(AttackHash);
                break;
            case State.Hurt:
                animator.SetTrigger(HurtHash);
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

    void UpdateIdle()
    {
        if (CanSeeHero())
        {
            EnterState(State.Chase);
        }
        else if (Time.time - stateStartTime > 1.5f)
        {
            EnterState(State.Patrol);
        }
    }

    void UpdatePatrol()
    {
        if (CanSeeHero())
        {
            EnterState(State.Chase);
            return;
        }

        Vector2 toTarget = patrolTarget - body.position;
        if (toTarget.magnitude < 0.1f || Time.time - stateStartTime > 3f)
        {
            EnterState(State.Idle);
            return;
        }
        Move(toTarget.normalized * patrolSpeed);
    }

    // Chase starts within sightRange, but only gives up beyond twice that:
    // with one number for both, a hero standing right at the edge would make
    // the skeleton flip between the two states every frame.
    void UpdateChase()
    {
        Vector2 toHero = HeroPosition() - body.position;
        if (hero.IsDead || toHero.magnitude > sightRange * 2f)
        {
            EnterState(State.Idle);
            return;
        }
        if (toHero.magnitude <= attackRange)
        {
            EnterState(State.Attack);
            return;
        }
        Move(toHero.normalized * chaseSpeed);
    }

    void UpdateAttack()
    {
        if (Time.time - stateStartTime >= attackSeconds)
        {
            EnterState(State.Chase);
        }
    }

    // The knockback carries it for a moment; then it decides between Chase
    // and Dead.
    void UpdateHurt()
    {
        if (Time.time - stateStartTime > 0.15f)
        {
            Stop();
        }
        if (Time.time - stateStartTime >= hurtSeconds)
        {
            EnterState(health > 0 ? State.Chase : State.Dead);
        }
    }

    // Animation Event: the sword's hit frame. The hero is only hurt if he's
    // still in front of the skeleton, so stepping back at the right moment works.
    public void OnAttackHit()
    {
        if (state != State.Attack)
        {
            return;
        }
        Vector2 front = body.position + Facings.ToVector(facing) * 0.6f;
        if (Vector2.Distance(front, HeroPosition()) < 0.8f)
        {
            hero.TakeDamage(1, body.position);
        }
    }

    // The hero's sword hit it.
    public void TakeHit(int damage, Vector2 from)
    {
        if (state == State.Hurt || state == State.Dead)
        {
            return;
        }
        health -= damage;
        audioSource.PlayOneShot(hitSound);
        body.linearVelocity = (body.position - from).normalized * knockbackSpeed;
        EnterState(State.Hurt);
    }

    // Animation Event: at the end of the Dead clips, once it has faded.
    public void OnDeathFinished()
    {
        gameObject.SetActive(false);
    }

    // Back where it started, whole again: on Restart.
    public void ResetSkeleton()
    {
        gameObject.SetActive(true);
        body.simulated = true;
        body.position = home;
        transform.position = home;
        body.linearVelocity = Vector2.zero;
        bodyCollider.enabled = true;

        // The Dead clip fades it out. Put its colour back before Rebind
        // remembers it.
        spriteRenderer.color = Color.white;
        animator.Rebind();

        health = maxHealth;
        facing = Facing.Down;
        EnterState(State.Idle);
    }

    bool CanSeeHero()
    {
        Vector2 heroPosition = HeroPosition();
        if (hero.IsDead || Vector2.Distance(body.position, heroPosition) > sightRange)
        {
            return false;
        }
        // A wall between them blocks the view.
        return !Physics2D.Linecast(body.position, heroPosition, wallMask);
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
