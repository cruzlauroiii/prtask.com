namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Complexity scoring service must define language difficulty weights dictionary with ordinal comparer")]
    public void ComplexityScoringServiceMustDefineLanguageDifficultyWeightsDictionaryWithOrdinalComparer()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "ComplexityScoringService.cs");
        Assert.IsTrue(Code.Contains("LanguageDifficultyWeights", StringComparison.Ordinal), "Must define LanguageDifficultyWeights dictionary");
        Assert.IsTrue(Code.Contains("StringComparer.OrdinalIgnoreCase", StringComparison.Ordinal), "Must use OrdinalIgnoreCase for file extension keys");
        Assert.IsTrue(Code.Contains("IComplexityScoringService", StringComparison.Ordinal), "Must implement IComplexityScoringService interface");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Complexity scoring service must assign weight four to rust and cpp extensions for difficulty")]
    public void ComplexityScoringServiceMustAssignWeightFourToRustAndCppExtensionsForDifficulty()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "ComplexityScoringService.cs");
        Assert.IsTrue(Code.Contains("[\".rs\"] = 4", StringComparison.Ordinal), "Rust files must have weight 4");
        Assert.IsTrue(Code.Contains("[\".cpp\"] = 4", StringComparison.Ordinal), "C++ files must have weight 4");
        Assert.IsTrue(Code.Contains("[\".c\"] = 4", StringComparison.Ordinal), "C files must have weight 4");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Complexity scoring service must assign weight three to csharp go java and sql extensions")]
    public void ComplexityScoringServiceMustAssignWeightThreeToCsharpGoJavaAndSqlExtensions()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "ComplexityScoringService.cs");
        Assert.IsTrue(Code.Contains("[\".cs\"] = 3", StringComparison.Ordinal), "C# files must have weight 3");
        Assert.IsTrue(Code.Contains("[\".go\"] = 3", StringComparison.Ordinal), "Go files must have weight 3");
        Assert.IsTrue(Code.Contains("[\".java\"] = 3", StringComparison.Ordinal), "Java files must have weight 3");
        Assert.IsTrue(Code.Contains("[\".sql\"] = 3", StringComparison.Ordinal), "SQL files must have weight 3");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Complexity scoring service must assign weight two to typescript javascript python and terraform")]
    public void ComplexityScoringServiceMustAssignWeightTwoToTypescriptJavascriptPythonAndTerraform()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "ComplexityScoringService.cs");
        Assert.IsTrue(Code.Contains("[\".ts\"] = 2", StringComparison.Ordinal), "TypeScript files must have weight 2");
        Assert.IsTrue(Code.Contains("[\".js\"] = 2", StringComparison.Ordinal), "JavaScript files must have weight 2");
        Assert.IsTrue(Code.Contains("[\".py\"] = 2", StringComparison.Ordinal), "Python files must have weight 2");
        Assert.IsTrue(Code.Contains("[\".tf\"] = 2", StringComparison.Ordinal), "Terraform files must have weight 2");
        Assert.IsTrue(Code.Contains("[\".razor\"] = 2", StringComparison.Ordinal), "Razor files must have weight 2");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Complexity scoring service must assign weight one to css scss html json yaml and xml extensions")]
    public void ComplexityScoringServiceMustAssignWeightOneToCssScssHtmlJsonYamlAndXmlExtensions()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "ComplexityScoringService.cs");
        Assert.IsTrue(Code.Contains("[\".css\"] = 1", StringComparison.Ordinal), "CSS files must have weight 1");
        Assert.IsTrue(Code.Contains("[\".scss\"] = 1", StringComparison.Ordinal), "SCSS files must have weight 1");
        Assert.IsTrue(Code.Contains("[\".html\"] = 1", StringComparison.Ordinal), "HTML files must have weight 1");
        Assert.IsTrue(Code.Contains("[\".json\"] = 1", StringComparison.Ordinal), "JSON files must have weight 1");
        Assert.IsTrue(Code.Contains("[\".xml\"] = 1", StringComparison.Ordinal), "XML files must have weight 1");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Complexity scoring service must calculate score from files changed additions deletions and extensions")]
    public void ComplexityScoringServiceMustCalculateScoreFromFilesChangedAdditionsDeletionsAndExtensions()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "ComplexityScoringService.cs");
        Assert.IsTrue(Code.Contains("CalculateComplexityScore", StringComparison.Ordinal), "Must implement CalculateComplexityScore method");
        Assert.IsTrue(Code.Contains("FilesChanged * 5", StringComparison.Ordinal), "File score must multiply files changed by 5");
        Assert.IsTrue(Code.Contains("(Additions + Deletions) / 10", StringComparison.Ordinal), "Line score must divide total changes by 10");
        Assert.IsTrue(Code.Contains("CalculateLanguageDifficultyScore", StringComparison.Ordinal), "Must call language difficulty score helper");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Complexity scoring service must calculate xp reward using app constants and streak bonus multiplier")]
    public void ComplexityScoringServiceMustCalculateXpRewardUsingAppConstantsAndStreakBonusMultiplier()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "ComplexityScoringService.cs");
        Assert.IsTrue(Code.Contains("CalculateXpReward", StringComparison.Ordinal), "Must implement CalculateXpReward method");
        Assert.IsTrue(Code.Contains("AppConstants.XpPerComplexityPoint", StringComparison.Ordinal), "Must use XpPerComplexityPoint constant");
        Assert.IsTrue(Code.Contains("AppConstants.StreakBonusMultiplier", StringComparison.Ordinal), "Must use StreakBonusMultiplier constant");
        Assert.IsTrue(Code.Contains("StreakDays > 0", StringComparison.Ordinal), "Must check for active streak days");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Complexity scoring service must use get value or default with fallback weight one for unknown extensions")]
    public void ComplexityScoringServiceMustUseGetValueOrDefaultWithFallbackWeightOneForUnknownExtensions()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "ComplexityScoringService.cs");
        Assert.IsTrue(Code.Contains("GetValueOrDefault(Extension, 1)", StringComparison.Ordinal), "Must fallback to weight 1 for unknown file extensions");
        Assert.IsTrue(Code.Contains("TotalWeight", StringComparison.Ordinal), "Must accumulate total weight from all extensions");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Diff sanitization service must implement partial class pattern with generated regex attributes")]
    public void DiffSanitizationServiceMustImplementPartialClassPatternWithGeneratedRegexAttributes()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "DiffSanitizationService.cs");
        Assert.IsTrue(Code.Contains("partial class DiffSanitizationService", StringComparison.Ordinal), "Must be a partial class for source generators");
        Assert.IsTrue(Code.Contains("[GeneratedRegex(", StringComparison.Ordinal), "Must use GeneratedRegex attribute for compile-time regex");
        Assert.IsTrue(Code.Contains("SecretPattern()", StringComparison.Ordinal), "Must define SecretPattern regex method");
        Assert.IsTrue(Code.Contains("FileExtensionPattern()", StringComparison.Ordinal), "Must define FileExtensionPattern regex method");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Diff sanitization service must sanitize diff by splitting lines and handling diff git headers")]
    public void DiffSanitizationServiceMustSanitizeDiffBySplittingLinesAndHandlingDiffGitHeaders()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "DiffSanitizationService.cs");
        Assert.IsTrue(Code.Contains("SanitizeDiffForPublicDisplay", StringComparison.Ordinal), "Must implement SanitizeDiffForPublicDisplay");
        Assert.IsTrue(Code.Contains("Split('\\n')", StringComparison.Ordinal), "Must split diff into individual lines");
        Assert.IsTrue(Code.Contains("diff --git", StringComparison.Ordinal), "Must detect diff git header lines");
        Assert.IsTrue(Code.Contains("StringBuilder", StringComparison.Ordinal), "Must use StringBuilder for efficient concatenation");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Diff sanitization service must redact file paths in diff headers keeping only filenames")]
    public void DiffSanitizationServiceMustRedactFilePathsInDiffHeadersKeepingOnlyFilenames()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "DiffSanitizationService.cs");
        Assert.IsTrue(Code.Contains("RedactFilePathInDiffHeader", StringComparison.Ordinal), "Must have RedactFilePathInDiffHeader method");
        Assert.IsTrue(Code.Contains("RedactFilePath", StringComparison.Ordinal), "Must have RedactFilePath for +++ and --- lines");
        Assert.IsTrue(Code.Contains("GetFileName", StringComparison.Ordinal), "Must extract filename from full path");
        Assert.IsTrue(Code.Contains("LastIndexOf('/')", StringComparison.Ordinal), "Must find last slash to extract filename");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Diff sanitization service must redact sensitive content matching password secret key and token patterns")]
    public void DiffSanitizationServiceMustRedactSensitiveContentMatchingPasswordSecretKeyAndTokenPatterns()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "DiffSanitizationService.cs");
        Assert.IsTrue(Code.Contains("RedactSensitiveContent", StringComparison.Ordinal), "Must have RedactSensitiveContent method");
        Assert.IsTrue(Code.Contains("[REDACTED]", StringComparison.Ordinal), "Must replace sensitive content with REDACTED marker");
        Assert.IsTrue(Code.Contains("password", StringComparison.Ordinal), "Secret pattern must match password values");
        Assert.IsTrue(Code.Contains("connection[_-]?string", StringComparison.Ordinal), "Secret pattern must match connection strings");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Diff sanitization service must extract unique file extensions from diff git headers")]
    public void DiffSanitizationServiceMustExtractUniqueFileExtensionsFromDiffGitHeaders()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "DiffSanitizationService.cs");
        Assert.IsTrue(Code.Contains("ExtractFileExtensions", StringComparison.Ordinal), "Must implement ExtractFileExtensions");
        Assert.IsTrue(Code.Contains("Distinct()", StringComparison.Ordinal), "Must return distinct file extensions only");
        Assert.IsTrue(Code.Contains("string.Join(','", StringComparison.Ordinal), "Must join extensions with comma separator");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Service registration must register all eight application services as scoped dependencies")]
    public void ServiceRegistrationMustRegisterAllEightApplicationServicesAsScopedDependencies()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "ServiceRegistration.cs");
        Assert.IsTrue(Code.Contains("AddScoped<IUserService, UserService>", StringComparison.Ordinal), "Must register UserService as scoped");
        Assert.IsTrue(Code.Contains("AddScoped<IComplexityScoringService, ComplexityScoringService>", StringComparison.Ordinal), "Must register ComplexityScoringService");
        Assert.IsTrue(Code.Contains("AddScoped<IDiffSanitizationService, DiffSanitizationService>", StringComparison.Ordinal), "Must register DiffSanitizationService");
        Assert.IsTrue(Code.Contains("AddScoped<IAchievementService, AchievementService>", StringComparison.Ordinal), "Must register AchievementService");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Service registration must register task pr payment and leaderboard services as scoped")]
    public void ServiceRegistrationMustRegisterTaskPrPaymentAndLeaderboardServicesAsScoped()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "ServiceRegistration.cs");
        Assert.IsTrue(Code.Contains("AddScoped<ITaskService, TaskService>", StringComparison.Ordinal), "Must register TaskService as scoped");
        Assert.IsTrue(Code.Contains("AddScoped<IPullRequestService, PullRequestService>", StringComparison.Ordinal), "Must register PullRequestService");
        Assert.IsTrue(Code.Contains("AddScoped<IPaymentService, PaymentService>", StringComparison.Ordinal), "Must register PaymentService");
        Assert.IsTrue(Code.Contains("AddScoped<ILeaderboardService, LeaderboardService>", StringComparison.Ordinal), "Must register LeaderboardService");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Service registration must configure named http clients for prtask and maya with base addresses")]
    public void ServiceRegistrationMustConfigureNamedHttpClientsForPrtaskAndMayaWithBaseAddresses()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "ServiceRegistration.cs");
        Assert.IsTrue(Code.Contains("AddHttpClient(AppConstants.AppName", StringComparison.Ordinal), "Must register PrTask named HTTP client");
        Assert.IsTrue(Code.Contains("AddHttpClient(\"Maya\"", StringComparison.Ordinal), "Must register Maya named HTTP client");
        Assert.IsTrue(Code.Contains("AppConstants.AppDomain", StringComparison.Ordinal), "PrTask client must use AppDomain for base address");
        Assert.IsTrue(Code.Contains("MayaConstants.SandboxBaseUrl", StringComparison.Ordinal), "Maya client must use sandbox base URL");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Service registration must return service collection for fluent chaining and use extension method")]
    public void ServiceRegistrationMustReturnServiceCollectionForFluentChainingAndUseExtensionMethod()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "ServiceRegistration.cs");
        Assert.IsTrue(Code.Contains("this IServiceCollection Services", StringComparison.Ordinal), "AddInfrastructure must be an extension method");
        Assert.IsTrue(Code.Contains("return Services", StringComparison.Ordinal), "Must return Services for fluent chaining");
        Assert.IsTrue(Code.Contains("static class ServiceRegistration", StringComparison.Ordinal), "Must be a static class");
        Assert.IsTrue(Code.Contains("AddInfrastructure", StringComparison.Ordinal), "Extension method must be named AddInfrastructure");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Infrastructure global usings must import dependency injection hosting and logging namespaces")]
    public void InfrastructureGlobalUsingsMustImportDependencyInjectionHostingAndLoggingNamespaces()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "GlobalUsings.cs");
        Assert.IsTrue(Code.Contains("Microsoft.Extensions.DependencyInjection", StringComparison.Ordinal), "Must globally use DependencyInjection namespace");
        Assert.IsTrue(Code.Contains("Microsoft.Extensions.Hosting", StringComparison.Ordinal), "Must globally use Hosting namespace");
        Assert.IsTrue(Code.Contains("Microsoft.Extensions.Logging", StringComparison.Ordinal), "Must globally use Logging namespace");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Complexity scoring service must include jsx tsx ruby proto and yaml in language weights")]
    public void ComplexityScoringServiceMustIncludeJsxTsxRubyProtoAndYamlInLanguageWeights()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "ComplexityScoringService.cs");
        Assert.IsTrue(Code.Contains("[\".jsx\"] = 2", StringComparison.Ordinal), "JSX files must have weight 2");
        Assert.IsTrue(Code.Contains("[\".tsx\"] = 2", StringComparison.Ordinal), "TSX files must have weight 2");
        Assert.IsTrue(Code.Contains("[\".rb\"] = 2", StringComparison.Ordinal), "Ruby files must have weight 2");
        Assert.IsTrue(Code.Contains("[\".proto\"] = 2", StringComparison.Ordinal), "Proto files must have weight 2");
        Assert.IsTrue(Code.Contains("[\".yml\"] = 1", StringComparison.Ordinal), "YAML .yml files must have weight 1");
        Assert.IsTrue(Code.Contains("[\".yaml\"] = 1", StringComparison.Ordinal), "YAML .yaml files must have weight 1");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Diff sanitization service must handle plus minus and at sign prefixed lines for diff format")]
    public void DiffSanitizationServiceMustHandlePlusMinusAndAtSignPrefixedLinesForDiffFormat()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "DiffSanitizationService.cs");
        Assert.IsTrue(Code.Contains("StartsWith(\"+++\"", StringComparison.Ordinal), "Must detect +++ file header lines");
        Assert.IsTrue(Code.Contains("StartsWith(\"---\"", StringComparison.Ordinal), "Must detect --- file header lines");
        Assert.IsTrue(Code.Contains("StartsWith(\"@@\"", StringComparison.Ordinal), "Must detect @@ hunk header lines");
        Assert.IsTrue(Code.Contains("TrimEnd()", StringComparison.Ordinal), "Must trim trailing whitespace from result");
    }
}
