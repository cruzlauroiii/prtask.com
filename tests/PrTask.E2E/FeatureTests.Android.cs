namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Android")]
    [DisplayName("Nav menu scss must have safe area inset top padding for android notification bar overlap")]
    public void NavMenuScssMustHaveSafeAreaInsetTopPaddingForAndroidNotificationBarOverlap()
    {
        var Scss = ReadSourceFile("PrTask.SharedUI", "Styles", "app.scss");
        Assert.IsTrue(
            Scss.Contains("safe-area-inset-top", StringComparison.Ordinal),
            "Nav menu SCSS must use env(safe-area-inset-top) to add space on top for Android notification bar");
    }
    [TestMethod, TestCategory("Android")]
    [DisplayName("Maui index html must have viewport fit cover meta tag for safe area rendering")]
    public void MauiIndexHtmlMustHaveViewportFitCoverMetaTagForSafeAreaRendering()
    {
        var Html = ReadSourceFile("PrTask.Maui", "wwwroot", "index.html");
        Assert.IsTrue(
            Html.Contains("viewport-fit=cover", StringComparison.Ordinal),
            "MAUI index.html must include viewport-fit=cover in viewport meta tag for safe area inset to work on Android");
    }
    [TestMethod, TestCategory("Android")]
    [DisplayName("Nav menu must have conditional auth state rendering with logout when authenticated")]
    public void NavMenuMustHaveConditionalAuthStateRenderingWithLogoutWhenAuthenticated()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(
            Razor.Contains("logout", StringComparison.OrdinalIgnoreCase) || Razor.Contains("Sign Out", StringComparison.OrdinalIgnoreCase),
            "NavMenu must have a logout or sign out option that appears when user is authenticated");
    }
    [TestMethod, TestCategory("Android")]
    [DisplayName("Nav menu must change sign in button state when user is authenticated via sso")]
    public void NavMenuMustChangeSignInButtonStateWhenUserIsAuthenticatedViaSso()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(
            Razor.Contains("IsAuthenticated", StringComparison.Ordinal)
            || Razor.Contains("AuthorizeView", StringComparison.Ordinal)
            || Razor.Contains("CurrentUser", StringComparison.Ordinal),
            "NavMenu must track authentication state to toggle Sign In button visibility after SSO login");
    }
    [TestMethod, TestCategory("Android")]
    [DisplayName("Clear cache page must exist and redirect back to home for android refresh functionality")]
    public void ClearCachePageMustExistAndRedirectBackToHomeForAndroidRefreshFunctionality()
    {
        Assert.IsTrue(
            SourceFileExists("PrTask.Maui", "wwwroot", "clear-cache.html"),
            "clear-cache.html must exist in MAUI wwwroot for refresh functionality");
        var Html = ReadSourceFile("PrTask.Maui", "wwwroot", "clear-cache.html");
        Assert.IsTrue(
            Html.Contains("location", StringComparison.OrdinalIgnoreCase),
            "clear-cache.html must redirect back to home after clearing cache");
    }
    [TestMethod, TestCategory("Android")]
    [DisplayName("Nav menu refresh link must trigger actual page reload not just navigation")]
    public void NavMenuRefreshLinkMustTriggerActualPageReloadNotJustNavigation()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Components", "NavMenu.razor");
        var HasRefreshLink = Razor.Contains("clear-cache", StringComparison.OrdinalIgnoreCase)
            || Razor.Contains("&#x21bb;", StringComparison.Ordinal)
            || Razor.Contains("refresh", StringComparison.OrdinalIgnoreCase);
        Assert.IsTrue(HasRefreshLink, "NavMenu must have a refresh mechanism that clears cache and reloads the app");
        var ClearCacheHtml = ReadSourceFile("PrTask.Maui", "wwwroot", "clear-cache.html");
        Assert.IsTrue(
            ClearCacheHtml.Contains("caches", StringComparison.Ordinal),
            "Refresh page must clear service worker caches for proper reload on Android");
    }
    [TestMethod, TestCategory("Android")]
    [DisplayName("Maui main page must handle url loading for sso provider domains")]
    public void MauiMainPageMustHandleUrlLoadingForSsoProviderDomains()
    {
        var Code = ReadSourceFile("PrTask.Maui", "MainPage.xaml.cs");
        Assert.IsTrue(Code.Contains("google.com", StringComparison.Ordinal), "Must handle Google SSO URLs");
        Assert.IsTrue(Code.Contains("github.com", StringComparison.Ordinal), "Must handle GitHub SSO URLs");
        Assert.IsTrue(Code.Contains("microsoftonline.com", StringComparison.Ordinal), "Must handle Azure SSO URLs");
        Assert.IsTrue(Code.Contains("okta.com", StringComparison.Ordinal), "Must handle Okta SSO URLs");
    }
    [TestMethod, TestCategory("Android")]
    [DisplayName("Maui program must configure android lifecycle to set decor fits system windows for status bar")]
    public void MauiProgramMustConfigureAndroidLifecycleToSetDecorFitsSystemWindowsForStatusBar()
    {
        var Code = ReadSourceFile("PrTask.Maui", "MauiProgram.cs");
        Assert.IsTrue(
            Code.Contains("SetDecorFitsSystemWindows", StringComparison.Ordinal),
            "MauiProgram must call SetDecorFitsSystemWindows(true) because CSS env(safe-area-inset-top) is broken on Android WebView (dotnet/maui#14894)");
    }
    [TestMethod, TestCategory("Android")]
    [DisplayName("Maui program must use configure lifecycle events for android status bar padding setup")]
    public void MauiProgramMustUseConfigureLifecycleEventsForAndroidStatusBarPaddingSetup()
    {
        var Code = ReadSourceFile("PrTask.Maui", "MauiProgram.cs");
        Assert.IsTrue(
            Code.Contains("ConfigureLifecycleEvents", StringComparison.Ordinal),
            "MauiProgram must use ConfigureLifecycleEvents to handle Android status bar insets at startup");
    }
}
