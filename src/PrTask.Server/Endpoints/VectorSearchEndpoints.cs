using PrTask.Application.Contracts;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Server.Endpoints;
public static class VectorSearchEndpoints
{
    public static void MapVectorSearchEndpoints(this IEndpointRouteBuilder Routes)
    {
        var Group = Routes.MapGroup(RouteConstants.ApiVectorSearch).RequireAuthorization();
        Group.MapPost(RouteConstants.SubIndex, async (VectorSearchIndexRequest Request, IVectorSearchService Service) =>
        {
            await Service.IndexAsync(Request.Id, Request.Embedding);
            return Results.Ok();
        });
        Group.MapPost(RouteConstants.SubQuery, async (VectorSearchQueryRequest Request, IVectorSearchService Service) =>
            Results.Ok(new { Results = await Service.SearchAsync(Request.Query, Request.TopK) }));
        Group.MapDelete(RouteConstants.SubVectorById, async (string ItemId, IVectorSearchService Service) =>
        {
            await Service.DeleteAsync(ItemId);
            return Results.NoContent();
        });
        Group.MapGet(RouteConstants.SubCount, async (IVectorSearchService Service) =>
            Results.Ok(new { Count = await Service.CountAsync() }));
    }
}
