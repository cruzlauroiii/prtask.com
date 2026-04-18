namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client program must create web assembly host builder with client routes root component on app selector")]
    public void ClientProgramMustCreateWebAssemblyHostBuilderWithClientRoutesRootComponentOnAppSelector()
    {
        var Code = ReadSourceFile("PrTask.Client", "Program.cs");
        Assert.IsTrue(Code.Contains("WebAssemblyHostBuilder.CreateDefault(args)", StringComparison.Ordinal), "Client Program must create default WebAssembly host builder");
        Assert.IsTrue(Code.Contains("ClientRoutes>(\"#app\")", StringComparison.Ordinal), "Client Program must add ClientRoutes root component on #app");
        Assert.IsTrue(Code.Contains("AppConstants.AppDomain", StringComparison.Ordinal), "Client Program must use AppConstants.AppDomain for base address");
        Assert.IsTrue(Code.Contains("Builder.Build().RunAsync()", StringComparison.Ordinal), "Client Program must call Build and RunAsync");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client layout must inherit layout component base and inject js runtime and http client services")]
    public void ClientLayoutMustInheritLayoutComponentBaseAndInjectJsRuntimeAndHttpClientServices()
    {
        var Code = ReadSourceFile("PrTask.Client", "Components", "ClientLayout.razor");
        Assert.IsTrue(Code.Contains("@inherits LayoutComponentBase", StringComparison.Ordinal), "ClientLayout must inherit LayoutComponentBase");
        Assert.IsTrue(Code.Contains("@inject IJSRuntime JsRuntime", StringComparison.Ordinal), "ClientLayout must inject IJSRuntime");
        Assert.IsTrue(Code.Contains("@inject HttpClient Http", StringComparison.Ordinal), "ClientLayout must inject HttpClient");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client layout must have clear cache reload link with refresh unicode character and title attribute")]
    public void ClientLayoutMustHaveClearCacheReloadLinkWithRefreshUnicodeCharacterAndTitleAttribute()
    {
        var Code = ReadSourceFile("PrTask.Client", "Components", "ClientLayout.razor");
        Assert.IsTrue(Code.Contains("clear-cache.html", StringComparison.Ordinal), "ClientLayout must link to clear-cache.html");
        Assert.IsTrue(Code.Contains("&#x21bb;", StringComparison.Ordinal), "ClientLayout must use refresh unicode character &#x21bb;");
        Assert.IsTrue(Code.Contains("Clear cache and reload all", StringComparison.Ordinal), "ClientLayout must have clear cache title attribute");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client layout auth check must fallback username to dashboard and catch http request exception")]
    public void ClientLayoutAuthCheckMustFallbackUsernameToDashboardAndCatchHttpRequestException()
    {
        var Code = ReadSourceFile("PrTask.Client", "Components", "ClientLayout.razor");
        Assert.IsTrue(Code.Contains("User?.Username ?? \"Dashboard\"", StringComparison.Ordinal), "ClientLayout must fallback username to Dashboard");
        Assert.IsTrue(Code.Contains("catch (HttpRequestException) { IsLoggedIn = false; }", StringComparison.Ordinal), "ClientLayout must catch HttpRequestException");
        Assert.IsTrue(Code.Contains("ReadFromJsonAsync<AuthUser>()", StringComparison.Ordinal), "ClientLayout must deserialize AuthUser from response");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client layout must include all eight legal page links using route constants in navigation bar")]
    public void ClientLayoutMustIncludeAllEightLegalPageLinksUsingRouteConstantsInNavigationBar()
    {
        var Code = ReadSourceFile("PrTask.Client", "Components", "ClientLayout.razor");
        Assert.IsTrue(Code.Contains("RouteConstants.CookiePolicy", StringComparison.Ordinal), "ClientLayout must link to CookiePolicy");
        Assert.IsTrue(Code.Contains("RouteConstants.AcceptableUse", StringComparison.Ordinal), "ClientLayout must link to AcceptableUse");
        Assert.IsTrue(Code.Contains("RouteConstants.Refund", StringComparison.Ordinal), "ClientLayout must link to Refund");
        Assert.IsTrue(Code.Contains("RouteConstants.Licenses", StringComparison.Ordinal), "ClientLayout must link to Licenses");
        Assert.IsTrue(Code.Contains("RouteConstants.Accessibility", StringComparison.Ordinal), "ClientLayout must link to Accessibility");
        Assert.IsTrue(Code.Contains("RouteConstants.Dmca", StringComparison.Ordinal), "ClientLayout must link to Dmca");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client layout theme toggle must use sun and moon characters matching dark and light theme states")]
    public void ClientLayoutThemeToggleMustUseSunAndMoonCharactersMatchingDarkAndLightThemeStates()
    {
        var Code = ReadSourceFile("PrTask.Client", "Components", "ClientLayout.razor");
        Assert.IsTrue(Code.Contains("ThemeIcon { get; set; } = \"☀\"", StringComparison.Ordinal), "ClientLayout must default ThemeIcon to sun");
        Assert.IsTrue(Code.Contains("Current == \"dark\" ? \"☾\" : \"☀\"", StringComparison.Ordinal), "ClientLayout must toggle between moon and sun");
        Assert.IsTrue(Code.Contains("ToggleThemeAsync", StringComparison.Ordinal), "ClientLayout must have ToggleThemeAsync method");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client layout sign in link must show when not logged in and sign out must link to auth logout")]
    public void ClientLayoutSignInLinkMustShowWhenNotLoggedInAndSignOutMustLinkToAuthLogout()
    {
        var Code = ReadSourceFile("PrTask.Client", "Components", "ClientLayout.razor");
        Assert.IsTrue(Code.Contains("RouteConstants.Login", StringComparison.Ordinal), "ClientLayout must link to Login route");
        Assert.IsTrue(Code.Contains("nav-login", StringComparison.Ordinal), "ClientLayout must use nav-login class for sign in link");
        Assert.IsTrue(Code.Contains("Sign Out", StringComparison.Ordinal), "ClientLayout must have Sign Out text");
        Assert.IsTrue(Code.Contains("Sign In", StringComparison.Ordinal), "ClientLayout must have Sign In text");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client routes must use typeof client routes assembly and client layout as default layout type")]
    public void ClientRoutesMustUseTypeofClientRoutesAssemblyAndClientLayoutAsDefaultLayoutType()
    {
        var Code = ReadSourceFile("PrTask.Client", "Components", "ClientRoutes.razor");
        Assert.IsTrue(Code.Contains("typeof(ClientRoutes).Assembly", StringComparison.Ordinal), "ClientRoutes must use typeof(ClientRoutes).Assembly");
        Assert.IsTrue(Code.Contains("typeof(ClientLayout)", StringComparison.Ordinal), "ClientRoutes must use ClientLayout as DefaultLayout");
        Assert.IsTrue(Code.Contains("The page you requested could not be found.", StringComparison.Ordinal), "ClientRoutes must show not found message text");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client imports must declare using statements for components routing web js interop and domain constants")]
    public void ClientImportsMustDeclareUsingStatementsForComponentsRoutingWebJsInteropAndDomainConstants()
    {
        var Code = ReadSourceFile("PrTask.Client", "_Imports.razor");
        Assert.IsTrue(Code.Contains("Microsoft.AspNetCore.Components.Web", StringComparison.Ordinal), "Client _Imports must use Components.Web");
        Assert.IsTrue(Code.Contains("Microsoft.JSInterop", StringComparison.Ordinal), "Client _Imports must use JSInterop");
        Assert.IsTrue(Code.Contains("System.Net.Http.Json", StringComparison.Ordinal), "Client _Imports must use System.Net.Http.Json");
        Assert.IsTrue(Code.Contains("PrTask.Domain.Constants", StringComparison.Ordinal), "Client _Imports must use Domain Constants");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client task detail wrapper must use tasks route pattern and pass task id to shared ui component")]
    public void ClientTaskDetailWrapperMustUseTasksRoutePatternAndPassTaskIdToSharedUiComponent()
    {
        var Code = ReadSourceFile("PrTask.Client", "Pages", "ClientTaskDetailPage.razor");
        Assert.IsTrue(Code.Contains("PrTask.SharedUI.Pages.TaskDetailPage", StringComparison.Ordinal), "Client TaskDetail must reference SharedUI TaskDetailPage");
        Assert.IsTrue(Code.Contains("TaskId=\"@TaskId\"", StringComparison.Ordinal), "Client TaskDetail must pass TaskId parameter");
        Assert.IsTrue(Code.Contains("string.Empty", StringComparison.Ordinal), "Client TaskDetail must default TaskId to empty string");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client pr detail wrapper must use prs route pattern and pass pr id to shared ui page component")]
    public void ClientPrDetailWrapperMustUsePrsRoutePatternAndPassPrIdToSharedUiPageComponent()
    {
        var Code = ReadSourceFile("PrTask.Client", "Pages", "ClientPullRequestDetailPage.razor");
        Assert.IsTrue(Code.Contains("PrTask.SharedUI.Pages.PullRequestDetailPage", StringComparison.Ordinal), "Client PRDetail must reference SharedUI PullRequestDetailPage");
        Assert.IsTrue(Code.Contains("PrId=\"@PrId\"", StringComparison.Ordinal), "Client PRDetail must pass PrId parameter");
        Assert.IsTrue(Code.Contains("@page \"/prs/{PrId}\"", StringComparison.Ordinal), "Client PRDetail must use /prs/{PrId} route");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client deployment preview wrapper must use deployments route and pass id to shared ui component")]
    public void ClientDeploymentPreviewWrapperMustUseDeploymentsRouteAndPassIdToSharedUiComponent()
    {
        var Code = ReadSourceFile("PrTask.Client", "Pages", "ClientDeploymentPreviewPage.razor");
        Assert.IsTrue(Code.Contains("PrTask.SharedUI.Pages.DeploymentPreviewPage", StringComparison.Ordinal), "Client DeploymentPreview must reference SharedUI page");
        Assert.IsTrue(Code.Contains("DeploymentId=\"@DeploymentId\"", StringComparison.Ordinal), "Client DeploymentPreview must pass DeploymentId parameter");
        Assert.IsTrue(Code.Contains("@page \"/deployments/{DeploymentId}\"", StringComparison.Ordinal), "Client DeploymentPreview must use deployments route");
    }
}
