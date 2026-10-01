using UnityEngine;

// What a bump with a slime means. Landing on top of it is a stomp, and rolling
// into it knocks it over. Any other bump hurts the knight.
public class KnightCombat : MonoBehaviour
{
    KnightController controller;
    KnightHealth health;

    void Awake()
    {
        controller = GetComponent<KnightController>();
        health = GetComponent<KnightHealth>();
    }

    // Enter: the first moment they touch. Stay: every physics step after that,
    // so a slime still touching him when the blinking ends hurts him again.
    void OnCollisionEnter2D(Collision2D collision)
    {
        HandleBump(collision);
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        HandleBump(collision);
    }

    void HandleBump(Collision2D collision)
    {
        if (collision.contactCount == 0 || health.IsDead)
        {
            return;
        }
        if (!collision.gameObject.TryGetComponent(out Slime slime) || slime.IsHarmless)
        {
            return;
        }

        // The contact's normal points from the slime towards the knight.
        // Pointing up means he came down on top of it.
        if (collision.GetContact(0).normal.y > 0.5f)
        {
            slime.TakeHit(transform.position.x);
            controller.Bounce();
        }
        else if (controller.IsRolling)
        {
            slime.TakeHit(transform.position.x);
        }
        else
        {
            health.TakeDamage(1, slime.transform.position.x);
        }
    }
}
