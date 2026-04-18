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
    [DisplayName("MAUI project must reference SharedUI for shared component consumption on Android")]
    public void TClaudeMd07MauiProjectMustReferenceSharedUiForSharedComponentConsumptionOnAndroid()
    {
        var MauiProj = Path.Combine(SourceRoot, MauiProject, $"{MauiProject}.csproj");
        var Content = File.ReadAllText(MauiProj);
        Assert.IsTrue(Content.Contains("PrTask.SharedUI"), "MAUI must reference SharedUI");
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
    [DisplayName("MayaConstants must define webhook event types for checkout success failure and dropout handling")]
    public void TClaudeMd20MayaConstantsMustDefineWebhookEventTypesForCheckoutSuccessFailureAndDropoutHandling()
    {
        var Content = File.ReadAllText(Path.Combine(SourceRoot, DomainProject, "Constants", "MayaConstants.cs"));
        Assert.IsTrue(Content.Contains("checkout.success"), "MayaConstants missing checkout.success webhook event");
        Assert.IsTrue(Content.Contains("checkout.failure"), "MayaConstants missing checkout.failure webhook event");
        Assert.IsTrue(Content.Contains("checkout.dropout"), "MayaConstants missing checkout.dropout webhook event");
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
    [DisplayName("PrTaskStatus enum must define full task lifecycle from Open through Claimed to Completed")]
    public void TClaudeMd26PrTaskStatusEnumMustDefineFullTaskLifecycleFromOpenThroughClaimedToCompleted()
    {
        var Names = Enum.GetNames<PrTaskStatus>();
        Assert.IsTrue(Names.Contains("Open"), "Missing Open status");
        Assert.IsTrue(Names.Contains("Claimed"), "Missing Claimed status");
        Assert.IsTrue(Names.Contains("Completed"), "Missing Completed status");
        Assert.IsTrue(Names.Contains("Cancelled"), "Missing Cancelled status");
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
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Test projects must reference latest MSTest version four for modern testing framework support")]
    public void TClaudeMd29TestProjectsMustReferenceLatestMsTestVersionFourForModernTestingFrameworkSupport()
    {
        var TestProjects = GetAllProjectFiles()
            .Where(P => File.ReadAllText(P).Contains("<IsTestProject>true</IsTestProject>"));
        foreach (var ProjectFile in TestProjects)
        {
            var Content = File.ReadAllText(ProjectFile);
            Assert.IsTrue(Content.Contains("MSTest"), $"{Path.GetFileName(ProjectFile)} missing MSTest reference");
            Assert.IsTrue(MsTestVersionRegex().IsMatch(Content), $"{Path.GetFileName(ProjectFile)} must use MSTest v4.x");
        }
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("DiffSanitizationService must exist in infrastructure for private source public sanitized diffs")]
    public void TClaudeMd30DiffSanitizationServiceMustExistInInfrastructureForPrivateSourcePublicSanitizedDiffs()
    {
        var ServiceType = InfrastructureAssembly.GetTypes()
            .FirstOrDefault(T => T.Name == "DiffSanitizationService");
        Assert.IsNotNull(ServiceType, "DiffSanitizationService must exist for sanitized public diffs");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("ComplexityScoringService must exist in infrastructure for PR complexity payment scaling")]
    public void TClaudeMd31ComplexityScoringServiceMustExistInInfrastructureForPrComplexityPaymentScaling()
    {
        var ServiceType = InfrastructureAssembly.GetTypes()
            .FirstOrDefault(T => T.Name == "ComplexityScoringService");
        Assert.IsNotNull(ServiceType, "ComplexityScoringService must exist for payment scaling by PR complexity");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("LeaderboardService must exist in infrastructure for competitive developer ranking system")]
    public void TClaudeMd32LeaderboardServiceMustExistInInfrastructureForCompetitiveDeveloperRankingSystem()
    {
        var ServiceType = InfrastructureAssembly.GetTypes()
            .FirstOrDefault(T => T.Name == "LeaderboardService");
        Assert.IsNotNull(ServiceType, "LeaderboardService must exist for leaderboard feature");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("AchievementService must exist in infrastructure for badge and XP progression tracking")]
    public void TClaudeMd33AchievementServiceMustExistInInfrastructureForBadgeAndXpProgressionTracking()
    {
        var ServiceType = InfrastructureAssembly.GetTypes()
            .FirstOrDefault(T => T.Name == "AchievementService");
        Assert.IsNotNull(ServiceType, "AchievementService must exist for badges, XP, and levels");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("PaymentService must exist in infrastructure for Maya Business payment gateway integration")]
    public void TClaudeMd34PaymentServiceMustExistInInfrastructureForMayaBusinessPaymentGatewayIntegration()
    {
        var ServiceType = InfrastructureAssembly.GetTypes()
            .FirstOrDefault(T => T.Name == "PaymentService");
        Assert.IsNotNull(ServiceType, "PaymentService must exist for Maya payment integration");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("UserService must exist in infrastructure for SSO user creation and profile management")]
    public void TClaudeMd35UserServiceMustExistInInfrastructureForSsoUserCreationAndProfileManagement()
    {
        var ServiceType = InfrastructureAssembly.GetTypes()
            .FirstOrDefault(T => T.Name == "UserService");
        Assert.IsNotNull(ServiceType, "UserService must exist for SSO user management");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Application layer must define service interfaces for task and pull request operations")]
    public void TClaudeMd36ApplicationLayerMustDefineServiceInterfacesForTaskAndPullRequestOperations()
    {
        var InterfaceTypes = ApplicationAssembly.GetTypes().Where(T => T.IsInterface).ToList();
        Assert.IsTrue(InterfaceTypes.Any(T => T.Name == "ITaskService"), "Missing ITaskService interface");
        Assert.IsTrue(InterfaceTypes.Any(T => T.Name == "IPullRequestService"), "Missing IPullRequestService interface");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Application layer must define request and response contracts for payment checkout workflow")]
    public void TClaudeMd37ApplicationLayerMustDefineRequestAndResponseContractsForPaymentCheckoutWorkflow()
    {
        var Types = ApplicationAssembly.GetTypes();
        Assert.IsTrue(Types.Any(T => T.Name == "PaymentCheckoutRequest"), "Missing PaymentCheckoutRequest");
        Assert.IsTrue(Types.Any(T => T.Name == "PaymentCheckoutResponse"), "Missing PaymentCheckoutResponse");
        Assert.IsTrue(Types.Any(T => T.Name == "PaymentWebhookRequest"), "Missing PaymentWebhookRequest");
        Assert.IsTrue(Types.Any(T => T.Name == "PaymentStatusResponse"), "Missing PaymentStatusResponse");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("SassCompiler build tool must be referenced in SharedUI Server and Maui for SCSS compilation")]
    public void TClaudeMd38SassCompilerBuildToolMustBeReferencedInSharedUiServerAndMauiForScssCompilation()
    {
        var RequiredProjects = new[] { SharedUiProject, ServerProject, MauiProject };
        var Missing = new List<string>();
        foreach (var Project in RequiredProjects)
        {
            var Content = File.ReadAllText(Path.Combine(SourceRoot, Project, $"{Project}.csproj"));
            if (!Content.Contains("AspNetCore.SassCompiler"))
            {
                Missing.Add(Project);
            }
        }
        Assert.AreEqual(0, Missing.Count, $"SassCompiler missing in: {string.Join(", ", Missing)}");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Domain project must not reference any other project to maintain clean dependency direction")]
    public void TClaudeMd39DomainProjectMustNotReferenceAnyOtherProjectToMaintainCleanDependencyDirection()
    {
        var DomainProj = Path.Combine(SourceRoot, DomainProject, $"{DomainProject}.csproj");
        var Content = File.ReadAllText(DomainProj);
        Assert.IsFalse(Content.Contains("<ProjectReference"), "Domain must not reference other projects");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Application project must only reference Domain to maintain clean layered architecture boundaries")]
    public void TClaudeMd40ApplicationProjectMustOnlyReferenceDomainToMaintainCleanLayeredArchitectureBoundaries()
    {
        var AppProj = Path.Combine(SourceRoot, ApplicationProject, $"{ApplicationProject}.csproj");
        var Content = File.ReadAllText(AppProj);
        if (Content.Contains("<ProjectReference"))
        {
            Assert.IsTrue(Content.Contains("PrTask.Domain"), "Application may only reference Domain");
            var RefCount = ProjectReferenceRegex().Count(Content);
            Assert.AreEqual(1, RefCount, "Application must reference only Domain — no other projects");
        }
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Infrastructure project must reference Application and Domain but not Server or Client")]
    public void TClaudeMd41InfrastructureProjectMustReferenceApplicationAndDomainButNotServerOrClient()
    {
        var InfraProj = Path.Combine(SourceRoot, InfrastructureProject, $"{InfrastructureProject}.csproj");
        var Content = File.ReadAllText(InfraProj);
        Assert.IsTrue(Content.Contains("PrTask.Application") || Content.Contains("PrTask.Domain"), "Infrastructure must reference Application or Domain");
        Assert.IsFalse(Content.Contains("PrTask.Server"), "Infrastructure must not reference Server");
        Assert.IsFalse(Content.Contains("PrTask.Client"), "Infrastructure must not reference Client");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("All source files must use file scoped namespaces for consistent modern code style")]
    public void TClaudeMd42AllSourceFilesMustUseFileScopedNamespacesForConsistentModernCodeStyle()
    {
        var Violations = new List<string>();
        foreach (var FilePath in GetSourceFiles(".cs"))
        {
            var Content = File.ReadAllText(FilePath);
            if (Content.Contains("namespace ") && !FileScopedNamespaceRegex().IsMatch(Content) && BlockNamespaceRegex().IsMatch(Content))
            {
                Violations.Add(Path.GetFileName(FilePath));
            }
        }
        Assert.AreEqual(0, Violations.Count, $"Block-scoped namespaces in: {string.Join(", ", Violations.Take(10))}");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Solution must contain E2E test project for comprehensive test coverage")]
    public void TClaudeMd43SolutionMustContainE2ETestProjectForComprehensiveTestCoverage()
    {
        var ProjectFiles = GetAllProjectFiles().Select(Path.GetFileName).ToList();
        Assert.IsTrue(ProjectFiles.Contains("PrTask.E2E.csproj"), "Missing E2E test project");
        Assert.IsFalse(ProjectFiles.Contains("PrTask.Unit.csproj"), "Unit test project must not exist — E2E tests only");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("All test projects must have IsTestProject set to true for test runner discovery")]
    public void TClaudeMd44AllTestProjectsMustHaveIsTestProjectSetToTrueForTestRunnerDiscovery()
    {
        var TestProjectPaths = GetAllProjectFiles()
            .Where(P => Path.GetFileName(P).Contains("E2E"));
        foreach (var ProjectFile in TestProjectPaths)
        {
            var Content = File.ReadAllText(ProjectFile);
            Assert.IsTrue(Content.Contains("<IsTestProject>true</IsTestProject>"), $"{Path.GetFileName(ProjectFile)} missing IsTestProject=true");
        }
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("PullRequestEntity must track diff storage key for private source sanitized diff feature")]
    public void TClaudeMd45PullRequestEntityMustTrackDiffStorageKeyForPrivateSourceSanitizedDiffFeature()
    {
        var Properties = typeof(PullRequestEntity).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        Assert.IsTrue(Properties.Any(P => P.Name == "DiffStorageKey"), "PullRequestEntity missing DiffStorageKey for private diffs");
        Assert.IsTrue(Properties.Any(P => P.Name == "SubmittedAt"), "PullRequestEntity missing SubmittedAt timestamp");
        Assert.IsTrue(Properties.Any(P => P.Name == "MergedAt"), "PullRequestEntity missing MergedAt timestamp");
        Assert.IsTrue(Properties.Any(P => P.Name == "PaidAt"), "PullRequestEntity missing PaidAt timestamp");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("PaymentEntity must track payer payee and task associations for audit trail completeness")]
    public void TClaudeMd46PaymentEntityMustTrackPayerPayeeAndTaskAssociationsForAuditTrailCompleteness()
    {
        var Properties = typeof(PaymentEntity).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        Assert.IsTrue(Properties.Any(P => P.Name == "PayerId"), "PaymentEntity missing PayerId");
        Assert.IsTrue(Properties.Any(P => P.Name == "PayeeId"), "PaymentEntity missing PayeeId");
        Assert.IsTrue(Properties.Any(P => P.Name == "TaskId"), "PaymentEntity missing TaskId");
        Assert.IsTrue(Properties.Any(P => P.Name == "PullRequestId"), "PaymentEntity missing PullRequestId");
        Assert.IsTrue(Properties.Any(P => P.Name == "Type"), "PaymentEntity missing Type");
        Assert.IsTrue(Properties.Any(P => P.Name == "Status"), "PaymentEntity missing Status");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("UserEntity must have Maya customer identifier for payment gateway account linking")]
    public void TClaudeMd47UserEntityMustHaveMayaCustomerIdentifierForPaymentGatewayAccountLinking()
    {
        var Properties = typeof(UserEntity).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        Assert.IsTrue(Properties.Any(P => P.Name == "MayaCustomerId"), "UserEntity missing MayaCustomerId for Maya integration");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("TaskEntity must have deadline and tags properties for job posting feature completeness")]
    public void TClaudeMd48TaskEntityMustHaveDeadlineAndTagsPropertiesForJobPostingFeatureCompleteness()
    {
        var Properties = typeof(TaskEntity).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        Assert.IsTrue(Properties.Any(P => P.Name == "Deadline"), "TaskEntity missing Deadline");
        Assert.IsTrue(Properties.Any(P => P.Name == "Tags"), "TaskEntity missing Tags");
        Assert.IsTrue(Properties.Any(P => P.Name == "MaxClaims"), "TaskEntity missing MaxClaims");
        Assert.IsTrue(Properties.Any(P => P.Name == "PaymentId"), "TaskEntity missing PaymentId");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("GitHubUserResponse record must exist in application layer for OAuth profile deserialization")]
    public void TClaudeMd49GitHubUserResponseRecordMustExistInApplicationLayerForOAuthProfileDeserialization()
    {
        var Types = ApplicationAssembly.GetTypes();
        var ResponseType = Types.FirstOrDefault(T => T.Name == "GitHubUserResponse");
        Assert.IsNotNull(ResponseType, "GitHubUserResponse must exist for GitHub SSO");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("AppConstants must define maximum file line count matching architecture test enforcement value")]
    public void TClaudeMd50AppConstantsMustDefineMaximumFileLineCountMatchingArchitectureTestEnforcementValue()
    {
        var Content = File.ReadAllText(Path.Combine(SourceRoot, DomainProject, "Constants", "AppConstants.cs"));
        Assert.IsTrue(Content.Contains($"MaxFileLines = {MaxFileLines}"), "AppConstants.MaxFileLines must match architecture test MaxFileLines");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("GoogleConstants must define OAuth authorize token and user info URLs for Google SSO")]
    public void TClaudeMd51GoogleConstantsMustDefineOAuthAuthorizeTokenAndUserInfoUrlsForGoogleSso()
    {
        var Content = File.ReadAllText(Path.Combine(SourceRoot, DomainProject, "Constants", "GoogleConstants.cs"));
        Assert.IsTrue(Content.Contains("accounts.google.com"), "GoogleConstants missing authorize URL");
        Assert.IsTrue(Content.Contains("googleapis.com"), "GoogleConstants missing token or userinfo URL");
        Assert.IsTrue(Content.Contains("RequiredScope"), "GoogleConstants missing RequiredScope");
        Assert.IsTrue(Content.Contains("S256"), "GoogleConstants missing PKCE code challenge method");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("AzureConstants must define OAuth authorize token and graph API URLs for Azure SSO")]
    public void TClaudeMd52AzureConstantsMustDefineOAuthAuthorizeTokenAndGraphApiUrlsForAzureSso()
    {
        var Content = File.ReadAllText(Path.Combine(SourceRoot, DomainProject, "Constants", "AzureConstants.cs"));
        Assert.IsTrue(Content.Contains("login.microsoftonline.com"), "AzureConstants missing authorize URL");
        Assert.IsTrue(Content.Contains("graph.microsoft.com"), "AzureConstants missing Graph API URL");
        Assert.IsTrue(Content.Contains("RequiredScope"), "AzureConstants missing RequiredScope");
        Assert.IsTrue(Content.Contains("S256"), "AzureConstants missing PKCE code challenge method");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("OktaConstants must define OAuth authorize token and user info path templates for Okta SSO")]
    public void TClaudeMd53OktaConstantsMustDefineOAuthAuthorizeTokenAndUserInfoPathTemplatesForOktaSso()
    {
        var Content = File.ReadAllText(Path.Combine(SourceRoot, DomainProject, "Constants", "OktaConstants.cs"));
        Assert.IsTrue(Content.Contains("authorize"), "OktaConstants missing authorize path");
        Assert.IsTrue(Content.Contains("token"), "OktaConstants missing token path");
        Assert.IsTrue(Content.Contains("userinfo"), "OktaConstants missing userinfo path");
        Assert.IsTrue(Content.Contains("S256"), "OktaConstants missing PKCE code challenge method");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("RouteConstants must define auth endpoints for all four SSO providers Google Azure Okta GitHub")]
    public void TClaudeMd54RouteConstantsMustDefineAuthEndpointsForAllFourSsoProvidersGoogleAzureOktaGitHub()
    {
        Assert.IsFalse(string.IsNullOrEmpty(RouteConstants.ApiAuthGitHub), "Missing GitHub auth route");
        Assert.IsFalse(string.IsNullOrEmpty(RouteConstants.ApiAuthGoogle), "Missing Google auth route");
        Assert.IsFalse(string.IsNullOrEmpty(RouteConstants.ApiAuthAzure), "Missing Azure auth route");
        Assert.IsFalse(string.IsNullOrEmpty(RouteConstants.ApiAuthOkta), "Missing Okta auth route");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("RouteConstants must define callback endpoints for all four SSO provider OAuth flows")]
    public void TClaudeMd55RouteConstantsMustDefineCallbackEndpointsForAllFourSsoProviderOAuthFlows()
    {
        Assert.IsFalse(string.IsNullOrEmpty(RouteConstants.ApiAuthCallback), "Missing GitHub callback route");
        Assert.IsFalse(string.IsNullOrEmpty(RouteConstants.ApiAuthCallbackGoogle), "Missing Google callback route");
        Assert.IsFalse(string.IsNullOrEmpty(RouteConstants.ApiAuthCallbackAzure), "Missing Azure callback route");
        Assert.IsFalse(string.IsNullOrEmpty(RouteConstants.ApiAuthCallbackOkta), "Missing Okta callback route");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("IUserService must define OIDC method for creating users from Google Azure and Okta providers")]
    public void TClaudeMd56IUserServiceMustDefineOidcMethodForCreatingUsersFromGoogleAzureAndOktaProviders()
    {
        var InterfaceType = ApplicationAssembly.GetTypes().FirstOrDefault(T => T.Name == "IUserService");
        Assert.IsNotNull(InterfaceType, "IUserService interface must exist");
        var Methods = InterfaceType.GetMethods();
        Assert.IsTrue(Methods.Any(M => M.Name == "CreateOrUpdateFromOidcAsync"), "IUserService missing CreateOrUpdateFromOidcAsync");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("OidcUserResponse record must exist in application layer for OIDC provider profile deserialization")]
    public void TClaudeMd57OidcUserResponseRecordMustExistInApplicationLayerForOidcProviderProfileDeserialization()
    {
        var Types = ApplicationAssembly.GetTypes();
        var ResponseType = Types.FirstOrDefault(T => T.Name == "OidcUserResponse");
        Assert.IsNotNull(ResponseType, "OidcUserResponse must exist for Google/Azure/Okta SSO");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("SharedUI must contain Home TaskList Leaderboard Dashboard and Login Razor page components")]
    public void TClaudeMd58SharedUiMustContainHomeTaskListLeaderboardDashboardAndLoginRazorPageComponents()
    {
        var PagesDir = Path.Combine(SourceRoot, SharedUiProject, "Pages");
        var RequiredPages = new[] { "Home.razor", "TaskList.razor", "LeaderboardPage.razor", "DashboardPage.razor", "LoginPage.razor" };
        var Missing = RequiredPages.Where(Page => !File.Exists(Path.Combine(PagesDir, Page))).ToList();
        Assert.AreEqual(0, Missing.Count, $"Missing pages: {string.Join(", ", Missing)}");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("SharedUI must contain Terms Privacy Refund AcceptableUse and CookiePolicy legal pages")]
    public void TClaudeMd59SharedUiMustContainTermsPrivacyRefundAcceptableUseAndCookiePolicyLegalPages()
    {
        var LegalDir = Path.Combine(SourceRoot, SharedUiProject, "Pages", "Legal");
        var RequiredPages = new[] { "TermsPage.razor", "PrivacyPage.razor", "RefundPage.razor", "AcceptableUsePage.razor", "CookiePolicyPage.razor" };
        var Missing = RequiredPages.Where(Page => !File.Exists(Path.Combine(LegalDir, Page))).ToList();
        Assert.AreEqual(0, Missing.Count, $"Missing legal pages: {string.Join(", ", Missing)}");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("SharedUI must contain NavMenu FooterSection MainLayout and App shared component files")]
    public void TClaudeMd60SharedUiMustContainNavMenuFooterSectionMainLayoutAndAppSharedComponentFiles()
    {
        var ComponentsDir = Path.Combine(SourceRoot, SharedUiProject, "Components");
        var Required = new[] { "NavMenu.razor", "FooterSection.razor", "MainLayout.razor", "App.razor", "Routes.razor" };
        var Missing = Required.Where(File => !System.IO.File.Exists(Path.Combine(ComponentsDir, File))).ToList();
        Assert.AreEqual(0, Missing.Count, $"Missing components: {string.Join(", ", Missing)}");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("SharedUI must contain client CreateTaskPage for job posting with bounty workflow")]
    public void TClaudeMd61SharedUiMustContainClientCreateTaskPageForJobPostingWithBountyWorkflow()
    {
        var ClientDir = Path.Combine(SourceRoot, SharedUiProject, "Pages", "Client");
        Assert.IsTrue(File.Exists(Path.Combine(ClientDir, "CreateTaskPage.razor")), "Missing Client/CreateTaskPage.razor");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("SharedUI must contain ProfilePage and TaskDetailPage for user and task detail views")]
    public void TClaudeMd62SharedUiMustContainProfilePageAndTaskDetailPageForUserAndTaskDetailViews()
    {
        var PagesDir = Path.Combine(SourceRoot, SharedUiProject, "Pages");
        Assert.IsTrue(File.Exists(Path.Combine(PagesDir, "ProfilePage.razor")), "Missing ProfilePage.razor");
        Assert.IsTrue(File.Exists(Path.Combine(PagesDir, "TaskDetailPage.razor")), "Missing TaskDetailPage.razor");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("SharedUI Imports razor must reference AspNetCore Components namespaces for Blazor support")]
    public void TClaudeMd63SharedUiImportsRazorMustReferenceAspNetCoreComponentsNamespacesForBlazorSupport()
    {
        var ImportsPath = Path.Combine(SourceRoot, SharedUiProject, "_Imports.razor");
        Assert.IsTrue(File.Exists(ImportsPath), "_Imports.razor not found in SharedUI");
        var Content = File.ReadAllText(ImportsPath);
        Assert.IsTrue(Content.Contains("Microsoft.AspNetCore.Components"), "_Imports.razor missing Components namespace");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Solution file must reference all required project files for complete build graph")]
    public void TClaudeMd64SolutionFileMustReferenceAllRequiredProjectFilesForCompleteBuildGraph()
    {
        var SlnFiles = Directory.GetFiles(SolutionRoot, "*.sln");
        Assert.IsTrue(SlnFiles.Length > 0, "No .sln file found in solution root");
        var SlnContent = File.ReadAllText(SlnFiles[0]);
        var RequiredProjects = new[] { DomainProject, ApplicationProject, InfrastructureProject, ServerProject, SharedUiProject, ClientProject, MauiProject, E2EProject };
        var Missing = RequiredProjects.Where(P => !SlnContent.Contains(P)).ToList();
        Assert.AreEqual(0, Missing.Count, $"Solution missing projects: {string.Join(", ", Missing)}");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Editor config must suppress StyleCop SA1312 SA1313 SA1306 for PascalCase local naming convention")]
    public void TClaudeMd65EditorConfigMustSuppressStyleCopSa1312Sa1313Sa1306ForPascalCaseLocalNamingConvention()
    {
        var Content = File.ReadAllText(Path.Combine(SolutionRoot, ".editorconfig"));
        Assert.IsTrue(Content.Contains("SA1312"), ".editorconfig missing SA1312 suppression for PascalCase locals");
        Assert.IsTrue(Content.Contains("SA1313"), ".editorconfig missing SA1313 suppression for PascalCase params");
        Assert.IsTrue(Content.Contains("SA1306"), ".editorconfig missing SA1306 suppression for PascalCase fields");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Directory build props must generate documentation file for XML doc analysis support")]
    public void TClaudeMd66DirectoryBuildPropsMustGenerateDocumentationFileForXmlDocAnalysisSupport()
    {
        var Content = File.ReadAllText(Path.Combine(SolutionRoot, "Directory.Build.props"));
        Assert.IsTrue(Content.Contains("<GenerateDocumentationFile>true</GenerateDocumentationFile>"), "Missing GenerateDocumentationFile");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Directory build props must set analysis mode to AllEnabledByDefault for maximum coverage")]
    public void TClaudeMd67DirectoryBuildPropsMustSetAnalysisModeToAllEnabledByDefaultForMaximumCoverage()
    {
        var Content = File.ReadAllText(Path.Combine(SolutionRoot, "Directory.Build.props"));
        Assert.IsTrue(Content.Contains("<AnalysisMode>AllEnabledByDefault</AnalysisMode>"), "Missing AnalysisMode AllEnabledByDefault");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("All Razor page files must contain page directive with route for navigation routing")]
    public void TClaudeMd68AllRazorPageFilesMustContainPageDirectiveWithRouteForNavigationRouting()
    {
        var PagesDir = Path.Combine(SourceRoot, SharedUiProject, "Pages");
        var RazorPages = Directory.EnumerateFiles(PagesDir, "*.razor", SearchOption.AllDirectories).ToList();
        var Missing = new List<string>();
        foreach (var Page in RazorPages)
        {
            var Content = File.ReadAllText(Page);
            if (!Content.Contains("@page"))
            {
                Missing.Add(Path.GetFileName(Page));
            }
        }
        Assert.AreEqual(0, Missing.Count, $"Pages without @page directive: {string.Join(", ", Missing)}");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Domain constants directory must contain all required constant files for application configuration")]
    public void TClaudeMd69DomainConstantsDirectoryMustContainAllRequiredConstantFilesForApplicationConfiguration()
    {
        var ConstantsDir = Path.Combine(SourceRoot, DomainProject, "Constants");
        var Required = new[] { "AppConstants.cs", "RouteConstants.cs", "MayaConstants.cs", "GitHubConstants.cs", "BadgeConstants.cs", "GoogleConstants.cs", "AzureConstants.cs", "OktaConstants.cs" };
        var Missing = Required.Where(File => !System.IO.File.Exists(Path.Combine(ConstantsDir, File))).ToList();
        Assert.AreEqual(0, Missing.Count, $"Missing constant files: {string.Join(", ", Missing)}");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Domain models directory must contain all required entity and enum files for data modeling")]
    public void TClaudeMd70DomainModelsDirectoryMustContainAllRequiredEntityAndEnumFilesForDataModeling()
    {
        var ModelsDir = Path.Combine(SourceRoot, DomainProject, "Models");
        var Required = new[] { "UserEntity.cs", "TaskEntity.cs", "PullRequestEntity.cs", "PaymentEntity.cs", "LeaderboardEntry.cs", "AchievementEntity.cs" };
        var Missing = Required.Where(File => !System.IO.File.Exists(Path.Combine(ModelsDir, File))).ToList();
        Assert.AreEqual(0, Missing.Count, $"Missing model files: {string.Join(", ", Missing)}");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Infrastructure services directory must contain all eight required service implementation files")]
    public void TClaudeMd71InfrastructureServicesDirectoryMustContainAllEightRequiredServiceImplementationFiles()
    {
        var ServicesDir = Path.Combine(SourceRoot, InfrastructureProject, "Services");
        var Required = new[] { "TaskService.cs", "PullRequestService.cs", "UserService.cs", "PaymentService.cs", "LeaderboardService.cs", "AchievementService.cs", "ComplexityScoringService.cs", "DiffSanitizationService.cs" };
        var Missing = Required.Where(File => !System.IO.File.Exists(Path.Combine(ServicesDir, File))).ToList();
        Assert.AreEqual(0, Missing.Count, $"Missing service files: {string.Join(", ", Missing)}");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("SharedUI SCSS styles directory must contain app scss and variables scss for theming")]
    public void TClaudeMd72SharedUiScssStylesDirectoryMustContainAppScssAndVariablesScssForTheming()
    {
        var StylesDir = Path.Combine(SourceRoot, SharedUiProject, "Styles");
        Assert.IsTrue(File.Exists(Path.Combine(StylesDir, "app.scss")), "Missing Styles/app.scss");
        Assert.IsTrue(File.Exists(Path.Combine(StylesDir, "_variables.scss")), "Missing Styles/_variables.scss");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("SCSS variables must use prefers-color-scheme media query for OS current color scheme detection")]
    public void TClaudeMdB2ScssVariablesMustUsePrefersColorSchemeMediaQueryForOsCurrentColorSchemeDetection()
    {
        var VariablesScss = Path.Combine(SourceRoot, SharedUiProject, "Styles", "_variables.scss");
        var Content = File.ReadAllText(VariablesScss);
        Assert.IsTrue(Content.Contains("prefers-color-scheme"), "_variables.scss must use prefers-color-scheme media query");
        Assert.IsTrue(Content.Contains("dark"), "_variables.scss must define dark mode variables");
        Assert.IsTrue(Content.Contains(":root"), "_variables.scss must use CSS custom properties via :root");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("SCSS must use plain SCSS only with no CSS framework imports and sasscompiler must output compressed")]
    public void TClaudeMdB3ScssMustUsePlainScssOnlyWithNoCssFrameworkImportsAndSasscompilerMustOutputCompressed()
    {
        var AppScss = Path.Combine(SourceRoot, SharedUiProject, "Styles", "app.scss");
        var Content = File.ReadAllText(AppScss);
        Assert.IsFalse(Content.Contains("bootstrap"), "SCSS must not import Bootstrap — plain SCSS only");
        Assert.IsFalse(Content.Contains("tailwind"), "SCSS must not import Tailwind — plain SCSS only");
        Assert.IsFalse(Content.Contains("bulma"), "SCSS must not import Bulma — plain SCSS only");
        var SassConfig = File.ReadAllText(Path.Combine(SourceRoot, SharedUiProject, "sasscompiler.json"));
        Assert.IsTrue(SassConfig.Contains("compressed"), "sasscompiler.json must output compressed (minified) CSS");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("SCSS layouts must use flexbox display flex for responsive component arrangement")]
    public void TClaudeMdB4ScssLayoutsMustUseFlexboxDisplayFlexForResponsiveComponentArrangement()
    {
        var AppScss = Path.Combine(SourceRoot, SharedUiProject, "Styles", "app.scss");
        var Content = File.ReadAllText(AppScss);
        Assert.IsTrue(Content.Contains("display: flex"), "app.scss must use flexbox (display: flex)");
        Assert.IsTrue(Content.Contains("flex-wrap"), "app.scss must use flex-wrap for responsive layouts");
        Assert.IsTrue(Content.Contains("flex-direction"), "app.scss must use flex-direction for layout control");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("SCSS must not use any overflow properties that block mobile vertical scrolling")]
    public void TClaudeMdB5ScssMustUseMaxWidthAndNoOverflowForMobileScrollSupport()
    {
        var AppScss = Path.Combine(SourceRoot, SharedUiProject, "Styles", "app.scss");
        var Content = File.ReadAllText(AppScss);
        Assert.IsTrue(Content.Contains("#app") && Content.Contains("max-width: 100vw"), "app.scss must use max-width: 100vw on #app to prevent horizontal overflow");
        Assert.IsTrue(Content.Contains("#app") && Content.Contains("min-height: 100dvh"), "app.scss must use min-height: 100dvh on #app — dvh accounts for mobile browser chrome");
        Assert.IsTrue(Content.Contains("#app") && Content.Contains("display: flex") && Content.Contains("flex-direction: column"), "app.scss #app must be a flex column container for proper mobile layout");
        Assert.IsFalse(Content.Contains("overflow-x") || Content.Contains("overflow-y") || Content.Contains("overflow: hidden"), "app.scss must not use any overflow property — overflow clip/hidden forbid scrolling on mobile");
        Assert.IsFalse(Content.Contains("min-height: 100vh"), "app.scss must not use 100vh — use 100dvh for mobile browser chrome support");
        Assert.IsTrue(Content.Contains("max-width: 768px"), "app.scss must have mobile breakpoint media query");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Server project must have UserSecretsId for dotnet native secret management")]
    public void TClaudeMdB6ServerProjectMustHaveUserSecretsIdForDotnetNativeSecretManagement()
    {
        var ServerProj = Path.Combine(SourceRoot, ServerProject, $"{ServerProject}.csproj");
        var Content = File.ReadAllText(ServerProj);
        Assert.IsTrue(Content.Contains("<UserSecretsId>"), "Server project must have UserSecretsId for dotnet user-secrets");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("RULES md must require dotnet ten native secret handling and never store secrets in source")]
    public void TClaudeMdB7RulesMdMustRequireDotnetTenNativeSecretHandlingAndNeverStoreSecretsInSource()
    {
        var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
        Assert.IsTrue(Content.Contains("dotnet 10 native secret handling"), "RULES.md must reference dotnet 10 native secret handling");
        Assert.IsTrue(Content.Contains("never store secrets in source"), "RULES.md must prohibit secrets in source");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("RULES md must require night mode with prefers-color-scheme detection for OS color scheme")]
    public void TClaudeMdB8RulesMdMustRequireNightModeWithPrefersColorSchemeDetectionForOsColorScheme()
    {
        var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
        Assert.IsTrue(Content.Contains("Night mode"), "RULES.md must reference night mode support");
        Assert.IsTrue(Content.Contains("prefers-color-scheme"), "RULES.md must reference prefers-color-scheme detection");
        Assert.IsTrue(Content.Contains("OS current color scheme"), "RULES.md must default to OS current color scheme");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("RULES md must require plain SCSS only with minified CSS and flexbox layouts")]
    public void TClaudeMdB9RulesMdMustRequirePlainScssOnlyWithMinifiedCssAndFlexboxLayouts()
    {
        var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
        Assert.IsTrue(Content.Contains("Plain SCSS only"), "RULES.md must specify plain SCSS only");
        Assert.IsTrue(Content.Contains("minified"), "RULES.md must require minified CSS output");
        Assert.IsTrue(Content.Contains("flexbox"), "RULES.md must require SCSS flexbox layouts");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("RULES md must require no horizontal scrolling past 100 percent width")]
    public void TClaudeMdC0RulesMdMustRequireNoHorizontalScrollingPast100PercentWidth()
    {
        var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
        Assert.IsTrue(Content.Contains("max-width: 100vw"), "RULES.md must specify max-width: 100vw to prevent horizontal overflow");
        Assert.IsTrue(Content.Contains("min-height: 100dvh"), "RULES.md must specify 100dvh for mobile viewport");
        Assert.IsTrue(Content.Contains("word-break"), "RULES.md must specify word-break for preventing horizontal overflow");
        Assert.IsTrue(Content.Contains("Never use any overflow property"), "RULES.md must prohibit all overflow properties");
        Assert.IsTrue(Content.Contains("Vertical scrolling", StringComparison.OrdinalIgnoreCase), "RULES.md must state vertical scrolling must work");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("RULES md must require Google SSO to be functional for login authentication")]
    public void TClaudeMdC1RulesMdMustRequireGoogleSsoToBeFunctionalForLoginAuthentication()
    {
        var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
        Assert.IsTrue(Content.Contains("Google SSO must be functional"), "RULES.md must require Google SSO to be functional for login");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Terraform tfvars file must not exist in source control to prevent secret leakage")]
    public void TClaudeMdC2TerraformTfvarsFileMustNotExistInSourceControlToPreventSecretLeakage()
    {
        var GitignorePath = Path.Combine(SolutionRoot, ".gitignore");
        if (File.Exists(GitignorePath))
        {
            var Content = File.ReadAllText(GitignorePath);
            Assert.IsTrue(Content.Contains("terraform.tfvars") || Content.Contains("*.tfvars"), ".gitignore must exclude terraform.tfvars to prevent secret leakage");
        }
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("RULES md must specify free platform with no charges to clients or developers")]
    public void TClaudeMdC3RulesMdMustSpecifyFreePlatformWithNoChargesToClientsOrDevelopers()
    {
        var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
        Assert.IsTrue(Content.Contains("Free platform"), "RULES.md must specify free platform");
        Assert.IsTrue(Content.Contains("charges nothing"), "RULES.md must state PrTask charges nothing");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("AppConstants PlatformFeePercent must be zero since PrTask is a free platform")]
    public void TClaudeMdC4AppConstantsPlatformFeePercentMustBeZeroSincePrTaskIsAFreePlatform()
    {
        var Content = File.ReadAllText(Path.Combine(SourceRoot, DomainProject, "Constants", "AppConstants.cs"));
        Assert.IsTrue(Content.Contains("PlatformFeePercent = 0"), "PlatformFeePercent must be 0 — PrTask is a free platform");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("RULES md must specify developers choose their preferred payout method for flexible payouts")]
    public void TClaudeMdC5RulesMdMustSpecifyDevelopersChooseTheirPreferredPayoutMethodForFlexiblePayouts()
    {
        var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
        Assert.IsTrue(Content.Contains("payout method"), "RULES.md must mention developer payout method choice");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("NavMenu must contain theme toggle button with JS interop for dark mode switching")]
    public void TClaudeMdC6NavMenuMustContainThemeToggleButtonWithJsInteropForDarkModeSwitching()
    {
        var NavMenuPath = Path.Combine(SourceRoot, SharedUiProject, "Components", "NavMenu.razor");
        var Content = File.ReadAllText(NavMenuPath);
        Assert.IsTrue(Content.Contains("theme-toggle"), "NavMenu must have theme-toggle button");
        Assert.IsTrue(Content.Contains("prtaskToggleTheme"), "NavMenu must call prtaskToggleTheme JS function");
        Assert.IsTrue(Content.Contains("prtaskGetTheme"), "NavMenu must call prtaskGetTheme JS function");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Client index HTML must have inline theme script with localStorage persistence for flash free dark mode")]
    public void TClaudeMdC7ClientIndexHtmlMustHaveInlineThemeScriptWithLocalStoragePersistenceForFlashFreeDarkMode()
    {
        var IndexPath = Path.Combine(SourceRoot, ClientProject, "wwwroot", "index.html");
        var Content = File.ReadAllText(IndexPath);
        Assert.IsTrue(Content.Contains("prtaskToggleTheme"), "index.html must define prtaskToggleTheme function");
        Assert.IsTrue(Content.Contains("prtaskGetTheme"), "index.html must define prtaskGetTheme function");
        Assert.IsTrue(Content.Contains("localStorage"), "index.html must use localStorage for theme persistence");
        Assert.IsTrue(Content.Contains("data-theme"), "index.html must use data-theme attribute");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Pricing page must show Free for both developer and client tiers with no fee references")]
    public void TClaudeMdC8PricingPageMustShowFreeForBothDeveloperAndClientTiersWithNoFeeReferences()
    {
        var PricingPath = Path.Combine(SourceRoot, SharedUiProject, "Pages", "PricingPage.razor");
        var Content = File.ReadAllText(PricingPath);
        Assert.IsTrue(Content.Contains("For Developers") && Content.Contains("Free"), "Developer tier must show Free");
        Assert.IsTrue(Content.Contains("For Clients") && Content.Contains("Free"), "Client tier must show Free");
        Assert.IsFalse(Content.Contains("10%"), "Pricing page must not reference 10% fee");
        Assert.IsFalse(Content.Contains("90%"), "Pricing page must not reference 90% payout");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Terms page must mention supported payment methods and automatic payment for compliance")]
    public void TClaudeMdC9TermsPageMustMentionSupportedPaymentMethodsAndAutomaticPaymentForCompliance()
    {
        var TermsPath = Path.Combine(SourceRoot, SharedUiProject, "Pages", "Legal", "TermsPage.razor");
        var Content = File.ReadAllText(TermsPath);
        Assert.IsTrue(Content.Contains("supported payment methods"), "Terms must mention supported payment methods");
        Assert.IsTrue(Content.Contains("automatically charged"), "Terms must mention automatic payment on PR approval");
        Assert.IsTrue(Content.Contains("USD"), "Terms must mention USD currency");
        Assert.IsTrue(Content.Contains("Public Pull Requests"), "Terms must mention public pull requests");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Gitignore must include wrangler directory to prevent Cloudflare account ID leakage")]
    public void TClaudeMdD0GitignoreMustIncludeWranglerDirectoryToPreventCloudflareAccountIdLeakage()
    {
        var Content = File.ReadAllText(Path.Combine(SolutionRoot, ".gitignore"));
        Assert.IsTrue(Content.Contains(".wrangler"), ".gitignore must exclude .wrangler/ directory");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("RULES md must have Learnings section documenting project specific lessons and patterns")]
    public void TClaudeMdD1RulesMdMustHaveLearningsSectionDocumentingProjectSpecificLessonsAndPatterns()
    {
        var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
        Assert.IsTrue(Content.Contains("## Learnings"), "RULES.md must have a Learnings section");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("All content pages must reference preferred payout method for generic developer payouts")]
    public void TClaudeMdD2AllContentPagesMustReferencePreferredPayoutMethodForGenericDeveloperPayouts()
    {
        var PricingPath = Path.Combine(SourceRoot, SharedUiProject, "Pages", "PricingPage.razor");
        var PricingContent = File.ReadAllText(PricingPath);
        Assert.IsTrue(PricingContent.Contains("preferred payout method"), "Pricing page must mention preferred payout method");
        var HowItWorksPath = Path.Combine(SourceRoot, SharedUiProject, "Pages", "HowItWorks.razor");
        var HowItWorksContent = File.ReadAllText(HowItWorksPath);
        Assert.IsTrue(HowItWorksContent.Contains("preferred payout method"), "HowItWorks page must mention preferred payout method");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("SCSS variables must use data-theme dark selector for manual theme override with mixin")]
    public void TClaudeMdD3ScssVariablesMustUseDataThemeDarkSelectorForManualThemeOverrideWithMixin()
    {
        var VariablesPath = Path.Combine(SourceRoot, SharedUiProject, "Styles", "_variables.scss");
        var Content = File.ReadAllText(VariablesPath);
        Assert.IsTrue(Content.Contains("[data-theme=\"dark\"]"), "SCSS must have data-theme dark selector for manual override");
        Assert.IsTrue(Content.Contains("@mixin dark-theme") || Content.Contains("@mixin dark_theme"), "SCSS must use mixin to avoid dark theme duplication");
        Assert.IsTrue(Content.Contains(":not([data-theme=\"light\"])"), "SCSS must use :not([data-theme=light]) to allow manual light override on dark OS");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("RULES md must specify theme switcher toggle in nav persisting to localStorage")]
    public void TClaudeMdD4RulesMdMustSpecifyThemeSwitcherToggleInNavPersistingToLocalStorage()
    {
        var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
        Assert.IsTrue(Content.Contains("theme switcher"), "RULES.md must mention theme switcher");
        Assert.IsTrue(Content.Contains("localStorage"), "RULES.md must mention localStorage persistence for theme");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("RULES md must specify supported payment providers for client bounty payments")]
    public void TClaudeMdD5RulesMdMustSpecifySupportedPaymentProvidersForClientBountyPayments()
    {
        var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
        Assert.IsTrue(Content.Contains("payment providers"), "RULES.md must mention supported payment providers");
        Assert.IsTrue(Content.Contains("bounties"), "RULES.md must reference bounties");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Client pricing page must also show Free and multiple payouts matching SharedUI pricing page")]
    public void TClaudeMdD6ClientPricingPageMustAlsoShowFreeAndMultiplePayoutsMatchingSharedUiPricingPage()
    {
        var ClientPricingPath = Path.Combine(SourceRoot, ClientProject, "Pages", "ClientPricingPage.razor");
        var Content = File.ReadAllText(ClientPricingPath);
        Assert.IsTrue(Content.Contains("Free"), "Client pricing page must show Free");
        Assert.IsFalse(Content.Contains("10% Fee"), "Client pricing page must not show 10% Fee");
        Assert.IsFalse(Content.Contains("90%"), "Client pricing page must not show 90% payout");
        Assert.IsTrue(Content.Contains("preferred payout method"), "Client pricing page must mention preferred payout method");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("RULES md must require Google auto login with prompt none for silent authentication when possible")]
    public void TClaudeMdD7RulesMdMustRequireGoogleAutoLoginWithPromptNoneForSilentAuthenticationWhenPossible()
    {
        var Content = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
        Assert.IsTrue(Content.Contains("auto-login"), "RULES.md must mention auto-login via Google");
        Assert.IsTrue(Content.Contains("prompt=none"), "RULES.md must mention prompt=none for silent auth");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Auth endpoints must support prompt none parameter for Google silent auto login flow")]
    public void TClaudeMdD8AuthEndpointsMustSupportPromptNoneParameterForGoogleSilentAutoLoginFlow()
    {
        var AuthPath = Path.Combine(SourceRoot, ServerProject, "Endpoints", "AuthEndpoints.cs");
        var Content = File.ReadAllText(AuthPath);
        Assert.IsTrue(Content.Contains("prompt=none"), "Auth endpoints must add prompt=none for Google auto-login");
        Assert.IsTrue(Content.Contains("auto_failed"), "Auth endpoints must handle auto-login failure gracefully");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Login page must show SSO provider buttons without auto redirect for pure WASM compatibility")]
    public void TClaudeMdD9LoginPageMustShowSsoProviderButtonsWithoutAutoRedirectForPureWasmCompatibility()
    {
        var LoginPath = Path.Combine(SourceRoot, SharedUiProject, "Pages", "LoginPage.razor");
        var Content = File.ReadAllText(LoginPath);
        Assert.IsTrue(Content.Contains("ApiAuthGoogle"), "Login page must have Google sign-in");
        Assert.IsTrue(Content.Contains("ApiAuthGitHub"), "Login page must have GitHub sign-in");
        Assert.IsFalse(Content.Contains("forceLoad"), "Login page must not use forceLoad which causes loading screen on WASM");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Pricing pages must not contain any percentage fee references like ten percent or ninety percent")]
    public void TClaudeMdE0PricingPagesMustNotContainAnyPercentageFeeReferencesLikeTenPercentOrNinetyPercent()
    {
        var SharedPricing = File.ReadAllText(Path.Combine(SourceRoot, SharedUiProject, "Pages", "PricingPage.razor"));
        var ClientPricing = File.ReadAllText(Path.Combine(SourceRoot, ClientProject, "Pages", "ClientPricingPage.razor"));
        Assert.IsFalse(SharedPricing.Contains("10%"), "SharedUI pricing must not have 10% fee");
        Assert.IsFalse(ClientPricing.Contains("10%"), "Client pricing must not have 10% fee");
        Assert.IsFalse(SharedPricing.Contains("90%"), "SharedUI pricing must not have 90% payout");
        Assert.IsFalse(ClientPricing.Contains("90%"), "Client pricing must not have 90% payout");
        Assert.IsTrue(SharedPricing.Contains("Free") && ClientPricing.Contains("Free"), "Both pricing pages must show Free");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("CSS must not block vertical scrolling on mobile by avoiding all overflow properties")]
    public void TClaudeMdF2CssMustNotUseAnyOverflowPropertyAndSupportMobilePortraitScrolling()
    {
        var AppScss = Path.Combine(SourceRoot, SharedUiProject, "Styles", "app.scss");
        var Content = File.ReadAllText(AppScss);
        Assert.IsTrue(Content.Contains("max-width: 100vw"), "Must use max-width: 100vw to constrain width without overflow property");
        Assert.IsTrue(Content.Contains("min-height: 100dvh"), "Must use 100dvh not 100vh — dvh accounts for mobile browser chrome");
        Assert.IsFalse(Content.Contains("min-height: 100vh"), "Must not use 100vh — causes scrolling issues on mobile Chrome");
        Assert.IsFalse(Content.Contains("overflow-x") || Content.Contains("overflow-y") || Content.Contains("overflow: hidden") || Content.Contains("overflow:hidden"), "Must not use any overflow property — all overflow values forbid or break mobile scrolling");
        Assert.IsTrue(Content.Contains("word-break"), "Must use word-break to prevent text from causing horizontal overflow");
    }
    [GeneratedRegex(@"PrivateAssets\s*=\s*""all""", RegexOptions.IgnoreCase)]
    private static partial Regex PrivateAssetsAllRegex();

    [GeneratedRegex(@"""MSTest""\s+Version=""4\.\*""")]
    private static partial Regex MsTestVersionRegex();
    [GeneratedRegex(@"<ProjectReference\s")]
    private static partial Regex ProjectReferenceRegex();
    [GeneratedRegex(@"^namespace\s+[\w.]+;", RegexOptions.Multiline)]
    private static partial Regex FileScopedNamespaceRegex();
    [GeneratedRegex(@"^namespace\s+[\w.]+\s*\{", RegexOptions.Multiline)]
    private static partial Regex BlockNamespaceRegex();
}
