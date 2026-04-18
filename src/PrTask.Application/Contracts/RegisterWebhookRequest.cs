namespace PrTask.Application.Contracts;
public record RegisterWebhookRequest(string EventName, string CallbackUrl);
