using UnityEngine;

// A trigger in the cup. A ball that's slow enough while it's inside has
// dropped in; a fast one rolls over the hole and carries on.
public class Cup : MonoBehaviour
{
    [SerializeField] GolfGame game;
    [SerializeField] float sinkSpeed = 1f;

    void OnTriggerStay(Collider other)
    {
        if (other.TryGetComponent(out GolfBall ball) && ball.Speed < sinkSpeed)
        {
            game.BallInCup();
        }
    }
}
