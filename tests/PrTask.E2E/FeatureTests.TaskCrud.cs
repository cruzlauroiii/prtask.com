namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Create task page must have all required form fields for task creation")]
    public void CreateTaskPageMustHaveAllRequiredFormFieldsForTaskCreation()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "Client", "CreateTaskPage.razor");
        Assert.IsTrue(Razor.Contains("Title", StringComparison.Ordinal), "Create task page must have a Title field");
        Assert.IsTrue(Razor.Contains("Description", StringComparison.Ordinal), "Create task page must have a Description field");
        Assert.IsTrue(Razor.Contains("RepoUrl", StringComparison.Ordinal), "Create task page must have a Repository URL field");
        Assert.IsTrue(Razor.Contains("Complexity", StringComparison.Ordinal), "Create task page must have a Complexity selector");
        Assert.IsTrue(Razor.Contains("BountyAmount", StringComparison.Ordinal), "Create task page must have a Bounty Amount field");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Route constants must define edit task and delete task routes for crud operations")]
    public void RouteConstantsMustDefineEditTaskAndDeleteTaskRoutesForCrudOperations()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Code.Contains("EditTask", StringComparison.Ordinal), "RouteConstants must define an EditTask route");
        Assert.IsTrue(Code.Contains("DeleteTask", StringComparison.Ordinal), "RouteConstants must define a DeleteTask route");
        Assert.IsTrue(Code.Contains("ClientCreateTask", StringComparison.Ordinal), "RouteConstants must define a ClientCreateTask route");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task service interface must define all crud operations for task management")]
    public void TaskServiceInterfaceMustDefineAllCrudOperationsForTaskManagement()
    {
        var Code = ReadSourceFile("PrTask.Application", "Services", "ITaskService.cs");
        Assert.IsTrue(Code.Contains("CreateAsync", StringComparison.Ordinal), "ITaskService must have CreateAsync method");
        Assert.IsTrue(Code.Contains("GetByIdAsync", StringComparison.Ordinal), "ITaskService must have GetByIdAsync method");
        Assert.IsTrue(Code.Contains("DeleteAsync", StringComparison.Ordinal), "ITaskService must have DeleteAsync method");
        Assert.IsTrue(
            Code.Contains("UpdateAsync", StringComparison.Ordinal) || Code.Contains("EditAsync", StringComparison.Ordinal),
            "ITaskService must have UpdateAsync or EditAsync method");
        Assert.IsTrue(
            Code.Contains("ListOpenAsync", StringComparison.Ordinal) || Code.Contains("ListAsync", StringComparison.Ordinal),
            "ITaskService must have a List method for reading tasks");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task detail page must have edit and delete buttons for task owner crud")]
    public void TaskDetailPageMustHaveEditAndDeleteButtonsForTaskOwnerCrud()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "TaskDetailPage.razor");
        Assert.IsTrue(
            Razor.Contains("edit-task", StringComparison.OrdinalIgnoreCase) || Razor.Contains("Edit Task", StringComparison.Ordinal),
            "Task detail page must have an Edit button for the task owner");
        Assert.IsTrue(
            Razor.Contains("Delete", StringComparison.Ordinal),
            "Task detail page must have a Delete button for the task owner");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task list page must fetch and display open tasks from task service")]
    public void TaskListPageMustFetchAndDisplayOpenTasksFromTaskService()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "TaskList.razor");
        Assert.IsTrue(Razor.Contains("ITaskService", StringComparison.Ordinal), "Task list must inject ITaskService");
        Assert.IsTrue(Razor.Contains("OnInitializedAsync", StringComparison.Ordinal), "Task list must load tasks on init");
        Assert.IsTrue(Razor.Contains("task-card", StringComparison.Ordinal), "Task list must render task cards");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task endpoints must support full crud via api routes")]
    public void TaskEndpointsMustSupportFullCrudViaApiRoutes()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Code.Contains("ApiTasks", StringComparison.Ordinal), "Must have API tasks route for CRUD operations");
        var Endpoints = ReadSourceFile("PrTask.Server", "Endpoints", "TaskEndpoints.cs");
        Assert.IsTrue(Endpoints.Contains("MapGet", StringComparison.Ordinal), "Task endpoints must support GET (Read)");
        Assert.IsTrue(Endpoints.Contains("MapPost", StringComparison.Ordinal), "Task endpoints must support POST (Create)");
        Assert.IsTrue(Endpoints.Contains("MapDelete", StringComparison.Ordinal), "Task endpoints must support DELETE");
        Assert.IsTrue(
            Endpoints.Contains("MapPatch", StringComparison.Ordinal) || Endpoints.Contains("MapPut", StringComparison.Ordinal),
            "Task endpoints must support PATCH or PUT (Update)");
    }
}
