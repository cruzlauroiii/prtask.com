namespace PrTask.Server.Endpoints;
public record ClaimRequest(string DeveloperId);
public record RejectRequest(string Notes);
public record CheckoutRequest(string TaskId, string PayerId, long AmountCents);
public record CheckoutResponse(string CheckoutUrl);
public record WebhookRequest(string EventType, string PayloadJson);
public record PaymentStatusResponse(string Status);
public record RankResponse(int Rank);
