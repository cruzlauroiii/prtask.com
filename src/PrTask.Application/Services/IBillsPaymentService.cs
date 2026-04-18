using PrTask.Domain.Models;
namespace PrTask.Application.Services;
public interface IBillsPaymentService
{
    Task<IReadOnlyList<BillerInfo>> GetBillersAsync();
    Task<BillerInfo?> GetBillerAsync(string Slug);
    Task<string> CreateBillPaymentAsync(string BillerSlug, string AccountNumber, decimal Amount, string Currency, string? CallbackUrl);
    Task ExecuteBillPaymentAsync(string BillPaymentId, string? CardNumber, string? ExpMonth, string? ExpYear, string? Cvc, bool UsePushPayment);
    Task<string> GetBillPaymentStatusAsync(string BillPaymentId);
}
