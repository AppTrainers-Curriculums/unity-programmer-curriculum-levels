using UnityEngine;

// Follows the knight smoothly, and never shows anything outside the level.
[RequireComponent(typeof(Camera))]
public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector2 offset = new Vector2(0f, 2f);         // look a little above the knight
    [SerializeField] float followSpeed = 5f;
    [SerializeField] Vector2 levelMin = new Vector2(0f, -3f);       // the level's bottom-left corner
    [SerializeField] Vector2 levelMax = new Vector2(189f, 12f);     // and its top-right corner

    Camera cam;

    void Awake()
    {
        cam = GetComponent<Camera>();
    }

    // LateUpdate runs after every Update, so the knight has already moved.
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, Goal(), followSpeed * Time.deltaTime);
    }

    // Straight to the knight, with no easing: after a fall, and on Restart.
    public void SnapToTarget()
    {
        transform.position = Goal();
    }

    Vector3 Goal()
    {
        // The camera sees Size units above and below its centre, and
        // Size × aspect units to each side.
        float halfHeight = cam.orthographicSize;
        float halfWidth = halfHeight * cam.aspect;
        float x = Mathf.Clamp(target.position.x + offset.x, levelMin.x + halfWidth, levelMax.x - halfWidth);
        float y = Mathf.Clamp(target.position.y + offset.y, levelMin.y + halfHeight, levelMax.y - halfHeight);
        return new Vector3(x, y, transform.position.z);
    }
}
