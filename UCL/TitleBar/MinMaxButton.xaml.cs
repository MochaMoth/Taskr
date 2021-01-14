using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace UCL.TitleBar
{
	public partial class MinMaxButton : UserControl
	{
		public MinMaxButton()
		{
			InitializeComponent();
            Loaded += Initialize;
            
        }

        public void Initialize(object sender, RoutedEventArgs e)
		{
            if (DesignerProperties.GetIsInDesignMode(this))
                return;
            Window window = Window.GetWindow(this);
            Window.GetWindow(this).StateChanged += WindowStateChanged;
            WindowStateChanged(this, null);
        }

        private void RefreshMaximizeRestoreButton()
        {
            Window window = Window.GetWindow(this);
            if (window.WindowState == WindowState.Maximized)
            {
                maximizeButton.Visibility = Visibility.Collapsed;
                restoreButton.Visibility = Visibility.Visible;
            }
            else
            {
                maximizeButton.Visibility = Visibility.Visible;
                restoreButton.Visibility = Visibility.Collapsed;
            }
        }

        public void WindowStateChanged(object sender, EventArgs e) => RefreshMaximizeRestoreButton();
        public void OnMaximizeRestoreButtonClick(object sender, RoutedEventArgs e) => 
            Window.GetWindow(this).WindowState = Window.GetWindow(this).WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
    }
}
