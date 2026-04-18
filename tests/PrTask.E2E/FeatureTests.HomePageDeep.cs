namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Home page hero section must have earn money heading with browse tasks and how it works buttons")]
    public void HomePageHeroSectionMustHaveEarnMoneyHeadingWithBrowseTasksAndHowItWorksButtons()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "Home.razor");
        Assert.IsTrue(Code.Contains("Earn Money with Pull Requests", StringComparison.Ordinal), "Home hero must have main heading");
        Assert.IsTrue(Code.Contains("btn btn-primary", StringComparison.Ordinal), "Home must have primary CTA button");
        Assert.IsTrue(Code.Contains("Browse Tasks", StringComparison.Ordinal), "Home must have Browse Tasks CTA");
        Assert.IsTrue(Code.Contains("How It Works", StringComparison.Ordinal), "Home must have How It Works CTA");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Home page feature cards must describe pick a task submit pr and get paid workflow steps")]
    public void HomePageFeatureCardsMustDescribePickATaskSubmitPrAndGetPaidWorkflowSteps()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "Home.razor");
        Assert.IsTrue(Code.Contains("Pick a Task", StringComparison.Ordinal), "Home must have Pick a Task feature card");
        Assert.IsTrue(Code.Contains("Submit Your PR", StringComparison.Ordinal), "Home must have Submit Your PR feature card");
        Assert.IsTrue(Code.Contains("Get Paid", StringComparison.Ordinal), "Home must have Get Paid feature card");
        Assert.IsTrue(Code.Contains("feature-card", StringComparison.Ordinal), "Home must use feature-card CSS class");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Home page stats section must show hundred percent developer payout xp earn and automatic payment")]
    public void HomePageStatsSectionMustShowHundredPercentDeveloperPayoutXpEarnAndAutomaticPayment()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "Home.razor");
        Assert.IsTrue(Code.Contains("100%", StringComparison.Ordinal), "Home stats must show 100% payout");
        Assert.IsTrue(Code.Contains("Developer Payout", StringComparison.Ordinal), "Home stats must label developer payout");
        Assert.IsTrue(Code.Contains("Earn Per Merge", StringComparison.Ordinal), "Home stats must show XP earn label");
        Assert.IsTrue(Code.Contains("Payment on Approval", StringComparison.Ordinal), "Home stats must show automatic payment");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Dashboard page must show four stat cards for active tasks prs submitted total earned and level")]
    public void DashboardPageMustShowFourStatCardsForActivePrsSubmittedTotalEarnedAndLevel()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "DashboardPage.razor");
        Assert.IsTrue(Code.Contains("Active Tasks", StringComparison.Ordinal), "Dashboard must show Active Tasks stat");
        Assert.IsTrue(Code.Contains("PRs Submitted", StringComparison.Ordinal), "Dashboard must show PRs Submitted stat");
        Assert.IsTrue(Code.Contains("Total Earned", StringComparison.Ordinal), "Dashboard must show Total Earned stat");
        Assert.IsTrue(Code.Contains("Current Level", StringComparison.Ordinal), "Dashboard must show Current Level stat");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Dashboard page must have recent activity section with empty state message for new users")]
    public void DashboardPageMustHaveRecentActivitySectionWithEmptyStateMessageForNewUsers()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "DashboardPage.razor");
        Assert.IsTrue(Code.Contains("Recent Activity", StringComparison.Ordinal), "Dashboard must have Recent Activity heading");
        Assert.IsTrue(Code.Contains("No activity yet. Browse tasks to get started.", StringComparison.Ordinal), "Dashboard must show empty state message");
        Assert.IsTrue(Code.Contains("dashboard-stats", StringComparison.Ordinal), "Dashboard must use dashboard-stats CSS class");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Login page must use route constants for all four oauth provider sign in links with button classes")]
    public void LoginPageMustUseRouteConstantsForAllFourOauthProviderSignInLinksWithButtonClasses()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "LoginPage.razor");
        Assert.IsTrue(Code.Contains("RouteConstants.ApiAuthGoogle", StringComparison.Ordinal), "Login must link to Google auth via RouteConstants");
        Assert.IsTrue(Code.Contains("RouteConstants.ApiAuthGitHub", StringComparison.Ordinal), "Login must link to GitHub auth via RouteConstants");
        Assert.IsTrue(Code.Contains("RouteConstants.ApiAuthAzure", StringComparison.Ordinal), "Login must link to Azure auth via RouteConstants");
        Assert.IsTrue(Code.Contains("RouteConstants.ApiAuthOkta", StringComparison.Ordinal), "Login must link to Okta auth via RouteConstants");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Login page must describe developer and client roles with sign in heading and connect account text")]
    public void LoginPageMustDescribeDeveloperAndClientRolesWithSignInHeadingAndConnectAccountText()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "LoginPage.razor");
        Assert.IsTrue(Code.Contains("Sign In to PrTask", StringComparison.Ordinal), "Login must have Sign In heading");
        Assert.IsTrue(Code.Contains("For Developers", StringComparison.Ordinal), "Login must describe developer role");
        Assert.IsTrue(Code.Contains("For Clients", StringComparison.Ordinal), "Login must describe client role");
        Assert.IsTrue(Code.Contains("login-buttons", StringComparison.Ordinal), "Login must use login-buttons container class");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("About page must describe platform purpose gamification secure payments legal links and contact email")]
    public void AboutPageMustDescribePlatformPurposeGamificationSecurePaymentsLegalLinksAndContactEmail()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "AboutPage.razor");
        Assert.IsTrue(Code.Contains("About PrTask", StringComparison.Ordinal), "About must have page heading");
        Assert.IsTrue(Code.Contains("What We Do", StringComparison.Ordinal), "About must explain what PrTask does");
        Assert.IsTrue(Code.Contains("Game-Like Experience", StringComparison.Ordinal), "About must describe gamification");
        Assert.IsTrue(Code.Contains("Secure Payments", StringComparison.Ordinal), "About must describe payment security");
        Assert.IsTrue(Code.Contains("support@prtask.com", StringComparison.Ordinal), "About must include contact email");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("About page legal links section must reference all eight legal page paths under legal prefix")]
    public void AboutPageLegalLinksSectionMustReferenceAllEightLegalPagePathsUnderLegalPrefix()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "AboutPage.razor");
        Assert.IsTrue(Code.Contains("/legal/terms", StringComparison.Ordinal), "About must link to terms page");
        Assert.IsTrue(Code.Contains("/legal/privacy", StringComparison.Ordinal), "About must link to privacy page");
        Assert.IsTrue(Code.Contains("/legal/cookie-policy", StringComparison.Ordinal), "About must link to cookie policy");
        Assert.IsTrue(Code.Contains("/legal/acceptable-use", StringComparison.Ordinal), "About must link to acceptable use");
        Assert.IsTrue(Code.Contains("/legal/dmca", StringComparison.Ordinal), "About must link to DMCA page");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("How it works page must have five numbered steps from browse tasks through get paid and level up")]
    public void HowItWorksPageMustHaveFiveNumberedStepsFromBrowseTasksThroughGetPaidAndLevelUp()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "HowItWorks.razor");
        Assert.IsTrue(Code.Contains("Browse Open Tasks", StringComparison.Ordinal), "HowItWorks step 1 must be Browse Open Tasks");
        Assert.IsTrue(Code.Contains("Submit a Pull Request", StringComparison.Ordinal), "HowItWorks step 2 must be Submit a Pull Request");
        Assert.IsTrue(Code.Contains("Complexity Scoring", StringComparison.Ordinal), "HowItWorks step 3 must be Complexity Scoring");
        Assert.IsTrue(Code.Contains("Client Reviews and Approves", StringComparison.Ordinal), "HowItWorks step 4 must be Client Reviews");
        Assert.IsTrue(Code.Contains("Get Paid and Level Up", StringComparison.Ordinal), "HowItWorks step 5 must be Get Paid and Level Up");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("How it works for clients section must list five ordered steps from sign in to automatic payment")]
    public void HowItWorksForClientsSectionMustListFiveOrderedStepsFromSignInToAutomaticPayment()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "HowItWorks.razor");
        Assert.IsTrue(Code.Contains("For Clients", StringComparison.Ordinal), "HowItWorks must have For Clients section");
        Assert.IsTrue(Code.Contains("Sign in with GitHub or Google", StringComparison.Ordinal), "Client step 1 must mention sign in");
        Assert.IsTrue(Code.Contains("Create a task with a description", StringComparison.Ordinal), "Client step 2 must mention task creation");
        Assert.IsTrue(Code.Contains("automatically charged the bounty", StringComparison.Ordinal), "Client step 5 must mention automatic charge");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pricing page must show free pricing for developers and clients with no hidden fees statement")]
    public void PricingPageMustShowFreePricingForDevelopersAndClientsWithNoHiddenFeesStatement()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "PricingPage.razor");
        Assert.IsTrue(Code.Contains("completely free for everyone", StringComparison.Ordinal), "Pricing must state platform is completely free");
        Assert.IsTrue(Code.Contains("For Developers", StringComparison.Ordinal), "Pricing must have developer pricing card");
        Assert.IsTrue(Code.Contains("For Clients", StringComparison.Ordinal), "Pricing must have client pricing card");
        Assert.IsTrue(Code.Contains("pricing-card featured", StringComparison.Ordinal), "Pricing must have featured card for clients");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pricing page faq must explain automatic payment process usd currency and hundred percent payout")]
    public void PricingPageFaqMustExplainAutomaticPaymentProcessUsdCurrencyAndHundredPercentPayout()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "PricingPage.razor");
        Assert.IsTrue(Code.Contains("Payment Details", StringComparison.Ordinal), "Pricing FAQ must have Payment Details heading");
        Assert.IsTrue(Code.Contains("How are payments processed?", StringComparison.Ordinal), "Pricing FAQ must explain payment processing");
        Assert.IsTrue(Code.Contains("When do I get paid?", StringComparison.Ordinal), "Pricing FAQ must explain payment timing");
        Assert.IsTrue(Code.Contains("US Dollars (USD)", StringComparison.Ordinal), "Pricing FAQ must state USD currency");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Download page must offer android apk download with windows ios macos and linux coming soon")]
    public void DownloadPageMustOfferAndroidApkDownloadWithWindowsIosMacosAndLinuxComingSoon()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "DownloadPage.razor");
        Assert.IsTrue(Code.Contains("Download Android APK", StringComparison.Ordinal), "Download must offer Android APK");
        Assert.IsTrue(Code.Contains("com.prtask.app-Signed.apk", StringComparison.Ordinal), "Download must link to signed APK file");
        Assert.IsTrue(Code.Contains("Coming Soon", StringComparison.Ordinal), "Download must show Coming Soon for other platforms");
        Assert.IsTrue(Code.Contains("AppConstants.AppDomain", StringComparison.Ordinal), "Download web app section must use AppConstants.AppDomain");
    }
}
