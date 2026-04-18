namespace PrTask.Application.Services;
public sealed record WssMessage(
    string Type,
    string? Id,
    string? Collection,
    string? Operation,
    string? Channel,
    string? Message,
    object? Data,
    string? Timestamp);
