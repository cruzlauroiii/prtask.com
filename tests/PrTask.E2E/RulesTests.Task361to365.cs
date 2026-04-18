using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("ProfilePage shows comprehensive stats — earned, spent, rank, PRs, tasks")]
    public void ProfilePageComprehensiveStats()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "ProfilePage.razor");
        Assert.IsTrue(Source.Contains("TotalEarnedCents"), "Shows total earned");
        Assert.IsTrue(Source.Contains("TotalSpentCents"), "Shows total spent");
        Assert.IsTrue(Source.Contains("UserRank"), "Shows leaderboard rank");
        Assert.IsTrue(Source.Contains("CompletedPrCount"), "Shows completed PR count");
        Assert.IsTrue(Source.Contains("TasksPostedCount"), "Shows tasks posted count");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("ProfilePage shows role badge and member since date")]
    public void ProfilePageRoleAndMemberSince()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "ProfilePage.razor");
        Assert.IsTrue(Source.Contains("ProfileUser.Role"), "Shows user role");
        Assert.IsTrue(Source.Contains("profile-role"), "Has role CSS class");
        Assert.IsTrue(Source.Contains("profile-member-since"), "Has member since section");
        Assert.IsTrue(Source.Contains(nameof(ProfileConstants.MemberSinceDateFormat)), "Uses ProfileConstants date format");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("ProfilePage shows recent pull requests")]
    public void ProfilePageRecentPrs()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "ProfilePage.razor");
        Assert.IsTrue(Source.Contains("RecentPullRequests"), "Has recent PRs list");
        Assert.IsTrue(Source.Contains("profile-recent-prs"), "Has recent PRs section");
        Assert.IsTrue(Source.Contains("ListByDeveloperAsync"), "Loads PRs by developer");
        Assert.IsTrue(Source.Contains(nameof(ProfileConstants.RecentPrLimit)), "Limits recent PRs");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("ITaskService has ListByClientAsync")]
    public void TaskServiceHasListByClient()
    {
        var Source = ReadSource("PrTask.Application", "Services", "ITaskService.cs");
        Assert.IsTrue(Source.Contains("ListByClientAsync"), "Has ListByClientAsync method");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("ProfileConstants has date format and PR limit")]
    public void ProfileConstantsHasValues()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "ProfileConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(ProfileConstants.MemberSinceDateFormat)), "Has MemberSinceDateFormat");
        Assert.IsTrue(Source.Contains(nameof(ProfileConstants.RecentPrLimit)), "Has RecentPrLimit");
    }
}
