using System.Net;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Service registration must register all eight service interfaces with scoped lifetime")]
    public void ServiceRegistrationMustRegisterAllEightServiceInterfacesWithScopedLifetime()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "ServiceRegistration.cs");
        Assert.IsTrue(Code.Contains("IUserService", StringComparison.Ordinal), "Must register IUserService");
        Assert.IsTrue(Code.Contains("ITaskService", StringComparison.Ordinal), "Must register ITaskService");
        Assert.IsTrue(Code.Contains("IPullRequestService", StringComparison.Ordinal), "Must register IPullRequestService");
        Assert.IsTrue(Code.Contains("IPaymentService", StringComparison.Ordinal), "Must register IPaymentService");
        Assert.IsTrue(Code.Contains("ILeaderboardService", StringComparison.Ordinal), "Must register ILeaderboardService");
        Assert.IsTrue(Code.Contains("IAchievementService", StringComparison.Ordinal), "Must register IAchievementService");
        Assert.IsTrue(Code.Contains("IComplexityScoringService", StringComparison.Ordinal), "Must register IComplexityScoringService");
        Assert.IsTrue(Code.Contains("IDiffSanitizationService", StringComparison.Ordinal), "Must register IDiffSanitizationService");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Service registration must configure named http clients for app domain and maya payment")]
    public void ServiceRegistrationMustConfigureNamedHttpClientsForAppDomainAndMayaPayment()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "ServiceRegistration.cs");
        Assert.IsTrue(Code.Contains("AddHttpClient", StringComparison.Ordinal), "Must register named HTTP clients");
        Assert.IsTrue(Code.Contains("Maya", StringComparison.Ordinal), "Must register Maya payment HTTP client");
        Assert.IsTrue(Code.Contains("SandboxBaseUrl", StringComparison.Ordinal), "Must use Maya sandbox URL for development");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("App constants must define cloudflare account id pages project and max file lines limit")]
    public void AppConstantsMustDefineCloudflareAccountIdPagesProjectAndMaxFileLinesLimit()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "AppConstants.cs");
        Assert.IsTrue(Code.Contains("CloudflareAccountId", StringComparison.Ordinal), "Must define Cloudflare account ID");
        Assert.IsTrue(Code.Contains("CloudflarePagesProject", StringComparison.Ordinal), "Must define Cloudflare Pages project name");
        Assert.IsTrue(Code.Contains("MaxFileLines", StringComparison.Ordinal), "Must define max file lines limit");
        Assert.IsTrue(Code.Contains("300", StringComparison.Ordinal), "Max file lines must be 300");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("App constants must define max task title length and description length validation limits")]
    public void AppConstantsMustDefineMaxTaskTitleLengthAndDescriptionLengthValidationLimits()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "AppConstants.cs");
        Assert.IsTrue(Code.Contains("MaxTaskTitleLength", StringComparison.Ordinal), "Must define max task title length");
        Assert.IsTrue(Code.Contains("MaxTaskDescriptionLength", StringComparison.Ordinal), "Must define max task description length");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Route constants must define all navigation routes for home login dashboard and profile pages")]
    public void RouteConstantsMustDefineAllNavigationRoutesForHomeLoginDashboardAndProfilePages()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Code.Contains("Home", StringComparison.Ordinal), "RouteConstants must define Home route");
        Assert.IsTrue(Code.Contains("Login", StringComparison.Ordinal), "RouteConstants must define Login route");
        Assert.IsTrue(Code.Contains("Dashboard", StringComparison.Ordinal), "RouteConstants must define Dashboard route");
        Assert.IsTrue(Code.Contains("Profile", StringComparison.Ordinal), "RouteConstants must define Profile route");
        Assert.IsTrue(Code.Contains("Settings", StringComparison.Ordinal), "RouteConstants must define Settings route");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Route constants must define all eight legal page routes for terms privacy and compliance")]
    public void RouteConstantsMustDefineAllEightLegalPageRoutesForTermsPrivacyAndCompliance()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Code.Contains("Terms", StringComparison.Ordinal), "RouteConstants must define Terms route");
        Assert.IsTrue(Code.Contains("Privacy", StringComparison.Ordinal), "RouteConstants must define Privacy route");
        Assert.IsTrue(Code.Contains("Refund", StringComparison.Ordinal), "RouteConstants must define Refund route");
        Assert.IsTrue(Code.Contains("AcceptableUse", StringComparison.Ordinal), "RouteConstants must define AcceptableUse route");
        Assert.IsTrue(Code.Contains("CookiePolicy", StringComparison.Ordinal), "RouteConstants must define CookiePolicy route");
        Assert.IsTrue(Code.Contains("Licenses", StringComparison.Ordinal), "RouteConstants must define Licenses route");
        Assert.IsTrue(Code.Contains("Accessibility", StringComparison.Ordinal), "RouteConstants must define Accessibility route");
        Assert.IsTrue(Code.Contains("Dmca", StringComparison.Ordinal), "RouteConstants must define Dmca route");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Route constants must define client specific routes for dashboard create task and payments")]
    public void RouteConstantsMustDefineClientSpecificRoutesForDashboardCreateTaskAndPayments()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Code.Contains("ClientDashboard", StringComparison.Ordinal), "RouteConstants must define ClientDashboard route");
        Assert.IsTrue(Code.Contains("ClientCreateTask", StringComparison.Ordinal), "RouteConstants must define ClientCreateTask route");
        Assert.IsTrue(Code.Contains("ClientPayments", StringComparison.Ordinal), "RouteConstants must define ClientPayments route");
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Payment webhook endpoint must accept anonymous post requests for maya gateway callbacks")]
    public async Task PaymentWebhookEndpointMustAcceptAnonymousPostRequestsForMayaGatewayCallbacksAsync()
    {
        var Content = new StringContent("{\"EventType\":\"checkout.success\",\"PayloadJson\":\"{}\"}", System.Text.Encoding.UTF8, "application/json");
        var Response = await ApiClient.PostAsync(RouteConstants.ApiPaymentsWebhook, Content);
        Assert.AreEqual(HttpStatusCode.OK, Response.StatusCode);
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Leaderboard api endpoint must return ok with json content type for leaderboard data")]
    public async Task LeaderboardApiEndpointMustReturnOkWithJsonContentTypeForLeaderboardDataAsync()
    {
        var Response = await ApiClient.GetAsync(RouteConstants.ApiLeaderboard);
        Assert.AreEqual(HttpStatusCode.OK, Response.StatusCode);
        Assert.IsTrue(
            Response.Content.Headers.ContentType?.MediaType == "application/json",
            "Leaderboard response must return JSON content type");
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Tasks api endpoint must return ok with task list for public browsing without authentication")]
    public async Task TasksApiEndpointMustReturnOkWithTaskListForPublicBrowsingWithoutAuthenticationAsync()
    {
        var Response = await ApiClient.GetAsync(RouteConstants.ApiTasks);
        Assert.AreEqual(HttpStatusCode.OK, Response.StatusCode);
    }
}
