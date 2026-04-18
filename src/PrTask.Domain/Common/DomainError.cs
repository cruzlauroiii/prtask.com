namespace PrTask.Domain.Common;

public sealed record DomainError(string Code, string Description)
{
    public static readonly DomainError None = new(string.Empty, string.Empty);

    public static DomainError Validation(string Description) =>
        new("Validation", Description);

    public static DomainError NotFound(string Description) =>
        new("NotFound", Description);

    public static DomainError Conflict(string Description) =>
        new("Conflict", Description);

    public static DomainError Failure(string Description) =>
        new("Failure", Description);

    public static DomainError Unauthorized(string Description) =>
        new("Unauthorized", Description);

    public static DomainError Forbidden(string Description) =>
        new("Forbidden", Description);

    public override string ToString() => $"{Code}: {Description}";
}
