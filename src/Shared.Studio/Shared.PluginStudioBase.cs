using BepInEx;
using KKAPI.Studio;
using KKAPI.Studio.UI;
using Studio;
using UniRx;

namespace IllusionMods.InvisibleBody
{
    /// <summary>
    /// Studio UI code
    /// </summary>
    public class StudioPluginBase : BaseUnityPlugin
    {
        public const string GUID = PluginBase.GUID + "studio";
        public const string PluginName = PluginBase.PluginName + " Studio UI";
        public const string Version = PluginBase.Version;

        internal void Start() => RegisterStudioControls();

        private static void RegisterStudioControls()
        {
            var invisibleSwitch = new CurrentStateCategorySwitch("Invisible Body", controller => controller.charInfo.GetComponent<CharaController>().Invisible);
            invisibleSwitch.Value.Subscribe(Observer.Create((bool value) =>
            {
                var controller = GetSelectedStudioController();
                if (controller != null)
                    controller.Invisible = value;
            }));

            StudioAPI.GetOrCreateCurrentStateCategory("").AddControl(invisibleSwitch);
        }

        private static CharaController GetSelectedStudioController() => FindObjectOfType<MPCharCtrl>()?.ociChar?.charInfo?.GetComponent<CharaController>();
    }
}
