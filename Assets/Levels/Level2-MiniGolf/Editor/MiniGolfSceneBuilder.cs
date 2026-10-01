using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEditor.Events;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;
using static Level2BuilderKit;

// INSTRUCTOR TOOL: not part of the student book, and never shipped in a build.
// Menu: Tools → Mini Golf (Level 2) → Build Scene
//
// Rebuilds Assets/Levels/Level2-MiniGolf/Scenes/MiniGolf.unity exactly as the
// Mini Golf book describes it: the three holes built from the Kenney Minigolf
// Kit tiles, the ball, the aim line, the camera, the confetti, the HUD and the
// settings and scorecard panels, with every Inspector reference wired up.
// Use it to prepare lab machines or to reset a broken scene. Running it again
// overwrites the scene and the materials it makes.
//
// This curriculum project was created from the Universal 2D template, so the
// builder also adds a 3D (Universal) renderer to the project's URP asset and
// gives the camera that renderer. Students start from the Universal 3D template
// and need none of that.
public static class MiniGolfSceneBuilder
{
    const string Root = "Assets/Levels/Level2-MiniGolf";
    const string ScenePath = Root + "/Scenes/MiniGolf.unity";
    const string Models = Root + "/Art/Models";
    const string Generated = Root + "/Generated";

    const float Floor = 0.063f;           // height of a tile's green surface
    const float BallRadius = 0.035f;      // the Kenney ball is 7 cm across

    [MenuItem("Tools/Mini Golf (Level 2)/Build Scene")]
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
        EnsureFolder(Generated);
        int courseLayer = AddLayer("Course");
        PrepareModels();

        // Unity ignores bounces slower than 2 m/s. 0.5 lets a gentle putt bounce off a
        // wall, and still lets a resting ball rest (Chapter 3).
        Physics.bounceThreshold = 0.5f;

        var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
        RenderSettings.ambientMode = AmbientMode.Trilight;
        RenderSettings.ambientSkyColor = Hex("#C9E4F5");
        RenderSettings.ambientEquatorColor = Hex("#A8B9C4");
        RenderSettings.ambientGroundColor = Hex("#5E6B5A");

        // ---- Light and camera (Chapters 1 and 5) ----
        var lightObject = new GameObject("Directional Light");
        lightObject.transform.rotation = Quaternion.Euler(50f, -30f, 0f);
        var sun = lightObject.AddComponent<Light>();
        sun.type = LightType.Directional;
        sun.intensity = 1.2f;
        sun.color = Hex("#FFF4E0");
        sun.shadows = LightShadows.Soft;

        var cameraObject = new GameObject("Main Camera");
        cameraObject.tag = "MainCamera";
        cameraObject.transform.position = new Vector3(0f, 3f, -2.5f);
        cameraObject.transform.rotation = Quaternion.Euler(50f, 0f, 0f);
        var cam = cameraObject.AddComponent<Camera>();
        cam.fieldOfView = 60f;
        cam.nearClipPlane = 0.05f;
        cam.clearFlags = CameraClearFlags.SolidColor;
        cam.backgroundColor = Hex("#8ECAE6");
        cameraObject.AddComponent<AudioListener>();
        UseThreeDRenderer(cam);
        var follow = cameraObject.AddComponent<CameraFollow>();

        // ---- The course: three holes built from tiles (Chapters 1, 2 and 9) ----
        var course = new GameObject("Course").transform;

