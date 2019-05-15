/*
This source file is under MIT License (MIT)
Copyright (c) 2019 Ian Schlarman
https://opensource.org/licenses/MIT
*/

namespace Facades.Standard.Contracts.DI
{
    /// <summary>
    /// Exposes the features of an IoC Container responsible for explicitly registering implementation instances.
    /// </summary>
    public interface IInterceptableContainer : IContainerBase
    {
        /// <summary>
        /// Composes the provided instance implementation of <typeparamref name="TContract"/> in the container so it will be used to satisfy dependencies.
        /// </summary>
        /// <remarks>
        /// Specifically, the Container stores information about what classes are available to satisfy requests for dependencies, but only composes
        /// (instantiates) them when they are requested.
        /// After registering an implementation, all future requests for a <typeparamref name="TContract"/> dependency will return the provided <paramref name="impl"/>.
        /// </remarks>
        /// <typeparam name="TContract">
        /// The <see cref="System.Type"/> to register <paramref name="impl"/> as.
        /// If <paramref name="impl"/> is of a more specialized type than <typeparamref name="TContract"/>, this needs to be explicitly provided.
        /// </typeparam>
        /// <param name="impl">The instance of <typeparamref name="TContract"/> to compose within the container.</param>
        void Register<TContract>(TContract impl);

        /// <summary>
        /// Composes the provided instance implementation of <typeparamref name="TContract"/> in the container so it will be used to satisfy dependencies.
        /// </summary>
        /// <remarks><see cref="Register{TContract}(TContract)"/></remarks>
        /// <typeparam name="TContract">
        /// The <see cref="System.Type"/> to register <paramref name="impl"/> as.
        /// If <paramref name="impl"/> is of a more specialized type than <typeparamref name="TContract"/>, this needs to be explicitly provided.
        /// </typeparam>
        /// <param name="impl">The instance of <typeparamref name="TContract"/> to compose within the container.</param>
        /// <param name="contractName">The contract name to register <paramref name="impl"/> as. Will be used when resolving <typeparamref name="TContract"/>.</param>
        void Register<TContract>(TContract impl, string contractName);
    }
}
