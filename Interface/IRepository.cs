using MasterProject.SharedKernel.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MasterProject.SharedKernel.Interface
{
    public interface IRepository
    {
        Task<T> AddAsync<T>(T entity) where T : BaseEntity, IAggregate;
        Task<bool> DeleteAsync<T>(T entity) where T : BaseEntity, IAggregate;

        Task<T> GetByID<T>(Guid Id) where T : BaseEntity, IAggregate;
        Task<List<T>> ListAsync<T>() where T : BaseEntity, IAggregate;
        Task<List<T>> ListAsync<T>(ISpecification<T> spec) where T : BaseEntity, IAggregate;

        Task UpdateAsync<T>(T entity) where T : BaseEntity, IAggregate;
    }
}
