using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Server.Endpoints;
public static class PlainTextDbEndpoints
{
    public static void MapPlainTextDbEndpoints(this IEndpointRouteBuilder Routes)
    {
        var Group = Routes.MapGroup(RouteConstants.ApiPlainTextDb).RequireAuthorization();
        Group.MapGet(RouteConstants.SubCollection, async (string Collection, IPlainTextDbService Service) =>
            Results.Ok(await Service.ListAsync(Collection)));
        Group.MapGet(RouteConstants.SubCollectionItem, async (string Collection, string ItemId, IPlainTextDbService Service) =>
        {
            var Data = await Service.ReadAsync(Collection, ItemId);
            return string.IsNullOrEmpty(Data) ? Results.NotFound() : Results.Content(Data, AppConstants.ContentTypeJson);
        });
        Group.MapPut(RouteConstants.SubCollectionItem, async (string Collection, string ItemId, HttpRequest Request, IPlainTextDbService Service) =>
        {
            using var Reader = new StreamReader(Request.Body);
            var JsonData = await Reader.ReadToEndAsync();
            await Service.WriteAsync(Collection, ItemId, JsonData);
            return Results.Ok();
        });
        Group.MapDelete(RouteConstants.SubCollectionItem, async (string Collection, string ItemId, IPlainTextDbService Service) =>
        {
            await Service.DeleteAsync(Collection, ItemId);
            return Results.NoContent();
        });
        Group.MapGet(RouteConstants.SubCollectionExport, async (string Collection, IPlainTextDbService Service) =>
            Results.Content(await Service.ExportCollectionAsync(Collection), AppConstants.ContentTypeJson));
        Group.MapPost(RouteConstants.SubCollectionImport, async (string Collection, HttpRequest Request, IPlainTextDbService Service) =>
        {
            using var Reader = new StreamReader(Request.Body);
            var JsonData = await Reader.ReadToEndAsync();
            await Service.ImportCollectionAsync(Collection, JsonData);
            return Results.Ok();
        });
    }
}
