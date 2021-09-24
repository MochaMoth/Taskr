using System;
using System.Collections.Generic;
using System.Text;

namespace Taskr.Core.Logging
{
	public interface ILogger
	{
		void LogInfo(string message);
		void LogWarning(string message);
		void LogError(string message);
		void Log(string message);
	}
}
