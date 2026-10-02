using UnityEngine;

// An archer's arrow. It flies straight, hurts the hero, and breaks on
// anything solid. Like every collider in the crypt, its collider is at the
// height of the feet; its picture is a child, drawn higher, at the height of
// a bow. It's on the Enemy layer, so it flies through skeletons.
[RequireComponent(typeof(Rigidbody2D))]
public class Arrow : MonoBehaviour
{
    [SerializeField] Transform picture;
    [SerializeField] float speed = 7f;
    [SerializeField] int damage = 1;
    [SerializeField] float lifeSeconds = 3f;

    public void Launch(Vector2 direction)
    {
        // The picture points up: turn its up to the way the arrow flies.
        picture.up = direction.normalized;
        GetComponent<Rigidbody2D>().linearVelocity = direction.normalized * speed;
        Destroy(gameObject, lifeSeconds);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Other triggers, such as pickups, aren't in the way.
        if (other.isTrigger)
        {
            return;
        }
        if (other.TryGetComponent(out HeroHealth hero))
        {
            hero.TakeDamage(damage, transform.position);
        }
        Destroy(gameObject);
    }
}
