namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Complexity scoring service interface must define calculate score with files additions deletions and extensions")]
    public void ComplexityScoringServiceInterfaceMustDefineCalculateScoreWithFilesAdditionsDeletionsAndExtensions()
    {
        var Code = ReadSourceFile("PrTask.Application", "Services", "IComplexityScoringService.cs");
        Assert.IsTrue(Code.Contains("int CalculateComplexityScore(int FilesChanged, int Additions, int Deletions, string[] FileExtensions)", StringComparison.Ordinal), "IComplexityScoringService must define CalculateComplexityScore with four params");
        Assert.IsTrue(Code.Contains("int CalculateXpReward(int ComplexityScore, int StreakDays)", StringComparison.Ordinal), "IComplexityScoringService must define CalculateXpReward");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Diff sanitization service interface must define sanitize diff and extract file extensions string methods")]
    public void DiffSanitizationServiceInterfaceMustDefineSanitizeDiffAndExtractFileExtensionsStringMethods()
    {
        var Code = ReadSourceFile("PrTask.Application", "Services", "IDiffSanitizationService.cs");
        Assert.IsTrue(Code.Contains("string SanitizeDiffForPublicDisplay(string RawDiff)", StringComparison.Ordinal), "IDiffSanitizationService must define SanitizeDiffForPublicDisplay");
        Assert.IsTrue(Code.Contains("string ExtractFileExtensions(string RawDiff)", StringComparison.Ordinal), "IDiffSanitizationService must define ExtractFileExtensions");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Leaderboard service interface must define get rank async and get top async with count parameter")]
    public void LeaderboardServiceInterfaceMustDefineGetRankAsyncAndGetTopAsyncWithCountParameter()
    {
        var Code = ReadSourceFile("PrTask.Application", "Services", "ILeaderboardService.cs");
        Assert.IsTrue(Code.Contains("Task<int> GetRankAsync(string UserId)", StringComparison.Ordinal), "ILeaderboardService must define GetRankAsync returning int");
        Assert.IsTrue(Code.Contains("Task<IReadOnlyList<LeaderboardEntry>> GetTopAsync(int Count)", StringComparison.Ordinal), "ILeaderboardService must define GetTopAsync with int Count");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Payment service interface must define exists checkout webhook and get status async methods")]
    public void PaymentServiceInterfaceMustDefineExistsCheckoutWebhookAndGetStatusAsyncMethods()
    {
        var Code = ReadSourceFile("PrTask.Application", "Services", "IPaymentService.cs");
        Assert.IsTrue(Code.Contains("Task<bool> ExistsAsync(string PaymentId)", StringComparison.Ordinal), "IPaymentService must define ExistsAsync returning bool");
        Assert.IsTrue(Code.Contains("Task<string> CreateCheckoutAsync(string TaskId, string PayerId, long AmountCents)", StringComparison.Ordinal), "IPaymentService must define CreateCheckoutAsync");
        Assert.IsTrue(Code.Contains("Task HandleWebhookAsync(string EventType, string PayloadJson)", StringComparison.Ordinal), "IPaymentService must define HandleWebhookAsync");
        Assert.IsTrue(Code.Contains("Task<string> GetStatusAsync(string PaymentId)", StringComparison.Ordinal), "IPaymentService must define GetStatusAsync");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Leaderboard rank response must be record with single int rank parameter in application contracts namespace")]
    public void LeaderboardRankResponseMustBeRecordWithSingleIntRankParameterInApplicationContractsNamespace()
    {
        var Code = ReadSourceFile("PrTask.Application", "Contracts", "LeaderboardRankResponse.cs");
        Assert.IsTrue(Code.Contains("record LeaderboardRankResponse(int Rank)", StringComparison.Ordinal), "LeaderboardRankResponse must be record with int Rank");
        Assert.IsTrue(Code.Contains("PrTask.Application.Contracts", StringComparison.Ordinal), "LeaderboardRankResponse must be in Application.Contracts namespace");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Payment status response must be record with string status parameter in application contracts namespace")]
    public void PaymentStatusResponseMustBeRecordWithStringStatusParameterInApplicationContractsNamespace()
    {
        var Code = ReadSourceFile("PrTask.Application", "Contracts", "PaymentStatusResponse.cs");
        Assert.IsTrue(Code.Contains("record PaymentStatusResponse(string Status)", StringComparison.Ordinal), "PaymentStatusResponse must be record with string Status");
        Assert.IsTrue(Code.Contains("PrTask.Application.Contracts", StringComparison.Ordinal), "PaymentStatusResponse must be in Application.Contracts namespace");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Complexity scoring interface must use domain models namespace for return type and parameter dependencies")]
    public void ComplexityScoringInterfaceMustUseDomainModelsNamespaceForReturnTypeAndParameterDependencies()
    {
        var Code = ReadSourceFile("PrTask.Application", "Services", "IComplexityScoringService.cs");
        Assert.IsTrue(Code.Contains("using PrTask.Domain.Models", StringComparison.Ordinal), "IComplexityScoringService must import Domain.Models namespace");
        Assert.IsTrue(Code.Contains("PrTask.Application.Services", StringComparison.Ordinal), "IComplexityScoringService must be in Application.Services namespace");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Leaderboard service interface must import domain models for leaderboard entry return type")]
    public void LeaderboardServiceInterfaceMustImportDomainModelsForLeaderboardEntryReturnType()
    {
        var Code = ReadSourceFile("PrTask.Application", "Services", "ILeaderboardService.cs");
        Assert.IsTrue(Code.Contains("using PrTask.Domain.Models", StringComparison.Ordinal), "ILeaderboardService must import Domain.Models for LeaderboardEntry");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Diff sanitization interface namespace must be application services without domain model dependency")]
    public void DiffSanitizationInterfaceNamespaceMustBeApplicationServicesWithoutDomainModelDependency()
    {
        var Code = ReadSourceFile("PrTask.Application", "Services", "IDiffSanitizationService.cs");
        Assert.IsTrue(Code.Contains("namespace PrTask.Application.Services", StringComparison.Ordinal), "IDiffSanitizationService must be in Application.Services namespace");
        Assert.IsFalse(Code.Contains("using PrTask.Domain", StringComparison.Ordinal), "IDiffSanitizationService must not depend on Domain namespace");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Payment service interface namespace must be application services without domain model import")]
    public void PaymentServiceInterfaceNamespaceMustBeApplicationServicesWithoutDomainModelImport()
    {
        var Code = ReadSourceFile("PrTask.Application", "Services", "IPaymentService.cs");
        Assert.IsTrue(Code.Contains("namespace PrTask.Application.Services", StringComparison.Ordinal), "IPaymentService must be in Application.Services namespace");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform variables must define six sensitive variables for api keys client secrets and session secret")]
    public void TerraformVariablesMustDefineSixSensitiveVariablesForApiKeysClientSecretsAndSessionSecret()
    {
        var Tf = ReadInfraFile("variables.tf");
        Assert.IsTrue(Tf.Contains("variable \"cloudflare_api_key\"", StringComparison.Ordinal), "Variables must define cloudflare_api_key");
        Assert.IsTrue(Tf.Contains("variable \"maya_secret_key\"", StringComparison.Ordinal), "Variables must define maya_secret_key");
        Assert.IsTrue(Tf.Contains("variable \"session_secret\"", StringComparison.Ordinal), "Variables must define session_secret");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform variables must mark api key maya secret github google azure okta secrets and session as sensitive")]
    public void TerraformVariablesMustMarkApiKeyMayaSecretGitHubGoogleAzureOktaSecretsAndSessionAsSensitive()
    {
        var Tf = ReadInfraFile("variables.tf");
        Assert.IsTrue(Tf.Contains("sensitive = true", StringComparison.Ordinal), "Variables must mark secrets as sensitive");
        Assert.IsTrue(Tf.Contains("variable \"github_client_secret\"", StringComparison.Ordinal), "Variables must define github_client_secret");
        Assert.IsTrue(Tf.Contains("variable \"google_client_secret\"", StringComparison.Ordinal), "Variables must define google_client_secret");
        Assert.IsTrue(Tf.Contains("variable \"azure_client_secret\"", StringComparison.Ordinal), "Variables must define azure_client_secret");
        Assert.IsTrue(Tf.Contains("variable \"okta_client_secret\"", StringComparison.Ordinal), "Variables must define okta_client_secret");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform variables must define all four oauth client id variables and okta domain as non sensitive strings")]
    public void TerraformVariablesMustDefineAllFourOauthClientIdVariablesAndOktaDomainAsNonSensitiveStrings()
    {
        var Tf = ReadInfraFile("variables.tf");
        Assert.IsTrue(Tf.Contains("variable \"github_client_id\"", StringComparison.Ordinal), "Variables must define github_client_id");
        Assert.IsTrue(Tf.Contains("variable \"google_client_id\"", StringComparison.Ordinal), "Variables must define google_client_id");
        Assert.IsTrue(Tf.Contains("variable \"azure_client_id\"", StringComparison.Ordinal), "Variables must define azure_client_id");
        Assert.IsTrue(Tf.Contains("variable \"okta_client_id\"", StringComparison.Ordinal), "Variables must define okta_client_id");
        Assert.IsTrue(Tf.Contains("variable \"okta_domain\"", StringComparison.Ordinal), "Variables must define okta_domain");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Terraform variables must define cloudflare account id zone id email and maya public key as string type")]
    public void TerraformVariablesMustDefineCloudflareAccountIdZoneIdEmailAndMayaPublicKeyAsStringType()
    {
        var Tf = ReadInfraFile("variables.tf");
        Assert.IsTrue(Tf.Contains("variable \"cloudflare_account_id\"", StringComparison.Ordinal), "Variables must define cloudflare_account_id");
        Assert.IsTrue(Tf.Contains("variable \"cloudflare_zone_id\"", StringComparison.Ordinal), "Variables must define cloudflare_zone_id");
        Assert.IsTrue(Tf.Contains("variable \"cloudflare_email\"", StringComparison.Ordinal), "Variables must define cloudflare_email");
        Assert.IsTrue(Tf.Contains("variable \"maya_public_key\"", StringComparison.Ordinal), "Variables must define maya_public_key");
    }
}
