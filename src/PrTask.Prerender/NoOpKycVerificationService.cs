using PrTask.Application.Services;
namespace PrTask.Prerender;
public sealed class NoOpKycVerificationService : IKycVerificationService
{
    public Task<(string SessionId, string VerificationUrl)> CreateSessionAsync(string UserId, string? CallbackUrl) => Task.FromResult((string.Empty, string.Empty));
    public Task<(string Status, string FullName)> GetSessionStatusAsync(string SessionId) => Task.FromResult((string.Empty, string.Empty));
    public Task UpdateSessionStatusAsync(string SessionId, string NewStatus, string? Comment) => Task.CompletedTask;
    public Task<string> ListSessionsAsync(string? VendorData, string? Status) => Task.FromResult(string.Empty);
    public Task DeleteSessionAsync(string SessionId) => Task.CompletedTask;
}
