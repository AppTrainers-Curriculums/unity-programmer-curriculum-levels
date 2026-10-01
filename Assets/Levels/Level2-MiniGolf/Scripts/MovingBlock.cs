using UnityEngine;

// A block that slides from side to side across the lane. It's a kinematic
// Rigidbody, moved by code in FixedUpdate, so the ball bounces off it properly.
[RequireComponent(typeof(Rigidbody))]
public class MovingBlock : MonoBehaviour
{
    [SerializeField] Vector3 travel = new Vector3(0.25f, 0f, 0f);   // how far it slides each way
    [SerializeField] float speed = 1.5f;                              // how fast it swings

    Rigidbody body;
    Vector3 middle;

    void Awake()
    {
        body = GetComponent<Rigidbody>();
        middle = transform.position;
    }

    void FixedUpdate()
    {
        float swing = Mathf.Sin(Time.time * speed);    // goes smoothly from -1 to 1 and back
        body.MovePosition(middle + travel * swing);
    }
}
