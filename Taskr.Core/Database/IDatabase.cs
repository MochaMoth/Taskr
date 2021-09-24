using System;
using System.Collections.Generic;
using System.Text;

namespace Taskr.Core.Database
{
	interface IDatabase
	{
		void Initialize();
		void AddRecord<T>(T record) where T : IRecord, new();
	}
}
