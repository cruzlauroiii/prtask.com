using PrTask.Application.Contracts;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Server.Endpoints;
public static class PaymentRecordEndpoints
{
    public static void MapPaymentRecordEndpoints(this IEndpointRouteBuilder Routes)
    {
        var Group = Routes.MapGroup(RouteConstants.ApiPaymentRecords).RequireAuthorization();
        Group.MapGet(RouteConstants.SubPaymentById, async (string PaymentId, IPaymentRecordService Service) =>
        {
            var Entity = await Service.GetByIdAsync(PaymentId);
            return Entity is null ? Results.NotFound() : Results.Ok(PaymentDto.FromEntity(Entity));
        });
        Group.MapGet(RouteConstants.SubByPayer, async (string PayerId, IPaymentRecordService Service) =>
            Results.Ok((await Service.ListByPayerAsync(PayerId)).Select(PaymentDto.FromEntity)));
        Group.MapGet(RouteConstants.SubByTask, async (string TaskId, IPaymentRecordService Service) =>
            Results.Ok((await Service.ListByTaskAsync(TaskId)).Select(PaymentDto.FromEntity)));
        Group.MapGet(RouteConstants.SubByMayaPaymentId, async (string MayaPaymentId, IPaymentRecordService Service) =>
        {
            var Entity = await Service.GetByMayaPaymentIdAsync(MayaPaymentId);
            return Entity is null ? Results.NotFound() : Results.Ok(PaymentDto.FromEntity(Entity));
        });
        Group.MapPost(RouteConstants.SubRoot, async (CreatePaymentRecordRequest Request, IPaymentRecordService Service) =>
        {
            var Entity = new PaymentEntity
            {
                Id = Guid.NewGuid().ToString(),
                PayerId = Request.PayerId,
                PayeeId = Request.PayeeId,
                TaskId = Request.TaskId,
                PullRequestId = Request.PullRequestId,
                AmountCents = Request.AmountCents,
                PlatformFeeCents = Request.PlatformFeeCents,
                Type = Request.Type
            };
            var Created = await Service.CreateAsync(Entity);
            return Results.Created(
                FormatStrings.ApiResourcePath(RouteConstants.ApiPaymentRecords, Created.Id),
                PaymentDto.FromEntity(Created));
        });
        Group.MapPut(RouteConstants.SubPaymentById, async (string PaymentId, UpdatePaymentRecordRequest Request, IPaymentRecordService Service) =>
        {
            var Existing = await Service.GetByIdAsync(PaymentId);
            if (Existing is null)
            {
                return Results.NotFound();
            }
            Existing.MayaCheckoutId = Request.MayaCheckoutId;
            Existing.MayaPaymentId = Request.MayaPaymentId;
            Existing.PayeeId = Request.PayeeId;
            Existing.AmountCents = Request.AmountCents;
            Existing.PlatformFeeCents = Request.PlatformFeeCents;
            Existing.Status = Request.Status;
            Existing.MayaStatus = Request.MayaStatus;
            var Updated = await Service.UpdateAsync(Existing);
            return Results.Ok(PaymentDto.FromEntity(Updated));
        });
        Group.MapDelete(RouteConstants.SubPaymentById, async (string PaymentId, IPaymentRecordService Service) =>
        {
            await Service.DeleteAsync(PaymentId);
            return Results.NoContent();
        });
    }
}
