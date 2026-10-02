using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEditor;
using UnityEditor.Animations;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Tilemaps;
using UnityEngine.UI;
using static Level3BuilderKit;

// INSTRUCTOR TOOL: not part of the student book, and never shipped in a build.
// Menu: Tools → Crypt Keys (Level 3) → Build Scene
//
// Rebuilds Assets/Levels/Level3-CryptKeys/Scenes/CryptKeys.unity exactly as the
// Crypt Keys book describes it: the pixel-art import settings, pivots and
// slicing, the tiles, the floors' Random Rule Tiles and the Tile Palette, every
// clip with its Animation Events, the Humanoid controller with its four
// sub-state machines, the skeleton's and the archer's Override Controllers, the
// Skeleton King's extended copy, the prefabs, the six rooms painted from
// Editor/CryptKeysMap.txt, the 2D lights, the Pixel Perfect Camera and the whole
// UI, with every Inspector reference wired up. It also sets the 2D Renderer's
// Transparency Sort Mode, so what is lower on the screen draws in front. Use it
// to prepare lab machines or to reset a broken scene. Running it again
// overwrites the scene, the prefabs, the clips and the controllers; the font
// asset, the Rule Tiles and the Tile Palette are made once and kept.
public static class CryptKeysSceneBuilder
{
    const string Root = "Assets/Levels/Level3-CryptKeys";
    const string ScenePath = Root + "/Scenes/CryptKeys.unity";
    const string CharacterFolder = Root + "/Art/Characters";
    const string TilesetPath = Root + "/Art/Tiles/DungeonTileset.png";
    const string PropFolder = Root + "/Art/Props";
    const string UiFolder = Root + "/Art/UI";
    const string FontFolder = Root + "/Art/Fonts";
    const string AudioFolder = Root + "/Audio";
    const string AnimationFolder = Root + "/Animation";
    const string TileFolder = Root + "/Tiles";
    const string PrefabFolder = Root + "/Prefabs";
    const string MapPath = Root + "/Editor/CryptKeysMap.txt";

    const float PixelsPerUnit = 32f;
    const int RoomWidth = 19;
    const int RoomHeight = 11;
    const int DoorColumn = 9;
    const int BossDoorRoom = 4;             // the Chapel's door needs the boss key
    const int GoldPerPile = 25;

    // Direction 0 to 3, as the Animator's Direction parameter numbers them.
    static readonly string[] Directions = { "Down", "Left", "Up", "Right" };
    // The five states in each direction, and the file name of each one's sheet.
    static readonly string[] States = { "Idle", "Walk", "Attack", "Hurt", "Dead" };
    static readonly string[] SheetNames = { "Idle", "Walk", "Attack", "Hurt", "Death" };

    // ---- The sliced art (ImportArt)
    static readonly Dictionary<string, Sprite[]> sheets = new Dictionary<string, Sprite[]>();
    static readonly Dictionary<Vector2Int, Sprite> tileSprites = new Dictionary<Vector2Int, Sprite>();
    static readonly Dictionary<string, Sprite> props = new Dictionary<string, Sprite>();
    static Sprite[] chestSprites;
    static Sprite[] potionSprites;
    static Sprite[] goldSprites;
    static Sprite keySprite;
    static Sprite bossKeySprite;
    static Sprite arrowSprite;
    static Sprite panelSprite;
    static Sprite slotSprite;
    static Sprite buttonSprite;
    static Sprite buttonHighlightedSprite;
    static Sprite buttonPressedSprite;
    static Sprite heartFull;
    static Sprite heartHalf;
    static Sprite heartEmpty;
    static Sprite bossBarFrame;
    static Sprite bossBarBack;
    static Sprite bossBarFill;

    // ---- The tiles (MakeTiles)
    static readonly Dictionary<Vector2Int, Tile> tiles = new Dictionary<Vector2Int, Tile>();
    static RuleTile floorTile;
    static RuleTile tombFloorTile;

    // ---- What the rooms are painted with, and what they hold (PaintRoom)
    static Tilemap floorMap;
    static Tilemap decorationMap;
    static Tilemap wallMap;
    static Transform enemies;
    static Transform chests;
    static Transform doors;
    static Transform pickups;
    static Transform torches;
    static Transform decor;
    static Transform summonPointGroup;
    static GameObject skeletonPrefab;
    static GameObject archerPrefab;
    static GameObject kingPrefab;
    static GameObject chestPrefab;
    static GameObject doorPrefab;
    static GameObject keyPrefab;
    static GameObject bossKeyPrefab;
    static GameObject potionPrefab;
    static GameObject goldPrefab;
    static GameObject wallTorchPrefab;
    static GameObject standingTorchPrefab;
    static GameObject bannerPrefab;
    static GameObject statuePrefab;
    static GameObject shieldStatuePrefab;
    static GameObject pillarPrefab;
    static readonly List<Skeleton> skeletons = new List<Skeleton>();
    static readonly List<Archer> archers = new List<Archer>();
    static readonly List<Door> doorList = new List<Door>();
    static readonly List<Transform> summonPoints = new List<Transform>();
    static SkeletonKing king;
    static Vector3 heroStart;

    [MenuItem("Tools/Crypt Keys (Level 3)/Build Scene")]
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
        AssetDatabase.Refresh();

        int wallsLayer = AddLayer("Walls");
        int heroLayer = AddLayer("Hero");
        int enemyLayer = AddLayer("Enemy");
        IgnoreCollisions(enemyLayer, enemyLayer);       // skeletons, archers and arrows pass through each other
        SortByHeight();

        ImportArt();
        MakeTiles();
        TMP_FontAsset font = MakePixelFont();

        // ---- Animation (Chapters 3, 4, 6, 8, 9, 10, 13 and 14) ----
        AnimationClip[] heroClips = MakeCharacterClips("Hero");
        AnimationClip[] skeletonClips = MakeCharacterClips("Skeleton");
        AnimationClip[] archerClips = MakeCharacterClips("Archer");
        AnimationClip[] kingClips = MakeCharacterClips("King");
        AnimatorController humanoid = MakeHumanoid(AnimationFolder + "/Humanoid.controller", heroClips);
        AnimatorOverrideController skeletonController = MakeOverrideController(
            AnimationFolder + "/Skeleton Override.overrideController", humanoid, heroClips, skeletonClips);
        AnimatorOverrideController archerController = MakeOverrideController(
            AnimationFolder + "/Archer Override.overrideController", humanoid, heroClips, archerClips);
        AnimatorController kingController = MakeHumanoid(AnimationFolder + "/Skeleton King.controller", kingClips);
        AddKingStates(kingController);
        AnimatorController doorController = MakeDoorAnimation();
        AnimatorController chestController = MakeChestAnimation();
        AnimatorController torchController = MakeTorchAnimation();
        AnimatorController potionController = MakeLoopAnimation("Potion", potionSprites, 10f);
        AnimatorController goldController = MakeLoopAnimation("Gold", goldSprites, 10f);
        AnimatorController keyController = MakeKeyAnimation();

        // ---- Prefabs (Chapters 6, 8, 9, 10, 13 and 14) ----
        AudioClip hit = LoadClip(AudioFolder + "/Hit.wav");
        AudioClip bones = LoadClip(AudioFolder + "/Bones.wav");
        GameObject arrowPrefab = MakeArrowPrefab(enemyLayer);
        skeletonPrefab = MakeEnemyPrefab("Skeleton", sheets["SkeletonDownIdle"][0], skeletonController, enemyLayer, 1f);
        Skeleton skeletonScript = skeletonPrefab.GetComponent<Skeleton>();
        SetLayerMask(skeletonScript, "wallMask", "Walls");
        Set(skeletonScript, "hitSound", hit);
        Set(skeletonScript, "deathSound", bones);

        archerPrefab = MakeEnemyPrefab("Archer", sheets["ArcherDownIdle"][0], archerController, enemyLayer, 1f);
        Archer archerScript = archerPrefab.GetComponent<Archer>();
        Set(archerScript, "arrowPrefab", arrowPrefab.GetComponent<Arrow>());
        SetLayerMask(archerScript, "wallMask", "Walls");
        Set(archerScript, "shootSound", LoadClip(AudioFolder + "/Shoot.wav"));
        Set(archerScript, "hitSound", hit);
        Set(archerScript, "deathSound", bones);

        kingPrefab = MakeEnemyPrefab("Skeleton King", sheets["KingDownIdle"][0], kingController, enemyLayer, 5f);
        SkeletonKing kingScript = kingPrefab.GetComponent<SkeletonKing>();
        Set(kingScript, "swingSound", LoadClip(AudioFolder + "/Swing.wav"));
        Set(kingScript, "hitSound", hit);
        Set(kingScript, "summonSound", LoadClip(AudioFolder + "/Summon.wav"));
        Set(kingScript, "whirlwindSound", LoadClip(AudioFolder + "/Whirl.wav"));
        Set(kingScript, "deathSound", bones);

