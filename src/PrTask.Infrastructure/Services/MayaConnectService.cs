using System.Net.Http.Headers;
using System.Text;
using Microsoft.Extensions.Configuration;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Infrastructure.Services;
public class MayaConnectService(IHttpClientFactory HttpFactory, IConfiguration Configuration, ILogger<MayaConnectService> Logger) : IMayaConnectService
{
    public Task<string> AuthorizeAsync(string RedirectUri, string Scope)
    {
        var ClientId = Configuration[MayaConstants.ConfigConnectClientId] ?? string.Empty;
        var State = Guid.NewGuid().ToString();
        var Redirect = FormatStrings.MayaConnectAuthorizeRedirect(
            MayaConstants.ConnectSandboxBaseUrl, ClientId, RedirectUri, Scope, State);
        return Task.FromResult(Redirect);
    }
    public async Task<string> ExchangeTokenAsync(string AuthorizationCode, string RedirectUri)
    {
        var Client = CreateClient();
        var Body = FormatStrings.MayaConnectTokenBody(
            OAuthConstants.GrantTypeAuthorizationCode, AuthorizationCode, RedirectUri);
        var Content = new StringContent(Body, Encoding.UTF8, AppConstants.ContentTypeFormUrlEncoded);
        var Response = await Client.PostAsync(MayaConstants.ConnectTokenPath, Content);
        return await ReadResponseOrEmptyAsync(Response);
    }
    public async Task<string> RefreshTokenAsync(string RefreshToken)
    {
        var Client = CreateClient();
        var Body = FormatStrings.MayaConnectRefreshBody(RefreshToken);
        var Content = new StringContent(Body, Encoding.UTF8, AppConstants.ContentTypeFormUrlEncoded);
        var Response = await Client.PostAsync(MayaConstants.ConnectTokenPath, Content);
        return await ReadResponseOrEmptyAsync(Response);
    }
    public async Task<string> GetUserInfoAsync(string AccessToken)
    {
        var Client = HttpFactory.CreateClient(MayaConstants.ConnectHttpClientName);
        Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(MayaConstants.BearerScheme, AccessToken);
        var Response = await Client.GetAsync(MayaConstants.ConnectUserInfoPath);
        return await ReadResponseOrEmptyAsync(Response);
    }
    public async Task<string> GetJwkAsync()
    {
        var Client = HttpFactory.CreateClient(MayaConstants.ConnectHttpClientName);
        var Response = await Client.GetAsync(MayaConstants.ConnectJwkPath);
        return await ReadResponseOrEmptyAsync(Response);
    }
    private HttpClient CreateClient()
    {
        var Client = HttpFactory.CreateClient(MayaConstants.ConnectHttpClientName);
        var ClientId = Configuration[MayaConstants.ConfigConnectClientId] ?? string.Empty;
        var ClientSecret = Configuration[MayaConstants.ConfigConnectClientSecret] ?? string.Empty;
        if (!string.IsNullOrEmpty(ClientId))
        {
            var Credentials = FormatStrings.BasicAuthPayload(ClientId, ClientSecret);
            var Encoded = Convert.ToBase64String(Encoding.ASCII.GetBytes(Credentials));
            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(AppConstants.AuthSchemeBasic, Encoded);
        }
        return Client;
    }
    private async Task<string> ReadResponseOrEmptyAsync(HttpResponseMessage Response)
    {
        if (!Response.IsSuccessStatusCode)
        {
            Logger.LogError("Maya Connect request failed: {Status}", Response.StatusCode);
            return string.Empty;
        }
        return await Response.Content.ReadAsStringAsync();
    }
}
