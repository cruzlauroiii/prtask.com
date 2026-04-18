namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("LoginConstants has benefit and step constants")]
    public void LoginConstantsHasBenefitAndStepConstants()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "LoginConstants.cs");
        Assert.IsTrue(Source.Contains("WhyPrTaskHeading"), "Has WhyPrTaskHeading");
        Assert.IsTrue(Source.Contains("BenefitEarnMoneyHeading"), "Has BenefitEarnMoneyHeading");
        Assert.IsTrue(Source.Contains("StepSignInHeading"), "Has StepSignInHeading");
        Assert.IsTrue(Source.Contains("SecurityHeading"), "Has SecurityHeading");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("LoginPage uses LoginConstants for benefit sections")]
    public void LoginPageUsesLoginConstantsForBenefitSections()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "LoginPage.razor");
        Assert.IsTrue(Source.Contains("LoginConstants.WhyPrTaskHeading") || Source.Contains("LoginWhyPrTaskHeading"), "Uses WhyPrTaskHeading via constant or localization");
        Assert.IsTrue(Source.Contains("LoginConstants.SecurityHeading") || Source.Contains("LoginSecurityHeading"), "Uses SecurityHeading via constant or localization");
        Assert.IsFalse(Source.Contains("\"Why PrTask"), "No hardcoded Why PrTask string");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("AboutConstants has mission values and stats")]
    public void AboutConstantsHasMissionValuesAndStats()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "AboutConstants.cs");
        Assert.IsTrue(Source.Contains("MissionHeading"), "Has MissionHeading");
        Assert.IsTrue(Source.Contains("ValuesHeading"), "Has ValuesHeading");
        Assert.IsTrue(Source.Contains("CommunityHeading"), "Has CommunityHeading");
        Assert.IsTrue(Source.Contains("StatTasksLabel"), "Has StatTasksLabel");
        Assert.IsTrue(Source.Contains("OpenSourceHeading"), "Has OpenSourceHeading");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("AboutPage uses AboutConstants for all new sections")]
    public void AboutPageUsesAboutConstantsForAllNewSections()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "AboutPage.razor");
        Assert.IsTrue(Source.Contains("AboutConstants.MissionHeading") || Source.Contains("AboutMissionHeading"), "Uses MissionHeading via constant or localization");
        Assert.IsTrue(Source.Contains("AboutConstants.ValuesHeading") || Source.Contains("AboutValuesHeading"), "Uses ValuesHeading via constant or localization");
        Assert.IsTrue(Source.Contains("AboutConstants.CommunityHeading") || Source.Contains("AboutCommunityHeading"), "Uses CommunityHeading via constant or localization");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("DownloadConstants has system requirements and troubleshooting")]
    public void DownloadConstantsHasSystemRequirementsAndTroubleshooting()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "DownloadConstants.cs");
        Assert.IsTrue(Source.Contains("SystemRequirementsHeading"), "Has SystemRequirementsHeading");
        Assert.IsTrue(Source.Contains("AndroidRequirements"), "Has AndroidRequirements");
        Assert.IsTrue(Source.Contains("TroubleshootingHeading"), "Has TroubleshootingHeading");
        Assert.IsTrue(Source.Contains("FeatureComparisonHeading"), "Has FeatureComparisonHeading");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("DownloadPage uses DownloadConstants for all new sections")]
    public void DownloadPageUsesDownloadConstantsForAllNewSections()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "DownloadPage.razor");
        Assert.IsTrue(Source.Contains("DownloadConstants.SystemRequirementsHeading") || Source.Contains("DownloadSystemRequirementsHeading"), "Uses SystemRequirementsHeading via constant or localization");
        Assert.IsTrue(Source.Contains("DownloadConstants.TroubleshootingHeading") || Source.Contains("DownloadTroubleshootingHeading"), "Uses TroubleshootingHeading via constant or localization");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("PricingConstants has comparison and enterprise constants")]
    public void PricingConstantsHasComparisonAndEnterpriseConstants()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "PricingConstants.cs");
        Assert.IsTrue(Source.Contains("ComparisonHeading"), "Has ComparisonHeading");
        Assert.IsTrue(Source.Contains("EnterpriseHeading"), "Has EnterpriseHeading");
        Assert.IsTrue(Source.Contains("PaymentMethodsHeading"), "Has PaymentMethodsHeading");
        Assert.IsTrue(Source.Contains("GetStartedHeading"), "Has GetStartedHeading");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("PricingPage uses PricingConstants for all new sections")]
    public void PricingPageUsesPricingConstantsForAllNewSections()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "PricingPage.razor");
        Assert.IsTrue(Source.Contains("PricingConstants.ComparisonHeading") || Source.Contains("PricingComparisonHeading"), "Uses ComparisonHeading via constant or localization");
        Assert.IsTrue(Source.Contains("PricingConstants.EnterpriseHeading") || Source.Contains("PricingEnterpriseHeading"), "Uses EnterpriseHeading via constant or localization");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("PaymentEndpoints Vault exists with card vault endpoints")]
    public void PaymentEndpointsVaultExistsWithCardVaultEndpoints()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "PaymentEndpoints.Vault.cs");
        Assert.IsTrue(Source.Contains("MapGet"), "Has MapGet");
        Assert.IsTrue(Source.Contains("MapPost"), "Has MapPost");
        Assert.IsTrue(Source.Contains("MapDelete"), "Has MapDelete");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("PaymentEndpoints Operations exists with capture and cancel")]
    public void PaymentEndpointsOperationsExistsWithCaptureAndCancel()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "PaymentEndpoints.Operations.cs");
        Assert.IsTrue(Source.Contains("Capture") || Source.Contains("capture"), "Has capture endpoint");
        Assert.IsTrue(Source.Contains("Cancel") || Source.Contains("cancel"), "Has cancel endpoint");
    }
}
