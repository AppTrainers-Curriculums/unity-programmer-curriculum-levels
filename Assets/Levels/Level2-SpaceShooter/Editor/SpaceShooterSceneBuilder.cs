using System.IO;
using TMPro;
using UnityEditor;
using UnityEditor.Events;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;
using static Level2BuilderKit;

// INSTRUCTOR TOOL: not part of the student book, and never shipped in a build.
// Menu: Tools → Space Shooter (Level 2) → Build Scene
//
// Rebuilds Assets/Levels/Level2-SpaceShooter/Scenes/SpaceShooter.unity exactly
// as the Space Shooter book describes it: the sprites' import settings, the
// Kenney font as a TextMeshPro font asset, the laser, enemy, power-up and
// explosion prefabs, the ship, the spawner, the camera and the whole UI, with
// every Inspector reference wired up. Use it to prepare lab machines or to reset
// a broken scene. Running it again overwrites the scene and the prefabs.
public static class SpaceShooterSceneBuilder
{
    const string Root = "Assets/Levels/Level2-SpaceShooter";
    const string ScenePath = Root + "/Scenes/SpaceShooter.unity";
    const string Sprites = Root + "/Art/Sprites";
    const string Fonts = Root + "/Art/Fonts";
    const string Audio = Root + "/Audio";
    const string PrefabFolder = Root + "/Prefabs";
    const string Generated = Root + "/Generated";

    [MenuItem("Tools/Space Shooter (Level 2)/Build Scene")]
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
        int playerLayer = AddLayer("Player");
        TMP_FontAsset font = MakeFontAsset();

        // ---- Prefabs: lasers, enemies, power-ups and the explosion (Chapters 3, 4, 8 and 10) ----
        GameObject playerLaser = MakeLaser("Player Laser", "laserBlue01", 12f, false);
        GameObject enemyLaser = MakeLaser("Enemy Laser", "laserRed01", 8f, true);
        GameObject shieldPowerUp = MakePowerUp("Shield Power-Up", "powerupBlue_shield", PowerUp.Kind.Shield);
        GameObject triplePowerUp = MakePowerUp("Triple Shot Power-Up", "powerupRed_star", PowerUp.Kind.TripleShot);
        GameObject rapidPowerUp = MakePowerUp("Rapid Fire Power-Up", "powerupYellow_bolt", PowerUp.Kind.RapidFire);
        GameObject[] powerUps = { shieldPowerUp, triplePowerUp, rapidPowerUp };
        GameObject explosion = MakeExplosion();

        GameObject scout = MakeEnemy("Scout", "enemyBlack1", 1, 100, 2.5f, 0f, 0f, powerUps, null);
        GameObject meteor = MakeEnemy("Meteor", "meteorBrown_big1", 3, 50, 1.5f, 0f, 60f, powerUps, null);
        GameObject zigzag = MakeEnemy("Zigzag", "enemyBlue3", 2, 150, 2f, 2f, 0f, powerUps, null);
        GameObject gunship = MakeEnemy("Gunship", "enemyRed2", 3, 250, 1f, 0f, 0f, powerUps, enemyLaser);

