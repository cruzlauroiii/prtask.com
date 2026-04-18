using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("PullRequestDetailPage has no hardcoded example diff")]
    public void PullRequestDetailPageNoHardcodedDiff()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "PullRequestDetailPage.razor");
        Assert.IsFalse(Source.Contains("src/Example.cs"), "No hardcoded src/Example.cs");
        Assert.IsFalse(Source.Contains("var old = GetValue"), "No hardcoded example code");
        Assert.IsTrue(Source.Contains(nameof(DiffConstants.DefaultFileName)), "Uses DiffConstants.DefaultFileName");
        Assert.IsTrue(Source.Contains("PrDetailConstants.NoDiffAvailable"), "Shows empty state when no diff");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("DiffConstants has DefaultFileName")]
    public void DiffConstantsHasDefaultFileName()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "DiffConstants.cs");
        Assert.IsTrue(Source.Contains("DefaultFileName"), "Has DefaultFileName constant");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("PullRequestDetailPage EditableCode is not hardcoded")]
    public void PullRequestDetailPageEditableCodeNotHardcoded()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "PullRequestDetailPage.razor");
        Assert.IsFalse(Source.Contains("using System;\\nvar result"), "No hardcoded editable code");
        Assert.IsTrue(Source.Contains("string.Empty"), "EditableCode starts empty");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("DashboardPage uses IPullRequestService not IPaymentRecordService")]
    public void DashboardPageUsesCorrectService()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "DashboardPage.razor");
        Assert.IsTrue(Source.Contains("IPullRequestService"), "Injects IPullRequestService");
        Assert.IsFalse(Source.Contains("IPaymentRecordService"), "Does not inject IPaymentRecordService");
        Assert.IsTrue(Source.Contains("DashboardConstants.ActiveTasksLabel"), "Shows Active Tasks stat");
        Assert.IsTrue(Source.Contains("DashboardConstants.UsersLabel"), "Shows Users stat");
        Assert.IsTrue(Source.Contains("DashboardConstants.TotalBountiesLabel"), "Shows Total Bounties stat");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("All pages use OnAfterRenderAsync for JS interop auth")]
    public void AllPagesUseOnAfterRenderAsyncForAuth()
    {
        var BoardsSource = ReadSource("PrTask.SharedUI", "Pages", "BoardsPage.razor");
        Assert.IsTrue(BoardsSource.Contains("OnAfterRenderAsync"), "BoardsPage uses OnAfterRenderAsync");
        var SprintsSource = ReadSource("PrTask.SharedUI", "Pages", "SprintsPage.razor");
        Assert.IsTrue(SprintsSource.Contains("OnAfterRenderAsync"), "SprintsPage uses OnAfterRenderAsync");
        var CreateTaskSource = ReadSource("PrTask.SharedUI", "Pages", "Client", "CreateTaskPage.razor");
        Assert.IsTrue(CreateTaskSource.Contains("OnAfterRenderAsync"), "CreateTaskPage uses OnAfterRenderAsync");
        var RepoSource = ReadSource("PrTask.SharedUI", "Pages", "Client", "RepositoryPage.razor");
        Assert.IsTrue(RepoSource.Contains("OnAfterRenderAsync"), "RepositoryPage uses OnAfterRenderAsync");
        var SubmitPrSource = ReadSource("PrTask.SharedUI", "Pages", "SubmitPrPage.razor");
        Assert.IsTrue(SubmitPrSource.Contains("OnAfterRenderAsync"), "SubmitPrPage uses OnAfterRenderAsync");
    }
}
