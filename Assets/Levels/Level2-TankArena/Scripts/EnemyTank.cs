using System.Collections;
using UnityEngine;

// An enemy tank. It drives around the arena to random places; whenever it can
// see the player, with no wall in the way, it stops, turns its barrel and fires.
[RequireComponent(typeof(Tracks))]
[RequireComponent(typeof(Turret))]
[RequireComponent(typeof(Health))]
public class EnemyTank : MonoBehaviour
{
    [SerializeField] string tankName = "Light Tank";
    [SerializeField] float sightRange = 8f;
    [SerializeField] LayerMask sightMask;         // what its eyes stop at: the walls and the player
    [SerializeField] float thinkTime = 3f;        // seconds between two new places to go

    Tracks tracks;
    Turret turret;
    ArenaGame game;
    Transform target;
    Vector2 destination;

    public string TankName
    {
        get { return tankName; }
    }

    public Health Health { get; private set; }

    void Awake()
    {
        tracks = GetComponent<Tracks>();
        turret = GetComponent<Turret>();
        Health = GetComponent<Health>();
        destination = transform.position;
    }

    void Start()
    {
        StartCoroutine(Think());
    }

    // The game hands every new enemy the game itself, and the tank to hunt.
    public void SetGame(ArenaGame arenaGame)
    {
        game = arenaGame;
        target = game.Player.transform;
    }

    // Every few seconds, choose somewhere new to go.
    IEnumerator Think()
    {
        while (true)
        {
            destination = ArenaBounds.RandomPoint();
            yield return new WaitForSeconds(thinkTime);
        }
    }

    void Update()
    {
        if (Health.IsDead)
        {
            game.EnemyDestroyed(this);
            Destroy(gameObject);
            return;
        }

        if (CanSeeTarget(out Vector2 targetPosition))
        {
            tracks.Stop();
            turret.AimAt(targetPosition);
            if (turret.IsAimedAt(targetPosition, 5f))
            {
                turret.Fire();
            }
        }
        else
        {
            // Drive on, with the barrel pointing straight ahead again.
            tracks.DriveTowards(destination);
            turret.AimAt((Vector2)transform.position + (Vector2)transform.up);
        }
    }

    // Can it see the player: close enough, with nothing in the way? If so,
    // targetPosition says where the player is.
    bool CanSeeTarget(out Vector2 targetPosition)
    {
        targetPosition = Vector2.zero;
        if (target == null || !target.gameObject.activeInHierarchy)
        {
            return false;
        }

        targetPosition = target.position;
        Vector2 toTarget = targetPosition - (Vector2)transform.position;
        if (toTarget.magnitude > sightRange)
        {
            return false;
        }

        Vector2 direction = toTarget.normalized;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, sightRange, sightMask);
        Debug.DrawRay(transform.position, direction * sightRange, Color.yellow);
        return hit.collider != null && hit.transform == target;
    }
}
