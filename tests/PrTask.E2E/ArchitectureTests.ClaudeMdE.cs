using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class ArchitectureTests
{
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("Client index HTML must have inline theme script with localStorage persistence for flash free dark mode")]
   public void TClaudeMdC7ClientIndexHtmlMustHaveInlineThemeScriptWithLocalStoragePersistenceForFlashFreeDarkMode()
   {
       var IndexPath = Path.Combine(SourceRoot, ClientProject, "wwwroot", "index.html");
       var Content = File.ReadAllText(IndexPath);
       Assert.IsTrue(Content.Contains("prtaskToggleTheme"), "index.html must define prtaskToggleTheme function");
       Assert.IsTrue(Content.Contains("prtaskGetTheme"), "index.html must define prtaskGetTheme function");
       Assert.IsTrue(Content.Contains("localStorage"), "index.html must use localStorage for theme persistence");
       Assert.IsTrue(Content.Contains("data-theme"), "index.html must use data-theme attribute");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("Pricing page must show Free for both developer and client tiers with no fee references")]
   public void TClaudeMdC8PricingPageMustShowFreeForBothDeveloperAndClientTiersWithNoFeeReferences()
   {
       var PricingPath = Path.Combine(SourceRoot, SharedUiProject, "Pages", "PricingPage.razor");
       var Content = File.ReadAllText(PricingPath);
       Assert.IsTrue(Content.Contains("For Developers") && Content.Contains("Free"), "Developer tier must show Free");
       Assert.IsTrue(Content.Contains("For Clients") && Content.Contains("Free"), "Client tier must show Free");
       Assert.IsFalse(Content.Contains("10%"), "Pricing page must not reference 10% fee");
       Assert.IsFalse(Content.Contains("90%"), "Pricing page must not reference 90% payout");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("Terms page must mention supported payment methods and automatic payment for compliance")]
   public void TClaudeMdC9TermsPageMustMentionSupportedPaymentMethodsAndAutomaticPaymentForCompliance()
   {
       var TermsPath = Path.Combine(SourceRoot, SharedUiProject, "Pages", "Legal", "TermsPage.razor");
       var Content = File.ReadAllText(TermsPath);
       Assert.IsTrue(Content.Contains("supported payment methods"), "Terms must mention supported payment methods");
       Assert.IsTrue(Content.Contains("automatically charged"), "Terms must mention automatic payment on PR approval");
       Assert.IsTrue(Content.Contains("USD"), "Terms must mention USD currency");
       Assert.IsTrue(Content.Contains("Public Pull Requests"), "Terms must mention public pull requests");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("Gitignore must include wrangler directory to prevent Cloudflare account ID leakage")]
   public void TClaudeMdD0GitignoreMustIncludeWranglerDirectoryToPreventCloudflareAccountIdLeakage()
   {
       var Content = File.ReadAllText(Path.Combine(SolutionRoot, ".gitignore"));
       Assert.IsTrue(Content.Contains(".wrangler"), ".gitignore must exclude .wrangler/ directory");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("RULES md must have Learnings section documenting project specific lessons and patterns")]
   public void TClaudeMdD1RulesMdMustHaveLearningsSectionDocumentingProjectSpecificLessonsAndPatterns()
   {
       var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
       Assert.IsTrue(Content.Contains("## Learnings"), "RULES.md must have a Learnings section");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("All content pages must reference preferred payout method for generic developer payouts")]
   public void TClaudeMdD2AllContentPagesMustReferencePreferredPayoutMethodForGenericDeveloperPayouts()
   {
       var PricingPath = Path.Combine(SourceRoot, SharedUiProject, "Pages", "PricingPage.razor");
       var PricingContent = File.ReadAllText(PricingPath);
       Assert.IsTrue(PricingContent.Contains("preferred payout method"), "Pricing page must mention preferred payout method");
       var HowItWorksPath = Path.Combine(SourceRoot, SharedUiProject, "Pages", "HowItWorks.razor");
       var HowItWorksContent = File.ReadAllText(HowItWorksPath);
       Assert.IsTrue(HowItWorksContent.Contains("preferred payout method"), "HowItWorks page must mention preferred payout method");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("SCSS variables must use data-theme dark selector for manual theme override with mixin")]
   public void TClaudeMdD3ScssVariablesMustUseDataThemeDarkSelectorForManualThemeOverrideWithMixin()
   {
       var VariablesPath = Path.Combine(SourceRoot, SharedUiProject, "Styles", "_variables.scss");
       var Content = File.ReadAllText(VariablesPath);
       Assert.IsTrue(Content.Contains("[data-theme=\"dark\"]"), "SCSS must have data-theme dark selector for manual override");
       Assert.IsTrue(Content.Contains("@mixin dark-theme") || Content.Contains("@mixin dark_theme"), "SCSS must use mixin to avoid dark theme duplication");
       Assert.IsTrue(Content.Contains(":not([data-theme=\"light\"])"), "SCSS must use :not([data-theme=light]) to allow manual light override on dark OS");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("RULES md must specify theme switcher toggle in nav persisting to localStorage")]
   public void TClaudeMdD4RulesMdMustSpecifyThemeSwitcherToggleInNavPersistingToLocalStorage()
   {
       var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
       Assert.IsTrue(Content.Contains("theme switcher"), "RULES.md must mention theme switcher");
       Assert.IsTrue(Content.Contains("localStorage"), "RULES.md must mention localStorage persistence for theme");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("Client pricing page must also show Free and multiple payouts matching SharedUI pricing page")]
   public void TClaudeMdD6ClientPricingPageMustAlsoShowFreeAndMultiplePayoutsMatchingSharedUiPricingPage()
   {
       var ClientPricingPath = Path.Combine(SourceRoot, ClientProject, "Pages", "ClientPricingPage.razor");
       var Content = File.ReadAllText(ClientPricingPath);
       Assert.IsTrue(Content.Contains("Free"), "Client pricing page must show Free");
       Assert.IsFalse(Content.Contains("10% Fee"), "Client pricing page must not show 10% Fee");
       Assert.IsFalse(Content.Contains("90%"), "Client pricing page must not show 90% payout");
       Assert.IsTrue(Content.Contains("preferred payout method"), "Client pricing page must mention preferred payout method");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("RULES md must require Google auto login with prompt none for silent authentication when possible")]
   public void TClaudeMdD7RulesMdMustRequireGoogleAutoLoginWithPromptNoneForSilentAuthenticationWhenPossible()
   {
       var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
       Assert.IsTrue(Content.Contains("auto-login"), "RULES.md must mention auto-login via Google");
       Assert.IsTrue(Content.Contains("prompt=none"), "RULES.md must mention prompt=none for silent auth");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("Auth endpoints must support prompt none parameter for Google silent auto login flow")]
   public void TClaudeMdD8AuthEndpointsMustSupportPromptNoneParameterForGoogleSilentAutoLoginFlow()
   {
       var AuthPath = Path.Combine(SourceRoot, ServerProject, "Endpoints", "AuthEndpoints.cs");
       var Content = File.ReadAllText(AuthPath);
       Assert.IsTrue(Content.Contains("prompt=none"), "Auth endpoints must add prompt=none for Google auto-login");
       Assert.IsTrue(Content.Contains("auto_failed"), "Auth endpoints must handle auto-login failure gracefully");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("Login page must show SSO provider buttons without auto redirect for pure WASM compatibility")]
   public void TClaudeMdD9LoginPageMustShowSsoProviderButtonsWithoutAutoRedirectForPureWasmCompatibility()
   {
       var LoginPath = Path.Combine(SourceRoot, SharedUiProject, "Pages", "LoginPage.razor");
       var Content = File.ReadAllText(LoginPath);
       Assert.IsTrue(Content.Contains("ApiAuthGoogle"), "Login page must have Google sign-in");
       Assert.IsTrue(Content.Contains("ApiAuthGitHub"), "Login page must have GitHub sign-in");
       Assert.IsFalse(Content.Contains("forceLoad"), "Login page must not use forceLoad which causes loading screen on WASM");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("Login page Sign In must link to Google auth via href for direct SSO navigation")]
   public void TClaudeMdE1LoginPageSignInMustLinkToGoogleAuthViaHrefForDirectSsoNavigation()
   {
       var LoginPath = Path.Combine(SourceRoot, SharedUiProject, "Pages", "LoginPage.razor");
       var Content = File.ReadAllText(LoginPath);
       Assert.IsTrue(Content.Contains("Sign in with Google"), "Login page must have Sign in with Google button");
       Assert.IsTrue(Content.Contains("ApiAuthGoogle"), "Login page must link to Google auth endpoint");
       Assert.IsTrue(Content.Contains("btn btn-primary"), "Google sign-in must be the primary button");
       Assert.IsTrue(Content.Contains("href"), "Login page must use href links for SSO providers");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("Payment model must be automatic charge on PR approval with no escrow in content pages")]
   public void TClaudeMdE2PaymentModelMustBeAutomaticChargeOnPrApprovalWithNoEscrowInContentPages()
   {
       var Pages = new[]
       {
           Path.Combine(SourceRoot, SharedUiProject, "Pages", "PricingPage.razor"),
           Path.Combine(SourceRoot, ClientProject, "Pages", "ClientPricingPage.razor"),
           Path.Combine(SourceRoot, SharedUiProject, "Pages", "HowItWorks.razor"),
           Path.Combine(SourceRoot, ClientProject, "Pages", "ClientHowItWorksPage.razor"),
           Path.Combine(SourceRoot, SharedUiProject, "Pages", "Home.razor"),
           Path.Combine(SourceRoot, ClientProject, "Pages", "ClientHomePage.razor"),
       };
       foreach (var Page in Pages)
       {
           var Content = File.ReadAllText(Page);
           var Name = Path.GetFileName(Page);
           Assert.IsFalse(Content.Contains("escrow", StringComparison.OrdinalIgnoreCase), $"{Name} must not mention escrow — payment is automatic on PR approval");
       }
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("Content pages must state client is automatically charged when approving a PR")]
   public void TClaudeMdE3ContentPagesMustStateClientIsAutomaticallyChargedWhenApprovingAPr()
   {
       var HowItWorks = File.ReadAllText(Path.Combine(SourceRoot, SharedUiProject, "Pages", "HowItWorks.razor"));
       var Pricing = File.ReadAllText(Path.Combine(SourceRoot, SharedUiProject, "Pages", "PricingPage.razor"));
       Assert.IsTrue(HowItWorks.Contains("automatically charged"), "HowItWorks must state client is automatically charged");
       Assert.IsTrue(Pricing.Contains("automatically charged"), "PricingPage must state client is automatically charged");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("Pull requests must be public with multiple developers able to submit for the same task")]
   public void TClaudeMdE4PullRequestsMustBePublicWithMultipleDevelopersAbleToSubmitForTheSameTask()
   {
       var HowItWorks = File.ReadAllText(Path.Combine(SourceRoot, SharedUiProject, "Pages", "HowItWorks.razor"));
       var Home = File.ReadAllText(Path.Combine(SourceRoot, SharedUiProject, "Pages", "Home.razor"));
       Assert.IsTrue(HowItWorks.Contains("public pull request"), "HowItWorks must mention public pull requests");
       Assert.IsTrue(HowItWorks.Contains("Multiple developers"), "HowItWorks must state multiple developers can submit PRs");
       Assert.IsTrue(HowItWorks.Contains("chooses the best one"), "HowItWorks must state client chooses the best PR");
       Assert.IsTrue(Home.Contains("client chooses"), "Home page must mention client chooses the best PR");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("Licenses page must exist for credit card compliance with PCI DSS and payment provider info")]
   public void TClaudeMdE5LicensesPageMustExistForCreditCardComplianceWithPciDssAndPaymentProviderInfo()
   {
       var LicensesPath = Path.Combine(SourceRoot, SharedUiProject, "Pages", "Legal", "LicensesPage.razor");
       Assert.IsTrue(File.Exists(LicensesPath), "LicensesPage.razor must exist in Legal directory");
       var Content = File.ReadAllText(LicensesPath);
       Assert.IsTrue(Content.Contains("@page \"/legal/licenses\""), "Licenses page must have @page directive");
       Assert.IsTrue(Content.Contains("Credit Card Processing"), "Licenses page must cover credit card processing");
       Assert.IsTrue(Content.Contains("PCI DSS"), "Licenses page must reference PCI DSS compliance");
       Assert.IsTrue(Content.Contains("payment provider"), "Licenses page must reference payment provider");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("RouteConstants must include Licenses route for credit card compliance page navigation")]
   public void TClaudeMdE7RouteConstantsMustIncludeLicensesRouteForCreditCardCompliancePageNavigation()
   {
       var Content = File.ReadAllText(Path.Combine(SourceRoot, DomainProject, "Constants", "RouteConstants.cs"));
       Assert.IsTrue(Content.Contains("Licenses") && Content.Contains("/legal/licenses"), "RouteConstants must define Licenses route");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("Footer must link to all legal pages including licenses for credit card review accessibility")]
   public void TClaudeMdE8FooterMustLinkToAllLegalPagesIncludingLicensesForCreditCardReviewAccessibility()
   {
       var FooterPath = Path.Combine(SourceRoot, SharedUiProject, "Components", "FooterSection.razor");
       var Content = File.ReadAllText(FooterPath);
       Assert.IsTrue(Content.Contains("/legal/terms"), "Footer must link to Terms");
       Assert.IsTrue(Content.Contains("/legal/privacy"), "Footer must link to Privacy");
       Assert.IsTrue(Content.Contains("/legal/refund"), "Footer must link to Refund Policy");
       Assert.IsTrue(Content.Contains("/legal/licenses"), "Footer must link to Licenses");
       Assert.IsTrue(Content.Contains("/legal/acceptable-use"), "Footer must link to Acceptable Use");
       Assert.IsTrue(Content.Contains("/legal/cookie-policy"), "Footer must link to Cookie Policy");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("Refund page must describe automatic payment model with no escrow references")]
   public void TClaudeMdE9RefundPageMustDescribeAutomaticPaymentModelWithNoEscrowReferences()
   {
       var RefundPath = Path.Combine(SourceRoot, SharedUiProject, "Pages", "Legal", "RefundPage.razor");
       var Content = File.ReadAllText(RefundPath);
       Assert.IsFalse(Content.Contains("escrow", StringComparison.OrdinalIgnoreCase), "Refund page must not mention escrow");
       Assert.IsTrue(Content.Contains("Automatic Payment Model"), "Refund page must describe automatic payment model");
       Assert.IsTrue(Content.Contains("only charged when they approve"), "Refund page must state client is only charged on approval");
       Assert.IsTrue(Content.Contains("No Charge Before Approval"), "Refund page must state no charge before approval");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("RULES md must specify no escrow automatic charge and public pull requests")]
   public void TClaudeMdF0RulesMdMustSpecifyNoEscrowAutomaticChargeAndPublicPullRequests()
   {
       var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
       Assert.IsTrue(Content.Contains("No escrow"), "RULES.md must specify no escrow");
       Assert.IsTrue(Content.Contains("automatically charged"), "RULES.md must specify automatic charge on PR approval");
       Assert.IsTrue(Content.Contains("Multiple developers can submit PRs"), "RULES.md must specify multiple PR submissions");
       Assert.IsTrue(Content.Contains("client chooses which PR to approve"), "RULES.md must specify client chooses PR");
       Assert.IsTrue(Content.Contains("Licenses page"), "RULES.md must require licenses page for credit card compliance");
       Assert.IsTrue(Content.Contains("credit card review"), "RULES.md must require legal pages for credit card review");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("Terms page must describe public pull requests and automatic payment model")]
   public void TClaudeMdF1TermsPageMustDescribePublicPullRequestsAndAutomaticPaymentModel()
   {
       var TermsPath = Path.Combine(SourceRoot, SharedUiProject, "Pages", "Legal", "TermsPage.razor");
       var Content = File.ReadAllText(TermsPath);
       Assert.IsTrue(Content.Contains("public"), "Terms must mention public pull requests");
       Assert.IsTrue(Content.Contains("Multiple developers"), "Terms must state multiple developers can submit PRs");
       Assert.IsTrue(Content.Contains("Automatic Payment"), "Terms must describe automatic payment model");
       Assert.IsFalse(Content.Contains("escrow", StringComparison.OrdinalIgnoreCase), "Terms must not mention escrow");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("CSS must not block vertical scrolling on mobile by avoiding all overflow properties")]
   public void TClaudeMdF2CssMustNotUseAnyOverflowPropertyAndSupportMobilePortraitScrolling()
   {
       var AppScss = Path.Combine(SourceRoot, SharedUiProject, "Styles", "app.scss");
       var Content = File.ReadAllText(AppScss);
       Assert.IsTrue(Content.Contains("max-width: 100vw"), "Must use max-width: 100vw to constrain width without overflow property");
       Assert.IsTrue(Content.Contains("min-height: 100dvh"), "Must use 100dvh not 100vh — dvh accounts for mobile browser chrome");
       Assert.IsFalse(Content.Contains("min-height: 100vh"), "Must not use 100vh — causes scrolling issues on mobile Chrome");
       Assert.IsFalse(Content.Contains("overflow-x") || Content.Contains("overflow-y") || Content.Contains("overflow: hidden") || Content.Contains("overflow:hidden"), "Must not use any overflow property — all overflow values forbid or break mobile scrolling");
       Assert.IsTrue(Content.Contains("word-break"), "Must use word-break to prevent text from causing horizontal overflow");
   }
}

