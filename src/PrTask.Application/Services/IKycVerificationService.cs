namespace PrTask.Application.Services;
public interface IKycVerificationService
{
    Task<(string SessionId, string VerificationUrl)> CreateSessionAsync(string UserId, string? CallbackUrl);
    Task<(string Status, string FullName)> GetSessionStatusAsync(string SessionId);
    Task UpdateSessionStatusAsync(string SessionId, string NewStatus, string? Comment);
    Task<string> ListSessionsAsync(string? VendorData, string? Status);
    Task DeleteSessionAsync(string SessionId);
}
