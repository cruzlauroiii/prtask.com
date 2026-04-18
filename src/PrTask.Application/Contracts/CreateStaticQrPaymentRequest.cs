namespace PrTask.Application.Contracts;
public record CreateStaticQrPaymentRequest(
    string P2mId, decimal Amount, string Currency, string RequestReferenceNumber);
