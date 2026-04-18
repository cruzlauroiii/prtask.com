using PrTask.Application.Contracts;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Server.Endpoints;
public static class InvoiceEndpoints
{
    public static void MapInvoiceEndpoints(this IEndpointRouteBuilder Routes)
    {
        var Group = Routes.MapGroup(RouteConstants.ApiInvoices).RequireAuthorization();
        Group.MapPost(RouteConstants.SubRoot, async (CreateInvoiceRequest Request, IInvoiceService Service) =>
        {
            var Entity = await Service.CreateInvoiceAsync(
                Request.Amount, Request.Currency, Request.Description, Request.UserId);
            return Results.Created(
                FormatStrings.ApiResourcePath(RouteConstants.ApiInvoices, Entity.Id),
                InvoiceDto.FromEntity(Entity));
        });
        Group.MapGet(RouteConstants.SubRoot, async (string? UserId, IInvoiceService Service) =>
            Results.Ok((await Service.ListInvoicesAsync(UserId)).Select(InvoiceDto.FromEntity)));
        Group.MapGet(RouteConstants.SubInvoiceById, async (string InvoiceId, IInvoiceService Service) =>
        {
            var Entity = await Service.GetInvoiceAsync(InvoiceId);
            return Entity is null ? Results.NotFound() : Results.Ok(InvoiceDto.FromEntity(Entity));
        });
        Group.MapDelete(RouteConstants.SubInvoiceById, async (string InvoiceId, IInvoiceService Service) =>
            await Service.DeleteInvoiceAsync(InvoiceId) ? Results.NoContent() : Results.NotFound());
    }
}
