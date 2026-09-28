using ResurgencePluginBridge;
using ResurgencePluginBridge.Attributes;

namespace ResurgencePlugin.Mods.ExampleCategory;
// Be sure to keep this general layout of RootNamespace.Mods.CategoryName

[PluginPreferenced] // This makes the mod's toggle status save between play sessions.
[PluginToggleable] // This makes the mod actually support Preferenced, and makes it toggleable.
public class ExampleToggleableMod : Mod // Inherited from Mod
{
    // Due to Mod being a MonoBehaviour, you have full access to the Unity lifecycle.
    // This also gives you much more control over what your features do.
    public void Update()
    {
        
    }

    public void Start()
    {
        
    }
}