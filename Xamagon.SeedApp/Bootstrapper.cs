using System;
using Autofac;

namespace Xamagon.SeedApp
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