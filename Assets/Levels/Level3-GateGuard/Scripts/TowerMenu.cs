using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The tower menu, over a tower that was tapped: its name, its level as
// stars, Upgrade and Sell. While it's open, the tower's range shows as a
// ring on the ground.
public class TowerMenu : MonoBehaviour
{
    [SerializeField] Bank bank;
    [SerializeField] RangeRing rangeRing;
    [SerializeField] TMP_Text titleText;
    [SerializeField] Image[] stars;             // three, one per level
    [SerializeField] Button upgradeButton;
    [SerializeField] TMP_Text upgradeText;
    [SerializeField] Button sellButton;
    [SerializeField] TMP_Text sellText;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip sellSound;
    [SerializeField] float heightAbovePlot = 3.2f;

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

    void OnEnable()
    {
        upgradeButton.onClick.AddListener(Upgrade);
        sellButton.onClick.AddListener(Sell);
    }

    void OnDisable()
    {
        upgradeButton.onClick.RemoveListener(Upgrade);
        sellButton.onClick.RemoveListener(Sell);
    }

    void Update()
    {
        if (plot == null)
        {
            return;
        }
        PlaceOver(plot.transform.position);
        Tower tower = plot.Tower;
        upgradeButton.interactable = tower.CanUpgrade && bank.CanAfford(tower.UpgradeCost);
    }

    public void Open(BuildPlot target)
    {
        plot = target;
        gameObject.SetActive(true);
        Refresh();
        Update();
    }

    public void Close()
    {
        plot = null;
        rangeRing.Hide();
        gameObject.SetActive(false);
    }

    void Refresh()
    {
        Tower tower = plot.Tower;
        titleText.text = tower.Title;
        for (int i = 0; i < stars.Length; i++)
        {
            stars[i].enabled = i < tower.Level;
        }
        upgradeText.text = tower.CanUpgrade ? tower.UpgradeCost.ToString() : "Max";
        sellText.text = $"Sell {tower.SellValue}";
        rangeRing.Show(tower.transform.position, tower.Current.Range);
    }

    void Upgrade()
    {
        Tower tower = plot.Tower;
        if (tower.CanUpgrade && bank.Spend(tower.UpgradeCost))
        {
            tower.Upgrade();
            Refresh();
        }
    }

    void Sell()
    {
        bank.Earn(plot.Tower.SellValue);
        audioSource.PlayOneShot(sellSound);
        plot.Clear();
        Close();
    }

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
