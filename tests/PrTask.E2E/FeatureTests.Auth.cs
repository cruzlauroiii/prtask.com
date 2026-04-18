using System.Net;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints must map github google azure and okta sso provider login routes")]
    public void AuthEndpointsMustMapGitHubGoogleAzureAndOktaSsoProviderLoginRoutes()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("ApiAuthGitHub", StringComparison.Ordinal), "AuthEndpoints must map GitHub login route");
        Assert.IsTrue(Code.Contains("ApiAuthGoogle", StringComparison.Ordinal), "AuthEndpoints must map Google login route");
        Assert.IsTrue(Code.Contains("ApiAuthAzure", StringComparison.Ordinal), "AuthEndpoints must map Azure AD login route");
        Assert.IsTrue(Code.Contains("ApiAuthOkta", StringComparison.Ordinal), "AuthEndpoints must map Okta login route");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints must use pkce code challenge with s256 method for all oidc providers")]
    public void AuthEndpointsMustUsePkceCodeChallengeWithS256MethodForAllOidcProviders()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("GeneratePkce", StringComparison.Ordinal), "AuthEndpoints must generate PKCE verifier and challenge");
        Assert.IsTrue(Code.Contains("code_challenge", StringComparison.Ordinal), "AuthEndpoints must include code_challenge in auth URL");
        Assert.IsTrue(Code.Contains("code_verifier", StringComparison.Ordinal), "AuthEndpoints must send code_verifier in token exchange");
        Assert.IsTrue(Code.Contains("S256", StringComparison.Ordinal), "AuthEndpoints must use SHA256 code challenge method");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints must use cookie authentication with claims based identity for signed in users")]
    public void AuthEndpointsMustUseCookieAuthenticationWithClaimsBasedIdentityForSignedInUsers()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("CookieAuthenticationDefaults", StringComparison.Ordinal), "AuthEndpoints must use cookie authentication scheme");
        Assert.IsTrue(Code.Contains("ClaimsIdentity", StringComparison.Ordinal), "AuthEndpoints must create claims identity for users");
        Assert.IsTrue(Code.Contains("NameIdentifier", StringComparison.Ordinal), "AuthEndpoints must store user ID in NameIdentifier claim");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth me endpoint must return user id username and avatar url from authenticated claims")]
    public void AuthMeEndpointMustReturnUserIdUsernameAndAvatarUrlFromAuthenticatedClaims()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("ApiAuthMe", StringComparison.Ordinal), "AuthEndpoints must map the /api/auth/me route");
        Assert.IsTrue(Code.Contains("UserId", StringComparison.Ordinal), "Auth me must return UserId from claims");
        Assert.IsTrue(Code.Contains("Username", StringComparison.Ordinal), "Auth me must return Username from claims");
        Assert.IsTrue(Code.Contains("avatar_url", StringComparison.Ordinal), "Auth me must return avatar URL from claims");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Auth endpoints must store pkce verifier in httponly secure cookie with ten minute expiry")]
    public void AuthEndpointsMustStorePkceVerifierInHttpOnlySecureCookieWithTenMinuteExpiry()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Code.Contains("HttpOnly = true", StringComparison.Ordinal), "PKCE cookie must be HttpOnly to prevent XSS");
        Assert.IsTrue(Code.Contains("Secure = true", StringComparison.Ordinal), "PKCE cookie must be Secure for HTTPS only");
        Assert.IsTrue(Code.Contains("SameSite", StringComparison.Ordinal), "PKCE cookie must set SameSite policy");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("GitHub constants must define authorize url token url and user api url for oauth flow")]
    public void GitHubConstantsMustDefineAuthorizeUrlTokenUrlAndUserApiUrlForOauthFlow()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "GitHubConstants.cs");
        Assert.IsTrue(Code.Contains("AuthorizeUrl", StringComparison.Ordinal), "GitHubConstants must have OAuth authorize URL");
        Assert.IsTrue(Code.Contains("TokenUrl", StringComparison.Ordinal), "GitHubConstants must have token exchange URL");
        Assert.IsTrue(Code.Contains("UserApiUrl", StringComparison.Ordinal), "GitHubConstants must have user API URL");
        Assert.IsTrue(Code.Contains("RequiredScope", StringComparison.Ordinal), "GitHubConstants must define required OAuth scopes");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Google constants must define authorize url token url and userinfo url for oidc flow")]
    public void GoogleConstantsMustDefineAuthorizeUrlTokenUrlAndUserInfoUrlForOidcFlow()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "GoogleConstants.cs");
        Assert.IsTrue(Code.Contains("AuthorizeUrl", StringComparison.Ordinal), "GoogleConstants must have OIDC authorize URL");
        Assert.IsTrue(Code.Contains("TokenUrl", StringComparison.Ordinal), "GoogleConstants must have token exchange URL");
        Assert.IsTrue(Code.Contains("UserInfoUrl", StringComparison.Ordinal), "GoogleConstants must have userinfo URL");
        Assert.IsTrue(Code.Contains("S256", StringComparison.Ordinal), "GoogleConstants must specify S256 code challenge method");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Azure constants must define common tenant authorize url template and microsoft graph userinfo")]
    public void AzureConstantsMustDefineCommonTenantAuthorizeUrlTemplateAndMicrosoftGraphUserInfo()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "AzureConstants.cs");
        Assert.IsTrue(Code.Contains("CommonTenant", StringComparison.Ordinal), "AzureConstants must define common tenant for multi-org support");
        Assert.IsTrue(Code.Contains("AuthorizeUrlTemplate", StringComparison.Ordinal), "AzureConstants must have authorize URL template");
        Assert.IsTrue(Code.Contains("graph.microsoft.com", StringComparison.Ordinal), "AzureConstants must use Microsoft Graph for user info");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Okta constants must define authorize token and userinfo path templates for oidc integration")]
    public void OktaConstantsMustDefineAuthorizeTokenAndUserInfoPathTemplatesForOidcIntegration()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "OktaConstants.cs");
        Assert.IsTrue(Code.Contains("AuthorizePathTemplate", StringComparison.Ordinal), "OktaConstants must have authorize path template");
        Assert.IsTrue(Code.Contains("TokenPathTemplate", StringComparison.Ordinal), "OktaConstants must have token path template");
        Assert.IsTrue(Code.Contains("UserInfoPathTemplate", StringComparison.Ordinal), "OktaConstants must have userinfo path template");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Route constants must define all four sso provider login and callback routes for authentication")]
    public void RouteConstantsMustDefineAllFourSsoProviderLoginAndCallbackRoutesForAuthentication()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Code.Contains("ApiAuthGitHub", StringComparison.Ordinal), "RouteConstants must define GitHub auth route");
        Assert.IsTrue(Code.Contains("ApiAuthGoogle", StringComparison.Ordinal), "RouteConstants must define Google auth route");
        Assert.IsTrue(Code.Contains("ApiAuthAzure", StringComparison.Ordinal), "RouteConstants must define Azure auth route");
        Assert.IsTrue(Code.Contains("ApiAuthOkta", StringComparison.Ordinal), "RouteConstants must define Okta auth route");
        Assert.IsTrue(Code.Contains("ApiAuthCallbackGoogle", StringComparison.Ordinal), "RouteConstants must define Google callback route");
        Assert.IsTrue(Code.Contains("ApiAuthCallbackAzure", StringComparison.Ordinal), "RouteConstants must define Azure callback route");
        Assert.IsTrue(Code.Contains("ApiAuthCallbackOkta", StringComparison.Ordinal), "RouteConstants must define Okta callback route");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("User service interface must support github oauth and oidc user creation or update methods")]
    public void UserServiceInterfaceMustSupportGitHubOauthAndOidcUserCreationOrUpdateMethods()
    {
        var Code = ReadSourceFile("PrTask.Application", "Services", "IUserService.cs");
        Assert.IsTrue(Code.Contains("CreateOrUpdateFromGitHubAsync", StringComparison.Ordinal), "IUserService must handle GitHub OAuth users");
        Assert.IsTrue(Code.Contains("CreateOrUpdateFromOidcAsync", StringComparison.Ordinal), "IUserService must handle OIDC provider users");
        Assert.IsTrue(Code.Contains("GetByGitHubIdAsync", StringComparison.Ordinal), "IUserService must look up users by GitHub ID");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Login page must have sso buttons for github google azure and okta authentication providers")]
    public void LoginPageMustHaveSsoButtonsForGitHubGoogleAzureAndOktaAuthenticationProviders()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "LoginPage.razor");
        Assert.IsTrue(Razor.Contains("github", StringComparison.OrdinalIgnoreCase), "Login page must have GitHub sign-in option");
        Assert.IsTrue(Razor.Contains("google", StringComparison.OrdinalIgnoreCase), "Login page must have Google sign-in option");
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Auth me endpoint must return unauthorized when no authentication cookie is present")]
    public async Task AuthMeEndpointMustReturnUnauthorizedWhenNoAuthenticationCookIsPresentAsync()
    {
        var Response = await ApiClient.GetAsync(RouteConstants.ApiAuthMe);
        Assert.AreEqual(HttpStatusCode.Unauthorized, Response.StatusCode);
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Auth logout endpoint must accept post method and return ok for unauthenticated requests")]
    public async Task AuthLogoutEndpointMustAcceptPostMethodAndReturnOkForUnauthenticatedRequestsAsync()
    {
        var Response = await ApiClient.PostAsync(RouteConstants.ApiAuthLogout, null);
        Assert.AreEqual(HttpStatusCode.OK, Response.StatusCode);
    }
}
