using System.Windows;
using System.Windows.Navigation;
using SystemTray.Proto.Three.MyService;

namespace SystemTray.Proto.Three
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            RandomService service = new RandomService();

            service.OnStatusChanged = mainWindow.OnServiceStatusChanged;
            this.MainWindow = mainWindow;

            service.Start();
        }
    }
}
