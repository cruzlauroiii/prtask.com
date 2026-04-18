using System.Text.RegularExpressions;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [GeneratedRegex(
        @"pull\s*request|earn\s*money|open\s*source|bounty|developer|side\s*hustle|tip|donate|contribute",
        RegexOptions.IgnoreCase)]
    private static partial Regex SeoKeywordsRegex();

    [GeneratedRegex(
        @"<p[^>]*>[^<]{50,}</p>",
        RegexOptions.IgnoreCase)]
    private static partial Regex SeoParagraphRegex();

    [TestMethod]
    [Timeout(600000)]
    [DisplayName("SEO: all pages have SEO keywords and paragraphs")]
    public async Task AllPagesSeoContentAsync()
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
        var AllRoutes = PrerenderedRoutes.Concat(LegalRoutes);
        foreach (var Route in AllRoutes)
        {
            var Url = $"{TestBaseUrl}{Route}";
            var Response = await Client.GetAsync(Url);
            if (!Response.IsSuccessStatusCode)
            {
                continue;
            }

            var Html = await Response.Content.ReadAsStringAsync();
            if (!SeoKeywordsRegex().IsMatch(Html))
            {
                Failures.Add($"{Route} missing SEO keywords");
            }

            if (!SeoParagraphRegex().IsMatch(Html))
            {
                Failures.Add($"{Route} missing substantial paragraphs (50+ chars)");
            }
        }

        Assert.AreEqual(0, Failures.Count,
            $"SEO issues:\n{string.Join("\n", Failures)}");
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("SEO: all pages have meta description and og tags")]
    public async Task AllPagesMetaTagsAsync()
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
        foreach (var Route in PrerenderedRoutes)
        {
            var Url = $"{TestBaseUrl}{Route}";
            var Response = await Client.GetAsync(Url);
            if (!Response.IsSuccessStatusCode)
            {
                continue;
            }

            var Html = await Response.Content.ReadAsStringAsync();
            if (!Html.Contains("name=\"description\""))
            {
                Failures.Add($"{Route} missing meta description");
            }

            if (!Html.Contains("property=\"og:title\""))
            {
                Failures.Add($"{Route} missing og:title");
            }
        }

        Assert.AreEqual(0, Failures.Count,
            $"Meta tag issues:\n{string.Join("\n", Failures)}");
    }
}
