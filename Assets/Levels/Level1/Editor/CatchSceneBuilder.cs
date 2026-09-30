using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEditor;
using UnityEditor.Events;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.UI;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

// INSTRUCTOR TOOL: not part of the student workbook, and never shipped in a build.
// Menu: Tools → Catch the Falling Blocks (Level 1) → Build Scene
//
// Rebuilds Assets/Levels/Level1/Scenes/Catch.unity exactly as the Level 1 workbook
// describes it: the three block tags, the Square sprite, the Block / GoldBlock /
// BadBlock prefabs, the player, floor, spawner, game manager and UI, with every
// Inspector reference wired up. Use it to prepare lab machines or to reset a
// broken scene. Running it again overwrites the scene and the prefabs.
public static class CatchSceneBuilder
{
    const string Root = "Assets/Levels/Level1";
    const string ScenePath = Root + "/Scenes/Catch.unity";
    const string SpriteFolder = Root + "/Sprites";
    const string PrefabFolder = Root + "/Prefabs";
    const string AudioFolder = Root + "/Audio";

    static readonly string[] BlockTags = { "Block", "GoldBlock", "BadBlock" };

    [MenuItem("Tools/Catch the Falling Blocks (Level 1)/Build Scene")]
    public static void Build()
    {
        if (!TextMeshProIsReady())
        {
            return;
        }
        if (!EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            return;
        }

        foreach (string tag in BlockTags)
        {
            AddTag(tag);
        }

        Directory.CreateDirectory(Root + "/Scenes");
        var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);

        Sprite square = MakeSquareSprite();

        // ---- The three block prefabs (Chapter 3 and 4) ----
        GameObject block = MakeBlockPrefab("Block", square, "#FF4D6D", 0.5f);
        GameObject goldBlock = MakeBlockPrefab("GoldBlock", square, "#FFD166", 0.9f);
        GameObject badBlock = MakeBlockPrefab("BadBlock", square, "#9B5DE5", 0.35f);

        // ---- Camera: orthographic, Size 6, dark navy background (Chapter 1) ----
        var cameraObject = new GameObject("Main Camera");
        cameraObject.tag = "MainCamera";
        cameraObject.transform.position = new Vector3(0f, 0f, -10f);
        var camera = cameraObject.AddComponent<Camera>();
        camera.orthographic = true;
        camera.orthographicSize = 6f;
        camera.clearFlags = CameraClearFlags.SolidColor;
        camera.backgroundColor = Hex("#1E1A33");
        camera.nearClipPlane = 0.3f;
        camera.farClipPlane = 1000f;
        cameraObject.AddComponent<AudioListener>();

        // ---- Light: without a 2D light, URP 2D sprites render black ----
        var lightObject = new GameObject("Global Light 2D");
        var light = lightObject.AddComponent<Light2D>();
        light.lightType = Light2D.LightType.Global;

        // ---- Player (Chapter 2) ----
        GameObject player = SpriteObject("Player", square, new Vector3(0f, -4.5f, 0f),
                                         new Vector3(2.4f, 0.4f, 1f), "#3DDCC8", 0);
        player.tag = "Player";
        player.AddComponent<BoxCollider2D>();
        var playerController = player.AddComponent<PlayerController>();

        // ---- Floor: an invisible solid collider below the screen (Chapter 7) ----
        var floor = new GameObject("Floor");
        floor.transform.position = new Vector3(0f, -7.5f, 0f);
        floor.transform.localScale = new Vector3(30f, 1f, 1f);
        floor.AddComponent<BoxCollider2D>();
        var floorScript = floor.AddComponent<Floor>();

        // ---- Spawner (Chapter 5) ----
        var spawnerObject = new GameObject("Spawner");
        var spawner = spawnerObject.AddComponent<Spawner>();

        // ---- Game manager, with its audio source (Chapters 6 and 10) ----
        var managerObject = new GameObject("GameManager");
        var gameManager = managerObject.AddComponent<GameManager>();
        var audioSource = managerObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;

        // ---- UI (Chapter 8) ----
        var canvasObject = new GameObject("Canvas");
        var canvas = canvasObject.AddComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        var scaler = canvasObject.AddComponent<CanvasScaler>();
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        scaler.referenceResolution = new Vector2(1920f, 1080f);
        scaler.matchWidthOrHeight = 0.5f;
        canvasObject.AddComponent<GraphicRaycaster>();
        Transform ui = canvasObject.transform;

        var eventSystem = new GameObject("EventSystem");
        eventSystem.AddComponent<EventSystem>();
        eventSystem.AddComponent<InputSystemUIInputModule>();

