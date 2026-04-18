namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("AboutPage uses RouteConstants for legal links")]
    public void AboutPageUsesRouteConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "AboutPage.razor");
        Assert.IsTrue(Source.Contains("RouteConstants.Terms"), "Uses Terms constant");
        Assert.IsTrue(Source.Contains("RouteConstants.Privacy"), "Uses Privacy constant");
        Assert.IsTrue(Source.Contains("RouteConstants.CookiePolicy"), "Uses CookiePolicy constant");
        Assert.IsTrue(Source.Contains("RouteConstants.AcceptableUse"), "Uses AcceptableUse constant");
        Assert.IsTrue(Source.Contains("RouteConstants.Refund"), "Uses Refund constant");
        Assert.IsTrue(Source.Contains("RouteConstants.Licenses"), "Uses Licenses constant");
        Assert.IsTrue(Source.Contains("RouteConstants.Accessibility"), "Uses Accessibility constant");
        Assert.IsTrue(Source.Contains("RouteConstants.Dmca"), "Uses Dmca constant");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Home page uses RouteConstants for navigation links")]
    public void HomePageUsesRouteConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Home.razor");
        Assert.IsTrue(Source.Contains("RouteConstants.Tasks"), "Uses Tasks constant");
        Assert.IsTrue(Source.Contains("RouteConstants.HowItWorks"), "Uses HowItWorks constant");
        Assert.IsTrue(Source.Contains("PrTask.Domain.Constants"), "Imports Domain.Constants");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("LoginPage uses RouteConstants for SSO provider endpoints")]
    public void LoginPageUsesRouteConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "LoginPage.razor");
        Assert.IsTrue(Source.Contains("RouteConstants.ApiAuthGoogle"), "Uses Google auth constant");
        Assert.IsTrue(Source.Contains("RouteConstants.ApiAuthGitHub"), "Uses GitHub auth constant");
        Assert.IsTrue(Source.Contains("RouteConstants.ApiAuthAzure"), "Uses Azure auth constant");
        Assert.IsTrue(Source.Contains("RouteConstants.ApiAuthOkta"), "Uses Okta auth constant");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SharedUI Home page has JSON-LD structured data")]
    public void HomePageHasStructuredData()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Home.razor");
        Assert.IsTrue(Source.Contains("application/ld+json"), "Has JSON-LD script");
        Assert.IsTrue(Source.Contains("schema.org"), "Uses schema.org vocabulary");
        Assert.IsTrue(Source.Contains("Organization"), "Has Organization schema");
        Assert.IsTrue(Source.Contains("WebSite"), "Has WebSite schema");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SharedUI Home page has stats section")]
    public void HomePageHasStats()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Home.razor");
        Assert.IsTrue(Source.Contains("stats-section"), "Has stats section");
        Assert.IsTrue(Source.Contains("stat-card"), "Has stat cards");
        Assert.IsTrue(Source.Contains("HomeConstants.DeveloperPayoutValue"), "Shows 100% payout");
    }
}
