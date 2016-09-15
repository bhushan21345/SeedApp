using System.Threading.Tasks;

namespace Xamagon.SeedApp.Common.Interfaces
{
    public interface IDialogService
    {
        Task DisplayAlert (string title, string message, string cancel);

        Task<bool> DisplayAlert (string title, string message, string ok, string cancel);
    }
}