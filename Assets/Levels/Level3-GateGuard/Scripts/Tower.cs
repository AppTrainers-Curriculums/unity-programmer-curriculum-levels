using UnityEngine;

// A tower on a plot, run as a state machine: Idle with nothing in range, Aim
// at the skeleton furthest along the road, Fire, then Reload. It has two
// Animators: its crew's (the archer, the mage or the catapult), driven with
// Aiming and Fire, and its own, whose Level switches the tower's looks. One
// script serves all three kinds: what differs is in the Inspector, and in
// the shot each one fires.
public class Tower : MonoBehaviour
{
    public enum State { Idle, Aim, Fire, Reload }

    static readonly int AimingHash = Animator.StringToHash("Aiming");
    static readonly int FireHash = Animator.StringToHash("Fire");
    static readonly int LevelHash = Animator.StringToHash("Level");

    [SerializeField] string title = "Arrow Tower";
    [SerializeField] TowerLevel[] levels;       // Levels 1, 2 and 3
    [SerializeField] Animator crew;
    [SerializeField] Transform turret;          // what turns to face the target
    [SerializeField] Transform muzzle;          // where its shots start
    [SerializeField] Projectile shotPrefab;
    [SerializeField] LayerMask enemyMask;
    [SerializeField] float turnSpeed = 360f;    // degrees a second
    [SerializeField] AudioClip shootSound;
    [SerializeField] AudioClip buildSound;

    GateGame game;
    Transform shotGroup;
    Animator body;
    AudioSource audioSource;
    State state;
    int level;
    int spent;
    Enemy target;
    float stateStartTime;

    public string Title
    {
        get { return title; }
    }

    public int Level
    {
        get { return level; }
    }

    public TowerLevel Current
    {
        get { return levels[level - 1]; }
    }

    public int BuildCost
    {
        get { return levels[0].Cost; }
    }

    public bool CanUpgrade
    {
        get { return level < levels.Length; }
    }

    public int UpgradeCost
    {
        get { return CanUpgrade ? levels[level].Cost : 0; }
    }

    // Selling gives back 60% of everything spent on the tower.
    public int SellValue
    {
        get { return Mathf.RoundToInt(spent * 0.6f); }
    }

    void Awake()
    {
        body = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // The plot calls this as soon as it makes the tower.
    public void Build(GateGame owner, Transform shots)
    {
        game = owner;
        shotGroup = shots;
        level = 1;
        spent = levels[0].Cost;
        body.SetInteger(LevelHash, level);
        audioSource.PlayOneShot(buildSound);
        EnterState(State.Idle);
    }

    public void Upgrade()
    {
        if (!CanUpgrade)
        {
            return;
        }
        level++;
        spent += levels[level - 1].Cost;
        body.SetInteger(LevelHash, level);      // the Level clip adds a storey, or the flags
        audioSource.PlayOneShot(buildSound);
    }

    void Update()
    {
        if (game == null || !game.IsPlaying)
        {
            return;
        }

        switch (state)
        {
            case State.Idle:
                target = FindTarget();
                if (target != null)
                {
                    EnterState(State.Aim);
                }
                break;
            case State.Aim:
                if (!InRange(target))
                {
                    target = FindTarget();
                }
                if (target == null)
                {
                    EnterState(State.Idle);
                }
                else if (TurnTowards(target))
                {
                    EnterState(State.Fire);
                }
                break;
            case State.Fire:
                if (InRange(target))
                {
                    TurnTowards(target);
                }
                // The shot leaves on the crew's OnRelease event. If it never
                // comes (the crew was interrupted), aim again.
                if (Time.time - stateStartTime > 2f)
                {
                    EnterState(State.Aim);
                }
                break;
            case State.Reload:
                if (Time.time - stateStartTime >= Current.ReloadSeconds)
                {
                    EnterState(State.Aim);
                }
                break;
        }
    }

    void EnterState(State next)
    {
        state = next;
        stateStartTime = Time.time;

        switch (state)
        {
            case State.Idle:
                target = null;
                crew.SetBool(AimingHash, false);
                break;
            case State.Aim:
                crew.SetBool(AimingHash, true);
                break;
            case State.Fire:
                crew.SetTrigger(FireHash);
                break;
            case State.Reload:
                break;
        }
    }

    // TowerCrew calls this on the crew's OnRelease Animation Event: the
    // frame the arrow leaves the bow, the bolt the staff, the stone the arm.
    public void Release()
    {
        if (state != State.Fire)
        {
            return;
        }
        if (InRange(target))
        {
            Projectile shot = Instantiate(shotPrefab, muzzle.position, Quaternion.identity, shotGroup);
            shot.Launch(target, Current, enemyMask);
            audioSource.PlayOneShot(shootSound);
        }
        EnterState(State.Reload);
    }

    // The skeleton furthest along the road, within range: the one closest to
    // the gate. Physics.OverlapSphere finds every collider on the Enemy layer
    // inside the circle; the loop keeps the best.
    Enemy FindTarget()
    {
        Enemy best = null;
        foreach (Collider found in Physics.OverlapSphere(transform.position, Current.Range, enemyMask))
        {
            if (found.TryGetComponent(out Enemy enemy) && enemy.IsTargetable &&
                (best == null || enemy.DistanceTravelled > best.DistanceTravelled))
            {
                best = enemy;
            }
        }
        return best;
    }

    bool InRange(Enemy enemy)
    {
        if (enemy == null || !enemy.IsTargetable)
        {
            return false;
        }
        Vector3 offset = enemy.transform.position - transform.position;
        offset.y = 0f;
        return offset.magnitude <= Current.Range;
    }

    // Turns the turret a little towards the enemy, on the ground only, and
    // answers true once it's facing it.
    bool TurnTowards(Enemy enemy)
    {
        Vector3 toEnemy = enemy.transform.position - turret.position;
        toEnemy.y = 0f;
        Quaternion facing = Quaternion.LookRotation(toEnemy);
        turret.rotation = Quaternion.RotateTowards(turret.rotation, facing, turnSpeed * Time.deltaTime);
        return Quaternion.Angle(turret.rotation, facing) < 5f;
    }
}
