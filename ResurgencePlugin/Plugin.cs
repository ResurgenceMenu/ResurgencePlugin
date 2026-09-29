using BepInEx;

namespace ResurgencePlugin;

[BepInPlugin(Constants.Guid, Constants.Name, Constants.Version)]
[BepInDependency("Industry.ResurgencePluginBridge")] // This is recommended to keep, as the mods won't load if Resurgence isn't present
[BepInDependency("industry.resurgencev2")]
public class Plugin : BaseUnityPlugin
{
    // This will not be used by default, but you can deal with harmony patching and anything else needed here!
}