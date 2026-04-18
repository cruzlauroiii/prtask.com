using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SettingsPage auto-loads profile from auth context")]
    public void SettingsPageAutoLoadsProfile()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "SettingsPage.razor.cs");
        Assert.IsTrue(Source.Contains("IJSRuntime"), "Injects IJSRuntime");
        Assert.IsTrue(Source.Contains(nameof(JsInteropConstants.GetUserId)), "Uses GetUserId");
        Assert.IsTrue(Source.Contains("OnAfterRenderAsync"), "Has OnAfterRenderAsync");
        Assert.IsTrue(Source.Contains("LoadProfileAsync"), "Calls LoadProfileAsync on auto-load");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SubmitPrPage auto-fills DeveloperId from auth")]
    public void SubmitPrPageAutoFillsDeveloperId()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "SubmitPrPage.razor");
        Assert.IsTrue(Source.Contains("IJSRuntime"), "Injects IJSRuntime");
        Assert.IsTrue(Source.Contains(nameof(JsInteropConstants.GetUserId)), "Uses GetUserId");
        Assert.IsTrue(Source.Contains("OnAfterRenderAsync"), "Has OnAfterRenderAsync");
        Assert.IsTrue(Source.Contains("DeveloperId"), "Sets DeveloperId from auth");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("DashboardPage shows Total Bounties stat from open tasks")]
    public void DashboardPageShowsTotalBounties()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "DashboardPage.razor");
        Assert.IsTrue(Source.Contains("TotalBountyCents"), "Has TotalBountyCents property");
        Assert.IsTrue(Source.Contains("DashboardConstants.TotalBountiesLabel"), "Shows Total Bounties label");
        Assert.IsTrue(Source.Contains("FormatAmount"), "Formats bounty amount");
        Assert.IsTrue(Source.Contains("BountyAmountCents"), "Computes from BountyAmountCents");
        Assert.IsFalse(Source.Contains("IPaymentRecordService"), "No longer uses IPaymentRecordService");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("TaskDetailPage and PullRequestDetailPage use auth for user actions")]
    public void TaskAndPrDetailPagesUseAuth()
    {
        var TaskSource = ReadSource("PrTask.SharedUI", "Pages", "TaskDetailPage.razor");
        Assert.IsTrue(TaskSource.Contains("IJSRuntime"), "TaskDetailPage injects IJSRuntime");
        Assert.IsTrue(TaskSource.Contains(nameof(JsInteropConstants.GetUserId)), "TaskDetailPage uses GetUserId");
        Assert.IsTrue(TaskSource.Contains("CurrentUserId"), "TaskDetailPage has CurrentUserId");
        var PrSource = ReadSource("PrTask.SharedUI", "Pages", "PullRequestDetailPage.razor");
        Assert.IsTrue(PrSource.Contains("IJSRuntime"), "PullRequestDetailPage injects IJSRuntime");
        Assert.IsTrue(PrSource.Contains(nameof(JsInteropConstants.GetUserId)), "PullRequestDetailPage uses GetUserId");
        Assert.IsTrue(PrSource.Contains("CurrentUserId"), "PullRequestDetailPage has CurrentUserId");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("ClientLayout uses JsInteropConstants for theme")]
    public void ClientLayoutUsesJsInteropConstants()
    {
        var Source = ReadSource("PrTask.Client", "Components", "ClientLayout.razor");
        Assert.IsTrue(Source.Contains(nameof(JsInteropConstants.GetTheme)), "Uses GetTheme constant");
        Assert.IsTrue(Source.Contains(nameof(JsInteropConstants.ToggleTheme)), "Uses ToggleTheme constant");
    }
}
