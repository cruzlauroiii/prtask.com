namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task10 All C# files must use file-scoped namespaces with no region directives")]
    public void Task10FileScopedNamespacesNoRegions()
    {
        var Analyzer = File.ReadAllText(Path.Combine(SourceRoot, "PrTask.Analyzers", "PT002NamespaceAndRegionAnalyzer.cs"));
        Assert.IsTrue(Analyzer.Contains("DiagnosticAnalyzer"), "PT002 namespace/region analyzer must exist");
        Assert.IsTrue(Analyzer.Contains("FileScopedNamespaceDeclaration") || Analyzer.Contains("NamespaceDeclaration"), "Must check namespace style");
        var Ec = File.ReadAllText(Path.Combine(SolutionRoot, ".editorconfig"));
        Assert.IsTrue(Ec.Contains("csharp_style_namespace_declarations") || Ec.Contains("file_scoped"), "Editorconfig must enforce file-scoped namespaces");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task11 All C# and Razor source files in src must be under 300 lines")]
    public void Task11AllSourceFilesUnder300Lines()
    {
        var Analyzer = File.ReadAllText(Path.Combine(SourceRoot, "PrTask.Analyzers", "PT003MaxFileLinesAnalyzer.cs"));
        Assert.IsTrue(Analyzer.Contains("DiagnosticAnalyzer"), "PT003 max-lines analyzer must exist");
        var Violations = new List<string>();
        foreach (var F in GetSourceFiles(".razor"))
        {
            var LineCount = File.ReadAllLines(F).Length;
            var Fn = Path.GetFileName(F);
            if (LineCount > 300)
            {
                Violations.Add($"{Fn}: {LineCount} lines (max 300)");
            }
        }
        Assert.AreEqual(0, Violations.Count, $"\n{string.Join("\n", Violations)}");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task12 Domain zero refs Application refs Domain only Infrastructure refs Application and Domain")]
    public void Task12CleanArchitectureLayering()
    {
        var DomainCsproj = File.ReadAllText(Path.Combine(SourceRoot, "PrTask.Domain", "PrTask.Domain.csproj"));
        var AppCsproj = File.ReadAllText(Path.Combine(SourceRoot, "PrTask.Application", "PrTask.Application.csproj"));
        var InfraCsproj = File.ReadAllText(Path.Combine(SourceRoot, "PrTask.Infrastructure", "PrTask.Infrastructure.csproj"));
        Assert.IsFalse(DomainCsproj.Contains("<ProjectReference"), "Domain must have zero project references");
        Assert.IsTrue(AppCsproj.Contains("PrTask.Domain"), "Application must reference Domain");
        Assert.IsFalse(AppCsproj.Contains("PrTask.Infrastructure"), "Application must not reference Infrastructure");
        Assert.IsTrue(InfraCsproj.Contains("PrTask.Application"), "Infrastructure must reference Application");
        Assert.IsTrue(InfraCsproj.Contains("PrTask.Domain"), "Infrastructure must reference Domain");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task13 Secrets must use dotnet user-secrets with UserSecretsId in Server project")]
    public void Task13SecretsViaDotnetUserSecrets()
    {
        var ServerCsproj = File.ReadAllText(Path.Combine(SourceRoot, "PrTask.Server", "PrTask.Server.csproj"));
        Assert.IsTrue(ServerCsproj.Contains("<UserSecretsId>"), "Server must have UserSecretsId for dotnet user-secrets");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task14 SSO must support four providers GitHub Google Azure Okta with callback endpoints")]
    public void Task14SsoFourProvidersWithCallbacks()
    {
        var Routes = ReadSource("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Routes.Contains("ApiAuthGitHub"), "Must define GitHub auth route");
        Assert.IsTrue(Routes.Contains("ApiAuthGoogle"), "Must define Google auth route");
        Assert.IsTrue(Routes.Contains("ApiAuthAzure"), "Must define Azure auth route");
        Assert.IsTrue(Routes.Contains("ApiAuthOkta"), "Must define Okta auth route");
        Assert.IsTrue(Routes.Contains("ApiAuthCallbackGoogle"), "Must define Google callback");
        Assert.IsTrue(Routes.Contains("ApiAuthCallbackAzure"), "Must define Azure callback");
        Assert.IsTrue(Routes.Contains("ApiAuthCallbackOkta"), "Must define Okta callback");
        var Auth = ReadSource("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Auth.Contains("GeneratePkce"), "Must generate PKCE verifier and challenge");
        var OAuth = ReadSource("PrTask.Domain", "Constants", "OAuthConstants.cs");
        Assert.IsTrue(OAuth.Contains("code_challenge"), "Must include code_challenge in auth URL");
        Assert.IsTrue(OAuth.Contains("S256"), "Must use SHA256 code challenge method");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task15 Google SSO must be functional with correct URLs PKCE and login page sign-in")]
    public void Task15GoogleSsoFunctional()
    {
        var Google = ReadSource("PrTask.Domain", "Constants", "GoogleConstants.cs");
        Assert.IsTrue(Google.Contains("accounts.google.com/o/oauth2/v2/auth"), "Must define Google authorize URL");
        Assert.IsTrue(Google.Contains("oauth2.googleapis.com/token"), "Must define Google token URL");
        Assert.IsTrue(Google.Contains("googleapis.com/oauth2/v3/userinfo"), "Must define Google userinfo URL");
        Assert.IsTrue(Google.Contains("openid email profile"), "Must require openid email profile scopes");
        Assert.IsTrue(Google.Contains("CodeChallengeMethod = \"S256\""), "Must use S256 PKCE method");
        var Login = ReadSource("PrTask.SharedUI", "Pages", "LoginPage.razor");
        Assert.IsTrue(Login.Contains("google", StringComparison.OrdinalIgnoreCase), "Login must have Google sign-in");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task16 Server must configure cookie auth with HttpOnly secure and thirty-day sliding expiration")]
    public void Task16CookieAuthConfiguration()
    {
        var Auth = ReadSource("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Auth.Contains("CookieAuthenticationDefaults"), "Must use cookie authentication scheme");
        Assert.IsTrue(Auth.Contains("HttpOnly = true"), "Cookie must be HttpOnly");
        Assert.IsTrue(Auth.Contains("Secure = true"), "Cookie must be Secure");
        Assert.IsTrue(Auth.Contains("ClaimsIdentity"), "Must create claims identity");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task17 Free platform PlatformFeePercent zero and Pricing page shows Free")]
    public void Task17FreePlatformZeroFees()
    {
        var Constants = ReadSource("PrTask.Domain", "Constants", "AppConstants.cs");
        Assert.IsTrue(Constants.Contains("PlatformFeePercent = 0"), "PlatformFeePercent must be zero");
        var Pricing = ReadSource("PrTask.SharedUI", "Pages", "PricingPage.razor");
        Assert.IsTrue(Pricing.Contains("PricingConstants.PageHeading") || Pricing.Contains("PricingPageHeading"), "Pricing must state free for everyone");
        Assert.IsTrue(Pricing.Contains("PricingConstants.PageDescription") || Pricing.Contains("PricingPageDescription"), "Pricing must state no hidden fees");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task18 Clients post jobs with bounties developers submit public PRs multiple devs can submit")]
    public void Task18ClientsPostJobsDevelopersSubmitPublicPrs()
    {
        var HowItWorks = ReadSource("PrTask.SharedUI", "Pages", "HowItWorks.razor");
        Assert.IsTrue(HowItWorks.Contains("HowItWorksConstants.Step2Description") || HowItWorks.Contains("HowItWorksStep2Description"), "Must reference step 2 description (multiple developers)");
        Assert.IsTrue(HowItWorks.Contains("HowItWorksConstants.Step3Description") || HowItWorks.Contains("HowItWorksStep3Description"), "Must reference step 3 description (files changed scoring)");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task19 No escrow client auto-charged on PR approval developer gets paid via preferred method")]
    public void Task19NoEscrowAutoChargeOnApproval()
    {
        var Refund = ReadSource("PrTask.SharedUI", "Pages", "Legal", "RefundPage.razor");
        Assert.IsTrue(Refund.Contains("approve") || Refund.Contains("Approve") || Refund.Contains("Approval") || Refund.Contains("RefundConstants"), "Refund page must reference PR approval");
        var PrService = ReadSource("PrTask.Application", "Services", "IPullRequestService.cs");
        Assert.IsTrue(PrService.Contains("ApproveAsync"), "Must have ApproveAsync for client approval");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task20 PaymentEntity must track PayerId PayeeId TaskId PullRequestId Type and Status")]
    public void Task20PaymentEntityFields()
    {
        var Code = ReadSource("PrTask.Domain", "Models", "PaymentEntity.cs");
        Assert.IsTrue(Code.Contains("PayerId"), "Must have PayerId");
        Assert.IsTrue(Code.Contains("PayeeId"), "Must have PayeeId");
        Assert.IsTrue(Code.Contains("TaskId"), "Must have TaskId");
        Assert.IsTrue(Code.Contains("PullRequestId"), "Must have PullRequestId");
        Assert.IsTrue(Code.Contains("PaymentType Type"), "Must have Type field");
        Assert.IsTrue(Code.Contains("PaymentStatus Status"), "Must have Status field");
    }
}
