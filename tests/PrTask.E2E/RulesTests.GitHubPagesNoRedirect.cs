namespace PrTask.E2E;

public partial class RulesTests
{
    private const string GitHubPagesUrl = "https://cruzlauroiii.github.io/prtask.com/";
    private const string GitHubPagesOrigin = "https://cruzlauroiii.github.io";
    private const string PrtaskLiveUrl = "https://prtask.com/";

    [TestMethod]
    [DisplayName("GitHubPages: no redirect to prtask.com (HTTP)")]
    public async Task GitHubPagesHttpNoRedirectAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = false,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(30) };

        var Response = await Client.GetAsync(GitHubPagesUrl);

        Assert.AreEqual(HttpStatusCode.OK, Response.StatusCode,
            $"GitHub Pages must return 200, got {(int)Response.StatusCode}. " +
            $"Location header: {Response.Headers.Location?.ToString() ?? "(none)"}");

        Assert.IsNull(Response.Headers.Location,
            $"GitHub Pages must NOT have Location header, got: {Response.Headers.Location}");
    }

    [TestMethod]
    [DisplayName("GitHubPages: no redirect to prtask.com (CDP)")]
    public async Task GitHubPagesCdpNoRedirectAsync()
    {
        await BrowserPage.NavigateAsync(GitHubPagesUrl);

        var FinalUrl = await CdpHelpers.GetUrlAsync(BrowserPage);
        Assert.IsTrue(FinalUrl.StartsWith(GitHubPagesOrigin, StringComparison.OrdinalIgnoreCase),
            $"Browser must stay on github.io, but ended up at: {FinalUrl}");

        Assert.IsFalse(FinalUrl.Contains("prtask.com/") && !FinalUrl.Contains("github.io"),
            $"Browser must NOT redirect to prtask.com, final URL: {FinalUrl}");

        var Title = await CdpHelpers.GetTitleAsync(BrowserPage);
        Assert.IsFalse(string.IsNullOrWhiteSpace(Title),
            $"Page must have a title, got: '{Title}'");

        await TakeScreenshotAsync("github-pages-no-redirect.png");
    }

    [TestMethod]
    [DisplayName("GitHubPages: no CNAME file in deployed site")]
    public async Task GitHubPagesNoCnameFileAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = false,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(30) };

        var Response = await Client.GetAsync("https://cruzlauroiii.github.io/prtask.com/CNAME");

        Assert.AreEqual(HttpStatusCode.NotFound, Response.StatusCode,
            $"CNAME file must NOT exist on GitHub Pages, got {(int)Response.StatusCode}");
    }

    [TestMethod]
    [DisplayName("PrTask.com: live site still reachable")]
    public async Task PrtaskComLiveSiteReachableAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = true,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(30) };

        var (Response, Body) = await GetFollowingMetaRefreshAsync(Client, PrtaskLiveUrl);

        Assert.IsTrue(Response.IsSuccessStatusCode,
            $"prtask.com must return 2xx, got {(int)Response.StatusCode}");

        Assert.IsTrue(Body.Contains("PrTask", StringComparison.OrdinalIgnoreCase),
            "prtask.com response must contain 'PrTask'");
    }
}
