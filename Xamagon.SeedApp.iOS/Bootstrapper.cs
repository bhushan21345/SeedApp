using Autofac;
using Xamagon.SeedApp.Common.Data;
using Xamagon.SeedApp.Common.Logging;
using Xamagon.SeedApp.Common.Security;
using Xamagon.SeedApp.iOS.Providers;
using XLabs.Platform.Services;

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
            containerBuilder.RegisterType<SecureLocalStorageProvider> ().As<ISecureLocalStorageProvider> ();
            containerBuilder.RegisterType<SecureStorage> ().As<ISecureStorage> ();
            containerBuilder.RegisterType<StackFrameProvider>().As<IStackFrameProvider>();
            containerBuilder.RegisterType<DataConfigProvider>().As<IDataConfigProvider>();
        }
    }
}

