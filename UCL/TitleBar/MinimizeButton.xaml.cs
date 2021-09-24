using System.Windows;
using System.Windows.Controls;

namespace UCL.TitleBar
{
	public partial class MinimizeButton : UserControl
	{
		public MinimizeButton()
		{
			InitializeComponent();
		}

		public void OnMinimizeButtonClick(object sender, RoutedEventArgs e) => Window.GetWindow(this).WindowState = WindowState.Minimized;
	}
}
