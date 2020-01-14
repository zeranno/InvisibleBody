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
        int InvAccCount = 0;

        /// <summary>
        /// Loads effect when accessory is added
        /// </summary>
        internal void Start()
        {
            InvAccCount += 1;
            PluginBase.Logger.LogMessage($"InvisibleBodyItem Start" + InvAccCount);
            InvAccCounter();
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
                InvAccCount += 1;
                PluginBase.Logger.LogMessage($"InvisibleBodyItem On" + InvAccCount);
                InvAccCounter();
        }

        /// <summary>
        /// Disables effect when accessory is hidden
        /// </summary>
        private void OnDisable()
        {
            InvAccCount -= 1;
            PluginBase.Logger.LogMessage($"InvisibleBodyItem Off" + InvAccCount);
            InvAccCounter();
        }

        private void InvAccCounter()
        {
            var chaControl = GetComponentInParent<ChaControl>();
            var charaController = PluginBase.GetController(chaControl); 
            if (InvAccCount > 0)
                charaController.AccVisible = false;
            else
                charaController.AccVisible = true;
        }
    }
}
