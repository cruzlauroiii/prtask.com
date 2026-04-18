namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task list page must inject task service and call list open async on initialized with null loading check")]
    public void TaskListPageMustInjectTaskServiceAndCallListOpenAsyncOnInitializedWithNullLoadingCheck()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "TaskList.razor");
        Assert.IsTrue(Code.Contains("@inject ITaskService TaskService", StringComparison.Ordinal), "TaskList must inject ITaskService");
        Assert.IsTrue(Code.Contains("TaskService.ListOpenAsync()", StringComparison.Ordinal), "TaskList must call ListOpenAsync on init");
        Assert.IsTrue(Code.Contains("OpenTasks is null", StringComparison.Ordinal), "TaskList must check null for loading state");
        Assert.IsTrue(Code.Contains("Loading tasks...", StringComparison.Ordinal), "TaskList must show loading message");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task list page must display task cards with complexity class bounty amount title and tags in grid")]
    public void TaskListPageMustDisplayTaskCardsWithComplexityClassBountyAmountTitleAndTagsInGrid()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "TaskList.razor");
        Assert.IsTrue(Code.Contains("task-grid", StringComparison.Ordinal), "TaskList must use task-grid layout class");
        Assert.IsTrue(Code.Contains("complexity-@CurrentTask.Complexity.ToString().ToLowerInvariant()", StringComparison.Ordinal), "TaskList must compute complexity CSS class from enum");
        Assert.IsTrue(Code.Contains("FormatBountyAmount(CurrentTask.BountyAmountCents)", StringComparison.Ordinal), "TaskList must format bounty with helper method");
        Assert.IsTrue(Code.Contains("task-tags", StringComparison.Ordinal), "TaskList must render tags container");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task list page must format bounty as dollar amount dividing cents by hundred with truncate at one twenty chars")]
    public void TaskListPageMustFormatBountyAsDollarAmountDividingCentsByHundredWithTruncateAtOneTwentyChars()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "TaskList.razor");
        Assert.IsTrue(Code.Contains("$\"${AmountCents / 100m:N0}\"", StringComparison.Ordinal), "FormatBountyAmount must divide cents by 100 and format as currency");
        Assert.IsTrue(Code.Contains("Description.Length <= 120", StringComparison.Ordinal), "TruncateDescription must check 120 char limit");
        Assert.IsTrue(Code.Contains("Description[..120]", StringComparison.Ordinal), "TruncateDescription must slice to 120 chars with range operator");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task list empty state must show no open tasks message when count is zero with link format")]
    public void TaskListEmptyStateMustShowNoOpenTasksMessageWhenCountIsZeroWithLinkFormat()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "TaskList.razor");
        Assert.IsTrue(Code.Contains("OpenTasks.Count == 0", StringComparison.Ordinal), "TaskList must check empty list count");
        Assert.IsTrue(Code.Contains("No open tasks right now", StringComparison.Ordinal), "TaskList must show no tasks empty message");
        Assert.IsTrue(Code.Contains("string.Format(System.Globalization.CultureInfo.InvariantCulture, \"/tasks/{0}\", CurrentTask.Id)", StringComparison.Ordinal), "TaskList must format task URL with InvariantCulture");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task detail page must inject task service and pull request service with task id route parameter")]
    public void TaskDetailPageMustInjectTaskServiceAndPullRequestServiceWithTaskIdRouteParameter()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "TaskDetailPage.razor");
        Assert.IsTrue(Code.Contains("@inject ITaskService TaskService", StringComparison.Ordinal), "TaskDetail must inject ITaskService");
        Assert.IsTrue(Code.Contains("@inject IPullRequestService PullRequestService", StringComparison.Ordinal), "TaskDetail must inject IPullRequestService");
        Assert.IsTrue(Code.Contains("@page \"/tasks/{TaskId}\"", StringComparison.Ordinal), "TaskDetail must have TaskId route parameter");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task detail page must show claim button only for open status with edit and delete owner actions")]
    public void TaskDetailPageMustShowClaimButtonOnlyForOpenStatusWithEditAndDeleteOwnerActions()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "TaskDetailPage.razor");
        Assert.IsTrue(Code.Contains("CurrentTask.Status == PrTaskStatus.Open", StringComparison.Ordinal), "TaskDetail must check Open status for claim button");
        Assert.IsTrue(Code.Contains("Claim This Task", StringComparison.Ordinal), "TaskDetail must show Claim This Task button");
        Assert.IsTrue(Code.Contains("Edit Task", StringComparison.Ordinal), "TaskDetail must show Edit Task link");
        Assert.IsTrue(Code.Contains("Delete Task", StringComparison.Ordinal), "TaskDetail must show Delete Task button");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task detail claim must call task service claim async then refresh task data from service")]
    public void TaskDetailClaimMustCallTaskServiceClaimAsyncThenRefreshTaskDataFromService()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "TaskDetailPage.razor");
        Assert.IsTrue(Code.Contains("TaskService.ClaimAsync(TaskId, \"current-user\")", StringComparison.Ordinal), "ClaimCurrentTask must call ClaimAsync with current-user");
        Assert.IsTrue(Code.Contains("TaskService.GetByIdAsync(TaskId)", StringComparison.Ordinal), "ClaimCurrentTask must refresh task data after claim");
        Assert.IsTrue(Code.Contains("TaskService.DeleteAsync(TaskId)", StringComparison.Ordinal), "DeleteCurrentTask must call DeleteAsync");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task detail pr list section must show pull requests with status author and review link")]
    public void TaskDetailPrListSectionMustShowPullRequestsWithStatusAuthorAndReviewLink()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "TaskDetailPage.razor");
        Assert.IsTrue(Code.Contains("pr-list-section", StringComparison.Ordinal), "TaskDetail must have PR list section");
        Assert.IsTrue(Code.Contains("Pr.Status", StringComparison.Ordinal), "TaskDetail must display PR status");
        Assert.IsTrue(Code.Contains("Pr.DeveloperId", StringComparison.Ordinal), "TaskDetail must display PR author");
        Assert.IsTrue(Code.Contains("Review PR", StringComparison.Ordinal), "TaskDetail must have Review PR link");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task detail page must format deadline date with mmm dd yyyy pattern using invariant culture")]
    public void TaskDetailPageMustFormatDeadlineDateWithMmmDdYyyyPatternUsingInvariantCulture()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "TaskDetailPage.razor");
        Assert.IsTrue(Code.Contains("CurrentTask.Deadline.HasValue", StringComparison.Ordinal), "TaskDetail must check if deadline has value");
        Assert.IsTrue(Code.Contains("MMM dd, yyyy", StringComparison.Ordinal), "TaskDetail must format deadline with MMM dd, yyyy pattern");
        Assert.IsTrue(Code.Contains("System.Globalization.CultureInfo.InvariantCulture", StringComparison.Ordinal), "TaskDetail must use InvariantCulture for date format");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Create task page must inject task service and navigation manager with form fields and submit handler")]
    public void CreateTaskPageMustInjectTaskServiceAndNavigationManagerWithFormFieldsAndSubmitHandler()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "Client", "CreateTaskPage.razor");
        Assert.IsTrue(Code.Contains("@inject ITaskService TaskService", StringComparison.Ordinal), "CreateTask must inject ITaskService");
        Assert.IsTrue(Code.Contains("@inject NavigationManager NavigationManager", StringComparison.Ordinal), "CreateTask must inject NavigationManager");
        Assert.IsTrue(Code.Contains("SubmitNewTask", StringComparison.Ordinal), "CreateTask must have SubmitNewTask handler");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Create task page must bind title description repo url complexity bounty and tags form fields")]
    public void CreateTaskPageMustBindTitleDescriptionRepoUrlComplexityBountyAndTagsFormFields()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "Client", "CreateTaskPage.razor");
        Assert.IsTrue(Code.Contains("@bind=\"Title\"", StringComparison.Ordinal), "CreateTask must bind Title field");
        Assert.IsTrue(Code.Contains("@bind=\"Description\"", StringComparison.Ordinal), "CreateTask must bind Description field");
        Assert.IsTrue(Code.Contains("@bind=\"RepoUrl\"", StringComparison.Ordinal), "CreateTask must bind RepoUrl field");
        Assert.IsTrue(Code.Contains("@bind=\"SelectedComplexity\"", StringComparison.Ordinal), "CreateTask must bind SelectedComplexity");
        Assert.IsTrue(Code.Contains("@bind=\"BountyAmountPesos\"", StringComparison.Ordinal), "CreateTask must bind BountyAmountPesos");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Create task page must use app constants for max title length max description length and min bounty")]
    public void CreateTaskPageMustUseAppConstantsForMaxTitleLengthMaxDescriptionLengthAndMinBounty()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "Client", "CreateTaskPage.razor");
        Assert.IsTrue(Code.Contains("AppConstants.MaxTaskTitleLength", StringComparison.Ordinal), "CreateTask must use MaxTaskTitleLength for title maxlength");
        Assert.IsTrue(Code.Contains("AppConstants.MaxTaskDescriptionLength", StringComparison.Ordinal), "CreateTask must use MaxTaskDescriptionLength for textarea");
        Assert.IsTrue(Code.Contains("AppConstants.MinBountyAmountCents / 100", StringComparison.Ordinal), "CreateTask must use MinBountyAmountCents for min value");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Create task submit must generate guid id multiply bounty by hundred and split tags with trim entries")]
    public void CreateTaskSubmitMustGenerateGuidIdMultiplyBountyByHundredAndSplitTagsWithTrimEntries()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "Client", "CreateTaskPage.razor");
        Assert.IsTrue(Code.Contains("Guid.NewGuid().ToString()", StringComparison.Ordinal), "CreateTask must generate GUID for new task ID");
        Assert.IsTrue(Code.Contains("BountyAmountPesos * 100L", StringComparison.Ordinal), "CreateTask must convert dollars to cents with long multiplication");
        Assert.IsTrue(Code.Contains("StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries", StringComparison.Ordinal), "CreateTask must trim and remove empty tag entries");
        Assert.IsTrue(Code.Contains("NavigationManager.NavigateTo($\"/tasks/{NewTask.Id}\")", StringComparison.Ordinal), "CreateTask must navigate to new task detail page");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Create task page must enumerate task complexity values in select dropdown with visibility option")]
    public void CreateTaskPageMustEnumerateTaskComplexityValuesInSelectDropdownWithVisibilityOption()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "Client", "CreateTaskPage.razor");
        Assert.IsTrue(Code.Contains("Enum.GetValues<TaskComplexity>()", StringComparison.Ordinal), "CreateTask must enumerate all TaskComplexity values");
        Assert.IsTrue(Code.Contains("SelectedVisibility", StringComparison.Ordinal), "CreateTask must have code visibility selection");
        Assert.IsTrue(Code.Contains("Public - Code changes visible to everyone", StringComparison.Ordinal), "CreateTask must describe public visibility");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Repository page must have add repository form with url input and visibility select with empty state")]
    public void RepositoryPageMustHaveAddRepositoryFormWithUrlInputAndVisibilitySelectWithEmptyState()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "Client", "RepositoryPage.razor");
        Assert.IsTrue(Code.Contains("Source Code Repositories", StringComparison.Ordinal), "Repository page must have heading");
        Assert.IsTrue(Code.Contains("Add Repository", StringComparison.Ordinal), "Repository page must have Add Repository section");
        Assert.IsTrue(Code.Contains("No repositories added yet", StringComparison.Ordinal), "Repository page must have empty state message");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Deployment preview must build preview url using deployment id and cloudflare pages project constant")]
    public void DeploymentPreviewMustBuildPreviewUrlUsingDeploymentIdAndCloudflarePagesProjectConstant()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "DeploymentPreviewPage.razor");
        Assert.IsTrue(Code.Contains("deploy-preview-{DeploymentId}--{AppConstants.CloudflarePagesProject}.pages.dev", StringComparison.Ordinal), "DeploymentPreview must build Cloudflare Pages preview URL");
        Assert.IsTrue(Code.Contains("Cloudflare Pages", StringComparison.Ordinal), "DeploymentPreview must show Cloudflare Pages platform");
        Assert.IsTrue(Code.Contains("pr-@DeploymentId", StringComparison.Ordinal), "DeploymentPreview must show PR branch name");
    }
}
