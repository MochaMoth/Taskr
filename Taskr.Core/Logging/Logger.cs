using System;
using System.Collections.Generic;
using System.Text;

namespace Taskr.Core.Logging
{
    public static class Logger
    {
        private static readonly ILogger _logger = new BasicConsoleLogger();

        public static void Log(string message) => _logger.Log(message);
    }
}
