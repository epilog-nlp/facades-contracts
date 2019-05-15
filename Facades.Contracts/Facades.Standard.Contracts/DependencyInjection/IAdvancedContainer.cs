/*
This source file is under MIT License (MIT)
Copyright (c) 2019 Ian Schlarman
https://opensource.org/licenses/MIT
*/

namespace Facades.Standard.Contracts.DI
{
    /// <summary>
    /// Represents a full-featured IoC Container. Aggregates all the various specialized Containers in a single interface.
    /// </summary>
    public interface IAdvancedContainer : IContainer, IOptionalContainer, IInterceptableContainer, ILazyContainer, IContainerBase
    {

    }
}
