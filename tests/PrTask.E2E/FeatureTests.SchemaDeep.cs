namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Database users table must have display name avatar url and email text columns for profile")]
    public void DatabaseUsersTableMustHaveDisplayNameAvatarUrlAndEmailTextColumnsForProfile()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsTrue(Sql.Contains("display_name TEXT", StringComparison.Ordinal), "Users must have display_name column for profile");
        Assert.IsTrue(Sql.Contains("avatar_url TEXT", StringComparison.Ordinal), "Users must have avatar_url column for profile picture");
        Assert.IsTrue(Sql.Contains("email TEXT", StringComparison.Ordinal), "Users must have email column for contact");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Database users table must use datetime now default for created at and updated at timestamps")]
    public void DatabaseUsersTableMustUseDatetimeNowDefaultForCreatedAtAndUpdatedAtTimestamps()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsTrue(Sql.Contains("created_at TEXT DEFAULT (datetime('now'))", StringComparison.Ordinal), "Users created_at must default to datetime now");
        Assert.IsTrue(Sql.Contains("updated_at TEXT DEFAULT (datetime('now'))", StringComparison.Ordinal), "Users updated_at must default to datetime now");
        Assert.IsTrue(Sql.Contains("id TEXT PRIMARY KEY", StringComparison.Ordinal), "Users must have TEXT primary key for UUID");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Database tasks table must have claimed by developer id deadline and tags json default columns")]
    public void DatabaseTasksTableMustHaveClaimedByDeveloperIdDeadlineAndTagsJsonDefaultColumns()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsTrue(Sql.Contains("claimed_by_developer_id TEXT", StringComparison.Ordinal), "Tasks must have claimed_by_developer_id for assignment tracking");
        Assert.IsTrue(Sql.Contains("deadline TEXT", StringComparison.Ordinal), "Tasks must have deadline column for time constraints");
        Assert.IsTrue(Sql.Contains("tags TEXT DEFAULT '[]'", StringComparison.Ordinal), "Tasks tags must default to empty JSON array");
        Assert.IsTrue(Sql.Contains("repo_url TEXT DEFAULT ''", StringComparison.Ordinal), "Tasks repo_url must default to empty string");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Database tasks table must have foreign key referencing client id to users table")]
    public void DatabaseTasksTableMustHaveForeignKeyReferencingClientIdToUsersTable()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsTrue(Sql.Contains("FOREIGN KEY (client_id) REFERENCES users(id)", StringComparison.Ordinal), "Tasks client_id must reference users table");
        Assert.IsTrue(Sql.Contains("description TEXT DEFAULT ''", StringComparison.Ordinal), "Tasks description must default to empty string");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Database pull requests table must have github pr url default empty and status default submitted")]
    public void DatabasePullRequestsTableMustHaveGitHubPrUrlDefaultEmptyAndStatusDefaultSubmitted()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsTrue(Sql.Contains("github_pr_url TEXT DEFAULT ''", StringComparison.Ordinal), "PRs github_pr_url must default to empty string");
        Assert.IsTrue(Sql.Contains("status TEXT DEFAULT 'Submitted'", StringComparison.Ordinal), "PRs status must default to Submitted");
        Assert.IsTrue(Sql.Contains("review_notes TEXT", StringComparison.Ordinal), "PRs must have review_notes column for reviewer feedback");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Database pull requests table must have dual foreign keys to tasks and users tables")]
    public void DatabasePullRequestsTableMustHaveDualForeignKeysToTasksAndUsersTables()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsTrue(Sql.Contains("FOREIGN KEY (task_id) REFERENCES tasks(id)", StringComparison.Ordinal), "PRs task_id must reference tasks table");
        Assert.IsTrue(Sql.Contains("FOREIGN KEY (developer_id) REFERENCES users(id)", StringComparison.Ordinal), "PRs developer_id must reference users table");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Database payments table must have triple foreign keys to tasks payer and payee users")]
    public void DatabasePaymentsTableMustHaveTripleForeignKeysToTasksPayerAndPayeeUsers()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsTrue(Sql.Contains("FOREIGN KEY (task_id) REFERENCES tasks(id)", StringComparison.Ordinal), "Payments task_id must reference tasks table");
        Assert.IsTrue(Sql.Contains("FOREIGN KEY (payer_id) REFERENCES users(id)", StringComparison.Ordinal), "Payments payer_id must reference users table");
        Assert.IsTrue(Sql.Contains("FOREIGN KEY (payee_id) REFERENCES users(id)", StringComparison.Ordinal), "Payments payee_id must reference users table");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Database payments table must have payer id as not null and payee id as nullable columns")]
    public void DatabasePaymentsTableMustHavePayerIdAsNotNullAndPayeeIdAsNullableColumns()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsTrue(Sql.Contains("payer_id TEXT NOT NULL", StringComparison.Ordinal), "Payments payer_id must be NOT NULL");
        Assert.IsTrue(Sql.Contains("payee_id TEXT", StringComparison.Ordinal), "Payments must have payee_id column");
        Assert.IsTrue(Sql.Contains("task_id TEXT NOT NULL", StringComparison.Ordinal), "Payments task_id must be NOT NULL");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Database achievements table must have user id foreign key and earned at with datetime default")]
    public void DatabaseAchievementsTableMustHaveUserIdForeignKeyAndEarnedAtWithDatetimeDefault()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsTrue(Sql.Contains("FOREIGN KEY (user_id) REFERENCES users(id)", StringComparison.Ordinal), "Achievements user_id must reference users table");
        Assert.IsTrue(Sql.Contains("earned_at TEXT DEFAULT (datetime('now'))", StringComparison.Ordinal), "Achievements earned_at must default to datetime now");
        Assert.IsTrue(Sql.Contains("user_id TEXT NOT NULL", StringComparison.Ordinal), "Achievements user_id must be NOT NULL");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Database leaderboard table must have username avatar url tasks completed and rank columns")]
    public void DatabaseLeaderboardTableMustHaveUsernameAvatarUrlTasksCompletedAndRankColumns()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsTrue(Sql.Contains("username TEXT DEFAULT ''", StringComparison.Ordinal), "Leaderboard username must default to empty string");
        Assert.IsTrue(Sql.Contains("tasks_completed INTEGER DEFAULT 0", StringComparison.Ordinal), "Leaderboard must track tasks_completed count");
        Assert.IsTrue(Sql.Contains("rank INTEGER DEFAULT 0", StringComparison.Ordinal), "Leaderboard rank must default to zero");
        Assert.IsTrue(Sql.Contains("total_earned_cents INTEGER DEFAULT 0", StringComparison.Ordinal), "Leaderboard must track total_earned_cents");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Database leaderboard table must use user id as primary key with foreign key to users")]
    public void DatabaseLeaderboardTableMustUseUserIdAsPrimaryKeyWithForeignKeyToUsers()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsTrue(Sql.Contains("user_id TEXT PRIMARY KEY", StringComparison.Ordinal), "Leaderboard must use user_id as primary key");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Database schema must use sqlite text type for all datetime columns instead of native datetime")]
    public void DatabaseSchemaMustUseSqliteTextTypeForAllDatetimeColumnsInsteadOfNativeDatetime()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsFalse(Sql.Contains("DATETIME", StringComparison.Ordinal), "Schema must not use native DATETIME type for D1 compatibility");
        Assert.IsTrue(Sql.Contains("created_at TEXT", StringComparison.Ordinal), "Datetime columns must use TEXT type for SQLite");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Database schema must use create table if not exists syntax for all six tables")]
    public void DatabaseSchemaMustUseCreateTableIfNotExistsSyntaxForAllSixTables()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsTrue(Sql.Contains("CREATE TABLE IF NOT EXISTS users", StringComparison.Ordinal), "Users table must use IF NOT EXISTS");
        Assert.IsTrue(Sql.Contains("CREATE TABLE IF NOT EXISTS tasks", StringComparison.Ordinal), "Tasks table must use IF NOT EXISTS");
        Assert.IsTrue(Sql.Contains("CREATE TABLE IF NOT EXISTS pull_requests", StringComparison.Ordinal), "Pull requests table must use IF NOT EXISTS");
        Assert.IsTrue(Sql.Contains("CREATE TABLE IF NOT EXISTS payments", StringComparison.Ordinal), "Payments table must use IF NOT EXISTS");
        Assert.IsTrue(Sql.Contains("CREATE TABLE IF NOT EXISTS achievements", StringComparison.Ordinal), "Achievements table must use IF NOT EXISTS");
        Assert.IsTrue(Sql.Contains("CREATE TABLE IF NOT EXISTS leaderboard", StringComparison.Ordinal), "Leaderboard table must use IF NOT EXISTS");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Database schema github username column must default to empty string for sso profile import")]
    public void DatabaseSchemaGitHubUsernameColumnMustDefaultToEmptyStringForSsoProfileImport()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsTrue(Sql.Contains("github_username TEXT DEFAULT ''", StringComparison.Ordinal), "github_username must default to empty string");
    }
}
