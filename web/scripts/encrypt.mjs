// Post-build step: AES-encrypt each protected course's pages with StatiCrypt so
// visitors need that course's password to read it. Runs after `astro build`.
//
// Password for each course comes from the env var COURSE_PW_<SLUG> (see
// levels.config.mjs). Locally, a missing password just skips that course
// (with a warning). In CI we set STATICRYPT_STRICT=1 so a missing password for a
// protected course FAILS the build — that prevents ever deploying a course that
// is supposed to be protected but isn't.
import { execFileSync } from 'child_process';
import fs from 'fs';
import os from 'os';
import path from 'path';
import { fileURLToPath } from 'url';
import { levels, passwordEnvVar } from '../levels.config.mjs';

const __dirname = path.dirname(fileURLToPath(import.meta.url));
const ROOT = path.join(__dirname, '..');
const DIST = path.join(ROOT, 'dist');
const STRICT = process.env.STATICRYPT_STRICT === '1';
const REMEMBER_DAYS = 30; // "Remember me" keeps a course unlocked in the browser

const toEncrypt = levels.filter((m) => m.published && m.protected);
let didEncryptSomething = false;

// Make "Remember me" checked by default in every encrypted page, so a student
// enters the password ONCE per course and every chapter then auto-unlocks
// (StatiCrypt only persists across pages when this box is ticked).
const REMEMBER_OFF = 'id="staticrypt-remember" type="checkbox" name="remember" />';
const REMEMBER_ON = 'id="staticrypt-remember" type="checkbox" name="remember" checked />';
function defaultCheckRemember(dir) {
  for (const entry of fs.readdirSync(dir, { withFileTypes: true })) {
    const full = path.join(dir, entry.name);
    if (entry.isDirectory()) defaultCheckRemember(full);
    else if (entry.name.endsWith('.html')) {
      const html = fs.readFileSync(full, 'utf8');
      if (html.includes(REMEMBER_OFF)) {
        fs.writeFileSync(full, html.replaceAll(REMEMBER_OFF, REMEMBER_ON));
      }
    }
  }
}

for (const m of toEncrypt) {
  const courseDir = path.join(DIST, m.slug);
  if (!fs.existsSync(courseDir)) continue; // course wasn't built (unpublished)

  const password = process.env[passwordEnvVar(m.slug)];
  if (!password) {
    const msg = `No ${passwordEnvVar(m.slug)} set — "${m.slug}" will NOT be encrypted.`;
    if (STRICT) {
      console.error(`✗ ${msg}`);
      process.exit(1);
    }
    console.warn(`⚠ ${msg} (set it to protect this course)`);
    continue;
  }

  // Encrypt into a temp dir, then copy the encrypted pages back over dist/<slug>.
  // StatiCrypt writes to <outDir>/<basename(input)>/..., so files land in tmp/<slug>/.
  const tmp = fs.mkdtempSync(path.join(os.tmpdir(), `enc-${m.slug}-`));
  execFileSync(
    'npx',
    [
      'staticrypt', courseDir,
      '-r',                         // recurse the course directory
      '-d', tmp,                    // output dir
      '-p', password,
      '-s', m.salt,                 // stable, non-secret salt
      '-c', 'false',                // don't read/write a .staticrypt.json config
      '--remember', String(REMEMBER_DAYS),
      '--short',                    // don't prompt about password length
      '--template-title', m.cardTitle,
      '--template-instructions', 'This course is password-protected. Enter the password your instructor gave you.',
      '--template-color-primary', '#EC4A5A',
      '--template-color-secondary', '#3E4655',
      '--template-button', 'Unlock',
    ],
    { cwd: ROOT, stdio: 'inherit' }
  );

  fs.cpSync(path.join(tmp, m.slug), courseDir, { recursive: true });
  fs.rmSync(tmp, { recursive: true, force: true });
  defaultCheckRemember(courseDir); // enter the password once, stay unlocked
  console.log(`🔒 encrypted ${m.slug}`);
  didEncryptSomething = true;
}

// StatiCrypt encrypts the HTML, but Pagefind's search index (dist/pagefind/) is
// built from the PLAINTEXT pages — leaving it would leak protected content through
// search. Remove it whenever we encrypted anything. (Search is disabled in
// astro.config.mjs too; this is a belt-and-braces cleanup.)
if (didEncryptSomething) {
  fs.rmSync(path.join(DIST, 'pagefind'), { recursive: true, force: true });
  console.log('🧹 removed dist/pagefind (search index) to avoid leaking content');
}

console.log('encrypt done');
