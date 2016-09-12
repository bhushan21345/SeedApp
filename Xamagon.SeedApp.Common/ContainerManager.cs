using Autofac;

namespace Xamagon.SeedApp.Common
{
    public class ContainerManager
    {
        private static IContainer _container;

        public static ContainerBuilder DependencyRegistrar { get; set; }

        public static IContainer Container {
            get {
                if (_container == null) {
                    _container = DependencyRegistrar.Build ();
                }

                return _container;
            }
        }

        public static void InitializeDependencyRegistrar ()
        {
            DependencyRegistrar = new ContainerBuilder ();

            Bootstrapper.Initialize (DependencyRegistrar);
        }
    }
}