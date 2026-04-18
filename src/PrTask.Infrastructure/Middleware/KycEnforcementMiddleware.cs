using System.Security.Claims;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Infrastructure.Middleware;
public class KycEnforcementMiddleware(RequestDelegate Next)
{
    private static readonly JsonSerializerOptions JsonOpts = new() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

    public async Task InvokeAsync(HttpContext Context, IUserService UserService)
    {
        if (!Context.User.Identity?.IsAuthenticated ?? true)
        {
            await Next(Context);
            return;
        }
        if (IsReadOnlyMethod(Context.Request.Method))
        {
            await Next(Context);
            return;
        }
        if (!RequiresKyc(Context.Request.Path, Context.Request.Method))
        {
            await Next(Context);
            return;
        }
        var UserId = Context.User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (string.IsNullOrEmpty(UserId))
        {
            await Next(Context);
            return;
        }
        var User = await UserService.GetByIdAsync(UserId);
        if (User is null)
        {
            await Next(Context);
            return;
        }
        if (User.KycStatus == KycStatus.Verified)
        {
            await Next(Context);
            return;
        }
        var Message = User.KycStatus switch
        {
            KycStatus.NotSubmitted => KycEnforcementConstants.KycRequiredMessage,
            KycStatus.Pending => KycEnforcementConstants.KycPendingMessage,
            KycStatus.Verified => KycEnforcementConstants.KycRequiredMessage,
            KycStatus.Rejected => KycEnforcementConstants.KycRejectedMessage,
            _ => KycEnforcementConstants.KycRequiredMessage
        };
        Context.Response.StatusCode = StatusCodes.Status403Forbidden;
        Context.Response.ContentType = KycEnforcementConstants.ResponseContentType;
        var ResponseBody = new Dictionary<string, string>
        {
            [KycEnforcementConstants.ErrorPropertyName] = Message,
            [KycEnforcementConstants.KycStatusPropertyName] = User.KycStatus.ToString()
        };
        await Context.Response.WriteAsync(JsonSerializer.Serialize(ResponseBody, JsonOpts));
    }

    private static bool IsReadOnlyMethod(string Method)
    {
        foreach (var ReadOnlyMethod in KycEnforcementConstants.ReadOnlyMethods)
        {
            if (string.Equals(Method, ReadOnlyMethod, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }
        return false;
    }

    private static bool RequiresKyc(PathString RequestPath, string Method)
    {
        var Path = RequestPath.Value ?? string.Empty;
        foreach (var Prefix in KycEnforcementConstants.KycRequiredPathPrefixes)
        {
            if (Path.StartsWith(Prefix, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }
        if (string.Equals(Method, HttpMethods.Post, StringComparison.OrdinalIgnoreCase))
        {
            foreach (var ExactPath in KycEnforcementConstants.KycRequiredExactPostPaths)
            {
                if (Path.StartsWith(ExactPath, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
        }
        return false;
    }
}
