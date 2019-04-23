using Prism.Ioc;
using Prism.Unity;
using WpfApp3.Views;
using System.Windows;
using WpfApp3.Core.Calculators;
using test1.Core.test;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<Shell>();

        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<ICalculator, ExpressionCalculator>();
            containerRegistry.Register<ITest, Test>();
           
        }

    }
}
