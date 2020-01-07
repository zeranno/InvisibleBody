using BepInEx;

namespace IllusionMods.InvisibleBody
{
    [BepInProcess(Constants.StudioProcessName)]
    [BepInDependency(KKAPI.KoikatuAPI.GUID)]
    [BepInPlugin(GUID, PluginName, Version)]
    public class PluginStudio : StudioPluginBase { }
}
