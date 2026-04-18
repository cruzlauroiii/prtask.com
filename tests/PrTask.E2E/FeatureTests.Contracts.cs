namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Claim task request must be a record type with developer id string parameter")]
    public void ClaimTaskRequestMustBeARecordTypeWithDeveloperIdStringParameter()
    {
        var Code = ReadSourceFile("PrTask.Application", "Contracts", "ClaimTaskRequest.cs");
        Assert.IsTrue(Code.Contains("record ClaimTaskRequest", StringComparison.Ordinal), "ClaimTaskRequest must be a record type");
        Assert.IsTrue(Code.Contains("string DeveloperId", StringComparison.Ordinal), "ClaimTaskRequest must have DeveloperId parameter");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Github user response must be sealed record with long id login name avatar and email")]
    public void GithubUserResponseMustBeSealedRecordWithLongIdLoginNameAvatarAndEmail()
    {
        var Code = ReadSourceFile("PrTask.Application", "Contracts", "GitHubUserResponse.cs");
        Assert.IsTrue(Code.Contains("sealed record GitHubUserResponse", StringComparison.Ordinal), "GitHubUserResponse must be a sealed record");
        Assert.IsTrue(Code.Contains("long Id", StringComparison.Ordinal), "GitHubUserResponse must have long Id for GitHub user ID");
        Assert.IsTrue(Code.Contains("string Login", StringComparison.Ordinal), "GitHubUserResponse must have Login username");
        Assert.IsTrue(Code.Contains("string? Name", StringComparison.Ordinal), "GitHubUserResponse must have nullable Name");
        Assert.IsTrue(Code.Contains("string? AvatarUrl", StringComparison.Ordinal), "GitHubUserResponse must have nullable AvatarUrl");
        Assert.IsTrue(Code.Contains("string? Email", StringComparison.Ordinal), "GitHubUserResponse must have nullable Email");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Oidc user response must be sealed record with subject id name email and picture")]
    public void OidcUserResponseMustBeSealedRecordWithSubjectIdNameEmailAndPicture()
    {
        var Code = ReadSourceFile("PrTask.Application", "Contracts", "OidcUserResponse.cs");
        Assert.IsTrue(Code.Contains("sealed record OidcUserResponse", StringComparison.Ordinal), "OidcUserResponse must be a sealed record");
        Assert.IsTrue(Code.Contains("string SubjectId", StringComparison.Ordinal), "OidcUserResponse must have SubjectId");
        Assert.IsTrue(Code.Contains("string? Name", StringComparison.Ordinal), "OidcUserResponse must have nullable Name");
        Assert.IsTrue(Code.Contains("string? Email", StringComparison.Ordinal), "OidcUserResponse must have nullable Email");
        Assert.IsTrue(Code.Contains("string? Picture", StringComparison.Ordinal), "OidcUserResponse must have nullable Picture");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Payment checkout request must be a record with task id payer id and amount cents")]
    public void PaymentCheckoutRequestMustBeARecordWithTaskIdPayerIdAndAmountCents()
    {
        var Code = ReadSourceFile("PrTask.Application", "Contracts", "PaymentCheckoutRequest.cs");
        Assert.IsTrue(Code.Contains("record PaymentCheckoutRequest", StringComparison.Ordinal), "PaymentCheckoutRequest must be a record type");
        Assert.IsTrue(Code.Contains("string TaskId", StringComparison.Ordinal), "PaymentCheckoutRequest must have TaskId");
        Assert.IsTrue(Code.Contains("string PayerId", StringComparison.Ordinal), "PaymentCheckoutRequest must have PayerId");
        Assert.IsTrue(Code.Contains("long AmountCents", StringComparison.Ordinal), "PaymentCheckoutRequest must have AmountCents");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Payment checkout response must be a record with checkout url for maya redirect")]
    public void PaymentCheckoutResponseMustBeARecordWithCheckoutUrlForMayaRedirect()
    {
        var Code = ReadSourceFile("PrTask.Application", "Contracts", "PaymentCheckoutResponse.cs");
        Assert.IsTrue(Code.Contains("record PaymentCheckoutResponse", StringComparison.Ordinal), "PaymentCheckoutResponse must be a record type");
        Assert.IsTrue(Code.Contains("string CheckoutUrl", StringComparison.Ordinal), "PaymentCheckoutResponse must have CheckoutUrl");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Payment status response must be a record with single status string property")]
    public void PaymentStatusResponseMustBeARecordWithSingleStatusStringPropertyForQuery()
    {
        var Code = ReadSourceFile("PrTask.Application", "Contracts", "PaymentStatusResponse.cs");
        Assert.IsTrue(Code.Contains("record PaymentStatusResponse", StringComparison.Ordinal), "PaymentStatusResponse must be a record type");
        Assert.IsTrue(Code.Contains("string Status", StringComparison.Ordinal), "PaymentStatusResponse must have Status");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Payment webhook request must be a record with event type and payload json parameters")]
    public void PaymentWebhookRequestMustBeARecordWithEventTypeAndPayloadJsonParameters()
    {
        var Code = ReadSourceFile("PrTask.Application", "Contracts", "PaymentWebhookRequest.cs");
        Assert.IsTrue(Code.Contains("record PaymentWebhookRequest", StringComparison.Ordinal), "PaymentWebhookRequest must be a record type");
        Assert.IsTrue(Code.Contains("string EventType", StringComparison.Ordinal), "PaymentWebhookRequest must have EventType");
        Assert.IsTrue(Code.Contains("string PayloadJson", StringComparison.Ordinal), "PaymentWebhookRequest must have PayloadJson");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Reject pull request request must be a record with reviewer notes string parameter")]
    public void RejectPullRequestRequestMustBeARecordWithReviewerNotesStringParameter()
    {
        var Code = ReadSourceFile("PrTask.Application", "Contracts", "RejectPullRequestRequest.cs");
        Assert.IsTrue(Code.Contains("record RejectPullRequestRequest", StringComparison.Ordinal), "RejectPullRequestRequest must be a record type");
        Assert.IsTrue(Code.Contains("string Notes", StringComparison.Ordinal), "RejectPullRequestRequest must have Notes parameter");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Complexity scoring interface must accept files changed additions deletions and extensions parameters")]
    public void ComplexityScoringInterfaceMustAcceptFilesChangedAdditionsDeletionsAndExtensionsParameters()
    {
        var Code = ReadSourceFile("PrTask.Application", "Services", "IComplexityScoringService.cs");
        Assert.IsTrue(Code.Contains("int FilesChanged", StringComparison.Ordinal), "CalculateComplexityScore must accept FilesChanged parameter");
        Assert.IsTrue(Code.Contains("int Additions", StringComparison.Ordinal), "CalculateComplexityScore must accept Additions parameter");
        Assert.IsTrue(Code.Contains("int Deletions", StringComparison.Ordinal), "CalculateComplexityScore must accept Deletions parameter");
        Assert.IsTrue(Code.Contains("string[] FileExtensions", StringComparison.Ordinal), "CalculateComplexityScore must accept FileExtensions parameter");
        Assert.IsTrue(Code.Contains("int StreakDays", StringComparison.Ordinal), "CalculateXpReward must accept StreakDays parameter");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Leaderboard service interface must return leaderboard entry list and accept count parameter")]
    public void LeaderboardServiceInterfaceMustReturnLeaderboardEntryListAndAcceptCountParameter()
    {
        var Code = ReadSourceFile("PrTask.Application", "Services", "ILeaderboardService.cs");
        Assert.IsTrue(Code.Contains("string UserId", StringComparison.Ordinal), "GetRankAsync must accept UserId parameter");
        Assert.IsTrue(Code.Contains("int Count", StringComparison.Ordinal), "GetTopAsync must accept Count parameter");
        Assert.IsTrue(Code.Contains("IReadOnlyList<LeaderboardEntry>", StringComparison.Ordinal), "GetTopAsync must return IReadOnlyList of LeaderboardEntry");
        Assert.IsTrue(Code.Contains("Task<int>", StringComparison.Ordinal), "GetRankAsync must return integer rank");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Payment service interface must define exists create checkout handle webhook and get status")]
    public void PaymentServiceInterfaceMustDefineExistsCreateCheckoutHandleWebhookAndGetStatus()
    {
        var Code = ReadSourceFile("PrTask.Application", "Services", "IPaymentService.cs");
        Assert.IsTrue(Code.Contains("ExistsAsync", StringComparison.Ordinal), "IPaymentService must have ExistsAsync");
        Assert.IsTrue(Code.Contains("CreateCheckoutAsync", StringComparison.Ordinal), "IPaymentService must have CreateCheckoutAsync");
        Assert.IsTrue(Code.Contains("HandleWebhookAsync", StringComparison.Ordinal), "IPaymentService must have HandleWebhookAsync");
        Assert.IsTrue(Code.Contains("GetStatusAsync", StringComparison.Ordinal), "IPaymentService must have GetStatusAsync");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request service interface must define submit approve reject and list by task methods")]
    public void PullRequestServiceInterfaceMustDefineSubmitApproveRejectAndListByTaskMethods()
    {
        var Code = ReadSourceFile("PrTask.Application", "Services", "IPullRequestService.cs");
        Assert.IsTrue(Code.Contains("SubmitAsync", StringComparison.Ordinal), "IPullRequestService must have SubmitAsync");
        Assert.IsTrue(Code.Contains("ApproveAsync", StringComparison.Ordinal), "IPullRequestService must have ApproveAsync");
        Assert.IsTrue(Code.Contains("RejectAsync", StringComparison.Ordinal), "IPullRequestService must have RejectAsync");
        Assert.IsTrue(Code.Contains("ListByDeveloperAsync", StringComparison.Ordinal), "IPullRequestService must have ListByDeveloperAsync");
        Assert.IsTrue(Code.Contains("ListByTaskAsync", StringComparison.Ordinal), "IPullRequestService must have ListByTaskAsync");
        Assert.IsTrue(Code.Contains("string Notes", StringComparison.Ordinal), "RejectAsync must accept reviewer Notes parameter");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task service interface must define create claim update delete and list open methods")]
    public void TaskServiceInterfaceMustDefineCreateClaimUpdateDeleteAndListOpenMethods()
    {
        var Code = ReadSourceFile("PrTask.Application", "Services", "ITaskService.cs");
        Assert.IsTrue(Code.Contains("CreateAsync", StringComparison.Ordinal), "ITaskService must have CreateAsync");
        Assert.IsTrue(Code.Contains("ClaimAsync", StringComparison.Ordinal), "ITaskService must have ClaimAsync");
        Assert.IsTrue(Code.Contains("UpdateAsync", StringComparison.Ordinal), "ITaskService must have UpdateAsync");
        Assert.IsTrue(Code.Contains("DeleteAsync", StringComparison.Ordinal), "ITaskService must have DeleteAsync");
        Assert.IsTrue(Code.Contains("ListOpenAsync", StringComparison.Ordinal), "ITaskService must have ListOpenAsync");
        Assert.IsTrue(Code.Contains("string DeveloperId", StringComparison.Ordinal), "ClaimAsync must accept DeveloperId parameter");
    }
}
