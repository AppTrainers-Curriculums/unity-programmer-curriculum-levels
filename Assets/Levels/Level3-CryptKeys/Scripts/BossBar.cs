using UnityEngine;
using UnityEngine.UI;

// The king's health bar, shown only in his tomb: a Filled image that slides
// down to his health.
public class BossBar : MonoBehaviour
{
    [SerializeField] Image fill;
    [SerializeField] float slideSpeed = 1f;     // how much of the bar it slides in a second

    float target = 1f;

    public void Show(bool isShown)
    {
        gameObject.SetActive(isShown);
    }

    public void SetHealth(int current, int max)
    {
        target = (float)current / max;
    }

    void Update()
    {
        fill.fillAmount = Mathf.MoveTowards(fill.fillAmount, target, slideSpeed * Time.deltaTime);
    }

    public void ResetBar()
    {
        target = 1f;
        fill.fillAmount = 1f;
        Show(false);
    }
}
