using System;
using Autofac;
using SQLite;
using Xamagon.SeedApp.Common.Logging;
using Xamagon.SeedApp.Common.Utilities;
using Xamagon.SeedApp.Data.Entities;
using Xamagon.SeedApp.Data.Interfaces;
using Xamagon.SeedApp.Data.Logging;
using Xamagon.SeedApp.Data.Managers;

namespace Xamagon.SeedApp.Data
{
    public class Bootstrapper
    {
        public static void Initialize (ContainerBuilder builder)
        {
            RegisterLoggingProviders (builder);
            RegisterManagers (builder);
            RegisterProviders (builder);
        }

        private static void RegisterLoggingProviders (ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<LocalDbLoggingProvider> ().As<ILoggingProvider> ();
            containerBuilder.RegisterType<Logger> ().As<ILogger> ();
        }

        private static void RegisterManagers (ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<SecurityManager> ().As<ISecurityManager> ();
        }

        private static void RegisterProviders (ContainerBuilder containerBuilder)
        {
        }
    }
}