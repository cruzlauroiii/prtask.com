using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Server.Endpoints;
public static class DiffEndpoints
{
    public static void MapDiffEndpoints(this IEndpointRouteBuilder Routes)
    {
        var Group = Routes.MapGroup(RouteConstants.ApiDiff);
        Group.MapPost(RouteConstants.SubDiffCompute, (DiffComputeRequest Request, IDiffComputeService Service) =>
        {
            var Result = Service.ComputeDiff(Request.OldText ?? string.Empty, Request.NewText ?? string.Empty);
            var Language = Service.DetectLanguage(Request.FileName ?? DiffConstants.DefaultFileName);
            return Results.Ok(new
            {
                Result.InlineLines,
                Result.OldLines,
                Result.NewLines,
                Result.Additions,
                Result.Deletions,
                Result.Modifications,
                Language
            });
        });
        Group.MapGet(RouteConstants.SubDiffLanguage, (string FileName, IDiffComputeService Service) =>
        {
            var Language = Service.DetectLanguage(FileName);
            return Results.Ok(new { FileName, Language });
        });
    }
    public sealed record DiffComputeRequest(string? OldText, string? NewText, string? FileName);
}
