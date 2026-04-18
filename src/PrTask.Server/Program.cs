using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using PrTask.Infrastructure;
using PrTask.Server.Endpoints;
var Builder = WebApplication.CreateBuilder(args);
Builder.Services.AddInfrastructure();
Builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
Builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(Options =>
    {
        Options.LoginPath = PrTask.Domain.Constants.RouteConstants.Login;
        Options.LogoutPath = PrTask.Domain.Constants.RouteConstants.ApiAuthLogout;
        Options.ExpireTimeSpan = TimeSpan.FromDays(30);
        Options.SlidingExpiration = true;
        Options.Cookie.HttpOnly = true;
        Options.Cookie.SameSite = SameSiteMode.Lax;
        Options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
        Options.Events.OnRedirectToLogin = Context =>
        {
            Context.Response.StatusCode = StatusCodes.Status401Unauthorized;
            return Task.CompletedTask;
        };
    });
Builder.Services.AddAuthorization();
Builder.Services.AddCors(Options => Options.AddPolicy("AllowClient", Policy =>
    Policy.WithOrigins($"https://{PrTask.Domain.Constants.AppConstants.AppDomain}")
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials()));
var App = Builder.Build();
App.UseCors("AllowClient");
App.UseStaticFiles();
App.UseAuthentication();
App.UseAuthorization();
App.MapAuthEndpoints(App.Configuration);
App.MapAuthEndpoints(App.Configuration);
App.MapTaskEndpoints();
App.MapPullRequestEndpoints();
App.MapPaymentEndpoints();
App.MapLeaderboardEndpoints();
App.MapRazorComponents<PrTask.SharedUI.Components.App>()
    .AddInteractiveServerRenderMode();
App.Run();
