using System.Net;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using PrTask.Application.Contracts;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
using PrTask.Infrastructure;
using PrTask.Infrastructure.Data;
using PrTask.Server.Endpoints;
namespace PrTask.E2E;
public static class InProcessServerHelper
{
   private static WebApplication? App;
   public static async Task StartAsync()
   {
       var SolutionRoot = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", ".."));
       var ServerRoot = Path.Combine(SolutionRoot, "src", "PrTask.Server");
       var Builder = WebApplication.CreateBuilder(new WebApplicationOptions
       {
           ContentRootPath = ServerRoot,
           WebRootPath = Path.Combine(ServerRoot, "wwwroot"),
           EnvironmentName = "Development",
           ApplicationName = "PrTask.Server"
       });
       Builder.Configuration[DbConstants.ConfigConnectionString] = "Data Source=prtask-e2e-test.db";
       Builder.WebHost.UseStaticWebAssets();
       Builder.WebHost.UseKestrelHttpsConfiguration();
       Builder.WebHost.UseUrls("https://127.0.0.1:0");
       Builder.Services.AddInfrastructure(Builder.Configuration);
       Builder.Services.AddLocalization();
       Builder.Services.AddSingleton<ILocalStoreService, NoOpLocalStoreService>();
       Builder.Services.AddSingleton<PrTask.SharedUI.Services.IConnectionStateService, PrTask.SharedUI.Services.ConnectionStateService>();
       Builder.Services.AddSingleton<PrTask.Application.Services.IGitSyncService, PrTask.Git.GitSyncService>();
       Builder.Services.AddScoped<PrTask.SharedUI.Services.WssStateService>();
       Builder.Services.AddRazorComponents().AddInteractiveServerComponents();
       Builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
           .AddCookie(Opt =>
           {
               Opt.LoginPath = RouteConstants.Login;
               Opt.ExpireTimeSpan = TimeSpan.FromDays(AppConstants.CookieExpirationDays);
               Opt.Cookie.HttpOnly = true;
               Opt.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
               Opt.Events.OnSignedIn = Ctx =>
               {
                   Ctx.Response.Cookies.Append(AppConstants.SessionActiveCookieName, AppConstants.SessionActiveCookieValue, new CookieOptions
                   {
                       Path = AppConstants.CookieRootPath, HttpOnly = false, SameSite = SameSiteMode.Lax, MaxAge = Opt.ExpireTimeSpan
                   });
                   return Task.CompletedTask;
               };
               Opt.Events.OnSigningOut = Ctx =>
               {
                   Ctx.Response.Cookies.Delete(AppConstants.SessionActiveCookieName, new CookieOptions { Path = AppConstants.CookieRootPath });
                   return Task.CompletedTask;
               };
               Opt.Events.OnRedirectToLogin = Ctx => { Ctx.Response.StatusCode = 401; return Task.CompletedTask; };
               Opt.Events.OnRedirectToAccessDenied = Ctx => { Ctx.Response.StatusCode = 403; return Task.CompletedTask; };
           });
       Builder.Services.AddAuthorization();
       Builder.Services.AddCors(O => O.AddPolicy(AppConstants.CorsPolicyName, P =>
           P.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));
       App = Builder.Build();
       using (var Scope = App.Services.CreateScope())
       {
           var Db = Scope.ServiceProvider.GetRequiredService<AppDbContext>();
           await Db.Database.EnsureCreatedAsync();
           await PrTask.Server.DemoSeedHelper.SeedAsync(Db, Scope.ServiceProvider);
       }
       App.UseWebSockets();
       App.Use(async (Ctx, Next) =>
       {
           Ctx.Response.Headers.Append(SecurityConstants.XContentTypeOptions, SecurityConstants.XContentTypeOptionsValue);
           Ctx.Response.Headers.Append(SecurityConstants.XFrameOptions, SecurityConstants.XFrameOptionsValue);
           Ctx.Response.Headers.Append(SecurityConstants.ReferrerPolicy, SecurityConstants.ReferrerPolicyValue);
           Ctx.Response.Headers.Append(SecurityConstants.PermissionsPolicy, SecurityConstants.PermissionsPolicyValue);
           Ctx.Response.Headers.Append(SecurityConstants.XssProtection, SecurityConstants.XssProtectionValue);
           await Next();
       });
       App.UseCors(AppConstants.CorsPolicyName);
       App.UseStaticFiles();
       App.UseAuthentication();
       App.UseAuthorization();
       App.UseAntiforgery();
       MapAllEndpoints(App);
       App.MapRazorComponents<PrTask.SharedUI.Components.App>()
           .AddInteractiveServerRenderMode();
       App.MapFallbackToFile(AppConstants.DesktopFallbackFile);
       await App.StartAsync();
       var Addresses = App.Services.GetRequiredService<IServer>()
           .Features.Get<IServerAddressesFeature>()!.Addresses;
       RulesTests.LocalServerUrl = Addresses.First();
       RulesTests.InProcessApp = App;
   }
   private static void MapAllEndpoints(WebApplication A)
   {
       A.MapAuthEndpoints(A.Configuration);
       A.MapTaskEndpoints();
       A.MapPullRequestEndpoints();
       A.MapPaymentEndpoints();
       A.MapPaymentRecordEndpoints();
       A.MapCustomerEndpoints();
       A.MapWebhookEndpoints();
       A.MapAchievementEndpoints();
       A.MapLeaderboardEndpoints();
       A.MapUserEndpoints();
       A.MapSprintEndpoints();
       A.MapBoardEndpoints();
       A.MapPlainTextDbEndpoints();
       A.MapSubscriptionEndpoints();
       A.MapInvoiceEndpoints();
       A.MapDisbursementEndpoints();
       A.MapQrPaymentEndpoints();
       A.MapWalletPaymentEndpoints();
       A.MapPaymentV2Endpoints();
       A.MapMayaConnectEndpoints();
       A.MapReviewCommentEndpoints();
       A.MapKycEndpoints();
       A.MapSourceCodeEndpoints();
       A.MapInferenceEndpoints();
       A.MapVectorSearchEndpoints();
       A.MapTranscriptionEndpoints();
       A.MapSyncEndpoints();
       A.MapWebSocketEndpoint();
       A.MapRepositoryEndpoints();
       A.MapBillsPaymentEndpoints();
       A.MapRefundEndpoints();
       A.MapVoidEndpoints();
       A.MapP3PaymentEndpoints();
       A.MapRemittanceEndpoints();
       A.MapAuditEndpoints();
       A.MapDiffEndpoints();
       A.MapPost(RouteConstants.ApiAuthDevLogin, async (DevLoginRequest Req, HttpContext Ctx, IUserService Svc) =>
       {
           var Provider = Req.Provider ?? E2ECrudConstants.DevProvider;
           var User = await Svc.CreateOrUpdateFromOidcAsync(
               Provider, Req.UserId, Req.Username,
               FormatStrings.BuyerEmail(Req.UserId), null);
           if (User.KycStatus != KycStatus.Verified || User.Role != UserRole.Admin)
           {
               User.KycStatus = KycStatus.Verified;
               User.Role = UserRole.Admin;
               await Svc.UpdateAsync(User);
           }
           var Claims = new List<Claim>
           {
               new(ClaimTypes.NameIdentifier, User.Id),
               new(ClaimTypes.Name, Req.Username),
               new(PermissionConstants.RoleClaimType, User.Role.ToString())
           };
           var Identity = new ClaimsIdentity(Claims, CookieAuthenticationDefaults.AuthenticationScheme);
           await Ctx.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(Identity));
           return Results.Ok(new { User.Id, Req.Username });
       });
   }
   public static async Task StopAsync()
   {
       if (App is not null)
       {
           await App.StopAsync();
           await App.DisposeAsync();
       }
   }
}