        chestPrefab = MakeChestPrefab(chestController);
        doorPrefab = MakeDoorPrefab(doorController);
        AudioClip keySound = LoadClip(AudioFolder + "/Key.wav");
        keyPrefab = MakeKeyPrefab("Key", keySprite, Pickup.Kind.Key, keyController, keySound);
        bossKeyPrefab = MakeKeyPrefab("Boss Key", bossKeySprite, Pickup.Kind.BossKey, keyController, keySound);
        potionPrefab = MakeLoopPickupPrefab("Potion", potionSprites[0], Pickup.Kind.Potion, potionController,
                                            LoadClip(AudioFolder + "/Potion.wav"));
        goldPrefab = MakeLoopPickupPrefab("Gold", goldSprites[0], Pickup.Kind.Gold, goldController,
                                          LoadClip(AudioFolder + "/Gold.wav"));
        SetInt(goldPrefab.GetComponent<Pickup>(), "gold", GoldPerPile);
        wallTorchPrefab = MakeTorchPrefab("Wall Torch", props["Wall Torch"], torchController, 0.7f, wallsLayer, false);
        standingTorchPrefab = MakeTorchPrefab("Standing Torch", props["Standing Torch"], torchController, 1.15f, wallsLayer, true);
        bannerPrefab = MakePropPrefab("Banner", props["Banner"], Vector2.zero, wallsLayer);
        statuePrefab = MakePropPrefab("Statue", props["Statue"], new Vector2(0.7f, 0.35f), wallsLayer);
        shieldStatuePrefab = MakePropPrefab("Shield Statue", props["Shield Statue"], new Vector2(0.7f, 0.35f), wallsLayer);
        pillarPrefab = MakePropPrefab("Pillar", props["Pillar"], new Vector2(1f, 0.6f), wallsLayer);

