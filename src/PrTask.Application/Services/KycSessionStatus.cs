namespace PrTask.Application.Services;
public sealed record KycSessionStatus(string SessionId, string Status, string? FullName, string? DocumentType, DateTime? DecisionAt);
