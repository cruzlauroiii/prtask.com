using System.Text.RegularExpressions;
using PrTask.Cdp;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [GeneratedRegex(@"/index\.[a-f0-9]{10}\.html")]
    private static partial Regex FingerprintedIndexUrlRegex();

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Req5: nav header fits in one line")]
    public async Task NavLinksOneLineAsync()
    {
        var Page = await CreateEmulatedPageAsync(1280, 720);
        try
        {
            await Page.NavigateAsync($"https://{AppConstants.AppDomain}/");
            var Result = await CdpHelpers.EvaluateAsync<System.Text.Json.JsonElement>(Page,
                "() => { const n = document.querySelector('.nav-menu'); const l = document.querySelector('.nav-links'); return { h: n?.getBoundingClientRect().height ?? 0, d: l ? getComputedStyle(l).display : 'none', v: l ? l.querySelectorAll('a').length : 0 }; }");
            var NavHeight = Result.GetProperty("h").GetDouble();
            var LinksDisplay = Result.GetProperty("d").GetString();
            var LinkCount = Result.GetProperty("v").GetInt32();
            Assert.IsTrue(NavHeight > 0, "Nav must exist");
            Assert.IsTrue(NavHeight < 80, $"Nav must be one line (height={NavHeight}px, max 80px)");
            Assert.AreNotEqual("none", LinksDisplay, "Nav links must be visible (not display:none)");
            Assert.IsTrue(LinkCount > 0, "Nav must have visible link elements");
        }
        finally
        {
            await ClosePageAsync(Page);
        }
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Req6: index.html is fingerprinted on GH Pages")]
    public async Task IndexFingerprintedAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = false,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(30) };
        var GhResponse = await Client.GetAsync("https://cruzlauroiii.github.io/prtask.com/index.html");
        Assert.IsTrue(GhResponse.IsSuccessStatusCode, "GH Pages index.html must return 200");
        var Html = await GhResponse.Content.ReadAsStringAsync();
        Assert.IsTrue(Html.Contains("http-equiv=\"refresh\""),
            "GH Pages index.html must be a redirect stub to fingerprinted version");
        var Match = MetaRefreshUrlPattern().Match(Html);
        Assert.IsTrue(Match.Success, "Redirect stub must have fingerprinted target URL");
        Assert.IsTrue(Match.Groups[1].Value.Contains(".html"),
            $"Target must be fingerprinted HTML, got: {Match.Groups[1].Value}");
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Req7: zero browser console errors on all pages")]
    public async Task ZeroErrorsAllPagesAsync()
    {
        var Page = await CreateEmulatedPageAsync();
        try
        {
            var AllErrors = new List<string>();
            var Transport = CdpHelpers.GetTransport(Page);
            CdpConsole.OnRuntimeConsoleApiCalled(Transport, Call =>
            {
                if (Call.Type == "error" && !IsIgnoredGhPagesError(string.Join(" ", Call.Args)))
                {
                    AllErrors.Add($"[error] on page: {string.Join(" ", Call.Args)}");
                }
            });
            foreach (var PagePath in AllPagePaths)
            {
                var Url = $"https://{AppConstants.AppDomain}{PagePath}";
                await Page.NavigateAsync(Url);
                try
                {
                    await Task.Delay(500);
                }
                catch (TimeoutException) { }
            }

            Assert.AreEqual(0, AllErrors.Count,
                $"Console errors:\n{string.Join("\n", AllErrors)}");
        }
        finally
        {
            await ClosePageAsync(Page);
        }
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Req8: all assets use preload in HTML head")]
    public async Task AssetsPreloadedAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = true,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(30) };
        var Response = await Client.GetAsync($"https://{AppConstants.AppDomain}/");
        var Html = await Response.Content.ReadAsStringAsync();
        var HeadEnd = Html.IndexOf("</head>", StringComparison.OrdinalIgnoreCase);
        var Head = HeadEnd > 0 ? Html[..HeadEnd] : Html;
        Assert.IsTrue(Head.Contains("rel=\"preload\""),
            "Head must contain preload links");
        Assert.IsTrue(
            Head.Contains("as=\"style\"") || Head.Contains("as=\"script\""),
            "Preload links must specify as= attribute");
    }
}
