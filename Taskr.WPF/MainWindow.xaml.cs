using System.Diagnostics;
using System.Windows;
using Taskr.Core.Logging;

namespace Taskr.WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += InitializeWindow;
        }

        public void InitializeWindow(object sender, RoutedEventArgs e)
        {
            Logger.Log("Hello");
        }
    }
}
