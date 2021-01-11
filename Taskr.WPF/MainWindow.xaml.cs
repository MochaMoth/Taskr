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
            _logWindow = new LogWindow();
            _logWindow.Show();
            Logger.AddLogger(new BasicConsoleLogger(LogLevel.Error));
            Logger.AddLogger(_logWindow);
            InitializeComponent();
            Loaded += InitializeWindow;
        }
        
        public void InitializeWindow(object sender, RoutedEventArgs e)
        {
            Logger.Log("Hello");
            Logger.LogInfo("Here's some info.");
            Logger.LogWarning("Something non-critical happened.");
            Logger.LogError("Some exception happened, but we stopped the execution.");
        }
    }
}
