/*
This source file is under MIT License (MIT)
Copyright (c) 2019 Ian Schlarman
https://opensource.org/licenses/MIT
*/

namespace Facades.Standard.Contracts.DI
{
    /// <summary>
    /// Represents an IoC Container with basic functionality.
    /// </summary>
    public interface IContainer : IContainerBase
    {
        /// <summary>
        /// Returns an instance of <typeparamref name="TOut"/> if it exists. If exactly one match is not found, will throw exceptions.
        /// </summary>
        /// <typeparam name="TOut">The type of object to return.</typeparam>
        /// <returns>The matching instance of <typeparamref name="TOut"/> composed by the Container.</returns>
        TOut Resolve<TOut>();

        /// <summary>
        /// Returns an instance of <typeparamref name="TOut"/> matching the provided <paramref name="contractName"/>. If exactly one match is not found, will throw exceptions. 
        /// </summary>
        /// <typeparam name="TOut">The type of object to return.</typeparam>
        /// <param name="contractName">The contract name of the object to retrieve. Providing <c>null</c> or an empty string ("") will use the default contract name.</param>
        /// <returns>The matching instance of <typeparamref name="TOut"/> composed by the Container.</returns>
        TOut Resolve<TOut>(string contractName);

        /// <summary>
        /// Satisfies all the dependencies of the provided <paramref name="item"/> and manages the lifecycle of all objects created.
        /// </summary>
        /// <remarks>
        /// Dependency objects are created using the singleton lifecycle. Created objects, especially <see cref="System.IDisposable"/> objects, may become inaccessible after the <see cref="IContainer"/> is disposed.
        /// To remove dependence on the the <see cref="IContainer"/> lifecycle, use the <see cref="IContainer.ComposeOnce{TIn}(TIn)"/> method to manage the lifecycle of created objects directly.
        /// </remarks>
        /// <typeparam name="TIn">The type of object the provided <paramref name="item"/> will be interpreted as.</typeparam>
        /// <param name="item">An item with dependencies that must be satisfied.</param>
        void ComposeAll<TIn>(TIn item);

        /// <summary>
        /// Satisfies all the dependencies of the provided <paramref name="item"/>, but does not register the created objects for recomposition.
        /// </summary>
        /// <typeparam name="TIn">The type of object the provided <paramref name="item"/> will be interpreted as.</typeparam>
        /// <param name="item">An item with dependencies that must be satisfied.</param>
        void ComposeOnce<TIn>(TIn item);

    }
}
