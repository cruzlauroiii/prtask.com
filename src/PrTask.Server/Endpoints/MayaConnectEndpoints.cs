using PrTask.Application.Contracts;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Server.Endpoints;
public static class MayaConnectEndpoints
{
    public static void MapMayaConnectEndpoints(this IEndpointRouteBuilder Routes)
    {
        var Group = Routes.MapGroup(RouteConstants.ApiMayaConnect).RequireAuthorization();
        Group.MapGet(RouteConstants.SubAuthorize, async (string RedirectUri, string? Scope, IMayaConnectService Service) =>
            Results.Ok(new { Url = await Service.AuthorizeAsync(RedirectUri, Scope ?? MayaConstants.ConnectDefaultScope) }));
        Group.MapPost(RouteConstants.SubToken, async (ExchangeTokenRequest Request, IMayaConnectService Service) =>
        {
            var Json = await Service.ExchangeTokenAsync(Request.Code, Request.RedirectUri);
            return string.IsNullOrEmpty(Json) ? Results.BadRequest() : Results.Content(Json, AppConstants.ContentTypeJson);
        });
        Group.MapPost(RouteConstants.SubRefresh, async (RefreshTokenRequest Request, IMayaConnectService Service) =>
        {
            var Json = await Service.RefreshTokenAsync(Request.RefreshToken);
            return string.IsNullOrEmpty(Json) ? Results.BadRequest() : Results.Content(Json, AppConstants.ContentTypeJson);
        });
        Group.MapGet(RouteConstants.SubUserInfo, async (string AccessToken, IMayaConnectService Service) =>
        {
            var Json = await Service.GetUserInfoAsync(AccessToken);
            return string.IsNullOrEmpty(Json) ? Results.BadRequest() : Results.Content(Json, AppConstants.ContentTypeJson);
        });
        Group.MapGet(RouteConstants.SubJwk, async (IMayaConnectService Service) =>
        {
            var Json = await Service.GetJwkAsync();
            return string.IsNullOrEmpty(Json) ? Results.BadRequest() : Results.Content(Json, AppConstants.ContentTypeJson);
        });
    }
}
