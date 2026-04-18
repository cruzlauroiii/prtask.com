namespace PrTask.Domain.Constants;
public static class E2ESsoConstants
{
    public const string GoogleButtonCss = ".google-login";
    public const string GitHubButtonCss = ".github-login";
    public const string AzureButtonCss = ".azure-login";
    public const string OktaButtonCss = ".okta-login";
    public const string GoogleAuthDomain = "accounts.google.com";
    public const string GitHubAuthDomain = "github.com";
    public const string AzureAuthDomain = "login.microsoftonline.com";
    public const string OktaAuthDomain = "okta.com";
    public const string GoogleAuthPathPrefix = "/o/oauth2";
    public const string GitHubAuthPathPrefix = "/login/oauth";
    public const string AzureAuthPathPrefix = "/common/oauth2";
    public const string OktaAuthPathPrefix = "/oauth2";
    public const int SsoRedirectTimeoutMs = 15000;
    public const string AssertLoginPageLoaded = "SSO: Login page must load with heading";
    public const string AssertButtonVisible = "SSO: {0} button must be visible on login page";
    public const string AssertRedirectStarted = "SSO: Clicking {0} must redirect to {1}";
    public const string AssertOAuthPageLoaded = "SSO: {0} OAuth page must load (URL contains {1})";
    public const string DashboardHeadingSelector = "h1";
    public const string ConnectedStatusCss = ".connected-status";
    public const string ConnectedCss = ".status-connected";
    public const string SsoTestUserId = "e2e-sso-user";
    public const string SsoTestUsername = "E2E SSO User";
    public const string AssertProviderConnected = "SSO: {0} must show as Connected on Settings page";
    public const string AssertProviderNotConnected = "SSO: {0} must show as Not connected before login";
    public const string AssertSettingsLoaded = "SSO: Settings page must load";
    public const string AssertUserLoggedIn = "SSO: User must be logged in after dev login";
}
