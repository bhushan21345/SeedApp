using System.Threading.Tasks;
using Xamarin.Forms;
using XLabs.Forms.Mvvm;

namespace Xamagon.SeedApp.ViewModels
{
    public class BaseViewModel : ViewModel
    {
        private Color _backgroundColor;
        private string _title, _loadingText;
        private bool _isLoading;

        public BaseViewModel ()
        {
            _isLoading = false;
            _loadingText = "";
        }

        public Color BackgroundColor {
            get { return _backgroundColor; }
            set { SetProperty (ref _backgroundColor, value); }
        }

        public string Title {
            get { return _title; }
            set { SetProperty (ref _title, value); }
        }

        public string LoadingText {
            get { return _loadingText; }
            set { SetProperty (ref _loadingText, value); }
        }

        public bool IsLoading {
            get { return _isLoading; }
            set { SetProperty (ref _isLoading, value); }
        }

        public virtual async Task OnViewAppear ()
        {
        }

        public virtual async Task OnViewDisappear ()
        {
        }
    }
}