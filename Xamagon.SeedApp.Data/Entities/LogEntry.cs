using SQLite;

namespace Xamagon.SeedApp.Data.Entities
{
    [Table("LogEntry")]
    public class LogEntry : EntityBase
    {
        public string Message { get; set; }

        public string Level { get; set; }

        public string Tags { get; set; }

        public string CallerMemberName { get; set; }

        public string CallerFullTypeName { get; set; }

        public string Data { get; set; }

        public int TaskId { get; set; }
    }
}