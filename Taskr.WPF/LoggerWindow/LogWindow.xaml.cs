using System.Windows;
using Taskr.Core.Logging;

namespace Taskr.WPF.LoggerWindow
{
	public partial class LogWindow : Window, ILogger
	{
		private LogLevel _logLevel;

		public LogWindow(LogLevel logLevel)
		{
			InitializeComponent();
			_logLevel = logLevel;
		}

		public void LogInfo(string message)
		{
			if ((int)_logLevel >= (int)LogLevel.Info)
				return;
		}

		public void LogWarning(string message)
		{
			if ((int)_logLevel >= (int)LogLevel.Warning)
				return;
		}

		public void LogError(string message)
		{
			if ((int)_logLevel >= (int)LogLevel.Error)
				return;
		}

		public void Log(string message)
		{
			if ((int)_logLevel >= (int)LogLevel.Debug)
				return;
		}
	}
}
