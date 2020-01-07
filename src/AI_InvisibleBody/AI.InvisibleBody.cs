using BepInEx;
using System.Collections.Generic;

namespace IllusionMods.InvisibleBody
{
    [BepInProcess(Constants.MainGameProcessName)]
    [BepInProcess(Constants.StudioProcessName)]
    [BepInDependency(KKAPI.KoikatuAPI.GUID)]
    [BepInDependency(ExtensibleSaveFormat.ExtendedSave.GUID)]
    [BepInPlugin(GUID, PluginName, Version)]
    public class Plugin : PluginBase
    {
        public const string PluginNameInternal = "AI_InvisibleBody";

        internal override HashSet<string> AccessoryAttachPoints => new HashSet<string>() { "N_Waist", "N_Waist_f", "N_Waist_b", "N_Waist_L", "N_Waist_R", "N_Ana", "N_Kokan", "N_Knee_L", "N_Foot_L", "N_Ankle_L", "N_Leg_L", "N_Knee_R", "N_Foot_R", "N_Ankle_R", "N_Leg_R", "N_Dan", "N_Tikubi_L", "N_Tikubi_R", "N_Mouth", "N_Earring_L", "N_Earring_R", "N_Hitai", "N_Head", "N_Head_top", "N_Hair_pin_R", "N_Hair_pin_L", "N_Hair_twin_R", "N_Hair_twin_L", "N_Hair_pony", "N_Nose", "N_Megane", "N_Face", "N_Neck", "N_Elbo_L", "N_Index_L", "N_Middle_L", "N_Ring_L", "N_Hand_L", "N_Wrist_L", "N_Arm_L", "N_Shoulder_L", "N_Elbo_R", "N_Index_R", "N_Middle_R", "N_Ring_R", "N_Hand_R", "N_Wrist_R", "N_Arm_R", "N_Shoulder_R", "N_Chest", "N_Back", "N_Back_R", "N_Back_L", "N_Chest_f" };
        internal override HashSet<string> RendererBlacklist => new HashSet<string>() { "o_ai_mi_pod01h_light00green", "o_ai_mi_pod01h_light00red", "o_ai_mi_pod01h_light00", "o_ai_mi_pod01h_00", "o_ai_mi_pod01k_light00green", "o_ai_mi_pod01k_light00red", "o_ai_mi_pod01k_light00", "o_ai_mi_pod01k_00", "o_ai_mi_pod01s_light01green", "o_ai_mi_pod01s_light01red", "o_ai_mi_pod01s_00", "o_ai_mi_pod01u_00", "anim_ai_mi_pod01_00stu", "o_ai_mi_kasa01_01", "p_ai_mi_kasa00_01", "p_ai_mi_obon00_01", "o_ai_mi_branko00_l", "o_ai_mi_branko00_m", "o_ai_mi_branko00_s", "p_ai_hi_sberi00_00stu", "o_ai_mi_catslang", "Water_jouro", "o_ai_mi_buiya02_00", "p_ai_mi_jouro00_01stu", "p_ai_mi_houki00_01stu", "p_ai_hi_kabeana00_00stu", "p_ai_mi_pickaxe00_00stu", "p_ai_mi_pickaxe01_00stu", "o_ai_mi_ami00a_00", "o_ai_mi_ami00d_00", "p_ai_mi_sao00", "o_ai_hi_idopump02_01", "o_ai_hi_idopump03_01", "o_ai_hi_idopump01_01", "o_ai_hi_idopump00_01" };
    }
}
