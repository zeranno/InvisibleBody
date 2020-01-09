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
        /// Sends a message to log when accessory is first added.
        /// </summary>
        internal void Start()
        {
            PluginBase.Logger.LogMessage($"InvisibleBodyItem Start");
            var chaControl = GetComponentInParent<ChaControl>();
            var charaController = PluginBase.GetController(chaControl);
            charaController.Invisible = true;
        }

        /// <summary>
        /// Activates effect when accessory is on.
        /// </summary>
        private void OnEnable()
        {
            PluginBase.Logger.LogMessage($"InvisibleBodyItem On");
            var chaControl = GetComponentInParent<ChaControl>();
            var charaController = PluginBase.GetController(chaControl); 
            charaController.Invisible = true;
        }

        /// <summary>
        /// Disables effect when accessory is off.
        /// </summary>
        private void OnDisable()
        {
            PluginBase.Logger.LogMessage($"InvisibleBodyItem Off");
            var chaControl = GetComponentInParent<ChaControl>();
            var charaController = PluginBase.GetController(chaControl);
            charaController.Invisible = false;
        }
    }
}
