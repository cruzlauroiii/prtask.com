using PrTask.Application.Contracts;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Server.Endpoints;
public static partial class P3PaymentEndpoints
{
    private static void MapRecurringEndpoints(RouteGroupBuilder Group)
    {
        Group.MapPost(RouteConstants.SubP3Recurring, async (P3RecurringPaymentRequest Request, IP3PaymentService Service) =>
        {
            var Result = await Service.CreateRecurringPaymentAsync(
                Request.CardNumber, Request.ExpMonth, Request.ExpYear, Request.Cvc,
                Request.Amount, Request.Currency, Request.RequestReferenceNumber,
                Request.FrequencyIndicator);
            return string.IsNullOrEmpty(Result) ? Results.BadRequest() : Results.Created(RouteConstants.SubP3Recurring, Result);
        }).RequireAuthorization();
    }
}
