using System.Text.RegularExpressions;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [GeneratedRegex(
        @"pull\s*request|earn\s*money|donate|bounty|open\s*source|developer",
        RegexOptions.IgnoreCase)]
    private static partial Regex SeoContentRegex();

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Req9: all pages have SEO content about PRs/earning")]
    public async Task SeoParagraphsAllPagesAsync()
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
            if (!SeoContentRegex().IsMatch(Html))
            {
                Failures.Add($"{Path} missing SEO content");
            }
        }

        Assert.AreEqual(0, Failures.Count,
            $"Pages missing SEO:\n{string.Join("\n", Failures)}");
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Req10: URL-based task entry point works")]
    public async Task UrlEntryPointAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = true,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(30) };
        var TestUrl = $"https://{AppConstants.AppDomain}/Tasks/test-task-id";
        var Response = await Client.GetAsync(TestUrl);
        Assert.IsTrue(Response.IsSuccessStatusCode,
            $"Task URL must return 2xx, got {(int)Response.StatusCode}");
        var Html = await Response.Content.ReadAsStringAsync();
        Assert.IsTrue(Html.Contains("nav-menu"),
            "Task entry point must have navigation");
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Req11: static header complete with all nav elements")]
    public async Task StaticHeaderCompleteAsync()
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
            if (!Html.Contains("nav-menu"))
            {
                Failures.Add($"{Path} missing nav-menu");
            }

            if (!Html.Contains("nav-brand"))
            {
                Failures.Add($"{Path} missing nav-brand");
            }

            if (!Html.Contains("nav-toggle"))
            {
                Failures.Add($"{Path} missing nav-toggle");
            }

            if (!Html.Contains("nav-links"))
            {
                Failures.Add($"{Path} missing nav-links");
            }

            if (!Html.Contains("href=\"Tasks") && !Html.Contains("href=\"./Tasks"))
            {
                Failures.Add($"{Path} missing Tasks link");
            }

            if (!Html.Contains("Sign In"))
            {
                Failures.Add($"{Path} missing Sign In");
            }

            if (!Html.Contains("site-footer"))
            {
                Failures.Add($"{Path} missing footer");
            }
        }

        Assert.AreEqual(0, Failures.Count,
            $"Static header issues:\n{string.Join("\n", Failures)}");
    }
}
