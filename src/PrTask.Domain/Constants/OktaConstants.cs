namespace PrTask.Domain.Constants;
public static class OktaConstants
{
    public const string AuthorizePathTemplate = "/oauth2/default/v1/authorize";
    public const string TokenPathTemplate = "/oauth2/default/v1/token";
    public const string UserInfoPathTemplate = "/oauth2/default/v1/userinfo";
    public const string RequiredScope = "openid email profile";
    public const string ResponseType = "code";
    public const string CodeChallengeMethod = "S256";
}
