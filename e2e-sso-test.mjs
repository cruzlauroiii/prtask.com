import { chromium } from '@playwright/test';
import { mkdirSync, writeFileSync, appendFileSync } from 'fs';

var LiveSiteUrl = 'https://prtask.com';
var OutputDir = 'output/screenshots';
var LogPath = 'output/e2e-sso-debug.log';

var AllProviders = [
    { Name: 'Google',    Css: '.google-login',  Domain: 'accounts.google.com',         Href: '/Api/Auth/Google' },
    { Name: 'GitHub',    Css: '.github-login',   Domain: 'github.com',                  Href: '/Api/Auth/GitHub' },
    { Name: 'Microsoft', Css: '.azure-login',    Domain: 'login.microsoftonline.com',   Href: '/Api/Auth/Azure' },
    { Name: 'Okta',      Css: '.okta-login',     Domain: 'okta.com',                    Href: '/Api/Auth/Okta' },
];

// Usage: node e2e-sso-test.mjs [provider]  e.g. node e2e-sso-test.mjs okta
var FilterArg = (process.argv[2] || '').toLowerCase();
var Providers = FilterArg
    ? AllProviders.filter(function (P) { return P.Name.toLowerCase() === FilterArg; })
    : AllProviders;

if (FilterArg && Providers.length === 0) {
    console.log('Unknown provider: ' + FilterArg + '. Available: ' + AllProviders.map(function (P) { return P.Name; }).join(', '));
    process.exit(1);
}

mkdirSync('output/screenshots', { recursive: true });
writeFileSync(LogPath, '=== SSO E2E Test (All Providers) — ' + new Date().toISOString() + ' ===\n\n');

function Log(Msg) {
    var Line = '[' + new Date().toISOString() + '] ' + Msg + '\n';
    appendFileSync(LogPath, Line);
    console.log(Msg);
}

async function Screenshot(Page, Name) {
    await Page.screenshot({ path: OutputDir + '/' + Name, fullPage: true });
    Log('Screenshot: ' + Name);
}

function Slug(Name) { return Name.toLowerCase().replace(/\s+/g, '-'); }

