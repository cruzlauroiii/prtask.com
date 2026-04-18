using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("FooterSection uses RouteConstants for all links")]
    public void FooterSectionUsesRouteConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Components", "FooterSection.razor");
        Assert.IsTrue(Source.Contains("RouteConstants.Tasks"), "Uses RouteConstants.Tasks");
        Assert.IsTrue(Source.Contains("RouteConstants.ClientCreateTask"), "Uses RouteConstants.ClientCreateTask");
        Assert.IsTrue(Source.Contains("RouteConstants.ClientPayments"), "Uses RouteConstants.ClientPayments");
        Assert.IsTrue(Source.Contains("RouteConstants.Sprints"), "Uses RouteConstants.Sprints");
        Assert.IsTrue(Source.Contains("RouteConstants.Boards"), "Uses RouteConstants.Boards");
        Assert.IsTrue(Source.Contains("RouteConstants.Leaderboard"), "Uses RouteConstants.Leaderboard");
        Assert.IsTrue(Source.Contains("RouteConstants.HowItWorks"), "Uses RouteConstants.HowItWorks");
        Assert.IsTrue(Source.Contains("RouteConstants.Pricing"), "Uses RouteConstants.Pricing");
        Assert.IsTrue(Source.Contains("RouteConstants.About"), "Uses RouteConstants.About");
        Assert.IsTrue(Source.Contains("RouteConstants.Terms"), "Uses RouteConstants.Terms");
        Assert.IsTrue(Source.Contains("RouteConstants.Privacy"), "Uses RouteConstants.Privacy");
        Assert.IsTrue(Source.Contains("RouteConstants.Refund"), "Uses RouteConstants.Refund");
        Assert.IsTrue(Source.Contains("RouteConstants.Licenses"), "Uses RouteConstants.Licenses");
        Assert.IsTrue(Source.Contains("RouteConstants.AcceptableUse"), "Uses RouteConstants.AcceptableUse");
        Assert.IsTrue(Source.Contains("RouteConstants.CookiePolicy"), "Uses RouteConstants.CookiePolicy");
        Assert.IsTrue(Source.Contains("RouteConstants.Accessibility"), "Uses RouteConstants.Accessibility");
        Assert.IsTrue(Source.Contains("RouteConstants.Dmca"), "Uses RouteConstants.Dmca");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("FooterSection has no hardcoded route strings")]
    public void FooterSectionNoHardcodedRoutes()
    {
        var Source = ReadSource("PrTask.SharedUI", "Components", "FooterSection.razor");
        Assert.IsFalse(Source.Contains("href=\"/tasks\""), "No hardcoded /tasks href");
        Assert.IsFalse(Source.Contains("href=\"/client/"), "No hardcoded /client/ href");
        Assert.IsFalse(Source.Contains("href=\"/legal/terms\""), "No hardcoded /legal/terms href");
        Assert.IsFalse(Source.Contains("href=\"/about\""), "No hardcoded /about href");
        Assert.IsFalse(Source.Contains("href=\"/leaderboard\""), "No hardcoded /leaderboard href");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("FormatStrings has centralized BountyAmount method")]
    public void FormatStringsBountyAmountExists()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "FormatStrings.cs");
        Assert.IsTrue(Source.Contains("BountyAmount"), "Has BountyAmount method");
        Assert.IsTrue(Source.Contains("BountyDisplayFormat"), "Uses BountyDisplayFormat");
        Assert.IsTrue(Source.Contains("CentsToDollarsDivisor"), "Uses CentsToDollarsDivisor");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("All pages delegate bounty formatting to FormatStrings.BountyAmount")]
    public void AllPagesDelegateToBountyAmount()
    {
        var Pages = new[]
        {
            ReadSource("PrTask.SharedUI", "Pages", "DashboardPage.razor"),
            ReadSource("PrTask.SharedUI", "Pages", "TaskList.razor"),
            ReadSource("PrTask.SharedUI", "Pages", "TaskDetailPage.razor"),
            ReadSource("PrTask.SharedUI", "Pages", "LeaderboardPage.razor"),
            ReadSource("PrTask.SharedUI", "Pages", "ProfilePage.razor"),
            ReadSource("PrTask.SharedUI", "Pages", "Client", "PaymentsPage.razor")
        };
        foreach (var Page in Pages)
        {
            Assert.IsTrue(Page.Contains("FormatStrings.BountyAmount"), "Uses FormatStrings.BountyAmount");
        }
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("No duplicate bounty format logic in pages")]
    public void NoDuplicateBountyFormatLogic()
    {
        var Pages = new[]
        {
            ReadSource("PrTask.SharedUI", "Pages", "DashboardPage.razor"),
            ReadSource("PrTask.SharedUI", "Pages", "TaskList.razor"),
            ReadSource("PrTask.SharedUI", "Pages", "TaskDetailPage.razor"),
            ReadSource("PrTask.SharedUI", "Pages", "LeaderboardPage.razor"),
            ReadSource("PrTask.SharedUI", "Pages", "ProfilePage.razor"),
            ReadSource("PrTask.SharedUI", "Pages", "Client", "PaymentsPage.razor")
        };
        foreach (var Page in Pages)
        {
            Assert.IsFalse(Page.Contains("string.Format(AppConstants.BountyDisplayFormat"), "No inline BountyDisplayFormat");
        }
    }
}
