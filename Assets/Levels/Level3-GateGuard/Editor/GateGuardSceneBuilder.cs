using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEditor;
using UnityEditor.Animations;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;
using static Level3BuilderKit;

// INSTRUCTOR TOOL: not part of the student book, and never shipped in a build.
// Menu: Tools → Gate Guard (Level 3) → Build Scene
//
// Rebuilds Assets/Levels/Level3-GateGuard/Scenes/GateGuard.unity exactly as the
// Gate Guard book describes it: the models' import settings, the Humanoid
// Avatars and the clips with their Animation Events, the Skeleton, Crew, Tower
// and Gate Animator Controllers with their Override Controllers and property
// clips, the prefabs, the battlefield laid out from Editor/GateGuardMap.txt
// on a hex Grid, the castle, the 3D renderer, the light and the camera, and
// the whole UI, with every Inspector reference wired up. Use it to prepare lab
// machines or to reset a broken scene. Running it again overwrites the scene,
// the prefabs, the clips and the controllers; the font asset is made once.
public static class GateGuardSceneBuilder
{
    const string Root = "Assets/Levels/Level3-GateGuard";
    const string ScenePath = Root + "/Scenes/GateGuard.unity";
    const string ModelFolder = Root + "/Art/Models";
    const string CharacterFolder = Root + "/Art/Characters";
    const string WeaponFolder = Root + "/Art/Weapons";
    const string ClipFolder = Root + "/Art/Animations";
    const string UiFolder = Root + "/Art/UI";
    const string IconFolder = Root + "/Art/Icons";
    const string FontFolder = Root + "/Art/Fonts";
    const string AudioFolder = Root + "/Audio";
    const string AnimationFolder = Root + "/Animation";
    const string PrefabFolder = Root + "/Prefabs";
    const string SettingsFolder = Root + "/Settings";
    const string MapPath = Root + "/Editor/GateGuardMap.txt";

    // ---- The battlefield: pointy-top hexes, 2 units across, odd rows half a hex to the right
    const float HexWidth = 2f;
    const float RowStep = 1.7320508f;                       // between rows: 1.5 × the hex's corner radius
    static readonly Vector3 GridOrigin = new Vector3(-12f, 0f, -4f * RowStep);  // the map's middle at (0, 0, 0)
    const int MapRows = 9;
    const int GateExitAngle = 60;                           // the road leaves the gate's tile north-east

    // ---- Sizes
    const float SkeletonScale = 0.42f;
    const float BossScale = 0.62f;
    const float CrewScale = 0.36f;
    const float TopLevel1 = 1.38f;                          // a crew's platform on one storey
    const float StoreyHeight = 1.2f;                        // the second storey: a tower base at 0.8 height

    // ---- The clips: which loop, and the Animation Events (0 at a clip's start, 1 at its end)
    static readonly string[] LoopingClips =
    {
        "Skeletons_Walking", "Running_A", "Walking_A", "Idle_A", "Ranged_Bow_Idle",
        "Ranged_Bow_Aiming_Idle", "Ranged_Magic_Spellcasting", "Cheering",
    };
    static readonly Dictionary<string, (string method, float time)> ClipEvents = new Dictionary<string, (string, float)>
    {
        { "Skeletons_Spawn_Ground", ("OnRisen", 0.98f) },
        { "Skeletons_Death", ("OnDeathFinished", 0.98f) },
        { "Melee_1H_Attack_Chop", ("OnGateHit", 0.55f) },
        { "Melee_2H_Attack_Chop", ("OnGateHit", 0.55f) },
        { "Ranged_Bow_Release", ("OnRelease", 0.15f) },
        { "Ranged_Magic_Shoot", ("OnRelease", 0.4f) },
    };

    // ---- The waves: { title, then kind, count, gap, kind, count, gap … }
    static readonly string[][] WaveData =
    {
        new[] { "The First Rising", "Minion", "6", "1.6" },
        new[] { "More Bones", "Minion", "10", "1.2" },
        new[] { "Hooded Runners", "Minion", "6", "1.2", "Rogue", "4", "0.9" },
        new[] { "The Quick Ones", "Rogue", "10", "0.7" },
        new[] { "Shields", "Warrior", "2", "2.5", "Minion", "8", "1" },
        new[] { "The Wall of Shields", "Warrior", "6", "2" },
        new[] { "Run and Hide", "Rogue", "10", "0.6", "Warrior", "4", "2" },
        new[] { "The Long March", "Minion", "14", "0.8", "Rogue", "6", "0.7", "Warrior", "3", "2" },
        new[] { "Iron and Bone", "Warrior", "8", "1.6", "Rogue", "8", "0.6" },
        new[] { "The Bone Mage", "Minion", "10", "0.9", "Warrior", "6", "1.8", "Bone Mage", "1", "1" },
    };

    static readonly Dictionary<string, Sprite> sprites = new Dictionary<string, Sprite>();
    static Material particleMaterial;
    static TMP_FontAsset font;
    static readonly Color Ink = new Color32(0x4A, 0x34, 0x20, 0xFF);        // dark brown, on parchment
    static readonly Color HudInk = new Color32(0xFF, 0xF7, 0xE6, 0xFF);

    [MenuItem("Tools/Gate Guard (Level 3)/Build Scene")]
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
        EnsureFolder(PrefabFolder);
        EnsureFolder(SettingsFolder);
        AssetDatabase.Refresh();

        int enemyLayer = AddLayer("Enemy");
        int plotLayer = AddLayer("Plot");

        ImportArt();
        font = MakeFontAsset(FontFolder + "/LilitaOne-Regular.ttf", FontFolder + "/LilitaOne-Regular SDF.asset");
        font.material.SetFloat(ShaderUtilities.ID_OutlineWidth, 0.18f);
        font.material.SetColor(ShaderUtilities.ID_OutlineColor, new Color32(0x2B, 0x1B, 0x10, 0xFF));
        EditorUtility.SetDirty(font.material);
        particleMaterial = MakeParticleMaterial(AnimationFolder + "/Particle.mat");

        // ---- Animation (Chapters 3 to 6, 8 to 10 and 13) ----
        AnimatorController skeletonController = MakeSkeletonController();
        AnimatorOverrideController rogueOverride = MakeOverrideController(AnimationFolder + "/Rogue Override.overrideController",
            skeletonController, new[] { Clip("Rig_Medium_Special", "Skeletons_Walking") }, new[] { Clip("Rig_Medium_MovementBasic", "Running_A") });
        AnimatorOverrideController warriorOverride = MakeOverrideController(AnimationFolder + "/Warrior Override.overrideController",
            skeletonController, new[] { Clip("Rig_Medium_Special", "Skeletons_Walking") }, new[] { Clip("Rig_Medium_MovementBasic", "Walking_A") });
        AnimatorOverrideController bossOverride = MakeOverrideController(AnimationFolder + "/Bone Mage Override.overrideController",
            skeletonController, new[] { Clip("Rig_Medium_CombatMelee", "Melee_1H_Attack_Chop") }, new[] { Clip("Rig_Medium_CombatMelee", "Melee_2H_Attack_Chop") });
        AnimatorController crewController = MakeCrewController();
        AnimatorOverrideController mageOverride = MakeOverrideController(AnimationFolder + "/Mage Override.overrideController",
            crewController,
            new[] { Clip("Rig_Medium_CombatRanged", "Ranged_Bow_Idle"), Clip("Rig_Medium_CombatRanged", "Ranged_Bow_Aiming_Idle"), Clip("Rig_Medium_CombatRanged", "Ranged_Bow_Release") },
            new[] { Clip("Rig_Medium_General", "Idle_A"), Clip("Rig_Medium_CombatRanged", "Ranged_Magic_Spellcasting"), Clip("Rig_Medium_CombatRanged", "Ranged_Magic_Shoot") });
        AnimatorOverrideController catapultOverride = MakeCatapultOverride(crewController);
        AnimatorController towerController = MakeTowerController();
        AnimatorController gateController = MakeGateController();

        // ---- Prefabs (Chapters 3, 6, 8, 9 and 14) ----
        GameObject dust = MakeBurstPrefab("Dust", new Color32(0xB9, 0x9A, 0x74, 0xFF), new Color32(0x8C, 0x7A, 0x66, 0xFF), 24, 1.4f, 0.5f);
        GameObject frostBurst = MakeBurstPrefab("Frost Burst", new Color32(0xDF, 0xF3, 0xFF, 0xFF), new Color32(0x7C, 0xC8, 0xFF, 0xFF), 18, 1.6f, 0f);
        Projectile arrow = MakeArrowPrefab();
        Projectile stone = MakeStonePrefab(dust);
        Projectile bolt = MakeBoltPrefab(frostBurst);

        Enemy minion = MakeEnemyPrefab("Minion", "Skeleton_Minion", skeletonController, enemyLayer, SkeletonScale, 6, 1.5f, 5, 1,
                                       new[] { ("Skeleton_Blade", "handslot.r") });
        Enemy rogue = MakeEnemyPrefab("Rogue", "Skeleton_Rogue", rogueOverride, enemyLayer, SkeletonScale, 4, 2.6f, 6, 1,
                                      new (string, string)[0]);
        Enemy warrior = MakeEnemyPrefab("Warrior", "Skeleton_Warrior", warriorOverride, enemyLayer, SkeletonScale, 18, 1f, 12, 2,
                                        new[] { ("Skeleton_Axe", "handslot.r"), ("Skeleton_Shield_Large_A", "handslot.l") });
        Enemy boss = MakeEnemyPrefab("Bone Mage", "Skeleton_Mage", bossOverride, enemyLayer, BossScale, 150, 0.7f, 100, 5,
                                     new[] { ("Skeleton_Staff", "handslot.r") });

