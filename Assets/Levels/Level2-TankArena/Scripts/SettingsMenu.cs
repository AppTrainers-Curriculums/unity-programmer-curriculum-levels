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
    [SerializeField] TMP_Dropdown colourDropdown;
    [SerializeField] Button closeButton;
    [SerializeField] ArenaGame game;
    [SerializeField] CameraFollow cameraFollow;
    [SerializeField] SpriteRenderer bodyRenderer;
    [SerializeField] SpriteRenderer barrelRenderer;
    [SerializeField] Sprite[] bodySprites;        // in the same order as the dropdown's options
    [SerializeField] Sprite[] barrelSprites;      // the same colours, in the same order

    void OnEnable()
    {
        // Show the current values, without calling the listeners.
        volumeSlider.SetValueWithoutNotify(AudioListener.volume);
        shakeToggle.SetIsOnWithoutNotify(cameraFollow.ShakeEnabled);
        nameInput.SetTextWithoutNotify(game.CommanderName);

        volumeSlider.onValueChanged.AddListener(OnVolumeChanged);
        shakeToggle.onValueChanged.AddListener(OnShakeToggled);
        nameInput.onEndEdit.AddListener(OnNameEntered);
        colourDropdown.onValueChanged.AddListener(OnColourChosen);
        closeButton.onClick.AddListener(Close);

        Time.timeScale = 0f;
    }

    void OnDisable()
    {
        volumeSlider.onValueChanged.RemoveListener(OnVolumeChanged);
        shakeToggle.onValueChanged.RemoveListener(OnShakeToggled);
        nameInput.onEndEdit.RemoveListener(OnNameEntered);
        colourDropdown.onValueChanged.RemoveListener(OnColourChosen);
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
        cameraFollow.ShakeEnabled = isOn;
    }

    void OnNameEntered(string text)
    {
        if (text.Trim() != "")
        {
            game.CommanderName = text.Trim();
        }
    }

    void OnColourChosen(int index)
    {
        bodyRenderer.sprite = bodySprites[index];
        barrelRenderer.sprite = barrelSprites[index];
    }
}
