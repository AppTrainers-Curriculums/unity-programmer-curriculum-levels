using UnityEngine;

// A laser bolt. It flies straight ahead at a fixed speed, hurts the first thing
// it hits on the other side, and disappears.
[RequireComponent(typeof(Rigidbody2D))]
public class Laser : MonoBehaviour
{
    [SerializeField] float speed = 12f;
    [SerializeField] float lifetime = 1.5f;
    [SerializeField] int damage = 1;
    [SerializeField] bool hitsPlayer = false;    // player lasers hit enemies; enemy lasers hit the player

    void Start()
    {
        // transform.up is the way the laser's sprite points
        GetComponent<Rigidbody2D>().linearVelocity = transform.up * speed;
        Destroy(gameObject, lifetime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (hitsPlayer)
        {
            if (other.TryGetComponent(out PlayerShip player))
            {
                player.TakeHit();
                Destroy(gameObject);
            }
        }
        else if (other.TryGetComponent(out Enemy enemy))
        {
            enemy.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
