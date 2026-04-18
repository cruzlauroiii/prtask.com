using PrTask.Domain.Models;
using PrTask.Infrastructure.Services;
namespace PrTask.Unit;
[TestClass]
public class TaskServiceTests
{
    private TaskService Service { get; } = new();
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Create task must store entity and return it")]
    public async Task CreateTaskMustStoreEntityAndReturnItAsync()
    {
        var Entity = CreateTask("svc-create-1");
        var Result = await Service.CreateAsync(Entity);
        Assert.AreEqual("svc-create-1", Result.Id);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Exists must return true after task is created")]
    public async Task ExistsMustReturnTrueAfterTaskIsCreatedAsync()
    {
        var Entity = CreateTask("svc-exists-1");
        await Service.CreateAsync(Entity);
        Assert.IsTrue(await Service.ExistsAsync("svc-exists-1"));
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Exists must return false for nonexistent task")]
    public async Task ExistsMustReturnFalseForNonexistentTaskAsync()
    {
        Assert.IsFalse(await Service.ExistsAsync("nonexistent-task-id"));
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Get by id must return entity after creation")]
    public async Task GetByIdMustReturnEntityAfterCreationAsync()
    {
        var Entity = CreateTask("svc-getbyid-1");
        await Service.CreateAsync(Entity);
        var Result = await Service.GetByIdAsync("svc-getbyid-1");
        Assert.IsNotNull(Result);
        Assert.AreEqual("Test Task", Result.Title);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Get by id must return null for nonexistent task")]
    public async Task GetByIdMustReturnNullForNonexistentTaskAsync()
    {
        var Result = await Service.GetByIdAsync("nonexistent-getbyid");
        Assert.IsNull(Result);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("List open must return only open tasks")]
    public async Task ListOpenMustReturnOnlyOpenTasksAsync()
    {
        var Open = CreateTask("svc-listopen-1");
        var Claimed = CreateTask("svc-listopen-2");
        Claimed.Status = PrTaskStatus.Claimed;
        await Service.CreateAsync(Open);
        await Service.CreateAsync(Claimed);
        var Results = await Service.ListOpenAsync();
        Assert.IsTrue(Results.Any(T => T.Id == "svc-listopen-1"));
        Assert.IsFalse(Results.Any(T => T.Id == "svc-listopen-2"));
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Claim must set task status to claimed")]
    public async Task ClaimMustSetTaskStatusToClaimedAsync()
    {
        var Entity = CreateTask("svc-claim-1");
        await Service.CreateAsync(Entity);
        await Service.ClaimAsync("svc-claim-1", "developer-1");
        var Result = await Service.GetByIdAsync("svc-claim-1");
        Assert.IsNotNull(Result);
        Assert.AreEqual(PrTaskStatus.Claimed, Result.Status);
    }
    private static TaskEntity CreateTask(string Id) => new()
    {
        Id = Id,
        ClientId = "client-1",
        Title = "Test Task",
        Description = "A test task description",
        RepoUrl = "https://github.com/test/repo"
    };
}
