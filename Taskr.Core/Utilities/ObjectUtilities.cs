using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Taskr.Core.Utilities
{
    class ObjectUtilities
    {
        public static bool IsSerializable<T>(T obj)
        {
            if (!typeof(T).IsSerializable && !(typeof(ISerializable).IsAssignableFrom(typeof(T))))
                throw new InvalidOperationException("Database Records must be Serializable.");

            return true;
        }
    }
}
