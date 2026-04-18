using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SourceCodeConstants has file type validation")]
    public void SourceCodeConstantsHasFileTypeValidation()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "SourceCodeConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(SourceCodeConstants.AllowedExtensions)), "Has AllowedExtensions");
        Assert.IsTrue(Source.Contains(nameof(SourceCodeConstants.InvalidFileType)), "Has InvalidFileType");
        Assert.IsTrue(Source.Contains(nameof(SourceCodeConstants.FileTooLarge)), "Has FileTooLarge");
        Assert.IsTrue(Source.Contains(nameof(SourceCodeConstants.NoValidFiles)), "Has NoValidFiles");
        Assert.IsTrue(Source.Contains(nameof(SourceCodeConstants.MaxTotalUploadSizeBytes)), "Has MaxTotalUploadSizeBytes");
        Assert.IsTrue(Source.Contains(nameof(SourceCodeConstants.TotalSizeTooLarge)), "Has TotalSizeTooLarge");
        Assert.IsTrue(Source.Contains(nameof(SourceCodeConstants.WarningSeparator)), "Has WarningSeparator");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("HandleFileUploadAsync validates file types")]
    public void HandleFileUploadValidatesFileTypes()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "TaskDetailPage.razor.cs");
        Assert.IsTrue(Source.Contains("SourceCodeConstants.AllowedExtensions"), "Checks AllowedExtensions");
        Assert.IsTrue(Source.Contains("Path.GetExtension"), "Uses Path.GetExtension");
        Assert.IsTrue(Source.Contains("SourceCodeConstants.InvalidFileType"), "Shows InvalidFileType warning");
        Assert.IsTrue(Source.Contains("SourceCodeConstants.NoValidFiles"), "Shows NoValidFiles when empty");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("HandleFileUploadAsync validates file size")]
    public void HandleFileUploadValidatesFileSize()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "TaskDetailPage.razor.cs");
        Assert.IsTrue(Source.Contains("SourceCodeConstants.MaxUploadFileSizeBytes"), "Checks per-file size");
        Assert.IsTrue(Source.Contains("SourceCodeConstants.MaxTotalUploadSizeBytes"), "Checks total size");
        Assert.IsTrue(Source.Contains("SourceCodeConstants.FileTooLarge"), "Shows FileTooLarge warning");
        Assert.IsTrue(Source.Contains("SourceCodeConstants.TotalSizeTooLarge"), "Shows TotalSizeTooLarge");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("TaskDetailPage delete navigates to tasks list")]
    public void TaskDetailPageDeleteNavigatesToTasksList()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "TaskDetailPage.razor");
        Assert.IsTrue(Source.Contains("NavigationManager.NavigateTo(RouteConstants.Tasks)"), "Navigates to tasks after delete");
        Assert.IsTrue(Source.Contains("TaskService.DeleteAsync"), "Calls DeleteAsync");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("TaskDetailConstants has all UI text constants")]
    public void TaskDetailConstantsComplete()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "TaskDetailConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(TaskDetailConstants.LoadingText)), "Has LoadingText");
        Assert.IsTrue(Source.Contains(nameof(TaskDetailConstants.SourceCodeHeading)), "Has SourceCodeHeading");
        Assert.IsTrue(Source.Contains(nameof(TaskDetailConstants.PullRequestsHeading)), "Has PullRequestsHeading");
        Assert.IsTrue(Source.Contains(nameof(TaskDetailConstants.EmptyPrState)), "Has EmptyPrState");
        Assert.IsTrue(Source.Contains(nameof(TaskDetailConstants.ClaimButtonText)), "Has ClaimButtonText");
        Assert.IsTrue(Source.Contains(nameof(TaskDetailConstants.DeadlineDateFormat)), "Has DeadlineDateFormat");
        Assert.IsTrue(Source.Contains(nameof(TaskDetailConstants.StatusLabel)), "Has StatusLabel");
    }
}
