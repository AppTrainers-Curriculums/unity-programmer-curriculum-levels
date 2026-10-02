using System.Collections;
using UnityEngine;

// A skeleton on the road, run as a state machine. The code decides what it
// does; its Animator, the Skeleton controller, only shows the body: rising
// from the ground, walking, chopping at the gate, falling. Every kind of
// skeleton is this one script, with its own numbers in the Inspector.
[RequireComponent(typeof(Animator))]
public class Enemy : MonoBehaviour
{
    public enum State { Rising, Walking, Slowed, Dying, AtGate }

    static readonly int WalkSpeedHash = Animator.StringToHash("WalkSpeed");
    static readonly int DieHash = Animator.StringToHash("Die");
    static readonly int AttackHash = Animator.StringToHash("Attack");
    static readonly int CheerHash = Animator.StringToHash("Cheer");

    [SerializeField] int maxHealth = 6;
    [SerializeField] float speed = 1.5f;            // units a second, on the road
    [SerializeField] int bounty = 5;                // gold, for the tower that finishes it
    [SerializeField] int livesCost = 1;             // what it costs the gate
    [SerializeField] float turnSpeed = 540f;        // degrees a second
    [SerializeField] EnemyHealthBar healthBar;
    [SerializeField] GameObject frost;              // the frost that shows while it's slowed
    [SerializeField] Color frostTint = new Color(0.62f, 0.85f, 1f);
    [SerializeField] AudioClip hitSound;
    [SerializeField] AudioClip deathSound;

    GateGame game;
    WaypointPath path;
    Animator animator;
    Collider bodyCollider;
    AudioSource audioSource;
    Renderer[] bodyRenderers;
    State state;
    int health;
    int nextPoint;
    float distanceTravelled;
    float slowFactor = 1f;
    float slowUntil;
    bool killedByTower;
    Color tint = Color.white;
    Coroutine flash;

    // How far along the road it has walked: the towers aim at the biggest.
    public float DistanceTravelled
    {
        get { return distanceTravelled; }
    }

    // Towers only shoot at a skeleton that's up and walking.
    public bool IsTargetable
    {
        get { return state == State.Walking || state == State.Slowed; }
    }

    void Awake()
    {
        animator = GetComponent<Animator>();
        bodyCollider = GetComponent<Collider>();
        audioSource = GetComponent<AudioSource>();
        bodyRenderers = GetComponentsInChildren<SkinnedMeshRenderer>();
    }

    // The spawner calls this as soon as it makes the skeleton: a prefab can't
    // point at things in the scene, so it's handed them here.
    public void Begin(GateGame owner, WaypointPath road)
    {
        game = owner;
        path = road;
        health = maxHealth;
        nextPoint = 1;
        distanceTravelled = 0f;
        transform.position = path.GetPoint(0);
        transform.rotation = Quaternion.LookRotation(path.GetPoint(1) - path.GetPoint(0));
        EnterState(State.Rising);
    }

    void Update()
    {
        // Before Begin, while paused (the clock stops), and after the end, it waits.
        if (game == null || !game.IsPlaying)
        {
            return;
        }

        switch (state)
        {
            case State.Rising:
                break;                  // waits for the OnRisen Animation Event
            case State.Walking:
                Walk(1f);
                break;
            case State.Slowed:
                Walk(slowFactor);
                if (Time.time >= slowUntil)
                {
                    EnterState(State.Walking);
                }
                break;
            case State.Dying:
                break;                  // waits for OnDeathFinished
            case State.AtGate:
                break;                  // waits for OnGateHit
        }
    }

