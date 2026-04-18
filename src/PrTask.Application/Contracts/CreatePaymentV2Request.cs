namespace PrTask.Application.Contracts;
public record CreatePaymentV2Request(string ConnectToken, decimal Amount, string Currency, string RequestReferenceNumber);
