using TMPro;
using UnityEditor;
using UnityEditor.Events;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;
using static Level2BuilderKit;

// INSTRUCTOR TOOL: not part of the student book, and never shipped in a build.
// Menu: Tools → Tank Arena (Level 2) → Build Scene
//
// Rebuilds Assets/Levels/Level2-TankArena/Scenes/TankArena.unity exactly as the
// Tank Arena book describes it: the sprites' import settings, the arena with its
// walls, trees and oil barrels, the player's tank, the shell, enemy tank, repair kit,
// explosion and hit prefabs, the camera and the whole UI, with every Inspector
// reference wired up. Use it to prepare lab machines or to reset a broken scene.
// Running it again overwrites the scene and the prefabs.
public static class TankArenaSceneBuilder
{
    const string Root = "Assets/Levels/Level2-TankArena";
    const string ScenePath = Root + "/Scenes/TankArena.unity";
    const string Sprites = Root + "/Art/Sprites";
    const string Audio = Root + "/Audio";
    const string PrefabFolder = Root + "/Prefabs";
    const string Generated = Root + "/Generated";

    static readonly Vector2 Centre = new Vector2(0.5f, 0.5f);
    static readonly Vector2 Bottom = new Vector2(0.5f, 0f);    // barrels turn around their base

    [MenuItem("Tools/Tank Arena (Level 2)/Build Scene")]
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
        EnsureFolder(PrefabFolder);
        EnsureFolder(Generated);
        int wallsLayer = AddLayer("Walls");
        int playerLayer = AddLayer("Player");

        // ---- Prefabs: shells, hits, explosions, repair kits, enemy tanks (Chapters 4 to 8 and 12) ----
        GameObject hitPuff = MakeBurst("Hit Puff", "smokeGrey1", 0.3f, 6, new Vector2(0.2f, 0.4f), new Vector2(0.3f, 1.2f), new Vector2(0.25f, 0.45f), 0.05f);
        GameObject explosion = MakeBurst("Explosion", "smokeOrange0", 0.6f, 12, new Vector2(0.4f, 0.8f), new Vector2(0.5f, 2.5f), new Vector2(0.5f, 1f), 0.3f);
        GameObject playerShell = MakeShell("Player Shell", "bulletBlue", 9f, hitPuff);
        GameObject enemyShell = MakeShell("Enemy Shell", "bulletRed", 7f, hitPuff);
        GameObject repairKit = MakeRepairKit();
        GameObject lightTank = MakeEnemy("Light Tank", "tankRed", "barrelRed", 2, 2f, 90f, 120f, 1.6f, 8f, enemyShell);
        GameObject heavyTank = MakeEnemy("Heavy Tank", "tankBlack", "barrelBlack", 5, 1.3f, 60f, 90f, 2.4f, 9f, enemyShell);

