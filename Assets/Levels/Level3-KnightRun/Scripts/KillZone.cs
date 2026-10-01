using UnityEngine;

// Water, goo, the moat, and the bottom of the level. The knight loses 1
// health and goes back to the last checkpoint. A slime that falls in is gone
// until Restart.
public class KillZone : MonoBehaviour
{
    [SerializeField] PlatformerGame game;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out KnightController knight))
        {
            game.KnightFell();
        }
        else if (other.TryGetComponent(out Slime slime))
        {
            slime.gameObject.SetActive(false);
        }
    }
}
