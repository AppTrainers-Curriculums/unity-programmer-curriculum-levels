using UnityEngine;

// A power-up drifting down the screen. The ship collects it by touching it.
[RequireComponent(typeof(Rigidbody2D))]
public class PowerUp : MonoBehaviour
{
    public enum Kind { Shield, TripleShot, RapidFire }

    [SerializeField] Kind kind = Kind.Shield;
    [SerializeField] float fallSpeed = 1.5f;

    void Start()
    {
        GetComponent<Rigidbody2D>().linearVelocity = Vector2.down * fallSpeed;
        Destroy(gameObject, 10f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out PlayerShip player))
        {
            player.Collect(kind);
            Destroy(gameObject);
        }
    }
}
