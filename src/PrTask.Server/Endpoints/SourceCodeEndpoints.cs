using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Server.Endpoints;
public static class SourceCodeEndpoints
{
    public static void MapSourceCodeEndpoints(this IEndpointRouteBuilder Routes)
    {
        var Group = Routes.MapGroup(RouteConstants.ApiSourceCode);
        Group.MapPost(RouteConstants.SubSourceUpload, async (string TaskId, IDictionary<string, string> Files, ISourceCodeService Service) =>
        {
            await Service.StoreFilesAsync(TaskId, Files);
            return Results.Ok(new { TaskId, FileCount = Files.Count });
        }).RequireAuthorization();
        Group.MapGet(RouteConstants.SubSourceFiles, async (string TaskId, ISourceCodeService Service) =>
        {
            var Files = await Service.GetFilesAsync(TaskId);
            return Results.Ok(Files);
        });
        Group.MapPost(RouteConstants.SubSourceModify, async (string TaskId, string PrId, IDictionary<string, string> Files, ISourceCodeService Service) =>
        {
            await Service.StoreModifiedFilesAsync(TaskId, PrId, Files);
            return Results.Ok(new { TaskId, PrId, FileCount = Files.Count });
        }).RequireAuthorization();
        Group.MapGet(RouteConstants.SubSourceModifiedFiles, async (string TaskId, string PrId, ISourceCodeService Service) =>
        {
            var Files = await Service.GetModifiedFilesAsync(TaskId, PrId);
            return Results.Ok(Files);
        });
        Group.MapGet(RouteConstants.SubSourceDiff, async (string TaskId, string PrId, ISourceCodeService Service) =>
        {
            var Diff = await Service.GenerateDiffAsync(TaskId, PrId);
            return Results.Ok(new { TaskId, PrId, Diff });
        });
        Group.MapDelete(RouteConstants.SubSourceDelete, async (string TaskId, ISourceCodeService Service) =>
        {
            await Service.DeleteFilesAsync(TaskId);
            return Results.NoContent();
        }).RequireAuthorization();
    }
}
