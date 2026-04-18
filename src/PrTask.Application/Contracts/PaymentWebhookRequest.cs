namespace PrTask.Application.Contracts;
public record PaymentWebhookRequest(string EventType, string PayloadJson);
