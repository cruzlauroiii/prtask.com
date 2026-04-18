namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Server program must configure cookie authentication with httponly secure and sliding expiration")]
    public void ServerProgramMustConfigureCookieAuthenticationWithHttpOnlySecureAndSlidingExpiration()
    {
        var Code = ReadSourceFile("PrTask.Server", "Program.cs");
        Assert.IsTrue(Code.Contains("CookieAuthenticationDefaults", StringComparison.Ordinal), "Server must use cookie authentication scheme");
        Assert.IsTrue(Code.Contains("HttpOnly = true", StringComparison.Ordinal), "Auth cookie must be HttpOnly to prevent XSS");
        Assert.IsTrue(Code.Contains("SecurePolicy", StringComparison.Ordinal), "Auth cookie must enforce HTTPS via SecurePolicy");
        Assert.IsTrue(Code.Contains("SlidingExpiration = true", StringComparison.Ordinal), "Auth cookie must have sliding expiration");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Server program must configure cors policy allowing only app domain with credentials support")]
    public void ServerProgramMustConfigureCorsPolicyAllowingOnlyAppDomainWithCredentialsSupport()
    {
        var Code = ReadSourceFile("PrTask.Server", "Program.cs");
        Assert.IsTrue(Code.Contains("AddCors", StringComparison.Ordinal), "Server must configure CORS");
        Assert.IsTrue(Code.Contains("AllowCredentials", StringComparison.Ordinal), "CORS must allow credentials for cookie auth");
        Assert.IsTrue(Code.Contains("AppConstants.AppDomain", StringComparison.Ordinal), "CORS must restrict origins to app domain");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Server program must register infrastructure services and map all endpoint groups correctly")]
    public void ServerProgramMustRegisterInfrastructureServicesAndMapAllEndpointGroupsCorrectly()
    {
        var Code = ReadSourceFile("PrTask.Server", "Program.cs");
        Assert.IsTrue(Code.Contains("AddInfrastructure", StringComparison.Ordinal), "Server must register infrastructure services");
        Assert.IsTrue(Code.Contains("MapAuthEndpoints", StringComparison.Ordinal), "Server must map auth endpoints");
        Assert.IsTrue(Code.Contains("MapTaskEndpoints", StringComparison.Ordinal), "Server must map task endpoints");
        Assert.IsTrue(Code.Contains("MapPullRequestEndpoints", StringComparison.Ordinal), "Server must map pull request endpoints");
        Assert.IsTrue(Code.Contains("MapPaymentEndpoints", StringComparison.Ordinal), "Server must map payment endpoints");
        Assert.IsTrue(Code.Contains("MapLeaderboardEndpoints", StringComparison.Ordinal), "Server must map leaderboard endpoints");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Server program must use correct middleware order with cors then static files then auth")]
    public void ServerProgramMustUseCorrectMiddlewareOrderWithCorsThenStaticFilesThenAuth()
    {
        var Code = ReadSourceFile("PrTask.Server", "Program.cs");
        var CorsIndex = Code.IndexOf("UseCors", StringComparison.Ordinal);
        var StaticIndex = Code.IndexOf("UseStaticFiles", StringComparison.Ordinal);
        var AuthIndex = Code.IndexOf("UseAuthentication", StringComparison.Ordinal);
        var AuthzIndex = Code.IndexOf("UseAuthorization", StringComparison.Ordinal);
        Assert.IsTrue(CorsIndex < StaticIndex, "CORS must be configured before static files");
        Assert.IsTrue(StaticIndex < AuthIndex, "Static files must be configured before authentication");
        Assert.IsTrue(AuthIndex < AuthzIndex, "Authentication must be configured before authorization");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Server program must return 401 unauthorized instead of redirect for unauthenticated api calls")]
    public void ServerProgramMustReturn401UnauthorizedInsteadOfRedirectForUnauthenticatedApiCalls()
    {
        var Code = ReadSourceFile("PrTask.Server", "Program.cs");
        Assert.IsTrue(Code.Contains("OnRedirectToLogin", StringComparison.Ordinal), "Server must override login redirect behavior");
        Assert.IsTrue(Code.Contains("Status401Unauthorized", StringComparison.Ordinal), "Server must return 401 for API calls instead of redirect");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Server program must set auth cookie expiration to thirty days with same site lax policy")]
    public void ServerProgramMustSetAuthCookieExpirationToThirtyDaysWithSameSiteLaxPolicy()
    {
        var Code = ReadSourceFile("PrTask.Server", "Program.cs");
        Assert.IsTrue(Code.Contains("FromDays(30)", StringComparison.Ordinal), "Auth cookie must expire after 30 days");
        Assert.IsTrue(Code.Contains("SameSite", StringComparison.Ordinal), "Auth cookie must set SameSite policy");
        Assert.IsTrue(Code.Contains("Lax", StringComparison.Ordinal), "Auth cookie SameSite must be Lax for OAuth redirects");
    }
}
