using MainApp.Services;
using MainApp.Stores;
using MainApp.ViewModels;
using System.Windows;

namespace MainApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            NavigationStore navigationStore = new NavigationStore();

            navigationStore.CurrentViewModel = new AccountViewModel(navigationStore);

            MainWindow window = new MainWindow()
            {
                DataContext = new MainViewModel(navigationStore)
            };

            window.Show();

            base.OnStartup(e);
        }
    }
}