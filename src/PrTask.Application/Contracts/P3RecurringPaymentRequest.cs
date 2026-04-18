namespace PrTask.Application.Contracts;
public record P3RecurringPaymentRequest(
    string CardNumber, string ExpMonth, string ExpYear, string Cvc,
    decimal Amount, string Currency, string RequestReferenceNumber,
    string FrequencyIndicator);
