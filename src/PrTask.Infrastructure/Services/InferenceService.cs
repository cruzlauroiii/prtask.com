using PrTask.Application.Services;
namespace PrTask.Infrastructure.Services;
public sealed class InferenceService : IInferenceService
{
    public Task<float[]> GenerateEmbeddingAsync(string Text) => Task.FromResult<float[]>([]);
    public Task<string> GenerateCompletionAsync(string Prompt) => Task.FromResult(string.Empty);
    public Task<bool> IsModelLoadedAsync() => Task.FromResult(false);
}
