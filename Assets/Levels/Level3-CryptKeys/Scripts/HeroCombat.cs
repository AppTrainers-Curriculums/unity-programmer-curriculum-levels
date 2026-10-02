using UnityEngine;

// The hero's sword. An attack starts the Attack clip, and the clip's hit
// frame calls OnAttackHit: only then does the sword hurt what's in front.
public class HeroCombat : MonoBehaviour
{
    static readonly int AttackHash = Animator.StringToHash("Attack");

    [SerializeField] LayerMask enemyMask;
    [SerializeField] AudioClip swingSound;
    [SerializeField] AudioClip clangSound;          // the king's whirlwind turns the sword aside
    [SerializeField] int damage = 1;
    [SerializeField] float attackSeconds = 0.5f;    // as long as the Attack clip
    [SerializeField] float hitDistance = 0.7f;      // how far in front of his middle the sword's circle is
    [SerializeField] float hitRadius = 0.6f;

    // His body's middle, above his feet: the sword's circle is measured from here.
    readonly Vector2 middle = new Vector2(0f, 0.4f);

    Animator animator;
    AudioSource audioSource;
    Vector2 attackDirection;
    float attackEndTime;

    public bool IsAttacking
    {
        get { return Time.time < attackEndTime; }
    }

    void Awake()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // An attack the way he faces: direction is Facings.ToVector of his facing.
    public void Attack(Vector2 direction)
    {
        if (IsAttacking)
        {
            return;
        }
        attackDirection = direction;
        attackEndTime = Time.time + attackSeconds;
        animator.SetTrigger(AttackHash);
        audioSource.PlayOneShot(swingSound);
    }

    // Animation Event: the sword's hit frame, on all four Attack clips.
    // Everything on the Enemy layer inside the circle is hit.
    public void OnAttackHit()
    {
        Vector2 front = (Vector2)transform.position + middle + attackDirection * hitDistance;
        Collider2D[] hits = Physics2D.OverlapCircleAll(front, hitRadius, enemyMask);
        foreach (Collider2D hit in hits)
        {
            if (hit.TryGetComponent(out Skeleton skeleton))
            {
                skeleton.TakeHit(damage, transform.position);
            }
            else if (hit.TryGetComponent(out Archer archer))
            {
                archer.TakeHit(damage, transform.position);
            }
            else if (hit.TryGetComponent(out SkeletonKing king) && !king.TakeHit(damage, transform.position))
            {
                audioSource.PlayOneShot(clangSound);
            }
        }
    }

    public void ResetCombat()
    {
        attackEndTime = 0f;
    }
}
