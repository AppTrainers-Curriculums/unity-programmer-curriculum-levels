using UnityEngine;
using UnityEngine.UI;

// The hero's three hearts. His health is counted in half hearts, so
// health / 2 is how many hearts are full, and health % 2, what's left over,
// is 1 when a half heart comes after them.
public class HeartsBar : MonoBehaviour
{
    [SerializeField] Image[] hearts;
    [SerializeField] Sprite fullHeart;
    [SerializeField] Sprite halfHeart;
    [SerializeField] Sprite emptyHeart;

    public void SetHealth(int health)
    {
        int full = health / 2;
        bool hasHalf = health % 2 == 1;
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < full)
            {
                hearts[i].sprite = fullHeart;
            }
            else if (i == full && hasHalf)
            {
                hearts[i].sprite = halfHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
        }
    }
}
