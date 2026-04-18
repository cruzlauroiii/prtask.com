namespace PrTask.Application.Contracts;
public record CreateDynamicQrRequest(
    decimal Amount, string Currency, string RequestReferenceNumber,
    string SuccessUrl, string FailureUrl, string CancelUrl);
