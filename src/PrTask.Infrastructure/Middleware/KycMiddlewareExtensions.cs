using Microsoft.AspNetCore.Builder;
namespace PrTask.Infrastructure.Middleware;
public static class KycMiddlewareExtensions
{
    public static IApplicationBuilder UseKycEnforcement(this IApplicationBuilder App)
    {
        return App.UseMiddleware<KycEnforcementMiddleware>();
    }
}
