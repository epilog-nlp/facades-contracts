/*
This source file is under MIT License (MIT)
Copyright (c) 2019 Ian Schlarman
https://opensource.org/licenses/MIT
*/

using System;

namespace Facades.Standard.Contracts.Configuration
{
    /// <summary>
    /// A facade for exposing a subset of configuration features without dependencies.
    /// </summary>
    public interface IConfig
    {
        /// <summary>
        /// Retrieves the configuration value for <paramref name="key"/>, or a default value if it doesn't exist.
        /// </summary>
        /// <typeparam name="TResult">The <see cref="Type"/> of value expected from the configuration.</typeparam>
        /// <param name="key">The configuration key to retrieve the value for.</param>
        /// <param name="defaultValue">The default value to return if the key doesn't exist.</param>
        /// <returns>The configuration value, of type <typeparamref name="TResult"/>, for <paramref name="key"/>, or a default value if the key doens't exist.</returns>
        TResult GetValue<TResult>(string key, TResult defaultValue);

        /// <summary>
        /// Determines if the <paramref name="key"/> exists in the configuration, and provides the value as an out variable if it does.
        /// </summary>
        /// <typeparam name="TResult">The <see cref="Type"/> of value expected from the configuration.</typeparam>
        /// <param name="key">The configuration key to look for.</param>
        /// <param name="value">If the configuration key exists, this will contain the value.</param>
        /// <returns>true if the configuration key exists. false otherwise.</returns>
        bool TryGetValue<TResult>(string key, out TResult value);

        /// <summary>
        /// Determines if the <paramref name="key"/> exists in the configuration, and provides the value as an out variable if it does.
        /// </summary>
        /// <param name="key">The configuration key to look for.</param>
        /// <param name="value">If the configuration key exists, this will contain the value.</param>
        /// <returns>true if the configuration key exists. false otherwise.</returns>
        bool TryGetValue(string key, out object value);
    }
}
