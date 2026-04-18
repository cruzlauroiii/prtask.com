namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("TaskDetailPage shows edit/delete only to task owner")]
    public void TaskDetailPageOwnerOnlyActions()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "TaskDetailPage.razor");
        Assert.IsTrue(Source.Contains("CurrentTask.ClientId == CurrentUserId"), "Edit/Delete gated by ClientId match");
        Assert.IsTrue(Source.Contains("task-owner-actions"), "Has owner actions section");
        Assert.IsTrue(Source.Contains("CurrentTask.ClientId != CurrentUserId"), "Claim gated to non-owners");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("CreateTaskPage uses BountyAmountDollars not BountyAmountPesos")]
    public void CreateTaskPageUsesCorrectCurrencyName()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Client", "CreateTaskPage.razor");
        Assert.IsTrue(Source.Contains("BountyAmountDollars"), "Uses BountyAmountDollars");
        Assert.IsFalse(Source.Contains("BountyAmountPesos"), "Does not use BountyAmountPesos");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("LeaderboardPage has earnings and spending tabs with real data")]
    public void LeaderboardPageHasRealTabs()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "LeaderboardPage.razor");
        Assert.IsTrue(Source.Contains("GetTopAsync"), "Loads earnings");
        Assert.IsTrue(Source.Contains("GetTopBySpendingAsync"), "Loads spending");
        Assert.IsTrue(Source.Contains("ShowEarnings"), "Has tab toggle state");
        Assert.IsTrue(Source.Contains("EarningsRank"), "Shows earnings rank");
        Assert.IsTrue(Source.Contains("SpendingRank"), "Shows spending rank");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("ProfilePage loads real user data from services")]
    public void ProfilePageLoadsRealData()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "ProfilePage.razor");
        Assert.IsTrue(Source.Contains("IUserService"), "Injects IUserService");
        Assert.IsTrue(Source.Contains("ILeaderboardService"), "Injects ILeaderboardService");
        Assert.IsTrue(Source.Contains("GetByIdAsync"), "Loads user by ID");
        Assert.IsTrue(Source.Contains("GetRankAsync"), "Gets leaderboard rank");
        Assert.IsTrue(Source.Contains("TotalEarnedCents"), "Shows total earned");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("RepositoryPage has full CRUD with add form and delete")]
    public void RepositoryPageFullCrud()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Client", "RepositoryPage.razor");
        Assert.IsTrue(Source.Contains("CreateAsync"), "Creates repositories");
        Assert.IsTrue(Source.Contains("DeleteAsync"), "Deletes repositories");
        Assert.IsTrue(Source.Contains("ListByOwnerAsync"), "Lists by owner");
        Assert.IsTrue(Source.Contains("RepositoryVisibility"), "Supports visibility settings");
    }
}
