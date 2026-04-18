namespace PrTask.Application.Contracts;
public sealed record OidcUserResponse(string SubjectId, string? Name, string? Email, string? Picture);
