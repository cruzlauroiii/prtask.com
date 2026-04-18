using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("NavConstants has navigation labels and button text")]
    public void NavConstantsHasNavigationLabels()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "NavConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(NavConstants.BrandName)), "Has BrandName");
        Assert.IsTrue(Source.Contains(nameof(NavConstants.TasksLabel)), "Has TasksLabel");
        Assert.IsTrue(Source.Contains(nameof(NavConstants.LeaderboardLabel)), "Has LeaderboardLabel");
        Assert.IsTrue(Source.Contains(nameof(NavConstants.HowItWorksLabel)), "Has HowItWorksLabel");
        Assert.IsTrue(Source.Contains(nameof(NavConstants.SignInText)), "Has SignInText");
        Assert.IsTrue(Source.Contains(nameof(NavConstants.SignOutText)), "Has SignOutText");
        Assert.IsTrue(Source.Contains(nameof(NavConstants.ToggleThemeTitle)), "Has ToggleThemeTitle");
        Assert.IsTrue(Source.Contains(nameof(NavConstants.ClearCacheTitle)), "Has ClearCacheTitle");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("NavMenu uses NavConstants for all UI text")]
    public void NavMenuUsesAllNavConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(Source.Contains("NavConstants.BrandName"), "Uses BrandName");
        Assert.IsTrue(Source.Contains("NavConstants.TasksLabel"), "Uses TasksLabel");
        Assert.IsTrue(Source.Contains("NavConstants.SignInText"), "Uses SignInText");
        Assert.IsTrue(Source.Contains("NavConstants.SignOutText"), "Uses SignOutText");
        Assert.IsTrue(Source.Contains("NavConstants.ToggleThemeTitle"), "Uses ToggleThemeTitle");
        Assert.IsFalse(Source.Contains(">Tasks<"), "No hardcoded Tasks text");
        Assert.IsFalse(Source.Contains(">Sign In<"), "No hardcoded Sign In text");
        Assert.IsFalse(Source.Contains(">Sign Out<"), "No hardcoded Sign Out text");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("FooterConstants has footer text")]
    public void FooterConstantsHasFooterText()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "FooterConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(FooterConstants.Tagline)), "Has Tagline");
        Assert.IsTrue(Source.Contains(nameof(FooterConstants.PlatformHeading)), "Has PlatformHeading");
        Assert.IsTrue(Source.Contains(nameof(FooterConstants.LegalHeading)), "Has LegalHeading");
        Assert.IsTrue(Source.Contains(nameof(FooterConstants.CopyrightText)), "Has CopyrightText");
        Assert.IsTrue(Source.Contains(nameof(FooterConstants.DoNotSellText)), "Has DoNotSellText");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("FooterSection uses FooterConstants and NavConstants for all UI text")]
    public void FooterSectionUsesAllConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Components", "FooterSection.razor");
        Assert.IsTrue(Source.Contains("NavConstants.BrandName"), "Uses BrandName");
        Assert.IsTrue(Source.Contains("FooterConstants.Tagline"), "Uses Tagline");
        Assert.IsTrue(Source.Contains("FooterConstants.PlatformHeading"), "Uses PlatformHeading");
        Assert.IsTrue(Source.Contains("FooterConstants.LegalHeading"), "Uses LegalHeading");
        Assert.IsTrue(Source.Contains("FooterConstants.CopyrightText"), "Uses CopyrightText");
        Assert.IsTrue(Source.Contains("FooterConstants.DoNotSellText"), "Uses DoNotSellText");
        Assert.IsTrue(Source.Contains("NavConstants.BrowseTasksLabel"), "Uses BrowseTasksLabel");
        Assert.IsFalse(Source.Contains(">Platform<"), "No hardcoded Platform heading");
        Assert.IsFalse(Source.Contains(">Legal<"), "No hardcoded Legal heading");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("PricingConstants has pricing page text")]
    public void PricingConstantsHasUiText()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "PricingConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(PricingConstants.PageHeading)), "Has PageHeading");
        Assert.IsTrue(Source.Contains(nameof(PricingConstants.PageDescription)), "Has PageDescription");
        Assert.IsTrue(Source.Contains(nameof(PricingConstants.DevelopersHeading)), "Has DevelopersHeading");
        Assert.IsTrue(Source.Contains(nameof(PricingConstants.ClientsHeading)), "Has ClientsHeading");
        Assert.IsTrue(Source.Contains(nameof(PricingConstants.FreeLabel)), "Has FreeLabel");
        Assert.IsTrue(Source.Contains(nameof(PricingConstants.FaqHeading)), "Has FaqHeading");
        Assert.IsTrue(Source.Contains(nameof(PricingConstants.FaqQuestion1)), "Has FaqQuestion1");
        Assert.IsTrue(Source.Contains(nameof(PricingConstants.FaqAnswer1)), "Has FaqAnswer1");
    }
}