using System;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace TrainRideDemo.Domain.Tests.TestUtils
{
    public abstract class  MockableDbSetWithExtensions<T> : DbSet<T>
        where T : class
    {
        public abstract void AddOrUpdate(params T[] entities);
        public abstract void AddOrUpdate(Expression<Func<T, object>> identifierExpression, params T[] entities);
    }
}
