namespace PrTask.Domain.Common;

/// <summary>
/// Represents a domain error with a code and description.
/// </summary>
public sealed record Error(string Code, string Description)
{
    public static readonly Error None = new(string.Empty, string.Empty);

    public static Error Validation(string Description) =>
        new("Validation", Description);

    public static Error NotFound(string Description) =>
        new("NotFound", Description);

    public static Error Conflict(string Description) =>
        new("Conflict", Description);

    public static Error Failure(string Description) =>
        new("Failure", Description);

    public static Error Unauthorized(string Description) =>
        new("Unauthorized", Description);

    public static Error Forbidden(string Description) =>
        new("Forbidden", Description);

    public override string ToString() => $"{Code}: {Description}";
}
