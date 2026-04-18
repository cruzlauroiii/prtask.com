using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("TermsConstants has all section constants")]
    public void TermsConstantsComplete()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "TermsConstants.cs");
        Assert.IsTrue(Source.Contains("SeoTitle"), "Has SeoTitle");
        Assert.IsTrue(Source.Contains("PageHeading"), "Has PageHeading");
        Assert.IsTrue(Source.Contains("PlatformRoleHeading"), "Has PlatformRoleHeading");
        Assert.IsTrue(Source.Contains("PaymentTermsHeading"), "Has PaymentTermsHeading");
        Assert.IsTrue(Source.Contains("DisputeResolutionHeading"), "Has DisputeResolutionHeading");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("TermsPage uses TermsConstants for all UI text")]
    public void TermsPageUsesConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Legal", "TermsPage.razor");
        Assert.IsTrue(Source.Contains("TermsConstants."), "Uses TermsConstants");
        Assert.IsFalse(Source.Contains("\"Terms of Service\""), "No hardcoded page heading");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("PrivacyConstants has all section constants")]
    public void PrivacyConstantsComplete()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "PrivacyConstants.cs");
        Assert.IsTrue(Source.Contains("SeoTitle"), "Has SeoTitle");
        Assert.IsTrue(Source.Contains("PageHeading"), "Has PageHeading");
        Assert.IsTrue(Source.Contains("GdprComplianceHeading"), "Has GdprHeading");
        Assert.IsTrue(Source.Contains("CcpaComplianceHeading"), "Has CcpaHeading");
        Assert.IsTrue(Source.Contains("DataBreachNotificationHeading"), "Has DataBreachHeading");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("PrivacyPage uses PrivacyConstants for all UI text")]
    public void PrivacyPageUsesConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Legal", "PrivacyPage.razor");
        Assert.IsTrue(Source.Contains("PrivacyConstants."), "Uses PrivacyConstants");
        Assert.IsFalse(Source.Contains("\"Privacy Policy\""), "No hardcoded page heading");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("CookiePolicyConstants has all section constants")]
    public void CookiePolicyConstantsComplete()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "CookiePolicyConstants.cs");
        Assert.IsTrue(Source.Contains("SeoTitle"), "Has SeoTitle");
        Assert.IsTrue(Source.Contains("PageHeading"), "Has PageHeading");
        Assert.IsTrue(Source.Contains("EssentialCookiesHeading"), "Has EssentialCookiesHeading");
        Assert.IsTrue(Source.Contains("TableHeaderCookieName"), "Has CookieTableHeaderName");
    }
}
