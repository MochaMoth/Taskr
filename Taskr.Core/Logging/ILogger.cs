using System;
using System.Collections.Generic;
using System.Text;

namespace Taskr.Core.Logging
{
    public interface ILogger
    {
        void Log(string message);
    }
}
