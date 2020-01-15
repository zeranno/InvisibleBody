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
            var chaControl = GetComponentInParent<ChaControl>();
            var charaController = PluginBase.GetController(chaControl);
            charaController.InvAccCount += 1;
            charaController.InvAccCounter();
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
                charaController.InvAccCount += 1;
                charaController.InvAccCounter();
        }

        /// <summary>
        /// Disables effect when accessory is hidden
        /// </summary>
        private void OnDisable()
        {
            var chaControl = GetComponentInParent<ChaControl>();
            var charaController = PluginBase.GetController(chaControl);
            charaController.InvAccCount -= 1;
            charaController.InvAccCounter();
        }
    }
}
