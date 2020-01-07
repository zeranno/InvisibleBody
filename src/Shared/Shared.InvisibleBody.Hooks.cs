﻿using HarmonyLib;
#if AI
using AIChara;
#endif

namespace IllusionMods
{
    public partial class InvisibleBody
    {
        internal static class Hooks
        {
            /// <summary>
            /// For changing head shape. Also for low poly.
            /// </summary>
            /// <param name="__instance"></param>
            [HarmonyPostfix, HarmonyPatch(typeof(ChaControl), nameof(ChaControl.InitShapeFace))]
            internal static void InitShapeFace(ChaControl __instance) => GetController(__instance).UpdateVisible(true);
        }
    }
}
