using System;
using Autofac;
using Xamagon.SeedApp.Common;
using Xamagon.SeedApp.iOS.Providers;

namespace Xamagon.SeedApp.iOS
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
        }
    }
}

