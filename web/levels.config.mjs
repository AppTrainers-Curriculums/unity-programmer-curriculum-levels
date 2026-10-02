// Single source of truth for the levels on the site.
//
// Each level's workbook stays where it lives in the Unity project, at
// Assets/Levels/LevelN/Docs~/workbook/workbook.md: the same file the PDF is
// built from, so the site and the PDF cannot drift apart.
//
// published: true   → built into the site (pages, sidebar group, home card)
// published: false  → left out of the build entirely (not on the site at all)
//
// protected: true   → the built pages are AES-encrypted with StatiCrypt; a
//                     visitor must enter that level's password to read them.
//                     "Turning a level on for students" = giving them the
//                     password. No rebuild needed once it's deployed.
//
// Passwords are NEVER stored here. At build time each protected level reads its
// password from an environment variable  COURSE_PW_<SLUG>  (slug uppercased,
// dashes → underscores), e.g. COURSE_PW_LEVEL_0.
// In CI these come from GitHub Secrets (see .github/workflows/deploy.yml).
//
// `salt` is a fixed 32-hex string per level — it is NOT secret. Keeping it
// stable makes builds reproducible and lets the "Remember me" box work across a
// level's chapters (enter the password once per level).

export const levels = [
  {
    slug: 'level-0',
    // Relative to the repo root (the Unity project), not to web/.
    src: 'Assets/Levels/Level0/Docs~/workbook/workbook.md',
    shortName: 'Level 0',
    introTitle: 'Before You Start',
    sidebarLabel: 'Level 0 — Rocket Launch',
    cardTitle: 'Level 0 — Rocket Launch',
    cardDescription:
      'Your first C# code and your first Unity scene, for students with no coding experience: 10 build chapters and 11 C# Concept chapters in teaching order, ending with exam-style practice for the Level 1 entry test.',
    published: true,
    protected: true,
    salt: '5e2e2eed7d0648be1a353b3acb2de822',
  },
  {
    slug: 'level-1',
    src: 'Assets/Levels/Level1/Docs~/workbook/workbook.md',
    shortName: 'Level 1',
    introTitle: 'Before You Start',
    sidebarLabel: 'Level 1 — Catch the Falling Blocks',
    cardTitle: 'Level 1 — Catch the Falling Blocks',
    cardDescription:
      'Your first real game: keyboard control, physics, prefabs, a score on screen, sound and a Web build to share. 11 build chapters and 6 C# Concept chapters (scope and access, classes, arrays, loops, enums and switch, text formatting), ending with practice for the Level 2 entry test.',
    published: true,
    protected: true,
    salt: 'acefee769687200f44a527e938277443',
  },
  // Level 2 has three games, each with a book that stands alone and teaches every
  // Level 2 topic (they share the C# Concept chapters, in Level2-Shared). A trainer
  // runs one of them, or gives different groups different ones.
  {
    slug: 'level-2-mini-golf',
    src: 'Assets/Levels/Level2-MiniGolf/Docs~/workbook/workbook.md',
    shortName: 'Level 2 Mini Golf',
    introTitle: 'Before You Start',
    sidebarLabel: 'Level 2 — Mini Golf',
    cardTitle: 'Level 2 — Mini Golf',
    cardDescription:
      'Level 2 in 3D: three holes of mini golf, a ball you aim and putt with a drag, a camera that follows it, golf scores and a scorecard, settings, and a Web build you can play with a finger. 15 build chapters and the 15 Level 2 C# Concept chapters, ending with exam-style practice.',
    published: true,
    protected: true,
    salt: 'e986a094b7a6b5ebdf71655a88971746',
  },
  {
    slug: 'level-2-space-shooter',
    src: 'Assets/Levels/Level2-SpaceShooter/Docs~/workbook/workbook.md',
    shortName: 'Level 2 Space Shooter',
    introTitle: 'Before You Start',
    sidebarLabel: 'Level 2 — Space Shooter',
    cardTitle: 'Level 2 — Space Shooter',
    cardDescription:
      'Level 2 in 2D: a shooter with five waves of enemies, power-ups, explosions, camera shake, a start screen, settings, and controls that work with a finger on a phone. 14 build chapters and the 15 Level 2 C# Concept chapters, ending with exam-style practice.',
    published: true,
    protected: true,
    salt: '6dbfb31e1d537d762a3ffd30d4557a39',
  },
  {
    slug: 'level-2-tank-arena',
    src: 'Assets/Levels/Level2-TankArena/Docs~/workbook/workbook.md',
    shortName: 'Level 2 Tank Arena',
    introTitle: 'Before You Start',
    sidebarLabel: 'Level 2 — Tank Arena',
    cardTitle: 'Level 2 — Tank Arena',
    cardDescription:
      'Level 2 in 2D, seen from above: a tank battle with four rounds of enemy tanks that see you and fire, repair kits, explosions, a follow camera, settings, and touch controls. 15 build chapters and the 15 Level 2 C# Concept chapters, ending with exam-style practice.',
    published: true,
    protected: true,
    salt: '1c1f857e25565bc2b2a7a092f80f8c31',
  },
  // Level 3 has three games too (Knight Run, then Crypt Keys and Gate Guard), each
  // with a book that teaches every Level 3 topic, from the C# Concept chapters in
  // Level3-Shared.
  {
    slug: 'level-3-knight-run',
    src: 'Assets/Levels/Level3-KnightRun/Docs~/workbook/workbook.md',
    shortName: 'Level 3 Knight Run',
    introTitle: 'Before You Start',
    sidebarLabel: 'Level 3 — Knight Run',
    cardTitle: 'Level 3 — Knight Run',
    cardDescription:
      'Level 3 in 2D: a platformer with an animated knight, slimes that think in states, three sections painted with Tilemaps, checkpoints, a health bar, a pause menu and touch buttons. 15 build chapters and the 12 Level 3 C# Concept chapters, ending with practice for the Unity Certified User: Programmer exam.',
    published: true,
    protected: true,
    salt: '4e89439e94f09d592be7fccdf8c4b54f',
  },
  {
    slug: 'level-3-crypt-keys',
    src: 'Assets/Levels/Level3-CryptKeys/Docs~/workbook/workbook.md',
    shortName: 'Level 3 Crypt Keys',
    introTitle: 'Before You Start',
    sidebarLabel: 'Level 3 — Crypt Keys',
    cardTitle: 'Level 3 — Crypt Keys',
    cardDescription:
      'Level 3 in 2D, seen from above: a crypt of six rooms, a warrior who faces four ways, skeletons and archers that think in states, keys, doors and chests, a boss in two phases, and torchlight in the dark. 16 build chapters and the 12 Level 3 C# Concept chapters, ending with practice for the Unity Certified User: Programmer exam.',
    published: true,
    protected: true,
    salt: '6498eedb480b4bd2c4bbe806014524ea',
  },
  {
    slug: 'level-3-gate-guard',
    src: 'Assets/Levels/Level3-GateGuard/Docs~/workbook/workbook.md',
    shortName: 'Level 3 Gate Guard',
    introTitle: 'Before You Start',
    sidebarLabel: 'Level 3 — Gate Guard',
    cardTitle: 'Level 3 — Gate Guard',
    cardDescription:
      'Level 3 in 3D: a tower defence on a hex battlefield painted with the GameObject Brush. Skeletons with Humanoid Avatars rise and march, archers, catapults and frost mages share one Animator Controller, towers grow through three levels, and ten waves end at a castle gate. 16 build chapters and the 12 Level 3 C# Concept chapters, ending with practice for the Unity Certified User: Programmer exam.',
    published: true,
    protected: true,
    salt: '4a222a4208fd7126f439718850c4857b',
  },
];

