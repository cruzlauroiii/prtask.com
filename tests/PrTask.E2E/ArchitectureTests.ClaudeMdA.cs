using System.Reflection;
using System.Text.RegularExpressions;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.E2E;
public partial class ArchitectureTests
{
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("All project files must target dot net ten framework for latest platform support")]
   public void TClaudeMd01AllProjectFilesMustTargetDotNetTenFrameworkForLatestPlatformSupport()
   {
       var Violations = new List<string>();
       foreach (var ProjectFile in GetAllProjectFiles())
       {
           var Content = File.ReadAllText(ProjectFile);
           var FileName = Path.GetFileName(ProjectFile);
           if (!Content.Contains("net10.0") && !Content.Contains("net10.0-android"))
           {
               Violations.Add(FileName);
           }
       }
       Assert.AreEqual(0, Violations.Count, $"Projects not targeting .NET 10: {string.Join(", ", Violations)}");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("Client project must use Blazor WebAssembly SDK for browser only execution model")]
   public void TClaudeMd02ClientProjectMustUseBlazorWebAssemblySdkForBrowserOnlyExecutionModel()
   {
       var ClientProj = Path.Combine(SourceRoot, ClientProject, $"{ClientProject}.csproj");
       var Content = File.ReadAllText(ClientProj);
       Assert.IsTrue(Content.Contains("Microsoft.NET.Sdk.BlazorWebAssembly"), "Client project must use BlazorWebAssembly SDK");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("No third party runtime packages allowed only Microsoft or PrivateAssets all analyzer packages")]
   public void TClaudeMd03NoThirdPartyRuntimePackagesAllowedOnlyMicrosoftOrPrivateAssetsAllAnalyzerPackages()
   {
       var Violations = new List<string>();
       var PrivateAssetsPattern = PrivateAssetsAllRegex();
       foreach (var ProjectFile in GetAllProjectFiles())
       {
           var Lines = File.ReadAllLines(ProjectFile);
           var FileName = Path.GetFileName(ProjectFile);
           foreach (var Line in Lines)
           {
               if (!Line.Contains("PackageReference"))
               {
                   continue;
               }
               if (Line.Contains("Microsoft.") || Line.Contains("MSTest") || Line.Contains("coverlet") || Line.Contains("SassCompiler"))
               {
                   continue;
               }
               if (PrivateAssetsPattern.IsMatch(Line))
               {
                   continue;
               }
               Violations.Add($"{FileName}: {Line.Trim()}");
           }
       }
       Assert.AreEqual(0, Violations.Count, $"Third-party runtime packages: {string.Join(", ", Violations.Take(5))}");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("SharedUI must be a Razor class library project for component sharing across platforms")]
   public void TClaudeMd04SharedUiMustBeARazorClassLibraryProjectForComponentSharingAcrossPlatforms()
   {
       var SharedUiProj = Path.Combine(SourceRoot, SharedUiProject, $"{SharedUiProject}.csproj");
       var Content = File.ReadAllText(SharedUiProj);
       Assert.IsTrue(Content.Contains("Microsoft.NET.Sdk.Razor"), "SharedUI must use Razor SDK");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("SharedUI must not have FrameworkReference to AspNetCore App to allow MAUI compatibility")]
   public void TClaudeMd05SharedUiMustNotHaveFrameworkReferenceToAspNetCoreAppToAllowMauiCompatibility()
   {
       var SharedUiProj = Path.Combine(SourceRoot, SharedUiProject, $"{SharedUiProject}.csproj");
       var Content = File.ReadAllText(SharedUiProj);
       Assert.IsFalse(Content.Contains("<FrameworkReference Include=\"Microsoft.AspNetCore.App\""), "SharedUI must not reference AspNetCore.App — blocks MAUI");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("Client project must reference SharedUI for shared component consumption in browser")]
   public void TClaudeMd06ClientProjectMustReferenceSharedUiForSharedComponentConsumptionInBrowser()
   {
       var ClientProj = Path.Combine(SourceRoot, ClientProject, $"{ClientProject}.csproj");
       var Content = File.ReadAllText(ClientProj);
       Assert.IsTrue(Content.Contains("PrTask.SharedUI"), "Client must reference SharedUI");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("MAUI project must target Android platform with use MAUI enabled for mobile support")]
   public void TClaudeMd08MauiProjectMustTargetAndroidPlatformWithUseMauiEnabledForMobileSupport()
   {
       var MauiProj = Path.Combine(SourceRoot, MauiProject, $"{MauiProject}.csproj");
       var Content = File.ReadAllText(MauiProj);
       Assert.IsTrue(Content.Contains("android"), "MAUI must target Android");
       Assert.IsTrue(Content.Contains("<UseMaui>true</UseMaui>"), "MAUI must have UseMaui enabled");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("TaskEntity must have bounty amount property for client job posting with payment incentives")]
   public void TClaudeMd09TaskEntityMustHaveBountyAmountPropertyForClientJobPostingWithPaymentIncentives()
   {
       var Properties = typeof(TaskEntity).GetProperties(BindingFlags.Public | BindingFlags.Instance);
       Assert.IsTrue(Properties.Any(P => P.Name == "BountyAmountCents"), "TaskEntity missing BountyAmountCents");
       Assert.IsTrue(Properties.Any(P => P.Name == "Complexity"), "TaskEntity missing Complexity");
       Assert.IsTrue(Properties.Any(P => P.Name == "Status"), "TaskEntity missing Status");
       Assert.IsTrue(Properties.Any(P => P.Name == "ClientId"), "TaskEntity missing ClientId");
       Assert.IsTrue(Properties.Any(P => P.Name == "Title"), "TaskEntity missing Title");
       Assert.IsTrue(Properties.Any(P => P.Name == "RepoUrl"), "TaskEntity missing RepoUrl");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("PullRequestEntity must have complexity score and review status for payment scaling logic")]
   public void TClaudeMd10PullRequestEntityMustHaveComplexityScoreAndReviewStatusForPaymentScalingLogic()
   {
       var Properties = typeof(PullRequestEntity).GetProperties(BindingFlags.Public | BindingFlags.Instance);
       Assert.IsTrue(Properties.Any(P => P.Name == "ComplexityScore"), "PullRequestEntity missing ComplexityScore");
       Assert.IsTrue(Properties.Any(P => P.Name == "Status"), "PullRequestEntity missing Status");
       Assert.IsTrue(Properties.Any(P => P.Name == "DeveloperId"), "PullRequestEntity missing DeveloperId");
       Assert.IsTrue(Properties.Any(P => P.Name == "TaskId"), "PullRequestEntity missing TaskId");
       Assert.IsTrue(Properties.Any(P => P.Name == "FilesChanged"), "PullRequestEntity missing FilesChanged");
       Assert.IsTrue(Properties.Any(P => P.Name == "Additions"), "PullRequestEntity missing Additions");
       Assert.IsTrue(Properties.Any(P => P.Name == "Deletions"), "PullRequestEntity missing Deletions");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("PullRequestStatus enum must include Merged and Paid values for payment flow completion")]
   public void TClaudeMd11PullRequestStatusEnumMustIncludeMergedAndPaidValuesForPaymentFlowCompletion()
   {
       var Names = Enum.GetNames<PullRequestStatus>();
       Assert.IsTrue(Names.Contains("Submitted"), "Missing Submitted status");
       Assert.IsTrue(Names.Contains("Approved"), "Missing Approved status");
       Assert.IsTrue(Names.Contains("Rejected"), "Missing Rejected status");
       Assert.IsTrue(Names.Contains("Merged"), "Missing Merged status");
       Assert.IsTrue(Names.Contains("Paid"), "Missing Paid status");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("TaskComplexity enum must define graduated levels from Trivial to Expert for scoring")]
   public void TClaudeMd12TaskComplexityEnumMustDefineGraduatedLevelsFromTrivialToExpertForScoring()
   {
       var Names = Enum.GetNames<TaskComplexity>();
       Assert.IsTrue(Names.Contains("Trivial"), "Missing Trivial");
       Assert.IsTrue(Names.Contains("Simple"), "Missing Simple");
       Assert.IsTrue(Names.Contains("Medium"), "Missing Medium");
       Assert.IsTrue(Names.Contains("Complex"), "Missing Complex");
       Assert.IsTrue(Names.Contains("Expert"), "Missing Expert");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("UserEntity must have experience points level and earnings tracking for gamification system")]
   public void TClaudeMd13UserEntityMustHaveExperiencePointsLevelAndEarningsTrackingForGamificationSystem()
   {
       var Properties = typeof(UserEntity).GetProperties(BindingFlags.Public | BindingFlags.Instance);
       Assert.IsTrue(Properties.Any(P => P.Name == "Xp"), "UserEntity missing Xp");
       Assert.IsTrue(Properties.Any(P => P.Name == "Level"), "UserEntity missing Level");
       Assert.IsTrue(Properties.Any(P => P.Name == "TotalEarnedCents"), "UserEntity missing TotalEarnedCents");
       Assert.IsTrue(Properties.Any(P => P.Name == "TotalSpentCents"), "UserEntity missing TotalSpentCents");
       Assert.IsTrue(Properties.Any(P => P.Name == "StreakDays"), "UserEntity missing StreakDays");
       Assert.IsTrue(Properties.Any(P => P.Name == "GitHubUsername"), "UserEntity missing GitHubUsername");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("LeaderboardEntry must have ranking fields for public competitive developer leaderboard display")]
   public void TClaudeMd14LeaderboardEntryMustHaveRankingFieldsForPublicCompetitiveDeveloperLeaderboardDisplay()
   {
       var Properties = typeof(LeaderboardEntry).GetProperties(BindingFlags.Public | BindingFlags.Instance);
       Assert.IsTrue(Properties.Any(P => P.Name == "Rank"), "LeaderboardEntry missing Rank");
       Assert.IsTrue(Properties.Any(P => P.Name == "PrsMerged"), "LeaderboardEntry missing PrsMerged");
       Assert.IsTrue(Properties.Any(P => P.Name == "TotalEarnedCents"), "LeaderboardEntry missing TotalEarnedCents");
       Assert.IsTrue(Properties.Any(P => P.Name == "Xp"), "LeaderboardEntry missing Xp");
       Assert.IsTrue(Properties.Any(P => P.Name == "Level"), "LeaderboardEntry missing Level");
       Assert.IsTrue(Properties.Any(P => P.Name == "ComplexityScoreSum"), "LeaderboardEntry missing ComplexityScoreSum");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("AchievementEntity must have badge type and earned timestamp for badge tracking system")]
   public void TClaudeMd15AchievementEntityMustHaveBadgeTypeAndEarnedTimestampForBadgeTrackingSystem()
   {
       var Properties = typeof(AchievementEntity).GetProperties(BindingFlags.Public | BindingFlags.Instance);
       Assert.IsTrue(Properties.Any(P => P.Name == "BadgeType"), "AchievementEntity missing BadgeType");
       Assert.IsTrue(Properties.Any(P => P.Name == "EarnedAt"), "AchievementEntity missing EarnedAt");
       Assert.IsTrue(Properties.Any(P => P.Name == "UserId"), "AchievementEntity missing UserId");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("PaymentEntity must have Maya integration fields for checkout and webhook processing")]
   public void TClaudeMd16PaymentEntityMustHaveMayaIntegrationFieldsForCheckoutAndWebhookProcessing()
   {
       var Properties = typeof(PaymentEntity).GetProperties(BindingFlags.Public | BindingFlags.Instance);
       Assert.IsTrue(Properties.Any(P => P.Name == "MayaCheckoutId"), "PaymentEntity missing MayaCheckoutId");
       Assert.IsTrue(Properties.Any(P => P.Name == "MayaPaymentId"), "PaymentEntity missing MayaPaymentId");
       Assert.IsTrue(Properties.Any(P => P.Name == "AmountCents"), "PaymentEntity missing AmountCents");
       Assert.IsTrue(Properties.Any(P => P.Name == "PlatformFeeCents"), "PaymentEntity missing PlatformFeeCents");
       Assert.IsTrue(Properties.Any(P => P.Name == "MayaStatus"), "PaymentEntity missing MayaStatus");
       Assert.IsTrue(Properties.Any(P => P.Name == "WebhookData"), "PaymentEntity missing WebhookData");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("PaymentType enum must include automatic charge developer payout and refund transaction types")]
   public void TClaudeMd17PaymentTypeEnumMustIncludeAutomaticChargeDeveloperPayoutAndRefundTransactionTypes()
   {
       var Names = Enum.GetNames<PaymentType>();
       Assert.IsTrue(Names.Contains("AutomaticCharge"), "Missing AutomaticCharge");
       Assert.IsTrue(Names.Contains("DeveloperPayout"), "Missing DeveloperPayout");
       Assert.IsTrue(Names.Contains("Refund"), "Missing Refund");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("PaymentStatus enum must track full lifecycle from Pending through Completed to Refunded")]
   public void TClaudeMd18PaymentStatusEnumMustTrackFullLifecycleFromPendingThroughCompletedToRefunded()
   {
       var Names = Enum.GetNames<PaymentStatus>();
       Assert.IsTrue(Names.Contains("Pending"), "Missing Pending");
       Assert.IsTrue(Names.Contains("Processing"), "Missing Processing");
       Assert.IsTrue(Names.Contains("Completed"), "Missing Completed");
       Assert.IsTrue(Names.Contains("Failed"), "Missing Failed");
       Assert.IsTrue(Names.Contains("Refunded"), "Missing Refunded");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("MayaConstants must define sandbox and production base URLs for payment gateway integration")]
   public void TClaudeMd19MayaConstantsMustDefineSandboxAndProductionBaseUrlsForPaymentGatewayIntegration()
   {
       Assert.IsFalse(string.IsNullOrEmpty(MayaConstants.SandboxBaseUrl), "MayaConstants missing SandboxBaseUrl");
       Assert.IsFalse(string.IsNullOrEmpty(MayaConstants.ProductionBaseUrl), "MayaConstants missing ProductionBaseUrl");
       Assert.IsFalse(string.IsNullOrEmpty(MayaConstants.CheckoutEndpoint), "MayaConstants missing CheckoutEndpoint");
       Assert.IsFalse(string.IsNullOrEmpty(MayaConstants.WebhookEndpoint), "MayaConstants missing WebhookEndpoint");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("GitHubConstants must define OAuth authorize and token exchange URLs for SSO authentication")]
   public void TClaudeMd21GitHubConstantsMustDefineOAuthAuthorizeAndTokenExchangeUrlsForSsoAuthentication()
   {
       Assert.IsFalse(string.IsNullOrEmpty(GitHubConstants.AuthorizeUrl), "GitHubConstants missing AuthorizeUrl");
       Assert.IsFalse(string.IsNullOrEmpty(GitHubConstants.TokenUrl), "GitHubConstants missing TokenUrl");
       Assert.IsFalse(string.IsNullOrEmpty(GitHubConstants.UserApiUrl), "GitHubConstants missing UserApiUrl");
       Assert.IsTrue(GitHubConstants.AuthorizeUrl.Contains("github.com"), "AuthorizeUrl must point to github.com");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("RouteConstants must define API endpoints for tasks pull requests payments and authentication")]
   public void TClaudeMd22RouteConstantsMustDefineApiEndpointsForTasksPullRequestsPaymentsAndAuthentication()
   {
       Assert.IsFalse(string.IsNullOrEmpty(RouteConstants.ApiTasks), "Missing ApiTasks route");
       Assert.IsFalse(string.IsNullOrEmpty(RouteConstants.ApiPullRequests), "Missing ApiPullRequests route");
       Assert.IsFalse(string.IsNullOrEmpty(RouteConstants.ApiLeaderboard), "Missing ApiLeaderboard route");
       Assert.IsFalse(string.IsNullOrEmpty(RouteConstants.ApiPaymentsCheckout), "Missing ApiPaymentsCheckout route");
       Assert.IsFalse(string.IsNullOrEmpty(RouteConstants.ApiPaymentsWebhook), "Missing ApiPaymentsWebhook route");
       Assert.IsFalse(string.IsNullOrEmpty(RouteConstants.ApiPaymentsStatus), "Missing ApiPaymentsStatus route");
       Assert.IsFalse(string.IsNullOrEmpty(RouteConstants.ApiAuthGitHub), "Missing ApiAuthGitHub route");
       Assert.IsFalse(string.IsNullOrEmpty(RouteConstants.ApiAuthCallback), "Missing ApiAuthCallback route");
       Assert.IsFalse(string.IsNullOrEmpty(RouteConstants.ApiAuthLogout), "Missing ApiAuthLogout route");
       Assert.IsFalse(string.IsNullOrEmpty(RouteConstants.ApiAuthMe), "Missing ApiAuthMe route");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("RouteConstants must define frontend routes for dashboard tasks leaderboard and legal pages")]
   public void TClaudeMd23RouteConstantsMustDefineFrontendRoutesForDashboardTasksLeaderboardAndLegalPages()
   {
       Assert.IsFalse(string.IsNullOrEmpty(RouteConstants.Dashboard), "Missing Dashboard route");
       Assert.IsFalse(string.IsNullOrEmpty(RouteConstants.Tasks), "Missing Tasks route");
       Assert.IsFalse(string.IsNullOrEmpty(RouteConstants.Login), "Missing Login route");
       Assert.IsFalse(string.IsNullOrEmpty(RouteConstants.Terms), "Missing Terms route");
       Assert.IsFalse(string.IsNullOrEmpty(RouteConstants.Privacy), "Missing Privacy route");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("BadgeConstants must define achievement badge types for developer gamification progression system")]
   public void TClaudeMd24BadgeConstantsMustDefineAchievementBadgeTypesForDeveloperGamificationProgressionSystem()
   {
       Assert.IsFalse(string.IsNullOrEmpty(BadgeConstants.FirstPrMerged), "Missing FirstPrMerged badge");
       Assert.IsFalse(string.IsNullOrEmpty(BadgeConstants.TenPrsMerged), "Missing TenPrsMerged badge");
       Assert.IsFalse(string.IsNullOrEmpty(BadgeConstants.ComplexityExpert), "Missing ComplexityExpert badge");
       Assert.IsFalse(string.IsNullOrEmpty(BadgeConstants.WeekStreak), "Missing WeekStreak badge");
       Assert.IsFalse(string.IsNullOrEmpty(BadgeConstants.TopTenLeaderboard), "Missing TopTenLeaderboard badge");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("AppConstants must define XP per complexity point and level thresholds for progression math")]
   public void TClaudeMd25AppConstantsMustDefineXpPerComplexityPointAndLevelThresholdsForProgressionMath()
   {
       var Content = File.ReadAllText(Path.Combine(SourceRoot, DomainProject, "Constants", "AppConstants.cs"));
       Assert.IsTrue(Content.Contains("XpPerComplexityPoint"), "AppConstants missing XpPerComplexityPoint");
       Assert.IsTrue(Content.Contains("MinBountyAmountCents"), "AppConstants missing MinBountyAmountCents");
       Assert.IsTrue(Content.Contains("PlatformFeePercent"), "AppConstants missing PlatformFeePercent");
       Assert.IsTrue(Content.Contains("StreakBonusMultiplier"), "AppConstants missing StreakBonusMultiplier");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("UserRole enum must define Developer Client and Admin roles for authorization enforcement")]
   public void TClaudeMd27UserRoleEnumMustDefineDeveloperClientAndAdminRolesForAuthorizationEnforcement()
   {
       var Names = Enum.GetNames<UserRole>();
       Assert.IsTrue(Names.Contains("Developer"), "Missing Developer role");
       Assert.IsTrue(Names.Contains("Client"), "Missing Client role");
       Assert.IsTrue(Names.Contains("Admin"), "Missing Admin role");
   }
   [TestMethod, TestCategory("Architecture")]
   [DisplayName("Directory build props must include all four required analyzer packages with PrivateAssets all")]
   public void TClaudeMd28DirectoryBuildPropsMustIncludeAllFourRequiredAnalyzerPackagesWithPrivateAssetsAll()
   {
       var Content = File.ReadAllText(Path.Combine(SolutionRoot, "Directory.Build.props"));
       var RequiredAnalyzers = new[] { "StyleCop.Analyzers", "Roslynator.Analyzers", "Meziantou.Analyzer", "SonarAnalyzer.CSharp" };
       var Missing = RequiredAnalyzers.Where(Analyzer => !Content.Contains(Analyzer)).ToList();
       Assert.AreEqual(0, Missing.Count, $"Missing analyzers: {string.Join(", ", Missing)}");
       foreach (var Analyzer in RequiredAnalyzers)
       {
           var AnalyzerIndex = Content.IndexOf(Analyzer, StringComparison.Ordinal);
           var NextHundredChars = Content[AnalyzerIndex..Math.Min(AnalyzerIndex + 200, Content.Length)];
           Assert.IsTrue(NextHundredChars.Contains("PrivateAssets=\"all\""), $"{Analyzer} must have PrivateAssets=\"all\"");
       }
   }
}

