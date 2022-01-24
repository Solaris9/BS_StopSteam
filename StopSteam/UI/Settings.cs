using System;
using BeatSaberMarkupLanguage.Attributes;
using BeatSaberMarkupLanguage.Settings;
using StopSteam.Configuration;
using Zenject;

namespace StopSteam.UI
{
    public class Settings : IInitializable, IDisposable
    {
        [Inject] private PluginConfig _config;
        
        [UIValue("stop-steam")]
        public bool StopSteam
        {
            get => _config.StopSteam;
            set => _config.StopSteam = value;
        }

        public void Initialize() =>  BSMLSettings.instance.AddSettingsMenu("StopSteam", "StopSteam.UI.Settings.bsml", this);

        public void Dispose() => BSMLSettings.instance.RemoveSettingsMenu(this);
    }
}