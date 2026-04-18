namespace PrTask.Domain.Models;
public record MayaErrorResponse(
    string Code,
    string Message,
    IReadOnlyList<MayaErrorParameter> Parameters,
    MayaErrorDetails Details);
