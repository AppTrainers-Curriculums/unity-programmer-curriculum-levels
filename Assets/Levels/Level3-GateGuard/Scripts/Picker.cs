using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

// Works out what the player tapped or clicked. A press that isn't on the UI
// casts a ray from the camera through the pointer: if it hits a plot, the
// build menu opens over an empty one, and the tower menu over a tower.
// Anywhere else closes them.
public class Picker : MonoBehaviour
{
    [SerializeField] GateGame game;
    [SerializeField] LayerMask plotMask;
    [SerializeField] BuildMenu buildMenu;
    [SerializeField] TowerMenu towerMenu;

    Camera cam;

    public bool HasMenuOpen
    {
        get { return buildMenu.IsOpen || towerMenu.IsOpen; }
    }

    void Awake()
    {
        cam = Camera.main;
    }

    void Update()
    {
        Pointer pointer = Pointer.current;
        if (!game.IsPlaying || pointer == null || !pointer.press.wasPressedThisFrame)
        {
            return;
        }
        // A press on a button belongs to the button.
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        Ray ray = cam.ScreenPointToRay(pointer.position.ReadValue());
        if (Physics.Raycast(ray, out RaycastHit hit, 200f, plotMask) && hit.collider.TryGetComponent(out BuildPlot plot))
        {
            if (plot.IsEmpty)
            {
                towerMenu.Close();
                buildMenu.Open(plot);
            }
            else
            {
                buildMenu.Close();
                towerMenu.Open(plot);
            }
        }
        else
        {
            CloseMenus();
        }
    }

    public void CloseMenus()
    {
        buildMenu.Close();
        towerMenu.Close();
    }
}
