using PrTask.Domain.Constants;
using PrTask.Infrastructure.Services;
namespace PrTask.Unit;
[TestClass]
public class AchievementServiceTests
{
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Determine eligible badges must return empty list when no thresholds met")]
    public void DetermineEligibleBadgesMustReturnEmptyListWhenNoThresholdsMet()
    {
        var Badges = AchievementService.DetermineEligibleBadges(0, 0, 0, 0);
        Assert.AreEqual(0, Badges.Count);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Determine eligible badges must award first pr merged at one pr")]
    public void DetermineEligibleBadgesMustAwardFirstPrMergedAtOnePr()
    {
        var Badges = AchievementService.DetermineEligibleBadges(1, 0, 0, 0);
        CollectionAssert.Contains(Badges, BadgeConstants.FirstPrMerged);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Determine eligible badges must award ten prs merged at ten prs")]
    public void DetermineEligibleBadgesMustAwardTenPrsMergedAtTenPrs()
    {
        var Badges = AchievementService.DetermineEligibleBadges(10, 0, 0, 0);
        CollectionAssert.Contains(Badges, BadgeConstants.FirstPrMerged);
        CollectionAssert.Contains(Badges, BadgeConstants.TenPrsMerged);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Determine eligible badges must award fifty prs merged at fifty prs")]
    public void DetermineEligibleBadgesMustAwardFiftyPrsMergedAtFiftyPrs()
    {
        var Badges = AchievementService.DetermineEligibleBadges(50, 0, 0, 0);
        CollectionAssert.Contains(Badges, BadgeConstants.FiftyPrsMerged);
        Assert.AreEqual(3, Badges.Count);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Determine eligible badges must award hundred prs merged at hundred prs")]
    public void DetermineEligibleBadgesMustAwardHundredPrsMergedAtHundredPrs()
    {
        var Badges = AchievementService.DetermineEligibleBadges(100, 0, 0, 0);
        CollectionAssert.Contains(Badges, BadgeConstants.HundredPrsMerged);
        Assert.AreEqual(4, Badges.Count);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Determine eligible badges must award thousand php earned badge")]
    public void DetermineEligibleBadgesMustAwardThousandPhpEarnedBadge()
    {
        var Badges = AchievementService.DetermineEligibleBadges(0, BadgeConstants.ThousandPhpThreshold, 0, 0);
        CollectionAssert.Contains(Badges, BadgeConstants.ThousandPhpEarned);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Determine eligible badges must award ten thousand php earned badge")]
    public void DetermineEligibleBadgesMustAwardTenThousandPhpEarnedBadge()
    {
        var Badges = AchievementService.DetermineEligibleBadges(0, BadgeConstants.TenThousandPhpThreshold, 0, 0);
        CollectionAssert.Contains(Badges, BadgeConstants.ThousandPhpEarned);
        CollectionAssert.Contains(Badges, BadgeConstants.TenThousandPhpEarned);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Determine eligible badges must award week streak at seven days")]
    public void DetermineEligibleBadgesMustAwardWeekStreakAtSevenDays()
    {
        var Badges = AchievementService.DetermineEligibleBadges(0, 0, 7, 0);
        CollectionAssert.Contains(Badges, BadgeConstants.WeekStreak);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Determine eligible badges must award month streak at thirty days")]
    public void DetermineEligibleBadgesMustAwardMonthStreakAtThirtyDays()
    {
        var Badges = AchievementService.DetermineEligibleBadges(0, 0, 30, 0);
        CollectionAssert.Contains(Badges, BadgeConstants.WeekStreak);
        CollectionAssert.Contains(Badges, BadgeConstants.MonthStreak);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Determine eligible badges must award top ten leaderboard for rank one")]
    public void DetermineEligibleBadgesMustAwardTopTenLeaderboardForRankOne()
    {
        var Badges = AchievementService.DetermineEligibleBadges(0, 0, 0, 1);
        CollectionAssert.Contains(Badges, BadgeConstants.TopTenLeaderboard);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Determine eligible badges must award top ten leaderboard for rank ten")]
    public void DetermineEligibleBadgesMustAwardTopTenLeaderboardForRankTen()
    {
        var Badges = AchievementService.DetermineEligibleBadges(0, 0, 0, 10);
        CollectionAssert.Contains(Badges, BadgeConstants.TopTenLeaderboard);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Determine eligible badges must not award top ten leaderboard for rank eleven")]
    public void DetermineEligibleBadgesMustNotAwardTopTenLeaderboardForRankEleven()
    {
        var Badges = AchievementService.DetermineEligibleBadges(0, 0, 0, 11);
        CollectionAssert.DoesNotContain(Badges, BadgeConstants.TopTenLeaderboard);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Determine eligible badges must not award top ten leaderboard for rank zero")]
    public void DetermineEligibleBadgesMustNotAwardTopTenLeaderboardForRankZero()
    {
        var Badges = AchievementService.DetermineEligibleBadges(0, 0, 0, 0);
        CollectionAssert.DoesNotContain(Badges, BadgeConstants.TopTenLeaderboard);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Determine eligible badges must award all badges for maximum stats")]
    public void DetermineEligibleBadgesMustAwardAllBadgesForMaximumStats()
    {
        var Badges = AchievementService.DetermineEligibleBadges(100, BadgeConstants.TenThousandPhpThreshold, 30, 1);
        Assert.AreEqual(9, Badges.Count);
    }
}
