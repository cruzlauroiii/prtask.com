namespace PrTask.Application.Contracts;
public record P3AuthorizeRequest(
    string CardNumber, string ExpMonth, string ExpYear, string Cvc,
    decimal Amount, string Currency, string RequestReferenceNumber);
