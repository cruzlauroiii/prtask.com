using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("MauiConstants has route error constants")]
    public void MauiConstantsComplete()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "MauiConstants.cs");
        Assert.IsTrue(Source.Contains("RouteNotFound"), "Has RouteNotFound");
        Assert.IsTrue(Source.Contains("SomethingWentWrong"), "Has SomethingWentWrong");
        Assert.IsTrue(Source.Contains("Reload"), "Has Reload");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("MauiLoginPage uses LoginConstants for all UI text")]
    public void MauiLoginPageUsesLoginConstants()
    {
        var Source = ReadSource("PrTask.Maui", "Pages", "MauiLoginPage.razor");
        Assert.IsTrue(Source.Contains("LoginConstants.PageHeading"), "Uses PageHeading");
        Assert.IsTrue(Source.Contains("LoginConstants.SignInWithGoogle"), "Uses SignInWithGoogle");
        Assert.IsTrue(Source.Contains("LoginConstants.DevelopersHeading"), "Uses DevelopersHeading");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Routes.razor uses MauiConstants for error text")]
    public void RoutesUseMauiConstants()
    {
        var Source = ReadSource("PrTask.Maui", "Routes.razor");
        Assert.IsTrue(Source.Contains("MauiConstants.RouteNotFound"), "Uses RouteNotFound");
        Assert.IsTrue(Source.Contains("MauiConstants.SomethingWentWrong"), "Uses SomethingWentWrong");
        Assert.IsTrue(Source.Contains("MauiConstants.Reload"), "Uses Reload");
    }
}
