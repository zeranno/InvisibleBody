﻿namespace IllusionMods.InvisibleBody
{
    internal static class Constants
    {
#if AI
        internal const string GameName = "AI Girl";
        internal const string StudioProcessName = "StudioNEOV2";
        internal const string MainGameProcessName = "AI-Syoujyo";
#elif EC
        internal const string GameName = "Emotion Creators";
        internal const string MainGameProcessName = "EmotionCreators";
#elif KK
        internal const string GameName = "Koikatsu";
        internal const string StudioProcessName = "CharaStudio";
        internal const string MainGameProcessName = "Koikatu";
        internal const string MainGameProcessNameSteam = "Koikatsu Party";
        internal const string VRProcessName = "KoikatuVR";
        internal const string VRProcessNameSteam = "Koikatsu Party VR";
#endif
    }
}
