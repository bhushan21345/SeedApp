using System;
using Autofac;
using Xamagon.SeedApp.Common.Logging;
using Xamagon.SeedApp.Data.Logging;

namespace Xamagon.SeedApp.Data
{
    public class Bootstrapper
    {
        public static void Initialize (ContainerBuilder builder)
        {
            RegisterLoggingProviders(builder);
            RegisterTypes (builder);
        }

        private static void RegisterLoggingProviders(ContainerBuilder builder)
        {
            builder.RegisterType<ILoggingProvider>().As<LocalDbLoggingProvider>();
            builder.RegisterType<ILogger>().As<Logger>();
        }

        private static void RegisterTypes (ContainerBuilder containerBuilder)
        {
        }
    }
}