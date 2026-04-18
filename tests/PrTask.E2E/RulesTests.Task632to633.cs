namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("DashboardPage shows recent pull requests section")]
    public void DashboardPageShowsRecentPrs()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "DashboardPage.razor");
        Assert.IsTrue(Source.Contains("IPullRequestService"),
            "DashboardPage must inject IPullRequestService");
        Assert.IsTrue(Source.Contains("ListRecentAsync"),
            "DashboardPage must call ListRecentAsync");
        Assert.IsTrue(Source.Contains("DashboardConstants.RecentPrsHeading") || Source.Contains("DashboardRecentPrsHeading"),
            "DashboardPage must use RecentPrsHeading via constant or localization");
        Assert.IsTrue(Source.Contains("DashboardConstants.PrsLabel") || Source.Contains("DashboardPrsLabel"),
            "DashboardPage must use PrsLabel via constant or localization");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("DashboardConstants defines PR display constants")]
    public void DashboardConstantsDefinesPrConstants()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "DashboardConstants.cs");
        Assert.IsTrue(Source.Contains("RecentPrsHeading"), "Must define RecentPrsHeading");
        Assert.IsTrue(Source.Contains("PrsLabel"), "Must define PrsLabel");
        Assert.IsTrue(Source.Contains("NoPrsText"), "Must define NoPrsText");
        Assert.IsTrue(Source.Contains("RecentPrLimit"), "Must define RecentPrLimit");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("PullRequestEndpoints has GET recent route")]
    public void PullRequestEndpointsHasRecentRoute()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "PullRequestEndpoints.cs");
        Assert.IsTrue(Source.Contains("SubRecent"),
            "PullRequestEndpoints must have SubRecent route");
        Assert.IsTrue(Source.Contains("ListRecentAsync"),
            "PullRequestEndpoints must call ListRecentAsync");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("IPullRequestService defines ListRecentAsync")]
    public void PullRequestServiceDefinesListRecent()
    {
        var Source = ReadSource("PrTask.Application", "Services", "IPullRequestService.cs");
        Assert.IsTrue(Source.Contains("ListRecentAsync"),
            "IPullRequestService must define ListRecentAsync");
    }
}
