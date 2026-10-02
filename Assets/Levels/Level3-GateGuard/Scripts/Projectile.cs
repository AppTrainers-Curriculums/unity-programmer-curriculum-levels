using UnityEngine;

// A tower's shot. Arrows and frost bolts fly straight at their target and
// follow it; a catapult's stone flies in an arc to where the target was when
// it was thrown, and hits everything where it lands. One script, a switch on
// its kind.
public class Projectile : MonoBehaviour
{
    public enum ProjectileKind { Arrow, Stone, Frost }

    [SerializeField] ProjectileKind kind;
    [SerializeField] float speed = 12f;             // arrows and frost bolts, units a second
    [SerializeField] float flightSeconds = 0.9f;    // a stone's time in the air
    [SerializeField] float arcHeight = 3f;          // how high a stone rises, halfway
    [SerializeField] float aimHeight = 0.45f;       // a skeleton's chest, above its feet
    [SerializeField] GameObject burstPrefab;        // dust or frost, where it lands
    [SerializeField] AudioClip landSound;

    Enemy target;
    TowerLevel stats;
    LayerMask enemyMask;
    Vector3 start;
    Vector3 end;
    float launchTime;

    public void Launch(Enemy aim, TowerLevel level, LayerMask mask)
    {
        target = aim;
        stats = level;
        enemyMask = mask;
        start = transform.position;
        end = kind == ProjectileKind.Stone ? target.transform.position : AimPoint();
        launchTime = Time.time;
    }

    void Update()
    {
        switch (kind)
        {
            case ProjectileKind.Arrow:
            case ProjectileKind.Frost:
                // Follow the target while it's still walking; otherwise fly
                // on to the last place it was.
                if (target != null && target.IsTargetable)
                {
                    end = AimPoint();
                }
                Vector3 before = transform.position;
                transform.position = Vector3.MoveTowards(before, end, speed * Time.deltaTime);
                if (transform.position != before)
                {
                    transform.rotation = Quaternion.LookRotation(transform.position - before);
                }
                if (transform.position == end)
                {
                    Arrive();
                }
                break;
            case ProjectileKind.Stone:
                // t runs from 0 to 1 over the flight. Along the ground it moves
                // in a straight line; up and down it follows 4t(1 − t): 0 at
                // both ends, 1 halfway.
                float t = (Time.time - launchTime) / flightSeconds;
                Vector3 ground = Vector3.Lerp(start, end, t);
                transform.position = ground + Vector3.up * arcHeight * 4f * t * (1f - t);
                if (t >= 1f)
                {
                    Arrive();
                }
                break;
        }
    }

    void Arrive()
    {
        switch (kind)
        {
            case ProjectileKind.Arrow:
                if (target != null)
                {
                    target.TakeDamage(stats.Damage);
                }
                break;
            case ProjectileKind.Stone:
                HitAround(transform.position, stats.SplashRadius, false);
                break;
            case ProjectileKind.Frost:
                if (stats.SplashRadius > 0f)
                {
                    HitAround(transform.position, stats.SplashRadius, true);
                }
                else if (target != null)
                {
                    target.TakeDamage(stats.Damage);
                    target.Slow(stats.SlowFactor, stats.SlowSeconds);
                }
                break;
        }

        if (burstPrefab != null)
        {
            Instantiate(burstPrefab, transform.position, Quaternion.identity);
        }
        if (landSound != null)
        {
            // A sound played at a point is a 3D sound: the further it is from
            // the Audio Listener, on the camera, the quieter. Played at the
            // camera, it's heard at full volume.
            AudioSource.PlayClipAtPoint(landSound, Camera.main.transform.position);
        }
        Destroy(gameObject);
    }

    // Everything on the Enemy layer within radius of the centre is hit.
    void HitAround(Vector3 centre, float radius, bool slows)
    {
        foreach (Collider found in Physics.OverlapSphere(centre, radius, enemyMask))
        {
            if (found.TryGetComponent(out Enemy enemy))
            {
                enemy.TakeDamage(stats.Damage);
                if (slows)
                {
                    enemy.Slow(stats.SlowFactor, stats.SlowSeconds);
                }
            }
        }
    }

    Vector3 AimPoint()
    {
        return target.transform.position + Vector3.up * aimHeight;
    }
}
