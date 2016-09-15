using System.Threading.Tasks;
using Newtonsoft.Json;
using SQLite;
using Xamagon.SeedApp.Common.Data;
using Xamagon.SeedApp.Common.Logging;
using Xamagon.SeedApp.Data.Entities;

namespace Xamagon.SeedApp.Data.Logging
{
    public class LocalDbLoggingProvider : ILoggingProvider
    {
        private readonly IDataConfigProvider _dataConfigProvider;

        public LocalDbLoggingProvider(IDataConfigProvider dataConfigProvider)
        {
            _dataConfigProvider = dataConfigProvider;
        }

        public void Log(string message, LogLevel level, object data, string[] tags, string callerFullTypeName, string callerMemberName)
        {
            LogEntry log = new LogEntry
            {
                Message = message,
                Level = level.ToString(),
                CallerMemberName = callerMemberName,
                CallerFullTypeName = callerFullTypeName,
                Data = data == null ? null : JsonConvert.SerializeObject(data),
                TaskId = TaskScheduler.Current.Id
            };

            var dbConnection = new SQLiteConnection(_dataConfigProvider.LogsDatabasePath);
            dbConnection.CreateTable<LogEntry>();
            dbConnection.Insert(log);
        }
    }
}