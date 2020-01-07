﻿using HarmonyLib;
#if AI
using AIChara;
#endif

namespace IllusionMods.InvisibleBody
{
    internal static class Hooks
    {
        /// <summary>
        /// For changing head shape. Also for low poly.
        /// </summary>
        /// <param name="__instance"></param>
        [HarmonyPostfix, HarmonyPatch(typeof(ChaControl), nameof(ChaControl.InitShapeFace))]
        internal static void InitShapeFace(ChaControl __instance) => PluginBase.GetController(__instance).UpdateVisible(true);
    }
}
