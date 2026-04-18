namespace PrTask.Domain.Constants;
public static class OAuthConstants
{
    public const string ParamClientId = "client_id";
    public const string ParamClientSecret = "client_secret";
    public const string ParamRedirectUri = "redirect_uri";
    public const string ParamCode = "code";
    public const string ParamCodeChallenge = "code_challenge";
    public const string ParamCodeChallengeMethod = "code_challenge_method";
    public const string ParamCodeVerifier = "code_verifier";
    public const string ParamResponseType = "response_type";
    public const string ParamScope = "scope";
    public const string ParamGrantType = "grant_type";
    public const string ParamPrompt = "prompt";
    public const string GrantTypeAuthorizationCode = "authorization_code";
    public const string PromptNone = "none";
    public const string TokenPropertyAccessToken = "access_token";
    public const string ClaimAvatarUrl = "avatar_url";
    public const string UserInfoPropertySub = "sub";
    public const string UserInfoPropertyName = "name";
    public const string UserInfoPropertyEmail = "email";
    public const string UserInfoPropertyPicture = "picture";
    public const string AuthSchemeBearer = "Bearer";
    public const string ChallengeMethodS256 = "S256";
    public const string ResponseTypeCode = "code";
    public const string PkceCookiePrefix = "pkce_";
    public const int PkceByteLength = 32;
    public const int PkceCookieMaxAgeMinutes = 10;
    public const string ParamState = "state";
    public const string ParamStatePrefix = "&state=";
    public const string TokenPropertyRefreshToken = "refresh_token";
    public const string TokenPropertyIdToken = "id_token";
    public const string TokenPropertyExpiresIn = "expires_in";
    public const string TokenPropertyAud = "aud";
    public const string BearerScheme = "Bearer";
    public static string GenerateCodeVerifier()
    {
        var Bytes = new byte[PkceByteLength];
        System.Security.Cryptography.RandomNumberGenerator.Fill(Bytes);
        return Convert.ToBase64String(Bytes)
            .TrimEnd('=')
            .Replace('+', '-')
            .Replace('/', '_');
    }
    public static string ComputeCodeChallenge(string CodeVerifier)
    {
        var Hash = System.Security.Cryptography.SHA256.HashData(
            System.Text.Encoding.ASCII.GetBytes(CodeVerifier));
        return Convert.ToBase64String(Hash)
            .TrimEnd('=')
            .Replace('+', '-')
            .Replace('/', '_');
    }
}
