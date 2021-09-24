using System;
using System.Collections.Generic;
using System.Text;

namespace Taskr.Core.DateTimeFormatters
{
	public interface IDateTimeFormat
	{
		string GetPretty(DateTime dateTime);
	}
}
