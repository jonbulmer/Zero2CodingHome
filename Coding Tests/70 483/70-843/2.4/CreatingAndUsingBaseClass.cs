using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exam.Objective2_4
{
    class CreatingAndUsingBaseClass
    {
        // Listing 2-45 Creating a base class
        interface IEntity
        {
            int Id { get; }
        }

        class Repository<T> where T : IEntity
        {
            protected IEnumerable<T> _elements;

            public Repository(IEnumerable<T> elements)
            {
                _elements = elements;
            }

            public T FindById(int id)
            {
                return _elements.SingleOrDefault(e => e.Id == id);
            }
        }

        // Listing 2-46 Inheriting from a base class
        class Order : IEntity
        {
            public int Id { get; }
        }

        class OrderRepository : Repository<Order>
        {
            public OrderRepository(IEnumerable<Order> orders)
                :base(orders) { }

            public IEnumerable<Order> FilterOrdersOnAmount(decimal amount)
            {
                List<Order> result = null;
                // Some filtering code
                return result;
            }
        }

    }
}
