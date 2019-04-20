using test1.Core.test;
using Unity;
using WpfApp3.Core.Calculators;

namespace WpfApp3.App_Start
{
    public static class UnityConfig
    {
        public static IUnityContainer RegisterInstances(this IUnityContainer container)
        {
            container.RegisterType<ICalculator, ExpressionCalculator>();
            container.RegisterType<ITest, Test>();
            return container;
        }
    }
}
