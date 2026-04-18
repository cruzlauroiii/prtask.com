using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("DmcaPage uses DmcaConstants for all UI text")]
    public void DmcaPageUsesConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Legal", "DmcaPage.razor");
        Assert.IsTrue(Source.Contains("DmcaConstants."), "Uses DmcaConstants");
        Assert.IsFalse(Source.Contains("\"DMCA\""), "No hardcoded page heading");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("CreateTaskConstants has BountyHintFormat")]
    public void CreateTaskConstantsHasBountyHintFormat()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "CreateTaskConstants.cs");
        Assert.IsTrue(Source.Contains("BountyHintFormat"), "Has BountyHintFormat");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("CreateTaskPage uses FormatStrings.BountyHint")]
    public void CreateTaskPageUsesFormatStringsBountyHint()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Client", "CreateTaskPage.razor");
        Assert.IsTrue(Source.Contains("FormatStrings.BountyHint"), "Uses FormatStrings.BountyHint");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("TaskListConstants has TaskCountFormat")]
    public void TaskListConstantsHasTaskCountFormat()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "TaskListConstants.cs");
        Assert.IsTrue(Source.Contains("TaskCountFormat"), "Has TaskCountFormat");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("FormatStrings has TaskCount and BountyHint methods")]
    public void FormatStringsHasTaskCountAndBountyHint()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "FormatStrings.cs");
        Assert.IsTrue(Source.Contains("TaskCount"), "Has TaskCount method");
        Assert.IsTrue(Source.Contains("BountyHint"), "Has BountyHint method");
    }
}
