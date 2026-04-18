using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("PullRequestDetailPage uses PrDetailConstants for all UI text")]
    public void PullRequestDetailPageUsesAllPrDetailConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "PullRequestDetailPage.razor");
        Assert.IsTrue(Source.Contains("PrDetailConstants.PageHeading"), "Uses PageHeading");
        Assert.IsTrue(Source.Contains("PrDetailConstants.LoadingText"), "Uses LoadingText");
        Assert.IsTrue(Source.Contains("PrDetailConstants.SubmittedByPrefix"), "Uses SubmittedByPrefix");
        Assert.IsTrue(Source.Contains("PrDetailConstants.ViewOnGitHubText"), "Uses ViewOnGitHubText");
        Assert.IsTrue(Source.Contains("PrDetailConstants.ChangedFilesHeading"), "Uses ChangedFilesHeading");
        Assert.IsTrue(Source.Contains("PrDetailConstants.CodeChangesHeading"), "Uses CodeChangesHeading");
        Assert.IsTrue(Source.Contains("PrDetailConstants.ReviewCommentsHeading"), "Uses ReviewCommentsHeading");
        Assert.IsTrue(Source.Contains("PrDetailConstants.ApproveAndMergeButtonText"), "Uses ApproveAndMergeButtonText");
        Assert.IsTrue(Source.Contains("PrDetailConstants.PaymentHeading"), "Uses PaymentHeading");
        Assert.IsTrue(Source.Contains("PrDetailConstants.CommentResolvedStatus"), "Uses CommentResolvedStatus");
        Assert.IsTrue(Source.Contains("PrDetailConstants.SplitViewLabel"), "Uses SplitViewLabel");
        Assert.IsTrue(Source.Contains("FormatStrings.DiffStats"), "Uses FormatStrings.DiffStats");
        Assert.IsTrue(Source.Contains("FormatStrings.CommentLocation"), "Uses FormatStrings.CommentLocation");
        Assert.IsFalse(Source.Contains("\"Pull Request Details\""), "No hardcoded page heading");
        Assert.IsFalse(Source.Contains("\"Approve and Merge\""), "No hardcoded approve text");
        Assert.IsFalse(Source.Contains("\"View on GitHub\""), "No hardcoded GitHub link text");
        Assert.IsFalse(Source.Contains("\"Review Comments\""), "No hardcoded review heading");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("HomeConstants has UI text")]
    public void HomeConstantsHasUiText()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "HomeConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(HomeConstants.HeroHeading)), "Has HeroHeading");
        Assert.IsTrue(Source.Contains(nameof(HomeConstants.HeroSubtitle)), "Has HeroSubtitle");
        Assert.IsTrue(Source.Contains(nameof(HomeConstants.BrowseTasksButtonText)), "Has BrowseTasksButtonText");
        Assert.IsTrue(Source.Contains(nameof(HomeConstants.HowItWorksButtonText)), "Has HowItWorksButtonText");
        Assert.IsTrue(Source.Contains(nameof(HomeConstants.FeaturePickTaskHeading)), "Has FeaturePickTaskHeading");
        Assert.IsTrue(Source.Contains(nameof(HomeConstants.FeatureSubmitPrHeading)), "Has FeatureSubmitPrHeading");
        Assert.IsTrue(Source.Contains(nameof(HomeConstants.FeatureGetPaidHeading)), "Has FeatureGetPaidHeading");
        Assert.IsTrue(Source.Contains(nameof(HomeConstants.OpenTasksLabel)), "Has OpenTasksLabel");
        Assert.IsTrue(Source.Contains(nameof(HomeConstants.TotalBountyPoolLabel)), "Has TotalBountyPoolLabel");
        Assert.IsTrue(Source.Contains(nameof(HomeConstants.DevelopersLabel)), "Has DevelopersLabel");
        Assert.IsTrue(Source.Contains(nameof(HomeConstants.DeveloperPayoutValue)), "Has DeveloperPayoutValue");
        Assert.IsTrue(Source.Contains(nameof(HomeConstants.AutomaticPaymentLabel)), "Has AutomaticPaymentLabel");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Home page uses HomeConstants for all UI text")]
    public void HomePageUsesAllHomeConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Home.razor");
        Assert.IsTrue(Source.Contains("HomeConstants.HeroHeading"), "Uses HeroHeading");
        Assert.IsTrue(Source.Contains("HomeConstants.HeroSubtitle"), "Uses HeroSubtitle");
        Assert.IsTrue(Source.Contains("HomeConstants.BrowseTasksButtonText"), "Uses BrowseTasksButtonText");
        Assert.IsTrue(Source.Contains("HomeConstants.HowItWorksButtonText"), "Uses HowItWorksButtonText");
        Assert.IsTrue(Source.Contains("HomeConstants.FeaturePickTaskHeading"), "Uses FeaturePickTaskHeading");
        Assert.IsTrue(Source.Contains("HomeConstants.FeatureGetPaidHeading"), "Uses FeatureGetPaidHeading");
        Assert.IsTrue(Source.Contains("HomeConstants.OpenTasksLabel"), "Uses OpenTasksLabel");
        Assert.IsTrue(Source.Contains("HomeConstants.DeveloperPayoutValue"), "Uses DeveloperPayoutValue");
        Assert.IsTrue(Source.Contains("HomeConstants.AutomaticPaymentLabel"), "Uses AutomaticPaymentLabel");
        Assert.IsFalse(Source.Contains("\"Pick a Task\""), "No hardcoded feature heading");
        Assert.IsFalse(Source.Contains("\"100%\""), "No hardcoded payout value");
        Assert.IsFalse(Source.Contains("\"Open Tasks\""), "No hardcoded stat label");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("FormatStrings has SubscriptionInterval, CommentLocation, and DiffStats")]
    public void FormatStringsHasNewMethods()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "FormatStrings.cs");
        Assert.IsTrue(Source.Contains("SubscriptionInterval"), "Has SubscriptionInterval");
        Assert.IsTrue(Source.Contains("CommentLocation"), "Has CommentLocation");
        Assert.IsTrue(Source.Contains("DiffStats"), "Has DiffStats");
        Assert.IsTrue(Source.Contains("SettingsConstants.SubscriptionIntervalFormat"), "Uses SubscriptionIntervalFormat");
        Assert.IsTrue(Source.Contains("PrDetailConstants.CommentLocationFormat"), "Uses CommentLocationFormat");
        Assert.IsTrue(Source.Contains("PrDetailConstants.DiffStatsFormat"), "Uses DiffStatsFormat");
    }
}
