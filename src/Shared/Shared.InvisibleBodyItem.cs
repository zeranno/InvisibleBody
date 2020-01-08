using UnityEngine;

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
        }

        /// <summary>
        /// Activates effect when accessory is on. Current effect is just a message.
        /// </summary>
        private void OnEnable()
        {
            PluginBase.Logger.LogMessage($"Test On");
        }

        /// <summary>
        /// Disables effect when accessory is off. Current effect is just a message.
        /// </summary>
        private void OnDisable()
        {
            PluginBase.Logger.LogMessage($"Test Off");
        }
    }
}
