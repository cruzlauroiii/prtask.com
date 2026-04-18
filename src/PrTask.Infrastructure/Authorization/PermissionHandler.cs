using Microsoft.AspNetCore.Authorization;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Infrastructure.Authorization;
public sealed class PermissionHandler : AuthorizationHandler<PermissionRequirement>
{
    protected override Task HandleRequirementAsync(
        AuthorizationHandlerContext Context,
        PermissionRequirement Requirement)
    {
        var RoleClaim = Context.User.FindFirst(PermissionConstants.RoleClaimType);
        if (RoleClaim is null || !Enum.TryParse<UserRole>(RoleClaim.Value, ignoreCase: true, out var Role))
        {
            return Task.CompletedTask;
        }
        if (PermissionConstants.RoleHasPermission(Role, Requirement.Permission))
        {
            Context.Succeed(Requirement);
        }
        return Task.CompletedTask;
    }
}
