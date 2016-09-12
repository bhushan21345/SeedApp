using System;
using Autofac;

namespace Xamagon.SeedApp.Droid
{
    public class Bootstrapper
    {
        public static void Initialize (ContainerBuilder builder)
        {
            RegisterTypes (builder);
        }

        private static void RegisterTypes (ContainerBuilder containerBuilder)
        {
        }
    }
}