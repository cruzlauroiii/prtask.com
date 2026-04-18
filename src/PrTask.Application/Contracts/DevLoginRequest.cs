namespace PrTask.Application.Contracts;
public record DevLoginRequest(string UserId, string Username, string? Provider = null);
