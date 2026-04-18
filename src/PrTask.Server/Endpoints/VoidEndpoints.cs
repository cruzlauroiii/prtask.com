using PrTask.Application.Contracts;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Server.Endpoints;
public static class VoidEndpoints
{
    public static void MapVoidEndpoints(this IEndpointRouteBuilder Routes)
    {
        var Group = Routes.MapGroup(RouteConstants.ApiVoids).RequireAuthorization();
        Group.MapGet(RouteConstants.SubVoidsByPayment, async (string PaymentId, IVoidService Service) =>
            Results.Ok((await Service.ListByPaymentIdAsync(PaymentId)).Select(VoidDto.FromEntity)));
        Group.MapGet(RouteConstants.SubVoidById, async (string VoidId, IVoidService Service) =>
        {
            var Entity = await Service.GetByIdAsync(VoidId);
            return Entity is null ? Results.NotFound() : Results.Ok(VoidDto.FromEntity(Entity));
        });
        Group.MapPost(RouteConstants.SubRoot, async (CreateVoidRequest Request, IVoidService Service) =>
        {
            var Entity = new VoidEntity
            {
                Id = Guid.NewGuid().ToString(),
                PaymentId = Request.PaymentId,
                Reason = Request.Reason,
                AmountCents = Request.AmountCents
            };
            var Created = await Service.CreateVoidAsync(Entity);
            return Results.Created(RouteConstants.ApiVoids, VoidDto.FromEntity(Created));
        });
        Group.MapPatch(RouteConstants.SubVoidById, async (string VoidId, UpdateVoidStatusRequest Request, IVoidService Service) =>
        {
            var Updated = await Service.UpdateStatusAsync(VoidId, Request.Status);
            return Updated is null ? Results.NotFound() : Results.Ok(VoidDto.FromEntity(Updated));
        });
        Group.MapDelete(RouteConstants.SubVoidById, async (string VoidId, IVoidService Service) =>
            await Service.DeleteAsync(VoidId) ? Results.NoContent() : Results.NotFound());
    }
}
