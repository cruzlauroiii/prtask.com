namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client dashboard must inject http client and check api auth me endpoint on initialized")]
    public void ClientDashboardMustInjectHttpClientAndCheckApiAuthMeEndpointOnInitialized()
    {
        var Code = ReadSourceFile("PrTask.Client", "Pages", "ClientDashboardPage.razor");
        Assert.IsTrue(Code.Contains("@inject HttpClient Http", StringComparison.Ordinal), "ClientDashboard must inject HttpClient");
        Assert.IsTrue(Code.Contains("Http.GetAsync(RouteConstants.ApiAuthMe)", StringComparison.Ordinal), "ClientDashboard must call ApiAuthMe endpoint");
        Assert.IsTrue(Code.Contains("Response.IsSuccessStatusCode", StringComparison.Ordinal), "ClientDashboard must check response success");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client dashboard must deserialize auth user and set is logged in with username or developer default")]
    public void ClientDashboardMustDeserializeAuthUserAndSetIsLoggedInWithUsernameOrDeveloperDefault()
    {
        var Code = ReadSourceFile("PrTask.Client", "Pages", "ClientDashboardPage.razor");
        Assert.IsTrue(Code.Contains("ReadFromJsonAsync<AuthUser>()", StringComparison.Ordinal), "ClientDashboard must deserialize AuthUser response");
        Assert.IsTrue(Code.Contains("User?.Username ?? \"Developer\"", StringComparison.Ordinal), "ClientDashboard must default username to Developer");
        Assert.IsTrue(Code.Contains("IsLoggedIn = true", StringComparison.Ordinal), "ClientDashboard must set IsLoggedIn on success");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client dashboard must catch http request exception and set is logged in false for network errors")]
    public void ClientDashboardMustCatchHttpRequestExceptionAndSetIsLoggedInFalseForNetworkErrors()
    {
        var Code = ReadSourceFile("PrTask.Client", "Pages", "ClientDashboardPage.razor");
        Assert.IsTrue(Code.Contains("catch (HttpRequestException) { IsLoggedIn = false; }", StringComparison.Ordinal), "ClientDashboard must handle HTTP errors gracefully");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client dashboard must show welcome username when logged in and sign in link when not authenticated")]
    public void ClientDashboardMustShowWelcomeUsernameWhenLoggedInAndSignInLinkWhenNotAuthenticated()
    {
        var Code = ReadSourceFile("PrTask.Client", "Pages", "ClientDashboardPage.razor");
        Assert.IsTrue(Code.Contains("Welcome, @Username", StringComparison.Ordinal), "ClientDashboard must show Welcome with username");
        Assert.IsTrue(Code.Contains("RouteConstants.Login", StringComparison.Ordinal), "ClientDashboard must link to login when not authenticated");
        Assert.IsTrue(Code.Contains("RouteConstants.Tasks", StringComparison.Ordinal), "ClientDashboard must link to tasks for activity");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client dashboard must define sealed auth user class with username string property for json deserialization")]
    public void ClientDashboardMustDefineSealedAuthUserClassWithUsernameStringPropertyForJsonDeserialization()
    {
        var Code = ReadSourceFile("PrTask.Client", "Pages", "ClientDashboardPage.razor");
        Assert.IsTrue(Code.Contains("sealed class AuthUser", StringComparison.Ordinal), "ClientDashboard must define sealed AuthUser nested class");
        Assert.IsTrue(Code.Contains("string Username { get; set; } = \"\"", StringComparison.Ordinal), "AuthUser must have Username property with empty default");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client about page must use route constants for legal links instead of hardcoded paths")]
    public void ClientAboutPageMustUseRouteConstantsForLegalLinksInsteadOfHardcodedPaths()
    {
        var Code = ReadSourceFile("PrTask.Client", "Pages", "ClientAboutPage.razor");
        Assert.IsTrue(Code.Contains("RouteConstants.Terms", StringComparison.Ordinal), "ClientAbout must use RouteConstants.Terms");
        Assert.IsTrue(Code.Contains("RouteConstants.Privacy", StringComparison.Ordinal), "ClientAbout must use RouteConstants.Privacy");
        Assert.IsTrue(Code.Contains("RouteConstants.CookiePolicy", StringComparison.Ordinal), "ClientAbout must use RouteConstants.CookiePolicy");
        Assert.IsTrue(Code.Contains("RouteConstants.Dmca", StringComparison.Ordinal), "ClientAbout must use RouteConstants.Dmca");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client task list must inject http client and fetch tasks from api tasks route constant endpoint")]
    public void ClientTaskListMustInjectHttpClientAndFetchTasksFromApiTasksRouteConstantEndpoint()
    {
        var Code = ReadSourceFile("PrTask.Client", "Pages", "ClientTaskListPage.razor");
        Assert.IsTrue(Code.Contains("@inject HttpClient HttpClient", StringComparison.Ordinal), "ClientTaskList must inject HttpClient");
        Assert.IsTrue(Code.Contains("HttpClient.GetFromJsonAsync<TaskEntity[]>(RouteConstants.ApiTasks)", StringComparison.Ordinal), "ClientTaskList must fetch tasks from ApiTasks route");
        Assert.IsTrue(Code.Contains("catch (HttpRequestException)", StringComparison.Ordinal), "ClientTaskList must catch HTTP errors");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client task list must use task entity array instead of read only list and default to empty array")]
    public void ClientTaskListMustUseTaskEntityArrayInsteadOfReadOnlyListAndDefaultToEmptyArray()
    {
        var Code = ReadSourceFile("PrTask.Client", "Pages", "ClientTaskListPage.razor");
        Assert.IsTrue(Code.Contains("TaskEntity[]? OpenTasks", StringComparison.Ordinal), "ClientTaskList must use TaskEntity array type");
        Assert.IsTrue(Code.Contains("?? []", StringComparison.Ordinal), "ClientTaskList must default null response to empty array");
        Assert.IsTrue(Code.Contains("OpenTasks = []", StringComparison.Ordinal), "ClientTaskList must set empty array on HTTP error");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client leaderboard must inject http client and fetch from api leaderboard route with error handling")]
    public void ClientLeaderboardMustInjectHttpClientAndFetchFromApiLeaderboardRouteWithErrorHandling()
    {
        var Code = ReadSourceFile("PrTask.Client", "Pages", "ClientLeaderboardPage.razor");
        Assert.IsTrue(Code.Contains("@inject HttpClient HttpClient", StringComparison.Ordinal), "ClientLeaderboard must inject HttpClient");
        Assert.IsTrue(Code.Contains("HttpClient.GetFromJsonAsync<LeaderboardEntry[]>(RouteConstants.ApiLeaderboard)", StringComparison.Ordinal), "ClientLeaderboard must fetch from ApiLeaderboard");
        Assert.IsTrue(Code.Contains("catch (HttpRequestException)", StringComparison.Ordinal), "ClientLeaderboard must handle HTTP errors");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client leaderboard must use leaderboard entry array type and display rank username xp and earned")]
    public void ClientLeaderboardMustUseLeaderboardEntryArrayTypeAndDisplayRankUsernameXpAndEarned()
    {
        var Code = ReadSourceFile("PrTask.Client", "Pages", "ClientLeaderboardPage.razor");
        Assert.IsTrue(Code.Contains("LeaderboardEntry[]? TopEntries", StringComparison.Ordinal), "ClientLeaderboard must use LeaderboardEntry array type");
        Assert.IsTrue(Code.Contains("Entry.GitHubUsername", StringComparison.Ordinal), "ClientLeaderboard must display GitHubUsername");
        Assert.IsTrue(Code.Contains("Entry.Xp", StringComparison.Ordinal), "ClientLeaderboard must display Xp value");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client wrapper pages must delegate to shared ui with parameter passing for task detail and pr detail")]
    public void ClientWrapperPagesMustDelegateToSharedUiWithParameterPassingForTaskDetailAndPrDetail()
    {
        var TaskDetail = ReadSourceFile("PrTask.Client", "Pages", "ClientTaskDetailPage.razor");
        Assert.IsTrue(TaskDetail.Contains("TaskId=\"@TaskId\"", StringComparison.Ordinal), "ClientTaskDetail must pass TaskId to SharedUI");
        Assert.IsTrue(TaskDetail.Contains("PrTask.SharedUI.Pages.TaskDetailPage", StringComparison.Ordinal), "ClientTaskDetail must delegate to SharedUI TaskDetailPage");
        var PrDetail = ReadSourceFile("PrTask.Client", "Pages", "ClientPullRequestDetailPage.razor");
        Assert.IsTrue(PrDetail.Contains("PrId=\"@PrId\"", StringComparison.Ordinal), "ClientPrDetail must pass PrId to SharedUI");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client home page must have hero section with earn money heading and feature cards without shared ui delegate")]
    public void ClientHomePageMustHaveHeroSectionWithEarnMoneyHeadingAndFeatureCardsWithoutSharedUiDelegate()
    {
        var Code = ReadSourceFile("PrTask.Client", "Pages", "ClientHomePage.razor");
        Assert.IsTrue(Code.Contains("Earn Money with Pull Requests", StringComparison.Ordinal), "ClientHome must have hero heading");
        Assert.IsTrue(Code.Contains("Pick a Task", StringComparison.Ordinal), "ClientHome must have Pick a Task feature card");
        Assert.IsTrue(Code.Contains("Submit Your PR", StringComparison.Ordinal), "ClientHome must have Submit Your PR feature card");
        Assert.IsTrue(Code.Contains("Get Paid", StringComparison.Ordinal), "ClientHome must have Get Paid feature card");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client login page must use anchor links to route constants for all four oauth providers")]
    public void ClientLoginPageMustUseAnchorLinksToRouteConstantsForAllFourOauthProviders()
    {
        var Code = ReadSourceFile("PrTask.Client", "Pages", "ClientLoginPage.razor");
        Assert.IsTrue(Code.Contains("RouteConstants.ApiAuthGoogle", StringComparison.Ordinal), "ClientLogin must link to Google auth");
        Assert.IsTrue(Code.Contains("RouteConstants.ApiAuthGitHub", StringComparison.Ordinal), "ClientLogin must link to GitHub auth");
        Assert.IsTrue(Code.Contains("RouteConstants.ApiAuthAzure", StringComparison.Ordinal), "ClientLogin must link to Azure auth");
        Assert.IsTrue(Code.Contains("RouteConstants.ApiAuthOkta", StringComparison.Ordinal), "ClientLogin must link to Okta auth");
    }
}
