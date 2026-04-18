namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client home page must have feature cards section with pick task submit pr and get paid steps")]
    public void ClientHomePageMustHaveFeatureCardsSectionWithPickTaskSubmitPrAndGetPaidSteps()
    {
        var Razor = ReadSourceFile("PrTask.Client", "Pages", "ClientHomePage.razor");
        Assert.IsTrue(Razor.Contains("feature-card", StringComparison.Ordinal), "Client home must use feature-card class for step cards");
        Assert.IsTrue(Razor.Contains("Pick a Task", StringComparison.Ordinal), "Client home must describe picking a task");
        Assert.IsTrue(Razor.Contains("Submit Your PR", StringComparison.Ordinal), "Client home must describe submitting a PR");
        Assert.IsTrue(Razor.Contains("Get Paid", StringComparison.Ordinal), "Client home must describe getting paid");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client home page must describe automatic charge on approval and multiple developer pr submissions")]
    public void ClientHomePageMustDescribeAutomaticChargeOnApprovalAndMultipleDeveloperPrSubmissions()
    {
        var Razor = ReadSourceFile("PrTask.Client", "Pages", "ClientHomePage.razor");
        Assert.IsTrue(Razor.Contains("automatically charged", StringComparison.Ordinal), "Client home must explain automatic charge on approval");
        Assert.IsTrue(Razor.Contains("Multiple developers", StringComparison.Ordinal), "Client home must explain multiple PR submissions");
        Assert.IsTrue(Razor.Contains("hero-subtitle", StringComparison.Ordinal), "Client home must have hero subtitle class");
        Assert.IsTrue(Razor.Contains("hero-actions", StringComparison.Ordinal), "Client home must have hero actions container");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client task list page must fetch tasks from api tasks route via http client get from json")]
    public void ClientTaskListPageMustFetchTasksFromApiTasksRouteViaHttpClientGetFromJson()
    {
        var Razor = ReadSourceFile("PrTask.Client", "Pages", "ClientTaskListPage.razor");
        Assert.IsTrue(Razor.Contains("RouteConstants.ApiTasks", StringComparison.Ordinal), "Client task list must use RouteConstants.ApiTasks endpoint");
        Assert.IsTrue(Razor.Contains("GetFromJsonAsync", StringComparison.Ordinal), "Client task list must deserialize JSON response");
        Assert.IsTrue(Razor.Contains("TaskEntity[]", StringComparison.Ordinal), "Client task list must deserialize to TaskEntity array");
        Assert.IsTrue(Razor.Contains("HttpRequestException", StringComparison.Ordinal), "Client task list must catch HttpRequestException");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client task list page must have task grid with complexity bounty and truncated description display")]
    public void ClientTaskListPageMustHaveTaskGridWithComplexityBountyAndTruncatedDescriptionDisplay()
    {
        var Razor = ReadSourceFile("PrTask.Client", "Pages", "ClientTaskListPage.razor");
        Assert.IsTrue(Razor.Contains("task-grid", StringComparison.Ordinal), "Client task list must use task-grid container");
        Assert.IsTrue(Razor.Contains("task-card", StringComparison.Ordinal), "Client task list must render task-card elements");
        Assert.IsTrue(Razor.Contains("task-complexity", StringComparison.Ordinal), "Client task list must show complexity badge");
        Assert.IsTrue(Razor.Contains("task-bounty", StringComparison.Ordinal), "Client task list must show bounty amount");
        Assert.IsTrue(Razor.Contains("TruncateDescription", StringComparison.Ordinal), "Client task list must truncate descriptions");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client task list page must truncate descriptions to one hundred twenty characters with ellipsis")]
    public void ClientTaskListPageMustTruncateDescriptionsToOneHundredTwentyCharactersWithEllipsis()
    {
        var Razor = ReadSourceFile("PrTask.Client", "Pages", "ClientTaskListPage.razor");
        Assert.IsTrue(Razor.Contains("120", StringComparison.Ordinal), "Client task list truncation must use 120 char limit");
        Assert.IsTrue(Razor.Contains("FormatBountyAmount", StringComparison.Ordinal), "Client task list must format bounty in dollars");
        Assert.IsTrue(Razor.Contains("empty-state", StringComparison.Ordinal), "Client task list must handle empty state");
        Assert.IsTrue(Razor.Contains("No open tasks", StringComparison.Ordinal), "Client task list must show no open tasks message");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client leaderboard page must use route constants api leaderboard and handle http request exceptions")]
    public void ClientLeaderboardPageMustUseRouteConstantsApiLeaderboardAndHandleHttpRequestExceptions()
    {
        var Razor = ReadSourceFile("PrTask.Client", "Pages", "ClientLeaderboardPage.razor");
        Assert.IsTrue(Razor.Contains("RouteConstants.ApiLeaderboard", StringComparison.Ordinal), "Client leaderboard must use ApiLeaderboard route");
        Assert.IsTrue(Razor.Contains("HttpRequestException", StringComparison.Ordinal), "Client leaderboard must handle HTTP errors");
        Assert.IsTrue(Razor.Contains("LeaderboardEntry[]", StringComparison.Ordinal), "Client leaderboard must deserialize to LeaderboardEntry array");
        Assert.IsTrue(Razor.Contains("leaderboard-table", StringComparison.Ordinal), "Client leaderboard must use leaderboard-table class");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client leaderboard page must display rank level xp prs merged and earned columns for developers")]
    public void ClientLeaderboardPageMustDisplayRankLevelXpPrsMergedAndEarnedColumnsForDevelopers()
    {
        var Razor = ReadSourceFile("PrTask.Client", "Pages", "ClientLeaderboardPage.razor");
        Assert.IsTrue(Razor.Contains("leaderboard-header", StringComparison.Ordinal), "Client leaderboard must have header row");
        Assert.IsTrue(Razor.Contains("leaderboard-row", StringComparison.Ordinal), "Client leaderboard must have data rows");
        Assert.IsTrue(Razor.Contains("PRs Merged", StringComparison.Ordinal), "Client leaderboard must show PRs Merged column");
        Assert.IsTrue(Razor.Contains("Earned", StringComparison.Ordinal), "Client leaderboard must show Earned column");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client dashboard page must use auth user sealed class with username property for deserialization")]
    public void ClientDashboardPageMustUseAuthUserSealedClassWithUsernamePropertyForDeserialization()
    {
        var Razor = ReadSourceFile("PrTask.Client", "Pages", "ClientDashboardPage.razor");
        Assert.IsTrue(Razor.Contains("sealed class AuthUser", StringComparison.Ordinal), "Client dashboard must define sealed AuthUser class");
        Assert.IsTrue(Razor.Contains("ReadFromJsonAsync", StringComparison.Ordinal), "Client dashboard must deserialize auth response");
        Assert.IsTrue(Razor.Contains("Username", StringComparison.Ordinal), "Client dashboard AuthUser must have Username property");
        Assert.IsTrue(Razor.Contains("Welcome", StringComparison.Ordinal), "Client dashboard must greet authenticated users");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client dashboard page must show stat cards for active tasks prs submitted earnings and level")]
    public void ClientDashboardPageMustShowStatCardsForActiveTasksPrsSubmittedEarningsAndLevel()
    {
        var Razor = ReadSourceFile("PrTask.Client", "Pages", "ClientDashboardPage.razor");
        Assert.IsTrue(Razor.Contains("dashboard-stats", StringComparison.Ordinal), "Client dashboard must have stats section");
        Assert.IsTrue(Razor.Contains("Active Tasks", StringComparison.Ordinal), "Client dashboard must show Active Tasks stat");
        Assert.IsTrue(Razor.Contains("PRs Submitted", StringComparison.Ordinal), "Client dashboard must show PRs Submitted stat");
        Assert.IsTrue(Razor.Contains("Total Earned", StringComparison.Ordinal), "Client dashboard must show Total Earned stat");
        Assert.IsTrue(Razor.Contains("Current Level", StringComparison.Ordinal), "Client dashboard must show Current Level stat");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client dashboard page must link to tasks page and login page using route constants")]
    public void ClientDashboardPageMustLinkToTasksPageAndLoginPageUsingRouteConstants()
    {
        var Razor = ReadSourceFile("PrTask.Client", "Pages", "ClientDashboardPage.razor");
        Assert.IsTrue(Razor.Contains("RouteConstants.Tasks", StringComparison.Ordinal), "Client dashboard must link to tasks for activity");
        Assert.IsTrue(Razor.Contains("RouteConstants.Login", StringComparison.Ordinal), "Client dashboard must link to login for unauthenticated");
        Assert.IsTrue(Razor.Contains("dashboard-section", StringComparison.Ordinal), "Client dashboard must have dashboard section");
        Assert.IsTrue(Razor.Contains("Recent Activity", StringComparison.Ordinal), "Client dashboard must have recent activity section");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client login page must have four sso provider buttons using route constants for auth endpoints")]
    public void ClientLoginPageMustHaveFourSsoProviderButtonsUsingRouteConstantsForAuthEndpoints()
    {
        var Razor = ReadSourceFile("PrTask.Client", "Pages", "ClientLoginPage.razor");
        Assert.IsTrue(Razor.Contains("RouteConstants.ApiAuthGoogle", StringComparison.Ordinal), "Client login must link to Google auth");
        Assert.IsTrue(Razor.Contains("RouteConstants.ApiAuthGitHub", StringComparison.Ordinal), "Client login must link to GitHub auth");
        Assert.IsTrue(Razor.Contains("RouteConstants.ApiAuthAzure", StringComparison.Ordinal), "Client login must link to Azure auth");
        Assert.IsTrue(Razor.Contains("RouteConstants.ApiAuthOkta", StringComparison.Ordinal), "Client login must link to Okta auth");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client login page must have login info section describing developer and client roles separately")]
    public void ClientLoginPageMustHaveLoginInfoSectionDescribingDeveloperAndClientRolesSeparately()
    {
        var Razor = ReadSourceFile("PrTask.Client", "Pages", "ClientLoginPage.razor");
        Assert.IsTrue(Razor.Contains("login-section", StringComparison.Ordinal), "Client login must use login-section class");
        Assert.IsTrue(Razor.Contains("For Developers", StringComparison.Ordinal), "Client login must describe developer use case");
        Assert.IsTrue(Razor.Contains("For Clients", StringComparison.Ordinal), "Client login must describe client use case");
        Assert.IsTrue(Razor.Contains("Sign In to PrTask", StringComparison.Ordinal), "Client login must have sign in heading");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client about page must have game like experience section and secure payments explanation")]
    public void ClientAboutPageMustHaveGameLikeExperienceSectionAndSecurePaymentsExplanation()
    {
        var Razor = ReadSourceFile("PrTask.Client", "Pages", "ClientAboutPage.razor");
        Assert.IsTrue(Razor.Contains("Game-Like Experience", StringComparison.Ordinal), "Client about must have game experience section");
        Assert.IsTrue(Razor.Contains("Secure Payments", StringComparison.Ordinal), "Client about must have secure payments section");
        Assert.IsTrue(Razor.Contains("legal-links", StringComparison.Ordinal), "Client about must have legal links section");
        Assert.IsTrue(Razor.Contains("support@prtask.com", StringComparison.Ordinal), "Client about must include support email");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client about page must link to all eight legal pages via route constants")]
    public void ClientAboutPageMustLinkToAllEightLegalPagesViaRouteConstants()
    {
        var Razor = ReadSourceFile("PrTask.Client", "Pages", "ClientAboutPage.razor");
        Assert.IsTrue(Razor.Contains("RouteConstants.Terms", StringComparison.Ordinal), "Client about must link to Terms");
        Assert.IsTrue(Razor.Contains("RouteConstants.Privacy", StringComparison.Ordinal), "Client about must link to Privacy");
        Assert.IsTrue(Razor.Contains("RouteConstants.CookiePolicy", StringComparison.Ordinal), "Client about must link to Cookie Policy");
        Assert.IsTrue(Razor.Contains("RouteConstants.AcceptableUse", StringComparison.Ordinal), "Client about must link to Acceptable Use");
        Assert.IsTrue(Razor.Contains("RouteConstants.Refund", StringComparison.Ordinal), "Client about must link to Refund");
        Assert.IsTrue(Razor.Contains("RouteConstants.Dmca", StringComparison.Ordinal), "Client about must link to DMCA");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client how it works page must have five numbered steps from browsing to getting paid")]
    public void ClientHowItWorksPageMustHaveFiveNumberedStepsFromBrowsingToGettingPaid()
    {
        var Razor = ReadSourceFile("PrTask.Client", "Pages", "ClientHowItWorksPage.razor");
        Assert.IsTrue(Razor.Contains("step-number", StringComparison.Ordinal), "Client how it works must use step-number class");
        Assert.IsTrue(Razor.Contains("Browse Open Tasks", StringComparison.Ordinal), "Client how it works must have browse tasks step");
        Assert.IsTrue(Razor.Contains("Submit a Pull Request", StringComparison.Ordinal), "Client how it works must have submit PR step");
        Assert.IsTrue(Razor.Contains("Complexity Scoring", StringComparison.Ordinal), "Client how it works must have scoring step");
        Assert.IsTrue(Razor.Contains("Get Paid and Level Up", StringComparison.Ordinal), "Client how it works must have payout step");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client pricing page must have pricing faq section with payment details and usd currency info")]
    public void ClientPricingPageMustHavePricingFaqSectionWithPaymentDetailsAndUsdCurrencyInfo()
    {
        var Razor = ReadSourceFile("PrTask.Client", "Pages", "ClientPricingPage.razor");
        Assert.IsTrue(Razor.Contains("pricing-faq", StringComparison.Ordinal), "Client pricing must have FAQ section");
        Assert.IsTrue(Razor.Contains("faq-item", StringComparison.Ordinal), "Client pricing must have FAQ items");
        Assert.IsTrue(Razor.Contains("US Dollars (USD)", StringComparison.Ordinal), "Client pricing must state USD currency");
        Assert.IsTrue(Razor.Contains("100% of the bounty", StringComparison.Ordinal), "Client pricing must state developers receive 100% bounty");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client pricing page must have developer and client pricing cards both showing free amount")]
    public void ClientPricingPageMustHaveDeveloperAndClientPricingCardsBothShowingFreeAmount()
    {
        var Razor = ReadSourceFile("PrTask.Client", "Pages", "ClientPricingPage.razor");
        Assert.IsTrue(Razor.Contains("For Developers", StringComparison.Ordinal), "Client pricing must have developer card");
        Assert.IsTrue(Razor.Contains("For Clients", StringComparison.Ordinal), "Client pricing must have client card");
        Assert.IsTrue(Razor.Contains("pricing-amount", StringComparison.Ordinal), "Client pricing must use pricing-amount class");
        Assert.IsTrue(Razor.Contains("Minimum bounty: $1", StringComparison.Ordinal), "Client pricing must state $1 minimum bounty");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client task detail wrapper must pass task id parameter to shared ui task detail page component")]
    public void ClientTaskDetailWrapperMustPassTaskIdParameterToSharedUiTaskDetailPageComponent()
    {
        var Razor = ReadSourceFile("PrTask.Client", "Pages", "ClientTaskDetailPage.razor");
        Assert.IsTrue(Razor.Contains("PrTask.SharedUI.Pages.TaskDetailPage", StringComparison.Ordinal), "Client task detail must delegate to SharedUI");
        Assert.IsTrue(Razor.Contains("TaskId=\"@TaskId\"", StringComparison.Ordinal), "Client task detail must pass TaskId parameter");
        Assert.IsTrue(Razor.Contains("[Parameter]", StringComparison.Ordinal), "Client task detail must accept TaskId as route parameter");
        Assert.IsTrue(Razor.Contains("string TaskId", StringComparison.Ordinal), "Client task detail must define TaskId property");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client deployment preview wrapper must pass deployment id to shared ui preview component")]
    public void ClientDeploymentPreviewWrapperMustPassDeploymentIdToSharedUiPreviewComponent()
    {
        var Razor = ReadSourceFile("PrTask.Client", "Pages", "ClientDeploymentPreviewPage.razor");
        Assert.IsTrue(Razor.Contains("PrTask.SharedUI.Pages.DeploymentPreviewPage", StringComparison.Ordinal), "Client deployment preview must delegate to SharedUI");
        Assert.IsTrue(Razor.Contains("DeploymentId=\"@DeploymentId\"", StringComparison.Ordinal), "Client deployment preview must pass DeploymentId parameter");
        Assert.IsTrue(Razor.Contains("string DeploymentId", StringComparison.Ordinal), "Client deployment preview must define DeploymentId property");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client pull request detail wrapper must pass pr id to shared ui pr detail component")]
    public void ClientPullRequestDetailWrapperMustPassPrIdToSharedUiPrDetailComponent()
    {
        var Razor = ReadSourceFile("PrTask.Client", "Pages", "ClientPullRequestDetailPage.razor");
        Assert.IsTrue(Razor.Contains("PrTask.SharedUI.Pages.PullRequestDetailPage", StringComparison.Ordinal), "Client PR detail must delegate to SharedUI");
        Assert.IsTrue(Razor.Contains("PrId=\"@PrId\"", StringComparison.Ordinal), "Client PR detail must pass PrId parameter");
        Assert.IsTrue(Razor.Contains("string PrId", StringComparison.Ordinal), "Client PR detail must define PrId property");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client repository wrapper must delegate to shared ui client repository page component")]
    public void ClientRepositoryWrapperMustDelegateToSharedUiClientRepositoryPageComponent()
    {
        var Razor = ReadSourceFile("PrTask.Client", "Pages", "Client", "ClientRepositoryPage.razor");
        Assert.IsTrue(Razor.Contains("PrTask.SharedUI.Pages.Client.RepositoryPage", StringComparison.Ordinal), "Client repository must delegate to SharedUI RepositoryPage");
        Assert.IsTrue(Razor.Contains("/client/repository", StringComparison.Ordinal), "Client repository must have client/repository route");
    }
}
