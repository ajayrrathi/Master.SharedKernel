using MasterProject.SharedKernel.Interface;
using System.ComponentModel.DataAnnotations;


namespace MasterProject.SharedKernel.Entities
{
    /// <summary>
    /// This class will be inherated  by the master entities. eg. Country, City, State, codes.
    /// </summary>
    public abstract class MasterEntity : BaseEntityWithLogs
    {
        /// <summary>
        /// Alternate key. This is the unique code that will be used for retriving the values. 
        /// </summary>
        [Required]
        [StringLength(200, ErrorMessage = "Please enter name with Minimum seven character and maximum 200 charater.", MinimumLength = 7)]
        public virtual string Code { get; set; }

        /// <summary>
        /// This is the display text for the master entity. This column detials will be used for displaying to user.  
        /// </summary>
        [Required]
        [StringLength(200, ErrorMessage = "Please enter name with Minimum seven character and maximum 200 charater.", MinimumLength = 7)]
        public virtual string Name { get; set; }

        /// <summary>
        /// Soft Delete for the Master records. 
        /// </summary>
        [ScaffoldColumn(false)]
        public virtual bool Deleted { get; set; } = false;

        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public override DateTime? CreatedOn
        //{
        //    get;

        //    set;
        //}

    }
}
