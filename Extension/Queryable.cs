using MasterProject.SharedKernel.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace MasterProject.SharedKernel.Extension
{
    /// <summary>
    /// This is the extension method for that can be applied to the classes that are derived from BaseEntity class. 
    /// This extenstion method will allow developer to include multiple table records while appling the specification. 
    /// </summary>
    public static class Queryable
    {
        /// <summary>
        /// This extenstion method will allow users to include multiple table records while appling the specification. 
        /// </summary>
        /// <typeparam name="T">The drived class from BaseEntity class</typeparam>
        /// <param name="query">IQueryable</param>
        /// <param name="Includes">The enpression for joining/selecting the entities</param>
        /// <returns></returns>
        public static IQueryable IncludeMultiple<T>(this IQueryable<T> query, params Expression<Func<T, object>>[] Includes) where T : BaseEntity
        {
            if (Includes != null)
            {
                query = Includes.Aggregate(query,
                    (current, include) => current.Include(include));
            }
            return query;
        }
    }
}
