using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("DemoSeedConstants defines User seed data")]
    public void DemoSeedConstantsDefinesUserSeedData()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "DemoSeedConstants.cs");
        Assert.IsTrue(Source.Contains("ClientDisplayName"), "Must define ClientDisplayName");
        Assert.IsTrue(Source.Contains("ClientEmail"), "Must define ClientEmail");
        Assert.IsTrue(Source.Contains("DeveloperDisplayName"), "Must define DeveloperDisplayName");
        Assert.IsTrue(Source.Contains("DeveloperEmail"), "Must define DeveloperEmail");
        Assert.IsTrue(Source.Contains("ClientSpentCents"), "Must define ClientSpentCents");
        Assert.IsTrue(Source.Contains("DeveloperEarnedCents"), "Must define DeveloperEarnedCents");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Program.cs seeds UserEntity records for demo")]
    public void ProgramCsSeedsUserEntityRecords()
    {
        var Source = ReadSource("PrTask.Server", "Program.cs");
        Assert.IsTrue(Source.Contains("Db.Users.AnyAsync"),
            "Program.cs must check Users before seeding");
        Assert.IsTrue(Source.Contains("DemoSeedConstants.ClientDisplayName"),
            "Program.cs must use DemoSeedConstants.ClientDisplayName");
        Assert.IsTrue(Source.Contains("DemoSeedConstants.DeveloperDisplayName"),
            "Program.cs must use DemoSeedConstants.DeveloperDisplayName");
        Assert.IsTrue(Source.Contains("UserRole.Client"),
            "Program.cs must seed client with UserRole.Client");
        Assert.IsTrue(Source.Contains("UserRole.Developer"),
            "Program.cs must seed developer with UserRole.Developer");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("DemoSeedConstants defines Payment seed data")]
    public void DemoSeedConstantsDefinesPaymentSeedData()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "DemoSeedConstants.cs");
        Assert.IsTrue(Source.Contains("PaymentAmountCents"), "Must define PaymentAmountCents");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Program.cs seeds PaymentEntity for demo")]
    public void ProgramCsSeedsPaymentEntity()
    {
        var Source = ReadSource("PrTask.Server", "Program.cs");
        Assert.IsTrue(Source.Contains("Db.Payments.AnyAsync"),
            "Program.cs must check Payments before seeding");
        Assert.IsTrue(Source.Contains("PaymentType.AutomaticCharge"),
            "Program.cs must seed payment with AutomaticCharge type");
        Assert.IsTrue(Source.Contains("PaymentStatus.Completed"),
            "Program.cs must seed payment with Completed status");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("DemoSeedConstants defines BoardColumn seed data")]
    public void DemoSeedConstantsDefinesBoardColumnSeedData()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "DemoSeedConstants.cs");
        Assert.IsTrue(Source.Contains("ColumnTodoId"), "Must define ColumnTodoId");
        Assert.IsTrue(Source.Contains("ColumnTodoName"), "Must define ColumnTodoName");
        Assert.IsTrue(Source.Contains("ColumnInProgressId"), "Must define ColumnInProgressId");
        Assert.IsTrue(Source.Contains("ColumnDoneId"), "Must define ColumnDoneId");
        Assert.IsTrue(Source.Contains("ColumnWipLimit"), "Must define ColumnWipLimit");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Program.cs seeds BoardColumnEntity records for demo")]
    public void ProgramCsSeedsBoardColumnRecords()
    {
        var Source = ReadSource("PrTask.Server", "Program.cs");
        Assert.IsTrue(Source.Contains("Db.BoardColumns.AnyAsync"),
            "Program.cs must check BoardColumns before seeding");
        Assert.IsTrue(Source.Contains("DemoSeedConstants.ColumnTodoId"),
            "Program.cs must seed To Do column");
        Assert.IsTrue(Source.Contains("DemoSeedConstants.ColumnInProgressId"),
            "Program.cs must seed In Progress column");
        Assert.IsTrue(Source.Contains("DemoSeedConstants.ColumnDoneId"),
            "Program.cs must seed Done column");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("DemoSeedConstants defines Achievement seed data")]
    public void DemoSeedConstantsDefinesAchievementSeedData()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "DemoSeedConstants.cs");
        Assert.IsTrue(Source.Contains("AchievementId"), "Must define AchievementId");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Program.cs seeds AchievementEntity for demo")]
    public void ProgramCsSeedsAchievementEntity()
    {
        var Source = ReadSource("PrTask.Server", "Program.cs");
        Assert.IsTrue(Source.Contains("Db.Achievements.AnyAsync"),
            "Program.cs must check Achievements before seeding");
        Assert.IsTrue(Source.Contains(nameof(BadgeConstants) + "." + nameof(BadgeConstants.FirstPrMerged)),
            "Program.cs must seed achievement with BadgeConstants.FirstPrMerged");
    }
}
