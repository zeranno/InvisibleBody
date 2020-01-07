using BepInEx;

namespace IllusionMods.InvisibleBody
{
    [BepInProcess(Constants.MainGameProcessName)]
    [BepInDependency(KKAPI.KoikatuAPI.GUID)]
    [BepInDependency(ExtensibleSaveFormat.ExtendedSave.GUID)]
    [BepInPlugin(GUID, PluginName, Version)]
    public class PluginMaker : PluginMakerBase { }
}
