using System.Runtime.CompilerServices;
using IPA.Config.Stores;

[assembly: InternalsVisibleTo(GeneratedStore.AssemblyVisibilityTarget)]

namespace StopSteam.Configuration
{
    public class PluginConfig
    {
        public virtual bool StopSteam { get; set; } = false;
    }
}