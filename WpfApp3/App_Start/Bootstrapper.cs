using System.Windows;
using Prism.Unity;
using Unity;
using WpfApp3.Views;

namespace WpfApp3.App_Start
{
    public class Bootstrapper : UnityBootstrapper
    {

        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            Container.RegisterInstances();
        }
    }
}
