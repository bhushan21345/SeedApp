using System.Threading.Tasks;
using Newtonsoft.Json;
using Realms;
using Xamagon.SeedApp.Common.Logging;
using Xamagon.SeedApp.Data.Entities;

namespace Xamagon.SeedApp.Data.Logging
{
    public class LocalDbLoggingProvider : ILoggingProvider
    {
        public void Log(string message, LogLevel level, object data, string[] tags, string callerFullTypeName, string callerMemberName)
        {
            var realm = Realm.GetInstance();

            realm.Write(() =>
            {
                var log = realm.CreateObject<LogEntry>();
                log.Message = message;
                log.Level = level.ToString();
                log.CallerMemberName = callerMemberName;
                log.CallerFullTypeName = callerFullTypeName;
                log.Data = data == null ? null : JsonConvert.SerializeObject(data);
                log.TaskId = TaskScheduler.Current.Id;
            });
        }
    }
}