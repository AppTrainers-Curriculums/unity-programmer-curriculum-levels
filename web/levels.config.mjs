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
];

export const publishedLevels = levels.filter((l) => l.published);

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
