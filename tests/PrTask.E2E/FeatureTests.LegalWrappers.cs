namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client legal wrappers must delegate terms privacy and refund pages to shared ui components")]
    public void ClientLegalWrappersMustDelegateTermsPrivacyAndRefundPagesToSharedUiComponents()
    {
        var Terms = ReadSourceFile("PrTask.Client", "Pages", "Legal", "ClientTermsPage.razor");
        var Privacy = ReadSourceFile("PrTask.Client", "Pages", "Legal", "ClientPrivacyPage.razor");
        var Refund = ReadSourceFile("PrTask.Client", "Pages", "Legal", "ClientRefundPage.razor");
        Assert.IsTrue(Terms.Contains("PrTask.SharedUI.Pages.Legal.TermsPage", StringComparison.Ordinal), "Client terms must delegate to SharedUI TermsPage");
        Assert.IsTrue(Privacy.Contains("PrTask.SharedUI.Pages.Legal.PrivacyPage", StringComparison.Ordinal), "Client privacy must delegate to SharedUI PrivacyPage");
        Assert.IsTrue(Refund.Contains("PrTask.SharedUI.Pages.Legal.RefundPage", StringComparison.Ordinal), "Client refund must delegate to SharedUI RefundPage");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client legal wrappers must delegate dmca accessibility and cookie policy to shared ui components")]
    public void ClientLegalWrappersMustDelegateDmcaAccessibilityAndCookiePolicyToSharedUiComponents()
    {
        var Dmca = ReadSourceFile("PrTask.Client", "Pages", "Legal", "ClientDmcaPage.razor");
        var Accessibility = ReadSourceFile("PrTask.Client", "Pages", "Legal", "ClientAccessibilityPage.razor");
        var CookiePolicy = ReadSourceFile("PrTask.Client", "Pages", "Legal", "ClientCookiePolicyPage.razor");
        Assert.IsTrue(Dmca.Contains("PrTask.SharedUI.Pages.Legal.DmcaPage", StringComparison.Ordinal), "Client DMCA must delegate to SharedUI DmcaPage");
        Assert.IsTrue(Accessibility.Contains("PrTask.SharedUI.Pages.Legal.AccessibilityPage", StringComparison.Ordinal), "Client accessibility must delegate to SharedUI AccessibilityPage");
        Assert.IsTrue(CookiePolicy.Contains("PrTask.SharedUI.Pages.Legal.CookiePolicyPage", StringComparison.Ordinal), "Client cookie policy must delegate to SharedUI CookiePolicyPage");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client legal wrappers must delegate acceptable use and licenses pages to shared ui components")]
    public void ClientLegalWrappersMustDelegateAcceptableUseAndLicensesPagesToSharedUiComponents()
    {
        var AcceptableUse = ReadSourceFile("PrTask.Client", "Pages", "Legal", "ClientAcceptableUsePage.razor");
        var Licenses = ReadSourceFile("PrTask.Client", "Pages", "Legal", "ClientLicensesPage.razor");
        Assert.IsTrue(AcceptableUse.Contains("PrTask.SharedUI.Pages.Legal.AcceptableUsePage", StringComparison.Ordinal), "Client acceptable use must delegate to SharedUI AcceptableUsePage");
        Assert.IsTrue(Licenses.Contains("PrTask.SharedUI.Pages.Legal.LicensesPage", StringComparison.Ordinal), "Client licenses must delegate to SharedUI LicensesPage");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client legal pages must use correct legal route paths matching route constants definitions")]
    public void ClientLegalPagesMustUseCorrectLegalRoutePathsMatchingRouteConstantsDefinitions()
    {
        var Terms = ReadSourceFile("PrTask.Client", "Pages", "Legal", "ClientTermsPage.razor");
        var Privacy = ReadSourceFile("PrTask.Client", "Pages", "Legal", "ClientPrivacyPage.razor");
        var Refund = ReadSourceFile("PrTask.Client", "Pages", "Legal", "ClientRefundPage.razor");
        var Dmca = ReadSourceFile("PrTask.Client", "Pages", "Legal", "ClientDmcaPage.razor");
        Assert.IsTrue(Terms.Contains("/legal/terms", StringComparison.Ordinal), "Client terms must use /legal/terms route");
        Assert.IsTrue(Privacy.Contains("/legal/privacy", StringComparison.Ordinal), "Client privacy must use /legal/privacy route");
        Assert.IsTrue(Refund.Contains("/legal/refund", StringComparison.Ordinal), "Client refund must use /legal/refund route");
        Assert.IsTrue(Dmca.Contains("/legal/dmca", StringComparison.Ordinal), "Client DMCA must use /legal/dmca route");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client legal pages must use correct route paths for accessibility cookie policy acceptable use licenses")]
    public void ClientLegalPagesMustUseCorrectRoutePathsForAccessibilityCookiePolicyAcceptableUseLicenses()
    {
        var Accessibility = ReadSourceFile("PrTask.Client", "Pages", "Legal", "ClientAccessibilityPage.razor");
        var CookiePolicy = ReadSourceFile("PrTask.Client", "Pages", "Legal", "ClientCookiePolicyPage.razor");
        var AcceptableUse = ReadSourceFile("PrTask.Client", "Pages", "Legal", "ClientAcceptableUsePage.razor");
        var Licenses = ReadSourceFile("PrTask.Client", "Pages", "Legal", "ClientLicensesPage.razor");
        Assert.IsTrue(Accessibility.Contains("/legal/accessibility", StringComparison.Ordinal), "Client accessibility must use /legal/accessibility route");
        Assert.IsTrue(CookiePolicy.Contains("/legal/cookie-policy", StringComparison.Ordinal), "Client cookie policy must use /legal/cookie-policy route");
        Assert.IsTrue(AcceptableUse.Contains("/legal/acceptable-use", StringComparison.Ordinal), "Client acceptable use must use /legal/acceptable-use route");
        Assert.IsTrue(Licenses.Contains("/legal/licenses", StringComparison.Ordinal), "Client licenses must use /legal/licenses route");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui legal wrappers must delegate refund dmca and accessibility pages to shared ui components")]
    public void MauiLegalWrappersMustDelegateRefundDmcaAndAccessibilityPagesToSharedUiComponents()
    {
        var Refund = ReadSourceFile("PrTask.Maui", "Pages", "Legal", "MauiRefundPage.razor");
        var Dmca = ReadSourceFile("PrTask.Maui", "Pages", "Legal", "MauiDmcaPage.razor");
        var Accessibility = ReadSourceFile("PrTask.Maui", "Pages", "Legal", "MauiAccessibilityPage.razor");
        Assert.IsTrue(Refund.Contains("PrTask.SharedUI.Pages.Legal.RefundPage", StringComparison.Ordinal), "Maui refund must delegate to SharedUI RefundPage");
        Assert.IsTrue(Dmca.Contains("PrTask.SharedUI.Pages.Legal.DmcaPage", StringComparison.Ordinal), "Maui DMCA must delegate to SharedUI DmcaPage");
        Assert.IsTrue(Accessibility.Contains("PrTask.SharedUI.Pages.Legal.AccessibilityPage", StringComparison.Ordinal), "Maui accessibility must delegate to SharedUI AccessibilityPage");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui legal wrappers must delegate cookie policy acceptable use and licenses to shared ui")]
    public void MauiLegalWrappersMustDelegateCookiePolicyAcceptableUseAndLicensesToSharedUi()
    {
        var CookiePolicy = ReadSourceFile("PrTask.Maui", "Pages", "Legal", "MauiCookiePolicyPage.razor");
        var AcceptableUse = ReadSourceFile("PrTask.Maui", "Pages", "Legal", "MauiAcceptableUsePage.razor");
        var Licenses = ReadSourceFile("PrTask.Maui", "Pages", "Legal", "MauiLicensesPage.razor");
        Assert.IsTrue(CookiePolicy.Contains("PrTask.SharedUI.Pages.Legal.CookiePolicyPage", StringComparison.Ordinal), "Maui cookie policy must delegate to SharedUI CookiePolicyPage");
        Assert.IsTrue(AcceptableUse.Contains("PrTask.SharedUI.Pages.Legal.AcceptableUsePage", StringComparison.Ordinal), "Maui acceptable use must delegate to SharedUI AcceptableUsePage");
        Assert.IsTrue(Licenses.Contains("PrTask.SharedUI.Pages.Legal.LicensesPage", StringComparison.Ordinal), "Maui licenses must delegate to SharedUI LicensesPage");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui legal pages must use correct legal route paths for refund dmca accessibility and cookie policy")]
    public void MauiLegalPagesMustUseCorrectLegalRoutePathsForRefundDmcaAccessibilityAndCookiePolicy()
    {
        var Refund = ReadSourceFile("PrTask.Maui", "Pages", "Legal", "MauiRefundPage.razor");
        var Dmca = ReadSourceFile("PrTask.Maui", "Pages", "Legal", "MauiDmcaPage.razor");
        var Accessibility = ReadSourceFile("PrTask.Maui", "Pages", "Legal", "MauiAccessibilityPage.razor");
        var CookiePolicy = ReadSourceFile("PrTask.Maui", "Pages", "Legal", "MauiCookiePolicyPage.razor");
        Assert.IsTrue(Refund.Contains("/legal/refund", StringComparison.Ordinal), "Maui refund must use /legal/refund route");
        Assert.IsTrue(Dmca.Contains("/legal/dmca", StringComparison.Ordinal), "Maui DMCA must use /legal/dmca route");
        Assert.IsTrue(Accessibility.Contains("/legal/accessibility", StringComparison.Ordinal), "Maui accessibility must use /legal/accessibility route");
        Assert.IsTrue(CookiePolicy.Contains("/legal/cookie-policy", StringComparison.Ordinal), "Maui cookie policy must use /legal/cookie-policy route");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui legal pages must use correct route paths for acceptable use and licenses pages")]
    public void MauiLegalPagesMustUseCorrectRoutePathsForAcceptableUseAndLicensesPages()
    {
        var AcceptableUse = ReadSourceFile("PrTask.Maui", "Pages", "Legal", "MauiAcceptableUsePage.razor");
        var Licenses = ReadSourceFile("PrTask.Maui", "Pages", "Legal", "MauiLicensesPage.razor");
        Assert.IsTrue(AcceptableUse.Contains("/legal/acceptable-use", StringComparison.Ordinal), "Maui acceptable use must use /legal/acceptable-use route");
        Assert.IsTrue(Licenses.Contains("/legal/licenses", StringComparison.Ordinal), "Maui licenses must use /legal/licenses route");
    }
}
