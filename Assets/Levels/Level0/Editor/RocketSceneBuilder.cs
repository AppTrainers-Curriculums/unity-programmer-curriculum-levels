using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.Rendering.Universal;

// INSTRUCTOR TOOL: not part of the student workbook, and never shipped in a build.
// Menu: Tools → Rocket Launch (Level 0) → Build Scene
//
// Rebuilds Assets/Levels/Level0/Scenes/Launch.unity exactly as Chapter 2 of the
// Level 0 workbook describes it: same object names, transforms, colours and
// sorting orders, with both game scripts attached. Use it to prepare lab machines
// or to reset a broken scene. Running it again overwrites the scene.
public static class RocketSceneBuilder
{
    const string Root = "Assets/Levels/Level0";
    const string ScenePath = Root + "/Scenes/Launch.unity";
    const string SpriteFolder = Root + "/Sprites";

    [MenuItem("Tools/Rocket Launch (Level 0)/Build Scene")]
    public static void Build()
    {
        if (!EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            return;
        }

        // Plain white shapes, 1 unit across, tinted by each Sprite Renderer
        // (the same thing GameObject → 2D Object → Sprites gives students).
        Sprite square = MakeShapeSprite("Square", false);
        Sprite circle = MakeShapeSprite("Circle", true);

        Directory.CreateDirectory(Root + "/Scenes");
        var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);

        // ---- Camera: orthographic, Size 9, dark navy background ----
        var cameraObject = new GameObject("Main Camera");
        cameraObject.tag = "MainCamera";
        cameraObject.transform.position = new Vector3(0f, 7f, -10f);
        var camera = cameraObject.AddComponent<Camera>();
        camera.orthographic = true;
        camera.orthographicSize = 9f;
        camera.clearFlags = CameraClearFlags.SolidColor;
        camera.backgroundColor = Hex("#1E1A33");
        camera.nearClipPlane = 0.3f;
        camera.farClipPlane = 1000f;
        cameraObject.AddComponent<AudioListener>();

        // ---- Light: without a 2D light, URP 2D sprites render black ----
        var lightObject = new GameObject("Global Light 2D");
        var light = lightObject.AddComponent<Light2D>();
        light.lightType = Light2D.LightType.Global;

        // ---- Mission control (invisible, holds the briefing script) ----
        var missionControl = new GameObject("MissionControl");
        missionControl.AddComponent<MissionBriefing>();

        // ---- The rocket: an empty parent with five sprite children ----
        var rocket = new GameObject("Rocket");
        rocket.AddComponent<Rocket>();
        Transform r = rocket.transform;

        Part("Body",      r, square, new Vector3(0f, 1.5f, 0f),  0f,  new Vector3(1f, 3f, 1f),       "#F5F3FF",  1);
        Part("Nose",      r, circle, new Vector3(0f, 3f, 0f),    0f,  new Vector3(1f, 1f, 1f),       "#EF4050",  0);
        Part("Window",    r, circle, new Vector3(0f, 2.2f, 0f),  0f,  new Vector3(0.45f, 0.45f, 1f), "#3DDCC8",  2);
        Part("Fin Left",  r, square, new Vector3(-0.6f, 0.5f, 0f), -20f, new Vector3(0.4f, 1f, 1f),  "#EF4050",  0);
        Part("Fin Right", r, square, new Vector3(0.6f, 0.5f, 0f),  20f,  new Vector3(0.4f, 1f, 1f),  "#EF4050",  0);

        // ---- The pad and the ground (not children of the rocket) ----
        Part("Launch Pad", null, square, new Vector3(0f, -0.15f, 0f), 0f, new Vector3(4f, 0.3f, 1f), "#6B6F7B", -1);
        Part("Ground",     null, square, new Vector3(0f, -2.3f, 0f),  0f, new Vector3(40f, 4f, 1f),  "#2E2A45", -2);

        EditorSceneManager.SaveScene(scene, ScenePath);
        AddToBuildSettings(ScenePath);

        Debug.Log("Rocket Launch scene built: " + ScenePath);
    }

    static void Part(string name, Transform parent, Sprite sprite, Vector3 position, float rotationZ,
                     Vector3 scale, string colorHex, int orderInLayer)
    {
        var go = new GameObject(name);
        go.transform.SetParent(parent, false);
        go.transform.localPosition = position;
        go.transform.localRotation = Quaternion.Euler(0f, 0f, rotationZ);
        go.transform.localScale = scale;

        var renderer = go.AddComponent<SpriteRenderer>();
        renderer.sprite = sprite;
        renderer.color = Hex(colorHex);
        renderer.sortingOrder = orderInLayer;
    }

    // Creates (once) a white 256×256 PNG imported as a 1-unit sprite.
    static Sprite MakeShapeSprite(string name, bool round)
    {
        string path = SpriteFolder + "/" + name + ".png";

        if (!File.Exists(path))
        {
            Directory.CreateDirectory(SpriteFolder);
            const int size = 256;
            var texture = new Texture2D(size, size, TextureFormat.RGBA32, false);
            float radius = size / 2f;

            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    float alpha = 1f;
                    if (round)
                    {
                        float dx = x + 0.5f - radius;
                        float dy = y + 0.5f - radius;
                        float distance = Mathf.Sqrt(dx * dx + dy * dy);
                        alpha = Mathf.Clamp01(radius - distance + 0.5f); // soft 1-pixel edge
                    }
                    texture.SetPixel(x, y, new Color(1f, 1f, 1f, alpha));
                }
            }

            File.WriteAllBytes(path, texture.EncodeToPNG());
            Object.DestroyImmediate(texture);
            AssetDatabase.ImportAsset(path);

            var importer = (TextureImporter)AssetImporter.GetAtPath(path);
            importer.textureType = TextureImporterType.Sprite;
            importer.spriteImportMode = SpriteImportMode.Single;
            importer.spritePixelsPerUnit = size;
            importer.alphaIsTransparency = true;
            importer.mipmapEnabled = false;
            importer.SaveAndReimport();
        }

        return AssetDatabase.LoadAssetAtPath<Sprite>(path);
    }

    // Puts the scene first in Build Settings, ticked, so a build starts with it,
    // and drops any scene whose file has been deleted.
    static void AddToBuildSettings(string scenePath)
    {
        var scenes = new System.Collections.Generic.List<EditorBuildSettingsScene>();
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

    static Color Hex(string hex)
    {
        ColorUtility.TryParseHtmlString(hex, out Color color);
        return color;
    }
}
