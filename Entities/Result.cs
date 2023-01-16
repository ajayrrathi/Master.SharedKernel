using System;
using System.Collections.Generic;

namespace MasterProject.SharedKernel.Entities
{
	public class Result
	{
        /// <summary>
        /// Return the operation status as successful.
        /// </summary>
        /// <returns>Return operation status.</returns>
        public static IMessage Successful()
        {
            return Message<string>.GetMessage(true,string.Empty);
        }
        /// <summary>
        /// Return the operation successful with operation values.
        /// </summary>
        /// <param name="values">List of operation result.</param>
        /// <returns>Return operation result, values or messages.</returns>
        public static IMessage Successful<T>(IList<T> values) where T : BaseEntity
        {
            return Message<IList<T>>.GetMessage(true, values);
        }
        /// <summary>
        /// Return the operation sucessful with operation value 
        /// </summary>
        /// <param name="value">Operation value.</param>
        /// <returns>Return operation result, values or messages.</returns>
        public static IMessage Successful<T>(T value) where T : BaseEntity
        {
            return Message<T>.GetMessage(true, value);
        }
        /// <summary>
        /// Return error results.
        /// </summary>
        /// <param name="message">Return failure with operation messages.</param>
        /// <returns>Return operation messages.</returns>
        public static IMessage Error(IList<string> message)
        {
            return Message<IList<string>>.GetMessage(false, message);
        }
        /// <summary>
        /// Return error results.
        /// </summary>
        /// <param name="message">Return failure with operation messages.</param>
        /// <returns>Return operation messages.</returns>
        public static IMessage Error(string message)
        {
            return Message<string>.GetMessage(false, message); ;
        }
        /// <summary>
        /// Return operation status as error.
        /// </summary>
        /// <returns>Return operation status.</returns>
        public static IMessage Error()
        {
            return Error(string.Empty);
        }
    }
}

