using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Server.Endpoints;
public static class TranscriptionEndpoints
{
    public static void MapTranscriptionEndpoints(this IEndpointRouteBuilder Routes)
    {
        var Group = Routes.MapGroup(RouteConstants.ApiTranscription).RequireAuthorization();
        Group.MapPost(RouteConstants.SubTranscribe, async (HttpRequest Request, ITranscriptionService Service) =>
        {
            var Text = await Service.TranscribeAsync(Request.Body);
            return Results.Ok(new { Text });
        });
        Group.MapGet(RouteConstants.SubStatus, async (ITranscriptionService Service) =>
            Results.Ok(new { ModelLoaded = await Service.IsModelLoadedAsync() }));
    }
}
