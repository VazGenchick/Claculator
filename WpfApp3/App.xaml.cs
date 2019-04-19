using System.Windows;
using Bootstrapper = WpfApp3.App_Start.Bootstrapper;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            new Bootstrapper().Run();
        }

    }
}
