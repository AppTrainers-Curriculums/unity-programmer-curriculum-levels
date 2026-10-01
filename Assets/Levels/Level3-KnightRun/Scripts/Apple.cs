using UnityEngine;

// An apple. It gives the knight back 1 health, unless he already has all 5:
// then it stays where it is, for later.
public class Apple : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out KnightHealth health) && !health.IsDead && health.Health < KnightHealth.MaxHealth)
        {
            health.Heal(1);
            gameObject.SetActive(false);
        }
    }

    public void ResetApple()
    {
        gameObject.SetActive(true);
    }
}
