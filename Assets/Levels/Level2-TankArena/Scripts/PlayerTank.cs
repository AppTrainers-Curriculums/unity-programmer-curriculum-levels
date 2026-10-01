using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

// The player's tank. With a keyboard: W and S drive, A and D turn, the barrel
// follows the mouse, and Space or a click fires. With a finger: a quick tap
// fires towards that spot, and a press that's held drives the tank there.
[RequireComponent(typeof(Tracks))]
[RequireComponent(typeof(Turret))]
[RequireComponent(typeof(Health))]
public class PlayerTank : MonoBehaviour
{
    [SerializeField] ArenaGame game;
    [SerializeField] float tapTime = 0.25f;       // a press shorter than this is a tap: it fires

    Tracks tracks;
    Turret turret;
    Rigidbody2D body;
    Camera cam;
    Vector2 startPosition;
    bool pressing = false;
    float pressStartTime = 0f;

    public Health Health { get; private set; }

    void Awake()
    {
        tracks = GetComponent<Tracks>();
        turret = GetComponent<Turret>();
        body = GetComponent<Rigidbody2D>();
        Health = GetComponent<Health>();
        cam = Camera.main;
        startPosition = transform.position;
    }

    void Update()
    {
        tracks.Stop();
        if (!game.IsPlaying || Time.timeScale == 0f)
        {
            pressing = false;
            return;
        }

        ReadKeyboard();
        ReadPointer();
    }

    // Tank controls: forwards and backwards along the way it faces, and turning
    // on the spot. A phone may have no keyboard at all, so check for null first.
    void ReadKeyboard()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard == null)
        {
            return;
        }

        float drive = 0f;
        float turn = 0f;
        if (keyboard.wKey.isPressed || keyboard.upArrowKey.isPressed)
        {
            drive += 1f;
        }
        if (keyboard.sKey.isPressed || keyboard.downArrowKey.isPressed)
        {
            drive -= 1f;
        }
        if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed)
        {
            turn += 1f;
        }
        if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed)
        {
            turn -= 1f;
        }
        tracks.Drive(drive, turn);

        if (keyboard.spaceKey.wasPressedThisFrame)
        {
            Fire();
        }
    }

    // The mouse or a finger. The barrel always aims at it. A tap fires; holding
    // it down drives the tank towards it.
    void ReadPointer()
    {
        Pointer pointer = Pointer.current;
        if (pointer == null)
        {
            return;
        }

        Vector2 world = cam.ScreenToWorldPoint(pointer.position.ReadValue());
        turret.AimAt(world);

        if (pointer.press.wasPressedThisFrame)
        {
            pressing = true;
            pressStartTime = Time.time;
        }
        // A press on a button isn't for the tank. The UI only knows a finger is
        // on a button a frame after it lands, so check on every frame.
        if (EventSystem.current.IsPointerOverGameObject())
        {
            pressing = false;
        }
        if (!pressing)
        {
            return;
        }

        float heldFor = Time.time - pressStartTime;
        if (pointer.press.wasReleasedThisFrame)
        {
            pressing = false;
            if (heldFor < tapTime)
            {
                Fire();    // a quick tap
            }
        }
        else if (heldFor >= tapTime)
        {
            tracks.DriveTowards(world);    // a press that's held
        }
    }

    void Fire()
    {
        if (turret.Fire())
        {
            game.ShotFired();
        }
    }

    // Back to the start, facing up, with full health, for a new match.
    public void ResetTank()
    {
        tracks.Stop();
        body.position = startPosition;
        body.rotation = 0f;
        transform.position = startPosition;
        transform.rotation = Quaternion.identity;
        body.linearVelocity = Vector2.zero;
        body.angularVelocity = 0f;
        Health.ResetHealth();
        pressing = false;
    }
}
