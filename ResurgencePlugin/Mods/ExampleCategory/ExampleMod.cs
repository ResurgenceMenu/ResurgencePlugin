using ResurgencePluginBridge; // All API for the plugin system will be in here
using ResurgencePluginBridge.Attributes;

namespace ResurgencePlugin.Mods.ExampleCategory;
// Be sure to keep this general layout of RootNamespace.Mods.CategoryName
// At the very least, "Mods" must be the second part, and the end must be the name of the category.

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