        // Kenney's tiles are only pictures. What the ball touches is a few
        // invisible boxes per hole: one floor with no seams, and the walls.
        Hole hole1 = MakeHole(course, "Hole 1", "The Windmill", 2, new Vector3(0f, 0f, 0f), courseLayer);
        Tile(hole1, "end", 0, 0, 180f);
        Tile(hole1, "straight", 0, 1, 0f);
        GameObject windmill = Tile(hole1, "windmill", 0, 2, 0f);
        Tile(hole1, "straight", 0, 3, 0f);
        Tile(hole1, "hole-square", 0, 4, 0f);
        Transform walls1 = hole1.transform.Find("Colliders");
        Box(walls1, "Floor", new Vector3(0f, 0.0315f, 2f), new Vector3(1f, 0.063f, 5f));
        Box(walls1, "Left Wall", new Vector3(-0.45f, 0.0735f, 2f), new Vector3(0.1f, 0.147f, 5f));
        Box(walls1, "Right Wall", new Vector3(0.45f, 0.0735f, 2f), new Vector3(0.1f, 0.147f, 5f));
        Box(walls1, "Back Wall", new Vector3(0f, 0.0735f, -0.45f), new Vector3(1f, 0.147f, 0.1f));
        Box(walls1, "End Wall", new Vector3(0f, 0.0735f, 4.45f), new Vector3(1f, 0.147f, 0.1f));
        Box(walls1, "Windmill Left", new Vector3(-0.3f, 0.15f, 2f), new Vector3(0.2f, 0.3f, 0.8f));
        Box(walls1, "Windmill Right", new Vector3(0.3f, 0.15f, 2f), new Vector3(0.2f, 0.3f, 0.8f));
        Cup cup1 = MakeCup(hole1, 0, 4, "flag-red");

        // The windmill's blades spin (Chapter 2).
        Transform blades = windmill.transform.Find("blades");
        var spinner = blades.gameObject.AddComponent<Spinner>();
        SetVector3(spinner, "degreesPerSecond", new Vector3(0f, 0f, 60f));

        Hole hole2 = MakeHole(course, "Hole 2", "Around the Corner", 3, new Vector3(3f, 0f, 0f), courseLayer);
        Tile(hole2, "end", 0, 0, 180f);
        Tile(hole2, "straight", 0, 1, 0f);
        Tile(hole2, "corner", 0, 2, 0f);
        Tile(hole2, "straight", 1, 2, 90f);
        Tile(hole2, "obstacle-block", 2, 2, 90f);
        Tile(hole2, "hole-square", 3, 2, 90f);
        Transform walls2 = hole2.transform.Find("Colliders");
        Box(walls2, "Floor", new Vector3(1.5f, 0.0315f, 1f), new Vector3(4f, 0.063f, 3f));
        Box(walls2, "Left Wall", new Vector3(-0.45f, 0.0735f, 1f), new Vector3(0.1f, 0.147f, 3f));
        Box(walls2, "Top Wall", new Vector3(1.5f, 0.0735f, 2.45f), new Vector3(4f, 0.147f, 0.1f));
        Box(walls2, "Inner Wall A", new Vector3(0.45f, 0.0735f, 0.5f), new Vector3(0.1f, 0.147f, 2f));
        Box(walls2, "Inner Wall B", new Vector3(2f, 0.0735f, 1.55f), new Vector3(3f, 0.147f, 0.1f));
        Box(walls2, "Back Wall", new Vector3(0f, 0.0735f, -0.45f), new Vector3(1f, 0.147f, 0.1f));
        Box(walls2, "End Wall", new Vector3(3.45f, 0.0735f, 2f), new Vector3(0.1f, 0.147f, 1f));
        Box(walls2, "Pillar", new Vector3(2f, 0.0735f, 2f), new Vector3(0.63f, 0.147f, 0.16f));
        Cup cup2 = MakeCup(hole2, 3, 2, "flag-blue");

