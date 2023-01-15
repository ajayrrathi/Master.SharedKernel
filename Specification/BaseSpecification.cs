using MasterProject.SharedKernel.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MasterProject.SharedKernel.Specification
{
    public abstract class BaseSpecification<T> : ISpecification<T>
    {
        /// <summary>
        /// Criteria for searching records.
        /// </summary>
        public Expression<Func<T, bool>> Criteria { get; set; }

        /// <summary>
        /// List of Entities that will be included along with selected entities.
        /// </summary>
        public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T, object>>>();

        /// <summary>
        /// List of Entities as string, that will be included with selected entities.
        /// </summary>
        public List<string> IncludeStrings { get; } = new List<string>();

        /// <summary>
        /// List of Entities that will be included along with selected entities.
        /// </summary>
        /// <param name="includeExpresion">Expression that will be added to list.</param>
        protected virtual void AddInclude(Expression<Func<T, object>> includeExpresion)
        {
            Includes.Add(includeExpresion);
        }
        /// <summary>
        /// Entities as string, that should be included with selected entities.
        /// </summary>
        protected virtual void AddInclude(string includeString)
        {
            IncludeStrings.Add(includeString);
        }
    }
}
