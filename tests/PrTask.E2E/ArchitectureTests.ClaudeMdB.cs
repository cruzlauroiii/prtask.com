using System.Reflection;
using System.Text.RegularExpressions;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.E2E;
public partial class ArchitectureTests
{
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
}

