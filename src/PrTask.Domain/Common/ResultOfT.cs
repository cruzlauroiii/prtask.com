namespace PrTask.Domain.Common;

public class Result<TValue> : Result
{
    internal Result(TValue? Value, bool IsSuccess, DomainError DomainError)
        : base(IsSuccess, DomainError)
    {
        this.Value = IsSuccess
            ? Value!
            : default!;
    }

    public TValue Value { get; }

#pragma warning disable CA2225
    public static implicit operator Result<TValue>(TValue Value) =>
        Success(Value);
#pragma warning restore CA2225
}
