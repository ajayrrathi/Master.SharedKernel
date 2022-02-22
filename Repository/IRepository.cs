using MasterProject.SharedKernel.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MasterProject.SharedKernel.Interface
{

    public interface IRepository  : IReadRepository, IAggregate 
    {
        Task<T> AddAsync<T>(T entity) where T : BaseEntity;
        Task<bool> DeleteAsync<T>(T entity) where T : AggregateEntity;
        Task UpdateAsync<T>(T entity) where T : BaseEntity;
    }
}
