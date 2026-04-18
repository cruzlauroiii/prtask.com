using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("CreateTaskConstants has UI text constants")]
    public void CreateTaskConstantsHasUiText()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "CreateTaskConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(CreateTaskConstants.PageHeading)), "Has PageHeading");
        Assert.IsTrue(Source.Contains(nameof(CreateTaskConstants.PageDescription)), "Has PageDescription");
        Assert.IsTrue(Source.Contains(nameof(CreateTaskConstants.TitleLabel)), "Has TitleLabel");
        Assert.IsTrue(Source.Contains(nameof(CreateTaskConstants.DescriptionLabel)), "Has DescriptionLabel");
        Assert.IsTrue(Source.Contains(nameof(CreateTaskConstants.BountyLabel)), "Has BountyLabel");
        Assert.IsTrue(Source.Contains(nameof(CreateTaskConstants.TagsLabel)), "Has TagsLabel");
        Assert.IsTrue(Source.Contains(nameof(CreateTaskConstants.SubmitButtonText)), "Has SubmitButtonText");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("CreateTaskPage uses CreateTaskConstants for all UI text")]
    public void CreateTaskPageUsesCreateTaskConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Client", "CreateTaskPage.razor");
        Assert.IsTrue(Source.Contains("CreateTaskConstants.PageHeading"), "Uses PageHeading");
        Assert.IsTrue(Source.Contains("CreateTaskConstants.PageDescription"), "Uses PageDescription");
        Assert.IsTrue(Source.Contains("CreateTaskConstants.TitleLabel"), "Uses TitleLabel");
        Assert.IsTrue(Source.Contains("CreateTaskConstants.DescriptionLabel"), "Uses DescriptionLabel");
        Assert.IsTrue(Source.Contains("CreateTaskConstants.RepoUrlLabel"), "Uses RepoUrlLabel");
        Assert.IsTrue(Source.Contains("CreateTaskConstants.BountyLabel"), "Uses BountyLabel");
        Assert.IsTrue(Source.Contains("CreateTaskConstants.TagsLabel"), "Uses TagsLabel");
        Assert.IsTrue(Source.Contains("CreateTaskConstants.SubmitButtonText"), "Uses SubmitButtonText");
        Assert.IsFalse(Source.Contains("\"Task Title\""), "No hardcoded label");
        Assert.IsFalse(Source.Contains("\"Create a New Task\""), "No hardcoded heading");
    }
}