        Hole hole3 = MakeHole(course, "Hole 3", "Mind the Edge", 3, new Vector3(8f, 0f, 0f), courseLayer);
        Tile(hole3, "end", 0, 0, 180f);
        Tile(hole3, "straight", 0, 1, 0f);
        Tile(hole3, "open", 0, 2, 0f);
        Tile(hole3, "open", 0, 3, 0f);
        Tile(hole3, "straight", 0, 4, 0f);
        Tile(hole3, "hole-square", 0, 5, 0f);
        Transform walls3 = hole3.transform.Find("Colliders");
        Box(walls3, "Floor", new Vector3(0f, 0.0315f, 2.5f), new Vector3(1f, 0.063f, 6f));
        Box(walls3, "Left Wall 1", new Vector3(-0.45f, 0.0735f, 0.5f), new Vector3(0.1f, 0.147f, 2f));
        Box(walls3, "Right Wall 1", new Vector3(0.45f, 0.0735f, 0.5f), new Vector3(0.1f, 0.147f, 2f));
        Box(walls3, "Left Wall 2", new Vector3(-0.45f, 0.0735f, 4.5f), new Vector3(0.1f, 0.147f, 2f));
        Box(walls3, "Right Wall 2", new Vector3(0.45f, 0.0735f, 4.5f), new Vector3(0.1f, 0.147f, 2f));
        Box(walls3, "Back Wall", new Vector3(0f, 0.0735f, -0.45f), new Vector3(1f, 0.147f, 0.1f));
        Box(walls3, "End Wall", new Vector3(0f, 0.0735f, 5.45f), new Vector3(1f, 0.147f, 0.1f));
        Cup cup3 = MakeCup(hole3, 0, 5, "flag-green");

        // A block sliding across the open stretch, where there are no walls (Chapter 9).
        var block = GameObject.CreatePrimitive(PrimitiveType.Cube);
        block.name = "Moving Block";
        block.layer = courseLayer;
        block.transform.SetParent(hole3.transform, false);
        block.transform.localPosition = new Vector3(0f, Floor + 0.04f, 2.5f);
        block.transform.localScale = new Vector3(0.2f, 0.08f, 0.1f);
        block.GetComponent<Renderer>().sharedMaterial = MakeMaterial(Generated + "/MovingBlock.mat",
            "Universal Render Pipeline/Lit", Hex("#FF7E44"));
        var blockBody = block.AddComponent<Rigidbody>();
        blockBody.isKinematic = true;
        blockBody.interpolation = RigidbodyInterpolation.Interpolate;
        var mover = block.AddComponent<MovingBlock>();
        SetVector3(mover, "travel", new Vector3(0.3f, 0f, 0f));

        // ---- The ball (Chapters 3 and 4) ----
        var ball = new GameObject("Ball");
        ball.transform.position = hole1.transform.position + new Vector3(0f, Floor + BallRadius + 0.002f, 0f);
        var model = (GameObject)PrefabUtility.InstantiatePrefab(LoadModel("ball-red"), ball.transform);
        model.name = "Model";
        var ballBody = ball.AddComponent<Rigidbody>();
        ballBody.mass = 1f;
        ballBody.linearDamping = 0.6f;
        ballBody.angularDamping = 0.05f;
        ballBody.interpolation = RigidbodyInterpolation.Interpolate;
        ballBody.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
        var ballCollider = ball.AddComponent<SphereCollider>();
        ballCollider.radius = BallRadius;
        ballCollider.sharedMaterial = MakeBallPhysics();
        var golfBall = ball.AddComponent<GolfBall>();
        var ballAudio = ball.AddComponent<AudioSource>();
        ballAudio.playOnAwake = false;
        var ballSounds = ball.AddComponent<BallSounds>();

        // ---- The aim line (Chapter 6) ----
        var aimerObject = new GameObject("Shot Aimer");
        var line = aimerObject.AddComponent<LineRenderer>();
        line.positionCount = 2;
        line.useWorldSpace = true;
        line.widthMultiplier = 0.02f;
        line.shadowCastingMode = ShadowCastingMode.Off;
        line.sharedMaterial = MakeMaterial(Generated + "/AimLine.mat", "Universal Render Pipeline/Unlit", Color.white);
        var aimer = aimerObject.AddComponent<ShotAimer>();

        // ---- Confetti for the cup (Chapter 11) ----
        ParticleSystem confetti = MakeConfetti();

