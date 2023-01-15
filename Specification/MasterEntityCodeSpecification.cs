using System;
using MasterProject.SharedKernel.Entities;

namespace MasterProject.SharedKernel.Specification
{
    /// <summary>
    /// Specification return all records where code match the specified criteria
    /// </summary>
    /// <typeparam name="T">T is of type base entity</typeparam>
    public class MasterEntityCodeSpecification<T> : BaseSpecification<T> where T : MasterEntity
    {
        public MasterEntityCodeSpecification(String code)
        {
            Criteria = Item => Item.Code == code;
        }
    }
}
