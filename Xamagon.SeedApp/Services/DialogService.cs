using System.Threading.Tasks;
using Xamagon.SeedApp.Common.Interfaces;

namespace Xamagon.SeedApp.Services
{
    public class DialogService : IDialogService
    {
        public Task DisplayAlert (string title, string message, string cancel)
        {
            return App.Current.MainPage.DisplayAlert (title, message, cancel);
        }

        public Task<bool> DisplayAlert (string title, string message, string ok, string cancel)
        {
            return App.Current.MainPage.DisplayAlert (title, message, ok, cancel);
        }
    }
}