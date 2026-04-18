namespace PrTask.Application.Services;
public interface IKycProvider
{
    string ProviderName { get; }
    Task<KycSessionResult> CreateSessionAsync(string UserId, string? CallbackUrl, KycSessionOptions? Options);
    Task<KycSessionStatus> GetSessionStatusAsync(string SessionId);
    Task<bool> HandleWebhookAsync(string Payload, string? Signature);
}
