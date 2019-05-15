/*
This source file is under MIT License (MIT)
Copyright (c) 2019 Ian Schlarman
https://opensource.org/licenses/MIT
*/

namespace Facades.Standard.Contracts.Logging.Specialized
{
    /// <summary>
    /// Exposes methods for a <typeparamref name="TLogger"/> to produce modified instances of itself.
    /// </summary>
    /// <typeparam name="TLogger"></typeparam>
    public interface IExtensibleLogger<TLogger>
        where TLogger : ILoggerBase
    {
        /// <summary>
        /// Creates a child <typeparamref name="TLogger"/> with the provided name.
        /// </summary>
        /// <param name="name">The name of the logger to be created.</param>
        /// <returns>A <typeparamref name="TLogger"/> instance with the provided name.</returns>
        TLogger CreateChild(string name);
    }
}
