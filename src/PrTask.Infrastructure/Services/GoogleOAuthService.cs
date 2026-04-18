using System.Net.Http.Json;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Infrastructure.Services;
public sealed class GoogleOAuthService(IHttpClientFactory HttpClientFactory) : IGoogleOAuthService
{
    public (string AuthorizeUrl, string CodeVerifier) BuildAuthorizeUrl(string RedirectUri, string? State)
    {
        var CodeVerifier = OAuthConstants.GenerateCodeVerifier();
        var CodeChallenge = OAuthConstants.ComputeCodeChallenge(CodeVerifier);
        var Url = GoogleConstants.BuildAuthorizeEndpoint(RedirectUri, CodeChallenge, State);
        return (Url, CodeVerifier);
    }
    public async Task<GoogleTokenResult?> ExchangeCodeAsync(string Code, string RedirectUri, string CodeVerifier)
    {
        var Http = HttpClientFactory.CreateClient(GoogleConstants.HttpClientName);
        var Body = GoogleConstants.BuildTokenBody(Code, RedirectUri, CodeVerifier);
        var Resp = await Http.PostAsync(GoogleConstants.TokenUrl, new StringContent(Body, System.Text.Encoding.UTF8, new System.Net.Http.Headers.MediaTypeHeaderValue(AppConstants.ContentTypeFormUrlEncoded))).ConfigureAwait(false);
        return Resp.IsSuccessStatusCode ? await Resp.Content.ReadFromJsonAsync<GoogleTokenResult>() : null;
    }
    public async Task<GoogleUserInfo?> GetUserInfoAsync(string AccessToken)
    {
        var Http = HttpClientFactory.CreateClient(GoogleConstants.HttpClientName);
        Http.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(OAuthConstants.BearerScheme, AccessToken);
        return await Http.GetFromJsonAsync<GoogleUserInfo>(GoogleConstants.UserInfoUrl);
    }
    public Task<bool> ValidateIdTokenAsync(string IdToken) => Task.FromResult(!string.IsNullOrEmpty(IdToken));
}
