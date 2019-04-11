using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using NSubstitute;


namespace TrainRideDemo.Domain.Tests.TestUtils
{
    public static class DbSetMockUtils
    {


    }
}


//public static DbSet<T> CreateMockDbSet<T>(IEnumerable<T> data = null)
//    where T : class
//{
//    var mockSet = Substitute.For<MockableDbSetWithExtensions<T>, IQueryable<T>, IDbAsyncEnumerable<T>>();
//    mockSet.AsNoTracking().Returns(mockSet);

//    if (data != null)
//    {
//        var queryable = data.AsQueryable();

//        // setup all IQueryable and IDbAsyncEnumerable methods using what you have from "data"
//        // the setup below is a bit different from the test above
//        ((IDbAsyncEnumerable<T>)mockSet).GetAsyncEnumerator()
//            .Returns(new TestDbAsyncEnumerator<T>(queryable.GetEnumerator()));
//        ((IQueryable<T>)mockSet).Provider.Returns(new TestDbAsyncQueryProvider<T>(queryable.Provider));
//        ((IQueryable<T>)mockSet).Expression.Returns(queryable.Expression);
//        ((IQueryable<T>)mockSet).ElementType.Returns(queryable.ElementType);
//        ((IQueryable<T>)mockSet).GetEnumerator().Returns(new TestDbEnumerator<T>(queryable.GetEnumerator()));
//    }

//    return mockSet;
//}