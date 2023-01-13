using MasterProject.SharedKernel.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterProject.SharedKernel.Entities
{
    /// <summary>
    ///  Aggregate root will drive from this class. Repositories will only work with these classes. 
    /// </summary>
    public abstract class AggregateEntity : BaseEntityWithLogs, IAggregate
    {

    }
}
