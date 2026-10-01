using UnityEngine;

// Keeps the camera above and behind the ball. It runs in LateUpdate: after the
// ball has moved this frame, so the camera never lags a frame behind.
public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector3 offset = new Vector3(0f, 1.6f, -1.6f);
    [SerializeField] float smoothing = 4f;

    void LateUpdate()
    {
        Vector3 wanted = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, wanted, smoothing * Time.deltaTime);
    }
}
