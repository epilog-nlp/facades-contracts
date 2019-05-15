/*
This source file is under MIT License (MIT)
Copyright (c) 2019 Ian Schlarman
https://opensource.org/licenses/MIT
*/

namespace Facades.Standard.Contracts.Logging
{
    /// <summary>
    /// A facade for exposing simple Debug and Error logging options
    /// </summary>
    public interface IBasicLogger : IDebugLogger, IErrorLogger, ILoggerBase
    {
        
    }

}
