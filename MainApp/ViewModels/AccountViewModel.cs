using MainApp.Commands;
using MainApp.Stores;
using System.Windows.Input;

namespace MainApp.ViewModels
{
    public class AccountViewModel : ViewModelBase
    {
        private string _title = "This is the Accounts Page";
        private readonly NavigationStore _navigationStore;

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        public ICommand NavigateHomeCommand { get; }

        public AccountViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;

            NavigateHomeCommand = new NagivateCommand<HomeViewModel>(
                _navigationStore,
                () => new HomeViewModel(_navigationStore));
        }
    }
}