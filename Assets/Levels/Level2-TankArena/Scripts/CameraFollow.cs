using UnityEngine;

// Follows the player's tank, smoothly, without ever showing anything outside
// the arena. It can shake too, when something explodes.
[RequireComponent(typeof(Camera))]
public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float smoothing = 5f;        // bigger catches up faster
    [SerializeField] float defaultShake = 0.15f;

    Camera cam;
    Vector3 followPosition;
    float shakeTimeLeft = 0f;
    float shakeStrength = 0f;

    public bool ShakeEnabled { get; set; } = true;

    void Awake()
    {
        cam = GetComponent<Camera>();
        followPosition = transform.position;
    }

    // Two versions (overloads): a normal shake, or one as strong as you ask.
    public void Shake(float seconds)
    {
        Shake(seconds, defaultShake);
    }

    public void Shake(float seconds, float strength)
    {
        shakeTimeLeft = seconds;
        shakeStrength = strength;
    }

    // LateUpdate: after the tank has moved this frame.
    void LateUpdate()
    {
        // Where the camera wants to be: over the tank, but no nearer the edge of
        // the arena than half of what it shows.
        float halfHeight = cam.orthographicSize;
        float halfWidth = halfHeight * cam.aspect;
        float maxX = ArenaBounds.HalfWidth - halfWidth;
        float maxY = ArenaBounds.HalfHeight - halfHeight;
        Vector3 wanted = target.position;
        wanted.x = Mathf.Clamp(wanted.x, -maxX, maxX);
        wanted.y = Mathf.Clamp(wanted.y, -maxY, maxY);
        wanted.z = transform.position.z;

        followPosition = Vector3.Lerp(followPosition, wanted, smoothing * Time.deltaTime);

        // While the game is paused, time doesn't pass, and the shake waits.
        Vector3 jolt = Vector3.zero;
        if (shakeTimeLeft > 0f && Time.timeScale > 0f)
        {
            shakeTimeLeft -= Time.deltaTime;
            if (ShakeEnabled)
            {
                jolt = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f) * shakeStrength;
            }
        }
        transform.position = followPosition + jolt;
    }
}
