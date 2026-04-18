namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth callback activity must handle deep link scheme com prtask app for oauth callback")]
    public void AuthCallbackActivityMustHandleDeepLinkSchemeComPrtaskAppForOauthCallback()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Platforms", "Android", "AuthCallbackActivity.cs");
        Assert.IsTrue(Code.Contains("com.prtask.app", StringComparison.Ordinal), "AuthCallbackActivity must use com.prtask.app URI scheme");
        Assert.IsTrue(Code.Contains("auth", StringComparison.Ordinal), "AuthCallbackActivity must handle auth host path");
        Assert.IsTrue(Code.Contains("WebAuthenticatorCallbackActivity", StringComparison.Ordinal), "AuthCallbackActivity must extend WebAuthenticatorCallbackActivity");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth callback activity must use single top launch mode with no history for clean back stack")]
    public void AuthCallbackActivityMustUseSingleTopLaunchModeWithNoHistoryForCleanBackStack()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Platforms", "Android", "AuthCallbackActivity.cs");
        Assert.IsTrue(Code.Contains("NoHistory = true", StringComparison.Ordinal), "AuthCallbackActivity must have NoHistory to prevent back navigation");
        Assert.IsTrue(Code.Contains("SingleTop", StringComparison.Ordinal), "AuthCallbackActivity must use SingleTop launch mode");
        Assert.IsTrue(Code.Contains("Exported = true", StringComparison.Ordinal), "AuthCallbackActivity must be exported for external intent handling");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Main application must extend maui application and create maui app from maui program")]
    public void MainApplicationMustExtendMauiApplicationAndCreateMauiAppFromMauiProgram()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Platforms", "Android", "MainApplication.cs");
        Assert.IsTrue(Code.Contains("MauiApplication", StringComparison.Ordinal), "MainApplication must extend MauiApplication");
        Assert.IsTrue(Code.Contains("MauiProgram.CreateMauiApp", StringComparison.Ordinal), "MainApplication must call MauiProgram.CreateMauiApp");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Main page must whitelist google github microsoft and okta domains for webview navigation")]
    public void MainPageMustWhitelistGoogleGitHubMicrosoftAndOktaDomainsForWebViewNavigation()
    {
        var Code = ReadSourceFile("PrTask.Maui", "MainPage.xaml.cs");
        Assert.IsTrue(Code.Contains("google.com", StringComparison.Ordinal), "MainPage must allow Google domains in WebView");
        Assert.IsTrue(Code.Contains("github.com", StringComparison.Ordinal), "MainPage must allow GitHub domains in WebView");
        Assert.IsTrue(Code.Contains("microsoftonline.com", StringComparison.Ordinal), "MainPage must allow Microsoft login domains in WebView");
        Assert.IsTrue(Code.Contains("okta.com", StringComparison.Ordinal), "MainPage must allow Okta domains in WebView");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Main page must use open in webview strategy for whitelisted sso provider domains")]
    public void MainPageMustUseOpenInWebViewStrategyForWhitelistedSsoProviderDomains()
    {
        var Code = ReadSourceFile("PrTask.Maui", "MainPage.xaml.cs");
        Assert.IsTrue(Code.Contains("OpenInWebView", StringComparison.Ordinal), "MainPage must set UrlLoadingStrategy.OpenInWebView for SSO domains");
        Assert.IsTrue(Code.Contains("OnUrlLoading", StringComparison.Ordinal), "MainPage must handle OnUrlLoading event for URL interception");
        Assert.IsTrue(Code.Contains("AppConstants.AppDomain", StringComparison.Ordinal), "MainPage must allow app domain in WebView");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client program must configure wasm host with root component and http client base address")]
    public void ClientProgramMustConfigureWasmHostWithRootComponentAndHttpClientBaseAddress()
    {
        var Code = ReadSourceFile("PrTask.Client", "Program.cs");
        Assert.IsTrue(Code.Contains("WebAssemblyHostBuilder", StringComparison.Ordinal), "Client must use WebAssembly host builder");
        Assert.IsTrue(Code.Contains("#app", StringComparison.Ordinal), "Client must mount root component at #app selector");
        Assert.IsTrue(Code.Contains("AppConstants.AppDomain", StringComparison.Ordinal), "Client HttpClient must use app domain as base address");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client layout must check auth me endpoint and display username when user is logged in")]
    public void ClientLayoutMustCheckAuthMeEndpointAndDisplayUsernameWhenUserIsLoggedIn()
    {
        var Code = ReadSourceFile("PrTask.Client", "Components", "ClientLayout.razor");
        Assert.IsTrue(Code.Contains("ApiAuthMe", StringComparison.Ordinal), "ClientLayout must call /api/auth/me to check auth state");
        Assert.IsTrue(Code.Contains("IsLoggedIn", StringComparison.Ordinal), "ClientLayout must track login state");
        Assert.IsTrue(Code.Contains("Username", StringComparison.Ordinal), "ClientLayout must display authenticated username");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client layout must support dark light theme toggle with persistent theme preference")]
    public void ClientLayoutMustSupportDarkLightThemeToggleWithPersistentThemePreference()
    {
        var Code = ReadSourceFile("PrTask.Client", "Components", "ClientLayout.razor");
        Assert.IsTrue(Code.Contains("prtaskGetTheme", StringComparison.Ordinal), "ClientLayout must call prtaskGetTheme for initial theme");
        Assert.IsTrue(Code.Contains("prtaskToggleTheme", StringComparison.Ordinal), "ClientLayout must call prtaskToggleTheme on toggle");
        Assert.IsTrue(Code.Contains("theme-toggle", StringComparison.Ordinal), "ClientLayout must have theme toggle button");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client layout nav must have links to all main pages with mobile menu toggle support")]
    public void ClientLayoutNavMustHaveLinksToAllMainPagesWithMobileMenuToggleSupport()
    {
        var Code = ReadSourceFile("PrTask.Client", "Components", "ClientLayout.razor");
        Assert.IsTrue(Code.Contains("nav-toggle", StringComparison.Ordinal), "ClientLayout must have mobile nav toggle button");
        Assert.IsTrue(Code.Contains("nav-open", StringComparison.Ordinal), "ClientLayout must toggle nav-open class for mobile menu");
        Assert.IsTrue(Code.Contains("RouteConstants.Tasks", StringComparison.Ordinal), "ClientLayout nav must link to tasks");
        Assert.IsTrue(Code.Contains("RouteConstants.Leaderboard", StringComparison.Ordinal), "ClientLayout nav must link to leaderboard");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client routes must use router with client layout as default and not found page fallback")]
    public void ClientRoutesMustUseRouterWithClientLayoutAsDefaultAndNotFoundPageFallback()
    {
        var Code = ReadSourceFile("PrTask.Client", "Components", "ClientRoutes.razor");
        Assert.IsTrue(Code.Contains("Router", StringComparison.Ordinal), "ClientRoutes must use Router component");
        Assert.IsTrue(Code.Contains("ClientLayout", StringComparison.Ordinal), "ClientRoutes must use ClientLayout as default layout");
        Assert.IsTrue(Code.Contains("NotFound", StringComparison.Ordinal), "ClientRoutes must have NotFound fallback");
        Assert.IsTrue(Code.Contains("Page Not Found", StringComparison.Ordinal), "ClientRoutes must display page not found message");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Shared ui app razor must define html structure with meta viewport and blazor script reference")]
    public void SharedUiAppRazorMustDefineHtmlStructureWithMetaViewportAndBlazorScriptReference()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Components", "App.razor");
        Assert.IsTrue(Code.Contains("viewport", StringComparison.Ordinal), "App.razor must have viewport meta tag");
        Assert.IsTrue(Code.Contains("PrTask", StringComparison.Ordinal), "App.razor must have PrTask in title");
        Assert.IsTrue(Code.Contains("blazor", StringComparison.OrdinalIgnoreCase), "App.razor must reference Blazor script");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Shared ui routes must use router with main layout default and focus on navigate for accessibility")]
    public void SharedUiRoutesMustUseRouterWithMainLayoutDefaultAndFocusOnNavigateForAccessibility()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Components", "Routes.razor");
        Assert.IsTrue(Code.Contains("Router", StringComparison.Ordinal), "Routes must use Router component");
        Assert.IsTrue(Code.Contains("MainLayout", StringComparison.Ordinal), "Routes must use MainLayout as default layout");
        Assert.IsTrue(Code.Contains("FocusOnNavigate", StringComparison.Ordinal), "Routes must use FocusOnNavigate for accessibility");
        Assert.IsTrue(Code.Contains("NotFound", StringComparison.Ordinal), "Routes must have NotFound fallback page");
    }
}
