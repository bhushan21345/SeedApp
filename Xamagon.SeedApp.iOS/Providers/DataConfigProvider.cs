using System;
using System.IO;
using Xamagon.SeedApp.Common.Data;

namespace Xamagon.SeedApp.iOS.Providers
{
    public class DataConfigProvider : IDataConfigProvider
    {
        public string LogsDatabasePath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "logs.db3");
    }
}
