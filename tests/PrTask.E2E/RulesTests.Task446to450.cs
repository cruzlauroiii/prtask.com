using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SprintConstants has all UI text constants")]
    public void SprintConstantsComplete()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "SprintConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(SprintConstants.LoadingText)), "Has LoadingText");
        Assert.IsTrue(Source.Contains(nameof(SprintConstants.EmptyStateText)), "Has EmptyStateText");
        Assert.IsTrue(Source.Contains(nameof(SprintConstants.CreateButtonText)), "Has CreateButtonText");
        Assert.IsTrue(Source.Contains(nameof(SprintConstants.StartButtonText)), "Has StartButtonText");
        Assert.IsTrue(Source.Contains(nameof(SprintConstants.CompleteButtonText)), "Has CompleteButtonText");
        Assert.IsTrue(Source.Contains(nameof(SprintConstants.DeleteButtonText)), "Has DeleteButtonText");
        Assert.IsTrue(Source.Contains(nameof(SprintConstants.NamePlaceholder)), "Has NamePlaceholder");
        Assert.IsTrue(Source.Contains(nameof(SprintConstants.DateRangeFormat)), "Has DateRangeFormat");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SprintsPage uses SprintConstants for all UI text")]
    public void SprintsPageUsesSprintConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "SprintsPage.razor");
        Assert.IsTrue(Source.Contains("SprintConstants.LoadingText"), "Uses LoadingText");
        Assert.IsTrue(Source.Contains("SprintConstants.EmptyStateText"), "Uses EmptyStateText");
        Assert.IsTrue(Source.Contains("SprintConstants.CreateButtonText"), "Uses CreateButtonText");
        Assert.IsTrue(Source.Contains("SprintConstants.StartButtonText"), "Uses StartButtonText");
        Assert.IsTrue(Source.Contains("SprintConstants.CompleteButtonText"), "Uses CompleteButtonText");
        Assert.IsTrue(Source.Contains("SprintConstants.DeleteButtonText"), "Uses DeleteButtonText");
        Assert.IsTrue(Source.Contains("SprintConstants.NamePlaceholder"), "Uses NamePlaceholder");
        Assert.IsTrue(Source.Contains("SprintConstants.DateRangeFormat"), "Uses DateRangeFormat");
        Assert.IsFalse(Source.Contains(">Create Sprint<"), "No hardcoded Create Sprint text");
        Assert.IsFalse(Source.Contains("\"Loading sprints...\""), "No hardcoded loading text");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("BoardConstants has UI text constants")]
    public void BoardConstantsHasUiText()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "BoardConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(BoardConstants.LoadingText)), "Has LoadingText");
        Assert.IsTrue(Source.Contains(nameof(BoardConstants.EmptyStateText)), "Has EmptyStateText");
        Assert.IsTrue(Source.Contains(nameof(BoardConstants.CreateButtonText)), "Has CreateButtonText");
        Assert.IsTrue(Source.Contains(nameof(BoardConstants.AddColumnButtonText)), "Has AddColumnButtonText");
        Assert.IsTrue(Source.Contains(nameof(BoardConstants.ColumnNamePlaceholder)), "Has ColumnNamePlaceholder");
        Assert.IsTrue(Source.Contains(nameof(BoardConstants.EmptyColumnText)), "Has EmptyColumnText");
        Assert.IsTrue(Source.Contains(nameof(BoardConstants.DetailLoadingText)), "Has DetailLoadingText");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("BoardsPage uses BoardConstants for all UI text")]
    public void BoardsPageUsesBoardConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "BoardsPage.razor");
        Assert.IsTrue(Source.Contains("BoardConstants.LoadingText"), "Uses LoadingText");
        Assert.IsTrue(Source.Contains("BoardConstants.EmptyStateText"), "Uses EmptyStateText");
        Assert.IsTrue(Source.Contains("BoardConstants.CreateButtonText"), "Uses CreateButtonText");
        Assert.IsTrue(Source.Contains("BoardConstants.CreateActionText"), "Uses CreateActionText");
        Assert.IsTrue(Source.Contains("BoardConstants.DeleteButtonText"), "Uses DeleteButtonText");
        Assert.IsTrue(Source.Contains("BoardConstants.NamePlaceholder"), "Uses NamePlaceholder");
        Assert.IsFalse(Source.Contains("\"Loading boards...\""), "No hardcoded loading text");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("BoardDetailPage uses BoardConstants for all UI text")]
    public void BoardDetailPageUsesBoardConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "BoardDetailPage.razor");
        Assert.IsTrue(Source.Contains("BoardConstants.DetailLoadingText"), "Uses DetailLoadingText");
        Assert.IsTrue(Source.Contains("BoardConstants.AddColumnButtonText"), "Uses AddColumnButtonText");
        Assert.IsTrue(Source.Contains("BoardConstants.AddColumnActionText"), "Uses AddColumnActionText");
        Assert.IsTrue(Source.Contains("BoardConstants.ColumnNamePlaceholder"), "Uses ColumnNamePlaceholder");
        Assert.IsTrue(Source.Contains("BoardConstants.ColumnWipPlaceholder"), "Uses ColumnWipPlaceholder");
        Assert.IsTrue(Source.Contains("BoardConstants.EmptyColumnText"), "Uses EmptyColumnText");
        Assert.IsTrue(Source.Contains("BoardConstants.DeleteColumnButtonText"), "Uses DeleteColumnButtonText");
        Assert.IsFalse(Source.Contains("\"Loading board...\""), "No hardcoded loading text");
    }
}
