using System;

namespace MasterProject.SharedKernel.Specification
{
    public class MasterEntityCodeSpecification<T> : BaseSpecification<T> where T : MasterProject.SharedKernel.Entities.MasterEntity
    {
        public MasterEntityCodeSpecification(String code)
        {
            Criteria = Item => Item.Code == code;
        }
    }
}
