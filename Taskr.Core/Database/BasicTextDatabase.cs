using System;
using System.Collections.Generic;
using System.Text;
using Taskr.Core.Utilities;

namespace Taskr.Core.Database
{
    class BasicTextDatabase : IDatabase
    {
        public void Initialize()
        {
            //
        }

        public void AddRecord<T>(T record) where T : IRecord, new()
        {
            _ = ObjectUtilities.IsSerializable(record);
        }
    }
}