    // The one place the state changes. The enter step runs once, as the
    // skeleton arrives in its new state.
    void EnterState(State next)
    {
        state = next;

        switch (state)
        {
            case State.Rising:
                bodyCollider.enabled = false;           // the towers can't see it yet
                healthBar.Hide();
                break;
            case State.Walking:
                bodyCollider.enabled = true;
                slowFactor = 1f;
                animator.SetFloat(WalkSpeedHash, 1f);
                frost.SetActive(false);
                SetTint(Color.white);
                break;
            case State.Slowed:
                animator.SetFloat(WalkSpeedHash, slowFactor);   // the Walk clip plays slower too
                frost.SetActive(true);
                SetTint(frostTint);
                break;
            case State.Dying:
                bodyCollider.enabled = false;
                healthBar.Hide();
                frost.SetActive(false);
                animator.SetTrigger(DieHash);
                audioSource.PlayOneShot(deathSound);
                break;
            case State.AtGate:
                bodyCollider.enabled = false;
                animator.SetTrigger(AttackHash);
                break;
        }
    }

    // Walks towards the next point on the road, turning to face it. factor is
    // 1 at full speed, 0.5 when slowed.
    void Walk(float factor)
    {
        Vector3 target = path.GetPoint(nextPoint);
        Vector3 before = transform.position;
        transform.position = Vector3.MoveTowards(before, target, speed * factor * Time.deltaTime);
        distanceTravelled += Vector3.Distance(before, transform.position);

        Vector3 toTarget = target - transform.position;
        if (toTarget.sqrMagnitude > 0.0001f)
        {
            Quaternion facing = Quaternion.LookRotation(toTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, facing, turnSpeed * Time.deltaTime);
        }

        if (transform.position == target)
        {
            nextPoint++;
            if (nextPoint >= path.Count)
            {
                EnterState(State.AtGate);
            }
        }
    }

    // A tower's shot hit it.
    public void TakeDamage(int damage)
    {
        if (!IsTargetable)
        {
            return;
        }
        health -= damage;
        healthBar.Show((float)health / maxHealth);
        audioSource.PlayOneShot(hitSound);
        if (flash != null)
        {
            StopCoroutine(flash);
        }
        flash = StartCoroutine(FlashRed());
        if (health <= 0)
        {
            killedByTower = true;
            EnterState(State.Dying);
        }
    }

    // A frost bolt hit it: slower for a while. Two bolts keep the slower
    // speed and the later end.
    public void Slow(float factor, float seconds)
    {
        if (!IsTargetable)
        {
            return;
        }
        slowFactor = state == State.Slowed ? Mathf.Min(slowFactor, factor) : factor;
        slowUntil = Mathf.Max(slowUntil, Time.time + seconds);
        EnterState(State.Slowed);
    }

    // The gate has fallen: whoever is still standing celebrates.
    public void Cheer()
    {
        if (state != State.Dying)
        {
            animator.SetTrigger(CheerHash);
        }
    }

    // Animation Event: the end of the Rise clip, once it's out of the ground.
    public void OnRisen()
    {
        if (state == State.Rising)
        {
            EnterState(State.Walking);
        }
    }

    // Animation Event: the chop's frame, as the blade hits the gate.
    public void OnGateHit()
    {
        if (state != State.AtGate)
        {
            return;
        }
        game.Gate.TakeHit(livesCost);
        killedByTower = false;          // no bounty for this one
        EnterState(State.Dying);
    }

    // Animation Event: the end of the Die clip.
    public void OnDeathFinished()
    {
        if (killedByTower)
        {
            game.Bank.Earn(bounty);
        }
        Destroy(gameObject);
    }

    // An Animator has one layer at Level 3, so a hit can't play a clip without
    // stopping the walk. The hit shows as a red flash instead, for a moment.
    IEnumerator FlashRed()
    {
        SetColour(Color.red);
        yield return new WaitForSeconds(0.08f);
        SetColour(tint);
        flash = null;
    }

    void SetTint(Color colour)
    {
        tint = colour;
        SetColour(colour);
    }

    void SetColour(Color colour)
    {
        foreach (Renderer part in bodyRenderers)
        {
            part.material.color = colour;
        }
    }
}
