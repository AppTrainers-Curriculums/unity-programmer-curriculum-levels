using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEditor;
using UnityEditor.Animations;
using UnityEditor.Events;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Rendering.Universal;
using UnityEngine.Tilemaps;
using UnityEngine.UI;
using static Level3BuilderKit;

// INSTRUCTOR TOOL: not part of the student book, and never shipped in a build.
// Menu: Tools → Knight Run (Level 3) → Build Scene
//
// Rebuilds Assets/Levels/Level3-KnightRun/Scenes/KnightRun.unity exactly as the
// Knight Run book describes it: the pixel-art import settings and slicing, the
// tiles and the Tile Palette, every animation clip, the three Animator
// Controllers and the purple slime's Override Controller, the prefabs, the
// level painted from Editor/KnightRunLevel.txt, the knight, the camera and the
// whole UI, with every Inspector reference wired up. Use it to prepare lab
// machines or to reset a broken scene. Running it again overwrites the scene,
// the prefabs, the clips and the controllers; the font asset and the Tile
// Palette are made once and kept.
public static class KnightRunSceneBuilder
{
    const string Root = "Assets/Levels/Level3-KnightRun";
    const string ScenePath = Root + "/Scenes/KnightRun.unity";
    const string SpriteFolder = Root + "/Art/Sprites";
    const string FontFolder = Root + "/Art/Fonts";
    const string AudioFolder = Root + "/Audio";
    const string AnimationFolder = Root + "/Animation";
    const string TileFolder = Root + "/Tiles";
    const string PrefabFolder = Root + "/Prefabs";
    const string MaterialFolder = Root + "/Materials";
    const string LevelMapPath = Root + "/Editor/KnightRunLevel.txt";

    const float PixelsPerUnit = 16f;
    const int SectionWidth = 63;
    const int MapTop = 10;                  // the map's first row is y = 10; its last is y = -3
    const float LevelWidth = 3 * SectionWidth;

    // ---- The sliced art (ImportArt)
    static Sprite[] knightSprites;
    static Sprite[] greenSprites;
    static Sprite[] purpleSprites;
    static Sprite[] coinSprites;
    static Sprite[] fruitSprites;
    static Sprite[] platformSprites;
    static Sprite[] tileSprites;
    static readonly Dictionary<Vector2Int, Tile> tilesByCell = new Dictionary<Vector2Int, Tile>();

    // ---- What each section looks like
    class Look
    {
        public string title;
        public Color sky;
        public Vector2Int groundTop, groundFill, liquidTop, liquidFill;
        public GameObject platformPrefab;
        public Dictionary<char, Vector3Int> decorations;    // tileset column, row, and height in tiles
    }

    [MenuItem("Tools/Knight Run (Level 3)/Build Scene")]
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

        EnsureFolder(Root + "/Scenes");
        EnsureFolder(AnimationFolder);
        EnsureFolder(TileFolder);
        EnsureFolder(PrefabFolder);
        EnsureFolder(MaterialFolder);
        AssetDatabase.Refresh();

        int groundLayer = AddLayer("Ground");
        int knightLayer = AddLayer("Knight");
        int enemyLayer = AddLayer("Enemy");
        IgnoreCollisions(enemyLayer, enemyLayer);       // slimes pass through each other

        ImportArt();
        MakeTiles();
        TMP_FontAsset font = MakePixelFont();
        PhysicsMaterial2D noFriction = MakePhysicsMaterial(MaterialFolder + "/No Friction.physicsMaterial2D", 0f, 0f);

        // ---- Animation: clips and controllers (Chapters 3, 4, 5, 6, 8 and 9) ----
        AnimatorController knightController = MakeKnightAnimation();
        AnimatorController slimeController = MakeSlimeAnimation(out AnimatorOverrideController purpleController);
        AnimatorController coinController = MakeCoinAnimation();
        AnimatorController checkpointController = MakeCheckpointAnimation();

        // ---- Prefabs (Chapters 6, 8 and 9) ----
        AudioClip squash = LoadClip(AudioFolder + "/explosion.wav");
        GameObject greenSlime = MakeSlimePrefab("Slime", greenSprites[4], slimeController, enemyLayer, groundLayer, squash,
                                                1, 1.5f, 2.5f, 4f, 1.2f, new Vector2(4f, 6f));
        GameObject purpleSlime = MakeSlimePrefab("Purple Slime", purpleSprites[4], purpleController, enemyLayer, groundLayer, squash,
                                                 2, 2f, 3.5f, 5f, 2f, new Vector2(5f, 7f));
        GameObject coinPrefab = MakeCoinPrefab(coinController);
        GameObject applePrefab = MakeApplePrefab();
        GameObject checkpointPrefab = MakeCheckpointPrefab(checkpointController);
        Look[] looks = MakeLooks(groundLayer);

