using System.Net.Http.Headers;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using PrTask.Application.Contracts;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Server.Endpoints;
public static class AuthEndpoints
{
    public static void MapAuthEndpoints(this IEndpointRouteBuilder Routes, IConfiguration Configuration)
    {
        MapGitHubEndpoints(Routes, Configuration);
        MapOidcEndpoint(Routes, Configuration, "Google", RouteConstants.ApiAuthGoogle, RouteConstants.ApiAuthCallbackGoogle,
            GoogleConstants.AuthorizeUrl, GoogleConstants.RequiredScope, "Google:ClientId");
        var AzureAuthorizeUrl = $"https://login.microsoftonline.com/{AzureConstants.CommonTenant}/oauth2/v2.0/authorize";
        MapOidcEndpoint(Routes, Configuration, "Azure", RouteConstants.ApiAuthAzure, RouteConstants.ApiAuthCallbackAzure,
            AzureAuthorizeUrl, AzureConstants.RequiredScope, "Azure:ClientId");
        MapOidcEndpoint(Routes, Configuration, "Okta", RouteConstants.ApiAuthOkta, RouteConstants.ApiAuthCallbackOkta,
            $"{Configuration["Okta:Domain"]}{OktaConstants.AuthorizePathTemplate}", OktaConstants.RequiredScope, "Okta:ClientId");
        MapOidcCallback(Routes, Configuration, "Google", RouteConstants.ApiAuthCallbackGoogle,
            GoogleConstants.TokenUrl, GoogleConstants.UserInfoUrl, "Google:ClientId", "Google:ClientSecret");
        var AzureTokenUrl = $"https://login.microsoftonline.com/{AzureConstants.CommonTenant}/oauth2/v2.0/token";
        MapOidcCallback(Routes, Configuration, "Azure", RouteConstants.ApiAuthCallbackAzure,
            AzureTokenUrl, AzureConstants.UserInfoUrl, "Azure:ClientId", "Azure:ClientSecret");
        MapOidcCallback(Routes, Configuration, "Okta", RouteConstants.ApiAuthCallbackOkta,
            $"{Configuration["Okta:Domain"]}{OktaConstants.TokenPathTemplate}",
            $"{Configuration["Okta:Domain"]}{OktaConstants.UserInfoPathTemplate}", "Okta:ClientId", "Okta:ClientSecret");
        Routes.MapPost(RouteConstants.ApiAuthLogout, async (HttpContext Context) =>
        {
            await Context.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Results.Ok();
        });
        Routes.MapGet(RouteConstants.ApiAuthMe, (HttpContext Context) =>
            Context.User.Identity?.IsAuthenticated != true
                ? Results.Unauthorized()
                : Results.Ok(new
                {
                    UserId = Context.User.FindFirstValue(ClaimTypes.NameIdentifier),
                    Username = Context.User.FindFirstValue(ClaimTypes.Name),
                    AvatarUrl = Context.User.FindFirstValue("avatar_url")
                }));
    }
    private static void MapGitHubEndpoints(IEndpointRouteBuilder Routes, IConfiguration Configuration)
    {
        Routes.MapGet(RouteConstants.ApiAuthGitHub, (HttpContext Context) =>
        {
            var ClientId = Configuration["GitHub:ClientId"];
            var RedirectUri = $"https://{AppConstants.AppDomain}{RouteConstants.ApiAuthCallback}";
            var AuthUrl = $"{GitHubConstants.AuthorizeUrl}?client_id={ClientId}&redirect_uri={Uri.EscapeDataString(RedirectUri)}&scope={Uri.EscapeDataString(GitHubConstants.RequiredScope)}";
            return Results.Redirect(AuthUrl);
        });
        Routes.MapGet(RouteConstants.ApiAuthCallback, async (string Code, HttpContext Context, IHttpClientFactory HttpFactory, IConfiguration Config, IUserService UserService) =>
        {
            var AccessToken = await ExchangeGitHubCodeAsync(Code, HttpFactory, Config);
            if (string.IsNullOrEmpty(AccessToken))
            {
                return Results.Redirect($"{RouteConstants.Login}?error=auth_failed");
            }
            var GitHubUser = await FetchGitHubUserAsync(AccessToken, HttpFactory);
            if (GitHubUser is null)
            {
                return Results.Redirect($"{RouteConstants.Login}?error=profile_failed");
            }
            var User = await UserService.CreateOrUpdateFromGitHubAsync(
                GitHubUser.Id, GitHubUser.Login, GitHubUser.Name, GitHubUser.AvatarUrl, GitHubUser.Email);
            await SignInUserAsync(Context, User.Id, User.GitHubUsername, User.AvatarUrl);
            return Results.Redirect(RouteConstants.Dashboard);
        });
    }
    private static void MapOidcEndpoint(IEndpointRouteBuilder Routes, IConfiguration Config, string Provider,
        string AuthRoute, string CallbackRoute, string AuthorizeUrl, string Scope, string ClientIdKey)
    {
        Routes.MapGet(AuthRoute, (HttpContext Context, bool? Auto) =>
        {
            var ClientId = Config[ClientIdKey];
            var RedirectUri = $"https://{AppConstants.AppDomain}{CallbackRoute}";
            var (Verifier, Challenge) = GeneratePkce();
            Context.Response.Cookies.Append($"pkce_{Provider}", Verifier, PkceCookieOptions);
            var AuthUrl = $"{AuthorizeUrl}?client_id={ClientId}&redirect_uri={Uri.EscapeDataString(RedirectUri)}" +
                $"&response_type=code&scope={Uri.EscapeDataString(Scope)}" +
                $"&code_challenge={Challenge}&code_challenge_method=S256";
            if (Auto == true && Provider == "Google")
            {
                AuthUrl += "&prompt=none";
            }
            return Results.Redirect(AuthUrl);
        });
    }
    private static void MapOidcCallback(IEndpointRouteBuilder Routes, IConfiguration Config, string Provider,
        string CallbackRoute, string TokenUrl, string UserInfoUrl, string ClientIdKey, string ClientSecretKey)
    {
        Routes.MapGet(CallbackRoute, async (string? Code, string? Error, HttpContext Context, IHttpClientFactory HttpFactory, IUserService UserService) =>
        {
            if (!string.IsNullOrEmpty(Error))
            {
                return Results.Redirect($"{RouteConstants.Login}?auto_failed=true");
            }
            if (string.IsNullOrEmpty(Code))
            {
                return Results.Redirect($"{RouteConstants.Login}?error=no_code");
            }
            var Verifier = Context.Request.Cookies[$"pkce_{Provider}"];
            if (string.IsNullOrEmpty(Verifier))
            {
                return Results.Redirect($"{RouteConstants.Login}?error=pkce_missing");
            }
            Context.Response.Cookies.Delete($"pkce_{Provider}");
            var RedirectUri = $"https://{AppConstants.AppDomain}{CallbackRoute}";
            var AccessToken = await ExchangeOidcCodeAsync(Code, Verifier, RedirectUri, TokenUrl,
                Config[ClientIdKey] ?? string.Empty, Config[ClientSecretKey] ?? string.Empty, HttpFactory);
            if (string.IsNullOrEmpty(AccessToken))
            {
                return Results.Redirect($"{RouteConstants.Login}?error=auth_failed");
            }
            var UserInfo = await FetchOidcUserInfoAsync(AccessToken, UserInfoUrl, HttpFactory);
            if (UserInfo is null)
            {
                return Results.Redirect($"{RouteConstants.Login}?error=profile_failed");
            }
            var User = await UserService.CreateOrUpdateFromOidcAsync(Provider, UserInfo.SubjectId, UserInfo.Name, UserInfo.Email, UserInfo.Picture);
            await SignInUserAsync(Context, User.Id, User.DisplayName ?? Provider, User.AvatarUrl);
            return Results.Redirect(RouteConstants.Dashboard);
        });
    }
    private static (string Verifier, string Challenge) GeneratePkce()
    {
        var Bytes = RandomNumberGenerator.GetBytes(32);
        var Verifier = Convert.ToBase64String(Bytes).Replace('+', '-').Replace('/', '_').TrimEnd('=');
        var Hash = SHA256.HashData(Encoding.ASCII.GetBytes(Verifier));
        var Challenge = Convert.ToBase64String(Hash).Replace('+', '-').Replace('/', '_').TrimEnd('=');
        return (Verifier, Challenge);
    }
    private static async Task SignInUserAsync(HttpContext Context, string UserId, string Username, string? AvatarUrl)
    {
        var Claims = new List<Claim> { new(ClaimTypes.NameIdentifier, UserId), new(ClaimTypes.Name, Username) };
        if (AvatarUrl is not null)
        {
            Claims.Add(new Claim("avatar_url", AvatarUrl));
        }
        var Identity = new ClaimsIdentity(Claims, CookieAuthenticationDefaults.AuthenticationScheme);
        await Context.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(Identity));
    }
    private static async Task<string?> ExchangeGitHubCodeAsync(string Code, IHttpClientFactory HttpFactory, IConfiguration Config)
    {
        var Client = HttpFactory.CreateClient();
        Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        var TokenRequest = new FormUrlEncodedContent(
        [
            new KeyValuePair<string, string>("client_id", Config["GitHub:ClientId"] ?? string.Empty),
            new KeyValuePair<string, string>("client_secret", Config["GitHub:ClientSecret"] ?? string.Empty),
            new KeyValuePair<string, string>("code", Code)
        ]);
        var Response = await Client.PostAsync(GitHubConstants.TokenUrl, TokenRequest);
        if (!Response.IsSuccessStatusCode)
        {
            return null;
        }
        var Json = await Response.Content.ReadAsStringAsync();
        using var Document = JsonDocument.Parse(Json);
        return Document.RootElement.TryGetProperty("access_token", out var TokenElement) ? TokenElement.GetString() : null;
    }
    private static async Task<string?> ExchangeOidcCodeAsync(string Code, string Verifier, string RedirectUri,
        string TokenUrl, string ClientId, string ClientSecret, IHttpClientFactory HttpFactory)
    {
        var Client = HttpFactory.CreateClient();
        Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        var TokenRequest = new FormUrlEncodedContent(
        [
            new KeyValuePair<string, string>("grant_type", "authorization_code"),
            new KeyValuePair<string, string>("code", Code),
            new KeyValuePair<string, string>("redirect_uri", RedirectUri),
            new KeyValuePair<string, string>("client_id", ClientId),
            new KeyValuePair<string, string>("client_secret", ClientSecret),
            new KeyValuePair<string, string>("code_verifier", Verifier)
        ]);
        var Response = await Client.PostAsync(TokenUrl, TokenRequest);
        if (!Response.IsSuccessStatusCode)
        {
            return null;
        }
        var Json = await Response.Content.ReadAsStringAsync();
        using var Document = JsonDocument.Parse(Json);
        return Document.RootElement.TryGetProperty("access_token", out var TokenElement) ? TokenElement.GetString() : null;
    }
    private static async Task<OidcUserResponse?> FetchOidcUserInfoAsync(string AccessToken, string UserInfoUrl, IHttpClientFactory HttpFactory)
    {
        var Client = HttpFactory.CreateClient();
        Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
        var Response = await Client.GetAsync(UserInfoUrl);
        if (!Response.IsSuccessStatusCode)
        {
            return null;
        }
        var Json = await Response.Content.ReadAsStringAsync();
        using var Document = JsonDocument.Parse(Json);
        var Root = Document.RootElement;
        var SubjectId = Root.TryGetProperty("sub", out var SubElement) ? SubElement.GetString() ?? string.Empty : string.Empty;
        var Name = Root.TryGetProperty("name", out var NameElement) ? NameElement.GetString() : null;
        var Email = Root.TryGetProperty("email", out var EmailElement) ? EmailElement.GetString() : null;
        var Picture = Root.TryGetProperty("picture", out var PicElement) ? PicElement.GetString() : null;
        return new OidcUserResponse(SubjectId, Name, Email, Picture);
    }
    private static async Task<GitHubUserResponse?> FetchGitHubUserAsync(string AccessToken, IHttpClientFactory HttpFactory)
    {
        var Client = HttpFactory.CreateClient();
        Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
        Client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue(AppConstants.AppName, "1.0"));
        var Response = await Client.GetAsync(GitHubConstants.UserApiUrl);
        return Response.IsSuccessStatusCode
            ? await Response.Content.ReadFromJsonAsync<GitHubUserResponse>(GitHubJsonOptions)
            : null;
    }
    private static readonly CookieOptions PkceCookieOptions = new()
    {
        HttpOnly = true, Secure = true, SameSite = SameSiteMode.Lax, MaxAge = TimeSpan.FromMinutes(10)
    };
    private static readonly JsonSerializerOptions GitHubJsonOptions = new() { PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower };
}
