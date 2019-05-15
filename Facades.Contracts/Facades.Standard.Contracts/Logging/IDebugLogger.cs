/*
This source file is under MIT License (MIT)
Copyright (c) 2019 Ian Schlarman
https://opensource.org/licenses/MIT
*/

using System;

namespace Facades.Standard.Contracts.Logging
{
    /// <summary>
    /// A facade for exposing Debug level logging
    /// </summary>
    public interface IDebugLogger : ILoggerBase
    {
        /// <summary>
        /// Logs the <paramref name="message"/> if <see cref="IsDebugEnabled"/> is true.
        /// </summary>
        /// <param name="message">The message to be logged.</param>
        void Debug(object message);

        /// <summary>
        /// Logs the <paramref name="message"/> and details from <paramref name="e"/> if <see cref="IsDebugEnabled"/> is true.
        /// </summary>
        /// <param name="message">The message to be logged.</param>
        /// <param name="e">The <see cref="Exception"/> to log details from.</param>
        void Debug(object message, Exception e);

        /// <summary>
        /// Determines if Debug Logging has been enabled.
        /// </summary>
        bool IsDebugEnabled { get; }
    }
}
