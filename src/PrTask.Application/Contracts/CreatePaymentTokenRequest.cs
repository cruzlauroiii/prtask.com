namespace PrTask.Application.Contracts;
public record CreatePaymentTokenRequest(
    string CardNumber, string ExpMonth, string ExpYear, string Cvc);
