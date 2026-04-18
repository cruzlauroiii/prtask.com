namespace PrTask.Application.Services;
public interface IInferenceService
{
    Task<float[]> GenerateEmbeddingAsync(string Text);
    Task<string> GenerateCompletionAsync(string Prompt);
    Task<bool> IsModelLoadedAsync();
}
