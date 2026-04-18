namespace PrTask.Application.Contracts;
public record CreateRemittanceRequest(
    string RecipientMayaAccount, decimal Amount,
    string Currency, string RequestReferenceNumber);
