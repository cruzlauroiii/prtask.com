namespace PrTask.Application.Services;
public sealed record GoogleTokenResult(string AccessToken, string? RefreshToken, string? IdToken, int ExpiresIn);
