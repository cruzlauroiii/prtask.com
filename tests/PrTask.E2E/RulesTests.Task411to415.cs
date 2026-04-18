using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("TaskDetailPage uses RouteConstants for all dynamic links")]
    public void TaskDetailPageUsesRouteConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "TaskDetailPage.razor");
        Assert.IsTrue(Source.Contains("RouteConstants.EditTask"), "Uses RouteConstants.EditTask");
        Assert.IsTrue(Source.Contains("RouteConstants.PullRequestDetail"), "Uses RouteConstants.PullRequestDetail");
        Assert.IsTrue(Source.Contains("RouteConstants.SubmitPr"), "Uses RouteConstants.SubmitPr");
        Assert.IsFalse(Source.Contains("href=\"/Client/EditTask/"), "No hardcoded edit task href");
        Assert.IsFalse(Source.Contains("href=\"/Prs/"), "No hardcoded PR href");
        Assert.IsFalse(Source.Contains("href=\"/tasks/@TaskId/submit-pr"), "No hardcoded submit PR href");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("All SharedUI pages use RouteConstants for dynamic href attributes")]
    public void AllPagesUseRouteConstantsForDynamicHrefs()
    {
        var Boards = ReadSource("PrTask.SharedUI", "Pages", "BoardsPage.razor");
        Assert.IsTrue(Boards.Contains("RouteConstants.BoardDetail"), "BoardsPage uses RouteConstants.BoardDetail");
        var BoardDetail = ReadSource("PrTask.SharedUI", "Pages", "BoardDetailPage.razor");
        Assert.IsTrue(BoardDetail.Contains("RouteConstants.TaskDetail"), "BoardDetailPage uses RouteConstants.TaskDetail");
        var Dashboard = ReadSource("PrTask.SharedUI", "Pages", "DashboardPage.razor");
        Assert.IsTrue(Dashboard.Contains("RouteConstants.TaskDetail"), "DashboardPage uses RouteConstants.TaskDetail");
        var Payments = ReadSource("PrTask.SharedUI", "Pages", "Client", "PaymentsPage.razor");
        Assert.IsTrue(Payments.Contains("RouteConstants.TaskDetail"), "PaymentsPage uses RouteConstants.TaskDetail");
        var Profile = ReadSource("PrTask.SharedUI", "Pages", "ProfilePage.razor");
        Assert.IsTrue(Profile.Contains("RouteConstants.PullRequestDetail"), "ProfilePage uses RouteConstants.PullRequestDetail");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("No hardcoded route hrefs remain in SharedUI Pages")]
    public void NoHardcodedRouteHrefsInPages()
    {
        var Pages = new[]
        {
            ReadSource("PrTask.SharedUI", "Pages", "BoardsPage.razor"),
            ReadSource("PrTask.SharedUI", "Pages", "BoardDetailPage.razor"),
            ReadSource("PrTask.SharedUI", "Pages", "DashboardPage.razor"),
            ReadSource("PrTask.SharedUI", "Pages", "ProfilePage.razor")
        };
        foreach (var Page in Pages)
        {
            Assert.IsFalse(Page.Contains("href=\"/tasks/@"), "No hardcoded /tasks/@Id href");
            Assert.IsFalse(Page.Contains("href=\"/prs/@"), "No hardcoded /prs/@Id href");
            Assert.IsFalse(Page.Contains("href=\"/boards/@"), "No hardcoded /boards/@Id href");
        }
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SubmitPrPage cancel link uses RouteConstants")]
    public void SubmitPrPageCancelLinkUsesRouteConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "SubmitPrPage.razor");
        Assert.IsTrue(Source.Contains("RouteConstants.TaskDetail"), "Uses RouteConstants.TaskDetail");
        Assert.IsFalse(Source.Contains("href=\"/tasks/@"), "No hardcoded task href");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("EditTaskPage cancel link uses RouteConstants")]
    public void EditTaskPageCancelLinkUsesRouteConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Client", "EditTaskPage.razor");
        Assert.IsTrue(Source.Contains("RouteConstants.TaskDetail"), "Uses RouteConstants.TaskDetail for cancel");
        Assert.IsFalse(Source.Contains("href=\"/tasks/@"), "No hardcoded task href");
    }
}
