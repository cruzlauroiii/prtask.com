namespace PrTask.Application.Contracts;
public record CreateWalletLinkRequest(
    string RequestReferenceNumber, string SuccessUrl,
    string FailureUrl, string CancelUrl);
