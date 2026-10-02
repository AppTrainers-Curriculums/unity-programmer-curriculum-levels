using UnityEngine;

// A skeleton archer, run as a state machine. It keeps its distance, shoots
// when it can see the hero, then steps aside before shooting again. Its
// Animator is the Humanoid controller, with the archer's own clips.
[RequireComponent(typeof(Rigidbody2D))]
public class Archer : MonoBehaviour
{
    public enum State { Idle, KeepDistance, Shoot, Reposition, Hurt, Dead }

    static readonly int DirectionHash = Animator.StringToHash("Direction");
    static readonly int SpeedHash = Animator.StringToHash("Speed");
    static readonly int AttackHash = Animator.StringToHash("Attack");
    static readonly int HurtHash = Animator.StringToHash("Hurt");
    static readonly int DeadHash = Animator.StringToHash("Dead");

    [SerializeField] CryptGame game;
    [SerializeField] HeroHealth hero;
    [SerializeField] Arrow arrowPrefab;
    [SerializeField] Transform arrowGroup;          // where its arrows go, so Restart can clear them
    [SerializeField] LayerMask wallMask;
    [SerializeField] AudioClip shootSound;
    [SerializeField] AudioClip hitSound;
    [SerializeField] AudioClip deathSound;
    [SerializeField] int maxHealth = 2;
    [SerializeField] float moveSpeed = 2f;
    [SerializeField] float sightRange = 9f;
    [SerializeField] float tooClose = 4f;           // closer than this, it backs away
    [SerializeField] float tooFar = 6f;             // further than this, it comes closer
    [SerializeField] float shootSeconds = 1f;       // as long as the Attack clip
    [SerializeField] float repositionSeconds = 0.8f;
    [SerializeField] float hurtSeconds = 0.4f;
    [SerializeField] float knockbackSpeed = 4f;

    Rigidbody2D body;
    Animator animator;
    Collider2D bodyCollider;
    SpriteRenderer spriteRenderer;
    AudioSource audioSource;
    Vector2 home;
    Vector2 sideStep;
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
        ResetArcher();
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
            case State.Idle:
                UpdateIdle();
                break;
            case State.KeepDistance:
                UpdateKeepDistance();
                break;
            case State.Shoot:
                UpdateShoot();
                break;
            case State.Reposition:
                UpdateReposition();
                break;
            case State.Hurt:
                UpdateHurt();
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
            case State.Idle:
                Stop();
                break;
            case State.KeepDistance:
                break;
            case State.Shoot:
                Stop();
                FaceHero();
                animator.SetTrigger(AttackHash);
                break;
            case State.Reposition:
                // A step to one side or the other, across the line to the hero.
                Vector2 toHero = (HeroPosition() - body.position).normalized;
                Vector2 across = new Vector2(-toHero.y, toHero.x);
                sideStep = (Random.value < 0.5f ? across : -across) * moveSpeed;
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
            EnterState(State.KeepDistance);
        }
    }

    void UpdateKeepDistance()
    {
        if (!CanSeeHero())
        {
            EnterState(State.Idle);
            return;
        }

        Vector2 toHero = HeroPosition() - body.position;
        if (toHero.magnitude < tooClose)
        {
            Move(-toHero.normalized * moveSpeed);
            facing = Facings.FromVector(toHero, facing);     // backs away, still facing the hero
        }
        else if (toHero.magnitude > tooFar)
        {
            Move(toHero.normalized * moveSpeed);
        }
        else
        {
            EnterState(State.Shoot);
        }
    }

    void UpdateShoot()
    {
        if (Time.time - stateStartTime >= shootSeconds)
        {
            EnterState(State.Reposition);
        }
    }

    void UpdateReposition()
    {
        Move(sideStep);
        if (Time.time - stateStartTime >= repositionSeconds)
        {
            EnterState(State.KeepDistance);
        }
    }

    void UpdateHurt()
    {
        if (Time.time - stateStartTime > 0.15f)
        {
            Stop();
        }
        if (Time.time - stateStartTime >= hurtSeconds)
        {
            EnterState(health > 0 ? State.KeepDistance : State.Dead);
        }
    }

    // Animation Event: the release frame, as the bowstring snaps forward.
    // The arrow flies from the archer's feet at where the hero's feet are now.
    public void OnAttackHit()
    {
        if (state != State.Shoot)
        {
            return;
        }
        Vector2 from = body.position + Facings.ToVector(facing) * 0.4f;
        Arrow arrow = Instantiate(arrowPrefab, from, Quaternion.identity, arrowGroup);
        arrow.Launch(HeroPosition() - from);
        audioSource.PlayOneShot(shootSound);
    }

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

    public void ResetArcher()
    {
        gameObject.SetActive(true);
        body.simulated = true;
        body.position = home;
        transform.position = home;
        body.linearVelocity = Vector2.zero;
        bodyCollider.enabled = true;
        spriteRenderer.color = Color.white;
        animator.Rebind();

        health = maxHealth;
        facing = Facing.Down;
        EnterState(State.Idle);
    }

    // It sees the hero if he's within range and no wall is in the way. A
    // statue isn't a wall, but its collider is on the Walls layer too: cover.
    bool CanSeeHero()
    {
        Vector2 heroPosition = HeroPosition();
        if (hero.IsDead || Vector2.Distance(body.position, heroPosition) > sightRange)
        {
            return false;
        }
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
