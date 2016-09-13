using Xamagon.SeedApp.Common;
using Xamarin.Forms;

namespace Xamagon.SeedApp
{
    public partial class App : Application
    {
        private readonly INavigationService _navigationService;

        public App(INavigationService navigationService)
        {
            InitializeComponent();
            _navigationService = navigationService;

            _navigationService.LoginStatusChanged ();

            //MainPage = new Xamagon.SeedApp.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
