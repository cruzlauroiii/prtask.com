using PrTask.Domain.Models;
namespace PrTask.Domain.Constants;
public static class PermissionConstants
{
    public const string PolicyPrefix = "Permission.";
    public const string ClaimType = "Permission";
    public const string RoleClaimType = "OrgRole";
    public const string CreateTask = "CreateTask";
    public const string EditTask = "EditTask";
    public const string DeleteTask = "DeleteTask";
    public const string ViewTask = "ViewTask";
    public const string ClaimTask = "ClaimTask";
    public const string CreatePullRequest = "CreatePullRequest";
    public const string ReviewPullRequest = "ReviewPullRequest";
    public const string ApprovePullRequest = "ApprovePullRequest";
    public const string RejectPullRequest = "RejectPullRequest";
    public const string DeletePullRequest = "DeletePullRequest";
    public const string EditPullRequest = "EditPullRequest";
    public const string ManageUsers = "ManageUsers";
    public const string DeleteUser = "DeleteUser";
    public const string ManagePayments = "ManagePayments";
    public const string ViewPayments = "ViewPayments";
    public const string ManageBilling = "ManageBilling";
    public const string ViewAuditLogs = "ViewAuditLogs";
    public const string ManageBoards = "ManageBoards";
    public const string ManageSprints = "ManageSprints";
    public const string ManageRepositories = "ManageRepositories";
    public const string ManageWebhooks = "ManageWebhooks";
    public const string ManageSettings = "ManageSettings";
    public static readonly IReadOnlyDictionary<UserRole, IReadOnlySet<string>> RolePermissions =
        new Dictionary<UserRole, IReadOnlySet<string>>
        {
            [UserRole.Viewer] = new HashSet<string>
            {
                ViewTask,
                ViewPayments
            },
            [UserRole.Member] = new HashSet<string>
            {
                ViewTask,
                ViewPayments,
                CreateTask,
                EditTask,
                ClaimTask,
                CreatePullRequest,
                EditPullRequest,
                ManageBoards,
                ManageSprints
            },
            [UserRole.Developer] = new HashSet<string>
            {
                ViewTask,
                ViewPayments,
                CreateTask,
                EditTask,
                ClaimTask,
                CreatePullRequest,
                EditPullRequest,
                ReviewPullRequest,
                ManageBoards,
                ManageSprints,
                ManageRepositories
            },
            [UserRole.Client] = new HashSet<string>
            {
                ViewTask,
                ViewPayments,
                CreateTask,
                EditTask,
                DeleteTask,
                ApprovePullRequest,
                RejectPullRequest,
                ManagePayments,
                ManageBilling,
                ManageBoards,
                ManageSprints,
                ManageWebhooks
            },
            [UserRole.Admin] = new HashSet<string>
            {
                ViewTask,
                ViewPayments,
                CreateTask,
                EditTask,
                DeleteTask,
                ClaimTask,
                CreatePullRequest,
                EditPullRequest,
                ReviewPullRequest,
                ApprovePullRequest,
                RejectPullRequest,
                DeletePullRequest,
                ManageUsers,
                ManagePayments,
                ManageBilling,
                ViewAuditLogs,
                ManageBoards,
                ManageSprints,
                ManageRepositories,
                ManageWebhooks,
                ManageSettings
            },
            [UserRole.Owner] = new HashSet<string>
            {
                ViewTask,
                ViewPayments,
                CreateTask,
                EditTask,
                DeleteTask,
                ClaimTask,
                CreatePullRequest,
                EditPullRequest,
                ReviewPullRequest,
                ApprovePullRequest,
                RejectPullRequest,
                DeletePullRequest,
                ManageUsers,
                DeleteUser,
                ManagePayments,
                ManageBilling,
                ViewAuditLogs,
                ManageBoards,
                ManageSprints,
                ManageRepositories,
                ManageWebhooks,
                ManageSettings
            }
        };
    public static IReadOnlySet<string> GetPermissionsForRole(UserRole Role) =>
        RolePermissions.TryGetValue(Role, out var Permissions)
            ? Permissions
            : new HashSet<string>();
    public static bool RoleHasPermission(UserRole Role, string Permission) =>
        RolePermissions.TryGetValue(Role, out var Permissions) && Permissions.Contains(Permission);
    public static string ToPolicyName(string Permission) => $"{PolicyPrefix}{Permission}";
    public static readonly IReadOnlySet<string> AllPermissions = new HashSet<string>
    {
        CreateTask,
        EditTask,
        DeleteTask,
        ViewTask,
        ClaimTask,
        CreatePullRequest,
        ReviewPullRequest,
        ApprovePullRequest,
        RejectPullRequest,
        DeletePullRequest,
        EditPullRequest,
        ManageUsers,
        DeleteUser,
        ManagePayments,
        ViewPayments,
        ManageBilling,
        ViewAuditLogs,
        ManageBoards,
        ManageSprints,
        ManageRepositories,
        ManageWebhooks,
        ManageSettings
    };
}
