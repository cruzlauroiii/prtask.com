using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task245 LeaderboardPage — tabs, table, ILeaderboardService")]
    public async Task LeaderboardPageStructureAsync()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "LeaderboardPage.razor");
        Assert.IsTrue(Source.Contains("@page \"/Leaderboard\""), "Has /leaderboard route");
        Assert.IsTrue(Source.Contains("ILeaderboardService"), "Injects ILeaderboardService");
        Assert.IsTrue(Source.Contains("LeaderboardConstants.TopEarnersTab"), "Has Top Earners tab");
        Assert.IsTrue(Source.Contains("LeaderboardConstants.TopSpendersTab"), "Has Top Spenders tab");
        Assert.IsTrue(Source.Contains("GetTopAsync"), "Calls GetTopAsync");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task246 SprintsPage — create form, sprint cards, ISprintService")]
    public async Task SprintsPageStructureAsync()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "SprintsPage.razor");
        Assert.IsTrue(Source.Contains("@page \"/Sprints\""), "Has /sprints route");
        Assert.IsTrue(Source.Contains("ISprintService"), "Injects ISprintService");
        Assert.IsTrue(Source.Contains("CreateAsync"), "Calls CreateAsync");
        Assert.IsTrue(Source.Contains("DeleteAsync"), "Calls DeleteAsync");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task247 BoardsPage — create form, board cards, IBoardService")]
    public async Task BoardsPageStructureAsync()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "BoardsPage.razor");
        Assert.IsTrue(Source.Contains("@page \"/Boards\""), "Has /boards route");
        Assert.IsTrue(Source.Contains("IBoardService"), "Injects IBoardService");
        Assert.IsTrue(Source.Contains("CreateAsync"), "Calls CreateAsync");
        Assert.IsTrue(Source.Contains("DeleteAsync"), "Calls DeleteAsync");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task248 PullRequestDetailPage — diff viewer, comments, approve/reject")]
    public async Task PullRequestDetailPageStructureAsync()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "PullRequestDetailPage.razor");
        Assert.IsTrue(Source.Contains("IPullRequestService"), "Injects IPullRequestService");
        Assert.IsTrue(Source.Contains("IReviewCommentService"), "Injects IReviewCommentService");
        Assert.IsTrue(Source.Contains("ISourceCodeService"), "Injects ISourceCodeService");
        Assert.IsTrue(Source.Contains("GenerateDiffAsync"), "Calls GenerateDiffAsync");
        Assert.IsTrue(Source.Contains("ApproveAsync"), "Has approve capability");
        Assert.IsTrue(Source.Contains("RejectAsync"), "Has reject capability");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task249 SubmitPrPage — PR submission form with GitHub URL")]
    public async Task SubmitPrPageStructureAsync()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "SubmitPrPage.razor");
        Assert.IsTrue(Source.Contains("IPullRequestService"), "Injects IPullRequestService");
        Assert.IsTrue(Source.Contains("ITaskService"), "Injects ITaskService");
        Assert.IsTrue(Source.Contains("SubmitAsync"), "Calls SubmitAsync");
        Assert.IsTrue(Source.Contains("NavigationManager"), "Uses NavigationManager");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task250 DashboardPage — stats cards, task grid, service calls")]
    public async Task DashboardPageStructureAsync()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "DashboardPage.razor");
        Assert.IsTrue(Source.Contains("@page \"/Dashboard\""), "Has /dashboard route");
        Assert.IsTrue(Source.Contains("ITaskService"), "Injects ITaskService");
        Assert.IsTrue(Source.Contains("IUserService"), "Injects IUserService");
        Assert.IsTrue(Source.Contains("ListOpenAsync"), "Calls ListOpenAsync");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task251 ProfilePage — avatar, earnings, leaderboard rank")]
    public async Task ProfilePageStructureAsync()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "ProfilePage.razor");
        Assert.IsTrue(Source.Contains("IUserService"), "Injects IUserService");
        Assert.IsTrue(Source.Contains("ILeaderboardService"), "Injects ILeaderboardService");
        Assert.IsTrue(Source.Contains("GetByIdAsync"), "Calls GetByIdAsync");
        Assert.IsTrue(Source.Contains("GetRankAsync"), "Calls GetRankAsync");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task252 Cloudflare D1 config in appsettings.Development.json")]
    public async Task CloudflareD1ConfigExistsAsync()
    {
        var ServerDir = Path.Combine(SourceRoot, "PrTask.Server");
        var Config = File.ReadAllText(Path.Combine(ServerDir, "appsettings.Development.json"));
        Assert.IsTrue(Config.Contains("Cloudflare"), "Has Cloudflare section");
        Assert.IsTrue(Config.Contains("AccountId"), "Has AccountId");
        Assert.IsTrue(Config.Contains("D1DatabaseId"), "Has D1DatabaseId");
        Assert.IsTrue(Config.Contains("ApiToken"), "Has ApiToken");
        await Task.CompletedTask;
    }
}
