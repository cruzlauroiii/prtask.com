using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("LicensesConstants has all section constants")]
    public void LicensesConstantsComplete()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "LicensesConstants.cs");
        Assert.IsTrue(Source.Contains("SeoTitle"), "Has SeoTitle");
        Assert.IsTrue(Source.Contains("PageHeading"), "Has PageHeading");
        Assert.IsTrue(Source.Contains("PlatformLicenseHeading"), "Has PlatformLicenseHeading");
        Assert.IsTrue(Source.Contains("CreditCardProcessingHeading"), "Has PciDssHeading");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("LicensesPage uses LicensesConstants for all UI text")]
    public void LicensesPageUsesConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Legal", "LicensesPage.razor");
        Assert.IsTrue(Source.Contains("LicensesConstants."), "Uses LicensesConstants");
        Assert.IsFalse(Source.Contains("\"Licenses\""), "No hardcoded page heading");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("AccessibilityConstants has all section constants")]
    public void AccessibilityConstantsComplete()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "AccessibilityConstants.cs");
        Assert.IsTrue(Source.Contains("SeoTitle"), "Has SeoTitle");
        Assert.IsTrue(Source.Contains("PageHeading"), "Has PageHeading");
        Assert.IsTrue(Source.Contains("ConformanceStatusHeading"), "Has WcagConformanceHeading");
        Assert.IsTrue(Source.Contains("MeasuresHeading"), "Has MeasuresHeading");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("AccessibilityPage uses AccessibilityConstants for all UI text")]
    public void AccessibilityPageUsesConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Legal", "AccessibilityPage.razor");
        Assert.IsTrue(Source.Contains("AccessibilityConstants."), "Uses AccessibilityConstants");
        Assert.IsFalse(Source.Contains("\"Accessibility\""), "No hardcoded page heading");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("DmcaConstants has all section constants")]
    public void DmcaConstantsComplete()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "DmcaConstants.cs");
        Assert.IsTrue(Source.Contains("SeoTitle"), "Has SeoTitle");
        Assert.IsTrue(Source.Contains("PageHeading"), "Has PageHeading");
        Assert.IsTrue(Source.Contains("FilingNoticeHeading"), "Has FilingNoticeHeading");
        Assert.IsTrue(Source.Contains("CounterNotificationHeading"), "Has CounterNotificationHeading");
    }
}
