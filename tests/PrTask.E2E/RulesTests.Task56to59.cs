using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task56 Live site must return successful HTTP for root pages API endpoints legal pages and Cloudflare header")]
    public async Task Task56LiveSiteHttpResponsesAsync()
    {
        var Response = await GetOrSkipAsync(BaseUrl);
        Assert.IsTrue(Response.IsSuccessStatusCode, $"Root returned {Response.StatusCode}");
        var Html = await Response.Content.ReadAsStringAsync();
        Assert.IsTrue(Html.Contains("PrTask"), "Must contain PrTask branding");
        Assert.IsTrue(Html.Contains("blazor.webassembly.js") || Html.Contains("blazor.web.js"),
            "Must reference Blazor runtime script");
        if (BaseUrl.Contains(AppConstants.AppDomain))
        {
            var ServerHeader = Response.Headers.Server?.ToString() ?? string.Empty;
            Assert.IsTrue(ServerHeader.Contains("cloudflare", StringComparison.OrdinalIgnoreCase), "Must have Cloudflare server header");
        }
        var PageRoutes = new[] { RouteConstants.Tasks, RouteConstants.Leaderboard, RouteConstants.Login,
            RouteConstants.Dashboard, RouteConstants.About };
        foreach (var Route in PageRoutes)
        {
            var PageResponse = await GetOrSkipAsync($"{BaseUrl}{Route}");
            Assert.IsTrue(PageResponse.IsSuccessStatusCode, $"{Route} returned {PageResponse.StatusCode}");
        }
        var LegalRoutes = new[] { RouteConstants.Terms, RouteConstants.Privacy, RouteConstants.Refund,
            RouteConstants.CookiePolicy, RouteConstants.AcceptableUse, RouteConstants.Accessibility, RouteConstants.Dmca };
        foreach (var Route in LegalRoutes)
        {
            var LegalResponse = await GetOrSkipAsync($"{BaseUrl}{Route}");
            Assert.IsTrue(LegalResponse.IsSuccessStatusCode, $"{Route} returned {LegalResponse.StatusCode}");
        }
        var ApiTasksResponse = await GetOrSkipAsync($"{BaseUrl}{RouteConstants.ApiTasks}");
        Assert.IsTrue(ApiTasksResponse.IsSuccessStatusCode, $"API tasks returned {ApiTasksResponse.StatusCode}");
        var ApiLeaderboardResponse = await GetOrSkipAsync($"{BaseUrl}{RouteConstants.ApiLeaderboard}");
        Assert.IsTrue(ApiLeaderboardResponse.IsSuccessStatusCode, $"API leaderboard returned {ApiLeaderboardResponse.StatusCode}");
        var AuthMeResponse = await GetOrSkipAsync($"{BaseUrl}{RouteConstants.ApiAuthMe}");
        Assert.AreEqual(HttpStatusCode.Unauthorized, AuthMeResponse.StatusCode, "Auth me must return 401 when not logged in");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task57 Live site CSS must contain theme properties prefers-color-scheme max-width 100vw min-height 100dvh no overflow word-break")]
    public async Task Task57LiveSiteCssThemeAndLayoutAsync()
    {
        var Response = await GetOrSkipAsync($"{BaseUrl}/_content/PrTask.SharedUI/css/app.css");
        Assert.IsTrue(Response.IsSuccessStatusCode, $"CSS returned {Response.StatusCode}");
        var Css = await Response.Content.ReadAsStringAsync();
        Assert.IsTrue(Css.Contains("--color-bg"), "Must contain --color-bg custom property");
        Assert.IsTrue(Css.Contains("prefers-color-scheme"), "Must contain prefers-color-scheme");
        Assert.IsTrue(Css.Contains("max-width:100vw"), "Must use max-width:100vw");
        Assert.IsTrue(Css.Contains("min-height:100dvh"), "Must use 100dvh");
        Assert.IsFalse(Css.Contains("min-height:100vh"), "Must not use 100vh");
        Assert.IsFalse(Css.Contains("overflow-x") || Css.Contains("overflow-y") || Css.Contains("overflow:hidden"), "Must not use overflow");
        Assert.IsTrue(Css.Contains("word-break"), "Must use word-break");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task58 Live site Google OAuth must redirect to accounts.google.com with PKCE S256 code_challenge")]
    public async Task Task58LiveSiteGoogleOAuthPkceAsync()
    {
        var Response = await GetOrSkipAsync($"{BaseUrl}{RouteConstants.ApiAuthGoogle}");
        Assert.AreEqual(HttpStatusCode.Found, Response.StatusCode, $"Must return 302, got {Response.StatusCode}");
        var Location = Response.Headers.Location?.ToString() ?? string.Empty;
        Assert.IsTrue(Location.StartsWith("https://accounts.google.com/o/oauth2/v2/auth"), "Must redirect to Google OAuth");
        Assert.IsTrue(Location.Contains("code_challenge="), "Must contain code_challenge");
        Assert.IsTrue(Location.Contains("code_challenge_method=S256"), "Must use S256 method");
        Assert.IsTrue(Location.Contains("client_id="), "Must contain client_id");
        Assert.IsTrue(Location.Contains("redirect_uri="), "Must contain redirect_uri");
        Assert.IsTrue(Location.Contains("response_type=code"), "Must use authorization code flow");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task59 Deployed WASM assemblies must not contain 10 percent Fee text")]
    public async Task Task59WasmNoFeeTextAsync()
    {
        var IndexResponse = await GetOrSkipAsync(BaseUrl, AllowNonSuccess: true);
        if (!IndexResponse.IsSuccessStatusCode)
        {
            Assert.Inconclusive($"Root page returned {IndexResponse.StatusCode} — WASM test requires deployed client");
            return;
        }
        var IndexHtml = await IndexResponse.Content.ReadAsStringAsync();
        var DotnetJsUrl = ResolveFingerprintedDotnetJs(IndexHtml);
        var DotnetJsResponse = await GetOrSkipAsync($"{BaseUrl}/{DotnetJsUrl}", AllowNonSuccess: true);
        if (!DotnetJsResponse.IsSuccessStatusCode)
        {
            Assert.Inconclusive($"WASM not deployed — dotnet.js returned {DotnetJsResponse.StatusCode}");
            return;
        }
        var DotnetJs = await DotnetJsResponse.Content.ReadAsStringAsync();
        Assert.IsTrue(DotnetJs.Contains("mainAssemblyName"), "dotnet.js must contain assembly manifest");
        var Matches = WasmAssemblyNamePattern().Matches(DotnetJs);
        Assert.IsTrue(Matches.Count > 0, "Must find PrTask assembly names in dotnet.js");
        var FeeUtf8 = Encoding.UTF8.GetBytes("10% Fee");
        var FeeUtf16 = Encoding.Unicode.GetBytes("10% Fee");
        foreach (System.Text.RegularExpressions.Match AssemblyMatch in Matches)
        {
            var AssemblyName = AssemblyMatch.Groups[1].Value;
            var AssemblyResponse = await GetOrSkipAsync($"{BaseUrl}/_framework/{AssemblyName}");
            Assert.IsTrue(AssemblyResponse.IsSuccessStatusCode, $"{AssemblyName} returned {AssemblyResponse.StatusCode}");
            var Bytes = await AssemblyResponse.Content.ReadAsByteArrayAsync();
            Assert.IsFalse(ContainsByteSequence(Bytes, FeeUtf8) || ContainsByteSequence(Bytes, FeeUtf16),
                $"Assembly {AssemblyName} must not contain '10% Fee'");
        }
    }
}
