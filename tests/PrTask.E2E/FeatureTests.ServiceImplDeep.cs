namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Complexity scoring service must define language weights with cs go java at three and rs cpp at four")]
    public void ComplexityScoringServiceMustDefineLanguageWeightsWithCsGoJavaAtThreeAndRsCppAtFour()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "ComplexityScoringService.cs");
        Assert.IsTrue(Code.Contains("[\".cs\"] = 3", StringComparison.Ordinal), "ComplexityScoring must weight .cs at 3");
        Assert.IsTrue(Code.Contains("[\".rs\"] = 4", StringComparison.Ordinal), "ComplexityScoring must weight .rs at 4");
        Assert.IsTrue(Code.Contains("[\".go\"] = 3", StringComparison.Ordinal), "ComplexityScoring must weight .go at 3");
        Assert.IsTrue(Code.Contains("[\".cpp\"] = 4", StringComparison.Ordinal), "ComplexityScoring must weight .cpp at 4");
        Assert.IsTrue(Code.Contains("[\".c\"] = 4", StringComparison.Ordinal), "ComplexityScoring must weight .c at 4");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Complexity scoring service must weight typescript javascript python ruby at two and config files at one")]
    public void ComplexityScoringServiceMustWeightTypescriptJavascriptPythonRubyAtTwoAndConfigFilesAtOne()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "ComplexityScoringService.cs");
        Assert.IsTrue(Code.Contains("[\".ts\"] = 2", StringComparison.Ordinal), "ComplexityScoring must weight .ts at 2");
        Assert.IsTrue(Code.Contains("[\".js\"] = 2", StringComparison.Ordinal), "ComplexityScoring must weight .js at 2");
        Assert.IsTrue(Code.Contains("[\".py\"] = 2", StringComparison.Ordinal), "ComplexityScoring must weight .py at 2");
        Assert.IsTrue(Code.Contains("[\".json\"] = 1", StringComparison.Ordinal), "ComplexityScoring must weight .json at 1");
        Assert.IsTrue(Code.Contains("[\".css\"] = 1", StringComparison.Ordinal), "ComplexityScoring must weight .css at 1");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Complexity scoring calculate must combine files times five plus lines divided ten plus language score")]
    public void ComplexityScoringCalculateMustCombineFilesTimesFivePlusLinesDividedTenPlusLanguageScore()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "ComplexityScoringService.cs");
        Assert.IsTrue(Code.Contains("FilesChanged * 5", StringComparison.Ordinal), "CalculateComplexityScore must multiply files by 5");
        Assert.IsTrue(Code.Contains("(Additions + Deletions) / 10", StringComparison.Ordinal), "CalculateComplexityScore must divide total lines by 10");
        Assert.IsTrue(Code.Contains("FileScore + LineScore + LanguageScore", StringComparison.Ordinal), "CalculateComplexityScore must sum all three scores");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Complexity scoring xp reward must multiply score by xp per point with streak bonus multiplier")]
    public void ComplexityScoringXpRewardMustMultiplyScoreByXpPerPointWithStreakBonusMultiplier()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "ComplexityScoringService.cs");
        Assert.IsTrue(Code.Contains("AppConstants.XpPerComplexityPoint", StringComparison.Ordinal), "CalculateXpReward must use XpPerComplexityPoint constant");
        Assert.IsTrue(Code.Contains("AppConstants.StreakBonusMultiplier", StringComparison.Ordinal), "CalculateXpReward must use StreakBonusMultiplier constant");
        Assert.IsTrue(Code.Contains("StreakDays > 0", StringComparison.Ordinal), "CalculateXpReward must check StreakDays for bonus");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Diff sanitization service must split raw diff by newline and process each line by prefix type")]
    public void DiffSanitizationServiceMustSplitRawDiffByNewlineAndProcessEachLineByPrefixType()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "DiffSanitizationService.cs");
        Assert.IsTrue(Code.Contains("RawDiff.Split('\\n')", StringComparison.Ordinal), "DiffSanitization must split diff by newline");
        Assert.IsTrue(Code.Contains("StringBuilder", StringComparison.Ordinal), "DiffSanitization must use StringBuilder for output");
        Assert.IsTrue(Code.Contains("StartsWith(\"diff --git\"", StringComparison.Ordinal), "DiffSanitization must detect diff headers");
        Assert.IsTrue(Code.Contains("StartsWith(\"@@\"", StringComparison.Ordinal), "DiffSanitization must detect hunk headers");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Diff sanitization must redact file paths in diff headers and addition deletion line prefixes")]
    public void DiffSanitizationMustRedactFilePathsInDiffHeadersAndAdditionDeletionLinePrefixes()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "DiffSanitizationService.cs");
        Assert.IsTrue(Code.Contains("RedactFilePathInDiffHeader", StringComparison.Ordinal), "DiffSanitization must have RedactFilePathInDiffHeader method");
        Assert.IsTrue(Code.Contains("RedactFilePath", StringComparison.Ordinal), "DiffSanitization must have RedactFilePath method");
        Assert.IsTrue(Code.Contains("RedactSensitiveContent", StringComparison.Ordinal), "DiffSanitization must have RedactSensitiveContent method");
        Assert.IsTrue(Code.Contains("[REDACTED]", StringComparison.Ordinal), "DiffSanitization must replace sensitive content with REDACTED");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Diff sanitization must use generated regex for secret pattern matching password key token api key")]
    public void DiffSanitizationMustUseGeneratedRegexForSecretPatternMatchingPasswordKeyTokenApiKey()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "DiffSanitizationService.cs");
        Assert.IsTrue(Code.Contains("[GeneratedRegex(", StringComparison.Ordinal), "DiffSanitization must use GeneratedRegex attribute");
        Assert.IsTrue(Code.Contains("password|secret|key|token|api", StringComparison.Ordinal), "DiffSanitization secret pattern must match password/secret/key/token/api");
        Assert.IsTrue(Code.Contains("connection[_-]?string", StringComparison.Ordinal), "DiffSanitization secret pattern must match connection string");
        Assert.IsTrue(Code.Contains("partial class DiffSanitizationService", StringComparison.Ordinal), "DiffSanitization must be partial class for source generators");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Diff sanitization extract file extensions must use generated regex on diff header and join with comma")]
    public void DiffSanitizationExtractFileExtensionsMustUseGeneratedRegexOnDiffHeaderAndJoinWithComma()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "DiffSanitizationService.cs");
        Assert.IsTrue(Code.Contains("ExtractFileExtensions", StringComparison.Ordinal), "DiffSanitization must have ExtractFileExtensions method");
        Assert.IsTrue(Code.Contains("FileExtensionPattern()", StringComparison.Ordinal), "ExtractFileExtensions must use FileExtensionPattern");
        Assert.IsTrue(Code.Contains("Distinct()", StringComparison.Ordinal), "ExtractFileExtensions must deduplicate extensions");
        Assert.IsTrue(Code.Contains("string.Join(','", StringComparison.Ordinal), "ExtractFileExtensions must join with comma");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Payment service must use maya checkout endpoint with camel case json serializer options")]
    public void PaymentServiceMustUseMayaCheckoutEndpointWithCamelCaseJsonSerializerOptions()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "PaymentService.cs");
        Assert.IsTrue(Code.Contains("JsonNamingPolicy.CamelCase", StringComparison.Ordinal), "PaymentService must use camelCase JSON naming policy");
        Assert.IsTrue(Code.Contains("MayaConstants.CheckoutEndpoint", StringComparison.Ordinal), "PaymentService must use MayaConstants.CheckoutEndpoint");
        Assert.IsTrue(Code.Contains("IHttpClientFactory", StringComparison.Ordinal), "PaymentService must inject IHttpClientFactory");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Payment service checkout must set usd currency with cents to dollars conversion and buyer email")]
    public void PaymentServiceCheckoutMustSetUsdCurrencyWithCentsToDollarsConversionAndBuyerEmail()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "PaymentService.cs");
        Assert.IsTrue(Code.Contains("Currency = \"USD\"", StringComparison.Ordinal), "PaymentService must use USD currency");
        Assert.IsTrue(Code.Contains("AmountCents / 100m", StringComparison.Ordinal), "PaymentService must convert cents to dollars");
        Assert.IsTrue(Code.Contains("$\"{PayerId}@prtask.com\"", StringComparison.Ordinal), "PaymentService must construct buyer email from payer ID");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Payment service checkout redirect urls must use app constants domain with success failure cancel paths")]
    public void PaymentServiceCheckoutRedirectUrlsMustUseAppConstantsDomainWithSuccessFailureCancelPaths()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "PaymentService.cs");
        Assert.IsTrue(Code.Contains("AppConstants.AppDomain", StringComparison.Ordinal), "PaymentService must use AppConstants.AppDomain for redirect URLs");
        Assert.IsTrue(Code.Contains("payment=success", StringComparison.Ordinal), "PaymentService must have success redirect");
        Assert.IsTrue(Code.Contains("payment=failed", StringComparison.Ordinal), "PaymentService must have failed redirect");
        Assert.IsTrue(Code.Contains("payment=cancelled", StringComparison.Ordinal), "PaymentService must have cancelled redirect");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Payment service must apply maya basic auth headers with base64 encoded key colon format")]
    public void PaymentServiceMustApplyMayaBasicAuthHeadersWithBase64EncodedKeyColonFormat()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "PaymentService.cs");
        Assert.IsTrue(Code.Contains("AuthenticationHeaderValue(\"Basic\"", StringComparison.Ordinal), "PaymentService must use Basic auth header");
        Assert.IsTrue(Code.Contains("Convert.ToBase64String(Encoding.ASCII.GetBytes($\"{Key}:\"))", StringComparison.Ordinal), "PaymentService must encode key with colon suffix");
        Assert.IsTrue(Code.Contains("Configuration[\"Maya:SecretKey\"]", StringComparison.Ordinal), "PaymentService must read Maya:SecretKey from config");
        Assert.IsTrue(Code.Contains("Configuration[\"Maya:PublicKey\"]", StringComparison.Ordinal), "PaymentService must read Maya:PublicKey from config");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Payment service checkout must parse redirect url from json response using json document element")]
    public void PaymentServiceCheckoutMustParseRedirectUrlFromJsonResponseUsingJsonDocumentElement()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "PaymentService.cs");
        Assert.IsTrue(Code.Contains("JsonDocument.Parse", StringComparison.Ordinal), "PaymentService must parse JSON response with JsonDocument");
        Assert.IsTrue(Code.Contains("TryGetProperty(\"redirectUrl\"", StringComparison.Ordinal), "PaymentService must extract redirectUrl property");
        Assert.IsTrue(Code.Contains("PRTASK-{TaskId}", StringComparison.Ordinal), "PaymentService must set request reference with PRTASK prefix");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("User service must use three concurrent dictionaries for id github id and oidc index lookups")]
    public void UserServiceMustUseThreeConcurrentDictionariesForIdGitHubIdAndOidcIndexLookups()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "UserService.cs");
        Assert.IsTrue(Code.Contains("ConcurrentDictionary<string, UserEntity>", StringComparison.Ordinal), "UserService must have StoreById dictionary");
        Assert.IsTrue(Code.Contains("ConcurrentDictionary<long, string>", StringComparison.Ordinal), "UserService must have GitHubIdIndex dictionary");
        Assert.IsTrue(Code.Contains("ConcurrentDictionary<string, string> OidcIndex", StringComparison.Ordinal), "UserService must have OidcIndex dictionary");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("User service create from oidc must construct key as provider colon subject id for index lookup")]
    public void UserServiceCreateFromOidcMustConstructKeyAsProviderColonSubjectIdForIndexLookup()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "UserService.cs");
        Assert.IsTrue(Code.Contains("$\"{Provider}:{SubjectId}\"", StringComparison.Ordinal), "UserService must construct OIDC key as Provider:SubjectId");
        Assert.IsTrue(Code.Contains("OidcIndex.TryGetValue(OidcKey", StringComparison.Ordinal), "UserService must check OidcIndex for existing user");
        Assert.IsTrue(Code.Contains("GitHubUsername = $\"{Provider}:{SubjectId}\"", StringComparison.Ordinal), "UserService must set GitHubUsername to Provider:SubjectId for OIDC");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Leaderboard service must rank entries by xp descending then prs merged descending sort order")]
    public void LeaderboardServiceMustRankEntriesByXpDescendingThenPrsMergedDescendingSortOrder()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "LeaderboardService.cs");
        Assert.IsTrue(Code.Contains("OrderByDescending(E => E.Xp)", StringComparison.Ordinal), "LeaderboardService must sort by Xp descending");
        Assert.IsTrue(Code.Contains("ThenByDescending(E => E.PrsMerged)", StringComparison.Ordinal), "LeaderboardService must secondary sort by PrsMerged");
        Assert.IsTrue(Code.Contains("Ranked[I].Rank = I + 1", StringComparison.Ordinal), "LeaderboardService must assign 1-based rank");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task service must filter open tasks by prtask status and order by created at descending")]
    public void TaskServiceMustFilterOpenTasksByPrtaskStatusAndOrderByCreatedAtDescending()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "TaskService.cs");
        Assert.IsTrue(Code.Contains("T.Status == PrTaskStatus.Open", StringComparison.Ordinal), "TaskService must filter by Open status");
        Assert.IsTrue(Code.Contains("OrderByDescending(T => T.CreatedAt)", StringComparison.Ordinal), "TaskService must order by CreatedAt descending");
        Assert.IsTrue(Code.Contains("PrTaskStatus.Claimed", StringComparison.Ordinal), "TaskService claim must set status to Claimed");
        Assert.IsTrue(Code.Contains("Store.TryRemove(TaskId, out _)", StringComparison.Ordinal), "TaskService delete must use TryRemove");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request service must filter by developer id with ordinal comparison and order by submitted at")]
    public void PullRequestServiceMustFilterByDeveloperIdWithOrdinalComparisonAndOrderBySubmittedAt()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "PullRequestService.cs");
        Assert.IsTrue(Code.Contains("string.Equals(Pr.DeveloperId, DeveloperId, StringComparison.Ordinal)", StringComparison.Ordinal), "PRService must compare DeveloperId with Ordinal");
        Assert.IsTrue(Code.Contains("OrderByDescending(Pr => Pr.SubmittedAt)", StringComparison.Ordinal), "PRService must order by SubmittedAt descending");
        Assert.IsTrue(Code.Contains("PullRequestStatus.Approved", StringComparison.Ordinal), "PRService approve must set Approved status");
        Assert.IsTrue(Code.Contains("PullRequestStatus.Rejected", StringComparison.Ordinal), "PRService reject must set Rejected status");
    }
}
