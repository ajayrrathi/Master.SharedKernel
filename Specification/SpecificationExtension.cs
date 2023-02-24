using MasterProject.SharedKernel.Entities;
using MasterProject.SharedKernel.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MasterProject.SharedKernel.Extension
{
    /// <summary>
    /// This is the extension method for that can be applied to the classes that are derived from BaseEntity class. 
    /// This extenstion method will allow developer to excute spcification on the classes drived from BaseEntity class.
    /// </summary>
    public static class SpecificationExtension
    {
        /// <summary>
        /// This extenstion method will allow developer to excute spcification on the classes drived from BaseEntity class.
        /// </summary>
        /// <typeparam name="T">The drived class from BaseEntity class</typeparam>
        /// <param name="query">IQueryable</param>
        /// <param name="specification">Specification that will be executed</param>
        /// <returns></returns>
        public static IQueryable<T> Specify<T>(this IQueryable<T> query, ISpecification<T> specification) where T : BaseEntity
        {
            if (specification == null)
                throw new System.ArgumentNullException(nameof(specification));

            var quearyableResultWithIncludes = specification.Includes.Aggregate(query,
                                (current, include) => current.Include(include));

            var SecondaryResult = specification.IncludeStrings.Aggregate(quearyableResultWithIncludes,
                                (current, include) => current.Include(include));
            if (specification.Criteria != null)
                return SecondaryResult.Where(specification.Criteria);
            else
                return SecondaryResult.AsQueryable<T>();
        }
    }
}
