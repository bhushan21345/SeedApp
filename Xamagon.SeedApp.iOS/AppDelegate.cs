﻿using Autofac;
using Foundation;
using UIKit;
using Xamagon.SeedApp.Common;

namespace Xamagon.SeedApp.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            WireupDependencies ();

            var application = ContainerManager.Container.Resolve<App> ();
            LoadApplication (application);

            return base.FinishedLaunching(app, options);
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