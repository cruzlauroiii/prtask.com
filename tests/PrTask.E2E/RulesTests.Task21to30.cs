namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task21 TaskEntity must have BountyAmountCents Complexity Deadline Tags MaxClaims and PaymentId")]
    public void Task21TaskEntityFields()
    {
        var Code = ReadSource("PrTask.Domain", "Models", "TaskEntity.cs");
        Assert.IsTrue(Code.Contains("BountyAmountCents"), "Must have BountyAmountCents");
        Assert.IsTrue(Code.Contains("TaskComplexity Complexity"), "Must have Complexity");
        Assert.IsTrue(Code.Contains("Deadline"), "Must have Deadline");
        Assert.IsTrue(Code.Contains("Tags"), "Must have Tags");
        Assert.IsTrue(Code.Contains("MaxClaims"), "Must have MaxClaims");
        Assert.IsTrue(Code.Contains("PaymentId"), "Must have PaymentId");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task22 PullRequestEntity must have complexity status DiffStorageKey SubmittedAt MergedAt PaidAt")]
    public void Task22PullRequestEntityFields()
    {
        var Code = ReadSource("PrTask.Domain", "Models", "PullRequestEntity.cs");
        Assert.IsTrue(Code.Contains("ComplexityScore"), "Must have complexity score");
        Assert.IsTrue(Code.Contains("PullRequestStatus Status"), "Must have Status");
        Assert.IsTrue(Code.Contains("DiffStorageKey"), "Must have DiffStorageKey");
        Assert.IsTrue(Code.Contains("SubmittedAt"), "Must have SubmittedAt");
        Assert.IsTrue(Code.Contains("MergedAt"), "Must have MergedAt");
        Assert.IsTrue(Code.Contains("PaidAt"), "Must have PaidAt");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task23 PullRequestStatus enum must include Submitted Approved Rejected Merged and Paid")]
    public void Task23PullRequestStatusEnum()
    {
        var Code = ReadSource("PrTask.Domain", "Models", "PullRequestStatus.cs");
        Assert.IsTrue(Code.Contains("Submitted = 0"), "Must define Submitted");
        Assert.IsTrue(Code.Contains("Approved = 1"), "Must define Approved");
        Assert.IsTrue(Code.Contains("Rejected = 2"), "Must define Rejected");
        Assert.IsTrue(Code.Contains("Merged = 3"), "Must define Merged");
        Assert.IsTrue(Code.Contains("Paid = 4"), "Must define Paid");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task24 TaskComplexity enum must range from Trivial through Expert levels")]
    public void Task24TaskComplexityEnum()
    {
        var Code = ReadSource("PrTask.Domain", "Models", "TaskComplexity.cs");
        Assert.IsTrue(Code.Contains("Trivial = 0"), "Must define Trivial");
        Assert.IsTrue(Code.Contains("Simple = 1"), "Must define Simple");
        Assert.IsTrue(Code.Contains("Medium = 2"), "Must define Medium");
        Assert.IsTrue(Code.Contains("Complex = 3"), "Must define Complex");
        Assert.IsTrue(Code.Contains("Expert = 4"), "Must define Expert");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task25 UserEntity must have XP Level Earnings and MayaCustomerId")]
    public void Task25UserEntityFields()
    {
        var Code = ReadSource("PrTask.Domain", "Models", "UserEntity.cs");
        Assert.IsTrue(Code.Contains("int Xp { get; set; }"), "Must have Xp");
        Assert.IsTrue(Code.Contains("int Level { get; set; }"), "Must have Level");
        Assert.IsTrue(Code.Contains("TotalEarnedCents"), "Must have earnings tracking");
        Assert.IsTrue(Code.Contains("MayaCustomerId"), "Must have MayaCustomerId");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task26 PaymentType must include AutomaticCharge DeveloperPayout Refund and PaymentStatus Pending through Refunded")]
    public void Task26PaymentTypeAndStatusEnums()
    {
        var PayType = ReadSource("PrTask.Domain", "Models", "PaymentType.cs");
        Assert.IsTrue(PayType.Contains("AutomaticCharge = 0"), "Must define AutomaticCharge");
        Assert.IsTrue(PayType.Contains("DeveloperPayout = 1"), "Must define DeveloperPayout");
        Assert.IsTrue(PayType.Contains("Refund = 2"), "Must define Refund");
        var PayStatus = ReadSource("PrTask.Domain", "Models", "PaymentStatus.cs");
        Assert.IsTrue(PayStatus.Contains("Pending"), "Must have Pending status");
        Assert.IsTrue(PayStatus.Contains("Refunded"), "Must have Refunded status");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task27 UserRole enum must include Developer Client and Admin")]
    public void Task27UserRoleEnum()
    {
        var Code = ReadSource("PrTask.Domain", "Models", "UserRole.cs");
        Assert.IsTrue(Code.Contains("Developer = 0"), "Must define Developer");
        Assert.IsTrue(Code.Contains("Client = 1"), "Must define Client");
        Assert.IsTrue(Code.Contains("Admin = 2"), "Must define Admin");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task28 LeaderboardEntry must have ranking fields and AchievementEntity must have badge and timestamp")]
    public void Task28LeaderboardAndAchievementEntities()
    {
        var Lb = ReadSource("PrTask.Domain", "Models", "LeaderboardEntry.cs");
        Assert.IsTrue(Lb.Contains("Rank"), "LeaderboardEntry must have Rank");
        Assert.IsTrue(Lb.Contains("UserId"), "LeaderboardEntry must have UserId");
        Assert.IsTrue(Lb.Contains("PrsMerged"), "LeaderboardEntry must have PrsMerged");
        var Ach = ReadSource("PrTask.Domain", "Models", "AchievementEntity.cs");
        Assert.IsTrue(Ach.Contains("BadgeType"), "AchievementEntity must have BadgeType");
        Assert.IsTrue(Ach.Contains("EarnedAt"), "AchievementEntity must have EarnedAt");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task29 Constants classes must exist MayaConstants GitHubConstants GoogleConstants AzureConstants OktaConstants")]
    public void Task29ConstantsClasses()
    {
        var Maya = ReadSource("PrTask.Domain", "Constants", "MayaConstants.cs");
        Assert.IsTrue(Maya.Contains("pg-sandbox.paymaya.com"), "Must have sandbox URL");
        Assert.IsTrue(Maya.Contains("pg.paymaya.com"), "Must have production URL");
        var Gh = ReadSource("PrTask.Domain", "Constants", "GitHubConstants.cs");
        Assert.IsTrue(Gh.Contains("github.com/login/oauth/authorize"), "Must have GitHub authorize URL");
        Assert.IsTrue(Gh.Contains("api.github.com/user"), "Must have GitHub user API URL");
        var Az = ReadSource("PrTask.Domain", "Constants", "AzureConstants.cs");
        Assert.IsTrue(Az.Contains("CommonTenant"), "Must have common tenant");
        Assert.IsTrue(Az.Contains("graph.microsoft.com"), "Must use MS Graph");
        var Ok = ReadSource("PrTask.Domain", "Constants", "OktaConstants.cs");
        Assert.IsTrue(Ok.Contains("AuthorizePathTemplate"), "Must have authorize path template");
        Assert.IsTrue(Ok.Contains("TokenPathTemplate"), "Must have token path template");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task30 RouteConstants BadgeConstants and AppConstants must define endpoints routes XP Level and fee values")]
    public void Task30RouteConstantsBadgeConstantsAppConstants()
    {
        var Routes = ReadSource("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Routes.Contains("Home = \"/\""), "Must define Home route");
        Assert.IsTrue(Routes.Contains("Login = \"/Login\""), "Must define Login route");
        Assert.IsTrue(Routes.Contains("ApiTasks = \"/Api/Tasks\""), "Must define API tasks route");
        Assert.IsTrue(Routes.Contains("Terms = \"/Legal/Terms\""), "Must define Terms route");
        Assert.IsTrue(Routes.Contains("Licenses = \"/Legal/Licenses\""), "Must define Licenses route");
        var Badges = ReadSource("PrTask.Domain", "Constants", "BadgeConstants.cs");
        Assert.IsTrue(Badges.Contains("BadgeConstants"), "BadgeConstants must exist");
        var App = ReadSource("PrTask.Domain", "Constants", "AppConstants.cs");
        Assert.IsTrue(App.Contains("XpPerComplexityPoint"), "Must define XP per complexity point");
        Assert.IsTrue(App.Contains("Level1Threshold"), "Must define level thresholds");
        Assert.IsTrue(App.Contains("PlatformFeePercent = 0"), "Must set zero platform fee");
    }
}