        var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);

        // ---- The camera: one room at a time, pixel perfect (Chapters 2 and 12) ----
        var cameraObject = new GameObject("Main Camera");
        cameraObject.tag = "MainCamera";
        var cam = cameraObject.AddComponent<Camera>();
        cam.orthographic = true;
        cam.orthographicSize = RoomHeight / 2f;
        cam.clearFlags = CameraClearFlags.SolidColor;
        cam.backgroundColor = Color.black;
        cameraObject.AddComponent<AudioListener>();
        var pixelPerfect = cameraObject.AddComponent<PixelPerfectCamera>();
        pixelPerfect.assetsPPU = 32;
        pixelPerfect.refResolutionX = 640;      // 20 tiles across
        pixelPerfect.refResolutionY = 352;      // 11 tiles: one room exactly
        pixelPerfect.cropFrame = PixelPerfectCamera.CropFrame.Letterbox;
        pixelPerfect.gridSnapping = PixelPerfectCamera.GridSnapping.UpscaleRenderTexture;
        var roomCamera = cameraObject.AddComponent<RoomCamera>();
        cameraObject.transform.position = new Vector3(RoomCentre(0).x, RoomCentre(0).y, -10f);

        // ---- The dark (Chapter 14) ----
        var lightObject = new GameObject("Global Light 2D");
        var globalLight = lightObject.AddComponent<Light2D>();
        globalLight.lightType = Light2D.LightType.Global;
        globalLight.intensity = 0.35f;
        globalLight.color = Hex("#A7B0D8");

        // ---- The crypt: the Grid and its three Tilemaps (Chapter 1) ----
        var gridObject = new GameObject("Grid");
        gridObject.AddComponent<Grid>().cellSize = new Vector3(1f, 1f, 0f);
        floorMap = MakeTilemap(gridObject.transform, "Floor", -30);
        decorationMap = MakeTilemap(gridObject.transform, "Decoration", -25);
        wallMap = MakeTilemap(gridObject.transform, "Walls", -20);
        wallMap.gameObject.layer = wallsLayer;
        var wallBody = wallMap.gameObject.AddComponent<Rigidbody2D>();
        wallBody.bodyType = RigidbodyType2D.Static;
        var wallCollider = wallMap.gameObject.AddComponent<TilemapCollider2D>();
        wallCollider.compositeOperation = Collider2D.CompositeOperation.Merge;
        var composite = wallMap.gameObject.AddComponent<CompositeCollider2D>();
        composite.geometryType = CompositeCollider2D.GeometryType.Polygons;

        // ---- The hero (Chapters 2 to 5 and 7) ----
        var heroObject = new GameObject("Hero");
        heroObject.layer = heroLayer;
        var heroRenderer = heroObject.AddComponent<SpriteRenderer>();
        heroRenderer.sprite = sheets["HeroUpIdle"][0];
        heroRenderer.spriteSortPoint = SpriteSortPoint.Pivot;
        var heroBody = heroObject.AddComponent<Rigidbody2D>();
        SetUpBody(heroBody, 1f);
        AddFeetCollider(heroObject, 0.55f);
        heroObject.AddComponent<Animator>().runtimeAnimatorController = humanoid;
        heroObject.AddComponent<AudioSource>().playOnAwake = false;
        var hero = heroObject.AddComponent<Hero>();
        var heroCombat = heroObject.AddComponent<HeroCombat>();
        var heroHealth = heroObject.AddComponent<HeroHealth>();
        var inventory = heroObject.AddComponent<Inventory>();
        AddPointLight(MakeChild(heroObject.transform, "Light", new Vector3(0f, 0.5f, 0f)), Hex("#FFE3B8"), 0.6f, 3f);

        // ---- The game, and the groups that hold the crypt's things (Chapters 6, 9, 10 and 12) ----
        var gameHolder = new GameObject("Crypt Game");
        var game = gameHolder.AddComponent<CryptGame>();
        var soundSource = gameHolder.AddComponent<AudioSource>();
        soundSource.playOnAwake = false;
        var musicSource = gameHolder.AddComponent<AudioSource>();
        musicSource.playOnAwake = false;
        musicSource.loop = true;
        musicSource.volume = 0.5f;

        enemies = new GameObject("Enemies").transform;
        chests = new GameObject("Chests").transform;
        doors = new GameObject("Doors").transform;
        pickups = new GameObject("Pickups").transform;
        torches = new GameObject("Torches").transform;
        decor = new GameObject("Statues and Banners").transform;
        Transform arrows = new GameObject("Arrows").transform;
        Transform summoned = new GameObject("Summoned").transform;
        summonPointGroup = new GameObject("Summon Points").transform;

        // ---- Paint the six rooms, and put everything in its place ----
        skeletons.Clear();
        archers.Clear();
        doorList.Clear();
        summonPoints.Clear();
        king = null;
        heroStart = Vector3.zero;
        var titles = new List<string>();
        var rooms = new List<List<string>>();
        foreach (string line in File.ReadAllLines(MapPath))
        {
            if (line.StartsWith("# "))      // a room's heading, such as "# The Crypt Gate"
            {
                titles.Add(line.Substring(2));
                rooms.Add(new List<string>());
            }
            else if (line.Length > 0)
            {
                rooms[rooms.Count - 1].Add(line);
            }
        }
        for (int i = 0; i < rooms.Count; i++)
        {
            PaintRoom(i, rooms[i]);
        }

        // The Editor builds the tilemap's collider shapes a moment after
        // painting. The scene is saved before that moment, so build them now:
        // a Composite Collider saved with no shapes stays empty in Play mode.
        wallCollider.ProcessTilemapChanges();
        composite.GenerateGeometry();

        heroObject.transform.position = heroStart;

        // The template the king copies when he summons: a whole skeleton,
        // switched off, that sees further than the others (Chapter 13).
        GameObject templateObject = Place(skeletonPrefab, null, new Vector3(RoomCentre(rooms.Count - 1).x, RoomCentre(rooms.Count - 1).y, 0f));
        templateObject.name = "Skeleton Template";
        templateObject.SetActive(false);
        Keep(templateObject);
        Skeleton template = templateObject.GetComponent<Skeleton>();
        SetFloat(template, "sightRange", 12f);

        // ---- The screen (Chapters 11 and 12) ----
        Transform ui = MakeCanvas("Canvas");
        Color ink = Hex("#F2E8D5");

        // The hearts, the keys and the gold, along the top
        RectTransform heartRow = MakeRect(ui, "Hearts", new Vector2(0f, 1f), new Vector2(40f, -40f), new Vector2(180f, 48f));
        var heartsBar = heartRow.gameObject.AddComponent<HeartsBar>();
        var heartImages = new Image[3];
        for (int i = 0; i < heartImages.Length; i++)
        {
            heartImages[i] = MakeImage(heartRow, "Heart " + (i + 1), Color.white, new Vector2(0f, 0.5f),
                                       new Vector2(i * 62f, 0f), new Vector2(52f, 48f));
            heartImages[i].sprite = heartFull;
        }
        Image keyIcon = MakeIcon(ui, "Key Icon", keySprite, new Vector2(250f, -32f));
        TMP_Text keyText = MakeHudText(ui, "Key Text", "x 0", new Vector2(320f, -40f), new Vector2(110f, 56f), font, ink);
        Image bossKeyIcon = MakeIcon(ui, "Boss Key Icon", bossKeySprite, new Vector2(440f, -32f));
        bossKeyIcon.enabled = false;
        Image goldIcon = MakeIcon(ui, "Gold Icon", goldSprites[0], new Vector2(540f, -32f));
        TMP_Text goldText = MakeHudText(ui, "Gold Text", "0", new Vector2(610f, -40f), new Vector2(160f, 56f), font, ink);

        // The potion slots, bottom left: tap one to drink
        var potionIcons = new Image[Inventory.MaxPotions];
        var potionButtons = new Button[Inventory.MaxPotions];
        for (int i = 0; i < potionIcons.Length; i++)
        {
            Image slot = MakeImage(ui, "Potion Slot " + (i + 1), Color.white, new Vector2(0f, 0f),
                                   new Vector2(30f + i * 110f, 30f), new Vector2(96f, 96f));
            slot.sprite = slotSprite;
            slot.raycastTarget = true;      // this one takes presses
            potionButtons[i] = slot.gameObject.AddComponent<Button>();
            potionButtons[i].targetGraphic = slot;
            potionIcons[i] = MakeImage(slot.transform, "Potion", Color.white, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(64f, 64f));
            potionIcons[i].sprite = potionSprites[0];
            potionIcons[i].enabled = false;
        }

        // The room's name, a message line, and the pause button
        TMP_Text roomText = MakeText(ui, "Room Text", "", 64f, TextAlignmentOptions.Center,
                                     new Vector2(0.5f, 1f), new Vector2(0f, -185f), new Vector2(1200f, 100f), ink);
        roomText.font = font;
        TMP_Text messageText = MakeText(ui, "Message Text", "", 40f, TextAlignmentOptions.Center,
                                        new Vector2(0.5f, 0f), new Vector2(0f, 210f), new Vector2(1200f, 70f), ink);
        messageText.font = font;
        Button pauseButton = MakeButton(ui, "Pause Button", "II", Vector2.zero, new Vector2(96f, 96f), Color.white);
        pauseButton.GetComponent<Image>().sprite = slotSprite;
        pauseButton.GetComponent<Image>().type = Image.Type.Simple;
        TMP_Text pauseLabel = pauseButton.GetComponentInChildren<TMP_Text>();
        pauseLabel.font = font;
        pauseLabel.fontSize = 44f;
        pauseLabel.color = ink;
        PinToCorner((RectTransform)pauseButton.transform, new Vector2(1f, 1f), new Vector2(-30f, -30f));

        // The boss bar, bottom middle: shown only in the King's Tomb (Chapter 13)
        RectTransform bossRect = MakeRect(ui, "Boss Bar", new Vector2(0.5f, 0f), new Vector2(0f, 50f), new Vector2(456f, 96f));
        var bossBar = bossRect.gameObject.AddComponent<BossBar>();
        TMP_Text bossName = MakeText(bossRect, "Name", "The Skeleton King", 36f, TextAlignmentOptions.Center,
                                     new Vector2(0.5f, 1f), Vector2.zero, new Vector2(456f, 50f), ink);
        bossName.font = font;
        MakeBarImage(bossRect, "Back", bossBarBack);
        Image bossFill = MakeBarImage(bossRect, "Fill", bossBarFill);
        bossFill.type = Image.Type.Filled;
        bossFill.fillMethod = Image.FillMethod.Horizontal;
        bossFill.fillOrigin = (int)Image.OriginHorizontal.Left;
        MakeBarImage(bossRect, "Frame", bossBarFrame);
        bossRect.gameObject.SetActive(false);

        // Start panel: the title, how to play, and Play (Chapter 11)
        GameObject startPanel;
        RectTransform startWindow = MakeStoneWindow(ui, "Start Panel", new Vector2(640f, 360f), out startPanel);
        MakePanelText(startWindow, "Title", "Crypt Keys", 44f, new Vector2(0f, 125f), new Vector2(600f, 60f), font);
        MakePanelText(startWindow, "How To Play",
                      "Walk: W A S D, or hold the mouse or a finger down\n" +
                      "Attack: Space, or a quick tap    Open a chest: E\n" +
                      "Drink a potion: Q, or tap it\n\n" +
                      "Find the keys, open the doors,\nand defeat the Skeleton King!",
                      15f, new Vector2(0f, 20f), new Vector2(600f, 150f), font);
        Button playButton = MakePanelButton(startWindow, "Play Button", "Play", new Vector2(0f, -125f), font);

        // Pause panel: Resume, Restart and the volume (Chapter 12)
        GameObject pausePanel;
        RectTransform pauseWindow = MakeStoneWindow(ui, "Pause Panel", new Vector2(460f, 330f), out pausePanel);
        MakePanelText(pauseWindow, "Title", "Paused", 36f, new Vector2(0f, 115f), new Vector2(420f, 60f), font);
        Button resumeButton = MakePanelButton(pauseWindow, "Resume Button", "Resume", new Vector2(0f, 45f), font);
        Button restartButton = MakePanelButton(pauseWindow, "Restart Button", "Restart", new Vector2(0f, -10f), font);
        MakePanelText(pauseWindow, "Volume Label", "Volume", 16f, new Vector2(-120f, -90f), new Vector2(140f, 30f), font);
        Slider volumeSlider = MakeSlider(pauseWindow, "Volume Slider", new Vector2(60f, -90f), 220f);
        volumeSlider.value = 1f;
        var pauseMenu = pausePanel.AddComponent<PauseMenu>();

        // Win panel: the gold and the time, and Play Again (Chapter 11)
        GameObject winPanel;
        RectTransform winWindow = MakeStoneWindow(ui, "Win Panel", new Vector2(560f, 330f), out winPanel);
        TMP_Text winText = MakePanelText(winWindow, "Win Text", "The Skeleton King has fallen!", 22f,
                                         new Vector2(0f, 40f), new Vector2(520f, 220f), font);
        Button playAgainButton = MakePanelButton(winWindow, "Play Again Button", "Play Again", new Vector2(0f, -115f), font);

        // Lose panel: Try Again (Chapter 11)
        GameObject losePanel;
        RectTransform loseWindow = MakeStoneWindow(ui, "Lose Panel", new Vector2(560f, 260f), out losePanel);
        MakePanelText(loseWindow, "Title", "The hero has fallen", 28f, new Vector2(0f, 45f), new Vector2(520f, 100f), font);
        Button tryAgainButton = MakePanelButton(loseWindow, "Try Again Button", "Try Again", new Vector2(0f, -70f), font);

        pausePanel.SetActive(false);
        winPanel.SetActive(false);
        losePanel.SetActive(false);

        // ---- Wire up every Inspector reference ----
        Set(hero, "game", game);
        SetLayerMask(heroCombat, "enemyMask", "Enemy");
        Set(heroCombat, "swingSound", LoadClip(AudioFolder + "/Swing.wav"));
        Set(heroCombat, "clangSound", LoadClip(AudioFolder + "/Clang.wav"));
        Set(heroHealth, "game", game);
        Set(heroHealth, "hearts", heartsBar);
        Set(heroHealth, "hurtSound", LoadClip(AudioFolder + "/Hurt.wav"));
        Set(heroHealth, "healSound", LoadClip(AudioFolder + "/Heal.wav"));
        Set(inventory, "health", heroHealth);
        Set(inventory, "keyText", keyText);
        Set(inventory, "bossKeyIcon", bossKeyIcon);
        Set(inventory, "goldText", goldText);
        SetArray(inventory, "potionIcons", potionIcons);
        SetArray(inventory, "potionButtons", potionButtons);

        foreach (Skeleton skeleton in skeletons)
        {
            Set(skeleton, "game", game);
            Set(skeleton, "hero", heroHealth);
        }
        Set(template, "game", game);
        Set(template, "hero", heroHealth);
        foreach (Archer archer in archers)
        {
            Set(archer, "game", game);
            Set(archer, "hero", heroHealth);
            Set(archer, "arrowGroup", arrows);
        }
        Set(king, "game", game);
        Set(king, "hero", heroHealth);
        Set(king, "bossBar", bossBar);
        Set(king, "skeletonTemplate", template);
        SetArray(king, "summonPoints", summonPoints.ToArray());
        Set(king, "summonGroup", summoned);
        foreach (Door door in doorList)
        {
            Set(door, "game", game);
        }

        SetArray(heartsBar, "hearts", heartImages);
        Set(heartsBar, "fullHeart", heartFull);
        Set(heartsBar, "halfHeart", heartHalf);
        Set(heartsBar, "emptyHeart", heartEmpty);
        Set(bossBar, "fill", bossFill);

        Set(game, "hero", hero);
        Set(game, "heroHealth", heroHealth);
        Set(game, "heroCombat", heroCombat);
        Set(game, "inventory", inventory);
        Set(game, "roomCamera", roomCamera);
        SetRooms(game, titles);
        SetFloat(game, "roomHeight", RoomHeight);
        Set(game, "king", king);
        Set(game, "enemies", enemies);
        Set(game, "chests", chests);
        Set(game, "doors", doors);
        Set(game, "pickups", pickups);
        Set(game, "arrows", arrows);
        Set(game, "roomText", roomText);
        Set(game, "messageText", messageText);
        Set(game, "startPanel", startPanel);
        Set(game, "playButton", playButton);
        Set(game, "pauseButton", pauseButton);
        Set(game, "pausePanel", pausePanel);
        Set(game, "winPanel", winPanel);
        Set(game, "winText", winText);
        Set(game, "playAgainButton", playAgainButton);
        Set(game, "losePanel", losePanel);
        Set(game, "tryAgainButton", tryAgainButton);
        Set(game, "soundSource", soundSource);
        Set(game, "musicSource", musicSource);
        Set(game, "cryptMusic", LoadClip(AudioFolder + "/Crypt.ogg"));
        Set(game, "fightMusic", LoadClip(AudioFolder + "/Fight.ogg"));
        Set(game, "winSound", LoadClip(AudioFolder + "/Win.wav"));
        Set(game, "loseSound", LoadClip(AudioFolder + "/Lose.wav"));

        Set(pauseMenu, "game", game);
        Set(pauseMenu, "resumeButton", resumeButton);
        Set(pauseMenu, "restartButton", restartButton);
        Set(pauseMenu, "volumeSlider", volumeSlider);

        AssetDatabase.SaveAssets();
        SaveScene(scene, ScenePath);
        Debug.Log("Crypt Keys scene built: " + ScenePath);
    }

    // ------------------------------------------------------------------ project settings

    // Lower on the screen draws in front (Chapter 2): every 2D Renderer's
    // Transparency Sort Mode is Custom Axis, along (0, 1, 0).
    static void SortByHeight()
    {
        string[] guids = AssetDatabase.FindAssets("t:Renderer2DData");
        if (guids.Length == 0)
        {
            Debug.LogWarning("No 2D Renderer asset found: set its Transparency Sort Mode to Custom Axis (0, 1, 0) by hand.");
        }
        foreach (string guid in guids)
        {
            Object rendererData = AssetDatabase.LoadAssetAtPath<Object>(AssetDatabase.GUIDToAssetPath(guid));
            var serialized = new SerializedObject(rendererData);
            serialized.FindProperty("m_TransparencySortMode").intValue = (int)TransparencySortMode.CustomAxis;
            serialized.FindProperty("m_TransparencySortAxis").vector3Value = new Vector3(0f, 1f, 0f);
            serialized.ApplyModifiedPropertiesWithoutUndo();
        }
    }

    // ------------------------------------------------------------------ art

    // Every sheet as pixel art. The characters are at 32 Pixels Per Unit, so
    // a 32-pixel tile is one unit, with the pivot at their feet: 8 pixels up,
    // in the middle of the frame. The king's bigger frames have the same
    // 48-pixel figure in their middle, so their pivots are 8 pixels further
    // from each edge for every 16 pixels more.
    static void ImportArt()
    {
        sheets.Clear();
        foreach (string character in new[] { "Hero", "Skeleton", "Archer", "King" })
        {
            foreach (string direction in Directions)
            {
                foreach (string sheetName in SheetNames)
                {
                    string name = character + direction + sheetName;
                    int cell = character == "King" && sheetName == "Attack" ? 64 : 48;
                    sheets[name] = ImportSpriteSheet(CharacterFolder + "/" + character + "/" + name + ".png",
                                                     cell, cell, PixelsPerUnit, FeetPivot(cell));
                }
            }
        }
        sheets["KingSummon"] = ImportSpriteSheet(CharacterFolder + "/King/KingSummon.png", 64, 64, PixelsPerUnit, FeetPivot(64));
        sheets["KingWhirlwind"] = ImportSpriteSheet(CharacterFolder + "/King/KingWhirlwind.png", 128, 128, PixelsPerUnit, FeetPivot(128));

        ImportTileset();

        // 0x72's chest is drawn for 16-pixel tiles: at 16 Pixels Per Unit it's one tile.
        chestSprites = ImportSpriteSheet(PropFolder + "/Chest.png", 16, 16, 16f, new Vector2(0.5f, 0f));
        Vector2 middle = new Vector2(0.5f, 0.5f);
        potionSprites = ImportSpriteSheet(PropFolder + "/Potion.png", 16, 16, PixelsPerUnit, middle);
        goldSprites = ImportSpriteSheet(PropFolder + "/Gold.png", 16, 16, PixelsPerUnit, middle);
        keySprite = ImportSprite(PropFolder + "/Key.png", PixelsPerUnit, middle);
        bossKeySprite = ImportSprite(PropFolder + "/BossKey.png", PixelsPerUnit, middle);
        arrowSprite = ImportSprite(PropFolder + "/Arrow.png", PixelsPerUnit, middle);

        // The UI's pictures, at 100 Pixels Per Unit, the Canvas's own. The
        // panel, the slot and the buttons have 9-slice borders, so they
        // stretch without stretching their edges.
        panelSprite = ImportSprite(UiFolder + "/Panel.png", 100f, middle, new Vector4(5f, 5f, 5f, 5f));
        slotSprite = ImportSprite(UiFolder + "/Slot.png", 100f, middle, new Vector4(7f, 7f, 7f, 7f));
        Vector4 buttonBorder = new Vector4(9f, 8f, 9f, 8f);
        buttonSprite = ImportSprite(UiFolder + "/Button.png", 100f, middle, buttonBorder);
        buttonHighlightedSprite = ImportSprite(UiFolder + "/ButtonHighlighted.png", 100f, middle, buttonBorder);
        buttonPressedSprite = ImportSprite(UiFolder + "/ButtonPressed.png", 100f, middle, buttonBorder);
        heartFull = ImportSprite(UiFolder + "/HeartFull.png", 100f, middle);
        heartHalf = ImportSprite(UiFolder + "/HeartHalf.png", 100f, middle);
        heartEmpty = ImportSprite(UiFolder + "/HeartEmpty.png", 100f, middle);

        // The boss bar's sheet holds three strips, each 76 × 6: its frame,
        // the dark bar behind, and the red bar that empties.
        Sprite[] bar = ImportSpriteCuts(UiFolder + "/BossBar.png", new[]
        {
            new SpriteCut("Boss Bar Frame", new Rect(0f, 11f, 76f, 6f), middle),
            new SpriteCut("Boss Bar Back", new Rect(0f, 5f, 76f, 6f), middle),
            new SpriteCut("Boss Bar Fill", new Rect(0f, 0f, 76f, 6f), middle),
        }, 100f);
        bossBarFrame = bar[0];
        bossBarBack = bar[1];
        bossBarFill = bar[2];
    }

    // A pivot at the feet of a figure in the middle of a square frame.
    static Vector2 FeetPivot(int cell)
    {
        float margin = (cell - 48) / 2f;
        return new Vector2(0.5f, (margin + 8f) / cell);
    }

    // The dungeon tileset: sliced 32 × 32 for the tiles, then a rectangle cut
    // around each tall prop, named, with its pivot at its foot, so it sorts
    // by where it stands (Chapters 1, 6 and 9).
    static void ImportTileset()
    {
        List<Rect> cells = GridCells(TilesetPath, 32, 32);
        var cuts = new List<SpriteCut>();
        for (int i = 0; i < cells.Count; i++)
        {
            cuts.Add(new SpriteCut("DungeonTileset_" + i, cells[i], new Vector2(0.5f, 0.5f)));
        }
        Vector2 foot = new Vector2(0.5f, 0f);
        cuts.Add(new SpriteCut("Wall Torch", new Rect(488f, 208f, 16f, 32f), foot));
        cuts.Add(new SpriteCut("Standing Torch", new Rect(512f, 192f, 32f, 48f), new Vector2(0.5f, 2f / 48f)));
        cuts.Add(new SpriteCut("Banner", new Rect(480f, 128f, 32f, 64f), foot));
        cuts.Add(new SpriteCut("Statue", new Rect(416f, 96f, 32f, 32f), foot));
        cuts.Add(new SpriteCut("Shield Statue", new Rect(448f, 96f, 32f, 32f), foot));
        cuts.Add(new SpriteCut("Pillar", new Rect(160f, 32f, 32f, 72f), foot));
        // The arched door, whole, and its two leaves. Each leaf's pivot is
        // its hinge, at the door's edge: 3 pixels in from the left, and 3 in
        // from the right.
        cuts.Add(new SpriteCut("Door", new Rect(608f, 190f, 32f, 64f), foot));
        cuts.Add(new SpriteCut("Door Left", new Rect(608f, 190f, 16f, 64f), new Vector2(3f / 16f, 0f)));
        cuts.Add(new SpriteCut("Door Right", new Rect(624f, 190f, 16f, 64f), new Vector2(13f / 16f, 0f)));
        Sprite[] sprites = ImportSpriteCuts(TilesetPath, cuts.ToArray(), PixelsPerUnit);

        int height = AssetDatabase.LoadAssetAtPath<Texture2D>(TilesetPath).height;
        tileSprites.Clear();
        props.Clear();
        for (int i = 0; i < cells.Count; i++)
        {
            int column = Mathf.RoundToInt(cells[i].x) / 32;
            int row = (height - Mathf.RoundToInt(cells[i].y)) / 32 - 1;
            tileSprites[new Vector2Int(column, row)] = sprites[i];
        }
        for (int i = cells.Count; i < cuts.Count; i++)
        {
            props[cuts[i].name] = sprites[i];
        }
    }

    // One Tile asset for every tile in the tileset, as dragging the sliced
    // tileset into the Tile Palette makes; the floors' two Random Rule Tiles;
    // and the palette. The seven tiles the walls are painted with, the dark
    // (column 3, row 0) and the wall's face (columns 4 to 6, rows 0 and 1),
    // get Grid colliders: one whole square each, for the Composite Collider
    // to merge. Every other tile has none.
    static void MakeTiles()
    {
        tiles.Clear();
        var paletteTiles = new List<TileBase>();
        var cells = new List<Vector3Int>();
        foreach (KeyValuePair<Vector2Int, Sprite> pair in tileSprites)
        {
            Vector2Int cell = pair.Key;
            bool isWall = cell.x >= 3 && cell.x <= 6 && cell.y <= 1;
            Tile tile = MakeTile(TileFolder + "/" + pair.Value.name + ".asset", pair.Value,
                                 isWall ? Tile.ColliderType.Grid : Tile.ColliderType.None);
            tiles[cell] = tile;
            paletteTiles.Add(tile);
            cells.Add(new Vector3Int(cell.x, -cell.y, 0));
        }

        // The stone floor: plain squares most of the time, sometimes cracked,
        // now and then badly cracked. The tomb's floor: dark squares, and now
        // and then dark cobbles or one big slab.
        floorTile = MakeRandomRuleTile(TileFolder + "/Floor.asset", new[]
        {
            TileSprite(2, 5), TileSprite(1, 5), TileSprite(0, 5), TileSprite(0, 5), TileSprite(1, 5), TileSprite(2, 5),
        }, 0.5f);
        tombFloorTile = MakeRandomRuleTile(TileFolder + "/Tomb Floor.asset", new[]
        {
            TileSprite(16, 7), TileSprite(15, 7), TileSprite(15, 7), TileSprite(15, 7), TileSprite(17, 7),
        }, 0.5f);
        paletteTiles.Add(floorTile);
        cells.Add(new Vector3Int(0, -9, 0));
        paletteTiles.Add(tombFloorTile);
        cells.Add(new Vector3Int(1, -9, 0));
        MakeTilePalette(TileFolder, "Crypt Palette", paletteTiles.ToArray(), cells.ToArray());
    }

    static Sprite TileSprite(int column, int row)
    {
        Sprite sprite;
        if (!tileSprites.TryGetValue(new Vector2Int(column, row), out sprite))
        {
            Debug.LogError("No tile at column " + column + ", row " + row + " of the tileset");
        }
        return sprite;
    }

    static Tile TileAt(int column, int row)
    {
        Tile tile;
        if (!tiles.TryGetValue(new Vector2Int(column, row), out tile))
        {
            Debug.LogError("No tile at column " + column + ", row " + row + " of the tileset");
        }
        return tile;
    }

    // The RPG UI's pixel font as a TextMeshPro font asset, with a dark
    // outline on its material, so it reads on the dark crypt (Chapter 11).
    static TMP_FontAsset MakePixelFont()
    {
        TMP_FontAsset font = MakeFontAsset(FontFolder + "/PixelRpgFont.ttf", FontFolder + "/PixelRpgFont SDF.asset");
        Material material = font.material;
        material.SetFloat("_OutlineWidth", 0.2f);
        material.SetColor("_OutlineColor", Hex("#120E12"));
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

    static string ClipPath(string name)
    {
        return AnimationFolder + "/" + name + ".anim";
    }

    // A character's 20 clips: Idle, Walk, Attack, Hurt and Dead in each
    // direction, in the order [direction * 5 + state] (Chapter 3). The attack
    // clips call OnAttackHit on their hit frames; the Dead clips hold their
    // last frame, fade out, and call OnDeathFinished at the end.
    static AnimationClip[] MakeCharacterClips(string character)
    {
        float walkRate = character == "Hero" ? 12f : 10f;
        float attackRate = 12f;
        float[] hitFrames = { 2f };             // the hero's slash
        if (character == "Skeleton")
        {
            hitFrames = new[] { 6f };           // the skeleton's slash
        }
        else if (character == "Archer")
        {
            hitFrames = new[] { 8f };           // the arrow leaves the bow
        }
        else if (character == "King")
        {
            attackRate = 10f;
            hitFrames = new[] { 3f, 8f };       // his two slashes
        }
        float deadRate = character == "Hero" ? 8f : 10f;

        var clips = new AnimationClip[20];
        for (int d = 0; d < Directions.Length; d++)
        {
            string prefix = character + " " + Directions[d] + " ";
            string sheet = character + Directions[d];
            clips[d * 5] = MakeSpriteClip(ClipPath(prefix + "Idle"), sheets[sheet + "Idle"], 8f, true);
            clips[d * 5 + 1] = MakeSpriteClip(ClipPath(prefix + "Walk"), sheets[sheet + "Walk"], walkRate, true);

            AnimationClip attack = MakeSpriteClip(ClipPath(prefix + "Attack"), sheets[sheet + "Attack"], attackRate, false);
            var hitTimes = new float[hitFrames.Length];
            var hitNames = new string[hitFrames.Length];
            for (int i = 0; i < hitFrames.Length; i++)
            {
                hitTimes[i] = hitFrames[i] / attackRate;
                hitNames[i] = "OnAttackHit";
            }
            SetEvents(attack, hitTimes, hitNames);
            clips[d * 5 + 2] = attack;

            clips[d * 5 + 3] = MakeSpriteClip(ClipPath(prefix + "Hurt"), sheets[sheet + "Hurt"], 10f, false);

            // Half a second still, then half a second fading: times on the
            // clip's own frames, as the Animation window places keyframes.
            Sprite[] deathFrames = sheets[sheet + "Death"];
            AnimationClip dead = MakeSpriteClip(ClipPath(prefix + "Dead"), deathFrames, deadRate, false);
            float fallen = deathFrames.Length / deadRate;
            SetColourCurve(dead, "", new[] { 0f, fallen + 0.5f, fallen + 1f },
                           new[] { Color.white, Color.white, new Color(1f, 1f, 1f, 0f) });
            SetEvents(dead, new[] { fallen + 1f }, new[] { "OnDeathFinished" });
            clips[d * 5 + 4] = dead;
        }
        return clips;
    }

    // The Humanoid controller (Chapter 4): Direction, Speed and three
    // triggers; four sub-state machines, one per direction, each with the
    // five states of that direction. Idle and Walk leave their machine through
    // Exit when Direction isn't the machine's own number, and the Base Layer
    // sends the character into the machine Direction names. The hero's clips
    // are the ones in it; the Override Controllers swap them.
    static AnimatorController MakeHumanoid(string path, AnimationClip[] clips)
    {
        AnimatorController controller = MakeController(path);
        controller.AddParameter("Direction", AnimatorControllerParameterType.Int);
        controller.AddParameter("Speed", AnimatorControllerParameterType.Float);
        controller.AddParameter("Attack", AnimatorControllerParameterType.Trigger);
        controller.AddParameter("Hurt", AnimatorControllerParameterType.Trigger);
        controller.AddParameter("Dead", AnimatorControllerParameterType.Trigger);

        AnimatorStateMachine root = controller.layers[0].stateMachine;
        var machines = new AnimatorStateMachine[Directions.Length];
        Vector2[] machinePlaces = { new Vector2(300f, 200f), new Vector2(50f, 100f), new Vector2(300f, 0f), new Vector2(550f, 100f) };
        for (int d = 0; d < Directions.Length; d++)
        {
            AnimatorStateMachine machine = root.AddStateMachine(Directions[d], machinePlaces[d]);
            machines[d] = machine;
            AnimatorState idle = AddState(machine, "Idle", clips[d * 5], new Vector2(300f, 0f));
            AnimatorState walk = AddState(machine, "Walk", clips[d * 5 + 1], new Vector2(600f, 0f));
            AnimatorState attack = AddState(machine, "Attack", clips[d * 5 + 2], new Vector2(450f, 130f));
            AnimatorState hurt = AddState(machine, "Hurt", clips[d * 5 + 3], new Vector2(300f, 260f));
            AnimatorState dead = AddState(machine, "Dead", clips[d * 5 + 4], new Vector2(600f, 260f));
            machine.defaultState = idle;
            if (d == 0)
            {
                root.defaultState = idle;       // the layer starts facing down
            }

            // Walking into a new direction starts in Walk, not Idle.
            machine.AddEntryTransition(walk).AddCondition(AnimatorConditionMode.Greater, 0.1f, "Speed");
            AddTransition(idle, walk, false).AddCondition(AnimatorConditionMode.Greater, 0.1f, "Speed");
            AddTransition(walk, idle, false).AddCondition(AnimatorConditionMode.Less, 0.1f, "Speed");
            AddTransition(idle, attack, false).AddCondition(AnimatorConditionMode.If, 0f, "Attack");
            AddTransition(walk, attack, false).AddCondition(AnimatorConditionMode.If, 0f, "Attack");
            AddTransition(attack, idle, true);
            AddTransition(hurt, idle, true);
            AddExitTransition(idle, false).AddCondition(AnimatorConditionMode.NotEqual, d, "Direction");
            AddExitTransition(walk, false).AddCondition(AnimatorConditionMode.NotEqual, d, "Direction");

            AnimatorStateTransition toHurt = AddAnyStateTransition(controller, hurt);
            toHurt.AddCondition(AnimatorConditionMode.If, 0f, "Hurt");
            toHurt.AddCondition(AnimatorConditionMode.Equals, d, "Direction");
            AnimatorStateTransition toDead = AddAnyStateTransition(controller, dead);
            toDead.AddCondition(AnimatorConditionMode.If, 0f, "Dead");
            toDead.AddCondition(AnimatorConditionMode.Equals, d, "Direction");
        }

        // Each machine is joined to the other three, on Direction Equals n.
        for (int from = 0; from < machines.Length; from++)
        {
            for (int to = 0; to < machines.Length; to++)
            {
                if (from != to)
                {
                    root.AddStateMachineTransition(machines[from], machines[to])
                        .AddCondition(AnimatorConditionMode.Equals, to, "Direction");
                }
            }
        }
        EditorUtility.SetDirty(controller);
        return controller;
    }

    // The king's copy of Humanoid gets two attacks no one else has (Chapter
    // 13): Whirlwind, for as long as its Bool is on, and Summon, once, on its
    // trigger. Both leave through the Base Layer's Exit, which starts the
    // layer again from Entry: Down, then on into his Direction.
    static void AddKingStates(AnimatorController controller)
    {
        controller.AddParameter("Whirlwind", AnimatorControllerParameterType.Bool);
        controller.AddParameter("Summon", AnimatorControllerParameterType.Trigger);

        AnimationClip whirlwind = MakeSpriteClip(ClipPath("King Whirlwind"), sheets["KingWhirlwind"], 12f, true);
        AnimationClip summon = MakeSpriteClip(ClipPath("King Summon"), sheets["KingSummon"], 10f, false);
        SetEvents(summon, new[] { 9f / 10f }, new[] { "OnSummon" });       // the golden ring spreads

        AnimatorState whirlwindState = AddState(controller, "Whirlwind", whirlwind, new Vector2(800f, 0f));
        AnimatorState summonState = AddState(controller, "Summon", summon, new Vector2(800f, 200f));
        AddAnyStateTransition(controller, whirlwindState).AddCondition(AnimatorConditionMode.If, 0f, "Whirlwind");
        AddAnyStateTransition(controller, summonState).AddCondition(AnimatorConditionMode.If, 0f, "Summon");
        AddExitTransition(whirlwindState, false).AddCondition(AnimatorConditionMode.IfNot, 0f, "Whirlwind");
        AddExitTransition(summonState, true);
        EditorUtility.SetDirty(controller);
    }

    // The door's three clips: property curves on its two leaves' Scale X,
    // which fold back to their hinges (Chapter 9).
    static AnimatorController MakeDoorAnimation()
    {
        AnimationClip closed = MakePropertyClip(ClipPath("Door Closed"), 30f, true);
        SetLeafCurves(closed, new[] { 0f, 1f }, new[] { 1f, 1f });
        AnimationClip opening = MakePropertyClip(ClipPath("Door Opening"), 30f, false);
        SetLeafCurves(opening, new[] { 0f, 0.5f }, new[] { 1f, 0.15f });
        SetEvents(opening, new[] { 0.5f }, new[] { "OnDoorOpened" });
        AnimationClip open = MakePropertyClip(ClipPath("Door Open"), 30f, true);
        SetLeafCurves(open, new[] { 0f, 1f }, new[] { 0.15f, 0.15f });

        AnimatorController controller = MakeController(AnimationFolder + "/Door.controller");
        controller.AddParameter("Open", AnimatorControllerParameterType.Bool);
        AnimatorState closedState = AddState(controller, "Closed", closed, new Vector2(300f, 0f));
        AnimatorState openingState = AddState(controller, "Opening", opening, new Vector2(560f, 0f));
        AnimatorState openState = AddState(controller, "Open", open, new Vector2(820f, 0f));
        controller.layers[0].stateMachine.defaultState = closedState;
        AddTransition(closedState, openingState, false).AddCondition(AnimatorConditionMode.If, 0f, "Open");
        AddTransition(openingState, openState, true);
        AddTransition(openState, closedState, false).AddCondition(AnimatorConditionMode.IfNot, 0f, "Open");
        EditorUtility.SetDirty(controller);
        return controller;
    }

    static void SetLeafCurves(AnimationClip clip, float[] times, float[] scales)
    {
        SetCurve(clip, "Left Leaf", typeof(Transform), "m_LocalScale.x", times, scales);
        SetCurve(clip, "Right Leaf", typeof(Transform), "m_LocalScale.x", times, scales);
    }

    // The chest: Closed, Opening and Open, on its Open trigger. The Opening
    // clip's last frame, the lid up, calls OnLootReady (Chapter 10).
    static AnimatorController MakeChestAnimation()
    {
        AnimationClip closed = MakeSpriteClip(ClipPath("Chest Closed"), Frames(chestSprites, 0), 8f, true);
        AnimationClip opening = MakeSpriteClip(ClipPath("Chest Opening"), Frames(chestSprites, 0, 1, 2), 8f, false);
        SetEvents(opening, new[] { 2f / 8f }, new[] { "OnLootReady" });
        AnimationClip open = MakeSpriteClip(ClipPath("Chest Open"), Frames(chestSprites, 2), 8f, true);

        AnimatorController controller = MakeController(AnimationFolder + "/Chest.controller");
        controller.AddParameter("Open", AnimatorControllerParameterType.Trigger);
        AnimatorState closedState = AddState(controller, "Closed", closed, new Vector2(300f, 0f));
        AnimatorState openingState = AddState(controller, "Opening", opening, new Vector2(560f, 0f));
        AnimatorState openState = AddState(controller, "Open", open, new Vector2(820f, 0f));
        controller.layers[0].stateMachine.defaultState = closedState;
        AddTransition(closedState, openingState, false).AddCondition(AnimatorConditionMode.If, 0f, "Open");
        AddTransition(openingState, openState, true);
        EditorUtility.SetDirty(controller);
        return controller;
    }

    // A torch's flicker: one looping clip that only animates its Light 2D's
    // Intensity, a property of a component that isn't a Transform (Chapter 14).
    static AnimatorController MakeTorchAnimation()
    {
        AnimationClip flicker = MakePropertyClip(ClipPath("Torch Flicker"), 30f, true);
        SetCurve(flicker, "Flame", typeof(Light2D), "m_Intensity",
                 new[] { 0f, 0.2f, 0.3f, 0.5f, 0.7f, 0.8f, 1f },
                 new[] { 1.2f, 1f, 1.3f, 1.1f, 1.35f, 1.05f, 1.2f });
        AnimatorController controller = MakeController(AnimationFolder + "/Torch.controller");
        controller.layers[0].stateMachine.defaultState = AddState(controller, "Flicker", flicker, new Vector2(300f, 0f));
        EditorUtility.SetDirty(controller);
        return controller;
    }

    // A pickup's one looping clip, from its sheet's own frames.
    static AnimatorController MakeLoopAnimation(string name, Sprite[] frames, float framesPerSecond)
    {
        AnimationClip loop = MakeSpriteClip(ClipPath(name + " Idle"), frames, framesPerSecond, true);
        AnimatorController controller = MakeController(AnimationFolder + "/" + name + ".controller");
        controller.layers[0].stateMachine.defaultState = AddState(controller, "Idle", loop, new Vector2(300f, 0f));
        EditorUtility.SetDirty(controller);
        return controller;
    }

    // A key bobs: a property clip on its Sprite child's position, so the key
    // itself, and its collider, stay where they were put (Chapter 9).
    static AnimatorController MakeKeyAnimation()
    {
        AnimationClip bob = MakePropertyClip(ClipPath("Key Bob"), 30f, true);
        SetCurve(bob, "Sprite", typeof(Transform), "m_LocalPosition.y", new[] { 0f, 0.5f, 1f }, new[] { 0f, 0.1f, 0f });
        AnimatorController controller = MakeController(AnimationFolder + "/Key.controller");
        controller.layers[0].stateMachine.defaultState = AddState(controller, "Bob", bob, new Vector2(300f, 0f));
        EditorUtility.SetDirty(controller);
        return controller;
    }

    // ------------------------------------------------------------------ prefabs

    // A top-down body: no gravity, no turning over, and smooth between steps.
    static void SetUpBody(Rigidbody2D body, float mass)
    {
        body.bodyType = RigidbodyType2D.Dynamic;
        body.gravityScale = 0f;
        body.mass = mass;
        body.constraints = RigidbodyConstraints2D.FreezeRotation;
        body.interpolation = RigidbodyInterpolation2D.Interpolate;
    }

    // In a top-down game a character's collider is at its feet: the walls
    // stop the feet, and the head can pass in front of a wall.
    static void AddFeetCollider(GameObject go, float width)
    {
        var capsule = go.AddComponent<CapsuleCollider2D>();
        capsule.direction = CapsuleDirection2D.Horizontal;
        capsule.size = new Vector2(width, 0.3f);
        capsule.offset = new Vector2(0f, 0.15f);
    }

    static GameObject MakeEnemyPrefab(string name, Sprite sprite, RuntimeAnimatorController controller, int enemyLayer, float mass)
    {
        var go = new GameObject(name);
        go.layer = enemyLayer;
        var renderer = go.AddComponent<SpriteRenderer>();
        renderer.sprite = sprite;
        renderer.spriteSortPoint = SpriteSortPoint.Pivot;
        SetUpBody(go.AddComponent<Rigidbody2D>(), mass);
        AddFeetCollider(go, name == "Skeleton King" ? 0.7f : 0.55f);
        go.AddComponent<Animator>().runtimeAnimatorController = controller;
        go.AddComponent<AudioSource>().playOnAwake = false;
        if (name == "Skeleton")
        {
            go.AddComponent<Skeleton>();
        }
        else if (name == "Archer")
        {
            go.AddComponent<Archer>();
        }
        else
        {
            go.AddComponent<SkeletonKing>();
        }
        return SavePrefab(go, name);
    }

    // The arrow's collider flies at the height of the feet; its Picture child
    // is drawn 0.4 higher, at the height of the bow (Chapter 8).
    static GameObject MakeArrowPrefab(int enemyLayer)
    {
        var go = new GameObject("Arrow");
        go.layer = enemyLayer;
        var body = go.AddComponent<Rigidbody2D>();
        SetUpBody(body, 0.1f);
        var circle = go.AddComponent<CircleCollider2D>();
        circle.isTrigger = true;
        circle.radius = 0.15f;
        var arrow = go.AddComponent<Arrow>();
        Transform picture = MakeChild(go.transform, "Picture", new Vector3(0f, 0.4f, 0f));
        picture.gameObject.layer = enemyLayer;
        var renderer = picture.gameObject.AddComponent<SpriteRenderer>();
        renderer.sprite = arrowSprite;
        renderer.spriteSortPoint = SpriteSortPoint.Pivot;
        Set(arrow, "picture", picture);
        return SavePrefab(go, "Arrow");
    }

    static GameObject MakeChestPrefab(RuntimeAnimatorController controller)
    {
        var go = new GameObject("Chest");
        var renderer = go.AddComponent<SpriteRenderer>();
        renderer.sprite = chestSprites[0];
        renderer.spriteSortPoint = SpriteSortPoint.Pivot;
        var box = go.AddComponent<BoxCollider2D>();
        box.size = new Vector2(0.85f, 0.45f);
        box.offset = new Vector2(0f, 0.225f);
        go.AddComponent<Animator>().runtimeAnimatorController = controller;
        go.AddComponent<AudioSource>().playOnAwake = false;
        var chest = go.AddComponent<Chest>();
        Set(chest, "openSound", LoadClip(AudioFolder + "/Chest.wav"));
        return SavePrefab(go, "Chest");
    }

    // The door: the doorway, the whole door's shape in black, with its two
    // leaves in front. A Sorting Group sorts all three as one, at the door's
    // foot. Its Box Collider fills the doorway until the door is open.
    static GameObject MakeDoorPrefab(RuntimeAnimatorController controller)
    {
        var go = new GameObject("Door");
        go.AddComponent<UnityEngine.Rendering.SortingGroup>();
        var blocker = go.AddComponent<BoxCollider2D>();
        blocker.size = new Vector2(1f, 2f);
        blocker.offset = new Vector2(0f, 1f + 2f / PixelsPerUnit);
        go.AddComponent<Animator>().runtimeAnimatorController = controller;
        go.AddComponent<AudioSource>().playOnAwake = false;
        var door = go.AddComponent<Door>();
        Set(door, "blocker", blocker);
        Set(door, "openSound", LoadClip(AudioFolder + "/Door.wav"));

        var doorway = MakeChild(go.transform, "Doorway", Vector3.zero).gameObject.AddComponent<SpriteRenderer>();
        doorway.sprite = props["Door"];
        doorway.color = Hex("#0B0A0D");
        float hinge = 13f / PixelsPerUnit;      // each hinge is 13 pixels from the middle
        var left = MakeChild(go.transform, "Left Leaf", new Vector3(-hinge, 0f, 0f)).gameObject.AddComponent<SpriteRenderer>();
        left.sprite = props["Door Left"];
        left.sortingOrder = 1;
        var right = MakeChild(go.transform, "Right Leaf", new Vector3(hinge, 0f, 0f)).gameObject.AddComponent<SpriteRenderer>();
        right.sprite = props["Door Right"];
        right.sortingOrder = 1;
        return SavePrefab(go, "Door");
    }

    // A key: the pickup and its trigger on the root, and its picture on a
    // child that bobs.
    static GameObject MakeKeyPrefab(string name, Sprite sprite, Pickup.Kind kind, RuntimeAnimatorController controller, AudioClip sound)
    {
        var go = new GameObject(name);
        var circle = go.AddComponent<CircleCollider2D>();
        circle.isTrigger = true;
        circle.radius = 0.3f;
        go.AddComponent<Animator>().runtimeAnimatorController = controller;
        var pickup = go.AddComponent<Pickup>();
        SetInt(pickup, "kind", (int)kind);
        Set(pickup, "pickupSound", sound);
        var renderer = MakeChild(go.transform, "Sprite", Vector3.zero).gameObject.AddComponent<SpriteRenderer>();
        renderer.sprite = sprite;
        renderer.spriteSortPoint = SpriteSortPoint.Pivot;
        return SavePrefab(go, name);
    }

    static GameObject MakeLoopPickupPrefab(string name, Sprite sprite, Pickup.Kind kind, RuntimeAnimatorController controller, AudioClip sound)
    {
        var go = new GameObject(name);
        var renderer = go.AddComponent<SpriteRenderer>();
        renderer.sprite = sprite;
        renderer.spriteSortPoint = SpriteSortPoint.Pivot;
        var circle = go.AddComponent<CircleCollider2D>();
        circle.isTrigger = true;
        circle.radius = 0.3f;
        go.AddComponent<Animator>().runtimeAnimatorController = controller;
        var pickup = go.AddComponent<Pickup>();
        SetInt(pickup, "kind", (int)kind);
        Set(pickup, "pickupSound", sound);
        return SavePrefab(go, name);
    }

    // A torch: its picture, and a warm Point Light 2D on its Flame child,
    // which the Animator flickers. A standing torch stands in the way.
    static GameObject MakeTorchPrefab(string name, Sprite sprite, RuntimeAnimatorController controller, float flameHeight,
                                      int wallsLayer, bool isStanding)
    {
        var go = new GameObject(name);
        var renderer = go.AddComponent<SpriteRenderer>();
        renderer.sprite = sprite;
        renderer.spriteSortPoint = SpriteSortPoint.Pivot;
        if (isStanding)
        {
            go.layer = wallsLayer;
            var box = go.AddComponent<BoxCollider2D>();
            box.size = new Vector2(0.5f, 0.25f);
            box.offset = new Vector2(0f, 0.12f);
        }
        go.AddComponent<Animator>().runtimeAnimatorController = controller;
        AddPointLight(MakeChild(go.transform, "Flame", new Vector3(0f, flameHeight, 0f)), Hex("#FF9A40"), 1.2f, 4.5f);
        return SavePrefab(go, name);
    }

    // A banner, a statue or a pillar: its picture, and, if it stands on the
    // floor, a collider at its foot on the Walls layer, so it stops the hero,
    // arrows and the enemies' sight: cover.
    static GameObject MakePropPrefab(string name, Sprite sprite, Vector2 footSize, int wallsLayer)
    {
        var go = new GameObject(name);
        var renderer = go.AddComponent<SpriteRenderer>();
        renderer.sprite = sprite;
        renderer.spriteSortPoint = SpriteSortPoint.Pivot;
        if (footSize != Vector2.zero)
        {
            go.layer = wallsLayer;
            var box = go.AddComponent<BoxCollider2D>();
            box.size = footSize;
            box.offset = new Vector2(0f, footSize.y / 2f);
        }
        return SavePrefab(go, name);
    }

    static GameObject SavePrefab(GameObject go, string name)
    {
        GameObject prefab = PrefabUtility.SaveAsPrefabAsset(go, PrefabFolder + "/" + name + ".prefab");
        Object.DestroyImmediate(go);
        return prefab;
    }

    static Light2D AddPointLight(Transform holder, Color colour, float intensity, float radius)
    {
        var light = holder.gameObject.AddComponent<Light2D>();
        light.lightType = Light2D.LightType.Point;
        light.color = colour;
        light.intensity = intensity;
        light.pointLightOuterRadius = radius;
        light.pointLightInnerRadius = radius * 0.2f;
        return light;
    }

    // ------------------------------------------------------------------ the crypt

    // Room k fills rows 11k to 11k + 10: the rooms are stacked, the first at
    // the bottom, so a door in a room's top wall leads into the next.
    static Vector2 RoomCentre(int room)
    {
        return new Vector2(RoomWidth / 2f, room * RoomHeight + RoomHeight / 2f);
    }

    // Paints one room of the map, and puts everything in it in its place.
    // The map's first row is the room's top row.
    static void PaintRoom(int room, List<string> map)
    {
        bool isTomb = string.Join("", map).Contains(",");
        TileBase floor = isTomb ? tombFloorTile : floorTile;
        for (int line = 0; line < map.Count; line++)
        {
            int row = RoomHeight - 1 - line;
            for (int x = 0; x < map[line].Length; x++)
            {
                char c = map[line][x];
                int y = room * RoomHeight + row;
                var cell = new Vector3Int(x, y, 0);
                switch (c)
                {
                    case '#':
                        wallMap.SetTile(cell, TileAt(3, 0));        // the dark around the room
                        break;
                    case 'W':
                    case 't':
                    case 'B':
                        wallMap.SetTile(cell, WallTile(map[line], x, row));
                        if (c == 't')
                        {
                            Place(wallTorchPrefab, torches, new Vector3(x + 0.5f, y + 0.4f, 0f));
                        }
                        else if (c == 'B')
                        {
                            Place(bannerPrefab, decor, new Vector3(x + 0.5f, y + 0.1f, 0f));
                        }
                        break;
                    case 'D':
                        // The doorway is left empty; the door fills it.
                        if (row == RoomHeight - 2)
                        {
                            GameObject door = Place(doorPrefab, doors, new Vector3(x + 0.5f, y - 2f / PixelsPerUnit, 0f));
                            door.name = "Door " + (room + 1);
                            Keep(door);
                            Door script = door.GetComponent<Door>();
                            SetBool(script, "needsBossKey", room == BossDoorRoom);
                            doorList.Add(script);
                        }
                        break;
                    case 'R':
                        floorMap.SetTile(cell, floor);
                        decorationMap.SetTile(cell, CarpetTile(map, line, x));
                        break;
                    default:
                        floorMap.SetTile(cell, floor);
                        PlaceThing(c, room, x, y);
                        break;
                }
            }
        }
    }

    // What stands on the floor: the hero's start, enemies, chests, pickups
    // and props. '.', ',' and 'd' (a doorway's threshold) are floor only.
    static void PlaceThing(char c, int room, int x, int y)
    {
        Vector3 foot = new Vector3(x + 0.5f, y + 0.15f, 0f);
        Vector3 middle = new Vector3(x + 0.5f, y + 0.5f, 0f);
        switch (c)
        {
            case 'H':
                heroStart = foot;
                break;
            case 's':
                skeletons.Add(Place(skeletonPrefab, enemies, foot).GetComponent<Skeleton>());
                break;
            case 'a':
                archers.Add(Place(archerPrefab, enemies, foot).GetComponent<Archer>());
                break;
            case 'K':
                king = Place(kingPrefab, enemies, foot).GetComponent<SkeletonKing>();
                break;
            case 'x':
                var point = new GameObject("Summon Point " + (summonPoints.Count + 1)).transform;
                point.SetParent(summonPointGroup, false);
                point.position = foot;
                summonPoints.Add(point);
                break;
            case 'k':
                MakeChest(room, foot, keyPrefab);
                break;
            case 'q':
                MakeChest(room, foot, potionPrefab, keyPrefab);
                break;
            case 'b':
                MakeChest(room, foot, bossKeyPrefab);
                break;
            case 'g':
                Place(goldPrefab, pickups, middle);
                break;
            case 'p':
                Place(potionPrefab, pickups, middle);
                break;
            case 'S':
                Place(statuePrefab, decor, foot);
                break;
            case 'Z':
                Place(shieldStatuePrefab, decor, foot);
                break;
            case 'O':
                Place(pillarPrefab, decor, new Vector3(x + 0.5f, y, 0f));
                break;
            case 'T':
                Place(standingTorchPrefab, torches, foot);
                break;
        }
    }

    // A chest, with its loot waiting in front of it, hidden until it opens.
    static void MakeChest(int room, Vector3 position, params GameObject[] lootPrefabs)
    {
        GameObject chest = Place(chestPrefab, chests, position);
        chest.name = "Chest " + (room + 1);
        Keep(chest);
        var loot = new GameObject[lootPrefabs.Length];
        for (int i = 0; i < lootPrefabs.Length; i++)
        {
            float across = lootPrefabs.Length == 1 ? 0f : (i == 0 ? -0.35f : 0.35f);
            loot[i] = Place(lootPrefabs[i], pickups, position + new Vector3(across, -0.55f, 0f));
            loot[i].name = lootPrefabs[i].name + " (Room " + (room + 1) + " Chest)";
            loot[i].SetActive(false);
            Keep(loot[i]);
            SetBool(loot[i].GetComponent<Pickup>(), "startsHidden", true);
        }
        SetArray(chest.GetComponent<Chest>(), "loot", loot);
    }

    // The wall's face is two tiles tall: its top row has the dark edge along
    // its top, its bottom row the shadow where it meets the floor. A wall's
    // end tiles have a dark edge on their side, beside the dark or a doorway.
    static Tile WallTile(string line, int x, int row)
    {
        int tileRow = row == RoomHeight - 1 ? 0 : 1;
        bool isLeftEnd = x == 0 || !IsWall(line[x - 1]);
        bool isRightEnd = x == line.Length - 1 || !IsWall(line[x + 1]);
        int column = isLeftEnd ? 4 : (isRightEnd ? 6 : 5);
        return TileAt(column, tileRow);
    }

    static bool IsWall(char c)
    {
        return c == 'W' || c == 't' || c == 'B';
    }

    // The red carpet is nine tiles: corners, edges and the middle, chosen
    // by which of its neighbours are carpet too.
    static Tile CarpetTile(List<string> map, int line, int x)
    {
        bool left = x > 0 && map[line][x - 1] == 'R';
        bool right = x < map[line].Length - 1 && map[line][x + 1] == 'R';
        bool above = line > 0 && map[line - 1][x] == 'R';
        bool below = line < map.Count - 1 && map[line + 1][x] == 'R';
        int column = !left ? 7 : (!right ? 9 : 8);
        int row = !above ? 5 : (!below ? 7 : 6);
        return TileAt(column, row);
    }

    static GameObject Place(GameObject prefab, Transform parent, Vector3 position)
    {
        var instance = (GameObject)PrefabUtility.InstantiatePrefab(prefab, parent);
        instance.transform.position = position;
        Keep(instance.transform);
        return instance;
    }

    // A change made from code to a prefab instance lasts only once it's
    // recorded as an override, as the Inspector records its own changes;
    // otherwise the next change through a SerializedObject puts it back.
    static void Keep(Object changed)
    {
        PrefabUtility.RecordPrefabInstancePropertyModifications(changed);
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

    // CryptGame's Room[] array: plain C# objects, filled in field by field.
    static void SetRooms(CryptGame game, List<string> titles)
    {
        var serialized = new SerializedObject(game);
        SerializedProperty rooms = serialized.FindProperty("rooms");
        rooms.arraySize = titles.Count;
        for (int i = 0; i < titles.Count; i++)
        {
            SerializedProperty element = rooms.GetArrayElementAtIndex(i);
            element.FindPropertyRelative("title").stringValue = titles[i];
            element.FindPropertyRelative("centre").vector2Value = RoomCentre(i);
            element.FindPropertyRelative("hasBoss").boolValue = i == titles.Count - 1;
        }
        serialized.ApplyModifiedPropertiesWithoutUndo();
    }

    // ------------------------------------------------------------------ UI

    static void PinToCorner(RectTransform rect, Vector2 corner, Vector2 position)
    {
        rect.anchorMin = corner;
        rect.anchorMax = corner;
        rect.pivot = corner;
        rect.anchoredPosition = position;
    }

    // A pixel-art icon at four times its size: 16 pixels become 64.
    static Image MakeIcon(Transform parent, string name, Sprite sprite, Vector2 position)
    {
        Image icon = MakeImage(parent, name, Color.white, new Vector2(0f, 1f), position, new Vector2(64f, 64f));
        icon.sprite = sprite;
        return icon;
    }

    static TMP_Text MakeHudText(Transform parent, string name, string text, Vector2 position, Vector2 size, TMP_FontAsset font, Color colour)
    {
        TMP_Text label = MakeText(parent, name, text, 44f, TextAlignmentOptions.Left, new Vector2(0f, 1f), position, size, colour);
        label.font = font;
        return label;
    }

    // One of the boss bar's strips, at six times its size.
    static Image MakeBarImage(Transform bar, string name, Sprite sprite)
    {
        Image image = MakeImage(bar, name, Color.white, new Vector2(0.5f, 0f), Vector2.zero, new Vector2(456f, 36f));
        image.sprite = sprite;
        return image;
    }

    // A dimmed full-screen panel holding the RPG UI's stone panel, sliced.
    // The window is drawn at twice its size, and its border at twice that
    // again (Pixels Per Unit Multiplier 0.5), so each pixel is 4 × 4 on screen.
    static RectTransform MakeStoneWindow(Transform parent, string name, Vector2 size, out GameObject panel)
    {
        RectTransform window = MakeWindow(parent, name, size, 2f, Color.white, out panel);
        Image image = window.GetComponent<Image>();
        image.sprite = panelSprite;
        image.type = Image.Type.Sliced;
        image.pixelsPerUnitMultiplier = 0.5f;
        return window;
    }

    static TMP_Text MakePanelText(Transform window, string name, string text, float size, Vector2 position, Vector2 box, TMP_FontAsset font)
    {
        TMP_Text label = MakeText(window, name, text, size, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), position, box, Hex("#F2E8D5"));
        label.font = font;
        return label;
    }

    // The RPG UI's stone button, sliced, with its own pictures for
    // Highlighted and Pressed: a Sprite Swap transition.
    static Button MakePanelButton(Transform window, string name, string label, Vector2 position, TMP_FontAsset font)
    {
        Button button = MakeButton(window, name, label, position, new Vector2(220f, 32f), Color.white);
        Image image = button.GetComponent<Image>();
        image.sprite = buttonSprite;
        image.type = Image.Type.Sliced;
        image.pixelsPerUnitMultiplier = 0.5f;
        button.transition = Selectable.Transition.SpriteSwap;
        SpriteState sprites = button.spriteState;
        sprites.highlightedSprite = buttonHighlightedSprite;
        sprites.pressedSprite = buttonPressedSprite;
        button.spriteState = sprites;
        TMP_Text text = button.GetComponentInChildren<TMP_Text>();
        text.font = font;
        text.fontSize = 18f;
        text.color = Hex("#F2E8D5");
        return button;
    }
}
