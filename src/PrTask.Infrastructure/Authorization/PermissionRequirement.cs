using Microsoft.AspNetCore.Authorization;
namespace PrTask.Infrastructure.Authorization;
public sealed class PermissionRequirement(string Permission) : IAuthorizationRequirement
{
    public string Permission { get; } = Permission;
}
