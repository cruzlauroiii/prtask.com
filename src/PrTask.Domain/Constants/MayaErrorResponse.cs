namespace PrTask.Domain.Constants;
public record MayaErrorParameter(string Field, string Description);

public record MayaErrorDetails(string ErrorClass);

public record MayaErrorResponse(
    string Code,
    string Message,
    IReadOnlyList<MayaErrorParameter> Parameters,
    MayaErrorDetails Details);
