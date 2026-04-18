namespace PrTask.E2E;
public partial class FeatureTests
{
    private static string ReadInfraFile(params string[] PathSegments)
    {
        var FullPath = Path.Combine([SourceRoot, "..", "infra", .. PathSegments]);
        return File.ReadAllText(FullPath);
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker must handle api routes and return not found for non api paths")]
    public void WorkerMustHandleApiRoutesAndReturnNotFoundForNonApiPaths()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("/api/", StringComparison.Ordinal), "Worker must route /api/ paths to handleApi");
        Assert.IsTrue(Js.Contains("handleApi", StringComparison.Ordinal), "Worker must define handleApi function");
        Assert.IsTrue(Js.Contains("status: 404", StringComparison.Ordinal), "Worker must return 404 for non-API paths");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker must have task crud endpoints for get post put and delete operations")]
    public void WorkerMustHaveTaskCrudEndpointsForGetPostPutAndDeleteOperations()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("\"/api/tasks\"", StringComparison.Ordinal), "Worker must have /api/tasks endpoint");
        Assert.IsTrue(Js.Contains("request.method === \"GET\"", StringComparison.Ordinal), "Worker must handle GET requests");
        Assert.IsTrue(Js.Contains("request.method === \"POST\"", StringComparison.Ordinal), "Worker must handle POST requests");
        Assert.IsTrue(Js.Contains("request.method === \"PUT\"", StringComparison.Ordinal), "Worker must handle PUT requests");
        Assert.IsTrue(Js.Contains("request.method === \"DELETE\"", StringComparison.Ordinal), "Worker must handle DELETE requests");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker must require session authentication for task create update and delete operations")]
    public void WorkerMustRequireSessionAuthenticationForTaskCreateUpdateAndDeleteOperations()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("getSession(request, env)", StringComparison.Ordinal), "Worker must call getSession for auth");
        Assert.IsTrue(Js.Contains("status: 401", StringComparison.Ordinal), "Worker must return 401 for unauthorized");
        Assert.IsTrue(Js.Contains("\"Unauthorized\"", StringComparison.Ordinal), "Worker must return Unauthorized message");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker must have oauth auth endpoints for google github azure and okta providers")]
    public void WorkerMustHaveOauthAuthEndpointsForGoogleGitHubAzureAndOktaProviders()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("/api/auth/google", StringComparison.Ordinal), "Worker must have Google auth endpoint");
        Assert.IsTrue(Js.Contains("/api/auth/github", StringComparison.Ordinal), "Worker must have GitHub auth endpoint");
        Assert.IsTrue(Js.Contains("/api/auth/azure", StringComparison.Ordinal), "Worker must have Azure auth endpoint");
        Assert.IsTrue(Js.Contains("/api/auth/okta", StringComparison.Ordinal), "Worker must have Okta auth endpoint");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker must have oauth callback endpoints for all four sso providers")]
    public void WorkerMustHaveOauthCallbackEndpointsForAllFourSsoProviders()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("/api/auth/callback/google", StringComparison.Ordinal), "Worker must have Google callback endpoint");
        Assert.IsTrue(Js.Contains("/api/auth/callback/github", StringComparison.Ordinal), "Worker must have GitHub callback endpoint");
        Assert.IsTrue(Js.Contains("/api/auth/callback/azure", StringComparison.Ordinal), "Worker must have Azure callback endpoint");
        Assert.IsTrue(Js.Contains("/api/auth/callback/okta", StringComparison.Ordinal), "Worker must have Okta callback endpoint");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker must use pkce with sha256 code challenge for google azure and okta oauth")]
    public void WorkerMustUsePkceWithSha256CodeChallengeForGoogleAzureAndOktaOauth()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("generateCodeVerifier", StringComparison.Ordinal), "Worker must generate PKCE code verifier");
        Assert.IsTrue(Js.Contains("generateCodeChallenge", StringComparison.Ordinal), "Worker must generate PKCE code challenge");
        Assert.IsTrue(Js.Contains("code_challenge_method: \"S256\"", StringComparison.Ordinal), "Worker must use S256 challenge method");
        Assert.IsTrue(Js.Contains("SHA-256", StringComparison.Ordinal), "Worker must hash with SHA-256");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker must store pkce verifier in kv sessions with ten minute expiration ttl")]
    public void WorkerMustStorePkceVerifierInKvSessionsWithTenMinuteExpirationTtl()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("pkce_", StringComparison.Ordinal), "Worker must prefix PKCE state with pkce_");
        Assert.IsTrue(Js.Contains("expirationTtl: 600", StringComparison.Ordinal), "Worker must expire PKCE verifier after 600 seconds");
        Assert.IsTrue(Js.Contains("env.SESSIONS.put", StringComparison.Ordinal), "Worker must store verifier in SESSIONS KV");
        Assert.IsTrue(Js.Contains("env.SESSIONS.delete", StringComparison.Ordinal), "Worker must delete PKCE verifier after use");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker must set http only secure same site lax cookie with thirty day expiration on auth")]
    public void WorkerMustSetHttpOnlySecureSameSiteLaxCookieWithThirtyDayExpirationOnAuth()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("HttpOnly", StringComparison.Ordinal), "Worker must set HttpOnly cookie flag");
        Assert.IsTrue(Js.Contains("Secure", StringComparison.Ordinal), "Worker must set Secure cookie flag");
        Assert.IsTrue(Js.Contains("SameSite=Lax", StringComparison.Ordinal), "Worker must set SameSite=Lax cookie flag");
        Assert.IsTrue(Js.Contains("Max-Age=2592000", StringComparison.Ordinal), "Worker must set 30-day cookie expiration");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker must support android platform redirect with com prtask app deep link scheme")]
    public void WorkerMustSupportAndroidPlatformRedirectWithComPrtaskAppDeepLinkScheme()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("com.prtask.app://auth", StringComparison.Ordinal), "Worker must redirect to app deep link on Android");
        Assert.IsTrue(Js.Contains("platform_", StringComparison.Ordinal), "Worker must track platform state for mobile auth");
        Assert.IsTrue(Js.Contains("\"android\"", StringComparison.Ordinal), "Worker must detect Android platform parameter");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker must have leaderboard endpoint ordering by total xp descending with limit parameter")]
    public void WorkerMustHaveLeaderboardEndpointOrderingByTotalXpDescendingWithLimitParameter()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("/api/leaderboard", StringComparison.Ordinal), "Worker must have leaderboard endpoint");
        Assert.IsTrue(Js.Contains("ORDER BY total_xp DESC", StringComparison.Ordinal), "Worker must order leaderboard by XP");
        Assert.IsTrue(Js.Contains("LIMIT", StringComparison.Ordinal), "Worker must limit leaderboard results");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker must handle post logout by deleting session and clearing cookie with zero max age")]
    public void WorkerMustHandlePostLogoutByDeletingSessionAndClearingCookieWithZeroMaxAge()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("/api/auth/logout", StringComparison.Ordinal), "Worker must have logout endpoint");
        Assert.IsTrue(Js.Contains("method === \"POST\"", StringComparison.Ordinal), "Worker logout must use POST method");
        Assert.IsTrue(Js.Contains("Max-Age=0", StringComparison.Ordinal), "Worker logout must clear cookie with Max-Age=0");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker must set cors headers allowing origin from prtask dot com domain only")]
    public void WorkerMustSetCorsHeadersAllowingOriginFromPrtaskDotComDomainOnly()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("Access-Control-Allow-Origin", StringComparison.Ordinal), "Worker must set CORS header");
        Assert.IsTrue(Js.Contains("https://prtask.com", StringComparison.Ordinal), "Worker must allow origin from prtask.com");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker must parse session cookie from request headers using regex match pattern")]
    public void WorkerMustParseSessionCookieFromRequestHeadersUsingRegexMatchPattern()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("getSessionId", StringComparison.Ordinal), "Worker must have getSessionId helper");
        Assert.IsTrue(Js.Contains("session=([^;]+)", StringComparison.Ordinal), "Worker must parse session cookie with regex");
        Assert.IsTrue(Js.Contains("request.headers.get(\"Cookie\")", StringComparison.Ordinal), "Worker must read Cookie header");
    }
}
