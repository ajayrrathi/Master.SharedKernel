using System;

namespace MasterProject.SharedKernel.Specification
{
    /// <summary>
    /// Specification return all records where created by match the specified criteria
    /// </summary>
    /// <typeparam name="T">T is of type base entity</typeparam>
    public class BaseEntityCreatedBySpecification<T> : BaseSpecification<T> where T : MasterProject.SharedKernel.Entities.BaseEntityWithLogs
    {
        public BaseEntityCreatedBySpecification(Guid id)
        {
            Criteria = Item => Item.CreatedById == id;
        }
    }
}
