using UnityEngine;
using UnityEngine.UI;

// A health bar that floats over a skeleton, on a World Space Canvas. A canvas
// in the world turns with whatever holds it, so every frame, after the
// skeleton has moved and turned, the bar turns back to face the camera.
public class EnemyHealthBar : MonoBehaviour
{
    [SerializeField] Image fill;

    Transform cameraTransform;

    void Awake()
    {
        cameraTransform = Camera.main.transform;
    }

    void LateUpdate()
    {
        transform.rotation = cameraTransform.rotation;
    }

    // fraction is 1 at full health, 0.5 at half.
    public void Show(float fraction)
    {
        gameObject.SetActive(true);
        fill.fillAmount = fraction;
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
