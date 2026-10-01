using UnityEngine;

// A tank's tracks: they drive it along the way it faces, and turn it on the
// spot. The player's tank and the enemy tanks all use them; their own scripts
// decide where to go.
[RequireComponent(typeof(Rigidbody2D))]
public class Tracks : MonoBehaviour
{
    [SerializeField] float moveSpeed = 3f;        // units per second
    [SerializeField] float turnSpeed = 120f;      // degrees per second

    Rigidbody2D body;
    float drive = 0f;
    float turn = 0f;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // drive: 1 forwards, -1 backwards, 0 stop. turn: 1 left, -1 right, 0 straight on.
    public void Drive(float driveAmount, float turnAmount)
    {
        drive = Mathf.Clamp(driveAmount, -1f, 1f);
        turn = Mathf.Clamp(turnAmount, -1f, 1f);
    }

    // Turns towards a point, and drives forwards once it's facing roughly that way.
    public void DriveTowards(Vector2 point)
    {
        Vector2 toPoint = point - body.position;
        if (toPoint.magnitude < 0.4f)
        {
            Stop();    // close enough: it has arrived
            return;
        }

        // The angle is more than 0 when the point is to the left. The tank turns
        // fully while it's 30° or more off, and drives only once it's within 45°.
        float angle = Vector2.SignedAngle(transform.up, toPoint);
        float turnAmount = angle / 30f;
        float driveAmount = Mathf.Abs(angle) < 45f ? 1f : 0f;
        Drive(driveAmount, turnAmount);
    }

    public void Stop()
    {
        Drive(0f, 0f);
    }

    // Physics moves the tank, on the physics clock.
    void FixedUpdate()
    {
        body.linearVelocity = (Vector2)transform.up * (drive * moveSpeed);
        body.angularVelocity = turn * turnSpeed;
    }
}
