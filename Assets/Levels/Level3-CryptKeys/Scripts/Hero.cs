using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

// The hero: walks with the keyboard, or towards a pointer that's held down,
// and faces one of four ways. Every frame he tells the Animator his Direction
// and his Speed. A quick tap swings the sword, or opens the chest in front.
[RequireComponent(typeof(Rigidbody2D))]
public class Hero : MonoBehaviour
{
    static readonly int DirectionHash = Animator.StringToHash("Direction");
    static readonly int SpeedHash = Animator.StringToHash("Speed");

    [SerializeField] CryptGame game;
    [SerializeField] float walkSpeed = 4f;
    [SerializeField] float holdSeconds = 0.25f;     // a press longer than this walks; a shorter one is a tap
    [SerializeField] float reach = 0.6f;            // how far in front of his feet a chest can be opened

    Rigidbody2D body;
    Animator animator;
    SpriteRenderer spriteRenderer;
    HeroCombat combat;
    HeroHealth health;
    Inventory inventory;
    Camera mainCamera;
    Facing facing = Facing.Up;
    float pressStart = -1f;     // when the pointer went down, or -1 when it isn't down
    bool isPressOnUi;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        combat = GetComponent<HeroCombat>();
        health = GetComponent<HeroHealth>();
        inventory = GetComponent<Inventory>();
        mainCamera = Camera.main;
    }

    void Update()
    {
        Vector2 move = Vector2.zero;
        if (HasControl() && !combat.IsAttacking)
        {
            move = ReadKeyboard() + ReadPointer();
        }
        else if (!HasControl())
        {
            pressStart = -1f;
        }

        if (move.sqrMagnitude > 0.01f)
        {
            facing = Facings.FromVector(move, facing);
        }

        // While he's stunned, the knockback carries him instead. A velocity
        // is safe to set in Update: the Rigidbody keeps it until the next
        // physics step uses it.
        if (!health.IsStunned)
        {
            body.linearVelocity = Vector2.ClampMagnitude(move, 1f) * walkSpeed;
        }

        animator.SetInteger(DirectionHash, (int)facing);
        animator.SetFloat(SpeedHash, body.linearVelocity.magnitude);
    }

    bool HasControl()
    {
        return game.IsPlaying && !health.IsDead && !health.IsStunned;
    }

    // W A S D or the arrows walk; Space or J attacks; E opens; Q drinks.
    // A phone may have no keyboard, and then Keyboard.current is null.
    Vector2 ReadKeyboard()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard == null)
        {
            return Vector2.zero;
        }

        Vector2 move = Vector2.zero;
        if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed)
        {
            move.x -= 1f;
        }
        if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed)
        {
            move.x += 1f;
        }
        if (keyboard.sKey.isPressed || keyboard.downArrowKey.isPressed)
        {
            move.y -= 1f;
        }
        if (keyboard.wKey.isPressed || keyboard.upArrowKey.isPressed)
        {
            move.y += 1f;
        }

        if (keyboard.spaceKey.wasPressedThisFrame || keyboard.jKey.wasPressedThisFrame)
        {
            combat.Attack(Facings.ToVector(facing));
        }
        if (keyboard.eKey.wasPressedThisFrame)
        {
            TryOpenChest();
        }
        if (keyboard.qKey.wasPressedThisFrame)
        {
            inventory.DrinkPotion();
        }
        return move.normalized;
    }

    // The mouse, or a finger: held down longer than holdSeconds, he walks
    // towards it; a quicker tap is handled by Tap. A press that lands on the
    // UI, such as a potion slot, belongs to the UI.
    Vector2 ReadPointer()
    {
        Pointer pointer = Pointer.current;
        if (pointer == null)
        {
            return Vector2.zero;
        }

        if (pointer.press.wasPressedThisFrame)
        {
            pressStart = Time.time;
            isPressOnUi = false;
        }
        if (pressStart < 0f)
        {
            return Vector2.zero;
        }

        // The UI only knows a finger is on a button a frame after it lands,
        // so ask on every frame of the press.
        if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
        {
            isPressOnUi = true;
        }

        Vector2 target = mainCamera.ScreenToWorldPoint(pointer.position.ReadValue());
        if (pointer.press.wasReleasedThisFrame || !pointer.press.isPressed)
        {
            if (!isPressOnUi && Time.time - pressStart <= holdSeconds)
            {
                Tap(target);
            }
            pressStart = -1f;
            return Vector2.zero;
        }

        Vector2 toTarget = target - body.position;
        if (isPressOnUi || Time.time - pressStart <= holdSeconds || toTarget.magnitude < 0.2f)
        {
            return Vector2.zero;
        }
        return toTarget.normalized;
    }

    // A tap opens the chest in front of him, or swings the sword the way of the tap.
    void Tap(Vector2 target)
    {
        if (TryOpenChest())
        {
            return;
        }
        facing = Facings.FromVector(target - body.position, facing);
        animator.SetInteger(DirectionHash, (int)facing);
        combat.Attack(Facings.ToVector(facing));
    }

    // A chest's collider is at its foot, as his is, so this circle is
    // measured from his feet.
    bool TryOpenChest()
    {
        Vector2 front = body.position + Facings.ToVector(facing) * reach;
        Collider2D[] hits = Physics2D.OverlapCircleAll(front, 0.45f);
        foreach (Collider2D hit in hits)
        {
            if (hit.TryGetComponent(out Chest chest) && !chest.IsOpen)
            {
                chest.Open();
                return true;
            }
        }
        return false;
    }

    // Back at the start, facing into the crypt: on Restart.
    public void ResetHero(Vector2 position)
    {
        body.position = position;
        transform.position = position;
        body.linearVelocity = Vector2.zero;
        facing = Facing.Up;
        pressStart = -1f;

        // The Dead clip fades him out. Put his colour back first: Rebind
        // remembers the colour he has now as the one to go back to.
        spriteRenderer.color = Color.white;
        animator.Rebind();
        animator.SetInteger(DirectionHash, (int)facing);
    }
}
