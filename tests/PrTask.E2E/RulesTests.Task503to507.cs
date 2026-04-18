using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("CookiePolicyPage uses CookiePolicyConstants for all UI text")]
    public void CookiePolicyPageUsesConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Legal", "CookiePolicyPage.razor");
        Assert.IsTrue(Source.Contains("CookiePolicyConstants."), "Uses CookiePolicyConstants");
        Assert.IsFalse(Source.Contains("\"Cookie Policy\""), "No hardcoded page heading");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("AcceptableUseConstants has all section constants")]
    public void AcceptableUseConstantsComplete()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "AcceptableUseConstants.cs");
        Assert.IsTrue(Source.Contains("SeoTitle"), "Has SeoTitle");
        Assert.IsTrue(Source.Contains("PageHeading"), "Has PageHeading");
        Assert.IsTrue(Source.Contains("ProhibitedActivitiesHeading"), "Has ProhibitedActivitiesHeading");
        Assert.IsTrue(Source.Contains("EnforcementActionsHeading"), "Has EnforcementHeading");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("AcceptableUsePage uses AcceptableUseConstants for all UI text")]
    public void AcceptableUsePageUsesConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Legal", "AcceptableUsePage.razor");
        Assert.IsTrue(Source.Contains("AcceptableUseConstants."), "Uses AcceptableUseConstants");
        Assert.IsFalse(Source.Contains("\"Acceptable Use\""), "No hardcoded page heading");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("RefundConstants has all section constants")]
    public void RefundConstantsComplete()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "RefundConstants.cs");
        Assert.IsTrue(Source.Contains("SeoTitle"), "Has SeoTitle");
        Assert.IsTrue(Source.Contains("PageHeading"), "Has PageHeading");
        Assert.IsTrue(Source.Contains("AutomaticPaymentModelHeading"), "Has AutomaticPaymentModelHeading");
        Assert.IsTrue(Source.Contains("ChargebackPolicyHeading"), "Has ChargebackPolicyHeading");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("RefundPage uses RefundConstants for all UI text")]
    public void RefundPageUsesConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Legal", "RefundPage.razor");
        Assert.IsTrue(Source.Contains("RefundConstants."), "Uses RefundConstants");
        Assert.IsFalse(Source.Contains("\"Refund Policy\""), "No hardcoded page heading");
    }
}
