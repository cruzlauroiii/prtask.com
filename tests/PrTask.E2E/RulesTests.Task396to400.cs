using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("PrConstants has status message constants for PR actions")]
    public void PrConstantsComplete()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "PrConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(PrConstants.StatusChangesSaved)), "Has StatusChangesSaved");
        Assert.IsTrue(Source.Contains(nameof(PrConstants.StatusApprovedMerged)), "Has StatusApprovedMerged");
        Assert.IsTrue(Source.Contains(nameof(PrConstants.StatusChangesRequested)), "Has StatusChangesRequested");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("PullRequestDetailPage uses PrConstants for status messages")]
    public void PullRequestDetailPageUsesPrConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "PullRequestDetailPage.razor");
        Assert.IsTrue(Source.Contains(nameof(PrConstants.StatusChangesSaved)), "Uses StatusChangesSaved");
        Assert.IsTrue(Source.Contains(nameof(PrConstants.StatusApprovedMerged)), "Uses StatusApprovedMerged");
        Assert.IsTrue(Source.Contains(nameof(PrConstants.StatusChangesRequested)), "Uses StatusChangesRequested");
        Assert.IsFalse(Source.Contains("\"Changes saved"), "No hardcoded changes saved string");
        Assert.IsFalse(Source.Contains("\"Pull request approved"), "No hardcoded approved string");
        Assert.IsFalse(Source.Contains("\"Changes requested on"), "No hardcoded changes requested string");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("RepositoryConstants has status message constants")]
    public void RepositoryConstantsComplete()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "RepositoryConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(RepositoryConstants.StatusUrlRequired)), "Has StatusUrlRequired");
        Assert.IsTrue(Source.Contains(nameof(RepositoryConstants.StatusAdded)), "Has StatusAdded");
        Assert.IsTrue(Source.Contains(nameof(RepositoryConstants.StatusRemoved)), "Has StatusRemoved");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("RepositoryPage uses RepositoryConstants for status messages")]
    public void RepositoryPageUsesRepositoryConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Client", "RepositoryPage.razor");
        Assert.IsTrue(Source.Contains(nameof(RepositoryConstants.StatusUrlRequired)), "Uses StatusUrlRequired");
        Assert.IsTrue(Source.Contains(nameof(RepositoryConstants.StatusAdded)), "Uses StatusAdded");
        Assert.IsTrue(Source.Contains(nameof(RepositoryConstants.StatusRemoved)), "Uses StatusRemoved");
        Assert.IsFalse(Source.Contains("\"Repository URL is required"), "No hardcoded URL required string");
        Assert.IsFalse(Source.Contains("\"Repository added"), "No hardcoded added string");
        Assert.IsFalse(Source.Contains("\"Repository removed"), "No hardcoded removed string");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("TaskVisibilityConstants used for default visibility in CreateTaskPage and EditTaskPage")]
    public void TaskVisibilityConstantsUsed()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "TaskVisibilityConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(TaskVisibilityConstants.Public)), "Has Public constant");
        Assert.IsTrue(Source.Contains(nameof(TaskVisibilityConstants.Private)), "Has Private constant");
        var Create = ReadSource("PrTask.SharedUI", "Pages", "Client", "CreateTaskPage.razor");
        Assert.IsTrue(Create.Contains(nameof(TaskVisibilityConstants.Public)), "CreateTaskPage uses TaskVisibilityConstants.Public");
        Assert.IsFalse(Create.Contains("= \"Public\""), "CreateTaskPage no hardcoded Public default");
        var Edit = ReadSource("PrTask.SharedUI", "Pages", "Client", "EditTaskPage.razor");
        Assert.IsTrue(Edit.Contains(nameof(TaskVisibilityConstants.Public)), "EditTaskPage uses TaskVisibilityConstants.Public");
        Assert.IsFalse(Edit.Contains("= \"Public\""), "EditTaskPage no hardcoded Public default");
    }
}
