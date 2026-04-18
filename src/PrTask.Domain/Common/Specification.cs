using System.Linq.Expressions;

namespace PrTask.Domain.Common;

public abstract class Specification<T> : ISpecification<T>
{
    public abstract Expression<Func<T, bool>> Criteria { get; }

    public bool IsSatisfiedBy(T Entity) =>
        Criteria.Compile()(Entity);

    public Specification<T> And(Specification<T> Other) =>
        new AndSpecification<T>(this, Other);

    public Specification<T> Or(Specification<T> Other) =>
        new OrSpecification<T>(this, Other);

    public Specification<T> Not() =>
        new NotSpecification<T>(this);
}
