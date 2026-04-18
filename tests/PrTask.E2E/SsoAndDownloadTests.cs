using System.Net;
using System.Net.Http;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
[TestClass]
public class SsoAndDownloadTests
{
    private static readonly string BaseUrl = $"https://{AppConstants.AppDomain}";
    private static readonly string SourceRoot = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "..", "src"));
    private static HttpClient Client { get; set; } = null!;
    [ClassInitialize]
    public static void ClassInitializeSsoHttpClient(TestContext Context)
    {
        var Handler = new HttpClientHandler { AllowAutoRedirect = false, CheckCertificateRevocationList = true };
        Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(30) };
    }
    [ClassCleanup]
    public static void ClassCleanupSsoHttpClient()
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
            Assert.Inconclusive($"Site not reachable: {Ex.Message}");
            return null!;
        }
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Download page must exist and return successful status for APK distribution")]
    public async Task DownloadPageMustExistAndReturnSuccessfulStatusForApkDistributionAsync()
    {
        var Response = await GetOrSkipAsync($"{BaseUrl}{RouteConstants.Download}");
        Assert.IsTrue(Response.IsSuccessStatusCode, $"Download page returned {Response.StatusCode}");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Download page must contain APK download link for Android app distribution")]
    public void DownloadPageMustContainApkDownloadLinkForAndroidAppDistribution()
    {
        var DownloadPath = Path.Combine(SourceRoot, "PrTask.SharedUI", "Pages", "DownloadPage.razor");
        var Content = File.ReadAllText(DownloadPath);
        Assert.IsTrue(Content.Contains(".apk"), "Download page must contain APK file link");
        Assert.IsTrue(Content.Contains("download"), "Download page must have download attribute on APK link");
        Assert.IsTrue(Content.Contains("Android"), "Download page must mention Android platform");
        Assert.IsTrue(Content.Contains("btn btn-primary"), "APK download must use primary button styling");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Download page must exist in Client and MAUI projects as wrapper for SharedUI component")]
    public void DownloadPageMustExistInClientAndMauiProjectsAsWrapperForSharedUiComponent()
    {
        var ClientPath = Path.Combine(SourceRoot, "PrTask.Client", "Pages", "ClientDownloadPage.razor");
        var MauiPath = Path.Combine(SourceRoot, "PrTask.Maui", "Pages", "MauiDownloadPage.razor");
        Assert.IsTrue(File.Exists(ClientPath), "Client must have ClientDownloadPage.razor");
        Assert.IsTrue(File.Exists(MauiPath), "MAUI must have MauiDownloadPage.razor");
        var ClientContent = File.ReadAllText(ClientPath);
        var MauiContent = File.ReadAllText(MauiPath);
        Assert.IsTrue(ClientContent.Contains("PrTask.SharedUI.Pages.DownloadPage"), "Client download page must wrap SharedUI component");
        Assert.IsTrue(MauiContent.Contains("PrTask.SharedUI.Pages.DownloadPage"), "MAUI download page must wrap SharedUI component");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Nav menu must contain download link for APK distribution page")]
    public void NavMenuMustContainDownloadLinkForApkDistributionPage()
    {
        var ClientLayoutPath = Path.Combine(SourceRoot, "PrTask.Client", "Components", "ClientLayout.razor");
        var NavMenuPath = Path.Combine(SourceRoot, "PrTask.SharedUI", "Components", "NavMenu.razor");
        var ClientContent = File.ReadAllText(ClientLayoutPath);
        var NavContent = File.ReadAllText(NavMenuPath);
        Assert.IsTrue(ClientContent.Contains("Download") && ClientContent.Contains("RouteConstants.Download"), "Client layout must have Download nav link");
        Assert.IsTrue(NavContent.Contains("Download") && NavContent.Contains("/download"), "SharedUI nav must have Download nav link");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Google OAuth endpoint must return 302 redirect to Google accounts for SSO login")]
    public async Task GoogleOAuthEndpointMustReturn302RedirectToGoogleAccountsForSsoLoginAsync()
    {
        var Response = await GetOrSkipAsync($"{BaseUrl}{RouteConstants.ApiAuthGoogle}");
        Assert.AreEqual(HttpStatusCode.Found, Response.StatusCode, $"Google auth must return 302, got {Response.StatusCode}");
        var Location = Response.Headers.Location?.ToString() ?? string.Empty;
        Assert.IsTrue(Location.StartsWith("https://accounts.google.com"), $"Must redirect to Google, got: {Location}");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("GitHub OAuth endpoint must return 302 redirect to GitHub for SSO login not 404")]
    public async Task GitHubOAuthEndpointMustReturn302RedirectToGitHubForSsoLoginNot404Async()
    {
        var Response = await GetOrSkipAsync($"{BaseUrl}{RouteConstants.ApiAuthGitHub}");
        Assert.AreNotEqual(HttpStatusCode.NotFound, Response.StatusCode, "GitHub auth must not return 404 — endpoint must be deployed");
        Assert.AreEqual(HttpStatusCode.Found, Response.StatusCode, $"GitHub auth must return 302 redirect, got {Response.StatusCode}");
        var Location = Response.Headers.Location?.ToString() ?? string.Empty;
        Assert.IsTrue(Location.StartsWith("https://github.com"), $"Must redirect to GitHub, got: {Location}");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Azure OAuth endpoint must return 302 redirect to Microsoft login for SSO login not 404")]
    public async Task AzureOAuthEndpointMustReturn302RedirectToMicrosoftLoginForSsoLoginNot404Async()
    {
        var Response = await GetOrSkipAsync($"{BaseUrl}{RouteConstants.ApiAuthAzure}");
        Assert.AreNotEqual(HttpStatusCode.NotFound, Response.StatusCode, "Azure auth must not return 404 — endpoint must be deployed");
        Assert.AreEqual(HttpStatusCode.Found, Response.StatusCode, $"Azure auth must return 302 redirect, got {Response.StatusCode}");
        var Location = Response.Headers.Location?.ToString() ?? string.Empty;
        Assert.IsTrue(Location.StartsWith("https://login.microsoftonline.com"), $"Must redirect to Microsoft login, got: {Location}");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Okta OAuth endpoint must return 302 redirect to Okta for SSO login not 404")]
    public async Task OktaOAuthEndpointMustReturn302RedirectToOktaForSsoLoginNot404Async()
    {
        var Response = await GetOrSkipAsync($"{BaseUrl}{RouteConstants.ApiAuthOkta}");
        Assert.AreNotEqual(HttpStatusCode.NotFound, Response.StatusCode, "Okta auth must not return 404 — endpoint must be deployed");
        Assert.AreEqual(HttpStatusCode.Found, Response.StatusCode, $"Okta auth must return 302 redirect, got {Response.StatusCode}");
        var Location = Response.Headers.Location?.ToString() ?? string.Empty;
        Assert.IsTrue(Location.Contains("okta"), $"Must redirect to Okta domain, got: {Location}");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Login page must have buttons for all four SSO providers Google GitHub Azure Okta")]
    public void LoginPageMustHaveButtonsForAllFourSsoProvidersGoogleGitHubAzureOkta()
    {
        var SharedLoginPath = Path.Combine(SourceRoot, "PrTask.SharedUI", "Pages", "LoginPage.razor");
        var Content = File.ReadAllText(SharedLoginPath);
        Assert.IsTrue(Content.Contains("ApiAuthGoogle"), "Login page must link to Google SSO");
        Assert.IsTrue(Content.Contains("ApiAuthGitHub"), "Login page must link to GitHub SSO");
        Assert.IsTrue(Content.Contains("ApiAuthAzure"), "Login page must link to Azure SSO");
        Assert.IsTrue(Content.Contains("ApiAuthOkta"), "Login page must link to Okta SSO");
        Assert.IsTrue(Content.Contains("Sign in with Google"), "Must have Google sign-in button text");
        Assert.IsTrue(Content.Contains("Sign in with GitHub"), "Must have GitHub sign-in button text");
        Assert.IsTrue(Content.Contains("Sign in with Microsoft"), "Must have Microsoft sign-in button text");
        Assert.IsTrue(Content.Contains("Sign in with Okta"), "Must have Okta sign-in button text");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("MAUI login page must use absolute URLs to prtask.com for SSO since BlazorWebView runs locally")]
    public void MauiLoginPageMustUseAbsoluteUrlsToPrtaskComForSsoSinceBlazorWebViewRunsLocally()
    {
        var MauiLoginPath = Path.Combine(SourceRoot, "PrTask.Maui", "Pages", "MauiLoginPage.razor");
        var Content = File.ReadAllText(MauiLoginPath);
        Assert.IsTrue(Content.Contains("https://"), "MAUI login must use absolute HTTPS URLs for SSO endpoints");
        Assert.IsTrue(Content.Contains("AppConstants.AppDomain"), "MAUI login must reference AppDomain for base URL");
        Assert.IsTrue(Content.Contains("ApiAuthGoogle"), "MAUI login must have Google SSO link");
        Assert.IsTrue(Content.Contains("ApiAuthGitHub"), "MAUI login must have GitHub SSO link");
        Assert.IsTrue(Content.Contains("ApiAuthAzure"), "MAUI login must have Azure SSO link");
        Assert.IsTrue(Content.Contains("ApiAuthOkta"), "MAUI login must have Okta SSO link");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("MAUI login page must not use SharedUI LoginPage wrapper to avoid relative URL issues")]
    public void MauiLoginPageMustNotUseSharedUiLoginPageWrapperToAvoidRelativeUrlIssues()
    {
        var MauiLoginPath = Path.Combine(SourceRoot, "PrTask.Maui", "Pages", "MauiLoginPage.razor");
        var Content = File.ReadAllText(MauiLoginPath);
        Assert.IsFalse(
            Content.Contains("<PrTask.SharedUI.Pages.LoginPage"),
            "MAUI login must NOT wrap SharedUI LoginPage — SharedUI uses relative URLs that do not work in BlazorWebView");
        Assert.IsTrue(Content.Contains("login-section"), "MAUI login must have its own login-section UI with absolute URLs");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Server auth endpoints must be registered for all four SSO providers in the endpoint mapper")]
    public void ServerAuthEndpointsMustBeRegisteredForAllFourSsoProvidersInTheEndpointMapper()
    {
        var AuthPath = Path.Combine(SourceRoot, "PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        var Content = File.ReadAllText(AuthPath);
        Assert.IsTrue(Content.Contains("MapGitHubEndpoints"), "Server must map GitHub auth endpoints");
        Assert.IsTrue(Content.Contains("Google") && Content.Contains("ApiAuthGoogle"), "Server must map Google auth endpoint");
        Assert.IsTrue(Content.Contains("Azure") && Content.Contains("ApiAuthAzure"), "Server must map Azure auth endpoint");
        Assert.IsTrue(Content.Contains("Okta") && Content.Contains("ApiAuthOkta"), "Server must map Okta auth endpoint");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("MAUI login must use WebAuthenticator for native SSO instead of opening external browser")]
    public void MauiLoginMustUseWebAuthenticatorForNativeSsoInsteadOfOpeningExternalBrowser()
    {
        var MauiLoginPath = Path.Combine(SourceRoot, "PrTask.Maui", "Pages", "MauiLoginPage.razor");
        var Content = File.ReadAllText(MauiLoginPath);
        Assert.IsTrue(Content.Contains("WebAuthenticator"), "MAUI login must use WebAuthenticator for native Chrome Custom Tabs SSO");
        Assert.IsTrue(Content.Contains("AuthenticateAsync"), "MAUI login must call AuthenticateAsync for native OAuth flow");
        Assert.IsFalse(Content.Contains("NavigationManager.NavigateTo") && Content.Contains("forceLoad"),
            "MAUI login must NOT use NavigateTo with forceLoad which opens external browser");
        Assert.IsFalse(Content.Contains("<a href") && Content.Contains("ApiAuth"),
            "MAUI login must NOT use anchor tags for SSO which would open external browser");
        Assert.IsTrue(Content.Contains("@onclick"), "MAUI login must use @onclick handlers to invoke WebAuthenticator");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("MAUI must have AuthCallbackActivity for handling OAuth deep link callback")]
    public void MauiMustHaveAuthCallbackActivityForHandlingOAuthDeepLinkCallback()
    {
        var CallbackPath = Path.Combine(SourceRoot, "PrTask.Maui", "Platforms", "Android", "AuthCallbackActivity.cs");
        Assert.IsTrue(File.Exists(CallbackPath), "AuthCallbackActivity.cs must exist for OAuth callback handling");
        var Content = File.ReadAllText(CallbackPath);
        Assert.IsTrue(Content.Contains("WebAuthenticatorCallbackActivity"), "Must extend WebAuthenticatorCallbackActivity");
        Assert.IsTrue(Content.Contains("com.prtask.app"), "Must have custom scheme com.prtask.app for deep link");
        Assert.IsTrue(Content.Contains("auth"), "Must have DataHost auth for callback URI");
        Assert.IsTrue(Content.Contains("IntentFilter"), "Must have IntentFilter for deep link registration");
        Assert.IsTrue(Content.Contains("CategoryBrowsable"), "Must be browsable for deep link to work");
        Assert.IsTrue(Content.Contains("ActionView"), "Must handle ACTION_VIEW intent for deep link");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("MAUI login must use custom scheme callback URI matching AuthCallbackActivity")]
    public void MauiLoginMustUseCustomSchemeCallbackUriMatchingAuthCallbackActivity()
    {
        var MauiLoginPath = Path.Combine(SourceRoot, "PrTask.Maui", "Pages", "MauiLoginPage.razor");
        var Content = File.ReadAllText(MauiLoginPath);
        Assert.IsTrue(Content.Contains("com.prtask.app://auth"), "MAUI login must use com.prtask.app://auth as callback URI");
        Assert.IsTrue(Content.Contains("CallbackUri"), "MAUI login must define CallbackUri for WebAuthenticator");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("MAUI login must pass platform parameter to worker for mobile OAuth callback")]
    public void MauiLoginMustPassPlatformParameterToWorkerForMobileOAuthCallback()
    {
        var MauiLoginPath = Path.Combine(SourceRoot, "PrTask.Maui", "Pages", "MauiLoginPage.razor");
        var Content = File.ReadAllText(MauiLoginPath);
        Assert.IsTrue(Content.Contains("platform=android"), "MAUI login must pass ?platform=android to signal mobile flow to worker");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Worker must support mobile OAuth callback with custom scheme redirect for Android")]
    public void WorkerMustSupportMobileOAuthCallbackWithCustomSchemeRedirectForAndroid()
    {
        var WorkerPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "..", "infra", "worker.js"));
        var Content = File.ReadAllText(WorkerPath);
        Assert.IsTrue(Content.Contains("platform"), "Worker must detect platform parameter for mobile OAuth flow");
        Assert.IsTrue(Content.Contains("com.prtask.app://auth"), "Worker must redirect to com.prtask.app://auth for Android callback");
        Assert.IsTrue(Content.Contains("session"), "Worker must include session in mobile callback redirect");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("MAUI login must store session from WebAuthenticator result in Preferences")]
    public void MauiLoginMustStoreSessionFromWebAuthenticatorResultInPreferences()
    {
        var MauiLoginPath = Path.Combine(SourceRoot, "PrTask.Maui", "Pages", "MauiLoginPage.razor");
        var Content = File.ReadAllText(MauiLoginPath);
        Assert.IsTrue(Content.Contains("Preferences"), "MAUI login must use Preferences to store session after OAuth");
        Assert.IsTrue(Content.Contains("Result.Properties"), "MAUI login must read session from WebAuthenticator result properties");
        Assert.IsTrue(Content.Contains("NavigationManager.NavigateTo"), "MAUI login must navigate to dashboard after successful login");
    }
    [TestMethod, TestCategory("LiveSite")]
    [DisplayName("Google OAuth must accept platform parameter for mobile flow without error")]
    public async Task GoogleOAuthMustAcceptPlatformParameterForMobileFlowWithoutErrorAsync()
    {
        var Response = await GetOrSkipAsync($"{BaseUrl}{RouteConstants.ApiAuthGoogle}?platform=android");
        Assert.AreEqual(HttpStatusCode.Found, Response.StatusCode, $"Google auth with platform=android must return 302, got {Response.StatusCode}");
        var Location = Response.Headers.Location?.ToString() ?? string.Empty;
        Assert.IsTrue(Location.StartsWith("https://accounts.google.com"), $"Must still redirect to Google, got: {Location}");
    }
}
