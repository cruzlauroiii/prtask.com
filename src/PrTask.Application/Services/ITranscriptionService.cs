namespace PrTask.Application.Services;
public interface ITranscriptionService
{
    Task<string> TranscribeAsync(Stream AudioStream);
    Task<string> TranscribeAsync(string FilePath);
    Task<bool> IsModelLoadedAsync();
}
