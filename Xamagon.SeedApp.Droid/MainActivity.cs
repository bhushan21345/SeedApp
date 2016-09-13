using Android.App;
using Android.Content.PM;
using Android.OS;
using Xamagon.SeedApp.Common;
using Autofac;

namespace Xamagon.SeedApp.Droid
{
    [Activity(Label = "Xamagon.SeedApp", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            WireupDependencies ();

            var application = ContainerManager.Container.Resolve<App> ();
            LoadApplication (application);
            //LoadApplication(new App());
        }

        private static void WireupDependencies ()
        {
            ContainerManager.InitializeDependencyRegistrar ();
            Data.Bootstrapper.Initialize (ContainerManager.DependencyRegistrar);
            SeedApp.Bootstrapper.Initialize (ContainerManager.DependencyRegistrar);
            Bootstrapper.Initialize (ContainerManager.DependencyRegistrar);
        }
    }
}

