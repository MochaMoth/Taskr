using System.Collections.Generic;
using System.Linq;

namespace Taskr.Core.Tasks
{
	class MultiTask : ITask
	{
		public bool DoShow => _tasks.Any(task => task.DoShow);

		private List<ITask> _tasks = new List<ITask>();
	}
}
