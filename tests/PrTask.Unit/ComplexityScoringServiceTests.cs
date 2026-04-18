using PrTask.Domain.Constants;
using PrTask.Infrastructure.Services;
namespace PrTask.Unit;
[TestClass]
public class ComplexityScoringServiceTests
{
    private ComplexityScoringService Service { get; } = new();
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Complexity score must return zero for zero inputs with no file extensions")]
    public void ComplexityScoreMustReturnZeroForZeroInputsWithNoFileExtensions()
    {
        var Score = Service.CalculateComplexityScore(0, 0, 0, []);
        Assert.AreEqual(0, Score);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Complexity score must weight files changed at five points each")]
    public void ComplexityScoreMustWeightFilesChangedAtFivePointsEach()
    {
        var Score = Service.CalculateComplexityScore(3, 0, 0, []);
        Assert.AreEqual(15, Score);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Complexity score must weight line changes at one point per ten lines")]
    public void ComplexityScoreMustWeightLineChangesAtOnePointPerTenLines()
    {
        var Score = Service.CalculateComplexityScore(0, 50, 50, []);
        Assert.AreEqual(10, Score);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Complexity score must apply csharp language weight of three")]
    public void ComplexityScoreMustApplyCsharpLanguageWeightOfThree()
    {
        var Score = Service.CalculateComplexityScore(0, 0, 0, [".cs"]);
        Assert.AreEqual(3, Score);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Complexity score must apply rust language weight of four")]
    public void ComplexityScoreMustApplyRustLanguageWeightOfFour()
    {
        var Score = Service.CalculateComplexityScore(0, 0, 0, [".rs"]);
        Assert.AreEqual(4, Score);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Complexity score must apply default weight of one for unknown extensions")]
    public void ComplexityScoreMustApplyDefaultWeightOfOneForUnknownExtensions()
    {
        var Score = Service.CalculateComplexityScore(0, 0, 0, [".xyz"]);
        Assert.AreEqual(1, Score);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Complexity score must sum all components for mixed input")]
    public void ComplexityScoreMustSumAllComponentsForMixedInput()
    {
        var Score = Service.CalculateComplexityScore(2, 30, 20, [".cs", ".ts"]);
        Assert.AreEqual(10 + 5 + 3 + 2, Score);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Complexity score must handle multiple extensions of same type")]
    public void ComplexityScoreMustHandleMultipleExtensionsOfSameType()
    {
        var Score = Service.CalculateComplexityScore(0, 0, 0, [".cs", ".cs", ".cs"]);
        Assert.AreEqual(9, Score);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Xp reward must multiply complexity score by xp per point constant")]
    public void XpRewardMustMultiplyComplexityScoreByXpPerPointConstant()
    {
        var Xp = Service.CalculateXpReward(10, 0);
        Assert.AreEqual(10 * AppConstants.XpPerComplexityPoint, Xp);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Xp reward must apply streak bonus multiplier when streak days positive")]
    public void XpRewardMustApplyStreakBonusMultiplierWhenStreakDaysPositive()
    {
        var Xp = Service.CalculateXpReward(10, 5);
        Assert.AreEqual(10 * AppConstants.XpPerComplexityPoint * AppConstants.StreakBonusMultiplier, Xp);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Xp reward must not apply streak bonus when streak days is zero")]
    public void XpRewardMustNotApplyStreakBonusWhenStreakDaysIsZero()
    {
        var XpNoStreak = Service.CalculateXpReward(10, 0);
        var XpWithStreak = Service.CalculateXpReward(10, 1);
        Assert.IsTrue(XpWithStreak > XpNoStreak);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Complexity score must be case insensitive for file extensions")]
    public void ComplexityScoreMustBeCaseInsensitiveForFileExtensions()
    {
        var LowerScore = Service.CalculateComplexityScore(0, 0, 0, [".cs"]);
        var UpperScore = Service.CalculateComplexityScore(0, 0, 0, [".CS"]);
        Assert.AreEqual(LowerScore, UpperScore);
    }
}
