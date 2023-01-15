using System;
using System.Collections.Generic;

namespace MasterProject.SharedKernel.Entities
{
    /// <summary>
    /// Interface that will be implememented by classes that will return operation result.
    /// </summary>
    public interface IMessage
    {
        /// <summary>
        /// Indicate operation status
        /// </summary>
        public bool IsSuccessful { get; }
    }
}

