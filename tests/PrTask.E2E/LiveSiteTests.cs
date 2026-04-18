using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
[TestClass]
public partial class LiveSiteTests
{
    private static readonly string BaseUrl = $"https://{AppConstants.AppDomain}";
    private static HttpClient Client { get; set; } = null!;
    [ClassInitialize]
    public static void ClassInitializeLiveSiteHttpClient(TestContext Context)
    {
        var Handler = new HttpClientHandler { AllowAutoRedirect = false, CheckCertificateRevocationList = true };
        Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(30) };
    }
    [ClassCleanup]
    public static void ClassCleanupLiveSiteHttpClient()
    {
        Client.Dispose();
    }
    private static async Task<HttpResponseMessage> GetOrSkipAsync(string Url)
    {
        try
        {
            return await Client.GetAsync(Url);
        }
        catch (HttpRequestException Ex)
        {
            Assert.Inconclusive($"Site not reachable (deploy first): {Ex.Message}");
            return null!;
        }
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Live site root URL must return successful HTTP status code confirming deployment is active")]
    public async Task LiveSiteRootUrlMustReturnSuccessfulHttpStatusCodeConfirmingDeploymentIsActiveAsync()
    {
        var Response = await GetOrSkipAsync(BaseUrl);
        Assert.IsTrue(Response.IsSuccessStatusCode, $"Root returned {Response.StatusCode}");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Live site root must return HTML content type with Blazor WebAssembly entry point page")]
    public async Task LiveSiteRootMustReturnHtmlContentTypeWithBlazorWebAssemblyEntryPointPageAsync()
    {
        var Response = await GetOrSkipAsync(BaseUrl);
        var ContentType = Response.Content.Headers.ContentType?.MediaType;
        Assert.AreEqual("text/html", ContentType, $"Expected text/html, got {ContentType}");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Live site root HTML must contain blazor webassembly script reference for WASM bootstrap")]
    public async Task LiveSiteRootHtmlMustContainBlazorWebAssemblyScriptReferenceForWasmBootstrapAsync()
    {
        var Response = await GetOrSkipAsync(BaseUrl);
        var Html = await Response.Content.ReadAsStringAsync();
        Assert.IsTrue(Html.Contains("blazor.webassembly.js"), "HTML must reference blazor.webassembly.js");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Live site root HTML must contain PrTask title for correct branding on the deployed page")]
    public async Task LiveSiteRootHtmlMustContainPrTaskTitleForCorrectBrandingOnTheDeployedPageAsync()
    {
        var Response = await GetOrSkipAsync(BaseUrl);
        var Html = await Response.Content.ReadAsStringAsync();
        Assert.IsTrue(Html.Contains("PrTask"), "HTML must contain PrTask branding");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Live site Blazor framework endpoint must return WASM runtime files for client execution")]
    public async Task LiveSiteBlazorFrameworkEndpointMustReturnWasmRuntimeFilesForClientExecutionAsync()
    {
        var Response = await GetOrSkipAsync($"{BaseUrl}/_framework/blazor.webassembly.js");
        Assert.IsTrue(Response.IsSuccessStatusCode, $"_framework/blazor.webassembly.js returned {Response.StatusCode}");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Live site tasks page must return successful status via SPA redirect for client side routing")]
    public async Task LiveSiteTasksPageMustReturnSuccessfulStatusViaSpaRedirectForClientSideRoutingAsync()
    {
        var Response = await GetOrSkipAsync($"{BaseUrl}{RouteConstants.Tasks}");
        Assert.IsTrue(Response.IsSuccessStatusCode, $"Tasks page returned {Response.StatusCode}");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Live site leaderboard page must return successful status via SPA redirect for navigation")]
    public async Task LiveSiteLeaderboardPageMustReturnSuccessfulStatusViaSpaRedirectForNavigationAsync()
    {
        var Response = await GetOrSkipAsync($"{BaseUrl}{RouteConstants.Leaderboard}");
        Assert.IsTrue(Response.IsSuccessStatusCode, $"Leaderboard page returned {Response.StatusCode}");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Live site login page must return successful status via SPA redirect for authentication flow")]
    public async Task LiveSiteLoginPageMustReturnSuccessfulStatusViaSpaRedirectForAuthenticationFlowAsync()
    {
        var Response = await GetOrSkipAsync($"{BaseUrl}{RouteConstants.Login}");
        Assert.IsTrue(Response.IsSuccessStatusCode, $"Login page returned {Response.StatusCode}");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Live site legal terms page must return successful status for compliance page availability")]
    public async Task LiveSiteLegalTermsPageMustReturnSuccessfulStatusForCompliancePageAvailabilityAsync()
    {
        var Response = await GetOrSkipAsync($"{BaseUrl}{RouteConstants.Terms}");
        Assert.IsTrue(Response.IsSuccessStatusCode, $"Terms page returned {Response.StatusCode}");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Live site privacy policy page must return successful status for legal compliance verification")]
    public async Task LiveSitePrivacyPolicyPageMustReturnSuccessfulStatusForLegalComplianceVerificationAsync()
    {
        var Response = await GetOrSkipAsync($"{BaseUrl}{RouteConstants.Privacy}");
        Assert.IsTrue(Response.IsSuccessStatusCode, $"Privacy page returned {Response.StatusCode}");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Live site refund policy page must return successful status for payment compliance")]
    public async Task LiveSiteRefundPolicyPageMustReturnSuccessfulStatusForPaymentComplianceAsync()
    {
        var Response = await GetOrSkipAsync($"{BaseUrl}{RouteConstants.Refund}");
        Assert.IsTrue(Response.IsSuccessStatusCode, $"Refund page returned {Response.StatusCode}");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Live site cookie policy page must return successful status for privacy regulation compliance")]
    public async Task LiveSiteCookiePolicyPageMustReturnSuccessfulStatusForPrivacyRegulationComplianceAsync()
    {
        var Response = await GetOrSkipAsync($"{BaseUrl}{RouteConstants.CookiePolicy}");
        Assert.IsTrue(Response.IsSuccessStatusCode, $"Cookie policy page returned {Response.StatusCode}");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Live site acceptable use page must return successful status for platform policy enforcement")]
    public async Task LiveSiteAcceptableUsePageMustReturnSuccessfulStatusForPlatformPolicyEnforcementAsync()
    {
        var Response = await GetOrSkipAsync($"{BaseUrl}{RouteConstants.AcceptableUse}");
        Assert.IsTrue(Response.IsSuccessStatusCode, $"Acceptable use page returned {Response.StatusCode}");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Live site dashboard page must return successful status via SPA routing for authenticated users")]
    public async Task LiveSiteDashboardPageMustReturnSuccessfulStatusViaSpaRoutingForAuthenticatedUsersAsync()
    {
        var Response = await GetOrSkipAsync($"{BaseUrl}{RouteConstants.Dashboard}");
        Assert.IsTrue(Response.IsSuccessStatusCode, $"Dashboard page returned {Response.StatusCode}");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Live site must serve response with Cloudflare server header confirming CDN hosting provider")]
    public async Task LiveSiteMustServeResponseWithCloudflareServerHeaderConfirmingCdnHostingProviderAsync()
    {
        var Response = await GetOrSkipAsync(BaseUrl);
        var ServerHeader = Response.Headers.Server?.ToString() ?? string.Empty;
        Assert.IsTrue(ServerHeader.Contains("cloudflare", StringComparison.OrdinalIgnoreCase), $"Expected Cloudflare server header, got: {ServerHeader}");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Live site must enforce HTTPS by returning successful status on secure connection only")]
    public async Task LiveSiteMustEnforceHttpsByReturnningSuccessfulStatusOnSecureConnectionOnlyAsync()
    {
        var Response = await GetOrSkipAsync($"https://{AppConstants.AppDomain}");
        Assert.IsTrue(Response.IsSuccessStatusCode, "HTTPS connection must succeed");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Live site www subdomain must redirect or resolve to same content as root domain")]
    public async Task LiveSiteWwwSubdomainMustRedirectOrResolveToSameContentAsRootDomainAsync()
    {
        HttpResponseMessage Response;
        try
        {
            var WwwHandler = new HttpClientHandler { CheckCertificateRevocationList = true };
            using var WwwClient = new HttpClient(WwwHandler) { Timeout = TimeSpan.FromSeconds(30) };
            Response = await WwwClient.GetAsync($"https://www.{AppConstants.AppDomain}");
        }
        catch (HttpRequestException Ex)
        {
            Assert.Inconclusive($"Site not reachable (deploy first): {Ex.Message}");
            return;
        }
        Assert.IsTrue(Response.IsSuccessStatusCode, $"www subdomain returned {Response.StatusCode}");
        var Html = await Response.Content.ReadAsStringAsync();
        Assert.IsTrue(Html.Contains("PrTask"), "www subdomain must serve PrTask content");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Live site SharedUI CSS stylesheet must be accessible for component styling on deployed site")]
    public async Task LiveSiteSharedUiCssStylesheetMustBeAccessibleForComponentStylingOnDeployedSiteAsync()
    {
        var Response = await GetOrSkipAsync($"{BaseUrl}/_content/PrTask.SharedUI/css/app.css");
        Assert.IsTrue(Response.IsSuccessStatusCode, $"SharedUI CSS returned {Response.StatusCode}");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Live site login page must be accessible with SSO provider options for authentication")]
    public async Task LiveSiteLoginPageMustBeAccessibleWithSsoProviderOptionsForAuthenticationAsync()
    {
        var Response = await GetOrSkipAsync($"{BaseUrl}{RouteConstants.Login}");
        Assert.IsTrue(Response.IsSuccessStatusCode, $"Login page returned {Response.StatusCode}");
        var Html = await Response.Content.ReadAsStringAsync();
        Assert.IsTrue(Html.Contains("PrTask"), "Login page must contain PrTask branding");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Live site Workers API auth endpoint must respond for serverless SSO authentication flow")]
    public async Task LiveSiteWorkersApiAuthEndpointMustRespondForServerlessSsoAuthenticationFlowAsync()
    {
        var Response = await GetOrSkipAsync($"{BaseUrl}/api/auth/me");
        Assert.IsTrue(Response.StatusCode == HttpStatusCode.Unauthorized || Response.IsSuccessStatusCode, $"API auth/me returned {Response.StatusCode}");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Live site API tasks endpoint must return valid response for public task listing")]
    public async Task LiveSiteApiTasksEndpointMustReturnValidResponseForPublicTaskListingAsync()
    {
        var Response = await GetOrSkipAsync($"{BaseUrl}{RouteConstants.ApiTasks}");
        Assert.IsTrue(Response.IsSuccessStatusCode, $"API tasks returned {Response.StatusCode}");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Live site API leaderboard endpoint must return valid response for public ranking display")]
    public async Task LiveSiteApiLeaderboardEndpointMustReturnValidResponseForPublicRankingDisplayAsync()
    {
        var Response = await GetOrSkipAsync($"{BaseUrl}{RouteConstants.ApiLeaderboard}");
        Assert.IsTrue(Response.IsSuccessStatusCode, $"API leaderboard returned {Response.StatusCode}");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Live site API auth me endpoint must return unauthorized for unauthenticated session check")]
    public async Task LiveSiteApiAuthMeEndpointMustReturnUnauthorizedForUnauthenticatedSessionCheckAsync()
    {
        var Response = await GetOrSkipAsync($"{BaseUrl}{RouteConstants.ApiAuthMe}");
        Assert.AreEqual(HttpStatusCode.Unauthorized, Response.StatusCode, "Auth me must return 401 when not logged in");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Live site CSS must be accessible and served as minified stylesheet for theme support")]
    public async Task LiveSiteCssMustBeAccessibleAndServedAsMinifiedStylesheetForThemeSupportAsync()
    {
        var Response = await GetOrSkipAsync($"{BaseUrl}/_content/PrTask.SharedUI/css/app.css");
        Assert.IsTrue(Response.IsSuccessStatusCode, $"CSS returned {Response.StatusCode}");
        var Css = await Response.Content.ReadAsStringAsync();
        Assert.IsTrue(Css.Contains("--color-bg"), "CSS must contain --color-bg custom property for theming");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Live site CSS must contain prefers-color-scheme media query for OS night mode detection")]
    public async Task LiveSiteCssMustContainPrefersColorSchemeMediaQueryForOsNightModeDetectionAsync()
    {
        var Response = await GetOrSkipAsync($"{BaseUrl}/_content/PrTask.SharedUI/css/app.css");
        Assert.IsTrue(Response.IsSuccessStatusCode, $"CSS returned {Response.StatusCode}");
        var Css = await Response.Content.ReadAsStringAsync();
        Assert.IsTrue(Css.Contains("prefers-color-scheme"), "CSS must contain prefers-color-scheme for night mode");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Live site CSS must not use any overflow property and support mobile portrait vertical scrolling")]
    public async Task LiveSiteCssMustNotUseAnyOverflowPropertyAndSupportMobilePortraitVerticalScrollingAsync()
    {
        var Response = await GetOrSkipAsync($"{BaseUrl}/_content/PrTask.SharedUI/css/app.css");
        Assert.IsTrue(Response.IsSuccessStatusCode, $"CSS returned {Response.StatusCode}");
        var Css = await Response.Content.ReadAsStringAsync();
        Assert.IsTrue(Css.Contains("max-width:100vw"), "CSS must use max-width:100vw on #app to prevent horizontal overflow without overflow property");
        Assert.IsTrue(Css.Contains("min-height:100dvh"), "CSS must use 100dvh not 100vh — dvh accounts for mobile browser chrome");
        Assert.IsFalse(Css.Contains("min-height:100vh"), "CSS must not use 100vh — causes scrolling issues on mobile Chrome");
        Assert.IsFalse(Css.Contains("overflow-x") || Css.Contains("overflow-y") || Css.Contains("overflow:hidden"), "CSS must not use any overflow property — all overflow values break mobile portrait scrolling");
        Assert.IsTrue(Css.Contains("word-break"), "CSS must use word-break to prevent text from causing horizontal overflow");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Live site Google OAuth endpoint must redirect to Google accounts for PKCE authentication flow")]
    public async Task LiveSiteGoogleOAuthEndpointMustRedirectToGoogleAccountsForPkceAuthenticationFlowAsync()
    {
        var Response = await GetOrSkipAsync($"{BaseUrl}{RouteConstants.ApiAuthGoogle}");
        Assert.AreEqual(HttpStatusCode.Found, Response.StatusCode, $"Google auth must return 302 redirect, got {Response.StatusCode}");
        var Location = Response.Headers.Location?.ToString() ?? string.Empty;
        Assert.IsTrue(Location.StartsWith("https://accounts.google.com/o/oauth2/v2/auth"), $"Redirect must point to Google OAuth, got: {Location}");
        Assert.IsTrue(Location.Contains("code_challenge="), "Redirect must contain PKCE code_challenge parameter");
        Assert.IsTrue(Location.Contains("code_challenge_method=S256"), "Redirect must use S256 code challenge method");
        Assert.IsTrue(Location.Contains("client_id="), "Redirect must contain client_id parameter");
        Assert.IsTrue(Location.Contains("redirect_uri="), "Redirect must contain redirect_uri parameter");
        Assert.IsTrue(Location.Contains("scope="), "Redirect must contain scope parameter");
        Assert.IsTrue(Location.Contains("response_type=code"), "Redirect must use authorization code flow");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Live site about page must return successful status for company information and legal links")]
    public async Task LiveSiteAboutPageMustReturnSuccessfulStatusForCompanyInformationAndLegalLinksAsync()
    {
        var Response = await GetOrSkipAsync($"{BaseUrl}{RouteConstants.About}");
        Assert.IsTrue(Response.IsSuccessStatusCode, $"About page returned {Response.StatusCode}");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Live site accessibility statement page must return successful status for ADA compliance")]
    public async Task LiveSiteAccessibilityStatementPageMustReturnSuccessfulStatusForAdaComplianceAsync()
    {
        var Response = await GetOrSkipAsync($"{BaseUrl}{RouteConstants.Accessibility}");
        Assert.IsTrue(Response.IsSuccessStatusCode, $"Accessibility page returned {Response.StatusCode}");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Live site DMCA copyright policy page must return successful status for safe harbor compliance")]
    public async Task LiveSiteDmcaCopyrightPolicyPageMustReturnSuccessfulStatusForSafeHarborComplianceAsync()
    {
        var Response = await GetOrSkipAsync($"{BaseUrl}{RouteConstants.Dmca}");
        Assert.IsTrue(Response.IsSuccessStatusCode, $"DMCA page returned {Response.StatusCode}");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Live site deployed WASM assemblies must not contain 10 percent fee text in pricing page content")]
    public async Task LiveSiteDeployedWasmAssembliesMustNotContainTenPercentFeeTextInPricingPageContentAsync()
    {
        var DotnetJsResponse = await GetOrSkipAsync($"{BaseUrl}/_framework/dotnet.js");
        Assert.IsTrue(DotnetJsResponse.IsSuccessStatusCode, $"dotnet.js returned {DotnetJsResponse.StatusCode}");
        var DotnetJs = await DotnetJsResponse.Content.ReadAsStringAsync();
        Assert.IsTrue(DotnetJs.Contains("mainAssemblyName"), "dotnet.js must contain assembly manifest, not SPA fallback HTML");
        var Matches = WasmAssemblyNamePattern().Matches(DotnetJs);
        Assert.IsTrue(Matches.Count > 0, "Must find PrTask Client or SharedUI assembly names in dotnet.js");
        var FeeUtf8 = Encoding.UTF8.GetBytes("10% Fee");
        var FeeUtf16 = Encoding.Unicode.GetBytes("10% Fee");
        foreach (Match AssemblyMatch in Matches)
        {
            var AssemblyName = AssemblyMatch.Groups[1].Value;
            var AssemblyResponse = await GetOrSkipAsync($"{BaseUrl}/_framework/{AssemblyName}");
            Assert.IsTrue(AssemblyResponse.IsSuccessStatusCode, $"{AssemblyName} returned {AssemblyResponse.StatusCode}");
            var AssemblyBytes = await AssemblyResponse.Content.ReadAsByteArrayAsync();
            var ContainsFee = ContainsByteSequence(AssemblyBytes, FeeUtf8) || ContainsByteSequence(AssemblyBytes, FeeUtf16);
            Assert.IsFalse(ContainsFee, $"Assembly {AssemblyName} must not contain '10% Fee' — pricing page should show Free");
        }
    }
    private static bool ContainsByteSequence(byte[] Source, byte[] Pattern)
    {
        return ((ReadOnlySpan<byte>)Source).IndexOf((ReadOnlySpan<byte>)Pattern) >= 0;
    }
    [GeneratedRegex(@"""name"":\s*""(PrTask\.(Client|SharedUI)\.[a-z0-9]+\.wasm)""")]
    private static partial Regex WasmAssemblyNamePattern();
}
