namespace PrTask.Application.Services;
public interface IMayaConnectService
{
    Task<string> AuthorizeAsync(string RedirectUri, string Scope);
    Task<string> ExchangeTokenAsync(string AuthorizationCode, string RedirectUri);
    Task<string> RefreshTokenAsync(string RefreshToken);
    Task<string> GetUserInfoAsync(string AccessToken);
    Task<string> GetJwkAsync();
}
