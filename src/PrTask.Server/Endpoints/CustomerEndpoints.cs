using PrTask.Application.Contracts;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Server.Endpoints;
public static class CustomerEndpoints
{
    public static void MapCustomerEndpoints(this IEndpointRouteBuilder Routes)
    {
        var Group = Routes.MapGroup(RouteConstants.ApiCustomers).RequireAuthorization();
        Group.MapPost(RouteConstants.SubRoot, async (CreateCustomerRequest Request, IPaymentService Service) =>
        {
            var CustomerId = await Service.CreateCustomerAsync(Request.Email, Request.FirstName, Request.LastName);
            return string.IsNullOrEmpty(CustomerId) ? Results.BadRequest() : Results.Ok(new { CustomerId });
        });
        Group.MapGet(RouteConstants.SubCustomerById, async (string CustomerId, IPaymentService Service) =>
        {
            var Result = await Service.GetCustomerAsync(CustomerId);
            return string.IsNullOrEmpty(Result) ? Results.NotFound() : Results.Ok(Result);
        });
        Group.MapPut(RouteConstants.SubCustomerById, async (string CustomerId, UpdateCustomerRequest Request, IPaymentService Service) =>
            await Service.UpdateCustomerAsync(CustomerId, Request.Email, Request.FirstName, Request.LastName)
                ? Results.Ok() : Results.BadRequest());
        Group.MapDelete(RouteConstants.SubCustomerById, async (string CustomerId, IPaymentService Service) =>
            await Service.DeleteCustomerAsync(CustomerId) ? Results.NoContent() : Results.NotFound());
        Group.MapGet(RouteConstants.SubCustomerCards, async (string CustomerId, IPaymentService Service) =>
        {
            var Result = await Service.GetVaultedCardsAsync(CustomerId);
            return string.IsNullOrEmpty(Result) ? Results.NotFound() : Results.Ok(Result);
        });
        Group.MapGet(RouteConstants.SubCustomerCard, async (string CustomerId, string CardToken, IPaymentService Service) =>
        {
            var Result = await Service.GetVaultedCardAsync(CustomerId, CardToken);
            return string.IsNullOrEmpty(Result) ? Results.NotFound() : Results.Ok(Result);
        });
        Group.MapPost(RouteConstants.SubCustomerCards, async (string CustomerId, VaultCardRequest Request, IPaymentService Service) =>
        {
            var CardToken = await Service.VaultCardAsync(CustomerId, Request.PaymentTokenId, Request.IsDefault);
            return string.IsNullOrEmpty(CardToken) ? Results.BadRequest() : Results.Ok(new { CardToken });
        });
        Group.MapPut(RouteConstants.SubCustomerCard, async (string CustomerId, string CardToken, VaultCardRequest Request, IPaymentService Service) =>
            await Service.UpdateVaultedCardAsync(CustomerId, CardToken, Request.IsDefault) ? Results.Ok() : Results.BadRequest());
        Group.MapDelete(RouteConstants.SubCustomerCard, async (string CustomerId, string CardToken, IPaymentService Service) =>
            await Service.DeleteVaultedCardAsync(CustomerId, CardToken) ? Results.NoContent() : Results.NotFound());
        Group.MapPost(RouteConstants.SubCustomerCardPay, async (string CustomerId, string CardToken, CardPaymentRequest Request, IPaymentService Service) =>
        {
            var VerificationUrl = await Service.PayWithVaultedCardAsync(CustomerId, CardToken, Request.TaskId, Request.AmountCents);
            return string.IsNullOrEmpty(VerificationUrl) ? Results.BadRequest() : Results.Ok(new { VerificationUrl });
        });
    }
}
