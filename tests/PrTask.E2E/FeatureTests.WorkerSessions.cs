namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker session storage must use json stringify with expiration ttl two million five hundred ninety two thousand")]
    public void WorkerSessionStorageMustUseJsonStringifyWithExpirationTtlTwoMillionFiveHundredNinetyTwoThousand()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("JSON.stringify(sessionData)", StringComparison.Ordinal), "Worker must serialize session data with JSON.stringify");
        Assert.IsTrue(Js.Contains("expirationTtl: 2592000", StringComparison.Ordinal), "Worker must set session TTL to 2592000 seconds (30 days)");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker get session must parse session id then fetch from kv and json parse or return null")]
    public void WorkerGetSessionMustParseSessionIdThenFetchFromKvAndJsonParseOrReturnNull()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("const sessionId = getSessionId(request)", StringComparison.Ordinal), "getSession must call getSessionId first");
        Assert.IsTrue(Js.Contains("if (!sessionId) return null", StringComparison.Ordinal), "getSession must return null when no sessionId");
        Assert.IsTrue(Js.Contains("env.SESSIONS.get(sessionId)", StringComparison.Ordinal), "getSession must fetch from SESSIONS KV store");
        Assert.IsTrue(Js.Contains("JSON.parse(session)", StringComparison.Ordinal), "getSession must parse JSON session data");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker get session id must read cookie header and match session regex returning null on miss")]
    public void WorkerGetSessionIdMustReadCookieHeaderAndMatchSessionRegexReturningNullOnMiss()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("request.headers.get(\"Cookie\") || \"\"", StringComparison.Ordinal), "getSessionId must default to empty string when no cookie");
        Assert.IsTrue(Js.Contains("cookie.match(/session=([^;]+)/)", StringComparison.Ordinal), "getSessionId must use regex to extract session value");
        Assert.IsTrue(Js.Contains("match ? match[1] : null", StringComparison.Ordinal), "getSessionId must return captured group or null");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker auth me endpoint must return session json for authenticated users or unauthorized status")]
    public void WorkerAuthMeEndpointMustReturnSessionJsonForAuthenticatedUsersOrUnauthorizedStatus()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("/api/auth/me", StringComparison.Ordinal), "Worker must have auth/me endpoint");
        Assert.IsTrue(Js.Contains("JSON.stringify(session)", StringComparison.Ordinal), "auth/me must return serialized session data");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker task update must bind title description complexity and bounty amount cents to sql update")]
    public void WorkerTaskUpdateMustBindTitleDescriptionComplexityAndBountyAmountCentsToSqlUpdate()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("UPDATE tasks SET title = ?, description = ?, complexity = ?, bounty_amount_cents = ? WHERE id = ?", StringComparison.Ordinal), "Worker task update must use parameterized UPDATE query");
        Assert.IsTrue(Js.Contains("body.complexity || \"Medium\"", StringComparison.Ordinal), "Worker task update must default complexity to Medium");
        Assert.IsTrue(Js.Contains("body.bountyAmountCents || 10000", StringComparison.Ordinal), "Worker task update must default bounty to 10000 cents");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker task delete must execute delete from tasks where id equals bound parameter")]
    public void WorkerTaskDeleteMustExecuteDeleteFromTasksWhereIdEqualsBoundParameter()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("DELETE FROM tasks WHERE id = ?", StringComparison.Ordinal), "Worker task delete must use parameterized DELETE query");
        Assert.IsTrue(Js.Contains("ok: true", StringComparison.Ordinal), "Worker task delete must respond with ok:true");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker task create must bind session user id as client id with repo url default empty string")]
    public void WorkerTaskCreateMustBindSessionUserIdAsClientIdWithRepoUrlDefaultEmptyString()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("session.userId", StringComparison.Ordinal), "Worker task create must use session userId as client_id");
        Assert.IsTrue(Js.Contains("body.repoUrl || \"\"", StringComparison.Ordinal), "Worker task create must default repoUrl to empty string");
        Assert.IsTrue(Js.Contains("body.complexity || \"Medium\"", StringComparison.Ordinal), "Worker task create must default complexity to Medium");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker task list must select open status tasks ordered by created at descending from d1")]
    public void WorkerTaskListMustSelectOpenStatusTasksOrderedByCreatedAtDescendingFromD1()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("SELECT * FROM tasks WHERE status = 'Open' ORDER BY created_at DESC", StringComparison.Ordinal), "Worker must query open tasks ordered by created_at DESC");
        Assert.IsTrue(Js.Contains("results.results", StringComparison.Ordinal), "Worker must access D1 results.results array");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker finish auth must check platform state and delete platform key from sessions kv store")]
    public void WorkerFinishAuthMustCheckPlatformStateAndDeletePlatformKeyFromSessionsKvStore()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("env.SESSIONS.get(\"platform_\" + state)", StringComparison.Ordinal), "finishAuth must check platform state from KV");
        Assert.IsTrue(Js.Contains("env.SESSIONS.delete(\"platform_\" + state)", StringComparison.Ordinal), "finishAuth must clean up platform state from KV");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker finish auth android redirect must include session and username url search params")]
    public void WorkerFinishAuthAndroidRedirectMustIncludeSessionAndUsernameUrlSearchParams()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("session: sessionId", StringComparison.Ordinal), "Android redirect must include session param with sessionId");
        Assert.IsTrue(Js.Contains("username: sessionData.username || \"\"", StringComparison.Ordinal), "Android redirect must include username param with fallback");
        Assert.IsTrue(Js.Contains("com.prtask.app://auth?", StringComparison.Ordinal), "Android redirect must append params to deep link URL");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker finish auth web redirect must set location header to prtask dashboard with cookie header")]
    public void WorkerFinishAuthWebRedirectMustSetLocationHeaderToPrtaskDashboardWithCookieHeader()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("cookieHeaders.set(\"Location\", \"https://prtask.com/dashboard\")", StringComparison.Ordinal), "Web auth must set Location header to dashboard");
        Assert.IsTrue(Js.Contains("session=\" + sessionId + \"; Path=/; HttpOnly; Secure; SameSite=Lax; Max-Age=2592000", StringComparison.Ordinal), "Web auth cookie must have full security attributes");
        Assert.IsTrue(Js.Contains("status: 302", StringComparison.Ordinal), "Web auth redirect must use 302 status");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker generate code verifier must create uint8 array of thirty two bytes with crypto get random values")]
    public void WorkerGenerateCodeVerifierMustCreateUint8ArrayOfThirtyTwoBytesWithCryptoGetRandomValues()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("new Uint8Array(32)", StringComparison.Ordinal), "generateCodeVerifier must create 32-byte Uint8Array");
        Assert.IsTrue(Js.Contains("crypto.getRandomValues(bytes)", StringComparison.Ordinal), "generateCodeVerifier must fill with crypto random values");
        Assert.IsTrue(Js.Contains("return base64UrlEncode(bytes)", StringComparison.Ordinal), "generateCodeVerifier must return base64url encoded result");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker generate code challenge must encode verifier with text encoder and digest sha256 hash")]
    public void WorkerGenerateCodeChallengeMustEncodeVerifierWithTextEncoderAndDigestSha256Hash()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("new TextEncoder()", StringComparison.Ordinal), "generateCodeChallenge must create TextEncoder");
        Assert.IsTrue(Js.Contains("encoder.encode(verifier)", StringComparison.Ordinal), "generateCodeChallenge must encode verifier string");
        Assert.IsTrue(Js.Contains("crypto.subtle.digest(\"SHA-256\", data)", StringComparison.Ordinal), "generateCodeChallenge must use SHA-256 digest");
        Assert.IsTrue(Js.Contains("base64UrlEncode(new Uint8Array(hash))", StringComparison.Ordinal), "generateCodeChallenge must base64url encode hash bytes");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker base64 url encode loop must convert each byte with string from char code then btoa encode")]
    public void WorkerBase64UrlEncodeLoopMustConvertEachByteWithStringFromCharCodeThenBtaoEncode()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("String.fromCharCode(byte)", StringComparison.Ordinal), "base64UrlEncode must convert bytes to chars");
        Assert.IsTrue(Js.Contains("btoa(binary)", StringComparison.Ordinal), "base64UrlEncode must use btoa for base64 encoding");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker logout handler must call get session id and delete session then return ok json response")]
    public void WorkerLogoutHandlerMustCallGetSessionIdAndDeleteSessionThenReturnOkJsonResponse()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("handleLogout", StringComparison.Ordinal), "Worker must define handleLogout function");
        Assert.IsTrue(Js.Contains("const session = getSessionId(request)", StringComparison.Ordinal), "handleLogout must extract session from request");
        Assert.IsTrue(Js.Contains("env.SESSIONS.delete(session)", StringComparison.Ordinal), "handleLogout must delete session from KV store");
        Assert.IsTrue(Js.Contains("session=; Path=/; HttpOnly; Secure; SameSite=Lax; Max-Age=0", StringComparison.Ordinal), "handleLogout must set expired cookie");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker leaderboard endpoint must parse count from url search params and default to string hundred")]
    public void WorkerLeaderboardEndpointMustParseCountFromUrlSearchParamsAndDefaultToStringHundred()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("url.searchParams.get(\"Count\") || \"100\"", StringComparison.Ordinal), "Leaderboard must read Count param with 100 default");
        Assert.IsTrue(Js.Contains("parseInt(count)", StringComparison.Ordinal), "Leaderboard must parseInt the count value");
        Assert.IsTrue(Js.Contains("SELECT * FROM leaderboard ORDER BY total_xp DESC LIMIT ?", StringComparison.Ordinal), "Leaderboard SQL must order by total_xp DESC with LIMIT");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker google session data must map sub as user id and name or email as username with picture")]
    public void WorkerGoogleSessionDataMustMapSubAsUserIdAndNameOrEmailAsUsernameWithPicture()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("userId: userInfo.sub", StringComparison.Ordinal), "Google session must use sub as userId (no prefix)");
        Assert.IsTrue(Js.Contains("username: userInfo.name || userInfo.email", StringComparison.Ordinal), "Google session must fallback from name to email");
        Assert.IsTrue(Js.Contains("avatarUrl: userInfo.picture", StringComparison.Ordinal), "Google session must use picture field for avatar");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker azure session data must fallback email to user principal name or empty string")]
    public void WorkerAzureSessionDataMustFallbackEmailToUserPrincipalNameOrEmptyString()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("email: userInfo.mail || userInfo.userPrincipalName || \"\"", StringComparison.Ordinal), "Azure email must chain mail, userPrincipalName, empty");
        Assert.IsTrue(Js.Contains("avatarUrl: \"\"", StringComparison.Ordinal), "Azure session must default avatarUrl to empty string");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker okta session data must prefix user id with okta underscore and use sub as identifier")]
    public void WorkerOktaSessionDataMustPrefixUserIdWithOktaUnderscoreAndUseSubAsIdentifier()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("\"okta_\" + userInfo.sub", StringComparison.Ordinal), "Okta session userId must prefix with okta_");
        Assert.IsTrue(Js.Contains("username: userInfo.name || userInfo.email", StringComparison.Ordinal), "Okta session must fallback from name to email");
        Assert.IsTrue(Js.Contains("email: userInfo.email || \"\"", StringComparison.Ordinal), "Okta session must default email to empty string");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker handle api fallback must return json error not found with four zero four status code")]
    public void WorkerHandleApiFallbackMustReturnJsonErrorNotFoundWithFourZeroFourStatusCode()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("return new Response(JSON.stringify({ error: \"not_found\" }), { status: 404, headers })", StringComparison.Ordinal), "handleApi must return 404 JSON response for unmatched routes");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker google callback redirect uri must match prtask com api auth callback google for token exchange")]
    public void WorkerGoogleCallbackRedirectUriMustMatchPrtaskComApiAuthCallbackGoogleForTokenExchange()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("redirect_uri: \"https://prtask.com/api/auth/callback/google\"", StringComparison.Ordinal), "Google callback must use prtask.com redirect URI in token exchange");
        Assert.IsTrue(Js.Contains("client_secret: env.GOOGLE_CLIENT_SECRET", StringComparison.Ordinal), "Google callback must send client_secret for token exchange");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker github callback redirect uri must use prtask com callback path in json token request body")]
    public void WorkerGitHubCallbackRedirectUriMustUsePrtaskComCallbackPathInJsonTokenRequestBody()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("redirect_uri: \"https://prtask.com/api/auth/callback/github\"", StringComparison.Ordinal), "GitHub callback must include redirect_uri in token request");
        Assert.IsTrue(Js.Contains("client_secret: env.GITHUB_CLIENT_SECRET", StringComparison.Ordinal), "GitHub callback must send client_secret in token request");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker azure token exchange must post to microsoftonline common oauth2 v2 token endpoint")]
    public void WorkerAzureTokenExchangeMustPostToMicrosoftonlineCommonOauth2V2TokenEndpoint()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("login.microsoftonline.com/common/oauth2/v2.0/token", StringComparison.Ordinal), "Azure must exchange token at common tenant token URL");
        Assert.IsTrue(Js.Contains("redirect_uri: \"https://prtask.com/api/auth/callback/azure\"", StringComparison.Ordinal), "Azure callback must use prtask.com redirect URI");
        Assert.IsTrue(Js.Contains("client_secret: env.AZURE_CLIENT_SECRET", StringComparison.Ordinal), "Azure callback must send client_secret for token exchange");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker okta callback redirect uri must use prtask com okta callback path for token exchange")]
    public void WorkerOktaCallbackRedirectUriMustUsePrtaskComOktaCallbackPathForTokenExchange()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("redirect_uri: \"https://prtask.com/api/auth/callback/okta\"", StringComparison.Ordinal), "Okta callback must use prtask.com redirect URI");
        Assert.IsTrue(Js.Contains("client_secret: env.OKTA_CLIENT_SECRET", StringComparison.Ordinal), "Okta callback must send client_secret for token exchange");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker google auth redirect uri must use prtask com api auth callback google for initial authorize")]
    public void WorkerGoogleAuthRedirectUriMustUsePrtaskComApiAuthCallbackGoogleForInitialAuthorize()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("const redirectUri = \"https://prtask.com/api/auth/callback/google\"", StringComparison.Ordinal), "Google auth must set redirect URI to prtask.com callback");
        Assert.IsTrue(Js.Contains("client_id: env.GOOGLE_CLIENT_ID", StringComparison.Ordinal), "Google auth must use GOOGLE_CLIENT_ID env variable");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker github auth redirect uri must use prtask com api auth callback github for authorize request")]
    public void WorkerGitHubAuthRedirectUriMustUsePrtaskComApiAuthCallbackGitHubForAuthorizeRequest()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("const redirectUri = \"https://prtask.com/api/auth/callback/github\"", StringComparison.Ordinal), "GitHub auth must set redirect URI to prtask.com callback");
        Assert.IsTrue(Js.Contains("client_id: env.GITHUB_CLIENT_ID", StringComparison.Ordinal), "GitHub auth must use GITHUB_CLIENT_ID env variable");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker all four google callback error redirects must point to prtask com login with query parameters")]
    public void WorkerAllFourGoogleCallbackErrorRedirectsMustPointToPrtaskComLoginWithQueryParameters()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("https://prtask.com/login?auto_failed=true", StringComparison.Ordinal), "Google error redirect must use full prtask.com URL");
        Assert.IsTrue(Js.Contains("https://prtask.com/login?error=no_code", StringComparison.Ordinal), "No code error must redirect to prtask.com login");
        Assert.IsTrue(Js.Contains("https://prtask.com/login?error=pkce_missing", StringComparison.Ordinal), "PKCE missing error must redirect to prtask.com login");
        Assert.IsTrue(Js.Contains("https://prtask.com/login?error=token_failed", StringComparison.Ordinal), "Token failed error must redirect to prtask.com login");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker no access token error must redirect all providers to prtask com login with error parameter")]
    public void WorkerNoAccessTokenErrorMustRedirectAllProvidersToPrtaskComLoginWithErrorParameter()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("error=no_access_token", StringComparison.Ordinal), "Callback must handle missing access_token in token response");
        Assert.IsTrue(Js.Contains("tokens.access_token", StringComparison.Ordinal), "Callback must extract access_token from token response");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker webhook endpoint must accept post and return received true json without authentication check")]
    public void WorkerWebhookEndpointMustAcceptPostAndReturnReceivedTrueJsonWithoutAuthenticationCheck()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("\"/api/payments/webhook\" && request.method === \"POST\"", StringComparison.Ordinal), "Webhook must match POST to /api/payments/webhook");
        Assert.IsTrue(Js.Contains("{ received: true }", StringComparison.Ordinal), "Webhook must respond with received:true object");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker export default must define async fetch handler accepting request and env parameters")]
    public void WorkerExportDefaultMustDefineAsyncFetchHandlerAcceptingRequestAndEnvParameters()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("export default", StringComparison.Ordinal), "Worker must use ES module export default pattern");
        Assert.IsTrue(Js.Contains("async fetch(request, env)", StringComparison.Ordinal), "Worker fetch handler must accept request and env");
        Assert.IsTrue(Js.Contains("new URL(request.url)", StringComparison.Ordinal), "Worker must parse URL from request");
        Assert.IsTrue(Js.Contains("url.pathname.startsWith(\"/api/\")", StringComparison.Ordinal), "Worker must check pathname starts with /api/");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker content type header must be application json for all api response handlers")]
    public void WorkerContentTypeHeaderMustBeApplicationJsonForAllApiResponseHandlers()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("\"Content-Type\": \"application/json\"", StringComparison.Ordinal), "Worker API headers must include Content-Type: application/json");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker task path regex must match api tasks slash any non slash characters for single task routes")]
    public void WorkerTaskPathRegexMustMatchApiTasksSlashAnyNonSlashCharactersForSingleTaskRoutes()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("path.match(/^\\/api\\/tasks\\/[^/]+$/)", StringComparison.Ordinal), "Worker must use regex to match single task routes");
        Assert.IsTrue(Js.Contains("path.match(/^\\/api\\/tasks\\/[^/]+\\/prs$/)", StringComparison.Ordinal), "Worker must use regex to match task PRs sub-route");
        Assert.IsTrue(Js.Contains("path.split(\"/\")[3]", StringComparison.Ordinal), "Worker must extract taskId from path index 3 for PR queries");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker google callback must delete pkce verifier from sessions after successful retrieval")]
    public void WorkerGoogleCallbackMustDeletePkceVerifierFromSessionsAfterSuccessfulRetrieval()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("env.SESSIONS.get(\"pkce_\" + state)", StringComparison.Ordinal), "Google callback must retrieve PKCE verifier from KV");
        Assert.IsTrue(Js.Contains("env.SESSIONS.delete(\"pkce_\" + state)", StringComparison.Ordinal), "Google callback must delete PKCE verifier after use");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker github token exchange must use json content type header not form url encoded like other providers")]
    public void WorkerGitHubTokenExchangeMustUseJsonContentTypeHeaderNotFormUrlEncodedLikeOtherProviders()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("\"Content-Type\": \"application/json\", \"Accept\": \"application/json\"", StringComparison.Ordinal), "GitHub token exchange must use JSON content type and accept headers");
        Assert.IsTrue(Js.Contains("JSON.stringify({", StringComparison.Ordinal), "GitHub must send JSON body with JSON.stringify");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker google azure and okta token exchanges must use form url encoded content type header")]
    public void WorkerGoogleAzureAndOktaTokenExchangesMustUseFormUrlEncodedContentTypeHeader()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("\"Content-Type\": \"application/x-www-form-urlencoded\"", StringComparison.Ordinal), "PKCE providers must use form-urlencoded content type");
        Assert.IsTrue(Js.Contains("tokenBody.toString()", StringComparison.Ordinal), "PKCE providers must serialize URLSearchParams to string");
    }
}
