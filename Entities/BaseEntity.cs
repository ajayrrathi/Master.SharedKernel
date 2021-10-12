using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasterProject.SharedKernel.Entities
{
    /// <summary>
    /// This is the base class. All the entities in the project will derive from this class. 
    /// This class will add the primary key column and all the audit columns to entities. 
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// This property will add the primary column to the table created for the enrities.
        /// </summary>
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual Guid Id { get; set; }

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
