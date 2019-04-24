using ModuleOne.Views;
using Prism.Ioc;
using Prism.Modularity;


namespace ModuleOne
{
    public class ModuleOne_Module : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewOne>();

        }
    }
}

