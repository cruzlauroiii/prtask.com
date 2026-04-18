using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("CookieConsentConstants has all UI text")]
    public void CookieConsentConstantsHasAllUiText()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "CookieConsentConstants.cs");
        Assert.IsTrue(Source.Contains("ConsentMessage"), "Has ConsentMessage");
        Assert.IsTrue(Source.Contains("CookiePolicyLinkText"), "Has CookiePolicyLinkText");
        Assert.IsTrue(Source.Contains("ManagePreferencesMessage"), "Has ManagePreferencesMessage");
        Assert.IsTrue(Source.Contains("EssentialLabel"), "Has EssentialLabel");
        Assert.IsTrue(Source.Contains("AnalyticsLabel"), "Has AnalyticsLabel");
        Assert.IsTrue(Source.Contains("MarketingLabel"), "Has MarketingLabel");
        Assert.IsTrue(Source.Contains("AcceptAllButtonText"), "Has AcceptAllButtonText");
        Assert.IsTrue(Source.Contains("RejectAllButtonText"), "Has RejectAllButtonText");
        Assert.IsTrue(Source.Contains("CustomizeButtonText"), "Has CustomizeButtonText");
        Assert.IsTrue(Source.Contains("SavePreferencesButtonText"), "Has SavePreferencesButtonText");
        Assert.IsTrue(Source.Contains("BackButtonText"), "Has BackButtonText");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("CookieConsent component uses CookieConsentConstants")]
    public void CookieConsentComponentUsesConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Components", "CookieConsent.razor");
        Assert.IsTrue(Source.Contains("CookieConsentConstants.ConsentMessage") || Source.Contains("CookieConsentMessage"), "Uses ConsentMessage via constant or localization");
        Assert.IsTrue(Source.Contains("CookieConsentConstants.AcceptAllButtonText") || Source.Contains("CookieAcceptAllButton"), "Uses AcceptAllButtonText via constant or localization");
        Assert.IsTrue(Source.Contains("CookieConsentConstants.RejectAllButtonText") || Source.Contains("CookieRejectAllButton"), "Uses RejectAllButtonText via constant or localization");
        Assert.IsTrue(Source.Contains("CookieConsentConstants.CustomizeButtonText") || Source.Contains("CookieCustomizeButton"), "Uses CustomizeButtonText via constant or localization");
        Assert.IsFalse(Source.Contains("\"We use cookies\""), "No hardcoded consent message");
        Assert.IsFalse(Source.Contains("\"Accept All\""), "No hardcoded Accept All");
        Assert.IsFalse(Source.Contains("\"Reject All\""), "No hardcoded Reject All");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SeoConstants has default meta tag constants")]
    public void SeoConstantsHasDefaultMetaTags()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "SeoConstants.cs");
        Assert.IsTrue(Source.Contains("DefaultTitle"), "Has DefaultTitle");
        Assert.IsTrue(Source.Contains("DefaultDescription"), "Has DefaultDescription");
        Assert.IsTrue(Source.Contains("DefaultOgTitle"), "Has DefaultOgTitle");
        Assert.IsTrue(Source.Contains("DefaultOgDescription"), "Has DefaultOgDescription");
        Assert.IsTrue(Source.Contains("DefaultOgUrl"), "Has DefaultOgUrl");
        Assert.IsTrue(Source.Contains("DefaultOgSiteName"), "Has DefaultOgSiteName");
        Assert.IsTrue(Source.Contains("DefaultTwitterTitle"), "Has DefaultTwitterTitle");
        Assert.IsTrue(Source.Contains("DefaultTwitterDescription"), "Has DefaultTwitterDescription");
        Assert.IsTrue(Source.Contains("DefaultCanonicalUrl"), "Has DefaultCanonicalUrl");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("App.razor uses SeoConstants for meta tags")]
    public void AppRazorUsesSeoConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Components", "App.razor");
        Assert.IsTrue(Source.Contains("SeoConstants.DefaultTitle"), "Uses DefaultTitle");
        Assert.IsTrue(Source.Contains("SeoConstants.DefaultDescription"), "Uses DefaultDescription");
        Assert.IsTrue(Source.Contains("SeoConstants.DefaultOgUrl"), "Uses DefaultOgUrl");
        Assert.IsFalse(Source.Contains("\"prtask.com\""), "No hardcoded site domain");
        Assert.IsFalse(Source.Contains("\"https://prtask.com\""), "No hardcoded site URL");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("AppConstants has PageNotFound text constants")]
    public void AppConstantsHasPageNotFoundText()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "AppConstants.cs");
        Assert.IsTrue(Source.Contains("PageNotFoundTitle"), "Has PageNotFoundTitle");
        Assert.IsTrue(Source.Contains("PageNotFoundMessage"), "Has PageNotFoundMessage");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Routes.razor uses AppConstants for error messages")]
    public void RoutesRazorUsesAppConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Components", "Routes.razor");
        Assert.IsTrue(Source.Contains("AppConstants.PageNotFoundTitle"), "Uses PageNotFoundTitle");
        Assert.IsTrue(Source.Contains("AppConstants.PageNotFoundMessage"), "Uses PageNotFoundMessage");
        Assert.IsFalse(Source.Contains("\"Page Not Found\""), "No hardcoded Page Not Found");
        Assert.IsFalse(Source.Contains("\"The page you requested\""), "No hardcoded error message");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("CookieConsentConstants has preference labels and descriptions")]
    public void CookieConsentConstantsHasPreferenceDescriptions()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "CookieConsentConstants.cs");
        Assert.IsTrue(Source.Contains("EssentialDescription"), "Has EssentialDescription");
        Assert.IsTrue(Source.Contains("AnalyticsDescription"), "Has AnalyticsDescription");
        Assert.IsTrue(Source.Contains("MarketingDescription"), "Has MarketingDescription");
    }
}
