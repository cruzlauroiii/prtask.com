using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("TaskVisibilityConstants has description constants for option labels")]
    public void TaskVisibilityConstantsHasDescriptions()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "TaskVisibilityConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(TaskVisibilityConstants.PublicDescription)), "Has PublicDescription");
        Assert.IsTrue(Source.Contains(nameof(TaskVisibilityConstants.PrivateDescription)), "Has PrivateDescription");
        var Create = ReadSource("PrTask.SharedUI", "Pages", "Client", "CreateTaskPage.razor");
        Assert.IsTrue(Create.Contains("TaskVisibilityConstants.PublicDescription"), "CreateTaskPage uses PublicDescription");
        Assert.IsTrue(Create.Contains("TaskVisibilityConstants.PrivateDescription"), "CreateTaskPage uses PrivateDescription");
        var Edit = ReadSource("PrTask.SharedUI", "Pages", "Client", "EditTaskPage.razor");
        Assert.IsTrue(Edit.Contains("TaskVisibilityConstants.PublicDescription"), "EditTaskPage uses PublicDescription");
        Assert.IsTrue(Edit.Contains("TaskVisibilityConstants.PrivateDescription"), "EditTaskPage uses PrivateDescription");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("RepositoryConstants has visibility description constants")]
    public void RepositoryConstantsVisibilityDescriptions()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "RepositoryConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(RepositoryConstants.VisibilityPublicDescription)), "Has VisibilityPublicDescription");
        Assert.IsTrue(Source.Contains(nameof(RepositoryConstants.VisibilityPrivateDescription)), "Has VisibilityPrivateDescription");
        var Page = ReadSource("PrTask.SharedUI", "Pages", "Client", "RepositoryPage.razor");
        Assert.IsTrue(Page.Contains("RepositoryConstants.VisibilityPublicDescription"), "Page uses VisibilityPublicDescription");
        Assert.IsTrue(Page.Contains("RepositoryConstants.VisibilityPrivateDescription"), "Page uses VisibilityPrivateDescription");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("PrConstants has RejectionReason constant")]
    public void PrConstantsRejectionReason()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "PrConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(PrConstants.RejectionReason)), "Has RejectionReason");
        var Page = ReadSource("PrTask.SharedUI", "Pages", "PullRequestDetailPage.razor");
        Assert.IsTrue(Page.Contains(nameof(PrConstants.RejectionReason)), "Page uses RejectionReason");
        Assert.IsFalse(Page.Contains("\"Changes requested\""), "No hardcoded rejection string");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("NavigateTo uses string.Format with RouteConstants in CreateTaskPage and EditTaskPage")]
    public void NavigateToUsesRouteConstants()
    {
        var Create = ReadSource("PrTask.SharedUI", "Pages", "Client", "CreateTaskPage.razor");
        Assert.IsTrue(Create.Contains("string.Format(RouteConstants.TaskDetail"), "CreateTaskPage uses RouteConstants.TaskDetail");
        Assert.IsFalse(Create.Contains("NavigateTo($\""), "CreateTaskPage no interpolated NavigateTo");
        var Edit = ReadSource("PrTask.SharedUI", "Pages", "Client", "EditTaskPage.razor");
        Assert.IsTrue(Edit.Contains("string.Format(RouteConstants.TaskDetail"), "EditTaskPage uses RouteConstants.TaskDetail");
        Assert.IsFalse(Edit.Contains("NavigateTo($\""), "EditTaskPage no interpolated NavigateTo");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SubmitPrPage NavigateTo uses string.Format with RouteConstants")]
    public void SubmitPrPageNavigateToUsesRouteConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "SubmitPrPage.razor");
        Assert.IsTrue(Source.Contains("string.Format(RouteConstants.PullRequestDetail"), "Uses RouteConstants.PullRequestDetail");
        Assert.IsFalse(Source.Contains("NavigateTo($\""), "No interpolated NavigateTo");
    }
}
