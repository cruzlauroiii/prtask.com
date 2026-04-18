namespace PrTask.Application.Services;
public interface IPaymentV2Service
{
    Task<string> CreatePaymentV2Async(string ConnectToken, decimal Amount, string Currency, string RequestReferenceNumber);
    Task<string> GetPaymentV2Async(string PaymentId);
}
