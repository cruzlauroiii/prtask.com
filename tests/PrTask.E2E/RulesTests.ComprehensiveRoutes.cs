using System.Text.RegularExpressions;
using Microsoft.Playwright;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    private static readonly string[] AllExpectedRoutes =
    [
        "/en/", "/en/Tasks", "/en/Leaderboard", "/en/HowItWorks", "/en/Pricing",
        "/en/About", "/en/Dashboard", "/en/Login", "/en/Download", "/en/Settings",
        "/en/Sprints", "/en/Boards",
        "/en/Client/CreateTask", "/en/Client/Payments", "/en/Client/Repository",
        "/en/Legal/Terms", "/en/Legal/Privacy", "/en/Legal/CookiePolicy",
        "/en/Legal/AcceptableUse", "/en/Legal/Refund", "/en/Legal/Licenses",
        "/en/Legal/Accessibility", "/en/Legal/Dmca",
    ];

    [TestMethod]
    [Timeout(600000)]
    [DisplayName("Req1: every expected route returns 200 on prtask.com")]
    public async Task EveryRouteReturns200OnPrtaskComAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = true,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(30) };
        var Failures = new List<string>();
        foreach (var Route in AllExpectedRoutes)
        {
            var Url = $"https://{AppConstants.AppDomain}{Route}";
            var Response = await Client.GetAsync(Url);
            if (!Response.IsSuccessStatusCode)
            {
                Failures.Add($"{Route} => {(int)Response.StatusCode}");
            }
        }

        Assert.AreEqual(0, Failures.Count,
            $"Routes returning non-200 on prtask.com:\n{string.Join("\n", Failures)}");
    }

    [TestMethod]
    [Timeout(600000)]
    [DisplayName("Req1: every expected route returns 200 on GH Pages")]
    public async Task EveryRouteReturns200OnGhPagesAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = true,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(30) };
        var Failures = new List<string>();
        foreach (var Route in AllExpectedRoutes)
        {
            var RelPath = Route == "/en/" ? "en/" : Route.TrimStart('/');
            var Url = $"{GhPagesRoot}{RelPath}";
            var Response = await Client.GetAsync(Url);
            if (!Response.IsSuccessStatusCode)
            {
                Failures.Add($"{Route} => {(int)Response.StatusCode} ({Url})");
            }
        }

        Assert.AreEqual(0, Failures.Count,
            $"Routes returning non-200 on GH Pages:\n{string.Join("\n", Failures)}");
    }

    [TestMethod]
    [Timeout(600000)]
    [DisplayName("Req1: all nav/footer links from / are fingerprinted .html")]
    public async Task AllLinksFromHomeAreFingerprintedAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = true,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(30) };
        var Response = await Client.GetAsync($"https://{AppConstants.AppDomain}/en/");
        var Html = await Response.Content.ReadAsStringAsync();
        var FpLinks = FingerprintedLinkRegex().Matches(Html)
            .Select(M => M.Groups[1].Value)
            .Distinct()
            .ToList();
        Assert.IsTrue(FpLinks.Count >= 10,
            $"Home must have at least 10 fingerprinted links, got {FpLinks.Count}");
        var Failures = new List<string>();
        foreach (var Link in FpLinks)
        {
            var Url = Link.Contains("://") ? Link : $"https://{AppConstants.AppDomain}/{Link}";
            var LnkResponse = await Client.GetAsync(Url);
            if (!LnkResponse.IsSuccessStatusCode)
            {
                Failures.Add($"{Link} -> {(int)LnkResponse.StatusCode}");
            }
        }

        Assert.AreEqual(0, Failures.Count,
            $"Fingerprinted links 404:\n{string.Join("\n", Failures)}");
    }

    [TestMethod]
    [Timeout(600000)]
    [DisplayName("Req1: Playwright click every nav link from / — no 404")]
    public async Task ClickEveryNavLinkFromHomeAsync()
    {
        var Context = await Browser.NewContextAsync(new BrowserNewContextOptions
        {
            ViewportSize = new ViewportSize { Width = 1280, Height = 720 },
            IgnoreHTTPSErrors = true,
        });
        var Page = await Context.NewPageAsync();
        try
        {
            await Page.GotoAsync(TestBaseUrl,
                new PageGotoOptions { WaitUntil = WaitUntilState.DOMContentLoaded });
            var NavLinks = await Page.EvaluateAsync<string[]>(
                "() => [...new Set([...document.querySelectorAll('.nav-links a, .footer-links a')].map(a => a.href).filter(h => h && !h.includes('/Api')))]");
            var Failures = new List<string>();
            foreach (var Href in NavLinks)
            {
                var Resp = await Page.GotoAsync(Href,
                    new PageGotoOptions { Timeout = 15000, WaitUntil = WaitUntilState.DOMContentLoaded });
                if (Resp is null || (!Resp.Ok && Resp.Status != 304))
                {
                    Failures.Add($"{Href} => {Resp?.Status ?? 0}");
                }
            }

            Assert.AreEqual(0, Failures.Count,
                $"Nav/footer links from / returning errors:\n{string.Join("\n", Failures)}");
        }
        finally
        {
            await Page.CloseAsync();
            await Context.DisposeAsync();
        }
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Req1: static HTML has no WASM or JS when JavaScriptEnabled=false")]
    public async Task StaticHtmlNoWasmWhenJsDisabledAsync()
    {
#pragma warning disable CS0162
        if (AppConstants.JavaScriptEnabled)
        {
            return;
        }
#pragma warning restore CS0162

#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = true,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(30) };
        var Failures = new List<string>();
        foreach (var Route in AllExpectedRoutes)
        {
            var Url = $"{TestBaseUrl}{Route}";
            var Response = await Client.GetAsync(Url);
            if (!Response.IsSuccessStatusCode)
            {
                continue;
            }

            var Html = await Response.Content.ReadAsStringAsync();
            if (Html.Contains("<script src=") || Html.Contains("<script defer"))
            {
                Failures.Add($"{Route} has external script tags when JavaScriptEnabled=false");
            }

            if (Html.Contains("blazor.webassembly"))
            {
                Failures.Add($"{Route} references Blazor WASM when JavaScriptEnabled=false");
            }

            if (Html.Contains("_framework/"))
            {
                Failures.Add($"{Route} references _framework/ when JavaScriptEnabled=false");
            }
        }

        Assert.AreEqual(0, Failures.Count,
            $"JS/WASM found:\n{string.Join("\n", Failures)}");
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Req5: links use relative paths that work on any base URL")]
    public async Task LinksAreRelativeNotAbsoluteAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = true,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(30) };
        var Response = await Client.GetAsync($"https://{AppConstants.AppDomain}/en/");
        var Html = await Response.Content.ReadAsStringAsync();
        var NavStart = Html.IndexOf("<nav", StringComparison.Ordinal);
        var NavEnd = Html.IndexOf("</nav>", StringComparison.Ordinal);
        if (NavStart >= 0 && NavEnd > NavStart)
        {
            var NavHtml = Html[NavStart..NavEnd];
            Assert.IsFalse(
                NavHtml.Contains("href=\"/Tasks\"") || NavHtml.Contains("href=\"/About\""),
                "Nav links must be relative (no leading slash), e.g. href=\"Tasks\" not href=\"/Tasks\"");
        }
    }
}
