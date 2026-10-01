using UnityEngine;

// A slime, run as a state machine. Each state's enter step tells the Animator
// which state it's in, through the State parameter, so the Animator follows
// the code. The purple slime is this same script, with other numbers.
[RequireComponent(typeof(Rigidbody2D))]
public class Slime : MonoBehaviour
{
    public enum State { Patrol, Chase, WindUp, Leap, Hurt, Dead }

    static readonly int StateHash = Animator.StringToHash("State");

    [SerializeField] PlatformerGame game;
    [SerializeField] KnightHealth knight;
    [SerializeField] LayerMask groundMask;
    [SerializeField] AudioClip squashSound;
    [SerializeField] int maxHealth = 1;
    [SerializeField] float patrolSpeed = 1.5f;
    [SerializeField] float patrolDistance = 2f;     // how far it wanders from where it started, each way
    [SerializeField] float chaseSpeed = 2.5f;
    [SerializeField] float sightRange = 4f;
    [SerializeField] float leapRange = 1.2f;
    [SerializeField] Vector2 leapVelocity = new Vector2(4f, 6f);
    [SerializeField] Vector2 knockback = new Vector2(3f, 3f);
    [SerializeField] float hurtSeconds = 0.4f;

    Rigidbody2D body;
    Animator animator;
    SpriteRenderer spriteRenderer;
    Collider2D slimeCollider;
    AudioSource audioSource;
    Vector2 startPosition;
    State state;
    int health;
    float direction = -1f;      // -1 left, 1 right
    float stateStartTime;

    // A hurt or dead slime can't hurt the knight, and can't be hit again.
    public bool IsHarmless
    {
        get { return state == State.Hurt || state == State.Dead; }
    }

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        slimeCollider = GetComponent<Collider2D>();
        audioSource = GetComponent<AudioSource>();
        startPosition = transform.position;
    }

    void Start()
    {
        ResetSlime();
    }

    void Update()
    {
        // Before Play, after the end and in the pause menu, slimes wait.
        if (!game.IsPlaying)
        {
            Stop();
            return;
        }

        switch (state)
        {
            case State.Patrol:
                UpdatePatrol();
                break;
            case State.Chase:
                UpdateChase();
                break;
            case State.WindUp:
                break;                  // waits for the OnLeap Animation Event
            case State.Leap:
                UpdateLeap();
                break;
            case State.Hurt:
                UpdateHurt();
                break;
            case State.Dead:
                break;                  // waits for the OnDeathFinished Animation Event
        }

        // The slime's picture looks left, so it flips to look right.
        spriteRenderer.flipX = direction > 0f;
    }

    // The one place the state changes. The enter step runs once, as the
    // slime arrives in its new state.
    void EnterState(State next)
    {
        state = next;
        stateStartTime = Time.time;
        animator.SetInteger(StateHash, (int)state);

        switch (state)
        {
            case State.Patrol:
                break;
            case State.Chase:
                break;
            case State.WindUp:
                Stop();
                break;
            case State.Leap:
                body.linearVelocity = new Vector2(direction * leapVelocity.x, leapVelocity.y);
                break;
            case State.Hurt:
                break;
            case State.Dead:
                Stop();
                slimeCollider.enabled = false;
                body.simulated = false;
                audioSource.PlayOneShot(squashSound);
                break;
        }
    }

    void UpdatePatrol()
    {
        if (CanSeeKnight(sightRange))
        {
            EnterState(State.Chase);
            return;
        }

        // Turn round at either end of its patch of ground, or at an edge.
        bool isPastRight = direction > 0f && transform.position.x > startPosition.x + patrolDistance;
        bool isPastLeft = direction < 0f && transform.position.x < startPosition.x - patrolDistance;
        if (isPastRight || isPastLeft || !HasGroundAhead())
        {
            direction = -direction;
        }
        Move(patrolSpeed);
    }

    void UpdateChase()
    {
        // It gives up once the knight is well away.
        if (!CanSeeKnight(sightRange * 1.5f))
        {
            EnterState(State.Patrol);
            return;
        }

        float toKnight = knight.transform.position.x - transform.position.x;
        direction = toKnight < 0f ? -1f : 1f;

        if (Mathf.Abs(toKnight) <= leapRange && IsGrounded() && HasGroundAhead())
        {
            EnterState(State.WindUp);
        }
        else if (HasGroundAhead())
        {
            Move(chaseSpeed);
        }
        else
        {
            Stop();     // it never chases him off a ledge
        }
    }

    void UpdateLeap()
    {
        // Landed: a moment after take-off, it's standing on the ground again.
        if (Time.time > stateStartTime + 0.2f && IsGrounded())
        {
            EnterState(State.Chase);
        }
    }

    void UpdateHurt()
    {
        if (Time.time < stateStartTime + hurtSeconds)
        {
            return;
        }
        if (health > 0)
        {
            EnterState(State.Chase);
        }
        else
        {
            EnterState(State.Dead);
        }
    }

    // Stomped or rolled into. fromX is where the knight is, so it flies away from him.
    public void TakeHit(float fromX)
    {
        if (IsHarmless)
        {
            return;
        }
        health--;
        float away = transform.position.x < fromX ? -1f : 1f;
        body.linearVelocity = new Vector2(knockback.x * away, knockback.y);
        EnterState(State.Hurt);
    }

    // Animation Event: on the last frame of the WindUp clip.
    public void OnLeap()
    {
        // A stomp during the wind-up changes the state first: then there's no leap.
        if (state == State.WindUp)
        {
            EnterState(State.Leap);
        }
    }

    // Animation Event: at the end of the Dead clip, once it has melted and faded.
    public void OnDeathFinished()
    {
        gameObject.SetActive(false);
    }

    bool CanSeeKnight(float range)
    {
        if (knight.IsDead)
        {
            return false;
        }
        Vector2 toKnight = knight.transform.position - transform.position;
        return Mathf.Abs(toKnight.x) < range && Mathf.Abs(toKnight.y) < 1.5f;
    }

    bool IsGrounded()
    {
        Vector2 start = (Vector2)transform.position + new Vector2(0f, 0.1f);
        return Physics2D.Raycast(start, Vector2.down, 0.2f, groundMask).collider != null;
    }

    // Is there ground half a tile ahead, in the direction it's going?
    bool HasGroundAhead()
    {
        Vector2 start = (Vector2)transform.position + new Vector2(direction * 0.5f, 0.1f);
        return Physics2D.Raycast(start, Vector2.down, 0.6f, groundMask).collider != null;
    }

    void Move(float speed)
    {
        body.linearVelocity = new Vector2(direction * speed, body.linearVelocity.y);
    }

    void Stop()
    {
        body.linearVelocity = new Vector2(0f, body.linearVelocity.y);
    }

    // Back where it started, alive and patrolling: on Restart.
    public void ResetSlime()
    {
        gameObject.SetActive(true);
        body.simulated = true;
        body.position = startPosition;
        transform.position = startPosition;
        body.linearVelocity = Vector2.zero;
        slimeCollider.enabled = true;

        // The Dead clip fades it out. Put its colour back before Rebind
        // remembers it.
        spriteRenderer.color = Color.white;
        animator.Rebind();

        health = maxHealth;
        direction = -1f;
        EnterState(State.Patrol);
    }
}
