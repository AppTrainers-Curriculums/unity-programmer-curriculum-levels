using UnityEngine;
using UnityEngine.InputSystem;

// The knight: he runs, jumps and rolls, with the keyboard or the touch
// buttons, and tells his Animator what he's doing every frame.
[RequireComponent(typeof(Rigidbody2D))]
public class KnightController : MonoBehaviour
{
    // The Animator's parameters, turned into numbers once. Strings are slow to
    // look up, and a typo in a hash's name is easy to spot: it's written once.
    static readonly int SpeedHash = Animator.StringToHash("Speed");
    static readonly int VerticalSpeedHash = Animator.StringToHash("VerticalSpeed");
    static readonly int GroundedHash = Animator.StringToHash("Grounded");
    static readonly int RollHash = Animator.StringToHash("Roll");

    [SerializeField] PlatformerGame game;
    [SerializeField] Transform leftFoot;
    [SerializeField] Transform rightFoot;
    [SerializeField] LayerMask groundMask;
    [SerializeField] AudioClip jumpSound;
    [SerializeField] AudioClip stepSound;
    [SerializeField] AudioClip rollSound;
    [SerializeField] float runSpeed = 6f;
    [SerializeField] float jumpSpeed = 12f;
    [SerializeField] float rollSpeed = 9f;
    [SerializeField] float rollCooldown = 0.4f;     // seconds from the end of one roll to the next
    [SerializeField] float bounceSpeed = 9f;        // how high a stomp throws him
    [SerializeField] float groundCheckDistance = 0.15f;

    Rigidbody2D body;
    Animator animator;
    SpriteRenderer spriteRenderer;
    AudioSource audioSource;
    KnightHealth health;

    float moveInput;            // -1 left, 0 still, 1 right
    bool isGrounded;
    bool isFacingLeft;
    bool isRolling;
    float rollDirection;
    float nextRollTime;
    bool isLeftHeld;            // the touch buttons
    bool isRightHeld;
    bool isJumpQueued;
    bool isRollQueued;

    public bool IsRolling
    {
        get { return isRolling; }
    }

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
        health = GetComponent<KnightHealth>();
    }

    void Update()
    {
        isGrounded = CheckGround();

        // The touch buttons only queue a jump or a roll. Use them up now.
        bool isJumpPressed = isJumpQueued;
        bool isRollPressed = isRollQueued;
        isJumpQueued = false;
        isRollQueued = false;

        moveInput = 0f;
        if (isLeftHeld)
        {
            moveInput -= 1f;
        }
        if (isRightHeld)
        {
            moveInput += 1f;
        }

        // The keyboard. A phone may have no keyboard, and then Keyboard.current is null.
        Keyboard keyboard = Keyboard.current;
        if (keyboard != null)
        {
            if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed)
            {
                moveInput -= 1f;
            }
            if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed)
            {
                moveInput += 1f;
            }
            if (keyboard.spaceKey.wasPressedThisFrame || keyboard.wKey.wasPressedThisFrame || keyboard.upArrowKey.wasPressedThisFrame)
            {
                isJumpPressed = true;
            }
            if (keyboard.leftShiftKey.wasPressedThisFrame || keyboard.rightShiftKey.wasPressedThisFrame || keyboard.jKey.wasPressedThisFrame)
            {
                isRollPressed = true;
            }
        }
        moveInput = Mathf.Clamp(moveInput, -1f, 1f);

        if (HasControl())
        {
            if (moveInput != 0f && !isRolling)
            {
                isFacingLeft = moveInput < 0f;
                spriteRenderer.flipX = isFacingLeft;
            }
            if (isJumpPressed && isGrounded && !isRolling)
            {
                Jump();
            }
            if (isRollPressed && isGrounded && !isRolling && Time.time >= nextRollTime)
            {
                StartRoll();
            }
        }
        else
        {
            moveInput = 0f;
        }

        // Run, or roll. While he's stunned, the knockback carries him instead.
        // A velocity is safe to set in Update: the Rigidbody keeps it until the
        // next physics step uses it.
        if (!health.IsStunned)
        {
            float speedX = moveInput * runSpeed;
            if (isRolling)
            {
                speedX = rollDirection * rollSpeed;
            }
            body.linearVelocity = new Vector2(speedX, body.linearVelocity.y);
        }

        animator.SetFloat(SpeedHash, Mathf.Abs(body.linearVelocity.x));
        animator.SetFloat(VerticalSpeedHash, body.linearVelocity.y);
        animator.SetBool(GroundedHash, isGrounded);
    }

    bool HasControl()
    {
        return game.IsPlaying && !health.IsDead && !health.IsStunned;
    }

    // Two short rays down from his feet, against the Ground layer only.
    // Moving up is never standing: that's a jump just starting.
    bool CheckGround()
    {
        if (body.linearVelocity.y > 0.01f)
        {
            return false;
        }
        RaycastHit2D left = Physics2D.Raycast(leftFoot.position, Vector2.down, groundCheckDistance, groundMask);
        RaycastHit2D right = Physics2D.Raycast(rightFoot.position, Vector2.down, groundCheckDistance, groundMask);
        return left.collider != null || right.collider != null;
    }

    void Jump()
    {
        body.linearVelocity = new Vector2(body.linearVelocity.x, jumpSpeed);
        isGrounded = false;
        audioSource.PlayOneShot(jumpSound);
    }

    void StartRoll()
    {
        isRolling = true;
        rollDirection = isFacingLeft ? -1f : 1f;
        animator.SetTrigger(RollHash);
        audioSource.PlayOneShot(rollSound);
    }

    // A stomp throws him back up off the slime.
    public void Bounce()
    {
        body.linearVelocity = new Vector2(body.linearVelocity.x, bounceSpeed);
    }

    // Animation Event: on each frame of the Run clip where a foot lands.
    public void OnFootstep()
    {
        if (isGrounded)
        {
            audioSource.PlayOneShot(stepSound, 0.4f);
        }
    }

    // Animation Event: on the last frame of the Roll clip.
    public void OnRollFinished()
    {
        isRolling = false;
        nextRollTime = Time.time + rollCooldown;
    }

    // The touch buttons call these, through their Event Triggers.
    public void SetLeftHeld(bool isHeld)
    {
        isLeftHeld = isHeld;
    }

    public void SetRightHeld(bool isHeld)
    {
        isRightHeld = isHeld;
    }

    public void PressJump()
    {
        isJumpQueued = true;
    }

    public void PressRoll()
    {
        isRollQueued = true;
    }

    // Back to a starting point, standing still and facing right: after a fall,
    // and on Restart.
    public void ResetKnight(Vector2 position)
    {
        body.position = position;
        transform.position = position;
        body.linearVelocity = Vector2.zero;

        // A fall can cut the Roll clip short, and then OnRollFinished never
        // comes. So the reset ends the roll itself.
        isRolling = false;
        nextRollTime = 0f;
        isFacingLeft = false;
        spriteRenderer.flipX = false;

        // The Dead clip fades him out. Put his colour back first: Rebind
        // remembers the colour he has now as the one to go back to.
        spriteRenderer.color = Color.white;
        animator.Rebind();
    }
}
