using System.Linq.Expressions;

namespace PrTask.Domain.Common;

internal sealed class NotSpecification<T>(Specification<T> Inner) : Specification<T>
{
    public override Expression<Func<T, bool>> Criteria
    {
        get
        {
            var Parameter = Inner.Criteria.Parameters[0];
            var Negated = Expression.Not(Inner.Criteria.Body);
            return Expression.Lambda<Func<T, bool>>(Negated, Parameter);
        }
    }
}
