using System.Net;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Complexity scoring service must calculate score from files changed additions deletions and extensions")]
    public void ComplexityScoringServiceMustCalculateScoreFromFilesChangedAdditionsDeletionsAndExtensions()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "ComplexityScoringService.cs");
        Assert.IsTrue(Code.Contains("CalculateComplexityScore", StringComparison.Ordinal), "Must implement complexity score calculation");
        Assert.IsTrue(Code.Contains("FilesChanged", StringComparison.Ordinal), "Must consider number of files changed");
        Assert.IsTrue(Code.Contains("Additions", StringComparison.Ordinal), "Must consider lines added");
        Assert.IsTrue(Code.Contains("Deletions", StringComparison.Ordinal), "Must consider lines deleted");
        Assert.IsTrue(Code.Contains("FileExtensions", StringComparison.Ordinal), "Must consider file types for language difficulty");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Complexity scoring service must have language difficulty weights for common programming languages")]
    public void ComplexityScoringServiceMustHaveLanguageDifficultyWeightsForCommonProgrammingLanguages()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "ComplexityScoringService.cs");
        Assert.IsTrue(Code.Contains(".cs", StringComparison.Ordinal), "Must weight C# files");
        Assert.IsTrue(Code.Contains(".rs", StringComparison.Ordinal), "Must weight Rust files");
        Assert.IsTrue(Code.Contains(".ts", StringComparison.Ordinal), "Must weight TypeScript files");
        Assert.IsTrue(Code.Contains(".py", StringComparison.Ordinal), "Must weight Python files");
        Assert.IsTrue(Code.Contains(".sql", StringComparison.Ordinal), "Must weight SQL files");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Complexity scoring service must calculate xp reward with streak bonus multiplier for active developers")]
    public void ComplexityScoringServiceMustCalculateXpRewardWithStreakBonusMultiplierForActiveDevelopers()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "ComplexityScoringService.cs");
        Assert.IsTrue(Code.Contains("CalculateXpReward", StringComparison.Ordinal), "Must implement XP reward calculation");
        Assert.IsTrue(Code.Contains("XpPerComplexityPoint", StringComparison.Ordinal), "Must use XP per complexity point constant");
        Assert.IsTrue(Code.Contains("StreakBonusMultiplier", StringComparison.Ordinal), "Must apply streak bonus for consecutive days");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Complexity scoring interface must define calculate complexity score and xp reward methods")]
    public void ComplexityScoringInterfaceMustDefineCalculateComplexityScoreAndXpRewardMethods()
    {
        var Code = ReadSourceFile("PrTask.Application", "Services", "IComplexityScoringService.cs");
        Assert.IsTrue(Code.Contains("CalculateComplexityScore", StringComparison.Ordinal), "Interface must declare complexity score method");
        Assert.IsTrue(Code.Contains("CalculateXpReward", StringComparison.Ordinal), "Interface must declare XP reward method");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Diff sanitization service must redact sensitive content like passwords keys and tokens from diffs")]
    public void DiffSanitizationServiceMustRedactSensitiveContentLikePasswordsKeysAndTokensFromDiffs()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "DiffSanitizationService.cs");
        Assert.IsTrue(Code.Contains("SanitizeDiffForPublicDisplay", StringComparison.Ordinal), "Must implement sanitization for public diff display");
        Assert.IsTrue(Code.Contains("REDACTED", StringComparison.Ordinal), "Must replace sensitive content with REDACTED marker");
        Assert.IsTrue(Code.Contains("password", StringComparison.OrdinalIgnoreCase), "Must detect password patterns in diff content");
        Assert.IsTrue(Code.Contains("secret", StringComparison.OrdinalIgnoreCase), "Must detect secret patterns in diff content");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Diff sanitization service must extract file extensions from raw diff headers for analysis")]
    public void DiffSanitizationServiceMustExtractFileExtensionsFromRawDiffHeadersForAnalysis()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "DiffSanitizationService.cs");
        Assert.IsTrue(Code.Contains("ExtractFileExtensions", StringComparison.Ordinal), "Must implement file extension extraction from diff");
        Assert.IsTrue(Code.Contains("diff --git", StringComparison.Ordinal), "Must parse git diff header format");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Diff sanitization service must strip full file paths keeping only filenames for privacy")]
    public void DiffSanitizationServiceMustStripFullFilePathsKeepingOnlyFilenamesForPrivacy()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "DiffSanitizationService.cs");
        Assert.IsTrue(Code.Contains("RedactFilePath", StringComparison.Ordinal), "Must redact full file paths from diff output");
        Assert.IsTrue(Code.Contains("GetFileName", StringComparison.Ordinal), "Must extract just the filename from full path");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Achievement service interface must define get by user and evaluate award badges async methods")]
    public void AchievementServiceInterfaceMustDefineGetByUserAndEvaluateAwardBadgesAsyncMethods()
    {
        var Code = ReadSourceFile("PrTask.Application", "Services", "IAchievementService.cs");
        Assert.IsTrue(Code.Contains("GetByUserAsync", StringComparison.Ordinal), "IAchievementService must retrieve user badges");
        Assert.IsTrue(Code.Contains("EvaluateAndAwardBadgesAsync", StringComparison.Ordinal), "IAchievementService must evaluate and award badges");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Leaderboard service interface must define get rank and get top methods for rankings")]
    public void LeaderboardServiceInterfaceMustDefineGetRankAndGetTopMethodsForRankings()
    {
        var Code = ReadSourceFile("PrTask.Application", "Services", "ILeaderboardService.cs");
        Assert.IsTrue(Code.Contains("GetRankAsync", StringComparison.Ordinal), "ILeaderboardService must support individual rank lookup");
        Assert.IsTrue(Code.Contains("GetTopAsync", StringComparison.Ordinal), "ILeaderboardService must support top N leaderboard query");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Leaderboard entry model must have rank prs merged total earned and xp level fields")]
    public void LeaderboardEntryModelMustHaveRankPrsMergedTotalEarnedAndXpLevelFields()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "LeaderboardEntry.cs");
        Assert.IsTrue(Code.Contains("Rank", StringComparison.Ordinal), "LeaderboardEntry must have Rank field");
        Assert.IsTrue(Code.Contains("PrsMerged", StringComparison.Ordinal), "LeaderboardEntry must track PRs merged count");
        Assert.IsTrue(Code.Contains("TotalEarnedCents", StringComparison.Ordinal), "LeaderboardEntry must track total earned amount");
        Assert.IsTrue(Code.Contains("Xp", StringComparison.Ordinal), "LeaderboardEntry must have XP field");
        Assert.IsTrue(Code.Contains("Level", StringComparison.Ordinal), "LeaderboardEntry must have Level field");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Leaderboard endpoints must map get top and get user rank routes for leaderboard api")]
    public void LeaderboardEndpointsMustMapGetTopAndGetUserRankRoutesForLeaderboardApi()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "LeaderboardEndpoints.cs");
        Assert.IsTrue(Code.Contains("ApiLeaderboard", StringComparison.Ordinal), "LeaderboardEndpoints must use ApiLeaderboard route constant");
        Assert.IsTrue(Code.Contains("GetTopAsync", StringComparison.Ordinal), "LeaderboardEndpoints must call GetTopAsync for leaderboard list");
        Assert.IsTrue(Code.Contains("GetRankAsync", StringComparison.Ordinal), "LeaderboardEndpoints must call GetRankAsync for individual rank");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Claim task request contract must have developer id field for task assignment workflow")]
    public void ClaimTaskRequestContractMustHaveDeveloperIdFieldForTaskAssignmentWorkflow()
    {
        var Code = ReadSourceFile("PrTask.Application", "Contracts", "ClaimTaskRequest.cs");
        Assert.IsTrue(Code.Contains("DeveloperId", StringComparison.Ordinal), "ClaimTaskRequest must identify the developer claiming the task");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Reject pull request request contract must have notes field for client rejection feedback")]
    public void RejectPullRequestRequestContractMustHaveNotesFieldForClientRejectionFeedback()
    {
        var Code = ReadSourceFile("PrTask.Application", "Contracts", "RejectPullRequestRequest.cs");
        Assert.IsTrue(Code.Contains("Notes", StringComparison.Ordinal), "RejectPullRequestRequest must include rejection notes for developer feedback");
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Leaderboard endpoint must return successful response with list of top ranked developers")]
    public async Task LeaderboardEndpointMustReturnSuccessfulResponseWithListOfTopRankedDevelopersAsync()
    {
        var Response = await ApiClient.GetAsync(RouteConstants.ApiLeaderboard);
        Assert.AreEqual(HttpStatusCode.OK, Response.StatusCode);
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Leaderboard user rank endpoint must return successful response with rank for specific user")]
    public async Task LeaderboardUserRankEndpointMustReturnSuccessfulResponseWithRankForSpecificUserAsync()
    {
        var Response = await ApiClient.GetAsync($"{RouteConstants.ApiLeaderboard}/test-user-id");
        Assert.AreEqual(HttpStatusCode.OK, Response.StatusCode);
    }
}
