namespace PrTask.Application.Contracts;
public sealed record GitHubUserResponse(long Id, string Login, string? Name, string? AvatarUrl, string? Email);
