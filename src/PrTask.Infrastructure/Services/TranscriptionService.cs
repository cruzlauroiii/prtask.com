using PrTask.Application.Services;
namespace PrTask.Infrastructure.Services;
public sealed class TranscriptionService : ITranscriptionService
{
    public Task<string> TranscribeAsync(Stream AudioStream) => Task.FromResult(string.Empty);
    public Task<string> TranscribeAsync(string FilePath) => Task.FromResult(string.Empty);
    public Task<bool> IsModelLoadedAsync() => Task.FromResult(false);
}