export const publishedLevels = levels.filter((l) => l.published);

// Files the site serves as they are, linked from the home page. scripts/import.mjs
// copies each one from the Unity project into public/files/ on every build, so
// there is one copy to keep up to date. Public: never list a protected or
// trainer-only file here.
export const downloads = [
  {
    // Relative to the repo root.
    src: 'Assets/Levels/Unity-Programmer-Curriculum-Levels.pdf',
    title: 'The curriculum at a glance (PDF)',
    description:
      'All seven levels, from zero coding to mid-level: what each one teaches in C# and in Unity, and how they lead to the Unity Certified User and Certified Associate programmer exams.',
  },
];

// Where a download is served, relative to the site base.
export const downloadPath = (d) => `files/${d.src.split('/').pop()}`;

export const stripMd = (s) => s.replace(/[`*]/g, '').trim();
export const slugify = (s) =>
  stripMd(s).toLowerCase().replace(/[^a-z0-9]+/g, '-').replace(/^-+|-+$/g, '');

// Where a level starts: its intro page, relative to the site base.
export const introPath = (level) => `${level.slug}/${slugify(level.introTitle)}/`;

// The public, un-encrypted "code to copy" page for a level.
export const codePath = (slug) => `code/${slug}/`;

// Env var name that holds a level's password, e.g. 'COURSE_PW_LEVEL_0'.
export const passwordEnvVar = (slug) =>
  'COURSE_PW_' + slug.toUpperCase().replace(/-/g, '_');
