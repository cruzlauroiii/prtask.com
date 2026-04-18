namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Server program must register infrastructure services and razor components with interactive server")]
    public void ServerProgramMustRegisterInfrastructureServicesAndRazorComponentsWithInteractiveServer()
    {
        var Code = ReadSourceFile("PrTask.Server", "Program.cs");
        Assert.IsTrue(Code.Contains("AddInfrastructure()", StringComparison.Ordinal), "Server must call AddInfrastructure for DI registration");
        Assert.IsTrue(Code.Contains("AddRazorComponents()", StringComparison.Ordinal), "Server must add Razor components");
        Assert.IsTrue(Code.Contains("AddInteractiveServerComponents()", StringComparison.Ordinal), "Server must enable interactive server rendering");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Server program must configure cookie authentication with thirty day sliding expiration")]
    public void ServerProgramMustConfigureCookieAuthenticationWithThirtyDaySlidingExpiration()
    {
        var Code = ReadSourceFile("PrTask.Server", "Program.cs");
        Assert.IsTrue(Code.Contains("CookieAuthenticationDefaults.AuthenticationScheme", StringComparison.Ordinal), "Server must use cookie auth scheme");
        Assert.IsTrue(Code.Contains("TimeSpan.FromDays(30)", StringComparison.Ordinal), "Server must set 30-day cookie expiration");
        Assert.IsTrue(Code.Contains("SlidingExpiration = true", StringComparison.Ordinal), "Server must enable sliding expiration");
        Assert.IsTrue(Code.Contains("Cookie.HttpOnly = true", StringComparison.Ordinal), "Server must set HttpOnly cookie flag");
        Assert.IsTrue(Code.Contains("SameSite = SameSiteMode.Lax", StringComparison.Ordinal), "Server must set SameSite Lax");
        Assert.IsTrue(Code.Contains("SecurePolicy = CookieSecurePolicy.Always", StringComparison.Ordinal), "Server must set Secure cookie policy");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Server program must configure cors policy allowing prtask domain with credentials")]
    public void ServerProgramMustConfigureCorsPolicyAllowingPrtaskDomainWithCredentials()
    {
        var Code = ReadSourceFile("PrTask.Server", "Program.cs");
        Assert.IsTrue(Code.Contains("AllowClient", StringComparison.Ordinal), "Server must define AllowClient CORS policy");
        Assert.IsTrue(Code.Contains("AppConstants.AppDomain", StringComparison.Ordinal), "Server CORS must use AppDomain constant");
        Assert.IsTrue(Code.Contains("AllowAnyMethod()", StringComparison.Ordinal), "Server CORS must allow any method");
        Assert.IsTrue(Code.Contains("AllowAnyHeader()", StringComparison.Ordinal), "Server CORS must allow any header");
        Assert.IsTrue(Code.Contains("AllowCredentials()", StringComparison.Ordinal), "Server CORS must allow credentials");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Server program must map all five endpoint groups for auth tasks prs payments and leaderboard")]
    public void ServerProgramMustMapAllFiveEndpointGroupsForAuthTasksPrsPaymentsAndLeaderboard()
    {
        var Code = ReadSourceFile("PrTask.Server", "Program.cs");
        Assert.IsTrue(Code.Contains("MapAuthEndpoints", StringComparison.Ordinal), "Server must map auth endpoints");
        Assert.IsTrue(Code.Contains("MapTaskEndpoints", StringComparison.Ordinal), "Server must map task endpoints");
        Assert.IsTrue(Code.Contains("MapPullRequestEndpoints", StringComparison.Ordinal), "Server must map pull request endpoints");
        Assert.IsTrue(Code.Contains("MapPaymentEndpoints", StringComparison.Ordinal), "Server must map payment endpoints");
        Assert.IsTrue(Code.Contains("MapLeaderboardEndpoints", StringComparison.Ordinal), "Server must map leaderboard endpoints");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Server program must return 401 unauthorized instead of redirect for api auth failures")]
    public void ServerProgramMustReturn401UnauthorizedInsteadOfRedirectForApiAuthFailures()
    {
        var Code = ReadSourceFile("PrTask.Server", "Program.cs");
        Assert.IsTrue(Code.Contains("OnRedirectToLogin", StringComparison.Ordinal), "Server must intercept login redirects");
        Assert.IsTrue(Code.Contains("Status401Unauthorized", StringComparison.Ordinal), "Server must return 401 instead of redirect");
        Assert.IsTrue(Code.Contains("RouteConstants.Login", StringComparison.Ordinal), "Server must set LoginPath from RouteConstants");
        Assert.IsTrue(Code.Contains("RouteConstants.ApiAuthLogout", StringComparison.Ordinal), "Server must set LogoutPath from RouteConstants");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints must map github oauth with authorize url client id and redirect uri")]
    public void AuthEndpointsMustMapGithubOauthWithAuthorizeUrlClientIdAndRedirectUri()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("MapGitHubEndpoints", StringComparison.Ordinal), "AuthEndpoints must map GitHub OAuth endpoints");
        Assert.IsTrue(Code.Contains("GitHubConstants.AuthorizeUrl", StringComparison.Ordinal), "AuthEndpoints must use GitHub authorize URL constant");
        Assert.IsTrue(Code.Contains("GitHubConstants.RequiredScope", StringComparison.Ordinal), "AuthEndpoints must request required GitHub scopes");
        Assert.IsTrue(Code.Contains("GitHubConstants.TokenUrl", StringComparison.Ordinal), "AuthEndpoints must use GitHub token URL constant");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints must map oidc endpoints for google azure and okta with pkce s256")]
    public void AuthEndpointsMustMapOidcEndpointsForGoogleAzureAndOktaWithPkceS256()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("MapOidcEndpoint", StringComparison.Ordinal), "AuthEndpoints must map OIDC endpoints");
        Assert.IsTrue(Code.Contains("MapOidcCallback", StringComparison.Ordinal), "AuthEndpoints must map OIDC callbacks");
        Assert.IsTrue(Code.Contains("GeneratePkce()", StringComparison.Ordinal), "AuthEndpoints must generate PKCE challenge");
        Assert.IsTrue(Code.Contains("code_challenge_method=S256", StringComparison.Ordinal), "AuthEndpoints must use S256 challenge method");
        Assert.IsTrue(Code.Contains("code_verifier", StringComparison.Ordinal), "AuthEndpoints must send code_verifier in token exchange");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints must store pkce verifier in http only secure samesite lax cookie")]
    public void AuthEndpointsMustStorePkceVerifierInHttpOnlySecureSameSiteLaxCookie()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("pkce_", StringComparison.Ordinal), "AuthEndpoints must prefix PKCE cookie with pkce_");
        Assert.IsTrue(Code.Contains("PkceCookieOptions", StringComparison.Ordinal), "AuthEndpoints must use shared PKCE cookie options");
        Assert.IsTrue(Code.Contains("HttpOnly = true", StringComparison.Ordinal), "PKCE cookie must be HttpOnly");
        Assert.IsTrue(Code.Contains("Secure = true", StringComparison.Ordinal), "PKCE cookie must be Secure");
        Assert.IsTrue(Code.Contains("SameSite = SameSiteMode.Lax", StringComparison.Ordinal), "PKCE cookie must be SameSite Lax");
        Assert.IsTrue(Code.Contains("TimeSpan.FromMinutes(10)", StringComparison.Ordinal), "PKCE cookie must expire after 10 minutes");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints must support google auto login with prompt none parameter for silent auth")]
    public void AuthEndpointsMustSupportGoogleAutoLoginWithPromptNoneParameterForSilentAuth()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("prompt=none", StringComparison.Ordinal), "AuthEndpoints must support silent Google auth");
        Assert.IsTrue(Code.Contains("Auto == true", StringComparison.Ordinal), "AuthEndpoints must check Auto parameter");
        Assert.IsTrue(Code.Contains("auto_failed=true", StringComparison.Ordinal), "AuthEndpoints must handle silent auth failure gracefully");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints must sign in user with claims identity containing name and avatar url")]
    public void AuthEndpointsMustSignInUserWithClaimsIdentityContainingNameAndAvatarUrl()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("SignInUserAsync", StringComparison.Ordinal), "AuthEndpoints must have SignInUserAsync helper");
        Assert.IsTrue(Code.Contains("ClaimTypes.NameIdentifier", StringComparison.Ordinal), "AuthEndpoints must set NameIdentifier claim");
        Assert.IsTrue(Code.Contains("ClaimTypes.Name", StringComparison.Ordinal), "AuthEndpoints must set Name claim");
        Assert.IsTrue(Code.Contains("avatar_url", StringComparison.Ordinal), "AuthEndpoints must set avatar_url claim");
        Assert.IsTrue(Code.Contains("ClaimsIdentity", StringComparison.Ordinal), "AuthEndpoints must create ClaimsIdentity");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints must map post logout and get auth me routes with user info response")]
    public void AuthEndpointsMustMapPostLogoutAndGetAuthMeRoutesWithUserInfoResponse()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("MapPost(RouteConstants.ApiAuthLogout", StringComparison.Ordinal), "AuthEndpoints must map POST logout");
        Assert.IsTrue(Code.Contains("MapGet(RouteConstants.ApiAuthMe", StringComparison.Ordinal), "AuthEndpoints must map GET auth/me");
        Assert.IsTrue(Code.Contains("SignOutAsync", StringComparison.Ordinal), "Logout must call SignOutAsync");
        Assert.IsTrue(Code.Contains("Results.Unauthorized()", StringComparison.Ordinal), "Auth/me must return 401 for unauthenticated");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints must use snake case json serializer for github api response deserialization")]
    public void AuthEndpointsMustUseSnakeCaseJsonSerializerForGithubApiResponseDeserialization()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("SnakeCaseLower", StringComparison.Ordinal), "AuthEndpoints must use snake_case JSON naming");
        Assert.IsTrue(Code.Contains("GitHubJsonOptions", StringComparison.Ordinal), "AuthEndpoints must have GitHubJsonOptions field");
        Assert.IsTrue(Code.Contains("ReadFromJsonAsync<GitHubUserResponse>", StringComparison.Ordinal), "AuthEndpoints must deserialize GitHub user response");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Service registration must register all eight application services with scoped lifetime")]
    public void ServiceRegistrationMustRegisterAllEightApplicationServicesWithScopedLifetime()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "ServiceRegistration.cs");
        Assert.IsTrue(Code.Contains("AddScoped<IUserService, UserService>", StringComparison.Ordinal), "Must register UserService");
        Assert.IsTrue(Code.Contains("AddScoped<IComplexityScoringService, ComplexityScoringService>", StringComparison.Ordinal), "Must register ComplexityScoringService");
        Assert.IsTrue(Code.Contains("AddScoped<IDiffSanitizationService, DiffSanitizationService>", StringComparison.Ordinal), "Must register DiffSanitizationService");
        Assert.IsTrue(Code.Contains("AddScoped<IAchievementService, AchievementService>", StringComparison.Ordinal), "Must register AchievementService");
        Assert.IsTrue(Code.Contains("AddScoped<ITaskService, TaskService>", StringComparison.Ordinal), "Must register TaskService");
        Assert.IsTrue(Code.Contains("AddScoped<IPullRequestService, PullRequestService>", StringComparison.Ordinal), "Must register PullRequestService");
        Assert.IsTrue(Code.Contains("AddScoped<IPaymentService, PaymentService>", StringComparison.Ordinal), "Must register PaymentService");
        Assert.IsTrue(Code.Contains("AddScoped<ILeaderboardService, LeaderboardService>", StringComparison.Ordinal), "Must register LeaderboardService");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Service registration must configure named http clients for prtask and maya apis")]
    public void ServiceRegistrationMustConfigureNamedHttpClientsForPrtaskAndMayaApis()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "ServiceRegistration.cs");
        Assert.IsTrue(Code.Contains("AddHttpClient(AppConstants.AppName", StringComparison.Ordinal), "Must register named PrTask HttpClient");
        Assert.IsTrue(Code.Contains("AddHttpClient(\"Maya\"", StringComparison.Ordinal), "Must register named Maya HttpClient");
        Assert.IsTrue(Code.Contains("AppConstants.AppDomain", StringComparison.Ordinal), "PrTask client must use AppDomain for base address");
        Assert.IsTrue(Code.Contains("MayaConstants.SandboxBaseUrl", StringComparison.Ordinal), "Maya client must use sandbox base URL");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Complexity scoring service must define language difficulty weights for twenty two file extensions")]
    public void ComplexityScoringServiceMustDefineLanguageDifficultyWeightsForTwentyTwoFileExtensions()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "ComplexityScoringService.cs");
        Assert.IsTrue(Code.Contains("[\".cs\"] = 3", StringComparison.Ordinal), "C# must have weight 3");
        Assert.IsTrue(Code.Contains("[\".rs\"] = 4", StringComparison.Ordinal), "Rust must have weight 4");
        Assert.IsTrue(Code.Contains("[\".js\"] = 2", StringComparison.Ordinal), "JavaScript must have weight 2");
        Assert.IsTrue(Code.Contains("[\".sql\"] = 3", StringComparison.Ordinal), "SQL must have weight 3");
        Assert.IsTrue(Code.Contains("[\".tf\"] = 2", StringComparison.Ordinal), "Terraform must have weight 2");
        Assert.IsTrue(Code.Contains("[\".html\"] = 1", StringComparison.Ordinal), "HTML must have weight 1");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Complexity scoring service must calculate xp reward with streak bonus multiplier from app constants")]
    public void ComplexityScoringServiceMustCalculateXpRewardWithStreakBonusMultiplierFromAppConstants()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "ComplexityScoringService.cs");
        Assert.IsTrue(Code.Contains("AppConstants.XpPerComplexityPoint", StringComparison.Ordinal), "XP reward must use XpPerComplexityPoint constant");
        Assert.IsTrue(Code.Contains("AppConstants.StreakBonusMultiplier", StringComparison.Ordinal), "XP reward must use StreakBonusMultiplier constant");
        Assert.IsTrue(Code.Contains("StreakDays > 0", StringComparison.Ordinal), "XP reward must check for active streak");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Diff sanitization service must use generated regex for secret pattern and file extension matching")]
    public void DiffSanitizationServiceMustUseGeneratedRegexForSecretPatternAndFileExtensionMatching()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "DiffSanitizationService.cs");
        Assert.IsTrue(Code.Contains("GeneratedRegex", StringComparison.Ordinal), "DiffSanitizationService must use GeneratedRegex attribute");
        Assert.IsTrue(Code.Contains("SecretPattern()", StringComparison.Ordinal), "DiffSanitizationService must have SecretPattern generated regex");
        Assert.IsTrue(Code.Contains("FileExtensionPattern()", StringComparison.Ordinal), "DiffSanitizationService must have FileExtensionPattern generated regex");
        Assert.IsTrue(Code.Contains("[REDACTED]", StringComparison.Ordinal), "DiffSanitizationService must redact sensitive content");
        Assert.IsTrue(Code.Contains("password|secret|key|token", StringComparison.Ordinal), "Secret pattern must match common secret keywords");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Diff sanitization service must sanitize diff headers file paths and extract extensions")]
    public void DiffSanitizationServiceMustSanitizeDiffHeadersFilePathsAndExtractExtensions()
    {
        var Code = ReadSourceFile("PrTask.Infrastructure", "Services", "DiffSanitizationService.cs");
        Assert.IsTrue(Code.Contains("RedactFilePathInDiffHeader", StringComparison.Ordinal), "DiffSanitizationService must redact diff headers");
        Assert.IsTrue(Code.Contains("RedactFilePath", StringComparison.Ordinal), "DiffSanitizationService must redact file paths");
        Assert.IsTrue(Code.Contains("GetFileName", StringComparison.Ordinal), "DiffSanitizationService must extract filename from path");
        Assert.IsTrue(Code.Contains("diff --git", StringComparison.Ordinal), "DiffSanitizationService must detect diff headers");
        Assert.IsTrue(Code.Contains("partial class DiffSanitizationService", StringComparison.Ordinal), "DiffSanitizationService must be partial for GeneratedRegex");
    }
}
