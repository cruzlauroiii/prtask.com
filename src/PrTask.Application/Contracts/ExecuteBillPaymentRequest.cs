namespace PrTask.Application.Contracts;
public record ExecuteBillPaymentRequest(
    string? CardNumber, string? ExpMonth, string? ExpYear,
    string? Cvc, bool UsePushPayment);
