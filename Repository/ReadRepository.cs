using System;
using MasterProject.SharedKernel.Entities;
using MasterProject.SharedKernel.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MasterProject.SharedKernel.Extension;
using MasterProject.SharedKernel.Specification;

namespace MasterProject.SharedKernel.Repository
{
	public abstract class ReadRepository : IReadRepository
	{
		private readonly DbContext _dbContext;
		public ReadRepository(DbContext dbContext){
            _dbContext = dbContext;
		}
        /// <summary>
        /// Return the record with the specified criteria.
        /// </summary>
        /// <typeparam name="T">T as the BaseEntity type.</typeparam>
        /// <param name="Id">Guid for searching.</param>
        /// <returns>Return object of IMessage</returns>
        public async Task<IMessage> GetByID<T>(Guid Id) where T : BaseEntity {
            return await ListAsync<T>(new BaseEntityByIdSpecification<T>(Id));
        }
        /// <summary>
        /// Return list of all the records for the entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>Return object of IMessage.</returns>
        public async Task<IMessage> ListAsync<T>() where T : BaseEntity {
            return Result.Successful(await _dbContext.Set<T>().ToListAsync());
        }
        /// <summary>
        /// Return the records that satisfied the specified criteria.
        /// </summary>
        /// <typeparam name="T">T as the BaseEntity.</typeparam>
        /// <param name="spec">Spcification for searching.</param>
        /// <returns>Return object of IMessage.</returns>
        public async Task<IMessage> ListAsync<T>(ISpecification<T> specification) where T : BaseEntity {
            return Result.Successful(await _dbContext.Set<T>().Specify<T>(specification).ToListAsync());
        }
    }
}