        Tower arrowTower = MakeCrewTower("Arrow Tower", "green", "Ranger", ("bow_withString", "handslot.l"), crewController, arrow,
            LoadClip(AudioFolder + "/Bow.wav"),
            new[] { new[] { 50f, 4f, 1f, 1f, 0f, 1f, 0f }, new[] { 40f, 4.5f, 2f, 0.85f, 0f, 1f, 0f }, new[] { 70f, 5f, 3f, 0.7f, 0f, 1f, 0f } },
            towerController);
        Tower catapultTower = MakeCatapultTower(catapultOverride, stone, towerController);
        Tower frostTower = MakeCrewTower("Frost Tower", "blue", "Mage", ("staff", "handslot.r"), mageOverride, bolt,
            LoadClip(AudioFolder + "/Frost.wav"),
            new[] { new[] { 60f, 3.5f, 1f, 1.2f, 0f, 0.5f, 2f }, new[] { 50f, 4f, 1f, 1.2f, 0f, 0.5f, 2.5f }, new[] { 80f, 4.5f, 2f, 1.2f, 1f, 0.5f, 3f } },
            towerController);

        var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);

        // A new scene lets go of the prefabs made above: load them again for the scene to point at.
        var enemyKinds = new Dictionary<string, Enemy>
        {
            { "Minion", LoadPrefab<Enemy>("Minion") },
            { "Rogue", LoadPrefab<Enemy>("Rogue") },
            { "Warrior", LoadPrefab<Enemy>("Warrior") },
            { "Bone Mage", LoadPrefab<Enemy>("Bone Mage") },
        };
        arrowTower = LoadPrefab<Tower>("Arrow Tower");
        catapultTower = LoadPrefab<Tower>("Catapult Tower");
        frostTower = LoadPrefab<Tower>("Frost Tower");

        // ---- The camera: the whole battlefield on any screen (Chapters 1 and 14) ----
        var cameraObject = new GameObject("Main Camera");
        cameraObject.tag = "MainCamera";
        var cam = cameraObject.AddComponent<Camera>();
        cam.clearFlags = CameraClearFlags.SolidColor;
        cam.backgroundColor = Hex("#1D2128");
        cam.nearClipPlane = 0.3f;
        cam.farClipPlane = 120f;
        cam.usePhysicalProperties = true;               // Physical Camera, so Gate Fit can keep the frame
        cam.sensorSize = new Vector2(36f, 20.25f);      // a 16:9 frame
        cam.gateFit = Camera.GateFitMode.Overscan;      // the whole frame shows on every screen shape
        cam.focalLength = 34.2f;
        cameraObject.transform.position = new Vector3(0.2f, 22.5f, -17.6f);
        cameraObject.transform.LookAt(new Vector3(0.2f, 0f, 0.7f));
        cameraObject.AddComponent<AudioListener>();
        UseThreeDRenderer(cam);

        // ---- The light (Chapter 14) ----
        var sunObject = new GameObject("Directional Light");
        var sun = sunObject.AddComponent<Light>();
        sun.type = LightType.Directional;
        sun.color = Hex("#FFF4E0");
        sun.intensity = 1.3f;
        sun.shadows = LightShadows.Soft;
        sunObject.transform.rotation = Quaternion.Euler(55f, 40f, 0f);
        RenderSettings.ambientMode = AmbientMode.Trilight;
        RenderSettings.ambientSkyColor = Hex("#C9E4F5");
        RenderSettings.ambientEquatorColor = Hex("#A8B9C4");
        RenderSettings.ambientGroundColor = Hex("#5E6B5A");

        // ---- The battlefield, from the map (Chapters 1 and 2) ----
        var gridObject = new GameObject("Battlefield");
        gridObject.transform.position = GridOrigin;
        var grid = gridObject.AddComponent<Grid>();
        grid.cellLayout = GridLayout.CellLayout.Hexagon;
        grid.cellSwizzle = GridLayout.CellSwizzle.XZY;
        grid.cellSize = new Vector3(HexWidth, 2f * HexWidth / Mathf.Sqrt(3f), 1f);
        Transform ground = MakeChild(gridObject.transform, "Ground");
        Transform decor = MakeChild(gridObject.transform, "Decor");
        Transform plotGroup = new GameObject("Build Plots").transform;
        Transform towerGroup = new GameObject("Towers").transform;
        Transform skeletonGroup = new GameObject("Skeletons").transform;
        Transform shotGroup = new GameObject("Shots").transform;

        Dictionary<Vector2Int, char> map = ReadMap();
        List<Vector2Int> road = WalkRoad(map);
        var plots = new List<BuildPlot>();
        var random = new System.Random(7);              // the same "random" trees every build
        foreach (KeyValuePair<Vector2Int, char> cell in map)
        {
            Vector3 position = CellPosition(cell.Key);
            int index = road.IndexOf(cell.Key);
            if (index >= 0)
            {
                (string piece, float yaw) = RoadPiece(road, index);
                Place(ModelFolder + "/hex_road_" + piece + ".fbx", ground, position, yaw, 1f);
                continue;
            }
            Place(ModelFolder + "/hex_grass.fbx", ground, position, 0f, 1f);
            float spin = 60f * random.Next(6);
            switch (cell.Value)
            {
                case 'T':
                    Place(ModelFolder + "/" + Pick(random, "trees_A_large", "trees_A_medium", "trees_B_large", "trees_B_medium", "trees_A_small") + ".fbx", decor, position, spin, 1f);
                    break;
                case 'M':
                    Place(ModelFolder + "/" + Pick(random, "mountain_A_grass_trees", "mountain_B_grass_trees", "mountain_C_grass") + ".fbx", decor, position, spin, 1f);
                    break;
                case 'H':
                    Place(ModelFolder + "/hills_A_trees.fbx", decor, position, spin, 1f);
                    break;
                case 'h':
                    Place(ModelFolder + "/" + Pick(random, "hill_single_A", "hill_single_B") + ".fbx", decor, position, spin, 1f);
                    break;
                case 'X':
                    Place(ModelFolder + "/building_destroyed.fbx", decor, position, 60f, 1f);
                    break;
                case 'b':
                    plots.Add(MakePlot(plotGroup, position, plots.Count + 1, plotLayer));
                    break;
                case '.':
                    if (random.NextDouble() < 0.35)
                    {
                        Vector3 offset = new Vector3((float)random.NextDouble() - 0.5f, 0f, (float)random.NextDouble() - 0.5f);
                        Place(ModelFolder + "/" + Pick(random, "rock_single_A", "rock_single_C", "tree_single_A", "tree_single_B", "rock_single_E") + ".fbx",
                              decor, position + offset, spin, 1f);
                    }
                    break;
            }
        }

        // ---- The castle and the gate (Chapters 2 and 13) ----
        Transform castle = new GameObject("Castle").transform;
        for (int c = 7; c <= 12; c++)
        {
            Place(ModelFolder + "/hex_grass.fbx", castle, CellPosition(new Vector2Int(c, MapRows)), 0f, 1f);
        }
        Place(ModelFolder + "/trees_A_medium.fbx", castle, CellPosition(new Vector2Int(7, MapRows)), 60f, 1f);
        Place(ModelFolder + "/building_castle_blue.fbx", castle, CellPosition(new Vector2Int(10, MapRows)), -150f, 1.1f);
        Place(ModelFolder + "/building_tower_A_blue.fbx", castle, CellPosition(new Vector2Int(8, MapRows)), -150f, 1f);
        Place(ModelFolder + "/building_tower_B_blue.fbx", castle, CellPosition(new Vector2Int(12, MapRows - 1)), -150f, 1f);
        Place(ModelFolder + "/flag_blue.fbx", castle, CellPosition(new Vector2Int(11, MapRows - 2)), -150f, 3f);
        Vector3 gatePosition = CellPosition(road[road.Count - 1]);
        Vector3 along = new Vector3(Mathf.Cos(150f * Mathf.Deg2Rad), 0f, Mathf.Sin(150f * Mathf.Deg2Rad)) * HexWidth;
        Place(ModelFolder + "/wall_straight.fbx", castle, gatePosition + along, -150f, 1f);
        Place(ModelFolder + "/wall_straight.fbx", castle, gatePosition - along, -150f, 1f);
        GameObject gateObject = InstantiateModel(ModelFolder + "/wall_straight_gate.fbx", null);
        gateObject.name = "Gate";
        gateObject.transform.SetPositionAndRotation(gatePosition, Quaternion.Euler(0f, -150f, 0f));
        gateObject.AddComponent<Animator>().runtimeAnimatorController = gateController;
        gateObject.AddComponent<AudioSource>().playOnAwake = false;
        var gate = gateObject.AddComponent<Gate>();

        // ---- The road's waypoints: every road tile's middle, then the gate (Chapter 2) ----
        var pathObject = new GameObject("Road");
        var waypointPath = pathObject.AddComponent<WaypointPath>();
        var waypoints = new List<Transform>();
        for (int i = 0; i < road.Count - 1; i++)
        {
            waypoints.Add(MakeChild(pathObject.transform, "Waypoint " + i, CellPosition(road[i])));
        }
        Vector3 toGate = new Vector3(Mathf.Cos(GateExitAngle * Mathf.Deg2Rad), 0f, Mathf.Sin(GateExitAngle * Mathf.Deg2Rad));
        waypoints.Add(MakeChild(pathObject.transform, "Waypoint " + (road.Count - 1) + " (the gate)", gatePosition - toGate * 0.8f));

        // ---- The game (Chapters 7 and 11 to 13) ----
        var gameObject = new GameObject("Gate Game");
        var game = gameObject.AddComponent<GateGame>();
        var bank = gameObject.AddComponent<Bank>();
        var spawner = gameObject.AddComponent<WaveSpawner>();
        var picker = gameObject.AddComponent<Picker>();
        var soundSource = gameObject.AddComponent<AudioSource>();
        soundSource.playOnAwake = false;
        var musicSource = gameObject.AddComponent<AudioSource>();
        musicSource.playOnAwake = false;
        musicSource.loop = true;
        musicSource.volume = 0.5f;

        var ringObject = new GameObject("Range Ring");
        var line = ringObject.AddComponent<LineRenderer>();
        line.useWorldSpace = true;
        line.widthMultiplier = 0.08f;
        line.sharedMaterial = particleMaterial;
        line.startColor = new Color(1f, 1f, 1f, 0.85f);
        line.endColor = new Color(1f, 1f, 1f, 0.85f);
        line.shadowCastingMode = ShadowCastingMode.Off;
        var rangeRing = ringObject.AddComponent<RangeRing>();

        // ---- The screen (Chapters 7, 10, 11 and 12) ----
        Transform ui = MakeCanvas("Canvas");
        TMP_Text goldText = MakeHudBar(ui, "Gold", sprites["Coin"], new Vector2(30f, -30f), "120");
        TMP_Text livesText = MakeHudBar(ui, "Lives", sprites["Hearts"], new Vector2(320f, -30f), "10");
        TMP_Text waveText = MakeHudBar(ui, "Wave", sprites["Skull"], new Vector2(610f, -30f), "Wave 0 / 10");
        ((RectTransform)waveText.transform.parent).sizeDelta = new Vector2(340f, 95f);     // room for "Wave 10 / 10"
        waveText.rectTransform.sizeDelta = new Vector2(230f, 80f);
        waveText.fontSize = 34f;

        Button speedButton = MakeSquareButton(ui, "Speed Button", new Vector2(1f, 1f), new Vector2(-170f, -30f), 120f, null, true);
        TMP_Text speedText = MakeLabel(speedButton.transform, "Label", "x2", 52f, Vector2.zero, new Vector2(120f, 120f), HudInk);
        Button pauseButton = MakeSquareButton(ui, "Pause Button", new Vector2(1f, 1f), new Vector2(-30f, -30f), 120f, null, false);
        pauseButton.GetComponent<Image>().sprite = sprites["PauseButton"];

        TMP_Text messageText = MakeLabel(ui, "Message Text", "", 64f, new Vector2(0f, 300f), new Vector2(1400f, 100f), HudInk);
        TMP_Text countdownText = MakeLabel(ui, "Countdown Text", "", 40f, new Vector2(0f, -330f), new Vector2(1400f, 70f), HudInk);
        Button startWaveButton = MakeWideButton(ui, "Start Wave Button", "Start Wave", new Vector2(0f, -430f), new Vector2(360f, 140f));
        Image swords = MakeImage(startWaveButton.transform, "Icon", Color.white, new Vector2(0f, 0.5f), new Vector2(34f, 4f), new Vector2(64f, 64f));
        swords.sprite = sprites["CrossedSwords"];
        RectTransform startWaveLabel = (RectTransform)startWaveButton.transform.Find("Label");
        startWaveLabel.anchoredPosition = new Vector2(30f, 4f);
        startWaveButton.gameObject.SetActive(false);    // the spawner shows it while it waits for a wave

        // The build menu: three towers, over the plot (Chapter 7)
        RectTransform buildRect = MakeMenu(ui, "Build Menu", sprites["PanelRibbon"], new Vector2(450f, 343f));
        MakeLabel(buildRect, "Title", "Build", 40f, new Vector2(0f, 136f), new Vector2(300f, 60f), Ink);
        string[] towerIcons = { "Bow", "Catapult", "Frost" };
        Tower[] towerPrefabs = { arrowTower, catapultTower, frostTower };
        var buildButtons = new Button[3];
        var priceTexts = new TMP_Text[3];
        for (int i = 0; i < 3; i++)
        {
            float x = (i - 1) * 130f;
            buildButtons[i] = MakeSquareButton(buildRect, towerIcons[i] + " Button", new Vector2(0.5f, 0.5f), new Vector2(x, 20f), 112f, sprites[towerIcons[i]], true);
            Image coin = MakeImage(buildRect, towerIcons[i] + " Coin", Color.white, new Vector2(0.5f, 0.5f), new Vector2(x - 30f, -70f), new Vector2(36f, 38f));
            coin.sprite = sprites["Coin"];
            priceTexts[i] = MakeLabel(buildRect, towerIcons[i] + " Price", "50", 36f, new Vector2(x + 18f, -70f), new Vector2(80f, 50f), Ink);
        }
        var buildMenu = buildRect.gameObject.AddComponent<BuildMenu>();
        buildRect.gameObject.SetActive(false);

        // The tower menu: stars, Upgrade and Sell (Chapter 10)
        RectTransform towerRect = MakeMenu(ui, "Tower Menu", sprites["PanelPlain"], new Vector2(470f, 322f));
        TMP_Text towerTitle = MakeLabel(towerRect, "Title", "Arrow Tower", 40f, new Vector2(0f, 100f), new Vector2(400f, 56f), Ink);
        var stars = new Image[3];
        for (int i = 0; i < 3; i++)
        {
            stars[i] = MakeImage(towerRect, "Star " + (i + 1), Color.white, new Vector2(0.5f, 0.5f), new Vector2((i - 1) * 52f, 52f), new Vector2(44f, 41f));
            stars[i].sprite = sprites["Star"];
        }
        Button upgradeButton = MakeSquareButton(towerRect, "Upgrade Button", new Vector2(0.5f, 0.5f), new Vector2(-90f, -30f), 104f, null, false);
        upgradeButton.GetComponent<Image>().sprite = sprites["UpgradeButton"];
        SpriteState upgradeSprites = upgradeButton.spriteState;
        upgradeSprites.disabledSprite = sprites["UpgradeButtonLocked"];
        upgradeButton.spriteState = upgradeSprites;
        upgradeButton.transition = Selectable.Transition.SpriteSwap;
        TMP_Text upgradeText = MakeLabel(towerRect, "Upgrade Price", "40", 34f, new Vector2(-90f, -112f), new Vector2(150f, 50f), Ink);
        Button sellButton = MakeSquareButton(towerRect, "Sell Button", new Vector2(0.5f, 0.5f), new Vector2(90f, -30f), 104f, sprites["Sell"], true);
        TMP_Text sellText = MakeLabel(towerRect, "Sell Value", "Sell 30", 34f, new Vector2(90f, -112f), new Vector2(170f, 50f), Ink);
        var towerMenu = towerRect.gameObject.AddComponent<TowerMenu>();
        towerRect.gameObject.SetActive(false);

        // Start panel: the title, how to play, Play, and the icons' credits (Chapter 13)
        GameObject startPanel = MakePanel(ui, "Start Panel", sprites["PanelSquare"], new Vector2(760f, 806f), "Gate Guard", out RectTransform startWindow);
        MakeLabel(startWindow, "How To Play",
                  "Skeletons are marching on the castle gate.\n\n" +
                  "Tap a dirt plot to build a tower.\nTap a tower to upgrade it, or sell it.\n\n" +
                  "Arrows hit one skeleton, stones hit a crowd,\nand frost slows them down.\n\nHold the gate for ten waves!",
                  30f, new Vector2(0f, 40f), new Vector2(620f, 470f), Ink);
        Button playButton = MakeWideButton(startWindow, "Play Button", "Play", new Vector2(0f, -245f), new Vector2(300f, 118f));
        MakeLabel(startWindow, "Credits", "Icons by Lorc, Delapouite, Skoll and sbed:\ngame-icons.net, CC BY 3.0", 18f,
                  new Vector2(0f, -332f), new Vector2(640f, 50f), Ink);

        // Pause panel: Resume, Restart and the volume (Chapter 13)
        GameObject pausePanel = MakePanel(ui, "Pause Panel", sprites["PanelTall"], new Vector2(520f, 700f), "Paused", out RectTransform pauseWindow);
        Button resumeButton = MakeWideButton(pauseWindow, "Resume Button", "Resume", new Vector2(0f, 120f), new Vector2(300f, 118f));
        Button restartButton = MakeWideButton(pauseWindow, "Restart Button", "Restart", new Vector2(0f, -20f), new Vector2(300f, 118f));
        MakeLabel(pauseWindow, "Volume Label", "Volume", 32f, new Vector2(0f, -130f), new Vector2(300f, 50f), Ink);
        Slider volumeSlider = MakeSlider(pauseWindow, "Volume Slider", new Vector2(0f, -190f), 300f);
        volumeSlider.transform.localScale = new Vector3(1.4f, 1.4f, 1f);
        volumeSlider.value = 1f;
        var pauseMenu = pausePanel.AddComponent<PauseMenu>();

        // Win and lose panels (Chapter 13)
        GameObject winPanel = MakePanel(ui, "Win Panel", sprites["PanelSquare"], new Vector2(700f, 742f), "Victory!", out RectTransform winWindow);
        Image crown = MakeImage(winWindow, "Crown", Color.white, new Vector2(0.5f, 1f), new Vector2(0f, -70f), new Vector2(240f, 164f));
        crown.sprite = sprites["Crown"];
        TMP_Text winText = MakeLabel(winWindow, "Win Text", "The gate held!", 40f, new Vector2(0f, 30f), new Vector2(600f, 300f), Ink);
        Button playAgainButton = MakeWideButton(winWindow, "Play Again Button", "Play Again", new Vector2(0f, -230f), new Vector2(330f, 124f));
        GameObject losePanel = MakePanel(ui, "Lose Panel", sprites["PanelSquare"], new Vector2(700f, 742f), "Defeat", out RectTransform loseWindow);
        MakeLabel(loseWindow, "Lose Text", "The gate has fallen", 44f, new Vector2(0f, 40f), new Vector2(600f, 200f), Ink);
        Button tryAgainButton = MakeWideButton(loseWindow, "Try Again Button", "Try Again", new Vector2(0f, -230f), new Vector2(330f, 124f));

        pausePanel.SetActive(false);
        winPanel.SetActive(false);
        losePanel.SetActive(false);

        // ---- Wire up every Inspector reference ----
        foreach (BuildPlot plot in plots)
        {
            Set(plot, "game", game);
            Set(plot, "towerGroup", towerGroup);
            Set(plot, "shotGroup", shotGroup);
        }
        SetArray(waypointPath, "waypoints", waypoints.ToArray());
        Set(gate, "game", game);
        Set(gate, "bank", bank);
        Set(gate, "hitSound", LoadClip(AudioFolder + "/GateHit.wav"));
        Set(gate, "breakSound", LoadClip(AudioFolder + "/GateBreak.wav"));

        Set(bank, "goldText", goldText);
        Set(bank, "livesText", livesText);

        Set(spawner, "game", game);
        Set(spawner, "bank", bank);
        Set(spawner, "path", waypointPath);
        Set(spawner, "skeletonGroup", skeletonGroup);
        SetWaves(spawner, enemyKinds);
        Set(spawner, "startWaveButton", startWaveButton);
        Set(spawner, "countdownText", countdownText);
        Set(spawner, "waveText", waveText);
        Set(spawner, "waveSound", LoadClip(AudioFolder + "/WaveStart.wav"));

        Set(picker, "game", game);
        SetLayerMask(picker, "plotMask", "Plot");
        Set(picker, "buildMenu", buildMenu);
        Set(picker, "towerMenu", towerMenu);

        Set(buildMenu, "bank", bank);
        SetArray(buildMenu, "towerPrefabs", towerPrefabs);
        SetArray(buildMenu, "buttons", buildButtons);
        SetArray(buildMenu, "priceTexts", priceTexts);

        Set(towerMenu, "bank", bank);
        Set(towerMenu, "rangeRing", rangeRing);
        Set(towerMenu, "titleText", towerTitle);
        SetArray(towerMenu, "stars", stars);
        Set(towerMenu, "upgradeButton", upgradeButton);
        Set(towerMenu, "upgradeText", upgradeText);
        Set(towerMenu, "sellButton", sellButton);
        Set(towerMenu, "sellText", sellText);
        Set(towerMenu, "audioSource", soundSource);
        Set(towerMenu, "sellSound", LoadClip(AudioFolder + "/Sell.wav"));

        Set(game, "bank", bank);
        Set(game, "gate", gate);
        Set(game, "spawner", spawner);
        Set(game, "picker", picker);
        Set(game, "plots", plotGroup);
        Set(game, "skeletons", skeletonGroup);
        Set(game, "shots", shotGroup);
        Set(game, "messageText", messageText);
        Set(game, "startPanel", startPanel);
        Set(game, "playButton", playButton);
        Set(game, "pauseButton", pauseButton);
        Set(game, "speedButton", speedButton);
        Set(game, "speedText", speedText);
        Set(game, "pausePanel", pausePanel);
        Set(game, "winPanel", winPanel);
        Set(game, "winText", winText);
        Set(game, "playAgainButton", playAgainButton);
        Set(game, "losePanel", losePanel);
        Set(game, "tryAgainButton", tryAgainButton);
        Set(game, "soundSource", soundSource);
        Set(game, "musicSource", musicSource);
        Set(game, "buildMusic", LoadClip(AudioFolder + "/Road.ogg"));
        Set(game, "battleMusic", LoadClip(AudioFolder + "/Tension.ogg"));
        Set(game, "winSound", LoadClip(AudioFolder + "/Win.wav"));
        Set(game, "loseSound", LoadClip(AudioFolder + "/Lose.wav"));

        Set(pauseMenu, "game", game);
        Set(pauseMenu, "resumeButton", resumeButton);
        Set(pauseMenu, "restartButton", restartButton);
        Set(pauseMenu, "volumeSlider", volumeSlider);

        AssetDatabase.SaveAssets();
        SaveScene(scene, ScenePath);
        Debug.Log("Gate Guard scene built: " + ScenePath);
    }

    // ------------------------------------------------------------------ the map

    static Dictionary<Vector2Int, char> ReadMap()
    {
        var map = new Dictionary<Vector2Int, char>();
        int line = 0;
        foreach (string text in File.ReadAllLines(MapPath))
        {
            if (text.StartsWith("#") || text.Trim().Length == 0)
            {
                continue;
            }
            string[] marks = text.Split(new[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
            int row = MapRows - 1 - line;              // the first line is the far (north) edge
            for (int column = 0; column < marks.Length; column++)
            {
                map[new Vector2Int(column, row)] = marks[column][0];
            }
            line++;
        }
        return map;
    }

    // A tile's middle in the world. Odd rows sit half a hex to the right,
    // as the Grid's Hexagon layout puts them.
    static Vector3 CellPosition(Vector2Int cell)
    {
        float x = cell.x * HexWidth + ((cell.y & 1) == 1 ? HexWidth / 2f : 0f);
        return GridOrigin + new Vector3(x, 0f, cell.y * RowStep);
    }

    // The road, in order, from S to G: each road tile touches the next one.
    static List<Vector2Int> WalkRoad(Dictionary<Vector2Int, char> map)
    {
        var roadCells = new List<Vector2Int>();
        Vector2Int start = Vector2Int.zero;
        foreach (KeyValuePair<Vector2Int, char> cell in map)
        {
            if (cell.Value == '=' || cell.Value == 'S' || cell.Value == 'G')
            {
                roadCells.Add(cell.Key);
            }
            if (cell.Value == 'S')
            {
                start = cell.Key;
            }
        }
        var road = new List<Vector2Int> { start };
        while (map[road[road.Count - 1]] != 'G')
        {
            Vector2Int here = road[road.Count - 1];
            bool found = false;
            foreach (Vector2Int cell in roadCells)
            {
                if (!road.Contains(cell) && Vector3.Distance(CellPosition(cell), CellPosition(here)) < HexWidth + 0.1f)
                {
                    road.Add(cell);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                throw new System.Exception("The road stops at " + here + ": check GateGuardMap.txt");
            }
        }
        return road;
    }

    static float AngleTo(Vector2Int from, Vector2Int to)
    {
        Vector3 d = CellPosition(to) - CellPosition(from);
        return Mathf.Repeat(Mathf.Round(Mathf.Atan2(d.z, d.x) * Mathf.Rad2Deg), 360f);
    }

    // Which road tile, and how far to turn it (Y rotation, clockwise seen from
    // above). Angles are counted anticlockwise from east, with north up. As
    // imported, A joins east and west, B joins east and south-west, M ends
    // at the east edge.
    static (string, float) RoadPiece(List<Vector2Int> road, int index)
    {
        float toNext = index < road.Count - 1 ? AngleTo(road[index], road[index + 1]) : GateExitAngle;
        if (index == 0)
        {
            return ("M", -toNext);
        }
        float toPrevious = AngleTo(road[index], road[index - 1]);
        float difference = Mathf.Repeat(toNext - toPrevious, 360f);
        if (Mathf.Approximately(difference, 180f))
        {
            return ("A", -toPrevious);
        }
        if (Mathf.Approximately(difference, 240f))
        {
            return ("B", -toPrevious);
        }
        if (Mathf.Approximately(difference, 120f))
        {
            return ("B", -toNext);
        }
        throw new System.Exception($"No road tile turns {difference}° at road tile {index}");
    }

    static string Pick(System.Random random, params string[] names)
    {
        return names[random.Next(names.Length)];
    }

    // ------------------------------------------------------------------ import

    static void ImportArt()
    {
        foreach (string file in Directory.GetFiles(ModelFolder, "*.fbx"))
        {
            ImportModel(file.Replace('\\', '/'), false);
        }
        foreach (string file in Directory.GetFiles(WeaponFolder, "*.fbx"))
        {
            ImportModel(file.Replace('\\', '/'), false);
        }
        foreach (string file in Directory.GetFiles(CharacterFolder, "*.fbx"))
        {
            ImportModel(file.Replace('\\', '/'), true);
        }
        foreach (string file in Directory.GetFiles(ClipFolder, "*.fbx"))
        {
            ImportClips(file.Replace('\\', '/'));
        }
        foreach (string file in Directory.GetFiles(UiFolder, "*.png"))
        {
            ImportUiSprite(file.Replace('\\', '/'));
        }
        foreach (string file in Directory.GetFiles(IconFolder, "*.png"))
        {
            ImportUiSprite(file.Replace('\\', '/'));
        }
    }

    // A model: Humanoid with its own Avatar (a character), or no rig at all.
    // No animation, cameras, lights or colliders come in with it.
    static void ImportModel(string path, bool humanoid)
    {
        var importer = (ModelImporter)AssetImporter.GetAtPath(path);
        ModelImporterAnimationType type = humanoid ? ModelImporterAnimationType.Human : ModelImporterAnimationType.None;
        bool changed = importer.animationType != type || importer.importAnimation || importer.importCameras
                       || importer.importLights || importer.addCollider
                       || (humanoid && importer.avatarSetup != ModelImporterAvatarSetup.CreateFromThisModel);
        if (!changed)
        {
            return;
        }
        importer.animationType = type;
        if (humanoid)
        {
            importer.avatarSetup = ModelImporterAvatarSetup.CreateFromThisModel;
        }
        importer.importAnimation = false;
        importer.importCameras = false;
        importer.importLights = false;
        importer.addCollider = false;
        importer.SaveAndReimport();
    }

    // A clip file, as the book sets it up in the Import Settings: Humanoid,
    // every clip's root baked into its pose (the code moves the skeletons, not
    // the clips), Loop Time on the clips that repeat, and the Animation Events.
    static void ImportClips(string path)
    {
        var importer = (ModelImporter)AssetImporter.GetAtPath(path);
        if (importer.animationType != ModelImporterAnimationType.Human || !importer.importAnimation
            || importer.avatarSetup != ModelImporterAvatarSetup.CreateFromThisModel)
        {
            importer.animationType = ModelImporterAnimationType.Human;
            importer.avatarSetup = ModelImporterAvatarSetup.CreateFromThisModel;
            importer.importAnimation = true;
            importer.importCameras = false;
            importer.importLights = false;
            importer.SaveAndReimport();
        }

        ModelImporterClipAnimation[] clips = importer.defaultClipAnimations;
        foreach (ModelImporterClipAnimation clip in clips)
        {
            int bar = clip.name.LastIndexOf('|');
            clip.name = bar >= 0 ? clip.name.Substring(bar + 1) : clip.name;
            clip.loopTime = System.Array.IndexOf(LoopingClips, clip.name) >= 0;
            clip.lockRootRotation = true;
            clip.keepOriginalOrientation = true;
            clip.lockRootHeightY = true;
            clip.keepOriginalPositionY = true;
            clip.lockRootPositionXZ = true;
            clip.keepOriginalPositionXZ = true;
            clip.events = ClipEvents.TryGetValue(clip.name, out (string method, float time) e)
                ? new[] { new AnimationEvent { functionName = e.method, time = e.time } }
                : new AnimationEvent[0];
        }
        if (!SameClips(importer.clipAnimations, clips))
        {
            importer.clipAnimations = clips;
            importer.SaveAndReimport();
        }
    }

    static bool SameClips(ModelImporterClipAnimation[] a, ModelImporterClipAnimation[] b)
    {
        if (a.Length != b.Length)
        {
            return false;
        }
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i].name != b[i].name || a[i].loopTime != b[i].loopTime || !a[i].lockRootPositionXZ
                || a[i].events.Length != b[i].events.Length)
            {
                return false;
            }
            for (int e = 0; e < a[i].events.Length; e++)
            {
                if (a[i].events[e].functionName != b[i].events[e].functionName || !Mathf.Approximately(a[i].events[e].time, b[i].events[e].time))
                {
                    return false;
                }
            }
        }
        return true;
    }

    static AnimationClip Clip(string file, string name)
    {
        foreach (Object asset in AssetDatabase.LoadAllAssetsAtPath(ClipFolder + "/" + file + ".fbx"))
        {
            if (asset is AnimationClip clip && clip.name == name)
            {
                return clip;
            }
        }
        throw new System.Exception("No clip " + name + " in " + file);
    }

    // The GUI pictures: smooth, not pixel art, so Bilinear filtering.
    static void ImportUiSprite(string path)
    {
        var importer = (TextureImporter)AssetImporter.GetAtPath(path);
        if (importer.textureType != TextureImporterType.Sprite || importer.spriteImportMode != SpriteImportMode.Single
            || importer.mipmapEnabled || importer.filterMode != FilterMode.Bilinear)
        {
            importer.textureType = TextureImporterType.Sprite;
            importer.spriteImportMode = SpriteImportMode.Single;
            importer.spritePixelsPerUnit = 100f;
            importer.mipmapEnabled = false;
            importer.filterMode = FilterMode.Bilinear;
            importer.alphaIsTransparency = true;
            importer.SaveAndReimport();
        }
        sprites[Path.GetFileNameWithoutExtension(path)] = AssetDatabase.LoadAssetAtPath<Sprite>(path);
    }

    // ------------------------------------------------------------------ animation

    // The skeletons' controller (Chapters 4 and 5): Rise, then Walk, whose
    // speed is the WalkSpeed parameter; Attack at the gate; Die and Cheer from
    // Any State.
    static AnimatorController MakeSkeletonController()
    {
        AnimatorController controller = MakeController(AnimationFolder + "/Skeleton.controller");
        controller.AddParameter("WalkSpeed", AnimatorControllerParameterType.Float);
        AnimatorControllerParameter[] parameters = controller.parameters;
        parameters[0].defaultFloat = 1f;
        controller.parameters = parameters;
        controller.AddParameter("Die", AnimatorControllerParameterType.Trigger);
        controller.AddParameter("Attack", AnimatorControllerParameterType.Trigger);
        controller.AddParameter("Cheer", AnimatorControllerParameterType.Trigger);

        AnimatorState rise = AddState(controller, "Rise", Clip("Rig_Medium_Special", "Skeletons_Spawn_Ground"), new Vector2(250f, 0f));
        rise.speed = 2f;
        AnimatorState walk = AddState(controller, "Walk", Clip("Rig_Medium_Special", "Skeletons_Walking"), new Vector2(250f, 100f));
        walk.speedParameterActive = true;
        walk.speedParameter = "WalkSpeed";
        AnimatorState attack = AddState(controller, "Attack", Clip("Rig_Medium_CombatMelee", "Melee_1H_Attack_Chop"), new Vector2(250f, 200f));
        AnimatorState die = AddState(controller, "Die", Clip("Rig_Medium_Special", "Skeletons_Death"), new Vector2(550f, 50f));
        AnimatorState cheer = AddState(controller, "Cheer", Clip("Rig_Medium_Simulation", "Cheering"), new Vector2(550f, 150f));
        controller.layers[0].stateMachine.defaultState = rise;

        Blend(AddTransition(rise, walk, true));
        Blend(AddTransition(walk, attack, false)).AddCondition(AnimatorConditionMode.If, 0f, "Attack");
        Blend(AddAnyStateTransition(controller, die)).AddCondition(AnimatorConditionMode.If, 0f, "Die");
        Blend(AddAnyStateTransition(controller, cheer)).AddCondition(AnimatorConditionMode.If, 0f, "Cheer");
        EditorUtility.SetDirty(controller);
        return controller;
    }

    // The tower crews' controller (Chapter 8): Idle and Aim on the Aiming
    // Bool, Shoot on the Fire trigger, back to Aim when the clip ends. Shoot
    // plays at double speed, so a crew keeps up with its tower's reload.
    static AnimatorController MakeCrewController()
    {
        AnimatorController controller = MakeController(AnimationFolder + "/Crew.controller");
        controller.AddParameter("Aiming", AnimatorControllerParameterType.Bool);
        controller.AddParameter("Fire", AnimatorControllerParameterType.Trigger);
        AnimatorState idle = AddState(controller, "Idle", Clip("Rig_Medium_CombatRanged", "Ranged_Bow_Idle"), new Vector2(250f, 0f));
        AnimatorState aim = AddState(controller, "Aim", Clip("Rig_Medium_CombatRanged", "Ranged_Bow_Aiming_Idle"), new Vector2(250f, 100f));
        AnimatorState shoot = AddState(controller, "Shoot", Clip("Rig_Medium_CombatRanged", "Ranged_Bow_Release"), new Vector2(250f, 200f));
        shoot.speed = 2f;
        controller.layers[0].stateMachine.defaultState = idle;
        Blend(AddTransition(idle, aim, false)).AddCondition(AnimatorConditionMode.If, 0f, "Aiming");
        Blend(AddTransition(aim, idle, false)).AddCondition(AnimatorConditionMode.IfNot, 0f, "Aiming");
        Blend(AddTransition(aim, shoot, false)).AddCondition(AnimatorConditionMode.If, 0f, "Fire");
        AnimatorStateTransition back = Blend(AddTransition(shoot, aim, true));
        back.exitTime = 0.9f;
        EditorUtility.SetDirty(controller);
        return controller;
    }

    static AnimatorStateTransition Blend(AnimatorStateTransition transition)
    {
        transition.duration = 0.1f;         // 3D bodies blend from one clip into the next
        return transition;
    }

    // The catapult runs the crews' controller too, with property clips that
    // turn its arm (Chapter 9): at rest, wound back, and the throw, whose
    // OnRelease comes as the spoon passes the top.
    static AnimatorOverrideController MakeCatapultOverride(AnimatorController crew)
    {
        string arm = "catapult_turret_red/catapult_arm_red";
        AnimationClip rest = MakePropertyClip(AnimationFolder + "/Arm Rest.anim", 30f, true);
        SetArmCurve(rest, arm, new[] { 0f, 1f }, new[] { 0f, 0f });
        AnimationClip wound = MakePropertyClip(AnimationFolder + "/Arm Wound.anim", 30f, true);
        SetArmCurve(wound, arm, new[] { 0f, 1f }, new[] { -40f, -40f });
        AnimationClip thrown = MakePropertyClip(AnimationFolder + "/Arm Throw.anim", 30f, false);
        SetArmCurve(thrown, arm, new[] { 0f, 0.2f, 0.6f, 1f }, new[] { -40f, 95f, 95f, -40f });
        SetEvents(thrown, new[] { 4f / 30f }, new[] { "OnRelease" });     // 0:04
        return MakeOverrideController(AnimationFolder + "/Catapult Override.overrideController", crew,
            new[] { Clip("Rig_Medium_CombatRanged", "Ranged_Bow_Idle"), Clip("Rig_Medium_CombatRanged", "Ranged_Bow_Aiming_Idle"), Clip("Rig_Medium_CombatRanged", "Ranged_Bow_Release") },
            new[] { rest, wound, thrown });
    }

    static void SetArmCurve(AnimationClip clip, string path, float[] times, float[] degrees)
    {
        SetCurve(clip, path, typeof(Transform), "localEulerAnglesRaw.x", times, degrees);
        SetCurve(clip, path, typeof(Transform), "localEulerAnglesRaw.y", times, new float[times.Length]);
        SetCurve(clip, path, typeof(Transform), "localEulerAnglesRaw.z", times, new float[times.Length]);
    }

    // Every tower's body (Chapter 10): one state per Level. Each clip pops the
    // tower, switches the second storey and the flags on or off (Is Active
    // keys), and lifts the crew.
    static AnimatorController MakeTowerController()
    {
        AnimatorController controller = MakeController(AnimationFolder + "/Tower.controller");
        controller.AddParameter("Level", AnimatorControllerParameterType.Int);
        AnimatorControllerParameter[] parameters = controller.parameters;
        parameters[0].defaultInt = 1;
        controller.parameters = parameters;
        for (int level = 1; level <= 3; level++)
        {
            AnimationClip clip = MakePropertyClip(AnimationFolder + $"/Tower Level {level}.anim", 30f, false);
            float[] times = { 0f, 4f / 30f, 8f / 30f };                    // 0:00, 0:04, 0:08
            float[] pop = { 0.9f, 1.1f, 1f };
            SetCurve(clip, "", typeof(Transform), "m_LocalScale.x", times, pop);
            SetCurve(clip, "", typeof(Transform), "m_LocalScale.y", times, pop);
            SetCurve(clip, "", typeof(Transform), "m_LocalScale.z", times, pop);
            float upper = level >= 2 ? 1f : 0f;
            float flags = level == 3 ? 1f : 0f;
            float top = level >= 2 ? TopLevel1 + StoreyHeight : TopLevel1;
            float[] hold = { 0f, 8f / 30f };
            SetCurve(clip, "Upper", typeof(GameObject), "m_IsActive", hold, new[] { upper, upper });
            SetCurve(clip, "Top/Flags", typeof(GameObject), "m_IsActive", hold, new[] { flags, flags });
            SetCurve(clip, "Top", typeof(Transform), "m_LocalPosition.y", hold, new[] { top, top });
            AnimatorState state = AddState(controller, "Level " + level, clip, new Vector2(250f, level * 100f));
            if (level == 1)
            {
                controller.layers[0].stateMachine.defaultState = state;
            }
            AddAnyStateTransition(controller, state).AddCondition(AnimatorConditionMode.Equals, level, "Level");
        }
        EditorUtility.SetDirty(controller);
        return controller;
    }

    // The gate (Chapter 13): Hit makes the doors shudder; Broken throws them open.
    static AnimatorController MakeGateController()
    {
        string left = "wall_straight_gate_door_left";
        string right = "wall_straight_gate_door_right";
        AnimatorController controller = MakeController(AnimationFolder + "/Gate.controller");
        controller.AddParameter("Hit", AnimatorControllerParameterType.Trigger);
        controller.AddParameter("Broken", AnimatorControllerParameterType.Bool);

        AnimationClip shut = MakePropertyClip(AnimationFolder + "/Gate Shut.anim", 30f, true);
        SetDoorCurves(shut, left, right, new[] { 0f, 1f }, new[] { 0f, 0f });
        AnimationClip shudder = MakePropertyClip(AnimationFolder + "/Gate Shudder.anim", 30f, false);
        SetDoorCurves(shudder, left, right, new[] { 0f, 2f / 30f, 5f / 30f, 7f / 30f, 9f / 30f }, new[] { 0f, 4f, -4f, 3f, 0f });
        AnimationClip broken = MakePropertyClip(AnimationFolder + "/Gate Broken.anim", 30f, false);
        SetDoorCurves(broken, left, right, new[] { 0f, 0.6f }, new[] { 0f, 100f });

        AnimatorState shutState = AddState(controller, "Shut", shut, new Vector2(250f, 0f));
        AnimatorState shudderState = AddState(controller, "Shudder", shudder, new Vector2(250f, 100f));
        AnimatorState brokenState = AddState(controller, "Broken", broken, new Vector2(550f, 50f));
        controller.layers[0].stateMachine.defaultState = shutState;
        AddTransition(shutState, shudderState, false).AddCondition(AnimatorConditionMode.If, 0f, "Hit");
        AddTransition(shudderState, shutState, true);
        AddAnyStateTransition(controller, brokenState).AddCondition(AnimatorConditionMode.If, 0f, "Broken");
        EditorUtility.SetDirty(controller);
        return controller;
    }

    // The two doors turn the opposite ways about their hinges.
    static void SetDoorCurves(AnimationClip clip, string left, string right, float[] times, float[] degrees)
    {
        var opposite = new float[degrees.Length];
        for (int i = 0; i < degrees.Length; i++)
        {
            opposite[i] = -degrees[i];
        }
        float[] zero = new float[times.Length];
        SetCurve(clip, left, typeof(Transform), "localEulerAnglesRaw.x", times, zero);
        SetCurve(clip, left, typeof(Transform), "localEulerAnglesRaw.y", times, degrees);
        SetCurve(clip, left, typeof(Transform), "localEulerAnglesRaw.z", times, zero);
        SetCurve(clip, right, typeof(Transform), "localEulerAnglesRaw.x", times, zero);
        SetCurve(clip, right, typeof(Transform), "localEulerAnglesRaw.y", times, opposite);
        SetCurve(clip, right, typeof(Transform), "localEulerAnglesRaw.z", times, zero);
    }

    // ------------------------------------------------------------------ prefabs

    static GameObject InstantiateModel(string path, Transform parent)
    {
        var model = AssetDatabase.LoadAssetAtPath<GameObject>(path);
        if (model == null)
        {
            throw new System.Exception("Missing model: " + path);
        }
        var go = (GameObject)PrefabUtility.InstantiatePrefab(model, parent);
        PrefabUtility.UnpackPrefabInstance(go, PrefabUnpackMode.Completely, InteractionMode.AutomatedAction);
        return go;
    }

    // A model placed in the scene, still linked to its FBX (as dragging it in does).
    static GameObject Place(string path, Transform parent, Vector3 position, float yaw, float scale)
    {
        var model = AssetDatabase.LoadAssetAtPath<GameObject>(path);
        if (model == null)
        {
            throw new System.Exception("Missing model: " + path);
        }
        var go = (GameObject)PrefabUtility.InstantiatePrefab(model, parent);
        go.transform.SetPositionAndRotation(position, Quaternion.Euler(0f, yaw, 0f));
        go.transform.localScale = Vector3.one * scale;
        return go;
    }

    static Transform MakeChild(Transform parent, string name)
    {
        return MakeChild(parent, name, parent.position);
    }

    static Transform MakeChild(Transform parent, string name, Vector3 position)
    {
        var child = new GameObject(name).transform;
        child.SetParent(parent, false);
        child.position = position;
        return child;
    }

    static T SavePrefab<T>(GameObject go, string name) where T : Component
    {
        string path = PrefabFolder + "/" + name + ".prefab";
        GameObject saved = PrefabUtility.SaveAsPrefabAsset(go, path);
        Object.DestroyImmediate(go);
        return saved.GetComponent<T>();
    }

    static T LoadPrefab<T>(string name) where T : Component
    {
        return AssetDatabase.LoadAssetAtPath<GameObject>(PrefabFolder + "/" + name + ".prefab").GetComponent<T>();
    }

    static T Find<T>(GameObject root, string name) where T : Component
    {
        foreach (T found in root.GetComponentsInChildren<T>(true))
        {
            if (found.name == name)
            {
                return found;
            }
        }
        throw new System.Exception("No " + name + " in " + root.name);
    }

    // One kind of skeleton (Chapters 3 and 6): the model with its Avatar, the
    // Skeleton controller or an override, its weapons on its hand bones, a
    // health bar and frost, and its numbers.
    static Enemy MakeEnemyPrefab(string name, string model, RuntimeAnimatorController controller, int layer, float scale,
                                 int health, float speed, int bounty, int livesCost, (string weapon, string bone)[] weapons)
    {
        GameObject root = InstantiateModel(CharacterFolder + "/" + model + ".fbx", null);
        root.name = name;
        root.layer = layer;
        root.transform.localScale = Vector3.one * scale;
        Animator animator = root.GetComponent<Animator>();
        animator.runtimeAnimatorController = controller;
        animator.applyRootMotion = false;
        var capsule = root.AddComponent<CapsuleCollider>();
        capsule.isTrigger = true;
        capsule.center = new Vector3(0f, 1.1f, 0f);
        capsule.radius = 0.5f;
        capsule.height = 2.2f;
        var body = root.AddComponent<Rigidbody>();
        body.isKinematic = true;
        body.useGravity = false;
        var audio = root.AddComponent<AudioSource>();
        audio.playOnAwake = false;
        foreach ((string weapon, string bone) in weapons)
        {
            InstantiateModel(WeaponFolder + "/" + weapon + ".fbx", Find<Transform>(root, bone));
        }

        // The health bar: a World Space Canvas, above the head
        var barObject = new GameObject("Health Bar", typeof(RectTransform));
        barObject.transform.SetParent(root.transform, false);
        var canvas = barObject.AddComponent<Canvas>();
        canvas.renderMode = RenderMode.WorldSpace;
        var barRect = (RectTransform)barObject.transform;
        barRect.sizeDelta = new Vector2(100f, 14f);
        barRect.localPosition = new Vector3(0f, 2.75f, 0f);
        barRect.localScale = Vector3.one * (0.8f / 100f / SkeletonScale);
        Image back = MakeImage(barRect, "Back", new Color(0f, 0f, 0f, 0.6f), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(100f, 14f));
        Image fill = MakeImage(barRect, "Fill", Color.white, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(96f, 10f));
        fill.sprite = sprites["HealthFill"];
        fill.type = Image.Type.Filled;
        fill.fillMethod = Image.FillMethod.Horizontal;
        fill.fillOrigin = (int)Image.OriginHorizontal.Left;
        back.raycastTarget = false;
        var healthBar = barObject.AddComponent<EnemyHealthBar>();
        Set(healthBar, "fill", fill);

        // Frost, shown while it's slowed
        GameObject frost = MakeFrostAura(root.transform);

        var enemy = root.AddComponent<Enemy>();
        SetInt(enemy, "maxHealth", health);
        SetFloat(enemy, "speed", speed);
        SetInt(enemy, "bounty", bounty);
        SetInt(enemy, "livesCost", livesCost);
        Set(enemy, "healthBar", healthBar);
        Set(enemy, "frost", frost);
        Set(enemy, "hitSound", LoadClip(AudioFolder + "/Bones.wav"));
        Set(enemy, "deathSound", LoadClip(AudioFolder + "/Crumble.wav"));
        return SavePrefab<Enemy>(root, name);
    }

    // A tower with a crew on top (Chapters 8 and 9): a base, a second storey
    // (switched off until Level 2), and the Top, which holds the crew, where
    // shots start, and the flags (switched on at Level 3).
    static Tower MakeCrewTower(string name, string colour, string crewModel, (string weapon, string bone) crewWeapon,
                               RuntimeAnimatorController crewController, Projectile shot, AudioClip shootSound,
                               float[][] levels, AnimatorController towerController)
    {
        var root = new GameObject(name);
        InstantiateModel(ModelFolder + $"/building_tower_base_{colour}.fbx", root.transform).name = "Base";
        GameObject upper = InstantiateModel(ModelFolder + $"/building_tower_base_{colour}.fbx", root.transform);
        upper.name = "Upper";
        upper.transform.localPosition = new Vector3(0f, StoreyHeight, 0f);
        upper.transform.localScale = new Vector3(1f, 0.8f, 1f);
        upper.SetActive(false);
        Transform top = MakeChild(root.transform, "Top", new Vector3(0f, TopLevel1, 0f));
        GameObject crew = InstantiateModel(CharacterFolder + "/" + crewModel + ".fbx", top);
        crew.name = crewModel;
        crew.transform.localPosition = Vector3.zero;
        crew.transform.localScale = Vector3.one * CrewScale;
        Animator crewAnimator = crew.GetComponent<Animator>();
        crewAnimator.runtimeAnimatorController = crewController;
        crewAnimator.applyRootMotion = false;
        InstantiateModel(WeaponFolder + "/" + crewWeapon.weapon + ".fbx", Find<Transform>(crew, crewWeapon.bone));
        Transform muzzle = MakeChild(top, "Muzzle", top.position + new Vector3(0f, 0.45f, 0f));
        MakeFlags(top, colour, -0.05f);

        return FinishTower(root, name, crew, crew.transform, muzzle, shot, shootSound, levels, towerController);
    }

    // The catapult tower (Chapter 9): no crew, the catapult tower model itself
    // in the Top, lowered so the same Level clips work. Its second storey
    // goes under it.
    static Tower MakeCatapultTower(RuntimeAnimatorController catapultController, Projectile stone, AnimatorController towerController)
    {
        var root = new GameObject("Catapult Tower");
        GameObject upper = InstantiateModel(ModelFolder + "/building_tower_base_red.fbx", root.transform);
        upper.name = "Upper";
        upper.transform.localScale = new Vector3(1f, 0.8f, 1f);
        upper.SetActive(false);
        Transform top = MakeChild(root.transform, "Top", new Vector3(0f, TopLevel1, 0f));
        GameObject catapult = InstantiateModel(ModelFolder + "/building_tower_catapult_red.fbx", top);
        catapult.name = "Catapult";
        catapult.transform.localPosition = new Vector3(0f, -TopLevel1, 0f);
        catapult.AddComponent<Animator>().runtimeAnimatorController = catapultController;
        Transform turret = Find<Transform>(catapult, "catapult_turret_red");
        Transform muzzle = MakeChild(top, "Muzzle", top.position + new Vector3(0f, 0.5f, 0f));
        MakeFlags(top, "red", 0.12f);
        float[][] levels =
        {
            new[] { 80f, 5f, 4f, 2.6f, 1.2f, 1f, 0f },
            new[] { 60f, 5.5f, 6f, 2.4f, 1.4f, 1f, 0f },
            new[] { 100f, 6f, 9f, 2.2f, 1.6f, 1f, 0f },
        };
        return FinishTower(root, "Catapult Tower", catapult, turret, muzzle, stone, LoadClip(AudioFolder + "/Launch.wav"), levels, towerController);
    }

    static void MakeFlags(Transform top, string colour, float height)
    {
        Transform flags = MakeChild(top, "Flags", top.position);
        for (int side = -1; side <= 1; side += 2)
        {
            GameObject flag = InstantiateModel(ModelFolder + $"/flag_{colour}.fbx", flags);
            flag.name = side < 0 ? "Flag Left" : "Flag Right";
            flag.transform.localPosition = new Vector3(side * 0.38f, height, 0.1f);
            flag.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            flag.transform.localScale = Vector3.one * 2.6f;
        }
        flags.gameObject.SetActive(false);
    }

    // What every tower has: the body's Animator (the Tower controller), a
    // sound, the Tower script with its three levels, and TowerCrew beside the
    // crew's Animator.
    static Tower FinishTower(GameObject root, string name, GameObject crew, Transform turret, Transform muzzle,
                             Projectile shot, AudioClip shootSound, float[][] levels, AnimatorController towerController)
    {
        root.AddComponent<Animator>().runtimeAnimatorController = towerController;
        root.AddComponent<AudioSource>().playOnAwake = false;
        var tower = root.AddComponent<Tower>();
        var towerCrew = crew.AddComponent<TowerCrew>();
        Set(towerCrew, "tower", tower);
        SetString(tower, "title", name);
        SetTowerLevels(tower, levels);
        Set(tower, "crew", crew.GetComponent<Animator>());
        Set(tower, "turret", turret);
        Set(tower, "muzzle", muzzle);
        Set(tower, "shotPrefab", shot);
        SetLayerMask(tower, "enemyMask", "Enemy");
        Set(tower, "shootSound", shootSound);
        Set(tower, "buildSound", LoadClip(AudioFolder + "/Build.wav"));
        return SavePrefab<Tower>(root, name);
    }

    // { cost, range, damage, reload seconds, splash radius, slow factor, slow seconds } per level
    static void SetTowerLevels(Tower tower, float[][] levels)
    {
        var serialized = new SerializedObject(tower);
        SerializedProperty array = serialized.FindProperty("levels");
        array.arraySize = levels.Length;
        for (int i = 0; i < levels.Length; i++)
        {
            SerializedProperty level = array.GetArrayElementAtIndex(i);
            level.FindPropertyRelative("cost").intValue = (int)levels[i][0];
            level.FindPropertyRelative("range").floatValue = levels[i][1];
            level.FindPropertyRelative("damage").intValue = (int)levels[i][2];
            level.FindPropertyRelative("reloadSeconds").floatValue = levels[i][3];
            level.FindPropertyRelative("splashRadius").floatValue = levels[i][4];
            level.FindPropertyRelative("slowFactor").floatValue = levels[i][5];
            level.FindPropertyRelative("slowSeconds").floatValue = levels[i][6];
        }
        serialized.ApplyModifiedPropertiesWithoutUndo();
    }

    static void SetWaves(WaveSpawner spawner, Dictionary<string, Enemy> kinds)
    {
        var serialized = new SerializedObject(spawner);
        SerializedProperty waves = serialized.FindProperty("waves");
        waves.arraySize = WaveData.Length;
        for (int i = 0; i < WaveData.Length; i++)
        {
            string[] data = WaveData[i];
            SerializedProperty wave = waves.GetArrayElementAtIndex(i);
            wave.FindPropertyRelative("title").stringValue = data[0];
            SerializedProperty groups = wave.FindPropertyRelative("groups");
            groups.arraySize = (data.Length - 1) / 3;
            for (int g = 0; g < groups.arraySize; g++)
            {
                SerializedProperty group = groups.GetArrayElementAtIndex(g);
                group.FindPropertyRelative("enemyPrefab").objectReferenceValue = kinds[data[1 + g * 3]];
                group.FindPropertyRelative("count").intValue = int.Parse(data[2 + g * 3]);
                group.FindPropertyRelative("gap").floatValue = float.Parse(data[3 + g * 3], System.Globalization.CultureInfo.InvariantCulture);
            }
        }
        serialized.ApplyModifiedPropertiesWithoutUndo();
    }

    static Projectile MakeArrowPrefab()
    {
        var root = new GameObject("Arrow");
        GameObject model = InstantiateModel(WeaponFolder + "/arrow_bow.fbx", root.transform);
        model.name = "Model";
        model.transform.localRotation = Quaternion.Euler(90f, 0f, 0f);     // the shaft along the way it flies (+Z)
        model.transform.localScale = Vector3.one * 0.9f;
        AddTrail(root, 0.05f, new Color(1f, 1f, 1f, 0.6f));
        return FinishProjectile(root, "Arrow", Projectile.ProjectileKind.Arrow, 14f, null, null);
    }

    static Projectile MakeStonePrefab(GameObject dust)
    {
        var root = new GameObject("Stone");
        GameObject model = InstantiateModel(ModelFolder + "/projectile_catapult.fbx", root.transform);
        model.name = "Model";
        model.transform.localScale = Vector3.one * 1.3f;
        AddTrail(root, 0.12f, new Color(0.55f, 0.5f, 0.45f, 0.5f));
        return FinishProjectile(root, "Stone", Projectile.ProjectileKind.Stone, 0f, dust, LoadClip(AudioFolder + "/StoneHit.wav"));
    }

    static Projectile MakeBoltPrefab(GameObject frostBurst)
    {
        var root = new GameObject("Frost Bolt");
        GameObject ball = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        Object.DestroyImmediate(ball.GetComponent<Collider>());
        ball.name = "Model";
        ball.transform.SetParent(root.transform, false);
        ball.transform.localScale = Vector3.one * 0.22f;
        ball.GetComponent<Renderer>().sharedMaterial = MakeMaterial(AnimationFolder + "/Frost Bolt.mat", "Universal Render Pipeline/Unlit", Hex("#BFE6FF"));
        AddTrail(root, 0.12f, new Color(0.62f, 0.85f, 1f, 0.8f));
        return FinishProjectile(root, "Frost Bolt", Projectile.ProjectileKind.Frost, 9f, frostBurst, null);
    }

    static Projectile FinishProjectile(GameObject root, string name, Projectile.ProjectileKind kind, float speed, GameObject burst, AudioClip landSound)
    {
        var projectile = root.AddComponent<Projectile>();
        var serialized = new SerializedObject(projectile);
        serialized.FindProperty("kind").enumValueIndex = (int)kind;
        serialized.ApplyModifiedPropertiesWithoutUndo();
        if (speed > 0f)
        {
            SetFloat(projectile, "speed", speed);
        }
        if (burst != null)
        {
            Set(projectile, "burstPrefab", burst);
        }
        if (landSound != null)
        {
            Set(projectile, "landSound", landSound);
        }
        return SavePrefab<Projectile>(root, name);
    }

    static void AddTrail(GameObject go, float width, Color colour)
    {
        var trail = go.AddComponent<TrailRenderer>();
        trail.time = 0.2f;
        trail.startWidth = width;
        trail.endWidth = 0f;
        trail.sharedMaterial = particleMaterial;
        trail.startColor = colour;
        trail.endColor = new Color(colour.r, colour.g, colour.b, 0f);
        trail.shadowCastingMode = ShadowCastingMode.Off;
    }

    // A burst of particles that plays once and removes itself (Stop Action: Destroy).
    static GameObject MakeBurstPrefab(string name, Color a, Color b, int count, float speed, float gravity)
    {
        var root = new GameObject(name);
        var particles = root.AddComponent<ParticleSystem>();
        ParticleSystem.MainModule main = particles.main;
        main.duration = 0.5f;
        main.loop = false;
        main.startLifetime = new ParticleSystem.MinMaxCurve(0.4f, 0.8f);
        main.startSpeed = new ParticleSystem.MinMaxCurve(speed * 0.5f, speed);
        main.startSize = new ParticleSystem.MinMaxCurve(0.12f, 0.28f);
        main.startColor = new ParticleSystem.MinMaxGradient(a, b);
        main.gravityModifier = gravity;
        main.stopAction = ParticleSystemStopAction.Destroy;
        ParticleSystem.EmissionModule emission = particles.emission;
        emission.rateOverTime = 0f;
        emission.SetBursts(new[] { new ParticleSystem.Burst(0f, (short)count) });
        ParticleSystem.ShapeModule shape = particles.shape;
        shape.shapeType = ParticleSystemShapeType.Hemisphere;
        shape.radius = 0.3f;
        shape.rotation = new Vector3(-90f, 0f, 0f);
        SetFade(particles);
        root.GetComponent<ParticleSystemRenderer>().sharedMaterial = particleMaterial;
        GameObject saved = PrefabUtility.SaveAsPrefabAsset(root, PrefabFolder + "/" + name + ".prefab");
        Object.DestroyImmediate(root);
        return saved;
    }

    // Frost sparkles round a slowed skeleton, switched off until a frost bolt hits.
    static GameObject MakeFrostAura(Transform parent)
    {
        var aura = new GameObject("Frost");
        aura.transform.SetParent(parent, false);
        aura.transform.localPosition = new Vector3(0f, 1.1f, 0f);
        var particles = aura.AddComponent<ParticleSystem>();
        ParticleSystem.MainModule main = particles.main;
        main.loop = true;
        main.startLifetime = 0.8f;
        main.startSpeed = 0.4f;
        main.startSize = new ParticleSystem.MinMaxCurve(0.08f, 0.16f);
        main.startColor = new ParticleSystem.MinMaxGradient(Hex("#DFF3FF"), Hex("#7CC8FF"));
        main.scalingMode = ParticleSystemScalingMode.Shape;
        main.simulationSpace = ParticleSystemSimulationSpace.World;
        ParticleSystem.EmissionModule emission = particles.emission;
        emission.rateOverTime = 18f;
        ParticleSystem.ShapeModule shape = particles.shape;
        shape.shapeType = ParticleSystemShapeType.Sphere;
        shape.radius = 0.9f;
        SetFade(particles);
        aura.GetComponent<ParticleSystemRenderer>().sharedMaterial = particleMaterial;
        aura.SetActive(false);
        return aura;
    }

    static void SetFade(ParticleSystem particles)
    {
        ParticleSystem.ColorOverLifetimeModule fade = particles.colorOverLifetime;
        fade.enabled = true;
        var gradient = new Gradient();
        gradient.SetKeys(new[] { new GradientColorKey(Color.white, 0f), new GradientColorKey(Color.white, 1f) },
                         new[] { new GradientAlphaKey(1f, 0f), new GradientAlphaKey(1f, 0.6f), new GradientAlphaKey(0f, 1f) });
        fade.color = gradient;
    }

    // URP's Particles/Unlit, transparent, with Unity's soft round particle.
    static Material MakeParticleMaterial(string path)
    {
        Material material = MakeMaterial(path, "Universal Render Pipeline/Particles/Unlit", Color.white);
        material.SetFloat("_Surface", 1f);
        material.SetFloat("_Blend", 0f);
        material.SetFloat("_SrcBlend", (float)BlendMode.SrcAlpha);
        material.SetFloat("_DstBlend", (float)BlendMode.OneMinusSrcAlpha);
        material.SetFloat("_ZWrite", 0f);
        material.EnableKeyword("_SURFACE_TYPE_TRANSPARENT");
        material.renderQueue = (int)RenderQueue.Transparent;
        var softDot = AssetDatabase.GetBuiltinExtraResource<Texture2D>("Default-Particle.psd");
        if (softDot != null)
        {
            material.SetTexture("_BaseMap", softDot);
        }
        EditorUtility.SetDirty(material);
        return material;
    }

    // A build plot (Chapter 7): the dirt, and a Box Collider on the Plot layer.
    static BuildPlot MakePlot(Transform group, Vector3 position, int number, int layer)
    {
        var plotObject = new GameObject("Build Plot " + number);
        plotObject.transform.SetParent(group, false);
        plotObject.transform.position = position;
        plotObject.layer = layer;
        Place(ModelFolder + "/building_dirt.fbx", plotObject.transform, position, 0f, 1f);
        var box = plotObject.AddComponent<BoxCollider>();
        box.center = new Vector3(0f, 0.1f, 0f);
        box.size = new Vector3(1.8f, 0.2f, 2f);
        return plotObject.AddComponent<BuildPlot>();
    }

    // ------------------------------------------------------------------ renderer

    // The project's URP asset starts with a 2D renderer. Add a Universal (3D)
    // renderer once, and make this scene's camera use it, as Mini Golf does.
    static void UseThreeDRenderer(Camera cam)
    {
        var pipeline = GraphicsSettings.currentRenderPipeline as UniversalRenderPipelineAsset;
        if (pipeline == null)
        {
            Debug.LogWarning("No URP asset is active: the camera keeps its default renderer.");
            return;
        }
        string path = SettingsFolder + "/GateGuardRenderer.asset";
        var rendererData = AssetDatabase.LoadAssetAtPath<UniversalRendererData>(path);
        if (rendererData == null)
        {
            rendererData = ScriptableObject.CreateInstance<UniversalRendererData>();
            rendererData.postProcessData = AssetDatabase.LoadAssetAtPath<PostProcessData>(
                "Packages/com.unity.render-pipelines.universal/Runtime/Data/PostProcessData.asset");
            AssetDatabase.CreateAsset(rendererData, path);
        }
        var serialized = new SerializedObject(pipeline);
        SerializedProperty list = serialized.FindProperty("m_RendererDataList");
        int index = -1;
        for (int i = 0; i < list.arraySize; i++)
        {
            if (list.GetArrayElementAtIndex(i).objectReferenceValue == rendererData)
            {
                index = i;
            }
        }
        if (index < 0)
        {
            index = list.arraySize;
            list.arraySize++;
            list.GetArrayElementAtIndex(index).objectReferenceValue = rendererData;
            serialized.ApplyModifiedPropertiesWithoutUndo();
            EditorUtility.SetDirty(pipeline);
        }
        UniversalAdditionalCameraData cameraData = cam.GetUniversalAdditionalCameraData();
        cameraData.SetRenderer(index);
        cameraData.renderPostProcessing = false;
    }

    // ------------------------------------------------------------------ UI

    static TMP_Text MakeLabel(Transform parent, string name, string text, float size, Vector2 position, Vector2 box, Color colour)
    {
        TMP_Text label = MakeText(parent, name, text, size, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), position, box, colour);
        label.font = font;
        return label;
    }

    // A pzUH bar along the top: an icon in its circle, and a number.
    static TMP_Text MakeHudBar(Transform ui, string name, Sprite icon, Vector2 position, string text)
    {
        Image bar = MakeImage(ui, name + " Bar", Color.white, new Vector2(0f, 1f), position, new Vector2(264f, 95f));
        bar.sprite = sprites["Bar"];
        Image iconImage = MakeImage(bar.transform, "Icon", Color.white, new Vector2(0f, 0.5f), new Vector2(14f, 0f), new Vector2(66f, 66f));
        iconImage.sprite = icon;
        iconImage.preserveAspect = true;
        TMP_Text label = MakeText(bar.transform, name + " Text", text, 44f, TextAlignmentOptions.Left, new Vector2(0f, 0.5f),
                                  new Vector2(100f, 2f), new Vector2(160f, 80f), HudInk);
        label.font = font;
        return label;
    }

    // A square pzUH button, with its four pictures as a Sprite Swap: Normal,
    // Highlighted (Hover), Pressed (Click) and Disabled (Locked).
    static Button MakeSquareButton(Transform parent, string name, Vector2 anchor, Vector2 position, float size, Sprite icon, bool swapSprites)
    {
        Button button = MakeButton(parent, name, "", position, new Vector2(size, size), Color.white);
        var rect = (RectTransform)button.transform;
        rect.anchorMin = anchor;
        rect.anchorMax = anchor;
        rect.pivot = anchor;
        rect.anchoredPosition = position;
        Image image = button.GetComponent<Image>();
        image.sprite = sprites["SquareNormal"];
        image.type = Image.Type.Simple;
        Object.DestroyImmediate(button.GetComponentInChildren<TMP_Text>().gameObject);
        if (swapSprites)
        {
            button.transition = Selectable.Transition.SpriteSwap;
            SpriteState states = button.spriteState;
            states.highlightedSprite = sprites["SquareHover"];
            states.pressedSprite = sprites["SquareClick"];
            states.selectedSprite = sprites["SquareNormal"];
            states.disabledSprite = sprites["SquareLocked"];
            button.spriteState = states;
        }
        if (icon != null)
        {
            Image iconImage = MakeImage(button.transform, "Icon", Color.white, new Vector2(0.5f, 0.5f), new Vector2(0f, 4f), new Vector2(size * 0.58f, size * 0.58f));
            iconImage.sprite = icon;
            iconImage.preserveAspect = true;
        }
        return button;
    }

    static Button MakeWideButton(Transform parent, string name, string label, Vector2 position, Vector2 size)
    {
        Button button = MakeButton(parent, name, label, position, size, Color.white);
        Image image = button.GetComponent<Image>();
        image.sprite = sprites["ButtonNormal"];
        image.type = Image.Type.Simple;
        button.transition = Selectable.Transition.SpriteSwap;
        SpriteState states = button.spriteState;
        states.highlightedSprite = sprites["ButtonHover"];
        states.pressedSprite = sprites["ButtonClick"];
        states.selectedSprite = sprites["ButtonNormal"];
        states.disabledSprite = sprites["ButtonLocked"];
        button.spriteState = states;
        TMP_Text text = button.GetComponentInChildren<TMP_Text>();
        text.gameObject.name = "Label";
        text.font = font;
        text.fontSize = size.y * 0.36f;
        text.color = HudInk;
        return button;
    }

    // A menu that opens over a plot: its pivot is the middle of its bottom edge.
    static RectTransform MakeMenu(Transform ui, string name, Sprite panel, Vector2 size)
    {
        Image image = MakeImage(ui, name, Color.white, new Vector2(0.5f, 0f), Vector2.zero, size);
        image.sprite = panel;
        image.raycastTarget = true;         // a press on the menu stays on the menu
        var rect = image.rectTransform;
        rect.anchorMin = Vector2.zero;
        rect.anchorMax = Vector2.zero;
        rect.pivot = new Vector2(0.5f, 0f);
        return rect;
    }

    // A dimmed full-screen panel, holding a pzUH window with a ribbon title.
    static GameObject MakePanel(Transform ui, string name, Sprite window, Vector2 size, string title, out RectTransform windowRect)
    {
        RectTransform dim = MakeStretch(ui, name);
        dim.gameObject.AddComponent<Image>().color = new Color(0f, 0f, 0f, 0.55f);
        Image windowImage = MakeImage(dim, "Window", Color.white, new Vector2(0.5f, 0.5f), Vector2.zero, size);
        windowImage.sprite = window;
        windowRect = windowImage.rectTransform;
        Image ribbon = MakeImage(windowRect, "Ribbon", Color.white, new Vector2(0.5f, 1f), new Vector2(0f, 46f), new Vector2(560f, 113f));
        ribbon.sprite = sprites["Ribbon"];
        TMP_Text titleText = MakeText(ribbon.transform, "Title", title, 44f, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f),
                                      new Vector2(0f, 6f), new Vector2(300f, 70f), Ink);
        titleText.font = font;
        return dim.gameObject;
    }
}
