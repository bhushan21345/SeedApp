using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Autofac;
using Xamagon.SeedApp.Common;
using Xamarin.Forms;

namespace Xamagon.SeedApp.Services
{
    public class NavigationService : INavigationService
    {
        private readonly Dictionary<Type, PageKey> _pages;
        private NavigationPage _navigation;

        public PageKey CurrentPageKey => _pages [_navigation.CurrentPage.GetType ()];

        public NavigationService ()
        {
            _pages = new Dictionary<Type, PageKey> ();
        }

        public async Task LoginStatusChanged ()
        {
            await NavigateTo (PageKey.LoginPage);
        }

        public async Task NavigateTo (PageKey pageKey, bool animated = false)
        {
            var page = GetPage (pageKey);

            if (pageKey == PageKey.LoginPage) {
                _navigation = null;
                App.Current.MainPage = page;
            }

            await _navigation.PushAsync (page, animated);
        }

        public async Task GoBack ()
        {
            await _navigation.PopAsync ();
        }

        public async Task PopToRoot ()
        {
            await _navigation.PopToRootAsync (true);
        }

        private ContentPage GetPage (PageKey pageKey)
        {
            ContentPage page;

            switch (pageKey) {
            case PageKey.LoginPage:
                page = ContainerManager.Container.Resolve<LoginPage> ();
                break;
            default:
                throw new ArgumentException (
                    $"No such page: {pageKey}. Did you forget to call NavigationService.Configure?", nameof (pageKey));
            }

            if (!_pages.ContainsKey (page.GetType ()))
                _pages.Add (page.GetType (), pageKey);

            return page;
        }
    }
}

