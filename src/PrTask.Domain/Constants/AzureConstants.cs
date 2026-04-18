namespace PrTask.Domain.Constants;
public static class AzureConstants
{
    public const string AuthorizeUrlTemplate = "https://login.microsoftonline.com/{0}/oauth2/v2.0/authorize";
    public const string TokenUrlTemplate = "https://login.microsoftonline.com/{0}/oauth2/v2.0/token";
    public const string UserInfoUrl = "https://graph.microsoft.com/v1.0/me";
    public const string CommonTenant = "common";
    public const string RequiredScope = "openid email profile User.Read";
    public const string ResponseType = "code";
    public const string CodeChallengeMethod = "S256";
}
