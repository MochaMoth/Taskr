using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Taskr.Core.Logging;
using UCL.Logger;

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

		protected override void OnClosing(CancelEventArgs e)
		{
			if (Visibility == Visibility.Hidden)
				return;

			e.Cancel = true;
			Hide();
		}

		private void AddLog(string message, string logLevel)
		{
			LogItem logItem = new LogItem(message, logLevel);
			LogList.Items.Add(logItem);
		}

		public void LogInfo(string message)
		{
			if ((int)_logLevel >= (int)LogLevel.Info)
				AddLog(message, LogLevel.Info.ToString());
		}

		public void LogWarning(string message)
		{
			if ((int)_logLevel >= (int)LogLevel.Warning)
				AddLog(message, LogLevel.Warning.ToString());
		}

		public void LogError(string message)
		{
			if ((int)_logLevel >= (int)LogLevel.Error)
				AddLog(message, LogLevel.Error.ToString());
		}

		public void Log(string message)
		{
			if ((int)_logLevel >= (int)LogLevel.Debug)
				AddLog(message, LogLevel.Debug.ToString());
		}
	}
}
