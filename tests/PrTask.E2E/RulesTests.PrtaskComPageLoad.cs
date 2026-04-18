using System.Text.RegularExpressions;

namespace PrTask.E2E;

public partial class RulesTests
{
    private const string PrtaskComUrl = "https://prtask.com/";

    private static readonly string[] KnownStaticPages =
    [
        "en/", "en/About.html", "en/Tasks.html", "en/HowItWorks.html",
        "en/Pricing.html", "en/Download.html", "en/Leaderboard.html",
        "en/Settings.html", "en/Sprints.html", "en/Boards.html", "en/Login.html"
    ];

    [GeneratedRegex("""(?:href|src)="([^"]*\.(css|js)(?:\?[^"]*)?)" """, RegexOptions.IgnoreCase)]
    private static partial Regex PageLoadAssetRefPattern();

    [GeneratedRegex("^[a-z0-9]{6,}$", RegexOptions.IgnoreCase)]
    private static partial Regex FingerprintHashSegmentPattern();

    private static readonly string InitScriptWhiteScreenDetection = string.Join('\n',
        "window.__prtaskLoadChecks = { WhiteScreen: false, FingerprintLink: false };",
        "const Observer = new MutationObserver(() => {",
        "  const Bg = getComputedStyle(document.documentElement).backgroundColor;",
        "  if (Bg === 'rgb(255, 255, 255)' || Bg === 'rgba(0, 0, 0, 0)') {",
        "    window.__prtaskLoadChecks.WhiteScreen = true;",
        "  }",
        "  const Links = document.querySelectorAll('a[href*=\"index.\"]');",
        "  for (const L of Links) {",
        "    if (L.offsetParent !== null && L.href.match(/index\\.[a-z0-9]+\\.html/)) {",
        "      window.__prtaskLoadChecks.FingerprintLink = true;",
        "    }",
        "  }",
        "});",
        "Observer.observe(document.documentElement, { childList: true, subtree: true });");

    private static readonly string JsCountVisibleNavLinks = string.Join('\n',
        "() => {",
        "  const NavItems = document.querySelectorAll('.nav-links a');",
        "  let VisibleCount = 0;",
        "  for (const Item of NavItems) {",
        "    const Rect = Item.getBoundingClientRect();",
        "    if (Rect.width > 0 && Rect.height > 0) VisibleCount++;",
        "  }",
        "  return VisibleCount > 3;",
        "}");

    private static readonly string JsBurgerVisible = string.Join('\n',
        "() => {",
        "  const T = document.querySelector('.nav-toggle, .nav-menu label.nav-toggle');",
        "  if (!T) return false;",
        "  const R = T.getBoundingClientRect();",
        "  return R.width > 0 && R.height > 0;",
        "}");

    [TestMethod]
    [DisplayName("PrTask.com PageLoad: no white background flash on initial load")]
    public async Task PrtaskComNoWhiteScreenFlashAsync()
    {
        var Page = await BrowserContext.NewPageAsync();
        try
        {
            await Page.RouteAsync("**/*", async Route => await Route.ContinueAsync());
            await Page.AddInitScriptAsync(InitScriptWhiteScreenDetection);
            await Page.GotoAsync(PrtaskComUrl, new Microsoft.Playwright.PageGotoOptions
            {
                Timeout = 20000, WaitUntil = Microsoft.Playwright.WaitUntilState.NetworkIdle
            });
            var Checks = await Page.EvaluateAsync<System.Text.Json.JsonElement>("() => window.__prtaskLoadChecks");
            Assert.IsFalse(Checks.GetProperty("WhiteScreen").GetBoolean(),
                "Initial load must NOT flash white background; body/html must have dark bg from the start");
            Assert.IsFalse(Checks.GetProperty("FingerprintLink").GetBoolean(),
                "Initial load must NOT show visible link to fingerprinted HTML (e.g. index.acb3c1fffd.html)");
        }
        finally
        {
            await Page.CloseAsync();
        }
    }

    [TestMethod]
    [DisplayName("PrTask.com PageLoad: burger menu at narrow viewport, full links at wide")]
    public async Task PrtaskComBurgerMenuAtNarrowViewportAsync()
    {
        var Page = await BrowserContext.NewPageAsync();
        try
        {
            await Page.SetViewportSizeAsync(375, 812);
            await Page.GotoAsync(PrtaskComUrl, new Microsoft.Playwright.PageGotoOptions
            {
                Timeout = 20000, WaitUntil = Microsoft.Playwright.WaitUntilState.DOMContentLoaded
            });
            try
            {
                await Page.WaitForLoadStateAsync(Microsoft.Playwright.LoadState.NetworkIdle,
                    new Microsoft.Playwright.PageWaitForLoadStateOptions { Timeout = 15000 });
            }
            catch (TimeoutException) { }
            var NavHeight = await Page.EvaluateAsync<double>(
                "() => document.querySelector('.nav-menu')?.getBoundingClientRect().height ?? 0");
            Assert.IsTrue(NavHeight is > 0 and < 60,
                $"At 375px viewport, nav must be one line (height={NavHeight}px)");
            Assert.IsTrue(await Page.EvaluateAsync<bool>(JsBurgerVisible),
                "Burger/hamburger toggle must be visible at narrow viewport");
            await Page.SetViewportSizeAsync(1920, 1080);
            await Task.Delay(500);
            Assert.IsTrue(await Page.EvaluateAsync<bool>(JsCountVisibleNavLinks),
                "At 1920px viewport, navigation links must be fully visible in header");
        }
        finally
        {
            await Page.CloseAsync();
        }
    }

