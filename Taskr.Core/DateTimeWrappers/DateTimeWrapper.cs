using System;

namespace Taskr.Core.DateTimeWrappers
{
	public class DateTimeWrapper
	{
		public static DateTime Now {
			get
			{
				if (_trackCurrentDateTime)
					return DateTime.Now;
				return _artificialDateTime;
			}
		}

		private static DateTime _artificialDateTime;
		private static bool _trackCurrentDateTime = true;

		public static void SetArtificialDateTime(DateTime artificialDateTime)
		{
			_trackCurrentDateTime = false;
			_artificialDateTime = artificialDateTime;
		}

		public static void RemoveArtificialDateTime() => _trackCurrentDateTime = true;
	}
}
