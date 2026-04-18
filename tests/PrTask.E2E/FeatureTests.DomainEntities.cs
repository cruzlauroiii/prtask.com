namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("User entity must have required id init property and github id as long type init property")]
    public void UserEntityMustHaveRequiredIdInitPropertyAndGitHubIdAsLongTypeInitProperty()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "UserEntity.cs");
        Assert.IsTrue(Code.Contains("required string Id { get; init; }", StringComparison.Ordinal), "UserEntity must have required Id with init");
        Assert.IsTrue(Code.Contains("long GitHubId { get; init; }", StringComparison.Ordinal), "UserEntity must have long GitHubId with init");
        Assert.IsTrue(Code.Contains("GitHubUsername { get; init; } = string.Empty", StringComparison.Ordinal), "UserEntity must default GitHubUsername to empty string");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("User entity must track total earned cents total spent cents xp level and streak days properties")]
    public void UserEntityMustTrackTotalEarnedCentsTotalSpentCentsXpLevelAndStreakDaysProperties()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "UserEntity.cs");
        Assert.IsTrue(Code.Contains("long TotalEarnedCents { get; set; }", StringComparison.Ordinal), "UserEntity must have TotalEarnedCents");
        Assert.IsTrue(Code.Contains("long TotalSpentCents { get; set; }", StringComparison.Ordinal), "UserEntity must have TotalSpentCents");
        Assert.IsTrue(Code.Contains("int Xp { get; set; }", StringComparison.Ordinal), "UserEntity must have Xp");
        Assert.IsTrue(Code.Contains("int Level { get; set; } = 1", StringComparison.Ordinal), "UserEntity must default Level to 1");
        Assert.IsTrue(Code.Contains("int StreakDays { get; set; }", StringComparison.Ordinal), "UserEntity must have StreakDays");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("User entity must default role to developer and have nullable maya customer id property")]
    public void UserEntityMustDefaultRoleToDeveloperAndHaveNullableMayaCustomerIdProperty()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "UserEntity.cs");
        Assert.IsTrue(Code.Contains("UserRole Role { get; set; } = UserRole.Developer", StringComparison.Ordinal), "UserEntity must default Role to Developer");
        Assert.IsTrue(Code.Contains("string? MayaCustomerId { get; set; }", StringComparison.Ordinal), "UserEntity must have nullable MayaCustomerId");
        Assert.IsTrue(Code.Contains("DateTime CreatedAt { get; init; } = DateTime.UtcNow", StringComparison.Ordinal), "UserEntity must default CreatedAt to UtcNow");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task entity must have required id client id title description and repo url properties")]
    public void TaskEntityMustHaveRequiredIdClientIdTitleDescriptionAndRepoUrlProperties()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "TaskEntity.cs");
        Assert.IsTrue(Code.Contains("required string Id { get; init; }", StringComparison.Ordinal), "TaskEntity must have required Id");
        Assert.IsTrue(Code.Contains("required string ClientId { get; init; }", StringComparison.Ordinal), "TaskEntity must have required ClientId");
        Assert.IsTrue(Code.Contains("required string Title { get; set; }", StringComparison.Ordinal), "TaskEntity must have required Title");
        Assert.IsTrue(Code.Contains("required string Description { get; set; }", StringComparison.Ordinal), "TaskEntity must have required Description");
        Assert.IsTrue(Code.Contains("required string RepoUrl { get; set; }", StringComparison.Ordinal), "TaskEntity must have required RepoUrl");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task entity must default complexity to medium and status to open with max claims at one")]
    public void TaskEntityMustDefaultComplexityToMediumAndStatusToOpenWithMaxClaimsAtOne()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "TaskEntity.cs");
        Assert.IsTrue(Code.Contains("TaskComplexity Complexity { get; set; } = TaskComplexity.Medium", StringComparison.Ordinal), "TaskEntity must default Complexity to Medium");
        Assert.IsTrue(Code.Contains("PrTaskStatus Status { get; set; } = PrTaskStatus.Open", StringComparison.Ordinal), "TaskEntity must default Status to Open");
        Assert.IsTrue(Code.Contains("int MaxClaims { get; set; } = 1", StringComparison.Ordinal), "TaskEntity must default MaxClaims to 1");
        Assert.IsTrue(Code.Contains("string[]? Tags { get; set; }", StringComparison.Ordinal), "TaskEntity must have nullable Tags array");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request entity must have required id task id developer id and default status to submitted")]
    public void PullRequestEntityMustHaveRequiredIdTaskIdDeveloperIdAndDefaultStatusToSubmitted()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "PullRequestEntity.cs");
        Assert.IsTrue(Code.Contains("required string Id { get; init; }", StringComparison.Ordinal), "PREntity must have required Id");
        Assert.IsTrue(Code.Contains("required string TaskId { get; init; }", StringComparison.Ordinal), "PREntity must have required TaskId");
        Assert.IsTrue(Code.Contains("required string DeveloperId { get; init; }", StringComparison.Ordinal), "PREntity must have required DeveloperId");
        Assert.IsTrue(Code.Contains("PullRequestStatus Status { get; set; } = PullRequestStatus.Submitted", StringComparison.Ordinal), "PREntity must default Status to Submitted");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request entity must track files changed additions deletions complexity score and diff key")]
    public void PullRequestEntityMustTrackFilesChangedAdditionsDeletionsComplexityScoreAndDiffKey()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "PullRequestEntity.cs");
        Assert.IsTrue(Code.Contains("int FilesChanged { get; set; }", StringComparison.Ordinal), "PREntity must have FilesChanged");
        Assert.IsTrue(Code.Contains("int Additions { get; set; }", StringComparison.Ordinal), "PREntity must have Additions");
        Assert.IsTrue(Code.Contains("int Deletions { get; set; }", StringComparison.Ordinal), "PREntity must have Deletions");
        Assert.IsTrue(Code.Contains("int ComplexityScore { get; set; }", StringComparison.Ordinal), "PREntity must have ComplexityScore");
        Assert.IsTrue(Code.Contains("string? DiffStorageKey { get; set; }", StringComparison.Ordinal), "PREntity must have nullable DiffStorageKey");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Payment entity must have maya checkout id maya payment id and payer payee task pr references")]
    public void PaymentEntityMustHaveMayaCheckoutIdMayaPaymentIdAndPayerPayeeTaskPrReferences()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "PaymentEntity.cs");
        Assert.IsTrue(Code.Contains("string? MayaCheckoutId { get; set; }", StringComparison.Ordinal), "PaymentEntity must have MayaCheckoutId");
        Assert.IsTrue(Code.Contains("string? MayaPaymentId { get; set; }", StringComparison.Ordinal), "PaymentEntity must have MayaPaymentId");
        Assert.IsTrue(Code.Contains("required string PayerId { get; init; }", StringComparison.Ordinal), "PaymentEntity must have required PayerId");
        Assert.IsTrue(Code.Contains("string? PayeeId { get; set; }", StringComparison.Ordinal), "PaymentEntity must have nullable PayeeId");
        Assert.IsTrue(Code.Contains("PaymentStatus Status { get; set; } = PaymentStatus.Pending", StringComparison.Ordinal), "PaymentEntity must default Status to Pending");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Leaderboard entry must have required user id github username with rank xp and level properties")]
    public void LeaderboardEntryMustHaveRequiredUserIdGitHubUsernameWithRankXpAndLevelProperties()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "LeaderboardEntry.cs");
        Assert.IsTrue(Code.Contains("required string UserId { get; init; }", StringComparison.Ordinal), "LeaderboardEntry must have required UserId");
        Assert.IsTrue(Code.Contains("required string GitHubUsername { get; init; }", StringComparison.Ordinal), "LeaderboardEntry must have required GitHubUsername");
        Assert.IsTrue(Code.Contains("int Rank { get; set; }", StringComparison.Ordinal), "LeaderboardEntry must have Rank");
        Assert.IsTrue(Code.Contains("int PrsMerged { get; set; }", StringComparison.Ordinal), "LeaderboardEntry must have PrsMerged");
        Assert.IsTrue(Code.Contains("int ComplexityScoreSum { get; set; }", StringComparison.Ordinal), "LeaderboardEntry must have ComplexityScoreSum");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Achievement entity must have required id user id badge type init properties with earned at datetime")]
    public void AchievementEntityMustHaveRequiredIdUserIdBadgeTypeInitPropertiesWithEarnedAtDatetime()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "AchievementEntity.cs");
        Assert.IsTrue(Code.Contains("required string Id { get; init; }", StringComparison.Ordinal), "AchievementEntity must have required Id");
        Assert.IsTrue(Code.Contains("required string UserId { get; init; }", StringComparison.Ordinal), "AchievementEntity must have required UserId");
        Assert.IsTrue(Code.Contains("required string BadgeType { get; init; }", StringComparison.Ordinal), "AchievementEntity must have required BadgeType");
        Assert.IsTrue(Code.Contains("DateTime EarnedAt { get; init; } = DateTime.UtcNow", StringComparison.Ordinal), "AchievementEntity must default EarnedAt to UtcNow");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task status enum must define open claimed in progress review completed and cancelled with int values")]
    public void TaskStatusEnumMustDefineOpenClaimedInProgressReviewCompletedAndCancelledWithIntValues()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "TaskStatus.cs");
        Assert.IsTrue(Code.Contains("Open = 0", StringComparison.Ordinal), "PrTaskStatus must define Open as 0");
        Assert.IsTrue(Code.Contains("Claimed = 1", StringComparison.Ordinal), "PrTaskStatus must define Claimed as 1");
        Assert.IsTrue(Code.Contains("InProgress = 2", StringComparison.Ordinal), "PrTaskStatus must define InProgress as 2");
        Assert.IsTrue(Code.Contains("Completed = 4", StringComparison.Ordinal), "PrTaskStatus must define Completed as 4");
        Assert.IsTrue(Code.Contains("Cancelled = 5", StringComparison.Ordinal), "PrTaskStatus must define Cancelled as 5");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task complexity enum must define trivial simple medium complex and expert with zero to four values")]
    public void TaskComplexityEnumMustDefineTrivialSimpleMediumComplexAndExpertWithZeroToFourValues()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "TaskComplexity.cs");
        Assert.IsTrue(Code.Contains("Trivial = 0", StringComparison.Ordinal), "TaskComplexity must define Trivial as 0");
        Assert.IsTrue(Code.Contains("Simple = 1", StringComparison.Ordinal), "TaskComplexity must define Simple as 1");
        Assert.IsTrue(Code.Contains("Medium = 2", StringComparison.Ordinal), "TaskComplexity must define Medium as 2");
        Assert.IsTrue(Code.Contains("Complex = 3", StringComparison.Ordinal), "TaskComplexity must define Complex as 3");
        Assert.IsTrue(Code.Contains("Expert = 4", StringComparison.Ordinal), "TaskComplexity must define Expert as 4");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("User role enum must define developer client and admin with zero one and two integer values")]
    public void UserRoleEnumMustDefineDeveloperClientAndAdminWithZeroOneAndTwoIntegerValues()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "UserRole.cs");
        Assert.IsTrue(Code.Contains("Developer = 0", StringComparison.Ordinal), "UserRole must define Developer as 0");
        Assert.IsTrue(Code.Contains("Client = 1", StringComparison.Ordinal), "UserRole must define Client as 1");
        Assert.IsTrue(Code.Contains("Admin = 2", StringComparison.Ordinal), "UserRole must define Admin as 2");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Payment type enum must define automatic charge developer payout and refund with zero to two values")]
    public void PaymentTypeEnumMustDefineAutomaticChargeDeveloperPayoutAndRefundWithZeroToTwoValues()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "PaymentType.cs");
        Assert.IsTrue(Code.Contains("AutomaticCharge = 0", StringComparison.Ordinal), "PaymentType must define AutomaticCharge as 0");
        Assert.IsTrue(Code.Contains("DeveloperPayout = 1", StringComparison.Ordinal), "PaymentType must define DeveloperPayout as 1");
        Assert.IsTrue(Code.Contains("Refund = 2", StringComparison.Ordinal), "PaymentType must define Refund as 2");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request status enum must define submitted approved rejected merged and paid status values")]
    public void PullRequestStatusEnumMustDefineSubmittedApprovedRejectedMergedAndPaidStatusValues()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "PullRequestStatus.cs");
        Assert.IsTrue(Code.Contains("Submitted = 0", StringComparison.Ordinal), "PullRequestStatus must define Submitted as 0");
        Assert.IsTrue(Code.Contains("Approved = 1", StringComparison.Ordinal), "PullRequestStatus must define Approved as 1");
        Assert.IsTrue(Code.Contains("Rejected = 2", StringComparison.Ordinal), "PullRequestStatus must define Rejected as 2");
        Assert.IsTrue(Code.Contains("Merged = 3", StringComparison.Ordinal), "PullRequestStatus must define Merged as 3");
        Assert.IsTrue(Code.Contains("Paid = 4", StringComparison.Ordinal), "PullRequestStatus must define Paid as 4");
    }
}
