namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Github user response must be sealed record with id login name avatar url and email parameters")]
    public void GitHubUserResponseMustBeSealedRecordWithIdLoginNameAvatarUrlAndEmailParameters()
    {
        var Code = ReadSourceFile("PrTask.Application", "Contracts", "GitHubUserResponse.cs");
        Assert.IsTrue(Code.Contains("sealed record GitHubUserResponse", StringComparison.Ordinal), "GitHubUserResponse must be sealed record");
        Assert.IsTrue(Code.Contains("long Id", StringComparison.Ordinal), "GitHubUserResponse must have long Id parameter");
        Assert.IsTrue(Code.Contains("string Login", StringComparison.Ordinal), "GitHubUserResponse must have Login parameter");
        Assert.IsTrue(Code.Contains("string? AvatarUrl", StringComparison.Ordinal), "GitHubUserResponse must have nullable AvatarUrl");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Oidc user response must be sealed record with subject id name email and picture parameters")]
    public void OidcUserResponseMustBeSealedRecordWithSubjectIdNameEmailAndPictureParameters()
    {
        var Code = ReadSourceFile("PrTask.Application", "Contracts", "OidcUserResponse.cs");
        Assert.IsTrue(Code.Contains("sealed record OidcUserResponse", StringComparison.Ordinal), "OidcUserResponse must be sealed record");
        Assert.IsTrue(Code.Contains("string SubjectId", StringComparison.Ordinal), "OidcUserResponse must have SubjectId parameter");
        Assert.IsTrue(Code.Contains("string? Name", StringComparison.Ordinal), "OidcUserResponse must have nullable Name");
        Assert.IsTrue(Code.Contains("string? Picture", StringComparison.Ordinal), "OidcUserResponse must have nullable Picture");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Payment checkout request must be record with task id payer id and amount cents parameters")]
    public void PaymentCheckoutRequestMustBeRecordWithTaskIdPayerIdAndAmountCentsParameters()
    {
        var Code = ReadSourceFile("PrTask.Application", "Contracts", "PaymentCheckoutRequest.cs");
        Assert.IsTrue(Code.Contains("record PaymentCheckoutRequest(string TaskId, string PayerId, long AmountCents)", StringComparison.Ordinal), "PaymentCheckoutRequest must have TaskId, PayerId, AmountCents");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Payment checkout response must be record with checkout url parameter and webhook request must have event type")]
    public void PaymentCheckoutResponseMustBeRecordWithCheckoutUrlAndWebhookMustHaveEventType()
    {
        var CheckoutResponse = ReadSourceFile("PrTask.Application", "Contracts", "PaymentCheckoutResponse.cs");
        Assert.IsTrue(CheckoutResponse.Contains("record PaymentCheckoutResponse(string CheckoutUrl)", StringComparison.Ordinal), "PaymentCheckoutResponse must have CheckoutUrl");
        var WebhookRequest = ReadSourceFile("PrTask.Application", "Contracts", "PaymentWebhookRequest.cs");
        Assert.IsTrue(WebhookRequest.Contains("record PaymentWebhookRequest(string EventType, string PayloadJson)", StringComparison.Ordinal), "PaymentWebhookRequest must have EventType and PayloadJson");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Claim task request must be record with developer id and reject pr request must have notes parameter")]
    public void ClaimTaskRequestMustBeRecordWithDeveloperIdAndRejectPrRequestMustHaveNotesParameter()
    {
        var ClaimRequest = ReadSourceFile("PrTask.Application", "Contracts", "ClaimTaskRequest.cs");
        Assert.IsTrue(ClaimRequest.Contains("record ClaimTaskRequest(string DeveloperId)", StringComparison.Ordinal), "ClaimTaskRequest must have DeveloperId parameter");
        var RejectRequest = ReadSourceFile("PrTask.Application", "Contracts", "RejectPullRequestRequest.cs");
        Assert.IsTrue(RejectRequest.Contains("record RejectPullRequestRequest(string Notes)", StringComparison.Ordinal), "RejectPullRequestRequest must have Notes parameter");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Service registration must register all eight services as scoped with interface to implementation mappings")]
    public void ServiceRegistrationMustRegisterAllEightServicesAsScopedWithInterfaceToImplementationMappings()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "ServiceRegistration.cs");
        Assert.IsTrue(Code.Contains("AddScoped<IUserService, UserService>()", StringComparison.Ordinal), "Must register IUserService as scoped");
        Assert.IsTrue(Code.Contains("AddScoped<ITaskService, TaskService>()", StringComparison.Ordinal), "Must register ITaskService as scoped");
        Assert.IsTrue(Code.Contains("AddScoped<IPullRequestService, PullRequestService>()", StringComparison.Ordinal), "Must register IPullRequestService as scoped");
        Assert.IsTrue(Code.Contains("AddScoped<IPaymentService, PaymentService>()", StringComparison.Ordinal), "Must register IPaymentService as scoped");
        Assert.IsTrue(Code.Contains("AddScoped<ILeaderboardService, LeaderboardService>()", StringComparison.Ordinal), "Must register ILeaderboardService as scoped");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Service registration must register maya http client with sandbox base url and prtask named client")]
    public void ServiceRegistrationMustRegisterMayaHttpClientWithSandboxBaseUrlAndPrtaskNamedClient()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "ServiceRegistration.cs");
        Assert.IsTrue(Code.Contains("AddHttpClient(\"Maya\"", StringComparison.Ordinal), "Must register Maya named HttpClient");
        Assert.IsTrue(Code.Contains("MayaConstants.SandboxBaseUrl", StringComparison.Ordinal), "Maya client must use SandboxBaseUrl");
        Assert.IsTrue(Code.Contains("AddHttpClient(AppConstants.AppName", StringComparison.Ordinal), "Must register PrTask named HttpClient");
        Assert.IsTrue(Code.Contains("AppConstants.AppDomain", StringComparison.Ordinal), "PrTask client must use AppDomain for base address");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Service registration must register complexity scoring diff sanitization and achievement services as scoped")]
    public void ServiceRegistrationMustRegisterComplexityScoringDiffSanitizationAndAchievementServicesAsScoped()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "ServiceRegistration.cs");
        Assert.IsTrue(Code.Contains("AddScoped<IComplexityScoringService, ComplexityScoringService>()", StringComparison.Ordinal), "Must register IComplexityScoringService");
        Assert.IsTrue(Code.Contains("AddScoped<IDiffSanitizationService, DiffSanitizationService>()", StringComparison.Ordinal), "Must register IDiffSanitizationService");
        Assert.IsTrue(Code.Contains("AddScoped<IAchievementService, AchievementService>()", StringComparison.Ordinal), "Must register IAchievementService");
        Assert.IsTrue(Code.Contains("AddInfrastructure", StringComparison.Ordinal), "Must define AddInfrastructure extension method");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Service interfaces must define async method signatures returning task with proper entity types")]
    public void ServiceInterfacesMustDefineMethodSignaturesReturningTaskWithProperEntityTypes()
    {
        var TaskService = ReadSourceFile("PrTask.Application", "Services", "ITaskService.cs");
        Assert.IsTrue(TaskService.Contains("Task<IReadOnlyList<TaskEntity>> ListOpenAsync()", StringComparison.Ordinal), "ITaskService must define ListOpenAsync");
        Assert.IsTrue(TaskService.Contains("Task ClaimAsync(string TaskId, string DeveloperId)", StringComparison.Ordinal), "ITaskService must define ClaimAsync with DeveloperId");
        Assert.IsTrue(TaskService.Contains("Task DeleteAsync(string TaskId)", StringComparison.Ordinal), "ITaskService must define DeleteAsync");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request service interface must define submit approve reject with list by developer and task queries")]
    public void PullRequestServiceInterfaceMustDefineSubmitApproveRejectWithListByDeveloperAndTaskQueries()
    {
        var Code = ReadSourceFile("PrTask.Application", "Services", "IPullRequestService.cs");
        Assert.IsTrue(Code.Contains("Task<PullRequestEntity> SubmitAsync(PullRequestEntity Entity)", StringComparison.Ordinal), "IPullRequestService must define SubmitAsync");
        Assert.IsTrue(Code.Contains("Task ApproveAsync(string PullRequestId)", StringComparison.Ordinal), "IPullRequestService must define ApproveAsync");
        Assert.IsTrue(Code.Contains("Task RejectAsync(string PullRequestId, string Notes)", StringComparison.Ordinal), "IPullRequestService must define RejectAsync");
        Assert.IsTrue(Code.Contains("ListByDeveloperAsync(string DeveloperId)", StringComparison.Ordinal), "IPullRequestService must define ListByDeveloperAsync");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("User service interface must define github and oidc create or update methods with nullable parameters")]
    public void UserServiceInterfaceMustDefineGitHubAndOidcCreateOrUpdateMethodsWithNullableParameters()
    {
        var Code = ReadSourceFile("PrTask.Application", "Services", "IUserService.cs");
        Assert.IsTrue(Code.Contains("CreateOrUpdateFromGitHubAsync(long GitHubId, string Username, string? DisplayName, string? AvatarUrl, string? Email)", StringComparison.Ordinal), "IUserService must define GitHub create/update");
        Assert.IsTrue(Code.Contains("CreateOrUpdateFromOidcAsync(string Provider, string SubjectId, string? Name, string? Email, string? AvatarUrl)", StringComparison.Ordinal), "IUserService must define OIDC create/update");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Achievement service interface must define evaluate with total prs earned cents streak and rank params")]
    public void AchievementServiceInterfaceMustDefineEvaluateWithTotalPrsEarnedCentsStreakAndRankParams()
    {
        var Code = ReadSourceFile("PrTask.Application", "Services", "IAchievementService.cs");
        Assert.IsTrue(Code.Contains("EvaluateAndAwardBadgesAsync(string UserId, int TotalPrsMerged, long TotalEarnedCents, int StreakDays, int LeaderboardRank)", StringComparison.Ordinal), "IAchievementService must define EvaluateAndAward with all params");
        Assert.IsTrue(Code.Contains("Task<IReadOnlyList<AchievementEntity>> GetByUserAsync(string UserId)", StringComparison.Ordinal), "IAchievementService must define GetByUserAsync");
    }
}
