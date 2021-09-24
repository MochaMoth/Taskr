using System;

namespace Taskr.Core.Tasks
{
	class BasicTask : ITask
	{
		public bool DoShow => throw new NotImplementedException();
	}
}
