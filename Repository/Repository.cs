using System;
using System.Threading.Tasks;
using MasterProject.SharedKernel.Entities;
using MasterProject.SharedKernel.Interface;
using Microsoft.EntityFrameworkCore;

namespace MasterProject.SharedKernel.Repository
{
	public abstract class Repository : ReadRepository, IRepository
    {
        private readonly DbContext _dbContext;
        public Repository(DbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Add entity.
        /// </summary>
        /// <typeparam name="T">Entity of type BaseEntity.</typeparam>
        /// <param name="entity">Value to be added.</param>
        /// <returns>Object of type IMessage.</returns>
        public async Task<IMessage> AddAsync<T>(T entity) where T : BaseEntity
        {
            try
            {
                await _dbContext.Set<T>().AddAsync(entity);
                await _dbContext.SaveChangesAsync();
                return Result.Successful(entity);
            }
            catch(Exception ex) {
                return Result.Error(ex.Message);
            }
        }
        /// <summary>
        /// Delete entity.
        /// </summary>
        /// <typeparam name="T">Entity of type BaseEntity.</typeparam>
        /// <param name="entity">Value to deleted.</param>
        /// <returns>Object of type IMessage.</returns>
        public async Task<IMessage> DeleteAsync<T>(T entity) where T : AggregateEntity
        {
            try
            {
                _dbContext.Set<T>().Remove(entity);
                await _dbContext.SaveChangesAsync();
                return Result.Successful();
            }
            catch (Exception ex)
            {
                return Result.Error(ex.Message);
            }
        }
        /// <summary>
        /// Updated entity.
        /// </summary>
        /// <typeparam name="T">Entity of type BaseEntity.</typeparam>
        /// <param name="entity">Values to be updated.</param>
        /// <returns>Object of type IMessage.</returns>
        public async Task<IMessage> UpdateAsync<T>(T entity) where T : BaseEntity
        {
            try
            {
                var updateEntity = _dbContext.Set<T>().Update(entity);
                updateEntity.State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();
                return Result.Successful();
            }
            catch (Exception ex)
            {
                return Result.Error(ex.Message);
            }
        }
    }
}

