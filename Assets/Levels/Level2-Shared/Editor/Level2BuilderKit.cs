using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.UI;
using UnityEngine.UI;

// INSTRUCTOR TOOL: helpers shared by the three Level 2 scene builders (Mini Golf,
// Space Shooter, Tank Arena). Not part of any student book, never in a build.
public static class Level2BuilderKit
{
    // ------------------------------------------------------------ project setup

    // TMP text needs the TMP Essential Resources (fonts and settings) in the project.
    public static bool TextMeshProIsReady()
    {
        if (Resources.Load<TMP_Settings>("TMP Settings") != null)
        {
            return true;
        }

        EditorApplication.ExecuteMenuItem("Window/TextMeshPro/Import TMP Essential Resources");
        EditorUtility.DisplayDialog("Import TMP Essentials first",
            "The scene uses TextMeshPro, which needs its Essential Resources in the project.\n\n" +
            "Click 'Import' in the Import Unity Package window that opened (or use Window → TextMeshPro → " +
            "Import TMP Essential Resources), wait for the import to finish, then run Build Scene again.",
            "OK");
        return false;
    }

    public static void AddTag(string tag)
    {
        var tagManager = new SerializedObject(AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/TagManager.asset")[0]);
        SerializedProperty tags = tagManager.FindProperty("tags");
        for (int i = 0; i < tags.arraySize; i++)
        {
            if (tags.GetArrayElementAtIndex(i).stringValue == tag)
            {
                return;
            }
        }
        tags.InsertArrayElementAtIndex(tags.arraySize);
        tags.GetArrayElementAtIndex(tags.arraySize - 1).stringValue = tag;
        tagManager.ApplyModifiedPropertiesWithoutUndo();
    }

    // Returns the layer's number, adding the layer in the first free user slot if needed.
    public static int AddLayer(string layerName)
    {
        int existing = LayerMask.NameToLayer(layerName);
        if (existing >= 0)
        {
            return existing;
        }

        var tagManager = new SerializedObject(AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/TagManager.asset")[0]);
        SerializedProperty layers = tagManager.FindProperty("layers");
        for (int i = 8; i < layers.arraySize; i++)
        {
            SerializedProperty slot = layers.GetArrayElementAtIndex(i);
            if (string.IsNullOrEmpty(slot.stringValue))
            {
                slot.stringValue = layerName;
                tagManager.ApplyModifiedPropertiesWithoutUndo();
                return i;
            }
        }
        Debug.LogError("No free layer for '" + layerName + "': free one in Project Settings → Tags and Layers.");
        return 0;
    }

    public static void SetLayerRecursively(GameObject go, int layer)
    {
        go.layer = layer;
        foreach (Transform child in go.transform)
        {
            SetLayerRecursively(child.gameObject, layer);
        }
    }

    // Puts the scene first in Build Settings, ticked, so a build starts with it,
    // and drops any scene whose file has been deleted.
    public static void AddToBuildSettings(string scenePath)
    {
        var scenes = new List<EditorBuildSettingsScene>();
        scenes.Add(new EditorBuildSettingsScene(scenePath, true));
        foreach (EditorBuildSettingsScene s in EditorBuildSettings.scenes)
        {
            if (s.path != scenePath && File.Exists(s.path))
            {
                scenes.Add(s);
            }
        }
        EditorBuildSettings.scenes = scenes.ToArray();
    }

    public static void EnsureFolder(string path)
    {
        Directory.CreateDirectory(path);
    }

    // ------------------------------------------------------------ wiring

    // Sets a [SerializeField] reference, exactly as dragging it into the Inspector would.
    public static void Set(Object target, string field, Object value)
    {
        SerializedObject serialized;
        SerializedProperty property = Find(target, field, out serialized);
        if (property == null)
        {
            return;
        }
        property.objectReferenceValue = value;
        serialized.ApplyModifiedPropertiesWithoutUndo();
    }

    // Fills a [SerializeField] array or List.
    public static void SetArray(Object target, string field, params Object[] values)
    {
        SerializedObject serialized;
        SerializedProperty property = Find(target, field, out serialized);
        if (property == null)
        {
            return;
        }
        property.arraySize = values.Length;
        for (int i = 0; i < values.Length; i++)
        {
            property.GetArrayElementAtIndex(i).objectReferenceValue = values[i];
        }
        serialized.ApplyModifiedPropertiesWithoutUndo();
    }

    public static void SetFloat(Object target, string field, float value)
    {
        SerializedObject serialized;
        SerializedProperty property = Find(target, field, out serialized);
        if (property != null)
        {
            property.floatValue = value;
            serialized.ApplyModifiedPropertiesWithoutUndo();
        }
    }

    public static void SetInt(Object target, string field, int value)
    {
        SerializedObject serialized;
        SerializedProperty property = Find(target, field, out serialized);
        if (property != null)
        {
            property.intValue = value;
            serialized.ApplyModifiedPropertiesWithoutUndo();
        }
    }

    public static void SetBool(Object target, string field, bool value)
    {
        SerializedObject serialized;
        SerializedProperty property = Find(target, field, out serialized);
        if (property != null)
        {
            property.boolValue = value;
            serialized.ApplyModifiedPropertiesWithoutUndo();
        }
    }

    public static void SetString(Object target, string field, string value)
    {
        SerializedObject serialized;
        SerializedProperty property = Find(target, field, out serialized);
        if (property != null)
        {
            property.stringValue = value;
            serialized.ApplyModifiedPropertiesWithoutUndo();
        }
    }

    public static void SetVector3(Object target, string field, Vector3 value)
    {
        SerializedObject serialized;
        SerializedProperty property = Find(target, field, out serialized);
        if (property != null)
        {
            property.vector3Value = value;
            serialized.ApplyModifiedPropertiesWithoutUndo();
        }
    }

    public static void SetLayerMask(Object target, string field, params string[] layerNames)
    {
        SerializedObject serialized;
        SerializedProperty property = Find(target, field, out serialized);
        if (property != null)
        {
            property.intValue = LayerMask.GetMask(layerNames);
            serialized.ApplyModifiedPropertiesWithoutUndo();
        }
    }

    static SerializedProperty Find(Object target, string field, out SerializedObject serialized)
    {
        serialized = new SerializedObject(target);
        SerializedProperty property = serialized.FindProperty(field);
        if (property == null)
        {
            Debug.LogError("No field '" + field + "' on " + target.GetType().Name);
        }
        return property;
    }

    // ------------------------------------------------------------ assets

    public static AudioClip LoadClip(string path)
    {
        var clip = AssetDatabase.LoadAssetAtPath<AudioClip>(path);
        if (clip == null)
        {
            Debug.LogWarning("Missing sound: " + path);
        }
        return clip;
    }

    // Imports a PNG as a single sprite with the given pixels per unit and pivot.
    public static Sprite ImportSprite(string path, float pixelsPerUnit, Vector2 pivot)
    {
        var importer = (TextureImporter)AssetImporter.GetAtPath(path);
        if (importer == null)
        {
            Debug.LogError("Missing sprite: " + path);
            return null;
        }
        var settings = new TextureImporterSettings();
        importer.ReadTextureSettings(settings);
        bool changed = importer.textureType != TextureImporterType.Sprite
            || importer.spriteImportMode != SpriteImportMode.Single
            || !Mathf.Approximately(importer.spritePixelsPerUnit, pixelsPerUnit)
            || settings.spriteAlignment != (int)SpriteAlignment.Custom
            || importer.spritePivot != pivot
            || importer.mipmapEnabled;
        if (changed)
        {
            importer.textureType = TextureImporterType.Sprite;
            importer.spriteImportMode = SpriteImportMode.Single;
            importer.spritePixelsPerUnit = pixelsPerUnit;
            importer.mipmapEnabled = false;
            importer.ReadTextureSettings(settings);
            settings.spriteAlignment = (int)SpriteAlignment.Custom;
            importer.SetTextureSettings(settings);
            importer.spritePivot = pivot;
            importer.SaveAndReimport();
        }
        return AssetDatabase.LoadAssetAtPath<Sprite>(path);
    }

    // Creates or updates a material asset with the given shader and colour.
    public static Material MakeMaterial(string path, string shaderName, Color color)
    {
        Shader shader = Shader.Find(shaderName);
        if (shader == null)
        {
            Debug.LogError("Shader not found: " + shaderName);
        }
        var material = AssetDatabase.LoadAssetAtPath<Material>(path);
        if (material == null)
        {
            material = new Material(shader);
            AssetDatabase.CreateAsset(material, path);
        }
        material.shader = shader;
        if (material.HasProperty("_BaseColor"))
        {
            material.SetColor("_BaseColor", color);
        }
        if (material.HasProperty("_Color"))
        {
            material.SetColor("_Color", color);
        }
        EditorUtility.SetDirty(material);
        return material;
    }

    public static Color Hex(string hex)
    {
        ColorUtility.TryParseHtmlString(hex, out Color color);
        return color;
    }

    public static Color Hex(string hex, float alpha)
    {
        Color color = Hex(hex);
        color.a = alpha;
        return color;
    }

    // ------------------------------------------------------------ UI

    // A Screen Space Overlay canvas scaled for 1920 × 1080, and the EventSystem
    // with the Input System's UI module: what GameObject → UI (Canvas) creates.
    public static Transform MakeCanvas(string name)
    {
        var canvasObject = new GameObject(name);
        canvasObject.layer = LayerMask.NameToLayer("UI");
        var canvas = canvasObject.AddComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        var scaler = canvasObject.AddComponent<CanvasScaler>();
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        scaler.referenceResolution = new Vector2(1920f, 1080f);
        scaler.matchWidthOrHeight = 0.5f;
        canvasObject.AddComponent<GraphicRaycaster>();

        var eventSystem = new GameObject("EventSystem");
        eventSystem.AddComponent<EventSystem>();
        eventSystem.AddComponent<InputSystemUIInputModule>();
        return canvasObject.transform;
    }

    public static RectTransform MakeRect(Transform parent, string name, Vector2 anchor, Vector2 position, Vector2 size)
    {
        var go = new GameObject(name, typeof(RectTransform));
        go.layer = LayerMask.NameToLayer("UI");
        go.transform.SetParent(parent, false);
        var rect = (RectTransform)go.transform;
        rect.anchorMin = anchor;
        rect.anchorMax = anchor;
        rect.pivot = anchor;
        rect.anchoredPosition = position;
        rect.sizeDelta = size;
        return rect;
    }

    // A rectangle that fills its parent.
    public static RectTransform MakeStretch(Transform parent, string name)
    {
        RectTransform rect = MakeRect(parent, name, new Vector2(0.5f, 0.5f), Vector2.zero, Vector2.zero);
        rect.anchorMin = Vector2.zero;
        rect.anchorMax = Vector2.one;
        rect.sizeDelta = Vector2.zero;
        return rect;
    }

    public static TMP_Text MakeText(Transform parent, string name, string text, float fontSize,
                                    TextAlignmentOptions alignment, Vector2 anchor, Vector2 position,
                                    Vector2 size, Color color)
    {
        RectTransform rect = MakeRect(parent, name, anchor, position, size);
        var tmp = rect.gameObject.AddComponent<TextMeshProUGUI>();
        tmp.text = text;
        tmp.fontSize = fontSize;
        tmp.alignment = alignment;
        tmp.color = color;
        tmp.raycastTarget = false;    // only there to be read: presses go through to the game
        return tmp;
    }

    public static Image MakeImage(Transform parent, string name, Color color, Vector2 anchor, Vector2 position, Vector2 size)
    {
        RectTransform rect = MakeRect(parent, name, anchor, position, size);
        var image = rect.gameObject.AddComponent<Image>();
        image.color = color;
        image.raycastTarget = false;  // only there to be seen: presses go through to the game
        return image;
    }

    public static DefaultControls.Resources UiResources()
    {
        var resources = new DefaultControls.Resources();
        resources.standard = AssetDatabase.GetBuiltinExtraResource<Sprite>("UI/Skin/UISprite.psd");
        resources.background = AssetDatabase.GetBuiltinExtraResource<Sprite>("UI/Skin/Background.psd");
        resources.inputField = AssetDatabase.GetBuiltinExtraResource<Sprite>("UI/Skin/InputFieldBackground.psd");
        resources.knob = AssetDatabase.GetBuiltinExtraResource<Sprite>("UI/Skin/Knob.psd");
        resources.checkmark = AssetDatabase.GetBuiltinExtraResource<Sprite>("UI/Skin/Checkmark.psd");
        resources.dropdown = AssetDatabase.GetBuiltinExtraResource<Sprite>("UI/Skin/DropdownArrow.psd");
        resources.mask = AssetDatabase.GetBuiltinExtraResource<Sprite>("UI/Skin/UIMask.psd");
        return resources;
    }

    static TMP_DefaultControls.Resources TmpResources()
    {
        DefaultControls.Resources ui = UiResources();
        var resources = new TMP_DefaultControls.Resources();
        resources.standard = ui.standard;
        resources.background = ui.background;
        resources.inputField = ui.inputField;
        resources.knob = ui.knob;
        resources.checkmark = ui.checkmark;
        resources.dropdown = ui.dropdown;
        resources.mask = ui.mask;
        return resources;
    }

    static RectTransform Place(GameObject go, Transform parent, string name, Vector2 position)
    {
        go.name = name;
        go.transform.SetParent(parent, false);
        SetLayerRecursively(go, LayerMask.NameToLayer("UI"));
        var rect = (RectTransform)go.transform;
        rect.anchoredPosition = position;
        return rect;
    }

    // The same controls GameObject → UI (Canvas) creates, at their default sizes.
    // Put them in a scaled window to make them bigger (see MakeWindow).
    public static Button MakeButton(Transform parent, string name, string label, Vector2 position, Vector2 size, Color color)
    {
        GameObject go = TMP_DefaultControls.CreateButton(TmpResources());
        RectTransform rect = Place(go, parent, name, position);
        rect.sizeDelta = size;
        go.GetComponent<Image>().color = color;
        TMP_Text text = go.GetComponentInChildren<TMP_Text>();
        text.text = label;
        text.fontSize = size.y * 0.5f;
        return go.GetComponent<Button>();
    }

    public static Slider MakeSlider(Transform parent, string name, Vector2 position, float width)
    {
        GameObject go = DefaultControls.CreateSlider(UiResources());
        RectTransform rect = Place(go, parent, name, position);
        rect.sizeDelta = new Vector2(width, rect.sizeDelta.y);
        return go.GetComponent<Slider>();
    }

    public static Toggle MakeToggle(Transform parent, string name, string label, Vector2 position)
    {
        GameObject go = DefaultControls.CreateToggle(UiResources());
        Place(go, parent, name, position);
        Text text = go.GetComponentInChildren<Text>();
        text.text = label;
        text.color = Color.white;
        return go.GetComponent<Toggle>();
    }

    public static TMP_InputField MakeInputField(Transform parent, string name, string placeholder, Vector2 position, float width)
    {
        GameObject go = TMP_DefaultControls.CreateInputField(TmpResources());
        RectTransform rect = Place(go, parent, name, position);
        rect.sizeDelta = new Vector2(width, rect.sizeDelta.y);
        var input = go.GetComponent<TMP_InputField>();
        ((TMP_Text)input.placeholder).text = placeholder;
        input.characterLimit = 12;
        return input;
    }

    public static TMP_Dropdown MakeDropdown(Transform parent, string name, Vector2 position, float width, params string[] options)
    {
        GameObject go = TMP_DefaultControls.CreateDropdown(TmpResources());
        RectTransform rect = Place(go, parent, name, position);
        rect.sizeDelta = new Vector2(width, rect.sizeDelta.y);
        var dropdown = go.GetComponent<TMP_Dropdown>();
        dropdown.ClearOptions();
        dropdown.AddOptions(new List<string>(options));
        dropdown.value = 0;
        dropdown.RefreshShownValue();
        return dropdown;
    }

    // A dimmed full-screen panel holding a window. The window is scaled up so the
    // default-sized controls inside it read well on a 1920 × 1080 canvas.
    public static RectTransform MakeWindow(Transform parent, string panelName, Vector2 windowSize, float scale,
                                           Color windowColor, out GameObject panel)
    {
        RectTransform dim = MakeStretch(parent, panelName);
        dim.gameObject.AddComponent<Image>().color = new Color(0f, 0f, 0f, 0.55f);
        panel = dim.gameObject;

        Image window = MakeImage(dim, "Window", windowColor, new Vector2(0.5f, 0.5f), Vector2.zero, windowSize);
        window.sprite = AssetDatabase.GetBuiltinExtraResource<Sprite>("UI/Skin/UISprite.psd");
        window.type = Image.Type.Sliced;
        window.rectTransform.localScale = new Vector3(scale, scale, 1f);
        return window.rectTransform;
    }

    public static void SaveScene(UnityEngine.SceneManagement.Scene scene, string path)
    {
        EditorSceneManager.SaveScene(scene, path);
        AddToBuildSettings(path);
    }
}
