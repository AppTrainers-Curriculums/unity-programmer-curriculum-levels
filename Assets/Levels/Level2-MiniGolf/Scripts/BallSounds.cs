using UnityEngine;

// Plays a click when the ball hits a wall: the harder the hit, the louder.
public class BallSounds : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip wallSound;

    void OnCollisionEnter(Collision collision)
    {
        // A floor faces up (its normal's y is near 1); a wall faces sideways (near 0).
        bool hitWall = Mathf.Abs(collision.GetContact(0).normal.y) < 0.5f;
        float impact = collision.relativeVelocity.magnitude;
        if (hitWall && impact > 0.2f)
        {
            audioSource.PlayOneShot(wallSound, Mathf.Clamp01(impact / 2f));
        }
    }
}
