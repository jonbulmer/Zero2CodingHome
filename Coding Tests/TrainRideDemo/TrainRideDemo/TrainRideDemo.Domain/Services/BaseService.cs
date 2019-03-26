using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TrainRideDemo.Domain.Service
{
    interface IBaseService<T> where T : class 
    {
        /// <summary>
        /// This gets the entity based on its primary key
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T Get(int id);

        /// <summary>
        /// This Gets All from the entity
        /// </summary>
        /// <returns></returns>
        List<T> GetAll();

        /// <summary>
        /// This allows us to do a where clause on the entity. This should only be used for one off cases
        /// </summary>
        /// <param name="whereClause"></param>
        /// <returns></returns>
        List<T> GetAll(Expression<Func<T, bool>> whereClause);

        /// <summary>
        /// Updates Entity
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        ResponseObject Update(T arg);

        /// <summary>
        /// Inserts New Entity
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        ResponseObject Insert(T arg);

        /// <summary>
        /// Deleted Entity
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ResponseObject Delete(int id);
    }
}
