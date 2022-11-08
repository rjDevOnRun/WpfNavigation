using MainApp.Stores;

namespace MainApp.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;

        public MainViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(this.CurrentViewModel));
        }

        public override void Dispose()
        {
            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
            base.Dispose();
        }
    }
}