namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("App razor must have head outlet component and blazor web js script for server rendering")]
    public void AppRazorMustHaveHeadOutletComponentAndBlazorWebJsScriptForServerRendering()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Components", "App.razor");
        Assert.IsTrue(Razor.Contains("HeadOutlet", StringComparison.Ordinal), "App.razor must include HeadOutlet component for title/meta tags");
        Assert.IsTrue(Razor.Contains("blazor.web.js", StringComparison.Ordinal), "App.razor must load blazor.web.js for server-side Blazor");
        Assert.IsTrue(Razor.Contains("<Routes />", StringComparison.Ordinal), "App.razor must render Routes component");
        Assert.IsTrue(Razor.Contains("Earn Money with Pull Requests", StringComparison.Ordinal), "App.razor must have descriptive page title");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("App razor must set base href and link shared ui css stylesheet for all pages")]
    public void AppRazorMustSetBaseHrefAndLinkSharedUiCssStylesheetForAllPages()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Components", "App.razor");
        Assert.IsTrue(Razor.Contains("<base href=\"/\" />", StringComparison.Ordinal), "App.razor must set base href to root");
        Assert.IsTrue(Razor.Contains("_content/PrTask.SharedUI/css/app.css", StringComparison.Ordinal), "App.razor must link SharedUI CSS stylesheet");
        Assert.IsTrue(Razor.Contains("lang=\"en\"", StringComparison.Ordinal), "App.razor must set language to English");
        Assert.IsTrue(Razor.Contains("charset=\"utf-8\"", StringComparison.Ordinal), "App.razor must set UTF-8 charset");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Routes razor must use focus on navigate with h1 selector for accessibility page transitions")]
    public void RoutesRazorMustUseFocusOnNavigateWithH1SelectorForAccessibilityPageTransitions()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Components", "Routes.razor");
        Assert.IsTrue(Razor.Contains("FocusOnNavigate", StringComparison.Ordinal), "Routes must use FocusOnNavigate for accessibility");
        Assert.IsTrue(Razor.Contains("Selector=\"h1\"", StringComparison.Ordinal), "Routes must focus on h1 elements after navigation");
        Assert.IsTrue(Razor.Contains("MainLayout", StringComparison.Ordinal), "Routes must use MainLayout as default layout");
        Assert.IsTrue(Razor.Contains("RouteView", StringComparison.Ordinal), "Routes must use RouteView for page rendering");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Routes razor must have not found handler showing page not found message with main layout")]
    public void RoutesRazorMustHaveNotFoundHandlerShowingPageNotFoundMessageWithMainLayout()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Components", "Routes.razor");
        Assert.IsTrue(Razor.Contains("NotFound", StringComparison.Ordinal), "Routes must handle NotFound state");
        Assert.IsTrue(Razor.Contains("Page Not Found", StringComparison.Ordinal), "Routes must display Page Not Found heading");
        Assert.IsTrue(Razor.Contains("LayoutView", StringComparison.Ordinal), "Routes NotFound must use LayoutView wrapper");
        Assert.IsTrue(Razor.Contains("could not be found", StringComparison.Ordinal), "Routes must explain page not found to user");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Main layout must inherit layout component base and render nav menu above page content")]
    public void MainLayoutMustInheritLayoutComponentBaseAndRenderNavMenuAbovePageContent()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Components", "MainLayout.razor");
        Assert.IsTrue(Razor.Contains("@inherits LayoutComponentBase", StringComparison.Ordinal), "MainLayout must inherit LayoutComponentBase");
        Assert.IsTrue(Razor.Contains("<NavMenu />", StringComparison.Ordinal), "MainLayout must render NavMenu component");
        Assert.IsTrue(Razor.Contains("page-content", StringComparison.Ordinal), "MainLayout must use page-content class for main area");
        Assert.IsTrue(Razor.Contains("@Body", StringComparison.Ordinal), "MainLayout must render page body content");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Nav menu must have hamburger toggle button and nav brand link to home page route")]
    public void NavMenuMustHaveHamburgerToggleButtonAndNavBrandLinkToHomePageRoute()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(Razor.Contains("nav-toggle", StringComparison.Ordinal), "NavMenu must have mobile hamburger toggle button");
        Assert.IsTrue(Razor.Contains("nav-brand", StringComparison.Ordinal), "NavMenu must have brand link");
        Assert.IsTrue(Razor.Contains("nav-open", StringComparison.Ordinal), "NavMenu must toggle nav-open class for mobile menu");
        Assert.IsTrue(Razor.Contains("nav-links", StringComparison.Ordinal), "NavMenu must have nav-links container");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Nav menu must have links to all main platform pages including download and settings")]
    public void NavMenuMustHaveLinksToAllMainPlatformPagesIncludingDownloadAndSettings()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(Razor.Contains("/tasks", StringComparison.Ordinal), "NavMenu must link to tasks page");
        Assert.IsTrue(Razor.Contains("/leaderboard", StringComparison.Ordinal), "NavMenu must link to leaderboard page");
        Assert.IsTrue(Razor.Contains("/download", StringComparison.Ordinal), "NavMenu must link to download page");
        Assert.IsTrue(Razor.Contains("/settings", StringComparison.Ordinal), "NavMenu must link to settings page");
        Assert.IsTrue(Razor.Contains("/dashboard", StringComparison.Ordinal), "NavMenu must link to dashboard page");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Nav menu must have links to all legal pages including dmca accessibility and licenses")]
    public void NavMenuMustHaveLinksToAllLegalPagesIncludingDmcaAccessibilityAndLicenses()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(Razor.Contains("/legal/dmca", StringComparison.Ordinal), "NavMenu must link to DMCA page");
        Assert.IsTrue(Razor.Contains("/legal/accessibility", StringComparison.Ordinal), "NavMenu must link to accessibility page");
        Assert.IsTrue(Razor.Contains("/legal/licenses", StringComparison.Ordinal), "NavMenu must link to licenses page");
        Assert.IsTrue(Razor.Contains("/legal/cookie-policy", StringComparison.Ordinal), "NavMenu must link to cookie policy page");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Nav menu must have clear cache link and inject js runtime for theme and auth interop")]
    public void NavMenuMustHaveClearCacheLinkAndInjectJsRuntimeForThemeAndAuthInterop()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(Razor.Contains("clear-cache.html", StringComparison.Ordinal), "NavMenu must have clear cache and reload link");
        Assert.IsTrue(Razor.Contains("IJSRuntime", StringComparison.Ordinal), "NavMenu must inject IJSRuntime for JS interop");
        Assert.IsTrue(Razor.Contains("OnAfterRenderAsync", StringComparison.Ordinal), "NavMenu must initialize on first render");
        Assert.IsTrue(Razor.Contains("StateHasChanged", StringComparison.Ordinal), "NavMenu must call StateHasChanged after async init");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Nav menu must show nav user span and sign out button when authenticated via js interop")]
    public void NavMenuMustShowNavUserSpanAndSignOutButtonWhenAuthenticatedViaJsInterop()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(Razor.Contains("nav-user", StringComparison.Ordinal), "NavMenu must have nav-user class for authenticated user display");
        Assert.IsTrue(Razor.Contains("CurrentUser", StringComparison.Ordinal), "NavMenu must display current username");
        Assert.IsTrue(Razor.Contains("nav-login", StringComparison.Ordinal), "NavMenu must have nav-login class for sign in/out button");
        Assert.IsTrue(Razor.Contains("Sign In", StringComparison.Ordinal), "NavMenu must show Sign In when unauthenticated");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Footer section must have footer content with brand and two footer column sections")]
    public void FooterSectionMustHaveFooterContentWithBrandAndTwoFooterColumnSections()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Components", "FooterSection.razor");
        Assert.IsTrue(Razor.Contains("site-footer", StringComparison.Ordinal), "Footer must use site-footer class");
        Assert.IsTrue(Razor.Contains("footer-content", StringComparison.Ordinal), "Footer must have footer-content container");
        Assert.IsTrue(Razor.Contains("footer-column", StringComparison.Ordinal), "Footer must have footer-column sections");
        Assert.IsTrue(Razor.Contains("footer-links", StringComparison.Ordinal), "Footer must have footer-links section");
        Assert.IsTrue(Razor.Contains("footer-logo", StringComparison.Ordinal), "Footer must have footer-logo span");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Footer section must have platform heading with browse tasks leaderboard how it works pricing links")]
    public void FooterSectionMustHavePlatformHeadingWithBrowseTasksLeaderboardHowItWorksPricingLinks()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Components", "FooterSection.razor");
        Assert.IsTrue(Razor.Contains("Platform", StringComparison.Ordinal), "Footer must have Platform column heading");
        Assert.IsTrue(Razor.Contains("Browse Tasks", StringComparison.Ordinal), "Footer must link to Browse Tasks");
        Assert.IsTrue(Razor.Contains("Leaderboard", StringComparison.Ordinal), "Footer must link to Leaderboard");
        Assert.IsTrue(Razor.Contains("How It Works", StringComparison.Ordinal), "Footer must link to How It Works");
        Assert.IsTrue(Razor.Contains("Pricing", StringComparison.Ordinal), "Footer must link to Pricing");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Footer section must display 2026 copyright year and earn money with pull requests tagline")]
    public void FooterSectionMustDisplay2026CopyrightYearAndEarnMoneyWithPullRequestsTagline()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Components", "FooterSection.razor");
        Assert.IsTrue(Razor.Contains("2026", StringComparison.Ordinal), "Footer must show 2026 copyright year");
        Assert.IsTrue(Razor.Contains("All rights reserved", StringComparison.Ordinal), "Footer must include all rights reserved");
        Assert.IsTrue(Razor.Contains("Earn money with pull requests", StringComparison.Ordinal), "Footer must show platform tagline");
        Assert.IsTrue(Razor.Contains("footer-bottom", StringComparison.Ordinal), "Footer must have footer-bottom section");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client layout must use route constants for all navigation links instead of hardcoded paths")]
    public void ClientLayoutMustUseRouteConstantsForAllNavigationLinksInsteadOfHardcodedPaths()
    {
        var Razor = ReadSourceFile("PrTask.Client", "Components", "ClientLayout.razor");
        Assert.IsTrue(Razor.Contains("RouteConstants.Tasks", StringComparison.Ordinal), "ClientLayout nav must use RouteConstants.Tasks");
        Assert.IsTrue(Razor.Contains("RouteConstants.Leaderboard", StringComparison.Ordinal), "ClientLayout nav must use RouteConstants.Leaderboard");
        Assert.IsTrue(Razor.Contains("RouteConstants.Dashboard", StringComparison.Ordinal), "ClientLayout nav must use RouteConstants.Dashboard");
        Assert.IsTrue(Razor.Contains("RouteConstants.Download", StringComparison.Ordinal), "ClientLayout nav must use RouteConstants.Download");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client layout must use route constants for legal page links and auth endpoints")]
    public void ClientLayoutMustUseRouteConstantsForLegalPageLinksAndAuthEndpoints()
    {
        var Razor = ReadSourceFile("PrTask.Client", "Components", "ClientLayout.razor");
        Assert.IsTrue(Razor.Contains("RouteConstants.Terms", StringComparison.Ordinal), "ClientLayout nav must use RouteConstants.Terms");
        Assert.IsTrue(Razor.Contains("RouteConstants.Privacy", StringComparison.Ordinal), "ClientLayout nav must use RouteConstants.Privacy");
        Assert.IsTrue(Razor.Contains("RouteConstants.ApiAuthMe", StringComparison.Ordinal), "ClientLayout must check auth via RouteConstants.ApiAuthMe");
        Assert.IsTrue(Razor.Contains("RouteConstants.ApiAuthLogout", StringComparison.Ordinal), "ClientLayout must use RouteConstants.ApiAuthLogout for sign out");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client layout must check auth state in on initialized async and show username when logged in")]
    public void ClientLayoutMustCheckAuthStateInOnInitializedAsyncAndShowUsernameWhenLoggedIn()
    {
        var Razor = ReadSourceFile("PrTask.Client", "Components", "ClientLayout.razor");
        Assert.IsTrue(Razor.Contains("OnInitializedAsync", StringComparison.Ordinal), "ClientLayout must override OnInitializedAsync for auth check");
        Assert.IsTrue(Razor.Contains("IsLoggedIn", StringComparison.Ordinal), "ClientLayout must track login state with IsLoggedIn");
        Assert.IsTrue(Razor.Contains("sealed class AuthUser", StringComparison.Ordinal), "ClientLayout must define sealed AuthUser for deserialization");
        Assert.IsTrue(Razor.Contains("nav-logout", StringComparison.Ordinal), "ClientLayout must have nav-logout class for sign out link");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client routes must use router with client layout and not found page fallback")]
    public void ClientRoutesMustUseRouterWithClientLayoutAndNotFoundPageFallback()
    {
        var Razor = ReadSourceFile("PrTask.Client", "Components", "ClientRoutes.razor");
        Assert.IsTrue(Razor.Contains("ClientLayout", StringComparison.Ordinal), "ClientRoutes must use ClientLayout as default");
        Assert.IsTrue(Razor.Contains("Page Not Found", StringComparison.Ordinal), "ClientRoutes must show Page Not Found message");
        Assert.IsTrue(Razor.Contains("Router", StringComparison.Ordinal), "ClientRoutes must use Router component");
        Assert.IsTrue(Razor.Contains("RouteView", StringComparison.Ordinal), "ClientRoutes must use RouteView for rendering");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Interop js must define prtask namespace with clipboard scroll and timezone utility functions")]
    public void InteropJsMustDefinePrtaskNamespaceWithClipboardScrollAndTimezoneUtilityFunctions()
    {
        var Js = ReadRootFile("scripts", "interop.js");
        Assert.IsTrue(Js.Contains("window.PrTask", StringComparison.Ordinal), "Interop must define window.PrTask namespace");
        Assert.IsTrue(Js.Contains("copyToClipboard", StringComparison.Ordinal), "Interop must have copyToClipboard function");
        Assert.IsTrue(Js.Contains("scrollToTop", StringComparison.Ordinal), "Interop must have scrollToTop function");
        Assert.IsTrue(Js.Contains("getTimezoneOffset", StringComparison.Ordinal), "Interop must have getTimezoneOffset function");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Interop js must use navigator clipboard api and smooth scroll behavior for user experience")]
    public void InteropJsMustUseNavigatorClipboardApiAndSmoothScrollBehaviorForUserExperience()
    {
        var Js = ReadRootFile("scripts", "interop.js");
        Assert.IsTrue(Js.Contains("navigator.clipboard.writeText", StringComparison.Ordinal), "Interop clipboard must use navigator.clipboard API");
        Assert.IsTrue(Js.Contains("behavior: \"smooth\"", StringComparison.Ordinal), "Interop scroll must use smooth behavior");
        Assert.IsTrue(Js.Contains("use strict", StringComparison.Ordinal), "Interop must use strict mode");
    }
}
