using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

// Drag back from anywhere on the screen and let go to putt. It works the same
// with a mouse and with a finger, because it reads the Pointer.
public class ShotAimer : MonoBehaviour
{
    [SerializeField] GolfBall ball;
    [SerializeField] GolfGame game;
    [SerializeField] LineRenderer aimLine;
    [SerializeField] LayerMask wallsMask;
    [SerializeField] float maxForce = 4f;         // the push at full power
    [SerializeField] float fullDrag = 0.35f;      // a drag this big (a share of the screen's height) is full power
    [SerializeField] float lineLength = 1.2f;     // the aim line's length at full power, in metres

    Camera cam;
    bool aiming = false;
    Vector2 dragStart;
    Vector3 shotDirection;
    float shotPower;

    public bool ShowAimLine { get; set; } = true;

    void Awake()
    {
        cam = Camera.main;
        aimLine.enabled = false;
    }

    void Update()
    {
        Pointer pointer = Pointer.current;
        if (pointer == null || !game.CanShoot)
        {
            return;
        }

        if (pointer.press.wasPressedThisFrame && !EventSystem.current.IsPointerOverGameObject())
        {
            aiming = true;
            dragStart = pointer.position.ReadValue();
        }

        if (!aiming)
        {
            return;
        }

        Aim(pointer.position.ReadValue());

        if (pointer.press.wasReleasedThisFrame)
        {
            if (shotPower > 0.05f)
            {
                ball.Shoot(shotDirection, shotPower * maxForce);
                game.StrokeTaken();
            }
            CancelAim();
        }
    }

    void Aim(Vector2 pointerPosition)
    {
        // Pull back to shoot forward: the drag points the opposite way.
        Vector2 drag = dragStart - pointerPosition;
        shotPower = Mathf.Clamp01(drag.magnitude / (Screen.height * fullDrag));

        // Turn the drag on the screen into a direction on the ground, as the camera sees it.
        Vector3 forward = cam.transform.forward;
        forward.y = 0f;
        Vector3 right = cam.transform.right;
        right.y = 0f;
        shotDirection = (forward.normalized * drag.y + right.normalized * drag.x).normalized;

        // The aim line starts at the ball and stops at the first wall in the way.
        Vector3 start = ball.transform.position;
        float length = shotPower * lineLength;
        if (Physics.Raycast(start, shotDirection, out RaycastHit hit, length, wallsMask))
        {
            length = hit.distance;
        }
        aimLine.SetPosition(0, start);
        aimLine.SetPosition(1, start + shotDirection * length);
        aimLine.enabled = ShowAimLine;

        game.ShowPower(shotPower);
    }

    public void CancelAim()
    {
        aiming = false;
        shotPower = 0f;
        aimLine.enabled = false;
        game.ShowPower(0f);
    }
}
