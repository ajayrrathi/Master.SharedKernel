using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterProject.SharedKernel.Entities
{
    /// <summary>
    /// Abstract class for operation result for returing values.
    /// </summary>
    public class Message<T> : IMessage where T : class
    {

        /// <summary>
        /// Indicate operation status.
        /// </summary>
        public bool IsSuccessful { get; }

        public T Values { get; }

        /// <summary>
        /// Private constractor for creating object for the message class.
        /// </summary>
        /// <param name="isSuccess">Operation indicater.</param>
        /// <param name="values">list of operation result.</param>
        protected Message(bool isSuccess,T values)
        {
            IsSuccessful = isSuccess;
            Values = values;
        }

        /// <summary>
        /// private method for generating object of message.
        /// </summary>
        /// <param name="isSuccessful">Indicate operation status</param>
        /// <param name="values">Return operation result values or error messages.</param>
        /// <returns></returns>
        protected internal static IMessage GetMessage(bool isSuccessful, T values)
        {
            return new Message<T>(
              isSuccessful,
              values
              );
        }
    }
}
