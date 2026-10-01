using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The settings panel. Its controls are connected with AddListener when the
// panel opens (OnEnable), and disconnected when it closes (OnDisable). The
// game is paused while it's open.
public class SettingsMenu : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] Toggle shakeToggle;
    [SerializeField] TMP_InputField nameInput;
    [SerializeField] TMP_Dropdown shipDropdown;
    [SerializeField] Button closeButton;
    [SerializeField] ShooterGame game;
    [SerializeField] CameraShake cameraShake;
    [SerializeField] SpriteRenderer shipRenderer;
    [SerializeField] Sprite[] shipSprites;      // in the same order as the dropdown's options
    [SerializeField] Image[] lifeIcons;
    [SerializeField] Sprite[] lifeSprites;      // the same colours, in the same order

    void OnEnable()
    {
        // Show the current values, without calling the listeners.
        volumeSlider.SetValueWithoutNotify(AudioListener.volume);
        shakeToggle.SetIsOnWithoutNotify(cameraShake.enabled);
        nameInput.SetTextWithoutNotify(game.PilotName);

        volumeSlider.onValueChanged.AddListener(OnVolumeChanged);
        shakeToggle.onValueChanged.AddListener(OnShakeToggled);
        nameInput.onEndEdit.AddListener(OnNameEntered);
        shipDropdown.onValueChanged.AddListener(OnShipChosen);
        closeButton.onClick.AddListener(Close);

        Time.timeScale = 0f;
    }

    void OnDisable()
    {
        volumeSlider.onValueChanged.RemoveListener(OnVolumeChanged);
        shakeToggle.onValueChanged.RemoveListener(OnShakeToggled);
        nameInput.onEndEdit.RemoveListener(OnNameEntered);
        shipDropdown.onValueChanged.RemoveListener(OnShipChosen);
        closeButton.onClick.RemoveListener(Close);

        Time.timeScale = 1f;
    }

    void Close()
    {
        gameObject.SetActive(false);
    }

    void OnVolumeChanged(float value)
    {
        AudioListener.volume = value;
    }

    void OnShakeToggled(bool isOn)
    {
        cameraShake.enabled = isOn;
    }

    void OnNameEntered(string text)
    {
        if (text.Trim() != "")
        {
            game.PilotName = text.Trim();
        }
    }

    void OnShipChosen(int index)
    {
        shipRenderer.sprite = shipSprites[index];
        foreach (Image icon in lifeIcons)
        {
            icon.sprite = lifeSprites[index];
        }
    }
}
