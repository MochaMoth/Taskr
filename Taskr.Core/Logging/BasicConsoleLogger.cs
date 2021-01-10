using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Taskr.Core.Logging
{
    public class BasicConsoleLogger : ILogger
    {
        private LogLevel _logLevel;

        public BasicConsoleLogger(LogLevel logLevel)
        {
            _logLevel = logLevel;
        }

        public void Log(string message)
        {
            if ((int)_logLevel >= (int)LogLevel.Debug)
                Debug.WriteLine(message);
        }

        public void LogInfo(string message)
        {
            if ((int)_logLevel >= (int)LogLevel.Info)
                Debug.WriteLine(message);
        }

        public void LogError(string message)
        {
            if ((int)_logLevel >= (int)LogLevel.Warning)
                Debug.WriteLine(message);
        }

        public void LogWarning(string message)
        {
            if ((int)_logLevel >= (int)LogLevel.Error)
                Debug.WriteLine(message);
        }
    }
}
