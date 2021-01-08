using System;

namespace Taskr.Core.Database
{
    [Serializable]
    public struct RecordTracker
    {
        public ulong UUID { get; set; }
        public IRecord Record { get; set; }

        public RecordTracker(ulong uuid, IRecord record)
        {
            UUID = uuid;
            Record = record;
        }
    }
}
