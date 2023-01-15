using MasterProject.SharedKernel.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MasterProject.SharedKernel.Interface
{
    /// <summary>
    /// This is interface can we used for read only repository. 
    /// </summary>
    public interface IReadRepository
    {
        /// <summary>
        /// Return the record with the specified criteria.
        /// </summary>
        /// <typeparam name="T">T as the BaseEntity type.</typeparam>
        /// <param name="Id">Guid for searching.</param>
        /// <returns>Return object of IMessage</returns>
        Task<IMessage> GetByID<T>(Guid Id) where T : BaseEntity;
        /// <summary>
        /// Return list of all the records for the entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        Task<IMessage> ListAsync<T>() where T : BaseEntity;
        /// <summary>
        /// Return the records that satisfied the specified criteria.
        /// </summary>
        /// <typeparam name="T">T as the BaseEntity.</typeparam>
        /// <param name="spec">Spcification for searching.</param>
        /// <returns></returns>
        Task<IMessage> ListAsync<T>(ISpecification<T> spec) where T : BaseEntity;
    }
}