        var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);

        // ---- Camera and light (Chapter 1) ----
        var cameraObject = new GameObject("Main Camera");
        cameraObject.tag = "MainCamera";
        var cam = cameraObject.AddComponent<Camera>();
        cam.orthographic = true;
        cam.orthographicSize = 5f;
        cam.clearFlags = CameraClearFlags.SolidColor;
        cam.backgroundColor = looks[0].sky;
        cameraObject.AddComponent<AudioListener>();
        var cameraFollow = cameraObject.AddComponent<CameraFollow>();

        var lightObject = new GameObject("Global Light 2D");
        lightObject.AddComponent<Light2D>().lightType = Light2D.LightType.Global;

        // ---- The level: the Grid and its three Tilemaps (Chapters 1, 7, 8 and 13) ----
        var gridObject = new GameObject("Grid");
        gridObject.AddComponent<Grid>().cellSize = new Vector3(1f, 1f, 0f);

        Tilemap ground = MakeTilemap(gridObject.transform, "Ground", 0);
        ground.gameObject.layer = groundLayer;
        var groundBody = ground.gameObject.AddComponent<Rigidbody2D>();
        groundBody.bodyType = RigidbodyType2D.Static;
        var groundCollider = ground.gameObject.AddComponent<TilemapCollider2D>();
        groundCollider.compositeOperation = Collider2D.CompositeOperation.Merge;
        var composite = ground.gameObject.AddComponent<CompositeCollider2D>();
        composite.geometryType = CompositeCollider2D.GeometryType.Polygons;

        Tilemap hazards = MakeTilemap(gridObject.transform, "Hazards", 1);
        var hazardCollider = hazards.gameObject.AddComponent<TilemapCollider2D>();
        hazardCollider.isTrigger = true;
        var hazardZone = hazards.gameObject.AddComponent<KillZone>();

        Tilemap decoration = MakeTilemap(gridObject.transform, "Decoration", -2);

        // ---- The knight (Chapters 2 to 5 and 7) ----
        var knightObject = new GameObject("Knight");
        knightObject.layer = knightLayer;
        var knightRenderer = knightObject.AddComponent<SpriteRenderer>();
        knightRenderer.sprite = knightSprites[0];
        knightRenderer.sortingOrder = 5;
        var knightBody = knightObject.AddComponent<Rigidbody2D>();
        knightBody.bodyType = RigidbodyType2D.Dynamic;
        knightBody.gravityScale = 3f;
        knightBody.constraints = RigidbodyConstraints2D.FreezeRotation;
        knightBody.interpolation = RigidbodyInterpolation2D.Interpolate;
        knightBody.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
        knightBody.sharedMaterial = noFriction;
        var capsule = knightObject.AddComponent<CapsuleCollider2D>();
        capsule.direction = CapsuleDirection2D.Vertical;
        capsule.size = new Vector2(0.7f, 1.15f);
        capsule.offset = new Vector2(0f, 0.575f);
        knightObject.AddComponent<Animator>().runtimeAnimatorController = knightController;
        knightObject.AddComponent<AudioSource>().playOnAwake = false;
        var knight = knightObject.AddComponent<KnightController>();
        var knightHealth = knightObject.AddComponent<KnightHealth>();
        knightObject.AddComponent<KnightCombat>();
        Transform leftFoot = MakeChild(knightObject.transform, "Left Foot", new Vector3(-0.25f, 0.05f, 0f));
        Transform rightFoot = MakeChild(knightObject.transform, "Right Foot", new Vector3(0.25f, 0.05f, 0f));

        // ---- The game, and the groups that hold the level's things (Chapters 6, 9 and 11) ----
        var gameHolder = new GameObject("Platformer Game");
        var game = gameHolder.AddComponent<PlatformerGame>();
        var gameAudio = gameHolder.AddComponent<AudioSource>();
        gameAudio.playOnAwake = false;
        var music = gameHolder.AddComponent<AudioSource>();
        music.clip = LoadClip(AudioFolder + "/time_for_adventure.mp3");
        music.loop = true;
        music.playOnAwake = true;
        music.volume = 0.5f;

        Transform platforms = new GameObject("Platforms").transform;
        Transform enemies = new GameObject("Enemies").transform;
        Transform pickups = new GameObject("Pickups").transform;
        Transform checkpoints = new GameObject("Checkpoints").transform;

        // ---- Paint the level, and put everything in its place ----
        Vector3 knightStart = Vector3.zero;
        Vector3 doorPosition = Vector3.zero;
        var slimes = new List<Slime>();
        var coins = new List<Coin>();
        var checkpointList = new List<Checkpoint>();
        string[] lines = File.ReadAllLines(LevelMapPath);
        int section = -1;
        var map = new List<string>();
        foreach (string line in lines)
        {
            if (line.StartsWith("# "))      // a section's heading, such as "# The Meadow"
            {
                if (section >= 0)
                {
                    PaintSection(section, map, looks[section], ground, hazards, decoration, platforms, enemies, pickups,
                                 checkpoints, greenSlime, purpleSlime, coinPrefab, applePrefab, checkpointPrefab,
                                 slimes, coins, checkpointList, ref knightStart, ref doorPosition);
                }
                section++;
                map.Clear();
                continue;
            }
            map.Add(line);
        }
        PaintSection(section, map, looks[section], ground, hazards, decoration, platforms, enemies, pickups,
                     checkpoints, greenSlime, purpleSlime, coinPrefab, applePrefab, checkpointPrefab,
                     slimes, coins, checkpointList, ref knightStart, ref doorPosition);

        // The Editor builds the tilemaps' collider shapes a moment after
        // painting. The scene is saved before that moment, so build them now:
        // a Composite Collider saved with no shapes stays empty in Play mode.
        groundCollider.ProcessTilemapChanges();
        hazardCollider.ProcessTilemapChanges();
        composite.GenerateGeometry();

        knightObject.transform.position = knightStart;
        cameraObject.transform.position = new Vector3(Mathf.Max(knightStart.x, 9f), 2f, -10f);

        // ---- The castle door, and the kill zone under everything (Chapters 7 and 13) ----
        var door = new GameObject("Castle Door");
        door.transform.position = doorPosition;
        var doorTrigger = door.AddComponent<BoxCollider2D>();
        doorTrigger.isTrigger = true;
        doorTrigger.size = new Vector2(1.4f, 2.6f);
        var castleDoor = door.AddComponent<CastleDoor>();

        var killZoneObject = new GameObject("Kill Zone");
        killZoneObject.transform.position = new Vector3(LevelWidth / 2f, -7f, 0f);
        var killTrigger = killZoneObject.AddComponent<BoxCollider2D>();
        killTrigger.isTrigger = true;
        killTrigger.size = new Vector2(LevelWidth + 20f, 2f);
        var killZone = killZoneObject.AddComponent<KillZone>();

        // ---- The screen (Chapters 10 to 12) ----
        Transform ui = MakeCanvas("Canvas");
        Color white = Color.white;
        Color panelColour = Hex("#1C1F2B", 0.75f);

        // The health bar, with the knight's face beside it
        Image healthPanel = MakeImage(ui, "Health Panel", panelColour, new Vector2(0f, 1f), new Vector2(30f, -30f), new Vector2(560f, 100f));
        healthPanel.sprite = UiSprite();
        healthPanel.type = Image.Type.Sliced;
        Image face = MakeImage(healthPanel.transform, "Knight Face", white, new Vector2(0f, 0.5f), new Vector2(0f, -4f), new Vector2(128f, 128f));
        face.sprite = knightSprites[0];
        face.preserveAspect = true;
        RectTransform barRect = MakeRect(healthPanel.transform, "Health Bar", new Vector2(0f, 0.5f), new Vector2(120f, 0f), new Vector2(410f, 40f));
        var healthBar = barRect.gameObject.AddComponent<HealthBar>();
        Image barBack = MakeImage(barRect, "Background", Hex("#000000", 0.45f), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(410f, 40f));
        barBack.sprite = UiSprite();
        barBack.type = Image.Type.Sliced;
        Image barFill = MakeImage(barRect, "Fill", Hex("#5CD140"), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(410f, 40f));
        barFill.sprite = UiSprite();
        barFill.type = Image.Type.Filled;
        barFill.fillMethod = Image.FillMethod.Horizontal;
        barFill.fillOrigin = (int)Image.OriginHorizontal.Left;

        // The coin count
        Image coinPanel = MakeImage(ui, "Coin Panel", panelColour, new Vector2(0f, 1f), new Vector2(30f, -145f), new Vector2(230f, 80f));
        coinPanel.sprite = UiSprite();
        coinPanel.type = Image.Type.Sliced;
        Image coinIcon = MakeImage(coinPanel.transform, "Coin Icon", white, new Vector2(0f, 0.5f), new Vector2(10f, 0f), new Vector2(64f, 64f));
        coinIcon.sprite = coinSprites[0];
        TMP_Text coinText = MakeText(coinPanel.transform, "Coin Text", "x 0", 44f, TextAlignmentOptions.Left,
                                     new Vector2(0f, 0.5f), new Vector2(84f, 0f), new Vector2(140f, 70f), white);
        coinText.font = font;

        // The section's name, and the pause button
        TMP_Text sectionText = MakeText(ui, "Section Text", "", 64f, TextAlignmentOptions.Center,
                                        new Vector2(0.5f, 1f), new Vector2(0f, -170f), new Vector2(1200f, 100f), white);
        sectionText.font = font;
        Button pauseButton = MakeButton(ui, "Pause Button", "II", Vector2.zero, new Vector2(110f, 110f), panelColour);
        TMP_Text pauseLabel = pauseButton.GetComponentInChildren<TMP_Text>();
        pauseLabel.font = font;
        pauseLabel.color = white;
        PinToCorner((RectTransform)pauseButton.transform, new Vector2(1f, 1f), new Vector2(-30f, -30f));

        // The touch buttons: Event Triggers, so two fingers work at once (Chapter 12)
        RectTransform touch = MakeStretch(ui, "Touch Controls");
        GameObject leftButton = MakeTouchButton(touch, "Left Button", "<", font, new Vector2(0f, 0f), new Vector2(60f, 60f));
        GameObject rightButton = MakeTouchButton(touch, "Right Button", ">", font, new Vector2(0f, 0f), new Vector2(290f, 60f));
        GameObject rollButton = MakeTouchButton(touch, "Roll Button", "ROLL", font, new Vector2(1f, 0f), new Vector2(-290f, 60f));
        GameObject jumpButton = MakeTouchButton(touch, "Jump Button", "JUMP", font, new Vector2(1f, 0f), new Vector2(-60f, 60f));
        AddHoldTrigger(leftButton, knight.SetLeftHeld);
        AddHoldTrigger(rightButton, knight.SetRightHeld);
        AddPressTrigger(rollButton, knight.PressRoll);
        AddPressTrigger(jumpButton, knight.PressJump);

        // Start panel: the title, how to play, and Play (Chapter 11)
        Color windowColour = Hex("#2B2440");
        Color buttonColour = Hex("#E2A23B");
        GameObject startPanel;
        RectTransform startWindow = MakeWindow(ui, "Start Panel", new Vector2(640f, 340f), 2f, windowColour, out startPanel);
        MakePanelText(startWindow, "Title", "Knight Run", 48f, new Vector2(0f, 105f), new Vector2(600f, 70f), font);
        MakePanelText(startWindow, "How To Play",
                      "Run: A and D, or the arrows\nJump: Space    Roll: Shift\nStomp on slimes, or roll into them.\nReach the castle door!",
                      17f, new Vector2(0f, 10f), new Vector2(600f, 120f), font);
        Button playButton = MakePanelButton(startWindow, "Play Button", "Play", new Vector2(0f, -115f), buttonColour, font);

        // Pause panel: Resume, Restart and the volume (Chapter 12)
        GameObject pausePanel;
        RectTransform pauseWindow = MakeWindow(ui, "Pause Panel", new Vector2(460f, 330f), 2f, windowColour, out pausePanel);
        MakePanelText(pauseWindow, "Title", "Paused", 40f, new Vector2(0f, 115f), new Vector2(420f, 60f), font);
        Button resumeButton = MakePanelButton(pauseWindow, "Resume Button", "Resume", new Vector2(0f, 45f), buttonColour, font);
        Button restartButton = MakePanelButton(pauseWindow, "Restart Button", "Restart", new Vector2(0f, -15f), buttonColour, font);
        MakePanelText(pauseWindow, "Volume Label", "Volume", 18f, new Vector2(-120f, -90f), new Vector2(140f, 30f), font);
        Slider volumeSlider = MakeSlider(pauseWindow, "Volume Slider", new Vector2(60f, -90f), 220f);
        volumeSlider.value = 1f;
        var pauseMenu = pausePanel.AddComponent<PauseMenu>();

        // Win panel: coins and time, and Play Again (Chapter 11)
        GameObject winPanel;
        RectTransform winWindow = MakeWindow(ui, "Win Panel", new Vector2(560f, 330f), 2f, windowColour, out winPanel);
        TMP_Text winText = MakePanelText(winWindow, "Win Text", "You made it!", 26f, new Vector2(0f, 40f), new Vector2(520f, 220f), font);
        Button playAgainButton = MakePanelButton(winWindow, "Play Again Button", "Play Again", new Vector2(0f, -115f), buttonColour, font);

        // Lose panel: Try Again (Chapter 11)
        GameObject losePanel;
        RectTransform loseWindow = MakeWindow(ui, "Lose Panel", new Vector2(560f, 260f), 2f, windowColour, out losePanel);
        MakePanelText(loseWindow, "Title", "The knight has fallen", 30f, new Vector2(0f, 45f), new Vector2(520f, 100f), font);
        Button tryAgainButton = MakePanelButton(loseWindow, "Try Again Button", "Try Again", new Vector2(0f, -70f), buttonColour, font);

        pausePanel.SetActive(false);
        winPanel.SetActive(false);
        losePanel.SetActive(false);

        // ---- Wire up every Inspector reference ----
        Set(cameraFollow, "target", knightObject.transform);
        SetVector2(cameraFollow, "levelMin", new Vector2(0f, -3f));
        SetVector2(cameraFollow, "levelMax", new Vector2(LevelWidth, 12f));

        Set(hazardZone, "game", game);
        Set(killZone, "game", game);
        Set(castleDoor, "game", game);

        Set(knight, "game", game);
        Set(knight, "leftFoot", leftFoot);
        Set(knight, "rightFoot", rightFoot);
        SetLayerMask(knight, "groundMask", "Ground");
        Set(knight, "jumpSound", LoadClip(AudioFolder + "/jump.wav"));
        Set(knight, "stepSound", LoadClip(AudioFolder + "/tap.wav"));
        Set(knight, "rollSound", LoadClip(AudioFolder + "/tap.wav"));

        Set(knightHealth, "game", game);
        Set(knightHealth, "healthBar", healthBar);
        Set(knightHealth, "hurtSound", LoadClip(AudioFolder + "/hurt.wav"));
        Set(knightHealth, "healSound", LoadClip(AudioFolder + "/power_up.wav"));

        foreach (Slime slime in slimes)
        {
            Set(slime, "game", game);
            Set(slime, "knight", knightHealth);
        }
        foreach (Coin coin in coins)
        {
            Set(coin, "game", game);
        }
        foreach (Checkpoint checkpoint in checkpointList)
        {
            Set(checkpoint, "game", game);
        }

        Set(healthBar, "fill", barFill);

        Set(game, "knight", knight);
        Set(game, "knightHealth", knightHealth);
        Set(game, "cameraFollow", cameraFollow);
        Set(game, "mainCamera", cam);
        Set(game, "enemies", enemies);
        Set(game, "pickups", pickups);
        Set(game, "checkpoints", checkpoints);
        SetSections(game, looks);
        Set(game, "coinText", coinText);
        Set(game, "sectionText", sectionText);
        Set(game, "touchControls", touch.gameObject);
        Set(game, "startPanel", startPanel);
        Set(game, "playButton", playButton);
        Set(game, "pauseButton", pauseButton);
        Set(game, "pausePanel", pausePanel);
        Set(game, "winPanel", winPanel);
        Set(game, "winText", winText);
        Set(game, "playAgainButton", playAgainButton);
        Set(game, "losePanel", losePanel);
        Set(game, "tryAgainButton", tryAgainButton);
        Set(game, "audioSource", gameAudio);
        Set(game, "coinSound", LoadClip(AudioFolder + "/coin.wav"));
        Set(game, "checkpointSound", LoadClip(AudioFolder + "/power_up.wav"));
        Set(game, "winSound", LoadClip(AudioFolder + "/power_up.wav"));

        Set(pauseMenu, "game", game);
        Set(pauseMenu, "resumeButton", resumeButton);
        Set(pauseMenu, "restartButton", restartButton);
        Set(pauseMenu, "volumeSlider", volumeSlider);

        AssetDatabase.SaveAssets();
        SaveScene(scene, ScenePath);
        Debug.Log("Knight Run scene built: " + ScenePath);
    }

    // ------------------------------------------------------------------ art

    // Every sheet at 16 Pixels Per Unit, so one 16-pixel tile is one unit.
    static void ImportArt()
    {
        // The knight's feet are 4 pixels above the bottom of his 32-pixel frames.
        knightSprites = ImportSpriteSheet(SpriteFolder + "/knight.png", 32, 32, PixelsPerUnit, new Vector2(0.5f, 4f / 32f));
        greenSprites = ImportSpriteSheet(SpriteFolder + "/slime_green.png", 24, 24, PixelsPerUnit, new Vector2(0.5f, 0f));
        purpleSprites = ImportSpriteSheet(SpriteFolder + "/slime_purple.png", 24, 24, PixelsPerUnit, new Vector2(0.5f, 0f));
        coinSprites = ImportSpriteSheet(SpriteFolder + "/coin.png", 16, 16, PixelsPerUnit, new Vector2(0.5f, 0.5f));
        fruitSprites = ImportSpriteSheet(SpriteFolder + "/fruit.png", 16, 16, PixelsPerUnit, new Vector2(0.5f, 0.5f));
        tileSprites = ImportSpriteSheet(SpriteFolder + "/world_tileset.png", 16, 16, PixelsPerUnit, new Vector2(0.5f, 0.5f));

        // Each row of platforms.png: a 1-tile platform, then a 2-tile one, 9 pixels tall.
        // Their pivot is the middle of their top edge: the surface you stand on.
        var rects = new List<Rect>();
        for (int row = 0; row < 4; row++)
        {
            float y = 64 - row * 16 - 9;
            rects.Add(new Rect(0f, y, 16f, 9f));
            rects.Add(new Rect(16f, y, 32f, 9f));
        }
        platformSprites = ImportSpriteRects(SpriteFolder + "/platforms.png", rects.ToArray(), PixelsPerUnit, new Vector2(0.5f, 1f));
    }

    // One Tile asset for every tile in the tileset, as dragging the sliced
    // tileset into the Tile Palette makes, and the palette itself. Grid
    // colliders: the tiles' rounded corners would leave notches between them.
    static void MakeTiles()
    {
        tilesByCell.Clear();
        var tiles = new List<TileBase>();
        var cells = new List<Vector3Int>();
        foreach (Sprite sprite in tileSprites)
        {
            int column = Mathf.RoundToInt(sprite.rect.x) / 16;
            int row = (256 - Mathf.RoundToInt(sprite.rect.y)) / 16 - 1;
            Tile tile = MakeTile(TileFolder + "/" + sprite.name + ".asset", sprite, Tile.ColliderType.Grid);
            tilesByCell[new Vector2Int(column, row)] = tile;
            tiles.Add(tile);
            cells.Add(new Vector3Int(column, -row, 0));
        }
        MakeTilePalette(TileFolder, "Knight Run Palette", tiles.ToArray(), cells.ToArray());
    }

    static Tile TileAt(Vector2Int cell)
    {
        Tile tile;
        if (!tilesByCell.TryGetValue(cell, out tile))
        {
            Debug.LogError("No tile at column " + cell.x + ", row " + cell.y + " of the tileset");
        }
        return tile;
    }

    // The bundle's pixel font as a TextMeshPro font asset, with a dark outline
    // on its material, so white text reads on every sky (Chapter 10).
    static TMP_FontAsset MakePixelFont()
    {
        TMP_FontAsset font = MakeFontAsset(FontFolder + "/PixelOperator8.ttf", FontFolder + "/PixelOperator8 SDF.asset");
        Material material = font.material;
        material.SetFloat("_OutlineWidth", 0.2f);
        material.SetColor("_OutlineColor", Hex("#1C1F2B"));
        EditorUtility.SetDirty(material);
        return font;
    }

    // ------------------------------------------------------------------ animation

    static Sprite[] Frames(Sprite[] sheet, params int[] indices)
    {
        var frames = new Sprite[indices.Length];
        for (int i = 0; i < indices.Length; i++)
        {
            frames[i] = sheet[indices[i]];
        }
        return frames;
    }

    static Sprite[] Range(Sprite[] sheet, int first, int last)
    {
        var frames = new Sprite[last - first + 1];
        for (int i = first; i <= last; i++)
        {
            frames[i - first] = sheet[i];
        }
        return frames;
    }

    static string ClipPath(string name)
    {
        return AnimationFolder + "/" + name + ".anim";
    }

    // The knight's clips and Animator (Chapters 3 to 5 and 7).
    static AnimatorController MakeKnightAnimation()
    {
        AnimationClip idle = MakeSpriteClip(ClipPath("Knight Idle"), Range(knightSprites, 0, 3), 8f, true);
        AnimationClip run = MakeSpriteClip(ClipPath("Knight Run"), Range(knightSprites, 8, 23), 16f, true);
        SetEvents(run, new[] { 2f / 16f, 6f / 16f, 10f / 16f, 14f / 16f },
                  new[] { "OnFootstep", "OnFootstep", "OnFootstep", "OnFootstep" });
        AnimationClip jump = MakeSpriteClip(ClipPath("Knight Jump"), Frames(knightSprites, 28), 8f, true);
        AnimationClip fall = MakeSpriteClip(ClipPath("Knight Fall"), Frames(knightSprites, 8), 8f, true);
        AnimationClip roll = MakeSpriteClip(ClipPath("Knight Roll"), Range(knightSprites, 26, 33), 14f, false);
        SetEvents(roll, new[] { 7f / 14f }, new[] { "OnRollFinished" });
        AnimationClip hurt = MakeSpriteClip(ClipPath("Knight Hurt"), Range(knightSprites, 34, 37), 10f, false);
        AnimationClip dead = MakeSpriteClip(ClipPath("Knight Dead"), Range(knightSprites, 40, 43), 8f, false);
        SetColourCurve(dead, "", new[] { 0f, 0.5f, 1f }, new[] { Color.white, Color.white, new Color(1f, 1f, 1f, 0f) });
        SetEvents(dead, new[] { 1f }, new[] { "OnDeathFinished" });

        AnimatorController controller = MakeController(AnimationFolder + "/Knight.controller");
        controller.AddParameter("Speed", AnimatorControllerParameterType.Float);
        controller.AddParameter("VerticalSpeed", AnimatorControllerParameterType.Float);
        controller.AddParameter("Grounded", AnimatorControllerParameterType.Bool);
        controller.AddParameter("Roll", AnimatorControllerParameterType.Trigger);
        controller.AddParameter("Hurt", AnimatorControllerParameterType.Trigger);
        controller.AddParameter("Dead", AnimatorControllerParameterType.Trigger);
        controller.parameters = SetDefaultBool(controller.parameters, "Grounded", true);

        AnimatorState idleState = AddState(controller, "Idle", idle, new Vector2(300f, 0f));
        AnimatorState runState = AddState(controller, "Run", run, new Vector2(600f, 0f));
        AnimatorState jumpState = AddState(controller, "Jump", jump, new Vector2(600f, 160f));
        AnimatorState fallState = AddState(controller, "Fall", fall, new Vector2(300f, 160f));
        AnimatorState rollState = AddState(controller, "Roll", roll, new Vector2(0f, 300f));
        AnimatorState hurtState = AddState(controller, "Hurt", hurt, new Vector2(300f, 300f));
        AnimatorState deadState = AddState(controller, "Dead", dead, new Vector2(600f, 300f));
        controller.layers[0].stateMachine.defaultState = idleState;

        AddTransition(idleState, runState, false).AddCondition(AnimatorConditionMode.Greater, 0.1f, "Speed");
        AddTransition(runState, idleState, false).AddCondition(AnimatorConditionMode.Less, 0.1f, "Speed");
        foreach (AnimatorState ground in new[] { idleState, runState })
        {
            AnimatorStateTransition up = AddTransition(ground, jumpState, false);
            up.AddCondition(AnimatorConditionMode.IfNot, 0f, "Grounded");
            up.AddCondition(AnimatorConditionMode.Greater, 0.1f, "VerticalSpeed");
            AnimatorStateTransition down = AddTransition(ground, fallState, false);
            down.AddCondition(AnimatorConditionMode.IfNot, 0f, "Grounded");
            down.AddCondition(AnimatorConditionMode.Less, -0.1f, "VerticalSpeed");
        }
        AddTransition(jumpState, fallState, false).AddCondition(AnimatorConditionMode.Less, 0.1f, "VerticalSpeed");
        AddTransition(fallState, idleState, false).AddCondition(AnimatorConditionMode.If, 0f, "Grounded");

        AddAnyStateTransition(controller, rollState).AddCondition(AnimatorConditionMode.If, 0f, "Roll");
        AddAnyStateTransition(controller, hurtState).AddCondition(AnimatorConditionMode.If, 0f, "Hurt");
        AddAnyStateTransition(controller, deadState).AddCondition(AnimatorConditionMode.If, 0f, "Dead");
        AddTransition(rollState, idleState, true);
        AddTransition(hurtState, idleState, true);
        EditorUtility.SetDirty(controller);
        return controller;
    }

    static AnimatorControllerParameter[] SetDefaultBool(AnimatorControllerParameter[] parameters, string name, bool value)
    {
        foreach (AnimatorControllerParameter parameter in parameters)
        {
            if (parameter.name == name)
            {
                parameter.defaultBool = value;
            }
        }
        return parameters;
    }

    // The slimes' clips, the Slime Animator that follows the code's State, and
    // the purple slime's Override Controller (Chapters 6 and 8).
    static AnimatorController MakeSlimeAnimation(out AnimatorOverrideController purple)
    {
        AnimationClip[] green = MakeSlimeClips("Slime", greenSprites);
        AnimationClip[] purpleClips = MakeSlimeClips("Purple Slime", purpleSprites);

        AnimatorController controller = MakeController(AnimationFolder + "/Slime.controller");
        controller.AddParameter("State", AnimatorControllerParameterType.Int);
        string[] names = { "Patrol", "Chase", "WindUp", "Leap", "Hurt", "Dead" };
        AnimationClip[] motions = { green[0], green[0], green[1], green[2], green[3], green[4] };
        for (int i = 0; i < names.Length; i++)
        {
            float x = i % 3 * 260f + 300f;
            float y = i / 3 * 140f;
            AnimatorState state = AddState(controller, names[i], motions[i], new Vector2(x, y));
            if (names[i] == "Chase")
            {
                state.speed = 1.6f;     // the Move clip, played faster
            }
            if (i == 0)
            {
                controller.layers[0].stateMachine.defaultState = state;
            }
            AddAnyStateTransition(controller, state).AddCondition(AnimatorConditionMode.Equals, i, "State");
        }
        EditorUtility.SetDirty(controller);

        purple = MakeOverrideController(AnimationFolder + "/Purple Slime.overrideController", controller, green, purpleClips);
        return controller;
    }

    static AnimationClip[] MakeSlimeClips(string name, Sprite[] sheet)
    {
        AnimationClip move = MakeSpriteClip(ClipPath(name + " Move"), Range(sheet, 4, 7), 8f, true);
        AnimationClip windUp = MakeSpriteClip(ClipPath(name + " WindUp"), Frames(sheet, 3, 2, 1), 8f, false);
        SetEvents(windUp, new[] { 2f / 8f }, new[] { "OnLeap" });
        AnimationClip leap = MakeSpriteClip(ClipPath(name + " Leap"), Frames(sheet, 6), 8f, true);
        AnimationClip hurt = MakeSpriteClip(ClipPath(name + " Hurt"), Range(sheet, 8, 11), 10f, false);
        AnimationClip dead = MakeSpriteClip(ClipPath(name + " Dead"), Frames(sheet, 3, 2, 1, 0), 8f, false);
        SetColourCurve(dead, "", new[] { 0f, 0.5f, 1f }, new[] { Color.white, Color.white, new Color(1f, 1f, 1f, 0f) });
        SetEvents(dead, new[] { 1f }, new[] { "OnDeathFinished" });
        return new[] { move, windUp, leap, hurt, dead };
    }

    // The coin's one looping clip (Chapter 9).
    static AnimatorController MakeCoinAnimation()
    {
        AnimationClip spin = MakeSpriteClip(ClipPath("Coin Spin"), Range(coinSprites, 0, 11), 12f, true);
        AnimatorController controller = MakeController(AnimationFolder + "/Coin.controller");
        controller.layers[0].stateMachine.defaultState = AddState(controller, "Spin", spin, new Vector2(300f, 0f));
        EditorUtility.SetDirty(controller);
        return controller;
    }

    // The checkpoint's three clips: property curves only, on the signpost's
    // scale and rotation, and on its Sign child's colour (Chapter 9).
    static AnimatorController MakeCheckpointAnimation()
    {
        Color grey = new Color(0.55f, 0.55f, 0.6f, 1f);

        AnimationClip unlit = MakePropertyClip(ClipPath("Checkpoint Unlit"), 30f, true);
        SetCurve(unlit, "", typeof(Transform), "m_LocalScale.x", new[] { 0f, 1f }, new[] { 1f, 1f });
        SetCurve(unlit, "", typeof(Transform), "m_LocalScale.y", new[] { 0f, 1f }, new[] { 1f, 1f });
        SetCurve(unlit, "", typeof(Transform), "localEulerAnglesRaw.z", new[] { 0f, 1f }, new[] { 0f, 0f });
        SetColourCurve(unlit, "Sign", new[] { 0f, 1f }, new[] { grey, grey });

        AnimationClip lighting = MakePropertyClip(ClipPath("Checkpoint Lighting"), 30f, false);
        SetCurve(lighting, "", typeof(Transform), "m_LocalScale.x", new[] { 0f, 0.15f, 0.4f }, new[] { 1f, 1.3f, 1f });
        SetCurve(lighting, "", typeof(Transform), "m_LocalScale.y", new[] { 0f, 0.15f, 0.4f }, new[] { 1f, 1.3f, 1f });
        SetCurve(lighting, "", typeof(Transform), "localEulerAnglesRaw.z", new[] { 0f, 0.4f }, new[] { 0f, 0f });
        SetColourCurve(lighting, "Sign", new[] { 0f, 0.4f }, new[] { grey, Color.white });

        AnimationClip lit = MakePropertyClip(ClipPath("Checkpoint Lit"), 30f, true);
        SetCurve(lit, "", typeof(Transform), "m_LocalScale.x", new[] { 0f, 2f }, new[] { 1f, 1f });
        SetCurve(lit, "", typeof(Transform), "m_LocalScale.y", new[] { 0f, 2f }, new[] { 1f, 1f });
        SetCurve(lit, "", typeof(Transform), "localEulerAnglesRaw.z", new[] { 0f, 0.5f, 1f, 1.5f, 2f }, new[] { 0f, 4f, 0f, -4f, 0f });
        SetColourCurve(lit, "Sign", new[] { 0f, 2f }, new[] { Color.white, Color.white });

        AnimatorController controller = MakeController(AnimationFolder + "/Checkpoint.controller");
        controller.AddParameter("Lit", AnimatorControllerParameterType.Bool);
        AnimatorState unlitState = AddState(controller, "Unlit", unlit, new Vector2(300f, 0f));
        AnimatorState lightingState = AddState(controller, "Lighting", lighting, new Vector2(560f, 0f));
        AnimatorState litState = AddState(controller, "Lit", lit, new Vector2(820f, 0f));
        controller.layers[0].stateMachine.defaultState = unlitState;
        AddTransition(unlitState, lightingState, false).AddCondition(AnimatorConditionMode.If, 0f, "Lit");
        AddTransition(lightingState, litState, true);
        AddTransition(litState, unlitState, false).AddCondition(AnimatorConditionMode.IfNot, 0f, "Lit");
        EditorUtility.SetDirty(controller);
        return controller;
    }

    // ------------------------------------------------------------------ prefabs

    static GameObject MakeSlimePrefab(string name, Sprite sprite, RuntimeAnimatorController controller, int enemyLayer,
                                      int groundLayer, AudioClip squash, int health, float patrolSpeed, float chaseSpeed,
                                      float sightRange, float leapRange, Vector2 leapVelocity)
    {
        var go = new GameObject(name);
        go.layer = enemyLayer;
        var renderer = go.AddComponent<SpriteRenderer>();
        renderer.sprite = sprite;
        renderer.sortingOrder = 2;
        var body = go.AddComponent<Rigidbody2D>();
        body.bodyType = RigidbodyType2D.Dynamic;
        body.gravityScale = 3f;
        body.constraints = RigidbodyConstraints2D.FreezeRotation;
        body.interpolation = RigidbodyInterpolation2D.Interpolate;
        var box = go.AddComponent<BoxCollider2D>();
        box.size = new Vector2(0.8f, 0.65f);
        box.offset = new Vector2(0f, 0.325f);
        go.AddComponent<Animator>().runtimeAnimatorController = controller;
        go.AddComponent<AudioSource>().playOnAwake = false;
        var slime = go.AddComponent<Slime>();
        SetLayerMask(slime, "groundMask", LayerMask.LayerToName(groundLayer));
        Set(slime, "squashSound", squash);
        SetInt(slime, "maxHealth", health);
        SetFloat(slime, "patrolSpeed", patrolSpeed);
        SetFloat(slime, "chaseSpeed", chaseSpeed);
        SetFloat(slime, "sightRange", sightRange);
        SetFloat(slime, "leapRange", leapRange);
        SetVector2(slime, "leapVelocity", leapVelocity);
        return SavePrefab(go, name);
    }

    static GameObject MakeCoinPrefab(RuntimeAnimatorController controller)
    {
        var go = new GameObject("Coin");
        var renderer = go.AddComponent<SpriteRenderer>();
        renderer.sprite = coinSprites[0];
        renderer.sortingOrder = 3;
        var circle = go.AddComponent<CircleCollider2D>();
        circle.isTrigger = true;
        circle.radius = 0.3f;
        go.AddComponent<Animator>().runtimeAnimatorController = controller;
        go.AddComponent<Coin>();
        return SavePrefab(go, "Coin");
    }

    static GameObject MakeApplePrefab()
    {
        var go = new GameObject("Apple");
        var renderer = go.AddComponent<SpriteRenderer>();
        renderer.sprite = fruitSprites[9];     // the red apple
        renderer.sortingOrder = 3;
        var circle = go.AddComponent<CircleCollider2D>();
        circle.isTrigger = true;
        circle.radius = 0.35f;
        go.AddComponent<Apple>();
        return SavePrefab(go, "Apple");
    }

    // The signpost stands on its pivot, at the bottom, so it bounces and sways
    // from its foot. Its picture is a child, Sign, half a tile up.
    static GameObject MakeCheckpointPrefab(RuntimeAnimatorController controller)
    {
        var go = new GameObject("Checkpoint");
        var trigger = go.AddComponent<BoxCollider2D>();
        trigger.isTrigger = true;
        trigger.size = new Vector2(1f, 2f);
        trigger.offset = new Vector2(0f, 1f);
        go.AddComponent<Animator>().runtimeAnimatorController = controller;
        go.AddComponent<Checkpoint>();
        var sign = new GameObject("Sign");
        sign.transform.SetParent(go.transform, false);
        sign.transform.localPosition = new Vector3(0f, 0.5f, 0f);
        var renderer = sign.AddComponent<SpriteRenderer>();
        renderer.sprite = TileAt(new Vector2Int(8, 3)).sprite;
        renderer.sortingOrder = 1;
        return SavePrefab(go, "Checkpoint");
    }

    // A one-way platform: jump up through it, land on top (Chapters 2, 8 and 13).
    static GameObject MakePlatformPrefab(string name, Sprite sprite, int groundLayer)
    {
        var go = new GameObject(name);
        go.layer = groundLayer;
        var renderer = go.AddComponent<SpriteRenderer>();
        renderer.sprite = sprite;
        var box = go.AddComponent<BoxCollider2D>();
        box.size = new Vector2(2f, 0.5f);
        box.offset = new Vector2(0f, -0.25f);
        box.usedByEffector = true;
        var effector = go.AddComponent<PlatformEffector2D>();
        effector.useOneWay = true;
        effector.surfaceArc = 180f;
        return SavePrefab(go, name);
    }

    static GameObject SavePrefab(GameObject go, string name)
    {
        GameObject prefab = PrefabUtility.SaveAsPrefabAsset(go, PrefabFolder + "/" + name + ".prefab");
        Object.DestroyImmediate(go);
        return prefab;
    }

    // ------------------------------------------------------------------ the level

    static Look[] MakeLooks(int groundLayer)
    {
        var meadow = new Look
        {
            title = "The Meadow",
            sky = Hex("#8ED0F2"),
            groundTop = new Vector2Int(0, 0), groundFill = new Vector2Int(0, 1),
            liquidTop = new Vector2Int(4, 9), liquidFill = new Vector2Int(4, 10),
            platformPrefab = MakePlatformPrefab("Meadow Platform", platformSprites[1], groundLayer),
            decorations = new Dictionary<char, Vector3Int>
            {
                { 'T', new Vector3Int(0, 3, 3) }, { 'b', new Vector3Int(1, 4, 1) },
                { 'f', new Vector3Int(1, 6, 1) }, { 'n', new Vector3Int(8, 5, 1) },
            },
        };
        var woods = new Look
        {
            title = "The Autumn Woods",
            sky = Hex("#FAD3B3"),
            groundTop = new Vector2Int(4, 0), groundFill = new Vector2Int(4, 1),
            liquidTop = new Vector2Int(4, 11), liquidFill = new Vector2Int(4, 12),
            platformPrefab = MakePlatformPrefab("Woods Platform", platformSprites[5], groundLayer),
            decorations = new Dictionary<char, Vector3Int>
            {
                { 'T', new Vector3Int(5, 3, 3) }, { 'b', new Vector3Int(5, 7, 1) },
                { 'm', new Vector3Int(7, 5, 1) }, { 'n', new Vector3Int(8, 6, 1) },
                { 'k', new Vector3Int(4, 8, 1) },
            },
        };
        var castle = new Look
        {
            title = "The Castle Walls",
            sky = Hex("#6F2C77"),
            groundTop = new Vector2Int(7, 1), groundFill = new Vector2Int(6, 1),
            liquidTop = new Vector2Int(6, 9), liquidFill = new Vector2Int(6, 10),
            platformPrefab = MakePlatformPrefab("Castle Platform", platformSprites[7], groundLayer),
            decorations = new Dictionary<char, Vector3Int>
            {
                { 'T', new Vector3Int(6, 3, 3) }, { 'b', new Vector3Int(6, 7, 1) },
            },
        };
        return new[] { meadow, woods, castle };
    }

    // Paints one section of the map, and puts its slimes, coins, apples,
    // platforms and signs in their places. Row 0 of the map is y = 10.
    static void PaintSection(int section, List<string> map, Look look, Tilemap ground, Tilemap hazards, Tilemap decoration,
                             Transform platforms, Transform enemies, Transform pickups, Transform checkpoints,
                             GameObject greenSlime, GameObject purpleSlime, GameObject coinPrefab, GameObject applePrefab,
                             GameObject checkpointPrefab, List<Slime> slimes, List<Coin> coins, List<Checkpoint> checkpointList,
                             ref Vector3 knightStart, ref Vector3 doorPosition)
    {
        for (int row = 0; row < map.Count; row++)
        {
            string line = map[row];
            int y = MapTop - row;
            for (int column = 0; column < line.Length; column++)
            {
                char c = line[column];
                int x = section * SectionWidth + column;
                char above = row > 0 && column < map[row - 1].Length ? map[row - 1][column] : '.';
                Vector3Int cell = new Vector3Int(x, y, 0);
                switch (c)
                {
                    case '#':
                        ground.SetTile(cell, TileAt(above == '#' ? look.groundFill : look.groundTop));
                        break;
                    case '~':
                        hazards.SetTile(cell, TileAt(above == '~' ? look.liquidFill : look.liquidTop));
                        break;
                    case 'w':
                        bool isTop = above != 'w' && above != 'o';
                        decoration.SetTile(cell, TileAt(isTop ? new Vector2Int(7, 1) : new Vector2Int(8, 1)));
                        break;
                    case 'o':
                        decoration.SetTile(cell, TileAt(new Vector2Int(0, 15)));
                        break;
                    case 'D':
                        decoration.SetTile(cell, TileAt(new Vector2Int(0, 15)));
                        doorPosition = new Vector3(x + 1f, y + 1.3f, 0f);
                        break;
                    case '=':
                        bool isStart = column == 0 || line[column - 1] != '=' || IsSecondHalf(line, column - 1);
                        if (isStart)
                        {
                            Place(look.platformPrefab, platforms, new Vector3(x + 1f, y + 1f, 0f));
                        }
                        break;
                    case 'K':
                        knightStart = new Vector3(x + 0.5f, y, 0f);
                        break;
                    case 'C':
                        coins.Add(Place(coinPrefab, pickups, new Vector3(x + 0.5f, y + 0.5f, 0f)).GetComponent<Coin>());
                        break;
                    case 'A':
                        Place(applePrefab, pickups, new Vector3(x + 0.5f, y + 0.5f, 0f));
                        break;
                    case 's':
                        slimes.Add(Place(greenSlime, enemies, new Vector3(x + 0.5f, y, 0f)).GetComponent<Slime>());
                        break;
                    case 'p':
                        slimes.Add(Place(purpleSlime, enemies, new Vector3(x + 0.5f, y, 0f)).GetComponent<Slime>());
                        break;
                    case 'P':
                        checkpointList.Add(Place(checkpointPrefab, checkpoints, new Vector3(x + 0.5f, y, 0f)).GetComponent<Checkpoint>());
                        break;
                    default:
                        Vector3Int decor;
                        if (look.decorations.TryGetValue(c, out decor))
                        {
                            for (int h = 0; h < decor.z; h++)
                            {
                                // A tall tree's tiles, from its trunk up.
                                decoration.SetTile(new Vector3Int(x, y + h, 0), TileAt(new Vector2Int(decor.x, decor.y + decor.z - 1 - h)));
                            }
                        }
                        break;
                }
            }
        }
    }

    // In "====", the 2nd and 4th marks are second halves of platforms.
    static bool IsSecondHalf(string line, int column)
    {
        int run = 0;
        while (column - run >= 0 && line[column - run] == '=')
        {
            run++;
        }
        return run % 2 == 0;
    }

    static GameObject Place(GameObject prefab, Transform parent, Vector3 position)
    {
        var instance = (GameObject)PrefabUtility.InstantiatePrefab(prefab, parent);
        instance.transform.position = position;
        return instance;
    }

    static Tilemap MakeTilemap(Transform grid, string name, int order)
    {
        var go = new GameObject(name);
        go.transform.SetParent(grid, false);
        var tilemap = go.AddComponent<Tilemap>();
        go.AddComponent<TilemapRenderer>().sortingOrder = order;
        return tilemap;
    }

    static Transform MakeChild(Transform parent, string name, Vector3 localPosition)
    {
        var child = new GameObject(name).transform;
        child.SetParent(parent, false);
        child.localPosition = localPosition;
        return child;
    }

    // PlatformerGame's Section[] array: plain C# objects, filled in field by field.
    static void SetSections(PlatformerGame game, Look[] looks)
    {
        var serialized = new SerializedObject(game);
        SerializedProperty sections = serialized.FindProperty("sections");
        sections.arraySize = looks.Length;
        for (int i = 0; i < looks.Length; i++)
        {
            SerializedProperty element = sections.GetArrayElementAtIndex(i);
            element.FindPropertyRelative("title").stringValue = looks[i].title;
            element.FindPropertyRelative("startX").floatValue = i * SectionWidth;
            element.FindPropertyRelative("skyColour").colorValue = looks[i].sky;
        }
        serialized.ApplyModifiedPropertiesWithoutUndo();
    }

    static void SetVector2(Object target, string field, Vector2 value)
    {
        var serialized = new SerializedObject(target);
        SerializedProperty property = serialized.FindProperty(field);
        if (property == null)
        {
            Debug.LogError("No field '" + field + "' on " + target.GetType().Name);
            return;
        }
        property.vector2Value = value;
        serialized.ApplyModifiedPropertiesWithoutUndo();
    }

    // ------------------------------------------------------------------ UI

    static Sprite UiSprite()
    {
        return AssetDatabase.GetBuiltinExtraResource<Sprite>("UI/Skin/UISprite.psd");
    }

    static void PinToCorner(RectTransform rect, Vector2 corner, Vector2 position)
    {
        rect.anchorMin = corner;
        rect.anchorMax = corner;
        rect.pivot = corner;
        rect.anchoredPosition = position;
    }

    static TMP_Text MakePanelText(Transform window, string name, string text, float size, Vector2 position, Vector2 box, TMP_FontAsset font)
    {
        TMP_Text label = MakeText(window, name, text, size, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), position, box, Color.white);
        label.font = font;
        return label;
    }

    static Button MakePanelButton(Transform window, string name, string label, Vector2 position, Color colour, TMP_FontAsset font)
    {
        Button button = MakeButton(window, name, label, position, new Vector2(220f, 46f), colour);
        TMP_Text text = button.GetComponentInChildren<TMP_Text>();
        text.font = font;
        text.fontSize = 22f;
        text.color = Color.white;
        return button;
    }

    // A round touch button: a picture that takes presses, with a label.
    static GameObject MakeTouchButton(Transform parent, string name, string label, TMP_FontAsset font, Vector2 corner, Vector2 position)
    {
        Image image = MakeImage(parent, name, Hex("#FFFFFF", 0.3f), corner, position, new Vector2(200f, 200f));
        image.sprite = AssetDatabase.GetBuiltinExtraResource<Sprite>("UI/Skin/Knob.psd");
        image.raycastTarget = true;     // this one takes presses
        PinToCorner(image.rectTransform, corner, position);
        TMP_Text text = MakeText(image.transform, "Label", label, label.Length > 1 ? 44f : 110f, TextAlignmentOptions.Center,
                                 new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(200f, 200f), Color.white);
        text.font = font;
        return image.gameObject;
    }

    // Pointer Down holds the button, Pointer Up and Pointer Exit let it go.
    static void AddHoldTrigger(GameObject button, UnityAction<bool> setHeld)
    {
        var trigger = button.AddComponent<EventTrigger>();
        AddHoldEntry(trigger, EventTriggerType.PointerDown, setHeld, true);
        AddHoldEntry(trigger, EventTriggerType.PointerUp, setHeld, false);
        AddHoldEntry(trigger, EventTriggerType.PointerExit, setHeld, false);
    }

    static void AddPressTrigger(GameObject button, UnityAction press)
    {
        var trigger = button.AddComponent<EventTrigger>();
        EventTrigger.Entry entry = new EventTrigger.Entry { eventID = EventTriggerType.PointerDown };
        UnityEventTools.AddVoidPersistentListener(entry.callback, press);
        trigger.triggers.Add(entry);
    }

    static void AddHoldEntry(EventTrigger trigger, EventTriggerType type, UnityAction<bool> setHeld, bool value)
    {
        var entry = new EventTrigger.Entry { eventID = type };
        UnityEventTools.AddBoolPersistentListener(entry.callback, setHeld, value);
        trigger.triggers.Add(entry);
    }
}
