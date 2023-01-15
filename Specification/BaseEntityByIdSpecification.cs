using System;

namespace MasterProject.SharedKernel.Specification
{
    /// <summary>
    /// Specification records where id match the specified criteria
    /// </summary>
    /// <typeparam name="T">T is of type base entity</typeparam>
    public class BaseEntityByIdSpecification<T> : BaseSpecification<T> where T : MasterProject.SharedKernel.Entities.BaseEntity
    {
        public BaseEntityByIdSpecification(Guid id)
        {
            Criteria = Item => Item.Id == id;
        }

    }
}
