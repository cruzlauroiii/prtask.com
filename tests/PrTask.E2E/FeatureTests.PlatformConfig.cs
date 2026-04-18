namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform main must require cloudflare provider version four dot twenty one or compatible")]
    public void TerraformMainMustRequireCloudflareProviderVersionFourDotTwentyOneOrCompatible()
    {
        var Tf = ReadInfraFile("main.tf");
        Assert.IsTrue(Tf.Contains("cloudflare/cloudflare", StringComparison.Ordinal), "Must require cloudflare provider from registry");
        Assert.IsTrue(Tf.Contains("~> 4.21", StringComparison.Ordinal), "Must pin to compatible version 4.21+");
        Assert.IsTrue(Tf.Contains("required_providers", StringComparison.Ordinal), "Must define required_providers block");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform main must configure cloudflare provider with api key and email authentication")]
    public void TerraformMainMustConfigureCloudflareProviderWithApiKeyAndEmailAuthentication()
    {
        var Tf = ReadInfraFile("main.tf");
        Assert.IsTrue(Tf.Contains("provider \"cloudflare\"", StringComparison.Ordinal), "Must define cloudflare provider block");
        Assert.IsTrue(Tf.Contains("api_key = var.cloudflare_api_key", StringComparison.Ordinal), "Must use api_key from variable");
        Assert.IsTrue(Tf.Contains("email   = var.cloudflare_email", StringComparison.Ordinal), "Must use email from variable");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform outputs must expose pages url and pages project name for deployment verification")]
    public void TerraformOutputsMustExposePagesUrlAndPagesProjectNameForDeploymentVerification()
    {
        var Tf = ReadInfraFile("outputs.tf");
        Assert.IsTrue(Tf.Contains("output \"pages_url\"", StringComparison.Ordinal), "Must output pages_url for site URL");
        Assert.IsTrue(Tf.Contains("output \"pages_project_name\"", StringComparison.Ordinal), "Must output pages_project_name");
        Assert.IsTrue(Tf.Contains("cloudflare_pages_project.prtask.subdomain", StringComparison.Ordinal), "Pages URL must reference project subdomain");
        Assert.IsTrue(Tf.Contains("cloudflare_pages_project.prtask.name", StringComparison.Ordinal), "Project name must reference prtask resource");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client program must use web assembly host builder with client routes root component at app")]
    public void ClientProgramMustUseWebAssemblyHostBuilderWithClientRoutesRootComponentAtApp()
    {
        var Code = ReadSourceFile("PrTask.Client", "Program.cs");
        Assert.IsTrue(Code.Contains("WebAssemblyHostBuilder.CreateDefault", StringComparison.Ordinal), "Client must use WebAssemblyHostBuilder");
        Assert.IsTrue(Code.Contains("ClientRoutes", StringComparison.Ordinal), "Client must register ClientRoutes as root component");
        Assert.IsTrue(Code.Contains("#app", StringComparison.Ordinal), "Root component must mount at #app CSS selector");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client program must register scoped http client with prtask domain as base address")]
    public void ClientProgramMustRegisterScopedHttpClientWithPrtaskDomainAsBaseAddress()
    {
        var Code = ReadSourceFile("PrTask.Client", "Program.cs");
        Assert.IsTrue(Code.Contains("AddScoped", StringComparison.Ordinal), "Client must register HttpClient as scoped service");
        Assert.IsTrue(Code.Contains("AppConstants.AppDomain", StringComparison.Ordinal), "HttpClient base address must use AppDomain");
        Assert.IsTrue(Code.Contains("new HttpClient", StringComparison.Ordinal), "Must create new HttpClient with configured base address");
        Assert.IsTrue(Code.Contains("RunAsync", StringComparison.Ordinal), "Client must call RunAsync to start WASM host");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui program must use prtask app class and configure android lifecycle for status bar")]
    public void MauiProgramMustUsePrtaskAppClassAndConfigureAndroidLifecycleForStatusBar()
    {
        var Code = ReadSourceFile("PrTask.Maui", "MauiProgram.cs");
        Assert.IsTrue(Code.Contains("UseMauiApp<PrTaskApp>", StringComparison.Ordinal), "Must register PrTaskApp as Maui app class");
        Assert.IsTrue(Code.Contains("SetDecorFitsSystemWindows", StringComparison.Ordinal), "Must configure system windows for status bar");
        Assert.IsTrue(Code.Contains("AddAndroid", StringComparison.Ordinal), "Must add Android platform lifecycle events");
        Assert.IsTrue(Code.Contains("OnCreate", StringComparison.Ordinal), "Must hook into Android OnCreate lifecycle");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth callback activity must use com prtask app custom scheme with auth host for deep linking")]
    public void AuthCallbackActivityMustUseComPrtaskAppCustomSchemeWithAuthHostForDeepLinking()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Platforms", "Android", "AuthCallbackActivity.cs");
        Assert.IsTrue(Code.Contains("DataScheme = \"com.prtask.app\"", StringComparison.Ordinal), "Must use com.prtask.app custom URL scheme");
        Assert.IsTrue(Code.Contains("DataHost = \"auth\"", StringComparison.Ordinal), "Must use auth as host for callback routing");
        Assert.IsTrue(Code.Contains("WebAuthenticatorCallbackActivity", StringComparison.Ordinal), "Must inherit WebAuthenticatorCallbackActivity");
        Assert.IsTrue(Code.Contains("NoHistory = true", StringComparison.Ordinal), "Must set NoHistory to prevent back navigation to callback");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth callback activity must have exported intent filter with view action and browsable category")]
    public void AuthCallbackActivityMustHaveExportedIntentFilterWithViewActionAndBrowsableCategory()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Platforms", "Android", "AuthCallbackActivity.cs");
        Assert.IsTrue(Code.Contains("Exported = true", StringComparison.Ordinal), "Must be exported for system to invoke");
        Assert.IsTrue(Code.Contains("IntentFilter", StringComparison.Ordinal), "Must have IntentFilter attribute");
        Assert.IsTrue(Code.Contains("ActionView", StringComparison.Ordinal), "Must handle VIEW action for URL schemes");
        Assert.IsTrue(Code.Contains("CategoryBrowsable", StringComparison.Ordinal), "Must be browsable for external URL invocation");
        Assert.IsTrue(Code.Contains("CategoryDefault", StringComparison.Ordinal), "Must be in default category for intent resolution");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Main activity must use splash theme and handle screen size orientation and ui mode changes")]
    public void MainActivityMustUseSplashThemeAndHandleScreenSizeOrientationAndUiModeChanges()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Platforms", "Android", "MainActivity.cs");
        Assert.IsTrue(Code.Contains("Maui.SplashTheme", StringComparison.Ordinal), "Must use Maui.SplashTheme for startup screen");
        Assert.IsTrue(Code.Contains("MainLauncher = true", StringComparison.Ordinal), "Must be the main launcher activity");
        Assert.IsTrue(Code.Contains("ConfigChanges.ScreenSize", StringComparison.Ordinal), "Must handle screen size changes without restart");
        Assert.IsTrue(Code.Contains("ConfigChanges.Orientation", StringComparison.Ordinal), "Must handle orientation changes");
        Assert.IsTrue(Code.Contains("ConfigChanges.UiMode", StringComparison.Ordinal), "Must handle UI mode changes for dark theme");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Main activity must inherit maui app compat activity with single top launch mode")]
    public void MainActivityMustInheritMauiAppCompatActivityWithSingleTopLaunchMode()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Platforms", "Android", "MainActivity.cs");
        Assert.IsTrue(Code.Contains("MauiAppCompatActivity", StringComparison.Ordinal), "Must inherit MauiAppCompatActivity base class");
        Assert.IsTrue(Code.Contains("LaunchMode.SingleTop", StringComparison.Ordinal), "Must use SingleTop launch mode for instance reuse");
        Assert.IsTrue(Code.Contains("Exported = true", StringComparison.Ordinal), "Must be exported for launcher visibility");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Main application must inherit maui application and create maui app from maui program")]
    public void MainApplicationMustInheritMauiApplicationAndCreateMauiAppFromMauiProgram()
    {
        var Code = ReadSourceFile("PrTask.Maui", "Platforms", "Android", "MainApplication.cs");
        Assert.IsTrue(Code.Contains("MauiApplication", StringComparison.Ordinal), "Must inherit MauiApplication base class");
        Assert.IsTrue(Code.Contains("MauiProgram.CreateMauiApp()", StringComparison.Ordinal), "Must delegate app creation to MauiProgram");
        Assert.IsTrue(Code.Contains("[Application]", StringComparison.Ordinal), "Must have Application attribute for Android manifest");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Application global usings must import dependency injection hosting and logging namespaces")]
    public void ApplicationGlobalUsingsMustImportDependencyInjectionHostingAndLoggingNamespaces()
    {
        var Code = ReadSourceFile("PrTask.Application", "GlobalUsings.cs");
        Assert.IsTrue(Code.Contains("Microsoft.Extensions.DependencyInjection", StringComparison.Ordinal), "Must globally use DependencyInjection");
        Assert.IsTrue(Code.Contains("Microsoft.Extensions.Hosting", StringComparison.Ordinal), "Must globally use Hosting");
        Assert.IsTrue(Code.Contains("Microsoft.Extensions.Logging", StringComparison.Ordinal), "Must globally use Logging");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Leaderboard endpoints must default to hundred entries when count parameter is not specified")]
    public void LeaderboardEndpointsMustDefaultToHundredEntriesWhenCountParameterIsNotSpecified()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "LeaderboardEndpoints.cs");
        Assert.IsTrue(Code.Contains("Count ?? 100", StringComparison.Ordinal), "Must default to 100 entries when Count is null");
        Assert.IsTrue(Code.Contains("MapGet(RouteConstants.ApiLeaderboard", StringComparison.Ordinal), "Must map GET route for leaderboard");
        Assert.IsTrue(Code.Contains("LeaderboardRankResponse", StringComparison.Ordinal), "Must wrap rank in LeaderboardRankResponse");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Payment endpoints must require authorization for checkout and expose webhook without auth")]
    public void PaymentEndpointsMustRequireAuthorizationForCheckoutAndExposeWebhookWithoutAuth()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "PaymentEndpoints.cs");
        Assert.IsTrue(Code.Contains("RequireAuthorization", StringComparison.Ordinal), "Checkout must require authorization");
        Assert.IsTrue(Code.Contains("MapPost(RouteConstants.ApiPaymentsCheckout", StringComparison.Ordinal), "Must map POST for checkout");
        Assert.IsTrue(Code.Contains("MapPost(RouteConstants.ApiPaymentsWebhook", StringComparison.Ordinal), "Must map POST for webhook");
        Assert.IsTrue(Code.Contains("PaymentCheckoutResponse", StringComparison.Ordinal), "Must return PaymentCheckoutResponse");
        Assert.IsTrue(Code.Contains("PaymentStatusResponse", StringComparison.Ordinal), "Must return PaymentStatusResponse for status query");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task endpoints must use route group with api tasks base path for all task operations")]
    public void TaskEndpointsMustUseRouteGroupWithApiTasksBasePathForAllTaskOperations()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "TaskEndpoints.cs");
        Assert.IsTrue(Code.Contains("MapGroup(RouteConstants.ApiTasks)", StringComparison.Ordinal), "Must use MapGroup with ApiTasks base path");
        Assert.IsTrue(Code.Contains("MapGet(\"/\"", StringComparison.Ordinal), "Must map GET / for listing open tasks");
        Assert.IsTrue(Code.Contains("MapDelete(\"/{TaskId}\"", StringComparison.Ordinal), "Must map DELETE with TaskId parameter");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request endpoints must use route group with api pull requests base path for all operations")]
    public void PullRequestEndpointsMustUseRouteGroupWithApiPullRequestsBasePathForAllOperations()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "PullRequestEndpoints.cs");
        Assert.IsTrue(Code.Contains("MapGroup(RouteConstants.ApiPullRequests)", StringComparison.Ordinal), "Must use MapGroup with ApiPullRequests base path");
        Assert.IsTrue(Code.Contains("task/{TaskId}", StringComparison.Ordinal), "Must have route to list PRs by task");
        Assert.IsTrue(Code.Contains("ListByTaskAsync", StringComparison.Ordinal), "Must call ListByTaskAsync for task-scoped PR listing");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints must build azure authorize url using common tenant url template for multi org")]
    public void AuthEndpointsMustBuildAzureAuthorizeUrlUsingCommonTenantUrlTemplateForMultiOrg()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("AzureConstants.CommonTenant", StringComparison.Ordinal), "Must use CommonTenant for Azure authorize URL");
        Assert.IsTrue(Code.Contains("AzureConstants.RequiredScope", StringComparison.Ordinal), "Must use Azure required scope");
        Assert.IsTrue(Code.Contains("AzureConstants.UserInfoUrl", StringComparison.Ordinal), "Must use Azure user info URL");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints must build okta urls from configuration domain and okta path templates")]
    public void AuthEndpointsMustBuildOktaUrlsFromConfigurationDomainAndOktaPathTemplates()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("OktaConstants.AuthorizePathTemplate", StringComparison.Ordinal), "Must use Okta authorize path template");
        Assert.IsTrue(Code.Contains("OktaConstants.TokenPathTemplate", StringComparison.Ordinal), "Must use Okta token path template");
        Assert.IsTrue(Code.Contains("OktaConstants.UserInfoPathTemplate", StringComparison.Ordinal), "Must use Okta userinfo path template");
        Assert.IsTrue(Code.Contains("Configuration[\"Okta:Domain\"]", StringComparison.Ordinal), "Must read Okta domain from configuration");
    }
}
