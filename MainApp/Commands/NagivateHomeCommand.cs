using MainApp.Stores;
using MainApp.ViewModels;

namespace MainApp.Commands
{
    public class NagivateHomeCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public NagivateHomeCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new HomeViewModel(_navigationStore);
        }
    }
}