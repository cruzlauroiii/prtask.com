namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Login page must use route constants for azure and okta sso provider auth endpoints")]
    public void LoginPageMustUseRouteConstantsForAzureAndOktaSsoProviderAuthEndpoints()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "LoginPage.razor");
        Assert.IsTrue(Razor.Contains("RouteConstants.ApiAuthAzure", StringComparison.Ordinal), "Login must link to Azure auth endpoint");
        Assert.IsTrue(Razor.Contains("RouteConstants.ApiAuthOkta", StringComparison.Ordinal), "Login must link to Okta auth endpoint");
        Assert.IsTrue(Razor.Contains("login-buttons", StringComparison.Ordinal), "Login must use login-buttons container class");
        Assert.IsTrue(Razor.Contains("login-info", StringComparison.Ordinal), "Login must have login-info section");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pricing page must state completely free platform with no hidden fees or commissions")]
    public void PricingPageMustStateCompletelyFreePlatformWithNoHiddenFeesOrCommissions()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "PricingPage.razor");
        Assert.IsTrue(Razor.Contains("completely free for everyone", StringComparison.Ordinal), "Pricing must state free for everyone");
        Assert.IsTrue(Razor.Contains("No hidden fees", StringComparison.Ordinal), "Pricing must state no hidden fees");
        Assert.IsTrue(Razor.Contains("pricing-cards", StringComparison.Ordinal), "Pricing must use pricing-cards container");
        Assert.IsTrue(Razor.Contains("featured", StringComparison.Ordinal), "Pricing must have featured card class");
        Assert.IsTrue(Razor.Contains("Minimum bounty: $1", StringComparison.Ordinal), "Pricing must state $1 minimum bounty");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("About page must have contact section with support email and what we do explanation")]
    public void AboutPageMustHaveContactSectionWithSupportEmailAndWhatWeDoExplanation()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "AboutPage.razor");
        Assert.IsTrue(Razor.Contains("Contact", StringComparison.Ordinal), "About must have contact section");
        Assert.IsTrue(Razor.Contains("support@prtask.com", StringComparison.Ordinal), "About must provide support email");
        Assert.IsTrue(Razor.Contains("about-section", StringComparison.Ordinal), "About must use about-section class");
        Assert.IsTrue(Razor.Contains("XP based on complexity scoring", StringComparison.Ordinal), "About must explain XP scoring");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("How it works page must describe complexity scoring with language difficulty and test coverage")]
    public void HowItWorksPageMustDescribeComplexityScoringWithLanguageDifficultyAndTestCoverage()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "HowItWorks.razor");
        Assert.IsTrue(Razor.Contains("files changed", StringComparison.Ordinal), "How it works must mention files changed in scoring");
        Assert.IsTrue(Razor.Contains("language difficulty", StringComparison.Ordinal), "How it works must mention language difficulty");
        Assert.IsTrue(Razor.Contains("step-number", StringComparison.Ordinal), "How it works must use step-number class");
        Assert.IsTrue(Razor.Contains("Multiple developers", StringComparison.Ordinal), "How it works must mention multiple PR submissions");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Dashboard page stat cards must have stat value and stat label classes with initial zero values")]
    public void DashboardPageStatCardsMustHaveStatValueAndStatLabelClassesWithInitialZeroValues()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "DashboardPage.razor");
        Assert.IsTrue(Razor.Contains("stat-value", StringComparison.Ordinal), "Dashboard stat cards must use stat-value class");
        Assert.IsTrue(Razor.Contains("stat-label", StringComparison.Ordinal), "Dashboard stat cards must use stat-label class");
        Assert.IsTrue(Razor.Contains("Lv. 1", StringComparison.Ordinal), "Dashboard must show Level 1 as default");
        Assert.IsTrue(Razor.Contains("dashboard-section", StringComparison.Ordinal), "Dashboard must use dashboard-section class");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task endpoints must use map group with api tasks route and get by id with not found")]
    public void TaskEndpointsMustUseMapGroupWithApiTasksRouteAndGetByIdWithNotFound()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "TaskEndpoints.cs");
        Assert.IsTrue(Code.Contains("MapGet(\"/{TaskId}\"", StringComparison.Ordinal), "TaskEndpoints must map GET by TaskId");
        Assert.IsTrue(Code.Contains("Results.NotFound()", StringComparison.Ordinal), "TaskEndpoints must return NotFound for missing tasks");
        Assert.IsTrue(Code.Contains("MapPatch", StringComparison.Ordinal), "TaskEndpoints must use MapPatch for updates");
        Assert.IsTrue(Code.Contains("MapDelete", StringComparison.Ordinal), "TaskEndpoints must use MapDelete for deletion");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request endpoints must accept reject request with notes and return created for submit")]
    public void PullRequestEndpointsMustAcceptRejectRequestWithNotesAndReturnCreatedForSubmit()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "PullRequestEndpoints.cs");
        Assert.IsTrue(Code.Contains("RejectPullRequestRequest", StringComparison.Ordinal), "PREndpoints must accept RejectPullRequestRequest");
        Assert.IsTrue(Code.Contains("Request.Notes", StringComparison.Ordinal), "PREndpoints must pass rejection Notes to service");
        Assert.IsTrue(Code.Contains("Results.Created", StringComparison.Ordinal), "PREndpoints must return Created for new PR");
        Assert.IsTrue(Code.Contains("RequireAuthorization()", StringComparison.Ordinal), "PREndpoints must require auth for mutations");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Payment endpoints must create checkout response and return payment status for query")]
    public void PaymentEndpointsMustCreateCheckoutResponseAndReturnPaymentStatusForQuery()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "PaymentEndpoints.cs");
        Assert.IsTrue(Code.Contains("PaymentCheckoutRequest", StringComparison.Ordinal), "PaymentEndpoints must accept PaymentCheckoutRequest");
        Assert.IsTrue(Code.Contains("PaymentCheckoutResponse", StringComparison.Ordinal), "PaymentEndpoints must return PaymentCheckoutResponse");
        Assert.IsTrue(Code.Contains("PaymentWebhookRequest", StringComparison.Ordinal), "PaymentEndpoints must accept PaymentWebhookRequest");
        Assert.IsTrue(Code.Contains("PaymentStatusResponse", StringComparison.Ordinal), "PaymentEndpoints must return PaymentStatusResponse");
        Assert.IsTrue(Code.Contains("GetStatusAsync", StringComparison.Ordinal), "PaymentEndpoints must call GetStatusAsync");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Leaderboard endpoints must use api leaderboard route constant with optional count parameter")]
    public void LeaderboardEndpointsMustUseApiLeaderboardRouteConstantWithOptionalCountParameter()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "LeaderboardEndpoints.cs");
        Assert.IsTrue(Code.Contains("RouteConstants.ApiLeaderboard", StringComparison.Ordinal), "LeaderboardEndpoints must use route constant");
        Assert.IsTrue(Code.Contains("int? Count", StringComparison.Ordinal), "LeaderboardEndpoints must accept optional Count parameter");
        Assert.IsTrue(Code.Contains("GetTopAsync", StringComparison.Ordinal), "LeaderboardEndpoints must call GetTopAsync");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui program must add blazor web view developer tools in debug configuration only")]
    public void MauiProgramMustAddBlazorWebViewDeveloperToolsInDebugConfigurationOnly()
    {
        var Code = ReadSourceFile("PrTask.Maui", "MauiProgram.cs");
        Assert.IsTrue(Code.Contains("#if DEBUG", StringComparison.Ordinal), "MauiProgram must conditionally compile debug tools");
        Assert.IsTrue(Code.Contains("AddBlazorWebViewDeveloperTools()", StringComparison.Ordinal), "MauiProgram must add dev tools in debug mode");
        Assert.IsTrue(Code.Contains("ConfigureLifecycleEvents", StringComparison.Ordinal), "MauiProgram must configure lifecycle events");
        Assert.IsTrue(Code.Contains("AddAndroid", StringComparison.Ordinal), "MauiProgram must register Android lifecycle handler");
    }
}
