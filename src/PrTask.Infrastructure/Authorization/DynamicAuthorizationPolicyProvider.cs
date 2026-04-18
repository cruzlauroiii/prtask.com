using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using PrTask.Domain.Constants;
namespace PrTask.Infrastructure.Authorization;
public sealed class DynamicAuthorizationPolicyProvider(
    IOptions<AuthorizationOptions> Options) : IAuthorizationPolicyProvider
{
    private readonly DefaultAuthorizationPolicyProvider FallbackProvider = new(Options);

    public Task<AuthorizationPolicy?> GetPolicyAsync(string PolicyName)
    {
        if (PolicyName.StartsWith(PermissionConstants.PolicyPrefix, StringComparison.Ordinal))
        {
            var Permission = PolicyName[PermissionConstants.PolicyPrefix.Length..];
            if (PermissionConstants.AllPermissions.Contains(Permission))
            {
                var PolicyBuilder = new AuthorizationPolicyBuilder();
                PolicyBuilder.AddRequirements(new PermissionRequirement(Permission));
                return Task.FromResult<AuthorizationPolicy?>(PolicyBuilder.Build());
            }
        }
        return FallbackProvider.GetPolicyAsync(PolicyName);
    }

    public Task<AuthorizationPolicy> GetDefaultPolicyAsync() =>
        FallbackProvider.GetDefaultPolicyAsync();

    public Task<AuthorizationPolicy?> GetFallbackPolicyAsync() =>
        FallbackProvider.GetFallbackPolicyAsync();
}
