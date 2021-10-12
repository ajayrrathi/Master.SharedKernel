using System;

namespace MasterProject.SharedKernel.Specification
{
    public class BaseEntityByIdSpecification<T> : BaseSpecification<T> where T : MasterProject.SharedKernel.Entities.BaseEntity
    {
        public BaseEntityByIdSpecification(Guid id)
        {
            Criteria = Item => Item.Id == id;
        }

    }
}
