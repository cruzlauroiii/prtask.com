using PrTask.Application.Contracts;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Server.Endpoints;
public static partial class PaymentEndpoints
{
    private static void MapVaultEndpoints(RouteGroupBuilder Group)
    {
        Group.MapPost(RouteConstants.SubCustomerCardsList, async (string CustomerId, VaultCardRequest Request, IPaymentService Service) =>
        {
            var CardToken = await Service.VaultCardAsync(CustomerId, Request.PaymentTokenId, Request.IsDefault);
            return string.IsNullOrEmpty(CardToken) ? Results.BadRequest() : Results.Created(FormatStrings.PaymentCustomerCardPath(CustomerId, CardToken), new { CardToken });
        }).RequireAuthorization();
        Group.MapGet(RouteConstants.SubCustomerCardsList, async (string CustomerId, IPaymentService Service) =>
        {
            var Cards = await Service.GetVaultedCardsAsync(CustomerId);
            return string.IsNullOrEmpty(Cards) ? Results.NotFound() : Results.Ok(Cards);
        }).RequireAuthorization();
        Group.MapGet(RouteConstants.SubCustomerCardByToken, async (string CustomerId, string Token, IPaymentService Service) =>
        {
            var Card = await Service.GetVaultedCardAsync(CustomerId, Token);
            return string.IsNullOrEmpty(Card) ? Results.NotFound() : Results.Ok(Card);
        }).RequireAuthorization();
        Group.MapDelete(RouteConstants.SubCustomerCardByToken, async (string CustomerId, string Token, IPaymentService Service) =>
            await Service.DeleteVaultedCardAsync(CustomerId, Token) ? Results.NoContent() : Results.NotFound())
            .RequireAuthorization();
        Group.MapPost(RouteConstants.SubVaultPay, async (VaultPayRequest Request, IPaymentService Service) =>
        {
            var Result = await Service.PayWithVaultedCardAsync(Request.CustomerId, Request.CardToken, Request.TaskId, Request.AmountCents);
            return string.IsNullOrEmpty(Result) ? Results.BadRequest() : Results.Ok(Result);
        }).RequireAuthorization();
    }

    private static void MapWebhookManagementEndpoints(RouteGroupBuilder Group)
    {
        Group.MapPost(RouteConstants.SubWebhooks, async (RegisterWebhookRequest Request, IPaymentService Service) =>
        {
            var WebhookId = await Service.RegisterWebhookAsync(Request.EventName, Request.CallbackUrl);
            return string.IsNullOrEmpty(WebhookId) ? Results.BadRequest() : Results.Created(FormatStrings.PaymentWebhookPath(WebhookId), new { WebhookId });
        }).RequireAuthorization();
        Group.MapGet(RouteConstants.SubWebhooks, async (IPaymentService Service) =>
            Results.Ok(await Service.GetWebhooksAsync()))
            .RequireAuthorization();
        Group.MapPut(RouteConstants.SubWebhooksById, async (string WebhookId, UpdateWebhookRequest Request, IPaymentService Service) =>
            await Service.UpdateWebhookAsync(WebhookId, Request.EventName, Request.CallbackUrl) ? Results.Ok() : Results.NotFound())
            .RequireAuthorization();
        Group.MapDelete(RouteConstants.SubWebhooksById, async (string WebhookId, IPaymentService Service) =>
            await Service.DeleteWebhookAsync(WebhookId) ? Results.NoContent() : Results.NotFound())
            .RequireAuthorization();
    }
}
