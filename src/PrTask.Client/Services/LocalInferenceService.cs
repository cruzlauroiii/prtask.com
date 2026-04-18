using PrTask.Application.Services;
namespace PrTask.Client.Services;
public class LocalInferenceService : IInferenceService
{
    public Task<float[]> GenerateEmbeddingAsync(string Text) =>
        Task.FromResult(Array.Empty<float>());

    public Task<string> GenerateCompletionAsync(string Prompt) =>
        Task.FromResult(string.Empty);

    public Task<bool> IsModelLoadedAsync() =>
        Task.FromResult(false);
}
