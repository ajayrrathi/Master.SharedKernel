using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MasterProject.SharedKernel.Interface
{
    /// <summary>
    /// Interface for creating generic specifications.
    /// </summary>
    /// <typeparam name="T">Entity name</typeparam>
    public interface ISpecification<T>
    {
        /// <summary>
        /// Criteria for searching records.
        /// </summary>
        Expression<Func<T, bool>> Criteria { get; }
        /// <summary>
        /// Entities that will be included along with selected entities.
        /// </summary>
        List<Expression<Func<T, object>>> Includes { get; }
        /// <summary>
        /// Entities as string, that will be included with selected entities.
        /// </summary>
        List<string> IncludeStrings { get; }
    }
}
