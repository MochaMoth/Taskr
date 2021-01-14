using System.Windows;
using System.Windows.Controls;

namespace UCL.TitleBar
{
	public partial class CloseButton : UserControl
	{
		public CloseButton()
		{
			InitializeComponent();
		}

		public void OnCloseButtonClick(object sender, RoutedEventArgs e) => Window.GetWindow((Button)sender).Close();
	}
}
