using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SeoHead must reference Constants SeoTitle and SeoDescription not hardcoded strings")]
    public void SeoHeadMustReferenceConstantsSeoTitleAndSeoDescriptionNotHardcodedStrings()
    {
        var About = ReadSource("PrTask.SharedUI", "Pages", "AboutPage.razor");
        Assert.IsTrue(About.Contains("@AboutConstants.SeoTitle"), "AboutPage has @AboutConstants.SeoTitle");
        Assert.IsTrue(About.Contains("@AboutConstants.SeoDescription"), "AboutPage has @AboutConstants.SeoDescription");
        var Pricing = ReadSource("PrTask.SharedUI", "Pages", "PricingPage.razor");
        Assert.IsTrue(Pricing.Contains("@PricingConstants.SeoTitle"), "PricingPage has @PricingConstants.SeoTitle");
        Assert.IsTrue(Pricing.Contains("@PricingConstants.SeoDescription"), "PricingPage has @PricingConstants.SeoDescription");
        var Download = ReadSource("PrTask.SharedUI", "Pages", "DownloadPage.razor");
        Assert.IsTrue(Download.Contains("@DownloadConstants.SeoTitle"), "DownloadPage has @DownloadConstants.SeoTitle");
        Assert.IsTrue(Download.Contains("@DownloadConstants.SeoDescription"), "DownloadPage has @DownloadConstants.SeoDescription");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("NavConstants must define MenuIcon ClearCacheIcon LightThemeIcon and DarkThemeIcon")]
    public void NavConstantsMustDefineMenuIconClearCacheIconLightThemeIconAndDarkThemeIcon()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "NavConstants.cs");
        Assert.IsTrue(Source.Contains("MenuIcon"), "Has MenuIcon");
        Assert.IsTrue(Source.Contains("ClearCacheIcon"), "Has ClearCacheIcon");
        Assert.IsTrue(Source.Contains("LightThemeIcon"), "Has LightThemeIcon");
        Assert.IsTrue(Source.Contains("DarkThemeIcon"), "Has DarkThemeIcon");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("NavMenu must use NavConstants for icon symbols not hardcoded entities")]
    public void NavMenuMustUseNavConstantsForIconSymbolsNotHardcodedEntities()
    {
        var Source = ReadSource("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(Source.Contains("NavConstants.MenuIcon"), "Has NavConstants.MenuIcon");
        Assert.IsTrue(Source.Contains("NavConstants.LightThemeIcon"), "Has NavConstants.LightThemeIcon");
        Assert.IsTrue(Source.Contains("NavConstants.ClearCacheIcon"), "Has NavConstants.ClearCacheIcon");
        Assert.IsTrue(Source.Contains("NavConstants.DarkThemeIcon"), "Has NavConstants.DarkThemeIcon");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SharedUI pages must use Constants PageHeading in the h1 element")]
    public void SharedUiPagesMustUseConstantsPageHeadingInTheH1Element()
    {
        var About = ReadSource("PrTask.SharedUI", "Pages", "AboutPage.razor");
        Assert.IsTrue(About.Contains("@AboutConstants.PageHeading") || About.Contains("AboutPageHeading"), "AboutPage uses PageHeading via constant or localization");
        var Pricing = ReadSource("PrTask.SharedUI", "Pages", "PricingPage.razor");
        Assert.IsTrue(Pricing.Contains("@PricingConstants.PageHeading") || Pricing.Contains("PricingPageHeading"), "PricingPage uses PageHeading via constant or localization");
        var Dashboard = ReadSource("PrTask.SharedUI", "Pages", "DashboardPage.razor");
        Assert.IsTrue(Dashboard.Contains("@DashboardConstants.PageHeading") || Dashboard.Contains("DashboardPageHeading"), "DashboardPage uses PageHeading via constant or localization");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("LeaderboardConstants must have SeoTitle SeoDescription and PageHeading")]
    public void LeaderboardConstantsMustHaveSeoTitleSeoDescriptionAndPageHeading()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "LeaderboardConstants.cs");
        Assert.IsTrue(Source.Contains("SeoTitle"), "Has SeoTitle");
        Assert.IsTrue(Source.Contains("SeoDescription"), "Has SeoDescription");
        Assert.IsTrue(Source.Contains("PageHeading"), "Has PageHeading");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SCSS must define key CSS classes referenced by razor files")]
    public void ScssMustDefineKeyCssClassesReferencedByRazorFiles()
    {
        var Source = File.ReadAllText(Path.Combine(SourceRoot, "PrTask.SharedUI", "Styles", "app.scss"));
        Assert.IsTrue(Source.Contains(".cookie-consent"), "Has .cookie-consent");
        Assert.IsTrue(Source.Contains(".board-card"), "Has .board-card");
        Assert.IsTrue(Source.Contains(".sprint-card"), "Has .sprint-card");
        Assert.IsTrue(Source.Contains(".leaderboard-table"), "Has .leaderboard-table");
        Assert.IsTrue(Source.Contains(".nav-menu"), "Has .nav-menu");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SCSS must include mobile breakpoint at max-width 480px")]
    public void ScssMustIncludeMobileBreakpointAtMaxWidth480Px()
    {
        var Source = File.ReadAllText(Path.Combine(SourceRoot, "PrTask.SharedUI", "Styles", "app.scss"));
        var HasBreakpoint = Source.Contains("max-width: 480px") || Source.Contains("max-width:480px");
        Assert.IsTrue(HasBreakpoint, "Has @media (max-width: 480px) mobile breakpoint");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("RemittanceEndpoints must map CreateRemittance ExecuteRemittance and GetRemittanceStatus")]
    public void RemittanceEndpointsMustMapCreateRemittanceExecuteRemittanceAndGetRemittanceStatus()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "RemittanceEndpoints.cs");
        Assert.IsTrue(Source.Contains("CreateRemittance"), "Has CreateRemittance");
        Assert.IsTrue(Source.Contains("ExecuteRemittance"), "Has ExecuteRemittance");
        Assert.IsTrue(Source.Contains("GetRemittanceStatus"), "Has GetRemittanceStatus");
    }
}
