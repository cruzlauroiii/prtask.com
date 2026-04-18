using System.Text.RegularExpressions;
using Microsoft.Playwright;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    private static readonly string[] PrerenderedRoutes =
    [
        "/", "/About", "/Tasks", "/HowItWorks", "/Pricing",
        "/Download", "/Leaderboard", "/Login", "/Dashboard",
        "/Settings", "/Sprints", "/Boards",
    ];

    private static readonly string[] LegalRoutes =
    [
        "/Legal/Terms", "/Legal/Privacy", "/Legal/Refund",
        "/Legal/AcceptableUse", "/Legal/CookiePolicy",
        "/Legal/Licenses", "/Legal/Accessibility", "/Legal/Dmca",
    ];

    private static readonly string[] ClientRoutes =
    [
        "/Client/CreateTask", "/Client/Payments", "/Client/Repository",
    ];

    private static string TestBaseUrl =>
        Environment.GetEnvironmentVariable("PRTASK_TEST_URL")
        ?? $"https://{AppConstants.AppDomain}";

    [TestMethod]
    [Timeout(600000)]
    [DisplayName("Routes: all prerendered pages return 200")]
    public async Task AllRoutesReturn200Async()
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
        var AllRoutes = PrerenderedRoutes.Concat(LegalRoutes).Concat(ClientRoutes);
        foreach (var Route in AllRoutes)
        {
            var Url = $"{TestBaseUrl}{Route}";
            var Response = await Client.GetAsync(Url);
            if (!Response.IsSuccessStatusCode)
            {
                Failures.Add($"{Route} => {(int)Response.StatusCode}");
            }
        }

        Assert.AreEqual(0, Failures.Count,
            $"Routes returning non-200:\n{string.Join("\n", Failures)}");
    }

    [TestMethod]
    [Timeout(600000)]
    [DisplayName("Routes: all nav/footer links clickable from / without 404")]
    public async Task AllLinksClickableFromHomeAsync()
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
            var Links = await Page.EvaluateAsync<string[]>(
                "() => [...new Set([...document.querySelectorAll('a[href]')].map(a => a.getAttribute('href')).filter(h => h && h.startsWith('/') && !h.startsWith('/Api')))]");
            var Failures = new List<string>();
            foreach (var Href in Links)
            {
                var Response = await Page.GotoAsync($"{TestBaseUrl}{Href}",
                    new PageGotoOptions { Timeout = 10000, WaitUntil = WaitUntilState.DOMContentLoaded });
                if (Response is null || (!Response.Ok && Response.Status != 304))
                {
                    Failures.Add($"{Href} => {Response?.Status ?? 0}");
                }
            }

            Assert.AreEqual(0, Failures.Count,
                $"Links from / returning errors:\n{string.Join("\n", Failures)}");
        }
        finally
        {
            await Page.CloseAsync();
            await Context.DisposeAsync();
        }
    }
}
