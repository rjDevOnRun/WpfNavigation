using MainApp.Stores;
using MainApp.ViewModels;

namespace MainApp.Commands
{
    public class NavigateAccountCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public NavigateAccountCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new AccountViewModel(_navigationStore);
        }
    }
}