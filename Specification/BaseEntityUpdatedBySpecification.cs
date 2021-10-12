using System;

namespace MasterProject.SharedKernel.Specification
{
    /// <summary>
    /// Specification return all records where updated by match the specified criteria
    /// </summary>
    /// <typeparam name="T">T is of type base entity</typeparam>
    public class BaseEntityUpdatedBySpecification<T> : BaseSpecification<T> where T : MasterProject.SharedKernel.Entities.BaseEntity
    {
        /// <summary>
        /// Constracter for the specification
        /// </summary>
        /// <param name="id">Updated by Id criteria for specification</param>
        public BaseEntityUpdatedBySpecification(Guid id)
        {
            Criteria = Item => Item.UpdatedByID == id;
        }
    }
}
