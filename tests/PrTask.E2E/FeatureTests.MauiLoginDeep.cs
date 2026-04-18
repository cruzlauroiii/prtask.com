namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui login page must inject navigation manager and use web authenticator for oauth flow")]
    public void MauiLoginPageMustInjectNavigationManagerAndUseWebAuthenticatorForOauthFlow()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Pages", "MauiLoginPage.razor");
        Assert.IsTrue(Code.Contains("@inject NavigationManager NavigationManager", StringComparison.Ordinal), "MauiLogin must inject NavigationManager");
        Assert.IsTrue(Code.Contains("WebAuthenticator.Default.AuthenticateAsync", StringComparison.Ordinal), "MauiLogin must use WebAuthenticator for SSO");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui login must build auth url with site base app domain and platform android query parameter")]
    public void MauiLoginMustBuildAuthUrlWithSiteBaseAppDomainAndPlatformAndroidQueryParameter()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Pages", "MauiLoginPage.razor");
        Assert.IsTrue(Code.Contains("$\"https://{AppConstants.AppDomain}\"", StringComparison.Ordinal), "MauiLogin SiteBase must use AppConstants.AppDomain");
        Assert.IsTrue(Code.Contains("$\"{SiteBase}{AuthRoute}?platform=android\"", StringComparison.Ordinal), "MauiLogin must append platform=android to auth URL");
        Assert.IsTrue(Code.Contains("com.prtask.app://auth", StringComparison.Ordinal), "MauiLogin callback URI must be com.prtask.app://auth");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui login must store session and username in preferences after successful web authenticator result")]
    public void MauiLoginMustStoreSessionAndUsernameInPreferencesAfterSuccessfulWebAuthenticatorResult()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Pages", "MauiLoginPage.razor");
        Assert.IsTrue(Code.Contains("Result.Properties.TryGetValue(\"session\", out var Sid)", StringComparison.Ordinal), "MauiLogin must extract session from auth result properties");
        Assert.IsTrue(Code.Contains("Preferences.Default.Set(\"session\", Session)", StringComparison.Ordinal), "MauiLogin must store session in Preferences");
        Assert.IsTrue(Code.Contains("Result.Properties.TryGetValue(\"username\", out var Name)", StringComparison.Ordinal), "MauiLogin must extract username from auth result");
        Assert.IsTrue(Code.Contains("Preferences.Default.Set(\"username\", StoredUsername)", StringComparison.Ordinal), "MauiLogin must store username in Preferences");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui login must navigate to route constants dashboard after successful authentication flow")]
    public void MauiLoginMustNavigateToRouteConstantsDashboardAfterSuccessfulAuthenticationFlow()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Pages", "MauiLoginPage.razor");
        Assert.IsTrue(Code.Contains("NavigationManager.NavigateTo(RouteConstants.Dashboard)", StringComparison.Ordinal), "MauiLogin must navigate to Dashboard after auth");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui login must catch task cancelled exception and clear error message for user cancellation")]
    public void MauiLoginMustCatchTaskCancelledExceptionAndClearErrorMessageForUserCancellation()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Pages", "MauiLoginPage.razor");
        Assert.IsTrue(Code.Contains("catch (TaskCanceledException)", StringComparison.Ordinal), "MauiLogin must catch TaskCanceledException for user cancel");
        Assert.IsTrue(Code.Contains("ErrorMessage = string.Empty", StringComparison.Ordinal), "MauiLogin must clear ErrorMessage on cancellation");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui login must catch general exception and display error message text for authentication failures")]
    public void MauiLoginMustCatchGeneralExceptionAndDisplayErrorMessageTextForAuthenticationFailures()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Pages", "MauiLoginPage.razor");
        Assert.IsTrue(Code.Contains("catch (Exception Ex)", StringComparison.Ordinal), "MauiLogin must catch general Exception for auth failures");
        Assert.IsTrue(Code.Contains("ErrorMessage = Ex.Message", StringComparison.Ordinal), "MauiLogin must set ErrorMessage from exception");
        Assert.IsTrue(Code.Contains("color: red", StringComparison.Ordinal), "MauiLogin must display error in red color");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui login buttons must invoke login with provider async for all four oauth route constants")]
    public void MauiLoginButtonsMustInvokeLoginWithProviderAsyncForAllFourOauthRouteConstants()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Pages", "MauiLoginPage.razor");
        Assert.IsTrue(Code.Contains("LoginWithProviderAsync(RouteConstants.ApiAuthGoogle)", StringComparison.Ordinal), "MauiLogin must have Google login button");
        Assert.IsTrue(Code.Contains("LoginWithProviderAsync(RouteConstants.ApiAuthGitHub)", StringComparison.Ordinal), "MauiLogin must have GitHub login button");
        Assert.IsTrue(Code.Contains("LoginWithProviderAsync(RouteConstants.ApiAuthAzure)", StringComparison.Ordinal), "MauiLogin must have Azure login button");
        Assert.IsTrue(Code.Contains("LoginWithProviderAsync(RouteConstants.ApiAuthOkta)", StringComparison.Ordinal), "MauiLogin must have Okta login button");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui login callback uri must use static readonly uri with com prtask app custom scheme")]
    public void MauiLoginCallbackUriMustUseStaticReadonlyUriWithComPrtaskAppCustomScheme()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Pages", "MauiLoginPage.razor");
        Assert.IsTrue(Code.Contains("static readonly Uri CallbackUri = new(\"com.prtask.app://auth\")", StringComparison.Ordinal), "MauiLogin must define static CallbackUri with app scheme");
        Assert.IsTrue(Code.Contains("static readonly string SiteBase", StringComparison.Ordinal), "MauiLogin must define static SiteBase string");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui wrapper pages must delegate to shared ui components with matching route and parameter passing")]
    public void MauiWrapperPagesMustDelegateToSharedUiComponentsWithMatchingRouteAndParameterPassing()
    {
        var Dashboard = ReadSourceFile("PrTask.Maui", "Pages", "MauiDashboardPage.razor");
        Assert.IsTrue(Dashboard.Contains("PrTask.SharedUI.Pages.DashboardPage", StringComparison.Ordinal), "MauiDashboard must delegate to SharedUI DashboardPage");
        var Profile = ReadSourceFile("PrTask.Maui", "Pages", "MauiProfilePage.razor");
        Assert.IsTrue(Profile.Contains("UserId=\"@UserId\"", StringComparison.Ordinal), "MauiProfile must pass UserId parameter to SharedUI");
        var PrDetail = ReadSourceFile("PrTask.Maui", "Pages", "MauiPullRequestDetailPage.razor");
        Assert.IsTrue(PrDetail.Contains("PrId=\"@PrId\"", StringComparison.Ordinal), "MauiPrDetail must pass PrId parameter to SharedUI");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui simple wrapper pages must delegate to shared ui with correct page route annotations")]
    public void MauiSimpleWrapperPagesMustDelegateToSharedUiWithCorrectPageRouteAnnotations()
    {
        var Settings = ReadSourceFile("PrTask.Maui", "Pages", "MauiSettingsPage.razor");
        Assert.IsTrue(Settings.Contains("@page \"/settings\"", StringComparison.Ordinal), "MauiSettings must have /settings route");
        Assert.IsTrue(Settings.Contains("PrTask.SharedUI.Pages.SettingsPage", StringComparison.Ordinal), "MauiSettings must delegate to SharedUI");
        var CreateTask = ReadSourceFile("PrTask.Maui", "Pages", "Client", "MauiCreateTaskPage.razor");
        Assert.IsTrue(CreateTask.Contains("@page \"/client/create-task\"", StringComparison.Ordinal), "MauiCreateTask must have /client/create-task route");
        Assert.IsTrue(CreateTask.Contains("PrTask.SharedUI.Pages.Client.CreateTaskPage", StringComparison.Ordinal), "MauiCreateTask must delegate to SharedUI");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui deployment preview wrapper must pass deployment id parameter to shared ui component")]
    public void MauiDeploymentPreviewWrapperMustPassDeploymentIdParameterToSharedUiComponent()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Pages", "MauiDeploymentPreviewPage.razor");
        Assert.IsTrue(Code.Contains("@page \"/deployments/{DeploymentId}\"", StringComparison.Ordinal), "MauiDeploymentPreview must have route with DeploymentId");
        Assert.IsTrue(Code.Contains("DeploymentId=\"@DeploymentId\"", StringComparison.Ordinal), "MauiDeploymentPreview must pass DeploymentId parameter");
        Assert.IsTrue(Code.Contains("PrTask.SharedUI.Pages.DeploymentPreviewPage", StringComparison.Ordinal), "MauiDeploymentPreview must delegate to SharedUI");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Main application must extend maui application with nint handle and jni handle ownership constructor")]
    public void MainApplicationMustExtendMauiApplicationWithNintHandleAndJniHandleOwnershipConstructor()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Platforms", "Android", "MainApplication.cs");
        Assert.IsTrue(Code.Contains("MauiApplication(Handle, Ownership)", StringComparison.Ordinal), "MainApplication must call base MauiApplication constructor");
        Assert.IsTrue(Code.Contains("nint Handle, JniHandleOwnership Ownership", StringComparison.Ordinal), "MainApplication must accept Handle and Ownership params");
        Assert.IsTrue(Code.Contains("[Application]", StringComparison.Ordinal), "MainApplication must have [Application] attribute");
        Assert.IsTrue(Code.Contains("MauiProgram.CreateMauiApp()", StringComparison.Ordinal), "MainApplication must delegate to MauiProgram.CreateMauiApp");
    }
}