        var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);

        // ---- Camera and light (Chapters 1 and 10) ----
        var cameraObject = new GameObject("Main Camera");
        cameraObject.tag = "MainCamera";
        cameraObject.transform.position = new Vector3(0f, 0f, -10f);
        var cam = cameraObject.AddComponent<Camera>();
        cam.orthographic = true;
        cam.orthographicSize = 5f;
        cam.clearFlags = CameraClearFlags.SolidColor;
        cam.backgroundColor = Hex("#3B3326");
        cameraObject.AddComponent<AudioListener>();
        var follow = cameraObject.AddComponent<CameraFollow>();

        var lightObject = new GameObject("Global Light 2D");
        lightObject.AddComponent<Light2D>().lightType = Light2D.LightType.Global;

        // ---- The arena (Chapter 1) ----
        Transform arena = new GameObject("Arena").transform;
        var ground = new GameObject("Ground");
        ground.transform.SetParent(arena, false);
        var groundRenderer = ground.AddComponent<SpriteRenderer>();
        groundRenderer.sprite = LoadSprite("sand", Centre, true);
        groundRenderer.drawMode = SpriteDrawMode.Tiled;
        groundRenderer.size = new Vector2(24f, 16f);
        groundRenderer.sortingOrder = -10;

        Wall(arena, "Wall Top", new Vector2(0f, 7.78f), 0f, 24f);
        Wall(arena, "Wall Bottom", new Vector2(0f, -7.78f), 0f, 24f);
        Wall(arena, "Wall Left", new Vector2(-11.78f, 0f), 90f, 16f);
        Wall(arena, "Wall Right", new Vector2(11.78f, 0f), 90f, 16f);
        Wall(arena, "Wall North", new Vector2(0f, 3.5f), 0f, 5f);
        Wall(arena, "Wall South", new Vector2(0f, -3.5f), 0f, 5f);
        Wall(arena, "Wall West", new Vector2(-6.5f, 0f), 90f, 4f);
        Wall(arena, "Wall East", new Vector2(6.5f, 0f), 90f, 4f);

        Obstacle(arena, "Tree", "treeLarge", new Vector2(-8f, 4.5f), 4, 0.3f);
        Obstacle(arena, "Tree", "treeLarge", new Vector2(8f, -4.5f), 4, 0.3f);
        Obstacle(arena, "Tree", "treeLarge", new Vector2(-3.5f, -6f), 4, 0.3f);
        Obstacle(arena, "Tree", "treeLarge", new Vector2(3.5f, 6f), 4, 0.3f);
        Obstacle(arena, "Oil Barrel", "barrelRed_up", new Vector2(-9.5f, -1f), 1, 0.22f);
        Obstacle(arena, "Oil Barrel", "barrelRed_up", new Vector2(9.5f, 1f), 1, 0.22f);
        Obstacle(arena, "Oil Barrel", "barrelGrey_up", new Vector2(-2.5f, 1f), 1, 0.22f);
        Obstacle(arena, "Oil Barrel", "barrelGrey_up", new Vector2(2.5f, -1f), 1, 0.22f);
        SetLayerRecursively(arena.gameObject, wallsLayer);    // what the enemies' eyes stop at (Chapter 7)

        // ---- Where the enemies appear, each facing the middle (Chapter 6) ----
        Transform spawnParent = new GameObject("Spawn Points").transform;
        Transform[] spawnPoints =
        {
            SpawnPoint(spawnParent, "Spawn Point 1", new Vector2(-10f, 6f), -121f),
            SpawnPoint(spawnParent, "Spawn Point 2", new Vector2(10f, 6f), 121f),
            SpawnPoint(spawnParent, "Spawn Point 3", new Vector2(-10f, -6f), -59f),
            SpawnPoint(spawnParent, "Spawn Point 4", new Vector2(10f, -6f), 59f),
        };

        // ---- The player's tank (Chapters 2 to 4, 7, 9 and 12) ----
        GameObject tank = MakeTankBody("Player Tank", "tankBlue", "barrelBlue", out Transform barrel, out Transform muzzle);
        var tankAudio = tank.AddComponent<AudioSource>();
        tankAudio.playOnAwake = false;
        var tracks = tank.AddComponent<Tracks>();
        SetFloat(tracks, "moveSpeed", 3f);
        SetFloat(tracks, "turnSpeed", 120f);
        var turret = tank.AddComponent<Turret>();
        Set(turret, "barrel", barrel);
        Set(turret, "muzzle", muzzle);
        Set(turret, "shellPrefab", playerShell);
        SetFloat(turret, "turnSpeed", 360f);
        SetFloat(turret, "reloadTime", 0.5f);
        Set(turret, "audioSource", tankAudio);
        Set(turret, "shotSound", LoadClip(Audio + "/Shot.wav"));
        var health = tank.AddComponent<Health>();
        SetInt(health, "maxHealth", 10);
        Set(health, "audioSource", tankAudio);
        Set(health, "hurtSound", LoadClip(Audio + "/Hit.wav"));
        Set(health, "healSound", LoadClip(Audio + "/Repair.wav"));
        var player = tank.AddComponent<PlayerTank>();
        SetLayerRecursively(tank, playerLayer);

        // ---- The game (Chapters 6, 8 and 11) ----
        var gameHolder = new GameObject("Arena Game");
        var game = gameHolder.AddComponent<ArenaGame>();
        var gameAudio = gameHolder.AddComponent<AudioSource>();
        gameAudio.playOnAwake = false;

        // ---- The screen (Chapters 6, 8, 11 and 13) ----
        Transform ui = MakeCanvas("Canvas");
        Color white = Color.white;
        Image healthBar = MakeImage(ui, "Health Bar", Hex("#1E1E1E", 0.7f), new Vector2(0f, 1f), new Vector2(40f, -30f), new Vector2(400f, 36f));
        RectTransform fillRect = MakeStretch(healthBar.transform, "Health Fill");
        fillRect.offsetMin = new Vector2(4f, 4f);
        fillRect.offsetMax = new Vector2(-4f, -4f);
        var healthFill = fillRect.gameObject.AddComponent<Image>();
        healthFill.raycastTarget = false;
        healthFill.color = Hex("#61CB8B");
        healthFill.sprite = AssetDatabase.GetBuiltinExtraResource<Sprite>("UI/Skin/UISprite.psd");
        healthFill.type = Image.Type.Filled;
        healthFill.fillMethod = Image.FillMethod.Horizontal;
        healthFill.fillOrigin = (int)Image.OriginHorizontal.Left;
        healthFill.fillAmount = 1f;

        TMP_Text roundText = MakeText(ui, "Round Text", "", 44f, TextAlignmentOptions.Center,
                                      new Vector2(0.5f, 1f), new Vector2(0f, -25f), new Vector2(600f, 70f), white);
        TMP_Text enemiesText = MakeText(ui, "Enemies Text", "", 44f, TextAlignmentOptions.Right,
                                        new Vector2(1f, 1f), new Vector2(-40f, -25f), new Vector2(500f, 70f), white);
        TMP_Text messageText = MakeText(ui, "Message Text", "", 96f, TextAlignmentOptions.Center,
                                        new Vector2(0.5f, 0.5f), new Vector2(0f, 150f), new Vector2(1600f, 200f), white);
        messageText.fontStyle = FontStyles.Bold;

        Color buttonColour = Hex("#D98E04");
        Color windowColour = Hex("#2F3B28");
        Button settingsButton = MakeButton(ui, "Settings Button", "Settings", Vector2.zero, new Vector2(220f, 70f), buttonColour);
        var settingsRect = (RectTransform)settingsButton.transform;
        settingsRect.anchorMin = new Vector2(1f, 0f);
        settingsRect.anchorMax = new Vector2(1f, 0f);
        settingsRect.pivot = new Vector2(1f, 0f);
        settingsRect.anchoredPosition = new Vector2(-30f, 30f);

        // Start panel: the title, how to play, and the Play button (Chapter 11)
        GameObject startPanel;
        RectTransform startWindow = MakeWindow(ui, "Start Panel", new Vector2(600f, 320f), 2f, windowColour, out startPanel);
        MakeText(startWindow, "Title", "Tank Arena", 48f, TextAlignmentOptions.Center,
                 new Vector2(0.5f, 0.5f), new Vector2(0f, 105f), new Vector2(560f, 70f), white);
        MakeText(startWindow, "How To Play",
                 "Keys: W and S drive, A and D turn, Space fires\nMouse or finger: the barrel aims where you point\nTap to fire, or press and hold to drive there",
                 17f, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), new Vector2(0f, 15f), new Vector2(560f, 100f), white);
        Button playButton = MakeButton(startWindow, "Play Button", "Play", new Vector2(0f, -105f), new Vector2(200f, 50f), buttonColour);

        // End panel: the result, the match's numbers, and Play Again (Chapter 11)
        GameObject endPanel;
        RectTransform endWindow = MakeWindow(ui, "End Panel", new Vector2(560f, 360f), 2f, windowColour, out endPanel);
        TMP_Text endText = MakeText(endWindow, "End Text", "Destroyed!", 20f, TextAlignmentOptions.Top,
                                    new Vector2(0.5f, 0.5f), new Vector2(0f, 30f), new Vector2(520f, 270f), white);
        Button playAgainButton = MakeButton(endWindow, "Play Again Button", "Play Again", new Vector2(0f, -145f), new Vector2(200f, 40f), buttonColour);
        endPanel.SetActive(false);

        // Settings panel: a window scaled ×2.2 so the default-sized controls read well (Chapter 13)
        GameObject settingsPanel;
        RectTransform settingsWindow = MakeWindow(ui, "Settings Panel", new Vector2(420f, 300f), 2.2f, windowColour, out settingsPanel);
        MakeText(settingsWindow, "Title", "Settings", 30f, TextAlignmentOptions.Center,
                 new Vector2(0.5f, 0.5f), new Vector2(0f, 115f), new Vector2(380f, 50f), white);
        MakeText(settingsWindow, "Volume Label", "Volume", 18f, TextAlignmentOptions.Left,
                 new Vector2(0.5f, 0.5f), new Vector2(-110f, 60f), new Vector2(140f, 30f), white);
        Slider volumeSlider = MakeSlider(settingsWindow, "Volume Slider", new Vector2(60f, 60f), 200f);
        volumeSlider.value = 1f;
        Toggle shakeToggle = MakeToggle(settingsWindow, "Shake Toggle", "Screen shake", new Vector2(10f, 18f));
        shakeToggle.isOn = true;
        MakeText(settingsWindow, "Name Label", "Commander", 18f, TextAlignmentOptions.Left,
                 new Vector2(0.5f, 0.5f), new Vector2(-110f, -28f), new Vector2(140f, 30f), white);
        TMP_InputField nameInput = MakeInputField(settingsWindow, "Name Input", "Your name", new Vector2(60f, -28f), 200f);
        MakeText(settingsWindow, "Colour Label", "Tank", 18f, TextAlignmentOptions.Left,
                 new Vector2(0.5f, 0.5f), new Vector2(-110f, -72f), new Vector2(140f, 30f), white);
        TMP_Dropdown colourDropdown = MakeDropdown(settingsWindow, "Colour Dropdown", new Vector2(60f, -72f), 200f, "Blue", "Green", "Beige");
        Button closeButton = MakeButton(settingsWindow, "Close Button", "Close", new Vector2(0f, -120f), new Vector2(160f, 36f), buttonColour);
        var settings = settingsPanel.AddComponent<SettingsMenu>();
        settingsPanel.SetActive(false);
        UnityEventTools.AddBoolPersistentListener(settingsButton.onClick, settingsPanel.SetActive, true);

        // ---- Wire up every Inspector reference ----
        Set(follow, "target", tank.transform);
        Set(player, "game", game);

        Set(game, "player", player);
        Set(game, "cameraFollow", follow);
        Set(game, "lightTankPrefab", lightTank);
        Set(game, "heavyTankPrefab", heavyTank);
        Set(game, "repairKitPrefab", repairKit);
        Set(game, "explosionPrefab", explosion);
        SetArray(game, "spawnPoints", spawnPoints);
        Set(game, "healthFill", healthFill);
        Set(game, "roundText", roundText);
        Set(game, "enemiesText", enemiesText);
        Set(game, "messageText", messageText);
        Set(game, "startPanel", startPanel);
        Set(game, "playButton", playButton);
        Set(game, "endPanel", endPanel);
        Set(game, "endText", endText);
        Set(game, "playAgainButton", playAgainButton);
        Set(game, "audioSource", gameAudio);
        Set(game, "explosionSound", LoadClip(Audio + "/Explosion.wav"));
        Set(game, "victorySound", LoadClip(Audio + "/Victory.wav"));
        Set(game, "defeatSound", LoadClip(Audio + "/Defeat.wav"));

        Set(settings, "volumeSlider", volumeSlider);
        Set(settings, "shakeToggle", shakeToggle);
        Set(settings, "nameInput", nameInput);
        Set(settings, "colourDropdown", colourDropdown);
        Set(settings, "closeButton", closeButton);
        Set(settings, "game", game);
        Set(settings, "cameraFollow", follow);
        Set(settings, "bodyRenderer", tank.GetComponent<SpriteRenderer>());
        Set(settings, "barrelRenderer", barrel.GetComponent<SpriteRenderer>());
        SetArray(settings, "bodySprites", LoadSprite("tankBlue", Centre, false), LoadSprite("tankGreen", Centre, false),
                 LoadSprite("tankBeige", Centre, false));
        SetArray(settings, "barrelSprites", LoadSprite("barrelBlue", Bottom, false), LoadSprite("barrelGreen", Bottom, false),
                 LoadSprite("barrelBeige", Bottom, false));

        AssetDatabase.SaveAssets();
        SaveScene(scene, ScenePath);
        Debug.Log("Tank Arena scene built: " + ScenePath);
    }

    // ------------------------------------------------------------------ arena

    // A row of sandbags: one sprite, tiled along the wall's length, with a Box
    // Collider 2D that follows the tiling (Auto Tiling).
    static void Wall(Transform arena, string name, Vector2 position, float turn, float length)
    {
        var wall = new GameObject(name);
        wall.transform.SetParent(arena, false);
        wall.transform.localPosition = position;
        wall.transform.localRotation = Quaternion.Euler(0f, 0f, turn);
        var renderer = wall.AddComponent<SpriteRenderer>();
        renderer.sprite = LoadSprite("sandbagBrown", Centre, true);
        renderer.drawMode = SpriteDrawMode.Tiled;
        renderer.size = new Vector2(length, 0.44f);
        renderer.sortingOrder = 0;
        var box = wall.AddComponent<BoxCollider2D>();
        box.autoTiling = true;
        box.size = renderer.size;
    }

    static void Obstacle(Transform arena, string name, string spriteName, Vector2 position, int order, float radius)
    {
        GameObject go = SpriteObject(name, spriteName, Centre, order);
        go.transform.SetParent(arena, false);
        go.transform.localPosition = position;
        go.AddComponent<CircleCollider2D>().radius = radius;
    }

    static Transform SpawnPoint(Transform parent, string name, Vector2 position, float turn)
    {
        Transform point = new GameObject(name).transform;
        point.SetParent(parent, false);
        point.localPosition = position;
        point.localRotation = Quaternion.Euler(0f, 0f, turn);
        return point;
    }

    // ------------------------------------------------------------------ tanks

    // A tank's body, with its barrel and muzzle: the part every tank shares.
    static GameObject MakeTankBody(string name, string bodySprite, string barrelSprite, out Transform barrel, out Transform muzzle)
    {
        GameObject tank = SpriteObject(name, bodySprite, Centre, 1);
        var body = tank.AddComponent<Rigidbody2D>();
        body.bodyType = RigidbodyType2D.Dynamic;
        body.gravityScale = 0f;
        body.interpolation = RigidbodyInterpolation2D.Interpolate;
        tank.AddComponent<CircleCollider2D>().radius = 0.35f;

        GameObject barrelObject = SpriteObject("Barrel", barrelSprite, Bottom, 2);
        barrelObject.transform.SetParent(tank.transform, false);
        barrel = barrelObject.transform;

        muzzle = new GameObject("Muzzle").transform;
        muzzle.SetParent(barrel, false);
        muzzle.localPosition = new Vector3(0f, 0.55f, 0f);
        return tank;
    }

    static GameObject MakeEnemy(string name, string bodySprite, string barrelSprite, int health, float moveSpeed, float turnSpeed,
                                float turretSpeed, float reloadTime, float sightRange, GameObject shell)
    {
        GameObject tank = MakeTankBody(name, bodySprite, barrelSprite, out Transform barrel, out Transform muzzle);
        var audio = tank.AddComponent<AudioSource>();
        audio.playOnAwake = false;

        var tracks = tank.AddComponent<Tracks>();
        SetFloat(tracks, "moveSpeed", moveSpeed);
        SetFloat(tracks, "turnSpeed", turnSpeed);

        var turret = tank.AddComponent<Turret>();
        Set(turret, "barrel", barrel);
        Set(turret, "muzzle", muzzle);
        Set(turret, "shellPrefab", shell);
        SetFloat(turret, "turnSpeed", turretSpeed);
        SetFloat(turret, "reloadTime", reloadTime);
        Set(turret, "audioSource", audio);
        Set(turret, "shotSound", LoadClip(Audio + "/Shot.wav"));

        var hitPoints = tank.AddComponent<Health>();
        SetInt(hitPoints, "maxHealth", health);
        Set(hitPoints, "audioSource", audio);
        Set(hitPoints, "hurtSound", LoadClip(Audio + "/Hit.wav"));

        var enemy = tank.AddComponent<EnemyTank>();
        SetString(enemy, "tankName", name);
        SetFloat(enemy, "sightRange", sightRange);
        SetLayerMask(enemy, "sightMask", "Walls", "Player");
        return SavePrefab(tank, name);
    }

    // ------------------------------------------------------------------ prefabs

    static GameObject MakeShell(string name, string spriteName, float speed, GameObject hitPuff)
    {
        GameObject go = SpriteObject(name, spriteName, Centre, 3);
        var body = go.AddComponent<Rigidbody2D>();
        body.bodyType = RigidbodyType2D.Dynamic;
        body.gravityScale = 0f;
        var circle = go.AddComponent<CircleCollider2D>();
        circle.isTrigger = true;
        circle.radius = 0.08f;
        var shell = go.AddComponent<Shell>();
        SetFloat(shell, "speed", speed);
        Set(shell, "hitPrefab", hitPuff);
        return SavePrefab(go, name);
    }

    static GameObject MakeRepairKit()
    {
        GameObject go = SpriteObject("Repair Kit", "barrelGreen_up", Centre, 1);
        go.AddComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
        var circle = go.AddComponent<CircleCollider2D>();
        circle.isTrigger = true;
        go.AddComponent<RepairKit>();
        return SavePrefab(go, "Repair Kit");
    }

    // A puff of smoke sprites that plays once, then deletes itself (Chapter 12).
    static GameObject MakeBurst(string name, string spriteName, float duration, int count, Vector2 lifetime, Vector2 speed, Vector2 size,
                                float radius)
    {
        var go = new GameObject(name);
        var particles = go.AddComponent<ParticleSystem>();
        particles.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);

        ParticleSystem.MainModule main = particles.main;
        main.duration = duration;
        main.loop = false;
        main.startLifetime = new ParticleSystem.MinMaxCurve(lifetime.x, lifetime.y);
        main.startSpeed = new ParticleSystem.MinMaxCurve(speed.x, speed.y);
        main.startSize = new ParticleSystem.MinMaxCurve(size.x, size.y);
        main.startRotation = new ParticleSystem.MinMaxCurve(0f, Mathf.PI * 2f);
        main.gravityModifier = 0f;
        main.stopAction = ParticleSystemStopAction.Destroy;

        ParticleSystem.EmissionModule emission = particles.emission;
        emission.rateOverTime = 0f;
        emission.SetBursts(new[] { new ParticleSystem.Burst(0f, count) });

        ParticleSystem.ShapeModule shape = particles.shape;
        shape.shapeType = ParticleSystemShapeType.Circle;
        shape.radius = radius;

        ParticleSystem.ColorOverLifetimeModule fade = particles.colorOverLifetime;
        fade.enabled = true;
        var gradient = new Gradient();
        gradient.SetKeys(
            new[] { new GradientColorKey(Color.white, 0f), new GradientColorKey(Color.white, 1f) },
            new[] { new GradientAlphaKey(1f, 0f), new GradientAlphaKey(0f, 1f) });
        fade.color = new ParticleSystem.MinMaxGradient(gradient);

        var renderer = go.GetComponent<ParticleSystemRenderer>();
        Material material = MakeMaterial(Generated + "/" + name + ".mat", "Universal Render Pipeline/2D/Sprite-Unlit-Default", Color.white);
        material.mainTexture = LoadSprite(spriteName, Centre, false).texture;
        renderer.sharedMaterial = material;
        renderer.sortingOrder = 5;
        return SavePrefab(go, name);
    }

    // ------------------------------------------------------------------ helpers

    static GameObject SpriteObject(string name, string spriteName, Vector2 pivot, int order)
    {
        var go = new GameObject(name);
        var renderer = go.AddComponent<SpriteRenderer>();
        renderer.sprite = LoadSprite(spriteName, pivot, false);
        renderer.sortingOrder = order;
        return go;
    }

    static GameObject SavePrefab(GameObject go, string name)
    {
        GameObject prefab = PrefabUtility.SaveAsPrefabAsset(go, PrefabFolder + "/" + name + ".prefab");
        Object.DestroyImmediate(go);
        return prefab;
    }

    // Kenney's sprites: 100 pixels per unit. Barrels turn around their base, so
    // their pivot is at the bottom. Tiled sprites need a Full Rect mesh.
    static Sprite LoadSprite(string name, Vector2 pivot, bool fullRect)
    {
        string path = Sprites + "/" + name + ".png";
        Sprite sprite = ImportSprite(path, 100f, pivot);
        if (fullRect)
        {
            var importer = (TextureImporter)AssetImporter.GetAtPath(path);
            var settings = new TextureImporterSettings();
            importer.ReadTextureSettings(settings);
            if (settings.spriteMeshType != SpriteMeshType.FullRect)
            {
                settings.spriteMeshType = SpriteMeshType.FullRect;
                importer.SetTextureSettings(settings);
                importer.SaveAndReimport();
                sprite = AssetDatabase.LoadAssetAtPath<Sprite>(path);
            }
        }
        return sprite;
    }
}
