using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using NSubstitute;


namespace TrainRideDemo.Domain.Tests.TestUtils
{
    public static class DbSetMockUtils
    {
        public static DbSet<T> CreateMockDbSet<T>(IEnumerable<T> data = null)
            where T : class
        {
            var mockSet = Substitute.For<MockableDbSetWithExtensions<T>, IQueryable<T>>();
           
            if (data != null)
            {
                var queryable = data.AsQueryable();
                ((IQueryable<T>)mockSet).Provider.Returns(new TestDbAsyncQueryProvider<T>(queryable.Provider));
                ((IQueryable<T>)mockSet).Expression.Returns(queryable.Expression);
                ((IQueryable<T>)mockSet).ElementType.Returns(queryable.ElementType);
                ((IQueryable<T>)mockSet).GetEnumerator().Returns(new TestDbEnumerator<T>(queryable.GetEnumerator()));
            }
            return mockSet;
        }
    }
}
