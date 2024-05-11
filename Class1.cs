using SDG.Unturned;
using Rocket.Core.Plugins;
using HarmonyLib;

namespace NoCarBoooM
{
    [HarmonyPatch]
    public class Class1 : RocketPlugin
    {
        private static Harmony harmony;

        protected override void Load()
        {
            harmony = new Harmony("com.mymod.nocarboooom");
            harmony.PatchAll();

        }


        [HarmonyPatch(typeof(InteractableVehicle), "explode")]
        [HarmonyPrefix]
        public static bool Prefix(InteractableVehicle __instance)
        {
            return false;
        }
    }
}