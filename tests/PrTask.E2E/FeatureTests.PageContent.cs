namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Dashboard page must display stat cards for active tasks prs submitted earnings and level")]
    public void DashboardPageMustDisplayStatCardsForActiveTasksPrsSubmittedEarningsAndLevel()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "DashboardPage.razor");
        Assert.IsTrue(Razor.Contains("dashboard-stats", StringComparison.Ordinal), "Dashboard must have stats section");
        Assert.IsTrue(Razor.Contains("stat-card", StringComparison.Ordinal), "Dashboard must use stat-card elements");
        Assert.IsTrue(Razor.Contains("Recent Activity", StringComparison.Ordinal), "Dashboard must have recent activity section");
        Assert.IsTrue(Razor.Contains("empty-state", StringComparison.Ordinal), "Dashboard must handle empty state gracefully");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Profile page must inject user service and leaderboard service for data loading")]
    public void ProfilePageMustInjectUserServiceAndLeaderboardServiceForDataLoading()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "ProfilePage.razor");
        Assert.IsTrue(Razor.Contains("IUserService", StringComparison.Ordinal), "Profile must inject IUserService");
        Assert.IsTrue(Razor.Contains("ILeaderboardService", StringComparison.Ordinal), "Profile must inject ILeaderboardService");
        Assert.IsTrue(Razor.Contains("GetByIdAsync", StringComparison.Ordinal), "Profile must call GetByIdAsync to load user");
        Assert.IsTrue(Razor.Contains("GetRankAsync", StringComparison.Ordinal), "Profile must call GetRankAsync for leaderboard rank");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Profile page must display avatar username level xp streak and total earned amount")]
    public void ProfilePageMustDisplayAvatarUsernameLevelXpStreakAndTotalEarnedAmount()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "ProfilePage.razor");
        Assert.IsTrue(Razor.Contains("profile-avatar", StringComparison.Ordinal), "Profile must display user avatar");
        Assert.IsTrue(Razor.Contains("GitHubUsername", StringComparison.Ordinal), "Profile must show GitHub username");
        Assert.IsTrue(Razor.Contains("Total Earned", StringComparison.Ordinal), "Profile must show total earned amount");
        Assert.IsTrue(Razor.Contains("Leaderboard Rank", StringComparison.Ordinal), "Profile must show leaderboard rank");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Profile page must format earned amount in dollars and show loading state while fetching")]
    public void ProfilePageMustFormatEarnedAmountInDollarsAndShowLoadingStateWhileFetching()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "ProfilePage.razor");
        Assert.IsTrue(Razor.Contains("FormatEarnedAmount", StringComparison.Ordinal), "Profile must format earned amount");
        Assert.IsTrue(Razor.Contains("Loading profile", StringComparison.Ordinal), "Profile must show loading state");
        Assert.IsTrue(Razor.Contains("UserId", StringComparison.Ordinal), "Profile must accept UserId route parameter");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task list page must inject task service and display open tasks with bounty and complexity")]
    public void TaskListPageMustInjectTaskServiceAndDisplayOpenTasksWithBountyAndComplexity()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "TaskList.razor");
        Assert.IsTrue(Razor.Contains("ITaskService", StringComparison.Ordinal), "TaskList must inject ITaskService");
        Assert.IsTrue(Razor.Contains("ListOpenAsync", StringComparison.Ordinal), "TaskList must call ListOpenAsync");
        Assert.IsTrue(Razor.Contains("task-card", StringComparison.Ordinal), "TaskList must render task cards");
        Assert.IsTrue(Razor.Contains("task-bounty", StringComparison.Ordinal), "TaskList must display bounty amount");
        Assert.IsTrue(Razor.Contains("task-complexity", StringComparison.Ordinal), "TaskList must display complexity level");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task list page must show tags truncated description and view task link for each task")]
    public void TaskListPageMustShowTagsTruncatedDescriptionAndViewTaskLinkForEachTask()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "TaskList.razor");
        Assert.IsTrue(Razor.Contains("task-tags", StringComparison.Ordinal), "TaskList must display task tags");
        Assert.IsTrue(Razor.Contains("TruncateDescription", StringComparison.Ordinal), "TaskList must truncate long descriptions");
        Assert.IsTrue(Razor.Contains("View Task", StringComparison.Ordinal), "TaskList must have View Task link");
        Assert.IsTrue(Razor.Contains("empty-state", StringComparison.Ordinal), "TaskList must handle empty state");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Create task page must have form with title description repo url complexity and bounty fields")]
    public void CreateTaskPageMustHaveFormWithTitleDescriptionRepoUrlComplexityAndBountyFields()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "Client", "CreateTaskPage.razor");
        Assert.IsTrue(Razor.Contains("Task Title", StringComparison.Ordinal), "Create task must have title field");
        Assert.IsTrue(Razor.Contains("Description", StringComparison.Ordinal), "Create task must have description field");
        Assert.IsTrue(Razor.Contains("Repository URL", StringComparison.Ordinal), "Create task must have repo URL field");
        Assert.IsTrue(Razor.Contains("Complexity Level", StringComparison.Ordinal), "Create task must have complexity selector");
        Assert.IsTrue(Razor.Contains("Bounty Amount", StringComparison.Ordinal), "Create task must have bounty amount input");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Create task page must have tags input visibility selector and submit button for task creation")]
    public void CreateTaskPageMustHaveTagsInputVisibilitySelectorAndSubmitButtonForTaskCreation()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "Client", "CreateTaskPage.razor");
        Assert.IsTrue(Razor.Contains("Tags", StringComparison.Ordinal), "Create task must have tags input");
        Assert.IsTrue(Razor.Contains("Code Visibility", StringComparison.Ordinal), "Create task must have code visibility selector");
        Assert.IsTrue(Razor.Contains("Public", StringComparison.Ordinal), "Create task must have Public visibility option");
        Assert.IsTrue(Razor.Contains("Private", StringComparison.Ordinal), "Create task must have Private visibility option");
        Assert.IsTrue(Razor.Contains("Create Task", StringComparison.Ordinal), "Create task must have submit button");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Create task page must enforce max title length and minimum bounty from app constants")]
    public void CreateTaskPageMustEnforceMaxTitleLengthAndMinimumBountyFromAppConstants()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "Client", "CreateTaskPage.razor");
        Assert.IsTrue(Razor.Contains("MaxTaskTitleLength", StringComparison.Ordinal), "Create task must enforce max title length");
        Assert.IsTrue(Razor.Contains("MaxTaskDescriptionLength", StringComparison.Ordinal), "Create task must enforce max description length");
        Assert.IsTrue(Razor.Contains("MinBountyAmountCents", StringComparison.Ordinal), "Create task must enforce minimum bounty amount");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Create task page must navigate to task detail after successful submission via navigation manager")]
    public void CreateTaskPageMustNavigateToTaskDetailAfterSuccessfulSubmissionViaNavigationManager()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "Client", "CreateTaskPage.razor");
        Assert.IsTrue(Razor.Contains("NavigationManager", StringComparison.Ordinal), "Create task must inject NavigationManager");
        Assert.IsTrue(Razor.Contains("NavigateTo", StringComparison.Ordinal), "Create task must navigate after submission");
        Assert.IsTrue(Razor.Contains("SubmitNewTask", StringComparison.Ordinal), "Create task must have submit handler method");
    }
}
