namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Schema users table must have text primary key id with github id integer and github username text default")]
    public void SchemaUsersTableMustHaveTextPrimaryKeyIdWithGitHubIdIntegerAndGitHubUsernameTextDefault()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsTrue(Sql.Contains("id TEXT PRIMARY KEY", StringComparison.Ordinal), "Users table must have TEXT PRIMARY KEY id");
        Assert.IsTrue(Sql.Contains("github_id INTEGER", StringComparison.Ordinal), "Users table must have github_id INTEGER");
        Assert.IsTrue(Sql.Contains("github_username TEXT DEFAULT ''", StringComparison.Ordinal), "Users table must default github_username to empty");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Schema users table must have display name avatar url email and role defaulting to developer")]
    public void SchemaUsersTableMustHaveDisplayNameAvatarUrlEmailAndRoleDefaultingToDeveloper()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsTrue(Sql.Contains("display_name TEXT", StringComparison.Ordinal), "Users table must have display_name TEXT");
        Assert.IsTrue(Sql.Contains("avatar_url TEXT", StringComparison.Ordinal), "Users table must have avatar_url TEXT");
        Assert.IsTrue(Sql.Contains("email TEXT", StringComparison.Ordinal), "Users table must have email TEXT column");
        Assert.IsTrue(Sql.Contains("role TEXT DEFAULT 'Developer'", StringComparison.Ordinal), "Users table must default role to Developer");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Schema users table must have maya customer id xp level streak and financial tracking columns")]
    public void SchemaUsersTableMustHaveMayaCustomerIdXpLevelStreakAndFinancialTrackingColumns()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsTrue(Sql.Contains("maya_customer_id TEXT", StringComparison.Ordinal), "Users table must have maya_customer_id TEXT");
        Assert.IsTrue(Sql.Contains("total_earned_cents INTEGER DEFAULT 0", StringComparison.Ordinal), "Users table must default total_earned_cents to 0");
        Assert.IsTrue(Sql.Contains("total_spent_cents INTEGER DEFAULT 0", StringComparison.Ordinal), "Users table must default total_spent_cents to 0");
        Assert.IsTrue(Sql.Contains("xp INTEGER DEFAULT 0", StringComparison.Ordinal), "Users table must default xp to 0");
        Assert.IsTrue(Sql.Contains("level INTEGER DEFAULT 1", StringComparison.Ordinal), "Users table must default level to 1");
        Assert.IsTrue(Sql.Contains("streak_days INTEGER DEFAULT 0", StringComparison.Ordinal), "Users table must default streak_days to 0");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Schema tasks table must have client id not null with foreign key reference to users id column")]
    public void SchemaTasksTableMustHaveClientIdNotNullWithForeignKeyReferenceToUsersIdColumn()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsTrue(Sql.Contains("client_id TEXT NOT NULL", StringComparison.Ordinal), "Tasks table must have client_id NOT NULL");
        Assert.IsTrue(Sql.Contains("title TEXT NOT NULL", StringComparison.Ordinal), "Tasks table must have title NOT NULL");
        Assert.IsTrue(Sql.Contains("FOREIGN KEY (client_id) REFERENCES users(id)", StringComparison.Ordinal), "Tasks must FK to users for client_id");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Schema tasks table must default status to open complexity to medium and bounty amount cents to zero")]
    public void SchemaTasksTableMustDefaultStatusToOpenComplexityToMediumAndBountyAmountCentsToZero()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsTrue(Sql.Contains("status TEXT DEFAULT 'Open'", StringComparison.Ordinal), "Tasks table must default status to Open");
        Assert.IsTrue(Sql.Contains("complexity TEXT DEFAULT 'Medium'", StringComparison.Ordinal), "Tasks table must default complexity to Medium");
        Assert.IsTrue(Sql.Contains("bounty_amount_cents INTEGER DEFAULT 0", StringComparison.Ordinal), "Tasks table must default bounty_amount_cents to 0");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Schema tasks table must have claimed developer id deadline and tags with json array default")]
    public void SchemaTasksTableMustHaveClaimedDeveloperIdDeadlineAndTagsWithJsonArrayDefault()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsTrue(Sql.Contains("claimed_by_developer_id TEXT", StringComparison.Ordinal), "Tasks table must have claimed_by_developer_id");
        Assert.IsTrue(Sql.Contains("deadline TEXT", StringComparison.Ordinal), "Tasks table must have deadline TEXT");
        Assert.IsTrue(Sql.Contains("tags TEXT DEFAULT '[]'", StringComparison.Ordinal), "Tasks table must default tags to empty JSON array");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Schema pull requests table must have task id and developer id as not null with foreign key references")]
    public void SchemaPullRequestsTableMustHaveTaskIdAndDeveloperIdAsNotNullWithForeignKeyReferences()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsTrue(Sql.Contains("task_id TEXT NOT NULL", StringComparison.Ordinal), "PRs table must have task_id NOT NULL");
        Assert.IsTrue(Sql.Contains("developer_id TEXT NOT NULL", StringComparison.Ordinal), "PRs table must have developer_id NOT NULL");
        Assert.IsTrue(Sql.Contains("FOREIGN KEY (task_id) REFERENCES tasks(id)", StringComparison.Ordinal), "PRs must FK to tasks");
        Assert.IsTrue(Sql.Contains("FOREIGN KEY (developer_id) REFERENCES users(id)", StringComparison.Ordinal), "PRs must FK to users for developer");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Schema pull requests table must default status to submitted and complexity score to zero with diff key")]
    public void SchemaPullRequestsTableMustDefaultStatusToSubmittedAndComplexityScoreToZeroWithDiffKey()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsTrue(Sql.Contains("status TEXT DEFAULT 'Submitted'", StringComparison.Ordinal), "PRs table must default status to Submitted");
        Assert.IsTrue(Sql.Contains("complexity_score INTEGER DEFAULT 0", StringComparison.Ordinal), "PRs table must default complexity_score to 0");
        Assert.IsTrue(Sql.Contains("diff_storage_key TEXT", StringComparison.Ordinal), "PRs table must have diff_storage_key");
        Assert.IsTrue(Sql.Contains("github_pr_url TEXT DEFAULT ''", StringComparison.Ordinal), "PRs table must default github_pr_url to empty");
        Assert.IsTrue(Sql.Contains("review_notes TEXT", StringComparison.Ordinal), "PRs table must have review_notes column");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Schema payments table must have payer id not null amount cents not null and payment type not null")]
    public void SchemaPaymentsTableMustHavePayerIdNotNullAmountCentsNotNullAndPaymentTypeNotNull()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsTrue(Sql.Contains("payer_id TEXT NOT NULL", StringComparison.Ordinal), "Payments table must have payer_id NOT NULL");
        Assert.IsTrue(Sql.Contains("amount_cents INTEGER NOT NULL", StringComparison.Ordinal), "Payments table must have amount_cents NOT NULL");
        Assert.IsTrue(Sql.Contains("payment_type TEXT NOT NULL", StringComparison.Ordinal), "Payments table must have payment_type NOT NULL");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Schema payments table must have triple foreign keys to tasks payer users and payee users tables")]
    public void SchemaPaymentsTableMustHaveTripleForeignKeysToTasksPayerUsersAndPayeeUsersTables()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsTrue(Sql.Contains("FOREIGN KEY (task_id) REFERENCES tasks(id)", StringComparison.Ordinal), "Payments must FK to tasks");
        Assert.IsTrue(Sql.Contains("FOREIGN KEY (payer_id) REFERENCES users(id)", StringComparison.Ordinal), "Payments must FK to users for payer");
        Assert.IsTrue(Sql.Contains("FOREIGN KEY (payee_id) REFERENCES users(id)", StringComparison.Ordinal), "Payments must FK to users for payee");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Schema achievements table must have user id not null badge type not null with foreign key to users")]
    public void SchemaAchievementsTableMustHaveUserIdNotNullBadgeTypeNotNullWithForeignKeyToUsers()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsTrue(Sql.Contains("user_id TEXT NOT NULL", StringComparison.Ordinal), "Achievements table must have user_id NOT NULL");
        Assert.IsTrue(Sql.Contains("badge_type TEXT NOT NULL", StringComparison.Ordinal), "Achievements table must have badge_type NOT NULL");
        Assert.IsTrue(Sql.Contains("earned_at TEXT DEFAULT (datetime('now'))", StringComparison.Ordinal), "Achievements must default earned_at to datetime now");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Schema leaderboard table must have user id text primary key with total xp tasks completed and rank columns")]
    public void SchemaLeaderboardTableMustHaveUserIdTextPrimaryKeyWithTotalXpTasksCompletedAndRankColumns()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsTrue(Sql.Contains("user_id TEXT PRIMARY KEY", StringComparison.Ordinal), "Leaderboard must have user_id as PRIMARY KEY");
        Assert.IsTrue(Sql.Contains("total_xp INTEGER DEFAULT 0", StringComparison.Ordinal), "Leaderboard must default total_xp to 0");
        Assert.IsTrue(Sql.Contains("tasks_completed INTEGER DEFAULT 0", StringComparison.Ordinal), "Leaderboard must default tasks_completed to 0");
        Assert.IsTrue(Sql.Contains("rank INTEGER DEFAULT 0", StringComparison.Ordinal), "Leaderboard must default rank to 0");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Schema all six tables must use create table if not exists pattern with datetime now for timestamps")]
    public void SchemaAllSixTablesMustUseCreateTableIfNotExistsPatternWithDatetimeNowForTimestamps()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsTrue(Sql.Contains("CREATE TABLE IF NOT EXISTS users", StringComparison.Ordinal), "Schema must create users table");
        Assert.IsTrue(Sql.Contains("CREATE TABLE IF NOT EXISTS tasks", StringComparison.Ordinal), "Schema must create tasks table");
        Assert.IsTrue(Sql.Contains("CREATE TABLE IF NOT EXISTS pull_requests", StringComparison.Ordinal), "Schema must create pull_requests table");
        Assert.IsTrue(Sql.Contains("CREATE TABLE IF NOT EXISTS payments", StringComparison.Ordinal), "Schema must create payments table");
        Assert.IsTrue(Sql.Contains("CREATE TABLE IF NOT EXISTS achievements", StringComparison.Ordinal), "Schema must create achievements table");
        Assert.IsTrue(Sql.Contains("CREATE TABLE IF NOT EXISTS leaderboard", StringComparison.Ordinal), "Schema must create leaderboard table");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Schema timestamp columns must use sqlite datetime now expression for created at and updated at defaults")]
    public void SchemaTimestampColumnsMustUseSqliteDatetimeNowExpressionForCreatedAtAndUpdatedAtDefaults()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsTrue(Sql.Contains("created_at TEXT DEFAULT (datetime('now'))", StringComparison.Ordinal), "Tables must default created_at to datetime now");
        Assert.IsTrue(Sql.Contains("updated_at TEXT DEFAULT (datetime('now'))", StringComparison.Ordinal), "Tables must default updated_at to datetime now");
    }
}
