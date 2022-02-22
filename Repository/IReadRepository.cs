using MasterProject.SharedKernel.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MasterProject.SharedKernel.Interface
{
    /// <summary>
    /// This is interface can we used for read only repository 
    /// </summary>
    public interface IReadRepository
    {
        Task<T> GetByID<T>(Guid Id) where T : BaseEntity;
        Task<List<T>> ListAsync<T>() where T : BaseEntity;
        Task<List<T>> ListAsync<T>(ISpecification<T> spec) where T : BaseEntity;
    }
}
