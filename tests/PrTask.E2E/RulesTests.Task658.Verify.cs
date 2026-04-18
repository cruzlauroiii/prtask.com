using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
   private static string Wf658_UserId = string.Empty;
   private static string Wf658_CreatedTaskId = string.Empty;
   private static string Wf658_CreatedPrId = string.Empty;
   private static string Wf658_CreatedCommentId = string.Empty;
   private static async Task Wf658_CaptureUserIdAsync(HttpResponseMessage LoginResp)
   {
       var Body = await LoginResp.Content.ReadAsStringAsync();
       using var Doc = JsonDocument.Parse(Body);
       Wf658_UserId = Doc.RootElement.GetProperty("id").GetString() ?? string.Empty;
       Assert.IsTrue(Wf658_UserId.Length > 0, $"658: Dev login must return user ID, got: {Body}");
   }
   private static async Task Wf658_CreateTaskViaApiAsync()
   {
       var Resp = await Wf658Http!.PostAsJsonAsync(RouteConstants.ApiTasks, new
       {
           ClientId = Wf658_UserId,
           Title = E2ECrudConstants.TaskTitle,
           Description = E2ECrudConstants.TaskDescription,
           RepoUrl = E2ECrudConstants.TaskRepoUrl,
           Complexity = 0,
           BountyAmountCents = E2ECrudConstants.BountyAmountCents,
           MaxClaims = 1,
           Tags = new[] { E2ECrudConstants.TagCsharp, E2ECrudConstants.TagE2E }
       });
       Assert.AreEqual(HttpStatusCode.Created, Resp.StatusCode,
           $"658-DB: Create task API must return 201, got {(int)Resp.StatusCode}");
       var Body = await Resp.Content.ReadAsStringAsync();
       using var Doc = JsonDocument.Parse(Body);
       Wf658_CreatedTaskId = Doc.RootElement.GetProperty("id").GetString() ?? string.Empty;
       Assert.IsTrue(Wf658_CreatedTaskId.Length > 0, "658-DB: Task ID must be returned");
   }
   private static async Task Wf658_VerifyTaskInDbAsync()
   {
       var Resp = await Wf658Http!.GetAsync(
           string.Format(RouteConstants.ApiTaskById, Wf658_CreatedTaskId));
       Assert.AreEqual(HttpStatusCode.OK, Resp.StatusCode,
           $"658-DB: GET task {Wf658_CreatedTaskId} must return 200");
       var Body = await Resp.Content.ReadAsStringAsync();
       using var Doc = JsonDocument.Parse(Body);
       var Root = Doc.RootElement;
       Assert.AreEqual(E2ECrudConstants.TaskTitle, Root.GetProperty("title").GetString(),
           "658-DB: Task title must match");
       Assert.AreEqual(E2ECrudConstants.TaskDescription,
           Root.GetProperty("description").GetString(), "658-DB: Task description must match");
       Assert.AreEqual(E2ECrudConstants.TaskRepoUrl, Root.GetProperty("repoUrl").GetString(),
           "658-DB: Task repoUrl must match");
       Assert.AreEqual(E2ECrudConstants.BountyAmountCents,
           Root.GetProperty("bountyAmountCents").GetInt64(), "658-DB: Task bounty must match");
       Assert.AreEqual(Wf658_UserId, Root.GetProperty("clientId").GetString(),
           "658-DB: Task clientId must match logged-in user");
   }
   private static async Task Wf658_SubmitPrViaApiAsync()
   {
       var Resp = await Wf658Http!.PostAsJsonAsync(RouteConstants.ApiPullRequests, new
       {
           TaskId = Wf658_CreatedTaskId,
           DeveloperId = Wf658_UserId,
           GitHubPrUrl = E2ECrudConstants.PrGitHubUrl
       });
       Assert.AreEqual(HttpStatusCode.Created, Resp.StatusCode,
           $"658-DB: Submit PR must return 201, got {(int)Resp.StatusCode}");
       var Body = await Resp.Content.ReadAsStringAsync();
       using var Doc = JsonDocument.Parse(Body);
       Wf658_CreatedPrId = Doc.RootElement.GetProperty("id").GetString() ?? string.Empty;
       Assert.IsTrue(Wf658_CreatedPrId.Length > 0, "658-DB: PR ID must be returned");
   }
   private static async Task Wf658_VerifyPrInDbAsync()
   {
       var Resp = await Wf658Http!.GetAsync(
           string.Format(RouteConstants.ApiPullRequestById, Wf658_CreatedPrId));
       Assert.AreEqual(HttpStatusCode.OK, Resp.StatusCode,
           $"658-DB: GET PR {Wf658_CreatedPrId} must return 200");
       var Body = await Resp.Content.ReadAsStringAsync();
       using var Doc = JsonDocument.Parse(Body);
       var Root = Doc.RootElement;
       Assert.AreEqual(Wf658_CreatedTaskId, Root.GetProperty("taskId").GetString(),
           "658-DB: PR taskId must match");
       Assert.AreEqual(Wf658_UserId, Root.GetProperty("developerId").GetString(),
           "658-DB: PR developerId must match");
       Assert.AreEqual(E2ECrudConstants.PrGitHubUrl,
           Root.GetProperty("gitHubPrUrl").GetString(), "658-DB: PR gitHubPrUrl must match");
       Assert.AreEqual("Submitted", Root.GetProperty("status").GetString(),
           "658-DB: PR initial status must be Submitted");
   }
   private static async Task Wf658_CreateCommentViaApiAsync()
   {
       var Resp = await Wf658Http!.PostAsJsonAsync(RouteConstants.ApiReviewComments, new
       {
           PullRequestId = Wf658_CreatedPrId,
           AuthorId = Wf658_UserId,
           Body = E2ECrudConstants.CommentBody,
           FilePath = E2ECrudConstants.CommentFilePath,
           LineNumber = E2ECrudConstants.CommentLineNumber
       });
       Assert.AreEqual(HttpStatusCode.Created, Resp.StatusCode,
           $"658-DB: Create comment must return 201, got {(int)Resp.StatusCode}");
       var Body = await Resp.Content.ReadAsStringAsync();
       using var Doc = JsonDocument.Parse(Body);
       Wf658_CreatedCommentId = Doc.RootElement.GetProperty("id").GetString() ?? string.Empty;
       Assert.IsTrue(Wf658_CreatedCommentId.Length > 0, "658-DB: Comment ID must be returned");
   }
   private static async Task Wf658_VerifyCommentInDbAsync()
   {
       var Resp = await Wf658Http!.GetAsync(
           string.Format(RouteConstants.ApiReviewCommentsByPr, Wf658_CreatedPrId));
       Assert.AreEqual(HttpStatusCode.OK, Resp.StatusCode,
           "658-DB: GET comments by PR must return 200");
       var Body = await Resp.Content.ReadAsStringAsync();
       using var Doc = JsonDocument.Parse(Body);
       var Comments = Doc.RootElement;
       Assert.IsTrue(Comments.GetArrayLength() > 0,
           "658-DB: At least one comment must exist for PR");
       var Found = false;
       foreach (var C in Comments.EnumerateArray())
       {
           if (C.GetProperty("id").GetString() == Wf658_CreatedCommentId)
           {
               Assert.AreEqual(E2ECrudConstants.CommentBody,
                   C.GetProperty("body").GetString(), "658-DB: Comment body must match");
               Assert.AreEqual(E2ECrudConstants.CommentFilePath,
                   C.GetProperty("filePath").GetString(), "658-DB: Comment filePath must match");
               Assert.AreEqual(E2ECrudConstants.CommentLineNumber,
                   C.GetProperty("lineNumber").GetInt32(), "658-DB: Comment line must match");
               Found = true;
               break;
           }
       }
       Assert.IsTrue(Found,
           $"658-DB: Comment {Wf658_CreatedCommentId} must exist in PR comments");
   }
   private static async Task Wf658_ApprovePrViaApiAsync()
   {
       var Resp = await Wf658Http!.PostAsync(
           string.Format(RouteConstants.ApiPullRequestApprove, Wf658_CreatedPrId), null);
       Assert.AreEqual(HttpStatusCode.OK, Resp.StatusCode,
           $"658-DB: Approve PR must return 200, got {(int)Resp.StatusCode}");
   }
   private static async Task Wf658_VerifyPrApprovedAsync()
   {
       var Resp = await Wf658Http!.GetAsync(
           string.Format(RouteConstants.ApiPullRequestById, Wf658_CreatedPrId));
       Assert.AreEqual(HttpStatusCode.OK, Resp.StatusCode,
           "658-DB: GET approved PR must return 200");
       var Body = await Resp.Content.ReadAsStringAsync();
       using var Doc = JsonDocument.Parse(Body);
       var Status = Doc.RootElement.GetProperty("status").GetString();
       Assert.AreEqual("Approved", Status,
           $"658-DB: PR status must be Approved, got: {Status}");
   }
   private static async Task Wf658_VerifyTaskListContainsCreatedAsync()
   {
       var Resp = await Wf658Http!.GetAsync(RouteConstants.ApiTasks);
       Assert.AreEqual(HttpStatusCode.OK, Resp.StatusCode,
           "658-DB: GET tasks list must return 200");
       var Body = await Resp.Content.ReadAsStringAsync();
       using var Doc = JsonDocument.Parse(Body);
       var Found = false;
       foreach (var T in Doc.RootElement.EnumerateArray())
       {
           if (T.GetProperty("id").GetString() == Wf658_CreatedTaskId)
           {
               Found = true;
               break;
           }
       }
       Assert.IsTrue(Found,
           $"658-DB: Created task {Wf658_CreatedTaskId} must appear in task list");
   }
   private static async Task Wf658_VerifyAuditLogExistsAsync()
   {
       var Resp = await Wf658Http!.GetAsync(RouteConstants.ApiAuditLogs);
       Assert.AreEqual(HttpStatusCode.OK, Resp.StatusCode,
           "658-DB: GET audit logs must return 200");
       var Body = await Resp.Content.ReadAsStringAsync();
       using var Doc = JsonDocument.Parse(Body);
       var Items = Doc.RootElement.GetProperty("items");
       Assert.IsTrue(Items.GetArrayLength() > 0,
           "658-DB: Audit log must have entries after workflow");
   }
   private static async Task Wf658_CleanupCreatedDataAsync()
   {
       if (!string.IsNullOrEmpty(Wf658_CreatedCommentId))
       {
           await Wf658Http!.DeleteAsync(
               string.Format(RouteConstants.ApiReviewCommentById, Wf658_CreatedCommentId));
       }
       if (!string.IsNullOrEmpty(Wf658_CreatedPrId))
       {
           await Wf658Http!.DeleteAsync(
               string.Format(RouteConstants.ApiPullRequestById, Wf658_CreatedPrId));
       }
       if (!string.IsNullOrEmpty(Wf658_CreatedTaskId))
       {
           await Wf658Http!.DeleteAsync(
               string.Format(RouteConstants.ApiTaskById, Wf658_CreatedTaskId));
       }
   }
}

