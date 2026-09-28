using ResurgencePluginBridge; // All API for the plugin system will be in here
using ResurgencePluginBridge.Attributes;

namespace ResurgencePlugin.Mods.ExampleCategory;
// Be sure to keep this general layout of RootNamespace.Mods.CategoryName

[PluginHideInVR] // This will make this mod not load in VR
[PluginHideInDesktop] // This makes it not load on Desktop
// In combination, this mod won't load no matter what.
public class ExampleMod : Mod // All mods must inherit this class (Mod).
{
    public override void Execute()
    {
        // This will run when this non-toggleable mod is pressed.
    }
}