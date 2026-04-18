using PrTask.Application.Contracts;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Server.Endpoints;
public static class UserEndpoints
{
    public static void MapUserEndpoints(this IEndpointRouteBuilder Routes)
    {
        var Group = Routes.MapGroup(RouteConstants.ApiUsers);
        Group.MapGet(RouteConstants.SubRoot, async (IUserService Service) =>
            Results.Ok((await Service.ListAsync()).Select(UserDto.FromEntity)));
        Group.MapGet(RouteConstants.SubUserById, async (string UserId, IUserService Service) =>
            await Service.GetByIdAsync(UserId) is { } Entity ? Results.Ok(UserDto.FromEntity(Entity)) : Results.NotFound());
        Group.MapPatch(RouteConstants.SubUserById, async (string UserId, UpdateUserRequest Request, IUserService Service) =>
        {
            var Entity = await Service.GetByIdAsync(UserId);
            if (Entity is null)
            {
                return Results.NotFound();
            }
            Entity.DisplayName = Request.DisplayName ?? Entity.DisplayName;
            Entity.AvatarUrl = Request.AvatarUrl ?? Entity.AvatarUrl;
            Entity.Email = Request.Email ?? Entity.Email;
            Entity.Role = Request.Role;
            return Results.Ok(UserDto.FromEntity(await Service.UpdateAsync(Entity)));
        }).RequireAuthorization(PermissionConstants.ToPolicyName(PermissionConstants.ManageUsers));
        Group.MapPost(RouteConstants.SubKyc, async (string UserId, SubmitKycRequest Request, IUserService Service) =>
        {
            var Entity = await Service.GetByIdAsync(UserId);
            if (Entity is null)
            {
                return Results.NotFound();
            }
            Entity.KycDocumentType = Request.DocumentType;
            Entity.KycDocumentId = Request.DocumentId;
            Entity.KycStatus = KycStatus.Pending;
            Entity.KycSubmittedAt = DateTime.UtcNow;
            return Results.Ok(UserDto.FromEntity(await Service.UpdateAsync(Entity)));
        }).RequireAuthorization();
        Group.MapDelete(RouteConstants.SubUserById, async (string UserId, IUserService Service) =>
        {
            await Service.DeleteAsync(UserId);
            return Results.NoContent();
        }).RequireAuthorization(PermissionConstants.ToPolicyName(PermissionConstants.DeleteUser));
    }
}
