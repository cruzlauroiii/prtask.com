using PrTask.Application.Contracts;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Server.Endpoints;
public static class InferenceEndpoints
{
    public static void MapInferenceEndpoints(this IEndpointRouteBuilder Routes)
    {
        var Group = Routes.MapGroup(RouteConstants.ApiInference).RequireAuthorization();
        Group.MapPost(RouteConstants.SubCompletion, async (InferenceCompletionRequest Request, IInferenceService Service) =>
            Results.Ok(new { Completion = await Service.GenerateCompletionAsync(Request.Prompt) }));
        Group.MapPost(RouteConstants.SubEmbedding, async (InferenceEmbeddingRequest Request, IInferenceService Service) =>
            Results.Ok(new { Embedding = await Service.GenerateEmbeddingAsync(Request.Text) }));
        Group.MapGet(RouteConstants.SubStatus, async (IInferenceService Service) =>
            Results.Ok(new { ModelLoaded = await Service.IsModelLoadedAsync() }));
    }
}
