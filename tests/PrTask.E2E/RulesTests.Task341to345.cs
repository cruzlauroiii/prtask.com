namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("ClientDashboardPage is a thin wrapper for SharedUI DashboardPage")]
    public void ClientDashboardPageIsWrapper()
    {
        var Source = ReadSource("PrTask.Client", "Pages", "ClientDashboardPage.razor");
        Assert.IsTrue(Source.Contains("DashboardPage"), "Wraps SharedUI DashboardPage");
        Assert.IsFalse(Source.Contains("stat-value"), "No inline stat rendering");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("ClientTaskListPage is a thin wrapper for SharedUI TaskList")]
    public void ClientTaskListPageIsWrapper()
    {
        var Source = ReadSource("PrTask.Client", "Pages", "ClientTaskListPage.razor");
        Assert.IsTrue(Source.Contains("TaskList"), "Wraps SharedUI TaskList");
        Assert.IsFalse(Source.Contains("HttpClient"), "No direct HttpClient usage");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("ClientLeaderboardPage is a thin wrapper for SharedUI LeaderboardPage")]
    public void ClientLeaderboardPageIsWrapper()
    {
        var Source = ReadSource("PrTask.Client", "Pages", "ClientLeaderboardPage.razor");
        Assert.IsTrue(Source.Contains("LeaderboardPage"), "Wraps SharedUI LeaderboardPage");
        Assert.IsFalse(Source.Contains("HttpClient"), "No direct HttpClient usage");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("All Client pages that have SharedUI equivalents must be thin wrappers")]
    public void ClientPagesAreThinWrappers()
    {
        var WrapperPages = new[]
        {
            ("ClientBoardsPage.razor", "BoardsPage"),
            ("ClientBoardDetailPage.razor", "BoardDetailPage"),
            ("ClientSprintsPage.razor", "SprintsPage"),
            ("ClientDashboardPage.razor", "DashboardPage"),
            ("ClientTaskListPage.razor", "TaskList"),
            ("ClientLeaderboardPage.razor", "LeaderboardPage"),
            ("ClientSettingsPage.razor", "SettingsPage"),
            ("ClientPaymentsPage.razor", "PaymentsPage"),
            ("ClientDownloadPage.razor", "DownloadPage")
        };
        foreach (var (FileName, SharedComponent) in WrapperPages)
        {
            var Source = ReadSource("PrTask.Client", "Pages", FileName);
            Assert.IsTrue(Source.Contains(SharedComponent),
                $"{FileName} must wrap SharedUI {SharedComponent}");
        }
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("No Client pages have hardcoded zero stats")]
    public void NoClientPagesHaveHardcodedZeroStats()
    {
        var PagesDir = Path.Combine(SourceRoot, "PrTask.Client", "Pages");
        var AllRazorFiles = Directory.GetFiles(PagesDir, "*.razor", SearchOption.AllDirectories);
        foreach (var FilePath in AllRazorFiles)
        {
            var FileName = Path.GetFileName(FilePath);
            var Content = File.ReadAllText(FilePath);
            if (Content.Contains("<span class=\"stat-value\">0</span>"))
            {
                Assert.Fail($"{FileName} has hardcoded zero stat values — should delegate to SharedUI");
            }
        }
    }
}
