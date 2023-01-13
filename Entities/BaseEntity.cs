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

    }
}
