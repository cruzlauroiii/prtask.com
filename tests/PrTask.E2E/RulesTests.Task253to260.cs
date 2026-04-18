using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task253 SettingsPage — KYC, profile form, IUserService, IKycVerificationService")]
    public async Task SettingsPageStructureAsync()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "SettingsPage.razor");
        Assert.IsTrue(Source.Contains("@page \"/Settings\""), "Has /settings route");
        var CodeBehind = ReadSource("PrTask.SharedUI", "Pages", "SettingsPage.razor.cs");
        Assert.IsTrue(CodeBehind.Contains("IUserService"), "Injects IUserService");
        Assert.IsTrue(CodeBehind.Contains("IKycVerificationService"), "Injects IKycVerificationService");
        Assert.IsTrue(CodeBehind.Contains("CreateSessionAsync"), "Calls KYC CreateSessionAsync");
        Assert.IsTrue(CodeBehind.Contains("GetSessionStatusAsync"), "Calls KYC GetSessionStatusAsync");
        Assert.IsTrue(CodeBehind.Contains("UpdateAsync"), "Calls UpdateAsync to save");
        Assert.IsTrue(CodeBehind.Contains(nameof(SettingsConstants)), "Uses SettingsConstants");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task254 CreateTaskPage — task creation form with all fields")]
    public async Task CreateTaskPageStructureAsync()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Client", "CreateTaskPage.razor");
        Assert.IsTrue(Source.Contains("@page \"/Client/CreateTask\""), "Has /client/create-task route");
        Assert.IsTrue(Source.Contains("ITaskService"), "Injects ITaskService");
        Assert.IsTrue(Source.Contains("NavigationManager"), "Injects NavigationManager");
        Assert.IsTrue(Source.Contains("CreateAsync"), "Calls CreateAsync");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task255 EditTaskPage — task edit form with load and save")]
    public async Task EditTaskPageStructureAsync()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Client", "EditTaskPage.razor");
        Assert.IsTrue(Source.Contains("/Client/EditTask/"), "Has /client/edit-task route");
        Assert.IsTrue(Source.Contains("ITaskService"), "Injects ITaskService");
        Assert.IsTrue(Source.Contains("GetByIdAsync"), "Loads task via GetByIdAsync");
        Assert.IsTrue(Source.Contains("UpdateAsync"), "Saves via UpdateAsync");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task256 PaymentsPage — payment records list by payer")]
    public async Task PaymentsPageStructureAsync()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Client", "PaymentsPage.razor");
        Assert.IsTrue(Source.Contains("@page \"/Client/Payments\""), "Has /client/payments route");
        Assert.IsTrue(Source.Contains("IPaymentRecordService"), "Injects IPaymentRecordService");
        Assert.IsTrue(Source.Contains("ListByPayerAsync"), "Calls ListByPayerAsync");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task257 TaskDetailPage — task view, source upload, PR list, claim/delete")]
    public async Task TaskDetailPageStructureAsync()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "TaskDetailPage.razor");
        Assert.IsTrue(Source.Contains("/Tasks/"), "Has /tasks/{TaskId} route");
        Assert.IsTrue(Source.Contains("ITaskService"), "Injects ITaskService");
        Assert.IsTrue(Source.Contains("IPullRequestService"), "Injects IPullRequestService");
        Assert.IsTrue(Source.Contains("ISourceCodeService"), "Injects ISourceCodeService");
        Assert.IsTrue(Source.Contains("StoreFilesAsync"), "Calls StoreFilesAsync for upload");
        Assert.IsTrue(Source.Contains("ClaimAsync"), "Calls ClaimAsync");
        Assert.IsTrue(Source.Contains("DeleteAsync"), "Calls DeleteAsync");
        Assert.IsTrue(Source.Contains("ApproveAsync"), "Calls ApproveAsync");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task258 BoardDetailPage — columns CRUD, IBoardService, ITaskService")]
    public async Task BoardDetailPageStructureAsync()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "BoardDetailPage.razor");
        Assert.IsTrue(Source.Contains("/Boards/"), "Has /boards/{BoardId} route");
        Assert.IsTrue(Source.Contains("IBoardService"), "Injects IBoardService");
        Assert.IsTrue(Source.Contains("GetByIdAsync"), "Loads board via GetByIdAsync");
        Assert.IsTrue(Source.Contains("ListColumnsAsync"), "Lists columns");
        Assert.IsTrue(Source.Contains("CreateColumnAsync"), "Creates columns");
        Assert.IsTrue(Source.Contains("DeleteColumnAsync"), "Deletes columns");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task259 RepositoryPage — static repository management page")]
    public async Task RepositoryPageStructureAsync()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Client", "RepositoryPage.razor");
        Assert.IsTrue(Source.Contains("@page \"/Client/Repository\""), "Has /client/repository route");
        Assert.IsTrue(Source.Contains("Repository"), "Contains repository content");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task260 DownloadPage — static download page with platform links")]
    public async Task DownloadPageStructureAsync()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "DownloadPage.razor");
        Assert.IsTrue(Source.Contains("@page \"/Download\""), "Has /download route");
        Assert.IsTrue(Source.Contains("Download"), "Contains download content");
        await Task.CompletedTask;
    }
}
