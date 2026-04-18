using System.Diagnostics;
using System.Net;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using PrTask.Application.Contracts;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Infrastructure;
using PrTask.Infrastructure.Data;
using PrTask.Server.Endpoints;
namespace PrTask.Desktop;
public static class Program
{
    public static async Task Main(string[] Args)
    {
        Console.Title = AppConstants.DesktopWindowTitle;
        var Builder = WebApplication.CreateBuilder(Args);
        Builder.Configuration[DbConstants.ConfigConnectionString] = AppConstants.DesktopLocalDbConnectionString;
        Builder.WebHost.ConfigureKestrel(Kestrel =>
            Kestrel.Listen(IPAddress.IPv6Any, AppConstants.DesktopAutoPort));
        Builder.Services.AddInfrastructure();
        Builder.Services.AddLocalization();
        Builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents();
        Builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(Options =>
            {
                Options.LoginPath = RouteConstants.Login;
                Options.LogoutPath = RouteConstants.ApiAuthLogout;
                Options.ExpireTimeSpan = TimeSpan.FromDays(AppConstants.CookieExpirationDays);
                Options.SlidingExpiration = true;
                Options.Cookie.HttpOnly = true;
                Options.Cookie.SameSite = SameSiteMode.Lax;
                Options.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
                Options.Events.OnSignedIn = Context =>
                {
                    Context.Response.Cookies.Append(AppConstants.SessionActiveCookieName, AppConstants.SessionActiveCookieValue, new CookieOptions
                    {
                        Path = AppConstants.CookieRootPath, HttpOnly = false, SameSite = SameSiteMode.Lax, MaxAge = Options.ExpireTimeSpan
                    });
                    return Task.CompletedTask;
                };
                Options.Events.OnSigningOut = Context =>
                {
                    Context.Response.Cookies.Delete(AppConstants.SessionActiveCookieName, new CookieOptions { Path = AppConstants.CookieRootPath });
                    return Task.CompletedTask;
                };
                Options.Events.OnRedirectToLogin = Context =>
                {
                    Context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                    return Task.CompletedTask;
                };
            });
        Builder.Services.AddAuthorization();
        Builder.Services.AddCors(Options => Options.AddPolicy(AppConstants.CorsPolicyName, Policy =>
            Policy.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()));
        var App = Builder.Build();
        using (var Scope = App.Services.CreateScope())
        {
            var Db = Scope.ServiceProvider.GetRequiredService<AppDbContext>();
            await Db.Database.EnsureCreatedAsync();
        }
        App.UseWebSockets();
        App.Use(async (Context, Next) =>
        {
            Context.Response.Headers.Append(SecurityConstants.XContentTypeOptions, SecurityConstants.XContentTypeOptionsValue);
            Context.Response.Headers.Append(SecurityConstants.XFrameOptions, SecurityConstants.XFrameOptionsValue);
            Context.Response.Headers.Append(SecurityConstants.ReferrerPolicy, SecurityConstants.ReferrerPolicyValue);
            Context.Response.Headers.Append(SecurityConstants.PermissionsPolicy, SecurityConstants.PermissionsPolicyValue);
            Context.Response.Headers.Append(SecurityConstants.XssProtection, SecurityConstants.XssProtectionValue);
            await Next();
        });
        App.UseCors(AppConstants.CorsPolicyName);
        App.Use(async (Context, Next) =>
        {
            if (Context.Request.Path == RouteConstants.Home || !Context.Request.Path.HasValue)
            {
                Context.Response.Redirect(AppConstants.DesktopDefaultLocalePath);
                return;
            }
            await Next();
        });
        App.UseDefaultFiles();
        App.UseStaticFiles();
        App.UseAuthentication();
        App.UseAuthorization();
        App.UseAntiforgery();
        App.MapPost(RouteConstants.ApiAuthDevLogin, async (DevLoginRequest Req, HttpContext Context, IUserService UserService) =>
        {
            var User = await UserService.CreateOrUpdateFromOidcAsync(
                E2ECrudConstants.DevProvider, Req.UserId, Req.Username,
                FormatStrings.BuyerEmail(Req.UserId), null);
            var Claims = new List<Claim>
            {
                new(ClaimTypes.NameIdentifier, User.Id),
                new(ClaimTypes.Name, Req.Username)
            };
            var Identity = new ClaimsIdentity(Claims, CookieAuthenticationDefaults.AuthenticationScheme);
            await Context.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(Identity));
            return Results.Ok(new { User.Id, Req.Username });
        });
        App.MapTaskEndpoints();
        App.MapPullRequestEndpoints();
        App.MapPaymentEndpoints();
        App.MapPaymentRecordEndpoints();
        App.MapCustomerEndpoints();
        App.MapWebhookEndpoints();
        App.MapAchievementEndpoints();
        App.MapLeaderboardEndpoints();
        App.MapUserEndpoints();
        App.MapSprintEndpoints();
        App.MapBoardEndpoints();
        App.MapPlainTextDbEndpoints();
        App.MapSubscriptionEndpoints();
        App.MapInvoiceEndpoints();
        App.MapDisbursementEndpoints();
        App.MapQrPaymentEndpoints();
        App.MapWalletPaymentEndpoints();
        App.MapPaymentV2Endpoints();
        App.MapMayaConnectEndpoints();
        App.MapReviewCommentEndpoints();
        App.MapKycEndpoints();
        App.MapSourceCodeEndpoints();
        App.MapInferenceEndpoints();
        App.MapVectorSearchEndpoints();
        App.MapTranscriptionEndpoints();
        App.MapSyncEndpoints();
        App.MapWebSocketEndpoint();
        App.MapRepositoryEndpoints();
        App.MapBillsPaymentEndpoints();
        App.MapRefundEndpoints();
        App.MapVoidEndpoints();
        App.MapP3PaymentEndpoints();
        App.MapRemittanceEndpoints();
        App.MapAuditEndpoints();
        App.MapDiffEndpoints();
        App.MapRazorComponents<PrTask.SharedUI.Components.App>()
            .AddInteractiveServerRenderMode();
        App.MapFallbackToFile(AppConstants.DesktopFallbackFile);
        await App.StartAsync();
        var ServerAddresses = App.Services
            .GetRequiredService<IServer>()
            .Features
            .Get<IServerAddressesFeature>()!
            .Addresses;
        var Url = ServerAddresses.First();
        Console.WriteLine(AppConstants.DesktopRunningPrefix + Url);
        _ = Task.Run(async () =>
        {
            await Task.Delay(AppConstants.DesktopBrowserDelayMs);
            OpenBrowser(Url);
        });
        await App.WaitForShutdownAsync();
    }
    private static void OpenBrowser(string Url)
    {
        try
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = Url,
                UseShellExecute = true,
            });
        }
        catch
        {
        }
    }
}
