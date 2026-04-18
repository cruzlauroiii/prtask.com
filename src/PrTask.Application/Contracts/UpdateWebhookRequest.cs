namespace PrTask.Application.Contracts;
public record UpdateWebhookRequest(string? EventName, string? CallbackUrl);
