/*
This source file is under MIT License (MIT)
Copyright (c) 2019 Ian Schlarman
https://opensource.org/licenses/MIT
*/

namespace Facades.Standard.Contracts.Logging
{
    /// <summary>
    /// A facade for exposing all the features of a standard Logger without introducing its dependencies.
    /// </summary>
    public interface ILogger : IBasicLogger, ITraceLogger, IWarnLogger, IInfoLogger, Specialized.IExtensibleLogger<ILogger>
    {
        
    }
}
