using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("PaymentsPage auto-loads from auth context")]
    public void PaymentsPageAutoLoadsFromAuth()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Client", "PaymentsPage.razor");
        Assert.IsTrue(Source.Contains("IJSRuntime"), "Injects IJSRuntime");
        Assert.IsTrue(Source.Contains(nameof(JsInteropConstants.GetUserId)), "Uses GetUserId");
        Assert.IsTrue(Source.Contains("OnAfterRenderAsync"), "Has OnAfterRenderAsync");
        Assert.IsTrue(Source.Contains("LoadPayments"), "Calls LoadPayments on auto-load");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("EditTaskPage has full CRUD — load, edit, save")]
    public void EditTaskPageFullCrud()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Client", "EditTaskPage.razor");
        Assert.IsTrue(Source.Contains("GetByIdAsync"), "Loads task by ID");
        Assert.IsTrue(Source.Contains("UpdateAsync"), "Saves via UpdateAsync");
        Assert.IsTrue(Source.Contains("BountyAmountCents"), "Edits bounty amount");
        Assert.IsTrue(Source.Contains("Tags"), "Edits tags");
        Assert.IsTrue(Source.Contains("Complexity"), "Edits complexity");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SprintsPage has full CRUD — create, start, complete, delete")]
    public void SprintsPageFullCrud()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "SprintsPage.razor");
        Assert.IsTrue(Source.Contains("CreateAsync"), "Creates sprints");
        Assert.IsTrue(Source.Contains("UpdateAsync"), "Updates sprints (start/complete)");
        Assert.IsTrue(Source.Contains("DeleteAsync"), "Deletes sprints");
        Assert.IsTrue(Source.Contains("SprintStatus.Active"), "Transitions to Active");
        Assert.IsTrue(Source.Contains("SprintStatus.Completed"), "Transitions to Completed");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("BoardsPage has full CRUD — create, list, delete")]
    public void BoardsPageFullCrud()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "BoardsPage.razor");
        Assert.IsTrue(Source.Contains("CreateAsync"), "Creates boards");
        Assert.IsTrue(Source.Contains("DeleteAsync"), "Deletes boards");
        Assert.IsTrue(Source.Contains("ListByOwnerAsync"), "Lists by owner");
        Assert.IsTrue(Source.Contains("BoardType"), "Supports board types");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("BoardDetailPage has full column CRUD — create, delete, WIP limits")]
    public void BoardDetailPageFullColumnCrud()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "BoardDetailPage.razor");
        Assert.IsTrue(Source.Contains("CreateColumnAsync"), "Creates columns");
        Assert.IsTrue(Source.Contains("DeleteColumnAsync"), "Deletes columns");
        Assert.IsTrue(Source.Contains("WipLimit"), "Supports WIP limits");
        Assert.IsTrue(Source.Contains("ColumnTasks"), "Maps tasks to columns");
        Assert.IsTrue(Source.Contains("ListColumnsAsync"), "Lists columns");
    }
}
