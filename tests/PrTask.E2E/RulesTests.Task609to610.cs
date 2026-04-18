using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("TaskEndpoints POST uses CreateTaskRequest DTO")]
    public void TaskEndpointsPostUsesCreateTaskRequest()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "TaskEndpoints.cs");
        Assert.IsTrue(Source.Contains("CreateTaskRequest"),
            "TaskEndpoints POST must accept CreateTaskRequest DTO");
        Assert.IsTrue(Source.Contains("Guid.NewGuid()"),
            "TaskEndpoints POST must auto-generate Id");
        Assert.IsTrue(Source.Contains("NameIdentifier"),
            "TaskEndpoints POST must get ClientId from authenticated user claims");
        Assert.IsFalse(Source.Contains("TaskEntity Entity") && Source.Contains("MapPost"),
            "TaskEndpoints POST must not accept raw TaskEntity");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("PullRequestEndpoints POST uses SubmitPullRequestRequest DTO")]
    public void PullRequestEndpointsPostUsesSubmitPullRequestRequest()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "PullRequestEndpoints.cs");
        Assert.IsTrue(Source.Contains("SubmitPullRequestRequest"),
            "PullRequestEndpoints POST must accept SubmitPullRequestRequest DTO");
        Assert.IsTrue(Source.Contains("Guid.NewGuid()"),
            "PullRequestEndpoints POST must auto-generate Id");
        Assert.IsFalse(Source.Contains("PullRequestEntity Entity") && Source.Contains("MapPost"),
            "PullRequestEndpoints POST must not accept raw PullRequestEntity for creation");
    }
}
