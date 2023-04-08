using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace BetterCartHandling
{
    [BepInPlugin(modGUID, modName, modVersion)]
    [BepInProcess("valheim.exe")]
    public class BetterCartHandling : BaseUnityPlugin
    {
        private const string modGUID = "ForshenMod.BetterCartHandling";
        private const string modName = "BetterCartHandling";
        private const string modVersion = "0.0.1";
        private readonly Harmony harmony = new Harmony(modGUID);

        public void Awake()
        {
            harmony.PatchAll();
        }
    }
}
