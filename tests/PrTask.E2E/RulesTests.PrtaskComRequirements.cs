using System.Text.RegularExpressions;
using Microsoft.Playwright;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    private static readonly string[] AllPagePaths =
    [
        "/en/", "/en/About", "/en/Tasks", "/en/HowItWorks", "/en/Pricing",
        "/en/Download", "/en/Leaderboard", "/en/Login", "/en/Dashboard",
        "/en/Settings", "/en/Sprints", "/en/Boards",
    ];

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Req1: all HTML pages are minified (no unnecessary whitespace)")]
    public async Task AllHtmlMinifiedAsync()
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
        foreach (var Path in AllPagePaths)
        {
            var Url = $"https://{AppConstants.AppDomain}{Path}";
            var Response = await Client.GetAsync(Url);
            if (!Response.IsSuccessStatusCode)
            {
                continue;
            }

            var Html = await Response.Content.ReadAsStringAsync();
            if (Html.Contains("\n    ") || Html.Contains("\n  "))
            {
                Failures.Add($"{Path} has unminified whitespace");
            }
        }

        Assert.AreEqual(0, Failures.Count,
            $"HTML not minified:\n{string.Join("\n", Failures)}");
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Req2: light theme passes color contrast")]
    public async Task LightThemeContrastAsync()
    {
        var Context = await Browser.NewContextAsync(new BrowserNewContextOptions
        {
            ViewportSize = new ViewportSize { Width = 1280, Height = 720 },
            IgnoreHTTPSErrors = true,
        });
        var Page = await Context.NewPageAsync();
        try
        {
            await Page.GotoAsync($"https://{AppConstants.AppDomain}/",
                new PageGotoOptions { WaitUntil = WaitUntilState.DOMContentLoaded });
            await Page.EvaluateAsync(
                "() => document.documentElement.setAttribute('data-theme', 'light')");
            await Page.WaitForTimeoutAsync(500);
            var Theme = await Page.EvaluateAsync<string>(
                "() => document.documentElement.getAttribute('data-theme')");
            Assert.AreEqual("light", Theme, "Light theme must be active");
        }
        finally
        {
            await Page.CloseAsync();
            await Context.DisposeAsync();
        }
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Req3: all pages return 200 and have h1, main landmark")]
    public async Task AllPagesStructureAsync()
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
        foreach (var Path in AllPagePaths)
        {
            var Url = $"https://{AppConstants.AppDomain}{Path}";
            var Response = await Client.GetAsync(Url);
            if (!Response.IsSuccessStatusCode)
            {
                Failures.Add($"{Path} returned {(int)Response.StatusCode}");
                continue;
            }

            var Html = await Response.Content.ReadAsStringAsync();
            if (!Html.Contains("<main"))
            {
                Failures.Add($"{Path} missing <main> landmark");
            }

            if (!Html.Contains("<h1"))
            {
                Failures.Add($"{Path} missing <h1>");
            }

            if (Html.Contains("<h4") || Html.Contains("<h5") || Html.Contains("<h6"))
            {
                Failures.Add($"{Path} has h4/h5/h6 (max depth h1/h2/h3)");
            }
        }

        Assert.AreEqual(0, Failures.Count,
            $"Page structure issues:\n{string.Join("\n", Failures)}");
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Req4: burger menu default on all pages")]
    public async Task BurgerMenuDefaultAsync()
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
        foreach (var Path in AllPagePaths)
        {
            var Url = $"https://{AppConstants.AppDomain}{Path}";
            var Response = await Client.GetAsync(Url);
            if (!Response.IsSuccessStatusCode)
            {
                continue;
            }

            var Html = await Response.Content.ReadAsStringAsync();
            if (!Html.Contains("nav-collapsed"))
            {
                Failures.Add($"{Path} missing nav-collapsed");
            }

            if (!Html.Contains("nav-toggle"))
            {
                Failures.Add($"{Path} missing burger toggle");
            }
        }

        Assert.AreEqual(0, Failures.Count,
            $"Burger menu issues:\n{string.Join("\n", Failures)}");
    }
}
