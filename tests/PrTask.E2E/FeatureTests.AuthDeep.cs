namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints must generate pkce verifier and challenge using sha256 and base64url encoding")]
    public void AuthEndpointsMustGeneratePkceVerifierAndChallengeUsingSha256AndBase64UrlEncoding()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("GeneratePkce", StringComparison.Ordinal), "Must have GeneratePkce helper method");
        Assert.IsTrue(Code.Contains("SHA256.HashData", StringComparison.Ordinal), "Must hash verifier with SHA256");
        Assert.IsTrue(Code.Contains("RandomNumberGenerator.GetBytes(32)", StringComparison.Ordinal), "Must generate 32 random bytes for verifier");
        Assert.IsTrue(Code.Contains("TrimEnd('=')", StringComparison.Ordinal), "Must trim base64 padding for URL safety");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints must store pkce verifier in httponly secure cookie with ten minute max age")]
    public void AuthEndpointsMustStorePkceVerifierInHttpOnlySecureCookieWithTenMinuteMaxAge()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("PkceCookieOptions", StringComparison.Ordinal), "Must use PkceCookieOptions for PKCE cookies");
        Assert.IsTrue(Code.Contains("HttpOnly = true", StringComparison.Ordinal), "PKCE cookie must be HttpOnly");
        Assert.IsTrue(Code.Contains("Secure = true", StringComparison.Ordinal), "PKCE cookie must require HTTPS");
        Assert.IsTrue(Code.Contains("FromMinutes(10)", StringComparison.Ordinal), "PKCE cookie must expire in 10 minutes");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints must map oidc endpoints for google azure and okta with proper route constants")]
    public void AuthEndpointsMustMapOidcEndpointsForGoogleAzureAndOktaWithProperRouteConstants()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("RouteConstants.ApiAuthGoogle", StringComparison.Ordinal), "Must map Google auth endpoint");
        Assert.IsTrue(Code.Contains("RouteConstants.ApiAuthAzure", StringComparison.Ordinal), "Must map Azure auth endpoint");
        Assert.IsTrue(Code.Contains("RouteConstants.ApiAuthOkta", StringComparison.Ordinal), "Must map Okta auth endpoint");
        Assert.IsTrue(Code.Contains("RouteConstants.ApiAuthCallbackGoogle", StringComparison.Ordinal), "Must map Google callback");
        Assert.IsTrue(Code.Contains("RouteConstants.ApiAuthCallbackAzure", StringComparison.Ordinal), "Must map Azure callback");
        Assert.IsTrue(Code.Contains("RouteConstants.ApiAuthCallbackOkta", StringComparison.Ordinal), "Must map Okta callback");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints must exchange github code for access token using form url encoded content")]
    public void AuthEndpointsMustExchangeGitHubCodeForAccessTokenUsingFormUrlEncodedContent()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("ExchangeGitHubCodeAsync", StringComparison.Ordinal), "Must have ExchangeGitHubCodeAsync helper");
        Assert.IsTrue(Code.Contains("FormUrlEncodedContent", StringComparison.Ordinal), "Must use form URL encoded content for token exchange");
        Assert.IsTrue(Code.Contains("client_id", StringComparison.Ordinal), "Must send client_id in token request");
        Assert.IsTrue(Code.Contains("client_secret", StringComparison.Ordinal), "Must send client_secret in token request");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints must exchange oidc code with code verifier for pkce token validation")]
    public void AuthEndpointsMustExchangeOidcCodeWithCodeVerifierForPkceTokenValidation()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("ExchangeOidcCodeAsync", StringComparison.Ordinal), "Must have ExchangeOidcCodeAsync helper");
        Assert.IsTrue(Code.Contains("code_verifier", StringComparison.Ordinal), "Must send code_verifier for PKCE validation");
        Assert.IsTrue(Code.Contains("authorization_code", StringComparison.Ordinal), "Must use authorization_code grant type");
        Assert.IsTrue(Code.Contains("redirect_uri", StringComparison.Ordinal), "Must send redirect_uri in token request");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints must fetch github user profile with bearer token and prtask user agent")]
    public void AuthEndpointsMustFetchGitHubUserProfileWithBearerTokenAndPrtaskUserAgent()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("FetchGitHubUserAsync", StringComparison.Ordinal), "Must have FetchGitHubUserAsync helper");
        Assert.IsTrue(Code.Contains("UserAgent", StringComparison.Ordinal), "Must set User-Agent header for GitHub API");
        Assert.IsTrue(Code.Contains("AppConstants.AppName", StringComparison.Ordinal), "User-Agent must use AppName");
        Assert.IsTrue(Code.Contains("GitHubConstants.UserApiUrl", StringComparison.Ordinal), "Must call GitHub user API URL");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints must deserialize github response using snake case lower json naming policy")]
    public void AuthEndpointsMustDeserializeGitHubResponseUsingSnakeCaseLowerJsonNamingPolicy()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("JsonNamingPolicy.SnakeCaseLower", StringComparison.Ordinal), "Must use SnakeCaseLower for GitHub JSON deserialization");
        Assert.IsTrue(Code.Contains("GitHubJsonOptions", StringComparison.Ordinal), "Must define GitHubJsonOptions for consistent deserialization");
        Assert.IsTrue(Code.Contains("ReadFromJsonAsync<GitHubUserResponse>", StringComparison.Ordinal), "Must deserialize to GitHubUserResponse record");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints must sign in user with name identifier and name claims identity")]
    public void AuthEndpointsMustSignInUserWithNameIdentifierAndNameClaimsIdentity()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("SignInUserAsync", StringComparison.Ordinal), "Must have SignInUserAsync helper method");
        Assert.IsTrue(Code.Contains("ClaimTypes.NameIdentifier", StringComparison.Ordinal), "Must create NameIdentifier claim with user ID");
        Assert.IsTrue(Code.Contains("ClaimTypes.Name", StringComparison.Ordinal), "Must create Name claim with username");
        Assert.IsTrue(Code.Contains("ClaimsIdentity", StringComparison.Ordinal), "Must create ClaimsIdentity for cookie auth");
        Assert.IsTrue(Code.Contains("ClaimsPrincipal", StringComparison.Ordinal), "Must create ClaimsPrincipal for sign-in");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints must add avatar url claim when user has avatar for profile display")]
    public void AuthEndpointsMustAddAvatarUrlClaimWhenUserHasAvatarForProfileDisplay()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("avatar_url", StringComparison.Ordinal), "Must use avatar_url custom claim name");
        Assert.IsTrue(Code.Contains("AvatarUrl is not null", StringComparison.Ordinal), "Must check if avatar URL is not null");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints must redirect to dashboard after successful github oauth callback flow")]
    public void AuthEndpointsMustRedirectToDashboardAfterSuccessfulGitHubOauthCallbackFlow()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("Results.Redirect(RouteConstants.Dashboard)", StringComparison.Ordinal), "Must redirect to dashboard after auth success");
        Assert.IsTrue(Code.Contains("CreateOrUpdateFromGitHubAsync", StringComparison.Ordinal), "Must call CreateOrUpdateFromGitHubAsync on callback");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints must redirect to login with error parameter on authentication failure")]
    public void AuthEndpointsMustRedirectToLoginWithErrorParameterOnAuthenticationFailure()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("error=auth_failed", StringComparison.Ordinal), "Must redirect with auth_failed error on token failure");
        Assert.IsTrue(Code.Contains("error=profile_failed", StringComparison.Ordinal), "Must redirect with profile_failed on user fetch failure");
        Assert.IsTrue(Code.Contains("error=pkce_missing", StringComparison.Ordinal), "Must redirect with pkce_missing when verifier absent");
        Assert.IsTrue(Code.Contains("error=no_code", StringComparison.Ordinal), "Must redirect with no_code when code is empty");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints must map post logout route that signs out and returns ok status result")]
    public void AuthEndpointsMustMapPostLogoutRouteThatSignsOutAndReturnsOkStatusResult()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("MapPost(RouteConstants.ApiAuthLogout", StringComparison.Ordinal), "Logout must use POST method for CSRF protection");
        Assert.IsTrue(Code.Contains("SignOutAsync", StringComparison.Ordinal), "Logout must call SignOutAsync on HttpContext");
        Assert.IsTrue(Code.Contains("Results.Ok()", StringComparison.Ordinal), "Logout must return 200 OK");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints must map get me route returning user id username and avatar from claims")]
    public void AuthEndpointsMustMapGetMeRouteReturningUserIdUsernameAndAvatarFromClaims()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("MapGet(RouteConstants.ApiAuthMe", StringComparison.Ordinal), "Me endpoint must use GET method");
        Assert.IsTrue(Code.Contains("IsAuthenticated", StringComparison.Ordinal), "Me must check authentication status");
        Assert.IsTrue(Code.Contains("Results.Unauthorized()", StringComparison.Ordinal), "Me must return 401 when not authenticated");
        Assert.IsTrue(Code.Contains("FindFirstValue", StringComparison.Ordinal), "Me must extract claims using FindFirstValue");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints must support google auto login with prompt none query parameter")]
    public void AuthEndpointsMustSupportGoogleAutoLoginWithPromptNoneQueryParameter()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("prompt=none", StringComparison.Ordinal), "Must add prompt=none for silent Google re-auth");
        Assert.IsTrue(Code.Contains("Auto == true", StringComparison.Ordinal), "Must check Auto query parameter for silent login");
        Assert.IsTrue(Code.Contains("auto_failed=true", StringComparison.Ordinal), "Must redirect with auto_failed on error for silent flow");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints must fetch oidc user info by parsing sub name email and picture from json")]
    public void AuthEndpointsMustFetchOidcUserInfoByParsingSubNameEmailAndPictureFromJson()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("FetchOidcUserInfoAsync", StringComparison.Ordinal), "Must have FetchOidcUserInfoAsync helper");
        Assert.IsTrue(Code.Contains("TryGetProperty(\"sub\"", StringComparison.Ordinal), "Must extract sub claim for subject ID");
        Assert.IsTrue(Code.Contains("TryGetProperty(\"name\"", StringComparison.Ordinal), "Must extract name claim");
        Assert.IsTrue(Code.Contains("TryGetProperty(\"email\"", StringComparison.Ordinal), "Must extract email claim");
        Assert.IsTrue(Code.Contains("TryGetProperty(\"picture\"", StringComparison.Ordinal), "Must extract picture claim for avatar");
    }
}
