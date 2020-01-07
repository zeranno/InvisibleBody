using BepInEx;
using KKAPI.Maker;
using KKAPI.Maker.UI;
using UniRx;
#if AI
using AIChara;
#endif

namespace IllusionMods.InvisibleBody
{
    /// <summary>
    /// Sets the selected characters invisible in Studio or character maker. Invisible state saves and loads with the scene or card.
    /// </summary>
    public class PluginMakerBase : BaseUnityPlugin
    {
        public const string GUID = PluginBase.GUID + "maker";
        public const string PluginName = PluginBase.PluginName + " Maker UI";
        public const string Version = PluginBase.Version;

        internal static MakerToggle InvisibleToggle;

        internal void Start()
        {
            MakerAPI.RegisterCustomSubCategories += MakerAPI_RegisterCustomSubCategories;
            MakerAPI.ReloadCustomInterface += MakerAPI_ReloadCustomInterface;
        }

        private void MakerAPI_ReloadCustomInterface(object sender, System.EventArgs e) => InvisibleToggle.SetValue(PluginBase.GetController(MakerAPI.GetCharacterControl()).Invisible, false);

        private void MakerAPI_RegisterCustomSubCategories(object sender, RegisterSubCategoriesEvent e)
        {
            InvisibleToggle = e.AddControl(new MakerToggle(MakerConstants.Body.All, "Invisible Body", false, this));
            InvisibleToggle.ValueChanged.Subscribe(Observer.Create<bool>(delegate { PluginBase.GetController(MakerAPI.GetCharacterControl()).Visible = !InvisibleToggle.Value; }));
        }
    }
}
