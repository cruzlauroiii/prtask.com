using System.Net.Http.Json;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Playwright;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
[TestClass]
public abstract class PlaywrightTestBase
{
    private const string EnvironmentVariableName = "ASPNETCORE_ENVIRONMENT";
    private const string DevelopmentEnvironment = "Development";
    private const int BrowserTimeoutMs = 30000;
    private const int NavigationTimeoutMs = 30000;
    private const int HttpTimeoutSeconds = 60;
    private const string SetCookieHeaderName = "Set-Cookie";
    private const int SplitLimit = 2;
    private const int SplitNameIndex = 0;
    private const int SplitValueIndex = 1;
    private const string CookiePathRoot = "/";
    private static WebApplicationFactory<Program> Factory { get; set; } = null!;
    private static IPlaywright PlaywrightInstance { get; set; } = null!;
    private static IBrowser Browser { get; set; } = null!;
    protected static IBrowserContext Context { get; set; } = null!;
    protected static IPage Page { get; set; } = null!;
    protected static string ServerBaseUrl { get; set; } = string.Empty;
    protected static HttpClient ApiClient { get; set; } = null!;
    [AssemblyInitialize]
    public static async Task AssemblyInitializeAsync(TestContext TestContext)
    {
        Environment.SetEnvironmentVariable(EnvironmentVariableName, DevelopmentEnvironment);
        Factory = new WebApplicationFactory<Program>();
        var Host = Factory.Services.GetRequiredService<IServer>();
        var Addresses = Host.Features.Get<IServerAddressesFeature>();
        ServerBaseUrl = Addresses?.Addresses.FirstOrDefault() ?? string.Empty;
        if (string.IsNullOrEmpty(ServerBaseUrl))
        {
            using var TempClient = Factory.CreateClient();
            ServerBaseUrl = TempClient.BaseAddress?.ToString().TrimEnd('/') ?? string.Empty;
        }
#pragma warning disable CA5399, MA0039, S4830
        var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = false,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        ApiClient = new HttpClient(Handler)
        {
            BaseAddress = new Uri(ServerBaseUrl),
            Timeout = TimeSpan.FromSeconds(HttpTimeoutSeconds)
        };
        PlaywrightInstance = await Playwright.CreateAsync();
        Browser = await PlaywrightInstance.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = true
        });
        Context = await Browser.NewContextAsync(new BrowserNewContextOptions
        {
            BaseURL = ServerBaseUrl,
            IgnoreHTTPSErrors = true
        });
        Page = await Context.NewPageAsync();
        Page.SetDefaultTimeout(BrowserTimeoutMs);
        Page.SetDefaultNavigationTimeout(NavigationTimeoutMs);
    }
    [AssemblyCleanup]
    public static async Task AssemblyCleanupAsync()
    {
        if (Page is not null)
        {
            await Page.CloseAsync();
        }
        if (Context is not null)
        {
            await Context.DisposeAsync();
        }
        if (Browser is not null)
        {
            await Browser.DisposeAsync();
        }
        PlaywrightInstance?.Dispose();
        ApiClient?.Dispose();
        if (Factory is not null)
        {
            await Factory.DisposeAsync();
        }
    }
    protected static async Task DevLoginAsync(string UserId, string Username)
    {
        var RequestBody = new { UserId, Username };
        var Response = await ApiClient.PostAsJsonAsync(RouteConstants.ApiAuthDevLogin, RequestBody);
        Response.EnsureSuccessStatusCode();
        var Cookies = Response.Headers.GetValues(SetCookieHeaderName);
        foreach (var CookieHeader in Cookies)
        {
            var Parts = CookieHeader.Split('=', SplitLimit);
            if (Parts.Length >= SplitLimit)
            {
                var CookieValue = Parts[SplitValueIndex].Split(';')[SplitNameIndex];
                await Context.AddCookiesAsync(new[]
                {
                    new Microsoft.Playwright.Cookie
                    {
                        Name = Parts[SplitNameIndex],
                        Value = CookieValue,
                        Domain = new Uri(ServerBaseUrl).Host,
                        Path = CookiePathRoot
                    }
                });
            }
        }
    }
    protected static async Task<IResponse?> NavigateAsync(string RelativeUrl)
    {
        var Response = await Page.GotoAsync(RelativeUrl, new PageGotoOptions
        {
            WaitUntil = WaitUntilState.NetworkIdle,
            Timeout = NavigationTimeoutMs
        });
        return Response;
    }
}
