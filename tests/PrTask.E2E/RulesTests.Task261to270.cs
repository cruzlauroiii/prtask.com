using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task261 Legal pages — all 8 pages with correct routes and content")]
    public async Task LegalPagesStructureAsync()
    {
        var Terms = ReadSource("PrTask.SharedUI", "Pages", "Legal", "TermsPage.razor");
        Assert.IsTrue(Terms.Contains("@page \"/Legal/Terms\""), "Terms has route");
        Assert.IsTrue(Terms.Contains("TermsConstants.PageHeading") || Terms.Contains("Terms of Service"), "Terms has heading");
        Assert.IsTrue(Terms.Contains("ConsumerProtection") || Terms.Contains("RA 7394"), "Terms references consumer protection");
        Assert.IsTrue(Terms.Contains("AntiMoneyLaundering") || Terms.Contains("RA 9160"), "Terms references AML");
        var Privacy = ReadSource("PrTask.SharedUI", "Pages", "Legal", "PrivacyPage.razor");
        Assert.IsTrue(Privacy.Contains("@page \"/Legal/Privacy\""), "Privacy has route");
        Assert.IsTrue(Privacy.Contains("GdprCompliance") || Privacy.Contains("GDPR"), "Privacy references GDPR");
        Assert.IsTrue(Privacy.Contains("CcpaCompliance") || Privacy.Contains("CCPA"), "Privacy references CCPA");
        Assert.IsTrue(Privacy.Contains("DataBreachNotification") || Privacy.Contains("RA 10173"), "Privacy references data privacy act");
        var Refund = ReadSource("PrTask.SharedUI", "Pages", "Legal", "RefundPage.razor");
        Assert.IsTrue(Refund.Contains("@page \"/Legal/Refund\""), "Refund has route");
        Assert.IsTrue(Refund.Contains("Refund"), "Refund has heading");
        var AcceptableUse = ReadSource("PrTask.SharedUI", "Pages", "Legal", "AcceptableUsePage.razor");
        Assert.IsTrue(AcceptableUse.Contains("@page \"/Legal/AcceptableUse\""), "AcceptableUse has route");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task262 Legal pages — cookie, licenses, accessibility, DMCA")]
    public async Task LegalPagesSecondaryAsync()
    {
        var Cookie = ReadSource("PrTask.SharedUI", "Pages", "Legal", "CookiePolicyPage.razor");
        Assert.IsTrue(Cookie.Contains("@page \"/Legal/CookiePolicy\""), "Cookie has route");
        Assert.IsTrue(Cookie.Contains("Cookie"), "Cookie has heading");
        var Licenses = ReadSource("PrTask.SharedUI", "Pages", "Legal", "LicensesPage.razor");
        Assert.IsTrue(Licenses.Contains("@page \"/Legal/Licenses\""), "Licenses has route");
        Assert.IsTrue(Licenses.Contains("PaymentProviderCompliance") || Licenses.Contains("CreditCardProcessing") || Licenses.Contains("PCI DSS"), "Licenses references PCI DSS");
        var Accessibility = ReadSource("PrTask.SharedUI", "Pages", "Legal", "AccessibilityPage.razor");
        Assert.IsTrue(Accessibility.Contains("@page \"/Legal/Accessibility\""), "Accessibility has route");
        Assert.IsTrue(Accessibility.Contains("AccessibilityConstants") || Accessibility.Contains("WCAG"), "Accessibility references WCAG");
        var Dmca = ReadSource("PrTask.SharedUI", "Pages", "Legal", "DmcaPage.razor");
        Assert.IsTrue(Dmca.Contains("@page \"/Legal/Dmca\""), "DMCA has route");
        Assert.IsTrue(Dmca.Contains("DmcaConstants") || Dmca.Contains("DMCA"), "DMCA has heading");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task263 DiditConstants — complete API property and status constants")]
    public async Task DiditConstantsCompleteAsync()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "DiditConstants.cs");
        Assert.IsTrue(Source.Contains("StatusNotStarted"), "Has StatusNotStarted");
        Assert.IsTrue(Source.Contains("StatusApproved"), "Has StatusApproved");
        Assert.IsTrue(Source.Contains("StatusDeclined"), "Has StatusDeclined");
        Assert.IsTrue(Source.Contains("StatusInReview"), "Has StatusInReview");
        Assert.IsTrue(Source.Contains("StatusExpired"), "Has StatusExpired");
        Assert.IsTrue(Source.Contains("PropertyWorkflowId"), "Has PropertyWorkflowId");
        Assert.IsTrue(Source.Contains("PropertyVendorData"), "Has PropertyVendorData");
        Assert.IsTrue(Source.Contains("PropertyCallback"), "Has PropertyCallback");
        Assert.IsTrue(Source.Contains("PropertyCallbackMethod"), "Has PropertyCallbackMethod");
        Assert.IsTrue(Source.Contains("PropertySessionNumber"), "Has PropertySessionNumber");
        Assert.IsTrue(Source.Contains("PropertyMetadata"), "Has PropertyMetadata");
        Assert.IsTrue(Source.Contains("PropertyLanguage"), "Has PropertyLanguage");
        Assert.IsTrue(Source.Contains("ApiKeyHeader"), "Has ApiKeyHeader");
        Assert.IsTrue(Source.Contains("x-api-key"), "Uses x-api-key header");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task264 DiditKycService — real API integration with all CRUD methods")]
    public async Task DiditKycServiceCrudAsync()
    {
        var Source = ReadSource("PrTask.Infrastructure", "Services", "DiditKycService.cs");
        Assert.IsTrue(Source.Contains(": IKycVerificationService"), "Implements interface");
        Assert.IsTrue(Source.Contains("CreateSessionAsync"), "Has CreateSessionAsync");
        Assert.IsTrue(Source.Contains("GetSessionStatusAsync"), "Has GetSessionStatusAsync");
        Assert.IsTrue(Source.Contains("UpdateSessionStatusAsync"), "Has UpdateSessionStatusAsync");
        Assert.IsTrue(Source.Contains("ListSessionsAsync"), "Has ListSessionsAsync");
        Assert.IsTrue(Source.Contains("DeleteSessionAsync"), "Has DeleteSessionAsync");
        Assert.IsTrue(Source.Contains(nameof(DiditConstants) + ".CreateSessionPath"), "Uses CreateSessionPath");
        Assert.IsTrue(Source.Contains(nameof(DiditConstants) + ".PropertyWorkflowId"), "Uses PropertyWorkflowId");
        Assert.IsTrue(Source.Contains(nameof(DiditConstants) + ".ApiKeyHeader"), "Uses ApiKeyHeader");
        Assert.IsTrue(Source.Contains("IHttpClientFactory"), "Uses IHttpClientFactory");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task265 Worker.js Durable Object uses recommended pattern")]
    public async Task WorkerDurableObjectPatternAsync()
    {
        var Source = ReadInfra("worker.js");
        Assert.IsTrue(Source.Contains("import { DurableObject }"), "Imports DurableObject from cloudflare:workers");
        Assert.IsTrue(Source.Contains("extends DurableObject"), "Extends DurableObject base class");
        Assert.IsTrue(Source.Contains("super(ctx, env)"), "Calls super with ctx and env");
        Assert.IsTrue(Source.Contains("this.ctx.acceptWebSocket"), "Uses this.ctx.acceptWebSocket");
        Assert.IsTrue(Source.Contains("this.ctx.getWebSockets"), "Uses this.ctx.getWebSockets");
        Assert.IsTrue(Source.Contains("serializeAttachment"), "Uses serializeAttachment");
        Assert.IsTrue(Source.Contains("deserializeAttachment"), "Uses deserializeAttachment");
        Assert.IsTrue(Source.Contains("sanitizeIdentifier"), "Has SQL injection prevention");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task266 Worker.js handles all OAuth providers")]
    public async Task WorkerOAuthProvidersAsync()
    {
        var Source = ReadInfra("worker.js");
        Assert.IsTrue(Source.Contains("handleGoogleAuth"), "Handles Google OAuth");
        Assert.IsTrue(Source.Contains("handleGitHubAuth"), "Handles GitHub OAuth");
        Assert.IsTrue(Source.Contains("handleAzureAuth"), "Handles Azure OAuth");
        Assert.IsTrue(Source.Contains("handleOktaAuth"), "Handles Okta OAuth");
        Assert.IsTrue(Source.Contains("handleGoogleCallback"), "Handles Google callback");
        Assert.IsTrue(Source.Contains("handleGitHubCallback"), "Handles GitHub callback");
        Assert.IsTrue(Source.Contains("generateCodeChallenge"), "Has PKCE code challenge");
        Assert.IsTrue(Source.Contains("generateCodeVerifier"), "Has PKCE code verifier");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task267 D1 schema has all required tables")]
    public async Task D1SchemaTablesAsync()
    {
        var Source = ReadInfra("schema.sql");
        Assert.IsTrue(Source.Contains("CREATE TABLE IF NOT EXISTS users"), "Has users table");
        Assert.IsTrue(Source.Contains("CREATE TABLE IF NOT EXISTS tasks"), "Has tasks table");
        Assert.IsTrue(Source.Contains("CREATE TABLE IF NOT EXISTS pull_requests"), "Has pull_requests table");
        Assert.IsTrue(Source.Contains("CREATE TABLE IF NOT EXISTS payments"), "Has payments table");
        Assert.IsTrue(Source.Contains("CREATE TABLE IF NOT EXISTS achievements"), "Has achievements table");
        Assert.IsTrue(Source.Contains("CREATE TABLE IF NOT EXISTS leaderboard"), "Has leaderboard table");
        Assert.IsTrue(Source.Contains("maya_customer_id"), "Users has maya_customer_id");
        Assert.IsTrue(Source.Contains("bounty_amount_cents"), "Tasks has bounty_amount_cents");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task268 Terraform infra — D1, KV, R2, Workers all configured")]
    public async Task TerraformInfraCompleteAsync()
    {
        var D1 = ReadInfra("d1.tf");
        Assert.IsTrue(D1.Contains("cloudflare_d1_database"), "Has D1 database resource");
        Assert.IsTrue(D1.Contains("prtask-db"), "D1 named prtask-db");
        var Kv = ReadInfra("kv.tf");
        Assert.IsTrue(Kv.Contains("prtask-sessions"), "Has sessions KV namespace");
        Assert.IsTrue(Kv.Contains("prtask-cache"), "Has cache KV namespace");
        var R2 = ReadInfra("r2.tf");
        Assert.IsTrue(R2.Contains("prtask-diffs"), "Has diffs R2 bucket");
        Assert.IsTrue(R2.Contains("prtask-avatars"), "Has avatars R2 bucket");
        var Workers = ReadInfra("workers.tf");
        Assert.IsTrue(Workers.Contains("prtask-api"), "Has worker named prtask-api");
        Assert.IsTrue(Workers.Contains("prtask.com/ws"), "Has WSS route");
        Assert.IsTrue(Workers.Contains("prtask.com/api/*"), "Has API route");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task269 HttpKycVerificationService — client-side KYC proxy")]
    public async Task HttpKycClientServiceAsync()
    {
        var Source = ReadSource("PrTask.Client", "Services", "HttpKycVerificationService.cs");
        Assert.IsTrue(Source.Contains(": IKycVerificationService"), "Implements interface");
        Assert.IsTrue(Source.Contains(nameof(DiditConstants) + ".JsonSessionId"), "Uses DiditConstants.JsonSessionId");
        Assert.IsTrue(Source.Contains(nameof(RouteConstants) + ".ApiKycCreate"), "Uses route constant");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task270 KycEndpoints — server-side KYC CRUD at /api/kyc")]
    public async Task KycEndpointsCrudAsync()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "KycEndpoints.cs");
        Assert.IsTrue(Source.Contains(nameof(RouteConstants) + ".ApiKyc"), "Mapped at ApiKyc route");
        Assert.IsTrue(Source.Contains("SubKycCreate"), "Has create sub-route");
        Assert.IsTrue(Source.Contains("SubKycStatus"), "Has status sub-route");
        Assert.IsTrue(Source.Contains("SubKycUpdate"), "Has update sub-route");
        Assert.IsTrue(Source.Contains("SubKycList"), "Has list sub-route");
        Assert.IsTrue(Source.Contains("SubKycDelete"), "Has delete sub-route");
        Assert.IsTrue(Source.Contains("RequireAuthorization"), "Requires auth");
        await Task.CompletedTask;
    }
}
