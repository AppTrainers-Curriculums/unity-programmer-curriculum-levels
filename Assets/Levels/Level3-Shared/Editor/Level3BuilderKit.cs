using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEditor;
using UnityEditor.Animations;
using UnityEditor.SceneManagement;
using UnityEditor.Tilemaps;
using UnityEditor.U2D.Sprites;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.UI;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

// INSTRUCTOR TOOL: helpers shared by the Level 3 scene builders (Knight Run, and
// Crypt Keys and Gate Guard to come). Not part of any student book, never in a build.
public static class Level3BuilderKit
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

    // ------------------------------------------------------------ assets kept in place

    // Saves a new asset, or copies it over the one already at the path, so the
    // asset keeps its GUID and everything that points to it still does.
    public static T SaveOver<T>(T asset, string path) where T : Object
    {
        var existing = AssetDatabase.LoadAssetAtPath<T>(path);
        if (existing == null)
        {
            AssetDatabase.CreateAsset(asset, path);
            return asset;
        }
        EditorUtility.CopySerialized(asset, existing);
        Object.DestroyImmediate(asset);
        EditorUtility.SetDirty(existing);
        return existing;
    }

    public static PhysicsMaterial2D MakePhysicsMaterial(string path, float friction, float bounciness)
    {
        var material = new PhysicsMaterial2D { friction = friction, bounciness = bounciness };
        return SaveOver(material, path);
    }

    // Ignores collisions between two layers, as unticking their box in
    // Project Settings → Physics 2D → Layer Collision Matrix does.
    public static void IgnoreCollisions(int layerA, int layerB)
    {
        Physics2D.IgnoreLayerCollision(layerA, layerB, true);
        EditorUtility.SetDirty(AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/Physics2DSettings.asset")[0]);
    }

    // A TextMeshPro font asset made from a .ttf, as Assets → Create → TextMeshPro →
    // Font Asset → SDF makes it in the book: a dynamic SDF atlas, its texture and
    // material saved inside it and named after the font, and the material on the
    // full Distance Field shader, whose Outline panel is always there. An asset
    // made by an older builder is put right, too.
    public static TMP_FontAsset MakeFontAsset(string fontPath, string assetPath)
    {
        var fontAsset = AssetDatabase.LoadAssetAtPath<TMP_FontAsset>(assetPath);
        if (fontAsset == null)
        {
            var sourceFont = AssetDatabase.LoadAssetAtPath<Font>(fontPath);
            if (sourceFont == null)
            {
                Debug.LogError("Missing font: " + fontPath);
                return null;
            }
            fontAsset = TMP_FontAsset.CreateFontAsset(sourceFont);
            fontAsset.name = Path.GetFileNameWithoutExtension(assetPath);
            AssetDatabase.CreateAsset(fontAsset, assetPath);
            AssetDatabase.AddObjectToAsset(fontAsset.atlasTexture, fontAsset);
            AssetDatabase.AddObjectToAsset(fontAsset.material, fontAsset);
        }

        string fontName = Path.GetFileNameWithoutExtension(fontPath);
        fontAsset.atlasTexture.name = fontName + " Atlas";
        fontAsset.material.name = fontName + " Atlas Material";
        fontAsset.material.shader = Shader.Find("TextMeshPro/Distance Field");
        EditorUtility.SetDirty(fontAsset.atlasTexture);
        EditorUtility.SetDirty(fontAsset.material);
        EditorUtility.SetDirty(fontAsset);
        AssetDatabase.SaveAssets();
        return fontAsset;
    }

    // ------------------------------------------------------------ pixel art

    // Imports a sprite sheet as pixel art, as the book does by hand: Sprite Mode
    // Multiple, the given Pixels Per Unit, Filter Mode Point (no filter, so the
    // pixels stay sharp), no compression and no mipmaps. Then slices it as
    // Sprite Editor → Slice → Grid By Cell Size does: only the cells with
    // something in them, named as the Sprite Editor names them (knight_0,
    // knight_1 …, left to right, top row first). Returns the sprites in that
    // order. It reimports only when something differs.
    public static Sprite[] ImportSpriteSheet(string path, int cellWidth, int cellHeight, float pixelsPerUnit, Vector2 pivot)
    {
        if (!File.Exists(path))
        {
            Debug.LogError("Missing sprite sheet: " + path);
            return new Sprite[0];
        }
        var pixels = new Texture2D(2, 2);
        pixels.LoadImage(File.ReadAllBytes(path));
        Color32[] colours = pixels.GetPixels32();
        int width = pixels.width;
        int height = pixels.height;
        Object.DestroyImmediate(pixels);

        var rects = new List<Rect>();
        for (int row = 0; row < height / cellHeight; row++)
        {
            for (int column = 0; column < width / cellWidth; column++)
            {
                // Textures count rows from the bottom; the Sprite Editor names from the top.
                int x = column * cellWidth;
                int y = height - (row + 1) * cellHeight;
                if (HasPixels(colours, width, x, y, cellWidth, cellHeight))
                {
                    rects.Add(new Rect(x, y, cellWidth, cellHeight));
                }
            }
        }
        return ImportSprites(path, rects, pixelsPerUnit, pivot);
    }

    // The same, with the rectangles given in pixels from the bottom-left, for a
    // sheet that isn't a grid (Slice → Automatic, in the Sprite Editor).
    public static Sprite[] ImportSpriteRects(string path, Rect[] rects, float pixelsPerUnit, Vector2 pivot)
    {
        return ImportSprites(path, new List<Rect>(rects), pixelsPerUnit, pivot);
    }

    static bool HasPixels(Color32[] colours, int width, int x0, int y0, int cellWidth, int cellHeight)
    {
        for (int y = y0; y < y0 + cellHeight; y++)
        {
            for (int x = x0; x < x0 + cellWidth; x++)
            {
                if (colours[y * width + x].a > 0)
                {
                    return true;
                }
            }
        }
        return false;
    }

    static Sprite[] ImportSprites(string path, List<Rect> rects, float pixelsPerUnit, Vector2 pivot)
    {
        var importer = (TextureImporter)AssetImporter.GetAtPath(path);
        if (importer == null)
        {
            Debug.LogError("Missing sprite sheet: " + path);
            return new Sprite[0];
        }
        string baseName = Path.GetFileNameWithoutExtension(path);

        var factory = new SpriteDataProviderFactories();
        factory.Init();
        ISpriteEditorDataProvider provider = factory.GetSpriteEditorDataProviderFromObject(importer);
        provider.InitSpriteEditorDataProvider();
        SpriteRect[] existing = provider.GetSpriteRects();

        bool same = importer.textureType == TextureImporterType.Sprite
            && importer.spriteImportMode == SpriteImportMode.Multiple
            && Mathf.Approximately(importer.spritePixelsPerUnit, pixelsPerUnit)
            && importer.filterMode == FilterMode.Point
            && importer.textureCompression == TextureImporterCompression.Uncompressed
            && !importer.mipmapEnabled
            && existing.Length == rects.Count;
        for (int i = 0; same && i < rects.Count; i++)
        {
            same = existing[i].name == baseName + "_" + i && existing[i].rect == rects[i]
                && existing[i].alignment == SpriteAlignment.Custom && existing[i].pivot == pivot;
        }

        if (!same)
        {
            importer.textureType = TextureImporterType.Sprite;
            importer.spriteImportMode = SpriteImportMode.Multiple;
            importer.spritePixelsPerUnit = pixelsPerUnit;
            importer.filterMode = FilterMode.Point;
            importer.textureCompression = TextureImporterCompression.Uncompressed;
            importer.mipmapEnabled = false;

            var spriteRects = new SpriteRect[rects.Count];
            var pairs = new List<SpriteNameFileIdPair>();
            for (int i = 0; i < rects.Count; i++)
            {
                string name = baseName + "_" + i;
                GUID id = GUID.Generate();
                foreach (SpriteRect old in existing)
                {
                    if (old.name == name)
                    {
                        id = old.spriteID;      // the same sprite keeps its id, so nothing loses it
                    }
                }
                spriteRects[i] = new SpriteRect
                {
                    name = name,
                    rect = rects[i],
                    alignment = SpriteAlignment.Custom,
                    pivot = pivot,
                    spriteID = id,
                };
                pairs.Add(new SpriteNameFileIdPair(name, id));
            }
            provider.SetSpriteRects(spriteRects);
            provider.GetDataProvider<ISpriteNameFileIdDataProvider>().SetNameFileIdPairs(pairs);
            provider.Apply();
            importer.SaveAndReimport();
        }

        var sprites = new Sprite[rects.Count];
        foreach (Object asset in AssetDatabase.LoadAllAssetRepresentationsAtPath(path))
        {
            var sprite = asset as Sprite;
            int index;
            if (sprite != null && sprite.name.StartsWith(baseName + "_")
                && int.TryParse(sprite.name.Substring(baseName.Length + 1), out index) && index < sprites.Length)
            {
                sprites[index] = sprite;
            }
        }
        return sprites;
    }

    // ------------------------------------------------------------ tiles

    // A Tile asset for one sprite, as dragging a sliced sheet into the Tile
    // Palette window makes them. Grid colliders are whole squares, so the
    // Composite Collider 2D merges them into smooth ground.
    public static Tile MakeTile(string path, Sprite sprite, Tile.ColliderType colliderType)
    {
        var tile = AssetDatabase.LoadAssetAtPath<Tile>(path);
        if (tile == null)
        {
            tile = ScriptableObject.CreateInstance<Tile>();
            AssetDatabase.CreateAsset(tile, path);
        }
        tile.sprite = sprite;
        tile.colliderType = colliderType;
        EditorUtility.SetDirty(tile);
        return tile;
    }

    // A Tile Palette with the tiles laid out in the given cells. Made once,
    // then kept: only its tiles are laid out again.
    public static void MakeTilePalette(string folder, string name, TileBase[] tiles, Vector3Int[] cells)
    {
        string path = folder + "/" + name + ".prefab";
        if (AssetDatabase.LoadAssetAtPath<GameObject>(path) == null)
        {
            GridPaletteUtility.CreateNewPalette(folder, name, GridLayout.CellLayout.Rectangle,
                GridPalette.CellSizing.Automatic, Vector3.one, GridLayout.CellSwizzle.XYZ);
        }
        GameObject contents = PrefabUtility.LoadPrefabContents(path);
        Tilemap tilemap = contents.GetComponentInChildren<Tilemap>();
        tilemap.ClearAllTiles();
        for (int i = 0; i < tiles.Length; i++)
        {
            tilemap.SetTile(cells[i], tiles[i]);
        }
        PrefabUtility.SaveAsPrefabAsset(contents, path);
        PrefabUtility.UnloadPrefabContents(contents);
    }

    // ------------------------------------------------------------ animation clips

    // A clip that shows these sprites one after another, at this many frames a
    // second, as dragging the frames into the Animation window makes it. The
    // last frame gets its whole frame too, so a looping clip doesn't skip it.
    public static AnimationClip MakeSpriteClip(string path, Sprite[] frames, float framesPerSecond, bool loop)
    {
        var clip = new AnimationClip { frameRate = framesPerSecond };
        var keys = new ObjectReferenceKeyframe[frames.Length + 1];
        for (int i = 0; i <= frames.Length; i++)
        {
            keys[i].time = i / framesPerSecond;
            keys[i].value = frames[Mathf.Min(i, frames.Length - 1)];
        }
        AnimationUtility.SetObjectReferenceCurve(clip, EditorCurveBinding.PPtrCurve("", typeof(SpriteRenderer), "m_Sprite"), keys);
        SetLooping(clip, loop);
        return SaveOver(clip, path);
    }

    // A clip with no sprite frames at all, only property curves (added with SetCurve).
    public static AnimationClip MakePropertyClip(string path, float framesPerSecond, bool loop)
    {
        var clip = new AnimationClip { frameRate = framesPerSecond };
        SetLooping(clip, loop);
        return SaveOver(clip, path);
    }

    static void SetLooping(AnimationClip clip, bool loop)
    {
        AnimationClipSettings settings = AnimationUtility.GetAnimationClipSettings(clip);
        settings.loopTime = loop;
        AnimationUtility.SetAnimationClipSettings(clip, settings);
    }

    // A property curve, through keyframes that change in straight lines: times
    // in seconds, and the value at each. path is the child it animates ("" for
    // the clip's own GameObject, "Sign" for its child Sign). Properties are
    // named as the Animation window names them, for example "m_Color.a" on a
    // SpriteRenderer, or "m_LocalScale.y" on a Transform.
    public static void SetCurve(AnimationClip clip, string path, System.Type type, string property, float[] times, float[] values)
    {
        var curve = new AnimationCurve();
        for (int i = 0; i < times.Length; i++)
        {
            curve.AddKey(new Keyframe(times[i], values[i]));
        }
        for (int i = 0; i < curve.length; i++)
        {
            AnimationUtility.SetKeyLeftTangentMode(curve, i, AnimationUtility.TangentMode.Linear);
            AnimationUtility.SetKeyRightTangentMode(curve, i, AnimationUtility.TangentMode.Linear);
        }
        AnimationUtility.SetEditorCurve(clip, EditorCurveBinding.FloatCurve(path, type, property), curve);
        EditorUtility.SetDirty(clip);
    }

    // A SpriteRenderer's colour, changing through these colours at these times.
    public static void SetColourCurve(AnimationClip clip, string path, float[] times, Color[] colours)
    {
        string[] channels = { "m_Color.r", "m_Color.g", "m_Color.b", "m_Color.a" };
        for (int c = 0; c < 4; c++)
        {
            var values = new float[colours.Length];
            for (int i = 0; i < colours.Length; i++)
            {
                values[i] = colours[i][c];
            }
            SetCurve(clip, path, typeof(SpriteRenderer), channels[c], times, values);
        }
    }

    // Animation Events: at each time, the clip calls the method of that name on
    // its GameObject's scripts.
    public static void SetEvents(AnimationClip clip, float[] times, string[] functionNames)
    {
        var events = new AnimationEvent[times.Length];
        for (int i = 0; i < times.Length; i++)
        {
            events[i] = new AnimationEvent { time = times[i], functionName = functionNames[i] };
        }
        AnimationUtility.SetAnimationEvents(clip, events);
        EditorUtility.SetDirty(clip);
    }

    // ------------------------------------------------------------ Animator Controllers

    // An empty Animator Controller: the one already at the path, emptied, so it
    // keeps its GUID, or a new one.
    public static AnimatorController MakeController(string path)
    {
        var controller = AssetDatabase.LoadAssetAtPath<AnimatorController>(path);
        if (controller == null)
        {
            return AnimatorController.CreateAnimatorControllerAtPath(path);
        }
        if (controller.layers.Length == 0)
        {
            controller.AddLayer("Base Layer");      // a controller saved half-made
        }
        AnimatorStateMachine machine = controller.layers[0].stateMachine;
        foreach (AnimatorStateTransition transition in machine.anyStateTransitions)
        {
            machine.RemoveAnyStateTransition(transition);
        }
        foreach (ChildAnimatorState child in machine.states)
        {
            machine.RemoveState(child.state);
        }
        while (controller.parameters.Length > 0)
        {
            controller.RemoveParameter(0);
        }
        return controller;
    }

    public static AnimatorState AddState(AnimatorController controller, string name, Motion motion, Vector2 position)
    {
        AnimatorState state = controller.layers[0].stateMachine.AddState(name, new Vector3(position.x, position.y, 0f));
        state.motion = motion;
        return state;
    }

    // A transition with the settings sprite animation wants: no blending
    // (Transition Duration 0), and Has Exit Time only when asked for, which
    // waits for the clip to end.
    public static AnimatorStateTransition AddTransition(AnimatorState from, AnimatorState to, bool hasExitTime)
    {
        AnimatorStateTransition transition = from.AddTransition(to);
        transition.hasExitTime = hasExitTime;
        transition.exitTime = 1f;
        transition.hasFixedDuration = true;
        transition.duration = 0f;
        return transition;
    }

    // From Any State, with Can Transition To Self off, so holding a key can't
    // restart the clip every frame.
    public static AnimatorStateTransition AddAnyStateTransition(AnimatorController controller, AnimatorState to)
    {
        AnimatorStateTransition transition = controller.layers[0].stateMachine.AddAnyStateTransition(to);
        transition.hasExitTime = false;
        transition.hasFixedDuration = true;
        transition.duration = 0f;
        transition.canTransitionToSelf = false;
        return transition;
    }

    // An Animator Override Controller: the base controller's state machine,
    // with some of its clips swapped for others.
    public static AnimatorOverrideController MakeOverrideController(string path, RuntimeAnimatorController baseController,
                                                                    AnimationClip[] originals, AnimationClip[] replacements)
    {
        var overrideController = AssetDatabase.LoadAssetAtPath<AnimatorOverrideController>(path);
        if (overrideController == null)
        {
            overrideController = new AnimatorOverrideController(baseController);
            AssetDatabase.CreateAsset(overrideController, path);
        }
        overrideController.runtimeAnimatorController = baseController;
        var overrides = new List<KeyValuePair<AnimationClip, AnimationClip>>();
        for (int i = 0; i < originals.Length; i++)
        {
            overrides.Add(new KeyValuePair<AnimationClip, AnimationClip>(originals[i], replacements[i]));
        }
        overrideController.ApplyOverrides(overrides);
        EditorUtility.SetDirty(overrideController);
        return overrideController;
    }
}
