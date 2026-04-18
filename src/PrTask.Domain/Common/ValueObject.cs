namespace PrTask.Domain.Common;

#pragma warning disable S4035
public abstract class ValueObject : IEquatable<ValueObject>
#pragma warning restore S4035
{
    protected abstract IEnumerable<object?> GetEqualityComponents();

    public override bool Equals(object? Obj) =>
        Obj is ValueObject Other && Other.GetType() == GetType() && Equals(Other);

    public bool Equals(ValueObject? Other) =>
        Other is not null
        && Other.GetType() == GetType()
        && GetEqualityComponents().SequenceEqual(Other.GetEqualityComponents());

    public override int GetHashCode() =>
        GetEqualityComponents()
            .Aggregate(0, (Current, Component) => HashCode.Combine(Current, Component));

    public static bool operator ==(ValueObject? Left, ValueObject? Right) =>
        Left is null ? Right is null : Left.Equals(Right);

    public static bool operator !=(ValueObject? Left, ValueObject? Right) =>
        !(Left == Right);
}
