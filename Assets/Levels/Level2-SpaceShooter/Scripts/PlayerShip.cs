using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

// The player's ship. It flies with the keyboard or follows a finger, fires
// lasers, collects power-ups, and blinks for a moment after it's hit.
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerShip : MonoBehaviour
{
    [SerializeField] ShooterGame game;
    [SerializeField] GameObject laserPrefab;
    [SerializeField] Transform muzzle;
    [SerializeField] GameObject shield;
    [SerializeField] SpriteRenderer shipRenderer;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip laserSound;
    [SerializeField] AudioClip powerUpSound;
    [SerializeField] AudioClip shieldDownSound;
    [SerializeField] float speed = 8f;
    [SerializeField] float shotsPerSecond = 4f;
    [SerializeField] float powerUpSeconds = 8f;
    [SerializeField] float fingerGap = 1f;        // the ship flies this far above a finger, so you can see it
    [SerializeField] Vector2 minPosition = new Vector2(-8.2f, -4.4f);
    [SerializeField] Vector2 maxPosition = new Vector2(8.2f, 1f);

    Rigidbody2D body;
    Camera cam;
    Vector2 startPosition;
    Vector2 keyboardDirection;
    Vector2 pointerTarget;
    bool followPointer = false;
    float nextShotTime = 0f;
    float tripleShotUntil = 0f;
    float rapidFireUntil = 0f;
    bool invulnerable = false;

    bool HasTripleShot
    {
        get { return Time.time < tripleShotUntil; }
    }

    bool HasRapidFire
    {
        get { return Time.time < rapidFireUntil; }
    }

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        cam = Camera.main;
        startPosition = transform.position;
    }

    void Update()
    {
        // Start every frame standing still: only keys and fingers held down
        // right now can move the ship.
        keyboardDirection = Vector2.zero;
        followPointer = false;
        if (!game.IsPlaying || Time.timeScale == 0f)
        {
            return;
        }

        // The keyboard: arrows or W A S D, and Space to fire. A phone may have
        // no keyboard at all, and then Keyboard.current is null.
        Keyboard keyboard = Keyboard.current;
        bool spaceHeld = false;
        if (keyboard != null)
        {
            if (keyboard.leftArrowKey.isPressed || keyboard.aKey.isPressed)
            {
                keyboardDirection.x -= 1f;
            }
            if (keyboard.rightArrowKey.isPressed || keyboard.dKey.isPressed)
            {
                keyboardDirection.x += 1f;
            }
            if (keyboard.downArrowKey.isPressed || keyboard.sKey.isPressed)
            {
                keyboardDirection.y -= 1f;
            }
            if (keyboard.upArrowKey.isPressed || keyboard.wKey.isPressed)
            {
                keyboardDirection.y += 1f;
            }
            keyboardDirection = keyboardDirection.normalized;
            spaceHeld = keyboard.spaceKey.isPressed;
        }

        // A finger or the mouse: while it's held down, the ship follows it.
        Pointer pointer = Pointer.current;
        followPointer = pointer != null && pointer.press.isPressed && !EventSystem.current.IsPointerOverGameObject();
        if (followPointer)
        {
            Vector2 world = cam.ScreenToWorldPoint(pointer.position.ReadValue());
            pointerTarget = world + new Vector2(0f, fingerGap);
        }

        // Fire while Space is held, or while the ship is following the pointer.
        if ((spaceHeld || followPointer) && Time.time >= nextShotTime)
        {
            Fire();
        }
    }

    // Physics moves the ship, on the physics clock.
    void FixedUpdate()
    {
        Vector2 next;
        if (followPointer)
        {
            next = Vector2.MoveTowards(body.position, pointerTarget, speed * Time.deltaTime);
        }
        else
        {
            next = body.position + keyboardDirection * speed * Time.deltaTime;
        }

        next.x = Mathf.Clamp(next.x, minPosition.x, maxPosition.x);
        next.y = Mathf.Clamp(next.y, minPosition.y, maxPosition.y);
        body.MovePosition(next);
    }

    void Fire()
    {
        if (HasTripleShot)
        {
            FireLaser(-12f);
            FireLaser(0f);
            FireLaser(12f);
        }
        else
        {
            FireLaser(0f);
        }
        audioSource.PlayOneShot(laserSound);

        float rate = shotsPerSecond;
        if (HasRapidFire)
        {
            rate = shotsPerSecond * 2f;
        }
        nextShotTime = Time.time + 1f / rate;
    }

    // One laser from the muzzle, turned by angle degrees: 0 flies straight up.
    void FireLaser(float angle)
    {
        Instantiate(laserPrefab, muzzle.position, Quaternion.Euler(0f, 0f, angle));
    }

    public void Collect(PowerUp.Kind kind)
    {
        audioSource.PlayOneShot(powerUpSound);
        switch (kind)
        {
            case PowerUp.Kind.Shield:
                shield.SetActive(true);
                break;
            case PowerUp.Kind.TripleShot:
                tripleShotUntil = Time.time + powerUpSeconds;
                break;
            case PowerUp.Kind.RapidFire:
                rapidFireUntil = Time.time + powerUpSeconds;
                break;
        }
    }

    public void TakeHit()
    {
        if (invulnerable || !game.IsPlaying)
        {
            return;
        }

        if (shield.activeSelf)
        {
            shield.SetActive(false);    // the shield takes the hit instead
            audioSource.PlayOneShot(shieldDownSound);
            return;
        }

        game.PlayerHit();
        if (game.IsPlaying)
        {
            StartCoroutine(Blink());
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Crashing into an enemy destroys it, and costs the ship a life.
        if (other.TryGetComponent(out Enemy enemy))
        {
            enemy.TakeDamage(100);
            TakeHit();
        }
    }

    IEnumerator Blink()
    {
        invulnerable = true;
        for (int i = 0; i < 10; i++)
        {
            shipRenderer.enabled = !shipRenderer.enabled;
            yield return new WaitForSeconds(0.15f);
        }
        shipRenderer.enabled = true;
        invulnerable = false;
    }

    public void ResetShip()
    {
        StopAllCoroutines();
        body.position = startPosition;
        transform.position = startPosition;
        keyboardDirection = Vector2.zero;
        followPointer = false;
        invulnerable = false;
        shipRenderer.enabled = true;
        tripleShotUntil = 0f;
        rapidFireUntil = 0f;
        shield.SetActive(false);
    }
}
