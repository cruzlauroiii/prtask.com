using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class FeatureTests
{
    private static WebApplicationFactory<Program> ApiFactory { get; set; } = null!;
    private static HttpClient ApiClient { get; set; } = null!;
    [ClassInitialize]
    public static void ClassInitializeFeatureTestFactory(TestContext Context)
    {
        ApiFactory = new WebApplicationFactory<Program>();
        ApiClient = ApiFactory.CreateClient();
    }
    [ClassCleanup]
    public static void ClassCleanupFeatureTestFactory()
    {
        ApiClient.Dispose();
        ApiFactory.Dispose();
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Maui index html must define prtask get user javascript function for auth state persistence")]
    public void MauiIndexHtmlMustDefinePrtaskGetUserJavascriptFunctionForAuthStatePersistence()
    {
        var Html = ReadSourceFile("PrTask.Maui", "wwwroot", "index.html");
        Assert.IsTrue(
            Html.Contains("prtaskGetUser", StringComparison.Ordinal),
            "MAUI index.html must define prtaskGetUser() function for NavMenu auth state");
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Client index html must define prtask get user javascript function for auth state persistence")]
    public void ClientIndexHtmlMustDefinePrtaskGetUserJavascriptFunctionForAuthStatePersistence()
    {
        var Html = ReadSourceFile("PrTask.Client", "wwwroot", "index.html");
        Assert.IsTrue(
            Html.Contains("prtaskGetUser", StringComparison.Ordinal),
            "Client index.html must define prtaskGetUser() function for NavMenu auth state");
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Both index html files must define prtask set user function for storing auth state")]
    public void BothIndexHtmlFilesMustDefinePrtaskSetUserFunctionForStoringAuthState()
    {
        var MauiHtml = ReadSourceFile("PrTask.Maui", "wwwroot", "index.html");
        var ClientHtml = ReadSourceFile("PrTask.Client", "wwwroot", "index.html");
        Assert.IsTrue(MauiHtml.Contains("prtaskSetUser", StringComparison.Ordinal), "MAUI index.html must define prtaskSetUser()");
        Assert.IsTrue(ClientHtml.Contains("prtaskSetUser", StringComparison.Ordinal), "Client index.html must define prtaskSetUser()");
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Task detail page must inject pull request service to load pr list dynamically")]
    public void TaskDetailPageMustInjectPullRequestServiceToLoadPrListDynamically()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "TaskDetailPage.razor");
        Assert.IsTrue(
            Razor.Contains("IPullRequestService", StringComparison.Ordinal),
            "TaskDetailPage must inject IPullRequestService to dynamically load PRs for the task");
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Task detail page must call list by task async to fetch pull requests for client selection")]
    public void TaskDetailPageMustCallListByTaskAsyncToFetchPullRequestsForClientSelection()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "TaskDetailPage.razor");
        Assert.IsTrue(
            Razor.Contains("ListByTaskAsync", StringComparison.Ordinal),
            "TaskDetailPage must call ListByTaskAsync to fetch all PRs submitted for this task");
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Pull request endpoints must have route to list prs by task id for client review")]
    public void PullRequestEndpointsMustHaveRouteToListPrsByTaskIdForClientReview()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "PullRequestEndpoints.cs");
        Assert.IsTrue(
            Code.Contains("task/{TaskId}", StringComparison.OrdinalIgnoreCase)
            || Code.Contains("ListByTaskAsync", StringComparison.Ordinal),
            "PullRequestEndpoints must have a GET route to list PRs by task ID");
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Get pull requests by task endpoint must return successful status code with list")]
    public async Task GetPullRequestsByTaskEndpointMustReturnSuccessfulStatusCodeWithListAsync()
    {
        var Response = await ApiClient.GetAsync($"{RouteConstants.ApiPullRequests}/task/some-task-id");
        Assert.AreEqual(HttpStatusCode.OK, Response.StatusCode);
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Delete task endpoint must return unauthorized when not authenticated for task deletion")]
    public async Task DeleteTaskEndpointMustReturnUnauthorizedWhenNotAuthenticatedForTaskDeletionAsync()
    {
        var Response = await ApiClient.DeleteAsync($"{RouteConstants.ApiTasks}/test-task-id");
        Assert.AreEqual(HttpStatusCode.Unauthorized, Response.StatusCode);
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Patch task endpoint must return unauthorized when not authenticated for task update")]
    public async Task PatchTaskEndpointMustReturnUnauthorizedWhenNotAuthenticatedForTaskUpdateAsync()
    {
        var Content = new StringContent("{}", System.Text.Encoding.UTF8, "application/json");
        var Request = new HttpRequestMessage(HttpMethod.Patch, $"{RouteConstants.ApiTasks}/test-task-id") { Content = Content };
        var Response = await ApiClient.SendAsync(Request);
        Assert.AreEqual(HttpStatusCode.Unauthorized, Response.StatusCode);
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Task detail page must render pr cards with review link for each submitted pull request")]
    public void TaskDetailPageMustRenderPrCardsWithReviewLinkForEachSubmittedPullRequest()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "TaskDetailPage.razor");
        Assert.IsTrue(Razor.Contains("pr-card", StringComparison.Ordinal), "TaskDetailPage must render pr-card elements for each PR");
        Assert.IsTrue(Razor.Contains("Review PR", StringComparison.Ordinal), "TaskDetailPage must have Review PR link for each PR card");
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Both index html files must define prtask check auth function to verify server side auth state")]
    public void BothIndexHtmlFilesMustDefinePrtaskCheckAuthFunctionToVerifyServerSideAuthState()
    {
        var ClientHtml = ReadSourceFile("PrTask.Client", "wwwroot", "index.html");
        var MauiHtml = ReadSourceFile("PrTask.Maui", "wwwroot", "index.html");
        Assert.IsTrue(ClientHtml.Contains("prtaskCheckAuth", StringComparison.Ordinal), "Client index.html must define prtaskCheckAuth()");
        Assert.IsTrue(MauiHtml.Contains("prtaskCheckAuth", StringComparison.Ordinal), "MAUI index.html must define prtaskCheckAuth()");
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Nav menu must call prtask check auth to verify authentication state from server")]
    public void NavMenuMustCallPrtaskCheckAuthToVerifyAuthenticationStateFromServer()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(
            Razor.Contains("prtaskCheckAuth", StringComparison.Ordinal),
            "NavMenu must call prtaskCheckAuth to verify server-side auth state via /api/auth/me");
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Auth check function must call api auth me endpoint to verify cookie based authentication")]
    public void AuthCheckFunctionMustCallApiAuthMeEndpointToVerifyCookieBasedAuthentication()
    {
        var ClientHtml = ReadSourceFile("PrTask.Client", "wwwroot", "index.html");
        Assert.IsTrue(
            ClientHtml.Contains("/api/auth/me", StringComparison.Ordinal),
            "prtaskCheckAuth must call /api/auth/me to verify if the user has a valid auth cookie");
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Auth callbacks must redirect to dashboard after successful sso login flow")]
    public void AuthCallbacksMustRedirectToDashboardAfterSuccessfulSsoLoginFlow()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(
            Code.Contains("Results.Redirect(RouteConstants.Dashboard)", StringComparison.Ordinal),
            "Auth callbacks must redirect to dashboard after successful authentication");
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Nav menu sign out must use post request not anchor tag to match server logout endpoint")]
    public void NavMenuSignOutMustUsePostRequestNotAnchorTagToMatchServerLogoutEndpoint()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsFalse(
            Razor.Contains("href=\"/api/auth/logout\"", StringComparison.Ordinal),
            "NavMenu must NOT use <a href> for logout because the endpoint is POST-only; must use JS fetch with POST method");
        Assert.IsTrue(
            Razor.Contains("SignOutAsync", StringComparison.Ordinal),
            "NavMenu must call SignOutAsync method that sends POST request to logout endpoint");
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Both index html files must define prtask sign out function for post based logout")]
    public void BothIndexHtmlFilesMustDefinePrtaskSignOutFunctionForPostBasedLogout()
    {
        var ClientHtml = ReadSourceFile("PrTask.Client", "wwwroot", "index.html");
        var MauiHtml = ReadSourceFile("PrTask.Maui", "wwwroot", "index.html");
        Assert.IsTrue(ClientHtml.Contains("prtaskSignOut", StringComparison.Ordinal), "Client index.html must define prtaskSignOut()");
        Assert.IsTrue(MauiHtml.Contains("prtaskSignOut", StringComparison.Ordinal), "MAUI index.html must define prtaskSignOut()");
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Sign out function must use post method to call api auth logout endpoint correctly")]
    public void SignOutFunctionMustUsePostMethodToCallApiAuthLogoutEndpointCorrectly()
    {
        var ClientHtml = ReadSourceFile("PrTask.Client", "wwwroot", "index.html");
        Assert.IsTrue(
            ClientHtml.Contains("\"POST\"", StringComparison.Ordinal),
            "prtaskSignOut must use POST method since the server logout endpoint is MapPost");
        Assert.IsTrue(
            ClientHtml.Contains("/api/auth/logout", StringComparison.Ordinal),
            "prtaskSignOut must call the /api/auth/logout endpoint");
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Client project must have task detail page wrapper for shared ui task detail component")]
    public void ClientProjectMustHaveTaskDetailPageWrapperForSharedUiTaskDetailComponent()
    {
        Assert.IsTrue(
            SourceFileExists("PrTask.Client", "Pages", "ClientTaskDetailPage.razor"),
            "Client project must have ClientTaskDetailPage.razor wrapping SharedUI TaskDetailPage");
        var Razor = ReadSourceFile("PrTask.Client", "Pages", "ClientTaskDetailPage.razor");
        Assert.IsTrue(
            Razor.Contains("TaskDetailPage", StringComparison.Ordinal),
            "ClientTaskDetailPage must reference the SharedUI TaskDetailPage component");
    }
}
