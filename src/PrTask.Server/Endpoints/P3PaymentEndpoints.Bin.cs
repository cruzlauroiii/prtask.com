using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Server.Endpoints;
public static partial class P3PaymentEndpoints
{
    private static void MapBinEndpoints(RouteGroupBuilder Group)
    {
        Group.MapGet(RouteConstants.SubP3BinByValue, async (string Bin, IP3PaymentService Service) =>
        {
            var Result = await Service.GetBinAsync(Bin);
            return string.IsNullOrEmpty(Result) ? Results.NotFound() : Results.Ok(Result);
        }).RequireAuthorization();

        Group.MapPost(RouteConstants.SubP3BinsQuery, async (IP3PaymentService Service) =>
        {
            var Result = await Service.QueryBinsAsync();
            return string.IsNullOrEmpty(Result) ? Results.BadRequest() : Results.Ok(Result);
        }).RequireAuthorization();

        Group.MapGet(RouteConstants.SubP3BinPatterns, async (IP3PaymentService Service) =>
        {
            var Result = await Service.GetBinPatternsAsync();
            return string.IsNullOrEmpty(Result) ? Results.NotFound() : Results.Ok(Result);
        }).RequireAuthorization();

        Group.MapGet(RouteConstants.SubP3BinDelta, async (IP3PaymentService Service) =>
        {
            var Result = await Service.GetBinDeltaAsync();
            return string.IsNullOrEmpty(Result) ? Results.NotFound() : Results.Ok(Result);
        }).RequireAuthorization();
    }

    private static void MapApiKeyEndpoints(RouteGroupBuilder Group)
    {
        Group.MapPost(RouteConstants.SubP3ApiKeys, async (IP3PaymentService Service) =>
        {
            var Result = await Service.CreateApiKeyAsync();
            return string.IsNullOrEmpty(Result) ? Results.BadRequest() : Results.Created(RouteConstants.SubP3ApiKeys, Result);
        }).RequireAuthorization();

        Group.MapGet(RouteConstants.SubP3ApiKeyById, async (string KeyId, IP3PaymentService Service) =>
        {
            var Result = await Service.GetApiKeyAsync(KeyId);
            return string.IsNullOrEmpty(Result) ? Results.NotFound() : Results.Ok(Result);
        }).RequireAuthorization();

        Group.MapGet(RouteConstants.SubP3ApiKeys, async (IP3PaymentService Service) =>
            Results.Ok(await Service.ListApiKeysAsync()))
            .RequireAuthorization();

        Group.MapDelete(RouteConstants.SubP3ApiKeyById, async (string KeyId, IP3PaymentService Service) =>
            await Service.DeleteApiKeyAsync(KeyId) ? Results.NoContent() : Results.NotFound())
            .RequireAuthorization();
    }
}
