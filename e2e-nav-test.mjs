import { chromium } from '@playwright/test';
import { mkdirSync, writeFileSync, appendFileSync } from 'fs';

var LiveSiteUrl = 'https://prtask.com';
var OutputDir = 'output/screenshots';
var LogPath = 'output/e2e-nav-debug.log';

mkdirSync('output/screenshots', { recursive: true });
writeFileSync(LogPath, '=== Nav E2E Test — ' + new Date().toISOString() + ' ===\n\n');

function Log(Msg) {
    var Line = '[' + new Date().toISOString() + '] ' + Msg + '\n';
    appendFileSync(LogPath, Line);
    console.log(Msg);
}

async function Screenshot(Page, Name) {
    await Page.screenshot({ path: OutputDir + '/' + Name, fullPage: true });
    Log('Screenshot: ' + Name);
}

var TestArg = (process.argv[2] || '').toLowerCase();

(async () => {
    Log('Launching browser...');
    var Browser = await chromium.launch({
        headless: false,
        channel: 'chrome',
        args: ['--start-maximized', '--disable-blink-features=AutomationControlled', '--disable-quic']
    });

    var Context = await Browser.newContext({ viewport: null, ignoreHTTPSErrors: true });
    var Page = await Context.newPage();
    var Failed = false;

    Page.on('console', function (Msg) {
        if (Msg.type() === 'error') { Log('CONSOLE ERROR: ' + Msg.text()); }
    });

    // ── Navigate and wait for Blazor ────────────────────────────
    Log('Navigate to home page');
    await Page.goto(LiveSiteUrl, { waitUntil: 'networkidle', timeout: 30000 });
    await Page.waitForTimeout(8000);
    await Screenshot(Page, 'nav-01-home.png');

    // ════════════════════════════════════════════════════════════
    // TEST: Language Selector
    // ════════════════════════════════════════════════════════════
    if (!TestArg || TestArg === 'language') {
        Log('');
        Log('══ Language Selector Test ══');

        // Step 1: Find the language selector
        var LangSelect = Page.locator('select.language-select');
        var LangCount = await LangSelect.count();
        Log('Language select elements: ' + LangCount);

        if (LangCount === 0) {
            Log('FAIL: Language selector not found');
            Failed = true;
        } else {
            // Step 2: Check current value
            var CurrentVal = await LangSelect.first().inputValue();
            Log('Current language value: ' + CurrentVal);

            // Step 3: Get all options
            var Options = await LangSelect.first().locator('option').allTextContents();
            Log('Options: ' + JSON.stringify(Options));

            if (Options.length >= 5) {
                Log('PASS: Has 5+ language options');
            } else {
                Log('FAIL: Expected 5+ options, got ' + Options.length);
                Failed = true;
            }

            // Step 4: Check option labels are readable (not key names)
            var HasKeyNames = Options.some(function (O) { return O.includes('Language') && O.includes('English'); });
            if (HasKeyNames) {
                Log('FAIL: Options show IStringLocalizer key names instead of labels (e.g. "LanguageEnglish")');
                Failed = true;
            } else {
                Log('PASS: Option labels are readable');
            }

            await Screenshot(Page, 'nav-02-language-initial.png');

            // Step 5: Change to Chinese
            Log('Changing language to Chinese (zh)...');
            await LangSelect.first().selectOption('zh');

            // Wait for page reload (forceLoad: true triggers full reload)
            await Page.waitForLoadState('networkidle', { timeout: 30000 }).catch(function () {});
            await Page.waitForTimeout(8000);

            var UrlAfterChange = Page.url();
            Log('URL after language change: ' + UrlAfterChange);
            await Screenshot(Page, 'nav-03-after-zh.png');

            // Step 6: Check localStorage was set
            var StoredLang = await Page.evaluate(function () {
                return localStorage.getItem('prtask-language') || '(null)';
            });
            Log('localStorage prtask-language: ' + StoredLang);

            if (StoredLang === 'zh') {
                Log('PASS: Language saved to localStorage');
            } else {
                Log('FAIL: Language not saved — got ' + StoredLang);
                Failed = true;
            }

            // Step 7: Check the selector shows zh after reload
            var LangAfter = Page.locator('select.language-select');
            if (await LangAfter.count() > 0) {
                var ValAfter = await LangAfter.first().inputValue();
                Log('Language selector value after reload: ' + ValAfter);
                if (ValAfter === 'zh') {
                    Log('PASS: Selector shows zh after reload');
                } else {
                    Log('FAIL: Selector shows "' + ValAfter + '" instead of "zh"');
                    Failed = true;
                }
            }

            // Step 8: Check if page text changed (look for Chinese characters)
            var BodyText = await Page.evaluate(function () {
                return document.body.innerText.substring(0, 500);
            });
            Log('Body text (first 500): ' + BodyText.substring(0, 200));

            var HasChinese = /[\u4e00-\u9fff]/.test(BodyText);
            if (HasChinese) {
                Log('PASS: Page contains Chinese characters');
            } else {
                Log('FAIL: Page does NOT contain Chinese characters — localization not working');
                Failed = true;
            }

            // Step 9: Switch back to English
            Log('Switching back to English...');
            var LangRevert = Page.locator('select.language-select');
            if (await LangRevert.count() > 0) {
                await LangRevert.first().selectOption('en');
                await Page.waitForLoadState('networkidle', { timeout: 30000 }).catch(function () {});
                await Page.waitForTimeout(8000);
                Log('Reverted to English');
            }
            await Screenshot(Page, 'nav-04-reverted-en.png');
        }
    }

    // ════════════════════════════════════════════════════════════
    // TEST: Clear Cache Button
    // ════════════════════════════════════════════════════════════
    if (!TestArg || TestArg === 'cache') {
        Log('');
        Log('══ Clear Cache Button Test ══');

        // Make sure we're on the home page
        if (TestArg === 'cache') {
            await Page.goto(LiveSiteUrl, { waitUntil: 'networkidle', timeout: 30000 });
            await Page.waitForTimeout(8000);
        }

        // Step 1: Find the clear cache button (it has the ClearCacheIcon text)
        var CacheBtn = Page.locator('.nav-actions button.nav-action').filter({ hasText: /[\u267b\u21bb\ud83d\udd04]|reload|cache|clear/i });
        var CacheBtnCount = await CacheBtn.count();
        Log('Clear cache button matches: ' + CacheBtnCount);

        if (CacheBtnCount === 0) {
            // Try finding by position — it's the 3rd button in .nav-actions (after language, theme)
            var AllActionBtns = Page.locator('.nav-actions button.nav-action');
            var ActionCount = await AllActionBtns.count();
            Log('Total nav-action buttons: ' + ActionCount);

            // List all buttons
            for (var I = 0; I < ActionCount; I++) {
                var BtnText = await AllActionBtns.nth(I).textContent();
                var BtnTitle = await AllActionBtns.nth(I).getAttribute('title') || '';
                Log('  Button[' + I + ']: text="' + (BtnText || '').trim() + '" title="' + BtnTitle + '"');
            }

            // Find by title attribute
            CacheBtn = Page.locator('.nav-actions button[title*="Cache"], .nav-actions button[title*="cache"], .nav-actions button[title*="Reload"], .nav-actions button[title*="reload"]');
            CacheBtnCount = await CacheBtn.count();
            Log('Cache button by title: ' + CacheBtnCount);
        }

        if (CacheBtnCount === 0) {
            Log('FAIL: Clear cache button not found');
            Failed = true;
        } else {
            await Screenshot(Page, 'nav-05-before-cache-clear.png');

            // Step 2: Check the prtaskClearCache function exists
            var FnExists = await Page.evaluate(function () {
                return typeof window.prtaskClearCache === 'function';
            });
            Log('prtaskClearCache function exists: ' + FnExists);

            if (!FnExists) {
                Log('FAIL: prtaskClearCache function not defined');
                Failed = true;
            } else {
                Log('PASS: prtaskClearCache function exists');
            }

            // Step 3: Check that SW is registered
            var SwStatus = await Page.evaluate(async function () {
                if (!('serviceWorker' in navigator)) return { supported: false };
                var Reg = await navigator.serviceWorker.getRegistration();
                return {
                    supported: true,
                    registered: !!Reg,
                    active: Reg ? !!Reg.active : false,
                    scope: Reg ? Reg.scope : ''
                };
            });
            Log('Service Worker status: ' + JSON.stringify(SwStatus));

            if (SwStatus.registered) {
                Log('PASS: Service Worker registered');
            } else {
                Log('WARN: Service Worker not registered — clear cache may just reload');
            }

            // Step 4: Check Cache API has entries
            var CacheBefore = await Page.evaluate(async function () {
                var Names = await caches.keys();
                var Total = 0;
                for (var I = 0; I < Names.length; I++) {
                    var C = await caches.open(Names[I]);
                    var K = await C.keys();
                    Total += K.length;
                }
                return { caches: Names, totalEntries: Total };
            });
            Log('Caches before: ' + JSON.stringify(CacheBefore));

            // Step 5: Click the clear cache button
            Log('Clicking clear cache button...');
            var UrlBefore = Page.url();

            // Listen for navigation
            var NavigationPromise = Page.waitForNavigation({ timeout: 30000 }).catch(function () { return null; });

            await CacheBtn.first().click();

            // Wait for either reload or timeout
            await NavigationPromise;
            await Page.waitForLoadState('networkidle', { timeout: 30000 }).catch(function () {});
            await Page.waitForTimeout(5000);

            var UrlAfter = Page.url();
            Log('URL before: ' + UrlBefore);
            Log('URL after: ' + UrlAfter);
            await Screenshot(Page, 'nav-06-after-cache-clear.png');

            // Step 6: Verify URL didn't get query params
            if (UrlAfter.includes('?t=') || UrlAfter.includes('?v=')) {
                Log('FAIL: URL has cache-busting query params: ' + UrlAfter);
                Failed = true;
            } else {
                Log('PASS: URL has no cache-busting query params');
            }

            // Step 7: Page should still be functional
            var BodyAfter = await Page.evaluate(function () {
                return document.body.innerText.length;
            });
            Log('Body text length after clear: ' + BodyAfter);

            if (BodyAfter > 50) {
                Log('PASS: Page loaded after cache clear');
            } else {
                Log('FAIL: Page appears empty after cache clear');
                Failed = true;
            }
        }
    }

    // ── Summary ─────────────────────────────────────────────────
    Log('');
    Log('=== Test ' + (Failed ? 'FAILED' : 'PASSED') + ' ===');
    await Browser.close();
    process.exit(Failed ? 1 : 0);
})();
