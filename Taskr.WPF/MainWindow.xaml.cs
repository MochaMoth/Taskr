using System.Windows;
using Taskr.Core.Logging;
using Taskr.WPF.LoggerWindow;

namespace Taskr.WPF
{
	public partial class MainWindow : Window
	{
		private LogWindow _logWindow;

		public MainWindow()
		{
			InitializeComponent();

			Loaded += InitializeWindow;
			Unloaded += UnloadWindow;
		}
		
		public void InitializeWindow(object sender, RoutedEventArgs e)
		{
			_logWindow = new LogWindow(LogLevel.Debug);
			_logWindow.Show();

			Logger.AddLogger(new BasicConsoleLogger(LogLevel.Debug));
			Logger.AddLogger(_logWindow);

			Logger.Log("Hello");
			Logger.LogInfo("Here's some info.");
			Logger.LogWarning("Something non-critical happened.");
			Logger.LogError("Some exception happened, but we stopped the execution.");
		}

		public void UnloadWindow(object sender, RoutedEventArgs e)
		{
			_logWindow.Close();
		}
	}
}
