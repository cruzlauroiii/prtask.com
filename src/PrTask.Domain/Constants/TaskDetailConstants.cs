namespace PrTask.Domain.Constants;
public static class TaskDetailConstants
{
    public const string SeoTitle = "Task Details - PrTask";
    public const string SeoDescription = "View task details, bounty amount, and submitted pull requests.";
    public const string EmptyPrState = "No pull requests submitted yet.";
    public const string LoadingText = "Loading task...";
    public const string SourceCodeHeading = "Source Code";
    public const string SourceCodeDescription = "Upload your source code folder so developers can see the code in the diff viewer.";
    public const string PullRequestsHeading = "Pull Requests";
    public const string PullRequestsDescription = "Developers submit pull requests for this task. Choose the best one to approve and merge.";
    public const string UploadFilesLabel = "Upload Source Files";
    public const string UploadButtonText = "Upload Files";
    public const string ClaimButtonText = "Claim This Task";
    public const string EditButtonText = "Edit Task";
    public const string DeleteButtonText = "Delete Task";
    public const string SubmitPrButtonText = "Submit a Pull Request";
    public const string ApproveButtonText = "Approve";
    public const string ViewDiffButtonText = "View Diff";
    public const string UploadedFilesHeadingFormat = "Uploaded Files ({0})";
    public const string FileSizeFormat = "({0} chars)";
    public const string StatusLabel = "Status: ";
    public const string DeadlineLabel = "Deadline: ";
    public const string DeadlineDateFormat = "MMM dd, yyyy";
    public const string LoadTimeoutMessage = "Task could not be loaded. The connection may be slow or unavailable.";
    public const string ErrorHeading = "Error Loading Task";
    public const string RetryButtonText = "Retry";
}
