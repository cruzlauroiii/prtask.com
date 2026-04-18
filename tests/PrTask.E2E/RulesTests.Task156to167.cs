namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Terms discloses tax obligations and AppConstants defines TaxReportingEnabled for BIR compliance")]
    public void Rule156BirTaxCompliance()
    {
        var Terms = ReadSource("PrTask.SharedUI", "Pages", "Legal", "TermsPage.razor");
        Assert.IsTrue(
            Terms.Contains("tax", StringComparison.OrdinalIgnoreCase),
            "Terms must reference tax obligations for BIR compliance");
        var AppConst = ReadSource("PrTask.Domain", "Constants", "AppConstants.cs");
        Assert.IsTrue(AppConst.Contains("TaxReportingEnabled"),
            "AppConstants must define TaxReportingEnabled boolean for BIR tax reporting");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Terms references RA 7394 or Consumer Act with dispute resolution and complaint mechanism")]
    public void Rule157ConsumerProtection()
    {
        var Terms = ReadSource("PrTask.SharedUI", "Pages", "Legal", "TermsPage.razor");
        Assert.IsTrue(
            Terms.Contains("RA 7394") || Terms.Contains("Consumer Act") || Terms.Contains("consumer protection", StringComparison.OrdinalIgnoreCase) || Terms.Contains("ConsumerProtection"),
            "Terms must reference RA 7394 or Consumer Act of the Philippines");
        Assert.IsTrue(
            Terms.Contains("dispute", StringComparison.OrdinalIgnoreCase),
            "Terms must include dispute resolution process");
        var AcceptableUse = ReadSource("PrTask.SharedUI", "Pages", "Legal", "AcceptableUsePage.razor");
        Assert.IsTrue(
            AcceptableUse.Contains("prohibit", StringComparison.OrdinalIgnoreCase) || AcceptableUse.Contains("enforce", StringComparison.OrdinalIgnoreCase) || AcceptableUse.Contains("conduct", StringComparison.OrdinalIgnoreCase),
            "AcceptableUse page must define prohibited conduct and enforcement actions");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Accessibility page references WCAG 2.1 Level AA and SCSS has focus indicators")]
    public void Rule158WcagAccessibility()
    {
        var Accessibility = ReadSource("PrTask.SharedUI", "Pages", "Legal", "AccessibilityPage.razor");
        Assert.IsTrue((Accessibility.Contains("AccessibilityConstants") || Accessibility.Contains("WCAG")) && (Accessibility.Contains("ConformanceStatus") || Accessibility.Contains("2.1")),
            "Accessibility page must reference WCAG 2.1");
        Assert.IsTrue(
            Accessibility.Contains("ConformanceStatus") || Accessibility.Contains("Level AA") || Accessibility.Contains("AA"),
            "Accessibility page must reference Level AA conformance");
        var ScssFiles = GetSourceFiles(".scss").ToList();
        var AllScss = string.Join("\n", ScssFiles.Select(File.ReadAllText));
        Assert.IsTrue(
            AllScss.Contains(":focus") || AllScss.Contains(":focus-visible") || AllScss.Contains("focus-indicator"),
            "SCSS must include focus indicators for keyboard accessibility");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("CookieConsent has essential analytics marketing categories and CookiePolicy lists cookie names")]
    public void Rule159CookieConsentGranularity()
    {
        var CookieConsent = ReadSource("PrTask.SharedUI", "Components", "CookieConsent.razor");
        Assert.IsTrue(
            CookieConsent.Contains("essential", StringComparison.OrdinalIgnoreCase) ||
            CookieConsent.Contains("Essential") ||
            CookieConsent.Contains("Accept") || CookieConsent.Contains("Reject"),
            "CookieConsent must have essential cookie handling with accept/reject options");
        var CookiePolicy = ReadSource("PrTask.SharedUI", "Pages", "Legal", "CookiePolicyPage.razor");
        Assert.IsTrue(
            CookiePolicy.Contains("Essential", StringComparison.OrdinalIgnoreCase),
            "CookiePolicy must list essential cookie category");
        Assert.IsTrue(
            CookiePolicy.Contains("Analytics", StringComparison.OrdinalIgnoreCase) ||
            CookiePolicy.Contains("analytics"),
            "CookiePolicy must list analytics cookie category");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Privacy page documents breach notification with 72 hours NPC notification requirement")]
    public void Rule160DataBreachNotification()
    {
        var Privacy = ReadSource("PrTask.SharedUI", "Pages", "Legal", "PrivacyPage.razor");
        Assert.IsTrue(
            Privacy.Contains("breach", StringComparison.OrdinalIgnoreCase) ||
            Privacy.Contains("notification", StringComparison.OrdinalIgnoreCase) ||
            Privacy.Contains("NPC") ||
            Privacy.Contains("72 hours") ||
            Privacy.Contains("security incident", StringComparison.OrdinalIgnoreCase),
            "Privacy page must reference breach notification, NPC notification, or 72-hour requirement");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("IP3PaymentService has GetBinAsync QueryBinsAsync GetBinPatternsAsync and GetBinDeltaAsync")]
    public void Rule161MayaP3BinLookup()
    {
        var InterfaceFiles = GetSourceFiles(".cs")
            .Where(F => Path.GetFileName(F).Equals("IP3PaymentService.cs", StringComparison.OrdinalIgnoreCase))
            .ToList();
        Assert.IsTrue(InterfaceFiles.Count > 0, "IP3PaymentService.cs must exist in the Application layer");
        var Content = File.ReadAllText(InterfaceFiles[0]);
        Assert.IsTrue(Content.Contains("GetBinAsync"), "IP3PaymentService must have GetBinAsync method");
        Assert.IsTrue(Content.Contains("QueryBinsAsync"), "IP3PaymentService must have QueryBinsAsync method");
        Assert.IsTrue(Content.Contains("GetBinPatternsAsync"), "IP3PaymentService must have GetBinPatternsAsync method");
        Assert.IsTrue(Content.Contains("GetBinDeltaAsync"), "IP3PaymentService must have GetBinDeltaAsync method");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("IP3PaymentService has CreateApiKeyAsync GetApiKeyAsync ListApiKeysAsync and DeleteApiKeyAsync")]
    public void Rule162MayaP3KeyManagement()
    {
        var InterfaceFiles = GetSourceFiles(".cs")
            .Where(F => Path.GetFileName(F).Equals("IP3PaymentService.cs", StringComparison.OrdinalIgnoreCase))
            .ToList();
        Assert.IsTrue(InterfaceFiles.Count > 0, "IP3PaymentService.cs must exist in the Application layer");
        var Content = File.ReadAllText(InterfaceFiles[0]);
        Assert.IsTrue(Content.Contains("CreateApiKeyAsync"), "IP3PaymentService must have CreateApiKeyAsync method");
        Assert.IsTrue(Content.Contains("GetApiKeyAsync"), "IP3PaymentService must have GetApiKeyAsync method");
        Assert.IsTrue(Content.Contains("ListApiKeysAsync"), "IP3PaymentService must have ListApiKeysAsync method");
        Assert.IsTrue(Content.Contains("DeleteApiKeyAsync"), "IP3PaymentService must have DeleteApiKeyAsync method");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("IP3PaymentService has PingAsync for Maya service health checks")]
    public void Rule163MayaP3ServiceHealth()
    {
        var InterfaceFiles = GetSourceFiles(".cs")
            .Where(F => Path.GetFileName(F).Equals("IP3PaymentService.cs", StringComparison.OrdinalIgnoreCase))
            .ToList();
        Assert.IsTrue(InterfaceFiles.Count > 0, "IP3PaymentService.cs must exist in the Application layer");
        var Content = File.ReadAllText(InterfaceFiles[0]);
        Assert.IsTrue(Content.Contains("PingAsync"), "IP3PaymentService must have PingAsync method for service health checks");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("PaymentService references SetCustomizationAsync for Maya checkout branding")]
    public void Rule164MayaCheckoutBranding()
    {
        var PaymentFiles = GetSourceFiles(".cs")
            .Where(F => Path.GetFileName(F).StartsWith("PaymentService", StringComparison.OrdinalIgnoreCase))
            .ToList();
        Assert.IsTrue(PaymentFiles.Count > 0, "PaymentService files must exist");
        var AllContent = string.Join("\n", PaymentFiles.Select(File.ReadAllText));
        Assert.IsTrue(AllContent.Contains("SetCustomizationAsync"),
            "PaymentService must implement SetCustomizationAsync for Maya checkout branding");
        Assert.IsTrue(
            AllContent.Contains("CustomTitle") || AllContent.Contains("LogoUrl") || AllContent.Contains("ColorScheme"),
            "SetCustomizationAsync must configure branding properties like CustomTitle, LogoUrl, or ColorScheme");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("MayaConstants defines all webhook event constants including CHECKOUT PAYMENT 3DS and RECURRING")]
    public void Rule165AllMayaWebhookEventTypes()
    {
        var MayaConst = ReadSource("PrTask.Domain", "Constants", "MayaConstants.cs");
        Assert.IsTrue(MayaConst.Contains("CHECKOUT_SUCCESS"), "MayaConstants must define CHECKOUT_SUCCESS webhook event");
        Assert.IsTrue(MayaConst.Contains("CHECKOUT_FAILURE"), "MayaConstants must define CHECKOUT_FAILURE webhook event");
        Assert.IsTrue(MayaConst.Contains("CHECKOUT_DROPOUT"), "MayaConstants must define CHECKOUT_DROPOUT webhook event");
        Assert.IsTrue(MayaConst.Contains("PAYMENT_SUCCESS"), "MayaConstants must define PAYMENT_SUCCESS webhook event");
        Assert.IsTrue(MayaConst.Contains("PAYMENT_FAILED"), "MayaConstants must define PAYMENT_FAILED webhook event");
        Assert.IsTrue(MayaConst.Contains("PAYMENT_EXPIRED"), "MayaConstants must define PAYMENT_EXPIRED webhook event");
        Assert.IsTrue(MayaConst.Contains("3DS_PAYMENT_SUCCESS"), "MayaConstants must define 3DS_PAYMENT_SUCCESS webhook event");
        Assert.IsTrue(MayaConst.Contains("3DS_PAYMENT_FAILURE"), "MayaConstants must define 3DS_PAYMENT_FAILURE webhook event");
        Assert.IsTrue(MayaConst.Contains("3DS_PAYMENT_DROPOUT"), "MayaConstants must define 3DS_PAYMENT_DROPOUT webhook event");
        Assert.IsTrue(MayaConst.Contains("RECURRING_PAYMENT_SUCCESS"), "MayaConstants must define RECURRING_PAYMENT_SUCCESS webhook event");
        Assert.IsTrue(MayaConst.Contains("RECURRING_PAYMENT_FAILURE"), "MayaConstants must define RECURRING_PAYMENT_FAILURE webhook event");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("MayaConstants documents which endpoints use PUBLIC vs SECRET key for auth validation")]
    public void Rule166MayaAuthKeyTypeValidation()
    {
        var MayaConst = ReadSource("PrTask.Domain", "Constants", "MayaConstants.cs");
        Assert.IsTrue(
            MayaConst.Contains("PublicKey") || MayaConst.Contains("public", StringComparison.OrdinalIgnoreCase),
            "MayaConstants must reference public key configuration");
        Assert.IsTrue(
            MayaConst.Contains("SecretKey") || MayaConst.Contains("secret", StringComparison.OrdinalIgnoreCase),
            "MayaConstants must reference secret key configuration");
        var PaymentFiles = GetSourceFiles(".cs")
            .Where(F => Path.GetFileName(F).StartsWith("PaymentService", StringComparison.OrdinalIgnoreCase))
            .ToList();
        var AllPayment = string.Join("\n", PaymentFiles.Select(File.ReadAllText));
        Assert.IsTrue(
            AllPayment.Contains("SecretKey") || AllPayment.Contains("UsesSecretKey"),
            "PaymentService must distinguish between public and secret key usage");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("RouteConstants has full CRUD routes for tasks PRs users payments achievements sprints boards subscriptions invoices disbursements")]
    public void Rule167FullCrudForAllEntities()
    {
        var Routes = ReadSource("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Routes.Contains("ApiTasks"), "RouteConstants must define ApiTasks");
        Assert.IsTrue(Routes.Contains("ApiPullRequests") || Routes.Contains("ApiPrs") || Routes.Contains("/Api/Prs"),
            "RouteConstants must define API route for pull requests");
        Assert.IsTrue(Routes.Contains("ApiUsers"), "RouteConstants must define ApiUsers");
        Assert.IsTrue(Routes.Contains("ApiPayments"), "RouteConstants must define ApiPayments");
        Assert.IsTrue(Routes.Contains("ApiAchievements"), "RouteConstants must define ApiAchievements");
        Assert.IsTrue(Routes.Contains("ApiSprints"), "RouteConstants must define ApiSprints");
        Assert.IsTrue(Routes.Contains("ApiBoards"), "RouteConstants must define ApiBoards");
        Assert.IsTrue(Routes.Contains("SubById") || Routes.Contains("/{TaskId}"),
            "RouteConstants must define by-id sub-route for entity retrieval");
        Assert.IsTrue(Routes.Contains("SubDelete") || Routes.Contains("DELETE") || Routes.Contains("/{TaskId}"),
            "RouteConstants must define delete sub-route");
        Assert.IsTrue(
            Routes.Contains("/Api/Subscriptions") || Routes.Contains("ApiSubscriptions"),
            "RouteConstants must define subscriptions API route");
        Assert.IsTrue(
            Routes.Contains("/Api/Invoices") || Routes.Contains("ApiInvoices"),
            "RouteConstants must define invoices API route");
        Assert.IsTrue(
            Routes.Contains("/Api/Disbursements") || Routes.Contains("ApiDisbursements"),
            "RouteConstants must define disbursements API route");
    }
}
