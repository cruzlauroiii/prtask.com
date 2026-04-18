using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Client.Services;
public class LocalKycVerificationService(ILocalStoreService Store) : IKycVerificationService
{
    public async Task<(string SessionId, string VerificationUrl)> CreateSessionAsync(string UserId, string? CallbackUrl)
    {
        var SessionId = Guid.NewGuid().ToString();
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeCreateKycSession, UserId, CallbackUrl, SessionId });
        return (SessionId, string.Empty);
    }

    public Task<(string Status, string FullName)> GetSessionStatusAsync(string SessionId) =>
        Task.FromResult((string.Empty, string.Empty));

    public async Task UpdateSessionStatusAsync(string SessionId, string NewStatus, string? Comment) =>
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeUpdateKycStatus, SessionId, NewStatus, Comment });

    public Task<string> ListSessionsAsync(string? VendorData, string? Status) =>
        Task.FromResult(string.Empty);

    public async Task DeleteSessionAsync(string SessionId) =>
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeDeleteKycSession, SessionId });
}
