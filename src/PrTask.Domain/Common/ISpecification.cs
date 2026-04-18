using System.Linq.Expressions;

namespace PrTask.Domain.Common;

public interface ISpecification<T>
{
    Expression<Func<T, bool>> Criteria { get; }

    bool IsSatisfiedBy(T Entity);
}
