using System;
using System.Threading.Tasks;

namespace Xamagon.SeedApp.Common
{
    public interface INavigationService
    {
        PageKey CurrentPageKey { get; }

        Task LoginStatusChanged ();

        Task NavigateTo (PageKey pageKey, bool animated = false);

        Task PopToRoot ();

        Task GoBack ();
    }

    public enum PageKey
    {
        LoginPage
    }
}