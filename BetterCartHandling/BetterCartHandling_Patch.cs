using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace BetterCartHandling
{
    [HarmonyPatch(typeof(Vagon), "Awake")]
    public class BetterCartHandling_Patch
    {
        [HarmonyPrefix]
        public static void SetCartPatch(ref float ___m_itemWeightMassFactor)
        {
            ___m_itemWeightMassFactor = 0;
        }
    }
}
