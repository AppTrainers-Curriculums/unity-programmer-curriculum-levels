using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The settings panel. Its controls are connected with AddListener when the
// panel opens (OnEnable), and disconnected when it closes (OnDisable). The
// game is paused while it's open.
public class SettingsMenu : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] Toggle aimLineToggle;
    [SerializeField] TMP_InputField nameInput;
    [SerializeField] TMP_Dropdown ballDropdown;
    [SerializeField] Button closeButton;
    [SerializeField] ShotAimer aimer;
    [SerializeField] GolfGame game;
    [SerializeField] MeshFilter ballModel;
    [SerializeField] Mesh[] ballMeshes;     // in the same order as the dropdown's options

    void OnEnable()
    {
        // Show the current values, without calling the listeners.
        volumeSlider.SetValueWithoutNotify(AudioListener.volume);
        aimLineToggle.SetIsOnWithoutNotify(aimer.ShowAimLine);
        nameInput.SetTextWithoutNotify(game.PlayerName);

        volumeSlider.onValueChanged.AddListener(OnVolumeChanged);
        aimLineToggle.onValueChanged.AddListener(OnAimLineToggled);
        nameInput.onEndEdit.AddListener(OnNameEntered);
        ballDropdown.onValueChanged.AddListener(OnBallChosen);
        closeButton.onClick.AddListener(Close);

        aimer.CancelAim();
        Time.timeScale = 0f;
    }

    void OnDisable()
    {
        volumeSlider.onValueChanged.RemoveListener(OnVolumeChanged);
        aimLineToggle.onValueChanged.RemoveListener(OnAimLineToggled);
        nameInput.onEndEdit.RemoveListener(OnNameEntered);
        ballDropdown.onValueChanged.RemoveListener(OnBallChosen);
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

    void OnAimLineToggled(bool isOn)
    {
        aimer.ShowAimLine = isOn;
    }

    void OnNameEntered(string text)
    {
        if (text.Trim() != "")
        {
            game.PlayerName = text.Trim();
        }
    }

    void OnBallChosen(int index)
    {
        ballModel.sharedMesh = ballMeshes[index];
    }
}
