using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Taskr.Core.Logging;

namespace Taskr.WPF.LoggerWindow
{
    public partial class LogWindow : Window, ILogger
    {
        public LogWindow()
        {
            InitializeComponent();
        }

        public void Log(string message)
        {
            //
        }

        public void LogInfo(string message)
        {
            //
        }

        public void LogWarning(string message)
        {
            //
        }

        public void LogError(string message)
        {
            //
        }
    }
}
