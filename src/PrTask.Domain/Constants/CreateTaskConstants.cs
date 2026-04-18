namespace PrTask.Domain.Constants;
public static class CreateTaskConstants
{
    public const string SeoTitle = "Create Task - PrTask";
    public const string SeoDescription = "Create a new task with a bounty for developers to complete.";
    public const string ValidationTitleRequired = "Title is required.";
    public const string ValidationDescriptionRequired = "Description is required.";
    public const string ValidationBountyTooLow = "Bounty must be at least $100.";
    public const string PageHeading = "Create a New Task";
    public const string PageDescription = "Post a task with a bounty to attract developers.";
    public const string TitleLabel = "Task Title";
    public const string TitlePlaceholder = "Fix authentication bug in user service";
    public const string DescriptionLabel = "Description";
    public const string DescriptionPlaceholder = "Describe the task in detail...";
    public const string RepoUrlLabel = "Repository URL";
    public const string RepoUrlPlaceholder = "https://github.com/org/repo";
    public const string WorkItemTypeLabel = "Work Item Type";
    public const string ComplexityLabel = "Complexity Level";
    public const string BountyLabel = "Bounty Amount (USD)";
    public const string TagsLabel = "Tags (comma-separated)";
    public const string TagsPlaceholder = "csharp, blazor, bug-fix";
    public const string VisibilityLabel = "Code Visibility";
    public const string SubmitButtonText = "Create Task";
    public const string BountyHintFormat = "Minimum: ${0}. No platform fees — developers receive 100% of the bounty.";
}
