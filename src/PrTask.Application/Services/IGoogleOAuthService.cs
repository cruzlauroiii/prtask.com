namespace PrTask.Application.Services;
public interface IGoogleOAuthService
{
    (string AuthorizeUrl, string CodeVerifier) BuildAuthorizeUrl(string RedirectUri, string? State);
    Task<GoogleTokenResult?> ExchangeCodeAsync(string Code, string RedirectUri, string CodeVerifier);
    Task<GoogleUserInfo?> GetUserInfoAsync(string AccessToken);
    Task<bool> ValidateIdTokenAsync(string IdToken);
}
