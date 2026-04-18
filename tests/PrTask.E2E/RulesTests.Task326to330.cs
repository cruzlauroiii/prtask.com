using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("NavMenu uses JsInteropConstants instead of magic strings")]
    public void NavMenuUsesJsInteropConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(Source.Contains(nameof(JsInteropConstants)), "Uses JsInteropConstants");
        Assert.IsTrue(Source.Contains(nameof(JsInteropConstants.GetTheme)), "Uses GetTheme constant");
        Assert.IsTrue(Source.Contains(nameof(JsInteropConstants.CheckAuth)), "Uses CheckAuth constant");
        Assert.IsTrue(Source.Contains(nameof(JsInteropConstants.SignOut)), "Uses SignOut constant");
        Assert.IsFalse(Source.Contains("\"prtask"), "No raw prtask strings");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("BoardsPage uses JsRuntime for CurrentUserId")]
    public void BoardsPageUsesJsRuntime()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "BoardsPage.razor");
        Assert.IsTrue(Source.Contains("IJSRuntime"), "Injects IJSRuntime");
        Assert.IsTrue(Source.Contains(nameof(JsInteropConstants.GetUserId)), "Uses GetUserId");
        Assert.IsTrue(Source.Contains("CurrentUserId"), "Has CurrentUserId property");
        Assert.IsFalse(Source.Contains("\"current-user\""), "No hardcoded current-user");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SprintsPage uses JsRuntime for CurrentUserId")]
    public void SprintsPageUsesJsRuntime()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "SprintsPage.razor");
        Assert.IsTrue(Source.Contains("IJSRuntime"), "Injects IJSRuntime");
        Assert.IsTrue(Source.Contains(nameof(JsInteropConstants.GetUserId)), "Uses GetUserId");
        Assert.IsTrue(Source.Contains("CurrentUserId"), "Has CurrentUserId property");
        Assert.IsFalse(Source.Contains("\"current-user\""), "No hardcoded current-user");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("CreateTaskPage uses JsRuntime for CurrentUserId")]
    public void CreateTaskPageUsesJsRuntime()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Client", "CreateTaskPage.razor");
        Assert.IsTrue(Source.Contains("IJSRuntime"), "Injects IJSRuntime");
        Assert.IsTrue(Source.Contains(nameof(JsInteropConstants.GetUserId)), "Uses GetUserId");
        Assert.IsTrue(Source.Contains("CurrentUserId"), "Has CurrentUserId property");
        Assert.IsFalse(Source.Contains("\"current-user\""), "No hardcoded current-user");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("RepositoryPage uses JsRuntime for OwnerId")]
    public void RepositoryPageUsesJsRuntime()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Client", "RepositoryPage.razor");
        Assert.IsTrue(Source.Contains("IJSRuntime"), "Injects IJSRuntime");
        Assert.IsTrue(Source.Contains(nameof(JsInteropConstants.GetUserId)), "Uses GetUserId");
        Assert.IsFalse(Source.Contains("\"current-user\""), "No hardcoded current-user");
    }
}
