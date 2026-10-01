using UnityEngine;
using UnityEngine.UI;

// The health bar: a Filled image that slides to the knight's health, and
// fades from green to red as it empties.
public class HealthBar : MonoBehaviour
{
    [SerializeField] Image fill;
    [SerializeField] Color fullColour = new Color(0.36f, 0.82f, 0.25f);
    [SerializeField] Color emptyColour = new Color(0.9f, 0.2f, 0.2f);
    [SerializeField] float slideSpeed = 2f;     // how much of the bar it slides in a second

    float target = 1f;

    public void SetHealth(int current, int max)
    {
        target = (float)current / max;
    }

    void Update()
    {
        fill.fillAmount = Mathf.MoveTowards(fill.fillAmount, target, slideSpeed * Time.deltaTime);
        fill.color = Color.Lerp(emptyColour, fullColour, fill.fillAmount);
    }
}
