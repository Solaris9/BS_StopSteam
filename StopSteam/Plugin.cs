using System.Diagnostics;
using IPA;
using IPA.Config;
using IPA.Config.Stores;
using StopSteam.Configuration;
using IPALogger = IPA.Logging.Logger;

namespace StopSteam
{
    [Plugin(RuntimeOptions.DynamicInit)]
    public class Plugin
    {
        private PluginConfig _config;

        [Init]
        public void Init(Config config) => _config = config.Generated<PluginConfig>();

        [OnExit]
        public void OnApplicationClose()
        {
            if (!_config.StopSteam) return;
                
            var processes = Process.GetProcessesByName("steam");
            if (processes.Length != 0) processes[0].Kill();
        }
    }
}