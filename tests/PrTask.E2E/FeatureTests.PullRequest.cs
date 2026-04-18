namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task detail page must have pull request list section for clients to choose from multiple submissions")]
    public void TaskDetailPageMustHavePullRequestListSectionForClientsToChooseFromMultipleSubmissions()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "TaskDetailPage.razor");
        Assert.IsTrue(
            Razor.Contains("Pull Request", StringComparison.Ordinal),
            "Task detail page must have a Pull Requests section header");
        Assert.IsTrue(
            Razor.Contains("pr-list", StringComparison.OrdinalIgnoreCase),
            "Task detail page must have a pr-list container for displaying multiple PR submissions");
        Assert.IsTrue(
            Razor.Contains("Approve", StringComparison.Ordinal) || Razor.Contains("choose", StringComparison.OrdinalIgnoreCase),
            "Task detail page must allow clients to approve or choose a PR from the list");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request detail page must have diff viewer section showing code changes")]
    public void PullRequestDetailPageMustHaveDiffViewerSectionShowingCodeChanges()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "PullRequestDetailPage.razor");
        Assert.IsTrue(Razor.Contains("diff-viewer", StringComparison.OrdinalIgnoreCase), "PR detail page must have a diff viewer");
        Assert.IsTrue(Razor.Contains("diff-line", StringComparison.OrdinalIgnoreCase), "PR detail page must render individual diff lines");
        Assert.IsTrue(Razor.Contains("line-add", StringComparison.OrdinalIgnoreCase), "PR detail page must show added lines with distinct styling");
        Assert.IsTrue(Razor.Contains("line-del", StringComparison.OrdinalIgnoreCase), "PR detail page must show deleted lines with distinct styling");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request detail page must have approve and reject action buttons")]
    public void PullRequestDetailPageMustHaveApproveAndRejectActionButtons()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "PullRequestDetailPage.razor");
        Assert.IsTrue(
            Razor.Contains("Approve", StringComparison.Ordinal),
            "PR detail page must have an Approve button for the client to accept the PR");
        Assert.IsTrue(
            Razor.Contains("Request Changes", StringComparison.Ordinal) || Razor.Contains("Reject", StringComparison.Ordinal),
            "PR detail page must have a Request Changes or Reject button");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request detail page must show code changes header and diff file sections")]
    public void PullRequestDetailPageMustShowCodeChangesHeaderAndDiffFileSections()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "PullRequestDetailPage.razor");
        Assert.IsTrue(
            Razor.Contains("Code Changes", StringComparison.Ordinal),
            "PR detail page must have a Code Changes heading");
        Assert.IsTrue(
            Razor.Contains("diff-file", StringComparison.OrdinalIgnoreCase),
            "PR detail page must organize diffs by file");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Create task page must have code visibility option for public or private changes")]
    public void CreateTaskPageMustHaveCodeVisibilityOptionForPublicOrPrivateChanges()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "Client", "CreateTaskPage.razor");
        Assert.IsTrue(
            Razor.Contains("Visibility", StringComparison.Ordinal),
            "Create task page must have a Visibility field");
        Assert.IsTrue(
            Razor.Contains("Public", StringComparison.Ordinal),
            "Create task page must offer Public visibility option where code changes are visible to everyone");
        Assert.IsTrue(
            Razor.Contains("Private", StringComparison.Ordinal),
            "Create task page must offer Private visibility option where code changes are visible only to participants");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request service interface must support listing prs by task for multiple submissions")]
    public void PullRequestServiceInterfaceMustSupportListingPrsByTaskForMultipleSubmissions()
    {
        var Code = ReadSourceFile("PrTask.Application", "Services", "IPullRequestService.cs");
        Assert.IsTrue(
            Code.Contains("ListByTaskAsync", StringComparison.Ordinal) || Code.Contains("GetByTaskIdAsync", StringComparison.Ordinal)
            || Code.Contains("ListAsync", StringComparison.Ordinal),
            "IPullRequestService must have a method to list PRs by task so clients can choose from multiple submissions");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request status enum must include submitted approved and rejected values")]
    public void PullRequestStatusEnumMustIncludeSubmittedApprovedAndRejectedValues()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "PullRequestStatus.cs");
        Assert.IsTrue(Code.Contains("Submitted", StringComparison.Ordinal), "PullRequestStatus must have Submitted value");
        Assert.IsTrue(Code.Contains("Approved", StringComparison.Ordinal), "PullRequestStatus must have Approved value");
        Assert.IsTrue(Code.Contains("Rejected", StringComparison.Ordinal), "PullRequestStatus must have Rejected value");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request detail page must have file tree sidebar showing changed files list")]
    public void PullRequestDetailPageMustHaveFileTreeSidebarShowingChangedFilesList()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "PullRequestDetailPage.razor");
        Assert.IsTrue(
            Razor.Contains("diff-file-tree", StringComparison.OrdinalIgnoreCase),
            "PR detail page must have a file tree sidebar listing all changed files");
        Assert.IsTrue(
            Razor.Contains("file-list", StringComparison.OrdinalIgnoreCase),
            "PR detail page must render a file list within the file tree");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request detail page must have unified and split diff view toggle")]
    public void PullRequestDetailPageMustHaveUnifiedAndSplitDiffViewToggle()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "PullRequestDetailPage.razor");
        Assert.IsTrue(
            Razor.Contains("diff-view-toggle", StringComparison.OrdinalIgnoreCase)
            || (Razor.Contains("Unified", StringComparison.Ordinal) && Razor.Contains("Split", StringComparison.Ordinal)),
            "PR detail page must allow toggling between unified and split diff views");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request detail page must show line numbers in diff for code reference")]
    public void PullRequestDetailPageMustShowLineNumbersInDiffForCodeReference()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "PullRequestDetailPage.razor");
        Assert.IsTrue(
            Razor.Contains("line-number", StringComparison.OrdinalIgnoreCase),
            "PR detail page must show line numbers for each diff line to support inline comments");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request detail page must have review comments section for inline feedback")]
    public void PullRequestDetailPageMustHaveReviewCommentsSectionForInlineFeedback()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "PullRequestDetailPage.razor");
        Assert.IsTrue(
            Razor.Contains("pr-comments", StringComparison.OrdinalIgnoreCase)
            || Razor.Contains("Review Comments", StringComparison.Ordinal),
            "PR detail page must have a review comments section for client feedback");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request detail page must inject pull request service to load pr data dynamically")]
    public void PullRequestDetailPageMustInjectPullRequestServiceToLoadPrDataDynamically()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "PullRequestDetailPage.razor");
        Assert.IsTrue(
            Razor.Contains("IPullRequestService", StringComparison.Ordinal),
            "PR detail page must inject IPullRequestService to load PR data from backend");
    }
}
