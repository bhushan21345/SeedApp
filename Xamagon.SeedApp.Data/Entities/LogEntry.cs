using System;
using Realms;
using Xamagon.SeedApp.Common.Utilities;

namespace Xamagon.SeedApp.Data.Entities
{
    public class LogEntry : RealmObject
    {
        public LogEntry()
        {
            LogKey = RandomTextGenerator.GenerateRandomString(12);
        }

        public string LogKey { get; set; }

        public DateTimeOffset CreatedOn { get; set; } = DateTime.UtcNow;

        public string Message { get; set; }

        public string Level { get; set; }

        public string Tags { get; set; }

        public string CallerMemberName { get; set; }

        public string CallerFullTypeName { get; set; }

        public string Data { get; set; }

        public int TaskId { get; set; }
    }
}