        // ---- The game (Chapters 7 to 13) ----
        var gameHolder = new GameObject("Golf Game");
        var game = gameHolder.AddComponent<GolfGame>();
        var gameAudio = gameHolder.AddComponent<AudioSource>();
        gameAudio.playOnAwake = false;

        // ---- The screen (Chapters 7, 12 and 13) ----
        Transform ui = MakeCanvas("Canvas");
        Color text = Color.white;
        Image bar = MakeImage(ui, "Top Bar", Hex("#38383D", 0.7f), new Vector2(0.5f, 1f), Vector2.zero, new Vector2(1920f, 110f));
        bar.rectTransform.anchorMin = new Vector2(0f, 1f);
        bar.rectTransform.anchorMax = new Vector2(1f, 1f);
        bar.rectTransform.sizeDelta = new Vector2(0f, 110f);
        TMP_Text holeText = MakeText(ui, "Hole Text", "Hole 1 of 3    Par 2", 48f, TextAlignmentOptions.Left,
                                     new Vector2(0f, 1f), new Vector2(40f, -20f), new Vector2(900f, 70f), text);
        TMP_Text strokesText = MakeText(ui, "Strokes Text", "Strokes: 0", 48f, TextAlignmentOptions.Center,
                                        new Vector2(0.5f, 1f), new Vector2(0f, -20f), new Vector2(500f, 70f), text);
        TMP_Text powerText = MakeText(ui, "Power Text", "", 64f, TextAlignmentOptions.Center,
                                      new Vector2(0.5f, 0f), new Vector2(0f, 50f), new Vector2(700f, 90f), text);
        TMP_Text messageText = MakeText(ui, "Message Text", "", 96f, TextAlignmentOptions.Center,
                                        new Vector2(0.5f, 0.5f), new Vector2(0f, 180f), new Vector2(1700f, 200f), text);
        messageText.fontStyle = FontStyles.Bold;
        Button settingsButton = MakeButton(ui, "Settings Button", "Settings", Vector2.zero, new Vector2(260f, 80f), Hex("#FF7E44"));
        RectTransform settingsRect = (RectTransform)settingsButton.transform;
        settingsRect.anchorMin = new Vector2(1f, 1f);
        settingsRect.anchorMax = new Vector2(1f, 1f);
        settingsRect.pivot = new Vector2(1f, 1f);
        settingsRect.anchoredPosition = new Vector2(-30f, -15f);

        // Settings panel: a window scaled ×2.2 so the default-sized controls read well
        GameObject settingsPanel;
        RectTransform settingsWindow = MakeWindow(ui, "Settings Panel", new Vector2(420f, 300f), 2.2f, Hex("#38383D"), out settingsPanel);
        MakeText(settingsWindow, "Title", "Settings", 30f, TextAlignmentOptions.Center,
                 new Vector2(0.5f, 0.5f), new Vector2(0f, 115f), new Vector2(380f, 50f), text);
        MakeText(settingsWindow, "Volume Label", "Volume", 18f, TextAlignmentOptions.Left,
                 new Vector2(0.5f, 0.5f), new Vector2(-110f, 60f), new Vector2(140f, 30f), text);
        Slider volumeSlider = MakeSlider(settingsWindow, "Volume Slider", new Vector2(60f, 60f), 200f);
        volumeSlider.value = 1f;
        Toggle aimLineToggle = MakeToggle(settingsWindow, "Aim Line Toggle", "Show the aim line", new Vector2(10f, 18f));
        aimLineToggle.isOn = true;
        MakeText(settingsWindow, "Name Label", "Name", 18f, TextAlignmentOptions.Left,
                 new Vector2(0.5f, 0.5f), new Vector2(-110f, -28f), new Vector2(140f, 30f), text);
        TMP_InputField nameInput = MakeInputField(settingsWindow, "Name Input", "Your name", new Vector2(60f, -28f), 200f);
        MakeText(settingsWindow, "Ball Label", "Ball", 18f, TextAlignmentOptions.Left,
                 new Vector2(0.5f, 0.5f), new Vector2(-110f, -72f), new Vector2(140f, 30f), text);
        TMP_Dropdown ballDropdown = MakeDropdown(settingsWindow, "Ball Dropdown", new Vector2(60f, -72f), 200f, "Red", "Blue", "Green");
        Button closeButton = MakeButton(settingsWindow, "Close Button", "Close", new Vector2(0f, -120f), new Vector2(160f, 36f), Hex("#FF7E44"));
        var settings = settingsPanel.AddComponent<SettingsMenu>();
        settingsPanel.SetActive(false);

