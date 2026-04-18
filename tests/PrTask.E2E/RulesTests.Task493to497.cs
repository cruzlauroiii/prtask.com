using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("DeploymentPreviewPage uses DeploymentPreviewConstants for all display text")]
    public void DeploymentPreviewPageUsesPreviewConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "DeploymentPreviewPage.razor");
        Assert.IsTrue(Source.Contains("DeploymentPreviewConstants.SeoTitle"), "Uses SeoTitle");
        Assert.IsTrue(Source.Contains("DeploymentPreviewConstants.PageHeading"), "Uses PageHeading");
        Assert.IsTrue(Source.Contains("DeploymentPreviewConstants.BuildStatusHeading"), "Uses BuildStatusHeading");
        Assert.IsTrue(Source.Contains("DeploymentPreviewConstants.PreviewUrlHeading"), "Uses PreviewUrlHeading");
        Assert.IsTrue(Source.Contains("DeploymentPreviewConstants.OpenLivePreviewText"), "Uses OpenLivePreviewText");
        Assert.IsTrue(Source.Contains("DeploymentPreviewConstants.DetailsHeading"), "Uses DetailsHeading");
        Assert.IsTrue(Source.Contains("DeploymentPreviewConstants.BranchLabel"), "Uses BranchLabel");
        Assert.IsTrue(Source.Contains("DeploymentPreviewConstants.EnvironmentValue"), "Uses EnvironmentValue");
        Assert.IsTrue(Source.Contains("DeploymentPreviewConstants.PlatformValue"), "Uses PlatformValue");
        Assert.IsTrue(Source.Contains("DeploymentPreviewConstants.DeployLogHeading"), "Uses DeployLogHeading");
        Assert.IsFalse(Source.Contains("\"Deployment Preview\""), "No hardcoded page heading");
        Assert.IsFalse(Source.Contains("\"Build Status\""), "No hardcoded build status heading");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("TaskListConstants has all UI text constants for page display")]
    public void TaskListConstantsHasUiText()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "TaskListConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(TaskListConstants.SearchPlaceholder)), "Has SearchPlaceholder");
        Assert.IsTrue(Source.Contains(nameof(TaskListConstants.FilterAll)), "Has FilterAll");
        Assert.IsTrue(Source.Contains(nameof(TaskListConstants.SortByNewest)), "Has SortByNewest");
        Assert.IsTrue(Source.Contains(nameof(TaskListConstants.SortByBounty)), "Has SortByBounty");
        Assert.IsTrue(Source.Contains(nameof(TaskListConstants.SortByComplexity)), "Has SortByComplexity");
        Assert.IsTrue(Source.Contains("SeoTitle"), "Has SeoTitle");
        Assert.IsTrue(Source.Contains("PageHeading"), "Has PageHeading");
        Assert.IsTrue(Source.Contains("PageDescription"), "Has PageDescription");
        Assert.IsTrue(Source.Contains("LoadingText"), "Has LoadingText");
        Assert.IsTrue(Source.Contains("EmptyStateText"), "Has EmptyStateText");
        Assert.IsTrue(Source.Contains("ViewTaskButtonText"), "Has ViewTaskButtonText");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("TaskList page uses TaskListConstants for all UI text")]
    public void TaskListPageUsesConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "TaskList.razor");
        Assert.IsTrue(Source.Contains("TaskListConstants.SearchPlaceholder"), "Uses SearchPlaceholder");
        Assert.IsTrue(Source.Contains("TaskListConstants.SeoTitle") || Source.Contains("TaskListConstants.PageHeading"), "Uses page heading constant");
        Assert.IsTrue(Source.Contains("TaskListConstants.LoadingText"), "Uses LoadingText");
        Assert.IsTrue(Source.Contains("TaskListConstants.EmptyStateText"), "Uses EmptyStateText");
        Assert.IsTrue(Source.Contains("TaskListConstants.ViewTaskButtonText"), "Uses ViewTaskButtonText");
        Assert.IsFalse(Source.Contains("\"Loading tasks...\""), "No hardcoded loading text");
        Assert.IsFalse(Source.Contains("\"No open tasks"), "No hardcoded empty state text");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("TaskList filter options use TaskListConstants label constants")]
    public void TaskListFilterOptionsUseConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "TaskList.razor");
        Assert.IsTrue(Source.Contains("TaskListConstants.AllComplexitiesLabel"), "Uses AllComplexitiesLabel");
        Assert.IsTrue(Source.Contains("TaskListConstants.NewestFirstLabel"), "Uses NewestFirstLabel");
        Assert.IsTrue(Source.Contains("TaskListConstants.HighestBountyLabel"), "Uses HighestBountyLabel");
        Assert.IsTrue(Source.Contains("TaskListConstants.ComplexityLabel"), "Uses ComplexityLabel");
        Assert.IsFalse(Source.Contains("\"All Complexities\""), "No hardcoded All Complexities");
        Assert.IsFalse(Source.Contains("\"Newest First\""), "No hardcoded Newest First");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("TaskList SeoHead uses TaskListConstants")]
    public void TaskListSeoUsesConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "TaskList.razor");
        Assert.IsTrue(Source.Contains("TaskListConstants.SeoTitle"), "Uses SeoTitle for SeoHead");
        Assert.IsTrue(Source.Contains("TaskListConstants.SeoDescription"), "Uses SeoDescription for SeoHead");
        Assert.IsFalse(Source.Contains("\"Browse Tasks - PrTask\""), "No hardcoded SEO title");
    }
}
