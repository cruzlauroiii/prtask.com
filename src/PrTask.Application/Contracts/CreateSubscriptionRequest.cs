namespace PrTask.Application.Contracts;
public record CreateSubscriptionRequest(
    string CustomerId, string CardTokenId, string Description,
    decimal Amount, string Currency, string Interval,
    int IntervalCount, DateTimeOffset StartDate);
