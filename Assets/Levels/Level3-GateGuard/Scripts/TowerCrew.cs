using UnityEngine;

// Sits beside a tower crew's Animator: on the archer, the mage, or the
// catapult. An Animation Event only reaches scripts on the Animator's own
// GameObject, and the Tower script is on the tower, so this passes the event
// on. Without it, the Console says OnRelease has no receiver.
public class TowerCrew : MonoBehaviour
{
    [SerializeField] Tower tower;

    // Animation Event: the frame the shot leaves.
    public void OnRelease()
    {
        tower.Release();
    }
}
