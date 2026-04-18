namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task list page must inject itask service and call list open async on initialization")]
    public void TaskListPageMustInjectITaskServiceAndCallListOpenAsyncOnInitialization()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "TaskList.razor");
        Assert.IsTrue(Code.Contains("@inject ITaskService TaskService", StringComparison.Ordinal), "TaskList must inject ITaskService");
        Assert.IsTrue(Code.Contains("ListOpenAsync", StringComparison.Ordinal), "TaskList must call ListOpenAsync for open tasks");
        Assert.IsTrue(Code.Contains("OnInitializedAsync", StringComparison.Ordinal), "TaskList must override OnInitializedAsync");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task list page must format bounty as dollar amount by dividing cents by hundred decimal")]
    public void TaskListPageMustFormatBountyAsDollarAmountByDividingCentsByHundredDecimal()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "TaskList.razor");
        Assert.IsTrue(Code.Contains("FormatBountyAmount", StringComparison.Ordinal), "TaskList must have FormatBountyAmount helper");
        Assert.IsTrue(Code.Contains("AmountCents / 100m", StringComparison.Ordinal), "FormatBountyAmount must divide cents by 100 decimal");
        Assert.IsTrue(Code.Contains("$\"${", StringComparison.Ordinal), "FormatBountyAmount must format with dollar sign prefix");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task list page must truncate description to hundred twenty characters with ellipsis suffix")]
    public void TaskListPageMustTruncateDescriptionToHundredTwentyCharactersWithEllipsisSuffix()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "TaskList.razor");
        Assert.IsTrue(Code.Contains("TruncateDescription", StringComparison.Ordinal), "TaskList must have TruncateDescription helper");
        Assert.IsTrue(Code.Contains("120", StringComparison.Ordinal), "TruncateDescription must use 120 char limit");
        Assert.IsTrue(Code.Contains("...", StringComparison.Ordinal), "TruncateDescription must append ellipsis when truncated");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task list page must show loading state null check and empty state when no tasks available")]
    public void TaskListPageMustShowLoadingStateNullCheckAndEmptyStateWhenNoTasksAvailable()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "TaskList.razor");
        Assert.IsTrue(Code.Contains("OpenTasks is null", StringComparison.Ordinal), "TaskList must check null for loading state");
        Assert.IsTrue(Code.Contains("Loading tasks...", StringComparison.Ordinal), "TaskList must show loading message");
        Assert.IsTrue(Code.Contains("OpenTasks.Count == 0", StringComparison.Ordinal), "TaskList must check count for empty state");
        Assert.IsTrue(Code.Contains("No open tasks right now", StringComparison.Ordinal), "TaskList must show empty state message");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task list page must render complexity badge with lowercase css class modifier for styling")]
    public void TaskListPageMustRenderComplexityBadgeWithLowercaseCssClassModifierForStyling()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "TaskList.razor");
        Assert.IsTrue(Code.Contains("complexity-@CurrentTask.Complexity.ToString().ToLowerInvariant()", StringComparison.Ordinal), "TaskList must apply lowercase complexity class");
        Assert.IsTrue(Code.Contains("task-grid", StringComparison.Ordinal), "TaskList must use task-grid container");
        Assert.IsTrue(Code.Contains("task-card", StringComparison.Ordinal), "TaskList must use task-card for each item");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task list page must conditionally render tags section and view task link with formatted id")]
    public void TaskListPageMustConditionallyRenderTagsSectionAndViewTaskLinkWithFormattedId()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "TaskList.razor");
        Assert.IsTrue(Code.Contains("CurrentTask.Tags is not null", StringComparison.Ordinal), "TaskList must check tags for null before rendering");
        Assert.IsTrue(Code.Contains("task-tags", StringComparison.Ordinal), "TaskList must use task-tags container");
        Assert.IsTrue(Code.Contains("View Task", StringComparison.Ordinal), "TaskList must have View Task link text");
        Assert.IsTrue(Code.Contains("InvariantCulture", StringComparison.Ordinal), "TaskList must use InvariantCulture for URL formatting");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Leaderboard page must render avatar images with alt text and handle null avatar url check")]
    public void LeaderboardPageMustRenderAvatarImagesWithAltTextAndHandleNullAvatarUrlCheck()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "LeaderboardPage.razor");
        Assert.IsTrue(Code.Contains("Entry.AvatarUrl is not null", StringComparison.Ordinal), "Leaderboard must check avatar URL for null");
        Assert.IsTrue(Code.Contains("class=\"avatar\"", StringComparison.Ordinal), "Leaderboard must use avatar CSS class for images");
        Assert.IsTrue(Code.Contains("alt=\"@Entry.GitHubUsername\"", StringComparison.Ordinal), "Leaderboard avatar must have username alt text");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Leaderboard page must display rank with hash prefix and level with lv dot prefix format")]
    public void LeaderboardPageMustDisplayRankWithHashPrefixAndLevelWithLvDotPrefixFormat()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "LeaderboardPage.razor");
        Assert.IsTrue(Code.Contains("#@Entry.Rank", StringComparison.Ordinal), "Leaderboard must display rank with # prefix");
        Assert.IsTrue(Code.Contains("Lv.@Entry.Level", StringComparison.Ordinal), "Leaderboard must display level with Lv. prefix");
        Assert.IsTrue(Code.Contains("@Entry.Xp XP", StringComparison.Ordinal), "Leaderboard must display XP with suffix");
        Assert.IsTrue(Code.Contains("leaderboard-row", StringComparison.Ordinal), "Leaderboard must use leaderboard-row class");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Leaderboard page must request top fifty entries from service and format earnings as dollars")]
    public void LeaderboardPageMustRequestTopFiftyEntriesFromServiceAndFormatEarningsAsDollars()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "LeaderboardPage.razor");
        Assert.IsTrue(Code.Contains("GetTopAsync(50)", StringComparison.Ordinal), "Leaderboard must request top 50 entries");
        Assert.IsTrue(Code.Contains("FormatEarnedAmount(Entry.TotalEarnedCents)", StringComparison.Ordinal), "Leaderboard must format earned amount from cents");
        Assert.IsTrue(Code.Contains("AmountCents / 100m", StringComparison.Ordinal), "FormatEarnedAmount must convert cents to dollars");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Profile page must inject user service and leaderboard service for profile and rank data")]
    public void ProfilePageMustInjectUserServiceAndLeaderboardServiceForProfileAndRankData()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "ProfilePage.razor");
        Assert.IsTrue(Code.Contains("@inject IUserService UserService", StringComparison.Ordinal), "Profile must inject IUserService");
        Assert.IsTrue(Code.Contains("@inject ILeaderboardService LeaderboardService", StringComparison.Ordinal), "Profile must inject ILeaderboardService");
        Assert.IsTrue(Code.Contains("UserService.GetByIdAsync(UserId)", StringComparison.Ordinal), "Profile must fetch user by ID");
        Assert.IsTrue(Code.Contains("LeaderboardService.GetRankAsync(UserId)", StringComparison.Ordinal), "Profile must fetch user rank");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Profile page must display user avatar badges for level xp and streak days count")]
    public void ProfilePageMustDisplayUserAvatarBadgesForLevelXpAndStreakDaysCount()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "ProfilePage.razor");
        Assert.IsTrue(Code.Contains("profile-avatar", StringComparison.Ordinal), "Profile must use profile-avatar class for image");
        Assert.IsTrue(Code.Contains("Lv. @ProfileUser.Level", StringComparison.Ordinal), "Profile must show level badge");
        Assert.IsTrue(Code.Contains("@ProfileUser.Xp XP", StringComparison.Ordinal), "Profile must show XP badge");
        Assert.IsTrue(Code.Contains("@ProfileUser.StreakDays Day Streak", StringComparison.Ordinal), "Profile must show streak days badge");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Profile page must show display name with github username fallback and at symbol prefix")]
    public void ProfilePageMustShowDisplayNameWithGitHubUsernameFallbackAndAtSymbolPrefix()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "ProfilePage.razor");
        Assert.IsTrue(Code.Contains("ProfileUser.DisplayName ?? ProfileUser.GitHubUsername", StringComparison.Ordinal), "Profile must fallback to GitHubUsername if DisplayName null");
        Assert.IsTrue(Code.Contains("profile-username", StringComparison.Ordinal), "Profile must have profile-username class");
        Assert.IsTrue(Code.Contains("@@@ProfileUser.GitHubUsername", StringComparison.Ordinal), "Profile must prefix username with @ symbol");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Profile page must show leaderboard rank and total earned stats with dollar formatting")]
    public void ProfilePageMustShowLeaderboardRankAndTotalEarnedStatsWithDollarFormatting()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "ProfilePage.razor");
        Assert.IsTrue(Code.Contains("#@UserRank", StringComparison.Ordinal), "Profile must show rank with hash prefix");
        Assert.IsTrue(Code.Contains("Leaderboard Rank", StringComparison.Ordinal), "Profile must label rank as Leaderboard Rank");
        Assert.IsTrue(Code.Contains("Total Earned", StringComparison.Ordinal), "Profile must show Total Earned label");
        Assert.IsTrue(Code.Contains("FormatEarnedAmount(ProfileUser.TotalEarnedCents)", StringComparison.Ordinal), "Profile must format earned from cents");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task detail page must show claim button only when task status is open for claiming")]
    public void TaskDetailPageMustShowClaimButtonOnlyWhenTaskStatusIsOpenForClaiming()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "TaskDetailPage.razor");
        Assert.IsTrue(Code.Contains("CurrentTask.Status == PrTaskStatus.Open", StringComparison.Ordinal), "TaskDetail must check Open status for claim button");
        Assert.IsTrue(Code.Contains("ClaimAsync(TaskId, \"current-user\")", StringComparison.Ordinal), "TaskDetail must call ClaimAsync on claim action");
        Assert.IsTrue(Code.Contains("DeleteAsync(TaskId)", StringComparison.Ordinal), "TaskDetail must call DeleteAsync on delete action");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task detail page must display deadline with mmm dd yyyy format using invariant culture")]
    public void TaskDetailPageMustDisplayDeadlineWithMmmDdYyyyFormatUsingInvariantCulture()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "TaskDetailPage.razor");
        Assert.IsTrue(Code.Contains("CurrentTask.Deadline.HasValue", StringComparison.Ordinal), "TaskDetail must check deadline HasValue");
        Assert.IsTrue(Code.Contains("MMM dd, yyyy", StringComparison.Ordinal), "TaskDetail must format deadline as MMM dd, yyyy");
        Assert.IsTrue(Code.Contains("InvariantCulture", StringComparison.Ordinal), "TaskDetail must use InvariantCulture for date formatting");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request detail page must toggle between unified and split diff view with css classes")]
    public void PullRequestDetailPageMustToggleBetweenUnifiedAndSplitDiffViewWithCssClasses()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "PullRequestDetailPage.razor");
        Assert.IsTrue(Code.Contains("IsUnifiedView", StringComparison.Ordinal), "PRDetail must track IsUnifiedView state");
        Assert.IsTrue(Code.Contains("diff-unified", StringComparison.Ordinal), "PRDetail must apply diff-unified CSS class");
        Assert.IsTrue(Code.Contains("diff-split", StringComparison.Ordinal), "PRDetail must apply diff-split CSS class");
        Assert.IsTrue(Code.Contains("DiffViewLabel", StringComparison.Ordinal), "PRDetail must compute diff view toggle label");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request detail page must show diff lines with context deletion and addition line types")]
    public void PullRequestDetailPageMustShowDiffLinesWithContextDeletionAndAdditionLineTypes()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "PullRequestDetailPage.razor");
        Assert.IsTrue(Code.Contains("line-context", StringComparison.Ordinal), "PRDetail must have context line type");
        Assert.IsTrue(Code.Contains("line-del", StringComparison.Ordinal), "PRDetail must have deletion line type");
        Assert.IsTrue(Code.Contains("line-add", StringComparison.Ordinal), "PRDetail must have addition line type");
        Assert.IsTrue(Code.Contains("diff-file-header", StringComparison.Ordinal), "PRDetail must have file header in diff");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Deployment preview page must build preview url with deploy prefix and pages dev domain")]
    public void DeploymentPreviewPageMustBuildPreviewUrlWithDeployPrefixAndPagesDevDomain()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "DeploymentPreviewPage.razor");
        Assert.IsTrue(Code.Contains("deploy-preview-{DeploymentId}", StringComparison.Ordinal), "Preview URL must include deployment ID");
        Assert.IsTrue(Code.Contains("AppConstants.CloudflarePagesProject", StringComparison.Ordinal), "Preview URL must use Cloudflare project name");
        Assert.IsTrue(Code.Contains("Building...", StringComparison.Ordinal), "Default build status must be Building");
        Assert.IsTrue(Code.Contains("pr-@DeploymentId", StringComparison.Ordinal), "Deployment must show branch as pr-{id}");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Download page must use app constants domain for web app link and download attribute on apk")]
    public void DownloadPageMustUseAppConstantsDomainForWebAppLinkAndDownloadAttributeOnApk()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "DownloadPage.razor");
        Assert.IsTrue(Code.Contains("AppConstants.AppDomain", StringComparison.Ordinal), "Download must use AppConstants.AppDomain for web link");
        Assert.IsTrue(Code.Contains("download>Download Android APK", StringComparison.Ordinal), "APK link must have download attribute");
        Assert.IsTrue(Code.Contains("@using PrTask.Domain.Constants", StringComparison.Ordinal), "Download must import Domain Constants");
    }
}
