namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Rules must declare dotnet ten blazor wasm plus maui android via shared ui razor class library")]
    public void RulesMustDeclareDotnetTenBlazorWasmPlusMauiAndroidViaSharedUiRazorClassLibrary()
    {
        var Rules = ReadRootFile("RULES.md");
        Assert.IsTrue(Rules.Contains(".NET 10 Blazor WASM + MAUI Android via SharedUI Razor Class Library", StringComparison.Ordinal), "RULES must declare .NET 10 Blazor WASM + MAUI stack");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Rules must declare free platform with no escrow and automatic charge on pr approval")]
    public void RulesMustDeclareFreePlatformWithNoEscrowAndAutomaticChargeOnPrApproval()
    {
        var Rules = ReadRootFile("RULES.md");
        Assert.IsTrue(Rules.Contains("Free platform", StringComparison.Ordinal), "RULES must declare free platform");
        Assert.IsTrue(Rules.Contains("No escrow", StringComparison.Ordinal), "RULES must declare no escrow model");
        Assert.IsTrue(Rules.Contains("automatically charged", StringComparison.Ordinal), "RULES must state automatic charge on approval");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Rules must require pascal case everywhere and no third party runtime packages")]
    public void RulesMustRequirePascalCaseEverywhereAndNoThirdPartyRuntimePackages()
    {
        var Rules = ReadRootFile("RULES.md");
        Assert.IsTrue(Rules.Contains("PascalCase everywhere", StringComparison.Ordinal), "RULES must require PascalCase");
        Assert.IsTrue(Rules.Contains("No third-party runtime packages", StringComparison.Ordinal), "RULES must forbid third-party runtime packages");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Rules must require four sso providers github oauth google oidc azure oidc and okta oidc")]
    public void RulesMustRequireFourSsoProvidersGitHubOauthGoogleOidcAzureOidcAndOktaOidc()
    {
        var Rules = ReadRootFile("RULES.md");
        Assert.IsTrue(Rules.Contains("GitHub OAuth", StringComparison.Ordinal), "RULES must list GitHub OAuth");
        Assert.IsTrue(Rules.Contains("Google OIDC PKCE", StringComparison.Ordinal), "RULES must list Google OIDC PKCE");
        Assert.IsTrue(Rules.Contains("Azure OIDC PKCE", StringComparison.Ordinal), "RULES must list Azure OIDC PKCE");
        Assert.IsTrue(Rules.Contains("Okta OIDC PKCE", StringComparison.Ordinal), "RULES must list Okta OIDC PKCE");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Rules must require hundred dvh not hundred vh and forbid all overflow properties on mobile")]
    public void RulesMustRequireHundredDvhNotHundredVhAndForbidAllOverflowPropertiesOnMobile()
    {
        var Rules = ReadRootFile("RULES.md");
        Assert.IsTrue(Rules.Contains("Never use 100vh", StringComparison.Ordinal), "RULES must forbid 100vh");
        Assert.IsTrue(Rules.Contains("100dvh", StringComparison.Ordinal), "RULES must require 100dvh");
        Assert.IsTrue(Rules.Contains("Never use any overflow property", StringComparison.Ordinal), "RULES must forbid all overflow properties");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Rules must require serverless architecture with opentofu and cloudflare free tier databases")]
    public void RulesMustRequireServerlessArchitectureWithOpentofuAndCloudflareFreeToolDatabases()
    {
        var Rules = ReadRootFile("RULES.md");
        Assert.IsTrue(Rules.Contains("Serverless architecture", StringComparison.Ordinal), "RULES must require serverless architecture");
        Assert.IsTrue(Rules.Contains("OpenTofu + Cloudflare free tier", StringComparison.Ordinal), "RULES must specify OpenTofu + Cloudflare");
        Assert.IsTrue(Rules.Contains("D1 SQL, KV, R2, Durable Objects", StringComparison.Ordinal), "RULES must list Cloudflare databases");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Rules must require four analyzers stylecop roslynator meziantou and sonar all private assets")]
    public void RulesMustRequireFourAnalyzersStylecopRoslynatorMeziantouAndSonarAllPrivateAssets()
    {
        var Rules = ReadRootFile("RULES.md");
        Assert.IsTrue(Rules.Contains("Four analyzers: StyleCop, Roslynator, Meziantou, SonarAnalyzer", StringComparison.Ordinal), "RULES must list four analyzers");
        Assert.IsTrue(Rules.Contains("PrivateAssets=all", StringComparison.Ordinal), "RULES must require PrivateAssets=all");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Rules must require e2e tests only with no unit tests and plain scss without css frameworks")]
    public void RulesMustRequireE2ETestsOnlyWithNoUnitTestsAndPlainScssWithoutCssFrameworks()
    {
        var Rules = ReadRootFile("RULES.md");
        Assert.IsTrue(Rules.Contains("E2E tests only", StringComparison.Ordinal), "RULES must require E2E tests only");
        Assert.IsTrue(Rules.Contains("Plain SCSS only (no CSS frameworks)", StringComparison.Ordinal), "RULES must require plain SCSS");
        Assert.IsTrue(Rules.Contains("flexbox", StringComparison.Ordinal), "RULES must require flexbox layouts");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Rules must require all transactions in us dollars and multiple developers can submit prs")]
    public void RulesMustRequireAllTransactionsInUsDollarsAndMultipleDevelopersCanSubmitPrs()
    {
        var Rules = ReadRootFile("RULES.md");
        Assert.IsTrue(Rules.Contains("All transactions in US Dollars (USD)", StringComparison.Ordinal), "RULES must require USD transactions");
        Assert.IsTrue(Rules.Contains("Multiple developers can submit PRs for the same task", StringComparison.Ordinal), "RULES must allow multiple PR submissions");
        Assert.IsTrue(Rules.Contains("Public pull requests", StringComparison.Ordinal), "RULES must require public PRs");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Rules learnings must document client duplicate pages and cloudflare pages terraform limitations")]
    public void RulesLearningsMustDocumentClientDuplicatePagesAndCloudflarePagessTerraformLimitations()
    {
        var Rules = ReadRootFile("RULES.md");
        Assert.IsTrue(Rules.Contains("Client project (PrTask.Client) has duplicate pages", StringComparison.Ordinal), "RULES learnings must note client duplicate pages");
        Assert.IsTrue(Rules.Contains("Cloudflare Pages direct upload is incompatible with build_config", StringComparison.Ordinal), "RULES learnings must note Cloudflare limitation");
        Assert.IsTrue(Rules.Contains("SonarAnalyzer S927", StringComparison.Ordinal), "RULES learnings must note SonarAnalyzer S927 issue");
    }
}
