namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Database schema must define users table with github identity role and financial tracking columns")]
    public void DatabaseSchemaMustDefineUsersTableWithGitHubIdentityRoleAndFinancialTrackingColumns()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsTrue(Sql.Contains("CREATE TABLE IF NOT EXISTS users", StringComparison.Ordinal), "Schema must create users table");
        Assert.IsTrue(Sql.Contains("github_id INTEGER", StringComparison.Ordinal), "Users must have github_id column");
        Assert.IsTrue(Sql.Contains("github_username TEXT", StringComparison.Ordinal), "Users must have github_username column");
        Assert.IsTrue(Sql.Contains("role TEXT DEFAULT 'Developer'", StringComparison.Ordinal), "Users role must default to Developer");
        Assert.IsTrue(Sql.Contains("total_earned_cents INTEGER DEFAULT 0", StringComparison.Ordinal), "Users must track total earned");
        Assert.IsTrue(Sql.Contains("total_spent_cents INTEGER DEFAULT 0", StringComparison.Ordinal), "Users must track total spent");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Database schema must define users table with xp level streak and timestamp columns")]
    public void DatabaseSchemaMustDefineUsersTableWithXpLevelStreakAndTimestampColumns()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsTrue(Sql.Contains("xp INTEGER DEFAULT 0", StringComparison.Ordinal), "Users must have xp column");
        Assert.IsTrue(Sql.Contains("level INTEGER DEFAULT 1", StringComparison.Ordinal), "Users must have level defaulting to 1");
        Assert.IsTrue(Sql.Contains("streak_days INTEGER DEFAULT 0", StringComparison.Ordinal), "Users must have streak_days column");
        Assert.IsTrue(Sql.Contains("maya_customer_id TEXT", StringComparison.Ordinal), "Users must have maya_customer_id column");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Database schema must define tasks table with client id complexity bounty and status columns")]
    public void DatabaseSchemaMustDefineTasksTableWithClientIdComplexityBountyAndStatusColumns()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsTrue(Sql.Contains("CREATE TABLE IF NOT EXISTS tasks", StringComparison.Ordinal), "Schema must create tasks table");
        Assert.IsTrue(Sql.Contains("client_id TEXT NOT NULL", StringComparison.Ordinal), "Tasks must have required client_id");
        Assert.IsTrue(Sql.Contains("title TEXT NOT NULL", StringComparison.Ordinal), "Tasks must have required title");
        Assert.IsTrue(Sql.Contains("complexity TEXT DEFAULT 'Medium'", StringComparison.Ordinal), "Tasks complexity must default to Medium");
        Assert.IsTrue(Sql.Contains("bounty_amount_cents INTEGER DEFAULT 0", StringComparison.Ordinal), "Tasks must have bounty_amount_cents");
        Assert.IsTrue(Sql.Contains("status TEXT DEFAULT 'Open'", StringComparison.Ordinal), "Tasks status must default to Open");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Database schema must define pull requests table with task and developer foreign keys")]
    public void DatabaseSchemaMustDefinePullRequestsTableWithTaskAndDeveloperForeignKeys()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsTrue(Sql.Contains("CREATE TABLE IF NOT EXISTS pull_requests", StringComparison.Ordinal), "Schema must create pull_requests table");
        Assert.IsTrue(Sql.Contains("task_id TEXT NOT NULL", StringComparison.Ordinal), "PRs must have required task_id");
        Assert.IsTrue(Sql.Contains("developer_id TEXT NOT NULL", StringComparison.Ordinal), "PRs must have required developer_id");
        Assert.IsTrue(Sql.Contains("complexity_score INTEGER DEFAULT 0", StringComparison.Ordinal), "PRs must have complexity_score");
        Assert.IsTrue(Sql.Contains("diff_storage_key TEXT", StringComparison.Ordinal), "PRs must have diff_storage_key for R2 storage");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Database schema must define payments table with maya checkout and payment id columns")]
    public void DatabaseSchemaMustDefinePaymentsTableWithMayaCheckoutAndPaymentIdColumns()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsTrue(Sql.Contains("CREATE TABLE IF NOT EXISTS payments", StringComparison.Ordinal), "Schema must create payments table");
        Assert.IsTrue(Sql.Contains("amount_cents INTEGER NOT NULL", StringComparison.Ordinal), "Payments must have required amount");
        Assert.IsTrue(Sql.Contains("payment_type TEXT NOT NULL", StringComparison.Ordinal), "Payments must have required type");
        Assert.IsTrue(Sql.Contains("maya_checkout_id TEXT", StringComparison.Ordinal), "Payments must have maya_checkout_id");
        Assert.IsTrue(Sql.Contains("maya_payment_id TEXT", StringComparison.Ordinal), "Payments must have maya_payment_id");
        Assert.IsTrue(Sql.Contains("status TEXT DEFAULT 'Pending'", StringComparison.Ordinal), "Payment status must default to Pending");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Database schema must define achievements and leaderboard tables with foreign key constraints")]
    public void DatabaseSchemaMustDefineAchievementsAndLeaderboardTablesWithForeignKeyConstraints()
    {
        var Sql = ReadInfraFile("schema.sql");
        Assert.IsTrue(Sql.Contains("CREATE TABLE IF NOT EXISTS achievements", StringComparison.Ordinal), "Schema must create achievements table");
        Assert.IsTrue(Sql.Contains("badge_type TEXT NOT NULL", StringComparison.Ordinal), "Achievements must have required badge_type");
        Assert.IsTrue(Sql.Contains("CREATE TABLE IF NOT EXISTS leaderboard", StringComparison.Ordinal), "Schema must create leaderboard table");
        Assert.IsTrue(Sql.Contains("total_xp INTEGER DEFAULT 0", StringComparison.Ordinal), "Leaderboard must track total XP");
        Assert.IsTrue(Sql.Contains("FOREIGN KEY", StringComparison.Ordinal), "Schema must use foreign key constraints for referential integrity");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Database schema must have six total tables matching domain entity models exactly")]
    public void DatabaseSchemaMustHaveSixTotalTablesMatchingDomainEntityModelsExactly()
    {
        var Sql = ReadInfraFile("schema.sql");
        var TableCount = Sql.Split("CREATE TABLE IF NOT EXISTS").Length - 1;
        Assert.AreEqual(6, TableCount, "Schema must define exactly 6 tables: users, tasks, pull_requests, payments, achievements, leaderboard");
    }
}
