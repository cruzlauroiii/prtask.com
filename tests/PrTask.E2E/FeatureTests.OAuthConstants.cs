namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("App constants must define prtask com domain and cloudflare pages project name as prtask")]
    public void AppConstantsMustDefinePrtaskComDomainAndCloudflarePagesProjectNameAsPrtask()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "AppConstants.cs");
        Assert.IsTrue(Code.Contains("AppDomain = \"prtask.com\"", StringComparison.Ordinal), "AppConstants must define AppDomain as prtask.com");
        Assert.IsTrue(Code.Contains("CloudflarePagesProject = \"prtask\"", StringComparison.Ordinal), "AppConstants must define CloudflarePagesProject");
        Assert.IsTrue(Code.Contains("AppName = \"PrTask\"", StringComparison.Ordinal), "AppConstants must define AppName as PrTask");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("App constants must define max file lines at three hundred and platform fee percent at zero")]
    public void AppConstantsMustDefineMaxFileLinesAtThreeHundredAndPlatformFeePercentAtZero()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "AppConstants.cs");
        Assert.IsTrue(Code.Contains("MaxFileLines = 300", StringComparison.Ordinal), "AppConstants must set MaxFileLines to 300");
        Assert.IsTrue(Code.Contains("PlatformFeePercent = 0", StringComparison.Ordinal), "AppConstants must set PlatformFeePercent to 0 (free platform)");
        Assert.IsTrue(Code.Contains("MinBountyAmountCents = 10000", StringComparison.Ordinal), "AppConstants must set MinBountyAmountCents to 10000");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("App constants must define xp per complexity point at ten and streak bonus multiplier at two")]
    public void AppConstantsMustDefineXpPerComplexityPointAtTenAndStreakBonusMultiplierAtTwo()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "AppConstants.cs");
        Assert.IsTrue(Code.Contains("XpPerComplexityPoint = 10", StringComparison.Ordinal), "AppConstants must set XpPerComplexityPoint to 10");
        Assert.IsTrue(Code.Contains("StreakBonusMultiplier = 2", StringComparison.Ordinal), "AppConstants must set StreakBonusMultiplier to 2");
        Assert.IsTrue(Code.Contains("MaxTaskTitleLength = 200", StringComparison.Ordinal), "AppConstants must set MaxTaskTitleLength to 200");
        Assert.IsTrue(Code.Contains("MaxTaskDescriptionLength = 10000", StringComparison.Ordinal), "AppConstants must set MaxTaskDescriptionLength to 10000");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("App constants must define level thresholds at zero hundred thousand and five thousand xp values")]
    public void AppConstantsMustDefineLevelThresholdsAtZeroHundredThousandAndFiveThousandXpValues()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "AppConstants.cs");
        Assert.IsTrue(Code.Contains("Level1Threshold = 0", StringComparison.Ordinal), "AppConstants must set Level1 threshold to 0");
        Assert.IsTrue(Code.Contains("Level2Threshold = 100", StringComparison.Ordinal), "AppConstants must set Level2 threshold to 100");
        Assert.IsTrue(Code.Contains("Level5Threshold = 1000", StringComparison.Ordinal), "AppConstants must set Level5 threshold to 1000");
        Assert.IsTrue(Code.Contains("Level10Threshold = 5000", StringComparison.Ordinal), "AppConstants must set Level10 threshold to 5000");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Google constants must define accounts google authorize url and googleapis token and userinfo urls")]
    public void GoogleConstantsMustDefineAccountsGoogleAuthorizeUrlAndGoogleapisTokenAndUserinfoUrls()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "GoogleConstants.cs");
        Assert.IsTrue(Code.Contains("accounts.google.com/o/oauth2/v2/auth", StringComparison.Ordinal), "Google must define authorize URL");
        Assert.IsTrue(Code.Contains("oauth2.googleapis.com/token", StringComparison.Ordinal), "Google must define token URL");
        Assert.IsTrue(Code.Contains("googleapis.com/oauth2/v3/userinfo", StringComparison.Ordinal), "Google must define userinfo URL");
        Assert.IsTrue(Code.Contains("CodeChallengeMethod = \"S256\"", StringComparison.Ordinal), "Google must use S256 code challenge method");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Github constants must define authorize access token and user api urls with read user scope")]
    public void GitHubConstantsMustDefineAuthorizeAccessTokenAndUserApiUrlsWithReadUserScope()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "GitHubConstants.cs");
        Assert.IsTrue(Code.Contains("github.com/login/oauth/authorize", StringComparison.Ordinal), "GitHub must define authorize URL");
        Assert.IsTrue(Code.Contains("github.com/login/oauth/access_token", StringComparison.Ordinal), "GitHub must define token URL");
        Assert.IsTrue(Code.Contains("api.github.com/user", StringComparison.Ordinal), "GitHub must define user API URL");
        Assert.IsTrue(Code.Contains("RequiredScope = \"read:user user:email\"", StringComparison.Ordinal), "GitHub must define required scope");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Azure constants must define microsoftonline authorize template and graph me userinfo url")]
    public void AzureConstantsMustDefineMicrosoftonlineAuthorizeTemplateAndGraphMeUserinfoUrl()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "AzureConstants.cs");
        Assert.IsTrue(Code.Contains("login.microsoftonline.com/{0}/oauth2/v2.0/authorize", StringComparison.Ordinal), "Azure must define authorize URL template");
        Assert.IsTrue(Code.Contains("graph.microsoft.com/v1.0/me", StringComparison.Ordinal), "Azure must define Graph userinfo URL");
        Assert.IsTrue(Code.Contains("CommonTenant = \"common\"", StringComparison.Ordinal), "Azure must define common tenant");
        Assert.IsTrue(Code.Contains("RequiredScope = \"openid email profile User.Read\"", StringComparison.Ordinal), "Azure must include User.Read scope");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Okta constants must define oauth2 default v1 authorize token and userinfo path templates")]
    public void OktaConstantsMustDefineOauth2DefaultV1AuthorizeTokenAndUserinfoPathTemplates()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "OktaConstants.cs");
        Assert.IsTrue(Code.Contains("/oauth2/default/v1/authorize", StringComparison.Ordinal), "Okta must define authorize path template");
        Assert.IsTrue(Code.Contains("/oauth2/default/v1/token", StringComparison.Ordinal), "Okta must define token path template");
        Assert.IsTrue(Code.Contains("/oauth2/default/v1/userinfo", StringComparison.Ordinal), "Okta must define userinfo path template");
        Assert.IsTrue(Code.Contains("RequiredScope = \"openid email profile\"", StringComparison.Ordinal), "Okta must define required scope");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maya constants must define sandbox and production base urls and checkout v1 checkouts endpoint")]
    public void MayaConstantsMustDefineSandboxAndProductionBaseUrlsAndCheckoutV1CheckoutsEndpoint()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "MayaConstants.cs");
        Assert.IsTrue(Code.Contains("pg-sandbox.paymaya.com", StringComparison.Ordinal), "Maya must define sandbox base URL");
        Assert.IsTrue(Code.Contains("pg.paymaya.com", StringComparison.Ordinal), "Maya must define production base URL");
        Assert.IsTrue(Code.Contains("CheckoutEndpoint = \"/checkout/v1/checkouts\"", StringComparison.Ordinal), "Maya must define checkout endpoint");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maya constants must define webhook success failure and dropout event type string constants")]
    public void MayaConstantsMustDefineWebhookSuccessFailureAndDropoutEventTypeStringConstants()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "MayaConstants.cs");
        Assert.IsTrue(Code.Contains("checkout.success", StringComparison.Ordinal), "Maya must define checkout.success webhook event");
        Assert.IsTrue(Code.Contains("checkout.failure", StringComparison.Ordinal), "Maya must define checkout.failure webhook event");
        Assert.IsTrue(Code.Contains("checkout.dropout", StringComparison.Ordinal), "Maya must define checkout.dropout webhook event");
        Assert.IsTrue(Code.Contains("WebhookEndpoint = \"/payments/v1/webhooks\"", StringComparison.Ordinal), "Maya must define webhook endpoint");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Route constants must define all eight legal page paths under legal prefix with consistent naming")]
    public void RouteConstantsMustDefineAllEightLegalPagePathsUnderLegalPrefixWithConsistentNaming()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Code.Contains("Terms = \"/legal/terms\"", StringComparison.Ordinal), "RouteConstants must define Terms path");
        Assert.IsTrue(Code.Contains("Privacy = \"/legal/privacy\"", StringComparison.Ordinal), "RouteConstants must define Privacy path");
        Assert.IsTrue(Code.Contains("Refund = \"/legal/refund\"", StringComparison.Ordinal), "RouteConstants must define Refund path");
        Assert.IsTrue(Code.Contains("Dmca = \"/legal/dmca\"", StringComparison.Ordinal), "RouteConstants must define Dmca path");
        Assert.IsTrue(Code.Contains("Accessibility = \"/legal/accessibility\"", StringComparison.Ordinal), "RouteConstants must define Accessibility path");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Route constants must define all four oauth provider api auth routes and callback routes")]
    public void RouteConstantsMustDefineAllFourOauthProviderApiAuthRoutesAndCallbackRoutes()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Code.Contains("ApiAuthGitHub = \"/api/auth/github\"", StringComparison.Ordinal), "RouteConstants must define GitHub auth route");
        Assert.IsTrue(Code.Contains("ApiAuthGoogle = \"/api/auth/google\"", StringComparison.Ordinal), "RouteConstants must define Google auth route");
        Assert.IsTrue(Code.Contains("ApiAuthAzure = \"/api/auth/azure\"", StringComparison.Ordinal), "RouteConstants must define Azure auth route");
        Assert.IsTrue(Code.Contains("ApiAuthOkta = \"/api/auth/okta\"", StringComparison.Ordinal), "RouteConstants must define Okta auth route");
        Assert.IsTrue(Code.Contains("ApiAuthMe = \"/api/auth/me\"", StringComparison.Ordinal), "RouteConstants must define auth me route");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Route constants must define api tasks prs payments checkout webhook and leaderboard endpoints")]
    public void RouteConstantsMustDefineApiTasksPrsPaymentsCheckoutWebhookAndLeaderboardEndpoints()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Code.Contains("ApiTasks = \"/api/tasks\"", StringComparison.Ordinal), "RouteConstants must define tasks API route");
        Assert.IsTrue(Code.Contains("ApiPullRequests = \"/api/prs\"", StringComparison.Ordinal), "RouteConstants must define PRs API route");
        Assert.IsTrue(Code.Contains("ApiPaymentsCheckout = \"/api/payments/checkout\"", StringComparison.Ordinal), "RouteConstants must define checkout route");
        Assert.IsTrue(Code.Contains("ApiPaymentsWebhook = \"/api/payments/webhook\"", StringComparison.Ordinal), "RouteConstants must define webhook route");
        Assert.IsTrue(Code.Contains("ApiLeaderboard = \"/api/leaderboard\"", StringComparison.Ordinal), "RouteConstants must define leaderboard route");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Route constants must define client dashboard create task edit task and delete task format paths")]
    public void RouteConstantsMustDefineClientDashboardCreateTaskEditTaskAndDeleteTaskFormatPaths()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Code.Contains("ClientDashboard = \"/client/dashboard\"", StringComparison.Ordinal), "RouteConstants must define client dashboard");
        Assert.IsTrue(Code.Contains("ClientCreateTask = \"/client/create-task\"", StringComparison.Ordinal), "RouteConstants must define create task route");
        Assert.IsTrue(Code.Contains("EditTask = \"/client/edit-task/{0}\"", StringComparison.Ordinal), "RouteConstants must define edit task format route");
        Assert.IsTrue(Code.Contains("DeleteTask = \"/client/delete-task/{0}\"", StringComparison.Ordinal), "RouteConstants must define delete task format route");
    }
}
