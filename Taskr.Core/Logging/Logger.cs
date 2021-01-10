using System;
using System.Collections.Generic;
using System.Text;

namespace Taskr.Core.Logging
{
    public static class Logger
    {
        private static List<ILogger> _loggers;

        public static void AddLogger(ILogger logger)
        {
            if (_loggers == null)
                _loggers = new List<ILogger>();
            _loggers.Add(logger);
            _log += logger.Log;
            _logInfo += logger.LogInfo;
            _logWarning += logger.LogWarning;
            _logError += logger.LogError;
        }

        public static void RemoveLogger(ILogger logger)
        {
            if (_loggers.Contains(logger))
                _loggers.Remove(logger);
            _log -= logger.Log;
            _logInfo -= logger.LogInfo;
            _logWarning -= logger.LogWarning;
            _logError -= logger.LogError;
        }

        static Action<string> _log;
        static Action<string> _logInfo;
        static Action<string> _logWarning;
        static Action<string> _logError;

        public static void Log(string message) => _log(message);
        public static void LogInfo(string message) => _logInfo(message);
        public static void LogWarning(string message) => _logWarning(message);
        public static void LogError(string message) => _logError(message);
    }
}
