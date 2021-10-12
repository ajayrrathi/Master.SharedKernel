using System;

namespace MasterProject.SharedKernel.Specification
{
    /// <summary>
    /// Specification return all records where name excelty match the specified criteria
    /// </summary>
    /// <typeparam name="T">T is of type master entity</typeparam>
    public class MasterEntityNameSpecification<T> : BaseSpecification<T> where T : MasterProject.SharedKernel.Entities.MasterEntity
    {
        /// <summary>
        /// Constracter for the specification
        /// </summary>
        /// <param name="name">name criteria for specification</param>
        public MasterEntityNameSpecification(String name)
        {
            Criteria = Item => Item.Name == name;
        }
    }
}
