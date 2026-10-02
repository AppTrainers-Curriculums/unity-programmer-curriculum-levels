using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The build menu: three buttons, one per tower, over the plot that was
// tapped. Camera.WorldToScreenPoint turns the plot's place in the world into
// a place on the screen. A tower the player can't afford has its button's
// interactable switched off, so it shows its Disabled picture.
public class BuildMenu : MonoBehaviour
{
    [SerializeField] Bank bank;
    [SerializeField] Tower[] towerPrefabs;      // Arrow, Catapult, Frost
    [SerializeField] Button[] buttons;          // in the same order
    [SerializeField] TMP_Text[] priceTexts;
    [SerializeField] float heightAbovePlot = 1.5f;

    BuildPlot plot;
    Camera cam;

    public bool IsOpen
    {
        get { return gameObject.activeSelf; }
    }

    void Awake()
    {
        cam = Camera.main;
    }

    // Each button needs its own method to call: buttons[0] builds an Arrow
    // tower, buttons[1] a Catapult, buttons[2] a Frost tower.
    void OnEnable()
    {
        buttons[0].onClick.AddListener(BuildArrow);
        buttons[1].onClick.AddListener(BuildCatapult);
        buttons[2].onClick.AddListener(BuildFrost);
    }

    void OnDisable()
    {
        buttons[0].onClick.RemoveListener(BuildArrow);
        buttons[1].onClick.RemoveListener(BuildCatapult);
        buttons[2].onClick.RemoveListener(BuildFrost);
    }

    // While it's open, it stays over its plot, and the buttons keep up with
    // the gold: a bounty can make a tower affordable.
    void Update()
    {
        if (plot == null)
        {
            return;
        }
        PlaceOver(plot.transform.position);
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = bank.CanAfford(towerPrefabs[i].BuildCost);
        }
    }

    public void Open(BuildPlot target)
    {
        plot = target;
        gameObject.SetActive(true);
        for (int i = 0; i < priceTexts.Length; i++)
        {
            priceTexts[i].text = towerPrefabs[i].BuildCost.ToString();
        }
        Update();
    }

    public void Close()
    {
        plot = null;
        gameObject.SetActive(false);
    }

    void BuildArrow()
    {
        Build(0);
    }

    void BuildCatapult()
    {
        Build(1);
    }

    void BuildFrost()
    {
        Build(2);
    }

    void Build(int index)
    {
        if (plot != null && bank.Spend(towerPrefabs[index].BuildCost))
        {
            plot.Build(towerPrefabs[index]);
        }
        Close();
    }

    // The menu's pivot is the middle of its bottom edge: that point goes over
    // the plot, then the menu is kept inside the screen.
    void PlaceOver(Vector3 worldPoint)
    {
        Vector3 screenPoint = cam.WorldToScreenPoint(worldPoint + Vector3.up * heightAbovePlot);
        RectTransform rect = (RectTransform)transform;
        Vector2 size = rect.rect.size * rect.lossyScale;
        screenPoint.x = Mathf.Clamp(screenPoint.x, size.x / 2f, Screen.width - size.x / 2f);
        screenPoint.y = Mathf.Clamp(screenPoint.y, 0f, Screen.height - size.y);
        rect.position = screenPoint;
    }
}
