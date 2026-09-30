import { defineConfig } from 'astro/config';
import starlight from '@astrojs/starlight';
import { publishedLevels } from './levels.config.mjs';
import { sidebarFor } from './scripts/workbook.mjs';

// GitHub Pages project site:
// https://apptrainers-curriculums.github.io/unity-programmer-curriculum-levels/
export default defineConfig({
  site: 'https://apptrainers-curriculums.github.io',
  base: '/unity-programmer-curriculum-levels/',
  integrations: [
    starlight({
      title: 'Unity Programmer Curriculum',
      description: 'Learn C# and Unity level by level, from your first line of code to complete games.',
      logo: {
        light: './src/assets/apptrainers-logo.png',
        dark: './src/assets/apptrainers-logo-dark.png',
        replacesTitle: true,
      },
      customCss: ['./src/styles/theme.css'],
      // One group per level, with a sub-group per Part of its workbook, in the
      // book's teaching order. Built from the same parse as the pages, so the
      // two can't disagree. The /code/<slug>/ copy sheets are deliberately NOT
      // in the sidebar: they are unlisted pages you hand out by URL. See
      // scripts/code-page.mjs.
      sidebar: publishedLevels.map((l) => ({
        label: l.sidebarLabel,
        items: sidebarFor(l),
      })),
      pagination: true,
      // Search is disabled: levels are AES-encrypted at build time (see
      // scripts/encrypt.mjs), but Pagefind would index the plaintext pages and
      // leak protected content through the search box. No index = no leak.
      pagefind: false,
    }),
  ],
});
