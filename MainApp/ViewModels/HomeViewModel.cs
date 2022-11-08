using MainApp.Commands;
using MainApp.Stores;
using System.Windows.Input;

namespace MainApp.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        private string _title = "This is the Home Page";

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        public ICommand NavigateAccountCommand { get; }

        public HomeViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;

            NavigateAccountCommand = new NagivateCommand<AccountViewModel>(
                _navigationStore,
                () => new AccountViewModel(_navigationStore));
        }
    }
}