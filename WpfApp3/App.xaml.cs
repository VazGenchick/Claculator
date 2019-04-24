using Prism.Ioc;
using Prism.Unity;
using WpfApp3.Views;
using System.Windows;
using WpfApp3.Core.Calculators;
using test1.Core.test;
using Unity.Lifetime;
using Prism.Modularity;

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

        protected override void RegisterTypes(IContainerRegistry container)
        {
            container.Register<ICalculator, ExpressionCalculator>();
            container.Register<ITest, Test>();
                 
        }
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ModuleOne.ModuleOne_Module>();
        }
    }
}
