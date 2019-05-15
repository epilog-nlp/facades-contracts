/*
This source file is under MIT License (MIT)
Copyright (c) 2019 Ian Schlarman
https://opensource.org/licenses/MIT
*/

using System;

namespace Facades.Standard.Contracts.Logging
{
    /// <summary>
    /// Utility methods for logging without breaking fluent syntax.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Utility method for passing <paramref name="result"/> into a log statement without breaking fluent syntax.
        /// </summary>
        /// <typeparam name="TResult">The Type of the <see cref="object"/> or method return being extended.</typeparam>
        /// <param name="result">An <see cref="object"/> or return value from a method. Will be passed into <paramref name="logStatement"/>.</param>
        /// <param name="logStatement">Any action using <paramref name="result"/>, but intended for logging.</param>
        /// <returns><paramref name="result"/></returns>
        /// <example>
        /// <code>
        /// public double PowLogging(double x, double y) => Math.Pow(x,y).LogAndContinue(r => Logger.Debug($"The result is {r}");
        /// </code>
        /// </example>
        public static TResult LogAndContinue<TResult>(this TResult result, Action<TResult> logStatement)
        {
            logStatement(result);
            return result;
        }

        /// <summary>
        /// Utility method for logging without breaking fluent syntax.
        /// </summary>
        /// <typeparam name="TResult">The Type of the <see cref="object"/> or method return being extended.</typeparam>
        /// <param name="result">An <see cref="object"/> or return value from a method.</param>
        /// <param name="logStatement">Any action to complete before returning <paramref name="result"/>, but intended for logging.</param>
        /// <returns><paramref name="result"/></returns>
        /// <example>
        /// <code>
        /// public string IndicativeMethod() => "MeaningfulString".LogAndContinue(() => Logger.Info("Logging something meaningful")); 
        /// </code>
        /// </example>
        public static TResult LogAndContinue<TResult>(this TResult result, Action logStatement)
        {
            logStatement();
            return result;
        }

        /// <summary>
        /// Utility method for passing the the return value from <paramref name="result"/> into a log statement without breaking fluent syntax.
        /// </summary>
        /// <typeparam name="TResult">The Type of <see cref="object"/> returned by <paramref name="result"/></typeparam>
        /// <param name="result">A <see cref="Func{TResult}"/> to invoke and return from.</param>
        /// <param name="logStatement">Any action using the return value from <paramref name="result"/>, but intended for logging.</param>
        /// <returns><paramref name="result"/></returns>
        /// <example>
        /// <code>
        /// int i = 0;
        /// Func{int} myFunc = () => i++; 
        /// public int CurrentIteration() => myFunc.LogResult(r => Logger.Debug($"Retrieved current iteration: {4}"));
        /// </code>
        /// </example>
        public static TResult LogResult<TResult>(this Func<TResult> result, Action<TResult> logStatement)
        {
            var r = result();
            logStatement(r);
            return r;
        }

        /// <summary>
        /// Utility method for executing and returning from <paramref name="result"/> while invoking <paramref name="logStatement"/> without breaking fluent syntax.
        /// </summary>
        /// <typeparam name="TResult">The Type of <see cref="object"/> returned by <paramref name="result"/></typeparam>
        /// <param name="result">A <see cref="Func{TResult}"/> to invoke and return from.</param>
        /// <param name="logStatement">Any action to complete before returning from <paramref name="result"/>, but intended for logging.</param>
        /// <returns><paramref name="result"/></returns>
        /// <example>
        /// <code>
        /// public string IndicativeMethod() => myMethodGroup.ExecWithLogging(() => Logger.Info("Logging something meaningful")); 
        /// </code>
        /// </example>
        public static TResult ExecWithLogging<TResult>(this Func<TResult> result, Action logStatement)
        {
            logStatement();
            return result();
        }
    }
}
