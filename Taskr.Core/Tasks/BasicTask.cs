using System;
using System.Collections.Generic;
using System.Text;

namespace Taskr.Core.Tasks
{
    class BasicTask : ITask
    {
        public bool DoShow => throw new NotImplementedException();
    }
}
