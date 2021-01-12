using System;
using System.Collections.Generic;
using System.Text;

namespace Taskr.Core.DateTimeFormatters
{
	public class DateTimeDebugFormat : IDateTimeFormat
	{
		public string GetPretty(DateTime dateTime)
		{
			return $"{dateTime.Hour:00}:{dateTime.Minute:00}:{dateTime.Second:00}:{dateTime.Millisecond:000}";
		}
	}
}
