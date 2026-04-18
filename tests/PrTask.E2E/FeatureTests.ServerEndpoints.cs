namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Server program must configure cookie auth with thirty day expiry and sliding expiration enabled")]
    public void ServerProgramMustConfigureCookieAuthWithThirtyDayExpiryAndSlidingExpirationEnabled()
    {
        var Code = ReadSourceFile("PrTask.Server", "Program.cs");
        Assert.IsTrue(Code.Contains("TimeSpan.FromDays(30)", StringComparison.Ordinal), "Server must set 30-day cookie expiry");
        Assert.IsTrue(Code.Contains("SlidingExpiration = true", StringComparison.Ordinal), "Server must enable sliding expiration");
        Assert.IsTrue(Code.Contains("Cookie.HttpOnly = true", StringComparison.Ordinal), "Server cookie must be HttpOnly");
        Assert.IsTrue(Code.Contains("CookieSecurePolicy.Always", StringComparison.Ordinal), "Server cookie must use Always secure policy");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Server program must configure cors allow client policy with app domain origin and credentials")]
    public void ServerProgramMustConfigureCorsAllowClientPolicyWithAppDomainOriginAndCredentials()
    {
        var Code = ReadSourceFile("PrTask.Server", "Program.cs");
        Assert.IsTrue(Code.Contains("\"AllowClient\"", StringComparison.Ordinal), "Server must define AllowClient CORS policy");
        Assert.IsTrue(Code.Contains("AppConstants.AppDomain", StringComparison.Ordinal), "Server CORS must use AppDomain for origin");
        Assert.IsTrue(Code.Contains("AllowCredentials()", StringComparison.Ordinal), "Server CORS must allow credentials");
        Assert.IsTrue(Code.Contains("AllowAnyHeader()", StringComparison.Ordinal), "Server CORS must allow any header");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Server program must redirect to login on unauthorized with four zero one status code override")]
    public void ServerProgramMustRedirectToLoginOnUnauthorizedWithFourZeroOneStatusCodeOverride()
    {
        var Code = ReadSourceFile("PrTask.Server", "Program.cs");
        Assert.IsTrue(Code.Contains("StatusCodes.Status401Unauthorized", StringComparison.Ordinal), "Server must return 401 instead of login redirect");
        Assert.IsTrue(Code.Contains("OnRedirectToLogin", StringComparison.Ordinal), "Server must override OnRedirectToLogin event");
        Assert.IsTrue(Code.Contains("RouteConstants.Login", StringComparison.Ordinal), "Server must set LoginPath to RouteConstants.Login");
        Assert.IsTrue(Code.Contains("SameSite = SameSiteMode.Lax", StringComparison.Ordinal), "Server cookie must use Lax same-site mode");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Server program must map all five endpoint groups and razor components with interactive server mode")]
    public void ServerProgramMustMapAllFiveEndpointGroupsAndRazorComponentsWithInteractiveServerMode()
    {
        var Code = ReadSourceFile("PrTask.Server", "Program.cs");
        Assert.IsTrue(Code.Contains("MapAuthEndpoints", StringComparison.Ordinal), "Server must map auth endpoints");
        Assert.IsTrue(Code.Contains("MapTaskEndpoints()", StringComparison.Ordinal), "Server must map task endpoints");
        Assert.IsTrue(Code.Contains("MapPullRequestEndpoints()", StringComparison.Ordinal), "Server must map PR endpoints");
        Assert.IsTrue(Code.Contains("MapPaymentEndpoints()", StringComparison.Ordinal), "Server must map payment endpoints");
        Assert.IsTrue(Code.Contains("MapLeaderboardEndpoints()", StringComparison.Ordinal), "Server must map leaderboard endpoints");
        Assert.IsTrue(Code.Contains("AddInteractiveServerRenderMode()", StringComparison.Ordinal), "Server must add interactive server render mode");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints must generate pkce verifier from thirty two random bytes with sha256 challenge hash")]
    public void AuthEndpointsMustGeneratePkceVerifierFromThirtyTwoRandomBytesWithSha256ChallengeHash()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("RandomNumberGenerator.GetBytes(32)", StringComparison.Ordinal), "Auth must generate 32 random bytes for PKCE verifier");
        Assert.IsTrue(Code.Contains("SHA256.HashData", StringComparison.Ordinal), "Auth must hash verifier with SHA256 for challenge");
        Assert.IsTrue(Code.Contains("Replace('+', '-')", StringComparison.Ordinal), "Auth must replace + with - for base64url encoding");
        Assert.IsTrue(Code.Contains("TrimEnd('=')", StringComparison.Ordinal), "Auth must trim padding for base64url encoding");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints must store pkce verifier in http only cookie with ten minute max age expiry")]
    public void AuthEndpointsMustStorePkceVerifierInHttpOnlyCookieWithTenMinuteMaxAgeExpiry()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("pkce_{Provider}", StringComparison.Ordinal), "Auth must name PKCE cookie with provider prefix");
        Assert.IsTrue(Code.Contains("TimeSpan.FromMinutes(10)", StringComparison.Ordinal), "PKCE cookie must expire after 10 minutes");
        Assert.IsTrue(Code.Contains("HttpOnly = true, Secure = true", StringComparison.Ordinal), "PKCE cookie must be HttpOnly and Secure");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints sign in must create claims principal with name identifier and name claim types")]
    public void AuthEndpointsMustCreateClaimsPrincipalWithNameIdentifierAndNameClaimTypes()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("ClaimTypes.NameIdentifier, UserId", StringComparison.Ordinal), "SignIn must add NameIdentifier claim");
        Assert.IsTrue(Code.Contains("ClaimTypes.Name, Username", StringComparison.Ordinal), "SignIn must add Name claim");
        Assert.IsTrue(Code.Contains("\"avatar_url\", AvatarUrl", StringComparison.Ordinal), "SignIn must add avatar_url custom claim");
        Assert.IsTrue(Code.Contains("ClaimsIdentity(Claims, CookieAuthenticationDefaults.AuthenticationScheme)", StringComparison.Ordinal), "SignIn must use cookie auth scheme for identity");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints github token exchange must use form url encoded content and accept json header")]
    public void AuthEndpointsGitHubTokenExchangeMustUseFormUrlEncodedContentAndAcceptJsonHeader()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("FormUrlEncodedContent", StringComparison.Ordinal), "GitHub token exchange must use FormUrlEncodedContent");
        Assert.IsTrue(Code.Contains("MediaTypeWithQualityHeaderValue(\"application/json\")", StringComparison.Ordinal), "GitHub must accept JSON response");
        Assert.IsTrue(Code.Contains("GitHubConstants.TokenUrl", StringComparison.Ordinal), "GitHub must use TokenUrl constant for exchange");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints oidc callback must exchange code with verifier and fetch user info with bearer token")]
    public void AuthEndpointsOidcCallbackMustExchangeCodeWithVerifierAndFetchUserInfoWithBearerToken()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("ExchangeOidcCodeAsync", StringComparison.Ordinal), "Auth must have ExchangeOidcCodeAsync method");
        Assert.IsTrue(Code.Contains("FetchOidcUserInfoAsync", StringComparison.Ordinal), "Auth must have FetchOidcUserInfoAsync method");
        Assert.IsTrue(Code.Contains("AuthenticationHeaderValue(\"Bearer\", AccessToken)", StringComparison.Ordinal), "Auth must send Bearer token for userinfo");
        Assert.IsTrue(Code.Contains("code_verifier", StringComparison.Ordinal), "Auth must send code_verifier in token exchange");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints me route must return user id username and avatar url from claims or unauthorized")]
    public void AuthEndpointsMeRouteMustReturnUserIdUsernameAndAvatarUrlFromClaimsOrUnauthorized()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("FindFirstValue(ClaimTypes.NameIdentifier)", StringComparison.Ordinal), "Auth me must extract UserId claim");
        Assert.IsTrue(Code.Contains("FindFirstValue(ClaimTypes.Name)", StringComparison.Ordinal), "Auth me must extract Username claim");
        Assert.IsTrue(Code.Contains("FindFirstValue(\"avatar_url\")", StringComparison.Ordinal), "Auth me must extract avatar_url claim");
        Assert.IsTrue(Code.Contains("Results.Unauthorized()", StringComparison.Ordinal), "Auth me must return unauthorized when not authenticated");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints github user fetch must use prtask user agent header and snake case json options")]
    public void AuthEndpointsGitHubUserFetchMustUsePrtaskUserAgentHeaderAndSnakeCaseJsonOptions()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("ProductInfoHeaderValue(AppConstants.AppName, \"1.0\")", StringComparison.Ordinal), "GitHub fetch must set PrTask user agent");
        Assert.IsTrue(Code.Contains("GitHubConstants.UserApiUrl", StringComparison.Ordinal), "GitHub fetch must use UserApiUrl constant");
        Assert.IsTrue(Code.Contains("JsonNamingPolicy.SnakeCaseLower", StringComparison.Ordinal), "GitHub must use SnakeCaseLower JSON naming policy");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task endpoints must map group on api tasks route with crud operations and claim action")]
    public void TaskEndpointsMustMapGroupOnApiTasksRouteWithCrudOperationsAndClaimAction()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "TaskEndpoints.cs");
        Assert.IsTrue(Code.Contains("Routes.MapGroup(RouteConstants.ApiTasks)", StringComparison.Ordinal), "Tasks must use MapGroup with ApiTasks route");
        Assert.IsTrue(Code.Contains("Service.ListOpenAsync()", StringComparison.Ordinal), "Tasks GET must call ListOpenAsync");
        Assert.IsTrue(Code.Contains("Results.Created($\"{RouteConstants.ApiTasks}/{Entity.Id}\"", StringComparison.Ordinal), "Tasks POST must return Created with location");
        Assert.IsTrue(Code.Contains("Results.NoContent()", StringComparison.Ordinal), "Tasks DELETE must return NoContent");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Task endpoints create update delete and claim must require authorization attribute for security")]
    public void TaskEndpointsCreateUpdateDeleteAndClaimMustRequireAuthorizationAttributeForSecurity()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "TaskEndpoints.cs");
        Assert.IsTrue(Code.Contains("RequireAuthorization()", StringComparison.Ordinal), "Task mutations must require authorization");
        Assert.IsTrue(Code.Contains("ClaimTaskRequest Request", StringComparison.Ordinal), "Tasks claim must accept ClaimTaskRequest");
        Assert.IsTrue(Code.Contains("Request.DeveloperId", StringComparison.Ordinal), "Tasks claim must use DeveloperId from request");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request endpoints must map developer and task sub routes with approve and reject actions")]
    public void PullRequestEndpointsMustMapDeveloperAndTaskSubRoutesWithApproveAndRejectActions()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "PullRequestEndpoints.cs");
        Assert.IsTrue(Code.Contains("Routes.MapGroup(RouteConstants.ApiPullRequests)", StringComparison.Ordinal), "PRs must use MapGroup with ApiPullRequests");
        Assert.IsTrue(Code.Contains("/developer/{DeveloperId}", StringComparison.Ordinal), "PRs must have developer sub route");
        Assert.IsTrue(Code.Contains("/task/{TaskId}", StringComparison.Ordinal), "PRs must have task sub route");
        Assert.IsTrue(Code.Contains("/{PullRequestId}/approve", StringComparison.Ordinal), "PRs must have approve action route");
        Assert.IsTrue(Code.Contains("/{PullRequestId}/reject", StringComparison.Ordinal), "PRs must have reject action route");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Payment endpoints must map checkout webhook and status routes with checkout requiring authorization")]
    public void PaymentEndpointsMustMapCheckoutWebhookAndStatusRoutesWithCheckoutRequiringAuthorization()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "PaymentEndpoints.cs");
        Assert.IsTrue(Code.Contains("RouteConstants.ApiPaymentsCheckout", StringComparison.Ordinal), "Payments must map checkout route");
        Assert.IsTrue(Code.Contains("RouteConstants.ApiPaymentsWebhook", StringComparison.Ordinal), "Payments must map webhook route");
        Assert.IsTrue(Code.Contains("RouteConstants.ApiPaymentsStatus", StringComparison.Ordinal), "Payments must map status route");
        Assert.IsTrue(Code.Contains("PaymentCheckoutResponse", StringComparison.Ordinal), "Payments checkout must return PaymentCheckoutResponse");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Leaderboard endpoints must accept optional count parameter with default hundred and rank by user id")]
    public void LeaderboardEndpointsMustAcceptOptionalCountParameterWithDefaultHundredAndRankByUserId()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "LeaderboardEndpoints.cs");
        Assert.IsTrue(Code.Contains("Count ?? 100", StringComparison.Ordinal), "Leaderboard must default count to 100");
        Assert.IsTrue(Code.Contains("LeaderboardRankResponse", StringComparison.Ordinal), "Leaderboard must return LeaderboardRankResponse");
        Assert.IsTrue(Code.Contains("RouteConstants.ApiLeaderboard", StringComparison.Ordinal), "Leaderboard must use ApiLeaderboard route constant");
    }
}
