using System;
using Autofac;
using Xamagon.SeedApp.Common;
using Xamagon.SeedApp.Common.Logging;
using Xamagon.SeedApp.Droid.Providers;

namespace Xamagon.SeedApp.Droid
{
    public class Bootstrapper
    {
        public static void Initialize (ContainerBuilder builder)
        {
            RegisterProviders (builder);
        }

        private static void RegisterProviders (ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<SecureStorageProvider> ().As<ISecureStorageProvider> ();
            containerBuilder.RegisterType<StackFrameProvider>().As<IStackFrameProvider>();
        }
    }
}