        var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);

        // ---- Camera and light (Chapter 1) ----
        var cameraObject = new GameObject("Main Camera");
        cameraObject.tag = "MainCamera";
        cameraObject.transform.position = new Vector3(0f, 0f, -10f);
        var cam = cameraObject.AddComponent<Camera>();
        cam.orthographic = true;
        cam.orthographicSize = 5f;
        cam.clearFlags = CameraClearFlags.SolidColor;
        cam.backgroundColor = Hex("#0B0B1A");
        cameraObject.AddComponent<AudioListener>();
        var shake = cameraObject.AddComponent<CameraShake>();

        var lightObject = new GameObject("Global Light 2D");
        lightObject.AddComponent<Light2D>().lightType = Light2D.LightType.Global;

        // ---- The scrolling background (Chapter 1) ----
        var background = new GameObject("Background");
        var backgroundRenderer = background.AddComponent<SpriteRenderer>();
        backgroundRenderer.sprite = LoadSprite("darkPurple");
        backgroundRenderer.drawMode = SpriteDrawMode.Tiled;
        backgroundRenderer.size = new Vector2(25.6f, 15.36f);     // 10 × 6 tiles: wide enough for a phone on its side
        backgroundRenderer.sortingOrder = -10;
        background.AddComponent<ScrollingBackground>();

        // ---- The player's ship (Chapters 2 to 4 and 8 to 11) ----
        var ship = new GameObject("Player Ship");
        ship.layer = playerLayer;
        ship.transform.position = new Vector3(0f, -3.5f, 0f);
        var shipRenderer = ship.AddComponent<SpriteRenderer>();
        shipRenderer.sprite = LoadSprite("playerShip1_blue");
        shipRenderer.sortingOrder = 1;
        var shipBody = ship.AddComponent<Rigidbody2D>();
        shipBody.bodyType = RigidbodyType2D.Dynamic;
        shipBody.gravityScale = 0f;
        shipBody.constraints = RigidbodyConstraints2D.FreezeRotation;
        shipBody.interpolation = RigidbodyInterpolation2D.Interpolate;
        var shipCollider = ship.AddComponent<CircleCollider2D>();
        shipCollider.isTrigger = true;
        shipCollider.radius = 0.35f;
        var shipAudio = ship.AddComponent<AudioSource>();
        shipAudio.playOnAwake = false;
        var player = ship.AddComponent<PlayerShip>();

        Transform muzzle = new GameObject("Muzzle").transform;
        muzzle.SetParent(ship.transform, false);
        muzzle.localPosition = new Vector3(0f, 0.5f, 0f);

        var shieldObject = new GameObject("Shield");
        shieldObject.transform.SetParent(ship.transform, false);
        shieldObject.transform.localPosition = new Vector3(0f, 0.1f, 0f);
        var shieldRenderer = shieldObject.AddComponent<SpriteRenderer>();
        shieldRenderer.sprite = LoadSprite("shield1");
        shieldRenderer.sortingOrder = 2;
        shieldObject.SetActive(false);
        SetLayerRecursively(ship, playerLayer);    // the ship and its children, as in the book

        // ---- Spawner and game (Chapters 5, 6 and 9) ----
        var spawnerObject = new GameObject("Wave Spawner");
        var spawner = spawnerObject.AddComponent<WaveSpawner>();

        var gameHolder = new GameObject("Shooter Game");
        var game = gameHolder.AddComponent<ShooterGame>();
        var gameAudio = gameHolder.AddComponent<AudioSource>();
        gameAudio.playOnAwake = false;

        // ---- The screen (Chapters 5, 6, 8, 9 and 12) ----
        Transform ui = MakeCanvas("Canvas");
        Color white = Color.white;
        TMP_Text scoreText = MakeText(ui, "Score Text", "000000", 64f, TextAlignmentOptions.Right,
                                      new Vector2(1f, 1f), new Vector2(-40f, -25f), new Vector2(500f, 90f), white);
        scoreText.font = font;
        TMP_Text waveText = MakeText(ui, "Wave Text", "", 40f, TextAlignmentOptions.Center,
                                     new Vector2(0.5f, 1f), new Vector2(0f, -30f), new Vector2(700f, 70f), white);
        waveText.font = font;
        TMP_Text messageText = MakeText(ui, "Message Text", "", 80f, TextAlignmentOptions.Center,
                                        new Vector2(0.5f, 0.5f), new Vector2(0f, 150f), new Vector2(1700f, 200f), white);
        messageText.font = font;

        var lifeIcons = new Image[3];
        for (int i = 0; i < lifeIcons.Length; i++)
        {
            lifeIcons[i] = MakeImage(ui, "Life Icon " + (i + 1), Color.white, new Vector2(0f, 1f),
                                     new Vector2(40f + i * 85f, -30f), new Vector2(66f, 52f));
            lifeIcons[i].sprite = LoadSprite("playerLife1_blue");
            lifeIcons[i].preserveAspect = true;
        }

        Button settingsButton = MakeButton(ui, "Settings Button", "Settings", Vector2.zero, new Vector2(220f, 70f), Hex("#3A8DDE"));
        var settingsRect = (RectTransform)settingsButton.transform;
        settingsRect.anchorMin = new Vector2(1f, 0f);
        settingsRect.anchorMax = new Vector2(1f, 0f);
        settingsRect.pivot = new Vector2(1f, 0f);
        settingsRect.anchoredPosition = new Vector2(-30f, 30f);

        // Start panel: the title and the Play button (Chapter 9)
        GameObject startPanel;
        RectTransform startWindow = MakeWindow(ui, "Start Panel", new Vector2(600f, 300f), 2f, Hex("#2A2340"), out startPanel);
        TMP_Text title = MakeText(startWindow, "Title", "Space Shooter", 48f, TextAlignmentOptions.Center,
                                  new Vector2(0.5f, 0.5f), new Vector2(0f, 90f), new Vector2(560f, 70f), white);
        title.font = font;
        MakeText(startWindow, "How To Play", "Fly: arrow keys or W A S D, or drag with a finger\nFire: hold Space, or keep your finger down",
                 18f, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), new Vector2(0f, 10f), new Vector2(560f, 80f), white);
        Button playButton = MakeButton(startWindow, "Play Button", "Play", new Vector2(0f, -95f), new Vector2(200f, 50f), Hex("#3A8DDE"));

        // End panel: the result and Play Again (Chapter 9)
        GameObject endPanel;
        RectTransform endWindow = MakeWindow(ui, "End Panel", new Vector2(560f, 340f), 2f, Hex("#2A2340"), out endPanel);
        TMP_Text endText = MakeText(endWindow, "End Text", "Game Over", 22f, TextAlignmentOptions.Top,
                                    new Vector2(0.5f, 0.5f), new Vector2(0f, 30f), new Vector2(520f, 250f), white);
        Button playAgainButton = MakeButton(endWindow, "Play Again Button", "Play Again", new Vector2(0f, -135f), new Vector2(200f, 40f), Hex("#3A8DDE"));
        endPanel.SetActive(false);

        // Settings panel: a window scaled ×2.2 so the default-sized controls read well (Chapter 12)
        GameObject settingsPanel;
        RectTransform settingsWindow = MakeWindow(ui, "Settings Panel", new Vector2(420f, 300f), 2.2f, Hex("#2A2340"), out settingsPanel);
        TMP_Text settingsTitle = MakeText(settingsWindow, "Title", "Settings", 30f, TextAlignmentOptions.Center,
                                          new Vector2(0.5f, 0.5f), new Vector2(0f, 115f), new Vector2(380f, 50f), white);
        settingsTitle.font = font;
        MakeText(settingsWindow, "Volume Label", "Volume", 18f, TextAlignmentOptions.Left,
                 new Vector2(0.5f, 0.5f), new Vector2(-110f, 60f), new Vector2(140f, 30f), white);
        Slider volumeSlider = MakeSlider(settingsWindow, "Volume Slider", new Vector2(60f, 60f), 200f);
        volumeSlider.value = 1f;
        Toggle shakeToggle = MakeToggle(settingsWindow, "Shake Toggle", "Screen shake", new Vector2(10f, 18f));
        shakeToggle.isOn = true;
        MakeText(settingsWindow, "Name Label", "Pilot", 18f, TextAlignmentOptions.Left,
                 new Vector2(0.5f, 0.5f), new Vector2(-110f, -28f), new Vector2(140f, 30f), white);
        TMP_InputField nameInput = MakeInputField(settingsWindow, "Name Input", "Your name", new Vector2(60f, -28f), 200f);
        MakeText(settingsWindow, "Ship Label", "Ship", 18f, TextAlignmentOptions.Left,
                 new Vector2(0.5f, 0.5f), new Vector2(-110f, -72f), new Vector2(140f, 30f), white);
        TMP_Dropdown shipDropdown = MakeDropdown(settingsWindow, "Ship Dropdown", new Vector2(60f, -72f), 200f, "Blue", "Green", "Orange", "Red");
        Button closeButton = MakeButton(settingsWindow, "Close Button", "Close", new Vector2(0f, -120f), new Vector2(160f, 36f), Hex("#3A8DDE"));
        var settings = settingsPanel.AddComponent<SettingsMenu>();
        settingsPanel.SetActive(false);
        UnityEventTools.AddBoolPersistentListener(settingsButton.onClick, settingsPanel.SetActive, true);

        // ---- Wire up every Inspector reference ----
        Set(player, "game", game);
        Set(player, "laserPrefab", playerLaser);
        Set(player, "muzzle", muzzle);
        Set(player, "shield", shieldObject);
        Set(player, "shipRenderer", shipRenderer);
        Set(player, "audioSource", shipAudio);
        Set(player, "laserSound", LoadClip(Audio + "/sfx_laser1.ogg"));
        Set(player, "powerUpSound", LoadClip(Audio + "/sfx_shieldUp.ogg"));
        Set(player, "shieldDownSound", LoadClip(Audio + "/sfx_shieldDown.ogg"));

        Set(spawner, "game", game);
        Set(spawner, "scoutPrefab", scout);
        Set(spawner, "meteorPrefab", meteor);
        Set(spawner, "zigzagPrefab", zigzag);
        Set(spawner, "gunshipPrefab", gunship);

        Set(game, "player", player);
        Set(game, "spawner", spawner);
        Set(game, "cameraShake", shake);
        Set(game, "explosionPrefab", explosion);
        Set(game, "scoreText", scoreText);
        Set(game, "waveText", waveText);
        Set(game, "messageText", messageText);
        SetArray(game, "lifeIcons", lifeIcons);
        Set(game, "startPanel", startPanel);
        Set(game, "playButton", playButton);
        Set(game, "endPanel", endPanel);
        Set(game, "endText", endText);
        Set(game, "playAgainButton", playAgainButton);
        Set(game, "audioSource", gameAudio);
        Set(game, "explosionSound", LoadClip(Audio + "/sfx_zap.ogg"));
        Set(game, "loseLifeSound", LoadClip(Audio + "/sfx_shieldDown.ogg"));
        Set(game, "waveSound", LoadClip(Audio + "/sfx_twoTone.ogg"));
        Set(game, "gameOverSound", LoadClip(Audio + "/sfx_lose.ogg"));

        Set(settings, "volumeSlider", volumeSlider);
        Set(settings, "shakeToggle", shakeToggle);
        Set(settings, "nameInput", nameInput);
        Set(settings, "shipDropdown", shipDropdown);
        Set(settings, "closeButton", closeButton);
        Set(settings, "game", game);
        Set(settings, "cameraShake", shake);
        Set(settings, "shipRenderer", shipRenderer);
        SetArray(settings, "shipSprites", LoadSprite("playerShip1_blue"), LoadSprite("playerShip1_green"),
                 LoadSprite("playerShip1_orange"), LoadSprite("playerShip1_red"));
        SetArray(settings, "lifeIcons", lifeIcons);
        SetArray(settings, "lifeSprites", LoadSprite("playerLife1_blue"), LoadSprite("playerLife1_green"),
                 LoadSprite("playerLife1_orange"), LoadSprite("playerLife1_red"));

        AssetDatabase.SaveAssets();
        SaveScene(scene, ScenePath);
        Debug.Log("Space Shooter scene built: " + ScenePath);
    }

    // ------------------------------------------------------------------ prefabs

    static GameObject MakeLaser(string name, string spriteName, float speed, bool hitsPlayer)
    {
        GameObject go = SpriteObject(name, spriteName, 0);
        var body = go.AddComponent<Rigidbody2D>();
        body.bodyType = RigidbodyType2D.Dynamic;
        body.gravityScale = 0f;
        var box = go.AddComponent<BoxCollider2D>();
        box.isTrigger = true;
        var laser = go.AddComponent<Laser>();
        SetFloat(laser, "speed", speed);
        SetBool(laser, "hitsPlayer", hitsPlayer);
        return SavePrefab(go, name);
    }

    static GameObject MakePowerUp(string name, string spriteName, PowerUp.Kind kind)
    {
        GameObject go = SpriteObject(name, spriteName, 1);
        var body = go.AddComponent<Rigidbody2D>();
        body.bodyType = RigidbodyType2D.Kinematic;
        var circle = go.AddComponent<CircleCollider2D>();
        circle.isTrigger = true;
        var powerUp = go.AddComponent<PowerUp>();
        SetInt(powerUp, "kind", (int)kind);
        return SavePrefab(go, name);
    }

    static GameObject MakeEnemy(string name, string spriteName, int health, int points, float fallSpeed,
                                float swayWidth, float spinSpeed, GameObject[] powerUps, GameObject laser)
    {
        GameObject go = SpriteObject(name, spriteName, 1);
        var body = go.AddComponent<Rigidbody2D>();
        body.bodyType = RigidbodyType2D.Kinematic;
        body.interpolation = RigidbodyInterpolation2D.Interpolate;
        var circle = go.AddComponent<CircleCollider2D>();
        circle.isTrigger = true;
        circle.radius = 0.4f;
        var enemy = go.AddComponent<Enemy>();
        SetString(enemy, "enemyName", name);
        SetInt(enemy, "maxHealth", health);
        SetInt(enemy, "points", points);
        SetFloat(enemy, "fallSpeed", fallSpeed);
        SetFloat(enemy, "swayWidth", swayWidth);
        SetFloat(enemy, "spinSpeed", spinSpeed);
        SetArray(enemy, "powerUpPrefabs", powerUps);

        if (laser != null)
        {
            // The gunship's gun: a muzzle below the ship, and a raycast looking down (Chapter 8)
            Transform muzzle = new GameObject("Muzzle").transform;
            muzzle.SetParent(go.transform, false);
            muzzle.localPosition = new Vector3(0f, -0.55f, 0f);
            var audio = go.AddComponent<AudioSource>();
            audio.playOnAwake = false;
            var gun = go.AddComponent<EnemyGun>();
            Set(gun, "laserPrefab", laser);
            Set(gun, "muzzle", muzzle);
            SetLayerMask(gun, "playerMask", "Player");
            Set(gun, "audioSource", audio);
            Set(gun, "shootSound", LoadClip(Audio + "/sfx_laser2.ogg"));
        }
        return SavePrefab(go, name);
    }

    // A burst of sparkles that plays once, then deletes itself (Chapter 10).
    static GameObject MakeExplosion()
    {
        var go = new GameObject("Explosion");
        var particles = go.AddComponent<ParticleSystem>();
        particles.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);

        ParticleSystem.MainModule main = particles.main;
        main.duration = 0.5f;
        main.loop = false;
        main.startLifetime = new ParticleSystem.MinMaxCurve(0.4f, 0.8f);
        main.startSpeed = new ParticleSystem.MinMaxCurve(1f, 4f);
        main.startSize = new ParticleSystem.MinMaxCurve(0.15f, 0.35f);
        main.startColor = new ParticleSystem.MinMaxGradient(Hex("#FFE066"), Hex("#FF8A3D"));
        main.gravityModifier = 0f;
        main.stopAction = ParticleSystemStopAction.Destroy;

        ParticleSystem.EmissionModule emission = particles.emission;
        emission.rateOverTime = 0f;
        emission.SetBursts(new[] { new ParticleSystem.Burst(0f, 30) });

        ParticleSystem.ShapeModule shape = particles.shape;
        shape.shapeType = ParticleSystemShapeType.Circle;
        shape.radius = 0.2f;

        ParticleSystem.ColorOverLifetimeModule fade = particles.colorOverLifetime;
        fade.enabled = true;
        var gradient = new Gradient();
        gradient.SetKeys(
            new[] { new GradientColorKey(Color.white, 0f), new GradientColorKey(Color.white, 1f) },
            new[] { new GradientAlphaKey(1f, 0f), new GradientAlphaKey(0f, 1f) });
        fade.color = new ParticleSystem.MinMaxGradient(gradient);

        var renderer = go.GetComponent<ParticleSystemRenderer>();
        Material material = MakeMaterial(Generated + "/Explosion.mat", "Universal Render Pipeline/2D/Sprite-Unlit-Default", Color.white);
        material.mainTexture = LoadSprite("star1").texture;
        renderer.sharedMaterial = material;
        renderer.sortingOrder = 5;
        return SavePrefab(go, "Explosion");
    }

    // ------------------------------------------------------------------ helpers

    static GameObject SpriteObject(string name, string spriteName, int order)
    {
        var go = new GameObject(name);
        var renderer = go.AddComponent<SpriteRenderer>();
        renderer.sprite = LoadSprite(spriteName);
        renderer.sortingOrder = order;
        return go;
    }

    static GameObject SavePrefab(GameObject go, string name)
    {
        GameObject prefab = PrefabUtility.SaveAsPrefabAsset(go, PrefabFolder + "/" + name + ".prefab");
        Object.DestroyImmediate(go);
        return prefab;
    }

    // Kenney's sprites: 100 pixels per unit, centred. The background tiles, so it
    // needs a Full Rect mesh.
    static Sprite LoadSprite(string name)
    {
        string path = Sprites + "/" + name + ".png";
        Sprite sprite = ImportSprite(path, 100f, new Vector2(0.5f, 0.5f));
        if (name == "darkPurple")
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

    // Kenney's "Future" font, as a TextMeshPro font asset (Chapter 5).
    static TMP_FontAsset MakeFontAsset()
    {
        string path = Fonts + "/kenvector_future SDF.asset";
        var fontAsset = AssetDatabase.LoadAssetAtPath<TMP_FontAsset>(path);
        if (fontAsset != null)
        {
            return fontAsset;
        }
        var sourceFont = AssetDatabase.LoadAssetAtPath<Font>(Fonts + "/kenvector_future.ttf");
        fontAsset = TMP_FontAsset.CreateFontAsset(sourceFont);
        fontAsset.name = "kenvector_future SDF";
        AssetDatabase.CreateAsset(fontAsset, path);
        // The font asset's texture and material must be saved inside it, too.
        fontAsset.atlasTexture.name = "kenvector_future SDF Atlas";
        AssetDatabase.AddObjectToAsset(fontAsset.atlasTexture, fontAsset);
        fontAsset.material.name = "kenvector_future SDF Material";
        AssetDatabase.AddObjectToAsset(fontAsset.material, fontAsset);
        AssetDatabase.SaveAssets();
        return fontAsset;
    }
}
