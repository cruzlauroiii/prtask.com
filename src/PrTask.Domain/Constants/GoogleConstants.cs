namespace PrTask.Domain.Constants;
public static class GoogleConstants
{
    public const string AuthorizeUrl = "https://accounts.google.com/o/oauth2/v2/auth";
    public const string TokenUrl = "https://oauth2.googleapis.com/token";
    public const string UserInfoUrl = "https://www.googleapis.com/oauth2/v3/userinfo";
    public const string TokenInfoUrl = "https://oauth2.googleapis.com/tokeninfo";
    public const string TokenInfoQueryFormat = "?id_token={0}";
    public const string RequiredScope = "openid email profile";
    public const string ResponseType = "code";
    public const string CodeChallengeMethod = "S256";
    public const string ConfigClientId = "Google:ClientId";
    public const string ConfigClientSecret = "Google:ClientSecret";
    public const string LogTokenExchangeFailed = "Google token exchange failed: {StatusCode} {Body}";
    public const string LogUserInfoFailed = "Google userinfo failed: {StatusCode}";
    public const string HttpClientName = "Google";
    public static string BuildAuthorizeEndpoint(string RedirectUri, string CodeChallenge, string? State)
    {
        var Url = $"{AuthorizeUrl}?{OAuthConstants.ParamClientId}=&{OAuthConstants.ParamRedirectUri}={Uri.EscapeDataString(RedirectUri)}&{OAuthConstants.ParamResponseType}={ResponseType}&{OAuthConstants.ParamScope}={Uri.EscapeDataString(RequiredScope)}&{OAuthConstants.ParamCodeChallengeMethod}={CodeChallengeMethod}&{OAuthConstants.ParamCodeChallenge}={CodeChallenge}";
        if (!string.IsNullOrEmpty(State))
        {
            Url += $"{OAuthConstants.ParamStatePrefix}{Uri.EscapeDataString(State)}";
        }
        return Url;
    }
    public static string BuildTokenBody(string Code, string RedirectUri, string CodeVerifier) =>
        $"{OAuthConstants.ParamGrantType}={OAuthConstants.GrantTypeAuthorizationCode}&{OAuthConstants.ParamCode}={Uri.EscapeDataString(Code)}&{OAuthConstants.ParamRedirectUri}={Uri.EscapeDataString(RedirectUri)}&{OAuthConstants.ParamCodeVerifier}={Uri.EscapeDataString(CodeVerifier)}";
}
