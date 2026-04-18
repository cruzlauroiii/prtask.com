namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Home page hero section must have earn money heading with browse tasks and how it works links")]
    public void HomePageHeroSectionMustHaveEarnMoneyHeadingWithBrowseTasksAndHowItWorksLinks()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "Home.razor");
        Assert.IsTrue(Code.Contains("Earn Money with Pull Requests", StringComparison.Ordinal), "Home hero must have earn money heading");
        Assert.IsTrue(Code.Contains("hero-actions", StringComparison.Ordinal), "Home must have hero-actions div for CTA buttons");
        Assert.IsTrue(Code.Contains("href=\"/tasks\"", StringComparison.Ordinal), "Home must link to tasks page from hero");
        Assert.IsTrue(Code.Contains("href=\"/how-it-works\"", StringComparison.Ordinal), "Home must link to how it works page from hero");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Home page hero subtitle must describe browsing tasks submitting prs and climbing leaderboard")]
    public void HomePageHeroSubtitleMustDescribeBrowsingTasksSubmittingPrsAndClimbingLeaderboard()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "Home.razor");
        Assert.IsTrue(Code.Contains("hero-subtitle", StringComparison.Ordinal), "Home must have hero-subtitle paragraph");
        Assert.IsTrue(Code.Contains("Browse tasks", StringComparison.Ordinal), "Hero subtitle must mention browsing tasks");
        Assert.IsTrue(Code.Contains("submit PRs", StringComparison.Ordinal), "Hero subtitle must mention submitting PRs");
        Assert.IsTrue(Code.Contains("leaderboard", StringComparison.Ordinal), "Hero subtitle must mention the leaderboard");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Home page feature cards must have pick task submit pr and get paid steps with descriptions")]
    public void HomePageFeatureCardsMustHavePickTaskSubmitPrAndGetPaidStepsWithDescriptions()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "Home.razor");
        Assert.IsTrue(Code.Contains("Pick a Task", StringComparison.Ordinal), "Feature cards must include Pick a Task step");
        Assert.IsTrue(Code.Contains("Submit Your PR", StringComparison.Ordinal), "Feature cards must include Submit Your PR step");
        Assert.IsTrue(Code.Contains("Get Paid", StringComparison.Ordinal), "Feature cards must include Get Paid step");
        Assert.IsTrue(Code.Contains("feature-card", StringComparison.Ordinal), "Home must use feature-card class for steps");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Home page stats section must show hundred percent developer payout and automatic payment labels")]
    public void HomePageStatsSectionMustShowHundredPercentDeveloperPayoutAndAutomaticPaymentLabels()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "Home.razor");
        Assert.IsTrue(Code.Contains("100%", StringComparison.Ordinal), "Stats must show 100% developer payout value");
        Assert.IsTrue(Code.Contains("Developer Payout", StringComparison.Ordinal), "Stats must label 100% as Developer Payout");
        Assert.IsTrue(Code.Contains("Automatic", StringComparison.Ordinal), "Stats must show Automatic payment value");
        Assert.IsTrue(Code.Contains("Payment on Approval", StringComparison.Ordinal), "Stats must label automatic as Payment on Approval");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Home page stats section must show xp earn per merge stat card with stat value class")]
    public void HomePageStatsSectionMustShowXpEarnPerMergeStatCardWithStatValueClass()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "Home.razor");
        Assert.IsTrue(Code.Contains("stat-card", StringComparison.Ordinal), "Home must use stat-card class for stat items");
        Assert.IsTrue(Code.Contains("stat-value", StringComparison.Ordinal), "Stat items must use stat-value class for numbers");
        Assert.IsTrue(Code.Contains("stat-label", StringComparison.Ordinal), "Stat items must use stat-label class for text");
        Assert.IsTrue(Code.Contains("Earn Per Merge", StringComparison.Ordinal), "Stats must label XP as Earn Per Merge");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Dashboard page must have four stat cards showing active tasks prs submitted total earned and level")]
    public void DashboardPageMustHaveFourStatCardsShowingActiveTasksPrsSubmittedTotalEarnedAndLevel()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "DashboardPage.razor");
        Assert.IsTrue(Code.Contains("Active Tasks", StringComparison.Ordinal), "Dashboard must show Active Tasks stat label");
        Assert.IsTrue(Code.Contains("PRs Submitted", StringComparison.Ordinal), "Dashboard must show PRs Submitted stat label");
        Assert.IsTrue(Code.Contains("Total Earned", StringComparison.Ordinal), "Dashboard must show Total Earned stat label");
        Assert.IsTrue(Code.Contains("Current Level", StringComparison.Ordinal), "Dashboard must show Current Level stat label");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Dashboard page must have empty state section with browse tasks call to action message")]
    public void DashboardPageMustHaveEmptyStateSectionWithBrowseTasksCallToActionMessage()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "DashboardPage.razor");
        Assert.IsTrue(Code.Contains("empty-state", StringComparison.Ordinal), "Dashboard must have empty-state div for no activity");
        Assert.IsTrue(Code.Contains("No activity yet", StringComparison.Ordinal), "Empty state must show no activity message");
        Assert.IsTrue(Code.Contains("Browse tasks to get started", StringComparison.Ordinal), "Empty state must suggest browsing tasks");
        Assert.IsTrue(Code.Contains("Recent Activity", StringComparison.Ordinal), "Dashboard must have Recent Activity heading");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pricing page must have developer and client cards both showing free with pricing amount class")]
    public void PricingPageMustHaveDeveloperAndClientCardsBothShowingFreeWithPricingAmountClass()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "PricingPage.razor");
        Assert.IsTrue(Code.Contains("For Developers", StringComparison.Ordinal), "Pricing must have For Developers card heading");
        Assert.IsTrue(Code.Contains("For Clients", StringComparison.Ordinal), "Pricing must have For Clients card heading");
        Assert.IsTrue(Code.Contains("pricing-amount", StringComparison.Ordinal), "Pricing cards must use pricing-amount class");
        Assert.IsTrue(Code.Contains(">Free<", StringComparison.Ordinal), "Pricing amount must show Free for both tiers");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pricing page client card must have featured class and list automatic payment on approval")]
    public void PricingPageClientCardMustHaveFeaturedClassAndListAutomaticPaymentOnApproval()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "PricingPage.razor");
        Assert.IsTrue(Code.Contains("pricing-card featured", StringComparison.Ordinal), "Client pricing card must have featured class");
        Assert.IsTrue(Code.Contains("Automatic payment on PR approval", StringComparison.Ordinal), "Client card must mention automatic payment on approval");
        Assert.IsTrue(Code.Contains("Post unlimited tasks", StringComparison.Ordinal), "Client card must allow unlimited task posting");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pricing page faq section must describe usd currency and hundred percent developer payout")]
    public void PricingPageFaqSectionMustDescribeUsdCurrencyAndHundredPercentDeveloperPayout()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "PricingPage.razor");
        Assert.IsTrue(Code.Contains("pricing-faq", StringComparison.Ordinal), "Pricing must have pricing-faq section");
        Assert.IsTrue(Code.Contains("Payment Details", StringComparison.Ordinal), "FAQ section must have Payment Details heading");
        Assert.IsTrue(Code.Contains("US Dollars (USD)", StringComparison.Ordinal), "FAQ must mention USD currency");
        Assert.IsTrue(Code.Contains("100% of the bounty", StringComparison.Ordinal), "FAQ must state developers receive 100% of bounty");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("How it works page must have five numbered steps with step number class for visual ordering")]
    public void HowItWorksPageMustHaveFiveNumberedStepsWithStepNumberClassForVisualOrdering()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "HowItWorks.razor");
        Assert.IsTrue(Code.Contains("step-number\">1<", StringComparison.Ordinal), "Must have step number 1");
        Assert.IsTrue(Code.Contains("step-number\">2<", StringComparison.Ordinal), "Must have step number 2");
        Assert.IsTrue(Code.Contains("step-number\">3<", StringComparison.Ordinal), "Must have step number 3");
        Assert.IsTrue(Code.Contains("step-number\">4<", StringComparison.Ordinal), "Must have step number 4");
        Assert.IsTrue(Code.Contains("step-number\">5<", StringComparison.Ordinal), "Must have step number 5");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("How it works page must describe complexity scoring and client review approval steps")]
    public void HowItWorksPageMustDescribeComplexityScoringAndClientReviewApprovalSteps()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "HowItWorks.razor");
        Assert.IsTrue(Code.Contains("Complexity Scoring", StringComparison.Ordinal), "Steps must include Complexity Scoring step");
        Assert.IsTrue(Code.Contains("Client Reviews and Approves", StringComparison.Ordinal), "Steps must include client review step");
        Assert.IsTrue(Code.Contains("Get Paid and Level Up", StringComparison.Ordinal), "Steps must include get paid and level up step");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("How it works for clients section must have ordered list with five onboarding instructions")]
    public void HowItWorksForClientsSectionMustHaveOrderedListWithFiveOnboardingInstructions()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "HowItWorks.razor");
        Assert.IsTrue(Code.Contains("for-clients", StringComparison.Ordinal), "How it works must have for-clients section");
        Assert.IsTrue(Code.Contains("For Clients", StringComparison.Ordinal), "Section must have For Clients heading");
        Assert.IsTrue(Code.Contains("<ol>", StringComparison.Ordinal), "Client instructions must use ordered list");
        Assert.IsTrue(Code.Contains("automatically charged", StringComparison.Ordinal), "Client instructions must mention automatic charge");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Login page must have sign in heading and four sso provider buttons in login buttons container")]
    public void LoginPageMustHaveSignInHeadingAndFourSsoProviderButtonsInLoginButtonsContainer()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "LoginPage.razor");
        Assert.IsTrue(Code.Contains("Sign In to PrTask", StringComparison.Ordinal), "Login must have Sign In to PrTask heading");
        Assert.IsTrue(Code.Contains("login-buttons", StringComparison.Ordinal), "Login must have login-buttons container div");
        Assert.IsTrue(Code.Contains("google-login", StringComparison.Ordinal), "Login must have google-login button class");
        Assert.IsTrue(Code.Contains("github-login", StringComparison.Ordinal), "Login must have github-login button class");
        Assert.IsTrue(Code.Contains("azure-login", StringComparison.Ordinal), "Login must have azure-login button class");
        Assert.IsTrue(Code.Contains("okta-login", StringComparison.Ordinal), "Login must have okta-login button class");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Login page info section must describe developer and client roles with login info class")]
    public void LoginPageInfoSectionMustDescribeDeveloperAndClientRolesWithLoginInfoClass()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "LoginPage.razor");
        Assert.IsTrue(Code.Contains("login-info", StringComparison.Ordinal), "Login must have login-info section div");
        Assert.IsTrue(Code.Contains("For Developers", StringComparison.Ordinal), "Login info must have For Developers heading");
        Assert.IsTrue(Code.Contains("For Clients", StringComparison.Ordinal), "Login info must have For Clients heading");
        Assert.IsTrue(Code.Contains("submit PRs, and get paid", StringComparison.Ordinal), "Developer info must mention getting paid");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Login page must use route constants for sso provider href links with using directive")]
    public void LoginPageMustUseRouteConstantsForSsoProviderHrefLinksWithUsingDirective()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "LoginPage.razor");
        Assert.IsTrue(Code.Contains("@using PrTask.Domain.Constants", StringComparison.Ordinal), "Login must import Domain Constants namespace");
        Assert.IsTrue(Code.Contains("RouteConstants.ApiAuthGoogle", StringComparison.Ordinal), "Google login must use RouteConstants.ApiAuthGoogle");
        Assert.IsTrue(Code.Contains("RouteConstants.ApiAuthGitHub", StringComparison.Ordinal), "GitHub login must use RouteConstants.ApiAuthGitHub");
        Assert.IsTrue(Code.Contains("RouteConstants.ApiAuthAzure", StringComparison.Ordinal), "Azure login must use RouteConstants.ApiAuthAzure");
        Assert.IsTrue(Code.Contains("RouteConstants.ApiAuthOkta", StringComparison.Ordinal), "Okta login must use RouteConstants.ApiAuthOkta");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("About page must have five sections covering what we do gamification payments legal and contact")]
    public void AboutPageMustHaveFiveSectionsCoveringWhatWeDoGamificationPaymentsLegalAndContact()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "AboutPage.razor");
        Assert.IsTrue(Code.Contains("What We Do", StringComparison.Ordinal), "About must have What We Do section");
        Assert.IsTrue(Code.Contains("Game-Like Experience", StringComparison.Ordinal), "About must have Game-Like Experience section");
        Assert.IsTrue(Code.Contains("Secure Payments", StringComparison.Ordinal), "About must have Secure Payments section");
        Assert.IsTrue(Code.Contains("Legal", StringComparison.Ordinal), "About must have Legal section");
        Assert.IsTrue(Code.Contains("Contact", StringComparison.Ordinal), "About must have Contact section");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("About page legal section must link to all eight legal pages including licenses and dmca")]
    public void AboutPageLegalSectionMustLinkToAllEightLegalPagesIncludingLicensesAndDmca()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "AboutPage.razor");
        Assert.IsTrue(Code.Contains("legal-links", StringComparison.Ordinal), "About must have legal-links container div");
        Assert.IsTrue(Code.Contains("/legal/terms", StringComparison.Ordinal), "About must link to Terms of Service");
        Assert.IsTrue(Code.Contains("/legal/privacy", StringComparison.Ordinal), "About must link to Privacy Policy");
        Assert.IsTrue(Code.Contains("/legal/refund", StringComparison.Ordinal), "About must link to Refund Policy");
        Assert.IsTrue(Code.Contains("/legal/dmca", StringComparison.Ordinal), "About must link to DMCA policy");
        Assert.IsTrue(Code.Contains("/legal/licenses", StringComparison.Ordinal), "About must link to Licenses page");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("About page contact section must provide support at prtask dot com email for inquiries")]
    public void AboutPageContactSectionMustProvideSupportAtPrtaskDotComEmailForInquiries()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "AboutPage.razor");
        Assert.IsTrue(Code.Contains("support@prtask.com", StringComparison.Ordinal), "Contact must provide support@prtask.com email");
        Assert.IsTrue(Code.Contains("about-section", StringComparison.Ordinal), "About must use about-section class for sections");
    }
}
