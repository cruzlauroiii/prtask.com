using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("DashboardConstants has all UI text constants")]
    public void DashboardConstantsComplete()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "DashboardConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(DashboardConstants.ActiveTasksLabel)), "Has ActiveTasksLabel");
        Assert.IsTrue(Source.Contains(nameof(DashboardConstants.UsersLabel)), "Has UsersLabel");
        Assert.IsTrue(Source.Contains(nameof(DashboardConstants.TotalBountiesLabel)), "Has TotalBountiesLabel");
        Assert.IsTrue(Source.Contains(nameof(DashboardConstants.OpenTasksHeading)), "Has OpenTasksHeading");
        Assert.IsTrue(Source.Contains(nameof(DashboardConstants.EmptyStateText)), "Has EmptyStateText");
        Assert.IsTrue(Source.Contains(nameof(DashboardConstants.ViewButtonText)), "Has ViewButtonText");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("DashboardPage uses DashboardConstants for all UI text")]
    public void DashboardPageUsesDashboardConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "DashboardPage.razor");
        Assert.IsTrue(Source.Contains("DashboardConstants.ActiveTasksLabel"), "Uses ActiveTasksLabel");
        Assert.IsTrue(Source.Contains("DashboardConstants.UsersLabel"), "Uses UsersLabel");
        Assert.IsTrue(Source.Contains("DashboardConstants.TotalBountiesLabel"), "Uses TotalBountiesLabel");
        Assert.IsTrue(Source.Contains("DashboardConstants.OpenTasksHeading"), "Uses OpenTasksHeading");
        Assert.IsTrue(Source.Contains("DashboardConstants.EmptyStateText"), "Uses EmptyStateText");
        Assert.IsTrue(Source.Contains("DashboardConstants.ViewButtonText"), "Uses ViewButtonText");
        Assert.IsFalse(Source.Contains("\"Active Tasks\""), "No hardcoded stat label");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("ProfileConstants has UI text constants")]
    public void ProfileConstantsHasUiText()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "ProfileConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(ProfileConstants.LoadingText)), "Has LoadingText");
        Assert.IsTrue(Source.Contains(nameof(ProfileConstants.TotalEarnedLabel)), "Has TotalEarnedLabel");
        Assert.IsTrue(Source.Contains(nameof(ProfileConstants.TotalSpentLabel)), "Has TotalSpentLabel");
        Assert.IsTrue(Source.Contains(nameof(ProfileConstants.LeaderboardRankLabel)), "Has LeaderboardRankLabel");
        Assert.IsTrue(Source.Contains(nameof(ProfileConstants.PrsCompletedLabel)), "Has PrsCompletedLabel");
        Assert.IsTrue(Source.Contains(nameof(ProfileConstants.TasksPostedLabel)), "Has TasksPostedLabel");
        Assert.IsTrue(Source.Contains(nameof(ProfileConstants.RecentPrsHeading)), "Has RecentPrsHeading");
        Assert.IsTrue(Source.Contains(nameof(ProfileConstants.ViewButtonText)), "Has ViewButtonText");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("ProfilePage uses ProfileConstants for all UI text")]
    public void ProfilePageUsesProfileConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "ProfilePage.razor");
        Assert.IsTrue(Source.Contains("ProfileConstants.LoadingText"), "Uses LoadingText");
        Assert.IsTrue(Source.Contains("ProfileConstants.TotalEarnedLabel"), "Uses TotalEarnedLabel");
        Assert.IsTrue(Source.Contains("ProfileConstants.TotalSpentLabel"), "Uses TotalSpentLabel");
        Assert.IsTrue(Source.Contains("ProfileConstants.LeaderboardRankLabel"), "Uses LeaderboardRankLabel");
        Assert.IsTrue(Source.Contains("ProfileConstants.PrsCompletedLabel"), "Uses PrsCompletedLabel");
        Assert.IsTrue(Source.Contains("ProfileConstants.TasksPostedLabel"), "Uses TasksPostedLabel");
        Assert.IsTrue(Source.Contains("ProfileConstants.RecentPrsHeading"), "Uses RecentPrsHeading");
        Assert.IsTrue(Source.Contains("ProfileConstants.ViewButtonText"), "Uses ViewButtonText");
        Assert.IsFalse(Source.Contains("\"Total Earned\""), "No hardcoded stat label");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("PaymentPageConstants has all UI text constants")]
    public void PaymentPageConstantsComplete()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "PaymentPageConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(PaymentPageConstants.PageHeading)), "Has PageHeading");
        Assert.IsTrue(Source.Contains(nameof(PaymentPageConstants.PageDescription)), "Has PageDescription");
        Assert.IsTrue(Source.Contains(nameof(PaymentPageConstants.UserIdLabel)), "Has UserIdLabel");
        Assert.IsTrue(Source.Contains(nameof(PaymentPageConstants.LoadButtonText)), "Has LoadButtonText");
        Assert.IsTrue(Source.Contains(nameof(PaymentPageConstants.EmptyStateText)), "Has EmptyStateText");
        Assert.IsTrue(Source.Contains(nameof(PaymentPageConstants.HeaderDate)), "Has HeaderDate");
        Assert.IsTrue(Source.Contains(nameof(PaymentPageConstants.DateFormat)), "Has DateFormat");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("PaymentsPage uses PaymentPageConstants for all UI text")]
    public void PaymentsPageUsesPaymentPageConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Client", "PaymentsPage.razor");
        Assert.IsTrue(Source.Contains("PaymentPageConstants.PageHeading"), "Uses PageHeading");
        Assert.IsTrue(Source.Contains("PaymentPageConstants.PageDescription"), "Uses PageDescription");
        Assert.IsTrue(Source.Contains("PaymentPageConstants.UserIdLabel"), "Uses UserIdLabel");
        Assert.IsTrue(Source.Contains("PaymentPageConstants.LoadButtonText"), "Uses LoadButtonText");
        Assert.IsTrue(Source.Contains("PaymentPageConstants.EmptyStateText"), "Uses EmptyStateText");
        Assert.IsTrue(Source.Contains("PaymentPageConstants.HeaderDate"), "Uses HeaderDate");
        Assert.IsTrue(Source.Contains("PaymentPageConstants.DateFormat"), "Uses DateFormat");
        Assert.IsTrue(Source.Contains("PaymentPageConstants.TaskNotApplicable"), "Uses TaskNotApplicable");
        Assert.IsFalse(Source.Contains("\"Payment History\""), "No hardcoded heading");
    }
}