        TMP_Text scoreText = MakeText(ui, "ScoreText", "Score: 0", 56f, TextAlignmentOptions.TopLeft,
                                      new Vector2(0f, 1f), new Vector2(40f, -30f), new Vector2(600f, 100f));
        TMP_Text messageText = MakeText(ui, "MessageText", "Catch the Falling Blocks", 64f, TextAlignmentOptions.Center,
                                        new Vector2(0.5f, 0.5f), new Vector2(0f, 140f), new Vector2(1600f, 360f));
        Button playButton = MakeButton(ui, "PlayButton", "Play", new Vector2(0f, -140f), new Vector2(320f, 110f));

        // Life icons in the top-right corner: LifeIcon1 on the left, LifeIcon3 on the right
        var lifeIcons = new GameObject[3];
        for (int i = 0; i < lifeIcons.Length; i++)
        {
            float x = -40f - (lifeIcons.Length - 1 - i) * 70f;
            lifeIcons[i] = MakeImage(ui, "LifeIcon" + (i + 1), "#FF4D6D",
                                     new Vector2(1f, 1f), new Vector2(x, -40f), new Vector2(50f, 50f));
        }

        // ---- Wire up every Inspector reference ----
        Set(playerController, "gameManager", gameManager);
        Set(floorScript, "gameManager", gameManager);
        Set(spawner, "gameManager", gameManager);
        // Four red blocks, one gold, two bad: red is the most common
        SetArray(spawner, "blockPrefabs", block, block, block, block, goldBlock, badBlock, badBlock);

        Set(gameManager, "spawner", spawner);
        Set(gameManager, "scoreText", scoreText);
        Set(gameManager, "messageText", messageText);
        Set(gameManager, "playButton", playButton.gameObject);
        SetArray(gameManager, "lifeIcons", lifeIcons);
        Set(gameManager, "audioSource", audioSource);
        Set(gameManager, "catchSound", LoadClip("Catch"));
        Set(gameManager, "goldSound", LoadClip("Gold"));
        Set(gameManager, "missSound", LoadClip("Miss"));
        Set(gameManager, "gameOverSound", LoadClip("GameOver"));

        // The Play button's On Click () calls GameManager.StartGame (Chapter 8)
        UnityEventTools.AddPersistentListener(playButton.onClick, gameManager.StartGame);

        EditorSceneManager.SaveScene(scene, ScenePath);
        AddToBuildSettings(ScenePath);

