using UnityEngine;

// Spins an object around its own axes, for ever: the windmill's blades.
public class Spinner : MonoBehaviour
{
    [SerializeField] Vector3 degreesPerSecond = new Vector3(0f, 0f, 90f);

    void Update()
    {
        transform.Rotate(degreesPerSecond * Time.deltaTime);
    }
}
