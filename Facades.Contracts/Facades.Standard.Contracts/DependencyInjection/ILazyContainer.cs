/*
This source file is under MIT License (MIT)
Copyright (c) 2019 Ian Schlarman
https://opensource.org/licenses/MIT
*/

namespace Facades.Standard.Contracts.DI
{
    /// <summary>
    /// Exposes the features of an IoC Container responsible for lazily resolving dependencies so they are only created as needed.
    /// </summary>
    public interface ILazyContainer : IContainerBase
    {
        /// <summary>
        /// Returns a Lazy instance of <typeparamref name="TOut"/> if it exists. If exactly one match is not found, will throw exceptions.
        /// </summary>
        /// <typeparam name="TOut">The type of object to return.</typeparam>
        /// <returns>A <see cref="System.Lazy{TOut}"/> containing the matching instance of <typeparamref name="TOut"/> composed by the Container.</returns>
        System.Lazy<TOut> ResolveLazy<TOut>();

        /// <summary>
        /// Returns a Lazy instance of <typeparamref name="TOut"/> matching the provided <paramref name="contractName"/> if it exists. If exactly one match is not found, will throw exceptions.
        /// </summary>
        /// <typeparam name="TOut">The type of object to return.</typeparam>
        /// <param name="contractName">The contract name of the object to retrieve. Providing <c>null</c> or an empty string ("") will use the default contract name.</param>
        /// <returns>A <see cref="System.Lazy{TOut}"/> containing the instance of <typeparamref name="TOut"/> with the specified contract name composed by the Container.</returns>
        System.Lazy<TOut> ResolveLazy<TOut>(string contractName);
    }
}
