using StopSteam.Configuration;
using StopSteam.UI;
using Zenject;

namespace StopSteam
{
    public class MenuInstaller : Installer
    {
        private readonly PluginConfig _config;

        public MenuInstaller(PluginConfig config) => _config = config;
        
        public override void InstallBindings()
        {
            Container.BindInstance(_config).AsSingle();
            Container.BindInterfacesAndSelfTo<Settings>().AsSingle();
        }
    }
}