        // The Settings button opens the panel: connected in the Inspector (Chapter 12)
        UnityEventTools.AddBoolPersistentListener(settingsButton.onClick, settingsPanel.SetActive, true);

        // Scorecard panel (Chapter 13)
        GameObject scorecardPanel;
        RectTransform scorecardWindow = MakeWindow(ui, "Scorecard Panel", new Vector2(560f, 330f), 2f, Hex("#38383D"), out scorecardPanel);
        TMP_Text scorecardText = MakeText(scorecardWindow, "Scorecard Text", "Scorecard", 20f, TextAlignmentOptions.TopLeft,
                                          new Vector2(0.5f, 0.5f), new Vector2(0f, 25f), new Vector2(520f, 250f), text);
        Button playAgainButton = MakeButton(scorecardWindow, "Play Again Button", "Play Again", new Vector2(0f, -130f),
                                            new Vector2(200f, 40f), Hex("#61CB8B"));
        scorecardPanel.SetActive(false);

        // ---- Wire up every Inspector reference ----
        Set(follow, "target", ball.transform);
        SetVector3(follow, "offset", new Vector3(0f, 3f, -2.5f));

        Set(ballSounds, "audioSource", ballAudio);
        Set(ballSounds, "wallSound", LoadClip(Root + "/Audio/Wall.wav"));

        Set(aimer, "ball", golfBall);
        Set(aimer, "game", game);
        Set(aimer, "aimLine", line);
        SetLayerMask(aimer, "wallsMask", "Course");

        foreach (Cup cup in new[] { cup1, cup2, cup3 })
        {
            Set(cup, "game", game);
        }

        SetArray(game, "holes", hole1, hole2, hole3);
        Set(game, "ball", golfBall);
        Set(game, "confetti", confetti);
        Set(game, "holeText", holeText);
        Set(game, "strokesText", strokesText);
        Set(game, "powerText", powerText);
        Set(game, "messageText", messageText);
        Set(game, "scorecardPanel", scorecardPanel);
        Set(game, "scorecardText", scorecardText);
        Set(game, "playAgainButton", playAgainButton);
        Set(game, "audioSource", gameAudio);
        Set(game, "puttSound", LoadClip(Root + "/Audio/Putt.wav"));
        Set(game, "cupSound", LoadClip(Root + "/Audio/Cup.wav"));
        Set(game, "fallSound", LoadClip(Root + "/Audio/Fall.wav"));
        Set(game, "cheerSound", LoadClip(Root + "/Audio/Cheer.wav"));

        Set(settings, "volumeSlider", volumeSlider);
        Set(settings, "aimLineToggle", aimLineToggle);
        Set(settings, "nameInput", nameInput);
        Set(settings, "ballDropdown", ballDropdown);
        Set(settings, "closeButton", closeButton);
        Set(settings, "aimer", aimer);
        Set(settings, "game", game);
        Set(settings, "ballModel", model.GetComponent<MeshFilter>());
        SetArray(settings, "ballMeshes", LoadMesh("ball-red"), LoadMesh("ball-blue"), LoadMesh("ball-green"));

