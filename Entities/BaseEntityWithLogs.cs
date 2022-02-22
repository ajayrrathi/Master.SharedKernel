using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterProject.SharedKernel.Entities
{
    /// <summary>
    /// This is the base class. All the entities in the project derived from this class will add audit columns to entities. 
    /// This class drive from BaseEntity class which will provide primary key for this class.
    /// </summary>
    public abstract class BaseEntityWithLogs : BaseEntity
    {
        /// <summary>
        /// Audit field. This field will store the Id of the user who have added the entity. 
        /// </summary>
        [ScaffoldColumn(false)]
        public virtual Guid? CreatedById { get; set; }

        /// <summary>
        /// Audit Field. This field will store Id of the user who have modified it last. 
        /// </summary>
        [ScaffoldColumn(false)]
        public virtual Guid? UpdatedByID { get; set; }

        /// <summary>
        /// Audit Field. This field will store the date the entity detials was created.
        /// </summary>
        [DataType(DataType.DateTime)]
        [ScaffoldColumn(false)]
        public virtual DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Audit Field. This field will store the last modified date for the entity record. 
        /// </summary>
        [DataType(DataType.DateTime)]
        [ScaffoldColumn(false)]
        public virtual DateTime? UpdatedOn { get; set; }
    }
}
