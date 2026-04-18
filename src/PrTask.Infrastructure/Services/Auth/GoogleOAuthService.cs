using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Infrastructure.Services.Auth;
public class GoogleOAuthService(IHttpClientFactory HttpFactory, IConfiguration Configuration, ILogger<GoogleOAuthService> Logger) : IGoogleOAuthService
{
    private static readonly JsonSerializerOptions JsonOpts = new() { PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower };
    public (string AuthorizeUrl, string CodeVerifier) BuildAuthorizeUrl(string RedirectUri, string? State)
    {
        var Verifier = GenerateCodeVerifier();
        var Challenge = ComputeCodeChallenge(Verifier);
        var ClientId = Configuration[GoogleConstants.ConfigClientId] ?? string.Empty;
        var Builder = new StringBuilder(GoogleConstants.AuthorizeUrl)
            .Append('?')
            .Append(OAuthConstants.ParamClientId).Append('=').Append(Uri.EscapeDataString(ClientId))
            .Append('&').Append(OAuthConstants.ParamRedirectUri).Append('=').Append(Uri.EscapeDataString(RedirectUri))
            .Append('&').Append(OAuthConstants.ParamResponseType).Append('=').Append(OAuthConstants.ResponseTypeCode)
            .Append('&').Append(OAuthConstants.ParamScope).Append('=').Append(Uri.EscapeDataString(GoogleConstants.RequiredScope))
            .Append('&').Append(OAuthConstants.ParamCodeChallenge).Append('=').Append(Uri.EscapeDataString(Challenge))
            .Append('&').Append(OAuthConstants.ParamCodeChallengeMethod).Append('=').Append(OAuthConstants.ChallengeMethodS256);
        if (!string.IsNullOrEmpty(State))
        {
            Builder.Append(OAuthConstants.ParamStatePrefix).Append(Uri.EscapeDataString(State));
        }
        return (Builder.ToString(), Verifier);
    }
    public async Task<GoogleTokenResult?> ExchangeCodeAsync(string Code, string RedirectUri, string CodeVerifier)
    {
        var ClientId = Configuration[GoogleConstants.ConfigClientId] ?? string.Empty;
        var ClientSecret = Configuration[GoogleConstants.ConfigClientSecret] ?? string.Empty;
        var Body = new Dictionary<string, string>
        {
            [OAuthConstants.ParamCode] = Code,
            [OAuthConstants.ParamClientId] = ClientId,
            [OAuthConstants.ParamClientSecret] = ClientSecret,
            [OAuthConstants.ParamRedirectUri] = RedirectUri,
            [OAuthConstants.ParamGrantType] = OAuthConstants.GrantTypeAuthorizationCode,
            [OAuthConstants.ParamCodeVerifier] = CodeVerifier
        };
        var Client = HttpFactory.CreateClient();
        var Response = await Client.PostAsync(GoogleConstants.TokenUrl, new FormUrlEncodedContent(Body));
        var Json = await Response.Content.ReadAsStringAsync();
        if (!Response.IsSuccessStatusCode)
        {
            Logger.LogError(GoogleConstants.LogTokenExchangeFailed, Response.StatusCode, Json);
            return null;
        }
        using var Doc = JsonDocument.Parse(Json);
        var Root = Doc.RootElement;
        return new GoogleTokenResult(
            AccessToken: GetStringProp(Root, OAuthConstants.TokenPropertyAccessToken),
            RefreshToken: GetOptionalProp(Root, OAuthConstants.TokenPropertyRefreshToken),
            IdToken: GetOptionalProp(Root, OAuthConstants.TokenPropertyIdToken),
            ExpiresIn: Root.TryGetProperty(OAuthConstants.TokenPropertyExpiresIn, out var Exp) ? Exp.GetInt32() : 0);
    }
    public async Task<GoogleUserInfo?> GetUserInfoAsync(string AccessToken)
    {
        var Client = HttpFactory.CreateClient();
        Client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(OAuthConstants.AuthSchemeBearer, AccessToken);
        var Response = await Client.GetAsync(GoogleConstants.UserInfoUrl);
        var Json = await Response.Content.ReadAsStringAsync();
        if (!Response.IsSuccessStatusCode)
        {
            Logger.LogError(GoogleConstants.LogUserInfoFailed, Response.StatusCode);
            return null;
        }
        using var Doc = JsonDocument.Parse(Json);
        var Root = Doc.RootElement;
        return new GoogleUserInfo(
            SubjectId: GetStringProp(Root, OAuthConstants.UserInfoPropertySub),
            Name: GetOptionalProp(Root, OAuthConstants.UserInfoPropertyName),
            Email: GetOptionalProp(Root, OAuthConstants.UserInfoPropertyEmail),
            Picture: GetOptionalProp(Root, OAuthConstants.UserInfoPropertyPicture));
    }
    public async Task<bool> ValidateIdTokenAsync(string IdToken)
    {
        var Client = HttpFactory.CreateClient();
        var Url = string.Concat(GoogleConstants.TokenInfoUrl, string.Format(GoogleConstants.TokenInfoQueryFormat, Uri.EscapeDataString(IdToken)));
        var Response = await Client.GetAsync(Url);
        if (!Response.IsSuccessStatusCode) { return false; }
        var Json = await Response.Content.ReadAsStringAsync();
        using var Doc = JsonDocument.Parse(Json);
        var Root = Doc.RootElement;
        var Aud = GetOptionalProp(Root, OAuthConstants.TokenPropertyAud);
        var ExpectedClientId = Configuration[GoogleConstants.ConfigClientId] ?? string.Empty;
        return string.Equals(Aud, ExpectedClientId, StringComparison.Ordinal);
    }
    private static string GenerateCodeVerifier()
    {
        var Bytes = RandomNumberGenerator.GetBytes(OAuthConstants.PkceByteLength);
        return Convert.ToBase64String(Bytes)
            .TrimEnd('=')
            .Replace('+', '-')
            .Replace('/', '_');
    }
    private static string ComputeCodeChallenge(string Verifier)
    {
        var Hash = SHA256.HashData(Encoding.ASCII.GetBytes(Verifier));
        return Convert.ToBase64String(Hash)
            .TrimEnd('=')
            .Replace('+', '-')
            .Replace('/', '_');
    }
    private static string GetStringProp(JsonElement El, string Name) =>
        El.TryGetProperty(Name, out var Val) ? Val.GetString() ?? string.Empty : string.Empty;
    private static string? GetOptionalProp(JsonElement El, string Name) =>
        El.TryGetProperty(Name, out var Val) ? Val.GetString() : null;
}
