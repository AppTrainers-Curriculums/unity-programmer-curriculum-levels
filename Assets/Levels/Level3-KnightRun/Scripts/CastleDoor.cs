using UnityEngine;

// The castle door at the end of the level. Walking into it wins.
public class CastleDoor : MonoBehaviour
{
    [SerializeField] PlatformerGame game;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out KnightController knight))
        {
            game.Win();
        }
    }
}
