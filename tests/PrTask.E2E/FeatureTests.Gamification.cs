namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Badge constants must define achievement badges for pr milestones and streaks")]
    public void BadgeConstantsMustDefineAchievementBadgesForPrMilestonesAndStreaks()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "BadgeConstants.cs");
        Assert.IsTrue(Code.Contains("FirstPrMerged", StringComparison.Ordinal), "Must have FirstPrMerged badge");
        Assert.IsTrue(Code.Contains("TenPrsMerged", StringComparison.Ordinal), "Must have TenPrsMerged badge");
        Assert.IsTrue(Code.Contains("WeekStreak", StringComparison.Ordinal), "Must have WeekStreak badge");
        Assert.IsTrue(Code.Contains("MonthStreak", StringComparison.Ordinal), "Must have MonthStreak badge");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Badge constants must define leaderboard and earning achievement milestones")]
    public void BadgeConstantsMustDefineLeaderboardAndEarningAchievementMilestones()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "BadgeConstants.cs");
        Assert.IsTrue(Code.Contains("TopTenLeaderboard", StringComparison.Ordinal), "Must have TopTenLeaderboard badge");
        Assert.IsTrue(Code.Contains("ComplexityExpert", StringComparison.Ordinal), "Must have ComplexityExpert badge");
        Assert.IsTrue(Code.Contains("FirstBountyPosted", StringComparison.Ordinal), "Must have FirstBountyPosted badge for clients");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("User entity must have xp level and streak fields for gamification system")]
    public void UserEntityMustHaveXpLevelAndStreakFieldsForGamificationSystem()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "UserEntity.cs");
        Assert.IsTrue(Code.Contains("Xp", StringComparison.Ordinal), "UserEntity must have Xp property for experience points");
        Assert.IsTrue(Code.Contains("Level", StringComparison.Ordinal), "UserEntity must have Level property for progression");
        Assert.IsTrue(Code.Contains("StreakDays", StringComparison.Ordinal), "UserEntity must have StreakDays property for streak tracking");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Achievement entity must exist with user id and badge type for earned badges")]
    public void AchievementEntityMustExistWithUserIdAndBadgeTypeForEarnedBadges()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "AchievementEntity.cs");
        Assert.IsTrue(Code.Contains("UserId", StringComparison.Ordinal), "AchievementEntity must have UserId");
        Assert.IsTrue(Code.Contains("BadgeType", StringComparison.Ordinal), "AchievementEntity must have BadgeType");
        Assert.IsTrue(Code.Contains("EarnedAt", StringComparison.Ordinal), "AchievementEntity must track when badge was earned");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Leaderboard page must display rank level xp and earnings for top developers")]
    public void LeaderboardPageMustDisplayRankLevelXpAndEarningsForTopDevelopers()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "LeaderboardPage.razor");
        Assert.IsTrue(Razor.Contains("Rank", StringComparison.Ordinal), "Leaderboard must show developer rank");
        Assert.IsTrue(Razor.Contains("Level", StringComparison.Ordinal), "Leaderboard must show developer level");
        Assert.IsTrue(Razor.Contains("XP", StringComparison.Ordinal), "Leaderboard must show developer XP");
        Assert.IsTrue(Razor.Contains("PRs Merged", StringComparison.Ordinal), "Leaderboard must show PRs merged count");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Profile page must display user badges with level xp and streak day counts")]
    public void ProfilePageMustDisplayUserBadgesWithLevelXpAndStreakDayCounts()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "ProfilePage.razor");
        Assert.IsTrue(Razor.Contains("Lv.", StringComparison.Ordinal), "Profile must display user level");
        Assert.IsTrue(Razor.Contains("XP", StringComparison.Ordinal), "Profile must display user XP");
        Assert.IsTrue(Razor.Contains("Streak", StringComparison.Ordinal), "Profile must display streak days");
        Assert.IsTrue(Razor.Contains("profile-badges", StringComparison.Ordinal), "Profile must have badges section");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Dashboard page must show active tasks prs submitted earnings and current level stats")]
    public void DashboardPageMustShowActiveTasksPrsSubmittedEarningsAndCurrentLevelStats()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "DashboardPage.razor");
        Assert.IsTrue(Razor.Contains("Active Tasks", StringComparison.Ordinal), "Dashboard must show active tasks count");
        Assert.IsTrue(Razor.Contains("PRs Submitted", StringComparison.Ordinal), "Dashboard must show PRs submitted count");
        Assert.IsTrue(Razor.Contains("Total Earned", StringComparison.Ordinal), "Dashboard must show total earned amount");
        Assert.IsTrue(Razor.Contains("Current Level", StringComparison.Ordinal), "Dashboard must show current user level");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("App constants must define xp thresholds and complexity scoring for leveling system")]
    public void AppConstantsMustDefineXpThresholdsAndComplexityScoringForLevelingSystem()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "AppConstants.cs");
        Assert.IsTrue(Code.Contains("XpPerComplexityPoint", StringComparison.Ordinal), "Must define XP per complexity point");
        Assert.IsTrue(Code.Contains("StreakBonusMultiplier", StringComparison.Ordinal), "Must define streak bonus multiplier");
        Assert.IsTrue(Code.Contains("Level1Threshold", StringComparison.Ordinal), "Must define level thresholds");
    }
}
