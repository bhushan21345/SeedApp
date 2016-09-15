using System;
using System.Runtime.CompilerServices;

namespace Xamagon.SeedApp.Common.Logging
{
    public interface ILogger
    {
        void Error(
            string message,
            object data = null,
            string[] tags = null,
            [CallerMemberName] string callerName = null, string callerFullTypeName = null);

        void Exception(Exception exception, string[] tags = null, [CallerMemberName] string callerName = null, string callerFullTypeName = null);

        void Info(string message, object data = null, string[] tags = null, [CallerMemberName] string callerName = null, string callerFullTypeName = null);

        void Verbose(
            string message,
            object data = null,
            string[] tags = null,
            [CallerMemberName] string callerName = null, string callerFullTypeName = null);

        void Warning(
            string message,
            object data = null,
            string[] tags = null,
            [CallerMemberName] string callerName = null, string callerFullTypeName = null);
    }
}
