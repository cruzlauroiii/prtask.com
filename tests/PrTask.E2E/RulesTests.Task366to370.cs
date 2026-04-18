using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("DeploymentPreviewPage uses DeploymentConstants — no magic strings")]
    public void DeploymentPreviewPageUsesConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "DeploymentPreviewPage.razor");
        Assert.IsTrue(Source.Contains(nameof(DeploymentConstants.StatusReady)), "Uses StatusReady constant");
        Assert.IsTrue(Source.Contains(nameof(DeploymentConstants.StatusDeployed)), "Uses StatusDeployed constant");
        Assert.IsTrue(Source.Contains(nameof(DeploymentConstants.LogCloning)), "Uses LogCloning constant");
        Assert.IsTrue(Source.Contains(nameof(DeploymentConstants.LogInstalling)), "Uses LogInstalling constant");
        Assert.IsTrue(Source.Contains(nameof(DeploymentConstants.LogBuilding)), "Uses LogBuilding constant");
        Assert.IsTrue(Source.Contains(nameof(DeploymentConstants.LogDeploying)), "Uses LogDeploying constant");
        Assert.IsTrue(Source.Contains(nameof(DeploymentConstants.LogWaiting)), "Uses LogWaiting constant");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("DeploymentPreviewPage uses FormatStrings for URLs and log lines")]
    public void DeploymentPreviewPageUsesFormatStrings()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "DeploymentPreviewPage.razor");
        Assert.IsTrue(Source.Contains("FormatStrings.DeployPreviewAddress"), "Uses FormatStrings for preview URL");
        Assert.IsTrue(Source.Contains("FormatStrings.DeployLogLine"), "Uses FormatStrings for log lines");
        Assert.IsTrue(Source.Contains("FormatStrings.DeployLogComplete"), "Uses FormatStrings for complete log");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("DeploymentConstants has all status and log constants")]
    public void DeploymentConstantsComplete()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "DeploymentConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(DeploymentConstants.StatusReady)), "Has StatusReady");
        Assert.IsTrue(Source.Contains(nameof(DeploymentConstants.StatusDeployed)), "Has StatusDeployed");
        Assert.IsTrue(Source.Contains(nameof(DeploymentConstants.LogCloning)), "Has LogCloning");
        Assert.IsTrue(Source.Contains(nameof(DeploymentConstants.LogInstalling)), "Has LogInstalling");
        Assert.IsTrue(Source.Contains(nameof(DeploymentConstants.LogBuilding)), "Has LogBuilding");
        Assert.IsTrue(Source.Contains(nameof(DeploymentConstants.LogDeploying)), "Has LogDeploying");
        Assert.IsTrue(Source.Contains(nameof(DeploymentConstants.LogWaiting)), "Has LogWaiting");
        Assert.IsTrue(Source.Contains(nameof(DeploymentConstants.PreviewUrlFormat)), "Has PreviewUrlFormat");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("DeploymentPreviewPage loads PR data and shows real build status")]
    public void DeploymentPreviewPageRealData()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "DeploymentPreviewPage.razor");
        Assert.IsTrue(Source.Contains("GetByIdAsync"), "Loads PR by deployment ID");
        Assert.IsTrue(Source.Contains("PullRequest.FilesChanged"), "Shows files changed");
        Assert.IsTrue(Source.Contains("PullRequest.Additions"), "Shows additions");
        Assert.IsTrue(Source.Contains("PullRequest.Deletions"), "Shows deletions");
        Assert.IsTrue(Source.Contains("PullRequest.Status"), "Shows PR status");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("FormatStrings has deployment helper methods")]
    public void FormatStringsHasDeploymentMethods()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "FormatStrings.cs");
        Assert.IsTrue(Source.Contains("DeployPreviewAddress"), "Has DeployPreviewAddress");
        Assert.IsTrue(Source.Contains("DeployLogLine"), "Has DeployLogLine");
        Assert.IsTrue(Source.Contains("DeployLogComplete"), "Has DeployLogComplete");
    }
}
