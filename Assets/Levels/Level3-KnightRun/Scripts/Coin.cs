using UnityEngine;

// A coin. Its spin is a looping clip in its Animator, with no code at all.
// When the knight touches it, it counts, and hides until Restart.
public class Coin : MonoBehaviour
{
    [SerializeField] PlatformerGame game;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out KnightController knight))
        {
            game.AddCoin();
            gameObject.SetActive(false);
        }
    }

    public void ResetCoin()
    {
        gameObject.SetActive(true);
    }
}
