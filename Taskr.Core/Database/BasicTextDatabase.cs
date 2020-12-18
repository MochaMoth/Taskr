using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

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
            if (!typeof(T).IsSerializable && !(typeof(ISerializable).IsAssignableFrom(typeof(T))))
                throw new InvalidOperationException("Database Records must be Serializable.");
        }
    }
}
