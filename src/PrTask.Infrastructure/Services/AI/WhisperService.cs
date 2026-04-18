using PrTask.Application.Services;
namespace PrTask.Infrastructure.Services.AI;
public sealed class WhisperService : ITranscriptionService
{
    public Task<string> TranscribeAsync(Stream AudioStream) => Task.FromResult(string.Empty);
    public Task<string> TranscribeAsync(string FilePath) => Task.FromResult(string.Empty);
    public Task<bool> IsModelLoadedAsync() => Task.FromResult(false);
}
