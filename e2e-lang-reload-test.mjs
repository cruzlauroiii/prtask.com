import { chromium } from '@playwright/test';
import { mkdirSync, writeFileSync, appendFileSync } from 'fs';

var LiveSiteUrl = 'https://prtask.com';
var OutputDir = 'output/screenshots';
var LogPath = 'output/e2e-lang-reload-debug.log';

mkdirSync('output/screenshots', { recursive: true });
writeFileSync(LogPath, '=== Language Reload E2E Test — ' + new Date().toISOString() + ' ===\n\n');

function Log(Msg) {
    var Line = '[' + new Date().toISOString() + '] ' + Msg + '\n';
    appendFileSync(LogPath, Line);
    console.log(Msg);
}

async function Screenshot(Page, Name) {
    await Page.screenshot({ path: OutputDir + '/' + Name, fullPage: true });
    Log('Screenshot: ' + Name);
}

(async () => {
    Log('Launching browser...');
    var Browser = await chromium.launch({
        headless: false,
        channel: 'chrome',
        args: ['--start-maximized', '--disable-blink-features=AutomationControlled', '--disable-quic']
    });

    var Failed = false;

    // ── Step 1: Fresh context (no cache, no SW, no localStorage) ──
    Log('');
    Log('══ Step 1: First load — no cache ══');
    var Ctx1 = await Browser.newContext({ viewport: null, ignoreHTTPSErrors: true });
    var Page1 = await Ctx1.newPage();

    await Page1.goto(LiveSiteUrl, { waitUntil: 'networkidle', timeout: 30000 });
    await Page1.waitForTimeout(8000);
    await Screenshot(Page1, 'lang-reload-01-first-load.png');

    var Select1 = Page1.locator('select.language-select');
    var Options1 = [];
    if (await Select1.count() > 0) {
        Options1 = await Select1.first().locator('option').allTextContents();
    }
    Log('First load options: ' + JSON.stringify(Options1));

    var FirstOption1 = Options1.length > 0 ? Options1[0] : '(none)';
    Log('First option text: "' + FirstOption1 + '"');

    if (FirstOption1 === 'EN English') {
        Log('PASS: First load shows "EN English"');
    } else {
        Log('FAIL: First load shows "' + FirstOption1 + '" instead of "EN English"');
        Failed = true;
    }

    // Check none of the options contain flag emoji or IStringLocalizer keys
    var HasBrokenOption = Options1.some(function (O) {
        return O.includes('LanguageEnglish') || O.includes('LanguageChinese') || O.includes('LanguageJapanese');
    });
    if (HasBrokenOption) {
        Log('FAIL: Options contain IStringLocalizer key names: ' + JSON.stringify(Options1));
        Failed = true;
    } else {
        Log('PASS: No IStringLocalizer key names in options');
    }

    // ── Step 2: Reload the page ──
    Log('');
    Log('══ Step 2: Reload page ══');
    await Page1.reload({ waitUntil: 'networkidle', timeout: 30000 });
    await Page1.waitForTimeout(8000);
    await Screenshot(Page1, 'lang-reload-02-after-reload.png');

    var Select2 = Page1.locator('select.language-select');
    var Options2 = [];
    if (await Select2.count() > 0) {
        Options2 = await Select2.first().locator('option').allTextContents();
    }
    Log('After reload options: ' + JSON.stringify(Options2));

    var FirstOption2 = Options2.length > 0 ? Options2[0] : '(none)';
    Log('First option after reload: "' + FirstOption2 + '"');

    if (FirstOption2 === 'EN English') {
        Log('PASS: After reload still shows "EN English"');
    } else {
        Log('FAIL: After reload shows "' + FirstOption2 + '" — reverted to old format');
        Failed = true;
    }

    // Check all options are consistent
    var ExpectedOptions = ['EN English', 'CN \u4e2d\u6587', 'JP \u65e5\u672c\u8a9e', 'DE Deutsch', 'IN \u0939\u093f\u0928\u094d\u0926\u0940'];
    var OptionsMatch = JSON.stringify(Options2) === JSON.stringify(ExpectedOptions);
    if (OptionsMatch) {
        Log('PASS: All options match expected labels after reload');
    } else {
        Log('FAIL: Options mismatch after reload');
        Log('  Expected: ' + JSON.stringify(ExpectedOptions));
        Log('  Got:      ' + JSON.stringify(Options2));
        Failed = true;
    }

    // ── Step 3: Hard reload (Ctrl+Shift+R equivalent) ──
    Log('');
    Log('══ Step 3: Hard reload (bypass cache) ══');
    await Page1.evaluate(function () { location.reload(); });
    await Page1.waitForLoadState('networkidle', { timeout: 30000 });
    await Page1.waitForTimeout(8000);
    await Screenshot(Page1, 'lang-reload-03-hard-reload.png');

    var Select3 = Page1.locator('select.language-select');
    var Options3 = [];
    if (await Select3.count() > 0) {
        Options3 = await Select3.first().locator('option').allTextContents();
    }
    Log('After hard reload options: ' + JSON.stringify(Options3));

    var FirstOption3 = Options3.length > 0 ? Options3[0] : '(none)';
    if (FirstOption3 === 'EN English') {
        Log('PASS: After hard reload still shows "EN English"');
    } else {
        Log('FAIL: After hard reload shows "' + FirstOption3 + '"');
        Failed = true;
    }

    // ── Step 4: New tab in same context (shares SW cache) ──
    Log('');
    Log('══ Step 4: New tab (shares SW cache) ══');
    var Page2 = await Ctx1.newPage();
    await Page2.goto(LiveSiteUrl, { waitUntil: 'networkidle', timeout: 30000 });
    await Page2.waitForTimeout(8000);
    await Screenshot(Page2, 'lang-reload-04-new-tab.png');

    var Select4 = Page2.locator('select.language-select');
    var Options4 = [];
    if (await Select4.count() > 0) {
        Options4 = await Select4.first().locator('option').allTextContents();
    }
    Log('New tab options: ' + JSON.stringify(Options4));

    var FirstOption4 = Options4.length > 0 ? Options4[0] : '(none)';
    if (FirstOption4 === 'EN English') {
        Log('PASS: New tab shows "EN English"');
    } else {
        Log('FAIL: New tab shows "' + FirstOption4 + '"');
        Failed = true;
    }

    await Page2.close();
    await Ctx1.close();

    // ── Summary ──
    Log('');
    Log('=== Test ' + (Failed ? 'FAILED' : 'PASSED') + ' ===');
    await Browser.close();
    process.exit(Failed ? 1 : 0);
})();
