using System.Linq.Expressions;

namespace PrTask.Domain.Common;

internal sealed class AndSpecification<T>(Specification<T> Left, Specification<T> Right) : Specification<T>
{
    public override Expression<Func<T, bool>> Criteria
    {
        get
        {
            var Parameter = Left.Criteria.Parameters[0];
            var Combined = Expression.AndAlso(
                Left.Criteria.Body,
                Expression.Invoke(Right.Criteria, Parameter));
            return Expression.Lambda<Func<T, bool>>(Combined, Parameter);
        }
    }
}
