namespace PrTask.Application.Services;
public interface IDisbursementService
{
    Task<string> CreateSessionAsync(string Email, string Password);
    Task TerminateSessionAsync();
    Task<string> GetWalletAsync();
    Task<string> RegisterBeneficiariesAsync(string CsvContent);
    Task<string> SubmitDisbursementAsync(string CsvContent);
    Task<string> ProcessDisbursementAsync(string DisbursementId);
    Task<string> GetDisbursementStatusAsync(string DisbursementId);
}
