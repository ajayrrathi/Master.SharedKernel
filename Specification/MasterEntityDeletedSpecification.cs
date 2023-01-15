
namespace MasterProject.SharedKernel.Specification
{
    /// <summary>
    /// Specification return all records where delete status match the specified criteria
    /// </summary>
    /// <typeparam name="T">T is of type master entity</typeparam>
    public class MasterEntityDeletedSpecification<T> : BaseSpecification<T> where T : MasterProject.SharedKernel.Entities.MasterEntity
    {
        /// <summary>
        /// Constracter for the specification
        /// </summary>
        /// <param name="isDeletedStatus">Delete criteria for specification</param>
        public MasterEntityDeletedSpecification(bool isDeletedStatus)
        {
            Criteria = Item => Item.Deleted == isDeletedStatus;
        }
    }
}
