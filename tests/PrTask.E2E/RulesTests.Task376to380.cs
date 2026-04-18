using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SubmitPrPage validates GitHub PR URL format")]
    public void SubmitPrPageValidatesUrl()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "SubmitPrPage.razor");
        Assert.IsTrue(Source.Contains("IsValidGitHubPrUrl"), "Has URL validation method");
        Assert.IsTrue(Source.Contains(nameof(SubmitPrConstants.InvalidGitHubUrl)), "Uses InvalidGitHubUrl constant");
        Assert.IsTrue(Source.Contains(nameof(SubmitPrConstants.GitHubPrUrlPrefix)), "Checks GitHub prefix");
        Assert.IsTrue(Source.Contains(nameof(SubmitPrConstants.GitHubPrUrlSegment)), "Checks /pull/ segment");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SubmitPrConstants has validation messages and URL patterns")]
    public void SubmitPrConstantsComplete()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "SubmitPrConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(SubmitPrConstants.EnterUserId)), "Has EnterUserId");
        Assert.IsTrue(Source.Contains(nameof(SubmitPrConstants.InvalidGitHubUrl)), "Has InvalidGitHubUrl");
        Assert.IsTrue(Source.Contains(nameof(SubmitPrConstants.GitHubPrUrlPrefix)), "Has GitHubPrUrlPrefix");
        Assert.IsTrue(Source.Contains(nameof(SubmitPrConstants.GitHubPrUrlSegment)), "Has GitHubPrUrlSegment");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("BoardDetailPage enforces WIP limits visually")]
    public void BoardDetailPageWipEnforcement()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "BoardDetailPage.razor");
        Assert.IsTrue(Source.Contains("IsWipExceeded"), "Has WIP exceeded check");
        Assert.IsTrue(Source.Contains("wip-exceeded"), "Has wip-exceeded CSS class");
        Assert.IsTrue(Source.Contains("GetColumnTaskCount"), "Counts tasks per column");
        Assert.IsTrue(Source.Contains("wip-exceeded-badge"), "Has WIP exceeded badge class");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("BoardDetailPage shows task count vs WIP limit")]
    public void BoardDetailPageTaskCountDisplay()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "BoardDetailPage.razor");
        Assert.IsTrue(Source.Contains("GetColumnTaskCount(Column.Id)"), "Shows current task count");
        Assert.IsTrue(Source.Contains("Column.WipLimit"), "Shows WIP limit value");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("BoardConstants has WIP limit messages")]
    public void BoardConstantsComplete()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "BoardConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(BoardConstants.WipLimitExceeded)), "Has WipLimitExceeded message");
    }
}
