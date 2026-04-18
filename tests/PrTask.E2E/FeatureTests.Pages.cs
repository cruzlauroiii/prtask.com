namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Home page must have hero section with earn money headline and browse tasks call to action")]
    public void HomePageMustHaveHeroSectionWithEarnMoneyHeadlineAndBrowseTasksCallToAction()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "Home.razor");
        Assert.IsTrue(Razor.Contains("Earn Money", StringComparison.Ordinal), "Home page hero must mention earning money");
        Assert.IsTrue(Razor.Contains("Browse Tasks", StringComparison.Ordinal), "Home page must have Browse Tasks CTA button");
        Assert.IsTrue(Razor.Contains("hero", StringComparison.Ordinal), "Home page must have hero section class");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Home page must have feature cards explaining pick task submit pr and get paid workflow")]
    public void HomePageMustHaveFeatureCardsExplainingPickTaskSubmitPrAndGetPaidWorkflow()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "Home.razor");
        Assert.IsTrue(Razor.Contains("Pick a Task", StringComparison.Ordinal), "Home must explain task picking step");
        Assert.IsTrue(Razor.Contains("Submit Your PR", StringComparison.Ordinal), "Home must explain PR submission step");
        Assert.IsTrue(Razor.Contains("Get Paid", StringComparison.Ordinal), "Home must explain payment step");
        Assert.IsTrue(Razor.Contains("feature-card", StringComparison.Ordinal), "Home must use feature-card class for step cards");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Home page must have stats section showing developer payout percentage and xp earning")]
    public void HomePageMustHaveStatsSectionShowingDeveloperPayoutPercentageAndXpEarning()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "Home.razor");
        Assert.IsTrue(Razor.Contains("100%", StringComparison.Ordinal), "Home must advertise 100% developer payout");
        Assert.IsTrue(Razor.Contains("XP", StringComparison.Ordinal), "Home must mention XP earnings");
        Assert.IsTrue(Razor.Contains("stat-card", StringComparison.Ordinal), "Home must use stat-card class for metrics");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pricing page must show free pricing for both developers and clients with feature lists")]
    public void PricingPageMustShowFreePricingForBothDevelopersAndClientsWithFeatureLists()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "PricingPage.razor");
        Assert.IsTrue(Razor.Contains("For Developers", StringComparison.Ordinal), "Pricing must have developer plan section");
        Assert.IsTrue(Razor.Contains("For Clients", StringComparison.Ordinal), "Pricing must have client plan section");
        Assert.IsTrue(Razor.Contains("Free", StringComparison.Ordinal), "Pricing must show free plan amount");
        Assert.IsTrue(Razor.Contains("100%", StringComparison.Ordinal), "Pricing must mention 100% bounty payout");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pricing page must have faq section explaining payment processing timing and currency support")]
    public void PricingPageMustHaveFaqSectionExplainingPaymentProcessingTimingAndCurrencySupport()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "PricingPage.razor");
        Assert.IsTrue(Razor.Contains("pricing-faq", StringComparison.Ordinal), "Pricing must have FAQ section");
        Assert.IsTrue(Razor.Contains("How are payments processed", StringComparison.Ordinal), "Pricing FAQ must explain payment processing");
        Assert.IsTrue(Razor.Contains("When do I get paid", StringComparison.Ordinal), "Pricing FAQ must explain payment timing");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("How it works page must explain five step workflow from browsing to getting paid")]
    public void HowItWorksPageMustExplainFiveStepWorkflowFromBrowsingToGettingPaid()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "HowItWorks.razor");
        Assert.IsTrue(Razor.Contains("Browse Open Tasks", StringComparison.Ordinal), "Step 1 must explain browsing tasks");
        Assert.IsTrue(Razor.Contains("Submit a Pull Request", StringComparison.Ordinal), "Step 2 must explain PR submission");
        Assert.IsTrue(Razor.Contains("Complexity Scoring", StringComparison.Ordinal), "Step 3 must explain complexity scoring");
        Assert.IsTrue(Razor.Contains("Client Reviews", StringComparison.Ordinal), "Step 4 must explain client review");
        Assert.IsTrue(Razor.Contains("Get Paid and Level Up", StringComparison.Ordinal), "Step 5 must explain payment and leveling");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("How it works page must have for clients section with task posting and approval instructions")]
    public void HowItWorksPageMustHaveForClientsSectionWithTaskPostingAndApprovalInstructions()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "HowItWorks.razor");
        Assert.IsTrue(Razor.Contains("For Clients", StringComparison.Ordinal), "Must have dedicated section for client instructions");
        Assert.IsTrue(Razor.Contains("Create a task", StringComparison.Ordinal), "Must explain task creation for clients");
        Assert.IsTrue(Razor.Contains("approve", StringComparison.OrdinalIgnoreCase), "Must explain PR approval process for clients");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("About page must explain platform purpose with game experience and secure payment sections")]
    public void AboutPageMustExplainPlatformPurposeWithGameExperienceAndSecurePaymentSections()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "AboutPage.razor");
        Assert.IsTrue(Razor.Contains("About PrTask", StringComparison.Ordinal), "About page must have title");
        Assert.IsTrue(Razor.Contains("Game-Like Experience", StringComparison.Ordinal), "About must mention gamification");
        Assert.IsTrue(Razor.Contains("Secure Payments", StringComparison.Ordinal), "About must mention payment security");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("About page must have legal section with links to all eight legal policy pages")]
    public void AboutPageMustHaveLegalSectionWithLinksToAllEightLegalPolicyPages()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "AboutPage.razor");
        Assert.IsTrue(Razor.Contains("/legal/terms", StringComparison.Ordinal), "About must link to terms of service");
        Assert.IsTrue(Razor.Contains("/legal/privacy", StringComparison.Ordinal), "About must link to privacy policy");
        Assert.IsTrue(Razor.Contains("/legal/refund", StringComparison.Ordinal), "About must link to refund policy");
        Assert.IsTrue(Razor.Contains("/legal/dmca", StringComparison.Ordinal), "About must link to DMCA policy");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Login page must have sign in buttons for google github microsoft and okta providers")]
    public void LoginPageMustHaveSignInButtonsForGoogleGitHubMicrosoftAndOktaProviders()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "LoginPage.razor");
        Assert.IsTrue(Razor.Contains("Google", StringComparison.Ordinal), "Login must have Google sign in");
        Assert.IsTrue(Razor.Contains("GitHub", StringComparison.Ordinal), "Login must have GitHub sign in");
        Assert.IsTrue(Razor.Contains("Microsoft", StringComparison.Ordinal), "Login must have Microsoft sign in");
        Assert.IsTrue(Razor.Contains("Okta", StringComparison.Ordinal), "Login must have Okta sign in");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Login page must use route constants for sso provider authentication endpoint urls")]
    public void LoginPageMustUseRouteConstantsForSsoProviderAuthenticationEndpointUrls()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "LoginPage.razor");
        Assert.IsTrue(Razor.Contains("RouteConstants.ApiAuthGoogle", StringComparison.Ordinal), "Login must reference Google auth route constant");
        Assert.IsTrue(Razor.Contains("RouteConstants.ApiAuthGitHub", StringComparison.Ordinal), "Login must reference GitHub auth route constant");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Login page must have sections explaining benefits for both developers and clients")]
    public void LoginPageMustHaveSectionsExplainingBenefitsForBothDevelopersAndClients()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "LoginPage.razor");
        Assert.IsTrue(Razor.Contains("For Developers", StringComparison.Ordinal), "Login must explain developer benefits");
        Assert.IsTrue(Razor.Contains("For Clients", StringComparison.Ordinal), "Login must explain client benefits");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Footer section must have platform links for tasks leaderboard how it works and pricing")]
    public void FooterSectionMustHavePlatformLinksForTasksLeaderboardHowItWorksAndPricing()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Components", "FooterSection.razor");
        Assert.IsTrue(Razor.Contains("/tasks", StringComparison.Ordinal), "Footer must link to tasks page");
        Assert.IsTrue(Razor.Contains("/leaderboard", StringComparison.Ordinal), "Footer must link to leaderboard");
        Assert.IsTrue(Razor.Contains("/how-it-works", StringComparison.Ordinal), "Footer must link to how it works");
        Assert.IsTrue(Razor.Contains("/pricing", StringComparison.Ordinal), "Footer must link to pricing page");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Footer section must have legal links for terms privacy refund and acceptable use policies")]
    public void FooterSectionMustHaveLegalLinksForTermsPrivacyRefundAndAcceptableUsePolicies()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Components", "FooterSection.razor");
        Assert.IsTrue(Razor.Contains("/legal/terms", StringComparison.Ordinal), "Footer must link to terms");
        Assert.IsTrue(Razor.Contains("/legal/privacy", StringComparison.Ordinal), "Footer must link to privacy policy");
        Assert.IsTrue(Razor.Contains("/legal/refund", StringComparison.Ordinal), "Footer must link to refund policy");
        Assert.IsTrue(Razor.Contains("/legal/acceptable-use", StringComparison.Ordinal), "Footer must link to acceptable use");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Footer section must display prtask brand name tagline and current year copyright notice")]
    public void FooterSectionMustDisplayPrTaskBrandNameTaglineAndCurrentYearCopyrightNotice()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Components", "FooterSection.razor");
        Assert.IsTrue(Razor.Contains("PrTask", StringComparison.Ordinal), "Footer must display brand name");
        Assert.IsTrue(Razor.Contains("2026", StringComparison.Ordinal), "Footer must display current year copyright");
        Assert.IsTrue(Razor.Contains("footer-brand", StringComparison.Ordinal), "Footer must have brand section class");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Main layout must inherit layout component base and render nav menu with page content")]
    public void MainLayoutMustInheritLayoutComponentBaseAndRenderNavMenuWithPageContent()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Components", "MainLayout.razor");
        Assert.IsTrue(Razor.Contains("LayoutComponentBase", StringComparison.Ordinal), "MainLayout must inherit from LayoutComponentBase");
        Assert.IsTrue(Razor.Contains("NavMenu", StringComparison.Ordinal), "MainLayout must include NavMenu component");
        Assert.IsTrue(Razor.Contains("@Body", StringComparison.Ordinal), "MainLayout must render @Body for page content");
    }
}
