using System;
using System.Collections.Generic;

namespace MasterProject.SharedKernel.Entities
{
	public class Result
	{
        /// <summary>
        /// Return the operation successful with operation values.
        /// </summary>
        /// <param name="values">List of operation result.</param>
        /// <returns>Return operation result values or messages.</returns>
        public static IMessage<T> Successful<T>(IList<T> values) where T : BaseEntity
        {
            return Message<T>.GetMessage(true, values);
        }
        /// <summary>
        /// Return the operation sucessful with operation value 
        /// </summary>
        /// <param name="value">Operation value.</param>
        /// <returns>Return operation result values or messages.</returns>
        public static IMessage<T> Successful<T>(T value) where T : BaseEntity
        {
            if (value == null)
                return Successful<T>(
                    new List<T>());
            else
                return Successful(
                    new List<T>() { value }
                    );
        }
        /// <summary>
        /// Return error results.
        /// </summary>
        /// <param name="message">Return failure with operation messages.</param>
        /// <returns>Return operation messages.</returns>
        public static IMessage<string> Error(IList<string> message)
        {
            return Message<string>.GetMessage(false, message);
        }
        /// <summary>
        /// Return error results.
        /// </summary>
        /// <param name="message">Return failure with operation messages.</param>
        /// <returns>Return operation messages.</returns>
        public static IMessage<string> Error(string message)
        {
            if (message == null)
                return Error(
                    new List<string>());
            else
                return Error(
                    new List<string>() { message }
                    );
        }
    }
}

