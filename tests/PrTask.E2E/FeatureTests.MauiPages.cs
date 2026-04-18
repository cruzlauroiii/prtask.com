namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui login page must use web authenticator default authenticate async for native sso flow")]
    public void MauiLoginPageMustUseWebAuthenticatorDefaultAuthenticateAsyncForNativeSsoFlow()
    {
        var Razor = ReadSourceFile("PrTask.Maui", "Pages", "MauiLoginPage.razor");
        Assert.IsTrue(Razor.Contains("WebAuthenticator.Default.AuthenticateAsync", StringComparison.Ordinal), "Maui login must call WebAuthenticator.Default.AuthenticateAsync");
        Assert.IsTrue(Razor.Contains("LoginWithProviderAsync", StringComparison.Ordinal), "Maui login must define LoginWithProviderAsync method");
        Assert.IsTrue(Razor.Contains("NavigationManager", StringComparison.Ordinal), "Maui login must inject NavigationManager for post-auth redirect");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui login page must build auth url with prtask domain and platform android query parameter")]
    public void MauiLoginPageMustBuildAuthUrlWithPrtaskDomainAndPlatformAndroidQueryParameter()
    {
        var Razor = ReadSourceFile("PrTask.Maui", "Pages", "MauiLoginPage.razor");
        Assert.IsTrue(Razor.Contains("AppConstants.AppDomain", StringComparison.Ordinal), "Maui login must use AppDomain for auth URL base");
        Assert.IsTrue(Razor.Contains("platform=android", StringComparison.Ordinal), "Maui login must pass platform=android parameter");
        Assert.IsTrue(Razor.Contains("com.prtask.app://auth", StringComparison.Ordinal), "Maui login must use custom scheme callback URI");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui login page must store session and username in preferences after successful authentication")]
    public void MauiLoginPageMustStoreSessionAndUsernameInPreferencesAfterSuccessfulAuthentication()
    {
        var Razor = ReadSourceFile("PrTask.Maui", "Pages", "MauiLoginPage.razor");
        Assert.IsTrue(Razor.Contains("Preferences.Default.Set(\"session\"", StringComparison.Ordinal), "Maui login must persist session in Preferences");
        Assert.IsTrue(Razor.Contains("Preferences.Default.Set(\"username\"", StringComparison.Ordinal), "Maui login must persist username in Preferences");
        Assert.IsTrue(Razor.Contains("RouteConstants.Dashboard", StringComparison.Ordinal), "Maui login must navigate to dashboard after auth");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui login page must show error message on authentication failure and clear on cancellation")]
    public void MauiLoginPageMustShowErrorMessageOnAuthenticationFailureAndClearOnCancellation()
    {
        var Razor = ReadSourceFile("PrTask.Maui", "Pages", "MauiLoginPage.razor");
        Assert.IsTrue(Razor.Contains("ErrorMessage", StringComparison.Ordinal), "Maui login must track error message state");
        Assert.IsTrue(Razor.Contains("TaskCanceledException", StringComparison.Ordinal), "Maui login must handle user cancellation");
        Assert.IsTrue(Razor.Contains("Ex.Message", StringComparison.Ordinal), "Maui login must display exception message on error");
        Assert.IsTrue(Razor.Contains("login-buttons", StringComparison.Ordinal), "Maui login must use login-buttons container");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui login page must have four sso provider buttons for google github azure and okta")]
    public void MauiLoginPageMustHaveFourSsoProviderButtonsForGoogleGithubAzureAndOkta()
    {
        var Razor = ReadSourceFile("PrTask.Maui", "Pages", "MauiLoginPage.razor");
        Assert.IsTrue(Razor.Contains("google-login", StringComparison.Ordinal), "Maui login must have Google login button");
        Assert.IsTrue(Razor.Contains("github-login", StringComparison.Ordinal), "Maui login must have GitHub login button");
        Assert.IsTrue(Razor.Contains("azure-login", StringComparison.Ordinal), "Maui login must have Azure login button");
        Assert.IsTrue(Razor.Contains("okta-login", StringComparison.Ordinal), "Maui login must have Okta login button");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui index html must have prtask sign out function using post method with include credentials")]
    public void MauiIndexHtmlMustHavePrtaskSignOutFunctionUsingPostMethodWithIncludeCredentials()
    {
        var Html = ReadSourceFile("PrTask.Maui", "wwwroot", "index.html");
        Assert.IsTrue(Html.Contains("prtaskSignOut", StringComparison.Ordinal), "Maui index must define prtaskSignOut function");
        Assert.IsTrue(Html.Contains("method: \"POST\"", StringComparison.Ordinal), "Maui sign out must use POST method");
        Assert.IsTrue(Html.Contains("credentials: \"include\"", StringComparison.Ordinal), "Maui sign out must include credentials");
        Assert.IsTrue(Html.Contains("api/auth/logout", StringComparison.Ordinal), "Maui sign out must call logout endpoint");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui index html must have prtask check auth function that fetches auth me and stores username")]
    public void MauiIndexHtmlMustHavePrtaskCheckAuthFunctionThatFetchesAuthMeAndStoresUsername()
    {
        var Html = ReadSourceFile("PrTask.Maui", "wwwroot", "index.html");
        Assert.IsTrue(Html.Contains("prtaskCheckAuth", StringComparison.Ordinal), "Maui index must define prtaskCheckAuth function");
        Assert.IsTrue(Html.Contains("api/auth/me", StringComparison.Ordinal), "Maui check auth must call auth/me endpoint");
        Assert.IsTrue(Html.Contains("prtaskSetUser", StringComparison.Ordinal), "Maui check auth must call prtaskSetUser");
        Assert.IsTrue(Html.Contains("prtaskGetUser", StringComparison.Ordinal), "Maui index must define prtaskGetUser function");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui index html must use blazor webview js with autostart false instead of webassembly js")]
    public void MauiIndexHtmlMustUseBlazorWebviewJsWithAutostartFalseInsteadOfWebassemblyJs()
    {
        var Html = ReadSourceFile("PrTask.Maui", "wwwroot", "index.html");
        Assert.IsTrue(Html.Contains("blazor.webview.js", StringComparison.Ordinal), "Maui index must load blazor.webview.js");
        Assert.IsTrue(Html.Contains("autostart=\"false\"", StringComparison.Ordinal), "Maui webview must use autostart false");
        Assert.IsFalse(Html.Contains("blazor.webassembly.js", StringComparison.Ordinal), "Maui index must not use blazor.webassembly.js");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui index html must have shared ui css link and prtask theme localStorage persistence")]
    public void MauiIndexHtmlMustHaveSharedUiCssLinkAndPrtaskThemeLocalStoragePersistence()
    {
        var Html = ReadSourceFile("PrTask.Maui", "wwwroot", "index.html");
        Assert.IsTrue(Html.Contains("_content/PrTask.SharedUI/css/app.css", StringComparison.Ordinal), "Maui index must link SharedUI CSS");
        Assert.IsTrue(Html.Contains("prtask-theme", StringComparison.Ordinal), "Maui index must use prtask-theme localStorage key");
        Assert.IsTrue(Html.Contains("data-theme", StringComparison.Ordinal), "Maui index must set data-theme attribute");
        Assert.IsTrue(Html.Contains("prtaskToggleTheme", StringComparison.Ordinal), "Maui index must define theme toggle function");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui home page wrapper must delegate to shared ui home component without custom code")]
    public void MauiHomePageWrapperMustDelegateToSharedUiHomeComponentWithoutCustomCode()
    {
        var Razor = ReadSourceFile("PrTask.Maui", "Pages", "MauiHomePage.razor");
        Assert.IsTrue(Razor.Contains("PrTask.SharedUI.Pages.Home", StringComparison.Ordinal), "Maui home must reference SharedUI Home");
        Assert.IsTrue(Razor.Contains("@page \"/\"", StringComparison.Ordinal), "Maui home must use root route");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui task list wrapper must delegate to shared ui task list component at tasks route")]
    public void MauiTaskListWrapperMustDelegateToSharedUiTaskListComponentAtTasksRoute()
    {
        var Razor = ReadSourceFile("PrTask.Maui", "Pages", "MauiTaskListPage.razor");
        Assert.IsTrue(Razor.Contains("PrTask.SharedUI.Pages.TaskList", StringComparison.Ordinal), "Maui task list must reference SharedUI TaskList");
        Assert.IsTrue(Razor.Contains("@page \"/tasks\"", StringComparison.Ordinal), "Maui task list must use tasks route");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui legal wrapper pages must delegate to shared ui terms and privacy legal pages")]
    public void MauiLegalWrapperPagesMustDelegateToSharedUiTermsAndPrivacyLegalPages()
    {
        var Terms = ReadSourceFile("PrTask.Maui", "Pages", "Legal", "MauiTermsPage.razor");
        var Privacy = ReadSourceFile("PrTask.Maui", "Pages", "Legal", "MauiPrivacyPage.razor");
        Assert.IsTrue(Terms.Contains("PrTask.SharedUI.Pages.Legal.TermsPage", StringComparison.Ordinal), "Maui terms must delegate to SharedUI TermsPage");
        Assert.IsTrue(Privacy.Contains("PrTask.SharedUI.Pages.Legal.PrivacyPage", StringComparison.Ordinal), "Maui privacy must delegate to SharedUI PrivacyPage");
        Assert.IsTrue(Terms.Contains("/legal/terms", StringComparison.Ordinal), "Maui terms must use /legal/terms route");
    }
}
