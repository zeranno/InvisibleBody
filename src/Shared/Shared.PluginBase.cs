using BepInEx;
using BepInEx.Harmony;
using BepInEx.Logging;
using KKAPI.Chara;
using System.Collections.Generic;
#if AI
using AIChara;
#endif

namespace IllusionMods.InvisibleBody
{
    /// <summary>
    /// Sets the selected characters invisible in Studio or character maker. Invisible state saves and loads with the scene or card.
    /// </summary>
    public abstract class PluginBase : BaseUnityPlugin
    {
        public const string GUID = "com.deathweasel.bepinex.invisiblebody";
        public const string PluginName = "Invisible Body";
        public const string PluginDataID = "KK_InvisibleBody";
        public const string Version = "1.3.2";
        internal static new ManualLogSource Logger;

        public static PluginBase Instance { get; private set; }

        /// <summary>
        /// Points where accessories and Studio items are attached. Objects attached to these will not be hidden.
        /// </summary>
        internal abstract HashSet<string> AccessoryAttachPoints { get; }

        /// <summary>
        /// Items attached to characters during specific animations.
        /// </summary>
        internal virtual HashSet<string> RendererBlacklist => new HashSet<string>() { };

        internal void Start()
        {
            Instance = this;
            Logger = base.Logger;

            CharacterApi.RegisterExtraBehaviour<CharaController>(PluginDataID);

            HarmonyWrapper.PatchAll(typeof(Hooks));
        }

        /// <summary>
        /// Get the InvisibleBodyCharaController for the character
        /// </summary>
        public static CharaController GetController(ChaControl character) => character?.gameObject?.GetComponent<CharaController>();
    }
}
