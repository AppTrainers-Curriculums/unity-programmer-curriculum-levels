using UnityEngine;

// A tank shell. It flies straight ahead and bursts on the first solid thing it
// touches: a wall only stops it, a tank loses health.
[RequireComponent(typeof(Rigidbody2D))]
public class Shell : MonoBehaviour
{
    [SerializeField] float speed = 9f;
    [SerializeField] float lifetime = 2f;
    [SerializeField] int damage = 1;
    [SerializeField] GameObject hitPrefab;        // the puff of smoke where it bursts

    void Start()
    {
        // transform.up is the way the shell's sprite points
        GetComponent<Rigidbody2D>().linearVelocity = transform.up * speed;
        Destroy(gameObject, lifetime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.isTrigger)
        {
            return;    // other shells and repair kits don't stop a shell
        }

        if (other.TryGetComponent(out Health health))
        {
            health.TakeDamage(damage);
        }
        Instantiate(hitPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
