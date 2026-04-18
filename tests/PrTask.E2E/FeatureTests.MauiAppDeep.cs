namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui layout must inherit layout component base and inject navigation manager for routing")]
    public void MauiLayoutMustInheritLayoutComponentBaseAndInjectNavigationManagerForRouting()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Components", "MauiLayout.razor");
        Assert.IsTrue(Code.Contains("@inherits LayoutComponentBase", StringComparison.Ordinal), "MauiLayout must inherit LayoutComponentBase");
        Assert.IsTrue(Code.Contains("@inject NavigationManager NavigationManager", StringComparison.Ordinal), "MauiLayout must inject NavigationManager");
        Assert.IsTrue(Code.Contains("PrTask.SharedUI.Components.NavMenu", StringComparison.Ordinal), "MauiLayout must render SharedUI NavMenu component");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui layout must check session from preferences on initialized and show auth bar when logged in")]
    public void MauiLayoutMustCheckSessionFromPreferencesOnInitializedAndShowAuthBarWhenLoggedIn()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Components", "MauiLayout.razor");
        Assert.IsTrue(Code.Contains("Preferences.Default.Get(\"session\", string.Empty)", StringComparison.Ordinal), "MauiLayout must read session from Preferences");
        Assert.IsTrue(Code.Contains("Preferences.Default.Get(\"username\", \"Dashboard\")", StringComparison.Ordinal), "MauiLayout must read username with Dashboard default");
        Assert.IsTrue(Code.Contains("maui-auth-bar", StringComparison.Ordinal), "MauiLayout must use maui-auth-bar class for auth state");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui layout sign out must remove session and username from preferences and navigate to login")]
    public void MauiLayoutSignOutMustRemoveSessionAndUsernameFromPreferencesAndNavigateToLogin()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Components", "MauiLayout.razor");
        Assert.IsTrue(Code.Contains("Preferences.Default.Remove(\"session\")", StringComparison.Ordinal), "MauiLayout signout must remove session preference");
        Assert.IsTrue(Code.Contains("Preferences.Default.Remove(\"username\")", StringComparison.Ordinal), "MauiLayout signout must remove username preference");
        Assert.IsTrue(Code.Contains("NavigationManager.NavigateTo(\"/login\")", StringComparison.Ordinal), "MauiLayout signout must navigate to login");
        Assert.IsTrue(Code.Contains("IsLoggedIn = false", StringComparison.Ordinal), "MauiLayout signout must set IsLoggedIn to false");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui routes must use router with maui layout as default layout in found context route view")]
    public void MauiRoutesMustUseRouterWithMauiLayoutAsDefaultLayoutInFoundContextRouteView()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Routes.razor");
        Assert.IsTrue(Code.Contains("typeof(Components.MauiLayout)", StringComparison.Ordinal), "MauiRoutes must use MauiLayout as DefaultLayout");
        Assert.IsTrue(Code.Contains("typeof(Routes).Assembly", StringComparison.Ordinal), "MauiRoutes must use typeof(Routes).Assembly");
        Assert.IsTrue(Code.Contains("RouteView", StringComparison.Ordinal), "MauiRoutes must use RouteView component");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui app must extend microsoft maui controls application and create window with main page")]
    public void MauiAppMustExtendMicrosoftMauiControlsApplicationAndCreateWindowWithMainPage()
    {
        var Code = ReadSourceFile("PrTask.Maui", "App.xaml.cs");
        Assert.IsTrue(Code.Contains("Microsoft.Maui.Controls.Application", StringComparison.Ordinal), "PrTaskApp must extend Maui Application");
        Assert.IsTrue(Code.Contains("CreateWindow(IActivationState? ActivationState)", StringComparison.Ordinal), "PrTaskApp must override CreateWindow");
        Assert.IsTrue(Code.Contains("new(new MainPage())", StringComparison.Ordinal), "PrTaskApp must create Window with new MainPage");
        Assert.IsTrue(Code.Contains("partial class PrTaskApp", StringComparison.Ordinal), "PrTaskApp must be partial class");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Main page url loading must allow google googleapis github microsoft and okta domains in web view")]
    public void MainPageUrlLoadingMustAllowGoogleGoogleapisGitHubMicrosoftAndOktaDomainsInWebView()
    {
        var Code = ReadSourceFile("PrTask.Maui", "MainPage.xaml.cs");
        Assert.IsTrue(Code.Contains(".google.com", StringComparison.Ordinal), "MainPage must allow google.com domains");
        Assert.IsTrue(Code.Contains(".googleapis.com", StringComparison.Ordinal), "MainPage must allow googleapis.com domains");
        Assert.IsTrue(Code.Contains("github.com", StringComparison.Ordinal), "MainPage must allow github.com domain");
        Assert.IsTrue(Code.Contains(".microsoftonline.com", StringComparison.Ordinal), "MainPage must allow microsoftonline.com domains");
        Assert.IsTrue(Code.Contains(".okta.com", StringComparison.Ordinal), "MainPage must allow okta.com domains");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Main page url loading must use open in web view strategy and ordinal ignore case host comparison")]
    public void MainPageUrlLoadingMustUseOpenInWebViewStrategyAndOrdinalIgnoreCaseHostComparison()
    {
        var Code = ReadSourceFile("PrTask.Maui", "MainPage.xaml.cs");
        Assert.IsTrue(Code.Contains("UrlLoadingStrategy.OpenInWebView", StringComparison.Ordinal), "MainPage must use OpenInWebView strategy for SSO");
        Assert.IsTrue(Code.Contains("StringComparison.OrdinalIgnoreCase", StringComparison.Ordinal), "MainPage must use OrdinalIgnoreCase for host comparison");
        Assert.IsTrue(Code.Contains("AppConstants.AppDomain", StringComparison.Ordinal), "MainPage must compare against AppConstants.AppDomain");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui program must add maui blazor web view service and configure android status bar lifecycle events")]
    public void MauiProgramMustAddMauiBlazorWebViewServiceAndConfigureAndroidStatusBarLifecycleEvents()
    {
        var Code = ReadSourceFile("PrTask.Maui", "MauiProgram.cs");
        Assert.IsTrue(Code.Contains("AddMauiBlazorWebView()", StringComparison.Ordinal), "MauiProgram must add Blazor WebView service");
        Assert.IsTrue(Code.Contains("ConfigureLifecycleEvents(ConfigureAndroidStatusBar)", StringComparison.Ordinal), "MauiProgram must configure lifecycle events");
        Assert.IsTrue(Code.Contains("WindowCompat.SetDecorFitsSystemWindows(Activity.Window, true)", StringComparison.Ordinal), "MauiProgram must set decor fits system windows");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Main activity must use single top launch mode with splash theme and exported true attribute")]
    public void MainActivityMustUseSingleTopLaunchModeWithSplashThemeAndExportedTrueAttribute()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Platforms", "Android", "MainActivity.cs");
        Assert.IsTrue(Code.Contains("LaunchMode.SingleTop", StringComparison.Ordinal), "MainActivity must use SingleTop launch mode");
        Assert.IsTrue(Code.Contains("Maui.SplashTheme", StringComparison.Ordinal), "MainActivity must use Maui.SplashTheme");
        Assert.IsTrue(Code.Contains("MainLauncher = true", StringComparison.Ordinal), "MainActivity must be main launcher");
        Assert.IsTrue(Code.Contains("Exported = true", StringComparison.Ordinal), "MainActivity must be exported");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Main activity must handle screen size orientation ui mode and density configuration changes")]
    public void MainActivityMustHandleScreenSizeOrientationUiModeAndDensityConfigurationChanges()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Platforms", "Android", "MainActivity.cs");
        Assert.IsTrue(Code.Contains("ConfigChanges.ScreenSize", StringComparison.Ordinal), "MainActivity must handle ScreenSize changes");
        Assert.IsTrue(Code.Contains("ConfigChanges.Orientation", StringComparison.Ordinal), "MainActivity must handle Orientation changes");
        Assert.IsTrue(Code.Contains("ConfigChanges.UiMode", StringComparison.Ordinal), "MainActivity must handle UiMode changes");
        Assert.IsTrue(Code.Contains("ConfigChanges.Density", StringComparison.Ordinal), "MainActivity must handle Density changes");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth callback activity must use no history and single top launch with web authenticator callback base")]
    public void AuthCallbackActivityMustUseNoHistoryAndSingleTopLaunchWithWebAuthenticatorCallbackBase()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Platforms", "Android", "AuthCallbackActivity.cs");
        Assert.IsTrue(Code.Contains("NoHistory = true", StringComparison.Ordinal), "AuthCallbackActivity must set NoHistory to true");
        Assert.IsTrue(Code.Contains("LaunchMode.SingleTop", StringComparison.Ordinal), "AuthCallbackActivity must use SingleTop launch mode");
        Assert.IsTrue(Code.Contains("WebAuthenticatorCallbackActivity", StringComparison.Ordinal), "AuthCallbackActivity must extend WebAuthenticatorCallbackActivity");
        Assert.IsTrue(Code.Contains("Exported = true", StringComparison.Ordinal), "AuthCallbackActivity must be exported for deep links");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Shared ui imports must declare using statements for components routing web and js interop")]
    public void SharedUiImportsMustDeclareUsingStatementsForComponentsRoutingWebAndJsInterop()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "_Imports.razor");
        Assert.IsTrue(Code.Contains("Microsoft.AspNetCore.Components", StringComparison.Ordinal), "SharedUI _Imports must use Components namespace");
        Assert.IsTrue(Code.Contains("Microsoft.AspNetCore.Components.Routing", StringComparison.Ordinal), "SharedUI _Imports must use Routing namespace");
        Assert.IsTrue(Code.Contains("Microsoft.JSInterop", StringComparison.Ordinal), "SharedUI _Imports must use JSInterop namespace");
        Assert.IsTrue(Code.Contains("PrTask.SharedUI.Components", StringComparison.Ordinal), "SharedUI _Imports must use SharedUI.Components");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui imports must declare using statements for maui components domain constants and routing")]
    public void MauiImportsMustDeclareUsingStatementsForMauiComponentsDomainConstantsAndRouting()
    {
        var Code = ReadSourceFile("PrTask.Maui", "_Imports.razor");
        Assert.IsTrue(Code.Contains("PrTask.Maui.Components", StringComparison.Ordinal), "Maui _Imports must use Maui.Components");
        Assert.IsTrue(Code.Contains("PrTask.Domain.Constants", StringComparison.Ordinal), "Maui _Imports must use Domain.Constants");
        Assert.IsTrue(Code.Contains("Microsoft.AspNetCore.Components.Web", StringComparison.Ordinal), "Maui _Imports must use Components.Web");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui task detail wrapper must pass task id parameter to shared ui task detail page component")]
    public void MauiTaskDetailWrapperMustPassTaskIdParameterToSharedUiTaskDetailPageComponent()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Pages", "MauiTaskDetailPage.razor");
        Assert.IsTrue(Code.Contains("PrTask.SharedUI.Pages.TaskDetailPage", StringComparison.Ordinal), "Maui TaskDetail must reference SharedUI TaskDetailPage");
        Assert.IsTrue(Code.Contains("TaskId=\"@TaskId\"", StringComparison.Ordinal), "Maui TaskDetail must pass TaskId parameter");
        Assert.IsTrue(Code.Contains("[Parameter]", StringComparison.Ordinal), "Maui TaskDetail must have Parameter attribute");
    }
}
