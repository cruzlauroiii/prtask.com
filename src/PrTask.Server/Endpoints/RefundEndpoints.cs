using PrTask.Application.Contracts;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Server.Endpoints;
public static class RefundEndpoints
{
    public static void MapRefundEndpoints(this IEndpointRouteBuilder Routes)
    {
        var Group = Routes.MapGroup(RouteConstants.ApiRefunds).RequireAuthorization();
        Group.MapGet(RouteConstants.SubRefundById, async (string Id, IRefundService Service) =>
        {
            var Entity = await Service.GetByIdAsync(Id);
            return Entity is null ? Results.NotFound() : Results.Ok(RefundDto.FromEntity(Entity));
        });
        Group.MapGet(RouteConstants.SubRefundsByPayment, async (string PaymentId, IRefundService Service) =>
            Results.Ok((await Service.ListByPaymentIdAsync(PaymentId)).Select(RefundDto.FromEntity)));
        Group.MapPost(RouteConstants.SubRoot, async (CreateRefundRequest Request, IRefundService Service) =>
        {
            var Entity = new RefundEntity
            {
                Id = Guid.NewGuid().ToString(),
                PaymentId = Request.PaymentId,
                AmountCents = Request.AmountCents,
                Currency = Request.Currency,
                Reason = Request.Reason
            };
            var Created = await Service.CreateRefundAsync(Entity);
            return Results.Created(RouteConstants.ApiRefunds, RefundDto.FromEntity(Created));
        });
        Group.MapMethods(RouteConstants.SubRefundById, [HttpMethods.Patch],
            async (string Id, UpdateRefundStatusRequest Request, IRefundService Service) =>
        {
            var Updated = await Service.UpdateStatusAsync(Id, Request.Status);
            return Updated is null ? Results.NotFound() : Results.Ok(RefundDto.FromEntity(Updated));
        });
        Group.MapDelete(RouteConstants.SubRefundById, async (string Id, IRefundService Service) =>
            await Service.DeleteAsync(Id) ? Results.NoContent() : Results.NotFound());
    }
}
