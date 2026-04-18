using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("CreateTaskConstants has validation message constants")]
    public void CreateTaskConstantsComplete()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "CreateTaskConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(CreateTaskConstants.ValidationTitleRequired)), "Has ValidationTitleRequired");
        Assert.IsTrue(Source.Contains(nameof(CreateTaskConstants.ValidationDescriptionRequired)), "Has ValidationDescriptionRequired");
        Assert.IsTrue(Source.Contains(nameof(CreateTaskConstants.ValidationBountyTooLow)), "Has ValidationBountyTooLow");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("CreateTaskPage has input validation")]
    public void CreateTaskPageHasValidation()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Client", "CreateTaskPage.razor");
        Assert.IsTrue(Source.Contains("CreateTaskConstants.ValidationTitleRequired"), "Validates title");
        Assert.IsTrue(Source.Contains("CreateTaskConstants.ValidationDescriptionRequired"), "Validates description");
        Assert.IsTrue(Source.Contains("CreateTaskConstants.ValidationBountyTooLow"), "Validates bounty minimum");
        Assert.IsTrue(Source.Contains("ValidationMessage"), "Has ValidationMessage property");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("RepositoryPage validates URL format")]
    public void RepositoryPageValidatesUrlFormat()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Client", "RepositoryPage.razor");
        Assert.IsTrue(Source.Contains("Uri.TryCreate"), "Uses Uri.TryCreate for validation");
        Assert.IsTrue(Source.Contains("RepositoryConstants.StatusInvalidUrl"), "Uses StatusInvalidUrl constant");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("RepositoryConstants has StatusInvalidUrl")]
    public void RepositoryConstantsHasInvalidUrl()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "RepositoryConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(RepositoryConstants.StatusInvalidUrl)), "Has StatusInvalidUrl");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("CreateTaskPage button text matches behavior")]
    public void CreateTaskPageButtonTextCorrect()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Client", "CreateTaskPage.razor");
        Assert.IsTrue(Source.Contains("CreateTaskConstants.SubmitButtonText"), "Button uses CreateTaskConstants.SubmitButtonText");
        Assert.IsFalse(Source.Contains("Proceed to Payment"), "No misleading payment text");
    }
}
