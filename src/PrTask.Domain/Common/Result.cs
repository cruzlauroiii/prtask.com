namespace PrTask.Domain.Common;

public class Result
{
    protected Result(bool IsSuccess, DomainError DomainError)
    {
        if (IsSuccess && DomainError != DomainError.None)
        {
            throw new ArgumentException("Success result cannot have an error.", nameof(DomainError));
        }

        if (!IsSuccess && DomainError == DomainError.None)
        {
            throw new ArgumentException("Failure result must have an error.", nameof(DomainError));
        }

        this.IsSuccess = IsSuccess;
        this.DomainError = DomainError;
    }

    public bool IsSuccess { get; }

    public bool IsFailure => !IsSuccess;

    public DomainError DomainError { get; }

    public static Result Success() => new(true, DomainError.None);

    public static Result<TValue> Success<TValue>(TValue Value) =>
        new(Value, true, DomainError.None);

    public static Result Failure(DomainError DomainError) => new(false, DomainError);

    public static Result<TValue> Failure<TValue>(DomainError DomainError) =>
        new(default, false, DomainError);
}
