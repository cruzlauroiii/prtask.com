using PrTask.Domain.Constants;
namespace PrTask.E2E;
[TestClass]
public class PlatformAndFeatureTests
{
    private static readonly string SourceRoot = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "..", "src"));
    private static readonly string InfraRoot = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "..", "infra"));
    private static readonly string MauiProject = "PrTask.Maui";
    private static readonly string SharedUiProject = "PrTask.SharedUI";
    private static readonly string ClientProject = "PrTask.Client";
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("MAUI index html must have safe area padding for Android status bar so notification icons do not overlap content")]
    public void MauiIndexHtmlMustHaveSafeAreaPaddingForAndroidStatusBarSoNotificationIconsDoNotOverlapContent()
    {
        var IndexPath = Path.Combine(SourceRoot, MauiProject, "wwwroot", "index.html");
        var Content = File.ReadAllText(IndexPath);
        Assert.IsTrue(
            Content.Contains("safe-area") || Content.Contains("env(safe-area-inset-top)") || Content.Contains("viewport-fit=cover"),
            "MAUI index.html must use viewport-fit=cover or safe-area-inset-top to handle Android status bar overlap");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("MAUI CSS must have top padding or safe area inset on nav menu to prevent status bar overlap")]
    public void MauiCssMustHaveTopPaddingOrSafeAreaInsetOnNavMenuToPreventStatusBarOverlap()
    {
        var ScssPath = Path.Combine(SourceRoot, SharedUiProject, "Styles", "app.scss");
        var Content = File.ReadAllText(ScssPath);
        Assert.IsTrue(
            Content.Contains("safe-area-inset-top") || Content.Contains("padding-top: env(") || Content.Contains("status-bar"),
            "SCSS must include safe-area-inset-top padding on nav-menu to prevent Android status bar from overlapping content");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("MAUI layout must detect authentication state and show username and sign out after SSO login")]
    public void MauiLayoutMustDetectAuthenticationStateAndShowUsernameAndSignOutAfterSsoLogin()
    {
        var MauiLayoutPath = Path.Combine(SourceRoot, MauiProject, "Components", "MauiLayout.razor");
        var Content = File.ReadAllText(MauiLayoutPath);
        Assert.IsTrue(
            Content.Contains("IsLoggedIn") || Content.Contains("session") || Content.Contains("Preferences"),
            "MAUI layout must check authentication state via session or Preferences");
        Assert.IsTrue(
            Content.Contains("Sign Out") || Content.Contains("Logout") || Content.Contains("nav-logout"),
            "MAUI layout must show Sign Out option when user is logged in");
        Assert.IsTrue(
            Content.Contains("Username") || Content.Contains("nav-user"),
            "MAUI layout must display the logged in username in the navigation");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("MAUI login page must update navigation state after successful SSO so sign in button changes to sign out")]
    public void MauiLoginPageMustUpdateNavigationStateAfterSuccessfulSsoSoSignInButtonChangesToSignOut()
    {
        var MauiLoginPath = Path.Combine(SourceRoot, MauiProject, "Pages", "MauiLoginPage.razor");
        var Content = File.ReadAllText(MauiLoginPath);
        Assert.IsTrue(Content.Contains("Preferences"), "MAUI login must store session in Preferences after SSO");
        Assert.IsTrue(Content.Contains("NavigationManager.NavigateTo"), "MAUI login must navigate after successful login");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Download page must have placeholder sections for Windows iOS Mac and Linux platforms not just Android")]
    public void DownloadPageMustHavePlaceholderSectionsForWindowsIosMacAndLinuxPlatformsNotJustAndroid()
    {
        var DownloadPath = Path.Combine(SourceRoot, SharedUiProject, "Pages", "DownloadPage.razor");
        var Content = File.ReadAllText(DownloadPath);
        Assert.IsTrue(Content.Contains("Android"), "Download page must have Android section");
        Assert.IsTrue(Content.Contains("Windows"), "Download page must have Windows placeholder section");
        Assert.IsTrue(Content.Contains("iOS") || Content.Contains("iPhone"), "Download page must have iOS placeholder section");
        Assert.IsTrue(Content.Contains("macOS") || Content.Contains("Mac"), "Download page must have macOS placeholder section");
        Assert.IsTrue(Content.Contains("Linux"), "Download page must have Linux placeholder section");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Download page platform placeholders must indicate coming soon status for unreleased platforms")]
    public void DownloadPagePlatformPlaceholdersMustIndicateComingSoonStatusForUnreleasedPlatforms()
    {
        var DownloadPath = Path.Combine(SourceRoot, SharedUiProject, "Pages", "DownloadPage.razor");
        var Content = File.ReadAllText(DownloadPath);
        Assert.IsTrue(
            Content.Contains("Coming Soon") || Content.Contains("coming soon") || Content.Contains("coming-soon"),
            "Download page must indicate Coming Soon for platforms not yet available");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Route constants must define routes for task CRUD operations including create edit and delete")]
    public void RouteConstantsMustDefineRoutesForTaskCrudOperationsIncludingCreateEditAndDelete()
    {
        var RoutesPath = Path.Combine(SourceRoot, "PrTask.Domain", "Constants", "RouteConstants.cs");
        var Content = File.ReadAllText(RoutesPath);
        Assert.IsTrue(Content.Contains("ClientCreateTask"), "Routes must have create task route");
        Assert.IsTrue(Content.Contains("TaskDetail"), "Routes must have task detail route for reading individual tasks");
        Assert.IsTrue(Content.Contains("Tasks"), "Routes must have tasks list route");
        Assert.IsTrue(
            Content.Contains("EditTask") || Content.Contains("TaskEdit"),
            "Routes must have edit task route for updating existing tasks");
        Assert.IsTrue(
            Content.Contains("DeleteTask") || Content.Contains("TaskDelete") || Content.Contains("ApiTaskDelete"),
            "Routes must have delete task route or API endpoint for removing tasks");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Task detail page must have edit and delete actions for task owner to manage their tasks")]
    public void TaskDetailPageMustHaveEditAndDeleteActionsForTaskOwnerToManageTheirTasks()
    {
        var TaskDetailPath = Path.Combine(SourceRoot, SharedUiProject, "Pages", "TaskDetailPage.razor");
        var Content = File.ReadAllText(TaskDetailPath);
        Assert.IsTrue(
            Content.Contains("Edit") || Content.Contains("edit"),
            "Task detail must have edit action for task owner");
        Assert.IsTrue(
            Content.Contains("Delete") || Content.Contains("delete") || Content.Contains("Cancel Task"),
            "Task detail must have delete or cancel action for task owner");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Worker API must have task CRUD endpoints for create read update and delete operations")]
    public void WorkerApiMustHaveTaskCrudEndpointsForCreateReadUpdateAndDeleteOperations()
    {
        var WorkerPath = Path.Combine(InfraRoot, "worker.js");
        var Content = File.ReadAllText(WorkerPath);
        Assert.IsTrue(Content.Contains("/api/tasks") && Content.Contains("GET"), "Worker must have GET /api/tasks for reading tasks");
        Assert.IsTrue(
            Content.Contains("/api/tasks") && Content.Contains("POST"),
            "Worker must have POST /api/tasks for creating tasks");
        Assert.IsTrue(
            Content.Contains("PUT") || Content.Contains("PATCH"),
            "Worker must have PUT or PATCH endpoint for updating tasks");
        Assert.IsTrue(
            Content.Contains("DELETE"),
            "Worker must have DELETE endpoint for removing tasks");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Route constants must define settings route for user configuration page")]
    public void RouteConstantsMustDefineSettingsRouteForUserConfigurationPage()
    {
        var RoutesPath = Path.Combine(SourceRoot, "PrTask.Domain", "Constants", "RouteConstants.cs");
        var Content = File.ReadAllText(RoutesPath);
        Assert.IsTrue(
            Content.Contains("Settings") || Content.Contains("settings"),
            "Routes must define a settings route for user configuration page");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Settings page must exist in SharedUI with user configuration options for withdrawals deposits and preferences")]
    public void SettingsPageMustExistInSharedUiWithUserConfigurationOptionsForWithdrawalsDepositsAndPreferences()
    {
        var SettingsFiles = Directory.GetFiles(
            Path.Combine(SourceRoot, SharedUiProject, "Pages"),
            "*Settings*",
            SearchOption.AllDirectories);
        Assert.IsTrue(SettingsFiles.Length > 0, "SharedUI must have a SettingsPage for user configuration");
        var Content = File.ReadAllText(SettingsFiles[0]);
        Assert.IsTrue(
            Content.Contains("Withdraw") || Content.Contains("withdraw") || Content.Contains("Payout") || Content.Contains("payout"),
            "Settings page must have withdrawal or payout configuration section");
        Assert.IsTrue(
            Content.Contains("Deposit") || Content.Contains("deposit") || Content.Contains("Payment") || Content.Contains("payment"),
            "Settings page must have deposit or payment method configuration section");
        Assert.IsTrue(
            Content.Contains("@page"), "Settings page must have a @page route directive");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Settings page must have profile notification and account management sections for comprehensive user control")]
    public void SettingsPageMustHaveProfileNotificationAndAccountManagementSectionsForComprehensiveUserControl()
    {
        var SettingsFiles = Directory.GetFiles(
            Path.Combine(SourceRoot, SharedUiProject, "Pages"),
            "*Settings*",
            SearchOption.AllDirectories);
        Assert.IsTrue(SettingsFiles.Length > 0, "SharedUI must have a SettingsPage");
        var Content = File.ReadAllText(SettingsFiles[0]);
        Assert.IsTrue(
            Content.Contains("Profile") || Content.Contains("profile") || Content.Contains("Display Name") || Content.Contains("Avatar"),
            "Settings must have profile editing section");
        Assert.IsTrue(
            Content.Contains("Notification") || Content.Contains("notification") || Content.Contains("Email") || Content.Contains("email"),
            "Settings must have notification or email preferences section");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Settings page must exist as wrapper in Client and MAUI projects for clean architecture")]
    public void SettingsPageMustExistAsWrapperInClientAndMauiProjectsForCleanArchitecture()
    {
        var ClientSettings = Directory.GetFiles(
            Path.Combine(SourceRoot, ClientProject, "Pages"),
            "*Settings*",
            SearchOption.AllDirectories);
        var MauiSettings = Directory.GetFiles(
            Path.Combine(SourceRoot, MauiProject, "Pages"),
            "*Settings*",
            SearchOption.AllDirectories);
        Assert.IsTrue(ClientSettings.Length > 0, "Client project must have a SettingsPage wrapper");
        Assert.IsTrue(MauiSettings.Length > 0, "MAUI project must have a SettingsPage wrapper");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Nav menu must have link to settings page for user to access configuration")]
    public void NavMenuMustHaveLinkToSettingsPageForUserToAccessConfiguration()
    {
        var NavMenuPath = Path.Combine(SourceRoot, SharedUiProject, "Components", "NavMenu.razor");
        var Content = File.ReadAllText(NavMenuPath);
        Assert.IsTrue(
            Content.Contains("Settings") || Content.Contains("settings"),
            "Nav menu must have a link to the Settings page");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("MAUI clear cache reload button must trigger actual page reload not just be a dead link")]
    public void MauiClearCacheReloadButtonMustTriggerActualPageReloadNotJustBeADeadLink()
    {
        var NavMenuPath = Path.Combine(SourceRoot, SharedUiProject, "Components", "NavMenu.razor");
        var Content = File.ReadAllText(NavMenuPath);
        Assert.IsTrue(Content.Contains("clear-cache") || Content.Contains("21bb"), "Nav must have refresh or clear cache element");
        var IndexPath = Path.Combine(SourceRoot, MauiProject, "wwwroot", "index.html");
        var MauiIndexExists = File.Exists(IndexPath);
        Assert.IsTrue(MauiIndexExists, "MAUI wwwroot/index.html must exist");
        var ClearCachePath = Path.Combine(SourceRoot, MauiProject, "wwwroot", "clear-cache.html");
        Assert.IsTrue(
            File.Exists(ClearCachePath),
            "MAUI wwwroot must have clear-cache.html that handles cache clearing and reload for the refresh button to work");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Task detail page must show list of pull requests submitted by developers for client to review and choose")]
    public void TaskDetailPageMustShowListOfPullRequestsSubmittedByDevelopersForClientToReviewAndChoose()
    {
        var TaskDetailPath = Path.Combine(SourceRoot, SharedUiProject, "Pages", "TaskDetailPage.razor");
        var Content = File.ReadAllText(TaskDetailPath);
        Assert.IsTrue(
            Content.Contains("Pull Request") || Content.Contains("PullRequest") || Content.Contains("pull-request") || Content.Contains("pr-list"),
            "Task detail must show pull requests section for developers submissions");
        Assert.IsTrue(
            Content.Contains("Approve") || Content.Contains("Accept") || Content.Contains("Choose") || Content.Contains("Select") || Content.Contains("Merge"),
            "Task detail must have action for client to approve or select a pull request");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Route constants must define pull request detail route for viewing individual PR submissions")]
    public void RouteConstantsMustDefinePullRequestDetailRouteForViewingIndividualPrSubmissions()
    {
        var RoutesPath = Path.Combine(SourceRoot, "PrTask.Domain", "Constants", "RouteConstants.cs");
        var Content = File.ReadAllText(RoutesPath);
        Assert.IsTrue(Content.Contains("PullRequestDetail"), "Routes must have pull request detail route");
        Assert.IsTrue(Content.Contains("PullRequests"), "Routes must have pull requests list route");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Diff page must exist in SharedUI for viewing pull request code changes with additions and deletions")]
    public void DiffPageMustExistInSharedUiForViewingPullRequestCodeChangesWithAdditionsAndDeletions()
    {
        var DiffFiles = Directory.GetFiles(
            Path.Combine(SourceRoot, SharedUiProject, "Pages"),
            "*Diff*",
            SearchOption.AllDirectories);
        var PrDetailFiles = Directory.GetFiles(
            Path.Combine(SourceRoot, SharedUiProject, "Pages"),
            "*PullRequest*",
            SearchOption.AllDirectories);
        var AllFiles = DiffFiles.Concat(PrDetailFiles).ToArray();
        Assert.IsTrue(AllFiles.Length > 0, "SharedUI must have a DiffPage or PullRequestDetailPage for viewing code changes");
        var Content = File.ReadAllText(AllFiles[0]);
        Assert.IsTrue(
            Content.Contains("diff") || Content.Contains("Diff") || Content.Contains("changes") || Content.Contains("Changes"),
            "Diff page must display code changes or diff content");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Diff page must show additions and deletions with proper styling for code review experience")]
    public void DiffPageMustShowAdditionsAndDeletionsWithProperStylingForCodeReviewExperience()
    {
        var DiffFiles = Directory.GetFiles(
            Path.Combine(SourceRoot, SharedUiProject, "Pages"),
            "*Diff*",
            SearchOption.AllDirectories);
        var PrDetailFiles = Directory.GetFiles(
            Path.Combine(SourceRoot, SharedUiProject, "Pages"),
            "*PullRequest*",
            SearchOption.AllDirectories);
        var AllFiles = DiffFiles.Concat(PrDetailFiles).ToArray();
        Assert.IsTrue(AllFiles.Length > 0, "SharedUI must have diff or PR detail page");
        var Content = File.ReadAllText(AllFiles[0]);
        Assert.IsTrue(
            Content.Contains("addition") || Content.Contains("deletion") || Content.Contains("added") || Content.Contains("removed") || Content.Contains("diff-line") || Content.Contains("line-add") || Content.Contains("line-del"),
            "Diff page must differentiate between additions and deletions");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Route constants must define repository or source code route for clients to post their code")]
    public void RouteConstantsMustDefineRepositoryOrSourceCodeRouteForClientsToPostTheirCode()
    {
        var RoutesPath = Path.Combine(SourceRoot, "PrTask.Domain", "Constants", "RouteConstants.cs");
        var Content = File.ReadAllText(RoutesPath);
        Assert.IsTrue(
            Content.Contains("Repository") || Content.Contains("SourceCode") || Content.Contains("Repo") || Content.Contains("Code"),
            "Routes must define a repository or source code route for clients to post their code");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Source code page must exist for clients to post repositories with public and private visibility options")]
    public void SourceCodePageMustExistForClientsToPostRepositoriesWithPublicAndPrivateVisibilityOptions()
    {
        var RepoFiles = Directory.GetFiles(
            Path.Combine(SourceRoot, SharedUiProject, "Pages"),
            "*.razor",
            SearchOption.AllDirectories)
            .Where(F => Path.GetFileName(F).Contains("Repo", StringComparison.OrdinalIgnoreCase)
                || Path.GetFileName(F).Contains("Source", StringComparison.OrdinalIgnoreCase)
                || Path.GetFileName(F).Contains("Code", StringComparison.OrdinalIgnoreCase))
            .ToArray();
        Assert.IsTrue(RepoFiles.Length > 0, "SharedUI must have a repository or source code page for clients to post code");
        var Content = File.ReadAllText(RepoFiles[0]);
        Assert.IsTrue(
            Content.Contains("Public") || Content.Contains("public"),
            "Source code page must support public visibility option");
        Assert.IsTrue(
            Content.Contains("Private") || Content.Contains("private"),
            "Source code page must support private visibility option");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Task creation must support visibility setting for public or private code changes on submitted work")]
    public void TaskCreationMustSupportVisibilitySettingForPublicOrPrivateCodeChangesOnSubmittedWork()
    {
        var CreateTaskPath = Path.Combine(SourceRoot, SharedUiProject, "Pages", "Client", "CreateTaskPage.razor");
        var Content = File.ReadAllText(CreateTaskPath);
        Assert.IsTrue(
            Content.Contains("Public") || Content.Contains("Private") || Content.Contains("Visibility") || Content.Contains("visibility"),
            "Create task page must have visibility option for public or private code changes");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Route constants must define deployment preview route for viewing deployed changes based on pull request")]
    public void RouteConstantsMustDefineDeploymentPreviewRouteForViewingDeployedChangesBasedOnPullRequest()
    {
        var RoutesPath = Path.Combine(SourceRoot, "PrTask.Domain", "Constants", "RouteConstants.cs");
        var Content = File.ReadAllText(RoutesPath);
        Assert.IsTrue(
            Content.Contains("Deploy") || Content.Contains("Preview") || Content.Contains("deploy") || Content.Contains("preview"),
            "Routes must define a deployment preview route for viewing deployed changes from PRs");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Deployment preview page must exist in SharedUI for client and developer to see live deployed changes from PR")]
    public void DeploymentPreviewPageMustExistInSharedUiForClientAndDeveloperToSeeLiveDeployedChangesFromPr()
    {
        var DeployFiles = Directory.GetFiles(
            Path.Combine(SourceRoot, SharedUiProject, "Pages"),
            "*.razor",
            SearchOption.AllDirectories)
            .Where(F => Path.GetFileName(F).Contains("Deploy", StringComparison.OrdinalIgnoreCase)
                || Path.GetFileName(F).Contains("Preview", StringComparison.OrdinalIgnoreCase))
            .ToArray();
        Assert.IsTrue(DeployFiles.Length > 0, "SharedUI must have a DeploymentPreviewPage for viewing deployed changes from pull requests");
        var Content = File.ReadAllText(DeployFiles[0]);
        Assert.IsTrue(
            Content.Contains("@page"), "Deployment preview page must have a route directive");
        Assert.IsTrue(
            Content.Contains("deploy") || Content.Contains("Deploy") || Content.Contains("preview") || Content.Contains("Preview") || Content.Contains("live") || Content.Contains("Live"),
            "Deployment preview page must reference deployment or preview functionality");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Deployment preview page must show build status and preview URL for the pull request changes")]
    public void DeploymentPreviewPageMustShowBuildStatusAndPreviewUrlForThePullRequestChanges()
    {
        var DeployFiles = Directory.GetFiles(
            Path.Combine(SourceRoot, SharedUiProject, "Pages"),
            "*.razor",
            SearchOption.AllDirectories)
            .Where(F => Path.GetFileName(F).Contains("Deploy", StringComparison.OrdinalIgnoreCase)
                || Path.GetFileName(F).Contains("Preview", StringComparison.OrdinalIgnoreCase))
            .ToArray();
        Assert.IsTrue(DeployFiles.Length > 0, "SharedUI must have deployment preview page");
        var Content = File.ReadAllText(DeployFiles[0]);
        Assert.IsTrue(
            Content.Contains("Status") || Content.Contains("status") || Content.Contains("Build") || Content.Contains("build"),
            "Deployment preview must show build or deployment status");
        Assert.IsTrue(
            Content.Contains("URL") || Content.Contains("url") || Content.Contains("href") || Content.Contains("Link") || Content.Contains("link"),
            "Deployment preview must show preview URL or link to the deployed changes");
    }
}
