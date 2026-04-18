namespace PrTask.Domain.Constants;
public static class SourceCodeConstants
{
    public const string KeyFormat = "{0}:{1}";
    public const string PrefixFormat = "{0}:";
    public const string DiffGitHeader = "diff --git a/{0} b/{0}";
    public const string DiffOldFile = "--- a/{0}";
    public const string DiffNewFile = "+++ b/{0}";
    public const string DiffContextLine = " {0}";
    public const string DiffDeleteLine = "-{0}";
    public const string DiffAddLine = "+{0}";
    public const string DiffNewFileHeader = "diff --git /dev/null b/{0}";
    public const string DiffNewFilePlusHeader = "+++ b/{0}";
    public const int MaxUploadFileSizeBytes = 1048576;
    public const int MaxUploadFileCount = 100;
    public const string SelectedFilesFormat = "Selected {0} files. Click Upload to save.";
    public const string UploadedFilesFormat = "Uploaded {0} files successfully.";
    public const string NoFilesSelected = "No files selected.";
    public const string InvalidFileType = "Some files were skipped — only source code files are allowed.";
    public const string FileTooLarge = "Some files exceed the 1 MB size limit and were skipped.";
    public const string NoValidFiles = "No valid source code files were found in your selection.";
    public const long MaxTotalUploadSizeBytes = 10485760;
    public const string TotalSizeTooLarge = "Total upload size exceeds 10 MB limit.";
    public const string WarningSeparator = " ";
    public const string JsonDiff = "diff";
    public static readonly IReadOnlySet<string> AllowedExtensions = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
    {
        ".cs", ".razor", ".css", ".js", ".ts", ".tsx", ".jsx",
        ".html", ".htm", ".json", ".xml", ".yaml", ".yml",
        ".md", ".txt", ".csv", ".sql", ".sh", ".ps1",
        ".csproj", ".sln", ".props", ".targets", ".config",
        ".py", ".rb", ".go", ".rs", ".java", ".kt", ".swift",
        ".c", ".cpp", ".h", ".hpp", ".vue", ".svelte",
        ".scss", ".sass", ".less", ".graphql", ".proto",
        ".dockerfile", ".gitignore", ".editorconfig", ".env.example"
    };
}
