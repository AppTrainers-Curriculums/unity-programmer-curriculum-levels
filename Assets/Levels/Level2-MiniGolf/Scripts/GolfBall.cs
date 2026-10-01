using UnityEngine;

// The golf ball. Physics moves it; this script pushes it, notices when it has
// stopped, and puts it back on the course.
[RequireComponent(typeof(Rigidbody))]
public class GolfBall : MonoBehaviour
{
    [SerializeField] float stopSpeed = 0.15f;    // slower than this (metres per second)...
    [SerializeField] float stopDelay = 0.2f;     // ...for this long (seconds), and the ball stops
    [SerializeField] float fallLimit = -1f;      // below this height, the ball has left the course

    Rigidbody body;
    float slowTime = 0f;

    public bool IsMoving { get; private set; }
    public Vector3 LastShotPosition { get; private set; }

    // How fast the ball rolls across the course. Up-and-down movement doesn't
    // count: a ball that's only bobbing on the spot has stopped.
    public float Speed
    {
        get
        {
            Vector3 velocity = body.linearVelocity;
            velocity.y = 0f;
            return velocity.magnitude;
        }
    }

    public bool IsOffCourse
    {
        get { return transform.position.y < fallLimit; }
    }

    void Awake()
    {
        body = GetComponent<Rigidbody>();
        LastShotPosition = transform.position;
    }

    void FixedUpdate()
    {
        if (!IsMoving)
        {
            return;
        }

        if (Speed < stopSpeed)
        {
            slowTime += Time.deltaTime;
            if (slowTime >= stopDelay)
            {
                Stop();
            }
        }
        else
        {
            slowTime = 0f;
        }
    }

    public void Shoot(Vector3 direction, float force)
    {
        LastShotPosition = transform.position;
        body.AddForce(direction * force, ForceMode.Impulse);
        IsMoving = true;
        slowTime = 0f;
    }

    public void Stop()
    {
        body.linearVelocity = Vector3.zero;
        body.angularVelocity = Vector3.zero;
        IsMoving = false;
    }

    public void PlaceAt(Vector3 position)
    {
        Stop();
        body.position = position;
        transform.position = position;
    }
}
