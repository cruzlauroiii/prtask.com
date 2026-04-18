namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("ClientHomePage is thin wrapper for SharedUI Home")]
    public void ClientHomePageIsThinWrapper()
    {
        var Source = ReadSource("PrTask.Client", "Pages", "ClientHomePage.razor");
        Assert.IsTrue(Source.Contains("PrTask.SharedUI.Pages.Home"), "Wraps SharedUI Home");
        Assert.IsFalse(Source.Contains("hero-subtitle"), "No duplicate hero content");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("ClientAboutPage is thin wrapper for SharedUI AboutPage")]
    public void ClientAboutPageIsThinWrapper()
    {
        var Source = ReadSource("PrTask.Client", "Pages", "ClientAboutPage.razor");
        Assert.IsTrue(Source.Contains("PrTask.SharedUI.Pages.AboutPage"), "Wraps SharedUI AboutPage");
        Assert.IsFalse(Source.Contains("about-section"), "No duplicate about content");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("ClientPricingPage is thin wrapper for SharedUI PricingPage")]
    public void ClientPricingPageIsThinWrapper()
    {
        var Source = ReadSource("PrTask.Client", "Pages", "ClientPricingPage.razor");
        Assert.IsTrue(Source.Contains("PrTask.SharedUI.Pages.PricingPage"), "Wraps SharedUI PricingPage");
        Assert.IsFalse(Source.Contains("pricing-card"), "No duplicate pricing content");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("ClientLoginPage is thin wrapper for SharedUI LoginPage")]
    public void ClientLoginPageIsThinWrapper()
    {
        var Source = ReadSource("PrTask.Client", "Pages", "ClientLoginPage.razor");
        Assert.IsTrue(Source.Contains("PrTask.SharedUI.Pages.LoginPage"), "Wraps SharedUI LoginPage");
        Assert.IsFalse(Source.Contains("login-buttons"), "No duplicate login content");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("All Client pages are thin wrappers — max 6 lines each")]
    public void AllClientPagesAreThinWrappers()
    {
        var ClientDir = Path.Combine(SourceRoot, "PrTask.Client", "Pages");
        foreach (var File in Directory.GetFiles(ClientDir, "Client*.razor"))
        {
            var Lines = System.IO.File.ReadAllLines(File).Length;
            Assert.IsTrue(Lines <= 6, $"{Path.GetFileName(File)} has {Lines} lines — should be thin wrapper (max 6)");
        }
    }
}
