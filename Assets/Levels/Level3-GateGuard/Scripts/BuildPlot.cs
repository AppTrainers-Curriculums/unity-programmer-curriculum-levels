using UnityEngine;

// A dirt plot beside the road, where a tower can stand. Its Box Collider, on
// the Plot layer, is what the Picker's ray hits.
public class BuildPlot : MonoBehaviour
{
    [SerializeField] GateGame game;
    [SerializeField] Transform towerGroup;      // every tower goes here
    [SerializeField] Transform shotGroup;       // and every tower's shots here

    Tower tower;

    public Tower Tower
    {
        get { return tower; }
    }

    public bool IsEmpty
    {
        get { return tower == null; }
    }

    public void Build(Tower towerPrefab)
    {
        tower = Instantiate(towerPrefab, transform.position, Quaternion.identity, towerGroup);
        tower.Build(game, shotGroup);
    }

    // Sold, or on Restart: the plot is empty again.
    public void Clear()
    {
        if (tower != null)
        {
            Destroy(tower.gameObject);
        }
        tower = null;
    }
}
