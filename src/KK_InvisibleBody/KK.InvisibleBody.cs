using BepInEx;
using System.Collections.Generic;

namespace IllusionMods.InvisibleBody
{
    [BepInProcess(Constants.MainGameProcessName)]
    [BepInProcess(Constants.MainGameProcessNameSteam)]
    [BepInProcess(Constants.VRProcessName)]
    [BepInProcess(Constants.VRProcessNameSteam)]
    [BepInProcess(Constants.StudioProcessName)]
    [BepInDependency(KKAPI.KoikatuAPI.GUID)]
    [BepInDependency(ExtensibleSaveFormat.ExtendedSave.GUID)]
    [BepInPlugin(GUID, PluginName, Version)]
    public class Plugin : PluginBase
    {
        internal override HashSet<string> AccessoryAttachPoints => new HashSet<string>() { "a_n_nip_L", "a_n_nip_R", "a_n_shoulder_L", "a_n_arm_L", "a_n_wrist_L", "a_n_hand_L", "a_n_ind_L", "a_n_mid_L", "a_n_ring_L", "a_n_elbo_L", "a_n_shoulder_R", "a_n_arm_R", "a_n_wrist_R", "a_n_hand_R", "a_n_ind_R", "a_n_mid_R", "a_n_ring_R", "a_n_elbo_R", "a_n_mouth", "a_n_hair_pin_R", "a_n_hair_pin", "a_n_hair_pony", "a_n_hair_twin_L", "a_n_hair_twin_R", "a_n_head", "a_n_headflont", "a_n_headside", "a_n_headtop", "a_n_earrings_L", "a_n_earrings_R", "a_n_nose", "a_n_megane", "a_n_neck", "a_n_back", "a_n_back_L", "a_n_back_R", "a_n_bust", "a_n_bust_f", "a_n_ana", "a_n_kokan", "a_n_dan", "a_n_leg_L", "a_n_ankle_L", "a_n_heel_L", "a_n_knee_L", "a_n_leg_R", "a_n_ankle_R", "a_n_heel_R", "a_n_knee_R", "a_n_waist", "a_n_waist_b", "a_n_waist_f", "a_n_waist_L", "a_n_waist_R" };

        public const string PluginNameInternal = "KK_InvisibleBody";
    }
}
