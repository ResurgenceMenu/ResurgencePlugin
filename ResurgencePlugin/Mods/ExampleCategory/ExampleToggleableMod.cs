using ResurgencePluginBridge;
using ResurgencePluginBridge.Attributes;

namespace ResurgencePlugin.Mods.ExampleCategory;
// Be sure to keep this general layout of RootNamespace.Mods.CategoryName
// At the very least, "Mods" must be the second part, and the end must be the name of the category.

[PluginToggleable] // This makes the mod toggleable.
[PluginPreferenced] // This makes the mod's toggle status save between play sessions.
// Making a mod preferenced requires it to be toggleable.
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