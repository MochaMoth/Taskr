using System;
using System.Collections.Generic;
using System.Text;

namespace Taskr.Core.Logging
{
    public static class Logger
    {
        private static ILogger _logger;

        public static void Log(string message) => _logger.Log(message);

        public static void SetLogger(ILogger logger) => _logger = logger;
    }
}
