using ExtensibleSaveFormat;
using KKAPI;
using KKAPI.Chara;
using System.Collections;
using System.Linq;
using UniRx;
using UnityEngine;
#if AI
using AIChara;
#endif

namespace IllusionMods.InvisibleBody
{
    class InvisibleBodyItem : MonoBehaviour
    {
        /// <summary>
        /// Loads effect when accessory is added
        /// </summary>
        internal void Start()
        {
            PluginBase.Logger.LogMessage($"InvisibleBodyItem Start");
            var chaControl = GetComponentInParent<ChaControl>();
            var charaController = PluginBase.GetController(chaControl);
            charaController.AccVisible = false;
        }

        /// <summary>
        /// Activates effect when accessory is unhidden but not when first loaded
        /// </summary>
        private void OnEnable()
        {
            var chaControl = GetComponentInParent<ChaControl>();
            var charaController = PluginBase.GetController(chaControl);
            if (chaControl == null) return;
            else
                PluginBase.Logger.LogMessage($"InvisibleBodyItem On");
            charaController.AccVisible = false;
        }

        /// <summary>
        /// Disables effect when accessory is hidden
        /// </summary>
        private void OnDisable()
        {
            PluginBase.Logger.LogMessage($"InvisibleBodyItem Off");
            var chaControl = GetComponentInParent<ChaControl>();
            var charaController = PluginBase.GetController(chaControl);
            charaController.AccVisible = true;
        }
    }
}
