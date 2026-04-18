import { chromium } from '@playwright/test';
import { mkdirSync, writeFileSync, appendFileSync } from 'fs';

var LiveSiteUrl = 'https://prtask.com';
var OutputDir = 'output/screenshots';
var LogPath = 'output/e2e-sync-debug.log';

mkdirSync('output/screenshots', { recursive: true });
writeFileSync(LogPath, '=== Sync E2E Test — ' + new Date().toISOString() + ' ===\n\n');

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

    var Context = await Browser.newContext({ viewport: null, ignoreHTTPSErrors: true });
    var Page = await Context.newPage();
    var Failed = false;

    // Capture console messages
    Page.on('console', function (Msg) {
        if (Msg.type() === 'error') { Log('CONSOLE ERROR: ' + Msg.text()); }
    });
    Page.on('pageerror', function (Err) { Log('PAGE ERROR: ' + Err.message); });

    // ── Step 1: Navigate to home page ───────────────────────────
    Log('Step 1: Navigate to home page');
    await Page.goto(LiveSiteUrl, { waitUntil: 'networkidle', timeout: 30000 });
    await Page.waitForTimeout(5000);
    await Screenshot(Page, 'sync-01-home.png');

    // ── Step 2: Verify OFFLINE status and Sync Now button ───────
    Log('Step 2: Verify sync status bar');
    var Bar = Page.locator('.sync-status-bar');
    var StatusText = Page.locator('.sync-status-text');
    var SyncBtn = Page.locator('.sync-status-button', { hasText: 'Sync Now' });

    var BarText = (await StatusText.textContent() || '').trim();
    Log('Initial status: "' + BarText + '"');

    if (await SyncBtn.count() > 0 && await SyncBtn.isVisible()) {
        Log('PASS: Sync Now button visible');
    } else {
        Log('FAIL: Sync Now button not found');
        Failed = true;
    }

    // ── Step 3: Click Sync Now — should do real delta sync ──────
    Log('Step 3: Click Sync Now (real delta sync)');
    await SyncBtn.click();
    Log('Clicked Sync Now — waiting for sync...');

    // Monitor status changes (up to 120s for first sync — downloads all assets)
    for (var I = 0; I < 120; I++) {
        await Page.waitForTimeout(1000);
        var CurrentText = (await StatusText.textContent() || '').trim();
        if (I % 5 === 0 || CurrentText.includes('OFFLINE')) {
            Log('  [' + (I + 1) + 's] status="' + CurrentText + '"');
        }

        if (CurrentText.includes('OFFLINE') && CurrentText.includes('Last synced')) {
            Log('Sync completed — returned to OFFLINE with last synced time');
            break;
        }
        if (CurrentText.includes('OFFLINE') && I > 5) {
            Log('Returned to OFFLINE');
            break;
        }
    }

    await Screenshot(Page, 'sync-02-after-sync.png');

    // ── Step 4: Verify sync actually happened ───────────────────
    Log('Step 4: Verify sync results');

    var FinalText = (await StatusText.textContent() || '').trim();
    if (FinalText.includes('OFFLINE')) {
        Log('PASS: Returned to OFFLINE after sync');
    } else {
        Log('FAIL: Did not return to OFFLINE — stuck on "' + FinalText + '"');
        Failed = true;
    }

    if (FinalText.includes('Last synced')) {
        Log('PASS: Shows last synced time');
    } else {
        Log('INFO: No last synced time (sync may have failed)');
    }

    // Check OPFS manifest was saved
    var ManifestExists = await Page.evaluate(async function () {
        try {
            var Root = await navigator.storage.getDirectory();
            var MetaDir = await Root.getDirectoryHandle('Meta');
            var Handle = await MetaDir.getFileHandle('AssetManifest.json');
            var File = await Handle.getFile();
            var Text = await File.text();
            var Manifest = JSON.parse(Text);
            return { Exists: true, AssetCount: Manifest.assets ? Manifest.assets.length : 0, Version: Manifest.version || '' };
        } catch (E) {
            return { Exists: false, Error: E.message };
        }
    });
    Log('OPFS manifest: ' + JSON.stringify(ManifestExists));

    if (ManifestExists.Exists && ManifestExists.AssetCount > 0) {
        Log('PASS: Asset manifest saved to OPFS (' + ManifestExists.AssetCount + ' assets, version=' + ManifestExists.Version + ')');
    } else {
        Log('FAIL: Asset manifest not found in OPFS: ' + (ManifestExists.Error || 'unknown'));
        Failed = true;
    }

    // Check Cache API has assets
    var CacheInfo = await Page.evaluate(async function () {
        var Cache = await caches.open('prtask-assets');
        var Keys = await Cache.keys();
        return { Count: Keys.length, Sample: Keys.slice(0, 5).map(function (K) { return new URL(K.url).pathname; }) };
    });
    Log('Cache API assets: count=' + CacheInfo.Count + ' sample=' + JSON.stringify(CacheInfo.Sample));

    if (CacheInfo.Count > 0) {
        Log('PASS: Assets cached in Cache API (' + CacheInfo.Count + ' entries)');
    } else {
        Log('FAIL: No assets in Cache API');
        Failed = true;
    }

    // ── Step 5: Verify Sync Now button reappears ────────────────
    Log('Step 5: Verify Sync Now button reappears');
    var SyncBtnAfter = Page.locator('.sync-status-button', { hasText: 'Sync Now' });
    if (await SyncBtnAfter.count() > 0 && await SyncBtnAfter.isVisible()) {
        Log('PASS: Sync Now button reappeared');
    } else {
        Log('FAIL: Sync Now button did not reappear');
        Failed = true;
    }

    // ── Step 6: Second sync should be fast (delta — no downloads) ──
    Log('Step 6: Second sync (should skip all — delta)');
    await SyncBtnAfter.click();
    await Page.waitForTimeout(10000);

    var SecondText = (await StatusText.textContent() || '').trim();
    Log('After second sync: "' + SecondText + '"');
    await Screenshot(Page, 'sync-03-second-sync.png');

    if (SecondText.includes('OFFLINE')) {
        Log('PASS: Second sync completed');
    } else {
        Log('FAIL: Second sync stuck on "' + SecondText + '"');
        Failed = true;
    }

    // ── Step 7: Verify no IndexedDB usage ───────────────────────
    Log('Step 7: Verify no IndexedDB');
    var IdbDatabases = await Page.evaluate(async function () {
        if (indexedDB.databases) {
            var Dbs = await indexedDB.databases();
            return Dbs.map(function (D) { return D.name; });
        }
        return ['(databases() not supported)'];
    });
    Log('IndexedDB databases: ' + JSON.stringify(IdbDatabases));

    var HasPrtaskDb = IdbDatabases.some(function (N) { return N && N.indexOf('PrtaskLocalStore') !== -1; });
    if (!HasPrtaskDb) {
        Log('PASS: No PrtaskLocalStore IndexedDB database');
    } else {
        Log('FAIL: PrtaskLocalStore IndexedDB still exists');
        Failed = true;
    }

    // ── Summary ─────────────────────────────────────────────────
    Log('');
    Log('=== Test ' + (Failed ? 'FAILED' : 'PASSED') + ' ===');
    await Browser.close();
    process.exit(Failed ? 1 : 0);
})();
