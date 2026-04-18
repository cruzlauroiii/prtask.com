using System.Net;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request endpoints must have approve and reject routes with authorization requirement")]
    public void PullRequestEndpointsMustHaveApproveAndRejectRoutesWithAuthorizationRequirement()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "PullRequestEndpoints.cs");
        Assert.IsTrue(Code.Contains("/approve", StringComparison.Ordinal), "PREndpoints must have approve route");
        Assert.IsTrue(Code.Contains("/reject", StringComparison.Ordinal), "PREndpoints must have reject route");
        Assert.IsTrue(Code.Contains("RequireAuthorization", StringComparison.Ordinal), "Approve and reject must require authorization");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request endpoints must have submit route returning created with location header")]
    public void PullRequestEndpointsMustHaveSubmitRouteReturningCreatedWithLocationHeader()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "PullRequestEndpoints.cs");
        Assert.IsTrue(Code.Contains("MapPost(\"/\"", StringComparison.Ordinal), "PREndpoints must have POST route for submission");
        Assert.IsTrue(Code.Contains("Results.Created", StringComparison.Ordinal), "Submit must return 201 Created with location");
        Assert.IsTrue(Code.Contains("SubmitAsync", StringComparison.Ordinal), "Submit must call SubmitAsync on service");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request endpoints must have list by developer route for developer portfolio view")]
    public void PullRequestEndpointsMustHaveListByDeveloperRouteForDeveloperPortfolioView()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "PullRequestEndpoints.cs");
        Assert.IsTrue(Code.Contains("developer/{DeveloperId}", StringComparison.Ordinal), "PREndpoints must have route to list PRs by developer");
        Assert.IsTrue(Code.Contains("ListByDeveloperAsync", StringComparison.Ordinal), "PREndpoints must call ListByDeveloperAsync on service");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request endpoints must pass rejection notes from request body to service reject method")]
    public void PullRequestEndpointsMustPassRejectionNotesFromRequestBodyToServiceRejectMethod()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "PullRequestEndpoints.cs");
        Assert.IsTrue(Code.Contains("RejectPullRequestRequest", StringComparison.Ordinal), "Reject must accept RejectPullRequestRequest body");
        Assert.IsTrue(Code.Contains("Request.Notes", StringComparison.Ordinal), "Reject must pass notes from request to service");
        Assert.IsTrue(Code.Contains("RejectAsync", StringComparison.Ordinal), "Reject must call RejectAsync on service");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task endpoints must have claim route accepting developer id for task assignment workflow")]
    public void TaskEndpointsMustHaveClaimRouteAcceptingDeveloperIdForTaskAssignmentWorkflow()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "TaskEndpoints.cs");
        Assert.IsTrue(Code.Contains("/claim", StringComparison.Ordinal), "TaskEndpoints must have claim route");
        Assert.IsTrue(Code.Contains("ClaimTaskRequest", StringComparison.Ordinal), "Claim must accept ClaimTaskRequest body");
        Assert.IsTrue(Code.Contains("ClaimAsync", StringComparison.Ordinal), "Claim must call ClaimAsync on service");
        Assert.IsTrue(Code.Contains("Request.DeveloperId", StringComparison.Ordinal), "Claim must pass developer ID from request");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task endpoints must return not found for nonexistent task on patch update request")]
    public void TaskEndpointsMustReturnNotFoundForNonexistentTaskOnPatchUpdateRequest()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "TaskEndpoints.cs");
        Assert.IsTrue(Code.Contains("MapPatch", StringComparison.Ordinal), "TaskEndpoints must have PATCH route for updates");
        Assert.IsTrue(Code.Contains("Results.NotFound", StringComparison.Ordinal), "PATCH must return NotFound for nonexistent tasks");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task endpoints must return no content on successful delete and created on post create")]
    public void TaskEndpointsMustReturnNoContentOnSuccessfulDeleteAndCreatedOnPostCreate()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "TaskEndpoints.cs");
        Assert.IsTrue(Code.Contains("Results.NoContent", StringComparison.Ordinal), "Delete must return 204 NoContent");
        Assert.IsTrue(Code.Contains("Results.Created", StringComparison.Ordinal), "Create must return 201 Created with location");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui program must register blazor webview and configure android lifecycle status bar events")]
    public void MauiProgramMustRegisterBlazorWebViewAndConfigureAndroidLifecycleStatusBarEvents()
    {
        var Code = ReadSourceFile("PrTask.Maui", "MauiProgram.cs");
        Assert.IsTrue(Code.Contains("AddMauiBlazorWebView", StringComparison.Ordinal), "MauiProgram must register Blazor WebView");
        Assert.IsTrue(Code.Contains("ConfigureLifecycleEvents", StringComparison.Ordinal), "MauiProgram must configure lifecycle events");
        Assert.IsTrue(Code.Contains("ConfigureAndroidStatusBar", StringComparison.Ordinal), "MauiProgram must configure Android status bar");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui program must add developer tools in debug mode only for webview debugging support")]
    public void MauiProgramMustAddDeveloperToolsInDebugModeOnlyForWebViewDebuggingSupport()
    {
        var Code = ReadSourceFile("PrTask.Maui", "MauiProgram.cs");
        Assert.IsTrue(Code.Contains("#if DEBUG", StringComparison.Ordinal), "MauiProgram must conditionally compile debug tools");
        Assert.IsTrue(Code.Contains("AddBlazorWebViewDeveloperTools", StringComparison.Ordinal), "MauiProgram must add developer tools in debug builds");
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Pull request approve endpoint must return unauthorized when not authenticated for pr approval")]
    public async Task PullRequestApproveEndpointMustReturnUnauthorizedWhenNotAuthenticatedForPrApprovalAsync()
    {
        var Response = await ApiClient.PostAsync($"{RouteConstants.ApiPullRequests}/test-pr-id/approve", null);
        Assert.AreEqual(HttpStatusCode.Unauthorized, Response.StatusCode);
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Pull request reject endpoint must return unauthorized when not authenticated for pr rejection")]
    public async Task PullRequestRejectEndpointMustReturnUnauthorizedWhenNotAuthenticatedForPrRejectionAsync()
    {
        var Content = new StringContent("{\"Notes\":\"test\"}", System.Text.Encoding.UTF8, "application/json");
        var Response = await ApiClient.PostAsync($"{RouteConstants.ApiPullRequests}/test-pr-id/reject", Content);
        Assert.AreEqual(HttpStatusCode.Unauthorized, Response.StatusCode);
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Pull request submit endpoint must return unauthorized when not authenticated for pr submission")]
    public async Task PullRequestSubmitEndpointMustReturnUnauthorizedWhenNotAuthenticatedForPrSubmissionAsync()
    {
        var Content = new StringContent("{\"Id\":\"pr1\",\"TaskId\":\"t1\",\"DeveloperId\":\"d1\"}", System.Text.Encoding.UTF8, "application/json");
        var Response = await ApiClient.PostAsync(RouteConstants.ApiPullRequests, Content);
        Assert.AreEqual(HttpStatusCode.Unauthorized, Response.StatusCode);
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Task claim endpoint must return unauthorized when not authenticated for task claiming")]
    public async Task TaskClaimEndpointMustReturnUnauthorizedWhenNotAuthenticatedForTaskClaimingAsync()
    {
        var Content = new StringContent("{\"DeveloperId\":\"dev1\"}", System.Text.Encoding.UTF8, "application/json");
        var Response = await ApiClient.PostAsync($"{RouteConstants.ApiTasks}/test-task-id/claim", Content);
        Assert.AreEqual(HttpStatusCode.Unauthorized, Response.StatusCode);
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Task create endpoint must return unauthorized when not authenticated for task creation")]
    public async Task TaskCreateEndpointMustReturnUnauthorizedWhenNotAuthenticatedForTaskCreationAsync()
    {
        var Content = new StringContent("{\"Id\":\"t1\",\"ClientId\":\"c1\",\"Title\":\"Test\",\"Description\":\"Test\",\"RepoUrl\":\"https://github.com/test\"}", System.Text.Encoding.UTF8, "application/json");
        var Response = await ApiClient.PostAsync(RouteConstants.ApiTasks, Content);
        Assert.AreEqual(HttpStatusCode.Unauthorized, Response.StatusCode);
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Get task by id endpoint must return not found for nonexistent task identifier")]
    public async Task GetTaskByIdEndpointMustReturnNotFoundForNonexistentTaskIdentifierAsync()
    {
        var Response = await ApiClient.GetAsync($"{RouteConstants.ApiTasks}/nonexistent-task-id");
        Assert.AreEqual(HttpStatusCode.NotFound, Response.StatusCode);
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Get pull request by id endpoint must return not found for nonexistent pr identifier")]
    public async Task GetPullRequestByIdEndpointMustReturnNotFoundForNonexistentPrIdentifierAsync()
    {
        var Response = await ApiClient.GetAsync($"{RouteConstants.ApiPullRequests}/nonexistent-pr-id");
        Assert.AreEqual(HttpStatusCode.NotFound, Response.StatusCode);
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Get pull requests by developer endpoint must return ok with empty list for unknown developer")]
    public async Task GetPullRequestsByDeveloperEndpointMustReturnOkWithEmptyListForUnknownDeveloperAsync()
    {
        var Response = await ApiClient.GetAsync($"{RouteConstants.ApiPullRequests}/developer/unknown-dev-id");
        Assert.AreEqual(HttpStatusCode.OK, Response.StatusCode);
    }
}
