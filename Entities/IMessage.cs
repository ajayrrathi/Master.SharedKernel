using System;
using System.Collections.Generic;

namespace MasterProject.SharedKernel.Entities
{
    /// <summary>
    /// Interface that will be implememented by classes that will return operation result.
    /// </summary>
    public interface IMessage<T> where T : class
    {
        /// <summary>
        /// Indicate operation status
        /// </summary>
        public bool IsSuccessful { get; }

        /// <summary>
        /// Return the value for Operation
        /// </summary>
        IList<T> Values { get; }

    }
}

