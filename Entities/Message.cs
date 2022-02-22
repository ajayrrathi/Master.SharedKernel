using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterProject.SharedKernel.Entities
{
    public abstract class Result
    {
        public virtual bool IsSuccess { get; } 
        public virtual string Message { get; }

        public Result(string message, bool isSuccess)
        {
            Message = message;
            IsSuccess = isSuccess;
         }
    }
}
