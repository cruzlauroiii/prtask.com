using System.Net;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Testing;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.E2E;
[TestClass]
public class ApiEndpointTests
{
    private static WebApplicationFactory<Program> Factory { get; set; } = null!;
    private static HttpClient Client { get; set; } = null!;
    [ClassInitialize]
    public static void ClassInitializeApiTestFactory(TestContext Context)
    {
        Factory = new WebApplicationFactory<Program>();
        Client = Factory.CreateClient();
    }
    [ClassCleanup]
    public static void ClassCleanupApiTestFactory()
    {
        Client.Dispose();
        Factory.Dispose();
    }
    [TestMethod, TestCategory("Api")]
    [DisplayName("Get tasks endpoint must return successful status code with empty list for fresh server")]
    public async Task GetTasksEndpointMustReturnSuccessfulStatusCodeWithEmptyListForFreshServerAsync()
    {
        var Response = await Client.GetAsync(RouteConstants.ApiTasks);
        Assert.AreEqual(HttpStatusCode.OK, Response.StatusCode);
        var Tasks = await Response.Content.ReadFromJsonAsync<TaskEntity[]>();
        Assert.IsNotNull(Tasks);
    }
    [TestMethod, TestCategory("Api")]
    [DisplayName("Get leaderboard endpoint must return successful status code with empty rankings initially")]
    public async Task GetLeaderboardEndpointMustReturnSuccessfulStatusCodeWithEmptyRankingsInitiallyAsync()
    {
        var Response = await Client.GetAsync(RouteConstants.ApiLeaderboard);
        Assert.AreEqual(HttpStatusCode.OK, Response.StatusCode);
        var Entries = await Response.Content.ReadFromJsonAsync<LeaderboardEntry[]>();
        Assert.IsNotNull(Entries);
    }
    [TestMethod, TestCategory("Api")]
    [DisplayName("Get single task by nonexistent identifier must return not found status code")]
    public async Task GetSingleTaskByNonexistentIdentifierMustReturnNotFoundStatusCodeAsync()
    {
        var Response = await Client.GetAsync($"{RouteConstants.ApiTasks}/nonexistent-id");
        Assert.AreEqual(HttpStatusCode.NotFound, Response.StatusCode);
    }
    [TestMethod, TestCategory("Api")]
    [DisplayName("Get single pull request by nonexistent identifier must return not found status code")]
    public async Task GetSinglePullRequestByNonexistentIdentifierMustReturnNotFoundStatusCodeAsync()
    {
        var Response = await Client.GetAsync($"{RouteConstants.ApiPullRequests}/nonexistent-id");
        Assert.AreEqual(HttpStatusCode.NotFound, Response.StatusCode);
    }
    [TestMethod, TestCategory("Api")]
    [DisplayName("Get leaderboard rank by user identifier must return successful status code with rank")]
    public async Task GetLeaderboardRankByUserIdentifierMustReturnSuccessfulStatusCodeWithRankAsync()
    {
        var Response = await Client.GetAsync($"{RouteConstants.ApiLeaderboard}/some-user-id");
        Assert.AreEqual(HttpStatusCode.OK, Response.StatusCode);
    }
    [TestMethod, TestCategory("Api")]
    [DisplayName("Get payment status endpoint must return successful status code for any payment identifier")]
    public async Task GetPaymentStatusEndpointMustReturnSuccessfulStatusCodeForAnyPaymentIdentifierAsync()
    {
        var Response = await Client.GetAsync($"{RouteConstants.ApiPaymentsStatus}/test-payment-id");
        Assert.AreEqual(HttpStatusCode.OK, Response.StatusCode);
    }
    [TestMethod, TestCategory("Api")]
    [DisplayName("Auth github endpoint must redirect to github authorization url for oauth flow")]
    public async Task AuthGitHubEndpointMustRedirectToGitHubAuthorizationUrlForOauthFlowAsync()
    {
        var NoRedirectClient = Factory.CreateDefaultClient(new NoAutoRedirectHandler());
        var Response = await NoRedirectClient.GetAsync(RouteConstants.ApiAuthGitHub);
        Assert.AreEqual(HttpStatusCode.Redirect, Response.StatusCode);
        Assert.IsTrue(Response.Headers.Location?.ToString().StartsWith(GitHubConstants.AuthorizeUrl, StringComparison.Ordinal) ?? false);
        NoRedirectClient.Dispose();
    }
    [TestMethod, TestCategory("Api")]
    [DisplayName("Post auth logout endpoint must return successful status code for session termination")]
    public async Task PostAuthLogoutEndpointMustReturnSuccessfulStatusCodeForSessionTerminationAsync()
    {
        var Response = await Client.PostAsync(RouteConstants.ApiAuthLogout, null);
        Assert.AreEqual(HttpStatusCode.OK, Response.StatusCode);
    }
    [TestMethod, TestCategory("Api")]
    [DisplayName("Post create task endpoint must return unauthorized when not authenticated")]
    public async Task PostCreateTaskEndpointMustReturnUnauthorizedWhenNotAuthenticatedAsync()
    {
        var Task = new TaskEntity { Id = "test-1", ClientId = "client-1", Title = "Test", Description = "Test desc", RepoUrl = "https://github.com/test/repo" };
        var Response = await Client.PostAsJsonAsync(RouteConstants.ApiTasks, Task);
        Assert.AreEqual(HttpStatusCode.Unauthorized, Response.StatusCode);
    }
    [TestMethod, TestCategory("Api")]
    [DisplayName("Post submit pull request endpoint must return unauthorized when not authenticated")]
    public async Task PostSubmitPullRequestEndpointMustReturnUnauthorizedWhenNotAuthenticatedAsync()
    {
        var Pr = new PullRequestEntity { Id = "pr-1", TaskId = "task-1", DeveloperId = "dev-1" };
        var Response = await Client.PostAsJsonAsync(RouteConstants.ApiPullRequests, Pr);
        Assert.AreEqual(HttpStatusCode.Unauthorized, Response.StatusCode);
    }
    [TestMethod, TestCategory("Api")]
    [DisplayName("Post payment checkout endpoint must return unauthorized when not authenticated")]
    public async Task PostPaymentCheckoutEndpointMustReturnUnauthorizedWhenNotAuthenticatedAsync()
    {
        var Response = await Client.PostAsJsonAsync(RouteConstants.ApiPaymentsCheckout, new { TaskId = "t1", PayerId = "p1", AmountCents = 10000 });
        Assert.AreEqual(HttpStatusCode.Unauthorized, Response.StatusCode);
    }
    [TestMethod, TestCategory("Api")]
    [DisplayName("Get auth me endpoint must return unauthorized when not authenticated")]
    public async Task GetAuthMeEndpointMustReturnUnauthorizedWhenNotAuthenticatedAsync()
    {
        var Response = await Client.GetAsync(RouteConstants.ApiAuthMe);
        Assert.AreEqual(HttpStatusCode.Unauthorized, Response.StatusCode);
    }
    [TestMethod, TestCategory("Api")]
    [DisplayName("Post webhook endpoint must return successful status code without authentication")]
    public async Task PostWebhookEndpointMustReturnSuccessfulStatusCodeWithoutAuthenticationAsync()
    {
        var Response = await Client.PostAsJsonAsync(RouteConstants.ApiPaymentsWebhook, new { EventType = "checkout.success", PayloadJson = "{}" });
        Assert.AreEqual(HttpStatusCode.OK, Response.StatusCode);
    }
    [TestMethod, TestCategory("Api")]
    [DisplayName("Auth google endpoint must redirect to google authorization url with pkce code challenge")]
    public async Task AuthGoogleEndpointMustRedirectToGoogleAuthorizationUrlWithPkceCodeChallengeAsync()
    {
        var NoRedirectClient = Factory.CreateDefaultClient(new NoAutoRedirectHandler());
        var Response = await NoRedirectClient.GetAsync(RouteConstants.ApiAuthGoogle);
        Assert.AreEqual(HttpStatusCode.Redirect, Response.StatusCode);
        var Location = Response.Headers.Location?.ToString() ?? string.Empty;
        Assert.IsTrue(Location.StartsWith(GoogleConstants.AuthorizeUrl, StringComparison.Ordinal), $"Expected redirect to Google, got: {Location}");
        Assert.IsTrue(Location.Contains("code_challenge="), "Missing PKCE code_challenge parameter");
        Assert.IsTrue(Location.Contains("code_challenge_method=S256"), "Missing PKCE S256 method");
        NoRedirectClient.Dispose();
    }
    [TestMethod, TestCategory("Api")]
    [DisplayName("Auth azure endpoint must redirect to azure login url with pkce code challenge for sso")]
    public async Task AuthAzureEndpointMustRedirectToAzureLoginUrlWithPkceCodeChallengeForSsoAsync()
    {
        var NoRedirectClient = Factory.CreateDefaultClient(new NoAutoRedirectHandler());
        var Response = await NoRedirectClient.GetAsync(RouteConstants.ApiAuthAzure);
        Assert.AreEqual(HttpStatusCode.Redirect, Response.StatusCode);
        var Location = Response.Headers.Location?.ToString() ?? string.Empty;
        Assert.IsTrue(Location.Contains("login.microsoftonline.com"), $"Expected redirect to Azure, got: {Location}");
        Assert.IsTrue(Location.Contains("code_challenge="), "Missing PKCE code_challenge parameter");
        Assert.IsTrue(Location.Contains("code_challenge_method=S256"), "Missing PKCE S256 method");
        NoRedirectClient.Dispose();
    }
    [TestMethod, TestCategory("Api")]
    [DisplayName("Auth okta endpoint must redirect to okta authorization url with pkce code challenge for sso")]
    public async Task AuthOktaEndpointMustRedirectToOktaAuthorizationUrlWithPkceCodeChallengeForSsoAsync()
    {
        var NoRedirectClient = Factory.CreateDefaultClient(new NoAutoRedirectHandler());
        var Response = await NoRedirectClient.GetAsync(RouteConstants.ApiAuthOkta);
        Assert.AreEqual(HttpStatusCode.Redirect, Response.StatusCode);
        var Location = Response.Headers.Location?.ToString() ?? string.Empty;
        Assert.IsTrue(Location.Contains("code_challenge="), "Missing PKCE code_challenge parameter");
        Assert.IsTrue(Location.Contains("code_challenge_method=S256"), "Missing PKCE S256 method");
        NoRedirectClient.Dispose();
    }
    [TestMethod, TestCategory("Api")]
    [DisplayName("Auth google redirect must include openid email profile scope for full user information")]
    public async Task AuthGoogleRedirectMustIncludeOpenidEmailProfileScopeForFullUserInformationAsync()
    {
        var NoRedirectClient = Factory.CreateDefaultClient(new NoAutoRedirectHandler());
        var Response = await NoRedirectClient.GetAsync(RouteConstants.ApiAuthGoogle);
        var Location = Response.Headers.Location?.ToString() ?? string.Empty;
        Assert.IsTrue(Location.Contains("scope="), "Missing scope parameter in Google redirect");
        Assert.IsTrue(Location.Contains("openid"), "Missing openid in scope");
        NoRedirectClient.Dispose();
    }
    [TestMethod, TestCategory("Api")]
    [DisplayName("Auth azure redirect must include response type code for authorization code flow")]
    public async Task AuthAzureRedirectMustIncludeResponseTypeCodeForAuthorizationCodeFlowAsync()
    {
        var NoRedirectClient = Factory.CreateDefaultClient(new NoAutoRedirectHandler());
        var Response = await NoRedirectClient.GetAsync(RouteConstants.ApiAuthAzure);
        var Location = Response.Headers.Location?.ToString() ?? string.Empty;
        Assert.IsTrue(Location.Contains("response_type=code"), "Missing response_type=code in Azure redirect");
        NoRedirectClient.Dispose();
    }
    [TestMethod, TestCategory("Api")]
    [DisplayName("Auth github redirect must include required scope for user read and email access")]
    public async Task AuthGitHubRedirectMustIncludeRequiredScopeForUserReadAndEmailAccessAsync()
    {
        var NoRedirectClient = Factory.CreateDefaultClient(new NoAutoRedirectHandler());
        var Response = await NoRedirectClient.GetAsync(RouteConstants.ApiAuthGitHub);
        var Location = Response.Headers.Location?.ToString() ?? string.Empty;
        Assert.IsTrue(Location.Contains("scope="), "Missing scope parameter in GitHub redirect");
        NoRedirectClient.Dispose();
    }
    [TestMethod, TestCategory("Api")]
    [DisplayName("Post claim task endpoint must return unauthorized when not authenticated for task claiming")]
    public async Task PostClaimTaskEndpointMustReturnUnauthorizedWhenNotAuthenticatedForTaskClaimingAsync()
    {
        var Response = await Client.PostAsync($"{RouteConstants.ApiTasks}/test-task-id/claim", null);
        Assert.AreEqual(HttpStatusCode.Unauthorized, Response.StatusCode);
    }
    [TestMethod, TestCategory("Api")]
    [DisplayName("Post approve pull request endpoint must return unauthorized when not authenticated")]
    public async Task PostApprovePullRequestEndpointMustReturnUnauthorizedWhenNotAuthenticatedAsync()
    {
        var Response = await Client.PostAsync($"{RouteConstants.ApiPullRequests}/test-pr-id/approve", null);
        Assert.AreEqual(HttpStatusCode.Unauthorized, Response.StatusCode);
    }
    [TestMethod, TestCategory("Api")]
    [DisplayName("Post reject pull request endpoint must return unauthorized when not authenticated")]
    public async Task PostRejectPullRequestEndpointMustReturnUnauthorizedWhenNotAuthenticatedAsync()
    {
        var Response = await Client.PostAsync($"{RouteConstants.ApiPullRequests}/test-pr-id/reject", null);
        Assert.AreEqual(HttpStatusCode.Unauthorized, Response.StatusCode);
    }
    [TestMethod, TestCategory("Api")]
    [DisplayName("Get developer pull requests endpoint must return successful status code with empty list")]
    public async Task GetDeveloperPullRequestsEndpointMustReturnSuccessfulStatusCodeWithEmptyListAsync()
    {
        var Response = await Client.GetAsync($"{RouteConstants.ApiPullRequests}/developer/some-dev-id");
        Assert.AreEqual(HttpStatusCode.OK, Response.StatusCode);
    }
    private sealed class NoAutoRedirectHandler : DelegatingHandler
    {
        public NoAutoRedirectHandler()
            : base(new HttpClientHandler { AllowAutoRedirect = false })
        {
        }
    }
}
