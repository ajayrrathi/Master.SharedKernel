using MasterProject.SharedKernel.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MasterProject.SharedKernel.Interface
{
    /// <summary>
    /// Interface for read and write repository.
    /// </summary>
    public interface IRepository  : IReadRepository, IAggregate 
    {
        /// <summary>
        /// Add entity.
        /// </summary>
        /// <typeparam name="T">Entity of type BaseEntity.</typeparam>
        /// <param name="entity">Value to be added.</param>
        /// <returns>Object of type IMessage.</returns>
        Task<IMessage> AddAsync<T>(T entity) where T : BaseEntity;
        /// <summary>
        /// Delete entity.
        /// </summary>
        /// <typeparam name="T">Entity of type BaseEntity.</typeparam>
        /// <param name="entity">Value to deleted.</param>
        /// <returns>Object of type IMessage.</returns>
        Task<IMessage> DeleteAsync<T>(T entity) where T : AggregateEntity;
        /// <summary>
        /// Updated entity.
        /// </summary>
        /// <typeparam name="T">Entity of type BaseEntity.</typeparam>
        /// <param name="entity">Values to be updated.</param>
        /// <returns>Object of type IMessage.</returns>
        Task<IMessage> UpdateAsync<T>(T entity) where T : BaseEntity;
    }
}
