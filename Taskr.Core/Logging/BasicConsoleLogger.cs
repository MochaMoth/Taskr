using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Taskr.Core.DateTimeFormatters;

namespace Taskr.Core.Logging
{
    public class BasicConsoleLogger : ILogger
    {
        private LogLevel _logLevel;
        private IDateTimeFormat _dateTimeFormat;

        public BasicConsoleLogger(LogLevel logLevel)
        {
            _logLevel = logLevel;
            _dateTimeFormat = new DateTimeDebugFormat();
        }

        public void Log(string message)
        {
            if ((int)_logLevel >= (int)LogLevel.Debug)
                Debug.WriteLine($"{_dateTimeFormat.GetPretty(DateTime.Now)} - Debug: {message}");
        }

        public void LogInfo(string message)
        {
            if ((int)_logLevel >= (int)LogLevel.Info)
                Debug.WriteLine($"{_dateTimeFormat.GetPretty(DateTime.Now)} - Info: {message}");
        }

        public void LogWarning(string message)
        {
            if ((int)_logLevel >= (int)LogLevel.Error)
                Debug.WriteLine($"{_dateTimeFormat.GetPretty(DateTime.Now)} - Warning: {message}");
        }

        public void LogError(string message)
        {
            if ((int)_logLevel >= (int)LogLevel.Warning)
                Debug.WriteLine($"{_dateTimeFormat.GetPretty(DateTime.Now)} - Error: {message}");
        }
    }
}
