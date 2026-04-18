using PrTask.Domain.Models;
using PrTask.Infrastructure.Services;
namespace PrTask.Unit;
[TestClass]
public class PullRequestServiceTests
{
    private PullRequestService Service { get; } = new();
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Submit must store pull request and return it")]
    public async Task SubmitMustStorePullRequestAndReturnItAsync()
    {
        var Entity = CreatePr("pr-submit-1");
        var Result = await Service.SubmitAsync(Entity);
        Assert.AreEqual("pr-submit-1", Result.Id);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Exists must return true after pull request is submitted")]
    public async Task ExistsMustReturnTrueAfterPullRequestIsSubmittedAsync()
    {
        var Entity = CreatePr("pr-exists-1");
        await Service.SubmitAsync(Entity);
        Assert.IsTrue(await Service.ExistsAsync("pr-exists-1"));
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Exists must return false for nonexistent pull request")]
    public async Task ExistsMustReturnFalseForNonexistentPullRequestAsync()
    {
        Assert.IsFalse(await Service.ExistsAsync("nonexistent-pr-id"));
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Get by id must return entity after submission")]
    public async Task GetByIdMustReturnEntityAfterSubmissionAsync()
    {
        var Entity = CreatePr("pr-getbyid-1");
        await Service.SubmitAsync(Entity);
        var Result = await Service.GetByIdAsync("pr-getbyid-1");
        Assert.IsNotNull(Result);
        Assert.AreEqual(PullRequestStatus.Submitted, Result.Status);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Get by id must return null for nonexistent pull request")]
    public async Task GetByIdMustReturnNullForNonexistentPullRequestAsync()
    {
        var Result = await Service.GetByIdAsync("nonexistent-pr-getbyid");
        Assert.IsNull(Result);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("List by developer must return only that developers pull requests")]
    public async Task ListByDeveloperMustReturnOnlyThatDevelopersPullRequestsAsync()
    {
        var Pr1 = new PullRequestEntity { Id = "pr-listdev-1", TaskId = "task-1", DeveloperId = "dev-a" };
        var Pr2 = new PullRequestEntity { Id = "pr-listdev-2", TaskId = "task-2", DeveloperId = "dev-b" };
        await Service.SubmitAsync(Pr1);
        await Service.SubmitAsync(Pr2);
        var Results = await Service.ListByDeveloperAsync("dev-a");
        Assert.IsTrue(Results.Any(P => P.Id == "pr-listdev-1"));
        Assert.IsFalse(Results.Any(P => P.Id == "pr-listdev-2"));
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Approve must set status to approved and set reviewed at timestamp")]
    public async Task ApproveMustSetStatusToApprovedAndSetReviewedAtTimestampAsync()
    {
        var Entity = CreatePr("pr-approve-1");
        await Service.SubmitAsync(Entity);
        await Service.ApproveAsync("pr-approve-1");
        var Result = await Service.GetByIdAsync("pr-approve-1");
        Assert.IsNotNull(Result);
        Assert.AreEqual(PullRequestStatus.Approved, Result.Status);
        Assert.IsNotNull(Result.ReviewedAt);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Reject must set status to rejected with reviewer notes")]
    public async Task RejectMustSetStatusToRejectedWithReviewerNotesAsync()
    {
        var Entity = CreatePr("pr-reject-1");
        await Service.SubmitAsync(Entity);
        await Service.RejectAsync("pr-reject-1", "Needs more tests");
        var Result = await Service.GetByIdAsync("pr-reject-1");
        Assert.IsNotNull(Result);
        Assert.AreEqual(PullRequestStatus.Rejected, Result.Status);
        Assert.AreEqual("Needs more tests", Result.ReviewerNotes);
        Assert.IsNotNull(Result.ReviewedAt);
    }
    private static PullRequestEntity CreatePr(string Id) => new()
    {
        Id = Id,
        TaskId = "task-1",
        DeveloperId = "developer-1"
    };
}
