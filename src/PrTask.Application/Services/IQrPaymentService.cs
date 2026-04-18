namespace PrTask.Application.Services;
public interface IQrPaymentService
{
    Task<string> CreateDynamicQrAsync(decimal Amount, string Currency, string RequestReferenceNumber, string SuccessUrl, string FailureUrl, string CancelUrl);
    Task<string> CreateStaticQrPaymentAsync(string P2mId, decimal Amount, string Currency, string RequestReferenceNumber);
    Task<string> ExecuteQrPaymentAsync(string PaymentId);
    Task<string> GetQrPaymentAsync(string PaymentId);
}
