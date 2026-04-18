namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task entity must have client id title description repo url and bounty amount fields")]
    public void TaskEntityMustHaveClientIdTitleDescriptionRepoUrlAndBountyAmountFields()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "TaskEntity.cs");
        Assert.IsTrue(Code.Contains("ClientId", StringComparison.Ordinal), "TaskEntity must have ClientId linking to the posting client");
        Assert.IsTrue(Code.Contains("Title", StringComparison.Ordinal), "TaskEntity must have Title for task summary");
        Assert.IsTrue(Code.Contains("Description", StringComparison.Ordinal), "TaskEntity must have Description for task details");
        Assert.IsTrue(Code.Contains("RepoUrl", StringComparison.Ordinal), "TaskEntity must have RepoUrl linking to the source repository");
        Assert.IsTrue(Code.Contains("BountyAmountCents", StringComparison.Ordinal), "TaskEntity must have BountyAmountCents for payment amount");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task entity must have complexity status max claims tags and deadline scheduling fields")]
    public void TaskEntityMustHaveComplexityStatusMaxClaimsTagsAndDeadlineSchedulingFields()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "TaskEntity.cs");
        Assert.IsTrue(Code.Contains("TaskComplexity", StringComparison.Ordinal), "TaskEntity must have complexity classification");
        Assert.IsTrue(Code.Contains("PrTaskStatus", StringComparison.Ordinal), "TaskEntity must have task status tracking");
        Assert.IsTrue(Code.Contains("MaxClaims", StringComparison.Ordinal), "TaskEntity must limit number of concurrent claims");
        Assert.IsTrue(Code.Contains("Tags", StringComparison.Ordinal), "TaskEntity must support tagging for search and filtering");
        Assert.IsTrue(Code.Contains("Deadline", StringComparison.Ordinal), "TaskEntity must have optional deadline for time-sensitive tasks");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task complexity enum must define trivial simple medium complex and expert difficulty levels")]
    public void TaskComplexityEnumMustDefineTrivialSimpleMediumComplexAndExpertDifficultyLevels()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "TaskComplexity.cs");
        Assert.IsTrue(Code.Contains("Trivial", StringComparison.Ordinal), "TaskComplexity must include Trivial level");
        Assert.IsTrue(Code.Contains("Simple", StringComparison.Ordinal), "TaskComplexity must include Simple level");
        Assert.IsTrue(Code.Contains("Medium", StringComparison.Ordinal), "TaskComplexity must include Medium level");
        Assert.IsTrue(Code.Contains("Complex", StringComparison.Ordinal), "TaskComplexity must include Complex level");
        Assert.IsTrue(Code.Contains("Expert", StringComparison.Ordinal), "TaskComplexity must include Expert level");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task status enum must define open claimed in progress review completed and cancelled states")]
    public void TaskStatusEnumMustDefineOpenClaimedInProgressReviewCompletedAndCancelledStates()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "TaskStatus.cs");
        Assert.IsTrue(Code.Contains("Open", StringComparison.Ordinal), "PrTaskStatus must have Open state for new tasks");
        Assert.IsTrue(Code.Contains("Claimed", StringComparison.Ordinal), "PrTaskStatus must have Claimed state for assigned tasks");
        Assert.IsTrue(Code.Contains("InProgress", StringComparison.Ordinal), "PrTaskStatus must have InProgress state for active work");
        Assert.IsTrue(Code.Contains("Review", StringComparison.Ordinal), "PrTaskStatus must have Review state for PR review");
        Assert.IsTrue(Code.Contains("Completed", StringComparison.Ordinal), "PrTaskStatus must have Completed state for finished tasks");
        Assert.IsTrue(Code.Contains("Cancelled", StringComparison.Ordinal), "PrTaskStatus must have Cancelled state for abandoned tasks");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("User role enum must define developer client and admin roles for access control")]
    public void UserRoleEnumMustDefineDeveloperClientAndAdminRolesForAccessControl()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "UserRole.cs");
        Assert.IsTrue(Code.Contains("Developer", StringComparison.Ordinal), "UserRole must have Developer role for PR submitters");
        Assert.IsTrue(Code.Contains("Client", StringComparison.Ordinal), "UserRole must have Client role for task posters");
        Assert.IsTrue(Code.Contains("Admin", StringComparison.Ordinal), "UserRole must have Admin role for platform management");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Payment type enum must define automatic charge developer payout and refund transaction types")]
    public void PaymentTypeEnumMustDefineAutomaticChargeDeveloperPayoutAndRefundTransactionTypes()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "PaymentType.cs");
        Assert.IsTrue(Code.Contains("AutomaticCharge", StringComparison.Ordinal), "PaymentType must have AutomaticCharge for client billing");
        Assert.IsTrue(Code.Contains("DeveloperPayout", StringComparison.Ordinal), "PaymentType must have DeveloperPayout for developer payment");
        Assert.IsTrue(Code.Contains("Refund", StringComparison.Ordinal), "PaymentType must have Refund for dispute resolution");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request entity must have task id developer id github url and diff storage key fields")]
    public void PullRequestEntityMustHaveTaskIdDeveloperIdGitHubUrlAndDiffStorageKeyFields()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "PullRequestEntity.cs");
        Assert.IsTrue(Code.Contains("TaskId", StringComparison.Ordinal), "PullRequestEntity must link to the parent task");
        Assert.IsTrue(Code.Contains("DeveloperId", StringComparison.Ordinal), "PullRequestEntity must track which developer submitted");
        Assert.IsTrue(Code.Contains("GitHubPrUrl", StringComparison.Ordinal), "PullRequestEntity must store GitHub PR URL");
        Assert.IsTrue(Code.Contains("DiffStorageKey", StringComparison.Ordinal), "PullRequestEntity must reference stored diff content");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request entity must have files changed additions deletions and complexity score metrics")]
    public void PullRequestEntityMustHaveFilesChangedAdditionsDeletionsAndComplexityScoreMetrics()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "PullRequestEntity.cs");
        Assert.IsTrue(Code.Contains("FilesChanged", StringComparison.Ordinal), "PullRequestEntity must track number of files changed");
        Assert.IsTrue(Code.Contains("Additions", StringComparison.Ordinal), "PullRequestEntity must track lines added");
        Assert.IsTrue(Code.Contains("Deletions", StringComparison.Ordinal), "PullRequestEntity must track lines deleted");
        Assert.IsTrue(Code.Contains("ComplexityScore", StringComparison.Ordinal), "PullRequestEntity must store calculated complexity score");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request entity must have reviewer notes submitted reviewed merged and paid timestamps")]
    public void PullRequestEntityMustHaveReviewerNotesSubmittedReviewedMergedAndPaidTimestamps()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "PullRequestEntity.cs");
        Assert.IsTrue(Code.Contains("ReviewerNotes", StringComparison.Ordinal), "PullRequestEntity must store reviewer feedback notes");
        Assert.IsTrue(Code.Contains("SubmittedAt", StringComparison.Ordinal), "PullRequestEntity must track submission time");
        Assert.IsTrue(Code.Contains("ReviewedAt", StringComparison.Ordinal), "PullRequestEntity must track review time");
        Assert.IsTrue(Code.Contains("MergedAt", StringComparison.Ordinal), "PullRequestEntity must track merge time");
        Assert.IsTrue(Code.Contains("PaidAt", StringComparison.Ordinal), "PullRequestEntity must track payment time");
    }
}
