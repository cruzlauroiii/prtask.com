namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker google auth must redirect to accounts google com with openid email profile scope")]
    public void WorkerGoogleAuthMustRedirectToAccountsGoogleComWithOpenidEmailProfileScope()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("accounts.google.com/o/oauth2/v2/auth", StringComparison.Ordinal), "Google auth must redirect to accounts.google.com");
        Assert.IsTrue(Js.Contains("scope: \"openid email profile\"", StringComparison.Ordinal), "Google auth must request openid email profile scope");
        Assert.IsTrue(Js.Contains("response_type: \"code\"", StringComparison.Ordinal), "Google auth must use authorization code response type");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker google callback must exchange code at googleapis token endpoint with code verifier")]
    public void WorkerGoogleCallbackMustExchangeCodeAtGoogleapisTokenEndpointWithCodeVerifier()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("oauth2.googleapis.com/token", StringComparison.Ordinal), "Google callback must exchange code at googleapis token endpoint");
        Assert.IsTrue(Js.Contains("code_verifier: verifier", StringComparison.Ordinal), "Google callback must send code_verifier for PKCE validation");
        Assert.IsTrue(Js.Contains("grant_type: \"authorization_code\"", StringComparison.Ordinal), "Google callback must use authorization_code grant type");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker google callback must fetch user info from googleapis userinfo v3 endpoint with bearer token")]
    public void WorkerGoogleCallbackMustFetchUserInfoFromGoogleapisUserinfoV3EndpointWithBearerToken()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("googleapis.com/oauth2/v3/userinfo", StringComparison.Ordinal), "Google callback must fetch user info from v3 endpoint");
        Assert.IsTrue(Js.Contains("Authorization: \"Bearer \" + accessToken", StringComparison.Ordinal), "Google must send Bearer token header");
        Assert.IsTrue(Js.Contains("provider: \"Google\"", StringComparison.Ordinal), "Google session must set provider to Google");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker github auth must redirect to github login oauth authorize with read user scope")]
    public void WorkerGitHubAuthMustRedirectToGitHubLoginOauthAuthorizeWithReadUserScope()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("github.com/login/oauth/authorize", StringComparison.Ordinal), "GitHub auth must redirect to github.com authorize");
        Assert.IsTrue(Js.Contains("scope: \"read:user user:email\"", StringComparison.Ordinal), "GitHub auth must request read:user and user:email scopes");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker github callback must exchange code via json body with client id and client secret")]
    public void WorkerGitHubCallbackMustExchangeCodeViaJsonBodyWithClientIdAndClientSecret()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("github.com/login/oauth/access_token", StringComparison.Ordinal), "GitHub callback must exchange code at access_token endpoint");
        Assert.IsTrue(Js.Contains("JSON.stringify", StringComparison.Ordinal), "GitHub token exchange must use JSON body");
        Assert.IsTrue(Js.Contains("Accept\": \"application/json\"", StringComparison.Ordinal), "GitHub token exchange must accept JSON response");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker github callback must fetch user profile from api github com with prtask user agent")]
    public void WorkerGitHubCallbackMustFetchUserProfileFromApiGitHubComWithPrtaskUserAgent()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("api.github.com/user", StringComparison.Ordinal), "GitHub callback must fetch user from api.github.com");
        Assert.IsTrue(Js.Contains("User-Agent\": \"PrTask\"", StringComparison.Ordinal), "GitHub API request must use PrTask User-Agent");
        Assert.IsTrue(Js.Contains("provider: \"GitHub\"", StringComparison.Ordinal), "GitHub session must set provider to GitHub");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker github session must prefix user id with github underscore and use login as username")]
    public void WorkerGitHubSessionMustPrefixUserIdWithGitHubUnderscoreAndUseLoginAsUsername()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("\"github_\" + userInfo.id", StringComparison.Ordinal), "GitHub session userId must prefix with github_");
        Assert.IsTrue(Js.Contains("username: userInfo.login", StringComparison.Ordinal), "GitHub session must use login as username");
        Assert.IsTrue(Js.Contains("avatarUrl: userInfo.avatar_url", StringComparison.Ordinal), "GitHub session must use avatar_url for avatar");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker azure auth must redirect to login microsoftonline com common tenant authorize endpoint")]
    public void WorkerAzureAuthMustRedirectToLoginMicrosoftonlineComCommonTenantAuthorizeEndpoint()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("login.microsoftonline.com/common/oauth2/v2.0/authorize", StringComparison.Ordinal), "Azure auth must use common tenant authorize URL");
        Assert.IsTrue(Js.Contains("AZURE_CLIENT_ID", StringComparison.Ordinal), "Azure auth must use AZURE_CLIENT_ID env variable");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker azure callback must fetch user profile from microsoft graph me endpoint")]
    public void WorkerAzureCallbackMustFetchUserProfileFromMicrosoftGraphMeEndpoint()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("graph.microsoft.com/v1.0/me", StringComparison.Ordinal), "Azure callback must fetch user from Microsoft Graph");
        Assert.IsTrue(Js.Contains("\"azure_\" + userInfo.id", StringComparison.Ordinal), "Azure session userId must prefix with azure_");
        Assert.IsTrue(Js.Contains("userInfo.displayName || userInfo.mail", StringComparison.Ordinal), "Azure must fallback to mail if displayName is empty");
        Assert.IsTrue(Js.Contains("provider: \"Azure\"", StringComparison.Ordinal), "Azure session must set provider to Azure");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker okta auth must redirect to okta domain oauth2 default v1 authorize endpoint")]
    public void WorkerOktaAuthMustRedirectToOktaDomainOauth2DefaultV1AuthorizeEndpoint()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("env.OKTA_DOMAIN + \"/oauth2/default/v1/authorize", StringComparison.Ordinal), "Okta auth must use OKTA_DOMAIN for authorize URL");
        Assert.IsTrue(Js.Contains("OKTA_CLIENT_ID", StringComparison.Ordinal), "Okta auth must use OKTA_CLIENT_ID env variable");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker okta callback must exchange token and fetch userinfo from okta domain endpoint")]
    public void WorkerOktaCallbackMustExchangeTokenAndFetchUserinfoFromOktaDomainEndpoint()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("env.OKTA_DOMAIN + \"/oauth2/default/v1/token\"", StringComparison.Ordinal), "Okta callback must exchange token at OKTA_DOMAIN");
        Assert.IsTrue(Js.Contains("env.OKTA_DOMAIN + \"/oauth2/default/v1/userinfo\"", StringComparison.Ordinal), "Okta callback must fetch userinfo from OKTA_DOMAIN");
        Assert.IsTrue(Js.Contains("\"okta_\" + userInfo.sub", StringComparison.Ordinal), "Okta session userId must prefix with okta_");
        Assert.IsTrue(Js.Contains("provider: \"Okta\"", StringComparison.Ordinal), "Okta session must set provider to Okta");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker finish auth must redirect web users to dashboard with session cookie set in header")]
    public void WorkerFinishAuthMustRedirectWebUsersToDashboardWithSessionCookieSetInHeader()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("finishAuth", StringComparison.Ordinal), "Worker must have finishAuth function for post-auth redirect");
        Assert.IsTrue(Js.Contains("prtask.com/dashboard", StringComparison.Ordinal), "Web auth must redirect to dashboard after login");
        Assert.IsTrue(Js.Contains("Set-Cookie", StringComparison.Ordinal), "Worker must set session cookie in response header");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker base64 url encode must replace plus with dash and slash with underscore and trim padding")]
    public void WorkerBase64UrlEncodeMustReplacePlusWithDashAndSlashWithUnderscoreAndTrimPadding()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("base64UrlEncode", StringComparison.Ordinal), "Worker must have base64UrlEncode helper function");
        Assert.IsTrue(Js.Contains("replace(/\\+/g, \"-\")", StringComparison.Ordinal), "Must replace + with - for URL-safe base64");
        Assert.IsTrue(Js.Contains("replace(/\\//g, \"_\")", StringComparison.Ordinal), "Must replace / with _ for URL-safe base64");
        Assert.IsTrue(Js.Contains("replace(/=+$/, \"\")", StringComparison.Ordinal), "Must trim trailing = padding for URL-safe base64");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker google auth error handling must redirect with auto failed and no code error parameters")]
    public void WorkerGoogleAuthErrorHandlingMustRedirectWithAutoFailedAndNoCodeErrorParameters()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("auto_failed=true", StringComparison.Ordinal), "Google callback must redirect with auto_failed on error param");
        Assert.IsTrue(Js.Contains("error=no_code", StringComparison.Ordinal), "Callback must redirect with no_code when code is missing");
        Assert.IsTrue(Js.Contains("error=pkce_missing", StringComparison.Ordinal), "Callback must redirect with pkce_missing when verifier absent");
        Assert.IsTrue(Js.Contains("error=token_failed", StringComparison.Ordinal), "Callback must redirect with token_failed on exchange failure");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker github and azure error handling must redirect with provider denied error parameters")]
    public void WorkerGitHubAndAzureErrorHandlingMustRedirectWithProviderDeniedErrorParameters()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("error=github_denied", StringComparison.Ordinal), "GitHub callback must redirect with github_denied on error");
        Assert.IsTrue(Js.Contains("error=azure_denied", StringComparison.Ordinal), "Azure callback must redirect with azure_denied on error");
        Assert.IsTrue(Js.Contains("error=okta_denied", StringComparison.Ordinal), "Okta callback must redirect with okta_denied on error");
        Assert.IsTrue(Js.Contains("error=profile_failed", StringComparison.Ordinal), "Callbacks must redirect with profile_failed on user fetch failure");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker task detail endpoint must return individual task by id with not found error response")]
    public void WorkerTaskDetailEndpointMustReturnIndividualTaskByIdWithNotFoundErrorResponse()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("SELECT * FROM tasks WHERE id = ?", StringComparison.Ordinal), "Worker must query task by ID");
        Assert.IsTrue(Js.Contains("error: \"not_found\"", StringComparison.Ordinal), "Worker must return not_found error for missing task");
        Assert.IsTrue(Js.Contains("path.split(\"/\").pop()", StringComparison.Ordinal), "Worker must extract task ID from path segments");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker pull requests by task endpoint must query prs ordered by created at descending")]
    public void WorkerPullRequestsByTaskEndpointMustQueryPrsOrderedByCreatedAtDescending()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("/prs$/) && request.method === \"GET\"", StringComparison.Ordinal), "Worker must match PRs by task route pattern");
        Assert.IsTrue(Js.Contains("SELECT * FROM pull_requests WHERE task_id = ?", StringComparison.Ordinal), "Worker must query PRs by task_id");
        Assert.IsTrue(Js.Contains("ORDER BY created_at DESC", StringComparison.Ordinal), "Worker must order PRs by created_at descending");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker webhook endpoint must accept post to api payments webhook and return received true")]
    public void WorkerWebhookEndpointMustAcceptPostToApiPaymentsWebhookAndReturnReceivedTrue()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("/api/payments/webhook", StringComparison.Ordinal), "Worker must have payments webhook endpoint");
        Assert.IsTrue(Js.Contains("received: true", StringComparison.Ordinal), "Worker webhook must respond with received:true");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker task create must insert into d1 with crypto random uuid and datetime now defaults")]
    public void WorkerTaskCreateMustInsertIntoD1WithCryptoRandomUuidAndDatetimeNowDefaults()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("crypto.randomUUID()", StringComparison.Ordinal), "Worker must generate UUID for new task ID");
        Assert.IsTrue(Js.Contains("INSERT INTO tasks", StringComparison.Ordinal), "Worker must insert new task into D1 database");
        Assert.IsTrue(Js.Contains("datetime('now')", StringComparison.Ordinal), "Worker must use SQLite datetime for created_at");
        Assert.IsTrue(Js.Contains("status: 201", StringComparison.Ordinal), "Worker must return 201 Created for new task");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker google auto login must set prompt none parameter when auto query parameter is true")]
    public void WorkerGoogleAutoLoginMustSetPromptNoneParameterWhenAutoQueryParameterIsTrue()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("url.searchParams.get(\"auto\") === \"true\"", StringComparison.Ordinal), "Worker must check auto query parameter for silent login");
        Assert.IsTrue(Js.Contains("params.set(\"prompt\", \"none\")", StringComparison.Ordinal), "Worker must set prompt=none for Google silent re-auth");
    }
}
