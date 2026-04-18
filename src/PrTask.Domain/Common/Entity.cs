namespace PrTask.Domain.Common;

#pragma warning disable S4035
public abstract class Entity : IEquatable<Entity>
#pragma warning restore S4035
{
    private readonly List<DomainEvent> DomainEventsList = [];

    public required string Id { get; init; }

    public IReadOnlyList<DomainEvent> DomainEvents => DomainEventsList.AsReadOnly();

    public void AddDomainEvent(DomainEvent DomainEvent) =>
        DomainEventsList.Add(DomainEvent);

    public void ClearDomainEvents() =>
        DomainEventsList.Clear();

    public override bool Equals(object? Obj) =>
        Obj is Entity Other && Equals(Other);

    public bool Equals(Entity? Other) =>
        Other is not null && (ReferenceEquals(this, Other) || Id == Other.Id);

    public override int GetHashCode() =>
        string.GetHashCode(Id, StringComparison.Ordinal);

    public static bool operator ==(Entity? Left, Entity? Right) =>
        Left is null ? Right is null : Left.Equals(Right);

    public static bool operator !=(Entity? Left, Entity? Right) =>
        !(Left == Right);
}