(async () => {
    Log('Launching browser (non-headless)...');
    var Browser = await chromium.launch({
        headless: false,
        channel: 'chrome',
        args: ['--start-maximized', '--disable-blink-features=AutomationControlled', '--disable-quic']
    });

    var Context = await Browser.newContext({ viewport: null, ignoreHTTPSErrors: true });
    var Page = await Context.newPage();
    var Failed = false;
    var CompletedProviders = [];

    // ════════════════════════════════════════════════════════════
    // PHASE 1: Verify all SSO buttons exist and redirect correctly
    // ════════════════════════════════════════════════════════════
    Log('');
    Log('══ PHASE 1: Verify SSO buttons and OAuth redirects ══');

    for (var I = 0; I < Providers.length; I++) {
        var P = Providers[I];
        var S = Slug(P.Name);
        Log('');
        Log('── ' + P.Name + ' ──');

        await Page.goto(LiveSiteUrl + '/Login', { waitUntil: 'networkidle', timeout: 30000 });

        var Btn = Page.locator(P.Css);
        var BtnCount = await Btn.count();
        if (BtnCount === 0) {
            Log('FAIL: ' + P.Name + ' button not found');
            Failed = true;
            continue;
        }
        Log('PASS: ' + P.Name + ' button exists');

        var BtnHref = await Btn.getAttribute('href') || '';
        if (BtnHref === P.Href) {
            Log('PASS: ' + P.Name + ' href = ' + BtnHref);
        } else {
            Log('FAIL: ' + P.Name + ' href = "' + BtnHref + '", expected "' + P.Href + '"');
            Failed = true;
        }

        // Click and check redirect
        await Btn.click();
        await Page.waitForLoadState('networkidle', { timeout: 30000 }).catch(function () {});
        var Url = Page.url();
        Log('After click URL: ' + Url);
        await Screenshot(Page, 'phase1-' + S + '-redirect.png');

        var Host = '';
        try { Host = new URL(Url).host; } catch (E) { Host = ''; }

        if (P.Domain && Host.includes(P.Domain)) {
            Log('PASS: ' + P.Name + ' redirected to ' + P.Domain);
        } else if (!P.Domain) {
            // Okta domain is environment-specific — just check it left prtask.com
            if (!Host.includes('prtask.com')) {
                Log('PASS: ' + P.Name + ' redirected away from prtask.com to ' + Host);
            } else {
                var Params = new URL(Url).searchParams;
                var ErrParam = Params.get('error') || '';
                if (ErrParam) {
                    Log('WARN: ' + P.Name + ' returned error: ' + ErrParam + ' (Okta may not be configured)');
                } else {
                    Log('FAIL: ' + P.Name + ' did not redirect — still on prtask.com');
                    Failed = true;
                }
            }
        } else if (Host.includes('prtask.com')) {
            var Params2 = new URL(Url).searchParams;
            var Err = Params2.get('error') || Params2.get('auto_failed') || '';
            if (Err) {
                Log('WARN: ' + P.Name + ' OAuth error: ' + Err + ' (credentials may not be configured)');
            } else {
                Log('FAIL: ' + P.Name + ' did not redirect to ' + P.Domain);
                Failed = true;
            }
        } else {
            Log('INFO: ' + P.Name + ' redirected to unexpected host: ' + Host);
        }
    }

    // ════════════════════════════════════════════════════════════
    // PHASE 2: Full login flow for each provider (manual)
    // ════════════════════════════════════════════════════════════
    Log('');
    Log('══ PHASE 2: Full login flow for each provider ══');
    Log('You will log in with each provider. 5 min timeout per provider.');

    for (var J = 0; J < Providers.length; J++) {
        var Prov = Providers[J];
        var Sl = Slug(Prov.Name);

        // Skip Okta if domain not configured
        if (Prov.Name === 'Okta' && !Prov.Domain) {
            Log('');
            Log('── ' + Prov.Name + ' (SKIP — domain not configured) ──');
            continue;
        }

        Log('');
        Log('── ' + Prov.Name + ' Full Login ──');

        // Sign out first if we have a session
        var ExistingUser = await Page.evaluate(function () { return localStorage.getItem('prtask-user') || ''; });
        if (ExistingUser) {
            Log('Signing out previous session (' + ExistingUser + ')...');
            await Page.evaluate(function () {
                localStorage.removeItem('prtask-user');
                localStorage.removeItem('prtask-userid');
                localStorage.removeItem('prtask-profile');
            });
            await Page.evaluate(function () {
                return fetch('/Api/Auth/Logout', { method: 'POST', credentials: 'include' }).catch(function () {});
            });
            // Clear cookies
            await Context.clearCookies();
        }

        // Navigate to login and click provider
        await Page.goto(LiveSiteUrl + '/Login', { waitUntil: 'networkidle', timeout: 30000 });
        var ProvBtn = Page.locator(Prov.Css);
        if (await ProvBtn.count() === 0) {
            Log('FAIL: ' + Prov.Name + ' button not found');
            Failed = true;
            continue;
        }

        await ProvBtn.click();
        await Page.waitForLoadState('networkidle', { timeout: 30000 }).catch(function () {});

        var ProvUrl = Page.url();
        var ProvHost = '';
        try { ProvHost = new URL(ProvUrl).host; } catch (E) {}

        // Check if we actually got to the provider
        if (ProvHost.includes('prtask.com')) {
            Log('WARN: ' + Prov.Name + ' did not redirect to OAuth page — skipping login');
            continue;
        }

        await Screenshot(Page, 'phase2-' + Sl + '-oauth.png');
        Log('>>> Please log in with ' + Prov.Name + ' in the browser window <<<');

        try {
            await Page.waitForURL(
                function (U) { try { return new URL(U).host.includes('prtask.com'); } catch (E) { return false; } },
                { timeout: 300000 }
            );
            await Page.waitForLoadState('networkidle', { timeout: 30000 });
        } catch (E) {
            Log('FAIL: Timeout waiting for ' + Prov.Name + ' login');
            await Screenshot(Page, 'phase2-' + Sl + '-timeout.png');
            Failed = true;
            continue;
        }

        Log('Redirected to: ' + Page.url());
        await Screenshot(Page, 'phase2-' + Sl + '-callback.png');
        await Page.waitForTimeout(3000);

        // Verify session
        var Cookies = await Context.cookies(LiveSiteUrl);
        var Sess = Cookies.find(function (C) { return C.name === 'session'; });
        if (Sess) {
            Log('PASS: ' + Prov.Name + ' session cookie set');
        } else {
            Log('FAIL: ' + Prov.Name + ' session cookie missing');
            Failed = true;
        }

        // Verify Auth/Me
        var Me = await Page.evaluate(function () {
            return fetch('/Api/Auth/Me', { credentials: 'include' })
                .then(function (R) { return R.json(); })
                .catch(function (E) { return { error: E.message }; });
        });
        var MeUser = Me.username || Me.Username || '';
        var MeProvider = Me.provider || Me.Provider || '';
        Log('/Api/Auth/Me: username=' + MeUser + ' provider=' + MeProvider);

        if (MeUser) {
            Log('PASS: ' + Prov.Name + ' Auth/Me returned username');
        } else {
            Log('FAIL: ' + Prov.Name + ' Auth/Me did not return username');
            Failed = true;
        }

        // Verify localStorage
        var StoredUser = await Page.evaluate(function () { return localStorage.getItem('prtask-user') || ''; });
        var StoredId = await Page.evaluate(function () { return localStorage.getItem('prtask-userid') || ''; });
        Log('localStorage: user=' + StoredUser + ' userid=' + StoredId);

        if (StoredUser && StoredId) {
            Log('PASS: ' + Prov.Name + ' localStorage populated');
        } else {
            Log('FAIL: ' + Prov.Name + ' localStorage empty');
            Failed = true;
        }

        // Verify nav shows username
        await Page.waitForTimeout(5000);
        var Toggle = Page.locator('.nav-toggle');
        if (await Toggle.count() > 0 && await Toggle.isVisible()) {
            await Toggle.click();
            await Page.waitForTimeout(1000);
        }

        var NavUser = Page.locator('.nav-user');
        if (await NavUser.count() > 0) {
            var NavText = await NavUser.first().textContent() || '';
            Log('PASS: ' + Prov.Name + ' nav shows: ' + NavText);
        } else {
            Log('FAIL: ' + Prov.Name + ' nav-user not found');
            Failed = true;
        }

        var SignOut = Page.locator('.nav-login', { hasText: 'Sign Out' });
        if (await SignOut.count() > 0) {
            Log('PASS: ' + Prov.Name + ' Sign Out visible');
        } else {
            Log('FAIL: ' + Prov.Name + ' Sign Out not visible');
            Failed = true;
        }

        await Screenshot(Page, 'phase2-' + Sl + '-nav.png');

        // Navigate to Settings and check connected status
        await Page.goto(LiveSiteUrl + '/Settings', { waitUntil: 'networkidle', timeout: 30000 });
        await Page.waitForTimeout(5000);
        await Page.reload({ waitUntil: 'networkidle', timeout: 30000 });
        await Page.waitForTimeout(8000);

        var Statuses = Page.locator('.connected-status');
        var StatCount = await Statuses.count();
        var ProvConnected = false;

        for (var K = 0; K < StatCount; K++) {
            var El = Statuses.nth(K);
            var ElText = (await El.textContent() || '').trim();
            var ElClass = (await El.getAttribute('class') || '').trim();
            var ElLabel = '';
            try {
                var Parent = El.locator('xpath=..');
                var Lbl = Parent.locator('label');
                ElLabel = (await Lbl.textContent() || '').trim();
            } catch (E) {}

            Log('  Status[' + K + ']: label="' + ElLabel + '" text="' + ElText + '" class="' + ElClass + '"');

            if (ElText === 'Connected' && ElClass.includes('status-connected')) {
                if (ElLabel.toLowerCase().includes(Prov.Name.toLowerCase()) ||
                    (Prov.Name === 'Microsoft' && ElLabel.toLowerCase().includes('microsoft'))) {
                    ProvConnected = true;
                }
            }
        }

        await Screenshot(Page, 'phase2-' + Sl + '-settings.png');

        // Map provider name to settings label
        var SettingsLabel = Prov.Name;
        if (ProvConnected) {
            Log('PASS: ' + SettingsLabel + ' shows Connected on Settings');
        } else {
            Log('FAIL: ' + SettingsLabel + ' does NOT show Connected on Settings');
            Failed = true;
        }

        CompletedProviders.push(Prov.Name);

        // Verify profile fields
        var DnInput = Page.locator('#DisplayName');
        if (await DnInput.count() > 0) {
            var DnVal = await DnInput.inputValue();
            Log('DisplayName: ' + (DnVal || '(empty)'));
        }
        var EmInput = Page.locator('#Email');
        if (await EmInput.count() > 0) {
            var EmVal = await EmInput.inputValue();
            Log('Email: ' + (EmVal || '(empty)'));
        }
    }

    // ════════════════════════════════════════════════════════════
    // PHASE 3: Sign out and verify cleanup
    // ════════════════════════════════════════════════════════════
    Log('');
    Log('══ PHASE 3: Sign out and verify ══');

    await Page.goto(LiveSiteUrl + '/Dashboard', { waitUntil: 'networkidle', timeout: 30000 });
    await Page.waitForTimeout(3000);

    var Toggle2 = Page.locator('.nav-toggle');
    if (await Toggle2.count() > 0 && await Toggle2.isVisible()) {
        await Toggle2.click();
        await Page.waitForTimeout(1000);
    }

    var SignOutFinal = Page.locator('.nav-login', { hasText: 'Sign Out' });
    if (await SignOutFinal.count() > 0 && await SignOutFinal.isVisible()) {
        await SignOutFinal.click();
        await Page.waitForLoadState('networkidle', { timeout: 30000 }).catch(function () {});
        await Page.waitForTimeout(3000);
        Log('After sign out URL: ' + Page.url());
        await Screenshot(Page, 'phase3-signout.png');

        var UAfter = await Page.evaluate(function () { return localStorage.getItem('prtask-user') || '(null)'; });
        var IdAfter = await Page.evaluate(function () { return localStorage.getItem('prtask-userid') || '(null)'; });
        var PrAfter = await Page.evaluate(function () { return localStorage.getItem('prtask-profile') || '(null)'; });

        if (UAfter === '(null)' && IdAfter === '(null)' && PrAfter === '(null)') {
            Log('PASS: All localStorage cleared after sign out');
        } else {
            Log('FAIL: localStorage not fully cleared: user=' + UAfter + ' userid=' + IdAfter);
            Failed = true;
        }

        var CookiesAfter = await Context.cookies(LiveSiteUrl);
        var SessAfter = CookiesAfter.find(function (C) { return C.name === 'session'; });
        if (!SessAfter || SessAfter.value === '') {
            Log('PASS: Session cookie cleared');
        } else {
            Log('FAIL: Session cookie still exists');
            Failed = true;
        }
    } else {
        Log('WARN: Sign Out button not visible — may already be signed out');
    }

    // ════════════════════════════════════════════════════════════
    // Summary
    // ════════════════════════════════════════════════════════════
    Log('');
    Log('══ Summary ══');
    Log('Providers tested (full login): ' + (CompletedProviders.length > 0 ? CompletedProviders.join(', ') : 'none'));
    Log('');
    Log('=== Test ' + (Failed ? 'FAILED' : 'PASSED') + ' ===');

    await Browser.close();
    process.exit(Failed ? 1 : 0);
})();
