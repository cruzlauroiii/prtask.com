using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("PricingPage uses PricingConstants for all UI text")]
    public void PricingPageUsesAllPricingConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "PricingPage.razor");
        Assert.IsTrue(Source.Contains("PricingConstants.PageHeading"), "Uses PageHeading");
        Assert.IsTrue(Source.Contains("PricingConstants.DevelopersHeading"), "Uses DevelopersHeading");
        Assert.IsTrue(Source.Contains("PricingConstants.FreeLabel"), "Uses FreeLabel");
        Assert.IsTrue(Source.Contains("PricingConstants.FaqHeading"), "Uses FaqHeading");
        Assert.IsFalse(Source.Contains("\"Pricing\""), "No hardcoded heading");
        Assert.IsFalse(Source.Contains("\"Free\""), "No hardcoded free label");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("DownloadConstants has download page text")]
    public void DownloadConstantsHasUiText()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "DownloadConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(DownloadConstants.PageHeading)), "Has PageHeading");
        Assert.IsTrue(Source.Contains(nameof(DownloadConstants.AndroidHeading)), "Has AndroidHeading");
        Assert.IsTrue(Source.Contains(nameof(DownloadConstants.AndroidButtonText)), "Has AndroidButtonText");
        Assert.IsTrue(Source.Contains(nameof(DownloadConstants.ComingSoonText)), "Has ComingSoonText");
        Assert.IsTrue(Source.Contains(nameof(DownloadConstants.WebAppHeading)), "Has WebAppHeading");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("DownloadPage uses DownloadConstants for all UI text")]
    public void DownloadPageUsesAllDownloadConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "DownloadPage.razor");
        Assert.IsTrue(Source.Contains("DownloadConstants.PageHeading"), "Uses PageHeading");
        Assert.IsTrue(Source.Contains("DownloadConstants.AndroidButtonText"), "Uses AndroidButtonText");
        Assert.IsTrue(Source.Contains("DownloadConstants.ComingSoonText"), "Uses ComingSoonText");
        Assert.IsFalse(Source.Contains("\"Coming Soon\""), "No hardcoded coming soon");
        Assert.IsFalse(Source.Contains("\"Download PrTask\""), "No hardcoded heading");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("AboutConstants has about page text")]
    public void AboutConstantsHasUiText()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "AboutConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(AboutConstants.PageHeading)), "Has PageHeading");
        Assert.IsTrue(Source.Contains(nameof(AboutConstants.WhatWeDoHeading)), "Has WhatWeDoHeading");
        Assert.IsTrue(Source.Contains(nameof(AboutConstants.AchievementsHeading)), "Has AchievementsHeading");
        Assert.IsTrue(Source.Contains(nameof(AboutConstants.PaymentsHeading)), "Has PaymentsHeading");
        Assert.IsTrue(Source.Contains(nameof(AboutConstants.ContactHeading)), "Has ContactHeading");
        Assert.IsTrue(Source.Contains(nameof(AboutConstants.TermsLinkText)), "Has TermsLinkText");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("AboutPage uses AboutConstants for all UI text")]
    public void AboutPageUsesAllAboutConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "AboutPage.razor");
        Assert.IsTrue(Source.Contains("AboutConstants.PageHeading"), "Uses PageHeading");
        Assert.IsTrue(Source.Contains("AboutConstants.WhatWeDoHeading"), "Uses WhatWeDoHeading");
        Assert.IsTrue(Source.Contains("AboutConstants.ContactHeading"), "Uses ContactHeading");
        Assert.IsTrue(Source.Contains("AboutConstants.TermsLinkText"), "Uses TermsLinkText");
        Assert.IsFalse(Source.Contains("\"About PrTask\""), "No hardcoded heading");
        Assert.IsFalse(Source.Contains("\"What We Do\""), "No hardcoded section heading");
    }
}
