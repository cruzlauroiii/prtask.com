using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("TaskListConstants has search filter and sort constants")]
    public void TaskListConstantsComplete()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "TaskListConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(TaskListConstants.MaxDescriptionPreviewLength)), "Has MaxDescriptionPreviewLength");
        Assert.IsTrue(Source.Contains(nameof(TaskListConstants.FilterAll)), "Has FilterAll");
        Assert.IsTrue(Source.Contains(nameof(TaskListConstants.SortByNewest)), "Has SortByNewest");
        Assert.IsTrue(Source.Contains(nameof(TaskListConstants.SortByBounty)), "Has SortByBounty");
        Assert.IsTrue(Source.Contains(nameof(TaskListConstants.SortByComplexity)), "Has SortByComplexity");
        Assert.IsTrue(Source.Contains(nameof(TaskListConstants.SearchPlaceholder)), "Has SearchPlaceholder");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("TaskList has search filter and sort functionality")]
    public void TaskListHasSearchFilterSort()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "TaskList.razor");
        Assert.IsTrue(Source.Contains("SearchQuery"), "Has SearchQuery property");
        Assert.IsTrue(Source.Contains("ComplexityFilter"), "Has ComplexityFilter property");
        Assert.IsTrue(Source.Contains("SortOrder"), "Has SortOrder property");
        Assert.IsTrue(Source.Contains("ApplyFilters"), "Has ApplyFilters method");
        Assert.IsTrue(Source.Contains("FilteredTasks"), "Has FilteredTasks computed property");
        Assert.IsTrue(Source.Contains("TaskListConstants.FilterAll"), "Uses TaskListConstants.FilterAll");
        Assert.IsTrue(Source.Contains("TaskListConstants.SortByNewest"), "Uses TaskListConstants.SortByNewest");
        Assert.IsTrue(Source.Contains("TaskListConstants.SortByBounty"), "Uses TaskListConstants.SortByBounty");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("FormatStrings has TruncateText method")]
    public void FormatStringsTruncateText()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "FormatStrings.cs");
        Assert.IsTrue(Source.Contains("TruncateText"), "Has TruncateText method");
        var TaskList = ReadSource("PrTask.SharedUI", "Pages", "TaskList.razor");
        Assert.IsTrue(TaskList.Contains("FormatStrings.TruncateText"), "TaskList uses FormatStrings.TruncateText");
        Assert.IsTrue(TaskList.Contains("TaskListConstants.MaxDescriptionPreviewLength"), "Uses MaxDescriptionPreviewLength constant");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Home page has dynamic stats from services")]
    public void HomePageDynamicStats()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Home.razor");
        Assert.IsTrue(Source.Contains("ITaskService"), "Injects ITaskService");
        Assert.IsTrue(Source.Contains("IUserService"), "Injects IUserService");
        Assert.IsTrue(Source.Contains("OpenTaskCount"), "Has OpenTaskCount");
        Assert.IsTrue(Source.Contains("TotalBountyCents"), "Has TotalBountyCents");
        Assert.IsTrue(Source.Contains("DeveloperCount"), "Has DeveloperCount");
        Assert.IsTrue(Source.Contains("FormatStrings.BountyAmount"), "Uses FormatStrings.BountyAmount");
        Assert.IsTrue(Source.Contains("OnInitializedAsync"), "Has OnInitializedAsync");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("TaskList uses RouteConstants.TaskDetail for task links")]
    public void TaskListUsesRouteConstantsForLinks()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "TaskList.razor");
        Assert.IsTrue(Source.Contains("RouteConstants.TaskDetail"), "Uses RouteConstants.TaskDetail");
        Assert.IsFalse(Source.Contains("\"/tasks/{0}\""), "No hardcoded /tasks/{0} format string");
    }
}
