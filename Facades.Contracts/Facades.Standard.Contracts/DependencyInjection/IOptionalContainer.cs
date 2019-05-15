/*
This source file is under MIT License (MIT)
Copyright (c) 2019 Ian Schlarman
https://opensource.org/licenses/MIT
*/

namespace Facades.Standard.Contracts.DI
{
    /// <summary>
    /// Exposes the features of an IoC Container responsible for providing a component's optional dependencies.
    /// </summary>
    public interface IOptionalContainer : IContainerBase
    {
        /// <summary>
        /// Returns an instance of <typeparamref name="TOut"/> if it exists. If not, will return <c>default</c>.
        /// If multiple matches are found, will throw exceptions.
        /// </summary>
        /// <typeparam name="TOut">The type of object to return.</typeparam>
        /// <returns>The matching instance of <typeparamref name="TOut"/> composed by the Container, or <c>default</c> if it doesn't exists.</returns>
        TOut ResolveOptional<TOut>();

        /// <summary>
        /// Returns an instance of <typeparamref name="TOut"/> matching the provided <paramref name="contractName"/> if it exists.
        /// If not, will return <c>default</c>. If multiple matches are found, will throw exceptions.
        /// </summary>
        /// <typeparam name="TOut">The type of object to return.</typeparam>
        /// <returns>The matching instance of <typeparamref name="TOut"/> composed by the Container, or <c>default</c> if it doesn't exists.</returns>
        TOut ResolveOptional<TOut>(string contractName);

        /// <summary>
        /// Returns a collection containing all <typeparamref name="TOut"/> items. If none are found, the collection will be empty.
        /// </summary>
        /// <typeparam name="TOut">The type of object to return.</typeparam>
        /// <returns>A collection containing all <typeparamref name="TOut"/> items composed by the Container.</returns>
        System.Collections.Generic.IEnumerable<TOut> ResolveAll<TOut>();

        /// <summary>
        /// Returns a collection containing all <typeparamref name="TOut"/> items matching the provided <paramref name="contractName"/>.
        /// If none are found, the collection will be empty.
        /// </summary>
        /// <typeparam name="TOut">The type of object to return.</typeparam>
        /// <param name="contractName"></param>
        /// <returns>A collection containing all matching <typeparamref name="TOut"/> items composed by the Container.</returns>
        System.Collections.Generic.IEnumerable<TOut> ResolveAll<TOut>(string contractName);
    }
}
