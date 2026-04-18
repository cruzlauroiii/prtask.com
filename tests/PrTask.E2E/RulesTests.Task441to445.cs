using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("TaskDetailPage uses TaskDetailConstants")]
    public void TaskDetailPageUsesTaskDetailConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "TaskDetailPage.razor");
        Assert.IsTrue(Source.Contains("TaskDetailConstants.LoadingText"), "Uses LoadingText");
        Assert.IsTrue(Source.Contains("TaskDetailConstants.SourceCodeHeading"), "Uses SourceCodeHeading");
        Assert.IsTrue(Source.Contains("TaskDetailConstants.SourceCodeDescription"), "Uses SourceCodeDescription");
        Assert.IsTrue(Source.Contains("TaskDetailConstants.PullRequestsHeading"), "Uses PullRequestsHeading");
        Assert.IsTrue(Source.Contains("TaskDetailConstants.EmptyPrState"), "Uses EmptyPrState");
        Assert.IsTrue(Source.Contains("TaskDetailConstants.ClaimButtonText"), "Uses ClaimButtonText");
        Assert.IsTrue(Source.Contains("TaskDetailConstants.EditButtonText"), "Uses EditButtonText");
        Assert.IsTrue(Source.Contains("TaskDetailConstants.DeleteButtonText"), "Uses DeleteButtonText");
        Assert.IsTrue(Source.Contains("TaskDetailConstants.SubmitPrButtonText"), "Uses SubmitPrButtonText");
        Assert.IsTrue(Source.Contains("TaskDetailConstants.ApproveButtonText"), "Uses ApproveButtonText");
        Assert.IsTrue(Source.Contains("TaskDetailConstants.ViewDiffButtonText"), "Uses ViewDiffButtonText");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("TaskDetailPage date format uses TaskDetailConstants")]
    public void TaskDetailPageDateFormatUsesConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "TaskDetailPage.razor");
        Assert.IsTrue(Source.Contains("TaskDetailConstants.DeadlineDateFormat"), "Uses DeadlineDateFormat");
        Assert.IsFalse(Source.Contains("\"MMM dd, yyyy\""), "No hardcoded date format");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("TaskDetailPage status/deadline labels use constants")]
    public void TaskDetailPageLabelsUseConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "TaskDetailPage.razor");
        Assert.IsTrue(Source.Contains("TaskDetailConstants.StatusLabel"), "Uses StatusLabel");
        Assert.IsTrue(Source.Contains("TaskDetailConstants.DeadlineLabel"), "Uses DeadlineLabel");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SubmitPrConstants has UI text")]
    public void SubmitPrConstantsHasUiText()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "SubmitPrConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(SubmitPrConstants.PageTitle)), "Has PageTitle");
        Assert.IsTrue(Source.Contains(nameof(SubmitPrConstants.LoadingText)), "Has LoadingText");
        Assert.IsTrue(Source.Contains(nameof(SubmitPrConstants.SubmittingForFormat)), "Has SubmittingForFormat");
        Assert.IsTrue(Source.Contains(nameof(SubmitPrConstants.GitHubPrUrlLabel)), "Has GitHubPrUrlLabel");
        Assert.IsTrue(Source.Contains(nameof(SubmitPrConstants.SubmitButtonText)), "Has SubmitButtonText");
        Assert.IsTrue(Source.Contains(nameof(SubmitPrConstants.CancelButtonText)), "Has CancelButtonText");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SubmitPrPage uses SubmitPrConstants for all UI text")]
    public void SubmitPrPageUsesSubmitPrConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "SubmitPrPage.razor");
        Assert.IsTrue(Source.Contains("SubmitPrConstants.PageTitle"), "Uses PageTitle");
        Assert.IsTrue(Source.Contains("SubmitPrConstants.LoadingText"), "Uses LoadingText");
        Assert.IsTrue(Source.Contains("SubmitPrConstants.GitHubPrUrlLabel"), "Uses GitHubPrUrlLabel");
        Assert.IsTrue(Source.Contains("SubmitPrConstants.UserIdLabel"), "Uses UserIdLabel");
        Assert.IsTrue(Source.Contains("SubmitPrConstants.SubmitButtonText"), "Uses SubmitButtonText");
        Assert.IsTrue(Source.Contains("SubmitPrConstants.CancelButtonText"), "Uses CancelButtonText");
        Assert.IsFalse(Source.Contains(">Submit Pull Request<"), "No hardcoded button text");
    }
}