        AssetDatabase.SaveAssets();
        SaveScene(scene, ScenePath);
        Debug.Log("Mini Golf scene built: " + ScenePath);
    }

    // ------------------------------------------------------------------ course

    static Hole MakeHole(Transform course, string name, string holeName, int par, Vector3 position, int layer)
    {
        var holeObject = new GameObject(name);
        holeObject.transform.SetParent(course, false);
        holeObject.transform.localPosition = position;
        holeObject.layer = layer;

        var colliders = new GameObject("Colliders");
        colliders.layer = layer;
        colliders.transform.SetParent(holeObject.transform, false);

        var tee = new GameObject("Tee").transform;
        tee.gameObject.layer = layer;    // a new child takes its hole's layer, as in the book
        tee.SetParent(holeObject.transform, false);
        tee.localPosition = new Vector3(0f, Floor + BallRadius + 0.002f, 0f);

        var hole = holeObject.AddComponent<Hole>();
        SetString(hole, "holeName", holeName);
        SetInt(hole, "par", par);
        Set(hole, "tee", tee);
        return hole;
    }

    // Places one Kenney tile in a hole, x and z in whole tiles from the hole's tee tile.
    static GameObject Tile(Hole hole, string modelName, int x, int z, float turn)
    {
        var tile = (GameObject)PrefabUtility.InstantiatePrefab(LoadModel(modelName), hole.transform);
        tile.transform.localPosition = new Vector3(x, 0f, z);
        tile.transform.localRotation = Quaternion.Euler(0f, turn, 0f);
        SetLayerRecursively(tile, hole.gameObject.layer);
        return tile;
    }

    // The cup: a small trigger sphere at the ball's height, over the hole in a
    // hole tile, and a flag standing in it.
    static Cup MakeCup(Hole hole, int x, int z, string flagModel)
    {
        var cupObject = new GameObject("Cup");
        cupObject.transform.SetParent(hole.transform, false);
        cupObject.transform.localPosition = new Vector3(x, Floor + BallRadius, z);
        var sphere = cupObject.AddComponent<SphereCollider>();
        sphere.isTrigger = true;
        sphere.radius = 0.03f;
        var cup = cupObject.AddComponent<Cup>();

        var flag = (GameObject)PrefabUtility.InstantiatePrefab(LoadModel(flagModel), hole.transform);
        SetLayerRecursively(flag, hole.gameObject.layer);
        flag.transform.localPosition = new Vector3(x, 0.032f, z);
        flag.transform.localRotation = Quaternion.Euler(0f, -40f, 0f);
        return cup;
    }

    // An invisible box the ball can touch.
    static void Box(Transform colliders, string name, Vector3 center, Vector3 size)
    {
        var box = new GameObject(name);
        box.layer = colliders.gameObject.layer;
        box.transform.SetParent(colliders, false);
        box.transform.localPosition = center;
        box.AddComponent<BoxCollider>().size = size;
    }

    // ------------------------------------------------------------------ assets

    // Kenney's FBX files are pictures only: no generated colliders (the holes use
    // a few invisible boxes instead), and no animation, cameras or lights.
    static void PrepareModels()
    {
        foreach (string guid in AssetDatabase.FindAssets("t:Model", new[] { Models }))
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            var importer = AssetImporter.GetAtPath(path) as ModelImporter;
            if (importer == null)
            {
                continue;
            }
            if (importer.addCollider || importer.importAnimation || importer.importCameras || importer.importLights)
            {
                importer.addCollider = false;
                importer.importAnimation = false;
                importer.importCameras = false;
                importer.importLights = false;
                importer.SaveAndReimport();
            }
        }
    }

    static GameObject LoadModel(string name)
    {
        var model = AssetDatabase.LoadAssetAtPath<GameObject>(Models + "/" + name + ".fbx");
        if (model == null)
        {
            Debug.LogError("Missing model: " + Models + "/" + name + ".fbx");
        }
        return model;
    }

    static Mesh LoadMesh(string modelName)
    {
        foreach (Object asset in AssetDatabase.LoadAllAssetsAtPath(Models + "/" + modelName + ".fbx"))
        {
            if (asset is Mesh)
            {
                return (Mesh)asset;
            }
        }
        Debug.LogError("No mesh in " + modelName);
        return null;
    }

    // No friction (the ball slides, and only Linear Damping slows it) and a
    // lively bounce off the walls.
    static PhysicsMaterial MakeBallPhysics()
    {
        string path = Generated + "/BallPhysics.asset";
        var material = AssetDatabase.LoadAssetAtPath<PhysicsMaterial>(path);
        if (material == null)
        {
            material = new PhysicsMaterial("Ball");
            AssetDatabase.CreateAsset(material, path);
        }
        material.dynamicFriction = 0f;
        material.staticFriction = 0f;
        material.frictionCombine = PhysicsMaterialCombine.Minimum;
        material.bounciness = 0.6f;
        material.bounceCombine = PhysicsMaterialCombine.Maximum;
        EditorUtility.SetDirty(material);
        return material;
    }

    static ParticleSystem MakeConfetti()
    {
        var go = new GameObject("Confetti");
        go.transform.rotation = Quaternion.Euler(-90f, 0f, 0f);    // the cone points up
        var particles = go.AddComponent<ParticleSystem>();
        particles.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);

        ParticleSystem.MainModule main = particles.main;
        main.duration = 1f;
        main.loop = false;
        main.playOnAwake = false;
        main.startLifetime = new ParticleSystem.MinMaxCurve(1.2f, 1.8f);
        main.startSpeed = new ParticleSystem.MinMaxCurve(1.5f, 3f);
        main.startSize = new ParticleSystem.MinMaxCurve(0.03f, 0.06f);
        main.startRotation = new ParticleSystem.MinMaxCurve(0f, Mathf.PI * 2f);
        main.gravityModifier = 0.6f;
        main.simulationSpace = ParticleSystemSimulationSpace.World;
        var colours = new Gradient();
        colours.SetKeys(
            new[]
            {
                new GradientColorKey(Hex("#FFC044"), 0f),
                new GradientColorKey(Hex("#FF7E44"), 0.25f),
                new GradientColorKey(Hex("#F378F0"), 0.5f),
                new GradientColorKey(Hex("#6794D9"), 0.75f),
                new GradientColorKey(Hex("#61CB8B"), 1f),
            },
            new[] { new GradientAlphaKey(1f, 0f), new GradientAlphaKey(1f, 1f) });
        var startColor = new ParticleSystem.MinMaxGradient(colours);
        startColor.mode = ParticleSystemGradientMode.RandomColor;
        main.startColor = startColor;

        ParticleSystem.EmissionModule emission = particles.emission;
        emission.rateOverTime = 0f;
        emission.SetBursts(new[] { new ParticleSystem.Burst(0f, 80) });

        ParticleSystem.ShapeModule shape = particles.shape;
        shape.shapeType = ParticleSystemShapeType.Cone;
        shape.angle = 30f;
        shape.radius = 0.05f;

        var renderer = go.GetComponent<ParticleSystemRenderer>();
        renderer.sharedMaterial = MakeMaterial(Generated + "/Confetti.mat",
            "Universal Render Pipeline/Particles/Unlit", Color.white);
        return particles;
    }

    // ------------------------------------------------------------------ renderer

    // The project's URP asset only has a 2D renderer. Add a Universal (3D)
    // renderer once, and make this scene's camera use it.
    static void UseThreeDRenderer(Camera cam)
    {
        var pipeline = GraphicsSettings.currentRenderPipeline as UniversalRenderPipelineAsset;
        if (pipeline == null)
        {
            Debug.LogWarning("No URP asset is active: the camera keeps its default renderer.");
            return;
        }

        string path = Root + "/Settings/MiniGolfRenderer.asset";
        var rendererData = AssetDatabase.LoadAssetAtPath<UniversalRendererData>(path);
        if (rendererData == null)
        {
            EnsureFolder(Root + "/Settings");
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
}
