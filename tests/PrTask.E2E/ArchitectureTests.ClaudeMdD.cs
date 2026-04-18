using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class ArchitectureTests
{
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("OpenTofu Workers must define API route pattern for serverless endpoint proxying to worker")]
   public void TClaudeMd94OpenTofuWorkersMustDefineApiRoutePatternForServerlessEndpointProxyingToWorker()
   {
       var WorkersTf = Path.Combine(SolutionRoot, "infra", "workers.tf");
       var Content = File.ReadAllText(WorkersTf);
       Assert.IsTrue(Content.Contains("cloudflare_workers_route"), "workers.tf must define cloudflare_workers_route");
       Assert.IsTrue(Content.Contains("/api/*"), "workers.tf route must match /api/* pattern");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("Cloudflare R2 must have diffs bucket for private source public sanitized diff object storage")]
   public void TClaudeMd95CloudflareR2MustHaveDiffsBucketForPrivateSourcePublicSanitizedDiffObjectStorage()
   {
       var R2Tf = Path.Combine(SolutionRoot, "infra", "r2.tf");
       var Content = File.ReadAllText(R2Tf);
       Assert.IsTrue(Content.Contains("prtask-diffs"), "R2 must have diffs bucket for sanitized diff storage");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("Cloudflare KV must have sessions namespace for serverless authentication session storage")]
   public void TClaudeMd96CloudflareKvMustHaveSessionsNamespaceForServerlessAuthenticationSessionStorage()
   {
       var KvTf = Path.Combine(SolutionRoot, "infra", "kv.tf");
       var Content = File.ReadAllText(KvTf);
       Assert.IsTrue(Content.Contains("prtask-sessions"), "KV must have sessions namespace for auth session storage");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("Cloudflare KV must have cache namespace for serverless application data caching")]
   public void TClaudeMd97CloudflareKvMustHaveCacheNamespaceForServerlessApplicationDataCaching()
   {
       var KvTf = Path.Combine(SolutionRoot, "infra", "kv.tf");
       var Content = File.ReadAllText(KvTf);
       Assert.IsTrue(Content.Contains("prtask-cache"), "KV must have cache namespace for data caching");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("RULES md file must exist at solution root with compact comprehensive project requirements")]
   public void TClaudeMd98RulesMdFileMustExistAtSolutionRootWithCompactComprehensiveProjectRequirements()
   {
       var RulesMd = Path.Combine(SolutionRoot, "RULES.md");
       Assert.IsTrue(File.Exists(RulesMd), "RULES.md must exist at solution root");
       var Content = File.ReadAllText(RulesMd);
       Assert.IsTrue(Content.Contains("compact") && Content.Contains("comprehensive"), "RULES.md must state it is compact and comprehensive");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("RULES md must require serverless architecture with one HTML and one WASM for deployment")]
   public void TClaudeMd99RulesMdMustRequireServerlessArchitectureWithOneHtmlAndOneWasmForDeployment()
   {
       var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
       Assert.IsTrue(Content.Contains("Serverless"), "RULES.md must specify serverless architecture");
       Assert.IsTrue(Content.Contains("one HTML") && Content.Contains("one WASM"), "RULES.md must require one HTML and one WASM file");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("RULES md must require Cloudflare D1 KV R2 databases for serverless persistence layer")]
   public void TClaudeMdA0RulesMdMustRequireCloudflareD1KvR2DatabasesForServerlessPersistenceLayer()
   {
       var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
       Assert.IsTrue(Content.Contains("D1"), "RULES.md must reference Cloudflare D1");
       Assert.IsTrue(Content.Contains("KV"), "RULES.md must reference Cloudflare KV");
       Assert.IsTrue(Content.Contains("R2"), "RULES.md must reference Cloudflare R2");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("RULES md must require comprehensive E2E tests for every rule in the rules document")]
   public void TClaudeMdA1RulesMdMustRequireComprehensiveE2eTestsForEveryRuleInTheRulesDocument()
   {
       var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
       Assert.IsTrue(Content.Contains("E2E") && Content.Contains("every rule"), "RULES.md must require E2E tests for every rule");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("RULES md must require Durable Objects as part of Cloudflare free tier persistence strategy")]
   public void TClaudeMdA3RulesMdMustRequireDurableObjectsAsPartOfCloudflareFreeTierPersistenceStrategy()
   {
       var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
       Assert.IsTrue(Content.Contains("Durable Objects"), "RULES.md must reference Cloudflare Durable Objects");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("RULES md must require deploying latest HTML WASM to Cloudflare via OpenTofu always")]
   public void TClaudeMdA4RulesMdMustRequireDeployingLatestHtmlWasmToCloudflareViaOpenTofuAlways()
   {
       var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
       Assert.IsTrue(Content.Contains("Deploy") && Content.Contains("OpenTofu always"), "RULES.md must require deploying via OpenTofu always");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("RULES md must specify payment provider integration for bounty based pay and get paid workflow")]
   public void TClaudeMdA5RulesMdMustSpecifyPaymentProviderIntegrationForBountyBasedPayAndGetPaidWorkflow()
   {
       var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
       Assert.IsTrue(Content.Contains("payment providers"), "RULES.md must reference payment providers");
       Assert.IsTrue(Content.Contains("bounties"), "RULES.md must reference bounty-based job posting");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("RULES md must specify all four SSO providers GitHub Google Azure and Okta for authentication")]
   public void TClaudeMdA6RulesMdMustSpecifyAllFourSsoProvidersGitHubGoogleAzureAndOktaForAuthentication()
   {
       var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
       Assert.IsTrue(Content.Contains("GitHub OAuth"), "RULES.md must reference GitHub OAuth");
       Assert.IsTrue(Content.Contains("Google OIDC PKCE"), "RULES.md must reference Google OIDC PKCE");
       Assert.IsTrue(Content.Contains("Azure OIDC PKCE"), "RULES.md must reference Azure OIDC PKCE");
       Assert.IsTrue(Content.Contains("Okta OIDC PKCE"), "RULES.md must reference Okta OIDC PKCE");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("RULES md must specify clean architecture with Domain Application and Infrastructure layer rules")]
   public void TClaudeMdA7RulesMdMustSpecifyCleanArchitectureWithDomainApplicationAndInfrastructureLayerRules()
   {
       var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
       Assert.IsTrue(Content.Contains("Domain has zero project references"), "RULES.md must specify Domain isolation");
       Assert.IsTrue(Content.Contains("Application references only Domain"), "RULES.md must specify Application depends on Domain only");
       Assert.IsTrue(Content.Contains("Infrastructure references Application and Domain"), "RULES.md must specify Infrastructure dependencies");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("RULES md must specify four analyzers StyleCop Roslynator Meziantou SonarAnalyzer with PrivateAssets")]
   public void TClaudeMdA8RulesMdMustSpecifyFourAnalyzersStyleCopRoslynatorMeziantouSonarAnalyzerWithPrivateAssets()
   {
       var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
       Assert.IsTrue(Content.Contains("StyleCop"), "RULES.md must reference StyleCop analyzer");
       Assert.IsTrue(Content.Contains("Roslynator"), "RULES.md must reference Roslynator analyzer");
       Assert.IsTrue(Content.Contains("Meziantou"), "RULES.md must reference Meziantou analyzer");
       Assert.IsTrue(Content.Contains("SonarAnalyzer"), "RULES.md must reference SonarAnalyzer");
       Assert.IsTrue(Content.Contains("PrivateAssets=all"), "RULES.md must require PrivateAssets=all for analyzers");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("RULES md must specify PascalCase naming convention and SassCompiler build tool requirements")]
   public void TClaudeMdA9RulesMdMustSpecifyPascalCaseNamingConventionAndSassCompilerBuildToolRequirements()
   {
       var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
       Assert.IsTrue(Content.Contains("PascalCase everywhere"), "RULES.md must require PascalCase everywhere");
       Assert.IsTrue(Content.Contains("SassCompiler build tool"), "RULES.md must reference SassCompiler as build tool");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("RULES md must specify gamification features including XP levels streak badges and leaderboard")]
   public void TClaudeMdB0RulesMdMustSpecifyGamificationFeaturesIncludingXpLevelsStreakBadgesAndLeaderboard()
   {
       var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
       Assert.IsTrue(Content.Contains("XP"), "RULES.md must reference XP");
       Assert.IsTrue(Content.Contains("levels"), "RULES.md must reference levels");
       Assert.IsTrue(Content.Contains("streak"), "RULES.md must reference streak");
       Assert.IsTrue(Content.Contains("badges"), "RULES.md must reference badges");
       Assert.IsTrue(Content.Contains("Leaderboard"), "RULES.md must reference Leaderboard");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("RULES md must specify public pull requests for open contribution model")]
   public void TClaudeMdB1RulesMdMustSpecifyPublicPullRequestsForOpenContributionModel()
   {
       var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
       Assert.IsTrue(Content.Contains("Public pull requests"), "RULES.md must specify public pull requests");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("SCSS variables must use prefers-color-scheme media query for OS current color scheme detection")]
   public void TClaudeMdB2ScssVariablesMustUsePrefersColorSchemeMediaQueryForOsCurrentColorSchemeDetection()
   {
       var VariablesScss = Path.Combine(SourceRoot, SharedUiProject, "Styles", "_variables.scss");
       var Content = File.ReadAllText(VariablesScss);
       Assert.IsTrue(Content.Contains("prefers-color-scheme"), "_variables.scss must use prefers-color-scheme media query");
       Assert.IsTrue(Content.Contains("dark"), "_variables.scss must define dark mode variables");
       Assert.IsTrue(Content.Contains(":root"), "_variables.scss must use CSS custom properties via :root");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("SCSS must use plain SCSS only with no CSS framework imports and sasscompiler must output compressed")]
   public void TClaudeMdB3ScssMustUsePlainScssOnlyWithNoCssFrameworkImportsAndSasscompilerMustOutputCompressed()
   {
       var AppScss = Path.Combine(SourceRoot, SharedUiProject, "Styles", "app.scss");
       var Content = File.ReadAllText(AppScss);
       Assert.IsFalse(Content.Contains("bootstrap"), "SCSS must not import Bootstrap — plain SCSS only");
       Assert.IsFalse(Content.Contains("tailwind"), "SCSS must not import Tailwind — plain SCSS only");
       Assert.IsFalse(Content.Contains("bulma"), "SCSS must not import Bulma — plain SCSS only");
       var SassConfig = File.ReadAllText(Path.Combine(SourceRoot, SharedUiProject, "sasscompiler.json"));
       Assert.IsTrue(SassConfig.Contains("compressed"), "sasscompiler.json must output compressed (minified) CSS");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("SCSS layouts must use flexbox display flex for responsive component arrangement")]
   public void TClaudeMdB4ScssLayoutsMustUseFlexboxDisplayFlexForResponsiveComponentArrangement()
   {
       var AppScss = Path.Combine(SourceRoot, SharedUiProject, "Styles", "app.scss");
       var Content = File.ReadAllText(AppScss);
       Assert.IsTrue(Content.Contains("display: flex"), "app.scss must use flexbox (display: flex)");
       Assert.IsTrue(Content.Contains("flex-wrap"), "app.scss must use flex-wrap for responsive layouts");
       Assert.IsTrue(Content.Contains("flex-direction"), "app.scss must use flex-direction for layout control");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("SCSS must not use any overflow properties that block mobile vertical scrolling")]
   public void TClaudeMdB5ScssMustUseMaxWidthAndNoOverflowForMobileScrollSupport()
   {
       var AppScss = Path.Combine(SourceRoot, SharedUiProject, "Styles", "app.scss");
       var Content = File.ReadAllText(AppScss);
       Assert.IsTrue(Content.Contains("#app") && Content.Contains("max-width: 100vw"), "app.scss must use max-width: 100vw on #app to prevent horizontal overflow");
       Assert.IsTrue(Content.Contains("#app") && Content.Contains("min-height: 100dvh"), "app.scss must use min-height: 100dvh on #app — dvh accounts for mobile browser chrome");
       Assert.IsTrue(Content.Contains("#app") && Content.Contains("display: flex") && Content.Contains("flex-direction: column"), "app.scss #app must be a flex column container for proper mobile layout");
       Assert.IsFalse(Content.Contains("overflow-x") || Content.Contains("overflow-y") || Content.Contains("overflow: hidden"), "app.scss must not use any overflow property — overflow clip/hidden forbid scrolling on mobile");
       Assert.IsFalse(Content.Contains("min-height: 100vh"), "app.scss must not use 100vh — use 100dvh for mobile browser chrome support");
       Assert.IsTrue(Content.Contains("max-width: 768px"), "app.scss must have mobile breakpoint media query");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("Server project must have UserSecretsId for dotnet native secret management")]
   public void TClaudeMdB6ServerProjectMustHaveUserSecretsIdForDotnetNativeSecretManagement()
   {
       var ServerProj = Path.Combine(SourceRoot, ServerProject, $"{ServerProject}.csproj");
       var Content = File.ReadAllText(ServerProj);
       Assert.IsTrue(Content.Contains("<UserSecretsId>"), "Server project must have UserSecretsId for dotnet user-secrets");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("RULES md must require dotnet ten native secret handling and never store secrets in source")]
   public void TClaudeMdB7RulesMdMustRequireDotnetTenNativeSecretHandlingAndNeverStoreSecretsInSource()
   {
       var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
       Assert.IsTrue(Content.Contains("dotnet 10 native secret handling"), "RULES.md must reference dotnet 10 native secret handling");
       Assert.IsTrue(Content.Contains("never store secrets in source"), "RULES.md must prohibit secrets in source");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("RULES md must require night mode with prefers-color-scheme detection for OS color scheme")]
   public void TClaudeMdB8RulesMdMustRequireNightModeWithPrefersColorSchemeDetectionForOsColorScheme()
   {
       var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
       Assert.IsTrue(Content.Contains("Night mode"), "RULES.md must reference night mode support");
       Assert.IsTrue(Content.Contains("prefers-color-scheme"), "RULES.md must reference prefers-color-scheme detection");
       Assert.IsTrue(Content.Contains("OS current color scheme"), "RULES.md must default to OS current color scheme");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("RULES md must require plain SCSS only with minified CSS and flexbox layouts")]
   public void TClaudeMdB9RulesMdMustRequirePlainScssOnlyWithMinifiedCssAndFlexboxLayouts()
   {
       var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
       Assert.IsTrue(Content.Contains("Plain SCSS only"), "RULES.md must specify plain SCSS only");
       Assert.IsTrue(Content.Contains("minified"), "RULES.md must require minified CSS output");
       Assert.IsTrue(Content.Contains("flexbox"), "RULES.md must require SCSS flexbox layouts");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("RULES md must require no horizontal scrolling past 100 percent width")]
   public void TClaudeMdC0RulesMdMustRequireNoHorizontalScrollingPast100PercentWidth()
   {
       var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
       Assert.IsTrue(Content.Contains("max-width: 100vw"), "RULES.md must specify max-width: 100vw to prevent horizontal overflow");
       Assert.IsTrue(Content.Contains("min-height: 100dvh"), "RULES.md must specify 100dvh for mobile viewport");
       Assert.IsTrue(Content.Contains("word-break"), "RULES.md must specify word-break for preventing horizontal overflow");
       Assert.IsTrue(Content.Contains("Never use any overflow property"), "RULES.md must prohibit all overflow properties");
       Assert.IsTrue(Content.Contains("Vertical scrolling", StringComparison.OrdinalIgnoreCase), "RULES.md must state vertical scrolling must work");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("RULES md must require Google SSO to be functional for login authentication")]
   public void TClaudeMdC1RulesMdMustRequireGoogleSsoToBeFunctionalForLoginAuthentication()
   {
       var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
       Assert.IsTrue(Content.Contains("Google SSO must be functional"), "RULES.md must require Google SSO to be functional for login");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("Terraform tfvars file must not exist in source control to prevent secret leakage")]
   public void TClaudeMdC2TerraformTfvarsFileMustNotExistInSourceControlToPreventSecretLeakage()
   {
       var GitignorePath = Path.Combine(SolutionRoot, ".gitignore");
       if (File.Exists(GitignorePath))
       {
           var Content = File.ReadAllText(GitignorePath);
           Assert.IsTrue(Content.Contains("terraform.tfvars") || Content.Contains("*.tfvars"), ".gitignore must exclude terraform.tfvars to prevent secret leakage");
       }
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("RULES md must specify free platform with no charges to clients or developers")]
   public void TClaudeMdC3RulesMdMustSpecifyFreePlatformWithNoChargesToClientsOrDevelopers()
   {
       var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
       Assert.IsTrue(Content.Contains("Free platform"), "RULES.md must specify free platform");
       Assert.IsTrue(Content.Contains("charges nothing"), "RULES.md must state PrTask charges nothing");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("AppConstants PlatformFeePercent must be zero since PrTask is a free platform")]
   public void TClaudeMdC4AppConstantsPlatformFeePercentMustBeZeroSincePrTaskIsAFreePlatform()
   {
       var Content = File.ReadAllText(Path.Combine(SourceRoot, DomainProject, "Constants", "AppConstants.cs"));
       Assert.IsTrue(Content.Contains("PlatformFeePercent = 0"), "PlatformFeePercent must be 0 — PrTask is a free platform");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("RULES md must specify developers choose their preferred payout method for flexible payouts")]
   public void TClaudeMdC5RulesMdMustSpecifyDevelopersChooseTheirPreferredPayoutMethodForFlexiblePayouts()
   {
       var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
       Assert.IsTrue(Content.Contains("payout method"), "RULES.md must mention developer payout method choice");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("NavMenu must contain theme toggle button with JS interop for dark mode switching")]
   public void TClaudeMdC6NavMenuMustContainThemeToggleButtonWithJsInteropForDarkModeSwitching()
   {
       var NavMenuPath = Path.Combine(SourceRoot, SharedUiProject, "Components", "NavMenu.razor");
       var Content = File.ReadAllText(NavMenuPath);
       Assert.IsTrue(Content.Contains("theme-toggle"), "NavMenu must have theme-toggle button");
       Assert.IsTrue(Content.Contains("prtaskToggleTheme"), "NavMenu must call prtaskToggleTheme JS function");
       Assert.IsTrue(Content.Contains("prtaskGetTheme"), "NavMenu must call prtaskGetTheme JS function");
   }
}

