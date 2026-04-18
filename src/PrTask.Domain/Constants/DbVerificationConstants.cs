namespace PrTask.Domain.Constants;

public static class DbVerificationConstants
{
    public const string TaskTable = "Tasks";
    public const string PullRequestTable = "PullRequests";
    public const string UserTable = "Users";
    public const string PaymentTable = "Payments";
    public const string ReviewCommentTable = "ReviewComments";
    public const string SprintTable = "Sprints";
    public const string BoardTable = "Boards";
    public const string BoardColumnTable = "BoardColumns";
    public const string RepositoryTable = "Repositories";
    public const string InvoiceTable = "Invoices";
    public const string SubscriptionTable = "Subscriptions";
    public const string AchievementTable = "Achievements";
    public const string AuditLogTable = "AuditLogs";

    public const string SelectByIdFormat = "SELECT * FROM {0} WHERE Id = @Id";
    public const string SelectCountFormat = "SELECT COUNT(*) FROM {0}";
    public const string SelectAllFormat = "SELECT * FROM {0} ORDER BY CreatedAt DESC LIMIT @Limit";
    public const string SelectByFieldFormat = "SELECT * FROM {0} WHERE {1} = @Value";

    public const string IdParameter = "@Id";
    public const string ValueParameter = "@Value";
    public const string LimitParameter = "@Limit";
    public const int DefaultQueryLimit = 100;

    public const string EntityExistsAssert = "{0} with Id {1} must exist in {2}";
    public const string EntityDeletedAssert = "{0} with Id {1} must not exist in {2}";
    public const string FieldMatchAssert = "{0}.{1} must equal {2}";
    public const string CountMatchAssert = "{0} count must be {1}";
    public const string DbFileNotFoundAssert = "Database file not found at {0}";

    public const string ReadOnlyConnectionString = "Data Source={0};Mode=ReadOnly";
    public const string WalConnectionString = "Data Source={0};Mode=ReadOnly;Cache=Shared";
    public const string SqliteProvider = "Microsoft.Data.Sqlite";

    public const string SnapshotFileFormat = "db-snapshot-{0}-{1:yyyyMMddHHmmss}.json";
    public const string SnapshotBeforeLabel = "before";
    public const string SnapshotAfterLabel = "after";
    public const string CompareResultFormat = "Table {0}: {1} differences found";
    public const int SnapshotTimeoutMs = 10000;
}
