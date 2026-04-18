namespace PrTask.Application.Services;
public interface IRemittanceService
{
    Task<string> CreateRemittanceAsync(string RecipientMayaAccount, decimal Amount, string Currency, string RequestReferenceNumber);
    Task ExecuteRemittanceAsync(string TransactionReferenceNumber);
    Task<string> GetRemittanceStatusAsync(string TransactionReferenceNumber);
}
