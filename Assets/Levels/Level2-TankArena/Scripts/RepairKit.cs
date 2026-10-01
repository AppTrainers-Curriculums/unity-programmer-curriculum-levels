using UnityEngine;

// A repair kit, sometimes left behind by a destroyed enemy. Drive over it to
// mend your tank. It turns slowly, to catch the eye, and doesn't wait for ever.
public class RepairKit : MonoBehaviour
{
    [SerializeField] int repairAmount = 2;
    [SerializeField] float lifetime = 12f;
    [SerializeField] float spinSpeed = 90f;       // degrees per second

    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    void Update()
    {
        transform.Rotate(0f, 0f, spinSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out PlayerTank player))
        {
            player.Health.Heal(repairAmount);
            Destroy(gameObject);
        }
    }
}
