using System.Text.RegularExpressions;
using PrTask.Cdp;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions;
namespace PrTask.E2E;

public partial class RulesTests
{
    private const string GhPagesBaseUrl = "https://cruzlauroiii.github.io/prtask.com/";

    [GeneratedRegex(@"url=([^""]+)""")]
    private static partial Regex MetaRefreshUrlPattern();

    [GeneratedRegex(@"url=([^""]+)""")]
    private static partial Regex MetaRefreshUrlPattern();

    [GeneratedRegex(@"url=([^""]+)""")]
    private static partial Regex MetaRefreshUrlPattern();

    [GeneratedRegex(@"url=([^""]+)""")]
    private static partial Regex MetaRefreshUrlPattern();

    [GeneratedRegex(@"url=([^""]+)""")]
    private static partial Regex MetaRefreshUrlPattern();

    [GeneratedRegex(@"url=([^""]+)""")]
    private static partial Regex MetaRefreshUrlPattern();

    private static readonly string[] GhPagesRoutes =
    [
        string.Empty, "About.html", "Tasks.html", "HowItWorks.html",
        "Pricing.html", "Download.html", "Leaderboard.html", "Login.html"
    ];

    private static readonly string[] IgnoredGhPagesErrors =
    [
        "favicon.ico", "service-worker", "manifest.json",
        "Failed to register a ServiceWorker",
        "Failed to load resource",
        "appsettings.json",
        "MONO_WASM",
        "mono_download_assets",
        "Failed to start platform"
    ];

    private static bool IsIgnoredGhPagesError(string Error) =>
        IgnoredGhPagesErrors.Any(P => Error.Contains(P, StringComparison.OrdinalIgnoreCase));

    [TestMethod]
    [DisplayName("GitHubPages: index.html loads with no 404 errors")]
    public async Task GhPagesIndexNoErrorsAsync()
    {
        var Errors = new List<string>();
        CdpConsole.OnRuntimeConsoleApiCalled(CdpHelpers.GetTransport(BrowserPage), Call =>
        {
            if (Call.Type == "error" && !IsIgnoredGhPagesError(string.Join(" ", Call.Args)))
            {
                Errors.Add(string.Join(" ", Call.Args));
            }
        });
        CdpConsole.OnRuntimeExceptionThrown(CdpHelpers.GetTransport(BrowserPage), Ex =>
        {
            if (!IsIgnoredGhPagesError(Ex.Text))
            {
                Errors.Add(Ex.Text);
            }
        });

        await BrowserPage.NavigateAsync(GhPagesBaseUrl);

        await Task.Delay(500);

        await Task.Delay(2000);

        Assert.AreEqual(0, Errors.Count,
            $"Index must have zero console errors, got {Errors.Count}:\n{string.Join("\n", Errors)}");

        await TakeScreenshotAsync("gh-pages-index-no-errors.png");
    }

    [TestMethod]
    [DisplayName("GitHubPages: all static assets return 200")]
    public async Task GhPagesAssetsReturn200Async()
    {
#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = true,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(15) };

        var Assets = new[]
        {
            "icon-192.png"
        };

        var Failures = new List<string>();
        var FingerprintedAssets = await DiscoverFingerprintedAssetsAsync(Client, GhPagesBaseUrl);
        var AllAssets = (string[])[.. Assets, .. FingerprintedAssets];
        foreach (var Asset in AllAssets)
        {
            var Url = $"{GhPagesBaseUrl}{Asset}";
            var Response = await Client.GetAsync(Url);
            if (!Response.IsSuccessStatusCode)
            {
                Failures.Add($"{Asset} => {(int)Response.StatusCode}");
            }
        }

        Assert.AreEqual(0, Failures.Count,
            $"All assets must return 200, failures:\n{string.Join("\n", Failures)}");
    }

    [TestMethod]
    [DisplayName("GitHubPages: base href is /prtask.com/")]
    public async Task GhPagesBaseHrefCorrectAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = true,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(15) };

        var Response = await Client.GetAsync(GhPagesBaseUrl);
        Assert.IsTrue(Response.IsSuccessStatusCode, $"Index must return 2xx, got {(int)Response.StatusCode}");

        var Html = await Response.Content.ReadAsStringAsync();
        var RefreshMatch = MetaRefreshUrlPattern().Match(Html);
        if (RefreshMatch.Success)
        {
            var FpResponse = await Client.GetAsync($"{GhPagesBaseUrl}{RefreshMatch.Groups[1].Value}");
            Assert.IsTrue(FpResponse.IsSuccessStatusCode, "Fingerprinted index must return 2xx");
            Html = await FpResponse.Content.ReadAsStringAsync();
        }
        Assert.IsTrue(Html.Contains("base href=\"/prtask.com/\""),
            "index.html must have <base href=\"/prtask.com/\">");
        Assert.IsFalse(Html.Contains("base href=\"/\">"),
            "index.html must NOT have <base href=\"/\">");
    }

    [TestMethod]
    [DisplayName("GitHubPages: prerendered pages return 200")]
    public async Task GhPagesPrerenderReturn200Async()
    {
#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = true,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(15) };

        var Pages = new[] { "About.html", "Tasks.html", "HowItWorks.html", "Pricing.html", "Settings.html" };
        var Failures = new List<string>();

        foreach (var PageName in Pages)
        {
            var Response = await Client.GetAsync($"{GhPagesBaseUrl}{PageName}");
            if (!Response.IsSuccessStatusCode)
            {
                Failures.Add($"{PageName} => {(int)Response.StatusCode}");
                continue;
            }
            var Html = await Response.Content.ReadAsStringAsync();
            if (!Html.Contains("nav-menu"))
            {
                Failures.Add($"{PageName} missing static nav");
            }
            if (!Html.Contains("site-footer"))
            {
                Failures.Add($"{PageName} missing static footer");
            }
        }

        Assert.AreEqual(0, Failures.Count,
            $"All pages must return 200 with nav/footer:\n{string.Join("\n", Failures)}");
    }
}
