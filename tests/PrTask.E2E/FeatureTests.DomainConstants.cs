namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("App constants must define prtask app name domain and cloudflare pages project identifier")]
    public void AppConstantsMustDefinePrtaskAppNameDomainAndCloudflarePagesProjectIdentifier()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "AppConstants.cs");
        Assert.IsTrue(Code.Contains("AppName = \"PrTask\"", StringComparison.Ordinal), "AppConstants must define AppName as PrTask");
        Assert.IsTrue(Code.Contains("AppDomain = \"prtask.com\"", StringComparison.Ordinal), "AppConstants must define AppDomain as prtask.com");
        Assert.IsTrue(Code.Contains("CloudflarePagesProject = \"prtask\"", StringComparison.Ordinal), "AppConstants must define CloudflarePagesProject");
        Assert.IsTrue(Code.Contains("CloudflareApiBase", StringComparison.Ordinal), "AppConstants must define CloudflareApiBase URL");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("App constants must define max file lines bounty minimum and zero platform fee percent")]
    public void AppConstantsMustDefineMaxFileLinesBountyMinimumAndZeroPlatformFeePercent()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "AppConstants.cs");
        Assert.IsTrue(Code.Contains("MaxFileLines = 300", StringComparison.Ordinal), "AppConstants must set MaxFileLines to 300");
        Assert.IsTrue(Code.Contains("MinBountyAmountCents = 10000", StringComparison.Ordinal), "AppConstants must set minimum bounty to 10000 cents");
        Assert.IsTrue(Code.Contains("PlatformFeePercent = 0", StringComparison.Ordinal), "AppConstants must set platform fee to zero");
        Assert.IsTrue(Code.Contains("MaxTaskTitleLength = 200", StringComparison.Ordinal), "AppConstants must limit task title length");
        Assert.IsTrue(Code.Contains("MaxTaskDescriptionLength = 10000", StringComparison.Ordinal), "AppConstants must limit task description length");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("App constants must define xp per complexity point streak bonus and level thresholds")]
    public void AppConstantsMustDefineXpPerComplexityPointStreakBonusAndLevelThresholds()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "AppConstants.cs");
        Assert.IsTrue(Code.Contains("XpPerComplexityPoint = 10", StringComparison.Ordinal), "AppConstants must set XP per complexity point to 10");
        Assert.IsTrue(Code.Contains("StreakBonusMultiplier = 2", StringComparison.Ordinal), "AppConstants must set streak bonus multiplier to 2");
        Assert.IsTrue(Code.Contains("Level1Threshold = 0", StringComparison.Ordinal), "AppConstants must set Level 1 threshold to 0");
        Assert.IsTrue(Code.Contains("Level2Threshold = 100", StringComparison.Ordinal), "AppConstants must set Level 2 threshold to 100");
        Assert.IsTrue(Code.Contains("Level5Threshold = 1000", StringComparison.Ordinal), "AppConstants must set Level 5 threshold to 1000");
        Assert.IsTrue(Code.Contains("Level10Threshold = 5000", StringComparison.Ordinal), "AppConstants must set Level 10 threshold to 5000");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Route constants must define home login dashboard tasks leaderboard and profile page routes")]
    public void RouteConstantsMustDefineHomeLoginDashboardTasksLeaderboardAndProfilePageRoutes()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Code.Contains("Home = \"/\"", StringComparison.Ordinal), "RouteConstants must define Home route");
        Assert.IsTrue(Code.Contains("Login = \"/login\"", StringComparison.Ordinal), "RouteConstants must define Login route");
        Assert.IsTrue(Code.Contains("Dashboard = \"/dashboard\"", StringComparison.Ordinal), "RouteConstants must define Dashboard route");
        Assert.IsTrue(Code.Contains("Tasks = \"/tasks\"", StringComparison.Ordinal), "RouteConstants must define Tasks route");
        Assert.IsTrue(Code.Contains("Leaderboard = \"/leaderboard\"", StringComparison.Ordinal), "RouteConstants must define Leaderboard route");
        Assert.IsTrue(Code.Contains("Profile = \"/profile/{0}\"", StringComparison.Ordinal), "RouteConstants must define Profile route with ID placeholder");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Route constants must define all eight legal page routes for compliance navigation")]
    public void RouteConstantsMustDefineAllEightLegalPageRoutesForComplianceNavigation()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Code.Contains("Terms = \"/legal/terms\"", StringComparison.Ordinal), "RouteConstants must define Terms route");
        Assert.IsTrue(Code.Contains("Privacy = \"/legal/privacy\"", StringComparison.Ordinal), "RouteConstants must define Privacy route");
        Assert.IsTrue(Code.Contains("Refund = \"/legal/refund\"", StringComparison.Ordinal), "RouteConstants must define Refund route");
        Assert.IsTrue(Code.Contains("AcceptableUse = \"/legal/acceptable-use\"", StringComparison.Ordinal), "RouteConstants must define AcceptableUse route");
        Assert.IsTrue(Code.Contains("CookiePolicy = \"/legal/cookie-policy\"", StringComparison.Ordinal), "RouteConstants must define CookiePolicy route");
        Assert.IsTrue(Code.Contains("Licenses = \"/legal/licenses\"", StringComparison.Ordinal), "RouteConstants must define Licenses route");
        Assert.IsTrue(Code.Contains("Accessibility = \"/legal/accessibility\"", StringComparison.Ordinal), "RouteConstants must define Accessibility route");
        Assert.IsTrue(Code.Contains("Dmca = \"/legal/dmca\"", StringComparison.Ordinal), "RouteConstants must define Dmca route");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Route constants must define api auth routes for all four sso providers and callbacks")]
    public void RouteConstantsMustDefineApiAuthRoutesForAllFourSsoProvidersAndCallbacks()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Code.Contains("ApiAuthGitHub = \"/api/auth/github\"", StringComparison.Ordinal), "RouteConstants must define GitHub auth route");
        Assert.IsTrue(Code.Contains("ApiAuthGoogle = \"/api/auth/google\"", StringComparison.Ordinal), "RouteConstants must define Google auth route");
        Assert.IsTrue(Code.Contains("ApiAuthAzure = \"/api/auth/azure\"", StringComparison.Ordinal), "RouteConstants must define Azure auth route");
        Assert.IsTrue(Code.Contains("ApiAuthOkta = \"/api/auth/okta\"", StringComparison.Ordinal), "RouteConstants must define Okta auth route");
        Assert.IsTrue(Code.Contains("ApiAuthCallbackGoogle = \"/api/auth/callback/google\"", StringComparison.Ordinal), "RouteConstants must define Google callback");
        Assert.IsTrue(Code.Contains("ApiAuthCallbackAzure = \"/api/auth/callback/azure\"", StringComparison.Ordinal), "RouteConstants must define Azure callback");
        Assert.IsTrue(Code.Contains("ApiAuthCallbackOkta = \"/api/auth/callback/okta\"", StringComparison.Ordinal), "RouteConstants must define Okta callback");
        Assert.IsTrue(Code.Contains("ApiAuthLogout = \"/api/auth/logout\"", StringComparison.Ordinal), "RouteConstants must define logout route");
        Assert.IsTrue(Code.Contains("ApiAuthMe = \"/api/auth/me\"", StringComparison.Ordinal), "RouteConstants must define auth me route");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Route constants must define api routes for tasks pull requests payments and leaderboard")]
    public void RouteConstantsMustDefineApiRoutesForTasksPullRequestsPaymentsAndLeaderboard()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Code.Contains("ApiTasks = \"/api/tasks\"", StringComparison.Ordinal), "RouteConstants must define API tasks route");
        Assert.IsTrue(Code.Contains("ApiPullRequests = \"/api/prs\"", StringComparison.Ordinal), "RouteConstants must define API PRs route");
        Assert.IsTrue(Code.Contains("ApiPaymentsCheckout = \"/api/payments/checkout\"", StringComparison.Ordinal), "RouteConstants must define payments checkout route");
        Assert.IsTrue(Code.Contains("ApiPaymentsWebhook = \"/api/payments/webhook\"", StringComparison.Ordinal), "RouteConstants must define payments webhook route");
        Assert.IsTrue(Code.Contains("ApiPaymentsStatus = \"/api/payments/status\"", StringComparison.Ordinal), "RouteConstants must define payments status route");
        Assert.IsTrue(Code.Contains("ApiLeaderboard = \"/api/leaderboard\"", StringComparison.Ordinal), "RouteConstants must define API leaderboard route");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Google constants must define authorize url token url userinfo url and s256 pkce method")]
    public void GoogleConstantsMustDefineAuthorizeUrlTokenUrlUserinfoUrlAndS256PkceMethod()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "GoogleConstants.cs");
        Assert.IsTrue(Code.Contains("accounts.google.com/o/oauth2/v2/auth", StringComparison.Ordinal), "GoogleConstants must define Google authorize URL");
        Assert.IsTrue(Code.Contains("oauth2.googleapis.com/token", StringComparison.Ordinal), "GoogleConstants must define Google token URL");
        Assert.IsTrue(Code.Contains("googleapis.com/oauth2/v3/userinfo", StringComparison.Ordinal), "GoogleConstants must define Google userinfo URL");
        Assert.IsTrue(Code.Contains("openid email profile", StringComparison.Ordinal), "GoogleConstants must require openid email profile scopes");
        Assert.IsTrue(Code.Contains("CodeChallengeMethod = \"S256\"", StringComparison.Ordinal), "GoogleConstants must use S256 PKCE method");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Azure constants must define microsoft login url templates common tenant and s256 pkce")]
    public void AzureConstantsMustDefineMicrosoftLoginUrlTemplatesCommonTenantAndS256Pkce()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "AzureConstants.cs");
        Assert.IsTrue(Code.Contains("login.microsoftonline.com/{0}/oauth2/v2.0/authorize", StringComparison.Ordinal), "AzureConstants must define authorize URL template");
        Assert.IsTrue(Code.Contains("login.microsoftonline.com/{0}/oauth2/v2.0/token", StringComparison.Ordinal), "AzureConstants must define token URL template");
        Assert.IsTrue(Code.Contains("graph.microsoft.com/v1.0/me", StringComparison.Ordinal), "AzureConstants must define MS Graph user info URL");
        Assert.IsTrue(Code.Contains("CommonTenant = \"common\"", StringComparison.Ordinal), "AzureConstants must use common tenant");
        Assert.IsTrue(Code.Contains("User.Read", StringComparison.Ordinal), "AzureConstants must require User.Read scope");
        Assert.IsTrue(Code.Contains("CodeChallengeMethod = \"S256\"", StringComparison.Ordinal), "AzureConstants must use S256 PKCE method");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Okta constants must define oauth2 default path templates and s256 pkce code challenge")]
    public void OktaConstantsMustDefineOauth2DefaultPathTemplatesAndS256PkceCodeChallenge()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "OktaConstants.cs");
        Assert.IsTrue(Code.Contains("/oauth2/default/v1/authorize", StringComparison.Ordinal), "OktaConstants must define authorize path");
        Assert.IsTrue(Code.Contains("/oauth2/default/v1/token", StringComparison.Ordinal), "OktaConstants must define token path");
        Assert.IsTrue(Code.Contains("/oauth2/default/v1/userinfo", StringComparison.Ordinal), "OktaConstants must define userinfo path");
        Assert.IsTrue(Code.Contains("openid email profile", StringComparison.Ordinal), "OktaConstants must require openid email profile scopes");
        Assert.IsTrue(Code.Contains("CodeChallengeMethod = \"S256\"", StringComparison.Ordinal), "OktaConstants must use S256 PKCE method");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Github constants must define authorize url token url user api and read user scope")]
    public void GithubConstantsMustDefineAuthorizeUrlTokenUrlUserApiAndReadUserScope()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "GitHubConstants.cs");
        Assert.IsTrue(Code.Contains("github.com/login/oauth/authorize", StringComparison.Ordinal), "GitHubConstants must define authorize URL");
        Assert.IsTrue(Code.Contains("github.com/login/oauth/access_token", StringComparison.Ordinal), "GitHubConstants must define token URL");
        Assert.IsTrue(Code.Contains("api.github.com/user", StringComparison.Ordinal), "GitHubConstants must define user API URL");
        Assert.IsTrue(Code.Contains("read:user user:email", StringComparison.Ordinal), "GitHubConstants must require read:user user:email scopes");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maya constants must define sandbox and production base urls with checkout and webhook endpoints")]
    public void MayaConstantsMustDefineSandboxAndProductionBaseUrlsWithCheckoutAndWebhookEndpoints()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "MayaConstants.cs");
        Assert.IsTrue(Code.Contains("pg-sandbox.paymaya.com", StringComparison.Ordinal), "MayaConstants must define sandbox base URL");
        Assert.IsTrue(Code.Contains("pg.paymaya.com", StringComparison.Ordinal), "MayaConstants must define production base URL");
        Assert.IsTrue(Code.Contains("CheckoutEndpoint = \"/checkout/v1/checkouts\"", StringComparison.Ordinal), "MayaConstants must define checkout endpoint");
        Assert.IsTrue(Code.Contains("WebhookEndpoint = \"/payments/v1/webhooks\"", StringComparison.Ordinal), "MayaConstants must define webhook endpoint");
        Assert.IsTrue(Code.Contains("CustomerEndpoint = \"/payments/v1/customers\"", StringComparison.Ordinal), "MayaConstants must define customer endpoint");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maya constants must define webhook event names for checkout success failure and dropout")]
    public void MayaConstantsMustDefineWebhookEventNamesForCheckoutSuccessFailureAndDropout()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "MayaConstants.cs");
        Assert.IsTrue(Code.Contains("WebhookCheckoutSuccess = \"checkout.success\"", StringComparison.Ordinal), "MayaConstants must define success event");
        Assert.IsTrue(Code.Contains("WebhookCheckoutFailure = \"checkout.failure\"", StringComparison.Ordinal), "MayaConstants must define failure event");
        Assert.IsTrue(Code.Contains("WebhookCheckoutDropout = \"checkout.dropout\"", StringComparison.Ordinal), "MayaConstants must define dropout event");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Route constants must define client dashboard create task repository and edit delete task routes")]
    public void RouteConstantsMustDefineClientDashboardCreateTaskRepositoryAndEditDeleteTaskRoutes()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Code.Contains("ClientDashboard = \"/client/dashboard\"", StringComparison.Ordinal), "RouteConstants must define client dashboard route");
        Assert.IsTrue(Code.Contains("ClientCreateTask = \"/client/create-task\"", StringComparison.Ordinal), "RouteConstants must define client create task route");
        Assert.IsTrue(Code.Contains("ClientPayments = \"/client/payments\"", StringComparison.Ordinal), "RouteConstants must define client payments route");
        Assert.IsTrue(Code.Contains("EditTask = \"/client/edit-task/{0}\"", StringComparison.Ordinal), "RouteConstants must define edit task route");
        Assert.IsTrue(Code.Contains("DeleteTask = \"/client/delete-task/{0}\"", StringComparison.Ordinal), "RouteConstants must define delete task route");
        Assert.IsTrue(Code.Contains("Repository = \"/client/repository\"", StringComparison.Ordinal), "RouteConstants must define repository route");
        Assert.IsTrue(Code.Contains("DeploymentPreview = \"/deployments/{0}\"", StringComparison.Ordinal), "RouteConstants must define deployment preview route");
    }
}
