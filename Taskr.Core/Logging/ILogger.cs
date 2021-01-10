using System;
using System.Collections.Generic;
using System.Text;

namespace Taskr.Core.Logging
{
    public interface ILogger
    {
        void Log(string message);
        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(string message);
    }
}
