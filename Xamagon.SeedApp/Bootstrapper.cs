using System;
using Autofac;
using Xamagon.SeedApp.Common;
using Xamagon.SeedApp.Services;

namespace Xamagon.SeedApp
{
    public class Bootstrapper
    {
        public static void Initialize (ContainerBuilder builder)
        {
            RegisterPages (builder);
            RegisterViewmodels (builder);
            RegisterServices (builder);
        }

        private static void RegisterServices (ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<NavigationService> ().As<INavigationService> ();
        }

        private static void RegisterPages (ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<App> ().SingleInstance();
            containerBuilder.RegisterType<LoginPage> ().SingleInstance ();
        }

        private static void RegisterViewmodels (ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<LoginPageViewModel>().SingleInstance ();
        }

        private static void RegisterProviders (ContainerBuilder containerBuilder)
        {
        }
    }
}