    [TestMethod]
    [DisplayName("PrTask.com PageLoad: static HTML pages reference fingerprinted asset files")]
    public async Task PrtaskComStaticHtmlLinksToFingerprintedAssetsAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = true,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(30) };
        var MustBeFingerprinted = new[] { "app", "blazor.webassembly", "circuit-manager" };
        var Failures = new List<string>();
        foreach (var PageRoute in KnownStaticPages)
        {
            var (Response, Html) = await GetFollowingMetaRefreshAsync(Client, $"{PrtaskComUrl}{PageRoute}");
            if (!Response.IsSuccessStatusCode)
            {
                continue;
            }
            foreach (var AssetName in MustBeFingerprinted)
            {
                foreach (Match Ref in PageLoadAssetRefPattern().Matches(Html))
                {
                    var Href = Ref.Groups[1].Value;
                    if (!Href.Contains(AssetName, StringComparison.OrdinalIgnoreCase))
                    {
                        continue;
                    }
                    var FileName = Href.Split('/')[^1].Split('?')[0];
                    var Parts = FileName.Split('.');
                    if (Parts.Length < 3 || !FingerprintHashSegmentPattern().IsMatch(Parts[^2]))
                    {
                        var Label = string.IsNullOrEmpty(PageRoute) ? "index" : PageRoute;
                        Failures.Add($"{Label}: {Href} is NOT fingerprinted");
                    }
                }
            }
        }
        Assert.AreEqual(0, Failures.Count,
            $"All asset references in static HTML must be fingerprinted:\n{string.Join("\n", Failures)}");
    }

    [TestMethod]
    [DisplayName("PrTask.com PageLoad: zero browser console errors on fresh load")]
    public async Task PrtaskComZeroBrowserErrorsAsync()
    {
        var Page = await BrowserContext.NewPageAsync();
        try
        {
            var Errors = new List<string>();
            Page.Console += (_, Msg) =>
            {
                if (Msg.Type == "error")
                {
                    Errors.Add($"CONSOLE: {Msg.Text}");
                }
            };
            Page.PageError += (_, Msg) => Errors.Add($"PAGE: {Msg}");
            await Page.GotoAsync(PrtaskComUrl, new Microsoft.Playwright.PageGotoOptions
            {
                Timeout = 20000, WaitUntil = Microsoft.Playwright.WaitUntilState.DOMContentLoaded
            });
            try
            {
                await Page.WaitForLoadStateAsync(Microsoft.Playwright.LoadState.NetworkIdle,
                    new Microsoft.Playwright.PageWaitForLoadStateOptions { Timeout = 15000 });
            }
            catch (TimeoutException) { }
            await Task.Delay(2000);
            var RealErrors = Errors
                .Where(E => !E.Contains("favicon.ico", StringComparison.OrdinalIgnoreCase)
                    && !E.Contains("manifest.json", StringComparison.OrdinalIgnoreCase))
                .ToList();
            Assert.AreEqual(0, RealErrors.Count,
                $"Page must have zero browser errors on fresh load:\n{string.Join("\n", RealErrors)}");
        }
        finally
        {
            await Page.CloseAsync();
        }
    }

    [TestMethod]
    [DisplayName("PrTask.com PageLoad: no /Api/Auth/Me request on initial unauthenticated load")]
    public async Task PrtaskComNoAuthMeOnInitialLoadAsync()
    {
        var Page = await BrowserContext.NewPageAsync();
        try
        {
            var AuthMeRequests = new List<string>();
            Page.Request += (_, Request) =>
            {
                if (Request.Url.Contains("/Api/Auth/Me", StringComparison.OrdinalIgnoreCase))
                {
                    AuthMeRequests.Add($"{Request.Method} {Request.Url}");
                }
            };
            await Page.GotoAsync(PrtaskComUrl, new Microsoft.Playwright.PageGotoOptions
            {
                Timeout = 20000, WaitUntil = Microsoft.Playwright.WaitUntilState.DOMContentLoaded
            });
            try
            {
                await Page.WaitForLoadStateAsync(Microsoft.Playwright.LoadState.NetworkIdle,
                    new Microsoft.Playwright.PageWaitForLoadStateOptions { Timeout = 15000 });
            }
            catch (TimeoutException) { }
            await Task.Delay(2000);
            Assert.AreEqual(0, AuthMeRequests.Count,
                $"Initial load must NOT call /Api/Auth/Me, found {AuthMeRequests.Count} request(s):\n{string.Join("\n", AuthMeRequests)}");
        }
        finally
        {
            await Page.CloseAsync();
        }
    }
}
