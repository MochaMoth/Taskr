using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Taskr.Core.Logging
{
    public class BasicConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Debug.WriteLine(message);
        }
    }
}
