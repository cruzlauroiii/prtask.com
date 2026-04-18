using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("LeaderboardConstants has all UI text constants")]
    public void LeaderboardConstantsComplete()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "LeaderboardConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(LeaderboardConstants.TopEarnersTab)), "Has TopEarnersTab");
        Assert.IsTrue(Source.Contains(nameof(LeaderboardConstants.TopSpendersTab)), "Has TopSpendersTab");
        Assert.IsTrue(Source.Contains(nameof(LeaderboardConstants.LoadingText)), "Has LoadingText");
        Assert.IsTrue(Source.Contains(nameof(LeaderboardConstants.EmptyStateText)), "Has EmptyStateText");
        Assert.IsTrue(Source.Contains(nameof(LeaderboardConstants.HeaderRank)), "Has HeaderRank");
        Assert.IsTrue(Source.Contains(nameof(LeaderboardConstants.DefaultTopCount)), "Has DefaultTopCount");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("LeaderboardPage uses LeaderboardConstants for all UI text")]
    public void LeaderboardPageUsesLeaderboardConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "LeaderboardPage.razor");
        Assert.IsTrue(Source.Contains("LeaderboardConstants.TopEarnersTab"), "Uses TopEarnersTab");
        Assert.IsTrue(Source.Contains("LeaderboardConstants.TopSpendersTab"), "Uses TopSpendersTab");
        Assert.IsTrue(Source.Contains("LeaderboardConstants.LoadingText"), "Uses LoadingText");
        Assert.IsTrue(Source.Contains("LeaderboardConstants.EmptyStateText"), "Uses EmptyStateText");
        Assert.IsTrue(Source.Contains("LeaderboardConstants.HeaderRank"), "Uses HeaderRank");
        Assert.IsTrue(Source.Contains("LeaderboardConstants.DefaultTopCount"), "Uses DefaultTopCount");
        Assert.IsFalse(Source.Contains("\"Top Earners\""), "No hardcoded tab text");
        Assert.IsFalse(Source.Contains("\"Loading leaderboard...\""), "No hardcoded loading text");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("EditTaskConstants has all UI text constants")]
    public void EditTaskConstantsComplete()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "EditTaskConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(EditTaskConstants.PageHeading)), "Has PageHeading");
        Assert.IsTrue(Source.Contains(nameof(EditTaskConstants.LoadingText)), "Has LoadingText");
        Assert.IsTrue(Source.Contains(nameof(EditTaskConstants.TitleLabel)), "Has TitleLabel");
        Assert.IsTrue(Source.Contains(nameof(EditTaskConstants.DescriptionLabel)), "Has DescriptionLabel");
        Assert.IsTrue(Source.Contains(nameof(EditTaskConstants.BountyLabel)), "Has BountyLabel");
        Assert.IsTrue(Source.Contains(nameof(EditTaskConstants.SaveButtonText)), "Has SaveButtonText");
        Assert.IsTrue(Source.Contains(nameof(EditTaskConstants.CancelButtonText)), "Has CancelButtonText");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("EditTaskPage uses EditTaskConstants for all UI text")]
    public void EditTaskPageUsesEditTaskConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Client", "EditTaskPage.razor");
        Assert.IsTrue(Source.Contains("EditTaskConstants.PageHeading"), "Uses PageHeading");
        Assert.IsTrue(Source.Contains("EditTaskConstants.LoadingText"), "Uses LoadingText");
        Assert.IsTrue(Source.Contains("EditTaskConstants.TitleLabel"), "Uses TitleLabel");
        Assert.IsTrue(Source.Contains("EditTaskConstants.DescriptionLabel"), "Uses DescriptionLabel");
        Assert.IsTrue(Source.Contains("EditTaskConstants.RepoUrlLabel"), "Uses RepoUrlLabel");
        Assert.IsTrue(Source.Contains("EditTaskConstants.BountyLabel"), "Uses BountyLabel");
        Assert.IsTrue(Source.Contains("EditTaskConstants.DeadlineLabel"), "Uses DeadlineLabel");
        Assert.IsTrue(Source.Contains("EditTaskConstants.TagsLabel"), "Uses TagsLabel");
        Assert.IsTrue(Source.Contains("EditTaskConstants.SaveButtonText"), "Uses SaveButtonText");
        Assert.IsTrue(Source.Contains("EditTaskConstants.CancelButtonText"), "Uses CancelButtonText");
        Assert.IsFalse(Source.Contains("\"Edit Task\""), "No hardcoded heading");
        Assert.IsFalse(Source.Contains("\"Save Changes\""), "No hardcoded button text");
    }
}
