using System.Windows;
using Taskr.Core.Logging;
using Taskr.WPF.LoggerWindow;

namespace Taskr.WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            LogWindow logWindow = new LogWindow();
            logWindow.Show();
            Logger.AddLogger(new BasicConsoleLogger(LogLevel.Error));
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
