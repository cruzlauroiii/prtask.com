using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("All pages use FormatStrings.BountyAmount — no inline dollar formatting")]
    public void AllPagesUseConstantFormatting()
    {
        var Dashboard = ReadSource("PrTask.SharedUI", "Pages", "DashboardPage.razor");
        var Leaderboard = ReadSource("PrTask.SharedUI", "Pages", "LeaderboardPage.razor");
        var TaskListSrc = ReadSource("PrTask.SharedUI", "Pages", "TaskList.razor");
        var Payments = ReadSource("PrTask.SharedUI", "Pages", "Client", "PaymentsPage.razor");
        var Profile = ReadSource("PrTask.SharedUI", "Pages", "ProfilePage.razor");
        Assert.IsTrue(Dashboard.Contains("FormatStrings.BountyAmount"), "Dashboard uses FormatStrings.BountyAmount");
        Assert.IsTrue(Leaderboard.Contains("FormatStrings.BountyAmount"), "Leaderboard uses FormatStrings.BountyAmount");
        Assert.IsTrue(TaskListSrc.Contains("FormatStrings.BountyAmount"), "TaskList uses FormatStrings.BountyAmount");
        Assert.IsTrue(Payments.Contains("FormatStrings.BountyAmount"), "Payments uses FormatStrings.BountyAmount");
        Assert.IsTrue(Profile.Contains("FormatStrings.BountyAmount"), "Profile uses FormatStrings.BountyAmount");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("DashboardPage uses Domain.Constants for formatting")]
    public void DashboardPageUsesConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "DashboardPage.razor");
        Assert.IsTrue(Source.Contains("PrTask.Domain.Constants"), "Imports Domain.Constants");
        Assert.IsTrue(Source.Contains("FormatStrings.BountyAmount"), "Uses FormatStrings.BountyAmount");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("LeaderboardPage uses Domain.Constants for formatting")]
    public void LeaderboardPageUsesConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "LeaderboardPage.razor");
        Assert.IsTrue(Source.Contains("PrTask.Domain.Constants"), "Imports Domain.Constants");
        Assert.IsTrue(Source.Contains("FormatStrings.BountyAmount"), "Uses FormatStrings.BountyAmount");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("TaskList uses Domain.Constants for formatting")]
    public void TaskListUsesConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "TaskList.razor");
        Assert.IsTrue(Source.Contains("PrTask.Domain.Constants"), "Imports Domain.Constants");
        Assert.IsTrue(Source.Contains("FormatStrings.BountyAmount"), "Uses FormatStrings.BountyAmount");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("No pages use inline dollar formatting pattern")]
    public void NoPagesUseInlineDollarFormat()
    {
        var Pages = new[]
        {
            ReadSource("PrTask.SharedUI", "Pages", "DashboardPage.razor"),
            ReadSource("PrTask.SharedUI", "Pages", "LeaderboardPage.razor"),
            ReadSource("PrTask.SharedUI", "Pages", "TaskList.razor"),
            ReadSource("PrTask.SharedUI", "Pages", "Client", "PaymentsPage.razor"),
            ReadSource("PrTask.SharedUI", "Pages", "ProfilePage.razor")
        };
        foreach (var Page in Pages)
        {
            Assert.IsFalse(Page.Contains("$\"${"), "No inline $\"${ dollar formatting");
        }
    }
}