        Debug.Log("Catch the Falling Blocks scene built: " + ScenePath);
    }

    // ------------------------------------------------------------------ helpers

    // TMP text needs the TMP Essential Resources (fonts and settings) in the project.
    static bool TextMeshProIsReady()
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

    static void AddTag(string tag)
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

    static GameObject MakeBlockPrefab(string name, Sprite sprite, string colorHex, float gravityScale)
    {
        Directory.CreateDirectory(PrefabFolder);

        GameObject go = SpriteObject(name, sprite, Vector3.zero, new Vector3(0.6f, 0.6f, 1f), colorHex, 1);
        go.tag = name;

        var collider = go.AddComponent<BoxCollider2D>();
        collider.isTrigger = true;

        // Gravity pulls the block down; damping (air resistance) stops it speeding up forever
        var body = go.AddComponent<Rigidbody2D>();
        body.gravityScale = gravityScale;
        body.linearDamping = 1f;

        GameObject prefab = PrefabUtility.SaveAsPrefabAsset(go, PrefabFolder + "/" + name + ".prefab");
        Object.DestroyImmediate(go);
        return prefab;
    }

    static GameObject SpriteObject(string name, Sprite sprite, Vector3 position, Vector3 scale,
                                   string colorHex, int orderInLayer)
    {
        var go = new GameObject(name);
        go.transform.position = position;
        go.transform.localScale = scale;

        var renderer = go.AddComponent<SpriteRenderer>();
        renderer.sprite = sprite;
        renderer.color = Hex(colorHex);
        renderer.sortingOrder = orderInLayer;
        return go;
    }

    static RectTransform MakeRect(Transform parent, string name, Vector2 anchor, Vector2 position, Vector2 size)
    {
        var go = new GameObject(name, typeof(RectTransform));
        go.transform.SetParent(parent, false);

        var rect = (RectTransform)go.transform;
        rect.anchorMin = anchor;
        rect.anchorMax = anchor;
        rect.pivot = anchor;
        rect.anchoredPosition = position;
        rect.sizeDelta = size;
        return rect;
    }

    static TMP_Text MakeText(Transform parent, string name, string text, float fontSize,
                             TextAlignmentOptions alignment, Vector2 anchor, Vector2 position, Vector2 size)
    {
        RectTransform rect = MakeRect(parent, name, anchor, position, size);
        var tmp = rect.gameObject.AddComponent<TextMeshProUGUI>();
        tmp.text = text;
        tmp.fontSize = fontSize;
        tmp.alignment = alignment;
        tmp.color = Hex("#F5F3FF");
        return tmp;
    }

    static Button MakeButton(Transform parent, string name, string label, Vector2 position, Vector2 size)
    {
        RectTransform rect = MakeRect(parent, name, new Vector2(0.5f, 0.5f), position, size);
        var image = rect.gameObject.AddComponent<Image>();
        image.color = Hex("#3DDCC8");
        var button = rect.gameObject.AddComponent<Button>();

        TMP_Text text = MakeText(rect, "Text (TMP)", label, 56f, TextAlignmentOptions.Center,
                                 new Vector2(0.5f, 0.5f), Vector2.zero, size);
        text.color = Hex("#1E1A33");
        return button;
    }

    static GameObject MakeImage(Transform parent, string name, string colorHex,
                                Vector2 anchor, Vector2 position, Vector2 size)
    {
        RectTransform rect = MakeRect(parent, name, anchor, position, size);
        var image = rect.gameObject.AddComponent<Image>();
        image.color = Hex(colorHex);
        return rect.gameObject;
    }

    // Sets a [SerializeField] reference, exactly as dragging it into the Inspector would
    static void Set(Object target, string field, Object value)
    {
        var serialized = new SerializedObject(target);
        SerializedProperty property = serialized.FindProperty(field);
        if (property == null)
        {
            Debug.LogError("No field '" + field + "' on " + target.GetType().Name);
            return;
        }
        property.objectReferenceValue = value;
        serialized.ApplyModifiedPropertiesWithoutUndo();
    }

    static void SetArray(Object target, string field, params Object[] values)
    {
        var serialized = new SerializedObject(target);
        SerializedProperty property = serialized.FindProperty(field);
        if (property == null)
        {
            Debug.LogError("No field '" + field + "' on " + target.GetType().Name);
            return;
        }
        property.arraySize = values.Length;
        for (int i = 0; i < values.Length; i++)
        {
            property.GetArrayElementAtIndex(i).objectReferenceValue = values[i];
        }
        serialized.ApplyModifiedPropertiesWithoutUndo();
    }

    static AudioClip LoadClip(string name)
    {
        var clip = AssetDatabase.LoadAssetAtPath<AudioClip>(AudioFolder + "/" + name + ".wav");
        if (clip == null)
        {
            Debug.LogWarning("Missing sound: " + AudioFolder + "/" + name + ".wav");
        }
        return clip;
    }

    // Creates (once) a white 256×256 PNG imported as a 1-unit sprite: the same
    // white square GameObject → 2D Object → Sprites → Square gives students.
    static Sprite MakeSquareSprite()
    {
        string path = SpriteFolder + "/Square.png";

        if (!File.Exists(path))
        {
            Directory.CreateDirectory(SpriteFolder);
            const int size = 256;
            var texture = new Texture2D(size, size, TextureFormat.RGBA32, false);
            var pixels = new Color32[size * size];
            for (int i = 0; i < pixels.Length; i++)
            {
                pixels[i] = new Color32(255, 255, 255, 255);
            }
            texture.SetPixels32(pixels);

            File.WriteAllBytes(path, texture.EncodeToPNG());
            Object.DestroyImmediate(texture);
            AssetDatabase.ImportAsset(path);

            var importer = (TextureImporter)AssetImporter.GetAtPath(path);
            importer.textureType = TextureImporterType.Sprite;
            importer.spriteImportMode = SpriteImportMode.Single;
            importer.spritePixelsPerUnit = size;
            importer.mipmapEnabled = false;
            importer.SaveAndReimport();
        }

        return AssetDatabase.LoadAssetAtPath<Sprite>(path);
    }

    static void AddToBuildSettings(string scenePath)
    {
        var scenes = new List<EditorBuildSettingsScene>(EditorBuildSettings.scenes);
        foreach (EditorBuildSettingsScene s in scenes)
        {
            if (s.path == scenePath)
            {
                return;
            }
        }
        scenes.Add(new EditorBuildSettingsScene(scenePath, true));
        EditorBuildSettings.scenes = scenes.ToArray();
    }

    static Color Hex(string hex)
    {
        ColorUtility.TryParseHtmlString(hex, out Color color);
        return color;
    }
}
