using System.Windows;

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
            //
        }
    }
}
