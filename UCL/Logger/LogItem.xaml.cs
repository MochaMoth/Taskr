using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media;

namespace UCL.Logger
{
	public partial class LogItem : UserControl
	{
		private readonly Dictionary<string, Color> _backgrounds = new Dictionary<string, Color> {
			{ "Info", Color.FromRgb(51, 204, 51) },
			{ "Warning", Color.FromRgb(204, 204, 51) },
			{ "Error", Color.FromRgb(204, 51, 51) },
			{ "Debug", Color.FromRgb(51, 51, 204) }
		};

		private readonly Dictionary<string, Color> _foregrounds = new Dictionary<string, Color> {
			{ "Info", Color.FromRgb(255, 255, 255) },
			{ "Warning", Color.FromRgb(255, 255, 255) },
			{ "Error", Color.FromRgb(255, 255, 255) },
			{ "Debug", Color.FromRgb(255, 255, 255) }
		};

		public LogItem(string message, string logLevel)
		{
			InitializeComponent();
			LogTitle.Text = logLevel;
			LogBody.Text = message;

			Resources["Background"] = new SolidColorBrush(_backgrounds[logLevel]);
			Resources["Foreground"] = new SolidColorBrush(_foregrounds[logLevel]);
		}
	}
}
