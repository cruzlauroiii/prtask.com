using System.Text.RegularExpressions;
using PrTask.Cdp;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    private const string GhPagesRoot = "https://cruzlauroiii.github.io/prtask.com/";
    private const string PrtaskRoot = "https://prtask.com/";

    [GeneratedRegex(@"href=""([^""]*\.[a-z0-9]{10}\.html)""")]
    private static partial Regex FingerprintedLinkRegex();

    [GeneratedRegex(@"<a[^>]*href=""([^""]+)""")]
    private static partial Regex NavLinkHrefRegex();

    [GeneratedRegex(@"<a[^>]*href=""([^""]+)""")]
    private static partial Regex NavLinkHrefRegex();

    [GeneratedRegex(@"<a[^>]*href=""([^""]+)""")]
    private static partial Regex NavLinkHrefRegex();

    [GeneratedRegex(@"<a[^>]*href=""([^""]+)""")]
    private static partial Regex NavLinkHrefRegex();

    [GeneratedRegex(@"<a[^>]*href=""([^""]+)""")]
    private static partial Regex NavLinkHrefRegex();

    [GeneratedRegex(@"<a[^>]*href=""([^""]+)""")]
    private static partial Regex NavLinkHrefRegex();

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("GhPages: all fingerprinted nav links return 200")]
    public async Task GhPagesAllNavLinksReturn200Async()
    {
#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = true,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(30) };
        var IndexResponse = await Client.GetAsync(GhPagesRoot);
        var IndexHtml = await IndexResponse.Content.ReadAsStringAsync();
        var RefreshMatch = MetaRefreshUrlPattern().Match(IndexHtml);
        Assert.IsTrue(RefreshMatch.Success, "GH Pages index must redirect to fingerprinted page");
        var FpIndex = $"{GhPagesRoot}{RefreshMatch.Groups[1].Value}";
        var FpResponse = await Client.GetAsync(FpIndex);
        Assert.IsTrue(FpResponse.IsSuccessStatusCode, $"Fingerprinted index must return 200, got {(int)FpResponse.StatusCode}");
        var FpHtml = await FpResponse.Content.ReadAsStringAsync();
        var Links = NavLinkHrefRegex().Matches(FpHtml)
            .Select(M => M.Groups[1].Value)
            .Where(H => !H.StartsWith('h') && !H.StartsWith('#') && H.Length > 1)
            .Distinct()
            .ToList();
        Assert.IsTrue(Links.Count >= 10, string.Format(System.Globalization.CultureInfo.InvariantCulture, "Must have at least 10 nav links, got {0}", Links.Count));
        var Failures = new List<string>();
        foreach (var Link in Links)
        {
            var Url = Link.Contains("://") ? Link : $"{GhPagesRoot}{Link}";
            var Response = await Client.GetAsync(Url);
            if (!Response.IsSuccessStatusCode)
            {
                Failures.Add($"{Link} -> {(int)Response.StatusCode}");
            }
        }

        Assert.AreEqual(0, Failures.Count,
            $"GH Pages fingerprinted links 404:\n{string.Join("\n", Failures)}");
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("PrtaskCom: all fingerprinted nav links return 200")]
    public async Task PrtaskComAllNavLinksReturn200Async()
    {
#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = true,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(30) };
        var (_, Html) = await GetFollowingMetaRefreshAsync(Client, PrtaskRoot);
        var Links = FingerprintedLinkRegex().Matches(Html)
            .Select(M => M.Groups[1].Value)
            .Distinct()
            .ToList();
        Assert.IsTrue(Links.Count >= 10, $"Must have at least 10 fingerprinted links, got {Links.Count}");
        var Failures = new List<string>();
        foreach (var Link in Links)
        {
            var Url = Link.Contains("://") ? Link : $"{PrtaskRoot}{Link}";
            var LnkResponse = await Client.GetAsync(Url);
            if (!LnkResponse.IsSuccessStatusCode)
            {
                Failures.Add($"{Link} -> {(int)LnkResponse.StatusCode}");
            }
        }

        Assert.AreEqual(0, Failures.Count,
            $"prtask.com fingerprinted links 404:\n{string.Join("\n", Failures)}");
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("GhPages: CDP click Tasks link — no 404")]
    public async Task GhPagesClickTasksLinkAsync()
    {
        var Page = await CreateEmulatedPageAsync(1280, 720);
        try
        {
            await Page.NavigateAsync(GhPagesRoot);
            try
            {
                await Task.Delay(500);
            }
            catch (TimeoutException) { }

            await CdpHelpers.ClickSelectorAsync(Page, "a[href*='Tasks']");
            await Task.Delay(500);
            var Url = await CdpHelpers.GetUrlAsync(Page);
            Assert.IsFalse(Url.Contains("404"), $"Must not be 404 page, URL: {Url}");
            Assert.IsTrue(
                Url.Contains("Tasks") || Url.Contains("tasks"),
                $"Must navigate to Tasks page, URL: {Url}");
        }
        finally
        {
            await ClosePageAsync(Page);
        }
    }
}
