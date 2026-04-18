using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("NavMenu uses RouteConstants for all navigation links")]
    public void NavMenuUsesRouteConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(Source.Contains("RouteConstants.Home"), "Uses RouteConstants.Home");
        Assert.IsTrue(Source.Contains("RouteConstants.Tasks"), "Uses RouteConstants.Tasks");
        Assert.IsTrue(Source.Contains("RouteConstants.Leaderboard"), "Uses RouteConstants.Leaderboard");
        Assert.IsTrue(Source.Contains("RouteConstants.HowItWorks"), "Uses RouteConstants.HowItWorks");
        Assert.IsTrue(Source.Contains("RouteConstants.Pricing"), "Uses RouteConstants.Pricing");
        Assert.IsTrue(Source.Contains("RouteConstants.About"), "Uses RouteConstants.About");
        Assert.IsTrue(Source.Contains("RouteConstants.Dashboard"), "Uses RouteConstants.Dashboard");
        Assert.IsTrue(Source.Contains("RouteConstants.ClientCreateTask"), "Uses RouteConstants.ClientCreateTask");
        Assert.IsTrue(Source.Contains("RouteConstants.ClientPayments"), "Uses RouteConstants.ClientPayments");
        Assert.IsTrue(Source.Contains("RouteConstants.Sprints"), "Uses RouteConstants.Sprints");
        Assert.IsTrue(Source.Contains("RouteConstants.Boards"), "Uses RouteConstants.Boards");
        Assert.IsTrue(Source.Contains("RouteConstants.Download"), "Uses RouteConstants.Download");
        Assert.IsTrue(Source.Contains("RouteConstants.Settings"), "Uses RouteConstants.Settings");
        Assert.IsTrue(Source.Contains("RouteConstants.Login"), "Uses RouteConstants.Login");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("NavMenu has no hardcoded route strings in NavigateTo calls")]
    public void NavMenuNoHardcodedRoutes()
    {
        var Source = ReadSource("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsFalse(Source.Contains("NavigateTo(\"/"), "No hardcoded NavigateTo paths");
        Assert.IsTrue(Source.Contains("RouteConstants.Terms"), "Uses RouteConstants.Terms");
        Assert.IsTrue(Source.Contains("RouteConstants.Privacy"), "Uses RouteConstants.Privacy");
        Assert.IsTrue(Source.Contains("RouteConstants.CookiePolicy"), "Uses RouteConstants.CookiePolicy");
        Assert.IsTrue(Source.Contains("RouteConstants.AcceptableUse"), "Uses RouteConstants.AcceptableUse");
        Assert.IsTrue(Source.Contains("RouteConstants.Refund"), "Uses RouteConstants.Refund");
        Assert.IsTrue(Source.Contains("RouteConstants.Licenses"), "Uses RouteConstants.Licenses");
        Assert.IsTrue(Source.Contains("RouteConstants.Accessibility"), "Uses RouteConstants.Accessibility");
        Assert.IsTrue(Source.Contains("RouteConstants.Dmca"), "Uses RouteConstants.Dmca");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("DashboardPage uses RouteConstants for create task link")]
    public void DashboardPageUsesRouteConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "DashboardPage.razor");
        Assert.IsTrue(Source.Contains("RouteConstants.ClientCreateTask"), "Uses RouteConstants.ClientCreateTask");
        Assert.IsFalse(Source.Contains("href=\"/client/create-task\""), "No hardcoded create task href");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("HowItWorks uses RouteConstants for static workflow links")]
    public void HowItWorksUsesRouteConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "HowItWorks.razor");
        Assert.IsTrue(Source.Contains("RouteConstants.Login"), "Uses RouteConstants.Login");
        Assert.IsTrue(Source.Contains("RouteConstants.Settings"), "Uses RouteConstants.Settings");
        Assert.IsTrue(Source.Contains("RouteConstants.ClientCreateTask"), "Uses RouteConstants.ClientCreateTask");
        Assert.IsTrue(Source.Contains("RouteConstants.Tasks"), "Uses RouteConstants.Tasks");
        Assert.IsTrue(Source.Contains("RouteConstants.ClientPayments"), "Uses RouteConstants.ClientPayments");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("HowItWorks uses DemoSeedConstants for demo links")]
    public void HowItWorksUsesDemoSeedConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "HowItWorks.razor");
        Assert.IsTrue(Source.Contains("DemoSeedConstants.TaskId"), "Uses DemoSeedConstants.TaskId");
        Assert.IsTrue(Source.Contains("DemoSeedConstants.PrId"), "Uses DemoSeedConstants.PrId");
        Assert.IsTrue(Source.Contains("RouteConstants.TaskDetail"), "Uses RouteConstants.TaskDetail");
        Assert.IsTrue(Source.Contains("RouteConstants.PullRequestDetail"), "Uses RouteConstants.PullRequestDetail");
        Assert.IsTrue(Source.Contains("RouteConstants.SubmitPr"), "Uses RouteConstants.SubmitPr");
        Assert.IsFalse(Source.Contains("href=\"/tasks/demo-task\""), "No hardcoded demo task href");
        Assert.IsFalse(Source.Contains("href=\"/prs/demo-pr\""), "No hardcoded demo PR href");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("DashboardPage uses RouteConstants for create task link")]
    public void DashboardPageUsesRouteConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "DashboardPage.razor");
        Assert.IsTrue(Source.Contains("RouteConstants.ClientCreateTask"), "Uses RouteConstants.ClientCreateTask");
        Assert.IsFalse(Source.Contains("href=\"/client/create-task\""), "No hardcoded create task href");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("HowItWorks uses RouteConstants for static workflow links")]
    public void HowItWorksUsesRouteConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "HowItWorks.razor");
        Assert.IsTrue(Source.Contains("RouteConstants.Login"), "Uses RouteConstants.Login");
        Assert.IsTrue(Source.Contains("RouteConstants.Settings"), "Uses RouteConstants.Settings");
        Assert.IsTrue(Source.Contains("RouteConstants.ClientCreateTask"), "Uses RouteConstants.ClientCreateTask");
        Assert.IsTrue(Source.Contains("RouteConstants.Tasks"), "Uses RouteConstants.Tasks");
        Assert.IsTrue(Source.Contains("RouteConstants.ClientPayments"), "Uses RouteConstants.ClientPayments");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("HowItWorks uses DemoSeedConstants for demo links")]
    public void HowItWorksUsesDemoSeedConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "HowItWorks.razor");
        Assert.IsTrue(Source.Contains("DemoSeedConstants.TaskId"), "Uses DemoSeedConstants.TaskId");
        Assert.IsTrue(Source.Contains("DemoSeedConstants.PrId"), "Uses DemoSeedConstants.PrId");
        Assert.IsTrue(Source.Contains("RouteConstants.TaskDetail"), "Uses RouteConstants.TaskDetail");
        Assert.IsTrue(Source.Contains("RouteConstants.PullRequestDetail"), "Uses RouteConstants.PullRequestDetail");
        Assert.IsTrue(Source.Contains("RouteConstants.SubmitPr"), "Uses RouteConstants.SubmitPr");
        Assert.IsFalse(Source.Contains("href=\"/tasks/demo-task\""), "No hardcoded demo task href");
        Assert.IsFalse(Source.Contains("href=\"/prs/demo-pr\""), "No hardcoded demo PR href");
    }
}
